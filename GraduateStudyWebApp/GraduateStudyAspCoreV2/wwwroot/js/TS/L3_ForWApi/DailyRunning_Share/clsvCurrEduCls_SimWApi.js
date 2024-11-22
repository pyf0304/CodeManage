/**
* 类名:clsvCurrEduCls_SimWApi
* 表名:vCurrEduCls_Sim(01120951)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/13 02:45:46
* 生成者:pyf
* 生成服务器IP:
工程名称:问卷调查(0112)
CM工程:游戏化教育平台(变量首字母小写)-全部函数集
* 相关数据库:103.116.76.183,9433EduHigh_Jsie
* PrjDataBaseId:0170
模块中文名:日常运行(DailyRunning)
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
        define(["require", "exports", "axios", "../../PubFun/enumComparisonOp.js", "../../PubFun/CacheHelper.js", "../../PubFun/CacheHelper.js", "../../PubFun/CacheHelper.js", "../../L0_Entity/DailyRunning_Share/clsvCurrEduCls_SimEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.vCurrEduCls_Sim_GetObjFromJsonObj = exports.vCurrEduCls_Sim_CopyObjTo = exports.vCurrEduCls_Sim_GetCombineCondition = exports.vCurrEduCls_Sim_GetObjByJSONStr = exports.vCurrEduCls_Sim_GetObjLstByJSONObjLst = exports.vCurrEduCls_Sim_GetObjLstByJSONStr = exports.vCurrEduCls_Sim_GetJSONStrByObj = exports.vCurrEduCls_Sim_BindDdl_id_CurrEduClsByCourseIdInDiv_Cache = exports.vCurrEduCls_Sim_ReFreshThisCache = exports.vCurrEduCls_Sim_GetWebApiUrl = exports.vCurrEduCls_Sim_GetRecCountByCond_Cache = exports.vCurrEduCls_Sim_GetRecCountByCondAsync = exports.vCurrEduCls_Sim_IsExistAsync = exports.vCurrEduCls_Sim_IsExist_Cache = exports.vCurrEduCls_Sim_IsExist = exports.vCurrEduCls_Sim_IsExistRecordAsync = exports.vCurrEduCls_Sim_IsExistRecord_Cache = exports.vCurrEduCls_Sim_GetObjLstByPagerAsync = exports.vCurrEduCls_Sim_GetObjLstByPager_Cache = exports.vCurrEduCls_Sim_GetObjLstByRange = exports.vCurrEduCls_Sim_GetObjLstByRangeAsync = exports.vCurrEduCls_Sim_GetTopObjLstAsync = exports.vCurrEduCls_Sim_GetObjLstByKeyLsts_Cache = exports.vCurrEduCls_Sim_JoinByKeyLst = exports.vCurrEduCls_Sim_GetSubObjLst_Cache = exports.vCurrEduCls_Sim_GetObjLst_PureCache = exports.vCurrEduCls_Sim_GetObjLst_Cache = exports.vCurrEduCls_Sim_GetObjLst_sessionStorage_PureCache = exports.vCurrEduCls_Sim_GetObjLst_sessionStorage = exports.vCurrEduCls_Sim_GetObjLstAsync = exports.vCurrEduCls_Sim_GetObjLst_localStorage_PureCache = exports.vCurrEduCls_Sim_GetObjLst_localStorage = exports.vCurrEduCls_Sim_GetObjLst_ClientCache = exports.vCurrEduCls_Sim_GetFirstObjAsync = exports.vCurrEduCls_Sim_GetFirstID = exports.vCurrEduCls_Sim_GetFirstIDAsync = exports.vCurrEduCls_Sim_funcKey = exports.vCurrEduCls_Sim_FilterFunByKey = exports.vCurrEduCls_Sim_SortFunByKey = exports.vCurrEduCls_Sim_SortFun_Defa_2Fld = exports.vCurrEduCls_Sim_SortFun_Defa = exports.vCurrEduCls_Sim_func = exports.vCurrEduCls_Sim_GetNameByid_CurrEduCls_Cache = exports.vCurrEduCls_Sim_GetObjByKeyLst_localStorage = exports.vCurrEduCls_Sim_GetObjByKeyLst_Cache = exports.vCurrEduCls_Sim_GetObjByKeyLstAsync = exports.vCurrEduCls_Sim_SplitKeyLst = exports.vCurrEduCls_Sim_ConstructorName = exports.vCurrEduCls_Sim_Controller = void 0;
    /**
     * vCurrEduCls_Sim(vCurrEduCls_Sim)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月13日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const enumComparisonOp_js_1 = require("../../PubFun/enumComparisonOp.js");
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const CacheHelper_js_2 = require("../../PubFun/CacheHelper.js");
    const CacheHelper_js_3 = require("../../PubFun/CacheHelper.js");
    const clsvCurrEduCls_SimEN_js_1 = require("../../L0_Entity/DailyRunning_Share/clsvCurrEduCls_SimEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.vCurrEduCls_Sim_Controller = "vCurrEduCls_SimApi";
    exports.vCurrEduCls_Sim_ConstructorName = "vCurrEduCls_Sim";
    /**
    * 把多关键字值分解为单独关键字的值，并且以对象形式返回
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strKeyLst:多关键字值
    * @returns 分解后的单独关键字值对象
    **/
    function vCurrEduCls_Sim_SplitKeyLst(strKeyLst) {
        const arrKey = strKeyLst.split('|');
        if (arrKey.length != 2) {
            const strMsg = "请选择需要修改的记录！";
            console.error(strMsg);
            alert(strMsg);
            throw (strMsg);
        }
        const objKeyLst = {
            id_CurrEduCls: arrKey[0],
            eduClsTypeId: arrKey[1],
        };
        if ((0, clsString_js_1.IsNullOrEmpty)(objKeyLst.id_CurrEduCls) == true) {
            const strMsg = "关键字段(id_CurrEduCls)值不能为空！";
            console.error(strMsg);
            alert(strMsg);
            throw (strMsg);
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(objKeyLst.eduClsTypeId) == true) {
            const strMsg = "关键字段(eduClsTypeId)值不能为空！";
            console.error(strMsg);
            alert(strMsg);
            throw (strMsg);
        }
        return objKeyLst;
    }
    exports.vCurrEduCls_Sim_SplitKeyLst = vCurrEduCls_Sim_SplitKeyLst;
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strid_CurrEduCls:关键字
    * @returns 对象
    **/
    async function vCurrEduCls_Sim_GetObjByKeyLstAsync(strid_CurrEduCls, strEduClsTypeId) {
        const strThisFuncName = "GetObjByKeyLstAsync";
        if ((0, clsString_js_1.IsNullOrEmpty)(strid_CurrEduCls) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strid_CurrEduCls]不能为空！(In clsvCurrEduCls_SimWApi.GetObjByKeyLstAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strid_CurrEduCls]的长度:[{0}]不正确！(clsvCurrEduCls_SimWApi.GetObjByKeyLstAsync)", strid_CurrEduCls.length);
            console.error(strMsg);
            throw (strMsg);
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(strEduClsTypeId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strEduClsTypeId]不能为空！(In clsvCurrEduCls_SimWApi.GetObjByKeyLstAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strEduClsTypeId.length != 4) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strEduClsTypeId]的长度:[{0}]不正确！(clsvCurrEduCls_SimWApi.GetObjByKeyLstAsync)", strEduClsTypeId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByKeyLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vCurrEduCls_Sim_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "strid_CurrEduCls": strid_CurrEduCls,
                    "strEduClsTypeId": strEduClsTypeId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    return null;
                }
                //console.log(returnObj);
                const objvCurrEduCls_Sim = vCurrEduCls_Sim_GetObjFromJsonObj(returnObj);
                return objvCurrEduCls_Sim;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vCurrEduCls_Sim_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vCurrEduCls_Sim_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vCurrEduCls_Sim_GetObjByKeyLstAsync = vCurrEduCls_Sim_GetObjByKeyLstAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param strid_CurrEduCls:所给的关键字
     * @returns 对象
    */
    async function vCurrEduCls_Sim_GetObjByKeyLst_Cache(strid_CurrEduCls, strEduClsTypeId, strCourseId, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByKeyLst_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strid_CurrEduCls) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strid_CurrEduCls]不能为空！(In clsvCurrEduCls_SimWApi.GetObjByKeyLst_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strid_CurrEduCls]的长度:[{0}]不正确！(clsvCurrEduCls_SimWApi.GetObjByKeyLst_Cache)", strid_CurrEduCls.length);
            console.error(strMsg);
            throw (strMsg);
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(strEduClsTypeId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strEduClsTypeId]不能为空！(In clsvCurrEduCls_SimWApi.GetObjByKeyLst_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strEduClsTypeId.length != 4) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strEduClsTypeId]的长度:[{0}]不正确！(clsvCurrEduCls_SimWApi.GetObjByKeyLst_Cache)", strEduClsTypeId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrvCurrEduCls_SimObjLst_Cache = await vCurrEduCls_Sim_GetObjLst_Cache(strCourseId);
        try {
            const arrvCurrEduCls_Sim_Sel = arrvCurrEduCls_SimObjLst_Cache.filter(x => x.id_CurrEduCls == strid_CurrEduCls
                && x.eduClsTypeId == strEduClsTypeId);
            let objvCurrEduCls_Sim;
            if (arrvCurrEduCls_Sim_Sel.length > 0) {
                objvCurrEduCls_Sim = arrvCurrEduCls_Sim_Sel[0];
                return objvCurrEduCls_Sim;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    const objvCurrEduCls_Sim_Const = await vCurrEduCls_Sim_GetObjByKeyLstAsync(strid_CurrEduCls, strEduClsTypeId);
                    if (objvCurrEduCls_Sim_Const != null) {
                        vCurrEduCls_Sim_ReFreshThisCache(strCourseId);
                        return objvCurrEduCls_Sim_Const;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strid_CurrEduCls, exports.vCurrEduCls_Sim_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.vCurrEduCls_Sim_GetObjByKeyLst_Cache = vCurrEduCls_Sim_GetObjByKeyLst_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param strid_CurrEduCls:所给的关键字
     * @returns 对象
    */
    async function vCurrEduCls_Sim_GetObjByKeyLst_localStorage(strid_CurrEduCls, strEduClsTypeId) {
        const strThisFuncName = "GetObjByKeyLst_localStorage";
        if ((0, clsString_js_1.IsNullOrEmpty)(strid_CurrEduCls) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strid_CurrEduCls]不能为空！(In clsvCurrEduCls_SimWApi.GetObjByKeyLst_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strid_CurrEduCls]的长度:[{0}]不正确！(clsvCurrEduCls_SimWApi.GetObjByKeyLst_localStorage)", strid_CurrEduCls.length);
            console.error(strMsg);
            throw (strMsg);
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(strEduClsTypeId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strEduClsTypeId]不能为空！(In clsvCurrEduCls_SimWApi.GetObjByKeyLst_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strEduClsTypeId.length != 4) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strEduClsTypeId]的长度:[{0}]不正确！(clsvCurrEduCls_SimWApi.GetObjByKeyLst_localStorage)", strEduClsTypeId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvCurrEduCls_SimEN_js_1.clsvCurrEduCls_SimEN._CurrTabName, strid_CurrEduCls);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objvCurrEduCls_Sim_Cache = JSON.parse(strTempObj);
            return objvCurrEduCls_Sim_Cache;
        }
        try {
            const objvCurrEduCls_Sim = await vCurrEduCls_Sim_GetObjByKeyLstAsync(strid_CurrEduCls, strEduClsTypeId);
            if (objvCurrEduCls_Sim != null) {
                localStorage.setItem(strKey, JSON.stringify(objvCurrEduCls_Sim));
                const strInfo = (0, clsString_js_1.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objvCurrEduCls_Sim;
            }
            return objvCurrEduCls_Sim;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strid_CurrEduCls, exports.vCurrEduCls_Sim_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.vCurrEduCls_Sim_GetObjByKeyLst_localStorage = vCurrEduCls_Sim_GetObjByKeyLst_localStorage;
    /**
     * 根据关键字获取相关对象的名称属性, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetNameByKeyId_Cache)
     * @param strid_CurrEduCls:所给的关键字
     * @returns 对象
    */
    async function vCurrEduCls_Sim_GetNameByid_CurrEduCls_Cache(strid_CurrEduCls, strCourseId, strEduClsTypeId) {
        const strThisFuncName = "GetNameByid_CurrEduCls_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strid_CurrEduCls) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strid_CurrEduCls]不能为空！(In clsvCurrEduCls_SimWApi.GetNameByid_CurrEduCls_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strid_CurrEduCls]的长度:[{0}]不正确！(clsvCurrEduCls_SimWApi.GetNameByid_CurrEduCls_Cache)", strid_CurrEduCls.length);
            console.error(strMsg);
            throw (strMsg);
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(strEduClsTypeId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strEduClsTypeId]不能为空！(In clsvCurrEduCls_SimWApi.GetNameByid_CurrEduCls_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strEduClsTypeId.length != 4) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strEduClsTypeId]的长度:[{0}]不正确！(clsvCurrEduCls_SimWApi.GetNameByid_CurrEduCls_Cache)", strEduClsTypeId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrvCurrEduCls_SimObjLst_Cache = await vCurrEduCls_Sim_GetObjLst_Cache(strCourseId);
        if (arrvCurrEduCls_SimObjLst_Cache == null)
            return "";
        try {
            const arrvCurrEduCls_Sim_Sel = arrvCurrEduCls_SimObjLst_Cache.filter(x => x.id_CurrEduCls == strid_CurrEduCls
                && x.eduClsTypeId == strEduClsTypeId);
            let objvCurrEduCls_Sim;
            if (arrvCurrEduCls_Sim_Sel.length > 0) {
                objvCurrEduCls_Sim = arrvCurrEduCls_Sim_Sel[0];
                return objvCurrEduCls_Sim.eduClsName;
            }
            else {
                return "";
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象名称属性不成功!", e, strid_CurrEduCls);
            console.error(strMsg);
            alert(strMsg);
        }
        return "";
    }
    exports.vCurrEduCls_Sim_GetNameByid_CurrEduCls_Cache = vCurrEduCls_Sim_GetNameByid_CurrEduCls_Cache;
    /**
     * 映射函数。根据表映射把输入字段值，映射成输出字段值
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_func)
     * @param strInFldName:输入字段名
     * @param strOutFldName:输出字段名
     * @param strInValue:输入字段值
     @param strCourseId:缓存的分类字段
     * @returns 返回一个输出字段值
    */
    async function vCurrEduCls_Sim_func(strInFldName1, strInFldName2, strOutFldName, strInValue1, strInValue2, strCourseId_C) {
        //const strThisFuncName = "func";
        if ((0, clsString_js_1.IsNullOrEmpty)(strCourseId_C) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strCourseId_C]不能为空！(In clsvCurrEduCls_SimWApi.func)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strCourseId_C.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strCourseId_C]的长度:[{0}]不正确！(clsvCurrEduCls_SimWApi.func)", strCourseId_C.length);
            console.error(strMsg);
            throw (strMsg);
        }
        if (strInFldName1 != clsvCurrEduCls_SimEN_js_1.clsvCurrEduCls_SimEN.con_id_CurrEduCls) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确!", strInFldName1);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (strInFldName2 != clsvCurrEduCls_SimEN_js_1.clsvCurrEduCls_SimEN.con_EduClsTypeId) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确!", strInFldName2);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsvCurrEduCls_SimEN_js_1.clsvCurrEduCls_SimEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_1.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strOutFldName, clsvCurrEduCls_SimEN_js_1.clsvCurrEduCls_SimEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strid_CurrEduCls = strInValue1;
        if ((0, clsString_js_1.IsNullOrEmpty)(strInValue1) == true) {
            return "";
        }
        const strEduClsTypeId = strInValue2;
        if ((0, clsString_js_1.IsNullOrEmpty)(strInValue2) == true) {
            return "";
        }
        const objvCurrEduCls_Sim = await vCurrEduCls_Sim_GetObjByKeyLst_Cache(strid_CurrEduCls, strEduClsTypeId, strCourseId_C);
        if (objvCurrEduCls_Sim == null)
            return "";
        if (objvCurrEduCls_Sim.GetFldValue(strOutFldName) == null)
            return "";
        return objvCurrEduCls_Sim.GetFldValue(strOutFldName).toString();
    }
    exports.vCurrEduCls_Sim_func = vCurrEduCls_Sim_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vCurrEduCls_Sim_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
    }
    exports.vCurrEduCls_Sim_SortFun_Defa = vCurrEduCls_Sim_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vCurrEduCls_Sim_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.currEduClsId == b.currEduClsId)
            return a.eduClsName.localeCompare(b.eduClsName);
        else
            return a.currEduClsId.localeCompare(b.currEduClsId);
    }
    exports.vCurrEduCls_Sim_SortFun_Defa_2Fld = vCurrEduCls_Sim_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vCurrEduCls_Sim_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsvCurrEduCls_SimEN_js_1.clsvCurrEduCls_SimEN.con_id_CurrEduCls:
                    return (a, b) => {
                        return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
                    };
                case clsvCurrEduCls_SimEN_js_1.clsvCurrEduCls_SimEN.con_CurrEduClsId:
                    return (a, b) => {
                        if (a.currEduClsId == null)
                            return -1;
                        if (b.currEduClsId == null)
                            return 1;
                        return a.currEduClsId.localeCompare(b.currEduClsId);
                    };
                case clsvCurrEduCls_SimEN_js_1.clsvCurrEduCls_SimEN.con_EduClsName:
                    return (a, b) => {
                        return a.eduClsName.localeCompare(b.eduClsName);
                    };
                case clsvCurrEduCls_SimEN_js_1.clsvCurrEduCls_SimEN.con_EduClsTypeId:
                    return (a, b) => {
                        return a.eduClsTypeId.localeCompare(b.eduClsTypeId);
                    };
                case clsvCurrEduCls_SimEN_js_1.clsvCurrEduCls_SimEN.con_CourseId:
                    return (a, b) => {
                        if (a.courseId == null)
                            return -1;
                        if (b.courseId == null)
                            return 1;
                        return a.courseId.localeCompare(b.courseId);
                    };
                case clsvCurrEduCls_SimEN_js_1.clsvCurrEduCls_SimEN.con_id_XzCollege:
                    return (a, b) => {
                        if (a.id_XzCollege == null)
                            return -1;
                        if (b.id_XzCollege == null)
                            return 1;
                        return a.id_XzCollege.localeCompare(b.id_XzCollege);
                    };
                case clsvCurrEduCls_SimEN_js_1.clsvCurrEduCls_SimEN.con_id_XzMajor:
                    return (a, b) => {
                        return a.id_XzMajor.localeCompare(b.id_XzMajor);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vCurrEduCls_Sim]中不存在！(in ${exports.vCurrEduCls_Sim_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsvCurrEduCls_SimEN_js_1.clsvCurrEduCls_SimEN.con_id_CurrEduCls:
                    return (a, b) => {
                        return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
                    };
                case clsvCurrEduCls_SimEN_js_1.clsvCurrEduCls_SimEN.con_CurrEduClsId:
                    return (a, b) => {
                        if (b.currEduClsId == null)
                            return -1;
                        if (a.currEduClsId == null)
                            return 1;
                        return b.currEduClsId.localeCompare(a.currEduClsId);
                    };
                case clsvCurrEduCls_SimEN_js_1.clsvCurrEduCls_SimEN.con_EduClsName:
                    return (a, b) => {
                        return b.eduClsName.localeCompare(a.eduClsName);
                    };
                case clsvCurrEduCls_SimEN_js_1.clsvCurrEduCls_SimEN.con_EduClsTypeId:
                    return (a, b) => {
                        return b.eduClsTypeId.localeCompare(a.eduClsTypeId);
                    };
                case clsvCurrEduCls_SimEN_js_1.clsvCurrEduCls_SimEN.con_CourseId:
                    return (a, b) => {
                        if (b.courseId == null)
                            return -1;
                        if (a.courseId == null)
                            return 1;
                        return b.courseId.localeCompare(a.courseId);
                    };
                case clsvCurrEduCls_SimEN_js_1.clsvCurrEduCls_SimEN.con_id_XzCollege:
                    return (a, b) => {
                        if (b.id_XzCollege == null)
                            return -1;
                        if (a.id_XzCollege == null)
                            return 1;
                        return b.id_XzCollege.localeCompare(a.id_XzCollege);
                    };
                case clsvCurrEduCls_SimEN_js_1.clsvCurrEduCls_SimEN.con_id_XzMajor:
                    return (a, b) => {
                        return b.id_XzMajor.localeCompare(a.id_XzMajor);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vCurrEduCls_Sim]中不存在！(in ${exports.vCurrEduCls_Sim_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.vCurrEduCls_Sim_SortFunByKey = vCurrEduCls_Sim_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function vCurrEduCls_Sim_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsvCurrEduCls_SimEN_js_1.clsvCurrEduCls_SimEN.con_id_CurrEduCls:
                return (obj) => {
                    return obj.id_CurrEduCls === value;
                };
            case clsvCurrEduCls_SimEN_js_1.clsvCurrEduCls_SimEN.con_CurrEduClsId:
                return (obj) => {
                    return obj.currEduClsId === value;
                };
            case clsvCurrEduCls_SimEN_js_1.clsvCurrEduCls_SimEN.con_EduClsName:
                return (obj) => {
                    return obj.eduClsName === value;
                };
            case clsvCurrEduCls_SimEN_js_1.clsvCurrEduCls_SimEN.con_EduClsTypeId:
                return (obj) => {
                    return obj.eduClsTypeId === value;
                };
            case clsvCurrEduCls_SimEN_js_1.clsvCurrEduCls_SimEN.con_CourseId:
                return (obj) => {
                    return obj.courseId === value;
                };
            case clsvCurrEduCls_SimEN_js_1.clsvCurrEduCls_SimEN.con_id_XzCollege:
                return (obj) => {
                    return obj.id_XzCollege === value;
                };
            case clsvCurrEduCls_SimEN_js_1.clsvCurrEduCls_SimEN.con_id_XzMajor:
                return (obj) => {
                    return obj.id_XzMajor === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[vCurrEduCls_Sim]中不存在！(in ${exports.vCurrEduCls_Sim_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.vCurrEduCls_Sim_FilterFunByKey = vCurrEduCls_Sim_FilterFunByKey;
    /**
     * 映射函数。根据表映射把输入字段值，映射成输出字段值
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_funcKey)
     * @param strInFldName:输入字段名
     * @param strInValue:输入字段值
     * @param strComparisonOp:比较操作符
     @param strCourseId:缓存的分类字段
     * @returns 返回一个关键字值列表
    */
    async function vCurrEduCls_Sim_funcKey(strInFldName, strInValue, strComparisonOp, strCourseId_C) {
        //const strThisFuncName = "funcKey";
        if ((0, clsString_js_1.IsNullOrEmpty)(strCourseId_C) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strCourseId_C]不能为空！(In clsvCurrEduCls_SimWApi.funcKey)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strCourseId_C.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strCourseId_C]的长度:[{0}]不正确！(clsvCurrEduCls_SimWApi.funcKey)", strCourseId_C.length);
            console.error(strMsg);
            throw (strMsg);
        }
        if (strInFldName == clsvCurrEduCls_SimEN_js_1.clsvCurrEduCls_SimEN.con_id_CurrEduCls) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (strInFldName == clsvCurrEduCls_SimEN_js_1.clsvCurrEduCls_SimEN.con_EduClsTypeId) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(strInValue) == true) {
            return [];
        }
        const arrvCurrEduCls_Sim = await vCurrEduCls_Sim_GetObjLst_Cache(strCourseId_C);
        if (arrvCurrEduCls_Sim == null)
            return [];
        let arrvCurrEduCls_Sim_Sel = arrvCurrEduCls_Sim;
        const strType = typeof (strInValue);
        switch (strType) {
            case "string":
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01: // " = "
                        arrvCurrEduCls_Sim_Sel = arrvCurrEduCls_Sim_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.Like_03:
                        arrvCurrEduCls_Sim_Sel = arrvCurrEduCls_Sim_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.In_04:
                        const arrValues = strInValue.split(',');
                        arrvCurrEduCls_Sim_Sel = arrvCurrEduCls_Sim_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
                        break;
                }
                break;
            case "boolean":
                if (strInValue == null)
                    return [];
                if (strComparisonOp == enumComparisonOp_js_1.enumComparisonOp.Equal_01) {
                    arrvCurrEduCls_Sim_Sel = arrvCurrEduCls_Sim_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                }
                break;
            case "number":
                if (Number(strInValue) == 0)
                    return [];
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01:
                        arrvCurrEduCls_Sim_Sel = arrvCurrEduCls_Sim_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotEqual_02:
                        arrvCurrEduCls_Sim_Sel = arrvCurrEduCls_Sim_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotLessThan_05: //" >= ":
                        arrvCurrEduCls_Sim_Sel = arrvCurrEduCls_Sim_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotGreaterThan_06: //" <= ":
                        arrvCurrEduCls_Sim_Sel = arrvCurrEduCls_Sim_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.GreaterThan_07: //" > ":
                        arrvCurrEduCls_Sim_Sel = arrvCurrEduCls_Sim_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.LessThan_08: //" < ":
                        arrvCurrEduCls_Sim_Sel = arrvCurrEduCls_Sim_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                }
                break;
        }
        if (arrvCurrEduCls_Sim_Sel.length == 0)
            return [];
        return arrvCurrEduCls_Sim.map(x => x.id_CurrEduCls + "|" + x.eduClsTypeId);
    }
    exports.vCurrEduCls_Sim_funcKey = vCurrEduCls_Sim_funcKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function vCurrEduCls_Sim_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vCurrEduCls_Sim_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vCurrEduCls_Sim_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vCurrEduCls_Sim_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vCurrEduCls_Sim_GetFirstIDAsync = vCurrEduCls_Sim_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function vCurrEduCls_Sim_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vCurrEduCls_Sim_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vCurrEduCls_Sim_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vCurrEduCls_Sim_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vCurrEduCls_Sim_GetFirstID = vCurrEduCls_Sim_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function vCurrEduCls_Sim_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vCurrEduCls_Sim_Controller, strAction);
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
                const objvCurrEduCls_Sim = vCurrEduCls_Sim_GetObjFromJsonObj(returnObj);
                return objvCurrEduCls_Sim;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vCurrEduCls_Sim_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vCurrEduCls_Sim_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vCurrEduCls_Sim_GetFirstObjAsync = vCurrEduCls_Sim_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vCurrEduCls_Sim_GetObjLst_ClientCache(strCourseId) {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvCurrEduCls_SimEN_js_1.clsvCurrEduCls_SimEN.WhereFormat) == false) {
            strWhereCond = (0, clsString_js_1.Format)(clsvCurrEduCls_SimEN_js_1.clsvCurrEduCls_SimEN.WhereFormat, strCourseId);
        }
        else {
            strWhereCond = (0, clsString_js_1.Format)("CourseId='{0}'", strCourseId);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvCurrEduCls_SimEN_js_1.clsvCurrEduCls_SimEN._CurrTabName, strCourseId);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvCurrEduCls_SimEN_js_1.clsvCurrEduCls_SimEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvCurrEduCls_SimEN_js_1.clsvCurrEduCls_SimEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_1.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrvCurrEduCls_SimExObjLst_Cache = CacheHelper_js_1.CacheHelper.Get(strKey);
            const arrvCurrEduCls_SimObjLst_T = vCurrEduCls_Sim_GetObjLstByJSONObjLst(arrvCurrEduCls_SimExObjLst_Cache);
            return arrvCurrEduCls_SimObjLst_T;
        }
        try {
            const arrvCurrEduCls_SimExObjLst = await vCurrEduCls_Sim_GetObjLstAsync(strWhereCond);
            CacheHelper_js_1.CacheHelper.Add(strKey, arrvCurrEduCls_SimExObjLst);
            const strInfo = (0, clsString_js_1.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvCurrEduCls_SimExObjLst.length);
            console.log(strInfo);
            return arrvCurrEduCls_SimExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vCurrEduCls_Sim_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vCurrEduCls_Sim_GetObjLst_ClientCache = vCurrEduCls_Sim_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vCurrEduCls_Sim_GetObjLst_localStorage(strCourseId) {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvCurrEduCls_SimEN_js_1.clsvCurrEduCls_SimEN.WhereFormat) == false) {
            strWhereCond = (0, clsString_js_1.Format)(clsvCurrEduCls_SimEN_js_1.clsvCurrEduCls_SimEN.WhereFormat, strCourseId);
        }
        else {
            strWhereCond = (0, clsString_js_1.Format)("CourseId='{0}'", strCourseId);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvCurrEduCls_SimEN_js_1.clsvCurrEduCls_SimEN._CurrTabName, strCourseId);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvCurrEduCls_SimEN_js_1.clsvCurrEduCls_SimEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvCurrEduCls_SimEN_js_1.clsvCurrEduCls_SimEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrvCurrEduCls_SimExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrvCurrEduCls_SimObjLst_T = vCurrEduCls_Sim_GetObjLstByJSONObjLst(arrvCurrEduCls_SimExObjLst_Cache);
            return arrvCurrEduCls_SimObjLst_T;
        }
        try {
            const arrvCurrEduCls_SimExObjLst = await vCurrEduCls_Sim_GetObjLstAsync(strWhereCond);
            const strPrefix = (0, clsString_js_1.Format)("{0}_", clsvCurrEduCls_SimEN_js_1.clsvCurrEduCls_SimEN._CurrTabName);
            const arrCacheKeyLst = (0, CacheHelper_js_2.LocalStorage_GetKeyByPrefix)(strPrefix);
            arrCacheKeyLst.forEach(x => localStorage.removeItem(x));
            localStorage.setItem(strKey, JSON.stringify(arrvCurrEduCls_SimExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvCurrEduCls_SimExObjLst.length);
            console.log(strInfo);
            return arrvCurrEduCls_SimExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vCurrEduCls_Sim_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vCurrEduCls_Sim_GetObjLst_localStorage = vCurrEduCls_Sim_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vCurrEduCls_Sim_GetObjLst_localStorage_PureCache(strCourseId) {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("CourseId='{0}'", strCourseId);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvCurrEduCls_SimEN_js_1.clsvCurrEduCls_SimEN._CurrTabName, strCourseId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrvCurrEduCls_SimObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvCurrEduCls_SimObjLst_Cache;
        }
        else
            return null;
    }
    exports.vCurrEduCls_Sim_GetObjLst_localStorage_PureCache = vCurrEduCls_Sim_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function vCurrEduCls_Sim_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vCurrEduCls_Sim_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vCurrEduCls_Sim_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vCurrEduCls_Sim_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vCurrEduCls_Sim_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vCurrEduCls_Sim_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vCurrEduCls_Sim_GetObjLstAsync = vCurrEduCls_Sim_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vCurrEduCls_Sim_GetObjLst_sessionStorage(strCourseId) {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvCurrEduCls_SimEN_js_1.clsvCurrEduCls_SimEN.WhereFormat) == false) {
            strWhereCond = (0, clsString_js_1.Format)(clsvCurrEduCls_SimEN_js_1.clsvCurrEduCls_SimEN.WhereFormat, strCourseId);
        }
        else {
            strWhereCond = (0, clsString_js_1.Format)("CourseId='{0}'", strCourseId);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvCurrEduCls_SimEN_js_1.clsvCurrEduCls_SimEN._CurrTabName, strCourseId);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvCurrEduCls_SimEN_js_1.clsvCurrEduCls_SimEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvCurrEduCls_SimEN_js_1.clsvCurrEduCls_SimEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrvCurrEduCls_SimExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrvCurrEduCls_SimObjLst_T = vCurrEduCls_Sim_GetObjLstByJSONObjLst(arrvCurrEduCls_SimExObjLst_Cache);
            return arrvCurrEduCls_SimObjLst_T;
        }
        try {
            const arrvCurrEduCls_SimExObjLst = await vCurrEduCls_Sim_GetObjLstAsync(strWhereCond);
            const strPrefix = (0, clsString_js_1.Format)("{0}_", clsvCurrEduCls_SimEN_js_1.clsvCurrEduCls_SimEN._CurrTabName);
            const arrCacheKeyLst = (0, CacheHelper_js_3.SessionStorage_GetKeyByPrefix)(strPrefix);
            arrCacheKeyLst.forEach(x => sessionStorage.removeItem(x));
            sessionStorage.setItem(strKey, JSON.stringify(arrvCurrEduCls_SimExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvCurrEduCls_SimExObjLst.length);
            console.log(strInfo);
            return arrvCurrEduCls_SimExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vCurrEduCls_Sim_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vCurrEduCls_Sim_GetObjLst_sessionStorage = vCurrEduCls_Sim_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vCurrEduCls_Sim_GetObjLst_sessionStorage_PureCache(strCourseId) {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("CourseId='{0}'", strCourseId);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvCurrEduCls_SimEN_js_1.clsvCurrEduCls_SimEN._CurrTabName, strCourseId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrvCurrEduCls_SimObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvCurrEduCls_SimObjLst_Cache;
        }
        else
            return null;
    }
    exports.vCurrEduCls_Sim_GetObjLst_sessionStorage_PureCache = vCurrEduCls_Sim_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vCurrEduCls_Sim_GetObjLst_Cache(strCourseId) {
        //const strThisFuncName = "GetObjLst_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strCourseId) == true) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[CourseId]不能为空！(in clsvCurrEduCls_SimWApi.vCurrEduCls_Sim_GetObjLst_Cache() )");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strCourseId.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strCourseId]的长度:[{0}]不正确！(in clsvCurrEduCls_SimWApi.vCurrEduCls_Sim_GetObjLst_Cache() )", strCourseId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        let arrvCurrEduCls_SimObjLst_Cache;
        switch (clsvCurrEduCls_SimEN_js_1.clsvCurrEduCls_SimEN.CacheModeId) {
            case "04": //sessionStorage
                arrvCurrEduCls_SimObjLst_Cache = await vCurrEduCls_Sim_GetObjLst_sessionStorage(strCourseId);
                break;
            case "03": //localStorage
                arrvCurrEduCls_SimObjLst_Cache = await vCurrEduCls_Sim_GetObjLst_localStorage(strCourseId);
                break;
            case "02": //ClientCache
                arrvCurrEduCls_SimObjLst_Cache = await vCurrEduCls_Sim_GetObjLst_ClientCache(strCourseId);
                break;
            default:
                arrvCurrEduCls_SimObjLst_Cache = await vCurrEduCls_Sim_GetObjLst_ClientCache(strCourseId);
                break;
        }
        const arrvCurrEduCls_SimObjLst = vCurrEduCls_Sim_GetObjLstByJSONObjLst(arrvCurrEduCls_SimObjLst_Cache);
        return arrvCurrEduCls_SimObjLst_Cache;
    }
    exports.vCurrEduCls_Sim_GetObjLst_Cache = vCurrEduCls_Sim_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vCurrEduCls_Sim_GetObjLst_PureCache(strCourseId) {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrvCurrEduCls_SimObjLst_Cache;
        switch (clsvCurrEduCls_SimEN_js_1.clsvCurrEduCls_SimEN.CacheModeId) {
            case "04": //sessionStorage
                arrvCurrEduCls_SimObjLst_Cache = await vCurrEduCls_Sim_GetObjLst_sessionStorage_PureCache(strCourseId);
                break;
            case "03": //localStorage
                arrvCurrEduCls_SimObjLst_Cache = await vCurrEduCls_Sim_GetObjLst_localStorage_PureCache(strCourseId);
                break;
            case "02": //ClientCache
                arrvCurrEduCls_SimObjLst_Cache = null;
                break;
            default:
                arrvCurrEduCls_SimObjLst_Cache = null;
                break;
        }
        return arrvCurrEduCls_SimObjLst_Cache;
    }
    exports.vCurrEduCls_Sim_GetObjLst_PureCache = vCurrEduCls_Sim_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objstrid_CurrEduCls_Cond:条件对象
     * @returns 对象列表子集
    */
    async function vCurrEduCls_Sim_GetSubObjLst_Cache(objvCurrEduCls_Sim_Cond, strCourseId) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrvCurrEduCls_SimObjLst_Cache = await vCurrEduCls_Sim_GetObjLst_Cache(strCourseId);
        let arrvCurrEduCls_Sim_Sel = arrvCurrEduCls_SimObjLst_Cache;
        if (objvCurrEduCls_Sim_Cond.sf_FldComparisonOp == null || objvCurrEduCls_Sim_Cond.sf_FldComparisonOp == "")
            return arrvCurrEduCls_Sim_Sel;
        const dicFldComparisonOp = JSON.parse(objvCurrEduCls_Sim_Cond.sf_FldComparisonOp);
        //console.log("clsvCurrEduCls_SimWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvCurrEduCls_Sim_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvCurrEduCls_Sim_Sel = arrvCurrEduCls_Sim_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvCurrEduCls_Sim_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvCurrEduCls_Sim_Sel = arrvCurrEduCls_Sim_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvCurrEduCls_Sim_Sel = arrvCurrEduCls_Sim_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvCurrEduCls_Sim_Sel = arrvCurrEduCls_Sim_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvCurrEduCls_Sim_Sel = arrvCurrEduCls_Sim_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvCurrEduCls_Sim_Sel = arrvCurrEduCls_Sim_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvCurrEduCls_Sim_Sel = arrvCurrEduCls_Sim_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvCurrEduCls_Sim_Sel = arrvCurrEduCls_Sim_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvCurrEduCls_Sim_Sel = arrvCurrEduCls_Sim_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvCurrEduCls_Sim_Sel = arrvCurrEduCls_Sim_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvCurrEduCls_Sim_Sel = arrvCurrEduCls_Sim_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvCurrEduCls_Sim_Sel = arrvCurrEduCls_Sim_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvCurrEduCls_Sim_Sel = arrvCurrEduCls_Sim_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvCurrEduCls_Sim_Sel = arrvCurrEduCls_Sim_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrvCurrEduCls_Sim_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objvCurrEduCls_Sim_Cond), exports.vCurrEduCls_Sim_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vCurrEduCls_Sim_GetSubObjLst_Cache = vCurrEduCls_Sim_GetSubObjLst_Cache;
    /// <summary>
    /// 把多个关键字段的值连接起来，用|连接(Join)--vCurrEduCls_Sim(vCurrEduCls_Sim)
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_JoinByKeyLst)
    /// </summary>
    /// <param name = "objvCurrEduCls_SimEN">需要连接的对象</param>
    /// <returns></returns>
    function vCurrEduCls_Sim_JoinByKeyLst(objvCurrEduCls_SimEN) {
        //检测记录是否存在
        let strResult = "";
        strResult += objvCurrEduCls_SimEN.id_CurrEduCls;
        strResult += "|" + objvCurrEduCls_SimEN.eduClsTypeId;
        return strResult;
    }
    exports.vCurrEduCls_Sim_JoinByKeyLst = vCurrEduCls_Sim_JoinByKeyLst;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrstrid_CurrEduClsLst:关键字列表
     * @returns 对象列表
    */
    async function vCurrEduCls_Sim_GetObjLstByKeyLsts_Cache(arrid_CurrEduClsLst, strCourseId) {
        const strThisFuncName = "GetObjLstByKeyLsts_Cache";
        try {
            const arrvCurrEduCls_SimObjLst_Cache = await vCurrEduCls_Sim_GetObjLst_Cache(strCourseId);
            const arrvCurrEduCls_Sim_Sel = arrvCurrEduCls_SimObjLst_Cache.filter(x => arrid_CurrEduClsLst.indexOf(vCurrEduCls_Sim_JoinByKeyLst(x)) > -1);
            return arrvCurrEduCls_Sim_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrid_CurrEduClsLst.join(","), exports.vCurrEduCls_Sim_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
    }
    exports.vCurrEduCls_Sim_GetObjLstByKeyLsts_Cache = vCurrEduCls_Sim_GetObjLstByKeyLsts_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function vCurrEduCls_Sim_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vCurrEduCls_Sim_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vCurrEduCls_Sim_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vCurrEduCls_Sim_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vCurrEduCls_Sim_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vCurrEduCls_Sim_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vCurrEduCls_Sim_GetTopObjLstAsync = vCurrEduCls_Sim_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vCurrEduCls_Sim_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vCurrEduCls_Sim_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vCurrEduCls_Sim_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vCurrEduCls_Sim_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vCurrEduCls_Sim_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vCurrEduCls_Sim_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vCurrEduCls_Sim_GetObjLstByRangeAsync = vCurrEduCls_Sim_GetObjLstByRangeAsync;
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
    async function vCurrEduCls_Sim_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vCurrEduCls_Sim_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vCurrEduCls_Sim_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vCurrEduCls_Sim_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vCurrEduCls_Sim_GetObjLstByRange = vCurrEduCls_Sim_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function vCurrEduCls_Sim_GetObjLstByPager_Cache(objPagerPara, strCourseId) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const arrvCurrEduCls_SimObjLst_Cache = await vCurrEduCls_Sim_GetObjLst_Cache(strCourseId);
        if (arrvCurrEduCls_SimObjLst_Cache.length == 0)
            return arrvCurrEduCls_SimObjLst_Cache;
        let arrvCurrEduCls_Sim_Sel = arrvCurrEduCls_SimObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objvCurrEduCls_Sim_Cond = new clsvCurrEduCls_SimEN_js_1.clsvCurrEduCls_SimEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvCurrEduCls_Sim_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsvCurrEduCls_SimWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvCurrEduCls_Sim_Sel = arrvCurrEduCls_Sim_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvCurrEduCls_Sim_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvCurrEduCls_Sim_Sel = arrvCurrEduCls_Sim_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvCurrEduCls_Sim_Sel = arrvCurrEduCls_Sim_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvCurrEduCls_Sim_Sel = arrvCurrEduCls_Sim_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvCurrEduCls_Sim_Sel = arrvCurrEduCls_Sim_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvCurrEduCls_Sim_Sel = arrvCurrEduCls_Sim_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvCurrEduCls_Sim_Sel = arrvCurrEduCls_Sim_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvCurrEduCls_Sim_Sel = arrvCurrEduCls_Sim_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrvCurrEduCls_Sim_Sel = arrvCurrEduCls_Sim_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvCurrEduCls_Sim_Sel = arrvCurrEduCls_Sim_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvCurrEduCls_Sim_Sel = arrvCurrEduCls_Sim_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvCurrEduCls_Sim_Sel = arrvCurrEduCls_Sim_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvCurrEduCls_Sim_Sel = arrvCurrEduCls_Sim_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvCurrEduCls_Sim_Sel = arrvCurrEduCls_Sim_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvCurrEduCls_Sim_Sel = arrvCurrEduCls_Sim_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvCurrEduCls_Sim_Sel.length == 0)
                return arrvCurrEduCls_Sim_Sel;
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
                arrvCurrEduCls_Sim_Sel = arrvCurrEduCls_Sim_Sel.sort(vCurrEduCls_Sim_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrvCurrEduCls_Sim_Sel = arrvCurrEduCls_Sim_Sel.sort(objPagerPara.sortFun);
            }
            arrvCurrEduCls_Sim_Sel = arrvCurrEduCls_Sim_Sel.slice(intStart, intEnd);
            return arrvCurrEduCls_Sim_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.vCurrEduCls_Sim_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vCurrEduCls_Sim_GetObjLstByPager_Cache = vCurrEduCls_Sim_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vCurrEduCls_Sim_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vCurrEduCls_Sim_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vCurrEduCls_Sim_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vCurrEduCls_Sim_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vCurrEduCls_Sim_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vCurrEduCls_Sim_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vCurrEduCls_Sim_GetObjLstByPagerAsync = vCurrEduCls_Sim_GetObjLstByPagerAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objstrid_CurrEduCls_Cond:条件对象
     * @returns 对象列表子集
    */
    async function vCurrEduCls_Sim_IsExistRecord_Cache(objvCurrEduCls_Sim_Cond, strCourseId) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrvCurrEduCls_SimObjLst_Cache = await vCurrEduCls_Sim_GetObjLst_Cache(strCourseId);
        if (arrvCurrEduCls_SimObjLst_Cache == null)
            return false;
        let arrvCurrEduCls_Sim_Sel = arrvCurrEduCls_SimObjLst_Cache;
        if (objvCurrEduCls_Sim_Cond.sf_FldComparisonOp == null || objvCurrEduCls_Sim_Cond.sf_FldComparisonOp == "")
            return arrvCurrEduCls_Sim_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objvCurrEduCls_Sim_Cond.sf_FldComparisonOp);
        //console.log("clsvCurrEduCls_SimWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvCurrEduCls_Sim_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvCurrEduCls_Sim_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvCurrEduCls_Sim_Sel = arrvCurrEduCls_Sim_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvCurrEduCls_Sim_Sel = arrvCurrEduCls_Sim_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvCurrEduCls_Sim_Sel = arrvCurrEduCls_Sim_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvCurrEduCls_Sim_Sel = arrvCurrEduCls_Sim_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvCurrEduCls_Sim_Sel = arrvCurrEduCls_Sim_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvCurrEduCls_Sim_Sel = arrvCurrEduCls_Sim_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvCurrEduCls_Sim_Sel = arrvCurrEduCls_Sim_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvCurrEduCls_Sim_Sel = arrvCurrEduCls_Sim_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvCurrEduCls_Sim_Sel = arrvCurrEduCls_Sim_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvCurrEduCls_Sim_Sel = arrvCurrEduCls_Sim_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvCurrEduCls_Sim_Sel = arrvCurrEduCls_Sim_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvCurrEduCls_Sim_Sel = arrvCurrEduCls_Sim_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvCurrEduCls_Sim_Sel = arrvCurrEduCls_Sim_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvCurrEduCls_Sim_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objvCurrEduCls_Sim_Cond), exports.vCurrEduCls_Sim_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.vCurrEduCls_Sim_IsExistRecord_Cache = vCurrEduCls_Sim_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function vCurrEduCls_Sim_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vCurrEduCls_Sim_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vCurrEduCls_Sim_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vCurrEduCls_Sim_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vCurrEduCls_Sim_IsExistRecordAsync = vCurrEduCls_Sim_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strid_CurrEduCls:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function vCurrEduCls_Sim_IsExist(strid_CurrEduCls, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vCurrEduCls_Sim_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "id_CurrEduCls": strid_CurrEduCls,
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vCurrEduCls_Sim_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vCurrEduCls_Sim_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vCurrEduCls_Sim_IsExist = vCurrEduCls_Sim_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param strid_CurrEduCls:所给的关键字
     * @returns 对象
    */
    async function vCurrEduCls_Sim_IsExist_Cache(strid_CurrEduCls, strEduClsTypeId, strCourseId) {
        const strThisFuncName = "IsExist_Cache";
        const arrvCurrEduCls_SimObjLst_Cache = await vCurrEduCls_Sim_GetObjLst_Cache(strCourseId);
        if (arrvCurrEduCls_SimObjLst_Cache == null)
            return false;
        try {
            const arrvCurrEduCls_Sim_Sel = arrvCurrEduCls_SimObjLst_Cache.filter(x => x.id_CurrEduCls == strid_CurrEduCls && x.eduClsTypeId == strEduClsTypeId);
            if (arrvCurrEduCls_Sim_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strid_CurrEduCls, exports.vCurrEduCls_Sim_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.vCurrEduCls_Sim_IsExist_Cache = vCurrEduCls_Sim_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strid_CurrEduCls:关键字
    * @returns 是否存在?存在返回True
    **/
    async function vCurrEduCls_Sim_IsExistAsync(strid_CurrEduCls) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vCurrEduCls_Sim_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strid_CurrEduCls": strid_CurrEduCls }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vCurrEduCls_Sim_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vCurrEduCls_Sim_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vCurrEduCls_Sim_IsExistAsync = vCurrEduCls_Sim_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function vCurrEduCls_Sim_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vCurrEduCls_Sim_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vCurrEduCls_Sim_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vCurrEduCls_Sim_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vCurrEduCls_Sim_GetRecCountByCondAsync = vCurrEduCls_Sim_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objvCurrEduCls_Sim_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function vCurrEduCls_Sim_GetRecCountByCond_Cache(objvCurrEduCls_Sim_Cond, strCourseId) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrvCurrEduCls_SimObjLst_Cache = await vCurrEduCls_Sim_GetObjLst_Cache(strCourseId);
        if (arrvCurrEduCls_SimObjLst_Cache == null)
            return 0;
        let arrvCurrEduCls_Sim_Sel = arrvCurrEduCls_SimObjLst_Cache;
        if (objvCurrEduCls_Sim_Cond.sf_FldComparisonOp == null || objvCurrEduCls_Sim_Cond.sf_FldComparisonOp == "")
            return arrvCurrEduCls_Sim_Sel.length;
        const dicFldComparisonOp = JSON.parse(objvCurrEduCls_Sim_Cond.sf_FldComparisonOp);
        //console.log("clsvCurrEduCls_SimWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvCurrEduCls_Sim_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvCurrEduCls_Sim_Sel = arrvCurrEduCls_Sim_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvCurrEduCls_Sim_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvCurrEduCls_Sim_Sel = arrvCurrEduCls_Sim_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvCurrEduCls_Sim_Sel = arrvCurrEduCls_Sim_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvCurrEduCls_Sim_Sel = arrvCurrEduCls_Sim_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvCurrEduCls_Sim_Sel = arrvCurrEduCls_Sim_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvCurrEduCls_Sim_Sel = arrvCurrEduCls_Sim_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvCurrEduCls_Sim_Sel = arrvCurrEduCls_Sim_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvCurrEduCls_Sim_Sel = arrvCurrEduCls_Sim_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrvCurrEduCls_Sim_Sel = arrvCurrEduCls_Sim_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvCurrEduCls_Sim_Sel = arrvCurrEduCls_Sim_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvCurrEduCls_Sim_Sel = arrvCurrEduCls_Sim_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvCurrEduCls_Sim_Sel = arrvCurrEduCls_Sim_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvCurrEduCls_Sim_Sel = arrvCurrEduCls_Sim_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvCurrEduCls_Sim_Sel = arrvCurrEduCls_Sim_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvCurrEduCls_Sim_Sel = arrvCurrEduCls_Sim_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrvCurrEduCls_Sim_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objvCurrEduCls_Sim_Cond), exports.vCurrEduCls_Sim_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.vCurrEduCls_Sim_GetRecCountByCond_Cache = vCurrEduCls_Sim_GetRecCountByCond_Cache;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function vCurrEduCls_Sim_GetWebApiUrl(strController, strAction) {
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
    exports.vCurrEduCls_Sim_GetWebApiUrl = vCurrEduCls_Sim_GetWebApiUrl;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function vCurrEduCls_Sim_ReFreshThisCache(strCourseId) {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvCurrEduCls_SimEN_js_1.clsvCurrEduCls_SimEN._CurrTabName, strCourseId);
            switch (clsvCurrEduCls_SimEN_js_1.clsvCurrEduCls_SimEN.CacheModeId) {
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
    exports.vCurrEduCls_Sim_ReFreshThisCache = vCurrEduCls_Sim_ReFreshThisCache;
    /**
     * 绑定基于Web的下拉框,在某一层下的下拉框
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunctionInDiv)
     * @param objDDL:需要绑定当前表的下拉框
     * @param strCourseId:课程Id
    */
    async function vCurrEduCls_Sim_BindDdl_id_CurrEduClsByCourseIdInDiv_Cache(strDivName, strDdlName, strCourseId) {
        const strThisFuncName = "BindDdl_id_CurrEduClsByCourseIdInDiv_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strCourseId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strCourseId]不能为空！(In clsvCurrEduCls_SimWApi.BindDdl_id_CurrEduClsByCourseIdInDiv)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strCourseId.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strCourseId]的长度:[{0}]不正确！(clsvCurrEduCls_SimWApi.BindDdl_id_CurrEduClsByCourseIdInDiv)", strCourseId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const objDdl = document.getElementById(strDdlName);
        if (objDdl == null) {
            const strMsg = (0, clsString_js_1.Format)("下拉框：{0} 不存在！(In BindDdl_id_CurrEduClsByCourseIdInDiv)", strDdlName);
            alert(strMsg);
            console.error(strMsg);
            throw (strMsg);
        }
        //为数据源于表的下拉框设置内容
        //console.log("开始：BindDdl_id_CurrEduClsByCourseIdInDiv_Cache");
        let arrObjLst_Sel = await vCurrEduCls_Sim_GetObjLst_Cache(strCourseId);
        if (arrObjLst_Sel == null)
            return;
        (0, clsCommFunc4Web_js_1.BindDdl_ObjLstInDiv_V)(strDivName, strDdlName, arrObjLst_Sel, clsvCurrEduCls_SimEN_js_1.clsvCurrEduCls_SimEN.con_id_CurrEduCls, clsvCurrEduCls_SimEN_js_1.clsvCurrEduCls_SimEN.con_EduClsName, "vCurrEduCls_Sim");
    }
    exports.vCurrEduCls_Sim_BindDdl_id_CurrEduClsByCourseIdInDiv_Cache = vCurrEduCls_Sim_BindDdl_id_CurrEduClsByCourseIdInDiv_Cache;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vCurrEduCls_Sim_GetJSONStrByObj(pobjvCurrEduCls_SimEN) {
        const strThisFuncName = "GetJSONStrByObj";
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjvCurrEduCls_SimEN);
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
    exports.vCurrEduCls_Sim_GetJSONStrByObj = vCurrEduCls_Sim_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function vCurrEduCls_Sim_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrvCurrEduCls_SimObjLst = new Array();
        if (strJSON === "") {
            return arrvCurrEduCls_SimObjLst;
        }
        try {
            arrvCurrEduCls_SimObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrvCurrEduCls_SimObjLst;
        }
        return arrvCurrEduCls_SimObjLst;
    }
    exports.vCurrEduCls_Sim_GetObjLstByJSONStr = vCurrEduCls_Sim_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrvCurrEduCls_SimObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function vCurrEduCls_Sim_GetObjLstByJSONObjLst(arrvCurrEduCls_SimObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrvCurrEduCls_SimObjLst = new Array();
        for (const objInFor of arrvCurrEduCls_SimObjLstS) {
            const obj1 = vCurrEduCls_Sim_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrvCurrEduCls_SimObjLst.push(obj1);
        }
        return arrvCurrEduCls_SimObjLst;
    }
    exports.vCurrEduCls_Sim_GetObjLstByJSONObjLst = vCurrEduCls_Sim_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vCurrEduCls_Sim_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjvCurrEduCls_SimEN = new clsvCurrEduCls_SimEN_js_1.clsvCurrEduCls_SimEN();
        if (strJSON === "") {
            return pobjvCurrEduCls_SimEN;
        }
        try {
            pobjvCurrEduCls_SimEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjvCurrEduCls_SimEN;
        }
        return pobjvCurrEduCls_SimEN;
    }
    exports.vCurrEduCls_Sim_GetObjByJSONStr = vCurrEduCls_Sim_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function vCurrEduCls_Sim_GetCombineCondition(objvCurrEduCls_Sim_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Sim_Cond.dicFldComparisonOp, clsvCurrEduCls_SimEN_js_1.clsvCurrEduCls_SimEN.con_id_CurrEduCls) == true) {
            const strComparisonOp_id_CurrEduCls = objvCurrEduCls_Sim_Cond.dicFldComparisonOp[clsvCurrEduCls_SimEN_js_1.clsvCurrEduCls_SimEN.con_id_CurrEduCls];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduCls_SimEN_js_1.clsvCurrEduCls_SimEN.con_id_CurrEduCls, objvCurrEduCls_Sim_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Sim_Cond.dicFldComparisonOp, clsvCurrEduCls_SimEN_js_1.clsvCurrEduCls_SimEN.con_CurrEduClsId) == true) {
            const strComparisonOp_CurrEduClsId = objvCurrEduCls_Sim_Cond.dicFldComparisonOp[clsvCurrEduCls_SimEN_js_1.clsvCurrEduCls_SimEN.con_CurrEduClsId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduCls_SimEN_js_1.clsvCurrEduCls_SimEN.con_CurrEduClsId, objvCurrEduCls_Sim_Cond.currEduClsId, strComparisonOp_CurrEduClsId);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Sim_Cond.dicFldComparisonOp, clsvCurrEduCls_SimEN_js_1.clsvCurrEduCls_SimEN.con_EduClsName) == true) {
            const strComparisonOp_EduClsName = objvCurrEduCls_Sim_Cond.dicFldComparisonOp[clsvCurrEduCls_SimEN_js_1.clsvCurrEduCls_SimEN.con_EduClsName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduCls_SimEN_js_1.clsvCurrEduCls_SimEN.con_EduClsName, objvCurrEduCls_Sim_Cond.eduClsName, strComparisonOp_EduClsName);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Sim_Cond.dicFldComparisonOp, clsvCurrEduCls_SimEN_js_1.clsvCurrEduCls_SimEN.con_EduClsTypeId) == true) {
            const strComparisonOp_EduClsTypeId = objvCurrEduCls_Sim_Cond.dicFldComparisonOp[clsvCurrEduCls_SimEN_js_1.clsvCurrEduCls_SimEN.con_EduClsTypeId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduCls_SimEN_js_1.clsvCurrEduCls_SimEN.con_EduClsTypeId, objvCurrEduCls_Sim_Cond.eduClsTypeId, strComparisonOp_EduClsTypeId);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Sim_Cond.dicFldComparisonOp, clsvCurrEduCls_SimEN_js_1.clsvCurrEduCls_SimEN.con_CourseId) == true) {
            const strComparisonOp_CourseId = objvCurrEduCls_Sim_Cond.dicFldComparisonOp[clsvCurrEduCls_SimEN_js_1.clsvCurrEduCls_SimEN.con_CourseId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduCls_SimEN_js_1.clsvCurrEduCls_SimEN.con_CourseId, objvCurrEduCls_Sim_Cond.courseId, strComparisonOp_CourseId);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Sim_Cond.dicFldComparisonOp, clsvCurrEduCls_SimEN_js_1.clsvCurrEduCls_SimEN.con_id_XzCollege) == true) {
            const strComparisonOp_id_XzCollege = objvCurrEduCls_Sim_Cond.dicFldComparisonOp[clsvCurrEduCls_SimEN_js_1.clsvCurrEduCls_SimEN.con_id_XzCollege];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduCls_SimEN_js_1.clsvCurrEduCls_SimEN.con_id_XzCollege, objvCurrEduCls_Sim_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Sim_Cond.dicFldComparisonOp, clsvCurrEduCls_SimEN_js_1.clsvCurrEduCls_SimEN.con_id_XzMajor) == true) {
            const strComparisonOp_id_XzMajor = objvCurrEduCls_Sim_Cond.dicFldComparisonOp[clsvCurrEduCls_SimEN_js_1.clsvCurrEduCls_SimEN.con_id_XzMajor];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduCls_SimEN_js_1.clsvCurrEduCls_SimEN.con_id_XzMajor, objvCurrEduCls_Sim_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
        }
        return strWhereCond;
    }
    exports.vCurrEduCls_Sim_GetCombineCondition = vCurrEduCls_Sim_GetCombineCondition;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objvCurrEduCls_SimENS:源对象
     * @param objvCurrEduCls_SimENT:目标对象
    */
    function vCurrEduCls_Sim_CopyObjTo(objvCurrEduCls_SimENS, objvCurrEduCls_SimENT) {
        objvCurrEduCls_SimENT.id_CurrEduCls = objvCurrEduCls_SimENS.id_CurrEduCls; //教学班流水号
        objvCurrEduCls_SimENT.currEduClsId = objvCurrEduCls_SimENS.currEduClsId; //教学班Id
        objvCurrEduCls_SimENT.eduClsName = objvCurrEduCls_SimENS.eduClsName; //教学班名
        objvCurrEduCls_SimENT.eduClsTypeId = objvCurrEduCls_SimENS.eduClsTypeId; //教学班类型Id
        objvCurrEduCls_SimENT.courseId = objvCurrEduCls_SimENS.courseId; //课程Id
        objvCurrEduCls_SimENT.id_XzCollege = objvCurrEduCls_SimENS.id_XzCollege; //学院流水号
        objvCurrEduCls_SimENT.id_XzMajor = objvCurrEduCls_SimENS.id_XzMajor; //专业流水号
    }
    exports.vCurrEduCls_Sim_CopyObjTo = vCurrEduCls_Sim_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objvCurrEduCls_SimENS:源对象
     * @param objvCurrEduCls_SimENT:目标对象
    */
    function vCurrEduCls_Sim_GetObjFromJsonObj(objvCurrEduCls_SimENS) {
        const objvCurrEduCls_SimENT = new clsvCurrEduCls_SimEN_js_1.clsvCurrEduCls_SimEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvCurrEduCls_SimENT, objvCurrEduCls_SimENS);
        return objvCurrEduCls_SimENT;
    }
    exports.vCurrEduCls_Sim_GetObjFromJsonObj = vCurrEduCls_Sim_GetObjFromJsonObj;
});
