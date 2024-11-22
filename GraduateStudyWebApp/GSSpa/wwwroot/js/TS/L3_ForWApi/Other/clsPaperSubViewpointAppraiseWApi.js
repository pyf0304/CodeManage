/**
* 类名:clsPaperSubViewpointAppraiseWApi
* 表名:PaperSubViewpointAppraise(01120561)
* 生成代码版本:2022.11.02.1
* 生成日期:2022/11/02 11:46:15
* 生成者:pyf
* 生成服务器IP:
工程名称:问卷调查(0112)
CM工程:研究生论文学习(变量首字母小写)-全部函数集
* 相关数据库:103.116.76.183,9433EduHigh_Jsie
* PrjDataBaseId:0170
模块中文名:其他(Other)
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
        define(["require", "exports", "axios", "../../PubFun/CacheHelper.js", "../../L0_Entity/Other/clsPaperSubViewpointAppraiseEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsSysPara4WebApi.js", "../../PubFun/CacheHelper.js", "../../PubFun/jsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.PaperSubViewpointAppraise_GetObjFromJsonObj = exports.PaperSubViewpointAppraise_CopyObjTo = exports.PaperSubViewpointAppraise_GetUniCondStr4Update_PaperSubViewpointAppraiseId_SuvViewpointId = exports.PaperSubViewpointAppraise_GetUniCondStr_PaperSubViewpointAppraiseId_SuvViewpointId = exports.PaperSubViewpointAppraise_GetCombineCondition = exports.PaperSubViewpointAppraise_GetObjByJSONStr = exports.PaperSubViewpointAppraise_GetObjLstByJSONObjLst = exports.PaperSubViewpointAppraise_GetObjLstByJSONStr = exports.PaperSubViewpointAppraise_GetJSONStrByObj = exports.PaperSubViewpointAppraise_CheckProperty4Update = exports.PaperSubViewpointAppraise_CheckPropertyNew = exports.PaperSubViewpointAppraise_ReFreshThisCache = exports.PaperSubViewpointAppraise_ReFreshCache = exports.PaperSubViewpointAppraise_GetWebApiUrl = exports.PaperSubViewpointAppraise_GetMaxStrIdByPrefix = exports.PaperSubViewpointAppraise_GetRecCountByCond_Cache = exports.PaperSubViewpointAppraise_GetRecCountByCondAsync = exports.PaperSubViewpointAppraise_IsExistAsync = exports.PaperSubViewpointAppraise_IsExist_Cache = exports.PaperSubViewpointAppraise_IsExist = exports.PaperSubViewpointAppraise_IsExistRecordAsync = exports.PaperSubViewpointAppraise_IsExistRecord_Cache = exports.PaperSubViewpointAppraise_UpdateWithConditionAsync = exports.PaperSubViewpointAppraise_UpdateRecordAsync = exports.PaperSubViewpointAppraise_AddNewRecordWithReturnKey = exports.PaperSubViewpointAppraise_AddNewRecordWithReturnKeyAsync = exports.PaperSubViewpointAppraise_AddNewRecordAsync = exports.PaperSubViewpointAppraise_DelPaperSubViewpointAppraisesByCondAsync = exports.PaperSubViewpointAppraise_DelPaperSubViewpointAppraisesAsync = exports.PaperSubViewpointAppraise_DelRecordAsync = exports.PaperSubViewpointAppraise_GetObjLstByPagerAsync = exports.PaperSubViewpointAppraise_GetObjLstByPager_Cache = exports.PaperSubViewpointAppraise_GetObjLstByRange = exports.PaperSubViewpointAppraise_GetObjLstByRangeAsync = exports.PaperSubViewpointAppraise_GetTopObjLstAsync = exports.PaperSubViewpointAppraise_GetObjLstByPaperSubViewpointAppraiseIdLst_Cache = exports.PaperSubViewpointAppraise_GetObjLstByPaperSubViewpointAppraiseIdLstAsync = exports.PaperSubViewpointAppraise_GetSubObjLst_Cache = exports.PaperSubViewpointAppraise_GetObjLst_PureCache = exports.PaperSubViewpointAppraise_GetObjLst_Cache = exports.PaperSubViewpointAppraise_GetObjLst_sessionStorage_PureCache = exports.PaperSubViewpointAppraise_GetObjLst_sessionStorage = exports.PaperSubViewpointAppraise_GetObjLstAsync = exports.PaperSubViewpointAppraise_GetObjLst_localStorage_PureCache = exports.PaperSubViewpointAppraise_GetObjLst_localStorage = exports.PaperSubViewpointAppraise_GetObjLst_ClientCache = exports.PaperSubViewpointAppraise_GetFirstObjAsync = exports.PaperSubViewpointAppraise_GetFirstID = exports.PaperSubViewpointAppraise_GetFirstIDAsync = exports.PaperSubViewpointAppraise_FilterFunByKey = exports.PaperSubViewpointAppraise_SortFunByKey = exports.PaperSubViewpointAppraise_SortFun_Defa_2Fld = exports.PaperSubViewpointAppraise_SortFun_Defa = exports.PaperSubViewpointAppraise_func = exports.PaperSubViewpointAppraise_UpdateObjInLst_Cache = exports.PaperSubViewpointAppraise_GetObjByPaperSubViewpointAppraiseId_localStorage = exports.PaperSubViewpointAppraise_GetObjByPaperSubViewpointAppraiseId_Cache = exports.PaperSubViewpointAppraise_GetObjByPaperSubViewpointAppraiseIdAsync = exports.paperSubViewpointAppraise_ConstructorName = exports.paperSubViewpointAppraise_Controller = void 0;
    /**
     * 子观点评论表(PaperSubViewpointAppraise)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2022年11月02日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsPaperSubViewpointAppraiseEN_js_1 = require("../../L0_Entity/Other/clsPaperSubViewpointAppraiseEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    const CacheHelper_js_2 = require("../../PubFun/CacheHelper.js");
    const jsString_js_1 = require("../../PubFun/jsString.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.paperSubViewpointAppraise_Controller = "PaperSubViewpointAppraiseApi";
    exports.paperSubViewpointAppraise_ConstructorName = "paperSubViewpointAppraise";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param lngPaperSubViewpointAppraiseId:关键字
    * @returns 对象
    **/
    async function PaperSubViewpointAppraise_GetObjByPaperSubViewpointAppraiseIdAsync(lngPaperSubViewpointAppraiseId) {
        const strThisFuncName = "GetObjByPaperSubViewpointAppraiseIdAsync";
        if (lngPaperSubViewpointAppraiseId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngPaperSubViewpointAppraiseId]不能为空！(In GetObjByPaperSubViewpointAppraiseIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByPaperSubViewpointAppraiseId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperSubViewpointAppraise_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "lngPaperSubViewpointAppraiseId": lngPaperSubViewpointAppraiseId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.paperSubViewpointAppraise_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objPaperSubViewpointAppraise = PaperSubViewpointAppraise_GetObjFromJsonObj(returnObj);
                return objPaperSubViewpointAppraise;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperSubViewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperSubViewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperSubViewpointAppraise_GetObjByPaperSubViewpointAppraiseIdAsync = PaperSubViewpointAppraise_GetObjByPaperSubViewpointAppraiseIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param lngPaperSubViewpointAppraiseId:所给的关键字
     * @returns 对象
    */
    async function PaperSubViewpointAppraise_GetObjByPaperSubViewpointAppraiseId_Cache(lngPaperSubViewpointAppraiseId, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByPaperSubViewpointAppraiseId_Cache";
        if (lngPaperSubViewpointAppraiseId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngPaperSubViewpointAppraiseId]不能为空！(In GetObjByPaperSubViewpointAppraiseId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        const arrPaperSubViewpointAppraiseObjLst_Cache = await PaperSubViewpointAppraise_GetObjLst_Cache();
        try {
            const arrPaperSubViewpointAppraise_Sel = arrPaperSubViewpointAppraiseObjLst_Cache.filter(x => x.paperSubViewpointAppraiseId == lngPaperSubViewpointAppraiseId);
            let objPaperSubViewpointAppraise;
            if (arrPaperSubViewpointAppraise_Sel.length > 0) {
                objPaperSubViewpointAppraise = arrPaperSubViewpointAppraise_Sel[0];
                return objPaperSubViewpointAppraise;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    objPaperSubViewpointAppraise = await PaperSubViewpointAppraise_GetObjByPaperSubViewpointAppraiseIdAsync(lngPaperSubViewpointAppraiseId);
                    if (objPaperSubViewpointAppraise != null) {
                        PaperSubViewpointAppraise_ReFreshThisCache();
                        return objPaperSubViewpointAppraise;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngPaperSubViewpointAppraiseId, exports.paperSubViewpointAppraise_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.PaperSubViewpointAppraise_GetObjByPaperSubViewpointAppraiseId_Cache = PaperSubViewpointAppraise_GetObjByPaperSubViewpointAppraiseId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param lngPaperSubViewpointAppraiseId:所给的关键字
     * @returns 对象
    */
    async function PaperSubViewpointAppraise_GetObjByPaperSubViewpointAppraiseId_localStorage(lngPaperSubViewpointAppraiseId) {
        const strThisFuncName = "GetObjByPaperSubViewpointAppraiseId_localStorage";
        if (lngPaperSubViewpointAppraiseId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngPaperSubViewpointAppraiseId]不能为空！(In GetObjByPaperSubViewpointAppraiseId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsPaperSubViewpointAppraiseEN_js_1.clsPaperSubViewpointAppraiseEN._CurrTabName, lngPaperSubViewpointAppraiseId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objPaperSubViewpointAppraise_Cache = JSON.parse(strTempObj);
            return objPaperSubViewpointAppraise_Cache;
        }
        try {
            const objPaperSubViewpointAppraise = await PaperSubViewpointAppraise_GetObjByPaperSubViewpointAppraiseIdAsync(lngPaperSubViewpointAppraiseId);
            if (objPaperSubViewpointAppraise != null) {
                localStorage.setItem(strKey, JSON.stringify(objPaperSubViewpointAppraise));
                const strInfo = (0, clsString_js_1.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objPaperSubViewpointAppraise;
            }
            return objPaperSubViewpointAppraise;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngPaperSubViewpointAppraiseId, exports.paperSubViewpointAppraise_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.PaperSubViewpointAppraise_GetObjByPaperSubViewpointAppraiseId_localStorage = PaperSubViewpointAppraise_GetObjByPaperSubViewpointAppraiseId_localStorage;
    /**
     * 修改在缓存对象列表中的对象, 与后台数据库无关.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
     * @param objPaperSubViewpointAppraise:所给的对象
     * @returns 对象
    */
    async function PaperSubViewpointAppraise_UpdateObjInLst_Cache(objPaperSubViewpointAppraise) {
        const strThisFuncName = "UpdateObjInLst_Cache";
        try {
            const arrPaperSubViewpointAppraiseObjLst_Cache = await PaperSubViewpointAppraise_GetObjLst_Cache();
            const obj = arrPaperSubViewpointAppraiseObjLst_Cache.find(x => x.paperSubViewpointAppraiseId == objPaperSubViewpointAppraise.paperSubViewpointAppraiseId && x.subViewpointId == objPaperSubViewpointAppraise.subViewpointId);
            if (obj != null) {
                objPaperSubViewpointAppraise.paperSubViewpointAppraiseId = obj.paperSubViewpointAppraiseId;
                (0, clsCommFunc4Web_js_1.ObjectAssign)(obj, objPaperSubViewpointAppraise);
            }
            else {
                arrPaperSubViewpointAppraiseObjLst_Cache.push(objPaperSubViewpointAppraise);
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, exports.paperSubViewpointAppraise_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.PaperSubViewpointAppraise_UpdateObjInLst_Cache = PaperSubViewpointAppraise_UpdateObjInLst_Cache;
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
    async function PaperSubViewpointAppraise_func(strInFldName, strOutFldName, strInValue) {
        //const strThisFuncName = "func";
        if (strInFldName != clsPaperSubViewpointAppraiseEN_js_1.clsPaperSubViewpointAppraiseEN.con_PaperSubViewpointAppraiseId) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsPaperSubViewpointAppraiseEN_js_1.clsPaperSubViewpointAppraiseEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_1.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strInFldName, clsPaperSubViewpointAppraiseEN_js_1.clsPaperSubViewpointAppraiseEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const lngPaperSubViewpointAppraiseId = Number(strInValue);
        if (lngPaperSubViewpointAppraiseId == 0) {
            return "";
        }
        const objPaperSubViewpointAppraise = await PaperSubViewpointAppraise_GetObjByPaperSubViewpointAppraiseId_Cache(lngPaperSubViewpointAppraiseId);
        if (objPaperSubViewpointAppraise == null)
            return "";
        return objPaperSubViewpointAppraise.GetFldValue(strOutFldName).toString();
    }
    exports.PaperSubViewpointAppraise_func = PaperSubViewpointAppraise_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function PaperSubViewpointAppraise_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.paperSubViewpointAppraiseId - b.paperSubViewpointAppraiseId;
    }
    exports.PaperSubViewpointAppraise_SortFun_Defa = PaperSubViewpointAppraise_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function PaperSubViewpointAppraise_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.appraiseScore == b.appraiseScore)
            return a.appraiseContent.localeCompare(b.appraiseContent);
        else
            return a.appraiseScore - b.appraiseScore;
    }
    exports.PaperSubViewpointAppraise_SortFun_Defa_2Fld = PaperSubViewpointAppraise_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function PaperSubViewpointAppraise_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsPaperSubViewpointAppraiseEN_js_1.clsPaperSubViewpointAppraiseEN.con_PaperSubViewpointAppraiseId:
                    return (a, b) => {
                        return a.paperSubViewpointAppraiseId - b.paperSubViewpointAppraiseId;
                    };
                case clsPaperSubViewpointAppraiseEN_js_1.clsPaperSubViewpointAppraiseEN.con_AppraiseScore:
                    return (a, b) => {
                        return a.appraiseScore - b.appraiseScore;
                    };
                case clsPaperSubViewpointAppraiseEN_js_1.clsPaperSubViewpointAppraiseEN.con_AppraiseContent:
                    return (a, b) => {
                        return a.appraiseContent.localeCompare(b.appraiseContent);
                    };
                case clsPaperSubViewpointAppraiseEN_js_1.clsPaperSubViewpointAppraiseEN.con_UpdDate:
                    return (a, b) => {
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsPaperSubViewpointAppraiseEN_js_1.clsPaperSubViewpointAppraiseEN.con_Meno:
                    return (a, b) => {
                        return a.meno.localeCompare(b.meno);
                    };
                case clsPaperSubViewpointAppraiseEN_js_1.clsPaperSubViewpointAppraiseEN.con_SubViewpointId:
                    return (a, b) => {
                        return a.subViewpointId - b.subViewpointId;
                    };
                case clsPaperSubViewpointAppraiseEN_js_1.clsPaperSubViewpointAppraiseEN.con_UpdUser:
                    return (a, b) => {
                        return a.updUser.localeCompare(b.updUser);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[PaperSubViewpointAppraise]中不存在！(in ${exports.paperSubViewpointAppraise_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsPaperSubViewpointAppraiseEN_js_1.clsPaperSubViewpointAppraiseEN.con_PaperSubViewpointAppraiseId:
                    return (a, b) => {
                        return b.paperSubViewpointAppraiseId - a.paperSubViewpointAppraiseId;
                    };
                case clsPaperSubViewpointAppraiseEN_js_1.clsPaperSubViewpointAppraiseEN.con_AppraiseScore:
                    return (a, b) => {
                        return b.appraiseScore - a.appraiseScore;
                    };
                case clsPaperSubViewpointAppraiseEN_js_1.clsPaperSubViewpointAppraiseEN.con_AppraiseContent:
                    return (a, b) => {
                        return b.appraiseContent.localeCompare(a.appraiseContent);
                    };
                case clsPaperSubViewpointAppraiseEN_js_1.clsPaperSubViewpointAppraiseEN.con_UpdDate:
                    return (a, b) => {
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsPaperSubViewpointAppraiseEN_js_1.clsPaperSubViewpointAppraiseEN.con_Meno:
                    return (a, b) => {
                        return b.meno.localeCompare(a.meno);
                    };
                case clsPaperSubViewpointAppraiseEN_js_1.clsPaperSubViewpointAppraiseEN.con_SubViewpointId:
                    return (a, b) => {
                        return b.subViewpointId - a.subViewpointId;
                    };
                case clsPaperSubViewpointAppraiseEN_js_1.clsPaperSubViewpointAppraiseEN.con_UpdUser:
                    return (a, b) => {
                        return b.updUser.localeCompare(a.updUser);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[PaperSubViewpointAppraise]中不存在！(in ${exports.paperSubViewpointAppraise_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.PaperSubViewpointAppraise_SortFunByKey = PaperSubViewpointAppraise_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function PaperSubViewpointAppraise_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsPaperSubViewpointAppraiseEN_js_1.clsPaperSubViewpointAppraiseEN.con_PaperSubViewpointAppraiseId:
                return (obj) => {
                    return obj.paperSubViewpointAppraiseId === value;
                };
            case clsPaperSubViewpointAppraiseEN_js_1.clsPaperSubViewpointAppraiseEN.con_AppraiseScore:
                return (obj) => {
                    return obj.appraiseScore === value;
                };
            case clsPaperSubViewpointAppraiseEN_js_1.clsPaperSubViewpointAppraiseEN.con_AppraiseContent:
                return (obj) => {
                    return obj.appraiseContent === value;
                };
            case clsPaperSubViewpointAppraiseEN_js_1.clsPaperSubViewpointAppraiseEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsPaperSubViewpointAppraiseEN_js_1.clsPaperSubViewpointAppraiseEN.con_Meno:
                return (obj) => {
                    return obj.meno === value;
                };
            case clsPaperSubViewpointAppraiseEN_js_1.clsPaperSubViewpointAppraiseEN.con_SubViewpointId:
                return (obj) => {
                    return obj.subViewpointId === value;
                };
            case clsPaperSubViewpointAppraiseEN_js_1.clsPaperSubViewpointAppraiseEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[PaperSubViewpointAppraise]中不存在！(in ${exports.paperSubViewpointAppraise_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.PaperSubViewpointAppraise_FilterFunByKey = PaperSubViewpointAppraise_FilterFunByKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function PaperSubViewpointAppraise_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperSubViewpointAppraise_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperSubViewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperSubViewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperSubViewpointAppraise_GetFirstIDAsync = PaperSubViewpointAppraise_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function PaperSubViewpointAppraise_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperSubViewpointAppraise_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperSubViewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperSubViewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperSubViewpointAppraise_GetFirstID = PaperSubViewpointAppraise_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function PaperSubViewpointAppraise_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperSubViewpointAppraise_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.paperSubViewpointAppraise_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objPaperSubViewpointAppraise = PaperSubViewpointAppraise_GetObjFromJsonObj(returnObj);
                return objPaperSubViewpointAppraise;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperSubViewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperSubViewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperSubViewpointAppraise_GetFirstObjAsync = PaperSubViewpointAppraise_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function PaperSubViewpointAppraise_GetObjLst_ClientCache() {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsPaperSubViewpointAppraiseEN_js_1.clsPaperSubViewpointAppraiseEN._CurrTabName;
        clsPaperSubViewpointAppraiseEN_js_1.clsPaperSubViewpointAppraiseEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsPaperSubViewpointAppraiseEN_js_1.clsPaperSubViewpointAppraiseEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsPaperSubViewpointAppraiseEN_js_1.clsPaperSubViewpointAppraiseEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsPaperSubViewpointAppraiseEN_js_1.clsPaperSubViewpointAppraiseEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_2.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrPaperSubViewpointAppraiseExObjLst_Cache = CacheHelper_js_2.CacheHelper.Get(strKey);
            const arrPaperSubViewpointAppraiseObjLst_T = PaperSubViewpointAppraise_GetObjLstByJSONObjLst(arrPaperSubViewpointAppraiseExObjLst_Cache);
            return arrPaperSubViewpointAppraiseObjLst_T;
        }
        try {
            const arrPaperSubViewpointAppraiseExObjLst = await PaperSubViewpointAppraise_GetObjLstAsync(strWhereCond);
            CacheHelper_js_2.CacheHelper.Add(strKey, arrPaperSubViewpointAppraiseExObjLst);
            const strInfo = (0, clsString_js_1.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrPaperSubViewpointAppraiseExObjLst.length);
            console.log(strInfo);
            return arrPaperSubViewpointAppraiseExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.paperSubViewpointAppraise_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.PaperSubViewpointAppraise_GetObjLst_ClientCache = PaperSubViewpointAppraise_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function PaperSubViewpointAppraise_GetObjLst_localStorage() {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsPaperSubViewpointAppraiseEN_js_1.clsPaperSubViewpointAppraiseEN._CurrTabName;
        clsPaperSubViewpointAppraiseEN_js_1.clsPaperSubViewpointAppraiseEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsPaperSubViewpointAppraiseEN_js_1.clsPaperSubViewpointAppraiseEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsPaperSubViewpointAppraiseEN_js_1.clsPaperSubViewpointAppraiseEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsPaperSubViewpointAppraiseEN_js_1.clsPaperSubViewpointAppraiseEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrPaperSubViewpointAppraiseExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrPaperSubViewpointAppraiseObjLst_T = PaperSubViewpointAppraise_GetObjLstByJSONObjLst(arrPaperSubViewpointAppraiseExObjLst_Cache);
            return arrPaperSubViewpointAppraiseObjLst_T;
        }
        try {
            const arrPaperSubViewpointAppraiseExObjLst = await PaperSubViewpointAppraise_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrPaperSubViewpointAppraiseExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrPaperSubViewpointAppraiseExObjLst.length);
            console.log(strInfo);
            return arrPaperSubViewpointAppraiseExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.paperSubViewpointAppraise_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.PaperSubViewpointAppraise_GetObjLst_localStorage = PaperSubViewpointAppraise_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function PaperSubViewpointAppraise_GetObjLst_localStorage_PureCache() {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsPaperSubViewpointAppraiseEN_js_1.clsPaperSubViewpointAppraiseEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrPaperSubViewpointAppraiseObjLst_Cache = JSON.parse(strTempObjLst);
            return arrPaperSubViewpointAppraiseObjLst_Cache;
        }
        else
            return null;
    }
    exports.PaperSubViewpointAppraise_GetObjLst_localStorage_PureCache = PaperSubViewpointAppraise_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function PaperSubViewpointAppraise_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperSubViewpointAppraise_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.paperSubViewpointAppraise_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = PaperSubViewpointAppraise_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperSubViewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperSubViewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperSubViewpointAppraise_GetObjLstAsync = PaperSubViewpointAppraise_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function PaperSubViewpointAppraise_GetObjLst_sessionStorage() {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsPaperSubViewpointAppraiseEN_js_1.clsPaperSubViewpointAppraiseEN._CurrTabName;
        clsPaperSubViewpointAppraiseEN_js_1.clsPaperSubViewpointAppraiseEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsPaperSubViewpointAppraiseEN_js_1.clsPaperSubViewpointAppraiseEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsPaperSubViewpointAppraiseEN_js_1.clsPaperSubViewpointAppraiseEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsPaperSubViewpointAppraiseEN_js_1.clsPaperSubViewpointAppraiseEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrPaperSubViewpointAppraiseExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrPaperSubViewpointAppraiseObjLst_T = PaperSubViewpointAppraise_GetObjLstByJSONObjLst(arrPaperSubViewpointAppraiseExObjLst_Cache);
            return arrPaperSubViewpointAppraiseObjLst_T;
        }
        try {
            const arrPaperSubViewpointAppraiseExObjLst = await PaperSubViewpointAppraise_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrPaperSubViewpointAppraiseExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrPaperSubViewpointAppraiseExObjLst.length);
            console.log(strInfo);
            return arrPaperSubViewpointAppraiseExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.paperSubViewpointAppraise_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.PaperSubViewpointAppraise_GetObjLst_sessionStorage = PaperSubViewpointAppraise_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function PaperSubViewpointAppraise_GetObjLst_sessionStorage_PureCache() {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsPaperSubViewpointAppraiseEN_js_1.clsPaperSubViewpointAppraiseEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrPaperSubViewpointAppraiseObjLst_Cache = JSON.parse(strTempObjLst);
            return arrPaperSubViewpointAppraiseObjLst_Cache;
        }
        else
            return null;
    }
    exports.PaperSubViewpointAppraise_GetObjLst_sessionStorage_PureCache = PaperSubViewpointAppraise_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function PaperSubViewpointAppraise_GetObjLst_Cache() {
        //const strThisFuncName = "GetObjLst_Cache";
        let arrPaperSubViewpointAppraiseObjLst_Cache;
        switch (clsPaperSubViewpointAppraiseEN_js_1.clsPaperSubViewpointAppraiseEN.CacheModeId) {
            case "04": //sessionStorage
                arrPaperSubViewpointAppraiseObjLst_Cache = await PaperSubViewpointAppraise_GetObjLst_sessionStorage();
                break;
            case "03": //localStorage
                arrPaperSubViewpointAppraiseObjLst_Cache = await PaperSubViewpointAppraise_GetObjLst_localStorage();
                break;
            case "02": //ClientCache
                arrPaperSubViewpointAppraiseObjLst_Cache = await PaperSubViewpointAppraise_GetObjLst_ClientCache();
                break;
            default:
                arrPaperSubViewpointAppraiseObjLst_Cache = await PaperSubViewpointAppraise_GetObjLst_ClientCache();
                break;
        }
        const arrPaperSubViewpointAppraiseObjLst = PaperSubViewpointAppraise_GetObjLstByJSONObjLst(arrPaperSubViewpointAppraiseObjLst_Cache);
        return arrPaperSubViewpointAppraiseObjLst_Cache;
    }
    exports.PaperSubViewpointAppraise_GetObjLst_Cache = PaperSubViewpointAppraise_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function PaperSubViewpointAppraise_GetObjLst_PureCache() {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrPaperSubViewpointAppraiseObjLst_Cache;
        switch (clsPaperSubViewpointAppraiseEN_js_1.clsPaperSubViewpointAppraiseEN.CacheModeId) {
            case "04": //sessionStorage
                arrPaperSubViewpointAppraiseObjLst_Cache = await PaperSubViewpointAppraise_GetObjLst_sessionStorage_PureCache();
                break;
            case "03": //localStorage
                arrPaperSubViewpointAppraiseObjLst_Cache = await PaperSubViewpointAppraise_GetObjLst_localStorage_PureCache();
                break;
            case "02": //ClientCache
                arrPaperSubViewpointAppraiseObjLst_Cache = null;
                break;
            default:
                arrPaperSubViewpointAppraiseObjLst_Cache = null;
                break;
        }
        return arrPaperSubViewpointAppraiseObjLst_Cache;
    }
    exports.PaperSubViewpointAppraise_GetObjLst_PureCache = PaperSubViewpointAppraise_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objlngPaperSubViewpointAppraiseId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function PaperSubViewpointAppraise_GetSubObjLst_Cache(objPaperSubViewpointAppraise_Cond) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrPaperSubViewpointAppraiseObjLst_Cache = await PaperSubViewpointAppraise_GetObjLst_Cache();
        let arrPaperSubViewpointAppraise_Sel = arrPaperSubViewpointAppraiseObjLst_Cache;
        if (objPaperSubViewpointAppraise_Cond.sf_FldComparisonOp == null || objPaperSubViewpointAppraise_Cond.sf_FldComparisonOp == "")
            return arrPaperSubViewpointAppraise_Sel;
        const dicFldComparisonOp = JSON.parse(objPaperSubViewpointAppraise_Cond.sf_FldComparisonOp);
        //console.log("clsPaperSubViewpointAppraiseWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objPaperSubViewpointAppraise_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrPaperSubViewpointAppraise_Sel = arrPaperSubViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objPaperSubViewpointAppraise_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrPaperSubViewpointAppraise_Sel = arrPaperSubViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrPaperSubViewpointAppraise_Sel = arrPaperSubViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrPaperSubViewpointAppraise_Sel = arrPaperSubViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrPaperSubViewpointAppraise_Sel = arrPaperSubViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrPaperSubViewpointAppraise_Sel = arrPaperSubViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrPaperSubViewpointAppraise_Sel = arrPaperSubViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrPaperSubViewpointAppraise_Sel = arrPaperSubViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrPaperSubViewpointAppraise_Sel = arrPaperSubViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrPaperSubViewpointAppraise_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objPaperSubViewpointAppraise_Cond), exports.paperSubViewpointAppraise_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.PaperSubViewpointAppraise_GetSubObjLst_Cache = PaperSubViewpointAppraise_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrPaperSubViewpointAppraiseId:关键字列表
    * @returns 对象列表
    **/
    async function PaperSubViewpointAppraise_GetObjLstByPaperSubViewpointAppraiseIdLstAsync(arrPaperSubViewpointAppraiseId) {
        const strThisFuncName = "GetObjLstByPaperSubViewpointAppraiseIdLstAsync";
        const strAction = "GetObjLstByPaperSubViewpointAppraiseIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperSubViewpointAppraise_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrPaperSubViewpointAppraiseId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.paperSubViewpointAppraise_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = PaperSubViewpointAppraise_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperSubViewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperSubViewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperSubViewpointAppraise_GetObjLstByPaperSubViewpointAppraiseIdLstAsync = PaperSubViewpointAppraise_GetObjLstByPaperSubViewpointAppraiseIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrlngPaperSubViewpointAppraiseIdLst:关键字列表
     * @returns 对象列表
    */
    async function PaperSubViewpointAppraise_GetObjLstByPaperSubViewpointAppraiseIdLst_Cache(arrPaperSubViewpointAppraiseIdLst) {
        const strThisFuncName = "GetObjLstByPaperSubViewpointAppraiseIdLst_Cache";
        try {
            const arrPaperSubViewpointAppraiseObjLst_Cache = await PaperSubViewpointAppraise_GetObjLst_Cache();
            const arrPaperSubViewpointAppraise_Sel = arrPaperSubViewpointAppraiseObjLst_Cache.filter(x => arrPaperSubViewpointAppraiseIdLst.indexOf(x.paperSubViewpointAppraiseId) > -1);
            return arrPaperSubViewpointAppraise_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrPaperSubViewpointAppraiseIdLst.join(","), exports.paperSubViewpointAppraise_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.PaperSubViewpointAppraise_GetObjLstByPaperSubViewpointAppraiseIdLst_Cache = PaperSubViewpointAppraise_GetObjLstByPaperSubViewpointAppraiseIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function PaperSubViewpointAppraise_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperSubViewpointAppraise_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.paperSubViewpointAppraise_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = PaperSubViewpointAppraise_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperSubViewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperSubViewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperSubViewpointAppraise_GetTopObjLstAsync = PaperSubViewpointAppraise_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function PaperSubViewpointAppraise_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperSubViewpointAppraise_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.paperSubViewpointAppraise_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = PaperSubViewpointAppraise_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperSubViewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperSubViewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperSubViewpointAppraise_GetObjLstByRangeAsync = PaperSubViewpointAppraise_GetObjLstByRangeAsync;
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
    async function PaperSubViewpointAppraise_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperSubViewpointAppraise_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperSubViewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperSubViewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperSubViewpointAppraise_GetObjLstByRange = PaperSubViewpointAppraise_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function PaperSubViewpointAppraise_GetObjLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const arrPaperSubViewpointAppraiseObjLst_Cache = await PaperSubViewpointAppraise_GetObjLst_Cache();
        if (arrPaperSubViewpointAppraiseObjLst_Cache.length == 0)
            return arrPaperSubViewpointAppraiseObjLst_Cache;
        let arrPaperSubViewpointAppraise_Sel = arrPaperSubViewpointAppraiseObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objPaperSubViewpointAppraise_Cond = new clsPaperSubViewpointAppraiseEN_js_1.clsPaperSubViewpointAppraiseEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objPaperSubViewpointAppraise_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsPaperSubViewpointAppraiseWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrPaperSubViewpointAppraise_Sel = arrPaperSubViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objPaperSubViewpointAppraise_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrPaperSubViewpointAppraise_Sel = arrPaperSubViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrPaperSubViewpointAppraise_Sel = arrPaperSubViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrPaperSubViewpointAppraise_Sel = arrPaperSubViewpointAppraise_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrPaperSubViewpointAppraise_Sel = arrPaperSubViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrPaperSubViewpointAppraise_Sel = arrPaperSubViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrPaperSubViewpointAppraise_Sel = arrPaperSubViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrPaperSubViewpointAppraise_Sel = arrPaperSubViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrPaperSubViewpointAppraise_Sel = arrPaperSubViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrPaperSubViewpointAppraise_Sel = arrPaperSubViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrPaperSubViewpointAppraise_Sel.length == 0)
                return arrPaperSubViewpointAppraise_Sel;
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
                arrPaperSubViewpointAppraise_Sel = arrPaperSubViewpointAppraise_Sel.sort(PaperSubViewpointAppraise_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrPaperSubViewpointAppraise_Sel = arrPaperSubViewpointAppraise_Sel.sort(objPagerPara.sortFun);
            }
            arrPaperSubViewpointAppraise_Sel = arrPaperSubViewpointAppraise_Sel.slice(intStart, intEnd);
            return arrPaperSubViewpointAppraise_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.paperSubViewpointAppraise_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.PaperSubViewpointAppraise_GetObjLstByPager_Cache = PaperSubViewpointAppraise_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function PaperSubViewpointAppraise_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperSubViewpointAppraise_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.paperSubViewpointAppraise_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = PaperSubViewpointAppraise_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperSubViewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperSubViewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperSubViewpointAppraise_GetObjLstByPagerAsync = PaperSubViewpointAppraise_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param lngPaperSubViewpointAppraiseId:关键字
    * @returns 获取删除的结果
    **/
    async function PaperSubViewpointAppraise_DelRecordAsync(lngPaperSubViewpointAppraiseId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperSubViewpointAppraise_Controller, strAction);
        strUrl = (0, clsString_js_1.Format)("{0}/?Id={1}", strUrl, lngPaperSubViewpointAppraiseId);
        try {
            const response = await axios_1.default.delete(strUrl, {
                params: { "Id": lngPaperSubViewpointAppraiseId, }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperSubViewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperSubViewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperSubViewpointAppraise_DelRecordAsync = PaperSubViewpointAppraise_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrPaperSubViewpointAppraiseId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function PaperSubViewpointAppraise_DelPaperSubViewpointAppraisesAsync(arrPaperSubViewpointAppraiseId) {
        const strThisFuncName = "DelPaperSubViewpointAppraisesAsync";
        const strAction = "DelPaperSubViewpointAppraises";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperSubViewpointAppraise_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrPaperSubViewpointAppraiseId);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperSubViewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperSubViewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperSubViewpointAppraise_DelPaperSubViewpointAppraisesAsync = PaperSubViewpointAppraise_DelPaperSubViewpointAppraisesAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function PaperSubViewpointAppraise_DelPaperSubViewpointAppraisesByCondAsync(strWhereCond) {
        const strThisFuncName = "DelPaperSubViewpointAppraisesByCondAsync";
        const strAction = "DelPaperSubViewpointAppraisesByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperSubViewpointAppraise_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperSubViewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperSubViewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperSubViewpointAppraise_DelPaperSubViewpointAppraisesByCondAsync = PaperSubViewpointAppraise_DelPaperSubViewpointAppraisesByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objPaperSubViewpointAppraiseEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function PaperSubViewpointAppraise_AddNewRecordAsync(objPaperSubViewpointAppraiseEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objPaperSubViewpointAppraiseEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperSubViewpointAppraise_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPaperSubViewpointAppraiseEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperSubViewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperSubViewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperSubViewpointAppraise_AddNewRecordAsync = PaperSubViewpointAppraise_AddNewRecordAsync;
    /* 数据类型不是字符型，不可以最大关键字的方式添加记录。*/
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objPaperSubViewpointAppraiseEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function PaperSubViewpointAppraise_AddNewRecordWithReturnKeyAsync(objPaperSubViewpointAppraiseEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperSubViewpointAppraise_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPaperSubViewpointAppraiseEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperSubViewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperSubViewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperSubViewpointAppraise_AddNewRecordWithReturnKeyAsync = PaperSubViewpointAppraise_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objPaperSubViewpointAppraiseEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function PaperSubViewpointAppraise_AddNewRecordWithReturnKey(objPaperSubViewpointAppraiseEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objPaperSubViewpointAppraiseEN.paperSubViewpointAppraiseId === null || objPaperSubViewpointAppraiseEN.paperSubViewpointAppraiseId === 0) {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperSubViewpointAppraise_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPaperSubViewpointAppraiseEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperSubViewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperSubViewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperSubViewpointAppraise_AddNewRecordWithReturnKey = PaperSubViewpointAppraise_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objPaperSubViewpointAppraiseEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function PaperSubViewpointAppraise_UpdateRecordAsync(objPaperSubViewpointAppraiseEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objPaperSubViewpointAppraiseEN.sf_UpdFldSetStr === undefined || objPaperSubViewpointAppraiseEN.sf_UpdFldSetStr === null || objPaperSubViewpointAppraiseEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objPaperSubViewpointAppraiseEN.paperSubViewpointAppraiseId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperSubViewpointAppraise_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPaperSubViewpointAppraiseEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperSubViewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperSubViewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperSubViewpointAppraise_UpdateRecordAsync = PaperSubViewpointAppraise_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objPaperSubViewpointAppraiseEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function PaperSubViewpointAppraise_UpdateWithConditionAsync(objPaperSubViewpointAppraiseEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objPaperSubViewpointAppraiseEN.sf_UpdFldSetStr === undefined || objPaperSubViewpointAppraiseEN.sf_UpdFldSetStr === null || objPaperSubViewpointAppraiseEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objPaperSubViewpointAppraiseEN.paperSubViewpointAppraiseId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperSubViewpointAppraise_Controller, strAction);
        objPaperSubViewpointAppraiseEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objPaperSubViewpointAppraiseEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperSubViewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperSubViewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperSubViewpointAppraise_UpdateWithConditionAsync = PaperSubViewpointAppraise_UpdateWithConditionAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objlngPaperSubViewpointAppraiseId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function PaperSubViewpointAppraise_IsExistRecord_Cache(objPaperSubViewpointAppraise_Cond) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrPaperSubViewpointAppraiseObjLst_Cache = await PaperSubViewpointAppraise_GetObjLst_Cache();
        if (arrPaperSubViewpointAppraiseObjLst_Cache == null)
            return false;
        let arrPaperSubViewpointAppraise_Sel = arrPaperSubViewpointAppraiseObjLst_Cache;
        if (objPaperSubViewpointAppraise_Cond.sf_FldComparisonOp == null || objPaperSubViewpointAppraise_Cond.sf_FldComparisonOp == "")
            return arrPaperSubViewpointAppraise_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objPaperSubViewpointAppraise_Cond.sf_FldComparisonOp);
        //console.log("clsPaperSubViewpointAppraiseWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objPaperSubViewpointAppraise_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objPaperSubViewpointAppraise_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrPaperSubViewpointAppraise_Sel = arrPaperSubViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrPaperSubViewpointAppraise_Sel = arrPaperSubViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrPaperSubViewpointAppraise_Sel = arrPaperSubViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrPaperSubViewpointAppraise_Sel = arrPaperSubViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrPaperSubViewpointAppraise_Sel = arrPaperSubViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrPaperSubViewpointAppraise_Sel = arrPaperSubViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrPaperSubViewpointAppraise_Sel = arrPaperSubViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrPaperSubViewpointAppraise_Sel = arrPaperSubViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrPaperSubViewpointAppraise_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objPaperSubViewpointAppraise_Cond), exports.paperSubViewpointAppraise_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.PaperSubViewpointAppraise_IsExistRecord_Cache = PaperSubViewpointAppraise_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function PaperSubViewpointAppraise_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperSubViewpointAppraise_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperSubViewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperSubViewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperSubViewpointAppraise_IsExistRecordAsync = PaperSubViewpointAppraise_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param lngPaperSubViewpointAppraiseId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function PaperSubViewpointAppraise_IsExist(lngPaperSubViewpointAppraiseId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperSubViewpointAppraise_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "PaperSubViewpointAppraiseId": lngPaperSubViewpointAppraiseId,
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperSubViewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperSubViewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperSubViewpointAppraise_IsExist = PaperSubViewpointAppraise_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param lngPaperSubViewpointAppraiseId:所给的关键字
     * @returns 对象
    */
    async function PaperSubViewpointAppraise_IsExist_Cache(lngPaperSubViewpointAppraiseId) {
        const strThisFuncName = "IsExist_Cache";
        const arrPaperSubViewpointAppraiseObjLst_Cache = await PaperSubViewpointAppraise_GetObjLst_Cache();
        if (arrPaperSubViewpointAppraiseObjLst_Cache == null)
            return false;
        try {
            const arrPaperSubViewpointAppraise_Sel = arrPaperSubViewpointAppraiseObjLst_Cache.filter(x => x.paperSubViewpointAppraiseId == lngPaperSubViewpointAppraiseId);
            if (arrPaperSubViewpointAppraise_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", lngPaperSubViewpointAppraiseId, exports.paperSubViewpointAppraise_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.PaperSubViewpointAppraise_IsExist_Cache = PaperSubViewpointAppraise_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param lngPaperSubViewpointAppraiseId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function PaperSubViewpointAppraise_IsExistAsync(lngPaperSubViewpointAppraiseId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperSubViewpointAppraise_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "lngPaperSubViewpointAppraiseId": lngPaperSubViewpointAppraiseId }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperSubViewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperSubViewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperSubViewpointAppraise_IsExistAsync = PaperSubViewpointAppraise_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function PaperSubViewpointAppraise_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperSubViewpointAppraise_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperSubViewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperSubViewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperSubViewpointAppraise_GetRecCountByCondAsync = PaperSubViewpointAppraise_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objPaperSubViewpointAppraise_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function PaperSubViewpointAppraise_GetRecCountByCond_Cache(objPaperSubViewpointAppraise_Cond) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrPaperSubViewpointAppraiseObjLst_Cache = await PaperSubViewpointAppraise_GetObjLst_Cache();
        if (arrPaperSubViewpointAppraiseObjLst_Cache == null)
            return 0;
        let arrPaperSubViewpointAppraise_Sel = arrPaperSubViewpointAppraiseObjLst_Cache;
        if (objPaperSubViewpointAppraise_Cond.sf_FldComparisonOp == null || objPaperSubViewpointAppraise_Cond.sf_FldComparisonOp == "")
            return arrPaperSubViewpointAppraise_Sel.length;
        const dicFldComparisonOp = JSON.parse(objPaperSubViewpointAppraise_Cond.sf_FldComparisonOp);
        //console.log("clsPaperSubViewpointAppraiseWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objPaperSubViewpointAppraise_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrPaperSubViewpointAppraise_Sel = arrPaperSubViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objPaperSubViewpointAppraise_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrPaperSubViewpointAppraise_Sel = arrPaperSubViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrPaperSubViewpointAppraise_Sel = arrPaperSubViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrPaperSubViewpointAppraise_Sel = arrPaperSubViewpointAppraise_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrPaperSubViewpointAppraise_Sel = arrPaperSubViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrPaperSubViewpointAppraise_Sel = arrPaperSubViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrPaperSubViewpointAppraise_Sel = arrPaperSubViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrPaperSubViewpointAppraise_Sel = arrPaperSubViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrPaperSubViewpointAppraise_Sel = arrPaperSubViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrPaperSubViewpointAppraise_Sel = arrPaperSubViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrPaperSubViewpointAppraise_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objPaperSubViewpointAppraise_Cond), exports.paperSubViewpointAppraise_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.PaperSubViewpointAppraise_GetRecCountByCond_Cache = PaperSubViewpointAppraise_GetRecCountByCond_Cache;
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
    async function PaperSubViewpointAppraise_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperSubViewpointAppraise_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperSubViewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperSubViewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperSubViewpointAppraise_GetMaxStrIdByPrefix = PaperSubViewpointAppraise_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function PaperSubViewpointAppraise_GetWebApiUrl(strController, strAction) {
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
    exports.PaperSubViewpointAppraise_GetWebApiUrl = PaperSubViewpointAppraise_GetWebApiUrl;
    /**
    * 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshCache)
    **/
    function PaperSubViewpointAppraise_ReFreshCache() {
        const strThisFuncName = "ReFreshCache";
        const strMsg = (0, clsString_js_1.Format)("刷新缓存成功！");
        console.trace(strMsg);
        // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
        const strKey = clsPaperSubViewpointAppraiseEN_js_1.clsPaperSubViewpointAppraiseEN._CurrTabName;
        switch (clsPaperSubViewpointAppraiseEN_js_1.clsPaperSubViewpointAppraiseEN.CacheModeId) {
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
    exports.PaperSubViewpointAppraise_ReFreshCache = PaperSubViewpointAppraise_ReFreshCache;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function PaperSubViewpointAppraise_ReFreshThisCache() {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = clsPaperSubViewpointAppraiseEN_js_1.clsPaperSubViewpointAppraiseEN._CurrTabName;
            switch (clsPaperSubViewpointAppraiseEN_js_1.clsPaperSubViewpointAppraiseEN.CacheModeId) {
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
    exports.PaperSubViewpointAppraise_ReFreshThisCache = PaperSubViewpointAppraise_ReFreshThisCache;
    /* 该表的下拉框功能没有设置，不需要生成下拉框绑定函数。*/
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function PaperSubViewpointAppraise_CheckPropertyNew(pobjPaperSubViewpointAppraiseEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperSubViewpointAppraiseEN.appraiseContent) == false && (0, clsString_js_1.GetStrLen)(pobjPaperSubViewpointAppraiseEN.appraiseContent) > 2000) {
            throw new Error("(errid:Watl000059)字段[评议内容(appraiseContent)]的长度不能超过2000(In 子观点评论表(PaperSubViewpointAppraise))!值:$(pobjPaperSubViewpointAppraiseEN.appraiseContent)(clsPaperSubViewpointAppraiseBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperSubViewpointAppraiseEN.updDate) == false && (0, clsString_js_1.GetStrLen)(pobjPaperSubViewpointAppraiseEN.updDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 子观点评论表(PaperSubViewpointAppraise))!值:$(pobjPaperSubViewpointAppraiseEN.updDate)(clsPaperSubViewpointAppraiseBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperSubViewpointAppraiseEN.meno) == false && (0, clsString_js_1.GetStrLen)(pobjPaperSubViewpointAppraiseEN.meno) > 2000) {
            throw new Error("(errid:Watl000059)字段[备注(meno)]的长度不能超过2000(In 子观点评论表(PaperSubViewpointAppraise))!值:$(pobjPaperSubViewpointAppraiseEN.meno)(clsPaperSubViewpointAppraiseBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperSubViewpointAppraiseEN.updUser) == false && (0, clsString_js_1.GetStrLen)(pobjPaperSubViewpointAppraiseEN.updUser) > 20) {
            throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 子观点评论表(PaperSubViewpointAppraise))!值:$(pobjPaperSubViewpointAppraiseEN.updUser)(clsPaperSubViewpointAppraiseBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if (null != pobjPaperSubViewpointAppraiseEN.paperSubViewpointAppraiseId && undefined !== pobjPaperSubViewpointAppraiseEN.paperSubViewpointAppraiseId && jsString_js_1.tzDataType.isNumber(pobjPaperSubViewpointAppraiseEN.paperSubViewpointAppraiseId) === false) {
            throw new Error("(errid:Watl000060)字段[子观点评价Id(paperSubViewpointAppraiseId)]的值:[$(pobjPaperSubViewpointAppraiseEN.paperSubViewpointAppraiseId)], 非法，应该为数值型(In 子观点评论表(PaperSubViewpointAppraise))!(clsPaperSubViewpointAppraiseBL:CheckPropertyNew)");
        }
        if (null != pobjPaperSubViewpointAppraiseEN.appraiseScore && undefined !== pobjPaperSubViewpointAppraiseEN.appraiseScore && jsString_js_1.tzDataType.isNumber(pobjPaperSubViewpointAppraiseEN.appraiseScore) === false) {
            throw new Error("(errid:Watl000060)字段[打分(appraiseScore)]的值:[$(pobjPaperSubViewpointAppraiseEN.appraiseScore)], 非法，应该为数值型(In 子观点评论表(PaperSubViewpointAppraise))!(clsPaperSubViewpointAppraiseBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperSubViewpointAppraiseEN.appraiseContent) == false && undefined !== pobjPaperSubViewpointAppraiseEN.appraiseContent && jsString_js_1.tzDataType.isString(pobjPaperSubViewpointAppraiseEN.appraiseContent) === false) {
            throw new Error("(errid:Watl000060)字段[评议内容(appraiseContent)]的值:[$(pobjPaperSubViewpointAppraiseEN.appraiseContent)], 非法，应该为字符型(In 子观点评论表(PaperSubViewpointAppraise))!(clsPaperSubViewpointAppraiseBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperSubViewpointAppraiseEN.updDate) == false && undefined !== pobjPaperSubViewpointAppraiseEN.updDate && jsString_js_1.tzDataType.isString(pobjPaperSubViewpointAppraiseEN.updDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjPaperSubViewpointAppraiseEN.updDate)], 非法，应该为字符型(In 子观点评论表(PaperSubViewpointAppraise))!(clsPaperSubViewpointAppraiseBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperSubViewpointAppraiseEN.meno) == false && undefined !== pobjPaperSubViewpointAppraiseEN.meno && jsString_js_1.tzDataType.isString(pobjPaperSubViewpointAppraiseEN.meno) === false) {
            throw new Error("(errid:Watl000060)字段[备注(meno)]的值:[$(pobjPaperSubViewpointAppraiseEN.meno)], 非法，应该为字符型(In 子观点评论表(PaperSubViewpointAppraise))!(clsPaperSubViewpointAppraiseBL:CheckPropertyNew)");
        }
        if (null != pobjPaperSubViewpointAppraiseEN.subViewpointId && undefined !== pobjPaperSubViewpointAppraiseEN.subViewpointId && jsString_js_1.tzDataType.isNumber(pobjPaperSubViewpointAppraiseEN.subViewpointId) === false) {
            throw new Error("(errid:Watl000060)字段[子观点Id(subViewpointId)]的值:[$(pobjPaperSubViewpointAppraiseEN.subViewpointId)], 非法，应该为数值型(In 子观点评论表(PaperSubViewpointAppraise))!(clsPaperSubViewpointAppraiseBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperSubViewpointAppraiseEN.updUser) == false && undefined !== pobjPaperSubViewpointAppraiseEN.updUser && jsString_js_1.tzDataType.isString(pobjPaperSubViewpointAppraiseEN.updUser) === false) {
            throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjPaperSubViewpointAppraiseEN.updUser)], 非法，应该为字符型(In 子观点评论表(PaperSubViewpointAppraise))!(clsPaperSubViewpointAppraiseBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjPaperSubViewpointAppraiseEN.SetIsCheckProperty(true);
    }
    exports.PaperSubViewpointAppraise_CheckPropertyNew = PaperSubViewpointAppraise_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function PaperSubViewpointAppraise_CheckProperty4Update(pobjPaperSubViewpointAppraiseEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperSubViewpointAppraiseEN.appraiseContent) == false && (0, clsString_js_1.GetStrLen)(pobjPaperSubViewpointAppraiseEN.appraiseContent) > 2000) {
            throw new Error("(errid:Watl000062)字段[评议内容(appraiseContent)]的长度不能超过2000(In 子观点评论表(PaperSubViewpointAppraise))!值:$(pobjPaperSubViewpointAppraiseEN.appraiseContent)(clsPaperSubViewpointAppraiseBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperSubViewpointAppraiseEN.updDate) == false && (0, clsString_js_1.GetStrLen)(pobjPaperSubViewpointAppraiseEN.updDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 子观点评论表(PaperSubViewpointAppraise))!值:$(pobjPaperSubViewpointAppraiseEN.updDate)(clsPaperSubViewpointAppraiseBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperSubViewpointAppraiseEN.meno) == false && (0, clsString_js_1.GetStrLen)(pobjPaperSubViewpointAppraiseEN.meno) > 2000) {
            throw new Error("(errid:Watl000062)字段[备注(meno)]的长度不能超过2000(In 子观点评论表(PaperSubViewpointAppraise))!值:$(pobjPaperSubViewpointAppraiseEN.meno)(clsPaperSubViewpointAppraiseBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperSubViewpointAppraiseEN.updUser) == false && (0, clsString_js_1.GetStrLen)(pobjPaperSubViewpointAppraiseEN.updUser) > 20) {
            throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 子观点评论表(PaperSubViewpointAppraise))!值:$(pobjPaperSubViewpointAppraiseEN.updUser)(clsPaperSubViewpointAppraiseBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if (null != pobjPaperSubViewpointAppraiseEN.paperSubViewpointAppraiseId && undefined !== pobjPaperSubViewpointAppraiseEN.paperSubViewpointAppraiseId && jsString_js_1.tzDataType.isNumber(pobjPaperSubViewpointAppraiseEN.paperSubViewpointAppraiseId) === false) {
            throw new Error("(errid:Watl000063)字段[子观点评价Id(paperSubViewpointAppraiseId)]的值:[$(pobjPaperSubViewpointAppraiseEN.paperSubViewpointAppraiseId)], 非法，应该为数值型(In 子观点评论表(PaperSubViewpointAppraise))!(clsPaperSubViewpointAppraiseBL:CheckProperty4Update)");
        }
        if (null != pobjPaperSubViewpointAppraiseEN.appraiseScore && undefined !== pobjPaperSubViewpointAppraiseEN.appraiseScore && jsString_js_1.tzDataType.isNumber(pobjPaperSubViewpointAppraiseEN.appraiseScore) === false) {
            throw new Error("(errid:Watl000063)字段[打分(appraiseScore)]的值:[$(pobjPaperSubViewpointAppraiseEN.appraiseScore)], 非法，应该为数值型(In 子观点评论表(PaperSubViewpointAppraise))!(clsPaperSubViewpointAppraiseBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperSubViewpointAppraiseEN.appraiseContent) == false && undefined !== pobjPaperSubViewpointAppraiseEN.appraiseContent && jsString_js_1.tzDataType.isString(pobjPaperSubViewpointAppraiseEN.appraiseContent) === false) {
            throw new Error("(errid:Watl000063)字段[评议内容(appraiseContent)]的值:[$(pobjPaperSubViewpointAppraiseEN.appraiseContent)], 非法，应该为字符型(In 子观点评论表(PaperSubViewpointAppraise))!(clsPaperSubViewpointAppraiseBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperSubViewpointAppraiseEN.updDate) == false && undefined !== pobjPaperSubViewpointAppraiseEN.updDate && jsString_js_1.tzDataType.isString(pobjPaperSubViewpointAppraiseEN.updDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjPaperSubViewpointAppraiseEN.updDate)], 非法，应该为字符型(In 子观点评论表(PaperSubViewpointAppraise))!(clsPaperSubViewpointAppraiseBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperSubViewpointAppraiseEN.meno) == false && undefined !== pobjPaperSubViewpointAppraiseEN.meno && jsString_js_1.tzDataType.isString(pobjPaperSubViewpointAppraiseEN.meno) === false) {
            throw new Error("(errid:Watl000063)字段[备注(meno)]的值:[$(pobjPaperSubViewpointAppraiseEN.meno)], 非法，应该为字符型(In 子观点评论表(PaperSubViewpointAppraise))!(clsPaperSubViewpointAppraiseBL:CheckProperty4Update)");
        }
        if (null != pobjPaperSubViewpointAppraiseEN.subViewpointId && undefined !== pobjPaperSubViewpointAppraiseEN.subViewpointId && jsString_js_1.tzDataType.isNumber(pobjPaperSubViewpointAppraiseEN.subViewpointId) === false) {
            throw new Error("(errid:Watl000063)字段[子观点Id(subViewpointId)]的值:[$(pobjPaperSubViewpointAppraiseEN.subViewpointId)], 非法，应该为数值型(In 子观点评论表(PaperSubViewpointAppraise))!(clsPaperSubViewpointAppraiseBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperSubViewpointAppraiseEN.updUser) == false && undefined !== pobjPaperSubViewpointAppraiseEN.updUser && jsString_js_1.tzDataType.isString(pobjPaperSubViewpointAppraiseEN.updUser) === false) {
            throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjPaperSubViewpointAppraiseEN.updUser)], 非法，应该为字符型(In 子观点评论表(PaperSubViewpointAppraise))!(clsPaperSubViewpointAppraiseBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if (null === pobjPaperSubViewpointAppraiseEN.paperSubViewpointAppraiseId
            || pobjPaperSubViewpointAppraiseEN.paperSubViewpointAppraiseId != null && pobjPaperSubViewpointAppraiseEN.paperSubViewpointAppraiseId.toString() === "") {
            throw new Error("(errid:Watl000064)字段[子观点评价Id]不能为空(In 子观点评论表)!(clsPaperSubViewpointAppraiseBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjPaperSubViewpointAppraiseEN.SetIsCheckProperty(true);
    }
    exports.PaperSubViewpointAppraise_CheckProperty4Update = PaperSubViewpointAppraise_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function PaperSubViewpointAppraise_GetJSONStrByObj(pobjPaperSubViewpointAppraiseEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjPaperSubViewpointAppraiseEN.sf_UpdFldSetStr = pobjPaperSubViewpointAppraiseEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjPaperSubViewpointAppraiseEN);
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
    exports.PaperSubViewpointAppraise_GetJSONStrByObj = PaperSubViewpointAppraise_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function PaperSubViewpointAppraise_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrPaperSubViewpointAppraiseObjLst = new Array();
        if (strJSON === "") {
            return arrPaperSubViewpointAppraiseObjLst;
        }
        try {
            arrPaperSubViewpointAppraiseObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrPaperSubViewpointAppraiseObjLst;
        }
        return arrPaperSubViewpointAppraiseObjLst;
    }
    exports.PaperSubViewpointAppraise_GetObjLstByJSONStr = PaperSubViewpointAppraise_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrPaperSubViewpointAppraiseObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function PaperSubViewpointAppraise_GetObjLstByJSONObjLst(arrPaperSubViewpointAppraiseObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrPaperSubViewpointAppraiseObjLst = new Array();
        for (const objInFor of arrPaperSubViewpointAppraiseObjLstS) {
            const obj1 = PaperSubViewpointAppraise_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrPaperSubViewpointAppraiseObjLst.push(obj1);
        }
        return arrPaperSubViewpointAppraiseObjLst;
    }
    exports.PaperSubViewpointAppraise_GetObjLstByJSONObjLst = PaperSubViewpointAppraise_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function PaperSubViewpointAppraise_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjPaperSubViewpointAppraiseEN = new clsPaperSubViewpointAppraiseEN_js_1.clsPaperSubViewpointAppraiseEN();
        if (strJSON === "") {
            return pobjPaperSubViewpointAppraiseEN;
        }
        try {
            pobjPaperSubViewpointAppraiseEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjPaperSubViewpointAppraiseEN;
        }
        return pobjPaperSubViewpointAppraiseEN;
    }
    exports.PaperSubViewpointAppraise_GetObjByJSONStr = PaperSubViewpointAppraise_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function PaperSubViewpointAppraise_GetCombineCondition(objPaperSubViewpointAppraise_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objPaperSubViewpointAppraise_Cond.dicFldComparisonOp, clsPaperSubViewpointAppraiseEN_js_1.clsPaperSubViewpointAppraiseEN.con_PaperSubViewpointAppraiseId) == true) {
            const strComparisonOp_PaperSubViewpointAppraiseId = objPaperSubViewpointAppraise_Cond.dicFldComparisonOp[clsPaperSubViewpointAppraiseEN_js_1.clsPaperSubViewpointAppraiseEN.con_PaperSubViewpointAppraiseId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsPaperSubViewpointAppraiseEN_js_1.clsPaperSubViewpointAppraiseEN.con_PaperSubViewpointAppraiseId, objPaperSubViewpointAppraise_Cond.paperSubViewpointAppraiseId, strComparisonOp_PaperSubViewpointAppraiseId);
        }
        if (Object.prototype.hasOwnProperty.call(objPaperSubViewpointAppraise_Cond.dicFldComparisonOp, clsPaperSubViewpointAppraiseEN_js_1.clsPaperSubViewpointAppraiseEN.con_AppraiseScore) == true) {
            const strComparisonOp_AppraiseScore = objPaperSubViewpointAppraise_Cond.dicFldComparisonOp[clsPaperSubViewpointAppraiseEN_js_1.clsPaperSubViewpointAppraiseEN.con_AppraiseScore];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsPaperSubViewpointAppraiseEN_js_1.clsPaperSubViewpointAppraiseEN.con_AppraiseScore, objPaperSubViewpointAppraise_Cond.appraiseScore, strComparisonOp_AppraiseScore);
        }
        if (Object.prototype.hasOwnProperty.call(objPaperSubViewpointAppraise_Cond.dicFldComparisonOp, clsPaperSubViewpointAppraiseEN_js_1.clsPaperSubViewpointAppraiseEN.con_AppraiseContent) == true) {
            const strComparisonOp_AppraiseContent = objPaperSubViewpointAppraise_Cond.dicFldComparisonOp[clsPaperSubViewpointAppraiseEN_js_1.clsPaperSubViewpointAppraiseEN.con_AppraiseContent];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsPaperSubViewpointAppraiseEN_js_1.clsPaperSubViewpointAppraiseEN.con_AppraiseContent, objPaperSubViewpointAppraise_Cond.appraiseContent, strComparisonOp_AppraiseContent);
        }
        if (Object.prototype.hasOwnProperty.call(objPaperSubViewpointAppraise_Cond.dicFldComparisonOp, clsPaperSubViewpointAppraiseEN_js_1.clsPaperSubViewpointAppraiseEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objPaperSubViewpointAppraise_Cond.dicFldComparisonOp[clsPaperSubViewpointAppraiseEN_js_1.clsPaperSubViewpointAppraiseEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsPaperSubViewpointAppraiseEN_js_1.clsPaperSubViewpointAppraiseEN.con_UpdDate, objPaperSubViewpointAppraise_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objPaperSubViewpointAppraise_Cond.dicFldComparisonOp, clsPaperSubViewpointAppraiseEN_js_1.clsPaperSubViewpointAppraiseEN.con_Meno) == true) {
            const strComparisonOp_Meno = objPaperSubViewpointAppraise_Cond.dicFldComparisonOp[clsPaperSubViewpointAppraiseEN_js_1.clsPaperSubViewpointAppraiseEN.con_Meno];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsPaperSubViewpointAppraiseEN_js_1.clsPaperSubViewpointAppraiseEN.con_Meno, objPaperSubViewpointAppraise_Cond.meno, strComparisonOp_Meno);
        }
        if (Object.prototype.hasOwnProperty.call(objPaperSubViewpointAppraise_Cond.dicFldComparisonOp, clsPaperSubViewpointAppraiseEN_js_1.clsPaperSubViewpointAppraiseEN.con_SubViewpointId) == true) {
            const strComparisonOp_SubViewpointId = objPaperSubViewpointAppraise_Cond.dicFldComparisonOp[clsPaperSubViewpointAppraiseEN_js_1.clsPaperSubViewpointAppraiseEN.con_SubViewpointId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsPaperSubViewpointAppraiseEN_js_1.clsPaperSubViewpointAppraiseEN.con_SubViewpointId, objPaperSubViewpointAppraise_Cond.subViewpointId, strComparisonOp_SubViewpointId);
        }
        if (Object.prototype.hasOwnProperty.call(objPaperSubViewpointAppraise_Cond.dicFldComparisonOp, clsPaperSubViewpointAppraiseEN_js_1.clsPaperSubViewpointAppraiseEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objPaperSubViewpointAppraise_Cond.dicFldComparisonOp[clsPaperSubViewpointAppraiseEN_js_1.clsPaperSubViewpointAppraiseEN.con_UpdUser];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsPaperSubViewpointAppraiseEN_js_1.clsPaperSubViewpointAppraiseEN.con_UpdUser, objPaperSubViewpointAppraise_Cond.updUser, strComparisonOp_UpdUser);
        }
        return strWhereCond;
    }
    exports.PaperSubViewpointAppraise_GetCombineCondition = PaperSubViewpointAppraise_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--PaperSubViewpointAppraise(子观点评论表),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param lngPaperSubViewpointAppraiseId: 子观点评价Id(要求唯一的字段)
    * @param lngSubViewpointId: 子观点Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function PaperSubViewpointAppraise_GetUniCondStr_PaperSubViewpointAppraiseId_SuvViewpointId(objPaperSubViewpointAppraiseEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and PaperSubViewpointAppraiseId = '{0}'", objPaperSubViewpointAppraiseEN.paperSubViewpointAppraiseId);
        strWhereCond += (0, clsString_js_1.Format)(" and SubViewpointId = '{0}'", objPaperSubViewpointAppraiseEN.subViewpointId);
        return strWhereCond;
    }
    exports.PaperSubViewpointAppraise_GetUniCondStr_PaperSubViewpointAppraiseId_SuvViewpointId = PaperSubViewpointAppraise_GetUniCondStr_PaperSubViewpointAppraiseId_SuvViewpointId;
    /**
    *获取唯一性条件串(Uniqueness)--PaperSubViewpointAppraise(子观点评论表),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param lngPaperSubViewpointAppraiseId: 子观点评价Id(要求唯一的字段)
    * @param lngSubViewpointId: 子观点Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function PaperSubViewpointAppraise_GetUniCondStr4Update_PaperSubViewpointAppraiseId_SuvViewpointId(objPaperSubViewpointAppraiseEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and PaperSubViewpointAppraiseId <> '{0}'", objPaperSubViewpointAppraiseEN.paperSubViewpointAppraiseId);
        strWhereCond += (0, clsString_js_1.Format)(" and PaperSubViewpointAppraiseId = '{0}'", objPaperSubViewpointAppraiseEN.paperSubViewpointAppraiseId);
        strWhereCond += (0, clsString_js_1.Format)(" and SubViewpointId = '{0}'", objPaperSubViewpointAppraiseEN.subViewpointId);
        return strWhereCond;
    }
    exports.PaperSubViewpointAppraise_GetUniCondStr4Update_PaperSubViewpointAppraiseId_SuvViewpointId = PaperSubViewpointAppraise_GetUniCondStr4Update_PaperSubViewpointAppraiseId_SuvViewpointId;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objPaperSubViewpointAppraiseENS:源对象
     * @param objPaperSubViewpointAppraiseENT:目标对象
    */
    function PaperSubViewpointAppraise_CopyObjTo(objPaperSubViewpointAppraiseENS, objPaperSubViewpointAppraiseENT) {
        objPaperSubViewpointAppraiseENT.paperSubViewpointAppraiseId = objPaperSubViewpointAppraiseENS.paperSubViewpointAppraiseId; //子观点评价Id
        objPaperSubViewpointAppraiseENT.appraiseScore = objPaperSubViewpointAppraiseENS.appraiseScore; //打分
        objPaperSubViewpointAppraiseENT.appraiseContent = objPaperSubViewpointAppraiseENS.appraiseContent; //评议内容
        objPaperSubViewpointAppraiseENT.updDate = objPaperSubViewpointAppraiseENS.updDate; //修改日期
        objPaperSubViewpointAppraiseENT.meno = objPaperSubViewpointAppraiseENS.meno; //备注
        objPaperSubViewpointAppraiseENT.subViewpointId = objPaperSubViewpointAppraiseENS.subViewpointId; //子观点Id
        objPaperSubViewpointAppraiseENT.updUser = objPaperSubViewpointAppraiseENS.updUser; //修改人
        objPaperSubViewpointAppraiseENT.sf_UpdFldSetStr = objPaperSubViewpointAppraiseENS.updFldString; //sf_UpdFldSetStr
    }
    exports.PaperSubViewpointAppraise_CopyObjTo = PaperSubViewpointAppraise_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objPaperSubViewpointAppraiseENS:源对象
     * @param objPaperSubViewpointAppraiseENT:目标对象
    */
    function PaperSubViewpointAppraise_GetObjFromJsonObj(objPaperSubViewpointAppraiseENS) {
        const objPaperSubViewpointAppraiseENT = new clsPaperSubViewpointAppraiseEN_js_1.clsPaperSubViewpointAppraiseEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objPaperSubViewpointAppraiseENT, objPaperSubViewpointAppraiseENS);
        return objPaperSubViewpointAppraiseENT;
    }
    exports.PaperSubViewpointAppraise_GetObjFromJsonObj = PaperSubViewpointAppraise_GetObjFromJsonObj;
});
