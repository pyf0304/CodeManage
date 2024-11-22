/**
* 类名:clsPaperAppraiseWApi
* 表名:PaperAppraise(01120567)
* 生成代码版本:2022.11.02.1
* 生成日期:2022/11/02 11:46:16
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
        define(["require", "exports", "axios", "../../PubFun/CacheHelper.js", "../../L0_Entity/Other/clsPaperAppraiseEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsSysPara4WebApi.js", "../../PubFun/CacheHelper.js", "../../PubFun/jsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.PaperAppraise_GetObjFromJsonObj = exports.PaperAppraise_CopyObjTo = exports.PaperAppraise_GetUniCondStr4Update_PaperId = exports.PaperAppraise_GetUniCondStr_PaperId = exports.PaperAppraise_GetCombineCondition = exports.PaperAppraise_GetObjByJSONStr = exports.PaperAppraise_GetObjLstByJSONObjLst = exports.PaperAppraise_GetObjLstByJSONStr = exports.PaperAppraise_GetJSONStrByObj = exports.PaperAppraise_CheckProperty4Update = exports.PaperAppraise_CheckPropertyNew = exports.PaperAppraise_ReFreshThisCache = exports.PaperAppraise_ReFreshCache = exports.PaperAppraise_GetWebApiUrl = exports.PaperAppraise_GetMaxStrIdByPrefix = exports.PaperAppraise_GetRecCountByCond_Cache = exports.PaperAppraise_GetRecCountByCondAsync = exports.PaperAppraise_IsExistAsync = exports.PaperAppraise_IsExist_Cache = exports.PaperAppraise_IsExist = exports.PaperAppraise_IsExistRecordAsync = exports.PaperAppraise_IsExistRecord_Cache = exports.PaperAppraise_UpdateWithConditionAsync = exports.PaperAppraise_UpdateRecordAsync = exports.PaperAppraise_AddNewRecordWithReturnKey = exports.PaperAppraise_AddNewRecordWithReturnKeyAsync = exports.PaperAppraise_AddNewRecordAsync = exports.PaperAppraise_DelPaperAppraisesByCondAsync = exports.PaperAppraise_DelPaperAppraisesAsync = exports.PaperAppraise_DelRecordAsync = exports.PaperAppraise_GetObjLstByPagerAsync = exports.PaperAppraise_GetObjLstByPager_Cache = exports.PaperAppraise_GetObjLstByRange = exports.PaperAppraise_GetObjLstByRangeAsync = exports.PaperAppraise_GetTopObjLstAsync = exports.PaperAppraise_GetObjLstByPaperAppraiseIdLst_Cache = exports.PaperAppraise_GetObjLstByPaperAppraiseIdLstAsync = exports.PaperAppraise_GetSubObjLst_Cache = exports.PaperAppraise_GetObjLst_PureCache = exports.PaperAppraise_GetObjLst_Cache = exports.PaperAppraise_GetObjLst_sessionStorage_PureCache = exports.PaperAppraise_GetObjLst_sessionStorage = exports.PaperAppraise_GetObjLstAsync = exports.PaperAppraise_GetObjLst_localStorage_PureCache = exports.PaperAppraise_GetObjLst_localStorage = exports.PaperAppraise_GetObjLst_ClientCache = exports.PaperAppraise_GetFirstObjAsync = exports.PaperAppraise_GetFirstID = exports.PaperAppraise_GetFirstIDAsync = exports.PaperAppraise_FilterFunByKey = exports.PaperAppraise_SortFunByKey = exports.PaperAppraise_SortFun_Defa_2Fld = exports.PaperAppraise_SortFun_Defa = exports.PaperAppraise_func = exports.PaperAppraise_UpdateObjInLst_Cache = exports.PaperAppraise_GetObjByPaperAppraiseId_localStorage = exports.PaperAppraise_GetObjByPaperAppraiseId_Cache = exports.PaperAppraise_GetObjByPaperAppraiseIdAsync = exports.paperAppraise_ConstructorName = exports.paperAppraise_Controller = void 0;
    /**
     * 论文评论表(PaperAppraise)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2022年11月02日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsPaperAppraiseEN_js_1 = require("../../L0_Entity/Other/clsPaperAppraiseEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    const CacheHelper_js_2 = require("../../PubFun/CacheHelper.js");
    const jsString_js_1 = require("../../PubFun/jsString.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.paperAppraise_Controller = "PaperAppraiseApi";
    exports.paperAppraise_ConstructorName = "paperAppraise";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param lngPaperAppraiseId:关键字
    * @returns 对象
    **/
    async function PaperAppraise_GetObjByPaperAppraiseIdAsync(lngPaperAppraiseId) {
        const strThisFuncName = "GetObjByPaperAppraiseIdAsync";
        if (lngPaperAppraiseId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngPaperAppraiseId]不能为空！(In GetObjByPaperAppraiseIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByPaperAppraiseId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperAppraise_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "lngPaperAppraiseId": lngPaperAppraiseId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.paperAppraise_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objPaperAppraise = PaperAppraise_GetObjFromJsonObj(returnObj);
                return objPaperAppraise;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperAppraise_GetObjByPaperAppraiseIdAsync = PaperAppraise_GetObjByPaperAppraiseIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param lngPaperAppraiseId:所给的关键字
     * @returns 对象
    */
    async function PaperAppraise_GetObjByPaperAppraiseId_Cache(lngPaperAppraiseId, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByPaperAppraiseId_Cache";
        if (lngPaperAppraiseId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngPaperAppraiseId]不能为空！(In GetObjByPaperAppraiseId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        const arrPaperAppraiseObjLst_Cache = await PaperAppraise_GetObjLst_Cache();
        try {
            const arrPaperAppraise_Sel = arrPaperAppraiseObjLst_Cache.filter(x => x.paperAppraiseId == lngPaperAppraiseId);
            let objPaperAppraise;
            if (arrPaperAppraise_Sel.length > 0) {
                objPaperAppraise = arrPaperAppraise_Sel[0];
                return objPaperAppraise;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    objPaperAppraise = await PaperAppraise_GetObjByPaperAppraiseIdAsync(lngPaperAppraiseId);
                    if (objPaperAppraise != null) {
                        PaperAppraise_ReFreshThisCache();
                        return objPaperAppraise;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngPaperAppraiseId, exports.paperAppraise_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.PaperAppraise_GetObjByPaperAppraiseId_Cache = PaperAppraise_GetObjByPaperAppraiseId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param lngPaperAppraiseId:所给的关键字
     * @returns 对象
    */
    async function PaperAppraise_GetObjByPaperAppraiseId_localStorage(lngPaperAppraiseId) {
        const strThisFuncName = "GetObjByPaperAppraiseId_localStorage";
        if (lngPaperAppraiseId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngPaperAppraiseId]不能为空！(In GetObjByPaperAppraiseId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsPaperAppraiseEN_js_1.clsPaperAppraiseEN._CurrTabName, lngPaperAppraiseId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objPaperAppraise_Cache = JSON.parse(strTempObj);
            return objPaperAppraise_Cache;
        }
        try {
            const objPaperAppraise = await PaperAppraise_GetObjByPaperAppraiseIdAsync(lngPaperAppraiseId);
            if (objPaperAppraise != null) {
                localStorage.setItem(strKey, JSON.stringify(objPaperAppraise));
                const strInfo = (0, clsString_js_1.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objPaperAppraise;
            }
            return objPaperAppraise;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngPaperAppraiseId, exports.paperAppraise_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.PaperAppraise_GetObjByPaperAppraiseId_localStorage = PaperAppraise_GetObjByPaperAppraiseId_localStorage;
    /**
     * 修改在缓存对象列表中的对象, 与后台数据库无关.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
     * @param objPaperAppraise:所给的对象
     * @returns 对象
    */
    async function PaperAppraise_UpdateObjInLst_Cache(objPaperAppraise) {
        const strThisFuncName = "UpdateObjInLst_Cache";
        try {
            const arrPaperAppraiseObjLst_Cache = await PaperAppraise_GetObjLst_Cache();
            const obj = arrPaperAppraiseObjLst_Cache.find(x => x.paperId == objPaperAppraise.paperId);
            if (obj != null) {
                objPaperAppraise.paperAppraiseId = obj.paperAppraiseId;
                (0, clsCommFunc4Web_js_1.ObjectAssign)(obj, objPaperAppraise);
            }
            else {
                arrPaperAppraiseObjLst_Cache.push(objPaperAppraise);
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, exports.paperAppraise_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.PaperAppraise_UpdateObjInLst_Cache = PaperAppraise_UpdateObjInLst_Cache;
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
    async function PaperAppraise_func(strInFldName, strOutFldName, strInValue) {
        //const strThisFuncName = "func";
        if (strInFldName != clsPaperAppraiseEN_js_1.clsPaperAppraiseEN.con_PaperAppraiseId) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsPaperAppraiseEN_js_1.clsPaperAppraiseEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_1.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strInFldName, clsPaperAppraiseEN_js_1.clsPaperAppraiseEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const lngPaperAppraiseId = Number(strInValue);
        if (lngPaperAppraiseId == 0) {
            return "";
        }
        const objPaperAppraise = await PaperAppraise_GetObjByPaperAppraiseId_Cache(lngPaperAppraiseId);
        if (objPaperAppraise == null)
            return "";
        return objPaperAppraise.GetFldValue(strOutFldName).toString();
    }
    exports.PaperAppraise_func = PaperAppraise_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function PaperAppraise_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.paperAppraiseId - b.paperAppraiseId;
    }
    exports.PaperAppraise_SortFun_Defa = PaperAppraise_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function PaperAppraise_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.paperAppraiseContent == b.paperAppraiseContent)
            return a.appraiseScore - b.appraiseScore;
        else
            return a.paperAppraiseContent.localeCompare(b.paperAppraiseContent);
    }
    exports.PaperAppraise_SortFun_Defa_2Fld = PaperAppraise_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function PaperAppraise_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsPaperAppraiseEN_js_1.clsPaperAppraiseEN.con_PaperAppraiseId:
                    return (a, b) => {
                        return a.paperAppraiseId - b.paperAppraiseId;
                    };
                case clsPaperAppraiseEN_js_1.clsPaperAppraiseEN.con_PaperAppraiseContent:
                    return (a, b) => {
                        return a.paperAppraiseContent.localeCompare(b.paperAppraiseContent);
                    };
                case clsPaperAppraiseEN_js_1.clsPaperAppraiseEN.con_AppraiseScore:
                    return (a, b) => {
                        return a.appraiseScore - b.appraiseScore;
                    };
                case clsPaperAppraiseEN_js_1.clsPaperAppraiseEN.con_PaperId:
                    return (a, b) => {
                        return a.paperId.localeCompare(b.paperId);
                    };
                case clsPaperAppraiseEN_js_1.clsPaperAppraiseEN.con_UpdUser:
                    return (a, b) => {
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsPaperAppraiseEN_js_1.clsPaperAppraiseEN.con_UpdDate:
                    return (a, b) => {
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsPaperAppraiseEN_js_1.clsPaperAppraiseEN.con_Memo:
                    return (a, b) => {
                        return a.memo.localeCompare(b.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[PaperAppraise]中不存在！(in ${exports.paperAppraise_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsPaperAppraiseEN_js_1.clsPaperAppraiseEN.con_PaperAppraiseId:
                    return (a, b) => {
                        return b.paperAppraiseId - a.paperAppraiseId;
                    };
                case clsPaperAppraiseEN_js_1.clsPaperAppraiseEN.con_PaperAppraiseContent:
                    return (a, b) => {
                        return b.paperAppraiseContent.localeCompare(a.paperAppraiseContent);
                    };
                case clsPaperAppraiseEN_js_1.clsPaperAppraiseEN.con_AppraiseScore:
                    return (a, b) => {
                        return b.appraiseScore - a.appraiseScore;
                    };
                case clsPaperAppraiseEN_js_1.clsPaperAppraiseEN.con_PaperId:
                    return (a, b) => {
                        return b.paperId.localeCompare(a.paperId);
                    };
                case clsPaperAppraiseEN_js_1.clsPaperAppraiseEN.con_UpdUser:
                    return (a, b) => {
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsPaperAppraiseEN_js_1.clsPaperAppraiseEN.con_UpdDate:
                    return (a, b) => {
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsPaperAppraiseEN_js_1.clsPaperAppraiseEN.con_Memo:
                    return (a, b) => {
                        return b.memo.localeCompare(a.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[PaperAppraise]中不存在！(in ${exports.paperAppraise_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.PaperAppraise_SortFunByKey = PaperAppraise_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function PaperAppraise_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsPaperAppraiseEN_js_1.clsPaperAppraiseEN.con_PaperAppraiseId:
                return (obj) => {
                    return obj.paperAppraiseId === value;
                };
            case clsPaperAppraiseEN_js_1.clsPaperAppraiseEN.con_PaperAppraiseContent:
                return (obj) => {
                    return obj.paperAppraiseContent === value;
                };
            case clsPaperAppraiseEN_js_1.clsPaperAppraiseEN.con_AppraiseScore:
                return (obj) => {
                    return obj.appraiseScore === value;
                };
            case clsPaperAppraiseEN_js_1.clsPaperAppraiseEN.con_PaperId:
                return (obj) => {
                    return obj.paperId === value;
                };
            case clsPaperAppraiseEN_js_1.clsPaperAppraiseEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsPaperAppraiseEN_js_1.clsPaperAppraiseEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsPaperAppraiseEN_js_1.clsPaperAppraiseEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[PaperAppraise]中不存在！(in ${exports.paperAppraise_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.PaperAppraise_FilterFunByKey = PaperAppraise_FilterFunByKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function PaperAppraise_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperAppraise_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperAppraise_GetFirstIDAsync = PaperAppraise_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function PaperAppraise_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperAppraise_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperAppraise_GetFirstID = PaperAppraise_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function PaperAppraise_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperAppraise_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.paperAppraise_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objPaperAppraise = PaperAppraise_GetObjFromJsonObj(returnObj);
                return objPaperAppraise;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperAppraise_GetFirstObjAsync = PaperAppraise_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function PaperAppraise_GetObjLst_ClientCache() {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsPaperAppraiseEN_js_1.clsPaperAppraiseEN._CurrTabName;
        clsPaperAppraiseEN_js_1.clsPaperAppraiseEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsPaperAppraiseEN_js_1.clsPaperAppraiseEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsPaperAppraiseEN_js_1.clsPaperAppraiseEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsPaperAppraiseEN_js_1.clsPaperAppraiseEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_2.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrPaperAppraiseExObjLst_Cache = CacheHelper_js_2.CacheHelper.Get(strKey);
            const arrPaperAppraiseObjLst_T = PaperAppraise_GetObjLstByJSONObjLst(arrPaperAppraiseExObjLst_Cache);
            return arrPaperAppraiseObjLst_T;
        }
        try {
            const arrPaperAppraiseExObjLst = await PaperAppraise_GetObjLstAsync(strWhereCond);
            CacheHelper_js_2.CacheHelper.Add(strKey, arrPaperAppraiseExObjLst);
            const strInfo = (0, clsString_js_1.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrPaperAppraiseExObjLst.length);
            console.log(strInfo);
            return arrPaperAppraiseExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.paperAppraise_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.PaperAppraise_GetObjLst_ClientCache = PaperAppraise_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function PaperAppraise_GetObjLst_localStorage() {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsPaperAppraiseEN_js_1.clsPaperAppraiseEN._CurrTabName;
        clsPaperAppraiseEN_js_1.clsPaperAppraiseEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsPaperAppraiseEN_js_1.clsPaperAppraiseEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsPaperAppraiseEN_js_1.clsPaperAppraiseEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsPaperAppraiseEN_js_1.clsPaperAppraiseEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrPaperAppraiseExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrPaperAppraiseObjLst_T = PaperAppraise_GetObjLstByJSONObjLst(arrPaperAppraiseExObjLst_Cache);
            return arrPaperAppraiseObjLst_T;
        }
        try {
            const arrPaperAppraiseExObjLst = await PaperAppraise_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrPaperAppraiseExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrPaperAppraiseExObjLst.length);
            console.log(strInfo);
            return arrPaperAppraiseExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.paperAppraise_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.PaperAppraise_GetObjLst_localStorage = PaperAppraise_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function PaperAppraise_GetObjLst_localStorage_PureCache() {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsPaperAppraiseEN_js_1.clsPaperAppraiseEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrPaperAppraiseObjLst_Cache = JSON.parse(strTempObjLst);
            return arrPaperAppraiseObjLst_Cache;
        }
        else
            return null;
    }
    exports.PaperAppraise_GetObjLst_localStorage_PureCache = PaperAppraise_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function PaperAppraise_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperAppraise_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.paperAppraise_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = PaperAppraise_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperAppraise_GetObjLstAsync = PaperAppraise_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function PaperAppraise_GetObjLst_sessionStorage() {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsPaperAppraiseEN_js_1.clsPaperAppraiseEN._CurrTabName;
        clsPaperAppraiseEN_js_1.clsPaperAppraiseEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsPaperAppraiseEN_js_1.clsPaperAppraiseEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsPaperAppraiseEN_js_1.clsPaperAppraiseEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsPaperAppraiseEN_js_1.clsPaperAppraiseEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrPaperAppraiseExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrPaperAppraiseObjLst_T = PaperAppraise_GetObjLstByJSONObjLst(arrPaperAppraiseExObjLst_Cache);
            return arrPaperAppraiseObjLst_T;
        }
        try {
            const arrPaperAppraiseExObjLst = await PaperAppraise_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrPaperAppraiseExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrPaperAppraiseExObjLst.length);
            console.log(strInfo);
            return arrPaperAppraiseExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.paperAppraise_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.PaperAppraise_GetObjLst_sessionStorage = PaperAppraise_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function PaperAppraise_GetObjLst_sessionStorage_PureCache() {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsPaperAppraiseEN_js_1.clsPaperAppraiseEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrPaperAppraiseObjLst_Cache = JSON.parse(strTempObjLst);
            return arrPaperAppraiseObjLst_Cache;
        }
        else
            return null;
    }
    exports.PaperAppraise_GetObjLst_sessionStorage_PureCache = PaperAppraise_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function PaperAppraise_GetObjLst_Cache() {
        //const strThisFuncName = "GetObjLst_Cache";
        let arrPaperAppraiseObjLst_Cache;
        switch (clsPaperAppraiseEN_js_1.clsPaperAppraiseEN.CacheModeId) {
            case "04": //sessionStorage
                arrPaperAppraiseObjLst_Cache = await PaperAppraise_GetObjLst_sessionStorage();
                break;
            case "03": //localStorage
                arrPaperAppraiseObjLst_Cache = await PaperAppraise_GetObjLst_localStorage();
                break;
            case "02": //ClientCache
                arrPaperAppraiseObjLst_Cache = await PaperAppraise_GetObjLst_ClientCache();
                break;
            default:
                arrPaperAppraiseObjLst_Cache = await PaperAppraise_GetObjLst_ClientCache();
                break;
        }
        const arrPaperAppraiseObjLst = PaperAppraise_GetObjLstByJSONObjLst(arrPaperAppraiseObjLst_Cache);
        return arrPaperAppraiseObjLst_Cache;
    }
    exports.PaperAppraise_GetObjLst_Cache = PaperAppraise_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function PaperAppraise_GetObjLst_PureCache() {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrPaperAppraiseObjLst_Cache;
        switch (clsPaperAppraiseEN_js_1.clsPaperAppraiseEN.CacheModeId) {
            case "04": //sessionStorage
                arrPaperAppraiseObjLst_Cache = await PaperAppraise_GetObjLst_sessionStorage_PureCache();
                break;
            case "03": //localStorage
                arrPaperAppraiseObjLst_Cache = await PaperAppraise_GetObjLst_localStorage_PureCache();
                break;
            case "02": //ClientCache
                arrPaperAppraiseObjLst_Cache = null;
                break;
            default:
                arrPaperAppraiseObjLst_Cache = null;
                break;
        }
        return arrPaperAppraiseObjLst_Cache;
    }
    exports.PaperAppraise_GetObjLst_PureCache = PaperAppraise_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objlngPaperAppraiseId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function PaperAppraise_GetSubObjLst_Cache(objPaperAppraise_Cond) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrPaperAppraiseObjLst_Cache = await PaperAppraise_GetObjLst_Cache();
        let arrPaperAppraise_Sel = arrPaperAppraiseObjLst_Cache;
        if (objPaperAppraise_Cond.sf_FldComparisonOp == null || objPaperAppraise_Cond.sf_FldComparisonOp == "")
            return arrPaperAppraise_Sel;
        const dicFldComparisonOp = JSON.parse(objPaperAppraise_Cond.sf_FldComparisonOp);
        //console.log("clsPaperAppraiseWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objPaperAppraise_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrPaperAppraise_Sel = arrPaperAppraise_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objPaperAppraise_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrPaperAppraise_Sel = arrPaperAppraise_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrPaperAppraise_Sel = arrPaperAppraise_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrPaperAppraise_Sel = arrPaperAppraise_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrPaperAppraise_Sel = arrPaperAppraise_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrPaperAppraise_Sel = arrPaperAppraise_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrPaperAppraise_Sel = arrPaperAppraise_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrPaperAppraise_Sel = arrPaperAppraise_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrPaperAppraise_Sel = arrPaperAppraise_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrPaperAppraise_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objPaperAppraise_Cond), exports.paperAppraise_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.PaperAppraise_GetSubObjLst_Cache = PaperAppraise_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrPaperAppraiseId:关键字列表
    * @returns 对象列表
    **/
    async function PaperAppraise_GetObjLstByPaperAppraiseIdLstAsync(arrPaperAppraiseId) {
        const strThisFuncName = "GetObjLstByPaperAppraiseIdLstAsync";
        const strAction = "GetObjLstByPaperAppraiseIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperAppraise_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrPaperAppraiseId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.paperAppraise_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = PaperAppraise_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperAppraise_GetObjLstByPaperAppraiseIdLstAsync = PaperAppraise_GetObjLstByPaperAppraiseIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrlngPaperAppraiseIdLst:关键字列表
     * @returns 对象列表
    */
    async function PaperAppraise_GetObjLstByPaperAppraiseIdLst_Cache(arrPaperAppraiseIdLst) {
        const strThisFuncName = "GetObjLstByPaperAppraiseIdLst_Cache";
        try {
            const arrPaperAppraiseObjLst_Cache = await PaperAppraise_GetObjLst_Cache();
            const arrPaperAppraise_Sel = arrPaperAppraiseObjLst_Cache.filter(x => arrPaperAppraiseIdLst.indexOf(x.paperAppraiseId) > -1);
            return arrPaperAppraise_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrPaperAppraiseIdLst.join(","), exports.paperAppraise_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.PaperAppraise_GetObjLstByPaperAppraiseIdLst_Cache = PaperAppraise_GetObjLstByPaperAppraiseIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function PaperAppraise_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperAppraise_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.paperAppraise_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = PaperAppraise_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperAppraise_GetTopObjLstAsync = PaperAppraise_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function PaperAppraise_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperAppraise_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.paperAppraise_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = PaperAppraise_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperAppraise_GetObjLstByRangeAsync = PaperAppraise_GetObjLstByRangeAsync;
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
    async function PaperAppraise_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperAppraise_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperAppraise_GetObjLstByRange = PaperAppraise_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function PaperAppraise_GetObjLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const arrPaperAppraiseObjLst_Cache = await PaperAppraise_GetObjLst_Cache();
        if (arrPaperAppraiseObjLst_Cache.length == 0)
            return arrPaperAppraiseObjLst_Cache;
        let arrPaperAppraise_Sel = arrPaperAppraiseObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objPaperAppraise_Cond = new clsPaperAppraiseEN_js_1.clsPaperAppraiseEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objPaperAppraise_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsPaperAppraiseWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrPaperAppraise_Sel = arrPaperAppraise_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objPaperAppraise_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrPaperAppraise_Sel = arrPaperAppraise_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrPaperAppraise_Sel = arrPaperAppraise_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrPaperAppraise_Sel = arrPaperAppraise_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrPaperAppraise_Sel = arrPaperAppraise_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrPaperAppraise_Sel = arrPaperAppraise_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrPaperAppraise_Sel = arrPaperAppraise_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrPaperAppraise_Sel = arrPaperAppraise_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrPaperAppraise_Sel = arrPaperAppraise_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrPaperAppraise_Sel = arrPaperAppraise_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrPaperAppraise_Sel.length == 0)
                return arrPaperAppraise_Sel;
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
                arrPaperAppraise_Sel = arrPaperAppraise_Sel.sort(PaperAppraise_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrPaperAppraise_Sel = arrPaperAppraise_Sel.sort(objPagerPara.sortFun);
            }
            arrPaperAppraise_Sel = arrPaperAppraise_Sel.slice(intStart, intEnd);
            return arrPaperAppraise_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.paperAppraise_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.PaperAppraise_GetObjLstByPager_Cache = PaperAppraise_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function PaperAppraise_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperAppraise_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.paperAppraise_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = PaperAppraise_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperAppraise_GetObjLstByPagerAsync = PaperAppraise_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param lngPaperAppraiseId:关键字
    * @returns 获取删除的结果
    **/
    async function PaperAppraise_DelRecordAsync(lngPaperAppraiseId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperAppraise_Controller, strAction);
        strUrl = (0, clsString_js_1.Format)("{0}/?Id={1}", strUrl, lngPaperAppraiseId);
        try {
            const response = await axios_1.default.delete(strUrl, {
                params: { "Id": lngPaperAppraiseId, }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperAppraise_DelRecordAsync = PaperAppraise_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrPaperAppraiseId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function PaperAppraise_DelPaperAppraisesAsync(arrPaperAppraiseId) {
        const strThisFuncName = "DelPaperAppraisesAsync";
        const strAction = "DelPaperAppraises";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperAppraise_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrPaperAppraiseId);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperAppraise_DelPaperAppraisesAsync = PaperAppraise_DelPaperAppraisesAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function PaperAppraise_DelPaperAppraisesByCondAsync(strWhereCond) {
        const strThisFuncName = "DelPaperAppraisesByCondAsync";
        const strAction = "DelPaperAppraisesByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperAppraise_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperAppraise_DelPaperAppraisesByCondAsync = PaperAppraise_DelPaperAppraisesByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objPaperAppraiseEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function PaperAppraise_AddNewRecordAsync(objPaperAppraiseEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objPaperAppraiseEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperAppraise_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPaperAppraiseEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperAppraise_AddNewRecordAsync = PaperAppraise_AddNewRecordAsync;
    /* 数据类型不是字符型，不可以最大关键字的方式添加记录。*/
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objPaperAppraiseEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function PaperAppraise_AddNewRecordWithReturnKeyAsync(objPaperAppraiseEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperAppraise_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPaperAppraiseEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperAppraise_AddNewRecordWithReturnKeyAsync = PaperAppraise_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objPaperAppraiseEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function PaperAppraise_AddNewRecordWithReturnKey(objPaperAppraiseEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objPaperAppraiseEN.paperAppraiseId === null || objPaperAppraiseEN.paperAppraiseId === 0) {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperAppraise_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPaperAppraiseEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperAppraise_AddNewRecordWithReturnKey = PaperAppraise_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objPaperAppraiseEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function PaperAppraise_UpdateRecordAsync(objPaperAppraiseEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objPaperAppraiseEN.sf_UpdFldSetStr === undefined || objPaperAppraiseEN.sf_UpdFldSetStr === null || objPaperAppraiseEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objPaperAppraiseEN.paperAppraiseId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperAppraise_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPaperAppraiseEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperAppraise_UpdateRecordAsync = PaperAppraise_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objPaperAppraiseEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function PaperAppraise_UpdateWithConditionAsync(objPaperAppraiseEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objPaperAppraiseEN.sf_UpdFldSetStr === undefined || objPaperAppraiseEN.sf_UpdFldSetStr === null || objPaperAppraiseEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objPaperAppraiseEN.paperAppraiseId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperAppraise_Controller, strAction);
        objPaperAppraiseEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objPaperAppraiseEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperAppraise_UpdateWithConditionAsync = PaperAppraise_UpdateWithConditionAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objlngPaperAppraiseId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function PaperAppraise_IsExistRecord_Cache(objPaperAppraise_Cond) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrPaperAppraiseObjLst_Cache = await PaperAppraise_GetObjLst_Cache();
        if (arrPaperAppraiseObjLst_Cache == null)
            return false;
        let arrPaperAppraise_Sel = arrPaperAppraiseObjLst_Cache;
        if (objPaperAppraise_Cond.sf_FldComparisonOp == null || objPaperAppraise_Cond.sf_FldComparisonOp == "")
            return arrPaperAppraise_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objPaperAppraise_Cond.sf_FldComparisonOp);
        //console.log("clsPaperAppraiseWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objPaperAppraise_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objPaperAppraise_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrPaperAppraise_Sel = arrPaperAppraise_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrPaperAppraise_Sel = arrPaperAppraise_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrPaperAppraise_Sel = arrPaperAppraise_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrPaperAppraise_Sel = arrPaperAppraise_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrPaperAppraise_Sel = arrPaperAppraise_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrPaperAppraise_Sel = arrPaperAppraise_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrPaperAppraise_Sel = arrPaperAppraise_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrPaperAppraise_Sel = arrPaperAppraise_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrPaperAppraise_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objPaperAppraise_Cond), exports.paperAppraise_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.PaperAppraise_IsExistRecord_Cache = PaperAppraise_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function PaperAppraise_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperAppraise_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperAppraise_IsExistRecordAsync = PaperAppraise_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param lngPaperAppraiseId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function PaperAppraise_IsExist(lngPaperAppraiseId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperAppraise_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "PaperAppraiseId": lngPaperAppraiseId,
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperAppraise_IsExist = PaperAppraise_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param lngPaperAppraiseId:所给的关键字
     * @returns 对象
    */
    async function PaperAppraise_IsExist_Cache(lngPaperAppraiseId) {
        const strThisFuncName = "IsExist_Cache";
        const arrPaperAppraiseObjLst_Cache = await PaperAppraise_GetObjLst_Cache();
        if (arrPaperAppraiseObjLst_Cache == null)
            return false;
        try {
            const arrPaperAppraise_Sel = arrPaperAppraiseObjLst_Cache.filter(x => x.paperAppraiseId == lngPaperAppraiseId);
            if (arrPaperAppraise_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", lngPaperAppraiseId, exports.paperAppraise_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.PaperAppraise_IsExist_Cache = PaperAppraise_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param lngPaperAppraiseId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function PaperAppraise_IsExistAsync(lngPaperAppraiseId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperAppraise_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "lngPaperAppraiseId": lngPaperAppraiseId }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperAppraise_IsExistAsync = PaperAppraise_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function PaperAppraise_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperAppraise_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperAppraise_GetRecCountByCondAsync = PaperAppraise_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objPaperAppraise_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function PaperAppraise_GetRecCountByCond_Cache(objPaperAppraise_Cond) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrPaperAppraiseObjLst_Cache = await PaperAppraise_GetObjLst_Cache();
        if (arrPaperAppraiseObjLst_Cache == null)
            return 0;
        let arrPaperAppraise_Sel = arrPaperAppraiseObjLst_Cache;
        if (objPaperAppraise_Cond.sf_FldComparisonOp == null || objPaperAppraise_Cond.sf_FldComparisonOp == "")
            return arrPaperAppraise_Sel.length;
        const dicFldComparisonOp = JSON.parse(objPaperAppraise_Cond.sf_FldComparisonOp);
        //console.log("clsPaperAppraiseWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objPaperAppraise_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrPaperAppraise_Sel = arrPaperAppraise_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objPaperAppraise_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrPaperAppraise_Sel = arrPaperAppraise_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrPaperAppraise_Sel = arrPaperAppraise_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrPaperAppraise_Sel = arrPaperAppraise_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrPaperAppraise_Sel = arrPaperAppraise_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrPaperAppraise_Sel = arrPaperAppraise_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrPaperAppraise_Sel = arrPaperAppraise_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrPaperAppraise_Sel = arrPaperAppraise_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrPaperAppraise_Sel = arrPaperAppraise_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrPaperAppraise_Sel = arrPaperAppraise_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrPaperAppraise_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objPaperAppraise_Cond), exports.paperAppraise_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.PaperAppraise_GetRecCountByCond_Cache = PaperAppraise_GetRecCountByCond_Cache;
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
    async function PaperAppraise_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperAppraise_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperAppraise_GetMaxStrIdByPrefix = PaperAppraise_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function PaperAppraise_GetWebApiUrl(strController, strAction) {
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
    exports.PaperAppraise_GetWebApiUrl = PaperAppraise_GetWebApiUrl;
    /**
    * 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshCache)
    **/
    function PaperAppraise_ReFreshCache() {
        const strThisFuncName = "ReFreshCache";
        const strMsg = (0, clsString_js_1.Format)("刷新缓存成功！");
        console.trace(strMsg);
        // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
        const strKey = clsPaperAppraiseEN_js_1.clsPaperAppraiseEN._CurrTabName;
        switch (clsPaperAppraiseEN_js_1.clsPaperAppraiseEN.CacheModeId) {
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
    exports.PaperAppraise_ReFreshCache = PaperAppraise_ReFreshCache;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function PaperAppraise_ReFreshThisCache() {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = clsPaperAppraiseEN_js_1.clsPaperAppraiseEN._CurrTabName;
            switch (clsPaperAppraiseEN_js_1.clsPaperAppraiseEN.CacheModeId) {
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
    exports.PaperAppraise_ReFreshThisCache = PaperAppraise_ReFreshThisCache;
    /* 该表的下拉框功能没有设置，不需要生成下拉框绑定函数。*/
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function PaperAppraise_CheckPropertyNew(pobjPaperAppraiseEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperAppraiseEN.paperAppraiseContent) == false && (0, clsString_js_1.GetStrLen)(pobjPaperAppraiseEN.paperAppraiseContent) > 2000) {
            throw new Error("(errid:Watl000059)字段[论文评论内容(paperAppraiseContent)]的长度不能超过2000(In 论文评论表(PaperAppraise))!值:$(pobjPaperAppraiseEN.paperAppraiseContent)(clsPaperAppraiseBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperAppraiseEN.paperId) == false && (0, clsString_js_1.GetStrLen)(pobjPaperAppraiseEN.paperId) > 8) {
            throw new Error("(errid:Watl000059)字段[论文Id(paperId)]的长度不能超过8(In 论文评论表(PaperAppraise))!值:$(pobjPaperAppraiseEN.paperId)(clsPaperAppraiseBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperAppraiseEN.updUser) == false && (0, clsString_js_1.GetStrLen)(pobjPaperAppraiseEN.updUser) > 20) {
            throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 论文评论表(PaperAppraise))!值:$(pobjPaperAppraiseEN.updUser)(clsPaperAppraiseBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperAppraiseEN.updDate) == false && (0, clsString_js_1.GetStrLen)(pobjPaperAppraiseEN.updDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 论文评论表(PaperAppraise))!值:$(pobjPaperAppraiseEN.updDate)(clsPaperAppraiseBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperAppraiseEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjPaperAppraiseEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 论文评论表(PaperAppraise))!值:$(pobjPaperAppraiseEN.memo)(clsPaperAppraiseBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if (null != pobjPaperAppraiseEN.paperAppraiseId && undefined !== pobjPaperAppraiseEN.paperAppraiseId && jsString_js_1.tzDataType.isNumber(pobjPaperAppraiseEN.paperAppraiseId) === false) {
            throw new Error("(errid:Watl000060)字段[论文评论Id(paperAppraiseId)]的值:[$(pobjPaperAppraiseEN.paperAppraiseId)], 非法，应该为数值型(In 论文评论表(PaperAppraise))!(clsPaperAppraiseBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperAppraiseEN.paperAppraiseContent) == false && undefined !== pobjPaperAppraiseEN.paperAppraiseContent && jsString_js_1.tzDataType.isString(pobjPaperAppraiseEN.paperAppraiseContent) === false) {
            throw new Error("(errid:Watl000060)字段[论文评论内容(paperAppraiseContent)]的值:[$(pobjPaperAppraiseEN.paperAppraiseContent)], 非法，应该为字符型(In 论文评论表(PaperAppraise))!(clsPaperAppraiseBL:CheckPropertyNew)");
        }
        if (null != pobjPaperAppraiseEN.appraiseScore && undefined !== pobjPaperAppraiseEN.appraiseScore && jsString_js_1.tzDataType.isNumber(pobjPaperAppraiseEN.appraiseScore) === false) {
            throw new Error("(errid:Watl000060)字段[打分(appraiseScore)]的值:[$(pobjPaperAppraiseEN.appraiseScore)], 非法，应该为数值型(In 论文评论表(PaperAppraise))!(clsPaperAppraiseBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperAppraiseEN.paperId) == false && undefined !== pobjPaperAppraiseEN.paperId && jsString_js_1.tzDataType.isString(pobjPaperAppraiseEN.paperId) === false) {
            throw new Error("(errid:Watl000060)字段[论文Id(paperId)]的值:[$(pobjPaperAppraiseEN.paperId)], 非法，应该为字符型(In 论文评论表(PaperAppraise))!(clsPaperAppraiseBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperAppraiseEN.updUser) == false && undefined !== pobjPaperAppraiseEN.updUser && jsString_js_1.tzDataType.isString(pobjPaperAppraiseEN.updUser) === false) {
            throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjPaperAppraiseEN.updUser)], 非法，应该为字符型(In 论文评论表(PaperAppraise))!(clsPaperAppraiseBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperAppraiseEN.updDate) == false && undefined !== pobjPaperAppraiseEN.updDate && jsString_js_1.tzDataType.isString(pobjPaperAppraiseEN.updDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjPaperAppraiseEN.updDate)], 非法，应该为字符型(In 论文评论表(PaperAppraise))!(clsPaperAppraiseBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperAppraiseEN.memo) == false && undefined !== pobjPaperAppraiseEN.memo && jsString_js_1.tzDataType.isString(pobjPaperAppraiseEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjPaperAppraiseEN.memo)], 非法，应该为字符型(In 论文评论表(PaperAppraise))!(clsPaperAppraiseBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjPaperAppraiseEN.SetIsCheckProperty(true);
    }
    exports.PaperAppraise_CheckPropertyNew = PaperAppraise_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function PaperAppraise_CheckProperty4Update(pobjPaperAppraiseEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperAppraiseEN.paperAppraiseContent) == false && (0, clsString_js_1.GetStrLen)(pobjPaperAppraiseEN.paperAppraiseContent) > 2000) {
            throw new Error("(errid:Watl000062)字段[论文评论内容(paperAppraiseContent)]的长度不能超过2000(In 论文评论表(PaperAppraise))!值:$(pobjPaperAppraiseEN.paperAppraiseContent)(clsPaperAppraiseBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperAppraiseEN.paperId) == false && (0, clsString_js_1.GetStrLen)(pobjPaperAppraiseEN.paperId) > 8) {
            throw new Error("(errid:Watl000062)字段[论文Id(paperId)]的长度不能超过8(In 论文评论表(PaperAppraise))!值:$(pobjPaperAppraiseEN.paperId)(clsPaperAppraiseBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperAppraiseEN.updUser) == false && (0, clsString_js_1.GetStrLen)(pobjPaperAppraiseEN.updUser) > 20) {
            throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 论文评论表(PaperAppraise))!值:$(pobjPaperAppraiseEN.updUser)(clsPaperAppraiseBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperAppraiseEN.updDate) == false && (0, clsString_js_1.GetStrLen)(pobjPaperAppraiseEN.updDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 论文评论表(PaperAppraise))!值:$(pobjPaperAppraiseEN.updDate)(clsPaperAppraiseBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperAppraiseEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjPaperAppraiseEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 论文评论表(PaperAppraise))!值:$(pobjPaperAppraiseEN.memo)(clsPaperAppraiseBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if (null != pobjPaperAppraiseEN.paperAppraiseId && undefined !== pobjPaperAppraiseEN.paperAppraiseId && jsString_js_1.tzDataType.isNumber(pobjPaperAppraiseEN.paperAppraiseId) === false) {
            throw new Error("(errid:Watl000063)字段[论文评论Id(paperAppraiseId)]的值:[$(pobjPaperAppraiseEN.paperAppraiseId)], 非法，应该为数值型(In 论文评论表(PaperAppraise))!(clsPaperAppraiseBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperAppraiseEN.paperAppraiseContent) == false && undefined !== pobjPaperAppraiseEN.paperAppraiseContent && jsString_js_1.tzDataType.isString(pobjPaperAppraiseEN.paperAppraiseContent) === false) {
            throw new Error("(errid:Watl000063)字段[论文评论内容(paperAppraiseContent)]的值:[$(pobjPaperAppraiseEN.paperAppraiseContent)], 非法，应该为字符型(In 论文评论表(PaperAppraise))!(clsPaperAppraiseBL:CheckProperty4Update)");
        }
        if (null != pobjPaperAppraiseEN.appraiseScore && undefined !== pobjPaperAppraiseEN.appraiseScore && jsString_js_1.tzDataType.isNumber(pobjPaperAppraiseEN.appraiseScore) === false) {
            throw new Error("(errid:Watl000063)字段[打分(appraiseScore)]的值:[$(pobjPaperAppraiseEN.appraiseScore)], 非法，应该为数值型(In 论文评论表(PaperAppraise))!(clsPaperAppraiseBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperAppraiseEN.paperId) == false && undefined !== pobjPaperAppraiseEN.paperId && jsString_js_1.tzDataType.isString(pobjPaperAppraiseEN.paperId) === false) {
            throw new Error("(errid:Watl000063)字段[论文Id(paperId)]的值:[$(pobjPaperAppraiseEN.paperId)], 非法，应该为字符型(In 论文评论表(PaperAppraise))!(clsPaperAppraiseBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperAppraiseEN.updUser) == false && undefined !== pobjPaperAppraiseEN.updUser && jsString_js_1.tzDataType.isString(pobjPaperAppraiseEN.updUser) === false) {
            throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjPaperAppraiseEN.updUser)], 非法，应该为字符型(In 论文评论表(PaperAppraise))!(clsPaperAppraiseBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperAppraiseEN.updDate) == false && undefined !== pobjPaperAppraiseEN.updDate && jsString_js_1.tzDataType.isString(pobjPaperAppraiseEN.updDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjPaperAppraiseEN.updDate)], 非法，应该为字符型(In 论文评论表(PaperAppraise))!(clsPaperAppraiseBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperAppraiseEN.memo) == false && undefined !== pobjPaperAppraiseEN.memo && jsString_js_1.tzDataType.isString(pobjPaperAppraiseEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjPaperAppraiseEN.memo)], 非法，应该为字符型(In 论文评论表(PaperAppraise))!(clsPaperAppraiseBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if (null === pobjPaperAppraiseEN.paperAppraiseId
            || pobjPaperAppraiseEN.paperAppraiseId != null && pobjPaperAppraiseEN.paperAppraiseId.toString() === "") {
            throw new Error("(errid:Watl000064)字段[论文评论Id]不能为空(In 论文评论表)!(clsPaperAppraiseBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjPaperAppraiseEN.SetIsCheckProperty(true);
    }
    exports.PaperAppraise_CheckProperty4Update = PaperAppraise_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function PaperAppraise_GetJSONStrByObj(pobjPaperAppraiseEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjPaperAppraiseEN.sf_UpdFldSetStr = pobjPaperAppraiseEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjPaperAppraiseEN);
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
    exports.PaperAppraise_GetJSONStrByObj = PaperAppraise_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function PaperAppraise_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrPaperAppraiseObjLst = new Array();
        if (strJSON === "") {
            return arrPaperAppraiseObjLst;
        }
        try {
            arrPaperAppraiseObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrPaperAppraiseObjLst;
        }
        return arrPaperAppraiseObjLst;
    }
    exports.PaperAppraise_GetObjLstByJSONStr = PaperAppraise_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrPaperAppraiseObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function PaperAppraise_GetObjLstByJSONObjLst(arrPaperAppraiseObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrPaperAppraiseObjLst = new Array();
        for (const objInFor of arrPaperAppraiseObjLstS) {
            const obj1 = PaperAppraise_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrPaperAppraiseObjLst.push(obj1);
        }
        return arrPaperAppraiseObjLst;
    }
    exports.PaperAppraise_GetObjLstByJSONObjLst = PaperAppraise_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function PaperAppraise_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjPaperAppraiseEN = new clsPaperAppraiseEN_js_1.clsPaperAppraiseEN();
        if (strJSON === "") {
            return pobjPaperAppraiseEN;
        }
        try {
            pobjPaperAppraiseEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjPaperAppraiseEN;
        }
        return pobjPaperAppraiseEN;
    }
    exports.PaperAppraise_GetObjByJSONStr = PaperAppraise_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function PaperAppraise_GetCombineCondition(objPaperAppraise_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objPaperAppraise_Cond.dicFldComparisonOp, clsPaperAppraiseEN_js_1.clsPaperAppraiseEN.con_PaperAppraiseId) == true) {
            const strComparisonOp_PaperAppraiseId = objPaperAppraise_Cond.dicFldComparisonOp[clsPaperAppraiseEN_js_1.clsPaperAppraiseEN.con_PaperAppraiseId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsPaperAppraiseEN_js_1.clsPaperAppraiseEN.con_PaperAppraiseId, objPaperAppraise_Cond.paperAppraiseId, strComparisonOp_PaperAppraiseId);
        }
        if (Object.prototype.hasOwnProperty.call(objPaperAppraise_Cond.dicFldComparisonOp, clsPaperAppraiseEN_js_1.clsPaperAppraiseEN.con_PaperAppraiseContent) == true) {
            const strComparisonOp_PaperAppraiseContent = objPaperAppraise_Cond.dicFldComparisonOp[clsPaperAppraiseEN_js_1.clsPaperAppraiseEN.con_PaperAppraiseContent];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsPaperAppraiseEN_js_1.clsPaperAppraiseEN.con_PaperAppraiseContent, objPaperAppraise_Cond.paperAppraiseContent, strComparisonOp_PaperAppraiseContent);
        }
        if (Object.prototype.hasOwnProperty.call(objPaperAppraise_Cond.dicFldComparisonOp, clsPaperAppraiseEN_js_1.clsPaperAppraiseEN.con_AppraiseScore) == true) {
            const strComparisonOp_AppraiseScore = objPaperAppraise_Cond.dicFldComparisonOp[clsPaperAppraiseEN_js_1.clsPaperAppraiseEN.con_AppraiseScore];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsPaperAppraiseEN_js_1.clsPaperAppraiseEN.con_AppraiseScore, objPaperAppraise_Cond.appraiseScore, strComparisonOp_AppraiseScore);
        }
        if (Object.prototype.hasOwnProperty.call(objPaperAppraise_Cond.dicFldComparisonOp, clsPaperAppraiseEN_js_1.clsPaperAppraiseEN.con_PaperId) == true) {
            const strComparisonOp_PaperId = objPaperAppraise_Cond.dicFldComparisonOp[clsPaperAppraiseEN_js_1.clsPaperAppraiseEN.con_PaperId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsPaperAppraiseEN_js_1.clsPaperAppraiseEN.con_PaperId, objPaperAppraise_Cond.paperId, strComparisonOp_PaperId);
        }
        if (Object.prototype.hasOwnProperty.call(objPaperAppraise_Cond.dicFldComparisonOp, clsPaperAppraiseEN_js_1.clsPaperAppraiseEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objPaperAppraise_Cond.dicFldComparisonOp[clsPaperAppraiseEN_js_1.clsPaperAppraiseEN.con_UpdUser];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsPaperAppraiseEN_js_1.clsPaperAppraiseEN.con_UpdUser, objPaperAppraise_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objPaperAppraise_Cond.dicFldComparisonOp, clsPaperAppraiseEN_js_1.clsPaperAppraiseEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objPaperAppraise_Cond.dicFldComparisonOp[clsPaperAppraiseEN_js_1.clsPaperAppraiseEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsPaperAppraiseEN_js_1.clsPaperAppraiseEN.con_UpdDate, objPaperAppraise_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objPaperAppraise_Cond.dicFldComparisonOp, clsPaperAppraiseEN_js_1.clsPaperAppraiseEN.con_Memo) == true) {
            const strComparisonOp_Memo = objPaperAppraise_Cond.dicFldComparisonOp[clsPaperAppraiseEN_js_1.clsPaperAppraiseEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsPaperAppraiseEN_js_1.clsPaperAppraiseEN.con_Memo, objPaperAppraise_Cond.memo, strComparisonOp_Memo);
        }
        return strWhereCond;
    }
    exports.PaperAppraise_GetCombineCondition = PaperAppraise_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--PaperAppraise(论文评论表),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param strPaperId: 论文Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function PaperAppraise_GetUniCondStr_PaperId(objPaperAppraiseEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and PaperId = '{0}'", objPaperAppraiseEN.paperId);
        return strWhereCond;
    }
    exports.PaperAppraise_GetUniCondStr_PaperId = PaperAppraise_GetUniCondStr_PaperId;
    /**
    *获取唯一性条件串(Uniqueness)--PaperAppraise(论文评论表),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param strPaperId: 论文Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function PaperAppraise_GetUniCondStr4Update_PaperId(objPaperAppraiseEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and PaperAppraiseId <> '{0}'", objPaperAppraiseEN.paperAppraiseId);
        strWhereCond += (0, clsString_js_1.Format)(" and PaperId = '{0}'", objPaperAppraiseEN.paperId);
        return strWhereCond;
    }
    exports.PaperAppraise_GetUniCondStr4Update_PaperId = PaperAppraise_GetUniCondStr4Update_PaperId;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objPaperAppraiseENS:源对象
     * @param objPaperAppraiseENT:目标对象
    */
    function PaperAppraise_CopyObjTo(objPaperAppraiseENS, objPaperAppraiseENT) {
        objPaperAppraiseENT.paperAppraiseId = objPaperAppraiseENS.paperAppraiseId; //论文评论Id
        objPaperAppraiseENT.paperAppraiseContent = objPaperAppraiseENS.paperAppraiseContent; //论文评论内容
        objPaperAppraiseENT.appraiseScore = objPaperAppraiseENS.appraiseScore; //打分
        objPaperAppraiseENT.paperId = objPaperAppraiseENS.paperId; //论文Id
        objPaperAppraiseENT.updUser = objPaperAppraiseENS.updUser; //修改人
        objPaperAppraiseENT.updDate = objPaperAppraiseENS.updDate; //修改日期
        objPaperAppraiseENT.memo = objPaperAppraiseENS.memo; //备注
        objPaperAppraiseENT.sf_UpdFldSetStr = objPaperAppraiseENS.updFldString; //sf_UpdFldSetStr
    }
    exports.PaperAppraise_CopyObjTo = PaperAppraise_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objPaperAppraiseENS:源对象
     * @param objPaperAppraiseENT:目标对象
    */
    function PaperAppraise_GetObjFromJsonObj(objPaperAppraiseENS) {
        const objPaperAppraiseENT = new clsPaperAppraiseEN_js_1.clsPaperAppraiseEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objPaperAppraiseENT, objPaperAppraiseENS);
        return objPaperAppraiseENT;
    }
    exports.PaperAppraise_GetObjFromJsonObj = PaperAppraise_GetObjFromJsonObj;
});
