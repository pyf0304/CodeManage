/**
* 类名:clsXzGradeBaseWApi
* 表名:XzGradeBase(01120129)
* 生成代码版本:2022.11.02.1
* 生成日期:2022/11/02 11:46:07
* 生成者:pyf
* 生成服务器IP:
工程名称:问卷调查(0112)
CM工程:研究生论文学习(变量首字母小写)-全部函数集
* 相关数据库:103.116.76.183,9433EduHigh_Jsie
* PrjDataBaseId:0170
模块中文名:系统参数(SysPara)
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
        define(["require", "exports", "axios", "../../PubFun/CacheHelper.js", "../../L0_Entity/SysPara/clsXzGradeBaseEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsSysPara4WebApi.js", "../../PubFun/CacheHelper.js", "../../PubFun/jsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.XzGradeBase_GetObjFromJsonObj = exports.XzGradeBase_CopyObjTo = exports.XzGradeBase_GetCombineCondition = exports.XzGradeBase_GetObjByJSONStr = exports.XzGradeBase_GetObjLstByJSONObjLst = exports.XzGradeBase_GetObjLstByJSONStr = exports.XzGradeBase_GetJSONStrByObj = exports.XzGradeBase_CheckProperty4Update = exports.XzGradeBase_CheckPropertyNew = exports.XzGradeBase_BindDdl_id_GradeBaseInDiv_Cache = exports.XzGradeBase_ReFreshThisCache = exports.XzGradeBase_ReFreshCache = exports.XzGradeBase_GetWebApiUrl = exports.XzGradeBase_GetMaxStrIdByPrefix = exports.XzGradeBase_GetRecCountByCond_Cache = exports.XzGradeBase_GetRecCountByCondAsync = exports.XzGradeBase_IsExistAsync = exports.XzGradeBase_IsExist_Cache = exports.XzGradeBase_IsExist = exports.XzGradeBase_IsExistRecordAsync = exports.XzGradeBase_IsExistRecord_Cache = exports.XzGradeBase_UpdateWithConditionAsync = exports.XzGradeBase_UpdateRecordAsync = exports.XzGradeBase_AddNewRecordWithReturnKey = exports.XzGradeBase_AddNewRecordWithReturnKeyAsync = exports.XzGradeBase_AddNewRecordWithMaxIdAsync = exports.XzGradeBase_AddNewRecordAsync = exports.XzGradeBase_DelXzGradeBasesByCondAsync = exports.XzGradeBase_DelXzGradeBasesAsync = exports.XzGradeBase_DelRecordAsync = exports.XzGradeBase_GetObjLstByPagerAsync = exports.XzGradeBase_GetObjLstByPager_Cache = exports.XzGradeBase_GetObjLstByRange = exports.XzGradeBase_GetObjLstByRangeAsync = exports.XzGradeBase_GetTopObjLstAsync = exports.XzGradeBase_GetObjLstByid_GradeBaseLst_Cache = exports.XzGradeBase_GetObjLstByid_GradeBaseLstAsync = exports.XzGradeBase_GetSubObjLst_Cache = exports.XzGradeBase_GetObjLst_PureCache = exports.XzGradeBase_GetObjLst_Cache = exports.XzGradeBase_GetObjLst_sessionStorage_PureCache = exports.XzGradeBase_GetObjLst_sessionStorage = exports.XzGradeBase_GetObjLstAsync = exports.XzGradeBase_GetObjLst_localStorage_PureCache = exports.XzGradeBase_GetObjLst_localStorage = exports.XzGradeBase_GetObjLst_ClientCache = exports.XzGradeBase_GetFirstObjAsync = exports.XzGradeBase_GetFirstID = exports.XzGradeBase_GetFirstIDAsync = exports.XzGradeBase_FilterFunByKey = exports.XzGradeBase_SortFunByKey = exports.XzGradeBase_SortFun_Defa_2Fld = exports.XzGradeBase_SortFun_Defa = exports.XzGradeBase_func = exports.XzGradeBase_GetNameByid_GradeBase_Cache = exports.XzGradeBase_UpdateObjInLst_Cache = exports.XzGradeBase_GetObjByid_GradeBase_localStorage = exports.XzGradeBase_GetObjByid_GradeBase_Cache = exports.XzGradeBase_GetObjByid_GradeBaseAsync = exports.xzGradeBase_ConstructorName = exports.xzGradeBase_Controller = void 0;
    /**
     * 年级(XzGradeBase)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2022年11月02日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsXzGradeBaseEN_js_1 = require("../../L0_Entity/SysPara/clsXzGradeBaseEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    const CacheHelper_js_2 = require("../../PubFun/CacheHelper.js");
    const jsString_js_1 = require("../../PubFun/jsString.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.xzGradeBase_Controller = "XzGradeBaseApi";
    exports.xzGradeBase_ConstructorName = "xzGradeBase";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strid_GradeBase:关键字
    * @returns 对象
    **/
    async function XzGradeBase_GetObjByid_GradeBaseAsync(strid_GradeBase) {
        const strThisFuncName = "GetObjByid_GradeBaseAsync";
        if ((0, clsString_js_1.IsNullOrEmpty)(strid_GradeBase) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strid_GradeBase]不能为空！(In GetObjByid_GradeBaseAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_GradeBase.length != 4) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strid_GradeBase]的长度:[{0}]不正确！", strid_GradeBase.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByid_GradeBase";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzGradeBase_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "strid_GradeBase": strid_GradeBase,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.xzGradeBase_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objXzGradeBase = XzGradeBase_GetObjFromJsonObj(returnObj);
                return objXzGradeBase;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzGradeBase_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzGradeBase_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzGradeBase_GetObjByid_GradeBaseAsync = XzGradeBase_GetObjByid_GradeBaseAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param strid_GradeBase:所给的关键字
     * @returns 对象
    */
    async function XzGradeBase_GetObjByid_GradeBase_Cache(strid_GradeBase, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByid_GradeBase_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strid_GradeBase) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strid_GradeBase]不能为空！(In GetObjByid_GradeBase_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_GradeBase.length != 4) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strid_GradeBase]的长度:[{0}]不正确！", strid_GradeBase.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrXzGradeBaseObjLst_Cache = await XzGradeBase_GetObjLst_Cache();
        try {
            const arrXzGradeBase_Sel = arrXzGradeBaseObjLst_Cache.filter(x => x.id_GradeBase == strid_GradeBase);
            let objXzGradeBase;
            if (arrXzGradeBase_Sel.length > 0) {
                objXzGradeBase = arrXzGradeBase_Sel[0];
                return objXzGradeBase;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    objXzGradeBase = await XzGradeBase_GetObjByid_GradeBaseAsync(strid_GradeBase);
                    if (objXzGradeBase != null) {
                        XzGradeBase_ReFreshThisCache();
                        return objXzGradeBase;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strid_GradeBase, exports.xzGradeBase_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.XzGradeBase_GetObjByid_GradeBase_Cache = XzGradeBase_GetObjByid_GradeBase_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param strid_GradeBase:所给的关键字
     * @returns 对象
    */
    async function XzGradeBase_GetObjByid_GradeBase_localStorage(strid_GradeBase) {
        const strThisFuncName = "GetObjByid_GradeBase_localStorage";
        if ((0, clsString_js_1.IsNullOrEmpty)(strid_GradeBase) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strid_GradeBase]不能为空！(In GetObjByid_GradeBase_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_GradeBase.length != 4) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strid_GradeBase]的长度:[{0}]不正确！", strid_GradeBase.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsXzGradeBaseEN_js_1.clsXzGradeBaseEN._CurrTabName, strid_GradeBase);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objXzGradeBase_Cache = JSON.parse(strTempObj);
            return objXzGradeBase_Cache;
        }
        try {
            const objXzGradeBase = await XzGradeBase_GetObjByid_GradeBaseAsync(strid_GradeBase);
            if (objXzGradeBase != null) {
                localStorage.setItem(strKey, JSON.stringify(objXzGradeBase));
                const strInfo = (0, clsString_js_1.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objXzGradeBase;
            }
            return objXzGradeBase;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strid_GradeBase, exports.xzGradeBase_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.XzGradeBase_GetObjByid_GradeBase_localStorage = XzGradeBase_GetObjByid_GradeBase_localStorage;
    /**
     * 修改在缓存对象列表中的对象, 与后台数据库无关.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
     * @param objXzGradeBase:所给的对象
     * @returns 对象
    */
    async function XzGradeBase_UpdateObjInLst_Cache(objXzGradeBase) {
        const strThisFuncName = "UpdateObjInLst_Cache";
        try {
            const arrXzGradeBaseObjLst_Cache = await XzGradeBase_GetObjLst_Cache();
            const obj = arrXzGradeBaseObjLst_Cache.find(x => x.id_GradeBase == objXzGradeBase.id_GradeBase);
            if (obj != null) {
                objXzGradeBase.id_GradeBase = obj.id_GradeBase;
                (0, clsCommFunc4Web_js_1.ObjectAssign)(obj, objXzGradeBase);
            }
            else {
                arrXzGradeBaseObjLst_Cache.push(objXzGradeBase);
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, exports.xzGradeBase_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.XzGradeBase_UpdateObjInLst_Cache = XzGradeBase_UpdateObjInLst_Cache;
    /**
     * 根据关键字获取相关对象的名称属性, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetNameByKeyId_Cache)
     * @param strid_GradeBase:所给的关键字
     * @returns 对象
    */
    async function XzGradeBase_GetNameByid_GradeBase_Cache(strid_GradeBase) {
        const strThisFuncName = "GetNameByid_GradeBase_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strid_GradeBase) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strid_GradeBase]不能为空！(In GetNameByid_GradeBase_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_GradeBase.length != 4) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strid_GradeBase]的长度:[{0}]不正确！", strid_GradeBase.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrXzGradeBaseObjLst_Cache = await XzGradeBase_GetObjLst_Cache();
        if (arrXzGradeBaseObjLst_Cache == null)
            return "";
        try {
            const arrXzGradeBase_Sel = arrXzGradeBaseObjLst_Cache.filter(x => x.id_GradeBase == strid_GradeBase);
            let objXzGradeBase;
            if (arrXzGradeBase_Sel.length > 0) {
                objXzGradeBase = arrXzGradeBase_Sel[0];
                return objXzGradeBase.gradeBaseName;
            }
            else {
                return "";
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象名称属性不成功!", e, strid_GradeBase);
            console.error(strMsg);
            alert(strMsg);
        }
        return "";
    }
    exports.XzGradeBase_GetNameByid_GradeBase_Cache = XzGradeBase_GetNameByid_GradeBase_Cache;
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
    async function XzGradeBase_func(strInFldName, strOutFldName, strInValue) {
        //const strThisFuncName = "func";
        if (strInFldName != clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_id_GradeBase) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_1.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strInFldName, clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strid_GradeBase = strInValue;
        if ((0, clsString_js_1.IsNullOrEmpty)(strInValue) == true) {
            return "";
        }
        const objXzGradeBase = await XzGradeBase_GetObjByid_GradeBase_Cache(strid_GradeBase);
        if (objXzGradeBase == null)
            return "";
        return objXzGradeBase.GetFldValue(strOutFldName).toString();
    }
    exports.XzGradeBase_func = XzGradeBase_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function XzGradeBase_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.id_GradeBase.localeCompare(b.id_GradeBase);
    }
    exports.XzGradeBase_SortFun_Defa = XzGradeBase_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function XzGradeBase_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.gradeBaseID == b.gradeBaseID)
            return a.gradeBaseName.localeCompare(b.gradeBaseName);
        else
            return a.gradeBaseID.localeCompare(b.gradeBaseID);
    }
    exports.XzGradeBase_SortFun_Defa_2Fld = XzGradeBase_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function XzGradeBase_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_id_GradeBase:
                    return (a, b) => {
                        return a.id_GradeBase.localeCompare(b.id_GradeBase);
                    };
                case clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_GradeBaseID:
                    return (a, b) => {
                        return a.gradeBaseID.localeCompare(b.gradeBaseID);
                    };
                case clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_GradeBaseName:
                    return (a, b) => {
                        return a.gradeBaseName.localeCompare(b.gradeBaseName);
                    };
                case clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_GradeBaseNameA:
                    return (a, b) => {
                        return a.gradeBaseNameA.localeCompare(b.gradeBaseNameA);
                    };
                case clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_SchoolYear:
                    return (a, b) => {
                        return a.schoolYear.localeCompare(b.schoolYear);
                    };
                case clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_SchoolTerm:
                    return (a, b) => {
                        return a.schoolTerm.localeCompare(b.schoolTerm);
                    };
                case clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_EnterSchoolDate:
                    return (a, b) => {
                        return a.enterSchoolDate.localeCompare(b.enterSchoolDate);
                    };
                case clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_CurrentTermSeq:
                    return (a, b) => {
                        return a.currentTermSeq - b.currentTermSeq;
                    };
                case clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_ExecPlanTermIndex:
                    return (a, b) => {
                        return a.execPlanTermIndex - b.execPlanTermIndex;
                    };
                case clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_SetEPTermIndexDate:
                    return (a, b) => {
                        return a.setEPTermIndexDate.localeCompare(b.setEPTermIndexDate);
                    };
                case clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_IsOffed:
                    return (a, b) => {
                        if (a.isOffed == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_GradeIndex:
                    return (a, b) => {
                        return a.gradeIndex - b.gradeIndex;
                    };
                case clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_BeginYearMonth:
                    return (a, b) => {
                        return a.beginYearMonth.localeCompare(b.beginYearMonth);
                    };
                case clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_EndYearMonth:
                    return (a, b) => {
                        return a.endYearMonth.localeCompare(b.endYearMonth);
                    };
                case clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_AllowUpBaseInfo:
                    return (a, b) => {
                        if (a.allowUpBaseInfo == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_Prefix:
                    return (a, b) => {
                        return a.prefix.localeCompare(b.prefix);
                    };
                case clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_PointCalcVersionId:
                    return (a, b) => {
                        return a.pointCalcVersionId.localeCompare(b.pointCalcVersionId);
                    };
                case clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_ModifyUserID:
                    return (a, b) => {
                        return a.modifyUserID.localeCompare(b.modifyUserID);
                    };
                case clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_ModifyDate:
                    return (a, b) => {
                        return a.modifyDate.localeCompare(b.modifyDate);
                    };
                case clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_id_StudyLevel:
                    return (a, b) => {
                        return a.id_StudyLevel.localeCompare(b.id_StudyLevel);
                    };
                case clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_IsVisible:
                    return (a, b) => {
                        if (a.isVisible == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_Memo:
                    return (a, b) => {
                        return a.memo.localeCompare(b.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[XzGradeBase]中不存在！(in ${exports.xzGradeBase_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_id_GradeBase:
                    return (a, b) => {
                        return b.id_GradeBase.localeCompare(a.id_GradeBase);
                    };
                case clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_GradeBaseID:
                    return (a, b) => {
                        return b.gradeBaseID.localeCompare(a.gradeBaseID);
                    };
                case clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_GradeBaseName:
                    return (a, b) => {
                        return b.gradeBaseName.localeCompare(a.gradeBaseName);
                    };
                case clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_GradeBaseNameA:
                    return (a, b) => {
                        return b.gradeBaseNameA.localeCompare(a.gradeBaseNameA);
                    };
                case clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_SchoolYear:
                    return (a, b) => {
                        return b.schoolYear.localeCompare(a.schoolYear);
                    };
                case clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_SchoolTerm:
                    return (a, b) => {
                        return b.schoolTerm.localeCompare(a.schoolTerm);
                    };
                case clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_EnterSchoolDate:
                    return (a, b) => {
                        return b.enterSchoolDate.localeCompare(a.enterSchoolDate);
                    };
                case clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_CurrentTermSeq:
                    return (a, b) => {
                        return b.currentTermSeq - a.currentTermSeq;
                    };
                case clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_ExecPlanTermIndex:
                    return (a, b) => {
                        return b.execPlanTermIndex - a.execPlanTermIndex;
                    };
                case clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_SetEPTermIndexDate:
                    return (a, b) => {
                        return b.setEPTermIndexDate.localeCompare(a.setEPTermIndexDate);
                    };
                case clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_IsOffed:
                    return (a, b) => {
                        if (b.isOffed == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_GradeIndex:
                    return (a, b) => {
                        return b.gradeIndex - a.gradeIndex;
                    };
                case clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_BeginYearMonth:
                    return (a, b) => {
                        return b.beginYearMonth.localeCompare(a.beginYearMonth);
                    };
                case clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_EndYearMonth:
                    return (a, b) => {
                        return b.endYearMonth.localeCompare(a.endYearMonth);
                    };
                case clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_AllowUpBaseInfo:
                    return (a, b) => {
                        if (b.allowUpBaseInfo == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_Prefix:
                    return (a, b) => {
                        return b.prefix.localeCompare(a.prefix);
                    };
                case clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_PointCalcVersionId:
                    return (a, b) => {
                        return b.pointCalcVersionId.localeCompare(a.pointCalcVersionId);
                    };
                case clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_ModifyUserID:
                    return (a, b) => {
                        return b.modifyUserID.localeCompare(a.modifyUserID);
                    };
                case clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_ModifyDate:
                    return (a, b) => {
                        return b.modifyDate.localeCompare(a.modifyDate);
                    };
                case clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_id_StudyLevel:
                    return (a, b) => {
                        return b.id_StudyLevel.localeCompare(a.id_StudyLevel);
                    };
                case clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_IsVisible:
                    return (a, b) => {
                        if (b.isVisible == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_Memo:
                    return (a, b) => {
                        return b.memo.localeCompare(a.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[XzGradeBase]中不存在！(in ${exports.xzGradeBase_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.XzGradeBase_SortFunByKey = XzGradeBase_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function XzGradeBase_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_id_GradeBase:
                return (obj) => {
                    return obj.id_GradeBase === value;
                };
            case clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_GradeBaseID:
                return (obj) => {
                    return obj.gradeBaseID === value;
                };
            case clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_GradeBaseName:
                return (obj) => {
                    return obj.gradeBaseName === value;
                };
            case clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_GradeBaseNameA:
                return (obj) => {
                    return obj.gradeBaseNameA === value;
                };
            case clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_SchoolYear:
                return (obj) => {
                    return obj.schoolYear === value;
                };
            case clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_SchoolTerm:
                return (obj) => {
                    return obj.schoolTerm === value;
                };
            case clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_EnterSchoolDate:
                return (obj) => {
                    return obj.enterSchoolDate === value;
                };
            case clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_CurrentTermSeq:
                return (obj) => {
                    return obj.currentTermSeq === value;
                };
            case clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_ExecPlanTermIndex:
                return (obj) => {
                    return obj.execPlanTermIndex === value;
                };
            case clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_SetEPTermIndexDate:
                return (obj) => {
                    return obj.setEPTermIndexDate === value;
                };
            case clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_IsOffed:
                return (obj) => {
                    return obj.isOffed === value;
                };
            case clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_GradeIndex:
                return (obj) => {
                    return obj.gradeIndex === value;
                };
            case clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_BeginYearMonth:
                return (obj) => {
                    return obj.beginYearMonth === value;
                };
            case clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_EndYearMonth:
                return (obj) => {
                    return obj.endYearMonth === value;
                };
            case clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_AllowUpBaseInfo:
                return (obj) => {
                    return obj.allowUpBaseInfo === value;
                };
            case clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_Prefix:
                return (obj) => {
                    return obj.prefix === value;
                };
            case clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_PointCalcVersionId:
                return (obj) => {
                    return obj.pointCalcVersionId === value;
                };
            case clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_ModifyUserID:
                return (obj) => {
                    return obj.modifyUserID === value;
                };
            case clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_ModifyDate:
                return (obj) => {
                    return obj.modifyDate === value;
                };
            case clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_id_StudyLevel:
                return (obj) => {
                    return obj.id_StudyLevel === value;
                };
            case clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_IsVisible:
                return (obj) => {
                    return obj.isVisible === value;
                };
            case clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[XzGradeBase]中不存在！(in ${exports.xzGradeBase_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.XzGradeBase_FilterFunByKey = XzGradeBase_FilterFunByKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function XzGradeBase_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzGradeBase_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzGradeBase_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzGradeBase_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzGradeBase_GetFirstIDAsync = XzGradeBase_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function XzGradeBase_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzGradeBase_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzGradeBase_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzGradeBase_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzGradeBase_GetFirstID = XzGradeBase_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function XzGradeBase_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzGradeBase_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.xzGradeBase_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objXzGradeBase = XzGradeBase_GetObjFromJsonObj(returnObj);
                return objXzGradeBase;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzGradeBase_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzGradeBase_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzGradeBase_GetFirstObjAsync = XzGradeBase_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function XzGradeBase_GetObjLst_ClientCache() {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsXzGradeBaseEN_js_1.clsXzGradeBaseEN._CurrTabName;
        clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsXzGradeBaseEN_js_1.clsXzGradeBaseEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_2.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrXzGradeBaseExObjLst_Cache = CacheHelper_js_2.CacheHelper.Get(strKey);
            const arrXzGradeBaseObjLst_T = XzGradeBase_GetObjLstByJSONObjLst(arrXzGradeBaseExObjLst_Cache);
            return arrXzGradeBaseObjLst_T;
        }
        try {
            const arrXzGradeBaseExObjLst = await XzGradeBase_GetObjLstAsync(strWhereCond);
            CacheHelper_js_2.CacheHelper.Add(strKey, arrXzGradeBaseExObjLst);
            const strInfo = (0, clsString_js_1.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrXzGradeBaseExObjLst.length);
            console.log(strInfo);
            return arrXzGradeBaseExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.xzGradeBase_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.XzGradeBase_GetObjLst_ClientCache = XzGradeBase_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function XzGradeBase_GetObjLst_localStorage() {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsXzGradeBaseEN_js_1.clsXzGradeBaseEN._CurrTabName;
        clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsXzGradeBaseEN_js_1.clsXzGradeBaseEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrXzGradeBaseExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrXzGradeBaseObjLst_T = XzGradeBase_GetObjLstByJSONObjLst(arrXzGradeBaseExObjLst_Cache);
            return arrXzGradeBaseObjLst_T;
        }
        try {
            const arrXzGradeBaseExObjLst = await XzGradeBase_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrXzGradeBaseExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrXzGradeBaseExObjLst.length);
            console.log(strInfo);
            return arrXzGradeBaseExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.xzGradeBase_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.XzGradeBase_GetObjLst_localStorage = XzGradeBase_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function XzGradeBase_GetObjLst_localStorage_PureCache() {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsXzGradeBaseEN_js_1.clsXzGradeBaseEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrXzGradeBaseObjLst_Cache = JSON.parse(strTempObjLst);
            return arrXzGradeBaseObjLst_Cache;
        }
        else
            return null;
    }
    exports.XzGradeBase_GetObjLst_localStorage_PureCache = XzGradeBase_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function XzGradeBase_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzGradeBase_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.xzGradeBase_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = XzGradeBase_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzGradeBase_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzGradeBase_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzGradeBase_GetObjLstAsync = XzGradeBase_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function XzGradeBase_GetObjLst_sessionStorage() {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsXzGradeBaseEN_js_1.clsXzGradeBaseEN._CurrTabName;
        clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsXzGradeBaseEN_js_1.clsXzGradeBaseEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrXzGradeBaseExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrXzGradeBaseObjLst_T = XzGradeBase_GetObjLstByJSONObjLst(arrXzGradeBaseExObjLst_Cache);
            return arrXzGradeBaseObjLst_T;
        }
        try {
            const arrXzGradeBaseExObjLst = await XzGradeBase_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrXzGradeBaseExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrXzGradeBaseExObjLst.length);
            console.log(strInfo);
            return arrXzGradeBaseExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.xzGradeBase_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.XzGradeBase_GetObjLst_sessionStorage = XzGradeBase_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function XzGradeBase_GetObjLst_sessionStorage_PureCache() {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsXzGradeBaseEN_js_1.clsXzGradeBaseEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrXzGradeBaseObjLst_Cache = JSON.parse(strTempObjLst);
            return arrXzGradeBaseObjLst_Cache;
        }
        else
            return null;
    }
    exports.XzGradeBase_GetObjLst_sessionStorage_PureCache = XzGradeBase_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function XzGradeBase_GetObjLst_Cache() {
        //const strThisFuncName = "GetObjLst_Cache";
        let arrXzGradeBaseObjLst_Cache;
        switch (clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.CacheModeId) {
            case "04": //sessionStorage
                arrXzGradeBaseObjLst_Cache = await XzGradeBase_GetObjLst_sessionStorage();
                break;
            case "03": //localStorage
                arrXzGradeBaseObjLst_Cache = await XzGradeBase_GetObjLst_localStorage();
                break;
            case "02": //ClientCache
                arrXzGradeBaseObjLst_Cache = await XzGradeBase_GetObjLst_ClientCache();
                break;
            default:
                arrXzGradeBaseObjLst_Cache = await XzGradeBase_GetObjLst_ClientCache();
                break;
        }
        const arrXzGradeBaseObjLst = XzGradeBase_GetObjLstByJSONObjLst(arrXzGradeBaseObjLst_Cache);
        return arrXzGradeBaseObjLst_Cache;
    }
    exports.XzGradeBase_GetObjLst_Cache = XzGradeBase_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function XzGradeBase_GetObjLst_PureCache() {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrXzGradeBaseObjLst_Cache;
        switch (clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.CacheModeId) {
            case "04": //sessionStorage
                arrXzGradeBaseObjLst_Cache = await XzGradeBase_GetObjLst_sessionStorage_PureCache();
                break;
            case "03": //localStorage
                arrXzGradeBaseObjLst_Cache = await XzGradeBase_GetObjLst_localStorage_PureCache();
                break;
            case "02": //ClientCache
                arrXzGradeBaseObjLst_Cache = null;
                break;
            default:
                arrXzGradeBaseObjLst_Cache = null;
                break;
        }
        return arrXzGradeBaseObjLst_Cache;
    }
    exports.XzGradeBase_GetObjLst_PureCache = XzGradeBase_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objstrid_GradeBase_Cond:条件对象
     * @returns 对象列表子集
    */
    async function XzGradeBase_GetSubObjLst_Cache(objXzGradeBase_Cond) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrXzGradeBaseObjLst_Cache = await XzGradeBase_GetObjLst_Cache();
        let arrXzGradeBase_Sel = arrXzGradeBaseObjLst_Cache;
        if (objXzGradeBase_Cond.sf_FldComparisonOp == null || objXzGradeBase_Cond.sf_FldComparisonOp == "")
            return arrXzGradeBase_Sel;
        const dicFldComparisonOp = JSON.parse(objXzGradeBase_Cond.sf_FldComparisonOp);
        //console.log("clsXzGradeBaseWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objXzGradeBase_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrXzGradeBase_Sel = arrXzGradeBase_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objXzGradeBase_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzGradeBase_Sel = arrXzGradeBase_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrXzGradeBase_Sel = arrXzGradeBase_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzGradeBase_Sel = arrXzGradeBase_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzGradeBase_Sel = arrXzGradeBase_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrXzGradeBase_Sel = arrXzGradeBase_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrXzGradeBase_Sel = arrXzGradeBase_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrXzGradeBase_Sel = arrXzGradeBase_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrXzGradeBase_Sel = arrXzGradeBase_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrXzGradeBase_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objXzGradeBase_Cond), exports.xzGradeBase_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.XzGradeBase_GetSubObjLst_Cache = XzGradeBase_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrid_GradeBase:关键字列表
    * @returns 对象列表
    **/
    async function XzGradeBase_GetObjLstByid_GradeBaseLstAsync(arrid_GradeBase) {
        const strThisFuncName = "GetObjLstByid_GradeBaseLstAsync";
        const strAction = "GetObjLstByid_GradeBaseLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzGradeBase_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrid_GradeBase);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.xzGradeBase_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = XzGradeBase_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzGradeBase_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzGradeBase_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzGradeBase_GetObjLstByid_GradeBaseLstAsync = XzGradeBase_GetObjLstByid_GradeBaseLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrstrid_GradeBaseLst:关键字列表
     * @returns 对象列表
    */
    async function XzGradeBase_GetObjLstByid_GradeBaseLst_Cache(arrid_GradeBaseLst) {
        const strThisFuncName = "GetObjLstByid_GradeBaseLst_Cache";
        try {
            const arrXzGradeBaseObjLst_Cache = await XzGradeBase_GetObjLst_Cache();
            const arrXzGradeBase_Sel = arrXzGradeBaseObjLst_Cache.filter(x => arrid_GradeBaseLst.indexOf(x.id_GradeBase) > -1);
            return arrXzGradeBase_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrid_GradeBaseLst.join(","), exports.xzGradeBase_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.XzGradeBase_GetObjLstByid_GradeBaseLst_Cache = XzGradeBase_GetObjLstByid_GradeBaseLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function XzGradeBase_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzGradeBase_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.xzGradeBase_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = XzGradeBase_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzGradeBase_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzGradeBase_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzGradeBase_GetTopObjLstAsync = XzGradeBase_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function XzGradeBase_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzGradeBase_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.xzGradeBase_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = XzGradeBase_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzGradeBase_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzGradeBase_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzGradeBase_GetObjLstByRangeAsync = XzGradeBase_GetObjLstByRangeAsync;
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
    async function XzGradeBase_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzGradeBase_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzGradeBase_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzGradeBase_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzGradeBase_GetObjLstByRange = XzGradeBase_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function XzGradeBase_GetObjLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const arrXzGradeBaseObjLst_Cache = await XzGradeBase_GetObjLst_Cache();
        if (arrXzGradeBaseObjLst_Cache.length == 0)
            return arrXzGradeBaseObjLst_Cache;
        let arrXzGradeBase_Sel = arrXzGradeBaseObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objXzGradeBase_Cond = new clsXzGradeBaseEN_js_1.clsXzGradeBaseEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objXzGradeBase_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsXzGradeBaseWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrXzGradeBase_Sel = arrXzGradeBase_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objXzGradeBase_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzGradeBase_Sel = arrXzGradeBase_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrXzGradeBase_Sel = arrXzGradeBase_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrXzGradeBase_Sel = arrXzGradeBase_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzGradeBase_Sel = arrXzGradeBase_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzGradeBase_Sel = arrXzGradeBase_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrXzGradeBase_Sel = arrXzGradeBase_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrXzGradeBase_Sel = arrXzGradeBase_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrXzGradeBase_Sel = arrXzGradeBase_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrXzGradeBase_Sel = arrXzGradeBase_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrXzGradeBase_Sel.length == 0)
                return arrXzGradeBase_Sel;
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
                arrXzGradeBase_Sel = arrXzGradeBase_Sel.sort(XzGradeBase_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrXzGradeBase_Sel = arrXzGradeBase_Sel.sort(objPagerPara.sortFun);
            }
            arrXzGradeBase_Sel = arrXzGradeBase_Sel.slice(intStart, intEnd);
            return arrXzGradeBase_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.xzGradeBase_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.XzGradeBase_GetObjLstByPager_Cache = XzGradeBase_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function XzGradeBase_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzGradeBase_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.xzGradeBase_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = XzGradeBase_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzGradeBase_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzGradeBase_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzGradeBase_GetObjLstByPagerAsync = XzGradeBase_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param strid_GradeBase:关键字
    * @returns 获取删除的结果
    **/
    async function XzGradeBase_DelRecordAsync(strid_GradeBase) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzGradeBase_Controller, strAction);
        strUrl = (0, clsString_js_1.Format)("{0}/?Id={1}", strUrl, strid_GradeBase);
        try {
            const response = await axios_1.default.delete(strUrl, {
                params: { "Id": strid_GradeBase, }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzGradeBase_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzGradeBase_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzGradeBase_DelRecordAsync = XzGradeBase_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrid_GradeBase:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function XzGradeBase_DelXzGradeBasesAsync(arrid_GradeBase) {
        const strThisFuncName = "DelXzGradeBasesAsync";
        const strAction = "DelXzGradeBases";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzGradeBase_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrid_GradeBase);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzGradeBase_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzGradeBase_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzGradeBase_DelXzGradeBasesAsync = XzGradeBase_DelXzGradeBasesAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function XzGradeBase_DelXzGradeBasesByCondAsync(strWhereCond) {
        const strThisFuncName = "DelXzGradeBasesByCondAsync";
        const strAction = "DelXzGradeBasesByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzGradeBase_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzGradeBase_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzGradeBase_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzGradeBase_DelXzGradeBasesByCondAsync = XzGradeBase_DelXzGradeBasesByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objXzGradeBaseEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function XzGradeBase_AddNewRecordAsync(objXzGradeBaseEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        if (objXzGradeBaseEN.id_GradeBase === null || objXzGradeBaseEN.id_GradeBase === "") {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            throw strMsg;
        }
        //var strJSON = JSON.stringify(objXzGradeBaseEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzGradeBase_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objXzGradeBaseEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzGradeBase_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzGradeBase_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzGradeBase_AddNewRecordAsync = XzGradeBase_AddNewRecordAsync;
    /**
    * 调用WebApi来添加记录，关键字用最大关键字，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithMaxIdAsync)
    * @param objXzGradeBaseEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function XzGradeBase_AddNewRecordWithMaxIdAsync(objXzGradeBaseEN) {
        const strThisFuncName = "AddNewRecordWithMaxIdAsync";
        const strAction = "AddNewRecordWithMaxId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzGradeBase_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objXzGradeBaseEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzGradeBase_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzGradeBase_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzGradeBase_AddNewRecordWithMaxIdAsync = XzGradeBase_AddNewRecordWithMaxIdAsync;
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objXzGradeBaseEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function XzGradeBase_AddNewRecordWithReturnKeyAsync(objXzGradeBaseEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzGradeBase_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objXzGradeBaseEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzGradeBase_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzGradeBase_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzGradeBase_AddNewRecordWithReturnKeyAsync = XzGradeBase_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objXzGradeBaseEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function XzGradeBase_AddNewRecordWithReturnKey(objXzGradeBaseEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objXzGradeBaseEN.id_GradeBase === null || objXzGradeBaseEN.id_GradeBase === "") {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzGradeBase_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objXzGradeBaseEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzGradeBase_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzGradeBase_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzGradeBase_AddNewRecordWithReturnKey = XzGradeBase_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objXzGradeBaseEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function XzGradeBase_UpdateRecordAsync(objXzGradeBaseEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objXzGradeBaseEN.sf_UpdFldSetStr === undefined || objXzGradeBaseEN.sf_UpdFldSetStr === null || objXzGradeBaseEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objXzGradeBaseEN.id_GradeBase);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzGradeBase_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objXzGradeBaseEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzGradeBase_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzGradeBase_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzGradeBase_UpdateRecordAsync = XzGradeBase_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objXzGradeBaseEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function XzGradeBase_UpdateWithConditionAsync(objXzGradeBaseEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objXzGradeBaseEN.sf_UpdFldSetStr === undefined || objXzGradeBaseEN.sf_UpdFldSetStr === null || objXzGradeBaseEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objXzGradeBaseEN.id_GradeBase);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzGradeBase_Controller, strAction);
        objXzGradeBaseEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objXzGradeBaseEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzGradeBase_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzGradeBase_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzGradeBase_UpdateWithConditionAsync = XzGradeBase_UpdateWithConditionAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objstrid_GradeBase_Cond:条件对象
     * @returns 对象列表子集
    */
    async function XzGradeBase_IsExistRecord_Cache(objXzGradeBase_Cond) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrXzGradeBaseObjLst_Cache = await XzGradeBase_GetObjLst_Cache();
        if (arrXzGradeBaseObjLst_Cache == null)
            return false;
        let arrXzGradeBase_Sel = arrXzGradeBaseObjLst_Cache;
        if (objXzGradeBase_Cond.sf_FldComparisonOp == null || objXzGradeBase_Cond.sf_FldComparisonOp == "")
            return arrXzGradeBase_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objXzGradeBase_Cond.sf_FldComparisonOp);
        //console.log("clsXzGradeBaseWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objXzGradeBase_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objXzGradeBase_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzGradeBase_Sel = arrXzGradeBase_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrXzGradeBase_Sel = arrXzGradeBase_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzGradeBase_Sel = arrXzGradeBase_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzGradeBase_Sel = arrXzGradeBase_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrXzGradeBase_Sel = arrXzGradeBase_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrXzGradeBase_Sel = arrXzGradeBase_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrXzGradeBase_Sel = arrXzGradeBase_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrXzGradeBase_Sel = arrXzGradeBase_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrXzGradeBase_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objXzGradeBase_Cond), exports.xzGradeBase_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.XzGradeBase_IsExistRecord_Cache = XzGradeBase_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function XzGradeBase_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzGradeBase_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzGradeBase_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzGradeBase_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzGradeBase_IsExistRecordAsync = XzGradeBase_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strid_GradeBase:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function XzGradeBase_IsExist(strid_GradeBase, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzGradeBase_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "id_GradeBase": strid_GradeBase,
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzGradeBase_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzGradeBase_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzGradeBase_IsExist = XzGradeBase_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param strid_GradeBase:所给的关键字
     * @returns 对象
    */
    async function XzGradeBase_IsExist_Cache(strid_GradeBase) {
        const strThisFuncName = "IsExist_Cache";
        const arrXzGradeBaseObjLst_Cache = await XzGradeBase_GetObjLst_Cache();
        if (arrXzGradeBaseObjLst_Cache == null)
            return false;
        try {
            const arrXzGradeBase_Sel = arrXzGradeBaseObjLst_Cache.filter(x => x.id_GradeBase == strid_GradeBase);
            if (arrXzGradeBase_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strid_GradeBase, exports.xzGradeBase_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.XzGradeBase_IsExist_Cache = XzGradeBase_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strid_GradeBase:关键字
    * @returns 是否存在?存在返回True
    **/
    async function XzGradeBase_IsExistAsync(strid_GradeBase) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzGradeBase_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strid_GradeBase": strid_GradeBase }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzGradeBase_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzGradeBase_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzGradeBase_IsExistAsync = XzGradeBase_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function XzGradeBase_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzGradeBase_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzGradeBase_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzGradeBase_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzGradeBase_GetRecCountByCondAsync = XzGradeBase_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objXzGradeBase_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function XzGradeBase_GetRecCountByCond_Cache(objXzGradeBase_Cond) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrXzGradeBaseObjLst_Cache = await XzGradeBase_GetObjLst_Cache();
        if (arrXzGradeBaseObjLst_Cache == null)
            return 0;
        let arrXzGradeBase_Sel = arrXzGradeBaseObjLst_Cache;
        if (objXzGradeBase_Cond.sf_FldComparisonOp == null || objXzGradeBase_Cond.sf_FldComparisonOp == "")
            return arrXzGradeBase_Sel.length;
        const dicFldComparisonOp = JSON.parse(objXzGradeBase_Cond.sf_FldComparisonOp);
        //console.log("clsXzGradeBaseWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objXzGradeBase_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrXzGradeBase_Sel = arrXzGradeBase_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objXzGradeBase_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzGradeBase_Sel = arrXzGradeBase_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrXzGradeBase_Sel = arrXzGradeBase_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrXzGradeBase_Sel = arrXzGradeBase_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzGradeBase_Sel = arrXzGradeBase_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzGradeBase_Sel = arrXzGradeBase_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrXzGradeBase_Sel = arrXzGradeBase_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrXzGradeBase_Sel = arrXzGradeBase_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrXzGradeBase_Sel = arrXzGradeBase_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrXzGradeBase_Sel = arrXzGradeBase_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrXzGradeBase_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objXzGradeBase_Cond), exports.xzGradeBase_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.XzGradeBase_GetRecCountByCond_Cache = XzGradeBase_GetRecCountByCond_Cache;
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
    async function XzGradeBase_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzGradeBase_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzGradeBase_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzGradeBase_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzGradeBase_GetMaxStrIdByPrefix = XzGradeBase_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function XzGradeBase_GetWebApiUrl(strController, strAction) {
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
    exports.XzGradeBase_GetWebApiUrl = XzGradeBase_GetWebApiUrl;
    /**
    * 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshCache)
    **/
    function XzGradeBase_ReFreshCache() {
        const strThisFuncName = "ReFreshCache";
        const strMsg = (0, clsString_js_1.Format)("刷新缓存成功！");
        console.trace(strMsg);
        // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
        const strKey = clsXzGradeBaseEN_js_1.clsXzGradeBaseEN._CurrTabName;
        switch (clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.CacheModeId) {
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
    exports.XzGradeBase_ReFreshCache = XzGradeBase_ReFreshCache;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function XzGradeBase_ReFreshThisCache() {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = clsXzGradeBaseEN_js_1.clsXzGradeBaseEN._CurrTabName;
            switch (clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.CacheModeId) {
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
    exports.XzGradeBase_ReFreshThisCache = XzGradeBase_ReFreshThisCache;
    /**
     * 绑定基于Web的下拉框,在某一层下的下拉框
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunctionInDiv)
     * @param objDDL:需要绑定当前表的下拉框
    */
    async function XzGradeBase_BindDdl_id_GradeBaseInDiv_Cache(strDivName, strDdlName) {
        const strThisFuncName = "BindDdl_id_GradeBaseInDiv_Cache";
        const objDdl = document.getElementById(strDdlName);
        if (objDdl == null) {
            const strMsg = (0, clsString_js_1.Format)("下拉框：{0} 不存在！(In BindDdl_id_GradeBaseInDiv)", strDdlName);
            alert(strMsg);
            console.error(strMsg);
            throw (strMsg);
        }
        //为数据源于表的下拉框设置内容
        //console.log("开始：BindDdl_id_GradeBaseInDiv_Cache");
        const arrObjLst_Sel = await XzGradeBase_GetObjLst_Cache();
        if (arrObjLst_Sel == null)
            return;
        (0, clsCommFunc4Web_js_1.BindDdl_ObjLstInDiv)(strDivName, strDdlName, arrObjLst_Sel, clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_id_GradeBase, clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_GradeBaseName, "年级");
    }
    exports.XzGradeBase_BindDdl_id_GradeBaseInDiv_Cache = XzGradeBase_BindDdl_id_GradeBaseInDiv_Cache;
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function XzGradeBase_CheckPropertyNew(pobjXzGradeBaseEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzGradeBaseEN.gradeBaseID) === true) {
            throw new Error("(errid:Watl000058)字段[年级代号]不能为空(In 年级)!(clsXzGradeBaseBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzGradeBaseEN.gradeBaseName) === true) {
            throw new Error("(errid:Watl000058)字段[年级名称]不能为空(In 年级)!(clsXzGradeBaseBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzGradeBaseEN.schoolYear) === true
            || pobjXzGradeBaseEN.schoolYear.toString() === "0") {
            throw new Error("(errid:Watl000058)字段[学年]不能为空(In 年级)!(clsXzGradeBaseBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzGradeBaseEN.schoolTerm) === true
            || pobjXzGradeBaseEN.schoolTerm.toString() === "0") {
            throw new Error("(errid:Watl000058)字段[学期]不能为空(In 年级)!(clsXzGradeBaseBL:CheckPropertyNew)");
        }
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzGradeBaseEN.id_GradeBase) == false && (0, clsString_js_1.GetStrLen)(pobjXzGradeBaseEN.id_GradeBase) > 4) {
            throw new Error("(errid:Watl000059)字段[年级流水号(id_GradeBase)]的长度不能超过4(In 年级(XzGradeBase))!值:$(pobjXzGradeBaseEN.id_GradeBase)(clsXzGradeBaseBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzGradeBaseEN.gradeBaseID) == false && (0, clsString_js_1.GetStrLen)(pobjXzGradeBaseEN.gradeBaseID) > 4) {
            throw new Error("(errid:Watl000059)字段[年级代号(gradeBaseID)]的长度不能超过4(In 年级(XzGradeBase))!值:$(pobjXzGradeBaseEN.gradeBaseID)(clsXzGradeBaseBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzGradeBaseEN.gradeBaseName) == false && (0, clsString_js_1.GetStrLen)(pobjXzGradeBaseEN.gradeBaseName) > 50) {
            throw new Error("(errid:Watl000059)字段[年级名称(gradeBaseName)]的长度不能超过50(In 年级(XzGradeBase))!值:$(pobjXzGradeBaseEN.gradeBaseName)(clsXzGradeBaseBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzGradeBaseEN.gradeBaseNameA) == false && (0, clsString_js_1.GetStrLen)(pobjXzGradeBaseEN.gradeBaseNameA) > 10) {
            throw new Error("(errid:Watl000059)字段[年级名称缩写(gradeBaseNameA)]的长度不能超过10(In 年级(XzGradeBase))!值:$(pobjXzGradeBaseEN.gradeBaseNameA)(clsXzGradeBaseBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzGradeBaseEN.schoolYear) == false && (0, clsString_js_1.GetStrLen)(pobjXzGradeBaseEN.schoolYear) > 10) {
            throw new Error("(errid:Watl000059)字段[学年(schoolYear)]的长度不能超过10(In 年级(XzGradeBase))!值:$(pobjXzGradeBaseEN.schoolYear)(clsXzGradeBaseBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzGradeBaseEN.schoolTerm) == false && (0, clsString_js_1.GetStrLen)(pobjXzGradeBaseEN.schoolTerm) > 1) {
            throw new Error("(errid:Watl000059)字段[学期(schoolTerm)]的长度不能超过1(In 年级(XzGradeBase))!值:$(pobjXzGradeBaseEN.schoolTerm)(clsXzGradeBaseBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzGradeBaseEN.enterSchoolDate) == false && (0, clsString_js_1.GetStrLen)(pobjXzGradeBaseEN.enterSchoolDate) > 8) {
            throw new Error("(errid:Watl000059)字段[进校日期(enterSchoolDate)]的长度不能超过8(In 年级(XzGradeBase))!值:$(pobjXzGradeBaseEN.enterSchoolDate)(clsXzGradeBaseBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzGradeBaseEN.setEPTermIndexDate) == false && (0, clsString_js_1.GetStrLen)(pobjXzGradeBaseEN.setEPTermIndexDate) > 8) {
            throw new Error("(errid:Watl000059)字段[设定执行计划学期日期(setEPTermIndexDate)]的长度不能超过8(In 年级(XzGradeBase))!值:$(pobjXzGradeBaseEN.setEPTermIndexDate)(clsXzGradeBaseBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzGradeBaseEN.beginYearMonth) == false && (0, clsString_js_1.GetStrLen)(pobjXzGradeBaseEN.beginYearMonth) > 8) {
            throw new Error("(errid:Watl000059)字段[开始年月(beginYearMonth)]的长度不能超过8(In 年级(XzGradeBase))!值:$(pobjXzGradeBaseEN.beginYearMonth)(clsXzGradeBaseBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzGradeBaseEN.endYearMonth) == false && (0, clsString_js_1.GetStrLen)(pobjXzGradeBaseEN.endYearMonth) > 8) {
            throw new Error("(errid:Watl000059)字段[结束年月(endYearMonth)]的长度不能超过8(In 年级(XzGradeBase))!值:$(pobjXzGradeBaseEN.endYearMonth)(clsXzGradeBaseBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzGradeBaseEN.prefix) == false && (0, clsString_js_1.GetStrLen)(pobjXzGradeBaseEN.prefix) > 3) {
            throw new Error("(errid:Watl000059)字段[前缀(prefix)]的长度不能超过3(In 年级(XzGradeBase))!值:$(pobjXzGradeBaseEN.prefix)(clsXzGradeBaseBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzGradeBaseEN.pointCalcVersionId) == false && (0, clsString_js_1.GetStrLen)(pobjXzGradeBaseEN.pointCalcVersionId) > 2) {
            throw new Error("(errid:Watl000059)字段[绩点计算版本Id(pointCalcVersionId)]的长度不能超过2(In 年级(XzGradeBase))!值:$(pobjXzGradeBaseEN.pointCalcVersionId)(clsXzGradeBaseBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzGradeBaseEN.modifyUserID) == false && (0, clsString_js_1.GetStrLen)(pobjXzGradeBaseEN.modifyUserID) > 18) {
            throw new Error("(errid:Watl000059)字段[修改人(modifyUserID)]的长度不能超过18(In 年级(XzGradeBase))!值:$(pobjXzGradeBaseEN.modifyUserID)(clsXzGradeBaseBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzGradeBaseEN.modifyDate) == false && (0, clsString_js_1.GetStrLen)(pobjXzGradeBaseEN.modifyDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(modifyDate)]的长度不能超过20(In 年级(XzGradeBase))!值:$(pobjXzGradeBaseEN.modifyDate)(clsXzGradeBaseBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzGradeBaseEN.id_StudyLevel) == false && (0, clsString_js_1.GetStrLen)(pobjXzGradeBaseEN.id_StudyLevel) > 4) {
            throw new Error("(errid:Watl000059)字段[id_StudyLevel(id_StudyLevel)]的长度不能超过4(In 年级(XzGradeBase))!值:$(pobjXzGradeBaseEN.id_StudyLevel)(clsXzGradeBaseBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzGradeBaseEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjXzGradeBaseEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 年级(XzGradeBase))!值:$(pobjXzGradeBaseEN.memo)(clsXzGradeBaseBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzGradeBaseEN.id_GradeBase) == false && undefined !== pobjXzGradeBaseEN.id_GradeBase && jsString_js_1.tzDataType.isString(pobjXzGradeBaseEN.id_GradeBase) === false) {
            throw new Error("(errid:Watl000060)字段[年级流水号(id_GradeBase)]的值:[$(pobjXzGradeBaseEN.id_GradeBase)], 非法，应该为字符型(In 年级(XzGradeBase))!(clsXzGradeBaseBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzGradeBaseEN.gradeBaseID) == false && undefined !== pobjXzGradeBaseEN.gradeBaseID && jsString_js_1.tzDataType.isString(pobjXzGradeBaseEN.gradeBaseID) === false) {
            throw new Error("(errid:Watl000060)字段[年级代号(gradeBaseID)]的值:[$(pobjXzGradeBaseEN.gradeBaseID)], 非法，应该为字符型(In 年级(XzGradeBase))!(clsXzGradeBaseBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzGradeBaseEN.gradeBaseName) == false && undefined !== pobjXzGradeBaseEN.gradeBaseName && jsString_js_1.tzDataType.isString(pobjXzGradeBaseEN.gradeBaseName) === false) {
            throw new Error("(errid:Watl000060)字段[年级名称(gradeBaseName)]的值:[$(pobjXzGradeBaseEN.gradeBaseName)], 非法，应该为字符型(In 年级(XzGradeBase))!(clsXzGradeBaseBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzGradeBaseEN.gradeBaseNameA) == false && undefined !== pobjXzGradeBaseEN.gradeBaseNameA && jsString_js_1.tzDataType.isString(pobjXzGradeBaseEN.gradeBaseNameA) === false) {
            throw new Error("(errid:Watl000060)字段[年级名称缩写(gradeBaseNameA)]的值:[$(pobjXzGradeBaseEN.gradeBaseNameA)], 非法，应该为字符型(In 年级(XzGradeBase))!(clsXzGradeBaseBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzGradeBaseEN.schoolYear) == false && undefined !== pobjXzGradeBaseEN.schoolYear && jsString_js_1.tzDataType.isString(pobjXzGradeBaseEN.schoolYear) === false) {
            throw new Error("(errid:Watl000060)字段[学年(schoolYear)]的值:[$(pobjXzGradeBaseEN.schoolYear)], 非法，应该为字符型(In 年级(XzGradeBase))!(clsXzGradeBaseBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzGradeBaseEN.schoolTerm) == false && undefined !== pobjXzGradeBaseEN.schoolTerm && jsString_js_1.tzDataType.isString(pobjXzGradeBaseEN.schoolTerm) === false) {
            throw new Error("(errid:Watl000060)字段[学期(schoolTerm)]的值:[$(pobjXzGradeBaseEN.schoolTerm)], 非法，应该为字符型(In 年级(XzGradeBase))!(clsXzGradeBaseBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzGradeBaseEN.enterSchoolDate) == false && undefined !== pobjXzGradeBaseEN.enterSchoolDate && jsString_js_1.tzDataType.isString(pobjXzGradeBaseEN.enterSchoolDate) === false) {
            throw new Error("(errid:Watl000060)字段[进校日期(enterSchoolDate)]的值:[$(pobjXzGradeBaseEN.enterSchoolDate)], 非法，应该为字符型(In 年级(XzGradeBase))!(clsXzGradeBaseBL:CheckPropertyNew)");
        }
        if (null != pobjXzGradeBaseEN.currentTermSeq && undefined !== pobjXzGradeBaseEN.currentTermSeq && jsString_js_1.tzDataType.isNumber(pobjXzGradeBaseEN.currentTermSeq) === false) {
            throw new Error("(errid:Watl000060)字段[当前学期(currentTermSeq)]的值:[$(pobjXzGradeBaseEN.currentTermSeq)], 非法，应该为数值型(In 年级(XzGradeBase))!(clsXzGradeBaseBL:CheckPropertyNew)");
        }
        if (null != pobjXzGradeBaseEN.execPlanTermIndex && undefined !== pobjXzGradeBaseEN.execPlanTermIndex && jsString_js_1.tzDataType.isNumber(pobjXzGradeBaseEN.execPlanTermIndex) === false) {
            throw new Error("(errid:Watl000060)字段[生成执行计划学期(execPlanTermIndex)]的值:[$(pobjXzGradeBaseEN.execPlanTermIndex)], 非法，应该为数值型(In 年级(XzGradeBase))!(clsXzGradeBaseBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzGradeBaseEN.setEPTermIndexDate) == false && undefined !== pobjXzGradeBaseEN.setEPTermIndexDate && jsString_js_1.tzDataType.isString(pobjXzGradeBaseEN.setEPTermIndexDate) === false) {
            throw new Error("(errid:Watl000060)字段[设定执行计划学期日期(setEPTermIndexDate)]的值:[$(pobjXzGradeBaseEN.setEPTermIndexDate)], 非法，应该为字符型(In 年级(XzGradeBase))!(clsXzGradeBaseBL:CheckPropertyNew)");
        }
        if (null != pobjXzGradeBaseEN.isOffed && undefined !== pobjXzGradeBaseEN.isOffed && jsString_js_1.tzDataType.isBoolean(pobjXzGradeBaseEN.isOffed) === false) {
            throw new Error("(errid:Watl000060)字段[是否毕业(isOffed)]的值:[$(pobjXzGradeBaseEN.isOffed)], 非法，应该为布尔型(In 年级(XzGradeBase))!(clsXzGradeBaseBL:CheckPropertyNew)");
        }
        if (null != pobjXzGradeBaseEN.gradeIndex && undefined !== pobjXzGradeBaseEN.gradeIndex && jsString_js_1.tzDataType.isNumber(pobjXzGradeBaseEN.gradeIndex) === false) {
            throw new Error("(errid:Watl000060)字段[年级序号(gradeIndex)]的值:[$(pobjXzGradeBaseEN.gradeIndex)], 非法，应该为数值型(In 年级(XzGradeBase))!(clsXzGradeBaseBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzGradeBaseEN.beginYearMonth) == false && undefined !== pobjXzGradeBaseEN.beginYearMonth && jsString_js_1.tzDataType.isString(pobjXzGradeBaseEN.beginYearMonth) === false) {
            throw new Error("(errid:Watl000060)字段[开始年月(beginYearMonth)]的值:[$(pobjXzGradeBaseEN.beginYearMonth)], 非法，应该为字符型(In 年级(XzGradeBase))!(clsXzGradeBaseBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzGradeBaseEN.endYearMonth) == false && undefined !== pobjXzGradeBaseEN.endYearMonth && jsString_js_1.tzDataType.isString(pobjXzGradeBaseEN.endYearMonth) === false) {
            throw new Error("(errid:Watl000060)字段[结束年月(endYearMonth)]的值:[$(pobjXzGradeBaseEN.endYearMonth)], 非法，应该为字符型(In 年级(XzGradeBase))!(clsXzGradeBaseBL:CheckPropertyNew)");
        }
        if (null != pobjXzGradeBaseEN.allowUpBaseInfo && undefined !== pobjXzGradeBaseEN.allowUpBaseInfo && jsString_js_1.tzDataType.isBoolean(pobjXzGradeBaseEN.allowUpBaseInfo) === false) {
            throw new Error("(errid:Watl000060)字段[允许修改基本信息(allowUpBaseInfo)]的值:[$(pobjXzGradeBaseEN.allowUpBaseInfo)], 非法，应该为布尔型(In 年级(XzGradeBase))!(clsXzGradeBaseBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzGradeBaseEN.prefix) == false && undefined !== pobjXzGradeBaseEN.prefix && jsString_js_1.tzDataType.isString(pobjXzGradeBaseEN.prefix) === false) {
            throw new Error("(errid:Watl000060)字段[前缀(prefix)]的值:[$(pobjXzGradeBaseEN.prefix)], 非法，应该为字符型(In 年级(XzGradeBase))!(clsXzGradeBaseBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzGradeBaseEN.pointCalcVersionId) == false && undefined !== pobjXzGradeBaseEN.pointCalcVersionId && jsString_js_1.tzDataType.isString(pobjXzGradeBaseEN.pointCalcVersionId) === false) {
            throw new Error("(errid:Watl000060)字段[绩点计算版本Id(pointCalcVersionId)]的值:[$(pobjXzGradeBaseEN.pointCalcVersionId)], 非法，应该为字符型(In 年级(XzGradeBase))!(clsXzGradeBaseBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzGradeBaseEN.modifyUserID) == false && undefined !== pobjXzGradeBaseEN.modifyUserID && jsString_js_1.tzDataType.isString(pobjXzGradeBaseEN.modifyUserID) === false) {
            throw new Error("(errid:Watl000060)字段[修改人(modifyUserID)]的值:[$(pobjXzGradeBaseEN.modifyUserID)], 非法，应该为字符型(In 年级(XzGradeBase))!(clsXzGradeBaseBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzGradeBaseEN.modifyDate) == false && undefined !== pobjXzGradeBaseEN.modifyDate && jsString_js_1.tzDataType.isString(pobjXzGradeBaseEN.modifyDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(modifyDate)]的值:[$(pobjXzGradeBaseEN.modifyDate)], 非法，应该为字符型(In 年级(XzGradeBase))!(clsXzGradeBaseBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzGradeBaseEN.id_StudyLevel) == false && undefined !== pobjXzGradeBaseEN.id_StudyLevel && jsString_js_1.tzDataType.isString(pobjXzGradeBaseEN.id_StudyLevel) === false) {
            throw new Error("(errid:Watl000060)字段[id_StudyLevel(id_StudyLevel)]的值:[$(pobjXzGradeBaseEN.id_StudyLevel)], 非法，应该为字符型(In 年级(XzGradeBase))!(clsXzGradeBaseBL:CheckPropertyNew)");
        }
        if (null != pobjXzGradeBaseEN.isVisible && undefined !== pobjXzGradeBaseEN.isVisible && jsString_js_1.tzDataType.isBoolean(pobjXzGradeBaseEN.isVisible) === false) {
            throw new Error("(errid:Watl000060)字段[是否显示(isVisible)]的值:[$(pobjXzGradeBaseEN.isVisible)], 非法，应该为布尔型(In 年级(XzGradeBase))!(clsXzGradeBaseBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzGradeBaseEN.memo) == false && undefined !== pobjXzGradeBaseEN.memo && jsString_js_1.tzDataType.isString(pobjXzGradeBaseEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjXzGradeBaseEN.memo)], 非法，应该为字符型(In 年级(XzGradeBase))!(clsXzGradeBaseBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjXzGradeBaseEN.SetIsCheckProperty(true);
    }
    exports.XzGradeBase_CheckPropertyNew = XzGradeBase_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function XzGradeBase_CheckProperty4Update(pobjXzGradeBaseEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzGradeBaseEN.id_GradeBase) == false && (0, clsString_js_1.GetStrLen)(pobjXzGradeBaseEN.id_GradeBase) > 4) {
            throw new Error("(errid:Watl000062)字段[年级流水号(id_GradeBase)]的长度不能超过4(In 年级(XzGradeBase))!值:$(pobjXzGradeBaseEN.id_GradeBase)(clsXzGradeBaseBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzGradeBaseEN.gradeBaseID) == false && (0, clsString_js_1.GetStrLen)(pobjXzGradeBaseEN.gradeBaseID) > 4) {
            throw new Error("(errid:Watl000062)字段[年级代号(gradeBaseID)]的长度不能超过4(In 年级(XzGradeBase))!值:$(pobjXzGradeBaseEN.gradeBaseID)(clsXzGradeBaseBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzGradeBaseEN.gradeBaseName) == false && (0, clsString_js_1.GetStrLen)(pobjXzGradeBaseEN.gradeBaseName) > 50) {
            throw new Error("(errid:Watl000062)字段[年级名称(gradeBaseName)]的长度不能超过50(In 年级(XzGradeBase))!值:$(pobjXzGradeBaseEN.gradeBaseName)(clsXzGradeBaseBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzGradeBaseEN.gradeBaseNameA) == false && (0, clsString_js_1.GetStrLen)(pobjXzGradeBaseEN.gradeBaseNameA) > 10) {
            throw new Error("(errid:Watl000062)字段[年级名称缩写(gradeBaseNameA)]的长度不能超过10(In 年级(XzGradeBase))!值:$(pobjXzGradeBaseEN.gradeBaseNameA)(clsXzGradeBaseBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzGradeBaseEN.schoolYear) == false && (0, clsString_js_1.GetStrLen)(pobjXzGradeBaseEN.schoolYear) > 10) {
            throw new Error("(errid:Watl000062)字段[学年(schoolYear)]的长度不能超过10(In 年级(XzGradeBase))!值:$(pobjXzGradeBaseEN.schoolYear)(clsXzGradeBaseBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzGradeBaseEN.schoolTerm) == false && (0, clsString_js_1.GetStrLen)(pobjXzGradeBaseEN.schoolTerm) > 1) {
            throw new Error("(errid:Watl000062)字段[学期(schoolTerm)]的长度不能超过1(In 年级(XzGradeBase))!值:$(pobjXzGradeBaseEN.schoolTerm)(clsXzGradeBaseBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzGradeBaseEN.enterSchoolDate) == false && (0, clsString_js_1.GetStrLen)(pobjXzGradeBaseEN.enterSchoolDate) > 8) {
            throw new Error("(errid:Watl000062)字段[进校日期(enterSchoolDate)]的长度不能超过8(In 年级(XzGradeBase))!值:$(pobjXzGradeBaseEN.enterSchoolDate)(clsXzGradeBaseBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzGradeBaseEN.setEPTermIndexDate) == false && (0, clsString_js_1.GetStrLen)(pobjXzGradeBaseEN.setEPTermIndexDate) > 8) {
            throw new Error("(errid:Watl000062)字段[设定执行计划学期日期(setEPTermIndexDate)]的长度不能超过8(In 年级(XzGradeBase))!值:$(pobjXzGradeBaseEN.setEPTermIndexDate)(clsXzGradeBaseBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzGradeBaseEN.beginYearMonth) == false && (0, clsString_js_1.GetStrLen)(pobjXzGradeBaseEN.beginYearMonth) > 8) {
            throw new Error("(errid:Watl000062)字段[开始年月(beginYearMonth)]的长度不能超过8(In 年级(XzGradeBase))!值:$(pobjXzGradeBaseEN.beginYearMonth)(clsXzGradeBaseBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzGradeBaseEN.endYearMonth) == false && (0, clsString_js_1.GetStrLen)(pobjXzGradeBaseEN.endYearMonth) > 8) {
            throw new Error("(errid:Watl000062)字段[结束年月(endYearMonth)]的长度不能超过8(In 年级(XzGradeBase))!值:$(pobjXzGradeBaseEN.endYearMonth)(clsXzGradeBaseBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzGradeBaseEN.prefix) == false && (0, clsString_js_1.GetStrLen)(pobjXzGradeBaseEN.prefix) > 3) {
            throw new Error("(errid:Watl000062)字段[前缀(prefix)]的长度不能超过3(In 年级(XzGradeBase))!值:$(pobjXzGradeBaseEN.prefix)(clsXzGradeBaseBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzGradeBaseEN.pointCalcVersionId) == false && (0, clsString_js_1.GetStrLen)(pobjXzGradeBaseEN.pointCalcVersionId) > 2) {
            throw new Error("(errid:Watl000062)字段[绩点计算版本Id(pointCalcVersionId)]的长度不能超过2(In 年级(XzGradeBase))!值:$(pobjXzGradeBaseEN.pointCalcVersionId)(clsXzGradeBaseBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzGradeBaseEN.modifyUserID) == false && (0, clsString_js_1.GetStrLen)(pobjXzGradeBaseEN.modifyUserID) > 18) {
            throw new Error("(errid:Watl000062)字段[修改人(modifyUserID)]的长度不能超过18(In 年级(XzGradeBase))!值:$(pobjXzGradeBaseEN.modifyUserID)(clsXzGradeBaseBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzGradeBaseEN.modifyDate) == false && (0, clsString_js_1.GetStrLen)(pobjXzGradeBaseEN.modifyDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(modifyDate)]的长度不能超过20(In 年级(XzGradeBase))!值:$(pobjXzGradeBaseEN.modifyDate)(clsXzGradeBaseBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzGradeBaseEN.id_StudyLevel) == false && (0, clsString_js_1.GetStrLen)(pobjXzGradeBaseEN.id_StudyLevel) > 4) {
            throw new Error("(errid:Watl000062)字段[id_StudyLevel(id_StudyLevel)]的长度不能超过4(In 年级(XzGradeBase))!值:$(pobjXzGradeBaseEN.id_StudyLevel)(clsXzGradeBaseBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzGradeBaseEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjXzGradeBaseEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 年级(XzGradeBase))!值:$(pobjXzGradeBaseEN.memo)(clsXzGradeBaseBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzGradeBaseEN.id_GradeBase) == false && undefined !== pobjXzGradeBaseEN.id_GradeBase && jsString_js_1.tzDataType.isString(pobjXzGradeBaseEN.id_GradeBase) === false) {
            throw new Error("(errid:Watl000063)字段[年级流水号(id_GradeBase)]的值:[$(pobjXzGradeBaseEN.id_GradeBase)], 非法，应该为字符型(In 年级(XzGradeBase))!(clsXzGradeBaseBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzGradeBaseEN.gradeBaseID) == false && undefined !== pobjXzGradeBaseEN.gradeBaseID && jsString_js_1.tzDataType.isString(pobjXzGradeBaseEN.gradeBaseID) === false) {
            throw new Error("(errid:Watl000063)字段[年级代号(gradeBaseID)]的值:[$(pobjXzGradeBaseEN.gradeBaseID)], 非法，应该为字符型(In 年级(XzGradeBase))!(clsXzGradeBaseBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzGradeBaseEN.gradeBaseName) == false && undefined !== pobjXzGradeBaseEN.gradeBaseName && jsString_js_1.tzDataType.isString(pobjXzGradeBaseEN.gradeBaseName) === false) {
            throw new Error("(errid:Watl000063)字段[年级名称(gradeBaseName)]的值:[$(pobjXzGradeBaseEN.gradeBaseName)], 非法，应该为字符型(In 年级(XzGradeBase))!(clsXzGradeBaseBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzGradeBaseEN.gradeBaseNameA) == false && undefined !== pobjXzGradeBaseEN.gradeBaseNameA && jsString_js_1.tzDataType.isString(pobjXzGradeBaseEN.gradeBaseNameA) === false) {
            throw new Error("(errid:Watl000063)字段[年级名称缩写(gradeBaseNameA)]的值:[$(pobjXzGradeBaseEN.gradeBaseNameA)], 非法，应该为字符型(In 年级(XzGradeBase))!(clsXzGradeBaseBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzGradeBaseEN.schoolYear) == false && undefined !== pobjXzGradeBaseEN.schoolYear && jsString_js_1.tzDataType.isString(pobjXzGradeBaseEN.schoolYear) === false) {
            throw new Error("(errid:Watl000063)字段[学年(schoolYear)]的值:[$(pobjXzGradeBaseEN.schoolYear)], 非法，应该为字符型(In 年级(XzGradeBase))!(clsXzGradeBaseBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzGradeBaseEN.schoolTerm) == false && undefined !== pobjXzGradeBaseEN.schoolTerm && jsString_js_1.tzDataType.isString(pobjXzGradeBaseEN.schoolTerm) === false) {
            throw new Error("(errid:Watl000063)字段[学期(schoolTerm)]的值:[$(pobjXzGradeBaseEN.schoolTerm)], 非法，应该为字符型(In 年级(XzGradeBase))!(clsXzGradeBaseBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzGradeBaseEN.enterSchoolDate) == false && undefined !== pobjXzGradeBaseEN.enterSchoolDate && jsString_js_1.tzDataType.isString(pobjXzGradeBaseEN.enterSchoolDate) === false) {
            throw new Error("(errid:Watl000063)字段[进校日期(enterSchoolDate)]的值:[$(pobjXzGradeBaseEN.enterSchoolDate)], 非法，应该为字符型(In 年级(XzGradeBase))!(clsXzGradeBaseBL:CheckProperty4Update)");
        }
        if (null != pobjXzGradeBaseEN.currentTermSeq && undefined !== pobjXzGradeBaseEN.currentTermSeq && jsString_js_1.tzDataType.isNumber(pobjXzGradeBaseEN.currentTermSeq) === false) {
            throw new Error("(errid:Watl000063)字段[当前学期(currentTermSeq)]的值:[$(pobjXzGradeBaseEN.currentTermSeq)], 非法，应该为数值型(In 年级(XzGradeBase))!(clsXzGradeBaseBL:CheckProperty4Update)");
        }
        if (null != pobjXzGradeBaseEN.execPlanTermIndex && undefined !== pobjXzGradeBaseEN.execPlanTermIndex && jsString_js_1.tzDataType.isNumber(pobjXzGradeBaseEN.execPlanTermIndex) === false) {
            throw new Error("(errid:Watl000063)字段[生成执行计划学期(execPlanTermIndex)]的值:[$(pobjXzGradeBaseEN.execPlanTermIndex)], 非法，应该为数值型(In 年级(XzGradeBase))!(clsXzGradeBaseBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzGradeBaseEN.setEPTermIndexDate) == false && undefined !== pobjXzGradeBaseEN.setEPTermIndexDate && jsString_js_1.tzDataType.isString(pobjXzGradeBaseEN.setEPTermIndexDate) === false) {
            throw new Error("(errid:Watl000063)字段[设定执行计划学期日期(setEPTermIndexDate)]的值:[$(pobjXzGradeBaseEN.setEPTermIndexDate)], 非法，应该为字符型(In 年级(XzGradeBase))!(clsXzGradeBaseBL:CheckProperty4Update)");
        }
        if (null != pobjXzGradeBaseEN.isOffed && undefined !== pobjXzGradeBaseEN.isOffed && jsString_js_1.tzDataType.isBoolean(pobjXzGradeBaseEN.isOffed) === false) {
            throw new Error("(errid:Watl000063)字段[是否毕业(isOffed)]的值:[$(pobjXzGradeBaseEN.isOffed)], 非法，应该为布尔型(In 年级(XzGradeBase))!(clsXzGradeBaseBL:CheckProperty4Update)");
        }
        if (null != pobjXzGradeBaseEN.gradeIndex && undefined !== pobjXzGradeBaseEN.gradeIndex && jsString_js_1.tzDataType.isNumber(pobjXzGradeBaseEN.gradeIndex) === false) {
            throw new Error("(errid:Watl000063)字段[年级序号(gradeIndex)]的值:[$(pobjXzGradeBaseEN.gradeIndex)], 非法，应该为数值型(In 年级(XzGradeBase))!(clsXzGradeBaseBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzGradeBaseEN.beginYearMonth) == false && undefined !== pobjXzGradeBaseEN.beginYearMonth && jsString_js_1.tzDataType.isString(pobjXzGradeBaseEN.beginYearMonth) === false) {
            throw new Error("(errid:Watl000063)字段[开始年月(beginYearMonth)]的值:[$(pobjXzGradeBaseEN.beginYearMonth)], 非法，应该为字符型(In 年级(XzGradeBase))!(clsXzGradeBaseBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzGradeBaseEN.endYearMonth) == false && undefined !== pobjXzGradeBaseEN.endYearMonth && jsString_js_1.tzDataType.isString(pobjXzGradeBaseEN.endYearMonth) === false) {
            throw new Error("(errid:Watl000063)字段[结束年月(endYearMonth)]的值:[$(pobjXzGradeBaseEN.endYearMonth)], 非法，应该为字符型(In 年级(XzGradeBase))!(clsXzGradeBaseBL:CheckProperty4Update)");
        }
        if (null != pobjXzGradeBaseEN.allowUpBaseInfo && undefined !== pobjXzGradeBaseEN.allowUpBaseInfo && jsString_js_1.tzDataType.isBoolean(pobjXzGradeBaseEN.allowUpBaseInfo) === false) {
            throw new Error("(errid:Watl000063)字段[允许修改基本信息(allowUpBaseInfo)]的值:[$(pobjXzGradeBaseEN.allowUpBaseInfo)], 非法，应该为布尔型(In 年级(XzGradeBase))!(clsXzGradeBaseBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzGradeBaseEN.prefix) == false && undefined !== pobjXzGradeBaseEN.prefix && jsString_js_1.tzDataType.isString(pobjXzGradeBaseEN.prefix) === false) {
            throw new Error("(errid:Watl000063)字段[前缀(prefix)]的值:[$(pobjXzGradeBaseEN.prefix)], 非法，应该为字符型(In 年级(XzGradeBase))!(clsXzGradeBaseBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzGradeBaseEN.pointCalcVersionId) == false && undefined !== pobjXzGradeBaseEN.pointCalcVersionId && jsString_js_1.tzDataType.isString(pobjXzGradeBaseEN.pointCalcVersionId) === false) {
            throw new Error("(errid:Watl000063)字段[绩点计算版本Id(pointCalcVersionId)]的值:[$(pobjXzGradeBaseEN.pointCalcVersionId)], 非法，应该为字符型(In 年级(XzGradeBase))!(clsXzGradeBaseBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzGradeBaseEN.modifyUserID) == false && undefined !== pobjXzGradeBaseEN.modifyUserID && jsString_js_1.tzDataType.isString(pobjXzGradeBaseEN.modifyUserID) === false) {
            throw new Error("(errid:Watl000063)字段[修改人(modifyUserID)]的值:[$(pobjXzGradeBaseEN.modifyUserID)], 非法，应该为字符型(In 年级(XzGradeBase))!(clsXzGradeBaseBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzGradeBaseEN.modifyDate) == false && undefined !== pobjXzGradeBaseEN.modifyDate && jsString_js_1.tzDataType.isString(pobjXzGradeBaseEN.modifyDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(modifyDate)]的值:[$(pobjXzGradeBaseEN.modifyDate)], 非法，应该为字符型(In 年级(XzGradeBase))!(clsXzGradeBaseBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzGradeBaseEN.id_StudyLevel) == false && undefined !== pobjXzGradeBaseEN.id_StudyLevel && jsString_js_1.tzDataType.isString(pobjXzGradeBaseEN.id_StudyLevel) === false) {
            throw new Error("(errid:Watl000063)字段[id_StudyLevel(id_StudyLevel)]的值:[$(pobjXzGradeBaseEN.id_StudyLevel)], 非法，应该为字符型(In 年级(XzGradeBase))!(clsXzGradeBaseBL:CheckProperty4Update)");
        }
        if (null != pobjXzGradeBaseEN.isVisible && undefined !== pobjXzGradeBaseEN.isVisible && jsString_js_1.tzDataType.isBoolean(pobjXzGradeBaseEN.isVisible) === false) {
            throw new Error("(errid:Watl000063)字段[是否显示(isVisible)]的值:[$(pobjXzGradeBaseEN.isVisible)], 非法，应该为布尔型(In 年级(XzGradeBase))!(clsXzGradeBaseBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzGradeBaseEN.memo) == false && undefined !== pobjXzGradeBaseEN.memo && jsString_js_1.tzDataType.isString(pobjXzGradeBaseEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjXzGradeBaseEN.memo)], 非法，应该为字符型(In 年级(XzGradeBase))!(clsXzGradeBaseBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjXzGradeBaseEN.id_GradeBase) === true
            || pobjXzGradeBaseEN.id_GradeBase.toString() === "0") {
            throw new Error("(errid:Watl000064)字段[年级流水号]不能为空(In 年级)!(clsXzGradeBaseBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjXzGradeBaseEN.SetIsCheckProperty(true);
    }
    exports.XzGradeBase_CheckProperty4Update = XzGradeBase_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function XzGradeBase_GetJSONStrByObj(pobjXzGradeBaseEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjXzGradeBaseEN.sf_UpdFldSetStr = pobjXzGradeBaseEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjXzGradeBaseEN);
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
    exports.XzGradeBase_GetJSONStrByObj = XzGradeBase_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function XzGradeBase_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrXzGradeBaseObjLst = new Array();
        if (strJSON === "") {
            return arrXzGradeBaseObjLst;
        }
        try {
            arrXzGradeBaseObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrXzGradeBaseObjLst;
        }
        return arrXzGradeBaseObjLst;
    }
    exports.XzGradeBase_GetObjLstByJSONStr = XzGradeBase_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrXzGradeBaseObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function XzGradeBase_GetObjLstByJSONObjLst(arrXzGradeBaseObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrXzGradeBaseObjLst = new Array();
        for (const objInFor of arrXzGradeBaseObjLstS) {
            const obj1 = XzGradeBase_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrXzGradeBaseObjLst.push(obj1);
        }
        return arrXzGradeBaseObjLst;
    }
    exports.XzGradeBase_GetObjLstByJSONObjLst = XzGradeBase_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function XzGradeBase_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjXzGradeBaseEN = new clsXzGradeBaseEN_js_1.clsXzGradeBaseEN();
        if (strJSON === "") {
            return pobjXzGradeBaseEN;
        }
        try {
            pobjXzGradeBaseEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjXzGradeBaseEN;
        }
        return pobjXzGradeBaseEN;
    }
    exports.XzGradeBase_GetObjByJSONStr = XzGradeBase_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function XzGradeBase_GetCombineCondition(objXzGradeBase_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objXzGradeBase_Cond.dicFldComparisonOp, clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_id_GradeBase) == true) {
            const strComparisonOp_id_GradeBase = objXzGradeBase_Cond.dicFldComparisonOp[clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_id_GradeBase];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_id_GradeBase, objXzGradeBase_Cond.id_GradeBase, strComparisonOp_id_GradeBase);
        }
        if (Object.prototype.hasOwnProperty.call(objXzGradeBase_Cond.dicFldComparisonOp, clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_GradeBaseID) == true) {
            const strComparisonOp_GradeBaseID = objXzGradeBase_Cond.dicFldComparisonOp[clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_GradeBaseID];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_GradeBaseID, objXzGradeBase_Cond.gradeBaseID, strComparisonOp_GradeBaseID);
        }
        if (Object.prototype.hasOwnProperty.call(objXzGradeBase_Cond.dicFldComparisonOp, clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_GradeBaseName) == true) {
            const strComparisonOp_GradeBaseName = objXzGradeBase_Cond.dicFldComparisonOp[clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_GradeBaseName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_GradeBaseName, objXzGradeBase_Cond.gradeBaseName, strComparisonOp_GradeBaseName);
        }
        if (Object.prototype.hasOwnProperty.call(objXzGradeBase_Cond.dicFldComparisonOp, clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_GradeBaseNameA) == true) {
            const strComparisonOp_GradeBaseNameA = objXzGradeBase_Cond.dicFldComparisonOp[clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_GradeBaseNameA];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_GradeBaseNameA, objXzGradeBase_Cond.gradeBaseNameA, strComparisonOp_GradeBaseNameA);
        }
        if (Object.prototype.hasOwnProperty.call(objXzGradeBase_Cond.dicFldComparisonOp, clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_SchoolYear) == true) {
            const strComparisonOp_SchoolYear = objXzGradeBase_Cond.dicFldComparisonOp[clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_SchoolYear];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_SchoolYear, objXzGradeBase_Cond.schoolYear, strComparisonOp_SchoolYear);
        }
        if (Object.prototype.hasOwnProperty.call(objXzGradeBase_Cond.dicFldComparisonOp, clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_SchoolTerm) == true) {
            const strComparisonOp_SchoolTerm = objXzGradeBase_Cond.dicFldComparisonOp[clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_SchoolTerm];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_SchoolTerm, objXzGradeBase_Cond.schoolTerm, strComparisonOp_SchoolTerm);
        }
        if (Object.prototype.hasOwnProperty.call(objXzGradeBase_Cond.dicFldComparisonOp, clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_EnterSchoolDate) == true) {
            const strComparisonOp_EnterSchoolDate = objXzGradeBase_Cond.dicFldComparisonOp[clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_EnterSchoolDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_EnterSchoolDate, objXzGradeBase_Cond.enterSchoolDate, strComparisonOp_EnterSchoolDate);
        }
        if (Object.prototype.hasOwnProperty.call(objXzGradeBase_Cond.dicFldComparisonOp, clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_CurrentTermSeq) == true) {
            const strComparisonOp_CurrentTermSeq = objXzGradeBase_Cond.dicFldComparisonOp[clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_CurrentTermSeq];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_CurrentTermSeq, objXzGradeBase_Cond.currentTermSeq, strComparisonOp_CurrentTermSeq);
        }
        //数据类型number(smallint)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
        if (Object.prototype.hasOwnProperty.call(objXzGradeBase_Cond.dicFldComparisonOp, clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_SetEPTermIndexDate) == true) {
            const strComparisonOp_SetEPTermIndexDate = objXzGradeBase_Cond.dicFldComparisonOp[clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_SetEPTermIndexDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_SetEPTermIndexDate, objXzGradeBase_Cond.setEPTermIndexDate, strComparisonOp_SetEPTermIndexDate);
        }
        if (Object.prototype.hasOwnProperty.call(objXzGradeBase_Cond.dicFldComparisonOp, clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_IsOffed) == true) {
            if (objXzGradeBase_Cond.isOffed == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_IsOffed);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_IsOffed);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objXzGradeBase_Cond.dicFldComparisonOp, clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_GradeIndex) == true) {
            const strComparisonOp_GradeIndex = objXzGradeBase_Cond.dicFldComparisonOp[clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_GradeIndex];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_GradeIndex, objXzGradeBase_Cond.gradeIndex, strComparisonOp_GradeIndex);
        }
        if (Object.prototype.hasOwnProperty.call(objXzGradeBase_Cond.dicFldComparisonOp, clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_BeginYearMonth) == true) {
            const strComparisonOp_BeginYearMonth = objXzGradeBase_Cond.dicFldComparisonOp[clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_BeginYearMonth];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_BeginYearMonth, objXzGradeBase_Cond.beginYearMonth, strComparisonOp_BeginYearMonth);
        }
        if (Object.prototype.hasOwnProperty.call(objXzGradeBase_Cond.dicFldComparisonOp, clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_EndYearMonth) == true) {
            const strComparisonOp_EndYearMonth = objXzGradeBase_Cond.dicFldComparisonOp[clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_EndYearMonth];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_EndYearMonth, objXzGradeBase_Cond.endYearMonth, strComparisonOp_EndYearMonth);
        }
        if (Object.prototype.hasOwnProperty.call(objXzGradeBase_Cond.dicFldComparisonOp, clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_AllowUpBaseInfo) == true) {
            if (objXzGradeBase_Cond.allowUpBaseInfo == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_AllowUpBaseInfo);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_AllowUpBaseInfo);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objXzGradeBase_Cond.dicFldComparisonOp, clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_Prefix) == true) {
            const strComparisonOp_Prefix = objXzGradeBase_Cond.dicFldComparisonOp[clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_Prefix];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_Prefix, objXzGradeBase_Cond.prefix, strComparisonOp_Prefix);
        }
        if (Object.prototype.hasOwnProperty.call(objXzGradeBase_Cond.dicFldComparisonOp, clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_PointCalcVersionId) == true) {
            const strComparisonOp_PointCalcVersionId = objXzGradeBase_Cond.dicFldComparisonOp[clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_PointCalcVersionId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_PointCalcVersionId, objXzGradeBase_Cond.pointCalcVersionId, strComparisonOp_PointCalcVersionId);
        }
        if (Object.prototype.hasOwnProperty.call(objXzGradeBase_Cond.dicFldComparisonOp, clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_ModifyUserID) == true) {
            const strComparisonOp_ModifyUserID = objXzGradeBase_Cond.dicFldComparisonOp[clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_ModifyUserID];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_ModifyUserID, objXzGradeBase_Cond.modifyUserID, strComparisonOp_ModifyUserID);
        }
        if (Object.prototype.hasOwnProperty.call(objXzGradeBase_Cond.dicFldComparisonOp, clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_ModifyDate) == true) {
            const strComparisonOp_ModifyDate = objXzGradeBase_Cond.dicFldComparisonOp[clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_ModifyDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_ModifyDate, objXzGradeBase_Cond.modifyDate, strComparisonOp_ModifyDate);
        }
        if (Object.prototype.hasOwnProperty.call(objXzGradeBase_Cond.dicFldComparisonOp, clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_id_StudyLevel) == true) {
            const strComparisonOp_id_StudyLevel = objXzGradeBase_Cond.dicFldComparisonOp[clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_id_StudyLevel];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_id_StudyLevel, objXzGradeBase_Cond.id_StudyLevel, strComparisonOp_id_StudyLevel);
        }
        if (Object.prototype.hasOwnProperty.call(objXzGradeBase_Cond.dicFldComparisonOp, clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_IsVisible) == true) {
            if (objXzGradeBase_Cond.isVisible == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_IsVisible);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_IsVisible);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objXzGradeBase_Cond.dicFldComparisonOp, clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_Memo) == true) {
            const strComparisonOp_Memo = objXzGradeBase_Cond.dicFldComparisonOp[clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_Memo, objXzGradeBase_Cond.memo, strComparisonOp_Memo);
        }
        return strWhereCond;
    }
    exports.XzGradeBase_GetCombineCondition = XzGradeBase_GetCombineCondition;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objXzGradeBaseENS:源对象
     * @param objXzGradeBaseENT:目标对象
    */
    function XzGradeBase_CopyObjTo(objXzGradeBaseENS, objXzGradeBaseENT) {
        objXzGradeBaseENT.id_GradeBase = objXzGradeBaseENS.id_GradeBase; //年级流水号
        objXzGradeBaseENT.gradeBaseID = objXzGradeBaseENS.gradeBaseID; //年级代号
        objXzGradeBaseENT.gradeBaseName = objXzGradeBaseENS.gradeBaseName; //年级名称
        objXzGradeBaseENT.gradeBaseNameA = objXzGradeBaseENS.gradeBaseNameA; //年级名称缩写
        objXzGradeBaseENT.schoolYear = objXzGradeBaseENS.schoolYear; //学年
        objXzGradeBaseENT.schoolTerm = objXzGradeBaseENS.schoolTerm; //学期
        objXzGradeBaseENT.enterSchoolDate = objXzGradeBaseENS.enterSchoolDate; //进校日期
        objXzGradeBaseENT.currentTermSeq = objXzGradeBaseENS.currentTermSeq; //当前学期
        objXzGradeBaseENT.execPlanTermIndex = objXzGradeBaseENS.execPlanTermIndex; //生成执行计划学期
        objXzGradeBaseENT.setEPTermIndexDate = objXzGradeBaseENS.setEPTermIndexDate; //设定执行计划学期日期
        objXzGradeBaseENT.isOffed = objXzGradeBaseENS.isOffed; //是否毕业
        objXzGradeBaseENT.gradeIndex = objXzGradeBaseENS.gradeIndex; //年级序号
        objXzGradeBaseENT.beginYearMonth = objXzGradeBaseENS.beginYearMonth; //开始年月
        objXzGradeBaseENT.endYearMonth = objXzGradeBaseENS.endYearMonth; //结束年月
        objXzGradeBaseENT.allowUpBaseInfo = objXzGradeBaseENS.allowUpBaseInfo; //允许修改基本信息
        objXzGradeBaseENT.prefix = objXzGradeBaseENS.prefix; //前缀
        objXzGradeBaseENT.pointCalcVersionId = objXzGradeBaseENS.pointCalcVersionId; //绩点计算版本Id
        objXzGradeBaseENT.modifyUserID = objXzGradeBaseENS.modifyUserID; //修改人
        objXzGradeBaseENT.modifyDate = objXzGradeBaseENS.modifyDate; //修改日期
        objXzGradeBaseENT.id_StudyLevel = objXzGradeBaseENS.id_StudyLevel; //id_StudyLevel
        objXzGradeBaseENT.isVisible = objXzGradeBaseENS.isVisible; //是否显示
        objXzGradeBaseENT.memo = objXzGradeBaseENS.memo; //备注
        objXzGradeBaseENT.sf_UpdFldSetStr = objXzGradeBaseENS.updFldString; //sf_UpdFldSetStr
    }
    exports.XzGradeBase_CopyObjTo = XzGradeBase_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objXzGradeBaseENS:源对象
     * @param objXzGradeBaseENT:目标对象
    */
    function XzGradeBase_GetObjFromJsonObj(objXzGradeBaseENS) {
        const objXzGradeBaseENT = new clsXzGradeBaseEN_js_1.clsXzGradeBaseEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objXzGradeBaseENT, objXzGradeBaseENS);
        return objXzGradeBaseENT;
    }
    exports.XzGradeBase_GetObjFromJsonObj = XzGradeBase_GetObjFromJsonObj;
});
