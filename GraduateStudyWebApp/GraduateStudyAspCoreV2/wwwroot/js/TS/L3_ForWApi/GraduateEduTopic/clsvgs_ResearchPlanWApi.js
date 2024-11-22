/**
* 类名:clsvgs_ResearchPlanWApi
* 表名:vgs_ResearchPlan(01120662)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/13 00:47:05
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
        define(["require", "exports", "axios", "../../PubFun/enumComparisonOp.js", "../../PubFun/CacheHelper.js", "../../L0_Entity/GraduateEduTopic/clsvgs_ResearchPlanEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.vgs_ResearchPlan_GetObjFromJsonObj = exports.vgs_ResearchPlan_CopyObjTo = exports.vgs_ResearchPlan_GetCombineCondition = exports.vgs_ResearchPlan_GetObjByJSONStr = exports.vgs_ResearchPlan_GetObjLstByJSONObjLst = exports.vgs_ResearchPlan_GetObjLstByJSONStr = exports.vgs_ResearchPlan_GetJSONStrByObj = exports.vgs_ResearchPlan__Cache = exports.vgs_ResearchPlan_ReFreshThisCache = exports.vgs_ResearchPlan_GetWebApiUrl = exports.vgs_ResearchPlan_GetRecCountByCond_Cache = exports.vgs_ResearchPlan_GetRecCountByCondAsync = exports.vgs_ResearchPlan_IsExistAsync = exports.vgs_ResearchPlan_IsExist_Cache = exports.vgs_ResearchPlan_IsExist = exports.vgs_ResearchPlan_IsExistRecordAsync = exports.vgs_ResearchPlan_IsExistRecord_Cache = exports.vgs_ResearchPlan_GetObjLstByPagerAsync = exports.vgs_ResearchPlan_GetObjLstByPager_Cache = exports.vgs_ResearchPlan_GetObjLstByRange = exports.vgs_ResearchPlan_GetObjLstByRangeAsync = exports.vgs_ResearchPlan_GetTopObjLstAsync = exports.vgs_ResearchPlan_GetObjLstByPlanIdLst_Cache = exports.vgs_ResearchPlan_GetObjLstByPlanIdLstAsync = exports.vgs_ResearchPlan_GetSubObjLst_Cache = exports.vgs_ResearchPlan_GetObjLst_PureCache = exports.vgs_ResearchPlan_GetObjLst_Cache = exports.vgs_ResearchPlan_GetObjLst_sessionStorage_PureCache = exports.vgs_ResearchPlan_GetObjLst_sessionStorage = exports.vgs_ResearchPlan_GetObjLstAsync = exports.vgs_ResearchPlan_GetObjLst_localStorage_PureCache = exports.vgs_ResearchPlan_GetObjLst_localStorage = exports.vgs_ResearchPlan_GetObjLst_ClientCache = exports.vgs_ResearchPlan_GetFirstObjAsync = exports.vgs_ResearchPlan_GetFirstID = exports.vgs_ResearchPlan_GetFirstIDAsync = exports.vgs_ResearchPlan_funcKey = exports.vgs_ResearchPlan_FilterFunByKey = exports.vgs_ResearchPlan_SortFunByKey = exports.vgs_ResearchPlan_SortFun_Defa_2Fld = exports.vgs_ResearchPlan_SortFun_Defa = exports.vgs_ResearchPlan_func = exports.vgs_ResearchPlan_GetNameByPlanId_Cache = exports.vgs_ResearchPlan_GetObjByPlanId_localStorage = exports.vgs_ResearchPlan_GetObjByPlanId_Cache = exports.vgs_ResearchPlan_GetObjByPlanIdAsync = exports.vgs_ResearchPlan_ConstructorName = exports.vgs_ResearchPlan_Controller = void 0;
    /**
     * 主题研究计划视图(vgs_ResearchPlan)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月13日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const enumComparisonOp_js_1 = require("../../PubFun/enumComparisonOp.js");
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsvgs_ResearchPlanEN_js_1 = require("../../L0_Entity/GraduateEduTopic/clsvgs_ResearchPlanEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.vgs_ResearchPlan_Controller = "vgs_ResearchPlanApi";
    exports.vgs_ResearchPlan_ConstructorName = "vgs_ResearchPlan";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strPlanId:关键字
    * @returns 对象
    **/
    async function vgs_ResearchPlan_GetObjByPlanIdAsync(strPlanId) {
        const strThisFuncName = "GetObjByPlanIdAsync";
        if ((0, clsString_js_1.IsNullOrEmpty)(strPlanId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strPlanId]不能为空！(In clsvgs_ResearchPlanWApi.GetObjByPlanIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strPlanId.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strPlanId]的长度:[{0}]不正确！(clsvgs_ResearchPlanWApi.GetObjByPlanIdAsync)", strPlanId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByPlanId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_ResearchPlan_Controller, strAction);
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
                const objvgs_ResearchPlan = vgs_ResearchPlan_GetObjFromJsonObj(returnObj);
                return objvgs_ResearchPlan;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_ResearchPlan_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_ResearchPlan_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_ResearchPlan_GetObjByPlanIdAsync = vgs_ResearchPlan_GetObjByPlanIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param strPlanId:所给的关键字
     * @returns 对象
    */
    async function vgs_ResearchPlan_GetObjByPlanId_Cache(strPlanId, strid_CurrEduCls, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByPlanId_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strPlanId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strPlanId]不能为空！(In clsvgs_ResearchPlanWApi.GetObjByPlanId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strPlanId.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strPlanId]的长度:[{0}]不正确！(clsvgs_ResearchPlanWApi.GetObjByPlanId_Cache)", strPlanId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrvgs_ResearchPlanObjLst_Cache = await vgs_ResearchPlan_GetObjLst_Cache(strid_CurrEduCls);
        try {
            const arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlanObjLst_Cache.filter(x => x.planId == strPlanId);
            let objvgs_ResearchPlan;
            if (arrvgs_ResearchPlan_Sel.length > 0) {
                objvgs_ResearchPlan = arrvgs_ResearchPlan_Sel[0];
                return objvgs_ResearchPlan;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    const objvgs_ResearchPlan_Const = await vgs_ResearchPlan_GetObjByPlanIdAsync(strPlanId);
                    if (objvgs_ResearchPlan_Const != null) {
                        vgs_ResearchPlan_ReFreshThisCache(strid_CurrEduCls);
                        return objvgs_ResearchPlan_Const;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strPlanId, exports.vgs_ResearchPlan_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.vgs_ResearchPlan_GetObjByPlanId_Cache = vgs_ResearchPlan_GetObjByPlanId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param strPlanId:所给的关键字
     * @returns 对象
    */
    async function vgs_ResearchPlan_GetObjByPlanId_localStorage(strPlanId) {
        const strThisFuncName = "GetObjByPlanId_localStorage";
        if ((0, clsString_js_1.IsNullOrEmpty)(strPlanId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strPlanId]不能为空！(In clsvgs_ResearchPlanWApi.GetObjByPlanId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strPlanId.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strPlanId]的长度:[{0}]不正确！(clsvgs_ResearchPlanWApi.GetObjByPlanId_localStorage)", strPlanId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN._CurrTabName, strPlanId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objvgs_ResearchPlan_Cache = JSON.parse(strTempObj);
            return objvgs_ResearchPlan_Cache;
        }
        try {
            const objvgs_ResearchPlan = await vgs_ResearchPlan_GetObjByPlanIdAsync(strPlanId);
            if (objvgs_ResearchPlan != null) {
                localStorage.setItem(strKey, JSON.stringify(objvgs_ResearchPlan));
                const strInfo = (0, clsString_js_1.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objvgs_ResearchPlan;
            }
            return objvgs_ResearchPlan;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strPlanId, exports.vgs_ResearchPlan_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.vgs_ResearchPlan_GetObjByPlanId_localStorage = vgs_ResearchPlan_GetObjByPlanId_localStorage;
    /**
     * 根据关键字获取相关对象的名称属性, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetNameByKeyId_Cache)
     * @param strPlanId:所给的关键字
     * @returns 对象
    */
    async function vgs_ResearchPlan_GetNameByPlanId_Cache(strPlanId, strid_CurrEduCls) {
        const strThisFuncName = "GetNameByPlanId_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strPlanId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strPlanId]不能为空！(In clsvgs_ResearchPlanWApi.GetNameByPlanId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strPlanId.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strPlanId]的长度:[{0}]不正确！(clsvgs_ResearchPlanWApi.GetNameByPlanId_Cache)", strPlanId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrvgs_ResearchPlanObjLst_Cache = await vgs_ResearchPlan_GetObjLst_Cache(strid_CurrEduCls);
        if (arrvgs_ResearchPlanObjLst_Cache == null)
            return "";
        try {
            const arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlanObjLst_Cache.filter(x => x.planId == strPlanId);
            let objvgs_ResearchPlan;
            if (arrvgs_ResearchPlan_Sel.length > 0) {
                objvgs_ResearchPlan = arrvgs_ResearchPlan_Sel[0];
                return objvgs_ResearchPlan.statusName;
            }
            else {
                return "";
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象名称属性不成功!", e, strPlanId);
            console.error(strMsg);
            alert(strMsg);
        }
        return "";
    }
    exports.vgs_ResearchPlan_GetNameByPlanId_Cache = vgs_ResearchPlan_GetNameByPlanId_Cache;
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
    async function vgs_ResearchPlan_func(strInFldName, strOutFldName, strInValue, strid_CurrEduCls_C) {
        //const strThisFuncName = "func";
        if ((0, clsString_js_1.IsNullOrEmpty)(strid_CurrEduCls_C) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strid_CurrEduCls_C]不能为空！(In clsvgs_ResearchPlanWApi.func)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls_C.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strid_CurrEduCls_C]的长度:[{0}]不正确！(clsvgs_ResearchPlanWApi.func)", strid_CurrEduCls_C.length);
            console.error(strMsg);
            throw (strMsg);
        }
        if (strInFldName != clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_PlanId) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_1.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strOutFldName, clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strPlanId = strInValue;
        if ((0, clsString_js_1.IsNullOrEmpty)(strInValue) == true) {
            return "";
        }
        const objvgs_ResearchPlan = await vgs_ResearchPlan_GetObjByPlanId_Cache(strPlanId, strid_CurrEduCls_C);
        if (objvgs_ResearchPlan == null)
            return "";
        if (objvgs_ResearchPlan.GetFldValue(strOutFldName) == null)
            return "";
        return objvgs_ResearchPlan.GetFldValue(strOutFldName).toString();
    }
    exports.vgs_ResearchPlan_func = vgs_ResearchPlan_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vgs_ResearchPlan_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.planId.localeCompare(b.planId);
    }
    exports.vgs_ResearchPlan_SortFun_Defa = vgs_ResearchPlan_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vgs_ResearchPlan_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.topicId == b.topicId)
            return a.topicName.localeCompare(b.topicName);
        else
            return a.topicId.localeCompare(b.topicId);
    }
    exports.vgs_ResearchPlan_SortFun_Defa_2Fld = vgs_ResearchPlan_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vgs_ResearchPlan_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_PlanId:
                    return (a, b) => {
                        return a.planId.localeCompare(b.planId);
                    };
                case clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_TopicId:
                    return (a, b) => {
                        return a.topicId.localeCompare(b.topicId);
                    };
                case clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_TopicName:
                    return (a, b) => {
                        if (a.topicName == null)
                            return -1;
                        if (b.topicName == null)
                            return 1;
                        return a.topicName.localeCompare(b.topicName);
                    };
                case clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_id_CurrEduCls:
                    return (a, b) => {
                        if (a.id_CurrEduCls == null)
                            return -1;
                        if (b.id_CurrEduCls == null)
                            return 1;
                        return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
                    };
                case clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_StatusId:
                    return (a, b) => {
                        return a.statusId.localeCompare(b.statusId);
                    };
                case clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_StatusName:
                    return (a, b) => {
                        if (a.statusName == null)
                            return -1;
                        if (b.statusName == null)
                            return 1;
                        return a.statusName.localeCompare(b.statusName);
                    };
                case clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_PlanContent:
                    return (a, b) => {
                        if (a.planContent == null)
                            return -1;
                        if (b.planContent == null)
                            return 1;
                        return a.planContent.localeCompare(b.planContent);
                    };
                case clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_ResponsibleUser:
                    return (a, b) => {
                        if (a.responsibleUser == null)
                            return -1;
                        if (b.responsibleUser == null)
                            return 1;
                        return a.responsibleUser.localeCompare(b.responsibleUser);
                    };
                case clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_StartDate:
                    return (a, b) => {
                        if (a.startDate == null)
                            return -1;
                        if (b.startDate == null)
                            return 1;
                        return a.startDate.localeCompare(b.startDate);
                    };
                case clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_EndDate:
                    return (a, b) => {
                        if (a.endDate == null)
                            return -1;
                        if (b.endDate == null)
                            return 1;
                        return a.endDate.localeCompare(b.endDate);
                    };
                case clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_ActualFinishingDate:
                    return (a, b) => {
                        if (a.actualFinishingDate == null)
                            return -1;
                        if (b.actualFinishingDate == null)
                            return 1;
                        return a.actualFinishingDate.localeCompare(b.actualFinishingDate);
                    };
                case clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_AcceptanceUser:
                    return (a, b) => {
                        if (a.acceptanceUser == null)
                            return -1;
                        if (b.acceptanceUser == null)
                            return 1;
                        return a.acceptanceUser.localeCompare(b.acceptanceUser);
                    };
                case clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_IsSubmit:
                    return (a, b) => {
                        if (a.isSubmit == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_UpdUser:
                    return (a, b) => {
                        if (a.updUser == null)
                            return -1;
                        if (b.updUser == null)
                            return 1;
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_UpdDate:
                    return (a, b) => {
                        if (a.updDate == null)
                            return -1;
                        if (b.updDate == null)
                            return 1;
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                case clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_PlanTypeId:
                    return (a, b) => {
                        if (a.planTypeId == null)
                            return -1;
                        if (b.planTypeId == null)
                            return 1;
                        return a.planTypeId.localeCompare(b.planTypeId);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vgs_ResearchPlan]中不存在！(in ${exports.vgs_ResearchPlan_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_PlanId:
                    return (a, b) => {
                        return b.planId.localeCompare(a.planId);
                    };
                case clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_TopicId:
                    return (a, b) => {
                        return b.topicId.localeCompare(a.topicId);
                    };
                case clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_TopicName:
                    return (a, b) => {
                        if (b.topicName == null)
                            return -1;
                        if (a.topicName == null)
                            return 1;
                        return b.topicName.localeCompare(a.topicName);
                    };
                case clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_id_CurrEduCls:
                    return (a, b) => {
                        if (b.id_CurrEduCls == null)
                            return -1;
                        if (a.id_CurrEduCls == null)
                            return 1;
                        return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
                    };
                case clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_StatusId:
                    return (a, b) => {
                        return b.statusId.localeCompare(a.statusId);
                    };
                case clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_StatusName:
                    return (a, b) => {
                        if (b.statusName == null)
                            return -1;
                        if (a.statusName == null)
                            return 1;
                        return b.statusName.localeCompare(a.statusName);
                    };
                case clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_PlanContent:
                    return (a, b) => {
                        if (b.planContent == null)
                            return -1;
                        if (a.planContent == null)
                            return 1;
                        return b.planContent.localeCompare(a.planContent);
                    };
                case clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_ResponsibleUser:
                    return (a, b) => {
                        if (b.responsibleUser == null)
                            return -1;
                        if (a.responsibleUser == null)
                            return 1;
                        return b.responsibleUser.localeCompare(a.responsibleUser);
                    };
                case clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_StartDate:
                    return (a, b) => {
                        if (b.startDate == null)
                            return -1;
                        if (a.startDate == null)
                            return 1;
                        return b.startDate.localeCompare(a.startDate);
                    };
                case clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_EndDate:
                    return (a, b) => {
                        if (b.endDate == null)
                            return -1;
                        if (a.endDate == null)
                            return 1;
                        return b.endDate.localeCompare(a.endDate);
                    };
                case clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_ActualFinishingDate:
                    return (a, b) => {
                        if (b.actualFinishingDate == null)
                            return -1;
                        if (a.actualFinishingDate == null)
                            return 1;
                        return b.actualFinishingDate.localeCompare(a.actualFinishingDate);
                    };
                case clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_AcceptanceUser:
                    return (a, b) => {
                        if (b.acceptanceUser == null)
                            return -1;
                        if (a.acceptanceUser == null)
                            return 1;
                        return b.acceptanceUser.localeCompare(a.acceptanceUser);
                    };
                case clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_IsSubmit:
                    return (a, b) => {
                        if (b.isSubmit == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_UpdUser:
                    return (a, b) => {
                        if (b.updUser == null)
                            return -1;
                        if (a.updUser == null)
                            return 1;
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_UpdDate:
                    return (a, b) => {
                        if (b.updDate == null)
                            return -1;
                        if (a.updDate == null)
                            return 1;
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                case clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_PlanTypeId:
                    return (a, b) => {
                        if (b.planTypeId == null)
                            return -1;
                        if (a.planTypeId == null)
                            return 1;
                        return b.planTypeId.localeCompare(a.planTypeId);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vgs_ResearchPlan]中不存在！(in ${exports.vgs_ResearchPlan_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.vgs_ResearchPlan_SortFunByKey = vgs_ResearchPlan_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function vgs_ResearchPlan_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_PlanId:
                return (obj) => {
                    return obj.planId === value;
                };
            case clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_TopicId:
                return (obj) => {
                    return obj.topicId === value;
                };
            case clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_TopicName:
                return (obj) => {
                    return obj.topicName === value;
                };
            case clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_id_CurrEduCls:
                return (obj) => {
                    return obj.id_CurrEduCls === value;
                };
            case clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_StatusId:
                return (obj) => {
                    return obj.statusId === value;
                };
            case clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_StatusName:
                return (obj) => {
                    return obj.statusName === value;
                };
            case clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_PlanContent:
                return (obj) => {
                    return obj.planContent === value;
                };
            case clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_ResponsibleUser:
                return (obj) => {
                    return obj.responsibleUser === value;
                };
            case clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_StartDate:
                return (obj) => {
                    return obj.startDate === value;
                };
            case clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_EndDate:
                return (obj) => {
                    return obj.endDate === value;
                };
            case clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_ActualFinishingDate:
                return (obj) => {
                    return obj.actualFinishingDate === value;
                };
            case clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_AcceptanceUser:
                return (obj) => {
                    return obj.acceptanceUser === value;
                };
            case clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_IsSubmit:
                return (obj) => {
                    return obj.isSubmit === value;
                };
            case clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            case clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_PlanTypeId:
                return (obj) => {
                    return obj.planTypeId === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[vgs_ResearchPlan]中不存在！(in ${exports.vgs_ResearchPlan_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.vgs_ResearchPlan_FilterFunByKey = vgs_ResearchPlan_FilterFunByKey;
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
    async function vgs_ResearchPlan_funcKey(strInFldName, strInValue, strComparisonOp, strid_CurrEduCls_C) {
        //const strThisFuncName = "funcKey";
        if ((0, clsString_js_1.IsNullOrEmpty)(strid_CurrEduCls_C) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strid_CurrEduCls_C]不能为空！(In clsvgs_ResearchPlanWApi.funcKey)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls_C.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strid_CurrEduCls_C]的长度:[{0}]不正确！(clsvgs_ResearchPlanWApi.funcKey)", strid_CurrEduCls_C.length);
            console.error(strMsg);
            throw (strMsg);
        }
        if (strInFldName == clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_PlanId) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(strInValue) == true) {
            return [];
        }
        const arrvgs_ResearchPlan = await vgs_ResearchPlan_GetObjLst_Cache(strid_CurrEduCls_C);
        if (arrvgs_ResearchPlan == null)
            return [];
        let arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan;
        const strType = typeof (strInValue);
        switch (strType) {
            case "string":
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01: // " = "
                        arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.Like_03:
                        arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.In_04:
                        const arrValues = strInValue.split(',');
                        arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
                        break;
                }
                break;
            case "boolean":
                if (strInValue == null)
                    return [];
                if (strComparisonOp == enumComparisonOp_js_1.enumComparisonOp.Equal_01) {
                    arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                }
                break;
            case "number":
                if (Number(strInValue) == 0)
                    return [];
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01:
                        arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotEqual_02:
                        arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotLessThan_05: //" >= ":
                        arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotGreaterThan_06: //" <= ":
                        arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.GreaterThan_07: //" > ":
                        arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.LessThan_08: //" < ":
                        arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                }
                break;
        }
        if (arrvgs_ResearchPlan_Sel.length == 0)
            return [];
        return arrvgs_ResearchPlan_Sel.map(x => x.planId);
    }
    exports.vgs_ResearchPlan_funcKey = vgs_ResearchPlan_funcKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function vgs_ResearchPlan_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_ResearchPlan_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_ResearchPlan_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_ResearchPlan_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_ResearchPlan_GetFirstIDAsync = vgs_ResearchPlan_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function vgs_ResearchPlan_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_ResearchPlan_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_ResearchPlan_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_ResearchPlan_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_ResearchPlan_GetFirstID = vgs_ResearchPlan_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function vgs_ResearchPlan_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_ResearchPlan_Controller, strAction);
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
                const objvgs_ResearchPlan = vgs_ResearchPlan_GetObjFromJsonObj(returnObj);
                return objvgs_ResearchPlan;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_ResearchPlan_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_ResearchPlan_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_ResearchPlan_GetFirstObjAsync = vgs_ResearchPlan_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vgs_ResearchPlan_GetObjLst_ClientCache(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.WhereFormat) == false) {
            strWhereCond = (0, clsString_js_1.Format)(clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.WhereFormat, strid_CurrEduCls);
        }
        else {
            strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN._CurrTabName, strid_CurrEduCls);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_1.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrvgs_ResearchPlanExObjLst_Cache = CacheHelper_js_1.CacheHelper.Get(strKey);
            const arrvgs_ResearchPlanObjLst_T = vgs_ResearchPlan_GetObjLstByJSONObjLst(arrvgs_ResearchPlanExObjLst_Cache);
            return arrvgs_ResearchPlanObjLst_T;
        }
        try {
            const arrvgs_ResearchPlanExObjLst = await vgs_ResearchPlan_GetObjLstAsync(strWhereCond);
            CacheHelper_js_1.CacheHelper.Add(strKey, arrvgs_ResearchPlanExObjLst);
            const strInfo = (0, clsString_js_1.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvgs_ResearchPlanExObjLst.length);
            console.log(strInfo);
            return arrvgs_ResearchPlanExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vgs_ResearchPlan_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vgs_ResearchPlan_GetObjLst_ClientCache = vgs_ResearchPlan_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vgs_ResearchPlan_GetObjLst_localStorage(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.WhereFormat) == false) {
            strWhereCond = (0, clsString_js_1.Format)(clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.WhereFormat, strid_CurrEduCls);
        }
        else {
            strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN._CurrTabName, strid_CurrEduCls);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrvgs_ResearchPlanExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrvgs_ResearchPlanObjLst_T = vgs_ResearchPlan_GetObjLstByJSONObjLst(arrvgs_ResearchPlanExObjLst_Cache);
            return arrvgs_ResearchPlanObjLst_T;
        }
        try {
            const arrvgs_ResearchPlanExObjLst = await vgs_ResearchPlan_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrvgs_ResearchPlanExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvgs_ResearchPlanExObjLst.length);
            console.log(strInfo);
            return arrvgs_ResearchPlanExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vgs_ResearchPlan_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vgs_ResearchPlan_GetObjLst_localStorage = vgs_ResearchPlan_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vgs_ResearchPlan_GetObjLst_localStorage_PureCache(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN._CurrTabName, strid_CurrEduCls);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrvgs_ResearchPlanObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvgs_ResearchPlanObjLst_Cache;
        }
        else
            return null;
    }
    exports.vgs_ResearchPlan_GetObjLst_localStorage_PureCache = vgs_ResearchPlan_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function vgs_ResearchPlan_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_ResearchPlan_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vgs_ResearchPlan_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vgs_ResearchPlan_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_ResearchPlan_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_ResearchPlan_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_ResearchPlan_GetObjLstAsync = vgs_ResearchPlan_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vgs_ResearchPlan_GetObjLst_sessionStorage(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.WhereFormat) == false) {
            strWhereCond = (0, clsString_js_1.Format)(clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.WhereFormat, strid_CurrEduCls);
        }
        else {
            strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN._CurrTabName, strid_CurrEduCls);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrvgs_ResearchPlanExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrvgs_ResearchPlanObjLst_T = vgs_ResearchPlan_GetObjLstByJSONObjLst(arrvgs_ResearchPlanExObjLst_Cache);
            return arrvgs_ResearchPlanObjLst_T;
        }
        try {
            const arrvgs_ResearchPlanExObjLst = await vgs_ResearchPlan_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrvgs_ResearchPlanExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvgs_ResearchPlanExObjLst.length);
            console.log(strInfo);
            return arrvgs_ResearchPlanExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vgs_ResearchPlan_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vgs_ResearchPlan_GetObjLst_sessionStorage = vgs_ResearchPlan_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vgs_ResearchPlan_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN._CurrTabName, strid_CurrEduCls);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrvgs_ResearchPlanObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvgs_ResearchPlanObjLst_Cache;
        }
        else
            return null;
    }
    exports.vgs_ResearchPlan_GetObjLst_sessionStorage_PureCache = vgs_ResearchPlan_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vgs_ResearchPlan_GetObjLst_Cache(strid_CurrEduCls) {
        //const strThisFuncName = "GetObjLst_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strid_CurrEduCls) == true) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[id_CurrEduCls]不能为空！(in clsvgs_ResearchPlanWApi.vgs_ResearchPlan_GetObjLst_Cache() )");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strid_CurrEduCls]的长度:[{0}]不正确！(in clsvgs_ResearchPlanWApi.vgs_ResearchPlan_GetObjLst_Cache() )", strid_CurrEduCls.length);
            console.error(strMsg);
            throw (strMsg);
        }
        let arrvgs_ResearchPlanObjLst_Cache;
        switch (clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.CacheModeId) {
            case "04": //sessionStorage
                arrvgs_ResearchPlanObjLst_Cache = await vgs_ResearchPlan_GetObjLst_sessionStorage(strid_CurrEduCls);
                break;
            case "03": //localStorage
                arrvgs_ResearchPlanObjLst_Cache = await vgs_ResearchPlan_GetObjLst_localStorage(strid_CurrEduCls);
                break;
            case "02": //ClientCache
                arrvgs_ResearchPlanObjLst_Cache = await vgs_ResearchPlan_GetObjLst_ClientCache(strid_CurrEduCls);
                break;
            default:
                arrvgs_ResearchPlanObjLst_Cache = await vgs_ResearchPlan_GetObjLst_ClientCache(strid_CurrEduCls);
                break;
        }
        const arrvgs_ResearchPlanObjLst = vgs_ResearchPlan_GetObjLstByJSONObjLst(arrvgs_ResearchPlanObjLst_Cache);
        return arrvgs_ResearchPlanObjLst_Cache;
    }
    exports.vgs_ResearchPlan_GetObjLst_Cache = vgs_ResearchPlan_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vgs_ResearchPlan_GetObjLst_PureCache(strid_CurrEduCls) {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrvgs_ResearchPlanObjLst_Cache;
        switch (clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.CacheModeId) {
            case "04": //sessionStorage
                arrvgs_ResearchPlanObjLst_Cache = await vgs_ResearchPlan_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls);
                break;
            case "03": //localStorage
                arrvgs_ResearchPlanObjLst_Cache = await vgs_ResearchPlan_GetObjLst_localStorage_PureCache(strid_CurrEduCls);
                break;
            case "02": //ClientCache
                arrvgs_ResearchPlanObjLst_Cache = null;
                break;
            default:
                arrvgs_ResearchPlanObjLst_Cache = null;
                break;
        }
        return arrvgs_ResearchPlanObjLst_Cache;
    }
    exports.vgs_ResearchPlan_GetObjLst_PureCache = vgs_ResearchPlan_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objstrPlanId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function vgs_ResearchPlan_GetSubObjLst_Cache(objvgs_ResearchPlan_Cond, strid_CurrEduCls) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrvgs_ResearchPlanObjLst_Cache = await vgs_ResearchPlan_GetObjLst_Cache(strid_CurrEduCls);
        let arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlanObjLst_Cache;
        if (objvgs_ResearchPlan_Cond.sf_FldComparisonOp == null || objvgs_ResearchPlan_Cond.sf_FldComparisonOp == "")
            return arrvgs_ResearchPlan_Sel;
        const dicFldComparisonOp = JSON.parse(objvgs_ResearchPlan_Cond.sf_FldComparisonOp);
        //console.log("clsvgs_ResearchPlanWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvgs_ResearchPlan_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvgs_ResearchPlan_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrvgs_ResearchPlan_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objvgs_ResearchPlan_Cond), exports.vgs_ResearchPlan_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vgs_ResearchPlan_GetSubObjLst_Cache = vgs_ResearchPlan_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrPlanId:关键字列表
    * @returns 对象列表
    **/
    async function vgs_ResearchPlan_GetObjLstByPlanIdLstAsync(arrPlanId) {
        const strThisFuncName = "GetObjLstByPlanIdLstAsync";
        const strAction = "GetObjLstByPlanIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_ResearchPlan_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrPlanId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vgs_ResearchPlan_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vgs_ResearchPlan_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_ResearchPlan_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_ResearchPlan_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_ResearchPlan_GetObjLstByPlanIdLstAsync = vgs_ResearchPlan_GetObjLstByPlanIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrstrPlanIdLst:关键字列表
     * @returns 对象列表
    */
    async function vgs_ResearchPlan_GetObjLstByPlanIdLst_Cache(arrPlanIdLst, strid_CurrEduCls) {
        const strThisFuncName = "GetObjLstByPlanIdLst_Cache";
        try {
            const arrvgs_ResearchPlanObjLst_Cache = await vgs_ResearchPlan_GetObjLst_Cache(strid_CurrEduCls);
            const arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlanObjLst_Cache.filter(x => arrPlanIdLst.indexOf(x.planId) > -1);
            return arrvgs_ResearchPlan_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrPlanIdLst.join(","), exports.vgs_ResearchPlan_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
    }
    exports.vgs_ResearchPlan_GetObjLstByPlanIdLst_Cache = vgs_ResearchPlan_GetObjLstByPlanIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function vgs_ResearchPlan_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_ResearchPlan_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vgs_ResearchPlan_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vgs_ResearchPlan_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_ResearchPlan_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_ResearchPlan_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_ResearchPlan_GetTopObjLstAsync = vgs_ResearchPlan_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vgs_ResearchPlan_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_ResearchPlan_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vgs_ResearchPlan_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vgs_ResearchPlan_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_ResearchPlan_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_ResearchPlan_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_ResearchPlan_GetObjLstByRangeAsync = vgs_ResearchPlan_GetObjLstByRangeAsync;
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
    async function vgs_ResearchPlan_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_ResearchPlan_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_ResearchPlan_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_ResearchPlan_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_ResearchPlan_GetObjLstByRange = vgs_ResearchPlan_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function vgs_ResearchPlan_GetObjLstByPager_Cache(objPagerPara, strid_CurrEduCls) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const arrvgs_ResearchPlanObjLst_Cache = await vgs_ResearchPlan_GetObjLst_Cache(strid_CurrEduCls);
        if (arrvgs_ResearchPlanObjLst_Cache.length == 0)
            return arrvgs_ResearchPlanObjLst_Cache;
        let arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlanObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objvgs_ResearchPlan_Cond = new clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvgs_ResearchPlan_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsvgs_ResearchPlanWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvgs_ResearchPlan_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvgs_ResearchPlan_Sel.length == 0)
                return arrvgs_ResearchPlan_Sel;
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
                arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.sort(vgs_ResearchPlan_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.sort(objPagerPara.sortFun);
            }
            arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.slice(intStart, intEnd);
            return arrvgs_ResearchPlan_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.vgs_ResearchPlan_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vgs_ResearchPlan_GetObjLstByPager_Cache = vgs_ResearchPlan_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vgs_ResearchPlan_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_ResearchPlan_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vgs_ResearchPlan_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vgs_ResearchPlan_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_ResearchPlan_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_ResearchPlan_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_ResearchPlan_GetObjLstByPagerAsync = vgs_ResearchPlan_GetObjLstByPagerAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objstrPlanId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function vgs_ResearchPlan_IsExistRecord_Cache(objvgs_ResearchPlan_Cond, strid_CurrEduCls) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrvgs_ResearchPlanObjLst_Cache = await vgs_ResearchPlan_GetObjLst_Cache(strid_CurrEduCls);
        if (arrvgs_ResearchPlanObjLst_Cache == null)
            return false;
        let arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlanObjLst_Cache;
        if (objvgs_ResearchPlan_Cond.sf_FldComparisonOp == null || objvgs_ResearchPlan_Cond.sf_FldComparisonOp == "")
            return arrvgs_ResearchPlan_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objvgs_ResearchPlan_Cond.sf_FldComparisonOp);
        //console.log("clsvgs_ResearchPlanWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvgs_ResearchPlan_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvgs_ResearchPlan_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvgs_ResearchPlan_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objvgs_ResearchPlan_Cond), exports.vgs_ResearchPlan_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.vgs_ResearchPlan_IsExistRecord_Cache = vgs_ResearchPlan_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function vgs_ResearchPlan_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_ResearchPlan_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_ResearchPlan_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_ResearchPlan_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_ResearchPlan_IsExistRecordAsync = vgs_ResearchPlan_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strPlanId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function vgs_ResearchPlan_IsExist(strPlanId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_ResearchPlan_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_ResearchPlan_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_ResearchPlan_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_ResearchPlan_IsExist = vgs_ResearchPlan_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param strPlanId:所给的关键字
     * @returns 对象
    */
    async function vgs_ResearchPlan_IsExist_Cache(strPlanId, strid_CurrEduCls) {
        const strThisFuncName = "IsExist_Cache";
        const arrvgs_ResearchPlanObjLst_Cache = await vgs_ResearchPlan_GetObjLst_Cache(strid_CurrEduCls);
        if (arrvgs_ResearchPlanObjLst_Cache == null)
            return false;
        try {
            const arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlanObjLst_Cache.filter(x => x.planId == strPlanId);
            if (arrvgs_ResearchPlan_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strPlanId, exports.vgs_ResearchPlan_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.vgs_ResearchPlan_IsExist_Cache = vgs_ResearchPlan_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strPlanId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function vgs_ResearchPlan_IsExistAsync(strPlanId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_ResearchPlan_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_ResearchPlan_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_ResearchPlan_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_ResearchPlan_IsExistAsync = vgs_ResearchPlan_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function vgs_ResearchPlan_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_ResearchPlan_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_ResearchPlan_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_ResearchPlan_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_ResearchPlan_GetRecCountByCondAsync = vgs_ResearchPlan_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objvgs_ResearchPlan_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function vgs_ResearchPlan_GetRecCountByCond_Cache(objvgs_ResearchPlan_Cond, strid_CurrEduCls) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrvgs_ResearchPlanObjLst_Cache = await vgs_ResearchPlan_GetObjLst_Cache(strid_CurrEduCls);
        if (arrvgs_ResearchPlanObjLst_Cache == null)
            return 0;
        let arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlanObjLst_Cache;
        if (objvgs_ResearchPlan_Cond.sf_FldComparisonOp == null || objvgs_ResearchPlan_Cond.sf_FldComparisonOp == "")
            return arrvgs_ResearchPlan_Sel.length;
        const dicFldComparisonOp = JSON.parse(objvgs_ResearchPlan_Cond.sf_FldComparisonOp);
        //console.log("clsvgs_ResearchPlanWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvgs_ResearchPlan_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvgs_ResearchPlan_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvgs_ResearchPlan_Sel = arrvgs_ResearchPlan_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrvgs_ResearchPlan_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objvgs_ResearchPlan_Cond), exports.vgs_ResearchPlan_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.vgs_ResearchPlan_GetRecCountByCond_Cache = vgs_ResearchPlan_GetRecCountByCond_Cache;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function vgs_ResearchPlan_GetWebApiUrl(strController, strAction) {
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
    exports.vgs_ResearchPlan_GetWebApiUrl = vgs_ResearchPlan_GetWebApiUrl;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function vgs_ResearchPlan_ReFreshThisCache(strid_CurrEduCls) {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN._CurrTabName, strid_CurrEduCls);
            switch (clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.CacheModeId) {
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
    exports.vgs_ResearchPlan_ReFreshThisCache = vgs_ResearchPlan_ReFreshThisCache;
    /**
     * 绑定基于Web的下拉框,在某一层下的下拉框
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunctionInDiv)
     * @param objDDL:需要绑定当前表的下拉框
    */
    async function vgs_ResearchPlan__Cache(strDivName, strDdlName, strid_CurrEduCls) {
        const strThisFuncName = "_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strid_CurrEduCls) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strid_CurrEduCls]不能为空！(In clsvgs_ResearchPlanWApi.)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strid_CurrEduCls]的长度:[{0}]不正确！(clsvgs_ResearchPlanWApi.)", strid_CurrEduCls.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const objDdl = document.getElementById(strDdlName);
        if (objDdl == null) {
            const strMsg = (0, clsString_js_1.Format)("下拉框：{0} 不存在！(In )", strDdlName);
            alert(strMsg);
            console.error(strMsg);
            throw (strMsg);
        }
        //为数据源于表的下拉框设置内容
        //console.log("开始：_Cache");
        const arrObjLst_Sel = await vgs_ResearchPlan_GetObjLst_Cache(strid_CurrEduCls);
        if (arrObjLst_Sel == null)
            return;
        (0, clsCommFunc4Web_js_1.BindDdl_ObjLstInDiv_V)(strDivName, strDdlName, arrObjLst_Sel, clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_StatusId, clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_StatusName, "主题研究计划视图");
    }
    exports.vgs_ResearchPlan__Cache = vgs_ResearchPlan__Cache;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vgs_ResearchPlan_GetJSONStrByObj(pobjvgs_ResearchPlanEN) {
        const strThisFuncName = "GetJSONStrByObj";
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjvgs_ResearchPlanEN);
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
    exports.vgs_ResearchPlan_GetJSONStrByObj = vgs_ResearchPlan_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function vgs_ResearchPlan_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrvgs_ResearchPlanObjLst = new Array();
        if (strJSON === "") {
            return arrvgs_ResearchPlanObjLst;
        }
        try {
            arrvgs_ResearchPlanObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrvgs_ResearchPlanObjLst;
        }
        return arrvgs_ResearchPlanObjLst;
    }
    exports.vgs_ResearchPlan_GetObjLstByJSONStr = vgs_ResearchPlan_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrvgs_ResearchPlanObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function vgs_ResearchPlan_GetObjLstByJSONObjLst(arrvgs_ResearchPlanObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrvgs_ResearchPlanObjLst = new Array();
        for (const objInFor of arrvgs_ResearchPlanObjLstS) {
            const obj1 = vgs_ResearchPlan_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrvgs_ResearchPlanObjLst.push(obj1);
        }
        return arrvgs_ResearchPlanObjLst;
    }
    exports.vgs_ResearchPlan_GetObjLstByJSONObjLst = vgs_ResearchPlan_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vgs_ResearchPlan_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjvgs_ResearchPlanEN = new clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN();
        if (strJSON === "") {
            return pobjvgs_ResearchPlanEN;
        }
        try {
            pobjvgs_ResearchPlanEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjvgs_ResearchPlanEN;
        }
        return pobjvgs_ResearchPlanEN;
    }
    exports.vgs_ResearchPlan_GetObjByJSONStr = vgs_ResearchPlan_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function vgs_ResearchPlan_GetCombineCondition(objvgs_ResearchPlan_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objvgs_ResearchPlan_Cond.dicFldComparisonOp, clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_PlanId) == true) {
            const strComparisonOp_PlanId = objvgs_ResearchPlan_Cond.dicFldComparisonOp[clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_PlanId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_PlanId, objvgs_ResearchPlan_Cond.planId, strComparisonOp_PlanId);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_ResearchPlan_Cond.dicFldComparisonOp, clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_TopicId) == true) {
            const strComparisonOp_TopicId = objvgs_ResearchPlan_Cond.dicFldComparisonOp[clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_TopicId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_TopicId, objvgs_ResearchPlan_Cond.topicId, strComparisonOp_TopicId);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_ResearchPlan_Cond.dicFldComparisonOp, clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_TopicName) == true) {
            const strComparisonOp_TopicName = objvgs_ResearchPlan_Cond.dicFldComparisonOp[clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_TopicName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_TopicName, objvgs_ResearchPlan_Cond.topicName, strComparisonOp_TopicName);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_ResearchPlan_Cond.dicFldComparisonOp, clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_id_CurrEduCls) == true) {
            const strComparisonOp_id_CurrEduCls = objvgs_ResearchPlan_Cond.dicFldComparisonOp[clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_id_CurrEduCls];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_id_CurrEduCls, objvgs_ResearchPlan_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_ResearchPlan_Cond.dicFldComparisonOp, clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_StatusId) == true) {
            const strComparisonOp_StatusId = objvgs_ResearchPlan_Cond.dicFldComparisonOp[clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_StatusId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_StatusId, objvgs_ResearchPlan_Cond.statusId, strComparisonOp_StatusId);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_ResearchPlan_Cond.dicFldComparisonOp, clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_StatusName) == true) {
            const strComparisonOp_StatusName = objvgs_ResearchPlan_Cond.dicFldComparisonOp[clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_StatusName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_StatusName, objvgs_ResearchPlan_Cond.statusName, strComparisonOp_StatusName);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_ResearchPlan_Cond.dicFldComparisonOp, clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_PlanContent) == true) {
            const strComparisonOp_PlanContent = objvgs_ResearchPlan_Cond.dicFldComparisonOp[clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_PlanContent];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_PlanContent, objvgs_ResearchPlan_Cond.planContent, strComparisonOp_PlanContent);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_ResearchPlan_Cond.dicFldComparisonOp, clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_ResponsibleUser) == true) {
            const strComparisonOp_ResponsibleUser = objvgs_ResearchPlan_Cond.dicFldComparisonOp[clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_ResponsibleUser];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_ResponsibleUser, objvgs_ResearchPlan_Cond.responsibleUser, strComparisonOp_ResponsibleUser);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_ResearchPlan_Cond.dicFldComparisonOp, clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_StartDate) == true) {
            const strComparisonOp_StartDate = objvgs_ResearchPlan_Cond.dicFldComparisonOp[clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_StartDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_StartDate, objvgs_ResearchPlan_Cond.startDate, strComparisonOp_StartDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_ResearchPlan_Cond.dicFldComparisonOp, clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_EndDate) == true) {
            const strComparisonOp_EndDate = objvgs_ResearchPlan_Cond.dicFldComparisonOp[clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_EndDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_EndDate, objvgs_ResearchPlan_Cond.endDate, strComparisonOp_EndDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_ResearchPlan_Cond.dicFldComparisonOp, clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_ActualFinishingDate) == true) {
            const strComparisonOp_ActualFinishingDate = objvgs_ResearchPlan_Cond.dicFldComparisonOp[clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_ActualFinishingDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_ActualFinishingDate, objvgs_ResearchPlan_Cond.actualFinishingDate, strComparisonOp_ActualFinishingDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_ResearchPlan_Cond.dicFldComparisonOp, clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_AcceptanceUser) == true) {
            const strComparisonOp_AcceptanceUser = objvgs_ResearchPlan_Cond.dicFldComparisonOp[clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_AcceptanceUser];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_AcceptanceUser, objvgs_ResearchPlan_Cond.acceptanceUser, strComparisonOp_AcceptanceUser);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_ResearchPlan_Cond.dicFldComparisonOp, clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_IsSubmit) == true) {
            if (objvgs_ResearchPlan_Cond.isSubmit == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_IsSubmit);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_IsSubmit);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_ResearchPlan_Cond.dicFldComparisonOp, clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objvgs_ResearchPlan_Cond.dicFldComparisonOp[clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_UpdUser];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_UpdUser, objvgs_ResearchPlan_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_ResearchPlan_Cond.dicFldComparisonOp, clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objvgs_ResearchPlan_Cond.dicFldComparisonOp[clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_UpdDate, objvgs_ResearchPlan_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_ResearchPlan_Cond.dicFldComparisonOp, clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_Memo) == true) {
            const strComparisonOp_Memo = objvgs_ResearchPlan_Cond.dicFldComparisonOp[clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_Memo, objvgs_ResearchPlan_Cond.memo, strComparisonOp_Memo);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_ResearchPlan_Cond.dicFldComparisonOp, clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_PlanTypeId) == true) {
            const strComparisonOp_PlanTypeId = objvgs_ResearchPlan_Cond.dicFldComparisonOp[clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_PlanTypeId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_PlanTypeId, objvgs_ResearchPlan_Cond.planTypeId, strComparisonOp_PlanTypeId);
        }
        return strWhereCond;
    }
    exports.vgs_ResearchPlan_GetCombineCondition = vgs_ResearchPlan_GetCombineCondition;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objvgs_ResearchPlanENS:源对象
     * @param objvgs_ResearchPlanENT:目标对象
    */
    function vgs_ResearchPlan_CopyObjTo(objvgs_ResearchPlanENS, objvgs_ResearchPlanENT) {
        objvgs_ResearchPlanENT.planId = objvgs_ResearchPlanENS.planId; //计划Id
        objvgs_ResearchPlanENT.topicId = objvgs_ResearchPlanENS.topicId; //主题Id
        objvgs_ResearchPlanENT.topicName = objvgs_ResearchPlanENS.topicName; //栏目主题
        objvgs_ResearchPlanENT.id_CurrEduCls = objvgs_ResearchPlanENS.id_CurrEduCls; //教学班流水号
        objvgs_ResearchPlanENT.statusId = objvgs_ResearchPlanENS.statusId; //状态Id
        objvgs_ResearchPlanENT.statusName = objvgs_ResearchPlanENS.statusName; //状态名称
        objvgs_ResearchPlanENT.planContent = objvgs_ResearchPlanENS.planContent; //计划内容
        objvgs_ResearchPlanENT.responsibleUser = objvgs_ResearchPlanENS.responsibleUser; //负责人/小组
        objvgs_ResearchPlanENT.startDate = objvgs_ResearchPlanENS.startDate; //开始日期
        objvgs_ResearchPlanENT.endDate = objvgs_ResearchPlanENS.endDate; //截止日期
        objvgs_ResearchPlanENT.actualFinishingDate = objvgs_ResearchPlanENS.actualFinishingDate; //实际完成日期
        objvgs_ResearchPlanENT.acceptanceUser = objvgs_ResearchPlanENS.acceptanceUser; //验收用户
        objvgs_ResearchPlanENT.isSubmit = objvgs_ResearchPlanENS.isSubmit; //是否提交
        objvgs_ResearchPlanENT.updUser = objvgs_ResearchPlanENS.updUser; //修改人
        objvgs_ResearchPlanENT.updDate = objvgs_ResearchPlanENS.updDate; //修改日期
        objvgs_ResearchPlanENT.memo = objvgs_ResearchPlanENS.memo; //备注
        objvgs_ResearchPlanENT.planTypeId = objvgs_ResearchPlanENS.planTypeId; //计划类型
    }
    exports.vgs_ResearchPlan_CopyObjTo = vgs_ResearchPlan_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objvgs_ResearchPlanENS:源对象
     * @param objvgs_ResearchPlanENT:目标对象
    */
    function vgs_ResearchPlan_GetObjFromJsonObj(objvgs_ResearchPlanENS) {
        const objvgs_ResearchPlanENT = new clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvgs_ResearchPlanENT, objvgs_ResearchPlanENS);
        return objvgs_ResearchPlanENT;
    }
    exports.vgs_ResearchPlan_GetObjFromJsonObj = vgs_ResearchPlan_GetObjFromJsonObj;
});
