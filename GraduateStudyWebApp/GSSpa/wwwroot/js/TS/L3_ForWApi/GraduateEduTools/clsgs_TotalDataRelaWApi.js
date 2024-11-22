/**
* 类名:clsgs_TotalDataRelaWApi
* 表名:gs_TotalDataRela(01120700)
* 生成代码版本:2022.11.02.1
* 生成日期:2022/11/02 11:47:10
* 生成者:pyf
* 生成服务器IP:
工程名称:问卷调查(0112)
CM工程:研究生论文学习(变量首字母小写)-全部函数集
* 相关数据库:103.116.76.183,9433EduHigh_Jsie
* PrjDataBaseId:0170
模块中文名:研培设置(GraduateEduTools)
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
        define(["require", "exports", "axios", "../../PubFun/CacheHelper.js", "../../L0_Entity/GraduateEduTools/clsgs_TotalDataRelaEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsSysPara4WebApi.js", "../../PubFun/CacheHelper.js", "../../PubFun/jsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.gs_TotalDataRela_GetObjFromJsonObj = exports.gs_TotalDataRela_CopyObjTo = exports.gs_TotalDataRela_GetUniCondStr4Update_mId = exports.gs_TotalDataRela_GetUniCondStr_mId = exports.gs_TotalDataRela_GetCombineCondition = exports.gs_TotalDataRela_GetObjByJSONStr = exports.gs_TotalDataRela_GetObjLstByJSONObjLst = exports.gs_TotalDataRela_GetObjLstByJSONStr = exports.gs_TotalDataRela_GetJSONStrByObj = exports.gs_TotalDataRela_CheckProperty4Update = exports.gs_TotalDataRela_CheckPropertyNew = exports.gs_TotalDataRela_ReFreshThisCache = exports.gs_TotalDataRela_ReFreshCache = exports.gs_TotalDataRela_GetWebApiUrl = exports.gs_TotalDataRela_GetMaxStrIdByPrefix = exports.gs_TotalDataRela_GetRecCountByCond_Cache = exports.gs_TotalDataRela_GetRecCountByCondAsync = exports.gs_TotalDataRela_IsExistAsync = exports.gs_TotalDataRela_IsExist_Cache = exports.gs_TotalDataRela_IsExist = exports.gs_TotalDataRela_IsExistRecordAsync = exports.gs_TotalDataRela_IsExistRecord_Cache = exports.gs_TotalDataRela_UpdateWithConditionAsync = exports.gs_TotalDataRela_UpdateRecordAsync = exports.gs_TotalDataRela_AddNewRecordWithReturnKey = exports.gs_TotalDataRela_AddNewRecordWithReturnKeyAsync = exports.gs_TotalDataRela_AddNewRecordAsync = exports.gs_TotalDataRela_Delgs_TotalDataRelasByCondAsync = exports.gs_TotalDataRela_Delgs_TotalDataRelasAsync = exports.gs_TotalDataRela_DelRecordAsync = exports.gs_TotalDataRela_GetObjLstByPagerAsync = exports.gs_TotalDataRela_GetObjLstByPager_Cache = exports.gs_TotalDataRela_GetObjLstByRange = exports.gs_TotalDataRela_GetObjLstByRangeAsync = exports.gs_TotalDataRela_GetTopObjLstAsync = exports.gs_TotalDataRela_GetObjLstBymIdLst_Cache = exports.gs_TotalDataRela_GetObjLstBymIdLstAsync = exports.gs_TotalDataRela_GetSubObjLst_Cache = exports.gs_TotalDataRela_GetObjLst_PureCache = exports.gs_TotalDataRela_GetObjLst_Cache = exports.gs_TotalDataRela_GetObjLst_sessionStorage_PureCache = exports.gs_TotalDataRela_GetObjLst_sessionStorage = exports.gs_TotalDataRela_GetObjLstAsync = exports.gs_TotalDataRela_GetObjLst_localStorage_PureCache = exports.gs_TotalDataRela_GetObjLst_localStorage = exports.gs_TotalDataRela_GetObjLst_ClientCache = exports.gs_TotalDataRela_GetFirstObjAsync = exports.gs_TotalDataRela_GetFirstID = exports.gs_TotalDataRela_GetFirstIDAsync = exports.gs_TotalDataRela_FilterFunByKey = exports.gs_TotalDataRela_SortFunByKey = exports.gs_TotalDataRela_SortFun_Defa_2Fld = exports.gs_TotalDataRela_SortFun_Defa = exports.gs_TotalDataRela_func = exports.gs_TotalDataRela_UpdateObjInLst_Cache = exports.gs_TotalDataRela_GetObjBymId_localStorage = exports.gs_TotalDataRela_GetObjBymId_Cache = exports.gs_TotalDataRela_GetObjBymIdAsync = exports.gs_TotalDataRela_ConstructorName = exports.gs_TotalDataRela_Controller = void 0;
    /**
     * 各观点总数据关系表(gs_TotalDataRela)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2022年11月02日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsgs_TotalDataRelaEN_js_1 = require("../../L0_Entity/GraduateEduTools/clsgs_TotalDataRelaEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    const CacheHelper_js_2 = require("../../PubFun/CacheHelper.js");
    const jsString_js_1 = require("../../PubFun/jsString.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.gs_TotalDataRela_Controller = "gs_TotalDataRelaApi";
    exports.gs_TotalDataRela_ConstructorName = "gs_TotalDataRela";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param lngmId:关键字
    * @returns 对象
    **/
    async function gs_TotalDataRela_GetObjBymIdAsync(lngmId) {
        const strThisFuncName = "GetObjBymIdAsync";
        if (lngmId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngmId]不能为空！(In GetObjBymIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjBymId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TotalDataRela_Controller, strAction);
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
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_TotalDataRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objgs_TotalDataRela = gs_TotalDataRela_GetObjFromJsonObj(returnObj);
                return objgs_TotalDataRela;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TotalDataRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TotalDataRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TotalDataRela_GetObjBymIdAsync = gs_TotalDataRela_GetObjBymIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param lngmId:所给的关键字
     * @returns 对象
    */
    async function gs_TotalDataRela_GetObjBymId_Cache(lngmId, strid_CurrEduCls, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjBymId_Cache";
        if (lngmId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngmId]不能为空！(In GetObjBymId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        const arrgs_TotalDataRelaObjLst_Cache = await gs_TotalDataRela_GetObjLst_Cache(strid_CurrEduCls);
        try {
            const arrgs_TotalDataRela_Sel = arrgs_TotalDataRelaObjLst_Cache.filter(x => x.mId == lngmId);
            let objgs_TotalDataRela;
            if (arrgs_TotalDataRela_Sel.length > 0) {
                objgs_TotalDataRela = arrgs_TotalDataRela_Sel[0];
                return objgs_TotalDataRela;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    objgs_TotalDataRela = await gs_TotalDataRela_GetObjBymIdAsync(lngmId);
                    if (objgs_TotalDataRela != null) {
                        gs_TotalDataRela_ReFreshThisCache(strid_CurrEduCls);
                        return objgs_TotalDataRela;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngmId, exports.gs_TotalDataRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.gs_TotalDataRela_GetObjBymId_Cache = gs_TotalDataRela_GetObjBymId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param lngmId:所给的关键字
     * @returns 对象
    */
    async function gs_TotalDataRela_GetObjBymId_localStorage(lngmId) {
        const strThisFuncName = "GetObjBymId_localStorage";
        if (lngmId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngmId]不能为空！(In GetObjBymId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsgs_TotalDataRelaEN_js_1.clsgs_TotalDataRelaEN._CurrTabName, lngmId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objgs_TotalDataRela_Cache = JSON.parse(strTempObj);
            return objgs_TotalDataRela_Cache;
        }
        try {
            const objgs_TotalDataRela = await gs_TotalDataRela_GetObjBymIdAsync(lngmId);
            if (objgs_TotalDataRela != null) {
                localStorage.setItem(strKey, JSON.stringify(objgs_TotalDataRela));
                const strInfo = (0, clsString_js_1.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objgs_TotalDataRela;
            }
            return objgs_TotalDataRela;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngmId, exports.gs_TotalDataRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.gs_TotalDataRela_GetObjBymId_localStorage = gs_TotalDataRela_GetObjBymId_localStorage;
    /**
     * 修改在缓存对象列表中的对象, 与后台数据库无关.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
     * @param objgs_TotalDataRela:所给的对象
     * @returns 对象
    */
    async function gs_TotalDataRela_UpdateObjInLst_Cache(objgs_TotalDataRela, strid_CurrEduCls) {
        const strThisFuncName = "UpdateObjInLst_Cache";
        try {
            const arrgs_TotalDataRelaObjLst_Cache = await gs_TotalDataRela_GetObjLst_Cache(strid_CurrEduCls);
            const obj = arrgs_TotalDataRelaObjLst_Cache.find(x => x.mId == objgs_TotalDataRela.mId);
            if (obj != null) {
                objgs_TotalDataRela.mId = obj.mId;
                (0, clsCommFunc4Web_js_1.ObjectAssign)(obj, objgs_TotalDataRela);
            }
            else {
                arrgs_TotalDataRelaObjLst_Cache.push(objgs_TotalDataRela);
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, exports.gs_TotalDataRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.gs_TotalDataRela_UpdateObjInLst_Cache = gs_TotalDataRela_UpdateObjInLst_Cache;
    /*该表没有名称字段，不能生成此函数！*/
    /**
     * 映射函数。根据表映射把输入字段值，映射成输出字段值
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_func)
     * @param strInFldName:输入字段名
     * @param strOutFldName:输出字段名
     * @param strInValue:输入字段值
     @param strid_CurrEduCls:缓存的分类字段
     * @returns 返回一个输出字段值
    */
    async function gs_TotalDataRela_func(strInFldName, strOutFldName, strInValue, strid_CurrEduCls_C) {
        //const strThisFuncName = "func";
        if ((0, clsString_js_1.IsNullOrEmpty)(strid_CurrEduCls_C) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strid_CurrEduCls_C]不能为空！(In func)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls_C.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strid_CurrEduCls_C]的长度:[{0}]不正确！", strid_CurrEduCls_C.length);
            console.error(strMsg);
            throw (strMsg);
        }
        if (strInFldName != clsgs_TotalDataRelaEN_js_1.clsgs_TotalDataRelaEN.con_mId) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsgs_TotalDataRelaEN_js_1.clsgs_TotalDataRelaEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_1.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strInFldName, clsgs_TotalDataRelaEN_js_1.clsgs_TotalDataRelaEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const lngmId = Number(strInValue);
        if (lngmId == 0) {
            return "";
        }
        const objgs_TotalDataRela = await gs_TotalDataRela_GetObjBymId_Cache(lngmId, strid_CurrEduCls_C);
        if (objgs_TotalDataRela == null)
            return "";
        return objgs_TotalDataRela.GetFldValue(strOutFldName).toString();
    }
    exports.gs_TotalDataRela_func = gs_TotalDataRela_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function gs_TotalDataRela_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.mId - b.mId;
    }
    exports.gs_TotalDataRela_SortFun_Defa = gs_TotalDataRela_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function gs_TotalDataRela_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.id_CurrEduCls == b.id_CurrEduCls)
            return a.updDate.localeCompare(b.updDate);
        else
            return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
    }
    exports.gs_TotalDataRela_SortFun_Defa_2Fld = gs_TotalDataRela_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function gs_TotalDataRela_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsgs_TotalDataRelaEN_js_1.clsgs_TotalDataRelaEN.con_mId:
                    return (a, b) => {
                        return a.mId - b.mId;
                    };
                case clsgs_TotalDataRelaEN_js_1.clsgs_TotalDataRelaEN.con_id_CurrEduCls:
                    return (a, b) => {
                        return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
                    };
                case clsgs_TotalDataRelaEN_js_1.clsgs_TotalDataRelaEN.con_UpdDate:
                    return (a, b) => {
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsgs_TotalDataRelaEN_js_1.clsgs_TotalDataRelaEN.con_UpdUser:
                    return (a, b) => {
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsgs_TotalDataRelaEN_js_1.clsgs_TotalDataRelaEN.con_Memo:
                    return (a, b) => {
                        return a.memo.localeCompare(b.memo);
                    };
                case clsgs_TotalDataRelaEN_js_1.clsgs_TotalDataRelaEN.con_TDRelaTypeId:
                    return (a, b) => {
                        return a.tdRelaTypeId.localeCompare(b.tdRelaTypeId);
                    };
                case clsgs_TotalDataRelaEN_js_1.clsgs_TotalDataRelaEN.con_TotalDataId1:
                    return (a, b) => {
                        return a.totalDataId1.localeCompare(b.totalDataId1);
                    };
                case clsgs_TotalDataRelaEN_js_1.clsgs_TotalDataRelaEN.con_TotalDataId2:
                    return (a, b) => {
                        return a.totalDataId2.localeCompare(b.totalDataId2);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[gs_TotalDataRela]中不存在！(in ${exports.gs_TotalDataRela_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsgs_TotalDataRelaEN_js_1.clsgs_TotalDataRelaEN.con_mId:
                    return (a, b) => {
                        return b.mId - a.mId;
                    };
                case clsgs_TotalDataRelaEN_js_1.clsgs_TotalDataRelaEN.con_id_CurrEduCls:
                    return (a, b) => {
                        return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
                    };
                case clsgs_TotalDataRelaEN_js_1.clsgs_TotalDataRelaEN.con_UpdDate:
                    return (a, b) => {
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsgs_TotalDataRelaEN_js_1.clsgs_TotalDataRelaEN.con_UpdUser:
                    return (a, b) => {
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsgs_TotalDataRelaEN_js_1.clsgs_TotalDataRelaEN.con_Memo:
                    return (a, b) => {
                        return b.memo.localeCompare(a.memo);
                    };
                case clsgs_TotalDataRelaEN_js_1.clsgs_TotalDataRelaEN.con_TDRelaTypeId:
                    return (a, b) => {
                        return b.tdRelaTypeId.localeCompare(a.tdRelaTypeId);
                    };
                case clsgs_TotalDataRelaEN_js_1.clsgs_TotalDataRelaEN.con_TotalDataId1:
                    return (a, b) => {
                        return b.totalDataId1.localeCompare(a.totalDataId1);
                    };
                case clsgs_TotalDataRelaEN_js_1.clsgs_TotalDataRelaEN.con_TotalDataId2:
                    return (a, b) => {
                        return b.totalDataId2.localeCompare(a.totalDataId2);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[gs_TotalDataRela]中不存在！(in ${exports.gs_TotalDataRela_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.gs_TotalDataRela_SortFunByKey = gs_TotalDataRela_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function gs_TotalDataRela_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsgs_TotalDataRelaEN_js_1.clsgs_TotalDataRelaEN.con_mId:
                return (obj) => {
                    return obj.mId === value;
                };
            case clsgs_TotalDataRelaEN_js_1.clsgs_TotalDataRelaEN.con_id_CurrEduCls:
                return (obj) => {
                    return obj.id_CurrEduCls === value;
                };
            case clsgs_TotalDataRelaEN_js_1.clsgs_TotalDataRelaEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsgs_TotalDataRelaEN_js_1.clsgs_TotalDataRelaEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsgs_TotalDataRelaEN_js_1.clsgs_TotalDataRelaEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            case clsgs_TotalDataRelaEN_js_1.clsgs_TotalDataRelaEN.con_TDRelaTypeId:
                return (obj) => {
                    return obj.tdRelaTypeId === value;
                };
            case clsgs_TotalDataRelaEN_js_1.clsgs_TotalDataRelaEN.con_TotalDataId1:
                return (obj) => {
                    return obj.totalDataId1 === value;
                };
            case clsgs_TotalDataRelaEN_js_1.clsgs_TotalDataRelaEN.con_TotalDataId2:
                return (obj) => {
                    return obj.totalDataId2 === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[gs_TotalDataRela]中不存在！(in ${exports.gs_TotalDataRela_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.gs_TotalDataRela_FilterFunByKey = gs_TotalDataRela_FilterFunByKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function gs_TotalDataRela_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TotalDataRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TotalDataRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TotalDataRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TotalDataRela_GetFirstIDAsync = gs_TotalDataRela_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function gs_TotalDataRela_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TotalDataRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TotalDataRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TotalDataRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TotalDataRela_GetFirstID = gs_TotalDataRela_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function gs_TotalDataRela_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TotalDataRela_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_TotalDataRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objgs_TotalDataRela = gs_TotalDataRela_GetObjFromJsonObj(returnObj);
                return objgs_TotalDataRela;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TotalDataRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TotalDataRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TotalDataRela_GetFirstObjAsync = gs_TotalDataRela_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_TotalDataRela_GetObjLst_ClientCache(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsgs_TotalDataRelaEN_js_1.clsgs_TotalDataRelaEN._CurrTabName, strid_CurrEduCls);
        clsgs_TotalDataRelaEN_js_1.clsgs_TotalDataRelaEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsgs_TotalDataRelaEN_js_1.clsgs_TotalDataRelaEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsgs_TotalDataRelaEN_js_1.clsgs_TotalDataRelaEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsgs_TotalDataRelaEN_js_1.clsgs_TotalDataRelaEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_2.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrgs_TotalDataRelaExObjLst_Cache = CacheHelper_js_2.CacheHelper.Get(strKey);
            const arrgs_TotalDataRelaObjLst_T = gs_TotalDataRela_GetObjLstByJSONObjLst(arrgs_TotalDataRelaExObjLst_Cache);
            return arrgs_TotalDataRelaObjLst_T;
        }
        try {
            const arrgs_TotalDataRelaExObjLst = await gs_TotalDataRela_GetObjLstAsync(strWhereCond);
            CacheHelper_js_2.CacheHelper.Add(strKey, arrgs_TotalDataRelaExObjLst);
            const strInfo = (0, clsString_js_1.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_TotalDataRelaExObjLst.length);
            console.log(strInfo);
            return arrgs_TotalDataRelaExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.gs_TotalDataRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.gs_TotalDataRela_GetObjLst_ClientCache = gs_TotalDataRela_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_TotalDataRela_GetObjLst_localStorage(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsgs_TotalDataRelaEN_js_1.clsgs_TotalDataRelaEN._CurrTabName, strid_CurrEduCls);
        clsgs_TotalDataRelaEN_js_1.clsgs_TotalDataRelaEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsgs_TotalDataRelaEN_js_1.clsgs_TotalDataRelaEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsgs_TotalDataRelaEN_js_1.clsgs_TotalDataRelaEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsgs_TotalDataRelaEN_js_1.clsgs_TotalDataRelaEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrgs_TotalDataRelaExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrgs_TotalDataRelaObjLst_T = gs_TotalDataRela_GetObjLstByJSONObjLst(arrgs_TotalDataRelaExObjLst_Cache);
            return arrgs_TotalDataRelaObjLst_T;
        }
        try {
            const arrgs_TotalDataRelaExObjLst = await gs_TotalDataRela_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrgs_TotalDataRelaExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_TotalDataRelaExObjLst.length);
            console.log(strInfo);
            return arrgs_TotalDataRelaExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.gs_TotalDataRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.gs_TotalDataRela_GetObjLst_localStorage = gs_TotalDataRela_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_TotalDataRela_GetObjLst_localStorage_PureCache(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsgs_TotalDataRelaEN_js_1.clsgs_TotalDataRelaEN._CurrTabName, strid_CurrEduCls);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrgs_TotalDataRelaObjLst_Cache = JSON.parse(strTempObjLst);
            return arrgs_TotalDataRelaObjLst_Cache;
        }
        else
            return null;
    }
    exports.gs_TotalDataRela_GetObjLst_localStorage_PureCache = gs_TotalDataRela_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function gs_TotalDataRela_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TotalDataRela_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_TotalDataRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_TotalDataRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TotalDataRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TotalDataRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TotalDataRela_GetObjLstAsync = gs_TotalDataRela_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_TotalDataRela_GetObjLst_sessionStorage(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsgs_TotalDataRelaEN_js_1.clsgs_TotalDataRelaEN._CurrTabName, strid_CurrEduCls);
        clsgs_TotalDataRelaEN_js_1.clsgs_TotalDataRelaEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsgs_TotalDataRelaEN_js_1.clsgs_TotalDataRelaEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsgs_TotalDataRelaEN_js_1.clsgs_TotalDataRelaEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsgs_TotalDataRelaEN_js_1.clsgs_TotalDataRelaEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrgs_TotalDataRelaExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrgs_TotalDataRelaObjLst_T = gs_TotalDataRela_GetObjLstByJSONObjLst(arrgs_TotalDataRelaExObjLst_Cache);
            return arrgs_TotalDataRelaObjLst_T;
        }
        try {
            const arrgs_TotalDataRelaExObjLst = await gs_TotalDataRela_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrgs_TotalDataRelaExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_TotalDataRelaExObjLst.length);
            console.log(strInfo);
            return arrgs_TotalDataRelaExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.gs_TotalDataRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.gs_TotalDataRela_GetObjLst_sessionStorage = gs_TotalDataRela_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_TotalDataRela_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsgs_TotalDataRelaEN_js_1.clsgs_TotalDataRelaEN._CurrTabName, strid_CurrEduCls);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrgs_TotalDataRelaObjLst_Cache = JSON.parse(strTempObjLst);
            return arrgs_TotalDataRelaObjLst_Cache;
        }
        else
            return null;
    }
    exports.gs_TotalDataRela_GetObjLst_sessionStorage_PureCache = gs_TotalDataRela_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_TotalDataRela_GetObjLst_Cache(strid_CurrEduCls) {
        //const strThisFuncName = "GetObjLst_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strid_CurrEduCls) == true) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[id_CurrEduCls]不能为空！");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strid_CurrEduCls]的长度:[{0}]不正确！", strid_CurrEduCls.length);
            console.error(strMsg);
            throw (strMsg);
        }
        let arrgs_TotalDataRelaObjLst_Cache;
        switch (clsgs_TotalDataRelaEN_js_1.clsgs_TotalDataRelaEN.CacheModeId) {
            case "04": //sessionStorage
                arrgs_TotalDataRelaObjLst_Cache = await gs_TotalDataRela_GetObjLst_sessionStorage(strid_CurrEduCls);
                break;
            case "03": //localStorage
                arrgs_TotalDataRelaObjLst_Cache = await gs_TotalDataRela_GetObjLst_localStorage(strid_CurrEduCls);
                break;
            case "02": //ClientCache
                arrgs_TotalDataRelaObjLst_Cache = await gs_TotalDataRela_GetObjLst_ClientCache(strid_CurrEduCls);
                break;
            default:
                arrgs_TotalDataRelaObjLst_Cache = await gs_TotalDataRela_GetObjLst_ClientCache(strid_CurrEduCls);
                break;
        }
        const arrgs_TotalDataRelaObjLst = gs_TotalDataRela_GetObjLstByJSONObjLst(arrgs_TotalDataRelaObjLst_Cache);
        return arrgs_TotalDataRelaObjLst_Cache;
    }
    exports.gs_TotalDataRela_GetObjLst_Cache = gs_TotalDataRela_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_TotalDataRela_GetObjLst_PureCache(strid_CurrEduCls) {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrgs_TotalDataRelaObjLst_Cache;
        switch (clsgs_TotalDataRelaEN_js_1.clsgs_TotalDataRelaEN.CacheModeId) {
            case "04": //sessionStorage
                arrgs_TotalDataRelaObjLst_Cache = await gs_TotalDataRela_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls);
                break;
            case "03": //localStorage
                arrgs_TotalDataRelaObjLst_Cache = await gs_TotalDataRela_GetObjLst_localStorage_PureCache(strid_CurrEduCls);
                break;
            case "02": //ClientCache
                arrgs_TotalDataRelaObjLst_Cache = null;
                break;
            default:
                arrgs_TotalDataRelaObjLst_Cache = null;
                break;
        }
        return arrgs_TotalDataRelaObjLst_Cache;
    }
    exports.gs_TotalDataRela_GetObjLst_PureCache = gs_TotalDataRela_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objlngmId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function gs_TotalDataRela_GetSubObjLst_Cache(objgs_TotalDataRela_Cond, strid_CurrEduCls) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrgs_TotalDataRelaObjLst_Cache = await gs_TotalDataRela_GetObjLst_Cache(strid_CurrEduCls);
        let arrgs_TotalDataRela_Sel = arrgs_TotalDataRelaObjLst_Cache;
        if (objgs_TotalDataRela_Cond.sf_FldComparisonOp == null || objgs_TotalDataRela_Cond.sf_FldComparisonOp == "")
            return arrgs_TotalDataRela_Sel;
        const dicFldComparisonOp = JSON.parse(objgs_TotalDataRela_Cond.sf_FldComparisonOp);
        //console.log("clsgs_TotalDataRelaWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objgs_TotalDataRela_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrgs_TotalDataRela_Sel = arrgs_TotalDataRela_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objgs_TotalDataRela_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_TotalDataRela_Sel = arrgs_TotalDataRela_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrgs_TotalDataRela_Sel = arrgs_TotalDataRela_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_TotalDataRela_Sel = arrgs_TotalDataRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_TotalDataRela_Sel = arrgs_TotalDataRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrgs_TotalDataRela_Sel = arrgs_TotalDataRela_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrgs_TotalDataRela_Sel = arrgs_TotalDataRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrgs_TotalDataRela_Sel = arrgs_TotalDataRela_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrgs_TotalDataRela_Sel = arrgs_TotalDataRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrgs_TotalDataRela_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objgs_TotalDataRela_Cond), exports.gs_TotalDataRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.gs_TotalDataRela_GetSubObjLst_Cache = gs_TotalDataRela_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrmId:关键字列表
    * @returns 对象列表
    **/
    async function gs_TotalDataRela_GetObjLstBymIdLstAsync(arrmId) {
        const strThisFuncName = "GetObjLstBymIdLstAsync";
        const strAction = "GetObjLstBymIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TotalDataRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrmId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_TotalDataRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_TotalDataRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TotalDataRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TotalDataRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TotalDataRela_GetObjLstBymIdLstAsync = gs_TotalDataRela_GetObjLstBymIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrlngmIdLst:关键字列表
     * @returns 对象列表
    */
    async function gs_TotalDataRela_GetObjLstBymIdLst_Cache(arrmIdLst, strid_CurrEduCls) {
        const strThisFuncName = "GetObjLstBymIdLst_Cache";
        try {
            const arrgs_TotalDataRelaObjLst_Cache = await gs_TotalDataRela_GetObjLst_Cache(strid_CurrEduCls);
            const arrgs_TotalDataRela_Sel = arrgs_TotalDataRelaObjLst_Cache.filter(x => arrmIdLst.indexOf(x.mId) > -1);
            return arrgs_TotalDataRela_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrmIdLst.join(","), exports.gs_TotalDataRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.gs_TotalDataRela_GetObjLstBymIdLst_Cache = gs_TotalDataRela_GetObjLstBymIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function gs_TotalDataRela_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TotalDataRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_TotalDataRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_TotalDataRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TotalDataRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TotalDataRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TotalDataRela_GetTopObjLstAsync = gs_TotalDataRela_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function gs_TotalDataRela_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TotalDataRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_TotalDataRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_TotalDataRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TotalDataRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TotalDataRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TotalDataRela_GetObjLstByRangeAsync = gs_TotalDataRela_GetObjLstByRangeAsync;
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
    async function gs_TotalDataRela_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TotalDataRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TotalDataRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TotalDataRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TotalDataRela_GetObjLstByRange = gs_TotalDataRela_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function gs_TotalDataRela_GetObjLstByPager_Cache(objPagerPara, strid_CurrEduCls) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const arrgs_TotalDataRelaObjLst_Cache = await gs_TotalDataRela_GetObjLst_Cache(strid_CurrEduCls);
        if (arrgs_TotalDataRelaObjLst_Cache.length == 0)
            return arrgs_TotalDataRelaObjLst_Cache;
        let arrgs_TotalDataRela_Sel = arrgs_TotalDataRelaObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objgs_TotalDataRela_Cond = new clsgs_TotalDataRelaEN_js_1.clsgs_TotalDataRelaEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objgs_TotalDataRela_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsgs_TotalDataRelaWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrgs_TotalDataRela_Sel = arrgs_TotalDataRela_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objgs_TotalDataRela_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_TotalDataRela_Sel = arrgs_TotalDataRela_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrgs_TotalDataRela_Sel = arrgs_TotalDataRela_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrgs_TotalDataRela_Sel = arrgs_TotalDataRela_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_TotalDataRela_Sel = arrgs_TotalDataRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_TotalDataRela_Sel = arrgs_TotalDataRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrgs_TotalDataRela_Sel = arrgs_TotalDataRela_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrgs_TotalDataRela_Sel = arrgs_TotalDataRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrgs_TotalDataRela_Sel = arrgs_TotalDataRela_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrgs_TotalDataRela_Sel = arrgs_TotalDataRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrgs_TotalDataRela_Sel.length == 0)
                return arrgs_TotalDataRela_Sel;
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
                arrgs_TotalDataRela_Sel = arrgs_TotalDataRela_Sel.sort(gs_TotalDataRela_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrgs_TotalDataRela_Sel = arrgs_TotalDataRela_Sel.sort(objPagerPara.sortFun);
            }
            arrgs_TotalDataRela_Sel = arrgs_TotalDataRela_Sel.slice(intStart, intEnd);
            return arrgs_TotalDataRela_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.gs_TotalDataRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.gs_TotalDataRela_GetObjLstByPager_Cache = gs_TotalDataRela_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function gs_TotalDataRela_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TotalDataRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_TotalDataRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_TotalDataRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TotalDataRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TotalDataRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TotalDataRela_GetObjLstByPagerAsync = gs_TotalDataRela_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param lngmId:关键字
    * @returns 获取删除的结果
    **/
    async function gs_TotalDataRela_DelRecordAsync(lngmId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TotalDataRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TotalDataRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TotalDataRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TotalDataRela_DelRecordAsync = gs_TotalDataRela_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrmId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function gs_TotalDataRela_Delgs_TotalDataRelasAsync(arrmId) {
        const strThisFuncName = "Delgs_TotalDataRelasAsync";
        const strAction = "Delgs_TotalDataRelas";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TotalDataRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TotalDataRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TotalDataRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TotalDataRela_Delgs_TotalDataRelasAsync = gs_TotalDataRela_Delgs_TotalDataRelasAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function gs_TotalDataRela_Delgs_TotalDataRelasByCondAsync(strWhereCond) {
        const strThisFuncName = "Delgs_TotalDataRelasByCondAsync";
        const strAction = "Delgs_TotalDataRelasByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TotalDataRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TotalDataRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TotalDataRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TotalDataRela_Delgs_TotalDataRelasByCondAsync = gs_TotalDataRela_Delgs_TotalDataRelasByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objgs_TotalDataRelaEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function gs_TotalDataRela_AddNewRecordAsync(objgs_TotalDataRelaEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objgs_TotalDataRelaEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TotalDataRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_TotalDataRelaEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TotalDataRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TotalDataRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TotalDataRela_AddNewRecordAsync = gs_TotalDataRela_AddNewRecordAsync;
    /* 数据类型不是字符型，不可以最大关键字的方式添加记录。*/
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objgs_TotalDataRelaEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function gs_TotalDataRela_AddNewRecordWithReturnKeyAsync(objgs_TotalDataRelaEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TotalDataRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_TotalDataRelaEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TotalDataRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TotalDataRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TotalDataRela_AddNewRecordWithReturnKeyAsync = gs_TotalDataRela_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objgs_TotalDataRelaEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function gs_TotalDataRela_AddNewRecordWithReturnKey(objgs_TotalDataRelaEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objgs_TotalDataRelaEN.mId === null || objgs_TotalDataRelaEN.mId === 0) {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TotalDataRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_TotalDataRelaEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TotalDataRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TotalDataRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TotalDataRela_AddNewRecordWithReturnKey = gs_TotalDataRela_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objgs_TotalDataRelaEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function gs_TotalDataRela_UpdateRecordAsync(objgs_TotalDataRelaEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objgs_TotalDataRelaEN.sf_UpdFldSetStr === undefined || objgs_TotalDataRelaEN.sf_UpdFldSetStr === null || objgs_TotalDataRelaEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_TotalDataRelaEN.mId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TotalDataRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_TotalDataRelaEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TotalDataRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TotalDataRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TotalDataRela_UpdateRecordAsync = gs_TotalDataRela_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objgs_TotalDataRelaEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function gs_TotalDataRela_UpdateWithConditionAsync(objgs_TotalDataRelaEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objgs_TotalDataRelaEN.sf_UpdFldSetStr === undefined || objgs_TotalDataRelaEN.sf_UpdFldSetStr === null || objgs_TotalDataRelaEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_TotalDataRelaEN.mId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TotalDataRela_Controller, strAction);
        objgs_TotalDataRelaEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objgs_TotalDataRelaEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TotalDataRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TotalDataRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TotalDataRela_UpdateWithConditionAsync = gs_TotalDataRela_UpdateWithConditionAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objlngmId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function gs_TotalDataRela_IsExistRecord_Cache(objgs_TotalDataRela_Cond, strid_CurrEduCls) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrgs_TotalDataRelaObjLst_Cache = await gs_TotalDataRela_GetObjLst_Cache(strid_CurrEduCls);
        if (arrgs_TotalDataRelaObjLst_Cache == null)
            return false;
        let arrgs_TotalDataRela_Sel = arrgs_TotalDataRelaObjLst_Cache;
        if (objgs_TotalDataRela_Cond.sf_FldComparisonOp == null || objgs_TotalDataRela_Cond.sf_FldComparisonOp == "")
            return arrgs_TotalDataRela_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objgs_TotalDataRela_Cond.sf_FldComparisonOp);
        //console.log("clsgs_TotalDataRelaWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objgs_TotalDataRela_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objgs_TotalDataRela_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_TotalDataRela_Sel = arrgs_TotalDataRela_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrgs_TotalDataRela_Sel = arrgs_TotalDataRela_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_TotalDataRela_Sel = arrgs_TotalDataRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_TotalDataRela_Sel = arrgs_TotalDataRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrgs_TotalDataRela_Sel = arrgs_TotalDataRela_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrgs_TotalDataRela_Sel = arrgs_TotalDataRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrgs_TotalDataRela_Sel = arrgs_TotalDataRela_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrgs_TotalDataRela_Sel = arrgs_TotalDataRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrgs_TotalDataRela_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objgs_TotalDataRela_Cond), exports.gs_TotalDataRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.gs_TotalDataRela_IsExistRecord_Cache = gs_TotalDataRela_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function gs_TotalDataRela_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TotalDataRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TotalDataRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TotalDataRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TotalDataRela_IsExistRecordAsync = gs_TotalDataRela_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param lngmId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function gs_TotalDataRela_IsExist(lngmId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TotalDataRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TotalDataRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TotalDataRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TotalDataRela_IsExist = gs_TotalDataRela_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param lngmId:所给的关键字
     * @returns 对象
    */
    async function gs_TotalDataRela_IsExist_Cache(lngmId, strid_CurrEduCls) {
        const strThisFuncName = "IsExist_Cache";
        const arrgs_TotalDataRelaObjLst_Cache = await gs_TotalDataRela_GetObjLst_Cache(strid_CurrEduCls);
        if (arrgs_TotalDataRelaObjLst_Cache == null)
            return false;
        try {
            const arrgs_TotalDataRela_Sel = arrgs_TotalDataRelaObjLst_Cache.filter(x => x.mId == lngmId);
            if (arrgs_TotalDataRela_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", lngmId, exports.gs_TotalDataRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.gs_TotalDataRela_IsExist_Cache = gs_TotalDataRela_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param lngmId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function gs_TotalDataRela_IsExistAsync(lngmId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TotalDataRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TotalDataRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TotalDataRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TotalDataRela_IsExistAsync = gs_TotalDataRela_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function gs_TotalDataRela_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TotalDataRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TotalDataRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TotalDataRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TotalDataRela_GetRecCountByCondAsync = gs_TotalDataRela_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objgs_TotalDataRela_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function gs_TotalDataRela_GetRecCountByCond_Cache(objgs_TotalDataRela_Cond, strid_CurrEduCls) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrgs_TotalDataRelaObjLst_Cache = await gs_TotalDataRela_GetObjLst_Cache(strid_CurrEduCls);
        if (arrgs_TotalDataRelaObjLst_Cache == null)
            return 0;
        let arrgs_TotalDataRela_Sel = arrgs_TotalDataRelaObjLst_Cache;
        if (objgs_TotalDataRela_Cond.sf_FldComparisonOp == null || objgs_TotalDataRela_Cond.sf_FldComparisonOp == "")
            return arrgs_TotalDataRela_Sel.length;
        const dicFldComparisonOp = JSON.parse(objgs_TotalDataRela_Cond.sf_FldComparisonOp);
        //console.log("clsgs_TotalDataRelaWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objgs_TotalDataRela_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrgs_TotalDataRela_Sel = arrgs_TotalDataRela_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objgs_TotalDataRela_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_TotalDataRela_Sel = arrgs_TotalDataRela_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrgs_TotalDataRela_Sel = arrgs_TotalDataRela_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrgs_TotalDataRela_Sel = arrgs_TotalDataRela_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_TotalDataRela_Sel = arrgs_TotalDataRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_TotalDataRela_Sel = arrgs_TotalDataRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrgs_TotalDataRela_Sel = arrgs_TotalDataRela_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrgs_TotalDataRela_Sel = arrgs_TotalDataRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrgs_TotalDataRela_Sel = arrgs_TotalDataRela_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrgs_TotalDataRela_Sel = arrgs_TotalDataRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrgs_TotalDataRela_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objgs_TotalDataRela_Cond), exports.gs_TotalDataRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.gs_TotalDataRela_GetRecCountByCond_Cache = gs_TotalDataRela_GetRecCountByCond_Cache;
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
    async function gs_TotalDataRela_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TotalDataRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TotalDataRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TotalDataRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TotalDataRela_GetMaxStrIdByPrefix = gs_TotalDataRela_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function gs_TotalDataRela_GetWebApiUrl(strController, strAction) {
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
    exports.gs_TotalDataRela_GetWebApiUrl = gs_TotalDataRela_GetWebApiUrl;
    /**
    * 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshCache)
    **/
    function gs_TotalDataRela_ReFreshCache(strid_CurrEduCls) {
        const strThisFuncName = "ReFreshCache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strid_CurrEduCls) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strid_CurrEduCls]不能为空！(In clsgs_TotalDataRelaWApi.ReFreshCache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strid_CurrEduCls]的长度:[{0}]不正确！", strid_CurrEduCls.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strMsg = (0, clsString_js_1.Format)("刷新缓存成功！");
        console.trace(strMsg);
        // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsgs_TotalDataRelaEN_js_1.clsgs_TotalDataRelaEN._CurrTabName, strid_CurrEduCls);
        switch (clsgs_TotalDataRelaEN_js_1.clsgs_TotalDataRelaEN.CacheModeId) {
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
    exports.gs_TotalDataRela_ReFreshCache = gs_TotalDataRela_ReFreshCache;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function gs_TotalDataRela_ReFreshThisCache(strid_CurrEduCls) {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsgs_TotalDataRelaEN_js_1.clsgs_TotalDataRelaEN._CurrTabName, strid_CurrEduCls);
            switch (clsgs_TotalDataRelaEN_js_1.clsgs_TotalDataRelaEN.CacheModeId) {
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
    exports.gs_TotalDataRela_ReFreshThisCache = gs_TotalDataRela_ReFreshThisCache;
    /* 该表的下拉框功能没有设置，不需要生成下拉框绑定函数。*/
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function gs_TotalDataRela_CheckPropertyNew(pobjgs_TotalDataRelaEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TotalDataRelaEN.id_CurrEduCls) === true
            || pobjgs_TotalDataRelaEN.id_CurrEduCls.toString() === "0") {
            throw new Error("(errid:Watl000058)字段[教学班流水号]不能为空(In 各观点总数据关系表)!(clsgs_TotalDataRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TotalDataRelaEN.totalDataId1) === true) {
            throw new Error("(errid:Watl000058)字段[TotalDataId1]不能为空(In 各观点总数据关系表)!(clsgs_TotalDataRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TotalDataRelaEN.totalDataId2) === true) {
            throw new Error("(errid:Watl000058)字段[TotalDataId2]不能为空(In 各观点总数据关系表)!(clsgs_TotalDataRelaBL:CheckPropertyNew)");
        }
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TotalDataRelaEN.id_CurrEduCls) == false && (0, clsString_js_1.GetStrLen)(pobjgs_TotalDataRelaEN.id_CurrEduCls) > 8) {
            throw new Error("(errid:Watl000059)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 各观点总数据关系表(gs_TotalDataRela))!值:$(pobjgs_TotalDataRelaEN.id_CurrEduCls)(clsgs_TotalDataRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TotalDataRelaEN.updDate) == false && (0, clsString_js_1.GetStrLen)(pobjgs_TotalDataRelaEN.updDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 各观点总数据关系表(gs_TotalDataRela))!值:$(pobjgs_TotalDataRelaEN.updDate)(clsgs_TotalDataRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TotalDataRelaEN.updUser) == false && (0, clsString_js_1.GetStrLen)(pobjgs_TotalDataRelaEN.updUser) > 20) {
            throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 各观点总数据关系表(gs_TotalDataRela))!值:$(pobjgs_TotalDataRelaEN.updUser)(clsgs_TotalDataRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TotalDataRelaEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjgs_TotalDataRelaEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 各观点总数据关系表(gs_TotalDataRela))!值:$(pobjgs_TotalDataRelaEN.memo)(clsgs_TotalDataRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TotalDataRelaEN.tdRelaTypeId) == false && (0, clsString_js_1.GetStrLen)(pobjgs_TotalDataRelaEN.tdRelaTypeId) > 2) {
            throw new Error("(errid:Watl000059)字段[总数据关系类型Id(tdRelaTypeId)]的长度不能超过2(In 各观点总数据关系表(gs_TotalDataRela))!值:$(pobjgs_TotalDataRelaEN.tdRelaTypeId)(clsgs_TotalDataRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TotalDataRelaEN.totalDataId1) == false && (0, clsString_js_1.GetStrLen)(pobjgs_TotalDataRelaEN.totalDataId1) > 12) {
            throw new Error("(errid:Watl000059)字段[TotalDataId1(totalDataId1)]的长度不能超过12(In 各观点总数据关系表(gs_TotalDataRela))!值:$(pobjgs_TotalDataRelaEN.totalDataId1)(clsgs_TotalDataRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TotalDataRelaEN.totalDataId2) == false && (0, clsString_js_1.GetStrLen)(pobjgs_TotalDataRelaEN.totalDataId2) > 12) {
            throw new Error("(errid:Watl000059)字段[TotalDataId2(totalDataId2)]的长度不能超过12(In 各观点总数据关系表(gs_TotalDataRela))!值:$(pobjgs_TotalDataRelaEN.totalDataId2)(clsgs_TotalDataRelaBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if (null != pobjgs_TotalDataRelaEN.mId && undefined !== pobjgs_TotalDataRelaEN.mId && jsString_js_1.tzDataType.isNumber(pobjgs_TotalDataRelaEN.mId) === false) {
            throw new Error("(errid:Watl000060)字段[mId(mId)]的值:[$(pobjgs_TotalDataRelaEN.mId)], 非法，应该为数值型(In 各观点总数据关系表(gs_TotalDataRela))!(clsgs_TotalDataRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TotalDataRelaEN.id_CurrEduCls) == false && undefined !== pobjgs_TotalDataRelaEN.id_CurrEduCls && jsString_js_1.tzDataType.isString(pobjgs_TotalDataRelaEN.id_CurrEduCls) === false) {
            throw new Error("(errid:Watl000060)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjgs_TotalDataRelaEN.id_CurrEduCls)], 非法，应该为字符型(In 各观点总数据关系表(gs_TotalDataRela))!(clsgs_TotalDataRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TotalDataRelaEN.updDate) == false && undefined !== pobjgs_TotalDataRelaEN.updDate && jsString_js_1.tzDataType.isString(pobjgs_TotalDataRelaEN.updDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjgs_TotalDataRelaEN.updDate)], 非法，应该为字符型(In 各观点总数据关系表(gs_TotalDataRela))!(clsgs_TotalDataRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TotalDataRelaEN.updUser) == false && undefined !== pobjgs_TotalDataRelaEN.updUser && jsString_js_1.tzDataType.isString(pobjgs_TotalDataRelaEN.updUser) === false) {
            throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjgs_TotalDataRelaEN.updUser)], 非法，应该为字符型(In 各观点总数据关系表(gs_TotalDataRela))!(clsgs_TotalDataRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TotalDataRelaEN.memo) == false && undefined !== pobjgs_TotalDataRelaEN.memo && jsString_js_1.tzDataType.isString(pobjgs_TotalDataRelaEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjgs_TotalDataRelaEN.memo)], 非法，应该为字符型(In 各观点总数据关系表(gs_TotalDataRela))!(clsgs_TotalDataRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TotalDataRelaEN.tdRelaTypeId) == false && undefined !== pobjgs_TotalDataRelaEN.tdRelaTypeId && jsString_js_1.tzDataType.isString(pobjgs_TotalDataRelaEN.tdRelaTypeId) === false) {
            throw new Error("(errid:Watl000060)字段[总数据关系类型Id(tdRelaTypeId)]的值:[$(pobjgs_TotalDataRelaEN.tdRelaTypeId)], 非法，应该为字符型(In 各观点总数据关系表(gs_TotalDataRela))!(clsgs_TotalDataRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TotalDataRelaEN.totalDataId1) == false && undefined !== pobjgs_TotalDataRelaEN.totalDataId1 && jsString_js_1.tzDataType.isString(pobjgs_TotalDataRelaEN.totalDataId1) === false) {
            throw new Error("(errid:Watl000060)字段[TotalDataId1(totalDataId1)]的值:[$(pobjgs_TotalDataRelaEN.totalDataId1)], 非法，应该为字符型(In 各观点总数据关系表(gs_TotalDataRela))!(clsgs_TotalDataRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TotalDataRelaEN.totalDataId2) == false && undefined !== pobjgs_TotalDataRelaEN.totalDataId2 && jsString_js_1.tzDataType.isString(pobjgs_TotalDataRelaEN.totalDataId2) === false) {
            throw new Error("(errid:Watl000060)字段[TotalDataId2(totalDataId2)]的值:[$(pobjgs_TotalDataRelaEN.totalDataId2)], 非法，应该为字符型(In 各观点总数据关系表(gs_TotalDataRela))!(clsgs_TotalDataRelaBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjgs_TotalDataRelaEN.SetIsCheckProperty(true);
    }
    exports.gs_TotalDataRela_CheckPropertyNew = gs_TotalDataRela_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function gs_TotalDataRela_CheckProperty4Update(pobjgs_TotalDataRelaEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TotalDataRelaEN.id_CurrEduCls) == false && (0, clsString_js_1.GetStrLen)(pobjgs_TotalDataRelaEN.id_CurrEduCls) > 8) {
            throw new Error("(errid:Watl000062)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 各观点总数据关系表(gs_TotalDataRela))!值:$(pobjgs_TotalDataRelaEN.id_CurrEduCls)(clsgs_TotalDataRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TotalDataRelaEN.updDate) == false && (0, clsString_js_1.GetStrLen)(pobjgs_TotalDataRelaEN.updDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 各观点总数据关系表(gs_TotalDataRela))!值:$(pobjgs_TotalDataRelaEN.updDate)(clsgs_TotalDataRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TotalDataRelaEN.updUser) == false && (0, clsString_js_1.GetStrLen)(pobjgs_TotalDataRelaEN.updUser) > 20) {
            throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 各观点总数据关系表(gs_TotalDataRela))!值:$(pobjgs_TotalDataRelaEN.updUser)(clsgs_TotalDataRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TotalDataRelaEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjgs_TotalDataRelaEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 各观点总数据关系表(gs_TotalDataRela))!值:$(pobjgs_TotalDataRelaEN.memo)(clsgs_TotalDataRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TotalDataRelaEN.tdRelaTypeId) == false && (0, clsString_js_1.GetStrLen)(pobjgs_TotalDataRelaEN.tdRelaTypeId) > 2) {
            throw new Error("(errid:Watl000062)字段[总数据关系类型Id(tdRelaTypeId)]的长度不能超过2(In 各观点总数据关系表(gs_TotalDataRela))!值:$(pobjgs_TotalDataRelaEN.tdRelaTypeId)(clsgs_TotalDataRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TotalDataRelaEN.totalDataId1) == false && (0, clsString_js_1.GetStrLen)(pobjgs_TotalDataRelaEN.totalDataId1) > 12) {
            throw new Error("(errid:Watl000062)字段[TotalDataId1(totalDataId1)]的长度不能超过12(In 各观点总数据关系表(gs_TotalDataRela))!值:$(pobjgs_TotalDataRelaEN.totalDataId1)(clsgs_TotalDataRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TotalDataRelaEN.totalDataId2) == false && (0, clsString_js_1.GetStrLen)(pobjgs_TotalDataRelaEN.totalDataId2) > 12) {
            throw new Error("(errid:Watl000062)字段[TotalDataId2(totalDataId2)]的长度不能超过12(In 各观点总数据关系表(gs_TotalDataRela))!值:$(pobjgs_TotalDataRelaEN.totalDataId2)(clsgs_TotalDataRelaBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if (null != pobjgs_TotalDataRelaEN.mId && undefined !== pobjgs_TotalDataRelaEN.mId && jsString_js_1.tzDataType.isNumber(pobjgs_TotalDataRelaEN.mId) === false) {
            throw new Error("(errid:Watl000063)字段[mId(mId)]的值:[$(pobjgs_TotalDataRelaEN.mId)], 非法，应该为数值型(In 各观点总数据关系表(gs_TotalDataRela))!(clsgs_TotalDataRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TotalDataRelaEN.id_CurrEduCls) == false && undefined !== pobjgs_TotalDataRelaEN.id_CurrEduCls && jsString_js_1.tzDataType.isString(pobjgs_TotalDataRelaEN.id_CurrEduCls) === false) {
            throw new Error("(errid:Watl000063)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjgs_TotalDataRelaEN.id_CurrEduCls)], 非法，应该为字符型(In 各观点总数据关系表(gs_TotalDataRela))!(clsgs_TotalDataRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TotalDataRelaEN.updDate) == false && undefined !== pobjgs_TotalDataRelaEN.updDate && jsString_js_1.tzDataType.isString(pobjgs_TotalDataRelaEN.updDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjgs_TotalDataRelaEN.updDate)], 非法，应该为字符型(In 各观点总数据关系表(gs_TotalDataRela))!(clsgs_TotalDataRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TotalDataRelaEN.updUser) == false && undefined !== pobjgs_TotalDataRelaEN.updUser && jsString_js_1.tzDataType.isString(pobjgs_TotalDataRelaEN.updUser) === false) {
            throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjgs_TotalDataRelaEN.updUser)], 非法，应该为字符型(In 各观点总数据关系表(gs_TotalDataRela))!(clsgs_TotalDataRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TotalDataRelaEN.memo) == false && undefined !== pobjgs_TotalDataRelaEN.memo && jsString_js_1.tzDataType.isString(pobjgs_TotalDataRelaEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjgs_TotalDataRelaEN.memo)], 非法，应该为字符型(In 各观点总数据关系表(gs_TotalDataRela))!(clsgs_TotalDataRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TotalDataRelaEN.tdRelaTypeId) == false && undefined !== pobjgs_TotalDataRelaEN.tdRelaTypeId && jsString_js_1.tzDataType.isString(pobjgs_TotalDataRelaEN.tdRelaTypeId) === false) {
            throw new Error("(errid:Watl000063)字段[总数据关系类型Id(tdRelaTypeId)]的值:[$(pobjgs_TotalDataRelaEN.tdRelaTypeId)], 非法，应该为字符型(In 各观点总数据关系表(gs_TotalDataRela))!(clsgs_TotalDataRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TotalDataRelaEN.totalDataId1) == false && undefined !== pobjgs_TotalDataRelaEN.totalDataId1 && jsString_js_1.tzDataType.isString(pobjgs_TotalDataRelaEN.totalDataId1) === false) {
            throw new Error("(errid:Watl000063)字段[TotalDataId1(totalDataId1)]的值:[$(pobjgs_TotalDataRelaEN.totalDataId1)], 非法，应该为字符型(In 各观点总数据关系表(gs_TotalDataRela))!(clsgs_TotalDataRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_TotalDataRelaEN.totalDataId2) == false && undefined !== pobjgs_TotalDataRelaEN.totalDataId2 && jsString_js_1.tzDataType.isString(pobjgs_TotalDataRelaEN.totalDataId2) === false) {
            throw new Error("(errid:Watl000063)字段[TotalDataId2(totalDataId2)]的值:[$(pobjgs_TotalDataRelaEN.totalDataId2)], 非法，应该为字符型(In 各观点总数据关系表(gs_TotalDataRela))!(clsgs_TotalDataRelaBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if (null === pobjgs_TotalDataRelaEN.mId
            || pobjgs_TotalDataRelaEN.mId != null && pobjgs_TotalDataRelaEN.mId.toString() === "") {
            throw new Error("(errid:Watl000064)字段[mId]不能为空(In 各观点总数据关系表)!(clsgs_TotalDataRelaBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjgs_TotalDataRelaEN.SetIsCheckProperty(true);
    }
    exports.gs_TotalDataRela_CheckProperty4Update = gs_TotalDataRela_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function gs_TotalDataRela_GetJSONStrByObj(pobjgs_TotalDataRelaEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjgs_TotalDataRelaEN.sf_UpdFldSetStr = pobjgs_TotalDataRelaEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjgs_TotalDataRelaEN);
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
    exports.gs_TotalDataRela_GetJSONStrByObj = gs_TotalDataRela_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function gs_TotalDataRela_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrgs_TotalDataRelaObjLst = new Array();
        if (strJSON === "") {
            return arrgs_TotalDataRelaObjLst;
        }
        try {
            arrgs_TotalDataRelaObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrgs_TotalDataRelaObjLst;
        }
        return arrgs_TotalDataRelaObjLst;
    }
    exports.gs_TotalDataRela_GetObjLstByJSONStr = gs_TotalDataRela_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrgs_TotalDataRelaObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function gs_TotalDataRela_GetObjLstByJSONObjLst(arrgs_TotalDataRelaObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrgs_TotalDataRelaObjLst = new Array();
        for (const objInFor of arrgs_TotalDataRelaObjLstS) {
            const obj1 = gs_TotalDataRela_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrgs_TotalDataRelaObjLst.push(obj1);
        }
        return arrgs_TotalDataRelaObjLst;
    }
    exports.gs_TotalDataRela_GetObjLstByJSONObjLst = gs_TotalDataRela_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function gs_TotalDataRela_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjgs_TotalDataRelaEN = new clsgs_TotalDataRelaEN_js_1.clsgs_TotalDataRelaEN();
        if (strJSON === "") {
            return pobjgs_TotalDataRelaEN;
        }
        try {
            pobjgs_TotalDataRelaEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjgs_TotalDataRelaEN;
        }
        return pobjgs_TotalDataRelaEN;
    }
    exports.gs_TotalDataRela_GetObjByJSONStr = gs_TotalDataRela_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function gs_TotalDataRela_GetCombineCondition(objgs_TotalDataRela_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objgs_TotalDataRela_Cond.dicFldComparisonOp, clsgs_TotalDataRelaEN_js_1.clsgs_TotalDataRelaEN.con_mId) == true) {
            const strComparisonOp_mId = objgs_TotalDataRela_Cond.dicFldComparisonOp[clsgs_TotalDataRelaEN_js_1.clsgs_TotalDataRelaEN.con_mId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsgs_TotalDataRelaEN_js_1.clsgs_TotalDataRelaEN.con_mId, objgs_TotalDataRela_Cond.mId, strComparisonOp_mId);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_TotalDataRela_Cond.dicFldComparisonOp, clsgs_TotalDataRelaEN_js_1.clsgs_TotalDataRelaEN.con_id_CurrEduCls) == true) {
            const strComparisonOp_id_CurrEduCls = objgs_TotalDataRela_Cond.dicFldComparisonOp[clsgs_TotalDataRelaEN_js_1.clsgs_TotalDataRelaEN.con_id_CurrEduCls];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_TotalDataRelaEN_js_1.clsgs_TotalDataRelaEN.con_id_CurrEduCls, objgs_TotalDataRela_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_TotalDataRela_Cond.dicFldComparisonOp, clsgs_TotalDataRelaEN_js_1.clsgs_TotalDataRelaEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objgs_TotalDataRela_Cond.dicFldComparisonOp[clsgs_TotalDataRelaEN_js_1.clsgs_TotalDataRelaEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_TotalDataRelaEN_js_1.clsgs_TotalDataRelaEN.con_UpdDate, objgs_TotalDataRela_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_TotalDataRela_Cond.dicFldComparisonOp, clsgs_TotalDataRelaEN_js_1.clsgs_TotalDataRelaEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objgs_TotalDataRela_Cond.dicFldComparisonOp[clsgs_TotalDataRelaEN_js_1.clsgs_TotalDataRelaEN.con_UpdUser];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_TotalDataRelaEN_js_1.clsgs_TotalDataRelaEN.con_UpdUser, objgs_TotalDataRela_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_TotalDataRela_Cond.dicFldComparisonOp, clsgs_TotalDataRelaEN_js_1.clsgs_TotalDataRelaEN.con_Memo) == true) {
            const strComparisonOp_Memo = objgs_TotalDataRela_Cond.dicFldComparisonOp[clsgs_TotalDataRelaEN_js_1.clsgs_TotalDataRelaEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_TotalDataRelaEN_js_1.clsgs_TotalDataRelaEN.con_Memo, objgs_TotalDataRela_Cond.memo, strComparisonOp_Memo);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_TotalDataRela_Cond.dicFldComparisonOp, clsgs_TotalDataRelaEN_js_1.clsgs_TotalDataRelaEN.con_TDRelaTypeId) == true) {
            const strComparisonOp_TDRelaTypeId = objgs_TotalDataRela_Cond.dicFldComparisonOp[clsgs_TotalDataRelaEN_js_1.clsgs_TotalDataRelaEN.con_TDRelaTypeId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_TotalDataRelaEN_js_1.clsgs_TotalDataRelaEN.con_TDRelaTypeId, objgs_TotalDataRela_Cond.tdRelaTypeId, strComparisonOp_TDRelaTypeId);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_TotalDataRela_Cond.dicFldComparisonOp, clsgs_TotalDataRelaEN_js_1.clsgs_TotalDataRelaEN.con_TotalDataId1) == true) {
            const strComparisonOp_TotalDataId1 = objgs_TotalDataRela_Cond.dicFldComparisonOp[clsgs_TotalDataRelaEN_js_1.clsgs_TotalDataRelaEN.con_TotalDataId1];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_TotalDataRelaEN_js_1.clsgs_TotalDataRelaEN.con_TotalDataId1, objgs_TotalDataRela_Cond.totalDataId1, strComparisonOp_TotalDataId1);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_TotalDataRela_Cond.dicFldComparisonOp, clsgs_TotalDataRelaEN_js_1.clsgs_TotalDataRelaEN.con_TotalDataId2) == true) {
            const strComparisonOp_TotalDataId2 = objgs_TotalDataRela_Cond.dicFldComparisonOp[clsgs_TotalDataRelaEN_js_1.clsgs_TotalDataRelaEN.con_TotalDataId2];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_TotalDataRelaEN_js_1.clsgs_TotalDataRelaEN.con_TotalDataId2, objgs_TotalDataRela_Cond.totalDataId2, strComparisonOp_TotalDataId2);
        }
        return strWhereCond;
    }
    exports.gs_TotalDataRela_GetCombineCondition = gs_TotalDataRela_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--gs_TotalDataRela(各观点总数据关系表),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param lngmId: mId(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function gs_TotalDataRela_GetUniCondStr_mId(objgs_TotalDataRelaEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and mId = '{0}'", objgs_TotalDataRelaEN.mId);
        return strWhereCond;
    }
    exports.gs_TotalDataRela_GetUniCondStr_mId = gs_TotalDataRela_GetUniCondStr_mId;
    /**
    *获取唯一性条件串(Uniqueness)--gs_TotalDataRela(各观点总数据关系表),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param lngmId: mId(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function gs_TotalDataRela_GetUniCondStr4Update_mId(objgs_TotalDataRelaEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and mId <> '{0}'", objgs_TotalDataRelaEN.mId);
        strWhereCond += (0, clsString_js_1.Format)(" and mId = '{0}'", objgs_TotalDataRelaEN.mId);
        return strWhereCond;
    }
    exports.gs_TotalDataRela_GetUniCondStr4Update_mId = gs_TotalDataRela_GetUniCondStr4Update_mId;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objgs_TotalDataRelaENS:源对象
     * @param objgs_TotalDataRelaENT:目标对象
    */
    function gs_TotalDataRela_CopyObjTo(objgs_TotalDataRelaENS, objgs_TotalDataRelaENT) {
        objgs_TotalDataRelaENT.mId = objgs_TotalDataRelaENS.mId; //mId
        objgs_TotalDataRelaENT.id_CurrEduCls = objgs_TotalDataRelaENS.id_CurrEduCls; //教学班流水号
        objgs_TotalDataRelaENT.updDate = objgs_TotalDataRelaENS.updDate; //修改日期
        objgs_TotalDataRelaENT.updUser = objgs_TotalDataRelaENS.updUser; //修改人
        objgs_TotalDataRelaENT.memo = objgs_TotalDataRelaENS.memo; //备注
        objgs_TotalDataRelaENT.tdRelaTypeId = objgs_TotalDataRelaENS.tdRelaTypeId; //总数据关系类型Id
        objgs_TotalDataRelaENT.totalDataId1 = objgs_TotalDataRelaENS.totalDataId1; //TotalDataId1
        objgs_TotalDataRelaENT.totalDataId2 = objgs_TotalDataRelaENS.totalDataId2; //TotalDataId2
        objgs_TotalDataRelaENT.sf_UpdFldSetStr = objgs_TotalDataRelaENS.updFldString; //sf_UpdFldSetStr
    }
    exports.gs_TotalDataRela_CopyObjTo = gs_TotalDataRela_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objgs_TotalDataRelaENS:源对象
     * @param objgs_TotalDataRelaENT:目标对象
    */
    function gs_TotalDataRela_GetObjFromJsonObj(objgs_TotalDataRelaENS) {
        const objgs_TotalDataRelaENT = new clsgs_TotalDataRelaEN_js_1.clsgs_TotalDataRelaEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objgs_TotalDataRelaENT, objgs_TotalDataRelaENS);
        return objgs_TotalDataRelaENT;
    }
    exports.gs_TotalDataRela_GetObjFromJsonObj = gs_TotalDataRela_GetObjFromJsonObj;
});
