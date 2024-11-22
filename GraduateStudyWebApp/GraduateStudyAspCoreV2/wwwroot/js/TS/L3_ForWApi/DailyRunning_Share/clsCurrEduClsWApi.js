/**
* 类名:clsCurrEduClsWApi
* 表名:CurrEduCls(01120123)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/13 02:45:24
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
        define(["require", "exports", "axios", "../../PubFun/enumComparisonOp.js", "../../PubFun/CacheHelper.js", "../../L0_Entity/DailyRunning_Share/clsCurrEduClsEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.CurrEduCls_GetObjFromJsonObj = exports.CurrEduCls_CopyObjTo = exports.CurrEduCls_GetUniCondStr4Update_EduClsName = exports.CurrEduCls_GetUniCondStr_EduClsName = exports.CurrEduCls_GetCombineCondition = exports.CurrEduCls_GetObjByJSONStr = exports.CurrEduCls_GetObjLstByJSONObjLst = exports.CurrEduCls_GetObjLstByJSONStr = exports.CurrEduCls_GetJSONStrByObj = exports.CurrEduCls_CheckProperty4Update = exports.CurrEduCls_CheckPropertyNew = exports.CurrEduCls_BindDdl_id_CurrEduClsInDiv_Cache = exports.CurrEduCls_ReFreshThisCache = exports.CurrEduCls_ReFreshCache = exports.CurrEduCls_GetWebApiUrl = exports.CurrEduCls_GetMaxStrIdByPrefix = exports.CurrEduCls_GetMaxStrIdAsync = exports.CurrEduCls_GetRecCountByCond_Cache = exports.CurrEduCls_GetRecCountByCondAsync = exports.CurrEduCls_IsExistAsync = exports.CurrEduCls_IsExist_Cache = exports.CurrEduCls_IsExist = exports.CurrEduCls_IsExistRecordAsync = exports.CurrEduCls_IsExistRecord_Cache = exports.CurrEduCls_UpdateWithConditionAsync = exports.CurrEduCls_UpdateRecordAsync = exports.CurrEduCls_AddNewRecordWithReturnKey = exports.CurrEduCls_AddNewRecordWithReturnKeyAsync = exports.CurrEduCls_AddNewRecordWithMaxIdAsync = exports.CurrEduCls_AddNewRecordAsync = exports.CurrEduCls_DelCurrEduClssByCondAsync = exports.CurrEduCls_DelCurrEduClssAsync = exports.CurrEduCls_DelRecordAsync = exports.CurrEduCls_GetObjLstByPagerAsync = exports.CurrEduCls_GetObjLstByPager_Cache = exports.CurrEduCls_GetObjLstByRange = exports.CurrEduCls_GetObjLstByRangeAsync = exports.CurrEduCls_GetTopObjLstAsync = exports.CurrEduCls_GetObjLstByid_CurrEduClsLst_Cache = exports.CurrEduCls_GetObjLstByid_CurrEduClsLstAsync = exports.CurrEduCls_GetSubObjLst_Cache = exports.CurrEduCls_GetObjLst_PureCache = exports.CurrEduCls_GetObjLst_Cache = exports.CurrEduCls_GetObjLst_sessionStorage_PureCache = exports.CurrEduCls_GetObjLst_sessionStorage = exports.CurrEduCls_GetObjLstAsync = exports.CurrEduCls_GetObjLst_localStorage_PureCache = exports.CurrEduCls_GetObjLst_localStorage = exports.CurrEduCls_GetObjLst_ClientCache = exports.CurrEduCls_GetFirstObjAsync = exports.CurrEduCls_GetFirstID = exports.CurrEduCls_GetFirstIDAsync = exports.CurrEduCls_funcKey = exports.CurrEduCls_FilterFunByKey = exports.CurrEduCls_SortFunByKey = exports.CurrEduCls_SortFun_Defa_2Fld = exports.CurrEduCls_SortFun_Defa = exports.CurrEduCls_func = exports.CurrEduCls_GetNameByid_CurrEduCls_Cache = exports.CurrEduCls_UpdateObjInLst_Cache = exports.CurrEduCls_GetObjByid_CurrEduCls_localStorage = exports.CurrEduCls_GetObjByid_CurrEduCls_Cache = exports.CurrEduCls_GetObjByid_CurrEduClsAsync = exports.currEduCls_ConstructorName = exports.currEduCls_Controller = void 0;
    /**
     * 当前教学班(CurrEduCls)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月13日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const enumComparisonOp_js_1 = require("../../PubFun/enumComparisonOp.js");
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsCurrEduClsEN_js_1 = require("../../L0_Entity/DailyRunning_Share/clsCurrEduClsEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsString_js_2 = require("../../PubFun/clsString.js");
    exports.currEduCls_Controller = "CurrEduClsApi";
    exports.currEduCls_ConstructorName = "currEduCls";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strid_CurrEduCls:关键字
    * @returns 对象
    **/
    async function CurrEduCls_GetObjByid_CurrEduClsAsync(strid_CurrEduCls) {
        const strThisFuncName = "GetObjByid_CurrEduClsAsync";
        if ((0, clsString_js_2.IsNullOrEmpty)(strid_CurrEduCls) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strid_CurrEduCls]不能为空！(In clsCurrEduClsWApi.GetObjByid_CurrEduClsAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strid_CurrEduCls]的长度:[{0}]不正确！(clsCurrEduClsWApi.GetObjByid_CurrEduClsAsync)", strid_CurrEduCls.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByid_CurrEduCls";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.currEduCls_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "strid_CurrEduCls": strid_CurrEduCls,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    return null;
                }
                //console.log(returnObj);
                const objCurrEduCls = CurrEduCls_GetObjFromJsonObj(returnObj);
                return objCurrEduCls;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.currEduCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.currEduCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CurrEduCls_GetObjByid_CurrEduClsAsync = CurrEduCls_GetObjByid_CurrEduClsAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param strid_CurrEduCls:所给的关键字
     * @returns 对象
    */
    async function CurrEduCls_GetObjByid_CurrEduCls_Cache(strid_CurrEduCls, strCourseId, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByid_CurrEduCls_Cache";
        if ((0, clsString_js_2.IsNullOrEmpty)(strid_CurrEduCls) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strid_CurrEduCls]不能为空！(In clsCurrEduClsWApi.GetObjByid_CurrEduCls_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strid_CurrEduCls]的长度:[{0}]不正确！(clsCurrEduClsWApi.GetObjByid_CurrEduCls_Cache)", strid_CurrEduCls.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrCurrEduClsObjLst_Cache = await CurrEduCls_GetObjLst_Cache(strCourseId);
        try {
            const arrCurrEduCls_Sel = arrCurrEduClsObjLst_Cache.filter(x => x.id_CurrEduCls == strid_CurrEduCls);
            let objCurrEduCls;
            if (arrCurrEduCls_Sel.length > 0) {
                objCurrEduCls = arrCurrEduCls_Sel[0];
                return objCurrEduCls;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    const objCurrEduCls_Const = await CurrEduCls_GetObjByid_CurrEduClsAsync(strid_CurrEduCls);
                    if (objCurrEduCls_Const != null) {
                        CurrEduCls_ReFreshThisCache(strCourseId);
                        return objCurrEduCls_Const;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strid_CurrEduCls, exports.currEduCls_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.CurrEduCls_GetObjByid_CurrEduCls_Cache = CurrEduCls_GetObjByid_CurrEduCls_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param strid_CurrEduCls:所给的关键字
     * @returns 对象
    */
    async function CurrEduCls_GetObjByid_CurrEduCls_localStorage(strid_CurrEduCls) {
        const strThisFuncName = "GetObjByid_CurrEduCls_localStorage";
        if ((0, clsString_js_2.IsNullOrEmpty)(strid_CurrEduCls) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strid_CurrEduCls]不能为空！(In clsCurrEduClsWApi.GetObjByid_CurrEduCls_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strid_CurrEduCls]的长度:[{0}]不正确！(clsCurrEduClsWApi.GetObjByid_CurrEduCls_localStorage)", strid_CurrEduCls.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsCurrEduClsEN_js_1.clsCurrEduClsEN._CurrTabName, strid_CurrEduCls);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objCurrEduCls_Cache = JSON.parse(strTempObj);
            return objCurrEduCls_Cache;
        }
        try {
            const objCurrEduCls = await CurrEduCls_GetObjByid_CurrEduClsAsync(strid_CurrEduCls);
            if (objCurrEduCls != null) {
                localStorage.setItem(strKey, JSON.stringify(objCurrEduCls));
                const strInfo = (0, clsString_js_2.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objCurrEduCls;
            }
            return objCurrEduCls;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strid_CurrEduCls, exports.currEduCls_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.CurrEduCls_GetObjByid_CurrEduCls_localStorage = CurrEduCls_GetObjByid_CurrEduCls_localStorage;
    /**
     * 修改在缓存对象列表中的对象, 与后台数据库无关.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
     * @param objCurrEduCls:所给的对象
     * @returns 对象
    */
    async function CurrEduCls_UpdateObjInLst_Cache(objCurrEduCls, strCourseId) {
        const strThisFuncName = "UpdateObjInLst_Cache";
        try {
            const arrCurrEduClsObjLst_Cache = await CurrEduCls_GetObjLst_Cache(strCourseId);
            const obj = arrCurrEduClsObjLst_Cache.find(x => x.eduClsName == objCurrEduCls.eduClsName);
            if (obj != null) {
                objCurrEduCls.id_CurrEduCls = obj.id_CurrEduCls;
                (0, clsCommFunc4Web_js_1.ObjectAssign)(obj, objCurrEduCls);
            }
            else {
                arrCurrEduClsObjLst_Cache.push(objCurrEduCls);
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, exports.currEduCls_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.CurrEduCls_UpdateObjInLst_Cache = CurrEduCls_UpdateObjInLst_Cache;
    /**
     * 根据关键字获取相关对象的名称属性, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetNameByKeyId_Cache)
     * @param strid_CurrEduCls:所给的关键字
     * @returns 对象
    */
    async function CurrEduCls_GetNameByid_CurrEduCls_Cache(strid_CurrEduCls, strCourseId) {
        const strThisFuncName = "GetNameByid_CurrEduCls_Cache";
        if ((0, clsString_js_2.IsNullOrEmpty)(strid_CurrEduCls) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strid_CurrEduCls]不能为空！(In clsCurrEduClsWApi.GetNameByid_CurrEduCls_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strid_CurrEduCls]的长度:[{0}]不正确！(clsCurrEduClsWApi.GetNameByid_CurrEduCls_Cache)", strid_CurrEduCls.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrCurrEduClsObjLst_Cache = await CurrEduCls_GetObjLst_Cache(strCourseId);
        if (arrCurrEduClsObjLst_Cache == null)
            return "";
        try {
            const arrCurrEduCls_Sel = arrCurrEduClsObjLst_Cache.filter(x => x.id_CurrEduCls == strid_CurrEduCls);
            let objCurrEduCls;
            if (arrCurrEduCls_Sel.length > 0) {
                objCurrEduCls = arrCurrEduCls_Sel[0];
                return objCurrEduCls.eduClsName;
            }
            else {
                return "";
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象名称属性不成功!", e, strid_CurrEduCls);
            console.error(strMsg);
            alert(strMsg);
        }
        return "";
    }
    exports.CurrEduCls_GetNameByid_CurrEduCls_Cache = CurrEduCls_GetNameByid_CurrEduCls_Cache;
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
    async function CurrEduCls_func(strInFldName, strOutFldName, strInValue, strCourseId_C) {
        //const strThisFuncName = "func";
        if ((0, clsString_js_2.IsNullOrEmpty)(strCourseId_C) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strCourseId_C]不能为空！(In clsCurrEduClsWApi.func)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strCourseId_C.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strCourseId_C]的长度:[{0}]不正确！(clsCurrEduClsWApi.func)", strCourseId_C.length);
            console.error(strMsg);
            throw (strMsg);
        }
        if (strInFldName != clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_id_CurrEduCls) {
            const strMsg = (0, clsString_js_2.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsCurrEduClsEN_js_1.clsCurrEduClsEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_2.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strOutFldName, clsCurrEduClsEN_js_1.clsCurrEduClsEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strid_CurrEduCls = strInValue;
        if ((0, clsString_js_2.IsNullOrEmpty)(strInValue) == true) {
            return "";
        }
        const objCurrEduCls = await CurrEduCls_GetObjByid_CurrEduCls_Cache(strid_CurrEduCls, strCourseId_C);
        if (objCurrEduCls == null)
            return "";
        if (objCurrEduCls.GetFldValue(strOutFldName) == null)
            return "";
        return objCurrEduCls.GetFldValue(strOutFldName).toString();
    }
    exports.CurrEduCls_func = CurrEduCls_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function CurrEduCls_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
    }
    exports.CurrEduCls_SortFun_Defa = CurrEduCls_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function CurrEduCls_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.currEduClsId == b.currEduClsId)
            return a.eduClsName.localeCompare(b.eduClsName);
        else
            return a.currEduClsId.localeCompare(b.currEduClsId);
    }
    exports.CurrEduCls_SortFun_Defa_2Fld = CurrEduCls_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function CurrEduCls_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_id_CurrEduCls:
                    return (a, b) => {
                        return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
                    };
                case clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_CurrEduClsId:
                    return (a, b) => {
                        return a.currEduClsId.localeCompare(b.currEduClsId);
                    };
                case clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_EduClsName:
                    return (a, b) => {
                        if (a.eduClsName == null)
                            return -1;
                        if (b.eduClsName == null)
                            return 1;
                        return a.eduClsName.localeCompare(b.eduClsName);
                    };
                case clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_EduClsTypeId:
                    return (a, b) => {
                        if (a.eduClsTypeId == null)
                            return -1;
                        if (b.eduClsTypeId == null)
                            return 1;
                        return a.eduClsTypeId.localeCompare(b.eduClsTypeId);
                    };
                case clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_CourseId:
                    return (a, b) => {
                        if (a.courseId == null)
                            return -1;
                        if (b.courseId == null)
                            return 1;
                        return a.courseId.localeCompare(b.courseId);
                    };
                case clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_TeachingSolutionId:
                    return (a, b) => {
                        if (a.teachingSolutionId == null)
                            return -1;
                        if (b.teachingSolutionId == null)
                            return 1;
                        return a.teachingSolutionId.localeCompare(b.teachingSolutionId);
                    };
                case clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_id_XzCollege:
                    return (a, b) => {
                        if (a.id_XzCollege == null)
                            return -1;
                        if (b.id_XzCollege == null)
                            return 1;
                        return a.id_XzCollege.localeCompare(b.id_XzCollege);
                    };
                case clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_id_XzMajor:
                    return (a, b) => {
                        return a.id_XzMajor.localeCompare(b.id_XzMajor);
                    };
                case clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_id_EduWay:
                    return (a, b) => {
                        if (a.id_EduWay == null)
                            return -1;
                        if (b.id_EduWay == null)
                            return 1;
                        return a.id_EduWay.localeCompare(b.id_EduWay);
                    };
                case clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_id_ClassRoomType:
                    return (a, b) => {
                        if (a.id_ClassRoomType == null)
                            return -1;
                        if (b.id_ClassRoomType == null)
                            return 1;
                        return a.id_ClassRoomType.localeCompare(b.id_ClassRoomType);
                    };
                case clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_TotalLessonQty:
                    return (a, b) => {
                        return a.totalLessonQty - b.totalLessonQty;
                    };
                case clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_MaxStuQty:
                    return (a, b) => {
                        return a.maxStuQty - b.maxStuQty;
                    };
                case clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_WeekQty:
                    return (a, b) => {
                        return a.weekQty - b.weekQty;
                    };
                case clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_ScheUnitPW:
                    return (a, b) => {
                        return a.scheUnitPW - b.scheUnitPW;
                    };
                case clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_WeekStatusID:
                    return (a, b) => {
                        if (a.weekStatusID == null)
                            return -1;
                        if (b.weekStatusID == null)
                            return 1;
                        return a.weekStatusID.localeCompare(b.weekStatusID);
                    };
                case clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_CustomerWeek:
                    return (a, b) => {
                        if (a.customerWeek == null)
                            return -1;
                        if (b.customerWeek == null)
                            return 1;
                        return a.customerWeek.localeCompare(b.customerWeek);
                    };
                case clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_LessonQtyPerWeek:
                    return (a, b) => {
                        return a.lessonQtyPerWeek - b.lessonQtyPerWeek;
                    };
                case clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_Mark:
                    return (a, b) => {
                        return a.mark - b.mark;
                    };
                case clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_id_UniZone:
                    return (a, b) => {
                        if (a.id_UniZone == null)
                            return -1;
                        if (b.id_UniZone == null)
                            return 1;
                        return a.id_UniZone.localeCompare(b.id_UniZone);
                    };
                case clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_id_GradeBase:
                    return (a, b) => {
                        if (a.id_GradeBase == null)
                            return -1;
                        if (b.id_GradeBase == null)
                            return 1;
                        return a.id_GradeBase.localeCompare(b.id_GradeBase);
                    };
                case clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_IsEffective:
                    return (a, b) => {
                        if (a.isEffective == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_IsForPaperReading:
                    return (a, b) => {
                        if (a.isForPaperReading == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_SchoolYear:
                    return (a, b) => {
                        if (a.schoolYear == null)
                            return -1;
                        if (b.schoolYear == null)
                            return 1;
                        return a.schoolYear.localeCompare(b.schoolYear);
                    };
                case clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_SchoolTerm:
                    return (a, b) => {
                        if (a.schoolTerm == null)
                            return -1;
                        if (b.schoolTerm == null)
                            return 1;
                        return a.schoolTerm.localeCompare(b.schoolTerm);
                    };
                case clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_id_CourseType:
                    return (a, b) => {
                        if (a.id_CourseType == null)
                            return -1;
                        if (b.id_CourseType == null)
                            return 1;
                        return a.id_CourseType.localeCompare(b.id_CourseType);
                    };
                case clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_IsDegree:
                    return (a, b) => {
                        if (a.isDegree == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_id_ScoreType:
                    return (a, b) => {
                        if (a.id_ScoreType == null)
                            return -1;
                        if (b.id_ScoreType == null)
                            return 1;
                        return a.id_ScoreType.localeCompare(b.id_ScoreType);
                    };
                case clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_GetScoreWayId:
                    return (a, b) => {
                        if (a.getScoreWayId == null)
                            return -1;
                        if (b.getScoreWayId == null)
                            return 1;
                        return a.getScoreWayId.localeCompare(b.getScoreWayId);
                    };
                case clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_IsProportionalCtrl:
                    return (a, b) => {
                        if (a.isProportionalCtrl == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_id_ExamType:
                    return (a, b) => {
                        if (a.id_ExamType == null)
                            return -1;
                        if (b.id_ExamType == null)
                            return 1;
                        return a.id_ExamType.localeCompare(b.id_ExamType);
                    };
                case clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_ExamTime:
                    return (a, b) => {
                        if (a.examTime == null)
                            return -1;
                        if (b.examTime == null)
                            return 1;
                        return a.examTime.localeCompare(b.examTime);
                    };
                case clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_BeginWeek:
                    return (a, b) => {
                        return a.beginWeek - b.beginWeek;
                    };
                case clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_ModifyDate:
                    return (a, b) => {
                        if (a.modifyDate == null)
                            return -1;
                        if (b.modifyDate == null)
                            return 1;
                        return a.modifyDate.localeCompare(b.modifyDate);
                    };
                case clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_ModifyUserID:
                    return (a, b) => {
                        if (a.modifyUserID == null)
                            return -1;
                        if (b.modifyUserID == null)
                            return 1;
                        return a.modifyUserID.localeCompare(b.modifyUserID);
                    };
                case clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[CurrEduCls]中不存在！(in ${exports.currEduCls_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_id_CurrEduCls:
                    return (a, b) => {
                        return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
                    };
                case clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_CurrEduClsId:
                    return (a, b) => {
                        return b.currEduClsId.localeCompare(a.currEduClsId);
                    };
                case clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_EduClsName:
                    return (a, b) => {
                        if (b.eduClsName == null)
                            return -1;
                        if (a.eduClsName == null)
                            return 1;
                        return b.eduClsName.localeCompare(a.eduClsName);
                    };
                case clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_EduClsTypeId:
                    return (a, b) => {
                        if (b.eduClsTypeId == null)
                            return -1;
                        if (a.eduClsTypeId == null)
                            return 1;
                        return b.eduClsTypeId.localeCompare(a.eduClsTypeId);
                    };
                case clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_CourseId:
                    return (a, b) => {
                        if (b.courseId == null)
                            return -1;
                        if (a.courseId == null)
                            return 1;
                        return b.courseId.localeCompare(a.courseId);
                    };
                case clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_TeachingSolutionId:
                    return (a, b) => {
                        if (b.teachingSolutionId == null)
                            return -1;
                        if (a.teachingSolutionId == null)
                            return 1;
                        return b.teachingSolutionId.localeCompare(a.teachingSolutionId);
                    };
                case clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_id_XzCollege:
                    return (a, b) => {
                        if (b.id_XzCollege == null)
                            return -1;
                        if (a.id_XzCollege == null)
                            return 1;
                        return b.id_XzCollege.localeCompare(a.id_XzCollege);
                    };
                case clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_id_XzMajor:
                    return (a, b) => {
                        return b.id_XzMajor.localeCompare(a.id_XzMajor);
                    };
                case clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_id_EduWay:
                    return (a, b) => {
                        if (b.id_EduWay == null)
                            return -1;
                        if (a.id_EduWay == null)
                            return 1;
                        return b.id_EduWay.localeCompare(a.id_EduWay);
                    };
                case clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_id_ClassRoomType:
                    return (a, b) => {
                        if (b.id_ClassRoomType == null)
                            return -1;
                        if (a.id_ClassRoomType == null)
                            return 1;
                        return b.id_ClassRoomType.localeCompare(a.id_ClassRoomType);
                    };
                case clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_TotalLessonQty:
                    return (a, b) => {
                        return b.totalLessonQty - a.totalLessonQty;
                    };
                case clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_MaxStuQty:
                    return (a, b) => {
                        return b.maxStuQty - a.maxStuQty;
                    };
                case clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_WeekQty:
                    return (a, b) => {
                        return b.weekQty - a.weekQty;
                    };
                case clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_ScheUnitPW:
                    return (a, b) => {
                        return b.scheUnitPW - a.scheUnitPW;
                    };
                case clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_WeekStatusID:
                    return (a, b) => {
                        if (b.weekStatusID == null)
                            return -1;
                        if (a.weekStatusID == null)
                            return 1;
                        return b.weekStatusID.localeCompare(a.weekStatusID);
                    };
                case clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_CustomerWeek:
                    return (a, b) => {
                        if (b.customerWeek == null)
                            return -1;
                        if (a.customerWeek == null)
                            return 1;
                        return b.customerWeek.localeCompare(a.customerWeek);
                    };
                case clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_LessonQtyPerWeek:
                    return (a, b) => {
                        return b.lessonQtyPerWeek - a.lessonQtyPerWeek;
                    };
                case clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_Mark:
                    return (a, b) => {
                        return b.mark - a.mark;
                    };
                case clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_id_UniZone:
                    return (a, b) => {
                        if (b.id_UniZone == null)
                            return -1;
                        if (a.id_UniZone == null)
                            return 1;
                        return b.id_UniZone.localeCompare(a.id_UniZone);
                    };
                case clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_id_GradeBase:
                    return (a, b) => {
                        if (b.id_GradeBase == null)
                            return -1;
                        if (a.id_GradeBase == null)
                            return 1;
                        return b.id_GradeBase.localeCompare(a.id_GradeBase);
                    };
                case clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_IsEffective:
                    return (a, b) => {
                        if (b.isEffective == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_IsForPaperReading:
                    return (a, b) => {
                        if (b.isForPaperReading == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_SchoolYear:
                    return (a, b) => {
                        if (b.schoolYear == null)
                            return -1;
                        if (a.schoolYear == null)
                            return 1;
                        return b.schoolYear.localeCompare(a.schoolYear);
                    };
                case clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_SchoolTerm:
                    return (a, b) => {
                        if (b.schoolTerm == null)
                            return -1;
                        if (a.schoolTerm == null)
                            return 1;
                        return b.schoolTerm.localeCompare(a.schoolTerm);
                    };
                case clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_id_CourseType:
                    return (a, b) => {
                        if (b.id_CourseType == null)
                            return -1;
                        if (a.id_CourseType == null)
                            return 1;
                        return b.id_CourseType.localeCompare(a.id_CourseType);
                    };
                case clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_IsDegree:
                    return (a, b) => {
                        if (b.isDegree == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_id_ScoreType:
                    return (a, b) => {
                        if (b.id_ScoreType == null)
                            return -1;
                        if (a.id_ScoreType == null)
                            return 1;
                        return b.id_ScoreType.localeCompare(a.id_ScoreType);
                    };
                case clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_GetScoreWayId:
                    return (a, b) => {
                        if (b.getScoreWayId == null)
                            return -1;
                        if (a.getScoreWayId == null)
                            return 1;
                        return b.getScoreWayId.localeCompare(a.getScoreWayId);
                    };
                case clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_IsProportionalCtrl:
                    return (a, b) => {
                        if (b.isProportionalCtrl == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_id_ExamType:
                    return (a, b) => {
                        if (b.id_ExamType == null)
                            return -1;
                        if (a.id_ExamType == null)
                            return 1;
                        return b.id_ExamType.localeCompare(a.id_ExamType);
                    };
                case clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_ExamTime:
                    return (a, b) => {
                        if (b.examTime == null)
                            return -1;
                        if (a.examTime == null)
                            return 1;
                        return b.examTime.localeCompare(a.examTime);
                    };
                case clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_BeginWeek:
                    return (a, b) => {
                        return b.beginWeek - a.beginWeek;
                    };
                case clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_ModifyDate:
                    return (a, b) => {
                        if (b.modifyDate == null)
                            return -1;
                        if (a.modifyDate == null)
                            return 1;
                        return b.modifyDate.localeCompare(a.modifyDate);
                    };
                case clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_ModifyUserID:
                    return (a, b) => {
                        if (b.modifyUserID == null)
                            return -1;
                        if (a.modifyUserID == null)
                            return 1;
                        return b.modifyUserID.localeCompare(a.modifyUserID);
                    };
                case clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[CurrEduCls]中不存在！(in ${exports.currEduCls_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.CurrEduCls_SortFunByKey = CurrEduCls_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function CurrEduCls_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_id_CurrEduCls:
                return (obj) => {
                    return obj.id_CurrEduCls === value;
                };
            case clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_CurrEduClsId:
                return (obj) => {
                    return obj.currEduClsId === value;
                };
            case clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_EduClsName:
                return (obj) => {
                    return obj.eduClsName === value;
                };
            case clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_EduClsTypeId:
                return (obj) => {
                    return obj.eduClsTypeId === value;
                };
            case clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_CourseId:
                return (obj) => {
                    return obj.courseId === value;
                };
            case clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_TeachingSolutionId:
                return (obj) => {
                    return obj.teachingSolutionId === value;
                };
            case clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_id_XzCollege:
                return (obj) => {
                    return obj.id_XzCollege === value;
                };
            case clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_id_XzMajor:
                return (obj) => {
                    return obj.id_XzMajor === value;
                };
            case clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_id_EduWay:
                return (obj) => {
                    return obj.id_EduWay === value;
                };
            case clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_id_ClassRoomType:
                return (obj) => {
                    return obj.id_ClassRoomType === value;
                };
            case clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_TotalLessonQty:
                return (obj) => {
                    return obj.totalLessonQty === value;
                };
            case clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_MaxStuQty:
                return (obj) => {
                    return obj.maxStuQty === value;
                };
            case clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_WeekQty:
                return (obj) => {
                    return obj.weekQty === value;
                };
            case clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_ScheUnitPW:
                return (obj) => {
                    return obj.scheUnitPW === value;
                };
            case clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_WeekStatusID:
                return (obj) => {
                    return obj.weekStatusID === value;
                };
            case clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_CustomerWeek:
                return (obj) => {
                    return obj.customerWeek === value;
                };
            case clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_LessonQtyPerWeek:
                return (obj) => {
                    return obj.lessonQtyPerWeek === value;
                };
            case clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_Mark:
                return (obj) => {
                    return obj.mark === value;
                };
            case clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_id_UniZone:
                return (obj) => {
                    return obj.id_UniZone === value;
                };
            case clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_id_GradeBase:
                return (obj) => {
                    return obj.id_GradeBase === value;
                };
            case clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_IsEffective:
                return (obj) => {
                    return obj.isEffective === value;
                };
            case clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_IsForPaperReading:
                return (obj) => {
                    return obj.isForPaperReading === value;
                };
            case clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_SchoolYear:
                return (obj) => {
                    return obj.schoolYear === value;
                };
            case clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_SchoolTerm:
                return (obj) => {
                    return obj.schoolTerm === value;
                };
            case clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_id_CourseType:
                return (obj) => {
                    return obj.id_CourseType === value;
                };
            case clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_IsDegree:
                return (obj) => {
                    return obj.isDegree === value;
                };
            case clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_id_ScoreType:
                return (obj) => {
                    return obj.id_ScoreType === value;
                };
            case clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_GetScoreWayId:
                return (obj) => {
                    return obj.getScoreWayId === value;
                };
            case clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_IsProportionalCtrl:
                return (obj) => {
                    return obj.isProportionalCtrl === value;
                };
            case clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_id_ExamType:
                return (obj) => {
                    return obj.id_ExamType === value;
                };
            case clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_ExamTime:
                return (obj) => {
                    return obj.examTime === value;
                };
            case clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_BeginWeek:
                return (obj) => {
                    return obj.beginWeek === value;
                };
            case clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_ModifyDate:
                return (obj) => {
                    return obj.modifyDate === value;
                };
            case clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_ModifyUserID:
                return (obj) => {
                    return obj.modifyUserID === value;
                };
            case clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[CurrEduCls]中不存在！(in ${exports.currEduCls_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.CurrEduCls_FilterFunByKey = CurrEduCls_FilterFunByKey;
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
    async function CurrEduCls_funcKey(strInFldName, strInValue, strComparisonOp, strCourseId_C) {
        //const strThisFuncName = "funcKey";
        if ((0, clsString_js_2.IsNullOrEmpty)(strCourseId_C) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strCourseId_C]不能为空！(In clsCurrEduClsWApi.funcKey)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strCourseId_C.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strCourseId_C]的长度:[{0}]不正确！(clsCurrEduClsWApi.funcKey)", strCourseId_C.length);
            console.error(strMsg);
            throw (strMsg);
        }
        if (strInFldName == clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_id_CurrEduCls) {
            const strMsg = (0, clsString_js_2.Format)("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(strInValue) == true) {
            return [];
        }
        const arrCurrEduCls = await CurrEduCls_GetObjLst_Cache(strCourseId_C);
        if (arrCurrEduCls == null)
            return [];
        let arrCurrEduCls_Sel = arrCurrEduCls;
        const strType = typeof (strInValue);
        switch (strType) {
            case "string":
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01: // " = "
                        arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.Like_03:
                        arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.In_04:
                        const arrValues = strInValue.split(',');
                        arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
                        break;
                }
                break;
            case "boolean":
                if (strInValue == null)
                    return [];
                if (strComparisonOp == enumComparisonOp_js_1.enumComparisonOp.Equal_01) {
                    arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                }
                break;
            case "number":
                if (Number(strInValue) == 0)
                    return [];
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01:
                        arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotEqual_02:
                        arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotLessThan_05: //" >= ":
                        arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotGreaterThan_06: //" <= ":
                        arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.GreaterThan_07: //" > ":
                        arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.LessThan_08: //" < ":
                        arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                }
                break;
        }
        if (arrCurrEduCls_Sel.length == 0)
            return [];
        return arrCurrEduCls_Sel.map(x => x.id_CurrEduCls);
    }
    exports.CurrEduCls_funcKey = CurrEduCls_funcKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function CurrEduCls_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.currEduCls_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.currEduCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.currEduCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CurrEduCls_GetFirstIDAsync = CurrEduCls_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function CurrEduCls_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.currEduCls_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.currEduCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.currEduCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CurrEduCls_GetFirstID = CurrEduCls_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function CurrEduCls_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.currEduCls_Controller, strAction);
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
                const objCurrEduCls = CurrEduCls_GetObjFromJsonObj(returnObj);
                return objCurrEduCls;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.currEduCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.currEduCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CurrEduCls_GetFirstObjAsync = CurrEduCls_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function CurrEduCls_GetObjLst_ClientCache(strCourseId) {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        if ((0, clsString_js_2.IsNullOrEmpty)(clsCurrEduClsEN_js_1.clsCurrEduClsEN.WhereFormat) == false) {
            strWhereCond = (0, clsString_js_2.Format)(clsCurrEduClsEN_js_1.clsCurrEduClsEN.WhereFormat, strCourseId);
        }
        else {
            strWhereCond = (0, clsString_js_2.Format)("CourseId='{0}'", strCourseId);
        }
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsCurrEduClsEN_js_1.clsCurrEduClsEN._CurrTabName, strCourseId);
        if ((0, clsString_js_2.IsNullOrEmpty)(clsCurrEduClsEN_js_1.clsCurrEduClsEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsCurrEduClsEN_js_1.clsCurrEduClsEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_1.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrCurrEduClsExObjLst_Cache = CacheHelper_js_1.CacheHelper.Get(strKey);
            const arrCurrEduClsObjLst_T = CurrEduCls_GetObjLstByJSONObjLst(arrCurrEduClsExObjLst_Cache);
            return arrCurrEduClsObjLst_T;
        }
        try {
            const arrCurrEduClsExObjLst = await CurrEduCls_GetObjLstAsync(strWhereCond);
            CacheHelper_js_1.CacheHelper.Add(strKey, arrCurrEduClsExObjLst);
            const strInfo = (0, clsString_js_2.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrCurrEduClsExObjLst.length);
            console.log(strInfo);
            return arrCurrEduClsExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.currEduCls_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.CurrEduCls_GetObjLst_ClientCache = CurrEduCls_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function CurrEduCls_GetObjLst_localStorage(strCourseId) {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        if ((0, clsString_js_2.IsNullOrEmpty)(clsCurrEduClsEN_js_1.clsCurrEduClsEN.WhereFormat) == false) {
            strWhereCond = (0, clsString_js_2.Format)(clsCurrEduClsEN_js_1.clsCurrEduClsEN.WhereFormat, strCourseId);
        }
        else {
            strWhereCond = (0, clsString_js_2.Format)("CourseId='{0}'", strCourseId);
        }
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsCurrEduClsEN_js_1.clsCurrEduClsEN._CurrTabName, strCourseId);
        if ((0, clsString_js_2.IsNullOrEmpty)(clsCurrEduClsEN_js_1.clsCurrEduClsEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsCurrEduClsEN_js_1.clsCurrEduClsEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrCurrEduClsExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrCurrEduClsObjLst_T = CurrEduCls_GetObjLstByJSONObjLst(arrCurrEduClsExObjLst_Cache);
            return arrCurrEduClsObjLst_T;
        }
        try {
            const arrCurrEduClsExObjLst = await CurrEduCls_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrCurrEduClsExObjLst));
            const strInfo = (0, clsString_js_2.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrCurrEduClsExObjLst.length);
            console.log(strInfo);
            return arrCurrEduClsExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.currEduCls_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.CurrEduCls_GetObjLst_localStorage = CurrEduCls_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function CurrEduCls_GetObjLst_localStorage_PureCache(strCourseId) {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_2.Format)("CourseId='{0}'", strCourseId);
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsCurrEduClsEN_js_1.clsCurrEduClsEN._CurrTabName, strCourseId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrCurrEduClsObjLst_Cache = JSON.parse(strTempObjLst);
            return arrCurrEduClsObjLst_Cache;
        }
        else
            return null;
    }
    exports.CurrEduCls_GetObjLst_localStorage_PureCache = CurrEduCls_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function CurrEduCls_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.currEduCls_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.currEduCls_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = CurrEduCls_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.currEduCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.currEduCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CurrEduCls_GetObjLstAsync = CurrEduCls_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function CurrEduCls_GetObjLst_sessionStorage(strCourseId) {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        if ((0, clsString_js_2.IsNullOrEmpty)(clsCurrEduClsEN_js_1.clsCurrEduClsEN.WhereFormat) == false) {
            strWhereCond = (0, clsString_js_2.Format)(clsCurrEduClsEN_js_1.clsCurrEduClsEN.WhereFormat, strCourseId);
        }
        else {
            strWhereCond = (0, clsString_js_2.Format)("CourseId='{0}'", strCourseId);
        }
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsCurrEduClsEN_js_1.clsCurrEduClsEN._CurrTabName, strCourseId);
        if ((0, clsString_js_2.IsNullOrEmpty)(clsCurrEduClsEN_js_1.clsCurrEduClsEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsCurrEduClsEN_js_1.clsCurrEduClsEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrCurrEduClsExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrCurrEduClsObjLst_T = CurrEduCls_GetObjLstByJSONObjLst(arrCurrEduClsExObjLst_Cache);
            return arrCurrEduClsObjLst_T;
        }
        try {
            const arrCurrEduClsExObjLst = await CurrEduCls_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrCurrEduClsExObjLst));
            const strInfo = (0, clsString_js_2.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrCurrEduClsExObjLst.length);
            console.log(strInfo);
            return arrCurrEduClsExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.currEduCls_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.CurrEduCls_GetObjLst_sessionStorage = CurrEduCls_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function CurrEduCls_GetObjLst_sessionStorage_PureCache(strCourseId) {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_2.Format)("CourseId='{0}'", strCourseId);
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsCurrEduClsEN_js_1.clsCurrEduClsEN._CurrTabName, strCourseId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrCurrEduClsObjLst_Cache = JSON.parse(strTempObjLst);
            return arrCurrEduClsObjLst_Cache;
        }
        else
            return null;
    }
    exports.CurrEduCls_GetObjLst_sessionStorage_PureCache = CurrEduCls_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function CurrEduCls_GetObjLst_Cache(strCourseId) {
        //const strThisFuncName = "GetObjLst_Cache";
        if ((0, clsString_js_2.IsNullOrEmpty)(strCourseId) == true) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[CourseId]不能为空！(in clsCurrEduClsWApi.CurrEduCls_GetObjLst_Cache() )");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strCourseId.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strCourseId]的长度:[{0}]不正确！(in clsCurrEduClsWApi.CurrEduCls_GetObjLst_Cache() )", strCourseId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        let arrCurrEduClsObjLst_Cache;
        switch (clsCurrEduClsEN_js_1.clsCurrEduClsEN.CacheModeId) {
            case "04": //sessionStorage
                arrCurrEduClsObjLst_Cache = await CurrEduCls_GetObjLst_sessionStorage(strCourseId);
                break;
            case "03": //localStorage
                arrCurrEduClsObjLst_Cache = await CurrEduCls_GetObjLst_localStorage(strCourseId);
                break;
            case "02": //ClientCache
                arrCurrEduClsObjLst_Cache = await CurrEduCls_GetObjLst_ClientCache(strCourseId);
                break;
            default:
                arrCurrEduClsObjLst_Cache = await CurrEduCls_GetObjLst_ClientCache(strCourseId);
                break;
        }
        const arrCurrEduClsObjLst = CurrEduCls_GetObjLstByJSONObjLst(arrCurrEduClsObjLst_Cache);
        return arrCurrEduClsObjLst_Cache;
    }
    exports.CurrEduCls_GetObjLst_Cache = CurrEduCls_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function CurrEduCls_GetObjLst_PureCache(strCourseId) {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrCurrEduClsObjLst_Cache;
        switch (clsCurrEduClsEN_js_1.clsCurrEduClsEN.CacheModeId) {
            case "04": //sessionStorage
                arrCurrEduClsObjLst_Cache = await CurrEduCls_GetObjLst_sessionStorage_PureCache(strCourseId);
                break;
            case "03": //localStorage
                arrCurrEduClsObjLst_Cache = await CurrEduCls_GetObjLst_localStorage_PureCache(strCourseId);
                break;
            case "02": //ClientCache
                arrCurrEduClsObjLst_Cache = null;
                break;
            default:
                arrCurrEduClsObjLst_Cache = null;
                break;
        }
        return arrCurrEduClsObjLst_Cache;
    }
    exports.CurrEduCls_GetObjLst_PureCache = CurrEduCls_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objstrid_CurrEduCls_Cond:条件对象
     * @returns 对象列表子集
    */
    async function CurrEduCls_GetSubObjLst_Cache(objCurrEduCls_Cond, strCourseId) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrCurrEduClsObjLst_Cache = await CurrEduCls_GetObjLst_Cache(strCourseId);
        let arrCurrEduCls_Sel = arrCurrEduClsObjLst_Cache;
        if (objCurrEduCls_Cond.sf_FldComparisonOp == null || objCurrEduCls_Cond.sf_FldComparisonOp == "")
            return arrCurrEduCls_Sel;
        const dicFldComparisonOp = JSON.parse(objCurrEduCls_Cond.sf_FldComparisonOp);
        //console.log("clsCurrEduClsWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objCurrEduCls_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objCurrEduCls_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrCurrEduCls_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objCurrEduCls_Cond), exports.currEduCls_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.CurrEduCls_GetSubObjLst_Cache = CurrEduCls_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrid_CurrEduCls:关键字列表
    * @returns 对象列表
    **/
    async function CurrEduCls_GetObjLstByid_CurrEduClsLstAsync(arrid_CurrEduCls) {
        const strThisFuncName = "GetObjLstByid_CurrEduClsLstAsync";
        const strAction = "GetObjLstByid_CurrEduClsLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.currEduCls_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrid_CurrEduCls);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.currEduCls_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = CurrEduCls_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.currEduCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.currEduCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CurrEduCls_GetObjLstByid_CurrEduClsLstAsync = CurrEduCls_GetObjLstByid_CurrEduClsLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrstrid_CurrEduClsLst:关键字列表
     * @returns 对象列表
    */
    async function CurrEduCls_GetObjLstByid_CurrEduClsLst_Cache(arrid_CurrEduClsLst, strCourseId) {
        const strThisFuncName = "GetObjLstByid_CurrEduClsLst_Cache";
        try {
            const arrCurrEduClsObjLst_Cache = await CurrEduCls_GetObjLst_Cache(strCourseId);
            const arrCurrEduCls_Sel = arrCurrEduClsObjLst_Cache.filter(x => arrid_CurrEduClsLst.indexOf(x.id_CurrEduCls) > -1);
            return arrCurrEduCls_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrid_CurrEduClsLst.join(","), exports.currEduCls_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
    }
    exports.CurrEduCls_GetObjLstByid_CurrEduClsLst_Cache = CurrEduCls_GetObjLstByid_CurrEduClsLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function CurrEduCls_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.currEduCls_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.currEduCls_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = CurrEduCls_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.currEduCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.currEduCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CurrEduCls_GetTopObjLstAsync = CurrEduCls_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function CurrEduCls_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.currEduCls_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.currEduCls_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = CurrEduCls_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.currEduCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.currEduCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CurrEduCls_GetObjLstByRangeAsync = CurrEduCls_GetObjLstByRangeAsync;
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
    async function CurrEduCls_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.currEduCls_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.currEduCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.currEduCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CurrEduCls_GetObjLstByRange = CurrEduCls_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function CurrEduCls_GetObjLstByPager_Cache(objPagerPara, strCourseId) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const arrCurrEduClsObjLst_Cache = await CurrEduCls_GetObjLst_Cache(strCourseId);
        if (arrCurrEduClsObjLst_Cache.length == 0)
            return arrCurrEduClsObjLst_Cache;
        let arrCurrEduCls_Sel = arrCurrEduClsObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objCurrEduCls_Cond = new clsCurrEduClsEN_js_1.clsCurrEduClsEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objCurrEduCls_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsCurrEduClsWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objCurrEduCls_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrCurrEduCls_Sel.length == 0)
                return arrCurrEduCls_Sel;
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
                arrCurrEduCls_Sel = arrCurrEduCls_Sel.sort(CurrEduCls_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrCurrEduCls_Sel = arrCurrEduCls_Sel.sort(objPagerPara.sortFun);
            }
            arrCurrEduCls_Sel = arrCurrEduCls_Sel.slice(intStart, intEnd);
            return arrCurrEduCls_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.currEduCls_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.CurrEduCls_GetObjLstByPager_Cache = CurrEduCls_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function CurrEduCls_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.currEduCls_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.currEduCls_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = CurrEduCls_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.currEduCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.currEduCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CurrEduCls_GetObjLstByPagerAsync = CurrEduCls_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param strid_CurrEduCls:关键字
    * @returns 获取删除的结果
    **/
    async function CurrEduCls_DelRecordAsync(strid_CurrEduCls) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.currEduCls_Controller, strAction);
        strUrl = (0, clsString_js_2.Format)("{0}/?Id={1}", strUrl, strid_CurrEduCls);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.currEduCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.currEduCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CurrEduCls_DelRecordAsync = CurrEduCls_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrid_CurrEduCls:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function CurrEduCls_DelCurrEduClssAsync(arrid_CurrEduCls) {
        const strThisFuncName = "DelCurrEduClssAsync";
        const strAction = "DelCurrEduClss";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.currEduCls_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrid_CurrEduCls);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.currEduCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.currEduCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CurrEduCls_DelCurrEduClssAsync = CurrEduCls_DelCurrEduClssAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function CurrEduCls_DelCurrEduClssByCondAsync(strWhereCond) {
        const strThisFuncName = "DelCurrEduClssByCondAsync";
        const strAction = "DelCurrEduClssByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.currEduCls_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.currEduCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.currEduCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CurrEduCls_DelCurrEduClssByCondAsync = CurrEduCls_DelCurrEduClssByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objCurrEduClsEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function CurrEduCls_AddNewRecordAsync(objCurrEduClsEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objCurrEduClsEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.currEduCls_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objCurrEduClsEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.currEduCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.currEduCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CurrEduCls_AddNewRecordAsync = CurrEduCls_AddNewRecordAsync;
    /**
    * 调用WebApi来添加记录，关键字用最大关键字，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithMaxIdAsync)
    * @param objCurrEduClsEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function CurrEduCls_AddNewRecordWithMaxIdAsync(objCurrEduClsEN) {
        const strThisFuncName = "AddNewRecordWithMaxIdAsync";
        const strAction = "AddNewRecordWithMaxId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.currEduCls_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objCurrEduClsEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.currEduCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.currEduCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CurrEduCls_AddNewRecordWithMaxIdAsync = CurrEduCls_AddNewRecordWithMaxIdAsync;
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objCurrEduClsEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function CurrEduCls_AddNewRecordWithReturnKeyAsync(objCurrEduClsEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.currEduCls_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objCurrEduClsEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.currEduCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.currEduCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CurrEduCls_AddNewRecordWithReturnKeyAsync = CurrEduCls_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objCurrEduClsEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function CurrEduCls_AddNewRecordWithReturnKey(objCurrEduClsEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objCurrEduClsEN.id_CurrEduCls === null || objCurrEduClsEN.id_CurrEduCls === "") {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.currEduCls_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objCurrEduClsEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.currEduCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.currEduCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CurrEduCls_AddNewRecordWithReturnKey = CurrEduCls_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objCurrEduClsEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function CurrEduCls_UpdateRecordAsync(objCurrEduClsEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objCurrEduClsEN.sf_UpdFldSetStr === undefined || objCurrEduClsEN.sf_UpdFldSetStr === null || objCurrEduClsEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objCurrEduClsEN.id_CurrEduCls);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.currEduCls_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objCurrEduClsEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.currEduCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.currEduCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CurrEduCls_UpdateRecordAsync = CurrEduCls_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objCurrEduClsEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function CurrEduCls_UpdateWithConditionAsync(objCurrEduClsEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objCurrEduClsEN.sf_UpdFldSetStr === undefined || objCurrEduClsEN.sf_UpdFldSetStr === null || objCurrEduClsEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objCurrEduClsEN.id_CurrEduCls);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.currEduCls_Controller, strAction);
        objCurrEduClsEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objCurrEduClsEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.currEduCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.currEduCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CurrEduCls_UpdateWithConditionAsync = CurrEduCls_UpdateWithConditionAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objstrid_CurrEduCls_Cond:条件对象
     * @returns 对象列表子集
    */
    async function CurrEduCls_IsExistRecord_Cache(objCurrEduCls_Cond, strCourseId) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrCurrEduClsObjLst_Cache = await CurrEduCls_GetObjLst_Cache(strCourseId);
        if (arrCurrEduClsObjLst_Cache == null)
            return false;
        let arrCurrEduCls_Sel = arrCurrEduClsObjLst_Cache;
        if (objCurrEduCls_Cond.sf_FldComparisonOp == null || objCurrEduCls_Cond.sf_FldComparisonOp == "")
            return arrCurrEduCls_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objCurrEduCls_Cond.sf_FldComparisonOp);
        //console.log("clsCurrEduClsWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objCurrEduCls_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objCurrEduCls_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrCurrEduCls_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objCurrEduCls_Cond), exports.currEduCls_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.CurrEduCls_IsExistRecord_Cache = CurrEduCls_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function CurrEduCls_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.currEduCls_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.currEduCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.currEduCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CurrEduCls_IsExistRecordAsync = CurrEduCls_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strid_CurrEduCls:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function CurrEduCls_IsExist(strid_CurrEduCls, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.currEduCls_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.currEduCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.currEduCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CurrEduCls_IsExist = CurrEduCls_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param strid_CurrEduCls:所给的关键字
     * @returns 对象
    */
    async function CurrEduCls_IsExist_Cache(strid_CurrEduCls, strCourseId) {
        const strThisFuncName = "IsExist_Cache";
        const arrCurrEduClsObjLst_Cache = await CurrEduCls_GetObjLst_Cache(strCourseId);
        if (arrCurrEduClsObjLst_Cache == null)
            return false;
        try {
            const arrCurrEduCls_Sel = arrCurrEduClsObjLst_Cache.filter(x => x.id_CurrEduCls == strid_CurrEduCls);
            if (arrCurrEduCls_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strid_CurrEduCls, exports.currEduCls_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.CurrEduCls_IsExist_Cache = CurrEduCls_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strid_CurrEduCls:关键字
    * @returns 是否存在?存在返回True
    **/
    async function CurrEduCls_IsExistAsync(strid_CurrEduCls) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.currEduCls_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.currEduCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.currEduCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CurrEduCls_IsExistAsync = CurrEduCls_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function CurrEduCls_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.currEduCls_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.currEduCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.currEduCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CurrEduCls_GetRecCountByCondAsync = CurrEduCls_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objCurrEduCls_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function CurrEduCls_GetRecCountByCond_Cache(objCurrEduCls_Cond, strCourseId) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrCurrEduClsObjLst_Cache = await CurrEduCls_GetObjLst_Cache(strCourseId);
        if (arrCurrEduClsObjLst_Cache == null)
            return 0;
        let arrCurrEduCls_Sel = arrCurrEduClsObjLst_Cache;
        if (objCurrEduCls_Cond.sf_FldComparisonOp == null || objCurrEduCls_Cond.sf_FldComparisonOp == "")
            return arrCurrEduCls_Sel.length;
        const dicFldComparisonOp = JSON.parse(objCurrEduCls_Cond.sf_FldComparisonOp);
        //console.log("clsCurrEduClsWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objCurrEduCls_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objCurrEduCls_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrCurrEduCls_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objCurrEduCls_Cond), exports.currEduCls_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.CurrEduCls_GetRecCountByCond_Cache = CurrEduCls_GetRecCountByCond_Cache;
    /**
    * 获取表的最大关键字
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdAsync)
    * @returns 获取表的最大关键字
    **/
    async function CurrEduCls_GetMaxStrIdAsync() {
        const strThisFuncName = "GetMaxStrIdAsync";
        const strAction = "GetMaxStrId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.currEduCls_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.currEduCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.currEduCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CurrEduCls_GetMaxStrIdAsync = CurrEduCls_GetMaxStrIdAsync;
    /*该表的关键字类型不是字符型带前缀自增，不需要生成获取最大关键字函数！*/
    /**
     * 根据前缀获取当前表关键字值的最大值,再加1,避免重复
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdByPrefix)
     * @param mapParam:参数列表
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 获取当前表关键字值的最大值
    */
    async function CurrEduCls_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.currEduCls_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.currEduCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.currEduCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CurrEduCls_GetMaxStrIdByPrefix = CurrEduCls_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function CurrEduCls_GetWebApiUrl(strController, strAction) {
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
    exports.CurrEduCls_GetWebApiUrl = CurrEduCls_GetWebApiUrl;
    /**
    * 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshCache)
    **/
    function CurrEduCls_ReFreshCache(strCourseId) {
        const strThisFuncName = "ReFreshCache";
        if ((0, clsString_js_2.IsNullOrEmpty)(strCourseId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strCourseId]不能为空！(In clsCurrEduClsWApi.clsCurrEduClsWApi.ReFreshCache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strCourseId.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strCourseId]的长度:[{0}]不正确！(clsCurrEduClsWApi.clsCurrEduClsWApi.ReFreshCache)", strCourseId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strMsg = (0, clsString_js_2.Format)("刷新缓存成功！");
        console.trace(strMsg);
        // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsCurrEduClsEN_js_1.clsCurrEduClsEN._CurrTabName, strCourseId);
        switch (clsCurrEduClsEN_js_1.clsCurrEduClsEN.CacheModeId) {
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
    exports.CurrEduCls_ReFreshCache = CurrEduCls_ReFreshCache;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function CurrEduCls_ReFreshThisCache(strCourseId) {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsCurrEduClsEN_js_1.clsCurrEduClsEN._CurrTabName, strCourseId);
            switch (clsCurrEduClsEN_js_1.clsCurrEduClsEN.CacheModeId) {
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
    exports.CurrEduCls_ReFreshThisCache = CurrEduCls_ReFreshThisCache;
    /**
     * 绑定基于Web的下拉框,在某一层下的下拉框
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunctionInDiv)
     * @param objDDL:需要绑定当前表的下拉框
     * @param strCourseId:课程Id
    */
    async function CurrEduCls_BindDdl_id_CurrEduClsInDiv_Cache(strDivName, strDdlName, strCourseId) {
        const strThisFuncName = "BindDdl_id_CurrEduClsInDiv_Cache";
        if ((0, clsString_js_2.IsNullOrEmpty)(strCourseId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strCourseId]不能为空！(In clsCurrEduClsWApi.BindDdl_id_CurrEduClsInDiv)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strCourseId.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strCourseId]的长度:[{0}]不正确！(clsCurrEduClsWApi.BindDdl_id_CurrEduClsInDiv)", strCourseId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const objDdl = document.getElementById(strDdlName);
        if (objDdl == null) {
            const strMsg = (0, clsString_js_2.Format)("下拉框：{0} 不存在！(In BindDdl_id_CurrEduClsInDiv)", strDdlName);
            alert(strMsg);
            console.error(strMsg);
            throw (strMsg);
        }
        //为数据源于表的下拉框设置内容
        //console.log("开始：BindDdl_id_CurrEduClsInDiv_Cache");
        let arrObjLst_Sel = await CurrEduCls_GetObjLst_Cache(strCourseId);
        if (arrObjLst_Sel == null)
            return;
        (0, clsCommFunc4Web_js_1.BindDdl_ObjLstInDiv)(strDivName, strDdlName, arrObjLst_Sel, clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_id_CurrEduCls, clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_EduClsName, "当前教学班");
    }
    exports.CurrEduCls_BindDdl_id_CurrEduClsInDiv_Cache = CurrEduCls_BindDdl_id_CurrEduClsInDiv_Cache;
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function CurrEduCls_CheckPropertyNew(pobjCurrEduClsEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCurrEduClsEN.currEduClsId) === true) {
            throw new Error("(errid:Watl000058)字段[教学班Id]不能为空(In 当前教学班)!(clsCurrEduClsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCurrEduClsEN.id_XzMajor) === true
            || pobjCurrEduClsEN.id_XzMajor.toString() === "0") {
            throw new Error("(errid:Watl000058)字段[专业流水号]不能为空(In 当前教学班)!(clsCurrEduClsBL:CheckPropertyNew)");
        }
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCurrEduClsEN.id_CurrEduCls) == false && (0, clsString_js_2.GetStrLen)(pobjCurrEduClsEN.id_CurrEduCls) > 8) {
            throw new Error("(errid:Watl000059)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 当前教学班(CurrEduCls))!值:$(pobjCurrEduClsEN.id_CurrEduCls)(clsCurrEduClsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCurrEduClsEN.currEduClsId) == false && (0, clsString_js_2.GetStrLen)(pobjCurrEduClsEN.currEduClsId) > 15) {
            throw new Error("(errid:Watl000059)字段[教学班Id(currEduClsId)]的长度不能超过15(In 当前教学班(CurrEduCls))!值:$(pobjCurrEduClsEN.currEduClsId)(clsCurrEduClsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCurrEduClsEN.eduClsName) == false && (0, clsString_js_2.GetStrLen)(pobjCurrEduClsEN.eduClsName) > 100) {
            throw new Error("(errid:Watl000059)字段[教学班名(eduClsName)]的长度不能超过100(In 当前教学班(CurrEduCls))!值:$(pobjCurrEduClsEN.eduClsName)(clsCurrEduClsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCurrEduClsEN.eduClsTypeId) == false && (0, clsString_js_2.GetStrLen)(pobjCurrEduClsEN.eduClsTypeId) > 4) {
            throw new Error("(errid:Watl000059)字段[教学班类型Id(eduClsTypeId)]的长度不能超过4(In 当前教学班(CurrEduCls))!值:$(pobjCurrEduClsEN.eduClsTypeId)(clsCurrEduClsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCurrEduClsEN.courseId) == false && (0, clsString_js_2.GetStrLen)(pobjCurrEduClsEN.courseId) > 8) {
            throw new Error("(errid:Watl000059)字段[课程Id(courseId)]的长度不能超过8(In 当前教学班(CurrEduCls))!值:$(pobjCurrEduClsEN.courseId)(clsCurrEduClsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCurrEduClsEN.teachingSolutionId) == false && (0, clsString_js_2.GetStrLen)(pobjCurrEduClsEN.teachingSolutionId) > 8) {
            throw new Error("(errid:Watl000059)字段[教学方案Id(teachingSolutionId)]的长度不能超过8(In 当前教学班(CurrEduCls))!值:$(pobjCurrEduClsEN.teachingSolutionId)(clsCurrEduClsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCurrEduClsEN.id_XzCollege) == false && (0, clsString_js_2.GetStrLen)(pobjCurrEduClsEN.id_XzCollege) > 4) {
            throw new Error("(errid:Watl000059)字段[学院流水号(id_XzCollege)]的长度不能超过4(In 当前教学班(CurrEduCls))!值:$(pobjCurrEduClsEN.id_XzCollege)(clsCurrEduClsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCurrEduClsEN.id_XzMajor) == false && (0, clsString_js_2.GetStrLen)(pobjCurrEduClsEN.id_XzMajor) > 8) {
            throw new Error("(errid:Watl000059)字段[专业流水号(id_XzMajor)]的长度不能超过8(In 当前教学班(CurrEduCls))!值:$(pobjCurrEduClsEN.id_XzMajor)(clsCurrEduClsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCurrEduClsEN.id_EduWay) == false && (0, clsString_js_2.GetStrLen)(pobjCurrEduClsEN.id_EduWay) > 4) {
            throw new Error("(errid:Watl000059)字段[教学方式流水号(id_EduWay)]的长度不能超过4(In 当前教学班(CurrEduCls))!值:$(pobjCurrEduClsEN.id_EduWay)(clsCurrEduClsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCurrEduClsEN.id_ClassRoomType) == false && (0, clsString_js_2.GetStrLen)(pobjCurrEduClsEN.id_ClassRoomType) > 4) {
            throw new Error("(errid:Watl000059)字段[教室类型流水号(id_ClassRoomType)]的长度不能超过4(In 当前教学班(CurrEduCls))!值:$(pobjCurrEduClsEN.id_ClassRoomType)(clsCurrEduClsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCurrEduClsEN.weekStatusID) == false && (0, clsString_js_2.GetStrLen)(pobjCurrEduClsEN.weekStatusID) > 2) {
            throw new Error("(errid:Watl000059)字段[周状态编号(单,双,全周)(weekStatusID)]的长度不能超过2(In 当前教学班(CurrEduCls))!值:$(pobjCurrEduClsEN.weekStatusID)(clsCurrEduClsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCurrEduClsEN.customerWeek) == false && (0, clsString_js_2.GetStrLen)(pobjCurrEduClsEN.customerWeek) > 50) {
            throw new Error("(errid:Watl000059)字段[自定义上课周(customerWeek)]的长度不能超过50(In 当前教学班(CurrEduCls))!值:$(pobjCurrEduClsEN.customerWeek)(clsCurrEduClsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCurrEduClsEN.id_UniZone) == false && (0, clsString_js_2.GetStrLen)(pobjCurrEduClsEN.id_UniZone) > 4) {
            throw new Error("(errid:Watl000059)字段[校区流水号(id_UniZone)]的长度不能超过4(In 当前教学班(CurrEduCls))!值:$(pobjCurrEduClsEN.id_UniZone)(clsCurrEduClsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCurrEduClsEN.id_GradeBase) == false && (0, clsString_js_2.GetStrLen)(pobjCurrEduClsEN.id_GradeBase) > 4) {
            throw new Error("(errid:Watl000059)字段[年级流水号(id_GradeBase)]的长度不能超过4(In 当前教学班(CurrEduCls))!值:$(pobjCurrEduClsEN.id_GradeBase)(clsCurrEduClsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCurrEduClsEN.schoolYear) == false && (0, clsString_js_2.GetStrLen)(pobjCurrEduClsEN.schoolYear) > 10) {
            throw new Error("(errid:Watl000059)字段[学年(schoolYear)]的长度不能超过10(In 当前教学班(CurrEduCls))!值:$(pobjCurrEduClsEN.schoolYear)(clsCurrEduClsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCurrEduClsEN.schoolTerm) == false && (0, clsString_js_2.GetStrLen)(pobjCurrEduClsEN.schoolTerm) > 1) {
            throw new Error("(errid:Watl000059)字段[学期(schoolTerm)]的长度不能超过1(In 当前教学班(CurrEduCls))!值:$(pobjCurrEduClsEN.schoolTerm)(clsCurrEduClsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCurrEduClsEN.id_CourseType) == false && (0, clsString_js_2.GetStrLen)(pobjCurrEduClsEN.id_CourseType) > 4) {
            throw new Error("(errid:Watl000059)字段[课程类型流水号(id_CourseType)]的长度不能超过4(In 当前教学班(CurrEduCls))!值:$(pobjCurrEduClsEN.id_CourseType)(clsCurrEduClsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCurrEduClsEN.id_ScoreType) == false && (0, clsString_js_2.GetStrLen)(pobjCurrEduClsEN.id_ScoreType) > 4) {
            throw new Error("(errid:Watl000059)字段[成绩类型流水号(id_ScoreType)]的长度不能超过4(In 当前教学班(CurrEduCls))!值:$(pobjCurrEduClsEN.id_ScoreType)(clsCurrEduClsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCurrEduClsEN.getScoreWayId) == false && (0, clsString_js_2.GetStrLen)(pobjCurrEduClsEN.getScoreWayId) > 2) {
            throw new Error("(errid:Watl000059)字段[获得成绩方式Id(getScoreWayId)]的长度不能超过2(In 当前教学班(CurrEduCls))!值:$(pobjCurrEduClsEN.getScoreWayId)(clsCurrEduClsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCurrEduClsEN.id_ExamType) == false && (0, clsString_js_2.GetStrLen)(pobjCurrEduClsEN.id_ExamType) > 4) {
            throw new Error("(errid:Watl000059)字段[考试方式流水号(id_ExamType)]的长度不能超过4(In 当前教学班(CurrEduCls))!值:$(pobjCurrEduClsEN.id_ExamType)(clsCurrEduClsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCurrEduClsEN.examTime) == false && (0, clsString_js_2.GetStrLen)(pobjCurrEduClsEN.examTime) > 8) {
            throw new Error("(errid:Watl000059)字段[考试时间(examTime)]的长度不能超过8(In 当前教学班(CurrEduCls))!值:$(pobjCurrEduClsEN.examTime)(clsCurrEduClsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCurrEduClsEN.modifyDate) == false && (0, clsString_js_2.GetStrLen)(pobjCurrEduClsEN.modifyDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(modifyDate)]的长度不能超过20(In 当前教学班(CurrEduCls))!值:$(pobjCurrEduClsEN.modifyDate)(clsCurrEduClsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCurrEduClsEN.modifyUserID) == false && (0, clsString_js_2.GetStrLen)(pobjCurrEduClsEN.modifyUserID) > 18) {
            throw new Error("(errid:Watl000059)字段[修改人(modifyUserID)]的长度不能超过18(In 当前教学班(CurrEduCls))!值:$(pobjCurrEduClsEN.modifyUserID)(clsCurrEduClsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCurrEduClsEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjCurrEduClsEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 当前教学班(CurrEduCls))!值:$(pobjCurrEduClsEN.memo)(clsCurrEduClsBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCurrEduClsEN.id_CurrEduCls) == false && undefined !== pobjCurrEduClsEN.id_CurrEduCls && clsString_js_1.tzDataType.isString(pobjCurrEduClsEN.id_CurrEduCls) === false) {
            throw new Error("(errid:Watl000060)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjCurrEduClsEN.id_CurrEduCls)], 非法，应该为字符型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCurrEduClsEN.currEduClsId) == false && undefined !== pobjCurrEduClsEN.currEduClsId && clsString_js_1.tzDataType.isString(pobjCurrEduClsEN.currEduClsId) === false) {
            throw new Error("(errid:Watl000060)字段[教学班Id(currEduClsId)]的值:[$(pobjCurrEduClsEN.currEduClsId)], 非法，应该为字符型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCurrEduClsEN.eduClsName) == false && undefined !== pobjCurrEduClsEN.eduClsName && clsString_js_1.tzDataType.isString(pobjCurrEduClsEN.eduClsName) === false) {
            throw new Error("(errid:Watl000060)字段[教学班名(eduClsName)]的值:[$(pobjCurrEduClsEN.eduClsName)], 非法，应该为字符型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCurrEduClsEN.eduClsTypeId) == false && undefined !== pobjCurrEduClsEN.eduClsTypeId && clsString_js_1.tzDataType.isString(pobjCurrEduClsEN.eduClsTypeId) === false) {
            throw new Error("(errid:Watl000060)字段[教学班类型Id(eduClsTypeId)]的值:[$(pobjCurrEduClsEN.eduClsTypeId)], 非法，应该为字符型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCurrEduClsEN.courseId) == false && undefined !== pobjCurrEduClsEN.courseId && clsString_js_1.tzDataType.isString(pobjCurrEduClsEN.courseId) === false) {
            throw new Error("(errid:Watl000060)字段[课程Id(courseId)]的值:[$(pobjCurrEduClsEN.courseId)], 非法，应该为字符型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCurrEduClsEN.teachingSolutionId) == false && undefined !== pobjCurrEduClsEN.teachingSolutionId && clsString_js_1.tzDataType.isString(pobjCurrEduClsEN.teachingSolutionId) === false) {
            throw new Error("(errid:Watl000060)字段[教学方案Id(teachingSolutionId)]的值:[$(pobjCurrEduClsEN.teachingSolutionId)], 非法，应该为字符型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCurrEduClsEN.id_XzCollege) == false && undefined !== pobjCurrEduClsEN.id_XzCollege && clsString_js_1.tzDataType.isString(pobjCurrEduClsEN.id_XzCollege) === false) {
            throw new Error("(errid:Watl000060)字段[学院流水号(id_XzCollege)]的值:[$(pobjCurrEduClsEN.id_XzCollege)], 非法，应该为字符型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCurrEduClsEN.id_XzMajor) == false && undefined !== pobjCurrEduClsEN.id_XzMajor && clsString_js_1.tzDataType.isString(pobjCurrEduClsEN.id_XzMajor) === false) {
            throw new Error("(errid:Watl000060)字段[专业流水号(id_XzMajor)]的值:[$(pobjCurrEduClsEN.id_XzMajor)], 非法，应该为字符型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCurrEduClsEN.id_EduWay) == false && undefined !== pobjCurrEduClsEN.id_EduWay && clsString_js_1.tzDataType.isString(pobjCurrEduClsEN.id_EduWay) === false) {
            throw new Error("(errid:Watl000060)字段[教学方式流水号(id_EduWay)]的值:[$(pobjCurrEduClsEN.id_EduWay)], 非法，应该为字符型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCurrEduClsEN.id_ClassRoomType) == false && undefined !== pobjCurrEduClsEN.id_ClassRoomType && clsString_js_1.tzDataType.isString(pobjCurrEduClsEN.id_ClassRoomType) === false) {
            throw new Error("(errid:Watl000060)字段[教室类型流水号(id_ClassRoomType)]的值:[$(pobjCurrEduClsEN.id_ClassRoomType)], 非法，应该为字符型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckPropertyNew)");
        }
        if (null != pobjCurrEduClsEN.totalLessonQty && undefined !== pobjCurrEduClsEN.totalLessonQty && clsString_js_1.tzDataType.isNumber(pobjCurrEduClsEN.totalLessonQty) === false) {
            throw new Error("(errid:Watl000060)字段[总课时数(totalLessonQty)]的值:[$(pobjCurrEduClsEN.totalLessonQty)], 非法，应该为数值型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckPropertyNew)");
        }
        if (null != pobjCurrEduClsEN.maxStuQty && undefined !== pobjCurrEduClsEN.maxStuQty && clsString_js_1.tzDataType.isNumber(pobjCurrEduClsEN.maxStuQty) === false) {
            throw new Error("(errid:Watl000060)字段[最大学生数(maxStuQty)]的值:[$(pobjCurrEduClsEN.maxStuQty)], 非法，应该为数值型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckPropertyNew)");
        }
        if (null != pobjCurrEduClsEN.weekQty && undefined !== pobjCurrEduClsEN.weekQty && clsString_js_1.tzDataType.isNumber(pobjCurrEduClsEN.weekQty) === false) {
            throw new Error("(errid:Watl000060)字段[总周数(weekQty)]的值:[$(pobjCurrEduClsEN.weekQty)], 非法，应该为数值型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckPropertyNew)");
        }
        if (null != pobjCurrEduClsEN.scheUnitPW && undefined !== pobjCurrEduClsEN.scheUnitPW && clsString_js_1.tzDataType.isNumber(pobjCurrEduClsEN.scheUnitPW) === false) {
            throw new Error("(errid:Watl000060)字段[周排课次数(scheUnitPW)]的值:[$(pobjCurrEduClsEN.scheUnitPW)], 非法，应该为数值型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCurrEduClsEN.weekStatusID) == false && undefined !== pobjCurrEduClsEN.weekStatusID && clsString_js_1.tzDataType.isString(pobjCurrEduClsEN.weekStatusID) === false) {
            throw new Error("(errid:Watl000060)字段[周状态编号(单,双,全周)(weekStatusID)]的值:[$(pobjCurrEduClsEN.weekStatusID)], 非法，应该为字符型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCurrEduClsEN.customerWeek) == false && undefined !== pobjCurrEduClsEN.customerWeek && clsString_js_1.tzDataType.isString(pobjCurrEduClsEN.customerWeek) === false) {
            throw new Error("(errid:Watl000060)字段[自定义上课周(customerWeek)]的值:[$(pobjCurrEduClsEN.customerWeek)], 非法，应该为字符型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckPropertyNew)");
        }
        if (null != pobjCurrEduClsEN.lessonQtyPerWeek && undefined !== pobjCurrEduClsEN.lessonQtyPerWeek && clsString_js_1.tzDataType.isNumber(pobjCurrEduClsEN.lessonQtyPerWeek) === false) {
            throw new Error("(errid:Watl000060)字段[周课时数(lessonQtyPerWeek)]的值:[$(pobjCurrEduClsEN.lessonQtyPerWeek)], 非法，应该为数值型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckPropertyNew)");
        }
        if (null != pobjCurrEduClsEN.mark && undefined !== pobjCurrEduClsEN.mark && clsString_js_1.tzDataType.isNumber(pobjCurrEduClsEN.mark) === false) {
            throw new Error("(errid:Watl000060)字段[获得学分(mark)]的值:[$(pobjCurrEduClsEN.mark)], 非法，应该为数值型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCurrEduClsEN.id_UniZone) == false && undefined !== pobjCurrEduClsEN.id_UniZone && clsString_js_1.tzDataType.isString(pobjCurrEduClsEN.id_UniZone) === false) {
            throw new Error("(errid:Watl000060)字段[校区流水号(id_UniZone)]的值:[$(pobjCurrEduClsEN.id_UniZone)], 非法，应该为字符型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCurrEduClsEN.id_GradeBase) == false && undefined !== pobjCurrEduClsEN.id_GradeBase && clsString_js_1.tzDataType.isString(pobjCurrEduClsEN.id_GradeBase) === false) {
            throw new Error("(errid:Watl000060)字段[年级流水号(id_GradeBase)]的值:[$(pobjCurrEduClsEN.id_GradeBase)], 非法，应该为字符型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckPropertyNew)");
        }
        if (null != pobjCurrEduClsEN.isEffective && undefined !== pobjCurrEduClsEN.isEffective && clsString_js_1.tzDataType.isBoolean(pobjCurrEduClsEN.isEffective) === false) {
            throw new Error("(errid:Watl000060)字段[是否有效(isEffective)]的值:[$(pobjCurrEduClsEN.isEffective)], 非法，应该为布尔型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckPropertyNew)");
        }
        if (null != pobjCurrEduClsEN.isForPaperReading && undefined !== pobjCurrEduClsEN.isForPaperReading && clsString_js_1.tzDataType.isBoolean(pobjCurrEduClsEN.isForPaperReading) === false) {
            throw new Error("(errid:Watl000060)字段[是否参与论文阅读(isForPaperReading)]的值:[$(pobjCurrEduClsEN.isForPaperReading)], 非法，应该为布尔型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCurrEduClsEN.schoolYear) == false && undefined !== pobjCurrEduClsEN.schoolYear && clsString_js_1.tzDataType.isString(pobjCurrEduClsEN.schoolYear) === false) {
            throw new Error("(errid:Watl000060)字段[学年(schoolYear)]的值:[$(pobjCurrEduClsEN.schoolYear)], 非法，应该为字符型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCurrEduClsEN.schoolTerm) == false && undefined !== pobjCurrEduClsEN.schoolTerm && clsString_js_1.tzDataType.isString(pobjCurrEduClsEN.schoolTerm) === false) {
            throw new Error("(errid:Watl000060)字段[学期(schoolTerm)]的值:[$(pobjCurrEduClsEN.schoolTerm)], 非法，应该为字符型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCurrEduClsEN.id_CourseType) == false && undefined !== pobjCurrEduClsEN.id_CourseType && clsString_js_1.tzDataType.isString(pobjCurrEduClsEN.id_CourseType) === false) {
            throw new Error("(errid:Watl000060)字段[课程类型流水号(id_CourseType)]的值:[$(pobjCurrEduClsEN.id_CourseType)], 非法，应该为字符型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckPropertyNew)");
        }
        if (null != pobjCurrEduClsEN.isDegree && undefined !== pobjCurrEduClsEN.isDegree && clsString_js_1.tzDataType.isBoolean(pobjCurrEduClsEN.isDegree) === false) {
            throw new Error("(errid:Watl000060)字段[是否学位课(isDegree)]的值:[$(pobjCurrEduClsEN.isDegree)], 非法，应该为布尔型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCurrEduClsEN.id_ScoreType) == false && undefined !== pobjCurrEduClsEN.id_ScoreType && clsString_js_1.tzDataType.isString(pobjCurrEduClsEN.id_ScoreType) === false) {
            throw new Error("(errid:Watl000060)字段[成绩类型流水号(id_ScoreType)]的值:[$(pobjCurrEduClsEN.id_ScoreType)], 非法，应该为字符型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCurrEduClsEN.getScoreWayId) == false && undefined !== pobjCurrEduClsEN.getScoreWayId && clsString_js_1.tzDataType.isString(pobjCurrEduClsEN.getScoreWayId) === false) {
            throw new Error("(errid:Watl000060)字段[获得成绩方式Id(getScoreWayId)]的值:[$(pobjCurrEduClsEN.getScoreWayId)], 非法，应该为字符型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckPropertyNew)");
        }
        if (null != pobjCurrEduClsEN.isProportionalCtrl && undefined !== pobjCurrEduClsEN.isProportionalCtrl && clsString_js_1.tzDataType.isBoolean(pobjCurrEduClsEN.isProportionalCtrl) === false) {
            throw new Error("(errid:Watl000060)字段[是否比例控制(isProportionalCtrl)]的值:[$(pobjCurrEduClsEN.isProportionalCtrl)], 非法，应该为布尔型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCurrEduClsEN.id_ExamType) == false && undefined !== pobjCurrEduClsEN.id_ExamType && clsString_js_1.tzDataType.isString(pobjCurrEduClsEN.id_ExamType) === false) {
            throw new Error("(errid:Watl000060)字段[考试方式流水号(id_ExamType)]的值:[$(pobjCurrEduClsEN.id_ExamType)], 非法，应该为字符型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCurrEduClsEN.examTime) == false && undefined !== pobjCurrEduClsEN.examTime && clsString_js_1.tzDataType.isString(pobjCurrEduClsEN.examTime) === false) {
            throw new Error("(errid:Watl000060)字段[考试时间(examTime)]的值:[$(pobjCurrEduClsEN.examTime)], 非法，应该为字符型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckPropertyNew)");
        }
        if (null != pobjCurrEduClsEN.beginWeek && undefined !== pobjCurrEduClsEN.beginWeek && clsString_js_1.tzDataType.isNumber(pobjCurrEduClsEN.beginWeek) === false) {
            throw new Error("(errid:Watl000060)字段[开始周(beginWeek)]的值:[$(pobjCurrEduClsEN.beginWeek)], 非法，应该为数值型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCurrEduClsEN.modifyDate) == false && undefined !== pobjCurrEduClsEN.modifyDate && clsString_js_1.tzDataType.isString(pobjCurrEduClsEN.modifyDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(modifyDate)]的值:[$(pobjCurrEduClsEN.modifyDate)], 非法，应该为字符型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCurrEduClsEN.modifyUserID) == false && undefined !== pobjCurrEduClsEN.modifyUserID && clsString_js_1.tzDataType.isString(pobjCurrEduClsEN.modifyUserID) === false) {
            throw new Error("(errid:Watl000060)字段[修改人(modifyUserID)]的值:[$(pobjCurrEduClsEN.modifyUserID)], 非法，应该为字符型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCurrEduClsEN.memo) == false && undefined !== pobjCurrEduClsEN.memo && clsString_js_1.tzDataType.isString(pobjCurrEduClsEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjCurrEduClsEN.memo)], 非法，应该为字符型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCurrEduClsEN.courseId) == false && (0, clsString_js_2.GetStrLen)(pobjCurrEduClsEN.courseId) != 8) {
            throw ("(errid:Watl000061)字段[课程Id]作为外键字段,长度应该为8(In 当前教学班)!(clsCurrEduClsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCurrEduClsEN.id_EduWay) == false && (0, clsString_js_2.GetStrLen)(pobjCurrEduClsEN.id_EduWay) != 4) {
            throw ("(errid:Watl000061)字段[教学方式流水号]作为外键字段,长度应该为4(In 当前教学班)!(clsCurrEduClsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCurrEduClsEN.id_ClassRoomType) == false && (0, clsString_js_2.GetStrLen)(pobjCurrEduClsEN.id_ClassRoomType) != 4) {
            throw ("(errid:Watl000061)字段[教室类型流水号]作为外键字段,长度应该为4(In 当前教学班)!(clsCurrEduClsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCurrEduClsEN.weekStatusID) == false && (0, clsString_js_2.GetStrLen)(pobjCurrEduClsEN.weekStatusID) != 2) {
            throw ("(errid:Watl000061)字段[周状态编号(单,双,全周)]作为外键字段,长度应该为2(In 当前教学班)!(clsCurrEduClsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCurrEduClsEN.id_UniZone) == false && (0, clsString_js_2.GetStrLen)(pobjCurrEduClsEN.id_UniZone) != 4) {
            throw ("(errid:Watl000061)字段[校区流水号]作为外键字段,长度应该为4(In 当前教学班)!(clsCurrEduClsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCurrEduClsEN.id_GradeBase) == false && (0, clsString_js_2.GetStrLen)(pobjCurrEduClsEN.id_GradeBase) != 4) {
            throw ("(errid:Watl000061)字段[年级流水号]作为外键字段,长度应该为4(In 当前教学班)!(clsCurrEduClsBL:CheckPropertyNew)");
        }
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjCurrEduClsEN.SetIsCheckProperty(true);
    }
    exports.CurrEduCls_CheckPropertyNew = CurrEduCls_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function CurrEduCls_CheckProperty4Update(pobjCurrEduClsEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCurrEduClsEN.id_CurrEduCls) == false && (0, clsString_js_2.GetStrLen)(pobjCurrEduClsEN.id_CurrEduCls) > 8) {
            throw new Error("(errid:Watl000062)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 当前教学班(CurrEduCls))!值:$(pobjCurrEduClsEN.id_CurrEduCls)(clsCurrEduClsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCurrEduClsEN.currEduClsId) == false && (0, clsString_js_2.GetStrLen)(pobjCurrEduClsEN.currEduClsId) > 15) {
            throw new Error("(errid:Watl000062)字段[教学班Id(currEduClsId)]的长度不能超过15(In 当前教学班(CurrEduCls))!值:$(pobjCurrEduClsEN.currEduClsId)(clsCurrEduClsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCurrEduClsEN.eduClsName) == false && (0, clsString_js_2.GetStrLen)(pobjCurrEduClsEN.eduClsName) > 100) {
            throw new Error("(errid:Watl000062)字段[教学班名(eduClsName)]的长度不能超过100(In 当前教学班(CurrEduCls))!值:$(pobjCurrEduClsEN.eduClsName)(clsCurrEduClsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCurrEduClsEN.eduClsTypeId) == false && (0, clsString_js_2.GetStrLen)(pobjCurrEduClsEN.eduClsTypeId) > 4) {
            throw new Error("(errid:Watl000062)字段[教学班类型Id(eduClsTypeId)]的长度不能超过4(In 当前教学班(CurrEduCls))!值:$(pobjCurrEduClsEN.eduClsTypeId)(clsCurrEduClsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCurrEduClsEN.courseId) == false && (0, clsString_js_2.GetStrLen)(pobjCurrEduClsEN.courseId) > 8) {
            throw new Error("(errid:Watl000062)字段[课程Id(courseId)]的长度不能超过8(In 当前教学班(CurrEduCls))!值:$(pobjCurrEduClsEN.courseId)(clsCurrEduClsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCurrEduClsEN.teachingSolutionId) == false && (0, clsString_js_2.GetStrLen)(pobjCurrEduClsEN.teachingSolutionId) > 8) {
            throw new Error("(errid:Watl000062)字段[教学方案Id(teachingSolutionId)]的长度不能超过8(In 当前教学班(CurrEduCls))!值:$(pobjCurrEduClsEN.teachingSolutionId)(clsCurrEduClsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCurrEduClsEN.id_XzCollege) == false && (0, clsString_js_2.GetStrLen)(pobjCurrEduClsEN.id_XzCollege) > 4) {
            throw new Error("(errid:Watl000062)字段[学院流水号(id_XzCollege)]的长度不能超过4(In 当前教学班(CurrEduCls))!值:$(pobjCurrEduClsEN.id_XzCollege)(clsCurrEduClsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCurrEduClsEN.id_XzMajor) == false && (0, clsString_js_2.GetStrLen)(pobjCurrEduClsEN.id_XzMajor) > 8) {
            throw new Error("(errid:Watl000062)字段[专业流水号(id_XzMajor)]的长度不能超过8(In 当前教学班(CurrEduCls))!值:$(pobjCurrEduClsEN.id_XzMajor)(clsCurrEduClsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCurrEduClsEN.id_EduWay) == false && (0, clsString_js_2.GetStrLen)(pobjCurrEduClsEN.id_EduWay) > 4) {
            throw new Error("(errid:Watl000062)字段[教学方式流水号(id_EduWay)]的长度不能超过4(In 当前教学班(CurrEduCls))!值:$(pobjCurrEduClsEN.id_EduWay)(clsCurrEduClsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCurrEduClsEN.id_ClassRoomType) == false && (0, clsString_js_2.GetStrLen)(pobjCurrEduClsEN.id_ClassRoomType) > 4) {
            throw new Error("(errid:Watl000062)字段[教室类型流水号(id_ClassRoomType)]的长度不能超过4(In 当前教学班(CurrEduCls))!值:$(pobjCurrEduClsEN.id_ClassRoomType)(clsCurrEduClsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCurrEduClsEN.weekStatusID) == false && (0, clsString_js_2.GetStrLen)(pobjCurrEduClsEN.weekStatusID) > 2) {
            throw new Error("(errid:Watl000062)字段[周状态编号(单,双,全周)(weekStatusID)]的长度不能超过2(In 当前教学班(CurrEduCls))!值:$(pobjCurrEduClsEN.weekStatusID)(clsCurrEduClsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCurrEduClsEN.customerWeek) == false && (0, clsString_js_2.GetStrLen)(pobjCurrEduClsEN.customerWeek) > 50) {
            throw new Error("(errid:Watl000062)字段[自定义上课周(customerWeek)]的长度不能超过50(In 当前教学班(CurrEduCls))!值:$(pobjCurrEduClsEN.customerWeek)(clsCurrEduClsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCurrEduClsEN.id_UniZone) == false && (0, clsString_js_2.GetStrLen)(pobjCurrEduClsEN.id_UniZone) > 4) {
            throw new Error("(errid:Watl000062)字段[校区流水号(id_UniZone)]的长度不能超过4(In 当前教学班(CurrEduCls))!值:$(pobjCurrEduClsEN.id_UniZone)(clsCurrEduClsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCurrEduClsEN.id_GradeBase) == false && (0, clsString_js_2.GetStrLen)(pobjCurrEduClsEN.id_GradeBase) > 4) {
            throw new Error("(errid:Watl000062)字段[年级流水号(id_GradeBase)]的长度不能超过4(In 当前教学班(CurrEduCls))!值:$(pobjCurrEduClsEN.id_GradeBase)(clsCurrEduClsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCurrEduClsEN.schoolYear) == false && (0, clsString_js_2.GetStrLen)(pobjCurrEduClsEN.schoolYear) > 10) {
            throw new Error("(errid:Watl000062)字段[学年(schoolYear)]的长度不能超过10(In 当前教学班(CurrEduCls))!值:$(pobjCurrEduClsEN.schoolYear)(clsCurrEduClsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCurrEduClsEN.schoolTerm) == false && (0, clsString_js_2.GetStrLen)(pobjCurrEduClsEN.schoolTerm) > 1) {
            throw new Error("(errid:Watl000062)字段[学期(schoolTerm)]的长度不能超过1(In 当前教学班(CurrEduCls))!值:$(pobjCurrEduClsEN.schoolTerm)(clsCurrEduClsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCurrEduClsEN.id_CourseType) == false && (0, clsString_js_2.GetStrLen)(pobjCurrEduClsEN.id_CourseType) > 4) {
            throw new Error("(errid:Watl000062)字段[课程类型流水号(id_CourseType)]的长度不能超过4(In 当前教学班(CurrEduCls))!值:$(pobjCurrEduClsEN.id_CourseType)(clsCurrEduClsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCurrEduClsEN.id_ScoreType) == false && (0, clsString_js_2.GetStrLen)(pobjCurrEduClsEN.id_ScoreType) > 4) {
            throw new Error("(errid:Watl000062)字段[成绩类型流水号(id_ScoreType)]的长度不能超过4(In 当前教学班(CurrEduCls))!值:$(pobjCurrEduClsEN.id_ScoreType)(clsCurrEduClsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCurrEduClsEN.getScoreWayId) == false && (0, clsString_js_2.GetStrLen)(pobjCurrEduClsEN.getScoreWayId) > 2) {
            throw new Error("(errid:Watl000062)字段[获得成绩方式Id(getScoreWayId)]的长度不能超过2(In 当前教学班(CurrEduCls))!值:$(pobjCurrEduClsEN.getScoreWayId)(clsCurrEduClsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCurrEduClsEN.id_ExamType) == false && (0, clsString_js_2.GetStrLen)(pobjCurrEduClsEN.id_ExamType) > 4) {
            throw new Error("(errid:Watl000062)字段[考试方式流水号(id_ExamType)]的长度不能超过4(In 当前教学班(CurrEduCls))!值:$(pobjCurrEduClsEN.id_ExamType)(clsCurrEduClsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCurrEduClsEN.examTime) == false && (0, clsString_js_2.GetStrLen)(pobjCurrEduClsEN.examTime) > 8) {
            throw new Error("(errid:Watl000062)字段[考试时间(examTime)]的长度不能超过8(In 当前教学班(CurrEduCls))!值:$(pobjCurrEduClsEN.examTime)(clsCurrEduClsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCurrEduClsEN.modifyDate) == false && (0, clsString_js_2.GetStrLen)(pobjCurrEduClsEN.modifyDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(modifyDate)]的长度不能超过20(In 当前教学班(CurrEduCls))!值:$(pobjCurrEduClsEN.modifyDate)(clsCurrEduClsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCurrEduClsEN.modifyUserID) == false && (0, clsString_js_2.GetStrLen)(pobjCurrEduClsEN.modifyUserID) > 18) {
            throw new Error("(errid:Watl000062)字段[修改人(modifyUserID)]的长度不能超过18(In 当前教学班(CurrEduCls))!值:$(pobjCurrEduClsEN.modifyUserID)(clsCurrEduClsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCurrEduClsEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjCurrEduClsEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 当前教学班(CurrEduCls))!值:$(pobjCurrEduClsEN.memo)(clsCurrEduClsBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCurrEduClsEN.id_CurrEduCls) == false && undefined !== pobjCurrEduClsEN.id_CurrEduCls && clsString_js_1.tzDataType.isString(pobjCurrEduClsEN.id_CurrEduCls) === false) {
            throw new Error("(errid:Watl000063)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjCurrEduClsEN.id_CurrEduCls)], 非法，应该为字符型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCurrEduClsEN.currEduClsId) == false && undefined !== pobjCurrEduClsEN.currEduClsId && clsString_js_1.tzDataType.isString(pobjCurrEduClsEN.currEduClsId) === false) {
            throw new Error("(errid:Watl000063)字段[教学班Id(currEduClsId)]的值:[$(pobjCurrEduClsEN.currEduClsId)], 非法，应该为字符型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCurrEduClsEN.eduClsName) == false && undefined !== pobjCurrEduClsEN.eduClsName && clsString_js_1.tzDataType.isString(pobjCurrEduClsEN.eduClsName) === false) {
            throw new Error("(errid:Watl000063)字段[教学班名(eduClsName)]的值:[$(pobjCurrEduClsEN.eduClsName)], 非法，应该为字符型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCurrEduClsEN.eduClsTypeId) == false && undefined !== pobjCurrEduClsEN.eduClsTypeId && clsString_js_1.tzDataType.isString(pobjCurrEduClsEN.eduClsTypeId) === false) {
            throw new Error("(errid:Watl000063)字段[教学班类型Id(eduClsTypeId)]的值:[$(pobjCurrEduClsEN.eduClsTypeId)], 非法，应该为字符型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCurrEduClsEN.courseId) == false && undefined !== pobjCurrEduClsEN.courseId && clsString_js_1.tzDataType.isString(pobjCurrEduClsEN.courseId) === false) {
            throw new Error("(errid:Watl000063)字段[课程Id(courseId)]的值:[$(pobjCurrEduClsEN.courseId)], 非法，应该为字符型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCurrEduClsEN.teachingSolutionId) == false && undefined !== pobjCurrEduClsEN.teachingSolutionId && clsString_js_1.tzDataType.isString(pobjCurrEduClsEN.teachingSolutionId) === false) {
            throw new Error("(errid:Watl000063)字段[教学方案Id(teachingSolutionId)]的值:[$(pobjCurrEduClsEN.teachingSolutionId)], 非法，应该为字符型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCurrEduClsEN.id_XzCollege) == false && undefined !== pobjCurrEduClsEN.id_XzCollege && clsString_js_1.tzDataType.isString(pobjCurrEduClsEN.id_XzCollege) === false) {
            throw new Error("(errid:Watl000063)字段[学院流水号(id_XzCollege)]的值:[$(pobjCurrEduClsEN.id_XzCollege)], 非法，应该为字符型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCurrEduClsEN.id_XzMajor) == false && undefined !== pobjCurrEduClsEN.id_XzMajor && clsString_js_1.tzDataType.isString(pobjCurrEduClsEN.id_XzMajor) === false) {
            throw new Error("(errid:Watl000063)字段[专业流水号(id_XzMajor)]的值:[$(pobjCurrEduClsEN.id_XzMajor)], 非法，应该为字符型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCurrEduClsEN.id_EduWay) == false && undefined !== pobjCurrEduClsEN.id_EduWay && clsString_js_1.tzDataType.isString(pobjCurrEduClsEN.id_EduWay) === false) {
            throw new Error("(errid:Watl000063)字段[教学方式流水号(id_EduWay)]的值:[$(pobjCurrEduClsEN.id_EduWay)], 非法，应该为字符型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCurrEduClsEN.id_ClassRoomType) == false && undefined !== pobjCurrEduClsEN.id_ClassRoomType && clsString_js_1.tzDataType.isString(pobjCurrEduClsEN.id_ClassRoomType) === false) {
            throw new Error("(errid:Watl000063)字段[教室类型流水号(id_ClassRoomType)]的值:[$(pobjCurrEduClsEN.id_ClassRoomType)], 非法，应该为字符型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckProperty4Update)");
        }
        if (null != pobjCurrEduClsEN.totalLessonQty && undefined !== pobjCurrEduClsEN.totalLessonQty && clsString_js_1.tzDataType.isNumber(pobjCurrEduClsEN.totalLessonQty) === false) {
            throw new Error("(errid:Watl000063)字段[总课时数(totalLessonQty)]的值:[$(pobjCurrEduClsEN.totalLessonQty)], 非法，应该为数值型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckProperty4Update)");
        }
        if (null != pobjCurrEduClsEN.maxStuQty && undefined !== pobjCurrEduClsEN.maxStuQty && clsString_js_1.tzDataType.isNumber(pobjCurrEduClsEN.maxStuQty) === false) {
            throw new Error("(errid:Watl000063)字段[最大学生数(maxStuQty)]的值:[$(pobjCurrEduClsEN.maxStuQty)], 非法，应该为数值型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckProperty4Update)");
        }
        if (null != pobjCurrEduClsEN.weekQty && undefined !== pobjCurrEduClsEN.weekQty && clsString_js_1.tzDataType.isNumber(pobjCurrEduClsEN.weekQty) === false) {
            throw new Error("(errid:Watl000063)字段[总周数(weekQty)]的值:[$(pobjCurrEduClsEN.weekQty)], 非法，应该为数值型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckProperty4Update)");
        }
        if (null != pobjCurrEduClsEN.scheUnitPW && undefined !== pobjCurrEduClsEN.scheUnitPW && clsString_js_1.tzDataType.isNumber(pobjCurrEduClsEN.scheUnitPW) === false) {
            throw new Error("(errid:Watl000063)字段[周排课次数(scheUnitPW)]的值:[$(pobjCurrEduClsEN.scheUnitPW)], 非法，应该为数值型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCurrEduClsEN.weekStatusID) == false && undefined !== pobjCurrEduClsEN.weekStatusID && clsString_js_1.tzDataType.isString(pobjCurrEduClsEN.weekStatusID) === false) {
            throw new Error("(errid:Watl000063)字段[周状态编号(单,双,全周)(weekStatusID)]的值:[$(pobjCurrEduClsEN.weekStatusID)], 非法，应该为字符型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCurrEduClsEN.customerWeek) == false && undefined !== pobjCurrEduClsEN.customerWeek && clsString_js_1.tzDataType.isString(pobjCurrEduClsEN.customerWeek) === false) {
            throw new Error("(errid:Watl000063)字段[自定义上课周(customerWeek)]的值:[$(pobjCurrEduClsEN.customerWeek)], 非法，应该为字符型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckProperty4Update)");
        }
        if (null != pobjCurrEduClsEN.lessonQtyPerWeek && undefined !== pobjCurrEduClsEN.lessonQtyPerWeek && clsString_js_1.tzDataType.isNumber(pobjCurrEduClsEN.lessonQtyPerWeek) === false) {
            throw new Error("(errid:Watl000063)字段[周课时数(lessonQtyPerWeek)]的值:[$(pobjCurrEduClsEN.lessonQtyPerWeek)], 非法，应该为数值型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckProperty4Update)");
        }
        if (null != pobjCurrEduClsEN.mark && undefined !== pobjCurrEduClsEN.mark && clsString_js_1.tzDataType.isNumber(pobjCurrEduClsEN.mark) === false) {
            throw new Error("(errid:Watl000063)字段[获得学分(mark)]的值:[$(pobjCurrEduClsEN.mark)], 非法，应该为数值型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCurrEduClsEN.id_UniZone) == false && undefined !== pobjCurrEduClsEN.id_UniZone && clsString_js_1.tzDataType.isString(pobjCurrEduClsEN.id_UniZone) === false) {
            throw new Error("(errid:Watl000063)字段[校区流水号(id_UniZone)]的值:[$(pobjCurrEduClsEN.id_UniZone)], 非法，应该为字符型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCurrEduClsEN.id_GradeBase) == false && undefined !== pobjCurrEduClsEN.id_GradeBase && clsString_js_1.tzDataType.isString(pobjCurrEduClsEN.id_GradeBase) === false) {
            throw new Error("(errid:Watl000063)字段[年级流水号(id_GradeBase)]的值:[$(pobjCurrEduClsEN.id_GradeBase)], 非法，应该为字符型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckProperty4Update)");
        }
        if (null != pobjCurrEduClsEN.isEffective && undefined !== pobjCurrEduClsEN.isEffective && clsString_js_1.tzDataType.isBoolean(pobjCurrEduClsEN.isEffective) === false) {
            throw new Error("(errid:Watl000063)字段[是否有效(isEffective)]的值:[$(pobjCurrEduClsEN.isEffective)], 非法，应该为布尔型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckProperty4Update)");
        }
        if (null != pobjCurrEduClsEN.isForPaperReading && undefined !== pobjCurrEduClsEN.isForPaperReading && clsString_js_1.tzDataType.isBoolean(pobjCurrEduClsEN.isForPaperReading) === false) {
            throw new Error("(errid:Watl000063)字段[是否参与论文阅读(isForPaperReading)]的值:[$(pobjCurrEduClsEN.isForPaperReading)], 非法，应该为布尔型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCurrEduClsEN.schoolYear) == false && undefined !== pobjCurrEduClsEN.schoolYear && clsString_js_1.tzDataType.isString(pobjCurrEduClsEN.schoolYear) === false) {
            throw new Error("(errid:Watl000063)字段[学年(schoolYear)]的值:[$(pobjCurrEduClsEN.schoolYear)], 非法，应该为字符型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCurrEduClsEN.schoolTerm) == false && undefined !== pobjCurrEduClsEN.schoolTerm && clsString_js_1.tzDataType.isString(pobjCurrEduClsEN.schoolTerm) === false) {
            throw new Error("(errid:Watl000063)字段[学期(schoolTerm)]的值:[$(pobjCurrEduClsEN.schoolTerm)], 非法，应该为字符型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCurrEduClsEN.id_CourseType) == false && undefined !== pobjCurrEduClsEN.id_CourseType && clsString_js_1.tzDataType.isString(pobjCurrEduClsEN.id_CourseType) === false) {
            throw new Error("(errid:Watl000063)字段[课程类型流水号(id_CourseType)]的值:[$(pobjCurrEduClsEN.id_CourseType)], 非法，应该为字符型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckProperty4Update)");
        }
        if (null != pobjCurrEduClsEN.isDegree && undefined !== pobjCurrEduClsEN.isDegree && clsString_js_1.tzDataType.isBoolean(pobjCurrEduClsEN.isDegree) === false) {
            throw new Error("(errid:Watl000063)字段[是否学位课(isDegree)]的值:[$(pobjCurrEduClsEN.isDegree)], 非法，应该为布尔型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCurrEduClsEN.id_ScoreType) == false && undefined !== pobjCurrEduClsEN.id_ScoreType && clsString_js_1.tzDataType.isString(pobjCurrEduClsEN.id_ScoreType) === false) {
            throw new Error("(errid:Watl000063)字段[成绩类型流水号(id_ScoreType)]的值:[$(pobjCurrEduClsEN.id_ScoreType)], 非法，应该为字符型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCurrEduClsEN.getScoreWayId) == false && undefined !== pobjCurrEduClsEN.getScoreWayId && clsString_js_1.tzDataType.isString(pobjCurrEduClsEN.getScoreWayId) === false) {
            throw new Error("(errid:Watl000063)字段[获得成绩方式Id(getScoreWayId)]的值:[$(pobjCurrEduClsEN.getScoreWayId)], 非法，应该为字符型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckProperty4Update)");
        }
        if (null != pobjCurrEduClsEN.isProportionalCtrl && undefined !== pobjCurrEduClsEN.isProportionalCtrl && clsString_js_1.tzDataType.isBoolean(pobjCurrEduClsEN.isProportionalCtrl) === false) {
            throw new Error("(errid:Watl000063)字段[是否比例控制(isProportionalCtrl)]的值:[$(pobjCurrEduClsEN.isProportionalCtrl)], 非法，应该为布尔型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCurrEduClsEN.id_ExamType) == false && undefined !== pobjCurrEduClsEN.id_ExamType && clsString_js_1.tzDataType.isString(pobjCurrEduClsEN.id_ExamType) === false) {
            throw new Error("(errid:Watl000063)字段[考试方式流水号(id_ExamType)]的值:[$(pobjCurrEduClsEN.id_ExamType)], 非法，应该为字符型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCurrEduClsEN.examTime) == false && undefined !== pobjCurrEduClsEN.examTime && clsString_js_1.tzDataType.isString(pobjCurrEduClsEN.examTime) === false) {
            throw new Error("(errid:Watl000063)字段[考试时间(examTime)]的值:[$(pobjCurrEduClsEN.examTime)], 非法，应该为字符型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckProperty4Update)");
        }
        if (null != pobjCurrEduClsEN.beginWeek && undefined !== pobjCurrEduClsEN.beginWeek && clsString_js_1.tzDataType.isNumber(pobjCurrEduClsEN.beginWeek) === false) {
            throw new Error("(errid:Watl000063)字段[开始周(beginWeek)]的值:[$(pobjCurrEduClsEN.beginWeek)], 非法，应该为数值型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCurrEduClsEN.modifyDate) == false && undefined !== pobjCurrEduClsEN.modifyDate && clsString_js_1.tzDataType.isString(pobjCurrEduClsEN.modifyDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(modifyDate)]的值:[$(pobjCurrEduClsEN.modifyDate)], 非法，应该为字符型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCurrEduClsEN.modifyUserID) == false && undefined !== pobjCurrEduClsEN.modifyUserID && clsString_js_1.tzDataType.isString(pobjCurrEduClsEN.modifyUserID) === false) {
            throw new Error("(errid:Watl000063)字段[修改人(modifyUserID)]的值:[$(pobjCurrEduClsEN.modifyUserID)], 非法，应该为字符型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCurrEduClsEN.memo) == false && undefined !== pobjCurrEduClsEN.memo && clsString_js_1.tzDataType.isString(pobjCurrEduClsEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjCurrEduClsEN.memo)], 非法，应该为字符型(In 当前教学班(CurrEduCls))!(clsCurrEduClsBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCurrEduClsEN.id_CurrEduCls) === true
            || pobjCurrEduClsEN.id_CurrEduCls.toString() === "0") {
            throw new Error("(errid:Watl000064)字段[教学班流水号]不能为空(In 当前教学班)!(clsCurrEduClsBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCurrEduClsEN.courseId) == false && (0, clsString_js_2.GetStrLen)(pobjCurrEduClsEN.courseId) != 8) {
            throw ("(errid:Watl000065)字段[课程Id]作为外键字段,长度应该为8(In 当前教学班)!(clsCurrEduClsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCurrEduClsEN.id_EduWay) == false && (0, clsString_js_2.GetStrLen)(pobjCurrEduClsEN.id_EduWay) != 4) {
            throw ("(errid:Watl000065)字段[教学方式流水号]作为外键字段,长度应该为4(In 当前教学班)!(clsCurrEduClsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCurrEduClsEN.id_ClassRoomType) == false && (0, clsString_js_2.GetStrLen)(pobjCurrEduClsEN.id_ClassRoomType) != 4) {
            throw ("(errid:Watl000065)字段[教室类型流水号]作为外键字段,长度应该为4(In 当前教学班)!(clsCurrEduClsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCurrEduClsEN.weekStatusID) == false && (0, clsString_js_2.GetStrLen)(pobjCurrEduClsEN.weekStatusID) != 2) {
            throw ("(errid:Watl000065)字段[周状态编号(单,双,全周)]作为外键字段,长度应该为2(In 当前教学班)!(clsCurrEduClsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCurrEduClsEN.id_UniZone) == false && (0, clsString_js_2.GetStrLen)(pobjCurrEduClsEN.id_UniZone) != 4) {
            throw ("(errid:Watl000065)字段[校区流水号]作为外键字段,长度应该为4(In 当前教学班)!(clsCurrEduClsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCurrEduClsEN.id_GradeBase) == false && (0, clsString_js_2.GetStrLen)(pobjCurrEduClsEN.id_GradeBase) != 4) {
            throw ("(errid:Watl000065)字段[年级流水号]作为外键字段,长度应该为4(In 当前教学班)!(clsCurrEduClsBL:CheckPropertyNew)");
        }
        pobjCurrEduClsEN.SetIsCheckProperty(true);
    }
    exports.CurrEduCls_CheckProperty4Update = CurrEduCls_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function CurrEduCls_GetJSONStrByObj(pobjCurrEduClsEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjCurrEduClsEN.sf_UpdFldSetStr = pobjCurrEduClsEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjCurrEduClsEN);
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
    exports.CurrEduCls_GetJSONStrByObj = CurrEduCls_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function CurrEduCls_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrCurrEduClsObjLst = new Array();
        if (strJSON === "") {
            return arrCurrEduClsObjLst;
        }
        try {
            arrCurrEduClsObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrCurrEduClsObjLst;
        }
        return arrCurrEduClsObjLst;
    }
    exports.CurrEduCls_GetObjLstByJSONStr = CurrEduCls_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrCurrEduClsObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function CurrEduCls_GetObjLstByJSONObjLst(arrCurrEduClsObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrCurrEduClsObjLst = new Array();
        for (const objInFor of arrCurrEduClsObjLstS) {
            const obj1 = CurrEduCls_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrCurrEduClsObjLst.push(obj1);
        }
        return arrCurrEduClsObjLst;
    }
    exports.CurrEduCls_GetObjLstByJSONObjLst = CurrEduCls_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function CurrEduCls_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjCurrEduClsEN = new clsCurrEduClsEN_js_1.clsCurrEduClsEN();
        if (strJSON === "") {
            return pobjCurrEduClsEN;
        }
        try {
            pobjCurrEduClsEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjCurrEduClsEN;
        }
        return pobjCurrEduClsEN;
    }
    exports.CurrEduCls_GetObjByJSONStr = CurrEduCls_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function CurrEduCls_GetCombineCondition(objCurrEduCls_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objCurrEduCls_Cond.dicFldComparisonOp, clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_id_CurrEduCls) == true) {
            const strComparisonOp_id_CurrEduCls = objCurrEduCls_Cond.dicFldComparisonOp[clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_id_CurrEduCls];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_id_CurrEduCls, objCurrEduCls_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
        }
        if (Object.prototype.hasOwnProperty.call(objCurrEduCls_Cond.dicFldComparisonOp, clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_CurrEduClsId) == true) {
            const strComparisonOp_CurrEduClsId = objCurrEduCls_Cond.dicFldComparisonOp[clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_CurrEduClsId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_CurrEduClsId, objCurrEduCls_Cond.currEduClsId, strComparisonOp_CurrEduClsId);
        }
        if (Object.prototype.hasOwnProperty.call(objCurrEduCls_Cond.dicFldComparisonOp, clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_EduClsName) == true) {
            const strComparisonOp_EduClsName = objCurrEduCls_Cond.dicFldComparisonOp[clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_EduClsName];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_EduClsName, objCurrEduCls_Cond.eduClsName, strComparisonOp_EduClsName);
        }
        if (Object.prototype.hasOwnProperty.call(objCurrEduCls_Cond.dicFldComparisonOp, clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_EduClsTypeId) == true) {
            const strComparisonOp_EduClsTypeId = objCurrEduCls_Cond.dicFldComparisonOp[clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_EduClsTypeId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_EduClsTypeId, objCurrEduCls_Cond.eduClsTypeId, strComparisonOp_EduClsTypeId);
        }
        if (Object.prototype.hasOwnProperty.call(objCurrEduCls_Cond.dicFldComparisonOp, clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_CourseId) == true) {
            const strComparisonOp_CourseId = objCurrEduCls_Cond.dicFldComparisonOp[clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_CourseId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_CourseId, objCurrEduCls_Cond.courseId, strComparisonOp_CourseId);
        }
        if (Object.prototype.hasOwnProperty.call(objCurrEduCls_Cond.dicFldComparisonOp, clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_TeachingSolutionId) == true) {
            const strComparisonOp_TeachingSolutionId = objCurrEduCls_Cond.dicFldComparisonOp[clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_TeachingSolutionId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_TeachingSolutionId, objCurrEduCls_Cond.teachingSolutionId, strComparisonOp_TeachingSolutionId);
        }
        if (Object.prototype.hasOwnProperty.call(objCurrEduCls_Cond.dicFldComparisonOp, clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_id_XzCollege) == true) {
            const strComparisonOp_id_XzCollege = objCurrEduCls_Cond.dicFldComparisonOp[clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_id_XzCollege];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_id_XzCollege, objCurrEduCls_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
        }
        if (Object.prototype.hasOwnProperty.call(objCurrEduCls_Cond.dicFldComparisonOp, clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_id_XzMajor) == true) {
            const strComparisonOp_id_XzMajor = objCurrEduCls_Cond.dicFldComparisonOp[clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_id_XzMajor];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_id_XzMajor, objCurrEduCls_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
        }
        if (Object.prototype.hasOwnProperty.call(objCurrEduCls_Cond.dicFldComparisonOp, clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_id_EduWay) == true) {
            const strComparisonOp_id_EduWay = objCurrEduCls_Cond.dicFldComparisonOp[clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_id_EduWay];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_id_EduWay, objCurrEduCls_Cond.id_EduWay, strComparisonOp_id_EduWay);
        }
        if (Object.prototype.hasOwnProperty.call(objCurrEduCls_Cond.dicFldComparisonOp, clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_id_ClassRoomType) == true) {
            const strComparisonOp_id_ClassRoomType = objCurrEduCls_Cond.dicFldComparisonOp[clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_id_ClassRoomType];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_id_ClassRoomType, objCurrEduCls_Cond.id_ClassRoomType, strComparisonOp_id_ClassRoomType);
        }
        if (Object.prototype.hasOwnProperty.call(objCurrEduCls_Cond.dicFldComparisonOp, clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_TotalLessonQty) == true) {
            const strComparisonOp_TotalLessonQty = objCurrEduCls_Cond.dicFldComparisonOp[clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_TotalLessonQty];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_TotalLessonQty, objCurrEduCls_Cond.totalLessonQty, strComparisonOp_TotalLessonQty);
        }
        if (Object.prototype.hasOwnProperty.call(objCurrEduCls_Cond.dicFldComparisonOp, clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_MaxStuQty) == true) {
            const strComparisonOp_MaxStuQty = objCurrEduCls_Cond.dicFldComparisonOp[clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_MaxStuQty];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_MaxStuQty, objCurrEduCls_Cond.maxStuQty, strComparisonOp_MaxStuQty);
        }
        if (Object.prototype.hasOwnProperty.call(objCurrEduCls_Cond.dicFldComparisonOp, clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_WeekQty) == true) {
            const strComparisonOp_WeekQty = objCurrEduCls_Cond.dicFldComparisonOp[clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_WeekQty];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_WeekQty, objCurrEduCls_Cond.weekQty, strComparisonOp_WeekQty);
        }
        //数据类型number(smallint)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
        if (Object.prototype.hasOwnProperty.call(objCurrEduCls_Cond.dicFldComparisonOp, clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_WeekStatusID) == true) {
            const strComparisonOp_WeekStatusID = objCurrEduCls_Cond.dicFldComparisonOp[clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_WeekStatusID];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_WeekStatusID, objCurrEduCls_Cond.weekStatusID, strComparisonOp_WeekStatusID);
        }
        if (Object.prototype.hasOwnProperty.call(objCurrEduCls_Cond.dicFldComparisonOp, clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_CustomerWeek) == true) {
            const strComparisonOp_CustomerWeek = objCurrEduCls_Cond.dicFldComparisonOp[clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_CustomerWeek];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_CustomerWeek, objCurrEduCls_Cond.customerWeek, strComparisonOp_CustomerWeek);
        }
        //数据类型number(smallint)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
        if (Object.prototype.hasOwnProperty.call(objCurrEduCls_Cond.dicFldComparisonOp, clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_Mark) == true) {
            const strComparisonOp_Mark = objCurrEduCls_Cond.dicFldComparisonOp[clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_Mark];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_Mark, objCurrEduCls_Cond.mark, strComparisonOp_Mark);
        }
        if (Object.prototype.hasOwnProperty.call(objCurrEduCls_Cond.dicFldComparisonOp, clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_id_UniZone) == true) {
            const strComparisonOp_id_UniZone = objCurrEduCls_Cond.dicFldComparisonOp[clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_id_UniZone];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_id_UniZone, objCurrEduCls_Cond.id_UniZone, strComparisonOp_id_UniZone);
        }
        if (Object.prototype.hasOwnProperty.call(objCurrEduCls_Cond.dicFldComparisonOp, clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_id_GradeBase) == true) {
            const strComparisonOp_id_GradeBase = objCurrEduCls_Cond.dicFldComparisonOp[clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_id_GradeBase];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_id_GradeBase, objCurrEduCls_Cond.id_GradeBase, strComparisonOp_id_GradeBase);
        }
        if (Object.prototype.hasOwnProperty.call(objCurrEduCls_Cond.dicFldComparisonOp, clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_IsEffective) == true) {
            if (objCurrEduCls_Cond.isEffective == true) {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '1'", clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_IsEffective);
            }
            else {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '0'", clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_IsEffective);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objCurrEduCls_Cond.dicFldComparisonOp, clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_IsForPaperReading) == true) {
            if (objCurrEduCls_Cond.isForPaperReading == true) {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '1'", clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_IsForPaperReading);
            }
            else {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '0'", clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_IsForPaperReading);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objCurrEduCls_Cond.dicFldComparisonOp, clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_SchoolYear) == true) {
            const strComparisonOp_SchoolYear = objCurrEduCls_Cond.dicFldComparisonOp[clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_SchoolYear];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_SchoolYear, objCurrEduCls_Cond.schoolYear, strComparisonOp_SchoolYear);
        }
        if (Object.prototype.hasOwnProperty.call(objCurrEduCls_Cond.dicFldComparisonOp, clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_SchoolTerm) == true) {
            const strComparisonOp_SchoolTerm = objCurrEduCls_Cond.dicFldComparisonOp[clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_SchoolTerm];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_SchoolTerm, objCurrEduCls_Cond.schoolTerm, strComparisonOp_SchoolTerm);
        }
        if (Object.prototype.hasOwnProperty.call(objCurrEduCls_Cond.dicFldComparisonOp, clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_id_CourseType) == true) {
            const strComparisonOp_id_CourseType = objCurrEduCls_Cond.dicFldComparisonOp[clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_id_CourseType];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_id_CourseType, objCurrEduCls_Cond.id_CourseType, strComparisonOp_id_CourseType);
        }
        if (Object.prototype.hasOwnProperty.call(objCurrEduCls_Cond.dicFldComparisonOp, clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_IsDegree) == true) {
            if (objCurrEduCls_Cond.isDegree == true) {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '1'", clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_IsDegree);
            }
            else {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '0'", clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_IsDegree);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objCurrEduCls_Cond.dicFldComparisonOp, clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_id_ScoreType) == true) {
            const strComparisonOp_id_ScoreType = objCurrEduCls_Cond.dicFldComparisonOp[clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_id_ScoreType];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_id_ScoreType, objCurrEduCls_Cond.id_ScoreType, strComparisonOp_id_ScoreType);
        }
        if (Object.prototype.hasOwnProperty.call(objCurrEduCls_Cond.dicFldComparisonOp, clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_GetScoreWayId) == true) {
            const strComparisonOp_GetScoreWayId = objCurrEduCls_Cond.dicFldComparisonOp[clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_GetScoreWayId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_GetScoreWayId, objCurrEduCls_Cond.getScoreWayId, strComparisonOp_GetScoreWayId);
        }
        if (Object.prototype.hasOwnProperty.call(objCurrEduCls_Cond.dicFldComparisonOp, clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_IsProportionalCtrl) == true) {
            if (objCurrEduCls_Cond.isProportionalCtrl == true) {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '1'", clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_IsProportionalCtrl);
            }
            else {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '0'", clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_IsProportionalCtrl);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objCurrEduCls_Cond.dicFldComparisonOp, clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_id_ExamType) == true) {
            const strComparisonOp_id_ExamType = objCurrEduCls_Cond.dicFldComparisonOp[clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_id_ExamType];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_id_ExamType, objCurrEduCls_Cond.id_ExamType, strComparisonOp_id_ExamType);
        }
        if (Object.prototype.hasOwnProperty.call(objCurrEduCls_Cond.dicFldComparisonOp, clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_ExamTime) == true) {
            const strComparisonOp_ExamTime = objCurrEduCls_Cond.dicFldComparisonOp[clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_ExamTime];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_ExamTime, objCurrEduCls_Cond.examTime, strComparisonOp_ExamTime);
        }
        //数据类型number(smallint)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
        if (Object.prototype.hasOwnProperty.call(objCurrEduCls_Cond.dicFldComparisonOp, clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_ModifyDate) == true) {
            const strComparisonOp_ModifyDate = objCurrEduCls_Cond.dicFldComparisonOp[clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_ModifyDate];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_ModifyDate, objCurrEduCls_Cond.modifyDate, strComparisonOp_ModifyDate);
        }
        if (Object.prototype.hasOwnProperty.call(objCurrEduCls_Cond.dicFldComparisonOp, clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_ModifyUserID) == true) {
            const strComparisonOp_ModifyUserID = objCurrEduCls_Cond.dicFldComparisonOp[clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_ModifyUserID];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_ModifyUserID, objCurrEduCls_Cond.modifyUserID, strComparisonOp_ModifyUserID);
        }
        if (Object.prototype.hasOwnProperty.call(objCurrEduCls_Cond.dicFldComparisonOp, clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_Memo) == true) {
            const strComparisonOp_Memo = objCurrEduCls_Cond.dicFldComparisonOp[clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_Memo];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_Memo, objCurrEduCls_Cond.memo, strComparisonOp_Memo);
        }
        return strWhereCond;
    }
    exports.CurrEduCls_GetCombineCondition = CurrEduCls_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--CurrEduCls(当前教学班),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param strEduClsName: 教学班名(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function CurrEduCls_GetUniCondStr_EduClsName(objCurrEduClsEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and EduClsName = '{0}'", objCurrEduClsEN.eduClsName);
        return strWhereCond;
    }
    exports.CurrEduCls_GetUniCondStr_EduClsName = CurrEduCls_GetUniCondStr_EduClsName;
    /**
    *获取唯一性条件串(Uniqueness)--CurrEduCls(当前教学班),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param strEduClsName: 教学班名(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function CurrEduCls_GetUniCondStr4Update_EduClsName(objCurrEduClsEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and id_CurrEduCls <> '{0}'", objCurrEduClsEN.id_CurrEduCls);
        strWhereCond += (0, clsString_js_2.Format)(" and EduClsName = '{0}'", objCurrEduClsEN.eduClsName);
        return strWhereCond;
    }
    exports.CurrEduCls_GetUniCondStr4Update_EduClsName = CurrEduCls_GetUniCondStr4Update_EduClsName;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objCurrEduClsENS:源对象
     * @param objCurrEduClsENT:目标对象
    */
    function CurrEduCls_CopyObjTo(objCurrEduClsENS, objCurrEduClsENT) {
        objCurrEduClsENT.id_CurrEduCls = objCurrEduClsENS.id_CurrEduCls; //教学班流水号
        objCurrEduClsENT.currEduClsId = objCurrEduClsENS.currEduClsId; //教学班Id
        objCurrEduClsENT.eduClsName = objCurrEduClsENS.eduClsName; //教学班名
        objCurrEduClsENT.eduClsTypeId = objCurrEduClsENS.eduClsTypeId; //教学班类型Id
        objCurrEduClsENT.courseId = objCurrEduClsENS.courseId; //课程Id
        objCurrEduClsENT.teachingSolutionId = objCurrEduClsENS.teachingSolutionId; //教学方案Id
        objCurrEduClsENT.id_XzCollege = objCurrEduClsENS.id_XzCollege; //学院流水号
        objCurrEduClsENT.id_XzMajor = objCurrEduClsENS.id_XzMajor; //专业流水号
        objCurrEduClsENT.id_EduWay = objCurrEduClsENS.id_EduWay; //教学方式流水号
        objCurrEduClsENT.id_ClassRoomType = objCurrEduClsENS.id_ClassRoomType; //教室类型流水号
        objCurrEduClsENT.totalLessonQty = objCurrEduClsENS.totalLessonQty; //总课时数
        objCurrEduClsENT.maxStuQty = objCurrEduClsENS.maxStuQty; //最大学生数
        objCurrEduClsENT.weekQty = objCurrEduClsENS.weekQty; //总周数
        objCurrEduClsENT.scheUnitPW = objCurrEduClsENS.scheUnitPW; //周排课次数
        objCurrEduClsENT.weekStatusID = objCurrEduClsENS.weekStatusID; //周状态编号(单,双,全周)
        objCurrEduClsENT.customerWeek = objCurrEduClsENS.customerWeek; //自定义上课周
        objCurrEduClsENT.lessonQtyPerWeek = objCurrEduClsENS.lessonQtyPerWeek; //周课时数
        objCurrEduClsENT.mark = objCurrEduClsENS.mark; //获得学分
        objCurrEduClsENT.id_UniZone = objCurrEduClsENS.id_UniZone; //校区流水号
        objCurrEduClsENT.id_GradeBase = objCurrEduClsENS.id_GradeBase; //年级流水号
        objCurrEduClsENT.isEffective = objCurrEduClsENS.isEffective; //是否有效
        objCurrEduClsENT.isForPaperReading = objCurrEduClsENS.isForPaperReading; //是否参与论文阅读
        objCurrEduClsENT.schoolYear = objCurrEduClsENS.schoolYear; //学年
        objCurrEduClsENT.schoolTerm = objCurrEduClsENS.schoolTerm; //学期
        objCurrEduClsENT.id_CourseType = objCurrEduClsENS.id_CourseType; //课程类型流水号
        objCurrEduClsENT.isDegree = objCurrEduClsENS.isDegree; //是否学位课
        objCurrEduClsENT.id_ScoreType = objCurrEduClsENS.id_ScoreType; //成绩类型流水号
        objCurrEduClsENT.getScoreWayId = objCurrEduClsENS.getScoreWayId; //获得成绩方式Id
        objCurrEduClsENT.isProportionalCtrl = objCurrEduClsENS.isProportionalCtrl; //是否比例控制
        objCurrEduClsENT.id_ExamType = objCurrEduClsENS.id_ExamType; //考试方式流水号
        objCurrEduClsENT.examTime = objCurrEduClsENS.examTime; //考试时间
        objCurrEduClsENT.beginWeek = objCurrEduClsENS.beginWeek; //开始周
        objCurrEduClsENT.modifyDate = objCurrEduClsENS.modifyDate; //修改日期
        objCurrEduClsENT.modifyUserID = objCurrEduClsENS.modifyUserID; //修改人
        objCurrEduClsENT.memo = objCurrEduClsENS.memo; //备注
        objCurrEduClsENT.sf_UpdFldSetStr = objCurrEduClsENS.updFldString; //sf_UpdFldSetStr
    }
    exports.CurrEduCls_CopyObjTo = CurrEduCls_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objCurrEduClsENS:源对象
     * @param objCurrEduClsENT:目标对象
    */
    function CurrEduCls_GetObjFromJsonObj(objCurrEduClsENS) {
        const objCurrEduClsENT = new clsCurrEduClsEN_js_1.clsCurrEduClsEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objCurrEduClsENT, objCurrEduClsENS);
        return objCurrEduClsENT;
    }
    exports.CurrEduCls_GetObjFromJsonObj = CurrEduCls_GetObjFromJsonObj;
});
