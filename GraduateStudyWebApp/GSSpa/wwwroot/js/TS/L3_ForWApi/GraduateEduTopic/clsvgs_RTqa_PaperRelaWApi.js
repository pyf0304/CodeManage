/**
* 类名:clsvgs_RTqa_PaperRelaWApi
* 表名:vgs_RTqa_PaperRela(01120695)
* 生成代码版本:2022.11.02.1
* 生成日期:2022/11/02 12:02:56
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
        define(["require", "exports", "axios", "../../PubFun/CacheHelper.js", "../../L0_Entity/GraduateEduTopic/clsvgs_RTqa_PaperRelaEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsSysPara4WebApi.js", "../../PubFun/CacheHelper.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.vgs_RTqa_PaperRela_GetObjFromJsonObj = exports.vgs_RTqa_PaperRela_CopyObjTo = exports.vgs_RTqa_PaperRela_GetCombineCondition = exports.vgs_RTqa_PaperRela_GetObjByJSONStr = exports.vgs_RTqa_PaperRela_GetObjLstByJSONObjLst = exports.vgs_RTqa_PaperRela_GetObjLstByJSONStr = exports.vgs_RTqa_PaperRela_GetJSONStrByObj = exports.vgs_RTqa_PaperRela_ReFreshThisCache = exports.vgs_RTqa_PaperRela_GetWebApiUrl = exports.vgs_RTqa_PaperRela_GetRecCountByCond_Cache = exports.vgs_RTqa_PaperRela_GetRecCountByCondAsync = exports.vgs_RTqa_PaperRela_IsExistAsync = exports.vgs_RTqa_PaperRela_IsExist_Cache = exports.vgs_RTqa_PaperRela_IsExist = exports.vgs_RTqa_PaperRela_IsExistRecordAsync = exports.vgs_RTqa_PaperRela_IsExistRecord_Cache = exports.vgs_RTqa_PaperRela_GetObjLstByPagerAsync = exports.vgs_RTqa_PaperRela_GetObjLstByPager_Cache = exports.vgs_RTqa_PaperRela_GetObjLstByRange = exports.vgs_RTqa_PaperRela_GetObjLstByRangeAsync = exports.vgs_RTqa_PaperRela_GetTopObjLstAsync = exports.vgs_RTqa_PaperRela_GetObjLstBymIdLst_Cache = exports.vgs_RTqa_PaperRela_GetObjLstBymIdLstAsync = exports.vgs_RTqa_PaperRela_GetSubObjLst_Cache = exports.vgs_RTqa_PaperRela_GetObjLst_PureCache = exports.vgs_RTqa_PaperRela_GetObjLst_Cache = exports.vgs_RTqa_PaperRela_GetObjLst_sessionStorage_PureCache = exports.vgs_RTqa_PaperRela_GetObjLst_sessionStorage = exports.vgs_RTqa_PaperRela_GetObjLstAsync = exports.vgs_RTqa_PaperRela_GetObjLst_localStorage_PureCache = exports.vgs_RTqa_PaperRela_GetObjLst_localStorage = exports.vgs_RTqa_PaperRela_GetObjLst_ClientCache = exports.vgs_RTqa_PaperRela_GetFirstObjAsync = exports.vgs_RTqa_PaperRela_GetFirstID = exports.vgs_RTqa_PaperRela_GetFirstIDAsync = exports.vgs_RTqa_PaperRela_FilterFunByKey = exports.vgs_RTqa_PaperRela_SortFunByKey = exports.vgs_RTqa_PaperRela_SortFun_Defa_2Fld = exports.vgs_RTqa_PaperRela_SortFun_Defa = exports.vgs_RTqa_PaperRela_func = exports.vgs_RTqa_PaperRela_GetObjBymId_localStorage = exports.vgs_RTqa_PaperRela_GetObjBymId_Cache = exports.vgs_RTqa_PaperRela_GetObjBymIdAsync = exports.vgs_RTqa_PaperRela_ConstructorName = exports.vgs_RTqa_PaperRela_Controller = void 0;
    /**
     * 主题答疑关系视图(vgs_RTqa_PaperRela)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2022年11月02日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsvgs_RTqa_PaperRelaEN_js_1 = require("../../L0_Entity/GraduateEduTopic/clsvgs_RTqa_PaperRelaEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    const CacheHelper_js_2 = require("../../PubFun/CacheHelper.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.vgs_RTqa_PaperRela_Controller = "vgs_RTqa_PaperRelaApi";
    exports.vgs_RTqa_PaperRela_ConstructorName = "vgs_RTqa_PaperRela";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param lngmId:关键字
    * @returns 对象
    **/
    async function vgs_RTqa_PaperRela_GetObjBymIdAsync(lngmId) {
        const strThisFuncName = "GetObjBymIdAsync";
        if (lngmId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngmId]不能为空！(In GetObjBymIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjBymId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_RTqa_PaperRela_Controller, strAction);
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
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vgs_RTqa_PaperRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objvgs_RTqa_PaperRela = vgs_RTqa_PaperRela_GetObjFromJsonObj(returnObj);
                return objvgs_RTqa_PaperRela;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_RTqa_PaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_RTqa_PaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_RTqa_PaperRela_GetObjBymIdAsync = vgs_RTqa_PaperRela_GetObjBymIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param lngmId:所给的关键字
     * @returns 对象
    */
    async function vgs_RTqa_PaperRela_GetObjBymId_Cache(lngmId, strTopicId, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjBymId_Cache";
        if (lngmId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngmId]不能为空！(In GetObjBymId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        const arrvgs_RTqa_PaperRelaObjLst_Cache = await vgs_RTqa_PaperRela_GetObjLst_Cache(strTopicId);
        try {
            const arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRelaObjLst_Cache.filter(x => x.mId == lngmId);
            let objvgs_RTqa_PaperRela;
            if (arrvgs_RTqa_PaperRela_Sel.length > 0) {
                objvgs_RTqa_PaperRela = arrvgs_RTqa_PaperRela_Sel[0];
                return objvgs_RTqa_PaperRela;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    objvgs_RTqa_PaperRela = await vgs_RTqa_PaperRela_GetObjBymIdAsync(lngmId);
                    if (objvgs_RTqa_PaperRela != null) {
                        vgs_RTqa_PaperRela_ReFreshThisCache(strTopicId);
                        return objvgs_RTqa_PaperRela;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngmId, exports.vgs_RTqa_PaperRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.vgs_RTqa_PaperRela_GetObjBymId_Cache = vgs_RTqa_PaperRela_GetObjBymId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param lngmId:所给的关键字
     * @returns 对象
    */
    async function vgs_RTqa_PaperRela_GetObjBymId_localStorage(lngmId) {
        const strThisFuncName = "GetObjBymId_localStorage";
        if (lngmId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngmId]不能为空！(In GetObjBymId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN._CurrTabName, lngmId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objvgs_RTqa_PaperRela_Cache = JSON.parse(strTempObj);
            return objvgs_RTqa_PaperRela_Cache;
        }
        try {
            const objvgs_RTqa_PaperRela = await vgs_RTqa_PaperRela_GetObjBymIdAsync(lngmId);
            if (objvgs_RTqa_PaperRela != null) {
                localStorage.setItem(strKey, JSON.stringify(objvgs_RTqa_PaperRela));
                const strInfo = (0, clsString_js_1.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objvgs_RTqa_PaperRela;
            }
            return objvgs_RTqa_PaperRela;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngmId, exports.vgs_RTqa_PaperRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.vgs_RTqa_PaperRela_GetObjBymId_localStorage = vgs_RTqa_PaperRela_GetObjBymId_localStorage;
    /*该表没有名称字段，不能生成此函数！*/
    /**
     * 映射函数。根据表映射把输入字段值，映射成输出字段值
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_func)
     * @param strInFldName:输入字段名
     * @param strOutFldName:输出字段名
     * @param strInValue:输入字段值
     @param strTopicId:缓存的分类字段
     * @returns 返回一个输出字段值
    */
    async function vgs_RTqa_PaperRela_func(strInFldName, strOutFldName, strInValue, strTopicId_C) {
        //const strThisFuncName = "func";
        if ((0, clsString_js_1.IsNullOrEmpty)(strTopicId_C) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strTopicId_C]不能为空！(In func)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strTopicId_C.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strTopicId_C]的长度:[{0}]不正确！", strTopicId_C.length);
            console.error(strMsg);
            throw (strMsg);
        }
        if (strInFldName != clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_mId) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_1.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strInFldName, clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const lngmId = Number(strInValue);
        if (lngmId == 0) {
            return "";
        }
        const objvgs_RTqa_PaperRela = await vgs_RTqa_PaperRela_GetObjBymId_Cache(lngmId, strTopicId_C);
        if (objvgs_RTqa_PaperRela == null)
            return "";
        return objvgs_RTqa_PaperRela.GetFldValue(strOutFldName).toString();
    }
    exports.vgs_RTqa_PaperRela_func = vgs_RTqa_PaperRela_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vgs_RTqa_PaperRela_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.mId - b.mId;
    }
    exports.vgs_RTqa_PaperRela_SortFun_Defa = vgs_RTqa_PaperRela_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vgs_RTqa_PaperRela_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.topicId == b.topicId)
            return a.topicName.localeCompare(b.topicName);
        else
            return a.topicId.localeCompare(b.topicId);
    }
    exports.vgs_RTqa_PaperRela_SortFun_Defa_2Fld = vgs_RTqa_PaperRela_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vgs_RTqa_PaperRela_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_mId:
                    return (a, b) => {
                        return a.mId - b.mId;
                    };
                case clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_TopicId:
                    return (a, b) => {
                        return a.topicId.localeCompare(b.topicId);
                    };
                case clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_TopicName:
                    return (a, b) => {
                        return a.topicName.localeCompare(b.topicName);
                    };
                case clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_id_CurrEduCls:
                    return (a, b) => {
                        return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
                    };
                case clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_qa_PaperId:
                    return (a, b) => {
                        return a.qa_PaperId.localeCompare(b.qa_PaperId);
                    };
                case clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_PaperId:
                    return (a, b) => {
                        return a.paperId.localeCompare(b.paperId);
                    };
                case clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_QuestionsCount:
                    return (a, b) => {
                        return a.questionsCount - b.questionsCount;
                    };
                case clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_IsPublic:
                    return (a, b) => {
                        if (a.isPublic == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_IsSubmit:
                    return (a, b) => {
                        if (a.isSubmit == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_PaperTitle:
                    return (a, b) => {
                        return a.paperTitle.localeCompare(b.paperTitle);
                    };
                case clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_AttachmentCount:
                    return (a, b) => {
                        return a.attachmentCount - b.attachmentCount;
                    };
                case clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_AnswerCount:
                    return (a, b) => {
                        return a.answerCount - b.answerCount;
                    };
                case clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_ShareId:
                    return (a, b) => {
                        return a.shareId.localeCompare(b.shareId);
                    };
                case clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_TagsCount:
                    return (a, b) => {
                        return a.tagsCount - b.tagsCount;
                    };
                case clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_UpdDate:
                    return (a, b) => {
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_UpdUser:
                    return (a, b) => {
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_Memo:
                    return (a, b) => {
                        return a.memo.localeCompare(b.memo);
                    };
                case clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_qaUser:
                    return (a, b) => {
                        return a.qaUser.localeCompare(b.qaUser);
                    };
                case clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_qaDate:
                    return (a, b) => {
                        return a.qaDate.localeCompare(b.qaDate);
                    };
                case clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_qaUserName:
                    return (a, b) => {
                        return a.qaUserName.localeCompare(b.qaUserName);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vgs_RTqa_PaperRela]中不存在！(in ${exports.vgs_RTqa_PaperRela_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_mId:
                    return (a, b) => {
                        return b.mId - a.mId;
                    };
                case clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_TopicId:
                    return (a, b) => {
                        return b.topicId.localeCompare(a.topicId);
                    };
                case clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_TopicName:
                    return (a, b) => {
                        return b.topicName.localeCompare(a.topicName);
                    };
                case clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_id_CurrEduCls:
                    return (a, b) => {
                        return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
                    };
                case clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_qa_PaperId:
                    return (a, b) => {
                        return b.qa_PaperId.localeCompare(a.qa_PaperId);
                    };
                case clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_PaperId:
                    return (a, b) => {
                        return b.paperId.localeCompare(a.paperId);
                    };
                case clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_QuestionsCount:
                    return (a, b) => {
                        return b.questionsCount - a.questionsCount;
                    };
                case clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_IsPublic:
                    return (a, b) => {
                        if (b.isPublic == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_IsSubmit:
                    return (a, b) => {
                        if (b.isSubmit == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_PaperTitle:
                    return (a, b) => {
                        return b.paperTitle.localeCompare(a.paperTitle);
                    };
                case clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_AttachmentCount:
                    return (a, b) => {
                        return b.attachmentCount - a.attachmentCount;
                    };
                case clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_AnswerCount:
                    return (a, b) => {
                        return b.answerCount - a.answerCount;
                    };
                case clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_ShareId:
                    return (a, b) => {
                        return b.shareId.localeCompare(a.shareId);
                    };
                case clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_TagsCount:
                    return (a, b) => {
                        return b.tagsCount - a.tagsCount;
                    };
                case clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_UpdDate:
                    return (a, b) => {
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_UpdUser:
                    return (a, b) => {
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_Memo:
                    return (a, b) => {
                        return b.memo.localeCompare(a.memo);
                    };
                case clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_qaUser:
                    return (a, b) => {
                        return b.qaUser.localeCompare(a.qaUser);
                    };
                case clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_qaDate:
                    return (a, b) => {
                        return b.qaDate.localeCompare(a.qaDate);
                    };
                case clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_qaUserName:
                    return (a, b) => {
                        return b.qaUserName.localeCompare(a.qaUserName);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vgs_RTqa_PaperRela]中不存在！(in ${exports.vgs_RTqa_PaperRela_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.vgs_RTqa_PaperRela_SortFunByKey = vgs_RTqa_PaperRela_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function vgs_RTqa_PaperRela_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_mId:
                return (obj) => {
                    return obj.mId === value;
                };
            case clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_TopicId:
                return (obj) => {
                    return obj.topicId === value;
                };
            case clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_TopicName:
                return (obj) => {
                    return obj.topicName === value;
                };
            case clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_id_CurrEduCls:
                return (obj) => {
                    return obj.id_CurrEduCls === value;
                };
            case clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_qa_PaperId:
                return (obj) => {
                    return obj.qa_PaperId === value;
                };
            case clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_PaperId:
                return (obj) => {
                    return obj.paperId === value;
                };
            case clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_QuestionsCount:
                return (obj) => {
                    return obj.questionsCount === value;
                };
            case clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_IsPublic:
                return (obj) => {
                    return obj.isPublic === value;
                };
            case clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_IsSubmit:
                return (obj) => {
                    return obj.isSubmit === value;
                };
            case clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_PaperTitle:
                return (obj) => {
                    return obj.paperTitle === value;
                };
            case clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_AttachmentCount:
                return (obj) => {
                    return obj.attachmentCount === value;
                };
            case clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_AnswerCount:
                return (obj) => {
                    return obj.answerCount === value;
                };
            case clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_ShareId:
                return (obj) => {
                    return obj.shareId === value;
                };
            case clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_TagsCount:
                return (obj) => {
                    return obj.tagsCount === value;
                };
            case clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            case clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_qaUser:
                return (obj) => {
                    return obj.qaUser === value;
                };
            case clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_qaDate:
                return (obj) => {
                    return obj.qaDate === value;
                };
            case clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_qaUserName:
                return (obj) => {
                    return obj.qaUserName === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[vgs_RTqa_PaperRela]中不存在！(in ${exports.vgs_RTqa_PaperRela_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.vgs_RTqa_PaperRela_FilterFunByKey = vgs_RTqa_PaperRela_FilterFunByKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function vgs_RTqa_PaperRela_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_RTqa_PaperRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_RTqa_PaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_RTqa_PaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_RTqa_PaperRela_GetFirstIDAsync = vgs_RTqa_PaperRela_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function vgs_RTqa_PaperRela_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_RTqa_PaperRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_RTqa_PaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_RTqa_PaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_RTqa_PaperRela_GetFirstID = vgs_RTqa_PaperRela_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function vgs_RTqa_PaperRela_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_RTqa_PaperRela_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vgs_RTqa_PaperRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objvgs_RTqa_PaperRela = vgs_RTqa_PaperRela_GetObjFromJsonObj(returnObj);
                return objvgs_RTqa_PaperRela;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_RTqa_PaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_RTqa_PaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_RTqa_PaperRela_GetFirstObjAsync = vgs_RTqa_PaperRela_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vgs_RTqa_PaperRela_GetObjLst_ClientCache(strTopicId) {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("TopicId='{0}'", strTopicId);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN._CurrTabName, strTopicId);
        clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_2.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrvgs_RTqa_PaperRelaExObjLst_Cache = CacheHelper_js_2.CacheHelper.Get(strKey);
            const arrvgs_RTqa_PaperRelaObjLst_T = vgs_RTqa_PaperRela_GetObjLstByJSONObjLst(arrvgs_RTqa_PaperRelaExObjLst_Cache);
            return arrvgs_RTqa_PaperRelaObjLst_T;
        }
        try {
            const arrvgs_RTqa_PaperRelaExObjLst = await vgs_RTqa_PaperRela_GetObjLstAsync(strWhereCond);
            CacheHelper_js_2.CacheHelper.Add(strKey, arrvgs_RTqa_PaperRelaExObjLst);
            const strInfo = (0, clsString_js_1.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvgs_RTqa_PaperRelaExObjLst.length);
            console.log(strInfo);
            return arrvgs_RTqa_PaperRelaExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vgs_RTqa_PaperRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vgs_RTqa_PaperRela_GetObjLst_ClientCache = vgs_RTqa_PaperRela_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vgs_RTqa_PaperRela_GetObjLst_localStorage(strTopicId) {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("TopicId='{0}'", strTopicId);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN._CurrTabName, strTopicId);
        clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrvgs_RTqa_PaperRelaExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrvgs_RTqa_PaperRelaObjLst_T = vgs_RTqa_PaperRela_GetObjLstByJSONObjLst(arrvgs_RTqa_PaperRelaExObjLst_Cache);
            return arrvgs_RTqa_PaperRelaObjLst_T;
        }
        try {
            const arrvgs_RTqa_PaperRelaExObjLst = await vgs_RTqa_PaperRela_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrvgs_RTqa_PaperRelaExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvgs_RTqa_PaperRelaExObjLst.length);
            console.log(strInfo);
            return arrvgs_RTqa_PaperRelaExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vgs_RTqa_PaperRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vgs_RTqa_PaperRela_GetObjLst_localStorage = vgs_RTqa_PaperRela_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vgs_RTqa_PaperRela_GetObjLst_localStorage_PureCache(strTopicId) {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("TopicId='{0}'", strTopicId);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN._CurrTabName, strTopicId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrvgs_RTqa_PaperRelaObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvgs_RTqa_PaperRelaObjLst_Cache;
        }
        else
            return null;
    }
    exports.vgs_RTqa_PaperRela_GetObjLst_localStorage_PureCache = vgs_RTqa_PaperRela_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function vgs_RTqa_PaperRela_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_RTqa_PaperRela_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vgs_RTqa_PaperRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vgs_RTqa_PaperRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_RTqa_PaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_RTqa_PaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_RTqa_PaperRela_GetObjLstAsync = vgs_RTqa_PaperRela_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vgs_RTqa_PaperRela_GetObjLst_sessionStorage(strTopicId) {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("TopicId='{0}'", strTopicId);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN._CurrTabName, strTopicId);
        clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrvgs_RTqa_PaperRelaExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrvgs_RTqa_PaperRelaObjLst_T = vgs_RTqa_PaperRela_GetObjLstByJSONObjLst(arrvgs_RTqa_PaperRelaExObjLst_Cache);
            return arrvgs_RTqa_PaperRelaObjLst_T;
        }
        try {
            const arrvgs_RTqa_PaperRelaExObjLst = await vgs_RTqa_PaperRela_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrvgs_RTqa_PaperRelaExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvgs_RTqa_PaperRelaExObjLst.length);
            console.log(strInfo);
            return arrvgs_RTqa_PaperRelaExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vgs_RTqa_PaperRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vgs_RTqa_PaperRela_GetObjLst_sessionStorage = vgs_RTqa_PaperRela_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vgs_RTqa_PaperRela_GetObjLst_sessionStorage_PureCache(strTopicId) {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("TopicId='{0}'", strTopicId);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN._CurrTabName, strTopicId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrvgs_RTqa_PaperRelaObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvgs_RTqa_PaperRelaObjLst_Cache;
        }
        else
            return null;
    }
    exports.vgs_RTqa_PaperRela_GetObjLst_sessionStorage_PureCache = vgs_RTqa_PaperRela_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vgs_RTqa_PaperRela_GetObjLst_Cache(strTopicId) {
        //const strThisFuncName = "GetObjLst_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strTopicId) == true) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[TopicId]不能为空！");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strTopicId.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strTopicId]的长度:[{0}]不正确！", strTopicId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        let arrvgs_RTqa_PaperRelaObjLst_Cache;
        switch (clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.CacheModeId) {
            case "04": //sessionStorage
                arrvgs_RTqa_PaperRelaObjLst_Cache = await vgs_RTqa_PaperRela_GetObjLst_sessionStorage(strTopicId);
                break;
            case "03": //localStorage
                arrvgs_RTqa_PaperRelaObjLst_Cache = await vgs_RTqa_PaperRela_GetObjLst_localStorage(strTopicId);
                break;
            case "02": //ClientCache
                arrvgs_RTqa_PaperRelaObjLst_Cache = await vgs_RTqa_PaperRela_GetObjLst_ClientCache(strTopicId);
                break;
            default:
                arrvgs_RTqa_PaperRelaObjLst_Cache = await vgs_RTqa_PaperRela_GetObjLst_ClientCache(strTopicId);
                break;
        }
        const arrvgs_RTqa_PaperRelaObjLst = vgs_RTqa_PaperRela_GetObjLstByJSONObjLst(arrvgs_RTqa_PaperRelaObjLst_Cache);
        return arrvgs_RTqa_PaperRelaObjLst_Cache;
    }
    exports.vgs_RTqa_PaperRela_GetObjLst_Cache = vgs_RTqa_PaperRela_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vgs_RTqa_PaperRela_GetObjLst_PureCache(strTopicId) {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrvgs_RTqa_PaperRelaObjLst_Cache;
        switch (clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.CacheModeId) {
            case "04": //sessionStorage
                arrvgs_RTqa_PaperRelaObjLst_Cache = await vgs_RTqa_PaperRela_GetObjLst_sessionStorage_PureCache(strTopicId);
                break;
            case "03": //localStorage
                arrvgs_RTqa_PaperRelaObjLst_Cache = await vgs_RTqa_PaperRela_GetObjLst_localStorage_PureCache(strTopicId);
                break;
            case "02": //ClientCache
                arrvgs_RTqa_PaperRelaObjLst_Cache = null;
                break;
            default:
                arrvgs_RTqa_PaperRelaObjLst_Cache = null;
                break;
        }
        return arrvgs_RTqa_PaperRelaObjLst_Cache;
    }
    exports.vgs_RTqa_PaperRela_GetObjLst_PureCache = vgs_RTqa_PaperRela_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objlngmId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function vgs_RTqa_PaperRela_GetSubObjLst_Cache(objvgs_RTqa_PaperRela_Cond, strTopicId) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrvgs_RTqa_PaperRelaObjLst_Cache = await vgs_RTqa_PaperRela_GetObjLst_Cache(strTopicId);
        let arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRelaObjLst_Cache;
        if (objvgs_RTqa_PaperRela_Cond.sf_FldComparisonOp == null || objvgs_RTqa_PaperRela_Cond.sf_FldComparisonOp == "")
            return arrvgs_RTqa_PaperRela_Sel;
        const dicFldComparisonOp = JSON.parse(objvgs_RTqa_PaperRela_Cond.sf_FldComparisonOp);
        //console.log("clsvgs_RTqa_PaperRelaWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvgs_RTqa_PaperRela_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvgs_RTqa_PaperRela_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrvgs_RTqa_PaperRela_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objvgs_RTqa_PaperRela_Cond), exports.vgs_RTqa_PaperRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vgs_RTqa_PaperRela_GetSubObjLst_Cache = vgs_RTqa_PaperRela_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrmId:关键字列表
    * @returns 对象列表
    **/
    async function vgs_RTqa_PaperRela_GetObjLstBymIdLstAsync(arrmId) {
        const strThisFuncName = "GetObjLstBymIdLstAsync";
        const strAction = "GetObjLstBymIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_RTqa_PaperRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrmId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vgs_RTqa_PaperRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vgs_RTqa_PaperRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_RTqa_PaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_RTqa_PaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_RTqa_PaperRela_GetObjLstBymIdLstAsync = vgs_RTqa_PaperRela_GetObjLstBymIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrlngmIdLst:关键字列表
     * @returns 对象列表
    */
    async function vgs_RTqa_PaperRela_GetObjLstBymIdLst_Cache(arrmIdLst, strTopicId) {
        const strThisFuncName = "GetObjLstBymIdLst_Cache";
        try {
            const arrvgs_RTqa_PaperRelaObjLst_Cache = await vgs_RTqa_PaperRela_GetObjLst_Cache(strTopicId);
            const arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRelaObjLst_Cache.filter(x => arrmIdLst.indexOf(x.mId) > -1);
            return arrvgs_RTqa_PaperRela_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrmIdLst.join(","), exports.vgs_RTqa_PaperRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vgs_RTqa_PaperRela_GetObjLstBymIdLst_Cache = vgs_RTqa_PaperRela_GetObjLstBymIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function vgs_RTqa_PaperRela_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_RTqa_PaperRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vgs_RTqa_PaperRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vgs_RTqa_PaperRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_RTqa_PaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_RTqa_PaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_RTqa_PaperRela_GetTopObjLstAsync = vgs_RTqa_PaperRela_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vgs_RTqa_PaperRela_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_RTqa_PaperRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vgs_RTqa_PaperRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vgs_RTqa_PaperRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_RTqa_PaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_RTqa_PaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_RTqa_PaperRela_GetObjLstByRangeAsync = vgs_RTqa_PaperRela_GetObjLstByRangeAsync;
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
    async function vgs_RTqa_PaperRela_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_RTqa_PaperRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_RTqa_PaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_RTqa_PaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_RTqa_PaperRela_GetObjLstByRange = vgs_RTqa_PaperRela_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function vgs_RTqa_PaperRela_GetObjLstByPager_Cache(objPagerPara, strTopicId) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const arrvgs_RTqa_PaperRelaObjLst_Cache = await vgs_RTqa_PaperRela_GetObjLst_Cache(strTopicId);
        if (arrvgs_RTqa_PaperRelaObjLst_Cache.length == 0)
            return arrvgs_RTqa_PaperRelaObjLst_Cache;
        let arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRelaObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objvgs_RTqa_PaperRela_Cond = new clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvgs_RTqa_PaperRela_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsvgs_RTqa_PaperRelaWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvgs_RTqa_PaperRela_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRela_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvgs_RTqa_PaperRela_Sel.length == 0)
                return arrvgs_RTqa_PaperRela_Sel;
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
                arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRela_Sel.sort(vgs_RTqa_PaperRela_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRela_Sel.sort(objPagerPara.sortFun);
            }
            arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRela_Sel.slice(intStart, intEnd);
            return arrvgs_RTqa_PaperRela_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.vgs_RTqa_PaperRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vgs_RTqa_PaperRela_GetObjLstByPager_Cache = vgs_RTqa_PaperRela_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vgs_RTqa_PaperRela_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_RTqa_PaperRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vgs_RTqa_PaperRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vgs_RTqa_PaperRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_RTqa_PaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_RTqa_PaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_RTqa_PaperRela_GetObjLstByPagerAsync = vgs_RTqa_PaperRela_GetObjLstByPagerAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objlngmId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function vgs_RTqa_PaperRela_IsExistRecord_Cache(objvgs_RTqa_PaperRela_Cond, strTopicId) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrvgs_RTqa_PaperRelaObjLst_Cache = await vgs_RTqa_PaperRela_GetObjLst_Cache(strTopicId);
        if (arrvgs_RTqa_PaperRelaObjLst_Cache == null)
            return false;
        let arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRelaObjLst_Cache;
        if (objvgs_RTqa_PaperRela_Cond.sf_FldComparisonOp == null || objvgs_RTqa_PaperRela_Cond.sf_FldComparisonOp == "")
            return arrvgs_RTqa_PaperRela_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objvgs_RTqa_PaperRela_Cond.sf_FldComparisonOp);
        //console.log("clsvgs_RTqa_PaperRelaWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvgs_RTqa_PaperRela_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvgs_RTqa_PaperRela_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvgs_RTqa_PaperRela_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objvgs_RTqa_PaperRela_Cond), exports.vgs_RTqa_PaperRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.vgs_RTqa_PaperRela_IsExistRecord_Cache = vgs_RTqa_PaperRela_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function vgs_RTqa_PaperRela_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_RTqa_PaperRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_RTqa_PaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_RTqa_PaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_RTqa_PaperRela_IsExistRecordAsync = vgs_RTqa_PaperRela_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param lngmId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function vgs_RTqa_PaperRela_IsExist(lngmId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_RTqa_PaperRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_RTqa_PaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_RTqa_PaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_RTqa_PaperRela_IsExist = vgs_RTqa_PaperRela_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param lngmId:所给的关键字
     * @returns 对象
    */
    async function vgs_RTqa_PaperRela_IsExist_Cache(lngmId, strTopicId) {
        const strThisFuncName = "IsExist_Cache";
        const arrvgs_RTqa_PaperRelaObjLst_Cache = await vgs_RTqa_PaperRela_GetObjLst_Cache(strTopicId);
        if (arrvgs_RTqa_PaperRelaObjLst_Cache == null)
            return false;
        try {
            const arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRelaObjLst_Cache.filter(x => x.mId == lngmId);
            if (arrvgs_RTqa_PaperRela_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", lngmId, exports.vgs_RTqa_PaperRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.vgs_RTqa_PaperRela_IsExist_Cache = vgs_RTqa_PaperRela_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param lngmId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function vgs_RTqa_PaperRela_IsExistAsync(lngmId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_RTqa_PaperRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_RTqa_PaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_RTqa_PaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_RTqa_PaperRela_IsExistAsync = vgs_RTqa_PaperRela_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function vgs_RTqa_PaperRela_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_RTqa_PaperRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_RTqa_PaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_RTqa_PaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_RTqa_PaperRela_GetRecCountByCondAsync = vgs_RTqa_PaperRela_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objvgs_RTqa_PaperRela_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function vgs_RTqa_PaperRela_GetRecCountByCond_Cache(objvgs_RTqa_PaperRela_Cond, strTopicId) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrvgs_RTqa_PaperRelaObjLst_Cache = await vgs_RTqa_PaperRela_GetObjLst_Cache(strTopicId);
        if (arrvgs_RTqa_PaperRelaObjLst_Cache == null)
            return 0;
        let arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRelaObjLst_Cache;
        if (objvgs_RTqa_PaperRela_Cond.sf_FldComparisonOp == null || objvgs_RTqa_PaperRela_Cond.sf_FldComparisonOp == "")
            return arrvgs_RTqa_PaperRela_Sel.length;
        const dicFldComparisonOp = JSON.parse(objvgs_RTqa_PaperRela_Cond.sf_FldComparisonOp);
        //console.log("clsvgs_RTqa_PaperRelaWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvgs_RTqa_PaperRela_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvgs_RTqa_PaperRela_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRela_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvgs_RTqa_PaperRela_Sel = arrvgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrvgs_RTqa_PaperRela_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objvgs_RTqa_PaperRela_Cond), exports.vgs_RTqa_PaperRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.vgs_RTqa_PaperRela_GetRecCountByCond_Cache = vgs_RTqa_PaperRela_GetRecCountByCond_Cache;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function vgs_RTqa_PaperRela_GetWebApiUrl(strController, strAction) {
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
    exports.vgs_RTqa_PaperRela_GetWebApiUrl = vgs_RTqa_PaperRela_GetWebApiUrl;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function vgs_RTqa_PaperRela_ReFreshThisCache(strTopicId) {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN._CurrTabName, strTopicId);
            switch (clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.CacheModeId) {
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
    exports.vgs_RTqa_PaperRela_ReFreshThisCache = vgs_RTqa_PaperRela_ReFreshThisCache;
    /* 该表的下拉框功能没有设置，不需要生成下拉框绑定函数。*/
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vgs_RTqa_PaperRela_GetJSONStrByObj(pobjvgs_RTqa_PaperRelaEN) {
        const strThisFuncName = "GetJSONStrByObj";
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjvgs_RTqa_PaperRelaEN);
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
    exports.vgs_RTqa_PaperRela_GetJSONStrByObj = vgs_RTqa_PaperRela_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function vgs_RTqa_PaperRela_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrvgs_RTqa_PaperRelaObjLst = new Array();
        if (strJSON === "") {
            return arrvgs_RTqa_PaperRelaObjLst;
        }
        try {
            arrvgs_RTqa_PaperRelaObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrvgs_RTqa_PaperRelaObjLst;
        }
        return arrvgs_RTqa_PaperRelaObjLst;
    }
    exports.vgs_RTqa_PaperRela_GetObjLstByJSONStr = vgs_RTqa_PaperRela_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrvgs_RTqa_PaperRelaObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function vgs_RTqa_PaperRela_GetObjLstByJSONObjLst(arrvgs_RTqa_PaperRelaObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrvgs_RTqa_PaperRelaObjLst = new Array();
        for (const objInFor of arrvgs_RTqa_PaperRelaObjLstS) {
            const obj1 = vgs_RTqa_PaperRela_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrvgs_RTqa_PaperRelaObjLst.push(obj1);
        }
        return arrvgs_RTqa_PaperRelaObjLst;
    }
    exports.vgs_RTqa_PaperRela_GetObjLstByJSONObjLst = vgs_RTqa_PaperRela_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vgs_RTqa_PaperRela_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjvgs_RTqa_PaperRelaEN = new clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN();
        if (strJSON === "") {
            return pobjvgs_RTqa_PaperRelaEN;
        }
        try {
            pobjvgs_RTqa_PaperRelaEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjvgs_RTqa_PaperRelaEN;
        }
        return pobjvgs_RTqa_PaperRelaEN;
    }
    exports.vgs_RTqa_PaperRela_GetObjByJSONStr = vgs_RTqa_PaperRela_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function vgs_RTqa_PaperRela_GetCombineCondition(objvgs_RTqa_PaperRela_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objvgs_RTqa_PaperRela_Cond.dicFldComparisonOp, clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_mId) == true) {
            const strComparisonOp_mId = objvgs_RTqa_PaperRela_Cond.dicFldComparisonOp[clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_mId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_mId, objvgs_RTqa_PaperRela_Cond.mId, strComparisonOp_mId);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_RTqa_PaperRela_Cond.dicFldComparisonOp, clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_TopicId) == true) {
            const strComparisonOp_TopicId = objvgs_RTqa_PaperRela_Cond.dicFldComparisonOp[clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_TopicId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_TopicId, objvgs_RTqa_PaperRela_Cond.topicId, strComparisonOp_TopicId);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_RTqa_PaperRela_Cond.dicFldComparisonOp, clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_TopicName) == true) {
            const strComparisonOp_TopicName = objvgs_RTqa_PaperRela_Cond.dicFldComparisonOp[clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_TopicName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_TopicName, objvgs_RTqa_PaperRela_Cond.topicName, strComparisonOp_TopicName);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_RTqa_PaperRela_Cond.dicFldComparisonOp, clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_id_CurrEduCls) == true) {
            const strComparisonOp_id_CurrEduCls = objvgs_RTqa_PaperRela_Cond.dicFldComparisonOp[clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_id_CurrEduCls];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_id_CurrEduCls, objvgs_RTqa_PaperRela_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_RTqa_PaperRela_Cond.dicFldComparisonOp, clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_qa_PaperId) == true) {
            const strComparisonOp_qa_PaperId = objvgs_RTqa_PaperRela_Cond.dicFldComparisonOp[clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_qa_PaperId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_qa_PaperId, objvgs_RTqa_PaperRela_Cond.qa_PaperId, strComparisonOp_qa_PaperId);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_RTqa_PaperRela_Cond.dicFldComparisonOp, clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_PaperId) == true) {
            const strComparisonOp_PaperId = objvgs_RTqa_PaperRela_Cond.dicFldComparisonOp[clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_PaperId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_PaperId, objvgs_RTqa_PaperRela_Cond.paperId, strComparisonOp_PaperId);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_RTqa_PaperRela_Cond.dicFldComparisonOp, clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_QuestionsCount) == true) {
            const strComparisonOp_QuestionsCount = objvgs_RTqa_PaperRela_Cond.dicFldComparisonOp[clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_QuestionsCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_QuestionsCount, objvgs_RTqa_PaperRela_Cond.questionsCount, strComparisonOp_QuestionsCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_RTqa_PaperRela_Cond.dicFldComparisonOp, clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_IsPublic) == true) {
            if (objvgs_RTqa_PaperRela_Cond.isPublic == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_IsPublic);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_IsPublic);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_RTqa_PaperRela_Cond.dicFldComparisonOp, clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_IsSubmit) == true) {
            if (objvgs_RTqa_PaperRela_Cond.isSubmit == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_IsSubmit);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_IsSubmit);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_RTqa_PaperRela_Cond.dicFldComparisonOp, clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_PaperTitle) == true) {
            const strComparisonOp_PaperTitle = objvgs_RTqa_PaperRela_Cond.dicFldComparisonOp[clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_PaperTitle];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_PaperTitle, objvgs_RTqa_PaperRela_Cond.paperTitle, strComparisonOp_PaperTitle);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_RTqa_PaperRela_Cond.dicFldComparisonOp, clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_AttachmentCount) == true) {
            const strComparisonOp_AttachmentCount = objvgs_RTqa_PaperRela_Cond.dicFldComparisonOp[clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_AttachmentCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_AttachmentCount, objvgs_RTqa_PaperRela_Cond.attachmentCount, strComparisonOp_AttachmentCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_RTqa_PaperRela_Cond.dicFldComparisonOp, clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_AnswerCount) == true) {
            const strComparisonOp_AnswerCount = objvgs_RTqa_PaperRela_Cond.dicFldComparisonOp[clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_AnswerCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_AnswerCount, objvgs_RTqa_PaperRela_Cond.answerCount, strComparisonOp_AnswerCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_RTqa_PaperRela_Cond.dicFldComparisonOp, clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_ShareId) == true) {
            const strComparisonOp_ShareId = objvgs_RTqa_PaperRela_Cond.dicFldComparisonOp[clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_ShareId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_ShareId, objvgs_RTqa_PaperRela_Cond.shareId, strComparisonOp_ShareId);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_RTqa_PaperRela_Cond.dicFldComparisonOp, clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_TagsCount) == true) {
            const strComparisonOp_TagsCount = objvgs_RTqa_PaperRela_Cond.dicFldComparisonOp[clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_TagsCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_TagsCount, objvgs_RTqa_PaperRela_Cond.tagsCount, strComparisonOp_TagsCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_RTqa_PaperRela_Cond.dicFldComparisonOp, clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objvgs_RTqa_PaperRela_Cond.dicFldComparisonOp[clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_UpdDate, objvgs_RTqa_PaperRela_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_RTqa_PaperRela_Cond.dicFldComparisonOp, clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objvgs_RTqa_PaperRela_Cond.dicFldComparisonOp[clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_UpdUser];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_UpdUser, objvgs_RTqa_PaperRela_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_RTqa_PaperRela_Cond.dicFldComparisonOp, clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_Memo) == true) {
            const strComparisonOp_Memo = objvgs_RTqa_PaperRela_Cond.dicFldComparisonOp[clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_Memo, objvgs_RTqa_PaperRela_Cond.memo, strComparisonOp_Memo);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_RTqa_PaperRela_Cond.dicFldComparisonOp, clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_qaUser) == true) {
            const strComparisonOp_qaUser = objvgs_RTqa_PaperRela_Cond.dicFldComparisonOp[clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_qaUser];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_qaUser, objvgs_RTqa_PaperRela_Cond.qaUser, strComparisonOp_qaUser);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_RTqa_PaperRela_Cond.dicFldComparisonOp, clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_qaDate) == true) {
            const strComparisonOp_qaDate = objvgs_RTqa_PaperRela_Cond.dicFldComparisonOp[clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_qaDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_qaDate, objvgs_RTqa_PaperRela_Cond.qaDate, strComparisonOp_qaDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_RTqa_PaperRela_Cond.dicFldComparisonOp, clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_qaUserName) == true) {
            const strComparisonOp_qaUserName = objvgs_RTqa_PaperRela_Cond.dicFldComparisonOp[clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_qaUserName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN.con_qaUserName, objvgs_RTqa_PaperRela_Cond.qaUserName, strComparisonOp_qaUserName);
        }
        return strWhereCond;
    }
    exports.vgs_RTqa_PaperRela_GetCombineCondition = vgs_RTqa_PaperRela_GetCombineCondition;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objvgs_RTqa_PaperRelaENS:源对象
     * @param objvgs_RTqa_PaperRelaENT:目标对象
    */
    function vgs_RTqa_PaperRela_CopyObjTo(objvgs_RTqa_PaperRelaENS, objvgs_RTqa_PaperRelaENT) {
        objvgs_RTqa_PaperRelaENT.mId = objvgs_RTqa_PaperRelaENS.mId; //mId
        objvgs_RTqa_PaperRelaENT.topicId = objvgs_RTqa_PaperRelaENS.topicId; //主题Id
        objvgs_RTqa_PaperRelaENT.topicName = objvgs_RTqa_PaperRelaENS.topicName; //栏目主题
        objvgs_RTqa_PaperRelaENT.id_CurrEduCls = objvgs_RTqa_PaperRelaENS.id_CurrEduCls; //教学班流水号
        objvgs_RTqa_PaperRelaENT.qa_PaperId = objvgs_RTqa_PaperRelaENS.qa_PaperId; //论文答疑Id
        objvgs_RTqa_PaperRelaENT.paperId = objvgs_RTqa_PaperRelaENS.paperId; //论文Id
        objvgs_RTqa_PaperRelaENT.questionsCount = objvgs_RTqa_PaperRelaENS.questionsCount; //提问计数
        objvgs_RTqa_PaperRelaENT.isPublic = objvgs_RTqa_PaperRelaENS.isPublic; //是否公开
        objvgs_RTqa_PaperRelaENT.isSubmit = objvgs_RTqa_PaperRelaENS.isSubmit; //是否提交
        objvgs_RTqa_PaperRelaENT.paperTitle = objvgs_RTqa_PaperRelaENS.paperTitle; //论文标题
        objvgs_RTqa_PaperRelaENT.attachmentCount = objvgs_RTqa_PaperRelaENS.attachmentCount; //附件计数
        objvgs_RTqa_PaperRelaENT.answerCount = objvgs_RTqa_PaperRelaENS.answerCount; //回答计数
        objvgs_RTqa_PaperRelaENT.shareId = objvgs_RTqa_PaperRelaENS.shareId; //分享Id
        objvgs_RTqa_PaperRelaENT.tagsCount = objvgs_RTqa_PaperRelaENS.tagsCount; //论文标注数
        objvgs_RTqa_PaperRelaENT.updDate = objvgs_RTqa_PaperRelaENS.updDate; //修改日期
        objvgs_RTqa_PaperRelaENT.updUser = objvgs_RTqa_PaperRelaENS.updUser; //修改人
        objvgs_RTqa_PaperRelaENT.memo = objvgs_RTqa_PaperRelaENS.memo; //备注
        objvgs_RTqa_PaperRelaENT.qaUser = objvgs_RTqa_PaperRelaENS.qaUser; //qaUser
        objvgs_RTqa_PaperRelaENT.qaDate = objvgs_RTqa_PaperRelaENS.qaDate; //qaDate
        objvgs_RTqa_PaperRelaENT.qaUserName = objvgs_RTqa_PaperRelaENS.qaUserName; //qaUserName
    }
    exports.vgs_RTqa_PaperRela_CopyObjTo = vgs_RTqa_PaperRela_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objvgs_RTqa_PaperRelaENS:源对象
     * @param objvgs_RTqa_PaperRelaENT:目标对象
    */
    function vgs_RTqa_PaperRela_GetObjFromJsonObj(objvgs_RTqa_PaperRelaENS) {
        const objvgs_RTqa_PaperRelaENT = new clsvgs_RTqa_PaperRelaEN_js_1.clsvgs_RTqa_PaperRelaEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvgs_RTqa_PaperRelaENT, objvgs_RTqa_PaperRelaENS);
        return objvgs_RTqa_PaperRelaENT;
    }
    exports.vgs_RTqa_PaperRela_GetObjFromJsonObj = vgs_RTqa_PaperRela_GetObjFromJsonObj;
});
