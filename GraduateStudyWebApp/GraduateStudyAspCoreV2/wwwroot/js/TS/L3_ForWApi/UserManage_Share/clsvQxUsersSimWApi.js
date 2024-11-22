/**
* 类名:clsvQxUsersSimWApi
* 表名:vQxUsersSim(01120943)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/12 16:39:06
* 生成者:pyf
* 生成服务器IP:
工程名称:问卷调查(0112)
CM工程:游戏化教育平台(变量首字母小写)-全部函数集
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
        define(["require", "exports", "axios", "../../PubFun/enumComparisonOp.js", "../../PubFun/CacheHelper.js", "../../L0_Entity/UserManage_Share/clsvQxUsersSimEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.vQxUsersSim_GetObjFromJsonObj = exports.vQxUsersSim_CopyObjTo = exports.vQxUsersSim_GetCombineCondition = exports.vQxUsersSim_GetObjByJSONStr = exports.vQxUsersSim_GetObjLstByJSONObjLst = exports.vQxUsersSim_GetObjLstByJSONStr = exports.vQxUsersSim_GetJSONStrByObj = exports.vQxUsersSim_BindDdl_UserIdInDiv_Cache = exports.vQxUsersSim_ReFreshThisCache = exports.vQxUsersSim_GetWebApiUrl = exports.vQxUsersSim_GetRecCountByCond_Cache = exports.vQxUsersSim_GetRecCountByCondAsync = exports.vQxUsersSim_IsExistAsync = exports.vQxUsersSim_IsExist_Cache = exports.vQxUsersSim_IsExist = exports.vQxUsersSim_IsExistRecordAsync = exports.vQxUsersSim_IsExistRecord_Cache = exports.vQxUsersSim_GetObjLstByPagerAsync = exports.vQxUsersSim_GetObjLstByPager_Cache = exports.vQxUsersSim_GetObjLstByRange = exports.vQxUsersSim_GetObjLstByRangeAsync = exports.vQxUsersSim_GetTopObjLstAsync = exports.vQxUsersSim_GetObjLstByUserIdLst_Cache = exports.vQxUsersSim_GetObjLstByUserIdLstAsync = exports.vQxUsersSim_GetSubObjLst_Cache = exports.vQxUsersSim_GetObjLst_PureCache = exports.vQxUsersSim_GetObjLst_Cache = exports.vQxUsersSim_GetObjLst_sessionStorage_PureCache = exports.vQxUsersSim_GetObjLst_sessionStorage = exports.vQxUsersSim_GetObjLstAsync = exports.vQxUsersSim_GetObjLst_localStorage_PureCache = exports.vQxUsersSim_GetObjLst_localStorage = exports.vQxUsersSim_GetObjLst_ClientCache = exports.vQxUsersSim_GetFirstObjAsync = exports.vQxUsersSim_GetFirstID = exports.vQxUsersSim_GetFirstIDAsync = exports.vQxUsersSim_funcKey = exports.vQxUsersSim_FilterFunByKey = exports.vQxUsersSim_SortFunByKey = exports.vQxUsersSim_SortFun_Defa_2Fld = exports.vQxUsersSim_SortFun_Defa = exports.vQxUsersSim_func = exports.vQxUsersSim_GetNameByUserId_Cache = exports.vQxUsersSim_GetObjByUserId_localStorage = exports.vQxUsersSim_GetObjByUserId_Cache = exports.vQxUsersSim_GetObjByUserIdAsync = exports.vQxUsersSim_ConstructorName = exports.vQxUsersSim_Controller = void 0;
    /**
     * vQxUsersSim(vQxUsersSim)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月12日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const enumComparisonOp_js_1 = require("../../PubFun/enumComparisonOp.js");
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsvQxUsersSimEN_js_1 = require("../../L0_Entity/UserManage_Share/clsvQxUsersSimEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.vQxUsersSim_Controller = "vQxUsersSimApi";
    exports.vQxUsersSim_ConstructorName = "vQxUsersSim";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strUserId:关键字
    * @returns 对象
    **/
    async function vQxUsersSim_GetObjByUserIdAsync(strUserId) {
        const strThisFuncName = "GetObjByUserIdAsync";
        if ((0, clsString_js_1.IsNullOrEmpty)(strUserId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strUserId]不能为空！(In clsvQxUsersSimWApi.GetObjByUserIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByUserId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vQxUsersSim_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "strUserId": strUserId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    return null;
                }
                //console.log(returnObj);
                const objvQxUsersSim = vQxUsersSim_GetObjFromJsonObj(returnObj);
                return objvQxUsersSim;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vQxUsersSim_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vQxUsersSim_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vQxUsersSim_GetObjByUserIdAsync = vQxUsersSim_GetObjByUserIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param strUserId:所给的关键字
     * @returns 对象
    */
    async function vQxUsersSim_GetObjByUserId_Cache(strUserId, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByUserId_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strUserId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strUserId]不能为空！(In clsvQxUsersSimWApi.GetObjByUserId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        const arrvQxUsersSimObjLst_Cache = await vQxUsersSim_GetObjLst_Cache();
        try {
            const arrvQxUsersSim_Sel = arrvQxUsersSimObjLst_Cache.filter(x => x.userId == strUserId);
            let objvQxUsersSim;
            if (arrvQxUsersSim_Sel.length > 0) {
                objvQxUsersSim = arrvQxUsersSim_Sel[0];
                return objvQxUsersSim;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    const objvQxUsersSim_Const = await vQxUsersSim_GetObjByUserIdAsync(strUserId);
                    if (objvQxUsersSim_Const != null) {
                        vQxUsersSim_ReFreshThisCache();
                        return objvQxUsersSim_Const;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strUserId, exports.vQxUsersSim_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.vQxUsersSim_GetObjByUserId_Cache = vQxUsersSim_GetObjByUserId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param strUserId:所给的关键字
     * @returns 对象
    */
    async function vQxUsersSim_GetObjByUserId_localStorage(strUserId) {
        const strThisFuncName = "GetObjByUserId_localStorage";
        if ((0, clsString_js_1.IsNullOrEmpty)(strUserId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strUserId]不能为空！(In clsvQxUsersSimWApi.GetObjByUserId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvQxUsersSimEN_js_1.clsvQxUsersSimEN._CurrTabName, strUserId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objvQxUsersSim_Cache = JSON.parse(strTempObj);
            return objvQxUsersSim_Cache;
        }
        try {
            const objvQxUsersSim = await vQxUsersSim_GetObjByUserIdAsync(strUserId);
            if (objvQxUsersSim != null) {
                localStorage.setItem(strKey, JSON.stringify(objvQxUsersSim));
                const strInfo = (0, clsString_js_1.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objvQxUsersSim;
            }
            return objvQxUsersSim;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strUserId, exports.vQxUsersSim_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.vQxUsersSim_GetObjByUserId_localStorage = vQxUsersSim_GetObjByUserId_localStorage;
    /**
     * 根据关键字获取相关对象的名称属性, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetNameByKeyId_Cache)
     * @param strUserId:所给的关键字
     * @returns 对象
    */
    async function vQxUsersSim_GetNameByUserId_Cache(strUserId) {
        const strThisFuncName = "GetNameByUserId_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strUserId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strUserId]不能为空！(In clsvQxUsersSimWApi.GetNameByUserId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        const arrvQxUsersSimObjLst_Cache = await vQxUsersSim_GetObjLst_Cache();
        if (arrvQxUsersSimObjLst_Cache == null)
            return "";
        try {
            const arrvQxUsersSim_Sel = arrvQxUsersSimObjLst_Cache.filter(x => x.userId == strUserId);
            let objvQxUsersSim;
            if (arrvQxUsersSim_Sel.length > 0) {
                objvQxUsersSim = arrvQxUsersSim_Sel[0];
                return objvQxUsersSim.userName;
            }
            else {
                return "";
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象名称属性不成功!", e, strUserId);
            console.error(strMsg);
            alert(strMsg);
        }
        return "";
    }
    exports.vQxUsersSim_GetNameByUserId_Cache = vQxUsersSim_GetNameByUserId_Cache;
    /**
     * 映射函数。根据表映射把输入字段值，映射成输出字段值
     * 作者:pyf
     * 日期:2023-03-12
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_func)
     * @param strInFldName:输入字段名
     * @param strOutFldName:输出字段名
     * @param strInValue:输入字段值
     * @returns 返回一个输出字段值
    */
    async function vQxUsersSim_func(strInFldName, strOutFldName, strInValue) {
        //const strThisFuncName = "func";
        if (strInFldName != clsvQxUsersSimEN_js_1.clsvQxUsersSimEN.con_UserId) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsvQxUsersSimEN_js_1.clsvQxUsersSimEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_1.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strOutFldName, clsvQxUsersSimEN_js_1.clsvQxUsersSimEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUserId = strInValue;
        if ((0, clsString_js_1.IsNullOrEmpty)(strInValue) == true) {
            return "";
        }
        const objvQxUsersSim = await vQxUsersSim_GetObjByUserId_Cache(strUserId);
        if (objvQxUsersSim == null)
            return "";
        if (objvQxUsersSim.GetFldValue(strOutFldName) == null)
            return "";
        return objvQxUsersSim.GetFldValue(strOutFldName).toString();
    }
    exports.vQxUsersSim_func = vQxUsersSim_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-12
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vQxUsersSim_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.userId.localeCompare(b.userId);
    }
    exports.vQxUsersSim_SortFun_Defa = vQxUsersSim_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-12
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vQxUsersSim_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.userName == b.userName)
            return a.id_XzCollege.localeCompare(b.id_XzCollege);
        else
            return a.userName.localeCompare(b.userName);
    }
    exports.vQxUsersSim_SortFun_Defa_2Fld = vQxUsersSim_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-12
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vQxUsersSim_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsvQxUsersSimEN_js_1.clsvQxUsersSimEN.con_UserId:
                    return (a, b) => {
                        return a.userId.localeCompare(b.userId);
                    };
                case clsvQxUsersSimEN_js_1.clsvQxUsersSimEN.con_UserName:
                    return (a, b) => {
                        if (a.userName == null)
                            return -1;
                        if (b.userName == null)
                            return 1;
                        return a.userName.localeCompare(b.userName);
                    };
                case clsvQxUsersSimEN_js_1.clsvQxUsersSimEN.con_id_XzCollege:
                    return (a, b) => {
                        if (a.id_XzCollege == null)
                            return -1;
                        if (b.id_XzCollege == null)
                            return 1;
                        return a.id_XzCollege.localeCompare(b.id_XzCollege);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vQxUsersSim]中不存在！(in ${exports.vQxUsersSim_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsvQxUsersSimEN_js_1.clsvQxUsersSimEN.con_UserId:
                    return (a, b) => {
                        return b.userId.localeCompare(a.userId);
                    };
                case clsvQxUsersSimEN_js_1.clsvQxUsersSimEN.con_UserName:
                    return (a, b) => {
                        if (b.userName == null)
                            return -1;
                        if (a.userName == null)
                            return 1;
                        return b.userName.localeCompare(a.userName);
                    };
                case clsvQxUsersSimEN_js_1.clsvQxUsersSimEN.con_id_XzCollege:
                    return (a, b) => {
                        if (b.id_XzCollege == null)
                            return -1;
                        if (a.id_XzCollege == null)
                            return 1;
                        return b.id_XzCollege.localeCompare(a.id_XzCollege);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vQxUsersSim]中不存在！(in ${exports.vQxUsersSim_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.vQxUsersSim_SortFunByKey = vQxUsersSim_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-12
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function vQxUsersSim_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsvQxUsersSimEN_js_1.clsvQxUsersSimEN.con_UserId:
                return (obj) => {
                    return obj.userId === value;
                };
            case clsvQxUsersSimEN_js_1.clsvQxUsersSimEN.con_UserName:
                return (obj) => {
                    return obj.userName === value;
                };
            case clsvQxUsersSimEN_js_1.clsvQxUsersSimEN.con_id_XzCollege:
                return (obj) => {
                    return obj.id_XzCollege === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[vQxUsersSim]中不存在！(in ${exports.vQxUsersSim_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.vQxUsersSim_FilterFunByKey = vQxUsersSim_FilterFunByKey;
    /**
     * 映射函数。根据表映射把输入字段值，映射成输出字段值
     * 作者:pyf
     * 日期:2023-03-12
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_funcKey)
     * @param strInFldName:输入字段名
     * @param strInValue:输入字段值
     * @param strComparisonOp:比较操作符
     * @returns 返回一个关键字值列表
    */
    async function vQxUsersSim_funcKey(strInFldName, strInValue, strComparisonOp) {
        //const strThisFuncName = "funcKey";
        if (strInFldName == clsvQxUsersSimEN_js_1.clsvQxUsersSimEN.con_UserId) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(strInValue) == true) {
            return [];
        }
        const arrvQxUsersSim = await vQxUsersSim_GetObjLst_Cache();
        if (arrvQxUsersSim == null)
            return [];
        let arrvQxUsersSim_Sel = arrvQxUsersSim;
        const strType = typeof (strInValue);
        switch (strType) {
            case "string":
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01: // " = "
                        arrvQxUsersSim_Sel = arrvQxUsersSim_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.Like_03:
                        arrvQxUsersSim_Sel = arrvQxUsersSim_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.In_04:
                        const arrValues = strInValue.split(',');
                        arrvQxUsersSim_Sel = arrvQxUsersSim_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
                        break;
                }
                break;
            case "boolean":
                if (strInValue == null)
                    return [];
                if (strComparisonOp == enumComparisonOp_js_1.enumComparisonOp.Equal_01) {
                    arrvQxUsersSim_Sel = arrvQxUsersSim_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                }
                break;
            case "number":
                if (Number(strInValue) == 0)
                    return [];
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01:
                        arrvQxUsersSim_Sel = arrvQxUsersSim_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotEqual_02:
                        arrvQxUsersSim_Sel = arrvQxUsersSim_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotLessThan_05: //" >= ":
                        arrvQxUsersSim_Sel = arrvQxUsersSim_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotGreaterThan_06: //" <= ":
                        arrvQxUsersSim_Sel = arrvQxUsersSim_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.GreaterThan_07: //" > ":
                        arrvQxUsersSim_Sel = arrvQxUsersSim_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.LessThan_08: //" < ":
                        arrvQxUsersSim_Sel = arrvQxUsersSim_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                }
                break;
        }
        if (arrvQxUsersSim_Sel.length == 0)
            return [];
        return arrvQxUsersSim_Sel.map(x => x.userId);
    }
    exports.vQxUsersSim_funcKey = vQxUsersSim_funcKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function vQxUsersSim_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vQxUsersSim_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vQxUsersSim_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vQxUsersSim_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vQxUsersSim_GetFirstIDAsync = vQxUsersSim_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function vQxUsersSim_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vQxUsersSim_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vQxUsersSim_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vQxUsersSim_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vQxUsersSim_GetFirstID = vQxUsersSim_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function vQxUsersSim_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vQxUsersSim_Controller, strAction);
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
                const objvQxUsersSim = vQxUsersSim_GetObjFromJsonObj(returnObj);
                return objvQxUsersSim;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vQxUsersSim_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vQxUsersSim_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vQxUsersSim_GetFirstObjAsync = vQxUsersSim_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vQxUsersSim_GetObjLst_ClientCache() {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsvQxUsersSimEN_js_1.clsvQxUsersSimEN._CurrTabName;
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvQxUsersSimEN_js_1.clsvQxUsersSimEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvQxUsersSimEN_js_1.clsvQxUsersSimEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_1.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrvQxUsersSimExObjLst_Cache = CacheHelper_js_1.CacheHelper.Get(strKey);
            const arrvQxUsersSimObjLst_T = vQxUsersSim_GetObjLstByJSONObjLst(arrvQxUsersSimExObjLst_Cache);
            return arrvQxUsersSimObjLst_T;
        }
        try {
            const arrvQxUsersSimExObjLst = await vQxUsersSim_GetObjLstAsync(strWhereCond);
            CacheHelper_js_1.CacheHelper.Add(strKey, arrvQxUsersSimExObjLst);
            const strInfo = (0, clsString_js_1.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvQxUsersSimExObjLst.length);
            console.log(strInfo);
            return arrvQxUsersSimExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vQxUsersSim_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vQxUsersSim_GetObjLst_ClientCache = vQxUsersSim_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vQxUsersSim_GetObjLst_localStorage() {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsvQxUsersSimEN_js_1.clsvQxUsersSimEN._CurrTabName;
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvQxUsersSimEN_js_1.clsvQxUsersSimEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvQxUsersSimEN_js_1.clsvQxUsersSimEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrvQxUsersSimExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrvQxUsersSimObjLst_T = vQxUsersSim_GetObjLstByJSONObjLst(arrvQxUsersSimExObjLst_Cache);
            return arrvQxUsersSimObjLst_T;
        }
        try {
            const arrvQxUsersSimExObjLst = await vQxUsersSim_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrvQxUsersSimExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvQxUsersSimExObjLst.length);
            console.log(strInfo);
            return arrvQxUsersSimExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vQxUsersSim_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vQxUsersSim_GetObjLst_localStorage = vQxUsersSim_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vQxUsersSim_GetObjLst_localStorage_PureCache() {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsvQxUsersSimEN_js_1.clsvQxUsersSimEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrvQxUsersSimObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvQxUsersSimObjLst_Cache;
        }
        else
            return null;
    }
    exports.vQxUsersSim_GetObjLst_localStorage_PureCache = vQxUsersSim_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function vQxUsersSim_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vQxUsersSim_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vQxUsersSim_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vQxUsersSim_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vQxUsersSim_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vQxUsersSim_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vQxUsersSim_GetObjLstAsync = vQxUsersSim_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vQxUsersSim_GetObjLst_sessionStorage() {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsvQxUsersSimEN_js_1.clsvQxUsersSimEN._CurrTabName;
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvQxUsersSimEN_js_1.clsvQxUsersSimEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvQxUsersSimEN_js_1.clsvQxUsersSimEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrvQxUsersSimExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrvQxUsersSimObjLst_T = vQxUsersSim_GetObjLstByJSONObjLst(arrvQxUsersSimExObjLst_Cache);
            return arrvQxUsersSimObjLst_T;
        }
        try {
            const arrvQxUsersSimExObjLst = await vQxUsersSim_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrvQxUsersSimExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvQxUsersSimExObjLst.length);
            console.log(strInfo);
            return arrvQxUsersSimExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vQxUsersSim_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vQxUsersSim_GetObjLst_sessionStorage = vQxUsersSim_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vQxUsersSim_GetObjLst_sessionStorage_PureCache() {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsvQxUsersSimEN_js_1.clsvQxUsersSimEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrvQxUsersSimObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvQxUsersSimObjLst_Cache;
        }
        else
            return null;
    }
    exports.vQxUsersSim_GetObjLst_sessionStorage_PureCache = vQxUsersSim_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vQxUsersSim_GetObjLst_Cache() {
        //const strThisFuncName = "GetObjLst_Cache";
        let arrvQxUsersSimObjLst_Cache;
        switch (clsvQxUsersSimEN_js_1.clsvQxUsersSimEN.CacheModeId) {
            case "04": //sessionStorage
                arrvQxUsersSimObjLst_Cache = await vQxUsersSim_GetObjLst_sessionStorage();
                break;
            case "03": //localStorage
                arrvQxUsersSimObjLst_Cache = await vQxUsersSim_GetObjLst_localStorage();
                break;
            case "02": //ClientCache
                arrvQxUsersSimObjLst_Cache = await vQxUsersSim_GetObjLst_ClientCache();
                break;
            default:
                arrvQxUsersSimObjLst_Cache = await vQxUsersSim_GetObjLst_ClientCache();
                break;
        }
        const arrvQxUsersSimObjLst = vQxUsersSim_GetObjLstByJSONObjLst(arrvQxUsersSimObjLst_Cache);
        return arrvQxUsersSimObjLst_Cache;
    }
    exports.vQxUsersSim_GetObjLst_Cache = vQxUsersSim_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vQxUsersSim_GetObjLst_PureCache() {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrvQxUsersSimObjLst_Cache;
        switch (clsvQxUsersSimEN_js_1.clsvQxUsersSimEN.CacheModeId) {
            case "04": //sessionStorage
                arrvQxUsersSimObjLst_Cache = await vQxUsersSim_GetObjLst_sessionStorage_PureCache();
                break;
            case "03": //localStorage
                arrvQxUsersSimObjLst_Cache = await vQxUsersSim_GetObjLst_localStorage_PureCache();
                break;
            case "02": //ClientCache
                arrvQxUsersSimObjLst_Cache = null;
                break;
            default:
                arrvQxUsersSimObjLst_Cache = null;
                break;
        }
        return arrvQxUsersSimObjLst_Cache;
    }
    exports.vQxUsersSim_GetObjLst_PureCache = vQxUsersSim_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objstrUserId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function vQxUsersSim_GetSubObjLst_Cache(objvQxUsersSim_Cond) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrvQxUsersSimObjLst_Cache = await vQxUsersSim_GetObjLst_Cache();
        let arrvQxUsersSim_Sel = arrvQxUsersSimObjLst_Cache;
        if (objvQxUsersSim_Cond.sf_FldComparisonOp == null || objvQxUsersSim_Cond.sf_FldComparisonOp == "")
            return arrvQxUsersSim_Sel;
        const dicFldComparisonOp = JSON.parse(objvQxUsersSim_Cond.sf_FldComparisonOp);
        //console.log("clsvQxUsersSimWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvQxUsersSim_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvQxUsersSim_Sel = arrvQxUsersSim_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvQxUsersSim_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvQxUsersSim_Sel = arrvQxUsersSim_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvQxUsersSim_Sel = arrvQxUsersSim_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvQxUsersSim_Sel = arrvQxUsersSim_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvQxUsersSim_Sel = arrvQxUsersSim_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvQxUsersSim_Sel = arrvQxUsersSim_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvQxUsersSim_Sel = arrvQxUsersSim_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvQxUsersSim_Sel = arrvQxUsersSim_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvQxUsersSim_Sel = arrvQxUsersSim_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvQxUsersSim_Sel = arrvQxUsersSim_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvQxUsersSim_Sel = arrvQxUsersSim_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvQxUsersSim_Sel = arrvQxUsersSim_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvQxUsersSim_Sel = arrvQxUsersSim_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvQxUsersSim_Sel = arrvQxUsersSim_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrvQxUsersSim_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objvQxUsersSim_Cond), exports.vQxUsersSim_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vQxUsersSim_GetSubObjLst_Cache = vQxUsersSim_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrUserId:关键字列表
    * @returns 对象列表
    **/
    async function vQxUsersSim_GetObjLstByUserIdLstAsync(arrUserId) {
        const strThisFuncName = "GetObjLstByUserIdLstAsync";
        const strAction = "GetObjLstByUserIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vQxUsersSim_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrUserId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vQxUsersSim_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vQxUsersSim_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vQxUsersSim_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vQxUsersSim_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vQxUsersSim_GetObjLstByUserIdLstAsync = vQxUsersSim_GetObjLstByUserIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrstrUserIdLst:关键字列表
     * @returns 对象列表
    */
    async function vQxUsersSim_GetObjLstByUserIdLst_Cache(arrUserIdLst) {
        const strThisFuncName = "GetObjLstByUserIdLst_Cache";
        try {
            const arrvQxUsersSimObjLst_Cache = await vQxUsersSim_GetObjLst_Cache();
            const arrvQxUsersSim_Sel = arrvQxUsersSimObjLst_Cache.filter(x => arrUserIdLst.indexOf(x.userId) > -1);
            return arrvQxUsersSim_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrUserIdLst.join(","), exports.vQxUsersSim_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
    }
    exports.vQxUsersSim_GetObjLstByUserIdLst_Cache = vQxUsersSim_GetObjLstByUserIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function vQxUsersSim_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vQxUsersSim_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vQxUsersSim_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vQxUsersSim_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vQxUsersSim_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vQxUsersSim_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vQxUsersSim_GetTopObjLstAsync = vQxUsersSim_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vQxUsersSim_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vQxUsersSim_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vQxUsersSim_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vQxUsersSim_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vQxUsersSim_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vQxUsersSim_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vQxUsersSim_GetObjLstByRangeAsync = vQxUsersSim_GetObjLstByRangeAsync;
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
    async function vQxUsersSim_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vQxUsersSim_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vQxUsersSim_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vQxUsersSim_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vQxUsersSim_GetObjLstByRange = vQxUsersSim_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function vQxUsersSim_GetObjLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const arrvQxUsersSimObjLst_Cache = await vQxUsersSim_GetObjLst_Cache();
        if (arrvQxUsersSimObjLst_Cache.length == 0)
            return arrvQxUsersSimObjLst_Cache;
        let arrvQxUsersSim_Sel = arrvQxUsersSimObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objvQxUsersSim_Cond = new clsvQxUsersSimEN_js_1.clsvQxUsersSimEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvQxUsersSim_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsvQxUsersSimWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvQxUsersSim_Sel = arrvQxUsersSim_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvQxUsersSim_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvQxUsersSim_Sel = arrvQxUsersSim_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvQxUsersSim_Sel = arrvQxUsersSim_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvQxUsersSim_Sel = arrvQxUsersSim_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvQxUsersSim_Sel = arrvQxUsersSim_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvQxUsersSim_Sel = arrvQxUsersSim_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvQxUsersSim_Sel = arrvQxUsersSim_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvQxUsersSim_Sel = arrvQxUsersSim_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrvQxUsersSim_Sel = arrvQxUsersSim_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvQxUsersSim_Sel = arrvQxUsersSim_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvQxUsersSim_Sel = arrvQxUsersSim_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvQxUsersSim_Sel = arrvQxUsersSim_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvQxUsersSim_Sel = arrvQxUsersSim_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvQxUsersSim_Sel = arrvQxUsersSim_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvQxUsersSim_Sel = arrvQxUsersSim_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvQxUsersSim_Sel.length == 0)
                return arrvQxUsersSim_Sel;
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
                arrvQxUsersSim_Sel = arrvQxUsersSim_Sel.sort(vQxUsersSim_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrvQxUsersSim_Sel = arrvQxUsersSim_Sel.sort(objPagerPara.sortFun);
            }
            arrvQxUsersSim_Sel = arrvQxUsersSim_Sel.slice(intStart, intEnd);
            return arrvQxUsersSim_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.vQxUsersSim_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vQxUsersSim_GetObjLstByPager_Cache = vQxUsersSim_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vQxUsersSim_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vQxUsersSim_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vQxUsersSim_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vQxUsersSim_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vQxUsersSim_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vQxUsersSim_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vQxUsersSim_GetObjLstByPagerAsync = vQxUsersSim_GetObjLstByPagerAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objstrUserId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function vQxUsersSim_IsExistRecord_Cache(objvQxUsersSim_Cond) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrvQxUsersSimObjLst_Cache = await vQxUsersSim_GetObjLst_Cache();
        if (arrvQxUsersSimObjLst_Cache == null)
            return false;
        let arrvQxUsersSim_Sel = arrvQxUsersSimObjLst_Cache;
        if (objvQxUsersSim_Cond.sf_FldComparisonOp == null || objvQxUsersSim_Cond.sf_FldComparisonOp == "")
            return arrvQxUsersSim_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objvQxUsersSim_Cond.sf_FldComparisonOp);
        //console.log("clsvQxUsersSimWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvQxUsersSim_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvQxUsersSim_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvQxUsersSim_Sel = arrvQxUsersSim_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvQxUsersSim_Sel = arrvQxUsersSim_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvQxUsersSim_Sel = arrvQxUsersSim_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvQxUsersSim_Sel = arrvQxUsersSim_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvQxUsersSim_Sel = arrvQxUsersSim_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvQxUsersSim_Sel = arrvQxUsersSim_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvQxUsersSim_Sel = arrvQxUsersSim_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvQxUsersSim_Sel = arrvQxUsersSim_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvQxUsersSim_Sel = arrvQxUsersSim_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvQxUsersSim_Sel = arrvQxUsersSim_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvQxUsersSim_Sel = arrvQxUsersSim_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvQxUsersSim_Sel = arrvQxUsersSim_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvQxUsersSim_Sel = arrvQxUsersSim_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvQxUsersSim_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objvQxUsersSim_Cond), exports.vQxUsersSim_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.vQxUsersSim_IsExistRecord_Cache = vQxUsersSim_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function vQxUsersSim_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vQxUsersSim_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vQxUsersSim_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vQxUsersSim_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vQxUsersSim_IsExistRecordAsync = vQxUsersSim_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strUserId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function vQxUsersSim_IsExist(strUserId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vQxUsersSim_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "UserId": strUserId,
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vQxUsersSim_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vQxUsersSim_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vQxUsersSim_IsExist = vQxUsersSim_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param strUserId:所给的关键字
     * @returns 对象
    */
    async function vQxUsersSim_IsExist_Cache(strUserId) {
        const strThisFuncName = "IsExist_Cache";
        const arrvQxUsersSimObjLst_Cache = await vQxUsersSim_GetObjLst_Cache();
        if (arrvQxUsersSimObjLst_Cache == null)
            return false;
        try {
            const arrvQxUsersSim_Sel = arrvQxUsersSimObjLst_Cache.filter(x => x.userId == strUserId);
            if (arrvQxUsersSim_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strUserId, exports.vQxUsersSim_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.vQxUsersSim_IsExist_Cache = vQxUsersSim_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strUserId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function vQxUsersSim_IsExistAsync(strUserId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vQxUsersSim_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strUserId": strUserId }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vQxUsersSim_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vQxUsersSim_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vQxUsersSim_IsExistAsync = vQxUsersSim_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function vQxUsersSim_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vQxUsersSim_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vQxUsersSim_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vQxUsersSim_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vQxUsersSim_GetRecCountByCondAsync = vQxUsersSim_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objvQxUsersSim_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function vQxUsersSim_GetRecCountByCond_Cache(objvQxUsersSim_Cond) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrvQxUsersSimObjLst_Cache = await vQxUsersSim_GetObjLst_Cache();
        if (arrvQxUsersSimObjLst_Cache == null)
            return 0;
        let arrvQxUsersSim_Sel = arrvQxUsersSimObjLst_Cache;
        if (objvQxUsersSim_Cond.sf_FldComparisonOp == null || objvQxUsersSim_Cond.sf_FldComparisonOp == "")
            return arrvQxUsersSim_Sel.length;
        const dicFldComparisonOp = JSON.parse(objvQxUsersSim_Cond.sf_FldComparisonOp);
        //console.log("clsvQxUsersSimWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvQxUsersSim_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvQxUsersSim_Sel = arrvQxUsersSim_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvQxUsersSim_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvQxUsersSim_Sel = arrvQxUsersSim_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvQxUsersSim_Sel = arrvQxUsersSim_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvQxUsersSim_Sel = arrvQxUsersSim_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvQxUsersSim_Sel = arrvQxUsersSim_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvQxUsersSim_Sel = arrvQxUsersSim_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvQxUsersSim_Sel = arrvQxUsersSim_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvQxUsersSim_Sel = arrvQxUsersSim_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrvQxUsersSim_Sel = arrvQxUsersSim_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvQxUsersSim_Sel = arrvQxUsersSim_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvQxUsersSim_Sel = arrvQxUsersSim_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvQxUsersSim_Sel = arrvQxUsersSim_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvQxUsersSim_Sel = arrvQxUsersSim_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvQxUsersSim_Sel = arrvQxUsersSim_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvQxUsersSim_Sel = arrvQxUsersSim_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrvQxUsersSim_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objvQxUsersSim_Cond), exports.vQxUsersSim_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.vQxUsersSim_GetRecCountByCond_Cache = vQxUsersSim_GetRecCountByCond_Cache;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function vQxUsersSim_GetWebApiUrl(strController, strAction) {
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
    exports.vQxUsersSim_GetWebApiUrl = vQxUsersSim_GetWebApiUrl;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function vQxUsersSim_ReFreshThisCache() {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = clsvQxUsersSimEN_js_1.clsvQxUsersSimEN._CurrTabName;
            switch (clsvQxUsersSimEN_js_1.clsvQxUsersSimEN.CacheModeId) {
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
    exports.vQxUsersSim_ReFreshThisCache = vQxUsersSim_ReFreshThisCache;
    /**
     * 绑定基于Web的下拉框,在某一层下的下拉框
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunctionInDiv)
     * @param objDDL:需要绑定当前表的下拉框
    */
    async function vQxUsersSim_BindDdl_UserIdInDiv_Cache(strDivName, strDdlName) {
        const strThisFuncName = "BindDdl_UserIdInDiv_Cache";
        const objDdl = document.getElementById(strDdlName);
        if (objDdl == null) {
            const strMsg = (0, clsString_js_1.Format)("下拉框：{0} 不存在！(In BindDdl_UserIdInDiv)", strDdlName);
            alert(strMsg);
            console.error(strMsg);
            throw (strMsg);
        }
        //为数据源于表的下拉框设置内容
        //console.log("开始：BindDdl_UserIdInDiv_Cache");
        const arrObjLst_Sel = await vQxUsersSim_GetObjLst_Cache();
        if (arrObjLst_Sel == null)
            return;
        (0, clsCommFunc4Web_js_1.BindDdl_ObjLstInDiv_V)(strDivName, strDdlName, arrObjLst_Sel, clsvQxUsersSimEN_js_1.clsvQxUsersSimEN.con_UserId, clsvQxUsersSimEN_js_1.clsvQxUsersSimEN.con_UserName, "vQxUsersSim");
    }
    exports.vQxUsersSim_BindDdl_UserIdInDiv_Cache = vQxUsersSim_BindDdl_UserIdInDiv_Cache;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-03-12
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vQxUsersSim_GetJSONStrByObj(pobjvQxUsersSimEN) {
        const strThisFuncName = "GetJSONStrByObj";
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjvQxUsersSimEN);
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
    exports.vQxUsersSim_GetJSONStrByObj = vQxUsersSim_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-12
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function vQxUsersSim_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrvQxUsersSimObjLst = new Array();
        if (strJSON === "") {
            return arrvQxUsersSimObjLst;
        }
        try {
            arrvQxUsersSimObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrvQxUsersSimObjLst;
        }
        return arrvQxUsersSimObjLst;
    }
    exports.vQxUsersSim_GetObjLstByJSONStr = vQxUsersSim_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-12
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrvQxUsersSimObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function vQxUsersSim_GetObjLstByJSONObjLst(arrvQxUsersSimObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrvQxUsersSimObjLst = new Array();
        for (const objInFor of arrvQxUsersSimObjLstS) {
            const obj1 = vQxUsersSim_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrvQxUsersSimObjLst.push(obj1);
        }
        return arrvQxUsersSimObjLst;
    }
    exports.vQxUsersSim_GetObjLstByJSONObjLst = vQxUsersSim_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-12
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vQxUsersSim_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjvQxUsersSimEN = new clsvQxUsersSimEN_js_1.clsvQxUsersSimEN();
        if (strJSON === "") {
            return pobjvQxUsersSimEN;
        }
        try {
            pobjvQxUsersSimEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjvQxUsersSimEN;
        }
        return pobjvQxUsersSimEN;
    }
    exports.vQxUsersSim_GetObjByJSONStr = vQxUsersSim_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function vQxUsersSim_GetCombineCondition(objvQxUsersSim_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objvQxUsersSim_Cond.dicFldComparisonOp, clsvQxUsersSimEN_js_1.clsvQxUsersSimEN.con_UserId) == true) {
            const strComparisonOp_UserId = objvQxUsersSim_Cond.dicFldComparisonOp[clsvQxUsersSimEN_js_1.clsvQxUsersSimEN.con_UserId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQxUsersSimEN_js_1.clsvQxUsersSimEN.con_UserId, objvQxUsersSim_Cond.userId, strComparisonOp_UserId);
        }
        if (Object.prototype.hasOwnProperty.call(objvQxUsersSim_Cond.dicFldComparisonOp, clsvQxUsersSimEN_js_1.clsvQxUsersSimEN.con_UserName) == true) {
            const strComparisonOp_UserName = objvQxUsersSim_Cond.dicFldComparisonOp[clsvQxUsersSimEN_js_1.clsvQxUsersSimEN.con_UserName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQxUsersSimEN_js_1.clsvQxUsersSimEN.con_UserName, objvQxUsersSim_Cond.userName, strComparisonOp_UserName);
        }
        if (Object.prototype.hasOwnProperty.call(objvQxUsersSim_Cond.dicFldComparisonOp, clsvQxUsersSimEN_js_1.clsvQxUsersSimEN.con_id_XzCollege) == true) {
            const strComparisonOp_id_XzCollege = objvQxUsersSim_Cond.dicFldComparisonOp[clsvQxUsersSimEN_js_1.clsvQxUsersSimEN.con_id_XzCollege];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQxUsersSimEN_js_1.clsvQxUsersSimEN.con_id_XzCollege, objvQxUsersSim_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
        }
        return strWhereCond;
    }
    exports.vQxUsersSim_GetCombineCondition = vQxUsersSim_GetCombineCondition;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objvQxUsersSimENS:源对象
     * @param objvQxUsersSimENT:目标对象
    */
    function vQxUsersSim_CopyObjTo(objvQxUsersSimENS, objvQxUsersSimENT) {
        objvQxUsersSimENT.userId = objvQxUsersSimENS.userId; //用户ID
        objvQxUsersSimENT.userName = objvQxUsersSimENS.userName; //用户名
        objvQxUsersSimENT.id_XzCollege = objvQxUsersSimENS.id_XzCollege; //学院流水号
    }
    exports.vQxUsersSim_CopyObjTo = vQxUsersSim_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objvQxUsersSimENS:源对象
     * @param objvQxUsersSimENT:目标对象
    */
    function vQxUsersSim_GetObjFromJsonObj(objvQxUsersSimENS) {
        const objvQxUsersSimENT = new clsvQxUsersSimEN_js_1.clsvQxUsersSimEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvQxUsersSimENT, objvQxUsersSimENS);
        return objvQxUsersSimENT;
    }
    exports.vQxUsersSim_GetObjFromJsonObj = vQxUsersSim_GetObjFromJsonObj;
});
