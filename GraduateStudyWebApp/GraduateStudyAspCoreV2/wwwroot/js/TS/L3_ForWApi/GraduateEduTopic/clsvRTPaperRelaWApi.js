/**
* 类名:clsvRTPaperRelaWApi
* 表名:vRTPaperRela(01120583)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/13 00:55:13
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
        define(["require", "exports", "axios", "../../PubFun/enumComparisonOp.js", "../../PubFun/CacheHelper.js", "../../L0_Entity/GraduateEduTopic/clsvRTPaperRelaEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.vRTPaperRela_GetObjFromJsonObj = exports.vRTPaperRela_CopyObjTo = exports.vRTPaperRela_GetCombineCondition = exports.vRTPaperRela_GetObjByJSONStr = exports.vRTPaperRela_GetObjLstByJSONObjLst = exports.vRTPaperRela_GetObjLstByJSONStr = exports.vRTPaperRela_GetJSONStrByObj = exports.vRTPaperRela_ReFreshThisCache = exports.vRTPaperRela_GetWebApiUrl = exports.vRTPaperRela_GetRecCountByCond_Cache = exports.vRTPaperRela_GetRecCountByCondAsync = exports.vRTPaperRela_IsExistAsync = exports.vRTPaperRela_IsExist_Cache = exports.vRTPaperRela_IsExist = exports.vRTPaperRela_IsExistRecordAsync = exports.vRTPaperRela_IsExistRecord_Cache = exports.vRTPaperRela_GetObjLstByPagerAsync = exports.vRTPaperRela_GetObjLstByPager_Cache = exports.vRTPaperRela_GetObjLstByRange = exports.vRTPaperRela_GetObjLstByRangeAsync = exports.vRTPaperRela_GetTopObjLstAsync = exports.vRTPaperRela_GetObjLstBymIdLst_Cache = exports.vRTPaperRela_GetObjLstBymIdLstAsync = exports.vRTPaperRela_GetSubObjLst_Cache = exports.vRTPaperRela_GetObjLst_PureCache = exports.vRTPaperRela_GetObjLst_Cache = exports.vRTPaperRela_GetObjLst_sessionStorage_PureCache = exports.vRTPaperRela_GetObjLst_sessionStorage = exports.vRTPaperRela_GetObjLstAsync = exports.vRTPaperRela_GetObjLst_localStorage_PureCache = exports.vRTPaperRela_GetObjLst_localStorage = exports.vRTPaperRela_GetObjLst_ClientCache = exports.vRTPaperRela_GetFirstObjAsync = exports.vRTPaperRela_GetFirstID = exports.vRTPaperRela_GetFirstIDAsync = exports.vRTPaperRela_funcKey = exports.vRTPaperRela_FilterFunByKey = exports.vRTPaperRela_SortFunByKey = exports.vRTPaperRela_SortFun_Defa_2Fld = exports.vRTPaperRela_SortFun_Defa = exports.vRTPaperRela_func = exports.vRTPaperRela_GetObjBymId_localStorage = exports.vRTPaperRela_GetObjBymId_Cache = exports.vRTPaperRela_GetObjBymIdAsync = exports.vRTPaperRela_ConstructorName = exports.vRTPaperRela_Controller = void 0;
    /**
     * vRTPaperRela(vRTPaperRela)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月13日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const enumComparisonOp_js_1 = require("../../PubFun/enumComparisonOp.js");
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsvRTPaperRelaEN_js_1 = require("../../L0_Entity/GraduateEduTopic/clsvRTPaperRelaEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.vRTPaperRela_Controller = "vRTPaperRelaApi";
    exports.vRTPaperRela_ConstructorName = "vRTPaperRela";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param lngmId:关键字
    * @returns 对象
    **/
    async function vRTPaperRela_GetObjBymIdAsync(lngmId) {
        const strThisFuncName = "GetObjBymIdAsync";
        if (lngmId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngmId]不能为空！(In clsvRTPaperRelaWApi.GetObjBymIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjBymId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vRTPaperRela_Controller, strAction);
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
                const objvRTPaperRela = vRTPaperRela_GetObjFromJsonObj(returnObj);
                return objvRTPaperRela;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vRTPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vRTPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vRTPaperRela_GetObjBymIdAsync = vRTPaperRela_GetObjBymIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param lngmId:所给的关键字
     * @returns 对象
    */
    async function vRTPaperRela_GetObjBymId_Cache(lngmId, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjBymId_Cache";
        if (lngmId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngmId]不能为空！(In clsvRTPaperRelaWApi.GetObjBymId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        const arrvRTPaperRelaObjLst_Cache = await vRTPaperRela_GetObjLst_Cache();
        try {
            const arrvRTPaperRela_Sel = arrvRTPaperRelaObjLst_Cache.filter(x => x.mId == lngmId);
            let objvRTPaperRela;
            if (arrvRTPaperRela_Sel.length > 0) {
                objvRTPaperRela = arrvRTPaperRela_Sel[0];
                return objvRTPaperRela;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    const objvRTPaperRela_Const = await vRTPaperRela_GetObjBymIdAsync(lngmId);
                    if (objvRTPaperRela_Const != null) {
                        vRTPaperRela_ReFreshThisCache();
                        return objvRTPaperRela_Const;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngmId, exports.vRTPaperRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.vRTPaperRela_GetObjBymId_Cache = vRTPaperRela_GetObjBymId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param lngmId:所给的关键字
     * @returns 对象
    */
    async function vRTPaperRela_GetObjBymId_localStorage(lngmId) {
        const strThisFuncName = "GetObjBymId_localStorage";
        if (lngmId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngmId]不能为空！(In clsvRTPaperRelaWApi.GetObjBymId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN._CurrTabName, lngmId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objvRTPaperRela_Cache = JSON.parse(strTempObj);
            return objvRTPaperRela_Cache;
        }
        try {
            const objvRTPaperRela = await vRTPaperRela_GetObjBymIdAsync(lngmId);
            if (objvRTPaperRela != null) {
                localStorage.setItem(strKey, JSON.stringify(objvRTPaperRela));
                const strInfo = (0, clsString_js_1.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objvRTPaperRela;
            }
            return objvRTPaperRela;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngmId, exports.vRTPaperRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.vRTPaperRela_GetObjBymId_localStorage = vRTPaperRela_GetObjBymId_localStorage;
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
    async function vRTPaperRela_func(strInFldName, strOutFldName, strInValue) {
        //const strThisFuncName = "func";
        if (strInFldName != clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_mId) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_1.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strOutFldName, clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const lngmId = Number(strInValue);
        if (lngmId == 0) {
            return "";
        }
        const objvRTPaperRela = await vRTPaperRela_GetObjBymId_Cache(lngmId);
        if (objvRTPaperRela == null)
            return "";
        if (objvRTPaperRela.GetFldValue(strOutFldName) == null)
            return "";
        return objvRTPaperRela.GetFldValue(strOutFldName).toString();
    }
    exports.vRTPaperRela_func = vRTPaperRela_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vRTPaperRela_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.mId - b.mId;
    }
    exports.vRTPaperRela_SortFun_Defa = vRTPaperRela_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vRTPaperRela_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.topicId == b.topicId)
            return a.paperId.localeCompare(b.paperId);
        else
            return a.topicId.localeCompare(b.topicId);
    }
    exports.vRTPaperRela_SortFun_Defa_2Fld = vRTPaperRela_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vRTPaperRela_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_mId:
                    return (a, b) => {
                        return a.mId - b.mId;
                    };
                case clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_TopicId:
                    return (a, b) => {
                        if (a.topicId == null)
                            return -1;
                        if (b.topicId == null)
                            return 1;
                        return a.topicId.localeCompare(b.topicId);
                    };
                case clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_PaperId:
                    return (a, b) => {
                        if (a.paperId == null)
                            return -1;
                        if (b.paperId == null)
                            return 1;
                        return a.paperId.localeCompare(b.paperId);
                    };
                case clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_UpdDate:
                    return (a, b) => {
                        if (a.updDate == null)
                            return -1;
                        if (b.updDate == null)
                            return 1;
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_UpdUser:
                    return (a, b) => {
                        if (a.updUser == null)
                            return -1;
                        if (b.updUser == null)
                            return 1;
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                case clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_TopicName:
                    return (a, b) => {
                        if (a.topicName == null)
                            return -1;
                        if (b.topicName == null)
                            return 1;
                        return a.topicName.localeCompare(b.topicName);
                    };
                case clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_TopicContent:
                    return (a, b) => {
                        if (a.topicContent == null)
                            return -1;
                        if (b.topicContent == null)
                            return 1;
                        return a.topicContent.localeCompare(b.topicContent);
                    };
                case clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_TopicProposePeople:
                    return (a, b) => {
                        if (a.topicProposePeople == null)
                            return -1;
                        if (b.topicProposePeople == null)
                            return 1;
                        return a.topicProposePeople.localeCompare(b.topicProposePeople);
                    };
                case clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_PaperTitle:
                    return (a, b) => {
                        if (a.paperTitle == null)
                            return -1;
                        if (b.paperTitle == null)
                            return 1;
                        return a.paperTitle.localeCompare(b.paperTitle);
                    };
                case clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_PaperContent:
                    return (a, b) => {
                        if (a.paperContent == null)
                            return -1;
                        if (b.paperContent == null)
                            return 1;
                        return a.paperContent.localeCompare(b.paperContent);
                    };
                case clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_Author:
                    return (a, b) => {
                        if (a.author == null)
                            return -1;
                        if (b.author == null)
                            return 1;
                        return a.author.localeCompare(b.author);
                    };
                case clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_Periodical:
                    return (a, b) => {
                        if (a.periodical == null)
                            return -1;
                        if (b.periodical == null)
                            return 1;
                        return a.periodical.localeCompare(b.periodical);
                    };
                case clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_IsSubmit:
                    return (a, b) => {
                        if (a.isSubmit == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_id_CurrEduCls:
                    return (a, b) => {
                        if (a.id_CurrEduCls == null)
                            return -1;
                        if (b.id_CurrEduCls == null)
                            return 1;
                        return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
                    };
                case clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_PaperDate:
                    return (a, b) => {
                        if (a.paperDate == null)
                            return -1;
                        if (b.paperDate == null)
                            return 1;
                        return a.paperDate.localeCompare(b.paperDate);
                    };
                case clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_PaperStatusId:
                    return (a, b) => {
                        if (a.paperStatusId == null)
                            return -1;
                        if (b.paperStatusId == null)
                            return 1;
                        return a.paperStatusId.localeCompare(b.paperStatusId);
                    };
                case clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_PaperTypeId:
                    return (a, b) => {
                        if (a.paperTypeId == null)
                            return -1;
                        if (b.paperTypeId == null)
                            return 1;
                        return a.paperTypeId.localeCompare(b.paperTypeId);
                    };
                case clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_PaperUserId:
                    return (a, b) => {
                        if (a.paperUserId == null)
                            return -1;
                        if (b.paperUserId == null)
                            return 1;
                        return a.paperUserId.localeCompare(b.paperUserId);
                    };
                case clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_VersionCount:
                    return (a, b) => {
                        return a.versionCount - b.versionCount;
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vRTPaperRela]中不存在！(in ${exports.vRTPaperRela_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_mId:
                    return (a, b) => {
                        return b.mId - a.mId;
                    };
                case clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_TopicId:
                    return (a, b) => {
                        if (b.topicId == null)
                            return -1;
                        if (a.topicId == null)
                            return 1;
                        return b.topicId.localeCompare(a.topicId);
                    };
                case clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_PaperId:
                    return (a, b) => {
                        if (b.paperId == null)
                            return -1;
                        if (a.paperId == null)
                            return 1;
                        return b.paperId.localeCompare(a.paperId);
                    };
                case clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_UpdDate:
                    return (a, b) => {
                        if (b.updDate == null)
                            return -1;
                        if (a.updDate == null)
                            return 1;
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_UpdUser:
                    return (a, b) => {
                        if (b.updUser == null)
                            return -1;
                        if (a.updUser == null)
                            return 1;
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                case clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_TopicName:
                    return (a, b) => {
                        if (b.topicName == null)
                            return -1;
                        if (a.topicName == null)
                            return 1;
                        return b.topicName.localeCompare(a.topicName);
                    };
                case clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_TopicContent:
                    return (a, b) => {
                        if (b.topicContent == null)
                            return -1;
                        if (a.topicContent == null)
                            return 1;
                        return b.topicContent.localeCompare(a.topicContent);
                    };
                case clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_TopicProposePeople:
                    return (a, b) => {
                        if (b.topicProposePeople == null)
                            return -1;
                        if (a.topicProposePeople == null)
                            return 1;
                        return b.topicProposePeople.localeCompare(a.topicProposePeople);
                    };
                case clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_PaperTitle:
                    return (a, b) => {
                        if (b.paperTitle == null)
                            return -1;
                        if (a.paperTitle == null)
                            return 1;
                        return b.paperTitle.localeCompare(a.paperTitle);
                    };
                case clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_PaperContent:
                    return (a, b) => {
                        if (b.paperContent == null)
                            return -1;
                        if (a.paperContent == null)
                            return 1;
                        return b.paperContent.localeCompare(a.paperContent);
                    };
                case clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_Author:
                    return (a, b) => {
                        if (b.author == null)
                            return -1;
                        if (a.author == null)
                            return 1;
                        return b.author.localeCompare(a.author);
                    };
                case clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_Periodical:
                    return (a, b) => {
                        if (b.periodical == null)
                            return -1;
                        if (a.periodical == null)
                            return 1;
                        return b.periodical.localeCompare(a.periodical);
                    };
                case clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_IsSubmit:
                    return (a, b) => {
                        if (b.isSubmit == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_id_CurrEduCls:
                    return (a, b) => {
                        if (b.id_CurrEduCls == null)
                            return -1;
                        if (a.id_CurrEduCls == null)
                            return 1;
                        return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
                    };
                case clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_PaperDate:
                    return (a, b) => {
                        if (b.paperDate == null)
                            return -1;
                        if (a.paperDate == null)
                            return 1;
                        return b.paperDate.localeCompare(a.paperDate);
                    };
                case clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_PaperStatusId:
                    return (a, b) => {
                        if (b.paperStatusId == null)
                            return -1;
                        if (a.paperStatusId == null)
                            return 1;
                        return b.paperStatusId.localeCompare(a.paperStatusId);
                    };
                case clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_PaperTypeId:
                    return (a, b) => {
                        if (b.paperTypeId == null)
                            return -1;
                        if (a.paperTypeId == null)
                            return 1;
                        return b.paperTypeId.localeCompare(a.paperTypeId);
                    };
                case clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_PaperUserId:
                    return (a, b) => {
                        if (b.paperUserId == null)
                            return -1;
                        if (a.paperUserId == null)
                            return 1;
                        return b.paperUserId.localeCompare(a.paperUserId);
                    };
                case clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_VersionCount:
                    return (a, b) => {
                        return b.versionCount - a.versionCount;
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vRTPaperRela]中不存在！(in ${exports.vRTPaperRela_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.vRTPaperRela_SortFunByKey = vRTPaperRela_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function vRTPaperRela_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_mId:
                return (obj) => {
                    return obj.mId === value;
                };
            case clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_TopicId:
                return (obj) => {
                    return obj.topicId === value;
                };
            case clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_PaperId:
                return (obj) => {
                    return obj.paperId === value;
                };
            case clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            case clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_TopicName:
                return (obj) => {
                    return obj.topicName === value;
                };
            case clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_TopicContent:
                return (obj) => {
                    return obj.topicContent === value;
                };
            case clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_TopicProposePeople:
                return (obj) => {
                    return obj.topicProposePeople === value;
                };
            case clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_PaperTitle:
                return (obj) => {
                    return obj.paperTitle === value;
                };
            case clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_PaperContent:
                return (obj) => {
                    return obj.paperContent === value;
                };
            case clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_Author:
                return (obj) => {
                    return obj.author === value;
                };
            case clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_Periodical:
                return (obj) => {
                    return obj.periodical === value;
                };
            case clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_IsSubmit:
                return (obj) => {
                    return obj.isSubmit === value;
                };
            case clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_id_CurrEduCls:
                return (obj) => {
                    return obj.id_CurrEduCls === value;
                };
            case clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_PaperDate:
                return (obj) => {
                    return obj.paperDate === value;
                };
            case clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_PaperStatusId:
                return (obj) => {
                    return obj.paperStatusId === value;
                };
            case clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_PaperTypeId:
                return (obj) => {
                    return obj.paperTypeId === value;
                };
            case clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_PaperUserId:
                return (obj) => {
                    return obj.paperUserId === value;
                };
            case clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_VersionCount:
                return (obj) => {
                    return obj.versionCount === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[vRTPaperRela]中不存在！(in ${exports.vRTPaperRela_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.vRTPaperRela_FilterFunByKey = vRTPaperRela_FilterFunByKey;
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
    async function vRTPaperRela_funcKey(strInFldName, strInValue, strComparisonOp) {
        //const strThisFuncName = "funcKey";
        if (strInFldName == clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_mId) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (Number(strInValue) == 0) {
            return [];
        }
        const arrvRTPaperRela = await vRTPaperRela_GetObjLst_Cache();
        if (arrvRTPaperRela == null)
            return [];
        let arrvRTPaperRela_Sel = arrvRTPaperRela;
        const strType = typeof (strInValue);
        switch (strType) {
            case "string":
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01: // " = "
                        arrvRTPaperRela_Sel = arrvRTPaperRela_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.Like_03:
                        arrvRTPaperRela_Sel = arrvRTPaperRela_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.In_04:
                        const arrValues = strInValue.split(',');
                        arrvRTPaperRela_Sel = arrvRTPaperRela_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
                        break;
                }
                break;
            case "boolean":
                if (strInValue == null)
                    return [];
                if (strComparisonOp == enumComparisonOp_js_1.enumComparisonOp.Equal_01) {
                    arrvRTPaperRela_Sel = arrvRTPaperRela_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                }
                break;
            case "number":
                if (Number(strInValue) == 0)
                    return [];
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01:
                        arrvRTPaperRela_Sel = arrvRTPaperRela_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotEqual_02:
                        arrvRTPaperRela_Sel = arrvRTPaperRela_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotLessThan_05: //" >= ":
                        arrvRTPaperRela_Sel = arrvRTPaperRela_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotGreaterThan_06: //" <= ":
                        arrvRTPaperRela_Sel = arrvRTPaperRela_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.GreaterThan_07: //" > ":
                        arrvRTPaperRela_Sel = arrvRTPaperRela_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.LessThan_08: //" < ":
                        arrvRTPaperRela_Sel = arrvRTPaperRela_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                }
                break;
        }
        if (arrvRTPaperRela_Sel.length == 0)
            return [];
        return arrvRTPaperRela_Sel.map(x => x.mId);
    }
    exports.vRTPaperRela_funcKey = vRTPaperRela_funcKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function vRTPaperRela_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vRTPaperRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vRTPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vRTPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vRTPaperRela_GetFirstIDAsync = vRTPaperRela_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function vRTPaperRela_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vRTPaperRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vRTPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vRTPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vRTPaperRela_GetFirstID = vRTPaperRela_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function vRTPaperRela_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vRTPaperRela_Controller, strAction);
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
                const objvRTPaperRela = vRTPaperRela_GetObjFromJsonObj(returnObj);
                return objvRTPaperRela;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vRTPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vRTPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vRTPaperRela_GetFirstObjAsync = vRTPaperRela_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vRTPaperRela_GetObjLst_ClientCache() {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN._CurrTabName;
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_1.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrvRTPaperRelaExObjLst_Cache = CacheHelper_js_1.CacheHelper.Get(strKey);
            const arrvRTPaperRelaObjLst_T = vRTPaperRela_GetObjLstByJSONObjLst(arrvRTPaperRelaExObjLst_Cache);
            return arrvRTPaperRelaObjLst_T;
        }
        try {
            const arrvRTPaperRelaExObjLst = await vRTPaperRela_GetObjLstAsync(strWhereCond);
            CacheHelper_js_1.CacheHelper.Add(strKey, arrvRTPaperRelaExObjLst);
            const strInfo = (0, clsString_js_1.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvRTPaperRelaExObjLst.length);
            console.log(strInfo);
            return arrvRTPaperRelaExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vRTPaperRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vRTPaperRela_GetObjLst_ClientCache = vRTPaperRela_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vRTPaperRela_GetObjLst_localStorage() {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN._CurrTabName;
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrvRTPaperRelaExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrvRTPaperRelaObjLst_T = vRTPaperRela_GetObjLstByJSONObjLst(arrvRTPaperRelaExObjLst_Cache);
            return arrvRTPaperRelaObjLst_T;
        }
        try {
            const arrvRTPaperRelaExObjLst = await vRTPaperRela_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrvRTPaperRelaExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvRTPaperRelaExObjLst.length);
            console.log(strInfo);
            return arrvRTPaperRelaExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vRTPaperRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vRTPaperRela_GetObjLst_localStorage = vRTPaperRela_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vRTPaperRela_GetObjLst_localStorage_PureCache() {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrvRTPaperRelaObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvRTPaperRelaObjLst_Cache;
        }
        else
            return null;
    }
    exports.vRTPaperRela_GetObjLst_localStorage_PureCache = vRTPaperRela_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function vRTPaperRela_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vRTPaperRela_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vRTPaperRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vRTPaperRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vRTPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vRTPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vRTPaperRela_GetObjLstAsync = vRTPaperRela_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vRTPaperRela_GetObjLst_sessionStorage() {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN._CurrTabName;
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrvRTPaperRelaExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrvRTPaperRelaObjLst_T = vRTPaperRela_GetObjLstByJSONObjLst(arrvRTPaperRelaExObjLst_Cache);
            return arrvRTPaperRelaObjLst_T;
        }
        try {
            const arrvRTPaperRelaExObjLst = await vRTPaperRela_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrvRTPaperRelaExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvRTPaperRelaExObjLst.length);
            console.log(strInfo);
            return arrvRTPaperRelaExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vRTPaperRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vRTPaperRela_GetObjLst_sessionStorage = vRTPaperRela_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vRTPaperRela_GetObjLst_sessionStorage_PureCache() {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrvRTPaperRelaObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvRTPaperRelaObjLst_Cache;
        }
        else
            return null;
    }
    exports.vRTPaperRela_GetObjLst_sessionStorage_PureCache = vRTPaperRela_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vRTPaperRela_GetObjLst_Cache() {
        //const strThisFuncName = "GetObjLst_Cache";
        let arrvRTPaperRelaObjLst_Cache;
        switch (clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.CacheModeId) {
            case "04": //sessionStorage
                arrvRTPaperRelaObjLst_Cache = await vRTPaperRela_GetObjLst_sessionStorage();
                break;
            case "03": //localStorage
                arrvRTPaperRelaObjLst_Cache = await vRTPaperRela_GetObjLst_localStorage();
                break;
            case "02": //ClientCache
                arrvRTPaperRelaObjLst_Cache = await vRTPaperRela_GetObjLst_ClientCache();
                break;
            default:
                arrvRTPaperRelaObjLst_Cache = await vRTPaperRela_GetObjLst_ClientCache();
                break;
        }
        const arrvRTPaperRelaObjLst = vRTPaperRela_GetObjLstByJSONObjLst(arrvRTPaperRelaObjLst_Cache);
        return arrvRTPaperRelaObjLst_Cache;
    }
    exports.vRTPaperRela_GetObjLst_Cache = vRTPaperRela_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vRTPaperRela_GetObjLst_PureCache() {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrvRTPaperRelaObjLst_Cache;
        switch (clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.CacheModeId) {
            case "04": //sessionStorage
                arrvRTPaperRelaObjLst_Cache = await vRTPaperRela_GetObjLst_sessionStorage_PureCache();
                break;
            case "03": //localStorage
                arrvRTPaperRelaObjLst_Cache = await vRTPaperRela_GetObjLst_localStorage_PureCache();
                break;
            case "02": //ClientCache
                arrvRTPaperRelaObjLst_Cache = null;
                break;
            default:
                arrvRTPaperRelaObjLst_Cache = null;
                break;
        }
        return arrvRTPaperRelaObjLst_Cache;
    }
    exports.vRTPaperRela_GetObjLst_PureCache = vRTPaperRela_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objlngmId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function vRTPaperRela_GetSubObjLst_Cache(objvRTPaperRela_Cond) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrvRTPaperRelaObjLst_Cache = await vRTPaperRela_GetObjLst_Cache();
        let arrvRTPaperRela_Sel = arrvRTPaperRelaObjLst_Cache;
        if (objvRTPaperRela_Cond.sf_FldComparisonOp == null || objvRTPaperRela_Cond.sf_FldComparisonOp == "")
            return arrvRTPaperRela_Sel;
        const dicFldComparisonOp = JSON.parse(objvRTPaperRela_Cond.sf_FldComparisonOp);
        //console.log("clsvRTPaperRelaWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvRTPaperRela_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvRTPaperRela_Sel = arrvRTPaperRela_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvRTPaperRela_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvRTPaperRela_Sel = arrvRTPaperRela_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvRTPaperRela_Sel = arrvRTPaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvRTPaperRela_Sel = arrvRTPaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvRTPaperRela_Sel = arrvRTPaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvRTPaperRela_Sel = arrvRTPaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvRTPaperRela_Sel = arrvRTPaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvRTPaperRela_Sel = arrvRTPaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvRTPaperRela_Sel = arrvRTPaperRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvRTPaperRela_Sel = arrvRTPaperRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvRTPaperRela_Sel = arrvRTPaperRela_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvRTPaperRela_Sel = arrvRTPaperRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvRTPaperRela_Sel = arrvRTPaperRela_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvRTPaperRela_Sel = arrvRTPaperRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrvRTPaperRela_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objvRTPaperRela_Cond), exports.vRTPaperRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vRTPaperRela_GetSubObjLst_Cache = vRTPaperRela_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrmId:关键字列表
    * @returns 对象列表
    **/
    async function vRTPaperRela_GetObjLstBymIdLstAsync(arrmId) {
        const strThisFuncName = "GetObjLstBymIdLstAsync";
        const strAction = "GetObjLstBymIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vRTPaperRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrmId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vRTPaperRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vRTPaperRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vRTPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vRTPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vRTPaperRela_GetObjLstBymIdLstAsync = vRTPaperRela_GetObjLstBymIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrlngmIdLst:关键字列表
     * @returns 对象列表
    */
    async function vRTPaperRela_GetObjLstBymIdLst_Cache(arrmIdLst) {
        const strThisFuncName = "GetObjLstBymIdLst_Cache";
        try {
            const arrvRTPaperRelaObjLst_Cache = await vRTPaperRela_GetObjLst_Cache();
            const arrvRTPaperRela_Sel = arrvRTPaperRelaObjLst_Cache.filter(x => arrmIdLst.indexOf(x.mId) > -1);
            return arrvRTPaperRela_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrmIdLst.join(","), exports.vRTPaperRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
    }
    exports.vRTPaperRela_GetObjLstBymIdLst_Cache = vRTPaperRela_GetObjLstBymIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function vRTPaperRela_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vRTPaperRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vRTPaperRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vRTPaperRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vRTPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vRTPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vRTPaperRela_GetTopObjLstAsync = vRTPaperRela_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vRTPaperRela_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vRTPaperRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vRTPaperRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vRTPaperRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vRTPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vRTPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vRTPaperRela_GetObjLstByRangeAsync = vRTPaperRela_GetObjLstByRangeAsync;
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
    async function vRTPaperRela_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vRTPaperRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vRTPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vRTPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vRTPaperRela_GetObjLstByRange = vRTPaperRela_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function vRTPaperRela_GetObjLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const arrvRTPaperRelaObjLst_Cache = await vRTPaperRela_GetObjLst_Cache();
        if (arrvRTPaperRelaObjLst_Cache.length == 0)
            return arrvRTPaperRelaObjLst_Cache;
        let arrvRTPaperRela_Sel = arrvRTPaperRelaObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objvRTPaperRela_Cond = new clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvRTPaperRela_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsvRTPaperRelaWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvRTPaperRela_Sel = arrvRTPaperRela_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvRTPaperRela_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvRTPaperRela_Sel = arrvRTPaperRela_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvRTPaperRela_Sel = arrvRTPaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvRTPaperRela_Sel = arrvRTPaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvRTPaperRela_Sel = arrvRTPaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvRTPaperRela_Sel = arrvRTPaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvRTPaperRela_Sel = arrvRTPaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvRTPaperRela_Sel = arrvRTPaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrvRTPaperRela_Sel = arrvRTPaperRela_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvRTPaperRela_Sel = arrvRTPaperRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvRTPaperRela_Sel = arrvRTPaperRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvRTPaperRela_Sel = arrvRTPaperRela_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvRTPaperRela_Sel = arrvRTPaperRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvRTPaperRela_Sel = arrvRTPaperRela_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvRTPaperRela_Sel = arrvRTPaperRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvRTPaperRela_Sel.length == 0)
                return arrvRTPaperRela_Sel;
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
                arrvRTPaperRela_Sel = arrvRTPaperRela_Sel.sort(vRTPaperRela_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrvRTPaperRela_Sel = arrvRTPaperRela_Sel.sort(objPagerPara.sortFun);
            }
            arrvRTPaperRela_Sel = arrvRTPaperRela_Sel.slice(intStart, intEnd);
            return arrvRTPaperRela_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.vRTPaperRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vRTPaperRela_GetObjLstByPager_Cache = vRTPaperRela_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vRTPaperRela_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vRTPaperRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vRTPaperRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vRTPaperRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vRTPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vRTPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vRTPaperRela_GetObjLstByPagerAsync = vRTPaperRela_GetObjLstByPagerAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objlngmId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function vRTPaperRela_IsExistRecord_Cache(objvRTPaperRela_Cond) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrvRTPaperRelaObjLst_Cache = await vRTPaperRela_GetObjLst_Cache();
        if (arrvRTPaperRelaObjLst_Cache == null)
            return false;
        let arrvRTPaperRela_Sel = arrvRTPaperRelaObjLst_Cache;
        if (objvRTPaperRela_Cond.sf_FldComparisonOp == null || objvRTPaperRela_Cond.sf_FldComparisonOp == "")
            return arrvRTPaperRela_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objvRTPaperRela_Cond.sf_FldComparisonOp);
        //console.log("clsvRTPaperRelaWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvRTPaperRela_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvRTPaperRela_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvRTPaperRela_Sel = arrvRTPaperRela_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvRTPaperRela_Sel = arrvRTPaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvRTPaperRela_Sel = arrvRTPaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvRTPaperRela_Sel = arrvRTPaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvRTPaperRela_Sel = arrvRTPaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvRTPaperRela_Sel = arrvRTPaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvRTPaperRela_Sel = arrvRTPaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvRTPaperRela_Sel = arrvRTPaperRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvRTPaperRela_Sel = arrvRTPaperRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvRTPaperRela_Sel = arrvRTPaperRela_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvRTPaperRela_Sel = arrvRTPaperRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvRTPaperRela_Sel = arrvRTPaperRela_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvRTPaperRela_Sel = arrvRTPaperRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvRTPaperRela_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objvRTPaperRela_Cond), exports.vRTPaperRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.vRTPaperRela_IsExistRecord_Cache = vRTPaperRela_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function vRTPaperRela_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vRTPaperRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vRTPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vRTPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vRTPaperRela_IsExistRecordAsync = vRTPaperRela_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param lngmId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function vRTPaperRela_IsExist(lngmId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vRTPaperRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vRTPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vRTPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vRTPaperRela_IsExist = vRTPaperRela_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param lngmId:所给的关键字
     * @returns 对象
    */
    async function vRTPaperRela_IsExist_Cache(lngmId) {
        const strThisFuncName = "IsExist_Cache";
        const arrvRTPaperRelaObjLst_Cache = await vRTPaperRela_GetObjLst_Cache();
        if (arrvRTPaperRelaObjLst_Cache == null)
            return false;
        try {
            const arrvRTPaperRela_Sel = arrvRTPaperRelaObjLst_Cache.filter(x => x.mId == lngmId);
            if (arrvRTPaperRela_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", lngmId, exports.vRTPaperRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.vRTPaperRela_IsExist_Cache = vRTPaperRela_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param lngmId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function vRTPaperRela_IsExistAsync(lngmId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vRTPaperRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vRTPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vRTPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vRTPaperRela_IsExistAsync = vRTPaperRela_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function vRTPaperRela_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vRTPaperRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vRTPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vRTPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vRTPaperRela_GetRecCountByCondAsync = vRTPaperRela_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objvRTPaperRela_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function vRTPaperRela_GetRecCountByCond_Cache(objvRTPaperRela_Cond) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrvRTPaperRelaObjLst_Cache = await vRTPaperRela_GetObjLst_Cache();
        if (arrvRTPaperRelaObjLst_Cache == null)
            return 0;
        let arrvRTPaperRela_Sel = arrvRTPaperRelaObjLst_Cache;
        if (objvRTPaperRela_Cond.sf_FldComparisonOp == null || objvRTPaperRela_Cond.sf_FldComparisonOp == "")
            return arrvRTPaperRela_Sel.length;
        const dicFldComparisonOp = JSON.parse(objvRTPaperRela_Cond.sf_FldComparisonOp);
        //console.log("clsvRTPaperRelaWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvRTPaperRela_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvRTPaperRela_Sel = arrvRTPaperRela_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvRTPaperRela_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvRTPaperRela_Sel = arrvRTPaperRela_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvRTPaperRela_Sel = arrvRTPaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvRTPaperRela_Sel = arrvRTPaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvRTPaperRela_Sel = arrvRTPaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvRTPaperRela_Sel = arrvRTPaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvRTPaperRela_Sel = arrvRTPaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvRTPaperRela_Sel = arrvRTPaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrvRTPaperRela_Sel = arrvRTPaperRela_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvRTPaperRela_Sel = arrvRTPaperRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvRTPaperRela_Sel = arrvRTPaperRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvRTPaperRela_Sel = arrvRTPaperRela_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvRTPaperRela_Sel = arrvRTPaperRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvRTPaperRela_Sel = arrvRTPaperRela_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvRTPaperRela_Sel = arrvRTPaperRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrvRTPaperRela_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objvRTPaperRela_Cond), exports.vRTPaperRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.vRTPaperRela_GetRecCountByCond_Cache = vRTPaperRela_GetRecCountByCond_Cache;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function vRTPaperRela_GetWebApiUrl(strController, strAction) {
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
    exports.vRTPaperRela_GetWebApiUrl = vRTPaperRela_GetWebApiUrl;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function vRTPaperRela_ReFreshThisCache() {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN._CurrTabName;
            switch (clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.CacheModeId) {
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
    exports.vRTPaperRela_ReFreshThisCache = vRTPaperRela_ReFreshThisCache;
    /* 该表的下拉框功能没有设置，不需要生成下拉框绑定函数。*/
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vRTPaperRela_GetJSONStrByObj(pobjvRTPaperRelaEN) {
        const strThisFuncName = "GetJSONStrByObj";
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjvRTPaperRelaEN);
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
    exports.vRTPaperRela_GetJSONStrByObj = vRTPaperRela_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function vRTPaperRela_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrvRTPaperRelaObjLst = new Array();
        if (strJSON === "") {
            return arrvRTPaperRelaObjLst;
        }
        try {
            arrvRTPaperRelaObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrvRTPaperRelaObjLst;
        }
        return arrvRTPaperRelaObjLst;
    }
    exports.vRTPaperRela_GetObjLstByJSONStr = vRTPaperRela_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrvRTPaperRelaObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function vRTPaperRela_GetObjLstByJSONObjLst(arrvRTPaperRelaObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrvRTPaperRelaObjLst = new Array();
        for (const objInFor of arrvRTPaperRelaObjLstS) {
            const obj1 = vRTPaperRela_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrvRTPaperRelaObjLst.push(obj1);
        }
        return arrvRTPaperRelaObjLst;
    }
    exports.vRTPaperRela_GetObjLstByJSONObjLst = vRTPaperRela_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vRTPaperRela_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjvRTPaperRelaEN = new clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN();
        if (strJSON === "") {
            return pobjvRTPaperRelaEN;
        }
        try {
            pobjvRTPaperRelaEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjvRTPaperRelaEN;
        }
        return pobjvRTPaperRelaEN;
    }
    exports.vRTPaperRela_GetObjByJSONStr = vRTPaperRela_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function vRTPaperRela_GetCombineCondition(objvRTPaperRela_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objvRTPaperRela_Cond.dicFldComparisonOp, clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_mId) == true) {
            const strComparisonOp_mId = objvRTPaperRela_Cond.dicFldComparisonOp[clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_mId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_mId, objvRTPaperRela_Cond.mId, strComparisonOp_mId);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTPaperRela_Cond.dicFldComparisonOp, clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_TopicId) == true) {
            const strComparisonOp_TopicId = objvRTPaperRela_Cond.dicFldComparisonOp[clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_TopicId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_TopicId, objvRTPaperRela_Cond.topicId, strComparisonOp_TopicId);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTPaperRela_Cond.dicFldComparisonOp, clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_PaperId) == true) {
            const strComparisonOp_PaperId = objvRTPaperRela_Cond.dicFldComparisonOp[clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_PaperId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_PaperId, objvRTPaperRela_Cond.paperId, strComparisonOp_PaperId);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTPaperRela_Cond.dicFldComparisonOp, clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objvRTPaperRela_Cond.dicFldComparisonOp[clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_UpdDate, objvRTPaperRela_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTPaperRela_Cond.dicFldComparisonOp, clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objvRTPaperRela_Cond.dicFldComparisonOp[clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_UpdUser];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_UpdUser, objvRTPaperRela_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTPaperRela_Cond.dicFldComparisonOp, clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_Memo) == true) {
            const strComparisonOp_Memo = objvRTPaperRela_Cond.dicFldComparisonOp[clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_Memo, objvRTPaperRela_Cond.memo, strComparisonOp_Memo);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTPaperRela_Cond.dicFldComparisonOp, clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_TopicName) == true) {
            const strComparisonOp_TopicName = objvRTPaperRela_Cond.dicFldComparisonOp[clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_TopicName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_TopicName, objvRTPaperRela_Cond.topicName, strComparisonOp_TopicName);
        }
        //数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
        if (Object.prototype.hasOwnProperty.call(objvRTPaperRela_Cond.dicFldComparisonOp, clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_TopicProposePeople) == true) {
            const strComparisonOp_TopicProposePeople = objvRTPaperRela_Cond.dicFldComparisonOp[clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_TopicProposePeople];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_TopicProposePeople, objvRTPaperRela_Cond.topicProposePeople, strComparisonOp_TopicProposePeople);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTPaperRela_Cond.dicFldComparisonOp, clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_PaperTitle) == true) {
            const strComparisonOp_PaperTitle = objvRTPaperRela_Cond.dicFldComparisonOp[clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_PaperTitle];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_PaperTitle, objvRTPaperRela_Cond.paperTitle, strComparisonOp_PaperTitle);
        }
        //数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
        if (Object.prototype.hasOwnProperty.call(objvRTPaperRela_Cond.dicFldComparisonOp, clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_Author) == true) {
            const strComparisonOp_Author = objvRTPaperRela_Cond.dicFldComparisonOp[clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_Author];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_Author, objvRTPaperRela_Cond.author, strComparisonOp_Author);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTPaperRela_Cond.dicFldComparisonOp, clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_Periodical) == true) {
            const strComparisonOp_Periodical = objvRTPaperRela_Cond.dicFldComparisonOp[clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_Periodical];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_Periodical, objvRTPaperRela_Cond.periodical, strComparisonOp_Periodical);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTPaperRela_Cond.dicFldComparisonOp, clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_IsSubmit) == true) {
            if (objvRTPaperRela_Cond.isSubmit == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_IsSubmit);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_IsSubmit);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvRTPaperRela_Cond.dicFldComparisonOp, clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_id_CurrEduCls) == true) {
            const strComparisonOp_id_CurrEduCls = objvRTPaperRela_Cond.dicFldComparisonOp[clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_id_CurrEduCls];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_id_CurrEduCls, objvRTPaperRela_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTPaperRela_Cond.dicFldComparisonOp, clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_PaperDate) == true) {
            const strComparisonOp_PaperDate = objvRTPaperRela_Cond.dicFldComparisonOp[clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_PaperDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_PaperDate, objvRTPaperRela_Cond.paperDate, strComparisonOp_PaperDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTPaperRela_Cond.dicFldComparisonOp, clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_PaperStatusId) == true) {
            const strComparisonOp_PaperStatusId = objvRTPaperRela_Cond.dicFldComparisonOp[clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_PaperStatusId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_PaperStatusId, objvRTPaperRela_Cond.paperStatusId, strComparisonOp_PaperStatusId);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTPaperRela_Cond.dicFldComparisonOp, clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_PaperTypeId) == true) {
            const strComparisonOp_PaperTypeId = objvRTPaperRela_Cond.dicFldComparisonOp[clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_PaperTypeId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_PaperTypeId, objvRTPaperRela_Cond.paperTypeId, strComparisonOp_PaperTypeId);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTPaperRela_Cond.dicFldComparisonOp, clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_PaperUserId) == true) {
            const strComparisonOp_PaperUserId = objvRTPaperRela_Cond.dicFldComparisonOp[clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_PaperUserId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_PaperUserId, objvRTPaperRela_Cond.paperUserId, strComparisonOp_PaperUserId);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTPaperRela_Cond.dicFldComparisonOp, clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_VersionCount) == true) {
            const strComparisonOp_VersionCount = objvRTPaperRela_Cond.dicFldComparisonOp[clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_VersionCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN.con_VersionCount, objvRTPaperRela_Cond.versionCount, strComparisonOp_VersionCount);
        }
        return strWhereCond;
    }
    exports.vRTPaperRela_GetCombineCondition = vRTPaperRela_GetCombineCondition;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objvRTPaperRelaENS:源对象
     * @param objvRTPaperRelaENT:目标对象
    */
    function vRTPaperRela_CopyObjTo(objvRTPaperRelaENS, objvRTPaperRelaENT) {
        objvRTPaperRelaENT.mId = objvRTPaperRelaENS.mId; //mId
        objvRTPaperRelaENT.topicId = objvRTPaperRelaENS.topicId; //主题Id
        objvRTPaperRelaENT.paperId = objvRTPaperRelaENS.paperId; //论文Id
        objvRTPaperRelaENT.updDate = objvRTPaperRelaENS.updDate; //修改日期
        objvRTPaperRelaENT.updUser = objvRTPaperRelaENS.updUser; //修改人
        objvRTPaperRelaENT.memo = objvRTPaperRelaENS.memo; //备注
        objvRTPaperRelaENT.topicName = objvRTPaperRelaENS.topicName; //栏目主题
        objvRTPaperRelaENT.topicContent = objvRTPaperRelaENS.topicContent; //主题内容
        objvRTPaperRelaENT.topicProposePeople = objvRTPaperRelaENS.topicProposePeople; //主题提出人
        objvRTPaperRelaENT.paperTitle = objvRTPaperRelaENS.paperTitle; //论文标题
        objvRTPaperRelaENT.paperContent = objvRTPaperRelaENS.paperContent; //主题内容
        objvRTPaperRelaENT.author = objvRTPaperRelaENS.author; //作者
        objvRTPaperRelaENT.periodical = objvRTPaperRelaENS.periodical; //期刊
        objvRTPaperRelaENT.isSubmit = objvRTPaperRelaENS.isSubmit; //是否提交
        objvRTPaperRelaENT.id_CurrEduCls = objvRTPaperRelaENS.id_CurrEduCls; //教学班流水号
        objvRTPaperRelaENT.paperDate = objvRTPaperRelaENS.paperDate; //PaperDate
        objvRTPaperRelaENT.paperStatusId = objvRTPaperRelaENS.paperStatusId; //论文状态Id
        objvRTPaperRelaENT.paperTypeId = objvRTPaperRelaENS.paperTypeId; //论文类型Id
        objvRTPaperRelaENT.paperUserId = objvRTPaperRelaENS.paperUserId; //PaperUserId
        objvRTPaperRelaENT.versionCount = objvRTPaperRelaENS.versionCount; //版本统计
    }
    exports.vRTPaperRela_CopyObjTo = vRTPaperRela_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objvRTPaperRelaENS:源对象
     * @param objvRTPaperRelaENT:目标对象
    */
    function vRTPaperRela_GetObjFromJsonObj(objvRTPaperRelaENS) {
        const objvRTPaperRelaENT = new clsvRTPaperRelaEN_js_1.clsvRTPaperRelaEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvRTPaperRelaENT, objvRTPaperRelaENS);
        return objvRTPaperRelaENT;
    }
    exports.vRTPaperRela_GetObjFromJsonObj = vRTPaperRela_GetObjFromJsonObj;
});
