/**
* 类名:clsViewpointAppraiseWApi
* 表名:ViewpointAppraise(01120599)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/13 00:50:15
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
        define(["require", "exports", "axios", "../../PubFun/enumComparisonOp.js", "../../PubFun/CacheHelper.js", "../../L0_Entity/GraduateEduPaper/clsViewpointAppraiseEN.js", "../../L3_ForWApi/GraduateEduPaper/clsvViewpointAppraiseWApi.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.ViewpointAppraise_GetObjFromJsonObj = exports.ViewpointAppraise_CopyObjTo = exports.ViewpointAppraise_GetUniCondStr4Update_ViewpointAppraiseId_ViewpointId = exports.ViewpointAppraise_GetUniCondStr_ViewpointAppraiseId_ViewpointId = exports.ViewpointAppraise_GetCombineCondition = exports.ViewpointAppraise_GetObjByJSONStr = exports.ViewpointAppraise_GetObjLstByJSONObjLst = exports.ViewpointAppraise_GetObjLstByJSONStr = exports.ViewpointAppraise_GetJSONStrByObj = exports.ViewpointAppraise_CheckProperty4Update = exports.ViewpointAppraise_CheckPropertyNew = exports.ViewpointAppraise_ReFreshThisCache = exports.ViewpointAppraise_ReFreshCache = exports.ViewpointAppraise_GetWebApiUrl = exports.ViewpointAppraise_GetMaxStrIdByPrefix = exports.ViewpointAppraise_GetRecCountByCond_Cache = exports.ViewpointAppraise_GetRecCountByCondAsync = exports.ViewpointAppraise_IsExistAsync = exports.ViewpointAppraise_IsExist_Cache = exports.ViewpointAppraise_IsExist = exports.ViewpointAppraise_IsExistRecordAsync = exports.ViewpointAppraise_IsExistRecord_Cache = exports.ViewpointAppraise_UpdateWithConditionAsync = exports.ViewpointAppraise_UpdateRecordAsync = exports.ViewpointAppraise_AddNewRecordWithReturnKey = exports.ViewpointAppraise_AddNewRecordWithReturnKeyAsync = exports.ViewpointAppraise_AddNewRecordAsync = exports.ViewpointAppraise_DelViewpointAppraisesByCondAsync = exports.ViewpointAppraise_DelViewpointAppraisesAsync = exports.ViewpointAppraise_DelRecordAsync = exports.ViewpointAppraise_GetObjLstByPagerAsync = exports.ViewpointAppraise_GetObjLstByPager_Cache = exports.ViewpointAppraise_GetObjLstByRange = exports.ViewpointAppraise_GetObjLstByRangeAsync = exports.ViewpointAppraise_GetTopObjLstAsync = exports.ViewpointAppraise_GetObjLstByViewpointAppraiseIdLst_Cache = exports.ViewpointAppraise_GetObjLstByViewpointAppraiseIdLstAsync = exports.ViewpointAppraise_GetSubObjLst_Cache = exports.ViewpointAppraise_GetObjLst_PureCache = exports.ViewpointAppraise_GetObjLst_Cache = exports.ViewpointAppraise_GetObjLst_sessionStorage_PureCache = exports.ViewpointAppraise_GetObjLst_sessionStorage = exports.ViewpointAppraise_GetObjLstAsync = exports.ViewpointAppraise_GetObjLst_localStorage_PureCache = exports.ViewpointAppraise_GetObjLst_localStorage = exports.ViewpointAppraise_GetObjLst_ClientCache = exports.ViewpointAppraise_GetFirstObjAsync = exports.ViewpointAppraise_GetFirstID = exports.ViewpointAppraise_GetFirstIDAsync = exports.ViewpointAppraise_funcKey = exports.ViewpointAppraise_FilterFunByKey = exports.ViewpointAppraise_SortFunByKey = exports.ViewpointAppraise_SortFun_Defa_2Fld = exports.ViewpointAppraise_SortFun_Defa = exports.ViewpointAppraise_func = exports.ViewpointAppraise_UpdateObjInLst_Cache = exports.ViewpointAppraise_GetObjByViewpointAppraiseId_localStorage = exports.ViewpointAppraise_GetObjByViewpointAppraiseId_Cache = exports.ViewpointAppraise_GetObjByViewpointAppraiseIdAsync = exports.viewpointAppraise_ConstructorName = exports.viewpointAppraise_Controller = void 0;
    /**
     * 观点评论表(ViewpointAppraise)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月13日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const enumComparisonOp_js_1 = require("../../PubFun/enumComparisonOp.js");
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsViewpointAppraiseEN_js_1 = require("../../L0_Entity/GraduateEduPaper/clsViewpointAppraiseEN.js");
    const clsvViewpointAppraiseWApi_js_1 = require("../../L3_ForWApi/GraduateEduPaper/clsvViewpointAppraiseWApi.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsString_js_2 = require("../../PubFun/clsString.js");
    exports.viewpointAppraise_Controller = "ViewpointAppraiseApi";
    exports.viewpointAppraise_ConstructorName = "viewpointAppraise";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param lngViewpointAppraiseId:关键字
    * @returns 对象
    **/
    async function ViewpointAppraise_GetObjByViewpointAppraiseIdAsync(lngViewpointAppraiseId) {
        const strThisFuncName = "GetObjByViewpointAppraiseIdAsync";
        if (lngViewpointAppraiseId == 0) {
            const strMsg = (0, clsString_js_2.Format)("参数:[lngViewpointAppraiseId]不能为空！(In clsViewpointAppraiseWApi.GetObjByViewpointAppraiseIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByViewpointAppraiseId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointAppraise_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "lngViewpointAppraiseId": lngViewpointAppraiseId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    return null;
                }
                //console.log(returnObj);
                const objViewpointAppraise = ViewpointAppraise_GetObjFromJsonObj(returnObj);
                return objViewpointAppraise;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointAppraise_GetObjByViewpointAppraiseIdAsync = ViewpointAppraise_GetObjByViewpointAppraiseIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param lngViewpointAppraiseId:所给的关键字
     * @returns 对象
    */
    async function ViewpointAppraise_GetObjByViewpointAppraiseId_Cache(lngViewpointAppraiseId, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByViewpointAppraiseId_Cache";
        if (lngViewpointAppraiseId == 0) {
            const strMsg = (0, clsString_js_2.Format)("参数:[lngViewpointAppraiseId]不能为空！(In clsViewpointAppraiseWApi.GetObjByViewpointAppraiseId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        const arrViewpointAppraiseObjLst_Cache = await ViewpointAppraise_GetObjLst_Cache();
        try {
            const arrViewpointAppraise_Sel = arrViewpointAppraiseObjLst_Cache.filter(x => x.viewpointAppraiseId == lngViewpointAppraiseId);
            let objViewpointAppraise;
            if (arrViewpointAppraise_Sel.length > 0) {
                objViewpointAppraise = arrViewpointAppraise_Sel[0];
                return objViewpointAppraise;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    const objViewpointAppraise_Const = await ViewpointAppraise_GetObjByViewpointAppraiseIdAsync(lngViewpointAppraiseId);
                    if (objViewpointAppraise_Const != null) {
                        ViewpointAppraise_ReFreshThisCache();
                        return objViewpointAppraise_Const;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngViewpointAppraiseId, exports.viewpointAppraise_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.ViewpointAppraise_GetObjByViewpointAppraiseId_Cache = ViewpointAppraise_GetObjByViewpointAppraiseId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param lngViewpointAppraiseId:所给的关键字
     * @returns 对象
    */
    async function ViewpointAppraise_GetObjByViewpointAppraiseId_localStorage(lngViewpointAppraiseId) {
        const strThisFuncName = "GetObjByViewpointAppraiseId_localStorage";
        if (lngViewpointAppraiseId == 0) {
            const strMsg = (0, clsString_js_2.Format)("参数:[lngViewpointAppraiseId]不能为空！(In clsViewpointAppraiseWApi.GetObjByViewpointAppraiseId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsViewpointAppraiseEN_js_1.clsViewpointAppraiseEN._CurrTabName, lngViewpointAppraiseId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objViewpointAppraise_Cache = JSON.parse(strTempObj);
            return objViewpointAppraise_Cache;
        }
        try {
            const objViewpointAppraise = await ViewpointAppraise_GetObjByViewpointAppraiseIdAsync(lngViewpointAppraiseId);
            if (objViewpointAppraise != null) {
                localStorage.setItem(strKey, JSON.stringify(objViewpointAppraise));
                const strInfo = (0, clsString_js_2.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objViewpointAppraise;
            }
            return objViewpointAppraise;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngViewpointAppraiseId, exports.viewpointAppraise_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.ViewpointAppraise_GetObjByViewpointAppraiseId_localStorage = ViewpointAppraise_GetObjByViewpointAppraiseId_localStorage;
    /**
     * 修改在缓存对象列表中的对象, 与后台数据库无关.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
     * @param objViewpointAppraise:所给的对象
     * @returns 对象
    */
    async function ViewpointAppraise_UpdateObjInLst_Cache(objViewpointAppraise) {
        const strThisFuncName = "UpdateObjInLst_Cache";
        try {
            const arrViewpointAppraiseObjLst_Cache = await ViewpointAppraise_GetObjLst_Cache();
            const obj = arrViewpointAppraiseObjLst_Cache.find(x => x.viewpointAppraiseId == objViewpointAppraise.viewpointAppraiseId && x.viewpointId == objViewpointAppraise.viewpointId);
            if (obj != null) {
                objViewpointAppraise.viewpointAppraiseId = obj.viewpointAppraiseId;
                (0, clsCommFunc4Web_js_1.ObjectAssign)(obj, objViewpointAppraise);
            }
            else {
                arrViewpointAppraiseObjLst_Cache.push(objViewpointAppraise);
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, exports.viewpointAppraise_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.ViewpointAppraise_UpdateObjInLst_Cache = ViewpointAppraise_UpdateObjInLst_Cache;
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
    async function ViewpointAppraise_func(strInFldName, strOutFldName, strInValue) {
        //const strThisFuncName = "func";
        if (strInFldName != clsViewpointAppraiseEN_js_1.clsViewpointAppraiseEN.con_ViewpointAppraiseId) {
            const strMsg = (0, clsString_js_2.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsViewpointAppraiseEN_js_1.clsViewpointAppraiseEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_2.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strOutFldName, clsViewpointAppraiseEN_js_1.clsViewpointAppraiseEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const lngViewpointAppraiseId = Number(strInValue);
        if (lngViewpointAppraiseId == 0) {
            return "";
        }
        const objViewpointAppraise = await ViewpointAppraise_GetObjByViewpointAppraiseId_Cache(lngViewpointAppraiseId);
        if (objViewpointAppraise == null)
            return "";
        if (objViewpointAppraise.GetFldValue(strOutFldName) == null)
            return "";
        return objViewpointAppraise.GetFldValue(strOutFldName).toString();
    }
    exports.ViewpointAppraise_func = ViewpointAppraise_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function ViewpointAppraise_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.viewpointAppraiseId - b.viewpointAppraiseId;
    }
    exports.ViewpointAppraise_SortFun_Defa = ViewpointAppraise_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function ViewpointAppraise_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.viewpointId == b.viewpointId)
            return a.appraiseContent.localeCompare(b.appraiseContent);
        else
            return a.viewpointId.localeCompare(b.viewpointId);
    }
    exports.ViewpointAppraise_SortFun_Defa_2Fld = ViewpointAppraise_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function ViewpointAppraise_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsViewpointAppraiseEN_js_1.clsViewpointAppraiseEN.con_ViewpointAppraiseId:
                    return (a, b) => {
                        return a.viewpointAppraiseId - b.viewpointAppraiseId;
                    };
                case clsViewpointAppraiseEN_js_1.clsViewpointAppraiseEN.con_ViewpointId:
                    return (a, b) => {
                        if (a.viewpointId == null)
                            return -1;
                        if (b.viewpointId == null)
                            return 1;
                        return a.viewpointId.localeCompare(b.viewpointId);
                    };
                case clsViewpointAppraiseEN_js_1.clsViewpointAppraiseEN.con_AppraiseContent:
                    return (a, b) => {
                        if (a.appraiseContent == null)
                            return -1;
                        if (b.appraiseContent == null)
                            return 1;
                        return a.appraiseContent.localeCompare(b.appraiseContent);
                    };
                case clsViewpointAppraiseEN_js_1.clsViewpointAppraiseEN.con_UpdDate:
                    return (a, b) => {
                        if (a.updDate == null)
                            return -1;
                        if (b.updDate == null)
                            return 1;
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsViewpointAppraiseEN_js_1.clsViewpointAppraiseEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                case clsViewpointAppraiseEN_js_1.clsViewpointAppraiseEN.con_UpdUser:
                    return (a, b) => {
                        if (a.updUser == null)
                            return -1;
                        if (b.updUser == null)
                            return 1;
                        return a.updUser.localeCompare(b.updUser);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[ViewpointAppraise]中不存在！(in ${exports.viewpointAppraise_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsViewpointAppraiseEN_js_1.clsViewpointAppraiseEN.con_ViewpointAppraiseId:
                    return (a, b) => {
                        return b.viewpointAppraiseId - a.viewpointAppraiseId;
                    };
                case clsViewpointAppraiseEN_js_1.clsViewpointAppraiseEN.con_ViewpointId:
                    return (a, b) => {
                        if (b.viewpointId == null)
                            return -1;
                        if (a.viewpointId == null)
                            return 1;
                        return b.viewpointId.localeCompare(a.viewpointId);
                    };
                case clsViewpointAppraiseEN_js_1.clsViewpointAppraiseEN.con_AppraiseContent:
                    return (a, b) => {
                        if (b.appraiseContent == null)
                            return -1;
                        if (a.appraiseContent == null)
                            return 1;
                        return b.appraiseContent.localeCompare(a.appraiseContent);
                    };
                case clsViewpointAppraiseEN_js_1.clsViewpointAppraiseEN.con_UpdDate:
                    return (a, b) => {
                        if (b.updDate == null)
                            return -1;
                        if (a.updDate == null)
                            return 1;
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsViewpointAppraiseEN_js_1.clsViewpointAppraiseEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                case clsViewpointAppraiseEN_js_1.clsViewpointAppraiseEN.con_UpdUser:
                    return (a, b) => {
                        if (b.updUser == null)
                            return -1;
                        if (a.updUser == null)
                            return 1;
                        return b.updUser.localeCompare(a.updUser);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[ViewpointAppraise]中不存在！(in ${exports.viewpointAppraise_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.ViewpointAppraise_SortFunByKey = ViewpointAppraise_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function ViewpointAppraise_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsViewpointAppraiseEN_js_1.clsViewpointAppraiseEN.con_ViewpointAppraiseId:
                return (obj) => {
                    return obj.viewpointAppraiseId === value;
                };
            case clsViewpointAppraiseEN_js_1.clsViewpointAppraiseEN.con_ViewpointId:
                return (obj) => {
                    return obj.viewpointId === value;
                };
            case clsViewpointAppraiseEN_js_1.clsViewpointAppraiseEN.con_AppraiseContent:
                return (obj) => {
                    return obj.appraiseContent === value;
                };
            case clsViewpointAppraiseEN_js_1.clsViewpointAppraiseEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsViewpointAppraiseEN_js_1.clsViewpointAppraiseEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            case clsViewpointAppraiseEN_js_1.clsViewpointAppraiseEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[ViewpointAppraise]中不存在！(in ${exports.viewpointAppraise_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.ViewpointAppraise_FilterFunByKey = ViewpointAppraise_FilterFunByKey;
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
    async function ViewpointAppraise_funcKey(strInFldName, strInValue, strComparisonOp) {
        //const strThisFuncName = "funcKey";
        if (strInFldName == clsViewpointAppraiseEN_js_1.clsViewpointAppraiseEN.con_ViewpointAppraiseId) {
            const strMsg = (0, clsString_js_2.Format)("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (Number(strInValue) == 0) {
            return [];
        }
        const arrViewpointAppraise = await ViewpointAppraise_GetObjLst_Cache();
        if (arrViewpointAppraise == null)
            return [];
        let arrViewpointAppraise_Sel = arrViewpointAppraise;
        const strType = typeof (strInValue);
        switch (strType) {
            case "string":
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01: // " = "
                        arrViewpointAppraise_Sel = arrViewpointAppraise_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.Like_03:
                        arrViewpointAppraise_Sel = arrViewpointAppraise_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.In_04:
                        const arrValues = strInValue.split(',');
                        arrViewpointAppraise_Sel = arrViewpointAppraise_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
                        break;
                }
                break;
            case "boolean":
                if (strInValue == null)
                    return [];
                if (strComparisonOp == enumComparisonOp_js_1.enumComparisonOp.Equal_01) {
                    arrViewpointAppraise_Sel = arrViewpointAppraise_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                }
                break;
            case "number":
                if (Number(strInValue) == 0)
                    return [];
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01:
                        arrViewpointAppraise_Sel = arrViewpointAppraise_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotEqual_02:
                        arrViewpointAppraise_Sel = arrViewpointAppraise_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotLessThan_05: //" >= ":
                        arrViewpointAppraise_Sel = arrViewpointAppraise_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotGreaterThan_06: //" <= ":
                        arrViewpointAppraise_Sel = arrViewpointAppraise_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.GreaterThan_07: //" > ":
                        arrViewpointAppraise_Sel = arrViewpointAppraise_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.LessThan_08: //" < ":
                        arrViewpointAppraise_Sel = arrViewpointAppraise_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                }
                break;
        }
        if (arrViewpointAppraise_Sel.length == 0)
            return [];
        return arrViewpointAppraise_Sel.map(x => x.viewpointAppraiseId);
    }
    exports.ViewpointAppraise_funcKey = ViewpointAppraise_funcKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function ViewpointAppraise_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointAppraise_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointAppraise_GetFirstIDAsync = ViewpointAppraise_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function ViewpointAppraise_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointAppraise_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointAppraise_GetFirstID = ViewpointAppraise_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function ViewpointAppraise_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointAppraise_Controller, strAction);
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
                const objViewpointAppraise = ViewpointAppraise_GetObjFromJsonObj(returnObj);
                return objViewpointAppraise;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointAppraise_GetFirstObjAsync = ViewpointAppraise_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function ViewpointAppraise_GetObjLst_ClientCache() {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsViewpointAppraiseEN_js_1.clsViewpointAppraiseEN._CurrTabName;
        if ((0, clsString_js_2.IsNullOrEmpty)(clsViewpointAppraiseEN_js_1.clsViewpointAppraiseEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsViewpointAppraiseEN_js_1.clsViewpointAppraiseEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_1.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrViewpointAppraiseExObjLst_Cache = CacheHelper_js_1.CacheHelper.Get(strKey);
            const arrViewpointAppraiseObjLst_T = ViewpointAppraise_GetObjLstByJSONObjLst(arrViewpointAppraiseExObjLst_Cache);
            return arrViewpointAppraiseObjLst_T;
        }
        try {
            const arrViewpointAppraiseExObjLst = await ViewpointAppraise_GetObjLstAsync(strWhereCond);
            CacheHelper_js_1.CacheHelper.Add(strKey, arrViewpointAppraiseExObjLst);
            const strInfo = (0, clsString_js_2.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrViewpointAppraiseExObjLst.length);
            console.log(strInfo);
            return arrViewpointAppraiseExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.viewpointAppraise_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.ViewpointAppraise_GetObjLst_ClientCache = ViewpointAppraise_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function ViewpointAppraise_GetObjLst_localStorage() {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsViewpointAppraiseEN_js_1.clsViewpointAppraiseEN._CurrTabName;
        if ((0, clsString_js_2.IsNullOrEmpty)(clsViewpointAppraiseEN_js_1.clsViewpointAppraiseEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsViewpointAppraiseEN_js_1.clsViewpointAppraiseEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrViewpointAppraiseExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrViewpointAppraiseObjLst_T = ViewpointAppraise_GetObjLstByJSONObjLst(arrViewpointAppraiseExObjLst_Cache);
            return arrViewpointAppraiseObjLst_T;
        }
        try {
            const arrViewpointAppraiseExObjLst = await ViewpointAppraise_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrViewpointAppraiseExObjLst));
            const strInfo = (0, clsString_js_2.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrViewpointAppraiseExObjLst.length);
            console.log(strInfo);
            return arrViewpointAppraiseExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.viewpointAppraise_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.ViewpointAppraise_GetObjLst_localStorage = ViewpointAppraise_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function ViewpointAppraise_GetObjLst_localStorage_PureCache() {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsViewpointAppraiseEN_js_1.clsViewpointAppraiseEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrViewpointAppraiseObjLst_Cache = JSON.parse(strTempObjLst);
            return arrViewpointAppraiseObjLst_Cache;
        }
        else
            return null;
    }
    exports.ViewpointAppraise_GetObjLst_localStorage_PureCache = ViewpointAppraise_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function ViewpointAppraise_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointAppraise_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.viewpointAppraise_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = ViewpointAppraise_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointAppraise_GetObjLstAsync = ViewpointAppraise_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function ViewpointAppraise_GetObjLst_sessionStorage() {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsViewpointAppraiseEN_js_1.clsViewpointAppraiseEN._CurrTabName;
        if ((0, clsString_js_2.IsNullOrEmpty)(clsViewpointAppraiseEN_js_1.clsViewpointAppraiseEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsViewpointAppraiseEN_js_1.clsViewpointAppraiseEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrViewpointAppraiseExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrViewpointAppraiseObjLst_T = ViewpointAppraise_GetObjLstByJSONObjLst(arrViewpointAppraiseExObjLst_Cache);
            return arrViewpointAppraiseObjLst_T;
        }
        try {
            const arrViewpointAppraiseExObjLst = await ViewpointAppraise_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrViewpointAppraiseExObjLst));
            const strInfo = (0, clsString_js_2.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrViewpointAppraiseExObjLst.length);
            console.log(strInfo);
            return arrViewpointAppraiseExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.viewpointAppraise_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.ViewpointAppraise_GetObjLst_sessionStorage = ViewpointAppraise_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function ViewpointAppraise_GetObjLst_sessionStorage_PureCache() {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsViewpointAppraiseEN_js_1.clsViewpointAppraiseEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrViewpointAppraiseObjLst_Cache = JSON.parse(strTempObjLst);
            return arrViewpointAppraiseObjLst_Cache;
        }
        else
            return null;
    }
    exports.ViewpointAppraise_GetObjLst_sessionStorage_PureCache = ViewpointAppraise_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function ViewpointAppraise_GetObjLst_Cache() {
        //const strThisFuncName = "GetObjLst_Cache";
        let arrViewpointAppraiseObjLst_Cache;
        switch (clsViewpointAppraiseEN_js_1.clsViewpointAppraiseEN.CacheModeId) {
            case "04": //sessionStorage
                arrViewpointAppraiseObjLst_Cache = await ViewpointAppraise_GetObjLst_sessionStorage();
                break;
            case "03": //localStorage
                arrViewpointAppraiseObjLst_Cache = await ViewpointAppraise_GetObjLst_localStorage();
                break;
            case "02": //ClientCache
                arrViewpointAppraiseObjLst_Cache = await ViewpointAppraise_GetObjLst_ClientCache();
                break;
            default:
                arrViewpointAppraiseObjLst_Cache = await ViewpointAppraise_GetObjLst_ClientCache();
                break;
        }
        const arrViewpointAppraiseObjLst = ViewpointAppraise_GetObjLstByJSONObjLst(arrViewpointAppraiseObjLst_Cache);
        return arrViewpointAppraiseObjLst_Cache;
    }
    exports.ViewpointAppraise_GetObjLst_Cache = ViewpointAppraise_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function ViewpointAppraise_GetObjLst_PureCache() {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrViewpointAppraiseObjLst_Cache;
        switch (clsViewpointAppraiseEN_js_1.clsViewpointAppraiseEN.CacheModeId) {
            case "04": //sessionStorage
                arrViewpointAppraiseObjLst_Cache = await ViewpointAppraise_GetObjLst_sessionStorage_PureCache();
                break;
            case "03": //localStorage
                arrViewpointAppraiseObjLst_Cache = await ViewpointAppraise_GetObjLst_localStorage_PureCache();
                break;
            case "02": //ClientCache
                arrViewpointAppraiseObjLst_Cache = null;
                break;
            default:
                arrViewpointAppraiseObjLst_Cache = null;
                break;
        }
        return arrViewpointAppraiseObjLst_Cache;
    }
    exports.ViewpointAppraise_GetObjLst_PureCache = ViewpointAppraise_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objlngViewpointAppraiseId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function ViewpointAppraise_GetSubObjLst_Cache(objViewpointAppraise_Cond) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrViewpointAppraiseObjLst_Cache = await ViewpointAppraise_GetObjLst_Cache();
        let arrViewpointAppraise_Sel = arrViewpointAppraiseObjLst_Cache;
        if (objViewpointAppraise_Cond.sf_FldComparisonOp == null || objViewpointAppraise_Cond.sf_FldComparisonOp == "")
            return arrViewpointAppraise_Sel;
        const dicFldComparisonOp = JSON.parse(objViewpointAppraise_Cond.sf_FldComparisonOp);
        //console.log("clsViewpointAppraiseWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objViewpointAppraise_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrViewpointAppraise_Sel = arrViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objViewpointAppraise_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrViewpointAppraise_Sel = arrViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrViewpointAppraise_Sel = arrViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrViewpointAppraise_Sel = arrViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrViewpointAppraise_Sel = arrViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrViewpointAppraise_Sel = arrViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrViewpointAppraise_Sel = arrViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrViewpointAppraise_Sel = arrViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrViewpointAppraise_Sel = arrViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrViewpointAppraise_Sel = arrViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrViewpointAppraise_Sel = arrViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrViewpointAppraise_Sel = arrViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrViewpointAppraise_Sel = arrViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrViewpointAppraise_Sel = arrViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrViewpointAppraise_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objViewpointAppraise_Cond), exports.viewpointAppraise_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.ViewpointAppraise_GetSubObjLst_Cache = ViewpointAppraise_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrViewpointAppraiseId:关键字列表
    * @returns 对象列表
    **/
    async function ViewpointAppraise_GetObjLstByViewpointAppraiseIdLstAsync(arrViewpointAppraiseId) {
        const strThisFuncName = "GetObjLstByViewpointAppraiseIdLstAsync";
        const strAction = "GetObjLstByViewpointAppraiseIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointAppraise_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrViewpointAppraiseId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.viewpointAppraise_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = ViewpointAppraise_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointAppraise_GetObjLstByViewpointAppraiseIdLstAsync = ViewpointAppraise_GetObjLstByViewpointAppraiseIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrlngViewpointAppraiseIdLst:关键字列表
     * @returns 对象列表
    */
    async function ViewpointAppraise_GetObjLstByViewpointAppraiseIdLst_Cache(arrViewpointAppraiseIdLst) {
        const strThisFuncName = "GetObjLstByViewpointAppraiseIdLst_Cache";
        try {
            const arrViewpointAppraiseObjLst_Cache = await ViewpointAppraise_GetObjLst_Cache();
            const arrViewpointAppraise_Sel = arrViewpointAppraiseObjLst_Cache.filter(x => arrViewpointAppraiseIdLst.indexOf(x.viewpointAppraiseId) > -1);
            return arrViewpointAppraise_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrViewpointAppraiseIdLst.join(","), exports.viewpointAppraise_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
    }
    exports.ViewpointAppraise_GetObjLstByViewpointAppraiseIdLst_Cache = ViewpointAppraise_GetObjLstByViewpointAppraiseIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function ViewpointAppraise_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointAppraise_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.viewpointAppraise_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = ViewpointAppraise_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointAppraise_GetTopObjLstAsync = ViewpointAppraise_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function ViewpointAppraise_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointAppraise_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.viewpointAppraise_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = ViewpointAppraise_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointAppraise_GetObjLstByRangeAsync = ViewpointAppraise_GetObjLstByRangeAsync;
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
    async function ViewpointAppraise_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointAppraise_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointAppraise_GetObjLstByRange = ViewpointAppraise_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function ViewpointAppraise_GetObjLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const arrViewpointAppraiseObjLst_Cache = await ViewpointAppraise_GetObjLst_Cache();
        if (arrViewpointAppraiseObjLst_Cache.length == 0)
            return arrViewpointAppraiseObjLst_Cache;
        let arrViewpointAppraise_Sel = arrViewpointAppraiseObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objViewpointAppraise_Cond = new clsViewpointAppraiseEN_js_1.clsViewpointAppraiseEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objViewpointAppraise_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsViewpointAppraiseWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrViewpointAppraise_Sel = arrViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objViewpointAppraise_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrViewpointAppraise_Sel = arrViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrViewpointAppraise_Sel = arrViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrViewpointAppraise_Sel = arrViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrViewpointAppraise_Sel = arrViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrViewpointAppraise_Sel = arrViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrViewpointAppraise_Sel = arrViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrViewpointAppraise_Sel = arrViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrViewpointAppraise_Sel = arrViewpointAppraise_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrViewpointAppraise_Sel = arrViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrViewpointAppraise_Sel = arrViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrViewpointAppraise_Sel = arrViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrViewpointAppraise_Sel = arrViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrViewpointAppraise_Sel = arrViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrViewpointAppraise_Sel = arrViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrViewpointAppraise_Sel.length == 0)
                return arrViewpointAppraise_Sel;
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
                arrViewpointAppraise_Sel = arrViewpointAppraise_Sel.sort(ViewpointAppraise_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrViewpointAppraise_Sel = arrViewpointAppraise_Sel.sort(objPagerPara.sortFun);
            }
            arrViewpointAppraise_Sel = arrViewpointAppraise_Sel.slice(intStart, intEnd);
            return arrViewpointAppraise_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.viewpointAppraise_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.ViewpointAppraise_GetObjLstByPager_Cache = ViewpointAppraise_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function ViewpointAppraise_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointAppraise_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.viewpointAppraise_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = ViewpointAppraise_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointAppraise_GetObjLstByPagerAsync = ViewpointAppraise_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param lngViewpointAppraiseId:关键字
    * @returns 获取删除的结果
    **/
    async function ViewpointAppraise_DelRecordAsync(lngViewpointAppraiseId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointAppraise_Controller, strAction);
        strUrl = (0, clsString_js_2.Format)("{0}/?Id={1}", strUrl, lngViewpointAppraiseId);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointAppraise_DelRecordAsync = ViewpointAppraise_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrViewpointAppraiseId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function ViewpointAppraise_DelViewpointAppraisesAsync(arrViewpointAppraiseId) {
        const strThisFuncName = "DelViewpointAppraisesAsync";
        const strAction = "DelViewpointAppraises";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointAppraise_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrViewpointAppraiseId);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointAppraise_DelViewpointAppraisesAsync = ViewpointAppraise_DelViewpointAppraisesAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function ViewpointAppraise_DelViewpointAppraisesByCondAsync(strWhereCond) {
        const strThisFuncName = "DelViewpointAppraisesByCondAsync";
        const strAction = "DelViewpointAppraisesByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointAppraise_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointAppraise_DelViewpointAppraisesByCondAsync = ViewpointAppraise_DelViewpointAppraisesByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objViewpointAppraiseEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function ViewpointAppraise_AddNewRecordAsync(objViewpointAppraiseEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objViewpointAppraiseEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointAppraise_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objViewpointAppraiseEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointAppraise_AddNewRecordAsync = ViewpointAppraise_AddNewRecordAsync;
    /* 数据类型不是字符型，不可以最大关键字的方式添加记录。*/
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objViewpointAppraiseEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function ViewpointAppraise_AddNewRecordWithReturnKeyAsync(objViewpointAppraiseEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointAppraise_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objViewpointAppraiseEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointAppraise_AddNewRecordWithReturnKeyAsync = ViewpointAppraise_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objViewpointAppraiseEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function ViewpointAppraise_AddNewRecordWithReturnKey(objViewpointAppraiseEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objViewpointAppraiseEN.viewpointAppraiseId === null || objViewpointAppraiseEN.viewpointAppraiseId === 0) {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointAppraise_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objViewpointAppraiseEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointAppraise_AddNewRecordWithReturnKey = ViewpointAppraise_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objViewpointAppraiseEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function ViewpointAppraise_UpdateRecordAsync(objViewpointAppraiseEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objViewpointAppraiseEN.sf_UpdFldSetStr === undefined || objViewpointAppraiseEN.sf_UpdFldSetStr === null || objViewpointAppraiseEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objViewpointAppraiseEN.viewpointAppraiseId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointAppraise_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objViewpointAppraiseEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointAppraise_UpdateRecordAsync = ViewpointAppraise_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objViewpointAppraiseEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function ViewpointAppraise_UpdateWithConditionAsync(objViewpointAppraiseEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objViewpointAppraiseEN.sf_UpdFldSetStr === undefined || objViewpointAppraiseEN.sf_UpdFldSetStr === null || objViewpointAppraiseEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objViewpointAppraiseEN.viewpointAppraiseId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointAppraise_Controller, strAction);
        objViewpointAppraiseEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objViewpointAppraiseEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointAppraise_UpdateWithConditionAsync = ViewpointAppraise_UpdateWithConditionAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objlngViewpointAppraiseId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function ViewpointAppraise_IsExistRecord_Cache(objViewpointAppraise_Cond) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrViewpointAppraiseObjLst_Cache = await ViewpointAppraise_GetObjLst_Cache();
        if (arrViewpointAppraiseObjLst_Cache == null)
            return false;
        let arrViewpointAppraise_Sel = arrViewpointAppraiseObjLst_Cache;
        if (objViewpointAppraise_Cond.sf_FldComparisonOp == null || objViewpointAppraise_Cond.sf_FldComparisonOp == "")
            return arrViewpointAppraise_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objViewpointAppraise_Cond.sf_FldComparisonOp);
        //console.log("clsViewpointAppraiseWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objViewpointAppraise_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objViewpointAppraise_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrViewpointAppraise_Sel = arrViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrViewpointAppraise_Sel = arrViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrViewpointAppraise_Sel = arrViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrViewpointAppraise_Sel = arrViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrViewpointAppraise_Sel = arrViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrViewpointAppraise_Sel = arrViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrViewpointAppraise_Sel = arrViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrViewpointAppraise_Sel = arrViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrViewpointAppraise_Sel = arrViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrViewpointAppraise_Sel = arrViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrViewpointAppraise_Sel = arrViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrViewpointAppraise_Sel = arrViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrViewpointAppraise_Sel = arrViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrViewpointAppraise_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objViewpointAppraise_Cond), exports.viewpointAppraise_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.ViewpointAppraise_IsExistRecord_Cache = ViewpointAppraise_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function ViewpointAppraise_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointAppraise_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointAppraise_IsExistRecordAsync = ViewpointAppraise_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param lngViewpointAppraiseId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function ViewpointAppraise_IsExist(lngViewpointAppraiseId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointAppraise_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "ViewpointAppraiseId": lngViewpointAppraiseId,
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointAppraise_IsExist = ViewpointAppraise_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param lngViewpointAppraiseId:所给的关键字
     * @returns 对象
    */
    async function ViewpointAppraise_IsExist_Cache(lngViewpointAppraiseId) {
        const strThisFuncName = "IsExist_Cache";
        const arrViewpointAppraiseObjLst_Cache = await ViewpointAppraise_GetObjLst_Cache();
        if (arrViewpointAppraiseObjLst_Cache == null)
            return false;
        try {
            const arrViewpointAppraise_Sel = arrViewpointAppraiseObjLst_Cache.filter(x => x.viewpointAppraiseId == lngViewpointAppraiseId);
            if (arrViewpointAppraise_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", lngViewpointAppraiseId, exports.viewpointAppraise_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.ViewpointAppraise_IsExist_Cache = ViewpointAppraise_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param lngViewpointAppraiseId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function ViewpointAppraise_IsExistAsync(lngViewpointAppraiseId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointAppraise_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "lngViewpointAppraiseId": lngViewpointAppraiseId }
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointAppraise_IsExistAsync = ViewpointAppraise_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function ViewpointAppraise_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointAppraise_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointAppraise_GetRecCountByCondAsync = ViewpointAppraise_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objViewpointAppraise_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function ViewpointAppraise_GetRecCountByCond_Cache(objViewpointAppraise_Cond) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrViewpointAppraiseObjLst_Cache = await ViewpointAppraise_GetObjLst_Cache();
        if (arrViewpointAppraiseObjLst_Cache == null)
            return 0;
        let arrViewpointAppraise_Sel = arrViewpointAppraiseObjLst_Cache;
        if (objViewpointAppraise_Cond.sf_FldComparisonOp == null || objViewpointAppraise_Cond.sf_FldComparisonOp == "")
            return arrViewpointAppraise_Sel.length;
        const dicFldComparisonOp = JSON.parse(objViewpointAppraise_Cond.sf_FldComparisonOp);
        //console.log("clsViewpointAppraiseWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objViewpointAppraise_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrViewpointAppraise_Sel = arrViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objViewpointAppraise_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrViewpointAppraise_Sel = arrViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrViewpointAppraise_Sel = arrViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrViewpointAppraise_Sel = arrViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrViewpointAppraise_Sel = arrViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrViewpointAppraise_Sel = arrViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrViewpointAppraise_Sel = arrViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrViewpointAppraise_Sel = arrViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrViewpointAppraise_Sel = arrViewpointAppraise_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrViewpointAppraise_Sel = arrViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrViewpointAppraise_Sel = arrViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrViewpointAppraise_Sel = arrViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrViewpointAppraise_Sel = arrViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrViewpointAppraise_Sel = arrViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrViewpointAppraise_Sel = arrViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrViewpointAppraise_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objViewpointAppraise_Cond), exports.viewpointAppraise_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.ViewpointAppraise_GetRecCountByCond_Cache = ViewpointAppraise_GetRecCountByCond_Cache;
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
    async function ViewpointAppraise_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointAppraise_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointAppraise_GetMaxStrIdByPrefix = ViewpointAppraise_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function ViewpointAppraise_GetWebApiUrl(strController, strAction) {
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
    exports.ViewpointAppraise_GetWebApiUrl = ViewpointAppraise_GetWebApiUrl;
    /**
    * 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshCache)
    **/
    function ViewpointAppraise_ReFreshCache() {
        const strThisFuncName = "ReFreshCache";
        const strMsg = (0, clsString_js_2.Format)("刷新缓存成功！");
        console.trace(strMsg);
        // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
        const strKey = clsViewpointAppraiseEN_js_1.clsViewpointAppraiseEN._CurrTabName;
        switch (clsViewpointAppraiseEN_js_1.clsViewpointAppraiseEN.CacheModeId) {
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
        (0, clsvViewpointAppraiseWApi_js_1.vViewpointAppraise_ReFreshThisCache)();
    }
    exports.ViewpointAppraise_ReFreshCache = ViewpointAppraise_ReFreshCache;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function ViewpointAppraise_ReFreshThisCache() {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = clsViewpointAppraiseEN_js_1.clsViewpointAppraiseEN._CurrTabName;
            switch (clsViewpointAppraiseEN_js_1.clsViewpointAppraiseEN.CacheModeId) {
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
    exports.ViewpointAppraise_ReFreshThisCache = ViewpointAppraise_ReFreshThisCache;
    /* 该表的下拉框功能没有设置，不需要生成下拉框绑定函数。*/
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function ViewpointAppraise_CheckPropertyNew(pobjViewpointAppraiseEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjViewpointAppraiseEN.viewpointId) == false && (0, clsString_js_2.GetStrLen)(pobjViewpointAppraiseEN.viewpointId) > 8) {
            throw new Error("(errid:Watl000059)字段[观点Id(viewpointId)]的长度不能超过8(In 观点评论表(ViewpointAppraise))!值:$(pobjViewpointAppraiseEN.viewpointId)(clsViewpointAppraiseBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjViewpointAppraiseEN.appraiseContent) == false && (0, clsString_js_2.GetStrLen)(pobjViewpointAppraiseEN.appraiseContent) > 2000) {
            throw new Error("(errid:Watl000059)字段[评议内容(appraiseContent)]的长度不能超过2000(In 观点评论表(ViewpointAppraise))!值:$(pobjViewpointAppraiseEN.appraiseContent)(clsViewpointAppraiseBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjViewpointAppraiseEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjViewpointAppraiseEN.updDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 观点评论表(ViewpointAppraise))!值:$(pobjViewpointAppraiseEN.updDate)(clsViewpointAppraiseBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjViewpointAppraiseEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjViewpointAppraiseEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 观点评论表(ViewpointAppraise))!值:$(pobjViewpointAppraiseEN.memo)(clsViewpointAppraiseBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjViewpointAppraiseEN.updUser) == false && (0, clsString_js_2.GetStrLen)(pobjViewpointAppraiseEN.updUser) > 20) {
            throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 观点评论表(ViewpointAppraise))!值:$(pobjViewpointAppraiseEN.updUser)(clsViewpointAppraiseBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if (null != pobjViewpointAppraiseEN.viewpointAppraiseId && undefined !== pobjViewpointAppraiseEN.viewpointAppraiseId && clsString_js_1.tzDataType.isNumber(pobjViewpointAppraiseEN.viewpointAppraiseId) === false) {
            throw new Error("(errid:Watl000060)字段[观点评论Id(viewpointAppraiseId)]的值:[$(pobjViewpointAppraiseEN.viewpointAppraiseId)], 非法，应该为数值型(In 观点评论表(ViewpointAppraise))!(clsViewpointAppraiseBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjViewpointAppraiseEN.viewpointId) == false && undefined !== pobjViewpointAppraiseEN.viewpointId && clsString_js_1.tzDataType.isString(pobjViewpointAppraiseEN.viewpointId) === false) {
            throw new Error("(errid:Watl000060)字段[观点Id(viewpointId)]的值:[$(pobjViewpointAppraiseEN.viewpointId)], 非法，应该为字符型(In 观点评论表(ViewpointAppraise))!(clsViewpointAppraiseBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjViewpointAppraiseEN.appraiseContent) == false && undefined !== pobjViewpointAppraiseEN.appraiseContent && clsString_js_1.tzDataType.isString(pobjViewpointAppraiseEN.appraiseContent) === false) {
            throw new Error("(errid:Watl000060)字段[评议内容(appraiseContent)]的值:[$(pobjViewpointAppraiseEN.appraiseContent)], 非法，应该为字符型(In 观点评论表(ViewpointAppraise))!(clsViewpointAppraiseBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjViewpointAppraiseEN.updDate) == false && undefined !== pobjViewpointAppraiseEN.updDate && clsString_js_1.tzDataType.isString(pobjViewpointAppraiseEN.updDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjViewpointAppraiseEN.updDate)], 非法，应该为字符型(In 观点评论表(ViewpointAppraise))!(clsViewpointAppraiseBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjViewpointAppraiseEN.memo) == false && undefined !== pobjViewpointAppraiseEN.memo && clsString_js_1.tzDataType.isString(pobjViewpointAppraiseEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjViewpointAppraiseEN.memo)], 非法，应该为字符型(In 观点评论表(ViewpointAppraise))!(clsViewpointAppraiseBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjViewpointAppraiseEN.updUser) == false && undefined !== pobjViewpointAppraiseEN.updUser && clsString_js_1.tzDataType.isString(pobjViewpointAppraiseEN.updUser) === false) {
            throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjViewpointAppraiseEN.updUser)], 非法，应该为字符型(In 观点评论表(ViewpointAppraise))!(clsViewpointAppraiseBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjViewpointAppraiseEN.SetIsCheckProperty(true);
    }
    exports.ViewpointAppraise_CheckPropertyNew = ViewpointAppraise_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function ViewpointAppraise_CheckProperty4Update(pobjViewpointAppraiseEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjViewpointAppraiseEN.viewpointId) == false && (0, clsString_js_2.GetStrLen)(pobjViewpointAppraiseEN.viewpointId) > 8) {
            throw new Error("(errid:Watl000062)字段[观点Id(viewpointId)]的长度不能超过8(In 观点评论表(ViewpointAppraise))!值:$(pobjViewpointAppraiseEN.viewpointId)(clsViewpointAppraiseBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjViewpointAppraiseEN.appraiseContent) == false && (0, clsString_js_2.GetStrLen)(pobjViewpointAppraiseEN.appraiseContent) > 2000) {
            throw new Error("(errid:Watl000062)字段[评议内容(appraiseContent)]的长度不能超过2000(In 观点评论表(ViewpointAppraise))!值:$(pobjViewpointAppraiseEN.appraiseContent)(clsViewpointAppraiseBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjViewpointAppraiseEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjViewpointAppraiseEN.updDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 观点评论表(ViewpointAppraise))!值:$(pobjViewpointAppraiseEN.updDate)(clsViewpointAppraiseBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjViewpointAppraiseEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjViewpointAppraiseEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 观点评论表(ViewpointAppraise))!值:$(pobjViewpointAppraiseEN.memo)(clsViewpointAppraiseBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjViewpointAppraiseEN.updUser) == false && (0, clsString_js_2.GetStrLen)(pobjViewpointAppraiseEN.updUser) > 20) {
            throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 观点评论表(ViewpointAppraise))!值:$(pobjViewpointAppraiseEN.updUser)(clsViewpointAppraiseBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if (null != pobjViewpointAppraiseEN.viewpointAppraiseId && undefined !== pobjViewpointAppraiseEN.viewpointAppraiseId && clsString_js_1.tzDataType.isNumber(pobjViewpointAppraiseEN.viewpointAppraiseId) === false) {
            throw new Error("(errid:Watl000063)字段[观点评论Id(viewpointAppraiseId)]的值:[$(pobjViewpointAppraiseEN.viewpointAppraiseId)], 非法，应该为数值型(In 观点评论表(ViewpointAppraise))!(clsViewpointAppraiseBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjViewpointAppraiseEN.viewpointId) == false && undefined !== pobjViewpointAppraiseEN.viewpointId && clsString_js_1.tzDataType.isString(pobjViewpointAppraiseEN.viewpointId) === false) {
            throw new Error("(errid:Watl000063)字段[观点Id(viewpointId)]的值:[$(pobjViewpointAppraiseEN.viewpointId)], 非法，应该为字符型(In 观点评论表(ViewpointAppraise))!(clsViewpointAppraiseBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjViewpointAppraiseEN.appraiseContent) == false && undefined !== pobjViewpointAppraiseEN.appraiseContent && clsString_js_1.tzDataType.isString(pobjViewpointAppraiseEN.appraiseContent) === false) {
            throw new Error("(errid:Watl000063)字段[评议内容(appraiseContent)]的值:[$(pobjViewpointAppraiseEN.appraiseContent)], 非法，应该为字符型(In 观点评论表(ViewpointAppraise))!(clsViewpointAppraiseBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjViewpointAppraiseEN.updDate) == false && undefined !== pobjViewpointAppraiseEN.updDate && clsString_js_1.tzDataType.isString(pobjViewpointAppraiseEN.updDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjViewpointAppraiseEN.updDate)], 非法，应该为字符型(In 观点评论表(ViewpointAppraise))!(clsViewpointAppraiseBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjViewpointAppraiseEN.memo) == false && undefined !== pobjViewpointAppraiseEN.memo && clsString_js_1.tzDataType.isString(pobjViewpointAppraiseEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjViewpointAppraiseEN.memo)], 非法，应该为字符型(In 观点评论表(ViewpointAppraise))!(clsViewpointAppraiseBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjViewpointAppraiseEN.updUser) == false && undefined !== pobjViewpointAppraiseEN.updUser && clsString_js_1.tzDataType.isString(pobjViewpointAppraiseEN.updUser) === false) {
            throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjViewpointAppraiseEN.updUser)], 非法，应该为字符型(In 观点评论表(ViewpointAppraise))!(clsViewpointAppraiseBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if (null === pobjViewpointAppraiseEN.viewpointAppraiseId
            || pobjViewpointAppraiseEN.viewpointAppraiseId != null && pobjViewpointAppraiseEN.viewpointAppraiseId.toString() === "") {
            throw new Error("(errid:Watl000064)字段[观点评论Id]不能为空(In 观点评论表)!(clsViewpointAppraiseBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjViewpointAppraiseEN.SetIsCheckProperty(true);
    }
    exports.ViewpointAppraise_CheckProperty4Update = ViewpointAppraise_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function ViewpointAppraise_GetJSONStrByObj(pobjViewpointAppraiseEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjViewpointAppraiseEN.sf_UpdFldSetStr = pobjViewpointAppraiseEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjViewpointAppraiseEN);
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
    exports.ViewpointAppraise_GetJSONStrByObj = ViewpointAppraise_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function ViewpointAppraise_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrViewpointAppraiseObjLst = new Array();
        if (strJSON === "") {
            return arrViewpointAppraiseObjLst;
        }
        try {
            arrViewpointAppraiseObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrViewpointAppraiseObjLst;
        }
        return arrViewpointAppraiseObjLst;
    }
    exports.ViewpointAppraise_GetObjLstByJSONStr = ViewpointAppraise_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrViewpointAppraiseObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function ViewpointAppraise_GetObjLstByJSONObjLst(arrViewpointAppraiseObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrViewpointAppraiseObjLst = new Array();
        for (const objInFor of arrViewpointAppraiseObjLstS) {
            const obj1 = ViewpointAppraise_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrViewpointAppraiseObjLst.push(obj1);
        }
        return arrViewpointAppraiseObjLst;
    }
    exports.ViewpointAppraise_GetObjLstByJSONObjLst = ViewpointAppraise_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function ViewpointAppraise_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjViewpointAppraiseEN = new clsViewpointAppraiseEN_js_1.clsViewpointAppraiseEN();
        if (strJSON === "") {
            return pobjViewpointAppraiseEN;
        }
        try {
            pobjViewpointAppraiseEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjViewpointAppraiseEN;
        }
        return pobjViewpointAppraiseEN;
    }
    exports.ViewpointAppraise_GetObjByJSONStr = ViewpointAppraise_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function ViewpointAppraise_GetCombineCondition(objViewpointAppraise_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objViewpointAppraise_Cond.dicFldComparisonOp, clsViewpointAppraiseEN_js_1.clsViewpointAppraiseEN.con_ViewpointAppraiseId) == true) {
            const strComparisonOp_ViewpointAppraiseId = objViewpointAppraise_Cond.dicFldComparisonOp[clsViewpointAppraiseEN_js_1.clsViewpointAppraiseEN.con_ViewpointAppraiseId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsViewpointAppraiseEN_js_1.clsViewpointAppraiseEN.con_ViewpointAppraiseId, objViewpointAppraise_Cond.viewpointAppraiseId, strComparisonOp_ViewpointAppraiseId);
        }
        if (Object.prototype.hasOwnProperty.call(objViewpointAppraise_Cond.dicFldComparisonOp, clsViewpointAppraiseEN_js_1.clsViewpointAppraiseEN.con_ViewpointId) == true) {
            const strComparisonOp_ViewpointId = objViewpointAppraise_Cond.dicFldComparisonOp[clsViewpointAppraiseEN_js_1.clsViewpointAppraiseEN.con_ViewpointId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsViewpointAppraiseEN_js_1.clsViewpointAppraiseEN.con_ViewpointId, objViewpointAppraise_Cond.viewpointId, strComparisonOp_ViewpointId);
        }
        if (Object.prototype.hasOwnProperty.call(objViewpointAppraise_Cond.dicFldComparisonOp, clsViewpointAppraiseEN_js_1.clsViewpointAppraiseEN.con_AppraiseContent) == true) {
            const strComparisonOp_AppraiseContent = objViewpointAppraise_Cond.dicFldComparisonOp[clsViewpointAppraiseEN_js_1.clsViewpointAppraiseEN.con_AppraiseContent];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsViewpointAppraiseEN_js_1.clsViewpointAppraiseEN.con_AppraiseContent, objViewpointAppraise_Cond.appraiseContent, strComparisonOp_AppraiseContent);
        }
        if (Object.prototype.hasOwnProperty.call(objViewpointAppraise_Cond.dicFldComparisonOp, clsViewpointAppraiseEN_js_1.clsViewpointAppraiseEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objViewpointAppraise_Cond.dicFldComparisonOp[clsViewpointAppraiseEN_js_1.clsViewpointAppraiseEN.con_UpdDate];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsViewpointAppraiseEN_js_1.clsViewpointAppraiseEN.con_UpdDate, objViewpointAppraise_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objViewpointAppraise_Cond.dicFldComparisonOp, clsViewpointAppraiseEN_js_1.clsViewpointAppraiseEN.con_Memo) == true) {
            const strComparisonOp_Memo = objViewpointAppraise_Cond.dicFldComparisonOp[clsViewpointAppraiseEN_js_1.clsViewpointAppraiseEN.con_Memo];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsViewpointAppraiseEN_js_1.clsViewpointAppraiseEN.con_Memo, objViewpointAppraise_Cond.memo, strComparisonOp_Memo);
        }
        if (Object.prototype.hasOwnProperty.call(objViewpointAppraise_Cond.dicFldComparisonOp, clsViewpointAppraiseEN_js_1.clsViewpointAppraiseEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objViewpointAppraise_Cond.dicFldComparisonOp[clsViewpointAppraiseEN_js_1.clsViewpointAppraiseEN.con_UpdUser];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsViewpointAppraiseEN_js_1.clsViewpointAppraiseEN.con_UpdUser, objViewpointAppraise_Cond.updUser, strComparisonOp_UpdUser);
        }
        return strWhereCond;
    }
    exports.ViewpointAppraise_GetCombineCondition = ViewpointAppraise_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--ViewpointAppraise(观点评论表),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param lngViewpointAppraiseId: 观点评论Id(要求唯一的字段)
    * @param strViewpointId: 观点Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function ViewpointAppraise_GetUniCondStr_ViewpointAppraiseId_ViewpointId(objViewpointAppraiseEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and ViewpointAppraiseId = '{0}'", objViewpointAppraiseEN.viewpointAppraiseId);
        strWhereCond += (0, clsString_js_2.Format)(" and ViewpointId = '{0}'", objViewpointAppraiseEN.viewpointId);
        return strWhereCond;
    }
    exports.ViewpointAppraise_GetUniCondStr_ViewpointAppraiseId_ViewpointId = ViewpointAppraise_GetUniCondStr_ViewpointAppraiseId_ViewpointId;
    /**
    *获取唯一性条件串(Uniqueness)--ViewpointAppraise(观点评论表),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param lngViewpointAppraiseId: 观点评论Id(要求唯一的字段)
    * @param strViewpointId: 观点Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function ViewpointAppraise_GetUniCondStr4Update_ViewpointAppraiseId_ViewpointId(objViewpointAppraiseEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and ViewpointAppraiseId <> '{0}'", objViewpointAppraiseEN.viewpointAppraiseId);
        strWhereCond += (0, clsString_js_2.Format)(" and ViewpointAppraiseId = '{0}'", objViewpointAppraiseEN.viewpointAppraiseId);
        strWhereCond += (0, clsString_js_2.Format)(" and ViewpointId = '{0}'", objViewpointAppraiseEN.viewpointId);
        return strWhereCond;
    }
    exports.ViewpointAppraise_GetUniCondStr4Update_ViewpointAppraiseId_ViewpointId = ViewpointAppraise_GetUniCondStr4Update_ViewpointAppraiseId_ViewpointId;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objViewpointAppraiseENS:源对象
     * @param objViewpointAppraiseENT:目标对象
    */
    function ViewpointAppraise_CopyObjTo(objViewpointAppraiseENS, objViewpointAppraiseENT) {
        objViewpointAppraiseENT.viewpointAppraiseId = objViewpointAppraiseENS.viewpointAppraiseId; //观点评论Id
        objViewpointAppraiseENT.viewpointId = objViewpointAppraiseENS.viewpointId; //观点Id
        objViewpointAppraiseENT.appraiseContent = objViewpointAppraiseENS.appraiseContent; //评议内容
        objViewpointAppraiseENT.updDate = objViewpointAppraiseENS.updDate; //修改日期
        objViewpointAppraiseENT.memo = objViewpointAppraiseENS.memo; //备注
        objViewpointAppraiseENT.updUser = objViewpointAppraiseENS.updUser; //修改人
        objViewpointAppraiseENT.sf_UpdFldSetStr = objViewpointAppraiseENS.updFldString; //sf_UpdFldSetStr
    }
    exports.ViewpointAppraise_CopyObjTo = ViewpointAppraise_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objViewpointAppraiseENS:源对象
     * @param objViewpointAppraiseENT:目标对象
    */
    function ViewpointAppraise_GetObjFromJsonObj(objViewpointAppraiseENS) {
        const objViewpointAppraiseENT = new clsViewpointAppraiseEN_js_1.clsViewpointAppraiseEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objViewpointAppraiseENT, objViewpointAppraiseENS);
        return objViewpointAppraiseENT;
    }
    exports.ViewpointAppraise_GetObjFromJsonObj = ViewpointAppraise_GetObjFromJsonObj;
});
