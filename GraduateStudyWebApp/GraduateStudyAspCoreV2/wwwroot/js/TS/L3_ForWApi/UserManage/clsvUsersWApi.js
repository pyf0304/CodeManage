/**
* 类名:clsvUsersWApi
* 表名:vUsers(01120027)
* 版本:2023.02.24.1(服务器:WIN-SRV103-116)
* 日期:2023/02/24 13:49:15
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
        define(["require", "exports", "axios", "../../PubFun/enumComparisonOp.js", "../../PubFun/CacheHelper.js", "../../L0_Entity/UserManage/clsvUsersEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/CacheHelper.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.vUsers_GetObjFromJsonObj = exports.vUsers_CopyObjTo = exports.vUsers_GetCombineCondition = exports.vUsers_GetObjByJSONStr = exports.vUsers_GetObjLstByJSONObjLst = exports.vUsers_GetObjLstByJSONStr = exports.vUsers_GetJSONStrByObj = exports.vUsers_ReFreshThisCache = exports.vUsers_GetWebApiUrl = exports.vUsers_GetRecCountByCond_Cache = exports.vUsers_GetRecCountByCondAsync = exports.vUsers_IsExistAsync = exports.vUsers_IsExist_Cache = exports.vUsers_IsExist = exports.vUsers_IsExistRecordAsync = exports.vUsers_IsExistRecord_Cache = exports.vUsers_GetObjLstByPagerAsync = exports.vUsers_GetObjLstByPager_Cache = exports.vUsers_GetObjLstByRange = exports.vUsers_GetObjLstByRangeAsync = exports.vUsers_GetTopObjLstAsync = exports.vUsers_GetObjLstByUserIdLst_Cache = exports.vUsers_GetObjLstByUserIdLstAsync = exports.vUsers_GetSubObjLst_Cache = exports.vUsers_GetObjLst_PureCache = exports.vUsers_GetObjLst_Cache = exports.vUsers_GetObjLst_sessionStorage_PureCache = exports.vUsers_GetObjLst_sessionStorage = exports.vUsers_GetObjLstAsync = exports.vUsers_GetObjLst_localStorage_PureCache = exports.vUsers_GetObjLst_localStorage = exports.vUsers_GetObjLst_ClientCache = exports.vUsers_GetFirstObjAsync = exports.vUsers_GetFirstID = exports.vUsers_GetFirstIDAsync = exports.vUsers_funcKey = exports.vUsers_FilterFunByKey = exports.vUsers_SortFunByKey = exports.vUsers_SortFun_Defa_2Fld = exports.vUsers_SortFun_Defa = exports.vUsers_func = exports.vUsers_GetObjByUserId_localStorage = exports.vUsers_GetObjByUserId_Cache = exports.vUsers_GetObjByUserIdAsync = exports.vUsers_ConstructorName = exports.vUsers_Controller = void 0;
    /**
     * v用户(vUsers)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年02月24日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const enumComparisonOp_js_1 = require("../../PubFun/enumComparisonOp.js");
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsvUsersEN_js_1 = require("../../L0_Entity/UserManage/clsvUsersEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const CacheHelper_js_2 = require("../../PubFun/CacheHelper.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.vUsers_Controller = "vUsersApi";
    exports.vUsers_ConstructorName = "vUsers";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strUserId:关键字
    * @returns 对象
    **/
    async function vUsers_GetObjByUserIdAsync(strUserId) {
        const strThisFuncName = "GetObjByUserIdAsync";
        if ((0, clsString_js_1.IsNullOrEmpty)(strUserId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strUserId]不能为空！(In GetObjByUserIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByUserId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vUsers_Controller, strAction);
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
                const objvUsers = vUsers_GetObjFromJsonObj(returnObj);
                return objvUsers;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vUsers_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vUsers_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vUsers_GetObjByUserIdAsync = vUsers_GetObjByUserIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param strUserId:所给的关键字
     * @returns 对象
    */
    async function vUsers_GetObjByUserId_Cache(strUserId, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByUserId_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strUserId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strUserId]不能为空！(In GetObjByUserId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        const arrvUsersObjLst_Cache = await vUsers_GetObjLst_Cache();
        try {
            const arrvUsers_Sel = arrvUsersObjLst_Cache.filter(x => x.userId == strUserId);
            let objvUsers;
            if (arrvUsers_Sel.length > 0) {
                objvUsers = arrvUsers_Sel[0];
                return objvUsers;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    const objvUsers_Const = await vUsers_GetObjByUserIdAsync(strUserId);
                    if (objvUsers_Const != null) {
                        vUsers_ReFreshThisCache();
                        return objvUsers_Const;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strUserId, exports.vUsers_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.vUsers_GetObjByUserId_Cache = vUsers_GetObjByUserId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param strUserId:所给的关键字
     * @returns 对象
    */
    async function vUsers_GetObjByUserId_localStorage(strUserId) {
        const strThisFuncName = "GetObjByUserId_localStorage";
        if ((0, clsString_js_1.IsNullOrEmpty)(strUserId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strUserId]不能为空！(In GetObjByUserId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvUsersEN_js_1.clsvUsersEN._CurrTabName, strUserId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objvUsers_Cache = JSON.parse(strTempObj);
            return objvUsers_Cache;
        }
        try {
            const objvUsers = await vUsers_GetObjByUserIdAsync(strUserId);
            if (objvUsers != null) {
                localStorage.setItem(strKey, JSON.stringify(objvUsers));
                const strInfo = (0, clsString_js_1.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objvUsers;
            }
            return objvUsers;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strUserId, exports.vUsers_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.vUsers_GetObjByUserId_localStorage = vUsers_GetObjByUserId_localStorage;
    /*该表没有名称字段，不能生成此函数！*/
    /**
     * 映射函数。根据表映射把输入字段值，映射成输出字段值
     * 作者:pyf
     * 日期:2023-02-24
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_func)
     * @param strInFldName:输入字段名
     * @param strOutFldName:输出字段名
     * @param strInValue:输入字段值
     * @returns 返回一个输出字段值
    */
    async function vUsers_func(strInFldName, strOutFldName, strInValue) {
        //const strThisFuncName = "func";
        if (strInFldName != clsvUsersEN_js_1.clsvUsersEN.con_UserId) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsvUsersEN_js_1.clsvUsersEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_1.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strOutFldName, clsvUsersEN_js_1.clsvUsersEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUserId = strInValue;
        if ((0, clsString_js_1.IsNullOrEmpty)(strInValue) == true) {
            return "";
        }
        const objvUsers = await vUsers_GetObjByUserId_Cache(strUserId);
        if (objvUsers == null)
            return "";
        if (objvUsers.GetFldValue(strOutFldName) == null)
            return "";
        return objvUsers.GetFldValue(strOutFldName).toString();
    }
    exports.vUsers_func = vUsers_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-02-24
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vUsers_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.userId.localeCompare(b.userId);
    }
    exports.vUsers_SortFun_Defa = vUsers_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-02-24
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vUsers_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.userName == b.userName)
            return a.userStateId.localeCompare(b.userStateId);
        else
            return a.userName.localeCompare(b.userName);
    }
    exports.vUsers_SortFun_Defa_2Fld = vUsers_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-02-24
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vUsers_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsvUsersEN_js_1.clsvUsersEN.con_UserId:
                    return (a, b) => {
                        if (a.userId == null)
                            return -1;
                        if (b.userId == null)
                            return 1;
                        return a.userId.localeCompare(b.userId);
                    };
                case clsvUsersEN_js_1.clsvUsersEN.con_UserName:
                    return (a, b) => {
                        if (a.userName == null)
                            return -1;
                        if (b.userName == null)
                            return 1;
                        return a.userName.localeCompare(b.userName);
                    };
                case clsvUsersEN_js_1.clsvUsersEN.con_UserStateId:
                    return (a, b) => {
                        return a.userStateId.localeCompare(b.userStateId);
                    };
                case clsvUsersEN_js_1.clsvUsersEN.con_UserStateName:
                    return (a, b) => {
                        if (a.userStateName == null)
                            return -1;
                        if (b.userStateName == null)
                            return 1;
                        return a.userStateName.localeCompare(b.userStateName);
                    };
                case clsvUsersEN_js_1.clsvUsersEN.con_Password:
                    return (a, b) => {
                        if (a.password == null)
                            return -1;
                        if (b.password == null)
                            return 1;
                        return a.password.localeCompare(b.password);
                    };
                case clsvUsersEN_js_1.clsvUsersEN.con_IsGpUser:
                    return (a, b) => {
                        if (a.isGpUser == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvUsersEN_js_1.clsvUsersEN.con_BeginYearMonth:
                    return (a, b) => {
                        if (a.beginYearMonth == null)
                            return -1;
                        if (b.beginYearMonth == null)
                            return 1;
                        return a.beginYearMonth.localeCompare(b.beginYearMonth);
                    };
                case clsvUsersEN_js_1.clsvUsersEN.con_EndYearMonth:
                    return (a, b) => {
                        if (a.endYearMonth == null)
                            return -1;
                        if (b.endYearMonth == null)
                            return 1;
                        return a.endYearMonth.localeCompare(b.endYearMonth);
                    };
                case clsvUsersEN_js_1.clsvUsersEN.con_id_GradeBase:
                    return (a, b) => {
                        if (a.id_GradeBase == null)
                            return -1;
                        if (b.id_GradeBase == null)
                            return 1;
                        return a.id_GradeBase.localeCompare(b.id_GradeBase);
                    };
                case clsvUsersEN_js_1.clsvUsersEN.con_GradeBaseName:
                    return (a, b) => {
                        if (a.gradeBaseName == null)
                            return -1;
                        if (b.gradeBaseName == null)
                            return 1;
                        return a.gradeBaseName.localeCompare(b.gradeBaseName);
                    };
                case clsvUsersEN_js_1.clsvUsersEN.con_id_XzCollege:
                    return (a, b) => {
                        if (a.id_XzCollege == null)
                            return -1;
                        if (b.id_XzCollege == null)
                            return 1;
                        return a.id_XzCollege.localeCompare(b.id_XzCollege);
                    };
                case clsvUsersEN_js_1.clsvUsersEN.con_CollegeID:
                    return (a, b) => {
                        if (a.collegeID == null)
                            return -1;
                        if (b.collegeID == null)
                            return 1;
                        return a.collegeID.localeCompare(b.collegeID);
                    };
                case clsvUsersEN_js_1.clsvUsersEN.con_CollegeName:
                    return (a, b) => {
                        if (a.collegeName == null)
                            return -1;
                        if (b.collegeName == null)
                            return 1;
                        return a.collegeName.localeCompare(b.collegeName);
                    };
                case clsvUsersEN_js_1.clsvUsersEN.con_CollegeNameA:
                    return (a, b) => {
                        if (a.collegeNameA == null)
                            return -1;
                        if (b.collegeNameA == null)
                            return 1;
                        return a.collegeNameA.localeCompare(b.collegeNameA);
                    };
                case clsvUsersEN_js_1.clsvUsersEN.con_id_XzMajor:
                    return (a, b) => {
                        if (a.id_XzMajor == null)
                            return -1;
                        if (b.id_XzMajor == null)
                            return 1;
                        return a.id_XzMajor.localeCompare(b.id_XzMajor);
                    };
                case clsvUsersEN_js_1.clsvUsersEN.con_MajorName:
                    return (a, b) => {
                        if (a.majorName == null)
                            return -1;
                        if (b.majorName == null)
                            return 1;
                        return a.majorName.localeCompare(b.majorName);
                    };
                case clsvUsersEN_js_1.clsvUsersEN.con_IsLeaved:
                    return (a, b) => {
                        if (a.isLeaved == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvUsersEN_js_1.clsvUsersEN.con_StuIdTeacherId:
                    return (a, b) => {
                        if (a.stuIdTeacherId == null)
                            return -1;
                        if (b.stuIdTeacherId == null)
                            return 1;
                        return a.stuIdTeacherId.localeCompare(b.stuIdTeacherId);
                    };
                case clsvUsersEN_js_1.clsvUsersEN.con_IdentityID:
                    return (a, b) => {
                        return a.identityID.localeCompare(b.identityID);
                    };
                case clsvUsersEN_js_1.clsvUsersEN.con_IdentityDesc:
                    return (a, b) => {
                        if (a.identityDesc == null)
                            return -1;
                        if (b.identityDesc == null)
                            return 1;
                        return a.identityDesc.localeCompare(b.identityDesc);
                    };
                case clsvUsersEN_js_1.clsvUsersEN.con_AuditDate:
                    return (a, b) => {
                        if (a.auditDate == null)
                            return -1;
                        if (b.auditDate == null)
                            return 1;
                        return a.auditDate.localeCompare(b.auditDate);
                    };
                case clsvUsersEN_js_1.clsvUsersEN.con_AuditUser:
                    return (a, b) => {
                        if (a.auditUser == null)
                            return -1;
                        if (b.auditUser == null)
                            return 1;
                        return a.auditUser.localeCompare(b.auditUser);
                    };
                case clsvUsersEN_js_1.clsvUsersEN.con_IsAudit:
                    return (a, b) => {
                        if (a.isAudit == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvUsersEN_js_1.clsvUsersEN.con_IsRegister:
                    return (a, b) => {
                        if (a.isRegister == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvUsersEN_js_1.clsvUsersEN.con_RegisterDate:
                    return (a, b) => {
                        if (a.registerDate == null)
                            return -1;
                        if (b.registerDate == null)
                            return 1;
                        return a.registerDate.localeCompare(b.registerDate);
                    };
                case clsvUsersEN_js_1.clsvUsersEN.con_MobilePhone:
                    return (a, b) => {
                        if (a.mobilePhone == null)
                            return -1;
                        if (b.mobilePhone == null)
                            return 1;
                        return a.mobilePhone.localeCompare(b.mobilePhone);
                    };
                case clsvUsersEN_js_1.clsvUsersEN.con_UpdDate:
                    return (a, b) => {
                        if (a.updDate == null)
                            return -1;
                        if (b.updDate == null)
                            return 1;
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsvUsersEN_js_1.clsvUsersEN.con_UpdUser:
                    return (a, b) => {
                        if (a.updUser == null)
                            return -1;
                        if (b.updUser == null)
                            return 1;
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsvUsersEN_js_1.clsvUsersEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                case clsvUsersEN_js_1.clsvUsersEN.con_UserNameWithUserId:
                    return (a, b) => {
                        return a.userNameWithUserId.localeCompare(b.userNameWithUserId);
                    };
                case clsvUsersEN_js_1.clsvUsersEN.con_OpenId:
                    return (a, b) => {
                        if (a.openId == null)
                            return -1;
                        if (b.openId == null)
                            return 1;
                        return a.openId.localeCompare(b.openId);
                    };
                case clsvUsersEN_js_1.clsvUsersEN.con_AvatarsPicture:
                    return (a, b) => {
                        if (a.avatarsPicture == null)
                            return -1;
                        if (b.avatarsPicture == null)
                            return 1;
                        return a.avatarsPicture.localeCompare(b.avatarsPicture);
                    };
                case clsvUsersEN_js_1.clsvUsersEN.con_Email:
                    return (a, b) => {
                        if (a.email == null)
                            return -1;
                        if (b.email == null)
                            return 1;
                        return a.email.localeCompare(b.email);
                    };
                case clsvUsersEN_js_1.clsvUsersEN.con_PhoneNumber:
                    return (a, b) => {
                        if (a.phoneNumber == null)
                            return -1;
                        if (b.phoneNumber == null)
                            return 1;
                        return a.phoneNumber.localeCompare(b.phoneNumber);
                    };
                case clsvUsersEN_js_1.clsvUsersEN.con_HeadPic:
                    return (a, b) => {
                        if (a.headPic == null)
                            return -1;
                        if (b.headPic == null)
                            return 1;
                        return a.headPic.localeCompare(b.headPic);
                    };
                case clsvUsersEN_js_1.clsvUsersEN.con_IsGSuser:
                    return (a, b) => {
                        if (a.isGSuser == true)
                            return 1;
                        else
                            return -1;
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vUsers]中不存在！(in ${exports.vUsers_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsvUsersEN_js_1.clsvUsersEN.con_UserId:
                    return (a, b) => {
                        if (b.userId == null)
                            return -1;
                        if (a.userId == null)
                            return 1;
                        return b.userId.localeCompare(a.userId);
                    };
                case clsvUsersEN_js_1.clsvUsersEN.con_UserName:
                    return (a, b) => {
                        if (b.userName == null)
                            return -1;
                        if (a.userName == null)
                            return 1;
                        return b.userName.localeCompare(a.userName);
                    };
                case clsvUsersEN_js_1.clsvUsersEN.con_UserStateId:
                    return (a, b) => {
                        return b.userStateId.localeCompare(a.userStateId);
                    };
                case clsvUsersEN_js_1.clsvUsersEN.con_UserStateName:
                    return (a, b) => {
                        if (b.userStateName == null)
                            return -1;
                        if (a.userStateName == null)
                            return 1;
                        return b.userStateName.localeCompare(a.userStateName);
                    };
                case clsvUsersEN_js_1.clsvUsersEN.con_Password:
                    return (a, b) => {
                        if (b.password == null)
                            return -1;
                        if (a.password == null)
                            return 1;
                        return b.password.localeCompare(a.password);
                    };
                case clsvUsersEN_js_1.clsvUsersEN.con_IsGpUser:
                    return (a, b) => {
                        if (b.isGpUser == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvUsersEN_js_1.clsvUsersEN.con_BeginYearMonth:
                    return (a, b) => {
                        if (b.beginYearMonth == null)
                            return -1;
                        if (a.beginYearMonth == null)
                            return 1;
                        return b.beginYearMonth.localeCompare(a.beginYearMonth);
                    };
                case clsvUsersEN_js_1.clsvUsersEN.con_EndYearMonth:
                    return (a, b) => {
                        if (b.endYearMonth == null)
                            return -1;
                        if (a.endYearMonth == null)
                            return 1;
                        return b.endYearMonth.localeCompare(a.endYearMonth);
                    };
                case clsvUsersEN_js_1.clsvUsersEN.con_id_GradeBase:
                    return (a, b) => {
                        if (b.id_GradeBase == null)
                            return -1;
                        if (a.id_GradeBase == null)
                            return 1;
                        return b.id_GradeBase.localeCompare(a.id_GradeBase);
                    };
                case clsvUsersEN_js_1.clsvUsersEN.con_GradeBaseName:
                    return (a, b) => {
                        if (b.gradeBaseName == null)
                            return -1;
                        if (a.gradeBaseName == null)
                            return 1;
                        return b.gradeBaseName.localeCompare(a.gradeBaseName);
                    };
                case clsvUsersEN_js_1.clsvUsersEN.con_id_XzCollege:
                    return (a, b) => {
                        if (b.id_XzCollege == null)
                            return -1;
                        if (a.id_XzCollege == null)
                            return 1;
                        return b.id_XzCollege.localeCompare(a.id_XzCollege);
                    };
                case clsvUsersEN_js_1.clsvUsersEN.con_CollegeID:
                    return (a, b) => {
                        if (b.collegeID == null)
                            return -1;
                        if (a.collegeID == null)
                            return 1;
                        return b.collegeID.localeCompare(a.collegeID);
                    };
                case clsvUsersEN_js_1.clsvUsersEN.con_CollegeName:
                    return (a, b) => {
                        if (b.collegeName == null)
                            return -1;
                        if (a.collegeName == null)
                            return 1;
                        return b.collegeName.localeCompare(a.collegeName);
                    };
                case clsvUsersEN_js_1.clsvUsersEN.con_CollegeNameA:
                    return (a, b) => {
                        if (b.collegeNameA == null)
                            return -1;
                        if (a.collegeNameA == null)
                            return 1;
                        return b.collegeNameA.localeCompare(a.collegeNameA);
                    };
                case clsvUsersEN_js_1.clsvUsersEN.con_id_XzMajor:
                    return (a, b) => {
                        if (b.id_XzMajor == null)
                            return -1;
                        if (a.id_XzMajor == null)
                            return 1;
                        return b.id_XzMajor.localeCompare(a.id_XzMajor);
                    };
                case clsvUsersEN_js_1.clsvUsersEN.con_MajorName:
                    return (a, b) => {
                        if (b.majorName == null)
                            return -1;
                        if (a.majorName == null)
                            return 1;
                        return b.majorName.localeCompare(a.majorName);
                    };
                case clsvUsersEN_js_1.clsvUsersEN.con_IsLeaved:
                    return (a, b) => {
                        if (b.isLeaved == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvUsersEN_js_1.clsvUsersEN.con_StuIdTeacherId:
                    return (a, b) => {
                        if (b.stuIdTeacherId == null)
                            return -1;
                        if (a.stuIdTeacherId == null)
                            return 1;
                        return b.stuIdTeacherId.localeCompare(a.stuIdTeacherId);
                    };
                case clsvUsersEN_js_1.clsvUsersEN.con_IdentityID:
                    return (a, b) => {
                        return b.identityID.localeCompare(a.identityID);
                    };
                case clsvUsersEN_js_1.clsvUsersEN.con_IdentityDesc:
                    return (a, b) => {
                        if (b.identityDesc == null)
                            return -1;
                        if (a.identityDesc == null)
                            return 1;
                        return b.identityDesc.localeCompare(a.identityDesc);
                    };
                case clsvUsersEN_js_1.clsvUsersEN.con_AuditDate:
                    return (a, b) => {
                        if (b.auditDate == null)
                            return -1;
                        if (a.auditDate == null)
                            return 1;
                        return b.auditDate.localeCompare(a.auditDate);
                    };
                case clsvUsersEN_js_1.clsvUsersEN.con_AuditUser:
                    return (a, b) => {
                        if (b.auditUser == null)
                            return -1;
                        if (a.auditUser == null)
                            return 1;
                        return b.auditUser.localeCompare(a.auditUser);
                    };
                case clsvUsersEN_js_1.clsvUsersEN.con_IsAudit:
                    return (a, b) => {
                        if (b.isAudit == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvUsersEN_js_1.clsvUsersEN.con_IsRegister:
                    return (a, b) => {
                        if (b.isRegister == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvUsersEN_js_1.clsvUsersEN.con_RegisterDate:
                    return (a, b) => {
                        if (b.registerDate == null)
                            return -1;
                        if (a.registerDate == null)
                            return 1;
                        return b.registerDate.localeCompare(a.registerDate);
                    };
                case clsvUsersEN_js_1.clsvUsersEN.con_MobilePhone:
                    return (a, b) => {
                        if (b.mobilePhone == null)
                            return -1;
                        if (a.mobilePhone == null)
                            return 1;
                        return b.mobilePhone.localeCompare(a.mobilePhone);
                    };
                case clsvUsersEN_js_1.clsvUsersEN.con_UpdDate:
                    return (a, b) => {
                        if (b.updDate == null)
                            return -1;
                        if (a.updDate == null)
                            return 1;
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsvUsersEN_js_1.clsvUsersEN.con_UpdUser:
                    return (a, b) => {
                        if (b.updUser == null)
                            return -1;
                        if (a.updUser == null)
                            return 1;
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsvUsersEN_js_1.clsvUsersEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                case clsvUsersEN_js_1.clsvUsersEN.con_UserNameWithUserId:
                    return (a, b) => {
                        return b.userNameWithUserId.localeCompare(a.userNameWithUserId);
                    };
                case clsvUsersEN_js_1.clsvUsersEN.con_OpenId:
                    return (a, b) => {
                        if (b.openId == null)
                            return -1;
                        if (a.openId == null)
                            return 1;
                        return b.openId.localeCompare(a.openId);
                    };
                case clsvUsersEN_js_1.clsvUsersEN.con_AvatarsPicture:
                    return (a, b) => {
                        if (b.avatarsPicture == null)
                            return -1;
                        if (a.avatarsPicture == null)
                            return 1;
                        return b.avatarsPicture.localeCompare(a.avatarsPicture);
                    };
                case clsvUsersEN_js_1.clsvUsersEN.con_Email:
                    return (a, b) => {
                        if (b.email == null)
                            return -1;
                        if (a.email == null)
                            return 1;
                        return b.email.localeCompare(a.email);
                    };
                case clsvUsersEN_js_1.clsvUsersEN.con_PhoneNumber:
                    return (a, b) => {
                        if (b.phoneNumber == null)
                            return -1;
                        if (a.phoneNumber == null)
                            return 1;
                        return b.phoneNumber.localeCompare(a.phoneNumber);
                    };
                case clsvUsersEN_js_1.clsvUsersEN.con_HeadPic:
                    return (a, b) => {
                        if (b.headPic == null)
                            return -1;
                        if (a.headPic == null)
                            return 1;
                        return b.headPic.localeCompare(a.headPic);
                    };
                case clsvUsersEN_js_1.clsvUsersEN.con_IsGSuser:
                    return (a, b) => {
                        if (b.isGSuser == true)
                            return 1;
                        else
                            return -1;
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vUsers]中不存在！(in ${exports.vUsers_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.vUsers_SortFunByKey = vUsers_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-02-24
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function vUsers_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsvUsersEN_js_1.clsvUsersEN.con_UserId:
                return (obj) => {
                    return obj.userId === value;
                };
            case clsvUsersEN_js_1.clsvUsersEN.con_UserName:
                return (obj) => {
                    return obj.userName === value;
                };
            case clsvUsersEN_js_1.clsvUsersEN.con_UserStateId:
                return (obj) => {
                    return obj.userStateId === value;
                };
            case clsvUsersEN_js_1.clsvUsersEN.con_UserStateName:
                return (obj) => {
                    return obj.userStateName === value;
                };
            case clsvUsersEN_js_1.clsvUsersEN.con_Password:
                return (obj) => {
                    return obj.password === value;
                };
            case clsvUsersEN_js_1.clsvUsersEN.con_IsGpUser:
                return (obj) => {
                    return obj.isGpUser === value;
                };
            case clsvUsersEN_js_1.clsvUsersEN.con_BeginYearMonth:
                return (obj) => {
                    return obj.beginYearMonth === value;
                };
            case clsvUsersEN_js_1.clsvUsersEN.con_EndYearMonth:
                return (obj) => {
                    return obj.endYearMonth === value;
                };
            case clsvUsersEN_js_1.clsvUsersEN.con_id_GradeBase:
                return (obj) => {
                    return obj.id_GradeBase === value;
                };
            case clsvUsersEN_js_1.clsvUsersEN.con_GradeBaseName:
                return (obj) => {
                    return obj.gradeBaseName === value;
                };
            case clsvUsersEN_js_1.clsvUsersEN.con_id_XzCollege:
                return (obj) => {
                    return obj.id_XzCollege === value;
                };
            case clsvUsersEN_js_1.clsvUsersEN.con_CollegeID:
                return (obj) => {
                    return obj.collegeID === value;
                };
            case clsvUsersEN_js_1.clsvUsersEN.con_CollegeName:
                return (obj) => {
                    return obj.collegeName === value;
                };
            case clsvUsersEN_js_1.clsvUsersEN.con_CollegeNameA:
                return (obj) => {
                    return obj.collegeNameA === value;
                };
            case clsvUsersEN_js_1.clsvUsersEN.con_id_XzMajor:
                return (obj) => {
                    return obj.id_XzMajor === value;
                };
            case clsvUsersEN_js_1.clsvUsersEN.con_MajorName:
                return (obj) => {
                    return obj.majorName === value;
                };
            case clsvUsersEN_js_1.clsvUsersEN.con_IsLeaved:
                return (obj) => {
                    return obj.isLeaved === value;
                };
            case clsvUsersEN_js_1.clsvUsersEN.con_StuIdTeacherId:
                return (obj) => {
                    return obj.stuIdTeacherId === value;
                };
            case clsvUsersEN_js_1.clsvUsersEN.con_IdentityID:
                return (obj) => {
                    return obj.identityID === value;
                };
            case clsvUsersEN_js_1.clsvUsersEN.con_IdentityDesc:
                return (obj) => {
                    return obj.identityDesc === value;
                };
            case clsvUsersEN_js_1.clsvUsersEN.con_AuditDate:
                return (obj) => {
                    return obj.auditDate === value;
                };
            case clsvUsersEN_js_1.clsvUsersEN.con_AuditUser:
                return (obj) => {
                    return obj.auditUser === value;
                };
            case clsvUsersEN_js_1.clsvUsersEN.con_IsAudit:
                return (obj) => {
                    return obj.isAudit === value;
                };
            case clsvUsersEN_js_1.clsvUsersEN.con_IsRegister:
                return (obj) => {
                    return obj.isRegister === value;
                };
            case clsvUsersEN_js_1.clsvUsersEN.con_RegisterDate:
                return (obj) => {
                    return obj.registerDate === value;
                };
            case clsvUsersEN_js_1.clsvUsersEN.con_MobilePhone:
                return (obj) => {
                    return obj.mobilePhone === value;
                };
            case clsvUsersEN_js_1.clsvUsersEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsvUsersEN_js_1.clsvUsersEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsvUsersEN_js_1.clsvUsersEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            case clsvUsersEN_js_1.clsvUsersEN.con_UserNameWithUserId:
                return (obj) => {
                    return obj.userNameWithUserId === value;
                };
            case clsvUsersEN_js_1.clsvUsersEN.con_OpenId:
                return (obj) => {
                    return obj.openId === value;
                };
            case clsvUsersEN_js_1.clsvUsersEN.con_AvatarsPicture:
                return (obj) => {
                    return obj.avatarsPicture === value;
                };
            case clsvUsersEN_js_1.clsvUsersEN.con_Email:
                return (obj) => {
                    return obj.email === value;
                };
            case clsvUsersEN_js_1.clsvUsersEN.con_PhoneNumber:
                return (obj) => {
                    return obj.phoneNumber === value;
                };
            case clsvUsersEN_js_1.clsvUsersEN.con_HeadPic:
                return (obj) => {
                    return obj.headPic === value;
                };
            case clsvUsersEN_js_1.clsvUsersEN.con_IsGSuser:
                return (obj) => {
                    return obj.isGSuser === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[vUsers]中不存在！(in ${exports.vUsers_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.vUsers_FilterFunByKey = vUsers_FilterFunByKey;
    /**
     * 映射函数。根据表映射把输入字段值，映射成输出字段值
     * 作者:pyf
     * 日期:2023-02-24
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_funcKey)
     * @param strInFldName:输入字段名
     * @param strInValue:输入字段值
     * @param strComparisonOp:比较操作符
     * @returns 返回一个关键字值列表
    */
    async function vUsers_funcKey(strInFldName, strInValue, strComparisonOp) {
        //const strThisFuncName = "funcKey";
        if (strInFldName == clsvUsersEN_js_1.clsvUsersEN.con_UserId) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(strInValue) == true) {
            return [];
        }
        const arrvUsers = await vUsers_GetObjLst_Cache();
        if (arrvUsers == null)
            return [];
        let arrvUsers_Sel = arrvUsers;
        const strType = typeof (strInValue);
        switch (strType) {
            case "string":
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01: // " = "
                        arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.Like_03:
                        arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.In_04:
                        const arrValues = strInValue.split(',');
                        arrvUsers_Sel = arrvUsers_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
                        break;
                }
                break;
            case "boolean":
                if (strInValue == null)
                    return [];
                if (strComparisonOp == enumComparisonOp_js_1.enumComparisonOp.Equal_01) {
                    arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                }
                break;
            case "number":
                if (Number(strInValue) == 0)
                    return [];
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01:
                        arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotEqual_02:
                        arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotLessThan_05: //" >= ":
                        arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotGreaterThan_06: //" <= ":
                        arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.GreaterThan_07: //" > ":
                        arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.LessThan_08: //" < ":
                        arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                }
                break;
        }
        if (arrvUsers_Sel.length == 0)
            return [];
        return arrvUsers_Sel.map(x => x.userId);
    }
    exports.vUsers_funcKey = vUsers_funcKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function vUsers_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vUsers_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vUsers_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vUsers_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vUsers_GetFirstIDAsync = vUsers_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function vUsers_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vUsers_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vUsers_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vUsers_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vUsers_GetFirstID = vUsers_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function vUsers_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vUsers_Controller, strAction);
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
                const objvUsers = vUsers_GetObjFromJsonObj(returnObj);
                return objvUsers;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vUsers_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vUsers_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vUsers_GetFirstObjAsync = vUsers_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vUsers_GetObjLst_ClientCache() {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsvUsersEN_js_1.clsvUsersEN._CurrTabName;
        clsvUsersEN_js_1.clsvUsersEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsvUsersEN_js_1.clsvUsersEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvUsersEN_js_1.clsvUsersEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvUsersEN_js_1.clsvUsersEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_2.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrvUsersExObjLst_Cache = CacheHelper_js_2.CacheHelper.Get(strKey);
            const arrvUsersObjLst_T = vUsers_GetObjLstByJSONObjLst(arrvUsersExObjLst_Cache);
            return arrvUsersObjLst_T;
        }
        try {
            const arrvUsersExObjLst = await vUsers_GetObjLstAsync(strWhereCond);
            CacheHelper_js_2.CacheHelper.Add(strKey, arrvUsersExObjLst);
            const strInfo = (0, clsString_js_1.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvUsersExObjLst.length);
            console.log(strInfo);
            return arrvUsersExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vUsers_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vUsers_GetObjLst_ClientCache = vUsers_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vUsers_GetObjLst_localStorage() {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsvUsersEN_js_1.clsvUsersEN._CurrTabName;
        clsvUsersEN_js_1.clsvUsersEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsvUsersEN_js_1.clsvUsersEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvUsersEN_js_1.clsvUsersEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvUsersEN_js_1.clsvUsersEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrvUsersExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrvUsersObjLst_T = vUsers_GetObjLstByJSONObjLst(arrvUsersExObjLst_Cache);
            return arrvUsersObjLst_T;
        }
        try {
            const arrvUsersExObjLst = await vUsers_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrvUsersExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvUsersExObjLst.length);
            console.log(strInfo);
            return arrvUsersExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vUsers_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vUsers_GetObjLst_localStorage = vUsers_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vUsers_GetObjLst_localStorage_PureCache() {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsvUsersEN_js_1.clsvUsersEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrvUsersObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvUsersObjLst_Cache;
        }
        else
            return null;
    }
    exports.vUsers_GetObjLst_localStorage_PureCache = vUsers_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function vUsers_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vUsers_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vUsers_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vUsers_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vUsers_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vUsers_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vUsers_GetObjLstAsync = vUsers_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vUsers_GetObjLst_sessionStorage() {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsvUsersEN_js_1.clsvUsersEN._CurrTabName;
        clsvUsersEN_js_1.clsvUsersEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsvUsersEN_js_1.clsvUsersEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvUsersEN_js_1.clsvUsersEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvUsersEN_js_1.clsvUsersEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrvUsersExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrvUsersObjLst_T = vUsers_GetObjLstByJSONObjLst(arrvUsersExObjLst_Cache);
            return arrvUsersObjLst_T;
        }
        try {
            const arrvUsersExObjLst = await vUsers_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrvUsersExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvUsersExObjLst.length);
            console.log(strInfo);
            return arrvUsersExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vUsers_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vUsers_GetObjLst_sessionStorage = vUsers_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vUsers_GetObjLst_sessionStorage_PureCache() {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsvUsersEN_js_1.clsvUsersEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrvUsersObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvUsersObjLst_Cache;
        }
        else
            return null;
    }
    exports.vUsers_GetObjLst_sessionStorage_PureCache = vUsers_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vUsers_GetObjLst_Cache() {
        //const strThisFuncName = "GetObjLst_Cache";
        let arrvUsersObjLst_Cache;
        switch (clsvUsersEN_js_1.clsvUsersEN.CacheModeId) {
            case "04": //sessionStorage
                arrvUsersObjLst_Cache = await vUsers_GetObjLst_sessionStorage();
                break;
            case "03": //localStorage
                arrvUsersObjLst_Cache = await vUsers_GetObjLst_localStorage();
                break;
            case "02": //ClientCache
                arrvUsersObjLst_Cache = await vUsers_GetObjLst_ClientCache();
                break;
            default:
                arrvUsersObjLst_Cache = await vUsers_GetObjLst_ClientCache();
                break;
        }
        const arrvUsersObjLst = vUsers_GetObjLstByJSONObjLst(arrvUsersObjLst_Cache);
        return arrvUsersObjLst_Cache;
    }
    exports.vUsers_GetObjLst_Cache = vUsers_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vUsers_GetObjLst_PureCache() {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrvUsersObjLst_Cache;
        switch (clsvUsersEN_js_1.clsvUsersEN.CacheModeId) {
            case "04": //sessionStorage
                arrvUsersObjLst_Cache = await vUsers_GetObjLst_sessionStorage_PureCache();
                break;
            case "03": //localStorage
                arrvUsersObjLst_Cache = await vUsers_GetObjLst_localStorage_PureCache();
                break;
            case "02": //ClientCache
                arrvUsersObjLst_Cache = null;
                break;
            default:
                arrvUsersObjLst_Cache = null;
                break;
        }
        return arrvUsersObjLst_Cache;
    }
    exports.vUsers_GetObjLst_PureCache = vUsers_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objstrUserId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function vUsers_GetSubObjLst_Cache(objvUsers_Cond) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrvUsersObjLst_Cache = await vUsers_GetObjLst_Cache();
        let arrvUsers_Sel = arrvUsersObjLst_Cache;
        if (objvUsers_Cond.sf_FldComparisonOp == null || objvUsers_Cond.sf_FldComparisonOp == "")
            return arrvUsers_Sel;
        const dicFldComparisonOp = JSON.parse(objvUsers_Cond.sf_FldComparisonOp);
        //console.log("clsvUsersWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvUsers_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvUsers_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrvUsers_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objvUsers_Cond), exports.vUsers_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vUsers_GetSubObjLst_Cache = vUsers_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrUserId:关键字列表
    * @returns 对象列表
    **/
    async function vUsers_GetObjLstByUserIdLstAsync(arrUserId) {
        const strThisFuncName = "GetObjLstByUserIdLstAsync";
        const strAction = "GetObjLstByUserIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vUsers_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrUserId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vUsers_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vUsers_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vUsers_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vUsers_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vUsers_GetObjLstByUserIdLstAsync = vUsers_GetObjLstByUserIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrstrUserIdLst:关键字列表
     * @returns 对象列表
    */
    async function vUsers_GetObjLstByUserIdLst_Cache(arrUserIdLst) {
        const strThisFuncName = "GetObjLstByUserIdLst_Cache";
        try {
            const arrvUsersObjLst_Cache = await vUsers_GetObjLst_Cache();
            const arrvUsers_Sel = arrvUsersObjLst_Cache.filter(x => arrUserIdLst.indexOf(x.userId) > -1);
            return arrvUsers_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrUserIdLst.join(","), exports.vUsers_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vUsers_GetObjLstByUserIdLst_Cache = vUsers_GetObjLstByUserIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function vUsers_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vUsers_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vUsers_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vUsers_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vUsers_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vUsers_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vUsers_GetTopObjLstAsync = vUsers_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vUsers_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vUsers_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vUsers_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vUsers_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vUsers_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vUsers_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vUsers_GetObjLstByRangeAsync = vUsers_GetObjLstByRangeAsync;
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
    async function vUsers_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vUsers_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vUsers_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vUsers_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vUsers_GetObjLstByRange = vUsers_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function vUsers_GetObjLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const arrvUsersObjLst_Cache = await vUsers_GetObjLst_Cache();
        if (arrvUsersObjLst_Cache.length == 0)
            return arrvUsersObjLst_Cache;
        let arrvUsers_Sel = arrvUsersObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objvUsers_Cond = new clsvUsersEN_js_1.clsvUsersEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvUsers_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsvUsersWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvUsers_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrvUsers_Sel = arrvUsers_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvUsers_Sel.length == 0)
                return arrvUsers_Sel;
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
                arrvUsers_Sel = arrvUsers_Sel.sort(vUsers_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrvUsers_Sel = arrvUsers_Sel.sort(objPagerPara.sortFun);
            }
            arrvUsers_Sel = arrvUsers_Sel.slice(intStart, intEnd);
            return arrvUsers_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.vUsers_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vUsers_GetObjLstByPager_Cache = vUsers_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vUsers_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vUsers_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vUsers_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vUsers_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vUsers_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vUsers_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vUsers_GetObjLstByPagerAsync = vUsers_GetObjLstByPagerAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objstrUserId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function vUsers_IsExistRecord_Cache(objvUsers_Cond) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrvUsersObjLst_Cache = await vUsers_GetObjLst_Cache();
        if (arrvUsersObjLst_Cache == null)
            return false;
        let arrvUsers_Sel = arrvUsersObjLst_Cache;
        if (objvUsers_Cond.sf_FldComparisonOp == null || objvUsers_Cond.sf_FldComparisonOp == "")
            return arrvUsers_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objvUsers_Cond.sf_FldComparisonOp);
        //console.log("clsvUsersWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvUsers_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvUsers_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvUsers_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objvUsers_Cond), exports.vUsers_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.vUsers_IsExistRecord_Cache = vUsers_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function vUsers_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vUsers_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vUsers_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vUsers_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vUsers_IsExistRecordAsync = vUsers_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strUserId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function vUsers_IsExist(strUserId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vUsers_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vUsers_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vUsers_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vUsers_IsExist = vUsers_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param strUserId:所给的关键字
     * @returns 对象
    */
    async function vUsers_IsExist_Cache(strUserId) {
        const strThisFuncName = "IsExist_Cache";
        const arrvUsersObjLst_Cache = await vUsers_GetObjLst_Cache();
        if (arrvUsersObjLst_Cache == null)
            return false;
        try {
            const arrvUsers_Sel = arrvUsersObjLst_Cache.filter(x => x.userId == strUserId);
            if (arrvUsers_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strUserId, exports.vUsers_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.vUsers_IsExist_Cache = vUsers_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strUserId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function vUsers_IsExistAsync(strUserId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vUsers_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vUsers_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vUsers_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vUsers_IsExistAsync = vUsers_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function vUsers_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vUsers_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vUsers_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vUsers_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vUsers_GetRecCountByCondAsync = vUsers_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objvUsers_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function vUsers_GetRecCountByCond_Cache(objvUsers_Cond) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrvUsersObjLst_Cache = await vUsers_GetObjLst_Cache();
        if (arrvUsersObjLst_Cache == null)
            return 0;
        let arrvUsers_Sel = arrvUsersObjLst_Cache;
        if (objvUsers_Cond.sf_FldComparisonOp == null || objvUsers_Cond.sf_FldComparisonOp == "")
            return arrvUsers_Sel.length;
        const dicFldComparisonOp = JSON.parse(objvUsers_Cond.sf_FldComparisonOp);
        //console.log("clsvUsersWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvUsers_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvUsers_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrvUsers_Sel = arrvUsers_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrvUsers_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objvUsers_Cond), exports.vUsers_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.vUsers_GetRecCountByCond_Cache = vUsers_GetRecCountByCond_Cache;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function vUsers_GetWebApiUrl(strController, strAction) {
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
    exports.vUsers_GetWebApiUrl = vUsers_GetWebApiUrl;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function vUsers_ReFreshThisCache() {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = clsvUsersEN_js_1.clsvUsersEN._CurrTabName;
            switch (clsvUsersEN_js_1.clsvUsersEN.CacheModeId) {
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
    exports.vUsers_ReFreshThisCache = vUsers_ReFreshThisCache;
    /* 该表的下拉框功能没有设置，不需要生成下拉框绑定函数。*/
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-02-24
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vUsers_GetJSONStrByObj(pobjvUsersEN) {
        const strThisFuncName = "GetJSONStrByObj";
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjvUsersEN);
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
    exports.vUsers_GetJSONStrByObj = vUsers_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-02-24
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function vUsers_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrvUsersObjLst = new Array();
        if (strJSON === "") {
            return arrvUsersObjLst;
        }
        try {
            arrvUsersObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrvUsersObjLst;
        }
        return arrvUsersObjLst;
    }
    exports.vUsers_GetObjLstByJSONStr = vUsers_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-02-24
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrvUsersObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function vUsers_GetObjLstByJSONObjLst(arrvUsersObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrvUsersObjLst = new Array();
        for (const objInFor of arrvUsersObjLstS) {
            const obj1 = vUsers_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrvUsersObjLst.push(obj1);
        }
        return arrvUsersObjLst;
    }
    exports.vUsers_GetObjLstByJSONObjLst = vUsers_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-02-24
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vUsers_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjvUsersEN = new clsvUsersEN_js_1.clsvUsersEN();
        if (strJSON === "") {
            return pobjvUsersEN;
        }
        try {
            pobjvUsersEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjvUsersEN;
        }
        return pobjvUsersEN;
    }
    exports.vUsers_GetObjByJSONStr = vUsers_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function vUsers_GetCombineCondition(objvUsers_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objvUsers_Cond.dicFldComparisonOp, clsvUsersEN_js_1.clsvUsersEN.con_UserId) == true) {
            const strComparisonOp_UserId = objvUsers_Cond.dicFldComparisonOp[clsvUsersEN_js_1.clsvUsersEN.con_UserId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvUsersEN_js_1.clsvUsersEN.con_UserId, objvUsers_Cond.userId, strComparisonOp_UserId);
        }
        if (Object.prototype.hasOwnProperty.call(objvUsers_Cond.dicFldComparisonOp, clsvUsersEN_js_1.clsvUsersEN.con_UserName) == true) {
            const strComparisonOp_UserName = objvUsers_Cond.dicFldComparisonOp[clsvUsersEN_js_1.clsvUsersEN.con_UserName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvUsersEN_js_1.clsvUsersEN.con_UserName, objvUsers_Cond.userName, strComparisonOp_UserName);
        }
        if (Object.prototype.hasOwnProperty.call(objvUsers_Cond.dicFldComparisonOp, clsvUsersEN_js_1.clsvUsersEN.con_UserStateId) == true) {
            const strComparisonOp_UserStateId = objvUsers_Cond.dicFldComparisonOp[clsvUsersEN_js_1.clsvUsersEN.con_UserStateId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvUsersEN_js_1.clsvUsersEN.con_UserStateId, objvUsers_Cond.userStateId, strComparisonOp_UserStateId);
        }
        if (Object.prototype.hasOwnProperty.call(objvUsers_Cond.dicFldComparisonOp, clsvUsersEN_js_1.clsvUsersEN.con_UserStateName) == true) {
            const strComparisonOp_UserStateName = objvUsers_Cond.dicFldComparisonOp[clsvUsersEN_js_1.clsvUsersEN.con_UserStateName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvUsersEN_js_1.clsvUsersEN.con_UserStateName, objvUsers_Cond.userStateName, strComparisonOp_UserStateName);
        }
        if (Object.prototype.hasOwnProperty.call(objvUsers_Cond.dicFldComparisonOp, clsvUsersEN_js_1.clsvUsersEN.con_Password) == true) {
            const strComparisonOp_Password = objvUsers_Cond.dicFldComparisonOp[clsvUsersEN_js_1.clsvUsersEN.con_Password];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvUsersEN_js_1.clsvUsersEN.con_Password, objvUsers_Cond.password, strComparisonOp_Password);
        }
        if (Object.prototype.hasOwnProperty.call(objvUsers_Cond.dicFldComparisonOp, clsvUsersEN_js_1.clsvUsersEN.con_IsGpUser) == true) {
            if (objvUsers_Cond.isGpUser == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvUsersEN_js_1.clsvUsersEN.con_IsGpUser);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvUsersEN_js_1.clsvUsersEN.con_IsGpUser);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvUsers_Cond.dicFldComparisonOp, clsvUsersEN_js_1.clsvUsersEN.con_BeginYearMonth) == true) {
            const strComparisonOp_BeginYearMonth = objvUsers_Cond.dicFldComparisonOp[clsvUsersEN_js_1.clsvUsersEN.con_BeginYearMonth];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvUsersEN_js_1.clsvUsersEN.con_BeginYearMonth, objvUsers_Cond.beginYearMonth, strComparisonOp_BeginYearMonth);
        }
        if (Object.prototype.hasOwnProperty.call(objvUsers_Cond.dicFldComparisonOp, clsvUsersEN_js_1.clsvUsersEN.con_EndYearMonth) == true) {
            const strComparisonOp_EndYearMonth = objvUsers_Cond.dicFldComparisonOp[clsvUsersEN_js_1.clsvUsersEN.con_EndYearMonth];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvUsersEN_js_1.clsvUsersEN.con_EndYearMonth, objvUsers_Cond.endYearMonth, strComparisonOp_EndYearMonth);
        }
        if (Object.prototype.hasOwnProperty.call(objvUsers_Cond.dicFldComparisonOp, clsvUsersEN_js_1.clsvUsersEN.con_id_GradeBase) == true) {
            const strComparisonOp_id_GradeBase = objvUsers_Cond.dicFldComparisonOp[clsvUsersEN_js_1.clsvUsersEN.con_id_GradeBase];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvUsersEN_js_1.clsvUsersEN.con_id_GradeBase, objvUsers_Cond.id_GradeBase, strComparisonOp_id_GradeBase);
        }
        if (Object.prototype.hasOwnProperty.call(objvUsers_Cond.dicFldComparisonOp, clsvUsersEN_js_1.clsvUsersEN.con_GradeBaseName) == true) {
            const strComparisonOp_GradeBaseName = objvUsers_Cond.dicFldComparisonOp[clsvUsersEN_js_1.clsvUsersEN.con_GradeBaseName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvUsersEN_js_1.clsvUsersEN.con_GradeBaseName, objvUsers_Cond.gradeBaseName, strComparisonOp_GradeBaseName);
        }
        if (Object.prototype.hasOwnProperty.call(objvUsers_Cond.dicFldComparisonOp, clsvUsersEN_js_1.clsvUsersEN.con_id_XzCollege) == true) {
            const strComparisonOp_id_XzCollege = objvUsers_Cond.dicFldComparisonOp[clsvUsersEN_js_1.clsvUsersEN.con_id_XzCollege];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvUsersEN_js_1.clsvUsersEN.con_id_XzCollege, objvUsers_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
        }
        if (Object.prototype.hasOwnProperty.call(objvUsers_Cond.dicFldComparisonOp, clsvUsersEN_js_1.clsvUsersEN.con_CollegeID) == true) {
            const strComparisonOp_CollegeID = objvUsers_Cond.dicFldComparisonOp[clsvUsersEN_js_1.clsvUsersEN.con_CollegeID];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvUsersEN_js_1.clsvUsersEN.con_CollegeID, objvUsers_Cond.collegeID, strComparisonOp_CollegeID);
        }
        if (Object.prototype.hasOwnProperty.call(objvUsers_Cond.dicFldComparisonOp, clsvUsersEN_js_1.clsvUsersEN.con_CollegeName) == true) {
            const strComparisonOp_CollegeName = objvUsers_Cond.dicFldComparisonOp[clsvUsersEN_js_1.clsvUsersEN.con_CollegeName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvUsersEN_js_1.clsvUsersEN.con_CollegeName, objvUsers_Cond.collegeName, strComparisonOp_CollegeName);
        }
        if (Object.prototype.hasOwnProperty.call(objvUsers_Cond.dicFldComparisonOp, clsvUsersEN_js_1.clsvUsersEN.con_CollegeNameA) == true) {
            const strComparisonOp_CollegeNameA = objvUsers_Cond.dicFldComparisonOp[clsvUsersEN_js_1.clsvUsersEN.con_CollegeNameA];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvUsersEN_js_1.clsvUsersEN.con_CollegeNameA, objvUsers_Cond.collegeNameA, strComparisonOp_CollegeNameA);
        }
        if (Object.prototype.hasOwnProperty.call(objvUsers_Cond.dicFldComparisonOp, clsvUsersEN_js_1.clsvUsersEN.con_id_XzMajor) == true) {
            const strComparisonOp_id_XzMajor = objvUsers_Cond.dicFldComparisonOp[clsvUsersEN_js_1.clsvUsersEN.con_id_XzMajor];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvUsersEN_js_1.clsvUsersEN.con_id_XzMajor, objvUsers_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
        }
        if (Object.prototype.hasOwnProperty.call(objvUsers_Cond.dicFldComparisonOp, clsvUsersEN_js_1.clsvUsersEN.con_MajorName) == true) {
            const strComparisonOp_MajorName = objvUsers_Cond.dicFldComparisonOp[clsvUsersEN_js_1.clsvUsersEN.con_MajorName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvUsersEN_js_1.clsvUsersEN.con_MajorName, objvUsers_Cond.majorName, strComparisonOp_MajorName);
        }
        if (Object.prototype.hasOwnProperty.call(objvUsers_Cond.dicFldComparisonOp, clsvUsersEN_js_1.clsvUsersEN.con_IsLeaved) == true) {
            if (objvUsers_Cond.isLeaved == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvUsersEN_js_1.clsvUsersEN.con_IsLeaved);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvUsersEN_js_1.clsvUsersEN.con_IsLeaved);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvUsers_Cond.dicFldComparisonOp, clsvUsersEN_js_1.clsvUsersEN.con_StuIdTeacherId) == true) {
            const strComparisonOp_StuIdTeacherId = objvUsers_Cond.dicFldComparisonOp[clsvUsersEN_js_1.clsvUsersEN.con_StuIdTeacherId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvUsersEN_js_1.clsvUsersEN.con_StuIdTeacherId, objvUsers_Cond.stuIdTeacherId, strComparisonOp_StuIdTeacherId);
        }
        if (Object.prototype.hasOwnProperty.call(objvUsers_Cond.dicFldComparisonOp, clsvUsersEN_js_1.clsvUsersEN.con_IdentityID) == true) {
            const strComparisonOp_IdentityID = objvUsers_Cond.dicFldComparisonOp[clsvUsersEN_js_1.clsvUsersEN.con_IdentityID];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvUsersEN_js_1.clsvUsersEN.con_IdentityID, objvUsers_Cond.identityID, strComparisonOp_IdentityID);
        }
        if (Object.prototype.hasOwnProperty.call(objvUsers_Cond.dicFldComparisonOp, clsvUsersEN_js_1.clsvUsersEN.con_IdentityDesc) == true) {
            const strComparisonOp_IdentityDesc = objvUsers_Cond.dicFldComparisonOp[clsvUsersEN_js_1.clsvUsersEN.con_IdentityDesc];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvUsersEN_js_1.clsvUsersEN.con_IdentityDesc, objvUsers_Cond.identityDesc, strComparisonOp_IdentityDesc);
        }
        if (Object.prototype.hasOwnProperty.call(objvUsers_Cond.dicFldComparisonOp, clsvUsersEN_js_1.clsvUsersEN.con_AuditDate) == true) {
            const strComparisonOp_AuditDate = objvUsers_Cond.dicFldComparisonOp[clsvUsersEN_js_1.clsvUsersEN.con_AuditDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvUsersEN_js_1.clsvUsersEN.con_AuditDate, objvUsers_Cond.auditDate, strComparisonOp_AuditDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvUsers_Cond.dicFldComparisonOp, clsvUsersEN_js_1.clsvUsersEN.con_AuditUser) == true) {
            const strComparisonOp_AuditUser = objvUsers_Cond.dicFldComparisonOp[clsvUsersEN_js_1.clsvUsersEN.con_AuditUser];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvUsersEN_js_1.clsvUsersEN.con_AuditUser, objvUsers_Cond.auditUser, strComparisonOp_AuditUser);
        }
        if (Object.prototype.hasOwnProperty.call(objvUsers_Cond.dicFldComparisonOp, clsvUsersEN_js_1.clsvUsersEN.con_IsAudit) == true) {
            if (objvUsers_Cond.isAudit == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvUsersEN_js_1.clsvUsersEN.con_IsAudit);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvUsersEN_js_1.clsvUsersEN.con_IsAudit);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvUsers_Cond.dicFldComparisonOp, clsvUsersEN_js_1.clsvUsersEN.con_IsRegister) == true) {
            if (objvUsers_Cond.isRegister == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvUsersEN_js_1.clsvUsersEN.con_IsRegister);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvUsersEN_js_1.clsvUsersEN.con_IsRegister);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvUsers_Cond.dicFldComparisonOp, clsvUsersEN_js_1.clsvUsersEN.con_RegisterDate) == true) {
            const strComparisonOp_RegisterDate = objvUsers_Cond.dicFldComparisonOp[clsvUsersEN_js_1.clsvUsersEN.con_RegisterDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvUsersEN_js_1.clsvUsersEN.con_RegisterDate, objvUsers_Cond.registerDate, strComparisonOp_RegisterDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvUsers_Cond.dicFldComparisonOp, clsvUsersEN_js_1.clsvUsersEN.con_MobilePhone) == true) {
            const strComparisonOp_MobilePhone = objvUsers_Cond.dicFldComparisonOp[clsvUsersEN_js_1.clsvUsersEN.con_MobilePhone];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvUsersEN_js_1.clsvUsersEN.con_MobilePhone, objvUsers_Cond.mobilePhone, strComparisonOp_MobilePhone);
        }
        if (Object.prototype.hasOwnProperty.call(objvUsers_Cond.dicFldComparisonOp, clsvUsersEN_js_1.clsvUsersEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objvUsers_Cond.dicFldComparisonOp[clsvUsersEN_js_1.clsvUsersEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvUsersEN_js_1.clsvUsersEN.con_UpdDate, objvUsers_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvUsers_Cond.dicFldComparisonOp, clsvUsersEN_js_1.clsvUsersEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objvUsers_Cond.dicFldComparisonOp[clsvUsersEN_js_1.clsvUsersEN.con_UpdUser];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvUsersEN_js_1.clsvUsersEN.con_UpdUser, objvUsers_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objvUsers_Cond.dicFldComparisonOp, clsvUsersEN_js_1.clsvUsersEN.con_Memo) == true) {
            const strComparisonOp_Memo = objvUsers_Cond.dicFldComparisonOp[clsvUsersEN_js_1.clsvUsersEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvUsersEN_js_1.clsvUsersEN.con_Memo, objvUsers_Cond.memo, strComparisonOp_Memo);
        }
        if (Object.prototype.hasOwnProperty.call(objvUsers_Cond.dicFldComparisonOp, clsvUsersEN_js_1.clsvUsersEN.con_UserNameWithUserId) == true) {
            const strComparisonOp_UserNameWithUserId = objvUsers_Cond.dicFldComparisonOp[clsvUsersEN_js_1.clsvUsersEN.con_UserNameWithUserId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvUsersEN_js_1.clsvUsersEN.con_UserNameWithUserId, objvUsers_Cond.userNameWithUserId, strComparisonOp_UserNameWithUserId);
        }
        if (Object.prototype.hasOwnProperty.call(objvUsers_Cond.dicFldComparisonOp, clsvUsersEN_js_1.clsvUsersEN.con_OpenId) == true) {
            const strComparisonOp_OpenId = objvUsers_Cond.dicFldComparisonOp[clsvUsersEN_js_1.clsvUsersEN.con_OpenId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvUsersEN_js_1.clsvUsersEN.con_OpenId, objvUsers_Cond.openId, strComparisonOp_OpenId);
        }
        if (Object.prototype.hasOwnProperty.call(objvUsers_Cond.dicFldComparisonOp, clsvUsersEN_js_1.clsvUsersEN.con_AvatarsPicture) == true) {
            const strComparisonOp_AvatarsPicture = objvUsers_Cond.dicFldComparisonOp[clsvUsersEN_js_1.clsvUsersEN.con_AvatarsPicture];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvUsersEN_js_1.clsvUsersEN.con_AvatarsPicture, objvUsers_Cond.avatarsPicture, strComparisonOp_AvatarsPicture);
        }
        if (Object.prototype.hasOwnProperty.call(objvUsers_Cond.dicFldComparisonOp, clsvUsersEN_js_1.clsvUsersEN.con_Email) == true) {
            const strComparisonOp_Email = objvUsers_Cond.dicFldComparisonOp[clsvUsersEN_js_1.clsvUsersEN.con_Email];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvUsersEN_js_1.clsvUsersEN.con_Email, objvUsers_Cond.email, strComparisonOp_Email);
        }
        if (Object.prototype.hasOwnProperty.call(objvUsers_Cond.dicFldComparisonOp, clsvUsersEN_js_1.clsvUsersEN.con_PhoneNumber) == true) {
            const strComparisonOp_PhoneNumber = objvUsers_Cond.dicFldComparisonOp[clsvUsersEN_js_1.clsvUsersEN.con_PhoneNumber];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvUsersEN_js_1.clsvUsersEN.con_PhoneNumber, objvUsers_Cond.phoneNumber, strComparisonOp_PhoneNumber);
        }
        if (Object.prototype.hasOwnProperty.call(objvUsers_Cond.dicFldComparisonOp, clsvUsersEN_js_1.clsvUsersEN.con_HeadPic) == true) {
            const strComparisonOp_HeadPic = objvUsers_Cond.dicFldComparisonOp[clsvUsersEN_js_1.clsvUsersEN.con_HeadPic];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvUsersEN_js_1.clsvUsersEN.con_HeadPic, objvUsers_Cond.headPic, strComparisonOp_HeadPic);
        }
        if (Object.prototype.hasOwnProperty.call(objvUsers_Cond.dicFldComparisonOp, clsvUsersEN_js_1.clsvUsersEN.con_IsGSuser) == true) {
            if (objvUsers_Cond.isGSuser == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvUsersEN_js_1.clsvUsersEN.con_IsGSuser);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvUsersEN_js_1.clsvUsersEN.con_IsGSuser);
            }
        }
        return strWhereCond;
    }
    exports.vUsers_GetCombineCondition = vUsers_GetCombineCondition;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objvUsersENS:源对象
     * @param objvUsersENT:目标对象
    */
    function vUsers_CopyObjTo(objvUsersENS, objvUsersENT) {
        objvUsersENT.userId = objvUsersENS.userId; //用户ID
        objvUsersENT.userName = objvUsersENS.userName; //用户名
        objvUsersENT.userStateId = objvUsersENS.userStateId; //用户状态Id
        objvUsersENT.userStateName = objvUsersENS.userStateName; //用户状态名
        objvUsersENT.password = objvUsersENS.password; //Password
        objvUsersENT.isGpUser = objvUsersENS.isGpUser; //是否Gp用户
        objvUsersENT.beginYearMonth = objvUsersENS.beginYearMonth; //开始年月
        objvUsersENT.endYearMonth = objvUsersENS.endYearMonth; //结束年月
        objvUsersENT.id_GradeBase = objvUsersENS.id_GradeBase; //年级流水号
        objvUsersENT.gradeBaseName = objvUsersENS.gradeBaseName; //年级名称
        objvUsersENT.id_XzCollege = objvUsersENS.id_XzCollege; //学院流水号
        objvUsersENT.collegeID = objvUsersENS.collegeID; //学院ID
        objvUsersENT.collegeName = objvUsersENS.collegeName; //学院名称
        objvUsersENT.collegeNameA = objvUsersENS.collegeNameA; //学院名称简写
        objvUsersENT.id_XzMajor = objvUsersENS.id_XzMajor; //专业流水号
        objvUsersENT.majorName = objvUsersENS.majorName; //专业名称
        objvUsersENT.isLeaved = objvUsersENS.isLeaved; //IsLeaved
        objvUsersENT.stuIdTeacherId = objvUsersENS.stuIdTeacherId; //学工号
        objvUsersENT.identityID = objvUsersENS.identityID; //身份编号
        objvUsersENT.identityDesc = objvUsersENS.identityDesc; //身份描述
        objvUsersENT.auditDate = objvUsersENS.auditDate; //AuditDate
        objvUsersENT.auditUser = objvUsersENS.auditUser; //AuditUser
        objvUsersENT.isAudit = objvUsersENS.isAudit; //是否审核
        objvUsersENT.isRegister = objvUsersENS.isRegister; //IsRegister
        objvUsersENT.registerDate = objvUsersENS.registerDate; //RegisterDate
        objvUsersENT.mobilePhone = objvUsersENS.mobilePhone; //手机
        objvUsersENT.updDate = objvUsersENS.updDate; //修改日期
        objvUsersENT.updUser = objvUsersENS.updUser; //修改人
        objvUsersENT.memo = objvUsersENS.memo; //备注
        objvUsersENT.userNameWithUserId = objvUsersENS.userNameWithUserId; //UserNameWithUserId
        objvUsersENT.openId = objvUsersENS.openId; //微信OpenId
        objvUsersENT.avatarsPicture = objvUsersENS.avatarsPicture; //AvatarsPicture
        objvUsersENT.email = objvUsersENS.email; //电子邮箱
        objvUsersENT.phoneNumber = objvUsersENS.phoneNumber; //PhoneNumber
        objvUsersENT.headPic = objvUsersENS.headPic; //头像
        objvUsersENT.isGSuser = objvUsersENS.isGSuser; //是否GS用户
    }
    exports.vUsers_CopyObjTo = vUsers_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objvUsersENS:源对象
     * @param objvUsersENT:目标对象
    */
    function vUsers_GetObjFromJsonObj(objvUsersENS) {
        const objvUsersENT = new clsvUsersEN_js_1.clsvUsersEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvUsersENT, objvUsersENS);
        return objvUsersENT;
    }
    exports.vUsers_GetObjFromJsonObj = vUsers_GetObjFromJsonObj;
});
