/**
* 类名:clsvQxUsersWApi
* 表名:vQxUsers(01120564)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/13 00:45:30
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
        define(["require", "exports", "axios", "../../PubFun/enumComparisonOp.js", "../../PubFun/CacheHelper.js", "../../L0_Entity/BaseInfo/clsvQxUsersEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.vQxUsers_GetObjFromJsonObj = exports.vQxUsers_CopyObjTo = exports.vQxUsers_GetCombineCondition = exports.vQxUsers_GetObjByJSONStr = exports.vQxUsers_GetObjLstByJSONObjLst = exports.vQxUsers_GetObjLstByJSONStr = exports.vQxUsers_GetJSONStrByObj = exports.vQxUsers_ReFreshThisCache = exports.vQxUsers_GetWebApiUrl = exports.vQxUsers_GetRecCountByCond_Cache = exports.vQxUsers_GetRecCountByCondAsync = exports.vQxUsers_IsExistAsync = exports.vQxUsers_IsExist_Cache = exports.vQxUsers_IsExist = exports.vQxUsers_IsExistRecordAsync = exports.vQxUsers_IsExistRecord_Cache = exports.vQxUsers_GetObjLstByPagerAsync = exports.vQxUsers_GetObjLstByPager_Cache = exports.vQxUsers_GetObjLstByRange = exports.vQxUsers_GetObjLstByRangeAsync = exports.vQxUsers_GetTopObjLstAsync = exports.vQxUsers_GetObjLstByUserIdLst_Cache = exports.vQxUsers_GetObjLstByUserIdLstAsync = exports.vQxUsers_GetSubObjLst_Cache = exports.vQxUsers_GetObjLst_PureCache = exports.vQxUsers_GetObjLst_Cache = exports.vQxUsers_GetObjLst_sessionStorage_PureCache = exports.vQxUsers_GetObjLst_sessionStorage = exports.vQxUsers_GetObjLstAsync = exports.vQxUsers_GetObjLst_localStorage_PureCache = exports.vQxUsers_GetObjLst_localStorage = exports.vQxUsers_GetObjLst_ClientCache = exports.vQxUsers_GetFirstObjAsync = exports.vQxUsers_GetFirstID = exports.vQxUsers_GetFirstIDAsync = exports.vQxUsers_funcKey = exports.vQxUsers_FilterFunByKey = exports.vQxUsers_SortFunByKey = exports.vQxUsers_SortFun_Defa_2Fld = exports.vQxUsers_SortFun_Defa = exports.vQxUsers_func = exports.vQxUsers_GetObjByUserId_localStorage = exports.vQxUsers_GetObjByUserId_Cache = exports.vQxUsers_GetObjByUserIdAsync = exports.vQxUsers_ConstructorName = exports.vQxUsers_Controller = void 0;
    /**
     * vQx用户(vQxUsers)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月13日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const enumComparisonOp_js_1 = require("../../PubFun/enumComparisonOp.js");
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsvQxUsersEN_js_1 = require("../../L0_Entity/BaseInfo/clsvQxUsersEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.vQxUsers_Controller = "vQxUsersApi";
    exports.vQxUsers_ConstructorName = "vQxUsers";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strUserId:关键字
    * @returns 对象
    **/
    async function vQxUsers_GetObjByUserIdAsync(strUserId) {
        const strThisFuncName = "GetObjByUserIdAsync";
        if ((0, clsString_js_1.IsNullOrEmpty)(strUserId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strUserId]不能为空！(In clsvQxUsersWApi.GetObjByUserIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByUserId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vQxUsers_Controller, strAction);
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
                const objvQxUsers = vQxUsers_GetObjFromJsonObj(returnObj);
                return objvQxUsers;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vQxUsers_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vQxUsers_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vQxUsers_GetObjByUserIdAsync = vQxUsers_GetObjByUserIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param strUserId:所给的关键字
     * @returns 对象
    */
    async function vQxUsers_GetObjByUserId_Cache(strUserId, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByUserId_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strUserId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strUserId]不能为空！(In clsvQxUsersWApi.GetObjByUserId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        const arrvQxUsersObjLst_Cache = await vQxUsers_GetObjLst_Cache();
        try {
            const arrvQxUsers_Sel = arrvQxUsersObjLst_Cache.filter(x => x.userId == strUserId);
            let objvQxUsers;
            if (arrvQxUsers_Sel.length > 0) {
                objvQxUsers = arrvQxUsers_Sel[0];
                return objvQxUsers;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    const objvQxUsers_Const = await vQxUsers_GetObjByUserIdAsync(strUserId);
                    if (objvQxUsers_Const != null) {
                        vQxUsers_ReFreshThisCache();
                        return objvQxUsers_Const;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strUserId, exports.vQxUsers_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.vQxUsers_GetObjByUserId_Cache = vQxUsers_GetObjByUserId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param strUserId:所给的关键字
     * @returns 对象
    */
    async function vQxUsers_GetObjByUserId_localStorage(strUserId) {
        const strThisFuncName = "GetObjByUserId_localStorage";
        if ((0, clsString_js_1.IsNullOrEmpty)(strUserId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strUserId]不能为空！(In clsvQxUsersWApi.GetObjByUserId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvQxUsersEN_js_1.clsvQxUsersEN._CurrTabName, strUserId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objvQxUsers_Cache = JSON.parse(strTempObj);
            return objvQxUsers_Cache;
        }
        try {
            const objvQxUsers = await vQxUsers_GetObjByUserIdAsync(strUserId);
            if (objvQxUsers != null) {
                localStorage.setItem(strKey, JSON.stringify(objvQxUsers));
                const strInfo = (0, clsString_js_1.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objvQxUsers;
            }
            return objvQxUsers;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strUserId, exports.vQxUsers_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.vQxUsers_GetObjByUserId_localStorage = vQxUsers_GetObjByUserId_localStorage;
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
    async function vQxUsers_func(strInFldName, strOutFldName, strInValue) {
        //const strThisFuncName = "func";
        if (strInFldName != clsvQxUsersEN_js_1.clsvQxUsersEN.con_UserId) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsvQxUsersEN_js_1.clsvQxUsersEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_1.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strOutFldName, clsvQxUsersEN_js_1.clsvQxUsersEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUserId = strInValue;
        if ((0, clsString_js_1.IsNullOrEmpty)(strInValue) == true) {
            return "";
        }
        const objvQxUsers = await vQxUsers_GetObjByUserId_Cache(strUserId);
        if (objvQxUsers == null)
            return "";
        if (objvQxUsers.GetFldValue(strOutFldName) == null)
            return "";
        return objvQxUsers.GetFldValue(strOutFldName).toString();
    }
    exports.vQxUsers_func = vQxUsers_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vQxUsers_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.userId.localeCompare(b.userId);
    }
    exports.vQxUsers_SortFun_Defa = vQxUsers_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vQxUsers_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.userName == b.userName)
            return a.userStateId.localeCompare(b.userStateId);
        else
            return a.userName.localeCompare(b.userName);
    }
    exports.vQxUsers_SortFun_Defa_2Fld = vQxUsers_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vQxUsers_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsvQxUsersEN_js_1.clsvQxUsersEN.con_UserId:
                    return (a, b) => {
                        return a.userId.localeCompare(b.userId);
                    };
                case clsvQxUsersEN_js_1.clsvQxUsersEN.con_UserName:
                    return (a, b) => {
                        return a.userName.localeCompare(b.userName);
                    };
                case clsvQxUsersEN_js_1.clsvQxUsersEN.con_UserStateId:
                    return (a, b) => {
                        return a.userStateId.localeCompare(b.userStateId);
                    };
                case clsvQxUsersEN_js_1.clsvQxUsersEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                case clsvQxUsersEN_js_1.clsvQxUsersEN.con_UserStateName:
                    return (a, b) => {
                        if (a.userStateName == null)
                            return -1;
                        if (b.userStateName == null)
                            return 1;
                        return a.userStateName.localeCompare(b.userStateName);
                    };
                case clsvQxUsersEN_js_1.clsvQxUsersEN.con_DepartmentId:
                    return (a, b) => {
                        if (a.departmentId == null)
                            return -1;
                        if (b.departmentId == null)
                            return 1;
                        return a.departmentId.localeCompare(b.departmentId);
                    };
                case clsvQxUsersEN_js_1.clsvQxUsersEN.con_UpDepartmentId:
                    return (a, b) => {
                        if (a.upDepartmentId == null)
                            return -1;
                        if (b.upDepartmentId == null)
                            return 1;
                        return a.upDepartmentId.localeCompare(b.upDepartmentId);
                    };
                case clsvQxUsersEN_js_1.clsvQxUsersEN.con_DepartmentName:
                    return (a, b) => {
                        if (a.departmentName == null)
                            return -1;
                        if (b.departmentName == null)
                            return 1;
                        return a.departmentName.localeCompare(b.departmentName);
                    };
                case clsvQxUsersEN_js_1.clsvQxUsersEN.con_UpDepartmentName:
                    return (a, b) => {
                        if (a.upDepartmentName == null)
                            return -1;
                        if (b.upDepartmentName == null)
                            return 1;
                        return a.upDepartmentName.localeCompare(b.upDepartmentName);
                    };
                case clsvQxUsersEN_js_1.clsvQxUsersEN.con_DepartmentTypeName:
                    return (a, b) => {
                        if (a.departmentTypeName == null)
                            return -1;
                        if (b.departmentTypeName == null)
                            return 1;
                        return a.departmentTypeName.localeCompare(b.departmentTypeName);
                    };
                case clsvQxUsersEN_js_1.clsvQxUsersEN.con_DepartmentTypeId:
                    return (a, b) => {
                        if (a.departmentTypeId == null)
                            return -1;
                        if (b.departmentTypeId == null)
                            return 1;
                        return a.departmentTypeId.localeCompare(b.departmentTypeId);
                    };
                case clsvQxUsersEN_js_1.clsvQxUsersEN.con_DepartmentAbbrName:
                    return (a, b) => {
                        if (a.departmentAbbrName == null)
                            return -1;
                        if (b.departmentAbbrName == null)
                            return 1;
                        return a.departmentAbbrName.localeCompare(b.departmentAbbrName);
                    };
                case clsvQxUsersEN_js_1.clsvQxUsersEN.con_EffectiveDate:
                    return (a, b) => {
                        if (a.effectiveDate == null)
                            return -1;
                        if (b.effectiveDate == null)
                            return 1;
                        return a.effectiveDate.localeCompare(b.effectiveDate);
                    };
                case clsvQxUsersEN_js_1.clsvQxUsersEN.con_UpdDate:
                    return (a, b) => {
                        if (a.updDate == null)
                            return -1;
                        if (b.updDate == null)
                            return 1;
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsvQxUsersEN_js_1.clsvQxUsersEN.con_UpdUser:
                    return (a, b) => {
                        if (a.updUser == null)
                            return -1;
                        if (b.updUser == null)
                            return 1;
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsvQxUsersEN_js_1.clsvQxUsersEN.con_EffitiveBeginDate:
                    return (a, b) => {
                        return a.effitiveBeginDate.localeCompare(b.effitiveBeginDate);
                    };
                case clsvQxUsersEN_js_1.clsvQxUsersEN.con_EffitiveEndDate:
                    return (a, b) => {
                        return a.effitiveEndDate.localeCompare(b.effitiveEndDate);
                    };
                case clsvQxUsersEN_js_1.clsvQxUsersEN.con_StuTeacherID:
                    return (a, b) => {
                        return a.stuTeacherID.localeCompare(b.stuTeacherID);
                    };
                case clsvQxUsersEN_js_1.clsvQxUsersEN.con_IdentityID:
                    return (a, b) => {
                        if (a.identityID == null)
                            return -1;
                        if (b.identityID == null)
                            return 1;
                        return a.identityID.localeCompare(b.identityID);
                    };
                case clsvQxUsersEN_js_1.clsvQxUsersEN.con_Password:
                    return (a, b) => {
                        if (a.password == null)
                            return -1;
                        if (b.password == null)
                            return 1;
                        return a.password.localeCompare(b.password);
                    };
                case clsvQxUsersEN_js_1.clsvQxUsersEN.con_IdentityDesc:
                    return (a, b) => {
                        if (a.identityDesc == null)
                            return -1;
                        if (b.identityDesc == null)
                            return 1;
                        return a.identityDesc.localeCompare(b.identityDesc);
                    };
                case clsvQxUsersEN_js_1.clsvQxUsersEN.con_IsSynch:
                    return (a, b) => {
                        if (a.isSynch == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvQxUsersEN_js_1.clsvQxUsersEN.con_SynchDate:
                    return (a, b) => {
                        if (a.synchDate == null)
                            return -1;
                        if (b.synchDate == null)
                            return 1;
                        return a.synchDate.localeCompare(b.synchDate);
                    };
                case clsvQxUsersEN_js_1.clsvQxUsersEN.con_OpenId:
                    return (a, b) => {
                        if (a.openId == null)
                            return -1;
                        if (b.openId == null)
                            return 1;
                        return a.openId.localeCompare(b.openId);
                    };
                case clsvQxUsersEN_js_1.clsvQxUsersEN.con_NickName:
                    return (a, b) => {
                        if (a.nickName == null)
                            return -1;
                        if (b.nickName == null)
                            return 1;
                        return a.nickName.localeCompare(b.nickName);
                    };
                case clsvQxUsersEN_js_1.clsvQxUsersEN.con_HeadimgUrl:
                    return (a, b) => {
                        if (a.headimgUrl == null)
                            return -1;
                        if (b.headimgUrl == null)
                            return 1;
                        return a.headimgUrl.localeCompare(b.headimgUrl);
                    };
                case clsvQxUsersEN_js_1.clsvQxUsersEN.con_CollegeName:
                    return (a, b) => {
                        if (a.collegeName == null)
                            return -1;
                        if (b.collegeName == null)
                            return 1;
                        return a.collegeName.localeCompare(b.collegeName);
                    };
                case clsvQxUsersEN_js_1.clsvQxUsersEN.con_id_XzCollege:
                    return (a, b) => {
                        if (a.id_XzCollege == null)
                            return -1;
                        if (b.id_XzCollege == null)
                            return 1;
                        return a.id_XzCollege.localeCompare(b.id_XzCollege);
                    };
                case clsvQxUsersEN_js_1.clsvQxUsersEN.con_id_XzMajor:
                    return (a, b) => {
                        if (a.id_XzMajor == null)
                            return -1;
                        if (b.id_XzMajor == null)
                            return 1;
                        return a.id_XzMajor.localeCompare(b.id_XzMajor);
                    };
                case clsvQxUsersEN_js_1.clsvQxUsersEN.con_MajorName:
                    return (a, b) => {
                        if (a.majorName == null)
                            return -1;
                        if (b.majorName == null)
                            return 1;
                        return a.majorName.localeCompare(b.majorName);
                    };
                case clsvQxUsersEN_js_1.clsvQxUsersEN.con_Email:
                    return (a, b) => {
                        if (a.email == null)
                            return -1;
                        if (b.email == null)
                            return 1;
                        return a.email.localeCompare(b.email);
                    };
                case clsvQxUsersEN_js_1.clsvQxUsersEN.con_id_College:
                    return (a, b) => {
                        return a.id_College.localeCompare(b.id_College);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vQxUsers]中不存在！(in ${exports.vQxUsers_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsvQxUsersEN_js_1.clsvQxUsersEN.con_UserId:
                    return (a, b) => {
                        return b.userId.localeCompare(a.userId);
                    };
                case clsvQxUsersEN_js_1.clsvQxUsersEN.con_UserName:
                    return (a, b) => {
                        return b.userName.localeCompare(a.userName);
                    };
                case clsvQxUsersEN_js_1.clsvQxUsersEN.con_UserStateId:
                    return (a, b) => {
                        return b.userStateId.localeCompare(a.userStateId);
                    };
                case clsvQxUsersEN_js_1.clsvQxUsersEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                case clsvQxUsersEN_js_1.clsvQxUsersEN.con_UserStateName:
                    return (a, b) => {
                        if (b.userStateName == null)
                            return -1;
                        if (a.userStateName == null)
                            return 1;
                        return b.userStateName.localeCompare(a.userStateName);
                    };
                case clsvQxUsersEN_js_1.clsvQxUsersEN.con_DepartmentId:
                    return (a, b) => {
                        if (b.departmentId == null)
                            return -1;
                        if (a.departmentId == null)
                            return 1;
                        return b.departmentId.localeCompare(a.departmentId);
                    };
                case clsvQxUsersEN_js_1.clsvQxUsersEN.con_UpDepartmentId:
                    return (a, b) => {
                        if (b.upDepartmentId == null)
                            return -1;
                        if (a.upDepartmentId == null)
                            return 1;
                        return b.upDepartmentId.localeCompare(a.upDepartmentId);
                    };
                case clsvQxUsersEN_js_1.clsvQxUsersEN.con_DepartmentName:
                    return (a, b) => {
                        if (b.departmentName == null)
                            return -1;
                        if (a.departmentName == null)
                            return 1;
                        return b.departmentName.localeCompare(a.departmentName);
                    };
                case clsvQxUsersEN_js_1.clsvQxUsersEN.con_UpDepartmentName:
                    return (a, b) => {
                        if (b.upDepartmentName == null)
                            return -1;
                        if (a.upDepartmentName == null)
                            return 1;
                        return b.upDepartmentName.localeCompare(a.upDepartmentName);
                    };
                case clsvQxUsersEN_js_1.clsvQxUsersEN.con_DepartmentTypeName:
                    return (a, b) => {
                        if (b.departmentTypeName == null)
                            return -1;
                        if (a.departmentTypeName == null)
                            return 1;
                        return b.departmentTypeName.localeCompare(a.departmentTypeName);
                    };
                case clsvQxUsersEN_js_1.clsvQxUsersEN.con_DepartmentTypeId:
                    return (a, b) => {
                        if (b.departmentTypeId == null)
                            return -1;
                        if (a.departmentTypeId == null)
                            return 1;
                        return b.departmentTypeId.localeCompare(a.departmentTypeId);
                    };
                case clsvQxUsersEN_js_1.clsvQxUsersEN.con_DepartmentAbbrName:
                    return (a, b) => {
                        if (b.departmentAbbrName == null)
                            return -1;
                        if (a.departmentAbbrName == null)
                            return 1;
                        return b.departmentAbbrName.localeCompare(a.departmentAbbrName);
                    };
                case clsvQxUsersEN_js_1.clsvQxUsersEN.con_EffectiveDate:
                    return (a, b) => {
                        if (b.effectiveDate == null)
                            return -1;
                        if (a.effectiveDate == null)
                            return 1;
                        return b.effectiveDate.localeCompare(a.effectiveDate);
                    };
                case clsvQxUsersEN_js_1.clsvQxUsersEN.con_UpdDate:
                    return (a, b) => {
                        if (b.updDate == null)
                            return -1;
                        if (a.updDate == null)
                            return 1;
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsvQxUsersEN_js_1.clsvQxUsersEN.con_UpdUser:
                    return (a, b) => {
                        if (b.updUser == null)
                            return -1;
                        if (a.updUser == null)
                            return 1;
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsvQxUsersEN_js_1.clsvQxUsersEN.con_EffitiveBeginDate:
                    return (a, b) => {
                        return b.effitiveBeginDate.localeCompare(a.effitiveBeginDate);
                    };
                case clsvQxUsersEN_js_1.clsvQxUsersEN.con_EffitiveEndDate:
                    return (a, b) => {
                        return b.effitiveEndDate.localeCompare(a.effitiveEndDate);
                    };
                case clsvQxUsersEN_js_1.clsvQxUsersEN.con_StuTeacherID:
                    return (a, b) => {
                        return b.stuTeacherID.localeCompare(a.stuTeacherID);
                    };
                case clsvQxUsersEN_js_1.clsvQxUsersEN.con_IdentityID:
                    return (a, b) => {
                        if (b.identityID == null)
                            return -1;
                        if (a.identityID == null)
                            return 1;
                        return b.identityID.localeCompare(a.identityID);
                    };
                case clsvQxUsersEN_js_1.clsvQxUsersEN.con_Password:
                    return (a, b) => {
                        if (b.password == null)
                            return -1;
                        if (a.password == null)
                            return 1;
                        return b.password.localeCompare(a.password);
                    };
                case clsvQxUsersEN_js_1.clsvQxUsersEN.con_IdentityDesc:
                    return (a, b) => {
                        if (b.identityDesc == null)
                            return -1;
                        if (a.identityDesc == null)
                            return 1;
                        return b.identityDesc.localeCompare(a.identityDesc);
                    };
                case clsvQxUsersEN_js_1.clsvQxUsersEN.con_IsSynch:
                    return (a, b) => {
                        if (b.isSynch == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvQxUsersEN_js_1.clsvQxUsersEN.con_SynchDate:
                    return (a, b) => {
                        if (b.synchDate == null)
                            return -1;
                        if (a.synchDate == null)
                            return 1;
                        return b.synchDate.localeCompare(a.synchDate);
                    };
                case clsvQxUsersEN_js_1.clsvQxUsersEN.con_OpenId:
                    return (a, b) => {
                        if (b.openId == null)
                            return -1;
                        if (a.openId == null)
                            return 1;
                        return b.openId.localeCompare(a.openId);
                    };
                case clsvQxUsersEN_js_1.clsvQxUsersEN.con_NickName:
                    return (a, b) => {
                        if (b.nickName == null)
                            return -1;
                        if (a.nickName == null)
                            return 1;
                        return b.nickName.localeCompare(a.nickName);
                    };
                case clsvQxUsersEN_js_1.clsvQxUsersEN.con_HeadimgUrl:
                    return (a, b) => {
                        if (b.headimgUrl == null)
                            return -1;
                        if (a.headimgUrl == null)
                            return 1;
                        return b.headimgUrl.localeCompare(a.headimgUrl);
                    };
                case clsvQxUsersEN_js_1.clsvQxUsersEN.con_CollegeName:
                    return (a, b) => {
                        if (b.collegeName == null)
                            return -1;
                        if (a.collegeName == null)
                            return 1;
                        return b.collegeName.localeCompare(a.collegeName);
                    };
                case clsvQxUsersEN_js_1.clsvQxUsersEN.con_id_XzCollege:
                    return (a, b) => {
                        if (b.id_XzCollege == null)
                            return -1;
                        if (a.id_XzCollege == null)
                            return 1;
                        return b.id_XzCollege.localeCompare(a.id_XzCollege);
                    };
                case clsvQxUsersEN_js_1.clsvQxUsersEN.con_id_XzMajor:
                    return (a, b) => {
                        if (b.id_XzMajor == null)
                            return -1;
                        if (a.id_XzMajor == null)
                            return 1;
                        return b.id_XzMajor.localeCompare(a.id_XzMajor);
                    };
                case clsvQxUsersEN_js_1.clsvQxUsersEN.con_MajorName:
                    return (a, b) => {
                        if (b.majorName == null)
                            return -1;
                        if (a.majorName == null)
                            return 1;
                        return b.majorName.localeCompare(a.majorName);
                    };
                case clsvQxUsersEN_js_1.clsvQxUsersEN.con_Email:
                    return (a, b) => {
                        if (b.email == null)
                            return -1;
                        if (a.email == null)
                            return 1;
                        return b.email.localeCompare(a.email);
                    };
                case clsvQxUsersEN_js_1.clsvQxUsersEN.con_id_College:
                    return (a, b) => {
                        return b.id_College.localeCompare(a.id_College);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vQxUsers]中不存在！(in ${exports.vQxUsers_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.vQxUsers_SortFunByKey = vQxUsers_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function vQxUsers_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsvQxUsersEN_js_1.clsvQxUsersEN.con_UserId:
                return (obj) => {
                    return obj.userId === value;
                };
            case clsvQxUsersEN_js_1.clsvQxUsersEN.con_UserName:
                return (obj) => {
                    return obj.userName === value;
                };
            case clsvQxUsersEN_js_1.clsvQxUsersEN.con_UserStateId:
                return (obj) => {
                    return obj.userStateId === value;
                };
            case clsvQxUsersEN_js_1.clsvQxUsersEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            case clsvQxUsersEN_js_1.clsvQxUsersEN.con_UserStateName:
                return (obj) => {
                    return obj.userStateName === value;
                };
            case clsvQxUsersEN_js_1.clsvQxUsersEN.con_DepartmentId:
                return (obj) => {
                    return obj.departmentId === value;
                };
            case clsvQxUsersEN_js_1.clsvQxUsersEN.con_UpDepartmentId:
                return (obj) => {
                    return obj.upDepartmentId === value;
                };
            case clsvQxUsersEN_js_1.clsvQxUsersEN.con_DepartmentName:
                return (obj) => {
                    return obj.departmentName === value;
                };
            case clsvQxUsersEN_js_1.clsvQxUsersEN.con_UpDepartmentName:
                return (obj) => {
                    return obj.upDepartmentName === value;
                };
            case clsvQxUsersEN_js_1.clsvQxUsersEN.con_DepartmentTypeName:
                return (obj) => {
                    return obj.departmentTypeName === value;
                };
            case clsvQxUsersEN_js_1.clsvQxUsersEN.con_DepartmentTypeId:
                return (obj) => {
                    return obj.departmentTypeId === value;
                };
            case clsvQxUsersEN_js_1.clsvQxUsersEN.con_DepartmentAbbrName:
                return (obj) => {
                    return obj.departmentAbbrName === value;
                };
            case clsvQxUsersEN_js_1.clsvQxUsersEN.con_EffectiveDate:
                return (obj) => {
                    return obj.effectiveDate === value;
                };
            case clsvQxUsersEN_js_1.clsvQxUsersEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsvQxUsersEN_js_1.clsvQxUsersEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsvQxUsersEN_js_1.clsvQxUsersEN.con_EffitiveBeginDate:
                return (obj) => {
                    return obj.effitiveBeginDate === value;
                };
            case clsvQxUsersEN_js_1.clsvQxUsersEN.con_EffitiveEndDate:
                return (obj) => {
                    return obj.effitiveEndDate === value;
                };
            case clsvQxUsersEN_js_1.clsvQxUsersEN.con_StuTeacherID:
                return (obj) => {
                    return obj.stuTeacherID === value;
                };
            case clsvQxUsersEN_js_1.clsvQxUsersEN.con_IdentityID:
                return (obj) => {
                    return obj.identityID === value;
                };
            case clsvQxUsersEN_js_1.clsvQxUsersEN.con_Password:
                return (obj) => {
                    return obj.password === value;
                };
            case clsvQxUsersEN_js_1.clsvQxUsersEN.con_IdentityDesc:
                return (obj) => {
                    return obj.identityDesc === value;
                };
            case clsvQxUsersEN_js_1.clsvQxUsersEN.con_IsSynch:
                return (obj) => {
                    return obj.isSynch === value;
                };
            case clsvQxUsersEN_js_1.clsvQxUsersEN.con_SynchDate:
                return (obj) => {
                    return obj.synchDate === value;
                };
            case clsvQxUsersEN_js_1.clsvQxUsersEN.con_OpenId:
                return (obj) => {
                    return obj.openId === value;
                };
            case clsvQxUsersEN_js_1.clsvQxUsersEN.con_NickName:
                return (obj) => {
                    return obj.nickName === value;
                };
            case clsvQxUsersEN_js_1.clsvQxUsersEN.con_HeadimgUrl:
                return (obj) => {
                    return obj.headimgUrl === value;
                };
            case clsvQxUsersEN_js_1.clsvQxUsersEN.con_CollegeName:
                return (obj) => {
                    return obj.collegeName === value;
                };
            case clsvQxUsersEN_js_1.clsvQxUsersEN.con_id_XzCollege:
                return (obj) => {
                    return obj.id_XzCollege === value;
                };
            case clsvQxUsersEN_js_1.clsvQxUsersEN.con_id_XzMajor:
                return (obj) => {
                    return obj.id_XzMajor === value;
                };
            case clsvQxUsersEN_js_1.clsvQxUsersEN.con_MajorName:
                return (obj) => {
                    return obj.majorName === value;
                };
            case clsvQxUsersEN_js_1.clsvQxUsersEN.con_Email:
                return (obj) => {
                    return obj.email === value;
                };
            case clsvQxUsersEN_js_1.clsvQxUsersEN.con_id_College:
                return (obj) => {
                    return obj.id_College === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[vQxUsers]中不存在！(in ${exports.vQxUsers_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.vQxUsers_FilterFunByKey = vQxUsers_FilterFunByKey;
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
    async function vQxUsers_funcKey(strInFldName, strInValue, strComparisonOp) {
        //const strThisFuncName = "funcKey";
        if (strInFldName == clsvQxUsersEN_js_1.clsvQxUsersEN.con_UserId) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(strInValue) == true) {
            return [];
        }
        const arrvQxUsers = await vQxUsers_GetObjLst_Cache();
        if (arrvQxUsers == null)
            return [];
        let arrvQxUsers_Sel = arrvQxUsers;
        const strType = typeof (strInValue);
        switch (strType) {
            case "string":
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01: // " = "
                        arrvQxUsers_Sel = arrvQxUsers_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.Like_03:
                        arrvQxUsers_Sel = arrvQxUsers_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.In_04:
                        const arrValues = strInValue.split(',');
                        arrvQxUsers_Sel = arrvQxUsers_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
                        break;
                }
                break;
            case "boolean":
                if (strInValue == null)
                    return [];
                if (strComparisonOp == enumComparisonOp_js_1.enumComparisonOp.Equal_01) {
                    arrvQxUsers_Sel = arrvQxUsers_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                }
                break;
            case "number":
                if (Number(strInValue) == 0)
                    return [];
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01:
                        arrvQxUsers_Sel = arrvQxUsers_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotEqual_02:
                        arrvQxUsers_Sel = arrvQxUsers_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotLessThan_05: //" >= ":
                        arrvQxUsers_Sel = arrvQxUsers_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotGreaterThan_06: //" <= ":
                        arrvQxUsers_Sel = arrvQxUsers_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.GreaterThan_07: //" > ":
                        arrvQxUsers_Sel = arrvQxUsers_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.LessThan_08: //" < ":
                        arrvQxUsers_Sel = arrvQxUsers_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                }
                break;
        }
        if (arrvQxUsers_Sel.length == 0)
            return [];
        return arrvQxUsers_Sel.map(x => x.userId);
    }
    exports.vQxUsers_funcKey = vQxUsers_funcKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function vQxUsers_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vQxUsers_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vQxUsers_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vQxUsers_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vQxUsers_GetFirstIDAsync = vQxUsers_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function vQxUsers_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vQxUsers_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vQxUsers_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vQxUsers_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vQxUsers_GetFirstID = vQxUsers_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function vQxUsers_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vQxUsers_Controller, strAction);
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
                const objvQxUsers = vQxUsers_GetObjFromJsonObj(returnObj);
                return objvQxUsers;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vQxUsers_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vQxUsers_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vQxUsers_GetFirstObjAsync = vQxUsers_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vQxUsers_GetObjLst_ClientCache() {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsvQxUsersEN_js_1.clsvQxUsersEN._CurrTabName;
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvQxUsersEN_js_1.clsvQxUsersEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvQxUsersEN_js_1.clsvQxUsersEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_1.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrvQxUsersExObjLst_Cache = CacheHelper_js_1.CacheHelper.Get(strKey);
            const arrvQxUsersObjLst_T = vQxUsers_GetObjLstByJSONObjLst(arrvQxUsersExObjLst_Cache);
            return arrvQxUsersObjLst_T;
        }
        try {
            const arrvQxUsersExObjLst = await vQxUsers_GetObjLstAsync(strWhereCond);
            CacheHelper_js_1.CacheHelper.Add(strKey, arrvQxUsersExObjLst);
            const strInfo = (0, clsString_js_1.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvQxUsersExObjLst.length);
            console.log(strInfo);
            return arrvQxUsersExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vQxUsers_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vQxUsers_GetObjLst_ClientCache = vQxUsers_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vQxUsers_GetObjLst_localStorage() {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsvQxUsersEN_js_1.clsvQxUsersEN._CurrTabName;
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvQxUsersEN_js_1.clsvQxUsersEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvQxUsersEN_js_1.clsvQxUsersEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrvQxUsersExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrvQxUsersObjLst_T = vQxUsers_GetObjLstByJSONObjLst(arrvQxUsersExObjLst_Cache);
            return arrvQxUsersObjLst_T;
        }
        try {
            const arrvQxUsersExObjLst = await vQxUsers_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrvQxUsersExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvQxUsersExObjLst.length);
            console.log(strInfo);
            return arrvQxUsersExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vQxUsers_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vQxUsers_GetObjLst_localStorage = vQxUsers_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vQxUsers_GetObjLst_localStorage_PureCache() {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsvQxUsersEN_js_1.clsvQxUsersEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrvQxUsersObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvQxUsersObjLst_Cache;
        }
        else
            return null;
    }
    exports.vQxUsers_GetObjLst_localStorage_PureCache = vQxUsers_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function vQxUsers_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vQxUsers_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vQxUsers_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vQxUsers_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vQxUsers_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vQxUsers_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vQxUsers_GetObjLstAsync = vQxUsers_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vQxUsers_GetObjLst_sessionStorage() {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsvQxUsersEN_js_1.clsvQxUsersEN._CurrTabName;
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvQxUsersEN_js_1.clsvQxUsersEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvQxUsersEN_js_1.clsvQxUsersEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrvQxUsersExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrvQxUsersObjLst_T = vQxUsers_GetObjLstByJSONObjLst(arrvQxUsersExObjLst_Cache);
            return arrvQxUsersObjLst_T;
        }
        try {
            const arrvQxUsersExObjLst = await vQxUsers_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrvQxUsersExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvQxUsersExObjLst.length);
            console.log(strInfo);
            return arrvQxUsersExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vQxUsers_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vQxUsers_GetObjLst_sessionStorage = vQxUsers_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vQxUsers_GetObjLst_sessionStorage_PureCache() {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsvQxUsersEN_js_1.clsvQxUsersEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrvQxUsersObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvQxUsersObjLst_Cache;
        }
        else
            return null;
    }
    exports.vQxUsers_GetObjLst_sessionStorage_PureCache = vQxUsers_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vQxUsers_GetObjLst_Cache() {
        //const strThisFuncName = "GetObjLst_Cache";
        let arrvQxUsersObjLst_Cache;
        switch (clsvQxUsersEN_js_1.clsvQxUsersEN.CacheModeId) {
            case "04": //sessionStorage
                arrvQxUsersObjLst_Cache = await vQxUsers_GetObjLst_sessionStorage();
                break;
            case "03": //localStorage
                arrvQxUsersObjLst_Cache = await vQxUsers_GetObjLst_localStorage();
                break;
            case "02": //ClientCache
                arrvQxUsersObjLst_Cache = await vQxUsers_GetObjLst_ClientCache();
                break;
            default:
                arrvQxUsersObjLst_Cache = await vQxUsers_GetObjLst_ClientCache();
                break;
        }
        const arrvQxUsersObjLst = vQxUsers_GetObjLstByJSONObjLst(arrvQxUsersObjLst_Cache);
        return arrvQxUsersObjLst_Cache;
    }
    exports.vQxUsers_GetObjLst_Cache = vQxUsers_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vQxUsers_GetObjLst_PureCache() {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrvQxUsersObjLst_Cache;
        switch (clsvQxUsersEN_js_1.clsvQxUsersEN.CacheModeId) {
            case "04": //sessionStorage
                arrvQxUsersObjLst_Cache = await vQxUsers_GetObjLst_sessionStorage_PureCache();
                break;
            case "03": //localStorage
                arrvQxUsersObjLst_Cache = await vQxUsers_GetObjLst_localStorage_PureCache();
                break;
            case "02": //ClientCache
                arrvQxUsersObjLst_Cache = null;
                break;
            default:
                arrvQxUsersObjLst_Cache = null;
                break;
        }
        return arrvQxUsersObjLst_Cache;
    }
    exports.vQxUsers_GetObjLst_PureCache = vQxUsers_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objstrUserId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function vQxUsers_GetSubObjLst_Cache(objvQxUsers_Cond) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrvQxUsersObjLst_Cache = await vQxUsers_GetObjLst_Cache();
        let arrvQxUsers_Sel = arrvQxUsersObjLst_Cache;
        if (objvQxUsers_Cond.sf_FldComparisonOp == null || objvQxUsers_Cond.sf_FldComparisonOp == "")
            return arrvQxUsers_Sel;
        const dicFldComparisonOp = JSON.parse(objvQxUsers_Cond.sf_FldComparisonOp);
        //console.log("clsvQxUsersWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvQxUsers_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvQxUsers_Sel = arrvQxUsers_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvQxUsers_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvQxUsers_Sel = arrvQxUsers_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvQxUsers_Sel = arrvQxUsers_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvQxUsers_Sel = arrvQxUsers_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvQxUsers_Sel = arrvQxUsers_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvQxUsers_Sel = arrvQxUsers_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvQxUsers_Sel = arrvQxUsers_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvQxUsers_Sel = arrvQxUsers_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvQxUsers_Sel = arrvQxUsers_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvQxUsers_Sel = arrvQxUsers_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvQxUsers_Sel = arrvQxUsers_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvQxUsers_Sel = arrvQxUsers_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvQxUsers_Sel = arrvQxUsers_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvQxUsers_Sel = arrvQxUsers_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrvQxUsers_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objvQxUsers_Cond), exports.vQxUsers_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vQxUsers_GetSubObjLst_Cache = vQxUsers_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrUserId:关键字列表
    * @returns 对象列表
    **/
    async function vQxUsers_GetObjLstByUserIdLstAsync(arrUserId) {
        const strThisFuncName = "GetObjLstByUserIdLstAsync";
        const strAction = "GetObjLstByUserIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vQxUsers_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrUserId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vQxUsers_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vQxUsers_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vQxUsers_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vQxUsers_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vQxUsers_GetObjLstByUserIdLstAsync = vQxUsers_GetObjLstByUserIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrstrUserIdLst:关键字列表
     * @returns 对象列表
    */
    async function vQxUsers_GetObjLstByUserIdLst_Cache(arrUserIdLst) {
        const strThisFuncName = "GetObjLstByUserIdLst_Cache";
        try {
            const arrvQxUsersObjLst_Cache = await vQxUsers_GetObjLst_Cache();
            const arrvQxUsers_Sel = arrvQxUsersObjLst_Cache.filter(x => arrUserIdLst.indexOf(x.userId) > -1);
            return arrvQxUsers_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrUserIdLst.join(","), exports.vQxUsers_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
    }
    exports.vQxUsers_GetObjLstByUserIdLst_Cache = vQxUsers_GetObjLstByUserIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function vQxUsers_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vQxUsers_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vQxUsers_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vQxUsers_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vQxUsers_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vQxUsers_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vQxUsers_GetTopObjLstAsync = vQxUsers_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vQxUsers_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vQxUsers_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vQxUsers_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vQxUsers_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vQxUsers_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vQxUsers_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vQxUsers_GetObjLstByRangeAsync = vQxUsers_GetObjLstByRangeAsync;
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
    async function vQxUsers_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vQxUsers_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vQxUsers_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vQxUsers_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vQxUsers_GetObjLstByRange = vQxUsers_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function vQxUsers_GetObjLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const arrvQxUsersObjLst_Cache = await vQxUsers_GetObjLst_Cache();
        if (arrvQxUsersObjLst_Cache.length == 0)
            return arrvQxUsersObjLst_Cache;
        let arrvQxUsers_Sel = arrvQxUsersObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objvQxUsers_Cond = new clsvQxUsersEN_js_1.clsvQxUsersEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvQxUsers_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsvQxUsersWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvQxUsers_Sel = arrvQxUsers_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvQxUsers_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvQxUsers_Sel = arrvQxUsers_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvQxUsers_Sel = arrvQxUsers_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvQxUsers_Sel = arrvQxUsers_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvQxUsers_Sel = arrvQxUsers_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvQxUsers_Sel = arrvQxUsers_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvQxUsers_Sel = arrvQxUsers_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvQxUsers_Sel = arrvQxUsers_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrvQxUsers_Sel = arrvQxUsers_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvQxUsers_Sel = arrvQxUsers_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvQxUsers_Sel = arrvQxUsers_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvQxUsers_Sel = arrvQxUsers_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvQxUsers_Sel = arrvQxUsers_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvQxUsers_Sel = arrvQxUsers_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvQxUsers_Sel = arrvQxUsers_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvQxUsers_Sel.length == 0)
                return arrvQxUsers_Sel;
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
                arrvQxUsers_Sel = arrvQxUsers_Sel.sort(vQxUsers_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrvQxUsers_Sel = arrvQxUsers_Sel.sort(objPagerPara.sortFun);
            }
            arrvQxUsers_Sel = arrvQxUsers_Sel.slice(intStart, intEnd);
            return arrvQxUsers_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.vQxUsers_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vQxUsers_GetObjLstByPager_Cache = vQxUsers_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vQxUsers_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vQxUsers_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vQxUsers_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vQxUsers_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vQxUsers_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vQxUsers_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vQxUsers_GetObjLstByPagerAsync = vQxUsers_GetObjLstByPagerAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objstrUserId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function vQxUsers_IsExistRecord_Cache(objvQxUsers_Cond) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrvQxUsersObjLst_Cache = await vQxUsers_GetObjLst_Cache();
        if (arrvQxUsersObjLst_Cache == null)
            return false;
        let arrvQxUsers_Sel = arrvQxUsersObjLst_Cache;
        if (objvQxUsers_Cond.sf_FldComparisonOp == null || objvQxUsers_Cond.sf_FldComparisonOp == "")
            return arrvQxUsers_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objvQxUsers_Cond.sf_FldComparisonOp);
        //console.log("clsvQxUsersWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvQxUsers_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvQxUsers_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvQxUsers_Sel = arrvQxUsers_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvQxUsers_Sel = arrvQxUsers_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvQxUsers_Sel = arrvQxUsers_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvQxUsers_Sel = arrvQxUsers_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvQxUsers_Sel = arrvQxUsers_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvQxUsers_Sel = arrvQxUsers_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvQxUsers_Sel = arrvQxUsers_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvQxUsers_Sel = arrvQxUsers_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvQxUsers_Sel = arrvQxUsers_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvQxUsers_Sel = arrvQxUsers_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvQxUsers_Sel = arrvQxUsers_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvQxUsers_Sel = arrvQxUsers_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvQxUsers_Sel = arrvQxUsers_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvQxUsers_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objvQxUsers_Cond), exports.vQxUsers_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.vQxUsers_IsExistRecord_Cache = vQxUsers_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function vQxUsers_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vQxUsers_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vQxUsers_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vQxUsers_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vQxUsers_IsExistRecordAsync = vQxUsers_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strUserId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function vQxUsers_IsExist(strUserId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vQxUsers_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vQxUsers_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vQxUsers_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vQxUsers_IsExist = vQxUsers_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param strUserId:所给的关键字
     * @returns 对象
    */
    async function vQxUsers_IsExist_Cache(strUserId) {
        const strThisFuncName = "IsExist_Cache";
        const arrvQxUsersObjLst_Cache = await vQxUsers_GetObjLst_Cache();
        if (arrvQxUsersObjLst_Cache == null)
            return false;
        try {
            const arrvQxUsers_Sel = arrvQxUsersObjLst_Cache.filter(x => x.userId == strUserId);
            if (arrvQxUsers_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strUserId, exports.vQxUsers_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.vQxUsers_IsExist_Cache = vQxUsers_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strUserId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function vQxUsers_IsExistAsync(strUserId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vQxUsers_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vQxUsers_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vQxUsers_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vQxUsers_IsExistAsync = vQxUsers_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function vQxUsers_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vQxUsers_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vQxUsers_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vQxUsers_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vQxUsers_GetRecCountByCondAsync = vQxUsers_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objvQxUsers_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function vQxUsers_GetRecCountByCond_Cache(objvQxUsers_Cond) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrvQxUsersObjLst_Cache = await vQxUsers_GetObjLst_Cache();
        if (arrvQxUsersObjLst_Cache == null)
            return 0;
        let arrvQxUsers_Sel = arrvQxUsersObjLst_Cache;
        if (objvQxUsers_Cond.sf_FldComparisonOp == null || objvQxUsers_Cond.sf_FldComparisonOp == "")
            return arrvQxUsers_Sel.length;
        const dicFldComparisonOp = JSON.parse(objvQxUsers_Cond.sf_FldComparisonOp);
        //console.log("clsvQxUsersWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvQxUsers_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvQxUsers_Sel = arrvQxUsers_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvQxUsers_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvQxUsers_Sel = arrvQxUsers_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvQxUsers_Sel = arrvQxUsers_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvQxUsers_Sel = arrvQxUsers_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvQxUsers_Sel = arrvQxUsers_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvQxUsers_Sel = arrvQxUsers_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvQxUsers_Sel = arrvQxUsers_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvQxUsers_Sel = arrvQxUsers_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrvQxUsers_Sel = arrvQxUsers_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvQxUsers_Sel = arrvQxUsers_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvQxUsers_Sel = arrvQxUsers_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvQxUsers_Sel = arrvQxUsers_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvQxUsers_Sel = arrvQxUsers_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvQxUsers_Sel = arrvQxUsers_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvQxUsers_Sel = arrvQxUsers_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrvQxUsers_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objvQxUsers_Cond), exports.vQxUsers_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.vQxUsers_GetRecCountByCond_Cache = vQxUsers_GetRecCountByCond_Cache;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function vQxUsers_GetWebApiUrl(strController, strAction) {
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
    exports.vQxUsers_GetWebApiUrl = vQxUsers_GetWebApiUrl;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function vQxUsers_ReFreshThisCache() {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = clsvQxUsersEN_js_1.clsvQxUsersEN._CurrTabName;
            switch (clsvQxUsersEN_js_1.clsvQxUsersEN.CacheModeId) {
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
    exports.vQxUsers_ReFreshThisCache = vQxUsers_ReFreshThisCache;
    /* 该表的下拉框功能没有设置，不需要生成下拉框绑定函数。*/
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vQxUsers_GetJSONStrByObj(pobjvQxUsersEN) {
        const strThisFuncName = "GetJSONStrByObj";
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjvQxUsersEN);
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
    exports.vQxUsers_GetJSONStrByObj = vQxUsers_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function vQxUsers_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrvQxUsersObjLst = new Array();
        if (strJSON === "") {
            return arrvQxUsersObjLst;
        }
        try {
            arrvQxUsersObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrvQxUsersObjLst;
        }
        return arrvQxUsersObjLst;
    }
    exports.vQxUsers_GetObjLstByJSONStr = vQxUsers_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrvQxUsersObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function vQxUsers_GetObjLstByJSONObjLst(arrvQxUsersObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrvQxUsersObjLst = new Array();
        for (const objInFor of arrvQxUsersObjLstS) {
            const obj1 = vQxUsers_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrvQxUsersObjLst.push(obj1);
        }
        return arrvQxUsersObjLst;
    }
    exports.vQxUsers_GetObjLstByJSONObjLst = vQxUsers_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vQxUsers_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjvQxUsersEN = new clsvQxUsersEN_js_1.clsvQxUsersEN();
        if (strJSON === "") {
            return pobjvQxUsersEN;
        }
        try {
            pobjvQxUsersEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjvQxUsersEN;
        }
        return pobjvQxUsersEN;
    }
    exports.vQxUsers_GetObjByJSONStr = vQxUsers_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function vQxUsers_GetCombineCondition(objvQxUsers_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objvQxUsers_Cond.dicFldComparisonOp, clsvQxUsersEN_js_1.clsvQxUsersEN.con_UserId) == true) {
            const strComparisonOp_UserId = objvQxUsers_Cond.dicFldComparisonOp[clsvQxUsersEN_js_1.clsvQxUsersEN.con_UserId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQxUsersEN_js_1.clsvQxUsersEN.con_UserId, objvQxUsers_Cond.userId, strComparisonOp_UserId);
        }
        if (Object.prototype.hasOwnProperty.call(objvQxUsers_Cond.dicFldComparisonOp, clsvQxUsersEN_js_1.clsvQxUsersEN.con_UserName) == true) {
            const strComparisonOp_UserName = objvQxUsers_Cond.dicFldComparisonOp[clsvQxUsersEN_js_1.clsvQxUsersEN.con_UserName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQxUsersEN_js_1.clsvQxUsersEN.con_UserName, objvQxUsers_Cond.userName, strComparisonOp_UserName);
        }
        if (Object.prototype.hasOwnProperty.call(objvQxUsers_Cond.dicFldComparisonOp, clsvQxUsersEN_js_1.clsvQxUsersEN.con_UserStateId) == true) {
            const strComparisonOp_UserStateId = objvQxUsers_Cond.dicFldComparisonOp[clsvQxUsersEN_js_1.clsvQxUsersEN.con_UserStateId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQxUsersEN_js_1.clsvQxUsersEN.con_UserStateId, objvQxUsers_Cond.userStateId, strComparisonOp_UserStateId);
        }
        if (Object.prototype.hasOwnProperty.call(objvQxUsers_Cond.dicFldComparisonOp, clsvQxUsersEN_js_1.clsvQxUsersEN.con_Memo) == true) {
            const strComparisonOp_Memo = objvQxUsers_Cond.dicFldComparisonOp[clsvQxUsersEN_js_1.clsvQxUsersEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQxUsersEN_js_1.clsvQxUsersEN.con_Memo, objvQxUsers_Cond.memo, strComparisonOp_Memo);
        }
        if (Object.prototype.hasOwnProperty.call(objvQxUsers_Cond.dicFldComparisonOp, clsvQxUsersEN_js_1.clsvQxUsersEN.con_UserStateName) == true) {
            const strComparisonOp_UserStateName = objvQxUsers_Cond.dicFldComparisonOp[clsvQxUsersEN_js_1.clsvQxUsersEN.con_UserStateName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQxUsersEN_js_1.clsvQxUsersEN.con_UserStateName, objvQxUsers_Cond.userStateName, strComparisonOp_UserStateName);
        }
        if (Object.prototype.hasOwnProperty.call(objvQxUsers_Cond.dicFldComparisonOp, clsvQxUsersEN_js_1.clsvQxUsersEN.con_DepartmentId) == true) {
            const strComparisonOp_DepartmentId = objvQxUsers_Cond.dicFldComparisonOp[clsvQxUsersEN_js_1.clsvQxUsersEN.con_DepartmentId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQxUsersEN_js_1.clsvQxUsersEN.con_DepartmentId, objvQxUsers_Cond.departmentId, strComparisonOp_DepartmentId);
        }
        if (Object.prototype.hasOwnProperty.call(objvQxUsers_Cond.dicFldComparisonOp, clsvQxUsersEN_js_1.clsvQxUsersEN.con_UpDepartmentId) == true) {
            const strComparisonOp_UpDepartmentId = objvQxUsers_Cond.dicFldComparisonOp[clsvQxUsersEN_js_1.clsvQxUsersEN.con_UpDepartmentId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQxUsersEN_js_1.clsvQxUsersEN.con_UpDepartmentId, objvQxUsers_Cond.upDepartmentId, strComparisonOp_UpDepartmentId);
        }
        if (Object.prototype.hasOwnProperty.call(objvQxUsers_Cond.dicFldComparisonOp, clsvQxUsersEN_js_1.clsvQxUsersEN.con_DepartmentName) == true) {
            const strComparisonOp_DepartmentName = objvQxUsers_Cond.dicFldComparisonOp[clsvQxUsersEN_js_1.clsvQxUsersEN.con_DepartmentName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQxUsersEN_js_1.clsvQxUsersEN.con_DepartmentName, objvQxUsers_Cond.departmentName, strComparisonOp_DepartmentName);
        }
        if (Object.prototype.hasOwnProperty.call(objvQxUsers_Cond.dicFldComparisonOp, clsvQxUsersEN_js_1.clsvQxUsersEN.con_UpDepartmentName) == true) {
            const strComparisonOp_UpDepartmentName = objvQxUsers_Cond.dicFldComparisonOp[clsvQxUsersEN_js_1.clsvQxUsersEN.con_UpDepartmentName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQxUsersEN_js_1.clsvQxUsersEN.con_UpDepartmentName, objvQxUsers_Cond.upDepartmentName, strComparisonOp_UpDepartmentName);
        }
        if (Object.prototype.hasOwnProperty.call(objvQxUsers_Cond.dicFldComparisonOp, clsvQxUsersEN_js_1.clsvQxUsersEN.con_DepartmentTypeName) == true) {
            const strComparisonOp_DepartmentTypeName = objvQxUsers_Cond.dicFldComparisonOp[clsvQxUsersEN_js_1.clsvQxUsersEN.con_DepartmentTypeName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQxUsersEN_js_1.clsvQxUsersEN.con_DepartmentTypeName, objvQxUsers_Cond.departmentTypeName, strComparisonOp_DepartmentTypeName);
        }
        if (Object.prototype.hasOwnProperty.call(objvQxUsers_Cond.dicFldComparisonOp, clsvQxUsersEN_js_1.clsvQxUsersEN.con_DepartmentTypeId) == true) {
            const strComparisonOp_DepartmentTypeId = objvQxUsers_Cond.dicFldComparisonOp[clsvQxUsersEN_js_1.clsvQxUsersEN.con_DepartmentTypeId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQxUsersEN_js_1.clsvQxUsersEN.con_DepartmentTypeId, objvQxUsers_Cond.departmentTypeId, strComparisonOp_DepartmentTypeId);
        }
        if (Object.prototype.hasOwnProperty.call(objvQxUsers_Cond.dicFldComparisonOp, clsvQxUsersEN_js_1.clsvQxUsersEN.con_DepartmentAbbrName) == true) {
            const strComparisonOp_DepartmentAbbrName = objvQxUsers_Cond.dicFldComparisonOp[clsvQxUsersEN_js_1.clsvQxUsersEN.con_DepartmentAbbrName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQxUsersEN_js_1.clsvQxUsersEN.con_DepartmentAbbrName, objvQxUsers_Cond.departmentAbbrName, strComparisonOp_DepartmentAbbrName);
        }
        if (Object.prototype.hasOwnProperty.call(objvQxUsers_Cond.dicFldComparisonOp, clsvQxUsersEN_js_1.clsvQxUsersEN.con_EffectiveDate) == true) {
            const strComparisonOp_EffectiveDate = objvQxUsers_Cond.dicFldComparisonOp[clsvQxUsersEN_js_1.clsvQxUsersEN.con_EffectiveDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQxUsersEN_js_1.clsvQxUsersEN.con_EffectiveDate, objvQxUsers_Cond.effectiveDate, strComparisonOp_EffectiveDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvQxUsers_Cond.dicFldComparisonOp, clsvQxUsersEN_js_1.clsvQxUsersEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objvQxUsers_Cond.dicFldComparisonOp[clsvQxUsersEN_js_1.clsvQxUsersEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQxUsersEN_js_1.clsvQxUsersEN.con_UpdDate, objvQxUsers_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvQxUsers_Cond.dicFldComparisonOp, clsvQxUsersEN_js_1.clsvQxUsersEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objvQxUsers_Cond.dicFldComparisonOp[clsvQxUsersEN_js_1.clsvQxUsersEN.con_UpdUser];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQxUsersEN_js_1.clsvQxUsersEN.con_UpdUser, objvQxUsers_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objvQxUsers_Cond.dicFldComparisonOp, clsvQxUsersEN_js_1.clsvQxUsersEN.con_EffitiveBeginDate) == true) {
            const strComparisonOp_EffitiveBeginDate = objvQxUsers_Cond.dicFldComparisonOp[clsvQxUsersEN_js_1.clsvQxUsersEN.con_EffitiveBeginDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQxUsersEN_js_1.clsvQxUsersEN.con_EffitiveBeginDate, objvQxUsers_Cond.effitiveBeginDate, strComparisonOp_EffitiveBeginDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvQxUsers_Cond.dicFldComparisonOp, clsvQxUsersEN_js_1.clsvQxUsersEN.con_EffitiveEndDate) == true) {
            const strComparisonOp_EffitiveEndDate = objvQxUsers_Cond.dicFldComparisonOp[clsvQxUsersEN_js_1.clsvQxUsersEN.con_EffitiveEndDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQxUsersEN_js_1.clsvQxUsersEN.con_EffitiveEndDate, objvQxUsers_Cond.effitiveEndDate, strComparisonOp_EffitiveEndDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvQxUsers_Cond.dicFldComparisonOp, clsvQxUsersEN_js_1.clsvQxUsersEN.con_StuTeacherID) == true) {
            const strComparisonOp_StuTeacherID = objvQxUsers_Cond.dicFldComparisonOp[clsvQxUsersEN_js_1.clsvQxUsersEN.con_StuTeacherID];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQxUsersEN_js_1.clsvQxUsersEN.con_StuTeacherID, objvQxUsers_Cond.stuTeacherID, strComparisonOp_StuTeacherID);
        }
        if (Object.prototype.hasOwnProperty.call(objvQxUsers_Cond.dicFldComparisonOp, clsvQxUsersEN_js_1.clsvQxUsersEN.con_IdentityID) == true) {
            const strComparisonOp_IdentityID = objvQxUsers_Cond.dicFldComparisonOp[clsvQxUsersEN_js_1.clsvQxUsersEN.con_IdentityID];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQxUsersEN_js_1.clsvQxUsersEN.con_IdentityID, objvQxUsers_Cond.identityID, strComparisonOp_IdentityID);
        }
        if (Object.prototype.hasOwnProperty.call(objvQxUsers_Cond.dicFldComparisonOp, clsvQxUsersEN_js_1.clsvQxUsersEN.con_Password) == true) {
            const strComparisonOp_Password = objvQxUsers_Cond.dicFldComparisonOp[clsvQxUsersEN_js_1.clsvQxUsersEN.con_Password];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQxUsersEN_js_1.clsvQxUsersEN.con_Password, objvQxUsers_Cond.password, strComparisonOp_Password);
        }
        if (Object.prototype.hasOwnProperty.call(objvQxUsers_Cond.dicFldComparisonOp, clsvQxUsersEN_js_1.clsvQxUsersEN.con_IdentityDesc) == true) {
            const strComparisonOp_IdentityDesc = objvQxUsers_Cond.dicFldComparisonOp[clsvQxUsersEN_js_1.clsvQxUsersEN.con_IdentityDesc];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQxUsersEN_js_1.clsvQxUsersEN.con_IdentityDesc, objvQxUsers_Cond.identityDesc, strComparisonOp_IdentityDesc);
        }
        if (Object.prototype.hasOwnProperty.call(objvQxUsers_Cond.dicFldComparisonOp, clsvQxUsersEN_js_1.clsvQxUsersEN.con_IsSynch) == true) {
            if (objvQxUsers_Cond.isSynch == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvQxUsersEN_js_1.clsvQxUsersEN.con_IsSynch);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvQxUsersEN_js_1.clsvQxUsersEN.con_IsSynch);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvQxUsers_Cond.dicFldComparisonOp, clsvQxUsersEN_js_1.clsvQxUsersEN.con_SynchDate) == true) {
            const strComparisonOp_SynchDate = objvQxUsers_Cond.dicFldComparisonOp[clsvQxUsersEN_js_1.clsvQxUsersEN.con_SynchDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQxUsersEN_js_1.clsvQxUsersEN.con_SynchDate, objvQxUsers_Cond.synchDate, strComparisonOp_SynchDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvQxUsers_Cond.dicFldComparisonOp, clsvQxUsersEN_js_1.clsvQxUsersEN.con_OpenId) == true) {
            const strComparisonOp_OpenId = objvQxUsers_Cond.dicFldComparisonOp[clsvQxUsersEN_js_1.clsvQxUsersEN.con_OpenId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQxUsersEN_js_1.clsvQxUsersEN.con_OpenId, objvQxUsers_Cond.openId, strComparisonOp_OpenId);
        }
        if (Object.prototype.hasOwnProperty.call(objvQxUsers_Cond.dicFldComparisonOp, clsvQxUsersEN_js_1.clsvQxUsersEN.con_NickName) == true) {
            const strComparisonOp_NickName = objvQxUsers_Cond.dicFldComparisonOp[clsvQxUsersEN_js_1.clsvQxUsersEN.con_NickName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQxUsersEN_js_1.clsvQxUsersEN.con_NickName, objvQxUsers_Cond.nickName, strComparisonOp_NickName);
        }
        if (Object.prototype.hasOwnProperty.call(objvQxUsers_Cond.dicFldComparisonOp, clsvQxUsersEN_js_1.clsvQxUsersEN.con_HeadimgUrl) == true) {
            const strComparisonOp_HeadimgUrl = objvQxUsers_Cond.dicFldComparisonOp[clsvQxUsersEN_js_1.clsvQxUsersEN.con_HeadimgUrl];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQxUsersEN_js_1.clsvQxUsersEN.con_HeadimgUrl, objvQxUsers_Cond.headimgUrl, strComparisonOp_HeadimgUrl);
        }
        if (Object.prototype.hasOwnProperty.call(objvQxUsers_Cond.dicFldComparisonOp, clsvQxUsersEN_js_1.clsvQxUsersEN.con_CollegeName) == true) {
            const strComparisonOp_CollegeName = objvQxUsers_Cond.dicFldComparisonOp[clsvQxUsersEN_js_1.clsvQxUsersEN.con_CollegeName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQxUsersEN_js_1.clsvQxUsersEN.con_CollegeName, objvQxUsers_Cond.collegeName, strComparisonOp_CollegeName);
        }
        if (Object.prototype.hasOwnProperty.call(objvQxUsers_Cond.dicFldComparisonOp, clsvQxUsersEN_js_1.clsvQxUsersEN.con_id_XzCollege) == true) {
            const strComparisonOp_id_XzCollege = objvQxUsers_Cond.dicFldComparisonOp[clsvQxUsersEN_js_1.clsvQxUsersEN.con_id_XzCollege];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQxUsersEN_js_1.clsvQxUsersEN.con_id_XzCollege, objvQxUsers_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
        }
        if (Object.prototype.hasOwnProperty.call(objvQxUsers_Cond.dicFldComparisonOp, clsvQxUsersEN_js_1.clsvQxUsersEN.con_id_XzMajor) == true) {
            const strComparisonOp_id_XzMajor = objvQxUsers_Cond.dicFldComparisonOp[clsvQxUsersEN_js_1.clsvQxUsersEN.con_id_XzMajor];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQxUsersEN_js_1.clsvQxUsersEN.con_id_XzMajor, objvQxUsers_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
        }
        if (Object.prototype.hasOwnProperty.call(objvQxUsers_Cond.dicFldComparisonOp, clsvQxUsersEN_js_1.clsvQxUsersEN.con_MajorName) == true) {
            const strComparisonOp_MajorName = objvQxUsers_Cond.dicFldComparisonOp[clsvQxUsersEN_js_1.clsvQxUsersEN.con_MajorName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQxUsersEN_js_1.clsvQxUsersEN.con_MajorName, objvQxUsers_Cond.majorName, strComparisonOp_MajorName);
        }
        if (Object.prototype.hasOwnProperty.call(objvQxUsers_Cond.dicFldComparisonOp, clsvQxUsersEN_js_1.clsvQxUsersEN.con_Email) == true) {
            const strComparisonOp_Email = objvQxUsers_Cond.dicFldComparisonOp[clsvQxUsersEN_js_1.clsvQxUsersEN.con_Email];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQxUsersEN_js_1.clsvQxUsersEN.con_Email, objvQxUsers_Cond.email, strComparisonOp_Email);
        }
        if (Object.prototype.hasOwnProperty.call(objvQxUsers_Cond.dicFldComparisonOp, clsvQxUsersEN_js_1.clsvQxUsersEN.con_id_College) == true) {
            const strComparisonOp_id_College = objvQxUsers_Cond.dicFldComparisonOp[clsvQxUsersEN_js_1.clsvQxUsersEN.con_id_College];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQxUsersEN_js_1.clsvQxUsersEN.con_id_College, objvQxUsers_Cond.id_College, strComparisonOp_id_College);
        }
        return strWhereCond;
    }
    exports.vQxUsers_GetCombineCondition = vQxUsers_GetCombineCondition;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objvQxUsersENS:源对象
     * @param objvQxUsersENT:目标对象
    */
    function vQxUsers_CopyObjTo(objvQxUsersENS, objvQxUsersENT) {
        objvQxUsersENT.userId = objvQxUsersENS.userId; //用户ID
        objvQxUsersENT.userName = objvQxUsersENS.userName; //用户名
        objvQxUsersENT.userStateId = objvQxUsersENS.userStateId; //用户状态Id
        objvQxUsersENT.memo = objvQxUsersENS.memo; //备注
        objvQxUsersENT.userStateName = objvQxUsersENS.userStateName; //用户状态名
        objvQxUsersENT.departmentId = objvQxUsersENS.departmentId; //部门Id
        objvQxUsersENT.upDepartmentId = objvQxUsersENS.upDepartmentId; //UpDepartmentId
        objvQxUsersENT.departmentName = objvQxUsersENS.departmentName; //部门名称
        objvQxUsersENT.upDepartmentName = objvQxUsersENS.upDepartmentName; //UpDepartmentName
        objvQxUsersENT.departmentTypeName = objvQxUsersENS.departmentTypeName; //DepartmentTypeName
        objvQxUsersENT.departmentTypeId = objvQxUsersENS.departmentTypeId; //DepartmentTypeId
        objvQxUsersENT.departmentAbbrName = objvQxUsersENS.departmentAbbrName; //DepartmentAbbrName
        objvQxUsersENT.effectiveDate = objvQxUsersENS.effectiveDate; //EffectiveDate
        objvQxUsersENT.updDate = objvQxUsersENS.updDate; //修改日期
        objvQxUsersENT.updUser = objvQxUsersENS.updUser; //修改人
        objvQxUsersENT.effitiveBeginDate = objvQxUsersENS.effitiveBeginDate; //EffitiveBeginDate
        objvQxUsersENT.effitiveEndDate = objvQxUsersENS.effitiveEndDate; //EffitiveEndDate
        objvQxUsersENT.stuTeacherID = objvQxUsersENS.stuTeacherID; //学工号
        objvQxUsersENT.identityID = objvQxUsersENS.identityID; //身份编号
        objvQxUsersENT.password = objvQxUsersENS.password; //Password
        objvQxUsersENT.identityDesc = objvQxUsersENS.identityDesc; //身份描述
        objvQxUsersENT.isSynch = objvQxUsersENS.isSynch; //是否同步
        objvQxUsersENT.synchDate = objvQxUsersENS.synchDate; //同步日期
        objvQxUsersENT.openId = objvQxUsersENS.openId; //微信OpenId
        objvQxUsersENT.nickName = objvQxUsersENS.nickName; //昵称
        objvQxUsersENT.headimgUrl = objvQxUsersENS.headimgUrl; //微信头像
        objvQxUsersENT.collegeName = objvQxUsersENS.collegeName; //学院名称
        objvQxUsersENT.id_XzCollege = objvQxUsersENS.id_XzCollege; //学院流水号
        objvQxUsersENT.id_XzMajor = objvQxUsersENS.id_XzMajor; //专业流水号
        objvQxUsersENT.majorName = objvQxUsersENS.majorName; //专业名称
        objvQxUsersENT.email = objvQxUsersENS.email; //电子邮箱
        objvQxUsersENT.id_College = objvQxUsersENS.id_College; //学院流水号
    }
    exports.vQxUsers_CopyObjTo = vQxUsers_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objvQxUsersENS:源对象
     * @param objvQxUsersENT:目标对象
    */
    function vQxUsers_GetObjFromJsonObj(objvQxUsersENS) {
        const objvQxUsersENT = new clsvQxUsersEN_js_1.clsvQxUsersEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvQxUsersENT, objvQxUsersENS);
        return objvQxUsersENT;
    }
    exports.vQxUsers_GetObjFromJsonObj = vQxUsers_GetObjFromJsonObj;
});
