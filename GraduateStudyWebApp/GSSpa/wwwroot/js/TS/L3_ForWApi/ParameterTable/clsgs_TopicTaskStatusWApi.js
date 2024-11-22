/**
* 类名:clsgs_TopicTaskStatusWApi
* 表名:gs_TopicTaskStatus(01120664)
* 生成代码版本:2022.11.02.1
* 生成日期:2022/11/02 11:46:24
* 生成者:pyf
* 生成服务器IP:
工程名称:问卷调查(0112)
CM工程:研究生论文学习(变量首字母小写)-全部函数集
* 相关数据库:103.116.76.183,9433EduHigh_Jsie
* PrjDataBaseId:0170
模块中文名:研培参数(ParameterTable)
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
        define(["require", "exports", "axios", "../../PubFun/CacheHelper.js", "../../L0_Entity/ParameterTable/clsgs_TopicTaskStatusEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsSysPara4WebApi.js", "../../PubFun/CacheHelper.js", "../../PubFun/jsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.gs_TopicTaskStatus_GetObjFromJsonObj = exports.gs_TopicTaskStatus_CopyObjTo = exports.gs_TopicTaskStatus_GetCombineCondition = exports.gs_TopicTaskStatus_GetObjByJSONStr = exports.gs_TopicTaskStatus_GetObjLstByJSONObjLst = exports.gs_TopicTaskStatus_GetObjLstByJSONStr = exports.gs_TopicTaskStatus_GetJSONStrByObj = exports.gs_TopicTaskStatus_CheckProperty4Update = exports.gs_TopicTaskStatus_CheckPropertyNew = exports.gs_TopicTaskStatus_BindDdl_StatusIdInDiv_Cache = exports.gs_TopicTaskStatus_ReFreshThisCache = exports.gs_TopicTaskStatus_ReFreshCache = exports.gs_TopicTaskStatus_GetWebApiUrl = exports.gs_TopicTaskStatus_GetMaxStrIdByPrefix = exports.gs_TopicTaskStatus_GetRecCountByCond_Cache = exports.gs_TopicTaskStatus_GetRecCountByCondAsync = exports.gs_TopicTaskStatus_IsExistAsync = exports.gs_TopicTaskStatus_IsExist_Cache = exports.gs_TopicTaskStatus_IsExist = exports.gs_TopicTaskStatus_IsExistRecordAsync = exports.gs_TopicTaskStatus_IsExistRecord_Cache = exports.gs_TopicTaskStatus_UpdateWithConditionAsync = exports.gs_TopicTaskStatus_UpdateRecordAsync = exports.gs_TopicTaskStatus_AddNewRecordWithReturnKey = exports.gs_TopicTaskStatus_AddNewRecordWithReturnKeyAsync = exports.gs_TopicTaskStatus_AddNewRecordWithMaxIdAsync = exports.gs_TopicTaskStatus_AddNewRecordAsync = exports.gs_TopicTaskStatus_Delgs_TopicTaskStatussByCondAsync = exports.gs_TopicTaskStatus_Delgs_TopicTaskStatussAsync = exports.gs_TopicTaskStatus_DelRecordAsync = exports.gs_TopicTaskStatus_GetObjLstByPagerAsync = exports.gs_TopicTaskStatus_GetObjLstByPager_Cache = exports.gs_TopicTaskStatus_GetObjLstByRange = exports.gs_TopicTaskStatus_GetObjLstByRangeAsync = exports.gs_TopicTaskStatus_GetTopObjLstAsync = exports.gs_TopicTaskStatus_GetObjLstByStatusIdLst_Cache = exports.gs_TopicTaskStatus_GetObjLstByStatusIdLstAsync = exports.gs_TopicTaskStatus_GetSubObjLst_Cache = exports.gs_TopicTaskStatus_GetObjLst_PureCache = exports.gs_TopicTaskStatus_GetObjLst_Cache = exports.gs_TopicTaskStatus_GetObjLst_sessionStorage_PureCache = exports.gs_TopicTaskStatus_GetObjLst_sessionStorage = exports.gs_TopicTaskStatus_GetObjLstAsync = exports.gs_TopicTaskStatus_GetObjLst_localStorage_PureCache = exports.gs_TopicTaskStatus_GetObjLst_localStorage = exports.gs_TopicTaskStatus_GetObjLst_ClientCache = exports.gs_TopicTaskStatus_GetFirstObjAsync = exports.gs_TopicTaskStatus_GetFirstID = exports.gs_TopicTaskStatus_GetFirstIDAsync = exports.gs_TopicTaskStatus_FilterFunByKey = exports.gs_TopicTaskStatus_SortFunByKey = exports.gs_TopicTaskStatus_SortFun_Defa_2Fld = exports.gs_TopicTaskStatus_SortFun_Defa = exports.gs_TopicTaskStatus_func = exports.gs_TopicTaskStatus_GetNameByStatusId_Cache = exports.gs_TopicTaskStatus_UpdateObjInLst_Cache = exports.gs_TopicTaskStatus_GetObjByStatusId_localStorage = exports.gs_TopicTaskStatus_GetObjByStatusId_Cache = exports.gs_TopicTaskStatus_GetObjByStatusIdAsync = exports.gs_TopicTaskStatus_ConstructorName = exports.gs_TopicTaskStatus_Controller = void 0;
    /**
     * 主题任务状态(gs_TopicTaskStatus)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2022年11月02日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsgs_TopicTaskStatusEN_js_1 = require("../../L0_Entity/ParameterTable/clsgs_TopicTaskStatusEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    const CacheHelper_js_2 = require("../../PubFun/CacheHelper.js");
    const jsString_js_1 = require("../../PubFun/jsString.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.gs_TopicTaskStatus_Controller = "gs_TopicTaskStatusApi";
    exports.gs_TopicTaskStatus_ConstructorName = "gs_TopicTaskStatus";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strStatusId:关键字
    * @returns 对象
    **/
    async function gs_TopicTaskStatus_GetObjByStatusIdAsync(strStatusId) {
        const strThisFuncName = "GetObjByStatusIdAsync";
        if ((0, clsString_js_1.IsNullOrEmpty)(strStatusId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strStatusId]不能为空！(In GetObjByStatusIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strStatusId.length != 2) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strStatusId]的长度:[{0}]不正确！", strStatusId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByStatusId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TopicTaskStatus_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "strStatusId": strStatusId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_TopicTaskStatus_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objgs_TopicTaskStatus = gs_TopicTaskStatus_GetObjFromJsonObj(returnObj);
                return objgs_TopicTaskStatus;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TopicTaskStatus_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TopicTaskStatus_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TopicTaskStatus_GetObjByStatusIdAsync = gs_TopicTaskStatus_GetObjByStatusIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param strStatusId:所给的关键字
     * @returns 对象
    */
    async function gs_TopicTaskStatus_GetObjByStatusId_Cache(strStatusId, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByStatusId_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strStatusId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strStatusId]不能为空！(In GetObjByStatusId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strStatusId.length != 2) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strStatusId]的长度:[{0}]不正确！", strStatusId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrgs_TopicTaskStatusObjLst_Cache = await gs_TopicTaskStatus_GetObjLst_Cache();
        try {
            const arrgs_TopicTaskStatus_Sel = arrgs_TopicTaskStatusObjLst_Cache.filter(x => x.statusId == strStatusId);
            let objgs_TopicTaskStatus;
            if (arrgs_TopicTaskStatus_Sel.length > 0) {
                objgs_TopicTaskStatus = arrgs_TopicTaskStatus_Sel[0];
                return objgs_TopicTaskStatus;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    objgs_TopicTaskStatus = await gs_TopicTaskStatus_GetObjByStatusIdAsync(strStatusId);
                    if (objgs_TopicTaskStatus != null) {
                        gs_TopicTaskStatus_ReFreshThisCache();
                        return objgs_TopicTaskStatus;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strStatusId, exports.gs_TopicTaskStatus_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.gs_TopicTaskStatus_GetObjByStatusId_Cache = gs_TopicTaskStatus_GetObjByStatusId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param strStatusId:所给的关键字
     * @returns 对象
    */
    async function gs_TopicTaskStatus_GetObjByStatusId_localStorage(strStatusId) {
        const strThisFuncName = "GetObjByStatusId_localStorage";
        if ((0, clsString_js_1.IsNullOrEmpty)(strStatusId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strStatusId]不能为空！(In GetObjByStatusId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strStatusId.length != 2) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strStatusId]的长度:[{0}]不正确！", strStatusId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsgs_TopicTaskStatusEN_js_1.clsgs_TopicTaskStatusEN._CurrTabName, strStatusId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objgs_TopicTaskStatus_Cache = JSON.parse(strTempObj);
            return objgs_TopicTaskStatus_Cache;
        }
        try {
            const objgs_TopicTaskStatus = await gs_TopicTaskStatus_GetObjByStatusIdAsync(strStatusId);
            if (objgs_TopicTaskStatus != null) {
                localStorage.setItem(strKey, JSON.stringify(objgs_TopicTaskStatus));
                const strInfo = (0, clsString_js_1.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objgs_TopicTaskStatus;
            }
            return objgs_TopicTaskStatus;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strStatusId, exports.gs_TopicTaskStatus_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.gs_TopicTaskStatus_GetObjByStatusId_localStorage = gs_TopicTaskStatus_GetObjByStatusId_localStorage;
    /**
     * 修改在缓存对象列表中的对象, 与后台数据库无关.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
     * @param objgs_TopicTaskStatus:所给的对象
     * @returns 对象
    */
    async function gs_TopicTaskStatus_UpdateObjInLst_Cache(objgs_TopicTaskStatus) {
        const strThisFuncName = "UpdateObjInLst_Cache";
        try {
            const arrgs_TopicTaskStatusObjLst_Cache = await gs_TopicTaskStatus_GetObjLst_Cache();
            const obj = arrgs_TopicTaskStatusObjLst_Cache.find(x => x.statusId == objgs_TopicTaskStatus.statusId);
            if (obj != null) {
                objgs_TopicTaskStatus.statusId = obj.statusId;
                (0, clsCommFunc4Web_js_1.ObjectAssign)(obj, objgs_TopicTaskStatus);
            }
            else {
                arrgs_TopicTaskStatusObjLst_Cache.push(objgs_TopicTaskStatus);
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, exports.gs_TopicTaskStatus_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.gs_TopicTaskStatus_UpdateObjInLst_Cache = gs_TopicTaskStatus_UpdateObjInLst_Cache;
    /**
     * 根据关键字获取相关对象的名称属性, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetNameByKeyId_Cache)
     * @param strStatusId:所给的关键字
     * @returns 对象
    */
    async function gs_TopicTaskStatus_GetNameByStatusId_Cache(strStatusId) {
        const strThisFuncName = "GetNameByStatusId_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strStatusId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strStatusId]不能为空！(In GetNameByStatusId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strStatusId.length != 2) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strStatusId]的长度:[{0}]不正确！", strStatusId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrgs_TopicTaskStatusObjLst_Cache = await gs_TopicTaskStatus_GetObjLst_Cache();
        if (arrgs_TopicTaskStatusObjLst_Cache == null)
            return "";
        try {
            const arrgs_TopicTaskStatus_Sel = arrgs_TopicTaskStatusObjLst_Cache.filter(x => x.statusId == strStatusId);
            let objgs_TopicTaskStatus;
            if (arrgs_TopicTaskStatus_Sel.length > 0) {
                objgs_TopicTaskStatus = arrgs_TopicTaskStatus_Sel[0];
                return objgs_TopicTaskStatus.statusName;
            }
            else {
                return "";
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象名称属性不成功!", e, strStatusId);
            console.error(strMsg);
            alert(strMsg);
        }
        return "";
    }
    exports.gs_TopicTaskStatus_GetNameByStatusId_Cache = gs_TopicTaskStatus_GetNameByStatusId_Cache;
    /**
     * 映射函数。根据表映射把输入字段值，映射成输出字段值
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_func)
     * @param strInFldName:输入字段名
     * @param strOutFldName:输出字段名
     * @param strInValue:输入字段值
     * @returns 返回一个输出字段值
    */
    async function gs_TopicTaskStatus_func(strInFldName, strOutFldName, strInValue) {
        //const strThisFuncName = "func";
        if (strInFldName != clsgs_TopicTaskStatusEN_js_1.clsgs_TopicTaskStatusEN.con_StatusId) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsgs_TopicTaskStatusEN_js_1.clsgs_TopicTaskStatusEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_1.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strInFldName, clsgs_TopicTaskStatusEN_js_1.clsgs_TopicTaskStatusEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strStatusId = strInValue;
        if ((0, clsString_js_1.IsNullOrEmpty)(strInValue) == true) {
            return "";
        }
        const objgs_TopicTaskStatus = await gs_TopicTaskStatus_GetObjByStatusId_Cache(strStatusId);
        if (objgs_TopicTaskStatus == null)
            return "";
        return objgs_TopicTaskStatus.GetFldValue(strOutFldName).toString();
    }
    exports.gs_TopicTaskStatus_func = gs_TopicTaskStatus_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function gs_TopicTaskStatus_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.statusId.localeCompare(b.statusId);
    }
    exports.gs_TopicTaskStatus_SortFun_Defa = gs_TopicTaskStatus_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function gs_TopicTaskStatus_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.statusName == b.statusName)
            return a.updUser.localeCompare(b.updUser);
        else
            return a.statusName.localeCompare(b.statusName);
    }
    exports.gs_TopicTaskStatus_SortFun_Defa_2Fld = gs_TopicTaskStatus_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function gs_TopicTaskStatus_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsgs_TopicTaskStatusEN_js_1.clsgs_TopicTaskStatusEN.con_StatusId:
                    return (a, b) => {
                        return a.statusId.localeCompare(b.statusId);
                    };
                case clsgs_TopicTaskStatusEN_js_1.clsgs_TopicTaskStatusEN.con_StatusName:
                    return (a, b) => {
                        return a.statusName.localeCompare(b.statusName);
                    };
                case clsgs_TopicTaskStatusEN_js_1.clsgs_TopicTaskStatusEN.con_UpdUser:
                    return (a, b) => {
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsgs_TopicTaskStatusEN_js_1.clsgs_TopicTaskStatusEN.con_UpdDate:
                    return (a, b) => {
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsgs_TopicTaskStatusEN_js_1.clsgs_TopicTaskStatusEN.con_Memo:
                    return (a, b) => {
                        return a.memo.localeCompare(b.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[gs_TopicTaskStatus]中不存在！(in ${exports.gs_TopicTaskStatus_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsgs_TopicTaskStatusEN_js_1.clsgs_TopicTaskStatusEN.con_StatusId:
                    return (a, b) => {
                        return b.statusId.localeCompare(a.statusId);
                    };
                case clsgs_TopicTaskStatusEN_js_1.clsgs_TopicTaskStatusEN.con_StatusName:
                    return (a, b) => {
                        return b.statusName.localeCompare(a.statusName);
                    };
                case clsgs_TopicTaskStatusEN_js_1.clsgs_TopicTaskStatusEN.con_UpdUser:
                    return (a, b) => {
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsgs_TopicTaskStatusEN_js_1.clsgs_TopicTaskStatusEN.con_UpdDate:
                    return (a, b) => {
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsgs_TopicTaskStatusEN_js_1.clsgs_TopicTaskStatusEN.con_Memo:
                    return (a, b) => {
                        return b.memo.localeCompare(a.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[gs_TopicTaskStatus]中不存在！(in ${exports.gs_TopicTaskStatus_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.gs_TopicTaskStatus_SortFunByKey = gs_TopicTaskStatus_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function gs_TopicTaskStatus_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsgs_TopicTaskStatusEN_js_1.clsgs_TopicTaskStatusEN.con_StatusId:
                return (obj) => {
                    return obj.statusId === value;
                };
            case clsgs_TopicTaskStatusEN_js_1.clsgs_TopicTaskStatusEN.con_StatusName:
                return (obj) => {
                    return obj.statusName === value;
                };
            case clsgs_TopicTaskStatusEN_js_1.clsgs_TopicTaskStatusEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsgs_TopicTaskStatusEN_js_1.clsgs_TopicTaskStatusEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsgs_TopicTaskStatusEN_js_1.clsgs_TopicTaskStatusEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[gs_TopicTaskStatus]中不存在！(in ${exports.gs_TopicTaskStatus_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.gs_TopicTaskStatus_FilterFunByKey = gs_TopicTaskStatus_FilterFunByKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function gs_TopicTaskStatus_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TopicTaskStatus_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TopicTaskStatus_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TopicTaskStatus_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TopicTaskStatus_GetFirstIDAsync = gs_TopicTaskStatus_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function gs_TopicTaskStatus_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TopicTaskStatus_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TopicTaskStatus_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TopicTaskStatus_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TopicTaskStatus_GetFirstID = gs_TopicTaskStatus_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function gs_TopicTaskStatus_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TopicTaskStatus_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_TopicTaskStatus_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objgs_TopicTaskStatus = gs_TopicTaskStatus_GetObjFromJsonObj(returnObj);
                return objgs_TopicTaskStatus;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TopicTaskStatus_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TopicTaskStatus_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TopicTaskStatus_GetFirstObjAsync = gs_TopicTaskStatus_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_TopicTaskStatus_GetObjLst_ClientCache() {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsgs_TopicTaskStatusEN_js_1.clsgs_TopicTaskStatusEN._CurrTabName;
        clsgs_TopicTaskStatusEN_js_1.clsgs_TopicTaskStatusEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsgs_TopicTaskStatusEN_js_1.clsgs_TopicTaskStatusEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsgs_TopicTaskStatusEN_js_1.clsgs_TopicTaskStatusEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsgs_TopicTaskStatusEN_js_1.clsgs_TopicTaskStatusEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_2.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrgs_TopicTaskStatusExObjLst_Cache = CacheHelper_js_2.CacheHelper.Get(strKey);
            const arrgs_TopicTaskStatusObjLst_T = gs_TopicTaskStatus_GetObjLstByJSONObjLst(arrgs_TopicTaskStatusExObjLst_Cache);
            return arrgs_TopicTaskStatusObjLst_T;
        }
        try {
            const arrgs_TopicTaskStatusExObjLst = await gs_TopicTaskStatus_GetObjLstAsync(strWhereCond);
            CacheHelper_js_2.CacheHelper.Add(strKey, arrgs_TopicTaskStatusExObjLst);
            const strInfo = (0, clsString_js_1.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_TopicTaskStatusExObjLst.length);
            console.log(strInfo);
            return arrgs_TopicTaskStatusExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.gs_TopicTaskStatus_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.gs_TopicTaskStatus_GetObjLst_ClientCache = gs_TopicTaskStatus_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_TopicTaskStatus_GetObjLst_localStorage() {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsgs_TopicTaskStatusEN_js_1.clsgs_TopicTaskStatusEN._CurrTabName;
        clsgs_TopicTaskStatusEN_js_1.clsgs_TopicTaskStatusEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsgs_TopicTaskStatusEN_js_1.clsgs_TopicTaskStatusEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsgs_TopicTaskStatusEN_js_1.clsgs_TopicTaskStatusEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsgs_TopicTaskStatusEN_js_1.clsgs_TopicTaskStatusEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrgs_TopicTaskStatusExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrgs_TopicTaskStatusObjLst_T = gs_TopicTaskStatus_GetObjLstByJSONObjLst(arrgs_TopicTaskStatusExObjLst_Cache);
            return arrgs_TopicTaskStatusObjLst_T;
        }
        try {
            const arrgs_TopicTaskStatusExObjLst = await gs_TopicTaskStatus_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrgs_TopicTaskStatusExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_TopicTaskStatusExObjLst.length);
            console.log(strInfo);
            return arrgs_TopicTaskStatusExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.gs_TopicTaskStatus_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.gs_TopicTaskStatus_GetObjLst_localStorage = gs_TopicTaskStatus_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_TopicTaskStatus_GetObjLst_localStorage_PureCache() {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsgs_TopicTaskStatusEN_js_1.clsgs_TopicTaskStatusEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrgs_TopicTaskStatusObjLst_Cache = JSON.parse(strTempObjLst);
            return arrgs_TopicTaskStatusObjLst_Cache;
        }
        else
            return null;
    }
    exports.gs_TopicTaskStatus_GetObjLst_localStorage_PureCache = gs_TopicTaskStatus_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function gs_TopicTaskStatus_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TopicTaskStatus_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_TopicTaskStatus_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_TopicTaskStatus_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TopicTaskStatus_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TopicTaskStatus_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TopicTaskStatus_GetObjLstAsync = gs_TopicTaskStatus_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_TopicTaskStatus_GetObjLst_sessionStorage() {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsgs_TopicTaskStatusEN_js_1.clsgs_TopicTaskStatusEN._CurrTabName;
        clsgs_TopicTaskStatusEN_js_1.clsgs_TopicTaskStatusEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsgs_TopicTaskStatusEN_js_1.clsgs_TopicTaskStatusEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsgs_TopicTaskStatusEN_js_1.clsgs_TopicTaskStatusEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsgs_TopicTaskStatusEN_js_1.clsgs_TopicTaskStatusEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrgs_TopicTaskStatusExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrgs_TopicTaskStatusObjLst_T = gs_TopicTaskStatus_GetObjLstByJSONObjLst(arrgs_TopicTaskStatusExObjLst_Cache);
            return arrgs_TopicTaskStatusObjLst_T;
        }
        try {
            const arrgs_TopicTaskStatusExObjLst = await gs_TopicTaskStatus_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrgs_TopicTaskStatusExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_TopicTaskStatusExObjLst.length);
            console.log(strInfo);
            return arrgs_TopicTaskStatusExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.gs_TopicTaskStatus_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.gs_TopicTaskStatus_GetObjLst_sessionStorage = gs_TopicTaskStatus_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_TopicTaskStatus_GetObjLst_sessionStorage_PureCache() {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsgs_TopicTaskStatusEN_js_1.clsgs_TopicTaskStatusEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrgs_TopicTaskStatusObjLst_Cache = JSON.parse(strTempObjLst);
            return arrgs_TopicTaskStatusObjLst_Cache;
        }
        else
            return null;
    }
    exports.gs_TopicTaskStatus_GetObjLst_sessionStorage_PureCache = gs_TopicTaskStatus_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_TopicTaskStatus_GetObjLst_Cache() {
        //const strThisFuncName = "GetObjLst_Cache";
        let arrgs_TopicTaskStatusObjLst_Cache;
        switch (clsgs_TopicTaskStatusEN_js_1.clsgs_TopicTaskStatusEN.CacheModeId) {
            case "04": //sessionStorage
                arrgs_TopicTaskStatusObjLst_Cache = await gs_TopicTaskStatus_GetObjLst_sessionStorage();
                break;
            case "03": //localStorage
                arrgs_TopicTaskStatusObjLst_Cache = await gs_TopicTaskStatus_GetObjLst_localStorage();
                break;
            case "02": //ClientCache
                arrgs_TopicTaskStatusObjLst_Cache = await gs_TopicTaskStatus_GetObjLst_ClientCache();
                break;
            default:
                arrgs_TopicTaskStatusObjLst_Cache = await gs_TopicTaskStatus_GetObjLst_ClientCache();
                break;
        }
        const arrgs_TopicTaskStatusObjLst = gs_TopicTaskStatus_GetObjLstByJSONObjLst(arrgs_TopicTaskStatusObjLst_Cache);
        return arrgs_TopicTaskStatusObjLst_Cache;
    }
    exports.gs_TopicTaskStatus_GetObjLst_Cache = gs_TopicTaskStatus_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_TopicTaskStatus_GetObjLst_PureCache() {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrgs_TopicTaskStatusObjLst_Cache;
        switch (clsgs_TopicTaskStatusEN_js_1.clsgs_TopicTaskStatusEN.CacheModeId) {
            case "04": //sessionStorage
                arrgs_TopicTaskStatusObjLst_Cache = await gs_TopicTaskStatus_GetObjLst_sessionStorage_PureCache();
                break;
            case "03": //localStorage
                arrgs_TopicTaskStatusObjLst_Cache = await gs_TopicTaskStatus_GetObjLst_localStorage_PureCache();
                break;
            case "02": //ClientCache
                arrgs_TopicTaskStatusObjLst_Cache = null;
                break;
            default:
                arrgs_TopicTaskStatusObjLst_Cache = null;
                break;
        }
        return arrgs_TopicTaskStatusObjLst_Cache;
    }
    exports.gs_TopicTaskStatus_GetObjLst_PureCache = gs_TopicTaskStatus_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objstrStatusId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function gs_TopicTaskStatus_GetSubObjLst_Cache(objgs_TopicTaskStatus_Cond) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrgs_TopicTaskStatusObjLst_Cache = await gs_TopicTaskStatus_GetObjLst_Cache();
        let arrgs_TopicTaskStatus_Sel = arrgs_TopicTaskStatusObjLst_Cache;
        if (objgs_TopicTaskStatus_Cond.sf_FldComparisonOp == null || objgs_TopicTaskStatus_Cond.sf_FldComparisonOp == "")
            return arrgs_TopicTaskStatus_Sel;
        const dicFldComparisonOp = JSON.parse(objgs_TopicTaskStatus_Cond.sf_FldComparisonOp);
        //console.log("clsgs_TopicTaskStatusWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objgs_TopicTaskStatus_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrgs_TopicTaskStatus_Sel = arrgs_TopicTaskStatus_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objgs_TopicTaskStatus_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_TopicTaskStatus_Sel = arrgs_TopicTaskStatus_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrgs_TopicTaskStatus_Sel = arrgs_TopicTaskStatus_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_TopicTaskStatus_Sel = arrgs_TopicTaskStatus_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_TopicTaskStatus_Sel = arrgs_TopicTaskStatus_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrgs_TopicTaskStatus_Sel = arrgs_TopicTaskStatus_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrgs_TopicTaskStatus_Sel = arrgs_TopicTaskStatus_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrgs_TopicTaskStatus_Sel = arrgs_TopicTaskStatus_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrgs_TopicTaskStatus_Sel = arrgs_TopicTaskStatus_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrgs_TopicTaskStatus_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objgs_TopicTaskStatus_Cond), exports.gs_TopicTaskStatus_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.gs_TopicTaskStatus_GetSubObjLst_Cache = gs_TopicTaskStatus_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrStatusId:关键字列表
    * @returns 对象列表
    **/
    async function gs_TopicTaskStatus_GetObjLstByStatusIdLstAsync(arrStatusId) {
        const strThisFuncName = "GetObjLstByStatusIdLstAsync";
        const strAction = "GetObjLstByStatusIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TopicTaskStatus_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrStatusId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_TopicTaskStatus_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_TopicTaskStatus_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TopicTaskStatus_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TopicTaskStatus_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TopicTaskStatus_GetObjLstByStatusIdLstAsync = gs_TopicTaskStatus_GetObjLstByStatusIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrstrStatusIdLst:关键字列表
     * @returns 对象列表
    */
    async function gs_TopicTaskStatus_GetObjLstByStatusIdLst_Cache(arrStatusIdLst) {
        const strThisFuncName = "GetObjLstByStatusIdLst_Cache";
        try {
            const arrgs_TopicTaskStatusObjLst_Cache = await gs_TopicTaskStatus_GetObjLst_Cache();
            const arrgs_TopicTaskStatus_Sel = arrgs_TopicTaskStatusObjLst_Cache.filter(x => arrStatusIdLst.indexOf(x.statusId) > -1);
            return arrgs_TopicTaskStatus_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrStatusIdLst.join(","), exports.gs_TopicTaskStatus_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.gs_TopicTaskStatus_GetObjLstByStatusIdLst_Cache = gs_TopicTaskStatus_GetObjLstByStatusIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function gs_TopicTaskStatus_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TopicTaskStatus_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_TopicTaskStatus_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_TopicTaskStatus_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TopicTaskStatus_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TopicTaskStatus_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TopicTaskStatus_GetTopObjLstAsync = gs_TopicTaskStatus_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function gs_TopicTaskStatus_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TopicTaskStatus_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_TopicTaskStatus_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_TopicTaskStatus_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TopicTaskStatus_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TopicTaskStatus_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TopicTaskStatus_GetObjLstByRangeAsync = gs_TopicTaskStatus_GetObjLstByRangeAsync;
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
    async function gs_TopicTaskStatus_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TopicTaskStatus_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TopicTaskStatus_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TopicTaskStatus_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TopicTaskStatus_GetObjLstByRange = gs_TopicTaskStatus_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function gs_TopicTaskStatus_GetObjLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const arrgs_TopicTaskStatusObjLst_Cache = await gs_TopicTaskStatus_GetObjLst_Cache();
        if (arrgs_TopicTaskStatusObjLst_Cache.length == 0)
            return arrgs_TopicTaskStatusObjLst_Cache;
        let arrgs_TopicTaskStatus_Sel = arrgs_TopicTaskStatusObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objgs_TopicTaskStatus_Cond = new clsgs_TopicTaskStatusEN_js_1.clsgs_TopicTaskStatusEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objgs_TopicTaskStatus_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsgs_TopicTaskStatusWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrgs_TopicTaskStatus_Sel = arrgs_TopicTaskStatus_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objgs_TopicTaskStatus_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_TopicTaskStatus_Sel = arrgs_TopicTaskStatus_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrgs_TopicTaskStatus_Sel = arrgs_TopicTaskStatus_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrgs_TopicTaskStatus_Sel = arrgs_TopicTaskStatus_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_TopicTaskStatus_Sel = arrgs_TopicTaskStatus_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_TopicTaskStatus_Sel = arrgs_TopicTaskStatus_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrgs_TopicTaskStatus_Sel = arrgs_TopicTaskStatus_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrgs_TopicTaskStatus_Sel = arrgs_TopicTaskStatus_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrgs_TopicTaskStatus_Sel = arrgs_TopicTaskStatus_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrgs_TopicTaskStatus_Sel = arrgs_TopicTaskStatus_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrgs_TopicTaskStatus_Sel.length == 0)
                return arrgs_TopicTaskStatus_Sel;
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
                arrgs_TopicTaskStatus_Sel = arrgs_TopicTaskStatus_Sel.sort(gs_TopicTaskStatus_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrgs_TopicTaskStatus_Sel = arrgs_TopicTaskStatus_Sel.sort(objPagerPara.sortFun);
            }
            arrgs_TopicTaskStatus_Sel = arrgs_TopicTaskStatus_Sel.slice(intStart, intEnd);
            return arrgs_TopicTaskStatus_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.gs_TopicTaskStatus_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.gs_TopicTaskStatus_GetObjLstByPager_Cache = gs_TopicTaskStatus_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function gs_TopicTaskStatus_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TopicTaskStatus_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_TopicTaskStatus_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_TopicTaskStatus_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TopicTaskStatus_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TopicTaskStatus_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TopicTaskStatus_GetObjLstByPagerAsync = gs_TopicTaskStatus_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param strStatusId:关键字
    * @returns 获取删除的结果
    **/
    async function gs_TopicTaskStatus_DelRecordAsync(strStatusId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TopicTaskStatus_Controller, strAction);
        strUrl = (0, clsString_js_1.Format)("{0}/?Id={1}", strUrl, strStatusId);
        try {
            const response = await axios_1.default.delete(strUrl, {
                params: { "Id": strStatusId, }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TopicTaskStatus_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TopicTaskStatus_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TopicTaskStatus_DelRecordAsync = gs_TopicTaskStatus_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrStatusId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function gs_TopicTaskStatus_Delgs_TopicTaskStatussAsync(arrStatusId) {
        const strThisFuncName = "Delgs_TopicTaskStatussAsync";
        const strAction = "Delgs_TopicTaskStatuss";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TopicTaskStatus_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrStatusId);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TopicTaskStatus_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TopicTaskStatus_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TopicTaskStatus_Delgs_TopicTaskStatussAsync = gs_TopicTaskStatus_Delgs_TopicTaskStatussAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function gs_TopicTaskStatus_Delgs_TopicTaskStatussByCondAsync(strWhereCond) {
        const strThisFuncName = "Delgs_TopicTaskStatussByCondAsync";
        const strAction = "Delgs_TopicTaskStatussByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TopicTaskStatus_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TopicTaskStatus_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TopicTaskStatus_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TopicTaskStatus_Delgs_TopicTaskStatussByCondAsync = gs_TopicTaskStatus_Delgs_TopicTaskStatussByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objgs_TopicTaskStatusEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function gs_TopicTaskStatus_AddNewRecordAsync(objgs_TopicTaskStatusEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        if (objgs_TopicTaskStatusEN.statusId === null || objgs_TopicTaskStatusEN.statusId === "") {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            throw strMsg;
        }
        //var strJSON = JSON.stringify(objgs_TopicTaskStatusEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TopicTaskStatus_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_TopicTaskStatusEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TopicTaskStatus_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TopicTaskStatus_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TopicTaskStatus_AddNewRecordAsync = gs_TopicTaskStatus_AddNewRecordAsync;
    /**
    * 调用WebApi来添加记录，关键字用最大关键字，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithMaxIdAsync)
    * @param objgs_TopicTaskStatusEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function gs_TopicTaskStatus_AddNewRecordWithMaxIdAsync(objgs_TopicTaskStatusEN) {
        const strThisFuncName = "AddNewRecordWithMaxIdAsync";
        const strAction = "AddNewRecordWithMaxId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TopicTaskStatus_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_TopicTaskStatusEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TopicTaskStatus_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TopicTaskStatus_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TopicTaskStatus_AddNewRecordWithMaxIdAsync = gs_TopicTaskStatus_AddNewRecordWithMaxIdAsync;
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objgs_TopicTaskStatusEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function gs_TopicTaskStatus_AddNewRecordWithReturnKeyAsync(objgs_TopicTaskStatusEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TopicTaskStatus_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_TopicTaskStatusEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TopicTaskStatus_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TopicTaskStatus_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TopicTaskStatus_AddNewRecordWithReturnKeyAsync = gs_TopicTaskStatus_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objgs_TopicTaskStatusEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function gs_TopicTaskStatus_AddNewRecordWithReturnKey(objgs_TopicTaskStatusEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objgs_TopicTaskStatusEN.statusId === null || objgs_TopicTaskStatusEN.statusId === "") {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TopicTaskStatus_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_TopicTaskStatusEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TopicTaskStatus_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TopicTaskStatus_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TopicTaskStatus_AddNewRecordWithReturnKey = gs_TopicTaskStatus_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objgs_TopicTaskStatusEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function gs_TopicTaskStatus_UpdateRecordAsync(objgs_TopicTaskStatusEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objgs_TopicTaskStatusEN.sf_UpdFldSetStr === undefined || objgs_TopicTaskStatusEN.sf_UpdFldSetStr === null || objgs_TopicTaskStatusEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_TopicTaskStatusEN.statusId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TopicTaskStatus_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_TopicTaskStatusEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TopicTaskStatus_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TopicTaskStatus_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TopicTaskStatus_UpdateRecordAsync = gs_TopicTaskStatus_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objgs_TopicTaskStatusEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function gs_TopicTaskStatus_UpdateWithConditionAsync(objgs_TopicTaskStatusEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objgs_TopicTaskStatusEN.sf_UpdFldSetStr === undefined || objgs_TopicTaskStatusEN.sf_UpdFldSetStr === null || objgs_TopicTaskStatusEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_TopicTaskStatusEN.statusId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TopicTaskStatus_Controller, strAction);
        objgs_TopicTaskStatusEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objgs_TopicTaskStatusEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TopicTaskStatus_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TopicTaskStatus_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TopicTaskStatus_UpdateWithConditionAsync = gs_TopicTaskStatus_UpdateWithConditionAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objstrStatusId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function gs_TopicTaskStatus_IsExistRecord_Cache(objgs_TopicTaskStatus_Cond) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrgs_TopicTaskStatusObjLst_Cache = await gs_TopicTaskStatus_GetObjLst_Cache();
        if (arrgs_TopicTaskStatusObjLst_Cache == null)
            return false;
        let arrgs_TopicTaskStatus_Sel = arrgs_TopicTaskStatusObjLst_Cache;
        if (objgs_TopicTaskStatus_Cond.sf_FldComparisonOp == null || objgs_TopicTaskStatus_Cond.sf_FldComparisonOp == "")
            return arrgs_TopicTaskStatus_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objgs_TopicTaskStatus_Cond.sf_FldComparisonOp);
        //console.log("clsgs_TopicTaskStatusWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objgs_TopicTaskStatus_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objgs_TopicTaskStatus_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_TopicTaskStatus_Sel = arrgs_TopicTaskStatus_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrgs_TopicTaskStatus_Sel = arrgs_TopicTaskStatus_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_TopicTaskStatus_Sel = arrgs_TopicTaskStatus_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_TopicTaskStatus_Sel = arrgs_TopicTaskStatus_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrgs_TopicTaskStatus_Sel = arrgs_TopicTaskStatus_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrgs_TopicTaskStatus_Sel = arrgs_TopicTaskStatus_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrgs_TopicTaskStatus_Sel = arrgs_TopicTaskStatus_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrgs_TopicTaskStatus_Sel = arrgs_TopicTaskStatus_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrgs_TopicTaskStatus_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objgs_TopicTaskStatus_Cond), exports.gs_TopicTaskStatus_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.gs_TopicTaskStatus_IsExistRecord_Cache = gs_TopicTaskStatus_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function gs_TopicTaskStatus_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TopicTaskStatus_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TopicTaskStatus_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TopicTaskStatus_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TopicTaskStatus_IsExistRecordAsync = gs_TopicTaskStatus_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strStatusId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function gs_TopicTaskStatus_IsExist(strStatusId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TopicTaskStatus_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "StatusId": strStatusId,
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TopicTaskStatus_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TopicTaskStatus_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TopicTaskStatus_IsExist = gs_TopicTaskStatus_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param strStatusId:所给的关键字
     * @returns 对象
    */
    async function gs_TopicTaskStatus_IsExist_Cache(strStatusId) {
        const strThisFuncName = "IsExist_Cache";
        const arrgs_TopicTaskStatusObjLst_Cache = await gs_TopicTaskStatus_GetObjLst_Cache();
        if (arrgs_TopicTaskStatusObjLst_Cache == null)
            return false;
        try {
            const arrgs_TopicTaskStatus_Sel = arrgs_TopicTaskStatusObjLst_Cache.filter(x => x.statusId == strStatusId);
            if (arrgs_TopicTaskStatus_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strStatusId, exports.gs_TopicTaskStatus_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.gs_TopicTaskStatus_IsExist_Cache = gs_TopicTaskStatus_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strStatusId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function gs_TopicTaskStatus_IsExistAsync(strStatusId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TopicTaskStatus_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strStatusId": strStatusId }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TopicTaskStatus_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TopicTaskStatus_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TopicTaskStatus_IsExistAsync = gs_TopicTaskStatus_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function gs_TopicTaskStatus_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TopicTaskStatus_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TopicTaskStatus_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TopicTaskStatus_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TopicTaskStatus_GetRecCountByCondAsync = gs_TopicTaskStatus_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objgs_TopicTaskStatus_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function gs_TopicTaskStatus_GetRecCountByCond_Cache(objgs_TopicTaskStatus_Cond) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrgs_TopicTaskStatusObjLst_Cache = await gs_TopicTaskStatus_GetObjLst_Cache();
        if (arrgs_TopicTaskStatusObjLst_Cache == null)
            return 0;
        let arrgs_TopicTaskStatus_Sel = arrgs_TopicTaskStatusObjLst_Cache;
        if (objgs_TopicTaskStatus_Cond.sf_FldComparisonOp == null || objgs_TopicTaskStatus_Cond.sf_FldComparisonOp == "")
            return arrgs_TopicTaskStatus_Sel.length;
        const dicFldComparisonOp = JSON.parse(objgs_TopicTaskStatus_Cond.sf_FldComparisonOp);
        //console.log("clsgs_TopicTaskStatusWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objgs_TopicTaskStatus_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrgs_TopicTaskStatus_Sel = arrgs_TopicTaskStatus_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objgs_TopicTaskStatus_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_TopicTaskStatus_Sel = arrgs_TopicTaskStatus_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrgs_TopicTaskStatus_Sel = arrgs_TopicTaskStatus_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrgs_TopicTaskStatus_Sel = arrgs_TopicTaskStatus_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_TopicTaskStatus_Sel = arrgs_TopicTaskStatus_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_TopicTaskStatus_Sel = arrgs_TopicTaskStatus_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrgs_TopicTaskStatus_Sel = arrgs_TopicTaskStatus_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrgs_TopicTaskStatus_Sel = arrgs_TopicTaskStatus_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrgs_TopicTaskStatus_Sel = arrgs_TopicTaskStatus_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrgs_TopicTaskStatus_Sel = arrgs_TopicTaskStatus_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrgs_TopicTaskStatus_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objgs_TopicTaskStatus_Cond), exports.gs_TopicTaskStatus_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.gs_TopicTaskStatus_GetRecCountByCond_Cache = gs_TopicTaskStatus_GetRecCountByCond_Cache;
    /*该表的关键字类型不是字符型自增，不需要生成获取最大关键字函数！*/
    /*该表的关键字类型不是字符型带前缀自增，不需要生成获取最大关键字函数！*/
    /**
     * 根据前缀获取当前表关键字值的最大值,再加1,避免重复
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdByPrefix)
     * @param mapParam:参数列表
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 获取当前表关键字值的最大值
    */
    async function gs_TopicTaskStatus_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TopicTaskStatus_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TopicTaskStatus_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TopicTaskStatus_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TopicTaskStatus_GetMaxStrIdByPrefix = gs_TopicTaskStatus_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function gs_TopicTaskStatus_GetWebApiUrl(strController, strAction) {
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
    exports.gs_TopicTaskStatus_GetWebApiUrl = gs_TopicTaskStatus_GetWebApiUrl;
    /**
    * 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshCache)
    **/
    function gs_TopicTaskStatus_ReFreshCache() {
        const strThisFuncName = "ReFreshCache";
        const strMsg = (0, clsString_js_1.Format)("刷新缓存成功！");
        console.trace(strMsg);
        // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
        const strKey = clsgs_TopicTaskStatusEN_js_1.clsgs_TopicTaskStatusEN._CurrTabName;
        switch (clsgs_TopicTaskStatusEN_js_1.clsgs_TopicTaskStatusEN.CacheModeId) {
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
    }
    exports.gs_TopicTaskStatus_ReFreshCache = gs_TopicTaskStatus_ReFreshCache;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function gs_TopicTaskStatus_ReFreshThisCache() {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = clsgs_TopicTaskStatusEN_js_1.clsgs_TopicTaskStatusEN._CurrTabName;
            switch (clsgs_TopicTaskStatusEN_js_1.clsgs_TopicTaskStatusEN.CacheModeId) {
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
    exports.gs_TopicTaskStatus_ReFreshThisCache = gs_TopicTaskStatus_ReFreshThisCache;
    /**
     * 绑定基于Web的下拉框,在某一层下的下拉框
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunctionInDiv)
     * @param objDDL:需要绑定当前表的下拉框
    */
    async function gs_TopicTaskStatus_BindDdl_StatusIdInDiv_Cache(strDivName, strDdlName) {
        const strThisFuncName = "BindDdl_StatusIdInDiv_Cache";
        const objDdl = document.getElementById(strDdlName);
        if (objDdl == null) {
            const strMsg = (0, clsString_js_1.Format)("下拉框：{0} 不存在！(In BindDdl_StatusIdInDiv)", strDdlName);
            alert(strMsg);
            console.error(strMsg);
            throw (strMsg);
        }
        //为数据源于表的下拉框设置内容
        //console.log("开始：BindDdl_StatusIdInDiv_Cache");
        const arrObjLst_Sel = await gs_TopicTaskStatus_GetObjLst_Cache();
        if (arrObjLst_Sel == null)
            return;
        (0, clsCommFunc4Web_js_1.BindDdl_ObjLstInDiv)(strDivName, strDdlName, arrObjLst_Sel, clsgs_TopicTaskStatusEN_js_1.clsgs_TopicTaskStatusEN.con_StatusId, clsgs_TopicTaskStatusEN_js_1.clsgs_TopicTaskStatusEN.con_StatusName, "主题任务状态");
    }
    exports.gs_TopicTaskStatus_BindDdl_StatusIdInDiv_Cache = gs_TopicTaskStatus_BindDdl_StatusIdInDiv_Cache;
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function gs_TopicTaskStatus_CheckPropertyNew(pobjgs_TopicTaskStatusEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TopicTaskStatusEN.statusId) == false && (0, clsString_js_1.GetStrLen)(pobjgs_TopicTaskStatusEN.statusId) > 2) {
            throw new Error("(errid:Watl000059)字段[状态Id(statusId)]的长度不能超过2(In 主题任务状态(gs_TopicTaskStatus))!值:$(pobjgs_TopicTaskStatusEN.statusId)(clsgs_TopicTaskStatusBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TopicTaskStatusEN.statusName) == false && (0, clsString_js_1.GetStrLen)(pobjgs_TopicTaskStatusEN.statusName) > 100) {
            throw new Error("(errid:Watl000059)字段[状态名称(statusName)]的长度不能超过100(In 主题任务状态(gs_TopicTaskStatus))!值:$(pobjgs_TopicTaskStatusEN.statusName)(clsgs_TopicTaskStatusBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TopicTaskStatusEN.updUser) == false && (0, clsString_js_1.GetStrLen)(pobjgs_TopicTaskStatusEN.updUser) > 20) {
            throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 主题任务状态(gs_TopicTaskStatus))!值:$(pobjgs_TopicTaskStatusEN.updUser)(clsgs_TopicTaskStatusBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TopicTaskStatusEN.updDate) == false && (0, clsString_js_1.GetStrLen)(pobjgs_TopicTaskStatusEN.updDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 主题任务状态(gs_TopicTaskStatus))!值:$(pobjgs_TopicTaskStatusEN.updDate)(clsgs_TopicTaskStatusBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TopicTaskStatusEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjgs_TopicTaskStatusEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 主题任务状态(gs_TopicTaskStatus))!值:$(pobjgs_TopicTaskStatusEN.memo)(clsgs_TopicTaskStatusBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TopicTaskStatusEN.statusId) == false && undefined !== pobjgs_TopicTaskStatusEN.statusId && jsString_js_1.tzDataType.isString(pobjgs_TopicTaskStatusEN.statusId) === false) {
            throw new Error("(errid:Watl000060)字段[状态Id(statusId)]的值:[$(pobjgs_TopicTaskStatusEN.statusId)], 非法，应该为字符型(In 主题任务状态(gs_TopicTaskStatus))!(clsgs_TopicTaskStatusBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TopicTaskStatusEN.statusName) == false && undefined !== pobjgs_TopicTaskStatusEN.statusName && jsString_js_1.tzDataType.isString(pobjgs_TopicTaskStatusEN.statusName) === false) {
            throw new Error("(errid:Watl000060)字段[状态名称(statusName)]的值:[$(pobjgs_TopicTaskStatusEN.statusName)], 非法，应该为字符型(In 主题任务状态(gs_TopicTaskStatus))!(clsgs_TopicTaskStatusBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TopicTaskStatusEN.updUser) == false && undefined !== pobjgs_TopicTaskStatusEN.updUser && jsString_js_1.tzDataType.isString(pobjgs_TopicTaskStatusEN.updUser) === false) {
            throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjgs_TopicTaskStatusEN.updUser)], 非法，应该为字符型(In 主题任务状态(gs_TopicTaskStatus))!(clsgs_TopicTaskStatusBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TopicTaskStatusEN.updDate) == false && undefined !== pobjgs_TopicTaskStatusEN.updDate && jsString_js_1.tzDataType.isString(pobjgs_TopicTaskStatusEN.updDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjgs_TopicTaskStatusEN.updDate)], 非法，应该为字符型(In 主题任务状态(gs_TopicTaskStatus))!(clsgs_TopicTaskStatusBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TopicTaskStatusEN.memo) == false && undefined !== pobjgs_TopicTaskStatusEN.memo && jsString_js_1.tzDataType.isString(pobjgs_TopicTaskStatusEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjgs_TopicTaskStatusEN.memo)], 非法，应该为字符型(In 主题任务状态(gs_TopicTaskStatus))!(clsgs_TopicTaskStatusBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjgs_TopicTaskStatusEN.SetIsCheckProperty(true);
    }
    exports.gs_TopicTaskStatus_CheckPropertyNew = gs_TopicTaskStatus_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function gs_TopicTaskStatus_CheckProperty4Update(pobjgs_TopicTaskStatusEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TopicTaskStatusEN.statusId) == false && (0, clsString_js_1.GetStrLen)(pobjgs_TopicTaskStatusEN.statusId) > 2) {
            throw new Error("(errid:Watl000062)字段[状态Id(statusId)]的长度不能超过2(In 主题任务状态(gs_TopicTaskStatus))!值:$(pobjgs_TopicTaskStatusEN.statusId)(clsgs_TopicTaskStatusBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TopicTaskStatusEN.statusName) == false && (0, clsString_js_1.GetStrLen)(pobjgs_TopicTaskStatusEN.statusName) > 100) {
            throw new Error("(errid:Watl000062)字段[状态名称(statusName)]的长度不能超过100(In 主题任务状态(gs_TopicTaskStatus))!值:$(pobjgs_TopicTaskStatusEN.statusName)(clsgs_TopicTaskStatusBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TopicTaskStatusEN.updUser) == false && (0, clsString_js_1.GetStrLen)(pobjgs_TopicTaskStatusEN.updUser) > 20) {
            throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 主题任务状态(gs_TopicTaskStatus))!值:$(pobjgs_TopicTaskStatusEN.updUser)(clsgs_TopicTaskStatusBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TopicTaskStatusEN.updDate) == false && (0, clsString_js_1.GetStrLen)(pobjgs_TopicTaskStatusEN.updDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 主题任务状态(gs_TopicTaskStatus))!值:$(pobjgs_TopicTaskStatusEN.updDate)(clsgs_TopicTaskStatusBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TopicTaskStatusEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjgs_TopicTaskStatusEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 主题任务状态(gs_TopicTaskStatus))!值:$(pobjgs_TopicTaskStatusEN.memo)(clsgs_TopicTaskStatusBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TopicTaskStatusEN.statusId) == false && undefined !== pobjgs_TopicTaskStatusEN.statusId && jsString_js_1.tzDataType.isString(pobjgs_TopicTaskStatusEN.statusId) === false) {
            throw new Error("(errid:Watl000063)字段[状态Id(statusId)]的值:[$(pobjgs_TopicTaskStatusEN.statusId)], 非法，应该为字符型(In 主题任务状态(gs_TopicTaskStatus))!(clsgs_TopicTaskStatusBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TopicTaskStatusEN.statusName) == false && undefined !== pobjgs_TopicTaskStatusEN.statusName && jsString_js_1.tzDataType.isString(pobjgs_TopicTaskStatusEN.statusName) === false) {
            throw new Error("(errid:Watl000063)字段[状态名称(statusName)]的值:[$(pobjgs_TopicTaskStatusEN.statusName)], 非法，应该为字符型(In 主题任务状态(gs_TopicTaskStatus))!(clsgs_TopicTaskStatusBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TopicTaskStatusEN.updUser) == false && undefined !== pobjgs_TopicTaskStatusEN.updUser && jsString_js_1.tzDataType.isString(pobjgs_TopicTaskStatusEN.updUser) === false) {
            throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjgs_TopicTaskStatusEN.updUser)], 非法，应该为字符型(In 主题任务状态(gs_TopicTaskStatus))!(clsgs_TopicTaskStatusBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TopicTaskStatusEN.updDate) == false && undefined !== pobjgs_TopicTaskStatusEN.updDate && jsString_js_1.tzDataType.isString(pobjgs_TopicTaskStatusEN.updDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjgs_TopicTaskStatusEN.updDate)], 非法，应该为字符型(In 主题任务状态(gs_TopicTaskStatus))!(clsgs_TopicTaskStatusBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TopicTaskStatusEN.memo) == false && undefined !== pobjgs_TopicTaskStatusEN.memo && jsString_js_1.tzDataType.isString(pobjgs_TopicTaskStatusEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjgs_TopicTaskStatusEN.memo)], 非法，应该为字符型(In 主题任务状态(gs_TopicTaskStatus))!(clsgs_TopicTaskStatusBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TopicTaskStatusEN.statusId) === true) {
            throw new Error("(errid:Watl000064)字段[状态Id]不能为空(In 主题任务状态)!(clsgs_TopicTaskStatusBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjgs_TopicTaskStatusEN.SetIsCheckProperty(true);
    }
    exports.gs_TopicTaskStatus_CheckProperty4Update = gs_TopicTaskStatus_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function gs_TopicTaskStatus_GetJSONStrByObj(pobjgs_TopicTaskStatusEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjgs_TopicTaskStatusEN.sf_UpdFldSetStr = pobjgs_TopicTaskStatusEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjgs_TopicTaskStatusEN);
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
    exports.gs_TopicTaskStatus_GetJSONStrByObj = gs_TopicTaskStatus_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function gs_TopicTaskStatus_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrgs_TopicTaskStatusObjLst = new Array();
        if (strJSON === "") {
            return arrgs_TopicTaskStatusObjLst;
        }
        try {
            arrgs_TopicTaskStatusObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrgs_TopicTaskStatusObjLst;
        }
        return arrgs_TopicTaskStatusObjLst;
    }
    exports.gs_TopicTaskStatus_GetObjLstByJSONStr = gs_TopicTaskStatus_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrgs_TopicTaskStatusObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function gs_TopicTaskStatus_GetObjLstByJSONObjLst(arrgs_TopicTaskStatusObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrgs_TopicTaskStatusObjLst = new Array();
        for (const objInFor of arrgs_TopicTaskStatusObjLstS) {
            const obj1 = gs_TopicTaskStatus_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrgs_TopicTaskStatusObjLst.push(obj1);
        }
        return arrgs_TopicTaskStatusObjLst;
    }
    exports.gs_TopicTaskStatus_GetObjLstByJSONObjLst = gs_TopicTaskStatus_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function gs_TopicTaskStatus_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjgs_TopicTaskStatusEN = new clsgs_TopicTaskStatusEN_js_1.clsgs_TopicTaskStatusEN();
        if (strJSON === "") {
            return pobjgs_TopicTaskStatusEN;
        }
        try {
            pobjgs_TopicTaskStatusEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjgs_TopicTaskStatusEN;
        }
        return pobjgs_TopicTaskStatusEN;
    }
    exports.gs_TopicTaskStatus_GetObjByJSONStr = gs_TopicTaskStatus_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function gs_TopicTaskStatus_GetCombineCondition(objgs_TopicTaskStatus_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objgs_TopicTaskStatus_Cond.dicFldComparisonOp, clsgs_TopicTaskStatusEN_js_1.clsgs_TopicTaskStatusEN.con_StatusId) == true) {
            const strComparisonOp_StatusId = objgs_TopicTaskStatus_Cond.dicFldComparisonOp[clsgs_TopicTaskStatusEN_js_1.clsgs_TopicTaskStatusEN.con_StatusId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_TopicTaskStatusEN_js_1.clsgs_TopicTaskStatusEN.con_StatusId, objgs_TopicTaskStatus_Cond.statusId, strComparisonOp_StatusId);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_TopicTaskStatus_Cond.dicFldComparisonOp, clsgs_TopicTaskStatusEN_js_1.clsgs_TopicTaskStatusEN.con_StatusName) == true) {
            const strComparisonOp_StatusName = objgs_TopicTaskStatus_Cond.dicFldComparisonOp[clsgs_TopicTaskStatusEN_js_1.clsgs_TopicTaskStatusEN.con_StatusName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_TopicTaskStatusEN_js_1.clsgs_TopicTaskStatusEN.con_StatusName, objgs_TopicTaskStatus_Cond.statusName, strComparisonOp_StatusName);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_TopicTaskStatus_Cond.dicFldComparisonOp, clsgs_TopicTaskStatusEN_js_1.clsgs_TopicTaskStatusEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objgs_TopicTaskStatus_Cond.dicFldComparisonOp[clsgs_TopicTaskStatusEN_js_1.clsgs_TopicTaskStatusEN.con_UpdUser];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_TopicTaskStatusEN_js_1.clsgs_TopicTaskStatusEN.con_UpdUser, objgs_TopicTaskStatus_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_TopicTaskStatus_Cond.dicFldComparisonOp, clsgs_TopicTaskStatusEN_js_1.clsgs_TopicTaskStatusEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objgs_TopicTaskStatus_Cond.dicFldComparisonOp[clsgs_TopicTaskStatusEN_js_1.clsgs_TopicTaskStatusEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_TopicTaskStatusEN_js_1.clsgs_TopicTaskStatusEN.con_UpdDate, objgs_TopicTaskStatus_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_TopicTaskStatus_Cond.dicFldComparisonOp, clsgs_TopicTaskStatusEN_js_1.clsgs_TopicTaskStatusEN.con_Memo) == true) {
            const strComparisonOp_Memo = objgs_TopicTaskStatus_Cond.dicFldComparisonOp[clsgs_TopicTaskStatusEN_js_1.clsgs_TopicTaskStatusEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_TopicTaskStatusEN_js_1.clsgs_TopicTaskStatusEN.con_Memo, objgs_TopicTaskStatus_Cond.memo, strComparisonOp_Memo);
        }
        return strWhereCond;
    }
    exports.gs_TopicTaskStatus_GetCombineCondition = gs_TopicTaskStatus_GetCombineCondition;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objgs_TopicTaskStatusENS:源对象
     * @param objgs_TopicTaskStatusENT:目标对象
    */
    function gs_TopicTaskStatus_CopyObjTo(objgs_TopicTaskStatusENS, objgs_TopicTaskStatusENT) {
        objgs_TopicTaskStatusENT.statusId = objgs_TopicTaskStatusENS.statusId; //状态Id
        objgs_TopicTaskStatusENT.statusName = objgs_TopicTaskStatusENS.statusName; //状态名称
        objgs_TopicTaskStatusENT.updUser = objgs_TopicTaskStatusENS.updUser; //修改人
        objgs_TopicTaskStatusENT.updDate = objgs_TopicTaskStatusENS.updDate; //修改日期
        objgs_TopicTaskStatusENT.memo = objgs_TopicTaskStatusENS.memo; //备注
        objgs_TopicTaskStatusENT.sf_UpdFldSetStr = objgs_TopicTaskStatusENS.updFldString; //sf_UpdFldSetStr
    }
    exports.gs_TopicTaskStatus_CopyObjTo = gs_TopicTaskStatus_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objgs_TopicTaskStatusENS:源对象
     * @param objgs_TopicTaskStatusENT:目标对象
    */
    function gs_TopicTaskStatus_GetObjFromJsonObj(objgs_TopicTaskStatusENS) {
        const objgs_TopicTaskStatusENT = new clsgs_TopicTaskStatusEN_js_1.clsgs_TopicTaskStatusEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objgs_TopicTaskStatusENT, objgs_TopicTaskStatusENS);
        return objgs_TopicTaskStatusENT;
    }
    exports.gs_TopicTaskStatus_GetObjFromJsonObj = gs_TopicTaskStatus_GetObjFromJsonObj;
});
