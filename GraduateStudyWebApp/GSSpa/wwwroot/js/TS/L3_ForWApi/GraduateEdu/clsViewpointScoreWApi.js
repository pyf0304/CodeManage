/**
* 类名:clsViewpointScoreWApi
* 表名:ViewpointScore(01120600)
* 生成代码版本:2022.11.02.1
* 生成日期:2022/11/02 11:46:20
* 生成者:pyf
* 生成服务器IP:
工程名称:问卷调查(0112)
CM工程:研究生论文学习(变量首字母小写)-全部函数集
* 相关数据库:103.116.76.183,9433EduHigh_Jsie
* PrjDataBaseId:0170
模块中文名:研究生培养(GraduateEdu)
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
        define(["require", "exports", "axios", "../../PubFun/CacheHelper.js", "../../L0_Entity/GraduateEdu/clsViewpointScoreEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsSysPara4WebApi.js", "../../PubFun/CacheHelper.js", "../../PubFun/jsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.ViewpointScore_GetObjFromJsonObj = exports.ViewpointScore_CopyObjTo = exports.ViewpointScore_GetUniCondStr4Update_ViewpointScoreId_ViewpointId = exports.ViewpointScore_GetUniCondStr_ViewpointScoreId_ViewpointId = exports.ViewpointScore_GetCombineCondition = exports.ViewpointScore_GetObjByJSONStr = exports.ViewpointScore_GetObjLstByJSONObjLst = exports.ViewpointScore_GetObjLstByJSONStr = exports.ViewpointScore_GetJSONStrByObj = exports.ViewpointScore_CheckProperty4Update = exports.ViewpointScore_CheckPropertyNew = exports.ViewpointScore_ReFreshThisCache = exports.ViewpointScore_ReFreshCache = exports.ViewpointScore_GetWebApiUrl = exports.ViewpointScore_GetMaxStrIdByPrefix = exports.ViewpointScore_GetRecCountByCond_Cache = exports.ViewpointScore_GetRecCountByCondAsync = exports.ViewpointScore_IsExistAsync = exports.ViewpointScore_IsExist_Cache = exports.ViewpointScore_IsExist = exports.ViewpointScore_IsExistRecordAsync = exports.ViewpointScore_IsExistRecord_Cache = exports.ViewpointScore_UpdateWithConditionAsync = exports.ViewpointScore_UpdateRecordAsync = exports.ViewpointScore_AddNewRecordWithReturnKey = exports.ViewpointScore_AddNewRecordWithReturnKeyAsync = exports.ViewpointScore_AddNewRecordAsync = exports.ViewpointScore_DelViewpointScoresByCondAsync = exports.ViewpointScore_DelViewpointScoresAsync = exports.ViewpointScore_DelRecordAsync = exports.ViewpointScore_GetObjLstByPagerAsync = exports.ViewpointScore_GetObjLstByPager_Cache = exports.ViewpointScore_GetObjLstByRange = exports.ViewpointScore_GetObjLstByRangeAsync = exports.ViewpointScore_GetTopObjLstAsync = exports.ViewpointScore_GetObjLstByViewpointScoreIdLst_Cache = exports.ViewpointScore_GetObjLstByViewpointScoreIdLstAsync = exports.ViewpointScore_GetSubObjLst_Cache = exports.ViewpointScore_GetObjLst_PureCache = exports.ViewpointScore_GetObjLst_Cache = exports.ViewpointScore_GetObjLst_sessionStorage_PureCache = exports.ViewpointScore_GetObjLst_sessionStorage = exports.ViewpointScore_GetObjLstAsync = exports.ViewpointScore_GetObjLst_localStorage_PureCache = exports.ViewpointScore_GetObjLst_localStorage = exports.ViewpointScore_GetObjLst_ClientCache = exports.ViewpointScore_GetFirstObjAsync = exports.ViewpointScore_GetFirstID = exports.ViewpointScore_GetFirstIDAsync = exports.ViewpointScore_FilterFunByKey = exports.ViewpointScore_SortFunByKey = exports.ViewpointScore_SortFun_Defa_2Fld = exports.ViewpointScore_SortFun_Defa = exports.ViewpointScore_func = exports.ViewpointScore_UpdateObjInLst_Cache = exports.ViewpointScore_GetObjByViewpointScoreId_localStorage = exports.ViewpointScore_GetObjByViewpointScoreId_Cache = exports.ViewpointScore_GetObjByViewpointScoreIdAsync = exports.viewpointScore_ConstructorName = exports.viewpointScore_Controller = void 0;
    /**
     * 观点评分表(ViewpointScore)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2022年11月02日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsViewpointScoreEN_js_1 = require("../../L0_Entity/GraduateEdu/clsViewpointScoreEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    const CacheHelper_js_2 = require("../../PubFun/CacheHelper.js");
    const jsString_js_1 = require("../../PubFun/jsString.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.viewpointScore_Controller = "ViewpointScoreApi";
    exports.viewpointScore_ConstructorName = "viewpointScore";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param lngViewpointScoreId:关键字
    * @returns 对象
    **/
    async function ViewpointScore_GetObjByViewpointScoreIdAsync(lngViewpointScoreId) {
        const strThisFuncName = "GetObjByViewpointScoreIdAsync";
        if (lngViewpointScoreId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngViewpointScoreId]不能为空！(In GetObjByViewpointScoreIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByViewpointScoreId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointScore_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "lngViewpointScoreId": lngViewpointScoreId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.viewpointScore_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objViewpointScore = ViewpointScore_GetObjFromJsonObj(returnObj);
                return objViewpointScore;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointScore_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointScore_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointScore_GetObjByViewpointScoreIdAsync = ViewpointScore_GetObjByViewpointScoreIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param lngViewpointScoreId:所给的关键字
     * @returns 对象
    */
    async function ViewpointScore_GetObjByViewpointScoreId_Cache(lngViewpointScoreId, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByViewpointScoreId_Cache";
        if (lngViewpointScoreId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngViewpointScoreId]不能为空！(In GetObjByViewpointScoreId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        const arrViewpointScoreObjLst_Cache = await ViewpointScore_GetObjLst_Cache();
        try {
            const arrViewpointScore_Sel = arrViewpointScoreObjLst_Cache.filter(x => x.viewpointScoreId == lngViewpointScoreId);
            let objViewpointScore;
            if (arrViewpointScore_Sel.length > 0) {
                objViewpointScore = arrViewpointScore_Sel[0];
                return objViewpointScore;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    objViewpointScore = await ViewpointScore_GetObjByViewpointScoreIdAsync(lngViewpointScoreId);
                    if (objViewpointScore != null) {
                        ViewpointScore_ReFreshThisCache();
                        return objViewpointScore;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngViewpointScoreId, exports.viewpointScore_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.ViewpointScore_GetObjByViewpointScoreId_Cache = ViewpointScore_GetObjByViewpointScoreId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param lngViewpointScoreId:所给的关键字
     * @returns 对象
    */
    async function ViewpointScore_GetObjByViewpointScoreId_localStorage(lngViewpointScoreId) {
        const strThisFuncName = "GetObjByViewpointScoreId_localStorage";
        if (lngViewpointScoreId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngViewpointScoreId]不能为空！(In GetObjByViewpointScoreId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsViewpointScoreEN_js_1.clsViewpointScoreEN._CurrTabName, lngViewpointScoreId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objViewpointScore_Cache = JSON.parse(strTempObj);
            return objViewpointScore_Cache;
        }
        try {
            const objViewpointScore = await ViewpointScore_GetObjByViewpointScoreIdAsync(lngViewpointScoreId);
            if (objViewpointScore != null) {
                localStorage.setItem(strKey, JSON.stringify(objViewpointScore));
                const strInfo = (0, clsString_js_1.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objViewpointScore;
            }
            return objViewpointScore;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngViewpointScoreId, exports.viewpointScore_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.ViewpointScore_GetObjByViewpointScoreId_localStorage = ViewpointScore_GetObjByViewpointScoreId_localStorage;
    /**
     * 修改在缓存对象列表中的对象, 与后台数据库无关.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
     * @param objViewpointScore:所给的对象
     * @returns 对象
    */
    async function ViewpointScore_UpdateObjInLst_Cache(objViewpointScore) {
        const strThisFuncName = "UpdateObjInLst_Cache";
        try {
            const arrViewpointScoreObjLst_Cache = await ViewpointScore_GetObjLst_Cache();
            const obj = arrViewpointScoreObjLst_Cache.find(x => x.viewpointScoreId == objViewpointScore.viewpointScoreId && x.viewpointId == objViewpointScore.viewpointId);
            if (obj != null) {
                objViewpointScore.viewpointScoreId = obj.viewpointScoreId;
                (0, clsCommFunc4Web_js_1.ObjectAssign)(obj, objViewpointScore);
            }
            else {
                arrViewpointScoreObjLst_Cache.push(objViewpointScore);
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, exports.viewpointScore_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.ViewpointScore_UpdateObjInLst_Cache = ViewpointScore_UpdateObjInLst_Cache;
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
    async function ViewpointScore_func(strInFldName, strOutFldName, strInValue) {
        //const strThisFuncName = "func";
        if (strInFldName != clsViewpointScoreEN_js_1.clsViewpointScoreEN.con_ViewpointScoreId) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsViewpointScoreEN_js_1.clsViewpointScoreEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_1.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strInFldName, clsViewpointScoreEN_js_1.clsViewpointScoreEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const lngViewpointScoreId = Number(strInValue);
        if (lngViewpointScoreId == 0) {
            return "";
        }
        const objViewpointScore = await ViewpointScore_GetObjByViewpointScoreId_Cache(lngViewpointScoreId);
        if (objViewpointScore == null)
            return "";
        return objViewpointScore.GetFldValue(strOutFldName).toString();
    }
    exports.ViewpointScore_func = ViewpointScore_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function ViewpointScore_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.viewpointScoreId - b.viewpointScoreId;
    }
    exports.ViewpointScore_SortFun_Defa = ViewpointScore_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function ViewpointScore_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.viewpointScore == b.viewpointScore)
            return a.viewpointId.localeCompare(b.viewpointId);
        else
            return a.viewpointScore - b.viewpointScore;
    }
    exports.ViewpointScore_SortFun_Defa_2Fld = ViewpointScore_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function ViewpointScore_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsViewpointScoreEN_js_1.clsViewpointScoreEN.con_ViewpointScoreId:
                    return (a, b) => {
                        return a.viewpointScoreId - b.viewpointScoreId;
                    };
                case clsViewpointScoreEN_js_1.clsViewpointScoreEN.con_ViewpointScore:
                    return (a, b) => {
                        return a.viewpointScore - b.viewpointScore;
                    };
                case clsViewpointScoreEN_js_1.clsViewpointScoreEN.con_ViewpointId:
                    return (a, b) => {
                        return a.viewpointId.localeCompare(b.viewpointId);
                    };
                case clsViewpointScoreEN_js_1.clsViewpointScoreEN.con_UpdDate:
                    return (a, b) => {
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsViewpointScoreEN_js_1.clsViewpointScoreEN.con_UpdUserId:
                    return (a, b) => {
                        return a.updUserId.localeCompare(b.updUserId);
                    };
                case clsViewpointScoreEN_js_1.clsViewpointScoreEN.con_Memo:
                    return (a, b) => {
                        return a.memo.localeCompare(b.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[ViewpointScore]中不存在！(in ${exports.viewpointScore_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsViewpointScoreEN_js_1.clsViewpointScoreEN.con_ViewpointScoreId:
                    return (a, b) => {
                        return b.viewpointScoreId - a.viewpointScoreId;
                    };
                case clsViewpointScoreEN_js_1.clsViewpointScoreEN.con_ViewpointScore:
                    return (a, b) => {
                        return b.viewpointScore - a.viewpointScore;
                    };
                case clsViewpointScoreEN_js_1.clsViewpointScoreEN.con_ViewpointId:
                    return (a, b) => {
                        return b.viewpointId.localeCompare(a.viewpointId);
                    };
                case clsViewpointScoreEN_js_1.clsViewpointScoreEN.con_UpdDate:
                    return (a, b) => {
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsViewpointScoreEN_js_1.clsViewpointScoreEN.con_UpdUserId:
                    return (a, b) => {
                        return b.updUserId.localeCompare(a.updUserId);
                    };
                case clsViewpointScoreEN_js_1.clsViewpointScoreEN.con_Memo:
                    return (a, b) => {
                        return b.memo.localeCompare(a.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[ViewpointScore]中不存在！(in ${exports.viewpointScore_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.ViewpointScore_SortFunByKey = ViewpointScore_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function ViewpointScore_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsViewpointScoreEN_js_1.clsViewpointScoreEN.con_ViewpointScoreId:
                return (obj) => {
                    return obj.viewpointScoreId === value;
                };
            case clsViewpointScoreEN_js_1.clsViewpointScoreEN.con_ViewpointScore:
                return (obj) => {
                    return obj.viewpointScore === value;
                };
            case clsViewpointScoreEN_js_1.clsViewpointScoreEN.con_ViewpointId:
                return (obj) => {
                    return obj.viewpointId === value;
                };
            case clsViewpointScoreEN_js_1.clsViewpointScoreEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsViewpointScoreEN_js_1.clsViewpointScoreEN.con_UpdUserId:
                return (obj) => {
                    return obj.updUserId === value;
                };
            case clsViewpointScoreEN_js_1.clsViewpointScoreEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[ViewpointScore]中不存在！(in ${exports.viewpointScore_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.ViewpointScore_FilterFunByKey = ViewpointScore_FilterFunByKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function ViewpointScore_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointScore_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointScore_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointScore_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointScore_GetFirstIDAsync = ViewpointScore_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function ViewpointScore_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointScore_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointScore_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointScore_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointScore_GetFirstID = ViewpointScore_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function ViewpointScore_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointScore_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.viewpointScore_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objViewpointScore = ViewpointScore_GetObjFromJsonObj(returnObj);
                return objViewpointScore;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointScore_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointScore_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointScore_GetFirstObjAsync = ViewpointScore_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function ViewpointScore_GetObjLst_ClientCache() {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsViewpointScoreEN_js_1.clsViewpointScoreEN._CurrTabName;
        clsViewpointScoreEN_js_1.clsViewpointScoreEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsViewpointScoreEN_js_1.clsViewpointScoreEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsViewpointScoreEN_js_1.clsViewpointScoreEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsViewpointScoreEN_js_1.clsViewpointScoreEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_2.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrViewpointScoreExObjLst_Cache = CacheHelper_js_2.CacheHelper.Get(strKey);
            const arrViewpointScoreObjLst_T = ViewpointScore_GetObjLstByJSONObjLst(arrViewpointScoreExObjLst_Cache);
            return arrViewpointScoreObjLst_T;
        }
        try {
            const arrViewpointScoreExObjLst = await ViewpointScore_GetObjLstAsync(strWhereCond);
            CacheHelper_js_2.CacheHelper.Add(strKey, arrViewpointScoreExObjLst);
            const strInfo = (0, clsString_js_1.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrViewpointScoreExObjLst.length);
            console.log(strInfo);
            return arrViewpointScoreExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.viewpointScore_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.ViewpointScore_GetObjLst_ClientCache = ViewpointScore_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function ViewpointScore_GetObjLst_localStorage() {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsViewpointScoreEN_js_1.clsViewpointScoreEN._CurrTabName;
        clsViewpointScoreEN_js_1.clsViewpointScoreEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsViewpointScoreEN_js_1.clsViewpointScoreEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsViewpointScoreEN_js_1.clsViewpointScoreEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsViewpointScoreEN_js_1.clsViewpointScoreEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrViewpointScoreExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrViewpointScoreObjLst_T = ViewpointScore_GetObjLstByJSONObjLst(arrViewpointScoreExObjLst_Cache);
            return arrViewpointScoreObjLst_T;
        }
        try {
            const arrViewpointScoreExObjLst = await ViewpointScore_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrViewpointScoreExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrViewpointScoreExObjLst.length);
            console.log(strInfo);
            return arrViewpointScoreExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.viewpointScore_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.ViewpointScore_GetObjLst_localStorage = ViewpointScore_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function ViewpointScore_GetObjLst_localStorage_PureCache() {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsViewpointScoreEN_js_1.clsViewpointScoreEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrViewpointScoreObjLst_Cache = JSON.parse(strTempObjLst);
            return arrViewpointScoreObjLst_Cache;
        }
        else
            return null;
    }
    exports.ViewpointScore_GetObjLst_localStorage_PureCache = ViewpointScore_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function ViewpointScore_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointScore_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.viewpointScore_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = ViewpointScore_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointScore_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointScore_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointScore_GetObjLstAsync = ViewpointScore_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function ViewpointScore_GetObjLst_sessionStorage() {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsViewpointScoreEN_js_1.clsViewpointScoreEN._CurrTabName;
        clsViewpointScoreEN_js_1.clsViewpointScoreEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsViewpointScoreEN_js_1.clsViewpointScoreEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsViewpointScoreEN_js_1.clsViewpointScoreEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsViewpointScoreEN_js_1.clsViewpointScoreEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrViewpointScoreExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrViewpointScoreObjLst_T = ViewpointScore_GetObjLstByJSONObjLst(arrViewpointScoreExObjLst_Cache);
            return arrViewpointScoreObjLst_T;
        }
        try {
            const arrViewpointScoreExObjLst = await ViewpointScore_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrViewpointScoreExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrViewpointScoreExObjLst.length);
            console.log(strInfo);
            return arrViewpointScoreExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.viewpointScore_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.ViewpointScore_GetObjLst_sessionStorage = ViewpointScore_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function ViewpointScore_GetObjLst_sessionStorage_PureCache() {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsViewpointScoreEN_js_1.clsViewpointScoreEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrViewpointScoreObjLst_Cache = JSON.parse(strTempObjLst);
            return arrViewpointScoreObjLst_Cache;
        }
        else
            return null;
    }
    exports.ViewpointScore_GetObjLst_sessionStorage_PureCache = ViewpointScore_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function ViewpointScore_GetObjLst_Cache() {
        //const strThisFuncName = "GetObjLst_Cache";
        let arrViewpointScoreObjLst_Cache;
        switch (clsViewpointScoreEN_js_1.clsViewpointScoreEN.CacheModeId) {
            case "04": //sessionStorage
                arrViewpointScoreObjLst_Cache = await ViewpointScore_GetObjLst_sessionStorage();
                break;
            case "03": //localStorage
                arrViewpointScoreObjLst_Cache = await ViewpointScore_GetObjLst_localStorage();
                break;
            case "02": //ClientCache
                arrViewpointScoreObjLst_Cache = await ViewpointScore_GetObjLst_ClientCache();
                break;
            default:
                arrViewpointScoreObjLst_Cache = await ViewpointScore_GetObjLst_ClientCache();
                break;
        }
        const arrViewpointScoreObjLst = ViewpointScore_GetObjLstByJSONObjLst(arrViewpointScoreObjLst_Cache);
        return arrViewpointScoreObjLst_Cache;
    }
    exports.ViewpointScore_GetObjLst_Cache = ViewpointScore_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function ViewpointScore_GetObjLst_PureCache() {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrViewpointScoreObjLst_Cache;
        switch (clsViewpointScoreEN_js_1.clsViewpointScoreEN.CacheModeId) {
            case "04": //sessionStorage
                arrViewpointScoreObjLst_Cache = await ViewpointScore_GetObjLst_sessionStorage_PureCache();
                break;
            case "03": //localStorage
                arrViewpointScoreObjLst_Cache = await ViewpointScore_GetObjLst_localStorage_PureCache();
                break;
            case "02": //ClientCache
                arrViewpointScoreObjLst_Cache = null;
                break;
            default:
                arrViewpointScoreObjLst_Cache = null;
                break;
        }
        return arrViewpointScoreObjLst_Cache;
    }
    exports.ViewpointScore_GetObjLst_PureCache = ViewpointScore_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objlngViewpointScoreId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function ViewpointScore_GetSubObjLst_Cache(objViewpointScore_Cond) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrViewpointScoreObjLst_Cache = await ViewpointScore_GetObjLst_Cache();
        let arrViewpointScore_Sel = arrViewpointScoreObjLst_Cache;
        if (objViewpointScore_Cond.sf_FldComparisonOp == null || objViewpointScore_Cond.sf_FldComparisonOp == "")
            return arrViewpointScore_Sel;
        const dicFldComparisonOp = JSON.parse(objViewpointScore_Cond.sf_FldComparisonOp);
        //console.log("clsViewpointScoreWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objViewpointScore_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrViewpointScore_Sel = arrViewpointScore_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objViewpointScore_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrViewpointScore_Sel = arrViewpointScore_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrViewpointScore_Sel = arrViewpointScore_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrViewpointScore_Sel = arrViewpointScore_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrViewpointScore_Sel = arrViewpointScore_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrViewpointScore_Sel = arrViewpointScore_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrViewpointScore_Sel = arrViewpointScore_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrViewpointScore_Sel = arrViewpointScore_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrViewpointScore_Sel = arrViewpointScore_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrViewpointScore_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objViewpointScore_Cond), exports.viewpointScore_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.ViewpointScore_GetSubObjLst_Cache = ViewpointScore_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrViewpointScoreId:关键字列表
    * @returns 对象列表
    **/
    async function ViewpointScore_GetObjLstByViewpointScoreIdLstAsync(arrViewpointScoreId) {
        const strThisFuncName = "GetObjLstByViewpointScoreIdLstAsync";
        const strAction = "GetObjLstByViewpointScoreIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointScore_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrViewpointScoreId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.viewpointScore_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = ViewpointScore_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointScore_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointScore_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointScore_GetObjLstByViewpointScoreIdLstAsync = ViewpointScore_GetObjLstByViewpointScoreIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrlngViewpointScoreIdLst:关键字列表
     * @returns 对象列表
    */
    async function ViewpointScore_GetObjLstByViewpointScoreIdLst_Cache(arrViewpointScoreIdLst) {
        const strThisFuncName = "GetObjLstByViewpointScoreIdLst_Cache";
        try {
            const arrViewpointScoreObjLst_Cache = await ViewpointScore_GetObjLst_Cache();
            const arrViewpointScore_Sel = arrViewpointScoreObjLst_Cache.filter(x => arrViewpointScoreIdLst.indexOf(x.viewpointScoreId) > -1);
            return arrViewpointScore_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrViewpointScoreIdLst.join(","), exports.viewpointScore_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.ViewpointScore_GetObjLstByViewpointScoreIdLst_Cache = ViewpointScore_GetObjLstByViewpointScoreIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function ViewpointScore_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointScore_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.viewpointScore_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = ViewpointScore_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointScore_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointScore_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointScore_GetTopObjLstAsync = ViewpointScore_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function ViewpointScore_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointScore_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.viewpointScore_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = ViewpointScore_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointScore_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointScore_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointScore_GetObjLstByRangeAsync = ViewpointScore_GetObjLstByRangeAsync;
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
    async function ViewpointScore_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointScore_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointScore_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointScore_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointScore_GetObjLstByRange = ViewpointScore_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function ViewpointScore_GetObjLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const arrViewpointScoreObjLst_Cache = await ViewpointScore_GetObjLst_Cache();
        if (arrViewpointScoreObjLst_Cache.length == 0)
            return arrViewpointScoreObjLst_Cache;
        let arrViewpointScore_Sel = arrViewpointScoreObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objViewpointScore_Cond = new clsViewpointScoreEN_js_1.clsViewpointScoreEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objViewpointScore_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsViewpointScoreWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrViewpointScore_Sel = arrViewpointScore_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objViewpointScore_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrViewpointScore_Sel = arrViewpointScore_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrViewpointScore_Sel = arrViewpointScore_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrViewpointScore_Sel = arrViewpointScore_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrViewpointScore_Sel = arrViewpointScore_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrViewpointScore_Sel = arrViewpointScore_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrViewpointScore_Sel = arrViewpointScore_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrViewpointScore_Sel = arrViewpointScore_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrViewpointScore_Sel = arrViewpointScore_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrViewpointScore_Sel = arrViewpointScore_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrViewpointScore_Sel.length == 0)
                return arrViewpointScore_Sel;
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
                arrViewpointScore_Sel = arrViewpointScore_Sel.sort(ViewpointScore_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrViewpointScore_Sel = arrViewpointScore_Sel.sort(objPagerPara.sortFun);
            }
            arrViewpointScore_Sel = arrViewpointScore_Sel.slice(intStart, intEnd);
            return arrViewpointScore_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.viewpointScore_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.ViewpointScore_GetObjLstByPager_Cache = ViewpointScore_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function ViewpointScore_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointScore_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.viewpointScore_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = ViewpointScore_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointScore_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointScore_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointScore_GetObjLstByPagerAsync = ViewpointScore_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param lngViewpointScoreId:关键字
    * @returns 获取删除的结果
    **/
    async function ViewpointScore_DelRecordAsync(lngViewpointScoreId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointScore_Controller, strAction);
        strUrl = (0, clsString_js_1.Format)("{0}/?Id={1}", strUrl, lngViewpointScoreId);
        try {
            const response = await axios_1.default.delete(strUrl, {
                params: { "Id": lngViewpointScoreId, }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointScore_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointScore_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointScore_DelRecordAsync = ViewpointScore_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrViewpointScoreId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function ViewpointScore_DelViewpointScoresAsync(arrViewpointScoreId) {
        const strThisFuncName = "DelViewpointScoresAsync";
        const strAction = "DelViewpointScores";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointScore_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrViewpointScoreId);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointScore_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointScore_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointScore_DelViewpointScoresAsync = ViewpointScore_DelViewpointScoresAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function ViewpointScore_DelViewpointScoresByCondAsync(strWhereCond) {
        const strThisFuncName = "DelViewpointScoresByCondAsync";
        const strAction = "DelViewpointScoresByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointScore_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointScore_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointScore_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointScore_DelViewpointScoresByCondAsync = ViewpointScore_DelViewpointScoresByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objViewpointScoreEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function ViewpointScore_AddNewRecordAsync(objViewpointScoreEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objViewpointScoreEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointScore_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objViewpointScoreEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointScore_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointScore_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointScore_AddNewRecordAsync = ViewpointScore_AddNewRecordAsync;
    /* 数据类型不是字符型，不可以最大关键字的方式添加记录。*/
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objViewpointScoreEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function ViewpointScore_AddNewRecordWithReturnKeyAsync(objViewpointScoreEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointScore_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objViewpointScoreEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointScore_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointScore_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointScore_AddNewRecordWithReturnKeyAsync = ViewpointScore_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objViewpointScoreEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function ViewpointScore_AddNewRecordWithReturnKey(objViewpointScoreEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objViewpointScoreEN.viewpointScoreId === null || objViewpointScoreEN.viewpointScoreId === 0) {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointScore_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objViewpointScoreEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointScore_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointScore_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointScore_AddNewRecordWithReturnKey = ViewpointScore_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objViewpointScoreEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function ViewpointScore_UpdateRecordAsync(objViewpointScoreEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objViewpointScoreEN.sf_UpdFldSetStr === undefined || objViewpointScoreEN.sf_UpdFldSetStr === null || objViewpointScoreEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objViewpointScoreEN.viewpointScoreId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointScore_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objViewpointScoreEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointScore_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointScore_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointScore_UpdateRecordAsync = ViewpointScore_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objViewpointScoreEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function ViewpointScore_UpdateWithConditionAsync(objViewpointScoreEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objViewpointScoreEN.sf_UpdFldSetStr === undefined || objViewpointScoreEN.sf_UpdFldSetStr === null || objViewpointScoreEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objViewpointScoreEN.viewpointScoreId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointScore_Controller, strAction);
        objViewpointScoreEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objViewpointScoreEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointScore_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointScore_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointScore_UpdateWithConditionAsync = ViewpointScore_UpdateWithConditionAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objlngViewpointScoreId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function ViewpointScore_IsExistRecord_Cache(objViewpointScore_Cond) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrViewpointScoreObjLst_Cache = await ViewpointScore_GetObjLst_Cache();
        if (arrViewpointScoreObjLst_Cache == null)
            return false;
        let arrViewpointScore_Sel = arrViewpointScoreObjLst_Cache;
        if (objViewpointScore_Cond.sf_FldComparisonOp == null || objViewpointScore_Cond.sf_FldComparisonOp == "")
            return arrViewpointScore_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objViewpointScore_Cond.sf_FldComparisonOp);
        //console.log("clsViewpointScoreWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objViewpointScore_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objViewpointScore_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrViewpointScore_Sel = arrViewpointScore_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrViewpointScore_Sel = arrViewpointScore_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrViewpointScore_Sel = arrViewpointScore_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrViewpointScore_Sel = arrViewpointScore_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrViewpointScore_Sel = arrViewpointScore_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrViewpointScore_Sel = arrViewpointScore_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrViewpointScore_Sel = arrViewpointScore_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrViewpointScore_Sel = arrViewpointScore_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrViewpointScore_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objViewpointScore_Cond), exports.viewpointScore_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.ViewpointScore_IsExistRecord_Cache = ViewpointScore_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function ViewpointScore_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointScore_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointScore_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointScore_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointScore_IsExistRecordAsync = ViewpointScore_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param lngViewpointScoreId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function ViewpointScore_IsExist(lngViewpointScoreId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointScore_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "ViewpointScoreId": lngViewpointScoreId,
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointScore_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointScore_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointScore_IsExist = ViewpointScore_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param lngViewpointScoreId:所给的关键字
     * @returns 对象
    */
    async function ViewpointScore_IsExist_Cache(lngViewpointScoreId) {
        const strThisFuncName = "IsExist_Cache";
        const arrViewpointScoreObjLst_Cache = await ViewpointScore_GetObjLst_Cache();
        if (arrViewpointScoreObjLst_Cache == null)
            return false;
        try {
            const arrViewpointScore_Sel = arrViewpointScoreObjLst_Cache.filter(x => x.viewpointScoreId == lngViewpointScoreId);
            if (arrViewpointScore_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", lngViewpointScoreId, exports.viewpointScore_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.ViewpointScore_IsExist_Cache = ViewpointScore_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param lngViewpointScoreId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function ViewpointScore_IsExistAsync(lngViewpointScoreId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointScore_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "lngViewpointScoreId": lngViewpointScoreId }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointScore_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointScore_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointScore_IsExistAsync = ViewpointScore_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function ViewpointScore_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointScore_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointScore_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointScore_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointScore_GetRecCountByCondAsync = ViewpointScore_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objViewpointScore_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function ViewpointScore_GetRecCountByCond_Cache(objViewpointScore_Cond) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrViewpointScoreObjLst_Cache = await ViewpointScore_GetObjLst_Cache();
        if (arrViewpointScoreObjLst_Cache == null)
            return 0;
        let arrViewpointScore_Sel = arrViewpointScoreObjLst_Cache;
        if (objViewpointScore_Cond.sf_FldComparisonOp == null || objViewpointScore_Cond.sf_FldComparisonOp == "")
            return arrViewpointScore_Sel.length;
        const dicFldComparisonOp = JSON.parse(objViewpointScore_Cond.sf_FldComparisonOp);
        //console.log("clsViewpointScoreWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objViewpointScore_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrViewpointScore_Sel = arrViewpointScore_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objViewpointScore_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrViewpointScore_Sel = arrViewpointScore_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrViewpointScore_Sel = arrViewpointScore_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrViewpointScore_Sel = arrViewpointScore_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrViewpointScore_Sel = arrViewpointScore_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrViewpointScore_Sel = arrViewpointScore_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrViewpointScore_Sel = arrViewpointScore_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrViewpointScore_Sel = arrViewpointScore_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrViewpointScore_Sel = arrViewpointScore_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrViewpointScore_Sel = arrViewpointScore_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrViewpointScore_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objViewpointScore_Cond), exports.viewpointScore_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.ViewpointScore_GetRecCountByCond_Cache = ViewpointScore_GetRecCountByCond_Cache;
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
    async function ViewpointScore_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointScore_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointScore_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointScore_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointScore_GetMaxStrIdByPrefix = ViewpointScore_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function ViewpointScore_GetWebApiUrl(strController, strAction) {
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
    exports.ViewpointScore_GetWebApiUrl = ViewpointScore_GetWebApiUrl;
    /**
    * 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshCache)
    **/
    function ViewpointScore_ReFreshCache() {
        const strThisFuncName = "ReFreshCache";
        const strMsg = (0, clsString_js_1.Format)("刷新缓存成功！");
        console.trace(strMsg);
        // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
        const strKey = clsViewpointScoreEN_js_1.clsViewpointScoreEN._CurrTabName;
        switch (clsViewpointScoreEN_js_1.clsViewpointScoreEN.CacheModeId) {
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
    exports.ViewpointScore_ReFreshCache = ViewpointScore_ReFreshCache;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function ViewpointScore_ReFreshThisCache() {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = clsViewpointScoreEN_js_1.clsViewpointScoreEN._CurrTabName;
            switch (clsViewpointScoreEN_js_1.clsViewpointScoreEN.CacheModeId) {
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
    exports.ViewpointScore_ReFreshThisCache = ViewpointScore_ReFreshThisCache;
    /* 该表的下拉框功能没有设置，不需要生成下拉框绑定函数。*/
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function ViewpointScore_CheckPropertyNew(pobjViewpointScoreEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjViewpointScoreEN.viewpointId) == false && (0, clsString_js_1.GetStrLen)(pobjViewpointScoreEN.viewpointId) > 8) {
            throw new Error("(errid:Watl000059)字段[观点Id(viewpointId)]的长度不能超过8(In 观点评分表(ViewpointScore))!值:$(pobjViewpointScoreEN.viewpointId)(clsViewpointScoreBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjViewpointScoreEN.updDate) == false && (0, clsString_js_1.GetStrLen)(pobjViewpointScoreEN.updDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 观点评分表(ViewpointScore))!值:$(pobjViewpointScoreEN.updDate)(clsViewpointScoreBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjViewpointScoreEN.updUserId) == false && (0, clsString_js_1.GetStrLen)(pobjViewpointScoreEN.updUserId) > 20) {
            throw new Error("(errid:Watl000059)字段[修改用户Id(updUserId)]的长度不能超过20(In 观点评分表(ViewpointScore))!值:$(pobjViewpointScoreEN.updUserId)(clsViewpointScoreBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjViewpointScoreEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjViewpointScoreEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 观点评分表(ViewpointScore))!值:$(pobjViewpointScoreEN.memo)(clsViewpointScoreBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if (null != pobjViewpointScoreEN.viewpointScoreId && undefined !== pobjViewpointScoreEN.viewpointScoreId && jsString_js_1.tzDataType.isNumber(pobjViewpointScoreEN.viewpointScoreId) === false) {
            throw new Error("(errid:Watl000060)字段[评分Id(viewpointScoreId)]的值:[$(pobjViewpointScoreEN.viewpointScoreId)], 非法，应该为数值型(In 观点评分表(ViewpointScore))!(clsViewpointScoreBL:CheckPropertyNew)");
        }
        if (null != pobjViewpointScoreEN.viewpointScore && undefined !== pobjViewpointScoreEN.viewpointScore && jsString_js_1.tzDataType.isNumber(pobjViewpointScoreEN.viewpointScore) === false) {
            throw new Error("(errid:Watl000060)字段[评分(viewpointScore)]的值:[$(pobjViewpointScoreEN.viewpointScore)], 非法，应该为数值型(In 观点评分表(ViewpointScore))!(clsViewpointScoreBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjViewpointScoreEN.viewpointId) == false && undefined !== pobjViewpointScoreEN.viewpointId && jsString_js_1.tzDataType.isString(pobjViewpointScoreEN.viewpointId) === false) {
            throw new Error("(errid:Watl000060)字段[观点Id(viewpointId)]的值:[$(pobjViewpointScoreEN.viewpointId)], 非法，应该为字符型(In 观点评分表(ViewpointScore))!(clsViewpointScoreBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjViewpointScoreEN.updDate) == false && undefined !== pobjViewpointScoreEN.updDate && jsString_js_1.tzDataType.isString(pobjViewpointScoreEN.updDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjViewpointScoreEN.updDate)], 非法，应该为字符型(In 观点评分表(ViewpointScore))!(clsViewpointScoreBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjViewpointScoreEN.updUserId) == false && undefined !== pobjViewpointScoreEN.updUserId && jsString_js_1.tzDataType.isString(pobjViewpointScoreEN.updUserId) === false) {
            throw new Error("(errid:Watl000060)字段[修改用户Id(updUserId)]的值:[$(pobjViewpointScoreEN.updUserId)], 非法，应该为字符型(In 观点评分表(ViewpointScore))!(clsViewpointScoreBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjViewpointScoreEN.memo) == false && undefined !== pobjViewpointScoreEN.memo && jsString_js_1.tzDataType.isString(pobjViewpointScoreEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjViewpointScoreEN.memo)], 非法，应该为字符型(In 观点评分表(ViewpointScore))!(clsViewpointScoreBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjViewpointScoreEN.SetIsCheckProperty(true);
    }
    exports.ViewpointScore_CheckPropertyNew = ViewpointScore_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function ViewpointScore_CheckProperty4Update(pobjViewpointScoreEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjViewpointScoreEN.viewpointId) == false && (0, clsString_js_1.GetStrLen)(pobjViewpointScoreEN.viewpointId) > 8) {
            throw new Error("(errid:Watl000062)字段[观点Id(viewpointId)]的长度不能超过8(In 观点评分表(ViewpointScore))!值:$(pobjViewpointScoreEN.viewpointId)(clsViewpointScoreBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjViewpointScoreEN.updDate) == false && (0, clsString_js_1.GetStrLen)(pobjViewpointScoreEN.updDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 观点评分表(ViewpointScore))!值:$(pobjViewpointScoreEN.updDate)(clsViewpointScoreBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjViewpointScoreEN.updUserId) == false && (0, clsString_js_1.GetStrLen)(pobjViewpointScoreEN.updUserId) > 20) {
            throw new Error("(errid:Watl000062)字段[修改用户Id(updUserId)]的长度不能超过20(In 观点评分表(ViewpointScore))!值:$(pobjViewpointScoreEN.updUserId)(clsViewpointScoreBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjViewpointScoreEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjViewpointScoreEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 观点评分表(ViewpointScore))!值:$(pobjViewpointScoreEN.memo)(clsViewpointScoreBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if (null != pobjViewpointScoreEN.viewpointScoreId && undefined !== pobjViewpointScoreEN.viewpointScoreId && jsString_js_1.tzDataType.isNumber(pobjViewpointScoreEN.viewpointScoreId) === false) {
            throw new Error("(errid:Watl000063)字段[评分Id(viewpointScoreId)]的值:[$(pobjViewpointScoreEN.viewpointScoreId)], 非法，应该为数值型(In 观点评分表(ViewpointScore))!(clsViewpointScoreBL:CheckProperty4Update)");
        }
        if (null != pobjViewpointScoreEN.viewpointScore && undefined !== pobjViewpointScoreEN.viewpointScore && jsString_js_1.tzDataType.isNumber(pobjViewpointScoreEN.viewpointScore) === false) {
            throw new Error("(errid:Watl000063)字段[评分(viewpointScore)]的值:[$(pobjViewpointScoreEN.viewpointScore)], 非法，应该为数值型(In 观点评分表(ViewpointScore))!(clsViewpointScoreBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjViewpointScoreEN.viewpointId) == false && undefined !== pobjViewpointScoreEN.viewpointId && jsString_js_1.tzDataType.isString(pobjViewpointScoreEN.viewpointId) === false) {
            throw new Error("(errid:Watl000063)字段[观点Id(viewpointId)]的值:[$(pobjViewpointScoreEN.viewpointId)], 非法，应该为字符型(In 观点评分表(ViewpointScore))!(clsViewpointScoreBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjViewpointScoreEN.updDate) == false && undefined !== pobjViewpointScoreEN.updDate && jsString_js_1.tzDataType.isString(pobjViewpointScoreEN.updDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjViewpointScoreEN.updDate)], 非法，应该为字符型(In 观点评分表(ViewpointScore))!(clsViewpointScoreBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjViewpointScoreEN.updUserId) == false && undefined !== pobjViewpointScoreEN.updUserId && jsString_js_1.tzDataType.isString(pobjViewpointScoreEN.updUserId) === false) {
            throw new Error("(errid:Watl000063)字段[修改用户Id(updUserId)]的值:[$(pobjViewpointScoreEN.updUserId)], 非法，应该为字符型(In 观点评分表(ViewpointScore))!(clsViewpointScoreBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjViewpointScoreEN.memo) == false && undefined !== pobjViewpointScoreEN.memo && jsString_js_1.tzDataType.isString(pobjViewpointScoreEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjViewpointScoreEN.memo)], 非法，应该为字符型(In 观点评分表(ViewpointScore))!(clsViewpointScoreBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if (null === pobjViewpointScoreEN.viewpointScoreId
            || pobjViewpointScoreEN.viewpointScoreId != null && pobjViewpointScoreEN.viewpointScoreId.toString() === "") {
            throw new Error("(errid:Watl000064)字段[评分Id]不能为空(In 观点评分表)!(clsViewpointScoreBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjViewpointScoreEN.SetIsCheckProperty(true);
    }
    exports.ViewpointScore_CheckProperty4Update = ViewpointScore_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function ViewpointScore_GetJSONStrByObj(pobjViewpointScoreEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjViewpointScoreEN.sf_UpdFldSetStr = pobjViewpointScoreEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjViewpointScoreEN);
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
    exports.ViewpointScore_GetJSONStrByObj = ViewpointScore_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function ViewpointScore_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrViewpointScoreObjLst = new Array();
        if (strJSON === "") {
            return arrViewpointScoreObjLst;
        }
        try {
            arrViewpointScoreObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrViewpointScoreObjLst;
        }
        return arrViewpointScoreObjLst;
    }
    exports.ViewpointScore_GetObjLstByJSONStr = ViewpointScore_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrViewpointScoreObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function ViewpointScore_GetObjLstByJSONObjLst(arrViewpointScoreObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrViewpointScoreObjLst = new Array();
        for (const objInFor of arrViewpointScoreObjLstS) {
            const obj1 = ViewpointScore_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrViewpointScoreObjLst.push(obj1);
        }
        return arrViewpointScoreObjLst;
    }
    exports.ViewpointScore_GetObjLstByJSONObjLst = ViewpointScore_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function ViewpointScore_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjViewpointScoreEN = new clsViewpointScoreEN_js_1.clsViewpointScoreEN();
        if (strJSON === "") {
            return pobjViewpointScoreEN;
        }
        try {
            pobjViewpointScoreEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjViewpointScoreEN;
        }
        return pobjViewpointScoreEN;
    }
    exports.ViewpointScore_GetObjByJSONStr = ViewpointScore_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function ViewpointScore_GetCombineCondition(objViewpointScore_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objViewpointScore_Cond.dicFldComparisonOp, clsViewpointScoreEN_js_1.clsViewpointScoreEN.con_ViewpointScoreId) == true) {
            const strComparisonOp_ViewpointScoreId = objViewpointScore_Cond.dicFldComparisonOp[clsViewpointScoreEN_js_1.clsViewpointScoreEN.con_ViewpointScoreId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsViewpointScoreEN_js_1.clsViewpointScoreEN.con_ViewpointScoreId, objViewpointScore_Cond.viewpointScoreId, strComparisonOp_ViewpointScoreId);
        }
        if (Object.prototype.hasOwnProperty.call(objViewpointScore_Cond.dicFldComparisonOp, clsViewpointScoreEN_js_1.clsViewpointScoreEN.con_ViewpointScore) == true) {
            const strComparisonOp_ViewpointScore = objViewpointScore_Cond.dicFldComparisonOp[clsViewpointScoreEN_js_1.clsViewpointScoreEN.con_ViewpointScore];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsViewpointScoreEN_js_1.clsViewpointScoreEN.con_ViewpointScore, objViewpointScore_Cond.viewpointScore, strComparisonOp_ViewpointScore);
        }
        if (Object.prototype.hasOwnProperty.call(objViewpointScore_Cond.dicFldComparisonOp, clsViewpointScoreEN_js_1.clsViewpointScoreEN.con_ViewpointId) == true) {
            const strComparisonOp_ViewpointId = objViewpointScore_Cond.dicFldComparisonOp[clsViewpointScoreEN_js_1.clsViewpointScoreEN.con_ViewpointId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsViewpointScoreEN_js_1.clsViewpointScoreEN.con_ViewpointId, objViewpointScore_Cond.viewpointId, strComparisonOp_ViewpointId);
        }
        if (Object.prototype.hasOwnProperty.call(objViewpointScore_Cond.dicFldComparisonOp, clsViewpointScoreEN_js_1.clsViewpointScoreEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objViewpointScore_Cond.dicFldComparisonOp[clsViewpointScoreEN_js_1.clsViewpointScoreEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsViewpointScoreEN_js_1.clsViewpointScoreEN.con_UpdDate, objViewpointScore_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objViewpointScore_Cond.dicFldComparisonOp, clsViewpointScoreEN_js_1.clsViewpointScoreEN.con_UpdUserId) == true) {
            const strComparisonOp_UpdUserId = objViewpointScore_Cond.dicFldComparisonOp[clsViewpointScoreEN_js_1.clsViewpointScoreEN.con_UpdUserId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsViewpointScoreEN_js_1.clsViewpointScoreEN.con_UpdUserId, objViewpointScore_Cond.updUserId, strComparisonOp_UpdUserId);
        }
        if (Object.prototype.hasOwnProperty.call(objViewpointScore_Cond.dicFldComparisonOp, clsViewpointScoreEN_js_1.clsViewpointScoreEN.con_Memo) == true) {
            const strComparisonOp_Memo = objViewpointScore_Cond.dicFldComparisonOp[clsViewpointScoreEN_js_1.clsViewpointScoreEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsViewpointScoreEN_js_1.clsViewpointScoreEN.con_Memo, objViewpointScore_Cond.memo, strComparisonOp_Memo);
        }
        return strWhereCond;
    }
    exports.ViewpointScore_GetCombineCondition = ViewpointScore_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--ViewpointScore(观点评分表),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param lngViewpointScoreId: 评分Id(要求唯一的字段)
    * @param strViewpointId: 观点Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function ViewpointScore_GetUniCondStr_ViewpointScoreId_ViewpointId(objViewpointScoreEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and ViewpointScoreId = '{0}'", objViewpointScoreEN.viewpointScoreId);
        strWhereCond += (0, clsString_js_1.Format)(" and ViewpointId = '{0}'", objViewpointScoreEN.viewpointId);
        return strWhereCond;
    }
    exports.ViewpointScore_GetUniCondStr_ViewpointScoreId_ViewpointId = ViewpointScore_GetUniCondStr_ViewpointScoreId_ViewpointId;
    /**
    *获取唯一性条件串(Uniqueness)--ViewpointScore(观点评分表),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param lngViewpointScoreId: 评分Id(要求唯一的字段)
    * @param strViewpointId: 观点Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function ViewpointScore_GetUniCondStr4Update_ViewpointScoreId_ViewpointId(objViewpointScoreEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and ViewpointScoreId <> '{0}'", objViewpointScoreEN.viewpointScoreId);
        strWhereCond += (0, clsString_js_1.Format)(" and ViewpointScoreId = '{0}'", objViewpointScoreEN.viewpointScoreId);
        strWhereCond += (0, clsString_js_1.Format)(" and ViewpointId = '{0}'", objViewpointScoreEN.viewpointId);
        return strWhereCond;
    }
    exports.ViewpointScore_GetUniCondStr4Update_ViewpointScoreId_ViewpointId = ViewpointScore_GetUniCondStr4Update_ViewpointScoreId_ViewpointId;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objViewpointScoreENS:源对象
     * @param objViewpointScoreENT:目标对象
    */
    function ViewpointScore_CopyObjTo(objViewpointScoreENS, objViewpointScoreENT) {
        objViewpointScoreENT.viewpointScoreId = objViewpointScoreENS.viewpointScoreId; //评分Id
        objViewpointScoreENT.viewpointScore = objViewpointScoreENS.viewpointScore; //评分
        objViewpointScoreENT.viewpointId = objViewpointScoreENS.viewpointId; //观点Id
        objViewpointScoreENT.updDate = objViewpointScoreENS.updDate; //修改日期
        objViewpointScoreENT.updUserId = objViewpointScoreENS.updUserId; //修改用户Id
        objViewpointScoreENT.memo = objViewpointScoreENS.memo; //备注
        objViewpointScoreENT.sf_UpdFldSetStr = objViewpointScoreENS.updFldString; //sf_UpdFldSetStr
    }
    exports.ViewpointScore_CopyObjTo = ViewpointScore_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objViewpointScoreENS:源对象
     * @param objViewpointScoreENT:目标对象
    */
    function ViewpointScore_GetObjFromJsonObj(objViewpointScoreENS) {
        const objViewpointScoreENT = new clsViewpointScoreEN_js_1.clsViewpointScoreEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objViewpointScoreENT, objViewpointScoreENS);
        return objViewpointScoreENT;
    }
    exports.ViewpointScore_GetObjFromJsonObj = ViewpointScore_GetObjFromJsonObj;
});
