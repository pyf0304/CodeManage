/**
* 类名:clsUserIdentityWApi
* 表名:UserIdentity(01120177)
* 生成代码版本:2022.11.02.1
* 生成日期:2022/11/02 11:45:57
* 生成者:pyf
* 生成服务器IP:
工程名称:问卷调查(0112)
CM工程:研究生论文学习(变量首字母小写)-全部函数集
* 相关数据库:103.116.76.183,9433EduHigh_Jsie
* PrjDataBaseId:0170
模块中文名:用户管理(UserManage)
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
        define(["require", "exports", "axios", "../../PubFun/CacheHelper.js", "../../L0_Entity/UserManage/clsUserIdentityEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsSysPara4WebApi.js", "../../PubFun/CacheHelper.js", "../../PubFun/jsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.UserIdentity_GetObjFromJsonObj = exports.UserIdentity_CopyObjTo = exports.UserIdentity_GetCombineCondition = exports.UserIdentity_GetObjByJSONStr = exports.UserIdentity_GetObjLstByJSONObjLst = exports.UserIdentity_GetObjLstByJSONStr = exports.UserIdentity_GetJSONStrByObj = exports.UserIdentity_CheckProperty4Update = exports.UserIdentity_CheckPropertyNew = exports.UserIdentity_BindDdl_IdentityIDInDiv_Cache = exports.UserIdentity_ReFreshThisCache = exports.UserIdentity_ReFreshCache = exports.UserIdentity_GetWebApiUrl = exports.UserIdentity_GetMaxStrIdByPrefix = exports.UserIdentity_GetRecCountByCond_Cache = exports.UserIdentity_GetRecCountByCondAsync = exports.UserIdentity_IsExistAsync = exports.UserIdentity_IsExist_Cache = exports.UserIdentity_IsExist = exports.UserIdentity_IsExistRecordAsync = exports.UserIdentity_IsExistRecord_Cache = exports.UserIdentity_UpdateWithConditionAsync = exports.UserIdentity_UpdateRecordAsync = exports.UserIdentity_AddNewRecordWithReturnKey = exports.UserIdentity_AddNewRecordWithReturnKeyAsync = exports.UserIdentity_AddNewRecordWithMaxIdAsync = exports.UserIdentity_AddNewRecordAsync = exports.UserIdentity_DelUserIdentitysByCondAsync = exports.UserIdentity_DelUserIdentitysAsync = exports.UserIdentity_DelRecordAsync = exports.UserIdentity_GetObjLstByPagerAsync = exports.UserIdentity_GetObjLstByPager_Cache = exports.UserIdentity_GetObjLstByRange = exports.UserIdentity_GetObjLstByRangeAsync = exports.UserIdentity_GetTopObjLstAsync = exports.UserIdentity_GetObjLstByIdentityIDLst_Cache = exports.UserIdentity_GetObjLstByIdentityIDLstAsync = exports.UserIdentity_GetSubObjLst_Cache = exports.UserIdentity_GetObjLst_PureCache = exports.UserIdentity_GetObjLst_Cache = exports.UserIdentity_GetObjLst_sessionStorage_PureCache = exports.UserIdentity_GetObjLst_sessionStorage = exports.UserIdentity_GetObjLstAsync = exports.UserIdentity_GetObjLst_localStorage_PureCache = exports.UserIdentity_GetObjLst_localStorage = exports.UserIdentity_GetObjLst_ClientCache = exports.UserIdentity_GetFirstObjAsync = exports.UserIdentity_GetFirstID = exports.UserIdentity_GetFirstIDAsync = exports.UserIdentity_FilterFunByKey = exports.UserIdentity_SortFunByKey = exports.UserIdentity_SortFun_Defa_2Fld = exports.UserIdentity_SortFun_Defa = exports.UserIdentity_func = exports.UserIdentity_GetNameByIdentityID_Cache = exports.UserIdentity_UpdateObjInLst_Cache = exports.UserIdentity_GetObjByIdentityID_localStorage = exports.UserIdentity_GetObjByIdentityID_Cache = exports.UserIdentity_GetObjByIdentityIDAsync = exports.userIdentity_ConstructorName = exports.userIdentity_Controller = void 0;
    /**
     * 用户身份(UserIdentity)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2022年11月02日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsUserIdentityEN_js_1 = require("../../L0_Entity/UserManage/clsUserIdentityEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    const CacheHelper_js_2 = require("../../PubFun/CacheHelper.js");
    const jsString_js_1 = require("../../PubFun/jsString.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.userIdentity_Controller = "UserIdentityApi";
    exports.userIdentity_ConstructorName = "userIdentity";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strIdentityID:关键字
    * @returns 对象
    **/
    async function UserIdentity_GetObjByIdentityIDAsync(strIdentityID) {
        const strThisFuncName = "GetObjByIdentityIDAsync";
        if ((0, clsString_js_1.IsNullOrEmpty)(strIdentityID) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strIdentityID]不能为空！(In GetObjByIdentityIDAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strIdentityID.length != 2) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strIdentityID]的长度:[{0}]不正确！", strIdentityID.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByIdentityID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.userIdentity_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "strIdentityID": strIdentityID,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.userIdentity_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objUserIdentity = UserIdentity_GetObjFromJsonObj(returnObj);
                return objUserIdentity;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.userIdentity_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.userIdentity_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.UserIdentity_GetObjByIdentityIDAsync = UserIdentity_GetObjByIdentityIDAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param strIdentityID:所给的关键字
     * @returns 对象
    */
    async function UserIdentity_GetObjByIdentityID_Cache(strIdentityID, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByIdentityID_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strIdentityID) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strIdentityID]不能为空！(In GetObjByIdentityID_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strIdentityID.length != 2) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strIdentityID]的长度:[{0}]不正确！", strIdentityID.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrUserIdentityObjLst_Cache = await UserIdentity_GetObjLst_Cache();
        try {
            const arrUserIdentity_Sel = arrUserIdentityObjLst_Cache.filter(x => x.identityID == strIdentityID);
            let objUserIdentity;
            if (arrUserIdentity_Sel.length > 0) {
                objUserIdentity = arrUserIdentity_Sel[0];
                return objUserIdentity;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    objUserIdentity = await UserIdentity_GetObjByIdentityIDAsync(strIdentityID);
                    if (objUserIdentity != null) {
                        UserIdentity_ReFreshThisCache();
                        return objUserIdentity;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strIdentityID, exports.userIdentity_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.UserIdentity_GetObjByIdentityID_Cache = UserIdentity_GetObjByIdentityID_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param strIdentityID:所给的关键字
     * @returns 对象
    */
    async function UserIdentity_GetObjByIdentityID_localStorage(strIdentityID) {
        const strThisFuncName = "GetObjByIdentityID_localStorage";
        if ((0, clsString_js_1.IsNullOrEmpty)(strIdentityID) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strIdentityID]不能为空！(In GetObjByIdentityID_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strIdentityID.length != 2) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strIdentityID]的长度:[{0}]不正确！", strIdentityID.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsUserIdentityEN_js_1.clsUserIdentityEN._CurrTabName, strIdentityID);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objUserIdentity_Cache = JSON.parse(strTempObj);
            return objUserIdentity_Cache;
        }
        try {
            const objUserIdentity = await UserIdentity_GetObjByIdentityIDAsync(strIdentityID);
            if (objUserIdentity != null) {
                localStorage.setItem(strKey, JSON.stringify(objUserIdentity));
                const strInfo = (0, clsString_js_1.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objUserIdentity;
            }
            return objUserIdentity;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strIdentityID, exports.userIdentity_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.UserIdentity_GetObjByIdentityID_localStorage = UserIdentity_GetObjByIdentityID_localStorage;
    /**
     * 修改在缓存对象列表中的对象, 与后台数据库无关.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
     * @param objUserIdentity:所给的对象
     * @returns 对象
    */
    async function UserIdentity_UpdateObjInLst_Cache(objUserIdentity) {
        const strThisFuncName = "UpdateObjInLst_Cache";
        try {
            const arrUserIdentityObjLst_Cache = await UserIdentity_GetObjLst_Cache();
            const obj = arrUserIdentityObjLst_Cache.find(x => x.identityID == objUserIdentity.identityID);
            if (obj != null) {
                objUserIdentity.identityID = obj.identityID;
                (0, clsCommFunc4Web_js_1.ObjectAssign)(obj, objUserIdentity);
            }
            else {
                arrUserIdentityObjLst_Cache.push(objUserIdentity);
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, exports.userIdentity_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.UserIdentity_UpdateObjInLst_Cache = UserIdentity_UpdateObjInLst_Cache;
    /**
     * 根据关键字获取相关对象的名称属性, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetNameByKeyId_Cache)
     * @param strIdentityID:所给的关键字
     * @returns 对象
    */
    async function UserIdentity_GetNameByIdentityID_Cache(strIdentityID) {
        const strThisFuncName = "GetNameByIdentityID_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strIdentityID) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strIdentityID]不能为空！(In GetNameByIdentityID_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strIdentityID.length != 2) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strIdentityID]的长度:[{0}]不正确！", strIdentityID.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrUserIdentityObjLst_Cache = await UserIdentity_GetObjLst_Cache();
        if (arrUserIdentityObjLst_Cache == null)
            return "";
        try {
            const arrUserIdentity_Sel = arrUserIdentityObjLst_Cache.filter(x => x.identityID == strIdentityID);
            let objUserIdentity;
            if (arrUserIdentity_Sel.length > 0) {
                objUserIdentity = arrUserIdentity_Sel[0];
                return objUserIdentity.identityDesc;
            }
            else {
                return "";
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象名称属性不成功!", e, strIdentityID);
            console.error(strMsg);
            alert(strMsg);
        }
        return "";
    }
    exports.UserIdentity_GetNameByIdentityID_Cache = UserIdentity_GetNameByIdentityID_Cache;
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
    async function UserIdentity_func(strInFldName, strOutFldName, strInValue) {
        //const strThisFuncName = "func";
        if (strInFldName != clsUserIdentityEN_js_1.clsUserIdentityEN.con_IdentityID) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsUserIdentityEN_js_1.clsUserIdentityEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_1.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strInFldName, clsUserIdentityEN_js_1.clsUserIdentityEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strIdentityID = strInValue;
        if ((0, clsString_js_1.IsNullOrEmpty)(strInValue) == true) {
            return "";
        }
        const objUserIdentity = await UserIdentity_GetObjByIdentityID_Cache(strIdentityID);
        if (objUserIdentity == null)
            return "";
        return objUserIdentity.GetFldValue(strOutFldName).toString();
    }
    exports.UserIdentity_func = UserIdentity_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function UserIdentity_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.identityID.localeCompare(b.identityID);
    }
    exports.UserIdentity_SortFun_Defa = UserIdentity_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function UserIdentity_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.identityDesc == b.identityDesc)
            return a.memo.localeCompare(b.memo);
        else
            return a.identityDesc.localeCompare(b.identityDesc);
    }
    exports.UserIdentity_SortFun_Defa_2Fld = UserIdentity_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function UserIdentity_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsUserIdentityEN_js_1.clsUserIdentityEN.con_IdentityID:
                    return (a, b) => {
                        return a.identityID.localeCompare(b.identityID);
                    };
                case clsUserIdentityEN_js_1.clsUserIdentityEN.con_IdentityDesc:
                    return (a, b) => {
                        return a.identityDesc.localeCompare(b.identityDesc);
                    };
                case clsUserIdentityEN_js_1.clsUserIdentityEN.con_Memo:
                    return (a, b) => {
                        return a.memo.localeCompare(b.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[UserIdentity]中不存在！(in ${exports.userIdentity_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsUserIdentityEN_js_1.clsUserIdentityEN.con_IdentityID:
                    return (a, b) => {
                        return b.identityID.localeCompare(a.identityID);
                    };
                case clsUserIdentityEN_js_1.clsUserIdentityEN.con_IdentityDesc:
                    return (a, b) => {
                        return b.identityDesc.localeCompare(a.identityDesc);
                    };
                case clsUserIdentityEN_js_1.clsUserIdentityEN.con_Memo:
                    return (a, b) => {
                        return b.memo.localeCompare(a.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[UserIdentity]中不存在！(in ${exports.userIdentity_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.UserIdentity_SortFunByKey = UserIdentity_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function UserIdentity_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsUserIdentityEN_js_1.clsUserIdentityEN.con_IdentityID:
                return (obj) => {
                    return obj.identityID === value;
                };
            case clsUserIdentityEN_js_1.clsUserIdentityEN.con_IdentityDesc:
                return (obj) => {
                    return obj.identityDesc === value;
                };
            case clsUserIdentityEN_js_1.clsUserIdentityEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[UserIdentity]中不存在！(in ${exports.userIdentity_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.UserIdentity_FilterFunByKey = UserIdentity_FilterFunByKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function UserIdentity_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.userIdentity_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.userIdentity_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.userIdentity_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.UserIdentity_GetFirstIDAsync = UserIdentity_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function UserIdentity_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.userIdentity_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.userIdentity_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.userIdentity_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.UserIdentity_GetFirstID = UserIdentity_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function UserIdentity_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.userIdentity_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.userIdentity_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objUserIdentity = UserIdentity_GetObjFromJsonObj(returnObj);
                return objUserIdentity;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.userIdentity_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.userIdentity_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.UserIdentity_GetFirstObjAsync = UserIdentity_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function UserIdentity_GetObjLst_ClientCache() {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsUserIdentityEN_js_1.clsUserIdentityEN._CurrTabName;
        clsUserIdentityEN_js_1.clsUserIdentityEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsUserIdentityEN_js_1.clsUserIdentityEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsUserIdentityEN_js_1.clsUserIdentityEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsUserIdentityEN_js_1.clsUserIdentityEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_2.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrUserIdentityExObjLst_Cache = CacheHelper_js_2.CacheHelper.Get(strKey);
            const arrUserIdentityObjLst_T = UserIdentity_GetObjLstByJSONObjLst(arrUserIdentityExObjLst_Cache);
            return arrUserIdentityObjLst_T;
        }
        try {
            const arrUserIdentityExObjLst = await UserIdentity_GetObjLstAsync(strWhereCond);
            CacheHelper_js_2.CacheHelper.Add(strKey, arrUserIdentityExObjLst);
            const strInfo = (0, clsString_js_1.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrUserIdentityExObjLst.length);
            console.log(strInfo);
            return arrUserIdentityExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.userIdentity_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.UserIdentity_GetObjLst_ClientCache = UserIdentity_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function UserIdentity_GetObjLst_localStorage() {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsUserIdentityEN_js_1.clsUserIdentityEN._CurrTabName;
        clsUserIdentityEN_js_1.clsUserIdentityEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsUserIdentityEN_js_1.clsUserIdentityEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsUserIdentityEN_js_1.clsUserIdentityEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsUserIdentityEN_js_1.clsUserIdentityEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrUserIdentityExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrUserIdentityObjLst_T = UserIdentity_GetObjLstByJSONObjLst(arrUserIdentityExObjLst_Cache);
            return arrUserIdentityObjLst_T;
        }
        try {
            const arrUserIdentityExObjLst = await UserIdentity_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrUserIdentityExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrUserIdentityExObjLst.length);
            console.log(strInfo);
            return arrUserIdentityExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.userIdentity_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.UserIdentity_GetObjLst_localStorage = UserIdentity_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function UserIdentity_GetObjLst_localStorage_PureCache() {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsUserIdentityEN_js_1.clsUserIdentityEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrUserIdentityObjLst_Cache = JSON.parse(strTempObjLst);
            return arrUserIdentityObjLst_Cache;
        }
        else
            return null;
    }
    exports.UserIdentity_GetObjLst_localStorage_PureCache = UserIdentity_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function UserIdentity_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.userIdentity_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.userIdentity_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = UserIdentity_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.userIdentity_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.userIdentity_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.UserIdentity_GetObjLstAsync = UserIdentity_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function UserIdentity_GetObjLst_sessionStorage() {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsUserIdentityEN_js_1.clsUserIdentityEN._CurrTabName;
        clsUserIdentityEN_js_1.clsUserIdentityEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsUserIdentityEN_js_1.clsUserIdentityEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsUserIdentityEN_js_1.clsUserIdentityEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsUserIdentityEN_js_1.clsUserIdentityEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrUserIdentityExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrUserIdentityObjLst_T = UserIdentity_GetObjLstByJSONObjLst(arrUserIdentityExObjLst_Cache);
            return arrUserIdentityObjLst_T;
        }
        try {
            const arrUserIdentityExObjLst = await UserIdentity_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrUserIdentityExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrUserIdentityExObjLst.length);
            console.log(strInfo);
            return arrUserIdentityExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.userIdentity_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.UserIdentity_GetObjLst_sessionStorage = UserIdentity_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function UserIdentity_GetObjLst_sessionStorage_PureCache() {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsUserIdentityEN_js_1.clsUserIdentityEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrUserIdentityObjLst_Cache = JSON.parse(strTempObjLst);
            return arrUserIdentityObjLst_Cache;
        }
        else
            return null;
    }
    exports.UserIdentity_GetObjLst_sessionStorage_PureCache = UserIdentity_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function UserIdentity_GetObjLst_Cache() {
        //const strThisFuncName = "GetObjLst_Cache";
        let arrUserIdentityObjLst_Cache;
        switch (clsUserIdentityEN_js_1.clsUserIdentityEN.CacheModeId) {
            case "04": //sessionStorage
                arrUserIdentityObjLst_Cache = await UserIdentity_GetObjLst_sessionStorage();
                break;
            case "03": //localStorage
                arrUserIdentityObjLst_Cache = await UserIdentity_GetObjLst_localStorage();
                break;
            case "02": //ClientCache
                arrUserIdentityObjLst_Cache = await UserIdentity_GetObjLst_ClientCache();
                break;
            default:
                arrUserIdentityObjLst_Cache = await UserIdentity_GetObjLst_ClientCache();
                break;
        }
        const arrUserIdentityObjLst = UserIdentity_GetObjLstByJSONObjLst(arrUserIdentityObjLst_Cache);
        return arrUserIdentityObjLst_Cache;
    }
    exports.UserIdentity_GetObjLst_Cache = UserIdentity_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function UserIdentity_GetObjLst_PureCache() {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrUserIdentityObjLst_Cache;
        switch (clsUserIdentityEN_js_1.clsUserIdentityEN.CacheModeId) {
            case "04": //sessionStorage
                arrUserIdentityObjLst_Cache = await UserIdentity_GetObjLst_sessionStorage_PureCache();
                break;
            case "03": //localStorage
                arrUserIdentityObjLst_Cache = await UserIdentity_GetObjLst_localStorage_PureCache();
                break;
            case "02": //ClientCache
                arrUserIdentityObjLst_Cache = null;
                break;
            default:
                arrUserIdentityObjLst_Cache = null;
                break;
        }
        return arrUserIdentityObjLst_Cache;
    }
    exports.UserIdentity_GetObjLst_PureCache = UserIdentity_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objstrIdentityID_Cond:条件对象
     * @returns 对象列表子集
    */
    async function UserIdentity_GetSubObjLst_Cache(objUserIdentity_Cond) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrUserIdentityObjLst_Cache = await UserIdentity_GetObjLst_Cache();
        let arrUserIdentity_Sel = arrUserIdentityObjLst_Cache;
        if (objUserIdentity_Cond.sf_FldComparisonOp == null || objUserIdentity_Cond.sf_FldComparisonOp == "")
            return arrUserIdentity_Sel;
        const dicFldComparisonOp = JSON.parse(objUserIdentity_Cond.sf_FldComparisonOp);
        //console.log("clsUserIdentityWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objUserIdentity_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrUserIdentity_Sel = arrUserIdentity_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objUserIdentity_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrUserIdentity_Sel = arrUserIdentity_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrUserIdentity_Sel = arrUserIdentity_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrUserIdentity_Sel = arrUserIdentity_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrUserIdentity_Sel = arrUserIdentity_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrUserIdentity_Sel = arrUserIdentity_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrUserIdentity_Sel = arrUserIdentity_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrUserIdentity_Sel = arrUserIdentity_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrUserIdentity_Sel = arrUserIdentity_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrUserIdentity_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objUserIdentity_Cond), exports.userIdentity_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.UserIdentity_GetSubObjLst_Cache = UserIdentity_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrIdentityID:关键字列表
    * @returns 对象列表
    **/
    async function UserIdentity_GetObjLstByIdentityIDLstAsync(arrIdentityID) {
        const strThisFuncName = "GetObjLstByIdentityIDLstAsync";
        const strAction = "GetObjLstByIdentityIDLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.userIdentity_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrIdentityID);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.userIdentity_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = UserIdentity_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.userIdentity_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.userIdentity_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.UserIdentity_GetObjLstByIdentityIDLstAsync = UserIdentity_GetObjLstByIdentityIDLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrstrIdentityIDLst:关键字列表
     * @returns 对象列表
    */
    async function UserIdentity_GetObjLstByIdentityIDLst_Cache(arrIdentityIDLst) {
        const strThisFuncName = "GetObjLstByIdentityIDLst_Cache";
        try {
            const arrUserIdentityObjLst_Cache = await UserIdentity_GetObjLst_Cache();
            const arrUserIdentity_Sel = arrUserIdentityObjLst_Cache.filter(x => arrIdentityIDLst.indexOf(x.identityID) > -1);
            return arrUserIdentity_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrIdentityIDLst.join(","), exports.userIdentity_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.UserIdentity_GetObjLstByIdentityIDLst_Cache = UserIdentity_GetObjLstByIdentityIDLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function UserIdentity_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.userIdentity_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.userIdentity_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = UserIdentity_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.userIdentity_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.userIdentity_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.UserIdentity_GetTopObjLstAsync = UserIdentity_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function UserIdentity_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.userIdentity_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.userIdentity_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = UserIdentity_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.userIdentity_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.userIdentity_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.UserIdentity_GetObjLstByRangeAsync = UserIdentity_GetObjLstByRangeAsync;
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
    async function UserIdentity_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.userIdentity_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.userIdentity_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.userIdentity_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.UserIdentity_GetObjLstByRange = UserIdentity_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function UserIdentity_GetObjLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const arrUserIdentityObjLst_Cache = await UserIdentity_GetObjLst_Cache();
        if (arrUserIdentityObjLst_Cache.length == 0)
            return arrUserIdentityObjLst_Cache;
        let arrUserIdentity_Sel = arrUserIdentityObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objUserIdentity_Cond = new clsUserIdentityEN_js_1.clsUserIdentityEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objUserIdentity_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsUserIdentityWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrUserIdentity_Sel = arrUserIdentity_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objUserIdentity_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrUserIdentity_Sel = arrUserIdentity_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrUserIdentity_Sel = arrUserIdentity_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrUserIdentity_Sel = arrUserIdentity_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrUserIdentity_Sel = arrUserIdentity_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrUserIdentity_Sel = arrUserIdentity_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrUserIdentity_Sel = arrUserIdentity_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrUserIdentity_Sel = arrUserIdentity_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrUserIdentity_Sel = arrUserIdentity_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrUserIdentity_Sel = arrUserIdentity_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrUserIdentity_Sel.length == 0)
                return arrUserIdentity_Sel;
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
                arrUserIdentity_Sel = arrUserIdentity_Sel.sort(UserIdentity_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrUserIdentity_Sel = arrUserIdentity_Sel.sort(objPagerPara.sortFun);
            }
            arrUserIdentity_Sel = arrUserIdentity_Sel.slice(intStart, intEnd);
            return arrUserIdentity_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.userIdentity_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.UserIdentity_GetObjLstByPager_Cache = UserIdentity_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function UserIdentity_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.userIdentity_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.userIdentity_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = UserIdentity_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.userIdentity_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.userIdentity_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.UserIdentity_GetObjLstByPagerAsync = UserIdentity_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param strIdentityID:关键字
    * @returns 获取删除的结果
    **/
    async function UserIdentity_DelRecordAsync(strIdentityID) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.userIdentity_Controller, strAction);
        strUrl = (0, clsString_js_1.Format)("{0}/?Id={1}", strUrl, strIdentityID);
        try {
            const response = await axios_1.default.delete(strUrl, {
                params: { "Id": strIdentityID, }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.userIdentity_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.userIdentity_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.UserIdentity_DelRecordAsync = UserIdentity_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrIdentityID:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function UserIdentity_DelUserIdentitysAsync(arrIdentityID) {
        const strThisFuncName = "DelUserIdentitysAsync";
        const strAction = "DelUserIdentitys";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.userIdentity_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrIdentityID);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.userIdentity_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.userIdentity_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.UserIdentity_DelUserIdentitysAsync = UserIdentity_DelUserIdentitysAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function UserIdentity_DelUserIdentitysByCondAsync(strWhereCond) {
        const strThisFuncName = "DelUserIdentitysByCondAsync";
        const strAction = "DelUserIdentitysByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.userIdentity_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.userIdentity_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.userIdentity_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.UserIdentity_DelUserIdentitysByCondAsync = UserIdentity_DelUserIdentitysByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objUserIdentityEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function UserIdentity_AddNewRecordAsync(objUserIdentityEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        if (objUserIdentityEN.identityID === null || objUserIdentityEN.identityID === "") {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            throw strMsg;
        }
        //var strJSON = JSON.stringify(objUserIdentityEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.userIdentity_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objUserIdentityEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.userIdentity_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.userIdentity_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.UserIdentity_AddNewRecordAsync = UserIdentity_AddNewRecordAsync;
    /**
    * 调用WebApi来添加记录，关键字用最大关键字，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithMaxIdAsync)
    * @param objUserIdentityEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function UserIdentity_AddNewRecordWithMaxIdAsync(objUserIdentityEN) {
        const strThisFuncName = "AddNewRecordWithMaxIdAsync";
        const strAction = "AddNewRecordWithMaxId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.userIdentity_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objUserIdentityEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.userIdentity_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.userIdentity_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.UserIdentity_AddNewRecordWithMaxIdAsync = UserIdentity_AddNewRecordWithMaxIdAsync;
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objUserIdentityEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function UserIdentity_AddNewRecordWithReturnKeyAsync(objUserIdentityEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.userIdentity_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objUserIdentityEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.userIdentity_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.userIdentity_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.UserIdentity_AddNewRecordWithReturnKeyAsync = UserIdentity_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objUserIdentityEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function UserIdentity_AddNewRecordWithReturnKey(objUserIdentityEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objUserIdentityEN.identityID === null || objUserIdentityEN.identityID === "") {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.userIdentity_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objUserIdentityEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.userIdentity_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.userIdentity_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.UserIdentity_AddNewRecordWithReturnKey = UserIdentity_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objUserIdentityEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function UserIdentity_UpdateRecordAsync(objUserIdentityEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objUserIdentityEN.sf_UpdFldSetStr === undefined || objUserIdentityEN.sf_UpdFldSetStr === null || objUserIdentityEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objUserIdentityEN.identityID);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.userIdentity_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objUserIdentityEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.userIdentity_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.userIdentity_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.UserIdentity_UpdateRecordAsync = UserIdentity_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objUserIdentityEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function UserIdentity_UpdateWithConditionAsync(objUserIdentityEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objUserIdentityEN.sf_UpdFldSetStr === undefined || objUserIdentityEN.sf_UpdFldSetStr === null || objUserIdentityEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objUserIdentityEN.identityID);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.userIdentity_Controller, strAction);
        objUserIdentityEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objUserIdentityEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.userIdentity_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.userIdentity_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.UserIdentity_UpdateWithConditionAsync = UserIdentity_UpdateWithConditionAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objstrIdentityID_Cond:条件对象
     * @returns 对象列表子集
    */
    async function UserIdentity_IsExistRecord_Cache(objUserIdentity_Cond) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrUserIdentityObjLst_Cache = await UserIdentity_GetObjLst_Cache();
        if (arrUserIdentityObjLst_Cache == null)
            return false;
        let arrUserIdentity_Sel = arrUserIdentityObjLst_Cache;
        if (objUserIdentity_Cond.sf_FldComparisonOp == null || objUserIdentity_Cond.sf_FldComparisonOp == "")
            return arrUserIdentity_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objUserIdentity_Cond.sf_FldComparisonOp);
        //console.log("clsUserIdentityWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objUserIdentity_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objUserIdentity_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrUserIdentity_Sel = arrUserIdentity_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrUserIdentity_Sel = arrUserIdentity_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrUserIdentity_Sel = arrUserIdentity_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrUserIdentity_Sel = arrUserIdentity_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrUserIdentity_Sel = arrUserIdentity_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrUserIdentity_Sel = arrUserIdentity_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrUserIdentity_Sel = arrUserIdentity_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrUserIdentity_Sel = arrUserIdentity_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrUserIdentity_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objUserIdentity_Cond), exports.userIdentity_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.UserIdentity_IsExistRecord_Cache = UserIdentity_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function UserIdentity_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.userIdentity_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.userIdentity_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.userIdentity_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.UserIdentity_IsExistRecordAsync = UserIdentity_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strIdentityID:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function UserIdentity_IsExist(strIdentityID, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.userIdentity_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "IdentityID": strIdentityID,
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.userIdentity_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.userIdentity_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.UserIdentity_IsExist = UserIdentity_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param strIdentityID:所给的关键字
     * @returns 对象
    */
    async function UserIdentity_IsExist_Cache(strIdentityID) {
        const strThisFuncName = "IsExist_Cache";
        const arrUserIdentityObjLst_Cache = await UserIdentity_GetObjLst_Cache();
        if (arrUserIdentityObjLst_Cache == null)
            return false;
        try {
            const arrUserIdentity_Sel = arrUserIdentityObjLst_Cache.filter(x => x.identityID == strIdentityID);
            if (arrUserIdentity_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strIdentityID, exports.userIdentity_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.UserIdentity_IsExist_Cache = UserIdentity_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strIdentityID:关键字
    * @returns 是否存在?存在返回True
    **/
    async function UserIdentity_IsExistAsync(strIdentityID) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.userIdentity_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strIdentityID": strIdentityID }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.userIdentity_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.userIdentity_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.UserIdentity_IsExistAsync = UserIdentity_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function UserIdentity_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.userIdentity_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.userIdentity_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.userIdentity_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.UserIdentity_GetRecCountByCondAsync = UserIdentity_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objUserIdentity_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function UserIdentity_GetRecCountByCond_Cache(objUserIdentity_Cond) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrUserIdentityObjLst_Cache = await UserIdentity_GetObjLst_Cache();
        if (arrUserIdentityObjLst_Cache == null)
            return 0;
        let arrUserIdentity_Sel = arrUserIdentityObjLst_Cache;
        if (objUserIdentity_Cond.sf_FldComparisonOp == null || objUserIdentity_Cond.sf_FldComparisonOp == "")
            return arrUserIdentity_Sel.length;
        const dicFldComparisonOp = JSON.parse(objUserIdentity_Cond.sf_FldComparisonOp);
        //console.log("clsUserIdentityWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objUserIdentity_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrUserIdentity_Sel = arrUserIdentity_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objUserIdentity_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrUserIdentity_Sel = arrUserIdentity_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrUserIdentity_Sel = arrUserIdentity_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrUserIdentity_Sel = arrUserIdentity_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrUserIdentity_Sel = arrUserIdentity_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrUserIdentity_Sel = arrUserIdentity_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrUserIdentity_Sel = arrUserIdentity_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrUserIdentity_Sel = arrUserIdentity_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrUserIdentity_Sel = arrUserIdentity_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrUserIdentity_Sel = arrUserIdentity_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrUserIdentity_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objUserIdentity_Cond), exports.userIdentity_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.UserIdentity_GetRecCountByCond_Cache = UserIdentity_GetRecCountByCond_Cache;
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
    async function UserIdentity_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.userIdentity_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.userIdentity_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.userIdentity_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.UserIdentity_GetMaxStrIdByPrefix = UserIdentity_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function UserIdentity_GetWebApiUrl(strController, strAction) {
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
    exports.UserIdentity_GetWebApiUrl = UserIdentity_GetWebApiUrl;
    /**
    * 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshCache)
    **/
    function UserIdentity_ReFreshCache() {
        const strThisFuncName = "ReFreshCache";
        const strMsg = (0, clsString_js_1.Format)("刷新缓存成功！");
        console.trace(strMsg);
        // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
        const strKey = clsUserIdentityEN_js_1.clsUserIdentityEN._CurrTabName;
        switch (clsUserIdentityEN_js_1.clsUserIdentityEN.CacheModeId) {
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
    exports.UserIdentity_ReFreshCache = UserIdentity_ReFreshCache;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function UserIdentity_ReFreshThisCache() {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = clsUserIdentityEN_js_1.clsUserIdentityEN._CurrTabName;
            switch (clsUserIdentityEN_js_1.clsUserIdentityEN.CacheModeId) {
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
    exports.UserIdentity_ReFreshThisCache = UserIdentity_ReFreshThisCache;
    /**
     * 绑定基于Web的下拉框,在某一层下的下拉框
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunctionInDiv)
     * @param objDDL:需要绑定当前表的下拉框
    */
    async function UserIdentity_BindDdl_IdentityIDInDiv_Cache(strDivName, strDdlName) {
        const strThisFuncName = "BindDdl_IdentityIDInDiv_Cache";
        const objDdl = document.getElementById(strDdlName);
        if (objDdl == null) {
            const strMsg = (0, clsString_js_1.Format)("下拉框：{0} 不存在！(In BindDdl_IdentityIDInDiv)", strDdlName);
            alert(strMsg);
            console.error(strMsg);
            throw (strMsg);
        }
        //为数据源于表的下拉框设置内容
        //console.log("开始：BindDdl_IdentityIDInDiv_Cache");
        const arrObjLst_Sel = await UserIdentity_GetObjLst_Cache();
        if (arrObjLst_Sel == null)
            return;
        (0, clsCommFunc4Web_js_1.BindDdl_ObjLstInDiv)(strDivName, strDdlName, arrObjLst_Sel, clsUserIdentityEN_js_1.clsUserIdentityEN.con_IdentityID, clsUserIdentityEN_js_1.clsUserIdentityEN.con_IdentityDesc, "用户身份");
    }
    exports.UserIdentity_BindDdl_IdentityIDInDiv_Cache = UserIdentity_BindDdl_IdentityIDInDiv_Cache;
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function UserIdentity_CheckPropertyNew(pobjUserIdentityEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUserIdentityEN.identityDesc) === true) {
            throw new Error("(errid:Watl000058)字段[身份描述]不能为空(In 用户身份)!(clsUserIdentityBL:CheckPropertyNew)");
        }
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUserIdentityEN.identityID) == false && (0, clsString_js_1.GetStrLen)(pobjUserIdentityEN.identityID) > 2) {
            throw new Error("(errid:Watl000059)字段[身份编号(identityID)]的长度不能超过2(In 用户身份(UserIdentity))!值:$(pobjUserIdentityEN.identityID)(clsUserIdentityBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUserIdentityEN.identityDesc) == false && (0, clsString_js_1.GetStrLen)(pobjUserIdentityEN.identityDesc) > 20) {
            throw new Error("(errid:Watl000059)字段[身份描述(identityDesc)]的长度不能超过20(In 用户身份(UserIdentity))!值:$(pobjUserIdentityEN.identityDesc)(clsUserIdentityBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUserIdentityEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjUserIdentityEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 用户身份(UserIdentity))!值:$(pobjUserIdentityEN.memo)(clsUserIdentityBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUserIdentityEN.identityID) == false && undefined !== pobjUserIdentityEN.identityID && jsString_js_1.tzDataType.isString(pobjUserIdentityEN.identityID) === false) {
            throw new Error("(errid:Watl000060)字段[身份编号(identityID)]的值:[$(pobjUserIdentityEN.identityID)], 非法，应该为字符型(In 用户身份(UserIdentity))!(clsUserIdentityBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUserIdentityEN.identityDesc) == false && undefined !== pobjUserIdentityEN.identityDesc && jsString_js_1.tzDataType.isString(pobjUserIdentityEN.identityDesc) === false) {
            throw new Error("(errid:Watl000060)字段[身份描述(identityDesc)]的值:[$(pobjUserIdentityEN.identityDesc)], 非法，应该为字符型(In 用户身份(UserIdentity))!(clsUserIdentityBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUserIdentityEN.memo) == false && undefined !== pobjUserIdentityEN.memo && jsString_js_1.tzDataType.isString(pobjUserIdentityEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjUserIdentityEN.memo)], 非法，应该为字符型(In 用户身份(UserIdentity))!(clsUserIdentityBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjUserIdentityEN.SetIsCheckProperty(true);
    }
    exports.UserIdentity_CheckPropertyNew = UserIdentity_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function UserIdentity_CheckProperty4Update(pobjUserIdentityEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUserIdentityEN.identityID) == false && (0, clsString_js_1.GetStrLen)(pobjUserIdentityEN.identityID) > 2) {
            throw new Error("(errid:Watl000062)字段[身份编号(identityID)]的长度不能超过2(In 用户身份(UserIdentity))!值:$(pobjUserIdentityEN.identityID)(clsUserIdentityBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUserIdentityEN.identityDesc) == false && (0, clsString_js_1.GetStrLen)(pobjUserIdentityEN.identityDesc) > 20) {
            throw new Error("(errid:Watl000062)字段[身份描述(identityDesc)]的长度不能超过20(In 用户身份(UserIdentity))!值:$(pobjUserIdentityEN.identityDesc)(clsUserIdentityBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUserIdentityEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjUserIdentityEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 用户身份(UserIdentity))!值:$(pobjUserIdentityEN.memo)(clsUserIdentityBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUserIdentityEN.identityID) == false && undefined !== pobjUserIdentityEN.identityID && jsString_js_1.tzDataType.isString(pobjUserIdentityEN.identityID) === false) {
            throw new Error("(errid:Watl000063)字段[身份编号(identityID)]的值:[$(pobjUserIdentityEN.identityID)], 非法，应该为字符型(In 用户身份(UserIdentity))!(clsUserIdentityBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUserIdentityEN.identityDesc) == false && undefined !== pobjUserIdentityEN.identityDesc && jsString_js_1.tzDataType.isString(pobjUserIdentityEN.identityDesc) === false) {
            throw new Error("(errid:Watl000063)字段[身份描述(identityDesc)]的值:[$(pobjUserIdentityEN.identityDesc)], 非法，应该为字符型(In 用户身份(UserIdentity))!(clsUserIdentityBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUserIdentityEN.memo) == false && undefined !== pobjUserIdentityEN.memo && jsString_js_1.tzDataType.isString(pobjUserIdentityEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjUserIdentityEN.memo)], 非法，应该为字符型(In 用户身份(UserIdentity))!(clsUserIdentityBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUserIdentityEN.identityID) === true
            || pobjUserIdentityEN.identityID.toString() === "0") {
            throw new Error("(errid:Watl000064)字段[身份编号]不能为空(In 用户身份)!(clsUserIdentityBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjUserIdentityEN.SetIsCheckProperty(true);
    }
    exports.UserIdentity_CheckProperty4Update = UserIdentity_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function UserIdentity_GetJSONStrByObj(pobjUserIdentityEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjUserIdentityEN.sf_UpdFldSetStr = pobjUserIdentityEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjUserIdentityEN);
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
    exports.UserIdentity_GetJSONStrByObj = UserIdentity_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function UserIdentity_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrUserIdentityObjLst = new Array();
        if (strJSON === "") {
            return arrUserIdentityObjLst;
        }
        try {
            arrUserIdentityObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrUserIdentityObjLst;
        }
        return arrUserIdentityObjLst;
    }
    exports.UserIdentity_GetObjLstByJSONStr = UserIdentity_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrUserIdentityObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function UserIdentity_GetObjLstByJSONObjLst(arrUserIdentityObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrUserIdentityObjLst = new Array();
        for (const objInFor of arrUserIdentityObjLstS) {
            const obj1 = UserIdentity_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrUserIdentityObjLst.push(obj1);
        }
        return arrUserIdentityObjLst;
    }
    exports.UserIdentity_GetObjLstByJSONObjLst = UserIdentity_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function UserIdentity_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjUserIdentityEN = new clsUserIdentityEN_js_1.clsUserIdentityEN();
        if (strJSON === "") {
            return pobjUserIdentityEN;
        }
        try {
            pobjUserIdentityEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjUserIdentityEN;
        }
        return pobjUserIdentityEN;
    }
    exports.UserIdentity_GetObjByJSONStr = UserIdentity_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function UserIdentity_GetCombineCondition(objUserIdentity_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objUserIdentity_Cond.dicFldComparisonOp, clsUserIdentityEN_js_1.clsUserIdentityEN.con_IdentityID) == true) {
            const strComparisonOp_IdentityID = objUserIdentity_Cond.dicFldComparisonOp[clsUserIdentityEN_js_1.clsUserIdentityEN.con_IdentityID];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsUserIdentityEN_js_1.clsUserIdentityEN.con_IdentityID, objUserIdentity_Cond.identityID, strComparisonOp_IdentityID);
        }
        if (Object.prototype.hasOwnProperty.call(objUserIdentity_Cond.dicFldComparisonOp, clsUserIdentityEN_js_1.clsUserIdentityEN.con_IdentityDesc) == true) {
            const strComparisonOp_IdentityDesc = objUserIdentity_Cond.dicFldComparisonOp[clsUserIdentityEN_js_1.clsUserIdentityEN.con_IdentityDesc];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsUserIdentityEN_js_1.clsUserIdentityEN.con_IdentityDesc, objUserIdentity_Cond.identityDesc, strComparisonOp_IdentityDesc);
        }
        if (Object.prototype.hasOwnProperty.call(objUserIdentity_Cond.dicFldComparisonOp, clsUserIdentityEN_js_1.clsUserIdentityEN.con_Memo) == true) {
            const strComparisonOp_Memo = objUserIdentity_Cond.dicFldComparisonOp[clsUserIdentityEN_js_1.clsUserIdentityEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsUserIdentityEN_js_1.clsUserIdentityEN.con_Memo, objUserIdentity_Cond.memo, strComparisonOp_Memo);
        }
        return strWhereCond;
    }
    exports.UserIdentity_GetCombineCondition = UserIdentity_GetCombineCondition;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objUserIdentityENS:源对象
     * @param objUserIdentityENT:目标对象
    */
    function UserIdentity_CopyObjTo(objUserIdentityENS, objUserIdentityENT) {
        objUserIdentityENT.identityID = objUserIdentityENS.identityID; //身份编号
        objUserIdentityENT.identityDesc = objUserIdentityENS.identityDesc; //身份描述
        objUserIdentityENT.memo = objUserIdentityENS.memo; //备注
        objUserIdentityENT.sf_UpdFldSetStr = objUserIdentityENS.updFldString; //sf_UpdFldSetStr
    }
    exports.UserIdentity_CopyObjTo = UserIdentity_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objUserIdentityENS:源对象
     * @param objUserIdentityENT:目标对象
    */
    function UserIdentity_GetObjFromJsonObj(objUserIdentityENS) {
        const objUserIdentityENT = new clsUserIdentityEN_js_1.clsUserIdentityEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objUserIdentityENT, objUserIdentityENS);
        return objUserIdentityENT;
    }
    exports.UserIdentity_GetObjFromJsonObj = UserIdentity_GetObjFromJsonObj;
});
