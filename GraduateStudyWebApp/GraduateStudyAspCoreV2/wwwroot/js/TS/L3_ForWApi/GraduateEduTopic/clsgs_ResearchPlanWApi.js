/**
* 类名:clsgs_ResearchPlanWApi
* 表名:gs_ResearchPlan(01120663)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/13 00:49:38
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
        define(["require", "exports", "axios", "../../PubFun/enumComparisonOp.js", "../../PubFun/CacheHelper.js", "../../L0_Entity/GraduateEduTopic/clsgs_ResearchPlanEN.js", "../../L3_ForWApi/GraduateEduTopic/clsvgs_ResearchPlanWApi.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.gs_ResearchPlan_GetObjFromJsonObj = exports.gs_ResearchPlan_CopyObjTo = exports.gs_ResearchPlan_GetUniCondStr4Update_PlanId = exports.gs_ResearchPlan_GetUniCondStr_PlanId = exports.gs_ResearchPlan_GetCombineCondition = exports.gs_ResearchPlan_GetObjByJSONStr = exports.gs_ResearchPlan_GetObjLstByJSONObjLst = exports.gs_ResearchPlan_GetObjLstByJSONStr = exports.gs_ResearchPlan_GetJSONStrByObj = exports.gs_ResearchPlan_CheckProperty4Update = exports.gs_ResearchPlan_CheckPropertyNew = exports.gs_ResearchPlan_ReFreshThisCache = exports.gs_ResearchPlan_ReFreshCache = exports.gs_ResearchPlan_GetWebApiUrl = exports.gs_ResearchPlan_GetMaxStrIdByPrefix = exports.gs_ResearchPlan_GetMaxStrIdAsync = exports.gs_ResearchPlan_GetRecCountByCond_Cache = exports.gs_ResearchPlan_GetRecCountByCondAsync = exports.gs_ResearchPlan_IsExistAsync = exports.gs_ResearchPlan_IsExist_Cache = exports.gs_ResearchPlan_IsExist = exports.gs_ResearchPlan_IsExistRecordAsync = exports.gs_ResearchPlan_IsExistRecord_Cache = exports.gs_ResearchPlan_UpdateWithConditionAsync = exports.gs_ResearchPlan_UpdateRecordAsync = exports.gs_ResearchPlan_AddNewRecordWithReturnKey = exports.gs_ResearchPlan_AddNewRecordWithReturnKeyAsync = exports.gs_ResearchPlan_AddNewRecordWithMaxIdAsync = exports.gs_ResearchPlan_AddNewRecordAsync = exports.gs_ResearchPlan_Delgs_ResearchPlansByCondAsync = exports.gs_ResearchPlan_Delgs_ResearchPlansAsync = exports.gs_ResearchPlan_DelRecordAsync = exports.gs_ResearchPlan_GetObjLstByPagerAsync = exports.gs_ResearchPlan_GetObjLstByPager_Cache = exports.gs_ResearchPlan_GetObjLstByRange = exports.gs_ResearchPlan_GetObjLstByRangeAsync = exports.gs_ResearchPlan_GetTopObjLstAsync = exports.gs_ResearchPlan_GetObjLstByPlanIdLst_Cache = exports.gs_ResearchPlan_GetObjLstByPlanIdLstAsync = exports.gs_ResearchPlan_GetSubObjLst_Cache = exports.gs_ResearchPlan_GetObjLst_PureCache = exports.gs_ResearchPlan_GetObjLst_Cache = exports.gs_ResearchPlan_GetObjLst_sessionStorage_PureCache = exports.gs_ResearchPlan_GetObjLst_sessionStorage = exports.gs_ResearchPlan_GetObjLstAsync = exports.gs_ResearchPlan_GetObjLst_localStorage_PureCache = exports.gs_ResearchPlan_GetObjLst_localStorage = exports.gs_ResearchPlan_GetObjLst_ClientCache = exports.gs_ResearchPlan_GetFirstObjAsync = exports.gs_ResearchPlan_GetFirstID = exports.gs_ResearchPlan_GetFirstIDAsync = exports.gs_ResearchPlan_funcKey = exports.gs_ResearchPlan_FilterFunByKey = exports.gs_ResearchPlan_SortFunByKey = exports.gs_ResearchPlan_SortFun_Defa_2Fld = exports.gs_ResearchPlan_SortFun_Defa = exports.gs_ResearchPlan_func = exports.gs_ResearchPlan_UpdateObjInLst_Cache = exports.gs_ResearchPlan_GetObjByPlanId_localStorage = exports.gs_ResearchPlan_GetObjByPlanId_Cache = exports.gs_ResearchPlan_GetObjByPlanIdAsync = exports.gs_ResearchPlan_ConstructorName = exports.gs_ResearchPlan_Controller = void 0;
    /**
     * 主题研究计划(gs_ResearchPlan)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月13日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const enumComparisonOp_js_1 = require("../../PubFun/enumComparisonOp.js");
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsgs_ResearchPlanEN_js_1 = require("../../L0_Entity/GraduateEduTopic/clsgs_ResearchPlanEN.js");
    const clsvgs_ResearchPlanWApi_js_1 = require("../../L3_ForWApi/GraduateEduTopic/clsvgs_ResearchPlanWApi.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsString_js_2 = require("../../PubFun/clsString.js");
    exports.gs_ResearchPlan_Controller = "gs_ResearchPlanApi";
    exports.gs_ResearchPlan_ConstructorName = "gs_ResearchPlan";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strPlanId:关键字
    * @returns 对象
    **/
    async function gs_ResearchPlan_GetObjByPlanIdAsync(strPlanId) {
        const strThisFuncName = "GetObjByPlanIdAsync";
        if ((0, clsString_js_2.IsNullOrEmpty)(strPlanId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strPlanId]不能为空！(In clsgs_ResearchPlanWApi.GetObjByPlanIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strPlanId.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strPlanId]的长度:[{0}]不正确！(clsgs_ResearchPlanWApi.GetObjByPlanIdAsync)", strPlanId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByPlanId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ResearchPlan_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "strPlanId": strPlanId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    return null;
                }
                //console.log(returnObj);
                const objgs_ResearchPlan = gs_ResearchPlan_GetObjFromJsonObj(returnObj);
                return objgs_ResearchPlan;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ResearchPlan_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ResearchPlan_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ResearchPlan_GetObjByPlanIdAsync = gs_ResearchPlan_GetObjByPlanIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param strPlanId:所给的关键字
     * @returns 对象
    */
    async function gs_ResearchPlan_GetObjByPlanId_Cache(strPlanId, strid_CurrEduCls, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByPlanId_Cache";
        if ((0, clsString_js_2.IsNullOrEmpty)(strPlanId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strPlanId]不能为空！(In clsgs_ResearchPlanWApi.GetObjByPlanId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strPlanId.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strPlanId]的长度:[{0}]不正确！(clsgs_ResearchPlanWApi.GetObjByPlanId_Cache)", strPlanId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrgs_ResearchPlanObjLst_Cache = await gs_ResearchPlan_GetObjLst_Cache(strid_CurrEduCls);
        try {
            const arrgs_ResearchPlan_Sel = arrgs_ResearchPlanObjLst_Cache.filter(x => x.planId == strPlanId);
            let objgs_ResearchPlan;
            if (arrgs_ResearchPlan_Sel.length > 0) {
                objgs_ResearchPlan = arrgs_ResearchPlan_Sel[0];
                return objgs_ResearchPlan;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    const objgs_ResearchPlan_Const = await gs_ResearchPlan_GetObjByPlanIdAsync(strPlanId);
                    if (objgs_ResearchPlan_Const != null) {
                        gs_ResearchPlan_ReFreshThisCache(strid_CurrEduCls);
                        return objgs_ResearchPlan_Const;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strPlanId, exports.gs_ResearchPlan_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.gs_ResearchPlan_GetObjByPlanId_Cache = gs_ResearchPlan_GetObjByPlanId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param strPlanId:所给的关键字
     * @returns 对象
    */
    async function gs_ResearchPlan_GetObjByPlanId_localStorage(strPlanId) {
        const strThisFuncName = "GetObjByPlanId_localStorage";
        if ((0, clsString_js_2.IsNullOrEmpty)(strPlanId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strPlanId]不能为空！(In clsgs_ResearchPlanWApi.GetObjByPlanId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strPlanId.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strPlanId]的长度:[{0}]不正确！(clsgs_ResearchPlanWApi.GetObjByPlanId_localStorage)", strPlanId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN._CurrTabName, strPlanId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objgs_ResearchPlan_Cache = JSON.parse(strTempObj);
            return objgs_ResearchPlan_Cache;
        }
        try {
            const objgs_ResearchPlan = await gs_ResearchPlan_GetObjByPlanIdAsync(strPlanId);
            if (objgs_ResearchPlan != null) {
                localStorage.setItem(strKey, JSON.stringify(objgs_ResearchPlan));
                const strInfo = (0, clsString_js_2.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objgs_ResearchPlan;
            }
            return objgs_ResearchPlan;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strPlanId, exports.gs_ResearchPlan_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.gs_ResearchPlan_GetObjByPlanId_localStorage = gs_ResearchPlan_GetObjByPlanId_localStorage;
    /**
     * 修改在缓存对象列表中的对象, 与后台数据库无关.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
     * @param objgs_ResearchPlan:所给的对象
     * @returns 对象
    */
    async function gs_ResearchPlan_UpdateObjInLst_Cache(objgs_ResearchPlan, strid_CurrEduCls) {
        const strThisFuncName = "UpdateObjInLst_Cache";
        try {
            const arrgs_ResearchPlanObjLst_Cache = await gs_ResearchPlan_GetObjLst_Cache(strid_CurrEduCls);
            const obj = arrgs_ResearchPlanObjLst_Cache.find(x => x.planId == objgs_ResearchPlan.planId);
            if (obj != null) {
                objgs_ResearchPlan.planId = obj.planId;
                (0, clsCommFunc4Web_js_1.ObjectAssign)(obj, objgs_ResearchPlan);
            }
            else {
                arrgs_ResearchPlanObjLst_Cache.push(objgs_ResearchPlan);
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, exports.gs_ResearchPlan_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.gs_ResearchPlan_UpdateObjInLst_Cache = gs_ResearchPlan_UpdateObjInLst_Cache;
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
    async function gs_ResearchPlan_func(strInFldName, strOutFldName, strInValue, strid_CurrEduCls_C) {
        //const strThisFuncName = "func";
        if ((0, clsString_js_2.IsNullOrEmpty)(strid_CurrEduCls_C) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strid_CurrEduCls_C]不能为空！(In clsgs_ResearchPlanWApi.func)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls_C.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strid_CurrEduCls_C]的长度:[{0}]不正确！(clsgs_ResearchPlanWApi.func)", strid_CurrEduCls_C.length);
            console.error(strMsg);
            throw (strMsg);
        }
        if (strInFldName != clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN.con_PlanId) {
            const strMsg = (0, clsString_js_2.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_2.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strOutFldName, clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strPlanId = strInValue;
        if ((0, clsString_js_2.IsNullOrEmpty)(strInValue) == true) {
            return "";
        }
        const objgs_ResearchPlan = await gs_ResearchPlan_GetObjByPlanId_Cache(strPlanId, strid_CurrEduCls_C);
        if (objgs_ResearchPlan == null)
            return "";
        if (objgs_ResearchPlan.GetFldValue(strOutFldName) == null)
            return "";
        return objgs_ResearchPlan.GetFldValue(strOutFldName).toString();
    }
    exports.gs_ResearchPlan_func = gs_ResearchPlan_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function gs_ResearchPlan_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.planId.localeCompare(b.planId);
    }
    exports.gs_ResearchPlan_SortFun_Defa = gs_ResearchPlan_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function gs_ResearchPlan_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.topicId == b.topicId)
            return a.statusId.localeCompare(b.statusId);
        else
            return a.topicId.localeCompare(b.topicId);
    }
    exports.gs_ResearchPlan_SortFun_Defa_2Fld = gs_ResearchPlan_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function gs_ResearchPlan_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN.con_PlanId:
                    return (a, b) => {
                        return a.planId.localeCompare(b.planId);
                    };
                case clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN.con_TopicId:
                    return (a, b) => {
                        return a.topicId.localeCompare(b.topicId);
                    };
                case clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN.con_StatusId:
                    return (a, b) => {
                        return a.statusId.localeCompare(b.statusId);
                    };
                case clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN.con_PlanContent:
                    return (a, b) => {
                        if (a.planContent == null)
                            return -1;
                        if (b.planContent == null)
                            return 1;
                        return a.planContent.localeCompare(b.planContent);
                    };
                case clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN.con_ResponsibleUser:
                    return (a, b) => {
                        if (a.responsibleUser == null)
                            return -1;
                        if (b.responsibleUser == null)
                            return 1;
                        return a.responsibleUser.localeCompare(b.responsibleUser);
                    };
                case clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN.con_StartDate:
                    return (a, b) => {
                        if (a.startDate == null)
                            return -1;
                        if (b.startDate == null)
                            return 1;
                        return a.startDate.localeCompare(b.startDate);
                    };
                case clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN.con_EndDate:
                    return (a, b) => {
                        if (a.endDate == null)
                            return -1;
                        if (b.endDate == null)
                            return 1;
                        return a.endDate.localeCompare(b.endDate);
                    };
                case clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN.con_ActualFinishingDate:
                    return (a, b) => {
                        if (a.actualFinishingDate == null)
                            return -1;
                        if (b.actualFinishingDate == null)
                            return 1;
                        return a.actualFinishingDate.localeCompare(b.actualFinishingDate);
                    };
                case clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN.con_AcceptanceUser:
                    return (a, b) => {
                        if (a.acceptanceUser == null)
                            return -1;
                        if (b.acceptanceUser == null)
                            return 1;
                        return a.acceptanceUser.localeCompare(b.acceptanceUser);
                    };
                case clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN.con_IsSubmit:
                    return (a, b) => {
                        if (a.isSubmit == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN.con_UpdUser:
                    return (a, b) => {
                        if (a.updUser == null)
                            return -1;
                        if (b.updUser == null)
                            return 1;
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN.con_UpdDate:
                    return (a, b) => {
                        if (a.updDate == null)
                            return -1;
                        if (b.updDate == null)
                            return 1;
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                case clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN.con_PlanTypeId:
                    return (a, b) => {
                        if (a.planTypeId == null)
                            return -1;
                        if (b.planTypeId == null)
                            return 1;
                        return a.planTypeId.localeCompare(b.planTypeId);
                    };
                case clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN.con_id_CurrEduCls:
                    return (a, b) => {
                        if (a.id_CurrEduCls == null)
                            return -1;
                        if (b.id_CurrEduCls == null)
                            return 1;
                        return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[gs_ResearchPlan]中不存在！(in ${exports.gs_ResearchPlan_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN.con_PlanId:
                    return (a, b) => {
                        return b.planId.localeCompare(a.planId);
                    };
                case clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN.con_TopicId:
                    return (a, b) => {
                        return b.topicId.localeCompare(a.topicId);
                    };
                case clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN.con_StatusId:
                    return (a, b) => {
                        return b.statusId.localeCompare(a.statusId);
                    };
                case clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN.con_PlanContent:
                    return (a, b) => {
                        if (b.planContent == null)
                            return -1;
                        if (a.planContent == null)
                            return 1;
                        return b.planContent.localeCompare(a.planContent);
                    };
                case clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN.con_ResponsibleUser:
                    return (a, b) => {
                        if (b.responsibleUser == null)
                            return -1;
                        if (a.responsibleUser == null)
                            return 1;
                        return b.responsibleUser.localeCompare(a.responsibleUser);
                    };
                case clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN.con_StartDate:
                    return (a, b) => {
                        if (b.startDate == null)
                            return -1;
                        if (a.startDate == null)
                            return 1;
                        return b.startDate.localeCompare(a.startDate);
                    };
                case clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN.con_EndDate:
                    return (a, b) => {
                        if (b.endDate == null)
                            return -1;
                        if (a.endDate == null)
                            return 1;
                        return b.endDate.localeCompare(a.endDate);
                    };
                case clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN.con_ActualFinishingDate:
                    return (a, b) => {
                        if (b.actualFinishingDate == null)
                            return -1;
                        if (a.actualFinishingDate == null)
                            return 1;
                        return b.actualFinishingDate.localeCompare(a.actualFinishingDate);
                    };
                case clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN.con_AcceptanceUser:
                    return (a, b) => {
                        if (b.acceptanceUser == null)
                            return -1;
                        if (a.acceptanceUser == null)
                            return 1;
                        return b.acceptanceUser.localeCompare(a.acceptanceUser);
                    };
                case clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN.con_IsSubmit:
                    return (a, b) => {
                        if (b.isSubmit == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN.con_UpdUser:
                    return (a, b) => {
                        if (b.updUser == null)
                            return -1;
                        if (a.updUser == null)
                            return 1;
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN.con_UpdDate:
                    return (a, b) => {
                        if (b.updDate == null)
                            return -1;
                        if (a.updDate == null)
                            return 1;
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                case clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN.con_PlanTypeId:
                    return (a, b) => {
                        if (b.planTypeId == null)
                            return -1;
                        if (a.planTypeId == null)
                            return 1;
                        return b.planTypeId.localeCompare(a.planTypeId);
                    };
                case clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN.con_id_CurrEduCls:
                    return (a, b) => {
                        if (b.id_CurrEduCls == null)
                            return -1;
                        if (a.id_CurrEduCls == null)
                            return 1;
                        return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[gs_ResearchPlan]中不存在！(in ${exports.gs_ResearchPlan_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.gs_ResearchPlan_SortFunByKey = gs_ResearchPlan_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function gs_ResearchPlan_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN.con_PlanId:
                return (obj) => {
                    return obj.planId === value;
                };
            case clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN.con_TopicId:
                return (obj) => {
                    return obj.topicId === value;
                };
            case clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN.con_StatusId:
                return (obj) => {
                    return obj.statusId === value;
                };
            case clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN.con_PlanContent:
                return (obj) => {
                    return obj.planContent === value;
                };
            case clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN.con_ResponsibleUser:
                return (obj) => {
                    return obj.responsibleUser === value;
                };
            case clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN.con_StartDate:
                return (obj) => {
                    return obj.startDate === value;
                };
            case clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN.con_EndDate:
                return (obj) => {
                    return obj.endDate === value;
                };
            case clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN.con_ActualFinishingDate:
                return (obj) => {
                    return obj.actualFinishingDate === value;
                };
            case clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN.con_AcceptanceUser:
                return (obj) => {
                    return obj.acceptanceUser === value;
                };
            case clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN.con_IsSubmit:
                return (obj) => {
                    return obj.isSubmit === value;
                };
            case clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            case clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN.con_PlanTypeId:
                return (obj) => {
                    return obj.planTypeId === value;
                };
            case clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN.con_id_CurrEduCls:
                return (obj) => {
                    return obj.id_CurrEduCls === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[gs_ResearchPlan]中不存在！(in ${exports.gs_ResearchPlan_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.gs_ResearchPlan_FilterFunByKey = gs_ResearchPlan_FilterFunByKey;
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
    async function gs_ResearchPlan_funcKey(strInFldName, strInValue, strComparisonOp, strid_CurrEduCls_C) {
        //const strThisFuncName = "funcKey";
        if ((0, clsString_js_2.IsNullOrEmpty)(strid_CurrEduCls_C) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strid_CurrEduCls_C]不能为空！(In clsgs_ResearchPlanWApi.funcKey)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls_C.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strid_CurrEduCls_C]的长度:[{0}]不正确！(clsgs_ResearchPlanWApi.funcKey)", strid_CurrEduCls_C.length);
            console.error(strMsg);
            throw (strMsg);
        }
        if (strInFldName == clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN.con_PlanId) {
            const strMsg = (0, clsString_js_2.Format)("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(strInValue) == true) {
            return [];
        }
        const arrgs_ResearchPlan = await gs_ResearchPlan_GetObjLst_Cache(strid_CurrEduCls_C);
        if (arrgs_ResearchPlan == null)
            return [];
        let arrgs_ResearchPlan_Sel = arrgs_ResearchPlan;
        const strType = typeof (strInValue);
        switch (strType) {
            case "string":
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01: // " = "
                        arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.Like_03:
                        arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.In_04:
                        const arrValues = strInValue.split(',');
                        arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
                        break;
                }
                break;
            case "boolean":
                if (strInValue == null)
                    return [];
                if (strComparisonOp == enumComparisonOp_js_1.enumComparisonOp.Equal_01) {
                    arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                }
                break;
            case "number":
                if (Number(strInValue) == 0)
                    return [];
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01:
                        arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotEqual_02:
                        arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotLessThan_05: //" >= ":
                        arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotGreaterThan_06: //" <= ":
                        arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.GreaterThan_07: //" > ":
                        arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.LessThan_08: //" < ":
                        arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                }
                break;
        }
        if (arrgs_ResearchPlan_Sel.length == 0)
            return [];
        return arrgs_ResearchPlan_Sel.map(x => x.planId);
    }
    exports.gs_ResearchPlan_funcKey = gs_ResearchPlan_funcKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function gs_ResearchPlan_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ResearchPlan_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ResearchPlan_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ResearchPlan_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ResearchPlan_GetFirstIDAsync = gs_ResearchPlan_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function gs_ResearchPlan_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ResearchPlan_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ResearchPlan_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ResearchPlan_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ResearchPlan_GetFirstID = gs_ResearchPlan_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function gs_ResearchPlan_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ResearchPlan_Controller, strAction);
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
                const objgs_ResearchPlan = gs_ResearchPlan_GetObjFromJsonObj(returnObj);
                return objgs_ResearchPlan;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ResearchPlan_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ResearchPlan_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ResearchPlan_GetFirstObjAsync = gs_ResearchPlan_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_ResearchPlan_GetObjLst_ClientCache(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        if ((0, clsString_js_2.IsNullOrEmpty)(clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN.WhereFormat) == false) {
            strWhereCond = (0, clsString_js_2.Format)(clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN.WhereFormat, strid_CurrEduCls);
        }
        else {
            strWhereCond = (0, clsString_js_2.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        }
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN._CurrTabName, strid_CurrEduCls);
        if ((0, clsString_js_2.IsNullOrEmpty)(clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_1.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrgs_ResearchPlanExObjLst_Cache = CacheHelper_js_1.CacheHelper.Get(strKey);
            const arrgs_ResearchPlanObjLst_T = gs_ResearchPlan_GetObjLstByJSONObjLst(arrgs_ResearchPlanExObjLst_Cache);
            return arrgs_ResearchPlanObjLst_T;
        }
        try {
            const arrgs_ResearchPlanExObjLst = await gs_ResearchPlan_GetObjLstAsync(strWhereCond);
            CacheHelper_js_1.CacheHelper.Add(strKey, arrgs_ResearchPlanExObjLst);
            const strInfo = (0, clsString_js_2.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_ResearchPlanExObjLst.length);
            console.log(strInfo);
            return arrgs_ResearchPlanExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.gs_ResearchPlan_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.gs_ResearchPlan_GetObjLst_ClientCache = gs_ResearchPlan_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_ResearchPlan_GetObjLst_localStorage(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        if ((0, clsString_js_2.IsNullOrEmpty)(clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN.WhereFormat) == false) {
            strWhereCond = (0, clsString_js_2.Format)(clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN.WhereFormat, strid_CurrEduCls);
        }
        else {
            strWhereCond = (0, clsString_js_2.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        }
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN._CurrTabName, strid_CurrEduCls);
        if ((0, clsString_js_2.IsNullOrEmpty)(clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrgs_ResearchPlanExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrgs_ResearchPlanObjLst_T = gs_ResearchPlan_GetObjLstByJSONObjLst(arrgs_ResearchPlanExObjLst_Cache);
            return arrgs_ResearchPlanObjLst_T;
        }
        try {
            const arrgs_ResearchPlanExObjLst = await gs_ResearchPlan_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrgs_ResearchPlanExObjLst));
            const strInfo = (0, clsString_js_2.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_ResearchPlanExObjLst.length);
            console.log(strInfo);
            return arrgs_ResearchPlanExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.gs_ResearchPlan_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.gs_ResearchPlan_GetObjLst_localStorage = gs_ResearchPlan_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_ResearchPlan_GetObjLst_localStorage_PureCache(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_2.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN._CurrTabName, strid_CurrEduCls);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrgs_ResearchPlanObjLst_Cache = JSON.parse(strTempObjLst);
            return arrgs_ResearchPlanObjLst_Cache;
        }
        else
            return null;
    }
    exports.gs_ResearchPlan_GetObjLst_localStorage_PureCache = gs_ResearchPlan_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function gs_ResearchPlan_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ResearchPlan_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_ResearchPlan_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_ResearchPlan_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ResearchPlan_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ResearchPlan_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ResearchPlan_GetObjLstAsync = gs_ResearchPlan_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_ResearchPlan_GetObjLst_sessionStorage(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        if ((0, clsString_js_2.IsNullOrEmpty)(clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN.WhereFormat) == false) {
            strWhereCond = (0, clsString_js_2.Format)(clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN.WhereFormat, strid_CurrEduCls);
        }
        else {
            strWhereCond = (0, clsString_js_2.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        }
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN._CurrTabName, strid_CurrEduCls);
        if ((0, clsString_js_2.IsNullOrEmpty)(clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrgs_ResearchPlanExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrgs_ResearchPlanObjLst_T = gs_ResearchPlan_GetObjLstByJSONObjLst(arrgs_ResearchPlanExObjLst_Cache);
            return arrgs_ResearchPlanObjLst_T;
        }
        try {
            const arrgs_ResearchPlanExObjLst = await gs_ResearchPlan_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrgs_ResearchPlanExObjLst));
            const strInfo = (0, clsString_js_2.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_ResearchPlanExObjLst.length);
            console.log(strInfo);
            return arrgs_ResearchPlanExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.gs_ResearchPlan_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.gs_ResearchPlan_GetObjLst_sessionStorage = gs_ResearchPlan_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_ResearchPlan_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_2.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN._CurrTabName, strid_CurrEduCls);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrgs_ResearchPlanObjLst_Cache = JSON.parse(strTempObjLst);
            return arrgs_ResearchPlanObjLst_Cache;
        }
        else
            return null;
    }
    exports.gs_ResearchPlan_GetObjLst_sessionStorage_PureCache = gs_ResearchPlan_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_ResearchPlan_GetObjLst_Cache(strid_CurrEduCls) {
        //const strThisFuncName = "GetObjLst_Cache";
        if ((0, clsString_js_2.IsNullOrEmpty)(strid_CurrEduCls) == true) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[id_CurrEduCls]不能为空！(in clsgs_ResearchPlanWApi.gs_ResearchPlan_GetObjLst_Cache() )");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strid_CurrEduCls]的长度:[{0}]不正确！(in clsgs_ResearchPlanWApi.gs_ResearchPlan_GetObjLst_Cache() )", strid_CurrEduCls.length);
            console.error(strMsg);
            throw (strMsg);
        }
        let arrgs_ResearchPlanObjLst_Cache;
        switch (clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN.CacheModeId) {
            case "04": //sessionStorage
                arrgs_ResearchPlanObjLst_Cache = await gs_ResearchPlan_GetObjLst_sessionStorage(strid_CurrEduCls);
                break;
            case "03": //localStorage
                arrgs_ResearchPlanObjLst_Cache = await gs_ResearchPlan_GetObjLst_localStorage(strid_CurrEduCls);
                break;
            case "02": //ClientCache
                arrgs_ResearchPlanObjLst_Cache = await gs_ResearchPlan_GetObjLst_ClientCache(strid_CurrEduCls);
                break;
            default:
                arrgs_ResearchPlanObjLst_Cache = await gs_ResearchPlan_GetObjLst_ClientCache(strid_CurrEduCls);
                break;
        }
        const arrgs_ResearchPlanObjLst = gs_ResearchPlan_GetObjLstByJSONObjLst(arrgs_ResearchPlanObjLst_Cache);
        return arrgs_ResearchPlanObjLst_Cache;
    }
    exports.gs_ResearchPlan_GetObjLst_Cache = gs_ResearchPlan_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_ResearchPlan_GetObjLst_PureCache(strid_CurrEduCls) {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrgs_ResearchPlanObjLst_Cache;
        switch (clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN.CacheModeId) {
            case "04": //sessionStorage
                arrgs_ResearchPlanObjLst_Cache = await gs_ResearchPlan_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls);
                break;
            case "03": //localStorage
                arrgs_ResearchPlanObjLst_Cache = await gs_ResearchPlan_GetObjLst_localStorage_PureCache(strid_CurrEduCls);
                break;
            case "02": //ClientCache
                arrgs_ResearchPlanObjLst_Cache = null;
                break;
            default:
                arrgs_ResearchPlanObjLst_Cache = null;
                break;
        }
        return arrgs_ResearchPlanObjLst_Cache;
    }
    exports.gs_ResearchPlan_GetObjLst_PureCache = gs_ResearchPlan_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objstrPlanId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function gs_ResearchPlan_GetSubObjLst_Cache(objgs_ResearchPlan_Cond, strid_CurrEduCls) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrgs_ResearchPlanObjLst_Cache = await gs_ResearchPlan_GetObjLst_Cache(strid_CurrEduCls);
        let arrgs_ResearchPlan_Sel = arrgs_ResearchPlanObjLst_Cache;
        if (objgs_ResearchPlan_Cond.sf_FldComparisonOp == null || objgs_ResearchPlan_Cond.sf_FldComparisonOp == "")
            return arrgs_ResearchPlan_Sel;
        const dicFldComparisonOp = JSON.parse(objgs_ResearchPlan_Cond.sf_FldComparisonOp);
        //console.log("clsgs_ResearchPlanWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objgs_ResearchPlan_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objgs_ResearchPlan_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrgs_ResearchPlan_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objgs_ResearchPlan_Cond), exports.gs_ResearchPlan_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.gs_ResearchPlan_GetSubObjLst_Cache = gs_ResearchPlan_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrPlanId:关键字列表
    * @returns 对象列表
    **/
    async function gs_ResearchPlan_GetObjLstByPlanIdLstAsync(arrPlanId) {
        const strThisFuncName = "GetObjLstByPlanIdLstAsync";
        const strAction = "GetObjLstByPlanIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ResearchPlan_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrPlanId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_ResearchPlan_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_ResearchPlan_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ResearchPlan_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ResearchPlan_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ResearchPlan_GetObjLstByPlanIdLstAsync = gs_ResearchPlan_GetObjLstByPlanIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrstrPlanIdLst:关键字列表
     * @returns 对象列表
    */
    async function gs_ResearchPlan_GetObjLstByPlanIdLst_Cache(arrPlanIdLst, strid_CurrEduCls) {
        const strThisFuncName = "GetObjLstByPlanIdLst_Cache";
        try {
            const arrgs_ResearchPlanObjLst_Cache = await gs_ResearchPlan_GetObjLst_Cache(strid_CurrEduCls);
            const arrgs_ResearchPlan_Sel = arrgs_ResearchPlanObjLst_Cache.filter(x => arrPlanIdLst.indexOf(x.planId) > -1);
            return arrgs_ResearchPlan_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrPlanIdLst.join(","), exports.gs_ResearchPlan_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
    }
    exports.gs_ResearchPlan_GetObjLstByPlanIdLst_Cache = gs_ResearchPlan_GetObjLstByPlanIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function gs_ResearchPlan_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ResearchPlan_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_ResearchPlan_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_ResearchPlan_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ResearchPlan_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ResearchPlan_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ResearchPlan_GetTopObjLstAsync = gs_ResearchPlan_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function gs_ResearchPlan_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ResearchPlan_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_ResearchPlan_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_ResearchPlan_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ResearchPlan_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ResearchPlan_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ResearchPlan_GetObjLstByRangeAsync = gs_ResearchPlan_GetObjLstByRangeAsync;
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
    async function gs_ResearchPlan_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ResearchPlan_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ResearchPlan_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ResearchPlan_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ResearchPlan_GetObjLstByRange = gs_ResearchPlan_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function gs_ResearchPlan_GetObjLstByPager_Cache(objPagerPara, strid_CurrEduCls) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const arrgs_ResearchPlanObjLst_Cache = await gs_ResearchPlan_GetObjLst_Cache(strid_CurrEduCls);
        if (arrgs_ResearchPlanObjLst_Cache.length == 0)
            return arrgs_ResearchPlanObjLst_Cache;
        let arrgs_ResearchPlan_Sel = arrgs_ResearchPlanObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objgs_ResearchPlan_Cond = new clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objgs_ResearchPlan_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsgs_ResearchPlanWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objgs_ResearchPlan_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrgs_ResearchPlan_Sel.length == 0)
                return arrgs_ResearchPlan_Sel;
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
                arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.sort(gs_ResearchPlan_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.sort(objPagerPara.sortFun);
            }
            arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.slice(intStart, intEnd);
            return arrgs_ResearchPlan_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.gs_ResearchPlan_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.gs_ResearchPlan_GetObjLstByPager_Cache = gs_ResearchPlan_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function gs_ResearchPlan_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ResearchPlan_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_ResearchPlan_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_ResearchPlan_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ResearchPlan_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ResearchPlan_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ResearchPlan_GetObjLstByPagerAsync = gs_ResearchPlan_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param strPlanId:关键字
    * @returns 获取删除的结果
    **/
    async function gs_ResearchPlan_DelRecordAsync(strPlanId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ResearchPlan_Controller, strAction);
        strUrl = (0, clsString_js_2.Format)("{0}/?Id={1}", strUrl, strPlanId);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ResearchPlan_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ResearchPlan_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ResearchPlan_DelRecordAsync = gs_ResearchPlan_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrPlanId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function gs_ResearchPlan_Delgs_ResearchPlansAsync(arrPlanId) {
        const strThisFuncName = "Delgs_ResearchPlansAsync";
        const strAction = "Delgs_ResearchPlans";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ResearchPlan_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrPlanId);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ResearchPlan_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ResearchPlan_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ResearchPlan_Delgs_ResearchPlansAsync = gs_ResearchPlan_Delgs_ResearchPlansAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function gs_ResearchPlan_Delgs_ResearchPlansByCondAsync(strWhereCond) {
        const strThisFuncName = "Delgs_ResearchPlansByCondAsync";
        const strAction = "Delgs_ResearchPlansByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ResearchPlan_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ResearchPlan_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ResearchPlan_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ResearchPlan_Delgs_ResearchPlansByCondAsync = gs_ResearchPlan_Delgs_ResearchPlansByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objgs_ResearchPlanEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function gs_ResearchPlan_AddNewRecordAsync(objgs_ResearchPlanEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objgs_ResearchPlanEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ResearchPlan_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_ResearchPlanEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ResearchPlan_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ResearchPlan_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ResearchPlan_AddNewRecordAsync = gs_ResearchPlan_AddNewRecordAsync;
    /**
    * 调用WebApi来添加记录，关键字用最大关键字，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithMaxIdAsync)
    * @param objgs_ResearchPlanEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function gs_ResearchPlan_AddNewRecordWithMaxIdAsync(objgs_ResearchPlanEN) {
        const strThisFuncName = "AddNewRecordWithMaxIdAsync";
        const strAction = "AddNewRecordWithMaxId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ResearchPlan_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_ResearchPlanEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ResearchPlan_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ResearchPlan_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ResearchPlan_AddNewRecordWithMaxIdAsync = gs_ResearchPlan_AddNewRecordWithMaxIdAsync;
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objgs_ResearchPlanEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function gs_ResearchPlan_AddNewRecordWithReturnKeyAsync(objgs_ResearchPlanEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ResearchPlan_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_ResearchPlanEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ResearchPlan_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ResearchPlan_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ResearchPlan_AddNewRecordWithReturnKeyAsync = gs_ResearchPlan_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objgs_ResearchPlanEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function gs_ResearchPlan_AddNewRecordWithReturnKey(objgs_ResearchPlanEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objgs_ResearchPlanEN.planId === null || objgs_ResearchPlanEN.planId === "") {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ResearchPlan_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_ResearchPlanEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ResearchPlan_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ResearchPlan_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ResearchPlan_AddNewRecordWithReturnKey = gs_ResearchPlan_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objgs_ResearchPlanEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function gs_ResearchPlan_UpdateRecordAsync(objgs_ResearchPlanEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objgs_ResearchPlanEN.sf_UpdFldSetStr === undefined || objgs_ResearchPlanEN.sf_UpdFldSetStr === null || objgs_ResearchPlanEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_ResearchPlanEN.planId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ResearchPlan_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_ResearchPlanEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ResearchPlan_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ResearchPlan_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ResearchPlan_UpdateRecordAsync = gs_ResearchPlan_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objgs_ResearchPlanEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function gs_ResearchPlan_UpdateWithConditionAsync(objgs_ResearchPlanEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objgs_ResearchPlanEN.sf_UpdFldSetStr === undefined || objgs_ResearchPlanEN.sf_UpdFldSetStr === null || objgs_ResearchPlanEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_ResearchPlanEN.planId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ResearchPlan_Controller, strAction);
        objgs_ResearchPlanEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objgs_ResearchPlanEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ResearchPlan_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ResearchPlan_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ResearchPlan_UpdateWithConditionAsync = gs_ResearchPlan_UpdateWithConditionAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objstrPlanId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function gs_ResearchPlan_IsExistRecord_Cache(objgs_ResearchPlan_Cond, strid_CurrEduCls) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrgs_ResearchPlanObjLst_Cache = await gs_ResearchPlan_GetObjLst_Cache(strid_CurrEduCls);
        if (arrgs_ResearchPlanObjLst_Cache == null)
            return false;
        let arrgs_ResearchPlan_Sel = arrgs_ResearchPlanObjLst_Cache;
        if (objgs_ResearchPlan_Cond.sf_FldComparisonOp == null || objgs_ResearchPlan_Cond.sf_FldComparisonOp == "")
            return arrgs_ResearchPlan_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objgs_ResearchPlan_Cond.sf_FldComparisonOp);
        //console.log("clsgs_ResearchPlanWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objgs_ResearchPlan_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objgs_ResearchPlan_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrgs_ResearchPlan_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objgs_ResearchPlan_Cond), exports.gs_ResearchPlan_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.gs_ResearchPlan_IsExistRecord_Cache = gs_ResearchPlan_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function gs_ResearchPlan_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ResearchPlan_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ResearchPlan_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ResearchPlan_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ResearchPlan_IsExistRecordAsync = gs_ResearchPlan_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strPlanId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function gs_ResearchPlan_IsExist(strPlanId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ResearchPlan_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "PlanId": strPlanId,
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ResearchPlan_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ResearchPlan_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ResearchPlan_IsExist = gs_ResearchPlan_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param strPlanId:所给的关键字
     * @returns 对象
    */
    async function gs_ResearchPlan_IsExist_Cache(strPlanId, strid_CurrEduCls) {
        const strThisFuncName = "IsExist_Cache";
        const arrgs_ResearchPlanObjLst_Cache = await gs_ResearchPlan_GetObjLst_Cache(strid_CurrEduCls);
        if (arrgs_ResearchPlanObjLst_Cache == null)
            return false;
        try {
            const arrgs_ResearchPlan_Sel = arrgs_ResearchPlanObjLst_Cache.filter(x => x.planId == strPlanId);
            if (arrgs_ResearchPlan_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strPlanId, exports.gs_ResearchPlan_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.gs_ResearchPlan_IsExist_Cache = gs_ResearchPlan_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strPlanId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function gs_ResearchPlan_IsExistAsync(strPlanId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ResearchPlan_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strPlanId": strPlanId }
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ResearchPlan_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ResearchPlan_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ResearchPlan_IsExistAsync = gs_ResearchPlan_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function gs_ResearchPlan_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ResearchPlan_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ResearchPlan_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ResearchPlan_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ResearchPlan_GetRecCountByCondAsync = gs_ResearchPlan_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objgs_ResearchPlan_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function gs_ResearchPlan_GetRecCountByCond_Cache(objgs_ResearchPlan_Cond, strid_CurrEduCls) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrgs_ResearchPlanObjLst_Cache = await gs_ResearchPlan_GetObjLst_Cache(strid_CurrEduCls);
        if (arrgs_ResearchPlanObjLst_Cache == null)
            return 0;
        let arrgs_ResearchPlan_Sel = arrgs_ResearchPlanObjLst_Cache;
        if (objgs_ResearchPlan_Cond.sf_FldComparisonOp == null || objgs_ResearchPlan_Cond.sf_FldComparisonOp == "")
            return arrgs_ResearchPlan_Sel.length;
        const dicFldComparisonOp = JSON.parse(objgs_ResearchPlan_Cond.sf_FldComparisonOp);
        //console.log("clsgs_ResearchPlanWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objgs_ResearchPlan_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objgs_ResearchPlan_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrgs_ResearchPlan_Sel = arrgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrgs_ResearchPlan_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objgs_ResearchPlan_Cond), exports.gs_ResearchPlan_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.gs_ResearchPlan_GetRecCountByCond_Cache = gs_ResearchPlan_GetRecCountByCond_Cache;
    /**
    * 获取表的最大关键字
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdAsync)
    * @returns 获取表的最大关键字
    **/
    async function gs_ResearchPlan_GetMaxStrIdAsync() {
        const strThisFuncName = "GetMaxStrIdAsync";
        const strAction = "GetMaxStrId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ResearchPlan_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ResearchPlan_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ResearchPlan_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ResearchPlan_GetMaxStrIdAsync = gs_ResearchPlan_GetMaxStrIdAsync;
    /*该表的关键字类型不是字符型带前缀自增，不需要生成获取最大关键字函数！*/
    /**
     * 根据前缀获取当前表关键字值的最大值,再加1,避免重复
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdByPrefix)
     * @param mapParam:参数列表
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 获取当前表关键字值的最大值
    */
    async function gs_ResearchPlan_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ResearchPlan_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ResearchPlan_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ResearchPlan_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ResearchPlan_GetMaxStrIdByPrefix = gs_ResearchPlan_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function gs_ResearchPlan_GetWebApiUrl(strController, strAction) {
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
    exports.gs_ResearchPlan_GetWebApiUrl = gs_ResearchPlan_GetWebApiUrl;
    /**
    * 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshCache)
    **/
    function gs_ResearchPlan_ReFreshCache(strid_CurrEduCls) {
        const strThisFuncName = "ReFreshCache";
        if ((0, clsString_js_2.IsNullOrEmpty)(strid_CurrEduCls) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strid_CurrEduCls]不能为空！(In clsgs_ResearchPlanWApi.clsgs_ResearchPlanWApi.ReFreshCache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strid_CurrEduCls]的长度:[{0}]不正确！(clsgs_ResearchPlanWApi.clsgs_ResearchPlanWApi.ReFreshCache)", strid_CurrEduCls.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strMsg = (0, clsString_js_2.Format)("刷新缓存成功！");
        console.trace(strMsg);
        // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN._CurrTabName, strid_CurrEduCls);
        switch (clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN.CacheModeId) {
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
        (0, clsvgs_ResearchPlanWApi_js_1.vgs_ResearchPlan_ReFreshThisCache)(strid_CurrEduCls);
    }
    exports.gs_ResearchPlan_ReFreshCache = gs_ResearchPlan_ReFreshCache;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function gs_ResearchPlan_ReFreshThisCache(strid_CurrEduCls) {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN._CurrTabName, strid_CurrEduCls);
            switch (clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN.CacheModeId) {
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
    exports.gs_ResearchPlan_ReFreshThisCache = gs_ResearchPlan_ReFreshThisCache;
    /* 该表的下拉框功能没有设置，不需要生成下拉框绑定函数。*/
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function gs_ResearchPlan_CheckPropertyNew(pobjgs_ResearchPlanEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_ResearchPlanEN.topicId) === true
            || pobjgs_ResearchPlanEN.topicId.toString() === "0") {
            throw new Error("(errid:Watl000058)字段[主题Id]不能为空(In 主题研究计划)!(clsgs_ResearchPlanBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_ResearchPlanEN.statusId) === true) {
            throw new Error("(errid:Watl000058)字段[状态Id]不能为空(In 主题研究计划)!(clsgs_ResearchPlanBL:CheckPropertyNew)");
        }
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_ResearchPlanEN.planId) == false && (0, clsString_js_2.GetStrLen)(pobjgs_ResearchPlanEN.planId) > 8) {
            throw new Error("(errid:Watl000059)字段[计划Id(planId)]的长度不能超过8(In 主题研究计划(gs_ResearchPlan))!值:$(pobjgs_ResearchPlanEN.planId)(clsgs_ResearchPlanBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_ResearchPlanEN.topicId) == false && (0, clsString_js_2.GetStrLen)(pobjgs_ResearchPlanEN.topicId) > 8) {
            throw new Error("(errid:Watl000059)字段[主题Id(topicId)]的长度不能超过8(In 主题研究计划(gs_ResearchPlan))!值:$(pobjgs_ResearchPlanEN.topicId)(clsgs_ResearchPlanBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_ResearchPlanEN.statusId) == false && (0, clsString_js_2.GetStrLen)(pobjgs_ResearchPlanEN.statusId) > 2) {
            throw new Error("(errid:Watl000059)字段[状态Id(statusId)]的长度不能超过2(In 主题研究计划(gs_ResearchPlan))!值:$(pobjgs_ResearchPlanEN.statusId)(clsgs_ResearchPlanBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_ResearchPlanEN.planContent) == false && (0, clsString_js_2.GetStrLen)(pobjgs_ResearchPlanEN.planContent) > 1000) {
            throw new Error("(errid:Watl000059)字段[计划内容(planContent)]的长度不能超过1000(In 主题研究计划(gs_ResearchPlan))!值:$(pobjgs_ResearchPlanEN.planContent)(clsgs_ResearchPlanBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_ResearchPlanEN.responsibleUser) == false && (0, clsString_js_2.GetStrLen)(pobjgs_ResearchPlanEN.responsibleUser) > 50) {
            throw new Error("(errid:Watl000059)字段[负责人/小组(responsibleUser)]的长度不能超过50(In 主题研究计划(gs_ResearchPlan))!值:$(pobjgs_ResearchPlanEN.responsibleUser)(clsgs_ResearchPlanBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_ResearchPlanEN.startDate) == false && (0, clsString_js_2.GetStrLen)(pobjgs_ResearchPlanEN.startDate) > 20) {
            throw new Error("(errid:Watl000059)字段[开始日期(startDate)]的长度不能超过20(In 主题研究计划(gs_ResearchPlan))!值:$(pobjgs_ResearchPlanEN.startDate)(clsgs_ResearchPlanBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_ResearchPlanEN.endDate) == false && (0, clsString_js_2.GetStrLen)(pobjgs_ResearchPlanEN.endDate) > 20) {
            throw new Error("(errid:Watl000059)字段[截止日期(endDate)]的长度不能超过20(In 主题研究计划(gs_ResearchPlan))!值:$(pobjgs_ResearchPlanEN.endDate)(clsgs_ResearchPlanBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_ResearchPlanEN.actualFinishingDate) == false && (0, clsString_js_2.GetStrLen)(pobjgs_ResearchPlanEN.actualFinishingDate) > 20) {
            throw new Error("(errid:Watl000059)字段[实际完成日期(actualFinishingDate)]的长度不能超过20(In 主题研究计划(gs_ResearchPlan))!值:$(pobjgs_ResearchPlanEN.actualFinishingDate)(clsgs_ResearchPlanBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_ResearchPlanEN.acceptanceUser) == false && (0, clsString_js_2.GetStrLen)(pobjgs_ResearchPlanEN.acceptanceUser) > 50) {
            throw new Error("(errid:Watl000059)字段[验收用户(acceptanceUser)]的长度不能超过50(In 主题研究计划(gs_ResearchPlan))!值:$(pobjgs_ResearchPlanEN.acceptanceUser)(clsgs_ResearchPlanBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_ResearchPlanEN.updUser) == false && (0, clsString_js_2.GetStrLen)(pobjgs_ResearchPlanEN.updUser) > 20) {
            throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 主题研究计划(gs_ResearchPlan))!值:$(pobjgs_ResearchPlanEN.updUser)(clsgs_ResearchPlanBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_ResearchPlanEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjgs_ResearchPlanEN.updDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 主题研究计划(gs_ResearchPlan))!值:$(pobjgs_ResearchPlanEN.updDate)(clsgs_ResearchPlanBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_ResearchPlanEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjgs_ResearchPlanEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 主题研究计划(gs_ResearchPlan))!值:$(pobjgs_ResearchPlanEN.memo)(clsgs_ResearchPlanBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_ResearchPlanEN.planTypeId) == false && (0, clsString_js_2.GetStrLen)(pobjgs_ResearchPlanEN.planTypeId) > 2) {
            throw new Error("(errid:Watl000059)字段[计划类型(planTypeId)]的长度不能超过2(In 主题研究计划(gs_ResearchPlan))!值:$(pobjgs_ResearchPlanEN.planTypeId)(clsgs_ResearchPlanBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_ResearchPlanEN.id_CurrEduCls) == false && (0, clsString_js_2.GetStrLen)(pobjgs_ResearchPlanEN.id_CurrEduCls) > 8) {
            throw new Error("(errid:Watl000059)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 主题研究计划(gs_ResearchPlan))!值:$(pobjgs_ResearchPlanEN.id_CurrEduCls)(clsgs_ResearchPlanBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_ResearchPlanEN.planId) == false && undefined !== pobjgs_ResearchPlanEN.planId && clsString_js_1.tzDataType.isString(pobjgs_ResearchPlanEN.planId) === false) {
            throw new Error("(errid:Watl000060)字段[计划Id(planId)]的值:[$(pobjgs_ResearchPlanEN.planId)], 非法，应该为字符型(In 主题研究计划(gs_ResearchPlan))!(clsgs_ResearchPlanBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_ResearchPlanEN.topicId) == false && undefined !== pobjgs_ResearchPlanEN.topicId && clsString_js_1.tzDataType.isString(pobjgs_ResearchPlanEN.topicId) === false) {
            throw new Error("(errid:Watl000060)字段[主题Id(topicId)]的值:[$(pobjgs_ResearchPlanEN.topicId)], 非法，应该为字符型(In 主题研究计划(gs_ResearchPlan))!(clsgs_ResearchPlanBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_ResearchPlanEN.statusId) == false && undefined !== pobjgs_ResearchPlanEN.statusId && clsString_js_1.tzDataType.isString(pobjgs_ResearchPlanEN.statusId) === false) {
            throw new Error("(errid:Watl000060)字段[状态Id(statusId)]的值:[$(pobjgs_ResearchPlanEN.statusId)], 非法，应该为字符型(In 主题研究计划(gs_ResearchPlan))!(clsgs_ResearchPlanBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_ResearchPlanEN.planContent) == false && undefined !== pobjgs_ResearchPlanEN.planContent && clsString_js_1.tzDataType.isString(pobjgs_ResearchPlanEN.planContent) === false) {
            throw new Error("(errid:Watl000060)字段[计划内容(planContent)]的值:[$(pobjgs_ResearchPlanEN.planContent)], 非法，应该为字符型(In 主题研究计划(gs_ResearchPlan))!(clsgs_ResearchPlanBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_ResearchPlanEN.responsibleUser) == false && undefined !== pobjgs_ResearchPlanEN.responsibleUser && clsString_js_1.tzDataType.isString(pobjgs_ResearchPlanEN.responsibleUser) === false) {
            throw new Error("(errid:Watl000060)字段[负责人/小组(responsibleUser)]的值:[$(pobjgs_ResearchPlanEN.responsibleUser)], 非法，应该为字符型(In 主题研究计划(gs_ResearchPlan))!(clsgs_ResearchPlanBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_ResearchPlanEN.startDate) == false && undefined !== pobjgs_ResearchPlanEN.startDate && clsString_js_1.tzDataType.isString(pobjgs_ResearchPlanEN.startDate) === false) {
            throw new Error("(errid:Watl000060)字段[开始日期(startDate)]的值:[$(pobjgs_ResearchPlanEN.startDate)], 非法，应该为字符型(In 主题研究计划(gs_ResearchPlan))!(clsgs_ResearchPlanBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_ResearchPlanEN.endDate) == false && undefined !== pobjgs_ResearchPlanEN.endDate && clsString_js_1.tzDataType.isString(pobjgs_ResearchPlanEN.endDate) === false) {
            throw new Error("(errid:Watl000060)字段[截止日期(endDate)]的值:[$(pobjgs_ResearchPlanEN.endDate)], 非法，应该为字符型(In 主题研究计划(gs_ResearchPlan))!(clsgs_ResearchPlanBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_ResearchPlanEN.actualFinishingDate) == false && undefined !== pobjgs_ResearchPlanEN.actualFinishingDate && clsString_js_1.tzDataType.isString(pobjgs_ResearchPlanEN.actualFinishingDate) === false) {
            throw new Error("(errid:Watl000060)字段[实际完成日期(actualFinishingDate)]的值:[$(pobjgs_ResearchPlanEN.actualFinishingDate)], 非法，应该为字符型(In 主题研究计划(gs_ResearchPlan))!(clsgs_ResearchPlanBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_ResearchPlanEN.acceptanceUser) == false && undefined !== pobjgs_ResearchPlanEN.acceptanceUser && clsString_js_1.tzDataType.isString(pobjgs_ResearchPlanEN.acceptanceUser) === false) {
            throw new Error("(errid:Watl000060)字段[验收用户(acceptanceUser)]的值:[$(pobjgs_ResearchPlanEN.acceptanceUser)], 非法，应该为字符型(In 主题研究计划(gs_ResearchPlan))!(clsgs_ResearchPlanBL:CheckPropertyNew)");
        }
        if (null != pobjgs_ResearchPlanEN.isSubmit && undefined !== pobjgs_ResearchPlanEN.isSubmit && clsString_js_1.tzDataType.isBoolean(pobjgs_ResearchPlanEN.isSubmit) === false) {
            throw new Error("(errid:Watl000060)字段[是否提交(isSubmit)]的值:[$(pobjgs_ResearchPlanEN.isSubmit)], 非法，应该为布尔型(In 主题研究计划(gs_ResearchPlan))!(clsgs_ResearchPlanBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_ResearchPlanEN.updUser) == false && undefined !== pobjgs_ResearchPlanEN.updUser && clsString_js_1.tzDataType.isString(pobjgs_ResearchPlanEN.updUser) === false) {
            throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjgs_ResearchPlanEN.updUser)], 非法，应该为字符型(In 主题研究计划(gs_ResearchPlan))!(clsgs_ResearchPlanBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_ResearchPlanEN.updDate) == false && undefined !== pobjgs_ResearchPlanEN.updDate && clsString_js_1.tzDataType.isString(pobjgs_ResearchPlanEN.updDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjgs_ResearchPlanEN.updDate)], 非法，应该为字符型(In 主题研究计划(gs_ResearchPlan))!(clsgs_ResearchPlanBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_ResearchPlanEN.memo) == false && undefined !== pobjgs_ResearchPlanEN.memo && clsString_js_1.tzDataType.isString(pobjgs_ResearchPlanEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjgs_ResearchPlanEN.memo)], 非法，应该为字符型(In 主题研究计划(gs_ResearchPlan))!(clsgs_ResearchPlanBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_ResearchPlanEN.planTypeId) == false && undefined !== pobjgs_ResearchPlanEN.planTypeId && clsString_js_1.tzDataType.isString(pobjgs_ResearchPlanEN.planTypeId) === false) {
            throw new Error("(errid:Watl000060)字段[计划类型(planTypeId)]的值:[$(pobjgs_ResearchPlanEN.planTypeId)], 非法，应该为字符型(In 主题研究计划(gs_ResearchPlan))!(clsgs_ResearchPlanBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_ResearchPlanEN.id_CurrEduCls) == false && undefined !== pobjgs_ResearchPlanEN.id_CurrEduCls && clsString_js_1.tzDataType.isString(pobjgs_ResearchPlanEN.id_CurrEduCls) === false) {
            throw new Error("(errid:Watl000060)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjgs_ResearchPlanEN.id_CurrEduCls)], 非法，应该为字符型(In 主题研究计划(gs_ResearchPlan))!(clsgs_ResearchPlanBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjgs_ResearchPlanEN.SetIsCheckProperty(true);
    }
    exports.gs_ResearchPlan_CheckPropertyNew = gs_ResearchPlan_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function gs_ResearchPlan_CheckProperty4Update(pobjgs_ResearchPlanEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_ResearchPlanEN.planId) == false && (0, clsString_js_2.GetStrLen)(pobjgs_ResearchPlanEN.planId) > 8) {
            throw new Error("(errid:Watl000062)字段[计划Id(planId)]的长度不能超过8(In 主题研究计划(gs_ResearchPlan))!值:$(pobjgs_ResearchPlanEN.planId)(clsgs_ResearchPlanBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_ResearchPlanEN.topicId) == false && (0, clsString_js_2.GetStrLen)(pobjgs_ResearchPlanEN.topicId) > 8) {
            throw new Error("(errid:Watl000062)字段[主题Id(topicId)]的长度不能超过8(In 主题研究计划(gs_ResearchPlan))!值:$(pobjgs_ResearchPlanEN.topicId)(clsgs_ResearchPlanBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_ResearchPlanEN.statusId) == false && (0, clsString_js_2.GetStrLen)(pobjgs_ResearchPlanEN.statusId) > 2) {
            throw new Error("(errid:Watl000062)字段[状态Id(statusId)]的长度不能超过2(In 主题研究计划(gs_ResearchPlan))!值:$(pobjgs_ResearchPlanEN.statusId)(clsgs_ResearchPlanBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_ResearchPlanEN.planContent) == false && (0, clsString_js_2.GetStrLen)(pobjgs_ResearchPlanEN.planContent) > 1000) {
            throw new Error("(errid:Watl000062)字段[计划内容(planContent)]的长度不能超过1000(In 主题研究计划(gs_ResearchPlan))!值:$(pobjgs_ResearchPlanEN.planContent)(clsgs_ResearchPlanBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_ResearchPlanEN.responsibleUser) == false && (0, clsString_js_2.GetStrLen)(pobjgs_ResearchPlanEN.responsibleUser) > 50) {
            throw new Error("(errid:Watl000062)字段[负责人/小组(responsibleUser)]的长度不能超过50(In 主题研究计划(gs_ResearchPlan))!值:$(pobjgs_ResearchPlanEN.responsibleUser)(clsgs_ResearchPlanBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_ResearchPlanEN.startDate) == false && (0, clsString_js_2.GetStrLen)(pobjgs_ResearchPlanEN.startDate) > 20) {
            throw new Error("(errid:Watl000062)字段[开始日期(startDate)]的长度不能超过20(In 主题研究计划(gs_ResearchPlan))!值:$(pobjgs_ResearchPlanEN.startDate)(clsgs_ResearchPlanBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_ResearchPlanEN.endDate) == false && (0, clsString_js_2.GetStrLen)(pobjgs_ResearchPlanEN.endDate) > 20) {
            throw new Error("(errid:Watl000062)字段[截止日期(endDate)]的长度不能超过20(In 主题研究计划(gs_ResearchPlan))!值:$(pobjgs_ResearchPlanEN.endDate)(clsgs_ResearchPlanBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_ResearchPlanEN.actualFinishingDate) == false && (0, clsString_js_2.GetStrLen)(pobjgs_ResearchPlanEN.actualFinishingDate) > 20) {
            throw new Error("(errid:Watl000062)字段[实际完成日期(actualFinishingDate)]的长度不能超过20(In 主题研究计划(gs_ResearchPlan))!值:$(pobjgs_ResearchPlanEN.actualFinishingDate)(clsgs_ResearchPlanBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_ResearchPlanEN.acceptanceUser) == false && (0, clsString_js_2.GetStrLen)(pobjgs_ResearchPlanEN.acceptanceUser) > 50) {
            throw new Error("(errid:Watl000062)字段[验收用户(acceptanceUser)]的长度不能超过50(In 主题研究计划(gs_ResearchPlan))!值:$(pobjgs_ResearchPlanEN.acceptanceUser)(clsgs_ResearchPlanBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_ResearchPlanEN.updUser) == false && (0, clsString_js_2.GetStrLen)(pobjgs_ResearchPlanEN.updUser) > 20) {
            throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 主题研究计划(gs_ResearchPlan))!值:$(pobjgs_ResearchPlanEN.updUser)(clsgs_ResearchPlanBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_ResearchPlanEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjgs_ResearchPlanEN.updDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 主题研究计划(gs_ResearchPlan))!值:$(pobjgs_ResearchPlanEN.updDate)(clsgs_ResearchPlanBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_ResearchPlanEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjgs_ResearchPlanEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 主题研究计划(gs_ResearchPlan))!值:$(pobjgs_ResearchPlanEN.memo)(clsgs_ResearchPlanBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_ResearchPlanEN.planTypeId) == false && (0, clsString_js_2.GetStrLen)(pobjgs_ResearchPlanEN.planTypeId) > 2) {
            throw new Error("(errid:Watl000062)字段[计划类型(planTypeId)]的长度不能超过2(In 主题研究计划(gs_ResearchPlan))!值:$(pobjgs_ResearchPlanEN.planTypeId)(clsgs_ResearchPlanBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_ResearchPlanEN.id_CurrEduCls) == false && (0, clsString_js_2.GetStrLen)(pobjgs_ResearchPlanEN.id_CurrEduCls) > 8) {
            throw new Error("(errid:Watl000062)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 主题研究计划(gs_ResearchPlan))!值:$(pobjgs_ResearchPlanEN.id_CurrEduCls)(clsgs_ResearchPlanBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_ResearchPlanEN.planId) == false && undefined !== pobjgs_ResearchPlanEN.planId && clsString_js_1.tzDataType.isString(pobjgs_ResearchPlanEN.planId) === false) {
            throw new Error("(errid:Watl000063)字段[计划Id(planId)]的值:[$(pobjgs_ResearchPlanEN.planId)], 非法，应该为字符型(In 主题研究计划(gs_ResearchPlan))!(clsgs_ResearchPlanBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_ResearchPlanEN.topicId) == false && undefined !== pobjgs_ResearchPlanEN.topicId && clsString_js_1.tzDataType.isString(pobjgs_ResearchPlanEN.topicId) === false) {
            throw new Error("(errid:Watl000063)字段[主题Id(topicId)]的值:[$(pobjgs_ResearchPlanEN.topicId)], 非法，应该为字符型(In 主题研究计划(gs_ResearchPlan))!(clsgs_ResearchPlanBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_ResearchPlanEN.statusId) == false && undefined !== pobjgs_ResearchPlanEN.statusId && clsString_js_1.tzDataType.isString(pobjgs_ResearchPlanEN.statusId) === false) {
            throw new Error("(errid:Watl000063)字段[状态Id(statusId)]的值:[$(pobjgs_ResearchPlanEN.statusId)], 非法，应该为字符型(In 主题研究计划(gs_ResearchPlan))!(clsgs_ResearchPlanBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_ResearchPlanEN.planContent) == false && undefined !== pobjgs_ResearchPlanEN.planContent && clsString_js_1.tzDataType.isString(pobjgs_ResearchPlanEN.planContent) === false) {
            throw new Error("(errid:Watl000063)字段[计划内容(planContent)]的值:[$(pobjgs_ResearchPlanEN.planContent)], 非法，应该为字符型(In 主题研究计划(gs_ResearchPlan))!(clsgs_ResearchPlanBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_ResearchPlanEN.responsibleUser) == false && undefined !== pobjgs_ResearchPlanEN.responsibleUser && clsString_js_1.tzDataType.isString(pobjgs_ResearchPlanEN.responsibleUser) === false) {
            throw new Error("(errid:Watl000063)字段[负责人/小组(responsibleUser)]的值:[$(pobjgs_ResearchPlanEN.responsibleUser)], 非法，应该为字符型(In 主题研究计划(gs_ResearchPlan))!(clsgs_ResearchPlanBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_ResearchPlanEN.startDate) == false && undefined !== pobjgs_ResearchPlanEN.startDate && clsString_js_1.tzDataType.isString(pobjgs_ResearchPlanEN.startDate) === false) {
            throw new Error("(errid:Watl000063)字段[开始日期(startDate)]的值:[$(pobjgs_ResearchPlanEN.startDate)], 非法，应该为字符型(In 主题研究计划(gs_ResearchPlan))!(clsgs_ResearchPlanBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_ResearchPlanEN.endDate) == false && undefined !== pobjgs_ResearchPlanEN.endDate && clsString_js_1.tzDataType.isString(pobjgs_ResearchPlanEN.endDate) === false) {
            throw new Error("(errid:Watl000063)字段[截止日期(endDate)]的值:[$(pobjgs_ResearchPlanEN.endDate)], 非法，应该为字符型(In 主题研究计划(gs_ResearchPlan))!(clsgs_ResearchPlanBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_ResearchPlanEN.actualFinishingDate) == false && undefined !== pobjgs_ResearchPlanEN.actualFinishingDate && clsString_js_1.tzDataType.isString(pobjgs_ResearchPlanEN.actualFinishingDate) === false) {
            throw new Error("(errid:Watl000063)字段[实际完成日期(actualFinishingDate)]的值:[$(pobjgs_ResearchPlanEN.actualFinishingDate)], 非法，应该为字符型(In 主题研究计划(gs_ResearchPlan))!(clsgs_ResearchPlanBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_ResearchPlanEN.acceptanceUser) == false && undefined !== pobjgs_ResearchPlanEN.acceptanceUser && clsString_js_1.tzDataType.isString(pobjgs_ResearchPlanEN.acceptanceUser) === false) {
            throw new Error("(errid:Watl000063)字段[验收用户(acceptanceUser)]的值:[$(pobjgs_ResearchPlanEN.acceptanceUser)], 非法，应该为字符型(In 主题研究计划(gs_ResearchPlan))!(clsgs_ResearchPlanBL:CheckProperty4Update)");
        }
        if (null != pobjgs_ResearchPlanEN.isSubmit && undefined !== pobjgs_ResearchPlanEN.isSubmit && clsString_js_1.tzDataType.isBoolean(pobjgs_ResearchPlanEN.isSubmit) === false) {
            throw new Error("(errid:Watl000063)字段[是否提交(isSubmit)]的值:[$(pobjgs_ResearchPlanEN.isSubmit)], 非法，应该为布尔型(In 主题研究计划(gs_ResearchPlan))!(clsgs_ResearchPlanBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_ResearchPlanEN.updUser) == false && undefined !== pobjgs_ResearchPlanEN.updUser && clsString_js_1.tzDataType.isString(pobjgs_ResearchPlanEN.updUser) === false) {
            throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjgs_ResearchPlanEN.updUser)], 非法，应该为字符型(In 主题研究计划(gs_ResearchPlan))!(clsgs_ResearchPlanBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_ResearchPlanEN.updDate) == false && undefined !== pobjgs_ResearchPlanEN.updDate && clsString_js_1.tzDataType.isString(pobjgs_ResearchPlanEN.updDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjgs_ResearchPlanEN.updDate)], 非法，应该为字符型(In 主题研究计划(gs_ResearchPlan))!(clsgs_ResearchPlanBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_ResearchPlanEN.memo) == false && undefined !== pobjgs_ResearchPlanEN.memo && clsString_js_1.tzDataType.isString(pobjgs_ResearchPlanEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjgs_ResearchPlanEN.memo)], 非法，应该为字符型(In 主题研究计划(gs_ResearchPlan))!(clsgs_ResearchPlanBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_ResearchPlanEN.planTypeId) == false && undefined !== pobjgs_ResearchPlanEN.planTypeId && clsString_js_1.tzDataType.isString(pobjgs_ResearchPlanEN.planTypeId) === false) {
            throw new Error("(errid:Watl000063)字段[计划类型(planTypeId)]的值:[$(pobjgs_ResearchPlanEN.planTypeId)], 非法，应该为字符型(In 主题研究计划(gs_ResearchPlan))!(clsgs_ResearchPlanBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_ResearchPlanEN.id_CurrEduCls) == false && undefined !== pobjgs_ResearchPlanEN.id_CurrEduCls && clsString_js_1.tzDataType.isString(pobjgs_ResearchPlanEN.id_CurrEduCls) === false) {
            throw new Error("(errid:Watl000063)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjgs_ResearchPlanEN.id_CurrEduCls)], 非法，应该为字符型(In 主题研究计划(gs_ResearchPlan))!(clsgs_ResearchPlanBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_ResearchPlanEN.planId) === true) {
            throw new Error("(errid:Watl000064)字段[计划Id]不能为空(In 主题研究计划)!(clsgs_ResearchPlanBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjgs_ResearchPlanEN.SetIsCheckProperty(true);
    }
    exports.gs_ResearchPlan_CheckProperty4Update = gs_ResearchPlan_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function gs_ResearchPlan_GetJSONStrByObj(pobjgs_ResearchPlanEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjgs_ResearchPlanEN.sf_UpdFldSetStr = pobjgs_ResearchPlanEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjgs_ResearchPlanEN);
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
    exports.gs_ResearchPlan_GetJSONStrByObj = gs_ResearchPlan_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function gs_ResearchPlan_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrgs_ResearchPlanObjLst = new Array();
        if (strJSON === "") {
            return arrgs_ResearchPlanObjLst;
        }
        try {
            arrgs_ResearchPlanObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrgs_ResearchPlanObjLst;
        }
        return arrgs_ResearchPlanObjLst;
    }
    exports.gs_ResearchPlan_GetObjLstByJSONStr = gs_ResearchPlan_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrgs_ResearchPlanObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function gs_ResearchPlan_GetObjLstByJSONObjLst(arrgs_ResearchPlanObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrgs_ResearchPlanObjLst = new Array();
        for (const objInFor of arrgs_ResearchPlanObjLstS) {
            const obj1 = gs_ResearchPlan_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrgs_ResearchPlanObjLst.push(obj1);
        }
        return arrgs_ResearchPlanObjLst;
    }
    exports.gs_ResearchPlan_GetObjLstByJSONObjLst = gs_ResearchPlan_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function gs_ResearchPlan_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjgs_ResearchPlanEN = new clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN();
        if (strJSON === "") {
            return pobjgs_ResearchPlanEN;
        }
        try {
            pobjgs_ResearchPlanEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjgs_ResearchPlanEN;
        }
        return pobjgs_ResearchPlanEN;
    }
    exports.gs_ResearchPlan_GetObjByJSONStr = gs_ResearchPlan_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function gs_ResearchPlan_GetCombineCondition(objgs_ResearchPlan_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objgs_ResearchPlan_Cond.dicFldComparisonOp, clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN.con_PlanId) == true) {
            const strComparisonOp_PlanId = objgs_ResearchPlan_Cond.dicFldComparisonOp[clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN.con_PlanId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN.con_PlanId, objgs_ResearchPlan_Cond.planId, strComparisonOp_PlanId);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_ResearchPlan_Cond.dicFldComparisonOp, clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN.con_TopicId) == true) {
            const strComparisonOp_TopicId = objgs_ResearchPlan_Cond.dicFldComparisonOp[clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN.con_TopicId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN.con_TopicId, objgs_ResearchPlan_Cond.topicId, strComparisonOp_TopicId);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_ResearchPlan_Cond.dicFldComparisonOp, clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN.con_StatusId) == true) {
            const strComparisonOp_StatusId = objgs_ResearchPlan_Cond.dicFldComparisonOp[clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN.con_StatusId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN.con_StatusId, objgs_ResearchPlan_Cond.statusId, strComparisonOp_StatusId);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_ResearchPlan_Cond.dicFldComparisonOp, clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN.con_PlanContent) == true) {
            const strComparisonOp_PlanContent = objgs_ResearchPlan_Cond.dicFldComparisonOp[clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN.con_PlanContent];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN.con_PlanContent, objgs_ResearchPlan_Cond.planContent, strComparisonOp_PlanContent);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_ResearchPlan_Cond.dicFldComparisonOp, clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN.con_ResponsibleUser) == true) {
            const strComparisonOp_ResponsibleUser = objgs_ResearchPlan_Cond.dicFldComparisonOp[clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN.con_ResponsibleUser];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN.con_ResponsibleUser, objgs_ResearchPlan_Cond.responsibleUser, strComparisonOp_ResponsibleUser);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_ResearchPlan_Cond.dicFldComparisonOp, clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN.con_StartDate) == true) {
            const strComparisonOp_StartDate = objgs_ResearchPlan_Cond.dicFldComparisonOp[clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN.con_StartDate];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN.con_StartDate, objgs_ResearchPlan_Cond.startDate, strComparisonOp_StartDate);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_ResearchPlan_Cond.dicFldComparisonOp, clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN.con_EndDate) == true) {
            const strComparisonOp_EndDate = objgs_ResearchPlan_Cond.dicFldComparisonOp[clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN.con_EndDate];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN.con_EndDate, objgs_ResearchPlan_Cond.endDate, strComparisonOp_EndDate);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_ResearchPlan_Cond.dicFldComparisonOp, clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN.con_ActualFinishingDate) == true) {
            const strComparisonOp_ActualFinishingDate = objgs_ResearchPlan_Cond.dicFldComparisonOp[clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN.con_ActualFinishingDate];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN.con_ActualFinishingDate, objgs_ResearchPlan_Cond.actualFinishingDate, strComparisonOp_ActualFinishingDate);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_ResearchPlan_Cond.dicFldComparisonOp, clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN.con_AcceptanceUser) == true) {
            const strComparisonOp_AcceptanceUser = objgs_ResearchPlan_Cond.dicFldComparisonOp[clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN.con_AcceptanceUser];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN.con_AcceptanceUser, objgs_ResearchPlan_Cond.acceptanceUser, strComparisonOp_AcceptanceUser);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_ResearchPlan_Cond.dicFldComparisonOp, clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN.con_IsSubmit) == true) {
            if (objgs_ResearchPlan_Cond.isSubmit == true) {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '1'", clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN.con_IsSubmit);
            }
            else {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '0'", clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN.con_IsSubmit);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objgs_ResearchPlan_Cond.dicFldComparisonOp, clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objgs_ResearchPlan_Cond.dicFldComparisonOp[clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN.con_UpdUser];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN.con_UpdUser, objgs_ResearchPlan_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_ResearchPlan_Cond.dicFldComparisonOp, clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objgs_ResearchPlan_Cond.dicFldComparisonOp[clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN.con_UpdDate];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN.con_UpdDate, objgs_ResearchPlan_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_ResearchPlan_Cond.dicFldComparisonOp, clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN.con_Memo) == true) {
            const strComparisonOp_Memo = objgs_ResearchPlan_Cond.dicFldComparisonOp[clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN.con_Memo];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN.con_Memo, objgs_ResearchPlan_Cond.memo, strComparisonOp_Memo);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_ResearchPlan_Cond.dicFldComparisonOp, clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN.con_PlanTypeId) == true) {
            const strComparisonOp_PlanTypeId = objgs_ResearchPlan_Cond.dicFldComparisonOp[clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN.con_PlanTypeId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN.con_PlanTypeId, objgs_ResearchPlan_Cond.planTypeId, strComparisonOp_PlanTypeId);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_ResearchPlan_Cond.dicFldComparisonOp, clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN.con_id_CurrEduCls) == true) {
            const strComparisonOp_id_CurrEduCls = objgs_ResearchPlan_Cond.dicFldComparisonOp[clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN.con_id_CurrEduCls];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN.con_id_CurrEduCls, objgs_ResearchPlan_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
        }
        return strWhereCond;
    }
    exports.gs_ResearchPlan_GetCombineCondition = gs_ResearchPlan_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--gs_ResearchPlan(主题研究计划),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param strPlanId: 计划Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function gs_ResearchPlan_GetUniCondStr_PlanId(objgs_ResearchPlanEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and PlanId = '{0}'", objgs_ResearchPlanEN.planId);
        return strWhereCond;
    }
    exports.gs_ResearchPlan_GetUniCondStr_PlanId = gs_ResearchPlan_GetUniCondStr_PlanId;
    /**
    *获取唯一性条件串(Uniqueness)--gs_ResearchPlan(主题研究计划),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param strPlanId: 计划Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function gs_ResearchPlan_GetUniCondStr4Update_PlanId(objgs_ResearchPlanEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and PlanId <> '{0}'", objgs_ResearchPlanEN.planId);
        strWhereCond += (0, clsString_js_2.Format)(" and PlanId = '{0}'", objgs_ResearchPlanEN.planId);
        return strWhereCond;
    }
    exports.gs_ResearchPlan_GetUniCondStr4Update_PlanId = gs_ResearchPlan_GetUniCondStr4Update_PlanId;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objgs_ResearchPlanENS:源对象
     * @param objgs_ResearchPlanENT:目标对象
    */
    function gs_ResearchPlan_CopyObjTo(objgs_ResearchPlanENS, objgs_ResearchPlanENT) {
        objgs_ResearchPlanENT.planId = objgs_ResearchPlanENS.planId; //计划Id
        objgs_ResearchPlanENT.topicId = objgs_ResearchPlanENS.topicId; //主题Id
        objgs_ResearchPlanENT.statusId = objgs_ResearchPlanENS.statusId; //状态Id
        objgs_ResearchPlanENT.planContent = objgs_ResearchPlanENS.planContent; //计划内容
        objgs_ResearchPlanENT.responsibleUser = objgs_ResearchPlanENS.responsibleUser; //负责人/小组
        objgs_ResearchPlanENT.startDate = objgs_ResearchPlanENS.startDate; //开始日期
        objgs_ResearchPlanENT.endDate = objgs_ResearchPlanENS.endDate; //截止日期
        objgs_ResearchPlanENT.actualFinishingDate = objgs_ResearchPlanENS.actualFinishingDate; //实际完成日期
        objgs_ResearchPlanENT.acceptanceUser = objgs_ResearchPlanENS.acceptanceUser; //验收用户
        objgs_ResearchPlanENT.isSubmit = objgs_ResearchPlanENS.isSubmit; //是否提交
        objgs_ResearchPlanENT.updUser = objgs_ResearchPlanENS.updUser; //修改人
        objgs_ResearchPlanENT.updDate = objgs_ResearchPlanENS.updDate; //修改日期
        objgs_ResearchPlanENT.memo = objgs_ResearchPlanENS.memo; //备注
        objgs_ResearchPlanENT.planTypeId = objgs_ResearchPlanENS.planTypeId; //计划类型
        objgs_ResearchPlanENT.id_CurrEduCls = objgs_ResearchPlanENS.id_CurrEduCls; //教学班流水号
        objgs_ResearchPlanENT.sf_UpdFldSetStr = objgs_ResearchPlanENS.updFldString; //sf_UpdFldSetStr
    }
    exports.gs_ResearchPlan_CopyObjTo = gs_ResearchPlan_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objgs_ResearchPlanENS:源对象
     * @param objgs_ResearchPlanENT:目标对象
    */
    function gs_ResearchPlan_GetObjFromJsonObj(objgs_ResearchPlanENS) {
        const objgs_ResearchPlanENT = new clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objgs_ResearchPlanENT, objgs_ResearchPlanENS);
        return objgs_ResearchPlanENT;
    }
    exports.gs_ResearchPlan_GetObjFromJsonObj = gs_ResearchPlan_GetObjFromJsonObj;
});
