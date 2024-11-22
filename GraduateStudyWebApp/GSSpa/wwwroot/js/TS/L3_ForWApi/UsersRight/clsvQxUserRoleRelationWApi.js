/**
* 类名:clsvQxUserRoleRelationWApi
* 表名:vQxUserRoleRelation(01120257)
* 生成代码版本:2022.11.02.1
* 生成日期:2022/11/02 12:02:36
* 生成者:pyf
* 生成服务器IP:
工程名称:问卷调查(0112)
CM工程:研究生论文学习(变量首字母小写)-全部函数集
* 相关数据库:103.116.76.183,9433EduHigh_Jsie
* PrjDataBaseId:0170
模块中文名:权限管理(UsersRight)
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
        define(["require", "exports", "axios", "../../PubFun/CacheHelper.js", "../../L0_Entity/UsersRight/clsvQxUserRoleRelationEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsSysPara4WebApi.js", "../../PubFun/CacheHelper.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.vQxUserRoleRelation_GetObjFromJsonObj = exports.vQxUserRoleRelation_CopyObjTo = exports.vQxUserRoleRelation_GetUniCondStr4Update_mId_UserId = exports.vQxUserRoleRelation_GetUniCondStr_mId_UserId = exports.vQxUserRoleRelation_GetCombineCondition = exports.vQxUserRoleRelation_GetObjByJSONStr = exports.vQxUserRoleRelation_GetObjLstByJSONObjLst = exports.vQxUserRoleRelation_GetObjLstByJSONStr = exports.vQxUserRoleRelation_GetJSONStrByObj = exports.vQxUserRoleRelation_ReFreshThisCache = exports.vQxUserRoleRelation_GetWebApiUrl = exports.vQxUserRoleRelation_GetRecCountByCond_Cache = exports.vQxUserRoleRelation_GetRecCountByCondAsync = exports.vQxUserRoleRelation_IsExistAsync = exports.vQxUserRoleRelation_IsExist_Cache = exports.vQxUserRoleRelation_IsExist = exports.vQxUserRoleRelation_IsExistRecordAsync = exports.vQxUserRoleRelation_IsExistRecord_Cache = exports.vQxUserRoleRelation_GetObjLstByPagerAsync = exports.vQxUserRoleRelation_GetObjLstByPager_Cache = exports.vQxUserRoleRelation_GetObjLstByRange = exports.vQxUserRoleRelation_GetObjLstByRangeAsync = exports.vQxUserRoleRelation_GetTopObjLstAsync = exports.vQxUserRoleRelation_GetObjLstBymIdLst_Cache = exports.vQxUserRoleRelation_GetObjLstBymIdLstAsync = exports.vQxUserRoleRelation_GetSubObjLst_Cache = exports.vQxUserRoleRelation_GetObjLst_PureCache = exports.vQxUserRoleRelation_GetObjLst_Cache = exports.vQxUserRoleRelation_GetObjLst_sessionStorage_PureCache = exports.vQxUserRoleRelation_GetObjLst_sessionStorage = exports.vQxUserRoleRelation_GetObjLstAsync = exports.vQxUserRoleRelation_GetObjLst_localStorage_PureCache = exports.vQxUserRoleRelation_GetObjLst_localStorage = exports.vQxUserRoleRelation_GetObjLst_ClientCache = exports.vQxUserRoleRelation_GetFirstObjAsync = exports.vQxUserRoleRelation_GetFirstID = exports.vQxUserRoleRelation_GetFirstIDAsync = exports.vQxUserRoleRelation_FilterFunByKey = exports.vQxUserRoleRelation_SortFunByKey = exports.vQxUserRoleRelation_SortFun_Defa_2Fld = exports.vQxUserRoleRelation_SortFun_Defa = exports.vQxUserRoleRelation_func = exports.vQxUserRoleRelation_GetObjBymId_localStorage = exports.vQxUserRoleRelation_GetObjBymId_Cache = exports.vQxUserRoleRelation_GetObjBymIdAsync = exports.vQxUserRoleRelation_ConstructorName = exports.vQxUserRoleRelation_Controller = void 0;
    /**
     * vQx用户角色关系(vQxUserRoleRelation)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2022年11月02日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsvQxUserRoleRelationEN_js_1 = require("../../L0_Entity/UsersRight/clsvQxUserRoleRelationEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    const CacheHelper_js_2 = require("../../PubFun/CacheHelper.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.vQxUserRoleRelation_Controller = "vQxUserRoleRelationApi";
    exports.vQxUserRoleRelation_ConstructorName = "vQxUserRoleRelation";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param lngmId:关键字
    * @returns 对象
    **/
    async function vQxUserRoleRelation_GetObjBymIdAsync(lngmId) {
        const strThisFuncName = "GetObjBymIdAsync";
        if (lngmId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngmId]不能为空！(In GetObjBymIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjBymId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vQxUserRoleRelation_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "lngmId": lngmId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vQxUserRoleRelation_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objvQxUserRoleRelation = vQxUserRoleRelation_GetObjFromJsonObj(returnObj);
                return objvQxUserRoleRelation;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vQxUserRoleRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vQxUserRoleRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vQxUserRoleRelation_GetObjBymIdAsync = vQxUserRoleRelation_GetObjBymIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param lngmId:所给的关键字
     * @returns 对象
    */
    async function vQxUserRoleRelation_GetObjBymId_Cache(lngmId, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjBymId_Cache";
        if (lngmId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngmId]不能为空！(In GetObjBymId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        const arrvQxUserRoleRelationObjLst_Cache = await vQxUserRoleRelation_GetObjLst_Cache();
        try {
            const arrvQxUserRoleRelation_Sel = arrvQxUserRoleRelationObjLst_Cache.filter(x => x.mId == lngmId);
            let objvQxUserRoleRelation;
            if (arrvQxUserRoleRelation_Sel.length > 0) {
                objvQxUserRoleRelation = arrvQxUserRoleRelation_Sel[0];
                return objvQxUserRoleRelation;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    objvQxUserRoleRelation = await vQxUserRoleRelation_GetObjBymIdAsync(lngmId);
                    if (objvQxUserRoleRelation != null) {
                        vQxUserRoleRelation_ReFreshThisCache();
                        return objvQxUserRoleRelation;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngmId, exports.vQxUserRoleRelation_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.vQxUserRoleRelation_GetObjBymId_Cache = vQxUserRoleRelation_GetObjBymId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param lngmId:所给的关键字
     * @returns 对象
    */
    async function vQxUserRoleRelation_GetObjBymId_localStorage(lngmId) {
        const strThisFuncName = "GetObjBymId_localStorage";
        if (lngmId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngmId]不能为空！(In GetObjBymId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN._CurrTabName, lngmId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objvQxUserRoleRelation_Cache = JSON.parse(strTempObj);
            return objvQxUserRoleRelation_Cache;
        }
        try {
            const objvQxUserRoleRelation = await vQxUserRoleRelation_GetObjBymIdAsync(lngmId);
            if (objvQxUserRoleRelation != null) {
                localStorage.setItem(strKey, JSON.stringify(objvQxUserRoleRelation));
                const strInfo = (0, clsString_js_1.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objvQxUserRoleRelation;
            }
            return objvQxUserRoleRelation;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngmId, exports.vQxUserRoleRelation_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.vQxUserRoleRelation_GetObjBymId_localStorage = vQxUserRoleRelation_GetObjBymId_localStorage;
    /*该表没有名称字段，不能生成此函数！*/
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
    async function vQxUserRoleRelation_func(strInFldName, strOutFldName, strInValue) {
        //const strThisFuncName = "func";
        if (strInFldName != clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_mId) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_1.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strInFldName, clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const lngmId = Number(strInValue);
        if (lngmId == 0) {
            return "";
        }
        const objvQxUserRoleRelation = await vQxUserRoleRelation_GetObjBymId_Cache(lngmId);
        if (objvQxUserRoleRelation == null)
            return "";
        return objvQxUserRoleRelation.GetFldValue(strOutFldName).toString();
    }
    exports.vQxUserRoleRelation_func = vQxUserRoleRelation_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vQxUserRoleRelation_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.mId - b.mId;
    }
    exports.vQxUserRoleRelation_SortFun_Defa = vQxUserRoleRelation_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vQxUserRoleRelation_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.userId == b.userId)
            return a.roleId.localeCompare(b.roleId);
        else
            return a.userId.localeCompare(b.userId);
    }
    exports.vQxUserRoleRelation_SortFun_Defa_2Fld = vQxUserRoleRelation_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vQxUserRoleRelation_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_mId:
                    return (a, b) => {
                        return a.mId - b.mId;
                    };
                case clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_UserId:
                    return (a, b) => {
                        return a.userId.localeCompare(b.userId);
                    };
                case clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_RoleId:
                    return (a, b) => {
                        return a.roleId.localeCompare(b.roleId);
                    };
                case clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_QxPrjId:
                    return (a, b) => {
                        return a.qxPrjId.localeCompare(b.qxPrjId);
                    };
                case clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_Memo:
                    return (a, b) => {
                        return a.memo.localeCompare(b.memo);
                    };
                case clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_PrjName:
                    return (a, b) => {
                        return a.prjName.localeCompare(b.prjName);
                    };
                case clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_RoleName:
                    return (a, b) => {
                        return a.roleName.localeCompare(b.roleName);
                    };
                case clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_UserName:
                    return (a, b) => {
                        return a.userName.localeCompare(b.userName);
                    };
                case clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_DepartmentId:
                    return (a, b) => {
                        return a.departmentId.localeCompare(b.departmentId);
                    };
                case clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_UserStateId:
                    return (a, b) => {
                        return a.userStateId.localeCompare(b.userStateId);
                    };
                case clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_DepartmentName:
                    return (a, b) => {
                        return a.departmentName.localeCompare(b.departmentName);
                    };
                case clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_UserStateName:
                    return (a, b) => {
                        return a.userStateName.localeCompare(b.userStateName);
                    };
                case clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_IdentityDesc:
                    return (a, b) => {
                        return a.identityDesc.localeCompare(b.identityDesc);
                    };
                case clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_IdentityID:
                    return (a, b) => {
                        return a.identityID.localeCompare(b.identityID);
                    };
                case clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_StuTeacherID:
                    return (a, b) => {
                        return a.stuTeacherID.localeCompare(b.stuTeacherID);
                    };
                case clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_id_XzMajor:
                    return (a, b) => {
                        return a.id_XzMajor.localeCompare(b.id_XzMajor);
                    };
                case clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_CollegeName:
                    return (a, b) => {
                        return a.collegeName.localeCompare(b.collegeName);
                    };
                case clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_id_XzCollege:
                    return (a, b) => {
                        return a.id_XzCollege.localeCompare(b.id_XzCollege);
                    };
                case clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_MajorName:
                    return (a, b) => {
                        return a.majorName.localeCompare(b.majorName);
                    };
                case clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_Password:
                    return (a, b) => {
                        return a.password.localeCompare(b.password);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vQxUserRoleRelation]中不存在！(in ${exports.vQxUserRoleRelation_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_mId:
                    return (a, b) => {
                        return b.mId - a.mId;
                    };
                case clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_UserId:
                    return (a, b) => {
                        return b.userId.localeCompare(a.userId);
                    };
                case clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_RoleId:
                    return (a, b) => {
                        return b.roleId.localeCompare(a.roleId);
                    };
                case clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_QxPrjId:
                    return (a, b) => {
                        return b.qxPrjId.localeCompare(a.qxPrjId);
                    };
                case clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_Memo:
                    return (a, b) => {
                        return b.memo.localeCompare(a.memo);
                    };
                case clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_PrjName:
                    return (a, b) => {
                        return b.prjName.localeCompare(a.prjName);
                    };
                case clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_RoleName:
                    return (a, b) => {
                        return b.roleName.localeCompare(a.roleName);
                    };
                case clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_UserName:
                    return (a, b) => {
                        return b.userName.localeCompare(a.userName);
                    };
                case clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_DepartmentId:
                    return (a, b) => {
                        return b.departmentId.localeCompare(a.departmentId);
                    };
                case clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_UserStateId:
                    return (a, b) => {
                        return b.userStateId.localeCompare(a.userStateId);
                    };
                case clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_DepartmentName:
                    return (a, b) => {
                        return b.departmentName.localeCompare(a.departmentName);
                    };
                case clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_UserStateName:
                    return (a, b) => {
                        return b.userStateName.localeCompare(a.userStateName);
                    };
                case clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_IdentityDesc:
                    return (a, b) => {
                        return b.identityDesc.localeCompare(a.identityDesc);
                    };
                case clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_IdentityID:
                    return (a, b) => {
                        return b.identityID.localeCompare(a.identityID);
                    };
                case clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_StuTeacherID:
                    return (a, b) => {
                        return b.stuTeacherID.localeCompare(a.stuTeacherID);
                    };
                case clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_id_XzMajor:
                    return (a, b) => {
                        return b.id_XzMajor.localeCompare(a.id_XzMajor);
                    };
                case clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_CollegeName:
                    return (a, b) => {
                        return b.collegeName.localeCompare(a.collegeName);
                    };
                case clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_id_XzCollege:
                    return (a, b) => {
                        return b.id_XzCollege.localeCompare(a.id_XzCollege);
                    };
                case clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_MajorName:
                    return (a, b) => {
                        return b.majorName.localeCompare(a.majorName);
                    };
                case clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_Password:
                    return (a, b) => {
                        return b.password.localeCompare(a.password);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vQxUserRoleRelation]中不存在！(in ${exports.vQxUserRoleRelation_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.vQxUserRoleRelation_SortFunByKey = vQxUserRoleRelation_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function vQxUserRoleRelation_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_mId:
                return (obj) => {
                    return obj.mId === value;
                };
            case clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_UserId:
                return (obj) => {
                    return obj.userId === value;
                };
            case clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_RoleId:
                return (obj) => {
                    return obj.roleId === value;
                };
            case clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_QxPrjId:
                return (obj) => {
                    return obj.qxPrjId === value;
                };
            case clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            case clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_PrjName:
                return (obj) => {
                    return obj.prjName === value;
                };
            case clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_RoleName:
                return (obj) => {
                    return obj.roleName === value;
                };
            case clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_UserName:
                return (obj) => {
                    return obj.userName === value;
                };
            case clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_DepartmentId:
                return (obj) => {
                    return obj.departmentId === value;
                };
            case clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_UserStateId:
                return (obj) => {
                    return obj.userStateId === value;
                };
            case clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_DepartmentName:
                return (obj) => {
                    return obj.departmentName === value;
                };
            case clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_UserStateName:
                return (obj) => {
                    return obj.userStateName === value;
                };
            case clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_IdentityDesc:
                return (obj) => {
                    return obj.identityDesc === value;
                };
            case clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_IdentityID:
                return (obj) => {
                    return obj.identityID === value;
                };
            case clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_StuTeacherID:
                return (obj) => {
                    return obj.stuTeacherID === value;
                };
            case clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_id_XzMajor:
                return (obj) => {
                    return obj.id_XzMajor === value;
                };
            case clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_CollegeName:
                return (obj) => {
                    return obj.collegeName === value;
                };
            case clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_id_XzCollege:
                return (obj) => {
                    return obj.id_XzCollege === value;
                };
            case clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_MajorName:
                return (obj) => {
                    return obj.majorName === value;
                };
            case clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_Password:
                return (obj) => {
                    return obj.password === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[vQxUserRoleRelation]中不存在！(in ${exports.vQxUserRoleRelation_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.vQxUserRoleRelation_FilterFunByKey = vQxUserRoleRelation_FilterFunByKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function vQxUserRoleRelation_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vQxUserRoleRelation_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vQxUserRoleRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vQxUserRoleRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vQxUserRoleRelation_GetFirstIDAsync = vQxUserRoleRelation_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function vQxUserRoleRelation_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vQxUserRoleRelation_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vQxUserRoleRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vQxUserRoleRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vQxUserRoleRelation_GetFirstID = vQxUserRoleRelation_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function vQxUserRoleRelation_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vQxUserRoleRelation_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vQxUserRoleRelation_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objvQxUserRoleRelation = vQxUserRoleRelation_GetObjFromJsonObj(returnObj);
                return objvQxUserRoleRelation;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vQxUserRoleRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vQxUserRoleRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vQxUserRoleRelation_GetFirstObjAsync = vQxUserRoleRelation_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vQxUserRoleRelation_GetObjLst_ClientCache() {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN._CurrTabName;
        clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_2.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrvQxUserRoleRelationExObjLst_Cache = CacheHelper_js_2.CacheHelper.Get(strKey);
            const arrvQxUserRoleRelationObjLst_T = vQxUserRoleRelation_GetObjLstByJSONObjLst(arrvQxUserRoleRelationExObjLst_Cache);
            return arrvQxUserRoleRelationObjLst_T;
        }
        try {
            const arrvQxUserRoleRelationExObjLst = await vQxUserRoleRelation_GetObjLstAsync(strWhereCond);
            CacheHelper_js_2.CacheHelper.Add(strKey, arrvQxUserRoleRelationExObjLst);
            const strInfo = (0, clsString_js_1.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvQxUserRoleRelationExObjLst.length);
            console.log(strInfo);
            return arrvQxUserRoleRelationExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vQxUserRoleRelation_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vQxUserRoleRelation_GetObjLst_ClientCache = vQxUserRoleRelation_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vQxUserRoleRelation_GetObjLst_localStorage() {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN._CurrTabName;
        clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrvQxUserRoleRelationExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrvQxUserRoleRelationObjLst_T = vQxUserRoleRelation_GetObjLstByJSONObjLst(arrvQxUserRoleRelationExObjLst_Cache);
            return arrvQxUserRoleRelationObjLst_T;
        }
        try {
            const arrvQxUserRoleRelationExObjLst = await vQxUserRoleRelation_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrvQxUserRoleRelationExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvQxUserRoleRelationExObjLst.length);
            console.log(strInfo);
            return arrvQxUserRoleRelationExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vQxUserRoleRelation_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vQxUserRoleRelation_GetObjLst_localStorage = vQxUserRoleRelation_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vQxUserRoleRelation_GetObjLst_localStorage_PureCache() {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrvQxUserRoleRelationObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvQxUserRoleRelationObjLst_Cache;
        }
        else
            return null;
    }
    exports.vQxUserRoleRelation_GetObjLst_localStorage_PureCache = vQxUserRoleRelation_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function vQxUserRoleRelation_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vQxUserRoleRelation_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vQxUserRoleRelation_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vQxUserRoleRelation_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vQxUserRoleRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vQxUserRoleRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vQxUserRoleRelation_GetObjLstAsync = vQxUserRoleRelation_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vQxUserRoleRelation_GetObjLst_sessionStorage() {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN._CurrTabName;
        clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrvQxUserRoleRelationExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrvQxUserRoleRelationObjLst_T = vQxUserRoleRelation_GetObjLstByJSONObjLst(arrvQxUserRoleRelationExObjLst_Cache);
            return arrvQxUserRoleRelationObjLst_T;
        }
        try {
            const arrvQxUserRoleRelationExObjLst = await vQxUserRoleRelation_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrvQxUserRoleRelationExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvQxUserRoleRelationExObjLst.length);
            console.log(strInfo);
            return arrvQxUserRoleRelationExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vQxUserRoleRelation_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vQxUserRoleRelation_GetObjLst_sessionStorage = vQxUserRoleRelation_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vQxUserRoleRelation_GetObjLst_sessionStorage_PureCache() {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrvQxUserRoleRelationObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvQxUserRoleRelationObjLst_Cache;
        }
        else
            return null;
    }
    exports.vQxUserRoleRelation_GetObjLst_sessionStorage_PureCache = vQxUserRoleRelation_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vQxUserRoleRelation_GetObjLst_Cache() {
        //const strThisFuncName = "GetObjLst_Cache";
        let arrvQxUserRoleRelationObjLst_Cache;
        switch (clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.CacheModeId) {
            case "04": //sessionStorage
                arrvQxUserRoleRelationObjLst_Cache = await vQxUserRoleRelation_GetObjLst_sessionStorage();
                break;
            case "03": //localStorage
                arrvQxUserRoleRelationObjLst_Cache = await vQxUserRoleRelation_GetObjLst_localStorage();
                break;
            case "02": //ClientCache
                arrvQxUserRoleRelationObjLst_Cache = await vQxUserRoleRelation_GetObjLst_ClientCache();
                break;
            default:
                arrvQxUserRoleRelationObjLst_Cache = await vQxUserRoleRelation_GetObjLst_ClientCache();
                break;
        }
        const arrvQxUserRoleRelationObjLst = vQxUserRoleRelation_GetObjLstByJSONObjLst(arrvQxUserRoleRelationObjLst_Cache);
        return arrvQxUserRoleRelationObjLst_Cache;
    }
    exports.vQxUserRoleRelation_GetObjLst_Cache = vQxUserRoleRelation_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vQxUserRoleRelation_GetObjLst_PureCache() {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrvQxUserRoleRelationObjLst_Cache;
        switch (clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.CacheModeId) {
            case "04": //sessionStorage
                arrvQxUserRoleRelationObjLst_Cache = await vQxUserRoleRelation_GetObjLst_sessionStorage_PureCache();
                break;
            case "03": //localStorage
                arrvQxUserRoleRelationObjLst_Cache = await vQxUserRoleRelation_GetObjLst_localStorage_PureCache();
                break;
            case "02": //ClientCache
                arrvQxUserRoleRelationObjLst_Cache = null;
                break;
            default:
                arrvQxUserRoleRelationObjLst_Cache = null;
                break;
        }
        return arrvQxUserRoleRelationObjLst_Cache;
    }
    exports.vQxUserRoleRelation_GetObjLst_PureCache = vQxUserRoleRelation_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objlngmId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function vQxUserRoleRelation_GetSubObjLst_Cache(objvQxUserRoleRelation_Cond) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrvQxUserRoleRelationObjLst_Cache = await vQxUserRoleRelation_GetObjLst_Cache();
        let arrvQxUserRoleRelation_Sel = arrvQxUserRoleRelationObjLst_Cache;
        if (objvQxUserRoleRelation_Cond.sf_FldComparisonOp == null || objvQxUserRoleRelation_Cond.sf_FldComparisonOp == "")
            return arrvQxUserRoleRelation_Sel;
        const dicFldComparisonOp = JSON.parse(objvQxUserRoleRelation_Cond.sf_FldComparisonOp);
        //console.log("clsvQxUserRoleRelationWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvQxUserRoleRelation_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvQxUserRoleRelation_Sel = arrvQxUserRoleRelation_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvQxUserRoleRelation_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvQxUserRoleRelation_Sel = arrvQxUserRoleRelation_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvQxUserRoleRelation_Sel = arrvQxUserRoleRelation_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvQxUserRoleRelation_Sel = arrvQxUserRoleRelation_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvQxUserRoleRelation_Sel = arrvQxUserRoleRelation_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvQxUserRoleRelation_Sel = arrvQxUserRoleRelation_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvQxUserRoleRelation_Sel = arrvQxUserRoleRelation_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvQxUserRoleRelation_Sel = arrvQxUserRoleRelation_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvQxUserRoleRelation_Sel = arrvQxUserRoleRelation_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrvQxUserRoleRelation_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objvQxUserRoleRelation_Cond), exports.vQxUserRoleRelation_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vQxUserRoleRelation_GetSubObjLst_Cache = vQxUserRoleRelation_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrmId:关键字列表
    * @returns 对象列表
    **/
    async function vQxUserRoleRelation_GetObjLstBymIdLstAsync(arrmId) {
        const strThisFuncName = "GetObjLstBymIdLstAsync";
        const strAction = "GetObjLstBymIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vQxUserRoleRelation_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrmId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vQxUserRoleRelation_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vQxUserRoleRelation_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vQxUserRoleRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vQxUserRoleRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vQxUserRoleRelation_GetObjLstBymIdLstAsync = vQxUserRoleRelation_GetObjLstBymIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrlngmIdLst:关键字列表
     * @returns 对象列表
    */
    async function vQxUserRoleRelation_GetObjLstBymIdLst_Cache(arrmIdLst) {
        const strThisFuncName = "GetObjLstBymIdLst_Cache";
        try {
            const arrvQxUserRoleRelationObjLst_Cache = await vQxUserRoleRelation_GetObjLst_Cache();
            const arrvQxUserRoleRelation_Sel = arrvQxUserRoleRelationObjLst_Cache.filter(x => arrmIdLst.indexOf(x.mId) > -1);
            return arrvQxUserRoleRelation_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrmIdLst.join(","), exports.vQxUserRoleRelation_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vQxUserRoleRelation_GetObjLstBymIdLst_Cache = vQxUserRoleRelation_GetObjLstBymIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function vQxUserRoleRelation_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vQxUserRoleRelation_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vQxUserRoleRelation_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vQxUserRoleRelation_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vQxUserRoleRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vQxUserRoleRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vQxUserRoleRelation_GetTopObjLstAsync = vQxUserRoleRelation_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vQxUserRoleRelation_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vQxUserRoleRelation_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vQxUserRoleRelation_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vQxUserRoleRelation_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vQxUserRoleRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vQxUserRoleRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vQxUserRoleRelation_GetObjLstByRangeAsync = vQxUserRoleRelation_GetObjLstByRangeAsync;
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
    async function vQxUserRoleRelation_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vQxUserRoleRelation_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vQxUserRoleRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vQxUserRoleRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vQxUserRoleRelation_GetObjLstByRange = vQxUserRoleRelation_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function vQxUserRoleRelation_GetObjLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const arrvQxUserRoleRelationObjLst_Cache = await vQxUserRoleRelation_GetObjLst_Cache();
        if (arrvQxUserRoleRelationObjLst_Cache.length == 0)
            return arrvQxUserRoleRelationObjLst_Cache;
        let arrvQxUserRoleRelation_Sel = arrvQxUserRoleRelationObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objvQxUserRoleRelation_Cond = new clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvQxUserRoleRelation_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsvQxUserRoleRelationWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvQxUserRoleRelation_Sel = arrvQxUserRoleRelation_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvQxUserRoleRelation_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvQxUserRoleRelation_Sel = arrvQxUserRoleRelation_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvQxUserRoleRelation_Sel = arrvQxUserRoleRelation_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrvQxUserRoleRelation_Sel = arrvQxUserRoleRelation_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvQxUserRoleRelation_Sel = arrvQxUserRoleRelation_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvQxUserRoleRelation_Sel = arrvQxUserRoleRelation_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvQxUserRoleRelation_Sel = arrvQxUserRoleRelation_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvQxUserRoleRelation_Sel = arrvQxUserRoleRelation_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvQxUserRoleRelation_Sel = arrvQxUserRoleRelation_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvQxUserRoleRelation_Sel = arrvQxUserRoleRelation_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvQxUserRoleRelation_Sel.length == 0)
                return arrvQxUserRoleRelation_Sel;
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
                arrvQxUserRoleRelation_Sel = arrvQxUserRoleRelation_Sel.sort(vQxUserRoleRelation_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrvQxUserRoleRelation_Sel = arrvQxUserRoleRelation_Sel.sort(objPagerPara.sortFun);
            }
            arrvQxUserRoleRelation_Sel = arrvQxUserRoleRelation_Sel.slice(intStart, intEnd);
            return arrvQxUserRoleRelation_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.vQxUserRoleRelation_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vQxUserRoleRelation_GetObjLstByPager_Cache = vQxUserRoleRelation_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vQxUserRoleRelation_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vQxUserRoleRelation_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vQxUserRoleRelation_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vQxUserRoleRelation_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vQxUserRoleRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vQxUserRoleRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vQxUserRoleRelation_GetObjLstByPagerAsync = vQxUserRoleRelation_GetObjLstByPagerAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objlngmId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function vQxUserRoleRelation_IsExistRecord_Cache(objvQxUserRoleRelation_Cond) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrvQxUserRoleRelationObjLst_Cache = await vQxUserRoleRelation_GetObjLst_Cache();
        if (arrvQxUserRoleRelationObjLst_Cache == null)
            return false;
        let arrvQxUserRoleRelation_Sel = arrvQxUserRoleRelationObjLst_Cache;
        if (objvQxUserRoleRelation_Cond.sf_FldComparisonOp == null || objvQxUserRoleRelation_Cond.sf_FldComparisonOp == "")
            return arrvQxUserRoleRelation_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objvQxUserRoleRelation_Cond.sf_FldComparisonOp);
        //console.log("clsvQxUserRoleRelationWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvQxUserRoleRelation_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvQxUserRoleRelation_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvQxUserRoleRelation_Sel = arrvQxUserRoleRelation_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvQxUserRoleRelation_Sel = arrvQxUserRoleRelation_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvQxUserRoleRelation_Sel = arrvQxUserRoleRelation_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvQxUserRoleRelation_Sel = arrvQxUserRoleRelation_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvQxUserRoleRelation_Sel = arrvQxUserRoleRelation_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvQxUserRoleRelation_Sel = arrvQxUserRoleRelation_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvQxUserRoleRelation_Sel = arrvQxUserRoleRelation_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvQxUserRoleRelation_Sel = arrvQxUserRoleRelation_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvQxUserRoleRelation_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objvQxUserRoleRelation_Cond), exports.vQxUserRoleRelation_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.vQxUserRoleRelation_IsExistRecord_Cache = vQxUserRoleRelation_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function vQxUserRoleRelation_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vQxUserRoleRelation_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vQxUserRoleRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vQxUserRoleRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vQxUserRoleRelation_IsExistRecordAsync = vQxUserRoleRelation_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param lngmId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function vQxUserRoleRelation_IsExist(lngmId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vQxUserRoleRelation_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "mId": lngmId,
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vQxUserRoleRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vQxUserRoleRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vQxUserRoleRelation_IsExist = vQxUserRoleRelation_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param lngmId:所给的关键字
     * @returns 对象
    */
    async function vQxUserRoleRelation_IsExist_Cache(lngmId) {
        const strThisFuncName = "IsExist_Cache";
        const arrvQxUserRoleRelationObjLst_Cache = await vQxUserRoleRelation_GetObjLst_Cache();
        if (arrvQxUserRoleRelationObjLst_Cache == null)
            return false;
        try {
            const arrvQxUserRoleRelation_Sel = arrvQxUserRoleRelationObjLst_Cache.filter(x => x.mId == lngmId);
            if (arrvQxUserRoleRelation_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", lngmId, exports.vQxUserRoleRelation_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.vQxUserRoleRelation_IsExist_Cache = vQxUserRoleRelation_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param lngmId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function vQxUserRoleRelation_IsExistAsync(lngmId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vQxUserRoleRelation_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "lngmId": lngmId }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vQxUserRoleRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vQxUserRoleRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vQxUserRoleRelation_IsExistAsync = vQxUserRoleRelation_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function vQxUserRoleRelation_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vQxUserRoleRelation_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vQxUserRoleRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vQxUserRoleRelation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vQxUserRoleRelation_GetRecCountByCondAsync = vQxUserRoleRelation_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objvQxUserRoleRelation_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function vQxUserRoleRelation_GetRecCountByCond_Cache(objvQxUserRoleRelation_Cond) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrvQxUserRoleRelationObjLst_Cache = await vQxUserRoleRelation_GetObjLst_Cache();
        if (arrvQxUserRoleRelationObjLst_Cache == null)
            return 0;
        let arrvQxUserRoleRelation_Sel = arrvQxUserRoleRelationObjLst_Cache;
        if (objvQxUserRoleRelation_Cond.sf_FldComparisonOp == null || objvQxUserRoleRelation_Cond.sf_FldComparisonOp == "")
            return arrvQxUserRoleRelation_Sel.length;
        const dicFldComparisonOp = JSON.parse(objvQxUserRoleRelation_Cond.sf_FldComparisonOp);
        //console.log("clsvQxUserRoleRelationWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvQxUserRoleRelation_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvQxUserRoleRelation_Sel = arrvQxUserRoleRelation_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvQxUserRoleRelation_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvQxUserRoleRelation_Sel = arrvQxUserRoleRelation_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvQxUserRoleRelation_Sel = arrvQxUserRoleRelation_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrvQxUserRoleRelation_Sel = arrvQxUserRoleRelation_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvQxUserRoleRelation_Sel = arrvQxUserRoleRelation_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvQxUserRoleRelation_Sel = arrvQxUserRoleRelation_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvQxUserRoleRelation_Sel = arrvQxUserRoleRelation_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvQxUserRoleRelation_Sel = arrvQxUserRoleRelation_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvQxUserRoleRelation_Sel = arrvQxUserRoleRelation_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvQxUserRoleRelation_Sel = arrvQxUserRoleRelation_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrvQxUserRoleRelation_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objvQxUserRoleRelation_Cond), exports.vQxUserRoleRelation_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.vQxUserRoleRelation_GetRecCountByCond_Cache = vQxUserRoleRelation_GetRecCountByCond_Cache;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function vQxUserRoleRelation_GetWebApiUrl(strController, strAction) {
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
    exports.vQxUserRoleRelation_GetWebApiUrl = vQxUserRoleRelation_GetWebApiUrl;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function vQxUserRoleRelation_ReFreshThisCache() {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN._CurrTabName;
            switch (clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.CacheModeId) {
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
    exports.vQxUserRoleRelation_ReFreshThisCache = vQxUserRoleRelation_ReFreshThisCache;
    /* 该表的下拉框功能没有设置，不需要生成下拉框绑定函数。*/
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vQxUserRoleRelation_GetJSONStrByObj(pobjvQxUserRoleRelationEN) {
        const strThisFuncName = "GetJSONStrByObj";
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjvQxUserRoleRelationEN);
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
    exports.vQxUserRoleRelation_GetJSONStrByObj = vQxUserRoleRelation_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function vQxUserRoleRelation_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrvQxUserRoleRelationObjLst = new Array();
        if (strJSON === "") {
            return arrvQxUserRoleRelationObjLst;
        }
        try {
            arrvQxUserRoleRelationObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrvQxUserRoleRelationObjLst;
        }
        return arrvQxUserRoleRelationObjLst;
    }
    exports.vQxUserRoleRelation_GetObjLstByJSONStr = vQxUserRoleRelation_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrvQxUserRoleRelationObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function vQxUserRoleRelation_GetObjLstByJSONObjLst(arrvQxUserRoleRelationObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrvQxUserRoleRelationObjLst = new Array();
        for (const objInFor of arrvQxUserRoleRelationObjLstS) {
            const obj1 = vQxUserRoleRelation_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrvQxUserRoleRelationObjLst.push(obj1);
        }
        return arrvQxUserRoleRelationObjLst;
    }
    exports.vQxUserRoleRelation_GetObjLstByJSONObjLst = vQxUserRoleRelation_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vQxUserRoleRelation_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjvQxUserRoleRelationEN = new clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN();
        if (strJSON === "") {
            return pobjvQxUserRoleRelationEN;
        }
        try {
            pobjvQxUserRoleRelationEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjvQxUserRoleRelationEN;
        }
        return pobjvQxUserRoleRelationEN;
    }
    exports.vQxUserRoleRelation_GetObjByJSONStr = vQxUserRoleRelation_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function vQxUserRoleRelation_GetCombineCondition(objvQxUserRoleRelation_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objvQxUserRoleRelation_Cond.dicFldComparisonOp, clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_mId) == true) {
            const strComparisonOp_mId = objvQxUserRoleRelation_Cond.dicFldComparisonOp[clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_mId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_mId, objvQxUserRoleRelation_Cond.mId, strComparisonOp_mId);
        }
        if (Object.prototype.hasOwnProperty.call(objvQxUserRoleRelation_Cond.dicFldComparisonOp, clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_UserId) == true) {
            const strComparisonOp_UserId = objvQxUserRoleRelation_Cond.dicFldComparisonOp[clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_UserId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_UserId, objvQxUserRoleRelation_Cond.userId, strComparisonOp_UserId);
        }
        if (Object.prototype.hasOwnProperty.call(objvQxUserRoleRelation_Cond.dicFldComparisonOp, clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_RoleId) == true) {
            const strComparisonOp_RoleId = objvQxUserRoleRelation_Cond.dicFldComparisonOp[clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_RoleId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_RoleId, objvQxUserRoleRelation_Cond.roleId, strComparisonOp_RoleId);
        }
        if (Object.prototype.hasOwnProperty.call(objvQxUserRoleRelation_Cond.dicFldComparisonOp, clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_QxPrjId) == true) {
            const strComparisonOp_QxPrjId = objvQxUserRoleRelation_Cond.dicFldComparisonOp[clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_QxPrjId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_QxPrjId, objvQxUserRoleRelation_Cond.qxPrjId, strComparisonOp_QxPrjId);
        }
        if (Object.prototype.hasOwnProperty.call(objvQxUserRoleRelation_Cond.dicFldComparisonOp, clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_Memo) == true) {
            const strComparisonOp_Memo = objvQxUserRoleRelation_Cond.dicFldComparisonOp[clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_Memo, objvQxUserRoleRelation_Cond.memo, strComparisonOp_Memo);
        }
        if (Object.prototype.hasOwnProperty.call(objvQxUserRoleRelation_Cond.dicFldComparisonOp, clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_PrjName) == true) {
            const strComparisonOp_PrjName = objvQxUserRoleRelation_Cond.dicFldComparisonOp[clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_PrjName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_PrjName, objvQxUserRoleRelation_Cond.prjName, strComparisonOp_PrjName);
        }
        if (Object.prototype.hasOwnProperty.call(objvQxUserRoleRelation_Cond.dicFldComparisonOp, clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_RoleName) == true) {
            const strComparisonOp_RoleName = objvQxUserRoleRelation_Cond.dicFldComparisonOp[clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_RoleName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_RoleName, objvQxUserRoleRelation_Cond.roleName, strComparisonOp_RoleName);
        }
        if (Object.prototype.hasOwnProperty.call(objvQxUserRoleRelation_Cond.dicFldComparisonOp, clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_UserName) == true) {
            const strComparisonOp_UserName = objvQxUserRoleRelation_Cond.dicFldComparisonOp[clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_UserName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_UserName, objvQxUserRoleRelation_Cond.userName, strComparisonOp_UserName);
        }
        if (Object.prototype.hasOwnProperty.call(objvQxUserRoleRelation_Cond.dicFldComparisonOp, clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_DepartmentId) == true) {
            const strComparisonOp_DepartmentId = objvQxUserRoleRelation_Cond.dicFldComparisonOp[clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_DepartmentId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_DepartmentId, objvQxUserRoleRelation_Cond.departmentId, strComparisonOp_DepartmentId);
        }
        if (Object.prototype.hasOwnProperty.call(objvQxUserRoleRelation_Cond.dicFldComparisonOp, clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_UserStateId) == true) {
            const strComparisonOp_UserStateId = objvQxUserRoleRelation_Cond.dicFldComparisonOp[clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_UserStateId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_UserStateId, objvQxUserRoleRelation_Cond.userStateId, strComparisonOp_UserStateId);
        }
        if (Object.prototype.hasOwnProperty.call(objvQxUserRoleRelation_Cond.dicFldComparisonOp, clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_DepartmentName) == true) {
            const strComparisonOp_DepartmentName = objvQxUserRoleRelation_Cond.dicFldComparisonOp[clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_DepartmentName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_DepartmentName, objvQxUserRoleRelation_Cond.departmentName, strComparisonOp_DepartmentName);
        }
        if (Object.prototype.hasOwnProperty.call(objvQxUserRoleRelation_Cond.dicFldComparisonOp, clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_UserStateName) == true) {
            const strComparisonOp_UserStateName = objvQxUserRoleRelation_Cond.dicFldComparisonOp[clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_UserStateName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_UserStateName, objvQxUserRoleRelation_Cond.userStateName, strComparisonOp_UserStateName);
        }
        if (Object.prototype.hasOwnProperty.call(objvQxUserRoleRelation_Cond.dicFldComparisonOp, clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_IdentityDesc) == true) {
            const strComparisonOp_IdentityDesc = objvQxUserRoleRelation_Cond.dicFldComparisonOp[clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_IdentityDesc];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_IdentityDesc, objvQxUserRoleRelation_Cond.identityDesc, strComparisonOp_IdentityDesc);
        }
        if (Object.prototype.hasOwnProperty.call(objvQxUserRoleRelation_Cond.dicFldComparisonOp, clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_IdentityID) == true) {
            const strComparisonOp_IdentityID = objvQxUserRoleRelation_Cond.dicFldComparisonOp[clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_IdentityID];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_IdentityID, objvQxUserRoleRelation_Cond.identityID, strComparisonOp_IdentityID);
        }
        if (Object.prototype.hasOwnProperty.call(objvQxUserRoleRelation_Cond.dicFldComparisonOp, clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_StuTeacherID) == true) {
            const strComparisonOp_StuTeacherID = objvQxUserRoleRelation_Cond.dicFldComparisonOp[clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_StuTeacherID];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_StuTeacherID, objvQxUserRoleRelation_Cond.stuTeacherID, strComparisonOp_StuTeacherID);
        }
        if (Object.prototype.hasOwnProperty.call(objvQxUserRoleRelation_Cond.dicFldComparisonOp, clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_id_XzMajor) == true) {
            const strComparisonOp_id_XzMajor = objvQxUserRoleRelation_Cond.dicFldComparisonOp[clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_id_XzMajor];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_id_XzMajor, objvQxUserRoleRelation_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
        }
        if (Object.prototype.hasOwnProperty.call(objvQxUserRoleRelation_Cond.dicFldComparisonOp, clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_CollegeName) == true) {
            const strComparisonOp_CollegeName = objvQxUserRoleRelation_Cond.dicFldComparisonOp[clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_CollegeName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_CollegeName, objvQxUserRoleRelation_Cond.collegeName, strComparisonOp_CollegeName);
        }
        if (Object.prototype.hasOwnProperty.call(objvQxUserRoleRelation_Cond.dicFldComparisonOp, clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_id_XzCollege) == true) {
            const strComparisonOp_id_XzCollege = objvQxUserRoleRelation_Cond.dicFldComparisonOp[clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_id_XzCollege];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_id_XzCollege, objvQxUserRoleRelation_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
        }
        if (Object.prototype.hasOwnProperty.call(objvQxUserRoleRelation_Cond.dicFldComparisonOp, clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_MajorName) == true) {
            const strComparisonOp_MajorName = objvQxUserRoleRelation_Cond.dicFldComparisonOp[clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_MajorName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_MajorName, objvQxUserRoleRelation_Cond.majorName, strComparisonOp_MajorName);
        }
        if (Object.prototype.hasOwnProperty.call(objvQxUserRoleRelation_Cond.dicFldComparisonOp, clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_Password) == true) {
            const strComparisonOp_Password = objvQxUserRoleRelation_Cond.dicFldComparisonOp[clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_Password];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN.con_Password, objvQxUserRoleRelation_Cond.password, strComparisonOp_Password);
        }
        return strWhereCond;
    }
    exports.vQxUserRoleRelation_GetCombineCondition = vQxUserRoleRelation_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--vQxUserRoleRelation(vQx用户角色关系),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param lngmId: mId(要求唯一的字段)
    * @param strUserId: 用户ID(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function vQxUserRoleRelation_GetUniCondStr_mId_UserId(objvQxUserRoleRelationEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and mId = '{0}'", objvQxUserRoleRelationEN.mId);
        strWhereCond += (0, clsString_js_1.Format)(" and UserId = '{0}'", objvQxUserRoleRelationEN.userId);
        return strWhereCond;
    }
    exports.vQxUserRoleRelation_GetUniCondStr_mId_UserId = vQxUserRoleRelation_GetUniCondStr_mId_UserId;
    /**
    *获取唯一性条件串(Uniqueness)--vQxUserRoleRelation(vQx用户角色关系),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param lngmId: mId(要求唯一的字段)
    * @param strUserId: 用户ID(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function vQxUserRoleRelation_GetUniCondStr4Update_mId_UserId(objvQxUserRoleRelationEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and mId <> '{0}'", objvQxUserRoleRelationEN.mId);
        strWhereCond += (0, clsString_js_1.Format)(" and mId = '{0}'", objvQxUserRoleRelationEN.mId);
        strWhereCond += (0, clsString_js_1.Format)(" and UserId = '{0}'", objvQxUserRoleRelationEN.userId);
        return strWhereCond;
    }
    exports.vQxUserRoleRelation_GetUniCondStr4Update_mId_UserId = vQxUserRoleRelation_GetUniCondStr4Update_mId_UserId;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objvQxUserRoleRelationENS:源对象
     * @param objvQxUserRoleRelationENT:目标对象
    */
    function vQxUserRoleRelation_CopyObjTo(objvQxUserRoleRelationENS, objvQxUserRoleRelationENT) {
        objvQxUserRoleRelationENT.mId = objvQxUserRoleRelationENS.mId; //mId
        objvQxUserRoleRelationENT.userId = objvQxUserRoleRelationENS.userId; //用户ID
        objvQxUserRoleRelationENT.roleId = objvQxUserRoleRelationENS.roleId; //角色Id
        objvQxUserRoleRelationENT.qxPrjId = objvQxUserRoleRelationENS.qxPrjId; //QxPrjId
        objvQxUserRoleRelationENT.memo = objvQxUserRoleRelationENS.memo; //备注
        objvQxUserRoleRelationENT.prjName = objvQxUserRoleRelationENS.prjName; //PrjName
        objvQxUserRoleRelationENT.roleName = objvQxUserRoleRelationENS.roleName; //角色名
        objvQxUserRoleRelationENT.userName = objvQxUserRoleRelationENS.userName; //用户名
        objvQxUserRoleRelationENT.departmentId = objvQxUserRoleRelationENS.departmentId; //部门Id
        objvQxUserRoleRelationENT.userStateId = objvQxUserRoleRelationENS.userStateId; //用户状态Id
        objvQxUserRoleRelationENT.departmentName = objvQxUserRoleRelationENS.departmentName; //部门名称
        objvQxUserRoleRelationENT.userStateName = objvQxUserRoleRelationENS.userStateName; //用户状态名
        objvQxUserRoleRelationENT.identityDesc = objvQxUserRoleRelationENS.identityDesc; //身份描述
        objvQxUserRoleRelationENT.identityID = objvQxUserRoleRelationENS.identityID; //身份编号
        objvQxUserRoleRelationENT.stuTeacherID = objvQxUserRoleRelationENS.stuTeacherID; //学工号
        objvQxUserRoleRelationENT.id_XzMajor = objvQxUserRoleRelationENS.id_XzMajor; //专业流水号
        objvQxUserRoleRelationENT.collegeName = objvQxUserRoleRelationENS.collegeName; //学院名称
        objvQxUserRoleRelationENT.id_XzCollege = objvQxUserRoleRelationENS.id_XzCollege; //学院流水号
        objvQxUserRoleRelationENT.majorName = objvQxUserRoleRelationENS.majorName; //专业名称
        objvQxUserRoleRelationENT.password = objvQxUserRoleRelationENS.password; //Password
    }
    exports.vQxUserRoleRelation_CopyObjTo = vQxUserRoleRelation_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objvQxUserRoleRelationENS:源对象
     * @param objvQxUserRoleRelationENT:目标对象
    */
    function vQxUserRoleRelation_GetObjFromJsonObj(objvQxUserRoleRelationENS) {
        const objvQxUserRoleRelationENT = new clsvQxUserRoleRelationEN_js_1.clsvQxUserRoleRelationEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvQxUserRoleRelationENT, objvQxUserRoleRelationENS);
        return objvQxUserRoleRelationENT;
    }
    exports.vQxUserRoleRelation_GetObjFromJsonObj = vQxUserRoleRelation_GetObjFromJsonObj;
});
