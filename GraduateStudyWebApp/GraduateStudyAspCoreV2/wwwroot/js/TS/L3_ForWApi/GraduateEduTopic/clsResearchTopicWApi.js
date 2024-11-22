/**
* 类名:clsResearchTopicWApi
* 表名:ResearchTopic(01120546)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/13 00:49:03
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
        define(["require", "exports", "axios", "../../PubFun/enumComparisonOp.js", "../../PubFun/CacheHelper.js", "../../L0_Entity/GraduateEduTopic/clsResearchTopicEN.js", "../../L3_ForWApi/GraduateEduTopic/clsvResearchTopicWApi.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.ResearchTopic_GetObjFromJsonObj = exports.ResearchTopic_CopyObjTo = exports.ResearchTopic_GetUniCondStr4Update_TopicId = exports.ResearchTopic_GetUniCondStr_TopicId = exports.ResearchTopic_GetCombineCondition = exports.ResearchTopic_GetObjByJSONStr = exports.ResearchTopic_GetObjLstByJSONObjLst = exports.ResearchTopic_GetObjLstByJSONStr = exports.ResearchTopic_GetJSONStrByObj = exports.ResearchTopic_CheckProperty4Update = exports.ResearchTopic_CheckPropertyNew = exports.ResearchTopic_BindDdl_TopicIdInDiv_Cache = exports.ResearchTopic_ReFreshThisCache = exports.ResearchTopic_ReFreshCache = exports.ResearchTopic_GetWebApiUrl = exports.ResearchTopic_GetMaxStrIdByPrefix = exports.ResearchTopic_GetMaxStrIdAsync = exports.ResearchTopic_GetRecCountByCond_Cache = exports.ResearchTopic_GetRecCountByCondAsync = exports.ResearchTopic_IsExistAsync = exports.ResearchTopic_IsExist_Cache = exports.ResearchTopic_IsExist = exports.ResearchTopic_IsExistRecordAsync = exports.ResearchTopic_IsExistRecord_Cache = exports.ResearchTopic_UpdateWithConditionAsync = exports.ResearchTopic_UpdateRecordAsync = exports.ResearchTopic_AddNewRecordWithReturnKey = exports.ResearchTopic_AddNewRecordWithReturnKeyAsync = exports.ResearchTopic_ReOrderAsync = exports.ResearchTopic_GoBottomAsync = exports.ResearchTopic_DownMoveAsync = exports.ResearchTopic_UpMoveAsync = exports.ResearchTopic_GoTopAsync = exports.ResearchTopic_AddNewRecordWithMaxIdAsync = exports.ResearchTopic_AddNewRecordAsync = exports.ResearchTopic_DelResearchTopicsByCondAsync = exports.ResearchTopic_DelResearchTopicsAsync = exports.ResearchTopic_DelRecordAsync = exports.ResearchTopic_GetObjLstByPagerAsync = exports.ResearchTopic_GetObjLstByPager_Cache = exports.ResearchTopic_GetObjLstByRange = exports.ResearchTopic_GetObjLstByRangeAsync = exports.ResearchTopic_GetTopObjLstAsync = exports.ResearchTopic_GetObjLstByTopicIdLst_Cache = exports.ResearchTopic_GetObjLstByTopicIdLstAsync = exports.ResearchTopic_GetSubObjLst_Cache = exports.ResearchTopic_GetObjLst_PureCache = exports.ResearchTopic_GetObjLst_Cache = exports.ResearchTopic_GetObjLst_sessionStorage_PureCache = exports.ResearchTopic_GetObjLst_sessionStorage = exports.ResearchTopic_GetObjLstAsync = exports.ResearchTopic_GetObjLst_localStorage_PureCache = exports.ResearchTopic_GetObjLst_localStorage = exports.ResearchTopic_GetObjLst_ClientCache = exports.ResearchTopic_GetFirstObjAsync = exports.ResearchTopic_GetFirstID = exports.ResearchTopic_GetFirstIDAsync = exports.ResearchTopic_funcKey = exports.ResearchTopic_FilterFunByKey = exports.ResearchTopic_SortFunByKey = exports.ResearchTopic_SortFun_Defa_2Fld = exports.ResearchTopic_SortFun_Defa = exports.ResearchTopic_func = exports.ResearchTopic_UpdateObjInLst_Cache = exports.ResearchTopic_GetObjByTopicId_localStorage = exports.ResearchTopic_GetObjByTopicId_Cache = exports.ResearchTopic_GetObjByTopicIdAsync = exports.researchTopic_ConstructorName = exports.researchTopic_Controller = void 0;
    /**
     * 研究主题(ResearchTopic)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月13日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const enumComparisonOp_js_1 = require("../../PubFun/enumComparisonOp.js");
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsResearchTopicEN_js_1 = require("../../L0_Entity/GraduateEduTopic/clsResearchTopicEN.js");
    const clsvResearchTopicWApi_js_1 = require("../../L3_ForWApi/GraduateEduTopic/clsvResearchTopicWApi.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsString_js_2 = require("../../PubFun/clsString.js");
    exports.researchTopic_Controller = "ResearchTopicApi";
    exports.researchTopic_ConstructorName = "researchTopic";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strTopicId:关键字
    * @returns 对象
    **/
    async function ResearchTopic_GetObjByTopicIdAsync(strTopicId) {
        const strThisFuncName = "GetObjByTopicIdAsync";
        if ((0, clsString_js_2.IsNullOrEmpty)(strTopicId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strTopicId]不能为空！(In clsResearchTopicWApi.GetObjByTopicIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strTopicId.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strTopicId]的长度:[{0}]不正确！(clsResearchTopicWApi.GetObjByTopicIdAsync)", strTopicId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByTopicId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.researchTopic_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "strTopicId": strTopicId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    return null;
                }
                //console.log(returnObj);
                const objResearchTopic = ResearchTopic_GetObjFromJsonObj(returnObj);
                return objResearchTopic;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.researchTopic_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.researchTopic_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ResearchTopic_GetObjByTopicIdAsync = ResearchTopic_GetObjByTopicIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param strTopicId:所给的关键字
     * @returns 对象
    */
    async function ResearchTopic_GetObjByTopicId_Cache(strTopicId, strid_CurrEduCls, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByTopicId_Cache";
        if ((0, clsString_js_2.IsNullOrEmpty)(strTopicId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strTopicId]不能为空！(In clsResearchTopicWApi.GetObjByTopicId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strTopicId.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strTopicId]的长度:[{0}]不正确！(clsResearchTopicWApi.GetObjByTopicId_Cache)", strTopicId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrResearchTopicObjLst_Cache = await ResearchTopic_GetObjLst_Cache(strid_CurrEduCls);
        try {
            const arrResearchTopic_Sel = arrResearchTopicObjLst_Cache.filter(x => x.topicId == strTopicId);
            let objResearchTopic;
            if (arrResearchTopic_Sel.length > 0) {
                objResearchTopic = arrResearchTopic_Sel[0];
                return objResearchTopic;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    const objResearchTopic_Const = await ResearchTopic_GetObjByTopicIdAsync(strTopicId);
                    if (objResearchTopic_Const != null) {
                        ResearchTopic_ReFreshThisCache(strid_CurrEduCls);
                        return objResearchTopic_Const;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strTopicId, exports.researchTopic_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.ResearchTopic_GetObjByTopicId_Cache = ResearchTopic_GetObjByTopicId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param strTopicId:所给的关键字
     * @returns 对象
    */
    async function ResearchTopic_GetObjByTopicId_localStorage(strTopicId) {
        const strThisFuncName = "GetObjByTopicId_localStorage";
        if ((0, clsString_js_2.IsNullOrEmpty)(strTopicId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strTopicId]不能为空！(In clsResearchTopicWApi.GetObjByTopicId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strTopicId.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strTopicId]的长度:[{0}]不正确！(clsResearchTopicWApi.GetObjByTopicId_localStorage)", strTopicId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsResearchTopicEN_js_1.clsResearchTopicEN._CurrTabName, strTopicId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objResearchTopic_Cache = JSON.parse(strTempObj);
            return objResearchTopic_Cache;
        }
        try {
            const objResearchTopic = await ResearchTopic_GetObjByTopicIdAsync(strTopicId);
            if (objResearchTopic != null) {
                localStorage.setItem(strKey, JSON.stringify(objResearchTopic));
                const strInfo = (0, clsString_js_2.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objResearchTopic;
            }
            return objResearchTopic;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strTopicId, exports.researchTopic_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.ResearchTopic_GetObjByTopicId_localStorage = ResearchTopic_GetObjByTopicId_localStorage;
    /**
     * 修改在缓存对象列表中的对象, 与后台数据库无关.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
     * @param objResearchTopic:所给的对象
     * @returns 对象
    */
    async function ResearchTopic_UpdateObjInLst_Cache(objResearchTopic, strid_CurrEduCls) {
        const strThisFuncName = "UpdateObjInLst_Cache";
        try {
            const arrResearchTopicObjLst_Cache = await ResearchTopic_GetObjLst_Cache(strid_CurrEduCls);
            const obj = arrResearchTopicObjLst_Cache.find(x => x.topicId == objResearchTopic.topicId);
            if (obj != null) {
                objResearchTopic.topicId = obj.topicId;
                (0, clsCommFunc4Web_js_1.ObjectAssign)(obj, objResearchTopic);
            }
            else {
                arrResearchTopicObjLst_Cache.push(objResearchTopic);
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, exports.researchTopic_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.ResearchTopic_UpdateObjInLst_Cache = ResearchTopic_UpdateObjInLst_Cache;
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
    async function ResearchTopic_func(strInFldName, strOutFldName, strInValue, strid_CurrEduCls_C) {
        //const strThisFuncName = "func";
        if ((0, clsString_js_2.IsNullOrEmpty)(strid_CurrEduCls_C) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strid_CurrEduCls_C]不能为空！(In clsResearchTopicWApi.func)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls_C.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strid_CurrEduCls_C]的长度:[{0}]不正确！(clsResearchTopicWApi.func)", strid_CurrEduCls_C.length);
            console.error(strMsg);
            throw (strMsg);
        }
        if (strInFldName != clsResearchTopicEN_js_1.clsResearchTopicEN.con_TopicId) {
            const strMsg = (0, clsString_js_2.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsResearchTopicEN_js_1.clsResearchTopicEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_2.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strOutFldName, clsResearchTopicEN_js_1.clsResearchTopicEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strTopicId = strInValue;
        if ((0, clsString_js_2.IsNullOrEmpty)(strInValue) == true) {
            return "";
        }
        const objResearchTopic = await ResearchTopic_GetObjByTopicId_Cache(strTopicId, strid_CurrEduCls_C);
        if (objResearchTopic == null)
            return "";
        if (objResearchTopic.GetFldValue(strOutFldName) == null)
            return "";
        return objResearchTopic.GetFldValue(strOutFldName).toString();
    }
    exports.ResearchTopic_func = ResearchTopic_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function ResearchTopic_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.topicId.localeCompare(b.topicId);
    }
    exports.ResearchTopic_SortFun_Defa = ResearchTopic_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function ResearchTopic_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.topicName == b.topicName)
            return a.topicContent.localeCompare(b.topicContent);
        else
            return a.topicName.localeCompare(b.topicName);
    }
    exports.ResearchTopic_SortFun_Defa_2Fld = ResearchTopic_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function ResearchTopic_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsResearchTopicEN_js_1.clsResearchTopicEN.con_TopicId:
                    return (a, b) => {
                        return a.topicId.localeCompare(b.topicId);
                    };
                case clsResearchTopicEN_js_1.clsResearchTopicEN.con_TopicName:
                    return (a, b) => {
                        if (a.topicName == null)
                            return -1;
                        if (b.topicName == null)
                            return 1;
                        return a.topicName.localeCompare(b.topicName);
                    };
                case clsResearchTopicEN_js_1.clsResearchTopicEN.con_TopicContent:
                    return (a, b) => {
                        if (a.topicContent == null)
                            return -1;
                        if (b.topicContent == null)
                            return 1;
                        return a.topicContent.localeCompare(b.topicContent);
                    };
                case clsResearchTopicEN_js_1.clsResearchTopicEN.con_TopicProposePeople:
                    return (a, b) => {
                        if (a.topicProposePeople == null)
                            return -1;
                        if (b.topicProposePeople == null)
                            return 1;
                        return a.topicProposePeople.localeCompare(b.topicProposePeople);
                    };
                case clsResearchTopicEN_js_1.clsResearchTopicEN.con_OrderNum:
                    return (a, b) => {
                        return a.orderNum - b.orderNum;
                    };
                case clsResearchTopicEN_js_1.clsResearchTopicEN.con_IsSubmit:
                    return (a, b) => {
                        if (a.isSubmit == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsResearchTopicEN_js_1.clsResearchTopicEN.con_id_CurrEduCls:
                    return (a, b) => {
                        if (a.id_CurrEduCls == null)
                            return -1;
                        if (b.id_CurrEduCls == null)
                            return 1;
                        return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
                    };
                case clsResearchTopicEN_js_1.clsResearchTopicEN.con_ShareId:
                    return (a, b) => {
                        return a.shareId.localeCompare(b.shareId);
                    };
                case clsResearchTopicEN_js_1.clsResearchTopicEN.con_UpdDate:
                    return (a, b) => {
                        if (a.updDate == null)
                            return -1;
                        if (b.updDate == null)
                            return 1;
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsResearchTopicEN_js_1.clsResearchTopicEN.con_UpdUser:
                    return (a, b) => {
                        if (a.updUser == null)
                            return -1;
                        if (b.updUser == null)
                            return 1;
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsResearchTopicEN_js_1.clsResearchTopicEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[ResearchTopic]中不存在！(in ${exports.researchTopic_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsResearchTopicEN_js_1.clsResearchTopicEN.con_TopicId:
                    return (a, b) => {
                        return b.topicId.localeCompare(a.topicId);
                    };
                case clsResearchTopicEN_js_1.clsResearchTopicEN.con_TopicName:
                    return (a, b) => {
                        if (b.topicName == null)
                            return -1;
                        if (a.topicName == null)
                            return 1;
                        return b.topicName.localeCompare(a.topicName);
                    };
                case clsResearchTopicEN_js_1.clsResearchTopicEN.con_TopicContent:
                    return (a, b) => {
                        if (b.topicContent == null)
                            return -1;
                        if (a.topicContent == null)
                            return 1;
                        return b.topicContent.localeCompare(a.topicContent);
                    };
                case clsResearchTopicEN_js_1.clsResearchTopicEN.con_TopicProposePeople:
                    return (a, b) => {
                        if (b.topicProposePeople == null)
                            return -1;
                        if (a.topicProposePeople == null)
                            return 1;
                        return b.topicProposePeople.localeCompare(a.topicProposePeople);
                    };
                case clsResearchTopicEN_js_1.clsResearchTopicEN.con_OrderNum:
                    return (a, b) => {
                        return b.orderNum - a.orderNum;
                    };
                case clsResearchTopicEN_js_1.clsResearchTopicEN.con_IsSubmit:
                    return (a, b) => {
                        if (b.isSubmit == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsResearchTopicEN_js_1.clsResearchTopicEN.con_id_CurrEduCls:
                    return (a, b) => {
                        if (b.id_CurrEduCls == null)
                            return -1;
                        if (a.id_CurrEduCls == null)
                            return 1;
                        return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
                    };
                case clsResearchTopicEN_js_1.clsResearchTopicEN.con_ShareId:
                    return (a, b) => {
                        return b.shareId.localeCompare(a.shareId);
                    };
                case clsResearchTopicEN_js_1.clsResearchTopicEN.con_UpdDate:
                    return (a, b) => {
                        if (b.updDate == null)
                            return -1;
                        if (a.updDate == null)
                            return 1;
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsResearchTopicEN_js_1.clsResearchTopicEN.con_UpdUser:
                    return (a, b) => {
                        if (b.updUser == null)
                            return -1;
                        if (a.updUser == null)
                            return 1;
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsResearchTopicEN_js_1.clsResearchTopicEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[ResearchTopic]中不存在！(in ${exports.researchTopic_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.ResearchTopic_SortFunByKey = ResearchTopic_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function ResearchTopic_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsResearchTopicEN_js_1.clsResearchTopicEN.con_TopicId:
                return (obj) => {
                    return obj.topicId === value;
                };
            case clsResearchTopicEN_js_1.clsResearchTopicEN.con_TopicName:
                return (obj) => {
                    return obj.topicName === value;
                };
            case clsResearchTopicEN_js_1.clsResearchTopicEN.con_TopicContent:
                return (obj) => {
                    return obj.topicContent === value;
                };
            case clsResearchTopicEN_js_1.clsResearchTopicEN.con_TopicProposePeople:
                return (obj) => {
                    return obj.topicProposePeople === value;
                };
            case clsResearchTopicEN_js_1.clsResearchTopicEN.con_OrderNum:
                return (obj) => {
                    return obj.orderNum === value;
                };
            case clsResearchTopicEN_js_1.clsResearchTopicEN.con_IsSubmit:
                return (obj) => {
                    return obj.isSubmit === value;
                };
            case clsResearchTopicEN_js_1.clsResearchTopicEN.con_id_CurrEduCls:
                return (obj) => {
                    return obj.id_CurrEduCls === value;
                };
            case clsResearchTopicEN_js_1.clsResearchTopicEN.con_ShareId:
                return (obj) => {
                    return obj.shareId === value;
                };
            case clsResearchTopicEN_js_1.clsResearchTopicEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsResearchTopicEN_js_1.clsResearchTopicEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsResearchTopicEN_js_1.clsResearchTopicEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[ResearchTopic]中不存在！(in ${exports.researchTopic_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.ResearchTopic_FilterFunByKey = ResearchTopic_FilterFunByKey;
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
    async function ResearchTopic_funcKey(strInFldName, strInValue, strComparisonOp, strid_CurrEduCls_C) {
        //const strThisFuncName = "funcKey";
        if ((0, clsString_js_2.IsNullOrEmpty)(strid_CurrEduCls_C) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strid_CurrEduCls_C]不能为空！(In clsResearchTopicWApi.funcKey)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls_C.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strid_CurrEduCls_C]的长度:[{0}]不正确！(clsResearchTopicWApi.funcKey)", strid_CurrEduCls_C.length);
            console.error(strMsg);
            throw (strMsg);
        }
        if (strInFldName == clsResearchTopicEN_js_1.clsResearchTopicEN.con_TopicId) {
            const strMsg = (0, clsString_js_2.Format)("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(strInValue) == true) {
            return [];
        }
        const arrResearchTopic = await ResearchTopic_GetObjLst_Cache(strid_CurrEduCls_C);
        if (arrResearchTopic == null)
            return [];
        let arrResearchTopic_Sel = arrResearchTopic;
        const strType = typeof (strInValue);
        switch (strType) {
            case "string":
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01: // " = "
                        arrResearchTopic_Sel = arrResearchTopic_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.Like_03:
                        arrResearchTopic_Sel = arrResearchTopic_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.In_04:
                        const arrValues = strInValue.split(',');
                        arrResearchTopic_Sel = arrResearchTopic_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
                        break;
                }
                break;
            case "boolean":
                if (strInValue == null)
                    return [];
                if (strComparisonOp == enumComparisonOp_js_1.enumComparisonOp.Equal_01) {
                    arrResearchTopic_Sel = arrResearchTopic_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                }
                break;
            case "number":
                if (Number(strInValue) == 0)
                    return [];
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01:
                        arrResearchTopic_Sel = arrResearchTopic_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotEqual_02:
                        arrResearchTopic_Sel = arrResearchTopic_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotLessThan_05: //" >= ":
                        arrResearchTopic_Sel = arrResearchTopic_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotGreaterThan_06: //" <= ":
                        arrResearchTopic_Sel = arrResearchTopic_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.GreaterThan_07: //" > ":
                        arrResearchTopic_Sel = arrResearchTopic_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.LessThan_08: //" < ":
                        arrResearchTopic_Sel = arrResearchTopic_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                }
                break;
        }
        if (arrResearchTopic_Sel.length == 0)
            return [];
        return arrResearchTopic_Sel.map(x => x.topicId);
    }
    exports.ResearchTopic_funcKey = ResearchTopic_funcKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function ResearchTopic_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.researchTopic_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.researchTopic_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.researchTopic_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ResearchTopic_GetFirstIDAsync = ResearchTopic_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function ResearchTopic_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.researchTopic_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.researchTopic_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.researchTopic_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ResearchTopic_GetFirstID = ResearchTopic_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function ResearchTopic_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.researchTopic_Controller, strAction);
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
                const objResearchTopic = ResearchTopic_GetObjFromJsonObj(returnObj);
                return objResearchTopic;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.researchTopic_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.researchTopic_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ResearchTopic_GetFirstObjAsync = ResearchTopic_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function ResearchTopic_GetObjLst_ClientCache(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        if ((0, clsString_js_2.IsNullOrEmpty)(clsResearchTopicEN_js_1.clsResearchTopicEN.WhereFormat) == false) {
            strWhereCond = (0, clsString_js_2.Format)(clsResearchTopicEN_js_1.clsResearchTopicEN.WhereFormat, strid_CurrEduCls);
        }
        else {
            strWhereCond = (0, clsString_js_2.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        }
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsResearchTopicEN_js_1.clsResearchTopicEN._CurrTabName, strid_CurrEduCls);
        if ((0, clsString_js_2.IsNullOrEmpty)(clsResearchTopicEN_js_1.clsResearchTopicEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsResearchTopicEN_js_1.clsResearchTopicEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_1.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrResearchTopicExObjLst_Cache = CacheHelper_js_1.CacheHelper.Get(strKey);
            const arrResearchTopicObjLst_T = ResearchTopic_GetObjLstByJSONObjLst(arrResearchTopicExObjLst_Cache);
            return arrResearchTopicObjLst_T;
        }
        try {
            const arrResearchTopicExObjLst = await ResearchTopic_GetObjLstAsync(strWhereCond);
            CacheHelper_js_1.CacheHelper.Add(strKey, arrResearchTopicExObjLst);
            const strInfo = (0, clsString_js_2.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrResearchTopicExObjLst.length);
            console.log(strInfo);
            return arrResearchTopicExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.researchTopic_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.ResearchTopic_GetObjLst_ClientCache = ResearchTopic_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function ResearchTopic_GetObjLst_localStorage(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        if ((0, clsString_js_2.IsNullOrEmpty)(clsResearchTopicEN_js_1.clsResearchTopicEN.WhereFormat) == false) {
            strWhereCond = (0, clsString_js_2.Format)(clsResearchTopicEN_js_1.clsResearchTopicEN.WhereFormat, strid_CurrEduCls);
        }
        else {
            strWhereCond = (0, clsString_js_2.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        }
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsResearchTopicEN_js_1.clsResearchTopicEN._CurrTabName, strid_CurrEduCls);
        if ((0, clsString_js_2.IsNullOrEmpty)(clsResearchTopicEN_js_1.clsResearchTopicEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsResearchTopicEN_js_1.clsResearchTopicEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrResearchTopicExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrResearchTopicObjLst_T = ResearchTopic_GetObjLstByJSONObjLst(arrResearchTopicExObjLst_Cache);
            return arrResearchTopicObjLst_T;
        }
        try {
            const arrResearchTopicExObjLst = await ResearchTopic_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrResearchTopicExObjLst));
            const strInfo = (0, clsString_js_2.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrResearchTopicExObjLst.length);
            console.log(strInfo);
            return arrResearchTopicExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.researchTopic_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.ResearchTopic_GetObjLst_localStorage = ResearchTopic_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function ResearchTopic_GetObjLst_localStorage_PureCache(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_2.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsResearchTopicEN_js_1.clsResearchTopicEN._CurrTabName, strid_CurrEduCls);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrResearchTopicObjLst_Cache = JSON.parse(strTempObjLst);
            return arrResearchTopicObjLst_Cache;
        }
        else
            return null;
    }
    exports.ResearchTopic_GetObjLst_localStorage_PureCache = ResearchTopic_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function ResearchTopic_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.researchTopic_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.researchTopic_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = ResearchTopic_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.researchTopic_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.researchTopic_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ResearchTopic_GetObjLstAsync = ResearchTopic_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function ResearchTopic_GetObjLst_sessionStorage(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        if ((0, clsString_js_2.IsNullOrEmpty)(clsResearchTopicEN_js_1.clsResearchTopicEN.WhereFormat) == false) {
            strWhereCond = (0, clsString_js_2.Format)(clsResearchTopicEN_js_1.clsResearchTopicEN.WhereFormat, strid_CurrEduCls);
        }
        else {
            strWhereCond = (0, clsString_js_2.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        }
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsResearchTopicEN_js_1.clsResearchTopicEN._CurrTabName, strid_CurrEduCls);
        if ((0, clsString_js_2.IsNullOrEmpty)(clsResearchTopicEN_js_1.clsResearchTopicEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsResearchTopicEN_js_1.clsResearchTopicEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrResearchTopicExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrResearchTopicObjLst_T = ResearchTopic_GetObjLstByJSONObjLst(arrResearchTopicExObjLst_Cache);
            return arrResearchTopicObjLst_T;
        }
        try {
            const arrResearchTopicExObjLst = await ResearchTopic_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrResearchTopicExObjLst));
            const strInfo = (0, clsString_js_2.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrResearchTopicExObjLst.length);
            console.log(strInfo);
            return arrResearchTopicExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.researchTopic_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.ResearchTopic_GetObjLst_sessionStorage = ResearchTopic_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function ResearchTopic_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_2.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsResearchTopicEN_js_1.clsResearchTopicEN._CurrTabName, strid_CurrEduCls);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrResearchTopicObjLst_Cache = JSON.parse(strTempObjLst);
            return arrResearchTopicObjLst_Cache;
        }
        else
            return null;
    }
    exports.ResearchTopic_GetObjLst_sessionStorage_PureCache = ResearchTopic_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function ResearchTopic_GetObjLst_Cache(strid_CurrEduCls) {
        //const strThisFuncName = "GetObjLst_Cache";
        if ((0, clsString_js_2.IsNullOrEmpty)(strid_CurrEduCls) == true) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[id_CurrEduCls]不能为空！(in clsResearchTopicWApi.ResearchTopic_GetObjLst_Cache() )");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strid_CurrEduCls]的长度:[{0}]不正确！(in clsResearchTopicWApi.ResearchTopic_GetObjLst_Cache() )", strid_CurrEduCls.length);
            console.error(strMsg);
            throw (strMsg);
        }
        let arrResearchTopicObjLst_Cache;
        switch (clsResearchTopicEN_js_1.clsResearchTopicEN.CacheModeId) {
            case "04": //sessionStorage
                arrResearchTopicObjLst_Cache = await ResearchTopic_GetObjLst_sessionStorage(strid_CurrEduCls);
                break;
            case "03": //localStorage
                arrResearchTopicObjLst_Cache = await ResearchTopic_GetObjLst_localStorage(strid_CurrEduCls);
                break;
            case "02": //ClientCache
                arrResearchTopicObjLst_Cache = await ResearchTopic_GetObjLst_ClientCache(strid_CurrEduCls);
                break;
            default:
                arrResearchTopicObjLst_Cache = await ResearchTopic_GetObjLst_ClientCache(strid_CurrEduCls);
                break;
        }
        const arrResearchTopicObjLst = ResearchTopic_GetObjLstByJSONObjLst(arrResearchTopicObjLst_Cache);
        return arrResearchTopicObjLst_Cache;
    }
    exports.ResearchTopic_GetObjLst_Cache = ResearchTopic_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function ResearchTopic_GetObjLst_PureCache(strid_CurrEduCls) {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrResearchTopicObjLst_Cache;
        switch (clsResearchTopicEN_js_1.clsResearchTopicEN.CacheModeId) {
            case "04": //sessionStorage
                arrResearchTopicObjLst_Cache = await ResearchTopic_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls);
                break;
            case "03": //localStorage
                arrResearchTopicObjLst_Cache = await ResearchTopic_GetObjLst_localStorage_PureCache(strid_CurrEduCls);
                break;
            case "02": //ClientCache
                arrResearchTopicObjLst_Cache = null;
                break;
            default:
                arrResearchTopicObjLst_Cache = null;
                break;
        }
        return arrResearchTopicObjLst_Cache;
    }
    exports.ResearchTopic_GetObjLst_PureCache = ResearchTopic_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objstrTopicId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function ResearchTopic_GetSubObjLst_Cache(objResearchTopic_Cond, strid_CurrEduCls) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrResearchTopicObjLst_Cache = await ResearchTopic_GetObjLst_Cache(strid_CurrEduCls);
        let arrResearchTopic_Sel = arrResearchTopicObjLst_Cache;
        if (objResearchTopic_Cond.sf_FldComparisonOp == null || objResearchTopic_Cond.sf_FldComparisonOp == "")
            return arrResearchTopic_Sel;
        const dicFldComparisonOp = JSON.parse(objResearchTopic_Cond.sf_FldComparisonOp);
        //console.log("clsResearchTopicWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objResearchTopic_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrResearchTopic_Sel = arrResearchTopic_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objResearchTopic_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrResearchTopic_Sel = arrResearchTopic_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrResearchTopic_Sel = arrResearchTopic_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrResearchTopic_Sel = arrResearchTopic_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrResearchTopic_Sel = arrResearchTopic_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrResearchTopic_Sel = arrResearchTopic_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrResearchTopic_Sel = arrResearchTopic_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrResearchTopic_Sel = arrResearchTopic_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrResearchTopic_Sel = arrResearchTopic_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrResearchTopic_Sel = arrResearchTopic_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrResearchTopic_Sel = arrResearchTopic_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrResearchTopic_Sel = arrResearchTopic_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrResearchTopic_Sel = arrResearchTopic_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrResearchTopic_Sel = arrResearchTopic_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrResearchTopic_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objResearchTopic_Cond), exports.researchTopic_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.ResearchTopic_GetSubObjLst_Cache = ResearchTopic_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrTopicId:关键字列表
    * @returns 对象列表
    **/
    async function ResearchTopic_GetObjLstByTopicIdLstAsync(arrTopicId) {
        const strThisFuncName = "GetObjLstByTopicIdLstAsync";
        const strAction = "GetObjLstByTopicIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.researchTopic_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrTopicId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.researchTopic_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = ResearchTopic_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.researchTopic_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.researchTopic_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ResearchTopic_GetObjLstByTopicIdLstAsync = ResearchTopic_GetObjLstByTopicIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrstrTopicIdLst:关键字列表
     * @returns 对象列表
    */
    async function ResearchTopic_GetObjLstByTopicIdLst_Cache(arrTopicIdLst, strid_CurrEduCls) {
        const strThisFuncName = "GetObjLstByTopicIdLst_Cache";
        try {
            const arrResearchTopicObjLst_Cache = await ResearchTopic_GetObjLst_Cache(strid_CurrEduCls);
            const arrResearchTopic_Sel = arrResearchTopicObjLst_Cache.filter(x => arrTopicIdLst.indexOf(x.topicId) > -1);
            return arrResearchTopic_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrTopicIdLst.join(","), exports.researchTopic_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
    }
    exports.ResearchTopic_GetObjLstByTopicIdLst_Cache = ResearchTopic_GetObjLstByTopicIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function ResearchTopic_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.researchTopic_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.researchTopic_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = ResearchTopic_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.researchTopic_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.researchTopic_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ResearchTopic_GetTopObjLstAsync = ResearchTopic_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function ResearchTopic_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.researchTopic_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.researchTopic_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = ResearchTopic_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.researchTopic_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.researchTopic_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ResearchTopic_GetObjLstByRangeAsync = ResearchTopic_GetObjLstByRangeAsync;
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
    async function ResearchTopic_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.researchTopic_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.researchTopic_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.researchTopic_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ResearchTopic_GetObjLstByRange = ResearchTopic_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function ResearchTopic_GetObjLstByPager_Cache(objPagerPara, strid_CurrEduCls) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const arrResearchTopicObjLst_Cache = await ResearchTopic_GetObjLst_Cache(strid_CurrEduCls);
        if (arrResearchTopicObjLst_Cache.length == 0)
            return arrResearchTopicObjLst_Cache;
        let arrResearchTopic_Sel = arrResearchTopicObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objResearchTopic_Cond = new clsResearchTopicEN_js_1.clsResearchTopicEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objResearchTopic_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsResearchTopicWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrResearchTopic_Sel = arrResearchTopic_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objResearchTopic_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrResearchTopic_Sel = arrResearchTopic_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrResearchTopic_Sel = arrResearchTopic_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrResearchTopic_Sel = arrResearchTopic_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrResearchTopic_Sel = arrResearchTopic_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrResearchTopic_Sel = arrResearchTopic_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrResearchTopic_Sel = arrResearchTopic_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrResearchTopic_Sel = arrResearchTopic_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrResearchTopic_Sel = arrResearchTopic_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrResearchTopic_Sel = arrResearchTopic_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrResearchTopic_Sel = arrResearchTopic_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrResearchTopic_Sel = arrResearchTopic_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrResearchTopic_Sel = arrResearchTopic_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrResearchTopic_Sel = arrResearchTopic_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrResearchTopic_Sel = arrResearchTopic_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrResearchTopic_Sel.length == 0)
                return arrResearchTopic_Sel;
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
                arrResearchTopic_Sel = arrResearchTopic_Sel.sort(ResearchTopic_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrResearchTopic_Sel = arrResearchTopic_Sel.sort(objPagerPara.sortFun);
            }
            arrResearchTopic_Sel = arrResearchTopic_Sel.slice(intStart, intEnd);
            return arrResearchTopic_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.researchTopic_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.ResearchTopic_GetObjLstByPager_Cache = ResearchTopic_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function ResearchTopic_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.researchTopic_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.researchTopic_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = ResearchTopic_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.researchTopic_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.researchTopic_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ResearchTopic_GetObjLstByPagerAsync = ResearchTopic_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param strTopicId:关键字
    * @returns 获取删除的结果
    **/
    async function ResearchTopic_DelRecordAsync(strTopicId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.researchTopic_Controller, strAction);
        strUrl = (0, clsString_js_2.Format)("{0}/?Id={1}", strUrl, strTopicId);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.researchTopic_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.researchTopic_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ResearchTopic_DelRecordAsync = ResearchTopic_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrTopicId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function ResearchTopic_DelResearchTopicsAsync(arrTopicId) {
        const strThisFuncName = "DelResearchTopicsAsync";
        const strAction = "DelResearchTopics";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.researchTopic_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrTopicId);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.researchTopic_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.researchTopic_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ResearchTopic_DelResearchTopicsAsync = ResearchTopic_DelResearchTopicsAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function ResearchTopic_DelResearchTopicsByCondAsync(strWhereCond) {
        const strThisFuncName = "DelResearchTopicsByCondAsync";
        const strAction = "DelResearchTopicsByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.researchTopic_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.researchTopic_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.researchTopic_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ResearchTopic_DelResearchTopicsByCondAsync = ResearchTopic_DelResearchTopicsByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objResearchTopicEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function ResearchTopic_AddNewRecordAsync(objResearchTopicEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objResearchTopicEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.researchTopic_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objResearchTopicEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.researchTopic_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.researchTopic_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ResearchTopic_AddNewRecordAsync = ResearchTopic_AddNewRecordAsync;
    /**
    * 调用WebApi来添加记录，关键字用最大关键字，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithMaxIdAsync)
    * @param objResearchTopicEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function ResearchTopic_AddNewRecordWithMaxIdAsync(objResearchTopicEN) {
        const strThisFuncName = "AddNewRecordWithMaxIdAsync";
        const strAction = "AddNewRecordWithMaxId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.researchTopic_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objResearchTopicEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.researchTopic_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.researchTopic_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ResearchTopic_AddNewRecordWithMaxIdAsync = ResearchTopic_AddNewRecordWithMaxIdAsync;
    /**
    * 把所给的关键字列表相关的记录移顶
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GoTopAsync)
    * @param objResearchTopicEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function ResearchTopic_GoTopAsync(objOrderByData) {
        const strThisFuncName = "GoTopAsync";
        let strMsg = "";
        const strAction = "GoTop";
        if (objOrderByData.KeyIdLst.length == 0) {
            strMsg = "根据关键字列表置顶时，给定的关键字值列表不能为空!";
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.researchTopic_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.researchTopic_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.researchTopic_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ResearchTopic_GoTopAsync = ResearchTopic_GoTopAsync;
    /**
    * 把所给的关键字列表相关的记录上移
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpMoveAsync)
    * @param objResearchTopicEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function ResearchTopic_UpMoveAsync(objOrderByData) {
        const strThisFuncName = "UpMoveAsync";
        let strMsg = "";
        const strAction = "UpMove";
        if (objOrderByData.KeyIdLst.length == 0) {
            strMsg = "根据关键字列表上移时，给定的关键字值列表不能为空!";
            throw strMsg;
        }
        //var strJSON = JSON.stringify(objResearchTopicEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.researchTopic_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.researchTopic_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.researchTopic_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ResearchTopic_UpMoveAsync = ResearchTopic_UpMoveAsync;
    /**
    * 把所给的关键字列表相关的记录下移
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DownMoveAsync)
    * @param objResearchTopicEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function ResearchTopic_DownMoveAsync(objOrderByData) {
        const strThisFuncName = "DownMoveAsync";
        let strMsg = "";
        const strAction = "DownMove";
        if (objOrderByData.KeyIdLst.length == 0) {
            strMsg = "根据关键字列表下移时，给定的关键字值列表不能为空!";
            throw strMsg;
        }
        //var strJSON = JSON.stringify(objResearchTopicEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.researchTopic_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.researchTopic_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.researchTopic_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ResearchTopic_DownMoveAsync = ResearchTopic_DownMoveAsync;
    /**
    * 把所给的关键字列表相关的记录移底
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GoBottomAsync)
    * @param objResearchTopicEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function ResearchTopic_GoBottomAsync(objOrderByData) {
        const strThisFuncName = "GoBottomAsync";
        let strMsg = "";
        const strAction = "GoBottom";
        if (objOrderByData.KeyIdLst.length == 0) {
            strMsg = "根据关键字列表置底时，给定的关键字值列表不能为空!";
            throw strMsg;
        }
        //var strJSON = JSON.stringify(objResearchTopicEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.researchTopic_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.researchTopic_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.researchTopic_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ResearchTopic_GoBottomAsync = ResearchTopic_GoBottomAsync;
    /**
    * 把列表记录重序
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReOrderAsync)
    * @param objResearchTopicEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function ResearchTopic_ReOrderAsync(objOrderByData) {
        const strThisFuncName = "ReOrderAsync";
        const strAction = "ReOrder";
        //var strJSON = JSON.stringify(objResearchTopicEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.researchTopic_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.researchTopic_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.researchTopic_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ResearchTopic_ReOrderAsync = ResearchTopic_ReOrderAsync;
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objResearchTopicEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function ResearchTopic_AddNewRecordWithReturnKeyAsync(objResearchTopicEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.researchTopic_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objResearchTopicEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.researchTopic_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.researchTopic_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ResearchTopic_AddNewRecordWithReturnKeyAsync = ResearchTopic_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objResearchTopicEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function ResearchTopic_AddNewRecordWithReturnKey(objResearchTopicEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objResearchTopicEN.topicId === null || objResearchTopicEN.topicId === "") {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.researchTopic_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objResearchTopicEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.researchTopic_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.researchTopic_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ResearchTopic_AddNewRecordWithReturnKey = ResearchTopic_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objResearchTopicEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function ResearchTopic_UpdateRecordAsync(objResearchTopicEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objResearchTopicEN.sf_UpdFldSetStr === undefined || objResearchTopicEN.sf_UpdFldSetStr === null || objResearchTopicEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objResearchTopicEN.topicId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.researchTopic_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objResearchTopicEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.researchTopic_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.researchTopic_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ResearchTopic_UpdateRecordAsync = ResearchTopic_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objResearchTopicEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function ResearchTopic_UpdateWithConditionAsync(objResearchTopicEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objResearchTopicEN.sf_UpdFldSetStr === undefined || objResearchTopicEN.sf_UpdFldSetStr === null || objResearchTopicEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objResearchTopicEN.topicId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.researchTopic_Controller, strAction);
        objResearchTopicEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objResearchTopicEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.researchTopic_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.researchTopic_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ResearchTopic_UpdateWithConditionAsync = ResearchTopic_UpdateWithConditionAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objstrTopicId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function ResearchTopic_IsExistRecord_Cache(objResearchTopic_Cond, strid_CurrEduCls) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrResearchTopicObjLst_Cache = await ResearchTopic_GetObjLst_Cache(strid_CurrEduCls);
        if (arrResearchTopicObjLst_Cache == null)
            return false;
        let arrResearchTopic_Sel = arrResearchTopicObjLst_Cache;
        if (objResearchTopic_Cond.sf_FldComparisonOp == null || objResearchTopic_Cond.sf_FldComparisonOp == "")
            return arrResearchTopic_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objResearchTopic_Cond.sf_FldComparisonOp);
        //console.log("clsResearchTopicWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objResearchTopic_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objResearchTopic_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrResearchTopic_Sel = arrResearchTopic_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrResearchTopic_Sel = arrResearchTopic_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrResearchTopic_Sel = arrResearchTopic_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrResearchTopic_Sel = arrResearchTopic_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrResearchTopic_Sel = arrResearchTopic_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrResearchTopic_Sel = arrResearchTopic_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrResearchTopic_Sel = arrResearchTopic_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrResearchTopic_Sel = arrResearchTopic_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrResearchTopic_Sel = arrResearchTopic_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrResearchTopic_Sel = arrResearchTopic_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrResearchTopic_Sel = arrResearchTopic_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrResearchTopic_Sel = arrResearchTopic_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrResearchTopic_Sel = arrResearchTopic_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrResearchTopic_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objResearchTopic_Cond), exports.researchTopic_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.ResearchTopic_IsExistRecord_Cache = ResearchTopic_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function ResearchTopic_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.researchTopic_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.researchTopic_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.researchTopic_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ResearchTopic_IsExistRecordAsync = ResearchTopic_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strTopicId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function ResearchTopic_IsExist(strTopicId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.researchTopic_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "TopicId": strTopicId,
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.researchTopic_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.researchTopic_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ResearchTopic_IsExist = ResearchTopic_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param strTopicId:所给的关键字
     * @returns 对象
    */
    async function ResearchTopic_IsExist_Cache(strTopicId, strid_CurrEduCls) {
        const strThisFuncName = "IsExist_Cache";
        const arrResearchTopicObjLst_Cache = await ResearchTopic_GetObjLst_Cache(strid_CurrEduCls);
        if (arrResearchTopicObjLst_Cache == null)
            return false;
        try {
            const arrResearchTopic_Sel = arrResearchTopicObjLst_Cache.filter(x => x.topicId == strTopicId);
            if (arrResearchTopic_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strTopicId, exports.researchTopic_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.ResearchTopic_IsExist_Cache = ResearchTopic_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strTopicId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function ResearchTopic_IsExistAsync(strTopicId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.researchTopic_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strTopicId": strTopicId }
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.researchTopic_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.researchTopic_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ResearchTopic_IsExistAsync = ResearchTopic_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function ResearchTopic_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.researchTopic_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.researchTopic_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.researchTopic_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ResearchTopic_GetRecCountByCondAsync = ResearchTopic_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objResearchTopic_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function ResearchTopic_GetRecCountByCond_Cache(objResearchTopic_Cond, strid_CurrEduCls) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrResearchTopicObjLst_Cache = await ResearchTopic_GetObjLst_Cache(strid_CurrEduCls);
        if (arrResearchTopicObjLst_Cache == null)
            return 0;
        let arrResearchTopic_Sel = arrResearchTopicObjLst_Cache;
        if (objResearchTopic_Cond.sf_FldComparisonOp == null || objResearchTopic_Cond.sf_FldComparisonOp == "")
            return arrResearchTopic_Sel.length;
        const dicFldComparisonOp = JSON.parse(objResearchTopic_Cond.sf_FldComparisonOp);
        //console.log("clsResearchTopicWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objResearchTopic_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrResearchTopic_Sel = arrResearchTopic_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objResearchTopic_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrResearchTopic_Sel = arrResearchTopic_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrResearchTopic_Sel = arrResearchTopic_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrResearchTopic_Sel = arrResearchTopic_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrResearchTopic_Sel = arrResearchTopic_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrResearchTopic_Sel = arrResearchTopic_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrResearchTopic_Sel = arrResearchTopic_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrResearchTopic_Sel = arrResearchTopic_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrResearchTopic_Sel = arrResearchTopic_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrResearchTopic_Sel = arrResearchTopic_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrResearchTopic_Sel = arrResearchTopic_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrResearchTopic_Sel = arrResearchTopic_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrResearchTopic_Sel = arrResearchTopic_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrResearchTopic_Sel = arrResearchTopic_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrResearchTopic_Sel = arrResearchTopic_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrResearchTopic_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objResearchTopic_Cond), exports.researchTopic_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.ResearchTopic_GetRecCountByCond_Cache = ResearchTopic_GetRecCountByCond_Cache;
    /**
    * 获取表的最大关键字
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdAsync)
    * @returns 获取表的最大关键字
    **/
    async function ResearchTopic_GetMaxStrIdAsync() {
        const strThisFuncName = "GetMaxStrIdAsync";
        const strAction = "GetMaxStrId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.researchTopic_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.researchTopic_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.researchTopic_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ResearchTopic_GetMaxStrIdAsync = ResearchTopic_GetMaxStrIdAsync;
    /*该表的关键字类型不是字符型带前缀自增，不需要生成获取最大关键字函数！*/
    /**
     * 根据前缀获取当前表关键字值的最大值,再加1,避免重复
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdByPrefix)
     * @param mapParam:参数列表
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 获取当前表关键字值的最大值
    */
    async function ResearchTopic_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.researchTopic_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.researchTopic_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.researchTopic_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ResearchTopic_GetMaxStrIdByPrefix = ResearchTopic_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function ResearchTopic_GetWebApiUrl(strController, strAction) {
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
    exports.ResearchTopic_GetWebApiUrl = ResearchTopic_GetWebApiUrl;
    /**
    * 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshCache)
    **/
    function ResearchTopic_ReFreshCache(strid_CurrEduCls) {
        const strThisFuncName = "ReFreshCache";
        if ((0, clsString_js_2.IsNullOrEmpty)(strid_CurrEduCls) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strid_CurrEduCls]不能为空！(In clsResearchTopicWApi.clsResearchTopicWApi.ReFreshCache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strid_CurrEduCls]的长度:[{0}]不正确！(clsResearchTopicWApi.clsResearchTopicWApi.ReFreshCache)", strid_CurrEduCls.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strMsg = (0, clsString_js_2.Format)("刷新缓存成功！");
        console.trace(strMsg);
        // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsResearchTopicEN_js_1.clsResearchTopicEN._CurrTabName, strid_CurrEduCls);
        switch (clsResearchTopicEN_js_1.clsResearchTopicEN.CacheModeId) {
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
        (0, clsvResearchTopicWApi_js_1.vResearchTopic_ReFreshThisCache)(strid_CurrEduCls);
    }
    exports.ResearchTopic_ReFreshCache = ResearchTopic_ReFreshCache;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function ResearchTopic_ReFreshThisCache(strid_CurrEduCls) {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsResearchTopicEN_js_1.clsResearchTopicEN._CurrTabName, strid_CurrEduCls);
            switch (clsResearchTopicEN_js_1.clsResearchTopicEN.CacheModeId) {
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
    exports.ResearchTopic_ReFreshThisCache = ResearchTopic_ReFreshThisCache;
    /**
     * 绑定基于Web的下拉框,在某一层下的下拉框
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunctionInDiv)
     * @param objDDL:需要绑定当前表的下拉框
     * @param strid_CurrEduCls:教学班流水号
    */
    async function ResearchTopic_BindDdl_TopicIdInDiv_Cache(strDivName, strDdlName, strid_CurrEduCls) {
        const strThisFuncName = "BindDdl_TopicIdInDiv_Cache";
        if ((0, clsString_js_2.IsNullOrEmpty)(strid_CurrEduCls) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strid_CurrEduCls]不能为空！(In clsResearchTopicWApi.BindDdl_TopicIdInDiv)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strid_CurrEduCls]的长度:[{0}]不正确！(clsResearchTopicWApi.BindDdl_TopicIdInDiv)", strid_CurrEduCls.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const objDdl = document.getElementById(strDdlName);
        if (objDdl == null) {
            const strMsg = (0, clsString_js_2.Format)("下拉框：{0} 不存在！(In BindDdl_TopicIdInDiv)", strDdlName);
            alert(strMsg);
            console.error(strMsg);
            throw (strMsg);
        }
        //为数据源于表的下拉框设置内容
        //console.log("开始：BindDdl_TopicIdInDiv_Cache");
        let arrObjLst_Sel = await ResearchTopic_GetObjLst_Cache(strid_CurrEduCls);
        if (arrObjLst_Sel == null)
            return;
        (0, clsCommFunc4Web_js_1.BindDdl_ObjLstInDiv)(strDivName, strDdlName, arrObjLst_Sel, clsResearchTopicEN_js_1.clsResearchTopicEN.con_TopicId, clsResearchTopicEN_js_1.clsResearchTopicEN.con_TopicName, "研究主题");
    }
    exports.ResearchTopic_BindDdl_TopicIdInDiv_Cache = ResearchTopic_BindDdl_TopicIdInDiv_Cache;
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function ResearchTopic_CheckPropertyNew(pobjResearchTopicEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjResearchTopicEN.shareId) === true
            || pobjResearchTopicEN.shareId.toString() === "0") {
            throw new Error("(errid:Watl000058)字段[分享Id]不能为空(In 研究主题)!(clsResearchTopicBL:CheckPropertyNew)");
        }
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjResearchTopicEN.topicId) == false && (0, clsString_js_2.GetStrLen)(pobjResearchTopicEN.topicId) > 8) {
            throw new Error("(errid:Watl000059)字段[主题Id(topicId)]的长度不能超过8(In 研究主题(ResearchTopic))!值:$(pobjResearchTopicEN.topicId)(clsResearchTopicBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjResearchTopicEN.topicName) == false && (0, clsString_js_2.GetStrLen)(pobjResearchTopicEN.topicName) > 200) {
            throw new Error("(errid:Watl000059)字段[栏目主题(topicName)]的长度不能超过200(In 研究主题(ResearchTopic))!值:$(pobjResearchTopicEN.topicName)(clsResearchTopicBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjResearchTopicEN.topicProposePeople) == false && (0, clsString_js_2.GetStrLen)(pobjResearchTopicEN.topicProposePeople) > 50) {
            throw new Error("(errid:Watl000059)字段[主题提出人(topicProposePeople)]的长度不能超过50(In 研究主题(ResearchTopic))!值:$(pobjResearchTopicEN.topicProposePeople)(clsResearchTopicBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjResearchTopicEN.id_CurrEduCls) == false && (0, clsString_js_2.GetStrLen)(pobjResearchTopicEN.id_CurrEduCls) > 8) {
            throw new Error("(errid:Watl000059)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 研究主题(ResearchTopic))!值:$(pobjResearchTopicEN.id_CurrEduCls)(clsResearchTopicBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjResearchTopicEN.shareId) == false && (0, clsString_js_2.GetStrLen)(pobjResearchTopicEN.shareId) > 2) {
            throw new Error("(errid:Watl000059)字段[分享Id(shareId)]的长度不能超过2(In 研究主题(ResearchTopic))!值:$(pobjResearchTopicEN.shareId)(clsResearchTopicBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjResearchTopicEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjResearchTopicEN.updDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 研究主题(ResearchTopic))!值:$(pobjResearchTopicEN.updDate)(clsResearchTopicBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjResearchTopicEN.updUser) == false && (0, clsString_js_2.GetStrLen)(pobjResearchTopicEN.updUser) > 20) {
            throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 研究主题(ResearchTopic))!值:$(pobjResearchTopicEN.updUser)(clsResearchTopicBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjResearchTopicEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjResearchTopicEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 研究主题(ResearchTopic))!值:$(pobjResearchTopicEN.memo)(clsResearchTopicBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjResearchTopicEN.topicId) == false && undefined !== pobjResearchTopicEN.topicId && clsString_js_1.tzDataType.isString(pobjResearchTopicEN.topicId) === false) {
            throw new Error("(errid:Watl000060)字段[主题Id(topicId)]的值:[$(pobjResearchTopicEN.topicId)], 非法，应该为字符型(In 研究主题(ResearchTopic))!(clsResearchTopicBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjResearchTopicEN.topicName) == false && undefined !== pobjResearchTopicEN.topicName && clsString_js_1.tzDataType.isString(pobjResearchTopicEN.topicName) === false) {
            throw new Error("(errid:Watl000060)字段[栏目主题(topicName)]的值:[$(pobjResearchTopicEN.topicName)], 非法，应该为字符型(In 研究主题(ResearchTopic))!(clsResearchTopicBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjResearchTopicEN.topicContent) == false && undefined !== pobjResearchTopicEN.topicContent && clsString_js_1.tzDataType.isString(pobjResearchTopicEN.topicContent) === false) {
            throw new Error("(errid:Watl000060)字段[主题内容(topicContent)]的值:[$(pobjResearchTopicEN.topicContent)], 非法，应该为字符型(In 研究主题(ResearchTopic))!(clsResearchTopicBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjResearchTopicEN.topicProposePeople) == false && undefined !== pobjResearchTopicEN.topicProposePeople && clsString_js_1.tzDataType.isString(pobjResearchTopicEN.topicProposePeople) === false) {
            throw new Error("(errid:Watl000060)字段[主题提出人(topicProposePeople)]的值:[$(pobjResearchTopicEN.topicProposePeople)], 非法，应该为字符型(In 研究主题(ResearchTopic))!(clsResearchTopicBL:CheckPropertyNew)");
        }
        if (null != pobjResearchTopicEN.orderNum && undefined !== pobjResearchTopicEN.orderNum && clsString_js_1.tzDataType.isNumber(pobjResearchTopicEN.orderNum) === false) {
            throw new Error("(errid:Watl000060)字段[序号(orderNum)]的值:[$(pobjResearchTopicEN.orderNum)], 非法，应该为数值型(In 研究主题(ResearchTopic))!(clsResearchTopicBL:CheckPropertyNew)");
        }
        if (null != pobjResearchTopicEN.isSubmit && undefined !== pobjResearchTopicEN.isSubmit && clsString_js_1.tzDataType.isBoolean(pobjResearchTopicEN.isSubmit) === false) {
            throw new Error("(errid:Watl000060)字段[是否提交(isSubmit)]的值:[$(pobjResearchTopicEN.isSubmit)], 非法，应该为布尔型(In 研究主题(ResearchTopic))!(clsResearchTopicBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjResearchTopicEN.id_CurrEduCls) == false && undefined !== pobjResearchTopicEN.id_CurrEduCls && clsString_js_1.tzDataType.isString(pobjResearchTopicEN.id_CurrEduCls) === false) {
            throw new Error("(errid:Watl000060)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjResearchTopicEN.id_CurrEduCls)], 非法，应该为字符型(In 研究主题(ResearchTopic))!(clsResearchTopicBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjResearchTopicEN.shareId) == false && undefined !== pobjResearchTopicEN.shareId && clsString_js_1.tzDataType.isString(pobjResearchTopicEN.shareId) === false) {
            throw new Error("(errid:Watl000060)字段[分享Id(shareId)]的值:[$(pobjResearchTopicEN.shareId)], 非法，应该为字符型(In 研究主题(ResearchTopic))!(clsResearchTopicBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjResearchTopicEN.updDate) == false && undefined !== pobjResearchTopicEN.updDate && clsString_js_1.tzDataType.isString(pobjResearchTopicEN.updDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjResearchTopicEN.updDate)], 非法，应该为字符型(In 研究主题(ResearchTopic))!(clsResearchTopicBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjResearchTopicEN.updUser) == false && undefined !== pobjResearchTopicEN.updUser && clsString_js_1.tzDataType.isString(pobjResearchTopicEN.updUser) === false) {
            throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjResearchTopicEN.updUser)], 非法，应该为字符型(In 研究主题(ResearchTopic))!(clsResearchTopicBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjResearchTopicEN.memo) == false && undefined !== pobjResearchTopicEN.memo && clsString_js_1.tzDataType.isString(pobjResearchTopicEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjResearchTopicEN.memo)], 非法，应该为字符型(In 研究主题(ResearchTopic))!(clsResearchTopicBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjResearchTopicEN.SetIsCheckProperty(true);
    }
    exports.ResearchTopic_CheckPropertyNew = ResearchTopic_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function ResearchTopic_CheckProperty4Update(pobjResearchTopicEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjResearchTopicEN.topicId) == false && (0, clsString_js_2.GetStrLen)(pobjResearchTopicEN.topicId) > 8) {
            throw new Error("(errid:Watl000062)字段[主题Id(topicId)]的长度不能超过8(In 研究主题(ResearchTopic))!值:$(pobjResearchTopicEN.topicId)(clsResearchTopicBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjResearchTopicEN.topicName) == false && (0, clsString_js_2.GetStrLen)(pobjResearchTopicEN.topicName) > 200) {
            throw new Error("(errid:Watl000062)字段[栏目主题(topicName)]的长度不能超过200(In 研究主题(ResearchTopic))!值:$(pobjResearchTopicEN.topicName)(clsResearchTopicBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjResearchTopicEN.topicProposePeople) == false && (0, clsString_js_2.GetStrLen)(pobjResearchTopicEN.topicProposePeople) > 50) {
            throw new Error("(errid:Watl000062)字段[主题提出人(topicProposePeople)]的长度不能超过50(In 研究主题(ResearchTopic))!值:$(pobjResearchTopicEN.topicProposePeople)(clsResearchTopicBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjResearchTopicEN.id_CurrEduCls) == false && (0, clsString_js_2.GetStrLen)(pobjResearchTopicEN.id_CurrEduCls) > 8) {
            throw new Error("(errid:Watl000062)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 研究主题(ResearchTopic))!值:$(pobjResearchTopicEN.id_CurrEduCls)(clsResearchTopicBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjResearchTopicEN.shareId) == false && (0, clsString_js_2.GetStrLen)(pobjResearchTopicEN.shareId) > 2) {
            throw new Error("(errid:Watl000062)字段[分享Id(shareId)]的长度不能超过2(In 研究主题(ResearchTopic))!值:$(pobjResearchTopicEN.shareId)(clsResearchTopicBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjResearchTopicEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjResearchTopicEN.updDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 研究主题(ResearchTopic))!值:$(pobjResearchTopicEN.updDate)(clsResearchTopicBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjResearchTopicEN.updUser) == false && (0, clsString_js_2.GetStrLen)(pobjResearchTopicEN.updUser) > 20) {
            throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 研究主题(ResearchTopic))!值:$(pobjResearchTopicEN.updUser)(clsResearchTopicBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjResearchTopicEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjResearchTopicEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 研究主题(ResearchTopic))!值:$(pobjResearchTopicEN.memo)(clsResearchTopicBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjResearchTopicEN.topicId) == false && undefined !== pobjResearchTopicEN.topicId && clsString_js_1.tzDataType.isString(pobjResearchTopicEN.topicId) === false) {
            throw new Error("(errid:Watl000063)字段[主题Id(topicId)]的值:[$(pobjResearchTopicEN.topicId)], 非法，应该为字符型(In 研究主题(ResearchTopic))!(clsResearchTopicBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjResearchTopicEN.topicName) == false && undefined !== pobjResearchTopicEN.topicName && clsString_js_1.tzDataType.isString(pobjResearchTopicEN.topicName) === false) {
            throw new Error("(errid:Watl000063)字段[栏目主题(topicName)]的值:[$(pobjResearchTopicEN.topicName)], 非法，应该为字符型(In 研究主题(ResearchTopic))!(clsResearchTopicBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjResearchTopicEN.topicContent) == false && undefined !== pobjResearchTopicEN.topicContent && clsString_js_1.tzDataType.isString(pobjResearchTopicEN.topicContent) === false) {
            throw new Error("(errid:Watl000063)字段[主题内容(topicContent)]的值:[$(pobjResearchTopicEN.topicContent)], 非法，应该为字符型(In 研究主题(ResearchTopic))!(clsResearchTopicBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjResearchTopicEN.topicProposePeople) == false && undefined !== pobjResearchTopicEN.topicProposePeople && clsString_js_1.tzDataType.isString(pobjResearchTopicEN.topicProposePeople) === false) {
            throw new Error("(errid:Watl000063)字段[主题提出人(topicProposePeople)]的值:[$(pobjResearchTopicEN.topicProposePeople)], 非法，应该为字符型(In 研究主题(ResearchTopic))!(clsResearchTopicBL:CheckProperty4Update)");
        }
        if (null != pobjResearchTopicEN.orderNum && undefined !== pobjResearchTopicEN.orderNum && clsString_js_1.tzDataType.isNumber(pobjResearchTopicEN.orderNum) === false) {
            throw new Error("(errid:Watl000063)字段[序号(orderNum)]的值:[$(pobjResearchTopicEN.orderNum)], 非法，应该为数值型(In 研究主题(ResearchTopic))!(clsResearchTopicBL:CheckProperty4Update)");
        }
        if (null != pobjResearchTopicEN.isSubmit && undefined !== pobjResearchTopicEN.isSubmit && clsString_js_1.tzDataType.isBoolean(pobjResearchTopicEN.isSubmit) === false) {
            throw new Error("(errid:Watl000063)字段[是否提交(isSubmit)]的值:[$(pobjResearchTopicEN.isSubmit)], 非法，应该为布尔型(In 研究主题(ResearchTopic))!(clsResearchTopicBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjResearchTopicEN.id_CurrEduCls) == false && undefined !== pobjResearchTopicEN.id_CurrEduCls && clsString_js_1.tzDataType.isString(pobjResearchTopicEN.id_CurrEduCls) === false) {
            throw new Error("(errid:Watl000063)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjResearchTopicEN.id_CurrEduCls)], 非法，应该为字符型(In 研究主题(ResearchTopic))!(clsResearchTopicBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjResearchTopicEN.shareId) == false && undefined !== pobjResearchTopicEN.shareId && clsString_js_1.tzDataType.isString(pobjResearchTopicEN.shareId) === false) {
            throw new Error("(errid:Watl000063)字段[分享Id(shareId)]的值:[$(pobjResearchTopicEN.shareId)], 非法，应该为字符型(In 研究主题(ResearchTopic))!(clsResearchTopicBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjResearchTopicEN.updDate) == false && undefined !== pobjResearchTopicEN.updDate && clsString_js_1.tzDataType.isString(pobjResearchTopicEN.updDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjResearchTopicEN.updDate)], 非法，应该为字符型(In 研究主题(ResearchTopic))!(clsResearchTopicBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjResearchTopicEN.updUser) == false && undefined !== pobjResearchTopicEN.updUser && clsString_js_1.tzDataType.isString(pobjResearchTopicEN.updUser) === false) {
            throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjResearchTopicEN.updUser)], 非法，应该为字符型(In 研究主题(ResearchTopic))!(clsResearchTopicBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjResearchTopicEN.memo) == false && undefined !== pobjResearchTopicEN.memo && clsString_js_1.tzDataType.isString(pobjResearchTopicEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjResearchTopicEN.memo)], 非法，应该为字符型(In 研究主题(ResearchTopic))!(clsResearchTopicBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjResearchTopicEN.topicId) === true
            || pobjResearchTopicEN.topicId.toString() === "0") {
            throw new Error("(errid:Watl000064)字段[主题Id]不能为空(In 研究主题)!(clsResearchTopicBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjResearchTopicEN.SetIsCheckProperty(true);
    }
    exports.ResearchTopic_CheckProperty4Update = ResearchTopic_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function ResearchTopic_GetJSONStrByObj(pobjResearchTopicEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjResearchTopicEN.sf_UpdFldSetStr = pobjResearchTopicEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjResearchTopicEN);
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
    exports.ResearchTopic_GetJSONStrByObj = ResearchTopic_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function ResearchTopic_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrResearchTopicObjLst = new Array();
        if (strJSON === "") {
            return arrResearchTopicObjLst;
        }
        try {
            arrResearchTopicObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrResearchTopicObjLst;
        }
        return arrResearchTopicObjLst;
    }
    exports.ResearchTopic_GetObjLstByJSONStr = ResearchTopic_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrResearchTopicObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function ResearchTopic_GetObjLstByJSONObjLst(arrResearchTopicObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrResearchTopicObjLst = new Array();
        for (const objInFor of arrResearchTopicObjLstS) {
            const obj1 = ResearchTopic_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrResearchTopicObjLst.push(obj1);
        }
        return arrResearchTopicObjLst;
    }
    exports.ResearchTopic_GetObjLstByJSONObjLst = ResearchTopic_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function ResearchTopic_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjResearchTopicEN = new clsResearchTopicEN_js_1.clsResearchTopicEN();
        if (strJSON === "") {
            return pobjResearchTopicEN;
        }
        try {
            pobjResearchTopicEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjResearchTopicEN;
        }
        return pobjResearchTopicEN;
    }
    exports.ResearchTopic_GetObjByJSONStr = ResearchTopic_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function ResearchTopic_GetCombineCondition(objResearchTopic_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objResearchTopic_Cond.dicFldComparisonOp, clsResearchTopicEN_js_1.clsResearchTopicEN.con_TopicId) == true) {
            const strComparisonOp_TopicId = objResearchTopic_Cond.dicFldComparisonOp[clsResearchTopicEN_js_1.clsResearchTopicEN.con_TopicId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsResearchTopicEN_js_1.clsResearchTopicEN.con_TopicId, objResearchTopic_Cond.topicId, strComparisonOp_TopicId);
        }
        if (Object.prototype.hasOwnProperty.call(objResearchTopic_Cond.dicFldComparisonOp, clsResearchTopicEN_js_1.clsResearchTopicEN.con_TopicName) == true) {
            const strComparisonOp_TopicName = objResearchTopic_Cond.dicFldComparisonOp[clsResearchTopicEN_js_1.clsResearchTopicEN.con_TopicName];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsResearchTopicEN_js_1.clsResearchTopicEN.con_TopicName, objResearchTopic_Cond.topicName, strComparisonOp_TopicName);
        }
        //数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
        if (Object.prototype.hasOwnProperty.call(objResearchTopic_Cond.dicFldComparisonOp, clsResearchTopicEN_js_1.clsResearchTopicEN.con_TopicProposePeople) == true) {
            const strComparisonOp_TopicProposePeople = objResearchTopic_Cond.dicFldComparisonOp[clsResearchTopicEN_js_1.clsResearchTopicEN.con_TopicProposePeople];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsResearchTopicEN_js_1.clsResearchTopicEN.con_TopicProposePeople, objResearchTopic_Cond.topicProposePeople, strComparisonOp_TopicProposePeople);
        }
        if (Object.prototype.hasOwnProperty.call(objResearchTopic_Cond.dicFldComparisonOp, clsResearchTopicEN_js_1.clsResearchTopicEN.con_OrderNum) == true) {
            const strComparisonOp_OrderNum = objResearchTopic_Cond.dicFldComparisonOp[clsResearchTopicEN_js_1.clsResearchTopicEN.con_OrderNum];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsResearchTopicEN_js_1.clsResearchTopicEN.con_OrderNum, objResearchTopic_Cond.orderNum, strComparisonOp_OrderNum);
        }
        if (Object.prototype.hasOwnProperty.call(objResearchTopic_Cond.dicFldComparisonOp, clsResearchTopicEN_js_1.clsResearchTopicEN.con_IsSubmit) == true) {
            if (objResearchTopic_Cond.isSubmit == true) {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '1'", clsResearchTopicEN_js_1.clsResearchTopicEN.con_IsSubmit);
            }
            else {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '0'", clsResearchTopicEN_js_1.clsResearchTopicEN.con_IsSubmit);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objResearchTopic_Cond.dicFldComparisonOp, clsResearchTopicEN_js_1.clsResearchTopicEN.con_id_CurrEduCls) == true) {
            const strComparisonOp_id_CurrEduCls = objResearchTopic_Cond.dicFldComparisonOp[clsResearchTopicEN_js_1.clsResearchTopicEN.con_id_CurrEduCls];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsResearchTopicEN_js_1.clsResearchTopicEN.con_id_CurrEduCls, objResearchTopic_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
        }
        if (Object.prototype.hasOwnProperty.call(objResearchTopic_Cond.dicFldComparisonOp, clsResearchTopicEN_js_1.clsResearchTopicEN.con_ShareId) == true) {
            const strComparisonOp_ShareId = objResearchTopic_Cond.dicFldComparisonOp[clsResearchTopicEN_js_1.clsResearchTopicEN.con_ShareId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsResearchTopicEN_js_1.clsResearchTopicEN.con_ShareId, objResearchTopic_Cond.shareId, strComparisonOp_ShareId);
        }
        if (Object.prototype.hasOwnProperty.call(objResearchTopic_Cond.dicFldComparisonOp, clsResearchTopicEN_js_1.clsResearchTopicEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objResearchTopic_Cond.dicFldComparisonOp[clsResearchTopicEN_js_1.clsResearchTopicEN.con_UpdDate];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsResearchTopicEN_js_1.clsResearchTopicEN.con_UpdDate, objResearchTopic_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objResearchTopic_Cond.dicFldComparisonOp, clsResearchTopicEN_js_1.clsResearchTopicEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objResearchTopic_Cond.dicFldComparisonOp[clsResearchTopicEN_js_1.clsResearchTopicEN.con_UpdUser];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsResearchTopicEN_js_1.clsResearchTopicEN.con_UpdUser, objResearchTopic_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objResearchTopic_Cond.dicFldComparisonOp, clsResearchTopicEN_js_1.clsResearchTopicEN.con_Memo) == true) {
            const strComparisonOp_Memo = objResearchTopic_Cond.dicFldComparisonOp[clsResearchTopicEN_js_1.clsResearchTopicEN.con_Memo];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsResearchTopicEN_js_1.clsResearchTopicEN.con_Memo, objResearchTopic_Cond.memo, strComparisonOp_Memo);
        }
        return strWhereCond;
    }
    exports.ResearchTopic_GetCombineCondition = ResearchTopic_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--ResearchTopic(研究主题),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param strTopicId: 主题Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function ResearchTopic_GetUniCondStr_TopicId(objResearchTopicEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and TopicId = '{0}'", objResearchTopicEN.topicId);
        return strWhereCond;
    }
    exports.ResearchTopic_GetUniCondStr_TopicId = ResearchTopic_GetUniCondStr_TopicId;
    /**
    *获取唯一性条件串(Uniqueness)--ResearchTopic(研究主题),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param strTopicId: 主题Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function ResearchTopic_GetUniCondStr4Update_TopicId(objResearchTopicEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and TopicId <> '{0}'", objResearchTopicEN.topicId);
        strWhereCond += (0, clsString_js_2.Format)(" and TopicId = '{0}'", objResearchTopicEN.topicId);
        return strWhereCond;
    }
    exports.ResearchTopic_GetUniCondStr4Update_TopicId = ResearchTopic_GetUniCondStr4Update_TopicId;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objResearchTopicENS:源对象
     * @param objResearchTopicENT:目标对象
    */
    function ResearchTopic_CopyObjTo(objResearchTopicENS, objResearchTopicENT) {
        objResearchTopicENT.topicId = objResearchTopicENS.topicId; //主题Id
        objResearchTopicENT.topicName = objResearchTopicENS.topicName; //栏目主题
        objResearchTopicENT.topicContent = objResearchTopicENS.topicContent; //主题内容
        objResearchTopicENT.topicProposePeople = objResearchTopicENS.topicProposePeople; //主题提出人
        objResearchTopicENT.orderNum = objResearchTopicENS.orderNum; //序号
        objResearchTopicENT.isSubmit = objResearchTopicENS.isSubmit; //是否提交
        objResearchTopicENT.id_CurrEduCls = objResearchTopicENS.id_CurrEduCls; //教学班流水号
        objResearchTopicENT.shareId = objResearchTopicENS.shareId; //分享Id
        objResearchTopicENT.updDate = objResearchTopicENS.updDate; //修改日期
        objResearchTopicENT.updUser = objResearchTopicENS.updUser; //修改人
        objResearchTopicENT.memo = objResearchTopicENS.memo; //备注
        objResearchTopicENT.sf_UpdFldSetStr = objResearchTopicENS.updFldString; //sf_UpdFldSetStr
    }
    exports.ResearchTopic_CopyObjTo = ResearchTopic_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objResearchTopicENS:源对象
     * @param objResearchTopicENT:目标对象
    */
    function ResearchTopic_GetObjFromJsonObj(objResearchTopicENS) {
        const objResearchTopicENT = new clsResearchTopicEN_js_1.clsResearchTopicEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objResearchTopicENT, objResearchTopicENS);
        return objResearchTopicENT;
    }
    exports.ResearchTopic_GetObjFromJsonObj = ResearchTopic_GetObjFromJsonObj;
});
