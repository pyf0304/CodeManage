/**
* 类名:clsRTUserRelaWApi
* 表名:RTUserRela(01120582)
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
        define(["require", "exports", "axios", "../../PubFun/CacheHelper.js", "../../L0_Entity/GraduateEduTopic/clsRTUserRelaEN.js", "../../L3_ForWApi/GraduateEduTopic/clsvRTUserRelaWApi.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsSysPara4WebApi.js", "../../PubFun/CacheHelper.js", "../../PubFun/jsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.RTUserRela_GetObjFromJsonObj = exports.RTUserRela_CopyObjTo = exports.RTUserRela_GetUniCondStr4Update_TopicId_UserId = exports.RTUserRela_GetUniCondStr_TopicId_UserId = exports.RTUserRela_GetCombineCondition = exports.RTUserRela_GetObjByJSONStr = exports.RTUserRela_GetObjLstByJSONObjLst = exports.RTUserRela_GetObjLstByJSONStr = exports.RTUserRela_GetJSONStrByObj = exports.RTUserRela_CheckProperty4Update = exports.RTUserRela_CheckPropertyNew = exports.RTUserRela_ReFreshThisCache = exports.RTUserRela_ReFreshCache = exports.RTUserRela_GetWebApiUrl = exports.RTUserRela_GetMaxStrIdByPrefix = exports.RTUserRela_GetRecCountByCond_Cache = exports.RTUserRela_GetRecCountByCondAsync = exports.RTUserRela_IsExistAsync = exports.RTUserRela_IsExist_Cache = exports.RTUserRela_IsExist = exports.RTUserRela_IsExistRecordAsync = exports.RTUserRela_IsExistRecord_Cache = exports.RTUserRela_UpdateWithConditionAsync = exports.RTUserRela_UpdateRecordAsync = exports.RTUserRela_AddNewRecordWithReturnKey = exports.RTUserRela_AddNewRecordWithReturnKeyAsync = exports.RTUserRela_ReOrderAsync = exports.RTUserRela_GoBottomAsync = exports.RTUserRela_DownMoveAsync = exports.RTUserRela_UpMoveAsync = exports.RTUserRela_GoTopAsync = exports.RTUserRela_AddNewRecordAsync = exports.RTUserRela_DelRTUserRelasByCondAsync = exports.RTUserRela_DelRTUserRelasAsync = exports.RTUserRela_DelRecordAsync = exports.RTUserRela_GetObjLstByPagerAsync = exports.RTUserRela_GetObjLstByPager_Cache = exports.RTUserRela_GetObjLstByRange = exports.RTUserRela_GetObjLstByRangeAsync = exports.RTUserRela_GetTopObjLstAsync = exports.RTUserRela_GetObjLstBymIdLst_Cache = exports.RTUserRela_GetObjLstBymIdLstAsync = exports.RTUserRela_GetSubObjLst_Cache = exports.RTUserRela_GetObjLst_PureCache = exports.RTUserRela_GetObjLst_Cache = exports.RTUserRela_GetObjLst_sessionStorage_PureCache = exports.RTUserRela_GetObjLst_sessionStorage = exports.RTUserRela_GetObjLstAsync = exports.RTUserRela_GetObjLst_localStorage_PureCache = exports.RTUserRela_GetObjLst_localStorage = exports.RTUserRela_GetObjLst_ClientCache = exports.RTUserRela_GetFirstObjAsync = exports.RTUserRela_GetFirstID = exports.RTUserRela_GetFirstIDAsync = exports.RTUserRela_FilterFunByKey = exports.RTUserRela_SortFunByKey = exports.RTUserRela_SortFun_Defa_2Fld = exports.RTUserRela_SortFun_Defa = exports.RTUserRela_func = exports.RTUserRela_UpdateObjInLst_Cache = exports.RTUserRela_GetObjBymId_localStorage = exports.RTUserRela_GetObjBymId_Cache = exports.RTUserRela_GetObjBymIdAsync = exports.rTUserRela_ConstructorName = exports.rTUserRela_Controller = void 0;
    /**
     * 主题用户关系(RTUserRela)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2022年11月02日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsRTUserRelaEN_js_1 = require("../../L0_Entity/GraduateEduTopic/clsRTUserRelaEN.js");
    const clsvRTUserRelaWApi_js_1 = require("../../L3_ForWApi/GraduateEduTopic/clsvRTUserRelaWApi.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    const CacheHelper_js_2 = require("../../PubFun/CacheHelper.js");
    const jsString_js_1 = require("../../PubFun/jsString.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.rTUserRela_Controller = "RTUserRelaApi";
    exports.rTUserRela_ConstructorName = "rTUserRela";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param lngmId:关键字
    * @returns 对象
    **/
    async function RTUserRela_GetObjBymIdAsync(lngmId) {
        const strThisFuncName = "GetObjBymIdAsync";
        if (lngmId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngmId]不能为空！(In GetObjBymIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjBymId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTUserRela_Controller, strAction);
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
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.rTUserRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objRTUserRela = RTUserRela_GetObjFromJsonObj(returnObj);
                return objRTUserRela;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTUserRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTUserRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTUserRela_GetObjBymIdAsync = RTUserRela_GetObjBymIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param lngmId:所给的关键字
     * @returns 对象
    */
    async function RTUserRela_GetObjBymId_Cache(lngmId, strTopicId, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjBymId_Cache";
        if (lngmId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngmId]不能为空！(In GetObjBymId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        const arrRTUserRelaObjLst_Cache = await RTUserRela_GetObjLst_Cache(strTopicId);
        try {
            const arrRTUserRela_Sel = arrRTUserRelaObjLst_Cache.filter(x => x.mId == lngmId);
            let objRTUserRela;
            if (arrRTUserRela_Sel.length > 0) {
                objRTUserRela = arrRTUserRela_Sel[0];
                return objRTUserRela;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    objRTUserRela = await RTUserRela_GetObjBymIdAsync(lngmId);
                    if (objRTUserRela != null) {
                        RTUserRela_ReFreshThisCache(strTopicId);
                        return objRTUserRela;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngmId, exports.rTUserRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.RTUserRela_GetObjBymId_Cache = RTUserRela_GetObjBymId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param lngmId:所给的关键字
     * @returns 对象
    */
    async function RTUserRela_GetObjBymId_localStorage(lngmId) {
        const strThisFuncName = "GetObjBymId_localStorage";
        if (lngmId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngmId]不能为空！(In GetObjBymId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsRTUserRelaEN_js_1.clsRTUserRelaEN._CurrTabName, lngmId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objRTUserRela_Cache = JSON.parse(strTempObj);
            return objRTUserRela_Cache;
        }
        try {
            const objRTUserRela = await RTUserRela_GetObjBymIdAsync(lngmId);
            if (objRTUserRela != null) {
                localStorage.setItem(strKey, JSON.stringify(objRTUserRela));
                const strInfo = (0, clsString_js_1.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objRTUserRela;
            }
            return objRTUserRela;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngmId, exports.rTUserRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.RTUserRela_GetObjBymId_localStorage = RTUserRela_GetObjBymId_localStorage;
    /**
     * 修改在缓存对象列表中的对象, 与后台数据库无关.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
     * @param objRTUserRela:所给的对象
     * @returns 对象
    */
    async function RTUserRela_UpdateObjInLst_Cache(objRTUserRela, strTopicId) {
        const strThisFuncName = "UpdateObjInLst_Cache";
        try {
            const arrRTUserRelaObjLst_Cache = await RTUserRela_GetObjLst_Cache(strTopicId);
            const obj = arrRTUserRelaObjLst_Cache.find(x => x.topicId == objRTUserRela.topicId && x.userId == objRTUserRela.userId);
            if (obj != null) {
                objRTUserRela.mId = obj.mId;
                (0, clsCommFunc4Web_js_1.ObjectAssign)(obj, objRTUserRela);
            }
            else {
                arrRTUserRelaObjLst_Cache.push(objRTUserRela);
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, exports.rTUserRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.RTUserRela_UpdateObjInLst_Cache = RTUserRela_UpdateObjInLst_Cache;
    /*该表没有名称字段，不能生成此函数！*/
    /**
     * 映射函数。根据表映射把输入字段值，映射成输出字段值
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_func)
     * @param strInFldName:输入字段名
     * @param strOutFldName:输出字段名
     * @param strInValue:输入字段值
     @param strTopicId:缓存的分类字段
     * @returns 返回一个输出字段值
    */
    async function RTUserRela_func(strInFldName, strOutFldName, strInValue, strTopicId_C) {
        //const strThisFuncName = "func";
        if ((0, clsString_js_1.IsNullOrEmpty)(strTopicId_C) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strTopicId_C]不能为空！(In func)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strTopicId_C.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strTopicId_C]的长度:[{0}]不正确！", strTopicId_C.length);
            console.error(strMsg);
            throw (strMsg);
        }
        if (strInFldName != clsRTUserRelaEN_js_1.clsRTUserRelaEN.con_mId) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsRTUserRelaEN_js_1.clsRTUserRelaEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_1.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strInFldName, clsRTUserRelaEN_js_1.clsRTUserRelaEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const lngmId = Number(strInValue);
        if (lngmId == 0) {
            return "";
        }
        const objRTUserRela = await RTUserRela_GetObjBymId_Cache(lngmId, strTopicId_C);
        if (objRTUserRela == null)
            return "";
        return objRTUserRela.GetFldValue(strOutFldName).toString();
    }
    exports.RTUserRela_func = RTUserRela_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function RTUserRela_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.mId - b.mId;
    }
    exports.RTUserRela_SortFun_Defa = RTUserRela_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function RTUserRela_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.topicId == b.topicId)
            return a.userId.localeCompare(b.userId);
        else
            return a.topicId.localeCompare(b.topicId);
    }
    exports.RTUserRela_SortFun_Defa_2Fld = RTUserRela_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function RTUserRela_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsRTUserRelaEN_js_1.clsRTUserRelaEN.con_mId:
                    return (a, b) => {
                        return a.mId - b.mId;
                    };
                case clsRTUserRelaEN_js_1.clsRTUserRelaEN.con_TopicId:
                    return (a, b) => {
                        return a.topicId.localeCompare(b.topicId);
                    };
                case clsRTUserRelaEN_js_1.clsRTUserRelaEN.con_UserId:
                    return (a, b) => {
                        return a.userId.localeCompare(b.userId);
                    };
                case clsRTUserRelaEN_js_1.clsRTUserRelaEN.con_TopicUserRoleId:
                    return (a, b) => {
                        return a.topicUserRoleId.localeCompare(b.topicUserRoleId);
                    };
                case clsRTUserRelaEN_js_1.clsRTUserRelaEN.con_ColorId:
                    return (a, b) => {
                        return a.colorId.localeCompare(b.colorId);
                    };
                case clsRTUserRelaEN_js_1.clsRTUserRelaEN.con_OrderNum:
                    return (a, b) => {
                        return a.orderNum - b.orderNum;
                    };
                case clsRTUserRelaEN_js_1.clsRTUserRelaEN.con_UserBgColor:
                    return (a, b) => {
                        return a.userBgColor.localeCompare(b.userBgColor);
                    };
                case clsRTUserRelaEN_js_1.clsRTUserRelaEN.con_id_CurrEduCls:
                    return (a, b) => {
                        return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
                    };
                case clsRTUserRelaEN_js_1.clsRTUserRelaEN.con_UpdDate:
                    return (a, b) => {
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsRTUserRelaEN_js_1.clsRTUserRelaEN.con_UpdUser:
                    return (a, b) => {
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsRTUserRelaEN_js_1.clsRTUserRelaEN.con_Memo:
                    return (a, b) => {
                        return a.memo.localeCompare(b.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[RTUserRela]中不存在！(in ${exports.rTUserRela_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsRTUserRelaEN_js_1.clsRTUserRelaEN.con_mId:
                    return (a, b) => {
                        return b.mId - a.mId;
                    };
                case clsRTUserRelaEN_js_1.clsRTUserRelaEN.con_TopicId:
                    return (a, b) => {
                        return b.topicId.localeCompare(a.topicId);
                    };
                case clsRTUserRelaEN_js_1.clsRTUserRelaEN.con_UserId:
                    return (a, b) => {
                        return b.userId.localeCompare(a.userId);
                    };
                case clsRTUserRelaEN_js_1.clsRTUserRelaEN.con_TopicUserRoleId:
                    return (a, b) => {
                        return b.topicUserRoleId.localeCompare(a.topicUserRoleId);
                    };
                case clsRTUserRelaEN_js_1.clsRTUserRelaEN.con_ColorId:
                    return (a, b) => {
                        return b.colorId.localeCompare(a.colorId);
                    };
                case clsRTUserRelaEN_js_1.clsRTUserRelaEN.con_OrderNum:
                    return (a, b) => {
                        return b.orderNum - a.orderNum;
                    };
                case clsRTUserRelaEN_js_1.clsRTUserRelaEN.con_UserBgColor:
                    return (a, b) => {
                        return b.userBgColor.localeCompare(a.userBgColor);
                    };
                case clsRTUserRelaEN_js_1.clsRTUserRelaEN.con_id_CurrEduCls:
                    return (a, b) => {
                        return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
                    };
                case clsRTUserRelaEN_js_1.clsRTUserRelaEN.con_UpdDate:
                    return (a, b) => {
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsRTUserRelaEN_js_1.clsRTUserRelaEN.con_UpdUser:
                    return (a, b) => {
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsRTUserRelaEN_js_1.clsRTUserRelaEN.con_Memo:
                    return (a, b) => {
                        return b.memo.localeCompare(a.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[RTUserRela]中不存在！(in ${exports.rTUserRela_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.RTUserRela_SortFunByKey = RTUserRela_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function RTUserRela_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsRTUserRelaEN_js_1.clsRTUserRelaEN.con_mId:
                return (obj) => {
                    return obj.mId === value;
                };
            case clsRTUserRelaEN_js_1.clsRTUserRelaEN.con_TopicId:
                return (obj) => {
                    return obj.topicId === value;
                };
            case clsRTUserRelaEN_js_1.clsRTUserRelaEN.con_UserId:
                return (obj) => {
                    return obj.userId === value;
                };
            case clsRTUserRelaEN_js_1.clsRTUserRelaEN.con_TopicUserRoleId:
                return (obj) => {
                    return obj.topicUserRoleId === value;
                };
            case clsRTUserRelaEN_js_1.clsRTUserRelaEN.con_ColorId:
                return (obj) => {
                    return obj.colorId === value;
                };
            case clsRTUserRelaEN_js_1.clsRTUserRelaEN.con_OrderNum:
                return (obj) => {
                    return obj.orderNum === value;
                };
            case clsRTUserRelaEN_js_1.clsRTUserRelaEN.con_UserBgColor:
                return (obj) => {
                    return obj.userBgColor === value;
                };
            case clsRTUserRelaEN_js_1.clsRTUserRelaEN.con_id_CurrEduCls:
                return (obj) => {
                    return obj.id_CurrEduCls === value;
                };
            case clsRTUserRelaEN_js_1.clsRTUserRelaEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsRTUserRelaEN_js_1.clsRTUserRelaEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsRTUserRelaEN_js_1.clsRTUserRelaEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[RTUserRela]中不存在！(in ${exports.rTUserRela_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.RTUserRela_FilterFunByKey = RTUserRela_FilterFunByKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function RTUserRela_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTUserRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTUserRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTUserRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTUserRela_GetFirstIDAsync = RTUserRela_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function RTUserRela_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTUserRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTUserRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTUserRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTUserRela_GetFirstID = RTUserRela_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function RTUserRela_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTUserRela_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.rTUserRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objRTUserRela = RTUserRela_GetObjFromJsonObj(returnObj);
                return objRTUserRela;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTUserRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTUserRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTUserRela_GetFirstObjAsync = RTUserRela_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function RTUserRela_GetObjLst_ClientCache(strTopicId) {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("TopicId='{0}'", strTopicId);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsRTUserRelaEN_js_1.clsRTUserRelaEN._CurrTabName, strTopicId);
        clsRTUserRelaEN_js_1.clsRTUserRelaEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsRTUserRelaEN_js_1.clsRTUserRelaEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsRTUserRelaEN_js_1.clsRTUserRelaEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsRTUserRelaEN_js_1.clsRTUserRelaEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_2.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrRTUserRelaExObjLst_Cache = CacheHelper_js_2.CacheHelper.Get(strKey);
            const arrRTUserRelaObjLst_T = RTUserRela_GetObjLstByJSONObjLst(arrRTUserRelaExObjLst_Cache);
            return arrRTUserRelaObjLst_T;
        }
        try {
            const arrRTUserRelaExObjLst = await RTUserRela_GetObjLstAsync(strWhereCond);
            CacheHelper_js_2.CacheHelper.Add(strKey, arrRTUserRelaExObjLst);
            const strInfo = (0, clsString_js_1.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrRTUserRelaExObjLst.length);
            console.log(strInfo);
            return arrRTUserRelaExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.rTUserRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.RTUserRela_GetObjLst_ClientCache = RTUserRela_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function RTUserRela_GetObjLst_localStorage(strTopicId) {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("TopicId='{0}'", strTopicId);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsRTUserRelaEN_js_1.clsRTUserRelaEN._CurrTabName, strTopicId);
        clsRTUserRelaEN_js_1.clsRTUserRelaEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsRTUserRelaEN_js_1.clsRTUserRelaEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsRTUserRelaEN_js_1.clsRTUserRelaEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsRTUserRelaEN_js_1.clsRTUserRelaEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrRTUserRelaExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrRTUserRelaObjLst_T = RTUserRela_GetObjLstByJSONObjLst(arrRTUserRelaExObjLst_Cache);
            return arrRTUserRelaObjLst_T;
        }
        try {
            const arrRTUserRelaExObjLst = await RTUserRela_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrRTUserRelaExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrRTUserRelaExObjLst.length);
            console.log(strInfo);
            return arrRTUserRelaExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.rTUserRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.RTUserRela_GetObjLst_localStorage = RTUserRela_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function RTUserRela_GetObjLst_localStorage_PureCache(strTopicId) {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("TopicId='{0}'", strTopicId);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsRTUserRelaEN_js_1.clsRTUserRelaEN._CurrTabName, strTopicId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrRTUserRelaObjLst_Cache = JSON.parse(strTempObjLst);
            return arrRTUserRelaObjLst_Cache;
        }
        else
            return null;
    }
    exports.RTUserRela_GetObjLst_localStorage_PureCache = RTUserRela_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function RTUserRela_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTUserRela_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.rTUserRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = RTUserRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTUserRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTUserRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTUserRela_GetObjLstAsync = RTUserRela_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function RTUserRela_GetObjLst_sessionStorage(strTopicId) {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("TopicId='{0}'", strTopicId);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsRTUserRelaEN_js_1.clsRTUserRelaEN._CurrTabName, strTopicId);
        clsRTUserRelaEN_js_1.clsRTUserRelaEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsRTUserRelaEN_js_1.clsRTUserRelaEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsRTUserRelaEN_js_1.clsRTUserRelaEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsRTUserRelaEN_js_1.clsRTUserRelaEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrRTUserRelaExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrRTUserRelaObjLst_T = RTUserRela_GetObjLstByJSONObjLst(arrRTUserRelaExObjLst_Cache);
            return arrRTUserRelaObjLst_T;
        }
        try {
            const arrRTUserRelaExObjLst = await RTUserRela_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrRTUserRelaExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrRTUserRelaExObjLst.length);
            console.log(strInfo);
            return arrRTUserRelaExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.rTUserRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.RTUserRela_GetObjLst_sessionStorage = RTUserRela_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function RTUserRela_GetObjLst_sessionStorage_PureCache(strTopicId) {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("TopicId='{0}'", strTopicId);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsRTUserRelaEN_js_1.clsRTUserRelaEN._CurrTabName, strTopicId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrRTUserRelaObjLst_Cache = JSON.parse(strTempObjLst);
            return arrRTUserRelaObjLst_Cache;
        }
        else
            return null;
    }
    exports.RTUserRela_GetObjLst_sessionStorage_PureCache = RTUserRela_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function RTUserRela_GetObjLst_Cache(strTopicId) {
        //const strThisFuncName = "GetObjLst_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strTopicId) == true) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[TopicId]不能为空！");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strTopicId.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strTopicId]的长度:[{0}]不正确！", strTopicId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        let arrRTUserRelaObjLst_Cache;
        switch (clsRTUserRelaEN_js_1.clsRTUserRelaEN.CacheModeId) {
            case "04": //sessionStorage
                arrRTUserRelaObjLst_Cache = await RTUserRela_GetObjLst_sessionStorage(strTopicId);
                break;
            case "03": //localStorage
                arrRTUserRelaObjLst_Cache = await RTUserRela_GetObjLst_localStorage(strTopicId);
                break;
            case "02": //ClientCache
                arrRTUserRelaObjLst_Cache = await RTUserRela_GetObjLst_ClientCache(strTopicId);
                break;
            default:
                arrRTUserRelaObjLst_Cache = await RTUserRela_GetObjLst_ClientCache(strTopicId);
                break;
        }
        const arrRTUserRelaObjLst = RTUserRela_GetObjLstByJSONObjLst(arrRTUserRelaObjLst_Cache);
        return arrRTUserRelaObjLst_Cache;
    }
    exports.RTUserRela_GetObjLst_Cache = RTUserRela_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function RTUserRela_GetObjLst_PureCache(strTopicId) {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrRTUserRelaObjLst_Cache;
        switch (clsRTUserRelaEN_js_1.clsRTUserRelaEN.CacheModeId) {
            case "04": //sessionStorage
                arrRTUserRelaObjLst_Cache = await RTUserRela_GetObjLst_sessionStorage_PureCache(strTopicId);
                break;
            case "03": //localStorage
                arrRTUserRelaObjLst_Cache = await RTUserRela_GetObjLst_localStorage_PureCache(strTopicId);
                break;
            case "02": //ClientCache
                arrRTUserRelaObjLst_Cache = null;
                break;
            default:
                arrRTUserRelaObjLst_Cache = null;
                break;
        }
        return arrRTUserRelaObjLst_Cache;
    }
    exports.RTUserRela_GetObjLst_PureCache = RTUserRela_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objlngmId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function RTUserRela_GetSubObjLst_Cache(objRTUserRela_Cond, strTopicId) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrRTUserRelaObjLst_Cache = await RTUserRela_GetObjLst_Cache(strTopicId);
        let arrRTUserRela_Sel = arrRTUserRelaObjLst_Cache;
        if (objRTUserRela_Cond.sf_FldComparisonOp == null || objRTUserRela_Cond.sf_FldComparisonOp == "")
            return arrRTUserRela_Sel;
        const dicFldComparisonOp = JSON.parse(objRTUserRela_Cond.sf_FldComparisonOp);
        //console.log("clsRTUserRelaWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objRTUserRela_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrRTUserRela_Sel = arrRTUserRela_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objRTUserRela_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrRTUserRela_Sel = arrRTUserRela_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrRTUserRela_Sel = arrRTUserRela_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrRTUserRela_Sel = arrRTUserRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrRTUserRela_Sel = arrRTUserRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrRTUserRela_Sel = arrRTUserRela_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrRTUserRela_Sel = arrRTUserRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrRTUserRela_Sel = arrRTUserRela_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrRTUserRela_Sel = arrRTUserRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrRTUserRela_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objRTUserRela_Cond), exports.rTUserRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.RTUserRela_GetSubObjLst_Cache = RTUserRela_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrmId:关键字列表
    * @returns 对象列表
    **/
    async function RTUserRela_GetObjLstBymIdLstAsync(arrmId) {
        const strThisFuncName = "GetObjLstBymIdLstAsync";
        const strAction = "GetObjLstBymIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTUserRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrmId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.rTUserRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = RTUserRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTUserRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTUserRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTUserRela_GetObjLstBymIdLstAsync = RTUserRela_GetObjLstBymIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrlngmIdLst:关键字列表
     * @returns 对象列表
    */
    async function RTUserRela_GetObjLstBymIdLst_Cache(arrmIdLst, strTopicId) {
        const strThisFuncName = "GetObjLstBymIdLst_Cache";
        try {
            const arrRTUserRelaObjLst_Cache = await RTUserRela_GetObjLst_Cache(strTopicId);
            const arrRTUserRela_Sel = arrRTUserRelaObjLst_Cache.filter(x => arrmIdLst.indexOf(x.mId) > -1);
            return arrRTUserRela_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrmIdLst.join(","), exports.rTUserRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.RTUserRela_GetObjLstBymIdLst_Cache = RTUserRela_GetObjLstBymIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function RTUserRela_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTUserRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.rTUserRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = RTUserRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTUserRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTUserRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTUserRela_GetTopObjLstAsync = RTUserRela_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function RTUserRela_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTUserRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.rTUserRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = RTUserRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTUserRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTUserRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTUserRela_GetObjLstByRangeAsync = RTUserRela_GetObjLstByRangeAsync;
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
    async function RTUserRela_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTUserRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTUserRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTUserRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTUserRela_GetObjLstByRange = RTUserRela_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function RTUserRela_GetObjLstByPager_Cache(objPagerPara, strTopicId) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const arrRTUserRelaObjLst_Cache = await RTUserRela_GetObjLst_Cache(strTopicId);
        if (arrRTUserRelaObjLst_Cache.length == 0)
            return arrRTUserRelaObjLst_Cache;
        let arrRTUserRela_Sel = arrRTUserRelaObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objRTUserRela_Cond = new clsRTUserRelaEN_js_1.clsRTUserRelaEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objRTUserRela_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsRTUserRelaWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrRTUserRela_Sel = arrRTUserRela_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objRTUserRela_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrRTUserRela_Sel = arrRTUserRela_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrRTUserRela_Sel = arrRTUserRela_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrRTUserRela_Sel = arrRTUserRela_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrRTUserRela_Sel = arrRTUserRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrRTUserRela_Sel = arrRTUserRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrRTUserRela_Sel = arrRTUserRela_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrRTUserRela_Sel = arrRTUserRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrRTUserRela_Sel = arrRTUserRela_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrRTUserRela_Sel = arrRTUserRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrRTUserRela_Sel.length == 0)
                return arrRTUserRela_Sel;
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
                arrRTUserRela_Sel = arrRTUserRela_Sel.sort(RTUserRela_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrRTUserRela_Sel = arrRTUserRela_Sel.sort(objPagerPara.sortFun);
            }
            arrRTUserRela_Sel = arrRTUserRela_Sel.slice(intStart, intEnd);
            return arrRTUserRela_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.rTUserRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.RTUserRela_GetObjLstByPager_Cache = RTUserRela_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function RTUserRela_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTUserRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.rTUserRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = RTUserRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTUserRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTUserRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTUserRela_GetObjLstByPagerAsync = RTUserRela_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param lngmId:关键字
    * @returns 获取删除的结果
    **/
    async function RTUserRela_DelRecordAsync(lngmId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTUserRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTUserRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTUserRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTUserRela_DelRecordAsync = RTUserRela_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrmId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function RTUserRela_DelRTUserRelasAsync(arrmId) {
        const strThisFuncName = "DelRTUserRelasAsync";
        const strAction = "DelRTUserRelas";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTUserRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTUserRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTUserRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTUserRela_DelRTUserRelasAsync = RTUserRela_DelRTUserRelasAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function RTUserRela_DelRTUserRelasByCondAsync(strWhereCond) {
        const strThisFuncName = "DelRTUserRelasByCondAsync";
        const strAction = "DelRTUserRelasByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTUserRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTUserRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTUserRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTUserRela_DelRTUserRelasByCondAsync = RTUserRela_DelRTUserRelasByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objRTUserRelaEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function RTUserRela_AddNewRecordAsync(objRTUserRelaEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objRTUserRelaEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTUserRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRTUserRelaEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTUserRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTUserRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTUserRela_AddNewRecordAsync = RTUserRela_AddNewRecordAsync;
    /* 数据类型不是字符型，不可以最大关键字的方式添加记录。*/
    /**
    * 把所给的关键字列表相关的记录移顶
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GoTopAsync)
    * @param objRTUserRelaEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function RTUserRela_GoTopAsync(objOrderByData) {
        const strThisFuncName = "GoTopAsync";
        let strMsg = "";
        const strAction = "GoTop";
        if (objOrderByData.KeyIdLst.length == 0) {
            strMsg = "根据关键字列表置顶时，给定的关键字值列表不能为空!";
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTUserRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objOrderByData);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTUserRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTUserRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTUserRela_GoTopAsync = RTUserRela_GoTopAsync;
    /**
    * 把所给的关键字列表相关的记录上移
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpMoveAsync)
    * @param objRTUserRelaEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function RTUserRela_UpMoveAsync(objOrderByData) {
        const strThisFuncName = "UpMoveAsync";
        let strMsg = "";
        const strAction = "UpMove";
        if (objOrderByData.KeyIdLst.length == 0) {
            strMsg = "根据关键字列表上移时，给定的关键字值列表不能为空!";
            throw strMsg;
        }
        //var strJSON = JSON.stringify(objRTUserRelaEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTUserRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objOrderByData);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTUserRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTUserRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTUserRela_UpMoveAsync = RTUserRela_UpMoveAsync;
    /**
    * 把所给的关键字列表相关的记录下移
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DownMoveAsync)
    * @param objRTUserRelaEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function RTUserRela_DownMoveAsync(objOrderByData) {
        const strThisFuncName = "DownMoveAsync";
        let strMsg = "";
        const strAction = "DownMove";
        if (objOrderByData.KeyIdLst.length == 0) {
            strMsg = "根据关键字列表下移时，给定的关键字值列表不能为空!";
            throw strMsg;
        }
        //var strJSON = JSON.stringify(objRTUserRelaEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTUserRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objOrderByData);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTUserRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTUserRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTUserRela_DownMoveAsync = RTUserRela_DownMoveAsync;
    /**
    * 把所给的关键字列表相关的记录移底
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GoBottomAsync)
    * @param objRTUserRelaEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function RTUserRela_GoBottomAsync(objOrderByData) {
        const strThisFuncName = "GoBottomAsync";
        let strMsg = "";
        const strAction = "GoBottom";
        if (objOrderByData.KeyIdLst.length == 0) {
            strMsg = "根据关键字列表置底时，给定的关键字值列表不能为空!";
            throw strMsg;
        }
        //var strJSON = JSON.stringify(objRTUserRelaEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTUserRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objOrderByData);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTUserRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTUserRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTUserRela_GoBottomAsync = RTUserRela_GoBottomAsync;
    /**
    * 把列表记录重序
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReOrderAsync)
    * @param objRTUserRelaEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function RTUserRela_ReOrderAsync(objOrderByData) {
        const strThisFuncName = "ReOrderAsync";
        const strAction = "ReOrder";
        //var strJSON = JSON.stringify(objRTUserRelaEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTUserRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objOrderByData);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTUserRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTUserRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTUserRela_ReOrderAsync = RTUserRela_ReOrderAsync;
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objRTUserRelaEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function RTUserRela_AddNewRecordWithReturnKeyAsync(objRTUserRelaEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTUserRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRTUserRelaEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTUserRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTUserRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTUserRela_AddNewRecordWithReturnKeyAsync = RTUserRela_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objRTUserRelaEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function RTUserRela_AddNewRecordWithReturnKey(objRTUserRelaEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objRTUserRelaEN.mId === null || objRTUserRelaEN.mId === 0) {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTUserRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRTUserRelaEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTUserRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTUserRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTUserRela_AddNewRecordWithReturnKey = RTUserRela_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objRTUserRelaEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function RTUserRela_UpdateRecordAsync(objRTUserRelaEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objRTUserRelaEN.sf_UpdFldSetStr === undefined || objRTUserRelaEN.sf_UpdFldSetStr === null || objRTUserRelaEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objRTUserRelaEN.mId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTUserRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRTUserRelaEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTUserRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTUserRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTUserRela_UpdateRecordAsync = RTUserRela_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objRTUserRelaEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function RTUserRela_UpdateWithConditionAsync(objRTUserRelaEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objRTUserRelaEN.sf_UpdFldSetStr === undefined || objRTUserRelaEN.sf_UpdFldSetStr === null || objRTUserRelaEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objRTUserRelaEN.mId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTUserRela_Controller, strAction);
        objRTUserRelaEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objRTUserRelaEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTUserRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTUserRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTUserRela_UpdateWithConditionAsync = RTUserRela_UpdateWithConditionAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objlngmId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function RTUserRela_IsExistRecord_Cache(objRTUserRela_Cond, strTopicId) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrRTUserRelaObjLst_Cache = await RTUserRela_GetObjLst_Cache(strTopicId);
        if (arrRTUserRelaObjLst_Cache == null)
            return false;
        let arrRTUserRela_Sel = arrRTUserRelaObjLst_Cache;
        if (objRTUserRela_Cond.sf_FldComparisonOp == null || objRTUserRela_Cond.sf_FldComparisonOp == "")
            return arrRTUserRela_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objRTUserRela_Cond.sf_FldComparisonOp);
        //console.log("clsRTUserRelaWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objRTUserRela_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objRTUserRela_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrRTUserRela_Sel = arrRTUserRela_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrRTUserRela_Sel = arrRTUserRela_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrRTUserRela_Sel = arrRTUserRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrRTUserRela_Sel = arrRTUserRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrRTUserRela_Sel = arrRTUserRela_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrRTUserRela_Sel = arrRTUserRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrRTUserRela_Sel = arrRTUserRela_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrRTUserRela_Sel = arrRTUserRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrRTUserRela_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objRTUserRela_Cond), exports.rTUserRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.RTUserRela_IsExistRecord_Cache = RTUserRela_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function RTUserRela_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTUserRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTUserRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTUserRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTUserRela_IsExistRecordAsync = RTUserRela_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param lngmId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function RTUserRela_IsExist(lngmId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTUserRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTUserRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTUserRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTUserRela_IsExist = RTUserRela_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param lngmId:所给的关键字
     * @returns 对象
    */
    async function RTUserRela_IsExist_Cache(lngmId, strTopicId) {
        const strThisFuncName = "IsExist_Cache";
        const arrRTUserRelaObjLst_Cache = await RTUserRela_GetObjLst_Cache(strTopicId);
        if (arrRTUserRelaObjLst_Cache == null)
            return false;
        try {
            const arrRTUserRela_Sel = arrRTUserRelaObjLst_Cache.filter(x => x.mId == lngmId);
            if (arrRTUserRela_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", lngmId, exports.rTUserRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.RTUserRela_IsExist_Cache = RTUserRela_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param lngmId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function RTUserRela_IsExistAsync(lngmId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTUserRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTUserRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTUserRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTUserRela_IsExistAsync = RTUserRela_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function RTUserRela_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTUserRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTUserRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTUserRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTUserRela_GetRecCountByCondAsync = RTUserRela_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objRTUserRela_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function RTUserRela_GetRecCountByCond_Cache(objRTUserRela_Cond, strTopicId) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrRTUserRelaObjLst_Cache = await RTUserRela_GetObjLst_Cache(strTopicId);
        if (arrRTUserRelaObjLst_Cache == null)
            return 0;
        let arrRTUserRela_Sel = arrRTUserRelaObjLst_Cache;
        if (objRTUserRela_Cond.sf_FldComparisonOp == null || objRTUserRela_Cond.sf_FldComparisonOp == "")
            return arrRTUserRela_Sel.length;
        const dicFldComparisonOp = JSON.parse(objRTUserRela_Cond.sf_FldComparisonOp);
        //console.log("clsRTUserRelaWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objRTUserRela_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrRTUserRela_Sel = arrRTUserRela_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objRTUserRela_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrRTUserRela_Sel = arrRTUserRela_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrRTUserRela_Sel = arrRTUserRela_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrRTUserRela_Sel = arrRTUserRela_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrRTUserRela_Sel = arrRTUserRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrRTUserRela_Sel = arrRTUserRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrRTUserRela_Sel = arrRTUserRela_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrRTUserRela_Sel = arrRTUserRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrRTUserRela_Sel = arrRTUserRela_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrRTUserRela_Sel = arrRTUserRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrRTUserRela_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objRTUserRela_Cond), exports.rTUserRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.RTUserRela_GetRecCountByCond_Cache = RTUserRela_GetRecCountByCond_Cache;
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
    async function RTUserRela_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTUserRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTUserRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTUserRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTUserRela_GetMaxStrIdByPrefix = RTUserRela_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function RTUserRela_GetWebApiUrl(strController, strAction) {
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
    exports.RTUserRela_GetWebApiUrl = RTUserRela_GetWebApiUrl;
    /**
    * 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshCache)
    **/
    function RTUserRela_ReFreshCache(strTopicId) {
        const strThisFuncName = "ReFreshCache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strTopicId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strTopicId]不能为空！(In clsRTUserRelaWApi.ReFreshCache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strTopicId.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strTopicId]的长度:[{0}]不正确！", strTopicId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strMsg = (0, clsString_js_1.Format)("刷新缓存成功！");
        console.trace(strMsg);
        // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsRTUserRelaEN_js_1.clsRTUserRelaEN._CurrTabName, strTopicId);
        switch (clsRTUserRelaEN_js_1.clsRTUserRelaEN.CacheModeId) {
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
        (0, clsvRTUserRelaWApi_js_1.vRTUserRela_ReFreshThisCache)(strTopicId);
    }
    exports.RTUserRela_ReFreshCache = RTUserRela_ReFreshCache;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function RTUserRela_ReFreshThisCache(strTopicId) {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsRTUserRelaEN_js_1.clsRTUserRelaEN._CurrTabName, strTopicId);
            switch (clsRTUserRelaEN_js_1.clsRTUserRelaEN.CacheModeId) {
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
    exports.RTUserRela_ReFreshThisCache = RTUserRela_ReFreshThisCache;
    /* 该表的下拉框功能没有设置，不需要生成下拉框绑定函数。*/
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function RTUserRela_CheckPropertyNew(pobjRTUserRelaEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTUserRelaEN.topicUserRoleId) === true) {
            throw new Error("(errid:Watl000058)字段[主键Id]不能为空(In 主题用户关系)!(clsRTUserRelaBL:CheckPropertyNew)");
        }
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTUserRelaEN.topicId) == false && (0, clsString_js_1.GetStrLen)(pobjRTUserRelaEN.topicId) > 8) {
            throw new Error("(errid:Watl000059)字段[主题Id(topicId)]的长度不能超过8(In 主题用户关系(RTUserRela))!值:$(pobjRTUserRelaEN.topicId)(clsRTUserRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTUserRelaEN.userId) == false && (0, clsString_js_1.GetStrLen)(pobjRTUserRelaEN.userId) > 20) {
            throw new Error("(errid:Watl000059)字段[用户ID(userId)]的长度不能超过20(In 主题用户关系(RTUserRela))!值:$(pobjRTUserRelaEN.userId)(clsRTUserRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTUserRelaEN.topicUserRoleId) == false && (0, clsString_js_1.GetStrLen)(pobjRTUserRelaEN.topicUserRoleId) > 4) {
            throw new Error("(errid:Watl000059)字段[主键Id(topicUserRoleId)]的长度不能超过4(In 主题用户关系(RTUserRela))!值:$(pobjRTUserRelaEN.topicUserRoleId)(clsRTUserRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTUserRelaEN.colorId) == false && (0, clsString_js_1.GetStrLen)(pobjRTUserRelaEN.colorId) > 2) {
            throw new Error("(errid:Watl000059)字段[颜色Id(colorId)]的长度不能超过2(In 主题用户关系(RTUserRela))!值:$(pobjRTUserRelaEN.colorId)(clsRTUserRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTUserRelaEN.userBgColor) == false && (0, clsString_js_1.GetStrLen)(pobjRTUserRelaEN.userBgColor) > 200) {
            throw new Error("(errid:Watl000059)字段[用户段落背景(userBgColor)]的长度不能超过200(In 主题用户关系(RTUserRela))!值:$(pobjRTUserRelaEN.userBgColor)(clsRTUserRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTUserRelaEN.id_CurrEduCls) == false && (0, clsString_js_1.GetStrLen)(pobjRTUserRelaEN.id_CurrEduCls) > 8) {
            throw new Error("(errid:Watl000059)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 主题用户关系(RTUserRela))!值:$(pobjRTUserRelaEN.id_CurrEduCls)(clsRTUserRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTUserRelaEN.updDate) == false && (0, clsString_js_1.GetStrLen)(pobjRTUserRelaEN.updDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 主题用户关系(RTUserRela))!值:$(pobjRTUserRelaEN.updDate)(clsRTUserRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTUserRelaEN.updUser) == false && (0, clsString_js_1.GetStrLen)(pobjRTUserRelaEN.updUser) > 20) {
            throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 主题用户关系(RTUserRela))!值:$(pobjRTUserRelaEN.updUser)(clsRTUserRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTUserRelaEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjRTUserRelaEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 主题用户关系(RTUserRela))!值:$(pobjRTUserRelaEN.memo)(clsRTUserRelaBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if (null != pobjRTUserRelaEN.mId && undefined !== pobjRTUserRelaEN.mId && jsString_js_1.tzDataType.isNumber(pobjRTUserRelaEN.mId) === false) {
            throw new Error("(errid:Watl000060)字段[mId(mId)]的值:[$(pobjRTUserRelaEN.mId)], 非法，应该为数值型(In 主题用户关系(RTUserRela))!(clsRTUserRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTUserRelaEN.topicId) == false && undefined !== pobjRTUserRelaEN.topicId && jsString_js_1.tzDataType.isString(pobjRTUserRelaEN.topicId) === false) {
            throw new Error("(errid:Watl000060)字段[主题Id(topicId)]的值:[$(pobjRTUserRelaEN.topicId)], 非法，应该为字符型(In 主题用户关系(RTUserRela))!(clsRTUserRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTUserRelaEN.userId) == false && undefined !== pobjRTUserRelaEN.userId && jsString_js_1.tzDataType.isString(pobjRTUserRelaEN.userId) === false) {
            throw new Error("(errid:Watl000060)字段[用户ID(userId)]的值:[$(pobjRTUserRelaEN.userId)], 非法，应该为字符型(In 主题用户关系(RTUserRela))!(clsRTUserRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTUserRelaEN.topicUserRoleId) == false && undefined !== pobjRTUserRelaEN.topicUserRoleId && jsString_js_1.tzDataType.isString(pobjRTUserRelaEN.topicUserRoleId) === false) {
            throw new Error("(errid:Watl000060)字段[主键Id(topicUserRoleId)]的值:[$(pobjRTUserRelaEN.topicUserRoleId)], 非法，应该为字符型(In 主题用户关系(RTUserRela))!(clsRTUserRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTUserRelaEN.colorId) == false && undefined !== pobjRTUserRelaEN.colorId && jsString_js_1.tzDataType.isString(pobjRTUserRelaEN.colorId) === false) {
            throw new Error("(errid:Watl000060)字段[颜色Id(colorId)]的值:[$(pobjRTUserRelaEN.colorId)], 非法，应该为字符型(In 主题用户关系(RTUserRela))!(clsRTUserRelaBL:CheckPropertyNew)");
        }
        if (null != pobjRTUserRelaEN.orderNum && undefined !== pobjRTUserRelaEN.orderNum && jsString_js_1.tzDataType.isNumber(pobjRTUserRelaEN.orderNum) === false) {
            throw new Error("(errid:Watl000060)字段[序号(orderNum)]的值:[$(pobjRTUserRelaEN.orderNum)], 非法，应该为数值型(In 主题用户关系(RTUserRela))!(clsRTUserRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTUserRelaEN.userBgColor) == false && undefined !== pobjRTUserRelaEN.userBgColor && jsString_js_1.tzDataType.isString(pobjRTUserRelaEN.userBgColor) === false) {
            throw new Error("(errid:Watl000060)字段[用户段落背景(userBgColor)]的值:[$(pobjRTUserRelaEN.userBgColor)], 非法，应该为字符型(In 主题用户关系(RTUserRela))!(clsRTUserRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTUserRelaEN.id_CurrEduCls) == false && undefined !== pobjRTUserRelaEN.id_CurrEduCls && jsString_js_1.tzDataType.isString(pobjRTUserRelaEN.id_CurrEduCls) === false) {
            throw new Error("(errid:Watl000060)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjRTUserRelaEN.id_CurrEduCls)], 非法，应该为字符型(In 主题用户关系(RTUserRela))!(clsRTUserRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTUserRelaEN.updDate) == false && undefined !== pobjRTUserRelaEN.updDate && jsString_js_1.tzDataType.isString(pobjRTUserRelaEN.updDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjRTUserRelaEN.updDate)], 非法，应该为字符型(In 主题用户关系(RTUserRela))!(clsRTUserRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTUserRelaEN.updUser) == false && undefined !== pobjRTUserRelaEN.updUser && jsString_js_1.tzDataType.isString(pobjRTUserRelaEN.updUser) === false) {
            throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjRTUserRelaEN.updUser)], 非法，应该为字符型(In 主题用户关系(RTUserRela))!(clsRTUserRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTUserRelaEN.memo) == false && undefined !== pobjRTUserRelaEN.memo && jsString_js_1.tzDataType.isString(pobjRTUserRelaEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjRTUserRelaEN.memo)], 非法，应该为字符型(In 主题用户关系(RTUserRela))!(clsRTUserRelaBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjRTUserRelaEN.SetIsCheckProperty(true);
    }
    exports.RTUserRela_CheckPropertyNew = RTUserRela_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function RTUserRela_CheckProperty4Update(pobjRTUserRelaEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTUserRelaEN.topicId) == false && (0, clsString_js_1.GetStrLen)(pobjRTUserRelaEN.topicId) > 8) {
            throw new Error("(errid:Watl000062)字段[主题Id(topicId)]的长度不能超过8(In 主题用户关系(RTUserRela))!值:$(pobjRTUserRelaEN.topicId)(clsRTUserRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTUserRelaEN.userId) == false && (0, clsString_js_1.GetStrLen)(pobjRTUserRelaEN.userId) > 20) {
            throw new Error("(errid:Watl000062)字段[用户ID(userId)]的长度不能超过20(In 主题用户关系(RTUserRela))!值:$(pobjRTUserRelaEN.userId)(clsRTUserRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTUserRelaEN.topicUserRoleId) == false && (0, clsString_js_1.GetStrLen)(pobjRTUserRelaEN.topicUserRoleId) > 4) {
            throw new Error("(errid:Watl000062)字段[主键Id(topicUserRoleId)]的长度不能超过4(In 主题用户关系(RTUserRela))!值:$(pobjRTUserRelaEN.topicUserRoleId)(clsRTUserRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTUserRelaEN.colorId) == false && (0, clsString_js_1.GetStrLen)(pobjRTUserRelaEN.colorId) > 2) {
            throw new Error("(errid:Watl000062)字段[颜色Id(colorId)]的长度不能超过2(In 主题用户关系(RTUserRela))!值:$(pobjRTUserRelaEN.colorId)(clsRTUserRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTUserRelaEN.userBgColor) == false && (0, clsString_js_1.GetStrLen)(pobjRTUserRelaEN.userBgColor) > 200) {
            throw new Error("(errid:Watl000062)字段[用户段落背景(userBgColor)]的长度不能超过200(In 主题用户关系(RTUserRela))!值:$(pobjRTUserRelaEN.userBgColor)(clsRTUserRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTUserRelaEN.id_CurrEduCls) == false && (0, clsString_js_1.GetStrLen)(pobjRTUserRelaEN.id_CurrEduCls) > 8) {
            throw new Error("(errid:Watl000062)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 主题用户关系(RTUserRela))!值:$(pobjRTUserRelaEN.id_CurrEduCls)(clsRTUserRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTUserRelaEN.updDate) == false && (0, clsString_js_1.GetStrLen)(pobjRTUserRelaEN.updDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 主题用户关系(RTUserRela))!值:$(pobjRTUserRelaEN.updDate)(clsRTUserRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTUserRelaEN.updUser) == false && (0, clsString_js_1.GetStrLen)(pobjRTUserRelaEN.updUser) > 20) {
            throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 主题用户关系(RTUserRela))!值:$(pobjRTUserRelaEN.updUser)(clsRTUserRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTUserRelaEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjRTUserRelaEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 主题用户关系(RTUserRela))!值:$(pobjRTUserRelaEN.memo)(clsRTUserRelaBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if (null != pobjRTUserRelaEN.mId && undefined !== pobjRTUserRelaEN.mId && jsString_js_1.tzDataType.isNumber(pobjRTUserRelaEN.mId) === false) {
            throw new Error("(errid:Watl000063)字段[mId(mId)]的值:[$(pobjRTUserRelaEN.mId)], 非法，应该为数值型(In 主题用户关系(RTUserRela))!(clsRTUserRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTUserRelaEN.topicId) == false && undefined !== pobjRTUserRelaEN.topicId && jsString_js_1.tzDataType.isString(pobjRTUserRelaEN.topicId) === false) {
            throw new Error("(errid:Watl000063)字段[主题Id(topicId)]的值:[$(pobjRTUserRelaEN.topicId)], 非法，应该为字符型(In 主题用户关系(RTUserRela))!(clsRTUserRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTUserRelaEN.userId) == false && undefined !== pobjRTUserRelaEN.userId && jsString_js_1.tzDataType.isString(pobjRTUserRelaEN.userId) === false) {
            throw new Error("(errid:Watl000063)字段[用户ID(userId)]的值:[$(pobjRTUserRelaEN.userId)], 非法，应该为字符型(In 主题用户关系(RTUserRela))!(clsRTUserRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTUserRelaEN.topicUserRoleId) == false && undefined !== pobjRTUserRelaEN.topicUserRoleId && jsString_js_1.tzDataType.isString(pobjRTUserRelaEN.topicUserRoleId) === false) {
            throw new Error("(errid:Watl000063)字段[主键Id(topicUserRoleId)]的值:[$(pobjRTUserRelaEN.topicUserRoleId)], 非法，应该为字符型(In 主题用户关系(RTUserRela))!(clsRTUserRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTUserRelaEN.colorId) == false && undefined !== pobjRTUserRelaEN.colorId && jsString_js_1.tzDataType.isString(pobjRTUserRelaEN.colorId) === false) {
            throw new Error("(errid:Watl000063)字段[颜色Id(colorId)]的值:[$(pobjRTUserRelaEN.colorId)], 非法，应该为字符型(In 主题用户关系(RTUserRela))!(clsRTUserRelaBL:CheckProperty4Update)");
        }
        if (null != pobjRTUserRelaEN.orderNum && undefined !== pobjRTUserRelaEN.orderNum && jsString_js_1.tzDataType.isNumber(pobjRTUserRelaEN.orderNum) === false) {
            throw new Error("(errid:Watl000063)字段[序号(orderNum)]的值:[$(pobjRTUserRelaEN.orderNum)], 非法，应该为数值型(In 主题用户关系(RTUserRela))!(clsRTUserRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTUserRelaEN.userBgColor) == false && undefined !== pobjRTUserRelaEN.userBgColor && jsString_js_1.tzDataType.isString(pobjRTUserRelaEN.userBgColor) === false) {
            throw new Error("(errid:Watl000063)字段[用户段落背景(userBgColor)]的值:[$(pobjRTUserRelaEN.userBgColor)], 非法，应该为字符型(In 主题用户关系(RTUserRela))!(clsRTUserRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTUserRelaEN.id_CurrEduCls) == false && undefined !== pobjRTUserRelaEN.id_CurrEduCls && jsString_js_1.tzDataType.isString(pobjRTUserRelaEN.id_CurrEduCls) === false) {
            throw new Error("(errid:Watl000063)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjRTUserRelaEN.id_CurrEduCls)], 非法，应该为字符型(In 主题用户关系(RTUserRela))!(clsRTUserRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTUserRelaEN.updDate) == false && undefined !== pobjRTUserRelaEN.updDate && jsString_js_1.tzDataType.isString(pobjRTUserRelaEN.updDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjRTUserRelaEN.updDate)], 非法，应该为字符型(In 主题用户关系(RTUserRela))!(clsRTUserRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTUserRelaEN.updUser) == false && undefined !== pobjRTUserRelaEN.updUser && jsString_js_1.tzDataType.isString(pobjRTUserRelaEN.updUser) === false) {
            throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjRTUserRelaEN.updUser)], 非法，应该为字符型(In 主题用户关系(RTUserRela))!(clsRTUserRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTUserRelaEN.memo) == false && undefined !== pobjRTUserRelaEN.memo && jsString_js_1.tzDataType.isString(pobjRTUserRelaEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjRTUserRelaEN.memo)], 非法，应该为字符型(In 主题用户关系(RTUserRela))!(clsRTUserRelaBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if (null === pobjRTUserRelaEN.mId
            || pobjRTUserRelaEN.mId != null && pobjRTUserRelaEN.mId.toString() === "") {
            throw new Error("(errid:Watl000064)字段[mId]不能为空(In 主题用户关系)!(clsRTUserRelaBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjRTUserRelaEN.SetIsCheckProperty(true);
    }
    exports.RTUserRela_CheckProperty4Update = RTUserRela_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function RTUserRela_GetJSONStrByObj(pobjRTUserRelaEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjRTUserRelaEN.sf_UpdFldSetStr = pobjRTUserRelaEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjRTUserRelaEN);
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
    exports.RTUserRela_GetJSONStrByObj = RTUserRela_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function RTUserRela_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrRTUserRelaObjLst = new Array();
        if (strJSON === "") {
            return arrRTUserRelaObjLst;
        }
        try {
            arrRTUserRelaObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrRTUserRelaObjLst;
        }
        return arrRTUserRelaObjLst;
    }
    exports.RTUserRela_GetObjLstByJSONStr = RTUserRela_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrRTUserRelaObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function RTUserRela_GetObjLstByJSONObjLst(arrRTUserRelaObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrRTUserRelaObjLst = new Array();
        for (const objInFor of arrRTUserRelaObjLstS) {
            const obj1 = RTUserRela_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrRTUserRelaObjLst.push(obj1);
        }
        return arrRTUserRelaObjLst;
    }
    exports.RTUserRela_GetObjLstByJSONObjLst = RTUserRela_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function RTUserRela_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjRTUserRelaEN = new clsRTUserRelaEN_js_1.clsRTUserRelaEN();
        if (strJSON === "") {
            return pobjRTUserRelaEN;
        }
        try {
            pobjRTUserRelaEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjRTUserRelaEN;
        }
        return pobjRTUserRelaEN;
    }
    exports.RTUserRela_GetObjByJSONStr = RTUserRela_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function RTUserRela_GetCombineCondition(objRTUserRela_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objRTUserRela_Cond.dicFldComparisonOp, clsRTUserRelaEN_js_1.clsRTUserRelaEN.con_mId) == true) {
            const strComparisonOp_mId = objRTUserRela_Cond.dicFldComparisonOp[clsRTUserRelaEN_js_1.clsRTUserRelaEN.con_mId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsRTUserRelaEN_js_1.clsRTUserRelaEN.con_mId, objRTUserRela_Cond.mId, strComparisonOp_mId);
        }
        if (Object.prototype.hasOwnProperty.call(objRTUserRela_Cond.dicFldComparisonOp, clsRTUserRelaEN_js_1.clsRTUserRelaEN.con_TopicId) == true) {
            const strComparisonOp_TopicId = objRTUserRela_Cond.dicFldComparisonOp[clsRTUserRelaEN_js_1.clsRTUserRelaEN.con_TopicId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsRTUserRelaEN_js_1.clsRTUserRelaEN.con_TopicId, objRTUserRela_Cond.topicId, strComparisonOp_TopicId);
        }
        if (Object.prototype.hasOwnProperty.call(objRTUserRela_Cond.dicFldComparisonOp, clsRTUserRelaEN_js_1.clsRTUserRelaEN.con_UserId) == true) {
            const strComparisonOp_UserId = objRTUserRela_Cond.dicFldComparisonOp[clsRTUserRelaEN_js_1.clsRTUserRelaEN.con_UserId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsRTUserRelaEN_js_1.clsRTUserRelaEN.con_UserId, objRTUserRela_Cond.userId, strComparisonOp_UserId);
        }
        if (Object.prototype.hasOwnProperty.call(objRTUserRela_Cond.dicFldComparisonOp, clsRTUserRelaEN_js_1.clsRTUserRelaEN.con_TopicUserRoleId) == true) {
            const strComparisonOp_TopicUserRoleId = objRTUserRela_Cond.dicFldComparisonOp[clsRTUserRelaEN_js_1.clsRTUserRelaEN.con_TopicUserRoleId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsRTUserRelaEN_js_1.clsRTUserRelaEN.con_TopicUserRoleId, objRTUserRela_Cond.topicUserRoleId, strComparisonOp_TopicUserRoleId);
        }
        if (Object.prototype.hasOwnProperty.call(objRTUserRela_Cond.dicFldComparisonOp, clsRTUserRelaEN_js_1.clsRTUserRelaEN.con_ColorId) == true) {
            const strComparisonOp_ColorId = objRTUserRela_Cond.dicFldComparisonOp[clsRTUserRelaEN_js_1.clsRTUserRelaEN.con_ColorId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsRTUserRelaEN_js_1.clsRTUserRelaEN.con_ColorId, objRTUserRela_Cond.colorId, strComparisonOp_ColorId);
        }
        if (Object.prototype.hasOwnProperty.call(objRTUserRela_Cond.dicFldComparisonOp, clsRTUserRelaEN_js_1.clsRTUserRelaEN.con_OrderNum) == true) {
            const strComparisonOp_OrderNum = objRTUserRela_Cond.dicFldComparisonOp[clsRTUserRelaEN_js_1.clsRTUserRelaEN.con_OrderNum];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsRTUserRelaEN_js_1.clsRTUserRelaEN.con_OrderNum, objRTUserRela_Cond.orderNum, strComparisonOp_OrderNum);
        }
        if (Object.prototype.hasOwnProperty.call(objRTUserRela_Cond.dicFldComparisonOp, clsRTUserRelaEN_js_1.clsRTUserRelaEN.con_UserBgColor) == true) {
            const strComparisonOp_UserBgColor = objRTUserRela_Cond.dicFldComparisonOp[clsRTUserRelaEN_js_1.clsRTUserRelaEN.con_UserBgColor];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsRTUserRelaEN_js_1.clsRTUserRelaEN.con_UserBgColor, objRTUserRela_Cond.userBgColor, strComparisonOp_UserBgColor);
        }
        if (Object.prototype.hasOwnProperty.call(objRTUserRela_Cond.dicFldComparisonOp, clsRTUserRelaEN_js_1.clsRTUserRelaEN.con_id_CurrEduCls) == true) {
            const strComparisonOp_id_CurrEduCls = objRTUserRela_Cond.dicFldComparisonOp[clsRTUserRelaEN_js_1.clsRTUserRelaEN.con_id_CurrEduCls];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsRTUserRelaEN_js_1.clsRTUserRelaEN.con_id_CurrEduCls, objRTUserRela_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
        }
        if (Object.prototype.hasOwnProperty.call(objRTUserRela_Cond.dicFldComparisonOp, clsRTUserRelaEN_js_1.clsRTUserRelaEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objRTUserRela_Cond.dicFldComparisonOp[clsRTUserRelaEN_js_1.clsRTUserRelaEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsRTUserRelaEN_js_1.clsRTUserRelaEN.con_UpdDate, objRTUserRela_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objRTUserRela_Cond.dicFldComparisonOp, clsRTUserRelaEN_js_1.clsRTUserRelaEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objRTUserRela_Cond.dicFldComparisonOp[clsRTUserRelaEN_js_1.clsRTUserRelaEN.con_UpdUser];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsRTUserRelaEN_js_1.clsRTUserRelaEN.con_UpdUser, objRTUserRela_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objRTUserRela_Cond.dicFldComparisonOp, clsRTUserRelaEN_js_1.clsRTUserRelaEN.con_Memo) == true) {
            const strComparisonOp_Memo = objRTUserRela_Cond.dicFldComparisonOp[clsRTUserRelaEN_js_1.clsRTUserRelaEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsRTUserRelaEN_js_1.clsRTUserRelaEN.con_Memo, objRTUserRela_Cond.memo, strComparisonOp_Memo);
        }
        return strWhereCond;
    }
    exports.RTUserRela_GetCombineCondition = RTUserRela_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--RTUserRela(主题用户关系),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param strTopicId: 主题Id(要求唯一的字段)
    * @param strUserId: 用户ID(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function RTUserRela_GetUniCondStr_TopicId_UserId(objRTUserRelaEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and TopicId = '{0}'", objRTUserRelaEN.topicId);
        strWhereCond += (0, clsString_js_1.Format)(" and UserId = '{0}'", objRTUserRelaEN.userId);
        return strWhereCond;
    }
    exports.RTUserRela_GetUniCondStr_TopicId_UserId = RTUserRela_GetUniCondStr_TopicId_UserId;
    /**
    *获取唯一性条件串(Uniqueness)--RTUserRela(主题用户关系),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param strTopicId: 主题Id(要求唯一的字段)
    * @param strUserId: 用户ID(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function RTUserRela_GetUniCondStr4Update_TopicId_UserId(objRTUserRelaEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and mId <> '{0}'", objRTUserRelaEN.mId);
        strWhereCond += (0, clsString_js_1.Format)(" and TopicId = '{0}'", objRTUserRelaEN.topicId);
        strWhereCond += (0, clsString_js_1.Format)(" and UserId = '{0}'", objRTUserRelaEN.userId);
        return strWhereCond;
    }
    exports.RTUserRela_GetUniCondStr4Update_TopicId_UserId = RTUserRela_GetUniCondStr4Update_TopicId_UserId;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objRTUserRelaENS:源对象
     * @param objRTUserRelaENT:目标对象
    */
    function RTUserRela_CopyObjTo(objRTUserRelaENS, objRTUserRelaENT) {
        objRTUserRelaENT.mId = objRTUserRelaENS.mId; //mId
        objRTUserRelaENT.topicId = objRTUserRelaENS.topicId; //主题Id
        objRTUserRelaENT.userId = objRTUserRelaENS.userId; //用户ID
        objRTUserRelaENT.topicUserRoleId = objRTUserRelaENS.topicUserRoleId; //主键Id
        objRTUserRelaENT.colorId = objRTUserRelaENS.colorId; //颜色Id
        objRTUserRelaENT.orderNum = objRTUserRelaENS.orderNum; //序号
        objRTUserRelaENT.userBgColor = objRTUserRelaENS.userBgColor; //用户段落背景
        objRTUserRelaENT.id_CurrEduCls = objRTUserRelaENS.id_CurrEduCls; //教学班流水号
        objRTUserRelaENT.updDate = objRTUserRelaENS.updDate; //修改日期
        objRTUserRelaENT.updUser = objRTUserRelaENS.updUser; //修改人
        objRTUserRelaENT.memo = objRTUserRelaENS.memo; //备注
        objRTUserRelaENT.sf_UpdFldSetStr = objRTUserRelaENS.updFldString; //sf_UpdFldSetStr
    }
    exports.RTUserRela_CopyObjTo = RTUserRela_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objRTUserRelaENS:源对象
     * @param objRTUserRelaENT:目标对象
    */
    function RTUserRela_GetObjFromJsonObj(objRTUserRelaENS) {
        const objRTUserRelaENT = new clsRTUserRelaEN_js_1.clsRTUserRelaEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objRTUserRelaENT, objRTUserRelaENS);
        return objRTUserRelaENT;
    }
    exports.RTUserRela_GetObjFromJsonObj = RTUserRela_GetObjFromJsonObj;
});
