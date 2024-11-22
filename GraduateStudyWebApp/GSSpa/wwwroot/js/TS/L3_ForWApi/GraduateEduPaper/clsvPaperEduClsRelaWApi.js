/**
* 类名:clsvPaperEduClsRelaWApi
* 表名:vPaperEduClsRela(01120932)
* 生成代码版本:2022.11.02.1
* 生成日期:2022/11/02 12:02:44
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
        define(["require", "exports", "axios", "../../PubFun/CacheHelper.js", "../../L0_Entity/GraduateEduPaper/clsvPaperEduClsRelaEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsSysPara4WebApi.js", "../../PubFun/CacheHelper.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.vPaperEduClsRela_GetObjFromJsonObj = exports.vPaperEduClsRela_CopyObjTo = exports.vPaperEduClsRela_GetCombineCondition = exports.vPaperEduClsRela_GetObjByJSONStr = exports.vPaperEduClsRela_GetObjLstByJSONObjLst = exports.vPaperEduClsRela_GetObjLstByJSONStr = exports.vPaperEduClsRela_GetJSONStrByObj = exports.vPaperEduClsRela_BindDdl_PaperIdInDiv_Cache = exports.vPaperEduClsRela_ReFreshThisCache = exports.vPaperEduClsRela_GetWebApiUrl = exports.vPaperEduClsRela_GetRecCountByCond_Cache = exports.vPaperEduClsRela_GetRecCountByCondAsync = exports.vPaperEduClsRela_IsExistAsync = exports.vPaperEduClsRela_IsExist_Cache = exports.vPaperEduClsRela_IsExist = exports.vPaperEduClsRela_IsExistRecordAsync = exports.vPaperEduClsRela_IsExistRecord_Cache = exports.vPaperEduClsRela_GetObjLstByPagerAsync = exports.vPaperEduClsRela_GetObjLstByPager_Cache = exports.vPaperEduClsRela_GetObjLstByRange = exports.vPaperEduClsRela_GetObjLstByRangeAsync = exports.vPaperEduClsRela_GetTopObjLstAsync = exports.vPaperEduClsRela_GetObjLstBymIdLst_Cache = exports.vPaperEduClsRela_GetObjLstBymIdLstAsync = exports.vPaperEduClsRela_GetSubObjLst_Cache = exports.vPaperEduClsRela_GetObjLst_PureCache = exports.vPaperEduClsRela_GetObjLst_Cache = exports.vPaperEduClsRela_GetObjLst_sessionStorage_PureCache = exports.vPaperEduClsRela_GetObjLst_sessionStorage = exports.vPaperEduClsRela_GetObjLstAsync = exports.vPaperEduClsRela_GetObjLst_localStorage_PureCache = exports.vPaperEduClsRela_GetObjLst_localStorage = exports.vPaperEduClsRela_GetObjLst_ClientCache = exports.vPaperEduClsRela_GetFirstObjAsync = exports.vPaperEduClsRela_GetFirstID = exports.vPaperEduClsRela_GetFirstIDAsync = exports.vPaperEduClsRela_FilterFunByKey = exports.vPaperEduClsRela_SortFunByKey = exports.vPaperEduClsRela_SortFun_Defa_2Fld = exports.vPaperEduClsRela_SortFun_Defa = exports.vPaperEduClsRela_func = exports.vPaperEduClsRela_GetObjBymId_localStorage = exports.vPaperEduClsRela_GetObjBymId_Cache = exports.vPaperEduClsRela_GetObjBymIdAsync = exports.vPaperEduClsRela_ConstructorName = exports.vPaperEduClsRela_Controller = void 0;
    /**
     * vPaperEduClsRela(vPaperEduClsRela)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2022年11月02日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsvPaperEduClsRelaEN_js_1 = require("../../L0_Entity/GraduateEduPaper/clsvPaperEduClsRelaEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    const CacheHelper_js_2 = require("../../PubFun/CacheHelper.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.vPaperEduClsRela_Controller = "vPaperEduClsRelaApi";
    exports.vPaperEduClsRela_ConstructorName = "vPaperEduClsRela";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param lngmId:关键字
    * @returns 对象
    **/
    async function vPaperEduClsRela_GetObjBymIdAsync(lngmId) {
        const strThisFuncName = "GetObjBymIdAsync";
        if (lngmId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngmId]不能为空！(In GetObjBymIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjBymId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperEduClsRela_Controller, strAction);
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
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vPaperEduClsRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objvPaperEduClsRela = vPaperEduClsRela_GetObjFromJsonObj(returnObj);
                return objvPaperEduClsRela;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperEduClsRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperEduClsRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperEduClsRela_GetObjBymIdAsync = vPaperEduClsRela_GetObjBymIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param lngmId:所给的关键字
     * @returns 对象
    */
    async function vPaperEduClsRela_GetObjBymId_Cache(lngmId, strid_CurrEduCls, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjBymId_Cache";
        if (lngmId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngmId]不能为空！(In GetObjBymId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        const arrvPaperEduClsRelaObjLst_Cache = await vPaperEduClsRela_GetObjLst_Cache(strid_CurrEduCls);
        try {
            const arrvPaperEduClsRela_Sel = arrvPaperEduClsRelaObjLst_Cache.filter(x => x.mId == lngmId);
            let objvPaperEduClsRela;
            if (arrvPaperEduClsRela_Sel.length > 0) {
                objvPaperEduClsRela = arrvPaperEduClsRela_Sel[0];
                return objvPaperEduClsRela;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    objvPaperEduClsRela = await vPaperEduClsRela_GetObjBymIdAsync(lngmId);
                    if (objvPaperEduClsRela != null) {
                        vPaperEduClsRela_ReFreshThisCache(strid_CurrEduCls);
                        return objvPaperEduClsRela;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngmId, exports.vPaperEduClsRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.vPaperEduClsRela_GetObjBymId_Cache = vPaperEduClsRela_GetObjBymId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param lngmId:所给的关键字
     * @returns 对象
    */
    async function vPaperEduClsRela_GetObjBymId_localStorage(lngmId) {
        const strThisFuncName = "GetObjBymId_localStorage";
        if (lngmId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngmId]不能为空！(In GetObjBymId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvPaperEduClsRelaEN_js_1.clsvPaperEduClsRelaEN._CurrTabName, lngmId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objvPaperEduClsRela_Cache = JSON.parse(strTempObj);
            return objvPaperEduClsRela_Cache;
        }
        try {
            const objvPaperEduClsRela = await vPaperEduClsRela_GetObjBymIdAsync(lngmId);
            if (objvPaperEduClsRela != null) {
                localStorage.setItem(strKey, JSON.stringify(objvPaperEduClsRela));
                const strInfo = (0, clsString_js_1.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objvPaperEduClsRela;
            }
            return objvPaperEduClsRela;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngmId, exports.vPaperEduClsRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.vPaperEduClsRela_GetObjBymId_localStorage = vPaperEduClsRela_GetObjBymId_localStorage;
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
    async function vPaperEduClsRela_func(strInFldName, strOutFldName, strInValue, strid_CurrEduCls_C) {
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
        if (strInFldName != clsvPaperEduClsRelaEN_js_1.clsvPaperEduClsRelaEN.con_mId) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsvPaperEduClsRelaEN_js_1.clsvPaperEduClsRelaEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_1.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strInFldName, clsvPaperEduClsRelaEN_js_1.clsvPaperEduClsRelaEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const lngmId = Number(strInValue);
        if (lngmId == 0) {
            return "";
        }
        const objvPaperEduClsRela = await vPaperEduClsRela_GetObjBymId_Cache(lngmId, strid_CurrEduCls_C);
        if (objvPaperEduClsRela == null)
            return "";
        return objvPaperEduClsRela.GetFldValue(strOutFldName).toString();
    }
    exports.vPaperEduClsRela_func = vPaperEduClsRela_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vPaperEduClsRela_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.mId - b.mId;
    }
    exports.vPaperEduClsRela_SortFun_Defa = vPaperEduClsRela_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vPaperEduClsRela_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.paperId == b.paperId)
            return a.paperTitle.localeCompare(b.paperTitle);
        else
            return a.paperId.localeCompare(b.paperId);
    }
    exports.vPaperEduClsRela_SortFun_Defa_2Fld = vPaperEduClsRela_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vPaperEduClsRela_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsvPaperEduClsRelaEN_js_1.clsvPaperEduClsRelaEN.con_mId:
                    return (a, b) => {
                        return a.mId - b.mId;
                    };
                case clsvPaperEduClsRelaEN_js_1.clsvPaperEduClsRelaEN.con_PaperId:
                    return (a, b) => {
                        return a.paperId.localeCompare(b.paperId);
                    };
                case clsvPaperEduClsRelaEN_js_1.clsvPaperEduClsRelaEN.con_PaperTitle:
                    return (a, b) => {
                        return a.paperTitle.localeCompare(b.paperTitle);
                    };
                case clsvPaperEduClsRelaEN_js_1.clsvPaperEduClsRelaEN.con_Author:
                    return (a, b) => {
                        return a.author.localeCompare(b.author);
                    };
                case clsvPaperEduClsRelaEN_js_1.clsvPaperEduClsRelaEN.con_id_CurrEduCls:
                    return (a, b) => {
                        return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
                    };
                case clsvPaperEduClsRelaEN_js_1.clsvPaperEduClsRelaEN.con_UpdUser:
                    return (a, b) => {
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsvPaperEduClsRelaEN_js_1.clsvPaperEduClsRelaEN.con_UpdDate:
                    return (a, b) => {
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsvPaperEduClsRelaEN_js_1.clsvPaperEduClsRelaEN.con_Memo:
                    return (a, b) => {
                        return a.memo.localeCompare(b.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vPaperEduClsRela]中不存在！(in ${exports.vPaperEduClsRela_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsvPaperEduClsRelaEN_js_1.clsvPaperEduClsRelaEN.con_mId:
                    return (a, b) => {
                        return b.mId - a.mId;
                    };
                case clsvPaperEduClsRelaEN_js_1.clsvPaperEduClsRelaEN.con_PaperId:
                    return (a, b) => {
                        return b.paperId.localeCompare(a.paperId);
                    };
                case clsvPaperEduClsRelaEN_js_1.clsvPaperEduClsRelaEN.con_PaperTitle:
                    return (a, b) => {
                        return b.paperTitle.localeCompare(a.paperTitle);
                    };
                case clsvPaperEduClsRelaEN_js_1.clsvPaperEduClsRelaEN.con_Author:
                    return (a, b) => {
                        return b.author.localeCompare(a.author);
                    };
                case clsvPaperEduClsRelaEN_js_1.clsvPaperEduClsRelaEN.con_id_CurrEduCls:
                    return (a, b) => {
                        return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
                    };
                case clsvPaperEduClsRelaEN_js_1.clsvPaperEduClsRelaEN.con_UpdUser:
                    return (a, b) => {
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsvPaperEduClsRelaEN_js_1.clsvPaperEduClsRelaEN.con_UpdDate:
                    return (a, b) => {
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsvPaperEduClsRelaEN_js_1.clsvPaperEduClsRelaEN.con_Memo:
                    return (a, b) => {
                        return b.memo.localeCompare(a.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vPaperEduClsRela]中不存在！(in ${exports.vPaperEduClsRela_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.vPaperEduClsRela_SortFunByKey = vPaperEduClsRela_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function vPaperEduClsRela_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsvPaperEduClsRelaEN_js_1.clsvPaperEduClsRelaEN.con_mId:
                return (obj) => {
                    return obj.mId === value;
                };
            case clsvPaperEduClsRelaEN_js_1.clsvPaperEduClsRelaEN.con_PaperId:
                return (obj) => {
                    return obj.paperId === value;
                };
            case clsvPaperEduClsRelaEN_js_1.clsvPaperEduClsRelaEN.con_PaperTitle:
                return (obj) => {
                    return obj.paperTitle === value;
                };
            case clsvPaperEduClsRelaEN_js_1.clsvPaperEduClsRelaEN.con_Author:
                return (obj) => {
                    return obj.author === value;
                };
            case clsvPaperEduClsRelaEN_js_1.clsvPaperEduClsRelaEN.con_id_CurrEduCls:
                return (obj) => {
                    return obj.id_CurrEduCls === value;
                };
            case clsvPaperEduClsRelaEN_js_1.clsvPaperEduClsRelaEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsvPaperEduClsRelaEN_js_1.clsvPaperEduClsRelaEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsvPaperEduClsRelaEN_js_1.clsvPaperEduClsRelaEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[vPaperEduClsRela]中不存在！(in ${exports.vPaperEduClsRela_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.vPaperEduClsRela_FilterFunByKey = vPaperEduClsRela_FilterFunByKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function vPaperEduClsRela_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperEduClsRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperEduClsRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperEduClsRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperEduClsRela_GetFirstIDAsync = vPaperEduClsRela_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function vPaperEduClsRela_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperEduClsRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperEduClsRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperEduClsRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperEduClsRela_GetFirstID = vPaperEduClsRela_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function vPaperEduClsRela_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperEduClsRela_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vPaperEduClsRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objvPaperEduClsRela = vPaperEduClsRela_GetObjFromJsonObj(returnObj);
                return objvPaperEduClsRela;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperEduClsRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperEduClsRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperEduClsRela_GetFirstObjAsync = vPaperEduClsRela_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vPaperEduClsRela_GetObjLst_ClientCache(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvPaperEduClsRelaEN_js_1.clsvPaperEduClsRelaEN._CurrTabName, strid_CurrEduCls);
        clsvPaperEduClsRelaEN_js_1.clsvPaperEduClsRelaEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsvPaperEduClsRelaEN_js_1.clsvPaperEduClsRelaEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvPaperEduClsRelaEN_js_1.clsvPaperEduClsRelaEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvPaperEduClsRelaEN_js_1.clsvPaperEduClsRelaEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_2.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrvPaperEduClsRelaExObjLst_Cache = CacheHelper_js_2.CacheHelper.Get(strKey);
            const arrvPaperEduClsRelaObjLst_T = vPaperEduClsRela_GetObjLstByJSONObjLst(arrvPaperEduClsRelaExObjLst_Cache);
            return arrvPaperEduClsRelaObjLst_T;
        }
        try {
            const arrvPaperEduClsRelaExObjLst = await vPaperEduClsRela_GetObjLstAsync(strWhereCond);
            CacheHelper_js_2.CacheHelper.Add(strKey, arrvPaperEduClsRelaExObjLst);
            const strInfo = (0, clsString_js_1.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvPaperEduClsRelaExObjLst.length);
            console.log(strInfo);
            return arrvPaperEduClsRelaExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vPaperEduClsRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vPaperEduClsRela_GetObjLst_ClientCache = vPaperEduClsRela_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vPaperEduClsRela_GetObjLst_localStorage(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvPaperEduClsRelaEN_js_1.clsvPaperEduClsRelaEN._CurrTabName, strid_CurrEduCls);
        clsvPaperEduClsRelaEN_js_1.clsvPaperEduClsRelaEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsvPaperEduClsRelaEN_js_1.clsvPaperEduClsRelaEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvPaperEduClsRelaEN_js_1.clsvPaperEduClsRelaEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvPaperEduClsRelaEN_js_1.clsvPaperEduClsRelaEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrvPaperEduClsRelaExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrvPaperEduClsRelaObjLst_T = vPaperEduClsRela_GetObjLstByJSONObjLst(arrvPaperEduClsRelaExObjLst_Cache);
            return arrvPaperEduClsRelaObjLst_T;
        }
        try {
            const arrvPaperEduClsRelaExObjLst = await vPaperEduClsRela_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrvPaperEduClsRelaExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvPaperEduClsRelaExObjLst.length);
            console.log(strInfo);
            return arrvPaperEduClsRelaExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vPaperEduClsRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vPaperEduClsRela_GetObjLst_localStorage = vPaperEduClsRela_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vPaperEduClsRela_GetObjLst_localStorage_PureCache(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvPaperEduClsRelaEN_js_1.clsvPaperEduClsRelaEN._CurrTabName, strid_CurrEduCls);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrvPaperEduClsRelaObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvPaperEduClsRelaObjLst_Cache;
        }
        else
            return null;
    }
    exports.vPaperEduClsRela_GetObjLst_localStorage_PureCache = vPaperEduClsRela_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function vPaperEduClsRela_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperEduClsRela_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vPaperEduClsRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vPaperEduClsRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperEduClsRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperEduClsRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperEduClsRela_GetObjLstAsync = vPaperEduClsRela_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vPaperEduClsRela_GetObjLst_sessionStorage(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvPaperEduClsRelaEN_js_1.clsvPaperEduClsRelaEN._CurrTabName, strid_CurrEduCls);
        clsvPaperEduClsRelaEN_js_1.clsvPaperEduClsRelaEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsvPaperEduClsRelaEN_js_1.clsvPaperEduClsRelaEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvPaperEduClsRelaEN_js_1.clsvPaperEduClsRelaEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvPaperEduClsRelaEN_js_1.clsvPaperEduClsRelaEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrvPaperEduClsRelaExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrvPaperEduClsRelaObjLst_T = vPaperEduClsRela_GetObjLstByJSONObjLst(arrvPaperEduClsRelaExObjLst_Cache);
            return arrvPaperEduClsRelaObjLst_T;
        }
        try {
            const arrvPaperEduClsRelaExObjLst = await vPaperEduClsRela_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrvPaperEduClsRelaExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvPaperEduClsRelaExObjLst.length);
            console.log(strInfo);
            return arrvPaperEduClsRelaExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vPaperEduClsRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vPaperEduClsRela_GetObjLst_sessionStorage = vPaperEduClsRela_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vPaperEduClsRela_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvPaperEduClsRelaEN_js_1.clsvPaperEduClsRelaEN._CurrTabName, strid_CurrEduCls);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrvPaperEduClsRelaObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvPaperEduClsRelaObjLst_Cache;
        }
        else
            return null;
    }
    exports.vPaperEduClsRela_GetObjLst_sessionStorage_PureCache = vPaperEduClsRela_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vPaperEduClsRela_GetObjLst_Cache(strid_CurrEduCls) {
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
        let arrvPaperEduClsRelaObjLst_Cache;
        switch (clsvPaperEduClsRelaEN_js_1.clsvPaperEduClsRelaEN.CacheModeId) {
            case "04": //sessionStorage
                arrvPaperEduClsRelaObjLst_Cache = await vPaperEduClsRela_GetObjLst_sessionStorage(strid_CurrEduCls);
                break;
            case "03": //localStorage
                arrvPaperEduClsRelaObjLst_Cache = await vPaperEduClsRela_GetObjLst_localStorage(strid_CurrEduCls);
                break;
            case "02": //ClientCache
                arrvPaperEduClsRelaObjLst_Cache = await vPaperEduClsRela_GetObjLst_ClientCache(strid_CurrEduCls);
                break;
            default:
                arrvPaperEduClsRelaObjLst_Cache = await vPaperEduClsRela_GetObjLst_ClientCache(strid_CurrEduCls);
                break;
        }
        const arrvPaperEduClsRelaObjLst = vPaperEduClsRela_GetObjLstByJSONObjLst(arrvPaperEduClsRelaObjLst_Cache);
        return arrvPaperEduClsRelaObjLst_Cache;
    }
    exports.vPaperEduClsRela_GetObjLst_Cache = vPaperEduClsRela_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vPaperEduClsRela_GetObjLst_PureCache(strid_CurrEduCls) {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrvPaperEduClsRelaObjLst_Cache;
        switch (clsvPaperEduClsRelaEN_js_1.clsvPaperEduClsRelaEN.CacheModeId) {
            case "04": //sessionStorage
                arrvPaperEduClsRelaObjLst_Cache = await vPaperEduClsRela_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls);
                break;
            case "03": //localStorage
                arrvPaperEduClsRelaObjLst_Cache = await vPaperEduClsRela_GetObjLst_localStorage_PureCache(strid_CurrEduCls);
                break;
            case "02": //ClientCache
                arrvPaperEduClsRelaObjLst_Cache = null;
                break;
            default:
                arrvPaperEduClsRelaObjLst_Cache = null;
                break;
        }
        return arrvPaperEduClsRelaObjLst_Cache;
    }
    exports.vPaperEduClsRela_GetObjLst_PureCache = vPaperEduClsRela_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objlngmId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function vPaperEduClsRela_GetSubObjLst_Cache(objvPaperEduClsRela_Cond, strid_CurrEduCls) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrvPaperEduClsRelaObjLst_Cache = await vPaperEduClsRela_GetObjLst_Cache(strid_CurrEduCls);
        let arrvPaperEduClsRela_Sel = arrvPaperEduClsRelaObjLst_Cache;
        if (objvPaperEduClsRela_Cond.sf_FldComparisonOp == null || objvPaperEduClsRela_Cond.sf_FldComparisonOp == "")
            return arrvPaperEduClsRela_Sel;
        const dicFldComparisonOp = JSON.parse(objvPaperEduClsRela_Cond.sf_FldComparisonOp);
        //console.log("clsvPaperEduClsRelaWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvPaperEduClsRela_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvPaperEduClsRela_Sel = arrvPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvPaperEduClsRela_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvPaperEduClsRela_Sel = arrvPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvPaperEduClsRela_Sel = arrvPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvPaperEduClsRela_Sel = arrvPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvPaperEduClsRela_Sel = arrvPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvPaperEduClsRela_Sel = arrvPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvPaperEduClsRela_Sel = arrvPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvPaperEduClsRela_Sel = arrvPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvPaperEduClsRela_Sel = arrvPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrvPaperEduClsRela_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objvPaperEduClsRela_Cond), exports.vPaperEduClsRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vPaperEduClsRela_GetSubObjLst_Cache = vPaperEduClsRela_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrmId:关键字列表
    * @returns 对象列表
    **/
    async function vPaperEduClsRela_GetObjLstBymIdLstAsync(arrmId) {
        const strThisFuncName = "GetObjLstBymIdLstAsync";
        const strAction = "GetObjLstBymIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperEduClsRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrmId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vPaperEduClsRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vPaperEduClsRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperEduClsRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperEduClsRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperEduClsRela_GetObjLstBymIdLstAsync = vPaperEduClsRela_GetObjLstBymIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrlngmIdLst:关键字列表
     * @returns 对象列表
    */
    async function vPaperEduClsRela_GetObjLstBymIdLst_Cache(arrmIdLst, strid_CurrEduCls) {
        const strThisFuncName = "GetObjLstBymIdLst_Cache";
        try {
            const arrvPaperEduClsRelaObjLst_Cache = await vPaperEduClsRela_GetObjLst_Cache(strid_CurrEduCls);
            const arrvPaperEduClsRela_Sel = arrvPaperEduClsRelaObjLst_Cache.filter(x => arrmIdLst.indexOf(x.mId) > -1);
            return arrvPaperEduClsRela_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrmIdLst.join(","), exports.vPaperEduClsRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vPaperEduClsRela_GetObjLstBymIdLst_Cache = vPaperEduClsRela_GetObjLstBymIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function vPaperEduClsRela_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperEduClsRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vPaperEduClsRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vPaperEduClsRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperEduClsRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperEduClsRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperEduClsRela_GetTopObjLstAsync = vPaperEduClsRela_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vPaperEduClsRela_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperEduClsRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vPaperEduClsRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vPaperEduClsRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperEduClsRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperEduClsRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperEduClsRela_GetObjLstByRangeAsync = vPaperEduClsRela_GetObjLstByRangeAsync;
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
    async function vPaperEduClsRela_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperEduClsRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperEduClsRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperEduClsRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperEduClsRela_GetObjLstByRange = vPaperEduClsRela_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function vPaperEduClsRela_GetObjLstByPager_Cache(objPagerPara, strid_CurrEduCls) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const arrvPaperEduClsRelaObjLst_Cache = await vPaperEduClsRela_GetObjLst_Cache(strid_CurrEduCls);
        if (arrvPaperEduClsRelaObjLst_Cache.length == 0)
            return arrvPaperEduClsRelaObjLst_Cache;
        let arrvPaperEduClsRela_Sel = arrvPaperEduClsRelaObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objvPaperEduClsRela_Cond = new clsvPaperEduClsRelaEN_js_1.clsvPaperEduClsRelaEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvPaperEduClsRela_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsvPaperEduClsRelaWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvPaperEduClsRela_Sel = arrvPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvPaperEduClsRela_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvPaperEduClsRela_Sel = arrvPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvPaperEduClsRela_Sel = arrvPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrvPaperEduClsRela_Sel = arrvPaperEduClsRela_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvPaperEduClsRela_Sel = arrvPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvPaperEduClsRela_Sel = arrvPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvPaperEduClsRela_Sel = arrvPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvPaperEduClsRela_Sel = arrvPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvPaperEduClsRela_Sel = arrvPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvPaperEduClsRela_Sel = arrvPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvPaperEduClsRela_Sel.length == 0)
                return arrvPaperEduClsRela_Sel;
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
                arrvPaperEduClsRela_Sel = arrvPaperEduClsRela_Sel.sort(vPaperEduClsRela_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrvPaperEduClsRela_Sel = arrvPaperEduClsRela_Sel.sort(objPagerPara.sortFun);
            }
            arrvPaperEduClsRela_Sel = arrvPaperEduClsRela_Sel.slice(intStart, intEnd);
            return arrvPaperEduClsRela_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.vPaperEduClsRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vPaperEduClsRela_GetObjLstByPager_Cache = vPaperEduClsRela_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vPaperEduClsRela_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperEduClsRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vPaperEduClsRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vPaperEduClsRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperEduClsRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperEduClsRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperEduClsRela_GetObjLstByPagerAsync = vPaperEduClsRela_GetObjLstByPagerAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objlngmId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function vPaperEduClsRela_IsExistRecord_Cache(objvPaperEduClsRela_Cond, strid_CurrEduCls) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrvPaperEduClsRelaObjLst_Cache = await vPaperEduClsRela_GetObjLst_Cache(strid_CurrEduCls);
        if (arrvPaperEduClsRelaObjLst_Cache == null)
            return false;
        let arrvPaperEduClsRela_Sel = arrvPaperEduClsRelaObjLst_Cache;
        if (objvPaperEduClsRela_Cond.sf_FldComparisonOp == null || objvPaperEduClsRela_Cond.sf_FldComparisonOp == "")
            return arrvPaperEduClsRela_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objvPaperEduClsRela_Cond.sf_FldComparisonOp);
        //console.log("clsvPaperEduClsRelaWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvPaperEduClsRela_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvPaperEduClsRela_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvPaperEduClsRela_Sel = arrvPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvPaperEduClsRela_Sel = arrvPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvPaperEduClsRela_Sel = arrvPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvPaperEduClsRela_Sel = arrvPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvPaperEduClsRela_Sel = arrvPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvPaperEduClsRela_Sel = arrvPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvPaperEduClsRela_Sel = arrvPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvPaperEduClsRela_Sel = arrvPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvPaperEduClsRela_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objvPaperEduClsRela_Cond), exports.vPaperEduClsRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.vPaperEduClsRela_IsExistRecord_Cache = vPaperEduClsRela_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function vPaperEduClsRela_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperEduClsRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperEduClsRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperEduClsRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperEduClsRela_IsExistRecordAsync = vPaperEduClsRela_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param lngmId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function vPaperEduClsRela_IsExist(lngmId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperEduClsRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperEduClsRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperEduClsRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperEduClsRela_IsExist = vPaperEduClsRela_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param lngmId:所给的关键字
     * @returns 对象
    */
    async function vPaperEduClsRela_IsExist_Cache(lngmId, strid_CurrEduCls) {
        const strThisFuncName = "IsExist_Cache";
        const arrvPaperEduClsRelaObjLst_Cache = await vPaperEduClsRela_GetObjLst_Cache(strid_CurrEduCls);
        if (arrvPaperEduClsRelaObjLst_Cache == null)
            return false;
        try {
            const arrvPaperEduClsRela_Sel = arrvPaperEduClsRelaObjLst_Cache.filter(x => x.mId == lngmId);
            if (arrvPaperEduClsRela_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", lngmId, exports.vPaperEduClsRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.vPaperEduClsRela_IsExist_Cache = vPaperEduClsRela_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param lngmId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function vPaperEduClsRela_IsExistAsync(lngmId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperEduClsRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperEduClsRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperEduClsRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperEduClsRela_IsExistAsync = vPaperEduClsRela_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function vPaperEduClsRela_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperEduClsRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperEduClsRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperEduClsRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperEduClsRela_GetRecCountByCondAsync = vPaperEduClsRela_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objvPaperEduClsRela_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function vPaperEduClsRela_GetRecCountByCond_Cache(objvPaperEduClsRela_Cond, strid_CurrEduCls) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrvPaperEduClsRelaObjLst_Cache = await vPaperEduClsRela_GetObjLst_Cache(strid_CurrEduCls);
        if (arrvPaperEduClsRelaObjLst_Cache == null)
            return 0;
        let arrvPaperEduClsRela_Sel = arrvPaperEduClsRelaObjLst_Cache;
        if (objvPaperEduClsRela_Cond.sf_FldComparisonOp == null || objvPaperEduClsRela_Cond.sf_FldComparisonOp == "")
            return arrvPaperEduClsRela_Sel.length;
        const dicFldComparisonOp = JSON.parse(objvPaperEduClsRela_Cond.sf_FldComparisonOp);
        //console.log("clsvPaperEduClsRelaWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvPaperEduClsRela_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvPaperEduClsRela_Sel = arrvPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvPaperEduClsRela_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvPaperEduClsRela_Sel = arrvPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvPaperEduClsRela_Sel = arrvPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrvPaperEduClsRela_Sel = arrvPaperEduClsRela_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvPaperEduClsRela_Sel = arrvPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvPaperEduClsRela_Sel = arrvPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvPaperEduClsRela_Sel = arrvPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvPaperEduClsRela_Sel = arrvPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvPaperEduClsRela_Sel = arrvPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvPaperEduClsRela_Sel = arrvPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrvPaperEduClsRela_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objvPaperEduClsRela_Cond), exports.vPaperEduClsRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.vPaperEduClsRela_GetRecCountByCond_Cache = vPaperEduClsRela_GetRecCountByCond_Cache;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function vPaperEduClsRela_GetWebApiUrl(strController, strAction) {
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
    exports.vPaperEduClsRela_GetWebApiUrl = vPaperEduClsRela_GetWebApiUrl;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function vPaperEduClsRela_ReFreshThisCache(strid_CurrEduCls) {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvPaperEduClsRelaEN_js_1.clsvPaperEduClsRelaEN._CurrTabName, strid_CurrEduCls);
            switch (clsvPaperEduClsRelaEN_js_1.clsvPaperEduClsRelaEN.CacheModeId) {
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
    exports.vPaperEduClsRela_ReFreshThisCache = vPaperEduClsRela_ReFreshThisCache;
    /**
     * 绑定基于Web的下拉框,在某一层下的下拉框
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunctionInDiv)
     * @param objDDL:需要绑定当前表的下拉框
     * @param strid_CurrEduCls:教学班流水号
    */
    async function vPaperEduClsRela_BindDdl_PaperIdInDiv_Cache(strDivName, strDdlName, strid_CurrEduCls) {
        const strThisFuncName = "BindDdl_PaperIdInDiv_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strid_CurrEduCls) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strid_CurrEduCls]不能为空！(In BindDdl_PaperIdInDiv)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strid_CurrEduCls]的长度:[{0}]不正确！", strid_CurrEduCls.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const objDdl = document.getElementById(strDdlName);
        if (objDdl == null) {
            const strMsg = (0, clsString_js_1.Format)("下拉框：{0} 不存在！(In BindDdl_PaperIdInDiv)", strDdlName);
            alert(strMsg);
            console.error(strMsg);
            throw (strMsg);
        }
        //为数据源于表的下拉框设置内容
        //console.log("开始：BindDdl_PaperIdInDiv_Cache");
        let arrObjLst_Sel = await vPaperEduClsRela_GetObjLst_Cache(strid_CurrEduCls);
        if (arrObjLst_Sel == null)
            return;
        arrObjLst_Sel = arrObjLst_Sel.filter(x => x.id_CurrEduCls == strid_CurrEduCls);
        (0, clsCommFunc4Web_js_1.BindDdl_ObjLstInDiv_V)(strDivName, strDdlName, arrObjLst_Sel, clsvPaperEduClsRelaEN_js_1.clsvPaperEduClsRelaEN.con_PaperId, clsvPaperEduClsRelaEN_js_1.clsvPaperEduClsRelaEN.con_PaperTitle, "vPaperEduClsRela");
    }
    exports.vPaperEduClsRela_BindDdl_PaperIdInDiv_Cache = vPaperEduClsRela_BindDdl_PaperIdInDiv_Cache;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vPaperEduClsRela_GetJSONStrByObj(pobjvPaperEduClsRelaEN) {
        const strThisFuncName = "GetJSONStrByObj";
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjvPaperEduClsRelaEN);
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
    exports.vPaperEduClsRela_GetJSONStrByObj = vPaperEduClsRela_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function vPaperEduClsRela_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrvPaperEduClsRelaObjLst = new Array();
        if (strJSON === "") {
            return arrvPaperEduClsRelaObjLst;
        }
        try {
            arrvPaperEduClsRelaObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrvPaperEduClsRelaObjLst;
        }
        return arrvPaperEduClsRelaObjLst;
    }
    exports.vPaperEduClsRela_GetObjLstByJSONStr = vPaperEduClsRela_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrvPaperEduClsRelaObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function vPaperEduClsRela_GetObjLstByJSONObjLst(arrvPaperEduClsRelaObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrvPaperEduClsRelaObjLst = new Array();
        for (const objInFor of arrvPaperEduClsRelaObjLstS) {
            const obj1 = vPaperEduClsRela_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrvPaperEduClsRelaObjLst.push(obj1);
        }
        return arrvPaperEduClsRelaObjLst;
    }
    exports.vPaperEduClsRela_GetObjLstByJSONObjLst = vPaperEduClsRela_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vPaperEduClsRela_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjvPaperEduClsRelaEN = new clsvPaperEduClsRelaEN_js_1.clsvPaperEduClsRelaEN();
        if (strJSON === "") {
            return pobjvPaperEduClsRelaEN;
        }
        try {
            pobjvPaperEduClsRelaEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjvPaperEduClsRelaEN;
        }
        return pobjvPaperEduClsRelaEN;
    }
    exports.vPaperEduClsRela_GetObjByJSONStr = vPaperEduClsRela_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function vPaperEduClsRela_GetCombineCondition(objvPaperEduClsRela_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objvPaperEduClsRela_Cond.dicFldComparisonOp, clsvPaperEduClsRelaEN_js_1.clsvPaperEduClsRelaEN.con_mId) == true) {
            const strComparisonOp_mId = objvPaperEduClsRela_Cond.dicFldComparisonOp[clsvPaperEduClsRelaEN_js_1.clsvPaperEduClsRelaEN.con_mId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvPaperEduClsRelaEN_js_1.clsvPaperEduClsRelaEN.con_mId, objvPaperEduClsRela_Cond.mId, strComparisonOp_mId);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperEduClsRela_Cond.dicFldComparisonOp, clsvPaperEduClsRelaEN_js_1.clsvPaperEduClsRelaEN.con_PaperId) == true) {
            const strComparisonOp_PaperId = objvPaperEduClsRela_Cond.dicFldComparisonOp[clsvPaperEduClsRelaEN_js_1.clsvPaperEduClsRelaEN.con_PaperId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperEduClsRelaEN_js_1.clsvPaperEduClsRelaEN.con_PaperId, objvPaperEduClsRela_Cond.paperId, strComparisonOp_PaperId);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperEduClsRela_Cond.dicFldComparisonOp, clsvPaperEduClsRelaEN_js_1.clsvPaperEduClsRelaEN.con_PaperTitle) == true) {
            const strComparisonOp_PaperTitle = objvPaperEduClsRela_Cond.dicFldComparisonOp[clsvPaperEduClsRelaEN_js_1.clsvPaperEduClsRelaEN.con_PaperTitle];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperEduClsRelaEN_js_1.clsvPaperEduClsRelaEN.con_PaperTitle, objvPaperEduClsRela_Cond.paperTitle, strComparisonOp_PaperTitle);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperEduClsRela_Cond.dicFldComparisonOp, clsvPaperEduClsRelaEN_js_1.clsvPaperEduClsRelaEN.con_Author) == true) {
            const strComparisonOp_Author = objvPaperEduClsRela_Cond.dicFldComparisonOp[clsvPaperEduClsRelaEN_js_1.clsvPaperEduClsRelaEN.con_Author];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperEduClsRelaEN_js_1.clsvPaperEduClsRelaEN.con_Author, objvPaperEduClsRela_Cond.author, strComparisonOp_Author);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperEduClsRela_Cond.dicFldComparisonOp, clsvPaperEduClsRelaEN_js_1.clsvPaperEduClsRelaEN.con_id_CurrEduCls) == true) {
            const strComparisonOp_id_CurrEduCls = objvPaperEduClsRela_Cond.dicFldComparisonOp[clsvPaperEduClsRelaEN_js_1.clsvPaperEduClsRelaEN.con_id_CurrEduCls];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperEduClsRelaEN_js_1.clsvPaperEduClsRelaEN.con_id_CurrEduCls, objvPaperEduClsRela_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperEduClsRela_Cond.dicFldComparisonOp, clsvPaperEduClsRelaEN_js_1.clsvPaperEduClsRelaEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objvPaperEduClsRela_Cond.dicFldComparisonOp[clsvPaperEduClsRelaEN_js_1.clsvPaperEduClsRelaEN.con_UpdUser];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperEduClsRelaEN_js_1.clsvPaperEduClsRelaEN.con_UpdUser, objvPaperEduClsRela_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperEduClsRela_Cond.dicFldComparisonOp, clsvPaperEduClsRelaEN_js_1.clsvPaperEduClsRelaEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objvPaperEduClsRela_Cond.dicFldComparisonOp[clsvPaperEduClsRelaEN_js_1.clsvPaperEduClsRelaEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperEduClsRelaEN_js_1.clsvPaperEduClsRelaEN.con_UpdDate, objvPaperEduClsRela_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperEduClsRela_Cond.dicFldComparisonOp, clsvPaperEduClsRelaEN_js_1.clsvPaperEduClsRelaEN.con_Memo) == true) {
            const strComparisonOp_Memo = objvPaperEduClsRela_Cond.dicFldComparisonOp[clsvPaperEduClsRelaEN_js_1.clsvPaperEduClsRelaEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperEduClsRelaEN_js_1.clsvPaperEduClsRelaEN.con_Memo, objvPaperEduClsRela_Cond.memo, strComparisonOp_Memo);
        }
        return strWhereCond;
    }
    exports.vPaperEduClsRela_GetCombineCondition = vPaperEduClsRela_GetCombineCondition;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objvPaperEduClsRelaENS:源对象
     * @param objvPaperEduClsRelaENT:目标对象
    */
    function vPaperEduClsRela_CopyObjTo(objvPaperEduClsRelaENS, objvPaperEduClsRelaENT) {
        objvPaperEduClsRelaENT.mId = objvPaperEduClsRelaENS.mId; //mId
        objvPaperEduClsRelaENT.paperId = objvPaperEduClsRelaENS.paperId; //论文Id
        objvPaperEduClsRelaENT.paperTitle = objvPaperEduClsRelaENS.paperTitle; //论文标题
        objvPaperEduClsRelaENT.author = objvPaperEduClsRelaENS.author; //作者
        objvPaperEduClsRelaENT.id_CurrEduCls = objvPaperEduClsRelaENS.id_CurrEduCls; //教学班流水号
        objvPaperEduClsRelaENT.updUser = objvPaperEduClsRelaENS.updUser; //修改人
        objvPaperEduClsRelaENT.updDate = objvPaperEduClsRelaENS.updDate; //修改日期
        objvPaperEduClsRelaENT.memo = objvPaperEduClsRelaENS.memo; //备注
    }
    exports.vPaperEduClsRela_CopyObjTo = vPaperEduClsRela_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objvPaperEduClsRelaENS:源对象
     * @param objvPaperEduClsRelaENT:目标对象
    */
    function vPaperEduClsRela_GetObjFromJsonObj(objvPaperEduClsRelaENS) {
        const objvPaperEduClsRelaENT = new clsvPaperEduClsRelaEN_js_1.clsvPaperEduClsRelaEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvPaperEduClsRelaENT, objvPaperEduClsRelaENS);
        return objvPaperEduClsRelaENT;
    }
    exports.vPaperEduClsRela_GetObjFromJsonObj = vPaperEduClsRela_GetObjFromJsonObj;
});
