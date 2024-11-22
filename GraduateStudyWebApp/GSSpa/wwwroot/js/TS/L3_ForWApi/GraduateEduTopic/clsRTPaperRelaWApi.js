/**
* 类名:clsRTPaperRelaWApi
* 表名:RTPaperRela(01120581)
* 生成代码版本:2022.11.02.1
* 生成日期:2022/11/02 11:47:01
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
        define(["require", "exports", "axios", "../../PubFun/CacheHelper.js", "../../L0_Entity/GraduateEduTopic/clsRTPaperRelaEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsSysPara4WebApi.js", "../../PubFun/CacheHelper.js", "../../PubFun/jsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.RTPaperRela_GetObjFromJsonObj = exports.RTPaperRela_CopyObjTo = exports.RTPaperRela_GetUniCondStr4Update_mId = exports.RTPaperRela_GetUniCondStr_mId = exports.RTPaperRela_GetCombineCondition = exports.RTPaperRela_GetObjByJSONStr = exports.RTPaperRela_GetObjLstByJSONObjLst = exports.RTPaperRela_GetObjLstByJSONStr = exports.RTPaperRela_GetJSONStrByObj = exports.RTPaperRela_CheckProperty4Update = exports.RTPaperRela_CheckPropertyNew = exports.RTPaperRela_ReFreshThisCache = exports.RTPaperRela_ReFreshCache = exports.RTPaperRela_GetWebApiUrl = exports.RTPaperRela_GetMaxStrIdByPrefix = exports.RTPaperRela_GetRecCountByCond_Cache = exports.RTPaperRela_GetRecCountByCondAsync = exports.RTPaperRela_IsExistAsync = exports.RTPaperRela_IsExist_Cache = exports.RTPaperRela_IsExist = exports.RTPaperRela_IsExistRecordAsync = exports.RTPaperRela_IsExistRecord_Cache = exports.RTPaperRela_UpdateWithConditionAsync = exports.RTPaperRela_UpdateRecordAsync = exports.RTPaperRela_AddNewRecordWithReturnKey = exports.RTPaperRela_AddNewRecordWithReturnKeyAsync = exports.RTPaperRela_AddNewRecordAsync = exports.RTPaperRela_DelRTPaperRelasByCondAsync = exports.RTPaperRela_DelRTPaperRelasAsync = exports.RTPaperRela_DelRecordAsync = exports.RTPaperRela_GetObjLstByPagerAsync = exports.RTPaperRela_GetObjLstByPager_Cache = exports.RTPaperRela_GetObjLstByRange = exports.RTPaperRela_GetObjLstByRangeAsync = exports.RTPaperRela_GetTopObjLstAsync = exports.RTPaperRela_GetObjLstBymIdLst_Cache = exports.RTPaperRela_GetObjLstBymIdLstAsync = exports.RTPaperRela_GetSubObjLst_Cache = exports.RTPaperRela_GetObjLst_PureCache = exports.RTPaperRela_GetObjLst_Cache = exports.RTPaperRela_GetObjLst_sessionStorage_PureCache = exports.RTPaperRela_GetObjLst_sessionStorage = exports.RTPaperRela_GetObjLstAsync = exports.RTPaperRela_GetObjLst_localStorage_PureCache = exports.RTPaperRela_GetObjLst_localStorage = exports.RTPaperRela_GetObjLst_ClientCache = exports.RTPaperRela_GetFirstObjAsync = exports.RTPaperRela_GetFirstID = exports.RTPaperRela_GetFirstIDAsync = exports.RTPaperRela_FilterFunByKey = exports.RTPaperRela_SortFunByKey = exports.RTPaperRela_SortFun_Defa_2Fld = exports.RTPaperRela_SortFun_Defa = exports.RTPaperRela_func = exports.RTPaperRela_UpdateObjInLst_Cache = exports.RTPaperRela_GetObjBymId_localStorage = exports.RTPaperRela_GetObjBymId_Cache = exports.RTPaperRela_GetObjBymIdAsync = exports.rTPaperRela_ConstructorName = exports.rTPaperRela_Controller = void 0;
    /**
     * RTPaperRela(RTPaperRela)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2022年11月02日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsRTPaperRelaEN_js_1 = require("../../L0_Entity/GraduateEduTopic/clsRTPaperRelaEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    const CacheHelper_js_2 = require("../../PubFun/CacheHelper.js");
    const jsString_js_1 = require("../../PubFun/jsString.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.rTPaperRela_Controller = "RTPaperRelaApi";
    exports.rTPaperRela_ConstructorName = "rTPaperRela";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param lngmId:关键字
    * @returns 对象
    **/
    async function RTPaperRela_GetObjBymIdAsync(lngmId) {
        const strThisFuncName = "GetObjBymIdAsync";
        if (lngmId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngmId]不能为空！(In GetObjBymIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjBymId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTPaperRela_Controller, strAction);
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
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.rTPaperRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objRTPaperRela = RTPaperRela_GetObjFromJsonObj(returnObj);
                return objRTPaperRela;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTPaperRela_GetObjBymIdAsync = RTPaperRela_GetObjBymIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param lngmId:所给的关键字
     * @returns 对象
    */
    async function RTPaperRela_GetObjBymId_Cache(lngmId, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjBymId_Cache";
        if (lngmId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngmId]不能为空！(In GetObjBymId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        const arrRTPaperRelaObjLst_Cache = await RTPaperRela_GetObjLst_Cache();
        try {
            const arrRTPaperRela_Sel = arrRTPaperRelaObjLst_Cache.filter(x => x.mId == lngmId);
            let objRTPaperRela;
            if (arrRTPaperRela_Sel.length > 0) {
                objRTPaperRela = arrRTPaperRela_Sel[0];
                return objRTPaperRela;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    objRTPaperRela = await RTPaperRela_GetObjBymIdAsync(lngmId);
                    if (objRTPaperRela != null) {
                        RTPaperRela_ReFreshThisCache();
                        return objRTPaperRela;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngmId, exports.rTPaperRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.RTPaperRela_GetObjBymId_Cache = RTPaperRela_GetObjBymId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param lngmId:所给的关键字
     * @returns 对象
    */
    async function RTPaperRela_GetObjBymId_localStorage(lngmId) {
        const strThisFuncName = "GetObjBymId_localStorage";
        if (lngmId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngmId]不能为空！(In GetObjBymId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsRTPaperRelaEN_js_1.clsRTPaperRelaEN._CurrTabName, lngmId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objRTPaperRela_Cache = JSON.parse(strTempObj);
            return objRTPaperRela_Cache;
        }
        try {
            const objRTPaperRela = await RTPaperRela_GetObjBymIdAsync(lngmId);
            if (objRTPaperRela != null) {
                localStorage.setItem(strKey, JSON.stringify(objRTPaperRela));
                const strInfo = (0, clsString_js_1.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objRTPaperRela;
            }
            return objRTPaperRela;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngmId, exports.rTPaperRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.RTPaperRela_GetObjBymId_localStorage = RTPaperRela_GetObjBymId_localStorage;
    /**
     * 修改在缓存对象列表中的对象, 与后台数据库无关.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
     * @param objRTPaperRela:所给的对象
     * @returns 对象
    */
    async function RTPaperRela_UpdateObjInLst_Cache(objRTPaperRela) {
        const strThisFuncName = "UpdateObjInLst_Cache";
        try {
            const arrRTPaperRelaObjLst_Cache = await RTPaperRela_GetObjLst_Cache();
            const obj = arrRTPaperRelaObjLst_Cache.find(x => x.mId == objRTPaperRela.mId);
            if (obj != null) {
                objRTPaperRela.mId = obj.mId;
                (0, clsCommFunc4Web_js_1.ObjectAssign)(obj, objRTPaperRela);
            }
            else {
                arrRTPaperRelaObjLst_Cache.push(objRTPaperRela);
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, exports.rTPaperRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.RTPaperRela_UpdateObjInLst_Cache = RTPaperRela_UpdateObjInLst_Cache;
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
    async function RTPaperRela_func(strInFldName, strOutFldName, strInValue) {
        //const strThisFuncName = "func";
        if (strInFldName != clsRTPaperRelaEN_js_1.clsRTPaperRelaEN.con_mId) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsRTPaperRelaEN_js_1.clsRTPaperRelaEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_1.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strInFldName, clsRTPaperRelaEN_js_1.clsRTPaperRelaEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const lngmId = Number(strInValue);
        if (lngmId == 0) {
            return "";
        }
        const objRTPaperRela = await RTPaperRela_GetObjBymId_Cache(lngmId);
        if (objRTPaperRela == null)
            return "";
        return objRTPaperRela.GetFldValue(strOutFldName).toString();
    }
    exports.RTPaperRela_func = RTPaperRela_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function RTPaperRela_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.mId - b.mId;
    }
    exports.RTPaperRela_SortFun_Defa = RTPaperRela_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function RTPaperRela_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.topicId == b.topicId)
            return a.paperId.localeCompare(b.paperId);
        else
            return a.topicId.localeCompare(b.topicId);
    }
    exports.RTPaperRela_SortFun_Defa_2Fld = RTPaperRela_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function RTPaperRela_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsRTPaperRelaEN_js_1.clsRTPaperRelaEN.con_mId:
                    return (a, b) => {
                        return a.mId - b.mId;
                    };
                case clsRTPaperRelaEN_js_1.clsRTPaperRelaEN.con_TopicId:
                    return (a, b) => {
                        return a.topicId.localeCompare(b.topicId);
                    };
                case clsRTPaperRelaEN_js_1.clsRTPaperRelaEN.con_PaperId:
                    return (a, b) => {
                        return a.paperId.localeCompare(b.paperId);
                    };
                case clsRTPaperRelaEN_js_1.clsRTPaperRelaEN.con_UpdDate:
                    return (a, b) => {
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsRTPaperRelaEN_js_1.clsRTPaperRelaEN.con_UpdUser:
                    return (a, b) => {
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsRTPaperRelaEN_js_1.clsRTPaperRelaEN.con_Memo:
                    return (a, b) => {
                        return a.memo.localeCompare(b.memo);
                    };
                case clsRTPaperRelaEN_js_1.clsRTPaperRelaEN.con_id_CurrEduCls:
                    return (a, b) => {
                        return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[RTPaperRela]中不存在！(in ${exports.rTPaperRela_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsRTPaperRelaEN_js_1.clsRTPaperRelaEN.con_mId:
                    return (a, b) => {
                        return b.mId - a.mId;
                    };
                case clsRTPaperRelaEN_js_1.clsRTPaperRelaEN.con_TopicId:
                    return (a, b) => {
                        return b.topicId.localeCompare(a.topicId);
                    };
                case clsRTPaperRelaEN_js_1.clsRTPaperRelaEN.con_PaperId:
                    return (a, b) => {
                        return b.paperId.localeCompare(a.paperId);
                    };
                case clsRTPaperRelaEN_js_1.clsRTPaperRelaEN.con_UpdDate:
                    return (a, b) => {
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsRTPaperRelaEN_js_1.clsRTPaperRelaEN.con_UpdUser:
                    return (a, b) => {
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsRTPaperRelaEN_js_1.clsRTPaperRelaEN.con_Memo:
                    return (a, b) => {
                        return b.memo.localeCompare(a.memo);
                    };
                case clsRTPaperRelaEN_js_1.clsRTPaperRelaEN.con_id_CurrEduCls:
                    return (a, b) => {
                        return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[RTPaperRela]中不存在！(in ${exports.rTPaperRela_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.RTPaperRela_SortFunByKey = RTPaperRela_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function RTPaperRela_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsRTPaperRelaEN_js_1.clsRTPaperRelaEN.con_mId:
                return (obj) => {
                    return obj.mId === value;
                };
            case clsRTPaperRelaEN_js_1.clsRTPaperRelaEN.con_TopicId:
                return (obj) => {
                    return obj.topicId === value;
                };
            case clsRTPaperRelaEN_js_1.clsRTPaperRelaEN.con_PaperId:
                return (obj) => {
                    return obj.paperId === value;
                };
            case clsRTPaperRelaEN_js_1.clsRTPaperRelaEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsRTPaperRelaEN_js_1.clsRTPaperRelaEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsRTPaperRelaEN_js_1.clsRTPaperRelaEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            case clsRTPaperRelaEN_js_1.clsRTPaperRelaEN.con_id_CurrEduCls:
                return (obj) => {
                    return obj.id_CurrEduCls === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[RTPaperRela]中不存在！(in ${exports.rTPaperRela_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.RTPaperRela_FilterFunByKey = RTPaperRela_FilterFunByKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function RTPaperRela_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTPaperRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTPaperRela_GetFirstIDAsync = RTPaperRela_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function RTPaperRela_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTPaperRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTPaperRela_GetFirstID = RTPaperRela_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function RTPaperRela_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTPaperRela_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.rTPaperRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objRTPaperRela = RTPaperRela_GetObjFromJsonObj(returnObj);
                return objRTPaperRela;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTPaperRela_GetFirstObjAsync = RTPaperRela_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function RTPaperRela_GetObjLst_ClientCache() {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsRTPaperRelaEN_js_1.clsRTPaperRelaEN._CurrTabName;
        clsRTPaperRelaEN_js_1.clsRTPaperRelaEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsRTPaperRelaEN_js_1.clsRTPaperRelaEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsRTPaperRelaEN_js_1.clsRTPaperRelaEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsRTPaperRelaEN_js_1.clsRTPaperRelaEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_2.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrRTPaperRelaExObjLst_Cache = CacheHelper_js_2.CacheHelper.Get(strKey);
            const arrRTPaperRelaObjLst_T = RTPaperRela_GetObjLstByJSONObjLst(arrRTPaperRelaExObjLst_Cache);
            return arrRTPaperRelaObjLst_T;
        }
        try {
            const arrRTPaperRelaExObjLst = await RTPaperRela_GetObjLstAsync(strWhereCond);
            CacheHelper_js_2.CacheHelper.Add(strKey, arrRTPaperRelaExObjLst);
            const strInfo = (0, clsString_js_1.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrRTPaperRelaExObjLst.length);
            console.log(strInfo);
            return arrRTPaperRelaExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.rTPaperRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.RTPaperRela_GetObjLst_ClientCache = RTPaperRela_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function RTPaperRela_GetObjLst_localStorage() {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsRTPaperRelaEN_js_1.clsRTPaperRelaEN._CurrTabName;
        clsRTPaperRelaEN_js_1.clsRTPaperRelaEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsRTPaperRelaEN_js_1.clsRTPaperRelaEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsRTPaperRelaEN_js_1.clsRTPaperRelaEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsRTPaperRelaEN_js_1.clsRTPaperRelaEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrRTPaperRelaExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrRTPaperRelaObjLst_T = RTPaperRela_GetObjLstByJSONObjLst(arrRTPaperRelaExObjLst_Cache);
            return arrRTPaperRelaObjLst_T;
        }
        try {
            const arrRTPaperRelaExObjLst = await RTPaperRela_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrRTPaperRelaExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrRTPaperRelaExObjLst.length);
            console.log(strInfo);
            return arrRTPaperRelaExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.rTPaperRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.RTPaperRela_GetObjLst_localStorage = RTPaperRela_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function RTPaperRela_GetObjLst_localStorage_PureCache() {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsRTPaperRelaEN_js_1.clsRTPaperRelaEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrRTPaperRelaObjLst_Cache = JSON.parse(strTempObjLst);
            return arrRTPaperRelaObjLst_Cache;
        }
        else
            return null;
    }
    exports.RTPaperRela_GetObjLst_localStorage_PureCache = RTPaperRela_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function RTPaperRela_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTPaperRela_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.rTPaperRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = RTPaperRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTPaperRela_GetObjLstAsync = RTPaperRela_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function RTPaperRela_GetObjLst_sessionStorage() {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsRTPaperRelaEN_js_1.clsRTPaperRelaEN._CurrTabName;
        clsRTPaperRelaEN_js_1.clsRTPaperRelaEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsRTPaperRelaEN_js_1.clsRTPaperRelaEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsRTPaperRelaEN_js_1.clsRTPaperRelaEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsRTPaperRelaEN_js_1.clsRTPaperRelaEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrRTPaperRelaExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrRTPaperRelaObjLst_T = RTPaperRela_GetObjLstByJSONObjLst(arrRTPaperRelaExObjLst_Cache);
            return arrRTPaperRelaObjLst_T;
        }
        try {
            const arrRTPaperRelaExObjLst = await RTPaperRela_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrRTPaperRelaExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrRTPaperRelaExObjLst.length);
            console.log(strInfo);
            return arrRTPaperRelaExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.rTPaperRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.RTPaperRela_GetObjLst_sessionStorage = RTPaperRela_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function RTPaperRela_GetObjLst_sessionStorage_PureCache() {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsRTPaperRelaEN_js_1.clsRTPaperRelaEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrRTPaperRelaObjLst_Cache = JSON.parse(strTempObjLst);
            return arrRTPaperRelaObjLst_Cache;
        }
        else
            return null;
    }
    exports.RTPaperRela_GetObjLst_sessionStorage_PureCache = RTPaperRela_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function RTPaperRela_GetObjLst_Cache() {
        //const strThisFuncName = "GetObjLst_Cache";
        let arrRTPaperRelaObjLst_Cache;
        switch (clsRTPaperRelaEN_js_1.clsRTPaperRelaEN.CacheModeId) {
            case "04": //sessionStorage
                arrRTPaperRelaObjLst_Cache = await RTPaperRela_GetObjLst_sessionStorage();
                break;
            case "03": //localStorage
                arrRTPaperRelaObjLst_Cache = await RTPaperRela_GetObjLst_localStorage();
                break;
            case "02": //ClientCache
                arrRTPaperRelaObjLst_Cache = await RTPaperRela_GetObjLst_ClientCache();
                break;
            default:
                arrRTPaperRelaObjLst_Cache = await RTPaperRela_GetObjLst_ClientCache();
                break;
        }
        const arrRTPaperRelaObjLst = RTPaperRela_GetObjLstByJSONObjLst(arrRTPaperRelaObjLst_Cache);
        return arrRTPaperRelaObjLst_Cache;
    }
    exports.RTPaperRela_GetObjLst_Cache = RTPaperRela_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function RTPaperRela_GetObjLst_PureCache() {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrRTPaperRelaObjLst_Cache;
        switch (clsRTPaperRelaEN_js_1.clsRTPaperRelaEN.CacheModeId) {
            case "04": //sessionStorage
                arrRTPaperRelaObjLst_Cache = await RTPaperRela_GetObjLst_sessionStorage_PureCache();
                break;
            case "03": //localStorage
                arrRTPaperRelaObjLst_Cache = await RTPaperRela_GetObjLst_localStorage_PureCache();
                break;
            case "02": //ClientCache
                arrRTPaperRelaObjLst_Cache = null;
                break;
            default:
                arrRTPaperRelaObjLst_Cache = null;
                break;
        }
        return arrRTPaperRelaObjLst_Cache;
    }
    exports.RTPaperRela_GetObjLst_PureCache = RTPaperRela_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objlngmId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function RTPaperRela_GetSubObjLst_Cache(objRTPaperRela_Cond) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrRTPaperRelaObjLst_Cache = await RTPaperRela_GetObjLst_Cache();
        let arrRTPaperRela_Sel = arrRTPaperRelaObjLst_Cache;
        if (objRTPaperRela_Cond.sf_FldComparisonOp == null || objRTPaperRela_Cond.sf_FldComparisonOp == "")
            return arrRTPaperRela_Sel;
        const dicFldComparisonOp = JSON.parse(objRTPaperRela_Cond.sf_FldComparisonOp);
        //console.log("clsRTPaperRelaWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objRTPaperRela_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrRTPaperRela_Sel = arrRTPaperRela_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objRTPaperRela_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrRTPaperRela_Sel = arrRTPaperRela_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrRTPaperRela_Sel = arrRTPaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrRTPaperRela_Sel = arrRTPaperRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrRTPaperRela_Sel = arrRTPaperRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrRTPaperRela_Sel = arrRTPaperRela_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrRTPaperRela_Sel = arrRTPaperRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrRTPaperRela_Sel = arrRTPaperRela_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrRTPaperRela_Sel = arrRTPaperRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrRTPaperRela_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objRTPaperRela_Cond), exports.rTPaperRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.RTPaperRela_GetSubObjLst_Cache = RTPaperRela_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrmId:关键字列表
    * @returns 对象列表
    **/
    async function RTPaperRela_GetObjLstBymIdLstAsync(arrmId) {
        const strThisFuncName = "GetObjLstBymIdLstAsync";
        const strAction = "GetObjLstBymIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTPaperRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrmId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.rTPaperRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = RTPaperRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTPaperRela_GetObjLstBymIdLstAsync = RTPaperRela_GetObjLstBymIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrlngmIdLst:关键字列表
     * @returns 对象列表
    */
    async function RTPaperRela_GetObjLstBymIdLst_Cache(arrmIdLst) {
        const strThisFuncName = "GetObjLstBymIdLst_Cache";
        try {
            const arrRTPaperRelaObjLst_Cache = await RTPaperRela_GetObjLst_Cache();
            const arrRTPaperRela_Sel = arrRTPaperRelaObjLst_Cache.filter(x => arrmIdLst.indexOf(x.mId) > -1);
            return arrRTPaperRela_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrmIdLst.join(","), exports.rTPaperRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.RTPaperRela_GetObjLstBymIdLst_Cache = RTPaperRela_GetObjLstBymIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function RTPaperRela_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTPaperRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.rTPaperRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = RTPaperRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTPaperRela_GetTopObjLstAsync = RTPaperRela_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function RTPaperRela_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTPaperRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.rTPaperRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = RTPaperRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTPaperRela_GetObjLstByRangeAsync = RTPaperRela_GetObjLstByRangeAsync;
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
    async function RTPaperRela_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTPaperRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTPaperRela_GetObjLstByRange = RTPaperRela_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function RTPaperRela_GetObjLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const arrRTPaperRelaObjLst_Cache = await RTPaperRela_GetObjLst_Cache();
        if (arrRTPaperRelaObjLst_Cache.length == 0)
            return arrRTPaperRelaObjLst_Cache;
        let arrRTPaperRela_Sel = arrRTPaperRelaObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objRTPaperRela_Cond = new clsRTPaperRelaEN_js_1.clsRTPaperRelaEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objRTPaperRela_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsRTPaperRelaWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrRTPaperRela_Sel = arrRTPaperRela_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objRTPaperRela_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrRTPaperRela_Sel = arrRTPaperRela_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrRTPaperRela_Sel = arrRTPaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrRTPaperRela_Sel = arrRTPaperRela_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrRTPaperRela_Sel = arrRTPaperRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrRTPaperRela_Sel = arrRTPaperRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrRTPaperRela_Sel = arrRTPaperRela_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrRTPaperRela_Sel = arrRTPaperRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrRTPaperRela_Sel = arrRTPaperRela_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrRTPaperRela_Sel = arrRTPaperRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrRTPaperRela_Sel.length == 0)
                return arrRTPaperRela_Sel;
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
                arrRTPaperRela_Sel = arrRTPaperRela_Sel.sort(RTPaperRela_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrRTPaperRela_Sel = arrRTPaperRela_Sel.sort(objPagerPara.sortFun);
            }
            arrRTPaperRela_Sel = arrRTPaperRela_Sel.slice(intStart, intEnd);
            return arrRTPaperRela_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.rTPaperRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.RTPaperRela_GetObjLstByPager_Cache = RTPaperRela_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function RTPaperRela_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTPaperRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.rTPaperRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = RTPaperRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTPaperRela_GetObjLstByPagerAsync = RTPaperRela_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param lngmId:关键字
    * @returns 获取删除的结果
    **/
    async function RTPaperRela_DelRecordAsync(lngmId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTPaperRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTPaperRela_DelRecordAsync = RTPaperRela_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrmId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function RTPaperRela_DelRTPaperRelasAsync(arrmId) {
        const strThisFuncName = "DelRTPaperRelasAsync";
        const strAction = "DelRTPaperRelas";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTPaperRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTPaperRela_DelRTPaperRelasAsync = RTPaperRela_DelRTPaperRelasAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function RTPaperRela_DelRTPaperRelasByCondAsync(strWhereCond) {
        const strThisFuncName = "DelRTPaperRelasByCondAsync";
        const strAction = "DelRTPaperRelasByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTPaperRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTPaperRela_DelRTPaperRelasByCondAsync = RTPaperRela_DelRTPaperRelasByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objRTPaperRelaEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function RTPaperRela_AddNewRecordAsync(objRTPaperRelaEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objRTPaperRelaEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTPaperRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRTPaperRelaEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTPaperRela_AddNewRecordAsync = RTPaperRela_AddNewRecordAsync;
    /* 数据类型不是字符型，不可以最大关键字的方式添加记录。*/
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objRTPaperRelaEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function RTPaperRela_AddNewRecordWithReturnKeyAsync(objRTPaperRelaEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTPaperRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRTPaperRelaEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTPaperRela_AddNewRecordWithReturnKeyAsync = RTPaperRela_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objRTPaperRelaEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function RTPaperRela_AddNewRecordWithReturnKey(objRTPaperRelaEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objRTPaperRelaEN.mId === null || objRTPaperRelaEN.mId === 0) {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTPaperRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRTPaperRelaEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTPaperRela_AddNewRecordWithReturnKey = RTPaperRela_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objRTPaperRelaEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function RTPaperRela_UpdateRecordAsync(objRTPaperRelaEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objRTPaperRelaEN.sf_UpdFldSetStr === undefined || objRTPaperRelaEN.sf_UpdFldSetStr === null || objRTPaperRelaEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objRTPaperRelaEN.mId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTPaperRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRTPaperRelaEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTPaperRela_UpdateRecordAsync = RTPaperRela_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objRTPaperRelaEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function RTPaperRela_UpdateWithConditionAsync(objRTPaperRelaEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objRTPaperRelaEN.sf_UpdFldSetStr === undefined || objRTPaperRelaEN.sf_UpdFldSetStr === null || objRTPaperRelaEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objRTPaperRelaEN.mId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTPaperRela_Controller, strAction);
        objRTPaperRelaEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objRTPaperRelaEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTPaperRela_UpdateWithConditionAsync = RTPaperRela_UpdateWithConditionAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objlngmId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function RTPaperRela_IsExistRecord_Cache(objRTPaperRela_Cond) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrRTPaperRelaObjLst_Cache = await RTPaperRela_GetObjLst_Cache();
        if (arrRTPaperRelaObjLst_Cache == null)
            return false;
        let arrRTPaperRela_Sel = arrRTPaperRelaObjLst_Cache;
        if (objRTPaperRela_Cond.sf_FldComparisonOp == null || objRTPaperRela_Cond.sf_FldComparisonOp == "")
            return arrRTPaperRela_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objRTPaperRela_Cond.sf_FldComparisonOp);
        //console.log("clsRTPaperRelaWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objRTPaperRela_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objRTPaperRela_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrRTPaperRela_Sel = arrRTPaperRela_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrRTPaperRela_Sel = arrRTPaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrRTPaperRela_Sel = arrRTPaperRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrRTPaperRela_Sel = arrRTPaperRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrRTPaperRela_Sel = arrRTPaperRela_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrRTPaperRela_Sel = arrRTPaperRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrRTPaperRela_Sel = arrRTPaperRela_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrRTPaperRela_Sel = arrRTPaperRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrRTPaperRela_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objRTPaperRela_Cond), exports.rTPaperRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.RTPaperRela_IsExistRecord_Cache = RTPaperRela_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function RTPaperRela_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTPaperRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTPaperRela_IsExistRecordAsync = RTPaperRela_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param lngmId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function RTPaperRela_IsExist(lngmId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTPaperRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTPaperRela_IsExist = RTPaperRela_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param lngmId:所给的关键字
     * @returns 对象
    */
    async function RTPaperRela_IsExist_Cache(lngmId) {
        const strThisFuncName = "IsExist_Cache";
        const arrRTPaperRelaObjLst_Cache = await RTPaperRela_GetObjLst_Cache();
        if (arrRTPaperRelaObjLst_Cache == null)
            return false;
        try {
            const arrRTPaperRela_Sel = arrRTPaperRelaObjLst_Cache.filter(x => x.mId == lngmId);
            if (arrRTPaperRela_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", lngmId, exports.rTPaperRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.RTPaperRela_IsExist_Cache = RTPaperRela_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param lngmId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function RTPaperRela_IsExistAsync(lngmId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTPaperRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTPaperRela_IsExistAsync = RTPaperRela_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function RTPaperRela_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTPaperRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTPaperRela_GetRecCountByCondAsync = RTPaperRela_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objRTPaperRela_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function RTPaperRela_GetRecCountByCond_Cache(objRTPaperRela_Cond) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrRTPaperRelaObjLst_Cache = await RTPaperRela_GetObjLst_Cache();
        if (arrRTPaperRelaObjLst_Cache == null)
            return 0;
        let arrRTPaperRela_Sel = arrRTPaperRelaObjLst_Cache;
        if (objRTPaperRela_Cond.sf_FldComparisonOp == null || objRTPaperRela_Cond.sf_FldComparisonOp == "")
            return arrRTPaperRela_Sel.length;
        const dicFldComparisonOp = JSON.parse(objRTPaperRela_Cond.sf_FldComparisonOp);
        //console.log("clsRTPaperRelaWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objRTPaperRela_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrRTPaperRela_Sel = arrRTPaperRela_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objRTPaperRela_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrRTPaperRela_Sel = arrRTPaperRela_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrRTPaperRela_Sel = arrRTPaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrRTPaperRela_Sel = arrRTPaperRela_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrRTPaperRela_Sel = arrRTPaperRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrRTPaperRela_Sel = arrRTPaperRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrRTPaperRela_Sel = arrRTPaperRela_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrRTPaperRela_Sel = arrRTPaperRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrRTPaperRela_Sel = arrRTPaperRela_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrRTPaperRela_Sel = arrRTPaperRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrRTPaperRela_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objRTPaperRela_Cond), exports.rTPaperRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.RTPaperRela_GetRecCountByCond_Cache = RTPaperRela_GetRecCountByCond_Cache;
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
    async function RTPaperRela_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTPaperRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTPaperRela_GetMaxStrIdByPrefix = RTPaperRela_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function RTPaperRela_GetWebApiUrl(strController, strAction) {
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
    exports.RTPaperRela_GetWebApiUrl = RTPaperRela_GetWebApiUrl;
    /**
    * 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshCache)
    **/
    function RTPaperRela_ReFreshCache() {
        const strThisFuncName = "ReFreshCache";
        const strMsg = (0, clsString_js_1.Format)("刷新缓存成功！");
        console.trace(strMsg);
        // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
        const strKey = clsRTPaperRelaEN_js_1.clsRTPaperRelaEN._CurrTabName;
        switch (clsRTPaperRelaEN_js_1.clsRTPaperRelaEN.CacheModeId) {
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
    exports.RTPaperRela_ReFreshCache = RTPaperRela_ReFreshCache;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function RTPaperRela_ReFreshThisCache() {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = clsRTPaperRelaEN_js_1.clsRTPaperRelaEN._CurrTabName;
            switch (clsRTPaperRelaEN_js_1.clsRTPaperRelaEN.CacheModeId) {
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
    exports.RTPaperRela_ReFreshThisCache = RTPaperRela_ReFreshThisCache;
    /* 该表的下拉框功能没有设置，不需要生成下拉框绑定函数。*/
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function RTPaperRela_CheckPropertyNew(pobjRTPaperRelaEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTPaperRelaEN.topicId) == false && (0, clsString_js_1.GetStrLen)(pobjRTPaperRelaEN.topicId) > 8) {
            throw new Error("(errid:Watl000059)字段[主题Id(topicId)]的长度不能超过8(In RTPaperRela(RTPaperRela))!值:$(pobjRTPaperRelaEN.topicId)(clsRTPaperRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTPaperRelaEN.paperId) == false && (0, clsString_js_1.GetStrLen)(pobjRTPaperRelaEN.paperId) > 8) {
            throw new Error("(errid:Watl000059)字段[论文Id(paperId)]的长度不能超过8(In RTPaperRela(RTPaperRela))!值:$(pobjRTPaperRelaEN.paperId)(clsRTPaperRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTPaperRelaEN.updDate) == false && (0, clsString_js_1.GetStrLen)(pobjRTPaperRelaEN.updDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In RTPaperRela(RTPaperRela))!值:$(pobjRTPaperRelaEN.updDate)(clsRTPaperRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTPaperRelaEN.updUser) == false && (0, clsString_js_1.GetStrLen)(pobjRTPaperRelaEN.updUser) > 20) {
            throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In RTPaperRela(RTPaperRela))!值:$(pobjRTPaperRelaEN.updUser)(clsRTPaperRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTPaperRelaEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjRTPaperRelaEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In RTPaperRela(RTPaperRela))!值:$(pobjRTPaperRelaEN.memo)(clsRTPaperRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTPaperRelaEN.id_CurrEduCls) == false && (0, clsString_js_1.GetStrLen)(pobjRTPaperRelaEN.id_CurrEduCls) > 8) {
            throw new Error("(errid:Watl000059)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In RTPaperRela(RTPaperRela))!值:$(pobjRTPaperRelaEN.id_CurrEduCls)(clsRTPaperRelaBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if (null != pobjRTPaperRelaEN.mId && undefined !== pobjRTPaperRelaEN.mId && jsString_js_1.tzDataType.isNumber(pobjRTPaperRelaEN.mId) === false) {
            throw new Error("(errid:Watl000060)字段[mId(mId)]的值:[$(pobjRTPaperRelaEN.mId)], 非法，应该为数值型(In RTPaperRela(RTPaperRela))!(clsRTPaperRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTPaperRelaEN.topicId) == false && undefined !== pobjRTPaperRelaEN.topicId && jsString_js_1.tzDataType.isString(pobjRTPaperRelaEN.topicId) === false) {
            throw new Error("(errid:Watl000060)字段[主题Id(topicId)]的值:[$(pobjRTPaperRelaEN.topicId)], 非法，应该为字符型(In RTPaperRela(RTPaperRela))!(clsRTPaperRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTPaperRelaEN.paperId) == false && undefined !== pobjRTPaperRelaEN.paperId && jsString_js_1.tzDataType.isString(pobjRTPaperRelaEN.paperId) === false) {
            throw new Error("(errid:Watl000060)字段[论文Id(paperId)]的值:[$(pobjRTPaperRelaEN.paperId)], 非法，应该为字符型(In RTPaperRela(RTPaperRela))!(clsRTPaperRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTPaperRelaEN.updDate) == false && undefined !== pobjRTPaperRelaEN.updDate && jsString_js_1.tzDataType.isString(pobjRTPaperRelaEN.updDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjRTPaperRelaEN.updDate)], 非法，应该为字符型(In RTPaperRela(RTPaperRela))!(clsRTPaperRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTPaperRelaEN.updUser) == false && undefined !== pobjRTPaperRelaEN.updUser && jsString_js_1.tzDataType.isString(pobjRTPaperRelaEN.updUser) === false) {
            throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjRTPaperRelaEN.updUser)], 非法，应该为字符型(In RTPaperRela(RTPaperRela))!(clsRTPaperRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTPaperRelaEN.memo) == false && undefined !== pobjRTPaperRelaEN.memo && jsString_js_1.tzDataType.isString(pobjRTPaperRelaEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjRTPaperRelaEN.memo)], 非法，应该为字符型(In RTPaperRela(RTPaperRela))!(clsRTPaperRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTPaperRelaEN.id_CurrEduCls) == false && undefined !== pobjRTPaperRelaEN.id_CurrEduCls && jsString_js_1.tzDataType.isString(pobjRTPaperRelaEN.id_CurrEduCls) === false) {
            throw new Error("(errid:Watl000060)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjRTPaperRelaEN.id_CurrEduCls)], 非法，应该为字符型(In RTPaperRela(RTPaperRela))!(clsRTPaperRelaBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTPaperRelaEN.topicId) == false && (0, clsString_js_1.GetStrLen)(pobjRTPaperRelaEN.topicId) != 8) {
            throw ("(errid:Watl000061)字段[主题Id]作为外键字段,长度应该为8(In RTPaperRela)!(clsRTPaperRelaBL:CheckPropertyNew)");
        }
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjRTPaperRelaEN.SetIsCheckProperty(true);
    }
    exports.RTPaperRela_CheckPropertyNew = RTPaperRela_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function RTPaperRela_CheckProperty4Update(pobjRTPaperRelaEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTPaperRelaEN.topicId) == false && (0, clsString_js_1.GetStrLen)(pobjRTPaperRelaEN.topicId) > 8) {
            throw new Error("(errid:Watl000062)字段[主题Id(topicId)]的长度不能超过8(In RTPaperRela(RTPaperRela))!值:$(pobjRTPaperRelaEN.topicId)(clsRTPaperRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTPaperRelaEN.paperId) == false && (0, clsString_js_1.GetStrLen)(pobjRTPaperRelaEN.paperId) > 8) {
            throw new Error("(errid:Watl000062)字段[论文Id(paperId)]的长度不能超过8(In RTPaperRela(RTPaperRela))!值:$(pobjRTPaperRelaEN.paperId)(clsRTPaperRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTPaperRelaEN.updDate) == false && (0, clsString_js_1.GetStrLen)(pobjRTPaperRelaEN.updDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In RTPaperRela(RTPaperRela))!值:$(pobjRTPaperRelaEN.updDate)(clsRTPaperRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTPaperRelaEN.updUser) == false && (0, clsString_js_1.GetStrLen)(pobjRTPaperRelaEN.updUser) > 20) {
            throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In RTPaperRela(RTPaperRela))!值:$(pobjRTPaperRelaEN.updUser)(clsRTPaperRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTPaperRelaEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjRTPaperRelaEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In RTPaperRela(RTPaperRela))!值:$(pobjRTPaperRelaEN.memo)(clsRTPaperRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTPaperRelaEN.id_CurrEduCls) == false && (0, clsString_js_1.GetStrLen)(pobjRTPaperRelaEN.id_CurrEduCls) > 8) {
            throw new Error("(errid:Watl000062)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In RTPaperRela(RTPaperRela))!值:$(pobjRTPaperRelaEN.id_CurrEduCls)(clsRTPaperRelaBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if (null != pobjRTPaperRelaEN.mId && undefined !== pobjRTPaperRelaEN.mId && jsString_js_1.tzDataType.isNumber(pobjRTPaperRelaEN.mId) === false) {
            throw new Error("(errid:Watl000063)字段[mId(mId)]的值:[$(pobjRTPaperRelaEN.mId)], 非法，应该为数值型(In RTPaperRela(RTPaperRela))!(clsRTPaperRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTPaperRelaEN.topicId) == false && undefined !== pobjRTPaperRelaEN.topicId && jsString_js_1.tzDataType.isString(pobjRTPaperRelaEN.topicId) === false) {
            throw new Error("(errid:Watl000063)字段[主题Id(topicId)]的值:[$(pobjRTPaperRelaEN.topicId)], 非法，应该为字符型(In RTPaperRela(RTPaperRela))!(clsRTPaperRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTPaperRelaEN.paperId) == false && undefined !== pobjRTPaperRelaEN.paperId && jsString_js_1.tzDataType.isString(pobjRTPaperRelaEN.paperId) === false) {
            throw new Error("(errid:Watl000063)字段[论文Id(paperId)]的值:[$(pobjRTPaperRelaEN.paperId)], 非法，应该为字符型(In RTPaperRela(RTPaperRela))!(clsRTPaperRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTPaperRelaEN.updDate) == false && undefined !== pobjRTPaperRelaEN.updDate && jsString_js_1.tzDataType.isString(pobjRTPaperRelaEN.updDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjRTPaperRelaEN.updDate)], 非法，应该为字符型(In RTPaperRela(RTPaperRela))!(clsRTPaperRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTPaperRelaEN.updUser) == false && undefined !== pobjRTPaperRelaEN.updUser && jsString_js_1.tzDataType.isString(pobjRTPaperRelaEN.updUser) === false) {
            throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjRTPaperRelaEN.updUser)], 非法，应该为字符型(In RTPaperRela(RTPaperRela))!(clsRTPaperRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTPaperRelaEN.memo) == false && undefined !== pobjRTPaperRelaEN.memo && jsString_js_1.tzDataType.isString(pobjRTPaperRelaEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjRTPaperRelaEN.memo)], 非法，应该为字符型(In RTPaperRela(RTPaperRela))!(clsRTPaperRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTPaperRelaEN.id_CurrEduCls) == false && undefined !== pobjRTPaperRelaEN.id_CurrEduCls && jsString_js_1.tzDataType.isString(pobjRTPaperRelaEN.id_CurrEduCls) === false) {
            throw new Error("(errid:Watl000063)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjRTPaperRelaEN.id_CurrEduCls)], 非法，应该为字符型(In RTPaperRela(RTPaperRela))!(clsRTPaperRelaBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if (null === pobjRTPaperRelaEN.mId
            || pobjRTPaperRelaEN.mId != null && pobjRTPaperRelaEN.mId.toString() === "") {
            throw new Error("(errid:Watl000064)字段[mId]不能为空(In RTPaperRela)!(clsRTPaperRelaBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTPaperRelaEN.topicId) == false && (0, clsString_js_1.GetStrLen)(pobjRTPaperRelaEN.topicId) != 8) {
            throw ("(errid:Watl000065)字段[主题Id]作为外键字段,长度应该为8(In RTPaperRela)!(clsRTPaperRelaBL:CheckPropertyNew)");
        }
        pobjRTPaperRelaEN.SetIsCheckProperty(true);
    }
    exports.RTPaperRela_CheckProperty4Update = RTPaperRela_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function RTPaperRela_GetJSONStrByObj(pobjRTPaperRelaEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjRTPaperRelaEN.sf_UpdFldSetStr = pobjRTPaperRelaEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjRTPaperRelaEN);
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
    exports.RTPaperRela_GetJSONStrByObj = RTPaperRela_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function RTPaperRela_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrRTPaperRelaObjLst = new Array();
        if (strJSON === "") {
            return arrRTPaperRelaObjLst;
        }
        try {
            arrRTPaperRelaObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrRTPaperRelaObjLst;
        }
        return arrRTPaperRelaObjLst;
    }
    exports.RTPaperRela_GetObjLstByJSONStr = RTPaperRela_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrRTPaperRelaObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function RTPaperRela_GetObjLstByJSONObjLst(arrRTPaperRelaObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrRTPaperRelaObjLst = new Array();
        for (const objInFor of arrRTPaperRelaObjLstS) {
            const obj1 = RTPaperRela_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrRTPaperRelaObjLst.push(obj1);
        }
        return arrRTPaperRelaObjLst;
    }
    exports.RTPaperRela_GetObjLstByJSONObjLst = RTPaperRela_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function RTPaperRela_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjRTPaperRelaEN = new clsRTPaperRelaEN_js_1.clsRTPaperRelaEN();
        if (strJSON === "") {
            return pobjRTPaperRelaEN;
        }
        try {
            pobjRTPaperRelaEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjRTPaperRelaEN;
        }
        return pobjRTPaperRelaEN;
    }
    exports.RTPaperRela_GetObjByJSONStr = RTPaperRela_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function RTPaperRela_GetCombineCondition(objRTPaperRela_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objRTPaperRela_Cond.dicFldComparisonOp, clsRTPaperRelaEN_js_1.clsRTPaperRelaEN.con_mId) == true) {
            const strComparisonOp_mId = objRTPaperRela_Cond.dicFldComparisonOp[clsRTPaperRelaEN_js_1.clsRTPaperRelaEN.con_mId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsRTPaperRelaEN_js_1.clsRTPaperRelaEN.con_mId, objRTPaperRela_Cond.mId, strComparisonOp_mId);
        }
        if (Object.prototype.hasOwnProperty.call(objRTPaperRela_Cond.dicFldComparisonOp, clsRTPaperRelaEN_js_1.clsRTPaperRelaEN.con_TopicId) == true) {
            const strComparisonOp_TopicId = objRTPaperRela_Cond.dicFldComparisonOp[clsRTPaperRelaEN_js_1.clsRTPaperRelaEN.con_TopicId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsRTPaperRelaEN_js_1.clsRTPaperRelaEN.con_TopicId, objRTPaperRela_Cond.topicId, strComparisonOp_TopicId);
        }
        if (Object.prototype.hasOwnProperty.call(objRTPaperRela_Cond.dicFldComparisonOp, clsRTPaperRelaEN_js_1.clsRTPaperRelaEN.con_PaperId) == true) {
            const strComparisonOp_PaperId = objRTPaperRela_Cond.dicFldComparisonOp[clsRTPaperRelaEN_js_1.clsRTPaperRelaEN.con_PaperId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsRTPaperRelaEN_js_1.clsRTPaperRelaEN.con_PaperId, objRTPaperRela_Cond.paperId, strComparisonOp_PaperId);
        }
        if (Object.prototype.hasOwnProperty.call(objRTPaperRela_Cond.dicFldComparisonOp, clsRTPaperRelaEN_js_1.clsRTPaperRelaEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objRTPaperRela_Cond.dicFldComparisonOp[clsRTPaperRelaEN_js_1.clsRTPaperRelaEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsRTPaperRelaEN_js_1.clsRTPaperRelaEN.con_UpdDate, objRTPaperRela_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objRTPaperRela_Cond.dicFldComparisonOp, clsRTPaperRelaEN_js_1.clsRTPaperRelaEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objRTPaperRela_Cond.dicFldComparisonOp[clsRTPaperRelaEN_js_1.clsRTPaperRelaEN.con_UpdUser];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsRTPaperRelaEN_js_1.clsRTPaperRelaEN.con_UpdUser, objRTPaperRela_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objRTPaperRela_Cond.dicFldComparisonOp, clsRTPaperRelaEN_js_1.clsRTPaperRelaEN.con_Memo) == true) {
            const strComparisonOp_Memo = objRTPaperRela_Cond.dicFldComparisonOp[clsRTPaperRelaEN_js_1.clsRTPaperRelaEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsRTPaperRelaEN_js_1.clsRTPaperRelaEN.con_Memo, objRTPaperRela_Cond.memo, strComparisonOp_Memo);
        }
        if (Object.prototype.hasOwnProperty.call(objRTPaperRela_Cond.dicFldComparisonOp, clsRTPaperRelaEN_js_1.clsRTPaperRelaEN.con_id_CurrEduCls) == true) {
            const strComparisonOp_id_CurrEduCls = objRTPaperRela_Cond.dicFldComparisonOp[clsRTPaperRelaEN_js_1.clsRTPaperRelaEN.con_id_CurrEduCls];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsRTPaperRelaEN_js_1.clsRTPaperRelaEN.con_id_CurrEduCls, objRTPaperRela_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
        }
        return strWhereCond;
    }
    exports.RTPaperRela_GetCombineCondition = RTPaperRela_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--RTPaperRela(RTPaperRela),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param lngmId: mId(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function RTPaperRela_GetUniCondStr_mId(objRTPaperRelaEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and mId = '{0}'", objRTPaperRelaEN.mId);
        return strWhereCond;
    }
    exports.RTPaperRela_GetUniCondStr_mId = RTPaperRela_GetUniCondStr_mId;
    /**
    *获取唯一性条件串(Uniqueness)--RTPaperRela(RTPaperRela),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param lngmId: mId(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function RTPaperRela_GetUniCondStr4Update_mId(objRTPaperRelaEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and mId <> '{0}'", objRTPaperRelaEN.mId);
        strWhereCond += (0, clsString_js_1.Format)(" and mId = '{0}'", objRTPaperRelaEN.mId);
        return strWhereCond;
    }
    exports.RTPaperRela_GetUniCondStr4Update_mId = RTPaperRela_GetUniCondStr4Update_mId;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objRTPaperRelaENS:源对象
     * @param objRTPaperRelaENT:目标对象
    */
    function RTPaperRela_CopyObjTo(objRTPaperRelaENS, objRTPaperRelaENT) {
        objRTPaperRelaENT.mId = objRTPaperRelaENS.mId; //mId
        objRTPaperRelaENT.topicId = objRTPaperRelaENS.topicId; //主题Id
        objRTPaperRelaENT.paperId = objRTPaperRelaENS.paperId; //论文Id
        objRTPaperRelaENT.updDate = objRTPaperRelaENS.updDate; //修改日期
        objRTPaperRelaENT.updUser = objRTPaperRelaENS.updUser; //修改人
        objRTPaperRelaENT.memo = objRTPaperRelaENS.memo; //备注
        objRTPaperRelaENT.id_CurrEduCls = objRTPaperRelaENS.id_CurrEduCls; //教学班流水号
        objRTPaperRelaENT.sf_UpdFldSetStr = objRTPaperRelaENS.updFldString; //sf_UpdFldSetStr
    }
    exports.RTPaperRela_CopyObjTo = RTPaperRela_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objRTPaperRelaENS:源对象
     * @param objRTPaperRelaENT:目标对象
    */
    function RTPaperRela_GetObjFromJsonObj(objRTPaperRelaENS) {
        const objRTPaperRelaENT = new clsRTPaperRelaEN_js_1.clsRTPaperRelaEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objRTPaperRelaENT, objRTPaperRelaENS);
        return objRTPaperRelaENT;
    }
    exports.RTPaperRela_GetObjFromJsonObj = RTPaperRela_GetObjFromJsonObj;
});
