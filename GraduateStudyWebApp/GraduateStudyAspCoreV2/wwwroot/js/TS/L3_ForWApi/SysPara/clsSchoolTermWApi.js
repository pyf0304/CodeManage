/**
* 类名:clsSchoolTermWApi
* 表名:SchoolTerm(01120135)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/13 00:52:18
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
        define(["require", "exports", "axios", "../../PubFun/enumComparisonOp.js", "../../PubFun/CacheHelper.js", "../../L0_Entity/SysPara/clsSchoolTermEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.SchoolTerm_GetObjFromJsonObj = exports.SchoolTerm_CopyObjTo = exports.SchoolTerm_GetCombineCondition = exports.SchoolTerm_GetObjByJSONStr = exports.SchoolTerm_GetObjLstByJSONObjLst = exports.SchoolTerm_GetObjLstByJSONStr = exports.SchoolTerm_GetJSONStrByObj = exports.SchoolTerm_CheckProperty4Update = exports.SchoolTerm_CheckPropertyNew = exports.SchoolTerm_BindDdl_SchoolTermInDiv_Cache = exports.SchoolTerm_ReFreshThisCache = exports.SchoolTerm_ReFreshCache = exports.SchoolTerm_GetWebApiUrl = exports.SchoolTerm_GetMaxStrIdByPrefix = exports.SchoolTerm_GetRecCountByCond_Cache = exports.SchoolTerm_GetRecCountByCondAsync = exports.SchoolTerm_IsExistAsync = exports.SchoolTerm_IsExist_Cache = exports.SchoolTerm_IsExist = exports.SchoolTerm_IsExistRecordAsync = exports.SchoolTerm_IsExistRecord_Cache = exports.SchoolTerm_UpdateWithConditionAsync = exports.SchoolTerm_UpdateRecordAsync = exports.SchoolTerm_AddNewRecordWithReturnKey = exports.SchoolTerm_AddNewRecordWithReturnKeyAsync = exports.SchoolTerm_AddNewRecordWithMaxIdAsync = exports.SchoolTerm_AddNewRecordAsync = exports.SchoolTerm_DelSchoolTermsByCondAsync = exports.SchoolTerm_DelSchoolTermsAsync = exports.SchoolTerm_DelRecordAsync = exports.SchoolTerm_GetObjLstByPagerAsync = exports.SchoolTerm_GetObjLstByPager_Cache = exports.SchoolTerm_GetObjLstByRange = exports.SchoolTerm_GetObjLstByRangeAsync = exports.SchoolTerm_GetTopObjLstAsync = exports.SchoolTerm_GetObjLstBySchoolTermLst_Cache = exports.SchoolTerm_GetObjLstBySchoolTermLstAsync = exports.SchoolTerm_GetSubObjLst_Cache = exports.SchoolTerm_GetObjLst_PureCache = exports.SchoolTerm_GetObjLst_Cache = exports.SchoolTerm_GetObjLst_sessionStorage_PureCache = exports.SchoolTerm_GetObjLst_sessionStorage = exports.SchoolTerm_GetObjLstAsync = exports.SchoolTerm_GetObjLst_localStorage_PureCache = exports.SchoolTerm_GetObjLst_localStorage = exports.SchoolTerm_GetObjLst_ClientCache = exports.SchoolTerm_GetFirstObjAsync = exports.SchoolTerm_GetFirstID = exports.SchoolTerm_GetFirstIDAsync = exports.SchoolTerm_funcKey = exports.SchoolTerm_FilterFunByKey = exports.SchoolTerm_SortFunByKey = exports.SchoolTerm_SortFun_Defa = exports.SchoolTerm_func = exports.SchoolTerm_GetNameBySchoolTerm_Cache = exports.SchoolTerm_UpdateObjInLst_Cache = exports.SchoolTerm_GetObjBySchoolTerm_localStorage = exports.SchoolTerm_GetObjBySchoolTerm_Cache = exports.SchoolTerm_GetObjBySchoolTermAsync = exports.schoolTerm_ConstructorName = exports.schoolTerm_Controller = void 0;
    /**
     * 学期(SchoolTerm)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月13日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const enumComparisonOp_js_1 = require("../../PubFun/enumComparisonOp.js");
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsSchoolTermEN_js_1 = require("../../L0_Entity/SysPara/clsSchoolTermEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsString_js_2 = require("../../PubFun/clsString.js");
    exports.schoolTerm_Controller = "SchoolTermApi";
    exports.schoolTerm_ConstructorName = "schoolTerm";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strSchoolTerm:关键字
    * @returns 对象
    **/
    async function SchoolTerm_GetObjBySchoolTermAsync(strSchoolTerm) {
        const strThisFuncName = "GetObjBySchoolTermAsync";
        if ((0, clsString_js_2.IsNullOrEmpty)(strSchoolTerm) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strSchoolTerm]不能为空！(In clsSchoolTermWApi.GetObjBySchoolTermAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strSchoolTerm.length != 1) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strSchoolTerm]的长度:[{0}]不正确！(clsSchoolTermWApi.GetObjBySchoolTermAsync)", strSchoolTerm.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjBySchoolTerm";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.schoolTerm_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "strSchoolTerm": strSchoolTerm,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    return null;
                }
                //console.log(returnObj);
                const objSchoolTerm = SchoolTerm_GetObjFromJsonObj(returnObj);
                return objSchoolTerm;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.schoolTerm_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.schoolTerm_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SchoolTerm_GetObjBySchoolTermAsync = SchoolTerm_GetObjBySchoolTermAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param strSchoolTerm:所给的关键字
     * @returns 对象
    */
    async function SchoolTerm_GetObjBySchoolTerm_Cache(strSchoolTerm, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjBySchoolTerm_Cache";
        if ((0, clsString_js_2.IsNullOrEmpty)(strSchoolTerm) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strSchoolTerm]不能为空！(In clsSchoolTermWApi.GetObjBySchoolTerm_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strSchoolTerm.length != 1) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strSchoolTerm]的长度:[{0}]不正确！(clsSchoolTermWApi.GetObjBySchoolTerm_Cache)", strSchoolTerm.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrSchoolTermObjLst_Cache = await SchoolTerm_GetObjLst_Cache();
        try {
            const arrSchoolTerm_Sel = arrSchoolTermObjLst_Cache.filter(x => x.schoolTerm == strSchoolTerm);
            let objSchoolTerm;
            if (arrSchoolTerm_Sel.length > 0) {
                objSchoolTerm = arrSchoolTerm_Sel[0];
                return objSchoolTerm;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    const objSchoolTerm_Const = await SchoolTerm_GetObjBySchoolTermAsync(strSchoolTerm);
                    if (objSchoolTerm_Const != null) {
                        SchoolTerm_ReFreshThisCache();
                        return objSchoolTerm_Const;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strSchoolTerm, exports.schoolTerm_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.SchoolTerm_GetObjBySchoolTerm_Cache = SchoolTerm_GetObjBySchoolTerm_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param strSchoolTerm:所给的关键字
     * @returns 对象
    */
    async function SchoolTerm_GetObjBySchoolTerm_localStorage(strSchoolTerm) {
        const strThisFuncName = "GetObjBySchoolTerm_localStorage";
        if ((0, clsString_js_2.IsNullOrEmpty)(strSchoolTerm) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strSchoolTerm]不能为空！(In clsSchoolTermWApi.GetObjBySchoolTerm_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strSchoolTerm.length != 1) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strSchoolTerm]的长度:[{0}]不正确！(clsSchoolTermWApi.GetObjBySchoolTerm_localStorage)", strSchoolTerm.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsSchoolTermEN_js_1.clsSchoolTermEN._CurrTabName, strSchoolTerm);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objSchoolTerm_Cache = JSON.parse(strTempObj);
            return objSchoolTerm_Cache;
        }
        try {
            const objSchoolTerm = await SchoolTerm_GetObjBySchoolTermAsync(strSchoolTerm);
            if (objSchoolTerm != null) {
                localStorage.setItem(strKey, JSON.stringify(objSchoolTerm));
                const strInfo = (0, clsString_js_2.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objSchoolTerm;
            }
            return objSchoolTerm;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strSchoolTerm, exports.schoolTerm_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.SchoolTerm_GetObjBySchoolTerm_localStorage = SchoolTerm_GetObjBySchoolTerm_localStorage;
    /**
     * 修改在缓存对象列表中的对象, 与后台数据库无关.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
     * @param objSchoolTerm:所给的对象
     * @returns 对象
    */
    async function SchoolTerm_UpdateObjInLst_Cache(objSchoolTerm) {
        const strThisFuncName = "UpdateObjInLst_Cache";
        try {
            const arrSchoolTermObjLst_Cache = await SchoolTerm_GetObjLst_Cache();
            const obj = arrSchoolTermObjLst_Cache.find(x => x.schoolTerm == objSchoolTerm.schoolTerm);
            if (obj != null) {
                objSchoolTerm.schoolTerm = obj.schoolTerm;
                (0, clsCommFunc4Web_js_1.ObjectAssign)(obj, objSchoolTerm);
            }
            else {
                arrSchoolTermObjLst_Cache.push(objSchoolTerm);
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, exports.schoolTerm_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.SchoolTerm_UpdateObjInLst_Cache = SchoolTerm_UpdateObjInLst_Cache;
    /**
     * 根据关键字获取相关对象的名称属性, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetNameByKeyId_Cache)
     * @param strSchoolTerm:所给的关键字
     * @returns 对象
    */
    async function SchoolTerm_GetNameBySchoolTerm_Cache(strSchoolTerm) {
        const strThisFuncName = "GetNameBySchoolTerm_Cache";
        if ((0, clsString_js_2.IsNullOrEmpty)(strSchoolTerm) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strSchoolTerm]不能为空！(In clsSchoolTermWApi.GetNameBySchoolTerm_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strSchoolTerm.length != 1) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strSchoolTerm]的长度:[{0}]不正确！(clsSchoolTermWApi.GetNameBySchoolTerm_Cache)", strSchoolTerm.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrSchoolTermObjLst_Cache = await SchoolTerm_GetObjLst_Cache();
        if (arrSchoolTermObjLst_Cache == null)
            return "";
        try {
            const arrSchoolTerm_Sel = arrSchoolTermObjLst_Cache.filter(x => x.schoolTerm == strSchoolTerm);
            let objSchoolTerm;
            if (arrSchoolTerm_Sel.length > 0) {
                objSchoolTerm = arrSchoolTerm_Sel[0];
                return objSchoolTerm.schoolTermName;
            }
            else {
                return "";
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象名称属性不成功!", e, strSchoolTerm);
            console.error(strMsg);
            alert(strMsg);
        }
        return "";
    }
    exports.SchoolTerm_GetNameBySchoolTerm_Cache = SchoolTerm_GetNameBySchoolTerm_Cache;
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
    async function SchoolTerm_func(strInFldName, strOutFldName, strInValue) {
        //const strThisFuncName = "func";
        if (strInFldName != clsSchoolTermEN_js_1.clsSchoolTermEN.con_SchoolTerm) {
            const strMsg = (0, clsString_js_2.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsSchoolTermEN_js_1.clsSchoolTermEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_2.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strOutFldName, clsSchoolTermEN_js_1.clsSchoolTermEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strSchoolTerm = strInValue;
        if ((0, clsString_js_2.IsNullOrEmpty)(strInValue) == true) {
            return "";
        }
        const objSchoolTerm = await SchoolTerm_GetObjBySchoolTerm_Cache(strSchoolTerm);
        if (objSchoolTerm == null)
            return "";
        if (objSchoolTerm.GetFldValue(strOutFldName) == null)
            return "";
        return objSchoolTerm.GetFldValue(strOutFldName).toString();
    }
    exports.SchoolTerm_func = SchoolTerm_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function SchoolTerm_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.schoolTerm.localeCompare(b.schoolTerm);
    }
    exports.SchoolTerm_SortFun_Defa = SchoolTerm_SortFun_Defa;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function SchoolTerm_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsSchoolTermEN_js_1.clsSchoolTermEN.con_SchoolTerm:
                    return (a, b) => {
                        return a.schoolTerm.localeCompare(b.schoolTerm);
                    };
                case clsSchoolTermEN_js_1.clsSchoolTermEN.con_SchoolTermName:
                    return (a, b) => {
                        if (a.schoolTermName == null)
                            return -1;
                        if (b.schoolTermName == null)
                            return 1;
                        return a.schoolTermName.localeCompare(b.schoolTermName);
                    };
                case clsSchoolTermEN_js_1.clsSchoolTermEN.con_IsCurrentSchoolTerm:
                    return (a, b) => {
                        if (a.isCurrentSchoolTerm == true)
                            return 1;
                        else
                            return -1;
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[SchoolTerm]中不存在！(in ${exports.schoolTerm_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsSchoolTermEN_js_1.clsSchoolTermEN.con_SchoolTerm:
                    return (a, b) => {
                        return b.schoolTerm.localeCompare(a.schoolTerm);
                    };
                case clsSchoolTermEN_js_1.clsSchoolTermEN.con_SchoolTermName:
                    return (a, b) => {
                        if (b.schoolTermName == null)
                            return -1;
                        if (a.schoolTermName == null)
                            return 1;
                        return b.schoolTermName.localeCompare(a.schoolTermName);
                    };
                case clsSchoolTermEN_js_1.clsSchoolTermEN.con_IsCurrentSchoolTerm:
                    return (a, b) => {
                        if (b.isCurrentSchoolTerm == true)
                            return 1;
                        else
                            return -1;
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[SchoolTerm]中不存在！(in ${exports.schoolTerm_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.SchoolTerm_SortFunByKey = SchoolTerm_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function SchoolTerm_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsSchoolTermEN_js_1.clsSchoolTermEN.con_SchoolTerm:
                return (obj) => {
                    return obj.schoolTerm === value;
                };
            case clsSchoolTermEN_js_1.clsSchoolTermEN.con_SchoolTermName:
                return (obj) => {
                    return obj.schoolTermName === value;
                };
            case clsSchoolTermEN_js_1.clsSchoolTermEN.con_IsCurrentSchoolTerm:
                return (obj) => {
                    return obj.isCurrentSchoolTerm === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[SchoolTerm]中不存在！(in ${exports.schoolTerm_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.SchoolTerm_FilterFunByKey = SchoolTerm_FilterFunByKey;
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
    async function SchoolTerm_funcKey(strInFldName, strInValue, strComparisonOp) {
        //const strThisFuncName = "funcKey";
        if (strInFldName == clsSchoolTermEN_js_1.clsSchoolTermEN.con_SchoolTerm) {
            const strMsg = (0, clsString_js_2.Format)("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(strInValue) == true) {
            return [];
        }
        const arrSchoolTerm = await SchoolTerm_GetObjLst_Cache();
        if (arrSchoolTerm == null)
            return [];
        let arrSchoolTerm_Sel = arrSchoolTerm;
        const strType = typeof (strInValue);
        switch (strType) {
            case "string":
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01: // " = "
                        arrSchoolTerm_Sel = arrSchoolTerm_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.Like_03:
                        arrSchoolTerm_Sel = arrSchoolTerm_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.In_04:
                        const arrValues = strInValue.split(',');
                        arrSchoolTerm_Sel = arrSchoolTerm_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
                        break;
                }
                break;
            case "boolean":
                if (strInValue == null)
                    return [];
                if (strComparisonOp == enumComparisonOp_js_1.enumComparisonOp.Equal_01) {
                    arrSchoolTerm_Sel = arrSchoolTerm_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                }
                break;
            case "number":
                if (Number(strInValue) == 0)
                    return [];
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01:
                        arrSchoolTerm_Sel = arrSchoolTerm_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotEqual_02:
                        arrSchoolTerm_Sel = arrSchoolTerm_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotLessThan_05: //" >= ":
                        arrSchoolTerm_Sel = arrSchoolTerm_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotGreaterThan_06: //" <= ":
                        arrSchoolTerm_Sel = arrSchoolTerm_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.GreaterThan_07: //" > ":
                        arrSchoolTerm_Sel = arrSchoolTerm_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.LessThan_08: //" < ":
                        arrSchoolTerm_Sel = arrSchoolTerm_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                }
                break;
        }
        if (arrSchoolTerm_Sel.length == 0)
            return [];
        return arrSchoolTerm_Sel.map(x => x.schoolTerm);
    }
    exports.SchoolTerm_funcKey = SchoolTerm_funcKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function SchoolTerm_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.schoolTerm_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.schoolTerm_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.schoolTerm_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SchoolTerm_GetFirstIDAsync = SchoolTerm_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function SchoolTerm_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.schoolTerm_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.schoolTerm_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.schoolTerm_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SchoolTerm_GetFirstID = SchoolTerm_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function SchoolTerm_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.schoolTerm_Controller, strAction);
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
                const objSchoolTerm = SchoolTerm_GetObjFromJsonObj(returnObj);
                return objSchoolTerm;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.schoolTerm_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.schoolTerm_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SchoolTerm_GetFirstObjAsync = SchoolTerm_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function SchoolTerm_GetObjLst_ClientCache() {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsSchoolTermEN_js_1.clsSchoolTermEN._CurrTabName;
        if ((0, clsString_js_2.IsNullOrEmpty)(clsSchoolTermEN_js_1.clsSchoolTermEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsSchoolTermEN_js_1.clsSchoolTermEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_1.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrSchoolTermExObjLst_Cache = CacheHelper_js_1.CacheHelper.Get(strKey);
            const arrSchoolTermObjLst_T = SchoolTerm_GetObjLstByJSONObjLst(arrSchoolTermExObjLst_Cache);
            return arrSchoolTermObjLst_T;
        }
        try {
            const arrSchoolTermExObjLst = await SchoolTerm_GetObjLstAsync(strWhereCond);
            CacheHelper_js_1.CacheHelper.Add(strKey, arrSchoolTermExObjLst);
            const strInfo = (0, clsString_js_2.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrSchoolTermExObjLst.length);
            console.log(strInfo);
            return arrSchoolTermExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.schoolTerm_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.SchoolTerm_GetObjLst_ClientCache = SchoolTerm_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function SchoolTerm_GetObjLst_localStorage() {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsSchoolTermEN_js_1.clsSchoolTermEN._CurrTabName;
        if ((0, clsString_js_2.IsNullOrEmpty)(clsSchoolTermEN_js_1.clsSchoolTermEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsSchoolTermEN_js_1.clsSchoolTermEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrSchoolTermExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrSchoolTermObjLst_T = SchoolTerm_GetObjLstByJSONObjLst(arrSchoolTermExObjLst_Cache);
            return arrSchoolTermObjLst_T;
        }
        try {
            const arrSchoolTermExObjLst = await SchoolTerm_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrSchoolTermExObjLst));
            const strInfo = (0, clsString_js_2.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrSchoolTermExObjLst.length);
            console.log(strInfo);
            return arrSchoolTermExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.schoolTerm_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.SchoolTerm_GetObjLst_localStorage = SchoolTerm_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function SchoolTerm_GetObjLst_localStorage_PureCache() {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsSchoolTermEN_js_1.clsSchoolTermEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrSchoolTermObjLst_Cache = JSON.parse(strTempObjLst);
            return arrSchoolTermObjLst_Cache;
        }
        else
            return null;
    }
    exports.SchoolTerm_GetObjLst_localStorage_PureCache = SchoolTerm_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function SchoolTerm_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.schoolTerm_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.schoolTerm_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = SchoolTerm_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.schoolTerm_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.schoolTerm_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SchoolTerm_GetObjLstAsync = SchoolTerm_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function SchoolTerm_GetObjLst_sessionStorage() {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsSchoolTermEN_js_1.clsSchoolTermEN._CurrTabName;
        if ((0, clsString_js_2.IsNullOrEmpty)(clsSchoolTermEN_js_1.clsSchoolTermEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsSchoolTermEN_js_1.clsSchoolTermEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrSchoolTermExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrSchoolTermObjLst_T = SchoolTerm_GetObjLstByJSONObjLst(arrSchoolTermExObjLst_Cache);
            return arrSchoolTermObjLst_T;
        }
        try {
            const arrSchoolTermExObjLst = await SchoolTerm_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrSchoolTermExObjLst));
            const strInfo = (0, clsString_js_2.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrSchoolTermExObjLst.length);
            console.log(strInfo);
            return arrSchoolTermExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.schoolTerm_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.SchoolTerm_GetObjLst_sessionStorage = SchoolTerm_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function SchoolTerm_GetObjLst_sessionStorage_PureCache() {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsSchoolTermEN_js_1.clsSchoolTermEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrSchoolTermObjLst_Cache = JSON.parse(strTempObjLst);
            return arrSchoolTermObjLst_Cache;
        }
        else
            return null;
    }
    exports.SchoolTerm_GetObjLst_sessionStorage_PureCache = SchoolTerm_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function SchoolTerm_GetObjLst_Cache() {
        //const strThisFuncName = "GetObjLst_Cache";
        let arrSchoolTermObjLst_Cache;
        switch (clsSchoolTermEN_js_1.clsSchoolTermEN.CacheModeId) {
            case "04": //sessionStorage
                arrSchoolTermObjLst_Cache = await SchoolTerm_GetObjLst_sessionStorage();
                break;
            case "03": //localStorage
                arrSchoolTermObjLst_Cache = await SchoolTerm_GetObjLst_localStorage();
                break;
            case "02": //ClientCache
                arrSchoolTermObjLst_Cache = await SchoolTerm_GetObjLst_ClientCache();
                break;
            default:
                arrSchoolTermObjLst_Cache = await SchoolTerm_GetObjLst_ClientCache();
                break;
        }
        const arrSchoolTermObjLst = SchoolTerm_GetObjLstByJSONObjLst(arrSchoolTermObjLst_Cache);
        return arrSchoolTermObjLst_Cache;
    }
    exports.SchoolTerm_GetObjLst_Cache = SchoolTerm_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function SchoolTerm_GetObjLst_PureCache() {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrSchoolTermObjLst_Cache;
        switch (clsSchoolTermEN_js_1.clsSchoolTermEN.CacheModeId) {
            case "04": //sessionStorage
                arrSchoolTermObjLst_Cache = await SchoolTerm_GetObjLst_sessionStorage_PureCache();
                break;
            case "03": //localStorage
                arrSchoolTermObjLst_Cache = await SchoolTerm_GetObjLst_localStorage_PureCache();
                break;
            case "02": //ClientCache
                arrSchoolTermObjLst_Cache = null;
                break;
            default:
                arrSchoolTermObjLst_Cache = null;
                break;
        }
        return arrSchoolTermObjLst_Cache;
    }
    exports.SchoolTerm_GetObjLst_PureCache = SchoolTerm_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objstrSchoolTerm_Cond:条件对象
     * @returns 对象列表子集
    */
    async function SchoolTerm_GetSubObjLst_Cache(objSchoolTerm_Cond) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrSchoolTermObjLst_Cache = await SchoolTerm_GetObjLst_Cache();
        let arrSchoolTerm_Sel = arrSchoolTermObjLst_Cache;
        if (objSchoolTerm_Cond.sf_FldComparisonOp == null || objSchoolTerm_Cond.sf_FldComparisonOp == "")
            return arrSchoolTerm_Sel;
        const dicFldComparisonOp = JSON.parse(objSchoolTerm_Cond.sf_FldComparisonOp);
        //console.log("clsSchoolTermWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objSchoolTerm_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrSchoolTerm_Sel = arrSchoolTerm_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objSchoolTerm_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrSchoolTerm_Sel = arrSchoolTerm_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrSchoolTerm_Sel = arrSchoolTerm_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrSchoolTerm_Sel = arrSchoolTerm_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrSchoolTerm_Sel = arrSchoolTerm_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrSchoolTerm_Sel = arrSchoolTerm_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrSchoolTerm_Sel = arrSchoolTerm_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrSchoolTerm_Sel = arrSchoolTerm_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrSchoolTerm_Sel = arrSchoolTerm_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrSchoolTerm_Sel = arrSchoolTerm_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrSchoolTerm_Sel = arrSchoolTerm_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrSchoolTerm_Sel = arrSchoolTerm_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrSchoolTerm_Sel = arrSchoolTerm_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrSchoolTerm_Sel = arrSchoolTerm_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrSchoolTerm_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objSchoolTerm_Cond), exports.schoolTerm_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.SchoolTerm_GetSubObjLst_Cache = SchoolTerm_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrSchoolTerm:关键字列表
    * @returns 对象列表
    **/
    async function SchoolTerm_GetObjLstBySchoolTermLstAsync(arrSchoolTerm) {
        const strThisFuncName = "GetObjLstBySchoolTermLstAsync";
        const strAction = "GetObjLstBySchoolTermLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.schoolTerm_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrSchoolTerm);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.schoolTerm_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = SchoolTerm_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.schoolTerm_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.schoolTerm_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SchoolTerm_GetObjLstBySchoolTermLstAsync = SchoolTerm_GetObjLstBySchoolTermLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrstrSchoolTermLst:关键字列表
     * @returns 对象列表
    */
    async function SchoolTerm_GetObjLstBySchoolTermLst_Cache(arrSchoolTermLst) {
        const strThisFuncName = "GetObjLstBySchoolTermLst_Cache";
        try {
            const arrSchoolTermObjLst_Cache = await SchoolTerm_GetObjLst_Cache();
            const arrSchoolTerm_Sel = arrSchoolTermObjLst_Cache.filter(x => arrSchoolTermLst.indexOf(x.schoolTerm) > -1);
            return arrSchoolTerm_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrSchoolTermLst.join(","), exports.schoolTerm_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
    }
    exports.SchoolTerm_GetObjLstBySchoolTermLst_Cache = SchoolTerm_GetObjLstBySchoolTermLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function SchoolTerm_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.schoolTerm_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.schoolTerm_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = SchoolTerm_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.schoolTerm_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.schoolTerm_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SchoolTerm_GetTopObjLstAsync = SchoolTerm_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function SchoolTerm_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.schoolTerm_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.schoolTerm_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = SchoolTerm_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.schoolTerm_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.schoolTerm_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SchoolTerm_GetObjLstByRangeAsync = SchoolTerm_GetObjLstByRangeAsync;
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
    async function SchoolTerm_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.schoolTerm_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.schoolTerm_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.schoolTerm_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SchoolTerm_GetObjLstByRange = SchoolTerm_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function SchoolTerm_GetObjLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const arrSchoolTermObjLst_Cache = await SchoolTerm_GetObjLst_Cache();
        if (arrSchoolTermObjLst_Cache.length == 0)
            return arrSchoolTermObjLst_Cache;
        let arrSchoolTerm_Sel = arrSchoolTermObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objSchoolTerm_Cond = new clsSchoolTermEN_js_1.clsSchoolTermEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objSchoolTerm_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsSchoolTermWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrSchoolTerm_Sel = arrSchoolTerm_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objSchoolTerm_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrSchoolTerm_Sel = arrSchoolTerm_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrSchoolTerm_Sel = arrSchoolTerm_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrSchoolTerm_Sel = arrSchoolTerm_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrSchoolTerm_Sel = arrSchoolTerm_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrSchoolTerm_Sel = arrSchoolTerm_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrSchoolTerm_Sel = arrSchoolTerm_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrSchoolTerm_Sel = arrSchoolTerm_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrSchoolTerm_Sel = arrSchoolTerm_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrSchoolTerm_Sel = arrSchoolTerm_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrSchoolTerm_Sel = arrSchoolTerm_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrSchoolTerm_Sel = arrSchoolTerm_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrSchoolTerm_Sel = arrSchoolTerm_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrSchoolTerm_Sel = arrSchoolTerm_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrSchoolTerm_Sel = arrSchoolTerm_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrSchoolTerm_Sel.length == 0)
                return arrSchoolTerm_Sel;
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
                arrSchoolTerm_Sel = arrSchoolTerm_Sel.sort(SchoolTerm_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrSchoolTerm_Sel = arrSchoolTerm_Sel.sort(objPagerPara.sortFun);
            }
            arrSchoolTerm_Sel = arrSchoolTerm_Sel.slice(intStart, intEnd);
            return arrSchoolTerm_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.schoolTerm_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.SchoolTerm_GetObjLstByPager_Cache = SchoolTerm_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function SchoolTerm_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.schoolTerm_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.schoolTerm_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = SchoolTerm_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.schoolTerm_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.schoolTerm_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SchoolTerm_GetObjLstByPagerAsync = SchoolTerm_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param strSchoolTerm:关键字
    * @returns 获取删除的结果
    **/
    async function SchoolTerm_DelRecordAsync(strSchoolTerm) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.schoolTerm_Controller, strAction);
        strUrl = (0, clsString_js_2.Format)("{0}/?Id={1}", strUrl, strSchoolTerm);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.schoolTerm_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.schoolTerm_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SchoolTerm_DelRecordAsync = SchoolTerm_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrSchoolTerm:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function SchoolTerm_DelSchoolTermsAsync(arrSchoolTerm) {
        const strThisFuncName = "DelSchoolTermsAsync";
        const strAction = "DelSchoolTerms";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.schoolTerm_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrSchoolTerm);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.schoolTerm_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.schoolTerm_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SchoolTerm_DelSchoolTermsAsync = SchoolTerm_DelSchoolTermsAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function SchoolTerm_DelSchoolTermsByCondAsync(strWhereCond) {
        const strThisFuncName = "DelSchoolTermsByCondAsync";
        const strAction = "DelSchoolTermsByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.schoolTerm_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.schoolTerm_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.schoolTerm_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SchoolTerm_DelSchoolTermsByCondAsync = SchoolTerm_DelSchoolTermsByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objSchoolTermEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function SchoolTerm_AddNewRecordAsync(objSchoolTermEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        if (objSchoolTermEN.schoolTerm === null || objSchoolTermEN.schoolTerm === "") {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            throw strMsg;
        }
        //var strJSON = JSON.stringify(objSchoolTermEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.schoolTerm_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objSchoolTermEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.schoolTerm_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.schoolTerm_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SchoolTerm_AddNewRecordAsync = SchoolTerm_AddNewRecordAsync;
    /**
    * 调用WebApi来添加记录，关键字用最大关键字，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithMaxIdAsync)
    * @param objSchoolTermEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function SchoolTerm_AddNewRecordWithMaxIdAsync(objSchoolTermEN) {
        const strThisFuncName = "AddNewRecordWithMaxIdAsync";
        const strAction = "AddNewRecordWithMaxId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.schoolTerm_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objSchoolTermEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.schoolTerm_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.schoolTerm_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SchoolTerm_AddNewRecordWithMaxIdAsync = SchoolTerm_AddNewRecordWithMaxIdAsync;
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objSchoolTermEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function SchoolTerm_AddNewRecordWithReturnKeyAsync(objSchoolTermEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.schoolTerm_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objSchoolTermEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.schoolTerm_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.schoolTerm_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SchoolTerm_AddNewRecordWithReturnKeyAsync = SchoolTerm_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objSchoolTermEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function SchoolTerm_AddNewRecordWithReturnKey(objSchoolTermEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objSchoolTermEN.schoolTerm === null || objSchoolTermEN.schoolTerm === "") {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.schoolTerm_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objSchoolTermEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.schoolTerm_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.schoolTerm_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SchoolTerm_AddNewRecordWithReturnKey = SchoolTerm_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objSchoolTermEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function SchoolTerm_UpdateRecordAsync(objSchoolTermEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objSchoolTermEN.sf_UpdFldSetStr === undefined || objSchoolTermEN.sf_UpdFldSetStr === null || objSchoolTermEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objSchoolTermEN.schoolTerm);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.schoolTerm_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objSchoolTermEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.schoolTerm_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.schoolTerm_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SchoolTerm_UpdateRecordAsync = SchoolTerm_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objSchoolTermEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function SchoolTerm_UpdateWithConditionAsync(objSchoolTermEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objSchoolTermEN.sf_UpdFldSetStr === undefined || objSchoolTermEN.sf_UpdFldSetStr === null || objSchoolTermEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objSchoolTermEN.schoolTerm);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.schoolTerm_Controller, strAction);
        objSchoolTermEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objSchoolTermEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.schoolTerm_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.schoolTerm_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SchoolTerm_UpdateWithConditionAsync = SchoolTerm_UpdateWithConditionAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objstrSchoolTerm_Cond:条件对象
     * @returns 对象列表子集
    */
    async function SchoolTerm_IsExistRecord_Cache(objSchoolTerm_Cond) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrSchoolTermObjLst_Cache = await SchoolTerm_GetObjLst_Cache();
        if (arrSchoolTermObjLst_Cache == null)
            return false;
        let arrSchoolTerm_Sel = arrSchoolTermObjLst_Cache;
        if (objSchoolTerm_Cond.sf_FldComparisonOp == null || objSchoolTerm_Cond.sf_FldComparisonOp == "")
            return arrSchoolTerm_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objSchoolTerm_Cond.sf_FldComparisonOp);
        //console.log("clsSchoolTermWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objSchoolTerm_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objSchoolTerm_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrSchoolTerm_Sel = arrSchoolTerm_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrSchoolTerm_Sel = arrSchoolTerm_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrSchoolTerm_Sel = arrSchoolTerm_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrSchoolTerm_Sel = arrSchoolTerm_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrSchoolTerm_Sel = arrSchoolTerm_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrSchoolTerm_Sel = arrSchoolTerm_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrSchoolTerm_Sel = arrSchoolTerm_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrSchoolTerm_Sel = arrSchoolTerm_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrSchoolTerm_Sel = arrSchoolTerm_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrSchoolTerm_Sel = arrSchoolTerm_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrSchoolTerm_Sel = arrSchoolTerm_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrSchoolTerm_Sel = arrSchoolTerm_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrSchoolTerm_Sel = arrSchoolTerm_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrSchoolTerm_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objSchoolTerm_Cond), exports.schoolTerm_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.SchoolTerm_IsExistRecord_Cache = SchoolTerm_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function SchoolTerm_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.schoolTerm_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.schoolTerm_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.schoolTerm_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SchoolTerm_IsExistRecordAsync = SchoolTerm_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strSchoolTerm:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function SchoolTerm_IsExist(strSchoolTerm, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.schoolTerm_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "SchoolTerm": strSchoolTerm,
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.schoolTerm_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.schoolTerm_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SchoolTerm_IsExist = SchoolTerm_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param strSchoolTerm:所给的关键字
     * @returns 对象
    */
    async function SchoolTerm_IsExist_Cache(strSchoolTerm) {
        const strThisFuncName = "IsExist_Cache";
        const arrSchoolTermObjLst_Cache = await SchoolTerm_GetObjLst_Cache();
        if (arrSchoolTermObjLst_Cache == null)
            return false;
        try {
            const arrSchoolTerm_Sel = arrSchoolTermObjLst_Cache.filter(x => x.schoolTerm == strSchoolTerm);
            if (arrSchoolTerm_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strSchoolTerm, exports.schoolTerm_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.SchoolTerm_IsExist_Cache = SchoolTerm_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strSchoolTerm:关键字
    * @returns 是否存在?存在返回True
    **/
    async function SchoolTerm_IsExistAsync(strSchoolTerm) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.schoolTerm_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strSchoolTerm": strSchoolTerm }
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.schoolTerm_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.schoolTerm_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SchoolTerm_IsExistAsync = SchoolTerm_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function SchoolTerm_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.schoolTerm_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.schoolTerm_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.schoolTerm_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SchoolTerm_GetRecCountByCondAsync = SchoolTerm_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objSchoolTerm_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function SchoolTerm_GetRecCountByCond_Cache(objSchoolTerm_Cond) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrSchoolTermObjLst_Cache = await SchoolTerm_GetObjLst_Cache();
        if (arrSchoolTermObjLst_Cache == null)
            return 0;
        let arrSchoolTerm_Sel = arrSchoolTermObjLst_Cache;
        if (objSchoolTerm_Cond.sf_FldComparisonOp == null || objSchoolTerm_Cond.sf_FldComparisonOp == "")
            return arrSchoolTerm_Sel.length;
        const dicFldComparisonOp = JSON.parse(objSchoolTerm_Cond.sf_FldComparisonOp);
        //console.log("clsSchoolTermWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objSchoolTerm_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrSchoolTerm_Sel = arrSchoolTerm_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objSchoolTerm_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrSchoolTerm_Sel = arrSchoolTerm_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrSchoolTerm_Sel = arrSchoolTerm_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrSchoolTerm_Sel = arrSchoolTerm_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrSchoolTerm_Sel = arrSchoolTerm_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrSchoolTerm_Sel = arrSchoolTerm_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrSchoolTerm_Sel = arrSchoolTerm_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrSchoolTerm_Sel = arrSchoolTerm_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrSchoolTerm_Sel = arrSchoolTerm_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrSchoolTerm_Sel = arrSchoolTerm_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrSchoolTerm_Sel = arrSchoolTerm_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrSchoolTerm_Sel = arrSchoolTerm_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrSchoolTerm_Sel = arrSchoolTerm_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrSchoolTerm_Sel = arrSchoolTerm_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrSchoolTerm_Sel = arrSchoolTerm_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrSchoolTerm_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objSchoolTerm_Cond), exports.schoolTerm_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.SchoolTerm_GetRecCountByCond_Cache = SchoolTerm_GetRecCountByCond_Cache;
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
    async function SchoolTerm_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.schoolTerm_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.schoolTerm_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.schoolTerm_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SchoolTerm_GetMaxStrIdByPrefix = SchoolTerm_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function SchoolTerm_GetWebApiUrl(strController, strAction) {
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
    exports.SchoolTerm_GetWebApiUrl = SchoolTerm_GetWebApiUrl;
    /**
    * 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshCache)
    **/
    function SchoolTerm_ReFreshCache() {
        const strThisFuncName = "ReFreshCache";
        const strMsg = (0, clsString_js_2.Format)("刷新缓存成功！");
        console.trace(strMsg);
        // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
        const strKey = clsSchoolTermEN_js_1.clsSchoolTermEN._CurrTabName;
        switch (clsSchoolTermEN_js_1.clsSchoolTermEN.CacheModeId) {
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
    exports.SchoolTerm_ReFreshCache = SchoolTerm_ReFreshCache;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function SchoolTerm_ReFreshThisCache() {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = clsSchoolTermEN_js_1.clsSchoolTermEN._CurrTabName;
            switch (clsSchoolTermEN_js_1.clsSchoolTermEN.CacheModeId) {
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
    exports.SchoolTerm_ReFreshThisCache = SchoolTerm_ReFreshThisCache;
    /**
     * 绑定基于Web的下拉框,在某一层下的下拉框
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunctionInDiv)
     * @param objDDL:需要绑定当前表的下拉框
    */
    async function SchoolTerm_BindDdl_SchoolTermInDiv_Cache(strDivName, strDdlName) {
        const strThisFuncName = "BindDdl_SchoolTermInDiv_Cache";
        const objDdl = document.getElementById(strDdlName);
        if (objDdl == null) {
            const strMsg = (0, clsString_js_2.Format)("下拉框：{0} 不存在！(In BindDdl_SchoolTermInDiv)", strDdlName);
            alert(strMsg);
            console.error(strMsg);
            throw (strMsg);
        }
        //为数据源于表的下拉框设置内容
        //console.log("开始：BindDdl_SchoolTermInDiv_Cache");
        const arrObjLst_Sel = await SchoolTerm_GetObjLst_Cache();
        if (arrObjLst_Sel == null)
            return;
        (0, clsCommFunc4Web_js_1.BindDdl_ObjLstInDiv)(strDivName, strDdlName, arrObjLst_Sel, clsSchoolTermEN_js_1.clsSchoolTermEN.con_SchoolTerm, clsSchoolTermEN_js_1.clsSchoolTermEN.con_SchoolTermName, "学期");
    }
    exports.SchoolTerm_BindDdl_SchoolTermInDiv_Cache = SchoolTerm_BindDdl_SchoolTermInDiv_Cache;
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function SchoolTerm_CheckPropertyNew(pobjSchoolTermEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        if (null === pobjSchoolTermEN.isCurrentSchoolTerm
            || pobjSchoolTermEN.isCurrentSchoolTerm != null && pobjSchoolTermEN.isCurrentSchoolTerm.toString() === "") {
            throw new Error("(errid:Watl000058)字段[学期]不能为空(In 学期)!(clsSchoolTermBL:CheckPropertyNew)");
        }
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSchoolTermEN.schoolTerm) == false && (0, clsString_js_2.GetStrLen)(pobjSchoolTermEN.schoolTerm) > 1) {
            throw new Error("(errid:Watl000059)字段[学期(schoolTerm)]的长度不能超过1(In 学期(SchoolTerm))!值:$(pobjSchoolTermEN.schoolTerm)(clsSchoolTermBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSchoolTermEN.schoolTermName) == false && (0, clsString_js_2.GetStrLen)(pobjSchoolTermEN.schoolTermName) > 1) {
            throw new Error("(errid:Watl000059)字段[学期名(schoolTermName)]的长度不能超过1(In 学期(SchoolTerm))!值:$(pobjSchoolTermEN.schoolTermName)(clsSchoolTermBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSchoolTermEN.schoolTerm) == false && undefined !== pobjSchoolTermEN.schoolTerm && clsString_js_1.tzDataType.isString(pobjSchoolTermEN.schoolTerm) === false) {
            throw new Error("(errid:Watl000060)字段[学期(schoolTerm)]的值:[$(pobjSchoolTermEN.schoolTerm)], 非法，应该为字符型(In 学期(SchoolTerm))!(clsSchoolTermBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSchoolTermEN.schoolTermName) == false && undefined !== pobjSchoolTermEN.schoolTermName && clsString_js_1.tzDataType.isString(pobjSchoolTermEN.schoolTermName) === false) {
            throw new Error("(errid:Watl000060)字段[学期名(schoolTermName)]的值:[$(pobjSchoolTermEN.schoolTermName)], 非法，应该为字符型(In 学期(SchoolTerm))!(clsSchoolTermBL:CheckPropertyNew)");
        }
        if (null != pobjSchoolTermEN.isCurrentSchoolTerm && undefined !== pobjSchoolTermEN.isCurrentSchoolTerm && clsString_js_1.tzDataType.isBoolean(pobjSchoolTermEN.isCurrentSchoolTerm) === false) {
            throw new Error("(errid:Watl000060)字段[学期(isCurrentSchoolTerm)]的值:[$(pobjSchoolTermEN.isCurrentSchoolTerm)], 非法，应该为布尔型(In 学期(SchoolTerm))!(clsSchoolTermBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjSchoolTermEN.SetIsCheckProperty(true);
    }
    exports.SchoolTerm_CheckPropertyNew = SchoolTerm_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function SchoolTerm_CheckProperty4Update(pobjSchoolTermEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSchoolTermEN.schoolTerm) == false && (0, clsString_js_2.GetStrLen)(pobjSchoolTermEN.schoolTerm) > 1) {
            throw new Error("(errid:Watl000062)字段[学期(schoolTerm)]的长度不能超过1(In 学期(SchoolTerm))!值:$(pobjSchoolTermEN.schoolTerm)(clsSchoolTermBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSchoolTermEN.schoolTermName) == false && (0, clsString_js_2.GetStrLen)(pobjSchoolTermEN.schoolTermName) > 1) {
            throw new Error("(errid:Watl000062)字段[学期名(schoolTermName)]的长度不能超过1(In 学期(SchoolTerm))!值:$(pobjSchoolTermEN.schoolTermName)(clsSchoolTermBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSchoolTermEN.schoolTerm) == false && undefined !== pobjSchoolTermEN.schoolTerm && clsString_js_1.tzDataType.isString(pobjSchoolTermEN.schoolTerm) === false) {
            throw new Error("(errid:Watl000063)字段[学期(schoolTerm)]的值:[$(pobjSchoolTermEN.schoolTerm)], 非法，应该为字符型(In 学期(SchoolTerm))!(clsSchoolTermBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSchoolTermEN.schoolTermName) == false && undefined !== pobjSchoolTermEN.schoolTermName && clsString_js_1.tzDataType.isString(pobjSchoolTermEN.schoolTermName) === false) {
            throw new Error("(errid:Watl000063)字段[学期名(schoolTermName)]的值:[$(pobjSchoolTermEN.schoolTermName)], 非法，应该为字符型(In 学期(SchoolTerm))!(clsSchoolTermBL:CheckProperty4Update)");
        }
        if (null != pobjSchoolTermEN.isCurrentSchoolTerm && undefined !== pobjSchoolTermEN.isCurrentSchoolTerm && clsString_js_1.tzDataType.isBoolean(pobjSchoolTermEN.isCurrentSchoolTerm) === false) {
            throw new Error("(errid:Watl000063)字段[学期(isCurrentSchoolTerm)]的值:[$(pobjSchoolTermEN.isCurrentSchoolTerm)], 非法，应该为布尔型(In 学期(SchoolTerm))!(clsSchoolTermBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSchoolTermEN.schoolTerm) === true
            || pobjSchoolTermEN.schoolTerm.toString() === "0") {
            throw new Error("(errid:Watl000064)字段[学期]不能为空(In 学期)!(clsSchoolTermBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjSchoolTermEN.SetIsCheckProperty(true);
    }
    exports.SchoolTerm_CheckProperty4Update = SchoolTerm_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function SchoolTerm_GetJSONStrByObj(pobjSchoolTermEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjSchoolTermEN.sf_UpdFldSetStr = pobjSchoolTermEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjSchoolTermEN);
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
    exports.SchoolTerm_GetJSONStrByObj = SchoolTerm_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function SchoolTerm_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrSchoolTermObjLst = new Array();
        if (strJSON === "") {
            return arrSchoolTermObjLst;
        }
        try {
            arrSchoolTermObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrSchoolTermObjLst;
        }
        return arrSchoolTermObjLst;
    }
    exports.SchoolTerm_GetObjLstByJSONStr = SchoolTerm_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrSchoolTermObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function SchoolTerm_GetObjLstByJSONObjLst(arrSchoolTermObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrSchoolTermObjLst = new Array();
        for (const objInFor of arrSchoolTermObjLstS) {
            const obj1 = SchoolTerm_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrSchoolTermObjLst.push(obj1);
        }
        return arrSchoolTermObjLst;
    }
    exports.SchoolTerm_GetObjLstByJSONObjLst = SchoolTerm_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function SchoolTerm_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjSchoolTermEN = new clsSchoolTermEN_js_1.clsSchoolTermEN();
        if (strJSON === "") {
            return pobjSchoolTermEN;
        }
        try {
            pobjSchoolTermEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjSchoolTermEN;
        }
        return pobjSchoolTermEN;
    }
    exports.SchoolTerm_GetObjByJSONStr = SchoolTerm_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function SchoolTerm_GetCombineCondition(objSchoolTerm_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objSchoolTerm_Cond.dicFldComparisonOp, clsSchoolTermEN_js_1.clsSchoolTermEN.con_SchoolTerm) == true) {
            const strComparisonOp_SchoolTerm = objSchoolTerm_Cond.dicFldComparisonOp[clsSchoolTermEN_js_1.clsSchoolTermEN.con_SchoolTerm];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsSchoolTermEN_js_1.clsSchoolTermEN.con_SchoolTerm, objSchoolTerm_Cond.schoolTerm, strComparisonOp_SchoolTerm);
        }
        if (Object.prototype.hasOwnProperty.call(objSchoolTerm_Cond.dicFldComparisonOp, clsSchoolTermEN_js_1.clsSchoolTermEN.con_SchoolTermName) == true) {
            const strComparisonOp_SchoolTermName = objSchoolTerm_Cond.dicFldComparisonOp[clsSchoolTermEN_js_1.clsSchoolTermEN.con_SchoolTermName];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsSchoolTermEN_js_1.clsSchoolTermEN.con_SchoolTermName, objSchoolTerm_Cond.schoolTermName, strComparisonOp_SchoolTermName);
        }
        if (Object.prototype.hasOwnProperty.call(objSchoolTerm_Cond.dicFldComparisonOp, clsSchoolTermEN_js_1.clsSchoolTermEN.con_IsCurrentSchoolTerm) == true) {
            if (objSchoolTerm_Cond.isCurrentSchoolTerm == true) {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '1'", clsSchoolTermEN_js_1.clsSchoolTermEN.con_IsCurrentSchoolTerm);
            }
            else {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '0'", clsSchoolTermEN_js_1.clsSchoolTermEN.con_IsCurrentSchoolTerm);
            }
        }
        return strWhereCond;
    }
    exports.SchoolTerm_GetCombineCondition = SchoolTerm_GetCombineCondition;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objSchoolTermENS:源对象
     * @param objSchoolTermENT:目标对象
    */
    function SchoolTerm_CopyObjTo(objSchoolTermENS, objSchoolTermENT) {
        objSchoolTermENT.schoolTerm = objSchoolTermENS.schoolTerm; //学期
        objSchoolTermENT.schoolTermName = objSchoolTermENS.schoolTermName; //学期名
        objSchoolTermENT.isCurrentSchoolTerm = objSchoolTermENS.isCurrentSchoolTerm; //学期
        objSchoolTermENT.sf_UpdFldSetStr = objSchoolTermENS.updFldString; //sf_UpdFldSetStr
    }
    exports.SchoolTerm_CopyObjTo = SchoolTerm_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objSchoolTermENS:源对象
     * @param objSchoolTermENT:目标对象
    */
    function SchoolTerm_GetObjFromJsonObj(objSchoolTermENS) {
        const objSchoolTermENT = new clsSchoolTermEN_js_1.clsSchoolTermEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objSchoolTermENT, objSchoolTermENS);
        return objSchoolTermENT;
    }
    exports.SchoolTerm_GetObjFromJsonObj = SchoolTerm_GetObjFromJsonObj;
});
