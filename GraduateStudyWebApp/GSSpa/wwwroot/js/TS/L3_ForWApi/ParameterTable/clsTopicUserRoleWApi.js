/**
* 类名:clsTopicUserRoleWApi
* 表名:TopicUserRole(01120590)
* 生成代码版本:2022.11.02.1
* 生成日期:2022/11/02 11:46:21
* 生成者:pyf
* 生成服务器IP:
工程名称:问卷调查(0112)
CM工程:研究生论文学习(变量首字母小写)-全部函数集
* 相关数据库:103.116.76.183,9433EduHigh_Jsie
* PrjDataBaseId:0170
模块中文名:研培参数(ParameterTable)
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
        define(["require", "exports", "axios", "../../PubFun/CacheHelper.js", "../../L0_Entity/ParameterTable/clsTopicUserRoleEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsSysPara4WebApi.js", "../../PubFun/CacheHelper.js", "../../PubFun/jsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.TopicUserRole_GetObjFromJsonObj = exports.TopicUserRole_CopyObjTo = exports.TopicUserRole_GetUniCondStr4Update_TopicUserRoleId = exports.TopicUserRole_GetUniCondStr_TopicUserRoleId = exports.TopicUserRole_GetCombineCondition = exports.TopicUserRole_GetObjByJSONStr = exports.TopicUserRole_GetObjLstByJSONObjLst = exports.TopicUserRole_GetObjLstByJSONStr = exports.TopicUserRole_GetJSONStrByObj = exports.TopicUserRole_CheckProperty4Update = exports.TopicUserRole_CheckPropertyNew = exports.TopicUserRole__Cache = exports.TopicUserRole_ReFreshThisCache = exports.TopicUserRole_ReFreshCache = exports.TopicUserRole_GetWebApiUrl = exports.TopicUserRole_GetMaxStrIdByPrefix = exports.TopicUserRole_GetMaxStrIdAsync = exports.TopicUserRole_GetRecCountByCond_Cache = exports.TopicUserRole_GetRecCountByCondAsync = exports.TopicUserRole_IsExistAsync = exports.TopicUserRole_IsExist_Cache = exports.TopicUserRole_IsExist = exports.TopicUserRole_IsExistRecordAsync = exports.TopicUserRole_IsExistRecord_Cache = exports.TopicUserRole_UpdateWithConditionAsync = exports.TopicUserRole_UpdateRecordAsync = exports.TopicUserRole_AddNewRecordWithReturnKey = exports.TopicUserRole_AddNewRecordWithReturnKeyAsync = exports.TopicUserRole_AddNewRecordWithMaxIdAsync = exports.TopicUserRole_AddNewRecordAsync = exports.TopicUserRole_DelTopicUserRolesByCondAsync = exports.TopicUserRole_DelTopicUserRolesAsync = exports.TopicUserRole_DelRecordAsync = exports.TopicUserRole_GetObjLstByPagerAsync = exports.TopicUserRole_GetObjLstByPager_Cache = exports.TopicUserRole_GetObjLstByRange = exports.TopicUserRole_GetObjLstByRangeAsync = exports.TopicUserRole_GetTopObjLstAsync = exports.TopicUserRole_GetObjLstByTopicUserRoleIdLst_Cache = exports.TopicUserRole_GetObjLstByTopicUserRoleIdLstAsync = exports.TopicUserRole_GetSubObjLst_Cache = exports.TopicUserRole_GetObjLst_PureCache = exports.TopicUserRole_GetObjLst_Cache = exports.TopicUserRole_GetObjLst_sessionStorage_PureCache = exports.TopicUserRole_GetObjLst_sessionStorage = exports.TopicUserRole_GetObjLstAsync = exports.TopicUserRole_GetObjLst_localStorage_PureCache = exports.TopicUserRole_GetObjLst_localStorage = exports.TopicUserRole_GetObjLst_ClientCache = exports.TopicUserRole_GetFirstObjAsync = exports.TopicUserRole_GetFirstID = exports.TopicUserRole_GetFirstIDAsync = exports.TopicUserRole_FilterFunByKey = exports.TopicUserRole_SortFunByKey = exports.TopicUserRole_SortFun_Defa_2Fld = exports.TopicUserRole_SortFun_Defa = exports.TopicUserRole_func = exports.TopicUserRole_GetNameByTopicUserRoleId_Cache = exports.TopicUserRole_UpdateObjInLst_Cache = exports.TopicUserRole_GetObjByTopicUserRoleId_localStorage = exports.TopicUserRole_GetObjByTopicUserRoleId_Cache = exports.TopicUserRole_GetObjByTopicUserRoleIdAsync = exports.topicUserRole_ConstructorName = exports.topicUserRole_Controller = void 0;
    /**
     * 主题用户角色(TopicUserRole)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2022年11月02日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsTopicUserRoleEN_js_1 = require("../../L0_Entity/ParameterTable/clsTopicUserRoleEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    const CacheHelper_js_2 = require("../../PubFun/CacheHelper.js");
    const jsString_js_1 = require("../../PubFun/jsString.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.topicUserRole_Controller = "TopicUserRoleApi";
    exports.topicUserRole_ConstructorName = "topicUserRole";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strTopicUserRoleId:关键字
    * @returns 对象
    **/
    async function TopicUserRole_GetObjByTopicUserRoleIdAsync(strTopicUserRoleId) {
        const strThisFuncName = "GetObjByTopicUserRoleIdAsync";
        if ((0, clsString_js_1.IsNullOrEmpty)(strTopicUserRoleId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strTopicUserRoleId]不能为空！(In GetObjByTopicUserRoleIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strTopicUserRoleId.length != 4) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strTopicUserRoleId]的长度:[{0}]不正确！", strTopicUserRoleId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByTopicUserRoleId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.topicUserRole_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "strTopicUserRoleId": strTopicUserRoleId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.topicUserRole_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objTopicUserRole = TopicUserRole_GetObjFromJsonObj(returnObj);
                return objTopicUserRole;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.topicUserRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.topicUserRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TopicUserRole_GetObjByTopicUserRoleIdAsync = TopicUserRole_GetObjByTopicUserRoleIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param strTopicUserRoleId:所给的关键字
     * @returns 对象
    */
    async function TopicUserRole_GetObjByTopicUserRoleId_Cache(strTopicUserRoleId, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByTopicUserRoleId_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strTopicUserRoleId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strTopicUserRoleId]不能为空！(In GetObjByTopicUserRoleId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strTopicUserRoleId.length != 4) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strTopicUserRoleId]的长度:[{0}]不正确！", strTopicUserRoleId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrTopicUserRoleObjLst_Cache = await TopicUserRole_GetObjLst_Cache();
        try {
            const arrTopicUserRole_Sel = arrTopicUserRoleObjLst_Cache.filter(x => x.topicUserRoleId == strTopicUserRoleId);
            let objTopicUserRole;
            if (arrTopicUserRole_Sel.length > 0) {
                objTopicUserRole = arrTopicUserRole_Sel[0];
                return objTopicUserRole;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    objTopicUserRole = await TopicUserRole_GetObjByTopicUserRoleIdAsync(strTopicUserRoleId);
                    if (objTopicUserRole != null) {
                        TopicUserRole_ReFreshThisCache();
                        return objTopicUserRole;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strTopicUserRoleId, exports.topicUserRole_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.TopicUserRole_GetObjByTopicUserRoleId_Cache = TopicUserRole_GetObjByTopicUserRoleId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param strTopicUserRoleId:所给的关键字
     * @returns 对象
    */
    async function TopicUserRole_GetObjByTopicUserRoleId_localStorage(strTopicUserRoleId) {
        const strThisFuncName = "GetObjByTopicUserRoleId_localStorage";
        if ((0, clsString_js_1.IsNullOrEmpty)(strTopicUserRoleId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strTopicUserRoleId]不能为空！(In GetObjByTopicUserRoleId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strTopicUserRoleId.length != 4) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strTopicUserRoleId]的长度:[{0}]不正确！", strTopicUserRoleId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsTopicUserRoleEN_js_1.clsTopicUserRoleEN._CurrTabName, strTopicUserRoleId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objTopicUserRole_Cache = JSON.parse(strTempObj);
            return objTopicUserRole_Cache;
        }
        try {
            const objTopicUserRole = await TopicUserRole_GetObjByTopicUserRoleIdAsync(strTopicUserRoleId);
            if (objTopicUserRole != null) {
                localStorage.setItem(strKey, JSON.stringify(objTopicUserRole));
                const strInfo = (0, clsString_js_1.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objTopicUserRole;
            }
            return objTopicUserRole;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strTopicUserRoleId, exports.topicUserRole_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.TopicUserRole_GetObjByTopicUserRoleId_localStorage = TopicUserRole_GetObjByTopicUserRoleId_localStorage;
    /**
     * 修改在缓存对象列表中的对象, 与后台数据库无关.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
     * @param objTopicUserRole:所给的对象
     * @returns 对象
    */
    async function TopicUserRole_UpdateObjInLst_Cache(objTopicUserRole) {
        const strThisFuncName = "UpdateObjInLst_Cache";
        try {
            const arrTopicUserRoleObjLst_Cache = await TopicUserRole_GetObjLst_Cache();
            const obj = arrTopicUserRoleObjLst_Cache.find(x => x.topicUserRoleId == objTopicUserRole.topicUserRoleId);
            if (obj != null) {
                objTopicUserRole.topicUserRoleId = obj.topicUserRoleId;
                (0, clsCommFunc4Web_js_1.ObjectAssign)(obj, objTopicUserRole);
            }
            else {
                arrTopicUserRoleObjLst_Cache.push(objTopicUserRole);
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, exports.topicUserRole_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.TopicUserRole_UpdateObjInLst_Cache = TopicUserRole_UpdateObjInLst_Cache;
    /**
     * 根据关键字获取相关对象的名称属性, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetNameByKeyId_Cache)
     * @param strTopicUserRoleId:所给的关键字
     * @returns 对象
    */
    async function TopicUserRole_GetNameByTopicUserRoleId_Cache(strTopicUserRoleId) {
        const strThisFuncName = "GetNameByTopicUserRoleId_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strTopicUserRoleId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strTopicUserRoleId]不能为空！(In GetNameByTopicUserRoleId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strTopicUserRoleId.length != 4) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strTopicUserRoleId]的长度:[{0}]不正确！", strTopicUserRoleId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrTopicUserRoleObjLst_Cache = await TopicUserRole_GetObjLst_Cache();
        if (arrTopicUserRoleObjLst_Cache == null)
            return "";
        try {
            const arrTopicUserRole_Sel = arrTopicUserRoleObjLst_Cache.filter(x => x.topicUserRoleId == strTopicUserRoleId);
            let objTopicUserRole;
            if (arrTopicUserRole_Sel.length > 0) {
                objTopicUserRole = arrTopicUserRole_Sel[0];
                return objTopicUserRole.topicUserRoleName;
            }
            else {
                return "";
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象名称属性不成功!", e, strTopicUserRoleId);
            console.error(strMsg);
            alert(strMsg);
        }
        return "";
    }
    exports.TopicUserRole_GetNameByTopicUserRoleId_Cache = TopicUserRole_GetNameByTopicUserRoleId_Cache;
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
    async function TopicUserRole_func(strInFldName, strOutFldName, strInValue) {
        //const strThisFuncName = "func";
        if (strInFldName != clsTopicUserRoleEN_js_1.clsTopicUserRoleEN.con_TopicUserRoleId) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsTopicUserRoleEN_js_1.clsTopicUserRoleEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_1.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strInFldName, clsTopicUserRoleEN_js_1.clsTopicUserRoleEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strTopicUserRoleId = strInValue;
        if ((0, clsString_js_1.IsNullOrEmpty)(strInValue) == true) {
            return "";
        }
        const objTopicUserRole = await TopicUserRole_GetObjByTopicUserRoleId_Cache(strTopicUserRoleId);
        if (objTopicUserRole == null)
            return "";
        return objTopicUserRole.GetFldValue(strOutFldName).toString();
    }
    exports.TopicUserRole_func = TopicUserRole_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function TopicUserRole_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.topicUserRoleId.localeCompare(b.topicUserRoleId);
    }
    exports.TopicUserRole_SortFun_Defa = TopicUserRole_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function TopicUserRole_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.topicUserRoleName == b.topicUserRoleName)
            return a.updUserId.localeCompare(b.updUserId);
        else
            return a.topicUserRoleName.localeCompare(b.topicUserRoleName);
    }
    exports.TopicUserRole_SortFun_Defa_2Fld = TopicUserRole_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function TopicUserRole_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsTopicUserRoleEN_js_1.clsTopicUserRoleEN.con_TopicUserRoleId:
                    return (a, b) => {
                        return a.topicUserRoleId.localeCompare(b.topicUserRoleId);
                    };
                case clsTopicUserRoleEN_js_1.clsTopicUserRoleEN.con_TopicUserRoleName:
                    return (a, b) => {
                        return a.topicUserRoleName.localeCompare(b.topicUserRoleName);
                    };
                case clsTopicUserRoleEN_js_1.clsTopicUserRoleEN.con_UpdUserId:
                    return (a, b) => {
                        return a.updUserId.localeCompare(b.updUserId);
                    };
                case clsTopicUserRoleEN_js_1.clsTopicUserRoleEN.con_UpdDate:
                    return (a, b) => {
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsTopicUserRoleEN_js_1.clsTopicUserRoleEN.con_Memo:
                    return (a, b) => {
                        return a.memo.localeCompare(b.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[TopicUserRole]中不存在！(in ${exports.topicUserRole_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsTopicUserRoleEN_js_1.clsTopicUserRoleEN.con_TopicUserRoleId:
                    return (a, b) => {
                        return b.topicUserRoleId.localeCompare(a.topicUserRoleId);
                    };
                case clsTopicUserRoleEN_js_1.clsTopicUserRoleEN.con_TopicUserRoleName:
                    return (a, b) => {
                        return b.topicUserRoleName.localeCompare(a.topicUserRoleName);
                    };
                case clsTopicUserRoleEN_js_1.clsTopicUserRoleEN.con_UpdUserId:
                    return (a, b) => {
                        return b.updUserId.localeCompare(a.updUserId);
                    };
                case clsTopicUserRoleEN_js_1.clsTopicUserRoleEN.con_UpdDate:
                    return (a, b) => {
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsTopicUserRoleEN_js_1.clsTopicUserRoleEN.con_Memo:
                    return (a, b) => {
                        return b.memo.localeCompare(a.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[TopicUserRole]中不存在！(in ${exports.topicUserRole_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.TopicUserRole_SortFunByKey = TopicUserRole_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function TopicUserRole_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsTopicUserRoleEN_js_1.clsTopicUserRoleEN.con_TopicUserRoleId:
                return (obj) => {
                    return obj.topicUserRoleId === value;
                };
            case clsTopicUserRoleEN_js_1.clsTopicUserRoleEN.con_TopicUserRoleName:
                return (obj) => {
                    return obj.topicUserRoleName === value;
                };
            case clsTopicUserRoleEN_js_1.clsTopicUserRoleEN.con_UpdUserId:
                return (obj) => {
                    return obj.updUserId === value;
                };
            case clsTopicUserRoleEN_js_1.clsTopicUserRoleEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsTopicUserRoleEN_js_1.clsTopicUserRoleEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[TopicUserRole]中不存在！(in ${exports.topicUserRole_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.TopicUserRole_FilterFunByKey = TopicUserRole_FilterFunByKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function TopicUserRole_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.topicUserRole_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.topicUserRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.topicUserRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TopicUserRole_GetFirstIDAsync = TopicUserRole_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function TopicUserRole_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.topicUserRole_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.topicUserRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.topicUserRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TopicUserRole_GetFirstID = TopicUserRole_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function TopicUserRole_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.topicUserRole_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.topicUserRole_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objTopicUserRole = TopicUserRole_GetObjFromJsonObj(returnObj);
                return objTopicUserRole;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.topicUserRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.topicUserRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TopicUserRole_GetFirstObjAsync = TopicUserRole_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function TopicUserRole_GetObjLst_ClientCache() {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsTopicUserRoleEN_js_1.clsTopicUserRoleEN._CurrTabName;
        clsTopicUserRoleEN_js_1.clsTopicUserRoleEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsTopicUserRoleEN_js_1.clsTopicUserRoleEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsTopicUserRoleEN_js_1.clsTopicUserRoleEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsTopicUserRoleEN_js_1.clsTopicUserRoleEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_2.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrTopicUserRoleExObjLst_Cache = CacheHelper_js_2.CacheHelper.Get(strKey);
            const arrTopicUserRoleObjLst_T = TopicUserRole_GetObjLstByJSONObjLst(arrTopicUserRoleExObjLst_Cache);
            return arrTopicUserRoleObjLst_T;
        }
        try {
            const arrTopicUserRoleExObjLst = await TopicUserRole_GetObjLstAsync(strWhereCond);
            CacheHelper_js_2.CacheHelper.Add(strKey, arrTopicUserRoleExObjLst);
            const strInfo = (0, clsString_js_1.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrTopicUserRoleExObjLst.length);
            console.log(strInfo);
            return arrTopicUserRoleExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.topicUserRole_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.TopicUserRole_GetObjLst_ClientCache = TopicUserRole_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function TopicUserRole_GetObjLst_localStorage() {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsTopicUserRoleEN_js_1.clsTopicUserRoleEN._CurrTabName;
        clsTopicUserRoleEN_js_1.clsTopicUserRoleEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsTopicUserRoleEN_js_1.clsTopicUserRoleEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsTopicUserRoleEN_js_1.clsTopicUserRoleEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsTopicUserRoleEN_js_1.clsTopicUserRoleEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrTopicUserRoleExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrTopicUserRoleObjLst_T = TopicUserRole_GetObjLstByJSONObjLst(arrTopicUserRoleExObjLst_Cache);
            return arrTopicUserRoleObjLst_T;
        }
        try {
            const arrTopicUserRoleExObjLst = await TopicUserRole_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrTopicUserRoleExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrTopicUserRoleExObjLst.length);
            console.log(strInfo);
            return arrTopicUserRoleExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.topicUserRole_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.TopicUserRole_GetObjLst_localStorage = TopicUserRole_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function TopicUserRole_GetObjLst_localStorage_PureCache() {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsTopicUserRoleEN_js_1.clsTopicUserRoleEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrTopicUserRoleObjLst_Cache = JSON.parse(strTempObjLst);
            return arrTopicUserRoleObjLst_Cache;
        }
        else
            return null;
    }
    exports.TopicUserRole_GetObjLst_localStorage_PureCache = TopicUserRole_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function TopicUserRole_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.topicUserRole_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.topicUserRole_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = TopicUserRole_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.topicUserRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.topicUserRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TopicUserRole_GetObjLstAsync = TopicUserRole_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function TopicUserRole_GetObjLst_sessionStorage() {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsTopicUserRoleEN_js_1.clsTopicUserRoleEN._CurrTabName;
        clsTopicUserRoleEN_js_1.clsTopicUserRoleEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsTopicUserRoleEN_js_1.clsTopicUserRoleEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsTopicUserRoleEN_js_1.clsTopicUserRoleEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsTopicUserRoleEN_js_1.clsTopicUserRoleEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrTopicUserRoleExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrTopicUserRoleObjLst_T = TopicUserRole_GetObjLstByJSONObjLst(arrTopicUserRoleExObjLst_Cache);
            return arrTopicUserRoleObjLst_T;
        }
        try {
            const arrTopicUserRoleExObjLst = await TopicUserRole_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrTopicUserRoleExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrTopicUserRoleExObjLst.length);
            console.log(strInfo);
            return arrTopicUserRoleExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.topicUserRole_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.TopicUserRole_GetObjLst_sessionStorage = TopicUserRole_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function TopicUserRole_GetObjLst_sessionStorage_PureCache() {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsTopicUserRoleEN_js_1.clsTopicUserRoleEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrTopicUserRoleObjLst_Cache = JSON.parse(strTempObjLst);
            return arrTopicUserRoleObjLst_Cache;
        }
        else
            return null;
    }
    exports.TopicUserRole_GetObjLst_sessionStorage_PureCache = TopicUserRole_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function TopicUserRole_GetObjLst_Cache() {
        //const strThisFuncName = "GetObjLst_Cache";
        let arrTopicUserRoleObjLst_Cache;
        switch (clsTopicUserRoleEN_js_1.clsTopicUserRoleEN.CacheModeId) {
            case "04": //sessionStorage
                arrTopicUserRoleObjLst_Cache = await TopicUserRole_GetObjLst_sessionStorage();
                break;
            case "03": //localStorage
                arrTopicUserRoleObjLst_Cache = await TopicUserRole_GetObjLst_localStorage();
                break;
            case "02": //ClientCache
                arrTopicUserRoleObjLst_Cache = await TopicUserRole_GetObjLst_ClientCache();
                break;
            default:
                arrTopicUserRoleObjLst_Cache = await TopicUserRole_GetObjLst_ClientCache();
                break;
        }
        const arrTopicUserRoleObjLst = TopicUserRole_GetObjLstByJSONObjLst(arrTopicUserRoleObjLst_Cache);
        return arrTopicUserRoleObjLst_Cache;
    }
    exports.TopicUserRole_GetObjLst_Cache = TopicUserRole_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function TopicUserRole_GetObjLst_PureCache() {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrTopicUserRoleObjLst_Cache;
        switch (clsTopicUserRoleEN_js_1.clsTopicUserRoleEN.CacheModeId) {
            case "04": //sessionStorage
                arrTopicUserRoleObjLst_Cache = await TopicUserRole_GetObjLst_sessionStorage_PureCache();
                break;
            case "03": //localStorage
                arrTopicUserRoleObjLst_Cache = await TopicUserRole_GetObjLst_localStorage_PureCache();
                break;
            case "02": //ClientCache
                arrTopicUserRoleObjLst_Cache = null;
                break;
            default:
                arrTopicUserRoleObjLst_Cache = null;
                break;
        }
        return arrTopicUserRoleObjLst_Cache;
    }
    exports.TopicUserRole_GetObjLst_PureCache = TopicUserRole_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objstrTopicUserRoleId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function TopicUserRole_GetSubObjLst_Cache(objTopicUserRole_Cond) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrTopicUserRoleObjLst_Cache = await TopicUserRole_GetObjLst_Cache();
        let arrTopicUserRole_Sel = arrTopicUserRoleObjLst_Cache;
        if (objTopicUserRole_Cond.sf_FldComparisonOp == null || objTopicUserRole_Cond.sf_FldComparisonOp == "")
            return arrTopicUserRole_Sel;
        const dicFldComparisonOp = JSON.parse(objTopicUserRole_Cond.sf_FldComparisonOp);
        //console.log("clsTopicUserRoleWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objTopicUserRole_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrTopicUserRole_Sel = arrTopicUserRole_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objTopicUserRole_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrTopicUserRole_Sel = arrTopicUserRole_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrTopicUserRole_Sel = arrTopicUserRole_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrTopicUserRole_Sel = arrTopicUserRole_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrTopicUserRole_Sel = arrTopicUserRole_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrTopicUserRole_Sel = arrTopicUserRole_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrTopicUserRole_Sel = arrTopicUserRole_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrTopicUserRole_Sel = arrTopicUserRole_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrTopicUserRole_Sel = arrTopicUserRole_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrTopicUserRole_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objTopicUserRole_Cond), exports.topicUserRole_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.TopicUserRole_GetSubObjLst_Cache = TopicUserRole_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrTopicUserRoleId:关键字列表
    * @returns 对象列表
    **/
    async function TopicUserRole_GetObjLstByTopicUserRoleIdLstAsync(arrTopicUserRoleId) {
        const strThisFuncName = "GetObjLstByTopicUserRoleIdLstAsync";
        const strAction = "GetObjLstByTopicUserRoleIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.topicUserRole_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrTopicUserRoleId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.topicUserRole_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = TopicUserRole_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.topicUserRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.topicUserRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TopicUserRole_GetObjLstByTopicUserRoleIdLstAsync = TopicUserRole_GetObjLstByTopicUserRoleIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrstrTopicUserRoleIdLst:关键字列表
     * @returns 对象列表
    */
    async function TopicUserRole_GetObjLstByTopicUserRoleIdLst_Cache(arrTopicUserRoleIdLst) {
        const strThisFuncName = "GetObjLstByTopicUserRoleIdLst_Cache";
        try {
            const arrTopicUserRoleObjLst_Cache = await TopicUserRole_GetObjLst_Cache();
            const arrTopicUserRole_Sel = arrTopicUserRoleObjLst_Cache.filter(x => arrTopicUserRoleIdLst.indexOf(x.topicUserRoleId) > -1);
            return arrTopicUserRole_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrTopicUserRoleIdLst.join(","), exports.topicUserRole_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.TopicUserRole_GetObjLstByTopicUserRoleIdLst_Cache = TopicUserRole_GetObjLstByTopicUserRoleIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function TopicUserRole_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.topicUserRole_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.topicUserRole_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = TopicUserRole_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.topicUserRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.topicUserRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TopicUserRole_GetTopObjLstAsync = TopicUserRole_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function TopicUserRole_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.topicUserRole_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.topicUserRole_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = TopicUserRole_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.topicUserRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.topicUserRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TopicUserRole_GetObjLstByRangeAsync = TopicUserRole_GetObjLstByRangeAsync;
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
    async function TopicUserRole_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.topicUserRole_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.topicUserRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.topicUserRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TopicUserRole_GetObjLstByRange = TopicUserRole_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function TopicUserRole_GetObjLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const arrTopicUserRoleObjLst_Cache = await TopicUserRole_GetObjLst_Cache();
        if (arrTopicUserRoleObjLst_Cache.length == 0)
            return arrTopicUserRoleObjLst_Cache;
        let arrTopicUserRole_Sel = arrTopicUserRoleObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objTopicUserRole_Cond = new clsTopicUserRoleEN_js_1.clsTopicUserRoleEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objTopicUserRole_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsTopicUserRoleWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrTopicUserRole_Sel = arrTopicUserRole_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objTopicUserRole_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrTopicUserRole_Sel = arrTopicUserRole_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrTopicUserRole_Sel = arrTopicUserRole_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrTopicUserRole_Sel = arrTopicUserRole_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrTopicUserRole_Sel = arrTopicUserRole_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrTopicUserRole_Sel = arrTopicUserRole_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrTopicUserRole_Sel = arrTopicUserRole_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrTopicUserRole_Sel = arrTopicUserRole_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrTopicUserRole_Sel = arrTopicUserRole_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrTopicUserRole_Sel = arrTopicUserRole_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrTopicUserRole_Sel.length == 0)
                return arrTopicUserRole_Sel;
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
                arrTopicUserRole_Sel = arrTopicUserRole_Sel.sort(TopicUserRole_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrTopicUserRole_Sel = arrTopicUserRole_Sel.sort(objPagerPara.sortFun);
            }
            arrTopicUserRole_Sel = arrTopicUserRole_Sel.slice(intStart, intEnd);
            return arrTopicUserRole_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.topicUserRole_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.TopicUserRole_GetObjLstByPager_Cache = TopicUserRole_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function TopicUserRole_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.topicUserRole_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.topicUserRole_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = TopicUserRole_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.topicUserRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.topicUserRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TopicUserRole_GetObjLstByPagerAsync = TopicUserRole_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param strTopicUserRoleId:关键字
    * @returns 获取删除的结果
    **/
    async function TopicUserRole_DelRecordAsync(strTopicUserRoleId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.topicUserRole_Controller, strAction);
        strUrl = (0, clsString_js_1.Format)("{0}/?Id={1}", strUrl, strTopicUserRoleId);
        try {
            const response = await axios_1.default.delete(strUrl, {
                params: { "Id": strTopicUserRoleId, }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.topicUserRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.topicUserRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TopicUserRole_DelRecordAsync = TopicUserRole_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrTopicUserRoleId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function TopicUserRole_DelTopicUserRolesAsync(arrTopicUserRoleId) {
        const strThisFuncName = "DelTopicUserRolesAsync";
        const strAction = "DelTopicUserRoles";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.topicUserRole_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrTopicUserRoleId);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.topicUserRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.topicUserRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TopicUserRole_DelTopicUserRolesAsync = TopicUserRole_DelTopicUserRolesAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function TopicUserRole_DelTopicUserRolesByCondAsync(strWhereCond) {
        const strThisFuncName = "DelTopicUserRolesByCondAsync";
        const strAction = "DelTopicUserRolesByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.topicUserRole_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.topicUserRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.topicUserRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TopicUserRole_DelTopicUserRolesByCondAsync = TopicUserRole_DelTopicUserRolesByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objTopicUserRoleEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function TopicUserRole_AddNewRecordAsync(objTopicUserRoleEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objTopicUserRoleEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.topicUserRole_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopicUserRoleEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.topicUserRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.topicUserRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TopicUserRole_AddNewRecordAsync = TopicUserRole_AddNewRecordAsync;
    /**
    * 调用WebApi来添加记录，关键字用最大关键字，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithMaxIdAsync)
    * @param objTopicUserRoleEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function TopicUserRole_AddNewRecordWithMaxIdAsync(objTopicUserRoleEN) {
        const strThisFuncName = "AddNewRecordWithMaxIdAsync";
        const strAction = "AddNewRecordWithMaxId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.topicUserRole_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopicUserRoleEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.topicUserRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.topicUserRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TopicUserRole_AddNewRecordWithMaxIdAsync = TopicUserRole_AddNewRecordWithMaxIdAsync;
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objTopicUserRoleEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function TopicUserRole_AddNewRecordWithReturnKeyAsync(objTopicUserRoleEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.topicUserRole_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopicUserRoleEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.topicUserRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.topicUserRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TopicUserRole_AddNewRecordWithReturnKeyAsync = TopicUserRole_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objTopicUserRoleEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function TopicUserRole_AddNewRecordWithReturnKey(objTopicUserRoleEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objTopicUserRoleEN.topicUserRoleId === null || objTopicUserRoleEN.topicUserRoleId === "") {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.topicUserRole_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopicUserRoleEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.topicUserRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.topicUserRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TopicUserRole_AddNewRecordWithReturnKey = TopicUserRole_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objTopicUserRoleEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function TopicUserRole_UpdateRecordAsync(objTopicUserRoleEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objTopicUserRoleEN.sf_UpdFldSetStr === undefined || objTopicUserRoleEN.sf_UpdFldSetStr === null || objTopicUserRoleEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objTopicUserRoleEN.topicUserRoleId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.topicUserRole_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopicUserRoleEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.topicUserRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.topicUserRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TopicUserRole_UpdateRecordAsync = TopicUserRole_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objTopicUserRoleEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function TopicUserRole_UpdateWithConditionAsync(objTopicUserRoleEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objTopicUserRoleEN.sf_UpdFldSetStr === undefined || objTopicUserRoleEN.sf_UpdFldSetStr === null || objTopicUserRoleEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objTopicUserRoleEN.topicUserRoleId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.topicUserRole_Controller, strAction);
        objTopicUserRoleEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objTopicUserRoleEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.topicUserRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.topicUserRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TopicUserRole_UpdateWithConditionAsync = TopicUserRole_UpdateWithConditionAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objstrTopicUserRoleId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function TopicUserRole_IsExistRecord_Cache(objTopicUserRole_Cond) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrTopicUserRoleObjLst_Cache = await TopicUserRole_GetObjLst_Cache();
        if (arrTopicUserRoleObjLst_Cache == null)
            return false;
        let arrTopicUserRole_Sel = arrTopicUserRoleObjLst_Cache;
        if (objTopicUserRole_Cond.sf_FldComparisonOp == null || objTopicUserRole_Cond.sf_FldComparisonOp == "")
            return arrTopicUserRole_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objTopicUserRole_Cond.sf_FldComparisonOp);
        //console.log("clsTopicUserRoleWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objTopicUserRole_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objTopicUserRole_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrTopicUserRole_Sel = arrTopicUserRole_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrTopicUserRole_Sel = arrTopicUserRole_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrTopicUserRole_Sel = arrTopicUserRole_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrTopicUserRole_Sel = arrTopicUserRole_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrTopicUserRole_Sel = arrTopicUserRole_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrTopicUserRole_Sel = arrTopicUserRole_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrTopicUserRole_Sel = arrTopicUserRole_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrTopicUserRole_Sel = arrTopicUserRole_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrTopicUserRole_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objTopicUserRole_Cond), exports.topicUserRole_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.TopicUserRole_IsExistRecord_Cache = TopicUserRole_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function TopicUserRole_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.topicUserRole_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.topicUserRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.topicUserRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TopicUserRole_IsExistRecordAsync = TopicUserRole_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strTopicUserRoleId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function TopicUserRole_IsExist(strTopicUserRoleId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.topicUserRole_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "TopicUserRoleId": strTopicUserRoleId,
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.topicUserRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.topicUserRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TopicUserRole_IsExist = TopicUserRole_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param strTopicUserRoleId:所给的关键字
     * @returns 对象
    */
    async function TopicUserRole_IsExist_Cache(strTopicUserRoleId) {
        const strThisFuncName = "IsExist_Cache";
        const arrTopicUserRoleObjLst_Cache = await TopicUserRole_GetObjLst_Cache();
        if (arrTopicUserRoleObjLst_Cache == null)
            return false;
        try {
            const arrTopicUserRole_Sel = arrTopicUserRoleObjLst_Cache.filter(x => x.topicUserRoleId == strTopicUserRoleId);
            if (arrTopicUserRole_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strTopicUserRoleId, exports.topicUserRole_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.TopicUserRole_IsExist_Cache = TopicUserRole_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strTopicUserRoleId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function TopicUserRole_IsExistAsync(strTopicUserRoleId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.topicUserRole_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strTopicUserRoleId": strTopicUserRoleId }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.topicUserRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.topicUserRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TopicUserRole_IsExistAsync = TopicUserRole_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function TopicUserRole_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.topicUserRole_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.topicUserRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.topicUserRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TopicUserRole_GetRecCountByCondAsync = TopicUserRole_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objTopicUserRole_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function TopicUserRole_GetRecCountByCond_Cache(objTopicUserRole_Cond) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrTopicUserRoleObjLst_Cache = await TopicUserRole_GetObjLst_Cache();
        if (arrTopicUserRoleObjLst_Cache == null)
            return 0;
        let arrTopicUserRole_Sel = arrTopicUserRoleObjLst_Cache;
        if (objTopicUserRole_Cond.sf_FldComparisonOp == null || objTopicUserRole_Cond.sf_FldComparisonOp == "")
            return arrTopicUserRole_Sel.length;
        const dicFldComparisonOp = JSON.parse(objTopicUserRole_Cond.sf_FldComparisonOp);
        //console.log("clsTopicUserRoleWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objTopicUserRole_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrTopicUserRole_Sel = arrTopicUserRole_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objTopicUserRole_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrTopicUserRole_Sel = arrTopicUserRole_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrTopicUserRole_Sel = arrTopicUserRole_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrTopicUserRole_Sel = arrTopicUserRole_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrTopicUserRole_Sel = arrTopicUserRole_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrTopicUserRole_Sel = arrTopicUserRole_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrTopicUserRole_Sel = arrTopicUserRole_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrTopicUserRole_Sel = arrTopicUserRole_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrTopicUserRole_Sel = arrTopicUserRole_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrTopicUserRole_Sel = arrTopicUserRole_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrTopicUserRole_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objTopicUserRole_Cond), exports.topicUserRole_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.TopicUserRole_GetRecCountByCond_Cache = TopicUserRole_GetRecCountByCond_Cache;
    /**
    * 获取表的最大关键字
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdAsync)
    * @returns 获取表的最大关键字
    **/
    async function TopicUserRole_GetMaxStrIdAsync() {
        const strThisFuncName = "GetMaxStrIdAsync";
        const strAction = "GetMaxStrId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.topicUserRole_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.topicUserRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.topicUserRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TopicUserRole_GetMaxStrIdAsync = TopicUserRole_GetMaxStrIdAsync;
    /*该表的关键字类型不是字符型带前缀自增，不需要生成获取最大关键字函数！*/
    /**
     * 根据前缀获取当前表关键字值的最大值,再加1,避免重复
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdByPrefix)
     * @param mapParam:参数列表
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 获取当前表关键字值的最大值
    */
    async function TopicUserRole_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.topicUserRole_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.topicUserRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.topicUserRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TopicUserRole_GetMaxStrIdByPrefix = TopicUserRole_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function TopicUserRole_GetWebApiUrl(strController, strAction) {
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
    exports.TopicUserRole_GetWebApiUrl = TopicUserRole_GetWebApiUrl;
    /**
    * 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshCache)
    **/
    function TopicUserRole_ReFreshCache() {
        const strThisFuncName = "ReFreshCache";
        const strMsg = (0, clsString_js_1.Format)("刷新缓存成功！");
        console.trace(strMsg);
        // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
        const strKey = clsTopicUserRoleEN_js_1.clsTopicUserRoleEN._CurrTabName;
        switch (clsTopicUserRoleEN_js_1.clsTopicUserRoleEN.CacheModeId) {
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
    exports.TopicUserRole_ReFreshCache = TopicUserRole_ReFreshCache;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function TopicUserRole_ReFreshThisCache() {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = clsTopicUserRoleEN_js_1.clsTopicUserRoleEN._CurrTabName;
            switch (clsTopicUserRoleEN_js_1.clsTopicUserRoleEN.CacheModeId) {
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
    exports.TopicUserRole_ReFreshThisCache = TopicUserRole_ReFreshThisCache;
    /**
     * 绑定基于Web的下拉框,在某一层下的下拉框
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunctionInDiv)
     * @param objDDL:需要绑定当前表的下拉框
    */
    async function TopicUserRole__Cache(strDivName, strDdlName) {
        const strThisFuncName = "_Cache";
        const objDdl = document.getElementById(strDdlName);
        if (objDdl == null) {
            const strMsg = (0, clsString_js_1.Format)("下拉框：{0} 不存在！(In )", strDdlName);
            alert(strMsg);
            console.error(strMsg);
            throw (strMsg);
        }
        //为数据源于表的下拉框设置内容
        //console.log("开始：_Cache");
        const arrObjLst_Sel = await TopicUserRole_GetObjLst_Cache();
        if (arrObjLst_Sel == null)
            return;
        (0, clsCommFunc4Web_js_1.BindDdl_ObjLstInDiv)(strDivName, strDdlName, arrObjLst_Sel, clsTopicUserRoleEN_js_1.clsTopicUserRoleEN.con_TopicUserRoleId, clsTopicUserRoleEN_js_1.clsTopicUserRoleEN.con_TopicUserRoleName, "主题用户角色");
    }
    exports.TopicUserRole__Cache = TopicUserRole__Cache;
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function TopicUserRole_CheckPropertyNew(pobjTopicUserRoleEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTopicUserRoleEN.topicUserRoleName) === true) {
            throw new Error("(errid:Watl000058)字段[主题用户角色]不能为空(In 主题用户角色)!(clsTopicUserRoleBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTopicUserRoleEN.updUserId) === true) {
            throw new Error("(errid:Watl000058)字段[修改用户Id]不能为空(In 主题用户角色)!(clsTopicUserRoleBL:CheckPropertyNew)");
        }
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTopicUserRoleEN.topicUserRoleId) == false && (0, clsString_js_1.GetStrLen)(pobjTopicUserRoleEN.topicUserRoleId) > 4) {
            throw new Error("(errid:Watl000059)字段[主键Id(topicUserRoleId)]的长度不能超过4(In 主题用户角色(TopicUserRole))!值:$(pobjTopicUserRoleEN.topicUserRoleId)(clsTopicUserRoleBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTopicUserRoleEN.topicUserRoleName) == false && (0, clsString_js_1.GetStrLen)(pobjTopicUserRoleEN.topicUserRoleName) > 100) {
            throw new Error("(errid:Watl000059)字段[主题用户角色(topicUserRoleName)]的长度不能超过100(In 主题用户角色(TopicUserRole))!值:$(pobjTopicUserRoleEN.topicUserRoleName)(clsTopicUserRoleBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTopicUserRoleEN.updUserId) == false && (0, clsString_js_1.GetStrLen)(pobjTopicUserRoleEN.updUserId) > 20) {
            throw new Error("(errid:Watl000059)字段[修改用户Id(updUserId)]的长度不能超过20(In 主题用户角色(TopicUserRole))!值:$(pobjTopicUserRoleEN.updUserId)(clsTopicUserRoleBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTopicUserRoleEN.updDate) == false && (0, clsString_js_1.GetStrLen)(pobjTopicUserRoleEN.updDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 主题用户角色(TopicUserRole))!值:$(pobjTopicUserRoleEN.updDate)(clsTopicUserRoleBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTopicUserRoleEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjTopicUserRoleEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 主题用户角色(TopicUserRole))!值:$(pobjTopicUserRoleEN.memo)(clsTopicUserRoleBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTopicUserRoleEN.topicUserRoleId) == false && undefined !== pobjTopicUserRoleEN.topicUserRoleId && jsString_js_1.tzDataType.isString(pobjTopicUserRoleEN.topicUserRoleId) === false) {
            throw new Error("(errid:Watl000060)字段[主键Id(topicUserRoleId)]的值:[$(pobjTopicUserRoleEN.topicUserRoleId)], 非法，应该为字符型(In 主题用户角色(TopicUserRole))!(clsTopicUserRoleBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTopicUserRoleEN.topicUserRoleName) == false && undefined !== pobjTopicUserRoleEN.topicUserRoleName && jsString_js_1.tzDataType.isString(pobjTopicUserRoleEN.topicUserRoleName) === false) {
            throw new Error("(errid:Watl000060)字段[主题用户角色(topicUserRoleName)]的值:[$(pobjTopicUserRoleEN.topicUserRoleName)], 非法，应该为字符型(In 主题用户角色(TopicUserRole))!(clsTopicUserRoleBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTopicUserRoleEN.updUserId) == false && undefined !== pobjTopicUserRoleEN.updUserId && jsString_js_1.tzDataType.isString(pobjTopicUserRoleEN.updUserId) === false) {
            throw new Error("(errid:Watl000060)字段[修改用户Id(updUserId)]的值:[$(pobjTopicUserRoleEN.updUserId)], 非法，应该为字符型(In 主题用户角色(TopicUserRole))!(clsTopicUserRoleBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTopicUserRoleEN.updDate) == false && undefined !== pobjTopicUserRoleEN.updDate && jsString_js_1.tzDataType.isString(pobjTopicUserRoleEN.updDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjTopicUserRoleEN.updDate)], 非法，应该为字符型(In 主题用户角色(TopicUserRole))!(clsTopicUserRoleBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTopicUserRoleEN.memo) == false && undefined !== pobjTopicUserRoleEN.memo && jsString_js_1.tzDataType.isString(pobjTopicUserRoleEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjTopicUserRoleEN.memo)], 非法，应该为字符型(In 主题用户角色(TopicUserRole))!(clsTopicUserRoleBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjTopicUserRoleEN.SetIsCheckProperty(true);
    }
    exports.TopicUserRole_CheckPropertyNew = TopicUserRole_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function TopicUserRole_CheckProperty4Update(pobjTopicUserRoleEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTopicUserRoleEN.topicUserRoleId) == false && (0, clsString_js_1.GetStrLen)(pobjTopicUserRoleEN.topicUserRoleId) > 4) {
            throw new Error("(errid:Watl000062)字段[主键Id(topicUserRoleId)]的长度不能超过4(In 主题用户角色(TopicUserRole))!值:$(pobjTopicUserRoleEN.topicUserRoleId)(clsTopicUserRoleBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTopicUserRoleEN.topicUserRoleName) == false && (0, clsString_js_1.GetStrLen)(pobjTopicUserRoleEN.topicUserRoleName) > 100) {
            throw new Error("(errid:Watl000062)字段[主题用户角色(topicUserRoleName)]的长度不能超过100(In 主题用户角色(TopicUserRole))!值:$(pobjTopicUserRoleEN.topicUserRoleName)(clsTopicUserRoleBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTopicUserRoleEN.updUserId) == false && (0, clsString_js_1.GetStrLen)(pobjTopicUserRoleEN.updUserId) > 20) {
            throw new Error("(errid:Watl000062)字段[修改用户Id(updUserId)]的长度不能超过20(In 主题用户角色(TopicUserRole))!值:$(pobjTopicUserRoleEN.updUserId)(clsTopicUserRoleBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTopicUserRoleEN.updDate) == false && (0, clsString_js_1.GetStrLen)(pobjTopicUserRoleEN.updDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 主题用户角色(TopicUserRole))!值:$(pobjTopicUserRoleEN.updDate)(clsTopicUserRoleBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTopicUserRoleEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjTopicUserRoleEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 主题用户角色(TopicUserRole))!值:$(pobjTopicUserRoleEN.memo)(clsTopicUserRoleBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTopicUserRoleEN.topicUserRoleId) == false && undefined !== pobjTopicUserRoleEN.topicUserRoleId && jsString_js_1.tzDataType.isString(pobjTopicUserRoleEN.topicUserRoleId) === false) {
            throw new Error("(errid:Watl000063)字段[主键Id(topicUserRoleId)]的值:[$(pobjTopicUserRoleEN.topicUserRoleId)], 非法，应该为字符型(In 主题用户角色(TopicUserRole))!(clsTopicUserRoleBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTopicUserRoleEN.topicUserRoleName) == false && undefined !== pobjTopicUserRoleEN.topicUserRoleName && jsString_js_1.tzDataType.isString(pobjTopicUserRoleEN.topicUserRoleName) === false) {
            throw new Error("(errid:Watl000063)字段[主题用户角色(topicUserRoleName)]的值:[$(pobjTopicUserRoleEN.topicUserRoleName)], 非法，应该为字符型(In 主题用户角色(TopicUserRole))!(clsTopicUserRoleBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTopicUserRoleEN.updUserId) == false && undefined !== pobjTopicUserRoleEN.updUserId && jsString_js_1.tzDataType.isString(pobjTopicUserRoleEN.updUserId) === false) {
            throw new Error("(errid:Watl000063)字段[修改用户Id(updUserId)]的值:[$(pobjTopicUserRoleEN.updUserId)], 非法，应该为字符型(In 主题用户角色(TopicUserRole))!(clsTopicUserRoleBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTopicUserRoleEN.updDate) == false && undefined !== pobjTopicUserRoleEN.updDate && jsString_js_1.tzDataType.isString(pobjTopicUserRoleEN.updDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjTopicUserRoleEN.updDate)], 非法，应该为字符型(In 主题用户角色(TopicUserRole))!(clsTopicUserRoleBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTopicUserRoleEN.memo) == false && undefined !== pobjTopicUserRoleEN.memo && jsString_js_1.tzDataType.isString(pobjTopicUserRoleEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjTopicUserRoleEN.memo)], 非法，应该为字符型(In 主题用户角色(TopicUserRole))!(clsTopicUserRoleBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTopicUserRoleEN.topicUserRoleId) === true) {
            throw new Error("(errid:Watl000064)字段[主键Id]不能为空(In 主题用户角色)!(clsTopicUserRoleBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjTopicUserRoleEN.SetIsCheckProperty(true);
    }
    exports.TopicUserRole_CheckProperty4Update = TopicUserRole_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function TopicUserRole_GetJSONStrByObj(pobjTopicUserRoleEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjTopicUserRoleEN.sf_UpdFldSetStr = pobjTopicUserRoleEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjTopicUserRoleEN);
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
    exports.TopicUserRole_GetJSONStrByObj = TopicUserRole_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function TopicUserRole_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrTopicUserRoleObjLst = new Array();
        if (strJSON === "") {
            return arrTopicUserRoleObjLst;
        }
        try {
            arrTopicUserRoleObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrTopicUserRoleObjLst;
        }
        return arrTopicUserRoleObjLst;
    }
    exports.TopicUserRole_GetObjLstByJSONStr = TopicUserRole_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrTopicUserRoleObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function TopicUserRole_GetObjLstByJSONObjLst(arrTopicUserRoleObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrTopicUserRoleObjLst = new Array();
        for (const objInFor of arrTopicUserRoleObjLstS) {
            const obj1 = TopicUserRole_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrTopicUserRoleObjLst.push(obj1);
        }
        return arrTopicUserRoleObjLst;
    }
    exports.TopicUserRole_GetObjLstByJSONObjLst = TopicUserRole_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function TopicUserRole_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjTopicUserRoleEN = new clsTopicUserRoleEN_js_1.clsTopicUserRoleEN();
        if (strJSON === "") {
            return pobjTopicUserRoleEN;
        }
        try {
            pobjTopicUserRoleEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjTopicUserRoleEN;
        }
        return pobjTopicUserRoleEN;
    }
    exports.TopicUserRole_GetObjByJSONStr = TopicUserRole_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function TopicUserRole_GetCombineCondition(objTopicUserRole_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objTopicUserRole_Cond.dicFldComparisonOp, clsTopicUserRoleEN_js_1.clsTopicUserRoleEN.con_TopicUserRoleId) == true) {
            const strComparisonOp_TopicUserRoleId = objTopicUserRole_Cond.dicFldComparisonOp[clsTopicUserRoleEN_js_1.clsTopicUserRoleEN.con_TopicUserRoleId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsTopicUserRoleEN_js_1.clsTopicUserRoleEN.con_TopicUserRoleId, objTopicUserRole_Cond.topicUserRoleId, strComparisonOp_TopicUserRoleId);
        }
        if (Object.prototype.hasOwnProperty.call(objTopicUserRole_Cond.dicFldComparisonOp, clsTopicUserRoleEN_js_1.clsTopicUserRoleEN.con_TopicUserRoleName) == true) {
            const strComparisonOp_TopicUserRoleName = objTopicUserRole_Cond.dicFldComparisonOp[clsTopicUserRoleEN_js_1.clsTopicUserRoleEN.con_TopicUserRoleName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsTopicUserRoleEN_js_1.clsTopicUserRoleEN.con_TopicUserRoleName, objTopicUserRole_Cond.topicUserRoleName, strComparisonOp_TopicUserRoleName);
        }
        if (Object.prototype.hasOwnProperty.call(objTopicUserRole_Cond.dicFldComparisonOp, clsTopicUserRoleEN_js_1.clsTopicUserRoleEN.con_UpdUserId) == true) {
            const strComparisonOp_UpdUserId = objTopicUserRole_Cond.dicFldComparisonOp[clsTopicUserRoleEN_js_1.clsTopicUserRoleEN.con_UpdUserId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsTopicUserRoleEN_js_1.clsTopicUserRoleEN.con_UpdUserId, objTopicUserRole_Cond.updUserId, strComparisonOp_UpdUserId);
        }
        if (Object.prototype.hasOwnProperty.call(objTopicUserRole_Cond.dicFldComparisonOp, clsTopicUserRoleEN_js_1.clsTopicUserRoleEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objTopicUserRole_Cond.dicFldComparisonOp[clsTopicUserRoleEN_js_1.clsTopicUserRoleEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsTopicUserRoleEN_js_1.clsTopicUserRoleEN.con_UpdDate, objTopicUserRole_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objTopicUserRole_Cond.dicFldComparisonOp, clsTopicUserRoleEN_js_1.clsTopicUserRoleEN.con_Memo) == true) {
            const strComparisonOp_Memo = objTopicUserRole_Cond.dicFldComparisonOp[clsTopicUserRoleEN_js_1.clsTopicUserRoleEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsTopicUserRoleEN_js_1.clsTopicUserRoleEN.con_Memo, objTopicUserRole_Cond.memo, strComparisonOp_Memo);
        }
        return strWhereCond;
    }
    exports.TopicUserRole_GetCombineCondition = TopicUserRole_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--TopicUserRole(主题用户角色),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param strTopicUserRoleId: 主键Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function TopicUserRole_GetUniCondStr_TopicUserRoleId(objTopicUserRoleEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and TopicUserRoleId = '{0}'", objTopicUserRoleEN.topicUserRoleId);
        return strWhereCond;
    }
    exports.TopicUserRole_GetUniCondStr_TopicUserRoleId = TopicUserRole_GetUniCondStr_TopicUserRoleId;
    /**
    *获取唯一性条件串(Uniqueness)--TopicUserRole(主题用户角色),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param strTopicUserRoleId: 主键Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function TopicUserRole_GetUniCondStr4Update_TopicUserRoleId(objTopicUserRoleEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and TopicUserRoleId <> '{0}'", objTopicUserRoleEN.topicUserRoleId);
        strWhereCond += (0, clsString_js_1.Format)(" and TopicUserRoleId = '{0}'", objTopicUserRoleEN.topicUserRoleId);
        return strWhereCond;
    }
    exports.TopicUserRole_GetUniCondStr4Update_TopicUserRoleId = TopicUserRole_GetUniCondStr4Update_TopicUserRoleId;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objTopicUserRoleENS:源对象
     * @param objTopicUserRoleENT:目标对象
    */
    function TopicUserRole_CopyObjTo(objTopicUserRoleENS, objTopicUserRoleENT) {
        objTopicUserRoleENT.topicUserRoleId = objTopicUserRoleENS.topicUserRoleId; //主键Id
        objTopicUserRoleENT.topicUserRoleName = objTopicUserRoleENS.topicUserRoleName; //主题用户角色
        objTopicUserRoleENT.updUserId = objTopicUserRoleENS.updUserId; //修改用户Id
        objTopicUserRoleENT.updDate = objTopicUserRoleENS.updDate; //修改日期
        objTopicUserRoleENT.memo = objTopicUserRoleENS.memo; //备注
        objTopicUserRoleENT.sf_UpdFldSetStr = objTopicUserRoleENS.updFldString; //sf_UpdFldSetStr
    }
    exports.TopicUserRole_CopyObjTo = TopicUserRole_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objTopicUserRoleENS:源对象
     * @param objTopicUserRoleENT:目标对象
    */
    function TopicUserRole_GetObjFromJsonObj(objTopicUserRoleENS) {
        const objTopicUserRoleENT = new clsTopicUserRoleEN_js_1.clsTopicUserRoleEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objTopicUserRoleENT, objTopicUserRoleENS);
        return objTopicUserRoleENT;
    }
    exports.TopicUserRole_GetObjFromJsonObj = TopicUserRole_GetObjFromJsonObj;
});
