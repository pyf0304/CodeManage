/**
* 类名:clsgs_PaperStatusWApi
* 表名:gs_PaperStatus(01120676)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/13 00:53:12
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
        define(["require", "exports", "axios", "../../PubFun/enumComparisonOp.js", "../../PubFun/CacheHelper.js", "../../L0_Entity/ParameterTable/clsgs_PaperStatusEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.gs_PaperStatus_GetObjFromJsonObj = exports.gs_PaperStatus_CopyObjTo = exports.gs_PaperStatus_GetUniCondStr4Update_PaperStatusId = exports.gs_PaperStatus_GetUniCondStr_PaperStatusId = exports.gs_PaperStatus_GetCombineCondition = exports.gs_PaperStatus_GetObjByJSONStr = exports.gs_PaperStatus_GetObjLstByJSONObjLst = exports.gs_PaperStatus_GetObjLstByJSONStr = exports.gs_PaperStatus_GetJSONStrByObj = exports.gs_PaperStatus_CheckProperty4Update = exports.gs_PaperStatus_CheckPropertyNew = exports.gs_PaperStatus_ReFreshThisCache = exports.gs_PaperStatus_ReFreshCache = exports.gs_PaperStatus_GetWebApiUrl = exports.gs_PaperStatus_GetMaxStrIdByPrefix = exports.gs_PaperStatus_GetMaxStrIdAsync = exports.gs_PaperStatus_GetRecCountByCond_Cache = exports.gs_PaperStatus_GetRecCountByCondAsync = exports.gs_PaperStatus_IsExistAsync = exports.gs_PaperStatus_IsExist_Cache = exports.gs_PaperStatus_IsExist = exports.gs_PaperStatus_IsExistRecordAsync = exports.gs_PaperStatus_IsExistRecord_Cache = exports.gs_PaperStatus_UpdateWithConditionAsync = exports.gs_PaperStatus_UpdateRecordAsync = exports.gs_PaperStatus_AddNewRecordWithReturnKey = exports.gs_PaperStatus_AddNewRecordWithReturnKeyAsync = exports.gs_PaperStatus_AddNewRecordWithMaxIdAsync = exports.gs_PaperStatus_AddNewRecordAsync = exports.gs_PaperStatus_Delgs_PaperStatussByCondAsync = exports.gs_PaperStatus_Delgs_PaperStatussAsync = exports.gs_PaperStatus_DelRecordAsync = exports.gs_PaperStatus_GetObjLstByPagerAsync = exports.gs_PaperStatus_GetObjLstByPager_Cache = exports.gs_PaperStatus_GetObjLstByRange = exports.gs_PaperStatus_GetObjLstByRangeAsync = exports.gs_PaperStatus_GetTopObjLstAsync = exports.gs_PaperStatus_GetObjLstByPaperStatusIdLst_Cache = exports.gs_PaperStatus_GetObjLstByPaperStatusIdLstAsync = exports.gs_PaperStatus_GetSubObjLst_Cache = exports.gs_PaperStatus_GetObjLst_PureCache = exports.gs_PaperStatus_GetObjLst_Cache = exports.gs_PaperStatus_GetObjLst_sessionStorage_PureCache = exports.gs_PaperStatus_GetObjLst_sessionStorage = exports.gs_PaperStatus_GetObjLstAsync = exports.gs_PaperStatus_GetObjLst_localStorage_PureCache = exports.gs_PaperStatus_GetObjLst_localStorage = exports.gs_PaperStatus_GetObjLst_ClientCache = exports.gs_PaperStatus_GetFirstObjAsync = exports.gs_PaperStatus_GetFirstID = exports.gs_PaperStatus_GetFirstIDAsync = exports.gs_PaperStatus_funcKey = exports.gs_PaperStatus_FilterFunByKey = exports.gs_PaperStatus_SortFunByKey = exports.gs_PaperStatus_SortFun_Defa_2Fld = exports.gs_PaperStatus_SortFun_Defa = exports.gs_PaperStatus_func = exports.gs_PaperStatus_UpdateObjInLst_Cache = exports.gs_PaperStatus_GetObjByPaperStatusId_localStorage = exports.gs_PaperStatus_GetObjByPaperStatusId_Cache = exports.gs_PaperStatus_GetObjByPaperStatusIdAsync = exports.gs_PaperStatus_ConstructorName = exports.gs_PaperStatus_Controller = void 0;
    /**
     * 论文状态表(gs_PaperStatus)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月13日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const enumComparisonOp_js_1 = require("../../PubFun/enumComparisonOp.js");
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsgs_PaperStatusEN_js_1 = require("../../L0_Entity/ParameterTable/clsgs_PaperStatusEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsString_js_2 = require("../../PubFun/clsString.js");
    exports.gs_PaperStatus_Controller = "gs_PaperStatusApi";
    exports.gs_PaperStatus_ConstructorName = "gs_PaperStatus";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strPaperStatusId:关键字
    * @returns 对象
    **/
    async function gs_PaperStatus_GetObjByPaperStatusIdAsync(strPaperStatusId) {
        const strThisFuncName = "GetObjByPaperStatusIdAsync";
        if ((0, clsString_js_2.IsNullOrEmpty)(strPaperStatusId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strPaperStatusId]不能为空！(In clsgs_PaperStatusWApi.GetObjByPaperStatusIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strPaperStatusId.length != 2) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strPaperStatusId]的长度:[{0}]不正确！(clsgs_PaperStatusWApi.GetObjByPaperStatusIdAsync)", strPaperStatusId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByPaperStatusId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperStatus_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "strPaperStatusId": strPaperStatusId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    return null;
                }
                //console.log(returnObj);
                const objgs_PaperStatus = gs_PaperStatus_GetObjFromJsonObj(returnObj);
                return objgs_PaperStatus;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperStatus_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperStatus_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperStatus_GetObjByPaperStatusIdAsync = gs_PaperStatus_GetObjByPaperStatusIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param strPaperStatusId:所给的关键字
     * @returns 对象
    */
    async function gs_PaperStatus_GetObjByPaperStatusId_Cache(strPaperStatusId, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByPaperStatusId_Cache";
        if ((0, clsString_js_2.IsNullOrEmpty)(strPaperStatusId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strPaperStatusId]不能为空！(In clsgs_PaperStatusWApi.GetObjByPaperStatusId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strPaperStatusId.length != 2) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strPaperStatusId]的长度:[{0}]不正确！(clsgs_PaperStatusWApi.GetObjByPaperStatusId_Cache)", strPaperStatusId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrgs_PaperStatusObjLst_Cache = await gs_PaperStatus_GetObjLst_Cache();
        try {
            const arrgs_PaperStatus_Sel = arrgs_PaperStatusObjLst_Cache.filter(x => x.paperStatusId == strPaperStatusId);
            let objgs_PaperStatus;
            if (arrgs_PaperStatus_Sel.length > 0) {
                objgs_PaperStatus = arrgs_PaperStatus_Sel[0];
                return objgs_PaperStatus;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    const objgs_PaperStatus_Const = await gs_PaperStatus_GetObjByPaperStatusIdAsync(strPaperStatusId);
                    if (objgs_PaperStatus_Const != null) {
                        gs_PaperStatus_ReFreshThisCache();
                        return objgs_PaperStatus_Const;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strPaperStatusId, exports.gs_PaperStatus_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.gs_PaperStatus_GetObjByPaperStatusId_Cache = gs_PaperStatus_GetObjByPaperStatusId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param strPaperStatusId:所给的关键字
     * @returns 对象
    */
    async function gs_PaperStatus_GetObjByPaperStatusId_localStorage(strPaperStatusId) {
        const strThisFuncName = "GetObjByPaperStatusId_localStorage";
        if ((0, clsString_js_2.IsNullOrEmpty)(strPaperStatusId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strPaperStatusId]不能为空！(In clsgs_PaperStatusWApi.GetObjByPaperStatusId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strPaperStatusId.length != 2) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strPaperStatusId]的长度:[{0}]不正确！(clsgs_PaperStatusWApi.GetObjByPaperStatusId_localStorage)", strPaperStatusId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsgs_PaperStatusEN_js_1.clsgs_PaperStatusEN._CurrTabName, strPaperStatusId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objgs_PaperStatus_Cache = JSON.parse(strTempObj);
            return objgs_PaperStatus_Cache;
        }
        try {
            const objgs_PaperStatus = await gs_PaperStatus_GetObjByPaperStatusIdAsync(strPaperStatusId);
            if (objgs_PaperStatus != null) {
                localStorage.setItem(strKey, JSON.stringify(objgs_PaperStatus));
                const strInfo = (0, clsString_js_2.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objgs_PaperStatus;
            }
            return objgs_PaperStatus;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strPaperStatusId, exports.gs_PaperStatus_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.gs_PaperStatus_GetObjByPaperStatusId_localStorage = gs_PaperStatus_GetObjByPaperStatusId_localStorage;
    /**
     * 修改在缓存对象列表中的对象, 与后台数据库无关.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
     * @param objgs_PaperStatus:所给的对象
     * @returns 对象
    */
    async function gs_PaperStatus_UpdateObjInLst_Cache(objgs_PaperStatus) {
        const strThisFuncName = "UpdateObjInLst_Cache";
        try {
            const arrgs_PaperStatusObjLst_Cache = await gs_PaperStatus_GetObjLst_Cache();
            const obj = arrgs_PaperStatusObjLst_Cache.find(x => x.paperStatusId == objgs_PaperStatus.paperStatusId);
            if (obj != null) {
                objgs_PaperStatus.paperStatusId = obj.paperStatusId;
                (0, clsCommFunc4Web_js_1.ObjectAssign)(obj, objgs_PaperStatus);
            }
            else {
                arrgs_PaperStatusObjLst_Cache.push(objgs_PaperStatus);
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, exports.gs_PaperStatus_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.gs_PaperStatus_UpdateObjInLst_Cache = gs_PaperStatus_UpdateObjInLst_Cache;
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
    async function gs_PaperStatus_func(strInFldName, strOutFldName, strInValue) {
        //const strThisFuncName = "func";
        if (strInFldName != clsgs_PaperStatusEN_js_1.clsgs_PaperStatusEN.con_PaperStatusId) {
            const strMsg = (0, clsString_js_2.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsgs_PaperStatusEN_js_1.clsgs_PaperStatusEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_2.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strOutFldName, clsgs_PaperStatusEN_js_1.clsgs_PaperStatusEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strPaperStatusId = strInValue;
        if ((0, clsString_js_2.IsNullOrEmpty)(strInValue) == true) {
            return "";
        }
        const objgs_PaperStatus = await gs_PaperStatus_GetObjByPaperStatusId_Cache(strPaperStatusId);
        if (objgs_PaperStatus == null)
            return "";
        if (objgs_PaperStatus.GetFldValue(strOutFldName) == null)
            return "";
        return objgs_PaperStatus.GetFldValue(strOutFldName).toString();
    }
    exports.gs_PaperStatus_func = gs_PaperStatus_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function gs_PaperStatus_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.paperStatusId.localeCompare(b.paperStatusId);
    }
    exports.gs_PaperStatus_SortFun_Defa = gs_PaperStatus_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function gs_PaperStatus_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.paperStatusName == b.paperStatusName)
            return a.updUser.localeCompare(b.updUser);
        else
            return a.paperStatusName.localeCompare(b.paperStatusName);
    }
    exports.gs_PaperStatus_SortFun_Defa_2Fld = gs_PaperStatus_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function gs_PaperStatus_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsgs_PaperStatusEN_js_1.clsgs_PaperStatusEN.con_PaperStatusId:
                    return (a, b) => {
                        return a.paperStatusId.localeCompare(b.paperStatusId);
                    };
                case clsgs_PaperStatusEN_js_1.clsgs_PaperStatusEN.con_PaperStatusName:
                    return (a, b) => {
                        if (a.paperStatusName == null)
                            return -1;
                        if (b.paperStatusName == null)
                            return 1;
                        return a.paperStatusName.localeCompare(b.paperStatusName);
                    };
                case clsgs_PaperStatusEN_js_1.clsgs_PaperStatusEN.con_UpdUser:
                    return (a, b) => {
                        if (a.updUser == null)
                            return -1;
                        if (b.updUser == null)
                            return 1;
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsgs_PaperStatusEN_js_1.clsgs_PaperStatusEN.con_UpdDate:
                    return (a, b) => {
                        if (a.updDate == null)
                            return -1;
                        if (b.updDate == null)
                            return 1;
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsgs_PaperStatusEN_js_1.clsgs_PaperStatusEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[gs_PaperStatus]中不存在！(in ${exports.gs_PaperStatus_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsgs_PaperStatusEN_js_1.clsgs_PaperStatusEN.con_PaperStatusId:
                    return (a, b) => {
                        return b.paperStatusId.localeCompare(a.paperStatusId);
                    };
                case clsgs_PaperStatusEN_js_1.clsgs_PaperStatusEN.con_PaperStatusName:
                    return (a, b) => {
                        if (b.paperStatusName == null)
                            return -1;
                        if (a.paperStatusName == null)
                            return 1;
                        return b.paperStatusName.localeCompare(a.paperStatusName);
                    };
                case clsgs_PaperStatusEN_js_1.clsgs_PaperStatusEN.con_UpdUser:
                    return (a, b) => {
                        if (b.updUser == null)
                            return -1;
                        if (a.updUser == null)
                            return 1;
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsgs_PaperStatusEN_js_1.clsgs_PaperStatusEN.con_UpdDate:
                    return (a, b) => {
                        if (b.updDate == null)
                            return -1;
                        if (a.updDate == null)
                            return 1;
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsgs_PaperStatusEN_js_1.clsgs_PaperStatusEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[gs_PaperStatus]中不存在！(in ${exports.gs_PaperStatus_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.gs_PaperStatus_SortFunByKey = gs_PaperStatus_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function gs_PaperStatus_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsgs_PaperStatusEN_js_1.clsgs_PaperStatusEN.con_PaperStatusId:
                return (obj) => {
                    return obj.paperStatusId === value;
                };
            case clsgs_PaperStatusEN_js_1.clsgs_PaperStatusEN.con_PaperStatusName:
                return (obj) => {
                    return obj.paperStatusName === value;
                };
            case clsgs_PaperStatusEN_js_1.clsgs_PaperStatusEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsgs_PaperStatusEN_js_1.clsgs_PaperStatusEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsgs_PaperStatusEN_js_1.clsgs_PaperStatusEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[gs_PaperStatus]中不存在！(in ${exports.gs_PaperStatus_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.gs_PaperStatus_FilterFunByKey = gs_PaperStatus_FilterFunByKey;
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
    async function gs_PaperStatus_funcKey(strInFldName, strInValue, strComparisonOp) {
        //const strThisFuncName = "funcKey";
        if (strInFldName == clsgs_PaperStatusEN_js_1.clsgs_PaperStatusEN.con_PaperStatusId) {
            const strMsg = (0, clsString_js_2.Format)("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(strInValue) == true) {
            return [];
        }
        const arrgs_PaperStatus = await gs_PaperStatus_GetObjLst_Cache();
        if (arrgs_PaperStatus == null)
            return [];
        let arrgs_PaperStatus_Sel = arrgs_PaperStatus;
        const strType = typeof (strInValue);
        switch (strType) {
            case "string":
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01: // " = "
                        arrgs_PaperStatus_Sel = arrgs_PaperStatus_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.Like_03:
                        arrgs_PaperStatus_Sel = arrgs_PaperStatus_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.In_04:
                        const arrValues = strInValue.split(',');
                        arrgs_PaperStatus_Sel = arrgs_PaperStatus_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
                        break;
                }
                break;
            case "boolean":
                if (strInValue == null)
                    return [];
                if (strComparisonOp == enumComparisonOp_js_1.enumComparisonOp.Equal_01) {
                    arrgs_PaperStatus_Sel = arrgs_PaperStatus_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                }
                break;
            case "number":
                if (Number(strInValue) == 0)
                    return [];
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01:
                        arrgs_PaperStatus_Sel = arrgs_PaperStatus_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotEqual_02:
                        arrgs_PaperStatus_Sel = arrgs_PaperStatus_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotLessThan_05: //" >= ":
                        arrgs_PaperStatus_Sel = arrgs_PaperStatus_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotGreaterThan_06: //" <= ":
                        arrgs_PaperStatus_Sel = arrgs_PaperStatus_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.GreaterThan_07: //" > ":
                        arrgs_PaperStatus_Sel = arrgs_PaperStatus_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.LessThan_08: //" < ":
                        arrgs_PaperStatus_Sel = arrgs_PaperStatus_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                }
                break;
        }
        if (arrgs_PaperStatus_Sel.length == 0)
            return [];
        return arrgs_PaperStatus_Sel.map(x => x.paperStatusId);
    }
    exports.gs_PaperStatus_funcKey = gs_PaperStatus_funcKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function gs_PaperStatus_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperStatus_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperStatus_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperStatus_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperStatus_GetFirstIDAsync = gs_PaperStatus_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function gs_PaperStatus_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperStatus_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperStatus_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperStatus_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperStatus_GetFirstID = gs_PaperStatus_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function gs_PaperStatus_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperStatus_Controller, strAction);
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
                const objgs_PaperStatus = gs_PaperStatus_GetObjFromJsonObj(returnObj);
                return objgs_PaperStatus;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperStatus_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperStatus_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperStatus_GetFirstObjAsync = gs_PaperStatus_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_PaperStatus_GetObjLst_ClientCache() {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsgs_PaperStatusEN_js_1.clsgs_PaperStatusEN._CurrTabName;
        if ((0, clsString_js_2.IsNullOrEmpty)(clsgs_PaperStatusEN_js_1.clsgs_PaperStatusEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsgs_PaperStatusEN_js_1.clsgs_PaperStatusEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_1.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrgs_PaperStatusExObjLst_Cache = CacheHelper_js_1.CacheHelper.Get(strKey);
            const arrgs_PaperStatusObjLst_T = gs_PaperStatus_GetObjLstByJSONObjLst(arrgs_PaperStatusExObjLst_Cache);
            return arrgs_PaperStatusObjLst_T;
        }
        try {
            const arrgs_PaperStatusExObjLst = await gs_PaperStatus_GetObjLstAsync(strWhereCond);
            CacheHelper_js_1.CacheHelper.Add(strKey, arrgs_PaperStatusExObjLst);
            const strInfo = (0, clsString_js_2.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_PaperStatusExObjLst.length);
            console.log(strInfo);
            return arrgs_PaperStatusExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.gs_PaperStatus_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.gs_PaperStatus_GetObjLst_ClientCache = gs_PaperStatus_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_PaperStatus_GetObjLst_localStorage() {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsgs_PaperStatusEN_js_1.clsgs_PaperStatusEN._CurrTabName;
        if ((0, clsString_js_2.IsNullOrEmpty)(clsgs_PaperStatusEN_js_1.clsgs_PaperStatusEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsgs_PaperStatusEN_js_1.clsgs_PaperStatusEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrgs_PaperStatusExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrgs_PaperStatusObjLst_T = gs_PaperStatus_GetObjLstByJSONObjLst(arrgs_PaperStatusExObjLst_Cache);
            return arrgs_PaperStatusObjLst_T;
        }
        try {
            const arrgs_PaperStatusExObjLst = await gs_PaperStatus_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrgs_PaperStatusExObjLst));
            const strInfo = (0, clsString_js_2.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_PaperStatusExObjLst.length);
            console.log(strInfo);
            return arrgs_PaperStatusExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.gs_PaperStatus_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.gs_PaperStatus_GetObjLst_localStorage = gs_PaperStatus_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_PaperStatus_GetObjLst_localStorage_PureCache() {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsgs_PaperStatusEN_js_1.clsgs_PaperStatusEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrgs_PaperStatusObjLst_Cache = JSON.parse(strTempObjLst);
            return arrgs_PaperStatusObjLst_Cache;
        }
        else
            return null;
    }
    exports.gs_PaperStatus_GetObjLst_localStorage_PureCache = gs_PaperStatus_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function gs_PaperStatus_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperStatus_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_PaperStatus_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_PaperStatus_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperStatus_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperStatus_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperStatus_GetObjLstAsync = gs_PaperStatus_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_PaperStatus_GetObjLst_sessionStorage() {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsgs_PaperStatusEN_js_1.clsgs_PaperStatusEN._CurrTabName;
        if ((0, clsString_js_2.IsNullOrEmpty)(clsgs_PaperStatusEN_js_1.clsgs_PaperStatusEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsgs_PaperStatusEN_js_1.clsgs_PaperStatusEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrgs_PaperStatusExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrgs_PaperStatusObjLst_T = gs_PaperStatus_GetObjLstByJSONObjLst(arrgs_PaperStatusExObjLst_Cache);
            return arrgs_PaperStatusObjLst_T;
        }
        try {
            const arrgs_PaperStatusExObjLst = await gs_PaperStatus_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrgs_PaperStatusExObjLst));
            const strInfo = (0, clsString_js_2.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_PaperStatusExObjLst.length);
            console.log(strInfo);
            return arrgs_PaperStatusExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.gs_PaperStatus_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.gs_PaperStatus_GetObjLst_sessionStorage = gs_PaperStatus_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_PaperStatus_GetObjLst_sessionStorage_PureCache() {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsgs_PaperStatusEN_js_1.clsgs_PaperStatusEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrgs_PaperStatusObjLst_Cache = JSON.parse(strTempObjLst);
            return arrgs_PaperStatusObjLst_Cache;
        }
        else
            return null;
    }
    exports.gs_PaperStatus_GetObjLst_sessionStorage_PureCache = gs_PaperStatus_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_PaperStatus_GetObjLst_Cache() {
        //const strThisFuncName = "GetObjLst_Cache";
        let arrgs_PaperStatusObjLst_Cache;
        switch (clsgs_PaperStatusEN_js_1.clsgs_PaperStatusEN.CacheModeId) {
            case "04": //sessionStorage
                arrgs_PaperStatusObjLst_Cache = await gs_PaperStatus_GetObjLst_sessionStorage();
                break;
            case "03": //localStorage
                arrgs_PaperStatusObjLst_Cache = await gs_PaperStatus_GetObjLst_localStorage();
                break;
            case "02": //ClientCache
                arrgs_PaperStatusObjLst_Cache = await gs_PaperStatus_GetObjLst_ClientCache();
                break;
            default:
                arrgs_PaperStatusObjLst_Cache = await gs_PaperStatus_GetObjLst_ClientCache();
                break;
        }
        const arrgs_PaperStatusObjLst = gs_PaperStatus_GetObjLstByJSONObjLst(arrgs_PaperStatusObjLst_Cache);
        return arrgs_PaperStatusObjLst_Cache;
    }
    exports.gs_PaperStatus_GetObjLst_Cache = gs_PaperStatus_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_PaperStatus_GetObjLst_PureCache() {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrgs_PaperStatusObjLst_Cache;
        switch (clsgs_PaperStatusEN_js_1.clsgs_PaperStatusEN.CacheModeId) {
            case "04": //sessionStorage
                arrgs_PaperStatusObjLst_Cache = await gs_PaperStatus_GetObjLst_sessionStorage_PureCache();
                break;
            case "03": //localStorage
                arrgs_PaperStatusObjLst_Cache = await gs_PaperStatus_GetObjLst_localStorage_PureCache();
                break;
            case "02": //ClientCache
                arrgs_PaperStatusObjLst_Cache = null;
                break;
            default:
                arrgs_PaperStatusObjLst_Cache = null;
                break;
        }
        return arrgs_PaperStatusObjLst_Cache;
    }
    exports.gs_PaperStatus_GetObjLst_PureCache = gs_PaperStatus_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objstrPaperStatusId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function gs_PaperStatus_GetSubObjLst_Cache(objgs_PaperStatus_Cond) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrgs_PaperStatusObjLst_Cache = await gs_PaperStatus_GetObjLst_Cache();
        let arrgs_PaperStatus_Sel = arrgs_PaperStatusObjLst_Cache;
        if (objgs_PaperStatus_Cond.sf_FldComparisonOp == null || objgs_PaperStatus_Cond.sf_FldComparisonOp == "")
            return arrgs_PaperStatus_Sel;
        const dicFldComparisonOp = JSON.parse(objgs_PaperStatus_Cond.sf_FldComparisonOp);
        //console.log("clsgs_PaperStatusWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objgs_PaperStatus_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrgs_PaperStatus_Sel = arrgs_PaperStatus_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objgs_PaperStatus_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_PaperStatus_Sel = arrgs_PaperStatus_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrgs_PaperStatus_Sel = arrgs_PaperStatus_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrgs_PaperStatus_Sel = arrgs_PaperStatus_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrgs_PaperStatus_Sel = arrgs_PaperStatus_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrgs_PaperStatus_Sel = arrgs_PaperStatus_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrgs_PaperStatus_Sel = arrgs_PaperStatus_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrgs_PaperStatus_Sel = arrgs_PaperStatus_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_PaperStatus_Sel = arrgs_PaperStatus_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_PaperStatus_Sel = arrgs_PaperStatus_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrgs_PaperStatus_Sel = arrgs_PaperStatus_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrgs_PaperStatus_Sel = arrgs_PaperStatus_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrgs_PaperStatus_Sel = arrgs_PaperStatus_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrgs_PaperStatus_Sel = arrgs_PaperStatus_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrgs_PaperStatus_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objgs_PaperStatus_Cond), exports.gs_PaperStatus_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.gs_PaperStatus_GetSubObjLst_Cache = gs_PaperStatus_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrPaperStatusId:关键字列表
    * @returns 对象列表
    **/
    async function gs_PaperStatus_GetObjLstByPaperStatusIdLstAsync(arrPaperStatusId) {
        const strThisFuncName = "GetObjLstByPaperStatusIdLstAsync";
        const strAction = "GetObjLstByPaperStatusIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperStatus_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrPaperStatusId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_PaperStatus_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_PaperStatus_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperStatus_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperStatus_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperStatus_GetObjLstByPaperStatusIdLstAsync = gs_PaperStatus_GetObjLstByPaperStatusIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrstrPaperStatusIdLst:关键字列表
     * @returns 对象列表
    */
    async function gs_PaperStatus_GetObjLstByPaperStatusIdLst_Cache(arrPaperStatusIdLst) {
        const strThisFuncName = "GetObjLstByPaperStatusIdLst_Cache";
        try {
            const arrgs_PaperStatusObjLst_Cache = await gs_PaperStatus_GetObjLst_Cache();
            const arrgs_PaperStatus_Sel = arrgs_PaperStatusObjLst_Cache.filter(x => arrPaperStatusIdLst.indexOf(x.paperStatusId) > -1);
            return arrgs_PaperStatus_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrPaperStatusIdLst.join(","), exports.gs_PaperStatus_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
    }
    exports.gs_PaperStatus_GetObjLstByPaperStatusIdLst_Cache = gs_PaperStatus_GetObjLstByPaperStatusIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function gs_PaperStatus_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperStatus_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_PaperStatus_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_PaperStatus_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperStatus_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperStatus_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperStatus_GetTopObjLstAsync = gs_PaperStatus_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function gs_PaperStatus_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperStatus_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_PaperStatus_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_PaperStatus_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperStatus_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperStatus_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperStatus_GetObjLstByRangeAsync = gs_PaperStatus_GetObjLstByRangeAsync;
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
    async function gs_PaperStatus_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperStatus_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperStatus_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperStatus_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperStatus_GetObjLstByRange = gs_PaperStatus_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function gs_PaperStatus_GetObjLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const arrgs_PaperStatusObjLst_Cache = await gs_PaperStatus_GetObjLst_Cache();
        if (arrgs_PaperStatusObjLst_Cache.length == 0)
            return arrgs_PaperStatusObjLst_Cache;
        let arrgs_PaperStatus_Sel = arrgs_PaperStatusObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objgs_PaperStatus_Cond = new clsgs_PaperStatusEN_js_1.clsgs_PaperStatusEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objgs_PaperStatus_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsgs_PaperStatusWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrgs_PaperStatus_Sel = arrgs_PaperStatus_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objgs_PaperStatus_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_PaperStatus_Sel = arrgs_PaperStatus_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrgs_PaperStatus_Sel = arrgs_PaperStatus_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrgs_PaperStatus_Sel = arrgs_PaperStatus_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrgs_PaperStatus_Sel = arrgs_PaperStatus_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrgs_PaperStatus_Sel = arrgs_PaperStatus_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrgs_PaperStatus_Sel = arrgs_PaperStatus_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrgs_PaperStatus_Sel = arrgs_PaperStatus_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrgs_PaperStatus_Sel = arrgs_PaperStatus_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_PaperStatus_Sel = arrgs_PaperStatus_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_PaperStatus_Sel = arrgs_PaperStatus_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrgs_PaperStatus_Sel = arrgs_PaperStatus_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrgs_PaperStatus_Sel = arrgs_PaperStatus_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrgs_PaperStatus_Sel = arrgs_PaperStatus_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrgs_PaperStatus_Sel = arrgs_PaperStatus_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrgs_PaperStatus_Sel.length == 0)
                return arrgs_PaperStatus_Sel;
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
                arrgs_PaperStatus_Sel = arrgs_PaperStatus_Sel.sort(gs_PaperStatus_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrgs_PaperStatus_Sel = arrgs_PaperStatus_Sel.sort(objPagerPara.sortFun);
            }
            arrgs_PaperStatus_Sel = arrgs_PaperStatus_Sel.slice(intStart, intEnd);
            return arrgs_PaperStatus_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.gs_PaperStatus_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.gs_PaperStatus_GetObjLstByPager_Cache = gs_PaperStatus_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function gs_PaperStatus_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperStatus_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_PaperStatus_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_PaperStatus_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperStatus_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperStatus_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperStatus_GetObjLstByPagerAsync = gs_PaperStatus_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param strPaperStatusId:关键字
    * @returns 获取删除的结果
    **/
    async function gs_PaperStatus_DelRecordAsync(strPaperStatusId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperStatus_Controller, strAction);
        strUrl = (0, clsString_js_2.Format)("{0}/?Id={1}", strUrl, strPaperStatusId);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperStatus_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperStatus_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperStatus_DelRecordAsync = gs_PaperStatus_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrPaperStatusId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function gs_PaperStatus_Delgs_PaperStatussAsync(arrPaperStatusId) {
        const strThisFuncName = "Delgs_PaperStatussAsync";
        const strAction = "Delgs_PaperStatuss";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperStatus_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrPaperStatusId);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperStatus_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperStatus_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperStatus_Delgs_PaperStatussAsync = gs_PaperStatus_Delgs_PaperStatussAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function gs_PaperStatus_Delgs_PaperStatussByCondAsync(strWhereCond) {
        const strThisFuncName = "Delgs_PaperStatussByCondAsync";
        const strAction = "Delgs_PaperStatussByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperStatus_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperStatus_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperStatus_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperStatus_Delgs_PaperStatussByCondAsync = gs_PaperStatus_Delgs_PaperStatussByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objgs_PaperStatusEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function gs_PaperStatus_AddNewRecordAsync(objgs_PaperStatusEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objgs_PaperStatusEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperStatus_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_PaperStatusEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperStatus_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperStatus_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperStatus_AddNewRecordAsync = gs_PaperStatus_AddNewRecordAsync;
    /**
    * 调用WebApi来添加记录，关键字用最大关键字，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithMaxIdAsync)
    * @param objgs_PaperStatusEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function gs_PaperStatus_AddNewRecordWithMaxIdAsync(objgs_PaperStatusEN) {
        const strThisFuncName = "AddNewRecordWithMaxIdAsync";
        const strAction = "AddNewRecordWithMaxId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperStatus_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_PaperStatusEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperStatus_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperStatus_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperStatus_AddNewRecordWithMaxIdAsync = gs_PaperStatus_AddNewRecordWithMaxIdAsync;
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objgs_PaperStatusEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function gs_PaperStatus_AddNewRecordWithReturnKeyAsync(objgs_PaperStatusEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperStatus_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_PaperStatusEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperStatus_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperStatus_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperStatus_AddNewRecordWithReturnKeyAsync = gs_PaperStatus_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objgs_PaperStatusEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function gs_PaperStatus_AddNewRecordWithReturnKey(objgs_PaperStatusEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objgs_PaperStatusEN.paperStatusId === null || objgs_PaperStatusEN.paperStatusId === "") {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperStatus_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_PaperStatusEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperStatus_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperStatus_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperStatus_AddNewRecordWithReturnKey = gs_PaperStatus_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objgs_PaperStatusEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function gs_PaperStatus_UpdateRecordAsync(objgs_PaperStatusEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objgs_PaperStatusEN.sf_UpdFldSetStr === undefined || objgs_PaperStatusEN.sf_UpdFldSetStr === null || objgs_PaperStatusEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_PaperStatusEN.paperStatusId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperStatus_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_PaperStatusEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperStatus_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperStatus_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperStatus_UpdateRecordAsync = gs_PaperStatus_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objgs_PaperStatusEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function gs_PaperStatus_UpdateWithConditionAsync(objgs_PaperStatusEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objgs_PaperStatusEN.sf_UpdFldSetStr === undefined || objgs_PaperStatusEN.sf_UpdFldSetStr === null || objgs_PaperStatusEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_PaperStatusEN.paperStatusId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperStatus_Controller, strAction);
        objgs_PaperStatusEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objgs_PaperStatusEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperStatus_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperStatus_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperStatus_UpdateWithConditionAsync = gs_PaperStatus_UpdateWithConditionAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objstrPaperStatusId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function gs_PaperStatus_IsExistRecord_Cache(objgs_PaperStatus_Cond) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrgs_PaperStatusObjLst_Cache = await gs_PaperStatus_GetObjLst_Cache();
        if (arrgs_PaperStatusObjLst_Cache == null)
            return false;
        let arrgs_PaperStatus_Sel = arrgs_PaperStatusObjLst_Cache;
        if (objgs_PaperStatus_Cond.sf_FldComparisonOp == null || objgs_PaperStatus_Cond.sf_FldComparisonOp == "")
            return arrgs_PaperStatus_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objgs_PaperStatus_Cond.sf_FldComparisonOp);
        //console.log("clsgs_PaperStatusWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objgs_PaperStatus_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objgs_PaperStatus_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_PaperStatus_Sel = arrgs_PaperStatus_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrgs_PaperStatus_Sel = arrgs_PaperStatus_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrgs_PaperStatus_Sel = arrgs_PaperStatus_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrgs_PaperStatus_Sel = arrgs_PaperStatus_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrgs_PaperStatus_Sel = arrgs_PaperStatus_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrgs_PaperStatus_Sel = arrgs_PaperStatus_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrgs_PaperStatus_Sel = arrgs_PaperStatus_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_PaperStatus_Sel = arrgs_PaperStatus_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_PaperStatus_Sel = arrgs_PaperStatus_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrgs_PaperStatus_Sel = arrgs_PaperStatus_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrgs_PaperStatus_Sel = arrgs_PaperStatus_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrgs_PaperStatus_Sel = arrgs_PaperStatus_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrgs_PaperStatus_Sel = arrgs_PaperStatus_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrgs_PaperStatus_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objgs_PaperStatus_Cond), exports.gs_PaperStatus_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.gs_PaperStatus_IsExistRecord_Cache = gs_PaperStatus_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function gs_PaperStatus_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperStatus_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperStatus_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperStatus_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperStatus_IsExistRecordAsync = gs_PaperStatus_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strPaperStatusId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function gs_PaperStatus_IsExist(strPaperStatusId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperStatus_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "PaperStatusId": strPaperStatusId,
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperStatus_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperStatus_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperStatus_IsExist = gs_PaperStatus_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param strPaperStatusId:所给的关键字
     * @returns 对象
    */
    async function gs_PaperStatus_IsExist_Cache(strPaperStatusId) {
        const strThisFuncName = "IsExist_Cache";
        const arrgs_PaperStatusObjLst_Cache = await gs_PaperStatus_GetObjLst_Cache();
        if (arrgs_PaperStatusObjLst_Cache == null)
            return false;
        try {
            const arrgs_PaperStatus_Sel = arrgs_PaperStatusObjLst_Cache.filter(x => x.paperStatusId == strPaperStatusId);
            if (arrgs_PaperStatus_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strPaperStatusId, exports.gs_PaperStatus_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.gs_PaperStatus_IsExist_Cache = gs_PaperStatus_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strPaperStatusId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function gs_PaperStatus_IsExistAsync(strPaperStatusId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperStatus_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strPaperStatusId": strPaperStatusId }
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperStatus_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperStatus_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperStatus_IsExistAsync = gs_PaperStatus_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function gs_PaperStatus_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperStatus_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperStatus_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperStatus_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperStatus_GetRecCountByCondAsync = gs_PaperStatus_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objgs_PaperStatus_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function gs_PaperStatus_GetRecCountByCond_Cache(objgs_PaperStatus_Cond) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrgs_PaperStatusObjLst_Cache = await gs_PaperStatus_GetObjLst_Cache();
        if (arrgs_PaperStatusObjLst_Cache == null)
            return 0;
        let arrgs_PaperStatus_Sel = arrgs_PaperStatusObjLst_Cache;
        if (objgs_PaperStatus_Cond.sf_FldComparisonOp == null || objgs_PaperStatus_Cond.sf_FldComparisonOp == "")
            return arrgs_PaperStatus_Sel.length;
        const dicFldComparisonOp = JSON.parse(objgs_PaperStatus_Cond.sf_FldComparisonOp);
        //console.log("clsgs_PaperStatusWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objgs_PaperStatus_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrgs_PaperStatus_Sel = arrgs_PaperStatus_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objgs_PaperStatus_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_PaperStatus_Sel = arrgs_PaperStatus_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrgs_PaperStatus_Sel = arrgs_PaperStatus_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrgs_PaperStatus_Sel = arrgs_PaperStatus_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrgs_PaperStatus_Sel = arrgs_PaperStatus_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrgs_PaperStatus_Sel = arrgs_PaperStatus_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrgs_PaperStatus_Sel = arrgs_PaperStatus_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrgs_PaperStatus_Sel = arrgs_PaperStatus_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrgs_PaperStatus_Sel = arrgs_PaperStatus_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_PaperStatus_Sel = arrgs_PaperStatus_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_PaperStatus_Sel = arrgs_PaperStatus_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrgs_PaperStatus_Sel = arrgs_PaperStatus_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrgs_PaperStatus_Sel = arrgs_PaperStatus_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrgs_PaperStatus_Sel = arrgs_PaperStatus_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrgs_PaperStatus_Sel = arrgs_PaperStatus_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrgs_PaperStatus_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objgs_PaperStatus_Cond), exports.gs_PaperStatus_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.gs_PaperStatus_GetRecCountByCond_Cache = gs_PaperStatus_GetRecCountByCond_Cache;
    /**
    * 获取表的最大关键字
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdAsync)
    * @returns 获取表的最大关键字
    **/
    async function gs_PaperStatus_GetMaxStrIdAsync() {
        const strThisFuncName = "GetMaxStrIdAsync";
        const strAction = "GetMaxStrId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperStatus_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperStatus_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperStatus_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperStatus_GetMaxStrIdAsync = gs_PaperStatus_GetMaxStrIdAsync;
    /*该表的关键字类型不是字符型带前缀自增，不需要生成获取最大关键字函数！*/
    /**
     * 根据前缀获取当前表关键字值的最大值,再加1,避免重复
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdByPrefix)
     * @param mapParam:参数列表
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 获取当前表关键字值的最大值
    */
    async function gs_PaperStatus_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperStatus_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperStatus_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperStatus_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperStatus_GetMaxStrIdByPrefix = gs_PaperStatus_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function gs_PaperStatus_GetWebApiUrl(strController, strAction) {
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
    exports.gs_PaperStatus_GetWebApiUrl = gs_PaperStatus_GetWebApiUrl;
    /**
    * 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshCache)
    **/
    function gs_PaperStatus_ReFreshCache() {
        const strThisFuncName = "ReFreshCache";
        const strMsg = (0, clsString_js_2.Format)("刷新缓存成功！");
        console.trace(strMsg);
        // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
        const strKey = clsgs_PaperStatusEN_js_1.clsgs_PaperStatusEN._CurrTabName;
        switch (clsgs_PaperStatusEN_js_1.clsgs_PaperStatusEN.CacheModeId) {
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
    }
    exports.gs_PaperStatus_ReFreshCache = gs_PaperStatus_ReFreshCache;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function gs_PaperStatus_ReFreshThisCache() {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = clsgs_PaperStatusEN_js_1.clsgs_PaperStatusEN._CurrTabName;
            switch (clsgs_PaperStatusEN_js_1.clsgs_PaperStatusEN.CacheModeId) {
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
    exports.gs_PaperStatus_ReFreshThisCache = gs_PaperStatus_ReFreshThisCache;
    /* 该表的下拉框功能没有设置，不需要生成下拉框绑定函数。*/
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function gs_PaperStatus_CheckPropertyNew(pobjgs_PaperStatusEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperStatusEN.paperStatusId) == false && (0, clsString_js_2.GetStrLen)(pobjgs_PaperStatusEN.paperStatusId) > 2) {
            throw new Error("(errid:Watl000059)字段[论文状态Id(paperStatusId)]的长度不能超过2(In 论文状态表(gs_PaperStatus))!值:$(pobjgs_PaperStatusEN.paperStatusId)(clsgs_PaperStatusBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperStatusEN.paperStatusName) == false && (0, clsString_js_2.GetStrLen)(pobjgs_PaperStatusEN.paperStatusName) > 50) {
            throw new Error("(errid:Watl000059)字段[论文状态名(paperStatusName)]的长度不能超过50(In 论文状态表(gs_PaperStatus))!值:$(pobjgs_PaperStatusEN.paperStatusName)(clsgs_PaperStatusBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperStatusEN.updUser) == false && (0, clsString_js_2.GetStrLen)(pobjgs_PaperStatusEN.updUser) > 20) {
            throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 论文状态表(gs_PaperStatus))!值:$(pobjgs_PaperStatusEN.updUser)(clsgs_PaperStatusBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperStatusEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjgs_PaperStatusEN.updDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 论文状态表(gs_PaperStatus))!值:$(pobjgs_PaperStatusEN.updDate)(clsgs_PaperStatusBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperStatusEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjgs_PaperStatusEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 论文状态表(gs_PaperStatus))!值:$(pobjgs_PaperStatusEN.memo)(clsgs_PaperStatusBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperStatusEN.paperStatusId) == false && undefined !== pobjgs_PaperStatusEN.paperStatusId && clsString_js_1.tzDataType.isString(pobjgs_PaperStatusEN.paperStatusId) === false) {
            throw new Error("(errid:Watl000060)字段[论文状态Id(paperStatusId)]的值:[$(pobjgs_PaperStatusEN.paperStatusId)], 非法，应该为字符型(In 论文状态表(gs_PaperStatus))!(clsgs_PaperStatusBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperStatusEN.paperStatusName) == false && undefined !== pobjgs_PaperStatusEN.paperStatusName && clsString_js_1.tzDataType.isString(pobjgs_PaperStatusEN.paperStatusName) === false) {
            throw new Error("(errid:Watl000060)字段[论文状态名(paperStatusName)]的值:[$(pobjgs_PaperStatusEN.paperStatusName)], 非法，应该为字符型(In 论文状态表(gs_PaperStatus))!(clsgs_PaperStatusBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperStatusEN.updUser) == false && undefined !== pobjgs_PaperStatusEN.updUser && clsString_js_1.tzDataType.isString(pobjgs_PaperStatusEN.updUser) === false) {
            throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjgs_PaperStatusEN.updUser)], 非法，应该为字符型(In 论文状态表(gs_PaperStatus))!(clsgs_PaperStatusBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperStatusEN.updDate) == false && undefined !== pobjgs_PaperStatusEN.updDate && clsString_js_1.tzDataType.isString(pobjgs_PaperStatusEN.updDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjgs_PaperStatusEN.updDate)], 非法，应该为字符型(In 论文状态表(gs_PaperStatus))!(clsgs_PaperStatusBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperStatusEN.memo) == false && undefined !== pobjgs_PaperStatusEN.memo && clsString_js_1.tzDataType.isString(pobjgs_PaperStatusEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjgs_PaperStatusEN.memo)], 非法，应该为字符型(In 论文状态表(gs_PaperStatus))!(clsgs_PaperStatusBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjgs_PaperStatusEN.SetIsCheckProperty(true);
    }
    exports.gs_PaperStatus_CheckPropertyNew = gs_PaperStatus_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function gs_PaperStatus_CheckProperty4Update(pobjgs_PaperStatusEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperStatusEN.paperStatusId) == false && (0, clsString_js_2.GetStrLen)(pobjgs_PaperStatusEN.paperStatusId) > 2) {
            throw new Error("(errid:Watl000062)字段[论文状态Id(paperStatusId)]的长度不能超过2(In 论文状态表(gs_PaperStatus))!值:$(pobjgs_PaperStatusEN.paperStatusId)(clsgs_PaperStatusBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperStatusEN.paperStatusName) == false && (0, clsString_js_2.GetStrLen)(pobjgs_PaperStatusEN.paperStatusName) > 50) {
            throw new Error("(errid:Watl000062)字段[论文状态名(paperStatusName)]的长度不能超过50(In 论文状态表(gs_PaperStatus))!值:$(pobjgs_PaperStatusEN.paperStatusName)(clsgs_PaperStatusBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperStatusEN.updUser) == false && (0, clsString_js_2.GetStrLen)(pobjgs_PaperStatusEN.updUser) > 20) {
            throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 论文状态表(gs_PaperStatus))!值:$(pobjgs_PaperStatusEN.updUser)(clsgs_PaperStatusBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperStatusEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjgs_PaperStatusEN.updDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 论文状态表(gs_PaperStatus))!值:$(pobjgs_PaperStatusEN.updDate)(clsgs_PaperStatusBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperStatusEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjgs_PaperStatusEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 论文状态表(gs_PaperStatus))!值:$(pobjgs_PaperStatusEN.memo)(clsgs_PaperStatusBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperStatusEN.paperStatusId) == false && undefined !== pobjgs_PaperStatusEN.paperStatusId && clsString_js_1.tzDataType.isString(pobjgs_PaperStatusEN.paperStatusId) === false) {
            throw new Error("(errid:Watl000063)字段[论文状态Id(paperStatusId)]的值:[$(pobjgs_PaperStatusEN.paperStatusId)], 非法，应该为字符型(In 论文状态表(gs_PaperStatus))!(clsgs_PaperStatusBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperStatusEN.paperStatusName) == false && undefined !== pobjgs_PaperStatusEN.paperStatusName && clsString_js_1.tzDataType.isString(pobjgs_PaperStatusEN.paperStatusName) === false) {
            throw new Error("(errid:Watl000063)字段[论文状态名(paperStatusName)]的值:[$(pobjgs_PaperStatusEN.paperStatusName)], 非法，应该为字符型(In 论文状态表(gs_PaperStatus))!(clsgs_PaperStatusBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperStatusEN.updUser) == false && undefined !== pobjgs_PaperStatusEN.updUser && clsString_js_1.tzDataType.isString(pobjgs_PaperStatusEN.updUser) === false) {
            throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjgs_PaperStatusEN.updUser)], 非法，应该为字符型(In 论文状态表(gs_PaperStatus))!(clsgs_PaperStatusBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperStatusEN.updDate) == false && undefined !== pobjgs_PaperStatusEN.updDate && clsString_js_1.tzDataType.isString(pobjgs_PaperStatusEN.updDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjgs_PaperStatusEN.updDate)], 非法，应该为字符型(In 论文状态表(gs_PaperStatus))!(clsgs_PaperStatusBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperStatusEN.memo) == false && undefined !== pobjgs_PaperStatusEN.memo && clsString_js_1.tzDataType.isString(pobjgs_PaperStatusEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjgs_PaperStatusEN.memo)], 非法，应该为字符型(In 论文状态表(gs_PaperStatus))!(clsgs_PaperStatusBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PaperStatusEN.paperStatusId) === true) {
            throw new Error("(errid:Watl000064)字段[论文状态Id]不能为空(In 论文状态表)!(clsgs_PaperStatusBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjgs_PaperStatusEN.SetIsCheckProperty(true);
    }
    exports.gs_PaperStatus_CheckProperty4Update = gs_PaperStatus_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function gs_PaperStatus_GetJSONStrByObj(pobjgs_PaperStatusEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjgs_PaperStatusEN.sf_UpdFldSetStr = pobjgs_PaperStatusEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjgs_PaperStatusEN);
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
    exports.gs_PaperStatus_GetJSONStrByObj = gs_PaperStatus_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function gs_PaperStatus_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrgs_PaperStatusObjLst = new Array();
        if (strJSON === "") {
            return arrgs_PaperStatusObjLst;
        }
        try {
            arrgs_PaperStatusObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrgs_PaperStatusObjLst;
        }
        return arrgs_PaperStatusObjLst;
    }
    exports.gs_PaperStatus_GetObjLstByJSONStr = gs_PaperStatus_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrgs_PaperStatusObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function gs_PaperStatus_GetObjLstByJSONObjLst(arrgs_PaperStatusObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrgs_PaperStatusObjLst = new Array();
        for (const objInFor of arrgs_PaperStatusObjLstS) {
            const obj1 = gs_PaperStatus_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrgs_PaperStatusObjLst.push(obj1);
        }
        return arrgs_PaperStatusObjLst;
    }
    exports.gs_PaperStatus_GetObjLstByJSONObjLst = gs_PaperStatus_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function gs_PaperStatus_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjgs_PaperStatusEN = new clsgs_PaperStatusEN_js_1.clsgs_PaperStatusEN();
        if (strJSON === "") {
            return pobjgs_PaperStatusEN;
        }
        try {
            pobjgs_PaperStatusEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjgs_PaperStatusEN;
        }
        return pobjgs_PaperStatusEN;
    }
    exports.gs_PaperStatus_GetObjByJSONStr = gs_PaperStatus_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function gs_PaperStatus_GetCombineCondition(objgs_PaperStatus_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objgs_PaperStatus_Cond.dicFldComparisonOp, clsgs_PaperStatusEN_js_1.clsgs_PaperStatusEN.con_PaperStatusId) == true) {
            const strComparisonOp_PaperStatusId = objgs_PaperStatus_Cond.dicFldComparisonOp[clsgs_PaperStatusEN_js_1.clsgs_PaperStatusEN.con_PaperStatusId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_PaperStatusEN_js_1.clsgs_PaperStatusEN.con_PaperStatusId, objgs_PaperStatus_Cond.paperStatusId, strComparisonOp_PaperStatusId);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_PaperStatus_Cond.dicFldComparisonOp, clsgs_PaperStatusEN_js_1.clsgs_PaperStatusEN.con_PaperStatusName) == true) {
            const strComparisonOp_PaperStatusName = objgs_PaperStatus_Cond.dicFldComparisonOp[clsgs_PaperStatusEN_js_1.clsgs_PaperStatusEN.con_PaperStatusName];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_PaperStatusEN_js_1.clsgs_PaperStatusEN.con_PaperStatusName, objgs_PaperStatus_Cond.paperStatusName, strComparisonOp_PaperStatusName);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_PaperStatus_Cond.dicFldComparisonOp, clsgs_PaperStatusEN_js_1.clsgs_PaperStatusEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objgs_PaperStatus_Cond.dicFldComparisonOp[clsgs_PaperStatusEN_js_1.clsgs_PaperStatusEN.con_UpdUser];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_PaperStatusEN_js_1.clsgs_PaperStatusEN.con_UpdUser, objgs_PaperStatus_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_PaperStatus_Cond.dicFldComparisonOp, clsgs_PaperStatusEN_js_1.clsgs_PaperStatusEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objgs_PaperStatus_Cond.dicFldComparisonOp[clsgs_PaperStatusEN_js_1.clsgs_PaperStatusEN.con_UpdDate];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_PaperStatusEN_js_1.clsgs_PaperStatusEN.con_UpdDate, objgs_PaperStatus_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_PaperStatus_Cond.dicFldComparisonOp, clsgs_PaperStatusEN_js_1.clsgs_PaperStatusEN.con_Memo) == true) {
            const strComparisonOp_Memo = objgs_PaperStatus_Cond.dicFldComparisonOp[clsgs_PaperStatusEN_js_1.clsgs_PaperStatusEN.con_Memo];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_PaperStatusEN_js_1.clsgs_PaperStatusEN.con_Memo, objgs_PaperStatus_Cond.memo, strComparisonOp_Memo);
        }
        return strWhereCond;
    }
    exports.gs_PaperStatus_GetCombineCondition = gs_PaperStatus_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--gs_PaperStatus(论文状态表),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param strPaperStatusId: 论文状态Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function gs_PaperStatus_GetUniCondStr_PaperStatusId(objgs_PaperStatusEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and PaperStatusId = '{0}'", objgs_PaperStatusEN.paperStatusId);
        return strWhereCond;
    }
    exports.gs_PaperStatus_GetUniCondStr_PaperStatusId = gs_PaperStatus_GetUniCondStr_PaperStatusId;
    /**
    *获取唯一性条件串(Uniqueness)--gs_PaperStatus(论文状态表),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param strPaperStatusId: 论文状态Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function gs_PaperStatus_GetUniCondStr4Update_PaperStatusId(objgs_PaperStatusEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and PaperStatusId <> '{0}'", objgs_PaperStatusEN.paperStatusId);
        strWhereCond += (0, clsString_js_2.Format)(" and PaperStatusId = '{0}'", objgs_PaperStatusEN.paperStatusId);
        return strWhereCond;
    }
    exports.gs_PaperStatus_GetUniCondStr4Update_PaperStatusId = gs_PaperStatus_GetUniCondStr4Update_PaperStatusId;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objgs_PaperStatusENS:源对象
     * @param objgs_PaperStatusENT:目标对象
    */
    function gs_PaperStatus_CopyObjTo(objgs_PaperStatusENS, objgs_PaperStatusENT) {
        objgs_PaperStatusENT.paperStatusId = objgs_PaperStatusENS.paperStatusId; //论文状态Id
        objgs_PaperStatusENT.paperStatusName = objgs_PaperStatusENS.paperStatusName; //论文状态名
        objgs_PaperStatusENT.updUser = objgs_PaperStatusENS.updUser; //修改人
        objgs_PaperStatusENT.updDate = objgs_PaperStatusENS.updDate; //修改日期
        objgs_PaperStatusENT.memo = objgs_PaperStatusENS.memo; //备注
        objgs_PaperStatusENT.sf_UpdFldSetStr = objgs_PaperStatusENS.updFldString; //sf_UpdFldSetStr
    }
    exports.gs_PaperStatus_CopyObjTo = gs_PaperStatus_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objgs_PaperStatusENS:源对象
     * @param objgs_PaperStatusENT:目标对象
    */
    function gs_PaperStatus_GetObjFromJsonObj(objgs_PaperStatusENS) {
        const objgs_PaperStatusENT = new clsgs_PaperStatusEN_js_1.clsgs_PaperStatusEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objgs_PaperStatusENT, objgs_PaperStatusENS);
        return objgs_PaperStatusENT;
    }
    exports.gs_PaperStatus_GetObjFromJsonObj = gs_PaperStatus_GetObjFromJsonObj;
});
