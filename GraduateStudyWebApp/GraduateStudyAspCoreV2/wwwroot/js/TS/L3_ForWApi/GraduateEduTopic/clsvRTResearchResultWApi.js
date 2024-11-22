/**
* 类名:clsvRTResearchResultWApi
* 表名:vRTResearchResult(01120621)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/13 00:46:24
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
        define(["require", "exports", "axios", "../../PubFun/enumComparisonOp.js", "../../PubFun/CacheHelper.js", "../../L0_Entity/GraduateEduTopic/clsvRTResearchResultEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.vRTResearchResult_GetObjFromJsonObj = exports.vRTResearchResult_CopyObjTo = exports.vRTResearchResult_GetCombineCondition = exports.vRTResearchResult_GetObjByJSONStr = exports.vRTResearchResult_GetObjLstByJSONObjLst = exports.vRTResearchResult_GetObjLstByJSONStr = exports.vRTResearchResult_GetJSONStrByObj = exports.vRTResearchResult_ReFreshThisCache = exports.vRTResearchResult_GetWebApiUrl = exports.vRTResearchResult_GetRecCountByCond_Cache = exports.vRTResearchResult_GetRecCountByCondAsync = exports.vRTResearchResult_IsExistAsync = exports.vRTResearchResult_IsExist_Cache = exports.vRTResearchResult_IsExist = exports.vRTResearchResult_IsExistRecordAsync = exports.vRTResearchResult_IsExistRecord_Cache = exports.vRTResearchResult_GetObjLstByPagerAsync = exports.vRTResearchResult_GetObjLstByPager_Cache = exports.vRTResearchResult_GetObjLstByRange = exports.vRTResearchResult_GetObjLstByRangeAsync = exports.vRTResearchResult_GetTopObjLstAsync = exports.vRTResearchResult_GetObjLstBymIdLst_Cache = exports.vRTResearchResult_GetObjLstBymIdLstAsync = exports.vRTResearchResult_GetSubObjLst_Cache = exports.vRTResearchResult_GetObjLst_PureCache = exports.vRTResearchResult_GetObjLst_Cache = exports.vRTResearchResult_GetObjLst_sessionStorage_PureCache = exports.vRTResearchResult_GetObjLst_sessionStorage = exports.vRTResearchResult_GetObjLstAsync = exports.vRTResearchResult_GetObjLst_localStorage_PureCache = exports.vRTResearchResult_GetObjLst_localStorage = exports.vRTResearchResult_GetObjLst_ClientCache = exports.vRTResearchResult_GetFirstObjAsync = exports.vRTResearchResult_GetFirstID = exports.vRTResearchResult_GetFirstIDAsync = exports.vRTResearchResult_funcKey = exports.vRTResearchResult_FilterFunByKey = exports.vRTResearchResult_SortFunByKey = exports.vRTResearchResult_SortFun_Defa_2Fld = exports.vRTResearchResult_SortFun_Defa = exports.vRTResearchResult_func = exports.vRTResearchResult_GetObjBymId_localStorage = exports.vRTResearchResult_GetObjBymId_Cache = exports.vRTResearchResult_GetObjBymIdAsync = exports.vRTResearchResult_ConstructorName = exports.vRTResearchResult_Controller = void 0;
    /**
     * 主题研究结果关系(vRTResearchResult)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月13日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const enumComparisonOp_js_1 = require("../../PubFun/enumComparisonOp.js");
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsvRTResearchResultEN_js_1 = require("../../L0_Entity/GraduateEduTopic/clsvRTResearchResultEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.vRTResearchResult_Controller = "vRTResearchResultApi";
    exports.vRTResearchResult_ConstructorName = "vRTResearchResult";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param lngmId:关键字
    * @returns 对象
    **/
    async function vRTResearchResult_GetObjBymIdAsync(lngmId) {
        const strThisFuncName = "GetObjBymIdAsync";
        if (lngmId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngmId]不能为空！(In clsvRTResearchResultWApi.GetObjBymIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjBymId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vRTResearchResult_Controller, strAction);
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
                const objvRTResearchResult = vRTResearchResult_GetObjFromJsonObj(returnObj);
                return objvRTResearchResult;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vRTResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vRTResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vRTResearchResult_GetObjBymIdAsync = vRTResearchResult_GetObjBymIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param lngmId:所给的关键字
     * @returns 对象
    */
    async function vRTResearchResult_GetObjBymId_Cache(lngmId, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjBymId_Cache";
        if (lngmId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngmId]不能为空！(In clsvRTResearchResultWApi.GetObjBymId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        const arrvRTResearchResultObjLst_Cache = await vRTResearchResult_GetObjLst_Cache();
        try {
            const arrvRTResearchResult_Sel = arrvRTResearchResultObjLst_Cache.filter(x => x.mId == lngmId);
            let objvRTResearchResult;
            if (arrvRTResearchResult_Sel.length > 0) {
                objvRTResearchResult = arrvRTResearchResult_Sel[0];
                return objvRTResearchResult;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    const objvRTResearchResult_Const = await vRTResearchResult_GetObjBymIdAsync(lngmId);
                    if (objvRTResearchResult_Const != null) {
                        vRTResearchResult_ReFreshThisCache();
                        return objvRTResearchResult_Const;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngmId, exports.vRTResearchResult_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.vRTResearchResult_GetObjBymId_Cache = vRTResearchResult_GetObjBymId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param lngmId:所给的关键字
     * @returns 对象
    */
    async function vRTResearchResult_GetObjBymId_localStorage(lngmId) {
        const strThisFuncName = "GetObjBymId_localStorage";
        if (lngmId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngmId]不能为空！(In clsvRTResearchResultWApi.GetObjBymId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvRTResearchResultEN_js_1.clsvRTResearchResultEN._CurrTabName, lngmId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objvRTResearchResult_Cache = JSON.parse(strTempObj);
            return objvRTResearchResult_Cache;
        }
        try {
            const objvRTResearchResult = await vRTResearchResult_GetObjBymIdAsync(lngmId);
            if (objvRTResearchResult != null) {
                localStorage.setItem(strKey, JSON.stringify(objvRTResearchResult));
                const strInfo = (0, clsString_js_1.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objvRTResearchResult;
            }
            return objvRTResearchResult;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngmId, exports.vRTResearchResult_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.vRTResearchResult_GetObjBymId_localStorage = vRTResearchResult_GetObjBymId_localStorage;
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
    async function vRTResearchResult_func(strInFldName, strOutFldName, strInValue) {
        //const strThisFuncName = "func";
        if (strInFldName != clsvRTResearchResultEN_js_1.clsvRTResearchResultEN.con_mId) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsvRTResearchResultEN_js_1.clsvRTResearchResultEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_1.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strOutFldName, clsvRTResearchResultEN_js_1.clsvRTResearchResultEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const lngmId = Number(strInValue);
        if (lngmId == 0) {
            return "";
        }
        const objvRTResearchResult = await vRTResearchResult_GetObjBymId_Cache(lngmId);
        if (objvRTResearchResult == null)
            return "";
        if (objvRTResearchResult.GetFldValue(strOutFldName) == null)
            return "";
        return objvRTResearchResult.GetFldValue(strOutFldName).toString();
    }
    exports.vRTResearchResult_func = vRTResearchResult_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vRTResearchResult_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.mId - b.mId;
    }
    exports.vRTResearchResult_SortFun_Defa = vRTResearchResult_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vRTResearchResult_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.topicId == b.topicId)
            return a.paperId.localeCompare(b.paperId);
        else
            return a.topicId.localeCompare(b.topicId);
    }
    exports.vRTResearchResult_SortFun_Defa_2Fld = vRTResearchResult_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vRTResearchResult_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsvRTResearchResultEN_js_1.clsvRTResearchResultEN.con_TopicId:
                    return (a, b) => {
                        if (a.topicId == null)
                            return -1;
                        if (b.topicId == null)
                            return 1;
                        return a.topicId.localeCompare(b.topicId);
                    };
                case clsvRTResearchResultEN_js_1.clsvRTResearchResultEN.con_PaperId:
                    return (a, b) => {
                        if (a.paperId == null)
                            return -1;
                        if (b.paperId == null)
                            return 1;
                        return a.paperId.localeCompare(b.paperId);
                    };
                case clsvRTResearchResultEN_js_1.clsvRTResearchResultEN.con_UpdDate:
                    return (a, b) => {
                        if (a.updDate == null)
                            return -1;
                        if (b.updDate == null)
                            return 1;
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsvRTResearchResultEN_js_1.clsvRTResearchResultEN.con_UpdUser:
                    return (a, b) => {
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsvRTResearchResultEN_js_1.clsvRTResearchResultEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                case clsvRTResearchResultEN_js_1.clsvRTResearchResultEN.con_mId:
                    return (a, b) => {
                        return a.mId - b.mId;
                    };
                case clsvRTResearchResultEN_js_1.clsvRTResearchResultEN.con_UserName:
                    return (a, b) => {
                        if (a.userName == null)
                            return -1;
                        if (b.userName == null)
                            return 1;
                        return a.userName.localeCompare(b.userName);
                    };
                case clsvRTResearchResultEN_js_1.clsvRTResearchResultEN.con_PaperTitle:
                    return (a, b) => {
                        if (a.paperTitle == null)
                            return -1;
                        if (b.paperTitle == null)
                            return 1;
                        return a.paperTitle.localeCompare(b.paperTitle);
                    };
                case clsvRTResearchResultEN_js_1.clsvRTResearchResultEN.con_PaperContent:
                    return (a, b) => {
                        if (a.paperContent == null)
                            return -1;
                        if (b.paperContent == null)
                            return 1;
                        return a.paperContent.localeCompare(b.paperContent);
                    };
                case clsvRTResearchResultEN_js_1.clsvRTResearchResultEN.con_TopicName:
                    return (a, b) => {
                        if (a.topicName == null)
                            return -1;
                        if (b.topicName == null)
                            return 1;
                        return a.topicName.localeCompare(b.topicName);
                    };
                case clsvRTResearchResultEN_js_1.clsvRTResearchResultEN.con_TopicContent:
                    return (a, b) => {
                        if (a.topicContent == null)
                            return -1;
                        if (b.topicContent == null)
                            return 1;
                        return a.topicContent.localeCompare(b.topicContent);
                    };
                case clsvRTResearchResultEN_js_1.clsvRTResearchResultEN.con_TopicProposePeople:
                    return (a, b) => {
                        if (a.topicProposePeople == null)
                            return -1;
                        if (b.topicProposePeople == null)
                            return 1;
                        return a.topicProposePeople.localeCompare(b.topicProposePeople);
                    };
                case clsvRTResearchResultEN_js_1.clsvRTResearchResultEN.con_Periodical:
                    return (a, b) => {
                        if (a.periodical == null)
                            return -1;
                        if (b.periodical == null)
                            return 1;
                        return a.periodical.localeCompare(b.periodical);
                    };
                case clsvRTResearchResultEN_js_1.clsvRTResearchResultEN.con_Author:
                    return (a, b) => {
                        if (a.author == null)
                            return -1;
                        if (b.author == null)
                            return 1;
                        return a.author.localeCompare(b.author);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vRTResearchResult]中不存在！(in ${exports.vRTResearchResult_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsvRTResearchResultEN_js_1.clsvRTResearchResultEN.con_TopicId:
                    return (a, b) => {
                        if (b.topicId == null)
                            return -1;
                        if (a.topicId == null)
                            return 1;
                        return b.topicId.localeCompare(a.topicId);
                    };
                case clsvRTResearchResultEN_js_1.clsvRTResearchResultEN.con_PaperId:
                    return (a, b) => {
                        if (b.paperId == null)
                            return -1;
                        if (a.paperId == null)
                            return 1;
                        return b.paperId.localeCompare(a.paperId);
                    };
                case clsvRTResearchResultEN_js_1.clsvRTResearchResultEN.con_UpdDate:
                    return (a, b) => {
                        if (b.updDate == null)
                            return -1;
                        if (a.updDate == null)
                            return 1;
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsvRTResearchResultEN_js_1.clsvRTResearchResultEN.con_UpdUser:
                    return (a, b) => {
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsvRTResearchResultEN_js_1.clsvRTResearchResultEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                case clsvRTResearchResultEN_js_1.clsvRTResearchResultEN.con_mId:
                    return (a, b) => {
                        return b.mId - a.mId;
                    };
                case clsvRTResearchResultEN_js_1.clsvRTResearchResultEN.con_UserName:
                    return (a, b) => {
                        if (b.userName == null)
                            return -1;
                        if (a.userName == null)
                            return 1;
                        return b.userName.localeCompare(a.userName);
                    };
                case clsvRTResearchResultEN_js_1.clsvRTResearchResultEN.con_PaperTitle:
                    return (a, b) => {
                        if (b.paperTitle == null)
                            return -1;
                        if (a.paperTitle == null)
                            return 1;
                        return b.paperTitle.localeCompare(a.paperTitle);
                    };
                case clsvRTResearchResultEN_js_1.clsvRTResearchResultEN.con_PaperContent:
                    return (a, b) => {
                        if (b.paperContent == null)
                            return -1;
                        if (a.paperContent == null)
                            return 1;
                        return b.paperContent.localeCompare(a.paperContent);
                    };
                case clsvRTResearchResultEN_js_1.clsvRTResearchResultEN.con_TopicName:
                    return (a, b) => {
                        if (b.topicName == null)
                            return -1;
                        if (a.topicName == null)
                            return 1;
                        return b.topicName.localeCompare(a.topicName);
                    };
                case clsvRTResearchResultEN_js_1.clsvRTResearchResultEN.con_TopicContent:
                    return (a, b) => {
                        if (b.topicContent == null)
                            return -1;
                        if (a.topicContent == null)
                            return 1;
                        return b.topicContent.localeCompare(a.topicContent);
                    };
                case clsvRTResearchResultEN_js_1.clsvRTResearchResultEN.con_TopicProposePeople:
                    return (a, b) => {
                        if (b.topicProposePeople == null)
                            return -1;
                        if (a.topicProposePeople == null)
                            return 1;
                        return b.topicProposePeople.localeCompare(a.topicProposePeople);
                    };
                case clsvRTResearchResultEN_js_1.clsvRTResearchResultEN.con_Periodical:
                    return (a, b) => {
                        if (b.periodical == null)
                            return -1;
                        if (a.periodical == null)
                            return 1;
                        return b.periodical.localeCompare(a.periodical);
                    };
                case clsvRTResearchResultEN_js_1.clsvRTResearchResultEN.con_Author:
                    return (a, b) => {
                        if (b.author == null)
                            return -1;
                        if (a.author == null)
                            return 1;
                        return b.author.localeCompare(a.author);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vRTResearchResult]中不存在！(in ${exports.vRTResearchResult_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.vRTResearchResult_SortFunByKey = vRTResearchResult_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function vRTResearchResult_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsvRTResearchResultEN_js_1.clsvRTResearchResultEN.con_TopicId:
                return (obj) => {
                    return obj.topicId === value;
                };
            case clsvRTResearchResultEN_js_1.clsvRTResearchResultEN.con_PaperId:
                return (obj) => {
                    return obj.paperId === value;
                };
            case clsvRTResearchResultEN_js_1.clsvRTResearchResultEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsvRTResearchResultEN_js_1.clsvRTResearchResultEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsvRTResearchResultEN_js_1.clsvRTResearchResultEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            case clsvRTResearchResultEN_js_1.clsvRTResearchResultEN.con_mId:
                return (obj) => {
                    return obj.mId === value;
                };
            case clsvRTResearchResultEN_js_1.clsvRTResearchResultEN.con_UserName:
                return (obj) => {
                    return obj.userName === value;
                };
            case clsvRTResearchResultEN_js_1.clsvRTResearchResultEN.con_PaperTitle:
                return (obj) => {
                    return obj.paperTitle === value;
                };
            case clsvRTResearchResultEN_js_1.clsvRTResearchResultEN.con_PaperContent:
                return (obj) => {
                    return obj.paperContent === value;
                };
            case clsvRTResearchResultEN_js_1.clsvRTResearchResultEN.con_TopicName:
                return (obj) => {
                    return obj.topicName === value;
                };
            case clsvRTResearchResultEN_js_1.clsvRTResearchResultEN.con_TopicContent:
                return (obj) => {
                    return obj.topicContent === value;
                };
            case clsvRTResearchResultEN_js_1.clsvRTResearchResultEN.con_TopicProposePeople:
                return (obj) => {
                    return obj.topicProposePeople === value;
                };
            case clsvRTResearchResultEN_js_1.clsvRTResearchResultEN.con_Periodical:
                return (obj) => {
                    return obj.periodical === value;
                };
            case clsvRTResearchResultEN_js_1.clsvRTResearchResultEN.con_Author:
                return (obj) => {
                    return obj.author === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[vRTResearchResult]中不存在！(in ${exports.vRTResearchResult_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.vRTResearchResult_FilterFunByKey = vRTResearchResult_FilterFunByKey;
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
    async function vRTResearchResult_funcKey(strInFldName, strInValue, strComparisonOp) {
        //const strThisFuncName = "funcKey";
        if (strInFldName == clsvRTResearchResultEN_js_1.clsvRTResearchResultEN.con_mId) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (Number(strInValue) == 0) {
            return [];
        }
        const arrvRTResearchResult = await vRTResearchResult_GetObjLst_Cache();
        if (arrvRTResearchResult == null)
            return [];
        let arrvRTResearchResult_Sel = arrvRTResearchResult;
        const strType = typeof (strInValue);
        switch (strType) {
            case "string":
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01: // " = "
                        arrvRTResearchResult_Sel = arrvRTResearchResult_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.Like_03:
                        arrvRTResearchResult_Sel = arrvRTResearchResult_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.In_04:
                        const arrValues = strInValue.split(',');
                        arrvRTResearchResult_Sel = arrvRTResearchResult_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
                        break;
                }
                break;
            case "boolean":
                if (strInValue == null)
                    return [];
                if (strComparisonOp == enumComparisonOp_js_1.enumComparisonOp.Equal_01) {
                    arrvRTResearchResult_Sel = arrvRTResearchResult_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                }
                break;
            case "number":
                if (Number(strInValue) == 0)
                    return [];
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01:
                        arrvRTResearchResult_Sel = arrvRTResearchResult_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotEqual_02:
                        arrvRTResearchResult_Sel = arrvRTResearchResult_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotLessThan_05: //" >= ":
                        arrvRTResearchResult_Sel = arrvRTResearchResult_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotGreaterThan_06: //" <= ":
                        arrvRTResearchResult_Sel = arrvRTResearchResult_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.GreaterThan_07: //" > ":
                        arrvRTResearchResult_Sel = arrvRTResearchResult_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.LessThan_08: //" < ":
                        arrvRTResearchResult_Sel = arrvRTResearchResult_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                }
                break;
        }
        if (arrvRTResearchResult_Sel.length == 0)
            return [];
        return arrvRTResearchResult_Sel.map(x => x.mId);
    }
    exports.vRTResearchResult_funcKey = vRTResearchResult_funcKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function vRTResearchResult_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vRTResearchResult_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vRTResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vRTResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vRTResearchResult_GetFirstIDAsync = vRTResearchResult_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function vRTResearchResult_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vRTResearchResult_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vRTResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vRTResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vRTResearchResult_GetFirstID = vRTResearchResult_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function vRTResearchResult_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vRTResearchResult_Controller, strAction);
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
                const objvRTResearchResult = vRTResearchResult_GetObjFromJsonObj(returnObj);
                return objvRTResearchResult;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vRTResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vRTResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vRTResearchResult_GetFirstObjAsync = vRTResearchResult_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vRTResearchResult_GetObjLst_ClientCache() {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsvRTResearchResultEN_js_1.clsvRTResearchResultEN._CurrTabName;
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvRTResearchResultEN_js_1.clsvRTResearchResultEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvRTResearchResultEN_js_1.clsvRTResearchResultEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_1.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrvRTResearchResultExObjLst_Cache = CacheHelper_js_1.CacheHelper.Get(strKey);
            const arrvRTResearchResultObjLst_T = vRTResearchResult_GetObjLstByJSONObjLst(arrvRTResearchResultExObjLst_Cache);
            return arrvRTResearchResultObjLst_T;
        }
        try {
            const arrvRTResearchResultExObjLst = await vRTResearchResult_GetObjLstAsync(strWhereCond);
            CacheHelper_js_1.CacheHelper.Add(strKey, arrvRTResearchResultExObjLst);
            const strInfo = (0, clsString_js_1.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvRTResearchResultExObjLst.length);
            console.log(strInfo);
            return arrvRTResearchResultExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vRTResearchResult_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vRTResearchResult_GetObjLst_ClientCache = vRTResearchResult_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vRTResearchResult_GetObjLst_localStorage() {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsvRTResearchResultEN_js_1.clsvRTResearchResultEN._CurrTabName;
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvRTResearchResultEN_js_1.clsvRTResearchResultEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvRTResearchResultEN_js_1.clsvRTResearchResultEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrvRTResearchResultExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrvRTResearchResultObjLst_T = vRTResearchResult_GetObjLstByJSONObjLst(arrvRTResearchResultExObjLst_Cache);
            return arrvRTResearchResultObjLst_T;
        }
        try {
            const arrvRTResearchResultExObjLst = await vRTResearchResult_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrvRTResearchResultExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvRTResearchResultExObjLst.length);
            console.log(strInfo);
            return arrvRTResearchResultExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vRTResearchResult_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vRTResearchResult_GetObjLst_localStorage = vRTResearchResult_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vRTResearchResult_GetObjLst_localStorage_PureCache() {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsvRTResearchResultEN_js_1.clsvRTResearchResultEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrvRTResearchResultObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvRTResearchResultObjLst_Cache;
        }
        else
            return null;
    }
    exports.vRTResearchResult_GetObjLst_localStorage_PureCache = vRTResearchResult_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function vRTResearchResult_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vRTResearchResult_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vRTResearchResult_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vRTResearchResult_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vRTResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vRTResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vRTResearchResult_GetObjLstAsync = vRTResearchResult_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vRTResearchResult_GetObjLst_sessionStorage() {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsvRTResearchResultEN_js_1.clsvRTResearchResultEN._CurrTabName;
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvRTResearchResultEN_js_1.clsvRTResearchResultEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvRTResearchResultEN_js_1.clsvRTResearchResultEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrvRTResearchResultExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrvRTResearchResultObjLst_T = vRTResearchResult_GetObjLstByJSONObjLst(arrvRTResearchResultExObjLst_Cache);
            return arrvRTResearchResultObjLst_T;
        }
        try {
            const arrvRTResearchResultExObjLst = await vRTResearchResult_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrvRTResearchResultExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvRTResearchResultExObjLst.length);
            console.log(strInfo);
            return arrvRTResearchResultExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vRTResearchResult_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vRTResearchResult_GetObjLst_sessionStorage = vRTResearchResult_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vRTResearchResult_GetObjLst_sessionStorage_PureCache() {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsvRTResearchResultEN_js_1.clsvRTResearchResultEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrvRTResearchResultObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvRTResearchResultObjLst_Cache;
        }
        else
            return null;
    }
    exports.vRTResearchResult_GetObjLst_sessionStorage_PureCache = vRTResearchResult_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vRTResearchResult_GetObjLst_Cache() {
        //const strThisFuncName = "GetObjLst_Cache";
        let arrvRTResearchResultObjLst_Cache;
        switch (clsvRTResearchResultEN_js_1.clsvRTResearchResultEN.CacheModeId) {
            case "04": //sessionStorage
                arrvRTResearchResultObjLst_Cache = await vRTResearchResult_GetObjLst_sessionStorage();
                break;
            case "03": //localStorage
                arrvRTResearchResultObjLst_Cache = await vRTResearchResult_GetObjLst_localStorage();
                break;
            case "02": //ClientCache
                arrvRTResearchResultObjLst_Cache = await vRTResearchResult_GetObjLst_ClientCache();
                break;
            default:
                arrvRTResearchResultObjLst_Cache = await vRTResearchResult_GetObjLst_ClientCache();
                break;
        }
        const arrvRTResearchResultObjLst = vRTResearchResult_GetObjLstByJSONObjLst(arrvRTResearchResultObjLst_Cache);
        return arrvRTResearchResultObjLst_Cache;
    }
    exports.vRTResearchResult_GetObjLst_Cache = vRTResearchResult_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vRTResearchResult_GetObjLst_PureCache() {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrvRTResearchResultObjLst_Cache;
        switch (clsvRTResearchResultEN_js_1.clsvRTResearchResultEN.CacheModeId) {
            case "04": //sessionStorage
                arrvRTResearchResultObjLst_Cache = await vRTResearchResult_GetObjLst_sessionStorage_PureCache();
                break;
            case "03": //localStorage
                arrvRTResearchResultObjLst_Cache = await vRTResearchResult_GetObjLst_localStorage_PureCache();
                break;
            case "02": //ClientCache
                arrvRTResearchResultObjLst_Cache = null;
                break;
            default:
                arrvRTResearchResultObjLst_Cache = null;
                break;
        }
        return arrvRTResearchResultObjLst_Cache;
    }
    exports.vRTResearchResult_GetObjLst_PureCache = vRTResearchResult_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objlngmId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function vRTResearchResult_GetSubObjLst_Cache(objvRTResearchResult_Cond) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrvRTResearchResultObjLst_Cache = await vRTResearchResult_GetObjLst_Cache();
        let arrvRTResearchResult_Sel = arrvRTResearchResultObjLst_Cache;
        if (objvRTResearchResult_Cond.sf_FldComparisonOp == null || objvRTResearchResult_Cond.sf_FldComparisonOp == "")
            return arrvRTResearchResult_Sel;
        const dicFldComparisonOp = JSON.parse(objvRTResearchResult_Cond.sf_FldComparisonOp);
        //console.log("clsvRTResearchResultWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvRTResearchResult_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvRTResearchResult_Sel = arrvRTResearchResult_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvRTResearchResult_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvRTResearchResult_Sel = arrvRTResearchResult_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvRTResearchResult_Sel = arrvRTResearchResult_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvRTResearchResult_Sel = arrvRTResearchResult_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvRTResearchResult_Sel = arrvRTResearchResult_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvRTResearchResult_Sel = arrvRTResearchResult_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvRTResearchResult_Sel = arrvRTResearchResult_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvRTResearchResult_Sel = arrvRTResearchResult_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvRTResearchResult_Sel = arrvRTResearchResult_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvRTResearchResult_Sel = arrvRTResearchResult_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvRTResearchResult_Sel = arrvRTResearchResult_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvRTResearchResult_Sel = arrvRTResearchResult_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvRTResearchResult_Sel = arrvRTResearchResult_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvRTResearchResult_Sel = arrvRTResearchResult_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrvRTResearchResult_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objvRTResearchResult_Cond), exports.vRTResearchResult_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vRTResearchResult_GetSubObjLst_Cache = vRTResearchResult_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrmId:关键字列表
    * @returns 对象列表
    **/
    async function vRTResearchResult_GetObjLstBymIdLstAsync(arrmId) {
        const strThisFuncName = "GetObjLstBymIdLstAsync";
        const strAction = "GetObjLstBymIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vRTResearchResult_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrmId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vRTResearchResult_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vRTResearchResult_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vRTResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vRTResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vRTResearchResult_GetObjLstBymIdLstAsync = vRTResearchResult_GetObjLstBymIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrlngmIdLst:关键字列表
     * @returns 对象列表
    */
    async function vRTResearchResult_GetObjLstBymIdLst_Cache(arrmIdLst) {
        const strThisFuncName = "GetObjLstBymIdLst_Cache";
        try {
            const arrvRTResearchResultObjLst_Cache = await vRTResearchResult_GetObjLst_Cache();
            const arrvRTResearchResult_Sel = arrvRTResearchResultObjLst_Cache.filter(x => arrmIdLst.indexOf(x.mId) > -1);
            return arrvRTResearchResult_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrmIdLst.join(","), exports.vRTResearchResult_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
    }
    exports.vRTResearchResult_GetObjLstBymIdLst_Cache = vRTResearchResult_GetObjLstBymIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function vRTResearchResult_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vRTResearchResult_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vRTResearchResult_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vRTResearchResult_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vRTResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vRTResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vRTResearchResult_GetTopObjLstAsync = vRTResearchResult_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vRTResearchResult_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vRTResearchResult_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vRTResearchResult_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vRTResearchResult_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vRTResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vRTResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vRTResearchResult_GetObjLstByRangeAsync = vRTResearchResult_GetObjLstByRangeAsync;
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
    async function vRTResearchResult_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vRTResearchResult_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vRTResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vRTResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vRTResearchResult_GetObjLstByRange = vRTResearchResult_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function vRTResearchResult_GetObjLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const arrvRTResearchResultObjLst_Cache = await vRTResearchResult_GetObjLst_Cache();
        if (arrvRTResearchResultObjLst_Cache.length == 0)
            return arrvRTResearchResultObjLst_Cache;
        let arrvRTResearchResult_Sel = arrvRTResearchResultObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objvRTResearchResult_Cond = new clsvRTResearchResultEN_js_1.clsvRTResearchResultEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvRTResearchResult_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsvRTResearchResultWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvRTResearchResult_Sel = arrvRTResearchResult_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvRTResearchResult_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvRTResearchResult_Sel = arrvRTResearchResult_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvRTResearchResult_Sel = arrvRTResearchResult_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvRTResearchResult_Sel = arrvRTResearchResult_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvRTResearchResult_Sel = arrvRTResearchResult_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvRTResearchResult_Sel = arrvRTResearchResult_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvRTResearchResult_Sel = arrvRTResearchResult_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvRTResearchResult_Sel = arrvRTResearchResult_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrvRTResearchResult_Sel = arrvRTResearchResult_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvRTResearchResult_Sel = arrvRTResearchResult_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvRTResearchResult_Sel = arrvRTResearchResult_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvRTResearchResult_Sel = arrvRTResearchResult_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvRTResearchResult_Sel = arrvRTResearchResult_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvRTResearchResult_Sel = arrvRTResearchResult_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvRTResearchResult_Sel = arrvRTResearchResult_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvRTResearchResult_Sel.length == 0)
                return arrvRTResearchResult_Sel;
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
                arrvRTResearchResult_Sel = arrvRTResearchResult_Sel.sort(vRTResearchResult_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrvRTResearchResult_Sel = arrvRTResearchResult_Sel.sort(objPagerPara.sortFun);
            }
            arrvRTResearchResult_Sel = arrvRTResearchResult_Sel.slice(intStart, intEnd);
            return arrvRTResearchResult_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.vRTResearchResult_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vRTResearchResult_GetObjLstByPager_Cache = vRTResearchResult_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vRTResearchResult_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vRTResearchResult_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vRTResearchResult_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vRTResearchResult_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vRTResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vRTResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vRTResearchResult_GetObjLstByPagerAsync = vRTResearchResult_GetObjLstByPagerAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objlngmId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function vRTResearchResult_IsExistRecord_Cache(objvRTResearchResult_Cond) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrvRTResearchResultObjLst_Cache = await vRTResearchResult_GetObjLst_Cache();
        if (arrvRTResearchResultObjLst_Cache == null)
            return false;
        let arrvRTResearchResult_Sel = arrvRTResearchResultObjLst_Cache;
        if (objvRTResearchResult_Cond.sf_FldComparisonOp == null || objvRTResearchResult_Cond.sf_FldComparisonOp == "")
            return arrvRTResearchResult_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objvRTResearchResult_Cond.sf_FldComparisonOp);
        //console.log("clsvRTResearchResultWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvRTResearchResult_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvRTResearchResult_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvRTResearchResult_Sel = arrvRTResearchResult_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvRTResearchResult_Sel = arrvRTResearchResult_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvRTResearchResult_Sel = arrvRTResearchResult_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvRTResearchResult_Sel = arrvRTResearchResult_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvRTResearchResult_Sel = arrvRTResearchResult_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvRTResearchResult_Sel = arrvRTResearchResult_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvRTResearchResult_Sel = arrvRTResearchResult_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvRTResearchResult_Sel = arrvRTResearchResult_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvRTResearchResult_Sel = arrvRTResearchResult_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvRTResearchResult_Sel = arrvRTResearchResult_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvRTResearchResult_Sel = arrvRTResearchResult_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvRTResearchResult_Sel = arrvRTResearchResult_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvRTResearchResult_Sel = arrvRTResearchResult_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvRTResearchResult_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objvRTResearchResult_Cond), exports.vRTResearchResult_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.vRTResearchResult_IsExistRecord_Cache = vRTResearchResult_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function vRTResearchResult_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vRTResearchResult_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vRTResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vRTResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vRTResearchResult_IsExistRecordAsync = vRTResearchResult_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param lngmId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function vRTResearchResult_IsExist(lngmId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vRTResearchResult_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vRTResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vRTResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vRTResearchResult_IsExist = vRTResearchResult_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param lngmId:所给的关键字
     * @returns 对象
    */
    async function vRTResearchResult_IsExist_Cache(lngmId) {
        const strThisFuncName = "IsExist_Cache";
        const arrvRTResearchResultObjLst_Cache = await vRTResearchResult_GetObjLst_Cache();
        if (arrvRTResearchResultObjLst_Cache == null)
            return false;
        try {
            const arrvRTResearchResult_Sel = arrvRTResearchResultObjLst_Cache.filter(x => x.mId == lngmId);
            if (arrvRTResearchResult_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", lngmId, exports.vRTResearchResult_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.vRTResearchResult_IsExist_Cache = vRTResearchResult_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param lngmId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function vRTResearchResult_IsExistAsync(lngmId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vRTResearchResult_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vRTResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vRTResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vRTResearchResult_IsExistAsync = vRTResearchResult_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function vRTResearchResult_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vRTResearchResult_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vRTResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vRTResearchResult_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vRTResearchResult_GetRecCountByCondAsync = vRTResearchResult_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objvRTResearchResult_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function vRTResearchResult_GetRecCountByCond_Cache(objvRTResearchResult_Cond) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrvRTResearchResultObjLst_Cache = await vRTResearchResult_GetObjLst_Cache();
        if (arrvRTResearchResultObjLst_Cache == null)
            return 0;
        let arrvRTResearchResult_Sel = arrvRTResearchResultObjLst_Cache;
        if (objvRTResearchResult_Cond.sf_FldComparisonOp == null || objvRTResearchResult_Cond.sf_FldComparisonOp == "")
            return arrvRTResearchResult_Sel.length;
        const dicFldComparisonOp = JSON.parse(objvRTResearchResult_Cond.sf_FldComparisonOp);
        //console.log("clsvRTResearchResultWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvRTResearchResult_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvRTResearchResult_Sel = arrvRTResearchResult_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvRTResearchResult_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvRTResearchResult_Sel = arrvRTResearchResult_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvRTResearchResult_Sel = arrvRTResearchResult_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvRTResearchResult_Sel = arrvRTResearchResult_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvRTResearchResult_Sel = arrvRTResearchResult_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvRTResearchResult_Sel = arrvRTResearchResult_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvRTResearchResult_Sel = arrvRTResearchResult_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvRTResearchResult_Sel = arrvRTResearchResult_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrvRTResearchResult_Sel = arrvRTResearchResult_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvRTResearchResult_Sel = arrvRTResearchResult_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvRTResearchResult_Sel = arrvRTResearchResult_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvRTResearchResult_Sel = arrvRTResearchResult_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvRTResearchResult_Sel = arrvRTResearchResult_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvRTResearchResult_Sel = arrvRTResearchResult_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvRTResearchResult_Sel = arrvRTResearchResult_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrvRTResearchResult_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objvRTResearchResult_Cond), exports.vRTResearchResult_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.vRTResearchResult_GetRecCountByCond_Cache = vRTResearchResult_GetRecCountByCond_Cache;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function vRTResearchResult_GetWebApiUrl(strController, strAction) {
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
    exports.vRTResearchResult_GetWebApiUrl = vRTResearchResult_GetWebApiUrl;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function vRTResearchResult_ReFreshThisCache() {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = clsvRTResearchResultEN_js_1.clsvRTResearchResultEN._CurrTabName;
            switch (clsvRTResearchResultEN_js_1.clsvRTResearchResultEN.CacheModeId) {
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
    exports.vRTResearchResult_ReFreshThisCache = vRTResearchResult_ReFreshThisCache;
    /* 该表的下拉框功能没有设置，不需要生成下拉框绑定函数。*/
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vRTResearchResult_GetJSONStrByObj(pobjvRTResearchResultEN) {
        const strThisFuncName = "GetJSONStrByObj";
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjvRTResearchResultEN);
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
    exports.vRTResearchResult_GetJSONStrByObj = vRTResearchResult_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function vRTResearchResult_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrvRTResearchResultObjLst = new Array();
        if (strJSON === "") {
            return arrvRTResearchResultObjLst;
        }
        try {
            arrvRTResearchResultObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrvRTResearchResultObjLst;
        }
        return arrvRTResearchResultObjLst;
    }
    exports.vRTResearchResult_GetObjLstByJSONStr = vRTResearchResult_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrvRTResearchResultObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function vRTResearchResult_GetObjLstByJSONObjLst(arrvRTResearchResultObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrvRTResearchResultObjLst = new Array();
        for (const objInFor of arrvRTResearchResultObjLstS) {
            const obj1 = vRTResearchResult_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrvRTResearchResultObjLst.push(obj1);
        }
        return arrvRTResearchResultObjLst;
    }
    exports.vRTResearchResult_GetObjLstByJSONObjLst = vRTResearchResult_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vRTResearchResult_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjvRTResearchResultEN = new clsvRTResearchResultEN_js_1.clsvRTResearchResultEN();
        if (strJSON === "") {
            return pobjvRTResearchResultEN;
        }
        try {
            pobjvRTResearchResultEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjvRTResearchResultEN;
        }
        return pobjvRTResearchResultEN;
    }
    exports.vRTResearchResult_GetObjByJSONStr = vRTResearchResult_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function vRTResearchResult_GetCombineCondition(objvRTResearchResult_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objvRTResearchResult_Cond.dicFldComparisonOp, clsvRTResearchResultEN_js_1.clsvRTResearchResultEN.con_TopicId) == true) {
            const strComparisonOp_TopicId = objvRTResearchResult_Cond.dicFldComparisonOp[clsvRTResearchResultEN_js_1.clsvRTResearchResultEN.con_TopicId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTResearchResultEN_js_1.clsvRTResearchResultEN.con_TopicId, objvRTResearchResult_Cond.topicId, strComparisonOp_TopicId);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTResearchResult_Cond.dicFldComparisonOp, clsvRTResearchResultEN_js_1.clsvRTResearchResultEN.con_PaperId) == true) {
            const strComparisonOp_PaperId = objvRTResearchResult_Cond.dicFldComparisonOp[clsvRTResearchResultEN_js_1.clsvRTResearchResultEN.con_PaperId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTResearchResultEN_js_1.clsvRTResearchResultEN.con_PaperId, objvRTResearchResult_Cond.paperId, strComparisonOp_PaperId);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTResearchResult_Cond.dicFldComparisonOp, clsvRTResearchResultEN_js_1.clsvRTResearchResultEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objvRTResearchResult_Cond.dicFldComparisonOp[clsvRTResearchResultEN_js_1.clsvRTResearchResultEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTResearchResultEN_js_1.clsvRTResearchResultEN.con_UpdDate, objvRTResearchResult_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTResearchResult_Cond.dicFldComparisonOp, clsvRTResearchResultEN_js_1.clsvRTResearchResultEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objvRTResearchResult_Cond.dicFldComparisonOp[clsvRTResearchResultEN_js_1.clsvRTResearchResultEN.con_UpdUser];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTResearchResultEN_js_1.clsvRTResearchResultEN.con_UpdUser, objvRTResearchResult_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTResearchResult_Cond.dicFldComparisonOp, clsvRTResearchResultEN_js_1.clsvRTResearchResultEN.con_Memo) == true) {
            const strComparisonOp_Memo = objvRTResearchResult_Cond.dicFldComparisonOp[clsvRTResearchResultEN_js_1.clsvRTResearchResultEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTResearchResultEN_js_1.clsvRTResearchResultEN.con_Memo, objvRTResearchResult_Cond.memo, strComparisonOp_Memo);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTResearchResult_Cond.dicFldComparisonOp, clsvRTResearchResultEN_js_1.clsvRTResearchResultEN.con_mId) == true) {
            const strComparisonOp_mId = objvRTResearchResult_Cond.dicFldComparisonOp[clsvRTResearchResultEN_js_1.clsvRTResearchResultEN.con_mId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvRTResearchResultEN_js_1.clsvRTResearchResultEN.con_mId, objvRTResearchResult_Cond.mId, strComparisonOp_mId);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTResearchResult_Cond.dicFldComparisonOp, clsvRTResearchResultEN_js_1.clsvRTResearchResultEN.con_UserName) == true) {
            const strComparisonOp_UserName = objvRTResearchResult_Cond.dicFldComparisonOp[clsvRTResearchResultEN_js_1.clsvRTResearchResultEN.con_UserName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTResearchResultEN_js_1.clsvRTResearchResultEN.con_UserName, objvRTResearchResult_Cond.userName, strComparisonOp_UserName);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTResearchResult_Cond.dicFldComparisonOp, clsvRTResearchResultEN_js_1.clsvRTResearchResultEN.con_PaperTitle) == true) {
            const strComparisonOp_PaperTitle = objvRTResearchResult_Cond.dicFldComparisonOp[clsvRTResearchResultEN_js_1.clsvRTResearchResultEN.con_PaperTitle];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTResearchResultEN_js_1.clsvRTResearchResultEN.con_PaperTitle, objvRTResearchResult_Cond.paperTitle, strComparisonOp_PaperTitle);
        }
        //数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
        if (Object.prototype.hasOwnProperty.call(objvRTResearchResult_Cond.dicFldComparisonOp, clsvRTResearchResultEN_js_1.clsvRTResearchResultEN.con_TopicName) == true) {
            const strComparisonOp_TopicName = objvRTResearchResult_Cond.dicFldComparisonOp[clsvRTResearchResultEN_js_1.clsvRTResearchResultEN.con_TopicName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTResearchResultEN_js_1.clsvRTResearchResultEN.con_TopicName, objvRTResearchResult_Cond.topicName, strComparisonOp_TopicName);
        }
        //数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
        if (Object.prototype.hasOwnProperty.call(objvRTResearchResult_Cond.dicFldComparisonOp, clsvRTResearchResultEN_js_1.clsvRTResearchResultEN.con_TopicProposePeople) == true) {
            const strComparisonOp_TopicProposePeople = objvRTResearchResult_Cond.dicFldComparisonOp[clsvRTResearchResultEN_js_1.clsvRTResearchResultEN.con_TopicProposePeople];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTResearchResultEN_js_1.clsvRTResearchResultEN.con_TopicProposePeople, objvRTResearchResult_Cond.topicProposePeople, strComparisonOp_TopicProposePeople);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTResearchResult_Cond.dicFldComparisonOp, clsvRTResearchResultEN_js_1.clsvRTResearchResultEN.con_Periodical) == true) {
            const strComparisonOp_Periodical = objvRTResearchResult_Cond.dicFldComparisonOp[clsvRTResearchResultEN_js_1.clsvRTResearchResultEN.con_Periodical];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTResearchResultEN_js_1.clsvRTResearchResultEN.con_Periodical, objvRTResearchResult_Cond.periodical, strComparisonOp_Periodical);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTResearchResult_Cond.dicFldComparisonOp, clsvRTResearchResultEN_js_1.clsvRTResearchResultEN.con_Author) == true) {
            const strComparisonOp_Author = objvRTResearchResult_Cond.dicFldComparisonOp[clsvRTResearchResultEN_js_1.clsvRTResearchResultEN.con_Author];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTResearchResultEN_js_1.clsvRTResearchResultEN.con_Author, objvRTResearchResult_Cond.author, strComparisonOp_Author);
        }
        return strWhereCond;
    }
    exports.vRTResearchResult_GetCombineCondition = vRTResearchResult_GetCombineCondition;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objvRTResearchResultENS:源对象
     * @param objvRTResearchResultENT:目标对象
    */
    function vRTResearchResult_CopyObjTo(objvRTResearchResultENS, objvRTResearchResultENT) {
        objvRTResearchResultENT.topicId = objvRTResearchResultENS.topicId; //主题Id
        objvRTResearchResultENT.paperId = objvRTResearchResultENS.paperId; //论文Id
        objvRTResearchResultENT.updDate = objvRTResearchResultENS.updDate; //修改日期
        objvRTResearchResultENT.updUser = objvRTResearchResultENS.updUser; //修改人
        objvRTResearchResultENT.memo = objvRTResearchResultENS.memo; //备注
        objvRTResearchResultENT.mId = objvRTResearchResultENS.mId; //mId
        objvRTResearchResultENT.userName = objvRTResearchResultENS.userName; //用户名
        objvRTResearchResultENT.paperTitle = objvRTResearchResultENS.paperTitle; //论文标题
        objvRTResearchResultENT.paperContent = objvRTResearchResultENS.paperContent; //主题内容
        objvRTResearchResultENT.topicName = objvRTResearchResultENS.topicName; //栏目主题
        objvRTResearchResultENT.topicContent = objvRTResearchResultENS.topicContent; //主题内容
        objvRTResearchResultENT.topicProposePeople = objvRTResearchResultENS.topicProposePeople; //主题提出人
        objvRTResearchResultENT.periodical = objvRTResearchResultENS.periodical; //期刊
        objvRTResearchResultENT.author = objvRTResearchResultENS.author; //作者
    }
    exports.vRTResearchResult_CopyObjTo = vRTResearchResult_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objvRTResearchResultENS:源对象
     * @param objvRTResearchResultENT:目标对象
    */
    function vRTResearchResult_GetObjFromJsonObj(objvRTResearchResultENS) {
        const objvRTResearchResultENT = new clsvRTResearchResultEN_js_1.clsvRTResearchResultEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvRTResearchResultENT, objvRTResearchResultENS);
        return objvRTResearchResultENT;
    }
    exports.vRTResearchResult_GetObjFromJsonObj = vRTResearchResult_GetObjFromJsonObj;
});
