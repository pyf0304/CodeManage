/**
* 类名:clsXzAdminClsWApi
* 表名:XzAdminCls(01120194)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/13 00:52:37
* 生成者:pyf
* 生成服务器IP:
工程名称:问卷调查(0112)
CM工程:研究生论文学习(变量首字母小写)-全部函数集
* 相关数据库:103.116.76.183,9433EduHigh_Jsie
* PrjDataBaseId:0170
模块中文名:人员管理(PeopleManage)
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
        define(["require", "exports", "axios", "../../PubFun/enumComparisonOp.js", "../../PubFun/CacheHelper.js", "../../L0_Entity/PeopleManage/clsXzAdminClsEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.XzAdminCls_GetObjFromJsonObj = exports.XzAdminCls_CopyObjTo = exports.XzAdminCls_GetUniCondStr4Update_AdminClsName = exports.XzAdminCls_GetUniCondStr_AdminClsName = exports.XzAdminCls_GetCombineCondition = exports.XzAdminCls_GetObjByJSONStr = exports.XzAdminCls_GetObjLstByJSONObjLst = exports.XzAdminCls_GetObjLstByJSONStr = exports.XzAdminCls_GetJSONStrByObj = exports.XzAdminCls_CheckProperty4Update = exports.XzAdminCls_CheckPropertyNew = exports.XzAdminCls_BindDdl_id_AdminClsInDiv_Cache = exports.XzAdminCls_ReFreshThisCache = exports.XzAdminCls_ReFreshCache = exports.XzAdminCls_GetWebApiUrl = exports.XzAdminCls_GetMaxStrIdByPrefix = exports.XzAdminCls_GetMaxStrIdAsync = exports.XzAdminCls_GetRecCountByCond_Cache = exports.XzAdminCls_GetRecCountByCondAsync = exports.XzAdminCls_IsExistAsync = exports.XzAdminCls_IsExist_Cache = exports.XzAdminCls_IsExist = exports.XzAdminCls_IsExistRecordAsync = exports.XzAdminCls_IsExistRecord_Cache = exports.XzAdminCls_UpdateWithConditionAsync = exports.XzAdminCls_UpdateRecordAsync = exports.XzAdminCls_AddNewRecordWithReturnKey = exports.XzAdminCls_AddNewRecordWithReturnKeyAsync = exports.XzAdminCls_AddNewRecordWithMaxIdAsync = exports.XzAdminCls_AddNewRecordAsync = exports.XzAdminCls_DelXzAdminClssByCondAsync = exports.XzAdminCls_DelXzAdminClssAsync = exports.XzAdminCls_DelRecordAsync = exports.XzAdminCls_GetObjLstByPagerAsync = exports.XzAdminCls_GetObjLstByPager_Cache = exports.XzAdminCls_GetObjLstByRange = exports.XzAdminCls_GetObjLstByRangeAsync = exports.XzAdminCls_GetTopObjLstAsync = exports.XzAdminCls_GetObjLstByid_AdminClsLst_Cache = exports.XzAdminCls_GetObjLstByid_AdminClsLstAsync = exports.XzAdminCls_GetSubObjLst_Cache = exports.XzAdminCls_GetObjLst_PureCache = exports.XzAdminCls_GetObjLst_Cache = exports.XzAdminCls_GetObjLst_sessionStorage_PureCache = exports.XzAdminCls_GetObjLst_sessionStorage = exports.XzAdminCls_GetObjLstAsync = exports.XzAdminCls_GetObjLst_localStorage_PureCache = exports.XzAdminCls_GetObjLst_localStorage = exports.XzAdminCls_GetObjLst_ClientCache = exports.XzAdminCls_GetFirstObjAsync = exports.XzAdminCls_GetFirstID = exports.XzAdminCls_GetFirstIDAsync = exports.XzAdminCls_funcKey = exports.XzAdminCls_FilterFunByKey = exports.XzAdminCls_SortFunByKey = exports.XzAdminCls_SortFun_Defa_2Fld = exports.XzAdminCls_SortFun_Defa = exports.XzAdminCls_func = exports.XzAdminCls_GetNameByid_AdminCls_Cache = exports.XzAdminCls_UpdateObjInLst_Cache = exports.XzAdminCls_GetObjByid_AdminCls_localStorage = exports.XzAdminCls_GetObjByid_AdminCls_Cache = exports.XzAdminCls_GetObjByid_AdminClsAsync = exports.xzAdminCls_ConstructorName = exports.xzAdminCls_Controller = void 0;
    /**
     * 行政班(XzAdminCls)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月13日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const enumComparisonOp_js_1 = require("../../PubFun/enumComparisonOp.js");
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsXzAdminClsEN_js_1 = require("../../L0_Entity/PeopleManage/clsXzAdminClsEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsString_js_2 = require("../../PubFun/clsString.js");
    exports.xzAdminCls_Controller = "XzAdminClsApi";
    exports.xzAdminCls_ConstructorName = "xzAdminCls";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strid_AdminCls:关键字
    * @returns 对象
    **/
    async function XzAdminCls_GetObjByid_AdminClsAsync(strid_AdminCls) {
        const strThisFuncName = "GetObjByid_AdminClsAsync";
        if ((0, clsString_js_2.IsNullOrEmpty)(strid_AdminCls) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strid_AdminCls]不能为空！(In clsXzAdminClsWApi.GetObjByid_AdminClsAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_AdminCls.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strid_AdminCls]的长度:[{0}]不正确！(clsXzAdminClsWApi.GetObjByid_AdminClsAsync)", strid_AdminCls.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByid_AdminCls";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzAdminCls_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "strid_AdminCls": strid_AdminCls,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    return null;
                }
                //console.log(returnObj);
                const objXzAdminCls = XzAdminCls_GetObjFromJsonObj(returnObj);
                return objXzAdminCls;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzAdminCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzAdminCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzAdminCls_GetObjByid_AdminClsAsync = XzAdminCls_GetObjByid_AdminClsAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param strid_AdminCls:所给的关键字
     * @returns 对象
    */
    async function XzAdminCls_GetObjByid_AdminCls_Cache(strid_AdminCls, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByid_AdminCls_Cache";
        if ((0, clsString_js_2.IsNullOrEmpty)(strid_AdminCls) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strid_AdminCls]不能为空！(In clsXzAdminClsWApi.GetObjByid_AdminCls_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_AdminCls.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strid_AdminCls]的长度:[{0}]不正确！(clsXzAdminClsWApi.GetObjByid_AdminCls_Cache)", strid_AdminCls.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrXzAdminClsObjLst_Cache = await XzAdminCls_GetObjLst_Cache();
        try {
            const arrXzAdminCls_Sel = arrXzAdminClsObjLst_Cache.filter(x => x.id_AdminCls == strid_AdminCls);
            let objXzAdminCls;
            if (arrXzAdminCls_Sel.length > 0) {
                objXzAdminCls = arrXzAdminCls_Sel[0];
                return objXzAdminCls;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    const objXzAdminCls_Const = await XzAdminCls_GetObjByid_AdminClsAsync(strid_AdminCls);
                    if (objXzAdminCls_Const != null) {
                        XzAdminCls_ReFreshThisCache();
                        return objXzAdminCls_Const;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strid_AdminCls, exports.xzAdminCls_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.XzAdminCls_GetObjByid_AdminCls_Cache = XzAdminCls_GetObjByid_AdminCls_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param strid_AdminCls:所给的关键字
     * @returns 对象
    */
    async function XzAdminCls_GetObjByid_AdminCls_localStorage(strid_AdminCls) {
        const strThisFuncName = "GetObjByid_AdminCls_localStorage";
        if ((0, clsString_js_2.IsNullOrEmpty)(strid_AdminCls) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strid_AdminCls]不能为空！(In clsXzAdminClsWApi.GetObjByid_AdminCls_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_AdminCls.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strid_AdminCls]的长度:[{0}]不正确！(clsXzAdminClsWApi.GetObjByid_AdminCls_localStorage)", strid_AdminCls.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsXzAdminClsEN_js_1.clsXzAdminClsEN._CurrTabName, strid_AdminCls);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objXzAdminCls_Cache = JSON.parse(strTempObj);
            return objXzAdminCls_Cache;
        }
        try {
            const objXzAdminCls = await XzAdminCls_GetObjByid_AdminClsAsync(strid_AdminCls);
            if (objXzAdminCls != null) {
                localStorage.setItem(strKey, JSON.stringify(objXzAdminCls));
                const strInfo = (0, clsString_js_2.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objXzAdminCls;
            }
            return objXzAdminCls;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strid_AdminCls, exports.xzAdminCls_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.XzAdminCls_GetObjByid_AdminCls_localStorage = XzAdminCls_GetObjByid_AdminCls_localStorage;
    /**
     * 修改在缓存对象列表中的对象, 与后台数据库无关.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
     * @param objXzAdminCls:所给的对象
     * @returns 对象
    */
    async function XzAdminCls_UpdateObjInLst_Cache(objXzAdminCls) {
        const strThisFuncName = "UpdateObjInLst_Cache";
        try {
            const arrXzAdminClsObjLst_Cache = await XzAdminCls_GetObjLst_Cache();
            const obj = arrXzAdminClsObjLst_Cache.find(x => x.adminClsName == objXzAdminCls.adminClsName);
            if (obj != null) {
                objXzAdminCls.id_AdminCls = obj.id_AdminCls;
                (0, clsCommFunc4Web_js_1.ObjectAssign)(obj, objXzAdminCls);
            }
            else {
                arrXzAdminClsObjLst_Cache.push(objXzAdminCls);
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, exports.xzAdminCls_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.XzAdminCls_UpdateObjInLst_Cache = XzAdminCls_UpdateObjInLst_Cache;
    /**
     * 根据关键字获取相关对象的名称属性, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetNameByKeyId_Cache)
     * @param strid_AdminCls:所给的关键字
     * @returns 对象
    */
    async function XzAdminCls_GetNameByid_AdminCls_Cache(strid_AdminCls) {
        const strThisFuncName = "GetNameByid_AdminCls_Cache";
        if ((0, clsString_js_2.IsNullOrEmpty)(strid_AdminCls) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strid_AdminCls]不能为空！(In clsXzAdminClsWApi.GetNameByid_AdminCls_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_AdminCls.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strid_AdminCls]的长度:[{0}]不正确！(clsXzAdminClsWApi.GetNameByid_AdminCls_Cache)", strid_AdminCls.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrXzAdminClsObjLst_Cache = await XzAdminCls_GetObjLst_Cache();
        if (arrXzAdminClsObjLst_Cache == null)
            return "";
        try {
            const arrXzAdminCls_Sel = arrXzAdminClsObjLst_Cache.filter(x => x.id_AdminCls == strid_AdminCls);
            let objXzAdminCls;
            if (arrXzAdminCls_Sel.length > 0) {
                objXzAdminCls = arrXzAdminCls_Sel[0];
                return objXzAdminCls.adminClsName;
            }
            else {
                return "";
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象名称属性不成功!", e, strid_AdminCls);
            console.error(strMsg);
            alert(strMsg);
        }
        return "";
    }
    exports.XzAdminCls_GetNameByid_AdminCls_Cache = XzAdminCls_GetNameByid_AdminCls_Cache;
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
    async function XzAdminCls_func(strInFldName, strOutFldName, strInValue) {
        //const strThisFuncName = "func";
        if (strInFldName != clsXzAdminClsEN_js_1.clsXzAdminClsEN.con_id_AdminCls) {
            const strMsg = (0, clsString_js_2.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsXzAdminClsEN_js_1.clsXzAdminClsEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_2.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strOutFldName, clsXzAdminClsEN_js_1.clsXzAdminClsEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strid_AdminCls = strInValue;
        if ((0, clsString_js_2.IsNullOrEmpty)(strInValue) == true) {
            return "";
        }
        const objXzAdminCls = await XzAdminCls_GetObjByid_AdminCls_Cache(strid_AdminCls);
        if (objXzAdminCls == null)
            return "";
        if (objXzAdminCls.GetFldValue(strOutFldName) == null)
            return "";
        return objXzAdminCls.GetFldValue(strOutFldName).toString();
    }
    exports.XzAdminCls_func = XzAdminCls_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function XzAdminCls_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.id_AdminCls.localeCompare(b.id_AdminCls);
    }
    exports.XzAdminCls_SortFun_Defa = XzAdminCls_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function XzAdminCls_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.adminClsName == b.adminClsName)
            return a.id_XzMajor.localeCompare(b.id_XzMajor);
        else
            return a.adminClsName.localeCompare(b.adminClsName);
    }
    exports.XzAdminCls_SortFun_Defa_2Fld = XzAdminCls_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function XzAdminCls_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsXzAdminClsEN_js_1.clsXzAdminClsEN.con_id_AdminCls:
                    return (a, b) => {
                        return a.id_AdminCls.localeCompare(b.id_AdminCls);
                    };
                case clsXzAdminClsEN_js_1.clsXzAdminClsEN.con_AdminClsName:
                    return (a, b) => {
                        if (a.adminClsName == null)
                            return -1;
                        if (b.adminClsName == null)
                            return 1;
                        return a.adminClsName.localeCompare(b.adminClsName);
                    };
                case clsXzAdminClsEN_js_1.clsXzAdminClsEN.con_id_XzMajor:
                    return (a, b) => {
                        return a.id_XzMajor.localeCompare(b.id_XzMajor);
                    };
                case clsXzAdminClsEN_js_1.clsXzAdminClsEN.con_id_XzCollege:
                    return (a, b) => {
                        return a.id_XzCollege.localeCompare(b.id_XzCollege);
                    };
                case clsXzAdminClsEN_js_1.clsXzAdminClsEN.con_id_UniZone:
                    return (a, b) => {
                        if (a.id_UniZone == null)
                            return -1;
                        if (b.id_UniZone == null)
                            return 1;
                        return a.id_UniZone.localeCompare(b.id_UniZone);
                    };
                case clsXzAdminClsEN_js_1.clsXzAdminClsEN.con_CurrentStuQty:
                    return (a, b) => {
                        return a.currentStuQty - b.currentStuQty;
                    };
                case clsXzAdminClsEN_js_1.clsXzAdminClsEN.con_id_GradeBase:
                    return (a, b) => {
                        return a.id_GradeBase.localeCompare(b.id_GradeBase);
                    };
                case clsXzAdminClsEN_js_1.clsXzAdminClsEN.con_AdminClsId:
                    return (a, b) => {
                        if (a.adminClsId == null)
                            return -1;
                        if (b.adminClsId == null)
                            return 1;
                        return a.adminClsId.localeCompare(b.adminClsId);
                    };
                case clsXzAdminClsEN_js_1.clsXzAdminClsEN.con_id_AdminClsType:
                    return (a, b) => {
                        if (a.id_AdminClsType == null)
                            return -1;
                        if (b.id_AdminClsType == null)
                            return 1;
                        return a.id_AdminClsType.localeCompare(b.id_AdminClsType);
                    };
                case clsXzAdminClsEN_js_1.clsXzAdminClsEN.con_AdminClsIndex:
                    return (a, b) => {
                        return a.adminClsIndex - b.adminClsIndex;
                    };
                case clsXzAdminClsEN_js_1.clsXzAdminClsEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                case clsXzAdminClsEN_js_1.clsXzAdminClsEN.con_ModifyUserID:
                    return (a, b) => {
                        if (a.modifyUserID == null)
                            return -1;
                        if (b.modifyUserID == null)
                            return 1;
                        return a.modifyUserID.localeCompare(b.modifyUserID);
                    };
                case clsXzAdminClsEN_js_1.clsXzAdminClsEN.con_ModifyDate:
                    return (a, b) => {
                        if (a.modifyDate == null)
                            return -1;
                        if (b.modifyDate == null)
                            return 1;
                        return a.modifyDate.localeCompare(b.modifyDate);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[XzAdminCls]中不存在！(in ${exports.xzAdminCls_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsXzAdminClsEN_js_1.clsXzAdminClsEN.con_id_AdminCls:
                    return (a, b) => {
                        return b.id_AdminCls.localeCompare(a.id_AdminCls);
                    };
                case clsXzAdminClsEN_js_1.clsXzAdminClsEN.con_AdminClsName:
                    return (a, b) => {
                        if (b.adminClsName == null)
                            return -1;
                        if (a.adminClsName == null)
                            return 1;
                        return b.adminClsName.localeCompare(a.adminClsName);
                    };
                case clsXzAdminClsEN_js_1.clsXzAdminClsEN.con_id_XzMajor:
                    return (a, b) => {
                        return b.id_XzMajor.localeCompare(a.id_XzMajor);
                    };
                case clsXzAdminClsEN_js_1.clsXzAdminClsEN.con_id_XzCollege:
                    return (a, b) => {
                        return b.id_XzCollege.localeCompare(a.id_XzCollege);
                    };
                case clsXzAdminClsEN_js_1.clsXzAdminClsEN.con_id_UniZone:
                    return (a, b) => {
                        if (b.id_UniZone == null)
                            return -1;
                        if (a.id_UniZone == null)
                            return 1;
                        return b.id_UniZone.localeCompare(a.id_UniZone);
                    };
                case clsXzAdminClsEN_js_1.clsXzAdminClsEN.con_CurrentStuQty:
                    return (a, b) => {
                        return b.currentStuQty - a.currentStuQty;
                    };
                case clsXzAdminClsEN_js_1.clsXzAdminClsEN.con_id_GradeBase:
                    return (a, b) => {
                        return b.id_GradeBase.localeCompare(a.id_GradeBase);
                    };
                case clsXzAdminClsEN_js_1.clsXzAdminClsEN.con_AdminClsId:
                    return (a, b) => {
                        if (b.adminClsId == null)
                            return -1;
                        if (a.adminClsId == null)
                            return 1;
                        return b.adminClsId.localeCompare(a.adminClsId);
                    };
                case clsXzAdminClsEN_js_1.clsXzAdminClsEN.con_id_AdminClsType:
                    return (a, b) => {
                        if (b.id_AdminClsType == null)
                            return -1;
                        if (a.id_AdminClsType == null)
                            return 1;
                        return b.id_AdminClsType.localeCompare(a.id_AdminClsType);
                    };
                case clsXzAdminClsEN_js_1.clsXzAdminClsEN.con_AdminClsIndex:
                    return (a, b) => {
                        return b.adminClsIndex - a.adminClsIndex;
                    };
                case clsXzAdminClsEN_js_1.clsXzAdminClsEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                case clsXzAdminClsEN_js_1.clsXzAdminClsEN.con_ModifyUserID:
                    return (a, b) => {
                        if (b.modifyUserID == null)
                            return -1;
                        if (a.modifyUserID == null)
                            return 1;
                        return b.modifyUserID.localeCompare(a.modifyUserID);
                    };
                case clsXzAdminClsEN_js_1.clsXzAdminClsEN.con_ModifyDate:
                    return (a, b) => {
                        if (b.modifyDate == null)
                            return -1;
                        if (a.modifyDate == null)
                            return 1;
                        return b.modifyDate.localeCompare(a.modifyDate);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[XzAdminCls]中不存在！(in ${exports.xzAdminCls_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.XzAdminCls_SortFunByKey = XzAdminCls_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function XzAdminCls_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsXzAdminClsEN_js_1.clsXzAdminClsEN.con_id_AdminCls:
                return (obj) => {
                    return obj.id_AdminCls === value;
                };
            case clsXzAdminClsEN_js_1.clsXzAdminClsEN.con_AdminClsName:
                return (obj) => {
                    return obj.adminClsName === value;
                };
            case clsXzAdminClsEN_js_1.clsXzAdminClsEN.con_id_XzMajor:
                return (obj) => {
                    return obj.id_XzMajor === value;
                };
            case clsXzAdminClsEN_js_1.clsXzAdminClsEN.con_id_XzCollege:
                return (obj) => {
                    return obj.id_XzCollege === value;
                };
            case clsXzAdminClsEN_js_1.clsXzAdminClsEN.con_id_UniZone:
                return (obj) => {
                    return obj.id_UniZone === value;
                };
            case clsXzAdminClsEN_js_1.clsXzAdminClsEN.con_CurrentStuQty:
                return (obj) => {
                    return obj.currentStuQty === value;
                };
            case clsXzAdminClsEN_js_1.clsXzAdminClsEN.con_id_GradeBase:
                return (obj) => {
                    return obj.id_GradeBase === value;
                };
            case clsXzAdminClsEN_js_1.clsXzAdminClsEN.con_AdminClsId:
                return (obj) => {
                    return obj.adminClsId === value;
                };
            case clsXzAdminClsEN_js_1.clsXzAdminClsEN.con_id_AdminClsType:
                return (obj) => {
                    return obj.id_AdminClsType === value;
                };
            case clsXzAdminClsEN_js_1.clsXzAdminClsEN.con_AdminClsIndex:
                return (obj) => {
                    return obj.adminClsIndex === value;
                };
            case clsXzAdminClsEN_js_1.clsXzAdminClsEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            case clsXzAdminClsEN_js_1.clsXzAdminClsEN.con_ModifyUserID:
                return (obj) => {
                    return obj.modifyUserID === value;
                };
            case clsXzAdminClsEN_js_1.clsXzAdminClsEN.con_ModifyDate:
                return (obj) => {
                    return obj.modifyDate === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[XzAdminCls]中不存在！(in ${exports.xzAdminCls_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.XzAdminCls_FilterFunByKey = XzAdminCls_FilterFunByKey;
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
    async function XzAdminCls_funcKey(strInFldName, strInValue, strComparisonOp) {
        //const strThisFuncName = "funcKey";
        if (strInFldName == clsXzAdminClsEN_js_1.clsXzAdminClsEN.con_id_AdminCls) {
            const strMsg = (0, clsString_js_2.Format)("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(strInValue) == true) {
            return [];
        }
        const arrXzAdminCls = await XzAdminCls_GetObjLst_Cache();
        if (arrXzAdminCls == null)
            return [];
        let arrXzAdminCls_Sel = arrXzAdminCls;
        const strType = typeof (strInValue);
        switch (strType) {
            case "string":
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01: // " = "
                        arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.Like_03:
                        arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.In_04:
                        const arrValues = strInValue.split(',');
                        arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
                        break;
                }
                break;
            case "boolean":
                if (strInValue == null)
                    return [];
                if (strComparisonOp == enumComparisonOp_js_1.enumComparisonOp.Equal_01) {
                    arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                }
                break;
            case "number":
                if (Number(strInValue) == 0)
                    return [];
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01:
                        arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotEqual_02:
                        arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotLessThan_05: //" >= ":
                        arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotGreaterThan_06: //" <= ":
                        arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.GreaterThan_07: //" > ":
                        arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.LessThan_08: //" < ":
                        arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                }
                break;
        }
        if (arrXzAdminCls_Sel.length == 0)
            return [];
        return arrXzAdminCls_Sel.map(x => x.id_AdminCls);
    }
    exports.XzAdminCls_funcKey = XzAdminCls_funcKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function XzAdminCls_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzAdminCls_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzAdminCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzAdminCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzAdminCls_GetFirstIDAsync = XzAdminCls_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function XzAdminCls_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzAdminCls_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzAdminCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzAdminCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzAdminCls_GetFirstID = XzAdminCls_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function XzAdminCls_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzAdminCls_Controller, strAction);
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
                const objXzAdminCls = XzAdminCls_GetObjFromJsonObj(returnObj);
                return objXzAdminCls;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzAdminCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzAdminCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzAdminCls_GetFirstObjAsync = XzAdminCls_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function XzAdminCls_GetObjLst_ClientCache() {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsXzAdminClsEN_js_1.clsXzAdminClsEN._CurrTabName;
        if ((0, clsString_js_2.IsNullOrEmpty)(clsXzAdminClsEN_js_1.clsXzAdminClsEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsXzAdminClsEN_js_1.clsXzAdminClsEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_1.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrXzAdminClsExObjLst_Cache = CacheHelper_js_1.CacheHelper.Get(strKey);
            const arrXzAdminClsObjLst_T = XzAdminCls_GetObjLstByJSONObjLst(arrXzAdminClsExObjLst_Cache);
            return arrXzAdminClsObjLst_T;
        }
        try {
            const arrXzAdminClsExObjLst = await XzAdminCls_GetObjLstAsync(strWhereCond);
            CacheHelper_js_1.CacheHelper.Add(strKey, arrXzAdminClsExObjLst);
            const strInfo = (0, clsString_js_2.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrXzAdminClsExObjLst.length);
            console.log(strInfo);
            return arrXzAdminClsExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.xzAdminCls_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.XzAdminCls_GetObjLst_ClientCache = XzAdminCls_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function XzAdminCls_GetObjLst_localStorage() {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsXzAdminClsEN_js_1.clsXzAdminClsEN._CurrTabName;
        if ((0, clsString_js_2.IsNullOrEmpty)(clsXzAdminClsEN_js_1.clsXzAdminClsEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsXzAdminClsEN_js_1.clsXzAdminClsEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrXzAdminClsExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrXzAdminClsObjLst_T = XzAdminCls_GetObjLstByJSONObjLst(arrXzAdminClsExObjLst_Cache);
            return arrXzAdminClsObjLst_T;
        }
        try {
            const arrXzAdminClsExObjLst = await XzAdminCls_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrXzAdminClsExObjLst));
            const strInfo = (0, clsString_js_2.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrXzAdminClsExObjLst.length);
            console.log(strInfo);
            return arrXzAdminClsExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.xzAdminCls_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.XzAdminCls_GetObjLst_localStorage = XzAdminCls_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function XzAdminCls_GetObjLst_localStorage_PureCache() {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsXzAdminClsEN_js_1.clsXzAdminClsEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrXzAdminClsObjLst_Cache = JSON.parse(strTempObjLst);
            return arrXzAdminClsObjLst_Cache;
        }
        else
            return null;
    }
    exports.XzAdminCls_GetObjLst_localStorage_PureCache = XzAdminCls_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function XzAdminCls_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzAdminCls_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.xzAdminCls_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = XzAdminCls_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzAdminCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzAdminCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzAdminCls_GetObjLstAsync = XzAdminCls_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function XzAdminCls_GetObjLst_sessionStorage() {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsXzAdminClsEN_js_1.clsXzAdminClsEN._CurrTabName;
        if ((0, clsString_js_2.IsNullOrEmpty)(clsXzAdminClsEN_js_1.clsXzAdminClsEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsXzAdminClsEN_js_1.clsXzAdminClsEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrXzAdminClsExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrXzAdminClsObjLst_T = XzAdminCls_GetObjLstByJSONObjLst(arrXzAdminClsExObjLst_Cache);
            return arrXzAdminClsObjLst_T;
        }
        try {
            const arrXzAdminClsExObjLst = await XzAdminCls_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrXzAdminClsExObjLst));
            const strInfo = (0, clsString_js_2.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrXzAdminClsExObjLst.length);
            console.log(strInfo);
            return arrXzAdminClsExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.xzAdminCls_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.XzAdminCls_GetObjLst_sessionStorage = XzAdminCls_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function XzAdminCls_GetObjLst_sessionStorage_PureCache() {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsXzAdminClsEN_js_1.clsXzAdminClsEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrXzAdminClsObjLst_Cache = JSON.parse(strTempObjLst);
            return arrXzAdminClsObjLst_Cache;
        }
        else
            return null;
    }
    exports.XzAdminCls_GetObjLst_sessionStorage_PureCache = XzAdminCls_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function XzAdminCls_GetObjLst_Cache() {
        //const strThisFuncName = "GetObjLst_Cache";
        let arrXzAdminClsObjLst_Cache;
        switch (clsXzAdminClsEN_js_1.clsXzAdminClsEN.CacheModeId) {
            case "04": //sessionStorage
                arrXzAdminClsObjLst_Cache = await XzAdminCls_GetObjLst_sessionStorage();
                break;
            case "03": //localStorage
                arrXzAdminClsObjLst_Cache = await XzAdminCls_GetObjLst_localStorage();
                break;
            case "02": //ClientCache
                arrXzAdminClsObjLst_Cache = await XzAdminCls_GetObjLst_ClientCache();
                break;
            default:
                arrXzAdminClsObjLst_Cache = await XzAdminCls_GetObjLst_ClientCache();
                break;
        }
        const arrXzAdminClsObjLst = XzAdminCls_GetObjLstByJSONObjLst(arrXzAdminClsObjLst_Cache);
        return arrXzAdminClsObjLst_Cache;
    }
    exports.XzAdminCls_GetObjLst_Cache = XzAdminCls_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function XzAdminCls_GetObjLst_PureCache() {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrXzAdminClsObjLst_Cache;
        switch (clsXzAdminClsEN_js_1.clsXzAdminClsEN.CacheModeId) {
            case "04": //sessionStorage
                arrXzAdminClsObjLst_Cache = await XzAdminCls_GetObjLst_sessionStorage_PureCache();
                break;
            case "03": //localStorage
                arrXzAdminClsObjLst_Cache = await XzAdminCls_GetObjLst_localStorage_PureCache();
                break;
            case "02": //ClientCache
                arrXzAdminClsObjLst_Cache = null;
                break;
            default:
                arrXzAdminClsObjLst_Cache = null;
                break;
        }
        return arrXzAdminClsObjLst_Cache;
    }
    exports.XzAdminCls_GetObjLst_PureCache = XzAdminCls_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objstrid_AdminCls_Cond:条件对象
     * @returns 对象列表子集
    */
    async function XzAdminCls_GetSubObjLst_Cache(objXzAdminCls_Cond) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrXzAdminClsObjLst_Cache = await XzAdminCls_GetObjLst_Cache();
        let arrXzAdminCls_Sel = arrXzAdminClsObjLst_Cache;
        if (objXzAdminCls_Cond.sf_FldComparisonOp == null || objXzAdminCls_Cond.sf_FldComparisonOp == "")
            return arrXzAdminCls_Sel;
        const dicFldComparisonOp = JSON.parse(objXzAdminCls_Cond.sf_FldComparisonOp);
        //console.log("clsXzAdminClsWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objXzAdminCls_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objXzAdminCls_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrXzAdminCls_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objXzAdminCls_Cond), exports.xzAdminCls_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.XzAdminCls_GetSubObjLst_Cache = XzAdminCls_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrid_AdminCls:关键字列表
    * @returns 对象列表
    **/
    async function XzAdminCls_GetObjLstByid_AdminClsLstAsync(arrid_AdminCls) {
        const strThisFuncName = "GetObjLstByid_AdminClsLstAsync";
        const strAction = "GetObjLstByid_AdminClsLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzAdminCls_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrid_AdminCls);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.xzAdminCls_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = XzAdminCls_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzAdminCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzAdminCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzAdminCls_GetObjLstByid_AdminClsLstAsync = XzAdminCls_GetObjLstByid_AdminClsLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrstrid_AdminClsLst:关键字列表
     * @returns 对象列表
    */
    async function XzAdminCls_GetObjLstByid_AdminClsLst_Cache(arrid_AdminClsLst) {
        const strThisFuncName = "GetObjLstByid_AdminClsLst_Cache";
        try {
            const arrXzAdminClsObjLst_Cache = await XzAdminCls_GetObjLst_Cache();
            const arrXzAdminCls_Sel = arrXzAdminClsObjLst_Cache.filter(x => arrid_AdminClsLst.indexOf(x.id_AdminCls) > -1);
            return arrXzAdminCls_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrid_AdminClsLst.join(","), exports.xzAdminCls_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
    }
    exports.XzAdminCls_GetObjLstByid_AdminClsLst_Cache = XzAdminCls_GetObjLstByid_AdminClsLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function XzAdminCls_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzAdminCls_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.xzAdminCls_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = XzAdminCls_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzAdminCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzAdminCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzAdminCls_GetTopObjLstAsync = XzAdminCls_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function XzAdminCls_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzAdminCls_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.xzAdminCls_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = XzAdminCls_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzAdminCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzAdminCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzAdminCls_GetObjLstByRangeAsync = XzAdminCls_GetObjLstByRangeAsync;
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
    async function XzAdminCls_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzAdminCls_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzAdminCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzAdminCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzAdminCls_GetObjLstByRange = XzAdminCls_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function XzAdminCls_GetObjLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const arrXzAdminClsObjLst_Cache = await XzAdminCls_GetObjLst_Cache();
        if (arrXzAdminClsObjLst_Cache.length == 0)
            return arrXzAdminClsObjLst_Cache;
        let arrXzAdminCls_Sel = arrXzAdminClsObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objXzAdminCls_Cond = new clsXzAdminClsEN_js_1.clsXzAdminClsEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objXzAdminCls_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsXzAdminClsWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objXzAdminCls_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrXzAdminCls_Sel.length == 0)
                return arrXzAdminCls_Sel;
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
                arrXzAdminCls_Sel = arrXzAdminCls_Sel.sort(XzAdminCls_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrXzAdminCls_Sel = arrXzAdminCls_Sel.sort(objPagerPara.sortFun);
            }
            arrXzAdminCls_Sel = arrXzAdminCls_Sel.slice(intStart, intEnd);
            return arrXzAdminCls_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.xzAdminCls_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.XzAdminCls_GetObjLstByPager_Cache = XzAdminCls_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function XzAdminCls_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzAdminCls_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.xzAdminCls_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = XzAdminCls_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzAdminCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzAdminCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzAdminCls_GetObjLstByPagerAsync = XzAdminCls_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param strid_AdminCls:关键字
    * @returns 获取删除的结果
    **/
    async function XzAdminCls_DelRecordAsync(strid_AdminCls) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzAdminCls_Controller, strAction);
        strUrl = (0, clsString_js_2.Format)("{0}/?Id={1}", strUrl, strid_AdminCls);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzAdminCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzAdminCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzAdminCls_DelRecordAsync = XzAdminCls_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrid_AdminCls:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function XzAdminCls_DelXzAdminClssAsync(arrid_AdminCls) {
        const strThisFuncName = "DelXzAdminClssAsync";
        const strAction = "DelXzAdminClss";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzAdminCls_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrid_AdminCls);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzAdminCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzAdminCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzAdminCls_DelXzAdminClssAsync = XzAdminCls_DelXzAdminClssAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function XzAdminCls_DelXzAdminClssByCondAsync(strWhereCond) {
        const strThisFuncName = "DelXzAdminClssByCondAsync";
        const strAction = "DelXzAdminClssByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzAdminCls_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzAdminCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzAdminCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzAdminCls_DelXzAdminClssByCondAsync = XzAdminCls_DelXzAdminClssByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objXzAdminClsEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function XzAdminCls_AddNewRecordAsync(objXzAdminClsEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objXzAdminClsEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzAdminCls_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objXzAdminClsEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzAdminCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzAdminCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzAdminCls_AddNewRecordAsync = XzAdminCls_AddNewRecordAsync;
    /**
    * 调用WebApi来添加记录，关键字用最大关键字，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithMaxIdAsync)
    * @param objXzAdminClsEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function XzAdminCls_AddNewRecordWithMaxIdAsync(objXzAdminClsEN) {
        const strThisFuncName = "AddNewRecordWithMaxIdAsync";
        const strAction = "AddNewRecordWithMaxId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzAdminCls_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objXzAdminClsEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzAdminCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzAdminCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzAdminCls_AddNewRecordWithMaxIdAsync = XzAdminCls_AddNewRecordWithMaxIdAsync;
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objXzAdminClsEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function XzAdminCls_AddNewRecordWithReturnKeyAsync(objXzAdminClsEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzAdminCls_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objXzAdminClsEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzAdminCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzAdminCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzAdminCls_AddNewRecordWithReturnKeyAsync = XzAdminCls_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objXzAdminClsEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function XzAdminCls_AddNewRecordWithReturnKey(objXzAdminClsEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objXzAdminClsEN.id_AdminCls === null || objXzAdminClsEN.id_AdminCls === "") {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzAdminCls_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objXzAdminClsEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzAdminCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzAdminCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzAdminCls_AddNewRecordWithReturnKey = XzAdminCls_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objXzAdminClsEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function XzAdminCls_UpdateRecordAsync(objXzAdminClsEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objXzAdminClsEN.sf_UpdFldSetStr === undefined || objXzAdminClsEN.sf_UpdFldSetStr === null || objXzAdminClsEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objXzAdminClsEN.id_AdminCls);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzAdminCls_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objXzAdminClsEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzAdminCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzAdminCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzAdminCls_UpdateRecordAsync = XzAdminCls_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objXzAdminClsEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function XzAdminCls_UpdateWithConditionAsync(objXzAdminClsEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objXzAdminClsEN.sf_UpdFldSetStr === undefined || objXzAdminClsEN.sf_UpdFldSetStr === null || objXzAdminClsEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objXzAdminClsEN.id_AdminCls);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzAdminCls_Controller, strAction);
        objXzAdminClsEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objXzAdminClsEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzAdminCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzAdminCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzAdminCls_UpdateWithConditionAsync = XzAdminCls_UpdateWithConditionAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objstrid_AdminCls_Cond:条件对象
     * @returns 对象列表子集
    */
    async function XzAdminCls_IsExistRecord_Cache(objXzAdminCls_Cond) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrXzAdminClsObjLst_Cache = await XzAdminCls_GetObjLst_Cache();
        if (arrXzAdminClsObjLst_Cache == null)
            return false;
        let arrXzAdminCls_Sel = arrXzAdminClsObjLst_Cache;
        if (objXzAdminCls_Cond.sf_FldComparisonOp == null || objXzAdminCls_Cond.sf_FldComparisonOp == "")
            return arrXzAdminCls_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objXzAdminCls_Cond.sf_FldComparisonOp);
        //console.log("clsXzAdminClsWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objXzAdminCls_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objXzAdminCls_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrXzAdminCls_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objXzAdminCls_Cond), exports.xzAdminCls_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.XzAdminCls_IsExistRecord_Cache = XzAdminCls_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function XzAdminCls_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzAdminCls_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzAdminCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzAdminCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzAdminCls_IsExistRecordAsync = XzAdminCls_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strid_AdminCls:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function XzAdminCls_IsExist(strid_AdminCls, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzAdminCls_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "id_AdminCls": strid_AdminCls,
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzAdminCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzAdminCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzAdminCls_IsExist = XzAdminCls_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param strid_AdminCls:所给的关键字
     * @returns 对象
    */
    async function XzAdminCls_IsExist_Cache(strid_AdminCls) {
        const strThisFuncName = "IsExist_Cache";
        const arrXzAdminClsObjLst_Cache = await XzAdminCls_GetObjLst_Cache();
        if (arrXzAdminClsObjLst_Cache == null)
            return false;
        try {
            const arrXzAdminCls_Sel = arrXzAdminClsObjLst_Cache.filter(x => x.id_AdminCls == strid_AdminCls);
            if (arrXzAdminCls_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strid_AdminCls, exports.xzAdminCls_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.XzAdminCls_IsExist_Cache = XzAdminCls_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strid_AdminCls:关键字
    * @returns 是否存在?存在返回True
    **/
    async function XzAdminCls_IsExistAsync(strid_AdminCls) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzAdminCls_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strid_AdminCls": strid_AdminCls }
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzAdminCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzAdminCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzAdminCls_IsExistAsync = XzAdminCls_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function XzAdminCls_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzAdminCls_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzAdminCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzAdminCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzAdminCls_GetRecCountByCondAsync = XzAdminCls_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objXzAdminCls_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function XzAdminCls_GetRecCountByCond_Cache(objXzAdminCls_Cond) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrXzAdminClsObjLst_Cache = await XzAdminCls_GetObjLst_Cache();
        if (arrXzAdminClsObjLst_Cache == null)
            return 0;
        let arrXzAdminCls_Sel = arrXzAdminClsObjLst_Cache;
        if (objXzAdminCls_Cond.sf_FldComparisonOp == null || objXzAdminCls_Cond.sf_FldComparisonOp == "")
            return arrXzAdminCls_Sel.length;
        const dicFldComparisonOp = JSON.parse(objXzAdminCls_Cond.sf_FldComparisonOp);
        //console.log("clsXzAdminClsWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objXzAdminCls_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objXzAdminCls_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrXzAdminCls_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objXzAdminCls_Cond), exports.xzAdminCls_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.XzAdminCls_GetRecCountByCond_Cache = XzAdminCls_GetRecCountByCond_Cache;
    /**
    * 获取表的最大关键字
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdAsync)
    * @returns 获取表的最大关键字
    **/
    async function XzAdminCls_GetMaxStrIdAsync() {
        const strThisFuncName = "GetMaxStrIdAsync";
        const strAction = "GetMaxStrId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzAdminCls_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzAdminCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzAdminCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzAdminCls_GetMaxStrIdAsync = XzAdminCls_GetMaxStrIdAsync;
    /*该表的关键字类型不是字符型带前缀自增，不需要生成获取最大关键字函数！*/
    /**
     * 根据前缀获取当前表关键字值的最大值,再加1,避免重复
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdByPrefix)
     * @param mapParam:参数列表
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 获取当前表关键字值的最大值
    */
    async function XzAdminCls_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzAdminCls_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzAdminCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzAdminCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzAdminCls_GetMaxStrIdByPrefix = XzAdminCls_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function XzAdminCls_GetWebApiUrl(strController, strAction) {
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
    exports.XzAdminCls_GetWebApiUrl = XzAdminCls_GetWebApiUrl;
    /**
    * 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshCache)
    **/
    function XzAdminCls_ReFreshCache() {
        const strThisFuncName = "ReFreshCache";
        const strMsg = (0, clsString_js_2.Format)("刷新缓存成功！");
        console.trace(strMsg);
        // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
        const strKey = clsXzAdminClsEN_js_1.clsXzAdminClsEN._CurrTabName;
        switch (clsXzAdminClsEN_js_1.clsXzAdminClsEN.CacheModeId) {
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
    exports.XzAdminCls_ReFreshCache = XzAdminCls_ReFreshCache;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function XzAdminCls_ReFreshThisCache() {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = clsXzAdminClsEN_js_1.clsXzAdminClsEN._CurrTabName;
            switch (clsXzAdminClsEN_js_1.clsXzAdminClsEN.CacheModeId) {
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
    exports.XzAdminCls_ReFreshThisCache = XzAdminCls_ReFreshThisCache;
    /**
     * 绑定基于Web的下拉框,在某一层下的下拉框
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunctionInDiv)
     * @param objDDL:需要绑定当前表的下拉框
    */
    async function XzAdminCls_BindDdl_id_AdminClsInDiv_Cache(strDivName, strDdlName) {
        const strThisFuncName = "BindDdl_id_AdminClsInDiv_Cache";
        const objDdl = document.getElementById(strDdlName);
        if (objDdl == null) {
            const strMsg = (0, clsString_js_2.Format)("下拉框：{0} 不存在！(In BindDdl_id_AdminClsInDiv)", strDdlName);
            alert(strMsg);
            console.error(strMsg);
            throw (strMsg);
        }
        //为数据源于表的下拉框设置内容
        //console.log("开始：BindDdl_id_AdminClsInDiv_Cache");
        const arrObjLst_Sel = await XzAdminCls_GetObjLst_Cache();
        if (arrObjLst_Sel == null)
            return;
        (0, clsCommFunc4Web_js_1.BindDdl_ObjLstInDiv)(strDivName, strDdlName, arrObjLst_Sel, clsXzAdminClsEN_js_1.clsXzAdminClsEN.con_id_AdminCls, clsXzAdminClsEN_js_1.clsXzAdminClsEN.con_AdminClsName, "行政班");
    }
    exports.XzAdminCls_BindDdl_id_AdminClsInDiv_Cache = XzAdminCls_BindDdl_id_AdminClsInDiv_Cache;
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function XzAdminCls_CheckPropertyNew(pobjXzAdminClsEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzAdminClsEN.id_XzMajor) === true
            || pobjXzAdminClsEN.id_XzMajor.toString() === "0") {
            throw new Error("(errid:Watl000058)字段[专业流水号]不能为空(In 行政班)!(clsXzAdminClsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzAdminClsEN.id_XzCollege) === true
            || pobjXzAdminClsEN.id_XzCollege.toString() === "0") {
            throw new Error("(errid:Watl000058)字段[学院流水号]不能为空(In 行政班)!(clsXzAdminClsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzAdminClsEN.id_GradeBase) === true
            || pobjXzAdminClsEN.id_GradeBase.toString() === "0") {
            throw new Error("(errid:Watl000058)字段[年级流水号]不能为空(In 行政班)!(clsXzAdminClsBL:CheckPropertyNew)");
        }
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzAdminClsEN.id_AdminCls) == false && (0, clsString_js_2.GetStrLen)(pobjXzAdminClsEN.id_AdminCls) > 8) {
            throw new Error("(errid:Watl000059)字段[行政班流水号(id_AdminCls)]的长度不能超过8(In 行政班(XzAdminCls))!值:$(pobjXzAdminClsEN.id_AdminCls)(clsXzAdminClsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzAdminClsEN.adminClsName) == false && (0, clsString_js_2.GetStrLen)(pobjXzAdminClsEN.adminClsName) > 100) {
            throw new Error("(errid:Watl000059)字段[行政班名称(adminClsName)]的长度不能超过100(In 行政班(XzAdminCls))!值:$(pobjXzAdminClsEN.adminClsName)(clsXzAdminClsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzAdminClsEN.id_XzMajor) == false && (0, clsString_js_2.GetStrLen)(pobjXzAdminClsEN.id_XzMajor) > 8) {
            throw new Error("(errid:Watl000059)字段[专业流水号(id_XzMajor)]的长度不能超过8(In 行政班(XzAdminCls))!值:$(pobjXzAdminClsEN.id_XzMajor)(clsXzAdminClsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzAdminClsEN.id_XzCollege) == false && (0, clsString_js_2.GetStrLen)(pobjXzAdminClsEN.id_XzCollege) > 4) {
            throw new Error("(errid:Watl000059)字段[学院流水号(id_XzCollege)]的长度不能超过4(In 行政班(XzAdminCls))!值:$(pobjXzAdminClsEN.id_XzCollege)(clsXzAdminClsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzAdminClsEN.id_UniZone) == false && (0, clsString_js_2.GetStrLen)(pobjXzAdminClsEN.id_UniZone) > 4) {
            throw new Error("(errid:Watl000059)字段[校区流水号(id_UniZone)]的长度不能超过4(In 行政班(XzAdminCls))!值:$(pobjXzAdminClsEN.id_UniZone)(clsXzAdminClsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzAdminClsEN.id_GradeBase) == false && (0, clsString_js_2.GetStrLen)(pobjXzAdminClsEN.id_GradeBase) > 4) {
            throw new Error("(errid:Watl000059)字段[年级流水号(id_GradeBase)]的长度不能超过4(In 行政班(XzAdminCls))!值:$(pobjXzAdminClsEN.id_GradeBase)(clsXzAdminClsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzAdminClsEN.adminClsId) == false && (0, clsString_js_2.GetStrLen)(pobjXzAdminClsEN.adminClsId) > 8) {
            throw new Error("(errid:Watl000059)字段[行政班代号(adminClsId)]的长度不能超过8(In 行政班(XzAdminCls))!值:$(pobjXzAdminClsEN.adminClsId)(clsXzAdminClsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzAdminClsEN.id_AdminClsType) == false && (0, clsString_js_2.GetStrLen)(pobjXzAdminClsEN.id_AdminClsType) > 4) {
            throw new Error("(errid:Watl000059)字段[行政班级类型流水号(id_AdminClsType)]的长度不能超过4(In 行政班(XzAdminCls))!值:$(pobjXzAdminClsEN.id_AdminClsType)(clsXzAdminClsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzAdminClsEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjXzAdminClsEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 行政班(XzAdminCls))!值:$(pobjXzAdminClsEN.memo)(clsXzAdminClsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzAdminClsEN.modifyUserID) == false && (0, clsString_js_2.GetStrLen)(pobjXzAdminClsEN.modifyUserID) > 18) {
            throw new Error("(errid:Watl000059)字段[修改人(modifyUserID)]的长度不能超过18(In 行政班(XzAdminCls))!值:$(pobjXzAdminClsEN.modifyUserID)(clsXzAdminClsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzAdminClsEN.modifyDate) == false && (0, clsString_js_2.GetStrLen)(pobjXzAdminClsEN.modifyDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(modifyDate)]的长度不能超过20(In 行政班(XzAdminCls))!值:$(pobjXzAdminClsEN.modifyDate)(clsXzAdminClsBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzAdminClsEN.id_AdminCls) == false && undefined !== pobjXzAdminClsEN.id_AdminCls && clsString_js_1.tzDataType.isString(pobjXzAdminClsEN.id_AdminCls) === false) {
            throw new Error("(errid:Watl000060)字段[行政班流水号(id_AdminCls)]的值:[$(pobjXzAdminClsEN.id_AdminCls)], 非法，应该为字符型(In 行政班(XzAdminCls))!(clsXzAdminClsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzAdminClsEN.adminClsName) == false && undefined !== pobjXzAdminClsEN.adminClsName && clsString_js_1.tzDataType.isString(pobjXzAdminClsEN.adminClsName) === false) {
            throw new Error("(errid:Watl000060)字段[行政班名称(adminClsName)]的值:[$(pobjXzAdminClsEN.adminClsName)], 非法，应该为字符型(In 行政班(XzAdminCls))!(clsXzAdminClsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzAdminClsEN.id_XzMajor) == false && undefined !== pobjXzAdminClsEN.id_XzMajor && clsString_js_1.tzDataType.isString(pobjXzAdminClsEN.id_XzMajor) === false) {
            throw new Error("(errid:Watl000060)字段[专业流水号(id_XzMajor)]的值:[$(pobjXzAdminClsEN.id_XzMajor)], 非法，应该为字符型(In 行政班(XzAdminCls))!(clsXzAdminClsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzAdminClsEN.id_XzCollege) == false && undefined !== pobjXzAdminClsEN.id_XzCollege && clsString_js_1.tzDataType.isString(pobjXzAdminClsEN.id_XzCollege) === false) {
            throw new Error("(errid:Watl000060)字段[学院流水号(id_XzCollege)]的值:[$(pobjXzAdminClsEN.id_XzCollege)], 非法，应该为字符型(In 行政班(XzAdminCls))!(clsXzAdminClsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzAdminClsEN.id_UniZone) == false && undefined !== pobjXzAdminClsEN.id_UniZone && clsString_js_1.tzDataType.isString(pobjXzAdminClsEN.id_UniZone) === false) {
            throw new Error("(errid:Watl000060)字段[校区流水号(id_UniZone)]的值:[$(pobjXzAdminClsEN.id_UniZone)], 非法，应该为字符型(In 行政班(XzAdminCls))!(clsXzAdminClsBL:CheckPropertyNew)");
        }
        if (null != pobjXzAdminClsEN.currentStuQty && undefined !== pobjXzAdminClsEN.currentStuQty && clsString_js_1.tzDataType.isNumber(pobjXzAdminClsEN.currentStuQty) === false) {
            throw new Error("(errid:Watl000060)字段[当前学生数(currentStuQty)]的值:[$(pobjXzAdminClsEN.currentStuQty)], 非法，应该为数值型(In 行政班(XzAdminCls))!(clsXzAdminClsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzAdminClsEN.id_GradeBase) == false && undefined !== pobjXzAdminClsEN.id_GradeBase && clsString_js_1.tzDataType.isString(pobjXzAdminClsEN.id_GradeBase) === false) {
            throw new Error("(errid:Watl000060)字段[年级流水号(id_GradeBase)]的值:[$(pobjXzAdminClsEN.id_GradeBase)], 非法，应该为字符型(In 行政班(XzAdminCls))!(clsXzAdminClsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzAdminClsEN.adminClsId) == false && undefined !== pobjXzAdminClsEN.adminClsId && clsString_js_1.tzDataType.isString(pobjXzAdminClsEN.adminClsId) === false) {
            throw new Error("(errid:Watl000060)字段[行政班代号(adminClsId)]的值:[$(pobjXzAdminClsEN.adminClsId)], 非法，应该为字符型(In 行政班(XzAdminCls))!(clsXzAdminClsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzAdminClsEN.id_AdminClsType) == false && undefined !== pobjXzAdminClsEN.id_AdminClsType && clsString_js_1.tzDataType.isString(pobjXzAdminClsEN.id_AdminClsType) === false) {
            throw new Error("(errid:Watl000060)字段[行政班级类型流水号(id_AdminClsType)]的值:[$(pobjXzAdminClsEN.id_AdminClsType)], 非法，应该为字符型(In 行政班(XzAdminCls))!(clsXzAdminClsBL:CheckPropertyNew)");
        }
        if (null != pobjXzAdminClsEN.adminClsIndex && undefined !== pobjXzAdminClsEN.adminClsIndex && clsString_js_1.tzDataType.isNumber(pobjXzAdminClsEN.adminClsIndex) === false) {
            throw new Error("(errid:Watl000060)字段[AdminClsIndex(adminClsIndex)]的值:[$(pobjXzAdminClsEN.adminClsIndex)], 非法，应该为数值型(In 行政班(XzAdminCls))!(clsXzAdminClsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzAdminClsEN.memo) == false && undefined !== pobjXzAdminClsEN.memo && clsString_js_1.tzDataType.isString(pobjXzAdminClsEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjXzAdminClsEN.memo)], 非法，应该为字符型(In 行政班(XzAdminCls))!(clsXzAdminClsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzAdminClsEN.modifyUserID) == false && undefined !== pobjXzAdminClsEN.modifyUserID && clsString_js_1.tzDataType.isString(pobjXzAdminClsEN.modifyUserID) === false) {
            throw new Error("(errid:Watl000060)字段[修改人(modifyUserID)]的值:[$(pobjXzAdminClsEN.modifyUserID)], 非法，应该为字符型(In 行政班(XzAdminCls))!(clsXzAdminClsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzAdminClsEN.modifyDate) == false && undefined !== pobjXzAdminClsEN.modifyDate && clsString_js_1.tzDataType.isString(pobjXzAdminClsEN.modifyDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(modifyDate)]的值:[$(pobjXzAdminClsEN.modifyDate)], 非法，应该为字符型(In 行政班(XzAdminCls))!(clsXzAdminClsBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjXzAdminClsEN.SetIsCheckProperty(true);
    }
    exports.XzAdminCls_CheckPropertyNew = XzAdminCls_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function XzAdminCls_CheckProperty4Update(pobjXzAdminClsEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzAdminClsEN.id_AdminCls) == false && (0, clsString_js_2.GetStrLen)(pobjXzAdminClsEN.id_AdminCls) > 8) {
            throw new Error("(errid:Watl000062)字段[行政班流水号(id_AdminCls)]的长度不能超过8(In 行政班(XzAdminCls))!值:$(pobjXzAdminClsEN.id_AdminCls)(clsXzAdminClsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzAdminClsEN.adminClsName) == false && (0, clsString_js_2.GetStrLen)(pobjXzAdminClsEN.adminClsName) > 100) {
            throw new Error("(errid:Watl000062)字段[行政班名称(adminClsName)]的长度不能超过100(In 行政班(XzAdminCls))!值:$(pobjXzAdminClsEN.adminClsName)(clsXzAdminClsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzAdminClsEN.id_XzMajor) == false && (0, clsString_js_2.GetStrLen)(pobjXzAdminClsEN.id_XzMajor) > 8) {
            throw new Error("(errid:Watl000062)字段[专业流水号(id_XzMajor)]的长度不能超过8(In 行政班(XzAdminCls))!值:$(pobjXzAdminClsEN.id_XzMajor)(clsXzAdminClsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzAdminClsEN.id_XzCollege) == false && (0, clsString_js_2.GetStrLen)(pobjXzAdminClsEN.id_XzCollege) > 4) {
            throw new Error("(errid:Watl000062)字段[学院流水号(id_XzCollege)]的长度不能超过4(In 行政班(XzAdminCls))!值:$(pobjXzAdminClsEN.id_XzCollege)(clsXzAdminClsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzAdminClsEN.id_UniZone) == false && (0, clsString_js_2.GetStrLen)(pobjXzAdminClsEN.id_UniZone) > 4) {
            throw new Error("(errid:Watl000062)字段[校区流水号(id_UniZone)]的长度不能超过4(In 行政班(XzAdminCls))!值:$(pobjXzAdminClsEN.id_UniZone)(clsXzAdminClsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzAdminClsEN.id_GradeBase) == false && (0, clsString_js_2.GetStrLen)(pobjXzAdminClsEN.id_GradeBase) > 4) {
            throw new Error("(errid:Watl000062)字段[年级流水号(id_GradeBase)]的长度不能超过4(In 行政班(XzAdminCls))!值:$(pobjXzAdminClsEN.id_GradeBase)(clsXzAdminClsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzAdminClsEN.adminClsId) == false && (0, clsString_js_2.GetStrLen)(pobjXzAdminClsEN.adminClsId) > 8) {
            throw new Error("(errid:Watl000062)字段[行政班代号(adminClsId)]的长度不能超过8(In 行政班(XzAdminCls))!值:$(pobjXzAdminClsEN.adminClsId)(clsXzAdminClsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzAdminClsEN.id_AdminClsType) == false && (0, clsString_js_2.GetStrLen)(pobjXzAdminClsEN.id_AdminClsType) > 4) {
            throw new Error("(errid:Watl000062)字段[行政班级类型流水号(id_AdminClsType)]的长度不能超过4(In 行政班(XzAdminCls))!值:$(pobjXzAdminClsEN.id_AdminClsType)(clsXzAdminClsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzAdminClsEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjXzAdminClsEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 行政班(XzAdminCls))!值:$(pobjXzAdminClsEN.memo)(clsXzAdminClsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzAdminClsEN.modifyUserID) == false && (0, clsString_js_2.GetStrLen)(pobjXzAdminClsEN.modifyUserID) > 18) {
            throw new Error("(errid:Watl000062)字段[修改人(modifyUserID)]的长度不能超过18(In 行政班(XzAdminCls))!值:$(pobjXzAdminClsEN.modifyUserID)(clsXzAdminClsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzAdminClsEN.modifyDate) == false && (0, clsString_js_2.GetStrLen)(pobjXzAdminClsEN.modifyDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(modifyDate)]的长度不能超过20(In 行政班(XzAdminCls))!值:$(pobjXzAdminClsEN.modifyDate)(clsXzAdminClsBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzAdminClsEN.id_AdminCls) == false && undefined !== pobjXzAdminClsEN.id_AdminCls && clsString_js_1.tzDataType.isString(pobjXzAdminClsEN.id_AdminCls) === false) {
            throw new Error("(errid:Watl000063)字段[行政班流水号(id_AdminCls)]的值:[$(pobjXzAdminClsEN.id_AdminCls)], 非法，应该为字符型(In 行政班(XzAdminCls))!(clsXzAdminClsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzAdminClsEN.adminClsName) == false && undefined !== pobjXzAdminClsEN.adminClsName && clsString_js_1.tzDataType.isString(pobjXzAdminClsEN.adminClsName) === false) {
            throw new Error("(errid:Watl000063)字段[行政班名称(adminClsName)]的值:[$(pobjXzAdminClsEN.adminClsName)], 非法，应该为字符型(In 行政班(XzAdminCls))!(clsXzAdminClsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzAdminClsEN.id_XzMajor) == false && undefined !== pobjXzAdminClsEN.id_XzMajor && clsString_js_1.tzDataType.isString(pobjXzAdminClsEN.id_XzMajor) === false) {
            throw new Error("(errid:Watl000063)字段[专业流水号(id_XzMajor)]的值:[$(pobjXzAdminClsEN.id_XzMajor)], 非法，应该为字符型(In 行政班(XzAdminCls))!(clsXzAdminClsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzAdminClsEN.id_XzCollege) == false && undefined !== pobjXzAdminClsEN.id_XzCollege && clsString_js_1.tzDataType.isString(pobjXzAdminClsEN.id_XzCollege) === false) {
            throw new Error("(errid:Watl000063)字段[学院流水号(id_XzCollege)]的值:[$(pobjXzAdminClsEN.id_XzCollege)], 非法，应该为字符型(In 行政班(XzAdminCls))!(clsXzAdminClsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzAdminClsEN.id_UniZone) == false && undefined !== pobjXzAdminClsEN.id_UniZone && clsString_js_1.tzDataType.isString(pobjXzAdminClsEN.id_UniZone) === false) {
            throw new Error("(errid:Watl000063)字段[校区流水号(id_UniZone)]的值:[$(pobjXzAdminClsEN.id_UniZone)], 非法，应该为字符型(In 行政班(XzAdminCls))!(clsXzAdminClsBL:CheckProperty4Update)");
        }
        if (null != pobjXzAdminClsEN.currentStuQty && undefined !== pobjXzAdminClsEN.currentStuQty && clsString_js_1.tzDataType.isNumber(pobjXzAdminClsEN.currentStuQty) === false) {
            throw new Error("(errid:Watl000063)字段[当前学生数(currentStuQty)]的值:[$(pobjXzAdminClsEN.currentStuQty)], 非法，应该为数值型(In 行政班(XzAdminCls))!(clsXzAdminClsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzAdminClsEN.id_GradeBase) == false && undefined !== pobjXzAdminClsEN.id_GradeBase && clsString_js_1.tzDataType.isString(pobjXzAdminClsEN.id_GradeBase) === false) {
            throw new Error("(errid:Watl000063)字段[年级流水号(id_GradeBase)]的值:[$(pobjXzAdminClsEN.id_GradeBase)], 非法，应该为字符型(In 行政班(XzAdminCls))!(clsXzAdminClsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzAdminClsEN.adminClsId) == false && undefined !== pobjXzAdminClsEN.adminClsId && clsString_js_1.tzDataType.isString(pobjXzAdminClsEN.adminClsId) === false) {
            throw new Error("(errid:Watl000063)字段[行政班代号(adminClsId)]的值:[$(pobjXzAdminClsEN.adminClsId)], 非法，应该为字符型(In 行政班(XzAdminCls))!(clsXzAdminClsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzAdminClsEN.id_AdminClsType) == false && undefined !== pobjXzAdminClsEN.id_AdminClsType && clsString_js_1.tzDataType.isString(pobjXzAdminClsEN.id_AdminClsType) === false) {
            throw new Error("(errid:Watl000063)字段[行政班级类型流水号(id_AdminClsType)]的值:[$(pobjXzAdminClsEN.id_AdminClsType)], 非法，应该为字符型(In 行政班(XzAdminCls))!(clsXzAdminClsBL:CheckProperty4Update)");
        }
        if (null != pobjXzAdminClsEN.adminClsIndex && undefined !== pobjXzAdminClsEN.adminClsIndex && clsString_js_1.tzDataType.isNumber(pobjXzAdminClsEN.adminClsIndex) === false) {
            throw new Error("(errid:Watl000063)字段[AdminClsIndex(adminClsIndex)]的值:[$(pobjXzAdminClsEN.adminClsIndex)], 非法，应该为数值型(In 行政班(XzAdminCls))!(clsXzAdminClsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzAdminClsEN.memo) == false && undefined !== pobjXzAdminClsEN.memo && clsString_js_1.tzDataType.isString(pobjXzAdminClsEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjXzAdminClsEN.memo)], 非法，应该为字符型(In 行政班(XzAdminCls))!(clsXzAdminClsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzAdminClsEN.modifyUserID) == false && undefined !== pobjXzAdminClsEN.modifyUserID && clsString_js_1.tzDataType.isString(pobjXzAdminClsEN.modifyUserID) === false) {
            throw new Error("(errid:Watl000063)字段[修改人(modifyUserID)]的值:[$(pobjXzAdminClsEN.modifyUserID)], 非法，应该为字符型(In 行政班(XzAdminCls))!(clsXzAdminClsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzAdminClsEN.modifyDate) == false && undefined !== pobjXzAdminClsEN.modifyDate && clsString_js_1.tzDataType.isString(pobjXzAdminClsEN.modifyDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(modifyDate)]的值:[$(pobjXzAdminClsEN.modifyDate)], 非法，应该为字符型(In 行政班(XzAdminCls))!(clsXzAdminClsBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzAdminClsEN.id_AdminCls) === true
            || pobjXzAdminClsEN.id_AdminCls.toString() === "0") {
            throw new Error("(errid:Watl000064)字段[行政班流水号]不能为空(In 行政班)!(clsXzAdminClsBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjXzAdminClsEN.SetIsCheckProperty(true);
    }
    exports.XzAdminCls_CheckProperty4Update = XzAdminCls_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function XzAdminCls_GetJSONStrByObj(pobjXzAdminClsEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjXzAdminClsEN.sf_UpdFldSetStr = pobjXzAdminClsEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjXzAdminClsEN);
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
    exports.XzAdminCls_GetJSONStrByObj = XzAdminCls_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function XzAdminCls_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrXzAdminClsObjLst = new Array();
        if (strJSON === "") {
            return arrXzAdminClsObjLst;
        }
        try {
            arrXzAdminClsObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrXzAdminClsObjLst;
        }
        return arrXzAdminClsObjLst;
    }
    exports.XzAdminCls_GetObjLstByJSONStr = XzAdminCls_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrXzAdminClsObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function XzAdminCls_GetObjLstByJSONObjLst(arrXzAdminClsObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrXzAdminClsObjLst = new Array();
        for (const objInFor of arrXzAdminClsObjLstS) {
            const obj1 = XzAdminCls_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrXzAdminClsObjLst.push(obj1);
        }
        return arrXzAdminClsObjLst;
    }
    exports.XzAdminCls_GetObjLstByJSONObjLst = XzAdminCls_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function XzAdminCls_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjXzAdminClsEN = new clsXzAdminClsEN_js_1.clsXzAdminClsEN();
        if (strJSON === "") {
            return pobjXzAdminClsEN;
        }
        try {
            pobjXzAdminClsEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjXzAdminClsEN;
        }
        return pobjXzAdminClsEN;
    }
    exports.XzAdminCls_GetObjByJSONStr = XzAdminCls_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function XzAdminCls_GetCombineCondition(objXzAdminCls_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objXzAdminCls_Cond.dicFldComparisonOp, clsXzAdminClsEN_js_1.clsXzAdminClsEN.con_id_AdminCls) == true) {
            const strComparisonOp_id_AdminCls = objXzAdminCls_Cond.dicFldComparisonOp[clsXzAdminClsEN_js_1.clsXzAdminClsEN.con_id_AdminCls];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsXzAdminClsEN_js_1.clsXzAdminClsEN.con_id_AdminCls, objXzAdminCls_Cond.id_AdminCls, strComparisonOp_id_AdminCls);
        }
        if (Object.prototype.hasOwnProperty.call(objXzAdminCls_Cond.dicFldComparisonOp, clsXzAdminClsEN_js_1.clsXzAdminClsEN.con_AdminClsName) == true) {
            const strComparisonOp_AdminClsName = objXzAdminCls_Cond.dicFldComparisonOp[clsXzAdminClsEN_js_1.clsXzAdminClsEN.con_AdminClsName];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsXzAdminClsEN_js_1.clsXzAdminClsEN.con_AdminClsName, objXzAdminCls_Cond.adminClsName, strComparisonOp_AdminClsName);
        }
        if (Object.prototype.hasOwnProperty.call(objXzAdminCls_Cond.dicFldComparisonOp, clsXzAdminClsEN_js_1.clsXzAdminClsEN.con_id_XzMajor) == true) {
            const strComparisonOp_id_XzMajor = objXzAdminCls_Cond.dicFldComparisonOp[clsXzAdminClsEN_js_1.clsXzAdminClsEN.con_id_XzMajor];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsXzAdminClsEN_js_1.clsXzAdminClsEN.con_id_XzMajor, objXzAdminCls_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
        }
        if (Object.prototype.hasOwnProperty.call(objXzAdminCls_Cond.dicFldComparisonOp, clsXzAdminClsEN_js_1.clsXzAdminClsEN.con_id_XzCollege) == true) {
            const strComparisonOp_id_XzCollege = objXzAdminCls_Cond.dicFldComparisonOp[clsXzAdminClsEN_js_1.clsXzAdminClsEN.con_id_XzCollege];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsXzAdminClsEN_js_1.clsXzAdminClsEN.con_id_XzCollege, objXzAdminCls_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
        }
        if (Object.prototype.hasOwnProperty.call(objXzAdminCls_Cond.dicFldComparisonOp, clsXzAdminClsEN_js_1.clsXzAdminClsEN.con_id_UniZone) == true) {
            const strComparisonOp_id_UniZone = objXzAdminCls_Cond.dicFldComparisonOp[clsXzAdminClsEN_js_1.clsXzAdminClsEN.con_id_UniZone];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsXzAdminClsEN_js_1.clsXzAdminClsEN.con_id_UniZone, objXzAdminCls_Cond.id_UniZone, strComparisonOp_id_UniZone);
        }
        if (Object.prototype.hasOwnProperty.call(objXzAdminCls_Cond.dicFldComparisonOp, clsXzAdminClsEN_js_1.clsXzAdminClsEN.con_CurrentStuQty) == true) {
            const strComparisonOp_CurrentStuQty = objXzAdminCls_Cond.dicFldComparisonOp[clsXzAdminClsEN_js_1.clsXzAdminClsEN.con_CurrentStuQty];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsXzAdminClsEN_js_1.clsXzAdminClsEN.con_CurrentStuQty, objXzAdminCls_Cond.currentStuQty, strComparisonOp_CurrentStuQty);
        }
        if (Object.prototype.hasOwnProperty.call(objXzAdminCls_Cond.dicFldComparisonOp, clsXzAdminClsEN_js_1.clsXzAdminClsEN.con_id_GradeBase) == true) {
            const strComparisonOp_id_GradeBase = objXzAdminCls_Cond.dicFldComparisonOp[clsXzAdminClsEN_js_1.clsXzAdminClsEN.con_id_GradeBase];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsXzAdminClsEN_js_1.clsXzAdminClsEN.con_id_GradeBase, objXzAdminCls_Cond.id_GradeBase, strComparisonOp_id_GradeBase);
        }
        if (Object.prototype.hasOwnProperty.call(objXzAdminCls_Cond.dicFldComparisonOp, clsXzAdminClsEN_js_1.clsXzAdminClsEN.con_AdminClsId) == true) {
            const strComparisonOp_AdminClsId = objXzAdminCls_Cond.dicFldComparisonOp[clsXzAdminClsEN_js_1.clsXzAdminClsEN.con_AdminClsId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsXzAdminClsEN_js_1.clsXzAdminClsEN.con_AdminClsId, objXzAdminCls_Cond.adminClsId, strComparisonOp_AdminClsId);
        }
        if (Object.prototype.hasOwnProperty.call(objXzAdminCls_Cond.dicFldComparisonOp, clsXzAdminClsEN_js_1.clsXzAdminClsEN.con_id_AdminClsType) == true) {
            const strComparisonOp_id_AdminClsType = objXzAdminCls_Cond.dicFldComparisonOp[clsXzAdminClsEN_js_1.clsXzAdminClsEN.con_id_AdminClsType];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsXzAdminClsEN_js_1.clsXzAdminClsEN.con_id_AdminClsType, objXzAdminCls_Cond.id_AdminClsType, strComparisonOp_id_AdminClsType);
        }
        if (Object.prototype.hasOwnProperty.call(objXzAdminCls_Cond.dicFldComparisonOp, clsXzAdminClsEN_js_1.clsXzAdminClsEN.con_AdminClsIndex) == true) {
            const strComparisonOp_AdminClsIndex = objXzAdminCls_Cond.dicFldComparisonOp[clsXzAdminClsEN_js_1.clsXzAdminClsEN.con_AdminClsIndex];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsXzAdminClsEN_js_1.clsXzAdminClsEN.con_AdminClsIndex, objXzAdminCls_Cond.adminClsIndex, strComparisonOp_AdminClsIndex);
        }
        if (Object.prototype.hasOwnProperty.call(objXzAdminCls_Cond.dicFldComparisonOp, clsXzAdminClsEN_js_1.clsXzAdminClsEN.con_Memo) == true) {
            const strComparisonOp_Memo = objXzAdminCls_Cond.dicFldComparisonOp[clsXzAdminClsEN_js_1.clsXzAdminClsEN.con_Memo];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsXzAdminClsEN_js_1.clsXzAdminClsEN.con_Memo, objXzAdminCls_Cond.memo, strComparisonOp_Memo);
        }
        if (Object.prototype.hasOwnProperty.call(objXzAdminCls_Cond.dicFldComparisonOp, clsXzAdminClsEN_js_1.clsXzAdminClsEN.con_ModifyUserID) == true) {
            const strComparisonOp_ModifyUserID = objXzAdminCls_Cond.dicFldComparisonOp[clsXzAdminClsEN_js_1.clsXzAdminClsEN.con_ModifyUserID];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsXzAdminClsEN_js_1.clsXzAdminClsEN.con_ModifyUserID, objXzAdminCls_Cond.modifyUserID, strComparisonOp_ModifyUserID);
        }
        if (Object.prototype.hasOwnProperty.call(objXzAdminCls_Cond.dicFldComparisonOp, clsXzAdminClsEN_js_1.clsXzAdminClsEN.con_ModifyDate) == true) {
            const strComparisonOp_ModifyDate = objXzAdminCls_Cond.dicFldComparisonOp[clsXzAdminClsEN_js_1.clsXzAdminClsEN.con_ModifyDate];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsXzAdminClsEN_js_1.clsXzAdminClsEN.con_ModifyDate, objXzAdminCls_Cond.modifyDate, strComparisonOp_ModifyDate);
        }
        return strWhereCond;
    }
    exports.XzAdminCls_GetCombineCondition = XzAdminCls_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--XzAdminCls(行政班),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param strAdminClsName: 行政班名称(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function XzAdminCls_GetUniCondStr_AdminClsName(objXzAdminClsEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and AdminClsName = '{0}'", objXzAdminClsEN.adminClsName);
        return strWhereCond;
    }
    exports.XzAdminCls_GetUniCondStr_AdminClsName = XzAdminCls_GetUniCondStr_AdminClsName;
    /**
    *获取唯一性条件串(Uniqueness)--XzAdminCls(行政班),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param strAdminClsName: 行政班名称(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function XzAdminCls_GetUniCondStr4Update_AdminClsName(objXzAdminClsEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and id_AdminCls <> '{0}'", objXzAdminClsEN.id_AdminCls);
        strWhereCond += (0, clsString_js_2.Format)(" and AdminClsName = '{0}'", objXzAdminClsEN.adminClsName);
        return strWhereCond;
    }
    exports.XzAdminCls_GetUniCondStr4Update_AdminClsName = XzAdminCls_GetUniCondStr4Update_AdminClsName;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objXzAdminClsENS:源对象
     * @param objXzAdminClsENT:目标对象
    */
    function XzAdminCls_CopyObjTo(objXzAdminClsENS, objXzAdminClsENT) {
        objXzAdminClsENT.id_AdminCls = objXzAdminClsENS.id_AdminCls; //行政班流水号
        objXzAdminClsENT.adminClsName = objXzAdminClsENS.adminClsName; //行政班名称
        objXzAdminClsENT.id_XzMajor = objXzAdminClsENS.id_XzMajor; //专业流水号
        objXzAdminClsENT.id_XzCollege = objXzAdminClsENS.id_XzCollege; //学院流水号
        objXzAdminClsENT.id_UniZone = objXzAdminClsENS.id_UniZone; //校区流水号
        objXzAdminClsENT.currentStuQty = objXzAdminClsENS.currentStuQty; //当前学生数
        objXzAdminClsENT.id_GradeBase = objXzAdminClsENS.id_GradeBase; //年级流水号
        objXzAdminClsENT.adminClsId = objXzAdminClsENS.adminClsId; //行政班代号
        objXzAdminClsENT.id_AdminClsType = objXzAdminClsENS.id_AdminClsType; //行政班级类型流水号
        objXzAdminClsENT.adminClsIndex = objXzAdminClsENS.adminClsIndex; //AdminClsIndex
        objXzAdminClsENT.memo = objXzAdminClsENS.memo; //备注
        objXzAdminClsENT.modifyUserID = objXzAdminClsENS.modifyUserID; //修改人
        objXzAdminClsENT.modifyDate = objXzAdminClsENS.modifyDate; //修改日期
        objXzAdminClsENT.sf_UpdFldSetStr = objXzAdminClsENS.updFldString; //sf_UpdFldSetStr
    }
    exports.XzAdminCls_CopyObjTo = XzAdminCls_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objXzAdminClsENS:源对象
     * @param objXzAdminClsENT:目标对象
    */
    function XzAdminCls_GetObjFromJsonObj(objXzAdminClsENS) {
        const objXzAdminClsENT = new clsXzAdminClsEN_js_1.clsXzAdminClsEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objXzAdminClsENT, objXzAdminClsENS);
        return objXzAdminClsENT;
    }
    exports.XzAdminCls_GetObjFromJsonObj = XzAdminCls_GetObjFromJsonObj;
});
