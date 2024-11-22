/**
* 类名:clsgs_UserRelaPositionWApi
* 表名:gs_UserRelaPosition(01120844)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/13 00:48:56
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
        define(["require", "exports", "axios", "../../PubFun/enumComparisonOp.js", "../../PubFun/CacheHelper.js", "../../L0_Entity/GraduateEduTools/clsgs_UserRelaPositionEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.gs_UserRelaPosition_GetObjFromJsonObj = exports.gs_UserRelaPosition_CopyObjTo = exports.gs_UserRelaPosition_GetUniCondStr4Update_mId = exports.gs_UserRelaPosition_GetUniCondStr_mId = exports.gs_UserRelaPosition_GetCombineCondition = exports.gs_UserRelaPosition_GetObjByJSONStr = exports.gs_UserRelaPosition_GetObjLstByJSONObjLst = exports.gs_UserRelaPosition_GetObjLstByJSONStr = exports.gs_UserRelaPosition_GetJSONStrByObj = exports.gs_UserRelaPosition_CheckProperty4Update = exports.gs_UserRelaPosition_CheckPropertyNew = exports.gs_UserRelaPosition_ReFreshThisCache = exports.gs_UserRelaPosition_ReFreshCache = exports.gs_UserRelaPosition_GetWebApiUrl = exports.gs_UserRelaPosition_GetMaxStrIdByPrefix = exports.gs_UserRelaPosition_GetRecCountByCond_Cache = exports.gs_UserRelaPosition_GetRecCountByCondAsync = exports.gs_UserRelaPosition_IsExistAsync = exports.gs_UserRelaPosition_IsExist_Cache = exports.gs_UserRelaPosition_IsExist = exports.gs_UserRelaPosition_IsExistRecordAsync = exports.gs_UserRelaPosition_IsExistRecord_Cache = exports.gs_UserRelaPosition_UpdateWithConditionAsync = exports.gs_UserRelaPosition_UpdateRecordAsync = exports.gs_UserRelaPosition_AddNewRecordWithReturnKey = exports.gs_UserRelaPosition_AddNewRecordWithReturnKeyAsync = exports.gs_UserRelaPosition_ReOrderAsync = exports.gs_UserRelaPosition_GoBottomAsync = exports.gs_UserRelaPosition_DownMoveAsync = exports.gs_UserRelaPosition_UpMoveAsync = exports.gs_UserRelaPosition_GoTopAsync = exports.gs_UserRelaPosition_AddNewRecordAsync = exports.gs_UserRelaPosition_Delgs_UserRelaPositionsByCondAsync = exports.gs_UserRelaPosition_Delgs_UserRelaPositionsAsync = exports.gs_UserRelaPosition_DelRecordAsync = exports.gs_UserRelaPosition_GetObjLstByPagerAsync = exports.gs_UserRelaPosition_GetObjLstByPager_Cache = exports.gs_UserRelaPosition_GetObjLstByRange = exports.gs_UserRelaPosition_GetObjLstByRangeAsync = exports.gs_UserRelaPosition_GetTopObjLstAsync = exports.gs_UserRelaPosition_GetObjLstBymIdLst_Cache = exports.gs_UserRelaPosition_GetObjLstBymIdLstAsync = exports.gs_UserRelaPosition_GetSubObjLst_Cache = exports.gs_UserRelaPosition_GetObjLst_PureCache = exports.gs_UserRelaPosition_GetObjLst_Cache = exports.gs_UserRelaPosition_GetObjLst_sessionStorage_PureCache = exports.gs_UserRelaPosition_GetObjLst_sessionStorage = exports.gs_UserRelaPosition_GetObjLstAsync = exports.gs_UserRelaPosition_GetObjLst_localStorage_PureCache = exports.gs_UserRelaPosition_GetObjLst_localStorage = exports.gs_UserRelaPosition_GetObjLst_ClientCache = exports.gs_UserRelaPosition_GetFirstObjAsync = exports.gs_UserRelaPosition_GetFirstID = exports.gs_UserRelaPosition_GetFirstIDAsync = exports.gs_UserRelaPosition_funcKey = exports.gs_UserRelaPosition_FilterFunByKey = exports.gs_UserRelaPosition_SortFunByKey = exports.gs_UserRelaPosition_SortFun_Defa_2Fld = exports.gs_UserRelaPosition_SortFun_Defa = exports.gs_UserRelaPosition_func = exports.gs_UserRelaPosition_UpdateObjInLst_Cache = exports.gs_UserRelaPosition_GetObjBymId_localStorage = exports.gs_UserRelaPosition_GetObjBymId_Cache = exports.gs_UserRelaPosition_GetObjBymIdAsync = exports.gs_UserRelaPosition_ConstructorName = exports.gs_UserRelaPosition_Controller = void 0;
    /**
     * 用户关系坐标位置(gs_UserRelaPosition)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月13日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const enumComparisonOp_js_1 = require("../../PubFun/enumComparisonOp.js");
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsgs_UserRelaPositionEN_js_1 = require("../../L0_Entity/GraduateEduTools/clsgs_UserRelaPositionEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsString_js_2 = require("../../PubFun/clsString.js");
    exports.gs_UserRelaPosition_Controller = "gs_UserRelaPositionApi";
    exports.gs_UserRelaPosition_ConstructorName = "gs_UserRelaPosition";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param lngmId:关键字
    * @returns 对象
    **/
    async function gs_UserRelaPosition_GetObjBymIdAsync(lngmId) {
        const strThisFuncName = "GetObjBymIdAsync";
        if (lngmId == 0) {
            const strMsg = (0, clsString_js_2.Format)("参数:[lngmId]不能为空！(In clsgs_UserRelaPositionWApi.GetObjBymIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjBymId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_UserRelaPosition_Controller, strAction);
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
                    return null;
                }
                //console.log(returnObj);
                const objgs_UserRelaPosition = gs_UserRelaPosition_GetObjFromJsonObj(returnObj);
                return objgs_UserRelaPosition;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_UserRelaPosition_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_UserRelaPosition_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_UserRelaPosition_GetObjBymIdAsync = gs_UserRelaPosition_GetObjBymIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param lngmId:所给的关键字
     * @returns 对象
    */
    async function gs_UserRelaPosition_GetObjBymId_Cache(lngmId, strid_CurrEduCls, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjBymId_Cache";
        if (lngmId == 0) {
            const strMsg = (0, clsString_js_2.Format)("参数:[lngmId]不能为空！(In clsgs_UserRelaPositionWApi.GetObjBymId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        const arrgs_UserRelaPositionObjLst_Cache = await gs_UserRelaPosition_GetObjLst_Cache(strid_CurrEduCls);
        try {
            const arrgs_UserRelaPosition_Sel = arrgs_UserRelaPositionObjLst_Cache.filter(x => x.mId == lngmId);
            let objgs_UserRelaPosition;
            if (arrgs_UserRelaPosition_Sel.length > 0) {
                objgs_UserRelaPosition = arrgs_UserRelaPosition_Sel[0];
                return objgs_UserRelaPosition;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    const objgs_UserRelaPosition_Const = await gs_UserRelaPosition_GetObjBymIdAsync(lngmId);
                    if (objgs_UserRelaPosition_Const != null) {
                        gs_UserRelaPosition_ReFreshThisCache(strid_CurrEduCls);
                        return objgs_UserRelaPosition_Const;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngmId, exports.gs_UserRelaPosition_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.gs_UserRelaPosition_GetObjBymId_Cache = gs_UserRelaPosition_GetObjBymId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param lngmId:所给的关键字
     * @returns 对象
    */
    async function gs_UserRelaPosition_GetObjBymId_localStorage(lngmId) {
        const strThisFuncName = "GetObjBymId_localStorage";
        if (lngmId == 0) {
            const strMsg = (0, clsString_js_2.Format)("参数:[lngmId]不能为空！(In clsgs_UserRelaPositionWApi.GetObjBymId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsgs_UserRelaPositionEN_js_1.clsgs_UserRelaPositionEN._CurrTabName, lngmId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objgs_UserRelaPosition_Cache = JSON.parse(strTempObj);
            return objgs_UserRelaPosition_Cache;
        }
        try {
            const objgs_UserRelaPosition = await gs_UserRelaPosition_GetObjBymIdAsync(lngmId);
            if (objgs_UserRelaPosition != null) {
                localStorage.setItem(strKey, JSON.stringify(objgs_UserRelaPosition));
                const strInfo = (0, clsString_js_2.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objgs_UserRelaPosition;
            }
            return objgs_UserRelaPosition;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngmId, exports.gs_UserRelaPosition_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.gs_UserRelaPosition_GetObjBymId_localStorage = gs_UserRelaPosition_GetObjBymId_localStorage;
    /**
     * 修改在缓存对象列表中的对象, 与后台数据库无关.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
     * @param objgs_UserRelaPosition:所给的对象
     * @returns 对象
    */
    async function gs_UserRelaPosition_UpdateObjInLst_Cache(objgs_UserRelaPosition, strid_CurrEduCls) {
        const strThisFuncName = "UpdateObjInLst_Cache";
        try {
            const arrgs_UserRelaPositionObjLst_Cache = await gs_UserRelaPosition_GetObjLst_Cache(strid_CurrEduCls);
            const obj = arrgs_UserRelaPositionObjLst_Cache.find(x => x.mId == objgs_UserRelaPosition.mId);
            if (obj != null) {
                objgs_UserRelaPosition.mId = obj.mId;
                (0, clsCommFunc4Web_js_1.ObjectAssign)(obj, objgs_UserRelaPosition);
            }
            else {
                arrgs_UserRelaPositionObjLst_Cache.push(objgs_UserRelaPosition);
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, exports.gs_UserRelaPosition_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.gs_UserRelaPosition_UpdateObjInLst_Cache = gs_UserRelaPosition_UpdateObjInLst_Cache;
    /*该表没有名称字段，不能生成此函数！*/
    /**
     * 映射函数。根据表映射把输入字段值，映射成输出字段值
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_func)
     * @param strInFldName:输入字段名
     * @param strOutFldName:输出字段名
     * @param strInValue:输入字段值
     @param strid_CurrEduCls:缓存的分类字段
     * @returns 返回一个输出字段值
    */
    async function gs_UserRelaPosition_func(strInFldName, strOutFldName, strInValue, strid_CurrEduCls_C) {
        //const strThisFuncName = "func";
        if ((0, clsString_js_2.IsNullOrEmpty)(strid_CurrEduCls_C) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strid_CurrEduCls_C]不能为空！(In clsgs_UserRelaPositionWApi.func)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls_C.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strid_CurrEduCls_C]的长度:[{0}]不正确！(clsgs_UserRelaPositionWApi.func)", strid_CurrEduCls_C.length);
            console.error(strMsg);
            throw (strMsg);
        }
        if (strInFldName != clsgs_UserRelaPositionEN_js_1.clsgs_UserRelaPositionEN.con_mId) {
            const strMsg = (0, clsString_js_2.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsgs_UserRelaPositionEN_js_1.clsgs_UserRelaPositionEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_2.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strOutFldName, clsgs_UserRelaPositionEN_js_1.clsgs_UserRelaPositionEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const lngmId = Number(strInValue);
        if (lngmId == 0) {
            return "";
        }
        const objgs_UserRelaPosition = await gs_UserRelaPosition_GetObjBymId_Cache(lngmId, strid_CurrEduCls_C);
        if (objgs_UserRelaPosition == null)
            return "";
        if (objgs_UserRelaPosition.GetFldValue(strOutFldName) == null)
            return "";
        return objgs_UserRelaPosition.GetFldValue(strOutFldName).toString();
    }
    exports.gs_UserRelaPosition_func = gs_UserRelaPosition_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function gs_UserRelaPosition_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.mId - b.mId;
    }
    exports.gs_UserRelaPosition_SortFun_Defa = gs_UserRelaPosition_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function gs_UserRelaPosition_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.userId == b.userId)
            return a.updUser.localeCompare(b.updUser);
        else
            return a.userId.localeCompare(b.userId);
    }
    exports.gs_UserRelaPosition_SortFun_Defa_2Fld = gs_UserRelaPosition_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function gs_UserRelaPosition_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsgs_UserRelaPositionEN_js_1.clsgs_UserRelaPositionEN.con_mId:
                    return (a, b) => {
                        return a.mId - b.mId;
                    };
                case clsgs_UserRelaPositionEN_js_1.clsgs_UserRelaPositionEN.con_UserId:
                    return (a, b) => {
                        if (a.userId == null)
                            return -1;
                        if (b.userId == null)
                            return 1;
                        return a.userId.localeCompare(b.userId);
                    };
                case clsgs_UserRelaPositionEN_js_1.clsgs_UserRelaPositionEN.con_UpdUser:
                    return (a, b) => {
                        if (a.updUser == null)
                            return -1;
                        if (b.updUser == null)
                            return 1;
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsgs_UserRelaPositionEN_js_1.clsgs_UserRelaPositionEN.con_UpdDate:
                    return (a, b) => {
                        if (a.updDate == null)
                            return -1;
                        if (b.updDate == null)
                            return 1;
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsgs_UserRelaPositionEN_js_1.clsgs_UserRelaPositionEN.con_id_CurrEduCls:
                    return (a, b) => {
                        if (a.id_CurrEduCls == null)
                            return -1;
                        if (b.id_CurrEduCls == null)
                            return 1;
                        return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
                    };
                case clsgs_UserRelaPositionEN_js_1.clsgs_UserRelaPositionEN.con_OrderNum:
                    return (a, b) => {
                        return a.orderNum - b.orderNum;
                    };
                case clsgs_UserRelaPositionEN_js_1.clsgs_UserRelaPositionEN.con_X_Position:
                    return (a, b) => {
                        return a.x_Position - b.x_Position;
                    };
                case clsgs_UserRelaPositionEN_js_1.clsgs_UserRelaPositionEN.con_Y_Position:
                    return (a, b) => {
                        return a.y_Position - b.y_Position;
                    };
                case clsgs_UserRelaPositionEN_js_1.clsgs_UserRelaPositionEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[gs_UserRelaPosition]中不存在！(in ${exports.gs_UserRelaPosition_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsgs_UserRelaPositionEN_js_1.clsgs_UserRelaPositionEN.con_mId:
                    return (a, b) => {
                        return b.mId - a.mId;
                    };
                case clsgs_UserRelaPositionEN_js_1.clsgs_UserRelaPositionEN.con_UserId:
                    return (a, b) => {
                        if (b.userId == null)
                            return -1;
                        if (a.userId == null)
                            return 1;
                        return b.userId.localeCompare(a.userId);
                    };
                case clsgs_UserRelaPositionEN_js_1.clsgs_UserRelaPositionEN.con_UpdUser:
                    return (a, b) => {
                        if (b.updUser == null)
                            return -1;
                        if (a.updUser == null)
                            return 1;
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsgs_UserRelaPositionEN_js_1.clsgs_UserRelaPositionEN.con_UpdDate:
                    return (a, b) => {
                        if (b.updDate == null)
                            return -1;
                        if (a.updDate == null)
                            return 1;
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsgs_UserRelaPositionEN_js_1.clsgs_UserRelaPositionEN.con_id_CurrEduCls:
                    return (a, b) => {
                        if (b.id_CurrEduCls == null)
                            return -1;
                        if (a.id_CurrEduCls == null)
                            return 1;
                        return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
                    };
                case clsgs_UserRelaPositionEN_js_1.clsgs_UserRelaPositionEN.con_OrderNum:
                    return (a, b) => {
                        return b.orderNum - a.orderNum;
                    };
                case clsgs_UserRelaPositionEN_js_1.clsgs_UserRelaPositionEN.con_X_Position:
                    return (a, b) => {
                        return b.x_Position - a.x_Position;
                    };
                case clsgs_UserRelaPositionEN_js_1.clsgs_UserRelaPositionEN.con_Y_Position:
                    return (a, b) => {
                        return b.y_Position - a.y_Position;
                    };
                case clsgs_UserRelaPositionEN_js_1.clsgs_UserRelaPositionEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[gs_UserRelaPosition]中不存在！(in ${exports.gs_UserRelaPosition_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.gs_UserRelaPosition_SortFunByKey = gs_UserRelaPosition_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function gs_UserRelaPosition_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsgs_UserRelaPositionEN_js_1.clsgs_UserRelaPositionEN.con_mId:
                return (obj) => {
                    return obj.mId === value;
                };
            case clsgs_UserRelaPositionEN_js_1.clsgs_UserRelaPositionEN.con_UserId:
                return (obj) => {
                    return obj.userId === value;
                };
            case clsgs_UserRelaPositionEN_js_1.clsgs_UserRelaPositionEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsgs_UserRelaPositionEN_js_1.clsgs_UserRelaPositionEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsgs_UserRelaPositionEN_js_1.clsgs_UserRelaPositionEN.con_id_CurrEduCls:
                return (obj) => {
                    return obj.id_CurrEduCls === value;
                };
            case clsgs_UserRelaPositionEN_js_1.clsgs_UserRelaPositionEN.con_OrderNum:
                return (obj) => {
                    return obj.orderNum === value;
                };
            case clsgs_UserRelaPositionEN_js_1.clsgs_UserRelaPositionEN.con_X_Position:
                return (obj) => {
                    return obj.x_Position === value;
                };
            case clsgs_UserRelaPositionEN_js_1.clsgs_UserRelaPositionEN.con_Y_Position:
                return (obj) => {
                    return obj.y_Position === value;
                };
            case clsgs_UserRelaPositionEN_js_1.clsgs_UserRelaPositionEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[gs_UserRelaPosition]中不存在！(in ${exports.gs_UserRelaPosition_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.gs_UserRelaPosition_FilterFunByKey = gs_UserRelaPosition_FilterFunByKey;
    /**
     * 映射函数。根据表映射把输入字段值，映射成输出字段值
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_funcKey)
     * @param strInFldName:输入字段名
     * @param strInValue:输入字段值
     * @param strComparisonOp:比较操作符
     @param strid_CurrEduCls:缓存的分类字段
     * @returns 返回一个关键字值列表
    */
    async function gs_UserRelaPosition_funcKey(strInFldName, strInValue, strComparisonOp, strid_CurrEduCls_C) {
        //const strThisFuncName = "funcKey";
        if ((0, clsString_js_2.IsNullOrEmpty)(strid_CurrEduCls_C) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strid_CurrEduCls_C]不能为空！(In clsgs_UserRelaPositionWApi.funcKey)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls_C.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strid_CurrEduCls_C]的长度:[{0}]不正确！(clsgs_UserRelaPositionWApi.funcKey)", strid_CurrEduCls_C.length);
            console.error(strMsg);
            throw (strMsg);
        }
        if (strInFldName == clsgs_UserRelaPositionEN_js_1.clsgs_UserRelaPositionEN.con_mId) {
            const strMsg = (0, clsString_js_2.Format)("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (Number(strInValue) == 0) {
            return [];
        }
        const arrgs_UserRelaPosition = await gs_UserRelaPosition_GetObjLst_Cache(strid_CurrEduCls_C);
        if (arrgs_UserRelaPosition == null)
            return [];
        let arrgs_UserRelaPosition_Sel = arrgs_UserRelaPosition;
        const strType = typeof (strInValue);
        switch (strType) {
            case "string":
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01: // " = "
                        arrgs_UserRelaPosition_Sel = arrgs_UserRelaPosition_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.Like_03:
                        arrgs_UserRelaPosition_Sel = arrgs_UserRelaPosition_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.In_04:
                        const arrValues = strInValue.split(',');
                        arrgs_UserRelaPosition_Sel = arrgs_UserRelaPosition_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
                        break;
                }
                break;
            case "boolean":
                if (strInValue == null)
                    return [];
                if (strComparisonOp == enumComparisonOp_js_1.enumComparisonOp.Equal_01) {
                    arrgs_UserRelaPosition_Sel = arrgs_UserRelaPosition_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                }
                break;
            case "number":
                if (Number(strInValue) == 0)
                    return [];
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01:
                        arrgs_UserRelaPosition_Sel = arrgs_UserRelaPosition_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotEqual_02:
                        arrgs_UserRelaPosition_Sel = arrgs_UserRelaPosition_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotLessThan_05: //" >= ":
                        arrgs_UserRelaPosition_Sel = arrgs_UserRelaPosition_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotGreaterThan_06: //" <= ":
                        arrgs_UserRelaPosition_Sel = arrgs_UserRelaPosition_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.GreaterThan_07: //" > ":
                        arrgs_UserRelaPosition_Sel = arrgs_UserRelaPosition_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.LessThan_08: //" < ":
                        arrgs_UserRelaPosition_Sel = arrgs_UserRelaPosition_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                }
                break;
        }
        if (arrgs_UserRelaPosition_Sel.length == 0)
            return [];
        return arrgs_UserRelaPosition_Sel.map(x => x.mId);
    }
    exports.gs_UserRelaPosition_funcKey = gs_UserRelaPosition_funcKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function gs_UserRelaPosition_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_UserRelaPosition_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_UserRelaPosition_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_UserRelaPosition_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_UserRelaPosition_GetFirstIDAsync = gs_UserRelaPosition_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function gs_UserRelaPosition_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_UserRelaPosition_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_UserRelaPosition_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_UserRelaPosition_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_UserRelaPosition_GetFirstID = gs_UserRelaPosition_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function gs_UserRelaPosition_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_UserRelaPosition_Controller, strAction);
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
                const objgs_UserRelaPosition = gs_UserRelaPosition_GetObjFromJsonObj(returnObj);
                return objgs_UserRelaPosition;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_UserRelaPosition_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_UserRelaPosition_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_UserRelaPosition_GetFirstObjAsync = gs_UserRelaPosition_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_UserRelaPosition_GetObjLst_ClientCache(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        if ((0, clsString_js_2.IsNullOrEmpty)(clsgs_UserRelaPositionEN_js_1.clsgs_UserRelaPositionEN.WhereFormat) == false) {
            strWhereCond = (0, clsString_js_2.Format)(clsgs_UserRelaPositionEN_js_1.clsgs_UserRelaPositionEN.WhereFormat, strid_CurrEduCls);
        }
        else {
            strWhereCond = (0, clsString_js_2.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        }
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsgs_UserRelaPositionEN_js_1.clsgs_UserRelaPositionEN._CurrTabName, strid_CurrEduCls);
        if ((0, clsString_js_2.IsNullOrEmpty)(clsgs_UserRelaPositionEN_js_1.clsgs_UserRelaPositionEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsgs_UserRelaPositionEN_js_1.clsgs_UserRelaPositionEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_1.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrgs_UserRelaPositionExObjLst_Cache = CacheHelper_js_1.CacheHelper.Get(strKey);
            const arrgs_UserRelaPositionObjLst_T = gs_UserRelaPosition_GetObjLstByJSONObjLst(arrgs_UserRelaPositionExObjLst_Cache);
            return arrgs_UserRelaPositionObjLst_T;
        }
        try {
            const arrgs_UserRelaPositionExObjLst = await gs_UserRelaPosition_GetObjLstAsync(strWhereCond);
            CacheHelper_js_1.CacheHelper.Add(strKey, arrgs_UserRelaPositionExObjLst);
            const strInfo = (0, clsString_js_2.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_UserRelaPositionExObjLst.length);
            console.log(strInfo);
            return arrgs_UserRelaPositionExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.gs_UserRelaPosition_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.gs_UserRelaPosition_GetObjLst_ClientCache = gs_UserRelaPosition_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_UserRelaPosition_GetObjLst_localStorage(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        if ((0, clsString_js_2.IsNullOrEmpty)(clsgs_UserRelaPositionEN_js_1.clsgs_UserRelaPositionEN.WhereFormat) == false) {
            strWhereCond = (0, clsString_js_2.Format)(clsgs_UserRelaPositionEN_js_1.clsgs_UserRelaPositionEN.WhereFormat, strid_CurrEduCls);
        }
        else {
            strWhereCond = (0, clsString_js_2.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        }
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsgs_UserRelaPositionEN_js_1.clsgs_UserRelaPositionEN._CurrTabName, strid_CurrEduCls);
        if ((0, clsString_js_2.IsNullOrEmpty)(clsgs_UserRelaPositionEN_js_1.clsgs_UserRelaPositionEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsgs_UserRelaPositionEN_js_1.clsgs_UserRelaPositionEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrgs_UserRelaPositionExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrgs_UserRelaPositionObjLst_T = gs_UserRelaPosition_GetObjLstByJSONObjLst(arrgs_UserRelaPositionExObjLst_Cache);
            return arrgs_UserRelaPositionObjLst_T;
        }
        try {
            const arrgs_UserRelaPositionExObjLst = await gs_UserRelaPosition_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrgs_UserRelaPositionExObjLst));
            const strInfo = (0, clsString_js_2.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_UserRelaPositionExObjLst.length);
            console.log(strInfo);
            return arrgs_UserRelaPositionExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.gs_UserRelaPosition_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.gs_UserRelaPosition_GetObjLst_localStorage = gs_UserRelaPosition_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_UserRelaPosition_GetObjLst_localStorage_PureCache(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_2.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsgs_UserRelaPositionEN_js_1.clsgs_UserRelaPositionEN._CurrTabName, strid_CurrEduCls);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrgs_UserRelaPositionObjLst_Cache = JSON.parse(strTempObjLst);
            return arrgs_UserRelaPositionObjLst_Cache;
        }
        else
            return null;
    }
    exports.gs_UserRelaPosition_GetObjLst_localStorage_PureCache = gs_UserRelaPosition_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function gs_UserRelaPosition_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_UserRelaPosition_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_UserRelaPosition_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_UserRelaPosition_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_UserRelaPosition_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_UserRelaPosition_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_UserRelaPosition_GetObjLstAsync = gs_UserRelaPosition_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_UserRelaPosition_GetObjLst_sessionStorage(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        if ((0, clsString_js_2.IsNullOrEmpty)(clsgs_UserRelaPositionEN_js_1.clsgs_UserRelaPositionEN.WhereFormat) == false) {
            strWhereCond = (0, clsString_js_2.Format)(clsgs_UserRelaPositionEN_js_1.clsgs_UserRelaPositionEN.WhereFormat, strid_CurrEduCls);
        }
        else {
            strWhereCond = (0, clsString_js_2.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        }
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsgs_UserRelaPositionEN_js_1.clsgs_UserRelaPositionEN._CurrTabName, strid_CurrEduCls);
        if ((0, clsString_js_2.IsNullOrEmpty)(clsgs_UserRelaPositionEN_js_1.clsgs_UserRelaPositionEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsgs_UserRelaPositionEN_js_1.clsgs_UserRelaPositionEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrgs_UserRelaPositionExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrgs_UserRelaPositionObjLst_T = gs_UserRelaPosition_GetObjLstByJSONObjLst(arrgs_UserRelaPositionExObjLst_Cache);
            return arrgs_UserRelaPositionObjLst_T;
        }
        try {
            const arrgs_UserRelaPositionExObjLst = await gs_UserRelaPosition_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrgs_UserRelaPositionExObjLst));
            const strInfo = (0, clsString_js_2.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_UserRelaPositionExObjLst.length);
            console.log(strInfo);
            return arrgs_UserRelaPositionExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.gs_UserRelaPosition_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.gs_UserRelaPosition_GetObjLst_sessionStorage = gs_UserRelaPosition_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_UserRelaPosition_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_2.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsgs_UserRelaPositionEN_js_1.clsgs_UserRelaPositionEN._CurrTabName, strid_CurrEduCls);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrgs_UserRelaPositionObjLst_Cache = JSON.parse(strTempObjLst);
            return arrgs_UserRelaPositionObjLst_Cache;
        }
        else
            return null;
    }
    exports.gs_UserRelaPosition_GetObjLst_sessionStorage_PureCache = gs_UserRelaPosition_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_UserRelaPosition_GetObjLst_Cache(strid_CurrEduCls) {
        //const strThisFuncName = "GetObjLst_Cache";
        if ((0, clsString_js_2.IsNullOrEmpty)(strid_CurrEduCls) == true) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[id_CurrEduCls]不能为空！(in clsgs_UserRelaPositionWApi.gs_UserRelaPosition_GetObjLst_Cache() )");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strid_CurrEduCls]的长度:[{0}]不正确！(in clsgs_UserRelaPositionWApi.gs_UserRelaPosition_GetObjLst_Cache() )", strid_CurrEduCls.length);
            console.error(strMsg);
            throw (strMsg);
        }
        let arrgs_UserRelaPositionObjLst_Cache;
        switch (clsgs_UserRelaPositionEN_js_1.clsgs_UserRelaPositionEN.CacheModeId) {
            case "04": //sessionStorage
                arrgs_UserRelaPositionObjLst_Cache = await gs_UserRelaPosition_GetObjLst_sessionStorage(strid_CurrEduCls);
                break;
            case "03": //localStorage
                arrgs_UserRelaPositionObjLst_Cache = await gs_UserRelaPosition_GetObjLst_localStorage(strid_CurrEduCls);
                break;
            case "02": //ClientCache
                arrgs_UserRelaPositionObjLst_Cache = await gs_UserRelaPosition_GetObjLst_ClientCache(strid_CurrEduCls);
                break;
            default:
                arrgs_UserRelaPositionObjLst_Cache = await gs_UserRelaPosition_GetObjLst_ClientCache(strid_CurrEduCls);
                break;
        }
        const arrgs_UserRelaPositionObjLst = gs_UserRelaPosition_GetObjLstByJSONObjLst(arrgs_UserRelaPositionObjLst_Cache);
        return arrgs_UserRelaPositionObjLst_Cache;
    }
    exports.gs_UserRelaPosition_GetObjLst_Cache = gs_UserRelaPosition_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_UserRelaPosition_GetObjLst_PureCache(strid_CurrEduCls) {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrgs_UserRelaPositionObjLst_Cache;
        switch (clsgs_UserRelaPositionEN_js_1.clsgs_UserRelaPositionEN.CacheModeId) {
            case "04": //sessionStorage
                arrgs_UserRelaPositionObjLst_Cache = await gs_UserRelaPosition_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls);
                break;
            case "03": //localStorage
                arrgs_UserRelaPositionObjLst_Cache = await gs_UserRelaPosition_GetObjLst_localStorage_PureCache(strid_CurrEduCls);
                break;
            case "02": //ClientCache
                arrgs_UserRelaPositionObjLst_Cache = null;
                break;
            default:
                arrgs_UserRelaPositionObjLst_Cache = null;
                break;
        }
        return arrgs_UserRelaPositionObjLst_Cache;
    }
    exports.gs_UserRelaPosition_GetObjLst_PureCache = gs_UserRelaPosition_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objlngmId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function gs_UserRelaPosition_GetSubObjLst_Cache(objgs_UserRelaPosition_Cond, strid_CurrEduCls) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrgs_UserRelaPositionObjLst_Cache = await gs_UserRelaPosition_GetObjLst_Cache(strid_CurrEduCls);
        let arrgs_UserRelaPosition_Sel = arrgs_UserRelaPositionObjLst_Cache;
        if (objgs_UserRelaPosition_Cond.sf_FldComparisonOp == null || objgs_UserRelaPosition_Cond.sf_FldComparisonOp == "")
            return arrgs_UserRelaPosition_Sel;
        const dicFldComparisonOp = JSON.parse(objgs_UserRelaPosition_Cond.sf_FldComparisonOp);
        //console.log("clsgs_UserRelaPositionWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objgs_UserRelaPosition_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrgs_UserRelaPosition_Sel = arrgs_UserRelaPosition_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objgs_UserRelaPosition_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_UserRelaPosition_Sel = arrgs_UserRelaPosition_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrgs_UserRelaPosition_Sel = arrgs_UserRelaPosition_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrgs_UserRelaPosition_Sel = arrgs_UserRelaPosition_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrgs_UserRelaPosition_Sel = arrgs_UserRelaPosition_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrgs_UserRelaPosition_Sel = arrgs_UserRelaPosition_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrgs_UserRelaPosition_Sel = arrgs_UserRelaPosition_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrgs_UserRelaPosition_Sel = arrgs_UserRelaPosition_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_UserRelaPosition_Sel = arrgs_UserRelaPosition_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_UserRelaPosition_Sel = arrgs_UserRelaPosition_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrgs_UserRelaPosition_Sel = arrgs_UserRelaPosition_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrgs_UserRelaPosition_Sel = arrgs_UserRelaPosition_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrgs_UserRelaPosition_Sel = arrgs_UserRelaPosition_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrgs_UserRelaPosition_Sel = arrgs_UserRelaPosition_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrgs_UserRelaPosition_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objgs_UserRelaPosition_Cond), exports.gs_UserRelaPosition_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.gs_UserRelaPosition_GetSubObjLst_Cache = gs_UserRelaPosition_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrmId:关键字列表
    * @returns 对象列表
    **/
    async function gs_UserRelaPosition_GetObjLstBymIdLstAsync(arrmId) {
        const strThisFuncName = "GetObjLstBymIdLstAsync";
        const strAction = "GetObjLstBymIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_UserRelaPosition_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrmId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_UserRelaPosition_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_UserRelaPosition_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_UserRelaPosition_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_UserRelaPosition_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_UserRelaPosition_GetObjLstBymIdLstAsync = gs_UserRelaPosition_GetObjLstBymIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrlngmIdLst:关键字列表
     * @returns 对象列表
    */
    async function gs_UserRelaPosition_GetObjLstBymIdLst_Cache(arrmIdLst, strid_CurrEduCls) {
        const strThisFuncName = "GetObjLstBymIdLst_Cache";
        try {
            const arrgs_UserRelaPositionObjLst_Cache = await gs_UserRelaPosition_GetObjLst_Cache(strid_CurrEduCls);
            const arrgs_UserRelaPosition_Sel = arrgs_UserRelaPositionObjLst_Cache.filter(x => arrmIdLst.indexOf(x.mId) > -1);
            return arrgs_UserRelaPosition_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrmIdLst.join(","), exports.gs_UserRelaPosition_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
    }
    exports.gs_UserRelaPosition_GetObjLstBymIdLst_Cache = gs_UserRelaPosition_GetObjLstBymIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function gs_UserRelaPosition_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_UserRelaPosition_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_UserRelaPosition_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_UserRelaPosition_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_UserRelaPosition_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_UserRelaPosition_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_UserRelaPosition_GetTopObjLstAsync = gs_UserRelaPosition_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function gs_UserRelaPosition_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_UserRelaPosition_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_UserRelaPosition_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_UserRelaPosition_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_UserRelaPosition_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_UserRelaPosition_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_UserRelaPosition_GetObjLstByRangeAsync = gs_UserRelaPosition_GetObjLstByRangeAsync;
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
    async function gs_UserRelaPosition_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_UserRelaPosition_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_UserRelaPosition_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_UserRelaPosition_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_UserRelaPosition_GetObjLstByRange = gs_UserRelaPosition_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function gs_UserRelaPosition_GetObjLstByPager_Cache(objPagerPara, strid_CurrEduCls) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const arrgs_UserRelaPositionObjLst_Cache = await gs_UserRelaPosition_GetObjLst_Cache(strid_CurrEduCls);
        if (arrgs_UserRelaPositionObjLst_Cache.length == 0)
            return arrgs_UserRelaPositionObjLst_Cache;
        let arrgs_UserRelaPosition_Sel = arrgs_UserRelaPositionObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objgs_UserRelaPosition_Cond = new clsgs_UserRelaPositionEN_js_1.clsgs_UserRelaPositionEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objgs_UserRelaPosition_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsgs_UserRelaPositionWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrgs_UserRelaPosition_Sel = arrgs_UserRelaPosition_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objgs_UserRelaPosition_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_UserRelaPosition_Sel = arrgs_UserRelaPosition_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrgs_UserRelaPosition_Sel = arrgs_UserRelaPosition_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrgs_UserRelaPosition_Sel = arrgs_UserRelaPosition_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrgs_UserRelaPosition_Sel = arrgs_UserRelaPosition_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrgs_UserRelaPosition_Sel = arrgs_UserRelaPosition_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrgs_UserRelaPosition_Sel = arrgs_UserRelaPosition_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrgs_UserRelaPosition_Sel = arrgs_UserRelaPosition_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrgs_UserRelaPosition_Sel = arrgs_UserRelaPosition_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_UserRelaPosition_Sel = arrgs_UserRelaPosition_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_UserRelaPosition_Sel = arrgs_UserRelaPosition_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrgs_UserRelaPosition_Sel = arrgs_UserRelaPosition_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrgs_UserRelaPosition_Sel = arrgs_UserRelaPosition_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrgs_UserRelaPosition_Sel = arrgs_UserRelaPosition_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrgs_UserRelaPosition_Sel = arrgs_UserRelaPosition_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrgs_UserRelaPosition_Sel.length == 0)
                return arrgs_UserRelaPosition_Sel;
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
                arrgs_UserRelaPosition_Sel = arrgs_UserRelaPosition_Sel.sort(gs_UserRelaPosition_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrgs_UserRelaPosition_Sel = arrgs_UserRelaPosition_Sel.sort(objPagerPara.sortFun);
            }
            arrgs_UserRelaPosition_Sel = arrgs_UserRelaPosition_Sel.slice(intStart, intEnd);
            return arrgs_UserRelaPosition_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.gs_UserRelaPosition_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.gs_UserRelaPosition_GetObjLstByPager_Cache = gs_UserRelaPosition_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function gs_UserRelaPosition_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_UserRelaPosition_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_UserRelaPosition_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_UserRelaPosition_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_UserRelaPosition_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_UserRelaPosition_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_UserRelaPosition_GetObjLstByPagerAsync = gs_UserRelaPosition_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param lngmId:关键字
    * @returns 获取删除的结果
    **/
    async function gs_UserRelaPosition_DelRecordAsync(lngmId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_UserRelaPosition_Controller, strAction);
        strUrl = (0, clsString_js_2.Format)("{0}/?Id={1}", strUrl, lngmId);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_UserRelaPosition_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_UserRelaPosition_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_UserRelaPosition_DelRecordAsync = gs_UserRelaPosition_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrmId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function gs_UserRelaPosition_Delgs_UserRelaPositionsAsync(arrmId) {
        const strThisFuncName = "Delgs_UserRelaPositionsAsync";
        const strAction = "Delgs_UserRelaPositions";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_UserRelaPosition_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_UserRelaPosition_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_UserRelaPosition_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_UserRelaPosition_Delgs_UserRelaPositionsAsync = gs_UserRelaPosition_Delgs_UserRelaPositionsAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function gs_UserRelaPosition_Delgs_UserRelaPositionsByCondAsync(strWhereCond) {
        const strThisFuncName = "Delgs_UserRelaPositionsByCondAsync";
        const strAction = "Delgs_UserRelaPositionsByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_UserRelaPosition_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_UserRelaPosition_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_UserRelaPosition_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_UserRelaPosition_Delgs_UserRelaPositionsByCondAsync = gs_UserRelaPosition_Delgs_UserRelaPositionsByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objgs_UserRelaPositionEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function gs_UserRelaPosition_AddNewRecordAsync(objgs_UserRelaPositionEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objgs_UserRelaPositionEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_UserRelaPosition_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_UserRelaPositionEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_UserRelaPosition_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_UserRelaPosition_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_UserRelaPosition_AddNewRecordAsync = gs_UserRelaPosition_AddNewRecordAsync;
    /* 数据类型不是字符型，不可以最大关键字的方式添加记录。*/
    /**
    * 把所给的关键字列表相关的记录移顶
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GoTopAsync)
    * @param objgs_UserRelaPositionEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function gs_UserRelaPosition_GoTopAsync(objOrderByData) {
        const strThisFuncName = "GoTopAsync";
        let strMsg = "";
        const strAction = "GoTop";
        if (objOrderByData.KeyIdLst.length == 0) {
            strMsg = "根据关键字列表置顶时，给定的关键字值列表不能为空!";
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_UserRelaPosition_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_UserRelaPosition_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_UserRelaPosition_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_UserRelaPosition_GoTopAsync = gs_UserRelaPosition_GoTopAsync;
    /**
    * 把所给的关键字列表相关的记录上移
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpMoveAsync)
    * @param objgs_UserRelaPositionEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function gs_UserRelaPosition_UpMoveAsync(objOrderByData) {
        const strThisFuncName = "UpMoveAsync";
        let strMsg = "";
        const strAction = "UpMove";
        if (objOrderByData.KeyIdLst.length == 0) {
            strMsg = "根据关键字列表上移时，给定的关键字值列表不能为空!";
            throw strMsg;
        }
        //var strJSON = JSON.stringify(objgs_UserRelaPositionEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_UserRelaPosition_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_UserRelaPosition_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_UserRelaPosition_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_UserRelaPosition_UpMoveAsync = gs_UserRelaPosition_UpMoveAsync;
    /**
    * 把所给的关键字列表相关的记录下移
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DownMoveAsync)
    * @param objgs_UserRelaPositionEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function gs_UserRelaPosition_DownMoveAsync(objOrderByData) {
        const strThisFuncName = "DownMoveAsync";
        let strMsg = "";
        const strAction = "DownMove";
        if (objOrderByData.KeyIdLst.length == 0) {
            strMsg = "根据关键字列表下移时，给定的关键字值列表不能为空!";
            throw strMsg;
        }
        //var strJSON = JSON.stringify(objgs_UserRelaPositionEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_UserRelaPosition_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_UserRelaPosition_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_UserRelaPosition_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_UserRelaPosition_DownMoveAsync = gs_UserRelaPosition_DownMoveAsync;
    /**
    * 把所给的关键字列表相关的记录移底
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GoBottomAsync)
    * @param objgs_UserRelaPositionEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function gs_UserRelaPosition_GoBottomAsync(objOrderByData) {
        const strThisFuncName = "GoBottomAsync";
        let strMsg = "";
        const strAction = "GoBottom";
        if (objOrderByData.KeyIdLst.length == 0) {
            strMsg = "根据关键字列表置底时，给定的关键字值列表不能为空!";
            throw strMsg;
        }
        //var strJSON = JSON.stringify(objgs_UserRelaPositionEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_UserRelaPosition_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_UserRelaPosition_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_UserRelaPosition_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_UserRelaPosition_GoBottomAsync = gs_UserRelaPosition_GoBottomAsync;
    /**
    * 把列表记录重序
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReOrderAsync)
    * @param objgs_UserRelaPositionEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function gs_UserRelaPosition_ReOrderAsync(objOrderByData) {
        const strThisFuncName = "ReOrderAsync";
        const strAction = "ReOrder";
        //var strJSON = JSON.stringify(objgs_UserRelaPositionEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_UserRelaPosition_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_UserRelaPosition_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_UserRelaPosition_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_UserRelaPosition_ReOrderAsync = gs_UserRelaPosition_ReOrderAsync;
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objgs_UserRelaPositionEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function gs_UserRelaPosition_AddNewRecordWithReturnKeyAsync(objgs_UserRelaPositionEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_UserRelaPosition_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_UserRelaPositionEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_UserRelaPosition_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_UserRelaPosition_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_UserRelaPosition_AddNewRecordWithReturnKeyAsync = gs_UserRelaPosition_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objgs_UserRelaPositionEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function gs_UserRelaPosition_AddNewRecordWithReturnKey(objgs_UserRelaPositionEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objgs_UserRelaPositionEN.mId === null || objgs_UserRelaPositionEN.mId === 0) {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_UserRelaPosition_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_UserRelaPositionEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_UserRelaPosition_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_UserRelaPosition_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_UserRelaPosition_AddNewRecordWithReturnKey = gs_UserRelaPosition_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objgs_UserRelaPositionEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function gs_UserRelaPosition_UpdateRecordAsync(objgs_UserRelaPositionEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objgs_UserRelaPositionEN.sf_UpdFldSetStr === undefined || objgs_UserRelaPositionEN.sf_UpdFldSetStr === null || objgs_UserRelaPositionEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_UserRelaPositionEN.mId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_UserRelaPosition_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_UserRelaPositionEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_UserRelaPosition_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_UserRelaPosition_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_UserRelaPosition_UpdateRecordAsync = gs_UserRelaPosition_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objgs_UserRelaPositionEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function gs_UserRelaPosition_UpdateWithConditionAsync(objgs_UserRelaPositionEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objgs_UserRelaPositionEN.sf_UpdFldSetStr === undefined || objgs_UserRelaPositionEN.sf_UpdFldSetStr === null || objgs_UserRelaPositionEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_UserRelaPositionEN.mId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_UserRelaPosition_Controller, strAction);
        objgs_UserRelaPositionEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objgs_UserRelaPositionEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_UserRelaPosition_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_UserRelaPosition_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_UserRelaPosition_UpdateWithConditionAsync = gs_UserRelaPosition_UpdateWithConditionAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objlngmId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function gs_UserRelaPosition_IsExistRecord_Cache(objgs_UserRelaPosition_Cond, strid_CurrEduCls) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrgs_UserRelaPositionObjLst_Cache = await gs_UserRelaPosition_GetObjLst_Cache(strid_CurrEduCls);
        if (arrgs_UserRelaPositionObjLst_Cache == null)
            return false;
        let arrgs_UserRelaPosition_Sel = arrgs_UserRelaPositionObjLst_Cache;
        if (objgs_UserRelaPosition_Cond.sf_FldComparisonOp == null || objgs_UserRelaPosition_Cond.sf_FldComparisonOp == "")
            return arrgs_UserRelaPosition_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objgs_UserRelaPosition_Cond.sf_FldComparisonOp);
        //console.log("clsgs_UserRelaPositionWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objgs_UserRelaPosition_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objgs_UserRelaPosition_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_UserRelaPosition_Sel = arrgs_UserRelaPosition_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrgs_UserRelaPosition_Sel = arrgs_UserRelaPosition_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrgs_UserRelaPosition_Sel = arrgs_UserRelaPosition_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrgs_UserRelaPosition_Sel = arrgs_UserRelaPosition_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrgs_UserRelaPosition_Sel = arrgs_UserRelaPosition_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrgs_UserRelaPosition_Sel = arrgs_UserRelaPosition_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrgs_UserRelaPosition_Sel = arrgs_UserRelaPosition_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_UserRelaPosition_Sel = arrgs_UserRelaPosition_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_UserRelaPosition_Sel = arrgs_UserRelaPosition_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrgs_UserRelaPosition_Sel = arrgs_UserRelaPosition_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrgs_UserRelaPosition_Sel = arrgs_UserRelaPosition_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrgs_UserRelaPosition_Sel = arrgs_UserRelaPosition_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrgs_UserRelaPosition_Sel = arrgs_UserRelaPosition_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrgs_UserRelaPosition_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objgs_UserRelaPosition_Cond), exports.gs_UserRelaPosition_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.gs_UserRelaPosition_IsExistRecord_Cache = gs_UserRelaPosition_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function gs_UserRelaPosition_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_UserRelaPosition_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_UserRelaPosition_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_UserRelaPosition_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_UserRelaPosition_IsExistRecordAsync = gs_UserRelaPosition_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param lngmId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function gs_UserRelaPosition_IsExist(lngmId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_UserRelaPosition_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_UserRelaPosition_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_UserRelaPosition_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_UserRelaPosition_IsExist = gs_UserRelaPosition_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param lngmId:所给的关键字
     * @returns 对象
    */
    async function gs_UserRelaPosition_IsExist_Cache(lngmId, strid_CurrEduCls) {
        const strThisFuncName = "IsExist_Cache";
        const arrgs_UserRelaPositionObjLst_Cache = await gs_UserRelaPosition_GetObjLst_Cache(strid_CurrEduCls);
        if (arrgs_UserRelaPositionObjLst_Cache == null)
            return false;
        try {
            const arrgs_UserRelaPosition_Sel = arrgs_UserRelaPositionObjLst_Cache.filter(x => x.mId == lngmId);
            if (arrgs_UserRelaPosition_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", lngmId, exports.gs_UserRelaPosition_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.gs_UserRelaPosition_IsExist_Cache = gs_UserRelaPosition_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param lngmId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function gs_UserRelaPosition_IsExistAsync(lngmId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_UserRelaPosition_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_UserRelaPosition_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_UserRelaPosition_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_UserRelaPosition_IsExistAsync = gs_UserRelaPosition_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function gs_UserRelaPosition_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_UserRelaPosition_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_UserRelaPosition_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_UserRelaPosition_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_UserRelaPosition_GetRecCountByCondAsync = gs_UserRelaPosition_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objgs_UserRelaPosition_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function gs_UserRelaPosition_GetRecCountByCond_Cache(objgs_UserRelaPosition_Cond, strid_CurrEduCls) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrgs_UserRelaPositionObjLst_Cache = await gs_UserRelaPosition_GetObjLst_Cache(strid_CurrEduCls);
        if (arrgs_UserRelaPositionObjLst_Cache == null)
            return 0;
        let arrgs_UserRelaPosition_Sel = arrgs_UserRelaPositionObjLst_Cache;
        if (objgs_UserRelaPosition_Cond.sf_FldComparisonOp == null || objgs_UserRelaPosition_Cond.sf_FldComparisonOp == "")
            return arrgs_UserRelaPosition_Sel.length;
        const dicFldComparisonOp = JSON.parse(objgs_UserRelaPosition_Cond.sf_FldComparisonOp);
        //console.log("clsgs_UserRelaPositionWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objgs_UserRelaPosition_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrgs_UserRelaPosition_Sel = arrgs_UserRelaPosition_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objgs_UserRelaPosition_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_UserRelaPosition_Sel = arrgs_UserRelaPosition_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrgs_UserRelaPosition_Sel = arrgs_UserRelaPosition_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrgs_UserRelaPosition_Sel = arrgs_UserRelaPosition_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrgs_UserRelaPosition_Sel = arrgs_UserRelaPosition_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrgs_UserRelaPosition_Sel = arrgs_UserRelaPosition_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrgs_UserRelaPosition_Sel = arrgs_UserRelaPosition_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrgs_UserRelaPosition_Sel = arrgs_UserRelaPosition_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrgs_UserRelaPosition_Sel = arrgs_UserRelaPosition_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_UserRelaPosition_Sel = arrgs_UserRelaPosition_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_UserRelaPosition_Sel = arrgs_UserRelaPosition_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrgs_UserRelaPosition_Sel = arrgs_UserRelaPosition_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrgs_UserRelaPosition_Sel = arrgs_UserRelaPosition_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrgs_UserRelaPosition_Sel = arrgs_UserRelaPosition_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrgs_UserRelaPosition_Sel = arrgs_UserRelaPosition_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrgs_UserRelaPosition_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objgs_UserRelaPosition_Cond), exports.gs_UserRelaPosition_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.gs_UserRelaPosition_GetRecCountByCond_Cache = gs_UserRelaPosition_GetRecCountByCond_Cache;
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
    async function gs_UserRelaPosition_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_UserRelaPosition_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_UserRelaPosition_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_UserRelaPosition_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_UserRelaPosition_GetMaxStrIdByPrefix = gs_UserRelaPosition_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function gs_UserRelaPosition_GetWebApiUrl(strController, strAction) {
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
    exports.gs_UserRelaPosition_GetWebApiUrl = gs_UserRelaPosition_GetWebApiUrl;
    /**
    * 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshCache)
    **/
    function gs_UserRelaPosition_ReFreshCache(strid_CurrEduCls) {
        const strThisFuncName = "ReFreshCache";
        if ((0, clsString_js_2.IsNullOrEmpty)(strid_CurrEduCls) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strid_CurrEduCls]不能为空！(In clsgs_UserRelaPositionWApi.clsgs_UserRelaPositionWApi.ReFreshCache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strid_CurrEduCls]的长度:[{0}]不正确！(clsgs_UserRelaPositionWApi.clsgs_UserRelaPositionWApi.ReFreshCache)", strid_CurrEduCls.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strMsg = (0, clsString_js_2.Format)("刷新缓存成功！");
        console.trace(strMsg);
        // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsgs_UserRelaPositionEN_js_1.clsgs_UserRelaPositionEN._CurrTabName, strid_CurrEduCls);
        switch (clsgs_UserRelaPositionEN_js_1.clsgs_UserRelaPositionEN.CacheModeId) {
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
    }
    exports.gs_UserRelaPosition_ReFreshCache = gs_UserRelaPosition_ReFreshCache;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function gs_UserRelaPosition_ReFreshThisCache(strid_CurrEduCls) {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsgs_UserRelaPositionEN_js_1.clsgs_UserRelaPositionEN._CurrTabName, strid_CurrEduCls);
            switch (clsgs_UserRelaPositionEN_js_1.clsgs_UserRelaPositionEN.CacheModeId) {
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
    exports.gs_UserRelaPosition_ReFreshThisCache = gs_UserRelaPosition_ReFreshThisCache;
    /* 该表的下拉框功能没有设置，不需要生成下拉框绑定函数。*/
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function gs_UserRelaPosition_CheckPropertyNew(pobjgs_UserRelaPositionEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_UserRelaPositionEN.userId) == false && (0, clsString_js_2.GetStrLen)(pobjgs_UserRelaPositionEN.userId) > 18) {
            throw new Error("(errid:Watl000059)字段[用户ID(userId)]的长度不能超过18(In 用户关系坐标位置(gs_UserRelaPosition))!值:$(pobjgs_UserRelaPositionEN.userId)(clsgs_UserRelaPositionBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_UserRelaPositionEN.updUser) == false && (0, clsString_js_2.GetStrLen)(pobjgs_UserRelaPositionEN.updUser) > 20) {
            throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 用户关系坐标位置(gs_UserRelaPosition))!值:$(pobjgs_UserRelaPositionEN.updUser)(clsgs_UserRelaPositionBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_UserRelaPositionEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjgs_UserRelaPositionEN.updDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 用户关系坐标位置(gs_UserRelaPosition))!值:$(pobjgs_UserRelaPositionEN.updDate)(clsgs_UserRelaPositionBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_UserRelaPositionEN.id_CurrEduCls) == false && (0, clsString_js_2.GetStrLen)(pobjgs_UserRelaPositionEN.id_CurrEduCls) > 8) {
            throw new Error("(errid:Watl000059)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 用户关系坐标位置(gs_UserRelaPosition))!值:$(pobjgs_UserRelaPositionEN.id_CurrEduCls)(clsgs_UserRelaPositionBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_UserRelaPositionEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjgs_UserRelaPositionEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 用户关系坐标位置(gs_UserRelaPosition))!值:$(pobjgs_UserRelaPositionEN.memo)(clsgs_UserRelaPositionBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if (null != pobjgs_UserRelaPositionEN.mId && undefined !== pobjgs_UserRelaPositionEN.mId && clsString_js_1.tzDataType.isNumber(pobjgs_UserRelaPositionEN.mId) === false) {
            throw new Error("(errid:Watl000060)字段[mId(mId)]的值:[$(pobjgs_UserRelaPositionEN.mId)], 非法，应该为数值型(In 用户关系坐标位置(gs_UserRelaPosition))!(clsgs_UserRelaPositionBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_UserRelaPositionEN.userId) == false && undefined !== pobjgs_UserRelaPositionEN.userId && clsString_js_1.tzDataType.isString(pobjgs_UserRelaPositionEN.userId) === false) {
            throw new Error("(errid:Watl000060)字段[用户ID(userId)]的值:[$(pobjgs_UserRelaPositionEN.userId)], 非法，应该为字符型(In 用户关系坐标位置(gs_UserRelaPosition))!(clsgs_UserRelaPositionBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_UserRelaPositionEN.updUser) == false && undefined !== pobjgs_UserRelaPositionEN.updUser && clsString_js_1.tzDataType.isString(pobjgs_UserRelaPositionEN.updUser) === false) {
            throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjgs_UserRelaPositionEN.updUser)], 非法，应该为字符型(In 用户关系坐标位置(gs_UserRelaPosition))!(clsgs_UserRelaPositionBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_UserRelaPositionEN.updDate) == false && undefined !== pobjgs_UserRelaPositionEN.updDate && clsString_js_1.tzDataType.isString(pobjgs_UserRelaPositionEN.updDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjgs_UserRelaPositionEN.updDate)], 非法，应该为字符型(In 用户关系坐标位置(gs_UserRelaPosition))!(clsgs_UserRelaPositionBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_UserRelaPositionEN.id_CurrEduCls) == false && undefined !== pobjgs_UserRelaPositionEN.id_CurrEduCls && clsString_js_1.tzDataType.isString(pobjgs_UserRelaPositionEN.id_CurrEduCls) === false) {
            throw new Error("(errid:Watl000060)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjgs_UserRelaPositionEN.id_CurrEduCls)], 非法，应该为字符型(In 用户关系坐标位置(gs_UserRelaPosition))!(clsgs_UserRelaPositionBL:CheckPropertyNew)");
        }
        if (null != pobjgs_UserRelaPositionEN.orderNum && undefined !== pobjgs_UserRelaPositionEN.orderNum && clsString_js_1.tzDataType.isNumber(pobjgs_UserRelaPositionEN.orderNum) === false) {
            throw new Error("(errid:Watl000060)字段[序号(orderNum)]的值:[$(pobjgs_UserRelaPositionEN.orderNum)], 非法，应该为数值型(In 用户关系坐标位置(gs_UserRelaPosition))!(clsgs_UserRelaPositionBL:CheckPropertyNew)");
        }
        if (null != pobjgs_UserRelaPositionEN.x_Position && undefined !== pobjgs_UserRelaPositionEN.x_Position && clsString_js_1.tzDataType.isNumber(pobjgs_UserRelaPositionEN.x_Position) === false) {
            throw new Error("(errid:Watl000060)字段[X_坐标(x_Position)]的值:[$(pobjgs_UserRelaPositionEN.x_Position)], 非法，应该为数值型(In 用户关系坐标位置(gs_UserRelaPosition))!(clsgs_UserRelaPositionBL:CheckPropertyNew)");
        }
        if (null != pobjgs_UserRelaPositionEN.y_Position && undefined !== pobjgs_UserRelaPositionEN.y_Position && clsString_js_1.tzDataType.isNumber(pobjgs_UserRelaPositionEN.y_Position) === false) {
            throw new Error("(errid:Watl000060)字段[Y_坐标(y_Position)]的值:[$(pobjgs_UserRelaPositionEN.y_Position)], 非法，应该为数值型(In 用户关系坐标位置(gs_UserRelaPosition))!(clsgs_UserRelaPositionBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_UserRelaPositionEN.memo) == false && undefined !== pobjgs_UserRelaPositionEN.memo && clsString_js_1.tzDataType.isString(pobjgs_UserRelaPositionEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjgs_UserRelaPositionEN.memo)], 非法，应该为字符型(In 用户关系坐标位置(gs_UserRelaPosition))!(clsgs_UserRelaPositionBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjgs_UserRelaPositionEN.SetIsCheckProperty(true);
    }
    exports.gs_UserRelaPosition_CheckPropertyNew = gs_UserRelaPosition_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function gs_UserRelaPosition_CheckProperty4Update(pobjgs_UserRelaPositionEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_UserRelaPositionEN.userId) == false && (0, clsString_js_2.GetStrLen)(pobjgs_UserRelaPositionEN.userId) > 18) {
            throw new Error("(errid:Watl000062)字段[用户ID(userId)]的长度不能超过18(In 用户关系坐标位置(gs_UserRelaPosition))!值:$(pobjgs_UserRelaPositionEN.userId)(clsgs_UserRelaPositionBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_UserRelaPositionEN.updUser) == false && (0, clsString_js_2.GetStrLen)(pobjgs_UserRelaPositionEN.updUser) > 20) {
            throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 用户关系坐标位置(gs_UserRelaPosition))!值:$(pobjgs_UserRelaPositionEN.updUser)(clsgs_UserRelaPositionBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_UserRelaPositionEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjgs_UserRelaPositionEN.updDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 用户关系坐标位置(gs_UserRelaPosition))!值:$(pobjgs_UserRelaPositionEN.updDate)(clsgs_UserRelaPositionBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_UserRelaPositionEN.id_CurrEduCls) == false && (0, clsString_js_2.GetStrLen)(pobjgs_UserRelaPositionEN.id_CurrEduCls) > 8) {
            throw new Error("(errid:Watl000062)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 用户关系坐标位置(gs_UserRelaPosition))!值:$(pobjgs_UserRelaPositionEN.id_CurrEduCls)(clsgs_UserRelaPositionBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_UserRelaPositionEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjgs_UserRelaPositionEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 用户关系坐标位置(gs_UserRelaPosition))!值:$(pobjgs_UserRelaPositionEN.memo)(clsgs_UserRelaPositionBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if (null != pobjgs_UserRelaPositionEN.mId && undefined !== pobjgs_UserRelaPositionEN.mId && clsString_js_1.tzDataType.isNumber(pobjgs_UserRelaPositionEN.mId) === false) {
            throw new Error("(errid:Watl000063)字段[mId(mId)]的值:[$(pobjgs_UserRelaPositionEN.mId)], 非法，应该为数值型(In 用户关系坐标位置(gs_UserRelaPosition))!(clsgs_UserRelaPositionBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_UserRelaPositionEN.userId) == false && undefined !== pobjgs_UserRelaPositionEN.userId && clsString_js_1.tzDataType.isString(pobjgs_UserRelaPositionEN.userId) === false) {
            throw new Error("(errid:Watl000063)字段[用户ID(userId)]的值:[$(pobjgs_UserRelaPositionEN.userId)], 非法，应该为字符型(In 用户关系坐标位置(gs_UserRelaPosition))!(clsgs_UserRelaPositionBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_UserRelaPositionEN.updUser) == false && undefined !== pobjgs_UserRelaPositionEN.updUser && clsString_js_1.tzDataType.isString(pobjgs_UserRelaPositionEN.updUser) === false) {
            throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjgs_UserRelaPositionEN.updUser)], 非法，应该为字符型(In 用户关系坐标位置(gs_UserRelaPosition))!(clsgs_UserRelaPositionBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_UserRelaPositionEN.updDate) == false && undefined !== pobjgs_UserRelaPositionEN.updDate && clsString_js_1.tzDataType.isString(pobjgs_UserRelaPositionEN.updDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjgs_UserRelaPositionEN.updDate)], 非法，应该为字符型(In 用户关系坐标位置(gs_UserRelaPosition))!(clsgs_UserRelaPositionBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_UserRelaPositionEN.id_CurrEduCls) == false && undefined !== pobjgs_UserRelaPositionEN.id_CurrEduCls && clsString_js_1.tzDataType.isString(pobjgs_UserRelaPositionEN.id_CurrEduCls) === false) {
            throw new Error("(errid:Watl000063)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjgs_UserRelaPositionEN.id_CurrEduCls)], 非法，应该为字符型(In 用户关系坐标位置(gs_UserRelaPosition))!(clsgs_UserRelaPositionBL:CheckProperty4Update)");
        }
        if (null != pobjgs_UserRelaPositionEN.orderNum && undefined !== pobjgs_UserRelaPositionEN.orderNum && clsString_js_1.tzDataType.isNumber(pobjgs_UserRelaPositionEN.orderNum) === false) {
            throw new Error("(errid:Watl000063)字段[序号(orderNum)]的值:[$(pobjgs_UserRelaPositionEN.orderNum)], 非法，应该为数值型(In 用户关系坐标位置(gs_UserRelaPosition))!(clsgs_UserRelaPositionBL:CheckProperty4Update)");
        }
        if (null != pobjgs_UserRelaPositionEN.x_Position && undefined !== pobjgs_UserRelaPositionEN.x_Position && clsString_js_1.tzDataType.isNumber(pobjgs_UserRelaPositionEN.x_Position) === false) {
            throw new Error("(errid:Watl000063)字段[X_坐标(x_Position)]的值:[$(pobjgs_UserRelaPositionEN.x_Position)], 非法，应该为数值型(In 用户关系坐标位置(gs_UserRelaPosition))!(clsgs_UserRelaPositionBL:CheckProperty4Update)");
        }
        if (null != pobjgs_UserRelaPositionEN.y_Position && undefined !== pobjgs_UserRelaPositionEN.y_Position && clsString_js_1.tzDataType.isNumber(pobjgs_UserRelaPositionEN.y_Position) === false) {
            throw new Error("(errid:Watl000063)字段[Y_坐标(y_Position)]的值:[$(pobjgs_UserRelaPositionEN.y_Position)], 非法，应该为数值型(In 用户关系坐标位置(gs_UserRelaPosition))!(clsgs_UserRelaPositionBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_UserRelaPositionEN.memo) == false && undefined !== pobjgs_UserRelaPositionEN.memo && clsString_js_1.tzDataType.isString(pobjgs_UserRelaPositionEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjgs_UserRelaPositionEN.memo)], 非法，应该为字符型(In 用户关系坐标位置(gs_UserRelaPosition))!(clsgs_UserRelaPositionBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if (null === pobjgs_UserRelaPositionEN.mId
            || pobjgs_UserRelaPositionEN.mId != null && pobjgs_UserRelaPositionEN.mId.toString() === "") {
            throw new Error("(errid:Watl000064)字段[mId]不能为空(In 用户关系坐标位置)!(clsgs_UserRelaPositionBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjgs_UserRelaPositionEN.SetIsCheckProperty(true);
    }
    exports.gs_UserRelaPosition_CheckProperty4Update = gs_UserRelaPosition_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function gs_UserRelaPosition_GetJSONStrByObj(pobjgs_UserRelaPositionEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjgs_UserRelaPositionEN.sf_UpdFldSetStr = pobjgs_UserRelaPositionEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjgs_UserRelaPositionEN);
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
    exports.gs_UserRelaPosition_GetJSONStrByObj = gs_UserRelaPosition_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function gs_UserRelaPosition_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrgs_UserRelaPositionObjLst = new Array();
        if (strJSON === "") {
            return arrgs_UserRelaPositionObjLst;
        }
        try {
            arrgs_UserRelaPositionObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrgs_UserRelaPositionObjLst;
        }
        return arrgs_UserRelaPositionObjLst;
    }
    exports.gs_UserRelaPosition_GetObjLstByJSONStr = gs_UserRelaPosition_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrgs_UserRelaPositionObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function gs_UserRelaPosition_GetObjLstByJSONObjLst(arrgs_UserRelaPositionObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrgs_UserRelaPositionObjLst = new Array();
        for (const objInFor of arrgs_UserRelaPositionObjLstS) {
            const obj1 = gs_UserRelaPosition_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrgs_UserRelaPositionObjLst.push(obj1);
        }
        return arrgs_UserRelaPositionObjLst;
    }
    exports.gs_UserRelaPosition_GetObjLstByJSONObjLst = gs_UserRelaPosition_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function gs_UserRelaPosition_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjgs_UserRelaPositionEN = new clsgs_UserRelaPositionEN_js_1.clsgs_UserRelaPositionEN();
        if (strJSON === "") {
            return pobjgs_UserRelaPositionEN;
        }
        try {
            pobjgs_UserRelaPositionEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjgs_UserRelaPositionEN;
        }
        return pobjgs_UserRelaPositionEN;
    }
    exports.gs_UserRelaPosition_GetObjByJSONStr = gs_UserRelaPosition_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function gs_UserRelaPosition_GetCombineCondition(objgs_UserRelaPosition_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objgs_UserRelaPosition_Cond.dicFldComparisonOp, clsgs_UserRelaPositionEN_js_1.clsgs_UserRelaPositionEN.con_mId) == true) {
            const strComparisonOp_mId = objgs_UserRelaPosition_Cond.dicFldComparisonOp[clsgs_UserRelaPositionEN_js_1.clsgs_UserRelaPositionEN.con_mId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsgs_UserRelaPositionEN_js_1.clsgs_UserRelaPositionEN.con_mId, objgs_UserRelaPosition_Cond.mId, strComparisonOp_mId);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_UserRelaPosition_Cond.dicFldComparisonOp, clsgs_UserRelaPositionEN_js_1.clsgs_UserRelaPositionEN.con_UserId) == true) {
            const strComparisonOp_UserId = objgs_UserRelaPosition_Cond.dicFldComparisonOp[clsgs_UserRelaPositionEN_js_1.clsgs_UserRelaPositionEN.con_UserId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_UserRelaPositionEN_js_1.clsgs_UserRelaPositionEN.con_UserId, objgs_UserRelaPosition_Cond.userId, strComparisonOp_UserId);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_UserRelaPosition_Cond.dicFldComparisonOp, clsgs_UserRelaPositionEN_js_1.clsgs_UserRelaPositionEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objgs_UserRelaPosition_Cond.dicFldComparisonOp[clsgs_UserRelaPositionEN_js_1.clsgs_UserRelaPositionEN.con_UpdUser];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_UserRelaPositionEN_js_1.clsgs_UserRelaPositionEN.con_UpdUser, objgs_UserRelaPosition_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_UserRelaPosition_Cond.dicFldComparisonOp, clsgs_UserRelaPositionEN_js_1.clsgs_UserRelaPositionEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objgs_UserRelaPosition_Cond.dicFldComparisonOp[clsgs_UserRelaPositionEN_js_1.clsgs_UserRelaPositionEN.con_UpdDate];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_UserRelaPositionEN_js_1.clsgs_UserRelaPositionEN.con_UpdDate, objgs_UserRelaPosition_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_UserRelaPosition_Cond.dicFldComparisonOp, clsgs_UserRelaPositionEN_js_1.clsgs_UserRelaPositionEN.con_id_CurrEduCls) == true) {
            const strComparisonOp_id_CurrEduCls = objgs_UserRelaPosition_Cond.dicFldComparisonOp[clsgs_UserRelaPositionEN_js_1.clsgs_UserRelaPositionEN.con_id_CurrEduCls];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_UserRelaPositionEN_js_1.clsgs_UserRelaPositionEN.con_id_CurrEduCls, objgs_UserRelaPosition_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_UserRelaPosition_Cond.dicFldComparisonOp, clsgs_UserRelaPositionEN_js_1.clsgs_UserRelaPositionEN.con_OrderNum) == true) {
            const strComparisonOp_OrderNum = objgs_UserRelaPosition_Cond.dicFldComparisonOp[clsgs_UserRelaPositionEN_js_1.clsgs_UserRelaPositionEN.con_OrderNum];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsgs_UserRelaPositionEN_js_1.clsgs_UserRelaPositionEN.con_OrderNum, objgs_UserRelaPosition_Cond.orderNum, strComparisonOp_OrderNum);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_UserRelaPosition_Cond.dicFldComparisonOp, clsgs_UserRelaPositionEN_js_1.clsgs_UserRelaPositionEN.con_X_Position) == true) {
            const strComparisonOp_X_Position = objgs_UserRelaPosition_Cond.dicFldComparisonOp[clsgs_UserRelaPositionEN_js_1.clsgs_UserRelaPositionEN.con_X_Position];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsgs_UserRelaPositionEN_js_1.clsgs_UserRelaPositionEN.con_X_Position, objgs_UserRelaPosition_Cond.x_Position, strComparisonOp_X_Position);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_UserRelaPosition_Cond.dicFldComparisonOp, clsgs_UserRelaPositionEN_js_1.clsgs_UserRelaPositionEN.con_Y_Position) == true) {
            const strComparisonOp_Y_Position = objgs_UserRelaPosition_Cond.dicFldComparisonOp[clsgs_UserRelaPositionEN_js_1.clsgs_UserRelaPositionEN.con_Y_Position];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsgs_UserRelaPositionEN_js_1.clsgs_UserRelaPositionEN.con_Y_Position, objgs_UserRelaPosition_Cond.y_Position, strComparisonOp_Y_Position);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_UserRelaPosition_Cond.dicFldComparisonOp, clsgs_UserRelaPositionEN_js_1.clsgs_UserRelaPositionEN.con_Memo) == true) {
            const strComparisonOp_Memo = objgs_UserRelaPosition_Cond.dicFldComparisonOp[clsgs_UserRelaPositionEN_js_1.clsgs_UserRelaPositionEN.con_Memo];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_UserRelaPositionEN_js_1.clsgs_UserRelaPositionEN.con_Memo, objgs_UserRelaPosition_Cond.memo, strComparisonOp_Memo);
        }
        return strWhereCond;
    }
    exports.gs_UserRelaPosition_GetCombineCondition = gs_UserRelaPosition_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--gs_UserRelaPosition(用户关系坐标位置),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param lngmId: mId(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function gs_UserRelaPosition_GetUniCondStr_mId(objgs_UserRelaPositionEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and mId = '{0}'", objgs_UserRelaPositionEN.mId);
        return strWhereCond;
    }
    exports.gs_UserRelaPosition_GetUniCondStr_mId = gs_UserRelaPosition_GetUniCondStr_mId;
    /**
    *获取唯一性条件串(Uniqueness)--gs_UserRelaPosition(用户关系坐标位置),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param lngmId: mId(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function gs_UserRelaPosition_GetUniCondStr4Update_mId(objgs_UserRelaPositionEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and mId <> '{0}'", objgs_UserRelaPositionEN.mId);
        strWhereCond += (0, clsString_js_2.Format)(" and mId = '{0}'", objgs_UserRelaPositionEN.mId);
        return strWhereCond;
    }
    exports.gs_UserRelaPosition_GetUniCondStr4Update_mId = gs_UserRelaPosition_GetUniCondStr4Update_mId;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objgs_UserRelaPositionENS:源对象
     * @param objgs_UserRelaPositionENT:目标对象
    */
    function gs_UserRelaPosition_CopyObjTo(objgs_UserRelaPositionENS, objgs_UserRelaPositionENT) {
        objgs_UserRelaPositionENT.mId = objgs_UserRelaPositionENS.mId; //mId
        objgs_UserRelaPositionENT.userId = objgs_UserRelaPositionENS.userId; //用户ID
        objgs_UserRelaPositionENT.updUser = objgs_UserRelaPositionENS.updUser; //修改人
        objgs_UserRelaPositionENT.updDate = objgs_UserRelaPositionENS.updDate; //修改日期
        objgs_UserRelaPositionENT.id_CurrEduCls = objgs_UserRelaPositionENS.id_CurrEduCls; //教学班流水号
        objgs_UserRelaPositionENT.orderNum = objgs_UserRelaPositionENS.orderNum; //序号
        objgs_UserRelaPositionENT.x_Position = objgs_UserRelaPositionENS.x_Position; //X_坐标
        objgs_UserRelaPositionENT.y_Position = objgs_UserRelaPositionENS.y_Position; //Y_坐标
        objgs_UserRelaPositionENT.memo = objgs_UserRelaPositionENS.memo; //备注
        objgs_UserRelaPositionENT.sf_UpdFldSetStr = objgs_UserRelaPositionENS.updFldString; //sf_UpdFldSetStr
    }
    exports.gs_UserRelaPosition_CopyObjTo = gs_UserRelaPosition_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objgs_UserRelaPositionENS:源对象
     * @param objgs_UserRelaPositionENT:目标对象
    */
    function gs_UserRelaPosition_GetObjFromJsonObj(objgs_UserRelaPositionENS) {
        const objgs_UserRelaPositionENT = new clsgs_UserRelaPositionEN_js_1.clsgs_UserRelaPositionEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objgs_UserRelaPositionENT, objgs_UserRelaPositionENS);
        return objgs_UserRelaPositionENT;
    }
    exports.gs_UserRelaPosition_GetObjFromJsonObj = gs_UserRelaPosition_GetObjFromJsonObj;
});
