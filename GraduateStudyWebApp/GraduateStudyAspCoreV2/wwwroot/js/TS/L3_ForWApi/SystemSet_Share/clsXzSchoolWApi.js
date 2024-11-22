/**
* 类名:clsXzSchoolWApi
* 表名:XzSchool(01120029)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/14 18:24:32
* 生成者:pyf
* 生成服务器IP:
工程名称:问卷调查(0112)
CM工程:研究生论文学习(变量首字母小写)-全部函数集
* 相关数据库:103.116.76.183,9433EduHigh_Jsie
* PrjDataBaseId:0170
模块中文名:系统设置(SystemSet)
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
        define(["require", "exports", "axios", "../../PubFun/enumComparisonOp.js", "../../PubFun/CacheHelper.js", "../../L0_Entity/SystemSet_Share/clsXzSchoolEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.XzSchool_GetObjFromJsonObj = exports.XzSchool_CopyObjTo = exports.XzSchool_GetCombineCondition = exports.XzSchool_GetObjByJSONStr = exports.XzSchool_GetObjLstByJSONObjLst = exports.XzSchool_GetObjLstByJSONStr = exports.XzSchool_GetJSONStrByObj = exports.XzSchool_CheckProperty4Update = exports.XzSchool_CheckPropertyNew = exports.XzSchool_BindDdl_id_SchoolInDiv_Cache = exports.XzSchool_ReFreshThisCache = exports.XzSchool_ReFreshCache = exports.XzSchool_GetWebApiUrl = exports.XzSchool_GetMaxStrIdByPrefix = exports.XzSchool_GetRecCountByCond_Cache = exports.XzSchool_GetRecCountByCondAsync = exports.XzSchool_IsExistAsync = exports.XzSchool_IsExist_Cache = exports.XzSchool_IsExist = exports.XzSchool_IsExistRecordAsync = exports.XzSchool_IsExistRecord_Cache = exports.XzSchool_UpdateWithConditionAsync = exports.XzSchool_UpdateRecordAsync = exports.XzSchool_AddNewRecordWithReturnKey = exports.XzSchool_AddNewRecordWithReturnKeyAsync = exports.XzSchool_AddNewRecordWithMaxIdAsync = exports.XzSchool_AddNewRecordAsync = exports.XzSchool_DelXzSchoolsByCondAsync = exports.XzSchool_DelXzSchoolsAsync = exports.XzSchool_DelRecordAsync = exports.XzSchool_GetObjLstByPagerAsync = exports.XzSchool_GetObjLstByPager_Cache = exports.XzSchool_GetObjLstByRange = exports.XzSchool_GetObjLstByRangeAsync = exports.XzSchool_GetTopObjLstAsync = exports.XzSchool_GetObjLstByid_SchoolLst_Cache = exports.XzSchool_GetObjLstByid_SchoolLstAsync = exports.XzSchool_GetSubObjLst_Cache = exports.XzSchool_GetObjLst_PureCache = exports.XzSchool_GetObjLst_Cache = exports.XzSchool_GetObjLst_sessionStorage_PureCache = exports.XzSchool_GetObjLst_sessionStorage = exports.XzSchool_GetObjLstAsync = exports.XzSchool_GetObjLst_localStorage_PureCache = exports.XzSchool_GetObjLst_localStorage = exports.XzSchool_GetObjLst_ClientCache = exports.XzSchool_GetFirstObjAsync = exports.XzSchool_GetFirstID = exports.XzSchool_GetFirstIDAsync = exports.XzSchool_funcKey = exports.XzSchool_FilterFunByKey = exports.XzSchool_SortFunByKey = exports.XzSchool_SortFun_Defa_2Fld = exports.XzSchool_SortFun_Defa = exports.XzSchool_func = exports.XzSchool_GetNameByid_School_Cache = exports.XzSchool_UpdateObjInLst_Cache = exports.XzSchool_GetObjByid_School_localStorage = exports.XzSchool_GetObjByid_School_Cache = exports.XzSchool_GetObjByid_SchoolAsync = exports.xzSchool_ConstructorName = exports.xzSchool_Controller = void 0;
    /**
     * 学校(XzSchool)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月14日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const enumComparisonOp_js_1 = require("../../PubFun/enumComparisonOp.js");
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsXzSchoolEN_js_1 = require("../../L0_Entity/SystemSet_Share/clsXzSchoolEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsString_js_2 = require("../../PubFun/clsString.js");
    exports.xzSchool_Controller = "XzSchoolApi";
    exports.xzSchool_ConstructorName = "xzSchool";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strid_School:关键字
    * @returns 对象
    **/
    async function XzSchool_GetObjByid_SchoolAsync(strid_School) {
        const strThisFuncName = "GetObjByid_SchoolAsync";
        if ((0, clsString_js_2.IsNullOrEmpty)(strid_School) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strid_School]不能为空！(In clsXzSchoolWApi.GetObjByid_SchoolAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_School.length != 4) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strid_School]的长度:[{0}]不正确！(clsXzSchoolWApi.GetObjByid_SchoolAsync)", strid_School.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByid_School";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzSchool_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "strid_School": strid_School,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    return null;
                }
                //console.log(returnObj);
                const objXzSchool = XzSchool_GetObjFromJsonObj(returnObj);
                return objXzSchool;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzSchool_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzSchool_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzSchool_GetObjByid_SchoolAsync = XzSchool_GetObjByid_SchoolAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param strid_School:所给的关键字
     * @returns 对象
    */
    async function XzSchool_GetObjByid_School_Cache(strid_School, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByid_School_Cache";
        if ((0, clsString_js_2.IsNullOrEmpty)(strid_School) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strid_School]不能为空！(In clsXzSchoolWApi.GetObjByid_School_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_School.length != 4) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strid_School]的长度:[{0}]不正确！(clsXzSchoolWApi.GetObjByid_School_Cache)", strid_School.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrXzSchoolObjLst_Cache = await XzSchool_GetObjLst_Cache();
        try {
            const arrXzSchool_Sel = arrXzSchoolObjLst_Cache.filter(x => x.id_School == strid_School);
            let objXzSchool;
            if (arrXzSchool_Sel.length > 0) {
                objXzSchool = arrXzSchool_Sel[0];
                return objXzSchool;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    const objXzSchool_Const = await XzSchool_GetObjByid_SchoolAsync(strid_School);
                    if (objXzSchool_Const != null) {
                        XzSchool_ReFreshThisCache();
                        return objXzSchool_Const;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strid_School, exports.xzSchool_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.XzSchool_GetObjByid_School_Cache = XzSchool_GetObjByid_School_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param strid_School:所给的关键字
     * @returns 对象
    */
    async function XzSchool_GetObjByid_School_localStorage(strid_School) {
        const strThisFuncName = "GetObjByid_School_localStorage";
        if ((0, clsString_js_2.IsNullOrEmpty)(strid_School) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strid_School]不能为空！(In clsXzSchoolWApi.GetObjByid_School_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_School.length != 4) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strid_School]的长度:[{0}]不正确！(clsXzSchoolWApi.GetObjByid_School_localStorage)", strid_School.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsXzSchoolEN_js_1.clsXzSchoolEN._CurrTabName, strid_School);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objXzSchool_Cache = JSON.parse(strTempObj);
            return objXzSchool_Cache;
        }
        try {
            const objXzSchool = await XzSchool_GetObjByid_SchoolAsync(strid_School);
            if (objXzSchool != null) {
                localStorage.setItem(strKey, JSON.stringify(objXzSchool));
                const strInfo = (0, clsString_js_2.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objXzSchool;
            }
            return objXzSchool;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strid_School, exports.xzSchool_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.XzSchool_GetObjByid_School_localStorage = XzSchool_GetObjByid_School_localStorage;
    /**
     * 修改在缓存对象列表中的对象, 与后台数据库无关.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
     * @param objXzSchool:所给的对象
     * @returns 对象
    */
    async function XzSchool_UpdateObjInLst_Cache(objXzSchool) {
        const strThisFuncName = "UpdateObjInLst_Cache";
        try {
            const arrXzSchoolObjLst_Cache = await XzSchool_GetObjLst_Cache();
            const obj = arrXzSchoolObjLst_Cache.find(x => x.id_School == objXzSchool.id_School);
            if (obj != null) {
                objXzSchool.id_School = obj.id_School;
                (0, clsCommFunc4Web_js_1.ObjectAssign)(obj, objXzSchool);
            }
            else {
                arrXzSchoolObjLst_Cache.push(objXzSchool);
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, exports.xzSchool_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.XzSchool_UpdateObjInLst_Cache = XzSchool_UpdateObjInLst_Cache;
    /**
     * 根据关键字获取相关对象的名称属性, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetNameByKeyId_Cache)
     * @param strid_School:所给的关键字
     * @returns 对象
    */
    async function XzSchool_GetNameByid_School_Cache(strid_School) {
        const strThisFuncName = "GetNameByid_School_Cache";
        if ((0, clsString_js_2.IsNullOrEmpty)(strid_School) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strid_School]不能为空！(In clsXzSchoolWApi.GetNameByid_School_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_School.length != 4) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strid_School]的长度:[{0}]不正确！(clsXzSchoolWApi.GetNameByid_School_Cache)", strid_School.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrXzSchoolObjLst_Cache = await XzSchool_GetObjLst_Cache();
        if (arrXzSchoolObjLst_Cache == null)
            return "";
        try {
            const arrXzSchool_Sel = arrXzSchoolObjLst_Cache.filter(x => x.id_School == strid_School);
            let objXzSchool;
            if (arrXzSchool_Sel.length > 0) {
                objXzSchool = arrXzSchool_Sel[0];
                return objXzSchool.schoolName;
            }
            else {
                return "";
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象名称属性不成功!", e, strid_School);
            console.error(strMsg);
            alert(strMsg);
        }
        return "";
    }
    exports.XzSchool_GetNameByid_School_Cache = XzSchool_GetNameByid_School_Cache;
    /**
     * 映射函数。根据表映射把输入字段值，映射成输出字段值
     * 作者:pyf
     * 日期:2023-03-14
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_func)
     * @param strInFldName:输入字段名
     * @param strOutFldName:输出字段名
     * @param strInValue:输入字段值
     * @returns 返回一个输出字段值
    */
    async function XzSchool_func(strInFldName, strOutFldName, strInValue) {
        //const strThisFuncName = "func";
        if (strInFldName != clsXzSchoolEN_js_1.clsXzSchoolEN.con_id_School) {
            const strMsg = (0, clsString_js_2.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsXzSchoolEN_js_1.clsXzSchoolEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_2.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strOutFldName, clsXzSchoolEN_js_1.clsXzSchoolEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strid_School = strInValue;
        if ((0, clsString_js_2.IsNullOrEmpty)(strInValue) == true) {
            return "";
        }
        const objXzSchool = await XzSchool_GetObjByid_School_Cache(strid_School);
        if (objXzSchool == null)
            return "";
        if (objXzSchool.GetFldValue(strOutFldName) == null)
            return "";
        return objXzSchool.GetFldValue(strOutFldName).toString();
    }
    exports.XzSchool_func = XzSchool_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-14
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function XzSchool_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.id_School.localeCompare(b.id_School);
    }
    exports.XzSchool_SortFun_Defa = XzSchool_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-14
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function XzSchool_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.schoolId == b.schoolId)
            return a.schoolName.localeCompare(b.schoolName);
        else
            return a.schoolId.localeCompare(b.schoolId);
    }
    exports.XzSchool_SortFun_Defa_2Fld = XzSchool_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-14
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function XzSchool_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsXzSchoolEN_js_1.clsXzSchoolEN.con_id_School:
                    return (a, b) => {
                        return a.id_School.localeCompare(b.id_School);
                    };
                case clsXzSchoolEN_js_1.clsXzSchoolEN.con_SchoolId:
                    return (a, b) => {
                        return a.schoolId.localeCompare(b.schoolId);
                    };
                case clsXzSchoolEN_js_1.clsXzSchoolEN.con_SchoolName:
                    return (a, b) => {
                        return a.schoolName.localeCompare(b.schoolName);
                    };
                case clsXzSchoolEN_js_1.clsXzSchoolEN.con_SchoolENName:
                    return (a, b) => {
                        if (a.schoolENName == null)
                            return -1;
                        if (b.schoolENName == null)
                            return 1;
                        return a.schoolENName.localeCompare(b.schoolENName);
                    };
                case clsXzSchoolEN_js_1.clsXzSchoolEN.con_SchoolNameA:
                    return (a, b) => {
                        if (a.schoolNameA == null)
                            return -1;
                        if (b.schoolNameA == null)
                            return 1;
                        return a.schoolNameA.localeCompare(b.schoolNameA);
                    };
                case clsXzSchoolEN_js_1.clsXzSchoolEN.con_SchoolTypeId:
                    return (a, b) => {
                        if (a.schoolTypeId == null)
                            return -1;
                        if (b.schoolTypeId == null)
                            return 1;
                        return a.schoolTypeId.localeCompare(b.schoolTypeId);
                    };
                case clsXzSchoolEN_js_1.clsXzSchoolEN.con_IsCurrentUse:
                    return (a, b) => {
                        if (a.isCurrentUse == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsXzSchoolEN_js_1.clsXzSchoolEN.con_UpdDate:
                    return (a, b) => {
                        if (a.updDate == null)
                            return -1;
                        if (b.updDate == null)
                            return 1;
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsXzSchoolEN_js_1.clsXzSchoolEN.con_UpdUserId:
                    return (a, b) => {
                        if (a.updUserId == null)
                            return -1;
                        if (b.updUserId == null)
                            return 1;
                        return a.updUserId.localeCompare(b.updUserId);
                    };
                case clsXzSchoolEN_js_1.clsXzSchoolEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[XzSchool]中不存在！(in ${exports.xzSchool_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsXzSchoolEN_js_1.clsXzSchoolEN.con_id_School:
                    return (a, b) => {
                        return b.id_School.localeCompare(a.id_School);
                    };
                case clsXzSchoolEN_js_1.clsXzSchoolEN.con_SchoolId:
                    return (a, b) => {
                        return b.schoolId.localeCompare(a.schoolId);
                    };
                case clsXzSchoolEN_js_1.clsXzSchoolEN.con_SchoolName:
                    return (a, b) => {
                        return b.schoolName.localeCompare(a.schoolName);
                    };
                case clsXzSchoolEN_js_1.clsXzSchoolEN.con_SchoolENName:
                    return (a, b) => {
                        if (b.schoolENName == null)
                            return -1;
                        if (a.schoolENName == null)
                            return 1;
                        return b.schoolENName.localeCompare(a.schoolENName);
                    };
                case clsXzSchoolEN_js_1.clsXzSchoolEN.con_SchoolNameA:
                    return (a, b) => {
                        if (b.schoolNameA == null)
                            return -1;
                        if (a.schoolNameA == null)
                            return 1;
                        return b.schoolNameA.localeCompare(a.schoolNameA);
                    };
                case clsXzSchoolEN_js_1.clsXzSchoolEN.con_SchoolTypeId:
                    return (a, b) => {
                        if (b.schoolTypeId == null)
                            return -1;
                        if (a.schoolTypeId == null)
                            return 1;
                        return b.schoolTypeId.localeCompare(a.schoolTypeId);
                    };
                case clsXzSchoolEN_js_1.clsXzSchoolEN.con_IsCurrentUse:
                    return (a, b) => {
                        if (b.isCurrentUse == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsXzSchoolEN_js_1.clsXzSchoolEN.con_UpdDate:
                    return (a, b) => {
                        if (b.updDate == null)
                            return -1;
                        if (a.updDate == null)
                            return 1;
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsXzSchoolEN_js_1.clsXzSchoolEN.con_UpdUserId:
                    return (a, b) => {
                        if (b.updUserId == null)
                            return -1;
                        if (a.updUserId == null)
                            return 1;
                        return b.updUserId.localeCompare(a.updUserId);
                    };
                case clsXzSchoolEN_js_1.clsXzSchoolEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[XzSchool]中不存在！(in ${exports.xzSchool_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.XzSchool_SortFunByKey = XzSchool_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-14
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function XzSchool_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsXzSchoolEN_js_1.clsXzSchoolEN.con_id_School:
                return (obj) => {
                    return obj.id_School === value;
                };
            case clsXzSchoolEN_js_1.clsXzSchoolEN.con_SchoolId:
                return (obj) => {
                    return obj.schoolId === value;
                };
            case clsXzSchoolEN_js_1.clsXzSchoolEN.con_SchoolName:
                return (obj) => {
                    return obj.schoolName === value;
                };
            case clsXzSchoolEN_js_1.clsXzSchoolEN.con_SchoolENName:
                return (obj) => {
                    return obj.schoolENName === value;
                };
            case clsXzSchoolEN_js_1.clsXzSchoolEN.con_SchoolNameA:
                return (obj) => {
                    return obj.schoolNameA === value;
                };
            case clsXzSchoolEN_js_1.clsXzSchoolEN.con_SchoolTypeId:
                return (obj) => {
                    return obj.schoolTypeId === value;
                };
            case clsXzSchoolEN_js_1.clsXzSchoolEN.con_IsCurrentUse:
                return (obj) => {
                    return obj.isCurrentUse === value;
                };
            case clsXzSchoolEN_js_1.clsXzSchoolEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsXzSchoolEN_js_1.clsXzSchoolEN.con_UpdUserId:
                return (obj) => {
                    return obj.updUserId === value;
                };
            case clsXzSchoolEN_js_1.clsXzSchoolEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[XzSchool]中不存在！(in ${exports.xzSchool_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.XzSchool_FilterFunByKey = XzSchool_FilterFunByKey;
    /**
     * 映射函数。根据表映射把输入字段值，映射成输出字段值
     * 作者:pyf
     * 日期:2023-03-14
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_funcKey)
     * @param strInFldName:输入字段名
     * @param strInValue:输入字段值
     * @param strComparisonOp:比较操作符
     * @returns 返回一个关键字值列表
    */
    async function XzSchool_funcKey(strInFldName, strInValue, strComparisonOp) {
        //const strThisFuncName = "funcKey";
        if (strInFldName == clsXzSchoolEN_js_1.clsXzSchoolEN.con_id_School) {
            const strMsg = (0, clsString_js_2.Format)("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(strInValue) == true) {
            return [];
        }
        const arrXzSchool = await XzSchool_GetObjLst_Cache();
        if (arrXzSchool == null)
            return [];
        let arrXzSchool_Sel = arrXzSchool;
        const strType = typeof (strInValue);
        switch (strType) {
            case "string":
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01: // " = "
                        arrXzSchool_Sel = arrXzSchool_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.Like_03:
                        arrXzSchool_Sel = arrXzSchool_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.In_04:
                        const arrValues = strInValue.split(',');
                        arrXzSchool_Sel = arrXzSchool_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
                        break;
                }
                break;
            case "boolean":
                if (strInValue == null)
                    return [];
                if (strComparisonOp == enumComparisonOp_js_1.enumComparisonOp.Equal_01) {
                    arrXzSchool_Sel = arrXzSchool_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                }
                break;
            case "number":
                if (Number(strInValue) == 0)
                    return [];
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01:
                        arrXzSchool_Sel = arrXzSchool_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotEqual_02:
                        arrXzSchool_Sel = arrXzSchool_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotLessThan_05: //" >= ":
                        arrXzSchool_Sel = arrXzSchool_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotGreaterThan_06: //" <= ":
                        arrXzSchool_Sel = arrXzSchool_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.GreaterThan_07: //" > ":
                        arrXzSchool_Sel = arrXzSchool_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.LessThan_08: //" < ":
                        arrXzSchool_Sel = arrXzSchool_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                }
                break;
        }
        if (arrXzSchool_Sel.length == 0)
            return [];
        return arrXzSchool_Sel.map(x => x.id_School);
    }
    exports.XzSchool_funcKey = XzSchool_funcKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function XzSchool_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzSchool_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzSchool_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzSchool_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzSchool_GetFirstIDAsync = XzSchool_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function XzSchool_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzSchool_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzSchool_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzSchool_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzSchool_GetFirstID = XzSchool_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function XzSchool_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzSchool_Controller, strAction);
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
                const objXzSchool = XzSchool_GetObjFromJsonObj(returnObj);
                return objXzSchool;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzSchool_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzSchool_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzSchool_GetFirstObjAsync = XzSchool_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function XzSchool_GetObjLst_ClientCache() {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsXzSchoolEN_js_1.clsXzSchoolEN._CurrTabName;
        if ((0, clsString_js_2.IsNullOrEmpty)(clsXzSchoolEN_js_1.clsXzSchoolEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsXzSchoolEN_js_1.clsXzSchoolEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_1.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrXzSchoolExObjLst_Cache = CacheHelper_js_1.CacheHelper.Get(strKey);
            const arrXzSchoolObjLst_T = XzSchool_GetObjLstByJSONObjLst(arrXzSchoolExObjLst_Cache);
            return arrXzSchoolObjLst_T;
        }
        try {
            const arrXzSchoolExObjLst = await XzSchool_GetObjLstAsync(strWhereCond);
            CacheHelper_js_1.CacheHelper.Add(strKey, arrXzSchoolExObjLst);
            const strInfo = (0, clsString_js_2.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrXzSchoolExObjLst.length);
            console.log(strInfo);
            return arrXzSchoolExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.xzSchool_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.XzSchool_GetObjLst_ClientCache = XzSchool_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function XzSchool_GetObjLst_localStorage() {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsXzSchoolEN_js_1.clsXzSchoolEN._CurrTabName;
        if ((0, clsString_js_2.IsNullOrEmpty)(clsXzSchoolEN_js_1.clsXzSchoolEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsXzSchoolEN_js_1.clsXzSchoolEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrXzSchoolExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrXzSchoolObjLst_T = XzSchool_GetObjLstByJSONObjLst(arrXzSchoolExObjLst_Cache);
            return arrXzSchoolObjLst_T;
        }
        try {
            const arrXzSchoolExObjLst = await XzSchool_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrXzSchoolExObjLst));
            const strInfo = (0, clsString_js_2.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrXzSchoolExObjLst.length);
            console.log(strInfo);
            return arrXzSchoolExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.xzSchool_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.XzSchool_GetObjLst_localStorage = XzSchool_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function XzSchool_GetObjLst_localStorage_PureCache() {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsXzSchoolEN_js_1.clsXzSchoolEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrXzSchoolObjLst_Cache = JSON.parse(strTempObjLst);
            return arrXzSchoolObjLst_Cache;
        }
        else
            return null;
    }
    exports.XzSchool_GetObjLst_localStorage_PureCache = XzSchool_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function XzSchool_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzSchool_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.xzSchool_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = XzSchool_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzSchool_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzSchool_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzSchool_GetObjLstAsync = XzSchool_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function XzSchool_GetObjLst_sessionStorage() {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsXzSchoolEN_js_1.clsXzSchoolEN._CurrTabName;
        if ((0, clsString_js_2.IsNullOrEmpty)(clsXzSchoolEN_js_1.clsXzSchoolEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsXzSchoolEN_js_1.clsXzSchoolEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrXzSchoolExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrXzSchoolObjLst_T = XzSchool_GetObjLstByJSONObjLst(arrXzSchoolExObjLst_Cache);
            return arrXzSchoolObjLst_T;
        }
        try {
            const arrXzSchoolExObjLst = await XzSchool_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrXzSchoolExObjLst));
            const strInfo = (0, clsString_js_2.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrXzSchoolExObjLst.length);
            console.log(strInfo);
            return arrXzSchoolExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.xzSchool_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.XzSchool_GetObjLst_sessionStorage = XzSchool_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function XzSchool_GetObjLst_sessionStorage_PureCache() {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsXzSchoolEN_js_1.clsXzSchoolEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrXzSchoolObjLst_Cache = JSON.parse(strTempObjLst);
            return arrXzSchoolObjLst_Cache;
        }
        else
            return null;
    }
    exports.XzSchool_GetObjLst_sessionStorage_PureCache = XzSchool_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function XzSchool_GetObjLst_Cache() {
        //const strThisFuncName = "GetObjLst_Cache";
        let arrXzSchoolObjLst_Cache;
        switch (clsXzSchoolEN_js_1.clsXzSchoolEN.CacheModeId) {
            case "04": //sessionStorage
                arrXzSchoolObjLst_Cache = await XzSchool_GetObjLst_sessionStorage();
                break;
            case "03": //localStorage
                arrXzSchoolObjLst_Cache = await XzSchool_GetObjLst_localStorage();
                break;
            case "02": //ClientCache
                arrXzSchoolObjLst_Cache = await XzSchool_GetObjLst_ClientCache();
                break;
            default:
                arrXzSchoolObjLst_Cache = await XzSchool_GetObjLst_ClientCache();
                break;
        }
        const arrXzSchoolObjLst = XzSchool_GetObjLstByJSONObjLst(arrXzSchoolObjLst_Cache);
        return arrXzSchoolObjLst_Cache;
    }
    exports.XzSchool_GetObjLst_Cache = XzSchool_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function XzSchool_GetObjLst_PureCache() {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrXzSchoolObjLst_Cache;
        switch (clsXzSchoolEN_js_1.clsXzSchoolEN.CacheModeId) {
            case "04": //sessionStorage
                arrXzSchoolObjLst_Cache = await XzSchool_GetObjLst_sessionStorage_PureCache();
                break;
            case "03": //localStorage
                arrXzSchoolObjLst_Cache = await XzSchool_GetObjLst_localStorage_PureCache();
                break;
            case "02": //ClientCache
                arrXzSchoolObjLst_Cache = null;
                break;
            default:
                arrXzSchoolObjLst_Cache = null;
                break;
        }
        return arrXzSchoolObjLst_Cache;
    }
    exports.XzSchool_GetObjLst_PureCache = XzSchool_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objstrid_School_Cond:条件对象
     * @returns 对象列表子集
    */
    async function XzSchool_GetSubObjLst_Cache(objXzSchool_Cond) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrXzSchoolObjLst_Cache = await XzSchool_GetObjLst_Cache();
        let arrXzSchool_Sel = arrXzSchoolObjLst_Cache;
        if (objXzSchool_Cond.sf_FldComparisonOp == null || objXzSchool_Cond.sf_FldComparisonOp == "")
            return arrXzSchool_Sel;
        const dicFldComparisonOp = JSON.parse(objXzSchool_Cond.sf_FldComparisonOp);
        //console.log("clsXzSchoolWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objXzSchool_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrXzSchool_Sel = arrXzSchool_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objXzSchool_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzSchool_Sel = arrXzSchool_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrXzSchool_Sel = arrXzSchool_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrXzSchool_Sel = arrXzSchool_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrXzSchool_Sel = arrXzSchool_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrXzSchool_Sel = arrXzSchool_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrXzSchool_Sel = arrXzSchool_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrXzSchool_Sel = arrXzSchool_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzSchool_Sel = arrXzSchool_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzSchool_Sel = arrXzSchool_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrXzSchool_Sel = arrXzSchool_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrXzSchool_Sel = arrXzSchool_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrXzSchool_Sel = arrXzSchool_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrXzSchool_Sel = arrXzSchool_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrXzSchool_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objXzSchool_Cond), exports.xzSchool_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.XzSchool_GetSubObjLst_Cache = XzSchool_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrid_School:关键字列表
    * @returns 对象列表
    **/
    async function XzSchool_GetObjLstByid_SchoolLstAsync(arrid_School) {
        const strThisFuncName = "GetObjLstByid_SchoolLstAsync";
        const strAction = "GetObjLstByid_SchoolLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzSchool_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrid_School);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.xzSchool_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = XzSchool_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzSchool_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzSchool_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzSchool_GetObjLstByid_SchoolLstAsync = XzSchool_GetObjLstByid_SchoolLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrstrid_SchoolLst:关键字列表
     * @returns 对象列表
    */
    async function XzSchool_GetObjLstByid_SchoolLst_Cache(arrid_SchoolLst) {
        const strThisFuncName = "GetObjLstByid_SchoolLst_Cache";
        try {
            const arrXzSchoolObjLst_Cache = await XzSchool_GetObjLst_Cache();
            const arrXzSchool_Sel = arrXzSchoolObjLst_Cache.filter(x => arrid_SchoolLst.indexOf(x.id_School) > -1);
            return arrXzSchool_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrid_SchoolLst.join(","), exports.xzSchool_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
    }
    exports.XzSchool_GetObjLstByid_SchoolLst_Cache = XzSchool_GetObjLstByid_SchoolLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function XzSchool_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzSchool_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.xzSchool_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = XzSchool_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzSchool_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzSchool_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzSchool_GetTopObjLstAsync = XzSchool_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function XzSchool_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzSchool_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.xzSchool_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = XzSchool_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzSchool_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzSchool_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzSchool_GetObjLstByRangeAsync = XzSchool_GetObjLstByRangeAsync;
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
    async function XzSchool_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzSchool_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzSchool_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzSchool_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzSchool_GetObjLstByRange = XzSchool_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function XzSchool_GetObjLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const arrXzSchoolObjLst_Cache = await XzSchool_GetObjLst_Cache();
        if (arrXzSchoolObjLst_Cache.length == 0)
            return arrXzSchoolObjLst_Cache;
        let arrXzSchool_Sel = arrXzSchoolObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objXzSchool_Cond = new clsXzSchoolEN_js_1.clsXzSchoolEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objXzSchool_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsXzSchoolWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrXzSchool_Sel = arrXzSchool_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objXzSchool_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzSchool_Sel = arrXzSchool_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrXzSchool_Sel = arrXzSchool_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrXzSchool_Sel = arrXzSchool_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrXzSchool_Sel = arrXzSchool_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrXzSchool_Sel = arrXzSchool_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrXzSchool_Sel = arrXzSchool_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrXzSchool_Sel = arrXzSchool_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrXzSchool_Sel = arrXzSchool_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzSchool_Sel = arrXzSchool_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzSchool_Sel = arrXzSchool_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrXzSchool_Sel = arrXzSchool_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrXzSchool_Sel = arrXzSchool_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrXzSchool_Sel = arrXzSchool_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrXzSchool_Sel = arrXzSchool_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrXzSchool_Sel.length == 0)
                return arrXzSchool_Sel;
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
                arrXzSchool_Sel = arrXzSchool_Sel.sort(XzSchool_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrXzSchool_Sel = arrXzSchool_Sel.sort(objPagerPara.sortFun);
            }
            arrXzSchool_Sel = arrXzSchool_Sel.slice(intStart, intEnd);
            return arrXzSchool_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.xzSchool_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.XzSchool_GetObjLstByPager_Cache = XzSchool_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function XzSchool_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzSchool_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.xzSchool_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = XzSchool_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzSchool_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzSchool_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzSchool_GetObjLstByPagerAsync = XzSchool_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param strid_School:关键字
    * @returns 获取删除的结果
    **/
    async function XzSchool_DelRecordAsync(strid_School) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzSchool_Controller, strAction);
        strUrl = (0, clsString_js_2.Format)("{0}/?Id={1}", strUrl, strid_School);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzSchool_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzSchool_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzSchool_DelRecordAsync = XzSchool_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrid_School:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function XzSchool_DelXzSchoolsAsync(arrid_School) {
        const strThisFuncName = "DelXzSchoolsAsync";
        const strAction = "DelXzSchools";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzSchool_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrid_School);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzSchool_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzSchool_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzSchool_DelXzSchoolsAsync = XzSchool_DelXzSchoolsAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function XzSchool_DelXzSchoolsByCondAsync(strWhereCond) {
        const strThisFuncName = "DelXzSchoolsByCondAsync";
        const strAction = "DelXzSchoolsByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzSchool_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzSchool_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzSchool_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzSchool_DelXzSchoolsByCondAsync = XzSchool_DelXzSchoolsByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objXzSchoolEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function XzSchool_AddNewRecordAsync(objXzSchoolEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        if (objXzSchoolEN.id_School === null || objXzSchoolEN.id_School === "") {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            throw strMsg;
        }
        //var strJSON = JSON.stringify(objXzSchoolEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzSchool_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objXzSchoolEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzSchool_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzSchool_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzSchool_AddNewRecordAsync = XzSchool_AddNewRecordAsync;
    /**
    * 调用WebApi来添加记录，关键字用最大关键字，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithMaxIdAsync)
    * @param objXzSchoolEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function XzSchool_AddNewRecordWithMaxIdAsync(objXzSchoolEN) {
        const strThisFuncName = "AddNewRecordWithMaxIdAsync";
        const strAction = "AddNewRecordWithMaxId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzSchool_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objXzSchoolEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzSchool_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzSchool_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzSchool_AddNewRecordWithMaxIdAsync = XzSchool_AddNewRecordWithMaxIdAsync;
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objXzSchoolEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function XzSchool_AddNewRecordWithReturnKeyAsync(objXzSchoolEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzSchool_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objXzSchoolEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzSchool_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzSchool_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzSchool_AddNewRecordWithReturnKeyAsync = XzSchool_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objXzSchoolEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function XzSchool_AddNewRecordWithReturnKey(objXzSchoolEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objXzSchoolEN.id_School === null || objXzSchoolEN.id_School === "") {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzSchool_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objXzSchoolEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzSchool_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzSchool_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzSchool_AddNewRecordWithReturnKey = XzSchool_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objXzSchoolEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function XzSchool_UpdateRecordAsync(objXzSchoolEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objXzSchoolEN.sf_UpdFldSetStr === undefined || objXzSchoolEN.sf_UpdFldSetStr === null || objXzSchoolEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objXzSchoolEN.id_School);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzSchool_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objXzSchoolEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzSchool_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzSchool_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzSchool_UpdateRecordAsync = XzSchool_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objXzSchoolEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function XzSchool_UpdateWithConditionAsync(objXzSchoolEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objXzSchoolEN.sf_UpdFldSetStr === undefined || objXzSchoolEN.sf_UpdFldSetStr === null || objXzSchoolEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objXzSchoolEN.id_School);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzSchool_Controller, strAction);
        objXzSchoolEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objXzSchoolEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzSchool_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzSchool_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzSchool_UpdateWithConditionAsync = XzSchool_UpdateWithConditionAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objstrid_School_Cond:条件对象
     * @returns 对象列表子集
    */
    async function XzSchool_IsExistRecord_Cache(objXzSchool_Cond) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrXzSchoolObjLst_Cache = await XzSchool_GetObjLst_Cache();
        if (arrXzSchoolObjLst_Cache == null)
            return false;
        let arrXzSchool_Sel = arrXzSchoolObjLst_Cache;
        if (objXzSchool_Cond.sf_FldComparisonOp == null || objXzSchool_Cond.sf_FldComparisonOp == "")
            return arrXzSchool_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objXzSchool_Cond.sf_FldComparisonOp);
        //console.log("clsXzSchoolWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objXzSchool_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objXzSchool_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzSchool_Sel = arrXzSchool_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrXzSchool_Sel = arrXzSchool_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrXzSchool_Sel = arrXzSchool_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrXzSchool_Sel = arrXzSchool_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrXzSchool_Sel = arrXzSchool_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrXzSchool_Sel = arrXzSchool_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrXzSchool_Sel = arrXzSchool_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzSchool_Sel = arrXzSchool_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzSchool_Sel = arrXzSchool_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrXzSchool_Sel = arrXzSchool_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrXzSchool_Sel = arrXzSchool_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrXzSchool_Sel = arrXzSchool_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrXzSchool_Sel = arrXzSchool_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrXzSchool_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objXzSchool_Cond), exports.xzSchool_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.XzSchool_IsExistRecord_Cache = XzSchool_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function XzSchool_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzSchool_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzSchool_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzSchool_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzSchool_IsExistRecordAsync = XzSchool_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strid_School:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function XzSchool_IsExist(strid_School, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzSchool_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "id_School": strid_School,
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzSchool_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzSchool_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzSchool_IsExist = XzSchool_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param strid_School:所给的关键字
     * @returns 对象
    */
    async function XzSchool_IsExist_Cache(strid_School) {
        const strThisFuncName = "IsExist_Cache";
        const arrXzSchoolObjLst_Cache = await XzSchool_GetObjLst_Cache();
        if (arrXzSchoolObjLst_Cache == null)
            return false;
        try {
            const arrXzSchool_Sel = arrXzSchoolObjLst_Cache.filter(x => x.id_School == strid_School);
            if (arrXzSchool_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strid_School, exports.xzSchool_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.XzSchool_IsExist_Cache = XzSchool_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strid_School:关键字
    * @returns 是否存在?存在返回True
    **/
    async function XzSchool_IsExistAsync(strid_School) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzSchool_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strid_School": strid_School }
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzSchool_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzSchool_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzSchool_IsExistAsync = XzSchool_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function XzSchool_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzSchool_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzSchool_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzSchool_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzSchool_GetRecCountByCondAsync = XzSchool_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objXzSchool_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function XzSchool_GetRecCountByCond_Cache(objXzSchool_Cond) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrXzSchoolObjLst_Cache = await XzSchool_GetObjLst_Cache();
        if (arrXzSchoolObjLst_Cache == null)
            return 0;
        let arrXzSchool_Sel = arrXzSchoolObjLst_Cache;
        if (objXzSchool_Cond.sf_FldComparisonOp == null || objXzSchool_Cond.sf_FldComparisonOp == "")
            return arrXzSchool_Sel.length;
        const dicFldComparisonOp = JSON.parse(objXzSchool_Cond.sf_FldComparisonOp);
        //console.log("clsXzSchoolWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objXzSchool_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrXzSchool_Sel = arrXzSchool_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objXzSchool_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzSchool_Sel = arrXzSchool_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrXzSchool_Sel = arrXzSchool_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrXzSchool_Sel = arrXzSchool_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrXzSchool_Sel = arrXzSchool_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrXzSchool_Sel = arrXzSchool_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrXzSchool_Sel = arrXzSchool_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrXzSchool_Sel = arrXzSchool_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrXzSchool_Sel = arrXzSchool_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzSchool_Sel = arrXzSchool_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzSchool_Sel = arrXzSchool_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrXzSchool_Sel = arrXzSchool_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrXzSchool_Sel = arrXzSchool_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrXzSchool_Sel = arrXzSchool_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrXzSchool_Sel = arrXzSchool_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrXzSchool_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objXzSchool_Cond), exports.xzSchool_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.XzSchool_GetRecCountByCond_Cache = XzSchool_GetRecCountByCond_Cache;
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
    async function XzSchool_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzSchool_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzSchool_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzSchool_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzSchool_GetMaxStrIdByPrefix = XzSchool_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function XzSchool_GetWebApiUrl(strController, strAction) {
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
    exports.XzSchool_GetWebApiUrl = XzSchool_GetWebApiUrl;
    /**
    * 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshCache)
    **/
    function XzSchool_ReFreshCache() {
        const strThisFuncName = "ReFreshCache";
        const strMsg = (0, clsString_js_2.Format)("刷新缓存成功！");
        console.trace(strMsg);
        // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
        const strKey = clsXzSchoolEN_js_1.clsXzSchoolEN._CurrTabName;
        switch (clsXzSchoolEN_js_1.clsXzSchoolEN.CacheModeId) {
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
    exports.XzSchool_ReFreshCache = XzSchool_ReFreshCache;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function XzSchool_ReFreshThisCache() {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = clsXzSchoolEN_js_1.clsXzSchoolEN._CurrTabName;
            switch (clsXzSchoolEN_js_1.clsXzSchoolEN.CacheModeId) {
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
    exports.XzSchool_ReFreshThisCache = XzSchool_ReFreshThisCache;
    /**
     * 绑定基于Web的下拉框,在某一层下的下拉框
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunctionInDiv)
     * @param objDDL:需要绑定当前表的下拉框
    */
    async function XzSchool_BindDdl_id_SchoolInDiv_Cache(strDivName, strDdlName) {
        const strThisFuncName = "BindDdl_id_SchoolInDiv_Cache";
        const objDdl = document.getElementById(strDdlName);
        if (objDdl == null) {
            const strMsg = (0, clsString_js_2.Format)("下拉框：{0} 不存在！(In BindDdl_id_SchoolInDiv)", strDdlName);
            alert(strMsg);
            console.error(strMsg);
            throw (strMsg);
        }
        //为数据源于表的下拉框设置内容
        //console.log("开始：BindDdl_id_SchoolInDiv_Cache");
        const arrObjLst_Sel = await XzSchool_GetObjLst_Cache();
        if (arrObjLst_Sel == null)
            return;
        (0, clsCommFunc4Web_js_1.BindDdl_ObjLstInDiv)(strDivName, strDdlName, arrObjLst_Sel, clsXzSchoolEN_js_1.clsXzSchoolEN.con_id_School, clsXzSchoolEN_js_1.clsXzSchoolEN.con_SchoolName, "学校");
    }
    exports.XzSchool_BindDdl_id_SchoolInDiv_Cache = XzSchool_BindDdl_id_SchoolInDiv_Cache;
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function XzSchool_CheckPropertyNew(pobjXzSchoolEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzSchoolEN.schoolId) === true) {
            throw new Error("(errid:Watl000058)字段[学校编号]不能为空(In 学校)!(clsXzSchoolBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzSchoolEN.schoolName) === true) {
            throw new Error("(errid:Watl000058)字段[学校名称]不能为空(In 学校)!(clsXzSchoolBL:CheckPropertyNew)");
        }
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzSchoolEN.id_School) == false && (0, clsString_js_2.GetStrLen)(pobjXzSchoolEN.id_School) > 4) {
            throw new Error("(errid:Watl000059)字段[学校流水号(id_School)]的长度不能超过4(In 学校(XzSchool))!值:$(pobjXzSchoolEN.id_School)(clsXzSchoolBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzSchoolEN.schoolId) == false && (0, clsString_js_2.GetStrLen)(pobjXzSchoolEN.schoolId) > 10) {
            throw new Error("(errid:Watl000059)字段[学校编号(schoolId)]的长度不能超过10(In 学校(XzSchool))!值:$(pobjXzSchoolEN.schoolId)(clsXzSchoolBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzSchoolEN.schoolName) == false && (0, clsString_js_2.GetStrLen)(pobjXzSchoolEN.schoolName) > 50) {
            throw new Error("(errid:Watl000059)字段[学校名称(schoolName)]的长度不能超过50(In 学校(XzSchool))!值:$(pobjXzSchoolEN.schoolName)(clsXzSchoolBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzSchoolEN.schoolENName) == false && (0, clsString_js_2.GetStrLen)(pobjXzSchoolEN.schoolENName) > 50) {
            throw new Error("(errid:Watl000059)字段[SchoolENName(schoolENName)]的长度不能超过50(In 学校(XzSchool))!值:$(pobjXzSchoolEN.schoolENName)(clsXzSchoolBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzSchoolEN.schoolNameA) == false && (0, clsString_js_2.GetStrLen)(pobjXzSchoolEN.schoolNameA) > 14) {
            throw new Error("(errid:Watl000059)字段[学校简称(schoolNameA)]的长度不能超过14(In 学校(XzSchool))!值:$(pobjXzSchoolEN.schoolNameA)(clsXzSchoolBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzSchoolEN.schoolTypeId) == false && (0, clsString_js_2.GetStrLen)(pobjXzSchoolEN.schoolTypeId) > 2) {
            throw new Error("(errid:Watl000059)字段[学校类型Id(schoolTypeId)]的长度不能超过2(In 学校(XzSchool))!值:$(pobjXzSchoolEN.schoolTypeId)(clsXzSchoolBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzSchoolEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjXzSchoolEN.updDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 学校(XzSchool))!值:$(pobjXzSchoolEN.updDate)(clsXzSchoolBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzSchoolEN.updUserId) == false && (0, clsString_js_2.GetStrLen)(pobjXzSchoolEN.updUserId) > 20) {
            throw new Error("(errid:Watl000059)字段[修改用户Id(updUserId)]的长度不能超过20(In 学校(XzSchool))!值:$(pobjXzSchoolEN.updUserId)(clsXzSchoolBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzSchoolEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjXzSchoolEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 学校(XzSchool))!值:$(pobjXzSchoolEN.memo)(clsXzSchoolBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzSchoolEN.id_School) == false && undefined !== pobjXzSchoolEN.id_School && clsString_js_1.tzDataType.isString(pobjXzSchoolEN.id_School) === false) {
            throw new Error("(errid:Watl000060)字段[学校流水号(id_School)]的值:[$(pobjXzSchoolEN.id_School)], 非法，应该为字符型(In 学校(XzSchool))!(clsXzSchoolBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzSchoolEN.schoolId) == false && undefined !== pobjXzSchoolEN.schoolId && clsString_js_1.tzDataType.isString(pobjXzSchoolEN.schoolId) === false) {
            throw new Error("(errid:Watl000060)字段[学校编号(schoolId)]的值:[$(pobjXzSchoolEN.schoolId)], 非法，应该为字符型(In 学校(XzSchool))!(clsXzSchoolBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzSchoolEN.schoolName) == false && undefined !== pobjXzSchoolEN.schoolName && clsString_js_1.tzDataType.isString(pobjXzSchoolEN.schoolName) === false) {
            throw new Error("(errid:Watl000060)字段[学校名称(schoolName)]的值:[$(pobjXzSchoolEN.schoolName)], 非法，应该为字符型(In 学校(XzSchool))!(clsXzSchoolBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzSchoolEN.schoolENName) == false && undefined !== pobjXzSchoolEN.schoolENName && clsString_js_1.tzDataType.isString(pobjXzSchoolEN.schoolENName) === false) {
            throw new Error("(errid:Watl000060)字段[SchoolENName(schoolENName)]的值:[$(pobjXzSchoolEN.schoolENName)], 非法，应该为字符型(In 学校(XzSchool))!(clsXzSchoolBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzSchoolEN.schoolNameA) == false && undefined !== pobjXzSchoolEN.schoolNameA && clsString_js_1.tzDataType.isString(pobjXzSchoolEN.schoolNameA) === false) {
            throw new Error("(errid:Watl000060)字段[学校简称(schoolNameA)]的值:[$(pobjXzSchoolEN.schoolNameA)], 非法，应该为字符型(In 学校(XzSchool))!(clsXzSchoolBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzSchoolEN.schoolTypeId) == false && undefined !== pobjXzSchoolEN.schoolTypeId && clsString_js_1.tzDataType.isString(pobjXzSchoolEN.schoolTypeId) === false) {
            throw new Error("(errid:Watl000060)字段[学校类型Id(schoolTypeId)]的值:[$(pobjXzSchoolEN.schoolTypeId)], 非法，应该为字符型(In 学校(XzSchool))!(clsXzSchoolBL:CheckPropertyNew)");
        }
        if (null != pobjXzSchoolEN.isCurrentUse && undefined !== pobjXzSchoolEN.isCurrentUse && clsString_js_1.tzDataType.isBoolean(pobjXzSchoolEN.isCurrentUse) === false) {
            throw new Error("(errid:Watl000060)字段[是否当前使用(isCurrentUse)]的值:[$(pobjXzSchoolEN.isCurrentUse)], 非法，应该为布尔型(In 学校(XzSchool))!(clsXzSchoolBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzSchoolEN.updDate) == false && undefined !== pobjXzSchoolEN.updDate && clsString_js_1.tzDataType.isString(pobjXzSchoolEN.updDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjXzSchoolEN.updDate)], 非法，应该为字符型(In 学校(XzSchool))!(clsXzSchoolBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzSchoolEN.updUserId) == false && undefined !== pobjXzSchoolEN.updUserId && clsString_js_1.tzDataType.isString(pobjXzSchoolEN.updUserId) === false) {
            throw new Error("(errid:Watl000060)字段[修改用户Id(updUserId)]的值:[$(pobjXzSchoolEN.updUserId)], 非法，应该为字符型(In 学校(XzSchool))!(clsXzSchoolBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzSchoolEN.memo) == false && undefined !== pobjXzSchoolEN.memo && clsString_js_1.tzDataType.isString(pobjXzSchoolEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjXzSchoolEN.memo)], 非法，应该为字符型(In 学校(XzSchool))!(clsXzSchoolBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjXzSchoolEN.SetIsCheckProperty(true);
    }
    exports.XzSchool_CheckPropertyNew = XzSchool_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function XzSchool_CheckProperty4Update(pobjXzSchoolEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzSchoolEN.id_School) == false && (0, clsString_js_2.GetStrLen)(pobjXzSchoolEN.id_School) > 4) {
            throw new Error("(errid:Watl000062)字段[学校流水号(id_School)]的长度不能超过4(In 学校(XzSchool))!值:$(pobjXzSchoolEN.id_School)(clsXzSchoolBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzSchoolEN.schoolId) == false && (0, clsString_js_2.GetStrLen)(pobjXzSchoolEN.schoolId) > 10) {
            throw new Error("(errid:Watl000062)字段[学校编号(schoolId)]的长度不能超过10(In 学校(XzSchool))!值:$(pobjXzSchoolEN.schoolId)(clsXzSchoolBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzSchoolEN.schoolName) == false && (0, clsString_js_2.GetStrLen)(pobjXzSchoolEN.schoolName) > 50) {
            throw new Error("(errid:Watl000062)字段[学校名称(schoolName)]的长度不能超过50(In 学校(XzSchool))!值:$(pobjXzSchoolEN.schoolName)(clsXzSchoolBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzSchoolEN.schoolENName) == false && (0, clsString_js_2.GetStrLen)(pobjXzSchoolEN.schoolENName) > 50) {
            throw new Error("(errid:Watl000062)字段[SchoolENName(schoolENName)]的长度不能超过50(In 学校(XzSchool))!值:$(pobjXzSchoolEN.schoolENName)(clsXzSchoolBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzSchoolEN.schoolNameA) == false && (0, clsString_js_2.GetStrLen)(pobjXzSchoolEN.schoolNameA) > 14) {
            throw new Error("(errid:Watl000062)字段[学校简称(schoolNameA)]的长度不能超过14(In 学校(XzSchool))!值:$(pobjXzSchoolEN.schoolNameA)(clsXzSchoolBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzSchoolEN.schoolTypeId) == false && (0, clsString_js_2.GetStrLen)(pobjXzSchoolEN.schoolTypeId) > 2) {
            throw new Error("(errid:Watl000062)字段[学校类型Id(schoolTypeId)]的长度不能超过2(In 学校(XzSchool))!值:$(pobjXzSchoolEN.schoolTypeId)(clsXzSchoolBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzSchoolEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjXzSchoolEN.updDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 学校(XzSchool))!值:$(pobjXzSchoolEN.updDate)(clsXzSchoolBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzSchoolEN.updUserId) == false && (0, clsString_js_2.GetStrLen)(pobjXzSchoolEN.updUserId) > 20) {
            throw new Error("(errid:Watl000062)字段[修改用户Id(updUserId)]的长度不能超过20(In 学校(XzSchool))!值:$(pobjXzSchoolEN.updUserId)(clsXzSchoolBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzSchoolEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjXzSchoolEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 学校(XzSchool))!值:$(pobjXzSchoolEN.memo)(clsXzSchoolBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzSchoolEN.id_School) == false && undefined !== pobjXzSchoolEN.id_School && clsString_js_1.tzDataType.isString(pobjXzSchoolEN.id_School) === false) {
            throw new Error("(errid:Watl000063)字段[学校流水号(id_School)]的值:[$(pobjXzSchoolEN.id_School)], 非法，应该为字符型(In 学校(XzSchool))!(clsXzSchoolBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzSchoolEN.schoolId) == false && undefined !== pobjXzSchoolEN.schoolId && clsString_js_1.tzDataType.isString(pobjXzSchoolEN.schoolId) === false) {
            throw new Error("(errid:Watl000063)字段[学校编号(schoolId)]的值:[$(pobjXzSchoolEN.schoolId)], 非法，应该为字符型(In 学校(XzSchool))!(clsXzSchoolBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzSchoolEN.schoolName) == false && undefined !== pobjXzSchoolEN.schoolName && clsString_js_1.tzDataType.isString(pobjXzSchoolEN.schoolName) === false) {
            throw new Error("(errid:Watl000063)字段[学校名称(schoolName)]的值:[$(pobjXzSchoolEN.schoolName)], 非法，应该为字符型(In 学校(XzSchool))!(clsXzSchoolBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzSchoolEN.schoolENName) == false && undefined !== pobjXzSchoolEN.schoolENName && clsString_js_1.tzDataType.isString(pobjXzSchoolEN.schoolENName) === false) {
            throw new Error("(errid:Watl000063)字段[SchoolENName(schoolENName)]的值:[$(pobjXzSchoolEN.schoolENName)], 非法，应该为字符型(In 学校(XzSchool))!(clsXzSchoolBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzSchoolEN.schoolNameA) == false && undefined !== pobjXzSchoolEN.schoolNameA && clsString_js_1.tzDataType.isString(pobjXzSchoolEN.schoolNameA) === false) {
            throw new Error("(errid:Watl000063)字段[学校简称(schoolNameA)]的值:[$(pobjXzSchoolEN.schoolNameA)], 非法，应该为字符型(In 学校(XzSchool))!(clsXzSchoolBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzSchoolEN.schoolTypeId) == false && undefined !== pobjXzSchoolEN.schoolTypeId && clsString_js_1.tzDataType.isString(pobjXzSchoolEN.schoolTypeId) === false) {
            throw new Error("(errid:Watl000063)字段[学校类型Id(schoolTypeId)]的值:[$(pobjXzSchoolEN.schoolTypeId)], 非法，应该为字符型(In 学校(XzSchool))!(clsXzSchoolBL:CheckProperty4Update)");
        }
        if (null != pobjXzSchoolEN.isCurrentUse && undefined !== pobjXzSchoolEN.isCurrentUse && clsString_js_1.tzDataType.isBoolean(pobjXzSchoolEN.isCurrentUse) === false) {
            throw new Error("(errid:Watl000063)字段[是否当前使用(isCurrentUse)]的值:[$(pobjXzSchoolEN.isCurrentUse)], 非法，应该为布尔型(In 学校(XzSchool))!(clsXzSchoolBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzSchoolEN.updDate) == false && undefined !== pobjXzSchoolEN.updDate && clsString_js_1.tzDataType.isString(pobjXzSchoolEN.updDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjXzSchoolEN.updDate)], 非法，应该为字符型(In 学校(XzSchool))!(clsXzSchoolBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzSchoolEN.updUserId) == false && undefined !== pobjXzSchoolEN.updUserId && clsString_js_1.tzDataType.isString(pobjXzSchoolEN.updUserId) === false) {
            throw new Error("(errid:Watl000063)字段[修改用户Id(updUserId)]的值:[$(pobjXzSchoolEN.updUserId)], 非法，应该为字符型(In 学校(XzSchool))!(clsXzSchoolBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzSchoolEN.memo) == false && undefined !== pobjXzSchoolEN.memo && clsString_js_1.tzDataType.isString(pobjXzSchoolEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjXzSchoolEN.memo)], 非法，应该为字符型(In 学校(XzSchool))!(clsXzSchoolBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzSchoolEN.id_School) === true
            || pobjXzSchoolEN.id_School.toString() === "0") {
            throw new Error("(errid:Watl000064)字段[学校流水号]不能为空(In 学校)!(clsXzSchoolBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjXzSchoolEN.SetIsCheckProperty(true);
    }
    exports.XzSchool_CheckProperty4Update = XzSchool_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-03-14
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function XzSchool_GetJSONStrByObj(pobjXzSchoolEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjXzSchoolEN.sf_UpdFldSetStr = pobjXzSchoolEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjXzSchoolEN);
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
    exports.XzSchool_GetJSONStrByObj = XzSchool_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-14
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function XzSchool_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrXzSchoolObjLst = new Array();
        if (strJSON === "") {
            return arrXzSchoolObjLst;
        }
        try {
            arrXzSchoolObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrXzSchoolObjLst;
        }
        return arrXzSchoolObjLst;
    }
    exports.XzSchool_GetObjLstByJSONStr = XzSchool_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-14
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrXzSchoolObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function XzSchool_GetObjLstByJSONObjLst(arrXzSchoolObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrXzSchoolObjLst = new Array();
        for (const objInFor of arrXzSchoolObjLstS) {
            const obj1 = XzSchool_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrXzSchoolObjLst.push(obj1);
        }
        return arrXzSchoolObjLst;
    }
    exports.XzSchool_GetObjLstByJSONObjLst = XzSchool_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-14
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function XzSchool_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjXzSchoolEN = new clsXzSchoolEN_js_1.clsXzSchoolEN();
        if (strJSON === "") {
            return pobjXzSchoolEN;
        }
        try {
            pobjXzSchoolEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjXzSchoolEN;
        }
        return pobjXzSchoolEN;
    }
    exports.XzSchool_GetObjByJSONStr = XzSchool_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function XzSchool_GetCombineCondition(objXzSchool_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objXzSchool_Cond.dicFldComparisonOp, clsXzSchoolEN_js_1.clsXzSchoolEN.con_id_School) == true) {
            const strComparisonOp_id_School = objXzSchool_Cond.dicFldComparisonOp[clsXzSchoolEN_js_1.clsXzSchoolEN.con_id_School];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsXzSchoolEN_js_1.clsXzSchoolEN.con_id_School, objXzSchool_Cond.id_School, strComparisonOp_id_School);
        }
        if (Object.prototype.hasOwnProperty.call(objXzSchool_Cond.dicFldComparisonOp, clsXzSchoolEN_js_1.clsXzSchoolEN.con_SchoolId) == true) {
            const strComparisonOp_SchoolId = objXzSchool_Cond.dicFldComparisonOp[clsXzSchoolEN_js_1.clsXzSchoolEN.con_SchoolId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsXzSchoolEN_js_1.clsXzSchoolEN.con_SchoolId, objXzSchool_Cond.schoolId, strComparisonOp_SchoolId);
        }
        if (Object.prototype.hasOwnProperty.call(objXzSchool_Cond.dicFldComparisonOp, clsXzSchoolEN_js_1.clsXzSchoolEN.con_SchoolName) == true) {
            const strComparisonOp_SchoolName = objXzSchool_Cond.dicFldComparisonOp[clsXzSchoolEN_js_1.clsXzSchoolEN.con_SchoolName];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsXzSchoolEN_js_1.clsXzSchoolEN.con_SchoolName, objXzSchool_Cond.schoolName, strComparisonOp_SchoolName);
        }
        if (Object.prototype.hasOwnProperty.call(objXzSchool_Cond.dicFldComparisonOp, clsXzSchoolEN_js_1.clsXzSchoolEN.con_SchoolENName) == true) {
            const strComparisonOp_SchoolENName = objXzSchool_Cond.dicFldComparisonOp[clsXzSchoolEN_js_1.clsXzSchoolEN.con_SchoolENName];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsXzSchoolEN_js_1.clsXzSchoolEN.con_SchoolENName, objXzSchool_Cond.schoolENName, strComparisonOp_SchoolENName);
        }
        if (Object.prototype.hasOwnProperty.call(objXzSchool_Cond.dicFldComparisonOp, clsXzSchoolEN_js_1.clsXzSchoolEN.con_SchoolNameA) == true) {
            const strComparisonOp_SchoolNameA = objXzSchool_Cond.dicFldComparisonOp[clsXzSchoolEN_js_1.clsXzSchoolEN.con_SchoolNameA];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsXzSchoolEN_js_1.clsXzSchoolEN.con_SchoolNameA, objXzSchool_Cond.schoolNameA, strComparisonOp_SchoolNameA);
        }
        if (Object.prototype.hasOwnProperty.call(objXzSchool_Cond.dicFldComparisonOp, clsXzSchoolEN_js_1.clsXzSchoolEN.con_SchoolTypeId) == true) {
            const strComparisonOp_SchoolTypeId = objXzSchool_Cond.dicFldComparisonOp[clsXzSchoolEN_js_1.clsXzSchoolEN.con_SchoolTypeId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsXzSchoolEN_js_1.clsXzSchoolEN.con_SchoolTypeId, objXzSchool_Cond.schoolTypeId, strComparisonOp_SchoolTypeId);
        }
        if (Object.prototype.hasOwnProperty.call(objXzSchool_Cond.dicFldComparisonOp, clsXzSchoolEN_js_1.clsXzSchoolEN.con_IsCurrentUse) == true) {
            if (objXzSchool_Cond.isCurrentUse == true) {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '1'", clsXzSchoolEN_js_1.clsXzSchoolEN.con_IsCurrentUse);
            }
            else {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '0'", clsXzSchoolEN_js_1.clsXzSchoolEN.con_IsCurrentUse);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objXzSchool_Cond.dicFldComparisonOp, clsXzSchoolEN_js_1.clsXzSchoolEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objXzSchool_Cond.dicFldComparisonOp[clsXzSchoolEN_js_1.clsXzSchoolEN.con_UpdDate];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsXzSchoolEN_js_1.clsXzSchoolEN.con_UpdDate, objXzSchool_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objXzSchool_Cond.dicFldComparisonOp, clsXzSchoolEN_js_1.clsXzSchoolEN.con_UpdUserId) == true) {
            const strComparisonOp_UpdUserId = objXzSchool_Cond.dicFldComparisonOp[clsXzSchoolEN_js_1.clsXzSchoolEN.con_UpdUserId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsXzSchoolEN_js_1.clsXzSchoolEN.con_UpdUserId, objXzSchool_Cond.updUserId, strComparisonOp_UpdUserId);
        }
        if (Object.prototype.hasOwnProperty.call(objXzSchool_Cond.dicFldComparisonOp, clsXzSchoolEN_js_1.clsXzSchoolEN.con_Memo) == true) {
            const strComparisonOp_Memo = objXzSchool_Cond.dicFldComparisonOp[clsXzSchoolEN_js_1.clsXzSchoolEN.con_Memo];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsXzSchoolEN_js_1.clsXzSchoolEN.con_Memo, objXzSchool_Cond.memo, strComparisonOp_Memo);
        }
        return strWhereCond;
    }
    exports.XzSchool_GetCombineCondition = XzSchool_GetCombineCondition;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objXzSchoolENS:源对象
     * @param objXzSchoolENT:目标对象
    */
    function XzSchool_CopyObjTo(objXzSchoolENS, objXzSchoolENT) {
        objXzSchoolENT.id_School = objXzSchoolENS.id_School; //学校流水号
        objXzSchoolENT.schoolId = objXzSchoolENS.schoolId; //学校编号
        objXzSchoolENT.schoolName = objXzSchoolENS.schoolName; //学校名称
        objXzSchoolENT.schoolENName = objXzSchoolENS.schoolENName; //SchoolENName
        objXzSchoolENT.schoolNameA = objXzSchoolENS.schoolNameA; //学校简称
        objXzSchoolENT.schoolTypeId = objXzSchoolENS.schoolTypeId; //学校类型Id
        objXzSchoolENT.isCurrentUse = objXzSchoolENS.isCurrentUse; //是否当前使用
        objXzSchoolENT.updDate = objXzSchoolENS.updDate; //修改日期
        objXzSchoolENT.updUserId = objXzSchoolENS.updUserId; //修改用户Id
        objXzSchoolENT.memo = objXzSchoolENS.memo; //备注
        objXzSchoolENT.sf_UpdFldSetStr = objXzSchoolENS.updFldString; //sf_UpdFldSetStr
    }
    exports.XzSchool_CopyObjTo = XzSchool_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objXzSchoolENS:源对象
     * @param objXzSchoolENT:目标对象
    */
    function XzSchool_GetObjFromJsonObj(objXzSchoolENS) {
        const objXzSchoolENT = new clsXzSchoolEN_js_1.clsXzSchoolEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objXzSchoolENT, objXzSchoolENS);
        return objXzSchoolENT;
    }
    exports.XzSchool_GetObjFromJsonObj = XzSchool_GetObjFromJsonObj;
});
