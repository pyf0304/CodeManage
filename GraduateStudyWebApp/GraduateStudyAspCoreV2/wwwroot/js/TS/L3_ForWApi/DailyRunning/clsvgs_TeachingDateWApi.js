/**
* 类名:clsvgs_TeachingDateWApi
* 表名:vgs_TeachingDate(01120687)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/15 23:43:56
* 生成者:pyf
* 生成服务器IP:
工程名称:问卷调查(0112)
CM工程:研究生论文学习(变量首字母小写)-全部函数集
* 相关数据库:103.116.76.183,9433EduHigh_Jsie
* PrjDataBaseId:0170
模块中文名:日常运行(DailyRunning)
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
        define(["require", "exports", "axios", "../../PubFun/enumComparisonOp.js", "../../PubFun/CacheHelper.js", "../../L0_Entity/DailyRunning/clsvgs_TeachingDateEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.vgs_TeachingDate_GetObjFromJsonObj = exports.vgs_TeachingDate_CopyObjTo = exports.vgs_TeachingDate_GetCombineCondition = exports.vgs_TeachingDate_GetObjByJSONStr = exports.vgs_TeachingDate_GetObjLstByJSONObjLst = exports.vgs_TeachingDate_GetObjLstByJSONStr = exports.vgs_TeachingDate_GetJSONStrByObj = exports.vgs_TeachingDate_ReFreshThisCache = exports.vgs_TeachingDate_GetWebApiUrl = exports.vgs_TeachingDate_GetRecCountByCond_Cache = exports.vgs_TeachingDate_GetRecCountByCondAsync = exports.vgs_TeachingDate_IsExistAsync = exports.vgs_TeachingDate_IsExist_Cache = exports.vgs_TeachingDate_IsExist = exports.vgs_TeachingDate_IsExistRecordAsync = exports.vgs_TeachingDate_IsExistRecord_Cache = exports.vgs_TeachingDate_GetObjLstByPagerAsync = exports.vgs_TeachingDate_GetObjLstByPager_Cache = exports.vgs_TeachingDate_GetObjLstByRange = exports.vgs_TeachingDate_GetObjLstByRangeAsync = exports.vgs_TeachingDate_GetTopObjLstAsync = exports.vgs_TeachingDate_GetObjLstBymIdLst_Cache = exports.vgs_TeachingDate_GetObjLstBymIdLstAsync = exports.vgs_TeachingDate_GetSubObjLst_Cache = exports.vgs_TeachingDate_GetObjLst_PureCache = exports.vgs_TeachingDate_GetObjLst_Cache = exports.vgs_TeachingDate_GetObjLst_sessionStorage_PureCache = exports.vgs_TeachingDate_GetObjLst_sessionStorage = exports.vgs_TeachingDate_GetObjLstAsync = exports.vgs_TeachingDate_GetObjLst_localStorage_PureCache = exports.vgs_TeachingDate_GetObjLst_localStorage = exports.vgs_TeachingDate_GetObjLst_ClientCache = exports.vgs_TeachingDate_GetFirstObjAsync = exports.vgs_TeachingDate_GetFirstID = exports.vgs_TeachingDate_GetFirstIDAsync = exports.vgs_TeachingDate_funcKey = exports.vgs_TeachingDate_FilterFunByKey = exports.vgs_TeachingDate_SortFunByKey = exports.vgs_TeachingDate_SortFun_Defa_2Fld = exports.vgs_TeachingDate_SortFun_Defa = exports.vgs_TeachingDate_func = exports.vgs_TeachingDate_GetObjBymId_localStorage = exports.vgs_TeachingDate_GetObjBymId_Cache = exports.vgs_TeachingDate_GetObjBymIdAsync = exports.vgs_TeachingDate_ConstructorName = exports.vgs_TeachingDate_Controller = void 0;
    /**
     * vgs_TeachingDate(vgs_TeachingDate)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月15日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const enumComparisonOp_js_1 = require("../../PubFun/enumComparisonOp.js");
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsvgs_TeachingDateEN_js_1 = require("../../L0_Entity/DailyRunning/clsvgs_TeachingDateEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.vgs_TeachingDate_Controller = "vgs_TeachingDateApi";
    exports.vgs_TeachingDate_ConstructorName = "vgs_TeachingDate";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param lngmId:关键字
    * @returns 对象
    **/
    async function vgs_TeachingDate_GetObjBymIdAsync(lngmId) {
        const strThisFuncName = "GetObjBymIdAsync";
        if (lngmId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngmId]不能为空！(In clsvgs_TeachingDateWApi.GetObjBymIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjBymId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_TeachingDate_Controller, strAction);
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
                const objvgs_TeachingDate = vgs_TeachingDate_GetObjFromJsonObj(returnObj);
                return objvgs_TeachingDate;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_TeachingDate_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_TeachingDate_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_TeachingDate_GetObjBymIdAsync = vgs_TeachingDate_GetObjBymIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param lngmId:所给的关键字
     * @returns 对象
    */
    async function vgs_TeachingDate_GetObjBymId_Cache(lngmId, strid_CurrEduCls, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjBymId_Cache";
        if (lngmId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngmId]不能为空！(In clsvgs_TeachingDateWApi.GetObjBymId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        const arrvgs_TeachingDateObjLst_Cache = await vgs_TeachingDate_GetObjLst_Cache(strid_CurrEduCls);
        try {
            const arrvgs_TeachingDate_Sel = arrvgs_TeachingDateObjLst_Cache.filter(x => x.mId == lngmId);
            let objvgs_TeachingDate;
            if (arrvgs_TeachingDate_Sel.length > 0) {
                objvgs_TeachingDate = arrvgs_TeachingDate_Sel[0];
                return objvgs_TeachingDate;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    const objvgs_TeachingDate_Const = await vgs_TeachingDate_GetObjBymIdAsync(lngmId);
                    if (objvgs_TeachingDate_Const != null) {
                        vgs_TeachingDate_ReFreshThisCache(strid_CurrEduCls);
                        return objvgs_TeachingDate_Const;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngmId, exports.vgs_TeachingDate_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.vgs_TeachingDate_GetObjBymId_Cache = vgs_TeachingDate_GetObjBymId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param lngmId:所给的关键字
     * @returns 对象
    */
    async function vgs_TeachingDate_GetObjBymId_localStorage(lngmId) {
        const strThisFuncName = "GetObjBymId_localStorage";
        if (lngmId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngmId]不能为空！(In clsvgs_TeachingDateWApi.GetObjBymId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvgs_TeachingDateEN_js_1.clsvgs_TeachingDateEN._CurrTabName, lngmId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objvgs_TeachingDate_Cache = JSON.parse(strTempObj);
            return objvgs_TeachingDate_Cache;
        }
        try {
            const objvgs_TeachingDate = await vgs_TeachingDate_GetObjBymIdAsync(lngmId);
            if (objvgs_TeachingDate != null) {
                localStorage.setItem(strKey, JSON.stringify(objvgs_TeachingDate));
                const strInfo = (0, clsString_js_1.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objvgs_TeachingDate;
            }
            return objvgs_TeachingDate;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngmId, exports.vgs_TeachingDate_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.vgs_TeachingDate_GetObjBymId_localStorage = vgs_TeachingDate_GetObjBymId_localStorage;
    /*该表没有名称字段，不能生成此函数！*/
    /**
     * 映射函数。根据表映射把输入字段值，映射成输出字段值
     * 作者:pyf
     * 日期:2023-03-15
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_func)
     * @param strInFldName:输入字段名
     * @param strOutFldName:输出字段名
     * @param strInValue:输入字段值
     @param strid_CurrEduCls:缓存的分类字段
     * @returns 返回一个输出字段值
    */
    async function vgs_TeachingDate_func(strInFldName, strOutFldName, strInValue, strid_CurrEduCls_C) {
        //const strThisFuncName = "func";
        if ((0, clsString_js_1.IsNullOrEmpty)(strid_CurrEduCls_C) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strid_CurrEduCls_C]不能为空！(In clsvgs_TeachingDateWApi.func)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls_C.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strid_CurrEduCls_C]的长度:[{0}]不正确！(clsvgs_TeachingDateWApi.func)", strid_CurrEduCls_C.length);
            console.error(strMsg);
            throw (strMsg);
        }
        if (strInFldName != clsvgs_TeachingDateEN_js_1.clsvgs_TeachingDateEN.con_mId) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsvgs_TeachingDateEN_js_1.clsvgs_TeachingDateEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_1.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strOutFldName, clsvgs_TeachingDateEN_js_1.clsvgs_TeachingDateEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const lngmId = Number(strInValue);
        if (lngmId == 0) {
            return "";
        }
        const objvgs_TeachingDate = await vgs_TeachingDate_GetObjBymId_Cache(lngmId, strid_CurrEduCls_C);
        if (objvgs_TeachingDate == null)
            return "";
        if (objvgs_TeachingDate.GetFldValue(strOutFldName) == null)
            return "";
        return objvgs_TeachingDate.GetFldValue(strOutFldName).toString();
    }
    exports.vgs_TeachingDate_func = vgs_TeachingDate_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-15
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vgs_TeachingDate_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.mId - b.mId;
    }
    exports.vgs_TeachingDate_SortFun_Defa = vgs_TeachingDate_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-15
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vgs_TeachingDate_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.currEduClsId == b.currEduClsId)
            return a.eduClsName.localeCompare(b.eduClsName);
        else
            return a.currEduClsId.localeCompare(b.currEduClsId);
    }
    exports.vgs_TeachingDate_SortFun_Defa_2Fld = vgs_TeachingDate_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-15
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vgs_TeachingDate_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsvgs_TeachingDateEN_js_1.clsvgs_TeachingDateEN.con_CurrEduClsId:
                    return (a, b) => {
                        if (a.currEduClsId == null)
                            return -1;
                        if (b.currEduClsId == null)
                            return 1;
                        return a.currEduClsId.localeCompare(b.currEduClsId);
                    };
                case clsvgs_TeachingDateEN_js_1.clsvgs_TeachingDateEN.con_EduClsName:
                    return (a, b) => {
                        if (a.eduClsName == null)
                            return -1;
                        if (b.eduClsName == null)
                            return 1;
                        return a.eduClsName.localeCompare(b.eduClsName);
                    };
                case clsvgs_TeachingDateEN_js_1.clsvgs_TeachingDateEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                case clsvgs_TeachingDateEN_js_1.clsvgs_TeachingDateEN.con_UpdDate:
                    return (a, b) => {
                        if (a.updDate == null)
                            return -1;
                        if (b.updDate == null)
                            return 1;
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsvgs_TeachingDateEN_js_1.clsvgs_TeachingDateEN.con_EndDate:
                    return (a, b) => {
                        if (a.endDate == null)
                            return -1;
                        if (b.endDate == null)
                            return 1;
                        return a.endDate.localeCompare(b.endDate);
                    };
                case clsvgs_TeachingDateEN_js_1.clsvgs_TeachingDateEN.con_StartDate:
                    return (a, b) => {
                        if (a.startDate == null)
                            return -1;
                        if (b.startDate == null)
                            return 1;
                        return a.startDate.localeCompare(b.startDate);
                    };
                case clsvgs_TeachingDateEN_js_1.clsvgs_TeachingDateEN.con_id_CurrEduCls:
                    return (a, b) => {
                        if (a.id_CurrEduCls == null)
                            return -1;
                        if (b.id_CurrEduCls == null)
                            return 1;
                        return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
                    };
                case clsvgs_TeachingDateEN_js_1.clsvgs_TeachingDateEN.con_UpdUser:
                    return (a, b) => {
                        if (a.updUser == null)
                            return -1;
                        if (b.updUser == null)
                            return 1;
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsvgs_TeachingDateEN_js_1.clsvgs_TeachingDateEN.con_mId:
                    return (a, b) => {
                        return a.mId - b.mId;
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vgs_TeachingDate]中不存在！(in ${exports.vgs_TeachingDate_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsvgs_TeachingDateEN_js_1.clsvgs_TeachingDateEN.con_CurrEduClsId:
                    return (a, b) => {
                        if (b.currEduClsId == null)
                            return -1;
                        if (a.currEduClsId == null)
                            return 1;
                        return b.currEduClsId.localeCompare(a.currEduClsId);
                    };
                case clsvgs_TeachingDateEN_js_1.clsvgs_TeachingDateEN.con_EduClsName:
                    return (a, b) => {
                        if (b.eduClsName == null)
                            return -1;
                        if (a.eduClsName == null)
                            return 1;
                        return b.eduClsName.localeCompare(a.eduClsName);
                    };
                case clsvgs_TeachingDateEN_js_1.clsvgs_TeachingDateEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                case clsvgs_TeachingDateEN_js_1.clsvgs_TeachingDateEN.con_UpdDate:
                    return (a, b) => {
                        if (b.updDate == null)
                            return -1;
                        if (a.updDate == null)
                            return 1;
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsvgs_TeachingDateEN_js_1.clsvgs_TeachingDateEN.con_EndDate:
                    return (a, b) => {
                        if (b.endDate == null)
                            return -1;
                        if (a.endDate == null)
                            return 1;
                        return b.endDate.localeCompare(a.endDate);
                    };
                case clsvgs_TeachingDateEN_js_1.clsvgs_TeachingDateEN.con_StartDate:
                    return (a, b) => {
                        if (b.startDate == null)
                            return -1;
                        if (a.startDate == null)
                            return 1;
                        return b.startDate.localeCompare(a.startDate);
                    };
                case clsvgs_TeachingDateEN_js_1.clsvgs_TeachingDateEN.con_id_CurrEduCls:
                    return (a, b) => {
                        if (b.id_CurrEduCls == null)
                            return -1;
                        if (a.id_CurrEduCls == null)
                            return 1;
                        return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
                    };
                case clsvgs_TeachingDateEN_js_1.clsvgs_TeachingDateEN.con_UpdUser:
                    return (a, b) => {
                        if (b.updUser == null)
                            return -1;
                        if (a.updUser == null)
                            return 1;
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsvgs_TeachingDateEN_js_1.clsvgs_TeachingDateEN.con_mId:
                    return (a, b) => {
                        return b.mId - a.mId;
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vgs_TeachingDate]中不存在！(in ${exports.vgs_TeachingDate_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.vgs_TeachingDate_SortFunByKey = vgs_TeachingDate_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-15
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function vgs_TeachingDate_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsvgs_TeachingDateEN_js_1.clsvgs_TeachingDateEN.con_CurrEduClsId:
                return (obj) => {
                    return obj.currEduClsId === value;
                };
            case clsvgs_TeachingDateEN_js_1.clsvgs_TeachingDateEN.con_EduClsName:
                return (obj) => {
                    return obj.eduClsName === value;
                };
            case clsvgs_TeachingDateEN_js_1.clsvgs_TeachingDateEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            case clsvgs_TeachingDateEN_js_1.clsvgs_TeachingDateEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsvgs_TeachingDateEN_js_1.clsvgs_TeachingDateEN.con_EndDate:
                return (obj) => {
                    return obj.endDate === value;
                };
            case clsvgs_TeachingDateEN_js_1.clsvgs_TeachingDateEN.con_StartDate:
                return (obj) => {
                    return obj.startDate === value;
                };
            case clsvgs_TeachingDateEN_js_1.clsvgs_TeachingDateEN.con_id_CurrEduCls:
                return (obj) => {
                    return obj.id_CurrEduCls === value;
                };
            case clsvgs_TeachingDateEN_js_1.clsvgs_TeachingDateEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsvgs_TeachingDateEN_js_1.clsvgs_TeachingDateEN.con_mId:
                return (obj) => {
                    return obj.mId === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[vgs_TeachingDate]中不存在！(in ${exports.vgs_TeachingDate_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.vgs_TeachingDate_FilterFunByKey = vgs_TeachingDate_FilterFunByKey;
    /**
     * 映射函数。根据表映射把输入字段值，映射成输出字段值
     * 作者:pyf
     * 日期:2023-03-15
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_funcKey)
     * @param strInFldName:输入字段名
     * @param strInValue:输入字段值
     * @param strComparisonOp:比较操作符
     @param strid_CurrEduCls:缓存的分类字段
     * @returns 返回一个关键字值列表
    */
    async function vgs_TeachingDate_funcKey(strInFldName, strInValue, strComparisonOp, strid_CurrEduCls_C) {
        //const strThisFuncName = "funcKey";
        if ((0, clsString_js_1.IsNullOrEmpty)(strid_CurrEduCls_C) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strid_CurrEduCls_C]不能为空！(In clsvgs_TeachingDateWApi.funcKey)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls_C.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strid_CurrEduCls_C]的长度:[{0}]不正确！(clsvgs_TeachingDateWApi.funcKey)", strid_CurrEduCls_C.length);
            console.error(strMsg);
            throw (strMsg);
        }
        if (strInFldName == clsvgs_TeachingDateEN_js_1.clsvgs_TeachingDateEN.con_mId) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (Number(strInValue) == 0) {
            return [];
        }
        const arrvgs_TeachingDate = await vgs_TeachingDate_GetObjLst_Cache(strid_CurrEduCls_C);
        if (arrvgs_TeachingDate == null)
            return [];
        let arrvgs_TeachingDate_Sel = arrvgs_TeachingDate;
        const strType = typeof (strInValue);
        switch (strType) {
            case "string":
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01: // " = "
                        arrvgs_TeachingDate_Sel = arrvgs_TeachingDate_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.Like_03:
                        arrvgs_TeachingDate_Sel = arrvgs_TeachingDate_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.In_04:
                        const arrValues = strInValue.split(',');
                        arrvgs_TeachingDate_Sel = arrvgs_TeachingDate_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
                        break;
                }
                break;
            case "boolean":
                if (strInValue == null)
                    return [];
                if (strComparisonOp == enumComparisonOp_js_1.enumComparisonOp.Equal_01) {
                    arrvgs_TeachingDate_Sel = arrvgs_TeachingDate_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                }
                break;
            case "number":
                if (Number(strInValue) == 0)
                    return [];
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01:
                        arrvgs_TeachingDate_Sel = arrvgs_TeachingDate_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotEqual_02:
                        arrvgs_TeachingDate_Sel = arrvgs_TeachingDate_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotLessThan_05: //" >= ":
                        arrvgs_TeachingDate_Sel = arrvgs_TeachingDate_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotGreaterThan_06: //" <= ":
                        arrvgs_TeachingDate_Sel = arrvgs_TeachingDate_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.GreaterThan_07: //" > ":
                        arrvgs_TeachingDate_Sel = arrvgs_TeachingDate_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.LessThan_08: //" < ":
                        arrvgs_TeachingDate_Sel = arrvgs_TeachingDate_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                }
                break;
        }
        if (arrvgs_TeachingDate_Sel.length == 0)
            return [];
        return arrvgs_TeachingDate_Sel.map(x => x.mId);
    }
    exports.vgs_TeachingDate_funcKey = vgs_TeachingDate_funcKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function vgs_TeachingDate_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_TeachingDate_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_TeachingDate_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_TeachingDate_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_TeachingDate_GetFirstIDAsync = vgs_TeachingDate_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function vgs_TeachingDate_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_TeachingDate_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_TeachingDate_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_TeachingDate_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_TeachingDate_GetFirstID = vgs_TeachingDate_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function vgs_TeachingDate_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_TeachingDate_Controller, strAction);
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
                const objvgs_TeachingDate = vgs_TeachingDate_GetObjFromJsonObj(returnObj);
                return objvgs_TeachingDate;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_TeachingDate_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_TeachingDate_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_TeachingDate_GetFirstObjAsync = vgs_TeachingDate_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vgs_TeachingDate_GetObjLst_ClientCache(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvgs_TeachingDateEN_js_1.clsvgs_TeachingDateEN.WhereFormat) == false) {
            strWhereCond = (0, clsString_js_1.Format)(clsvgs_TeachingDateEN_js_1.clsvgs_TeachingDateEN.WhereFormat, strid_CurrEduCls);
        }
        else {
            strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvgs_TeachingDateEN_js_1.clsvgs_TeachingDateEN._CurrTabName, strid_CurrEduCls);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvgs_TeachingDateEN_js_1.clsvgs_TeachingDateEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvgs_TeachingDateEN_js_1.clsvgs_TeachingDateEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_1.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrvgs_TeachingDateExObjLst_Cache = CacheHelper_js_1.CacheHelper.Get(strKey);
            const arrvgs_TeachingDateObjLst_T = vgs_TeachingDate_GetObjLstByJSONObjLst(arrvgs_TeachingDateExObjLst_Cache);
            return arrvgs_TeachingDateObjLst_T;
        }
        try {
            const arrvgs_TeachingDateExObjLst = await vgs_TeachingDate_GetObjLstAsync(strWhereCond);
            CacheHelper_js_1.CacheHelper.Add(strKey, arrvgs_TeachingDateExObjLst);
            const strInfo = (0, clsString_js_1.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvgs_TeachingDateExObjLst.length);
            console.log(strInfo);
            return arrvgs_TeachingDateExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vgs_TeachingDate_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vgs_TeachingDate_GetObjLst_ClientCache = vgs_TeachingDate_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vgs_TeachingDate_GetObjLst_localStorage(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvgs_TeachingDateEN_js_1.clsvgs_TeachingDateEN.WhereFormat) == false) {
            strWhereCond = (0, clsString_js_1.Format)(clsvgs_TeachingDateEN_js_1.clsvgs_TeachingDateEN.WhereFormat, strid_CurrEduCls);
        }
        else {
            strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvgs_TeachingDateEN_js_1.clsvgs_TeachingDateEN._CurrTabName, strid_CurrEduCls);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvgs_TeachingDateEN_js_1.clsvgs_TeachingDateEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvgs_TeachingDateEN_js_1.clsvgs_TeachingDateEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrvgs_TeachingDateExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrvgs_TeachingDateObjLst_T = vgs_TeachingDate_GetObjLstByJSONObjLst(arrvgs_TeachingDateExObjLst_Cache);
            return arrvgs_TeachingDateObjLst_T;
        }
        try {
            const arrvgs_TeachingDateExObjLst = await vgs_TeachingDate_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrvgs_TeachingDateExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvgs_TeachingDateExObjLst.length);
            console.log(strInfo);
            return arrvgs_TeachingDateExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vgs_TeachingDate_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vgs_TeachingDate_GetObjLst_localStorage = vgs_TeachingDate_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vgs_TeachingDate_GetObjLst_localStorage_PureCache(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvgs_TeachingDateEN_js_1.clsvgs_TeachingDateEN._CurrTabName, strid_CurrEduCls);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrvgs_TeachingDateObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvgs_TeachingDateObjLst_Cache;
        }
        else
            return null;
    }
    exports.vgs_TeachingDate_GetObjLst_localStorage_PureCache = vgs_TeachingDate_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function vgs_TeachingDate_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_TeachingDate_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vgs_TeachingDate_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vgs_TeachingDate_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_TeachingDate_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_TeachingDate_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_TeachingDate_GetObjLstAsync = vgs_TeachingDate_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vgs_TeachingDate_GetObjLst_sessionStorage(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvgs_TeachingDateEN_js_1.clsvgs_TeachingDateEN.WhereFormat) == false) {
            strWhereCond = (0, clsString_js_1.Format)(clsvgs_TeachingDateEN_js_1.clsvgs_TeachingDateEN.WhereFormat, strid_CurrEduCls);
        }
        else {
            strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvgs_TeachingDateEN_js_1.clsvgs_TeachingDateEN._CurrTabName, strid_CurrEduCls);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvgs_TeachingDateEN_js_1.clsvgs_TeachingDateEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvgs_TeachingDateEN_js_1.clsvgs_TeachingDateEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrvgs_TeachingDateExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrvgs_TeachingDateObjLst_T = vgs_TeachingDate_GetObjLstByJSONObjLst(arrvgs_TeachingDateExObjLst_Cache);
            return arrvgs_TeachingDateObjLst_T;
        }
        try {
            const arrvgs_TeachingDateExObjLst = await vgs_TeachingDate_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrvgs_TeachingDateExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvgs_TeachingDateExObjLst.length);
            console.log(strInfo);
            return arrvgs_TeachingDateExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vgs_TeachingDate_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vgs_TeachingDate_GetObjLst_sessionStorage = vgs_TeachingDate_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vgs_TeachingDate_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvgs_TeachingDateEN_js_1.clsvgs_TeachingDateEN._CurrTabName, strid_CurrEduCls);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrvgs_TeachingDateObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvgs_TeachingDateObjLst_Cache;
        }
        else
            return null;
    }
    exports.vgs_TeachingDate_GetObjLst_sessionStorage_PureCache = vgs_TeachingDate_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vgs_TeachingDate_GetObjLst_Cache(strid_CurrEduCls) {
        //const strThisFuncName = "GetObjLst_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strid_CurrEduCls) == true) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[id_CurrEduCls]不能为空！(in clsvgs_TeachingDateWApi.vgs_TeachingDate_GetObjLst_Cache() )");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strid_CurrEduCls]的长度:[{0}]不正确！(in clsvgs_TeachingDateWApi.vgs_TeachingDate_GetObjLst_Cache() )", strid_CurrEduCls.length);
            console.error(strMsg);
            throw (strMsg);
        }
        let arrvgs_TeachingDateObjLst_Cache;
        switch (clsvgs_TeachingDateEN_js_1.clsvgs_TeachingDateEN.CacheModeId) {
            case "04": //sessionStorage
                arrvgs_TeachingDateObjLst_Cache = await vgs_TeachingDate_GetObjLst_sessionStorage(strid_CurrEduCls);
                break;
            case "03": //localStorage
                arrvgs_TeachingDateObjLst_Cache = await vgs_TeachingDate_GetObjLst_localStorage(strid_CurrEduCls);
                break;
            case "02": //ClientCache
                arrvgs_TeachingDateObjLst_Cache = await vgs_TeachingDate_GetObjLst_ClientCache(strid_CurrEduCls);
                break;
            default:
                arrvgs_TeachingDateObjLst_Cache = await vgs_TeachingDate_GetObjLst_ClientCache(strid_CurrEduCls);
                break;
        }
        const arrvgs_TeachingDateObjLst = vgs_TeachingDate_GetObjLstByJSONObjLst(arrvgs_TeachingDateObjLst_Cache);
        return arrvgs_TeachingDateObjLst_Cache;
    }
    exports.vgs_TeachingDate_GetObjLst_Cache = vgs_TeachingDate_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vgs_TeachingDate_GetObjLst_PureCache(strid_CurrEduCls) {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrvgs_TeachingDateObjLst_Cache;
        switch (clsvgs_TeachingDateEN_js_1.clsvgs_TeachingDateEN.CacheModeId) {
            case "04": //sessionStorage
                arrvgs_TeachingDateObjLst_Cache = await vgs_TeachingDate_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls);
                break;
            case "03": //localStorage
                arrvgs_TeachingDateObjLst_Cache = await vgs_TeachingDate_GetObjLst_localStorage_PureCache(strid_CurrEduCls);
                break;
            case "02": //ClientCache
                arrvgs_TeachingDateObjLst_Cache = null;
                break;
            default:
                arrvgs_TeachingDateObjLst_Cache = null;
                break;
        }
        return arrvgs_TeachingDateObjLst_Cache;
    }
    exports.vgs_TeachingDate_GetObjLst_PureCache = vgs_TeachingDate_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objlngmId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function vgs_TeachingDate_GetSubObjLst_Cache(objvgs_TeachingDate_Cond, strid_CurrEduCls) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrvgs_TeachingDateObjLst_Cache = await vgs_TeachingDate_GetObjLst_Cache(strid_CurrEduCls);
        let arrvgs_TeachingDate_Sel = arrvgs_TeachingDateObjLst_Cache;
        if (objvgs_TeachingDate_Cond.sf_FldComparisonOp == null || objvgs_TeachingDate_Cond.sf_FldComparisonOp == "")
            return arrvgs_TeachingDate_Sel;
        const dicFldComparisonOp = JSON.parse(objvgs_TeachingDate_Cond.sf_FldComparisonOp);
        //console.log("clsvgs_TeachingDateWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvgs_TeachingDate_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvgs_TeachingDate_Sel = arrvgs_TeachingDate_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvgs_TeachingDate_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvgs_TeachingDate_Sel = arrvgs_TeachingDate_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvgs_TeachingDate_Sel = arrvgs_TeachingDate_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvgs_TeachingDate_Sel = arrvgs_TeachingDate_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvgs_TeachingDate_Sel = arrvgs_TeachingDate_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvgs_TeachingDate_Sel = arrvgs_TeachingDate_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvgs_TeachingDate_Sel = arrvgs_TeachingDate_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvgs_TeachingDate_Sel = arrvgs_TeachingDate_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvgs_TeachingDate_Sel = arrvgs_TeachingDate_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvgs_TeachingDate_Sel = arrvgs_TeachingDate_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvgs_TeachingDate_Sel = arrvgs_TeachingDate_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvgs_TeachingDate_Sel = arrvgs_TeachingDate_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvgs_TeachingDate_Sel = arrvgs_TeachingDate_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvgs_TeachingDate_Sel = arrvgs_TeachingDate_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrvgs_TeachingDate_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objvgs_TeachingDate_Cond), exports.vgs_TeachingDate_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vgs_TeachingDate_GetSubObjLst_Cache = vgs_TeachingDate_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrmId:关键字列表
    * @returns 对象列表
    **/
    async function vgs_TeachingDate_GetObjLstBymIdLstAsync(arrmId) {
        const strThisFuncName = "GetObjLstBymIdLstAsync";
        const strAction = "GetObjLstBymIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_TeachingDate_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrmId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vgs_TeachingDate_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vgs_TeachingDate_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_TeachingDate_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_TeachingDate_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_TeachingDate_GetObjLstBymIdLstAsync = vgs_TeachingDate_GetObjLstBymIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrlngmIdLst:关键字列表
     * @returns 对象列表
    */
    async function vgs_TeachingDate_GetObjLstBymIdLst_Cache(arrmIdLst, strid_CurrEduCls) {
        const strThisFuncName = "GetObjLstBymIdLst_Cache";
        try {
            const arrvgs_TeachingDateObjLst_Cache = await vgs_TeachingDate_GetObjLst_Cache(strid_CurrEduCls);
            const arrvgs_TeachingDate_Sel = arrvgs_TeachingDateObjLst_Cache.filter(x => arrmIdLst.indexOf(x.mId) > -1);
            return arrvgs_TeachingDate_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrmIdLst.join(","), exports.vgs_TeachingDate_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
    }
    exports.vgs_TeachingDate_GetObjLstBymIdLst_Cache = vgs_TeachingDate_GetObjLstBymIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function vgs_TeachingDate_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_TeachingDate_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vgs_TeachingDate_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vgs_TeachingDate_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_TeachingDate_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_TeachingDate_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_TeachingDate_GetTopObjLstAsync = vgs_TeachingDate_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vgs_TeachingDate_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_TeachingDate_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vgs_TeachingDate_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vgs_TeachingDate_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_TeachingDate_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_TeachingDate_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_TeachingDate_GetObjLstByRangeAsync = vgs_TeachingDate_GetObjLstByRangeAsync;
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
    async function vgs_TeachingDate_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_TeachingDate_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_TeachingDate_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_TeachingDate_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_TeachingDate_GetObjLstByRange = vgs_TeachingDate_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function vgs_TeachingDate_GetObjLstByPager_Cache(objPagerPara, strid_CurrEduCls) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const arrvgs_TeachingDateObjLst_Cache = await vgs_TeachingDate_GetObjLst_Cache(strid_CurrEduCls);
        if (arrvgs_TeachingDateObjLst_Cache.length == 0)
            return arrvgs_TeachingDateObjLst_Cache;
        let arrvgs_TeachingDate_Sel = arrvgs_TeachingDateObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objvgs_TeachingDate_Cond = new clsvgs_TeachingDateEN_js_1.clsvgs_TeachingDateEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvgs_TeachingDate_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsvgs_TeachingDateWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvgs_TeachingDate_Sel = arrvgs_TeachingDate_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvgs_TeachingDate_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvgs_TeachingDate_Sel = arrvgs_TeachingDate_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvgs_TeachingDate_Sel = arrvgs_TeachingDate_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvgs_TeachingDate_Sel = arrvgs_TeachingDate_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvgs_TeachingDate_Sel = arrvgs_TeachingDate_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvgs_TeachingDate_Sel = arrvgs_TeachingDate_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvgs_TeachingDate_Sel = arrvgs_TeachingDate_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvgs_TeachingDate_Sel = arrvgs_TeachingDate_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrvgs_TeachingDate_Sel = arrvgs_TeachingDate_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvgs_TeachingDate_Sel = arrvgs_TeachingDate_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvgs_TeachingDate_Sel = arrvgs_TeachingDate_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvgs_TeachingDate_Sel = arrvgs_TeachingDate_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvgs_TeachingDate_Sel = arrvgs_TeachingDate_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvgs_TeachingDate_Sel = arrvgs_TeachingDate_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvgs_TeachingDate_Sel = arrvgs_TeachingDate_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvgs_TeachingDate_Sel.length == 0)
                return arrvgs_TeachingDate_Sel;
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
                arrvgs_TeachingDate_Sel = arrvgs_TeachingDate_Sel.sort(vgs_TeachingDate_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrvgs_TeachingDate_Sel = arrvgs_TeachingDate_Sel.sort(objPagerPara.sortFun);
            }
            arrvgs_TeachingDate_Sel = arrvgs_TeachingDate_Sel.slice(intStart, intEnd);
            return arrvgs_TeachingDate_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.vgs_TeachingDate_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vgs_TeachingDate_GetObjLstByPager_Cache = vgs_TeachingDate_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vgs_TeachingDate_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_TeachingDate_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vgs_TeachingDate_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vgs_TeachingDate_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_TeachingDate_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_TeachingDate_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_TeachingDate_GetObjLstByPagerAsync = vgs_TeachingDate_GetObjLstByPagerAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objlngmId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function vgs_TeachingDate_IsExistRecord_Cache(objvgs_TeachingDate_Cond, strid_CurrEduCls) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrvgs_TeachingDateObjLst_Cache = await vgs_TeachingDate_GetObjLst_Cache(strid_CurrEduCls);
        if (arrvgs_TeachingDateObjLst_Cache == null)
            return false;
        let arrvgs_TeachingDate_Sel = arrvgs_TeachingDateObjLst_Cache;
        if (objvgs_TeachingDate_Cond.sf_FldComparisonOp == null || objvgs_TeachingDate_Cond.sf_FldComparisonOp == "")
            return arrvgs_TeachingDate_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objvgs_TeachingDate_Cond.sf_FldComparisonOp);
        //console.log("clsvgs_TeachingDateWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvgs_TeachingDate_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvgs_TeachingDate_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvgs_TeachingDate_Sel = arrvgs_TeachingDate_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvgs_TeachingDate_Sel = arrvgs_TeachingDate_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvgs_TeachingDate_Sel = arrvgs_TeachingDate_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvgs_TeachingDate_Sel = arrvgs_TeachingDate_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvgs_TeachingDate_Sel = arrvgs_TeachingDate_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvgs_TeachingDate_Sel = arrvgs_TeachingDate_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvgs_TeachingDate_Sel = arrvgs_TeachingDate_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvgs_TeachingDate_Sel = arrvgs_TeachingDate_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvgs_TeachingDate_Sel = arrvgs_TeachingDate_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvgs_TeachingDate_Sel = arrvgs_TeachingDate_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvgs_TeachingDate_Sel = arrvgs_TeachingDate_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvgs_TeachingDate_Sel = arrvgs_TeachingDate_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvgs_TeachingDate_Sel = arrvgs_TeachingDate_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvgs_TeachingDate_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objvgs_TeachingDate_Cond), exports.vgs_TeachingDate_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.vgs_TeachingDate_IsExistRecord_Cache = vgs_TeachingDate_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function vgs_TeachingDate_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_TeachingDate_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_TeachingDate_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_TeachingDate_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_TeachingDate_IsExistRecordAsync = vgs_TeachingDate_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param lngmId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function vgs_TeachingDate_IsExist(lngmId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_TeachingDate_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_TeachingDate_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_TeachingDate_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_TeachingDate_IsExist = vgs_TeachingDate_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param lngmId:所给的关键字
     * @returns 对象
    */
    async function vgs_TeachingDate_IsExist_Cache(lngmId, strid_CurrEduCls) {
        const strThisFuncName = "IsExist_Cache";
        const arrvgs_TeachingDateObjLst_Cache = await vgs_TeachingDate_GetObjLst_Cache(strid_CurrEduCls);
        if (arrvgs_TeachingDateObjLst_Cache == null)
            return false;
        try {
            const arrvgs_TeachingDate_Sel = arrvgs_TeachingDateObjLst_Cache.filter(x => x.mId == lngmId);
            if (arrvgs_TeachingDate_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", lngmId, exports.vgs_TeachingDate_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.vgs_TeachingDate_IsExist_Cache = vgs_TeachingDate_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param lngmId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function vgs_TeachingDate_IsExistAsync(lngmId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_TeachingDate_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_TeachingDate_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_TeachingDate_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_TeachingDate_IsExistAsync = vgs_TeachingDate_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function vgs_TeachingDate_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_TeachingDate_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_TeachingDate_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_TeachingDate_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_TeachingDate_GetRecCountByCondAsync = vgs_TeachingDate_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objvgs_TeachingDate_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function vgs_TeachingDate_GetRecCountByCond_Cache(objvgs_TeachingDate_Cond, strid_CurrEduCls) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrvgs_TeachingDateObjLst_Cache = await vgs_TeachingDate_GetObjLst_Cache(strid_CurrEduCls);
        if (arrvgs_TeachingDateObjLst_Cache == null)
            return 0;
        let arrvgs_TeachingDate_Sel = arrvgs_TeachingDateObjLst_Cache;
        if (objvgs_TeachingDate_Cond.sf_FldComparisonOp == null || objvgs_TeachingDate_Cond.sf_FldComparisonOp == "")
            return arrvgs_TeachingDate_Sel.length;
        const dicFldComparisonOp = JSON.parse(objvgs_TeachingDate_Cond.sf_FldComparisonOp);
        //console.log("clsvgs_TeachingDateWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvgs_TeachingDate_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvgs_TeachingDate_Sel = arrvgs_TeachingDate_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvgs_TeachingDate_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvgs_TeachingDate_Sel = arrvgs_TeachingDate_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvgs_TeachingDate_Sel = arrvgs_TeachingDate_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvgs_TeachingDate_Sel = arrvgs_TeachingDate_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvgs_TeachingDate_Sel = arrvgs_TeachingDate_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvgs_TeachingDate_Sel = arrvgs_TeachingDate_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvgs_TeachingDate_Sel = arrvgs_TeachingDate_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvgs_TeachingDate_Sel = arrvgs_TeachingDate_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrvgs_TeachingDate_Sel = arrvgs_TeachingDate_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvgs_TeachingDate_Sel = arrvgs_TeachingDate_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvgs_TeachingDate_Sel = arrvgs_TeachingDate_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvgs_TeachingDate_Sel = arrvgs_TeachingDate_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvgs_TeachingDate_Sel = arrvgs_TeachingDate_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvgs_TeachingDate_Sel = arrvgs_TeachingDate_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvgs_TeachingDate_Sel = arrvgs_TeachingDate_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrvgs_TeachingDate_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objvgs_TeachingDate_Cond), exports.vgs_TeachingDate_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.vgs_TeachingDate_GetRecCountByCond_Cache = vgs_TeachingDate_GetRecCountByCond_Cache;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function vgs_TeachingDate_GetWebApiUrl(strController, strAction) {
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
    exports.vgs_TeachingDate_GetWebApiUrl = vgs_TeachingDate_GetWebApiUrl;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function vgs_TeachingDate_ReFreshThisCache(strid_CurrEduCls) {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvgs_TeachingDateEN_js_1.clsvgs_TeachingDateEN._CurrTabName, strid_CurrEduCls);
            switch (clsvgs_TeachingDateEN_js_1.clsvgs_TeachingDateEN.CacheModeId) {
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
    exports.vgs_TeachingDate_ReFreshThisCache = vgs_TeachingDate_ReFreshThisCache;
    /* 该表的下拉框功能没有设置，不需要生成下拉框绑定函数。*/
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-03-15
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vgs_TeachingDate_GetJSONStrByObj(pobjvgs_TeachingDateEN) {
        const strThisFuncName = "GetJSONStrByObj";
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjvgs_TeachingDateEN);
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
    exports.vgs_TeachingDate_GetJSONStrByObj = vgs_TeachingDate_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-15
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function vgs_TeachingDate_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrvgs_TeachingDateObjLst = new Array();
        if (strJSON === "") {
            return arrvgs_TeachingDateObjLst;
        }
        try {
            arrvgs_TeachingDateObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrvgs_TeachingDateObjLst;
        }
        return arrvgs_TeachingDateObjLst;
    }
    exports.vgs_TeachingDate_GetObjLstByJSONStr = vgs_TeachingDate_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-15
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrvgs_TeachingDateObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function vgs_TeachingDate_GetObjLstByJSONObjLst(arrvgs_TeachingDateObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrvgs_TeachingDateObjLst = new Array();
        for (const objInFor of arrvgs_TeachingDateObjLstS) {
            const obj1 = vgs_TeachingDate_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrvgs_TeachingDateObjLst.push(obj1);
        }
        return arrvgs_TeachingDateObjLst;
    }
    exports.vgs_TeachingDate_GetObjLstByJSONObjLst = vgs_TeachingDate_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-15
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vgs_TeachingDate_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjvgs_TeachingDateEN = new clsvgs_TeachingDateEN_js_1.clsvgs_TeachingDateEN();
        if (strJSON === "") {
            return pobjvgs_TeachingDateEN;
        }
        try {
            pobjvgs_TeachingDateEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjvgs_TeachingDateEN;
        }
        return pobjvgs_TeachingDateEN;
    }
    exports.vgs_TeachingDate_GetObjByJSONStr = vgs_TeachingDate_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function vgs_TeachingDate_GetCombineCondition(objvgs_TeachingDate_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objvgs_TeachingDate_Cond.dicFldComparisonOp, clsvgs_TeachingDateEN_js_1.clsvgs_TeachingDateEN.con_CurrEduClsId) == true) {
            const strComparisonOp_CurrEduClsId = objvgs_TeachingDate_Cond.dicFldComparisonOp[clsvgs_TeachingDateEN_js_1.clsvgs_TeachingDateEN.con_CurrEduClsId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_TeachingDateEN_js_1.clsvgs_TeachingDateEN.con_CurrEduClsId, objvgs_TeachingDate_Cond.currEduClsId, strComparisonOp_CurrEduClsId);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_TeachingDate_Cond.dicFldComparisonOp, clsvgs_TeachingDateEN_js_1.clsvgs_TeachingDateEN.con_EduClsName) == true) {
            const strComparisonOp_EduClsName = objvgs_TeachingDate_Cond.dicFldComparisonOp[clsvgs_TeachingDateEN_js_1.clsvgs_TeachingDateEN.con_EduClsName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_TeachingDateEN_js_1.clsvgs_TeachingDateEN.con_EduClsName, objvgs_TeachingDate_Cond.eduClsName, strComparisonOp_EduClsName);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_TeachingDate_Cond.dicFldComparisonOp, clsvgs_TeachingDateEN_js_1.clsvgs_TeachingDateEN.con_Memo) == true) {
            const strComparisonOp_Memo = objvgs_TeachingDate_Cond.dicFldComparisonOp[clsvgs_TeachingDateEN_js_1.clsvgs_TeachingDateEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_TeachingDateEN_js_1.clsvgs_TeachingDateEN.con_Memo, objvgs_TeachingDate_Cond.memo, strComparisonOp_Memo);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_TeachingDate_Cond.dicFldComparisonOp, clsvgs_TeachingDateEN_js_1.clsvgs_TeachingDateEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objvgs_TeachingDate_Cond.dicFldComparisonOp[clsvgs_TeachingDateEN_js_1.clsvgs_TeachingDateEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_TeachingDateEN_js_1.clsvgs_TeachingDateEN.con_UpdDate, objvgs_TeachingDate_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_TeachingDate_Cond.dicFldComparisonOp, clsvgs_TeachingDateEN_js_1.clsvgs_TeachingDateEN.con_EndDate) == true) {
            const strComparisonOp_EndDate = objvgs_TeachingDate_Cond.dicFldComparisonOp[clsvgs_TeachingDateEN_js_1.clsvgs_TeachingDateEN.con_EndDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_TeachingDateEN_js_1.clsvgs_TeachingDateEN.con_EndDate, objvgs_TeachingDate_Cond.endDate, strComparisonOp_EndDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_TeachingDate_Cond.dicFldComparisonOp, clsvgs_TeachingDateEN_js_1.clsvgs_TeachingDateEN.con_StartDate) == true) {
            const strComparisonOp_StartDate = objvgs_TeachingDate_Cond.dicFldComparisonOp[clsvgs_TeachingDateEN_js_1.clsvgs_TeachingDateEN.con_StartDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_TeachingDateEN_js_1.clsvgs_TeachingDateEN.con_StartDate, objvgs_TeachingDate_Cond.startDate, strComparisonOp_StartDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_TeachingDate_Cond.dicFldComparisonOp, clsvgs_TeachingDateEN_js_1.clsvgs_TeachingDateEN.con_id_CurrEduCls) == true) {
            const strComparisonOp_id_CurrEduCls = objvgs_TeachingDate_Cond.dicFldComparisonOp[clsvgs_TeachingDateEN_js_1.clsvgs_TeachingDateEN.con_id_CurrEduCls];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_TeachingDateEN_js_1.clsvgs_TeachingDateEN.con_id_CurrEduCls, objvgs_TeachingDate_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_TeachingDate_Cond.dicFldComparisonOp, clsvgs_TeachingDateEN_js_1.clsvgs_TeachingDateEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objvgs_TeachingDate_Cond.dicFldComparisonOp[clsvgs_TeachingDateEN_js_1.clsvgs_TeachingDateEN.con_UpdUser];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_TeachingDateEN_js_1.clsvgs_TeachingDateEN.con_UpdUser, objvgs_TeachingDate_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_TeachingDate_Cond.dicFldComparisonOp, clsvgs_TeachingDateEN_js_1.clsvgs_TeachingDateEN.con_mId) == true) {
            const strComparisonOp_mId = objvgs_TeachingDate_Cond.dicFldComparisonOp[clsvgs_TeachingDateEN_js_1.clsvgs_TeachingDateEN.con_mId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvgs_TeachingDateEN_js_1.clsvgs_TeachingDateEN.con_mId, objvgs_TeachingDate_Cond.mId, strComparisonOp_mId);
        }
        return strWhereCond;
    }
    exports.vgs_TeachingDate_GetCombineCondition = vgs_TeachingDate_GetCombineCondition;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objvgs_TeachingDateENS:源对象
     * @param objvgs_TeachingDateENT:目标对象
    */
    function vgs_TeachingDate_CopyObjTo(objvgs_TeachingDateENS, objvgs_TeachingDateENT) {
        objvgs_TeachingDateENT.currEduClsId = objvgs_TeachingDateENS.currEduClsId; //教学班Id
        objvgs_TeachingDateENT.eduClsName = objvgs_TeachingDateENS.eduClsName; //教学班名
        objvgs_TeachingDateENT.memo = objvgs_TeachingDateENS.memo; //备注
        objvgs_TeachingDateENT.updDate = objvgs_TeachingDateENS.updDate; //修改日期
        objvgs_TeachingDateENT.endDate = objvgs_TeachingDateENS.endDate; //截止日期
        objvgs_TeachingDateENT.startDate = objvgs_TeachingDateENS.startDate; //开始日期
        objvgs_TeachingDateENT.id_CurrEduCls = objvgs_TeachingDateENS.id_CurrEduCls; //教学班流水号
        objvgs_TeachingDateENT.updUser = objvgs_TeachingDateENS.updUser; //修改人
        objvgs_TeachingDateENT.mId = objvgs_TeachingDateENS.mId; //mId
    }
    exports.vgs_TeachingDate_CopyObjTo = vgs_TeachingDate_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objvgs_TeachingDateENS:源对象
     * @param objvgs_TeachingDateENT:目标对象
    */
    function vgs_TeachingDate_GetObjFromJsonObj(objvgs_TeachingDateENS) {
        const objvgs_TeachingDateENT = new clsvgs_TeachingDateEN_js_1.clsvgs_TeachingDateEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvgs_TeachingDateENT, objvgs_TeachingDateENS);
        return objvgs_TeachingDateENT;
    }
    exports.vgs_TeachingDate_GetObjFromJsonObj = vgs_TeachingDate_GetObjFromJsonObj;
});
