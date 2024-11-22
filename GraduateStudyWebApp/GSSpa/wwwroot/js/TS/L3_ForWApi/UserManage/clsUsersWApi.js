/**
* 类名:clsUsersWApi
* 表名:Users(01120034)
* 生成代码版本:2022.11.02.1
* 生成日期:2022/11/02 11:45:58
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
        define(["require", "exports", "axios", "../../PubFun/CacheHelper.js", "../../L0_Entity/UserManage/clsUsersEN.js", "../../L3_ForWApi/UserManage/clsvUsersWApi.js", "../../L3_ForWApi/UserManage/clsvUsersSimWApi.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsSysPara4WebApi.js", "../../PubFun/CacheHelper.js", "../../PubFun/jsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.Users_GetObjFromJsonObj = exports.Users_CopyObjTo = exports.Users_GetCombineCondition = exports.Users_GetObjByJSONStr = exports.Users_GetObjLstByJSONObjLst = exports.Users_GetObjLstByJSONStr = exports.Users_GetJSONStrByObj = exports.Users_CheckProperty4Update = exports.Users_CheckPropertyNew = exports.Users__Cache = exports.Users_ReFreshThisCache = exports.Users_ReFreshCache = exports.Users_GetWebApiUrl = exports.Users_GetMaxStrIdByPrefix = exports.Users_GetRecCountByCond_Cache = exports.Users_GetRecCountByCondAsync = exports.Users_IsExistAsync = exports.Users_IsExist_Cache = exports.Users_IsExist = exports.Users_IsExistRecordAsync = exports.Users_IsExistRecord_Cache = exports.Users_UpdateWithConditionAsync = exports.Users_UpdateRecordAsync = exports.Users_AddNewRecordWithReturnKey = exports.Users_AddNewRecordWithReturnKeyAsync = exports.Users_AddNewRecordWithMaxIdAsync = exports.Users_AddNewRecordAsync = exports.Users_DelUserssByCondAsync = exports.Users_DelUserssAsync = exports.Users_DelRecordAsync = exports.Users_GetObjLstByPagerAsync = exports.Users_GetObjLstByPager_Cache = exports.Users_GetObjLstByRange = exports.Users_GetObjLstByRangeAsync = exports.Users_GetTopObjLstAsync = exports.Users_GetObjLstByUserIdLst_Cache = exports.Users_GetObjLstByUserIdLstAsync = exports.Users_GetSubObjLst_Cache = exports.Users_GetObjLst_PureCache = exports.Users_GetObjLst_Cache = exports.Users_GetObjLst_sessionStorage_PureCache = exports.Users_GetObjLst_sessionStorage = exports.Users_GetObjLstAsync = exports.Users_GetObjLst_localStorage_PureCache = exports.Users_GetObjLst_localStorage = exports.Users_GetObjLst_ClientCache = exports.Users_GetFirstObjAsync = exports.Users_GetFirstID = exports.Users_GetFirstIDAsync = exports.Users_FilterFunByKey = exports.Users_SortFunByKey = exports.Users_SortFun_Defa_2Fld = exports.Users_SortFun_Defa = exports.Users_func = exports.Users_GetNameByUserId_Cache = exports.Users_UpdateObjInLst_Cache = exports.Users_GetObjByUserId_localStorage = exports.Users_GetObjByUserId_Cache = exports.Users_GetObjByUserIdAsync = exports.users_ConstructorName = exports.users_Controller = void 0;
    /**
     * 用户(Users)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2022年11月02日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsUsersEN_js_1 = require("../../L0_Entity/UserManage/clsUsersEN.js");
    const clsvUsersWApi_js_1 = require("../../L3_ForWApi/UserManage/clsvUsersWApi.js");
    const clsvUsersSimWApi_js_1 = require("../../L3_ForWApi/UserManage/clsvUsersSimWApi.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    const CacheHelper_js_2 = require("../../PubFun/CacheHelper.js");
    const jsString_js_1 = require("../../PubFun/jsString.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.users_Controller = "UsersApi";
    exports.users_ConstructorName = "users";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strUserId:关键字
    * @returns 对象
    **/
    async function Users_GetObjByUserIdAsync(strUserId) {
        const strThisFuncName = "GetObjByUserIdAsync";
        if ((0, clsString_js_1.IsNullOrEmpty)(strUserId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strUserId]不能为空！(In GetObjByUserIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strUserId.length != 20) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strUserId]的长度:[{0}]不正确！", strUserId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByUserId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.users_Controller, strAction);
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
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.users_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objUsers = Users_GetObjFromJsonObj(returnObj);
                return objUsers;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.users_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.users_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Users_GetObjByUserIdAsync = Users_GetObjByUserIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param strUserId:所给的关键字
     * @returns 对象
    */
    async function Users_GetObjByUserId_Cache(strUserId, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByUserId_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strUserId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strUserId]不能为空！(In GetObjByUserId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        const arrUsersObjLst_Cache = await Users_GetObjLst_Cache();
        try {
            const arrUsers_Sel = arrUsersObjLst_Cache.filter(x => x.userId == strUserId);
            let objUsers;
            if (arrUsers_Sel.length > 0) {
                objUsers = arrUsers_Sel[0];
                return objUsers;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    objUsers = await Users_GetObjByUserIdAsync(strUserId);
                    if (objUsers != null) {
                        Users_ReFreshThisCache();
                        return objUsers;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strUserId, exports.users_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.Users_GetObjByUserId_Cache = Users_GetObjByUserId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param strUserId:所给的关键字
     * @returns 对象
    */
    async function Users_GetObjByUserId_localStorage(strUserId) {
        const strThisFuncName = "GetObjByUserId_localStorage";
        if ((0, clsString_js_1.IsNullOrEmpty)(strUserId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strUserId]不能为空！(In GetObjByUserId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strUserId.length != 20) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strUserId]的长度:[{0}]不正确！", strUserId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsUsersEN_js_1.clsUsersEN._CurrTabName, strUserId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objUsers_Cache = JSON.parse(strTempObj);
            return objUsers_Cache;
        }
        try {
            const objUsers = await Users_GetObjByUserIdAsync(strUserId);
            if (objUsers != null) {
                localStorage.setItem(strKey, JSON.stringify(objUsers));
                const strInfo = (0, clsString_js_1.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objUsers;
            }
            return objUsers;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strUserId, exports.users_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.Users_GetObjByUserId_localStorage = Users_GetObjByUserId_localStorage;
    /**
     * 修改在缓存对象列表中的对象, 与后台数据库无关.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
     * @param objUsers:所给的对象
     * @returns 对象
    */
    async function Users_UpdateObjInLst_Cache(objUsers) {
        const strThisFuncName = "UpdateObjInLst_Cache";
        try {
            const arrUsersObjLst_Cache = await Users_GetObjLst_Cache();
            const obj = arrUsersObjLst_Cache.find(x => x.userId == objUsers.userId);
            if (obj != null) {
                objUsers.userId = obj.userId;
                (0, clsCommFunc4Web_js_1.ObjectAssign)(obj, objUsers);
            }
            else {
                arrUsersObjLst_Cache.push(objUsers);
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, exports.users_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.Users_UpdateObjInLst_Cache = Users_UpdateObjInLst_Cache;
    /**
     * 根据关键字获取相关对象的名称属性, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetNameByKeyId_Cache)
     * @param strUserId:所给的关键字
     * @returns 对象
    */
    async function Users_GetNameByUserId_Cache(strUserId) {
        const strThisFuncName = "GetNameByUserId_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strUserId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strUserId]不能为空！(In GetNameByUserId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strUserId.length != 20) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strUserId]的长度:[{0}]不正确！", strUserId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrUsersObjLst_Cache = await Users_GetObjLst_Cache();
        if (arrUsersObjLst_Cache == null)
            return "";
        try {
            const arrUsers_Sel = arrUsersObjLst_Cache.filter(x => x.userId == strUserId);
            let objUsers;
            if (arrUsers_Sel.length > 0) {
                objUsers = arrUsers_Sel[0];
                return objUsers.userName;
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
    exports.Users_GetNameByUserId_Cache = Users_GetNameByUserId_Cache;
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
    async function Users_func(strInFldName, strOutFldName, strInValue) {
        //const strThisFuncName = "func";
        if (strInFldName != clsUsersEN_js_1.clsUsersEN.con_UserId) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsUsersEN_js_1.clsUsersEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_1.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strInFldName, clsUsersEN_js_1.clsUsersEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUserId = strInValue;
        if ((0, clsString_js_1.IsNullOrEmpty)(strInValue) == true) {
            return "";
        }
        const objUsers = await Users_GetObjByUserId_Cache(strUserId);
        if (objUsers == null)
            return "";
        return objUsers.GetFldValue(strOutFldName).toString();
    }
    exports.Users_func = Users_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function Users_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.userId.localeCompare(b.userId);
    }
    exports.Users_SortFun_Defa = Users_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function Users_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.userName == b.userName)
            return a.departmentId.localeCompare(b.departmentId);
        else
            return a.userName.localeCompare(b.userName);
    }
    exports.Users_SortFun_Defa_2Fld = Users_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function Users_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsUsersEN_js_1.clsUsersEN.con_UserId:
                    return (a, b) => {
                        return a.userId.localeCompare(b.userId);
                    };
                case clsUsersEN_js_1.clsUsersEN.con_UserName:
                    return (a, b) => {
                        return a.userName.localeCompare(b.userName);
                    };
                case clsUsersEN_js_1.clsUsersEN.con_DepartmentId:
                    return (a, b) => {
                        return a.departmentId.localeCompare(b.departmentId);
                    };
                case clsUsersEN_js_1.clsUsersEN.con_UserStateId:
                    return (a, b) => {
                        return a.userStateId.localeCompare(b.userStateId);
                    };
                case clsUsersEN_js_1.clsUsersEN.con_Password:
                    return (a, b) => {
                        return a.password.localeCompare(b.password);
                    };
                case clsUsersEN_js_1.clsUsersEN.con_IsGpUser:
                    return (a, b) => {
                        if (a.isGpUser == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsUsersEN_js_1.clsUsersEN.con_SchoolID1:
                    return (a, b) => {
                        return a.schoolID1.localeCompare(b.schoolID1);
                    };
                case clsUsersEN_js_1.clsUsersEN.con_BeginYearMonth:
                    return (a, b) => {
                        return a.beginYearMonth.localeCompare(b.beginYearMonth);
                    };
                case clsUsersEN_js_1.clsUsersEN.con_EndYearMonth:
                    return (a, b) => {
                        return a.endYearMonth.localeCompare(b.endYearMonth);
                    };
                case clsUsersEN_js_1.clsUsersEN.con_id_GradeBase:
                    return (a, b) => {
                        return a.id_GradeBase.localeCompare(b.id_GradeBase);
                    };
                case clsUsersEN_js_1.clsUsersEN.con_id_XzCollege:
                    return (a, b) => {
                        return a.id_XzCollege.localeCompare(b.id_XzCollege);
                    };
                case clsUsersEN_js_1.clsUsersEN.con_id_XzMajor:
                    return (a, b) => {
                        return a.id_XzMajor.localeCompare(b.id_XzMajor);
                    };
                case clsUsersEN_js_1.clsUsersEN.con_IsLeaved:
                    return (a, b) => {
                        if (a.isLeaved == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsUsersEN_js_1.clsUsersEN.con_StuIdTeacherId:
                    return (a, b) => {
                        return a.stuIdTeacherId.localeCompare(b.stuIdTeacherId);
                    };
                case clsUsersEN_js_1.clsUsersEN.con_Email:
                    return (a, b) => {
                        return a.email.localeCompare(b.email);
                    };
                case clsUsersEN_js_1.clsUsersEN.con_PhoneNumber:
                    return (a, b) => {
                        return a.phoneNumber.localeCompare(b.phoneNumber);
                    };
                case clsUsersEN_js_1.clsUsersEN.con_AvatarsPicture:
                    return (a, b) => {
                        return a.avatarsPicture.localeCompare(b.avatarsPicture);
                    };
                case clsUsersEN_js_1.clsUsersEN.con_IdentityID:
                    return (a, b) => {
                        return a.identityID.localeCompare(b.identityID);
                    };
                case clsUsersEN_js_1.clsUsersEN.con_AuditDate:
                    return (a, b) => {
                        return a.auditDate.localeCompare(b.auditDate);
                    };
                case clsUsersEN_js_1.clsUsersEN.con_AuditUser:
                    return (a, b) => {
                        return a.auditUser.localeCompare(b.auditUser);
                    };
                case clsUsersEN_js_1.clsUsersEN.con_IsAudit:
                    return (a, b) => {
                        if (a.isAudit == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsUsersEN_js_1.clsUsersEN.con_IsRegister:
                    return (a, b) => {
                        if (a.isRegister == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsUsersEN_js_1.clsUsersEN.con_RegisterDate:
                    return (a, b) => {
                        return a.registerDate.localeCompare(b.registerDate);
                    };
                case clsUsersEN_js_1.clsUsersEN.con_MobilePhone:
                    return (a, b) => {
                        return a.mobilePhone.localeCompare(b.mobilePhone);
                    };
                case clsUsersEN_js_1.clsUsersEN.con_OpenId:
                    return (a, b) => {
                        return a.openId.localeCompare(b.openId);
                    };
                case clsUsersEN_js_1.clsUsersEN.con_UpdDate:
                    return (a, b) => {
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsUsersEN_js_1.clsUsersEN.con_UpdUser:
                    return (a, b) => {
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsUsersEN_js_1.clsUsersEN.con_Memo:
                    return (a, b) => {
                        return a.memo.localeCompare(b.memo);
                    };
                case clsUsersEN_js_1.clsUsersEN.con_HeadPic:
                    return (a, b) => {
                        return a.headPic.localeCompare(b.headPic);
                    };
                case clsUsersEN_js_1.clsUsersEN.con_IsGSuser:
                    return (a, b) => {
                        if (a.isGSuser == true)
                            return 1;
                        else
                            return -1;
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[Users]中不存在！(in ${exports.users_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsUsersEN_js_1.clsUsersEN.con_UserId:
                    return (a, b) => {
                        return b.userId.localeCompare(a.userId);
                    };
                case clsUsersEN_js_1.clsUsersEN.con_UserName:
                    return (a, b) => {
                        return b.userName.localeCompare(a.userName);
                    };
                case clsUsersEN_js_1.clsUsersEN.con_DepartmentId:
                    return (a, b) => {
                        return b.departmentId.localeCompare(a.departmentId);
                    };
                case clsUsersEN_js_1.clsUsersEN.con_UserStateId:
                    return (a, b) => {
                        return b.userStateId.localeCompare(a.userStateId);
                    };
                case clsUsersEN_js_1.clsUsersEN.con_Password:
                    return (a, b) => {
                        return b.password.localeCompare(a.password);
                    };
                case clsUsersEN_js_1.clsUsersEN.con_IsGpUser:
                    return (a, b) => {
                        if (b.isGpUser == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsUsersEN_js_1.clsUsersEN.con_SchoolID1:
                    return (a, b) => {
                        return b.schoolID1.localeCompare(a.schoolID1);
                    };
                case clsUsersEN_js_1.clsUsersEN.con_BeginYearMonth:
                    return (a, b) => {
                        return b.beginYearMonth.localeCompare(a.beginYearMonth);
                    };
                case clsUsersEN_js_1.clsUsersEN.con_EndYearMonth:
                    return (a, b) => {
                        return b.endYearMonth.localeCompare(a.endYearMonth);
                    };
                case clsUsersEN_js_1.clsUsersEN.con_id_GradeBase:
                    return (a, b) => {
                        return b.id_GradeBase.localeCompare(a.id_GradeBase);
                    };
                case clsUsersEN_js_1.clsUsersEN.con_id_XzCollege:
                    return (a, b) => {
                        return b.id_XzCollege.localeCompare(a.id_XzCollege);
                    };
                case clsUsersEN_js_1.clsUsersEN.con_id_XzMajor:
                    return (a, b) => {
                        return b.id_XzMajor.localeCompare(a.id_XzMajor);
                    };
                case clsUsersEN_js_1.clsUsersEN.con_IsLeaved:
                    return (a, b) => {
                        if (b.isLeaved == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsUsersEN_js_1.clsUsersEN.con_StuIdTeacherId:
                    return (a, b) => {
                        return b.stuIdTeacherId.localeCompare(a.stuIdTeacherId);
                    };
                case clsUsersEN_js_1.clsUsersEN.con_Email:
                    return (a, b) => {
                        return b.email.localeCompare(a.email);
                    };
                case clsUsersEN_js_1.clsUsersEN.con_PhoneNumber:
                    return (a, b) => {
                        return b.phoneNumber.localeCompare(a.phoneNumber);
                    };
                case clsUsersEN_js_1.clsUsersEN.con_AvatarsPicture:
                    return (a, b) => {
                        return b.avatarsPicture.localeCompare(a.avatarsPicture);
                    };
                case clsUsersEN_js_1.clsUsersEN.con_IdentityID:
                    return (a, b) => {
                        return b.identityID.localeCompare(a.identityID);
                    };
                case clsUsersEN_js_1.clsUsersEN.con_AuditDate:
                    return (a, b) => {
                        return b.auditDate.localeCompare(a.auditDate);
                    };
                case clsUsersEN_js_1.clsUsersEN.con_AuditUser:
                    return (a, b) => {
                        return b.auditUser.localeCompare(a.auditUser);
                    };
                case clsUsersEN_js_1.clsUsersEN.con_IsAudit:
                    return (a, b) => {
                        if (b.isAudit == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsUsersEN_js_1.clsUsersEN.con_IsRegister:
                    return (a, b) => {
                        if (b.isRegister == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsUsersEN_js_1.clsUsersEN.con_RegisterDate:
                    return (a, b) => {
                        return b.registerDate.localeCompare(a.registerDate);
                    };
                case clsUsersEN_js_1.clsUsersEN.con_MobilePhone:
                    return (a, b) => {
                        return b.mobilePhone.localeCompare(a.mobilePhone);
                    };
                case clsUsersEN_js_1.clsUsersEN.con_OpenId:
                    return (a, b) => {
                        return b.openId.localeCompare(a.openId);
                    };
                case clsUsersEN_js_1.clsUsersEN.con_UpdDate:
                    return (a, b) => {
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsUsersEN_js_1.clsUsersEN.con_UpdUser:
                    return (a, b) => {
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsUsersEN_js_1.clsUsersEN.con_Memo:
                    return (a, b) => {
                        return b.memo.localeCompare(a.memo);
                    };
                case clsUsersEN_js_1.clsUsersEN.con_HeadPic:
                    return (a, b) => {
                        return b.headPic.localeCompare(a.headPic);
                    };
                case clsUsersEN_js_1.clsUsersEN.con_IsGSuser:
                    return (a, b) => {
                        if (b.isGSuser == true)
                            return 1;
                        else
                            return -1;
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[Users]中不存在！(in ${exports.users_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.Users_SortFunByKey = Users_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function Users_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsUsersEN_js_1.clsUsersEN.con_UserId:
                return (obj) => {
                    return obj.userId === value;
                };
            case clsUsersEN_js_1.clsUsersEN.con_UserName:
                return (obj) => {
                    return obj.userName === value;
                };
            case clsUsersEN_js_1.clsUsersEN.con_DepartmentId:
                return (obj) => {
                    return obj.departmentId === value;
                };
            case clsUsersEN_js_1.clsUsersEN.con_UserStateId:
                return (obj) => {
                    return obj.userStateId === value;
                };
            case clsUsersEN_js_1.clsUsersEN.con_Password:
                return (obj) => {
                    return obj.password === value;
                };
            case clsUsersEN_js_1.clsUsersEN.con_IsGpUser:
                return (obj) => {
                    return obj.isGpUser === value;
                };
            case clsUsersEN_js_1.clsUsersEN.con_SchoolID1:
                return (obj) => {
                    return obj.schoolID1 === value;
                };
            case clsUsersEN_js_1.clsUsersEN.con_BeginYearMonth:
                return (obj) => {
                    return obj.beginYearMonth === value;
                };
            case clsUsersEN_js_1.clsUsersEN.con_EndYearMonth:
                return (obj) => {
                    return obj.endYearMonth === value;
                };
            case clsUsersEN_js_1.clsUsersEN.con_id_GradeBase:
                return (obj) => {
                    return obj.id_GradeBase === value;
                };
            case clsUsersEN_js_1.clsUsersEN.con_id_XzCollege:
                return (obj) => {
                    return obj.id_XzCollege === value;
                };
            case clsUsersEN_js_1.clsUsersEN.con_id_XzMajor:
                return (obj) => {
                    return obj.id_XzMajor === value;
                };
            case clsUsersEN_js_1.clsUsersEN.con_IsLeaved:
                return (obj) => {
                    return obj.isLeaved === value;
                };
            case clsUsersEN_js_1.clsUsersEN.con_StuIdTeacherId:
                return (obj) => {
                    return obj.stuIdTeacherId === value;
                };
            case clsUsersEN_js_1.clsUsersEN.con_Email:
                return (obj) => {
                    return obj.email === value;
                };
            case clsUsersEN_js_1.clsUsersEN.con_PhoneNumber:
                return (obj) => {
                    return obj.phoneNumber === value;
                };
            case clsUsersEN_js_1.clsUsersEN.con_AvatarsPicture:
                return (obj) => {
                    return obj.avatarsPicture === value;
                };
            case clsUsersEN_js_1.clsUsersEN.con_IdentityID:
                return (obj) => {
                    return obj.identityID === value;
                };
            case clsUsersEN_js_1.clsUsersEN.con_AuditDate:
                return (obj) => {
                    return obj.auditDate === value;
                };
            case clsUsersEN_js_1.clsUsersEN.con_AuditUser:
                return (obj) => {
                    return obj.auditUser === value;
                };
            case clsUsersEN_js_1.clsUsersEN.con_IsAudit:
                return (obj) => {
                    return obj.isAudit === value;
                };
            case clsUsersEN_js_1.clsUsersEN.con_IsRegister:
                return (obj) => {
                    return obj.isRegister === value;
                };
            case clsUsersEN_js_1.clsUsersEN.con_RegisterDate:
                return (obj) => {
                    return obj.registerDate === value;
                };
            case clsUsersEN_js_1.clsUsersEN.con_MobilePhone:
                return (obj) => {
                    return obj.mobilePhone === value;
                };
            case clsUsersEN_js_1.clsUsersEN.con_OpenId:
                return (obj) => {
                    return obj.openId === value;
                };
            case clsUsersEN_js_1.clsUsersEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsUsersEN_js_1.clsUsersEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsUsersEN_js_1.clsUsersEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            case clsUsersEN_js_1.clsUsersEN.con_HeadPic:
                return (obj) => {
                    return obj.headPic === value;
                };
            case clsUsersEN_js_1.clsUsersEN.con_IsGSuser:
                return (obj) => {
                    return obj.isGSuser === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[Users]中不存在！(in ${exports.users_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.Users_FilterFunByKey = Users_FilterFunByKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function Users_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.users_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.users_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.users_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Users_GetFirstIDAsync = Users_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function Users_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.users_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.users_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.users_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Users_GetFirstID = Users_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function Users_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.users_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.users_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objUsers = Users_GetObjFromJsonObj(returnObj);
                return objUsers;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.users_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.users_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Users_GetFirstObjAsync = Users_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function Users_GetObjLst_ClientCache() {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsUsersEN_js_1.clsUsersEN._CurrTabName;
        clsUsersEN_js_1.clsUsersEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsUsersEN_js_1.clsUsersEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsUsersEN_js_1.clsUsersEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsUsersEN_js_1.clsUsersEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_2.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrUsersExObjLst_Cache = CacheHelper_js_2.CacheHelper.Get(strKey);
            const arrUsersObjLst_T = Users_GetObjLstByJSONObjLst(arrUsersExObjLst_Cache);
            return arrUsersObjLst_T;
        }
        try {
            const arrUsersExObjLst = await Users_GetObjLstAsync(strWhereCond);
            CacheHelper_js_2.CacheHelper.Add(strKey, arrUsersExObjLst);
            const strInfo = (0, clsString_js_1.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrUsersExObjLst.length);
            console.log(strInfo);
            return arrUsersExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.users_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.Users_GetObjLst_ClientCache = Users_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function Users_GetObjLst_localStorage() {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsUsersEN_js_1.clsUsersEN._CurrTabName;
        clsUsersEN_js_1.clsUsersEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsUsersEN_js_1.clsUsersEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsUsersEN_js_1.clsUsersEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsUsersEN_js_1.clsUsersEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrUsersExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrUsersObjLst_T = Users_GetObjLstByJSONObjLst(arrUsersExObjLst_Cache);
            return arrUsersObjLst_T;
        }
        try {
            const arrUsersExObjLst = await Users_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrUsersExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrUsersExObjLst.length);
            console.log(strInfo);
            return arrUsersExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.users_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.Users_GetObjLst_localStorage = Users_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function Users_GetObjLst_localStorage_PureCache() {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsUsersEN_js_1.clsUsersEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrUsersObjLst_Cache = JSON.parse(strTempObjLst);
            return arrUsersObjLst_Cache;
        }
        else
            return null;
    }
    exports.Users_GetObjLst_localStorage_PureCache = Users_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function Users_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.users_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.users_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = Users_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.users_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.users_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Users_GetObjLstAsync = Users_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function Users_GetObjLst_sessionStorage() {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsUsersEN_js_1.clsUsersEN._CurrTabName;
        clsUsersEN_js_1.clsUsersEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsUsersEN_js_1.clsUsersEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsUsersEN_js_1.clsUsersEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsUsersEN_js_1.clsUsersEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrUsersExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrUsersObjLst_T = Users_GetObjLstByJSONObjLst(arrUsersExObjLst_Cache);
            return arrUsersObjLst_T;
        }
        try {
            const arrUsersExObjLst = await Users_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrUsersExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrUsersExObjLst.length);
            console.log(strInfo);
            return arrUsersExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.users_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.Users_GetObjLst_sessionStorage = Users_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function Users_GetObjLst_sessionStorage_PureCache() {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsUsersEN_js_1.clsUsersEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrUsersObjLst_Cache = JSON.parse(strTempObjLst);
            return arrUsersObjLst_Cache;
        }
        else
            return null;
    }
    exports.Users_GetObjLst_sessionStorage_PureCache = Users_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function Users_GetObjLst_Cache() {
        //const strThisFuncName = "GetObjLst_Cache";
        let arrUsersObjLst_Cache;
        switch (clsUsersEN_js_1.clsUsersEN.CacheModeId) {
            case "04": //sessionStorage
                arrUsersObjLst_Cache = await Users_GetObjLst_sessionStorage();
                break;
            case "03": //localStorage
                arrUsersObjLst_Cache = await Users_GetObjLst_localStorage();
                break;
            case "02": //ClientCache
                arrUsersObjLst_Cache = await Users_GetObjLst_ClientCache();
                break;
            default:
                arrUsersObjLst_Cache = await Users_GetObjLst_ClientCache();
                break;
        }
        const arrUsersObjLst = Users_GetObjLstByJSONObjLst(arrUsersObjLst_Cache);
        return arrUsersObjLst_Cache;
    }
    exports.Users_GetObjLst_Cache = Users_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function Users_GetObjLst_PureCache() {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrUsersObjLst_Cache;
        switch (clsUsersEN_js_1.clsUsersEN.CacheModeId) {
            case "04": //sessionStorage
                arrUsersObjLst_Cache = await Users_GetObjLst_sessionStorage_PureCache();
                break;
            case "03": //localStorage
                arrUsersObjLst_Cache = await Users_GetObjLst_localStorage_PureCache();
                break;
            case "02": //ClientCache
                arrUsersObjLst_Cache = null;
                break;
            default:
                arrUsersObjLst_Cache = null;
                break;
        }
        return arrUsersObjLst_Cache;
    }
    exports.Users_GetObjLst_PureCache = Users_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objstrUserId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function Users_GetSubObjLst_Cache(objUsers_Cond) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrUsersObjLst_Cache = await Users_GetObjLst_Cache();
        let arrUsers_Sel = arrUsersObjLst_Cache;
        if (objUsers_Cond.sf_FldComparisonOp == null || objUsers_Cond.sf_FldComparisonOp == "")
            return arrUsers_Sel;
        const dicFldComparisonOp = JSON.parse(objUsers_Cond.sf_FldComparisonOp);
        //console.log("clsUsersWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objUsers_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrUsers_Sel = arrUsers_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objUsers_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrUsers_Sel = arrUsers_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrUsers_Sel = arrUsers_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrUsers_Sel = arrUsers_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrUsers_Sel = arrUsers_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrUsers_Sel = arrUsers_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrUsers_Sel = arrUsers_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrUsers_Sel = arrUsers_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrUsers_Sel = arrUsers_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrUsers_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objUsers_Cond), exports.users_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.Users_GetSubObjLst_Cache = Users_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrUserId:关键字列表
    * @returns 对象列表
    **/
    async function Users_GetObjLstByUserIdLstAsync(arrUserId) {
        const strThisFuncName = "GetObjLstByUserIdLstAsync";
        const strAction = "GetObjLstByUserIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.users_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrUserId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.users_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = Users_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.users_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.users_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Users_GetObjLstByUserIdLstAsync = Users_GetObjLstByUserIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrstrUserIdLst:关键字列表
     * @returns 对象列表
    */
    async function Users_GetObjLstByUserIdLst_Cache(arrUserIdLst) {
        const strThisFuncName = "GetObjLstByUserIdLst_Cache";
        try {
            const arrUsersObjLst_Cache = await Users_GetObjLst_Cache();
            const arrUsers_Sel = arrUsersObjLst_Cache.filter(x => arrUserIdLst.indexOf(x.userId) > -1);
            return arrUsers_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrUserIdLst.join(","), exports.users_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.Users_GetObjLstByUserIdLst_Cache = Users_GetObjLstByUserIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function Users_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.users_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.users_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = Users_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.users_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.users_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Users_GetTopObjLstAsync = Users_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function Users_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.users_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.users_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = Users_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.users_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.users_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Users_GetObjLstByRangeAsync = Users_GetObjLstByRangeAsync;
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
    async function Users_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.users_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.users_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.users_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Users_GetObjLstByRange = Users_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function Users_GetObjLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const arrUsersObjLst_Cache = await Users_GetObjLst_Cache();
        if (arrUsersObjLst_Cache.length == 0)
            return arrUsersObjLst_Cache;
        let arrUsers_Sel = arrUsersObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objUsers_Cond = new clsUsersEN_js_1.clsUsersEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objUsers_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsUsersWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrUsers_Sel = arrUsers_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objUsers_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrUsers_Sel = arrUsers_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrUsers_Sel = arrUsers_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrUsers_Sel = arrUsers_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrUsers_Sel = arrUsers_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrUsers_Sel = arrUsers_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrUsers_Sel = arrUsers_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrUsers_Sel = arrUsers_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrUsers_Sel = arrUsers_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrUsers_Sel = arrUsers_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrUsers_Sel.length == 0)
                return arrUsers_Sel;
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
                arrUsers_Sel = arrUsers_Sel.sort(Users_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrUsers_Sel = arrUsers_Sel.sort(objPagerPara.sortFun);
            }
            arrUsers_Sel = arrUsers_Sel.slice(intStart, intEnd);
            return arrUsers_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.users_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.Users_GetObjLstByPager_Cache = Users_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function Users_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.users_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.users_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = Users_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.users_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.users_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Users_GetObjLstByPagerAsync = Users_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param strUserId:关键字
    * @returns 获取删除的结果
    **/
    async function Users_DelRecordAsync(strUserId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.users_Controller, strAction);
        strUrl = (0, clsString_js_1.Format)("{0}/?Id={1}", strUrl, strUserId);
        try {
            const response = await axios_1.default.delete(strUrl, {
                params: { "Id": strUserId, }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.users_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.users_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Users_DelRecordAsync = Users_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrUserId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function Users_DelUserssAsync(arrUserId) {
        const strThisFuncName = "DelUserssAsync";
        const strAction = "DelUserss";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.users_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrUserId);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.users_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.users_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Users_DelUserssAsync = Users_DelUserssAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function Users_DelUserssByCondAsync(strWhereCond) {
        const strThisFuncName = "DelUserssByCondAsync";
        const strAction = "DelUserssByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.users_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.users_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.users_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Users_DelUserssByCondAsync = Users_DelUserssByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objUsersEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function Users_AddNewRecordAsync(objUsersEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        if (objUsersEN.userId === null || objUsersEN.userId === "") {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            throw strMsg;
        }
        //var strJSON = JSON.stringify(objUsersEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.users_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objUsersEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.users_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.users_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Users_AddNewRecordAsync = Users_AddNewRecordAsync;
    /**
    * 调用WebApi来添加记录，关键字用最大关键字，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithMaxIdAsync)
    * @param objUsersEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function Users_AddNewRecordWithMaxIdAsync(objUsersEN) {
        const strThisFuncName = "AddNewRecordWithMaxIdAsync";
        const strAction = "AddNewRecordWithMaxId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.users_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objUsersEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.users_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.users_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Users_AddNewRecordWithMaxIdAsync = Users_AddNewRecordWithMaxIdAsync;
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objUsersEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function Users_AddNewRecordWithReturnKeyAsync(objUsersEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.users_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objUsersEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.users_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.users_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Users_AddNewRecordWithReturnKeyAsync = Users_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objUsersEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function Users_AddNewRecordWithReturnKey(objUsersEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objUsersEN.userId === null || objUsersEN.userId === "") {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.users_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objUsersEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.users_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.users_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Users_AddNewRecordWithReturnKey = Users_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objUsersEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function Users_UpdateRecordAsync(objUsersEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objUsersEN.sf_UpdFldSetStr === undefined || objUsersEN.sf_UpdFldSetStr === null || objUsersEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objUsersEN.userId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.users_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objUsersEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.users_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.users_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Users_UpdateRecordAsync = Users_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objUsersEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function Users_UpdateWithConditionAsync(objUsersEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objUsersEN.sf_UpdFldSetStr === undefined || objUsersEN.sf_UpdFldSetStr === null || objUsersEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objUsersEN.userId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.users_Controller, strAction);
        objUsersEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objUsersEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.users_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.users_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Users_UpdateWithConditionAsync = Users_UpdateWithConditionAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objstrUserId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function Users_IsExistRecord_Cache(objUsers_Cond) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrUsersObjLst_Cache = await Users_GetObjLst_Cache();
        if (arrUsersObjLst_Cache == null)
            return false;
        let arrUsers_Sel = arrUsersObjLst_Cache;
        if (objUsers_Cond.sf_FldComparisonOp == null || objUsers_Cond.sf_FldComparisonOp == "")
            return arrUsers_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objUsers_Cond.sf_FldComparisonOp);
        //console.log("clsUsersWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objUsers_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objUsers_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrUsers_Sel = arrUsers_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrUsers_Sel = arrUsers_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrUsers_Sel = arrUsers_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrUsers_Sel = arrUsers_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrUsers_Sel = arrUsers_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrUsers_Sel = arrUsers_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrUsers_Sel = arrUsers_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrUsers_Sel = arrUsers_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrUsers_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objUsers_Cond), exports.users_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.Users_IsExistRecord_Cache = Users_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function Users_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.users_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.users_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.users_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Users_IsExistRecordAsync = Users_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strUserId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function Users_IsExist(strUserId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.users_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.users_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.users_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Users_IsExist = Users_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param strUserId:所给的关键字
     * @returns 对象
    */
    async function Users_IsExist_Cache(strUserId) {
        const strThisFuncName = "IsExist_Cache";
        const arrUsersObjLst_Cache = await Users_GetObjLst_Cache();
        if (arrUsersObjLst_Cache == null)
            return false;
        try {
            const arrUsers_Sel = arrUsersObjLst_Cache.filter(x => x.userId == strUserId);
            if (arrUsers_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strUserId, exports.users_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.Users_IsExist_Cache = Users_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strUserId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function Users_IsExistAsync(strUserId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.users_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.users_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.users_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Users_IsExistAsync = Users_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function Users_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.users_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.users_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.users_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Users_GetRecCountByCondAsync = Users_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objUsers_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function Users_GetRecCountByCond_Cache(objUsers_Cond) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrUsersObjLst_Cache = await Users_GetObjLst_Cache();
        if (arrUsersObjLst_Cache == null)
            return 0;
        let arrUsers_Sel = arrUsersObjLst_Cache;
        if (objUsers_Cond.sf_FldComparisonOp == null || objUsers_Cond.sf_FldComparisonOp == "")
            return arrUsers_Sel.length;
        const dicFldComparisonOp = JSON.parse(objUsers_Cond.sf_FldComparisonOp);
        //console.log("clsUsersWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objUsers_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrUsers_Sel = arrUsers_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objUsers_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrUsers_Sel = arrUsers_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrUsers_Sel = arrUsers_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrUsers_Sel = arrUsers_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrUsers_Sel = arrUsers_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrUsers_Sel = arrUsers_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrUsers_Sel = arrUsers_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrUsers_Sel = arrUsers_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrUsers_Sel = arrUsers_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrUsers_Sel = arrUsers_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrUsers_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objUsers_Cond), exports.users_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.Users_GetRecCountByCond_Cache = Users_GetRecCountByCond_Cache;
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
    async function Users_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.users_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.users_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.users_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Users_GetMaxStrIdByPrefix = Users_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function Users_GetWebApiUrl(strController, strAction) {
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
    exports.Users_GetWebApiUrl = Users_GetWebApiUrl;
    /**
    * 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshCache)
    **/
    function Users_ReFreshCache() {
        const strThisFuncName = "ReFreshCache";
        const strMsg = (0, clsString_js_1.Format)("刷新缓存成功！");
        console.trace(strMsg);
        // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
        const strKey = clsUsersEN_js_1.clsUsersEN._CurrTabName;
        switch (clsUsersEN_js_1.clsUsersEN.CacheModeId) {
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
        (0, clsvUsersWApi_js_1.vUsers_ReFreshThisCache)();
        (0, clsvUsersSimWApi_js_1.vUsersSim_ReFreshThisCache)();
    }
    exports.Users_ReFreshCache = Users_ReFreshCache;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function Users_ReFreshThisCache() {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = clsUsersEN_js_1.clsUsersEN._CurrTabName;
            switch (clsUsersEN_js_1.clsUsersEN.CacheModeId) {
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
    exports.Users_ReFreshThisCache = Users_ReFreshThisCache;
    /**
     * 绑定基于Web的下拉框,在某一层下的下拉框
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunctionInDiv)
     * @param objDDL:需要绑定当前表的下拉框
    */
    async function Users__Cache(strDivName, strDdlName) {
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
        const arrObjLst_Sel = await Users_GetObjLst_Cache();
        if (arrObjLst_Sel == null)
            return;
        (0, clsCommFunc4Web_js_1.BindDdl_ObjLstInDiv)(strDivName, strDdlName, arrObjLst_Sel, clsUsersEN_js_1.clsUsersEN.con_UserId, clsUsersEN_js_1.clsUsersEN.con_UserName, "用户");
    }
    exports.Users__Cache = Users__Cache;
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function Users_CheckPropertyNew(pobjUsersEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUsersEN.userName) === true) {
            throw new Error("(errid:Watl000058)字段[用户名]不能为空(In 用户)!(clsUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUsersEN.userStateId) === true) {
            throw new Error("(errid:Watl000058)字段[用户状态Id]不能为空(In 用户)!(clsUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUsersEN.identityID) === true
            || pobjUsersEN.identityID.toString() === "0") {
            throw new Error("(errid:Watl000058)字段[身份编号]不能为空(In 用户)!(clsUsersBL:CheckPropertyNew)");
        }
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUsersEN.userId) == false && (0, clsString_js_1.GetStrLen)(pobjUsersEN.userId) > 20) {
            throw new Error("(errid:Watl000059)字段[用户ID(userId)]的长度不能超过20(In 用户(Users))!值:$(pobjUsersEN.userId)(clsUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUsersEN.userName) == false && (0, clsString_js_1.GetStrLen)(pobjUsersEN.userName) > 50) {
            throw new Error("(errid:Watl000059)字段[用户名(userName)]的长度不能超过50(In 用户(Users))!值:$(pobjUsersEN.userName)(clsUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUsersEN.departmentId) == false && (0, clsString_js_1.GetStrLen)(pobjUsersEN.departmentId) > 8) {
            throw new Error("(errid:Watl000059)字段[部门Id(departmentId)]的长度不能超过8(In 用户(Users))!值:$(pobjUsersEN.departmentId)(clsUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUsersEN.userStateId) == false && (0, clsString_js_1.GetStrLen)(pobjUsersEN.userStateId) > 2) {
            throw new Error("(errid:Watl000059)字段[用户状态Id(userStateId)]的长度不能超过2(In 用户(Users))!值:$(pobjUsersEN.userStateId)(clsUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUsersEN.password) == false && (0, clsString_js_1.GetStrLen)(pobjUsersEN.password) > 20) {
            throw new Error("(errid:Watl000059)字段[Password(password)]的长度不能超过20(In 用户(Users))!值:$(pobjUsersEN.password)(clsUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUsersEN.schoolID1) == false && (0, clsString_js_1.GetStrLen)(pobjUsersEN.schoolID1) > 4) {
            throw new Error("(errid:Watl000059)字段[学校编号(schoolID1)]的长度不能超过4(In 用户(Users))!值:$(pobjUsersEN.schoolID1)(clsUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUsersEN.beginYearMonth) == false && (0, clsString_js_1.GetStrLen)(pobjUsersEN.beginYearMonth) > 8) {
            throw new Error("(errid:Watl000059)字段[开始年月(beginYearMonth)]的长度不能超过8(In 用户(Users))!值:$(pobjUsersEN.beginYearMonth)(clsUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUsersEN.endYearMonth) == false && (0, clsString_js_1.GetStrLen)(pobjUsersEN.endYearMonth) > 8) {
            throw new Error("(errid:Watl000059)字段[结束年月(endYearMonth)]的长度不能超过8(In 用户(Users))!值:$(pobjUsersEN.endYearMonth)(clsUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUsersEN.id_GradeBase) == false && (0, clsString_js_1.GetStrLen)(pobjUsersEN.id_GradeBase) > 4) {
            throw new Error("(errid:Watl000059)字段[年级流水号(id_GradeBase)]的长度不能超过4(In 用户(Users))!值:$(pobjUsersEN.id_GradeBase)(clsUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUsersEN.id_XzCollege) == false && (0, clsString_js_1.GetStrLen)(pobjUsersEN.id_XzCollege) > 4) {
            throw new Error("(errid:Watl000059)字段[学院流水号(id_XzCollege)]的长度不能超过4(In 用户(Users))!值:$(pobjUsersEN.id_XzCollege)(clsUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUsersEN.id_XzMajor) == false && (0, clsString_js_1.GetStrLen)(pobjUsersEN.id_XzMajor) > 8) {
            throw new Error("(errid:Watl000059)字段[专业流水号(id_XzMajor)]的长度不能超过8(In 用户(Users))!值:$(pobjUsersEN.id_XzMajor)(clsUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUsersEN.stuIdTeacherId) == false && (0, clsString_js_1.GetStrLen)(pobjUsersEN.stuIdTeacherId) > 20) {
            throw new Error("(errid:Watl000059)字段[学工号(stuIdTeacherId)]的长度不能超过20(In 用户(Users))!值:$(pobjUsersEN.stuIdTeacherId)(clsUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUsersEN.email) == false && (0, clsString_js_1.GetStrLen)(pobjUsersEN.email) > 100) {
            throw new Error("(errid:Watl000059)字段[电子邮箱(email)]的长度不能超过100(In 用户(Users))!值:$(pobjUsersEN.email)(clsUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUsersEN.phoneNumber) == false && (0, clsString_js_1.GetStrLen)(pobjUsersEN.phoneNumber) > 15) {
            throw new Error("(errid:Watl000059)字段[PhoneNumber(phoneNumber)]的长度不能超过15(In 用户(Users))!值:$(pobjUsersEN.phoneNumber)(clsUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUsersEN.avatarsPicture) == false && (0, clsString_js_1.GetStrLen)(pobjUsersEN.avatarsPicture) > 100) {
            throw new Error("(errid:Watl000059)字段[AvatarsPicture(avatarsPicture)]的长度不能超过100(In 用户(Users))!值:$(pobjUsersEN.avatarsPicture)(clsUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUsersEN.identityID) == false && (0, clsString_js_1.GetStrLen)(pobjUsersEN.identityID) > 2) {
            throw new Error("(errid:Watl000059)字段[身份编号(identityID)]的长度不能超过2(In 用户(Users))!值:$(pobjUsersEN.identityID)(clsUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUsersEN.auditDate) == false && (0, clsString_js_1.GetStrLen)(pobjUsersEN.auditDate) > 14) {
            throw new Error("(errid:Watl000059)字段[AuditDate(auditDate)]的长度不能超过14(In 用户(Users))!值:$(pobjUsersEN.auditDate)(clsUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUsersEN.auditUser) == false && (0, clsString_js_1.GetStrLen)(pobjUsersEN.auditUser) > 18) {
            throw new Error("(errid:Watl000059)字段[AuditUser(auditUser)]的长度不能超过18(In 用户(Users))!值:$(pobjUsersEN.auditUser)(clsUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUsersEN.registerDate) == false && (0, clsString_js_1.GetStrLen)(pobjUsersEN.registerDate) > 14) {
            throw new Error("(errid:Watl000059)字段[RegisterDate(registerDate)]的长度不能超过14(In 用户(Users))!值:$(pobjUsersEN.registerDate)(clsUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUsersEN.mobilePhone) == false && (0, clsString_js_1.GetStrLen)(pobjUsersEN.mobilePhone) > 20) {
            throw new Error("(errid:Watl000059)字段[手机(mobilePhone)]的长度不能超过20(In 用户(Users))!值:$(pobjUsersEN.mobilePhone)(clsUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUsersEN.openId) == false && (0, clsString_js_1.GetStrLen)(pobjUsersEN.openId) > 50) {
            throw new Error("(errid:Watl000059)字段[微信OpenId(openId)]的长度不能超过50(In 用户(Users))!值:$(pobjUsersEN.openId)(clsUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUsersEN.updDate) == false && (0, clsString_js_1.GetStrLen)(pobjUsersEN.updDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 用户(Users))!值:$(pobjUsersEN.updDate)(clsUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUsersEN.updUser) == false && (0, clsString_js_1.GetStrLen)(pobjUsersEN.updUser) > 20) {
            throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 用户(Users))!值:$(pobjUsersEN.updUser)(clsUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUsersEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjUsersEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 用户(Users))!值:$(pobjUsersEN.memo)(clsUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUsersEN.headPic) == false && (0, clsString_js_1.GetStrLen)(pobjUsersEN.headPic) > 500) {
            throw new Error("(errid:Watl000059)字段[头像(headPic)]的长度不能超过500(In 用户(Users))!值:$(pobjUsersEN.headPic)(clsUsersBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUsersEN.userId) == false && undefined !== pobjUsersEN.userId && jsString_js_1.tzDataType.isString(pobjUsersEN.userId) === false) {
            throw new Error("(errid:Watl000060)字段[用户ID(userId)]的值:[$(pobjUsersEN.userId)], 非法，应该为字符型(In 用户(Users))!(clsUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUsersEN.userName) == false && undefined !== pobjUsersEN.userName && jsString_js_1.tzDataType.isString(pobjUsersEN.userName) === false) {
            throw new Error("(errid:Watl000060)字段[用户名(userName)]的值:[$(pobjUsersEN.userName)], 非法，应该为字符型(In 用户(Users))!(clsUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUsersEN.departmentId) == false && undefined !== pobjUsersEN.departmentId && jsString_js_1.tzDataType.isString(pobjUsersEN.departmentId) === false) {
            throw new Error("(errid:Watl000060)字段[部门Id(departmentId)]的值:[$(pobjUsersEN.departmentId)], 非法，应该为字符型(In 用户(Users))!(clsUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUsersEN.userStateId) == false && undefined !== pobjUsersEN.userStateId && jsString_js_1.tzDataType.isString(pobjUsersEN.userStateId) === false) {
            throw new Error("(errid:Watl000060)字段[用户状态Id(userStateId)]的值:[$(pobjUsersEN.userStateId)], 非法，应该为字符型(In 用户(Users))!(clsUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUsersEN.password) == false && undefined !== pobjUsersEN.password && jsString_js_1.tzDataType.isString(pobjUsersEN.password) === false) {
            throw new Error("(errid:Watl000060)字段[Password(password)]的值:[$(pobjUsersEN.password)], 非法，应该为字符型(In 用户(Users))!(clsUsersBL:CheckPropertyNew)");
        }
        if (null != pobjUsersEN.isGpUser && undefined !== pobjUsersEN.isGpUser && jsString_js_1.tzDataType.isBoolean(pobjUsersEN.isGpUser) === false) {
            throw new Error("(errid:Watl000060)字段[是否Gp用户(isGpUser)]的值:[$(pobjUsersEN.isGpUser)], 非法，应该为布尔型(In 用户(Users))!(clsUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUsersEN.schoolID1) == false && undefined !== pobjUsersEN.schoolID1 && jsString_js_1.tzDataType.isString(pobjUsersEN.schoolID1) === false) {
            throw new Error("(errid:Watl000060)字段[学校编号(schoolID1)]的值:[$(pobjUsersEN.schoolID1)], 非法，应该为字符型(In 用户(Users))!(clsUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUsersEN.beginYearMonth) == false && undefined !== pobjUsersEN.beginYearMonth && jsString_js_1.tzDataType.isString(pobjUsersEN.beginYearMonth) === false) {
            throw new Error("(errid:Watl000060)字段[开始年月(beginYearMonth)]的值:[$(pobjUsersEN.beginYearMonth)], 非法，应该为字符型(In 用户(Users))!(clsUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUsersEN.endYearMonth) == false && undefined !== pobjUsersEN.endYearMonth && jsString_js_1.tzDataType.isString(pobjUsersEN.endYearMonth) === false) {
            throw new Error("(errid:Watl000060)字段[结束年月(endYearMonth)]的值:[$(pobjUsersEN.endYearMonth)], 非法，应该为字符型(In 用户(Users))!(clsUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUsersEN.id_GradeBase) == false && undefined !== pobjUsersEN.id_GradeBase && jsString_js_1.tzDataType.isString(pobjUsersEN.id_GradeBase) === false) {
            throw new Error("(errid:Watl000060)字段[年级流水号(id_GradeBase)]的值:[$(pobjUsersEN.id_GradeBase)], 非法，应该为字符型(In 用户(Users))!(clsUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUsersEN.id_XzCollege) == false && undefined !== pobjUsersEN.id_XzCollege && jsString_js_1.tzDataType.isString(pobjUsersEN.id_XzCollege) === false) {
            throw new Error("(errid:Watl000060)字段[学院流水号(id_XzCollege)]的值:[$(pobjUsersEN.id_XzCollege)], 非法，应该为字符型(In 用户(Users))!(clsUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUsersEN.id_XzMajor) == false && undefined !== pobjUsersEN.id_XzMajor && jsString_js_1.tzDataType.isString(pobjUsersEN.id_XzMajor) === false) {
            throw new Error("(errid:Watl000060)字段[专业流水号(id_XzMajor)]的值:[$(pobjUsersEN.id_XzMajor)], 非法，应该为字符型(In 用户(Users))!(clsUsersBL:CheckPropertyNew)");
        }
        if (null != pobjUsersEN.isLeaved && undefined !== pobjUsersEN.isLeaved && jsString_js_1.tzDataType.isBoolean(pobjUsersEN.isLeaved) === false) {
            throw new Error("(errid:Watl000060)字段[IsLeaved(isLeaved)]的值:[$(pobjUsersEN.isLeaved)], 非法，应该为布尔型(In 用户(Users))!(clsUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUsersEN.stuIdTeacherId) == false && undefined !== pobjUsersEN.stuIdTeacherId && jsString_js_1.tzDataType.isString(pobjUsersEN.stuIdTeacherId) === false) {
            throw new Error("(errid:Watl000060)字段[学工号(stuIdTeacherId)]的值:[$(pobjUsersEN.stuIdTeacherId)], 非法，应该为字符型(In 用户(Users))!(clsUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUsersEN.email) == false && undefined !== pobjUsersEN.email && jsString_js_1.tzDataType.isString(pobjUsersEN.email) === false) {
            throw new Error("(errid:Watl000060)字段[电子邮箱(email)]的值:[$(pobjUsersEN.email)], 非法，应该为字符型(In 用户(Users))!(clsUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUsersEN.phoneNumber) == false && undefined !== pobjUsersEN.phoneNumber && jsString_js_1.tzDataType.isString(pobjUsersEN.phoneNumber) === false) {
            throw new Error("(errid:Watl000060)字段[PhoneNumber(phoneNumber)]的值:[$(pobjUsersEN.phoneNumber)], 非法，应该为字符型(In 用户(Users))!(clsUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUsersEN.avatarsPicture) == false && undefined !== pobjUsersEN.avatarsPicture && jsString_js_1.tzDataType.isString(pobjUsersEN.avatarsPicture) === false) {
            throw new Error("(errid:Watl000060)字段[AvatarsPicture(avatarsPicture)]的值:[$(pobjUsersEN.avatarsPicture)], 非法，应该为字符型(In 用户(Users))!(clsUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUsersEN.identityID) == false && undefined !== pobjUsersEN.identityID && jsString_js_1.tzDataType.isString(pobjUsersEN.identityID) === false) {
            throw new Error("(errid:Watl000060)字段[身份编号(identityID)]的值:[$(pobjUsersEN.identityID)], 非法，应该为字符型(In 用户(Users))!(clsUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUsersEN.auditDate) == false && undefined !== pobjUsersEN.auditDate && jsString_js_1.tzDataType.isString(pobjUsersEN.auditDate) === false) {
            throw new Error("(errid:Watl000060)字段[AuditDate(auditDate)]的值:[$(pobjUsersEN.auditDate)], 非法，应该为字符型(In 用户(Users))!(clsUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUsersEN.auditUser) == false && undefined !== pobjUsersEN.auditUser && jsString_js_1.tzDataType.isString(pobjUsersEN.auditUser) === false) {
            throw new Error("(errid:Watl000060)字段[AuditUser(auditUser)]的值:[$(pobjUsersEN.auditUser)], 非法，应该为字符型(In 用户(Users))!(clsUsersBL:CheckPropertyNew)");
        }
        if (null != pobjUsersEN.isAudit && undefined !== pobjUsersEN.isAudit && jsString_js_1.tzDataType.isBoolean(pobjUsersEN.isAudit) === false) {
            throw new Error("(errid:Watl000060)字段[是否审核(isAudit)]的值:[$(pobjUsersEN.isAudit)], 非法，应该为布尔型(In 用户(Users))!(clsUsersBL:CheckPropertyNew)");
        }
        if (null != pobjUsersEN.isRegister && undefined !== pobjUsersEN.isRegister && jsString_js_1.tzDataType.isBoolean(pobjUsersEN.isRegister) === false) {
            throw new Error("(errid:Watl000060)字段[IsRegister(isRegister)]的值:[$(pobjUsersEN.isRegister)], 非法，应该为布尔型(In 用户(Users))!(clsUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUsersEN.registerDate) == false && undefined !== pobjUsersEN.registerDate && jsString_js_1.tzDataType.isString(pobjUsersEN.registerDate) === false) {
            throw new Error("(errid:Watl000060)字段[RegisterDate(registerDate)]的值:[$(pobjUsersEN.registerDate)], 非法，应该为字符型(In 用户(Users))!(clsUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUsersEN.mobilePhone) == false && undefined !== pobjUsersEN.mobilePhone && jsString_js_1.tzDataType.isString(pobjUsersEN.mobilePhone) === false) {
            throw new Error("(errid:Watl000060)字段[手机(mobilePhone)]的值:[$(pobjUsersEN.mobilePhone)], 非法，应该为字符型(In 用户(Users))!(clsUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUsersEN.openId) == false && undefined !== pobjUsersEN.openId && jsString_js_1.tzDataType.isString(pobjUsersEN.openId) === false) {
            throw new Error("(errid:Watl000060)字段[微信OpenId(openId)]的值:[$(pobjUsersEN.openId)], 非法，应该为字符型(In 用户(Users))!(clsUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUsersEN.updDate) == false && undefined !== pobjUsersEN.updDate && jsString_js_1.tzDataType.isString(pobjUsersEN.updDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjUsersEN.updDate)], 非法，应该为字符型(In 用户(Users))!(clsUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUsersEN.updUser) == false && undefined !== pobjUsersEN.updUser && jsString_js_1.tzDataType.isString(pobjUsersEN.updUser) === false) {
            throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjUsersEN.updUser)], 非法，应该为字符型(In 用户(Users))!(clsUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUsersEN.memo) == false && undefined !== pobjUsersEN.memo && jsString_js_1.tzDataType.isString(pobjUsersEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjUsersEN.memo)], 非法，应该为字符型(In 用户(Users))!(clsUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUsersEN.headPic) == false && undefined !== pobjUsersEN.headPic && jsString_js_1.tzDataType.isString(pobjUsersEN.headPic) === false) {
            throw new Error("(errid:Watl000060)字段[头像(headPic)]的值:[$(pobjUsersEN.headPic)], 非法，应该为字符型(In 用户(Users))!(clsUsersBL:CheckPropertyNew)");
        }
        if (null != pobjUsersEN.isGSuser && undefined !== pobjUsersEN.isGSuser && jsString_js_1.tzDataType.isBoolean(pobjUsersEN.isGSuser) === false) {
            throw new Error("(errid:Watl000060)字段[是否GS用户(isGSuser)]的值:[$(pobjUsersEN.isGSuser)], 非法，应该为布尔型(In 用户(Users))!(clsUsersBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjUsersEN.SetIsCheckProperty(true);
    }
    exports.Users_CheckPropertyNew = Users_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function Users_CheckProperty4Update(pobjUsersEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUsersEN.userId) == false && (0, clsString_js_1.GetStrLen)(pobjUsersEN.userId) > 20) {
            throw new Error("(errid:Watl000062)字段[用户ID(userId)]的长度不能超过20(In 用户(Users))!值:$(pobjUsersEN.userId)(clsUsersBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUsersEN.userName) == false && (0, clsString_js_1.GetStrLen)(pobjUsersEN.userName) > 50) {
            throw new Error("(errid:Watl000062)字段[用户名(userName)]的长度不能超过50(In 用户(Users))!值:$(pobjUsersEN.userName)(clsUsersBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUsersEN.departmentId) == false && (0, clsString_js_1.GetStrLen)(pobjUsersEN.departmentId) > 8) {
            throw new Error("(errid:Watl000062)字段[部门Id(departmentId)]的长度不能超过8(In 用户(Users))!值:$(pobjUsersEN.departmentId)(clsUsersBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUsersEN.userStateId) == false && (0, clsString_js_1.GetStrLen)(pobjUsersEN.userStateId) > 2) {
            throw new Error("(errid:Watl000062)字段[用户状态Id(userStateId)]的长度不能超过2(In 用户(Users))!值:$(pobjUsersEN.userStateId)(clsUsersBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUsersEN.password) == false && (0, clsString_js_1.GetStrLen)(pobjUsersEN.password) > 20) {
            throw new Error("(errid:Watl000062)字段[Password(password)]的长度不能超过20(In 用户(Users))!值:$(pobjUsersEN.password)(clsUsersBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUsersEN.schoolID1) == false && (0, clsString_js_1.GetStrLen)(pobjUsersEN.schoolID1) > 4) {
            throw new Error("(errid:Watl000062)字段[学校编号(schoolID1)]的长度不能超过4(In 用户(Users))!值:$(pobjUsersEN.schoolID1)(clsUsersBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUsersEN.beginYearMonth) == false && (0, clsString_js_1.GetStrLen)(pobjUsersEN.beginYearMonth) > 8) {
            throw new Error("(errid:Watl000062)字段[开始年月(beginYearMonth)]的长度不能超过8(In 用户(Users))!值:$(pobjUsersEN.beginYearMonth)(clsUsersBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUsersEN.endYearMonth) == false && (0, clsString_js_1.GetStrLen)(pobjUsersEN.endYearMonth) > 8) {
            throw new Error("(errid:Watl000062)字段[结束年月(endYearMonth)]的长度不能超过8(In 用户(Users))!值:$(pobjUsersEN.endYearMonth)(clsUsersBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUsersEN.id_GradeBase) == false && (0, clsString_js_1.GetStrLen)(pobjUsersEN.id_GradeBase) > 4) {
            throw new Error("(errid:Watl000062)字段[年级流水号(id_GradeBase)]的长度不能超过4(In 用户(Users))!值:$(pobjUsersEN.id_GradeBase)(clsUsersBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUsersEN.id_XzCollege) == false && (0, clsString_js_1.GetStrLen)(pobjUsersEN.id_XzCollege) > 4) {
            throw new Error("(errid:Watl000062)字段[学院流水号(id_XzCollege)]的长度不能超过4(In 用户(Users))!值:$(pobjUsersEN.id_XzCollege)(clsUsersBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUsersEN.id_XzMajor) == false && (0, clsString_js_1.GetStrLen)(pobjUsersEN.id_XzMajor) > 8) {
            throw new Error("(errid:Watl000062)字段[专业流水号(id_XzMajor)]的长度不能超过8(In 用户(Users))!值:$(pobjUsersEN.id_XzMajor)(clsUsersBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUsersEN.stuIdTeacherId) == false && (0, clsString_js_1.GetStrLen)(pobjUsersEN.stuIdTeacherId) > 20) {
            throw new Error("(errid:Watl000062)字段[学工号(stuIdTeacherId)]的长度不能超过20(In 用户(Users))!值:$(pobjUsersEN.stuIdTeacherId)(clsUsersBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUsersEN.email) == false && (0, clsString_js_1.GetStrLen)(pobjUsersEN.email) > 100) {
            throw new Error("(errid:Watl000062)字段[电子邮箱(email)]的长度不能超过100(In 用户(Users))!值:$(pobjUsersEN.email)(clsUsersBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUsersEN.phoneNumber) == false && (0, clsString_js_1.GetStrLen)(pobjUsersEN.phoneNumber) > 15) {
            throw new Error("(errid:Watl000062)字段[PhoneNumber(phoneNumber)]的长度不能超过15(In 用户(Users))!值:$(pobjUsersEN.phoneNumber)(clsUsersBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUsersEN.avatarsPicture) == false && (0, clsString_js_1.GetStrLen)(pobjUsersEN.avatarsPicture) > 100) {
            throw new Error("(errid:Watl000062)字段[AvatarsPicture(avatarsPicture)]的长度不能超过100(In 用户(Users))!值:$(pobjUsersEN.avatarsPicture)(clsUsersBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUsersEN.identityID) == false && (0, clsString_js_1.GetStrLen)(pobjUsersEN.identityID) > 2) {
            throw new Error("(errid:Watl000062)字段[身份编号(identityID)]的长度不能超过2(In 用户(Users))!值:$(pobjUsersEN.identityID)(clsUsersBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUsersEN.auditDate) == false && (0, clsString_js_1.GetStrLen)(pobjUsersEN.auditDate) > 14) {
            throw new Error("(errid:Watl000062)字段[AuditDate(auditDate)]的长度不能超过14(In 用户(Users))!值:$(pobjUsersEN.auditDate)(clsUsersBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUsersEN.auditUser) == false && (0, clsString_js_1.GetStrLen)(pobjUsersEN.auditUser) > 18) {
            throw new Error("(errid:Watl000062)字段[AuditUser(auditUser)]的长度不能超过18(In 用户(Users))!值:$(pobjUsersEN.auditUser)(clsUsersBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUsersEN.registerDate) == false && (0, clsString_js_1.GetStrLen)(pobjUsersEN.registerDate) > 14) {
            throw new Error("(errid:Watl000062)字段[RegisterDate(registerDate)]的长度不能超过14(In 用户(Users))!值:$(pobjUsersEN.registerDate)(clsUsersBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUsersEN.mobilePhone) == false && (0, clsString_js_1.GetStrLen)(pobjUsersEN.mobilePhone) > 20) {
            throw new Error("(errid:Watl000062)字段[手机(mobilePhone)]的长度不能超过20(In 用户(Users))!值:$(pobjUsersEN.mobilePhone)(clsUsersBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUsersEN.openId) == false && (0, clsString_js_1.GetStrLen)(pobjUsersEN.openId) > 50) {
            throw new Error("(errid:Watl000062)字段[微信OpenId(openId)]的长度不能超过50(In 用户(Users))!值:$(pobjUsersEN.openId)(clsUsersBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUsersEN.updDate) == false && (0, clsString_js_1.GetStrLen)(pobjUsersEN.updDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 用户(Users))!值:$(pobjUsersEN.updDate)(clsUsersBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUsersEN.updUser) == false && (0, clsString_js_1.GetStrLen)(pobjUsersEN.updUser) > 20) {
            throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 用户(Users))!值:$(pobjUsersEN.updUser)(clsUsersBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUsersEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjUsersEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 用户(Users))!值:$(pobjUsersEN.memo)(clsUsersBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUsersEN.headPic) == false && (0, clsString_js_1.GetStrLen)(pobjUsersEN.headPic) > 500) {
            throw new Error("(errid:Watl000062)字段[头像(headPic)]的长度不能超过500(In 用户(Users))!值:$(pobjUsersEN.headPic)(clsUsersBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUsersEN.userId) == false && undefined !== pobjUsersEN.userId && jsString_js_1.tzDataType.isString(pobjUsersEN.userId) === false) {
            throw new Error("(errid:Watl000063)字段[用户ID(userId)]的值:[$(pobjUsersEN.userId)], 非法，应该为字符型(In 用户(Users))!(clsUsersBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUsersEN.userName) == false && undefined !== pobjUsersEN.userName && jsString_js_1.tzDataType.isString(pobjUsersEN.userName) === false) {
            throw new Error("(errid:Watl000063)字段[用户名(userName)]的值:[$(pobjUsersEN.userName)], 非法，应该为字符型(In 用户(Users))!(clsUsersBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUsersEN.departmentId) == false && undefined !== pobjUsersEN.departmentId && jsString_js_1.tzDataType.isString(pobjUsersEN.departmentId) === false) {
            throw new Error("(errid:Watl000063)字段[部门Id(departmentId)]的值:[$(pobjUsersEN.departmentId)], 非法，应该为字符型(In 用户(Users))!(clsUsersBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUsersEN.userStateId) == false && undefined !== pobjUsersEN.userStateId && jsString_js_1.tzDataType.isString(pobjUsersEN.userStateId) === false) {
            throw new Error("(errid:Watl000063)字段[用户状态Id(userStateId)]的值:[$(pobjUsersEN.userStateId)], 非法，应该为字符型(In 用户(Users))!(clsUsersBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUsersEN.password) == false && undefined !== pobjUsersEN.password && jsString_js_1.tzDataType.isString(pobjUsersEN.password) === false) {
            throw new Error("(errid:Watl000063)字段[Password(password)]的值:[$(pobjUsersEN.password)], 非法，应该为字符型(In 用户(Users))!(clsUsersBL:CheckProperty4Update)");
        }
        if (null != pobjUsersEN.isGpUser && undefined !== pobjUsersEN.isGpUser && jsString_js_1.tzDataType.isBoolean(pobjUsersEN.isGpUser) === false) {
            throw new Error("(errid:Watl000063)字段[是否Gp用户(isGpUser)]的值:[$(pobjUsersEN.isGpUser)], 非法，应该为布尔型(In 用户(Users))!(clsUsersBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUsersEN.schoolID1) == false && undefined !== pobjUsersEN.schoolID1 && jsString_js_1.tzDataType.isString(pobjUsersEN.schoolID1) === false) {
            throw new Error("(errid:Watl000063)字段[学校编号(schoolID1)]的值:[$(pobjUsersEN.schoolID1)], 非法，应该为字符型(In 用户(Users))!(clsUsersBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUsersEN.beginYearMonth) == false && undefined !== pobjUsersEN.beginYearMonth && jsString_js_1.tzDataType.isString(pobjUsersEN.beginYearMonth) === false) {
            throw new Error("(errid:Watl000063)字段[开始年月(beginYearMonth)]的值:[$(pobjUsersEN.beginYearMonth)], 非法，应该为字符型(In 用户(Users))!(clsUsersBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUsersEN.endYearMonth) == false && undefined !== pobjUsersEN.endYearMonth && jsString_js_1.tzDataType.isString(pobjUsersEN.endYearMonth) === false) {
            throw new Error("(errid:Watl000063)字段[结束年月(endYearMonth)]的值:[$(pobjUsersEN.endYearMonth)], 非法，应该为字符型(In 用户(Users))!(clsUsersBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUsersEN.id_GradeBase) == false && undefined !== pobjUsersEN.id_GradeBase && jsString_js_1.tzDataType.isString(pobjUsersEN.id_GradeBase) === false) {
            throw new Error("(errid:Watl000063)字段[年级流水号(id_GradeBase)]的值:[$(pobjUsersEN.id_GradeBase)], 非法，应该为字符型(In 用户(Users))!(clsUsersBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUsersEN.id_XzCollege) == false && undefined !== pobjUsersEN.id_XzCollege && jsString_js_1.tzDataType.isString(pobjUsersEN.id_XzCollege) === false) {
            throw new Error("(errid:Watl000063)字段[学院流水号(id_XzCollege)]的值:[$(pobjUsersEN.id_XzCollege)], 非法，应该为字符型(In 用户(Users))!(clsUsersBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUsersEN.id_XzMajor) == false && undefined !== pobjUsersEN.id_XzMajor && jsString_js_1.tzDataType.isString(pobjUsersEN.id_XzMajor) === false) {
            throw new Error("(errid:Watl000063)字段[专业流水号(id_XzMajor)]的值:[$(pobjUsersEN.id_XzMajor)], 非法，应该为字符型(In 用户(Users))!(clsUsersBL:CheckProperty4Update)");
        }
        if (null != pobjUsersEN.isLeaved && undefined !== pobjUsersEN.isLeaved && jsString_js_1.tzDataType.isBoolean(pobjUsersEN.isLeaved) === false) {
            throw new Error("(errid:Watl000063)字段[IsLeaved(isLeaved)]的值:[$(pobjUsersEN.isLeaved)], 非法，应该为布尔型(In 用户(Users))!(clsUsersBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUsersEN.stuIdTeacherId) == false && undefined !== pobjUsersEN.stuIdTeacherId && jsString_js_1.tzDataType.isString(pobjUsersEN.stuIdTeacherId) === false) {
            throw new Error("(errid:Watl000063)字段[学工号(stuIdTeacherId)]的值:[$(pobjUsersEN.stuIdTeacherId)], 非法，应该为字符型(In 用户(Users))!(clsUsersBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUsersEN.email) == false && undefined !== pobjUsersEN.email && jsString_js_1.tzDataType.isString(pobjUsersEN.email) === false) {
            throw new Error("(errid:Watl000063)字段[电子邮箱(email)]的值:[$(pobjUsersEN.email)], 非法，应该为字符型(In 用户(Users))!(clsUsersBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUsersEN.phoneNumber) == false && undefined !== pobjUsersEN.phoneNumber && jsString_js_1.tzDataType.isString(pobjUsersEN.phoneNumber) === false) {
            throw new Error("(errid:Watl000063)字段[PhoneNumber(phoneNumber)]的值:[$(pobjUsersEN.phoneNumber)], 非法，应该为字符型(In 用户(Users))!(clsUsersBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUsersEN.avatarsPicture) == false && undefined !== pobjUsersEN.avatarsPicture && jsString_js_1.tzDataType.isString(pobjUsersEN.avatarsPicture) === false) {
            throw new Error("(errid:Watl000063)字段[AvatarsPicture(avatarsPicture)]的值:[$(pobjUsersEN.avatarsPicture)], 非法，应该为字符型(In 用户(Users))!(clsUsersBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUsersEN.identityID) == false && undefined !== pobjUsersEN.identityID && jsString_js_1.tzDataType.isString(pobjUsersEN.identityID) === false) {
            throw new Error("(errid:Watl000063)字段[身份编号(identityID)]的值:[$(pobjUsersEN.identityID)], 非法，应该为字符型(In 用户(Users))!(clsUsersBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUsersEN.auditDate) == false && undefined !== pobjUsersEN.auditDate && jsString_js_1.tzDataType.isString(pobjUsersEN.auditDate) === false) {
            throw new Error("(errid:Watl000063)字段[AuditDate(auditDate)]的值:[$(pobjUsersEN.auditDate)], 非法，应该为字符型(In 用户(Users))!(clsUsersBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUsersEN.auditUser) == false && undefined !== pobjUsersEN.auditUser && jsString_js_1.tzDataType.isString(pobjUsersEN.auditUser) === false) {
            throw new Error("(errid:Watl000063)字段[AuditUser(auditUser)]的值:[$(pobjUsersEN.auditUser)], 非法，应该为字符型(In 用户(Users))!(clsUsersBL:CheckProperty4Update)");
        }
        if (null != pobjUsersEN.isAudit && undefined !== pobjUsersEN.isAudit && jsString_js_1.tzDataType.isBoolean(pobjUsersEN.isAudit) === false) {
            throw new Error("(errid:Watl000063)字段[是否审核(isAudit)]的值:[$(pobjUsersEN.isAudit)], 非法，应该为布尔型(In 用户(Users))!(clsUsersBL:CheckProperty4Update)");
        }
        if (null != pobjUsersEN.isRegister && undefined !== pobjUsersEN.isRegister && jsString_js_1.tzDataType.isBoolean(pobjUsersEN.isRegister) === false) {
            throw new Error("(errid:Watl000063)字段[IsRegister(isRegister)]的值:[$(pobjUsersEN.isRegister)], 非法，应该为布尔型(In 用户(Users))!(clsUsersBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUsersEN.registerDate) == false && undefined !== pobjUsersEN.registerDate && jsString_js_1.tzDataType.isString(pobjUsersEN.registerDate) === false) {
            throw new Error("(errid:Watl000063)字段[RegisterDate(registerDate)]的值:[$(pobjUsersEN.registerDate)], 非法，应该为字符型(In 用户(Users))!(clsUsersBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUsersEN.mobilePhone) == false && undefined !== pobjUsersEN.mobilePhone && jsString_js_1.tzDataType.isString(pobjUsersEN.mobilePhone) === false) {
            throw new Error("(errid:Watl000063)字段[手机(mobilePhone)]的值:[$(pobjUsersEN.mobilePhone)], 非法，应该为字符型(In 用户(Users))!(clsUsersBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUsersEN.openId) == false && undefined !== pobjUsersEN.openId && jsString_js_1.tzDataType.isString(pobjUsersEN.openId) === false) {
            throw new Error("(errid:Watl000063)字段[微信OpenId(openId)]的值:[$(pobjUsersEN.openId)], 非法，应该为字符型(In 用户(Users))!(clsUsersBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUsersEN.updDate) == false && undefined !== pobjUsersEN.updDate && jsString_js_1.tzDataType.isString(pobjUsersEN.updDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjUsersEN.updDate)], 非法，应该为字符型(In 用户(Users))!(clsUsersBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUsersEN.updUser) == false && undefined !== pobjUsersEN.updUser && jsString_js_1.tzDataType.isString(pobjUsersEN.updUser) === false) {
            throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjUsersEN.updUser)], 非法，应该为字符型(In 用户(Users))!(clsUsersBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUsersEN.memo) == false && undefined !== pobjUsersEN.memo && jsString_js_1.tzDataType.isString(pobjUsersEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjUsersEN.memo)], 非法，应该为字符型(In 用户(Users))!(clsUsersBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUsersEN.headPic) == false && undefined !== pobjUsersEN.headPic && jsString_js_1.tzDataType.isString(pobjUsersEN.headPic) === false) {
            throw new Error("(errid:Watl000063)字段[头像(headPic)]的值:[$(pobjUsersEN.headPic)], 非法，应该为字符型(In 用户(Users))!(clsUsersBL:CheckProperty4Update)");
        }
        if (null != pobjUsersEN.isGSuser && undefined !== pobjUsersEN.isGSuser && jsString_js_1.tzDataType.isBoolean(pobjUsersEN.isGSuser) === false) {
            throw new Error("(errid:Watl000063)字段[是否GS用户(isGSuser)]的值:[$(pobjUsersEN.isGSuser)], 非法，应该为布尔型(In 用户(Users))!(clsUsersBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjUsersEN.userId) === true) {
            throw new Error("(errid:Watl000064)字段[用户ID]不能为空(In 用户)!(clsUsersBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjUsersEN.SetIsCheckProperty(true);
    }
    exports.Users_CheckProperty4Update = Users_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function Users_GetJSONStrByObj(pobjUsersEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjUsersEN.sf_UpdFldSetStr = pobjUsersEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjUsersEN);
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
    exports.Users_GetJSONStrByObj = Users_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function Users_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrUsersObjLst = new Array();
        if (strJSON === "") {
            return arrUsersObjLst;
        }
        try {
            arrUsersObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrUsersObjLst;
        }
        return arrUsersObjLst;
    }
    exports.Users_GetObjLstByJSONStr = Users_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrUsersObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function Users_GetObjLstByJSONObjLst(arrUsersObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrUsersObjLst = new Array();
        for (const objInFor of arrUsersObjLstS) {
            const obj1 = Users_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrUsersObjLst.push(obj1);
        }
        return arrUsersObjLst;
    }
    exports.Users_GetObjLstByJSONObjLst = Users_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function Users_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjUsersEN = new clsUsersEN_js_1.clsUsersEN();
        if (strJSON === "") {
            return pobjUsersEN;
        }
        try {
            pobjUsersEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjUsersEN;
        }
        return pobjUsersEN;
    }
    exports.Users_GetObjByJSONStr = Users_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function Users_GetCombineCondition(objUsers_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objUsers_Cond.dicFldComparisonOp, clsUsersEN_js_1.clsUsersEN.con_UserId) == true) {
            const strComparisonOp_UserId = objUsers_Cond.dicFldComparisonOp[clsUsersEN_js_1.clsUsersEN.con_UserId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsUsersEN_js_1.clsUsersEN.con_UserId, objUsers_Cond.userId, strComparisonOp_UserId);
        }
        if (Object.prototype.hasOwnProperty.call(objUsers_Cond.dicFldComparisonOp, clsUsersEN_js_1.clsUsersEN.con_UserName) == true) {
            const strComparisonOp_UserName = objUsers_Cond.dicFldComparisonOp[clsUsersEN_js_1.clsUsersEN.con_UserName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsUsersEN_js_1.clsUsersEN.con_UserName, objUsers_Cond.userName, strComparisonOp_UserName);
        }
        if (Object.prototype.hasOwnProperty.call(objUsers_Cond.dicFldComparisonOp, clsUsersEN_js_1.clsUsersEN.con_DepartmentId) == true) {
            const strComparisonOp_DepartmentId = objUsers_Cond.dicFldComparisonOp[clsUsersEN_js_1.clsUsersEN.con_DepartmentId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsUsersEN_js_1.clsUsersEN.con_DepartmentId, objUsers_Cond.departmentId, strComparisonOp_DepartmentId);
        }
        if (Object.prototype.hasOwnProperty.call(objUsers_Cond.dicFldComparisonOp, clsUsersEN_js_1.clsUsersEN.con_UserStateId) == true) {
            const strComparisonOp_UserStateId = objUsers_Cond.dicFldComparisonOp[clsUsersEN_js_1.clsUsersEN.con_UserStateId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsUsersEN_js_1.clsUsersEN.con_UserStateId, objUsers_Cond.userStateId, strComparisonOp_UserStateId);
        }
        if (Object.prototype.hasOwnProperty.call(objUsers_Cond.dicFldComparisonOp, clsUsersEN_js_1.clsUsersEN.con_Password) == true) {
            const strComparisonOp_Password = objUsers_Cond.dicFldComparisonOp[clsUsersEN_js_1.clsUsersEN.con_Password];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsUsersEN_js_1.clsUsersEN.con_Password, objUsers_Cond.password, strComparisonOp_Password);
        }
        if (Object.prototype.hasOwnProperty.call(objUsers_Cond.dicFldComparisonOp, clsUsersEN_js_1.clsUsersEN.con_IsGpUser) == true) {
            if (objUsers_Cond.isGpUser == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsUsersEN_js_1.clsUsersEN.con_IsGpUser);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsUsersEN_js_1.clsUsersEN.con_IsGpUser);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objUsers_Cond.dicFldComparisonOp, clsUsersEN_js_1.clsUsersEN.con_SchoolID1) == true) {
            const strComparisonOp_SchoolID1 = objUsers_Cond.dicFldComparisonOp[clsUsersEN_js_1.clsUsersEN.con_SchoolID1];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsUsersEN_js_1.clsUsersEN.con_SchoolID1, objUsers_Cond.schoolID1, strComparisonOp_SchoolID1);
        }
        if (Object.prototype.hasOwnProperty.call(objUsers_Cond.dicFldComparisonOp, clsUsersEN_js_1.clsUsersEN.con_BeginYearMonth) == true) {
            const strComparisonOp_BeginYearMonth = objUsers_Cond.dicFldComparisonOp[clsUsersEN_js_1.clsUsersEN.con_BeginYearMonth];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsUsersEN_js_1.clsUsersEN.con_BeginYearMonth, objUsers_Cond.beginYearMonth, strComparisonOp_BeginYearMonth);
        }
        if (Object.prototype.hasOwnProperty.call(objUsers_Cond.dicFldComparisonOp, clsUsersEN_js_1.clsUsersEN.con_EndYearMonth) == true) {
            const strComparisonOp_EndYearMonth = objUsers_Cond.dicFldComparisonOp[clsUsersEN_js_1.clsUsersEN.con_EndYearMonth];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsUsersEN_js_1.clsUsersEN.con_EndYearMonth, objUsers_Cond.endYearMonth, strComparisonOp_EndYearMonth);
        }
        if (Object.prototype.hasOwnProperty.call(objUsers_Cond.dicFldComparisonOp, clsUsersEN_js_1.clsUsersEN.con_id_GradeBase) == true) {
            const strComparisonOp_id_GradeBase = objUsers_Cond.dicFldComparisonOp[clsUsersEN_js_1.clsUsersEN.con_id_GradeBase];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsUsersEN_js_1.clsUsersEN.con_id_GradeBase, objUsers_Cond.id_GradeBase, strComparisonOp_id_GradeBase);
        }
        if (Object.prototype.hasOwnProperty.call(objUsers_Cond.dicFldComparisonOp, clsUsersEN_js_1.clsUsersEN.con_id_XzCollege) == true) {
            const strComparisonOp_id_XzCollege = objUsers_Cond.dicFldComparisonOp[clsUsersEN_js_1.clsUsersEN.con_id_XzCollege];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsUsersEN_js_1.clsUsersEN.con_id_XzCollege, objUsers_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
        }
        if (Object.prototype.hasOwnProperty.call(objUsers_Cond.dicFldComparisonOp, clsUsersEN_js_1.clsUsersEN.con_id_XzMajor) == true) {
            const strComparisonOp_id_XzMajor = objUsers_Cond.dicFldComparisonOp[clsUsersEN_js_1.clsUsersEN.con_id_XzMajor];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsUsersEN_js_1.clsUsersEN.con_id_XzMajor, objUsers_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
        }
        if (Object.prototype.hasOwnProperty.call(objUsers_Cond.dicFldComparisonOp, clsUsersEN_js_1.clsUsersEN.con_IsLeaved) == true) {
            if (objUsers_Cond.isLeaved == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsUsersEN_js_1.clsUsersEN.con_IsLeaved);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsUsersEN_js_1.clsUsersEN.con_IsLeaved);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objUsers_Cond.dicFldComparisonOp, clsUsersEN_js_1.clsUsersEN.con_StuIdTeacherId) == true) {
            const strComparisonOp_StuIdTeacherId = objUsers_Cond.dicFldComparisonOp[clsUsersEN_js_1.clsUsersEN.con_StuIdTeacherId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsUsersEN_js_1.clsUsersEN.con_StuIdTeacherId, objUsers_Cond.stuIdTeacherId, strComparisonOp_StuIdTeacherId);
        }
        if (Object.prototype.hasOwnProperty.call(objUsers_Cond.dicFldComparisonOp, clsUsersEN_js_1.clsUsersEN.con_Email) == true) {
            const strComparisonOp_Email = objUsers_Cond.dicFldComparisonOp[clsUsersEN_js_1.clsUsersEN.con_Email];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsUsersEN_js_1.clsUsersEN.con_Email, objUsers_Cond.email, strComparisonOp_Email);
        }
        if (Object.prototype.hasOwnProperty.call(objUsers_Cond.dicFldComparisonOp, clsUsersEN_js_1.clsUsersEN.con_PhoneNumber) == true) {
            const strComparisonOp_PhoneNumber = objUsers_Cond.dicFldComparisonOp[clsUsersEN_js_1.clsUsersEN.con_PhoneNumber];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsUsersEN_js_1.clsUsersEN.con_PhoneNumber, objUsers_Cond.phoneNumber, strComparisonOp_PhoneNumber);
        }
        if (Object.prototype.hasOwnProperty.call(objUsers_Cond.dicFldComparisonOp, clsUsersEN_js_1.clsUsersEN.con_AvatarsPicture) == true) {
            const strComparisonOp_AvatarsPicture = objUsers_Cond.dicFldComparisonOp[clsUsersEN_js_1.clsUsersEN.con_AvatarsPicture];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsUsersEN_js_1.clsUsersEN.con_AvatarsPicture, objUsers_Cond.avatarsPicture, strComparisonOp_AvatarsPicture);
        }
        if (Object.prototype.hasOwnProperty.call(objUsers_Cond.dicFldComparisonOp, clsUsersEN_js_1.clsUsersEN.con_IdentityID) == true) {
            const strComparisonOp_IdentityID = objUsers_Cond.dicFldComparisonOp[clsUsersEN_js_1.clsUsersEN.con_IdentityID];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsUsersEN_js_1.clsUsersEN.con_IdentityID, objUsers_Cond.identityID, strComparisonOp_IdentityID);
        }
        if (Object.prototype.hasOwnProperty.call(objUsers_Cond.dicFldComparisonOp, clsUsersEN_js_1.clsUsersEN.con_AuditDate) == true) {
            const strComparisonOp_AuditDate = objUsers_Cond.dicFldComparisonOp[clsUsersEN_js_1.clsUsersEN.con_AuditDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsUsersEN_js_1.clsUsersEN.con_AuditDate, objUsers_Cond.auditDate, strComparisonOp_AuditDate);
        }
        if (Object.prototype.hasOwnProperty.call(objUsers_Cond.dicFldComparisonOp, clsUsersEN_js_1.clsUsersEN.con_AuditUser) == true) {
            const strComparisonOp_AuditUser = objUsers_Cond.dicFldComparisonOp[clsUsersEN_js_1.clsUsersEN.con_AuditUser];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsUsersEN_js_1.clsUsersEN.con_AuditUser, objUsers_Cond.auditUser, strComparisonOp_AuditUser);
        }
        if (Object.prototype.hasOwnProperty.call(objUsers_Cond.dicFldComparisonOp, clsUsersEN_js_1.clsUsersEN.con_IsAudit) == true) {
            if (objUsers_Cond.isAudit == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsUsersEN_js_1.clsUsersEN.con_IsAudit);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsUsersEN_js_1.clsUsersEN.con_IsAudit);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objUsers_Cond.dicFldComparisonOp, clsUsersEN_js_1.clsUsersEN.con_IsRegister) == true) {
            if (objUsers_Cond.isRegister == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsUsersEN_js_1.clsUsersEN.con_IsRegister);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsUsersEN_js_1.clsUsersEN.con_IsRegister);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objUsers_Cond.dicFldComparisonOp, clsUsersEN_js_1.clsUsersEN.con_RegisterDate) == true) {
            const strComparisonOp_RegisterDate = objUsers_Cond.dicFldComparisonOp[clsUsersEN_js_1.clsUsersEN.con_RegisterDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsUsersEN_js_1.clsUsersEN.con_RegisterDate, objUsers_Cond.registerDate, strComparisonOp_RegisterDate);
        }
        if (Object.prototype.hasOwnProperty.call(objUsers_Cond.dicFldComparisonOp, clsUsersEN_js_1.clsUsersEN.con_MobilePhone) == true) {
            const strComparisonOp_MobilePhone = objUsers_Cond.dicFldComparisonOp[clsUsersEN_js_1.clsUsersEN.con_MobilePhone];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsUsersEN_js_1.clsUsersEN.con_MobilePhone, objUsers_Cond.mobilePhone, strComparisonOp_MobilePhone);
        }
        if (Object.prototype.hasOwnProperty.call(objUsers_Cond.dicFldComparisonOp, clsUsersEN_js_1.clsUsersEN.con_OpenId) == true) {
            const strComparisonOp_OpenId = objUsers_Cond.dicFldComparisonOp[clsUsersEN_js_1.clsUsersEN.con_OpenId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsUsersEN_js_1.clsUsersEN.con_OpenId, objUsers_Cond.openId, strComparisonOp_OpenId);
        }
        if (Object.prototype.hasOwnProperty.call(objUsers_Cond.dicFldComparisonOp, clsUsersEN_js_1.clsUsersEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objUsers_Cond.dicFldComparisonOp[clsUsersEN_js_1.clsUsersEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsUsersEN_js_1.clsUsersEN.con_UpdDate, objUsers_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objUsers_Cond.dicFldComparisonOp, clsUsersEN_js_1.clsUsersEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objUsers_Cond.dicFldComparisonOp[clsUsersEN_js_1.clsUsersEN.con_UpdUser];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsUsersEN_js_1.clsUsersEN.con_UpdUser, objUsers_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objUsers_Cond.dicFldComparisonOp, clsUsersEN_js_1.clsUsersEN.con_Memo) == true) {
            const strComparisonOp_Memo = objUsers_Cond.dicFldComparisonOp[clsUsersEN_js_1.clsUsersEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsUsersEN_js_1.clsUsersEN.con_Memo, objUsers_Cond.memo, strComparisonOp_Memo);
        }
        if (Object.prototype.hasOwnProperty.call(objUsers_Cond.dicFldComparisonOp, clsUsersEN_js_1.clsUsersEN.con_HeadPic) == true) {
            const strComparisonOp_HeadPic = objUsers_Cond.dicFldComparisonOp[clsUsersEN_js_1.clsUsersEN.con_HeadPic];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsUsersEN_js_1.clsUsersEN.con_HeadPic, objUsers_Cond.headPic, strComparisonOp_HeadPic);
        }
        if (Object.prototype.hasOwnProperty.call(objUsers_Cond.dicFldComparisonOp, clsUsersEN_js_1.clsUsersEN.con_IsGSuser) == true) {
            if (objUsers_Cond.isGSuser == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsUsersEN_js_1.clsUsersEN.con_IsGSuser);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsUsersEN_js_1.clsUsersEN.con_IsGSuser);
            }
        }
        return strWhereCond;
    }
    exports.Users_GetCombineCondition = Users_GetCombineCondition;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objUsersENS:源对象
     * @param objUsersENT:目标对象
    */
    function Users_CopyObjTo(objUsersENS, objUsersENT) {
        objUsersENT.userId = objUsersENS.userId; //用户ID
        objUsersENT.userName = objUsersENS.userName; //用户名
        objUsersENT.departmentId = objUsersENS.departmentId; //部门Id
        objUsersENT.userStateId = objUsersENS.userStateId; //用户状态Id
        objUsersENT.password = objUsersENS.password; //Password
        objUsersENT.isGpUser = objUsersENS.isGpUser; //是否Gp用户
        objUsersENT.schoolID1 = objUsersENS.schoolID1; //学校编号
        objUsersENT.beginYearMonth = objUsersENS.beginYearMonth; //开始年月
        objUsersENT.endYearMonth = objUsersENS.endYearMonth; //结束年月
        objUsersENT.id_GradeBase = objUsersENS.id_GradeBase; //年级流水号
        objUsersENT.id_XzCollege = objUsersENS.id_XzCollege; //学院流水号
        objUsersENT.id_XzMajor = objUsersENS.id_XzMajor; //专业流水号
        objUsersENT.isLeaved = objUsersENS.isLeaved; //IsLeaved
        objUsersENT.stuIdTeacherId = objUsersENS.stuIdTeacherId; //学工号
        objUsersENT.email = objUsersENS.email; //电子邮箱
        objUsersENT.phoneNumber = objUsersENS.phoneNumber; //PhoneNumber
        objUsersENT.avatarsPicture = objUsersENS.avatarsPicture; //AvatarsPicture
        objUsersENT.identityID = objUsersENS.identityID; //身份编号
        objUsersENT.auditDate = objUsersENS.auditDate; //AuditDate
        objUsersENT.auditUser = objUsersENS.auditUser; //AuditUser
        objUsersENT.isAudit = objUsersENS.isAudit; //是否审核
        objUsersENT.isRegister = objUsersENS.isRegister; //IsRegister
        objUsersENT.registerDate = objUsersENS.registerDate; //RegisterDate
        objUsersENT.mobilePhone = objUsersENS.mobilePhone; //手机
        objUsersENT.openId = objUsersENS.openId; //微信OpenId
        objUsersENT.updDate = objUsersENS.updDate; //修改日期
        objUsersENT.updUser = objUsersENS.updUser; //修改人
        objUsersENT.memo = objUsersENS.memo; //备注
        objUsersENT.headPic = objUsersENS.headPic; //头像
        objUsersENT.isGSuser = objUsersENS.isGSuser; //是否GS用户
        objUsersENT.sf_UpdFldSetStr = objUsersENS.updFldString; //sf_UpdFldSetStr
    }
    exports.Users_CopyObjTo = Users_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objUsersENS:源对象
     * @param objUsersENT:目标对象
    */
    function Users_GetObjFromJsonObj(objUsersENS) {
        const objUsersENT = new clsUsersEN_js_1.clsUsersEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objUsersENT, objUsersENS);
        return objUsersENT;
    }
    exports.Users_GetObjFromJsonObj = Users_GetObjFromJsonObj;
});
