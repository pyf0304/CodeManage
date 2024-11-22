/**
* 类名:clsRTSysSocialRelaWApi
* 表名:RTSysSocialRela(01120657)
* 生成代码版本:2022.11.02.1
* 生成日期:2022/11/02 11:46:55
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
        define(["require", "exports", "axios", "../../PubFun/CacheHelper.js", "../../L0_Entity/GraduateEduTopic/clsRTSysSocialRelaEN.js", "../../L3_ForWApi/GraduateEduTopic/clsvRTSysSocialRelaWApi.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsSysPara4WebApi.js", "../../PubFun/CacheHelper.js", "../../PubFun/jsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.RTSysSocialRela_GetObjFromJsonObj = exports.RTSysSocialRela_CopyObjTo = exports.RTSysSocialRela_GetUniCondStr4Update_mId = exports.RTSysSocialRela_GetUniCondStr_mId = exports.RTSysSocialRela_GetCombineCondition = exports.RTSysSocialRela_GetObjByJSONStr = exports.RTSysSocialRela_GetObjLstByJSONObjLst = exports.RTSysSocialRela_GetObjLstByJSONStr = exports.RTSysSocialRela_GetJSONStrByObj = exports.RTSysSocialRela_CheckProperty4Update = exports.RTSysSocialRela_CheckPropertyNew = exports.RTSysSocialRela_ReFreshThisCache = exports.RTSysSocialRela_ReFreshCache = exports.RTSysSocialRela_GetWebApiUrl = exports.RTSysSocialRela_GetMaxStrIdByPrefix = exports.RTSysSocialRela_GetRecCountByCond_Cache = exports.RTSysSocialRela_GetRecCountByCondAsync = exports.RTSysSocialRela_IsExistAsync = exports.RTSysSocialRela_IsExist_Cache = exports.RTSysSocialRela_IsExist = exports.RTSysSocialRela_IsExistRecordAsync = exports.RTSysSocialRela_IsExistRecord_Cache = exports.RTSysSocialRela_UpdateWithConditionAsync = exports.RTSysSocialRela_UpdateRecordAsync = exports.RTSysSocialRela_AddNewRecordWithReturnKey = exports.RTSysSocialRela_AddNewRecordWithReturnKeyAsync = exports.RTSysSocialRela_AddNewRecordAsync = exports.RTSysSocialRela_DelRTSysSocialRelasByCondAsync = exports.RTSysSocialRela_DelRTSysSocialRelasAsync = exports.RTSysSocialRela_DelRecordAsync = exports.RTSysSocialRela_GetObjLstByPagerAsync = exports.RTSysSocialRela_GetObjLstByPager_Cache = exports.RTSysSocialRela_GetObjLstByRange = exports.RTSysSocialRela_GetObjLstByRangeAsync = exports.RTSysSocialRela_GetTopObjLstAsync = exports.RTSysSocialRela_GetObjLstBymIdLst_Cache = exports.RTSysSocialRela_GetObjLstBymIdLstAsync = exports.RTSysSocialRela_GetSubObjLst_Cache = exports.RTSysSocialRela_GetObjLst_PureCache = exports.RTSysSocialRela_GetObjLst_Cache = exports.RTSysSocialRela_GetObjLst_sessionStorage_PureCache = exports.RTSysSocialRela_GetObjLst_sessionStorage = exports.RTSysSocialRela_GetObjLstAsync = exports.RTSysSocialRela_GetObjLst_localStorage_PureCache = exports.RTSysSocialRela_GetObjLst_localStorage = exports.RTSysSocialRela_GetObjLst_ClientCache = exports.RTSysSocialRela_GetFirstObjAsync = exports.RTSysSocialRela_GetFirstID = exports.RTSysSocialRela_GetFirstIDAsync = exports.RTSysSocialRela_FilterFunByKey = exports.RTSysSocialRela_SortFunByKey = exports.RTSysSocialRela_SortFun_Defa_2Fld = exports.RTSysSocialRela_SortFun_Defa = exports.RTSysSocialRela_func = exports.RTSysSocialRela_UpdateObjInLst_Cache = exports.RTSysSocialRela_GetObjBymId_localStorage = exports.RTSysSocialRela_GetObjBymId_Cache = exports.RTSysSocialRela_GetObjBymIdAsync = exports.rTSysSocialRela_ConstructorName = exports.rTSysSocialRela_Controller = void 0;
    /**
     * RTSysSocialRela(RTSysSocialRela)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2022年11月02日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsRTSysSocialRelaEN_js_1 = require("../../L0_Entity/GraduateEduTopic/clsRTSysSocialRelaEN.js");
    const clsvRTSysSocialRelaWApi_js_1 = require("../../L3_ForWApi/GraduateEduTopic/clsvRTSysSocialRelaWApi.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    const CacheHelper_js_2 = require("../../PubFun/CacheHelper.js");
    const jsString_js_1 = require("../../PubFun/jsString.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.rTSysSocialRela_Controller = "RTSysSocialRelaApi";
    exports.rTSysSocialRela_ConstructorName = "rTSysSocialRela";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param lngmId:关键字
    * @returns 对象
    **/
    async function RTSysSocialRela_GetObjBymIdAsync(lngmId) {
        const strThisFuncName = "GetObjBymIdAsync";
        if (lngmId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngmId]不能为空！(In GetObjBymIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjBymId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTSysSocialRela_Controller, strAction);
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
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.rTSysSocialRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objRTSysSocialRela = RTSysSocialRela_GetObjFromJsonObj(returnObj);
                return objRTSysSocialRela;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTSysSocialRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTSysSocialRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTSysSocialRela_GetObjBymIdAsync = RTSysSocialRela_GetObjBymIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param lngmId:所给的关键字
     * @returns 对象
    */
    async function RTSysSocialRela_GetObjBymId_Cache(lngmId, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjBymId_Cache";
        if (lngmId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngmId]不能为空！(In GetObjBymId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        const arrRTSysSocialRelaObjLst_Cache = await RTSysSocialRela_GetObjLst_Cache();
        try {
            const arrRTSysSocialRela_Sel = arrRTSysSocialRelaObjLst_Cache.filter(x => x.mId == lngmId);
            let objRTSysSocialRela;
            if (arrRTSysSocialRela_Sel.length > 0) {
                objRTSysSocialRela = arrRTSysSocialRela_Sel[0];
                return objRTSysSocialRela;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    objRTSysSocialRela = await RTSysSocialRela_GetObjBymIdAsync(lngmId);
                    if (objRTSysSocialRela != null) {
                        RTSysSocialRela_ReFreshThisCache();
                        return objRTSysSocialRela;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngmId, exports.rTSysSocialRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.RTSysSocialRela_GetObjBymId_Cache = RTSysSocialRela_GetObjBymId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param lngmId:所给的关键字
     * @returns 对象
    */
    async function RTSysSocialRela_GetObjBymId_localStorage(lngmId) {
        const strThisFuncName = "GetObjBymId_localStorage";
        if (lngmId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngmId]不能为空！(In GetObjBymId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsRTSysSocialRelaEN_js_1.clsRTSysSocialRelaEN._CurrTabName, lngmId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objRTSysSocialRela_Cache = JSON.parse(strTempObj);
            return objRTSysSocialRela_Cache;
        }
        try {
            const objRTSysSocialRela = await RTSysSocialRela_GetObjBymIdAsync(lngmId);
            if (objRTSysSocialRela != null) {
                localStorage.setItem(strKey, JSON.stringify(objRTSysSocialRela));
                const strInfo = (0, clsString_js_1.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objRTSysSocialRela;
            }
            return objRTSysSocialRela;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngmId, exports.rTSysSocialRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.RTSysSocialRela_GetObjBymId_localStorage = RTSysSocialRela_GetObjBymId_localStorage;
    /**
     * 修改在缓存对象列表中的对象, 与后台数据库无关.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
     * @param objRTSysSocialRela:所给的对象
     * @returns 对象
    */
    async function RTSysSocialRela_UpdateObjInLst_Cache(objRTSysSocialRela) {
        const strThisFuncName = "UpdateObjInLst_Cache";
        try {
            const arrRTSysSocialRelaObjLst_Cache = await RTSysSocialRela_GetObjLst_Cache();
            const obj = arrRTSysSocialRelaObjLst_Cache.find(x => x.mId == objRTSysSocialRela.mId);
            if (obj != null) {
                objRTSysSocialRela.mId = obj.mId;
                (0, clsCommFunc4Web_js_1.ObjectAssign)(obj, objRTSysSocialRela);
            }
            else {
                arrRTSysSocialRelaObjLst_Cache.push(objRTSysSocialRela);
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, exports.rTSysSocialRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.RTSysSocialRela_UpdateObjInLst_Cache = RTSysSocialRela_UpdateObjInLst_Cache;
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
    async function RTSysSocialRela_func(strInFldName, strOutFldName, strInValue) {
        //const strThisFuncName = "func";
        if (strInFldName != clsRTSysSocialRelaEN_js_1.clsRTSysSocialRelaEN.con_mId) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsRTSysSocialRelaEN_js_1.clsRTSysSocialRelaEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_1.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strInFldName, clsRTSysSocialRelaEN_js_1.clsRTSysSocialRelaEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const lngmId = Number(strInValue);
        if (lngmId == 0) {
            return "";
        }
        const objRTSysSocialRela = await RTSysSocialRela_GetObjBymId_Cache(lngmId);
        if (objRTSysSocialRela == null)
            return "";
        return objRTSysSocialRela.GetFldValue(strOutFldName).toString();
    }
    exports.RTSysSocialRela_func = RTSysSocialRela_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function RTSysSocialRela_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.mId - b.mId;
    }
    exports.RTSysSocialRela_SortFun_Defa = RTSysSocialRela_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function RTSysSocialRela_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.topicId == b.topicId)
            return a.socialId.localeCompare(b.socialId);
        else
            return a.topicId.localeCompare(b.topicId);
    }
    exports.RTSysSocialRela_SortFun_Defa_2Fld = RTSysSocialRela_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function RTSysSocialRela_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsRTSysSocialRelaEN_js_1.clsRTSysSocialRelaEN.con_mId:
                    return (a, b) => {
                        return a.mId - b.mId;
                    };
                case clsRTSysSocialRelaEN_js_1.clsRTSysSocialRelaEN.con_TopicId:
                    return (a, b) => {
                        return a.topicId.localeCompare(b.topicId);
                    };
                case clsRTSysSocialRelaEN_js_1.clsRTSysSocialRelaEN.con_SocialId:
                    return (a, b) => {
                        return a.socialId.localeCompare(b.socialId);
                    };
                case clsRTSysSocialRelaEN_js_1.clsRTSysSocialRelaEN.con_UpdDate:
                    return (a, b) => {
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsRTSysSocialRelaEN_js_1.clsRTSysSocialRelaEN.con_UpdUser:
                    return (a, b) => {
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsRTSysSocialRelaEN_js_1.clsRTSysSocialRelaEN.con_Memo:
                    return (a, b) => {
                        return a.memo.localeCompare(b.memo);
                    };
                case clsRTSysSocialRelaEN_js_1.clsRTSysSocialRelaEN.con_ClassificationId:
                    return (a, b) => {
                        return a.classificationId.localeCompare(b.classificationId);
                    };
                case clsRTSysSocialRelaEN_js_1.clsRTSysSocialRelaEN.con_id_CurrEduCls:
                    return (a, b) => {
                        return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[RTSysSocialRela]中不存在！(in ${exports.rTSysSocialRela_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsRTSysSocialRelaEN_js_1.clsRTSysSocialRelaEN.con_mId:
                    return (a, b) => {
                        return b.mId - a.mId;
                    };
                case clsRTSysSocialRelaEN_js_1.clsRTSysSocialRelaEN.con_TopicId:
                    return (a, b) => {
                        return b.topicId.localeCompare(a.topicId);
                    };
                case clsRTSysSocialRelaEN_js_1.clsRTSysSocialRelaEN.con_SocialId:
                    return (a, b) => {
                        return b.socialId.localeCompare(a.socialId);
                    };
                case clsRTSysSocialRelaEN_js_1.clsRTSysSocialRelaEN.con_UpdDate:
                    return (a, b) => {
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsRTSysSocialRelaEN_js_1.clsRTSysSocialRelaEN.con_UpdUser:
                    return (a, b) => {
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsRTSysSocialRelaEN_js_1.clsRTSysSocialRelaEN.con_Memo:
                    return (a, b) => {
                        return b.memo.localeCompare(a.memo);
                    };
                case clsRTSysSocialRelaEN_js_1.clsRTSysSocialRelaEN.con_ClassificationId:
                    return (a, b) => {
                        return b.classificationId.localeCompare(a.classificationId);
                    };
                case clsRTSysSocialRelaEN_js_1.clsRTSysSocialRelaEN.con_id_CurrEduCls:
                    return (a, b) => {
                        return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[RTSysSocialRela]中不存在！(in ${exports.rTSysSocialRela_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.RTSysSocialRela_SortFunByKey = RTSysSocialRela_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function RTSysSocialRela_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsRTSysSocialRelaEN_js_1.clsRTSysSocialRelaEN.con_mId:
                return (obj) => {
                    return obj.mId === value;
                };
            case clsRTSysSocialRelaEN_js_1.clsRTSysSocialRelaEN.con_TopicId:
                return (obj) => {
                    return obj.topicId === value;
                };
            case clsRTSysSocialRelaEN_js_1.clsRTSysSocialRelaEN.con_SocialId:
                return (obj) => {
                    return obj.socialId === value;
                };
            case clsRTSysSocialRelaEN_js_1.clsRTSysSocialRelaEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsRTSysSocialRelaEN_js_1.clsRTSysSocialRelaEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsRTSysSocialRelaEN_js_1.clsRTSysSocialRelaEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            case clsRTSysSocialRelaEN_js_1.clsRTSysSocialRelaEN.con_ClassificationId:
                return (obj) => {
                    return obj.classificationId === value;
                };
            case clsRTSysSocialRelaEN_js_1.clsRTSysSocialRelaEN.con_id_CurrEduCls:
                return (obj) => {
                    return obj.id_CurrEduCls === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[RTSysSocialRela]中不存在！(in ${exports.rTSysSocialRela_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.RTSysSocialRela_FilterFunByKey = RTSysSocialRela_FilterFunByKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function RTSysSocialRela_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTSysSocialRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTSysSocialRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTSysSocialRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTSysSocialRela_GetFirstIDAsync = RTSysSocialRela_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function RTSysSocialRela_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTSysSocialRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTSysSocialRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTSysSocialRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTSysSocialRela_GetFirstID = RTSysSocialRela_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function RTSysSocialRela_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTSysSocialRela_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.rTSysSocialRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objRTSysSocialRela = RTSysSocialRela_GetObjFromJsonObj(returnObj);
                return objRTSysSocialRela;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTSysSocialRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTSysSocialRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTSysSocialRela_GetFirstObjAsync = RTSysSocialRela_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function RTSysSocialRela_GetObjLst_ClientCache() {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsRTSysSocialRelaEN_js_1.clsRTSysSocialRelaEN._CurrTabName;
        clsRTSysSocialRelaEN_js_1.clsRTSysSocialRelaEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsRTSysSocialRelaEN_js_1.clsRTSysSocialRelaEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsRTSysSocialRelaEN_js_1.clsRTSysSocialRelaEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsRTSysSocialRelaEN_js_1.clsRTSysSocialRelaEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_2.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrRTSysSocialRelaExObjLst_Cache = CacheHelper_js_2.CacheHelper.Get(strKey);
            const arrRTSysSocialRelaObjLst_T = RTSysSocialRela_GetObjLstByJSONObjLst(arrRTSysSocialRelaExObjLst_Cache);
            return arrRTSysSocialRelaObjLst_T;
        }
        try {
            const arrRTSysSocialRelaExObjLst = await RTSysSocialRela_GetObjLstAsync(strWhereCond);
            CacheHelper_js_2.CacheHelper.Add(strKey, arrRTSysSocialRelaExObjLst);
            const strInfo = (0, clsString_js_1.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrRTSysSocialRelaExObjLst.length);
            console.log(strInfo);
            return arrRTSysSocialRelaExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.rTSysSocialRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.RTSysSocialRela_GetObjLst_ClientCache = RTSysSocialRela_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function RTSysSocialRela_GetObjLst_localStorage() {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsRTSysSocialRelaEN_js_1.clsRTSysSocialRelaEN._CurrTabName;
        clsRTSysSocialRelaEN_js_1.clsRTSysSocialRelaEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsRTSysSocialRelaEN_js_1.clsRTSysSocialRelaEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsRTSysSocialRelaEN_js_1.clsRTSysSocialRelaEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsRTSysSocialRelaEN_js_1.clsRTSysSocialRelaEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrRTSysSocialRelaExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrRTSysSocialRelaObjLst_T = RTSysSocialRela_GetObjLstByJSONObjLst(arrRTSysSocialRelaExObjLst_Cache);
            return arrRTSysSocialRelaObjLst_T;
        }
        try {
            const arrRTSysSocialRelaExObjLst = await RTSysSocialRela_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrRTSysSocialRelaExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrRTSysSocialRelaExObjLst.length);
            console.log(strInfo);
            return arrRTSysSocialRelaExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.rTSysSocialRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.RTSysSocialRela_GetObjLst_localStorage = RTSysSocialRela_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function RTSysSocialRela_GetObjLst_localStorage_PureCache() {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsRTSysSocialRelaEN_js_1.clsRTSysSocialRelaEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrRTSysSocialRelaObjLst_Cache = JSON.parse(strTempObjLst);
            return arrRTSysSocialRelaObjLst_Cache;
        }
        else
            return null;
    }
    exports.RTSysSocialRela_GetObjLst_localStorage_PureCache = RTSysSocialRela_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function RTSysSocialRela_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTSysSocialRela_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.rTSysSocialRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = RTSysSocialRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTSysSocialRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTSysSocialRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTSysSocialRela_GetObjLstAsync = RTSysSocialRela_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function RTSysSocialRela_GetObjLst_sessionStorage() {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsRTSysSocialRelaEN_js_1.clsRTSysSocialRelaEN._CurrTabName;
        clsRTSysSocialRelaEN_js_1.clsRTSysSocialRelaEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsRTSysSocialRelaEN_js_1.clsRTSysSocialRelaEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsRTSysSocialRelaEN_js_1.clsRTSysSocialRelaEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsRTSysSocialRelaEN_js_1.clsRTSysSocialRelaEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrRTSysSocialRelaExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrRTSysSocialRelaObjLst_T = RTSysSocialRela_GetObjLstByJSONObjLst(arrRTSysSocialRelaExObjLst_Cache);
            return arrRTSysSocialRelaObjLst_T;
        }
        try {
            const arrRTSysSocialRelaExObjLst = await RTSysSocialRela_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrRTSysSocialRelaExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrRTSysSocialRelaExObjLst.length);
            console.log(strInfo);
            return arrRTSysSocialRelaExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.rTSysSocialRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.RTSysSocialRela_GetObjLst_sessionStorage = RTSysSocialRela_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function RTSysSocialRela_GetObjLst_sessionStorage_PureCache() {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsRTSysSocialRelaEN_js_1.clsRTSysSocialRelaEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrRTSysSocialRelaObjLst_Cache = JSON.parse(strTempObjLst);
            return arrRTSysSocialRelaObjLst_Cache;
        }
        else
            return null;
    }
    exports.RTSysSocialRela_GetObjLst_sessionStorage_PureCache = RTSysSocialRela_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function RTSysSocialRela_GetObjLst_Cache() {
        //const strThisFuncName = "GetObjLst_Cache";
        let arrRTSysSocialRelaObjLst_Cache;
        switch (clsRTSysSocialRelaEN_js_1.clsRTSysSocialRelaEN.CacheModeId) {
            case "04": //sessionStorage
                arrRTSysSocialRelaObjLst_Cache = await RTSysSocialRela_GetObjLst_sessionStorage();
                break;
            case "03": //localStorage
                arrRTSysSocialRelaObjLst_Cache = await RTSysSocialRela_GetObjLst_localStorage();
                break;
            case "02": //ClientCache
                arrRTSysSocialRelaObjLst_Cache = await RTSysSocialRela_GetObjLst_ClientCache();
                break;
            default:
                arrRTSysSocialRelaObjLst_Cache = await RTSysSocialRela_GetObjLst_ClientCache();
                break;
        }
        const arrRTSysSocialRelaObjLst = RTSysSocialRela_GetObjLstByJSONObjLst(arrRTSysSocialRelaObjLst_Cache);
        return arrRTSysSocialRelaObjLst_Cache;
    }
    exports.RTSysSocialRela_GetObjLst_Cache = RTSysSocialRela_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function RTSysSocialRela_GetObjLst_PureCache() {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrRTSysSocialRelaObjLst_Cache;
        switch (clsRTSysSocialRelaEN_js_1.clsRTSysSocialRelaEN.CacheModeId) {
            case "04": //sessionStorage
                arrRTSysSocialRelaObjLst_Cache = await RTSysSocialRela_GetObjLst_sessionStorage_PureCache();
                break;
            case "03": //localStorage
                arrRTSysSocialRelaObjLst_Cache = await RTSysSocialRela_GetObjLst_localStorage_PureCache();
                break;
            case "02": //ClientCache
                arrRTSysSocialRelaObjLst_Cache = null;
                break;
            default:
                arrRTSysSocialRelaObjLst_Cache = null;
                break;
        }
        return arrRTSysSocialRelaObjLst_Cache;
    }
    exports.RTSysSocialRela_GetObjLst_PureCache = RTSysSocialRela_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objlngmId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function RTSysSocialRela_GetSubObjLst_Cache(objRTSysSocialRela_Cond) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrRTSysSocialRelaObjLst_Cache = await RTSysSocialRela_GetObjLst_Cache();
        let arrRTSysSocialRela_Sel = arrRTSysSocialRelaObjLst_Cache;
        if (objRTSysSocialRela_Cond.sf_FldComparisonOp == null || objRTSysSocialRela_Cond.sf_FldComparisonOp == "")
            return arrRTSysSocialRela_Sel;
        const dicFldComparisonOp = JSON.parse(objRTSysSocialRela_Cond.sf_FldComparisonOp);
        //console.log("clsRTSysSocialRelaWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objRTSysSocialRela_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrRTSysSocialRela_Sel = arrRTSysSocialRela_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objRTSysSocialRela_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrRTSysSocialRela_Sel = arrRTSysSocialRela_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrRTSysSocialRela_Sel = arrRTSysSocialRela_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrRTSysSocialRela_Sel = arrRTSysSocialRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrRTSysSocialRela_Sel = arrRTSysSocialRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrRTSysSocialRela_Sel = arrRTSysSocialRela_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrRTSysSocialRela_Sel = arrRTSysSocialRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrRTSysSocialRela_Sel = arrRTSysSocialRela_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrRTSysSocialRela_Sel = arrRTSysSocialRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrRTSysSocialRela_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objRTSysSocialRela_Cond), exports.rTSysSocialRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.RTSysSocialRela_GetSubObjLst_Cache = RTSysSocialRela_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrmId:关键字列表
    * @returns 对象列表
    **/
    async function RTSysSocialRela_GetObjLstBymIdLstAsync(arrmId) {
        const strThisFuncName = "GetObjLstBymIdLstAsync";
        const strAction = "GetObjLstBymIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTSysSocialRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrmId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.rTSysSocialRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = RTSysSocialRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTSysSocialRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTSysSocialRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTSysSocialRela_GetObjLstBymIdLstAsync = RTSysSocialRela_GetObjLstBymIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrlngmIdLst:关键字列表
     * @returns 对象列表
    */
    async function RTSysSocialRela_GetObjLstBymIdLst_Cache(arrmIdLst) {
        const strThisFuncName = "GetObjLstBymIdLst_Cache";
        try {
            const arrRTSysSocialRelaObjLst_Cache = await RTSysSocialRela_GetObjLst_Cache();
            const arrRTSysSocialRela_Sel = arrRTSysSocialRelaObjLst_Cache.filter(x => arrmIdLst.indexOf(x.mId) > -1);
            return arrRTSysSocialRela_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrmIdLst.join(","), exports.rTSysSocialRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.RTSysSocialRela_GetObjLstBymIdLst_Cache = RTSysSocialRela_GetObjLstBymIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function RTSysSocialRela_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTSysSocialRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.rTSysSocialRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = RTSysSocialRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTSysSocialRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTSysSocialRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTSysSocialRela_GetTopObjLstAsync = RTSysSocialRela_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function RTSysSocialRela_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTSysSocialRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.rTSysSocialRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = RTSysSocialRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTSysSocialRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTSysSocialRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTSysSocialRela_GetObjLstByRangeAsync = RTSysSocialRela_GetObjLstByRangeAsync;
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
    async function RTSysSocialRela_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTSysSocialRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTSysSocialRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTSysSocialRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTSysSocialRela_GetObjLstByRange = RTSysSocialRela_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function RTSysSocialRela_GetObjLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const arrRTSysSocialRelaObjLst_Cache = await RTSysSocialRela_GetObjLst_Cache();
        if (arrRTSysSocialRelaObjLst_Cache.length == 0)
            return arrRTSysSocialRelaObjLst_Cache;
        let arrRTSysSocialRela_Sel = arrRTSysSocialRelaObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objRTSysSocialRela_Cond = new clsRTSysSocialRelaEN_js_1.clsRTSysSocialRelaEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objRTSysSocialRela_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsRTSysSocialRelaWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrRTSysSocialRela_Sel = arrRTSysSocialRela_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objRTSysSocialRela_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrRTSysSocialRela_Sel = arrRTSysSocialRela_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrRTSysSocialRela_Sel = arrRTSysSocialRela_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrRTSysSocialRela_Sel = arrRTSysSocialRela_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrRTSysSocialRela_Sel = arrRTSysSocialRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrRTSysSocialRela_Sel = arrRTSysSocialRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrRTSysSocialRela_Sel = arrRTSysSocialRela_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrRTSysSocialRela_Sel = arrRTSysSocialRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrRTSysSocialRela_Sel = arrRTSysSocialRela_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrRTSysSocialRela_Sel = arrRTSysSocialRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrRTSysSocialRela_Sel.length == 0)
                return arrRTSysSocialRela_Sel;
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
                arrRTSysSocialRela_Sel = arrRTSysSocialRela_Sel.sort(RTSysSocialRela_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrRTSysSocialRela_Sel = arrRTSysSocialRela_Sel.sort(objPagerPara.sortFun);
            }
            arrRTSysSocialRela_Sel = arrRTSysSocialRela_Sel.slice(intStart, intEnd);
            return arrRTSysSocialRela_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.rTSysSocialRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.RTSysSocialRela_GetObjLstByPager_Cache = RTSysSocialRela_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function RTSysSocialRela_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTSysSocialRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.rTSysSocialRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = RTSysSocialRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTSysSocialRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTSysSocialRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTSysSocialRela_GetObjLstByPagerAsync = RTSysSocialRela_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param lngmId:关键字
    * @returns 获取删除的结果
    **/
    async function RTSysSocialRela_DelRecordAsync(lngmId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTSysSocialRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTSysSocialRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTSysSocialRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTSysSocialRela_DelRecordAsync = RTSysSocialRela_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrmId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function RTSysSocialRela_DelRTSysSocialRelasAsync(arrmId) {
        const strThisFuncName = "DelRTSysSocialRelasAsync";
        const strAction = "DelRTSysSocialRelas";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTSysSocialRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTSysSocialRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTSysSocialRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTSysSocialRela_DelRTSysSocialRelasAsync = RTSysSocialRela_DelRTSysSocialRelasAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function RTSysSocialRela_DelRTSysSocialRelasByCondAsync(strWhereCond) {
        const strThisFuncName = "DelRTSysSocialRelasByCondAsync";
        const strAction = "DelRTSysSocialRelasByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTSysSocialRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTSysSocialRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTSysSocialRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTSysSocialRela_DelRTSysSocialRelasByCondAsync = RTSysSocialRela_DelRTSysSocialRelasByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objRTSysSocialRelaEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function RTSysSocialRela_AddNewRecordAsync(objRTSysSocialRelaEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objRTSysSocialRelaEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTSysSocialRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRTSysSocialRelaEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTSysSocialRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTSysSocialRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTSysSocialRela_AddNewRecordAsync = RTSysSocialRela_AddNewRecordAsync;
    /* 数据类型不是字符型，不可以最大关键字的方式添加记录。*/
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objRTSysSocialRelaEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function RTSysSocialRela_AddNewRecordWithReturnKeyAsync(objRTSysSocialRelaEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTSysSocialRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRTSysSocialRelaEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTSysSocialRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTSysSocialRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTSysSocialRela_AddNewRecordWithReturnKeyAsync = RTSysSocialRela_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objRTSysSocialRelaEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function RTSysSocialRela_AddNewRecordWithReturnKey(objRTSysSocialRelaEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objRTSysSocialRelaEN.mId === null || objRTSysSocialRelaEN.mId === 0) {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTSysSocialRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRTSysSocialRelaEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTSysSocialRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTSysSocialRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTSysSocialRela_AddNewRecordWithReturnKey = RTSysSocialRela_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objRTSysSocialRelaEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function RTSysSocialRela_UpdateRecordAsync(objRTSysSocialRelaEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objRTSysSocialRelaEN.sf_UpdFldSetStr === undefined || objRTSysSocialRelaEN.sf_UpdFldSetStr === null || objRTSysSocialRelaEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objRTSysSocialRelaEN.mId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTSysSocialRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRTSysSocialRelaEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTSysSocialRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTSysSocialRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTSysSocialRela_UpdateRecordAsync = RTSysSocialRela_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objRTSysSocialRelaEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function RTSysSocialRela_UpdateWithConditionAsync(objRTSysSocialRelaEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objRTSysSocialRelaEN.sf_UpdFldSetStr === undefined || objRTSysSocialRelaEN.sf_UpdFldSetStr === null || objRTSysSocialRelaEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objRTSysSocialRelaEN.mId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTSysSocialRela_Controller, strAction);
        objRTSysSocialRelaEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objRTSysSocialRelaEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTSysSocialRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTSysSocialRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTSysSocialRela_UpdateWithConditionAsync = RTSysSocialRela_UpdateWithConditionAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objlngmId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function RTSysSocialRela_IsExistRecord_Cache(objRTSysSocialRela_Cond) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrRTSysSocialRelaObjLst_Cache = await RTSysSocialRela_GetObjLst_Cache();
        if (arrRTSysSocialRelaObjLst_Cache == null)
            return false;
        let arrRTSysSocialRela_Sel = arrRTSysSocialRelaObjLst_Cache;
        if (objRTSysSocialRela_Cond.sf_FldComparisonOp == null || objRTSysSocialRela_Cond.sf_FldComparisonOp == "")
            return arrRTSysSocialRela_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objRTSysSocialRela_Cond.sf_FldComparisonOp);
        //console.log("clsRTSysSocialRelaWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objRTSysSocialRela_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objRTSysSocialRela_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrRTSysSocialRela_Sel = arrRTSysSocialRela_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrRTSysSocialRela_Sel = arrRTSysSocialRela_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrRTSysSocialRela_Sel = arrRTSysSocialRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrRTSysSocialRela_Sel = arrRTSysSocialRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrRTSysSocialRela_Sel = arrRTSysSocialRela_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrRTSysSocialRela_Sel = arrRTSysSocialRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrRTSysSocialRela_Sel = arrRTSysSocialRela_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrRTSysSocialRela_Sel = arrRTSysSocialRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrRTSysSocialRela_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objRTSysSocialRela_Cond), exports.rTSysSocialRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.RTSysSocialRela_IsExistRecord_Cache = RTSysSocialRela_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function RTSysSocialRela_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTSysSocialRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTSysSocialRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTSysSocialRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTSysSocialRela_IsExistRecordAsync = RTSysSocialRela_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param lngmId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function RTSysSocialRela_IsExist(lngmId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTSysSocialRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTSysSocialRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTSysSocialRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTSysSocialRela_IsExist = RTSysSocialRela_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param lngmId:所给的关键字
     * @returns 对象
    */
    async function RTSysSocialRela_IsExist_Cache(lngmId) {
        const strThisFuncName = "IsExist_Cache";
        const arrRTSysSocialRelaObjLst_Cache = await RTSysSocialRela_GetObjLst_Cache();
        if (arrRTSysSocialRelaObjLst_Cache == null)
            return false;
        try {
            const arrRTSysSocialRela_Sel = arrRTSysSocialRelaObjLst_Cache.filter(x => x.mId == lngmId);
            if (arrRTSysSocialRela_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", lngmId, exports.rTSysSocialRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.RTSysSocialRela_IsExist_Cache = RTSysSocialRela_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param lngmId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function RTSysSocialRela_IsExistAsync(lngmId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTSysSocialRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTSysSocialRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTSysSocialRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTSysSocialRela_IsExistAsync = RTSysSocialRela_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function RTSysSocialRela_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTSysSocialRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTSysSocialRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTSysSocialRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTSysSocialRela_GetRecCountByCondAsync = RTSysSocialRela_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objRTSysSocialRela_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function RTSysSocialRela_GetRecCountByCond_Cache(objRTSysSocialRela_Cond) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrRTSysSocialRelaObjLst_Cache = await RTSysSocialRela_GetObjLst_Cache();
        if (arrRTSysSocialRelaObjLst_Cache == null)
            return 0;
        let arrRTSysSocialRela_Sel = arrRTSysSocialRelaObjLst_Cache;
        if (objRTSysSocialRela_Cond.sf_FldComparisonOp == null || objRTSysSocialRela_Cond.sf_FldComparisonOp == "")
            return arrRTSysSocialRela_Sel.length;
        const dicFldComparisonOp = JSON.parse(objRTSysSocialRela_Cond.sf_FldComparisonOp);
        //console.log("clsRTSysSocialRelaWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objRTSysSocialRela_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrRTSysSocialRela_Sel = arrRTSysSocialRela_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objRTSysSocialRela_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrRTSysSocialRela_Sel = arrRTSysSocialRela_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrRTSysSocialRela_Sel = arrRTSysSocialRela_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrRTSysSocialRela_Sel = arrRTSysSocialRela_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrRTSysSocialRela_Sel = arrRTSysSocialRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrRTSysSocialRela_Sel = arrRTSysSocialRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrRTSysSocialRela_Sel = arrRTSysSocialRela_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrRTSysSocialRela_Sel = arrRTSysSocialRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrRTSysSocialRela_Sel = arrRTSysSocialRela_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrRTSysSocialRela_Sel = arrRTSysSocialRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrRTSysSocialRela_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objRTSysSocialRela_Cond), exports.rTSysSocialRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.RTSysSocialRela_GetRecCountByCond_Cache = RTSysSocialRela_GetRecCountByCond_Cache;
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
    async function RTSysSocialRela_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTSysSocialRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTSysSocialRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTSysSocialRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTSysSocialRela_GetMaxStrIdByPrefix = RTSysSocialRela_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function RTSysSocialRela_GetWebApiUrl(strController, strAction) {
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
    exports.RTSysSocialRela_GetWebApiUrl = RTSysSocialRela_GetWebApiUrl;
    /**
    * 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshCache)
    **/
    function RTSysSocialRela_ReFreshCache() {
        const strThisFuncName = "ReFreshCache";
        const strMsg = (0, clsString_js_1.Format)("刷新缓存成功！");
        console.trace(strMsg);
        // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
        const strKey = clsRTSysSocialRelaEN_js_1.clsRTSysSocialRelaEN._CurrTabName;
        switch (clsRTSysSocialRelaEN_js_1.clsRTSysSocialRelaEN.CacheModeId) {
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
        (0, clsvRTSysSocialRelaWApi_js_1.vRTSysSocialRela_ReFreshThisCache)();
    }
    exports.RTSysSocialRela_ReFreshCache = RTSysSocialRela_ReFreshCache;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function RTSysSocialRela_ReFreshThisCache() {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = clsRTSysSocialRelaEN_js_1.clsRTSysSocialRelaEN._CurrTabName;
            switch (clsRTSysSocialRelaEN_js_1.clsRTSysSocialRelaEN.CacheModeId) {
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
    exports.RTSysSocialRela_ReFreshThisCache = RTSysSocialRela_ReFreshThisCache;
    /* 该表的下拉框功能没有设置，不需要生成下拉框绑定函数。*/
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function RTSysSocialRela_CheckPropertyNew(pobjRTSysSocialRelaEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTSysSocialRelaEN.topicId) === true
            || pobjRTSysSocialRelaEN.topicId.toString() === "0") {
            throw new Error("(errid:Watl000058)字段[主题Id]不能为空(In RTSysSocialRela)!(clsRTSysSocialRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTSysSocialRelaEN.socialId) === true) {
            throw new Error("(errid:Watl000058)字段[社会Id]不能为空(In RTSysSocialRela)!(clsRTSysSocialRelaBL:CheckPropertyNew)");
        }
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTSysSocialRelaEN.topicId) == false && (0, clsString_js_1.GetStrLen)(pobjRTSysSocialRelaEN.topicId) > 8) {
            throw new Error("(errid:Watl000059)字段[主题Id(topicId)]的长度不能超过8(In RTSysSocialRela(RTSysSocialRela))!值:$(pobjRTSysSocialRelaEN.topicId)(clsRTSysSocialRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTSysSocialRelaEN.socialId) == false && (0, clsString_js_1.GetStrLen)(pobjRTSysSocialRelaEN.socialId) > 10) {
            throw new Error("(errid:Watl000059)字段[社会Id(socialId)]的长度不能超过10(In RTSysSocialRela(RTSysSocialRela))!值:$(pobjRTSysSocialRelaEN.socialId)(clsRTSysSocialRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTSysSocialRelaEN.updDate) == false && (0, clsString_js_1.GetStrLen)(pobjRTSysSocialRelaEN.updDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In RTSysSocialRela(RTSysSocialRela))!值:$(pobjRTSysSocialRelaEN.updDate)(clsRTSysSocialRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTSysSocialRelaEN.updUser) == false && (0, clsString_js_1.GetStrLen)(pobjRTSysSocialRelaEN.updUser) > 20) {
            throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In RTSysSocialRela(RTSysSocialRela))!值:$(pobjRTSysSocialRelaEN.updUser)(clsRTSysSocialRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTSysSocialRelaEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjRTSysSocialRelaEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In RTSysSocialRela(RTSysSocialRela))!值:$(pobjRTSysSocialRelaEN.memo)(clsRTSysSocialRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTSysSocialRelaEN.classificationId) == false && (0, clsString_js_1.GetStrLen)(pobjRTSysSocialRelaEN.classificationId) > 10) {
            throw new Error("(errid:Watl000059)字段[分类Id(classificationId)]的长度不能超过10(In RTSysSocialRela(RTSysSocialRela))!值:$(pobjRTSysSocialRelaEN.classificationId)(clsRTSysSocialRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTSysSocialRelaEN.id_CurrEduCls) == false && (0, clsString_js_1.GetStrLen)(pobjRTSysSocialRelaEN.id_CurrEduCls) > 8) {
            throw new Error("(errid:Watl000059)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In RTSysSocialRela(RTSysSocialRela))!值:$(pobjRTSysSocialRelaEN.id_CurrEduCls)(clsRTSysSocialRelaBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if (null != pobjRTSysSocialRelaEN.mId && undefined !== pobjRTSysSocialRelaEN.mId && jsString_js_1.tzDataType.isNumber(pobjRTSysSocialRelaEN.mId) === false) {
            throw new Error("(errid:Watl000060)字段[mId(mId)]的值:[$(pobjRTSysSocialRelaEN.mId)], 非法，应该为数值型(In RTSysSocialRela(RTSysSocialRela))!(clsRTSysSocialRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTSysSocialRelaEN.topicId) == false && undefined !== pobjRTSysSocialRelaEN.topicId && jsString_js_1.tzDataType.isString(pobjRTSysSocialRelaEN.topicId) === false) {
            throw new Error("(errid:Watl000060)字段[主题Id(topicId)]的值:[$(pobjRTSysSocialRelaEN.topicId)], 非法，应该为字符型(In RTSysSocialRela(RTSysSocialRela))!(clsRTSysSocialRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTSysSocialRelaEN.socialId) == false && undefined !== pobjRTSysSocialRelaEN.socialId && jsString_js_1.tzDataType.isString(pobjRTSysSocialRelaEN.socialId) === false) {
            throw new Error("(errid:Watl000060)字段[社会Id(socialId)]的值:[$(pobjRTSysSocialRelaEN.socialId)], 非法，应该为字符型(In RTSysSocialRela(RTSysSocialRela))!(clsRTSysSocialRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTSysSocialRelaEN.updDate) == false && undefined !== pobjRTSysSocialRelaEN.updDate && jsString_js_1.tzDataType.isString(pobjRTSysSocialRelaEN.updDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjRTSysSocialRelaEN.updDate)], 非法，应该为字符型(In RTSysSocialRela(RTSysSocialRela))!(clsRTSysSocialRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTSysSocialRelaEN.updUser) == false && undefined !== pobjRTSysSocialRelaEN.updUser && jsString_js_1.tzDataType.isString(pobjRTSysSocialRelaEN.updUser) === false) {
            throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjRTSysSocialRelaEN.updUser)], 非法，应该为字符型(In RTSysSocialRela(RTSysSocialRela))!(clsRTSysSocialRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTSysSocialRelaEN.memo) == false && undefined !== pobjRTSysSocialRelaEN.memo && jsString_js_1.tzDataType.isString(pobjRTSysSocialRelaEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjRTSysSocialRelaEN.memo)], 非法，应该为字符型(In RTSysSocialRela(RTSysSocialRela))!(clsRTSysSocialRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTSysSocialRelaEN.classificationId) == false && undefined !== pobjRTSysSocialRelaEN.classificationId && jsString_js_1.tzDataType.isString(pobjRTSysSocialRelaEN.classificationId) === false) {
            throw new Error("(errid:Watl000060)字段[分类Id(classificationId)]的值:[$(pobjRTSysSocialRelaEN.classificationId)], 非法，应该为字符型(In RTSysSocialRela(RTSysSocialRela))!(clsRTSysSocialRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTSysSocialRelaEN.id_CurrEduCls) == false && undefined !== pobjRTSysSocialRelaEN.id_CurrEduCls && jsString_js_1.tzDataType.isString(pobjRTSysSocialRelaEN.id_CurrEduCls) === false) {
            throw new Error("(errid:Watl000060)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjRTSysSocialRelaEN.id_CurrEduCls)], 非法，应该为字符型(In RTSysSocialRela(RTSysSocialRela))!(clsRTSysSocialRelaBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjRTSysSocialRelaEN.SetIsCheckProperty(true);
    }
    exports.RTSysSocialRela_CheckPropertyNew = RTSysSocialRela_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function RTSysSocialRela_CheckProperty4Update(pobjRTSysSocialRelaEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTSysSocialRelaEN.topicId) == false && (0, clsString_js_1.GetStrLen)(pobjRTSysSocialRelaEN.topicId) > 8) {
            throw new Error("(errid:Watl000062)字段[主题Id(topicId)]的长度不能超过8(In RTSysSocialRela(RTSysSocialRela))!值:$(pobjRTSysSocialRelaEN.topicId)(clsRTSysSocialRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTSysSocialRelaEN.socialId) == false && (0, clsString_js_1.GetStrLen)(pobjRTSysSocialRelaEN.socialId) > 10) {
            throw new Error("(errid:Watl000062)字段[社会Id(socialId)]的长度不能超过10(In RTSysSocialRela(RTSysSocialRela))!值:$(pobjRTSysSocialRelaEN.socialId)(clsRTSysSocialRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTSysSocialRelaEN.updDate) == false && (0, clsString_js_1.GetStrLen)(pobjRTSysSocialRelaEN.updDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In RTSysSocialRela(RTSysSocialRela))!值:$(pobjRTSysSocialRelaEN.updDate)(clsRTSysSocialRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTSysSocialRelaEN.updUser) == false && (0, clsString_js_1.GetStrLen)(pobjRTSysSocialRelaEN.updUser) > 20) {
            throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In RTSysSocialRela(RTSysSocialRela))!值:$(pobjRTSysSocialRelaEN.updUser)(clsRTSysSocialRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTSysSocialRelaEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjRTSysSocialRelaEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In RTSysSocialRela(RTSysSocialRela))!值:$(pobjRTSysSocialRelaEN.memo)(clsRTSysSocialRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTSysSocialRelaEN.classificationId) == false && (0, clsString_js_1.GetStrLen)(pobjRTSysSocialRelaEN.classificationId) > 10) {
            throw new Error("(errid:Watl000062)字段[分类Id(classificationId)]的长度不能超过10(In RTSysSocialRela(RTSysSocialRela))!值:$(pobjRTSysSocialRelaEN.classificationId)(clsRTSysSocialRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTSysSocialRelaEN.id_CurrEduCls) == false && (0, clsString_js_1.GetStrLen)(pobjRTSysSocialRelaEN.id_CurrEduCls) > 8) {
            throw new Error("(errid:Watl000062)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In RTSysSocialRela(RTSysSocialRela))!值:$(pobjRTSysSocialRelaEN.id_CurrEduCls)(clsRTSysSocialRelaBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if (null != pobjRTSysSocialRelaEN.mId && undefined !== pobjRTSysSocialRelaEN.mId && jsString_js_1.tzDataType.isNumber(pobjRTSysSocialRelaEN.mId) === false) {
            throw new Error("(errid:Watl000063)字段[mId(mId)]的值:[$(pobjRTSysSocialRelaEN.mId)], 非法，应该为数值型(In RTSysSocialRela(RTSysSocialRela))!(clsRTSysSocialRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTSysSocialRelaEN.topicId) == false && undefined !== pobjRTSysSocialRelaEN.topicId && jsString_js_1.tzDataType.isString(pobjRTSysSocialRelaEN.topicId) === false) {
            throw new Error("(errid:Watl000063)字段[主题Id(topicId)]的值:[$(pobjRTSysSocialRelaEN.topicId)], 非法，应该为字符型(In RTSysSocialRela(RTSysSocialRela))!(clsRTSysSocialRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTSysSocialRelaEN.socialId) == false && undefined !== pobjRTSysSocialRelaEN.socialId && jsString_js_1.tzDataType.isString(pobjRTSysSocialRelaEN.socialId) === false) {
            throw new Error("(errid:Watl000063)字段[社会Id(socialId)]的值:[$(pobjRTSysSocialRelaEN.socialId)], 非法，应该为字符型(In RTSysSocialRela(RTSysSocialRela))!(clsRTSysSocialRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTSysSocialRelaEN.updDate) == false && undefined !== pobjRTSysSocialRelaEN.updDate && jsString_js_1.tzDataType.isString(pobjRTSysSocialRelaEN.updDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjRTSysSocialRelaEN.updDate)], 非法，应该为字符型(In RTSysSocialRela(RTSysSocialRela))!(clsRTSysSocialRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTSysSocialRelaEN.updUser) == false && undefined !== pobjRTSysSocialRelaEN.updUser && jsString_js_1.tzDataType.isString(pobjRTSysSocialRelaEN.updUser) === false) {
            throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjRTSysSocialRelaEN.updUser)], 非法，应该为字符型(In RTSysSocialRela(RTSysSocialRela))!(clsRTSysSocialRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTSysSocialRelaEN.memo) == false && undefined !== pobjRTSysSocialRelaEN.memo && jsString_js_1.tzDataType.isString(pobjRTSysSocialRelaEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjRTSysSocialRelaEN.memo)], 非法，应该为字符型(In RTSysSocialRela(RTSysSocialRela))!(clsRTSysSocialRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTSysSocialRelaEN.classificationId) == false && undefined !== pobjRTSysSocialRelaEN.classificationId && jsString_js_1.tzDataType.isString(pobjRTSysSocialRelaEN.classificationId) === false) {
            throw new Error("(errid:Watl000063)字段[分类Id(classificationId)]的值:[$(pobjRTSysSocialRelaEN.classificationId)], 非法，应该为字符型(In RTSysSocialRela(RTSysSocialRela))!(clsRTSysSocialRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTSysSocialRelaEN.id_CurrEduCls) == false && undefined !== pobjRTSysSocialRelaEN.id_CurrEduCls && jsString_js_1.tzDataType.isString(pobjRTSysSocialRelaEN.id_CurrEduCls) === false) {
            throw new Error("(errid:Watl000063)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjRTSysSocialRelaEN.id_CurrEduCls)], 非法，应该为字符型(In RTSysSocialRela(RTSysSocialRela))!(clsRTSysSocialRelaBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if (null === pobjRTSysSocialRelaEN.mId
            || pobjRTSysSocialRelaEN.mId != null && pobjRTSysSocialRelaEN.mId.toString() === "") {
            throw new Error("(errid:Watl000064)字段[mId]不能为空(In RTSysSocialRela)!(clsRTSysSocialRelaBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjRTSysSocialRelaEN.SetIsCheckProperty(true);
    }
    exports.RTSysSocialRela_CheckProperty4Update = RTSysSocialRela_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function RTSysSocialRela_GetJSONStrByObj(pobjRTSysSocialRelaEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjRTSysSocialRelaEN.sf_UpdFldSetStr = pobjRTSysSocialRelaEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjRTSysSocialRelaEN);
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
    exports.RTSysSocialRela_GetJSONStrByObj = RTSysSocialRela_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function RTSysSocialRela_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrRTSysSocialRelaObjLst = new Array();
        if (strJSON === "") {
            return arrRTSysSocialRelaObjLst;
        }
        try {
            arrRTSysSocialRelaObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrRTSysSocialRelaObjLst;
        }
        return arrRTSysSocialRelaObjLst;
    }
    exports.RTSysSocialRela_GetObjLstByJSONStr = RTSysSocialRela_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrRTSysSocialRelaObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function RTSysSocialRela_GetObjLstByJSONObjLst(arrRTSysSocialRelaObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrRTSysSocialRelaObjLst = new Array();
        for (const objInFor of arrRTSysSocialRelaObjLstS) {
            const obj1 = RTSysSocialRela_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrRTSysSocialRelaObjLst.push(obj1);
        }
        return arrRTSysSocialRelaObjLst;
    }
    exports.RTSysSocialRela_GetObjLstByJSONObjLst = RTSysSocialRela_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function RTSysSocialRela_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjRTSysSocialRelaEN = new clsRTSysSocialRelaEN_js_1.clsRTSysSocialRelaEN();
        if (strJSON === "") {
            return pobjRTSysSocialRelaEN;
        }
        try {
            pobjRTSysSocialRelaEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjRTSysSocialRelaEN;
        }
        return pobjRTSysSocialRelaEN;
    }
    exports.RTSysSocialRela_GetObjByJSONStr = RTSysSocialRela_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function RTSysSocialRela_GetCombineCondition(objRTSysSocialRela_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objRTSysSocialRela_Cond.dicFldComparisonOp, clsRTSysSocialRelaEN_js_1.clsRTSysSocialRelaEN.con_mId) == true) {
            const strComparisonOp_mId = objRTSysSocialRela_Cond.dicFldComparisonOp[clsRTSysSocialRelaEN_js_1.clsRTSysSocialRelaEN.con_mId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsRTSysSocialRelaEN_js_1.clsRTSysSocialRelaEN.con_mId, objRTSysSocialRela_Cond.mId, strComparisonOp_mId);
        }
        if (Object.prototype.hasOwnProperty.call(objRTSysSocialRela_Cond.dicFldComparisonOp, clsRTSysSocialRelaEN_js_1.clsRTSysSocialRelaEN.con_TopicId) == true) {
            const strComparisonOp_TopicId = objRTSysSocialRela_Cond.dicFldComparisonOp[clsRTSysSocialRelaEN_js_1.clsRTSysSocialRelaEN.con_TopicId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsRTSysSocialRelaEN_js_1.clsRTSysSocialRelaEN.con_TopicId, objRTSysSocialRela_Cond.topicId, strComparisonOp_TopicId);
        }
        if (Object.prototype.hasOwnProperty.call(objRTSysSocialRela_Cond.dicFldComparisonOp, clsRTSysSocialRelaEN_js_1.clsRTSysSocialRelaEN.con_SocialId) == true) {
            const strComparisonOp_SocialId = objRTSysSocialRela_Cond.dicFldComparisonOp[clsRTSysSocialRelaEN_js_1.clsRTSysSocialRelaEN.con_SocialId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsRTSysSocialRelaEN_js_1.clsRTSysSocialRelaEN.con_SocialId, objRTSysSocialRela_Cond.socialId, strComparisonOp_SocialId);
        }
        if (Object.prototype.hasOwnProperty.call(objRTSysSocialRela_Cond.dicFldComparisonOp, clsRTSysSocialRelaEN_js_1.clsRTSysSocialRelaEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objRTSysSocialRela_Cond.dicFldComparisonOp[clsRTSysSocialRelaEN_js_1.clsRTSysSocialRelaEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsRTSysSocialRelaEN_js_1.clsRTSysSocialRelaEN.con_UpdDate, objRTSysSocialRela_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objRTSysSocialRela_Cond.dicFldComparisonOp, clsRTSysSocialRelaEN_js_1.clsRTSysSocialRelaEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objRTSysSocialRela_Cond.dicFldComparisonOp[clsRTSysSocialRelaEN_js_1.clsRTSysSocialRelaEN.con_UpdUser];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsRTSysSocialRelaEN_js_1.clsRTSysSocialRelaEN.con_UpdUser, objRTSysSocialRela_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objRTSysSocialRela_Cond.dicFldComparisonOp, clsRTSysSocialRelaEN_js_1.clsRTSysSocialRelaEN.con_Memo) == true) {
            const strComparisonOp_Memo = objRTSysSocialRela_Cond.dicFldComparisonOp[clsRTSysSocialRelaEN_js_1.clsRTSysSocialRelaEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsRTSysSocialRelaEN_js_1.clsRTSysSocialRelaEN.con_Memo, objRTSysSocialRela_Cond.memo, strComparisonOp_Memo);
        }
        if (Object.prototype.hasOwnProperty.call(objRTSysSocialRela_Cond.dicFldComparisonOp, clsRTSysSocialRelaEN_js_1.clsRTSysSocialRelaEN.con_ClassificationId) == true) {
            const strComparisonOp_ClassificationId = objRTSysSocialRela_Cond.dicFldComparisonOp[clsRTSysSocialRelaEN_js_1.clsRTSysSocialRelaEN.con_ClassificationId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsRTSysSocialRelaEN_js_1.clsRTSysSocialRelaEN.con_ClassificationId, objRTSysSocialRela_Cond.classificationId, strComparisonOp_ClassificationId);
        }
        if (Object.prototype.hasOwnProperty.call(objRTSysSocialRela_Cond.dicFldComparisonOp, clsRTSysSocialRelaEN_js_1.clsRTSysSocialRelaEN.con_id_CurrEduCls) == true) {
            const strComparisonOp_id_CurrEduCls = objRTSysSocialRela_Cond.dicFldComparisonOp[clsRTSysSocialRelaEN_js_1.clsRTSysSocialRelaEN.con_id_CurrEduCls];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsRTSysSocialRelaEN_js_1.clsRTSysSocialRelaEN.con_id_CurrEduCls, objRTSysSocialRela_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
        }
        return strWhereCond;
    }
    exports.RTSysSocialRela_GetCombineCondition = RTSysSocialRela_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--RTSysSocialRela(RTSysSocialRela),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param lngmId: mId(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function RTSysSocialRela_GetUniCondStr_mId(objRTSysSocialRelaEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and mId = '{0}'", objRTSysSocialRelaEN.mId);
        return strWhereCond;
    }
    exports.RTSysSocialRela_GetUniCondStr_mId = RTSysSocialRela_GetUniCondStr_mId;
    /**
    *获取唯一性条件串(Uniqueness)--RTSysSocialRela(RTSysSocialRela),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param lngmId: mId(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function RTSysSocialRela_GetUniCondStr4Update_mId(objRTSysSocialRelaEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and mId <> '{0}'", objRTSysSocialRelaEN.mId);
        strWhereCond += (0, clsString_js_1.Format)(" and mId = '{0}'", objRTSysSocialRelaEN.mId);
        return strWhereCond;
    }
    exports.RTSysSocialRela_GetUniCondStr4Update_mId = RTSysSocialRela_GetUniCondStr4Update_mId;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objRTSysSocialRelaENS:源对象
     * @param objRTSysSocialRelaENT:目标对象
    */
    function RTSysSocialRela_CopyObjTo(objRTSysSocialRelaENS, objRTSysSocialRelaENT) {
        objRTSysSocialRelaENT.mId = objRTSysSocialRelaENS.mId; //mId
        objRTSysSocialRelaENT.topicId = objRTSysSocialRelaENS.topicId; //主题Id
        objRTSysSocialRelaENT.socialId = objRTSysSocialRelaENS.socialId; //社会Id
        objRTSysSocialRelaENT.updDate = objRTSysSocialRelaENS.updDate; //修改日期
        objRTSysSocialRelaENT.updUser = objRTSysSocialRelaENS.updUser; //修改人
        objRTSysSocialRelaENT.memo = objRTSysSocialRelaENS.memo; //备注
        objRTSysSocialRelaENT.classificationId = objRTSysSocialRelaENS.classificationId; //分类Id
        objRTSysSocialRelaENT.id_CurrEduCls = objRTSysSocialRelaENS.id_CurrEduCls; //教学班流水号
        objRTSysSocialRelaENT.sf_UpdFldSetStr = objRTSysSocialRelaENS.updFldString; //sf_UpdFldSetStr
    }
    exports.RTSysSocialRela_CopyObjTo = RTSysSocialRela_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objRTSysSocialRelaENS:源对象
     * @param objRTSysSocialRelaENT:目标对象
    */
    function RTSysSocialRela_GetObjFromJsonObj(objRTSysSocialRelaENS) {
        const objRTSysSocialRelaENT = new clsRTSysSocialRelaEN_js_1.clsRTSysSocialRelaEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objRTSysSocialRelaENT, objRTSysSocialRelaENS);
        return objRTSysSocialRelaENT;
    }
    exports.RTSysSocialRela_GetObjFromJsonObj = RTSysSocialRela_GetObjFromJsonObj;
});
