/**
* 类名:clsvRTConceptRelaWApi
* 表名:vRTConceptRela(01120607)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/13 00:46:31
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
        define(["require", "exports", "axios", "../../PubFun/enumComparisonOp.js", "../../PubFun/CacheHelper.js", "../../L0_Entity/GraduateEduTopic/clsvRTConceptRelaEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.vRTConceptRela_GetObjFromJsonObj = exports.vRTConceptRela_CopyObjTo = exports.vRTConceptRela_GetUniCondStr4Update_mId_TopicId_ConceptId = exports.vRTConceptRela_GetUniCondStr_mId_TopicId_ConceptId = exports.vRTConceptRela_GetCombineCondition = exports.vRTConceptRela_GetObjByJSONStr = exports.vRTConceptRela_GetObjLstByJSONObjLst = exports.vRTConceptRela_GetObjLstByJSONStr = exports.vRTConceptRela_GetJSONStrByObj = exports.vRTConceptRela_ReFreshThisCache = exports.vRTConceptRela_GetWebApiUrl = exports.vRTConceptRela_GetRecCountByCond_Cache = exports.vRTConceptRela_GetRecCountByCondAsync = exports.vRTConceptRela_IsExistAsync = exports.vRTConceptRela_IsExist_Cache = exports.vRTConceptRela_IsExist = exports.vRTConceptRela_IsExistRecordAsync = exports.vRTConceptRela_IsExistRecord_Cache = exports.vRTConceptRela_ReOrderAsync = exports.vRTConceptRela_GoBottomAsync = exports.vRTConceptRela_DownMoveAsync = exports.vRTConceptRela_UpMoveAsync = exports.vRTConceptRela_GoTopAsync = exports.vRTConceptRela_GetObjLstByPagerAsync = exports.vRTConceptRela_GetObjLstByPager_Cache = exports.vRTConceptRela_GetObjLstByRange = exports.vRTConceptRela_GetObjLstByRangeAsync = exports.vRTConceptRela_GetTopObjLstAsync = exports.vRTConceptRela_GetObjLstBymIdLst_Cache = exports.vRTConceptRela_GetObjLstBymIdLstAsync = exports.vRTConceptRela_GetSubObjLst_Cache = exports.vRTConceptRela_GetObjLst_PureCache = exports.vRTConceptRela_GetObjLst_Cache = exports.vRTConceptRela_GetObjLst_sessionStorage_PureCache = exports.vRTConceptRela_GetObjLst_sessionStorage = exports.vRTConceptRela_GetObjLstAsync = exports.vRTConceptRela_GetObjLst_localStorage_PureCache = exports.vRTConceptRela_GetObjLst_localStorage = exports.vRTConceptRela_GetObjLst_ClientCache = exports.vRTConceptRela_GetFirstObjAsync = exports.vRTConceptRela_GetFirstID = exports.vRTConceptRela_GetFirstIDAsync = exports.vRTConceptRela_funcKey = exports.vRTConceptRela_FilterFunByKey = exports.vRTConceptRela_SortFunByKey = exports.vRTConceptRela_SortFun_Defa_2Fld = exports.vRTConceptRela_SortFun_Defa = exports.vRTConceptRela_func = exports.vRTConceptRela_GetObjBymId_localStorage = exports.vRTConceptRela_GetObjBymId_Cache = exports.vRTConceptRela_GetObjBymIdAsync = exports.vRTConceptRela_ConstructorName = exports.vRTConceptRela_Controller = void 0;
    /**
     * vRTConceptRela(vRTConceptRela)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月13日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const enumComparisonOp_js_1 = require("../../PubFun/enumComparisonOp.js");
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsvRTConceptRelaEN_js_1 = require("../../L0_Entity/GraduateEduTopic/clsvRTConceptRelaEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.vRTConceptRela_Controller = "vRTConceptRelaApi";
    exports.vRTConceptRela_ConstructorName = "vRTConceptRela";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param lngmId:关键字
    * @returns 对象
    **/
    async function vRTConceptRela_GetObjBymIdAsync(lngmId) {
        const strThisFuncName = "GetObjBymIdAsync";
        if (lngmId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngmId]不能为空！(In clsvRTConceptRelaWApi.GetObjBymIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjBymId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vRTConceptRela_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "lngmId": lngmId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    return null;
                }
                //console.log(returnObj);
                const objvRTConceptRela = vRTConceptRela_GetObjFromJsonObj(returnObj);
                return objvRTConceptRela;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vRTConceptRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vRTConceptRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vRTConceptRela_GetObjBymIdAsync = vRTConceptRela_GetObjBymIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param lngmId:所给的关键字
     * @returns 对象
    */
    async function vRTConceptRela_GetObjBymId_Cache(lngmId, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjBymId_Cache";
        if (lngmId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngmId]不能为空！(In clsvRTConceptRelaWApi.GetObjBymId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        const arrvRTConceptRelaObjLst_Cache = await vRTConceptRela_GetObjLst_Cache();
        try {
            const arrvRTConceptRela_Sel = arrvRTConceptRelaObjLst_Cache.filter(x => x.mId == lngmId);
            let objvRTConceptRela;
            if (arrvRTConceptRela_Sel.length > 0) {
                objvRTConceptRela = arrvRTConceptRela_Sel[0];
                return objvRTConceptRela;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    const objvRTConceptRela_Const = await vRTConceptRela_GetObjBymIdAsync(lngmId);
                    if (objvRTConceptRela_Const != null) {
                        vRTConceptRela_ReFreshThisCache();
                        return objvRTConceptRela_Const;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngmId, exports.vRTConceptRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.vRTConceptRela_GetObjBymId_Cache = vRTConceptRela_GetObjBymId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param lngmId:所给的关键字
     * @returns 对象
    */
    async function vRTConceptRela_GetObjBymId_localStorage(lngmId) {
        const strThisFuncName = "GetObjBymId_localStorage";
        if (lngmId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngmId]不能为空！(In clsvRTConceptRelaWApi.GetObjBymId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN._CurrTabName, lngmId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objvRTConceptRela_Cache = JSON.parse(strTempObj);
            return objvRTConceptRela_Cache;
        }
        try {
            const objvRTConceptRela = await vRTConceptRela_GetObjBymIdAsync(lngmId);
            if (objvRTConceptRela != null) {
                localStorage.setItem(strKey, JSON.stringify(objvRTConceptRela));
                const strInfo = (0, clsString_js_1.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objvRTConceptRela;
            }
            return objvRTConceptRela;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngmId, exports.vRTConceptRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.vRTConceptRela_GetObjBymId_localStorage = vRTConceptRela_GetObjBymId_localStorage;
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
    async function vRTConceptRela_func(strInFldName, strOutFldName, strInValue) {
        //const strThisFuncName = "func";
        if (strInFldName != clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_mId) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_1.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strOutFldName, clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const lngmId = Number(strInValue);
        if (lngmId == 0) {
            return "";
        }
        const objvRTConceptRela = await vRTConceptRela_GetObjBymId_Cache(lngmId);
        if (objvRTConceptRela == null)
            return "";
        if (objvRTConceptRela.GetFldValue(strOutFldName) == null)
            return "";
        return objvRTConceptRela.GetFldValue(strOutFldName).toString();
    }
    exports.vRTConceptRela_func = vRTConceptRela_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vRTConceptRela_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.mId - b.mId;
    }
    exports.vRTConceptRela_SortFun_Defa = vRTConceptRela_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vRTConceptRela_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.topicId == b.topicId)
            return a.conceptId.localeCompare(b.conceptId);
        else
            return a.topicId.localeCompare(b.topicId);
    }
    exports.vRTConceptRela_SortFun_Defa_2Fld = vRTConceptRela_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vRTConceptRela_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_mId:
                    return (a, b) => {
                        return a.mId - b.mId;
                    };
                case clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_TopicId:
                    return (a, b) => {
                        if (a.topicId == null)
                            return -1;
                        if (b.topicId == null)
                            return 1;
                        return a.topicId.localeCompare(b.topicId);
                    };
                case clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_ConceptId:
                    return (a, b) => {
                        return a.conceptId.localeCompare(b.conceptId);
                    };
                case clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_UpdDate:
                    return (a, b) => {
                        if (a.updDate == null)
                            return -1;
                        if (b.updDate == null)
                            return 1;
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                case clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_TopicName:
                    return (a, b) => {
                        if (a.topicName == null)
                            return -1;
                        if (b.topicName == null)
                            return 1;
                        return a.topicName.localeCompare(b.topicName);
                    };
                case clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_TopicContent:
                    return (a, b) => {
                        if (a.topicContent == null)
                            return -1;
                        if (b.topicContent == null)
                            return 1;
                        return a.topicContent.localeCompare(b.topicContent);
                    };
                case clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_OrderNum:
                    return (a, b) => {
                        return a.orderNum - b.orderNum;
                    };
                case clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_TopicProposePeople:
                    return (a, b) => {
                        if (a.topicProposePeople == null)
                            return -1;
                        if (b.topicProposePeople == null)
                            return 1;
                        return a.topicProposePeople.localeCompare(b.topicProposePeople);
                    };
                case clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_ConceptContent:
                    return (a, b) => {
                        if (a.conceptContent == null)
                            return -1;
                        if (b.conceptContent == null)
                            return 1;
                        return a.conceptContent.localeCompare(b.conceptContent);
                    };
                case clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_ConceptName:
                    return (a, b) => {
                        if (a.conceptName == null)
                            return -1;
                        if (b.conceptName == null)
                            return 1;
                        return a.conceptName.localeCompare(b.conceptName);
                    };
                case clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_AppraiseCount:
                    return (a, b) => {
                        return a.appraiseCount - b.appraiseCount;
                    };
                case clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_CitationCount:
                    return (a, b) => {
                        return a.citationCount - b.citationCount;
                    };
                case clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_CitationId:
                    return (a, b) => {
                        if (a.citationId == null)
                            return -1;
                        if (b.citationId == null)
                            return 1;
                        return a.citationId.localeCompare(b.citationId);
                    };
                case clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_IsSubmit:
                    return (a, b) => {
                        if (a.isSubmit == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_Score:
                    return (a, b) => {
                        return a.score - b.score;
                    };
                case clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_StuScore:
                    return (a, b) => {
                        return a.stuScore - b.stuScore;
                    };
                case clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_TeaScore:
                    return (a, b) => {
                        return a.teaScore - b.teaScore;
                    };
                case clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_ConcepDate:
                    return (a, b) => {
                        if (a.concepDate == null)
                            return -1;
                        if (b.concepDate == null)
                            return 1;
                        return a.concepDate.localeCompare(b.concepDate);
                    };
                case clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_ConcepUserId:
                    return (a, b) => {
                        if (a.concepUserId == null)
                            return -1;
                        if (b.concepUserId == null)
                            return 1;
                        return a.concepUserId.localeCompare(b.concepUserId);
                    };
                case clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_id_CurrEduCls:
                    return (a, b) => {
                        if (a.id_CurrEduCls == null)
                            return -1;
                        if (b.id_CurrEduCls == null)
                            return 1;
                        return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
                    };
                case clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_PdfContent:
                    return (a, b) => {
                        if (a.pdfContent == null)
                            return -1;
                        if (b.pdfContent == null)
                            return 1;
                        return a.pdfContent.localeCompare(b.pdfContent);
                    };
                case clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_PdfPageNum:
                    return (a, b) => {
                        return a.pdfPageNum - b.pdfPageNum;
                    };
                case clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_OkCount:
                    return (a, b) => {
                        return a.okCount - b.okCount;
                    };
                case clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_VersionCount:
                    return (a, b) => {
                        return a.versionCount - b.versionCount;
                    };
                case clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_CreateDate:
                    return (a, b) => {
                        if (a.createDate == null)
                            return -1;
                        if (b.createDate == null)
                            return 1;
                        return a.createDate.localeCompare(b.createDate);
                    };
                case clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_ShareId:
                    return (a, b) => {
                        if (a.shareId == null)
                            return -1;
                        if (b.shareId == null)
                            return 1;
                        return a.shareId.localeCompare(b.shareId);
                    };
                case clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_UpdUser:
                    return (a, b) => {
                        if (a.updUser == null)
                            return -1;
                        if (b.updUser == null)
                            return 1;
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_ClassificationId:
                    return (a, b) => {
                        if (a.classificationId == null)
                            return -1;
                        if (b.classificationId == null)
                            return 1;
                        return a.classificationId.localeCompare(b.classificationId);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vRTConceptRela]中不存在！(in ${exports.vRTConceptRela_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_mId:
                    return (a, b) => {
                        return b.mId - a.mId;
                    };
                case clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_TopicId:
                    return (a, b) => {
                        if (b.topicId == null)
                            return -1;
                        if (a.topicId == null)
                            return 1;
                        return b.topicId.localeCompare(a.topicId);
                    };
                case clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_ConceptId:
                    return (a, b) => {
                        return b.conceptId.localeCompare(a.conceptId);
                    };
                case clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_UpdDate:
                    return (a, b) => {
                        if (b.updDate == null)
                            return -1;
                        if (a.updDate == null)
                            return 1;
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                case clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_TopicName:
                    return (a, b) => {
                        if (b.topicName == null)
                            return -1;
                        if (a.topicName == null)
                            return 1;
                        return b.topicName.localeCompare(a.topicName);
                    };
                case clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_TopicContent:
                    return (a, b) => {
                        if (b.topicContent == null)
                            return -1;
                        if (a.topicContent == null)
                            return 1;
                        return b.topicContent.localeCompare(a.topicContent);
                    };
                case clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_OrderNum:
                    return (a, b) => {
                        return b.orderNum - a.orderNum;
                    };
                case clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_TopicProposePeople:
                    return (a, b) => {
                        if (b.topicProposePeople == null)
                            return -1;
                        if (a.topicProposePeople == null)
                            return 1;
                        return b.topicProposePeople.localeCompare(a.topicProposePeople);
                    };
                case clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_ConceptContent:
                    return (a, b) => {
                        if (b.conceptContent == null)
                            return -1;
                        if (a.conceptContent == null)
                            return 1;
                        return b.conceptContent.localeCompare(a.conceptContent);
                    };
                case clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_ConceptName:
                    return (a, b) => {
                        if (b.conceptName == null)
                            return -1;
                        if (a.conceptName == null)
                            return 1;
                        return b.conceptName.localeCompare(a.conceptName);
                    };
                case clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_AppraiseCount:
                    return (a, b) => {
                        return b.appraiseCount - a.appraiseCount;
                    };
                case clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_CitationCount:
                    return (a, b) => {
                        return b.citationCount - a.citationCount;
                    };
                case clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_CitationId:
                    return (a, b) => {
                        if (b.citationId == null)
                            return -1;
                        if (a.citationId == null)
                            return 1;
                        return b.citationId.localeCompare(a.citationId);
                    };
                case clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_IsSubmit:
                    return (a, b) => {
                        if (b.isSubmit == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_Score:
                    return (a, b) => {
                        return b.score - a.score;
                    };
                case clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_StuScore:
                    return (a, b) => {
                        return b.stuScore - a.stuScore;
                    };
                case clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_TeaScore:
                    return (a, b) => {
                        return b.teaScore - a.teaScore;
                    };
                case clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_ConcepDate:
                    return (a, b) => {
                        if (b.concepDate == null)
                            return -1;
                        if (a.concepDate == null)
                            return 1;
                        return b.concepDate.localeCompare(a.concepDate);
                    };
                case clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_ConcepUserId:
                    return (a, b) => {
                        if (b.concepUserId == null)
                            return -1;
                        if (a.concepUserId == null)
                            return 1;
                        return b.concepUserId.localeCompare(a.concepUserId);
                    };
                case clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_id_CurrEduCls:
                    return (a, b) => {
                        if (b.id_CurrEduCls == null)
                            return -1;
                        if (a.id_CurrEduCls == null)
                            return 1;
                        return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
                    };
                case clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_PdfContent:
                    return (a, b) => {
                        if (b.pdfContent == null)
                            return -1;
                        if (a.pdfContent == null)
                            return 1;
                        return b.pdfContent.localeCompare(a.pdfContent);
                    };
                case clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_PdfPageNum:
                    return (a, b) => {
                        return b.pdfPageNum - a.pdfPageNum;
                    };
                case clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_OkCount:
                    return (a, b) => {
                        return b.okCount - a.okCount;
                    };
                case clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_VersionCount:
                    return (a, b) => {
                        return b.versionCount - a.versionCount;
                    };
                case clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_CreateDate:
                    return (a, b) => {
                        if (b.createDate == null)
                            return -1;
                        if (a.createDate == null)
                            return 1;
                        return b.createDate.localeCompare(a.createDate);
                    };
                case clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_ShareId:
                    return (a, b) => {
                        if (b.shareId == null)
                            return -1;
                        if (a.shareId == null)
                            return 1;
                        return b.shareId.localeCompare(a.shareId);
                    };
                case clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_UpdUser:
                    return (a, b) => {
                        if (b.updUser == null)
                            return -1;
                        if (a.updUser == null)
                            return 1;
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_ClassificationId:
                    return (a, b) => {
                        if (b.classificationId == null)
                            return -1;
                        if (a.classificationId == null)
                            return 1;
                        return b.classificationId.localeCompare(a.classificationId);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vRTConceptRela]中不存在！(in ${exports.vRTConceptRela_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.vRTConceptRela_SortFunByKey = vRTConceptRela_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function vRTConceptRela_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_mId:
                return (obj) => {
                    return obj.mId === value;
                };
            case clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_TopicId:
                return (obj) => {
                    return obj.topicId === value;
                };
            case clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_ConceptId:
                return (obj) => {
                    return obj.conceptId === value;
                };
            case clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            case clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_TopicName:
                return (obj) => {
                    return obj.topicName === value;
                };
            case clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_TopicContent:
                return (obj) => {
                    return obj.topicContent === value;
                };
            case clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_OrderNum:
                return (obj) => {
                    return obj.orderNum === value;
                };
            case clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_TopicProposePeople:
                return (obj) => {
                    return obj.topicProposePeople === value;
                };
            case clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_ConceptContent:
                return (obj) => {
                    return obj.conceptContent === value;
                };
            case clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_ConceptName:
                return (obj) => {
                    return obj.conceptName === value;
                };
            case clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_AppraiseCount:
                return (obj) => {
                    return obj.appraiseCount === value;
                };
            case clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_CitationCount:
                return (obj) => {
                    return obj.citationCount === value;
                };
            case clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_CitationId:
                return (obj) => {
                    return obj.citationId === value;
                };
            case clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_IsSubmit:
                return (obj) => {
                    return obj.isSubmit === value;
                };
            case clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_Score:
                return (obj) => {
                    return obj.score === value;
                };
            case clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_StuScore:
                return (obj) => {
                    return obj.stuScore === value;
                };
            case clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_TeaScore:
                return (obj) => {
                    return obj.teaScore === value;
                };
            case clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_ConcepDate:
                return (obj) => {
                    return obj.concepDate === value;
                };
            case clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_ConcepUserId:
                return (obj) => {
                    return obj.concepUserId === value;
                };
            case clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_id_CurrEduCls:
                return (obj) => {
                    return obj.id_CurrEduCls === value;
                };
            case clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_PdfContent:
                return (obj) => {
                    return obj.pdfContent === value;
                };
            case clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_PdfPageNum:
                return (obj) => {
                    return obj.pdfPageNum === value;
                };
            case clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_OkCount:
                return (obj) => {
                    return obj.okCount === value;
                };
            case clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_VersionCount:
                return (obj) => {
                    return obj.versionCount === value;
                };
            case clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_CreateDate:
                return (obj) => {
                    return obj.createDate === value;
                };
            case clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_ShareId:
                return (obj) => {
                    return obj.shareId === value;
                };
            case clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_ClassificationId:
                return (obj) => {
                    return obj.classificationId === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[vRTConceptRela]中不存在！(in ${exports.vRTConceptRela_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.vRTConceptRela_FilterFunByKey = vRTConceptRela_FilterFunByKey;
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
    async function vRTConceptRela_funcKey(strInFldName, strInValue, strComparisonOp) {
        //const strThisFuncName = "funcKey";
        if (strInFldName == clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_mId) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (Number(strInValue) == 0) {
            return [];
        }
        const arrvRTConceptRela = await vRTConceptRela_GetObjLst_Cache();
        if (arrvRTConceptRela == null)
            return [];
        let arrvRTConceptRela_Sel = arrvRTConceptRela;
        const strType = typeof (strInValue);
        switch (strType) {
            case "string":
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01: // " = "
                        arrvRTConceptRela_Sel = arrvRTConceptRela_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.Like_03:
                        arrvRTConceptRela_Sel = arrvRTConceptRela_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.In_04:
                        const arrValues = strInValue.split(',');
                        arrvRTConceptRela_Sel = arrvRTConceptRela_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
                        break;
                }
                break;
            case "boolean":
                if (strInValue == null)
                    return [];
                if (strComparisonOp == enumComparisonOp_js_1.enumComparisonOp.Equal_01) {
                    arrvRTConceptRela_Sel = arrvRTConceptRela_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                }
                break;
            case "number":
                if (Number(strInValue) == 0)
                    return [];
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01:
                        arrvRTConceptRela_Sel = arrvRTConceptRela_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotEqual_02:
                        arrvRTConceptRela_Sel = arrvRTConceptRela_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotLessThan_05: //" >= ":
                        arrvRTConceptRela_Sel = arrvRTConceptRela_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotGreaterThan_06: //" <= ":
                        arrvRTConceptRela_Sel = arrvRTConceptRela_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.GreaterThan_07: //" > ":
                        arrvRTConceptRela_Sel = arrvRTConceptRela_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.LessThan_08: //" < ":
                        arrvRTConceptRela_Sel = arrvRTConceptRela_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                }
                break;
        }
        if (arrvRTConceptRela_Sel.length == 0)
            return [];
        return arrvRTConceptRela_Sel.map(x => x.mId);
    }
    exports.vRTConceptRela_funcKey = vRTConceptRela_funcKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function vRTConceptRela_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vRTConceptRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vRTConceptRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vRTConceptRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vRTConceptRela_GetFirstIDAsync = vRTConceptRela_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function vRTConceptRela_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vRTConceptRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vRTConceptRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vRTConceptRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vRTConceptRela_GetFirstID = vRTConceptRela_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function vRTConceptRela_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vRTConceptRela_Controller, strAction);
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
                const objvRTConceptRela = vRTConceptRela_GetObjFromJsonObj(returnObj);
                return objvRTConceptRela;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vRTConceptRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vRTConceptRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vRTConceptRela_GetFirstObjAsync = vRTConceptRela_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vRTConceptRela_GetObjLst_ClientCache() {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN._CurrTabName;
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_1.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrvRTConceptRelaExObjLst_Cache = CacheHelper_js_1.CacheHelper.Get(strKey);
            const arrvRTConceptRelaObjLst_T = vRTConceptRela_GetObjLstByJSONObjLst(arrvRTConceptRelaExObjLst_Cache);
            return arrvRTConceptRelaObjLst_T;
        }
        try {
            const arrvRTConceptRelaExObjLst = await vRTConceptRela_GetObjLstAsync(strWhereCond);
            CacheHelper_js_1.CacheHelper.Add(strKey, arrvRTConceptRelaExObjLst);
            const strInfo = (0, clsString_js_1.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvRTConceptRelaExObjLst.length);
            console.log(strInfo);
            return arrvRTConceptRelaExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vRTConceptRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vRTConceptRela_GetObjLst_ClientCache = vRTConceptRela_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vRTConceptRela_GetObjLst_localStorage() {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN._CurrTabName;
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrvRTConceptRelaExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrvRTConceptRelaObjLst_T = vRTConceptRela_GetObjLstByJSONObjLst(arrvRTConceptRelaExObjLst_Cache);
            return arrvRTConceptRelaObjLst_T;
        }
        try {
            const arrvRTConceptRelaExObjLst = await vRTConceptRela_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrvRTConceptRelaExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvRTConceptRelaExObjLst.length);
            console.log(strInfo);
            return arrvRTConceptRelaExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vRTConceptRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vRTConceptRela_GetObjLst_localStorage = vRTConceptRela_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vRTConceptRela_GetObjLst_localStorage_PureCache() {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrvRTConceptRelaObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvRTConceptRelaObjLst_Cache;
        }
        else
            return null;
    }
    exports.vRTConceptRela_GetObjLst_localStorage_PureCache = vRTConceptRela_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function vRTConceptRela_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vRTConceptRela_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vRTConceptRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vRTConceptRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vRTConceptRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vRTConceptRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vRTConceptRela_GetObjLstAsync = vRTConceptRela_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vRTConceptRela_GetObjLst_sessionStorage() {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN._CurrTabName;
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrvRTConceptRelaExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrvRTConceptRelaObjLst_T = vRTConceptRela_GetObjLstByJSONObjLst(arrvRTConceptRelaExObjLst_Cache);
            return arrvRTConceptRelaObjLst_T;
        }
        try {
            const arrvRTConceptRelaExObjLst = await vRTConceptRela_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrvRTConceptRelaExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvRTConceptRelaExObjLst.length);
            console.log(strInfo);
            return arrvRTConceptRelaExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vRTConceptRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vRTConceptRela_GetObjLst_sessionStorage = vRTConceptRela_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vRTConceptRela_GetObjLst_sessionStorage_PureCache() {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrvRTConceptRelaObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvRTConceptRelaObjLst_Cache;
        }
        else
            return null;
    }
    exports.vRTConceptRela_GetObjLst_sessionStorage_PureCache = vRTConceptRela_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vRTConceptRela_GetObjLst_Cache() {
        //const strThisFuncName = "GetObjLst_Cache";
        let arrvRTConceptRelaObjLst_Cache;
        switch (clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.CacheModeId) {
            case "04": //sessionStorage
                arrvRTConceptRelaObjLst_Cache = await vRTConceptRela_GetObjLst_sessionStorage();
                break;
            case "03": //localStorage
                arrvRTConceptRelaObjLst_Cache = await vRTConceptRela_GetObjLst_localStorage();
                break;
            case "02": //ClientCache
                arrvRTConceptRelaObjLst_Cache = await vRTConceptRela_GetObjLst_ClientCache();
                break;
            default:
                arrvRTConceptRelaObjLst_Cache = await vRTConceptRela_GetObjLst_ClientCache();
                break;
        }
        const arrvRTConceptRelaObjLst = vRTConceptRela_GetObjLstByJSONObjLst(arrvRTConceptRelaObjLst_Cache);
        return arrvRTConceptRelaObjLst_Cache;
    }
    exports.vRTConceptRela_GetObjLst_Cache = vRTConceptRela_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vRTConceptRela_GetObjLst_PureCache() {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrvRTConceptRelaObjLst_Cache;
        switch (clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.CacheModeId) {
            case "04": //sessionStorage
                arrvRTConceptRelaObjLst_Cache = await vRTConceptRela_GetObjLst_sessionStorage_PureCache();
                break;
            case "03": //localStorage
                arrvRTConceptRelaObjLst_Cache = await vRTConceptRela_GetObjLst_localStorage_PureCache();
                break;
            case "02": //ClientCache
                arrvRTConceptRelaObjLst_Cache = null;
                break;
            default:
                arrvRTConceptRelaObjLst_Cache = null;
                break;
        }
        return arrvRTConceptRelaObjLst_Cache;
    }
    exports.vRTConceptRela_GetObjLst_PureCache = vRTConceptRela_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objlngmId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function vRTConceptRela_GetSubObjLst_Cache(objvRTConceptRela_Cond) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrvRTConceptRelaObjLst_Cache = await vRTConceptRela_GetObjLst_Cache();
        let arrvRTConceptRela_Sel = arrvRTConceptRelaObjLst_Cache;
        if (objvRTConceptRela_Cond.sf_FldComparisonOp == null || objvRTConceptRela_Cond.sf_FldComparisonOp == "")
            return arrvRTConceptRela_Sel;
        const dicFldComparisonOp = JSON.parse(objvRTConceptRela_Cond.sf_FldComparisonOp);
        //console.log("clsvRTConceptRelaWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvRTConceptRela_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvRTConceptRela_Sel = arrvRTConceptRela_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvRTConceptRela_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvRTConceptRela_Sel = arrvRTConceptRela_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvRTConceptRela_Sel = arrvRTConceptRela_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvRTConceptRela_Sel = arrvRTConceptRela_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvRTConceptRela_Sel = arrvRTConceptRela_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvRTConceptRela_Sel = arrvRTConceptRela_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvRTConceptRela_Sel = arrvRTConceptRela_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvRTConceptRela_Sel = arrvRTConceptRela_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvRTConceptRela_Sel = arrvRTConceptRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvRTConceptRela_Sel = arrvRTConceptRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvRTConceptRela_Sel = arrvRTConceptRela_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvRTConceptRela_Sel = arrvRTConceptRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvRTConceptRela_Sel = arrvRTConceptRela_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvRTConceptRela_Sel = arrvRTConceptRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrvRTConceptRela_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objvRTConceptRela_Cond), exports.vRTConceptRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vRTConceptRela_GetSubObjLst_Cache = vRTConceptRela_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrmId:关键字列表
    * @returns 对象列表
    **/
    async function vRTConceptRela_GetObjLstBymIdLstAsync(arrmId) {
        const strThisFuncName = "GetObjLstBymIdLstAsync";
        const strAction = "GetObjLstBymIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vRTConceptRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrmId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vRTConceptRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vRTConceptRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vRTConceptRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vRTConceptRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vRTConceptRela_GetObjLstBymIdLstAsync = vRTConceptRela_GetObjLstBymIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrlngmIdLst:关键字列表
     * @returns 对象列表
    */
    async function vRTConceptRela_GetObjLstBymIdLst_Cache(arrmIdLst) {
        const strThisFuncName = "GetObjLstBymIdLst_Cache";
        try {
            const arrvRTConceptRelaObjLst_Cache = await vRTConceptRela_GetObjLst_Cache();
            const arrvRTConceptRela_Sel = arrvRTConceptRelaObjLst_Cache.filter(x => arrmIdLst.indexOf(x.mId) > -1);
            return arrvRTConceptRela_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrmIdLst.join(","), exports.vRTConceptRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
    }
    exports.vRTConceptRela_GetObjLstBymIdLst_Cache = vRTConceptRela_GetObjLstBymIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function vRTConceptRela_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vRTConceptRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vRTConceptRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vRTConceptRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vRTConceptRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vRTConceptRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vRTConceptRela_GetTopObjLstAsync = vRTConceptRela_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vRTConceptRela_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vRTConceptRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vRTConceptRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vRTConceptRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vRTConceptRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vRTConceptRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vRTConceptRela_GetObjLstByRangeAsync = vRTConceptRela_GetObjLstByRangeAsync;
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
    async function vRTConceptRela_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vRTConceptRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vRTConceptRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vRTConceptRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vRTConceptRela_GetObjLstByRange = vRTConceptRela_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function vRTConceptRela_GetObjLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const arrvRTConceptRelaObjLst_Cache = await vRTConceptRela_GetObjLst_Cache();
        if (arrvRTConceptRelaObjLst_Cache.length == 0)
            return arrvRTConceptRelaObjLst_Cache;
        let arrvRTConceptRela_Sel = arrvRTConceptRelaObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objvRTConceptRela_Cond = new clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvRTConceptRela_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsvRTConceptRelaWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvRTConceptRela_Sel = arrvRTConceptRela_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvRTConceptRela_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvRTConceptRela_Sel = arrvRTConceptRela_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvRTConceptRela_Sel = arrvRTConceptRela_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvRTConceptRela_Sel = arrvRTConceptRela_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvRTConceptRela_Sel = arrvRTConceptRela_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvRTConceptRela_Sel = arrvRTConceptRela_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvRTConceptRela_Sel = arrvRTConceptRela_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvRTConceptRela_Sel = arrvRTConceptRela_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrvRTConceptRela_Sel = arrvRTConceptRela_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvRTConceptRela_Sel = arrvRTConceptRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvRTConceptRela_Sel = arrvRTConceptRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvRTConceptRela_Sel = arrvRTConceptRela_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvRTConceptRela_Sel = arrvRTConceptRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvRTConceptRela_Sel = arrvRTConceptRela_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvRTConceptRela_Sel = arrvRTConceptRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvRTConceptRela_Sel.length == 0)
                return arrvRTConceptRela_Sel;
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
                arrvRTConceptRela_Sel = arrvRTConceptRela_Sel.sort(vRTConceptRela_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrvRTConceptRela_Sel = arrvRTConceptRela_Sel.sort(objPagerPara.sortFun);
            }
            arrvRTConceptRela_Sel = arrvRTConceptRela_Sel.slice(intStart, intEnd);
            return arrvRTConceptRela_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.vRTConceptRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vRTConceptRela_GetObjLstByPager_Cache = vRTConceptRela_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vRTConceptRela_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vRTConceptRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vRTConceptRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vRTConceptRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vRTConceptRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vRTConceptRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vRTConceptRela_GetObjLstByPagerAsync = vRTConceptRela_GetObjLstByPagerAsync;
    /**
    * 把所给的关键字列表相关的记录移顶
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GoTopAsync)
    * @param objvRTConceptRelaEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function vRTConceptRela_GoTopAsync(objOrderByData) {
        const strThisFuncName = "GoTopAsync";
        let strMsg = "";
        const strAction = "GoTop";
        if (objOrderByData.KeyIdLst.length == 0) {
            strMsg = "根据关键字列表置顶时，给定的关键字值列表不能为空!";
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vRTConceptRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vRTConceptRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vRTConceptRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vRTConceptRela_GoTopAsync = vRTConceptRela_GoTopAsync;
    /**
    * 把所给的关键字列表相关的记录上移
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpMoveAsync)
    * @param objvRTConceptRelaEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function vRTConceptRela_UpMoveAsync(objOrderByData) {
        const strThisFuncName = "UpMoveAsync";
        let strMsg = "";
        const strAction = "UpMove";
        if (objOrderByData.KeyIdLst.length == 0) {
            strMsg = "根据关键字列表上移时，给定的关键字值列表不能为空!";
            throw strMsg;
        }
        //var strJSON = JSON.stringify(objvRTConceptRelaEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vRTConceptRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vRTConceptRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vRTConceptRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vRTConceptRela_UpMoveAsync = vRTConceptRela_UpMoveAsync;
    /**
    * 把所给的关键字列表相关的记录下移
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DownMoveAsync)
    * @param objvRTConceptRelaEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function vRTConceptRela_DownMoveAsync(objOrderByData) {
        const strThisFuncName = "DownMoveAsync";
        let strMsg = "";
        const strAction = "DownMove";
        if (objOrderByData.KeyIdLst.length == 0) {
            strMsg = "根据关键字列表下移时，给定的关键字值列表不能为空!";
            throw strMsg;
        }
        //var strJSON = JSON.stringify(objvRTConceptRelaEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vRTConceptRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vRTConceptRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vRTConceptRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vRTConceptRela_DownMoveAsync = vRTConceptRela_DownMoveAsync;
    /**
    * 把所给的关键字列表相关的记录移底
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GoBottomAsync)
    * @param objvRTConceptRelaEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function vRTConceptRela_GoBottomAsync(objOrderByData) {
        const strThisFuncName = "GoBottomAsync";
        let strMsg = "";
        const strAction = "GoBottom";
        if (objOrderByData.KeyIdLst.length == 0) {
            strMsg = "根据关键字列表置底时，给定的关键字值列表不能为空!";
            throw strMsg;
        }
        //var strJSON = JSON.stringify(objvRTConceptRelaEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vRTConceptRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vRTConceptRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vRTConceptRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vRTConceptRela_GoBottomAsync = vRTConceptRela_GoBottomAsync;
    /**
    * 把列表记录重序
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReOrderAsync)
    * @param objvRTConceptRelaEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function vRTConceptRela_ReOrderAsync(objOrderByData) {
        const strThisFuncName = "ReOrderAsync";
        const strAction = "ReOrder";
        //var strJSON = JSON.stringify(objvRTConceptRelaEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vRTConceptRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vRTConceptRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vRTConceptRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vRTConceptRela_ReOrderAsync = vRTConceptRela_ReOrderAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objlngmId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function vRTConceptRela_IsExistRecord_Cache(objvRTConceptRela_Cond) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrvRTConceptRelaObjLst_Cache = await vRTConceptRela_GetObjLst_Cache();
        if (arrvRTConceptRelaObjLst_Cache == null)
            return false;
        let arrvRTConceptRela_Sel = arrvRTConceptRelaObjLst_Cache;
        if (objvRTConceptRela_Cond.sf_FldComparisonOp == null || objvRTConceptRela_Cond.sf_FldComparisonOp == "")
            return arrvRTConceptRela_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objvRTConceptRela_Cond.sf_FldComparisonOp);
        //console.log("clsvRTConceptRelaWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvRTConceptRela_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvRTConceptRela_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvRTConceptRela_Sel = arrvRTConceptRela_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvRTConceptRela_Sel = arrvRTConceptRela_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvRTConceptRela_Sel = arrvRTConceptRela_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvRTConceptRela_Sel = arrvRTConceptRela_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvRTConceptRela_Sel = arrvRTConceptRela_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvRTConceptRela_Sel = arrvRTConceptRela_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvRTConceptRela_Sel = arrvRTConceptRela_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvRTConceptRela_Sel = arrvRTConceptRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvRTConceptRela_Sel = arrvRTConceptRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvRTConceptRela_Sel = arrvRTConceptRela_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvRTConceptRela_Sel = arrvRTConceptRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvRTConceptRela_Sel = arrvRTConceptRela_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvRTConceptRela_Sel = arrvRTConceptRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvRTConceptRela_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objvRTConceptRela_Cond), exports.vRTConceptRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.vRTConceptRela_IsExistRecord_Cache = vRTConceptRela_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function vRTConceptRela_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vRTConceptRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vRTConceptRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vRTConceptRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vRTConceptRela_IsExistRecordAsync = vRTConceptRela_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param lngmId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function vRTConceptRela_IsExist(lngmId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vRTConceptRela_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "mId": lngmId,
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vRTConceptRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vRTConceptRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vRTConceptRela_IsExist = vRTConceptRela_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param lngmId:所给的关键字
     * @returns 对象
    */
    async function vRTConceptRela_IsExist_Cache(lngmId) {
        const strThisFuncName = "IsExist_Cache";
        const arrvRTConceptRelaObjLst_Cache = await vRTConceptRela_GetObjLst_Cache();
        if (arrvRTConceptRelaObjLst_Cache == null)
            return false;
        try {
            const arrvRTConceptRela_Sel = arrvRTConceptRelaObjLst_Cache.filter(x => x.mId == lngmId);
            if (arrvRTConceptRela_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", lngmId, exports.vRTConceptRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.vRTConceptRela_IsExist_Cache = vRTConceptRela_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param lngmId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function vRTConceptRela_IsExistAsync(lngmId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vRTConceptRela_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "lngmId": lngmId }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vRTConceptRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vRTConceptRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vRTConceptRela_IsExistAsync = vRTConceptRela_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function vRTConceptRela_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vRTConceptRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vRTConceptRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vRTConceptRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vRTConceptRela_GetRecCountByCondAsync = vRTConceptRela_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objvRTConceptRela_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function vRTConceptRela_GetRecCountByCond_Cache(objvRTConceptRela_Cond) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrvRTConceptRelaObjLst_Cache = await vRTConceptRela_GetObjLst_Cache();
        if (arrvRTConceptRelaObjLst_Cache == null)
            return 0;
        let arrvRTConceptRela_Sel = arrvRTConceptRelaObjLst_Cache;
        if (objvRTConceptRela_Cond.sf_FldComparisonOp == null || objvRTConceptRela_Cond.sf_FldComparisonOp == "")
            return arrvRTConceptRela_Sel.length;
        const dicFldComparisonOp = JSON.parse(objvRTConceptRela_Cond.sf_FldComparisonOp);
        //console.log("clsvRTConceptRelaWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvRTConceptRela_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvRTConceptRela_Sel = arrvRTConceptRela_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvRTConceptRela_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvRTConceptRela_Sel = arrvRTConceptRela_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvRTConceptRela_Sel = arrvRTConceptRela_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvRTConceptRela_Sel = arrvRTConceptRela_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvRTConceptRela_Sel = arrvRTConceptRela_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvRTConceptRela_Sel = arrvRTConceptRela_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvRTConceptRela_Sel = arrvRTConceptRela_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvRTConceptRela_Sel = arrvRTConceptRela_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrvRTConceptRela_Sel = arrvRTConceptRela_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvRTConceptRela_Sel = arrvRTConceptRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvRTConceptRela_Sel = arrvRTConceptRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvRTConceptRela_Sel = arrvRTConceptRela_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvRTConceptRela_Sel = arrvRTConceptRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvRTConceptRela_Sel = arrvRTConceptRela_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvRTConceptRela_Sel = arrvRTConceptRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrvRTConceptRela_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objvRTConceptRela_Cond), exports.vRTConceptRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.vRTConceptRela_GetRecCountByCond_Cache = vRTConceptRela_GetRecCountByCond_Cache;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function vRTConceptRela_GetWebApiUrl(strController, strAction) {
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
    exports.vRTConceptRela_GetWebApiUrl = vRTConceptRela_GetWebApiUrl;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function vRTConceptRela_ReFreshThisCache() {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN._CurrTabName;
            switch (clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.CacheModeId) {
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
    exports.vRTConceptRela_ReFreshThisCache = vRTConceptRela_ReFreshThisCache;
    /* 该表的下拉框功能没有设置，不需要生成下拉框绑定函数。*/
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vRTConceptRela_GetJSONStrByObj(pobjvRTConceptRelaEN) {
        const strThisFuncName = "GetJSONStrByObj";
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjvRTConceptRelaEN);
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
    exports.vRTConceptRela_GetJSONStrByObj = vRTConceptRela_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function vRTConceptRela_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrvRTConceptRelaObjLst = new Array();
        if (strJSON === "") {
            return arrvRTConceptRelaObjLst;
        }
        try {
            arrvRTConceptRelaObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrvRTConceptRelaObjLst;
        }
        return arrvRTConceptRelaObjLst;
    }
    exports.vRTConceptRela_GetObjLstByJSONStr = vRTConceptRela_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrvRTConceptRelaObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function vRTConceptRela_GetObjLstByJSONObjLst(arrvRTConceptRelaObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrvRTConceptRelaObjLst = new Array();
        for (const objInFor of arrvRTConceptRelaObjLstS) {
            const obj1 = vRTConceptRela_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrvRTConceptRelaObjLst.push(obj1);
        }
        return arrvRTConceptRelaObjLst;
    }
    exports.vRTConceptRela_GetObjLstByJSONObjLst = vRTConceptRela_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vRTConceptRela_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjvRTConceptRelaEN = new clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN();
        if (strJSON === "") {
            return pobjvRTConceptRelaEN;
        }
        try {
            pobjvRTConceptRelaEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjvRTConceptRelaEN;
        }
        return pobjvRTConceptRelaEN;
    }
    exports.vRTConceptRela_GetObjByJSONStr = vRTConceptRela_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function vRTConceptRela_GetCombineCondition(objvRTConceptRela_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objvRTConceptRela_Cond.dicFldComparisonOp, clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_mId) == true) {
            const strComparisonOp_mId = objvRTConceptRela_Cond.dicFldComparisonOp[clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_mId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_mId, objvRTConceptRela_Cond.mId, strComparisonOp_mId);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTConceptRela_Cond.dicFldComparisonOp, clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_TopicId) == true) {
            const strComparisonOp_TopicId = objvRTConceptRela_Cond.dicFldComparisonOp[clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_TopicId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_TopicId, objvRTConceptRela_Cond.topicId, strComparisonOp_TopicId);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTConceptRela_Cond.dicFldComparisonOp, clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_ConceptId) == true) {
            const strComparisonOp_ConceptId = objvRTConceptRela_Cond.dicFldComparisonOp[clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_ConceptId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_ConceptId, objvRTConceptRela_Cond.conceptId, strComparisonOp_ConceptId);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTConceptRela_Cond.dicFldComparisonOp, clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objvRTConceptRela_Cond.dicFldComparisonOp[clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_UpdDate, objvRTConceptRela_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTConceptRela_Cond.dicFldComparisonOp, clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_Memo) == true) {
            const strComparisonOp_Memo = objvRTConceptRela_Cond.dicFldComparisonOp[clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_Memo, objvRTConceptRela_Cond.memo, strComparisonOp_Memo);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTConceptRela_Cond.dicFldComparisonOp, clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_TopicName) == true) {
            const strComparisonOp_TopicName = objvRTConceptRela_Cond.dicFldComparisonOp[clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_TopicName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_TopicName, objvRTConceptRela_Cond.topicName, strComparisonOp_TopicName);
        }
        //数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
        if (Object.prototype.hasOwnProperty.call(objvRTConceptRela_Cond.dicFldComparisonOp, clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_OrderNum) == true) {
            const strComparisonOp_OrderNum = objvRTConceptRela_Cond.dicFldComparisonOp[clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_OrderNum];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_OrderNum, objvRTConceptRela_Cond.orderNum, strComparisonOp_OrderNum);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTConceptRela_Cond.dicFldComparisonOp, clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_TopicProposePeople) == true) {
            const strComparisonOp_TopicProposePeople = objvRTConceptRela_Cond.dicFldComparisonOp[clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_TopicProposePeople];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_TopicProposePeople, objvRTConceptRela_Cond.topicProposePeople, strComparisonOp_TopicProposePeople);
        }
        //数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
        if (Object.prototype.hasOwnProperty.call(objvRTConceptRela_Cond.dicFldComparisonOp, clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_ConceptName) == true) {
            const strComparisonOp_ConceptName = objvRTConceptRela_Cond.dicFldComparisonOp[clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_ConceptName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_ConceptName, objvRTConceptRela_Cond.conceptName, strComparisonOp_ConceptName);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTConceptRela_Cond.dicFldComparisonOp, clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_AppraiseCount) == true) {
            const strComparisonOp_AppraiseCount = objvRTConceptRela_Cond.dicFldComparisonOp[clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_AppraiseCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_AppraiseCount, objvRTConceptRela_Cond.appraiseCount, strComparisonOp_AppraiseCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTConceptRela_Cond.dicFldComparisonOp, clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_CitationCount) == true) {
            const strComparisonOp_CitationCount = objvRTConceptRela_Cond.dicFldComparisonOp[clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_CitationCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_CitationCount, objvRTConceptRela_Cond.citationCount, strComparisonOp_CitationCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTConceptRela_Cond.dicFldComparisonOp, clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_CitationId) == true) {
            const strComparisonOp_CitationId = objvRTConceptRela_Cond.dicFldComparisonOp[clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_CitationId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_CitationId, objvRTConceptRela_Cond.citationId, strComparisonOp_CitationId);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTConceptRela_Cond.dicFldComparisonOp, clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_IsSubmit) == true) {
            if (objvRTConceptRela_Cond.isSubmit == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_IsSubmit);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_IsSubmit);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvRTConceptRela_Cond.dicFldComparisonOp, clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_Score) == true) {
            const strComparisonOp_Score = objvRTConceptRela_Cond.dicFldComparisonOp[clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_Score];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_Score, objvRTConceptRela_Cond.score, strComparisonOp_Score);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTConceptRela_Cond.dicFldComparisonOp, clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_StuScore) == true) {
            const strComparisonOp_StuScore = objvRTConceptRela_Cond.dicFldComparisonOp[clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_StuScore];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_StuScore, objvRTConceptRela_Cond.stuScore, strComparisonOp_StuScore);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTConceptRela_Cond.dicFldComparisonOp, clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_TeaScore) == true) {
            const strComparisonOp_TeaScore = objvRTConceptRela_Cond.dicFldComparisonOp[clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_TeaScore];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_TeaScore, objvRTConceptRela_Cond.teaScore, strComparisonOp_TeaScore);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTConceptRela_Cond.dicFldComparisonOp, clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_ConcepDate) == true) {
            const strComparisonOp_ConcepDate = objvRTConceptRela_Cond.dicFldComparisonOp[clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_ConcepDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_ConcepDate, objvRTConceptRela_Cond.concepDate, strComparisonOp_ConcepDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTConceptRela_Cond.dicFldComparisonOp, clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_ConcepUserId) == true) {
            const strComparisonOp_ConcepUserId = objvRTConceptRela_Cond.dicFldComparisonOp[clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_ConcepUserId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_ConcepUserId, objvRTConceptRela_Cond.concepUserId, strComparisonOp_ConcepUserId);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTConceptRela_Cond.dicFldComparisonOp, clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_id_CurrEduCls) == true) {
            const strComparisonOp_id_CurrEduCls = objvRTConceptRela_Cond.dicFldComparisonOp[clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_id_CurrEduCls];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_id_CurrEduCls, objvRTConceptRela_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTConceptRela_Cond.dicFldComparisonOp, clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_PdfContent) == true) {
            const strComparisonOp_PdfContent = objvRTConceptRela_Cond.dicFldComparisonOp[clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_PdfContent];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_PdfContent, objvRTConceptRela_Cond.pdfContent, strComparisonOp_PdfContent);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTConceptRela_Cond.dicFldComparisonOp, clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_PdfPageNum) == true) {
            const strComparisonOp_PdfPageNum = objvRTConceptRela_Cond.dicFldComparisonOp[clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_PdfPageNum];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_PdfPageNum, objvRTConceptRela_Cond.pdfPageNum, strComparisonOp_PdfPageNum);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTConceptRela_Cond.dicFldComparisonOp, clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_OkCount) == true) {
            const strComparisonOp_OkCount = objvRTConceptRela_Cond.dicFldComparisonOp[clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_OkCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_OkCount, objvRTConceptRela_Cond.okCount, strComparisonOp_OkCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTConceptRela_Cond.dicFldComparisonOp, clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_VersionCount) == true) {
            const strComparisonOp_VersionCount = objvRTConceptRela_Cond.dicFldComparisonOp[clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_VersionCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_VersionCount, objvRTConceptRela_Cond.versionCount, strComparisonOp_VersionCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTConceptRela_Cond.dicFldComparisonOp, clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_CreateDate) == true) {
            const strComparisonOp_CreateDate = objvRTConceptRela_Cond.dicFldComparisonOp[clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_CreateDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_CreateDate, objvRTConceptRela_Cond.createDate, strComparisonOp_CreateDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTConceptRela_Cond.dicFldComparisonOp, clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_ShareId) == true) {
            const strComparisonOp_ShareId = objvRTConceptRela_Cond.dicFldComparisonOp[clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_ShareId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_ShareId, objvRTConceptRela_Cond.shareId, strComparisonOp_ShareId);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTConceptRela_Cond.dicFldComparisonOp, clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objvRTConceptRela_Cond.dicFldComparisonOp[clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_UpdUser];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_UpdUser, objvRTConceptRela_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTConceptRela_Cond.dicFldComparisonOp, clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_ClassificationId) == true) {
            const strComparisonOp_ClassificationId = objvRTConceptRela_Cond.dicFldComparisonOp[clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_ClassificationId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN.con_ClassificationId, objvRTConceptRela_Cond.classificationId, strComparisonOp_ClassificationId);
        }
        return strWhereCond;
    }
    exports.vRTConceptRela_GetCombineCondition = vRTConceptRela_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--vRTConceptRela(vRTConceptRela),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param lngmId: mId(要求唯一的字段)
    * @param strTopicId: 主题Id(要求唯一的字段)
    * @param strConceptId: 概念Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function vRTConceptRela_GetUniCondStr_mId_TopicId_ConceptId(objvRTConceptRelaEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and mId = '{0}'", objvRTConceptRelaEN.mId);
        strWhereCond += (0, clsString_js_1.Format)(" and TopicId = '{0}'", objvRTConceptRelaEN.topicId);
        strWhereCond += (0, clsString_js_1.Format)(" and ConceptId = '{0}'", objvRTConceptRelaEN.conceptId);
        return strWhereCond;
    }
    exports.vRTConceptRela_GetUniCondStr_mId_TopicId_ConceptId = vRTConceptRela_GetUniCondStr_mId_TopicId_ConceptId;
    /**
    *获取唯一性条件串(Uniqueness)--vRTConceptRela(vRTConceptRela),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param lngmId: mId(要求唯一的字段)
    * @param strTopicId: 主题Id(要求唯一的字段)
    * @param strConceptId: 概念Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function vRTConceptRela_GetUniCondStr4Update_mId_TopicId_ConceptId(objvRTConceptRelaEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and mId <> '{0}'", objvRTConceptRelaEN.mId);
        strWhereCond += (0, clsString_js_1.Format)(" and mId = '{0}'", objvRTConceptRelaEN.mId);
        strWhereCond += (0, clsString_js_1.Format)(" and TopicId = '{0}'", objvRTConceptRelaEN.topicId);
        strWhereCond += (0, clsString_js_1.Format)(" and ConceptId = '{0}'", objvRTConceptRelaEN.conceptId);
        return strWhereCond;
    }
    exports.vRTConceptRela_GetUniCondStr4Update_mId_TopicId_ConceptId = vRTConceptRela_GetUniCondStr4Update_mId_TopicId_ConceptId;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objvRTConceptRelaENS:源对象
     * @param objvRTConceptRelaENT:目标对象
    */
    function vRTConceptRela_CopyObjTo(objvRTConceptRelaENS, objvRTConceptRelaENT) {
        objvRTConceptRelaENT.mId = objvRTConceptRelaENS.mId; //mId
        objvRTConceptRelaENT.topicId = objvRTConceptRelaENS.topicId; //主题Id
        objvRTConceptRelaENT.conceptId = objvRTConceptRelaENS.conceptId; //概念Id
        objvRTConceptRelaENT.updDate = objvRTConceptRelaENS.updDate; //修改日期
        objvRTConceptRelaENT.memo = objvRTConceptRelaENS.memo; //备注
        objvRTConceptRelaENT.topicName = objvRTConceptRelaENS.topicName; //栏目主题
        objvRTConceptRelaENT.topicContent = objvRTConceptRelaENS.topicContent; //主题内容
        objvRTConceptRelaENT.orderNum = objvRTConceptRelaENS.orderNum; //序号
        objvRTConceptRelaENT.topicProposePeople = objvRTConceptRelaENS.topicProposePeople; //主题提出人
        objvRTConceptRelaENT.conceptContent = objvRTConceptRelaENS.conceptContent; //概念内容
        objvRTConceptRelaENT.conceptName = objvRTConceptRelaENS.conceptName; //概念名称
        objvRTConceptRelaENT.appraiseCount = objvRTConceptRelaENS.appraiseCount; //评论数
        objvRTConceptRelaENT.citationCount = objvRTConceptRelaENS.citationCount; //引用统计
        objvRTConceptRelaENT.citationId = objvRTConceptRelaENS.citationId; //引用Id
        objvRTConceptRelaENT.isSubmit = objvRTConceptRelaENS.isSubmit; //是否提交
        objvRTConceptRelaENT.score = objvRTConceptRelaENS.score; //评分
        objvRTConceptRelaENT.stuScore = objvRTConceptRelaENS.stuScore; //学生平均分
        objvRTConceptRelaENT.teaScore = objvRTConceptRelaENS.teaScore; //教师评分
        objvRTConceptRelaENT.concepDate = objvRTConceptRelaENS.concepDate; //ConcepDate
        objvRTConceptRelaENT.concepUserId = objvRTConceptRelaENS.concepUserId; //ConcepUserId
        objvRTConceptRelaENT.id_CurrEduCls = objvRTConceptRelaENS.id_CurrEduCls; //教学班流水号
        objvRTConceptRelaENT.pdfContent = objvRTConceptRelaENS.pdfContent; //Pdf内容
        objvRTConceptRelaENT.pdfPageNum = objvRTConceptRelaENS.pdfPageNum; //Pdf页码
        objvRTConceptRelaENT.okCount = objvRTConceptRelaENS.okCount; //点赞统计
        objvRTConceptRelaENT.versionCount = objvRTConceptRelaENS.versionCount; //版本统计
        objvRTConceptRelaENT.createDate = objvRTConceptRelaENS.createDate; //建立日期
        objvRTConceptRelaENT.shareId = objvRTConceptRelaENS.shareId; //分享Id
        objvRTConceptRelaENT.updUser = objvRTConceptRelaENS.updUser; //修改人
        objvRTConceptRelaENT.classificationId = objvRTConceptRelaENS.classificationId; //分类Id
    }
    exports.vRTConceptRela_CopyObjTo = vRTConceptRela_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objvRTConceptRelaENS:源对象
     * @param objvRTConceptRelaENT:目标对象
    */
    function vRTConceptRela_GetObjFromJsonObj(objvRTConceptRelaENS) {
        const objvRTConceptRelaENT = new clsvRTConceptRelaEN_js_1.clsvRTConceptRelaEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvRTConceptRelaENT, objvRTConceptRelaENS);
        return objvRTConceptRelaENT;
    }
    exports.vRTConceptRela_GetObjFromJsonObj = vRTConceptRela_GetObjFromJsonObj;
});
