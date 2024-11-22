/**
* 类名:clsPaperEduClsRelaWApi
* 表名:PaperEduClsRela(01120919)
* 生成代码版本:2022.11.02.1
* 生成日期:2022/11/02 11:46:37
* 生成者:pyf
* 生成服务器IP:
工程名称:问卷调查(0112)
CM工程:研究生论文学习(变量首字母小写)-全部函数集
* 相关数据库:103.116.76.183,9433EduHigh_Jsie
* PrjDataBaseId:0170
模块中文名:研培论文(GraduateEduPaper)
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
        define(["require", "exports", "axios", "../../PubFun/CacheHelper.js", "../../L0_Entity/GraduateEduPaper/clsPaperEduClsRelaEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsSysPara4WebApi.js", "../../PubFun/CacheHelper.js", "../../PubFun/jsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.PaperEduClsRela_GetObjFromJsonObj = exports.PaperEduClsRela_CopyObjTo = exports.PaperEduClsRela_GetUniCondStr4Update_PaperId_id_CurrEduCls = exports.PaperEduClsRela_GetUniCondStr_PaperId_id_CurrEduCls = exports.PaperEduClsRela_GetCombineCondition = exports.PaperEduClsRela_GetObjByJSONStr = exports.PaperEduClsRela_GetObjLstByJSONObjLst = exports.PaperEduClsRela_GetObjLstByJSONStr = exports.PaperEduClsRela_GetJSONStrByObj = exports.PaperEduClsRela_CheckProperty4Update = exports.PaperEduClsRela_CheckPropertyNew = exports.PaperEduClsRela_ReFreshThisCache = exports.PaperEduClsRela_ReFreshCache = exports.PaperEduClsRela_GetWebApiUrl = exports.PaperEduClsRela_GetMaxStrIdByPrefix = exports.PaperEduClsRela_GetRecCountByCond_Cache = exports.PaperEduClsRela_GetRecCountByCondAsync = exports.PaperEduClsRela_IsExistAsync = exports.PaperEduClsRela_IsExist_Cache = exports.PaperEduClsRela_IsExist = exports.PaperEduClsRela_IsExistRecordAsync = exports.PaperEduClsRela_IsExistRecord_Cache = exports.PaperEduClsRela_UpdateWithConditionAsync = exports.PaperEduClsRela_UpdateRecordAsync = exports.PaperEduClsRela_AddNewRecordWithReturnKey = exports.PaperEduClsRela_AddNewRecordWithReturnKeyAsync = exports.PaperEduClsRela_AddNewRecordAsync = exports.PaperEduClsRela_DelPaperEduClsRelasByCondAsync = exports.PaperEduClsRela_DelPaperEduClsRelasAsync = exports.PaperEduClsRela_DelRecordAsync = exports.PaperEduClsRela_GetObjLstByPagerAsync = exports.PaperEduClsRela_GetObjLstByPager_Cache = exports.PaperEduClsRela_GetObjLstByRange = exports.PaperEduClsRela_GetObjLstByRangeAsync = exports.PaperEduClsRela_GetTopObjLstAsync = exports.PaperEduClsRela_GetObjLstBymIdLst_Cache = exports.PaperEduClsRela_GetObjLstBymIdLstAsync = exports.PaperEduClsRela_GetSubObjLst_Cache = exports.PaperEduClsRela_GetObjLst_PureCache = exports.PaperEduClsRela_GetObjLst_Cache = exports.PaperEduClsRela_GetObjLst_sessionStorage_PureCache = exports.PaperEduClsRela_GetObjLst_sessionStorage = exports.PaperEduClsRela_GetObjLstAsync = exports.PaperEduClsRela_GetObjLst_localStorage_PureCache = exports.PaperEduClsRela_GetObjLst_localStorage = exports.PaperEduClsRela_GetObjLst_ClientCache = exports.PaperEduClsRela_GetFirstObjAsync = exports.PaperEduClsRela_GetFirstID = exports.PaperEduClsRela_GetFirstIDAsync = exports.PaperEduClsRela_FilterFunByKey = exports.PaperEduClsRela_SortFunByKey = exports.PaperEduClsRela_SortFun_Defa_2Fld = exports.PaperEduClsRela_SortFun_Defa = exports.PaperEduClsRela_func = exports.PaperEduClsRela_UpdateObjInLst_Cache = exports.PaperEduClsRela_GetObjBymId_localStorage = exports.PaperEduClsRela_GetObjBymId_Cache = exports.PaperEduClsRela_GetObjBymIdAsync = exports.paperEduClsRela_ConstructorName = exports.paperEduClsRela_Controller = void 0;
    /**
     * 论文教学班关系(PaperEduClsRela)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2022年11月02日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsPaperEduClsRelaEN_js_1 = require("../../L0_Entity/GraduateEduPaper/clsPaperEduClsRelaEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    const CacheHelper_js_2 = require("../../PubFun/CacheHelper.js");
    const jsString_js_1 = require("../../PubFun/jsString.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.paperEduClsRela_Controller = "PaperEduClsRelaApi";
    exports.paperEduClsRela_ConstructorName = "paperEduClsRela";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param lngmId:关键字
    * @returns 对象
    **/
    async function PaperEduClsRela_GetObjBymIdAsync(lngmId) {
        const strThisFuncName = "GetObjBymIdAsync";
        if (lngmId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngmId]不能为空！(In GetObjBymIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjBymId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperEduClsRela_Controller, strAction);
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
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.paperEduClsRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objPaperEduClsRela = PaperEduClsRela_GetObjFromJsonObj(returnObj);
                return objPaperEduClsRela;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperEduClsRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperEduClsRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperEduClsRela_GetObjBymIdAsync = PaperEduClsRela_GetObjBymIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param lngmId:所给的关键字
     * @returns 对象
    */
    async function PaperEduClsRela_GetObjBymId_Cache(lngmId, strid_CurrEduCls, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjBymId_Cache";
        if (lngmId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngmId]不能为空！(In GetObjBymId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        const arrPaperEduClsRelaObjLst_Cache = await PaperEduClsRela_GetObjLst_Cache(strid_CurrEduCls);
        try {
            const arrPaperEduClsRela_Sel = arrPaperEduClsRelaObjLst_Cache.filter(x => x.mId == lngmId);
            let objPaperEduClsRela;
            if (arrPaperEduClsRela_Sel.length > 0) {
                objPaperEduClsRela = arrPaperEduClsRela_Sel[0];
                return objPaperEduClsRela;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    objPaperEduClsRela = await PaperEduClsRela_GetObjBymIdAsync(lngmId);
                    if (objPaperEduClsRela != null) {
                        PaperEduClsRela_ReFreshThisCache(strid_CurrEduCls);
                        return objPaperEduClsRela;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngmId, exports.paperEduClsRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.PaperEduClsRela_GetObjBymId_Cache = PaperEduClsRela_GetObjBymId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param lngmId:所给的关键字
     * @returns 对象
    */
    async function PaperEduClsRela_GetObjBymId_localStorage(lngmId) {
        const strThisFuncName = "GetObjBymId_localStorage";
        if (lngmId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngmId]不能为空！(In GetObjBymId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsPaperEduClsRelaEN_js_1.clsPaperEduClsRelaEN._CurrTabName, lngmId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objPaperEduClsRela_Cache = JSON.parse(strTempObj);
            return objPaperEduClsRela_Cache;
        }
        try {
            const objPaperEduClsRela = await PaperEduClsRela_GetObjBymIdAsync(lngmId);
            if (objPaperEduClsRela != null) {
                localStorage.setItem(strKey, JSON.stringify(objPaperEduClsRela));
                const strInfo = (0, clsString_js_1.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objPaperEduClsRela;
            }
            return objPaperEduClsRela;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngmId, exports.paperEduClsRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.PaperEduClsRela_GetObjBymId_localStorage = PaperEduClsRela_GetObjBymId_localStorage;
    /**
     * 修改在缓存对象列表中的对象, 与后台数据库无关.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
     * @param objPaperEduClsRela:所给的对象
     * @returns 对象
    */
    async function PaperEduClsRela_UpdateObjInLst_Cache(objPaperEduClsRela, strid_CurrEduCls) {
        const strThisFuncName = "UpdateObjInLst_Cache";
        try {
            const arrPaperEduClsRelaObjLst_Cache = await PaperEduClsRela_GetObjLst_Cache(strid_CurrEduCls);
            const obj = arrPaperEduClsRelaObjLst_Cache.find(x => x.paperId == objPaperEduClsRela.paperId && x.id_CurrEduCls == objPaperEduClsRela.id_CurrEduCls);
            if (obj != null) {
                objPaperEduClsRela.mId = obj.mId;
                (0, clsCommFunc4Web_js_1.ObjectAssign)(obj, objPaperEduClsRela);
            }
            else {
                arrPaperEduClsRelaObjLst_Cache.push(objPaperEduClsRela);
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, exports.paperEduClsRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.PaperEduClsRela_UpdateObjInLst_Cache = PaperEduClsRela_UpdateObjInLst_Cache;
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
    async function PaperEduClsRela_func(strInFldName, strOutFldName, strInValue, strid_CurrEduCls_C) {
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
        if (strInFldName != clsPaperEduClsRelaEN_js_1.clsPaperEduClsRelaEN.con_mId) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsPaperEduClsRelaEN_js_1.clsPaperEduClsRelaEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_1.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strInFldName, clsPaperEduClsRelaEN_js_1.clsPaperEduClsRelaEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const lngmId = Number(strInValue);
        if (lngmId == 0) {
            return "";
        }
        const objPaperEduClsRela = await PaperEduClsRela_GetObjBymId_Cache(lngmId, strid_CurrEduCls_C);
        if (objPaperEduClsRela == null)
            return "";
        return objPaperEduClsRela.GetFldValue(strOutFldName).toString();
    }
    exports.PaperEduClsRela_func = PaperEduClsRela_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function PaperEduClsRela_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.mId - b.mId;
    }
    exports.PaperEduClsRela_SortFun_Defa = PaperEduClsRela_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function PaperEduClsRela_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.paperId == b.paperId)
            return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
        else
            return a.paperId.localeCompare(b.paperId);
    }
    exports.PaperEduClsRela_SortFun_Defa_2Fld = PaperEduClsRela_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function PaperEduClsRela_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsPaperEduClsRelaEN_js_1.clsPaperEduClsRelaEN.con_mId:
                    return (a, b) => {
                        return a.mId - b.mId;
                    };
                case clsPaperEduClsRelaEN_js_1.clsPaperEduClsRelaEN.con_PaperId:
                    return (a, b) => {
                        return a.paperId.localeCompare(b.paperId);
                    };
                case clsPaperEduClsRelaEN_js_1.clsPaperEduClsRelaEN.con_id_CurrEduCls:
                    return (a, b) => {
                        return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
                    };
                case clsPaperEduClsRelaEN_js_1.clsPaperEduClsRelaEN.con_UpdUser:
                    return (a, b) => {
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsPaperEduClsRelaEN_js_1.clsPaperEduClsRelaEN.con_UpdDate:
                    return (a, b) => {
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsPaperEduClsRelaEN_js_1.clsPaperEduClsRelaEN.con_Memo:
                    return (a, b) => {
                        return a.memo.localeCompare(b.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[PaperEduClsRela]中不存在！(in ${exports.paperEduClsRela_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsPaperEduClsRelaEN_js_1.clsPaperEduClsRelaEN.con_mId:
                    return (a, b) => {
                        return b.mId - a.mId;
                    };
                case clsPaperEduClsRelaEN_js_1.clsPaperEduClsRelaEN.con_PaperId:
                    return (a, b) => {
                        return b.paperId.localeCompare(a.paperId);
                    };
                case clsPaperEduClsRelaEN_js_1.clsPaperEduClsRelaEN.con_id_CurrEduCls:
                    return (a, b) => {
                        return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
                    };
                case clsPaperEduClsRelaEN_js_1.clsPaperEduClsRelaEN.con_UpdUser:
                    return (a, b) => {
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsPaperEduClsRelaEN_js_1.clsPaperEduClsRelaEN.con_UpdDate:
                    return (a, b) => {
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsPaperEduClsRelaEN_js_1.clsPaperEduClsRelaEN.con_Memo:
                    return (a, b) => {
                        return b.memo.localeCompare(a.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[PaperEduClsRela]中不存在！(in ${exports.paperEduClsRela_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.PaperEduClsRela_SortFunByKey = PaperEduClsRela_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function PaperEduClsRela_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsPaperEduClsRelaEN_js_1.clsPaperEduClsRelaEN.con_mId:
                return (obj) => {
                    return obj.mId === value;
                };
            case clsPaperEduClsRelaEN_js_1.clsPaperEduClsRelaEN.con_PaperId:
                return (obj) => {
                    return obj.paperId === value;
                };
            case clsPaperEduClsRelaEN_js_1.clsPaperEduClsRelaEN.con_id_CurrEduCls:
                return (obj) => {
                    return obj.id_CurrEduCls === value;
                };
            case clsPaperEduClsRelaEN_js_1.clsPaperEduClsRelaEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsPaperEduClsRelaEN_js_1.clsPaperEduClsRelaEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsPaperEduClsRelaEN_js_1.clsPaperEduClsRelaEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[PaperEduClsRela]中不存在！(in ${exports.paperEduClsRela_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.PaperEduClsRela_FilterFunByKey = PaperEduClsRela_FilterFunByKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function PaperEduClsRela_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperEduClsRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperEduClsRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperEduClsRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperEduClsRela_GetFirstIDAsync = PaperEduClsRela_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function PaperEduClsRela_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperEduClsRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperEduClsRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperEduClsRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperEduClsRela_GetFirstID = PaperEduClsRela_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function PaperEduClsRela_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperEduClsRela_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.paperEduClsRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objPaperEduClsRela = PaperEduClsRela_GetObjFromJsonObj(returnObj);
                return objPaperEduClsRela;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperEduClsRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperEduClsRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperEduClsRela_GetFirstObjAsync = PaperEduClsRela_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function PaperEduClsRela_GetObjLst_ClientCache(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsPaperEduClsRelaEN_js_1.clsPaperEduClsRelaEN._CurrTabName, strid_CurrEduCls);
        clsPaperEduClsRelaEN_js_1.clsPaperEduClsRelaEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsPaperEduClsRelaEN_js_1.clsPaperEduClsRelaEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsPaperEduClsRelaEN_js_1.clsPaperEduClsRelaEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsPaperEduClsRelaEN_js_1.clsPaperEduClsRelaEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_2.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrPaperEduClsRelaExObjLst_Cache = CacheHelper_js_2.CacheHelper.Get(strKey);
            const arrPaperEduClsRelaObjLst_T = PaperEduClsRela_GetObjLstByJSONObjLst(arrPaperEduClsRelaExObjLst_Cache);
            return arrPaperEduClsRelaObjLst_T;
        }
        try {
            const arrPaperEduClsRelaExObjLst = await PaperEduClsRela_GetObjLstAsync(strWhereCond);
            CacheHelper_js_2.CacheHelper.Add(strKey, arrPaperEduClsRelaExObjLst);
            const strInfo = (0, clsString_js_1.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrPaperEduClsRelaExObjLst.length);
            console.log(strInfo);
            return arrPaperEduClsRelaExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.paperEduClsRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.PaperEduClsRela_GetObjLst_ClientCache = PaperEduClsRela_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function PaperEduClsRela_GetObjLst_localStorage(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsPaperEduClsRelaEN_js_1.clsPaperEduClsRelaEN._CurrTabName, strid_CurrEduCls);
        clsPaperEduClsRelaEN_js_1.clsPaperEduClsRelaEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsPaperEduClsRelaEN_js_1.clsPaperEduClsRelaEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsPaperEduClsRelaEN_js_1.clsPaperEduClsRelaEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsPaperEduClsRelaEN_js_1.clsPaperEduClsRelaEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrPaperEduClsRelaExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrPaperEduClsRelaObjLst_T = PaperEduClsRela_GetObjLstByJSONObjLst(arrPaperEduClsRelaExObjLst_Cache);
            return arrPaperEduClsRelaObjLst_T;
        }
        try {
            const arrPaperEduClsRelaExObjLst = await PaperEduClsRela_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrPaperEduClsRelaExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrPaperEduClsRelaExObjLst.length);
            console.log(strInfo);
            return arrPaperEduClsRelaExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.paperEduClsRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.PaperEduClsRela_GetObjLst_localStorage = PaperEduClsRela_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function PaperEduClsRela_GetObjLst_localStorage_PureCache(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsPaperEduClsRelaEN_js_1.clsPaperEduClsRelaEN._CurrTabName, strid_CurrEduCls);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrPaperEduClsRelaObjLst_Cache = JSON.parse(strTempObjLst);
            return arrPaperEduClsRelaObjLst_Cache;
        }
        else
            return null;
    }
    exports.PaperEduClsRela_GetObjLst_localStorage_PureCache = PaperEduClsRela_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function PaperEduClsRela_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperEduClsRela_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.paperEduClsRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = PaperEduClsRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperEduClsRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperEduClsRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperEduClsRela_GetObjLstAsync = PaperEduClsRela_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function PaperEduClsRela_GetObjLst_sessionStorage(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsPaperEduClsRelaEN_js_1.clsPaperEduClsRelaEN._CurrTabName, strid_CurrEduCls);
        clsPaperEduClsRelaEN_js_1.clsPaperEduClsRelaEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsPaperEduClsRelaEN_js_1.clsPaperEduClsRelaEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsPaperEduClsRelaEN_js_1.clsPaperEduClsRelaEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsPaperEduClsRelaEN_js_1.clsPaperEduClsRelaEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrPaperEduClsRelaExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrPaperEduClsRelaObjLst_T = PaperEduClsRela_GetObjLstByJSONObjLst(arrPaperEduClsRelaExObjLst_Cache);
            return arrPaperEduClsRelaObjLst_T;
        }
        try {
            const arrPaperEduClsRelaExObjLst = await PaperEduClsRela_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrPaperEduClsRelaExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrPaperEduClsRelaExObjLst.length);
            console.log(strInfo);
            return arrPaperEduClsRelaExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.paperEduClsRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.PaperEduClsRela_GetObjLst_sessionStorage = PaperEduClsRela_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function PaperEduClsRela_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsPaperEduClsRelaEN_js_1.clsPaperEduClsRelaEN._CurrTabName, strid_CurrEduCls);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrPaperEduClsRelaObjLst_Cache = JSON.parse(strTempObjLst);
            return arrPaperEduClsRelaObjLst_Cache;
        }
        else
            return null;
    }
    exports.PaperEduClsRela_GetObjLst_sessionStorage_PureCache = PaperEduClsRela_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function PaperEduClsRela_GetObjLst_Cache(strid_CurrEduCls) {
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
        let arrPaperEduClsRelaObjLst_Cache;
        switch (clsPaperEduClsRelaEN_js_1.clsPaperEduClsRelaEN.CacheModeId) {
            case "04": //sessionStorage
                arrPaperEduClsRelaObjLst_Cache = await PaperEduClsRela_GetObjLst_sessionStorage(strid_CurrEduCls);
                break;
            case "03": //localStorage
                arrPaperEduClsRelaObjLst_Cache = await PaperEduClsRela_GetObjLst_localStorage(strid_CurrEduCls);
                break;
            case "02": //ClientCache
                arrPaperEduClsRelaObjLst_Cache = await PaperEduClsRela_GetObjLst_ClientCache(strid_CurrEduCls);
                break;
            default:
                arrPaperEduClsRelaObjLst_Cache = await PaperEduClsRela_GetObjLst_ClientCache(strid_CurrEduCls);
                break;
        }
        const arrPaperEduClsRelaObjLst = PaperEduClsRela_GetObjLstByJSONObjLst(arrPaperEduClsRelaObjLst_Cache);
        return arrPaperEduClsRelaObjLst_Cache;
    }
    exports.PaperEduClsRela_GetObjLst_Cache = PaperEduClsRela_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function PaperEduClsRela_GetObjLst_PureCache(strid_CurrEduCls) {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrPaperEduClsRelaObjLst_Cache;
        switch (clsPaperEduClsRelaEN_js_1.clsPaperEduClsRelaEN.CacheModeId) {
            case "04": //sessionStorage
                arrPaperEduClsRelaObjLst_Cache = await PaperEduClsRela_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls);
                break;
            case "03": //localStorage
                arrPaperEduClsRelaObjLst_Cache = await PaperEduClsRela_GetObjLst_localStorage_PureCache(strid_CurrEduCls);
                break;
            case "02": //ClientCache
                arrPaperEduClsRelaObjLst_Cache = null;
                break;
            default:
                arrPaperEduClsRelaObjLst_Cache = null;
                break;
        }
        return arrPaperEduClsRelaObjLst_Cache;
    }
    exports.PaperEduClsRela_GetObjLst_PureCache = PaperEduClsRela_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objlngmId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function PaperEduClsRela_GetSubObjLst_Cache(objPaperEduClsRela_Cond, strid_CurrEduCls) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrPaperEduClsRelaObjLst_Cache = await PaperEduClsRela_GetObjLst_Cache(strid_CurrEduCls);
        let arrPaperEduClsRela_Sel = arrPaperEduClsRelaObjLst_Cache;
        if (objPaperEduClsRela_Cond.sf_FldComparisonOp == null || objPaperEduClsRela_Cond.sf_FldComparisonOp == "")
            return arrPaperEduClsRela_Sel;
        const dicFldComparisonOp = JSON.parse(objPaperEduClsRela_Cond.sf_FldComparisonOp);
        //console.log("clsPaperEduClsRelaWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objPaperEduClsRela_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objPaperEduClsRela_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrPaperEduClsRela_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objPaperEduClsRela_Cond), exports.paperEduClsRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.PaperEduClsRela_GetSubObjLst_Cache = PaperEduClsRela_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrmId:关键字列表
    * @returns 对象列表
    **/
    async function PaperEduClsRela_GetObjLstBymIdLstAsync(arrmId) {
        const strThisFuncName = "GetObjLstBymIdLstAsync";
        const strAction = "GetObjLstBymIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperEduClsRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrmId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.paperEduClsRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = PaperEduClsRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperEduClsRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperEduClsRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperEduClsRela_GetObjLstBymIdLstAsync = PaperEduClsRela_GetObjLstBymIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrlngmIdLst:关键字列表
     * @returns 对象列表
    */
    async function PaperEduClsRela_GetObjLstBymIdLst_Cache(arrmIdLst, strid_CurrEduCls) {
        const strThisFuncName = "GetObjLstBymIdLst_Cache";
        try {
            const arrPaperEduClsRelaObjLst_Cache = await PaperEduClsRela_GetObjLst_Cache(strid_CurrEduCls);
            const arrPaperEduClsRela_Sel = arrPaperEduClsRelaObjLst_Cache.filter(x => arrmIdLst.indexOf(x.mId) > -1);
            return arrPaperEduClsRela_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrmIdLst.join(","), exports.paperEduClsRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.PaperEduClsRela_GetObjLstBymIdLst_Cache = PaperEduClsRela_GetObjLstBymIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function PaperEduClsRela_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperEduClsRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.paperEduClsRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = PaperEduClsRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperEduClsRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperEduClsRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperEduClsRela_GetTopObjLstAsync = PaperEduClsRela_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function PaperEduClsRela_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperEduClsRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.paperEduClsRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = PaperEduClsRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperEduClsRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperEduClsRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperEduClsRela_GetObjLstByRangeAsync = PaperEduClsRela_GetObjLstByRangeAsync;
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
    async function PaperEduClsRela_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperEduClsRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperEduClsRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperEduClsRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperEduClsRela_GetObjLstByRange = PaperEduClsRela_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function PaperEduClsRela_GetObjLstByPager_Cache(objPagerPara, strid_CurrEduCls) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const arrPaperEduClsRelaObjLst_Cache = await PaperEduClsRela_GetObjLst_Cache(strid_CurrEduCls);
        if (arrPaperEduClsRelaObjLst_Cache.length == 0)
            return arrPaperEduClsRelaObjLst_Cache;
        let arrPaperEduClsRela_Sel = arrPaperEduClsRelaObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objPaperEduClsRela_Cond = new clsPaperEduClsRelaEN_js_1.clsPaperEduClsRelaEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objPaperEduClsRela_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsPaperEduClsRelaWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objPaperEduClsRela_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrPaperEduClsRela_Sel.length == 0)
                return arrPaperEduClsRela_Sel;
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
                arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.sort(PaperEduClsRela_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.sort(objPagerPara.sortFun);
            }
            arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.slice(intStart, intEnd);
            return arrPaperEduClsRela_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.paperEduClsRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.PaperEduClsRela_GetObjLstByPager_Cache = PaperEduClsRela_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function PaperEduClsRela_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperEduClsRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.paperEduClsRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = PaperEduClsRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperEduClsRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperEduClsRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperEduClsRela_GetObjLstByPagerAsync = PaperEduClsRela_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param lngmId:关键字
    * @returns 获取删除的结果
    **/
    async function PaperEduClsRela_DelRecordAsync(lngmId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperEduClsRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperEduClsRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperEduClsRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperEduClsRela_DelRecordAsync = PaperEduClsRela_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrmId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function PaperEduClsRela_DelPaperEduClsRelasAsync(arrmId) {
        const strThisFuncName = "DelPaperEduClsRelasAsync";
        const strAction = "DelPaperEduClsRelas";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperEduClsRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperEduClsRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperEduClsRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperEduClsRela_DelPaperEduClsRelasAsync = PaperEduClsRela_DelPaperEduClsRelasAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function PaperEduClsRela_DelPaperEduClsRelasByCondAsync(strWhereCond) {
        const strThisFuncName = "DelPaperEduClsRelasByCondAsync";
        const strAction = "DelPaperEduClsRelasByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperEduClsRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperEduClsRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperEduClsRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperEduClsRela_DelPaperEduClsRelasByCondAsync = PaperEduClsRela_DelPaperEduClsRelasByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objPaperEduClsRelaEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function PaperEduClsRela_AddNewRecordAsync(objPaperEduClsRelaEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objPaperEduClsRelaEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperEduClsRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPaperEduClsRelaEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperEduClsRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperEduClsRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperEduClsRela_AddNewRecordAsync = PaperEduClsRela_AddNewRecordAsync;
    /* 数据类型不是字符型，不可以最大关键字的方式添加记录。*/
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objPaperEduClsRelaEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function PaperEduClsRela_AddNewRecordWithReturnKeyAsync(objPaperEduClsRelaEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperEduClsRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPaperEduClsRelaEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperEduClsRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperEduClsRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperEduClsRela_AddNewRecordWithReturnKeyAsync = PaperEduClsRela_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objPaperEduClsRelaEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function PaperEduClsRela_AddNewRecordWithReturnKey(objPaperEduClsRelaEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objPaperEduClsRelaEN.mId === null || objPaperEduClsRelaEN.mId === 0) {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperEduClsRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPaperEduClsRelaEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperEduClsRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperEduClsRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperEduClsRela_AddNewRecordWithReturnKey = PaperEduClsRela_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objPaperEduClsRelaEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function PaperEduClsRela_UpdateRecordAsync(objPaperEduClsRelaEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objPaperEduClsRelaEN.sf_UpdFldSetStr === undefined || objPaperEduClsRelaEN.sf_UpdFldSetStr === null || objPaperEduClsRelaEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objPaperEduClsRelaEN.mId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperEduClsRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPaperEduClsRelaEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperEduClsRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperEduClsRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperEduClsRela_UpdateRecordAsync = PaperEduClsRela_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objPaperEduClsRelaEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function PaperEduClsRela_UpdateWithConditionAsync(objPaperEduClsRelaEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objPaperEduClsRelaEN.sf_UpdFldSetStr === undefined || objPaperEduClsRelaEN.sf_UpdFldSetStr === null || objPaperEduClsRelaEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objPaperEduClsRelaEN.mId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperEduClsRela_Controller, strAction);
        objPaperEduClsRelaEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objPaperEduClsRelaEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperEduClsRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperEduClsRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperEduClsRela_UpdateWithConditionAsync = PaperEduClsRela_UpdateWithConditionAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objlngmId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function PaperEduClsRela_IsExistRecord_Cache(objPaperEduClsRela_Cond, strid_CurrEduCls) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrPaperEduClsRelaObjLst_Cache = await PaperEduClsRela_GetObjLst_Cache(strid_CurrEduCls);
        if (arrPaperEduClsRelaObjLst_Cache == null)
            return false;
        let arrPaperEduClsRela_Sel = arrPaperEduClsRelaObjLst_Cache;
        if (objPaperEduClsRela_Cond.sf_FldComparisonOp == null || objPaperEduClsRela_Cond.sf_FldComparisonOp == "")
            return arrPaperEduClsRela_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objPaperEduClsRela_Cond.sf_FldComparisonOp);
        //console.log("clsPaperEduClsRelaWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objPaperEduClsRela_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objPaperEduClsRela_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrPaperEduClsRela_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objPaperEduClsRela_Cond), exports.paperEduClsRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.PaperEduClsRela_IsExistRecord_Cache = PaperEduClsRela_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function PaperEduClsRela_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperEduClsRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperEduClsRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperEduClsRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperEduClsRela_IsExistRecordAsync = PaperEduClsRela_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param lngmId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function PaperEduClsRela_IsExist(lngmId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperEduClsRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperEduClsRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperEduClsRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperEduClsRela_IsExist = PaperEduClsRela_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param lngmId:所给的关键字
     * @returns 对象
    */
    async function PaperEduClsRela_IsExist_Cache(lngmId, strid_CurrEduCls) {
        const strThisFuncName = "IsExist_Cache";
        const arrPaperEduClsRelaObjLst_Cache = await PaperEduClsRela_GetObjLst_Cache(strid_CurrEduCls);
        if (arrPaperEduClsRelaObjLst_Cache == null)
            return false;
        try {
            const arrPaperEduClsRela_Sel = arrPaperEduClsRelaObjLst_Cache.filter(x => x.mId == lngmId);
            if (arrPaperEduClsRela_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", lngmId, exports.paperEduClsRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.PaperEduClsRela_IsExist_Cache = PaperEduClsRela_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param lngmId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function PaperEduClsRela_IsExistAsync(lngmId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperEduClsRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperEduClsRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperEduClsRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperEduClsRela_IsExistAsync = PaperEduClsRela_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function PaperEduClsRela_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperEduClsRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperEduClsRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperEduClsRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperEduClsRela_GetRecCountByCondAsync = PaperEduClsRela_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objPaperEduClsRela_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function PaperEduClsRela_GetRecCountByCond_Cache(objPaperEduClsRela_Cond, strid_CurrEduCls) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrPaperEduClsRelaObjLst_Cache = await PaperEduClsRela_GetObjLst_Cache(strid_CurrEduCls);
        if (arrPaperEduClsRelaObjLst_Cache == null)
            return 0;
        let arrPaperEduClsRela_Sel = arrPaperEduClsRelaObjLst_Cache;
        if (objPaperEduClsRela_Cond.sf_FldComparisonOp == null || objPaperEduClsRela_Cond.sf_FldComparisonOp == "")
            return arrPaperEduClsRela_Sel.length;
        const dicFldComparisonOp = JSON.parse(objPaperEduClsRela_Cond.sf_FldComparisonOp);
        //console.log("clsPaperEduClsRelaWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objPaperEduClsRela_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objPaperEduClsRela_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrPaperEduClsRela_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objPaperEduClsRela_Cond), exports.paperEduClsRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.PaperEduClsRela_GetRecCountByCond_Cache = PaperEduClsRela_GetRecCountByCond_Cache;
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
    async function PaperEduClsRela_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperEduClsRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperEduClsRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperEduClsRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperEduClsRela_GetMaxStrIdByPrefix = PaperEduClsRela_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function PaperEduClsRela_GetWebApiUrl(strController, strAction) {
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
    exports.PaperEduClsRela_GetWebApiUrl = PaperEduClsRela_GetWebApiUrl;
    /**
    * 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshCache)
    **/
    function PaperEduClsRela_ReFreshCache(strid_CurrEduCls) {
        const strThisFuncName = "ReFreshCache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strid_CurrEduCls) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strid_CurrEduCls]不能为空！(In clsPaperEduClsRelaWApi.ReFreshCache)");
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
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsPaperEduClsRelaEN_js_1.clsPaperEduClsRelaEN._CurrTabName, strid_CurrEduCls);
        switch (clsPaperEduClsRelaEN_js_1.clsPaperEduClsRelaEN.CacheModeId) {
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
    exports.PaperEduClsRela_ReFreshCache = PaperEduClsRela_ReFreshCache;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function PaperEduClsRela_ReFreshThisCache(strid_CurrEduCls) {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsPaperEduClsRelaEN_js_1.clsPaperEduClsRelaEN._CurrTabName, strid_CurrEduCls);
            switch (clsPaperEduClsRelaEN_js_1.clsPaperEduClsRelaEN.CacheModeId) {
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
    exports.PaperEduClsRela_ReFreshThisCache = PaperEduClsRela_ReFreshThisCache;
    /* 该表的下拉框功能没有设置，不需要生成下拉框绑定函数。*/
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function PaperEduClsRela_CheckPropertyNew(pobjPaperEduClsRelaEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperEduClsRelaEN.paperId) === true
            || pobjPaperEduClsRelaEN.paperId.toString() === "0") {
            throw new Error("(errid:Watl000058)字段[论文Id]不能为空(In 论文教学班关系)!(clsPaperEduClsRelaBL:CheckPropertyNew)");
        }
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperEduClsRelaEN.paperId) == false && (0, clsString_js_1.GetStrLen)(pobjPaperEduClsRelaEN.paperId) > 8) {
            throw new Error("(errid:Watl000059)字段[论文Id(paperId)]的长度不能超过8(In 论文教学班关系(PaperEduClsRela))!值:$(pobjPaperEduClsRelaEN.paperId)(clsPaperEduClsRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperEduClsRelaEN.id_CurrEduCls) == false && (0, clsString_js_1.GetStrLen)(pobjPaperEduClsRelaEN.id_CurrEduCls) > 8) {
            throw new Error("(errid:Watl000059)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 论文教学班关系(PaperEduClsRela))!值:$(pobjPaperEduClsRelaEN.id_CurrEduCls)(clsPaperEduClsRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperEduClsRelaEN.updUser) == false && (0, clsString_js_1.GetStrLen)(pobjPaperEduClsRelaEN.updUser) > 20) {
            throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 论文教学班关系(PaperEduClsRela))!值:$(pobjPaperEduClsRelaEN.updUser)(clsPaperEduClsRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperEduClsRelaEN.updDate) == false && (0, clsString_js_1.GetStrLen)(pobjPaperEduClsRelaEN.updDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 论文教学班关系(PaperEduClsRela))!值:$(pobjPaperEduClsRelaEN.updDate)(clsPaperEduClsRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperEduClsRelaEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjPaperEduClsRelaEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 论文教学班关系(PaperEduClsRela))!值:$(pobjPaperEduClsRelaEN.memo)(clsPaperEduClsRelaBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if (null != pobjPaperEduClsRelaEN.mId && undefined !== pobjPaperEduClsRelaEN.mId && jsString_js_1.tzDataType.isNumber(pobjPaperEduClsRelaEN.mId) === false) {
            throw new Error("(errid:Watl000060)字段[mId(mId)]的值:[$(pobjPaperEduClsRelaEN.mId)], 非法，应该为数值型(In 论文教学班关系(PaperEduClsRela))!(clsPaperEduClsRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperEduClsRelaEN.paperId) == false && undefined !== pobjPaperEduClsRelaEN.paperId && jsString_js_1.tzDataType.isString(pobjPaperEduClsRelaEN.paperId) === false) {
            throw new Error("(errid:Watl000060)字段[论文Id(paperId)]的值:[$(pobjPaperEduClsRelaEN.paperId)], 非法，应该为字符型(In 论文教学班关系(PaperEduClsRela))!(clsPaperEduClsRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperEduClsRelaEN.id_CurrEduCls) == false && undefined !== pobjPaperEduClsRelaEN.id_CurrEduCls && jsString_js_1.tzDataType.isString(pobjPaperEduClsRelaEN.id_CurrEduCls) === false) {
            throw new Error("(errid:Watl000060)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjPaperEduClsRelaEN.id_CurrEduCls)], 非法，应该为字符型(In 论文教学班关系(PaperEduClsRela))!(clsPaperEduClsRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperEduClsRelaEN.updUser) == false && undefined !== pobjPaperEduClsRelaEN.updUser && jsString_js_1.tzDataType.isString(pobjPaperEduClsRelaEN.updUser) === false) {
            throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjPaperEduClsRelaEN.updUser)], 非法，应该为字符型(In 论文教学班关系(PaperEduClsRela))!(clsPaperEduClsRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperEduClsRelaEN.updDate) == false && undefined !== pobjPaperEduClsRelaEN.updDate && jsString_js_1.tzDataType.isString(pobjPaperEduClsRelaEN.updDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjPaperEduClsRelaEN.updDate)], 非法，应该为字符型(In 论文教学班关系(PaperEduClsRela))!(clsPaperEduClsRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperEduClsRelaEN.memo) == false && undefined !== pobjPaperEduClsRelaEN.memo && jsString_js_1.tzDataType.isString(pobjPaperEduClsRelaEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjPaperEduClsRelaEN.memo)], 非法，应该为字符型(In 论文教学班关系(PaperEduClsRela))!(clsPaperEduClsRelaBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjPaperEduClsRelaEN.SetIsCheckProperty(true);
    }
    exports.PaperEduClsRela_CheckPropertyNew = PaperEduClsRela_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function PaperEduClsRela_CheckProperty4Update(pobjPaperEduClsRelaEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperEduClsRelaEN.paperId) == false && (0, clsString_js_1.GetStrLen)(pobjPaperEduClsRelaEN.paperId) > 8) {
            throw new Error("(errid:Watl000062)字段[论文Id(paperId)]的长度不能超过8(In 论文教学班关系(PaperEduClsRela))!值:$(pobjPaperEduClsRelaEN.paperId)(clsPaperEduClsRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperEduClsRelaEN.id_CurrEduCls) == false && (0, clsString_js_1.GetStrLen)(pobjPaperEduClsRelaEN.id_CurrEduCls) > 8) {
            throw new Error("(errid:Watl000062)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 论文教学班关系(PaperEduClsRela))!值:$(pobjPaperEduClsRelaEN.id_CurrEduCls)(clsPaperEduClsRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperEduClsRelaEN.updUser) == false && (0, clsString_js_1.GetStrLen)(pobjPaperEduClsRelaEN.updUser) > 20) {
            throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 论文教学班关系(PaperEduClsRela))!值:$(pobjPaperEduClsRelaEN.updUser)(clsPaperEduClsRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperEduClsRelaEN.updDate) == false && (0, clsString_js_1.GetStrLen)(pobjPaperEduClsRelaEN.updDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 论文教学班关系(PaperEduClsRela))!值:$(pobjPaperEduClsRelaEN.updDate)(clsPaperEduClsRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperEduClsRelaEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjPaperEduClsRelaEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 论文教学班关系(PaperEduClsRela))!值:$(pobjPaperEduClsRelaEN.memo)(clsPaperEduClsRelaBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if (null != pobjPaperEduClsRelaEN.mId && undefined !== pobjPaperEduClsRelaEN.mId && jsString_js_1.tzDataType.isNumber(pobjPaperEduClsRelaEN.mId) === false) {
            throw new Error("(errid:Watl000063)字段[mId(mId)]的值:[$(pobjPaperEduClsRelaEN.mId)], 非法，应该为数值型(In 论文教学班关系(PaperEduClsRela))!(clsPaperEduClsRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperEduClsRelaEN.paperId) == false && undefined !== pobjPaperEduClsRelaEN.paperId && jsString_js_1.tzDataType.isString(pobjPaperEduClsRelaEN.paperId) === false) {
            throw new Error("(errid:Watl000063)字段[论文Id(paperId)]的值:[$(pobjPaperEduClsRelaEN.paperId)], 非法，应该为字符型(In 论文教学班关系(PaperEduClsRela))!(clsPaperEduClsRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperEduClsRelaEN.id_CurrEduCls) == false && undefined !== pobjPaperEduClsRelaEN.id_CurrEduCls && jsString_js_1.tzDataType.isString(pobjPaperEduClsRelaEN.id_CurrEduCls) === false) {
            throw new Error("(errid:Watl000063)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjPaperEduClsRelaEN.id_CurrEduCls)], 非法，应该为字符型(In 论文教学班关系(PaperEduClsRela))!(clsPaperEduClsRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperEduClsRelaEN.updUser) == false && undefined !== pobjPaperEduClsRelaEN.updUser && jsString_js_1.tzDataType.isString(pobjPaperEduClsRelaEN.updUser) === false) {
            throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjPaperEduClsRelaEN.updUser)], 非法，应该为字符型(In 论文教学班关系(PaperEduClsRela))!(clsPaperEduClsRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperEduClsRelaEN.updDate) == false && undefined !== pobjPaperEduClsRelaEN.updDate && jsString_js_1.tzDataType.isString(pobjPaperEduClsRelaEN.updDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjPaperEduClsRelaEN.updDate)], 非法，应该为字符型(In 论文教学班关系(PaperEduClsRela))!(clsPaperEduClsRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperEduClsRelaEN.memo) == false && undefined !== pobjPaperEduClsRelaEN.memo && jsString_js_1.tzDataType.isString(pobjPaperEduClsRelaEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjPaperEduClsRelaEN.memo)], 非法，应该为字符型(In 论文教学班关系(PaperEduClsRela))!(clsPaperEduClsRelaBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if (null === pobjPaperEduClsRelaEN.mId
            || pobjPaperEduClsRelaEN.mId != null && pobjPaperEduClsRelaEN.mId.toString() === "") {
            throw new Error("(errid:Watl000064)字段[mId]不能为空(In 论文教学班关系)!(clsPaperEduClsRelaBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjPaperEduClsRelaEN.SetIsCheckProperty(true);
    }
    exports.PaperEduClsRela_CheckProperty4Update = PaperEduClsRela_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function PaperEduClsRela_GetJSONStrByObj(pobjPaperEduClsRelaEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjPaperEduClsRelaEN.sf_UpdFldSetStr = pobjPaperEduClsRelaEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjPaperEduClsRelaEN);
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
    exports.PaperEduClsRela_GetJSONStrByObj = PaperEduClsRela_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function PaperEduClsRela_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrPaperEduClsRelaObjLst = new Array();
        if (strJSON === "") {
            return arrPaperEduClsRelaObjLst;
        }
        try {
            arrPaperEduClsRelaObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrPaperEduClsRelaObjLst;
        }
        return arrPaperEduClsRelaObjLst;
    }
    exports.PaperEduClsRela_GetObjLstByJSONStr = PaperEduClsRela_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrPaperEduClsRelaObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function PaperEduClsRela_GetObjLstByJSONObjLst(arrPaperEduClsRelaObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrPaperEduClsRelaObjLst = new Array();
        for (const objInFor of arrPaperEduClsRelaObjLstS) {
            const obj1 = PaperEduClsRela_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrPaperEduClsRelaObjLst.push(obj1);
        }
        return arrPaperEduClsRelaObjLst;
    }
    exports.PaperEduClsRela_GetObjLstByJSONObjLst = PaperEduClsRela_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function PaperEduClsRela_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjPaperEduClsRelaEN = new clsPaperEduClsRelaEN_js_1.clsPaperEduClsRelaEN();
        if (strJSON === "") {
            return pobjPaperEduClsRelaEN;
        }
        try {
            pobjPaperEduClsRelaEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjPaperEduClsRelaEN;
        }
        return pobjPaperEduClsRelaEN;
    }
    exports.PaperEduClsRela_GetObjByJSONStr = PaperEduClsRela_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function PaperEduClsRela_GetCombineCondition(objPaperEduClsRela_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objPaperEduClsRela_Cond.dicFldComparisonOp, clsPaperEduClsRelaEN_js_1.clsPaperEduClsRelaEN.con_mId) == true) {
            const strComparisonOp_mId = objPaperEduClsRela_Cond.dicFldComparisonOp[clsPaperEduClsRelaEN_js_1.clsPaperEduClsRelaEN.con_mId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsPaperEduClsRelaEN_js_1.clsPaperEduClsRelaEN.con_mId, objPaperEduClsRela_Cond.mId, strComparisonOp_mId);
        }
        if (Object.prototype.hasOwnProperty.call(objPaperEduClsRela_Cond.dicFldComparisonOp, clsPaperEduClsRelaEN_js_1.clsPaperEduClsRelaEN.con_PaperId) == true) {
            const strComparisonOp_PaperId = objPaperEduClsRela_Cond.dicFldComparisonOp[clsPaperEduClsRelaEN_js_1.clsPaperEduClsRelaEN.con_PaperId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsPaperEduClsRelaEN_js_1.clsPaperEduClsRelaEN.con_PaperId, objPaperEduClsRela_Cond.paperId, strComparisonOp_PaperId);
        }
        if (Object.prototype.hasOwnProperty.call(objPaperEduClsRela_Cond.dicFldComparisonOp, clsPaperEduClsRelaEN_js_1.clsPaperEduClsRelaEN.con_id_CurrEduCls) == true) {
            const strComparisonOp_id_CurrEduCls = objPaperEduClsRela_Cond.dicFldComparisonOp[clsPaperEduClsRelaEN_js_1.clsPaperEduClsRelaEN.con_id_CurrEduCls];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsPaperEduClsRelaEN_js_1.clsPaperEduClsRelaEN.con_id_CurrEduCls, objPaperEduClsRela_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
        }
        if (Object.prototype.hasOwnProperty.call(objPaperEduClsRela_Cond.dicFldComparisonOp, clsPaperEduClsRelaEN_js_1.clsPaperEduClsRelaEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objPaperEduClsRela_Cond.dicFldComparisonOp[clsPaperEduClsRelaEN_js_1.clsPaperEduClsRelaEN.con_UpdUser];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsPaperEduClsRelaEN_js_1.clsPaperEduClsRelaEN.con_UpdUser, objPaperEduClsRela_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objPaperEduClsRela_Cond.dicFldComparisonOp, clsPaperEduClsRelaEN_js_1.clsPaperEduClsRelaEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objPaperEduClsRela_Cond.dicFldComparisonOp[clsPaperEduClsRelaEN_js_1.clsPaperEduClsRelaEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsPaperEduClsRelaEN_js_1.clsPaperEduClsRelaEN.con_UpdDate, objPaperEduClsRela_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objPaperEduClsRela_Cond.dicFldComparisonOp, clsPaperEduClsRelaEN_js_1.clsPaperEduClsRelaEN.con_Memo) == true) {
            const strComparisonOp_Memo = objPaperEduClsRela_Cond.dicFldComparisonOp[clsPaperEduClsRelaEN_js_1.clsPaperEduClsRelaEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsPaperEduClsRelaEN_js_1.clsPaperEduClsRelaEN.con_Memo, objPaperEduClsRela_Cond.memo, strComparisonOp_Memo);
        }
        return strWhereCond;
    }
    exports.PaperEduClsRela_GetCombineCondition = PaperEduClsRela_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--PaperEduClsRela(论文教学班关系),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param strPaperId: 论文Id(要求唯一的字段)
    * @param strid_CurrEduCls: 教学班流水号(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function PaperEduClsRela_GetUniCondStr_PaperId_id_CurrEduCls(objPaperEduClsRelaEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and PaperId = '{0}'", objPaperEduClsRelaEN.paperId);
        strWhereCond += (0, clsString_js_1.Format)(" and id_CurrEduCls = '{0}'", objPaperEduClsRelaEN.id_CurrEduCls);
        return strWhereCond;
    }
    exports.PaperEduClsRela_GetUniCondStr_PaperId_id_CurrEduCls = PaperEduClsRela_GetUniCondStr_PaperId_id_CurrEduCls;
    /**
    *获取唯一性条件串(Uniqueness)--PaperEduClsRela(论文教学班关系),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param strPaperId: 论文Id(要求唯一的字段)
    * @param strid_CurrEduCls: 教学班流水号(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function PaperEduClsRela_GetUniCondStr4Update_PaperId_id_CurrEduCls(objPaperEduClsRelaEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and mId <> '{0}'", objPaperEduClsRelaEN.mId);
        strWhereCond += (0, clsString_js_1.Format)(" and PaperId = '{0}'", objPaperEduClsRelaEN.paperId);
        strWhereCond += (0, clsString_js_1.Format)(" and id_CurrEduCls = '{0}'", objPaperEduClsRelaEN.id_CurrEduCls);
        return strWhereCond;
    }
    exports.PaperEduClsRela_GetUniCondStr4Update_PaperId_id_CurrEduCls = PaperEduClsRela_GetUniCondStr4Update_PaperId_id_CurrEduCls;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objPaperEduClsRelaENS:源对象
     * @param objPaperEduClsRelaENT:目标对象
    */
    function PaperEduClsRela_CopyObjTo(objPaperEduClsRelaENS, objPaperEduClsRelaENT) {
        objPaperEduClsRelaENT.mId = objPaperEduClsRelaENS.mId; //mId
        objPaperEduClsRelaENT.paperId = objPaperEduClsRelaENS.paperId; //论文Id
        objPaperEduClsRelaENT.id_CurrEduCls = objPaperEduClsRelaENS.id_CurrEduCls; //教学班流水号
        objPaperEduClsRelaENT.updUser = objPaperEduClsRelaENS.updUser; //修改人
        objPaperEduClsRelaENT.updDate = objPaperEduClsRelaENS.updDate; //修改日期
        objPaperEduClsRelaENT.memo = objPaperEduClsRelaENS.memo; //备注
        objPaperEduClsRelaENT.sf_UpdFldSetStr = objPaperEduClsRelaENS.updFldString; //sf_UpdFldSetStr
    }
    exports.PaperEduClsRela_CopyObjTo = PaperEduClsRela_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objPaperEduClsRelaENS:源对象
     * @param objPaperEduClsRelaENT:目标对象
    */
    function PaperEduClsRela_GetObjFromJsonObj(objPaperEduClsRelaENS) {
        const objPaperEduClsRelaENT = new clsPaperEduClsRelaEN_js_1.clsPaperEduClsRelaEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objPaperEduClsRelaENT, objPaperEduClsRelaENS);
        return objPaperEduClsRelaENT;
    }
    exports.PaperEduClsRela_GetObjFromJsonObj = PaperEduClsRela_GetObjFromJsonObj;
});
