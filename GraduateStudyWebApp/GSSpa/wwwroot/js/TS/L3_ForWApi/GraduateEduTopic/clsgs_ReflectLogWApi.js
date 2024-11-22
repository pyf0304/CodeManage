/**
* 类名:clsgs_ReflectLogWApi
* 表名:gs_ReflectLog(01120702)
* 生成代码版本:2022.11.02.1
* 生成日期:2022/11/02 11:47:03
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
        define(["require", "exports", "axios", "../../PubFun/CacheHelper.js", "../../L0_Entity/GraduateEduTopic/clsgs_ReflectLogEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsSysPara4WebApi.js", "../../PubFun/CacheHelper.js", "../../PubFun/jsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.gs_ReflectLog_GetObjFromJsonObj = exports.gs_ReflectLog_CopyObjTo = exports.gs_ReflectLog_GetUniCondStr4Update_mId = exports.gs_ReflectLog_GetUniCondStr_mId = exports.gs_ReflectLog_GetCombineCondition = exports.gs_ReflectLog_GetObjByJSONStr = exports.gs_ReflectLog_GetObjLstByJSONObjLst = exports.gs_ReflectLog_GetObjLstByJSONStr = exports.gs_ReflectLog_GetJSONStrByObj = exports.gs_ReflectLog_CheckProperty4Update = exports.gs_ReflectLog_CheckPropertyNew = exports.gs_ReflectLog_ReFreshThisCache = exports.gs_ReflectLog_ReFreshCache = exports.gs_ReflectLog_GetWebApiUrl = exports.gs_ReflectLog_GetMaxStrIdByPrefix = exports.gs_ReflectLog_GetRecCountByCond_Cache = exports.gs_ReflectLog_GetRecCountByCondAsync = exports.gs_ReflectLog_IsExistAsync = exports.gs_ReflectLog_IsExist_Cache = exports.gs_ReflectLog_IsExist = exports.gs_ReflectLog_IsExistRecordAsync = exports.gs_ReflectLog_IsExistRecord_Cache = exports.gs_ReflectLog_UpdateWithConditionAsync = exports.gs_ReflectLog_UpdateRecordAsync = exports.gs_ReflectLog_AddNewRecordWithReturnKey = exports.gs_ReflectLog_AddNewRecordWithReturnKeyAsync = exports.gs_ReflectLog_AddNewRecordAsync = exports.gs_ReflectLog_Delgs_ReflectLogsByCondAsync = exports.gs_ReflectLog_Delgs_ReflectLogsAsync = exports.gs_ReflectLog_DelRecordAsync = exports.gs_ReflectLog_GetObjLstByPagerAsync = exports.gs_ReflectLog_GetObjLstByPager_Cache = exports.gs_ReflectLog_GetObjLstByRange = exports.gs_ReflectLog_GetObjLstByRangeAsync = exports.gs_ReflectLog_GetTopObjLstAsync = exports.gs_ReflectLog_GetObjLstBymIdLst_Cache = exports.gs_ReflectLog_GetObjLstBymIdLstAsync = exports.gs_ReflectLog_GetSubObjLst_Cache = exports.gs_ReflectLog_GetObjLst_PureCache = exports.gs_ReflectLog_GetObjLst_Cache = exports.gs_ReflectLog_GetObjLst_sessionStorage_PureCache = exports.gs_ReflectLog_GetObjLst_sessionStorage = exports.gs_ReflectLog_GetObjLstAsync = exports.gs_ReflectLog_GetObjLst_localStorage_PureCache = exports.gs_ReflectLog_GetObjLst_localStorage = exports.gs_ReflectLog_GetObjLst_ClientCache = exports.gs_ReflectLog_GetFirstObjAsync = exports.gs_ReflectLog_GetFirstID = exports.gs_ReflectLog_GetFirstIDAsync = exports.gs_ReflectLog_FilterFunByKey = exports.gs_ReflectLog_SortFunByKey = exports.gs_ReflectLog_SortFun_Defa_2Fld = exports.gs_ReflectLog_SortFun_Defa = exports.gs_ReflectLog_func = exports.gs_ReflectLog_UpdateObjInLst_Cache = exports.gs_ReflectLog_GetObjBymId_localStorage = exports.gs_ReflectLog_GetObjBymId_Cache = exports.gs_ReflectLog_GetObjBymIdAsync = exports.gs_ReflectLog_ConstructorName = exports.gs_ReflectLog_Controller = void 0;
    /**
     * 反思日志(gs_ReflectLog)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2022年11月02日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsgs_ReflectLogEN_js_1 = require("../../L0_Entity/GraduateEduTopic/clsgs_ReflectLogEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    const CacheHelper_js_2 = require("../../PubFun/CacheHelper.js");
    const jsString_js_1 = require("../../PubFun/jsString.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.gs_ReflectLog_Controller = "gs_ReflectLogApi";
    exports.gs_ReflectLog_ConstructorName = "gs_ReflectLog";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param lngmId:关键字
    * @returns 对象
    **/
    async function gs_ReflectLog_GetObjBymIdAsync(lngmId) {
        const strThisFuncName = "GetObjBymIdAsync";
        if (lngmId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngmId]不能为空！(In GetObjBymIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjBymId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ReflectLog_Controller, strAction);
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
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_ReflectLog_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objgs_ReflectLog = gs_ReflectLog_GetObjFromJsonObj(returnObj);
                return objgs_ReflectLog;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ReflectLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ReflectLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ReflectLog_GetObjBymIdAsync = gs_ReflectLog_GetObjBymIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param lngmId:所给的关键字
     * @returns 对象
    */
    async function gs_ReflectLog_GetObjBymId_Cache(lngmId, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjBymId_Cache";
        if (lngmId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngmId]不能为空！(In GetObjBymId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        const arrgs_ReflectLogObjLst_Cache = await gs_ReflectLog_GetObjLst_Cache();
        try {
            const arrgs_ReflectLog_Sel = arrgs_ReflectLogObjLst_Cache.filter(x => x.mId == lngmId);
            let objgs_ReflectLog;
            if (arrgs_ReflectLog_Sel.length > 0) {
                objgs_ReflectLog = arrgs_ReflectLog_Sel[0];
                return objgs_ReflectLog;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    objgs_ReflectLog = await gs_ReflectLog_GetObjBymIdAsync(lngmId);
                    if (objgs_ReflectLog != null) {
                        gs_ReflectLog_ReFreshThisCache();
                        return objgs_ReflectLog;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngmId, exports.gs_ReflectLog_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.gs_ReflectLog_GetObjBymId_Cache = gs_ReflectLog_GetObjBymId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param lngmId:所给的关键字
     * @returns 对象
    */
    async function gs_ReflectLog_GetObjBymId_localStorage(lngmId) {
        const strThisFuncName = "GetObjBymId_localStorage";
        if (lngmId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngmId]不能为空！(In GetObjBymId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsgs_ReflectLogEN_js_1.clsgs_ReflectLogEN._CurrTabName, lngmId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objgs_ReflectLog_Cache = JSON.parse(strTempObj);
            return objgs_ReflectLog_Cache;
        }
        try {
            const objgs_ReflectLog = await gs_ReflectLog_GetObjBymIdAsync(lngmId);
            if (objgs_ReflectLog != null) {
                localStorage.setItem(strKey, JSON.stringify(objgs_ReflectLog));
                const strInfo = (0, clsString_js_1.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objgs_ReflectLog;
            }
            return objgs_ReflectLog;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngmId, exports.gs_ReflectLog_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.gs_ReflectLog_GetObjBymId_localStorage = gs_ReflectLog_GetObjBymId_localStorage;
    /**
     * 修改在缓存对象列表中的对象, 与后台数据库无关.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
     * @param objgs_ReflectLog:所给的对象
     * @returns 对象
    */
    async function gs_ReflectLog_UpdateObjInLst_Cache(objgs_ReflectLog) {
        const strThisFuncName = "UpdateObjInLst_Cache";
        try {
            const arrgs_ReflectLogObjLst_Cache = await gs_ReflectLog_GetObjLst_Cache();
            const obj = arrgs_ReflectLogObjLst_Cache.find(x => x.mId == objgs_ReflectLog.mId);
            if (obj != null) {
                objgs_ReflectLog.mId = obj.mId;
                (0, clsCommFunc4Web_js_1.ObjectAssign)(obj, objgs_ReflectLog);
            }
            else {
                arrgs_ReflectLogObjLst_Cache.push(objgs_ReflectLog);
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, exports.gs_ReflectLog_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.gs_ReflectLog_UpdateObjInLst_Cache = gs_ReflectLog_UpdateObjInLst_Cache;
    /*该表没有名称字段，不能生成此函数！*/
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
    async function gs_ReflectLog_func(strInFldName, strOutFldName, strInValue) {
        //const strThisFuncName = "func";
        if (strInFldName != clsgs_ReflectLogEN_js_1.clsgs_ReflectLogEN.con_mId) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsgs_ReflectLogEN_js_1.clsgs_ReflectLogEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_1.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strInFldName, clsgs_ReflectLogEN_js_1.clsgs_ReflectLogEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const lngmId = Number(strInValue);
        if (lngmId == 0) {
            return "";
        }
        const objgs_ReflectLog = await gs_ReflectLog_GetObjBymId_Cache(lngmId);
        if (objgs_ReflectLog == null)
            return "";
        return objgs_ReflectLog.GetFldValue(strOutFldName).toString();
    }
    exports.gs_ReflectLog_func = gs_ReflectLog_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function gs_ReflectLog_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.mId - b.mId;
    }
    exports.gs_ReflectLog_SortFun_Defa = gs_ReflectLog_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function gs_ReflectLog_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.topicId == b.topicId)
            return a.reflectLogName.localeCompare(b.reflectLogName);
        else
            return a.topicId.localeCompare(b.topicId);
    }
    exports.gs_ReflectLog_SortFun_Defa_2Fld = gs_ReflectLog_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function gs_ReflectLog_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsgs_ReflectLogEN_js_1.clsgs_ReflectLogEN.con_mId:
                    return (a, b) => {
                        return a.mId - b.mId;
                    };
                case clsgs_ReflectLogEN_js_1.clsgs_ReflectLogEN.con_TopicId:
                    return (a, b) => {
                        return a.topicId.localeCompare(b.topicId);
                    };
                case clsgs_ReflectLogEN_js_1.clsgs_ReflectLogEN.con_ReflectLogName:
                    return (a, b) => {
                        return a.reflectLogName.localeCompare(b.reflectLogName);
                    };
                case clsgs_ReflectLogEN_js_1.clsgs_ReflectLogEN.con_ReflectLogContent:
                    return (a, b) => {
                        return a.reflectLogContent.localeCompare(b.reflectLogContent);
                    };
                case clsgs_ReflectLogEN_js_1.clsgs_ReflectLogEN.con_UpdUser:
                    return (a, b) => {
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsgs_ReflectLogEN_js_1.clsgs_ReflectLogEN.con_UpdDate:
                    return (a, b) => {
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsgs_ReflectLogEN_js_1.clsgs_ReflectLogEN.con_Memo:
                    return (a, b) => {
                        return a.memo.localeCompare(b.memo);
                    };
                case clsgs_ReflectLogEN_js_1.clsgs_ReflectLogEN.con_id_CurrEduCls:
                    return (a, b) => {
                        return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[gs_ReflectLog]中不存在！(in ${exports.gs_ReflectLog_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsgs_ReflectLogEN_js_1.clsgs_ReflectLogEN.con_mId:
                    return (a, b) => {
                        return b.mId - a.mId;
                    };
                case clsgs_ReflectLogEN_js_1.clsgs_ReflectLogEN.con_TopicId:
                    return (a, b) => {
                        return b.topicId.localeCompare(a.topicId);
                    };
                case clsgs_ReflectLogEN_js_1.clsgs_ReflectLogEN.con_ReflectLogName:
                    return (a, b) => {
                        return b.reflectLogName.localeCompare(a.reflectLogName);
                    };
                case clsgs_ReflectLogEN_js_1.clsgs_ReflectLogEN.con_ReflectLogContent:
                    return (a, b) => {
                        return b.reflectLogContent.localeCompare(a.reflectLogContent);
                    };
                case clsgs_ReflectLogEN_js_1.clsgs_ReflectLogEN.con_UpdUser:
                    return (a, b) => {
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsgs_ReflectLogEN_js_1.clsgs_ReflectLogEN.con_UpdDate:
                    return (a, b) => {
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsgs_ReflectLogEN_js_1.clsgs_ReflectLogEN.con_Memo:
                    return (a, b) => {
                        return b.memo.localeCompare(a.memo);
                    };
                case clsgs_ReflectLogEN_js_1.clsgs_ReflectLogEN.con_id_CurrEduCls:
                    return (a, b) => {
                        return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[gs_ReflectLog]中不存在！(in ${exports.gs_ReflectLog_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.gs_ReflectLog_SortFunByKey = gs_ReflectLog_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function gs_ReflectLog_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsgs_ReflectLogEN_js_1.clsgs_ReflectLogEN.con_mId:
                return (obj) => {
                    return obj.mId === value;
                };
            case clsgs_ReflectLogEN_js_1.clsgs_ReflectLogEN.con_TopicId:
                return (obj) => {
                    return obj.topicId === value;
                };
            case clsgs_ReflectLogEN_js_1.clsgs_ReflectLogEN.con_ReflectLogName:
                return (obj) => {
                    return obj.reflectLogName === value;
                };
            case clsgs_ReflectLogEN_js_1.clsgs_ReflectLogEN.con_ReflectLogContent:
                return (obj) => {
                    return obj.reflectLogContent === value;
                };
            case clsgs_ReflectLogEN_js_1.clsgs_ReflectLogEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsgs_ReflectLogEN_js_1.clsgs_ReflectLogEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsgs_ReflectLogEN_js_1.clsgs_ReflectLogEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            case clsgs_ReflectLogEN_js_1.clsgs_ReflectLogEN.con_id_CurrEduCls:
                return (obj) => {
                    return obj.id_CurrEduCls === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[gs_ReflectLog]中不存在！(in ${exports.gs_ReflectLog_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.gs_ReflectLog_FilterFunByKey = gs_ReflectLog_FilterFunByKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function gs_ReflectLog_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ReflectLog_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ReflectLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ReflectLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ReflectLog_GetFirstIDAsync = gs_ReflectLog_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function gs_ReflectLog_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ReflectLog_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ReflectLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ReflectLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ReflectLog_GetFirstID = gs_ReflectLog_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function gs_ReflectLog_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ReflectLog_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_ReflectLog_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objgs_ReflectLog = gs_ReflectLog_GetObjFromJsonObj(returnObj);
                return objgs_ReflectLog;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ReflectLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ReflectLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ReflectLog_GetFirstObjAsync = gs_ReflectLog_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_ReflectLog_GetObjLst_ClientCache() {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsgs_ReflectLogEN_js_1.clsgs_ReflectLogEN._CurrTabName;
        clsgs_ReflectLogEN_js_1.clsgs_ReflectLogEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsgs_ReflectLogEN_js_1.clsgs_ReflectLogEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsgs_ReflectLogEN_js_1.clsgs_ReflectLogEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsgs_ReflectLogEN_js_1.clsgs_ReflectLogEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_2.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrgs_ReflectLogExObjLst_Cache = CacheHelper_js_2.CacheHelper.Get(strKey);
            const arrgs_ReflectLogObjLst_T = gs_ReflectLog_GetObjLstByJSONObjLst(arrgs_ReflectLogExObjLst_Cache);
            return arrgs_ReflectLogObjLst_T;
        }
        try {
            const arrgs_ReflectLogExObjLst = await gs_ReflectLog_GetObjLstAsync(strWhereCond);
            CacheHelper_js_2.CacheHelper.Add(strKey, arrgs_ReflectLogExObjLst);
            const strInfo = (0, clsString_js_1.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_ReflectLogExObjLst.length);
            console.log(strInfo);
            return arrgs_ReflectLogExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.gs_ReflectLog_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.gs_ReflectLog_GetObjLst_ClientCache = gs_ReflectLog_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_ReflectLog_GetObjLst_localStorage() {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsgs_ReflectLogEN_js_1.clsgs_ReflectLogEN._CurrTabName;
        clsgs_ReflectLogEN_js_1.clsgs_ReflectLogEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsgs_ReflectLogEN_js_1.clsgs_ReflectLogEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsgs_ReflectLogEN_js_1.clsgs_ReflectLogEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsgs_ReflectLogEN_js_1.clsgs_ReflectLogEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrgs_ReflectLogExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrgs_ReflectLogObjLst_T = gs_ReflectLog_GetObjLstByJSONObjLst(arrgs_ReflectLogExObjLst_Cache);
            return arrgs_ReflectLogObjLst_T;
        }
        try {
            const arrgs_ReflectLogExObjLst = await gs_ReflectLog_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrgs_ReflectLogExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_ReflectLogExObjLst.length);
            console.log(strInfo);
            return arrgs_ReflectLogExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.gs_ReflectLog_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.gs_ReflectLog_GetObjLst_localStorage = gs_ReflectLog_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_ReflectLog_GetObjLst_localStorage_PureCache() {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsgs_ReflectLogEN_js_1.clsgs_ReflectLogEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrgs_ReflectLogObjLst_Cache = JSON.parse(strTempObjLst);
            return arrgs_ReflectLogObjLst_Cache;
        }
        else
            return null;
    }
    exports.gs_ReflectLog_GetObjLst_localStorage_PureCache = gs_ReflectLog_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function gs_ReflectLog_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ReflectLog_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_ReflectLog_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_ReflectLog_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ReflectLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ReflectLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ReflectLog_GetObjLstAsync = gs_ReflectLog_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_ReflectLog_GetObjLst_sessionStorage() {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsgs_ReflectLogEN_js_1.clsgs_ReflectLogEN._CurrTabName;
        clsgs_ReflectLogEN_js_1.clsgs_ReflectLogEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsgs_ReflectLogEN_js_1.clsgs_ReflectLogEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsgs_ReflectLogEN_js_1.clsgs_ReflectLogEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsgs_ReflectLogEN_js_1.clsgs_ReflectLogEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrgs_ReflectLogExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrgs_ReflectLogObjLst_T = gs_ReflectLog_GetObjLstByJSONObjLst(arrgs_ReflectLogExObjLst_Cache);
            return arrgs_ReflectLogObjLst_T;
        }
        try {
            const arrgs_ReflectLogExObjLst = await gs_ReflectLog_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrgs_ReflectLogExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_ReflectLogExObjLst.length);
            console.log(strInfo);
            return arrgs_ReflectLogExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.gs_ReflectLog_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.gs_ReflectLog_GetObjLst_sessionStorage = gs_ReflectLog_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_ReflectLog_GetObjLst_sessionStorage_PureCache() {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsgs_ReflectLogEN_js_1.clsgs_ReflectLogEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrgs_ReflectLogObjLst_Cache = JSON.parse(strTempObjLst);
            return arrgs_ReflectLogObjLst_Cache;
        }
        else
            return null;
    }
    exports.gs_ReflectLog_GetObjLst_sessionStorage_PureCache = gs_ReflectLog_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_ReflectLog_GetObjLst_Cache() {
        //const strThisFuncName = "GetObjLst_Cache";
        let arrgs_ReflectLogObjLst_Cache;
        switch (clsgs_ReflectLogEN_js_1.clsgs_ReflectLogEN.CacheModeId) {
            case "04": //sessionStorage
                arrgs_ReflectLogObjLst_Cache = await gs_ReflectLog_GetObjLst_sessionStorage();
                break;
            case "03": //localStorage
                arrgs_ReflectLogObjLst_Cache = await gs_ReflectLog_GetObjLst_localStorage();
                break;
            case "02": //ClientCache
                arrgs_ReflectLogObjLst_Cache = await gs_ReflectLog_GetObjLst_ClientCache();
                break;
            default:
                arrgs_ReflectLogObjLst_Cache = await gs_ReflectLog_GetObjLst_ClientCache();
                break;
        }
        const arrgs_ReflectLogObjLst = gs_ReflectLog_GetObjLstByJSONObjLst(arrgs_ReflectLogObjLst_Cache);
        return arrgs_ReflectLogObjLst_Cache;
    }
    exports.gs_ReflectLog_GetObjLst_Cache = gs_ReflectLog_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_ReflectLog_GetObjLst_PureCache() {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrgs_ReflectLogObjLst_Cache;
        switch (clsgs_ReflectLogEN_js_1.clsgs_ReflectLogEN.CacheModeId) {
            case "04": //sessionStorage
                arrgs_ReflectLogObjLst_Cache = await gs_ReflectLog_GetObjLst_sessionStorage_PureCache();
                break;
            case "03": //localStorage
                arrgs_ReflectLogObjLst_Cache = await gs_ReflectLog_GetObjLst_localStorage_PureCache();
                break;
            case "02": //ClientCache
                arrgs_ReflectLogObjLst_Cache = null;
                break;
            default:
                arrgs_ReflectLogObjLst_Cache = null;
                break;
        }
        return arrgs_ReflectLogObjLst_Cache;
    }
    exports.gs_ReflectLog_GetObjLst_PureCache = gs_ReflectLog_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objlngmId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function gs_ReflectLog_GetSubObjLst_Cache(objgs_ReflectLog_Cond) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrgs_ReflectLogObjLst_Cache = await gs_ReflectLog_GetObjLst_Cache();
        let arrgs_ReflectLog_Sel = arrgs_ReflectLogObjLst_Cache;
        if (objgs_ReflectLog_Cond.sf_FldComparisonOp == null || objgs_ReflectLog_Cond.sf_FldComparisonOp == "")
            return arrgs_ReflectLog_Sel;
        const dicFldComparisonOp = JSON.parse(objgs_ReflectLog_Cond.sf_FldComparisonOp);
        //console.log("clsgs_ReflectLogWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objgs_ReflectLog_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrgs_ReflectLog_Sel = arrgs_ReflectLog_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objgs_ReflectLog_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_ReflectLog_Sel = arrgs_ReflectLog_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrgs_ReflectLog_Sel = arrgs_ReflectLog_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_ReflectLog_Sel = arrgs_ReflectLog_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_ReflectLog_Sel = arrgs_ReflectLog_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrgs_ReflectLog_Sel = arrgs_ReflectLog_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrgs_ReflectLog_Sel = arrgs_ReflectLog_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrgs_ReflectLog_Sel = arrgs_ReflectLog_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrgs_ReflectLog_Sel = arrgs_ReflectLog_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrgs_ReflectLog_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objgs_ReflectLog_Cond), exports.gs_ReflectLog_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.gs_ReflectLog_GetSubObjLst_Cache = gs_ReflectLog_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrmId:关键字列表
    * @returns 对象列表
    **/
    async function gs_ReflectLog_GetObjLstBymIdLstAsync(arrmId) {
        const strThisFuncName = "GetObjLstBymIdLstAsync";
        const strAction = "GetObjLstBymIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ReflectLog_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrmId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_ReflectLog_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_ReflectLog_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ReflectLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ReflectLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ReflectLog_GetObjLstBymIdLstAsync = gs_ReflectLog_GetObjLstBymIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrlngmIdLst:关键字列表
     * @returns 对象列表
    */
    async function gs_ReflectLog_GetObjLstBymIdLst_Cache(arrmIdLst) {
        const strThisFuncName = "GetObjLstBymIdLst_Cache";
        try {
            const arrgs_ReflectLogObjLst_Cache = await gs_ReflectLog_GetObjLst_Cache();
            const arrgs_ReflectLog_Sel = arrgs_ReflectLogObjLst_Cache.filter(x => arrmIdLst.indexOf(x.mId) > -1);
            return arrgs_ReflectLog_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrmIdLst.join(","), exports.gs_ReflectLog_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.gs_ReflectLog_GetObjLstBymIdLst_Cache = gs_ReflectLog_GetObjLstBymIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function gs_ReflectLog_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ReflectLog_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_ReflectLog_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_ReflectLog_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ReflectLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ReflectLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ReflectLog_GetTopObjLstAsync = gs_ReflectLog_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function gs_ReflectLog_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ReflectLog_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_ReflectLog_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_ReflectLog_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ReflectLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ReflectLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ReflectLog_GetObjLstByRangeAsync = gs_ReflectLog_GetObjLstByRangeAsync;
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
    async function gs_ReflectLog_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ReflectLog_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ReflectLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ReflectLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ReflectLog_GetObjLstByRange = gs_ReflectLog_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function gs_ReflectLog_GetObjLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const arrgs_ReflectLogObjLst_Cache = await gs_ReflectLog_GetObjLst_Cache();
        if (arrgs_ReflectLogObjLst_Cache.length == 0)
            return arrgs_ReflectLogObjLst_Cache;
        let arrgs_ReflectLog_Sel = arrgs_ReflectLogObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objgs_ReflectLog_Cond = new clsgs_ReflectLogEN_js_1.clsgs_ReflectLogEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objgs_ReflectLog_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsgs_ReflectLogWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrgs_ReflectLog_Sel = arrgs_ReflectLog_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objgs_ReflectLog_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_ReflectLog_Sel = arrgs_ReflectLog_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrgs_ReflectLog_Sel = arrgs_ReflectLog_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrgs_ReflectLog_Sel = arrgs_ReflectLog_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_ReflectLog_Sel = arrgs_ReflectLog_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_ReflectLog_Sel = arrgs_ReflectLog_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrgs_ReflectLog_Sel = arrgs_ReflectLog_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrgs_ReflectLog_Sel = arrgs_ReflectLog_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrgs_ReflectLog_Sel = arrgs_ReflectLog_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrgs_ReflectLog_Sel = arrgs_ReflectLog_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrgs_ReflectLog_Sel.length == 0)
                return arrgs_ReflectLog_Sel;
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
                arrgs_ReflectLog_Sel = arrgs_ReflectLog_Sel.sort(gs_ReflectLog_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrgs_ReflectLog_Sel = arrgs_ReflectLog_Sel.sort(objPagerPara.sortFun);
            }
            arrgs_ReflectLog_Sel = arrgs_ReflectLog_Sel.slice(intStart, intEnd);
            return arrgs_ReflectLog_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.gs_ReflectLog_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.gs_ReflectLog_GetObjLstByPager_Cache = gs_ReflectLog_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function gs_ReflectLog_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ReflectLog_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_ReflectLog_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_ReflectLog_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ReflectLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ReflectLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ReflectLog_GetObjLstByPagerAsync = gs_ReflectLog_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param lngmId:关键字
    * @returns 获取删除的结果
    **/
    async function gs_ReflectLog_DelRecordAsync(lngmId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ReflectLog_Controller, strAction);
        strUrl = (0, clsString_js_1.Format)("{0}/?Id={1}", strUrl, lngmId);
        try {
            const response = await axios_1.default.delete(strUrl, {
                params: { "Id": lngmId, }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ReflectLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ReflectLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ReflectLog_DelRecordAsync = gs_ReflectLog_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrmId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function gs_ReflectLog_Delgs_ReflectLogsAsync(arrmId) {
        const strThisFuncName = "Delgs_ReflectLogsAsync";
        const strAction = "Delgs_ReflectLogs";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ReflectLog_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrmId);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ReflectLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ReflectLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ReflectLog_Delgs_ReflectLogsAsync = gs_ReflectLog_Delgs_ReflectLogsAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function gs_ReflectLog_Delgs_ReflectLogsByCondAsync(strWhereCond) {
        const strThisFuncName = "Delgs_ReflectLogsByCondAsync";
        const strAction = "Delgs_ReflectLogsByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ReflectLog_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ReflectLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ReflectLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ReflectLog_Delgs_ReflectLogsByCondAsync = gs_ReflectLog_Delgs_ReflectLogsByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objgs_ReflectLogEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function gs_ReflectLog_AddNewRecordAsync(objgs_ReflectLogEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objgs_ReflectLogEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ReflectLog_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_ReflectLogEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ReflectLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ReflectLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ReflectLog_AddNewRecordAsync = gs_ReflectLog_AddNewRecordAsync;
    /* 数据类型不是字符型，不可以最大关键字的方式添加记录。*/
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objgs_ReflectLogEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function gs_ReflectLog_AddNewRecordWithReturnKeyAsync(objgs_ReflectLogEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ReflectLog_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_ReflectLogEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ReflectLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ReflectLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ReflectLog_AddNewRecordWithReturnKeyAsync = gs_ReflectLog_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objgs_ReflectLogEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function gs_ReflectLog_AddNewRecordWithReturnKey(objgs_ReflectLogEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objgs_ReflectLogEN.mId === null || objgs_ReflectLogEN.mId === 0) {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ReflectLog_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_ReflectLogEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ReflectLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ReflectLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ReflectLog_AddNewRecordWithReturnKey = gs_ReflectLog_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objgs_ReflectLogEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function gs_ReflectLog_UpdateRecordAsync(objgs_ReflectLogEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objgs_ReflectLogEN.sf_UpdFldSetStr === undefined || objgs_ReflectLogEN.sf_UpdFldSetStr === null || objgs_ReflectLogEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_ReflectLogEN.mId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ReflectLog_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_ReflectLogEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ReflectLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ReflectLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ReflectLog_UpdateRecordAsync = gs_ReflectLog_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objgs_ReflectLogEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function gs_ReflectLog_UpdateWithConditionAsync(objgs_ReflectLogEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objgs_ReflectLogEN.sf_UpdFldSetStr === undefined || objgs_ReflectLogEN.sf_UpdFldSetStr === null || objgs_ReflectLogEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_ReflectLogEN.mId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ReflectLog_Controller, strAction);
        objgs_ReflectLogEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objgs_ReflectLogEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ReflectLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ReflectLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ReflectLog_UpdateWithConditionAsync = gs_ReflectLog_UpdateWithConditionAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objlngmId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function gs_ReflectLog_IsExistRecord_Cache(objgs_ReflectLog_Cond) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrgs_ReflectLogObjLst_Cache = await gs_ReflectLog_GetObjLst_Cache();
        if (arrgs_ReflectLogObjLst_Cache == null)
            return false;
        let arrgs_ReflectLog_Sel = arrgs_ReflectLogObjLst_Cache;
        if (objgs_ReflectLog_Cond.sf_FldComparisonOp == null || objgs_ReflectLog_Cond.sf_FldComparisonOp == "")
            return arrgs_ReflectLog_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objgs_ReflectLog_Cond.sf_FldComparisonOp);
        //console.log("clsgs_ReflectLogWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objgs_ReflectLog_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objgs_ReflectLog_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_ReflectLog_Sel = arrgs_ReflectLog_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrgs_ReflectLog_Sel = arrgs_ReflectLog_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_ReflectLog_Sel = arrgs_ReflectLog_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_ReflectLog_Sel = arrgs_ReflectLog_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrgs_ReflectLog_Sel = arrgs_ReflectLog_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrgs_ReflectLog_Sel = arrgs_ReflectLog_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrgs_ReflectLog_Sel = arrgs_ReflectLog_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrgs_ReflectLog_Sel = arrgs_ReflectLog_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrgs_ReflectLog_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objgs_ReflectLog_Cond), exports.gs_ReflectLog_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.gs_ReflectLog_IsExistRecord_Cache = gs_ReflectLog_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function gs_ReflectLog_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ReflectLog_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ReflectLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ReflectLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ReflectLog_IsExistRecordAsync = gs_ReflectLog_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param lngmId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function gs_ReflectLog_IsExist(lngmId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ReflectLog_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ReflectLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ReflectLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ReflectLog_IsExist = gs_ReflectLog_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param lngmId:所给的关键字
     * @returns 对象
    */
    async function gs_ReflectLog_IsExist_Cache(lngmId) {
        const strThisFuncName = "IsExist_Cache";
        const arrgs_ReflectLogObjLst_Cache = await gs_ReflectLog_GetObjLst_Cache();
        if (arrgs_ReflectLogObjLst_Cache == null)
            return false;
        try {
            const arrgs_ReflectLog_Sel = arrgs_ReflectLogObjLst_Cache.filter(x => x.mId == lngmId);
            if (arrgs_ReflectLog_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", lngmId, exports.gs_ReflectLog_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.gs_ReflectLog_IsExist_Cache = gs_ReflectLog_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param lngmId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function gs_ReflectLog_IsExistAsync(lngmId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ReflectLog_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ReflectLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ReflectLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ReflectLog_IsExistAsync = gs_ReflectLog_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function gs_ReflectLog_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ReflectLog_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ReflectLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ReflectLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ReflectLog_GetRecCountByCondAsync = gs_ReflectLog_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objgs_ReflectLog_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function gs_ReflectLog_GetRecCountByCond_Cache(objgs_ReflectLog_Cond) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrgs_ReflectLogObjLst_Cache = await gs_ReflectLog_GetObjLst_Cache();
        if (arrgs_ReflectLogObjLst_Cache == null)
            return 0;
        let arrgs_ReflectLog_Sel = arrgs_ReflectLogObjLst_Cache;
        if (objgs_ReflectLog_Cond.sf_FldComparisonOp == null || objgs_ReflectLog_Cond.sf_FldComparisonOp == "")
            return arrgs_ReflectLog_Sel.length;
        const dicFldComparisonOp = JSON.parse(objgs_ReflectLog_Cond.sf_FldComparisonOp);
        //console.log("clsgs_ReflectLogWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objgs_ReflectLog_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrgs_ReflectLog_Sel = arrgs_ReflectLog_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objgs_ReflectLog_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_ReflectLog_Sel = arrgs_ReflectLog_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrgs_ReflectLog_Sel = arrgs_ReflectLog_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrgs_ReflectLog_Sel = arrgs_ReflectLog_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_ReflectLog_Sel = arrgs_ReflectLog_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_ReflectLog_Sel = arrgs_ReflectLog_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrgs_ReflectLog_Sel = arrgs_ReflectLog_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrgs_ReflectLog_Sel = arrgs_ReflectLog_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrgs_ReflectLog_Sel = arrgs_ReflectLog_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrgs_ReflectLog_Sel = arrgs_ReflectLog_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrgs_ReflectLog_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objgs_ReflectLog_Cond), exports.gs_ReflectLog_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.gs_ReflectLog_GetRecCountByCond_Cache = gs_ReflectLog_GetRecCountByCond_Cache;
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
    async function gs_ReflectLog_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ReflectLog_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ReflectLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ReflectLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ReflectLog_GetMaxStrIdByPrefix = gs_ReflectLog_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function gs_ReflectLog_GetWebApiUrl(strController, strAction) {
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
    exports.gs_ReflectLog_GetWebApiUrl = gs_ReflectLog_GetWebApiUrl;
    /**
    * 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshCache)
    **/
    function gs_ReflectLog_ReFreshCache() {
        const strThisFuncName = "ReFreshCache";
        const strMsg = (0, clsString_js_1.Format)("刷新缓存成功！");
        console.trace(strMsg);
        // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
        const strKey = clsgs_ReflectLogEN_js_1.clsgs_ReflectLogEN._CurrTabName;
        switch (clsgs_ReflectLogEN_js_1.clsgs_ReflectLogEN.CacheModeId) {
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
    exports.gs_ReflectLog_ReFreshCache = gs_ReflectLog_ReFreshCache;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function gs_ReflectLog_ReFreshThisCache() {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = clsgs_ReflectLogEN_js_1.clsgs_ReflectLogEN._CurrTabName;
            switch (clsgs_ReflectLogEN_js_1.clsgs_ReflectLogEN.CacheModeId) {
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
    exports.gs_ReflectLog_ReFreshThisCache = gs_ReflectLog_ReFreshThisCache;
    /* 该表的下拉框功能没有设置，不需要生成下拉框绑定函数。*/
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function gs_ReflectLog_CheckPropertyNew(pobjgs_ReflectLogEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ReflectLogEN.topicId) == false && (0, clsString_js_1.GetStrLen)(pobjgs_ReflectLogEN.topicId) > 8) {
            throw new Error("(errid:Watl000059)字段[主题Id(topicId)]的长度不能超过8(In 反思日志(gs_ReflectLog))!值:$(pobjgs_ReflectLogEN.topicId)(clsgs_ReflectLogBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ReflectLogEN.reflectLogName) == false && (0, clsString_js_1.GetStrLen)(pobjgs_ReflectLogEN.reflectLogName) > 1000) {
            throw new Error("(errid:Watl000059)字段[标题(reflectLogName)]的长度不能超过1000(In 反思日志(gs_ReflectLog))!值:$(pobjgs_ReflectLogEN.reflectLogName)(clsgs_ReflectLogBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ReflectLogEN.reflectLogContent) == false && (0, clsString_js_1.GetStrLen)(pobjgs_ReflectLogEN.reflectLogContent) > 5000) {
            throw new Error("(errid:Watl000059)字段[内容(reflectLogContent)]的长度不能超过5000(In 反思日志(gs_ReflectLog))!值:$(pobjgs_ReflectLogEN.reflectLogContent)(clsgs_ReflectLogBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ReflectLogEN.updUser) == false && (0, clsString_js_1.GetStrLen)(pobjgs_ReflectLogEN.updUser) > 20) {
            throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 反思日志(gs_ReflectLog))!值:$(pobjgs_ReflectLogEN.updUser)(clsgs_ReflectLogBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ReflectLogEN.updDate) == false && (0, clsString_js_1.GetStrLen)(pobjgs_ReflectLogEN.updDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 反思日志(gs_ReflectLog))!值:$(pobjgs_ReflectLogEN.updDate)(clsgs_ReflectLogBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ReflectLogEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjgs_ReflectLogEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 反思日志(gs_ReflectLog))!值:$(pobjgs_ReflectLogEN.memo)(clsgs_ReflectLogBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ReflectLogEN.id_CurrEduCls) == false && (0, clsString_js_1.GetStrLen)(pobjgs_ReflectLogEN.id_CurrEduCls) > 8) {
            throw new Error("(errid:Watl000059)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 反思日志(gs_ReflectLog))!值:$(pobjgs_ReflectLogEN.id_CurrEduCls)(clsgs_ReflectLogBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if (null != pobjgs_ReflectLogEN.mId && undefined !== pobjgs_ReflectLogEN.mId && jsString_js_1.tzDataType.isNumber(pobjgs_ReflectLogEN.mId) === false) {
            throw new Error("(errid:Watl000060)字段[mId(mId)]的值:[$(pobjgs_ReflectLogEN.mId)], 非法，应该为数值型(In 反思日志(gs_ReflectLog))!(clsgs_ReflectLogBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ReflectLogEN.topicId) == false && undefined !== pobjgs_ReflectLogEN.topicId && jsString_js_1.tzDataType.isString(pobjgs_ReflectLogEN.topicId) === false) {
            throw new Error("(errid:Watl000060)字段[主题Id(topicId)]的值:[$(pobjgs_ReflectLogEN.topicId)], 非法，应该为字符型(In 反思日志(gs_ReflectLog))!(clsgs_ReflectLogBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ReflectLogEN.reflectLogName) == false && undefined !== pobjgs_ReflectLogEN.reflectLogName && jsString_js_1.tzDataType.isString(pobjgs_ReflectLogEN.reflectLogName) === false) {
            throw new Error("(errid:Watl000060)字段[标题(reflectLogName)]的值:[$(pobjgs_ReflectLogEN.reflectLogName)], 非法，应该为字符型(In 反思日志(gs_ReflectLog))!(clsgs_ReflectLogBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ReflectLogEN.reflectLogContent) == false && undefined !== pobjgs_ReflectLogEN.reflectLogContent && jsString_js_1.tzDataType.isString(pobjgs_ReflectLogEN.reflectLogContent) === false) {
            throw new Error("(errid:Watl000060)字段[内容(reflectLogContent)]的值:[$(pobjgs_ReflectLogEN.reflectLogContent)], 非法，应该为字符型(In 反思日志(gs_ReflectLog))!(clsgs_ReflectLogBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ReflectLogEN.updUser) == false && undefined !== pobjgs_ReflectLogEN.updUser && jsString_js_1.tzDataType.isString(pobjgs_ReflectLogEN.updUser) === false) {
            throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjgs_ReflectLogEN.updUser)], 非法，应该为字符型(In 反思日志(gs_ReflectLog))!(clsgs_ReflectLogBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ReflectLogEN.updDate) == false && undefined !== pobjgs_ReflectLogEN.updDate && jsString_js_1.tzDataType.isString(pobjgs_ReflectLogEN.updDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjgs_ReflectLogEN.updDate)], 非法，应该为字符型(In 反思日志(gs_ReflectLog))!(clsgs_ReflectLogBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ReflectLogEN.memo) == false && undefined !== pobjgs_ReflectLogEN.memo && jsString_js_1.tzDataType.isString(pobjgs_ReflectLogEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjgs_ReflectLogEN.memo)], 非法，应该为字符型(In 反思日志(gs_ReflectLog))!(clsgs_ReflectLogBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ReflectLogEN.id_CurrEduCls) == false && undefined !== pobjgs_ReflectLogEN.id_CurrEduCls && jsString_js_1.tzDataType.isString(pobjgs_ReflectLogEN.id_CurrEduCls) === false) {
            throw new Error("(errid:Watl000060)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjgs_ReflectLogEN.id_CurrEduCls)], 非法，应该为字符型(In 反思日志(gs_ReflectLog))!(clsgs_ReflectLogBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjgs_ReflectLogEN.SetIsCheckProperty(true);
    }
    exports.gs_ReflectLog_CheckPropertyNew = gs_ReflectLog_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function gs_ReflectLog_CheckProperty4Update(pobjgs_ReflectLogEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ReflectLogEN.topicId) == false && (0, clsString_js_1.GetStrLen)(pobjgs_ReflectLogEN.topicId) > 8) {
            throw new Error("(errid:Watl000062)字段[主题Id(topicId)]的长度不能超过8(In 反思日志(gs_ReflectLog))!值:$(pobjgs_ReflectLogEN.topicId)(clsgs_ReflectLogBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ReflectLogEN.reflectLogName) == false && (0, clsString_js_1.GetStrLen)(pobjgs_ReflectLogEN.reflectLogName) > 1000) {
            throw new Error("(errid:Watl000062)字段[标题(reflectLogName)]的长度不能超过1000(In 反思日志(gs_ReflectLog))!值:$(pobjgs_ReflectLogEN.reflectLogName)(clsgs_ReflectLogBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ReflectLogEN.reflectLogContent) == false && (0, clsString_js_1.GetStrLen)(pobjgs_ReflectLogEN.reflectLogContent) > 5000) {
            throw new Error("(errid:Watl000062)字段[内容(reflectLogContent)]的长度不能超过5000(In 反思日志(gs_ReflectLog))!值:$(pobjgs_ReflectLogEN.reflectLogContent)(clsgs_ReflectLogBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ReflectLogEN.updUser) == false && (0, clsString_js_1.GetStrLen)(pobjgs_ReflectLogEN.updUser) > 20) {
            throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 反思日志(gs_ReflectLog))!值:$(pobjgs_ReflectLogEN.updUser)(clsgs_ReflectLogBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ReflectLogEN.updDate) == false && (0, clsString_js_1.GetStrLen)(pobjgs_ReflectLogEN.updDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 反思日志(gs_ReflectLog))!值:$(pobjgs_ReflectLogEN.updDate)(clsgs_ReflectLogBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ReflectLogEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjgs_ReflectLogEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 反思日志(gs_ReflectLog))!值:$(pobjgs_ReflectLogEN.memo)(clsgs_ReflectLogBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ReflectLogEN.id_CurrEduCls) == false && (0, clsString_js_1.GetStrLen)(pobjgs_ReflectLogEN.id_CurrEduCls) > 8) {
            throw new Error("(errid:Watl000062)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 反思日志(gs_ReflectLog))!值:$(pobjgs_ReflectLogEN.id_CurrEduCls)(clsgs_ReflectLogBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if (null != pobjgs_ReflectLogEN.mId && undefined !== pobjgs_ReflectLogEN.mId && jsString_js_1.tzDataType.isNumber(pobjgs_ReflectLogEN.mId) === false) {
            throw new Error("(errid:Watl000063)字段[mId(mId)]的值:[$(pobjgs_ReflectLogEN.mId)], 非法，应该为数值型(In 反思日志(gs_ReflectLog))!(clsgs_ReflectLogBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ReflectLogEN.topicId) == false && undefined !== pobjgs_ReflectLogEN.topicId && jsString_js_1.tzDataType.isString(pobjgs_ReflectLogEN.topicId) === false) {
            throw new Error("(errid:Watl000063)字段[主题Id(topicId)]的值:[$(pobjgs_ReflectLogEN.topicId)], 非法，应该为字符型(In 反思日志(gs_ReflectLog))!(clsgs_ReflectLogBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ReflectLogEN.reflectLogName) == false && undefined !== pobjgs_ReflectLogEN.reflectLogName && jsString_js_1.tzDataType.isString(pobjgs_ReflectLogEN.reflectLogName) === false) {
            throw new Error("(errid:Watl000063)字段[标题(reflectLogName)]的值:[$(pobjgs_ReflectLogEN.reflectLogName)], 非法，应该为字符型(In 反思日志(gs_ReflectLog))!(clsgs_ReflectLogBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ReflectLogEN.reflectLogContent) == false && undefined !== pobjgs_ReflectLogEN.reflectLogContent && jsString_js_1.tzDataType.isString(pobjgs_ReflectLogEN.reflectLogContent) === false) {
            throw new Error("(errid:Watl000063)字段[内容(reflectLogContent)]的值:[$(pobjgs_ReflectLogEN.reflectLogContent)], 非法，应该为字符型(In 反思日志(gs_ReflectLog))!(clsgs_ReflectLogBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ReflectLogEN.updUser) == false && undefined !== pobjgs_ReflectLogEN.updUser && jsString_js_1.tzDataType.isString(pobjgs_ReflectLogEN.updUser) === false) {
            throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjgs_ReflectLogEN.updUser)], 非法，应该为字符型(In 反思日志(gs_ReflectLog))!(clsgs_ReflectLogBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ReflectLogEN.updDate) == false && undefined !== pobjgs_ReflectLogEN.updDate && jsString_js_1.tzDataType.isString(pobjgs_ReflectLogEN.updDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjgs_ReflectLogEN.updDate)], 非法，应该为字符型(In 反思日志(gs_ReflectLog))!(clsgs_ReflectLogBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ReflectLogEN.memo) == false && undefined !== pobjgs_ReflectLogEN.memo && jsString_js_1.tzDataType.isString(pobjgs_ReflectLogEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjgs_ReflectLogEN.memo)], 非法，应该为字符型(In 反思日志(gs_ReflectLog))!(clsgs_ReflectLogBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ReflectLogEN.id_CurrEduCls) == false && undefined !== pobjgs_ReflectLogEN.id_CurrEduCls && jsString_js_1.tzDataType.isString(pobjgs_ReflectLogEN.id_CurrEduCls) === false) {
            throw new Error("(errid:Watl000063)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjgs_ReflectLogEN.id_CurrEduCls)], 非法，应该为字符型(In 反思日志(gs_ReflectLog))!(clsgs_ReflectLogBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if (null === pobjgs_ReflectLogEN.mId
            || pobjgs_ReflectLogEN.mId != null && pobjgs_ReflectLogEN.mId.toString() === "") {
            throw new Error("(errid:Watl000064)字段[mId]不能为空(In 反思日志)!(clsgs_ReflectLogBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjgs_ReflectLogEN.SetIsCheckProperty(true);
    }
    exports.gs_ReflectLog_CheckProperty4Update = gs_ReflectLog_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function gs_ReflectLog_GetJSONStrByObj(pobjgs_ReflectLogEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjgs_ReflectLogEN.sf_UpdFldSetStr = pobjgs_ReflectLogEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjgs_ReflectLogEN);
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
    exports.gs_ReflectLog_GetJSONStrByObj = gs_ReflectLog_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function gs_ReflectLog_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrgs_ReflectLogObjLst = new Array();
        if (strJSON === "") {
            return arrgs_ReflectLogObjLst;
        }
        try {
            arrgs_ReflectLogObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrgs_ReflectLogObjLst;
        }
        return arrgs_ReflectLogObjLst;
    }
    exports.gs_ReflectLog_GetObjLstByJSONStr = gs_ReflectLog_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrgs_ReflectLogObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function gs_ReflectLog_GetObjLstByJSONObjLst(arrgs_ReflectLogObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrgs_ReflectLogObjLst = new Array();
        for (const objInFor of arrgs_ReflectLogObjLstS) {
            const obj1 = gs_ReflectLog_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrgs_ReflectLogObjLst.push(obj1);
        }
        return arrgs_ReflectLogObjLst;
    }
    exports.gs_ReflectLog_GetObjLstByJSONObjLst = gs_ReflectLog_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function gs_ReflectLog_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjgs_ReflectLogEN = new clsgs_ReflectLogEN_js_1.clsgs_ReflectLogEN();
        if (strJSON === "") {
            return pobjgs_ReflectLogEN;
        }
        try {
            pobjgs_ReflectLogEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjgs_ReflectLogEN;
        }
        return pobjgs_ReflectLogEN;
    }
    exports.gs_ReflectLog_GetObjByJSONStr = gs_ReflectLog_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function gs_ReflectLog_GetCombineCondition(objgs_ReflectLog_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objgs_ReflectLog_Cond.dicFldComparisonOp, clsgs_ReflectLogEN_js_1.clsgs_ReflectLogEN.con_mId) == true) {
            const strComparisonOp_mId = objgs_ReflectLog_Cond.dicFldComparisonOp[clsgs_ReflectLogEN_js_1.clsgs_ReflectLogEN.con_mId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsgs_ReflectLogEN_js_1.clsgs_ReflectLogEN.con_mId, objgs_ReflectLog_Cond.mId, strComparisonOp_mId);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_ReflectLog_Cond.dicFldComparisonOp, clsgs_ReflectLogEN_js_1.clsgs_ReflectLogEN.con_TopicId) == true) {
            const strComparisonOp_TopicId = objgs_ReflectLog_Cond.dicFldComparisonOp[clsgs_ReflectLogEN_js_1.clsgs_ReflectLogEN.con_TopicId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_ReflectLogEN_js_1.clsgs_ReflectLogEN.con_TopicId, objgs_ReflectLog_Cond.topicId, strComparisonOp_TopicId);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_ReflectLog_Cond.dicFldComparisonOp, clsgs_ReflectLogEN_js_1.clsgs_ReflectLogEN.con_ReflectLogName) == true) {
            const strComparisonOp_ReflectLogName = objgs_ReflectLog_Cond.dicFldComparisonOp[clsgs_ReflectLogEN_js_1.clsgs_ReflectLogEN.con_ReflectLogName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_ReflectLogEN_js_1.clsgs_ReflectLogEN.con_ReflectLogName, objgs_ReflectLog_Cond.reflectLogName, strComparisonOp_ReflectLogName);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_ReflectLog_Cond.dicFldComparisonOp, clsgs_ReflectLogEN_js_1.clsgs_ReflectLogEN.con_ReflectLogContent) == true) {
            const strComparisonOp_ReflectLogContent = objgs_ReflectLog_Cond.dicFldComparisonOp[clsgs_ReflectLogEN_js_1.clsgs_ReflectLogEN.con_ReflectLogContent];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_ReflectLogEN_js_1.clsgs_ReflectLogEN.con_ReflectLogContent, objgs_ReflectLog_Cond.reflectLogContent, strComparisonOp_ReflectLogContent);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_ReflectLog_Cond.dicFldComparisonOp, clsgs_ReflectLogEN_js_1.clsgs_ReflectLogEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objgs_ReflectLog_Cond.dicFldComparisonOp[clsgs_ReflectLogEN_js_1.clsgs_ReflectLogEN.con_UpdUser];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_ReflectLogEN_js_1.clsgs_ReflectLogEN.con_UpdUser, objgs_ReflectLog_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_ReflectLog_Cond.dicFldComparisonOp, clsgs_ReflectLogEN_js_1.clsgs_ReflectLogEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objgs_ReflectLog_Cond.dicFldComparisonOp[clsgs_ReflectLogEN_js_1.clsgs_ReflectLogEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_ReflectLogEN_js_1.clsgs_ReflectLogEN.con_UpdDate, objgs_ReflectLog_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_ReflectLog_Cond.dicFldComparisonOp, clsgs_ReflectLogEN_js_1.clsgs_ReflectLogEN.con_Memo) == true) {
            const strComparisonOp_Memo = objgs_ReflectLog_Cond.dicFldComparisonOp[clsgs_ReflectLogEN_js_1.clsgs_ReflectLogEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_ReflectLogEN_js_1.clsgs_ReflectLogEN.con_Memo, objgs_ReflectLog_Cond.memo, strComparisonOp_Memo);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_ReflectLog_Cond.dicFldComparisonOp, clsgs_ReflectLogEN_js_1.clsgs_ReflectLogEN.con_id_CurrEduCls) == true) {
            const strComparisonOp_id_CurrEduCls = objgs_ReflectLog_Cond.dicFldComparisonOp[clsgs_ReflectLogEN_js_1.clsgs_ReflectLogEN.con_id_CurrEduCls];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_ReflectLogEN_js_1.clsgs_ReflectLogEN.con_id_CurrEduCls, objgs_ReflectLog_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
        }
        return strWhereCond;
    }
    exports.gs_ReflectLog_GetCombineCondition = gs_ReflectLog_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--gs_ReflectLog(反思日志),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param lngmId: mId(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function gs_ReflectLog_GetUniCondStr_mId(objgs_ReflectLogEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and mId = '{0}'", objgs_ReflectLogEN.mId);
        return strWhereCond;
    }
    exports.gs_ReflectLog_GetUniCondStr_mId = gs_ReflectLog_GetUniCondStr_mId;
    /**
    *获取唯一性条件串(Uniqueness)--gs_ReflectLog(反思日志),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param lngmId: mId(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function gs_ReflectLog_GetUniCondStr4Update_mId(objgs_ReflectLogEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and mId <> '{0}'", objgs_ReflectLogEN.mId);
        strWhereCond += (0, clsString_js_1.Format)(" and mId = '{0}'", objgs_ReflectLogEN.mId);
        return strWhereCond;
    }
    exports.gs_ReflectLog_GetUniCondStr4Update_mId = gs_ReflectLog_GetUniCondStr4Update_mId;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objgs_ReflectLogENS:源对象
     * @param objgs_ReflectLogENT:目标对象
    */
    function gs_ReflectLog_CopyObjTo(objgs_ReflectLogENS, objgs_ReflectLogENT) {
        objgs_ReflectLogENT.mId = objgs_ReflectLogENS.mId; //mId
        objgs_ReflectLogENT.topicId = objgs_ReflectLogENS.topicId; //主题Id
        objgs_ReflectLogENT.reflectLogName = objgs_ReflectLogENS.reflectLogName; //标题
        objgs_ReflectLogENT.reflectLogContent = objgs_ReflectLogENS.reflectLogContent; //内容
        objgs_ReflectLogENT.updUser = objgs_ReflectLogENS.updUser; //修改人
        objgs_ReflectLogENT.updDate = objgs_ReflectLogENS.updDate; //修改日期
        objgs_ReflectLogENT.memo = objgs_ReflectLogENS.memo; //备注
        objgs_ReflectLogENT.id_CurrEduCls = objgs_ReflectLogENS.id_CurrEduCls; //教学班流水号
        objgs_ReflectLogENT.sf_UpdFldSetStr = objgs_ReflectLogENS.updFldString; //sf_UpdFldSetStr
    }
    exports.gs_ReflectLog_CopyObjTo = gs_ReflectLog_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objgs_ReflectLogENS:源对象
     * @param objgs_ReflectLogENT:目标对象
    */
    function gs_ReflectLog_GetObjFromJsonObj(objgs_ReflectLogENS) {
        const objgs_ReflectLogENT = new clsgs_ReflectLogEN_js_1.clsgs_ReflectLogEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objgs_ReflectLogENT, objgs_ReflectLogENS);
        return objgs_ReflectLogENT;
    }
    exports.gs_ReflectLog_GetObjFromJsonObj = gs_ReflectLog_GetObjFromJsonObj;
});
