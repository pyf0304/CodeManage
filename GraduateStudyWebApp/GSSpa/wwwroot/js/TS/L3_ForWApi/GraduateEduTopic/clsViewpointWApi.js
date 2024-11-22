/**
* 类名:clsViewpointWApi
* 表名:Viewpoint(01120542)
* 生成代码版本:2022.11.02.1
* 生成日期:2022/11/02 11:47:02
* 生成者:pyf
* 生成服务器IP:
工程名称:问卷调查(0112)
CM工程:研究生论文学习(变量首字母小写)-全部函数集
* 相关数据库:103.116.76.183,9433EduHigh_Jsie
* PrjDataBaseId:0170
模块中文名:研培主题(GraduateEduTopic)
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
        define(["require", "exports", "axios", "../../PubFun/CacheHelper.js", "../../L0_Entity/GraduateEduTopic/clsViewpointEN.js", "../../L3_ForWApi/GraduateEduTopic/clsvViewpointWApi.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsSysPara4WebApi.js", "../../PubFun/CacheHelper.js", "../../PubFun/jsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.Viewpoint_GetObjFromJsonObj = exports.Viewpoint_CopyObjTo = exports.Viewpoint_GetUniCondStr4Update_ViewpointId = exports.Viewpoint_GetUniCondStr_ViewpointId = exports.Viewpoint_GetCombineCondition = exports.Viewpoint_GetObjByJSONStr = exports.Viewpoint_GetObjLstByJSONObjLst = exports.Viewpoint_GetObjLstByJSONStr = exports.Viewpoint_GetJSONStrByObj = exports.Viewpoint_CheckProperty4Update = exports.Viewpoint_CheckPropertyNew = exports.Viewpoint_ReFreshThisCache = exports.Viewpoint_ReFreshCache = exports.Viewpoint_GetWebApiUrl = exports.Viewpoint_GetMaxStrIdByPrefix = exports.Viewpoint_GetMaxStrIdAsync = exports.Viewpoint_GetRecCountByCond_Cache = exports.Viewpoint_GetRecCountByCondAsync = exports.Viewpoint_IsExistAsync = exports.Viewpoint_IsExist_Cache = exports.Viewpoint_IsExist = exports.Viewpoint_IsExistRecordAsync = exports.Viewpoint_IsExistRecord_Cache = exports.Viewpoint_UpdateWithConditionAsync = exports.Viewpoint_UpdateRecordAsync = exports.Viewpoint_AddNewRecordWithReturnKey = exports.Viewpoint_AddNewRecordWithReturnKeyAsync = exports.Viewpoint_AddNewRecordWithMaxIdAsync = exports.Viewpoint_AddNewRecordAsync = exports.Viewpoint_DelViewpointsByCondAsync = exports.Viewpoint_DelViewpointsAsync = exports.Viewpoint_DelRecordAsync = exports.Viewpoint_GetObjLstByPagerAsync = exports.Viewpoint_GetObjLstByPager_Cache = exports.Viewpoint_GetObjLstByRange = exports.Viewpoint_GetObjLstByRangeAsync = exports.Viewpoint_GetTopObjLstAsync = exports.Viewpoint_GetObjLstByViewpointIdLst_Cache = exports.Viewpoint_GetObjLstByViewpointIdLstAsync = exports.Viewpoint_GetSubObjLst_Cache = exports.Viewpoint_GetObjLst_PureCache = exports.Viewpoint_GetObjLst_Cache = exports.Viewpoint_GetObjLst_sessionStorage_PureCache = exports.Viewpoint_GetObjLst_sessionStorage = exports.Viewpoint_GetObjLstAsync = exports.Viewpoint_GetObjLst_localStorage_PureCache = exports.Viewpoint_GetObjLst_localStorage = exports.Viewpoint_GetObjLst_ClientCache = exports.Viewpoint_GetFirstObjAsync = exports.Viewpoint_GetFirstID = exports.Viewpoint_GetFirstIDAsync = exports.Viewpoint_FilterFunByKey = exports.Viewpoint_SortFunByKey = exports.Viewpoint_SortFun_Defa_2Fld = exports.Viewpoint_SortFun_Defa = exports.Viewpoint_func = exports.Viewpoint_UpdateObjInLst_Cache = exports.Viewpoint_GetObjByViewpointId_localStorage = exports.Viewpoint_GetObjByViewpointId_Cache = exports.Viewpoint_GetObjByViewpointIdAsync = exports.viewpoint_ConstructorName = exports.viewpoint_Controller = void 0;
    /**
     * 观点表(Viewpoint)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2022年11月02日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsViewpointEN_js_1 = require("../../L0_Entity/GraduateEduTopic/clsViewpointEN.js");
    const clsvViewpointWApi_js_1 = require("../../L3_ForWApi/GraduateEduTopic/clsvViewpointWApi.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    const CacheHelper_js_2 = require("../../PubFun/CacheHelper.js");
    const jsString_js_1 = require("../../PubFun/jsString.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.viewpoint_Controller = "ViewpointApi";
    exports.viewpoint_ConstructorName = "viewpoint";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strViewpointId:关键字
    * @returns 对象
    **/
    async function Viewpoint_GetObjByViewpointIdAsync(strViewpointId) {
        const strThisFuncName = "GetObjByViewpointIdAsync";
        if ((0, clsString_js_1.IsNullOrEmpty)(strViewpointId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strViewpointId]不能为空！(In GetObjByViewpointIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strViewpointId.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strViewpointId]的长度:[{0}]不正确！", strViewpointId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByViewpointId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpoint_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "strViewpointId": strViewpointId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.viewpoint_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objViewpoint = Viewpoint_GetObjFromJsonObj(returnObj);
                return objViewpoint;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Viewpoint_GetObjByViewpointIdAsync = Viewpoint_GetObjByViewpointIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param strViewpointId:所给的关键字
     * @returns 对象
    */
    async function Viewpoint_GetObjByViewpointId_Cache(strViewpointId, strid_CurrEduCls, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByViewpointId_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strViewpointId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strViewpointId]不能为空！(In GetObjByViewpointId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strViewpointId.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strViewpointId]的长度:[{0}]不正确！", strViewpointId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrViewpointObjLst_Cache = await Viewpoint_GetObjLst_Cache(strid_CurrEduCls);
        try {
            const arrViewpoint_Sel = arrViewpointObjLst_Cache.filter(x => x.viewpointId == strViewpointId);
            let objViewpoint;
            if (arrViewpoint_Sel.length > 0) {
                objViewpoint = arrViewpoint_Sel[0];
                return objViewpoint;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    objViewpoint = await Viewpoint_GetObjByViewpointIdAsync(strViewpointId);
                    if (objViewpoint != null) {
                        Viewpoint_ReFreshThisCache(strid_CurrEduCls);
                        return objViewpoint;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strViewpointId, exports.viewpoint_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.Viewpoint_GetObjByViewpointId_Cache = Viewpoint_GetObjByViewpointId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param strViewpointId:所给的关键字
     * @returns 对象
    */
    async function Viewpoint_GetObjByViewpointId_localStorage(strViewpointId) {
        const strThisFuncName = "GetObjByViewpointId_localStorage";
        if ((0, clsString_js_1.IsNullOrEmpty)(strViewpointId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strViewpointId]不能为空！(In GetObjByViewpointId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strViewpointId.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strViewpointId]的长度:[{0}]不正确！", strViewpointId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsViewpointEN_js_1.clsViewpointEN._CurrTabName, strViewpointId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objViewpoint_Cache = JSON.parse(strTempObj);
            return objViewpoint_Cache;
        }
        try {
            const objViewpoint = await Viewpoint_GetObjByViewpointIdAsync(strViewpointId);
            if (objViewpoint != null) {
                localStorage.setItem(strKey, JSON.stringify(objViewpoint));
                const strInfo = (0, clsString_js_1.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objViewpoint;
            }
            return objViewpoint;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strViewpointId, exports.viewpoint_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.Viewpoint_GetObjByViewpointId_localStorage = Viewpoint_GetObjByViewpointId_localStorage;
    /**
     * 修改在缓存对象列表中的对象, 与后台数据库无关.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
     * @param objViewpoint:所给的对象
     * @returns 对象
    */
    async function Viewpoint_UpdateObjInLst_Cache(objViewpoint, strid_CurrEduCls) {
        const strThisFuncName = "UpdateObjInLst_Cache";
        try {
            const arrViewpointObjLst_Cache = await Viewpoint_GetObjLst_Cache(strid_CurrEduCls);
            const obj = arrViewpointObjLst_Cache.find(x => x.viewpointId == objViewpoint.viewpointId);
            if (obj != null) {
                objViewpoint.viewpointId = obj.viewpointId;
                (0, clsCommFunc4Web_js_1.ObjectAssign)(obj, objViewpoint);
            }
            else {
                arrViewpointObjLst_Cache.push(objViewpoint);
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, exports.viewpoint_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.Viewpoint_UpdateObjInLst_Cache = Viewpoint_UpdateObjInLst_Cache;
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
    async function Viewpoint_func(strInFldName, strOutFldName, strInValue, strid_CurrEduCls_C) {
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
        if (strInFldName != clsViewpointEN_js_1.clsViewpointEN.con_ViewpointId) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsViewpointEN_js_1.clsViewpointEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_1.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strInFldName, clsViewpointEN_js_1.clsViewpointEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strViewpointId = strInValue;
        if ((0, clsString_js_1.IsNullOrEmpty)(strInValue) == true) {
            return "";
        }
        const objViewpoint = await Viewpoint_GetObjByViewpointId_Cache(strViewpointId, strid_CurrEduCls_C);
        if (objViewpoint == null)
            return "";
        return objViewpoint.GetFldValue(strOutFldName).toString();
    }
    exports.Viewpoint_func = Viewpoint_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function Viewpoint_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.viewpointId.localeCompare(b.viewpointId);
    }
    exports.Viewpoint_SortFun_Defa = Viewpoint_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function Viewpoint_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.viewpointName == b.viewpointName)
            return a.viewpointContent.localeCompare(b.viewpointContent);
        else
            return a.viewpointName.localeCompare(b.viewpointName);
    }
    exports.Viewpoint_SortFun_Defa_2Fld = Viewpoint_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function Viewpoint_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsViewpointEN_js_1.clsViewpointEN.con_ViewpointId:
                    return (a, b) => {
                        return a.viewpointId.localeCompare(b.viewpointId);
                    };
                case clsViewpointEN_js_1.clsViewpointEN.con_ViewpointName:
                    return (a, b) => {
                        return a.viewpointName.localeCompare(b.viewpointName);
                    };
                case clsViewpointEN_js_1.clsViewpointEN.con_ViewpointContent:
                    return (a, b) => {
                        return a.viewpointContent.localeCompare(b.viewpointContent);
                    };
                case clsViewpointEN_js_1.clsViewpointEN.con_ViewpointTypeId:
                    return (a, b) => {
                        return a.viewpointTypeId.localeCompare(b.viewpointTypeId);
                    };
                case clsViewpointEN_js_1.clsViewpointEN.con_Reason:
                    return (a, b) => {
                        return a.reason.localeCompare(b.reason);
                    };
                case clsViewpointEN_js_1.clsViewpointEN.con_Source:
                    return (a, b) => {
                        return a.source.localeCompare(b.source);
                    };
                case clsViewpointEN_js_1.clsViewpointEN.con_VPProposePeople:
                    return (a, b) => {
                        return a.vpProposePeople.localeCompare(b.vpProposePeople);
                    };
                case clsViewpointEN_js_1.clsViewpointEN.con_UpdDate:
                    return (a, b) => {
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsViewpointEN_js_1.clsViewpointEN.con_UpdUser:
                    return (a, b) => {
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsViewpointEN_js_1.clsViewpointEN.con_Memo:
                    return (a, b) => {
                        return a.memo.localeCompare(b.memo);
                    };
                case clsViewpointEN_js_1.clsViewpointEN.con_IsSubmit:
                    return (a, b) => {
                        if (a.isSubmit == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsViewpointEN_js_1.clsViewpointEN.con_UserTypeId:
                    return (a, b) => {
                        return a.userTypeId.localeCompare(b.userTypeId);
                    };
                case clsViewpointEN_js_1.clsViewpointEN.con_CitationId:
                    return (a, b) => {
                        return a.citationId.localeCompare(b.citationId);
                    };
                case clsViewpointEN_js_1.clsViewpointEN.con_AppraiseCount:
                    return (a, b) => {
                        return a.appraiseCount - b.appraiseCount;
                    };
                case clsViewpointEN_js_1.clsViewpointEN.con_OkCount:
                    return (a, b) => {
                        return a.okCount - b.okCount;
                    };
                case clsViewpointEN_js_1.clsViewpointEN.con_score:
                    return (a, b) => {
                        return a.score - b.score;
                    };
                case clsViewpointEN_js_1.clsViewpointEN.con_StuScore:
                    return (a, b) => {
                        return a.stuScore - b.stuScore;
                    };
                case clsViewpointEN_js_1.clsViewpointEN.con_TeaScore:
                    return (a, b) => {
                        return a.teaScore - b.teaScore;
                    };
                case clsViewpointEN_js_1.clsViewpointEN.con_id_CurrEduCls:
                    return (a, b) => {
                        return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
                    };
                case clsViewpointEN_js_1.clsViewpointEN.con_PdfContent:
                    return (a, b) => {
                        return a.pdfContent.localeCompare(b.pdfContent);
                    };
                case clsViewpointEN_js_1.clsViewpointEN.con_PdfPageNum:
                    return (a, b) => {
                        return a.pdfPageNum - b.pdfPageNum;
                    };
                case clsViewpointEN_js_1.clsViewpointEN.con_CitationCount:
                    return (a, b) => {
                        return a.citationCount - b.citationCount;
                    };
                case clsViewpointEN_js_1.clsViewpointEN.con_VersionCount:
                    return (a, b) => {
                        return a.versionCount - b.versionCount;
                    };
                case clsViewpointEN_js_1.clsViewpointEN.con_CreateDate:
                    return (a, b) => {
                        return a.createDate.localeCompare(b.createDate);
                    };
                case clsViewpointEN_js_1.clsViewpointEN.con_ShareId:
                    return (a, b) => {
                        return a.shareId.localeCompare(b.shareId);
                    };
                case clsViewpointEN_js_1.clsViewpointEN.con_IsRecommend:
                    return (a, b) => {
                        if (a.isRecommend == true)
                            return 1;
                        else
                            return -1;
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[Viewpoint]中不存在！(in ${exports.viewpoint_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsViewpointEN_js_1.clsViewpointEN.con_ViewpointId:
                    return (a, b) => {
                        return b.viewpointId.localeCompare(a.viewpointId);
                    };
                case clsViewpointEN_js_1.clsViewpointEN.con_ViewpointName:
                    return (a, b) => {
                        return b.viewpointName.localeCompare(a.viewpointName);
                    };
                case clsViewpointEN_js_1.clsViewpointEN.con_ViewpointContent:
                    return (a, b) => {
                        return b.viewpointContent.localeCompare(a.viewpointContent);
                    };
                case clsViewpointEN_js_1.clsViewpointEN.con_ViewpointTypeId:
                    return (a, b) => {
                        return b.viewpointTypeId.localeCompare(a.viewpointTypeId);
                    };
                case clsViewpointEN_js_1.clsViewpointEN.con_Reason:
                    return (a, b) => {
                        return b.reason.localeCompare(a.reason);
                    };
                case clsViewpointEN_js_1.clsViewpointEN.con_Source:
                    return (a, b) => {
                        return b.source.localeCompare(a.source);
                    };
                case clsViewpointEN_js_1.clsViewpointEN.con_VPProposePeople:
                    return (a, b) => {
                        return b.vpProposePeople.localeCompare(a.vpProposePeople);
                    };
                case clsViewpointEN_js_1.clsViewpointEN.con_UpdDate:
                    return (a, b) => {
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsViewpointEN_js_1.clsViewpointEN.con_UpdUser:
                    return (a, b) => {
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsViewpointEN_js_1.clsViewpointEN.con_Memo:
                    return (a, b) => {
                        return b.memo.localeCompare(a.memo);
                    };
                case clsViewpointEN_js_1.clsViewpointEN.con_IsSubmit:
                    return (a, b) => {
                        if (b.isSubmit == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsViewpointEN_js_1.clsViewpointEN.con_UserTypeId:
                    return (a, b) => {
                        return b.userTypeId.localeCompare(a.userTypeId);
                    };
                case clsViewpointEN_js_1.clsViewpointEN.con_CitationId:
                    return (a, b) => {
                        return b.citationId.localeCompare(a.citationId);
                    };
                case clsViewpointEN_js_1.clsViewpointEN.con_AppraiseCount:
                    return (a, b) => {
                        return b.appraiseCount - a.appraiseCount;
                    };
                case clsViewpointEN_js_1.clsViewpointEN.con_OkCount:
                    return (a, b) => {
                        return b.okCount - a.okCount;
                    };
                case clsViewpointEN_js_1.clsViewpointEN.con_score:
                    return (a, b) => {
                        return b.score - a.score;
                    };
                case clsViewpointEN_js_1.clsViewpointEN.con_StuScore:
                    return (a, b) => {
                        return b.stuScore - a.stuScore;
                    };
                case clsViewpointEN_js_1.clsViewpointEN.con_TeaScore:
                    return (a, b) => {
                        return b.teaScore - a.teaScore;
                    };
                case clsViewpointEN_js_1.clsViewpointEN.con_id_CurrEduCls:
                    return (a, b) => {
                        return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
                    };
                case clsViewpointEN_js_1.clsViewpointEN.con_PdfContent:
                    return (a, b) => {
                        return b.pdfContent.localeCompare(a.pdfContent);
                    };
                case clsViewpointEN_js_1.clsViewpointEN.con_PdfPageNum:
                    return (a, b) => {
                        return b.pdfPageNum - a.pdfPageNum;
                    };
                case clsViewpointEN_js_1.clsViewpointEN.con_CitationCount:
                    return (a, b) => {
                        return b.citationCount - a.citationCount;
                    };
                case clsViewpointEN_js_1.clsViewpointEN.con_VersionCount:
                    return (a, b) => {
                        return b.versionCount - a.versionCount;
                    };
                case clsViewpointEN_js_1.clsViewpointEN.con_CreateDate:
                    return (a, b) => {
                        return b.createDate.localeCompare(a.createDate);
                    };
                case clsViewpointEN_js_1.clsViewpointEN.con_ShareId:
                    return (a, b) => {
                        return b.shareId.localeCompare(a.shareId);
                    };
                case clsViewpointEN_js_1.clsViewpointEN.con_IsRecommend:
                    return (a, b) => {
                        if (b.isRecommend == true)
                            return 1;
                        else
                            return -1;
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[Viewpoint]中不存在！(in ${exports.viewpoint_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.Viewpoint_SortFunByKey = Viewpoint_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function Viewpoint_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsViewpointEN_js_1.clsViewpointEN.con_ViewpointId:
                return (obj) => {
                    return obj.viewpointId === value;
                };
            case clsViewpointEN_js_1.clsViewpointEN.con_ViewpointName:
                return (obj) => {
                    return obj.viewpointName === value;
                };
            case clsViewpointEN_js_1.clsViewpointEN.con_ViewpointContent:
                return (obj) => {
                    return obj.viewpointContent === value;
                };
            case clsViewpointEN_js_1.clsViewpointEN.con_ViewpointTypeId:
                return (obj) => {
                    return obj.viewpointTypeId === value;
                };
            case clsViewpointEN_js_1.clsViewpointEN.con_Reason:
                return (obj) => {
                    return obj.reason === value;
                };
            case clsViewpointEN_js_1.clsViewpointEN.con_Source:
                return (obj) => {
                    return obj.source === value;
                };
            case clsViewpointEN_js_1.clsViewpointEN.con_VPProposePeople:
                return (obj) => {
                    return obj.vpProposePeople === value;
                };
            case clsViewpointEN_js_1.clsViewpointEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsViewpointEN_js_1.clsViewpointEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsViewpointEN_js_1.clsViewpointEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            case clsViewpointEN_js_1.clsViewpointEN.con_IsSubmit:
                return (obj) => {
                    return obj.isSubmit === value;
                };
            case clsViewpointEN_js_1.clsViewpointEN.con_UserTypeId:
                return (obj) => {
                    return obj.userTypeId === value;
                };
            case clsViewpointEN_js_1.clsViewpointEN.con_CitationId:
                return (obj) => {
                    return obj.citationId === value;
                };
            case clsViewpointEN_js_1.clsViewpointEN.con_AppraiseCount:
                return (obj) => {
                    return obj.appraiseCount === value;
                };
            case clsViewpointEN_js_1.clsViewpointEN.con_OkCount:
                return (obj) => {
                    return obj.okCount === value;
                };
            case clsViewpointEN_js_1.clsViewpointEN.con_score:
                return (obj) => {
                    return obj.score === value;
                };
            case clsViewpointEN_js_1.clsViewpointEN.con_StuScore:
                return (obj) => {
                    return obj.stuScore === value;
                };
            case clsViewpointEN_js_1.clsViewpointEN.con_TeaScore:
                return (obj) => {
                    return obj.teaScore === value;
                };
            case clsViewpointEN_js_1.clsViewpointEN.con_id_CurrEduCls:
                return (obj) => {
                    return obj.id_CurrEduCls === value;
                };
            case clsViewpointEN_js_1.clsViewpointEN.con_PdfContent:
                return (obj) => {
                    return obj.pdfContent === value;
                };
            case clsViewpointEN_js_1.clsViewpointEN.con_PdfPageNum:
                return (obj) => {
                    return obj.pdfPageNum === value;
                };
            case clsViewpointEN_js_1.clsViewpointEN.con_CitationCount:
                return (obj) => {
                    return obj.citationCount === value;
                };
            case clsViewpointEN_js_1.clsViewpointEN.con_VersionCount:
                return (obj) => {
                    return obj.versionCount === value;
                };
            case clsViewpointEN_js_1.clsViewpointEN.con_CreateDate:
                return (obj) => {
                    return obj.createDate === value;
                };
            case clsViewpointEN_js_1.clsViewpointEN.con_ShareId:
                return (obj) => {
                    return obj.shareId === value;
                };
            case clsViewpointEN_js_1.clsViewpointEN.con_IsRecommend:
                return (obj) => {
                    return obj.isRecommend === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[Viewpoint]中不存在！(in ${exports.viewpoint_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.Viewpoint_FilterFunByKey = Viewpoint_FilterFunByKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function Viewpoint_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpoint_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Viewpoint_GetFirstIDAsync = Viewpoint_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function Viewpoint_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpoint_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Viewpoint_GetFirstID = Viewpoint_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function Viewpoint_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpoint_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.viewpoint_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objViewpoint = Viewpoint_GetObjFromJsonObj(returnObj);
                return objViewpoint;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Viewpoint_GetFirstObjAsync = Viewpoint_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function Viewpoint_GetObjLst_ClientCache(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsViewpointEN_js_1.clsViewpointEN._CurrTabName, strid_CurrEduCls);
        clsViewpointEN_js_1.clsViewpointEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsViewpointEN_js_1.clsViewpointEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsViewpointEN_js_1.clsViewpointEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsViewpointEN_js_1.clsViewpointEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_2.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrViewpointExObjLst_Cache = CacheHelper_js_2.CacheHelper.Get(strKey);
            const arrViewpointObjLst_T = Viewpoint_GetObjLstByJSONObjLst(arrViewpointExObjLst_Cache);
            return arrViewpointObjLst_T;
        }
        try {
            const arrViewpointExObjLst = await Viewpoint_GetObjLstAsync(strWhereCond);
            CacheHelper_js_2.CacheHelper.Add(strKey, arrViewpointExObjLst);
            const strInfo = (0, clsString_js_1.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrViewpointExObjLst.length);
            console.log(strInfo);
            return arrViewpointExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.viewpoint_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.Viewpoint_GetObjLst_ClientCache = Viewpoint_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function Viewpoint_GetObjLst_localStorage(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsViewpointEN_js_1.clsViewpointEN._CurrTabName, strid_CurrEduCls);
        clsViewpointEN_js_1.clsViewpointEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsViewpointEN_js_1.clsViewpointEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsViewpointEN_js_1.clsViewpointEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsViewpointEN_js_1.clsViewpointEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrViewpointExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrViewpointObjLst_T = Viewpoint_GetObjLstByJSONObjLst(arrViewpointExObjLst_Cache);
            return arrViewpointObjLst_T;
        }
        try {
            const arrViewpointExObjLst = await Viewpoint_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrViewpointExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrViewpointExObjLst.length);
            console.log(strInfo);
            return arrViewpointExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.viewpoint_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.Viewpoint_GetObjLst_localStorage = Viewpoint_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function Viewpoint_GetObjLst_localStorage_PureCache(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsViewpointEN_js_1.clsViewpointEN._CurrTabName, strid_CurrEduCls);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrViewpointObjLst_Cache = JSON.parse(strTempObjLst);
            return arrViewpointObjLst_Cache;
        }
        else
            return null;
    }
    exports.Viewpoint_GetObjLst_localStorage_PureCache = Viewpoint_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function Viewpoint_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpoint_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.viewpoint_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = Viewpoint_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Viewpoint_GetObjLstAsync = Viewpoint_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function Viewpoint_GetObjLst_sessionStorage(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsViewpointEN_js_1.clsViewpointEN._CurrTabName, strid_CurrEduCls);
        clsViewpointEN_js_1.clsViewpointEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsViewpointEN_js_1.clsViewpointEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsViewpointEN_js_1.clsViewpointEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsViewpointEN_js_1.clsViewpointEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrViewpointExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrViewpointObjLst_T = Viewpoint_GetObjLstByJSONObjLst(arrViewpointExObjLst_Cache);
            return arrViewpointObjLst_T;
        }
        try {
            const arrViewpointExObjLst = await Viewpoint_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrViewpointExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrViewpointExObjLst.length);
            console.log(strInfo);
            return arrViewpointExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.viewpoint_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.Viewpoint_GetObjLst_sessionStorage = Viewpoint_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function Viewpoint_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsViewpointEN_js_1.clsViewpointEN._CurrTabName, strid_CurrEduCls);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrViewpointObjLst_Cache = JSON.parse(strTempObjLst);
            return arrViewpointObjLst_Cache;
        }
        else
            return null;
    }
    exports.Viewpoint_GetObjLst_sessionStorage_PureCache = Viewpoint_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function Viewpoint_GetObjLst_Cache(strid_CurrEduCls) {
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
        let arrViewpointObjLst_Cache;
        switch (clsViewpointEN_js_1.clsViewpointEN.CacheModeId) {
            case "04": //sessionStorage
                arrViewpointObjLst_Cache = await Viewpoint_GetObjLst_sessionStorage(strid_CurrEduCls);
                break;
            case "03": //localStorage
                arrViewpointObjLst_Cache = await Viewpoint_GetObjLst_localStorage(strid_CurrEduCls);
                break;
            case "02": //ClientCache
                arrViewpointObjLst_Cache = await Viewpoint_GetObjLst_ClientCache(strid_CurrEduCls);
                break;
            default:
                arrViewpointObjLst_Cache = await Viewpoint_GetObjLst_ClientCache(strid_CurrEduCls);
                break;
        }
        const arrViewpointObjLst = Viewpoint_GetObjLstByJSONObjLst(arrViewpointObjLst_Cache);
        return arrViewpointObjLst_Cache;
    }
    exports.Viewpoint_GetObjLst_Cache = Viewpoint_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function Viewpoint_GetObjLst_PureCache(strid_CurrEduCls) {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrViewpointObjLst_Cache;
        switch (clsViewpointEN_js_1.clsViewpointEN.CacheModeId) {
            case "04": //sessionStorage
                arrViewpointObjLst_Cache = await Viewpoint_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls);
                break;
            case "03": //localStorage
                arrViewpointObjLst_Cache = await Viewpoint_GetObjLst_localStorage_PureCache(strid_CurrEduCls);
                break;
            case "02": //ClientCache
                arrViewpointObjLst_Cache = null;
                break;
            default:
                arrViewpointObjLst_Cache = null;
                break;
        }
        return arrViewpointObjLst_Cache;
    }
    exports.Viewpoint_GetObjLst_PureCache = Viewpoint_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objstrViewpointId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function Viewpoint_GetSubObjLst_Cache(objViewpoint_Cond, strid_CurrEduCls) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrViewpointObjLst_Cache = await Viewpoint_GetObjLst_Cache(strid_CurrEduCls);
        let arrViewpoint_Sel = arrViewpointObjLst_Cache;
        if (objViewpoint_Cond.sf_FldComparisonOp == null || objViewpoint_Cond.sf_FldComparisonOp == "")
            return arrViewpoint_Sel;
        const dicFldComparisonOp = JSON.parse(objViewpoint_Cond.sf_FldComparisonOp);
        //console.log("clsViewpointWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objViewpoint_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrViewpoint_Sel = arrViewpoint_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objViewpoint_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrViewpoint_Sel = arrViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrViewpoint_Sel = arrViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrViewpoint_Sel = arrViewpoint_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrViewpoint_Sel = arrViewpoint_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrViewpoint_Sel = arrViewpoint_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrViewpoint_Sel = arrViewpoint_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrViewpoint_Sel = arrViewpoint_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrViewpoint_Sel = arrViewpoint_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrViewpoint_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objViewpoint_Cond), exports.viewpoint_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.Viewpoint_GetSubObjLst_Cache = Viewpoint_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrViewpointId:关键字列表
    * @returns 对象列表
    **/
    async function Viewpoint_GetObjLstByViewpointIdLstAsync(arrViewpointId) {
        const strThisFuncName = "GetObjLstByViewpointIdLstAsync";
        const strAction = "GetObjLstByViewpointIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpoint_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrViewpointId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.viewpoint_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = Viewpoint_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Viewpoint_GetObjLstByViewpointIdLstAsync = Viewpoint_GetObjLstByViewpointIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrstrViewpointIdLst:关键字列表
     * @returns 对象列表
    */
    async function Viewpoint_GetObjLstByViewpointIdLst_Cache(arrViewpointIdLst, strid_CurrEduCls) {
        const strThisFuncName = "GetObjLstByViewpointIdLst_Cache";
        try {
            const arrViewpointObjLst_Cache = await Viewpoint_GetObjLst_Cache(strid_CurrEduCls);
            const arrViewpoint_Sel = arrViewpointObjLst_Cache.filter(x => arrViewpointIdLst.indexOf(x.viewpointId) > -1);
            return arrViewpoint_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrViewpointIdLst.join(","), exports.viewpoint_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.Viewpoint_GetObjLstByViewpointIdLst_Cache = Viewpoint_GetObjLstByViewpointIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function Viewpoint_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpoint_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.viewpoint_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = Viewpoint_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Viewpoint_GetTopObjLstAsync = Viewpoint_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function Viewpoint_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpoint_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.viewpoint_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = Viewpoint_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Viewpoint_GetObjLstByRangeAsync = Viewpoint_GetObjLstByRangeAsync;
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
    async function Viewpoint_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpoint_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Viewpoint_GetObjLstByRange = Viewpoint_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function Viewpoint_GetObjLstByPager_Cache(objPagerPara, strid_CurrEduCls) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const arrViewpointObjLst_Cache = await Viewpoint_GetObjLst_Cache(strid_CurrEduCls);
        if (arrViewpointObjLst_Cache.length == 0)
            return arrViewpointObjLst_Cache;
        let arrViewpoint_Sel = arrViewpointObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objViewpoint_Cond = new clsViewpointEN_js_1.clsViewpointEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objViewpoint_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsViewpointWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrViewpoint_Sel = arrViewpoint_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objViewpoint_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrViewpoint_Sel = arrViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrViewpoint_Sel = arrViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrViewpoint_Sel = arrViewpoint_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrViewpoint_Sel = arrViewpoint_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrViewpoint_Sel = arrViewpoint_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrViewpoint_Sel = arrViewpoint_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrViewpoint_Sel = arrViewpoint_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrViewpoint_Sel = arrViewpoint_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrViewpoint_Sel = arrViewpoint_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrViewpoint_Sel.length == 0)
                return arrViewpoint_Sel;
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
                arrViewpoint_Sel = arrViewpoint_Sel.sort(Viewpoint_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrViewpoint_Sel = arrViewpoint_Sel.sort(objPagerPara.sortFun);
            }
            arrViewpoint_Sel = arrViewpoint_Sel.slice(intStart, intEnd);
            return arrViewpoint_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.viewpoint_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.Viewpoint_GetObjLstByPager_Cache = Viewpoint_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function Viewpoint_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpoint_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.viewpoint_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = Viewpoint_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Viewpoint_GetObjLstByPagerAsync = Viewpoint_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param strViewpointId:关键字
    * @returns 获取删除的结果
    **/
    async function Viewpoint_DelRecordAsync(strViewpointId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpoint_Controller, strAction);
        strUrl = (0, clsString_js_1.Format)("{0}/?Id={1}", strUrl, strViewpointId);
        try {
            const response = await axios_1.default.delete(strUrl, {
                params: { "Id": strViewpointId, }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Viewpoint_DelRecordAsync = Viewpoint_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrViewpointId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function Viewpoint_DelViewpointsAsync(arrViewpointId) {
        const strThisFuncName = "DelViewpointsAsync";
        const strAction = "DelViewpoints";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpoint_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrViewpointId);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Viewpoint_DelViewpointsAsync = Viewpoint_DelViewpointsAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function Viewpoint_DelViewpointsByCondAsync(strWhereCond) {
        const strThisFuncName = "DelViewpointsByCondAsync";
        const strAction = "DelViewpointsByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpoint_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Viewpoint_DelViewpointsByCondAsync = Viewpoint_DelViewpointsByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objViewpointEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function Viewpoint_AddNewRecordAsync(objViewpointEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objViewpointEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpoint_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objViewpointEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Viewpoint_AddNewRecordAsync = Viewpoint_AddNewRecordAsync;
    /**
    * 调用WebApi来添加记录，关键字用最大关键字，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithMaxIdAsync)
    * @param objViewpointEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function Viewpoint_AddNewRecordWithMaxIdAsync(objViewpointEN) {
        const strThisFuncName = "AddNewRecordWithMaxIdAsync";
        const strAction = "AddNewRecordWithMaxId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpoint_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objViewpointEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Viewpoint_AddNewRecordWithMaxIdAsync = Viewpoint_AddNewRecordWithMaxIdAsync;
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objViewpointEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function Viewpoint_AddNewRecordWithReturnKeyAsync(objViewpointEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpoint_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objViewpointEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Viewpoint_AddNewRecordWithReturnKeyAsync = Viewpoint_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objViewpointEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function Viewpoint_AddNewRecordWithReturnKey(objViewpointEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objViewpointEN.viewpointId === null || objViewpointEN.viewpointId === "") {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpoint_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objViewpointEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Viewpoint_AddNewRecordWithReturnKey = Viewpoint_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objViewpointEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function Viewpoint_UpdateRecordAsync(objViewpointEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objViewpointEN.sf_UpdFldSetStr === undefined || objViewpointEN.sf_UpdFldSetStr === null || objViewpointEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objViewpointEN.viewpointId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpoint_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objViewpointEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Viewpoint_UpdateRecordAsync = Viewpoint_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objViewpointEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function Viewpoint_UpdateWithConditionAsync(objViewpointEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objViewpointEN.sf_UpdFldSetStr === undefined || objViewpointEN.sf_UpdFldSetStr === null || objViewpointEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objViewpointEN.viewpointId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpoint_Controller, strAction);
        objViewpointEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objViewpointEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Viewpoint_UpdateWithConditionAsync = Viewpoint_UpdateWithConditionAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objstrViewpointId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function Viewpoint_IsExistRecord_Cache(objViewpoint_Cond, strid_CurrEduCls) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrViewpointObjLst_Cache = await Viewpoint_GetObjLst_Cache(strid_CurrEduCls);
        if (arrViewpointObjLst_Cache == null)
            return false;
        let arrViewpoint_Sel = arrViewpointObjLst_Cache;
        if (objViewpoint_Cond.sf_FldComparisonOp == null || objViewpoint_Cond.sf_FldComparisonOp == "")
            return arrViewpoint_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objViewpoint_Cond.sf_FldComparisonOp);
        //console.log("clsViewpointWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objViewpoint_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objViewpoint_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrViewpoint_Sel = arrViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrViewpoint_Sel = arrViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrViewpoint_Sel = arrViewpoint_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrViewpoint_Sel = arrViewpoint_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrViewpoint_Sel = arrViewpoint_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrViewpoint_Sel = arrViewpoint_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrViewpoint_Sel = arrViewpoint_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrViewpoint_Sel = arrViewpoint_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrViewpoint_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objViewpoint_Cond), exports.viewpoint_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.Viewpoint_IsExistRecord_Cache = Viewpoint_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function Viewpoint_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpoint_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Viewpoint_IsExistRecordAsync = Viewpoint_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strViewpointId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function Viewpoint_IsExist(strViewpointId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpoint_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "ViewpointId": strViewpointId,
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Viewpoint_IsExist = Viewpoint_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param strViewpointId:所给的关键字
     * @returns 对象
    */
    async function Viewpoint_IsExist_Cache(strViewpointId, strid_CurrEduCls) {
        const strThisFuncName = "IsExist_Cache";
        const arrViewpointObjLst_Cache = await Viewpoint_GetObjLst_Cache(strid_CurrEduCls);
        if (arrViewpointObjLst_Cache == null)
            return false;
        try {
            const arrViewpoint_Sel = arrViewpointObjLst_Cache.filter(x => x.viewpointId == strViewpointId);
            if (arrViewpoint_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strViewpointId, exports.viewpoint_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.Viewpoint_IsExist_Cache = Viewpoint_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strViewpointId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function Viewpoint_IsExistAsync(strViewpointId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpoint_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strViewpointId": strViewpointId }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Viewpoint_IsExistAsync = Viewpoint_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function Viewpoint_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpoint_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Viewpoint_GetRecCountByCondAsync = Viewpoint_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objViewpoint_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function Viewpoint_GetRecCountByCond_Cache(objViewpoint_Cond, strid_CurrEduCls) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrViewpointObjLst_Cache = await Viewpoint_GetObjLst_Cache(strid_CurrEduCls);
        if (arrViewpointObjLst_Cache == null)
            return 0;
        let arrViewpoint_Sel = arrViewpointObjLst_Cache;
        if (objViewpoint_Cond.sf_FldComparisonOp == null || objViewpoint_Cond.sf_FldComparisonOp == "")
            return arrViewpoint_Sel.length;
        const dicFldComparisonOp = JSON.parse(objViewpoint_Cond.sf_FldComparisonOp);
        //console.log("clsViewpointWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objViewpoint_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrViewpoint_Sel = arrViewpoint_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objViewpoint_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrViewpoint_Sel = arrViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrViewpoint_Sel = arrViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrViewpoint_Sel = arrViewpoint_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrViewpoint_Sel = arrViewpoint_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrViewpoint_Sel = arrViewpoint_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrViewpoint_Sel = arrViewpoint_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrViewpoint_Sel = arrViewpoint_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrViewpoint_Sel = arrViewpoint_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrViewpoint_Sel = arrViewpoint_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrViewpoint_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objViewpoint_Cond), exports.viewpoint_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.Viewpoint_GetRecCountByCond_Cache = Viewpoint_GetRecCountByCond_Cache;
    /**
    * 获取表的最大关键字
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdAsync)
    * @returns 获取表的最大关键字
    **/
    async function Viewpoint_GetMaxStrIdAsync() {
        const strThisFuncName = "GetMaxStrIdAsync";
        const strAction = "GetMaxStrId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpoint_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Viewpoint_GetMaxStrIdAsync = Viewpoint_GetMaxStrIdAsync;
    /*该表的关键字类型不是字符型带前缀自增，不需要生成获取最大关键字函数！*/
    /**
     * 根据前缀获取当前表关键字值的最大值,再加1,避免重复
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdByPrefix)
     * @param mapParam:参数列表
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 获取当前表关键字值的最大值
    */
    async function Viewpoint_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpoint_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Viewpoint_GetMaxStrIdByPrefix = Viewpoint_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function Viewpoint_GetWebApiUrl(strController, strAction) {
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
    exports.Viewpoint_GetWebApiUrl = Viewpoint_GetWebApiUrl;
    /**
    * 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshCache)
    **/
    function Viewpoint_ReFreshCache(strid_CurrEduCls) {
        const strThisFuncName = "ReFreshCache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strid_CurrEduCls) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strid_CurrEduCls]不能为空！(In clsViewpointWApi.ReFreshCache)");
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
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsViewpointEN_js_1.clsViewpointEN._CurrTabName, strid_CurrEduCls);
        switch (clsViewpointEN_js_1.clsViewpointEN.CacheModeId) {
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
        (0, clsvViewpointWApi_js_1.vViewpoint_ReFreshThisCache)(strid_CurrEduCls);
    }
    exports.Viewpoint_ReFreshCache = Viewpoint_ReFreshCache;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function Viewpoint_ReFreshThisCache(strid_CurrEduCls) {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsViewpointEN_js_1.clsViewpointEN._CurrTabName, strid_CurrEduCls);
            switch (clsViewpointEN_js_1.clsViewpointEN.CacheModeId) {
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
    exports.Viewpoint_ReFreshThisCache = Viewpoint_ReFreshThisCache;
    /* 该表的下拉框功能没有设置，不需要生成下拉框绑定函数。*/
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function Viewpoint_CheckPropertyNew(pobjViewpointEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjViewpointEN.viewpointId) == false && (0, clsString_js_1.GetStrLen)(pobjViewpointEN.viewpointId) > 8) {
            throw new Error("(errid:Watl000059)字段[观点Id(viewpointId)]的长度不能超过8(In 观点表(Viewpoint))!值:$(pobjViewpointEN.viewpointId)(clsViewpointBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjViewpointEN.viewpointName) == false && (0, clsString_js_1.GetStrLen)(pobjViewpointEN.viewpointName) > 500) {
            throw new Error("(errid:Watl000059)字段[观点名称(viewpointName)]的长度不能超过500(In 观点表(Viewpoint))!值:$(pobjViewpointEN.viewpointName)(clsViewpointBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjViewpointEN.viewpointTypeId) == false && (0, clsString_js_1.GetStrLen)(pobjViewpointEN.viewpointTypeId) > 4) {
            throw new Error("(errid:Watl000059)字段[观点类型Id(viewpointTypeId)]的长度不能超过4(In 观点表(Viewpoint))!值:$(pobjViewpointEN.viewpointTypeId)(clsViewpointBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjViewpointEN.source) == false && (0, clsString_js_1.GetStrLen)(pobjViewpointEN.source) > 500) {
            throw new Error("(errid:Watl000059)字段[来源(source)]的长度不能超过500(In 观点表(Viewpoint))!值:$(pobjViewpointEN.source)(clsViewpointBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjViewpointEN.vpProposePeople) == false && (0, clsString_js_1.GetStrLen)(pobjViewpointEN.vpProposePeople) > 50) {
            throw new Error("(errid:Watl000059)字段[观点提出人(vpProposePeople)]的长度不能超过50(In 观点表(Viewpoint))!值:$(pobjViewpointEN.vpProposePeople)(clsViewpointBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjViewpointEN.updDate) == false && (0, clsString_js_1.GetStrLen)(pobjViewpointEN.updDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 观点表(Viewpoint))!值:$(pobjViewpointEN.updDate)(clsViewpointBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjViewpointEN.updUser) == false && (0, clsString_js_1.GetStrLen)(pobjViewpointEN.updUser) > 20) {
            throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 观点表(Viewpoint))!值:$(pobjViewpointEN.updUser)(clsViewpointBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjViewpointEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjViewpointEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 观点表(Viewpoint))!值:$(pobjViewpointEN.memo)(clsViewpointBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjViewpointEN.userTypeId) == false && (0, clsString_js_1.GetStrLen)(pobjViewpointEN.userTypeId) > 2) {
            throw new Error("(errid:Watl000059)字段[用户类型Id(userTypeId)]的长度不能超过2(In 观点表(Viewpoint))!值:$(pobjViewpointEN.userTypeId)(clsViewpointBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjViewpointEN.citationId) == false && (0, clsString_js_1.GetStrLen)(pobjViewpointEN.citationId) > 8) {
            throw new Error("(errid:Watl000059)字段[引用Id(citationId)]的长度不能超过8(In 观点表(Viewpoint))!值:$(pobjViewpointEN.citationId)(clsViewpointBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjViewpointEN.id_CurrEduCls) == false && (0, clsString_js_1.GetStrLen)(pobjViewpointEN.id_CurrEduCls) > 8) {
            throw new Error("(errid:Watl000059)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 观点表(Viewpoint))!值:$(pobjViewpointEN.id_CurrEduCls)(clsViewpointBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjViewpointEN.pdfContent) == false && (0, clsString_js_1.GetStrLen)(pobjViewpointEN.pdfContent) > 2000) {
            throw new Error("(errid:Watl000059)字段[Pdf内容(pdfContent)]的长度不能超过2000(In 观点表(Viewpoint))!值:$(pobjViewpointEN.pdfContent)(clsViewpointBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjViewpointEN.createDate) == false && (0, clsString_js_1.GetStrLen)(pobjViewpointEN.createDate) > 20) {
            throw new Error("(errid:Watl000059)字段[建立日期(createDate)]的长度不能超过20(In 观点表(Viewpoint))!值:$(pobjViewpointEN.createDate)(clsViewpointBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjViewpointEN.shareId) == false && (0, clsString_js_1.GetStrLen)(pobjViewpointEN.shareId) > 2) {
            throw new Error("(errid:Watl000059)字段[分享Id(shareId)]的长度不能超过2(In 观点表(Viewpoint))!值:$(pobjViewpointEN.shareId)(clsViewpointBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjViewpointEN.viewpointId) == false && undefined !== pobjViewpointEN.viewpointId && jsString_js_1.tzDataType.isString(pobjViewpointEN.viewpointId) === false) {
            throw new Error("(errid:Watl000060)字段[观点Id(viewpointId)]的值:[$(pobjViewpointEN.viewpointId)], 非法，应该为字符型(In 观点表(Viewpoint))!(clsViewpointBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjViewpointEN.viewpointName) == false && undefined !== pobjViewpointEN.viewpointName && jsString_js_1.tzDataType.isString(pobjViewpointEN.viewpointName) === false) {
            throw new Error("(errid:Watl000060)字段[观点名称(viewpointName)]的值:[$(pobjViewpointEN.viewpointName)], 非法，应该为字符型(In 观点表(Viewpoint))!(clsViewpointBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjViewpointEN.viewpointContent) == false && undefined !== pobjViewpointEN.viewpointContent && jsString_js_1.tzDataType.isString(pobjViewpointEN.viewpointContent) === false) {
            throw new Error("(errid:Watl000060)字段[观点内容(viewpointContent)]的值:[$(pobjViewpointEN.viewpointContent)], 非法，应该为字符型(In 观点表(Viewpoint))!(clsViewpointBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjViewpointEN.viewpointTypeId) == false && undefined !== pobjViewpointEN.viewpointTypeId && jsString_js_1.tzDataType.isString(pobjViewpointEN.viewpointTypeId) === false) {
            throw new Error("(errid:Watl000060)字段[观点类型Id(viewpointTypeId)]的值:[$(pobjViewpointEN.viewpointTypeId)], 非法，应该为字符型(In 观点表(Viewpoint))!(clsViewpointBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjViewpointEN.reason) == false && undefined !== pobjViewpointEN.reason && jsString_js_1.tzDataType.isString(pobjViewpointEN.reason) === false) {
            throw new Error("(errid:Watl000060)字段[理由(reason)]的值:[$(pobjViewpointEN.reason)], 非法，应该为字符型(In 观点表(Viewpoint))!(clsViewpointBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjViewpointEN.source) == false && undefined !== pobjViewpointEN.source && jsString_js_1.tzDataType.isString(pobjViewpointEN.source) === false) {
            throw new Error("(errid:Watl000060)字段[来源(source)]的值:[$(pobjViewpointEN.source)], 非法，应该为字符型(In 观点表(Viewpoint))!(clsViewpointBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjViewpointEN.vpProposePeople) == false && undefined !== pobjViewpointEN.vpProposePeople && jsString_js_1.tzDataType.isString(pobjViewpointEN.vpProposePeople) === false) {
            throw new Error("(errid:Watl000060)字段[观点提出人(vpProposePeople)]的值:[$(pobjViewpointEN.vpProposePeople)], 非法，应该为字符型(In 观点表(Viewpoint))!(clsViewpointBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjViewpointEN.updDate) == false && undefined !== pobjViewpointEN.updDate && jsString_js_1.tzDataType.isString(pobjViewpointEN.updDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjViewpointEN.updDate)], 非法，应该为字符型(In 观点表(Viewpoint))!(clsViewpointBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjViewpointEN.updUser) == false && undefined !== pobjViewpointEN.updUser && jsString_js_1.tzDataType.isString(pobjViewpointEN.updUser) === false) {
            throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjViewpointEN.updUser)], 非法，应该为字符型(In 观点表(Viewpoint))!(clsViewpointBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjViewpointEN.memo) == false && undefined !== pobjViewpointEN.memo && jsString_js_1.tzDataType.isString(pobjViewpointEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjViewpointEN.memo)], 非法，应该为字符型(In 观点表(Viewpoint))!(clsViewpointBL:CheckPropertyNew)");
        }
        if (null != pobjViewpointEN.isSubmit && undefined !== pobjViewpointEN.isSubmit && jsString_js_1.tzDataType.isBoolean(pobjViewpointEN.isSubmit) === false) {
            throw new Error("(errid:Watl000060)字段[是否提交(isSubmit)]的值:[$(pobjViewpointEN.isSubmit)], 非法，应该为布尔型(In 观点表(Viewpoint))!(clsViewpointBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjViewpointEN.userTypeId) == false && undefined !== pobjViewpointEN.userTypeId && jsString_js_1.tzDataType.isString(pobjViewpointEN.userTypeId) === false) {
            throw new Error("(errid:Watl000060)字段[用户类型Id(userTypeId)]的值:[$(pobjViewpointEN.userTypeId)], 非法，应该为字符型(In 观点表(Viewpoint))!(clsViewpointBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjViewpointEN.citationId) == false && undefined !== pobjViewpointEN.citationId && jsString_js_1.tzDataType.isString(pobjViewpointEN.citationId) === false) {
            throw new Error("(errid:Watl000060)字段[引用Id(citationId)]的值:[$(pobjViewpointEN.citationId)], 非法，应该为字符型(In 观点表(Viewpoint))!(clsViewpointBL:CheckPropertyNew)");
        }
        if (null != pobjViewpointEN.appraiseCount && undefined !== pobjViewpointEN.appraiseCount && jsString_js_1.tzDataType.isNumber(pobjViewpointEN.appraiseCount) === false) {
            throw new Error("(errid:Watl000060)字段[评论数(appraiseCount)]的值:[$(pobjViewpointEN.appraiseCount)], 非法，应该为数值型(In 观点表(Viewpoint))!(clsViewpointBL:CheckPropertyNew)");
        }
        if (null != pobjViewpointEN.okCount && undefined !== pobjViewpointEN.okCount && jsString_js_1.tzDataType.isNumber(pobjViewpointEN.okCount) === false) {
            throw new Error("(errid:Watl000060)字段[点赞统计(okCount)]的值:[$(pobjViewpointEN.okCount)], 非法，应该为数值型(In 观点表(Viewpoint))!(clsViewpointBL:CheckPropertyNew)");
        }
        if (null != pobjViewpointEN.score && undefined !== pobjViewpointEN.score && jsString_js_1.tzDataType.isNumber(pobjViewpointEN.score) === false) {
            throw new Error("(errid:Watl000060)字段[评分(score)]的值:[$(pobjViewpointEN.score)], 非法，应该为数值型(In 观点表(Viewpoint))!(clsViewpointBL:CheckPropertyNew)");
        }
        if (null != pobjViewpointEN.stuScore && undefined !== pobjViewpointEN.stuScore && jsString_js_1.tzDataType.isNumber(pobjViewpointEN.stuScore) === false) {
            throw new Error("(errid:Watl000060)字段[学生平均分(stuScore)]的值:[$(pobjViewpointEN.stuScore)], 非法，应该为数值型(In 观点表(Viewpoint))!(clsViewpointBL:CheckPropertyNew)");
        }
        if (null != pobjViewpointEN.teaScore && undefined !== pobjViewpointEN.teaScore && jsString_js_1.tzDataType.isNumber(pobjViewpointEN.teaScore) === false) {
            throw new Error("(errid:Watl000060)字段[教师评分(teaScore)]的值:[$(pobjViewpointEN.teaScore)], 非法，应该为数值型(In 观点表(Viewpoint))!(clsViewpointBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjViewpointEN.id_CurrEduCls) == false && undefined !== pobjViewpointEN.id_CurrEduCls && jsString_js_1.tzDataType.isString(pobjViewpointEN.id_CurrEduCls) === false) {
            throw new Error("(errid:Watl000060)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjViewpointEN.id_CurrEduCls)], 非法，应该为字符型(In 观点表(Viewpoint))!(clsViewpointBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjViewpointEN.pdfContent) == false && undefined !== pobjViewpointEN.pdfContent && jsString_js_1.tzDataType.isString(pobjViewpointEN.pdfContent) === false) {
            throw new Error("(errid:Watl000060)字段[Pdf内容(pdfContent)]的值:[$(pobjViewpointEN.pdfContent)], 非法，应该为字符型(In 观点表(Viewpoint))!(clsViewpointBL:CheckPropertyNew)");
        }
        if (null != pobjViewpointEN.pdfPageNum && undefined !== pobjViewpointEN.pdfPageNum && jsString_js_1.tzDataType.isNumber(pobjViewpointEN.pdfPageNum) === false) {
            throw new Error("(errid:Watl000060)字段[Pdf页码(pdfPageNum)]的值:[$(pobjViewpointEN.pdfPageNum)], 非法，应该为数值型(In 观点表(Viewpoint))!(clsViewpointBL:CheckPropertyNew)");
        }
        if (null != pobjViewpointEN.citationCount && undefined !== pobjViewpointEN.citationCount && jsString_js_1.tzDataType.isNumber(pobjViewpointEN.citationCount) === false) {
            throw new Error("(errid:Watl000060)字段[引用统计(citationCount)]的值:[$(pobjViewpointEN.citationCount)], 非法，应该为数值型(In 观点表(Viewpoint))!(clsViewpointBL:CheckPropertyNew)");
        }
        if (null != pobjViewpointEN.versionCount && undefined !== pobjViewpointEN.versionCount && jsString_js_1.tzDataType.isNumber(pobjViewpointEN.versionCount) === false) {
            throw new Error("(errid:Watl000060)字段[版本统计(versionCount)]的值:[$(pobjViewpointEN.versionCount)], 非法，应该为数值型(In 观点表(Viewpoint))!(clsViewpointBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjViewpointEN.createDate) == false && undefined !== pobjViewpointEN.createDate && jsString_js_1.tzDataType.isString(pobjViewpointEN.createDate) === false) {
            throw new Error("(errid:Watl000060)字段[建立日期(createDate)]的值:[$(pobjViewpointEN.createDate)], 非法，应该为字符型(In 观点表(Viewpoint))!(clsViewpointBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjViewpointEN.shareId) == false && undefined !== pobjViewpointEN.shareId && jsString_js_1.tzDataType.isString(pobjViewpointEN.shareId) === false) {
            throw new Error("(errid:Watl000060)字段[分享Id(shareId)]的值:[$(pobjViewpointEN.shareId)], 非法，应该为字符型(In 观点表(Viewpoint))!(clsViewpointBL:CheckPropertyNew)");
        }
        if (null != pobjViewpointEN.isRecommend && undefined !== pobjViewpointEN.isRecommend && jsString_js_1.tzDataType.isBoolean(pobjViewpointEN.isRecommend) === false) {
            throw new Error("(errid:Watl000060)字段[是否推荐(isRecommend)]的值:[$(pobjViewpointEN.isRecommend)], 非法，应该为布尔型(In 观点表(Viewpoint))!(clsViewpointBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjViewpointEN.SetIsCheckProperty(true);
    }
    exports.Viewpoint_CheckPropertyNew = Viewpoint_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function Viewpoint_CheckProperty4Update(pobjViewpointEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjViewpointEN.viewpointId) == false && (0, clsString_js_1.GetStrLen)(pobjViewpointEN.viewpointId) > 8) {
            throw new Error("(errid:Watl000062)字段[观点Id(viewpointId)]的长度不能超过8(In 观点表(Viewpoint))!值:$(pobjViewpointEN.viewpointId)(clsViewpointBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjViewpointEN.viewpointName) == false && (0, clsString_js_1.GetStrLen)(pobjViewpointEN.viewpointName) > 500) {
            throw new Error("(errid:Watl000062)字段[观点名称(viewpointName)]的长度不能超过500(In 观点表(Viewpoint))!值:$(pobjViewpointEN.viewpointName)(clsViewpointBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjViewpointEN.viewpointTypeId) == false && (0, clsString_js_1.GetStrLen)(pobjViewpointEN.viewpointTypeId) > 4) {
            throw new Error("(errid:Watl000062)字段[观点类型Id(viewpointTypeId)]的长度不能超过4(In 观点表(Viewpoint))!值:$(pobjViewpointEN.viewpointTypeId)(clsViewpointBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjViewpointEN.source) == false && (0, clsString_js_1.GetStrLen)(pobjViewpointEN.source) > 500) {
            throw new Error("(errid:Watl000062)字段[来源(source)]的长度不能超过500(In 观点表(Viewpoint))!值:$(pobjViewpointEN.source)(clsViewpointBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjViewpointEN.vpProposePeople) == false && (0, clsString_js_1.GetStrLen)(pobjViewpointEN.vpProposePeople) > 50) {
            throw new Error("(errid:Watl000062)字段[观点提出人(vpProposePeople)]的长度不能超过50(In 观点表(Viewpoint))!值:$(pobjViewpointEN.vpProposePeople)(clsViewpointBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjViewpointEN.updDate) == false && (0, clsString_js_1.GetStrLen)(pobjViewpointEN.updDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 观点表(Viewpoint))!值:$(pobjViewpointEN.updDate)(clsViewpointBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjViewpointEN.updUser) == false && (0, clsString_js_1.GetStrLen)(pobjViewpointEN.updUser) > 20) {
            throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 观点表(Viewpoint))!值:$(pobjViewpointEN.updUser)(clsViewpointBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjViewpointEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjViewpointEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 观点表(Viewpoint))!值:$(pobjViewpointEN.memo)(clsViewpointBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjViewpointEN.userTypeId) == false && (0, clsString_js_1.GetStrLen)(pobjViewpointEN.userTypeId) > 2) {
            throw new Error("(errid:Watl000062)字段[用户类型Id(userTypeId)]的长度不能超过2(In 观点表(Viewpoint))!值:$(pobjViewpointEN.userTypeId)(clsViewpointBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjViewpointEN.citationId) == false && (0, clsString_js_1.GetStrLen)(pobjViewpointEN.citationId) > 8) {
            throw new Error("(errid:Watl000062)字段[引用Id(citationId)]的长度不能超过8(In 观点表(Viewpoint))!值:$(pobjViewpointEN.citationId)(clsViewpointBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjViewpointEN.id_CurrEduCls) == false && (0, clsString_js_1.GetStrLen)(pobjViewpointEN.id_CurrEduCls) > 8) {
            throw new Error("(errid:Watl000062)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 观点表(Viewpoint))!值:$(pobjViewpointEN.id_CurrEduCls)(clsViewpointBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjViewpointEN.pdfContent) == false && (0, clsString_js_1.GetStrLen)(pobjViewpointEN.pdfContent) > 2000) {
            throw new Error("(errid:Watl000062)字段[Pdf内容(pdfContent)]的长度不能超过2000(In 观点表(Viewpoint))!值:$(pobjViewpointEN.pdfContent)(clsViewpointBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjViewpointEN.createDate) == false && (0, clsString_js_1.GetStrLen)(pobjViewpointEN.createDate) > 20) {
            throw new Error("(errid:Watl000062)字段[建立日期(createDate)]的长度不能超过20(In 观点表(Viewpoint))!值:$(pobjViewpointEN.createDate)(clsViewpointBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjViewpointEN.shareId) == false && (0, clsString_js_1.GetStrLen)(pobjViewpointEN.shareId) > 2) {
            throw new Error("(errid:Watl000062)字段[分享Id(shareId)]的长度不能超过2(In 观点表(Viewpoint))!值:$(pobjViewpointEN.shareId)(clsViewpointBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjViewpointEN.viewpointId) == false && undefined !== pobjViewpointEN.viewpointId && jsString_js_1.tzDataType.isString(pobjViewpointEN.viewpointId) === false) {
            throw new Error("(errid:Watl000063)字段[观点Id(viewpointId)]的值:[$(pobjViewpointEN.viewpointId)], 非法，应该为字符型(In 观点表(Viewpoint))!(clsViewpointBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjViewpointEN.viewpointName) == false && undefined !== pobjViewpointEN.viewpointName && jsString_js_1.tzDataType.isString(pobjViewpointEN.viewpointName) === false) {
            throw new Error("(errid:Watl000063)字段[观点名称(viewpointName)]的值:[$(pobjViewpointEN.viewpointName)], 非法，应该为字符型(In 观点表(Viewpoint))!(clsViewpointBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjViewpointEN.viewpointContent) == false && undefined !== pobjViewpointEN.viewpointContent && jsString_js_1.tzDataType.isString(pobjViewpointEN.viewpointContent) === false) {
            throw new Error("(errid:Watl000063)字段[观点内容(viewpointContent)]的值:[$(pobjViewpointEN.viewpointContent)], 非法，应该为字符型(In 观点表(Viewpoint))!(clsViewpointBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjViewpointEN.viewpointTypeId) == false && undefined !== pobjViewpointEN.viewpointTypeId && jsString_js_1.tzDataType.isString(pobjViewpointEN.viewpointTypeId) === false) {
            throw new Error("(errid:Watl000063)字段[观点类型Id(viewpointTypeId)]的值:[$(pobjViewpointEN.viewpointTypeId)], 非法，应该为字符型(In 观点表(Viewpoint))!(clsViewpointBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjViewpointEN.reason) == false && undefined !== pobjViewpointEN.reason && jsString_js_1.tzDataType.isString(pobjViewpointEN.reason) === false) {
            throw new Error("(errid:Watl000063)字段[理由(reason)]的值:[$(pobjViewpointEN.reason)], 非法，应该为字符型(In 观点表(Viewpoint))!(clsViewpointBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjViewpointEN.source) == false && undefined !== pobjViewpointEN.source && jsString_js_1.tzDataType.isString(pobjViewpointEN.source) === false) {
            throw new Error("(errid:Watl000063)字段[来源(source)]的值:[$(pobjViewpointEN.source)], 非法，应该为字符型(In 观点表(Viewpoint))!(clsViewpointBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjViewpointEN.vpProposePeople) == false && undefined !== pobjViewpointEN.vpProposePeople && jsString_js_1.tzDataType.isString(pobjViewpointEN.vpProposePeople) === false) {
            throw new Error("(errid:Watl000063)字段[观点提出人(vpProposePeople)]的值:[$(pobjViewpointEN.vpProposePeople)], 非法，应该为字符型(In 观点表(Viewpoint))!(clsViewpointBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjViewpointEN.updDate) == false && undefined !== pobjViewpointEN.updDate && jsString_js_1.tzDataType.isString(pobjViewpointEN.updDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjViewpointEN.updDate)], 非法，应该为字符型(In 观点表(Viewpoint))!(clsViewpointBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjViewpointEN.updUser) == false && undefined !== pobjViewpointEN.updUser && jsString_js_1.tzDataType.isString(pobjViewpointEN.updUser) === false) {
            throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjViewpointEN.updUser)], 非法，应该为字符型(In 观点表(Viewpoint))!(clsViewpointBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjViewpointEN.memo) == false && undefined !== pobjViewpointEN.memo && jsString_js_1.tzDataType.isString(pobjViewpointEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjViewpointEN.memo)], 非法，应该为字符型(In 观点表(Viewpoint))!(clsViewpointBL:CheckProperty4Update)");
        }
        if (null != pobjViewpointEN.isSubmit && undefined !== pobjViewpointEN.isSubmit && jsString_js_1.tzDataType.isBoolean(pobjViewpointEN.isSubmit) === false) {
            throw new Error("(errid:Watl000063)字段[是否提交(isSubmit)]的值:[$(pobjViewpointEN.isSubmit)], 非法，应该为布尔型(In 观点表(Viewpoint))!(clsViewpointBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjViewpointEN.userTypeId) == false && undefined !== pobjViewpointEN.userTypeId && jsString_js_1.tzDataType.isString(pobjViewpointEN.userTypeId) === false) {
            throw new Error("(errid:Watl000063)字段[用户类型Id(userTypeId)]的值:[$(pobjViewpointEN.userTypeId)], 非法，应该为字符型(In 观点表(Viewpoint))!(clsViewpointBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjViewpointEN.citationId) == false && undefined !== pobjViewpointEN.citationId && jsString_js_1.tzDataType.isString(pobjViewpointEN.citationId) === false) {
            throw new Error("(errid:Watl000063)字段[引用Id(citationId)]的值:[$(pobjViewpointEN.citationId)], 非法，应该为字符型(In 观点表(Viewpoint))!(clsViewpointBL:CheckProperty4Update)");
        }
        if (null != pobjViewpointEN.appraiseCount && undefined !== pobjViewpointEN.appraiseCount && jsString_js_1.tzDataType.isNumber(pobjViewpointEN.appraiseCount) === false) {
            throw new Error("(errid:Watl000063)字段[评论数(appraiseCount)]的值:[$(pobjViewpointEN.appraiseCount)], 非法，应该为数值型(In 观点表(Viewpoint))!(clsViewpointBL:CheckProperty4Update)");
        }
        if (null != pobjViewpointEN.okCount && undefined !== pobjViewpointEN.okCount && jsString_js_1.tzDataType.isNumber(pobjViewpointEN.okCount) === false) {
            throw new Error("(errid:Watl000063)字段[点赞统计(okCount)]的值:[$(pobjViewpointEN.okCount)], 非法，应该为数值型(In 观点表(Viewpoint))!(clsViewpointBL:CheckProperty4Update)");
        }
        if (null != pobjViewpointEN.score && undefined !== pobjViewpointEN.score && jsString_js_1.tzDataType.isNumber(pobjViewpointEN.score) === false) {
            throw new Error("(errid:Watl000063)字段[评分(score)]的值:[$(pobjViewpointEN.score)], 非法，应该为数值型(In 观点表(Viewpoint))!(clsViewpointBL:CheckProperty4Update)");
        }
        if (null != pobjViewpointEN.stuScore && undefined !== pobjViewpointEN.stuScore && jsString_js_1.tzDataType.isNumber(pobjViewpointEN.stuScore) === false) {
            throw new Error("(errid:Watl000063)字段[学生平均分(stuScore)]的值:[$(pobjViewpointEN.stuScore)], 非法，应该为数值型(In 观点表(Viewpoint))!(clsViewpointBL:CheckProperty4Update)");
        }
        if (null != pobjViewpointEN.teaScore && undefined !== pobjViewpointEN.teaScore && jsString_js_1.tzDataType.isNumber(pobjViewpointEN.teaScore) === false) {
            throw new Error("(errid:Watl000063)字段[教师评分(teaScore)]的值:[$(pobjViewpointEN.teaScore)], 非法，应该为数值型(In 观点表(Viewpoint))!(clsViewpointBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjViewpointEN.id_CurrEduCls) == false && undefined !== pobjViewpointEN.id_CurrEduCls && jsString_js_1.tzDataType.isString(pobjViewpointEN.id_CurrEduCls) === false) {
            throw new Error("(errid:Watl000063)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjViewpointEN.id_CurrEduCls)], 非法，应该为字符型(In 观点表(Viewpoint))!(clsViewpointBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjViewpointEN.pdfContent) == false && undefined !== pobjViewpointEN.pdfContent && jsString_js_1.tzDataType.isString(pobjViewpointEN.pdfContent) === false) {
            throw new Error("(errid:Watl000063)字段[Pdf内容(pdfContent)]的值:[$(pobjViewpointEN.pdfContent)], 非法，应该为字符型(In 观点表(Viewpoint))!(clsViewpointBL:CheckProperty4Update)");
        }
        if (null != pobjViewpointEN.pdfPageNum && undefined !== pobjViewpointEN.pdfPageNum && jsString_js_1.tzDataType.isNumber(pobjViewpointEN.pdfPageNum) === false) {
            throw new Error("(errid:Watl000063)字段[Pdf页码(pdfPageNum)]的值:[$(pobjViewpointEN.pdfPageNum)], 非法，应该为数值型(In 观点表(Viewpoint))!(clsViewpointBL:CheckProperty4Update)");
        }
        if (null != pobjViewpointEN.citationCount && undefined !== pobjViewpointEN.citationCount && jsString_js_1.tzDataType.isNumber(pobjViewpointEN.citationCount) === false) {
            throw new Error("(errid:Watl000063)字段[引用统计(citationCount)]的值:[$(pobjViewpointEN.citationCount)], 非法，应该为数值型(In 观点表(Viewpoint))!(clsViewpointBL:CheckProperty4Update)");
        }
        if (null != pobjViewpointEN.versionCount && undefined !== pobjViewpointEN.versionCount && jsString_js_1.tzDataType.isNumber(pobjViewpointEN.versionCount) === false) {
            throw new Error("(errid:Watl000063)字段[版本统计(versionCount)]的值:[$(pobjViewpointEN.versionCount)], 非法，应该为数值型(In 观点表(Viewpoint))!(clsViewpointBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjViewpointEN.createDate) == false && undefined !== pobjViewpointEN.createDate && jsString_js_1.tzDataType.isString(pobjViewpointEN.createDate) === false) {
            throw new Error("(errid:Watl000063)字段[建立日期(createDate)]的值:[$(pobjViewpointEN.createDate)], 非法，应该为字符型(In 观点表(Viewpoint))!(clsViewpointBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjViewpointEN.shareId) == false && undefined !== pobjViewpointEN.shareId && jsString_js_1.tzDataType.isString(pobjViewpointEN.shareId) === false) {
            throw new Error("(errid:Watl000063)字段[分享Id(shareId)]的值:[$(pobjViewpointEN.shareId)], 非法，应该为字符型(In 观点表(Viewpoint))!(clsViewpointBL:CheckProperty4Update)");
        }
        if (null != pobjViewpointEN.isRecommend && undefined !== pobjViewpointEN.isRecommend && jsString_js_1.tzDataType.isBoolean(pobjViewpointEN.isRecommend) === false) {
            throw new Error("(errid:Watl000063)字段[是否推荐(isRecommend)]的值:[$(pobjViewpointEN.isRecommend)], 非法，应该为布尔型(In 观点表(Viewpoint))!(clsViewpointBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjViewpointEN.viewpointId) === true) {
            throw new Error("(errid:Watl000064)字段[观点Id]不能为空(In 观点表)!(clsViewpointBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjViewpointEN.SetIsCheckProperty(true);
    }
    exports.Viewpoint_CheckProperty4Update = Viewpoint_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function Viewpoint_GetJSONStrByObj(pobjViewpointEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjViewpointEN.sf_UpdFldSetStr = pobjViewpointEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjViewpointEN);
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
    exports.Viewpoint_GetJSONStrByObj = Viewpoint_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function Viewpoint_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrViewpointObjLst = new Array();
        if (strJSON === "") {
            return arrViewpointObjLst;
        }
        try {
            arrViewpointObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrViewpointObjLst;
        }
        return arrViewpointObjLst;
    }
    exports.Viewpoint_GetObjLstByJSONStr = Viewpoint_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrViewpointObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function Viewpoint_GetObjLstByJSONObjLst(arrViewpointObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrViewpointObjLst = new Array();
        for (const objInFor of arrViewpointObjLstS) {
            const obj1 = Viewpoint_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrViewpointObjLst.push(obj1);
        }
        return arrViewpointObjLst;
    }
    exports.Viewpoint_GetObjLstByJSONObjLst = Viewpoint_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function Viewpoint_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjViewpointEN = new clsViewpointEN_js_1.clsViewpointEN();
        if (strJSON === "") {
            return pobjViewpointEN;
        }
        try {
            pobjViewpointEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjViewpointEN;
        }
        return pobjViewpointEN;
    }
    exports.Viewpoint_GetObjByJSONStr = Viewpoint_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function Viewpoint_GetCombineCondition(objViewpoint_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objViewpoint_Cond.dicFldComparisonOp, clsViewpointEN_js_1.clsViewpointEN.con_ViewpointId) == true) {
            const strComparisonOp_ViewpointId = objViewpoint_Cond.dicFldComparisonOp[clsViewpointEN_js_1.clsViewpointEN.con_ViewpointId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsViewpointEN_js_1.clsViewpointEN.con_ViewpointId, objViewpoint_Cond.viewpointId, strComparisonOp_ViewpointId);
        }
        if (Object.prototype.hasOwnProperty.call(objViewpoint_Cond.dicFldComparisonOp, clsViewpointEN_js_1.clsViewpointEN.con_ViewpointName) == true) {
            const strComparisonOp_ViewpointName = objViewpoint_Cond.dicFldComparisonOp[clsViewpointEN_js_1.clsViewpointEN.con_ViewpointName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsViewpointEN_js_1.clsViewpointEN.con_ViewpointName, objViewpoint_Cond.viewpointName, strComparisonOp_ViewpointName);
        }
        //数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
        if (Object.prototype.hasOwnProperty.call(objViewpoint_Cond.dicFldComparisonOp, clsViewpointEN_js_1.clsViewpointEN.con_ViewpointTypeId) == true) {
            const strComparisonOp_ViewpointTypeId = objViewpoint_Cond.dicFldComparisonOp[clsViewpointEN_js_1.clsViewpointEN.con_ViewpointTypeId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsViewpointEN_js_1.clsViewpointEN.con_ViewpointTypeId, objViewpoint_Cond.viewpointTypeId, strComparisonOp_ViewpointTypeId);
        }
        //数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
        if (Object.prototype.hasOwnProperty.call(objViewpoint_Cond.dicFldComparisonOp, clsViewpointEN_js_1.clsViewpointEN.con_Source) == true) {
            const strComparisonOp_Source = objViewpoint_Cond.dicFldComparisonOp[clsViewpointEN_js_1.clsViewpointEN.con_Source];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsViewpointEN_js_1.clsViewpointEN.con_Source, objViewpoint_Cond.source, strComparisonOp_Source);
        }
        if (Object.prototype.hasOwnProperty.call(objViewpoint_Cond.dicFldComparisonOp, clsViewpointEN_js_1.clsViewpointEN.con_VPProposePeople) == true) {
            const strComparisonOp_VPProposePeople = objViewpoint_Cond.dicFldComparisonOp[clsViewpointEN_js_1.clsViewpointEN.con_VPProposePeople];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsViewpointEN_js_1.clsViewpointEN.con_VPProposePeople, objViewpoint_Cond.vpProposePeople, strComparisonOp_VPProposePeople);
        }
        if (Object.prototype.hasOwnProperty.call(objViewpoint_Cond.dicFldComparisonOp, clsViewpointEN_js_1.clsViewpointEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objViewpoint_Cond.dicFldComparisonOp[clsViewpointEN_js_1.clsViewpointEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsViewpointEN_js_1.clsViewpointEN.con_UpdDate, objViewpoint_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objViewpoint_Cond.dicFldComparisonOp, clsViewpointEN_js_1.clsViewpointEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objViewpoint_Cond.dicFldComparisonOp[clsViewpointEN_js_1.clsViewpointEN.con_UpdUser];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsViewpointEN_js_1.clsViewpointEN.con_UpdUser, objViewpoint_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objViewpoint_Cond.dicFldComparisonOp, clsViewpointEN_js_1.clsViewpointEN.con_Memo) == true) {
            const strComparisonOp_Memo = objViewpoint_Cond.dicFldComparisonOp[clsViewpointEN_js_1.clsViewpointEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsViewpointEN_js_1.clsViewpointEN.con_Memo, objViewpoint_Cond.memo, strComparisonOp_Memo);
        }
        if (Object.prototype.hasOwnProperty.call(objViewpoint_Cond.dicFldComparisonOp, clsViewpointEN_js_1.clsViewpointEN.con_IsSubmit) == true) {
            if (objViewpoint_Cond.isSubmit == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsViewpointEN_js_1.clsViewpointEN.con_IsSubmit);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsViewpointEN_js_1.clsViewpointEN.con_IsSubmit);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objViewpoint_Cond.dicFldComparisonOp, clsViewpointEN_js_1.clsViewpointEN.con_UserTypeId) == true) {
            const strComparisonOp_UserTypeId = objViewpoint_Cond.dicFldComparisonOp[clsViewpointEN_js_1.clsViewpointEN.con_UserTypeId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsViewpointEN_js_1.clsViewpointEN.con_UserTypeId, objViewpoint_Cond.userTypeId, strComparisonOp_UserTypeId);
        }
        if (Object.prototype.hasOwnProperty.call(objViewpoint_Cond.dicFldComparisonOp, clsViewpointEN_js_1.clsViewpointEN.con_CitationId) == true) {
            const strComparisonOp_CitationId = objViewpoint_Cond.dicFldComparisonOp[clsViewpointEN_js_1.clsViewpointEN.con_CitationId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsViewpointEN_js_1.clsViewpointEN.con_CitationId, objViewpoint_Cond.citationId, strComparisonOp_CitationId);
        }
        if (Object.prototype.hasOwnProperty.call(objViewpoint_Cond.dicFldComparisonOp, clsViewpointEN_js_1.clsViewpointEN.con_AppraiseCount) == true) {
            const strComparisonOp_AppraiseCount = objViewpoint_Cond.dicFldComparisonOp[clsViewpointEN_js_1.clsViewpointEN.con_AppraiseCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsViewpointEN_js_1.clsViewpointEN.con_AppraiseCount, objViewpoint_Cond.appraiseCount, strComparisonOp_AppraiseCount);
        }
        if (Object.prototype.hasOwnProperty.call(objViewpoint_Cond.dicFldComparisonOp, clsViewpointEN_js_1.clsViewpointEN.con_OkCount) == true) {
            const strComparisonOp_OkCount = objViewpoint_Cond.dicFldComparisonOp[clsViewpointEN_js_1.clsViewpointEN.con_OkCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsViewpointEN_js_1.clsViewpointEN.con_OkCount, objViewpoint_Cond.okCount, strComparisonOp_OkCount);
        }
        if (Object.prototype.hasOwnProperty.call(objViewpoint_Cond.dicFldComparisonOp, clsViewpointEN_js_1.clsViewpointEN.con_score) == true) {
            const strComparisonOp_score = objViewpoint_Cond.dicFldComparisonOp[clsViewpointEN_js_1.clsViewpointEN.con_score];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsViewpointEN_js_1.clsViewpointEN.con_score, objViewpoint_Cond.score, strComparisonOp_score);
        }
        if (Object.prototype.hasOwnProperty.call(objViewpoint_Cond.dicFldComparisonOp, clsViewpointEN_js_1.clsViewpointEN.con_StuScore) == true) {
            const strComparisonOp_StuScore = objViewpoint_Cond.dicFldComparisonOp[clsViewpointEN_js_1.clsViewpointEN.con_StuScore];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsViewpointEN_js_1.clsViewpointEN.con_StuScore, objViewpoint_Cond.stuScore, strComparisonOp_StuScore);
        }
        if (Object.prototype.hasOwnProperty.call(objViewpoint_Cond.dicFldComparisonOp, clsViewpointEN_js_1.clsViewpointEN.con_TeaScore) == true) {
            const strComparisonOp_TeaScore = objViewpoint_Cond.dicFldComparisonOp[clsViewpointEN_js_1.clsViewpointEN.con_TeaScore];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsViewpointEN_js_1.clsViewpointEN.con_TeaScore, objViewpoint_Cond.teaScore, strComparisonOp_TeaScore);
        }
        if (Object.prototype.hasOwnProperty.call(objViewpoint_Cond.dicFldComparisonOp, clsViewpointEN_js_1.clsViewpointEN.con_id_CurrEduCls) == true) {
            const strComparisonOp_id_CurrEduCls = objViewpoint_Cond.dicFldComparisonOp[clsViewpointEN_js_1.clsViewpointEN.con_id_CurrEduCls];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsViewpointEN_js_1.clsViewpointEN.con_id_CurrEduCls, objViewpoint_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
        }
        if (Object.prototype.hasOwnProperty.call(objViewpoint_Cond.dicFldComparisonOp, clsViewpointEN_js_1.clsViewpointEN.con_PdfContent) == true) {
            const strComparisonOp_PdfContent = objViewpoint_Cond.dicFldComparisonOp[clsViewpointEN_js_1.clsViewpointEN.con_PdfContent];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsViewpointEN_js_1.clsViewpointEN.con_PdfContent, objViewpoint_Cond.pdfContent, strComparisonOp_PdfContent);
        }
        if (Object.prototype.hasOwnProperty.call(objViewpoint_Cond.dicFldComparisonOp, clsViewpointEN_js_1.clsViewpointEN.con_PdfPageNum) == true) {
            const strComparisonOp_PdfPageNum = objViewpoint_Cond.dicFldComparisonOp[clsViewpointEN_js_1.clsViewpointEN.con_PdfPageNum];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsViewpointEN_js_1.clsViewpointEN.con_PdfPageNum, objViewpoint_Cond.pdfPageNum, strComparisonOp_PdfPageNum);
        }
        if (Object.prototype.hasOwnProperty.call(objViewpoint_Cond.dicFldComparisonOp, clsViewpointEN_js_1.clsViewpointEN.con_CitationCount) == true) {
            const strComparisonOp_CitationCount = objViewpoint_Cond.dicFldComparisonOp[clsViewpointEN_js_1.clsViewpointEN.con_CitationCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsViewpointEN_js_1.clsViewpointEN.con_CitationCount, objViewpoint_Cond.citationCount, strComparisonOp_CitationCount);
        }
        if (Object.prototype.hasOwnProperty.call(objViewpoint_Cond.dicFldComparisonOp, clsViewpointEN_js_1.clsViewpointEN.con_VersionCount) == true) {
            const strComparisonOp_VersionCount = objViewpoint_Cond.dicFldComparisonOp[clsViewpointEN_js_1.clsViewpointEN.con_VersionCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsViewpointEN_js_1.clsViewpointEN.con_VersionCount, objViewpoint_Cond.versionCount, strComparisonOp_VersionCount);
        }
        if (Object.prototype.hasOwnProperty.call(objViewpoint_Cond.dicFldComparisonOp, clsViewpointEN_js_1.clsViewpointEN.con_CreateDate) == true) {
            const strComparisonOp_CreateDate = objViewpoint_Cond.dicFldComparisonOp[clsViewpointEN_js_1.clsViewpointEN.con_CreateDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsViewpointEN_js_1.clsViewpointEN.con_CreateDate, objViewpoint_Cond.createDate, strComparisonOp_CreateDate);
        }
        if (Object.prototype.hasOwnProperty.call(objViewpoint_Cond.dicFldComparisonOp, clsViewpointEN_js_1.clsViewpointEN.con_ShareId) == true) {
            const strComparisonOp_ShareId = objViewpoint_Cond.dicFldComparisonOp[clsViewpointEN_js_1.clsViewpointEN.con_ShareId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsViewpointEN_js_1.clsViewpointEN.con_ShareId, objViewpoint_Cond.shareId, strComparisonOp_ShareId);
        }
        if (Object.prototype.hasOwnProperty.call(objViewpoint_Cond.dicFldComparisonOp, clsViewpointEN_js_1.clsViewpointEN.con_IsRecommend) == true) {
            if (objViewpoint_Cond.isRecommend == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsViewpointEN_js_1.clsViewpointEN.con_IsRecommend);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsViewpointEN_js_1.clsViewpointEN.con_IsRecommend);
            }
        }
        return strWhereCond;
    }
    exports.Viewpoint_GetCombineCondition = Viewpoint_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--Viewpoint(观点表),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param strViewpointId: 观点Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function Viewpoint_GetUniCondStr_ViewpointId(objViewpointEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and ViewpointId = '{0}'", objViewpointEN.viewpointId);
        return strWhereCond;
    }
    exports.Viewpoint_GetUniCondStr_ViewpointId = Viewpoint_GetUniCondStr_ViewpointId;
    /**
    *获取唯一性条件串(Uniqueness)--Viewpoint(观点表),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param strViewpointId: 观点Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function Viewpoint_GetUniCondStr4Update_ViewpointId(objViewpointEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and ViewpointId <> '{0}'", objViewpointEN.viewpointId);
        strWhereCond += (0, clsString_js_1.Format)(" and ViewpointId = '{0}'", objViewpointEN.viewpointId);
        return strWhereCond;
    }
    exports.Viewpoint_GetUniCondStr4Update_ViewpointId = Viewpoint_GetUniCondStr4Update_ViewpointId;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objViewpointENS:源对象
     * @param objViewpointENT:目标对象
    */
    function Viewpoint_CopyObjTo(objViewpointENS, objViewpointENT) {
        objViewpointENT.viewpointId = objViewpointENS.viewpointId; //观点Id
        objViewpointENT.viewpointName = objViewpointENS.viewpointName; //观点名称
        objViewpointENT.viewpointContent = objViewpointENS.viewpointContent; //观点内容
        objViewpointENT.viewpointTypeId = objViewpointENS.viewpointTypeId; //观点类型Id
        objViewpointENT.reason = objViewpointENS.reason; //理由
        objViewpointENT.source = objViewpointENS.source; //来源
        objViewpointENT.vpProposePeople = objViewpointENS.vpProposePeople; //观点提出人
        objViewpointENT.updDate = objViewpointENS.updDate; //修改日期
        objViewpointENT.updUser = objViewpointENS.updUser; //修改人
        objViewpointENT.memo = objViewpointENS.memo; //备注
        objViewpointENT.isSubmit = objViewpointENS.isSubmit; //是否提交
        objViewpointENT.userTypeId = objViewpointENS.userTypeId; //用户类型Id
        objViewpointENT.citationId = objViewpointENS.citationId; //引用Id
        objViewpointENT.appraiseCount = objViewpointENS.appraiseCount; //评论数
        objViewpointENT.okCount = objViewpointENS.okCount; //点赞统计
        objViewpointENT.score = objViewpointENS.score; //评分
        objViewpointENT.stuScore = objViewpointENS.stuScore; //学生平均分
        objViewpointENT.teaScore = objViewpointENS.teaScore; //教师评分
        objViewpointENT.id_CurrEduCls = objViewpointENS.id_CurrEduCls; //教学班流水号
        objViewpointENT.pdfContent = objViewpointENS.pdfContent; //Pdf内容
        objViewpointENT.pdfPageNum = objViewpointENS.pdfPageNum; //Pdf页码
        objViewpointENT.citationCount = objViewpointENS.citationCount; //引用统计
        objViewpointENT.versionCount = objViewpointENS.versionCount; //版本统计
        objViewpointENT.createDate = objViewpointENS.createDate; //建立日期
        objViewpointENT.shareId = objViewpointENS.shareId; //分享Id
        objViewpointENT.isRecommend = objViewpointENS.isRecommend; //是否推荐
        objViewpointENT.sf_UpdFldSetStr = objViewpointENS.updFldString; //sf_UpdFldSetStr
    }
    exports.Viewpoint_CopyObjTo = Viewpoint_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objViewpointENS:源对象
     * @param objViewpointENT:目标对象
    */
    function Viewpoint_GetObjFromJsonObj(objViewpointENS) {
        const objViewpointENT = new clsViewpointEN_js_1.clsViewpointEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objViewpointENT, objViewpointENS);
        return objViewpointENT;
    }
    exports.Viewpoint_GetObjFromJsonObj = Viewpoint_GetObjFromJsonObj;
});
