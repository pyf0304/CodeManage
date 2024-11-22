/**
* 类名:clsQxUsersWApi
* 表名:QxUsers(01120258)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/13 00:52:34
* 生成者:pyf
* 生成服务器IP:
工程名称:问卷调查(0112)
CM工程:研究生论文学习(变量首字母小写)-全部函数集
* 相关数据库:103.116.76.183,9433EduHigh_Jsie
* PrjDataBaseId:0170
模块中文名:基本信息维护(BaseInfo)
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
        define(["require", "exports", "axios", "../../PubFun/enumComparisonOp.js", "../../PubFun/CacheHelper.js", "../../L0_Entity/BaseInfo/clsQxUsersEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.QxUsers_GetObjFromJsonObj = exports.QxUsers_CopyObjTo = exports.QxUsers_GetCombineCondition = exports.QxUsers_GetObjByJSONStr = exports.QxUsers_GetObjLstByJSONObjLst = exports.QxUsers_GetObjLstByJSONStr = exports.QxUsers_GetJSONStrByObj = exports.QxUsers_CheckProperty4Update = exports.QxUsers_CheckPropertyNew = exports.QxUsers_ReFreshThisCache = exports.QxUsers_ReFreshCache = exports.QxUsers_GetWebApiUrl = exports.QxUsers_GetMaxStrIdByPrefix = exports.QxUsers_GetRecCountByCond_Cache = exports.QxUsers_GetRecCountByCondAsync = exports.QxUsers_IsExistAsync = exports.QxUsers_IsExist_Cache = exports.QxUsers_IsExist = exports.QxUsers_IsExistRecordAsync = exports.QxUsers_IsExistRecord_Cache = exports.QxUsers_UpdateWithConditionAsync = exports.QxUsers_UpdateRecordAsync = exports.QxUsers_AddNewRecordWithReturnKey = exports.QxUsers_AddNewRecordWithReturnKeyAsync = exports.QxUsers_AddNewRecordWithMaxIdAsync = exports.QxUsers_AddNewRecordAsync = exports.QxUsers_DelQxUserssByCondAsync = exports.QxUsers_DelQxUserssAsync = exports.QxUsers_DelRecordAsync = exports.QxUsers_GetObjLstByPagerAsync = exports.QxUsers_GetObjLstByPager_Cache = exports.QxUsers_GetObjLstByRange = exports.QxUsers_GetObjLstByRangeAsync = exports.QxUsers_GetTopObjLstAsync = exports.QxUsers_GetObjLstByUserIdLst_Cache = exports.QxUsers_GetObjLstByUserIdLstAsync = exports.QxUsers_GetSubObjLst_Cache = exports.QxUsers_GetObjLst_PureCache = exports.QxUsers_GetObjLst_Cache = exports.QxUsers_GetObjLst_sessionStorage_PureCache = exports.QxUsers_GetObjLst_sessionStorage = exports.QxUsers_GetObjLstAsync = exports.QxUsers_GetObjLst_localStorage_PureCache = exports.QxUsers_GetObjLst_localStorage = exports.QxUsers_GetObjLst_ClientCache = exports.QxUsers_GetFirstObjAsync = exports.QxUsers_GetFirstID = exports.QxUsers_GetFirstIDAsync = exports.QxUsers_funcKey = exports.QxUsers_FilterFunByKey = exports.QxUsers_SortFunByKey = exports.QxUsers_SortFun_Defa_2Fld = exports.QxUsers_SortFun_Defa = exports.QxUsers_func = exports.QxUsers_UpdateObjInLst_Cache = exports.QxUsers_GetObjByUserId_localStorage = exports.QxUsers_GetObjByUserId_Cache = exports.QxUsers_GetObjByUserIdAsync = exports.qxUsers_ConstructorName = exports.qxUsers_Controller = void 0;
    /**
     * Qx用户(QxUsers)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月13日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const enumComparisonOp_js_1 = require("../../PubFun/enumComparisonOp.js");
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsQxUsersEN_js_1 = require("../../L0_Entity/BaseInfo/clsQxUsersEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsString_js_2 = require("../../PubFun/clsString.js");
    exports.qxUsers_Controller = "QxUsersApi";
    exports.qxUsers_ConstructorName = "qxUsers";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strUserId:关键字
    * @returns 对象
    **/
    async function QxUsers_GetObjByUserIdAsync(strUserId) {
        const strThisFuncName = "GetObjByUserIdAsync";
        if ((0, clsString_js_2.IsNullOrEmpty)(strUserId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strUserId]不能为空！(In clsQxUsersWApi.GetObjByUserIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByUserId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qxUsers_Controller, strAction);
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
                const objQxUsers = QxUsers_GetObjFromJsonObj(returnObj);
                return objQxUsers;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qxUsers_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qxUsers_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.QxUsers_GetObjByUserIdAsync = QxUsers_GetObjByUserIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param strUserId:所给的关键字
     * @returns 对象
    */
    async function QxUsers_GetObjByUserId_Cache(strUserId, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByUserId_Cache";
        if ((0, clsString_js_2.IsNullOrEmpty)(strUserId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strUserId]不能为空！(In clsQxUsersWApi.GetObjByUserId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        const arrQxUsersObjLst_Cache = await QxUsers_GetObjLst_Cache();
        try {
            const arrQxUsers_Sel = arrQxUsersObjLst_Cache.filter(x => x.userId == strUserId);
            let objQxUsers;
            if (arrQxUsers_Sel.length > 0) {
                objQxUsers = arrQxUsers_Sel[0];
                return objQxUsers;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    const objQxUsers_Const = await QxUsers_GetObjByUserIdAsync(strUserId);
                    if (objQxUsers_Const != null) {
                        QxUsers_ReFreshThisCache();
                        return objQxUsers_Const;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strUserId, exports.qxUsers_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.QxUsers_GetObjByUserId_Cache = QxUsers_GetObjByUserId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param strUserId:所给的关键字
     * @returns 对象
    */
    async function QxUsers_GetObjByUserId_localStorage(strUserId) {
        const strThisFuncName = "GetObjByUserId_localStorage";
        if ((0, clsString_js_2.IsNullOrEmpty)(strUserId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strUserId]不能为空！(In clsQxUsersWApi.GetObjByUserId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsQxUsersEN_js_1.clsQxUsersEN._CurrTabName, strUserId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objQxUsers_Cache = JSON.parse(strTempObj);
            return objQxUsers_Cache;
        }
        try {
            const objQxUsers = await QxUsers_GetObjByUserIdAsync(strUserId);
            if (objQxUsers != null) {
                localStorage.setItem(strKey, JSON.stringify(objQxUsers));
                const strInfo = (0, clsString_js_2.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objQxUsers;
            }
            return objQxUsers;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strUserId, exports.qxUsers_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.QxUsers_GetObjByUserId_localStorage = QxUsers_GetObjByUserId_localStorage;
    /**
     * 修改在缓存对象列表中的对象, 与后台数据库无关.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
     * @param objQxUsers:所给的对象
     * @returns 对象
    */
    async function QxUsers_UpdateObjInLst_Cache(objQxUsers) {
        const strThisFuncName = "UpdateObjInLst_Cache";
        try {
            const arrQxUsersObjLst_Cache = await QxUsers_GetObjLst_Cache();
            const obj = arrQxUsersObjLst_Cache.find(x => x.userId == objQxUsers.userId);
            if (obj != null) {
                objQxUsers.userId = obj.userId;
                (0, clsCommFunc4Web_js_1.ObjectAssign)(obj, objQxUsers);
            }
            else {
                arrQxUsersObjLst_Cache.push(objQxUsers);
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, exports.qxUsers_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.QxUsers_UpdateObjInLst_Cache = QxUsers_UpdateObjInLst_Cache;
    /*该表没有名称字段，不能生成此函数！*/
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
    async function QxUsers_func(strInFldName, strOutFldName, strInValue) {
        //const strThisFuncName = "func";
        if (strInFldName != clsQxUsersEN_js_1.clsQxUsersEN.con_UserId) {
            const strMsg = (0, clsString_js_2.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsQxUsersEN_js_1.clsQxUsersEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_2.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strOutFldName, clsQxUsersEN_js_1.clsQxUsersEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUserId = strInValue;
        if ((0, clsString_js_2.IsNullOrEmpty)(strInValue) == true) {
            return "";
        }
        const objQxUsers = await QxUsers_GetObjByUserId_Cache(strUserId);
        if (objQxUsers == null)
            return "";
        if (objQxUsers.GetFldValue(strOutFldName) == null)
            return "";
        return objQxUsers.GetFldValue(strOutFldName).toString();
    }
    exports.QxUsers_func = QxUsers_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function QxUsers_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.userId.localeCompare(b.userId);
    }
    exports.QxUsers_SortFun_Defa = QxUsers_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function QxUsers_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.userName == b.userName)
            return a.departmentId.localeCompare(b.departmentId);
        else
            return a.userName.localeCompare(b.userName);
    }
    exports.QxUsers_SortFun_Defa_2Fld = QxUsers_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function QxUsers_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsQxUsersEN_js_1.clsQxUsersEN.con_UserId:
                    return (a, b) => {
                        return a.userId.localeCompare(b.userId);
                    };
                case clsQxUsersEN_js_1.clsQxUsersEN.con_UserName:
                    return (a, b) => {
                        return a.userName.localeCompare(b.userName);
                    };
                case clsQxUsersEN_js_1.clsQxUsersEN.con_DepartmentId:
                    return (a, b) => {
                        if (a.departmentId == null)
                            return -1;
                        if (b.departmentId == null)
                            return 1;
                        return a.departmentId.localeCompare(b.departmentId);
                    };
                case clsQxUsersEN_js_1.clsQxUsersEN.con_id_XzCollege:
                    return (a, b) => {
                        if (a.id_XzCollege == null)
                            return -1;
                        if (b.id_XzCollege == null)
                            return 1;
                        return a.id_XzCollege.localeCompare(b.id_XzCollege);
                    };
                case clsQxUsersEN_js_1.clsQxUsersEN.con_UserStateId:
                    return (a, b) => {
                        return a.userStateId.localeCompare(b.userStateId);
                    };
                case clsQxUsersEN_js_1.clsQxUsersEN.con_id_GradeBase:
                    return (a, b) => {
                        if (a.id_GradeBase == null)
                            return -1;
                        if (b.id_GradeBase == null)
                            return 1;
                        return a.id_GradeBase.localeCompare(b.id_GradeBase);
                    };
                case clsQxUsersEN_js_1.clsQxUsersEN.con_Card_State:
                    return (a, b) => {
                        if (a.card_State == null)
                            return -1;
                        if (b.card_State == null)
                            return 1;
                        return a.card_State.localeCompare(b.card_State);
                    };
                case clsQxUsersEN_js_1.clsQxUsersEN.con_IsLeaved:
                    return (a, b) => {
                        if (a.isLeaved == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsQxUsersEN_js_1.clsQxUsersEN.con_CardNo:
                    return (a, b) => {
                        if (a.cardNo == null)
                            return -1;
                        if (b.cardNo == null)
                            return 1;
                        return a.cardNo.localeCompare(b.cardNo);
                    };
                case clsQxUsersEN_js_1.clsQxUsersEN.con_BeginYearMonth:
                    return (a, b) => {
                        if (a.beginYearMonth == null)
                            return -1;
                        if (b.beginYearMonth == null)
                            return 1;
                        return a.beginYearMonth.localeCompare(b.beginYearMonth);
                    };
                case clsQxUsersEN_js_1.clsQxUsersEN.con_EndYearMonth:
                    return (a, b) => {
                        if (a.endYearMonth == null)
                            return -1;
                        if (b.endYearMonth == null)
                            return 1;
                        return a.endYearMonth.localeCompare(b.endYearMonth);
                    };
                case clsQxUsersEN_js_1.clsQxUsersEN.con_OptUser:
                    return (a, b) => {
                        if (a.optUser == null)
                            return -1;
                        if (b.optUser == null)
                            return 1;
                        return a.optUser.localeCompare(b.optUser);
                    };
                case clsQxUsersEN_js_1.clsQxUsersEN.con_OptDate:
                    return (a, b) => {
                        if (a.optDate == null)
                            return -1;
                        if (b.optDate == null)
                            return 1;
                        return a.optDate.localeCompare(b.optDate);
                    };
                case clsQxUsersEN_js_1.clsQxUsersEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                case clsQxUsersEN_js_1.clsQxUsersEN.con_Password:
                    return (a, b) => {
                        if (a.password == null)
                            return -1;
                        if (b.password == null)
                            return 1;
                        return a.password.localeCompare(b.password);
                    };
                case clsQxUsersEN_js_1.clsQxUsersEN.con_IsGpUser:
                    return (a, b) => {
                        if (a.isGpUser == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsQxUsersEN_js_1.clsQxUsersEN.con_SchoolID1:
                    return (a, b) => {
                        if (a.schoolID1 == null)
                            return -1;
                        if (b.schoolID1 == null)
                            return 1;
                        return a.schoolID1.localeCompare(b.schoolID1);
                    };
                case clsQxUsersEN_js_1.clsQxUsersEN.con_AvatarsPicture:
                    return (a, b) => {
                        if (a.avatarsPicture == null)
                            return -1;
                        if (b.avatarsPicture == null)
                            return 1;
                        return a.avatarsPicture.localeCompare(b.avatarsPicture);
                    };
                case clsQxUsersEN_js_1.clsQxUsersEN.con_Email:
                    return (a, b) => {
                        if (a.email == null)
                            return -1;
                        if (b.email == null)
                            return 1;
                        return a.email.localeCompare(b.email);
                    };
                case clsQxUsersEN_js_1.clsQxUsersEN.con_PhoneNumber:
                    return (a, b) => {
                        if (a.phoneNumber == null)
                            return -1;
                        if (b.phoneNumber == null)
                            return 1;
                        return a.phoneNumber.localeCompare(b.phoneNumber);
                    };
                case clsQxUsersEN_js_1.clsQxUsersEN.con_EffectiveDate:
                    return (a, b) => {
                        if (a.effectiveDate == null)
                            return -1;
                        if (b.effectiveDate == null)
                            return 1;
                        return a.effectiveDate.localeCompare(b.effectiveDate);
                    };
                case clsQxUsersEN_js_1.clsQxUsersEN.con_UpdDate:
                    return (a, b) => {
                        if (a.updDate == null)
                            return -1;
                        if (b.updDate == null)
                            return 1;
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsQxUsersEN_js_1.clsQxUsersEN.con_UpdUser:
                    return (a, b) => {
                        if (a.updUser == null)
                            return -1;
                        if (b.updUser == null)
                            return 1;
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsQxUsersEN_js_1.clsQxUsersEN.con_EffitiveBeginDate:
                    return (a, b) => {
                        return a.effitiveBeginDate.localeCompare(b.effitiveBeginDate);
                    };
                case clsQxUsersEN_js_1.clsQxUsersEN.con_EffitiveEndDate:
                    return (a, b) => {
                        return a.effitiveEndDate.localeCompare(b.effitiveEndDate);
                    };
                case clsQxUsersEN_js_1.clsQxUsersEN.con_id_College:
                    return (a, b) => {
                        return a.id_College.localeCompare(b.id_College);
                    };
                case clsQxUsersEN_js_1.clsQxUsersEN.con_StuTeacherID:
                    return (a, b) => {
                        return a.stuTeacherID.localeCompare(b.stuTeacherID);
                    };
                case clsQxUsersEN_js_1.clsQxUsersEN.con_IdentityID:
                    return (a, b) => {
                        if (a.identityID == null)
                            return -1;
                        if (b.identityID == null)
                            return 1;
                        return a.identityID.localeCompare(b.identityID);
                    };
                case clsQxUsersEN_js_1.clsQxUsersEN.con_IsArchive:
                    return (a, b) => {
                        if (a.isArchive == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsQxUsersEN_js_1.clsQxUsersEN.con_HeadimgUrl:
                    return (a, b) => {
                        if (a.headimgUrl == null)
                            return -1;
                        if (b.headimgUrl == null)
                            return 1;
                        return a.headimgUrl.localeCompare(b.headimgUrl);
                    };
                case clsQxUsersEN_js_1.clsQxUsersEN.con_OpenId:
                    return (a, b) => {
                        if (a.openId == null)
                            return -1;
                        if (b.openId == null)
                            return 1;
                        return a.openId.localeCompare(b.openId);
                    };
                case clsQxUsersEN_js_1.clsQxUsersEN.con_NickName:
                    return (a, b) => {
                        if (a.nickName == null)
                            return -1;
                        if (b.nickName == null)
                            return 1;
                        return a.nickName.localeCompare(b.nickName);
                    };
                case clsQxUsersEN_js_1.clsQxUsersEN.con_IsSynch:
                    return (a, b) => {
                        if (a.isSynch == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsQxUsersEN_js_1.clsQxUsersEN.con_SynchDate:
                    return (a, b) => {
                        if (a.synchDate == null)
                            return -1;
                        if (b.synchDate == null)
                            return 1;
                        return a.synchDate.localeCompare(b.synchDate);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[QxUsers]中不存在！(in ${exports.qxUsers_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsQxUsersEN_js_1.clsQxUsersEN.con_UserId:
                    return (a, b) => {
                        return b.userId.localeCompare(a.userId);
                    };
                case clsQxUsersEN_js_1.clsQxUsersEN.con_UserName:
                    return (a, b) => {
                        return b.userName.localeCompare(a.userName);
                    };
                case clsQxUsersEN_js_1.clsQxUsersEN.con_DepartmentId:
                    return (a, b) => {
                        if (b.departmentId == null)
                            return -1;
                        if (a.departmentId == null)
                            return 1;
                        return b.departmentId.localeCompare(a.departmentId);
                    };
                case clsQxUsersEN_js_1.clsQxUsersEN.con_id_XzCollege:
                    return (a, b) => {
                        if (b.id_XzCollege == null)
                            return -1;
                        if (a.id_XzCollege == null)
                            return 1;
                        return b.id_XzCollege.localeCompare(a.id_XzCollege);
                    };
                case clsQxUsersEN_js_1.clsQxUsersEN.con_UserStateId:
                    return (a, b) => {
                        return b.userStateId.localeCompare(a.userStateId);
                    };
                case clsQxUsersEN_js_1.clsQxUsersEN.con_id_GradeBase:
                    return (a, b) => {
                        if (b.id_GradeBase == null)
                            return -1;
                        if (a.id_GradeBase == null)
                            return 1;
                        return b.id_GradeBase.localeCompare(a.id_GradeBase);
                    };
                case clsQxUsersEN_js_1.clsQxUsersEN.con_Card_State:
                    return (a, b) => {
                        if (b.card_State == null)
                            return -1;
                        if (a.card_State == null)
                            return 1;
                        return b.card_State.localeCompare(a.card_State);
                    };
                case clsQxUsersEN_js_1.clsQxUsersEN.con_IsLeaved:
                    return (a, b) => {
                        if (b.isLeaved == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsQxUsersEN_js_1.clsQxUsersEN.con_CardNo:
                    return (a, b) => {
                        if (b.cardNo == null)
                            return -1;
                        if (a.cardNo == null)
                            return 1;
                        return b.cardNo.localeCompare(a.cardNo);
                    };
                case clsQxUsersEN_js_1.clsQxUsersEN.con_BeginYearMonth:
                    return (a, b) => {
                        if (b.beginYearMonth == null)
                            return -1;
                        if (a.beginYearMonth == null)
                            return 1;
                        return b.beginYearMonth.localeCompare(a.beginYearMonth);
                    };
                case clsQxUsersEN_js_1.clsQxUsersEN.con_EndYearMonth:
                    return (a, b) => {
                        if (b.endYearMonth == null)
                            return -1;
                        if (a.endYearMonth == null)
                            return 1;
                        return b.endYearMonth.localeCompare(a.endYearMonth);
                    };
                case clsQxUsersEN_js_1.clsQxUsersEN.con_OptUser:
                    return (a, b) => {
                        if (b.optUser == null)
                            return -1;
                        if (a.optUser == null)
                            return 1;
                        return b.optUser.localeCompare(a.optUser);
                    };
                case clsQxUsersEN_js_1.clsQxUsersEN.con_OptDate:
                    return (a, b) => {
                        if (b.optDate == null)
                            return -1;
                        if (a.optDate == null)
                            return 1;
                        return b.optDate.localeCompare(a.optDate);
                    };
                case clsQxUsersEN_js_1.clsQxUsersEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                case clsQxUsersEN_js_1.clsQxUsersEN.con_Password:
                    return (a, b) => {
                        if (b.password == null)
                            return -1;
                        if (a.password == null)
                            return 1;
                        return b.password.localeCompare(a.password);
                    };
                case clsQxUsersEN_js_1.clsQxUsersEN.con_IsGpUser:
                    return (a, b) => {
                        if (b.isGpUser == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsQxUsersEN_js_1.clsQxUsersEN.con_SchoolID1:
                    return (a, b) => {
                        if (b.schoolID1 == null)
                            return -1;
                        if (a.schoolID1 == null)
                            return 1;
                        return b.schoolID1.localeCompare(a.schoolID1);
                    };
                case clsQxUsersEN_js_1.clsQxUsersEN.con_AvatarsPicture:
                    return (a, b) => {
                        if (b.avatarsPicture == null)
                            return -1;
                        if (a.avatarsPicture == null)
                            return 1;
                        return b.avatarsPicture.localeCompare(a.avatarsPicture);
                    };
                case clsQxUsersEN_js_1.clsQxUsersEN.con_Email:
                    return (a, b) => {
                        if (b.email == null)
                            return -1;
                        if (a.email == null)
                            return 1;
                        return b.email.localeCompare(a.email);
                    };
                case clsQxUsersEN_js_1.clsQxUsersEN.con_PhoneNumber:
                    return (a, b) => {
                        if (b.phoneNumber == null)
                            return -1;
                        if (a.phoneNumber == null)
                            return 1;
                        return b.phoneNumber.localeCompare(a.phoneNumber);
                    };
                case clsQxUsersEN_js_1.clsQxUsersEN.con_EffectiveDate:
                    return (a, b) => {
                        if (b.effectiveDate == null)
                            return -1;
                        if (a.effectiveDate == null)
                            return 1;
                        return b.effectiveDate.localeCompare(a.effectiveDate);
                    };
                case clsQxUsersEN_js_1.clsQxUsersEN.con_UpdDate:
                    return (a, b) => {
                        if (b.updDate == null)
                            return -1;
                        if (a.updDate == null)
                            return 1;
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsQxUsersEN_js_1.clsQxUsersEN.con_UpdUser:
                    return (a, b) => {
                        if (b.updUser == null)
                            return -1;
                        if (a.updUser == null)
                            return 1;
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsQxUsersEN_js_1.clsQxUsersEN.con_EffitiveBeginDate:
                    return (a, b) => {
                        return b.effitiveBeginDate.localeCompare(a.effitiveBeginDate);
                    };
                case clsQxUsersEN_js_1.clsQxUsersEN.con_EffitiveEndDate:
                    return (a, b) => {
                        return b.effitiveEndDate.localeCompare(a.effitiveEndDate);
                    };
                case clsQxUsersEN_js_1.clsQxUsersEN.con_id_College:
                    return (a, b) => {
                        return b.id_College.localeCompare(a.id_College);
                    };
                case clsQxUsersEN_js_1.clsQxUsersEN.con_StuTeacherID:
                    return (a, b) => {
                        return b.stuTeacherID.localeCompare(a.stuTeacherID);
                    };
                case clsQxUsersEN_js_1.clsQxUsersEN.con_IdentityID:
                    return (a, b) => {
                        if (b.identityID == null)
                            return -1;
                        if (a.identityID == null)
                            return 1;
                        return b.identityID.localeCompare(a.identityID);
                    };
                case clsQxUsersEN_js_1.clsQxUsersEN.con_IsArchive:
                    return (a, b) => {
                        if (b.isArchive == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsQxUsersEN_js_1.clsQxUsersEN.con_HeadimgUrl:
                    return (a, b) => {
                        if (b.headimgUrl == null)
                            return -1;
                        if (a.headimgUrl == null)
                            return 1;
                        return b.headimgUrl.localeCompare(a.headimgUrl);
                    };
                case clsQxUsersEN_js_1.clsQxUsersEN.con_OpenId:
                    return (a, b) => {
                        if (b.openId == null)
                            return -1;
                        if (a.openId == null)
                            return 1;
                        return b.openId.localeCompare(a.openId);
                    };
                case clsQxUsersEN_js_1.clsQxUsersEN.con_NickName:
                    return (a, b) => {
                        if (b.nickName == null)
                            return -1;
                        if (a.nickName == null)
                            return 1;
                        return b.nickName.localeCompare(a.nickName);
                    };
                case clsQxUsersEN_js_1.clsQxUsersEN.con_IsSynch:
                    return (a, b) => {
                        if (b.isSynch == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsQxUsersEN_js_1.clsQxUsersEN.con_SynchDate:
                    return (a, b) => {
                        if (b.synchDate == null)
                            return -1;
                        if (a.synchDate == null)
                            return 1;
                        return b.synchDate.localeCompare(a.synchDate);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[QxUsers]中不存在！(in ${exports.qxUsers_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.QxUsers_SortFunByKey = QxUsers_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function QxUsers_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsQxUsersEN_js_1.clsQxUsersEN.con_UserId:
                return (obj) => {
                    return obj.userId === value;
                };
            case clsQxUsersEN_js_1.clsQxUsersEN.con_UserName:
                return (obj) => {
                    return obj.userName === value;
                };
            case clsQxUsersEN_js_1.clsQxUsersEN.con_DepartmentId:
                return (obj) => {
                    return obj.departmentId === value;
                };
            case clsQxUsersEN_js_1.clsQxUsersEN.con_id_XzCollege:
                return (obj) => {
                    return obj.id_XzCollege === value;
                };
            case clsQxUsersEN_js_1.clsQxUsersEN.con_UserStateId:
                return (obj) => {
                    return obj.userStateId === value;
                };
            case clsQxUsersEN_js_1.clsQxUsersEN.con_id_GradeBase:
                return (obj) => {
                    return obj.id_GradeBase === value;
                };
            case clsQxUsersEN_js_1.clsQxUsersEN.con_Card_State:
                return (obj) => {
                    return obj.card_State === value;
                };
            case clsQxUsersEN_js_1.clsQxUsersEN.con_IsLeaved:
                return (obj) => {
                    return obj.isLeaved === value;
                };
            case clsQxUsersEN_js_1.clsQxUsersEN.con_CardNo:
                return (obj) => {
                    return obj.cardNo === value;
                };
            case clsQxUsersEN_js_1.clsQxUsersEN.con_BeginYearMonth:
                return (obj) => {
                    return obj.beginYearMonth === value;
                };
            case clsQxUsersEN_js_1.clsQxUsersEN.con_EndYearMonth:
                return (obj) => {
                    return obj.endYearMonth === value;
                };
            case clsQxUsersEN_js_1.clsQxUsersEN.con_OptUser:
                return (obj) => {
                    return obj.optUser === value;
                };
            case clsQxUsersEN_js_1.clsQxUsersEN.con_OptDate:
                return (obj) => {
                    return obj.optDate === value;
                };
            case clsQxUsersEN_js_1.clsQxUsersEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            case clsQxUsersEN_js_1.clsQxUsersEN.con_Password:
                return (obj) => {
                    return obj.password === value;
                };
            case clsQxUsersEN_js_1.clsQxUsersEN.con_IsGpUser:
                return (obj) => {
                    return obj.isGpUser === value;
                };
            case clsQxUsersEN_js_1.clsQxUsersEN.con_SchoolID1:
                return (obj) => {
                    return obj.schoolID1 === value;
                };
            case clsQxUsersEN_js_1.clsQxUsersEN.con_AvatarsPicture:
                return (obj) => {
                    return obj.avatarsPicture === value;
                };
            case clsQxUsersEN_js_1.clsQxUsersEN.con_Email:
                return (obj) => {
                    return obj.email === value;
                };
            case clsQxUsersEN_js_1.clsQxUsersEN.con_PhoneNumber:
                return (obj) => {
                    return obj.phoneNumber === value;
                };
            case clsQxUsersEN_js_1.clsQxUsersEN.con_EffectiveDate:
                return (obj) => {
                    return obj.effectiveDate === value;
                };
            case clsQxUsersEN_js_1.clsQxUsersEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsQxUsersEN_js_1.clsQxUsersEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsQxUsersEN_js_1.clsQxUsersEN.con_EffitiveBeginDate:
                return (obj) => {
                    return obj.effitiveBeginDate === value;
                };
            case clsQxUsersEN_js_1.clsQxUsersEN.con_EffitiveEndDate:
                return (obj) => {
                    return obj.effitiveEndDate === value;
                };
            case clsQxUsersEN_js_1.clsQxUsersEN.con_id_College:
                return (obj) => {
                    return obj.id_College === value;
                };
            case clsQxUsersEN_js_1.clsQxUsersEN.con_StuTeacherID:
                return (obj) => {
                    return obj.stuTeacherID === value;
                };
            case clsQxUsersEN_js_1.clsQxUsersEN.con_IdentityID:
                return (obj) => {
                    return obj.identityID === value;
                };
            case clsQxUsersEN_js_1.clsQxUsersEN.con_IsArchive:
                return (obj) => {
                    return obj.isArchive === value;
                };
            case clsQxUsersEN_js_1.clsQxUsersEN.con_HeadimgUrl:
                return (obj) => {
                    return obj.headimgUrl === value;
                };
            case clsQxUsersEN_js_1.clsQxUsersEN.con_OpenId:
                return (obj) => {
                    return obj.openId === value;
                };
            case clsQxUsersEN_js_1.clsQxUsersEN.con_NickName:
                return (obj) => {
                    return obj.nickName === value;
                };
            case clsQxUsersEN_js_1.clsQxUsersEN.con_IsSynch:
                return (obj) => {
                    return obj.isSynch === value;
                };
            case clsQxUsersEN_js_1.clsQxUsersEN.con_SynchDate:
                return (obj) => {
                    return obj.synchDate === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[QxUsers]中不存在！(in ${exports.qxUsers_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.QxUsers_FilterFunByKey = QxUsers_FilterFunByKey;
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
    async function QxUsers_funcKey(strInFldName, strInValue, strComparisonOp) {
        //const strThisFuncName = "funcKey";
        if (strInFldName == clsQxUsersEN_js_1.clsQxUsersEN.con_UserId) {
            const strMsg = (0, clsString_js_2.Format)("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(strInValue) == true) {
            return [];
        }
        const arrQxUsers = await QxUsers_GetObjLst_Cache();
        if (arrQxUsers == null)
            return [];
        let arrQxUsers_Sel = arrQxUsers;
        const strType = typeof (strInValue);
        switch (strType) {
            case "string":
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01: // " = "
                        arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.Like_03:
                        arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.In_04:
                        const arrValues = strInValue.split(',');
                        arrQxUsers_Sel = arrQxUsers_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
                        break;
                }
                break;
            case "boolean":
                if (strInValue == null)
                    return [];
                if (strComparisonOp == enumComparisonOp_js_1.enumComparisonOp.Equal_01) {
                    arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                }
                break;
            case "number":
                if (Number(strInValue) == 0)
                    return [];
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01:
                        arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotEqual_02:
                        arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotLessThan_05: //" >= ":
                        arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotGreaterThan_06: //" <= ":
                        arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.GreaterThan_07: //" > ":
                        arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.LessThan_08: //" < ":
                        arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                }
                break;
        }
        if (arrQxUsers_Sel.length == 0)
            return [];
        return arrQxUsers_Sel.map(x => x.userId);
    }
    exports.QxUsers_funcKey = QxUsers_funcKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function QxUsers_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qxUsers_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qxUsers_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qxUsers_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.QxUsers_GetFirstIDAsync = QxUsers_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function QxUsers_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qxUsers_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qxUsers_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qxUsers_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.QxUsers_GetFirstID = QxUsers_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function QxUsers_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qxUsers_Controller, strAction);
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
                const objQxUsers = QxUsers_GetObjFromJsonObj(returnObj);
                return objQxUsers;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qxUsers_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qxUsers_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.QxUsers_GetFirstObjAsync = QxUsers_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function QxUsers_GetObjLst_ClientCache() {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsQxUsersEN_js_1.clsQxUsersEN._CurrTabName;
        if ((0, clsString_js_2.IsNullOrEmpty)(clsQxUsersEN_js_1.clsQxUsersEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsQxUsersEN_js_1.clsQxUsersEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_1.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrQxUsersExObjLst_Cache = CacheHelper_js_1.CacheHelper.Get(strKey);
            const arrQxUsersObjLst_T = QxUsers_GetObjLstByJSONObjLst(arrQxUsersExObjLst_Cache);
            return arrQxUsersObjLst_T;
        }
        try {
            const arrQxUsersExObjLst = await QxUsers_GetObjLstAsync(strWhereCond);
            CacheHelper_js_1.CacheHelper.Add(strKey, arrQxUsersExObjLst);
            const strInfo = (0, clsString_js_2.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrQxUsersExObjLst.length);
            console.log(strInfo);
            return arrQxUsersExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.qxUsers_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.QxUsers_GetObjLst_ClientCache = QxUsers_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function QxUsers_GetObjLst_localStorage() {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsQxUsersEN_js_1.clsQxUsersEN._CurrTabName;
        if ((0, clsString_js_2.IsNullOrEmpty)(clsQxUsersEN_js_1.clsQxUsersEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsQxUsersEN_js_1.clsQxUsersEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrQxUsersExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrQxUsersObjLst_T = QxUsers_GetObjLstByJSONObjLst(arrQxUsersExObjLst_Cache);
            return arrQxUsersObjLst_T;
        }
        try {
            const arrQxUsersExObjLst = await QxUsers_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrQxUsersExObjLst));
            const strInfo = (0, clsString_js_2.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrQxUsersExObjLst.length);
            console.log(strInfo);
            return arrQxUsersExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.qxUsers_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.QxUsers_GetObjLst_localStorage = QxUsers_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function QxUsers_GetObjLst_localStorage_PureCache() {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsQxUsersEN_js_1.clsQxUsersEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrQxUsersObjLst_Cache = JSON.parse(strTempObjLst);
            return arrQxUsersObjLst_Cache;
        }
        else
            return null;
    }
    exports.QxUsers_GetObjLst_localStorage_PureCache = QxUsers_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function QxUsers_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qxUsers_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.qxUsers_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = QxUsers_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qxUsers_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qxUsers_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.QxUsers_GetObjLstAsync = QxUsers_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function QxUsers_GetObjLst_sessionStorage() {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsQxUsersEN_js_1.clsQxUsersEN._CurrTabName;
        if ((0, clsString_js_2.IsNullOrEmpty)(clsQxUsersEN_js_1.clsQxUsersEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsQxUsersEN_js_1.clsQxUsersEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrQxUsersExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrQxUsersObjLst_T = QxUsers_GetObjLstByJSONObjLst(arrQxUsersExObjLst_Cache);
            return arrQxUsersObjLst_T;
        }
        try {
            const arrQxUsersExObjLst = await QxUsers_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrQxUsersExObjLst));
            const strInfo = (0, clsString_js_2.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrQxUsersExObjLst.length);
            console.log(strInfo);
            return arrQxUsersExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.qxUsers_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.QxUsers_GetObjLst_sessionStorage = QxUsers_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function QxUsers_GetObjLst_sessionStorage_PureCache() {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsQxUsersEN_js_1.clsQxUsersEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrQxUsersObjLst_Cache = JSON.parse(strTempObjLst);
            return arrQxUsersObjLst_Cache;
        }
        else
            return null;
    }
    exports.QxUsers_GetObjLst_sessionStorage_PureCache = QxUsers_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function QxUsers_GetObjLst_Cache() {
        //const strThisFuncName = "GetObjLst_Cache";
        let arrQxUsersObjLst_Cache;
        switch (clsQxUsersEN_js_1.clsQxUsersEN.CacheModeId) {
            case "04": //sessionStorage
                arrQxUsersObjLst_Cache = await QxUsers_GetObjLst_sessionStorage();
                break;
            case "03": //localStorage
                arrQxUsersObjLst_Cache = await QxUsers_GetObjLst_localStorage();
                break;
            case "02": //ClientCache
                arrQxUsersObjLst_Cache = await QxUsers_GetObjLst_ClientCache();
                break;
            default:
                arrQxUsersObjLst_Cache = await QxUsers_GetObjLst_ClientCache();
                break;
        }
        const arrQxUsersObjLst = QxUsers_GetObjLstByJSONObjLst(arrQxUsersObjLst_Cache);
        return arrQxUsersObjLst_Cache;
    }
    exports.QxUsers_GetObjLst_Cache = QxUsers_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function QxUsers_GetObjLst_PureCache() {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrQxUsersObjLst_Cache;
        switch (clsQxUsersEN_js_1.clsQxUsersEN.CacheModeId) {
            case "04": //sessionStorage
                arrQxUsersObjLst_Cache = await QxUsers_GetObjLst_sessionStorage_PureCache();
                break;
            case "03": //localStorage
                arrQxUsersObjLst_Cache = await QxUsers_GetObjLst_localStorage_PureCache();
                break;
            case "02": //ClientCache
                arrQxUsersObjLst_Cache = null;
                break;
            default:
                arrQxUsersObjLst_Cache = null;
                break;
        }
        return arrQxUsersObjLst_Cache;
    }
    exports.QxUsers_GetObjLst_PureCache = QxUsers_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objstrUserId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function QxUsers_GetSubObjLst_Cache(objQxUsers_Cond) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrQxUsersObjLst_Cache = await QxUsers_GetObjLst_Cache();
        let arrQxUsers_Sel = arrQxUsersObjLst_Cache;
        if (objQxUsers_Cond.sf_FldComparisonOp == null || objQxUsers_Cond.sf_FldComparisonOp == "")
            return arrQxUsers_Sel;
        const dicFldComparisonOp = JSON.parse(objQxUsers_Cond.sf_FldComparisonOp);
        //console.log("clsQxUsersWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objQxUsers_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objQxUsers_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrQxUsers_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objQxUsers_Cond), exports.qxUsers_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.QxUsers_GetSubObjLst_Cache = QxUsers_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrUserId:关键字列表
    * @returns 对象列表
    **/
    async function QxUsers_GetObjLstByUserIdLstAsync(arrUserId) {
        const strThisFuncName = "GetObjLstByUserIdLstAsync";
        const strAction = "GetObjLstByUserIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qxUsers_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrUserId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.qxUsers_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = QxUsers_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qxUsers_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qxUsers_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.QxUsers_GetObjLstByUserIdLstAsync = QxUsers_GetObjLstByUserIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrstrUserIdLst:关键字列表
     * @returns 对象列表
    */
    async function QxUsers_GetObjLstByUserIdLst_Cache(arrUserIdLst) {
        const strThisFuncName = "GetObjLstByUserIdLst_Cache";
        try {
            const arrQxUsersObjLst_Cache = await QxUsers_GetObjLst_Cache();
            const arrQxUsers_Sel = arrQxUsersObjLst_Cache.filter(x => arrUserIdLst.indexOf(x.userId) > -1);
            return arrQxUsers_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrUserIdLst.join(","), exports.qxUsers_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
    }
    exports.QxUsers_GetObjLstByUserIdLst_Cache = QxUsers_GetObjLstByUserIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function QxUsers_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qxUsers_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.qxUsers_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = QxUsers_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qxUsers_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qxUsers_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.QxUsers_GetTopObjLstAsync = QxUsers_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function QxUsers_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qxUsers_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.qxUsers_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = QxUsers_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qxUsers_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qxUsers_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.QxUsers_GetObjLstByRangeAsync = QxUsers_GetObjLstByRangeAsync;
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
    async function QxUsers_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qxUsers_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qxUsers_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qxUsers_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.QxUsers_GetObjLstByRange = QxUsers_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function QxUsers_GetObjLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const arrQxUsersObjLst_Cache = await QxUsers_GetObjLst_Cache();
        if (arrQxUsersObjLst_Cache.length == 0)
            return arrQxUsersObjLst_Cache;
        let arrQxUsers_Sel = arrQxUsersObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objQxUsers_Cond = new clsQxUsersEN_js_1.clsQxUsersEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objQxUsers_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsQxUsersWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objQxUsers_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrQxUsers_Sel = arrQxUsers_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrQxUsers_Sel.length == 0)
                return arrQxUsers_Sel;
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
                arrQxUsers_Sel = arrQxUsers_Sel.sort(QxUsers_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrQxUsers_Sel = arrQxUsers_Sel.sort(objPagerPara.sortFun);
            }
            arrQxUsers_Sel = arrQxUsers_Sel.slice(intStart, intEnd);
            return arrQxUsers_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.qxUsers_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.QxUsers_GetObjLstByPager_Cache = QxUsers_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function QxUsers_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qxUsers_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.qxUsers_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = QxUsers_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qxUsers_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qxUsers_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.QxUsers_GetObjLstByPagerAsync = QxUsers_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param strUserId:关键字
    * @returns 获取删除的结果
    **/
    async function QxUsers_DelRecordAsync(strUserId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qxUsers_Controller, strAction);
        strUrl = (0, clsString_js_2.Format)("{0}/?Id={1}", strUrl, strUserId);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qxUsers_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qxUsers_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.QxUsers_DelRecordAsync = QxUsers_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrUserId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function QxUsers_DelQxUserssAsync(arrUserId) {
        const strThisFuncName = "DelQxUserssAsync";
        const strAction = "DelQxUserss";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qxUsers_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qxUsers_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qxUsers_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.QxUsers_DelQxUserssAsync = QxUsers_DelQxUserssAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function QxUsers_DelQxUserssByCondAsync(strWhereCond) {
        const strThisFuncName = "DelQxUserssByCondAsync";
        const strAction = "DelQxUserssByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qxUsers_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qxUsers_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qxUsers_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.QxUsers_DelQxUserssByCondAsync = QxUsers_DelQxUserssByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objQxUsersEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function QxUsers_AddNewRecordAsync(objQxUsersEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        if (objQxUsersEN.userId === null || objQxUsersEN.userId === "") {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            throw strMsg;
        }
        //var strJSON = JSON.stringify(objQxUsersEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qxUsers_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objQxUsersEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qxUsers_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qxUsers_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.QxUsers_AddNewRecordAsync = QxUsers_AddNewRecordAsync;
    /**
    * 调用WebApi来添加记录，关键字用最大关键字，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithMaxIdAsync)
    * @param objQxUsersEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function QxUsers_AddNewRecordWithMaxIdAsync(objQxUsersEN) {
        const strThisFuncName = "AddNewRecordWithMaxIdAsync";
        const strAction = "AddNewRecordWithMaxId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qxUsers_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objQxUsersEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qxUsers_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qxUsers_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.QxUsers_AddNewRecordWithMaxIdAsync = QxUsers_AddNewRecordWithMaxIdAsync;
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objQxUsersEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function QxUsers_AddNewRecordWithReturnKeyAsync(objQxUsersEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qxUsers_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objQxUsersEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qxUsers_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qxUsers_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.QxUsers_AddNewRecordWithReturnKeyAsync = QxUsers_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objQxUsersEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function QxUsers_AddNewRecordWithReturnKey(objQxUsersEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objQxUsersEN.userId === null || objQxUsersEN.userId === "") {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qxUsers_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objQxUsersEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qxUsers_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qxUsers_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.QxUsers_AddNewRecordWithReturnKey = QxUsers_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objQxUsersEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function QxUsers_UpdateRecordAsync(objQxUsersEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objQxUsersEN.sf_UpdFldSetStr === undefined || objQxUsersEN.sf_UpdFldSetStr === null || objQxUsersEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objQxUsersEN.userId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qxUsers_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objQxUsersEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qxUsers_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qxUsers_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.QxUsers_UpdateRecordAsync = QxUsers_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objQxUsersEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function QxUsers_UpdateWithConditionAsync(objQxUsersEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objQxUsersEN.sf_UpdFldSetStr === undefined || objQxUsersEN.sf_UpdFldSetStr === null || objQxUsersEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objQxUsersEN.userId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qxUsers_Controller, strAction);
        objQxUsersEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objQxUsersEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qxUsers_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qxUsers_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.QxUsers_UpdateWithConditionAsync = QxUsers_UpdateWithConditionAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objstrUserId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function QxUsers_IsExistRecord_Cache(objQxUsers_Cond) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrQxUsersObjLst_Cache = await QxUsers_GetObjLst_Cache();
        if (arrQxUsersObjLst_Cache == null)
            return false;
        let arrQxUsers_Sel = arrQxUsersObjLst_Cache;
        if (objQxUsers_Cond.sf_FldComparisonOp == null || objQxUsers_Cond.sf_FldComparisonOp == "")
            return arrQxUsers_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objQxUsers_Cond.sf_FldComparisonOp);
        //console.log("clsQxUsersWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objQxUsers_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objQxUsers_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrQxUsers_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objQxUsers_Cond), exports.qxUsers_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.QxUsers_IsExistRecord_Cache = QxUsers_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function QxUsers_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qxUsers_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qxUsers_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qxUsers_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.QxUsers_IsExistRecordAsync = QxUsers_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strUserId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function QxUsers_IsExist(strUserId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qxUsers_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qxUsers_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qxUsers_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.QxUsers_IsExist = QxUsers_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param strUserId:所给的关键字
     * @returns 对象
    */
    async function QxUsers_IsExist_Cache(strUserId) {
        const strThisFuncName = "IsExist_Cache";
        const arrQxUsersObjLst_Cache = await QxUsers_GetObjLst_Cache();
        if (arrQxUsersObjLst_Cache == null)
            return false;
        try {
            const arrQxUsers_Sel = arrQxUsersObjLst_Cache.filter(x => x.userId == strUserId);
            if (arrQxUsers_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strUserId, exports.qxUsers_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.QxUsers_IsExist_Cache = QxUsers_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strUserId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function QxUsers_IsExistAsync(strUserId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qxUsers_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qxUsers_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qxUsers_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.QxUsers_IsExistAsync = QxUsers_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function QxUsers_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qxUsers_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qxUsers_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qxUsers_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.QxUsers_GetRecCountByCondAsync = QxUsers_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objQxUsers_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function QxUsers_GetRecCountByCond_Cache(objQxUsers_Cond) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrQxUsersObjLst_Cache = await QxUsers_GetObjLst_Cache();
        if (arrQxUsersObjLst_Cache == null)
            return 0;
        let arrQxUsers_Sel = arrQxUsersObjLst_Cache;
        if (objQxUsers_Cond.sf_FldComparisonOp == null || objQxUsers_Cond.sf_FldComparisonOp == "")
            return arrQxUsers_Sel.length;
        const dicFldComparisonOp = JSON.parse(objQxUsers_Cond.sf_FldComparisonOp);
        //console.log("clsQxUsersWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objQxUsers_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objQxUsers_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrQxUsers_Sel = arrQxUsers_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrQxUsers_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objQxUsers_Cond), exports.qxUsers_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.QxUsers_GetRecCountByCond_Cache = QxUsers_GetRecCountByCond_Cache;
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
    async function QxUsers_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qxUsers_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qxUsers_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qxUsers_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.QxUsers_GetMaxStrIdByPrefix = QxUsers_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function QxUsers_GetWebApiUrl(strController, strAction) {
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
    exports.QxUsers_GetWebApiUrl = QxUsers_GetWebApiUrl;
    /**
    * 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshCache)
    **/
    function QxUsers_ReFreshCache() {
        const strThisFuncName = "ReFreshCache";
        const strMsg = (0, clsString_js_2.Format)("刷新缓存成功！");
        console.trace(strMsg);
        // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
        const strKey = clsQxUsersEN_js_1.clsQxUsersEN._CurrTabName;
        switch (clsQxUsersEN_js_1.clsQxUsersEN.CacheModeId) {
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
    exports.QxUsers_ReFreshCache = QxUsers_ReFreshCache;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function QxUsers_ReFreshThisCache() {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = clsQxUsersEN_js_1.clsQxUsersEN._CurrTabName;
            switch (clsQxUsersEN_js_1.clsQxUsersEN.CacheModeId) {
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
    exports.QxUsers_ReFreshThisCache = QxUsers_ReFreshThisCache;
    /* 该表的下拉框功能没有设置，不需要生成下拉框绑定函数。*/
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function QxUsers_CheckPropertyNew(pobjQxUsersEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.userName) === true) {
            throw new Error("(errid:Watl000058)字段[用户名]不能为空(In Qx用户)!(clsQxUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.userStateId) === true) {
            throw new Error("(errid:Watl000058)字段[用户状态Id]不能为空(In Qx用户)!(clsQxUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.effitiveBeginDate) === true) {
            throw new Error("(errid:Watl000058)字段[EffitiveBeginDate]不能为空(In Qx用户)!(clsQxUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.effitiveEndDate) === true) {
            throw new Error("(errid:Watl000058)字段[EffitiveEndDate]不能为空(In Qx用户)!(clsQxUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.id_College) === true
            || pobjQxUsersEN.id_College.toString() === "0") {
            throw new Error("(errid:Watl000058)字段[学院流水号]不能为空(In Qx用户)!(clsQxUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.stuTeacherID) === true) {
            throw new Error("(errid:Watl000058)字段[学工号]不能为空(In Qx用户)!(clsQxUsersBL:CheckPropertyNew)");
        }
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.userId) == false && (0, clsString_js_2.GetStrLen)(pobjQxUsersEN.userId) > 18) {
            throw new Error("(errid:Watl000059)字段[用户ID(userId)]的长度不能超过18(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.userId)(clsQxUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.userName) == false && (0, clsString_js_2.GetStrLen)(pobjQxUsersEN.userName) > 30) {
            throw new Error("(errid:Watl000059)字段[用户名(userName)]的长度不能超过30(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.userName)(clsQxUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.departmentId) == false && (0, clsString_js_2.GetStrLen)(pobjQxUsersEN.departmentId) > 8) {
            throw new Error("(errid:Watl000059)字段[部门Id(departmentId)]的长度不能超过8(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.departmentId)(clsQxUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.id_XzCollege) == false && (0, clsString_js_2.GetStrLen)(pobjQxUsersEN.id_XzCollege) > 4) {
            throw new Error("(errid:Watl000059)字段[学院流水号(id_XzCollege)]的长度不能超过4(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.id_XzCollege)(clsQxUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.userStateId) == false && (0, clsString_js_2.GetStrLen)(pobjQxUsersEN.userStateId) > 2) {
            throw new Error("(errid:Watl000059)字段[用户状态Id(userStateId)]的长度不能超过2(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.userStateId)(clsQxUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.id_GradeBase) == false && (0, clsString_js_2.GetStrLen)(pobjQxUsersEN.id_GradeBase) > 4) {
            throw new Error("(errid:Watl000059)字段[年级流水号(id_GradeBase)]的长度不能超过4(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.id_GradeBase)(clsQxUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.card_State) == false && (0, clsString_js_2.GetStrLen)(pobjQxUsersEN.card_State) > 10) {
            throw new Error("(errid:Watl000059)字段[Card_State(card_State)]的长度不能超过10(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.card_State)(clsQxUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.cardNo) == false && (0, clsString_js_2.GetStrLen)(pobjQxUsersEN.cardNo) > 18) {
            throw new Error("(errid:Watl000059)字段[卡号(cardNo)]的长度不能超过18(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.cardNo)(clsQxUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.beginYearMonth) == false && (0, clsString_js_2.GetStrLen)(pobjQxUsersEN.beginYearMonth) > 8) {
            throw new Error("(errid:Watl000059)字段[开始年月(beginYearMonth)]的长度不能超过8(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.beginYearMonth)(clsQxUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.endYearMonth) == false && (0, clsString_js_2.GetStrLen)(pobjQxUsersEN.endYearMonth) > 8) {
            throw new Error("(errid:Watl000059)字段[结束年月(endYearMonth)]的长度不能超过8(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.endYearMonth)(clsQxUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.optUser) == false && (0, clsString_js_2.GetStrLen)(pobjQxUsersEN.optUser) > 20) {
            throw new Error("(errid:Watl000059)字段[OptUser(optUser)]的长度不能超过20(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.optUser)(clsQxUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.optDate) == false && (0, clsString_js_2.GetStrLen)(pobjQxUsersEN.optDate) > 20) {
            throw new Error("(errid:Watl000059)字段[OptDate(optDate)]的长度不能超过20(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.optDate)(clsQxUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjQxUsersEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.memo)(clsQxUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.password) == false && (0, clsString_js_2.GetStrLen)(pobjQxUsersEN.password) > 20) {
            throw new Error("(errid:Watl000059)字段[Password(password)]的长度不能超过20(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.password)(clsQxUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.schoolID1) == false && (0, clsString_js_2.GetStrLen)(pobjQxUsersEN.schoolID1) > 4) {
            throw new Error("(errid:Watl000059)字段[学校编号(schoolID1)]的长度不能超过4(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.schoolID1)(clsQxUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.avatarsPicture) == false && (0, clsString_js_2.GetStrLen)(pobjQxUsersEN.avatarsPicture) > 100) {
            throw new Error("(errid:Watl000059)字段[AvatarsPicture(avatarsPicture)]的长度不能超过100(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.avatarsPicture)(clsQxUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.email) == false && (0, clsString_js_2.GetStrLen)(pobjQxUsersEN.email) > 100) {
            throw new Error("(errid:Watl000059)字段[电子邮箱(email)]的长度不能超过100(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.email)(clsQxUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.phoneNumber) == false && (0, clsString_js_2.GetStrLen)(pobjQxUsersEN.phoneNumber) > 15) {
            throw new Error("(errid:Watl000059)字段[PhoneNumber(phoneNumber)]的长度不能超过15(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.phoneNumber)(clsQxUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.effectiveDate) == false && (0, clsString_js_2.GetStrLen)(pobjQxUsersEN.effectiveDate) > 8) {
            throw new Error("(errid:Watl000059)字段[EffectiveDate(effectiveDate)]的长度不能超过8(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.effectiveDate)(clsQxUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjQxUsersEN.updDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.updDate)(clsQxUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.updUser) == false && (0, clsString_js_2.GetStrLen)(pobjQxUsersEN.updUser) > 20) {
            throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.updUser)(clsQxUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.effitiveBeginDate) == false && (0, clsString_js_2.GetStrLen)(pobjQxUsersEN.effitiveBeginDate) > 14) {
            throw new Error("(errid:Watl000059)字段[EffitiveBeginDate(effitiveBeginDate)]的长度不能超过14(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.effitiveBeginDate)(clsQxUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.effitiveEndDate) == false && (0, clsString_js_2.GetStrLen)(pobjQxUsersEN.effitiveEndDate) > 14) {
            throw new Error("(errid:Watl000059)字段[EffitiveEndDate(effitiveEndDate)]的长度不能超过14(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.effitiveEndDate)(clsQxUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.id_College) == false && (0, clsString_js_2.GetStrLen)(pobjQxUsersEN.id_College) > 4) {
            throw new Error("(errid:Watl000059)字段[学院流水号(id_College)]的长度不能超过4(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.id_College)(clsQxUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.stuTeacherID) == false && (0, clsString_js_2.GetStrLen)(pobjQxUsersEN.stuTeacherID) > 20) {
            throw new Error("(errid:Watl000059)字段[学工号(stuTeacherID)]的长度不能超过20(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.stuTeacherID)(clsQxUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.identityID) == false && (0, clsString_js_2.GetStrLen)(pobjQxUsersEN.identityID) > 2) {
            throw new Error("(errid:Watl000059)字段[身份编号(identityID)]的长度不能超过2(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.identityID)(clsQxUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.headimgUrl) == false && (0, clsString_js_2.GetStrLen)(pobjQxUsersEN.headimgUrl) > 1000) {
            throw new Error("(errid:Watl000059)字段[微信头像(headimgUrl)]的长度不能超过1000(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.headimgUrl)(clsQxUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.openId) == false && (0, clsString_js_2.GetStrLen)(pobjQxUsersEN.openId) > 50) {
            throw new Error("(errid:Watl000059)字段[微信OpenId(openId)]的长度不能超过50(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.openId)(clsQxUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.nickName) == false && (0, clsString_js_2.GetStrLen)(pobjQxUsersEN.nickName) > 50) {
            throw new Error("(errid:Watl000059)字段[昵称(nickName)]的长度不能超过50(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.nickName)(clsQxUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.synchDate) == false && (0, clsString_js_2.GetStrLen)(pobjQxUsersEN.synchDate) > 30) {
            throw new Error("(errid:Watl000059)字段[同步日期(synchDate)]的长度不能超过30(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.synchDate)(clsQxUsersBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.userId) == false && undefined !== pobjQxUsersEN.userId && clsString_js_1.tzDataType.isString(pobjQxUsersEN.userId) === false) {
            throw new Error("(errid:Watl000060)字段[用户ID(userId)]的值:[$(pobjQxUsersEN.userId)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.userName) == false && undefined !== pobjQxUsersEN.userName && clsString_js_1.tzDataType.isString(pobjQxUsersEN.userName) === false) {
            throw new Error("(errid:Watl000060)字段[用户名(userName)]的值:[$(pobjQxUsersEN.userName)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.departmentId) == false && undefined !== pobjQxUsersEN.departmentId && clsString_js_1.tzDataType.isString(pobjQxUsersEN.departmentId) === false) {
            throw new Error("(errid:Watl000060)字段[部门Id(departmentId)]的值:[$(pobjQxUsersEN.departmentId)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.id_XzCollege) == false && undefined !== pobjQxUsersEN.id_XzCollege && clsString_js_1.tzDataType.isString(pobjQxUsersEN.id_XzCollege) === false) {
            throw new Error("(errid:Watl000060)字段[学院流水号(id_XzCollege)]的值:[$(pobjQxUsersEN.id_XzCollege)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.userStateId) == false && undefined !== pobjQxUsersEN.userStateId && clsString_js_1.tzDataType.isString(pobjQxUsersEN.userStateId) === false) {
            throw new Error("(errid:Watl000060)字段[用户状态Id(userStateId)]的值:[$(pobjQxUsersEN.userStateId)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.id_GradeBase) == false && undefined !== pobjQxUsersEN.id_GradeBase && clsString_js_1.tzDataType.isString(pobjQxUsersEN.id_GradeBase) === false) {
            throw new Error("(errid:Watl000060)字段[年级流水号(id_GradeBase)]的值:[$(pobjQxUsersEN.id_GradeBase)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.card_State) == false && undefined !== pobjQxUsersEN.card_State && clsString_js_1.tzDataType.isString(pobjQxUsersEN.card_State) === false) {
            throw new Error("(errid:Watl000060)字段[Card_State(card_State)]的值:[$(pobjQxUsersEN.card_State)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckPropertyNew)");
        }
        if (null != pobjQxUsersEN.isLeaved && undefined !== pobjQxUsersEN.isLeaved && clsString_js_1.tzDataType.isBoolean(pobjQxUsersEN.isLeaved) === false) {
            throw new Error("(errid:Watl000060)字段[IsLeaved(isLeaved)]的值:[$(pobjQxUsersEN.isLeaved)], 非法，应该为布尔型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.cardNo) == false && undefined !== pobjQxUsersEN.cardNo && clsString_js_1.tzDataType.isString(pobjQxUsersEN.cardNo) === false) {
            throw new Error("(errid:Watl000060)字段[卡号(cardNo)]的值:[$(pobjQxUsersEN.cardNo)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.beginYearMonth) == false && undefined !== pobjQxUsersEN.beginYearMonth && clsString_js_1.tzDataType.isString(pobjQxUsersEN.beginYearMonth) === false) {
            throw new Error("(errid:Watl000060)字段[开始年月(beginYearMonth)]的值:[$(pobjQxUsersEN.beginYearMonth)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.endYearMonth) == false && undefined !== pobjQxUsersEN.endYearMonth && clsString_js_1.tzDataType.isString(pobjQxUsersEN.endYearMonth) === false) {
            throw new Error("(errid:Watl000060)字段[结束年月(endYearMonth)]的值:[$(pobjQxUsersEN.endYearMonth)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.optUser) == false && undefined !== pobjQxUsersEN.optUser && clsString_js_1.tzDataType.isString(pobjQxUsersEN.optUser) === false) {
            throw new Error("(errid:Watl000060)字段[OptUser(optUser)]的值:[$(pobjQxUsersEN.optUser)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.optDate) == false && undefined !== pobjQxUsersEN.optDate && clsString_js_1.tzDataType.isString(pobjQxUsersEN.optDate) === false) {
            throw new Error("(errid:Watl000060)字段[OptDate(optDate)]的值:[$(pobjQxUsersEN.optDate)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.memo) == false && undefined !== pobjQxUsersEN.memo && clsString_js_1.tzDataType.isString(pobjQxUsersEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjQxUsersEN.memo)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.password) == false && undefined !== pobjQxUsersEN.password && clsString_js_1.tzDataType.isString(pobjQxUsersEN.password) === false) {
            throw new Error("(errid:Watl000060)字段[Password(password)]的值:[$(pobjQxUsersEN.password)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckPropertyNew)");
        }
        if (null != pobjQxUsersEN.isGpUser && undefined !== pobjQxUsersEN.isGpUser && clsString_js_1.tzDataType.isBoolean(pobjQxUsersEN.isGpUser) === false) {
            throw new Error("(errid:Watl000060)字段[是否Gp用户(isGpUser)]的值:[$(pobjQxUsersEN.isGpUser)], 非法，应该为布尔型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.schoolID1) == false && undefined !== pobjQxUsersEN.schoolID1 && clsString_js_1.tzDataType.isString(pobjQxUsersEN.schoolID1) === false) {
            throw new Error("(errid:Watl000060)字段[学校编号(schoolID1)]的值:[$(pobjQxUsersEN.schoolID1)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.avatarsPicture) == false && undefined !== pobjQxUsersEN.avatarsPicture && clsString_js_1.tzDataType.isString(pobjQxUsersEN.avatarsPicture) === false) {
            throw new Error("(errid:Watl000060)字段[AvatarsPicture(avatarsPicture)]的值:[$(pobjQxUsersEN.avatarsPicture)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.email) == false && undefined !== pobjQxUsersEN.email && clsString_js_1.tzDataType.isString(pobjQxUsersEN.email) === false) {
            throw new Error("(errid:Watl000060)字段[电子邮箱(email)]的值:[$(pobjQxUsersEN.email)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.phoneNumber) == false && undefined !== pobjQxUsersEN.phoneNumber && clsString_js_1.tzDataType.isString(pobjQxUsersEN.phoneNumber) === false) {
            throw new Error("(errid:Watl000060)字段[PhoneNumber(phoneNumber)]的值:[$(pobjQxUsersEN.phoneNumber)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.effectiveDate) == false && undefined !== pobjQxUsersEN.effectiveDate && clsString_js_1.tzDataType.isString(pobjQxUsersEN.effectiveDate) === false) {
            throw new Error("(errid:Watl000060)字段[EffectiveDate(effectiveDate)]的值:[$(pobjQxUsersEN.effectiveDate)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.updDate) == false && undefined !== pobjQxUsersEN.updDate && clsString_js_1.tzDataType.isString(pobjQxUsersEN.updDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjQxUsersEN.updDate)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.updUser) == false && undefined !== pobjQxUsersEN.updUser && clsString_js_1.tzDataType.isString(pobjQxUsersEN.updUser) === false) {
            throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjQxUsersEN.updUser)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.effitiveBeginDate) == false && undefined !== pobjQxUsersEN.effitiveBeginDate && clsString_js_1.tzDataType.isString(pobjQxUsersEN.effitiveBeginDate) === false) {
            throw new Error("(errid:Watl000060)字段[EffitiveBeginDate(effitiveBeginDate)]的值:[$(pobjQxUsersEN.effitiveBeginDate)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.effitiveEndDate) == false && undefined !== pobjQxUsersEN.effitiveEndDate && clsString_js_1.tzDataType.isString(pobjQxUsersEN.effitiveEndDate) === false) {
            throw new Error("(errid:Watl000060)字段[EffitiveEndDate(effitiveEndDate)]的值:[$(pobjQxUsersEN.effitiveEndDate)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.id_College) == false && undefined !== pobjQxUsersEN.id_College && clsString_js_1.tzDataType.isString(pobjQxUsersEN.id_College) === false) {
            throw new Error("(errid:Watl000060)字段[学院流水号(id_College)]的值:[$(pobjQxUsersEN.id_College)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.stuTeacherID) == false && undefined !== pobjQxUsersEN.stuTeacherID && clsString_js_1.tzDataType.isString(pobjQxUsersEN.stuTeacherID) === false) {
            throw new Error("(errid:Watl000060)字段[学工号(stuTeacherID)]的值:[$(pobjQxUsersEN.stuTeacherID)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.identityID) == false && undefined !== pobjQxUsersEN.identityID && clsString_js_1.tzDataType.isString(pobjQxUsersEN.identityID) === false) {
            throw new Error("(errid:Watl000060)字段[身份编号(identityID)]的值:[$(pobjQxUsersEN.identityID)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckPropertyNew)");
        }
        if (null != pobjQxUsersEN.isArchive && undefined !== pobjQxUsersEN.isArchive && clsString_js_1.tzDataType.isBoolean(pobjQxUsersEN.isArchive) === false) {
            throw new Error("(errid:Watl000060)字段[IsArchive(isArchive)]的值:[$(pobjQxUsersEN.isArchive)], 非法，应该为布尔型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.headimgUrl) == false && undefined !== pobjQxUsersEN.headimgUrl && clsString_js_1.tzDataType.isString(pobjQxUsersEN.headimgUrl) === false) {
            throw new Error("(errid:Watl000060)字段[微信头像(headimgUrl)]的值:[$(pobjQxUsersEN.headimgUrl)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.openId) == false && undefined !== pobjQxUsersEN.openId && clsString_js_1.tzDataType.isString(pobjQxUsersEN.openId) === false) {
            throw new Error("(errid:Watl000060)字段[微信OpenId(openId)]的值:[$(pobjQxUsersEN.openId)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.nickName) == false && undefined !== pobjQxUsersEN.nickName && clsString_js_1.tzDataType.isString(pobjQxUsersEN.nickName) === false) {
            throw new Error("(errid:Watl000060)字段[昵称(nickName)]的值:[$(pobjQxUsersEN.nickName)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckPropertyNew)");
        }
        if (null != pobjQxUsersEN.isSynch && undefined !== pobjQxUsersEN.isSynch && clsString_js_1.tzDataType.isBoolean(pobjQxUsersEN.isSynch) === false) {
            throw new Error("(errid:Watl000060)字段[是否同步(isSynch)]的值:[$(pobjQxUsersEN.isSynch)], 非法，应该为布尔型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.synchDate) == false && undefined !== pobjQxUsersEN.synchDate && clsString_js_1.tzDataType.isString(pobjQxUsersEN.synchDate) === false) {
            throw new Error("(errid:Watl000060)字段[同步日期(synchDate)]的值:[$(pobjQxUsersEN.synchDate)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjQxUsersEN.SetIsCheckProperty(true);
    }
    exports.QxUsers_CheckPropertyNew = QxUsers_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function QxUsers_CheckProperty4Update(pobjQxUsersEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.userId) == false && (0, clsString_js_2.GetStrLen)(pobjQxUsersEN.userId) > 18) {
            throw new Error("(errid:Watl000062)字段[用户ID(userId)]的长度不能超过18(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.userId)(clsQxUsersBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.userName) == false && (0, clsString_js_2.GetStrLen)(pobjQxUsersEN.userName) > 30) {
            throw new Error("(errid:Watl000062)字段[用户名(userName)]的长度不能超过30(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.userName)(clsQxUsersBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.departmentId) == false && (0, clsString_js_2.GetStrLen)(pobjQxUsersEN.departmentId) > 8) {
            throw new Error("(errid:Watl000062)字段[部门Id(departmentId)]的长度不能超过8(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.departmentId)(clsQxUsersBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.id_XzCollege) == false && (0, clsString_js_2.GetStrLen)(pobjQxUsersEN.id_XzCollege) > 4) {
            throw new Error("(errid:Watl000062)字段[学院流水号(id_XzCollege)]的长度不能超过4(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.id_XzCollege)(clsQxUsersBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.userStateId) == false && (0, clsString_js_2.GetStrLen)(pobjQxUsersEN.userStateId) > 2) {
            throw new Error("(errid:Watl000062)字段[用户状态Id(userStateId)]的长度不能超过2(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.userStateId)(clsQxUsersBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.id_GradeBase) == false && (0, clsString_js_2.GetStrLen)(pobjQxUsersEN.id_GradeBase) > 4) {
            throw new Error("(errid:Watl000062)字段[年级流水号(id_GradeBase)]的长度不能超过4(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.id_GradeBase)(clsQxUsersBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.card_State) == false && (0, clsString_js_2.GetStrLen)(pobjQxUsersEN.card_State) > 10) {
            throw new Error("(errid:Watl000062)字段[Card_State(card_State)]的长度不能超过10(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.card_State)(clsQxUsersBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.cardNo) == false && (0, clsString_js_2.GetStrLen)(pobjQxUsersEN.cardNo) > 18) {
            throw new Error("(errid:Watl000062)字段[卡号(cardNo)]的长度不能超过18(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.cardNo)(clsQxUsersBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.beginYearMonth) == false && (0, clsString_js_2.GetStrLen)(pobjQxUsersEN.beginYearMonth) > 8) {
            throw new Error("(errid:Watl000062)字段[开始年月(beginYearMonth)]的长度不能超过8(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.beginYearMonth)(clsQxUsersBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.endYearMonth) == false && (0, clsString_js_2.GetStrLen)(pobjQxUsersEN.endYearMonth) > 8) {
            throw new Error("(errid:Watl000062)字段[结束年月(endYearMonth)]的长度不能超过8(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.endYearMonth)(clsQxUsersBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.optUser) == false && (0, clsString_js_2.GetStrLen)(pobjQxUsersEN.optUser) > 20) {
            throw new Error("(errid:Watl000062)字段[OptUser(optUser)]的长度不能超过20(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.optUser)(clsQxUsersBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.optDate) == false && (0, clsString_js_2.GetStrLen)(pobjQxUsersEN.optDate) > 20) {
            throw new Error("(errid:Watl000062)字段[OptDate(optDate)]的长度不能超过20(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.optDate)(clsQxUsersBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjQxUsersEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.memo)(clsQxUsersBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.password) == false && (0, clsString_js_2.GetStrLen)(pobjQxUsersEN.password) > 20) {
            throw new Error("(errid:Watl000062)字段[Password(password)]的长度不能超过20(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.password)(clsQxUsersBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.schoolID1) == false && (0, clsString_js_2.GetStrLen)(pobjQxUsersEN.schoolID1) > 4) {
            throw new Error("(errid:Watl000062)字段[学校编号(schoolID1)]的长度不能超过4(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.schoolID1)(clsQxUsersBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.avatarsPicture) == false && (0, clsString_js_2.GetStrLen)(pobjQxUsersEN.avatarsPicture) > 100) {
            throw new Error("(errid:Watl000062)字段[AvatarsPicture(avatarsPicture)]的长度不能超过100(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.avatarsPicture)(clsQxUsersBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.email) == false && (0, clsString_js_2.GetStrLen)(pobjQxUsersEN.email) > 100) {
            throw new Error("(errid:Watl000062)字段[电子邮箱(email)]的长度不能超过100(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.email)(clsQxUsersBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.phoneNumber) == false && (0, clsString_js_2.GetStrLen)(pobjQxUsersEN.phoneNumber) > 15) {
            throw new Error("(errid:Watl000062)字段[PhoneNumber(phoneNumber)]的长度不能超过15(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.phoneNumber)(clsQxUsersBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.effectiveDate) == false && (0, clsString_js_2.GetStrLen)(pobjQxUsersEN.effectiveDate) > 8) {
            throw new Error("(errid:Watl000062)字段[EffectiveDate(effectiveDate)]的长度不能超过8(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.effectiveDate)(clsQxUsersBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjQxUsersEN.updDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.updDate)(clsQxUsersBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.updUser) == false && (0, clsString_js_2.GetStrLen)(pobjQxUsersEN.updUser) > 20) {
            throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.updUser)(clsQxUsersBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.effitiveBeginDate) == false && (0, clsString_js_2.GetStrLen)(pobjQxUsersEN.effitiveBeginDate) > 14) {
            throw new Error("(errid:Watl000062)字段[EffitiveBeginDate(effitiveBeginDate)]的长度不能超过14(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.effitiveBeginDate)(clsQxUsersBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.effitiveEndDate) == false && (0, clsString_js_2.GetStrLen)(pobjQxUsersEN.effitiveEndDate) > 14) {
            throw new Error("(errid:Watl000062)字段[EffitiveEndDate(effitiveEndDate)]的长度不能超过14(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.effitiveEndDate)(clsQxUsersBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.id_College) == false && (0, clsString_js_2.GetStrLen)(pobjQxUsersEN.id_College) > 4) {
            throw new Error("(errid:Watl000062)字段[学院流水号(id_College)]的长度不能超过4(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.id_College)(clsQxUsersBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.stuTeacherID) == false && (0, clsString_js_2.GetStrLen)(pobjQxUsersEN.stuTeacherID) > 20) {
            throw new Error("(errid:Watl000062)字段[学工号(stuTeacherID)]的长度不能超过20(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.stuTeacherID)(clsQxUsersBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.identityID) == false && (0, clsString_js_2.GetStrLen)(pobjQxUsersEN.identityID) > 2) {
            throw new Error("(errid:Watl000062)字段[身份编号(identityID)]的长度不能超过2(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.identityID)(clsQxUsersBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.headimgUrl) == false && (0, clsString_js_2.GetStrLen)(pobjQxUsersEN.headimgUrl) > 1000) {
            throw new Error("(errid:Watl000062)字段[微信头像(headimgUrl)]的长度不能超过1000(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.headimgUrl)(clsQxUsersBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.openId) == false && (0, clsString_js_2.GetStrLen)(pobjQxUsersEN.openId) > 50) {
            throw new Error("(errid:Watl000062)字段[微信OpenId(openId)]的长度不能超过50(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.openId)(clsQxUsersBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.nickName) == false && (0, clsString_js_2.GetStrLen)(pobjQxUsersEN.nickName) > 50) {
            throw new Error("(errid:Watl000062)字段[昵称(nickName)]的长度不能超过50(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.nickName)(clsQxUsersBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.synchDate) == false && (0, clsString_js_2.GetStrLen)(pobjQxUsersEN.synchDate) > 30) {
            throw new Error("(errid:Watl000062)字段[同步日期(synchDate)]的长度不能超过30(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.synchDate)(clsQxUsersBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.userId) == false && undefined !== pobjQxUsersEN.userId && clsString_js_1.tzDataType.isString(pobjQxUsersEN.userId) === false) {
            throw new Error("(errid:Watl000063)字段[用户ID(userId)]的值:[$(pobjQxUsersEN.userId)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.userName) == false && undefined !== pobjQxUsersEN.userName && clsString_js_1.tzDataType.isString(pobjQxUsersEN.userName) === false) {
            throw new Error("(errid:Watl000063)字段[用户名(userName)]的值:[$(pobjQxUsersEN.userName)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.departmentId) == false && undefined !== pobjQxUsersEN.departmentId && clsString_js_1.tzDataType.isString(pobjQxUsersEN.departmentId) === false) {
            throw new Error("(errid:Watl000063)字段[部门Id(departmentId)]的值:[$(pobjQxUsersEN.departmentId)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.id_XzCollege) == false && undefined !== pobjQxUsersEN.id_XzCollege && clsString_js_1.tzDataType.isString(pobjQxUsersEN.id_XzCollege) === false) {
            throw new Error("(errid:Watl000063)字段[学院流水号(id_XzCollege)]的值:[$(pobjQxUsersEN.id_XzCollege)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.userStateId) == false && undefined !== pobjQxUsersEN.userStateId && clsString_js_1.tzDataType.isString(pobjQxUsersEN.userStateId) === false) {
            throw new Error("(errid:Watl000063)字段[用户状态Id(userStateId)]的值:[$(pobjQxUsersEN.userStateId)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.id_GradeBase) == false && undefined !== pobjQxUsersEN.id_GradeBase && clsString_js_1.tzDataType.isString(pobjQxUsersEN.id_GradeBase) === false) {
            throw new Error("(errid:Watl000063)字段[年级流水号(id_GradeBase)]的值:[$(pobjQxUsersEN.id_GradeBase)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.card_State) == false && undefined !== pobjQxUsersEN.card_State && clsString_js_1.tzDataType.isString(pobjQxUsersEN.card_State) === false) {
            throw new Error("(errid:Watl000063)字段[Card_State(card_State)]的值:[$(pobjQxUsersEN.card_State)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckProperty4Update)");
        }
        if (null != pobjQxUsersEN.isLeaved && undefined !== pobjQxUsersEN.isLeaved && clsString_js_1.tzDataType.isBoolean(pobjQxUsersEN.isLeaved) === false) {
            throw new Error("(errid:Watl000063)字段[IsLeaved(isLeaved)]的值:[$(pobjQxUsersEN.isLeaved)], 非法，应该为布尔型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.cardNo) == false && undefined !== pobjQxUsersEN.cardNo && clsString_js_1.tzDataType.isString(pobjQxUsersEN.cardNo) === false) {
            throw new Error("(errid:Watl000063)字段[卡号(cardNo)]的值:[$(pobjQxUsersEN.cardNo)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.beginYearMonth) == false && undefined !== pobjQxUsersEN.beginYearMonth && clsString_js_1.tzDataType.isString(pobjQxUsersEN.beginYearMonth) === false) {
            throw new Error("(errid:Watl000063)字段[开始年月(beginYearMonth)]的值:[$(pobjQxUsersEN.beginYearMonth)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.endYearMonth) == false && undefined !== pobjQxUsersEN.endYearMonth && clsString_js_1.tzDataType.isString(pobjQxUsersEN.endYearMonth) === false) {
            throw new Error("(errid:Watl000063)字段[结束年月(endYearMonth)]的值:[$(pobjQxUsersEN.endYearMonth)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.optUser) == false && undefined !== pobjQxUsersEN.optUser && clsString_js_1.tzDataType.isString(pobjQxUsersEN.optUser) === false) {
            throw new Error("(errid:Watl000063)字段[OptUser(optUser)]的值:[$(pobjQxUsersEN.optUser)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.optDate) == false && undefined !== pobjQxUsersEN.optDate && clsString_js_1.tzDataType.isString(pobjQxUsersEN.optDate) === false) {
            throw new Error("(errid:Watl000063)字段[OptDate(optDate)]的值:[$(pobjQxUsersEN.optDate)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.memo) == false && undefined !== pobjQxUsersEN.memo && clsString_js_1.tzDataType.isString(pobjQxUsersEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjQxUsersEN.memo)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.password) == false && undefined !== pobjQxUsersEN.password && clsString_js_1.tzDataType.isString(pobjQxUsersEN.password) === false) {
            throw new Error("(errid:Watl000063)字段[Password(password)]的值:[$(pobjQxUsersEN.password)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckProperty4Update)");
        }
        if (null != pobjQxUsersEN.isGpUser && undefined !== pobjQxUsersEN.isGpUser && clsString_js_1.tzDataType.isBoolean(pobjQxUsersEN.isGpUser) === false) {
            throw new Error("(errid:Watl000063)字段[是否Gp用户(isGpUser)]的值:[$(pobjQxUsersEN.isGpUser)], 非法，应该为布尔型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.schoolID1) == false && undefined !== pobjQxUsersEN.schoolID1 && clsString_js_1.tzDataType.isString(pobjQxUsersEN.schoolID1) === false) {
            throw new Error("(errid:Watl000063)字段[学校编号(schoolID1)]的值:[$(pobjQxUsersEN.schoolID1)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.avatarsPicture) == false && undefined !== pobjQxUsersEN.avatarsPicture && clsString_js_1.tzDataType.isString(pobjQxUsersEN.avatarsPicture) === false) {
            throw new Error("(errid:Watl000063)字段[AvatarsPicture(avatarsPicture)]的值:[$(pobjQxUsersEN.avatarsPicture)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.email) == false && undefined !== pobjQxUsersEN.email && clsString_js_1.tzDataType.isString(pobjQxUsersEN.email) === false) {
            throw new Error("(errid:Watl000063)字段[电子邮箱(email)]的值:[$(pobjQxUsersEN.email)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.phoneNumber) == false && undefined !== pobjQxUsersEN.phoneNumber && clsString_js_1.tzDataType.isString(pobjQxUsersEN.phoneNumber) === false) {
            throw new Error("(errid:Watl000063)字段[PhoneNumber(phoneNumber)]的值:[$(pobjQxUsersEN.phoneNumber)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.effectiveDate) == false && undefined !== pobjQxUsersEN.effectiveDate && clsString_js_1.tzDataType.isString(pobjQxUsersEN.effectiveDate) === false) {
            throw new Error("(errid:Watl000063)字段[EffectiveDate(effectiveDate)]的值:[$(pobjQxUsersEN.effectiveDate)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.updDate) == false && undefined !== pobjQxUsersEN.updDate && clsString_js_1.tzDataType.isString(pobjQxUsersEN.updDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjQxUsersEN.updDate)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.updUser) == false && undefined !== pobjQxUsersEN.updUser && clsString_js_1.tzDataType.isString(pobjQxUsersEN.updUser) === false) {
            throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjQxUsersEN.updUser)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.effitiveBeginDate) == false && undefined !== pobjQxUsersEN.effitiveBeginDate && clsString_js_1.tzDataType.isString(pobjQxUsersEN.effitiveBeginDate) === false) {
            throw new Error("(errid:Watl000063)字段[EffitiveBeginDate(effitiveBeginDate)]的值:[$(pobjQxUsersEN.effitiveBeginDate)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.effitiveEndDate) == false && undefined !== pobjQxUsersEN.effitiveEndDate && clsString_js_1.tzDataType.isString(pobjQxUsersEN.effitiveEndDate) === false) {
            throw new Error("(errid:Watl000063)字段[EffitiveEndDate(effitiveEndDate)]的值:[$(pobjQxUsersEN.effitiveEndDate)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.id_College) == false && undefined !== pobjQxUsersEN.id_College && clsString_js_1.tzDataType.isString(pobjQxUsersEN.id_College) === false) {
            throw new Error("(errid:Watl000063)字段[学院流水号(id_College)]的值:[$(pobjQxUsersEN.id_College)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.stuTeacherID) == false && undefined !== pobjQxUsersEN.stuTeacherID && clsString_js_1.tzDataType.isString(pobjQxUsersEN.stuTeacherID) === false) {
            throw new Error("(errid:Watl000063)字段[学工号(stuTeacherID)]的值:[$(pobjQxUsersEN.stuTeacherID)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.identityID) == false && undefined !== pobjQxUsersEN.identityID && clsString_js_1.tzDataType.isString(pobjQxUsersEN.identityID) === false) {
            throw new Error("(errid:Watl000063)字段[身份编号(identityID)]的值:[$(pobjQxUsersEN.identityID)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckProperty4Update)");
        }
        if (null != pobjQxUsersEN.isArchive && undefined !== pobjQxUsersEN.isArchive && clsString_js_1.tzDataType.isBoolean(pobjQxUsersEN.isArchive) === false) {
            throw new Error("(errid:Watl000063)字段[IsArchive(isArchive)]的值:[$(pobjQxUsersEN.isArchive)], 非法，应该为布尔型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.headimgUrl) == false && undefined !== pobjQxUsersEN.headimgUrl && clsString_js_1.tzDataType.isString(pobjQxUsersEN.headimgUrl) === false) {
            throw new Error("(errid:Watl000063)字段[微信头像(headimgUrl)]的值:[$(pobjQxUsersEN.headimgUrl)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.openId) == false && undefined !== pobjQxUsersEN.openId && clsString_js_1.tzDataType.isString(pobjQxUsersEN.openId) === false) {
            throw new Error("(errid:Watl000063)字段[微信OpenId(openId)]的值:[$(pobjQxUsersEN.openId)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.nickName) == false && undefined !== pobjQxUsersEN.nickName && clsString_js_1.tzDataType.isString(pobjQxUsersEN.nickName) === false) {
            throw new Error("(errid:Watl000063)字段[昵称(nickName)]的值:[$(pobjQxUsersEN.nickName)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckProperty4Update)");
        }
        if (null != pobjQxUsersEN.isSynch && undefined !== pobjQxUsersEN.isSynch && clsString_js_1.tzDataType.isBoolean(pobjQxUsersEN.isSynch) === false) {
            throw new Error("(errid:Watl000063)字段[是否同步(isSynch)]的值:[$(pobjQxUsersEN.isSynch)], 非法，应该为布尔型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.synchDate) == false && undefined !== pobjQxUsersEN.synchDate && clsString_js_1.tzDataType.isString(pobjQxUsersEN.synchDate) === false) {
            throw new Error("(errid:Watl000063)字段[同步日期(synchDate)]的值:[$(pobjQxUsersEN.synchDate)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQxUsersEN.userId) === true) {
            throw new Error("(errid:Watl000064)字段[用户ID]不能为空(In Qx用户)!(clsQxUsersBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjQxUsersEN.SetIsCheckProperty(true);
    }
    exports.QxUsers_CheckProperty4Update = QxUsers_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function QxUsers_GetJSONStrByObj(pobjQxUsersEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjQxUsersEN.sf_UpdFldSetStr = pobjQxUsersEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjQxUsersEN);
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
    exports.QxUsers_GetJSONStrByObj = QxUsers_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function QxUsers_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrQxUsersObjLst = new Array();
        if (strJSON === "") {
            return arrQxUsersObjLst;
        }
        try {
            arrQxUsersObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrQxUsersObjLst;
        }
        return arrQxUsersObjLst;
    }
    exports.QxUsers_GetObjLstByJSONStr = QxUsers_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrQxUsersObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function QxUsers_GetObjLstByJSONObjLst(arrQxUsersObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrQxUsersObjLst = new Array();
        for (const objInFor of arrQxUsersObjLstS) {
            const obj1 = QxUsers_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrQxUsersObjLst.push(obj1);
        }
        return arrQxUsersObjLst;
    }
    exports.QxUsers_GetObjLstByJSONObjLst = QxUsers_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function QxUsers_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjQxUsersEN = new clsQxUsersEN_js_1.clsQxUsersEN();
        if (strJSON === "") {
            return pobjQxUsersEN;
        }
        try {
            pobjQxUsersEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjQxUsersEN;
        }
        return pobjQxUsersEN;
    }
    exports.QxUsers_GetObjByJSONStr = QxUsers_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function QxUsers_GetCombineCondition(objQxUsers_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objQxUsers_Cond.dicFldComparisonOp, clsQxUsersEN_js_1.clsQxUsersEN.con_UserId) == true) {
            const strComparisonOp_UserId = objQxUsers_Cond.dicFldComparisonOp[clsQxUsersEN_js_1.clsQxUsersEN.con_UserId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsQxUsersEN_js_1.clsQxUsersEN.con_UserId, objQxUsers_Cond.userId, strComparisonOp_UserId);
        }
        if (Object.prototype.hasOwnProperty.call(objQxUsers_Cond.dicFldComparisonOp, clsQxUsersEN_js_1.clsQxUsersEN.con_UserName) == true) {
            const strComparisonOp_UserName = objQxUsers_Cond.dicFldComparisonOp[clsQxUsersEN_js_1.clsQxUsersEN.con_UserName];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsQxUsersEN_js_1.clsQxUsersEN.con_UserName, objQxUsers_Cond.userName, strComparisonOp_UserName);
        }
        if (Object.prototype.hasOwnProperty.call(objQxUsers_Cond.dicFldComparisonOp, clsQxUsersEN_js_1.clsQxUsersEN.con_DepartmentId) == true) {
            const strComparisonOp_DepartmentId = objQxUsers_Cond.dicFldComparisonOp[clsQxUsersEN_js_1.clsQxUsersEN.con_DepartmentId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsQxUsersEN_js_1.clsQxUsersEN.con_DepartmentId, objQxUsers_Cond.departmentId, strComparisonOp_DepartmentId);
        }
        if (Object.prototype.hasOwnProperty.call(objQxUsers_Cond.dicFldComparisonOp, clsQxUsersEN_js_1.clsQxUsersEN.con_id_XzCollege) == true) {
            const strComparisonOp_id_XzCollege = objQxUsers_Cond.dicFldComparisonOp[clsQxUsersEN_js_1.clsQxUsersEN.con_id_XzCollege];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsQxUsersEN_js_1.clsQxUsersEN.con_id_XzCollege, objQxUsers_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
        }
        if (Object.prototype.hasOwnProperty.call(objQxUsers_Cond.dicFldComparisonOp, clsQxUsersEN_js_1.clsQxUsersEN.con_UserStateId) == true) {
            const strComparisonOp_UserStateId = objQxUsers_Cond.dicFldComparisonOp[clsQxUsersEN_js_1.clsQxUsersEN.con_UserStateId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsQxUsersEN_js_1.clsQxUsersEN.con_UserStateId, objQxUsers_Cond.userStateId, strComparisonOp_UserStateId);
        }
        if (Object.prototype.hasOwnProperty.call(objQxUsers_Cond.dicFldComparisonOp, clsQxUsersEN_js_1.clsQxUsersEN.con_id_GradeBase) == true) {
            const strComparisonOp_id_GradeBase = objQxUsers_Cond.dicFldComparisonOp[clsQxUsersEN_js_1.clsQxUsersEN.con_id_GradeBase];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsQxUsersEN_js_1.clsQxUsersEN.con_id_GradeBase, objQxUsers_Cond.id_GradeBase, strComparisonOp_id_GradeBase);
        }
        if (Object.prototype.hasOwnProperty.call(objQxUsers_Cond.dicFldComparisonOp, clsQxUsersEN_js_1.clsQxUsersEN.con_Card_State) == true) {
            const strComparisonOp_Card_State = objQxUsers_Cond.dicFldComparisonOp[clsQxUsersEN_js_1.clsQxUsersEN.con_Card_State];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsQxUsersEN_js_1.clsQxUsersEN.con_Card_State, objQxUsers_Cond.card_State, strComparisonOp_Card_State);
        }
        if (Object.prototype.hasOwnProperty.call(objQxUsers_Cond.dicFldComparisonOp, clsQxUsersEN_js_1.clsQxUsersEN.con_IsLeaved) == true) {
            if (objQxUsers_Cond.isLeaved == true) {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '1'", clsQxUsersEN_js_1.clsQxUsersEN.con_IsLeaved);
            }
            else {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '0'", clsQxUsersEN_js_1.clsQxUsersEN.con_IsLeaved);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objQxUsers_Cond.dicFldComparisonOp, clsQxUsersEN_js_1.clsQxUsersEN.con_CardNo) == true) {
            const strComparisonOp_CardNo = objQxUsers_Cond.dicFldComparisonOp[clsQxUsersEN_js_1.clsQxUsersEN.con_CardNo];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsQxUsersEN_js_1.clsQxUsersEN.con_CardNo, objQxUsers_Cond.cardNo, strComparisonOp_CardNo);
        }
        if (Object.prototype.hasOwnProperty.call(objQxUsers_Cond.dicFldComparisonOp, clsQxUsersEN_js_1.clsQxUsersEN.con_BeginYearMonth) == true) {
            const strComparisonOp_BeginYearMonth = objQxUsers_Cond.dicFldComparisonOp[clsQxUsersEN_js_1.clsQxUsersEN.con_BeginYearMonth];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsQxUsersEN_js_1.clsQxUsersEN.con_BeginYearMonth, objQxUsers_Cond.beginYearMonth, strComparisonOp_BeginYearMonth);
        }
        if (Object.prototype.hasOwnProperty.call(objQxUsers_Cond.dicFldComparisonOp, clsQxUsersEN_js_1.clsQxUsersEN.con_EndYearMonth) == true) {
            const strComparisonOp_EndYearMonth = objQxUsers_Cond.dicFldComparisonOp[clsQxUsersEN_js_1.clsQxUsersEN.con_EndYearMonth];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsQxUsersEN_js_1.clsQxUsersEN.con_EndYearMonth, objQxUsers_Cond.endYearMonth, strComparisonOp_EndYearMonth);
        }
        if (Object.prototype.hasOwnProperty.call(objQxUsers_Cond.dicFldComparisonOp, clsQxUsersEN_js_1.clsQxUsersEN.con_OptUser) == true) {
            const strComparisonOp_OptUser = objQxUsers_Cond.dicFldComparisonOp[clsQxUsersEN_js_1.clsQxUsersEN.con_OptUser];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsQxUsersEN_js_1.clsQxUsersEN.con_OptUser, objQxUsers_Cond.optUser, strComparisonOp_OptUser);
        }
        if (Object.prototype.hasOwnProperty.call(objQxUsers_Cond.dicFldComparisonOp, clsQxUsersEN_js_1.clsQxUsersEN.con_OptDate) == true) {
            const strComparisonOp_OptDate = objQxUsers_Cond.dicFldComparisonOp[clsQxUsersEN_js_1.clsQxUsersEN.con_OptDate];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsQxUsersEN_js_1.clsQxUsersEN.con_OptDate, objQxUsers_Cond.optDate, strComparisonOp_OptDate);
        }
        if (Object.prototype.hasOwnProperty.call(objQxUsers_Cond.dicFldComparisonOp, clsQxUsersEN_js_1.clsQxUsersEN.con_Memo) == true) {
            const strComparisonOp_Memo = objQxUsers_Cond.dicFldComparisonOp[clsQxUsersEN_js_1.clsQxUsersEN.con_Memo];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsQxUsersEN_js_1.clsQxUsersEN.con_Memo, objQxUsers_Cond.memo, strComparisonOp_Memo);
        }
        if (Object.prototype.hasOwnProperty.call(objQxUsers_Cond.dicFldComparisonOp, clsQxUsersEN_js_1.clsQxUsersEN.con_Password) == true) {
            const strComparisonOp_Password = objQxUsers_Cond.dicFldComparisonOp[clsQxUsersEN_js_1.clsQxUsersEN.con_Password];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsQxUsersEN_js_1.clsQxUsersEN.con_Password, objQxUsers_Cond.password, strComparisonOp_Password);
        }
        if (Object.prototype.hasOwnProperty.call(objQxUsers_Cond.dicFldComparisonOp, clsQxUsersEN_js_1.clsQxUsersEN.con_IsGpUser) == true) {
            if (objQxUsers_Cond.isGpUser == true) {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '1'", clsQxUsersEN_js_1.clsQxUsersEN.con_IsGpUser);
            }
            else {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '0'", clsQxUsersEN_js_1.clsQxUsersEN.con_IsGpUser);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objQxUsers_Cond.dicFldComparisonOp, clsQxUsersEN_js_1.clsQxUsersEN.con_SchoolID1) == true) {
            const strComparisonOp_SchoolID1 = objQxUsers_Cond.dicFldComparisonOp[clsQxUsersEN_js_1.clsQxUsersEN.con_SchoolID1];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsQxUsersEN_js_1.clsQxUsersEN.con_SchoolID1, objQxUsers_Cond.schoolID1, strComparisonOp_SchoolID1);
        }
        if (Object.prototype.hasOwnProperty.call(objQxUsers_Cond.dicFldComparisonOp, clsQxUsersEN_js_1.clsQxUsersEN.con_AvatarsPicture) == true) {
            const strComparisonOp_AvatarsPicture = objQxUsers_Cond.dicFldComparisonOp[clsQxUsersEN_js_1.clsQxUsersEN.con_AvatarsPicture];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsQxUsersEN_js_1.clsQxUsersEN.con_AvatarsPicture, objQxUsers_Cond.avatarsPicture, strComparisonOp_AvatarsPicture);
        }
        if (Object.prototype.hasOwnProperty.call(objQxUsers_Cond.dicFldComparisonOp, clsQxUsersEN_js_1.clsQxUsersEN.con_Email) == true) {
            const strComparisonOp_Email = objQxUsers_Cond.dicFldComparisonOp[clsQxUsersEN_js_1.clsQxUsersEN.con_Email];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsQxUsersEN_js_1.clsQxUsersEN.con_Email, objQxUsers_Cond.email, strComparisonOp_Email);
        }
        if (Object.prototype.hasOwnProperty.call(objQxUsers_Cond.dicFldComparisonOp, clsQxUsersEN_js_1.clsQxUsersEN.con_PhoneNumber) == true) {
            const strComparisonOp_PhoneNumber = objQxUsers_Cond.dicFldComparisonOp[clsQxUsersEN_js_1.clsQxUsersEN.con_PhoneNumber];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsQxUsersEN_js_1.clsQxUsersEN.con_PhoneNumber, objQxUsers_Cond.phoneNumber, strComparisonOp_PhoneNumber);
        }
        if (Object.prototype.hasOwnProperty.call(objQxUsers_Cond.dicFldComparisonOp, clsQxUsersEN_js_1.clsQxUsersEN.con_EffectiveDate) == true) {
            const strComparisonOp_EffectiveDate = objQxUsers_Cond.dicFldComparisonOp[clsQxUsersEN_js_1.clsQxUsersEN.con_EffectiveDate];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsQxUsersEN_js_1.clsQxUsersEN.con_EffectiveDate, objQxUsers_Cond.effectiveDate, strComparisonOp_EffectiveDate);
        }
        if (Object.prototype.hasOwnProperty.call(objQxUsers_Cond.dicFldComparisonOp, clsQxUsersEN_js_1.clsQxUsersEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objQxUsers_Cond.dicFldComparisonOp[clsQxUsersEN_js_1.clsQxUsersEN.con_UpdDate];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsQxUsersEN_js_1.clsQxUsersEN.con_UpdDate, objQxUsers_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objQxUsers_Cond.dicFldComparisonOp, clsQxUsersEN_js_1.clsQxUsersEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objQxUsers_Cond.dicFldComparisonOp[clsQxUsersEN_js_1.clsQxUsersEN.con_UpdUser];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsQxUsersEN_js_1.clsQxUsersEN.con_UpdUser, objQxUsers_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objQxUsers_Cond.dicFldComparisonOp, clsQxUsersEN_js_1.clsQxUsersEN.con_EffitiveBeginDate) == true) {
            const strComparisonOp_EffitiveBeginDate = objQxUsers_Cond.dicFldComparisonOp[clsQxUsersEN_js_1.clsQxUsersEN.con_EffitiveBeginDate];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsQxUsersEN_js_1.clsQxUsersEN.con_EffitiveBeginDate, objQxUsers_Cond.effitiveBeginDate, strComparisonOp_EffitiveBeginDate);
        }
        if (Object.prototype.hasOwnProperty.call(objQxUsers_Cond.dicFldComparisonOp, clsQxUsersEN_js_1.clsQxUsersEN.con_EffitiveEndDate) == true) {
            const strComparisonOp_EffitiveEndDate = objQxUsers_Cond.dicFldComparisonOp[clsQxUsersEN_js_1.clsQxUsersEN.con_EffitiveEndDate];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsQxUsersEN_js_1.clsQxUsersEN.con_EffitiveEndDate, objQxUsers_Cond.effitiveEndDate, strComparisonOp_EffitiveEndDate);
        }
        if (Object.prototype.hasOwnProperty.call(objQxUsers_Cond.dicFldComparisonOp, clsQxUsersEN_js_1.clsQxUsersEN.con_id_College) == true) {
            const strComparisonOp_id_College = objQxUsers_Cond.dicFldComparisonOp[clsQxUsersEN_js_1.clsQxUsersEN.con_id_College];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsQxUsersEN_js_1.clsQxUsersEN.con_id_College, objQxUsers_Cond.id_College, strComparisonOp_id_College);
        }
        if (Object.prototype.hasOwnProperty.call(objQxUsers_Cond.dicFldComparisonOp, clsQxUsersEN_js_1.clsQxUsersEN.con_StuTeacherID) == true) {
            const strComparisonOp_StuTeacherID = objQxUsers_Cond.dicFldComparisonOp[clsQxUsersEN_js_1.clsQxUsersEN.con_StuTeacherID];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsQxUsersEN_js_1.clsQxUsersEN.con_StuTeacherID, objQxUsers_Cond.stuTeacherID, strComparisonOp_StuTeacherID);
        }
        if (Object.prototype.hasOwnProperty.call(objQxUsers_Cond.dicFldComparisonOp, clsQxUsersEN_js_1.clsQxUsersEN.con_IdentityID) == true) {
            const strComparisonOp_IdentityID = objQxUsers_Cond.dicFldComparisonOp[clsQxUsersEN_js_1.clsQxUsersEN.con_IdentityID];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsQxUsersEN_js_1.clsQxUsersEN.con_IdentityID, objQxUsers_Cond.identityID, strComparisonOp_IdentityID);
        }
        if (Object.prototype.hasOwnProperty.call(objQxUsers_Cond.dicFldComparisonOp, clsQxUsersEN_js_1.clsQxUsersEN.con_IsArchive) == true) {
            if (objQxUsers_Cond.isArchive == true) {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '1'", clsQxUsersEN_js_1.clsQxUsersEN.con_IsArchive);
            }
            else {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '0'", clsQxUsersEN_js_1.clsQxUsersEN.con_IsArchive);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objQxUsers_Cond.dicFldComparisonOp, clsQxUsersEN_js_1.clsQxUsersEN.con_HeadimgUrl) == true) {
            const strComparisonOp_HeadimgUrl = objQxUsers_Cond.dicFldComparisonOp[clsQxUsersEN_js_1.clsQxUsersEN.con_HeadimgUrl];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsQxUsersEN_js_1.clsQxUsersEN.con_HeadimgUrl, objQxUsers_Cond.headimgUrl, strComparisonOp_HeadimgUrl);
        }
        if (Object.prototype.hasOwnProperty.call(objQxUsers_Cond.dicFldComparisonOp, clsQxUsersEN_js_1.clsQxUsersEN.con_OpenId) == true) {
            const strComparisonOp_OpenId = objQxUsers_Cond.dicFldComparisonOp[clsQxUsersEN_js_1.clsQxUsersEN.con_OpenId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsQxUsersEN_js_1.clsQxUsersEN.con_OpenId, objQxUsers_Cond.openId, strComparisonOp_OpenId);
        }
        if (Object.prototype.hasOwnProperty.call(objQxUsers_Cond.dicFldComparisonOp, clsQxUsersEN_js_1.clsQxUsersEN.con_NickName) == true) {
            const strComparisonOp_NickName = objQxUsers_Cond.dicFldComparisonOp[clsQxUsersEN_js_1.clsQxUsersEN.con_NickName];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsQxUsersEN_js_1.clsQxUsersEN.con_NickName, objQxUsers_Cond.nickName, strComparisonOp_NickName);
        }
        if (Object.prototype.hasOwnProperty.call(objQxUsers_Cond.dicFldComparisonOp, clsQxUsersEN_js_1.clsQxUsersEN.con_IsSynch) == true) {
            if (objQxUsers_Cond.isSynch == true) {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '1'", clsQxUsersEN_js_1.clsQxUsersEN.con_IsSynch);
            }
            else {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '0'", clsQxUsersEN_js_1.clsQxUsersEN.con_IsSynch);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objQxUsers_Cond.dicFldComparisonOp, clsQxUsersEN_js_1.clsQxUsersEN.con_SynchDate) == true) {
            const strComparisonOp_SynchDate = objQxUsers_Cond.dicFldComparisonOp[clsQxUsersEN_js_1.clsQxUsersEN.con_SynchDate];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsQxUsersEN_js_1.clsQxUsersEN.con_SynchDate, objQxUsers_Cond.synchDate, strComparisonOp_SynchDate);
        }
        return strWhereCond;
    }
    exports.QxUsers_GetCombineCondition = QxUsers_GetCombineCondition;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objQxUsersENS:源对象
     * @param objQxUsersENT:目标对象
    */
    function QxUsers_CopyObjTo(objQxUsersENS, objQxUsersENT) {
        objQxUsersENT.userId = objQxUsersENS.userId; //用户ID
        objQxUsersENT.userName = objQxUsersENS.userName; //用户名
        objQxUsersENT.departmentId = objQxUsersENS.departmentId; //部门Id
        objQxUsersENT.id_XzCollege = objQxUsersENS.id_XzCollege; //学院流水号
        objQxUsersENT.userStateId = objQxUsersENS.userStateId; //用户状态Id
        objQxUsersENT.id_GradeBase = objQxUsersENS.id_GradeBase; //年级流水号
        objQxUsersENT.card_State = objQxUsersENS.card_State; //Card_State
        objQxUsersENT.isLeaved = objQxUsersENS.isLeaved; //IsLeaved
        objQxUsersENT.cardNo = objQxUsersENS.cardNo; //卡号
        objQxUsersENT.beginYearMonth = objQxUsersENS.beginYearMonth; //开始年月
        objQxUsersENT.endYearMonth = objQxUsersENS.endYearMonth; //结束年月
        objQxUsersENT.optUser = objQxUsersENS.optUser; //OptUser
        objQxUsersENT.optDate = objQxUsersENS.optDate; //OptDate
        objQxUsersENT.memo = objQxUsersENS.memo; //备注
        objQxUsersENT.password = objQxUsersENS.password; //Password
        objQxUsersENT.isGpUser = objQxUsersENS.isGpUser; //是否Gp用户
        objQxUsersENT.schoolID1 = objQxUsersENS.schoolID1; //学校编号
        objQxUsersENT.avatarsPicture = objQxUsersENS.avatarsPicture; //AvatarsPicture
        objQxUsersENT.email = objQxUsersENS.email; //电子邮箱
        objQxUsersENT.phoneNumber = objQxUsersENS.phoneNumber; //PhoneNumber
        objQxUsersENT.effectiveDate = objQxUsersENS.effectiveDate; //EffectiveDate
        objQxUsersENT.updDate = objQxUsersENS.updDate; //修改日期
        objQxUsersENT.updUser = objQxUsersENS.updUser; //修改人
        objQxUsersENT.effitiveBeginDate = objQxUsersENS.effitiveBeginDate; //EffitiveBeginDate
        objQxUsersENT.effitiveEndDate = objQxUsersENS.effitiveEndDate; //EffitiveEndDate
        objQxUsersENT.id_College = objQxUsersENS.id_College; //学院流水号
        objQxUsersENT.stuTeacherID = objQxUsersENS.stuTeacherID; //学工号
        objQxUsersENT.identityID = objQxUsersENS.identityID; //身份编号
        objQxUsersENT.isArchive = objQxUsersENS.isArchive; //IsArchive
        objQxUsersENT.headimgUrl = objQxUsersENS.headimgUrl; //微信头像
        objQxUsersENT.openId = objQxUsersENS.openId; //微信OpenId
        objQxUsersENT.nickName = objQxUsersENS.nickName; //昵称
        objQxUsersENT.isSynch = objQxUsersENS.isSynch; //是否同步
        objQxUsersENT.synchDate = objQxUsersENS.synchDate; //同步日期
        objQxUsersENT.sf_UpdFldSetStr = objQxUsersENS.updFldString; //sf_UpdFldSetStr
    }
    exports.QxUsers_CopyObjTo = QxUsers_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objQxUsersENS:源对象
     * @param objQxUsersENT:目标对象
    */
    function QxUsers_GetObjFromJsonObj(objQxUsersENS) {
        const objQxUsersENT = new clsQxUsersEN_js_1.clsQxUsersEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objQxUsersENT, objQxUsersENS);
        return objQxUsersENT;
    }
    exports.QxUsers_GetObjFromJsonObj = QxUsers_GetObjFromJsonObj;
});
