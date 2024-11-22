/**
* 类名:clsCurrEduClsTeacherWApi
* 表名:CurrEduClsTeacher(01120124)
* 生成代码版本:2022.11.02.1
* 生成日期:2022/11/02 11:46:09
* 生成者:pyf
* 生成服务器IP:
工程名称:问卷调查(0112)
CM工程:研究生论文学习(变量首字母小写)-全部函数集
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
        define(["require", "exports", "axios", "../../PubFun/CacheHelper.js", "../../L0_Entity/DailyRunning/clsCurrEduClsTeacherEN.js", "../../L3_ForWApi/DailyRunning/clsvCurrEduClsTeacherWApi.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsSysPara4WebApi.js", "../../PubFun/CacheHelper.js", "../../PubFun/jsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.CurrEduClsTeacher_GetObjFromJsonObj = exports.CurrEduClsTeacher_CopyObjTo = exports.CurrEduClsTeacher_GetUniCondStr4Update_id_CurrEduCls_id_Teacher = exports.CurrEduClsTeacher_GetUniCondStr_id_CurrEduCls_id_Teacher = exports.CurrEduClsTeacher_GetCombineCondition = exports.CurrEduClsTeacher_GetObjByJSONStr = exports.CurrEduClsTeacher_GetObjLstByJSONObjLst = exports.CurrEduClsTeacher_GetObjLstByJSONStr = exports.CurrEduClsTeacher_GetJSONStrByObj = exports.CurrEduClsTeacher_CheckProperty4Update = exports.CurrEduClsTeacher_CheckPropertyNew = exports.CurrEduClsTeacher_ReFreshThisCache = exports.CurrEduClsTeacher_ReFreshCache = exports.CurrEduClsTeacher_GetWebApiUrl = exports.CurrEduClsTeacher_GetMaxStrIdByPrefix = exports.CurrEduClsTeacher_GetRecCountByCond_Cache = exports.CurrEduClsTeacher_GetRecCountByCondAsync = exports.CurrEduClsTeacher_IsExistAsync = exports.CurrEduClsTeacher_IsExist_Cache = exports.CurrEduClsTeacher_IsExist = exports.CurrEduClsTeacher_IsExistRecordAsync = exports.CurrEduClsTeacher_IsExistRecord_Cache = exports.CurrEduClsTeacher_UpdateWithConditionAsync = exports.CurrEduClsTeacher_UpdateRecordAsync = exports.CurrEduClsTeacher_AddNewRecordWithReturnKey = exports.CurrEduClsTeacher_AddNewRecordWithReturnKeyAsync = exports.CurrEduClsTeacher_ReOrderAsync = exports.CurrEduClsTeacher_GoBottomAsync = exports.CurrEduClsTeacher_DownMoveAsync = exports.CurrEduClsTeacher_UpMoveAsync = exports.CurrEduClsTeacher_GoTopAsync = exports.CurrEduClsTeacher_AddNewRecordAsync = exports.CurrEduClsTeacher_DelCurrEduClsTeachersByCondAsync = exports.CurrEduClsTeacher_DelCurrEduClsTeachersAsync = exports.CurrEduClsTeacher_DelRecordAsync = exports.CurrEduClsTeacher_GetObjLstByPagerAsync = exports.CurrEduClsTeacher_GetObjLstByPager_Cache = exports.CurrEduClsTeacher_GetObjLstByRange = exports.CurrEduClsTeacher_GetObjLstByRangeAsync = exports.CurrEduClsTeacher_GetTopObjLstAsync = exports.CurrEduClsTeacher_GetObjLstByid_EduClsTeacherLst_Cache = exports.CurrEduClsTeacher_GetObjLstByid_EduClsTeacherLstAsync = exports.CurrEduClsTeacher_GetSubObjLst_Cache = exports.CurrEduClsTeacher_GetObjLst_PureCache = exports.CurrEduClsTeacher_GetObjLst_Cache = exports.CurrEduClsTeacher_GetObjLst_sessionStorage_PureCache = exports.CurrEduClsTeacher_GetObjLst_sessionStorage = exports.CurrEduClsTeacher_GetObjLstAsync = exports.CurrEduClsTeacher_GetObjLst_localStorage_PureCache = exports.CurrEduClsTeacher_GetObjLst_localStorage = exports.CurrEduClsTeacher_GetObjLst_ClientCache = exports.CurrEduClsTeacher_GetFirstObjAsync = exports.CurrEduClsTeacher_GetFirstID = exports.CurrEduClsTeacher_GetFirstIDAsync = exports.CurrEduClsTeacher_FilterFunByKey = exports.CurrEduClsTeacher_SortFunByKey = exports.CurrEduClsTeacher_SortFun_Defa_2Fld = exports.CurrEduClsTeacher_SortFun_Defa = exports.CurrEduClsTeacher_func = exports.CurrEduClsTeacher_UpdateObjInLst_Cache = exports.CurrEduClsTeacher_GetObjByid_EduClsTeacher_localStorage = exports.CurrEduClsTeacher_GetObjByid_EduClsTeacher_Cache = exports.CurrEduClsTeacher_GetObjByid_EduClsTeacherAsync = exports.currEduClsTeacher_ConstructorName = exports.currEduClsTeacher_Controller = void 0;
    /**
     * 当前教学班教师(CurrEduClsTeacher)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2022年11月02日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsCurrEduClsTeacherEN_js_1 = require("../../L0_Entity/DailyRunning/clsCurrEduClsTeacherEN.js");
    const clsvCurrEduClsTeacherWApi_js_1 = require("../../L3_ForWApi/DailyRunning/clsvCurrEduClsTeacherWApi.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    const CacheHelper_js_2 = require("../../PubFun/CacheHelper.js");
    const jsString_js_1 = require("../../PubFun/jsString.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.currEduClsTeacher_Controller = "CurrEduClsTeacherApi";
    exports.currEduClsTeacher_ConstructorName = "currEduClsTeacher";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param lngid_EduClsTeacher:关键字
    * @returns 对象
    **/
    async function CurrEduClsTeacher_GetObjByid_EduClsTeacherAsync(lngid_EduClsTeacher) {
        const strThisFuncName = "GetObjByid_EduClsTeacherAsync";
        if (lngid_EduClsTeacher == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngid_EduClsTeacher]不能为空！(In GetObjByid_EduClsTeacherAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByid_EduClsTeacher";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.currEduClsTeacher_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "lngid_EduClsTeacher": lngid_EduClsTeacher,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.currEduClsTeacher_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objCurrEduClsTeacher = CurrEduClsTeacher_GetObjFromJsonObj(returnObj);
                return objCurrEduClsTeacher;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.currEduClsTeacher_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.currEduClsTeacher_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CurrEduClsTeacher_GetObjByid_EduClsTeacherAsync = CurrEduClsTeacher_GetObjByid_EduClsTeacherAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param lngid_EduClsTeacher:所给的关键字
     * @returns 对象
    */
    async function CurrEduClsTeacher_GetObjByid_EduClsTeacher_Cache(lngid_EduClsTeacher, strid_CurrEduCls, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByid_EduClsTeacher_Cache";
        if (lngid_EduClsTeacher == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngid_EduClsTeacher]不能为空！(In GetObjByid_EduClsTeacher_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        const arrCurrEduClsTeacherObjLst_Cache = await CurrEduClsTeacher_GetObjLst_Cache(strid_CurrEduCls);
        try {
            const arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacherObjLst_Cache.filter(x => x.id_EduClsTeacher == lngid_EduClsTeacher);
            let objCurrEduClsTeacher;
            if (arrCurrEduClsTeacher_Sel.length > 0) {
                objCurrEduClsTeacher = arrCurrEduClsTeacher_Sel[0];
                return objCurrEduClsTeacher;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    objCurrEduClsTeacher = await CurrEduClsTeacher_GetObjByid_EduClsTeacherAsync(lngid_EduClsTeacher);
                    if (objCurrEduClsTeacher != null) {
                        CurrEduClsTeacher_ReFreshThisCache(strid_CurrEduCls);
                        return objCurrEduClsTeacher;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngid_EduClsTeacher, exports.currEduClsTeacher_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.CurrEduClsTeacher_GetObjByid_EduClsTeacher_Cache = CurrEduClsTeacher_GetObjByid_EduClsTeacher_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param lngid_EduClsTeacher:所给的关键字
     * @returns 对象
    */
    async function CurrEduClsTeacher_GetObjByid_EduClsTeacher_localStorage(lngid_EduClsTeacher) {
        const strThisFuncName = "GetObjByid_EduClsTeacher_localStorage";
        if (lngid_EduClsTeacher == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngid_EduClsTeacher]不能为空！(In GetObjByid_EduClsTeacher_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsCurrEduClsTeacherEN_js_1.clsCurrEduClsTeacherEN._CurrTabName, lngid_EduClsTeacher);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objCurrEduClsTeacher_Cache = JSON.parse(strTempObj);
            return objCurrEduClsTeacher_Cache;
        }
        try {
            const objCurrEduClsTeacher = await CurrEduClsTeacher_GetObjByid_EduClsTeacherAsync(lngid_EduClsTeacher);
            if (objCurrEduClsTeacher != null) {
                localStorage.setItem(strKey, JSON.stringify(objCurrEduClsTeacher));
                const strInfo = (0, clsString_js_1.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objCurrEduClsTeacher;
            }
            return objCurrEduClsTeacher;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngid_EduClsTeacher, exports.currEduClsTeacher_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.CurrEduClsTeacher_GetObjByid_EduClsTeacher_localStorage = CurrEduClsTeacher_GetObjByid_EduClsTeacher_localStorage;
    /**
     * 修改在缓存对象列表中的对象, 与后台数据库无关.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
     * @param objCurrEduClsTeacher:所给的对象
     * @returns 对象
    */
    async function CurrEduClsTeacher_UpdateObjInLst_Cache(objCurrEduClsTeacher, strid_CurrEduCls) {
        const strThisFuncName = "UpdateObjInLst_Cache";
        try {
            const arrCurrEduClsTeacherObjLst_Cache = await CurrEduClsTeacher_GetObjLst_Cache(strid_CurrEduCls);
            const obj = arrCurrEduClsTeacherObjLst_Cache.find(x => x.id_CurrEduCls == objCurrEduClsTeacher.id_CurrEduCls && x.id_Teacher == objCurrEduClsTeacher.id_Teacher);
            if (obj != null) {
                objCurrEduClsTeacher.id_EduClsTeacher = obj.id_EduClsTeacher;
                (0, clsCommFunc4Web_js_1.ObjectAssign)(obj, objCurrEduClsTeacher);
            }
            else {
                arrCurrEduClsTeacherObjLst_Cache.push(objCurrEduClsTeacher);
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, exports.currEduClsTeacher_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.CurrEduClsTeacher_UpdateObjInLst_Cache = CurrEduClsTeacher_UpdateObjInLst_Cache;
    /*该表没有名称字段，不能生成此函数！*/
    /**
     * 映射函数。根据表映射把输入字段值，映射成输出字段值
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_func)
     * @param strInFldName:输入字段名
     * @param strOutFldName:输出字段名
     * @param strInValue:输入字段值
     @param strid_CurrEduCls:缓存的分类字段
     * @returns 返回一个输出字段值
    */
    async function CurrEduClsTeacher_func(strInFldName, strOutFldName, strInValue, strid_CurrEduCls_C) {
        //const strThisFuncName = "func";
        if ((0, clsString_js_1.IsNullOrEmpty)(strid_CurrEduCls_C) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strid_CurrEduCls_C]不能为空！(In func)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls_C.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strid_CurrEduCls_C]的长度:[{0}]不正确！", strid_CurrEduCls_C.length);
            console.error(strMsg);
            throw (strMsg);
        }
        if (strInFldName != clsCurrEduClsTeacherEN_js_1.clsCurrEduClsTeacherEN.con_id_EduClsTeacher) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsCurrEduClsTeacherEN_js_1.clsCurrEduClsTeacherEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_1.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strInFldName, clsCurrEduClsTeacherEN_js_1.clsCurrEduClsTeacherEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const lngid_EduClsTeacher = Number(strInValue);
        if (lngid_EduClsTeacher == 0) {
            return "";
        }
        const objCurrEduClsTeacher = await CurrEduClsTeacher_GetObjByid_EduClsTeacher_Cache(lngid_EduClsTeacher, strid_CurrEduCls_C);
        if (objCurrEduClsTeacher == null)
            return "";
        return objCurrEduClsTeacher.GetFldValue(strOutFldName).toString();
    }
    exports.CurrEduClsTeacher_func = CurrEduClsTeacher_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function CurrEduClsTeacher_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.id_EduClsTeacher - b.id_EduClsTeacher;
    }
    exports.CurrEduClsTeacher_SortFun_Defa = CurrEduClsTeacher_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function CurrEduClsTeacher_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.id_CurrEduCls == b.id_CurrEduCls)
            return a.id_Teacher.localeCompare(b.id_Teacher);
        else
            return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
    }
    exports.CurrEduClsTeacher_SortFun_Defa_2Fld = CurrEduClsTeacher_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function CurrEduClsTeacher_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsCurrEduClsTeacherEN_js_1.clsCurrEduClsTeacherEN.con_id_EduClsTeacher:
                    return (a, b) => {
                        return a.id_EduClsTeacher - b.id_EduClsTeacher;
                    };
                case clsCurrEduClsTeacherEN_js_1.clsCurrEduClsTeacherEN.con_id_CurrEduCls:
                    return (a, b) => {
                        return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
                    };
                case clsCurrEduClsTeacherEN_js_1.clsCurrEduClsTeacherEN.con_id_Teacher:
                    return (a, b) => {
                        return a.id_Teacher.localeCompare(b.id_Teacher);
                    };
                case clsCurrEduClsTeacherEN_js_1.clsCurrEduClsTeacherEN.con_id_Pk2EduClsTeacherType:
                    return (a, b) => {
                        return a.id_Pk2EduClsTeacherType.localeCompare(b.id_Pk2EduClsTeacherType);
                    };
                case clsCurrEduClsTeacherEN_js_1.clsCurrEduClsTeacherEN.con_SchoolTerm:
                    return (a, b) => {
                        return a.schoolTerm.localeCompare(b.schoolTerm);
                    };
                case clsCurrEduClsTeacherEN_js_1.clsCurrEduClsTeacherEN.con_SchoolYear:
                    return (a, b) => {
                        return a.schoolYear.localeCompare(b.schoolYear);
                    };
                case clsCurrEduClsTeacherEN_js_1.clsCurrEduClsTeacherEN.con_OpenBeginDate:
                    return (a, b) => {
                        return a.openBeginDate.localeCompare(b.openBeginDate);
                    };
                case clsCurrEduClsTeacherEN_js_1.clsCurrEduClsTeacherEN.con_OpenEndDate:
                    return (a, b) => {
                        return a.openEndDate.localeCompare(b.openEndDate);
                    };
                case clsCurrEduClsTeacherEN_js_1.clsCurrEduClsTeacherEN.con_OrderNum:
                    return (a, b) => {
                        return a.orderNum - b.orderNum;
                    };
                case clsCurrEduClsTeacherEN_js_1.clsCurrEduClsTeacherEN.con_UpdDate:
                    return (a, b) => {
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsCurrEduClsTeacherEN_js_1.clsCurrEduClsTeacherEN.con_UpdUser:
                    return (a, b) => {
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsCurrEduClsTeacherEN_js_1.clsCurrEduClsTeacherEN.con_Memo:
                    return (a, b) => {
                        return a.memo.localeCompare(b.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[CurrEduClsTeacher]中不存在！(in ${exports.currEduClsTeacher_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsCurrEduClsTeacherEN_js_1.clsCurrEduClsTeacherEN.con_id_EduClsTeacher:
                    return (a, b) => {
                        return b.id_EduClsTeacher - a.id_EduClsTeacher;
                    };
                case clsCurrEduClsTeacherEN_js_1.clsCurrEduClsTeacherEN.con_id_CurrEduCls:
                    return (a, b) => {
                        return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
                    };
                case clsCurrEduClsTeacherEN_js_1.clsCurrEduClsTeacherEN.con_id_Teacher:
                    return (a, b) => {
                        return b.id_Teacher.localeCompare(a.id_Teacher);
                    };
                case clsCurrEduClsTeacherEN_js_1.clsCurrEduClsTeacherEN.con_id_Pk2EduClsTeacherType:
                    return (a, b) => {
                        return b.id_Pk2EduClsTeacherType.localeCompare(a.id_Pk2EduClsTeacherType);
                    };
                case clsCurrEduClsTeacherEN_js_1.clsCurrEduClsTeacherEN.con_SchoolTerm:
                    return (a, b) => {
                        return b.schoolTerm.localeCompare(a.schoolTerm);
                    };
                case clsCurrEduClsTeacherEN_js_1.clsCurrEduClsTeacherEN.con_SchoolYear:
                    return (a, b) => {
                        return b.schoolYear.localeCompare(a.schoolYear);
                    };
                case clsCurrEduClsTeacherEN_js_1.clsCurrEduClsTeacherEN.con_OpenBeginDate:
                    return (a, b) => {
                        return b.openBeginDate.localeCompare(a.openBeginDate);
                    };
                case clsCurrEduClsTeacherEN_js_1.clsCurrEduClsTeacherEN.con_OpenEndDate:
                    return (a, b) => {
                        return b.openEndDate.localeCompare(a.openEndDate);
                    };
                case clsCurrEduClsTeacherEN_js_1.clsCurrEduClsTeacherEN.con_OrderNum:
                    return (a, b) => {
                        return b.orderNum - a.orderNum;
                    };
                case clsCurrEduClsTeacherEN_js_1.clsCurrEduClsTeacherEN.con_UpdDate:
                    return (a, b) => {
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsCurrEduClsTeacherEN_js_1.clsCurrEduClsTeacherEN.con_UpdUser:
                    return (a, b) => {
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsCurrEduClsTeacherEN_js_1.clsCurrEduClsTeacherEN.con_Memo:
                    return (a, b) => {
                        return b.memo.localeCompare(a.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[CurrEduClsTeacher]中不存在！(in ${exports.currEduClsTeacher_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.CurrEduClsTeacher_SortFunByKey = CurrEduClsTeacher_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function CurrEduClsTeacher_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsCurrEduClsTeacherEN_js_1.clsCurrEduClsTeacherEN.con_id_EduClsTeacher:
                return (obj) => {
                    return obj.id_EduClsTeacher === value;
                };
            case clsCurrEduClsTeacherEN_js_1.clsCurrEduClsTeacherEN.con_id_CurrEduCls:
                return (obj) => {
                    return obj.id_CurrEduCls === value;
                };
            case clsCurrEduClsTeacherEN_js_1.clsCurrEduClsTeacherEN.con_id_Teacher:
                return (obj) => {
                    return obj.id_Teacher === value;
                };
            case clsCurrEduClsTeacherEN_js_1.clsCurrEduClsTeacherEN.con_id_Pk2EduClsTeacherType:
                return (obj) => {
                    return obj.id_Pk2EduClsTeacherType === value;
                };
            case clsCurrEduClsTeacherEN_js_1.clsCurrEduClsTeacherEN.con_SchoolTerm:
                return (obj) => {
                    return obj.schoolTerm === value;
                };
            case clsCurrEduClsTeacherEN_js_1.clsCurrEduClsTeacherEN.con_SchoolYear:
                return (obj) => {
                    return obj.schoolYear === value;
                };
            case clsCurrEduClsTeacherEN_js_1.clsCurrEduClsTeacherEN.con_OpenBeginDate:
                return (obj) => {
                    return obj.openBeginDate === value;
                };
            case clsCurrEduClsTeacherEN_js_1.clsCurrEduClsTeacherEN.con_OpenEndDate:
                return (obj) => {
                    return obj.openEndDate === value;
                };
            case clsCurrEduClsTeacherEN_js_1.clsCurrEduClsTeacherEN.con_OrderNum:
                return (obj) => {
                    return obj.orderNum === value;
                };
            case clsCurrEduClsTeacherEN_js_1.clsCurrEduClsTeacherEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsCurrEduClsTeacherEN_js_1.clsCurrEduClsTeacherEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsCurrEduClsTeacherEN_js_1.clsCurrEduClsTeacherEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[CurrEduClsTeacher]中不存在！(in ${exports.currEduClsTeacher_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.CurrEduClsTeacher_FilterFunByKey = CurrEduClsTeacher_FilterFunByKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function CurrEduClsTeacher_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.currEduClsTeacher_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.currEduClsTeacher_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.currEduClsTeacher_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CurrEduClsTeacher_GetFirstIDAsync = CurrEduClsTeacher_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function CurrEduClsTeacher_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.currEduClsTeacher_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.currEduClsTeacher_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.currEduClsTeacher_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CurrEduClsTeacher_GetFirstID = CurrEduClsTeacher_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function CurrEduClsTeacher_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.currEduClsTeacher_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.currEduClsTeacher_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objCurrEduClsTeacher = CurrEduClsTeacher_GetObjFromJsonObj(returnObj);
                return objCurrEduClsTeacher;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.currEduClsTeacher_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.currEduClsTeacher_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CurrEduClsTeacher_GetFirstObjAsync = CurrEduClsTeacher_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function CurrEduClsTeacher_GetObjLst_ClientCache(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsCurrEduClsTeacherEN_js_1.clsCurrEduClsTeacherEN._CurrTabName, strid_CurrEduCls);
        clsCurrEduClsTeacherEN_js_1.clsCurrEduClsTeacherEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsCurrEduClsTeacherEN_js_1.clsCurrEduClsTeacherEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsCurrEduClsTeacherEN_js_1.clsCurrEduClsTeacherEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsCurrEduClsTeacherEN_js_1.clsCurrEduClsTeacherEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_2.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrCurrEduClsTeacherExObjLst_Cache = CacheHelper_js_2.CacheHelper.Get(strKey);
            const arrCurrEduClsTeacherObjLst_T = CurrEduClsTeacher_GetObjLstByJSONObjLst(arrCurrEduClsTeacherExObjLst_Cache);
            return arrCurrEduClsTeacherObjLst_T;
        }
        try {
            const arrCurrEduClsTeacherExObjLst = await CurrEduClsTeacher_GetObjLstAsync(strWhereCond);
            CacheHelper_js_2.CacheHelper.Add(strKey, arrCurrEduClsTeacherExObjLst);
            const strInfo = (0, clsString_js_1.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrCurrEduClsTeacherExObjLst.length);
            console.log(strInfo);
            return arrCurrEduClsTeacherExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.currEduClsTeacher_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.CurrEduClsTeacher_GetObjLst_ClientCache = CurrEduClsTeacher_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function CurrEduClsTeacher_GetObjLst_localStorage(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsCurrEduClsTeacherEN_js_1.clsCurrEduClsTeacherEN._CurrTabName, strid_CurrEduCls);
        clsCurrEduClsTeacherEN_js_1.clsCurrEduClsTeacherEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsCurrEduClsTeacherEN_js_1.clsCurrEduClsTeacherEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsCurrEduClsTeacherEN_js_1.clsCurrEduClsTeacherEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsCurrEduClsTeacherEN_js_1.clsCurrEduClsTeacherEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrCurrEduClsTeacherExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrCurrEduClsTeacherObjLst_T = CurrEduClsTeacher_GetObjLstByJSONObjLst(arrCurrEduClsTeacherExObjLst_Cache);
            return arrCurrEduClsTeacherObjLst_T;
        }
        try {
            const arrCurrEduClsTeacherExObjLst = await CurrEduClsTeacher_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrCurrEduClsTeacherExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrCurrEduClsTeacherExObjLst.length);
            console.log(strInfo);
            return arrCurrEduClsTeacherExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.currEduClsTeacher_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.CurrEduClsTeacher_GetObjLst_localStorage = CurrEduClsTeacher_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function CurrEduClsTeacher_GetObjLst_localStorage_PureCache(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsCurrEduClsTeacherEN_js_1.clsCurrEduClsTeacherEN._CurrTabName, strid_CurrEduCls);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrCurrEduClsTeacherObjLst_Cache = JSON.parse(strTempObjLst);
            return arrCurrEduClsTeacherObjLst_Cache;
        }
        else
            return null;
    }
    exports.CurrEduClsTeacher_GetObjLst_localStorage_PureCache = CurrEduClsTeacher_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function CurrEduClsTeacher_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.currEduClsTeacher_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.currEduClsTeacher_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = CurrEduClsTeacher_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.currEduClsTeacher_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.currEduClsTeacher_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CurrEduClsTeacher_GetObjLstAsync = CurrEduClsTeacher_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function CurrEduClsTeacher_GetObjLst_sessionStorage(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsCurrEduClsTeacherEN_js_1.clsCurrEduClsTeacherEN._CurrTabName, strid_CurrEduCls);
        clsCurrEduClsTeacherEN_js_1.clsCurrEduClsTeacherEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsCurrEduClsTeacherEN_js_1.clsCurrEduClsTeacherEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsCurrEduClsTeacherEN_js_1.clsCurrEduClsTeacherEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsCurrEduClsTeacherEN_js_1.clsCurrEduClsTeacherEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrCurrEduClsTeacherExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrCurrEduClsTeacherObjLst_T = CurrEduClsTeacher_GetObjLstByJSONObjLst(arrCurrEduClsTeacherExObjLst_Cache);
            return arrCurrEduClsTeacherObjLst_T;
        }
        try {
            const arrCurrEduClsTeacherExObjLst = await CurrEduClsTeacher_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrCurrEduClsTeacherExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrCurrEduClsTeacherExObjLst.length);
            console.log(strInfo);
            return arrCurrEduClsTeacherExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.currEduClsTeacher_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.CurrEduClsTeacher_GetObjLst_sessionStorage = CurrEduClsTeacher_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function CurrEduClsTeacher_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsCurrEduClsTeacherEN_js_1.clsCurrEduClsTeacherEN._CurrTabName, strid_CurrEduCls);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrCurrEduClsTeacherObjLst_Cache = JSON.parse(strTempObjLst);
            return arrCurrEduClsTeacherObjLst_Cache;
        }
        else
            return null;
    }
    exports.CurrEduClsTeacher_GetObjLst_sessionStorage_PureCache = CurrEduClsTeacher_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function CurrEduClsTeacher_GetObjLst_Cache(strid_CurrEduCls) {
        //const strThisFuncName = "GetObjLst_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strid_CurrEduCls) == true) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[id_CurrEduCls]不能为空！");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strid_CurrEduCls]的长度:[{0}]不正确！", strid_CurrEduCls.length);
            console.error(strMsg);
            throw (strMsg);
        }
        let arrCurrEduClsTeacherObjLst_Cache;
        switch (clsCurrEduClsTeacherEN_js_1.clsCurrEduClsTeacherEN.CacheModeId) {
            case "04": //sessionStorage
                arrCurrEduClsTeacherObjLst_Cache = await CurrEduClsTeacher_GetObjLst_sessionStorage(strid_CurrEduCls);
                break;
            case "03": //localStorage
                arrCurrEduClsTeacherObjLst_Cache = await CurrEduClsTeacher_GetObjLst_localStorage(strid_CurrEduCls);
                break;
            case "02": //ClientCache
                arrCurrEduClsTeacherObjLst_Cache = await CurrEduClsTeacher_GetObjLst_ClientCache(strid_CurrEduCls);
                break;
            default:
                arrCurrEduClsTeacherObjLst_Cache = await CurrEduClsTeacher_GetObjLst_ClientCache(strid_CurrEduCls);
                break;
        }
        const arrCurrEduClsTeacherObjLst = CurrEduClsTeacher_GetObjLstByJSONObjLst(arrCurrEduClsTeacherObjLst_Cache);
        return arrCurrEduClsTeacherObjLst_Cache;
    }
    exports.CurrEduClsTeacher_GetObjLst_Cache = CurrEduClsTeacher_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function CurrEduClsTeacher_GetObjLst_PureCache(strid_CurrEduCls) {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrCurrEduClsTeacherObjLst_Cache;
        switch (clsCurrEduClsTeacherEN_js_1.clsCurrEduClsTeacherEN.CacheModeId) {
            case "04": //sessionStorage
                arrCurrEduClsTeacherObjLst_Cache = await CurrEduClsTeacher_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls);
                break;
            case "03": //localStorage
                arrCurrEduClsTeacherObjLst_Cache = await CurrEduClsTeacher_GetObjLst_localStorage_PureCache(strid_CurrEduCls);
                break;
            case "02": //ClientCache
                arrCurrEduClsTeacherObjLst_Cache = null;
                break;
            default:
                arrCurrEduClsTeacherObjLst_Cache = null;
                break;
        }
        return arrCurrEduClsTeacherObjLst_Cache;
    }
    exports.CurrEduClsTeacher_GetObjLst_PureCache = CurrEduClsTeacher_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objlngid_EduClsTeacher_Cond:条件对象
     * @returns 对象列表子集
    */
    async function CurrEduClsTeacher_GetSubObjLst_Cache(objCurrEduClsTeacher_Cond, strid_CurrEduCls) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrCurrEduClsTeacherObjLst_Cache = await CurrEduClsTeacher_GetObjLst_Cache(strid_CurrEduCls);
        let arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacherObjLst_Cache;
        if (objCurrEduClsTeacher_Cond.sf_FldComparisonOp == null || objCurrEduClsTeacher_Cond.sf_FldComparisonOp == "")
            return arrCurrEduClsTeacher_Sel;
        const dicFldComparisonOp = JSON.parse(objCurrEduClsTeacher_Cond.sf_FldComparisonOp);
        //console.log("clsCurrEduClsTeacherWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objCurrEduClsTeacher_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objCurrEduClsTeacher_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrCurrEduClsTeacher_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objCurrEduClsTeacher_Cond), exports.currEduClsTeacher_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.CurrEduClsTeacher_GetSubObjLst_Cache = CurrEduClsTeacher_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrid_EduClsTeacher:关键字列表
    * @returns 对象列表
    **/
    async function CurrEduClsTeacher_GetObjLstByid_EduClsTeacherLstAsync(arrid_EduClsTeacher) {
        const strThisFuncName = "GetObjLstByid_EduClsTeacherLstAsync";
        const strAction = "GetObjLstByid_EduClsTeacherLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.currEduClsTeacher_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrid_EduClsTeacher);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.currEduClsTeacher_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = CurrEduClsTeacher_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.currEduClsTeacher_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.currEduClsTeacher_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CurrEduClsTeacher_GetObjLstByid_EduClsTeacherLstAsync = CurrEduClsTeacher_GetObjLstByid_EduClsTeacherLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrlngid_EduClsTeacherLst:关键字列表
     * @returns 对象列表
    */
    async function CurrEduClsTeacher_GetObjLstByid_EduClsTeacherLst_Cache(arrid_EduClsTeacherLst, strid_CurrEduCls) {
        const strThisFuncName = "GetObjLstByid_EduClsTeacherLst_Cache";
        try {
            const arrCurrEduClsTeacherObjLst_Cache = await CurrEduClsTeacher_GetObjLst_Cache(strid_CurrEduCls);
            const arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacherObjLst_Cache.filter(x => arrid_EduClsTeacherLst.indexOf(x.id_EduClsTeacher) > -1);
            return arrCurrEduClsTeacher_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrid_EduClsTeacherLst.join(","), exports.currEduClsTeacher_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.CurrEduClsTeacher_GetObjLstByid_EduClsTeacherLst_Cache = CurrEduClsTeacher_GetObjLstByid_EduClsTeacherLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function CurrEduClsTeacher_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.currEduClsTeacher_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.currEduClsTeacher_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = CurrEduClsTeacher_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.currEduClsTeacher_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.currEduClsTeacher_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CurrEduClsTeacher_GetTopObjLstAsync = CurrEduClsTeacher_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function CurrEduClsTeacher_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.currEduClsTeacher_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.currEduClsTeacher_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = CurrEduClsTeacher_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.currEduClsTeacher_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.currEduClsTeacher_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CurrEduClsTeacher_GetObjLstByRangeAsync = CurrEduClsTeacher_GetObjLstByRangeAsync;
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
    async function CurrEduClsTeacher_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.currEduClsTeacher_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.currEduClsTeacher_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.currEduClsTeacher_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CurrEduClsTeacher_GetObjLstByRange = CurrEduClsTeacher_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function CurrEduClsTeacher_GetObjLstByPager_Cache(objPagerPara, strid_CurrEduCls) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const arrCurrEduClsTeacherObjLst_Cache = await CurrEduClsTeacher_GetObjLst_Cache(strid_CurrEduCls);
        if (arrCurrEduClsTeacherObjLst_Cache.length == 0)
            return arrCurrEduClsTeacherObjLst_Cache;
        let arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacherObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objCurrEduClsTeacher_Cond = new clsCurrEduClsTeacherEN_js_1.clsCurrEduClsTeacherEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objCurrEduClsTeacher_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsCurrEduClsTeacherWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objCurrEduClsTeacher_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrCurrEduClsTeacher_Sel.length == 0)
                return arrCurrEduClsTeacher_Sel;
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
                arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.sort(CurrEduClsTeacher_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.sort(objPagerPara.sortFun);
            }
            arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.slice(intStart, intEnd);
            return arrCurrEduClsTeacher_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.currEduClsTeacher_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.CurrEduClsTeacher_GetObjLstByPager_Cache = CurrEduClsTeacher_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function CurrEduClsTeacher_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.currEduClsTeacher_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.currEduClsTeacher_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = CurrEduClsTeacher_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.currEduClsTeacher_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.currEduClsTeacher_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CurrEduClsTeacher_GetObjLstByPagerAsync = CurrEduClsTeacher_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param lngid_EduClsTeacher:关键字
    * @returns 获取删除的结果
    **/
    async function CurrEduClsTeacher_DelRecordAsync(lngid_EduClsTeacher) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.currEduClsTeacher_Controller, strAction);
        strUrl = (0, clsString_js_1.Format)("{0}/?Id={1}", strUrl, lngid_EduClsTeacher);
        try {
            const response = await axios_1.default.delete(strUrl, {
                params: { "Id": lngid_EduClsTeacher, }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.currEduClsTeacher_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.currEduClsTeacher_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CurrEduClsTeacher_DelRecordAsync = CurrEduClsTeacher_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrid_EduClsTeacher:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function CurrEduClsTeacher_DelCurrEduClsTeachersAsync(arrid_EduClsTeacher) {
        const strThisFuncName = "DelCurrEduClsTeachersAsync";
        const strAction = "DelCurrEduClsTeachers";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.currEduClsTeacher_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrid_EduClsTeacher);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.currEduClsTeacher_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.currEduClsTeacher_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CurrEduClsTeacher_DelCurrEduClsTeachersAsync = CurrEduClsTeacher_DelCurrEduClsTeachersAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function CurrEduClsTeacher_DelCurrEduClsTeachersByCondAsync(strWhereCond) {
        const strThisFuncName = "DelCurrEduClsTeachersByCondAsync";
        const strAction = "DelCurrEduClsTeachersByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.currEduClsTeacher_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.currEduClsTeacher_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.currEduClsTeacher_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CurrEduClsTeacher_DelCurrEduClsTeachersByCondAsync = CurrEduClsTeacher_DelCurrEduClsTeachersByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objCurrEduClsTeacherEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function CurrEduClsTeacher_AddNewRecordAsync(objCurrEduClsTeacherEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objCurrEduClsTeacherEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.currEduClsTeacher_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objCurrEduClsTeacherEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.currEduClsTeacher_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.currEduClsTeacher_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CurrEduClsTeacher_AddNewRecordAsync = CurrEduClsTeacher_AddNewRecordAsync;
    /* 数据类型不是字符型，不可以最大关键字的方式添加记录。*/
    /**
    * 把所给的关键字列表相关的记录移顶
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GoTopAsync)
    * @param objCurrEduClsTeacherEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function CurrEduClsTeacher_GoTopAsync(objOrderByData) {
        const strThisFuncName = "GoTopAsync";
        let strMsg = "";
        const strAction = "GoTop";
        if (objOrderByData.KeyIdLst.length == 0) {
            strMsg = "根据关键字列表置顶时，给定的关键字值列表不能为空!";
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.currEduClsTeacher_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.currEduClsTeacher_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.currEduClsTeacher_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CurrEduClsTeacher_GoTopAsync = CurrEduClsTeacher_GoTopAsync;
    /**
    * 把所给的关键字列表相关的记录上移
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpMoveAsync)
    * @param objCurrEduClsTeacherEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function CurrEduClsTeacher_UpMoveAsync(objOrderByData) {
        const strThisFuncName = "UpMoveAsync";
        let strMsg = "";
        const strAction = "UpMove";
        if (objOrderByData.KeyIdLst.length == 0) {
            strMsg = "根据关键字列表上移时，给定的关键字值列表不能为空!";
            throw strMsg;
        }
        //var strJSON = JSON.stringify(objCurrEduClsTeacherEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.currEduClsTeacher_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.currEduClsTeacher_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.currEduClsTeacher_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CurrEduClsTeacher_UpMoveAsync = CurrEduClsTeacher_UpMoveAsync;
    /**
    * 把所给的关键字列表相关的记录下移
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DownMoveAsync)
    * @param objCurrEduClsTeacherEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function CurrEduClsTeacher_DownMoveAsync(objOrderByData) {
        const strThisFuncName = "DownMoveAsync";
        let strMsg = "";
        const strAction = "DownMove";
        if (objOrderByData.KeyIdLst.length == 0) {
            strMsg = "根据关键字列表下移时，给定的关键字值列表不能为空!";
            throw strMsg;
        }
        //var strJSON = JSON.stringify(objCurrEduClsTeacherEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.currEduClsTeacher_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.currEduClsTeacher_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.currEduClsTeacher_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CurrEduClsTeacher_DownMoveAsync = CurrEduClsTeacher_DownMoveAsync;
    /**
    * 把所给的关键字列表相关的记录移底
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GoBottomAsync)
    * @param objCurrEduClsTeacherEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function CurrEduClsTeacher_GoBottomAsync(objOrderByData) {
        const strThisFuncName = "GoBottomAsync";
        let strMsg = "";
        const strAction = "GoBottom";
        if (objOrderByData.KeyIdLst.length == 0) {
            strMsg = "根据关键字列表置底时，给定的关键字值列表不能为空!";
            throw strMsg;
        }
        //var strJSON = JSON.stringify(objCurrEduClsTeacherEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.currEduClsTeacher_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.currEduClsTeacher_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.currEduClsTeacher_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CurrEduClsTeacher_GoBottomAsync = CurrEduClsTeacher_GoBottomAsync;
    /**
    * 把列表记录重序
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReOrderAsync)
    * @param objCurrEduClsTeacherEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function CurrEduClsTeacher_ReOrderAsync(objOrderByData) {
        const strThisFuncName = "ReOrderAsync";
        const strAction = "ReOrder";
        //var strJSON = JSON.stringify(objCurrEduClsTeacherEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.currEduClsTeacher_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.currEduClsTeacher_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.currEduClsTeacher_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CurrEduClsTeacher_ReOrderAsync = CurrEduClsTeacher_ReOrderAsync;
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objCurrEduClsTeacherEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function CurrEduClsTeacher_AddNewRecordWithReturnKeyAsync(objCurrEduClsTeacherEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.currEduClsTeacher_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objCurrEduClsTeacherEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.currEduClsTeacher_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.currEduClsTeacher_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CurrEduClsTeacher_AddNewRecordWithReturnKeyAsync = CurrEduClsTeacher_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objCurrEduClsTeacherEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function CurrEduClsTeacher_AddNewRecordWithReturnKey(objCurrEduClsTeacherEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objCurrEduClsTeacherEN.id_EduClsTeacher === null || objCurrEduClsTeacherEN.id_EduClsTeacher === 0) {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.currEduClsTeacher_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objCurrEduClsTeacherEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.currEduClsTeacher_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.currEduClsTeacher_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CurrEduClsTeacher_AddNewRecordWithReturnKey = CurrEduClsTeacher_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objCurrEduClsTeacherEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function CurrEduClsTeacher_UpdateRecordAsync(objCurrEduClsTeacherEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objCurrEduClsTeacherEN.sf_UpdFldSetStr === undefined || objCurrEduClsTeacherEN.sf_UpdFldSetStr === null || objCurrEduClsTeacherEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objCurrEduClsTeacherEN.id_EduClsTeacher);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.currEduClsTeacher_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objCurrEduClsTeacherEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.currEduClsTeacher_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.currEduClsTeacher_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CurrEduClsTeacher_UpdateRecordAsync = CurrEduClsTeacher_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objCurrEduClsTeacherEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function CurrEduClsTeacher_UpdateWithConditionAsync(objCurrEduClsTeacherEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objCurrEduClsTeacherEN.sf_UpdFldSetStr === undefined || objCurrEduClsTeacherEN.sf_UpdFldSetStr === null || objCurrEduClsTeacherEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objCurrEduClsTeacherEN.id_EduClsTeacher);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.currEduClsTeacher_Controller, strAction);
        objCurrEduClsTeacherEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objCurrEduClsTeacherEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.currEduClsTeacher_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.currEduClsTeacher_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CurrEduClsTeacher_UpdateWithConditionAsync = CurrEduClsTeacher_UpdateWithConditionAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objlngid_EduClsTeacher_Cond:条件对象
     * @returns 对象列表子集
    */
    async function CurrEduClsTeacher_IsExistRecord_Cache(objCurrEduClsTeacher_Cond, strid_CurrEduCls) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrCurrEduClsTeacherObjLst_Cache = await CurrEduClsTeacher_GetObjLst_Cache(strid_CurrEduCls);
        if (arrCurrEduClsTeacherObjLst_Cache == null)
            return false;
        let arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacherObjLst_Cache;
        if (objCurrEduClsTeacher_Cond.sf_FldComparisonOp == null || objCurrEduClsTeacher_Cond.sf_FldComparisonOp == "")
            return arrCurrEduClsTeacher_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objCurrEduClsTeacher_Cond.sf_FldComparisonOp);
        //console.log("clsCurrEduClsTeacherWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objCurrEduClsTeacher_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objCurrEduClsTeacher_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrCurrEduClsTeacher_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objCurrEduClsTeacher_Cond), exports.currEduClsTeacher_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.CurrEduClsTeacher_IsExistRecord_Cache = CurrEduClsTeacher_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function CurrEduClsTeacher_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.currEduClsTeacher_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.currEduClsTeacher_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.currEduClsTeacher_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CurrEduClsTeacher_IsExistRecordAsync = CurrEduClsTeacher_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param lngid_EduClsTeacher:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function CurrEduClsTeacher_IsExist(lngid_EduClsTeacher, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.currEduClsTeacher_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "id_EduClsTeacher": lngid_EduClsTeacher,
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.currEduClsTeacher_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.currEduClsTeacher_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CurrEduClsTeacher_IsExist = CurrEduClsTeacher_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param lngid_EduClsTeacher:所给的关键字
     * @returns 对象
    */
    async function CurrEduClsTeacher_IsExist_Cache(lngid_EduClsTeacher, strid_CurrEduCls) {
        const strThisFuncName = "IsExist_Cache";
        const arrCurrEduClsTeacherObjLst_Cache = await CurrEduClsTeacher_GetObjLst_Cache(strid_CurrEduCls);
        if (arrCurrEduClsTeacherObjLst_Cache == null)
            return false;
        try {
            const arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacherObjLst_Cache.filter(x => x.id_EduClsTeacher == lngid_EduClsTeacher);
            if (arrCurrEduClsTeacher_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", lngid_EduClsTeacher, exports.currEduClsTeacher_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.CurrEduClsTeacher_IsExist_Cache = CurrEduClsTeacher_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param lngid_EduClsTeacher:关键字
    * @returns 是否存在?存在返回True
    **/
    async function CurrEduClsTeacher_IsExistAsync(lngid_EduClsTeacher) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.currEduClsTeacher_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "lngid_EduClsTeacher": lngid_EduClsTeacher }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.currEduClsTeacher_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.currEduClsTeacher_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CurrEduClsTeacher_IsExistAsync = CurrEduClsTeacher_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function CurrEduClsTeacher_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.currEduClsTeacher_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.currEduClsTeacher_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.currEduClsTeacher_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CurrEduClsTeacher_GetRecCountByCondAsync = CurrEduClsTeacher_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objCurrEduClsTeacher_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function CurrEduClsTeacher_GetRecCountByCond_Cache(objCurrEduClsTeacher_Cond, strid_CurrEduCls) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrCurrEduClsTeacherObjLst_Cache = await CurrEduClsTeacher_GetObjLst_Cache(strid_CurrEduCls);
        if (arrCurrEduClsTeacherObjLst_Cache == null)
            return 0;
        let arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacherObjLst_Cache;
        if (objCurrEduClsTeacher_Cond.sf_FldComparisonOp == null || objCurrEduClsTeacher_Cond.sf_FldComparisonOp == "")
            return arrCurrEduClsTeacher_Sel.length;
        const dicFldComparisonOp = JSON.parse(objCurrEduClsTeacher_Cond.sf_FldComparisonOp);
        //console.log("clsCurrEduClsTeacherWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objCurrEduClsTeacher_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objCurrEduClsTeacher_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrCurrEduClsTeacher_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objCurrEduClsTeacher_Cond), exports.currEduClsTeacher_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.CurrEduClsTeacher_GetRecCountByCond_Cache = CurrEduClsTeacher_GetRecCountByCond_Cache;
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
    async function CurrEduClsTeacher_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.currEduClsTeacher_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.currEduClsTeacher_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.currEduClsTeacher_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CurrEduClsTeacher_GetMaxStrIdByPrefix = CurrEduClsTeacher_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function CurrEduClsTeacher_GetWebApiUrl(strController, strAction) {
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
    exports.CurrEduClsTeacher_GetWebApiUrl = CurrEduClsTeacher_GetWebApiUrl;
    /**
    * 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshCache)
    **/
    function CurrEduClsTeacher_ReFreshCache(strid_CurrEduCls) {
        const strThisFuncName = "ReFreshCache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strid_CurrEduCls) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strid_CurrEduCls]不能为空！(In clsCurrEduClsTeacherWApi.ReFreshCache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strid_CurrEduCls]的长度:[{0}]不正确！", strid_CurrEduCls.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strMsg = (0, clsString_js_1.Format)("刷新缓存成功！");
        console.trace(strMsg);
        // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsCurrEduClsTeacherEN_js_1.clsCurrEduClsTeacherEN._CurrTabName, strid_CurrEduCls);
        switch (clsCurrEduClsTeacherEN_js_1.clsCurrEduClsTeacherEN.CacheModeId) {
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
        (0, clsvCurrEduClsTeacherWApi_js_1.vCurrEduClsTeacher_ReFreshThisCache)(strid_CurrEduCls);
    }
    exports.CurrEduClsTeacher_ReFreshCache = CurrEduClsTeacher_ReFreshCache;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function CurrEduClsTeacher_ReFreshThisCache(strid_CurrEduCls) {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsCurrEduClsTeacherEN_js_1.clsCurrEduClsTeacherEN._CurrTabName, strid_CurrEduCls);
            switch (clsCurrEduClsTeacherEN_js_1.clsCurrEduClsTeacherEN.CacheModeId) {
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
    exports.CurrEduClsTeacher_ReFreshThisCache = CurrEduClsTeacher_ReFreshThisCache;
    /* 该表的下拉框功能没有设置，不需要生成下拉框绑定函数。*/
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function CurrEduClsTeacher_CheckPropertyNew(pobjCurrEduClsTeacherEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjCurrEduClsTeacherEN.id_CurrEduCls) == false && (0, clsString_js_1.GetStrLen)(pobjCurrEduClsTeacherEN.id_CurrEduCls) > 8) {
            throw new Error("(errid:Watl000059)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 当前教学班教师(CurrEduClsTeacher))!值:$(pobjCurrEduClsTeacherEN.id_CurrEduCls)(clsCurrEduClsTeacherBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjCurrEduClsTeacherEN.id_Teacher) == false && (0, clsString_js_1.GetStrLen)(pobjCurrEduClsTeacherEN.id_Teacher) > 8) {
            throw new Error("(errid:Watl000059)字段[教师流水号(id_Teacher)]的长度不能超过8(In 当前教学班教师(CurrEduClsTeacher))!值:$(pobjCurrEduClsTeacherEN.id_Teacher)(clsCurrEduClsTeacherBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjCurrEduClsTeacherEN.id_Pk2EduClsTeacherType) == false && (0, clsString_js_1.GetStrLen)(pobjCurrEduClsTeacherEN.id_Pk2EduClsTeacherType) > 4) {
            throw new Error("(errid:Watl000059)字段[教学班老师角色(主讲,辅导)流水号(id_Pk2EduClsTeacherType)]的长度不能超过4(In 当前教学班教师(CurrEduClsTeacher))!值:$(pobjCurrEduClsTeacherEN.id_Pk2EduClsTeacherType)(clsCurrEduClsTeacherBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjCurrEduClsTeacherEN.schoolTerm) == false && (0, clsString_js_1.GetStrLen)(pobjCurrEduClsTeacherEN.schoolTerm) > 1) {
            throw new Error("(errid:Watl000059)字段[学期(schoolTerm)]的长度不能超过1(In 当前教学班教师(CurrEduClsTeacher))!值:$(pobjCurrEduClsTeacherEN.schoolTerm)(clsCurrEduClsTeacherBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjCurrEduClsTeacherEN.schoolYear) == false && (0, clsString_js_1.GetStrLen)(pobjCurrEduClsTeacherEN.schoolYear) > 10) {
            throw new Error("(errid:Watl000059)字段[学年(schoolYear)]的长度不能超过10(In 当前教学班教师(CurrEduClsTeacher))!值:$(pobjCurrEduClsTeacherEN.schoolYear)(clsCurrEduClsTeacherBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjCurrEduClsTeacherEN.openBeginDate) == false && (0, clsString_js_1.GetStrLen)(pobjCurrEduClsTeacherEN.openBeginDate) > 8) {
            throw new Error("(errid:Watl000059)字段[开放开始日期(openBeginDate)]的长度不能超过8(In 当前教学班教师(CurrEduClsTeacher))!值:$(pobjCurrEduClsTeacherEN.openBeginDate)(clsCurrEduClsTeacherBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjCurrEduClsTeacherEN.openEndDate) == false && (0, clsString_js_1.GetStrLen)(pobjCurrEduClsTeacherEN.openEndDate) > 8) {
            throw new Error("(errid:Watl000059)字段[开放结束日期(openEndDate)]的长度不能超过8(In 当前教学班教师(CurrEduClsTeacher))!值:$(pobjCurrEduClsTeacherEN.openEndDate)(clsCurrEduClsTeacherBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjCurrEduClsTeacherEN.updDate) == false && (0, clsString_js_1.GetStrLen)(pobjCurrEduClsTeacherEN.updDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 当前教学班教师(CurrEduClsTeacher))!值:$(pobjCurrEduClsTeacherEN.updDate)(clsCurrEduClsTeacherBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjCurrEduClsTeacherEN.updUser) == false && (0, clsString_js_1.GetStrLen)(pobjCurrEduClsTeacherEN.updUser) > 20) {
            throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 当前教学班教师(CurrEduClsTeacher))!值:$(pobjCurrEduClsTeacherEN.updUser)(clsCurrEduClsTeacherBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjCurrEduClsTeacherEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjCurrEduClsTeacherEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 当前教学班教师(CurrEduClsTeacher))!值:$(pobjCurrEduClsTeacherEN.memo)(clsCurrEduClsTeacherBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if (null != pobjCurrEduClsTeacherEN.id_EduClsTeacher && undefined !== pobjCurrEduClsTeacherEN.id_EduClsTeacher && jsString_js_1.tzDataType.isNumber(pobjCurrEduClsTeacherEN.id_EduClsTeacher) === false) {
            throw new Error("(errid:Watl000060)字段[教学班老师流水号(id_EduClsTeacher)]的值:[$(pobjCurrEduClsTeacherEN.id_EduClsTeacher)], 非法，应该为数值型(In 当前教学班教师(CurrEduClsTeacher))!(clsCurrEduClsTeacherBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjCurrEduClsTeacherEN.id_CurrEduCls) == false && undefined !== pobjCurrEduClsTeacherEN.id_CurrEduCls && jsString_js_1.tzDataType.isString(pobjCurrEduClsTeacherEN.id_CurrEduCls) === false) {
            throw new Error("(errid:Watl000060)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjCurrEduClsTeacherEN.id_CurrEduCls)], 非法，应该为字符型(In 当前教学班教师(CurrEduClsTeacher))!(clsCurrEduClsTeacherBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjCurrEduClsTeacherEN.id_Teacher) == false && undefined !== pobjCurrEduClsTeacherEN.id_Teacher && jsString_js_1.tzDataType.isString(pobjCurrEduClsTeacherEN.id_Teacher) === false) {
            throw new Error("(errid:Watl000060)字段[教师流水号(id_Teacher)]的值:[$(pobjCurrEduClsTeacherEN.id_Teacher)], 非法，应该为字符型(In 当前教学班教师(CurrEduClsTeacher))!(clsCurrEduClsTeacherBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjCurrEduClsTeacherEN.id_Pk2EduClsTeacherType) == false && undefined !== pobjCurrEduClsTeacherEN.id_Pk2EduClsTeacherType && jsString_js_1.tzDataType.isString(pobjCurrEduClsTeacherEN.id_Pk2EduClsTeacherType) === false) {
            throw new Error("(errid:Watl000060)字段[教学班老师角色(主讲,辅导)流水号(id_Pk2EduClsTeacherType)]的值:[$(pobjCurrEduClsTeacherEN.id_Pk2EduClsTeacherType)], 非法，应该为字符型(In 当前教学班教师(CurrEduClsTeacher))!(clsCurrEduClsTeacherBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjCurrEduClsTeacherEN.schoolTerm) == false && undefined !== pobjCurrEduClsTeacherEN.schoolTerm && jsString_js_1.tzDataType.isString(pobjCurrEduClsTeacherEN.schoolTerm) === false) {
            throw new Error("(errid:Watl000060)字段[学期(schoolTerm)]的值:[$(pobjCurrEduClsTeacherEN.schoolTerm)], 非法，应该为字符型(In 当前教学班教师(CurrEduClsTeacher))!(clsCurrEduClsTeacherBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjCurrEduClsTeacherEN.schoolYear) == false && undefined !== pobjCurrEduClsTeacherEN.schoolYear && jsString_js_1.tzDataType.isString(pobjCurrEduClsTeacherEN.schoolYear) === false) {
            throw new Error("(errid:Watl000060)字段[学年(schoolYear)]的值:[$(pobjCurrEduClsTeacherEN.schoolYear)], 非法，应该为字符型(In 当前教学班教师(CurrEduClsTeacher))!(clsCurrEduClsTeacherBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjCurrEduClsTeacherEN.openBeginDate) == false && undefined !== pobjCurrEduClsTeacherEN.openBeginDate && jsString_js_1.tzDataType.isString(pobjCurrEduClsTeacherEN.openBeginDate) === false) {
            throw new Error("(errid:Watl000060)字段[开放开始日期(openBeginDate)]的值:[$(pobjCurrEduClsTeacherEN.openBeginDate)], 非法，应该为字符型(In 当前教学班教师(CurrEduClsTeacher))!(clsCurrEduClsTeacherBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjCurrEduClsTeacherEN.openEndDate) == false && undefined !== pobjCurrEduClsTeacherEN.openEndDate && jsString_js_1.tzDataType.isString(pobjCurrEduClsTeacherEN.openEndDate) === false) {
            throw new Error("(errid:Watl000060)字段[开放结束日期(openEndDate)]的值:[$(pobjCurrEduClsTeacherEN.openEndDate)], 非法，应该为字符型(In 当前教学班教师(CurrEduClsTeacher))!(clsCurrEduClsTeacherBL:CheckPropertyNew)");
        }
        if (null != pobjCurrEduClsTeacherEN.orderNum && undefined !== pobjCurrEduClsTeacherEN.orderNum && jsString_js_1.tzDataType.isNumber(pobjCurrEduClsTeacherEN.orderNum) === false) {
            throw new Error("(errid:Watl000060)字段[序号(orderNum)]的值:[$(pobjCurrEduClsTeacherEN.orderNum)], 非法，应该为数值型(In 当前教学班教师(CurrEduClsTeacher))!(clsCurrEduClsTeacherBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjCurrEduClsTeacherEN.updDate) == false && undefined !== pobjCurrEduClsTeacherEN.updDate && jsString_js_1.tzDataType.isString(pobjCurrEduClsTeacherEN.updDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjCurrEduClsTeacherEN.updDate)], 非法，应该为字符型(In 当前教学班教师(CurrEduClsTeacher))!(clsCurrEduClsTeacherBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjCurrEduClsTeacherEN.updUser) == false && undefined !== pobjCurrEduClsTeacherEN.updUser && jsString_js_1.tzDataType.isString(pobjCurrEduClsTeacherEN.updUser) === false) {
            throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjCurrEduClsTeacherEN.updUser)], 非法，应该为字符型(In 当前教学班教师(CurrEduClsTeacher))!(clsCurrEduClsTeacherBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjCurrEduClsTeacherEN.memo) == false && undefined !== pobjCurrEduClsTeacherEN.memo && jsString_js_1.tzDataType.isString(pobjCurrEduClsTeacherEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjCurrEduClsTeacherEN.memo)], 非法，应该为字符型(In 当前教学班教师(CurrEduClsTeacher))!(clsCurrEduClsTeacherBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjCurrEduClsTeacherEN.id_CurrEduCls) == false && (0, clsString_js_1.GetStrLen)(pobjCurrEduClsTeacherEN.id_CurrEduCls) != 8) {
            throw ("(errid:Watl000061)字段[教学班流水号]作为外键字段,长度应该为8(In 当前教学班教师)!(clsCurrEduClsTeacherBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjCurrEduClsTeacherEN.id_Teacher) == false && (0, clsString_js_1.GetStrLen)(pobjCurrEduClsTeacherEN.id_Teacher) != 8) {
            throw ("(errid:Watl000061)字段[教师流水号]作为外键字段,长度应该为8(In 当前教学班教师)!(clsCurrEduClsTeacherBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjCurrEduClsTeacherEN.id_Pk2EduClsTeacherType) == false && (0, clsString_js_1.GetStrLen)(pobjCurrEduClsTeacherEN.id_Pk2EduClsTeacherType) != 4) {
            throw ("(errid:Watl000061)字段[教学班老师角色(主讲,辅导)流水号]作为外键字段,长度应该为4(In 当前教学班教师)!(clsCurrEduClsTeacherBL:CheckPropertyNew)");
        }
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjCurrEduClsTeacherEN.SetIsCheckProperty(true);
    }
    exports.CurrEduClsTeacher_CheckPropertyNew = CurrEduClsTeacher_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function CurrEduClsTeacher_CheckProperty4Update(pobjCurrEduClsTeacherEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjCurrEduClsTeacherEN.id_CurrEduCls) == false && (0, clsString_js_1.GetStrLen)(pobjCurrEduClsTeacherEN.id_CurrEduCls) > 8) {
            throw new Error("(errid:Watl000062)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 当前教学班教师(CurrEduClsTeacher))!值:$(pobjCurrEduClsTeacherEN.id_CurrEduCls)(clsCurrEduClsTeacherBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjCurrEduClsTeacherEN.id_Teacher) == false && (0, clsString_js_1.GetStrLen)(pobjCurrEduClsTeacherEN.id_Teacher) > 8) {
            throw new Error("(errid:Watl000062)字段[教师流水号(id_Teacher)]的长度不能超过8(In 当前教学班教师(CurrEduClsTeacher))!值:$(pobjCurrEduClsTeacherEN.id_Teacher)(clsCurrEduClsTeacherBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjCurrEduClsTeacherEN.id_Pk2EduClsTeacherType) == false && (0, clsString_js_1.GetStrLen)(pobjCurrEduClsTeacherEN.id_Pk2EduClsTeacherType) > 4) {
            throw new Error("(errid:Watl000062)字段[教学班老师角色(主讲,辅导)流水号(id_Pk2EduClsTeacherType)]的长度不能超过4(In 当前教学班教师(CurrEduClsTeacher))!值:$(pobjCurrEduClsTeacherEN.id_Pk2EduClsTeacherType)(clsCurrEduClsTeacherBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjCurrEduClsTeacherEN.schoolTerm) == false && (0, clsString_js_1.GetStrLen)(pobjCurrEduClsTeacherEN.schoolTerm) > 1) {
            throw new Error("(errid:Watl000062)字段[学期(schoolTerm)]的长度不能超过1(In 当前教学班教师(CurrEduClsTeacher))!值:$(pobjCurrEduClsTeacherEN.schoolTerm)(clsCurrEduClsTeacherBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjCurrEduClsTeacherEN.schoolYear) == false && (0, clsString_js_1.GetStrLen)(pobjCurrEduClsTeacherEN.schoolYear) > 10) {
            throw new Error("(errid:Watl000062)字段[学年(schoolYear)]的长度不能超过10(In 当前教学班教师(CurrEduClsTeacher))!值:$(pobjCurrEduClsTeacherEN.schoolYear)(clsCurrEduClsTeacherBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjCurrEduClsTeacherEN.openBeginDate) == false && (0, clsString_js_1.GetStrLen)(pobjCurrEduClsTeacherEN.openBeginDate) > 8) {
            throw new Error("(errid:Watl000062)字段[开放开始日期(openBeginDate)]的长度不能超过8(In 当前教学班教师(CurrEduClsTeacher))!值:$(pobjCurrEduClsTeacherEN.openBeginDate)(clsCurrEduClsTeacherBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjCurrEduClsTeacherEN.openEndDate) == false && (0, clsString_js_1.GetStrLen)(pobjCurrEduClsTeacherEN.openEndDate) > 8) {
            throw new Error("(errid:Watl000062)字段[开放结束日期(openEndDate)]的长度不能超过8(In 当前教学班教师(CurrEduClsTeacher))!值:$(pobjCurrEduClsTeacherEN.openEndDate)(clsCurrEduClsTeacherBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjCurrEduClsTeacherEN.updDate) == false && (0, clsString_js_1.GetStrLen)(pobjCurrEduClsTeacherEN.updDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 当前教学班教师(CurrEduClsTeacher))!值:$(pobjCurrEduClsTeacherEN.updDate)(clsCurrEduClsTeacherBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjCurrEduClsTeacherEN.updUser) == false && (0, clsString_js_1.GetStrLen)(pobjCurrEduClsTeacherEN.updUser) > 20) {
            throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 当前教学班教师(CurrEduClsTeacher))!值:$(pobjCurrEduClsTeacherEN.updUser)(clsCurrEduClsTeacherBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjCurrEduClsTeacherEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjCurrEduClsTeacherEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 当前教学班教师(CurrEduClsTeacher))!值:$(pobjCurrEduClsTeacherEN.memo)(clsCurrEduClsTeacherBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if (null != pobjCurrEduClsTeacherEN.id_EduClsTeacher && undefined !== pobjCurrEduClsTeacherEN.id_EduClsTeacher && jsString_js_1.tzDataType.isNumber(pobjCurrEduClsTeacherEN.id_EduClsTeacher) === false) {
            throw new Error("(errid:Watl000063)字段[教学班老师流水号(id_EduClsTeacher)]的值:[$(pobjCurrEduClsTeacherEN.id_EduClsTeacher)], 非法，应该为数值型(In 当前教学班教师(CurrEduClsTeacher))!(clsCurrEduClsTeacherBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjCurrEduClsTeacherEN.id_CurrEduCls) == false && undefined !== pobjCurrEduClsTeacherEN.id_CurrEduCls && jsString_js_1.tzDataType.isString(pobjCurrEduClsTeacherEN.id_CurrEduCls) === false) {
            throw new Error("(errid:Watl000063)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjCurrEduClsTeacherEN.id_CurrEduCls)], 非法，应该为字符型(In 当前教学班教师(CurrEduClsTeacher))!(clsCurrEduClsTeacherBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjCurrEduClsTeacherEN.id_Teacher) == false && undefined !== pobjCurrEduClsTeacherEN.id_Teacher && jsString_js_1.tzDataType.isString(pobjCurrEduClsTeacherEN.id_Teacher) === false) {
            throw new Error("(errid:Watl000063)字段[教师流水号(id_Teacher)]的值:[$(pobjCurrEduClsTeacherEN.id_Teacher)], 非法，应该为字符型(In 当前教学班教师(CurrEduClsTeacher))!(clsCurrEduClsTeacherBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjCurrEduClsTeacherEN.id_Pk2EduClsTeacherType) == false && undefined !== pobjCurrEduClsTeacherEN.id_Pk2EduClsTeacherType && jsString_js_1.tzDataType.isString(pobjCurrEduClsTeacherEN.id_Pk2EduClsTeacherType) === false) {
            throw new Error("(errid:Watl000063)字段[教学班老师角色(主讲,辅导)流水号(id_Pk2EduClsTeacherType)]的值:[$(pobjCurrEduClsTeacherEN.id_Pk2EduClsTeacherType)], 非法，应该为字符型(In 当前教学班教师(CurrEduClsTeacher))!(clsCurrEduClsTeacherBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjCurrEduClsTeacherEN.schoolTerm) == false && undefined !== pobjCurrEduClsTeacherEN.schoolTerm && jsString_js_1.tzDataType.isString(pobjCurrEduClsTeacherEN.schoolTerm) === false) {
            throw new Error("(errid:Watl000063)字段[学期(schoolTerm)]的值:[$(pobjCurrEduClsTeacherEN.schoolTerm)], 非法，应该为字符型(In 当前教学班教师(CurrEduClsTeacher))!(clsCurrEduClsTeacherBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjCurrEduClsTeacherEN.schoolYear) == false && undefined !== pobjCurrEduClsTeacherEN.schoolYear && jsString_js_1.tzDataType.isString(pobjCurrEduClsTeacherEN.schoolYear) === false) {
            throw new Error("(errid:Watl000063)字段[学年(schoolYear)]的值:[$(pobjCurrEduClsTeacherEN.schoolYear)], 非法，应该为字符型(In 当前教学班教师(CurrEduClsTeacher))!(clsCurrEduClsTeacherBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjCurrEduClsTeacherEN.openBeginDate) == false && undefined !== pobjCurrEduClsTeacherEN.openBeginDate && jsString_js_1.tzDataType.isString(pobjCurrEduClsTeacherEN.openBeginDate) === false) {
            throw new Error("(errid:Watl000063)字段[开放开始日期(openBeginDate)]的值:[$(pobjCurrEduClsTeacherEN.openBeginDate)], 非法，应该为字符型(In 当前教学班教师(CurrEduClsTeacher))!(clsCurrEduClsTeacherBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjCurrEduClsTeacherEN.openEndDate) == false && undefined !== pobjCurrEduClsTeacherEN.openEndDate && jsString_js_1.tzDataType.isString(pobjCurrEduClsTeacherEN.openEndDate) === false) {
            throw new Error("(errid:Watl000063)字段[开放结束日期(openEndDate)]的值:[$(pobjCurrEduClsTeacherEN.openEndDate)], 非法，应该为字符型(In 当前教学班教师(CurrEduClsTeacher))!(clsCurrEduClsTeacherBL:CheckProperty4Update)");
        }
        if (null != pobjCurrEduClsTeacherEN.orderNum && undefined !== pobjCurrEduClsTeacherEN.orderNum && jsString_js_1.tzDataType.isNumber(pobjCurrEduClsTeacherEN.orderNum) === false) {
            throw new Error("(errid:Watl000063)字段[序号(orderNum)]的值:[$(pobjCurrEduClsTeacherEN.orderNum)], 非法，应该为数值型(In 当前教学班教师(CurrEduClsTeacher))!(clsCurrEduClsTeacherBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjCurrEduClsTeacherEN.updDate) == false && undefined !== pobjCurrEduClsTeacherEN.updDate && jsString_js_1.tzDataType.isString(pobjCurrEduClsTeacherEN.updDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjCurrEduClsTeacherEN.updDate)], 非法，应该为字符型(In 当前教学班教师(CurrEduClsTeacher))!(clsCurrEduClsTeacherBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjCurrEduClsTeacherEN.updUser) == false && undefined !== pobjCurrEduClsTeacherEN.updUser && jsString_js_1.tzDataType.isString(pobjCurrEduClsTeacherEN.updUser) === false) {
            throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjCurrEduClsTeacherEN.updUser)], 非法，应该为字符型(In 当前教学班教师(CurrEduClsTeacher))!(clsCurrEduClsTeacherBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjCurrEduClsTeacherEN.memo) == false && undefined !== pobjCurrEduClsTeacherEN.memo && jsString_js_1.tzDataType.isString(pobjCurrEduClsTeacherEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjCurrEduClsTeacherEN.memo)], 非法，应该为字符型(In 当前教学班教师(CurrEduClsTeacher))!(clsCurrEduClsTeacherBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if (null === pobjCurrEduClsTeacherEN.id_EduClsTeacher
            || pobjCurrEduClsTeacherEN.id_EduClsTeacher != null && pobjCurrEduClsTeacherEN.id_EduClsTeacher.toString() === "") {
            throw new Error("(errid:Watl000064)字段[教学班老师流水号]不能为空(In 当前教学班教师)!(clsCurrEduClsTeacherBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjCurrEduClsTeacherEN.id_CurrEduCls) == false && (0, clsString_js_1.GetStrLen)(pobjCurrEduClsTeacherEN.id_CurrEduCls) != 8) {
            throw ("(errid:Watl000065)字段[教学班流水号]作为外键字段,长度应该为8(In 当前教学班教师)!(clsCurrEduClsTeacherBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjCurrEduClsTeacherEN.id_Teacher) == false && (0, clsString_js_1.GetStrLen)(pobjCurrEduClsTeacherEN.id_Teacher) != 8) {
            throw ("(errid:Watl000065)字段[教师流水号]作为外键字段,长度应该为8(In 当前教学班教师)!(clsCurrEduClsTeacherBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjCurrEduClsTeacherEN.id_Pk2EduClsTeacherType) == false && (0, clsString_js_1.GetStrLen)(pobjCurrEduClsTeacherEN.id_Pk2EduClsTeacherType) != 4) {
            throw ("(errid:Watl000065)字段[教学班老师角色(主讲,辅导)流水号]作为外键字段,长度应该为4(In 当前教学班教师)!(clsCurrEduClsTeacherBL:CheckPropertyNew)");
        }
        pobjCurrEduClsTeacherEN.SetIsCheckProperty(true);
    }
    exports.CurrEduClsTeacher_CheckProperty4Update = CurrEduClsTeacher_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function CurrEduClsTeacher_GetJSONStrByObj(pobjCurrEduClsTeacherEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjCurrEduClsTeacherEN.sf_UpdFldSetStr = pobjCurrEduClsTeacherEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjCurrEduClsTeacherEN);
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
    exports.CurrEduClsTeacher_GetJSONStrByObj = CurrEduClsTeacher_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function CurrEduClsTeacher_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrCurrEduClsTeacherObjLst = new Array();
        if (strJSON === "") {
            return arrCurrEduClsTeacherObjLst;
        }
        try {
            arrCurrEduClsTeacherObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrCurrEduClsTeacherObjLst;
        }
        return arrCurrEduClsTeacherObjLst;
    }
    exports.CurrEduClsTeacher_GetObjLstByJSONStr = CurrEduClsTeacher_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrCurrEduClsTeacherObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function CurrEduClsTeacher_GetObjLstByJSONObjLst(arrCurrEduClsTeacherObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrCurrEduClsTeacherObjLst = new Array();
        for (const objInFor of arrCurrEduClsTeacherObjLstS) {
            const obj1 = CurrEduClsTeacher_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrCurrEduClsTeacherObjLst.push(obj1);
        }
        return arrCurrEduClsTeacherObjLst;
    }
    exports.CurrEduClsTeacher_GetObjLstByJSONObjLst = CurrEduClsTeacher_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function CurrEduClsTeacher_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjCurrEduClsTeacherEN = new clsCurrEduClsTeacherEN_js_1.clsCurrEduClsTeacherEN();
        if (strJSON === "") {
            return pobjCurrEduClsTeacherEN;
        }
        try {
            pobjCurrEduClsTeacherEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjCurrEduClsTeacherEN;
        }
        return pobjCurrEduClsTeacherEN;
    }
    exports.CurrEduClsTeacher_GetObjByJSONStr = CurrEduClsTeacher_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function CurrEduClsTeacher_GetCombineCondition(objCurrEduClsTeacher_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objCurrEduClsTeacher_Cond.dicFldComparisonOp, clsCurrEduClsTeacherEN_js_1.clsCurrEduClsTeacherEN.con_id_EduClsTeacher) == true) {
            const strComparisonOp_id_EduClsTeacher = objCurrEduClsTeacher_Cond.dicFldComparisonOp[clsCurrEduClsTeacherEN_js_1.clsCurrEduClsTeacherEN.con_id_EduClsTeacher];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsCurrEduClsTeacherEN_js_1.clsCurrEduClsTeacherEN.con_id_EduClsTeacher, objCurrEduClsTeacher_Cond.id_EduClsTeacher, strComparisonOp_id_EduClsTeacher);
        }
        if (Object.prototype.hasOwnProperty.call(objCurrEduClsTeacher_Cond.dicFldComparisonOp, clsCurrEduClsTeacherEN_js_1.clsCurrEduClsTeacherEN.con_id_CurrEduCls) == true) {
            const strComparisonOp_id_CurrEduCls = objCurrEduClsTeacher_Cond.dicFldComparisonOp[clsCurrEduClsTeacherEN_js_1.clsCurrEduClsTeacherEN.con_id_CurrEduCls];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsCurrEduClsTeacherEN_js_1.clsCurrEduClsTeacherEN.con_id_CurrEduCls, objCurrEduClsTeacher_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
        }
        if (Object.prototype.hasOwnProperty.call(objCurrEduClsTeacher_Cond.dicFldComparisonOp, clsCurrEduClsTeacherEN_js_1.clsCurrEduClsTeacherEN.con_id_Teacher) == true) {
            const strComparisonOp_id_Teacher = objCurrEduClsTeacher_Cond.dicFldComparisonOp[clsCurrEduClsTeacherEN_js_1.clsCurrEduClsTeacherEN.con_id_Teacher];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsCurrEduClsTeacherEN_js_1.clsCurrEduClsTeacherEN.con_id_Teacher, objCurrEduClsTeacher_Cond.id_Teacher, strComparisonOp_id_Teacher);
        }
        if (Object.prototype.hasOwnProperty.call(objCurrEduClsTeacher_Cond.dicFldComparisonOp, clsCurrEduClsTeacherEN_js_1.clsCurrEduClsTeacherEN.con_id_Pk2EduClsTeacherType) == true) {
            const strComparisonOp_id_Pk2EduClsTeacherType = objCurrEduClsTeacher_Cond.dicFldComparisonOp[clsCurrEduClsTeacherEN_js_1.clsCurrEduClsTeacherEN.con_id_Pk2EduClsTeacherType];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsCurrEduClsTeacherEN_js_1.clsCurrEduClsTeacherEN.con_id_Pk2EduClsTeacherType, objCurrEduClsTeacher_Cond.id_Pk2EduClsTeacherType, strComparisonOp_id_Pk2EduClsTeacherType);
        }
        if (Object.prototype.hasOwnProperty.call(objCurrEduClsTeacher_Cond.dicFldComparisonOp, clsCurrEduClsTeacherEN_js_1.clsCurrEduClsTeacherEN.con_SchoolTerm) == true) {
            const strComparisonOp_SchoolTerm = objCurrEduClsTeacher_Cond.dicFldComparisonOp[clsCurrEduClsTeacherEN_js_1.clsCurrEduClsTeacherEN.con_SchoolTerm];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsCurrEduClsTeacherEN_js_1.clsCurrEduClsTeacherEN.con_SchoolTerm, objCurrEduClsTeacher_Cond.schoolTerm, strComparisonOp_SchoolTerm);
        }
        if (Object.prototype.hasOwnProperty.call(objCurrEduClsTeacher_Cond.dicFldComparisonOp, clsCurrEduClsTeacherEN_js_1.clsCurrEduClsTeacherEN.con_SchoolYear) == true) {
            const strComparisonOp_SchoolYear = objCurrEduClsTeacher_Cond.dicFldComparisonOp[clsCurrEduClsTeacherEN_js_1.clsCurrEduClsTeacherEN.con_SchoolYear];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsCurrEduClsTeacherEN_js_1.clsCurrEduClsTeacherEN.con_SchoolYear, objCurrEduClsTeacher_Cond.schoolYear, strComparisonOp_SchoolYear);
        }
        if (Object.prototype.hasOwnProperty.call(objCurrEduClsTeacher_Cond.dicFldComparisonOp, clsCurrEduClsTeacherEN_js_1.clsCurrEduClsTeacherEN.con_OpenBeginDate) == true) {
            const strComparisonOp_OpenBeginDate = objCurrEduClsTeacher_Cond.dicFldComparisonOp[clsCurrEduClsTeacherEN_js_1.clsCurrEduClsTeacherEN.con_OpenBeginDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsCurrEduClsTeacherEN_js_1.clsCurrEduClsTeacherEN.con_OpenBeginDate, objCurrEduClsTeacher_Cond.openBeginDate, strComparisonOp_OpenBeginDate);
        }
        if (Object.prototype.hasOwnProperty.call(objCurrEduClsTeacher_Cond.dicFldComparisonOp, clsCurrEduClsTeacherEN_js_1.clsCurrEduClsTeacherEN.con_OpenEndDate) == true) {
            const strComparisonOp_OpenEndDate = objCurrEduClsTeacher_Cond.dicFldComparisonOp[clsCurrEduClsTeacherEN_js_1.clsCurrEduClsTeacherEN.con_OpenEndDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsCurrEduClsTeacherEN_js_1.clsCurrEduClsTeacherEN.con_OpenEndDate, objCurrEduClsTeacher_Cond.openEndDate, strComparisonOp_OpenEndDate);
        }
        if (Object.prototype.hasOwnProperty.call(objCurrEduClsTeacher_Cond.dicFldComparisonOp, clsCurrEduClsTeacherEN_js_1.clsCurrEduClsTeacherEN.con_OrderNum) == true) {
            const strComparisonOp_OrderNum = objCurrEduClsTeacher_Cond.dicFldComparisonOp[clsCurrEduClsTeacherEN_js_1.clsCurrEduClsTeacherEN.con_OrderNum];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsCurrEduClsTeacherEN_js_1.clsCurrEduClsTeacherEN.con_OrderNum, objCurrEduClsTeacher_Cond.orderNum, strComparisonOp_OrderNum);
        }
        if (Object.prototype.hasOwnProperty.call(objCurrEduClsTeacher_Cond.dicFldComparisonOp, clsCurrEduClsTeacherEN_js_1.clsCurrEduClsTeacherEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objCurrEduClsTeacher_Cond.dicFldComparisonOp[clsCurrEduClsTeacherEN_js_1.clsCurrEduClsTeacherEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsCurrEduClsTeacherEN_js_1.clsCurrEduClsTeacherEN.con_UpdDate, objCurrEduClsTeacher_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objCurrEduClsTeacher_Cond.dicFldComparisonOp, clsCurrEduClsTeacherEN_js_1.clsCurrEduClsTeacherEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objCurrEduClsTeacher_Cond.dicFldComparisonOp[clsCurrEduClsTeacherEN_js_1.clsCurrEduClsTeacherEN.con_UpdUser];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsCurrEduClsTeacherEN_js_1.clsCurrEduClsTeacherEN.con_UpdUser, objCurrEduClsTeacher_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objCurrEduClsTeacher_Cond.dicFldComparisonOp, clsCurrEduClsTeacherEN_js_1.clsCurrEduClsTeacherEN.con_Memo) == true) {
            const strComparisonOp_Memo = objCurrEduClsTeacher_Cond.dicFldComparisonOp[clsCurrEduClsTeacherEN_js_1.clsCurrEduClsTeacherEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsCurrEduClsTeacherEN_js_1.clsCurrEduClsTeacherEN.con_Memo, objCurrEduClsTeacher_Cond.memo, strComparisonOp_Memo);
        }
        return strWhereCond;
    }
    exports.CurrEduClsTeacher_GetCombineCondition = CurrEduClsTeacher_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--CurrEduClsTeacher(当前教学班教师),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param strid_CurrEduCls: 教学班流水号(要求唯一的字段)
    * @param strid_Teacher: 教师流水号(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function CurrEduClsTeacher_GetUniCondStr_id_CurrEduCls_id_Teacher(objCurrEduClsTeacherEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and id_CurrEduCls = '{0}'", objCurrEduClsTeacherEN.id_CurrEduCls);
        strWhereCond += (0, clsString_js_1.Format)(" and id_Teacher = '{0}'", objCurrEduClsTeacherEN.id_Teacher);
        return strWhereCond;
    }
    exports.CurrEduClsTeacher_GetUniCondStr_id_CurrEduCls_id_Teacher = CurrEduClsTeacher_GetUniCondStr_id_CurrEduCls_id_Teacher;
    /**
    *获取唯一性条件串(Uniqueness)--CurrEduClsTeacher(当前教学班教师),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param strid_CurrEduCls: 教学班流水号(要求唯一的字段)
    * @param strid_Teacher: 教师流水号(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function CurrEduClsTeacher_GetUniCondStr4Update_id_CurrEduCls_id_Teacher(objCurrEduClsTeacherEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and id_EduClsTeacher <> '{0}'", objCurrEduClsTeacherEN.id_EduClsTeacher);
        strWhereCond += (0, clsString_js_1.Format)(" and id_CurrEduCls = '{0}'", objCurrEduClsTeacherEN.id_CurrEduCls);
        strWhereCond += (0, clsString_js_1.Format)(" and id_Teacher = '{0}'", objCurrEduClsTeacherEN.id_Teacher);
        return strWhereCond;
    }
    exports.CurrEduClsTeacher_GetUniCondStr4Update_id_CurrEduCls_id_Teacher = CurrEduClsTeacher_GetUniCondStr4Update_id_CurrEduCls_id_Teacher;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objCurrEduClsTeacherENS:源对象
     * @param objCurrEduClsTeacherENT:目标对象
    */
    function CurrEduClsTeacher_CopyObjTo(objCurrEduClsTeacherENS, objCurrEduClsTeacherENT) {
        objCurrEduClsTeacherENT.id_EduClsTeacher = objCurrEduClsTeacherENS.id_EduClsTeacher; //教学班老师流水号
        objCurrEduClsTeacherENT.id_CurrEduCls = objCurrEduClsTeacherENS.id_CurrEduCls; //教学班流水号
        objCurrEduClsTeacherENT.id_Teacher = objCurrEduClsTeacherENS.id_Teacher; //教师流水号
        objCurrEduClsTeacherENT.id_Pk2EduClsTeacherType = objCurrEduClsTeacherENS.id_Pk2EduClsTeacherType; //教学班老师角色(主讲,辅导)流水号
        objCurrEduClsTeacherENT.schoolTerm = objCurrEduClsTeacherENS.schoolTerm; //学期
        objCurrEduClsTeacherENT.schoolYear = objCurrEduClsTeacherENS.schoolYear; //学年
        objCurrEduClsTeacherENT.openBeginDate = objCurrEduClsTeacherENS.openBeginDate; //开放开始日期
        objCurrEduClsTeacherENT.openEndDate = objCurrEduClsTeacherENS.openEndDate; //开放结束日期
        objCurrEduClsTeacherENT.orderNum = objCurrEduClsTeacherENS.orderNum; //序号
        objCurrEduClsTeacherENT.updDate = objCurrEduClsTeacherENS.updDate; //修改日期
        objCurrEduClsTeacherENT.updUser = objCurrEduClsTeacherENS.updUser; //修改人
        objCurrEduClsTeacherENT.memo = objCurrEduClsTeacherENS.memo; //备注
        objCurrEduClsTeacherENT.sf_UpdFldSetStr = objCurrEduClsTeacherENS.updFldString; //sf_UpdFldSetStr
    }
    exports.CurrEduClsTeacher_CopyObjTo = CurrEduClsTeacher_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objCurrEduClsTeacherENS:源对象
     * @param objCurrEduClsTeacherENT:目标对象
    */
    function CurrEduClsTeacher_GetObjFromJsonObj(objCurrEduClsTeacherENS) {
        const objCurrEduClsTeacherENT = new clsCurrEduClsTeacherEN_js_1.clsCurrEduClsTeacherEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objCurrEduClsTeacherENT, objCurrEduClsTeacherENS);
        return objCurrEduClsTeacherENT;
    }
    exports.CurrEduClsTeacher_GetObjFromJsonObj = CurrEduClsTeacher_GetObjFromJsonObj;
});
