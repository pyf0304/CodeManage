/**
* 类名:clsvgs_PaperReportWApi
* 表名:vgs_PaperReport(01120771)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/13 00:53:20
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
        define(["require", "exports", "axios", "../../PubFun/enumComparisonOp.js", "../../PubFun/CacheHelper.js", "../../L0_Entity/GraduateEduTopic/clsvgs_PaperReportEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.vgs_PaperReport_GetObjFromJsonObj = exports.vgs_PaperReport_CopyObjTo = exports.vgs_PaperReport_GetCombineCondition = exports.vgs_PaperReport_GetObjByJSONStr = exports.vgs_PaperReport_GetObjLstByJSONObjLst = exports.vgs_PaperReport_GetObjLstByJSONStr = exports.vgs_PaperReport_GetJSONStrByObj = exports.vgs_PaperReport_ReFreshThisCache = exports.vgs_PaperReport_GetWebApiUrl = exports.vgs_PaperReport_GetRecCountByCond_Cache = exports.vgs_PaperReport_GetRecCountByCondAsync = exports.vgs_PaperReport_IsExistAsync = exports.vgs_PaperReport_IsExist_Cache = exports.vgs_PaperReport_IsExist = exports.vgs_PaperReport_IsExistRecordAsync = exports.vgs_PaperReport_IsExistRecord_Cache = exports.vgs_PaperReport_GetObjLstByPagerAsync = exports.vgs_PaperReport_GetObjLstByPager_Cache = exports.vgs_PaperReport_GetObjLstByRange = exports.vgs_PaperReport_GetObjLstByRangeAsync = exports.vgs_PaperReport_GetTopObjLstAsync = exports.vgs_PaperReport_GetObjLstByReportIdLst_Cache = exports.vgs_PaperReport_GetObjLstByReportIdLstAsync = exports.vgs_PaperReport_GetSubObjLst_Cache = exports.vgs_PaperReport_GetObjLst_PureCache = exports.vgs_PaperReport_GetObjLst_Cache = exports.vgs_PaperReport_GetObjLst_sessionStorage_PureCache = exports.vgs_PaperReport_GetObjLst_sessionStorage = exports.vgs_PaperReport_GetObjLstAsync = exports.vgs_PaperReport_GetObjLst_localStorage_PureCache = exports.vgs_PaperReport_GetObjLst_localStorage = exports.vgs_PaperReport_GetObjLst_ClientCache = exports.vgs_PaperReport_GetFirstObjAsync = exports.vgs_PaperReport_GetFirstID = exports.vgs_PaperReport_GetFirstIDAsync = exports.vgs_PaperReport_funcKey = exports.vgs_PaperReport_FilterFunByKey = exports.vgs_PaperReport_SortFunByKey = exports.vgs_PaperReport_SortFun_Defa_2Fld = exports.vgs_PaperReport_SortFun_Defa = exports.vgs_PaperReport_func = exports.vgs_PaperReport_GetObjByReportId_localStorage = exports.vgs_PaperReport_GetObjByReportId_Cache = exports.vgs_PaperReport_GetObjByReportIdAsync = exports.vgs_PaperReport_ConstructorName = exports.vgs_PaperReport_Controller = void 0;
    /**
     * 论文汇报视图(vgs_PaperReport)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月13日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const enumComparisonOp_js_1 = require("../../PubFun/enumComparisonOp.js");
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsvgs_PaperReportEN_js_1 = require("../../L0_Entity/GraduateEduTopic/clsvgs_PaperReportEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.vgs_PaperReport_Controller = "vgs_PaperReportApi";
    exports.vgs_PaperReport_ConstructorName = "vgs_PaperReport";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strReportId:关键字
    * @returns 对象
    **/
    async function vgs_PaperReport_GetObjByReportIdAsync(strReportId) {
        const strThisFuncName = "GetObjByReportIdAsync";
        if ((0, clsString_js_1.IsNullOrEmpty)(strReportId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strReportId]不能为空！(In clsvgs_PaperReportWApi.GetObjByReportIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strReportId.length != 10) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strReportId]的长度:[{0}]不正确！(clsvgs_PaperReportWApi.GetObjByReportIdAsync)", strReportId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByReportId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PaperReport_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "strReportId": strReportId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    return null;
                }
                //console.log(returnObj);
                const objvgs_PaperReport = vgs_PaperReport_GetObjFromJsonObj(returnObj);
                return objvgs_PaperReport;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PaperReport_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PaperReport_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PaperReport_GetObjByReportIdAsync = vgs_PaperReport_GetObjByReportIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param strReportId:所给的关键字
     * @returns 对象
    */
    async function vgs_PaperReport_GetObjByReportId_Cache(strReportId, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByReportId_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strReportId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strReportId]不能为空！(In clsvgs_PaperReportWApi.GetObjByReportId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strReportId.length != 10) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strReportId]的长度:[{0}]不正确！(clsvgs_PaperReportWApi.GetObjByReportId_Cache)", strReportId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrvgs_PaperReportObjLst_Cache = await vgs_PaperReport_GetObjLst_Cache();
        try {
            const arrvgs_PaperReport_Sel = arrvgs_PaperReportObjLst_Cache.filter(x => x.reportId == strReportId);
            let objvgs_PaperReport;
            if (arrvgs_PaperReport_Sel.length > 0) {
                objvgs_PaperReport = arrvgs_PaperReport_Sel[0];
                return objvgs_PaperReport;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    const objvgs_PaperReport_Const = await vgs_PaperReport_GetObjByReportIdAsync(strReportId);
                    if (objvgs_PaperReport_Const != null) {
                        vgs_PaperReport_ReFreshThisCache();
                        return objvgs_PaperReport_Const;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strReportId, exports.vgs_PaperReport_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.vgs_PaperReport_GetObjByReportId_Cache = vgs_PaperReport_GetObjByReportId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param strReportId:所给的关键字
     * @returns 对象
    */
    async function vgs_PaperReport_GetObjByReportId_localStorage(strReportId) {
        const strThisFuncName = "GetObjByReportId_localStorage";
        if ((0, clsString_js_1.IsNullOrEmpty)(strReportId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strReportId]不能为空！(In clsvgs_PaperReportWApi.GetObjByReportId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strReportId.length != 10) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strReportId]的长度:[{0}]不正确！(clsvgs_PaperReportWApi.GetObjByReportId_localStorage)", strReportId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN._CurrTabName, strReportId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objvgs_PaperReport_Cache = JSON.parse(strTempObj);
            return objvgs_PaperReport_Cache;
        }
        try {
            const objvgs_PaperReport = await vgs_PaperReport_GetObjByReportIdAsync(strReportId);
            if (objvgs_PaperReport != null) {
                localStorage.setItem(strKey, JSON.stringify(objvgs_PaperReport));
                const strInfo = (0, clsString_js_1.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objvgs_PaperReport;
            }
            return objvgs_PaperReport;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strReportId, exports.vgs_PaperReport_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.vgs_PaperReport_GetObjByReportId_localStorage = vgs_PaperReport_GetObjByReportId_localStorage;
    /*该表没有名称字段，不能生成此函数！*/
    /**
     * 映射函数。根据表映射把输入字段值，映射成输出字段值
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_func)
     * @param strInFldName:输入字段名
     * @param strOutFldName:输出字段名
     * @param strInValue:输入字段值
     * @returns 返回一个输出字段值
    */
    async function vgs_PaperReport_func(strInFldName, strOutFldName, strInValue) {
        //const strThisFuncName = "func";
        if (strInFldName != clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_ReportId) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_1.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strOutFldName, clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strReportId = strInValue;
        if ((0, clsString_js_1.IsNullOrEmpty)(strInValue) == true) {
            return "";
        }
        const objvgs_PaperReport = await vgs_PaperReport_GetObjByReportId_Cache(strReportId);
        if (objvgs_PaperReport == null)
            return "";
        if (objvgs_PaperReport.GetFldValue(strOutFldName) == null)
            return "";
        return objvgs_PaperReport.GetFldValue(strOutFldName).toString();
    }
    exports.vgs_PaperReport_func = vgs_PaperReport_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vgs_PaperReport_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.reportId.localeCompare(b.reportId);
    }
    exports.vgs_PaperReport_SortFun_Defa = vgs_PaperReport_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vgs_PaperReport_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.memo == b.memo)
            return a.updDate.localeCompare(b.updDate);
        else
            return a.memo.localeCompare(b.memo);
    }
    exports.vgs_PaperReport_SortFun_Defa_2Fld = vgs_PaperReport_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vgs_PaperReport_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                case clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_ReportId:
                    return (a, b) => {
                        return a.reportId.localeCompare(b.reportId);
                    };
                case clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_UpdDate:
                    return (a, b) => {
                        if (a.updDate == null)
                            return -1;
                        if (b.updDate == null)
                            return 1;
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_TopicName:
                    return (a, b) => {
                        if (a.topicName == null)
                            return -1;
                        if (b.topicName == null)
                            return 1;
                        return a.topicName.localeCompare(b.topicName);
                    };
                case clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_TopicId:
                    return (a, b) => {
                        if (a.topicId == null)
                            return -1;
                        if (b.topicId == null)
                            return 1;
                        return a.topicId.localeCompare(b.topicId);
                    };
                case clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_PaperId:
                    return (a, b) => {
                        if (a.paperId == null)
                            return -1;
                        if (b.paperId == null)
                            return 1;
                        return a.paperId.localeCompare(b.paperId);
                    };
                case clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_PaperTitle:
                    return (a, b) => {
                        if (a.paperTitle == null)
                            return -1;
                        if (b.paperTitle == null)
                            return 1;
                        return a.paperTitle.localeCompare(b.paperTitle);
                    };
                case clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_ReportContent:
                    return (a, b) => {
                        if (a.reportContent == null)
                            return -1;
                        if (b.reportContent == null)
                            return 1;
                        return a.reportContent.localeCompare(b.reportContent);
                    };
                case clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_id_CurrEduCls:
                    return (a, b) => {
                        if (a.id_CurrEduCls == null)
                            return -1;
                        if (b.id_CurrEduCls == null)
                            return 1;
                        return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
                    };
                case clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_IsSubmit:
                    return (a, b) => {
                        if (a.isSubmit == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_ReportUser:
                    return (a, b) => {
                        if (a.reportUser == null)
                            return -1;
                        if (b.reportUser == null)
                            return 1;
                        return a.reportUser.localeCompare(b.reportUser);
                    };
                case clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_ReportDate:
                    return (a, b) => {
                        if (a.reportDate == null)
                            return -1;
                        if (b.reportDate == null)
                            return 1;
                        return a.reportDate.localeCompare(b.reportDate);
                    };
                case clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_UpdUser:
                    return (a, b) => {
                        if (a.updUser == null)
                            return -1;
                        if (b.updUser == null)
                            return 1;
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_VersionCount:
                    return (a, b) => {
                        return a.versionCount - b.versionCount;
                    };
                case clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_OkCount:
                    return (a, b) => {
                        return a.okCount - b.okCount;
                    };
                case clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_AppraiseCount:
                    return (a, b) => {
                        return a.appraiseCount - b.appraiseCount;
                    };
                case clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_Score:
                    return (a, b) => {
                        return a.score - b.score;
                    };
                case clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_StuScore:
                    return (a, b) => {
                        return a.stuScore - b.stuScore;
                    };
                case clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_TeaScore:
                    return (a, b) => {
                        return a.teaScore - b.teaScore;
                    };
                case clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_PDFUrl:
                    return (a, b) => {
                        if (a.pdFUrl == null)
                            return -1;
                        if (b.pdFUrl == null)
                            return 1;
                        return a.pdFUrl.localeCompare(b.pdFUrl);
                    };
                case clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_PPTUrl:
                    return (a, b) => {
                        if (a.ppTUrl == null)
                            return -1;
                        if (b.ppTUrl == null)
                            return 1;
                        return a.ppTUrl.localeCompare(b.ppTUrl);
                    };
                case clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_Month:
                    return (a, b) => {
                        if (a.month == null)
                            return -1;
                        if (b.month == null)
                            return 1;
                        return a.month.localeCompare(b.month);
                    };
                case clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_Week:
                    return (a, b) => {
                        return a.week - b.week;
                    };
                case clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_Year:
                    return (a, b) => {
                        if (a.year == null)
                            return -1;
                        if (b.year == null)
                            return 1;
                        return a.year.localeCompare(b.year);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vgs_PaperReport]中不存在！(in ${exports.vgs_PaperReport_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                case clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_ReportId:
                    return (a, b) => {
                        return b.reportId.localeCompare(a.reportId);
                    };
                case clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_UpdDate:
                    return (a, b) => {
                        if (b.updDate == null)
                            return -1;
                        if (a.updDate == null)
                            return 1;
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_TopicName:
                    return (a, b) => {
                        if (b.topicName == null)
                            return -1;
                        if (a.topicName == null)
                            return 1;
                        return b.topicName.localeCompare(a.topicName);
                    };
                case clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_TopicId:
                    return (a, b) => {
                        if (b.topicId == null)
                            return -1;
                        if (a.topicId == null)
                            return 1;
                        return b.topicId.localeCompare(a.topicId);
                    };
                case clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_PaperId:
                    return (a, b) => {
                        if (b.paperId == null)
                            return -1;
                        if (a.paperId == null)
                            return 1;
                        return b.paperId.localeCompare(a.paperId);
                    };
                case clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_PaperTitle:
                    return (a, b) => {
                        if (b.paperTitle == null)
                            return -1;
                        if (a.paperTitle == null)
                            return 1;
                        return b.paperTitle.localeCompare(a.paperTitle);
                    };
                case clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_ReportContent:
                    return (a, b) => {
                        if (b.reportContent == null)
                            return -1;
                        if (a.reportContent == null)
                            return 1;
                        return b.reportContent.localeCompare(a.reportContent);
                    };
                case clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_id_CurrEduCls:
                    return (a, b) => {
                        if (b.id_CurrEduCls == null)
                            return -1;
                        if (a.id_CurrEduCls == null)
                            return 1;
                        return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
                    };
                case clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_IsSubmit:
                    return (a, b) => {
                        if (b.isSubmit == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_ReportUser:
                    return (a, b) => {
                        if (b.reportUser == null)
                            return -1;
                        if (a.reportUser == null)
                            return 1;
                        return b.reportUser.localeCompare(a.reportUser);
                    };
                case clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_ReportDate:
                    return (a, b) => {
                        if (b.reportDate == null)
                            return -1;
                        if (a.reportDate == null)
                            return 1;
                        return b.reportDate.localeCompare(a.reportDate);
                    };
                case clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_UpdUser:
                    return (a, b) => {
                        if (b.updUser == null)
                            return -1;
                        if (a.updUser == null)
                            return 1;
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_VersionCount:
                    return (a, b) => {
                        return b.versionCount - a.versionCount;
                    };
                case clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_OkCount:
                    return (a, b) => {
                        return b.okCount - a.okCount;
                    };
                case clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_AppraiseCount:
                    return (a, b) => {
                        return b.appraiseCount - a.appraiseCount;
                    };
                case clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_Score:
                    return (a, b) => {
                        return b.score - a.score;
                    };
                case clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_StuScore:
                    return (a, b) => {
                        return b.stuScore - a.stuScore;
                    };
                case clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_TeaScore:
                    return (a, b) => {
                        return b.teaScore - a.teaScore;
                    };
                case clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_PDFUrl:
                    return (a, b) => {
                        if (b.pdFUrl == null)
                            return -1;
                        if (a.pdFUrl == null)
                            return 1;
                        return b.pdFUrl.localeCompare(a.pdFUrl);
                    };
                case clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_PPTUrl:
                    return (a, b) => {
                        if (b.ppTUrl == null)
                            return -1;
                        if (a.ppTUrl == null)
                            return 1;
                        return b.ppTUrl.localeCompare(a.ppTUrl);
                    };
                case clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_Month:
                    return (a, b) => {
                        if (b.month == null)
                            return -1;
                        if (a.month == null)
                            return 1;
                        return b.month.localeCompare(a.month);
                    };
                case clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_Week:
                    return (a, b) => {
                        return b.week - a.week;
                    };
                case clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_Year:
                    return (a, b) => {
                        if (b.year == null)
                            return -1;
                        if (a.year == null)
                            return 1;
                        return b.year.localeCompare(a.year);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vgs_PaperReport]中不存在！(in ${exports.vgs_PaperReport_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.vgs_PaperReport_SortFunByKey = vgs_PaperReport_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function vgs_PaperReport_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            case clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_ReportId:
                return (obj) => {
                    return obj.reportId === value;
                };
            case clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_TopicName:
                return (obj) => {
                    return obj.topicName === value;
                };
            case clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_TopicId:
                return (obj) => {
                    return obj.topicId === value;
                };
            case clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_PaperId:
                return (obj) => {
                    return obj.paperId === value;
                };
            case clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_PaperTitle:
                return (obj) => {
                    return obj.paperTitle === value;
                };
            case clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_ReportContent:
                return (obj) => {
                    return obj.reportContent === value;
                };
            case clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_id_CurrEduCls:
                return (obj) => {
                    return obj.id_CurrEduCls === value;
                };
            case clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_IsSubmit:
                return (obj) => {
                    return obj.isSubmit === value;
                };
            case clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_ReportUser:
                return (obj) => {
                    return obj.reportUser === value;
                };
            case clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_ReportDate:
                return (obj) => {
                    return obj.reportDate === value;
                };
            case clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_VersionCount:
                return (obj) => {
                    return obj.versionCount === value;
                };
            case clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_OkCount:
                return (obj) => {
                    return obj.okCount === value;
                };
            case clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_AppraiseCount:
                return (obj) => {
                    return obj.appraiseCount === value;
                };
            case clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_Score:
                return (obj) => {
                    return obj.score === value;
                };
            case clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_StuScore:
                return (obj) => {
                    return obj.stuScore === value;
                };
            case clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_TeaScore:
                return (obj) => {
                    return obj.teaScore === value;
                };
            case clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_PDFUrl:
                return (obj) => {
                    return obj.pdFUrl === value;
                };
            case clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_PPTUrl:
                return (obj) => {
                    return obj.ppTUrl === value;
                };
            case clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_Month:
                return (obj) => {
                    return obj.month === value;
                };
            case clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_Week:
                return (obj) => {
                    return obj.week === value;
                };
            case clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_Year:
                return (obj) => {
                    return obj.year === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[vgs_PaperReport]中不存在！(in ${exports.vgs_PaperReport_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.vgs_PaperReport_FilterFunByKey = vgs_PaperReport_FilterFunByKey;
    /**
     * 映射函数。根据表映射把输入字段值，映射成输出字段值
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_funcKey)
     * @param strInFldName:输入字段名
     * @param strInValue:输入字段值
     * @param strComparisonOp:比较操作符
     * @returns 返回一个关键字值列表
    */
    async function vgs_PaperReport_funcKey(strInFldName, strInValue, strComparisonOp) {
        //const strThisFuncName = "funcKey";
        if (strInFldName == clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_ReportId) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(strInValue) == true) {
            return [];
        }
        const arrvgs_PaperReport = await vgs_PaperReport_GetObjLst_Cache();
        if (arrvgs_PaperReport == null)
            return [];
        let arrvgs_PaperReport_Sel = arrvgs_PaperReport;
        const strType = typeof (strInValue);
        switch (strType) {
            case "string":
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01: // " = "
                        arrvgs_PaperReport_Sel = arrvgs_PaperReport_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.Like_03:
                        arrvgs_PaperReport_Sel = arrvgs_PaperReport_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.In_04:
                        const arrValues = strInValue.split(',');
                        arrvgs_PaperReport_Sel = arrvgs_PaperReport_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
                        break;
                }
                break;
            case "boolean":
                if (strInValue == null)
                    return [];
                if (strComparisonOp == enumComparisonOp_js_1.enumComparisonOp.Equal_01) {
                    arrvgs_PaperReport_Sel = arrvgs_PaperReport_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                }
                break;
            case "number":
                if (Number(strInValue) == 0)
                    return [];
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01:
                        arrvgs_PaperReport_Sel = arrvgs_PaperReport_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotEqual_02:
                        arrvgs_PaperReport_Sel = arrvgs_PaperReport_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotLessThan_05: //" >= ":
                        arrvgs_PaperReport_Sel = arrvgs_PaperReport_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotGreaterThan_06: //" <= ":
                        arrvgs_PaperReport_Sel = arrvgs_PaperReport_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.GreaterThan_07: //" > ":
                        arrvgs_PaperReport_Sel = arrvgs_PaperReport_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.LessThan_08: //" < ":
                        arrvgs_PaperReport_Sel = arrvgs_PaperReport_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                }
                break;
        }
        if (arrvgs_PaperReport_Sel.length == 0)
            return [];
        return arrvgs_PaperReport_Sel.map(x => x.reportId);
    }
    exports.vgs_PaperReport_funcKey = vgs_PaperReport_funcKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function vgs_PaperReport_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PaperReport_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PaperReport_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PaperReport_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PaperReport_GetFirstIDAsync = vgs_PaperReport_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function vgs_PaperReport_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PaperReport_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PaperReport_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PaperReport_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PaperReport_GetFirstID = vgs_PaperReport_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function vgs_PaperReport_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PaperReport_Controller, strAction);
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
                const objvgs_PaperReport = vgs_PaperReport_GetObjFromJsonObj(returnObj);
                return objvgs_PaperReport;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PaperReport_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PaperReport_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PaperReport_GetFirstObjAsync = vgs_PaperReport_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vgs_PaperReport_GetObjLst_ClientCache() {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN._CurrTabName;
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_1.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrvgs_PaperReportExObjLst_Cache = CacheHelper_js_1.CacheHelper.Get(strKey);
            const arrvgs_PaperReportObjLst_T = vgs_PaperReport_GetObjLstByJSONObjLst(arrvgs_PaperReportExObjLst_Cache);
            return arrvgs_PaperReportObjLst_T;
        }
        try {
            const arrvgs_PaperReportExObjLst = await vgs_PaperReport_GetObjLstAsync(strWhereCond);
            CacheHelper_js_1.CacheHelper.Add(strKey, arrvgs_PaperReportExObjLst);
            const strInfo = (0, clsString_js_1.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvgs_PaperReportExObjLst.length);
            console.log(strInfo);
            return arrvgs_PaperReportExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vgs_PaperReport_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vgs_PaperReport_GetObjLst_ClientCache = vgs_PaperReport_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vgs_PaperReport_GetObjLst_localStorage() {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN._CurrTabName;
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrvgs_PaperReportExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrvgs_PaperReportObjLst_T = vgs_PaperReport_GetObjLstByJSONObjLst(arrvgs_PaperReportExObjLst_Cache);
            return arrvgs_PaperReportObjLst_T;
        }
        try {
            const arrvgs_PaperReportExObjLst = await vgs_PaperReport_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrvgs_PaperReportExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvgs_PaperReportExObjLst.length);
            console.log(strInfo);
            return arrvgs_PaperReportExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vgs_PaperReport_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vgs_PaperReport_GetObjLst_localStorage = vgs_PaperReport_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vgs_PaperReport_GetObjLst_localStorage_PureCache() {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrvgs_PaperReportObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvgs_PaperReportObjLst_Cache;
        }
        else
            return null;
    }
    exports.vgs_PaperReport_GetObjLst_localStorage_PureCache = vgs_PaperReport_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function vgs_PaperReport_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PaperReport_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vgs_PaperReport_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vgs_PaperReport_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PaperReport_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PaperReport_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PaperReport_GetObjLstAsync = vgs_PaperReport_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vgs_PaperReport_GetObjLst_sessionStorage() {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN._CurrTabName;
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrvgs_PaperReportExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrvgs_PaperReportObjLst_T = vgs_PaperReport_GetObjLstByJSONObjLst(arrvgs_PaperReportExObjLst_Cache);
            return arrvgs_PaperReportObjLst_T;
        }
        try {
            const arrvgs_PaperReportExObjLst = await vgs_PaperReport_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrvgs_PaperReportExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvgs_PaperReportExObjLst.length);
            console.log(strInfo);
            return arrvgs_PaperReportExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vgs_PaperReport_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vgs_PaperReport_GetObjLst_sessionStorage = vgs_PaperReport_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vgs_PaperReport_GetObjLst_sessionStorage_PureCache() {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrvgs_PaperReportObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvgs_PaperReportObjLst_Cache;
        }
        else
            return null;
    }
    exports.vgs_PaperReport_GetObjLst_sessionStorage_PureCache = vgs_PaperReport_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vgs_PaperReport_GetObjLst_Cache() {
        //const strThisFuncName = "GetObjLst_Cache";
        let arrvgs_PaperReportObjLst_Cache;
        switch (clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.CacheModeId) {
            case "04": //sessionStorage
                arrvgs_PaperReportObjLst_Cache = await vgs_PaperReport_GetObjLst_sessionStorage();
                break;
            case "03": //localStorage
                arrvgs_PaperReportObjLst_Cache = await vgs_PaperReport_GetObjLst_localStorage();
                break;
            case "02": //ClientCache
                arrvgs_PaperReportObjLst_Cache = await vgs_PaperReport_GetObjLst_ClientCache();
                break;
            default:
                arrvgs_PaperReportObjLst_Cache = await vgs_PaperReport_GetObjLst_ClientCache();
                break;
        }
        const arrvgs_PaperReportObjLst = vgs_PaperReport_GetObjLstByJSONObjLst(arrvgs_PaperReportObjLst_Cache);
        return arrvgs_PaperReportObjLst_Cache;
    }
    exports.vgs_PaperReport_GetObjLst_Cache = vgs_PaperReport_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vgs_PaperReport_GetObjLst_PureCache() {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrvgs_PaperReportObjLst_Cache;
        switch (clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.CacheModeId) {
            case "04": //sessionStorage
                arrvgs_PaperReportObjLst_Cache = await vgs_PaperReport_GetObjLst_sessionStorage_PureCache();
                break;
            case "03": //localStorage
                arrvgs_PaperReportObjLst_Cache = await vgs_PaperReport_GetObjLst_localStorage_PureCache();
                break;
            case "02": //ClientCache
                arrvgs_PaperReportObjLst_Cache = null;
                break;
            default:
                arrvgs_PaperReportObjLst_Cache = null;
                break;
        }
        return arrvgs_PaperReportObjLst_Cache;
    }
    exports.vgs_PaperReport_GetObjLst_PureCache = vgs_PaperReport_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objstrReportId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function vgs_PaperReport_GetSubObjLst_Cache(objvgs_PaperReport_Cond) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrvgs_PaperReportObjLst_Cache = await vgs_PaperReport_GetObjLst_Cache();
        let arrvgs_PaperReport_Sel = arrvgs_PaperReportObjLst_Cache;
        if (objvgs_PaperReport_Cond.sf_FldComparisonOp == null || objvgs_PaperReport_Cond.sf_FldComparisonOp == "")
            return arrvgs_PaperReport_Sel;
        const dicFldComparisonOp = JSON.parse(objvgs_PaperReport_Cond.sf_FldComparisonOp);
        //console.log("clsvgs_PaperReportWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvgs_PaperReport_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvgs_PaperReport_Sel = arrvgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvgs_PaperReport_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvgs_PaperReport_Sel = arrvgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvgs_PaperReport_Sel = arrvgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvgs_PaperReport_Sel = arrvgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvgs_PaperReport_Sel = arrvgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvgs_PaperReport_Sel = arrvgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvgs_PaperReport_Sel = arrvgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvgs_PaperReport_Sel = arrvgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvgs_PaperReport_Sel = arrvgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvgs_PaperReport_Sel = arrvgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvgs_PaperReport_Sel = arrvgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvgs_PaperReport_Sel = arrvgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvgs_PaperReport_Sel = arrvgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvgs_PaperReport_Sel = arrvgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrvgs_PaperReport_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objvgs_PaperReport_Cond), exports.vgs_PaperReport_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vgs_PaperReport_GetSubObjLst_Cache = vgs_PaperReport_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrReportId:关键字列表
    * @returns 对象列表
    **/
    async function vgs_PaperReport_GetObjLstByReportIdLstAsync(arrReportId) {
        const strThisFuncName = "GetObjLstByReportIdLstAsync";
        const strAction = "GetObjLstByReportIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PaperReport_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrReportId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vgs_PaperReport_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vgs_PaperReport_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PaperReport_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PaperReport_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PaperReport_GetObjLstByReportIdLstAsync = vgs_PaperReport_GetObjLstByReportIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrstrReportIdLst:关键字列表
     * @returns 对象列表
    */
    async function vgs_PaperReport_GetObjLstByReportIdLst_Cache(arrReportIdLst) {
        const strThisFuncName = "GetObjLstByReportIdLst_Cache";
        try {
            const arrvgs_PaperReportObjLst_Cache = await vgs_PaperReport_GetObjLst_Cache();
            const arrvgs_PaperReport_Sel = arrvgs_PaperReportObjLst_Cache.filter(x => arrReportIdLst.indexOf(x.reportId) > -1);
            return arrvgs_PaperReport_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrReportIdLst.join(","), exports.vgs_PaperReport_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
    }
    exports.vgs_PaperReport_GetObjLstByReportIdLst_Cache = vgs_PaperReport_GetObjLstByReportIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function vgs_PaperReport_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PaperReport_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vgs_PaperReport_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vgs_PaperReport_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PaperReport_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PaperReport_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PaperReport_GetTopObjLstAsync = vgs_PaperReport_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vgs_PaperReport_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PaperReport_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vgs_PaperReport_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vgs_PaperReport_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PaperReport_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PaperReport_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PaperReport_GetObjLstByRangeAsync = vgs_PaperReport_GetObjLstByRangeAsync;
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
    async function vgs_PaperReport_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PaperReport_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PaperReport_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PaperReport_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PaperReport_GetObjLstByRange = vgs_PaperReport_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function vgs_PaperReport_GetObjLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const arrvgs_PaperReportObjLst_Cache = await vgs_PaperReport_GetObjLst_Cache();
        if (arrvgs_PaperReportObjLst_Cache.length == 0)
            return arrvgs_PaperReportObjLst_Cache;
        let arrvgs_PaperReport_Sel = arrvgs_PaperReportObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objvgs_PaperReport_Cond = new clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvgs_PaperReport_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsvgs_PaperReportWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvgs_PaperReport_Sel = arrvgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvgs_PaperReport_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvgs_PaperReport_Sel = arrvgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvgs_PaperReport_Sel = arrvgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvgs_PaperReport_Sel = arrvgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvgs_PaperReport_Sel = arrvgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvgs_PaperReport_Sel = arrvgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvgs_PaperReport_Sel = arrvgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvgs_PaperReport_Sel = arrvgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrvgs_PaperReport_Sel = arrvgs_PaperReport_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvgs_PaperReport_Sel = arrvgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvgs_PaperReport_Sel = arrvgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvgs_PaperReport_Sel = arrvgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvgs_PaperReport_Sel = arrvgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvgs_PaperReport_Sel = arrvgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvgs_PaperReport_Sel = arrvgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvgs_PaperReport_Sel.length == 0)
                return arrvgs_PaperReport_Sel;
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
                arrvgs_PaperReport_Sel = arrvgs_PaperReport_Sel.sort(vgs_PaperReport_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrvgs_PaperReport_Sel = arrvgs_PaperReport_Sel.sort(objPagerPara.sortFun);
            }
            arrvgs_PaperReport_Sel = arrvgs_PaperReport_Sel.slice(intStart, intEnd);
            return arrvgs_PaperReport_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.vgs_PaperReport_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vgs_PaperReport_GetObjLstByPager_Cache = vgs_PaperReport_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vgs_PaperReport_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PaperReport_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vgs_PaperReport_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vgs_PaperReport_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PaperReport_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PaperReport_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PaperReport_GetObjLstByPagerAsync = vgs_PaperReport_GetObjLstByPagerAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objstrReportId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function vgs_PaperReport_IsExistRecord_Cache(objvgs_PaperReport_Cond) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrvgs_PaperReportObjLst_Cache = await vgs_PaperReport_GetObjLst_Cache();
        if (arrvgs_PaperReportObjLst_Cache == null)
            return false;
        let arrvgs_PaperReport_Sel = arrvgs_PaperReportObjLst_Cache;
        if (objvgs_PaperReport_Cond.sf_FldComparisonOp == null || objvgs_PaperReport_Cond.sf_FldComparisonOp == "")
            return arrvgs_PaperReport_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objvgs_PaperReport_Cond.sf_FldComparisonOp);
        //console.log("clsvgs_PaperReportWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvgs_PaperReport_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvgs_PaperReport_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvgs_PaperReport_Sel = arrvgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvgs_PaperReport_Sel = arrvgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvgs_PaperReport_Sel = arrvgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvgs_PaperReport_Sel = arrvgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvgs_PaperReport_Sel = arrvgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvgs_PaperReport_Sel = arrvgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvgs_PaperReport_Sel = arrvgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvgs_PaperReport_Sel = arrvgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvgs_PaperReport_Sel = arrvgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvgs_PaperReport_Sel = arrvgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvgs_PaperReport_Sel = arrvgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvgs_PaperReport_Sel = arrvgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvgs_PaperReport_Sel = arrvgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvgs_PaperReport_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objvgs_PaperReport_Cond), exports.vgs_PaperReport_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.vgs_PaperReport_IsExistRecord_Cache = vgs_PaperReport_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function vgs_PaperReport_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PaperReport_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PaperReport_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PaperReport_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PaperReport_IsExistRecordAsync = vgs_PaperReport_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strReportId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function vgs_PaperReport_IsExist(strReportId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PaperReport_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "ReportId": strReportId,
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PaperReport_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PaperReport_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PaperReport_IsExist = vgs_PaperReport_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param strReportId:所给的关键字
     * @returns 对象
    */
    async function vgs_PaperReport_IsExist_Cache(strReportId) {
        const strThisFuncName = "IsExist_Cache";
        const arrvgs_PaperReportObjLst_Cache = await vgs_PaperReport_GetObjLst_Cache();
        if (arrvgs_PaperReportObjLst_Cache == null)
            return false;
        try {
            const arrvgs_PaperReport_Sel = arrvgs_PaperReportObjLst_Cache.filter(x => x.reportId == strReportId);
            if (arrvgs_PaperReport_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strReportId, exports.vgs_PaperReport_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.vgs_PaperReport_IsExist_Cache = vgs_PaperReport_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strReportId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function vgs_PaperReport_IsExistAsync(strReportId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PaperReport_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strReportId": strReportId }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PaperReport_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PaperReport_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PaperReport_IsExistAsync = vgs_PaperReport_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function vgs_PaperReport_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PaperReport_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PaperReport_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PaperReport_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PaperReport_GetRecCountByCondAsync = vgs_PaperReport_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objvgs_PaperReport_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function vgs_PaperReport_GetRecCountByCond_Cache(objvgs_PaperReport_Cond) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrvgs_PaperReportObjLst_Cache = await vgs_PaperReport_GetObjLst_Cache();
        if (arrvgs_PaperReportObjLst_Cache == null)
            return 0;
        let arrvgs_PaperReport_Sel = arrvgs_PaperReportObjLst_Cache;
        if (objvgs_PaperReport_Cond.sf_FldComparisonOp == null || objvgs_PaperReport_Cond.sf_FldComparisonOp == "")
            return arrvgs_PaperReport_Sel.length;
        const dicFldComparisonOp = JSON.parse(objvgs_PaperReport_Cond.sf_FldComparisonOp);
        //console.log("clsvgs_PaperReportWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvgs_PaperReport_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvgs_PaperReport_Sel = arrvgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvgs_PaperReport_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvgs_PaperReport_Sel = arrvgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvgs_PaperReport_Sel = arrvgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvgs_PaperReport_Sel = arrvgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvgs_PaperReport_Sel = arrvgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvgs_PaperReport_Sel = arrvgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvgs_PaperReport_Sel = arrvgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvgs_PaperReport_Sel = arrvgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrvgs_PaperReport_Sel = arrvgs_PaperReport_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvgs_PaperReport_Sel = arrvgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvgs_PaperReport_Sel = arrvgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvgs_PaperReport_Sel = arrvgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvgs_PaperReport_Sel = arrvgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvgs_PaperReport_Sel = arrvgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvgs_PaperReport_Sel = arrvgs_PaperReport_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrvgs_PaperReport_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objvgs_PaperReport_Cond), exports.vgs_PaperReport_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.vgs_PaperReport_GetRecCountByCond_Cache = vgs_PaperReport_GetRecCountByCond_Cache;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function vgs_PaperReport_GetWebApiUrl(strController, strAction) {
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
    exports.vgs_PaperReport_GetWebApiUrl = vgs_PaperReport_GetWebApiUrl;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function vgs_PaperReport_ReFreshThisCache() {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN._CurrTabName;
            switch (clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.CacheModeId) {
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
    exports.vgs_PaperReport_ReFreshThisCache = vgs_PaperReport_ReFreshThisCache;
    /* 该表的下拉框功能没有设置，不需要生成下拉框绑定函数。*/
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vgs_PaperReport_GetJSONStrByObj(pobjvgs_PaperReportEN) {
        const strThisFuncName = "GetJSONStrByObj";
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjvgs_PaperReportEN);
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
    exports.vgs_PaperReport_GetJSONStrByObj = vgs_PaperReport_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function vgs_PaperReport_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrvgs_PaperReportObjLst = new Array();
        if (strJSON === "") {
            return arrvgs_PaperReportObjLst;
        }
        try {
            arrvgs_PaperReportObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrvgs_PaperReportObjLst;
        }
        return arrvgs_PaperReportObjLst;
    }
    exports.vgs_PaperReport_GetObjLstByJSONStr = vgs_PaperReport_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrvgs_PaperReportObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function vgs_PaperReport_GetObjLstByJSONObjLst(arrvgs_PaperReportObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrvgs_PaperReportObjLst = new Array();
        for (const objInFor of arrvgs_PaperReportObjLstS) {
            const obj1 = vgs_PaperReport_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrvgs_PaperReportObjLst.push(obj1);
        }
        return arrvgs_PaperReportObjLst;
    }
    exports.vgs_PaperReport_GetObjLstByJSONObjLst = vgs_PaperReport_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vgs_PaperReport_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjvgs_PaperReportEN = new clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN();
        if (strJSON === "") {
            return pobjvgs_PaperReportEN;
        }
        try {
            pobjvgs_PaperReportEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjvgs_PaperReportEN;
        }
        return pobjvgs_PaperReportEN;
    }
    exports.vgs_PaperReport_GetObjByJSONStr = vgs_PaperReport_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function vgs_PaperReport_GetCombineCondition(objvgs_PaperReport_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objvgs_PaperReport_Cond.dicFldComparisonOp, clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_Memo) == true) {
            const strComparisonOp_Memo = objvgs_PaperReport_Cond.dicFldComparisonOp[clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_Memo, objvgs_PaperReport_Cond.memo, strComparisonOp_Memo);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PaperReport_Cond.dicFldComparisonOp, clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_ReportId) == true) {
            const strComparisonOp_ReportId = objvgs_PaperReport_Cond.dicFldComparisonOp[clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_ReportId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_ReportId, objvgs_PaperReport_Cond.reportId, strComparisonOp_ReportId);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PaperReport_Cond.dicFldComparisonOp, clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objvgs_PaperReport_Cond.dicFldComparisonOp[clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_UpdDate, objvgs_PaperReport_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PaperReport_Cond.dicFldComparisonOp, clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_TopicName) == true) {
            const strComparisonOp_TopicName = objvgs_PaperReport_Cond.dicFldComparisonOp[clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_TopicName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_TopicName, objvgs_PaperReport_Cond.topicName, strComparisonOp_TopicName);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PaperReport_Cond.dicFldComparisonOp, clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_TopicId) == true) {
            const strComparisonOp_TopicId = objvgs_PaperReport_Cond.dicFldComparisonOp[clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_TopicId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_TopicId, objvgs_PaperReport_Cond.topicId, strComparisonOp_TopicId);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PaperReport_Cond.dicFldComparisonOp, clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_PaperId) == true) {
            const strComparisonOp_PaperId = objvgs_PaperReport_Cond.dicFldComparisonOp[clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_PaperId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_PaperId, objvgs_PaperReport_Cond.paperId, strComparisonOp_PaperId);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PaperReport_Cond.dicFldComparisonOp, clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_PaperTitle) == true) {
            const strComparisonOp_PaperTitle = objvgs_PaperReport_Cond.dicFldComparisonOp[clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_PaperTitle];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_PaperTitle, objvgs_PaperReport_Cond.paperTitle, strComparisonOp_PaperTitle);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PaperReport_Cond.dicFldComparisonOp, clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_ReportContent) == true) {
            const strComparisonOp_ReportContent = objvgs_PaperReport_Cond.dicFldComparisonOp[clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_ReportContent];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_ReportContent, objvgs_PaperReport_Cond.reportContent, strComparisonOp_ReportContent);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PaperReport_Cond.dicFldComparisonOp, clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_id_CurrEduCls) == true) {
            const strComparisonOp_id_CurrEduCls = objvgs_PaperReport_Cond.dicFldComparisonOp[clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_id_CurrEduCls];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_id_CurrEduCls, objvgs_PaperReport_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PaperReport_Cond.dicFldComparisonOp, clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_IsSubmit) == true) {
            if (objvgs_PaperReport_Cond.isSubmit == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_IsSubmit);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_IsSubmit);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PaperReport_Cond.dicFldComparisonOp, clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_ReportUser) == true) {
            const strComparisonOp_ReportUser = objvgs_PaperReport_Cond.dicFldComparisonOp[clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_ReportUser];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_ReportUser, objvgs_PaperReport_Cond.reportUser, strComparisonOp_ReportUser);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PaperReport_Cond.dicFldComparisonOp, clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_ReportDate) == true) {
            const strComparisonOp_ReportDate = objvgs_PaperReport_Cond.dicFldComparisonOp[clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_ReportDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_ReportDate, objvgs_PaperReport_Cond.reportDate, strComparisonOp_ReportDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PaperReport_Cond.dicFldComparisonOp, clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objvgs_PaperReport_Cond.dicFldComparisonOp[clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_UpdUser];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_UpdUser, objvgs_PaperReport_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PaperReport_Cond.dicFldComparisonOp, clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_VersionCount) == true) {
            const strComparisonOp_VersionCount = objvgs_PaperReport_Cond.dicFldComparisonOp[clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_VersionCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_VersionCount, objvgs_PaperReport_Cond.versionCount, strComparisonOp_VersionCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PaperReport_Cond.dicFldComparisonOp, clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_OkCount) == true) {
            const strComparisonOp_OkCount = objvgs_PaperReport_Cond.dicFldComparisonOp[clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_OkCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_OkCount, objvgs_PaperReport_Cond.okCount, strComparisonOp_OkCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PaperReport_Cond.dicFldComparisonOp, clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_AppraiseCount) == true) {
            const strComparisonOp_AppraiseCount = objvgs_PaperReport_Cond.dicFldComparisonOp[clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_AppraiseCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_AppraiseCount, objvgs_PaperReport_Cond.appraiseCount, strComparisonOp_AppraiseCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PaperReport_Cond.dicFldComparisonOp, clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_Score) == true) {
            const strComparisonOp_Score = objvgs_PaperReport_Cond.dicFldComparisonOp[clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_Score];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_Score, objvgs_PaperReport_Cond.score, strComparisonOp_Score);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PaperReport_Cond.dicFldComparisonOp, clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_StuScore) == true) {
            const strComparisonOp_StuScore = objvgs_PaperReport_Cond.dicFldComparisonOp[clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_StuScore];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_StuScore, objvgs_PaperReport_Cond.stuScore, strComparisonOp_StuScore);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PaperReport_Cond.dicFldComparisonOp, clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_TeaScore) == true) {
            const strComparisonOp_TeaScore = objvgs_PaperReport_Cond.dicFldComparisonOp[clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_TeaScore];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_TeaScore, objvgs_PaperReport_Cond.teaScore, strComparisonOp_TeaScore);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PaperReport_Cond.dicFldComparisonOp, clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_PDFUrl) == true) {
            const strComparisonOp_PDFUrl = objvgs_PaperReport_Cond.dicFldComparisonOp[clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_PDFUrl];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_PDFUrl, objvgs_PaperReport_Cond.pdFUrl, strComparisonOp_PDFUrl);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PaperReport_Cond.dicFldComparisonOp, clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_PPTUrl) == true) {
            const strComparisonOp_PPTUrl = objvgs_PaperReport_Cond.dicFldComparisonOp[clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_PPTUrl];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_PPTUrl, objvgs_PaperReport_Cond.ppTUrl, strComparisonOp_PPTUrl);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PaperReport_Cond.dicFldComparisonOp, clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_Month) == true) {
            const strComparisonOp_Month = objvgs_PaperReport_Cond.dicFldComparisonOp[clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_Month];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_Month, objvgs_PaperReport_Cond.month, strComparisonOp_Month);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PaperReport_Cond.dicFldComparisonOp, clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_Week) == true) {
            const strComparisonOp_Week = objvgs_PaperReport_Cond.dicFldComparisonOp[clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_Week];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_Week, objvgs_PaperReport_Cond.week, strComparisonOp_Week);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PaperReport_Cond.dicFldComparisonOp, clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_Year) == true) {
            const strComparisonOp_Year = objvgs_PaperReport_Cond.dicFldComparisonOp[clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_Year];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN.con_Year, objvgs_PaperReport_Cond.year, strComparisonOp_Year);
        }
        return strWhereCond;
    }
    exports.vgs_PaperReport_GetCombineCondition = vgs_PaperReport_GetCombineCondition;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objvgs_PaperReportENS:源对象
     * @param objvgs_PaperReportENT:目标对象
    */
    function vgs_PaperReport_CopyObjTo(objvgs_PaperReportENS, objvgs_PaperReportENT) {
        objvgs_PaperReportENT.memo = objvgs_PaperReportENS.memo; //备注
        objvgs_PaperReportENT.reportId = objvgs_PaperReportENS.reportId; //汇报Id
        objvgs_PaperReportENT.updDate = objvgs_PaperReportENS.updDate; //修改日期
        objvgs_PaperReportENT.topicName = objvgs_PaperReportENS.topicName; //栏目主题
        objvgs_PaperReportENT.topicId = objvgs_PaperReportENS.topicId; //主题Id
        objvgs_PaperReportENT.paperId = objvgs_PaperReportENS.paperId; //论文Id
        objvgs_PaperReportENT.paperTitle = objvgs_PaperReportENS.paperTitle; //论文标题
        objvgs_PaperReportENT.reportContent = objvgs_PaperReportENS.reportContent; //汇报内容
        objvgs_PaperReportENT.id_CurrEduCls = objvgs_PaperReportENS.id_CurrEduCls; //教学班流水号
        objvgs_PaperReportENT.isSubmit = objvgs_PaperReportENS.isSubmit; //是否提交
        objvgs_PaperReportENT.reportUser = objvgs_PaperReportENS.reportUser; //汇报用户
        objvgs_PaperReportENT.reportDate = objvgs_PaperReportENS.reportDate; //汇报日期
        objvgs_PaperReportENT.updUser = objvgs_PaperReportENS.updUser; //修改人
        objvgs_PaperReportENT.versionCount = objvgs_PaperReportENS.versionCount; //版本统计
        objvgs_PaperReportENT.okCount = objvgs_PaperReportENS.okCount; //点赞统计
        objvgs_PaperReportENT.appraiseCount = objvgs_PaperReportENS.appraiseCount; //评论数
        objvgs_PaperReportENT.score = objvgs_PaperReportENS.score; //评分
        objvgs_PaperReportENT.stuScore = objvgs_PaperReportENS.stuScore; //学生平均分
        objvgs_PaperReportENT.teaScore = objvgs_PaperReportENS.teaScore; //教师评分
        objvgs_PaperReportENT.pdFUrl = objvgs_PaperReportENS.pdFUrl; //PDFUrl
        objvgs_PaperReportENT.ppTUrl = objvgs_PaperReportENS.ppTUrl; //PPTUrl
        objvgs_PaperReportENT.month = objvgs_PaperReportENS.month; //月
        objvgs_PaperReportENT.week = objvgs_PaperReportENS.week; //周
        objvgs_PaperReportENT.year = objvgs_PaperReportENS.year; //年
    }
    exports.vgs_PaperReport_CopyObjTo = vgs_PaperReport_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objvgs_PaperReportENS:源对象
     * @param objvgs_PaperReportENT:目标对象
    */
    function vgs_PaperReport_GetObjFromJsonObj(objvgs_PaperReportENS) {
        const objvgs_PaperReportENT = new clsvgs_PaperReportEN_js_1.clsvgs_PaperReportEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvgs_PaperReportENT, objvgs_PaperReportENS);
        return objvgs_PaperReportENT;
    }
    exports.vgs_PaperReport_GetObjFromJsonObj = vgs_PaperReport_GetObjFromJsonObj;
});
