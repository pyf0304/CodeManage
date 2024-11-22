/**
* 类名:clsvSysScoreWeightWApi
* 表名:vSysScoreWeight(01120630)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/13 00:47:49
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
        define(["require", "exports", "axios", "../../PubFun/enumComparisonOp.js", "../../PubFun/CacheHelper.js", "../../L0_Entity/GraduateEduTools/clsvSysScoreWeightEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.vSysScoreWeight_GetObjFromJsonObj = exports.vSysScoreWeight_CopyObjTo = exports.vSysScoreWeight_GetCombineCondition = exports.vSysScoreWeight_GetObjByJSONStr = exports.vSysScoreWeight_GetObjLstByJSONObjLst = exports.vSysScoreWeight_GetObjLstByJSONStr = exports.vSysScoreWeight_GetJSONStrByObj = exports.vSysScoreWeight_ReFreshThisCache = exports.vSysScoreWeight_GetWebApiUrl = exports.vSysScoreWeight_GetRecCountByCond_Cache = exports.vSysScoreWeight_GetRecCountByCondAsync = exports.vSysScoreWeight_IsExistAsync = exports.vSysScoreWeight_IsExist_Cache = exports.vSysScoreWeight_IsExist = exports.vSysScoreWeight_IsExistRecordAsync = exports.vSysScoreWeight_IsExistRecord_Cache = exports.vSysScoreWeight_GetObjLstByPagerAsync = exports.vSysScoreWeight_GetObjLstByPager_Cache = exports.vSysScoreWeight_GetObjLstByRange = exports.vSysScoreWeight_GetObjLstByRangeAsync = exports.vSysScoreWeight_GetTopObjLstAsync = exports.vSysScoreWeight_GetObjLstByScoreWeightIdLst_Cache = exports.vSysScoreWeight_GetObjLstByScoreWeightIdLstAsync = exports.vSysScoreWeight_GetSubObjLst_Cache = exports.vSysScoreWeight_GetObjLst_PureCache = exports.vSysScoreWeight_GetObjLst_Cache = exports.vSysScoreWeight_GetObjLst_sessionStorage_PureCache = exports.vSysScoreWeight_GetObjLst_sessionStorage = exports.vSysScoreWeight_GetObjLstAsync = exports.vSysScoreWeight_GetObjLst_localStorage_PureCache = exports.vSysScoreWeight_GetObjLst_localStorage = exports.vSysScoreWeight_GetObjLst_ClientCache = exports.vSysScoreWeight_GetFirstObjAsync = exports.vSysScoreWeight_GetFirstID = exports.vSysScoreWeight_GetFirstIDAsync = exports.vSysScoreWeight_funcKey = exports.vSysScoreWeight_FilterFunByKey = exports.vSysScoreWeight_SortFunByKey = exports.vSysScoreWeight_SortFun_Defa_2Fld = exports.vSysScoreWeight_SortFun_Defa = exports.vSysScoreWeight_func = exports.vSysScoreWeight_GetObjByScoreWeightId_localStorage = exports.vSysScoreWeight_GetObjByScoreWeightId_Cache = exports.vSysScoreWeight_GetObjByScoreWeightIdAsync = exports.vSysScoreWeight_ConstructorName = exports.vSysScoreWeight_Controller = void 0;
    /**
     * v系统分数权重表(vSysScoreWeight)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月13日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const enumComparisonOp_js_1 = require("../../PubFun/enumComparisonOp.js");
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsvSysScoreWeightEN_js_1 = require("../../L0_Entity/GraduateEduTools/clsvSysScoreWeightEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.vSysScoreWeight_Controller = "vSysScoreWeightApi";
    exports.vSysScoreWeight_ConstructorName = "vSysScoreWeight";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strScoreWeightId:关键字
    * @returns 对象
    **/
    async function vSysScoreWeight_GetObjByScoreWeightIdAsync(strScoreWeightId) {
        const strThisFuncName = "GetObjByScoreWeightIdAsync";
        if ((0, clsString_js_1.IsNullOrEmpty)(strScoreWeightId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strScoreWeightId]不能为空！(In clsvSysScoreWeightWApi.GetObjByScoreWeightIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strScoreWeightId.length != 1) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strScoreWeightId]的长度:[{0}]不正确！(clsvSysScoreWeightWApi.GetObjByScoreWeightIdAsync)", strScoreWeightId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByScoreWeightId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vSysScoreWeight_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "strScoreWeightId": strScoreWeightId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    return null;
                }
                //console.log(returnObj);
                const objvSysScoreWeight = vSysScoreWeight_GetObjFromJsonObj(returnObj);
                return objvSysScoreWeight;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vSysScoreWeight_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vSysScoreWeight_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vSysScoreWeight_GetObjByScoreWeightIdAsync = vSysScoreWeight_GetObjByScoreWeightIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param strScoreWeightId:所给的关键字
     * @returns 对象
    */
    async function vSysScoreWeight_GetObjByScoreWeightId_Cache(strScoreWeightId, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByScoreWeightId_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strScoreWeightId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strScoreWeightId]不能为空！(In clsvSysScoreWeightWApi.GetObjByScoreWeightId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strScoreWeightId.length != 1) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strScoreWeightId]的长度:[{0}]不正确！(clsvSysScoreWeightWApi.GetObjByScoreWeightId_Cache)", strScoreWeightId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrvSysScoreWeightObjLst_Cache = await vSysScoreWeight_GetObjLst_Cache();
        try {
            const arrvSysScoreWeight_Sel = arrvSysScoreWeightObjLst_Cache.filter(x => x.scoreWeightId == strScoreWeightId);
            let objvSysScoreWeight;
            if (arrvSysScoreWeight_Sel.length > 0) {
                objvSysScoreWeight = arrvSysScoreWeight_Sel[0];
                return objvSysScoreWeight;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    const objvSysScoreWeight_Const = await vSysScoreWeight_GetObjByScoreWeightIdAsync(strScoreWeightId);
                    if (objvSysScoreWeight_Const != null) {
                        vSysScoreWeight_ReFreshThisCache();
                        return objvSysScoreWeight_Const;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strScoreWeightId, exports.vSysScoreWeight_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.vSysScoreWeight_GetObjByScoreWeightId_Cache = vSysScoreWeight_GetObjByScoreWeightId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param strScoreWeightId:所给的关键字
     * @returns 对象
    */
    async function vSysScoreWeight_GetObjByScoreWeightId_localStorage(strScoreWeightId) {
        const strThisFuncName = "GetObjByScoreWeightId_localStorage";
        if ((0, clsString_js_1.IsNullOrEmpty)(strScoreWeightId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strScoreWeightId]不能为空！(In clsvSysScoreWeightWApi.GetObjByScoreWeightId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strScoreWeightId.length != 1) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strScoreWeightId]的长度:[{0}]不正确！(clsvSysScoreWeightWApi.GetObjByScoreWeightId_localStorage)", strScoreWeightId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvSysScoreWeightEN_js_1.clsvSysScoreWeightEN._CurrTabName, strScoreWeightId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objvSysScoreWeight_Cache = JSON.parse(strTempObj);
            return objvSysScoreWeight_Cache;
        }
        try {
            const objvSysScoreWeight = await vSysScoreWeight_GetObjByScoreWeightIdAsync(strScoreWeightId);
            if (objvSysScoreWeight != null) {
                localStorage.setItem(strKey, JSON.stringify(objvSysScoreWeight));
                const strInfo = (0, clsString_js_1.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objvSysScoreWeight;
            }
            return objvSysScoreWeight;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strScoreWeightId, exports.vSysScoreWeight_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.vSysScoreWeight_GetObjByScoreWeightId_localStorage = vSysScoreWeight_GetObjByScoreWeightId_localStorage;
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
    async function vSysScoreWeight_func(strInFldName, strOutFldName, strInValue) {
        //const strThisFuncName = "func";
        if (strInFldName != clsvSysScoreWeightEN_js_1.clsvSysScoreWeightEN.con_ScoreWeightId) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsvSysScoreWeightEN_js_1.clsvSysScoreWeightEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_1.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strOutFldName, clsvSysScoreWeightEN_js_1.clsvSysScoreWeightEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strScoreWeightId = strInValue;
        if ((0, clsString_js_1.IsNullOrEmpty)(strInValue) == true) {
            return "";
        }
        const objvSysScoreWeight = await vSysScoreWeight_GetObjByScoreWeightId_Cache(strScoreWeightId);
        if (objvSysScoreWeight == null)
            return "";
        if (objvSysScoreWeight.GetFldValue(strOutFldName) == null)
            return "";
        return objvSysScoreWeight.GetFldValue(strOutFldName).toString();
    }
    exports.vSysScoreWeight_func = vSysScoreWeight_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vSysScoreWeight_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.scoreWeightId.localeCompare(b.scoreWeightId);
    }
    exports.vSysScoreWeight_SortFun_Defa = vSysScoreWeight_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vSysScoreWeight_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.scoreWeightValue == b.scoreWeightValue)
            return a.updDate.localeCompare(b.updDate);
        else
            return a.scoreWeightValue.localeCompare(b.scoreWeightValue);
    }
    exports.vSysScoreWeight_SortFun_Defa_2Fld = vSysScoreWeight_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vSysScoreWeight_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsvSysScoreWeightEN_js_1.clsvSysScoreWeightEN.con_ScoreWeightId:
                    return (a, b) => {
                        return a.scoreWeightId.localeCompare(b.scoreWeightId);
                    };
                case clsvSysScoreWeightEN_js_1.clsvSysScoreWeightEN.con_ScoreWeightValue:
                    return (a, b) => {
                        return a.scoreWeightValue.localeCompare(b.scoreWeightValue);
                    };
                case clsvSysScoreWeightEN_js_1.clsvSysScoreWeightEN.con_IsPublic:
                    return (a, b) => {
                        if (a.isPublic == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvSysScoreWeightEN_js_1.clsvSysScoreWeightEN.con_UpdDate:
                    return (a, b) => {
                        if (a.updDate == null)
                            return -1;
                        if (b.updDate == null)
                            return 1;
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsvSysScoreWeightEN_js_1.clsvSysScoreWeightEN.con_UpdUser:
                    return (a, b) => {
                        if (a.updUser == null)
                            return -1;
                        if (b.updUser == null)
                            return 1;
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsvSysScoreWeightEN_js_1.clsvSysScoreWeightEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                case clsvSysScoreWeightEN_js_1.clsvSysScoreWeightEN.con_ScoreTypeId:
                    return (a, b) => {
                        if (a.scoreTypeId == null)
                            return -1;
                        if (b.scoreTypeId == null)
                            return 1;
                        return a.scoreTypeId.localeCompare(b.scoreTypeId);
                    };
                case clsvSysScoreWeightEN_js_1.clsvSysScoreWeightEN.con_ScoreTypeName:
                    return (a, b) => {
                        if (a.scoreTypeName == null)
                            return -1;
                        if (b.scoreTypeName == null)
                            return 1;
                        return a.scoreTypeName.localeCompare(b.scoreTypeName);
                    };
                case clsvSysScoreWeightEN_js_1.clsvSysScoreWeightEN.con_OnlyId:
                    return (a, b) => {
                        if (a.onlyId == null)
                            return -1;
                        if (b.onlyId == null)
                            return 1;
                        return a.onlyId.localeCompare(b.onlyId);
                    };
                case clsvSysScoreWeightEN_js_1.clsvSysScoreWeightEN.con_id_CurrEduCls:
                    return (a, b) => {
                        if (a.id_CurrEduCls == null)
                            return -1;
                        if (b.id_CurrEduCls == null)
                            return 1;
                        return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
                    };
                case clsvSysScoreWeightEN_js_1.clsvSysScoreWeightEN.con_CurrEduClsId:
                    return (a, b) => {
                        return a.currEduClsId.localeCompare(b.currEduClsId);
                    };
                case clsvSysScoreWeightEN_js_1.clsvSysScoreWeightEN.con_EduClsName:
                    return (a, b) => {
                        if (a.eduClsName == null)
                            return -1;
                        if (b.eduClsName == null)
                            return 1;
                        return a.eduClsName.localeCompare(b.eduClsName);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vSysScoreWeight]中不存在！(in ${exports.vSysScoreWeight_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsvSysScoreWeightEN_js_1.clsvSysScoreWeightEN.con_ScoreWeightId:
                    return (a, b) => {
                        return b.scoreWeightId.localeCompare(a.scoreWeightId);
                    };
                case clsvSysScoreWeightEN_js_1.clsvSysScoreWeightEN.con_ScoreWeightValue:
                    return (a, b) => {
                        return b.scoreWeightValue.localeCompare(a.scoreWeightValue);
                    };
                case clsvSysScoreWeightEN_js_1.clsvSysScoreWeightEN.con_IsPublic:
                    return (a, b) => {
                        if (b.isPublic == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvSysScoreWeightEN_js_1.clsvSysScoreWeightEN.con_UpdDate:
                    return (a, b) => {
                        if (b.updDate == null)
                            return -1;
                        if (a.updDate == null)
                            return 1;
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsvSysScoreWeightEN_js_1.clsvSysScoreWeightEN.con_UpdUser:
                    return (a, b) => {
                        if (b.updUser == null)
                            return -1;
                        if (a.updUser == null)
                            return 1;
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsvSysScoreWeightEN_js_1.clsvSysScoreWeightEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                case clsvSysScoreWeightEN_js_1.clsvSysScoreWeightEN.con_ScoreTypeId:
                    return (a, b) => {
                        if (b.scoreTypeId == null)
                            return -1;
                        if (a.scoreTypeId == null)
                            return 1;
                        return b.scoreTypeId.localeCompare(a.scoreTypeId);
                    };
                case clsvSysScoreWeightEN_js_1.clsvSysScoreWeightEN.con_ScoreTypeName:
                    return (a, b) => {
                        if (b.scoreTypeName == null)
                            return -1;
                        if (a.scoreTypeName == null)
                            return 1;
                        return b.scoreTypeName.localeCompare(a.scoreTypeName);
                    };
                case clsvSysScoreWeightEN_js_1.clsvSysScoreWeightEN.con_OnlyId:
                    return (a, b) => {
                        if (b.onlyId == null)
                            return -1;
                        if (a.onlyId == null)
                            return 1;
                        return b.onlyId.localeCompare(a.onlyId);
                    };
                case clsvSysScoreWeightEN_js_1.clsvSysScoreWeightEN.con_id_CurrEduCls:
                    return (a, b) => {
                        if (b.id_CurrEduCls == null)
                            return -1;
                        if (a.id_CurrEduCls == null)
                            return 1;
                        return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
                    };
                case clsvSysScoreWeightEN_js_1.clsvSysScoreWeightEN.con_CurrEduClsId:
                    return (a, b) => {
                        return b.currEduClsId.localeCompare(a.currEduClsId);
                    };
                case clsvSysScoreWeightEN_js_1.clsvSysScoreWeightEN.con_EduClsName:
                    return (a, b) => {
                        if (b.eduClsName == null)
                            return -1;
                        if (a.eduClsName == null)
                            return 1;
                        return b.eduClsName.localeCompare(a.eduClsName);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vSysScoreWeight]中不存在！(in ${exports.vSysScoreWeight_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.vSysScoreWeight_SortFunByKey = vSysScoreWeight_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function vSysScoreWeight_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsvSysScoreWeightEN_js_1.clsvSysScoreWeightEN.con_ScoreWeightId:
                return (obj) => {
                    return obj.scoreWeightId === value;
                };
            case clsvSysScoreWeightEN_js_1.clsvSysScoreWeightEN.con_ScoreWeightValue:
                return (obj) => {
                    return obj.scoreWeightValue === value;
                };
            case clsvSysScoreWeightEN_js_1.clsvSysScoreWeightEN.con_IsPublic:
                return (obj) => {
                    return obj.isPublic === value;
                };
            case clsvSysScoreWeightEN_js_1.clsvSysScoreWeightEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsvSysScoreWeightEN_js_1.clsvSysScoreWeightEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsvSysScoreWeightEN_js_1.clsvSysScoreWeightEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            case clsvSysScoreWeightEN_js_1.clsvSysScoreWeightEN.con_ScoreTypeId:
                return (obj) => {
                    return obj.scoreTypeId === value;
                };
            case clsvSysScoreWeightEN_js_1.clsvSysScoreWeightEN.con_ScoreTypeName:
                return (obj) => {
                    return obj.scoreTypeName === value;
                };
            case clsvSysScoreWeightEN_js_1.clsvSysScoreWeightEN.con_OnlyId:
                return (obj) => {
                    return obj.onlyId === value;
                };
            case clsvSysScoreWeightEN_js_1.clsvSysScoreWeightEN.con_id_CurrEduCls:
                return (obj) => {
                    return obj.id_CurrEduCls === value;
                };
            case clsvSysScoreWeightEN_js_1.clsvSysScoreWeightEN.con_CurrEduClsId:
                return (obj) => {
                    return obj.currEduClsId === value;
                };
            case clsvSysScoreWeightEN_js_1.clsvSysScoreWeightEN.con_EduClsName:
                return (obj) => {
                    return obj.eduClsName === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[vSysScoreWeight]中不存在！(in ${exports.vSysScoreWeight_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.vSysScoreWeight_FilterFunByKey = vSysScoreWeight_FilterFunByKey;
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
    async function vSysScoreWeight_funcKey(strInFldName, strInValue, strComparisonOp) {
        //const strThisFuncName = "funcKey";
        if (strInFldName == clsvSysScoreWeightEN_js_1.clsvSysScoreWeightEN.con_ScoreWeightId) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(strInValue) == true) {
            return [];
        }
        const arrvSysScoreWeight = await vSysScoreWeight_GetObjLst_Cache();
        if (arrvSysScoreWeight == null)
            return [];
        let arrvSysScoreWeight_Sel = arrvSysScoreWeight;
        const strType = typeof (strInValue);
        switch (strType) {
            case "string":
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01: // " = "
                        arrvSysScoreWeight_Sel = arrvSysScoreWeight_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.Like_03:
                        arrvSysScoreWeight_Sel = arrvSysScoreWeight_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.In_04:
                        const arrValues = strInValue.split(',');
                        arrvSysScoreWeight_Sel = arrvSysScoreWeight_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
                        break;
                }
                break;
            case "boolean":
                if (strInValue == null)
                    return [];
                if (strComparisonOp == enumComparisonOp_js_1.enumComparisonOp.Equal_01) {
                    arrvSysScoreWeight_Sel = arrvSysScoreWeight_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                }
                break;
            case "number":
                if (Number(strInValue) == 0)
                    return [];
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01:
                        arrvSysScoreWeight_Sel = arrvSysScoreWeight_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotEqual_02:
                        arrvSysScoreWeight_Sel = arrvSysScoreWeight_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotLessThan_05: //" >= ":
                        arrvSysScoreWeight_Sel = arrvSysScoreWeight_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotGreaterThan_06: //" <= ":
                        arrvSysScoreWeight_Sel = arrvSysScoreWeight_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.GreaterThan_07: //" > ":
                        arrvSysScoreWeight_Sel = arrvSysScoreWeight_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.LessThan_08: //" < ":
                        arrvSysScoreWeight_Sel = arrvSysScoreWeight_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                }
                break;
        }
        if (arrvSysScoreWeight_Sel.length == 0)
            return [];
        return arrvSysScoreWeight_Sel.map(x => x.scoreWeightId);
    }
    exports.vSysScoreWeight_funcKey = vSysScoreWeight_funcKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function vSysScoreWeight_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vSysScoreWeight_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vSysScoreWeight_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vSysScoreWeight_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vSysScoreWeight_GetFirstIDAsync = vSysScoreWeight_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function vSysScoreWeight_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vSysScoreWeight_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vSysScoreWeight_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vSysScoreWeight_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vSysScoreWeight_GetFirstID = vSysScoreWeight_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function vSysScoreWeight_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vSysScoreWeight_Controller, strAction);
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
                const objvSysScoreWeight = vSysScoreWeight_GetObjFromJsonObj(returnObj);
                return objvSysScoreWeight;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vSysScoreWeight_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vSysScoreWeight_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vSysScoreWeight_GetFirstObjAsync = vSysScoreWeight_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vSysScoreWeight_GetObjLst_ClientCache() {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsvSysScoreWeightEN_js_1.clsvSysScoreWeightEN._CurrTabName;
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvSysScoreWeightEN_js_1.clsvSysScoreWeightEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvSysScoreWeightEN_js_1.clsvSysScoreWeightEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_1.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrvSysScoreWeightExObjLst_Cache = CacheHelper_js_1.CacheHelper.Get(strKey);
            const arrvSysScoreWeightObjLst_T = vSysScoreWeight_GetObjLstByJSONObjLst(arrvSysScoreWeightExObjLst_Cache);
            return arrvSysScoreWeightObjLst_T;
        }
        try {
            const arrvSysScoreWeightExObjLst = await vSysScoreWeight_GetObjLstAsync(strWhereCond);
            CacheHelper_js_1.CacheHelper.Add(strKey, arrvSysScoreWeightExObjLst);
            const strInfo = (0, clsString_js_1.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvSysScoreWeightExObjLst.length);
            console.log(strInfo);
            return arrvSysScoreWeightExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vSysScoreWeight_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vSysScoreWeight_GetObjLst_ClientCache = vSysScoreWeight_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vSysScoreWeight_GetObjLst_localStorage() {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsvSysScoreWeightEN_js_1.clsvSysScoreWeightEN._CurrTabName;
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvSysScoreWeightEN_js_1.clsvSysScoreWeightEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvSysScoreWeightEN_js_1.clsvSysScoreWeightEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrvSysScoreWeightExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrvSysScoreWeightObjLst_T = vSysScoreWeight_GetObjLstByJSONObjLst(arrvSysScoreWeightExObjLst_Cache);
            return arrvSysScoreWeightObjLst_T;
        }
        try {
            const arrvSysScoreWeightExObjLst = await vSysScoreWeight_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrvSysScoreWeightExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvSysScoreWeightExObjLst.length);
            console.log(strInfo);
            return arrvSysScoreWeightExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vSysScoreWeight_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vSysScoreWeight_GetObjLst_localStorage = vSysScoreWeight_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vSysScoreWeight_GetObjLst_localStorage_PureCache() {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsvSysScoreWeightEN_js_1.clsvSysScoreWeightEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrvSysScoreWeightObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvSysScoreWeightObjLst_Cache;
        }
        else
            return null;
    }
    exports.vSysScoreWeight_GetObjLst_localStorage_PureCache = vSysScoreWeight_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function vSysScoreWeight_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vSysScoreWeight_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vSysScoreWeight_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vSysScoreWeight_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vSysScoreWeight_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vSysScoreWeight_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vSysScoreWeight_GetObjLstAsync = vSysScoreWeight_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vSysScoreWeight_GetObjLst_sessionStorage() {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsvSysScoreWeightEN_js_1.clsvSysScoreWeightEN._CurrTabName;
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvSysScoreWeightEN_js_1.clsvSysScoreWeightEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvSysScoreWeightEN_js_1.clsvSysScoreWeightEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrvSysScoreWeightExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrvSysScoreWeightObjLst_T = vSysScoreWeight_GetObjLstByJSONObjLst(arrvSysScoreWeightExObjLst_Cache);
            return arrvSysScoreWeightObjLst_T;
        }
        try {
            const arrvSysScoreWeightExObjLst = await vSysScoreWeight_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrvSysScoreWeightExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvSysScoreWeightExObjLst.length);
            console.log(strInfo);
            return arrvSysScoreWeightExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vSysScoreWeight_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vSysScoreWeight_GetObjLst_sessionStorage = vSysScoreWeight_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vSysScoreWeight_GetObjLst_sessionStorage_PureCache() {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsvSysScoreWeightEN_js_1.clsvSysScoreWeightEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrvSysScoreWeightObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvSysScoreWeightObjLst_Cache;
        }
        else
            return null;
    }
    exports.vSysScoreWeight_GetObjLst_sessionStorage_PureCache = vSysScoreWeight_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vSysScoreWeight_GetObjLst_Cache() {
        //const strThisFuncName = "GetObjLst_Cache";
        let arrvSysScoreWeightObjLst_Cache;
        switch (clsvSysScoreWeightEN_js_1.clsvSysScoreWeightEN.CacheModeId) {
            case "04": //sessionStorage
                arrvSysScoreWeightObjLst_Cache = await vSysScoreWeight_GetObjLst_sessionStorage();
                break;
            case "03": //localStorage
                arrvSysScoreWeightObjLst_Cache = await vSysScoreWeight_GetObjLst_localStorage();
                break;
            case "02": //ClientCache
                arrvSysScoreWeightObjLst_Cache = await vSysScoreWeight_GetObjLst_ClientCache();
                break;
            default:
                arrvSysScoreWeightObjLst_Cache = await vSysScoreWeight_GetObjLst_ClientCache();
                break;
        }
        const arrvSysScoreWeightObjLst = vSysScoreWeight_GetObjLstByJSONObjLst(arrvSysScoreWeightObjLst_Cache);
        return arrvSysScoreWeightObjLst_Cache;
    }
    exports.vSysScoreWeight_GetObjLst_Cache = vSysScoreWeight_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vSysScoreWeight_GetObjLst_PureCache() {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrvSysScoreWeightObjLst_Cache;
        switch (clsvSysScoreWeightEN_js_1.clsvSysScoreWeightEN.CacheModeId) {
            case "04": //sessionStorage
                arrvSysScoreWeightObjLst_Cache = await vSysScoreWeight_GetObjLst_sessionStorage_PureCache();
                break;
            case "03": //localStorage
                arrvSysScoreWeightObjLst_Cache = await vSysScoreWeight_GetObjLst_localStorage_PureCache();
                break;
            case "02": //ClientCache
                arrvSysScoreWeightObjLst_Cache = null;
                break;
            default:
                arrvSysScoreWeightObjLst_Cache = null;
                break;
        }
        return arrvSysScoreWeightObjLst_Cache;
    }
    exports.vSysScoreWeight_GetObjLst_PureCache = vSysScoreWeight_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objstrScoreWeightId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function vSysScoreWeight_GetSubObjLst_Cache(objvSysScoreWeight_Cond) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrvSysScoreWeightObjLst_Cache = await vSysScoreWeight_GetObjLst_Cache();
        let arrvSysScoreWeight_Sel = arrvSysScoreWeightObjLst_Cache;
        if (objvSysScoreWeight_Cond.sf_FldComparisonOp == null || objvSysScoreWeight_Cond.sf_FldComparisonOp == "")
            return arrvSysScoreWeight_Sel;
        const dicFldComparisonOp = JSON.parse(objvSysScoreWeight_Cond.sf_FldComparisonOp);
        //console.log("clsvSysScoreWeightWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvSysScoreWeight_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvSysScoreWeight_Sel = arrvSysScoreWeight_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvSysScoreWeight_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvSysScoreWeight_Sel = arrvSysScoreWeight_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvSysScoreWeight_Sel = arrvSysScoreWeight_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvSysScoreWeight_Sel = arrvSysScoreWeight_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvSysScoreWeight_Sel = arrvSysScoreWeight_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvSysScoreWeight_Sel = arrvSysScoreWeight_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvSysScoreWeight_Sel = arrvSysScoreWeight_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvSysScoreWeight_Sel = arrvSysScoreWeight_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvSysScoreWeight_Sel = arrvSysScoreWeight_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvSysScoreWeight_Sel = arrvSysScoreWeight_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvSysScoreWeight_Sel = arrvSysScoreWeight_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvSysScoreWeight_Sel = arrvSysScoreWeight_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvSysScoreWeight_Sel = arrvSysScoreWeight_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvSysScoreWeight_Sel = arrvSysScoreWeight_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrvSysScoreWeight_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objvSysScoreWeight_Cond), exports.vSysScoreWeight_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vSysScoreWeight_GetSubObjLst_Cache = vSysScoreWeight_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrScoreWeightId:关键字列表
    * @returns 对象列表
    **/
    async function vSysScoreWeight_GetObjLstByScoreWeightIdLstAsync(arrScoreWeightId) {
        const strThisFuncName = "GetObjLstByScoreWeightIdLstAsync";
        const strAction = "GetObjLstByScoreWeightIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vSysScoreWeight_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrScoreWeightId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vSysScoreWeight_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vSysScoreWeight_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vSysScoreWeight_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vSysScoreWeight_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vSysScoreWeight_GetObjLstByScoreWeightIdLstAsync = vSysScoreWeight_GetObjLstByScoreWeightIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrstrScoreWeightIdLst:关键字列表
     * @returns 对象列表
    */
    async function vSysScoreWeight_GetObjLstByScoreWeightIdLst_Cache(arrScoreWeightIdLst) {
        const strThisFuncName = "GetObjLstByScoreWeightIdLst_Cache";
        try {
            const arrvSysScoreWeightObjLst_Cache = await vSysScoreWeight_GetObjLst_Cache();
            const arrvSysScoreWeight_Sel = arrvSysScoreWeightObjLst_Cache.filter(x => arrScoreWeightIdLst.indexOf(x.scoreWeightId) > -1);
            return arrvSysScoreWeight_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrScoreWeightIdLst.join(","), exports.vSysScoreWeight_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
    }
    exports.vSysScoreWeight_GetObjLstByScoreWeightIdLst_Cache = vSysScoreWeight_GetObjLstByScoreWeightIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function vSysScoreWeight_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vSysScoreWeight_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vSysScoreWeight_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vSysScoreWeight_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vSysScoreWeight_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vSysScoreWeight_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vSysScoreWeight_GetTopObjLstAsync = vSysScoreWeight_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vSysScoreWeight_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vSysScoreWeight_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vSysScoreWeight_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vSysScoreWeight_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vSysScoreWeight_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vSysScoreWeight_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vSysScoreWeight_GetObjLstByRangeAsync = vSysScoreWeight_GetObjLstByRangeAsync;
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
    async function vSysScoreWeight_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vSysScoreWeight_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vSysScoreWeight_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vSysScoreWeight_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vSysScoreWeight_GetObjLstByRange = vSysScoreWeight_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function vSysScoreWeight_GetObjLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const arrvSysScoreWeightObjLst_Cache = await vSysScoreWeight_GetObjLst_Cache();
        if (arrvSysScoreWeightObjLst_Cache.length == 0)
            return arrvSysScoreWeightObjLst_Cache;
        let arrvSysScoreWeight_Sel = arrvSysScoreWeightObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objvSysScoreWeight_Cond = new clsvSysScoreWeightEN_js_1.clsvSysScoreWeightEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvSysScoreWeight_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsvSysScoreWeightWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvSysScoreWeight_Sel = arrvSysScoreWeight_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvSysScoreWeight_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvSysScoreWeight_Sel = arrvSysScoreWeight_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvSysScoreWeight_Sel = arrvSysScoreWeight_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvSysScoreWeight_Sel = arrvSysScoreWeight_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvSysScoreWeight_Sel = arrvSysScoreWeight_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvSysScoreWeight_Sel = arrvSysScoreWeight_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvSysScoreWeight_Sel = arrvSysScoreWeight_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvSysScoreWeight_Sel = arrvSysScoreWeight_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrvSysScoreWeight_Sel = arrvSysScoreWeight_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvSysScoreWeight_Sel = arrvSysScoreWeight_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvSysScoreWeight_Sel = arrvSysScoreWeight_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvSysScoreWeight_Sel = arrvSysScoreWeight_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvSysScoreWeight_Sel = arrvSysScoreWeight_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvSysScoreWeight_Sel = arrvSysScoreWeight_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvSysScoreWeight_Sel = arrvSysScoreWeight_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvSysScoreWeight_Sel.length == 0)
                return arrvSysScoreWeight_Sel;
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
                arrvSysScoreWeight_Sel = arrvSysScoreWeight_Sel.sort(vSysScoreWeight_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrvSysScoreWeight_Sel = arrvSysScoreWeight_Sel.sort(objPagerPara.sortFun);
            }
            arrvSysScoreWeight_Sel = arrvSysScoreWeight_Sel.slice(intStart, intEnd);
            return arrvSysScoreWeight_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.vSysScoreWeight_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vSysScoreWeight_GetObjLstByPager_Cache = vSysScoreWeight_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vSysScoreWeight_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vSysScoreWeight_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vSysScoreWeight_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vSysScoreWeight_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vSysScoreWeight_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vSysScoreWeight_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vSysScoreWeight_GetObjLstByPagerAsync = vSysScoreWeight_GetObjLstByPagerAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objstrScoreWeightId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function vSysScoreWeight_IsExistRecord_Cache(objvSysScoreWeight_Cond) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrvSysScoreWeightObjLst_Cache = await vSysScoreWeight_GetObjLst_Cache();
        if (arrvSysScoreWeightObjLst_Cache == null)
            return false;
        let arrvSysScoreWeight_Sel = arrvSysScoreWeightObjLst_Cache;
        if (objvSysScoreWeight_Cond.sf_FldComparisonOp == null || objvSysScoreWeight_Cond.sf_FldComparisonOp == "")
            return arrvSysScoreWeight_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objvSysScoreWeight_Cond.sf_FldComparisonOp);
        //console.log("clsvSysScoreWeightWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvSysScoreWeight_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvSysScoreWeight_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvSysScoreWeight_Sel = arrvSysScoreWeight_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvSysScoreWeight_Sel = arrvSysScoreWeight_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvSysScoreWeight_Sel = arrvSysScoreWeight_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvSysScoreWeight_Sel = arrvSysScoreWeight_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvSysScoreWeight_Sel = arrvSysScoreWeight_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvSysScoreWeight_Sel = arrvSysScoreWeight_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvSysScoreWeight_Sel = arrvSysScoreWeight_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvSysScoreWeight_Sel = arrvSysScoreWeight_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvSysScoreWeight_Sel = arrvSysScoreWeight_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvSysScoreWeight_Sel = arrvSysScoreWeight_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvSysScoreWeight_Sel = arrvSysScoreWeight_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvSysScoreWeight_Sel = arrvSysScoreWeight_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvSysScoreWeight_Sel = arrvSysScoreWeight_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvSysScoreWeight_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objvSysScoreWeight_Cond), exports.vSysScoreWeight_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.vSysScoreWeight_IsExistRecord_Cache = vSysScoreWeight_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function vSysScoreWeight_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vSysScoreWeight_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vSysScoreWeight_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vSysScoreWeight_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vSysScoreWeight_IsExistRecordAsync = vSysScoreWeight_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strScoreWeightId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function vSysScoreWeight_IsExist(strScoreWeightId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vSysScoreWeight_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "ScoreWeightId": strScoreWeightId,
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vSysScoreWeight_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vSysScoreWeight_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vSysScoreWeight_IsExist = vSysScoreWeight_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param strScoreWeightId:所给的关键字
     * @returns 对象
    */
    async function vSysScoreWeight_IsExist_Cache(strScoreWeightId) {
        const strThisFuncName = "IsExist_Cache";
        const arrvSysScoreWeightObjLst_Cache = await vSysScoreWeight_GetObjLst_Cache();
        if (arrvSysScoreWeightObjLst_Cache == null)
            return false;
        try {
            const arrvSysScoreWeight_Sel = arrvSysScoreWeightObjLst_Cache.filter(x => x.scoreWeightId == strScoreWeightId);
            if (arrvSysScoreWeight_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strScoreWeightId, exports.vSysScoreWeight_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.vSysScoreWeight_IsExist_Cache = vSysScoreWeight_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strScoreWeightId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function vSysScoreWeight_IsExistAsync(strScoreWeightId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vSysScoreWeight_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strScoreWeightId": strScoreWeightId }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vSysScoreWeight_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vSysScoreWeight_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vSysScoreWeight_IsExistAsync = vSysScoreWeight_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function vSysScoreWeight_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vSysScoreWeight_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vSysScoreWeight_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vSysScoreWeight_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vSysScoreWeight_GetRecCountByCondAsync = vSysScoreWeight_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objvSysScoreWeight_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function vSysScoreWeight_GetRecCountByCond_Cache(objvSysScoreWeight_Cond) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrvSysScoreWeightObjLst_Cache = await vSysScoreWeight_GetObjLst_Cache();
        if (arrvSysScoreWeightObjLst_Cache == null)
            return 0;
        let arrvSysScoreWeight_Sel = arrvSysScoreWeightObjLst_Cache;
        if (objvSysScoreWeight_Cond.sf_FldComparisonOp == null || objvSysScoreWeight_Cond.sf_FldComparisonOp == "")
            return arrvSysScoreWeight_Sel.length;
        const dicFldComparisonOp = JSON.parse(objvSysScoreWeight_Cond.sf_FldComparisonOp);
        //console.log("clsvSysScoreWeightWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvSysScoreWeight_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvSysScoreWeight_Sel = arrvSysScoreWeight_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvSysScoreWeight_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvSysScoreWeight_Sel = arrvSysScoreWeight_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvSysScoreWeight_Sel = arrvSysScoreWeight_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvSysScoreWeight_Sel = arrvSysScoreWeight_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvSysScoreWeight_Sel = arrvSysScoreWeight_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvSysScoreWeight_Sel = arrvSysScoreWeight_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvSysScoreWeight_Sel = arrvSysScoreWeight_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvSysScoreWeight_Sel = arrvSysScoreWeight_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrvSysScoreWeight_Sel = arrvSysScoreWeight_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvSysScoreWeight_Sel = arrvSysScoreWeight_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvSysScoreWeight_Sel = arrvSysScoreWeight_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvSysScoreWeight_Sel = arrvSysScoreWeight_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvSysScoreWeight_Sel = arrvSysScoreWeight_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvSysScoreWeight_Sel = arrvSysScoreWeight_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvSysScoreWeight_Sel = arrvSysScoreWeight_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrvSysScoreWeight_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objvSysScoreWeight_Cond), exports.vSysScoreWeight_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.vSysScoreWeight_GetRecCountByCond_Cache = vSysScoreWeight_GetRecCountByCond_Cache;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function vSysScoreWeight_GetWebApiUrl(strController, strAction) {
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
    exports.vSysScoreWeight_GetWebApiUrl = vSysScoreWeight_GetWebApiUrl;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function vSysScoreWeight_ReFreshThisCache() {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = clsvSysScoreWeightEN_js_1.clsvSysScoreWeightEN._CurrTabName;
            switch (clsvSysScoreWeightEN_js_1.clsvSysScoreWeightEN.CacheModeId) {
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
            const strMsg = (0, clsString_js_1.Format)("刷新缓存成功！");
            console.trace(strMsg);
        }
        else {
            const strMsg = (0, clsString_js_1.Format)("刷新缓存已经关闭。");
            console.trace(strMsg);
        }
    }
    exports.vSysScoreWeight_ReFreshThisCache = vSysScoreWeight_ReFreshThisCache;
    /* 该表的下拉框功能没有设置，不需要生成下拉框绑定函数。*/
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vSysScoreWeight_GetJSONStrByObj(pobjvSysScoreWeightEN) {
        const strThisFuncName = "GetJSONStrByObj";
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjvSysScoreWeightEN);
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
    exports.vSysScoreWeight_GetJSONStrByObj = vSysScoreWeight_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function vSysScoreWeight_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrvSysScoreWeightObjLst = new Array();
        if (strJSON === "") {
            return arrvSysScoreWeightObjLst;
        }
        try {
            arrvSysScoreWeightObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrvSysScoreWeightObjLst;
        }
        return arrvSysScoreWeightObjLst;
    }
    exports.vSysScoreWeight_GetObjLstByJSONStr = vSysScoreWeight_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrvSysScoreWeightObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function vSysScoreWeight_GetObjLstByJSONObjLst(arrvSysScoreWeightObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrvSysScoreWeightObjLst = new Array();
        for (const objInFor of arrvSysScoreWeightObjLstS) {
            const obj1 = vSysScoreWeight_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrvSysScoreWeightObjLst.push(obj1);
        }
        return arrvSysScoreWeightObjLst;
    }
    exports.vSysScoreWeight_GetObjLstByJSONObjLst = vSysScoreWeight_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vSysScoreWeight_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjvSysScoreWeightEN = new clsvSysScoreWeightEN_js_1.clsvSysScoreWeightEN();
        if (strJSON === "") {
            return pobjvSysScoreWeightEN;
        }
        try {
            pobjvSysScoreWeightEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjvSysScoreWeightEN;
        }
        return pobjvSysScoreWeightEN;
    }
    exports.vSysScoreWeight_GetObjByJSONStr = vSysScoreWeight_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function vSysScoreWeight_GetCombineCondition(objvSysScoreWeight_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objvSysScoreWeight_Cond.dicFldComparisonOp, clsvSysScoreWeightEN_js_1.clsvSysScoreWeightEN.con_ScoreWeightId) == true) {
            const strComparisonOp_ScoreWeightId = objvSysScoreWeight_Cond.dicFldComparisonOp[clsvSysScoreWeightEN_js_1.clsvSysScoreWeightEN.con_ScoreWeightId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvSysScoreWeightEN_js_1.clsvSysScoreWeightEN.con_ScoreWeightId, objvSysScoreWeight_Cond.scoreWeightId, strComparisonOp_ScoreWeightId);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysScoreWeight_Cond.dicFldComparisonOp, clsvSysScoreWeightEN_js_1.clsvSysScoreWeightEN.con_ScoreWeightValue) == true) {
            const strComparisonOp_ScoreWeightValue = objvSysScoreWeight_Cond.dicFldComparisonOp[clsvSysScoreWeightEN_js_1.clsvSysScoreWeightEN.con_ScoreWeightValue];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvSysScoreWeightEN_js_1.clsvSysScoreWeightEN.con_ScoreWeightValue, objvSysScoreWeight_Cond.scoreWeightValue, strComparisonOp_ScoreWeightValue);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysScoreWeight_Cond.dicFldComparisonOp, clsvSysScoreWeightEN_js_1.clsvSysScoreWeightEN.con_IsPublic) == true) {
            if (objvSysScoreWeight_Cond.isPublic == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvSysScoreWeightEN_js_1.clsvSysScoreWeightEN.con_IsPublic);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvSysScoreWeightEN_js_1.clsvSysScoreWeightEN.con_IsPublic);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvSysScoreWeight_Cond.dicFldComparisonOp, clsvSysScoreWeightEN_js_1.clsvSysScoreWeightEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objvSysScoreWeight_Cond.dicFldComparisonOp[clsvSysScoreWeightEN_js_1.clsvSysScoreWeightEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvSysScoreWeightEN_js_1.clsvSysScoreWeightEN.con_UpdDate, objvSysScoreWeight_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysScoreWeight_Cond.dicFldComparisonOp, clsvSysScoreWeightEN_js_1.clsvSysScoreWeightEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objvSysScoreWeight_Cond.dicFldComparisonOp[clsvSysScoreWeightEN_js_1.clsvSysScoreWeightEN.con_UpdUser];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvSysScoreWeightEN_js_1.clsvSysScoreWeightEN.con_UpdUser, objvSysScoreWeight_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysScoreWeight_Cond.dicFldComparisonOp, clsvSysScoreWeightEN_js_1.clsvSysScoreWeightEN.con_Memo) == true) {
            const strComparisonOp_Memo = objvSysScoreWeight_Cond.dicFldComparisonOp[clsvSysScoreWeightEN_js_1.clsvSysScoreWeightEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvSysScoreWeightEN_js_1.clsvSysScoreWeightEN.con_Memo, objvSysScoreWeight_Cond.memo, strComparisonOp_Memo);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysScoreWeight_Cond.dicFldComparisonOp, clsvSysScoreWeightEN_js_1.clsvSysScoreWeightEN.con_ScoreTypeId) == true) {
            const strComparisonOp_ScoreTypeId = objvSysScoreWeight_Cond.dicFldComparisonOp[clsvSysScoreWeightEN_js_1.clsvSysScoreWeightEN.con_ScoreTypeId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvSysScoreWeightEN_js_1.clsvSysScoreWeightEN.con_ScoreTypeId, objvSysScoreWeight_Cond.scoreTypeId, strComparisonOp_ScoreTypeId);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysScoreWeight_Cond.dicFldComparisonOp, clsvSysScoreWeightEN_js_1.clsvSysScoreWeightEN.con_ScoreTypeName) == true) {
            const strComparisonOp_ScoreTypeName = objvSysScoreWeight_Cond.dicFldComparisonOp[clsvSysScoreWeightEN_js_1.clsvSysScoreWeightEN.con_ScoreTypeName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvSysScoreWeightEN_js_1.clsvSysScoreWeightEN.con_ScoreTypeName, objvSysScoreWeight_Cond.scoreTypeName, strComparisonOp_ScoreTypeName);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysScoreWeight_Cond.dicFldComparisonOp, clsvSysScoreWeightEN_js_1.clsvSysScoreWeightEN.con_OnlyId) == true) {
            const strComparisonOp_OnlyId = objvSysScoreWeight_Cond.dicFldComparisonOp[clsvSysScoreWeightEN_js_1.clsvSysScoreWeightEN.con_OnlyId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvSysScoreWeightEN_js_1.clsvSysScoreWeightEN.con_OnlyId, objvSysScoreWeight_Cond.onlyId, strComparisonOp_OnlyId);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysScoreWeight_Cond.dicFldComparisonOp, clsvSysScoreWeightEN_js_1.clsvSysScoreWeightEN.con_id_CurrEduCls) == true) {
            const strComparisonOp_id_CurrEduCls = objvSysScoreWeight_Cond.dicFldComparisonOp[clsvSysScoreWeightEN_js_1.clsvSysScoreWeightEN.con_id_CurrEduCls];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvSysScoreWeightEN_js_1.clsvSysScoreWeightEN.con_id_CurrEduCls, objvSysScoreWeight_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysScoreWeight_Cond.dicFldComparisonOp, clsvSysScoreWeightEN_js_1.clsvSysScoreWeightEN.con_CurrEduClsId) == true) {
            const strComparisonOp_CurrEduClsId = objvSysScoreWeight_Cond.dicFldComparisonOp[clsvSysScoreWeightEN_js_1.clsvSysScoreWeightEN.con_CurrEduClsId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvSysScoreWeightEN_js_1.clsvSysScoreWeightEN.con_CurrEduClsId, objvSysScoreWeight_Cond.currEduClsId, strComparisonOp_CurrEduClsId);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysScoreWeight_Cond.dicFldComparisonOp, clsvSysScoreWeightEN_js_1.clsvSysScoreWeightEN.con_EduClsName) == true) {
            const strComparisonOp_EduClsName = objvSysScoreWeight_Cond.dicFldComparisonOp[clsvSysScoreWeightEN_js_1.clsvSysScoreWeightEN.con_EduClsName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvSysScoreWeightEN_js_1.clsvSysScoreWeightEN.con_EduClsName, objvSysScoreWeight_Cond.eduClsName, strComparisonOp_EduClsName);
        }
        return strWhereCond;
    }
    exports.vSysScoreWeight_GetCombineCondition = vSysScoreWeight_GetCombineCondition;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objvSysScoreWeightENS:源对象
     * @param objvSysScoreWeightENT:目标对象
    */
    function vSysScoreWeight_CopyObjTo(objvSysScoreWeightENS, objvSysScoreWeightENT) {
        objvSysScoreWeightENT.scoreWeightId = objvSysScoreWeightENS.scoreWeightId; //分数权重Id
        objvSysScoreWeightENT.scoreWeightValue = objvSysScoreWeightENS.scoreWeightValue; //分数权重值
        objvSysScoreWeightENT.isPublic = objvSysScoreWeightENS.isPublic; //是否公开
        objvSysScoreWeightENT.updDate = objvSysScoreWeightENS.updDate; //修改日期
        objvSysScoreWeightENT.updUser = objvSysScoreWeightENS.updUser; //修改人
        objvSysScoreWeightENT.memo = objvSysScoreWeightENS.memo; //备注
        objvSysScoreWeightENT.scoreTypeId = objvSysScoreWeightENS.scoreTypeId; //分数类型Id
        objvSysScoreWeightENT.scoreTypeName = objvSysScoreWeightENS.scoreTypeName; //分数类型名称
        objvSysScoreWeightENT.onlyId = objvSysScoreWeightENS.onlyId; //OnlyId
        objvSysScoreWeightENT.id_CurrEduCls = objvSysScoreWeightENS.id_CurrEduCls; //教学班流水号
        objvSysScoreWeightENT.currEduClsId = objvSysScoreWeightENS.currEduClsId; //教学班Id
        objvSysScoreWeightENT.eduClsName = objvSysScoreWeightENS.eduClsName; //教学班名
    }
    exports.vSysScoreWeight_CopyObjTo = vSysScoreWeight_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objvSysScoreWeightENS:源对象
     * @param objvSysScoreWeightENT:目标对象
    */
    function vSysScoreWeight_GetObjFromJsonObj(objvSysScoreWeightENS) {
        const objvSysScoreWeightENT = new clsvSysScoreWeightEN_js_1.clsvSysScoreWeightEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvSysScoreWeightENT, objvSysScoreWeightENS);
        return objvSysScoreWeightENT;
    }
    exports.vSysScoreWeight_GetObjFromJsonObj = vSysScoreWeight_GetObjFromJsonObj;
});
