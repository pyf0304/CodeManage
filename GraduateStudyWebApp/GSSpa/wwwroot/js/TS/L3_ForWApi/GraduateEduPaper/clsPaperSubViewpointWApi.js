/**
* 类名:clsPaperSubViewpointWApi
* 表名:PaperSubViewpoint(01120534)
* 生成代码版本:2022.11.02.1
* 生成日期:2022/11/02 11:46:44
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
        define(["require", "exports", "axios", "../../PubFun/CacheHelper.js", "../../L0_Entity/GraduateEduPaper/clsPaperSubViewpointEN.js", "../../L3_ForWApi/GraduateEduPaper/clsvPaperSubViewpointWApi.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsSysPara4WebApi.js", "../../PubFun/CacheHelper.js", "../../PubFun/jsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.PaperSubViewpoint_GetObjFromJsonObj = exports.PaperSubViewpoint_CopyObjTo = exports.PaperSubViewpoint_GetUniCondStr4Update_SubViewpointId = exports.PaperSubViewpoint_GetUniCondStr4Update_PaperRWId_SubViewpointTypeId_SubViewpointContent = exports.PaperSubViewpoint_GetUniCondStr_SubViewpointId = exports.PaperSubViewpoint_GetUniCondStr_PaperRWId_SubViewpointTypeId_SubViewpointContent = exports.PaperSubViewpoint_GetCombineCondition = exports.PaperSubViewpoint_GetObjByJSONStr = exports.PaperSubViewpoint_GetObjLstByJSONObjLst = exports.PaperSubViewpoint_GetObjLstByJSONStr = exports.PaperSubViewpoint_GetJSONStrByObj = exports.PaperSubViewpoint_CheckProperty4Update = exports.PaperSubViewpoint_CheckPropertyNew = exports.PaperSubViewpoint_ReFreshThisCache = exports.PaperSubViewpoint_ReFreshCache = exports.PaperSubViewpoint_GetWebApiUrl = exports.PaperSubViewpoint_GetMaxStrIdByPrefix = exports.PaperSubViewpoint_GetMaxStrIdAsync = exports.PaperSubViewpoint_GetRecCountByCond_Cache = exports.PaperSubViewpoint_GetRecCountByCondAsync = exports.PaperSubViewpoint_IsExistAsync = exports.PaperSubViewpoint_IsExist_Cache = exports.PaperSubViewpoint_IsExist = exports.PaperSubViewpoint_IsExistRecordAsync = exports.PaperSubViewpoint_IsExistRecord_Cache = exports.PaperSubViewpoint_UpdateWithConditionAsync = exports.PaperSubViewpoint_UpdateRecordAsync = exports.PaperSubViewpoint_AddNewRecordWithReturnKey = exports.PaperSubViewpoint_AddNewRecordWithReturnKeyAsync = exports.PaperSubViewpoint_ReOrderAsync = exports.PaperSubViewpoint_GoBottomAsync = exports.PaperSubViewpoint_DownMoveAsync = exports.PaperSubViewpoint_UpMoveAsync = exports.PaperSubViewpoint_GoTopAsync = exports.PaperSubViewpoint_AddNewRecordWithMaxIdAsync = exports.PaperSubViewpoint_AddNewRecordAsync = exports.PaperSubViewpoint_DelPaperSubViewpointsByCondAsync = exports.PaperSubViewpoint_DelPaperSubViewpointsAsync = exports.PaperSubViewpoint_DelRecordAsync = exports.PaperSubViewpoint_GetObjLstByPagerAsync = exports.PaperSubViewpoint_GetObjLstByPager_Cache = exports.PaperSubViewpoint_GetObjLstByRange = exports.PaperSubViewpoint_GetObjLstByRangeAsync = exports.PaperSubViewpoint_GetTopObjLstAsync = exports.PaperSubViewpoint_GetObjLstBySubViewpointIdLst_Cache = exports.PaperSubViewpoint_GetObjLstBySubViewpointIdLstAsync = exports.PaperSubViewpoint_GetSubObjLst_Cache = exports.PaperSubViewpoint_GetObjLst_PureCache = exports.PaperSubViewpoint_GetObjLst_Cache = exports.PaperSubViewpoint_GetObjLst_sessionStorage_PureCache = exports.PaperSubViewpoint_GetObjLst_sessionStorage = exports.PaperSubViewpoint_GetObjLstAsync = exports.PaperSubViewpoint_GetObjLst_localStorage_PureCache = exports.PaperSubViewpoint_GetObjLst_localStorage = exports.PaperSubViewpoint_GetObjLst_ClientCache = exports.PaperSubViewpoint_GetFirstObjAsync = exports.PaperSubViewpoint_GetFirstID = exports.PaperSubViewpoint_GetFirstIDAsync = exports.PaperSubViewpoint_FilterFunByKey = exports.PaperSubViewpoint_SortFunByKey = exports.PaperSubViewpoint_SortFun_Defa_2Fld = exports.PaperSubViewpoint_SortFun_Defa = exports.PaperSubViewpoint_func = exports.PaperSubViewpoint_UpdateObjInLst_Cache = exports.PaperSubViewpoint_GetObjBySubViewpointId_localStorage = exports.PaperSubViewpoint_GetObjBySubViewpointId_Cache = exports.PaperSubViewpoint_GetObjBySubViewpointIdAsync = exports.paperSubViewpoint_ConstructorName = exports.paperSubViewpoint_Controller = void 0;
    /**
     * 子观点表(PaperSubViewpoint)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2022年11月02日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsPaperSubViewpointEN_js_1 = require("../../L0_Entity/GraduateEduPaper/clsPaperSubViewpointEN.js");
    const clsvPaperSubViewpointWApi_js_1 = require("../../L3_ForWApi/GraduateEduPaper/clsvPaperSubViewpointWApi.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    const CacheHelper_js_2 = require("../../PubFun/CacheHelper.js");
    const jsString_js_1 = require("../../PubFun/jsString.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.paperSubViewpoint_Controller = "PaperSubViewpointApi";
    exports.paperSubViewpoint_ConstructorName = "paperSubViewpoint";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strSubViewpointId:关键字
    * @returns 对象
    **/
    async function PaperSubViewpoint_GetObjBySubViewpointIdAsync(strSubViewpointId) {
        const strThisFuncName = "GetObjBySubViewpointIdAsync";
        if ((0, clsString_js_1.IsNullOrEmpty)(strSubViewpointId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strSubViewpointId]不能为空！(In GetObjBySubViewpointIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strSubViewpointId.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strSubViewpointId]的长度:[{0}]不正确！", strSubViewpointId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjBySubViewpointId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperSubViewpoint_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "strSubViewpointId": strSubViewpointId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.paperSubViewpoint_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objPaperSubViewpoint = PaperSubViewpoint_GetObjFromJsonObj(returnObj);
                return objPaperSubViewpoint;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperSubViewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperSubViewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperSubViewpoint_GetObjBySubViewpointIdAsync = PaperSubViewpoint_GetObjBySubViewpointIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param strSubViewpointId:所给的关键字
     * @returns 对象
    */
    async function PaperSubViewpoint_GetObjBySubViewpointId_Cache(strSubViewpointId, strid_CurrEduCls, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjBySubViewpointId_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strSubViewpointId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strSubViewpointId]不能为空！(In GetObjBySubViewpointId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strSubViewpointId.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strSubViewpointId]的长度:[{0}]不正确！", strSubViewpointId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrPaperSubViewpointObjLst_Cache = await PaperSubViewpoint_GetObjLst_Cache(strid_CurrEduCls);
        try {
            const arrPaperSubViewpoint_Sel = arrPaperSubViewpointObjLst_Cache.filter(x => x.subViewpointId == strSubViewpointId);
            let objPaperSubViewpoint;
            if (arrPaperSubViewpoint_Sel.length > 0) {
                objPaperSubViewpoint = arrPaperSubViewpoint_Sel[0];
                return objPaperSubViewpoint;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    objPaperSubViewpoint = await PaperSubViewpoint_GetObjBySubViewpointIdAsync(strSubViewpointId);
                    if (objPaperSubViewpoint != null) {
                        PaperSubViewpoint_ReFreshThisCache(strid_CurrEduCls);
                        return objPaperSubViewpoint;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strSubViewpointId, exports.paperSubViewpoint_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.PaperSubViewpoint_GetObjBySubViewpointId_Cache = PaperSubViewpoint_GetObjBySubViewpointId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param strSubViewpointId:所给的关键字
     * @returns 对象
    */
    async function PaperSubViewpoint_GetObjBySubViewpointId_localStorage(strSubViewpointId) {
        const strThisFuncName = "GetObjBySubViewpointId_localStorage";
        if ((0, clsString_js_1.IsNullOrEmpty)(strSubViewpointId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strSubViewpointId]不能为空！(In GetObjBySubViewpointId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strSubViewpointId.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strSubViewpointId]的长度:[{0}]不正确！", strSubViewpointId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN._CurrTabName, strSubViewpointId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objPaperSubViewpoint_Cache = JSON.parse(strTempObj);
            return objPaperSubViewpoint_Cache;
        }
        try {
            const objPaperSubViewpoint = await PaperSubViewpoint_GetObjBySubViewpointIdAsync(strSubViewpointId);
            if (objPaperSubViewpoint != null) {
                localStorage.setItem(strKey, JSON.stringify(objPaperSubViewpoint));
                const strInfo = (0, clsString_js_1.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objPaperSubViewpoint;
            }
            return objPaperSubViewpoint;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strSubViewpointId, exports.paperSubViewpoint_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.PaperSubViewpoint_GetObjBySubViewpointId_localStorage = PaperSubViewpoint_GetObjBySubViewpointId_localStorage;
    /**
     * 修改在缓存对象列表中的对象, 与后台数据库无关.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
     * @param objPaperSubViewpoint:所给的对象
     * @returns 对象
    */
    async function PaperSubViewpoint_UpdateObjInLst_Cache(objPaperSubViewpoint, strid_CurrEduCls) {
        const strThisFuncName = "UpdateObjInLst_Cache";
        try {
            const arrPaperSubViewpointObjLst_Cache = await PaperSubViewpoint_GetObjLst_Cache(strid_CurrEduCls);
            const obj = arrPaperSubViewpointObjLst_Cache.find(x => x.subViewpointId == objPaperSubViewpoint.subViewpointId);
            if (obj != null) {
                objPaperSubViewpoint.subViewpointId = obj.subViewpointId;
                (0, clsCommFunc4Web_js_1.ObjectAssign)(obj, objPaperSubViewpoint);
            }
            else {
                arrPaperSubViewpointObjLst_Cache.push(objPaperSubViewpoint);
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, exports.paperSubViewpoint_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.PaperSubViewpoint_UpdateObjInLst_Cache = PaperSubViewpoint_UpdateObjInLst_Cache;
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
    async function PaperSubViewpoint_func(strInFldName, strOutFldName, strInValue, strid_CurrEduCls_C) {
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
        if (strInFldName != clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_SubViewpointId) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_1.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strInFldName, clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strSubViewpointId = strInValue;
        if ((0, clsString_js_1.IsNullOrEmpty)(strInValue) == true) {
            return "";
        }
        const objPaperSubViewpoint = await PaperSubViewpoint_GetObjBySubViewpointId_Cache(strSubViewpointId, strid_CurrEduCls_C);
        if (objPaperSubViewpoint == null)
            return "";
        return objPaperSubViewpoint.GetFldValue(strOutFldName).toString();
    }
    exports.PaperSubViewpoint_func = PaperSubViewpoint_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function PaperSubViewpoint_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.subViewpointId.localeCompare(b.subViewpointId);
    }
    exports.PaperSubViewpoint_SortFun_Defa = PaperSubViewpoint_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function PaperSubViewpoint_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.paperRWId == b.paperRWId)
            return a.paperId.localeCompare(b.paperId);
        else
            return a.paperRWId.localeCompare(b.paperRWId);
    }
    exports.PaperSubViewpoint_SortFun_Defa_2Fld = PaperSubViewpoint_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function PaperSubViewpoint_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_SubViewpointId:
                    return (a, b) => {
                        return a.subViewpointId.localeCompare(b.subViewpointId);
                    };
                case clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_PaperRWId:
                    return (a, b) => {
                        return a.paperRWId.localeCompare(b.paperRWId);
                    };
                case clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_PaperId:
                    return (a, b) => {
                        return a.paperId.localeCompare(b.paperId);
                    };
                case clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_id_CurrEduCls:
                    return (a, b) => {
                        return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
                    };
                case clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_UserId:
                    return (a, b) => {
                        return a.userId.localeCompare(b.userId);
                    };
                case clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_SectionId:
                    return (a, b) => {
                        return a.sectionId.localeCompare(b.sectionId);
                    };
                case clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_SubViewpointTypeId:
                    return (a, b) => {
                        return a.subViewpointTypeId.localeCompare(b.subViewpointTypeId);
                    };
                case clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_RWTitle:
                    return (a, b) => {
                        return a.rwTitle.localeCompare(b.rwTitle);
                    };
                case clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_SubViewpointContent:
                    return (a, b) => {
                        return a.subViewpointContent.localeCompare(b.subViewpointContent);
                    };
                case clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_ExplainTypeId:
                    return (a, b) => {
                        return a.explainTypeId.localeCompare(b.explainTypeId);
                    };
                case clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_ExplainContent:
                    return (a, b) => {
                        return a.explainContent.localeCompare(b.explainContent);
                    };
                case clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_IsPublic:
                    return (a, b) => {
                        if (a.isPublic == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_LiteratureSourcesId:
                    return (a, b) => {
                        return a.literatureSourcesId.localeCompare(b.literatureSourcesId);
                    };
                case clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_PageNumber:
                    return (a, b) => {
                        return a.pageNumber - b.pageNumber;
                    };
                case clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_OrderNum:
                    return (a, b) => {
                        return a.orderNum - b.orderNum;
                    };
                case clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_PaperLineNum:
                    return (a, b) => {
                        return a.paperLineNum - b.paperLineNum;
                    };
                case clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_PaperPageNum:
                    return (a, b) => {
                        return a.paperPageNum - b.paperPageNum;
                    };
                case clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_AppraiseCount:
                    return (a, b) => {
                        return a.appraiseCount - b.appraiseCount;
                    };
                case clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_OkCount:
                    return (a, b) => {
                        return a.okCount - b.okCount;
                    };
                case clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_score:
                    return (a, b) => {
                        return a.score - b.score;
                    };
                case clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_StuScore:
                    return (a, b) => {
                        return a.stuScore - b.stuScore;
                    };
                case clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_TeaScore:
                    return (a, b) => {
                        return a.teaScore - b.teaScore;
                    };
                case clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_CreateDate:
                    return (a, b) => {
                        return a.createDate.localeCompare(b.createDate);
                    };
                case clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_ShareId:
                    return (a, b) => {
                        return a.shareId.localeCompare(b.shareId);
                    };
                case clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_TopicId:
                    return (a, b) => {
                        return a.topicId.localeCompare(b.topicId);
                    };
                case clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_AttitudesId:
                    return (a, b) => {
                        return a.attitudesId.localeCompare(b.attitudesId);
                    };
                case clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_UpdDate:
                    return (a, b) => {
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_UpdUser:
                    return (a, b) => {
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_Memo:
                    return (a, b) => {
                        return a.memo.localeCompare(b.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[PaperSubViewpoint]中不存在！(in ${exports.paperSubViewpoint_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_SubViewpointId:
                    return (a, b) => {
                        return b.subViewpointId.localeCompare(a.subViewpointId);
                    };
                case clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_PaperRWId:
                    return (a, b) => {
                        return b.paperRWId.localeCompare(a.paperRWId);
                    };
                case clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_PaperId:
                    return (a, b) => {
                        return b.paperId.localeCompare(a.paperId);
                    };
                case clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_id_CurrEduCls:
                    return (a, b) => {
                        return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
                    };
                case clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_UserId:
                    return (a, b) => {
                        return b.userId.localeCompare(a.userId);
                    };
                case clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_SectionId:
                    return (a, b) => {
                        return b.sectionId.localeCompare(a.sectionId);
                    };
                case clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_SubViewpointTypeId:
                    return (a, b) => {
                        return b.subViewpointTypeId.localeCompare(a.subViewpointTypeId);
                    };
                case clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_RWTitle:
                    return (a, b) => {
                        return b.rwTitle.localeCompare(a.rwTitle);
                    };
                case clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_SubViewpointContent:
                    return (a, b) => {
                        return b.subViewpointContent.localeCompare(a.subViewpointContent);
                    };
                case clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_ExplainTypeId:
                    return (a, b) => {
                        return b.explainTypeId.localeCompare(a.explainTypeId);
                    };
                case clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_ExplainContent:
                    return (a, b) => {
                        return b.explainContent.localeCompare(a.explainContent);
                    };
                case clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_IsPublic:
                    return (a, b) => {
                        if (b.isPublic == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_LiteratureSourcesId:
                    return (a, b) => {
                        return b.literatureSourcesId.localeCompare(a.literatureSourcesId);
                    };
                case clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_PageNumber:
                    return (a, b) => {
                        return b.pageNumber - a.pageNumber;
                    };
                case clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_OrderNum:
                    return (a, b) => {
                        return b.orderNum - a.orderNum;
                    };
                case clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_PaperLineNum:
                    return (a, b) => {
                        return b.paperLineNum - a.paperLineNum;
                    };
                case clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_PaperPageNum:
                    return (a, b) => {
                        return b.paperPageNum - a.paperPageNum;
                    };
                case clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_AppraiseCount:
                    return (a, b) => {
                        return b.appraiseCount - a.appraiseCount;
                    };
                case clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_OkCount:
                    return (a, b) => {
                        return b.okCount - a.okCount;
                    };
                case clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_score:
                    return (a, b) => {
                        return b.score - a.score;
                    };
                case clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_StuScore:
                    return (a, b) => {
                        return b.stuScore - a.stuScore;
                    };
                case clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_TeaScore:
                    return (a, b) => {
                        return b.teaScore - a.teaScore;
                    };
                case clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_CreateDate:
                    return (a, b) => {
                        return b.createDate.localeCompare(a.createDate);
                    };
                case clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_ShareId:
                    return (a, b) => {
                        return b.shareId.localeCompare(a.shareId);
                    };
                case clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_TopicId:
                    return (a, b) => {
                        return b.topicId.localeCompare(a.topicId);
                    };
                case clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_AttitudesId:
                    return (a, b) => {
                        return b.attitudesId.localeCompare(a.attitudesId);
                    };
                case clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_UpdDate:
                    return (a, b) => {
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_UpdUser:
                    return (a, b) => {
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_Memo:
                    return (a, b) => {
                        return b.memo.localeCompare(a.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[PaperSubViewpoint]中不存在！(in ${exports.paperSubViewpoint_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.PaperSubViewpoint_SortFunByKey = PaperSubViewpoint_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function PaperSubViewpoint_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_SubViewpointId:
                return (obj) => {
                    return obj.subViewpointId === value;
                };
            case clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_PaperRWId:
                return (obj) => {
                    return obj.paperRWId === value;
                };
            case clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_PaperId:
                return (obj) => {
                    return obj.paperId === value;
                };
            case clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_id_CurrEduCls:
                return (obj) => {
                    return obj.id_CurrEduCls === value;
                };
            case clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_UserId:
                return (obj) => {
                    return obj.userId === value;
                };
            case clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_SectionId:
                return (obj) => {
                    return obj.sectionId === value;
                };
            case clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_SubViewpointTypeId:
                return (obj) => {
                    return obj.subViewpointTypeId === value;
                };
            case clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_RWTitle:
                return (obj) => {
                    return obj.rwTitle === value;
                };
            case clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_SubViewpointContent:
                return (obj) => {
                    return obj.subViewpointContent === value;
                };
            case clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_ExplainTypeId:
                return (obj) => {
                    return obj.explainTypeId === value;
                };
            case clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_ExplainContent:
                return (obj) => {
                    return obj.explainContent === value;
                };
            case clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_IsPublic:
                return (obj) => {
                    return obj.isPublic === value;
                };
            case clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_LiteratureSourcesId:
                return (obj) => {
                    return obj.literatureSourcesId === value;
                };
            case clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_PageNumber:
                return (obj) => {
                    return obj.pageNumber === value;
                };
            case clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_OrderNum:
                return (obj) => {
                    return obj.orderNum === value;
                };
            case clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_PaperLineNum:
                return (obj) => {
                    return obj.paperLineNum === value;
                };
            case clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_PaperPageNum:
                return (obj) => {
                    return obj.paperPageNum === value;
                };
            case clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_AppraiseCount:
                return (obj) => {
                    return obj.appraiseCount === value;
                };
            case clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_OkCount:
                return (obj) => {
                    return obj.okCount === value;
                };
            case clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_score:
                return (obj) => {
                    return obj.score === value;
                };
            case clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_StuScore:
                return (obj) => {
                    return obj.stuScore === value;
                };
            case clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_TeaScore:
                return (obj) => {
                    return obj.teaScore === value;
                };
            case clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_CreateDate:
                return (obj) => {
                    return obj.createDate === value;
                };
            case clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_ShareId:
                return (obj) => {
                    return obj.shareId === value;
                };
            case clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_TopicId:
                return (obj) => {
                    return obj.topicId === value;
                };
            case clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_AttitudesId:
                return (obj) => {
                    return obj.attitudesId === value;
                };
            case clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[PaperSubViewpoint]中不存在！(in ${exports.paperSubViewpoint_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.PaperSubViewpoint_FilterFunByKey = PaperSubViewpoint_FilterFunByKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function PaperSubViewpoint_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperSubViewpoint_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperSubViewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperSubViewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperSubViewpoint_GetFirstIDAsync = PaperSubViewpoint_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function PaperSubViewpoint_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperSubViewpoint_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperSubViewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperSubViewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperSubViewpoint_GetFirstID = PaperSubViewpoint_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function PaperSubViewpoint_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperSubViewpoint_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.paperSubViewpoint_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objPaperSubViewpoint = PaperSubViewpoint_GetObjFromJsonObj(returnObj);
                return objPaperSubViewpoint;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperSubViewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperSubViewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperSubViewpoint_GetFirstObjAsync = PaperSubViewpoint_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function PaperSubViewpoint_GetObjLst_ClientCache(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN._CurrTabName, strid_CurrEduCls);
        clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_2.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrPaperSubViewpointExObjLst_Cache = CacheHelper_js_2.CacheHelper.Get(strKey);
            const arrPaperSubViewpointObjLst_T = PaperSubViewpoint_GetObjLstByJSONObjLst(arrPaperSubViewpointExObjLst_Cache);
            return arrPaperSubViewpointObjLst_T;
        }
        try {
            const arrPaperSubViewpointExObjLst = await PaperSubViewpoint_GetObjLstAsync(strWhereCond);
            CacheHelper_js_2.CacheHelper.Add(strKey, arrPaperSubViewpointExObjLst);
            const strInfo = (0, clsString_js_1.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrPaperSubViewpointExObjLst.length);
            console.log(strInfo);
            return arrPaperSubViewpointExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.paperSubViewpoint_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.PaperSubViewpoint_GetObjLst_ClientCache = PaperSubViewpoint_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function PaperSubViewpoint_GetObjLst_localStorage(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN._CurrTabName, strid_CurrEduCls);
        clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrPaperSubViewpointExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrPaperSubViewpointObjLst_T = PaperSubViewpoint_GetObjLstByJSONObjLst(arrPaperSubViewpointExObjLst_Cache);
            return arrPaperSubViewpointObjLst_T;
        }
        try {
            const arrPaperSubViewpointExObjLst = await PaperSubViewpoint_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrPaperSubViewpointExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrPaperSubViewpointExObjLst.length);
            console.log(strInfo);
            return arrPaperSubViewpointExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.paperSubViewpoint_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.PaperSubViewpoint_GetObjLst_localStorage = PaperSubViewpoint_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function PaperSubViewpoint_GetObjLst_localStorage_PureCache(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN._CurrTabName, strid_CurrEduCls);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrPaperSubViewpointObjLst_Cache = JSON.parse(strTempObjLst);
            return arrPaperSubViewpointObjLst_Cache;
        }
        else
            return null;
    }
    exports.PaperSubViewpoint_GetObjLst_localStorage_PureCache = PaperSubViewpoint_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function PaperSubViewpoint_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperSubViewpoint_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.paperSubViewpoint_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = PaperSubViewpoint_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperSubViewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperSubViewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperSubViewpoint_GetObjLstAsync = PaperSubViewpoint_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function PaperSubViewpoint_GetObjLst_sessionStorage(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN._CurrTabName, strid_CurrEduCls);
        clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrPaperSubViewpointExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrPaperSubViewpointObjLst_T = PaperSubViewpoint_GetObjLstByJSONObjLst(arrPaperSubViewpointExObjLst_Cache);
            return arrPaperSubViewpointObjLst_T;
        }
        try {
            const arrPaperSubViewpointExObjLst = await PaperSubViewpoint_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrPaperSubViewpointExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrPaperSubViewpointExObjLst.length);
            console.log(strInfo);
            return arrPaperSubViewpointExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.paperSubViewpoint_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.PaperSubViewpoint_GetObjLst_sessionStorage = PaperSubViewpoint_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function PaperSubViewpoint_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN._CurrTabName, strid_CurrEduCls);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrPaperSubViewpointObjLst_Cache = JSON.parse(strTempObjLst);
            return arrPaperSubViewpointObjLst_Cache;
        }
        else
            return null;
    }
    exports.PaperSubViewpoint_GetObjLst_sessionStorage_PureCache = PaperSubViewpoint_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function PaperSubViewpoint_GetObjLst_Cache(strid_CurrEduCls) {
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
        let arrPaperSubViewpointObjLst_Cache;
        switch (clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.CacheModeId) {
            case "04": //sessionStorage
                arrPaperSubViewpointObjLst_Cache = await PaperSubViewpoint_GetObjLst_sessionStorage(strid_CurrEduCls);
                break;
            case "03": //localStorage
                arrPaperSubViewpointObjLst_Cache = await PaperSubViewpoint_GetObjLst_localStorage(strid_CurrEduCls);
                break;
            case "02": //ClientCache
                arrPaperSubViewpointObjLst_Cache = await PaperSubViewpoint_GetObjLst_ClientCache(strid_CurrEduCls);
                break;
            default:
                arrPaperSubViewpointObjLst_Cache = await PaperSubViewpoint_GetObjLst_ClientCache(strid_CurrEduCls);
                break;
        }
        const arrPaperSubViewpointObjLst = PaperSubViewpoint_GetObjLstByJSONObjLst(arrPaperSubViewpointObjLst_Cache);
        return arrPaperSubViewpointObjLst_Cache;
    }
    exports.PaperSubViewpoint_GetObjLst_Cache = PaperSubViewpoint_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function PaperSubViewpoint_GetObjLst_PureCache(strid_CurrEduCls) {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrPaperSubViewpointObjLst_Cache;
        switch (clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.CacheModeId) {
            case "04": //sessionStorage
                arrPaperSubViewpointObjLst_Cache = await PaperSubViewpoint_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls);
                break;
            case "03": //localStorage
                arrPaperSubViewpointObjLst_Cache = await PaperSubViewpoint_GetObjLst_localStorage_PureCache(strid_CurrEduCls);
                break;
            case "02": //ClientCache
                arrPaperSubViewpointObjLst_Cache = null;
                break;
            default:
                arrPaperSubViewpointObjLst_Cache = null;
                break;
        }
        return arrPaperSubViewpointObjLst_Cache;
    }
    exports.PaperSubViewpoint_GetObjLst_PureCache = PaperSubViewpoint_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objstrSubViewpointId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function PaperSubViewpoint_GetSubObjLst_Cache(objPaperSubViewpoint_Cond, strid_CurrEduCls) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrPaperSubViewpointObjLst_Cache = await PaperSubViewpoint_GetObjLst_Cache(strid_CurrEduCls);
        let arrPaperSubViewpoint_Sel = arrPaperSubViewpointObjLst_Cache;
        if (objPaperSubViewpoint_Cond.sf_FldComparisonOp == null || objPaperSubViewpoint_Cond.sf_FldComparisonOp == "")
            return arrPaperSubViewpoint_Sel;
        const dicFldComparisonOp = JSON.parse(objPaperSubViewpoint_Cond.sf_FldComparisonOp);
        //console.log("clsPaperSubViewpointWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objPaperSubViewpoint_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objPaperSubViewpoint_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrPaperSubViewpoint_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objPaperSubViewpoint_Cond), exports.paperSubViewpoint_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.PaperSubViewpoint_GetSubObjLst_Cache = PaperSubViewpoint_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrSubViewpointId:关键字列表
    * @returns 对象列表
    **/
    async function PaperSubViewpoint_GetObjLstBySubViewpointIdLstAsync(arrSubViewpointId) {
        const strThisFuncName = "GetObjLstBySubViewpointIdLstAsync";
        const strAction = "GetObjLstBySubViewpointIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperSubViewpoint_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrSubViewpointId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.paperSubViewpoint_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = PaperSubViewpoint_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperSubViewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperSubViewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperSubViewpoint_GetObjLstBySubViewpointIdLstAsync = PaperSubViewpoint_GetObjLstBySubViewpointIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrstrSubViewpointIdLst:关键字列表
     * @returns 对象列表
    */
    async function PaperSubViewpoint_GetObjLstBySubViewpointIdLst_Cache(arrSubViewpointIdLst, strid_CurrEduCls) {
        const strThisFuncName = "GetObjLstBySubViewpointIdLst_Cache";
        try {
            const arrPaperSubViewpointObjLst_Cache = await PaperSubViewpoint_GetObjLst_Cache(strid_CurrEduCls);
            const arrPaperSubViewpoint_Sel = arrPaperSubViewpointObjLst_Cache.filter(x => arrSubViewpointIdLst.indexOf(x.subViewpointId) > -1);
            return arrPaperSubViewpoint_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrSubViewpointIdLst.join(","), exports.paperSubViewpoint_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.PaperSubViewpoint_GetObjLstBySubViewpointIdLst_Cache = PaperSubViewpoint_GetObjLstBySubViewpointIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function PaperSubViewpoint_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperSubViewpoint_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.paperSubViewpoint_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = PaperSubViewpoint_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperSubViewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperSubViewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperSubViewpoint_GetTopObjLstAsync = PaperSubViewpoint_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function PaperSubViewpoint_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperSubViewpoint_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.paperSubViewpoint_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = PaperSubViewpoint_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperSubViewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperSubViewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperSubViewpoint_GetObjLstByRangeAsync = PaperSubViewpoint_GetObjLstByRangeAsync;
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
    async function PaperSubViewpoint_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperSubViewpoint_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperSubViewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperSubViewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperSubViewpoint_GetObjLstByRange = PaperSubViewpoint_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function PaperSubViewpoint_GetObjLstByPager_Cache(objPagerPara, strid_CurrEduCls) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const arrPaperSubViewpointObjLst_Cache = await PaperSubViewpoint_GetObjLst_Cache(strid_CurrEduCls);
        if (arrPaperSubViewpointObjLst_Cache.length == 0)
            return arrPaperSubViewpointObjLst_Cache;
        let arrPaperSubViewpoint_Sel = arrPaperSubViewpointObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objPaperSubViewpoint_Cond = new clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objPaperSubViewpoint_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsPaperSubViewpointWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objPaperSubViewpoint_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrPaperSubViewpoint_Sel.length == 0)
                return arrPaperSubViewpoint_Sel;
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
                arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.sort(PaperSubViewpoint_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.sort(objPagerPara.sortFun);
            }
            arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.slice(intStart, intEnd);
            return arrPaperSubViewpoint_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.paperSubViewpoint_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.PaperSubViewpoint_GetObjLstByPager_Cache = PaperSubViewpoint_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function PaperSubViewpoint_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperSubViewpoint_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.paperSubViewpoint_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = PaperSubViewpoint_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperSubViewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperSubViewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperSubViewpoint_GetObjLstByPagerAsync = PaperSubViewpoint_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param strSubViewpointId:关键字
    * @returns 获取删除的结果
    **/
    async function PaperSubViewpoint_DelRecordAsync(strSubViewpointId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperSubViewpoint_Controller, strAction);
        strUrl = (0, clsString_js_1.Format)("{0}/?Id={1}", strUrl, strSubViewpointId);
        try {
            const response = await axios_1.default.delete(strUrl, {
                params: { "Id": strSubViewpointId, }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperSubViewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperSubViewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperSubViewpoint_DelRecordAsync = PaperSubViewpoint_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrSubViewpointId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function PaperSubViewpoint_DelPaperSubViewpointsAsync(arrSubViewpointId) {
        const strThisFuncName = "DelPaperSubViewpointsAsync";
        const strAction = "DelPaperSubViewpoints";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperSubViewpoint_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrSubViewpointId);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperSubViewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperSubViewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperSubViewpoint_DelPaperSubViewpointsAsync = PaperSubViewpoint_DelPaperSubViewpointsAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function PaperSubViewpoint_DelPaperSubViewpointsByCondAsync(strWhereCond) {
        const strThisFuncName = "DelPaperSubViewpointsByCondAsync";
        const strAction = "DelPaperSubViewpointsByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperSubViewpoint_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperSubViewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperSubViewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperSubViewpoint_DelPaperSubViewpointsByCondAsync = PaperSubViewpoint_DelPaperSubViewpointsByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objPaperSubViewpointEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function PaperSubViewpoint_AddNewRecordAsync(objPaperSubViewpointEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objPaperSubViewpointEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperSubViewpoint_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPaperSubViewpointEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperSubViewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperSubViewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperSubViewpoint_AddNewRecordAsync = PaperSubViewpoint_AddNewRecordAsync;
    /**
    * 调用WebApi来添加记录，关键字用最大关键字，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithMaxIdAsync)
    * @param objPaperSubViewpointEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function PaperSubViewpoint_AddNewRecordWithMaxIdAsync(objPaperSubViewpointEN) {
        const strThisFuncName = "AddNewRecordWithMaxIdAsync";
        const strAction = "AddNewRecordWithMaxId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperSubViewpoint_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPaperSubViewpointEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperSubViewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperSubViewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperSubViewpoint_AddNewRecordWithMaxIdAsync = PaperSubViewpoint_AddNewRecordWithMaxIdAsync;
    /**
    * 把所给的关键字列表相关的记录移顶
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GoTopAsync)
    * @param objPaperSubViewpointEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function PaperSubViewpoint_GoTopAsync(objOrderByData) {
        const strThisFuncName = "GoTopAsync";
        let strMsg = "";
        const strAction = "GoTop";
        if (objOrderByData.KeyIdLst.length == 0) {
            strMsg = "根据关键字列表置顶时，给定的关键字值列表不能为空!";
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperSubViewpoint_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperSubViewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperSubViewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperSubViewpoint_GoTopAsync = PaperSubViewpoint_GoTopAsync;
    /**
    * 把所给的关键字列表相关的记录上移
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpMoveAsync)
    * @param objPaperSubViewpointEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function PaperSubViewpoint_UpMoveAsync(objOrderByData) {
        const strThisFuncName = "UpMoveAsync";
        let strMsg = "";
        const strAction = "UpMove";
        if (objOrderByData.KeyIdLst.length == 0) {
            strMsg = "根据关键字列表上移时，给定的关键字值列表不能为空!";
            throw strMsg;
        }
        //var strJSON = JSON.stringify(objPaperSubViewpointEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperSubViewpoint_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperSubViewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperSubViewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperSubViewpoint_UpMoveAsync = PaperSubViewpoint_UpMoveAsync;
    /**
    * 把所给的关键字列表相关的记录下移
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DownMoveAsync)
    * @param objPaperSubViewpointEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function PaperSubViewpoint_DownMoveAsync(objOrderByData) {
        const strThisFuncName = "DownMoveAsync";
        let strMsg = "";
        const strAction = "DownMove";
        if (objOrderByData.KeyIdLst.length == 0) {
            strMsg = "根据关键字列表下移时，给定的关键字值列表不能为空!";
            throw strMsg;
        }
        //var strJSON = JSON.stringify(objPaperSubViewpointEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperSubViewpoint_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperSubViewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperSubViewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperSubViewpoint_DownMoveAsync = PaperSubViewpoint_DownMoveAsync;
    /**
    * 把所给的关键字列表相关的记录移底
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GoBottomAsync)
    * @param objPaperSubViewpointEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function PaperSubViewpoint_GoBottomAsync(objOrderByData) {
        const strThisFuncName = "GoBottomAsync";
        let strMsg = "";
        const strAction = "GoBottom";
        if (objOrderByData.KeyIdLst.length == 0) {
            strMsg = "根据关键字列表置底时，给定的关键字值列表不能为空!";
            throw strMsg;
        }
        //var strJSON = JSON.stringify(objPaperSubViewpointEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperSubViewpoint_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperSubViewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperSubViewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperSubViewpoint_GoBottomAsync = PaperSubViewpoint_GoBottomAsync;
    /**
    * 把列表记录重序
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReOrderAsync)
    * @param objPaperSubViewpointEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function PaperSubViewpoint_ReOrderAsync(objOrderByData) {
        const strThisFuncName = "ReOrderAsync";
        const strAction = "ReOrder";
        //var strJSON = JSON.stringify(objPaperSubViewpointEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperSubViewpoint_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperSubViewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperSubViewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperSubViewpoint_ReOrderAsync = PaperSubViewpoint_ReOrderAsync;
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objPaperSubViewpointEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function PaperSubViewpoint_AddNewRecordWithReturnKeyAsync(objPaperSubViewpointEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperSubViewpoint_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPaperSubViewpointEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperSubViewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperSubViewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperSubViewpoint_AddNewRecordWithReturnKeyAsync = PaperSubViewpoint_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objPaperSubViewpointEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function PaperSubViewpoint_AddNewRecordWithReturnKey(objPaperSubViewpointEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objPaperSubViewpointEN.subViewpointId === null || objPaperSubViewpointEN.subViewpointId === "") {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperSubViewpoint_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPaperSubViewpointEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperSubViewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperSubViewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperSubViewpoint_AddNewRecordWithReturnKey = PaperSubViewpoint_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objPaperSubViewpointEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function PaperSubViewpoint_UpdateRecordAsync(objPaperSubViewpointEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objPaperSubViewpointEN.sf_UpdFldSetStr === undefined || objPaperSubViewpointEN.sf_UpdFldSetStr === null || objPaperSubViewpointEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objPaperSubViewpointEN.subViewpointId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperSubViewpoint_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPaperSubViewpointEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperSubViewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperSubViewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperSubViewpoint_UpdateRecordAsync = PaperSubViewpoint_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objPaperSubViewpointEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function PaperSubViewpoint_UpdateWithConditionAsync(objPaperSubViewpointEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objPaperSubViewpointEN.sf_UpdFldSetStr === undefined || objPaperSubViewpointEN.sf_UpdFldSetStr === null || objPaperSubViewpointEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objPaperSubViewpointEN.subViewpointId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperSubViewpoint_Controller, strAction);
        objPaperSubViewpointEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objPaperSubViewpointEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperSubViewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperSubViewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperSubViewpoint_UpdateWithConditionAsync = PaperSubViewpoint_UpdateWithConditionAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objstrSubViewpointId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function PaperSubViewpoint_IsExistRecord_Cache(objPaperSubViewpoint_Cond, strid_CurrEduCls) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrPaperSubViewpointObjLst_Cache = await PaperSubViewpoint_GetObjLst_Cache(strid_CurrEduCls);
        if (arrPaperSubViewpointObjLst_Cache == null)
            return false;
        let arrPaperSubViewpoint_Sel = arrPaperSubViewpointObjLst_Cache;
        if (objPaperSubViewpoint_Cond.sf_FldComparisonOp == null || objPaperSubViewpoint_Cond.sf_FldComparisonOp == "")
            return arrPaperSubViewpoint_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objPaperSubViewpoint_Cond.sf_FldComparisonOp);
        //console.log("clsPaperSubViewpointWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objPaperSubViewpoint_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objPaperSubViewpoint_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrPaperSubViewpoint_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objPaperSubViewpoint_Cond), exports.paperSubViewpoint_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.PaperSubViewpoint_IsExistRecord_Cache = PaperSubViewpoint_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function PaperSubViewpoint_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperSubViewpoint_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperSubViewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperSubViewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperSubViewpoint_IsExistRecordAsync = PaperSubViewpoint_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strSubViewpointId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function PaperSubViewpoint_IsExist(strSubViewpointId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperSubViewpoint_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "SubViewpointId": strSubViewpointId,
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperSubViewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperSubViewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperSubViewpoint_IsExist = PaperSubViewpoint_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param strSubViewpointId:所给的关键字
     * @returns 对象
    */
    async function PaperSubViewpoint_IsExist_Cache(strSubViewpointId, strid_CurrEduCls) {
        const strThisFuncName = "IsExist_Cache";
        const arrPaperSubViewpointObjLst_Cache = await PaperSubViewpoint_GetObjLst_Cache(strid_CurrEduCls);
        if (arrPaperSubViewpointObjLst_Cache == null)
            return false;
        try {
            const arrPaperSubViewpoint_Sel = arrPaperSubViewpointObjLst_Cache.filter(x => x.subViewpointId == strSubViewpointId);
            if (arrPaperSubViewpoint_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strSubViewpointId, exports.paperSubViewpoint_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.PaperSubViewpoint_IsExist_Cache = PaperSubViewpoint_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strSubViewpointId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function PaperSubViewpoint_IsExistAsync(strSubViewpointId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperSubViewpoint_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strSubViewpointId": strSubViewpointId }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperSubViewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperSubViewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperSubViewpoint_IsExistAsync = PaperSubViewpoint_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function PaperSubViewpoint_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperSubViewpoint_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperSubViewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperSubViewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperSubViewpoint_GetRecCountByCondAsync = PaperSubViewpoint_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objPaperSubViewpoint_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function PaperSubViewpoint_GetRecCountByCond_Cache(objPaperSubViewpoint_Cond, strid_CurrEduCls) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrPaperSubViewpointObjLst_Cache = await PaperSubViewpoint_GetObjLst_Cache(strid_CurrEduCls);
        if (arrPaperSubViewpointObjLst_Cache == null)
            return 0;
        let arrPaperSubViewpoint_Sel = arrPaperSubViewpointObjLst_Cache;
        if (objPaperSubViewpoint_Cond.sf_FldComparisonOp == null || objPaperSubViewpoint_Cond.sf_FldComparisonOp == "")
            return arrPaperSubViewpoint_Sel.length;
        const dicFldComparisonOp = JSON.parse(objPaperSubViewpoint_Cond.sf_FldComparisonOp);
        //console.log("clsPaperSubViewpointWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objPaperSubViewpoint_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objPaperSubViewpoint_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrPaperSubViewpoint_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objPaperSubViewpoint_Cond), exports.paperSubViewpoint_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.PaperSubViewpoint_GetRecCountByCond_Cache = PaperSubViewpoint_GetRecCountByCond_Cache;
    /**
    * 获取表的最大关键字
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdAsync)
    * @returns 获取表的最大关键字
    **/
    async function PaperSubViewpoint_GetMaxStrIdAsync() {
        const strThisFuncName = "GetMaxStrIdAsync";
        const strAction = "GetMaxStrId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperSubViewpoint_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperSubViewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperSubViewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperSubViewpoint_GetMaxStrIdAsync = PaperSubViewpoint_GetMaxStrIdAsync;
    /*该表的关键字类型不是字符型带前缀自增，不需要生成获取最大关键字函数！*/
    /**
     * 根据前缀获取当前表关键字值的最大值,再加1,避免重复
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdByPrefix)
     * @param mapParam:参数列表
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 获取当前表关键字值的最大值
    */
    async function PaperSubViewpoint_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperSubViewpoint_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperSubViewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperSubViewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperSubViewpoint_GetMaxStrIdByPrefix = PaperSubViewpoint_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function PaperSubViewpoint_GetWebApiUrl(strController, strAction) {
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
    exports.PaperSubViewpoint_GetWebApiUrl = PaperSubViewpoint_GetWebApiUrl;
    /**
    * 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshCache)
    **/
    function PaperSubViewpoint_ReFreshCache(strid_CurrEduCls) {
        const strThisFuncName = "ReFreshCache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strid_CurrEduCls) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strid_CurrEduCls]不能为空！(In clsPaperSubViewpointWApi.ReFreshCache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strid_CurrEduCls]的长度:[{0}]不正确！", strid_CurrEduCls.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strMsg = (0, clsString_js_1.Format)("刷新缓存成功！");
        console.trace(strMsg);
        // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN._CurrTabName, strid_CurrEduCls);
        switch (clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.CacheModeId) {
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
        (0, clsvPaperSubViewpointWApi_js_1.vPaperSubViewpoint_ReFreshThisCache)(strid_CurrEduCls);
    }
    exports.PaperSubViewpoint_ReFreshCache = PaperSubViewpoint_ReFreshCache;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function PaperSubViewpoint_ReFreshThisCache(strid_CurrEduCls) {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN._CurrTabName, strid_CurrEduCls);
            switch (clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.CacheModeId) {
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
    exports.PaperSubViewpoint_ReFreshThisCache = PaperSubViewpoint_ReFreshThisCache;
    /* 该表的下拉框功能没有设置，不需要生成下拉框绑定函数。*/
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function PaperSubViewpoint_CheckPropertyNew(pobjPaperSubViewpointEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperSubViewpointEN.paperRWId) === true) {
            throw new Error("(errid:Watl000058)字段[课文阅读]不能为空(In 子观点表)!(clsPaperSubViewpointBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperSubViewpointEN.paperId) === true
            || pobjPaperSubViewpointEN.paperId.toString() === "0") {
            throw new Error("(errid:Watl000058)字段[论文Id]不能为空(In 子观点表)!(clsPaperSubViewpointBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperSubViewpointEN.id_CurrEduCls) === true
            || pobjPaperSubViewpointEN.id_CurrEduCls.toString() === "0") {
            throw new Error("(errid:Watl000058)字段[教学班流水号]不能为空(In 子观点表)!(clsPaperSubViewpointBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperSubViewpointEN.userId) === true) {
            throw new Error("(errid:Watl000058)字段[用户ID]不能为空(In 子观点表)!(clsPaperSubViewpointBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperSubViewpointEN.subViewpointTypeId) === true
            || pobjPaperSubViewpointEN.subViewpointTypeId.toString() === "0") {
            throw new Error("(errid:Watl000058)字段[类型Id]不能为空(In 子观点表)!(clsPaperSubViewpointBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperSubViewpointEN.shareId) === true) {
            throw new Error("(errid:Watl000058)字段[分享Id]不能为空(In 子观点表)!(clsPaperSubViewpointBL:CheckPropertyNew)");
        }
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperSubViewpointEN.subViewpointId) == false && (0, clsString_js_1.GetStrLen)(pobjPaperSubViewpointEN.subViewpointId) > 8) {
            throw new Error("(errid:Watl000059)字段[子观点Id(subViewpointId)]的长度不能超过8(In 子观点表(PaperSubViewpoint))!值:$(pobjPaperSubViewpointEN.subViewpointId)(clsPaperSubViewpointBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperSubViewpointEN.paperRWId) == false && (0, clsString_js_1.GetStrLen)(pobjPaperSubViewpointEN.paperRWId) > 8) {
            throw new Error("(errid:Watl000059)字段[课文阅读(paperRWId)]的长度不能超过8(In 子观点表(PaperSubViewpoint))!值:$(pobjPaperSubViewpointEN.paperRWId)(clsPaperSubViewpointBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperSubViewpointEN.paperId) == false && (0, clsString_js_1.GetStrLen)(pobjPaperSubViewpointEN.paperId) > 8) {
            throw new Error("(errid:Watl000059)字段[论文Id(paperId)]的长度不能超过8(In 子观点表(PaperSubViewpoint))!值:$(pobjPaperSubViewpointEN.paperId)(clsPaperSubViewpointBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperSubViewpointEN.id_CurrEduCls) == false && (0, clsString_js_1.GetStrLen)(pobjPaperSubViewpointEN.id_CurrEduCls) > 8) {
            throw new Error("(errid:Watl000059)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 子观点表(PaperSubViewpoint))!值:$(pobjPaperSubViewpointEN.id_CurrEduCls)(clsPaperSubViewpointBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperSubViewpointEN.userId) == false && (0, clsString_js_1.GetStrLen)(pobjPaperSubViewpointEN.userId) > 20) {
            throw new Error("(errid:Watl000059)字段[用户ID(userId)]的长度不能超过20(In 子观点表(PaperSubViewpoint))!值:$(pobjPaperSubViewpointEN.userId)(clsPaperSubViewpointBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperSubViewpointEN.sectionId) == false && (0, clsString_js_1.GetStrLen)(pobjPaperSubViewpointEN.sectionId) > 8) {
            throw new Error("(errid:Watl000059)字段[节Id(sectionId)]的长度不能超过8(In 子观点表(PaperSubViewpoint))!值:$(pobjPaperSubViewpointEN.sectionId)(clsPaperSubViewpointBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperSubViewpointEN.subViewpointTypeId) == false && (0, clsString_js_1.GetStrLen)(pobjPaperSubViewpointEN.subViewpointTypeId) > 8) {
            throw new Error("(errid:Watl000059)字段[类型Id(subViewpointTypeId)]的长度不能超过8(In 子观点表(PaperSubViewpoint))!值:$(pobjPaperSubViewpointEN.subViewpointTypeId)(clsPaperSubViewpointBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperSubViewpointEN.rwTitle) == false && (0, clsString_js_1.GetStrLen)(pobjPaperSubViewpointEN.rwTitle) > 50) {
            throw new Error("(errid:Watl000059)字段[读写标题(rwTitle)]的长度不能超过50(In 子观点表(PaperSubViewpoint))!值:$(pobjPaperSubViewpointEN.rwTitle)(clsPaperSubViewpointBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperSubViewpointEN.explainTypeId) == false && (0, clsString_js_1.GetStrLen)(pobjPaperSubViewpointEN.explainTypeId) > 2) {
            throw new Error("(errid:Watl000059)字段[说明类型Id(explainTypeId)]的长度不能超过2(In 子观点表(PaperSubViewpoint))!值:$(pobjPaperSubViewpointEN.explainTypeId)(clsPaperSubViewpointBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperSubViewpointEN.explainContent) == false && (0, clsString_js_1.GetStrLen)(pobjPaperSubViewpointEN.explainContent) > 5000) {
            throw new Error("(errid:Watl000059)字段[说明内容(explainContent)]的长度不能超过5000(In 子观点表(PaperSubViewpoint))!值:$(pobjPaperSubViewpointEN.explainContent)(clsPaperSubViewpointBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperSubViewpointEN.literatureSourcesId) == false && (0, clsString_js_1.GetStrLen)(pobjPaperSubViewpointEN.literatureSourcesId) > 8) {
            throw new Error("(errid:Watl000059)字段[文献来源(literatureSourcesId)]的长度不能超过8(In 子观点表(PaperSubViewpoint))!值:$(pobjPaperSubViewpointEN.literatureSourcesId)(clsPaperSubViewpointBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperSubViewpointEN.createDate) == false && (0, clsString_js_1.GetStrLen)(pobjPaperSubViewpointEN.createDate) > 20) {
            throw new Error("(errid:Watl000059)字段[建立日期(createDate)]的长度不能超过20(In 子观点表(PaperSubViewpoint))!值:$(pobjPaperSubViewpointEN.createDate)(clsPaperSubViewpointBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperSubViewpointEN.shareId) == false && (0, clsString_js_1.GetStrLen)(pobjPaperSubViewpointEN.shareId) > 2) {
            throw new Error("(errid:Watl000059)字段[分享Id(shareId)]的长度不能超过2(In 子观点表(PaperSubViewpoint))!值:$(pobjPaperSubViewpointEN.shareId)(clsPaperSubViewpointBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperSubViewpointEN.topicId) == false && (0, clsString_js_1.GetStrLen)(pobjPaperSubViewpointEN.topicId) > 8) {
            throw new Error("(errid:Watl000059)字段[主题Id(topicId)]的长度不能超过8(In 子观点表(PaperSubViewpoint))!值:$(pobjPaperSubViewpointEN.topicId)(clsPaperSubViewpointBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperSubViewpointEN.attitudesId) == false && (0, clsString_js_1.GetStrLen)(pobjPaperSubViewpointEN.attitudesId) > 2) {
            throw new Error("(errid:Watl000059)字段[态度Id(attitudesId)]的长度不能超过2(In 子观点表(PaperSubViewpoint))!值:$(pobjPaperSubViewpointEN.attitudesId)(clsPaperSubViewpointBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperSubViewpointEN.updDate) == false && (0, clsString_js_1.GetStrLen)(pobjPaperSubViewpointEN.updDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 子观点表(PaperSubViewpoint))!值:$(pobjPaperSubViewpointEN.updDate)(clsPaperSubViewpointBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperSubViewpointEN.updUser) == false && (0, clsString_js_1.GetStrLen)(pobjPaperSubViewpointEN.updUser) > 20) {
            throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 子观点表(PaperSubViewpoint))!值:$(pobjPaperSubViewpointEN.updUser)(clsPaperSubViewpointBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperSubViewpointEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjPaperSubViewpointEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 子观点表(PaperSubViewpoint))!值:$(pobjPaperSubViewpointEN.memo)(clsPaperSubViewpointBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperSubViewpointEN.subViewpointId) == false && undefined !== pobjPaperSubViewpointEN.subViewpointId && jsString_js_1.tzDataType.isString(pobjPaperSubViewpointEN.subViewpointId) === false) {
            throw new Error("(errid:Watl000060)字段[子观点Id(subViewpointId)]的值:[$(pobjPaperSubViewpointEN.subViewpointId)], 非法，应该为字符型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperSubViewpointEN.paperRWId) == false && undefined !== pobjPaperSubViewpointEN.paperRWId && jsString_js_1.tzDataType.isString(pobjPaperSubViewpointEN.paperRWId) === false) {
            throw new Error("(errid:Watl000060)字段[课文阅读(paperRWId)]的值:[$(pobjPaperSubViewpointEN.paperRWId)], 非法，应该为字符型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperSubViewpointEN.paperId) == false && undefined !== pobjPaperSubViewpointEN.paperId && jsString_js_1.tzDataType.isString(pobjPaperSubViewpointEN.paperId) === false) {
            throw new Error("(errid:Watl000060)字段[论文Id(paperId)]的值:[$(pobjPaperSubViewpointEN.paperId)], 非法，应该为字符型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperSubViewpointEN.id_CurrEduCls) == false && undefined !== pobjPaperSubViewpointEN.id_CurrEduCls && jsString_js_1.tzDataType.isString(pobjPaperSubViewpointEN.id_CurrEduCls) === false) {
            throw new Error("(errid:Watl000060)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjPaperSubViewpointEN.id_CurrEduCls)], 非法，应该为字符型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperSubViewpointEN.userId) == false && undefined !== pobjPaperSubViewpointEN.userId && jsString_js_1.tzDataType.isString(pobjPaperSubViewpointEN.userId) === false) {
            throw new Error("(errid:Watl000060)字段[用户ID(userId)]的值:[$(pobjPaperSubViewpointEN.userId)], 非法，应该为字符型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperSubViewpointEN.sectionId) == false && undefined !== pobjPaperSubViewpointEN.sectionId && jsString_js_1.tzDataType.isString(pobjPaperSubViewpointEN.sectionId) === false) {
            throw new Error("(errid:Watl000060)字段[节Id(sectionId)]的值:[$(pobjPaperSubViewpointEN.sectionId)], 非法，应该为字符型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperSubViewpointEN.subViewpointTypeId) == false && undefined !== pobjPaperSubViewpointEN.subViewpointTypeId && jsString_js_1.tzDataType.isString(pobjPaperSubViewpointEN.subViewpointTypeId) === false) {
            throw new Error("(errid:Watl000060)字段[类型Id(subViewpointTypeId)]的值:[$(pobjPaperSubViewpointEN.subViewpointTypeId)], 非法，应该为字符型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperSubViewpointEN.rwTitle) == false && undefined !== pobjPaperSubViewpointEN.rwTitle && jsString_js_1.tzDataType.isString(pobjPaperSubViewpointEN.rwTitle) === false) {
            throw new Error("(errid:Watl000060)字段[读写标题(rwTitle)]的值:[$(pobjPaperSubViewpointEN.rwTitle)], 非法，应该为字符型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperSubViewpointEN.subViewpointContent) == false && undefined !== pobjPaperSubViewpointEN.subViewpointContent && jsString_js_1.tzDataType.isString(pobjPaperSubViewpointEN.subViewpointContent) === false) {
            throw new Error("(errid:Watl000060)字段[详情内容(subViewpointContent)]的值:[$(pobjPaperSubViewpointEN.subViewpointContent)], 非法，应该为字符型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperSubViewpointEN.explainTypeId) == false && undefined !== pobjPaperSubViewpointEN.explainTypeId && jsString_js_1.tzDataType.isString(pobjPaperSubViewpointEN.explainTypeId) === false) {
            throw new Error("(errid:Watl000060)字段[说明类型Id(explainTypeId)]的值:[$(pobjPaperSubViewpointEN.explainTypeId)], 非法，应该为字符型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperSubViewpointEN.explainContent) == false && undefined !== pobjPaperSubViewpointEN.explainContent && jsString_js_1.tzDataType.isString(pobjPaperSubViewpointEN.explainContent) === false) {
            throw new Error("(errid:Watl000060)字段[说明内容(explainContent)]的值:[$(pobjPaperSubViewpointEN.explainContent)], 非法，应该为字符型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckPropertyNew)");
        }
        if (null != pobjPaperSubViewpointEN.isPublic && undefined !== pobjPaperSubViewpointEN.isPublic && jsString_js_1.tzDataType.isBoolean(pobjPaperSubViewpointEN.isPublic) === false) {
            throw new Error("(errid:Watl000060)字段[是否公开(isPublic)]的值:[$(pobjPaperSubViewpointEN.isPublic)], 非法，应该为布尔型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperSubViewpointEN.literatureSourcesId) == false && undefined !== pobjPaperSubViewpointEN.literatureSourcesId && jsString_js_1.tzDataType.isString(pobjPaperSubViewpointEN.literatureSourcesId) === false) {
            throw new Error("(errid:Watl000060)字段[文献来源(literatureSourcesId)]的值:[$(pobjPaperSubViewpointEN.literatureSourcesId)], 非法，应该为字符型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckPropertyNew)");
        }
        if (null != pobjPaperSubViewpointEN.pageNumber && undefined !== pobjPaperSubViewpointEN.pageNumber && jsString_js_1.tzDataType.isNumber(pobjPaperSubViewpointEN.pageNumber) === false) {
            throw new Error("(errid:Watl000060)字段[页码(pageNumber)]的值:[$(pobjPaperSubViewpointEN.pageNumber)], 非法，应该为数值型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckPropertyNew)");
        }
        if (null != pobjPaperSubViewpointEN.orderNum && undefined !== pobjPaperSubViewpointEN.orderNum && jsString_js_1.tzDataType.isNumber(pobjPaperSubViewpointEN.orderNum) === false) {
            throw new Error("(errid:Watl000060)字段[序号(orderNum)]的值:[$(pobjPaperSubViewpointEN.orderNum)], 非法，应该为数值型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckPropertyNew)");
        }
        if (null != pobjPaperSubViewpointEN.paperLineNum && undefined !== pobjPaperSubViewpointEN.paperLineNum && jsString_js_1.tzDataType.isNumber(pobjPaperSubViewpointEN.paperLineNum) === false) {
            throw new Error("(errid:Watl000060)字段[论文行号(paperLineNum)]的值:[$(pobjPaperSubViewpointEN.paperLineNum)], 非法，应该为数值型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckPropertyNew)");
        }
        if (null != pobjPaperSubViewpointEN.paperPageNum && undefined !== pobjPaperSubViewpointEN.paperPageNum && jsString_js_1.tzDataType.isNumber(pobjPaperSubViewpointEN.paperPageNum) === false) {
            throw new Error("(errid:Watl000060)字段[论文页码(paperPageNum)]的值:[$(pobjPaperSubViewpointEN.paperPageNum)], 非法，应该为数值型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckPropertyNew)");
        }
        if (null != pobjPaperSubViewpointEN.appraiseCount && undefined !== pobjPaperSubViewpointEN.appraiseCount && jsString_js_1.tzDataType.isNumber(pobjPaperSubViewpointEN.appraiseCount) === false) {
            throw new Error("(errid:Watl000060)字段[评论数(appraiseCount)]的值:[$(pobjPaperSubViewpointEN.appraiseCount)], 非法，应该为数值型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckPropertyNew)");
        }
        if (null != pobjPaperSubViewpointEN.okCount && undefined !== pobjPaperSubViewpointEN.okCount && jsString_js_1.tzDataType.isNumber(pobjPaperSubViewpointEN.okCount) === false) {
            throw new Error("(errid:Watl000060)字段[点赞统计(okCount)]的值:[$(pobjPaperSubViewpointEN.okCount)], 非法，应该为数值型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckPropertyNew)");
        }
        if (null != pobjPaperSubViewpointEN.score && undefined !== pobjPaperSubViewpointEN.score && jsString_js_1.tzDataType.isNumber(pobjPaperSubViewpointEN.score) === false) {
            throw new Error("(errid:Watl000060)字段[评分(score)]的值:[$(pobjPaperSubViewpointEN.score)], 非法，应该为数值型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckPropertyNew)");
        }
        if (null != pobjPaperSubViewpointEN.stuScore && undefined !== pobjPaperSubViewpointEN.stuScore && jsString_js_1.tzDataType.isNumber(pobjPaperSubViewpointEN.stuScore) === false) {
            throw new Error("(errid:Watl000060)字段[学生平均分(stuScore)]的值:[$(pobjPaperSubViewpointEN.stuScore)], 非法，应该为数值型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckPropertyNew)");
        }
        if (null != pobjPaperSubViewpointEN.teaScore && undefined !== pobjPaperSubViewpointEN.teaScore && jsString_js_1.tzDataType.isNumber(pobjPaperSubViewpointEN.teaScore) === false) {
            throw new Error("(errid:Watl000060)字段[教师评分(teaScore)]的值:[$(pobjPaperSubViewpointEN.teaScore)], 非法，应该为数值型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperSubViewpointEN.createDate) == false && undefined !== pobjPaperSubViewpointEN.createDate && jsString_js_1.tzDataType.isString(pobjPaperSubViewpointEN.createDate) === false) {
            throw new Error("(errid:Watl000060)字段[建立日期(createDate)]的值:[$(pobjPaperSubViewpointEN.createDate)], 非法，应该为字符型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperSubViewpointEN.shareId) == false && undefined !== pobjPaperSubViewpointEN.shareId && jsString_js_1.tzDataType.isString(pobjPaperSubViewpointEN.shareId) === false) {
            throw new Error("(errid:Watl000060)字段[分享Id(shareId)]的值:[$(pobjPaperSubViewpointEN.shareId)], 非法，应该为字符型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperSubViewpointEN.topicId) == false && undefined !== pobjPaperSubViewpointEN.topicId && jsString_js_1.tzDataType.isString(pobjPaperSubViewpointEN.topicId) === false) {
            throw new Error("(errid:Watl000060)字段[主题Id(topicId)]的值:[$(pobjPaperSubViewpointEN.topicId)], 非法，应该为字符型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperSubViewpointEN.attitudesId) == false && undefined !== pobjPaperSubViewpointEN.attitudesId && jsString_js_1.tzDataType.isString(pobjPaperSubViewpointEN.attitudesId) === false) {
            throw new Error("(errid:Watl000060)字段[态度Id(attitudesId)]的值:[$(pobjPaperSubViewpointEN.attitudesId)], 非法，应该为字符型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperSubViewpointEN.updDate) == false && undefined !== pobjPaperSubViewpointEN.updDate && jsString_js_1.tzDataType.isString(pobjPaperSubViewpointEN.updDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjPaperSubViewpointEN.updDate)], 非法，应该为字符型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperSubViewpointEN.updUser) == false && undefined !== pobjPaperSubViewpointEN.updUser && jsString_js_1.tzDataType.isString(pobjPaperSubViewpointEN.updUser) === false) {
            throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjPaperSubViewpointEN.updUser)], 非法，应该为字符型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperSubViewpointEN.memo) == false && undefined !== pobjPaperSubViewpointEN.memo && jsString_js_1.tzDataType.isString(pobjPaperSubViewpointEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjPaperSubViewpointEN.memo)], 非法，应该为字符型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperSubViewpointEN.paperRWId) == false && (0, clsString_js_1.GetStrLen)(pobjPaperSubViewpointEN.paperRWId) != 8) {
            throw ("(errid:Watl000061)字段[课文阅读]作为外键字段,长度应该为8(In 子观点表)!(clsPaperSubViewpointBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperSubViewpointEN.subViewpointTypeId) == false && (0, clsString_js_1.GetStrLen)(pobjPaperSubViewpointEN.subViewpointTypeId) != 8) {
            throw ("(errid:Watl000061)字段[类型Id]作为外键字段,长度应该为8(In 子观点表)!(clsPaperSubViewpointBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperSubViewpointEN.explainTypeId) == false && (0, clsString_js_1.GetStrLen)(pobjPaperSubViewpointEN.explainTypeId) != 2) {
            throw ("(errid:Watl000061)字段[说明类型Id]作为外键字段,长度应该为2(In 子观点表)!(clsPaperSubViewpointBL:CheckPropertyNew)");
        }
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjPaperSubViewpointEN.SetIsCheckProperty(true);
    }
    exports.PaperSubViewpoint_CheckPropertyNew = PaperSubViewpoint_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function PaperSubViewpoint_CheckProperty4Update(pobjPaperSubViewpointEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperSubViewpointEN.subViewpointId) == false && (0, clsString_js_1.GetStrLen)(pobjPaperSubViewpointEN.subViewpointId) > 8) {
            throw new Error("(errid:Watl000062)字段[子观点Id(subViewpointId)]的长度不能超过8(In 子观点表(PaperSubViewpoint))!值:$(pobjPaperSubViewpointEN.subViewpointId)(clsPaperSubViewpointBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperSubViewpointEN.paperRWId) == false && (0, clsString_js_1.GetStrLen)(pobjPaperSubViewpointEN.paperRWId) > 8) {
            throw new Error("(errid:Watl000062)字段[课文阅读(paperRWId)]的长度不能超过8(In 子观点表(PaperSubViewpoint))!值:$(pobjPaperSubViewpointEN.paperRWId)(clsPaperSubViewpointBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperSubViewpointEN.paperId) == false && (0, clsString_js_1.GetStrLen)(pobjPaperSubViewpointEN.paperId) > 8) {
            throw new Error("(errid:Watl000062)字段[论文Id(paperId)]的长度不能超过8(In 子观点表(PaperSubViewpoint))!值:$(pobjPaperSubViewpointEN.paperId)(clsPaperSubViewpointBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperSubViewpointEN.id_CurrEduCls) == false && (0, clsString_js_1.GetStrLen)(pobjPaperSubViewpointEN.id_CurrEduCls) > 8) {
            throw new Error("(errid:Watl000062)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 子观点表(PaperSubViewpoint))!值:$(pobjPaperSubViewpointEN.id_CurrEduCls)(clsPaperSubViewpointBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperSubViewpointEN.userId) == false && (0, clsString_js_1.GetStrLen)(pobjPaperSubViewpointEN.userId) > 20) {
            throw new Error("(errid:Watl000062)字段[用户ID(userId)]的长度不能超过20(In 子观点表(PaperSubViewpoint))!值:$(pobjPaperSubViewpointEN.userId)(clsPaperSubViewpointBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperSubViewpointEN.sectionId) == false && (0, clsString_js_1.GetStrLen)(pobjPaperSubViewpointEN.sectionId) > 8) {
            throw new Error("(errid:Watl000062)字段[节Id(sectionId)]的长度不能超过8(In 子观点表(PaperSubViewpoint))!值:$(pobjPaperSubViewpointEN.sectionId)(clsPaperSubViewpointBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperSubViewpointEN.subViewpointTypeId) == false && (0, clsString_js_1.GetStrLen)(pobjPaperSubViewpointEN.subViewpointTypeId) > 8) {
            throw new Error("(errid:Watl000062)字段[类型Id(subViewpointTypeId)]的长度不能超过8(In 子观点表(PaperSubViewpoint))!值:$(pobjPaperSubViewpointEN.subViewpointTypeId)(clsPaperSubViewpointBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperSubViewpointEN.rwTitle) == false && (0, clsString_js_1.GetStrLen)(pobjPaperSubViewpointEN.rwTitle) > 50) {
            throw new Error("(errid:Watl000062)字段[读写标题(rwTitle)]的长度不能超过50(In 子观点表(PaperSubViewpoint))!值:$(pobjPaperSubViewpointEN.rwTitle)(clsPaperSubViewpointBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperSubViewpointEN.explainTypeId) == false && (0, clsString_js_1.GetStrLen)(pobjPaperSubViewpointEN.explainTypeId) > 2) {
            throw new Error("(errid:Watl000062)字段[说明类型Id(explainTypeId)]的长度不能超过2(In 子观点表(PaperSubViewpoint))!值:$(pobjPaperSubViewpointEN.explainTypeId)(clsPaperSubViewpointBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperSubViewpointEN.explainContent) == false && (0, clsString_js_1.GetStrLen)(pobjPaperSubViewpointEN.explainContent) > 5000) {
            throw new Error("(errid:Watl000062)字段[说明内容(explainContent)]的长度不能超过5000(In 子观点表(PaperSubViewpoint))!值:$(pobjPaperSubViewpointEN.explainContent)(clsPaperSubViewpointBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperSubViewpointEN.literatureSourcesId) == false && (0, clsString_js_1.GetStrLen)(pobjPaperSubViewpointEN.literatureSourcesId) > 8) {
            throw new Error("(errid:Watl000062)字段[文献来源(literatureSourcesId)]的长度不能超过8(In 子观点表(PaperSubViewpoint))!值:$(pobjPaperSubViewpointEN.literatureSourcesId)(clsPaperSubViewpointBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperSubViewpointEN.createDate) == false && (0, clsString_js_1.GetStrLen)(pobjPaperSubViewpointEN.createDate) > 20) {
            throw new Error("(errid:Watl000062)字段[建立日期(createDate)]的长度不能超过20(In 子观点表(PaperSubViewpoint))!值:$(pobjPaperSubViewpointEN.createDate)(clsPaperSubViewpointBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperSubViewpointEN.shareId) == false && (0, clsString_js_1.GetStrLen)(pobjPaperSubViewpointEN.shareId) > 2) {
            throw new Error("(errid:Watl000062)字段[分享Id(shareId)]的长度不能超过2(In 子观点表(PaperSubViewpoint))!值:$(pobjPaperSubViewpointEN.shareId)(clsPaperSubViewpointBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperSubViewpointEN.topicId) == false && (0, clsString_js_1.GetStrLen)(pobjPaperSubViewpointEN.topicId) > 8) {
            throw new Error("(errid:Watl000062)字段[主题Id(topicId)]的长度不能超过8(In 子观点表(PaperSubViewpoint))!值:$(pobjPaperSubViewpointEN.topicId)(clsPaperSubViewpointBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperSubViewpointEN.attitudesId) == false && (0, clsString_js_1.GetStrLen)(pobjPaperSubViewpointEN.attitudesId) > 2) {
            throw new Error("(errid:Watl000062)字段[态度Id(attitudesId)]的长度不能超过2(In 子观点表(PaperSubViewpoint))!值:$(pobjPaperSubViewpointEN.attitudesId)(clsPaperSubViewpointBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperSubViewpointEN.updDate) == false && (0, clsString_js_1.GetStrLen)(pobjPaperSubViewpointEN.updDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 子观点表(PaperSubViewpoint))!值:$(pobjPaperSubViewpointEN.updDate)(clsPaperSubViewpointBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperSubViewpointEN.updUser) == false && (0, clsString_js_1.GetStrLen)(pobjPaperSubViewpointEN.updUser) > 20) {
            throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 子观点表(PaperSubViewpoint))!值:$(pobjPaperSubViewpointEN.updUser)(clsPaperSubViewpointBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperSubViewpointEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjPaperSubViewpointEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 子观点表(PaperSubViewpoint))!值:$(pobjPaperSubViewpointEN.memo)(clsPaperSubViewpointBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperSubViewpointEN.subViewpointId) == false && undefined !== pobjPaperSubViewpointEN.subViewpointId && jsString_js_1.tzDataType.isString(pobjPaperSubViewpointEN.subViewpointId) === false) {
            throw new Error("(errid:Watl000063)字段[子观点Id(subViewpointId)]的值:[$(pobjPaperSubViewpointEN.subViewpointId)], 非法，应该为字符型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperSubViewpointEN.paperRWId) == false && undefined !== pobjPaperSubViewpointEN.paperRWId && jsString_js_1.tzDataType.isString(pobjPaperSubViewpointEN.paperRWId) === false) {
            throw new Error("(errid:Watl000063)字段[课文阅读(paperRWId)]的值:[$(pobjPaperSubViewpointEN.paperRWId)], 非法，应该为字符型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperSubViewpointEN.paperId) == false && undefined !== pobjPaperSubViewpointEN.paperId && jsString_js_1.tzDataType.isString(pobjPaperSubViewpointEN.paperId) === false) {
            throw new Error("(errid:Watl000063)字段[论文Id(paperId)]的值:[$(pobjPaperSubViewpointEN.paperId)], 非法，应该为字符型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperSubViewpointEN.id_CurrEduCls) == false && undefined !== pobjPaperSubViewpointEN.id_CurrEduCls && jsString_js_1.tzDataType.isString(pobjPaperSubViewpointEN.id_CurrEduCls) === false) {
            throw new Error("(errid:Watl000063)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjPaperSubViewpointEN.id_CurrEduCls)], 非法，应该为字符型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperSubViewpointEN.userId) == false && undefined !== pobjPaperSubViewpointEN.userId && jsString_js_1.tzDataType.isString(pobjPaperSubViewpointEN.userId) === false) {
            throw new Error("(errid:Watl000063)字段[用户ID(userId)]的值:[$(pobjPaperSubViewpointEN.userId)], 非法，应该为字符型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperSubViewpointEN.sectionId) == false && undefined !== pobjPaperSubViewpointEN.sectionId && jsString_js_1.tzDataType.isString(pobjPaperSubViewpointEN.sectionId) === false) {
            throw new Error("(errid:Watl000063)字段[节Id(sectionId)]的值:[$(pobjPaperSubViewpointEN.sectionId)], 非法，应该为字符型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperSubViewpointEN.subViewpointTypeId) == false && undefined !== pobjPaperSubViewpointEN.subViewpointTypeId && jsString_js_1.tzDataType.isString(pobjPaperSubViewpointEN.subViewpointTypeId) === false) {
            throw new Error("(errid:Watl000063)字段[类型Id(subViewpointTypeId)]的值:[$(pobjPaperSubViewpointEN.subViewpointTypeId)], 非法，应该为字符型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperSubViewpointEN.rwTitle) == false && undefined !== pobjPaperSubViewpointEN.rwTitle && jsString_js_1.tzDataType.isString(pobjPaperSubViewpointEN.rwTitle) === false) {
            throw new Error("(errid:Watl000063)字段[读写标题(rwTitle)]的值:[$(pobjPaperSubViewpointEN.rwTitle)], 非法，应该为字符型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperSubViewpointEN.subViewpointContent) == false && undefined !== pobjPaperSubViewpointEN.subViewpointContent && jsString_js_1.tzDataType.isString(pobjPaperSubViewpointEN.subViewpointContent) === false) {
            throw new Error("(errid:Watl000063)字段[详情内容(subViewpointContent)]的值:[$(pobjPaperSubViewpointEN.subViewpointContent)], 非法，应该为字符型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperSubViewpointEN.explainTypeId) == false && undefined !== pobjPaperSubViewpointEN.explainTypeId && jsString_js_1.tzDataType.isString(pobjPaperSubViewpointEN.explainTypeId) === false) {
            throw new Error("(errid:Watl000063)字段[说明类型Id(explainTypeId)]的值:[$(pobjPaperSubViewpointEN.explainTypeId)], 非法，应该为字符型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperSubViewpointEN.explainContent) == false && undefined !== pobjPaperSubViewpointEN.explainContent && jsString_js_1.tzDataType.isString(pobjPaperSubViewpointEN.explainContent) === false) {
            throw new Error("(errid:Watl000063)字段[说明内容(explainContent)]的值:[$(pobjPaperSubViewpointEN.explainContent)], 非法，应该为字符型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckProperty4Update)");
        }
        if (null != pobjPaperSubViewpointEN.isPublic && undefined !== pobjPaperSubViewpointEN.isPublic && jsString_js_1.tzDataType.isBoolean(pobjPaperSubViewpointEN.isPublic) === false) {
            throw new Error("(errid:Watl000063)字段[是否公开(isPublic)]的值:[$(pobjPaperSubViewpointEN.isPublic)], 非法，应该为布尔型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperSubViewpointEN.literatureSourcesId) == false && undefined !== pobjPaperSubViewpointEN.literatureSourcesId && jsString_js_1.tzDataType.isString(pobjPaperSubViewpointEN.literatureSourcesId) === false) {
            throw new Error("(errid:Watl000063)字段[文献来源(literatureSourcesId)]的值:[$(pobjPaperSubViewpointEN.literatureSourcesId)], 非法，应该为字符型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckProperty4Update)");
        }
        if (null != pobjPaperSubViewpointEN.pageNumber && undefined !== pobjPaperSubViewpointEN.pageNumber && jsString_js_1.tzDataType.isNumber(pobjPaperSubViewpointEN.pageNumber) === false) {
            throw new Error("(errid:Watl000063)字段[页码(pageNumber)]的值:[$(pobjPaperSubViewpointEN.pageNumber)], 非法，应该为数值型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckProperty4Update)");
        }
        if (null != pobjPaperSubViewpointEN.orderNum && undefined !== pobjPaperSubViewpointEN.orderNum && jsString_js_1.tzDataType.isNumber(pobjPaperSubViewpointEN.orderNum) === false) {
            throw new Error("(errid:Watl000063)字段[序号(orderNum)]的值:[$(pobjPaperSubViewpointEN.orderNum)], 非法，应该为数值型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckProperty4Update)");
        }
        if (null != pobjPaperSubViewpointEN.paperLineNum && undefined !== pobjPaperSubViewpointEN.paperLineNum && jsString_js_1.tzDataType.isNumber(pobjPaperSubViewpointEN.paperLineNum) === false) {
            throw new Error("(errid:Watl000063)字段[论文行号(paperLineNum)]的值:[$(pobjPaperSubViewpointEN.paperLineNum)], 非法，应该为数值型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckProperty4Update)");
        }
        if (null != pobjPaperSubViewpointEN.paperPageNum && undefined !== pobjPaperSubViewpointEN.paperPageNum && jsString_js_1.tzDataType.isNumber(pobjPaperSubViewpointEN.paperPageNum) === false) {
            throw new Error("(errid:Watl000063)字段[论文页码(paperPageNum)]的值:[$(pobjPaperSubViewpointEN.paperPageNum)], 非法，应该为数值型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckProperty4Update)");
        }
        if (null != pobjPaperSubViewpointEN.appraiseCount && undefined !== pobjPaperSubViewpointEN.appraiseCount && jsString_js_1.tzDataType.isNumber(pobjPaperSubViewpointEN.appraiseCount) === false) {
            throw new Error("(errid:Watl000063)字段[评论数(appraiseCount)]的值:[$(pobjPaperSubViewpointEN.appraiseCount)], 非法，应该为数值型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckProperty4Update)");
        }
        if (null != pobjPaperSubViewpointEN.okCount && undefined !== pobjPaperSubViewpointEN.okCount && jsString_js_1.tzDataType.isNumber(pobjPaperSubViewpointEN.okCount) === false) {
            throw new Error("(errid:Watl000063)字段[点赞统计(okCount)]的值:[$(pobjPaperSubViewpointEN.okCount)], 非法，应该为数值型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckProperty4Update)");
        }
        if (null != pobjPaperSubViewpointEN.score && undefined !== pobjPaperSubViewpointEN.score && jsString_js_1.tzDataType.isNumber(pobjPaperSubViewpointEN.score) === false) {
            throw new Error("(errid:Watl000063)字段[评分(score)]的值:[$(pobjPaperSubViewpointEN.score)], 非法，应该为数值型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckProperty4Update)");
        }
        if (null != pobjPaperSubViewpointEN.stuScore && undefined !== pobjPaperSubViewpointEN.stuScore && jsString_js_1.tzDataType.isNumber(pobjPaperSubViewpointEN.stuScore) === false) {
            throw new Error("(errid:Watl000063)字段[学生平均分(stuScore)]的值:[$(pobjPaperSubViewpointEN.stuScore)], 非法，应该为数值型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckProperty4Update)");
        }
        if (null != pobjPaperSubViewpointEN.teaScore && undefined !== pobjPaperSubViewpointEN.teaScore && jsString_js_1.tzDataType.isNumber(pobjPaperSubViewpointEN.teaScore) === false) {
            throw new Error("(errid:Watl000063)字段[教师评分(teaScore)]的值:[$(pobjPaperSubViewpointEN.teaScore)], 非法，应该为数值型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperSubViewpointEN.createDate) == false && undefined !== pobjPaperSubViewpointEN.createDate && jsString_js_1.tzDataType.isString(pobjPaperSubViewpointEN.createDate) === false) {
            throw new Error("(errid:Watl000063)字段[建立日期(createDate)]的值:[$(pobjPaperSubViewpointEN.createDate)], 非法，应该为字符型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperSubViewpointEN.shareId) == false && undefined !== pobjPaperSubViewpointEN.shareId && jsString_js_1.tzDataType.isString(pobjPaperSubViewpointEN.shareId) === false) {
            throw new Error("(errid:Watl000063)字段[分享Id(shareId)]的值:[$(pobjPaperSubViewpointEN.shareId)], 非法，应该为字符型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperSubViewpointEN.topicId) == false && undefined !== pobjPaperSubViewpointEN.topicId && jsString_js_1.tzDataType.isString(pobjPaperSubViewpointEN.topicId) === false) {
            throw new Error("(errid:Watl000063)字段[主题Id(topicId)]的值:[$(pobjPaperSubViewpointEN.topicId)], 非法，应该为字符型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperSubViewpointEN.attitudesId) == false && undefined !== pobjPaperSubViewpointEN.attitudesId && jsString_js_1.tzDataType.isString(pobjPaperSubViewpointEN.attitudesId) === false) {
            throw new Error("(errid:Watl000063)字段[态度Id(attitudesId)]的值:[$(pobjPaperSubViewpointEN.attitudesId)], 非法，应该为字符型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperSubViewpointEN.updDate) == false && undefined !== pobjPaperSubViewpointEN.updDate && jsString_js_1.tzDataType.isString(pobjPaperSubViewpointEN.updDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjPaperSubViewpointEN.updDate)], 非法，应该为字符型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperSubViewpointEN.updUser) == false && undefined !== pobjPaperSubViewpointEN.updUser && jsString_js_1.tzDataType.isString(pobjPaperSubViewpointEN.updUser) === false) {
            throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjPaperSubViewpointEN.updUser)], 非法，应该为字符型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperSubViewpointEN.memo) == false && undefined !== pobjPaperSubViewpointEN.memo && jsString_js_1.tzDataType.isString(pobjPaperSubViewpointEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjPaperSubViewpointEN.memo)], 非法，应该为字符型(In 子观点表(PaperSubViewpoint))!(clsPaperSubViewpointBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperSubViewpointEN.subViewpointId) === true) {
            throw new Error("(errid:Watl000064)字段[子观点Id]不能为空(In 子观点表)!(clsPaperSubViewpointBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperSubViewpointEN.paperRWId) == false && (0, clsString_js_1.GetStrLen)(pobjPaperSubViewpointEN.paperRWId) != 8) {
            throw ("(errid:Watl000065)字段[课文阅读]作为外键字段,长度应该为8(In 子观点表)!(clsPaperSubViewpointBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperSubViewpointEN.subViewpointTypeId) == false && (0, clsString_js_1.GetStrLen)(pobjPaperSubViewpointEN.subViewpointTypeId) != 8) {
            throw ("(errid:Watl000065)字段[类型Id]作为外键字段,长度应该为8(In 子观点表)!(clsPaperSubViewpointBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperSubViewpointEN.explainTypeId) == false && (0, clsString_js_1.GetStrLen)(pobjPaperSubViewpointEN.explainTypeId) != 2) {
            throw ("(errid:Watl000065)字段[说明类型Id]作为外键字段,长度应该为2(In 子观点表)!(clsPaperSubViewpointBL:CheckPropertyNew)");
        }
        pobjPaperSubViewpointEN.SetIsCheckProperty(true);
    }
    exports.PaperSubViewpoint_CheckProperty4Update = PaperSubViewpoint_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function PaperSubViewpoint_GetJSONStrByObj(pobjPaperSubViewpointEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjPaperSubViewpointEN.sf_UpdFldSetStr = pobjPaperSubViewpointEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjPaperSubViewpointEN);
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
    exports.PaperSubViewpoint_GetJSONStrByObj = PaperSubViewpoint_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function PaperSubViewpoint_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrPaperSubViewpointObjLst = new Array();
        if (strJSON === "") {
            return arrPaperSubViewpointObjLst;
        }
        try {
            arrPaperSubViewpointObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrPaperSubViewpointObjLst;
        }
        return arrPaperSubViewpointObjLst;
    }
    exports.PaperSubViewpoint_GetObjLstByJSONStr = PaperSubViewpoint_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrPaperSubViewpointObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function PaperSubViewpoint_GetObjLstByJSONObjLst(arrPaperSubViewpointObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrPaperSubViewpointObjLst = new Array();
        for (const objInFor of arrPaperSubViewpointObjLstS) {
            const obj1 = PaperSubViewpoint_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrPaperSubViewpointObjLst.push(obj1);
        }
        return arrPaperSubViewpointObjLst;
    }
    exports.PaperSubViewpoint_GetObjLstByJSONObjLst = PaperSubViewpoint_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function PaperSubViewpoint_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjPaperSubViewpointEN = new clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN();
        if (strJSON === "") {
            return pobjPaperSubViewpointEN;
        }
        try {
            pobjPaperSubViewpointEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjPaperSubViewpointEN;
        }
        return pobjPaperSubViewpointEN;
    }
    exports.PaperSubViewpoint_GetObjByJSONStr = PaperSubViewpoint_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function PaperSubViewpoint_GetCombineCondition(objPaperSubViewpoint_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objPaperSubViewpoint_Cond.dicFldComparisonOp, clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_SubViewpointId) == true) {
            const strComparisonOp_SubViewpointId = objPaperSubViewpoint_Cond.dicFldComparisonOp[clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_SubViewpointId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_SubViewpointId, objPaperSubViewpoint_Cond.subViewpointId, strComparisonOp_SubViewpointId);
        }
        if (Object.prototype.hasOwnProperty.call(objPaperSubViewpoint_Cond.dicFldComparisonOp, clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_PaperRWId) == true) {
            const strComparisonOp_PaperRWId = objPaperSubViewpoint_Cond.dicFldComparisonOp[clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_PaperRWId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_PaperRWId, objPaperSubViewpoint_Cond.paperRWId, strComparisonOp_PaperRWId);
        }
        if (Object.prototype.hasOwnProperty.call(objPaperSubViewpoint_Cond.dicFldComparisonOp, clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_PaperId) == true) {
            const strComparisonOp_PaperId = objPaperSubViewpoint_Cond.dicFldComparisonOp[clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_PaperId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_PaperId, objPaperSubViewpoint_Cond.paperId, strComparisonOp_PaperId);
        }
        if (Object.prototype.hasOwnProperty.call(objPaperSubViewpoint_Cond.dicFldComparisonOp, clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_id_CurrEduCls) == true) {
            const strComparisonOp_id_CurrEduCls = objPaperSubViewpoint_Cond.dicFldComparisonOp[clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_id_CurrEduCls];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_id_CurrEduCls, objPaperSubViewpoint_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
        }
        if (Object.prototype.hasOwnProperty.call(objPaperSubViewpoint_Cond.dicFldComparisonOp, clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_UserId) == true) {
            const strComparisonOp_UserId = objPaperSubViewpoint_Cond.dicFldComparisonOp[clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_UserId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_UserId, objPaperSubViewpoint_Cond.userId, strComparisonOp_UserId);
        }
        if (Object.prototype.hasOwnProperty.call(objPaperSubViewpoint_Cond.dicFldComparisonOp, clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_SectionId) == true) {
            const strComparisonOp_SectionId = objPaperSubViewpoint_Cond.dicFldComparisonOp[clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_SectionId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_SectionId, objPaperSubViewpoint_Cond.sectionId, strComparisonOp_SectionId);
        }
        if (Object.prototype.hasOwnProperty.call(objPaperSubViewpoint_Cond.dicFldComparisonOp, clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_SubViewpointTypeId) == true) {
            const strComparisonOp_SubViewpointTypeId = objPaperSubViewpoint_Cond.dicFldComparisonOp[clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_SubViewpointTypeId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_SubViewpointTypeId, objPaperSubViewpoint_Cond.subViewpointTypeId, strComparisonOp_SubViewpointTypeId);
        }
        if (Object.prototype.hasOwnProperty.call(objPaperSubViewpoint_Cond.dicFldComparisonOp, clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_RWTitle) == true) {
            const strComparisonOp_RWTitle = objPaperSubViewpoint_Cond.dicFldComparisonOp[clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_RWTitle];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_RWTitle, objPaperSubViewpoint_Cond.rwTitle, strComparisonOp_RWTitle);
        }
        //数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
        if (Object.prototype.hasOwnProperty.call(objPaperSubViewpoint_Cond.dicFldComparisonOp, clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_ExplainTypeId) == true) {
            const strComparisonOp_ExplainTypeId = objPaperSubViewpoint_Cond.dicFldComparisonOp[clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_ExplainTypeId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_ExplainTypeId, objPaperSubViewpoint_Cond.explainTypeId, strComparisonOp_ExplainTypeId);
        }
        if (Object.prototype.hasOwnProperty.call(objPaperSubViewpoint_Cond.dicFldComparisonOp, clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_ExplainContent) == true) {
            const strComparisonOp_ExplainContent = objPaperSubViewpoint_Cond.dicFldComparisonOp[clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_ExplainContent];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_ExplainContent, objPaperSubViewpoint_Cond.explainContent, strComparisonOp_ExplainContent);
        }
        if (Object.prototype.hasOwnProperty.call(objPaperSubViewpoint_Cond.dicFldComparisonOp, clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_IsPublic) == true) {
            if (objPaperSubViewpoint_Cond.isPublic == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_IsPublic);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_IsPublic);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objPaperSubViewpoint_Cond.dicFldComparisonOp, clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_LiteratureSourcesId) == true) {
            const strComparisonOp_LiteratureSourcesId = objPaperSubViewpoint_Cond.dicFldComparisonOp[clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_LiteratureSourcesId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_LiteratureSourcesId, objPaperSubViewpoint_Cond.literatureSourcesId, strComparisonOp_LiteratureSourcesId);
        }
        if (Object.prototype.hasOwnProperty.call(objPaperSubViewpoint_Cond.dicFldComparisonOp, clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_PageNumber) == true) {
            const strComparisonOp_PageNumber = objPaperSubViewpoint_Cond.dicFldComparisonOp[clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_PageNumber];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_PageNumber, objPaperSubViewpoint_Cond.pageNumber, strComparisonOp_PageNumber);
        }
        if (Object.prototype.hasOwnProperty.call(objPaperSubViewpoint_Cond.dicFldComparisonOp, clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_OrderNum) == true) {
            const strComparisonOp_OrderNum = objPaperSubViewpoint_Cond.dicFldComparisonOp[clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_OrderNum];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_OrderNum, objPaperSubViewpoint_Cond.orderNum, strComparisonOp_OrderNum);
        }
        if (Object.prototype.hasOwnProperty.call(objPaperSubViewpoint_Cond.dicFldComparisonOp, clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_PaperLineNum) == true) {
            const strComparisonOp_PaperLineNum = objPaperSubViewpoint_Cond.dicFldComparisonOp[clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_PaperLineNum];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_PaperLineNum, objPaperSubViewpoint_Cond.paperLineNum, strComparisonOp_PaperLineNum);
        }
        if (Object.prototype.hasOwnProperty.call(objPaperSubViewpoint_Cond.dicFldComparisonOp, clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_PaperPageNum) == true) {
            const strComparisonOp_PaperPageNum = objPaperSubViewpoint_Cond.dicFldComparisonOp[clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_PaperPageNum];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_PaperPageNum, objPaperSubViewpoint_Cond.paperPageNum, strComparisonOp_PaperPageNum);
        }
        if (Object.prototype.hasOwnProperty.call(objPaperSubViewpoint_Cond.dicFldComparisonOp, clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_AppraiseCount) == true) {
            const strComparisonOp_AppraiseCount = objPaperSubViewpoint_Cond.dicFldComparisonOp[clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_AppraiseCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_AppraiseCount, objPaperSubViewpoint_Cond.appraiseCount, strComparisonOp_AppraiseCount);
        }
        if (Object.prototype.hasOwnProperty.call(objPaperSubViewpoint_Cond.dicFldComparisonOp, clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_OkCount) == true) {
            const strComparisonOp_OkCount = objPaperSubViewpoint_Cond.dicFldComparisonOp[clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_OkCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_OkCount, objPaperSubViewpoint_Cond.okCount, strComparisonOp_OkCount);
        }
        if (Object.prototype.hasOwnProperty.call(objPaperSubViewpoint_Cond.dicFldComparisonOp, clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_score) == true) {
            const strComparisonOp_score = objPaperSubViewpoint_Cond.dicFldComparisonOp[clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_score];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_score, objPaperSubViewpoint_Cond.score, strComparisonOp_score);
        }
        if (Object.prototype.hasOwnProperty.call(objPaperSubViewpoint_Cond.dicFldComparisonOp, clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_StuScore) == true) {
            const strComparisonOp_StuScore = objPaperSubViewpoint_Cond.dicFldComparisonOp[clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_StuScore];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_StuScore, objPaperSubViewpoint_Cond.stuScore, strComparisonOp_StuScore);
        }
        if (Object.prototype.hasOwnProperty.call(objPaperSubViewpoint_Cond.dicFldComparisonOp, clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_TeaScore) == true) {
            const strComparisonOp_TeaScore = objPaperSubViewpoint_Cond.dicFldComparisonOp[clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_TeaScore];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_TeaScore, objPaperSubViewpoint_Cond.teaScore, strComparisonOp_TeaScore);
        }
        if (Object.prototype.hasOwnProperty.call(objPaperSubViewpoint_Cond.dicFldComparisonOp, clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_CreateDate) == true) {
            const strComparisonOp_CreateDate = objPaperSubViewpoint_Cond.dicFldComparisonOp[clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_CreateDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_CreateDate, objPaperSubViewpoint_Cond.createDate, strComparisonOp_CreateDate);
        }
        if (Object.prototype.hasOwnProperty.call(objPaperSubViewpoint_Cond.dicFldComparisonOp, clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_ShareId) == true) {
            const strComparisonOp_ShareId = objPaperSubViewpoint_Cond.dicFldComparisonOp[clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_ShareId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_ShareId, objPaperSubViewpoint_Cond.shareId, strComparisonOp_ShareId);
        }
        if (Object.prototype.hasOwnProperty.call(objPaperSubViewpoint_Cond.dicFldComparisonOp, clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_TopicId) == true) {
            const strComparisonOp_TopicId = objPaperSubViewpoint_Cond.dicFldComparisonOp[clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_TopicId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_TopicId, objPaperSubViewpoint_Cond.topicId, strComparisonOp_TopicId);
        }
        if (Object.prototype.hasOwnProperty.call(objPaperSubViewpoint_Cond.dicFldComparisonOp, clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_AttitudesId) == true) {
            const strComparisonOp_AttitudesId = objPaperSubViewpoint_Cond.dicFldComparisonOp[clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_AttitudesId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_AttitudesId, objPaperSubViewpoint_Cond.attitudesId, strComparisonOp_AttitudesId);
        }
        if (Object.prototype.hasOwnProperty.call(objPaperSubViewpoint_Cond.dicFldComparisonOp, clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objPaperSubViewpoint_Cond.dicFldComparisonOp[clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_UpdDate, objPaperSubViewpoint_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objPaperSubViewpoint_Cond.dicFldComparisonOp, clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objPaperSubViewpoint_Cond.dicFldComparisonOp[clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_UpdUser];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_UpdUser, objPaperSubViewpoint_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objPaperSubViewpoint_Cond.dicFldComparisonOp, clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_Memo) == true) {
            const strComparisonOp_Memo = objPaperSubViewpoint_Cond.dicFldComparisonOp[clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.con_Memo, objPaperSubViewpoint_Cond.memo, strComparisonOp_Memo);
        }
        return strWhereCond;
    }
    exports.PaperSubViewpoint_GetCombineCondition = PaperSubViewpoint_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--PaperSubViewpoint(子观点表),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param strPaperRWId: 课文阅读(要求唯一的字段)
    * @param strSubViewpointTypeId: 类型Id(要求唯一的字段)
    * @param strSubViewpointContent: 详情内容(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function PaperSubViewpoint_GetUniCondStr_PaperRWId_SubViewpointTypeId_SubViewpointContent(objPaperSubViewpointEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and PaperRWId = '{0}'", objPaperSubViewpointEN.paperRWId);
        strWhereCond += (0, clsString_js_1.Format)(" and SubViewpointTypeId = '{0}'", objPaperSubViewpointEN.subViewpointTypeId);
        strWhereCond += (0, clsString_js_1.Format)(" and SubViewpointContent = '{0}'", objPaperSubViewpointEN.subViewpointContent);
        return strWhereCond;
    }
    exports.PaperSubViewpoint_GetUniCondStr_PaperRWId_SubViewpointTypeId_SubViewpointContent = PaperSubViewpoint_GetUniCondStr_PaperRWId_SubViewpointTypeId_SubViewpointContent;
    /**
    *获取唯一性条件串(Uniqueness)--PaperSubViewpoint(子观点表),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param strSubViewpointId: 子观点Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function PaperSubViewpoint_GetUniCondStr_SubViewpointId(objPaperSubViewpointEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and SubViewpointId = '{0}'", objPaperSubViewpointEN.subViewpointId);
        return strWhereCond;
    }
    exports.PaperSubViewpoint_GetUniCondStr_SubViewpointId = PaperSubViewpoint_GetUniCondStr_SubViewpointId;
    /**
    *获取唯一性条件串(Uniqueness)--PaperSubViewpoint(子观点表),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param strPaperRWId: 课文阅读(要求唯一的字段)
    * @param strSubViewpointTypeId: 类型Id(要求唯一的字段)
    * @param strSubViewpointContent: 详情内容(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function PaperSubViewpoint_GetUniCondStr4Update_PaperRWId_SubViewpointTypeId_SubViewpointContent(objPaperSubViewpointEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and SubViewpointId <> '{0}'", objPaperSubViewpointEN.subViewpointId);
        strWhereCond += (0, clsString_js_1.Format)(" and PaperRWId = '{0}'", objPaperSubViewpointEN.paperRWId);
        strWhereCond += (0, clsString_js_1.Format)(" and SubViewpointTypeId = '{0}'", objPaperSubViewpointEN.subViewpointTypeId);
        strWhereCond += (0, clsString_js_1.Format)(" and SubViewpointContent = '{0}'", objPaperSubViewpointEN.subViewpointContent);
        return strWhereCond;
    }
    exports.PaperSubViewpoint_GetUniCondStr4Update_PaperRWId_SubViewpointTypeId_SubViewpointContent = PaperSubViewpoint_GetUniCondStr4Update_PaperRWId_SubViewpointTypeId_SubViewpointContent;
    /**
    *获取唯一性条件串(Uniqueness)--PaperSubViewpoint(子观点表),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param strSubViewpointId: 子观点Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function PaperSubViewpoint_GetUniCondStr4Update_SubViewpointId(objPaperSubViewpointEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and SubViewpointId <> '{0}'", objPaperSubViewpointEN.subViewpointId);
        strWhereCond += (0, clsString_js_1.Format)(" and SubViewpointId = '{0}'", objPaperSubViewpointEN.subViewpointId);
        return strWhereCond;
    }
    exports.PaperSubViewpoint_GetUniCondStr4Update_SubViewpointId = PaperSubViewpoint_GetUniCondStr4Update_SubViewpointId;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objPaperSubViewpointENS:源对象
     * @param objPaperSubViewpointENT:目标对象
    */
    function PaperSubViewpoint_CopyObjTo(objPaperSubViewpointENS, objPaperSubViewpointENT) {
        objPaperSubViewpointENT.subViewpointId = objPaperSubViewpointENS.subViewpointId; //子观点Id
        objPaperSubViewpointENT.paperRWId = objPaperSubViewpointENS.paperRWId; //课文阅读
        objPaperSubViewpointENT.paperId = objPaperSubViewpointENS.paperId; //论文Id
        objPaperSubViewpointENT.id_CurrEduCls = objPaperSubViewpointENS.id_CurrEduCls; //教学班流水号
        objPaperSubViewpointENT.userId = objPaperSubViewpointENS.userId; //用户ID
        objPaperSubViewpointENT.sectionId = objPaperSubViewpointENS.sectionId; //节Id
        objPaperSubViewpointENT.subViewpointTypeId = objPaperSubViewpointENS.subViewpointTypeId; //类型Id
        objPaperSubViewpointENT.rwTitle = objPaperSubViewpointENS.rwTitle; //读写标题
        objPaperSubViewpointENT.subViewpointContent = objPaperSubViewpointENS.subViewpointContent; //详情内容
        objPaperSubViewpointENT.explainTypeId = objPaperSubViewpointENS.explainTypeId; //说明类型Id
        objPaperSubViewpointENT.explainContent = objPaperSubViewpointENS.explainContent; //说明内容
        objPaperSubViewpointENT.isPublic = objPaperSubViewpointENS.isPublic; //是否公开
        objPaperSubViewpointENT.literatureSourcesId = objPaperSubViewpointENS.literatureSourcesId; //文献来源
        objPaperSubViewpointENT.pageNumber = objPaperSubViewpointENS.pageNumber; //页码
        objPaperSubViewpointENT.orderNum = objPaperSubViewpointENS.orderNum; //序号
        objPaperSubViewpointENT.paperLineNum = objPaperSubViewpointENS.paperLineNum; //论文行号
        objPaperSubViewpointENT.paperPageNum = objPaperSubViewpointENS.paperPageNum; //论文页码
        objPaperSubViewpointENT.appraiseCount = objPaperSubViewpointENS.appraiseCount; //评论数
        objPaperSubViewpointENT.okCount = objPaperSubViewpointENS.okCount; //点赞统计
        objPaperSubViewpointENT.score = objPaperSubViewpointENS.score; //评分
        objPaperSubViewpointENT.stuScore = objPaperSubViewpointENS.stuScore; //学生平均分
        objPaperSubViewpointENT.teaScore = objPaperSubViewpointENS.teaScore; //教师评分
        objPaperSubViewpointENT.createDate = objPaperSubViewpointENS.createDate; //建立日期
        objPaperSubViewpointENT.shareId = objPaperSubViewpointENS.shareId; //分享Id
        objPaperSubViewpointENT.topicId = objPaperSubViewpointENS.topicId; //主题Id
        objPaperSubViewpointENT.attitudesId = objPaperSubViewpointENS.attitudesId; //态度Id
        objPaperSubViewpointENT.updDate = objPaperSubViewpointENS.updDate; //修改日期
        objPaperSubViewpointENT.updUser = objPaperSubViewpointENS.updUser; //修改人
        objPaperSubViewpointENT.memo = objPaperSubViewpointENS.memo; //备注
        objPaperSubViewpointENT.sf_UpdFldSetStr = objPaperSubViewpointENS.updFldString; //sf_UpdFldSetStr
    }
    exports.PaperSubViewpoint_CopyObjTo = PaperSubViewpoint_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objPaperSubViewpointENS:源对象
     * @param objPaperSubViewpointENT:目标对象
    */
    function PaperSubViewpoint_GetObjFromJsonObj(objPaperSubViewpointENS) {
        const objPaperSubViewpointENT = new clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objPaperSubViewpointENT, objPaperSubViewpointENS);
        return objPaperSubViewpointENT;
    }
    exports.PaperSubViewpoint_GetObjFromJsonObj = PaperSubViewpoint_GetObjFromJsonObj;
});
