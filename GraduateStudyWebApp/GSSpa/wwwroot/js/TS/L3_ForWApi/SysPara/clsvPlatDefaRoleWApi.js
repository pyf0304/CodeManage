/**
* 类名:clsvPlatDefaRoleWApi
* 表名:vPlatDefaRole(01120232)
* 生成代码版本:2022.11.02.1
* 生成日期:2022/11/02 12:02:20
* 生成者:pyf
* 生成服务器IP:
工程名称:问卷调查(0112)
CM工程:研究生论文学习(变量首字母小写)-全部函数集
* 相关数据库:103.116.76.183,9433EduHigh_Jsie
* PrjDataBaseId:0170
模块中文名:系统参数(SysPara)
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
        define(["require", "exports", "axios", "../../L0_Entity/SysPara/clsvPlatDefaRoleEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsSysPara4WebApi.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.vPlatDefaRole_GetObjFromJsonObj = exports.vPlatDefaRole_CopyObjTo = exports.vPlatDefaRole_GetCombineCondition = exports.vPlatDefaRole_GetObjByJSONStr = exports.vPlatDefaRole_GetObjLstByJSONObjLst = exports.vPlatDefaRole_GetObjLstByJSONStr = exports.vPlatDefaRole_GetJSONStrByObj = exports.vPlatDefaRole_GetWebApiUrl = exports.vPlatDefaRole_GetRecCountByCondAsync = exports.vPlatDefaRole_IsExistAsync = exports.vPlatDefaRole_IsExist = exports.vPlatDefaRole_IsExistRecordAsync = exports.vPlatDefaRole_GetObjLstByPagerAsync = exports.vPlatDefaRole_GetObjLstByRange = exports.vPlatDefaRole_GetObjLstByRangeAsync = exports.vPlatDefaRole_GetTopObjLstAsync = exports.vPlatDefaRole_GetObjLstBymIdLstAsync = exports.vPlatDefaRole_GetObjLstAsync = exports.vPlatDefaRole_GetFirstObjAsync = exports.vPlatDefaRole_GetFirstID = exports.vPlatDefaRole_GetFirstIDAsync = exports.vPlatDefaRole_FilterFunByKey = exports.vPlatDefaRole_SortFunByKey = exports.vPlatDefaRole_SortFun_Defa_2Fld = exports.vPlatDefaRole_SortFun_Defa = exports.vPlatDefaRole_GetObjBymIdAsync = exports.vPlatDefaRole_ConstructorName = exports.vPlatDefaRole_Controller = void 0;
    /**
     * v平台默认角色(vPlatDefaRole)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2022年11月02日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const clsvPlatDefaRoleEN_js_1 = require("../../L0_Entity/SysPara/clsvPlatDefaRoleEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.vPlatDefaRole_Controller = "vPlatDefaRoleApi";
    exports.vPlatDefaRole_ConstructorName = "vPlatDefaRole";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param lngmId:关键字
    * @returns 对象
    **/
    async function vPlatDefaRole_GetObjBymIdAsync(lngmId) {
        const strThisFuncName = "GetObjBymIdAsync";
        if (lngmId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngmId]不能为空！(In GetObjBymIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjBymId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPlatDefaRole_Controller, strAction);
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
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vPlatDefaRole_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objvPlatDefaRole = vPlatDefaRole_GetObjFromJsonObj(returnObj);
                return objvPlatDefaRole;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPlatDefaRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPlatDefaRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPlatDefaRole_GetObjBymIdAsync = vPlatDefaRole_GetObjBymIdAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vPlatDefaRole_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.mId - b.mId;
    }
    exports.vPlatDefaRole_SortFun_Defa = vPlatDefaRole_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vPlatDefaRole_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.id_School == b.id_School)
            return a.schoolId.localeCompare(b.schoolId);
        else
            return a.id_School.localeCompare(b.id_School);
    }
    exports.vPlatDefaRole_SortFun_Defa_2Fld = vPlatDefaRole_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vPlatDefaRole_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsvPlatDefaRoleEN_js_1.clsvPlatDefaRoleEN.con_mId:
                    return (a, b) => {
                        return a.mId - b.mId;
                    };
                case clsvPlatDefaRoleEN_js_1.clsvPlatDefaRoleEN.con_id_School:
                    return (a, b) => {
                        return a.id_School.localeCompare(b.id_School);
                    };
                case clsvPlatDefaRoleEN_js_1.clsvPlatDefaRoleEN.con_SchoolId:
                    return (a, b) => {
                        return a.schoolId.localeCompare(b.schoolId);
                    };
                case clsvPlatDefaRoleEN_js_1.clsvPlatDefaRoleEN.con_IsCurrentUse:
                    return (a, b) => {
                        if (a.isCurrentUse == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvPlatDefaRoleEN_js_1.clsvPlatDefaRoleEN.con_SchoolName:
                    return (a, b) => {
                        return a.schoolName.localeCompare(b.schoolName);
                    };
                case clsvPlatDefaRoleEN_js_1.clsvPlatDefaRoleEN.con_PersonType:
                    return (a, b) => {
                        return a.personType.localeCompare(b.personType);
                    };
                case clsvPlatDefaRoleEN_js_1.clsvPlatDefaRoleEN.con_PrjId:
                    return (a, b) => {
                        return a.prjId.localeCompare(b.prjId);
                    };
                case clsvPlatDefaRoleEN_js_1.clsvPlatDefaRoleEN.con_RoleId:
                    return (a, b) => {
                        return a.roleId.localeCompare(b.roleId);
                    };
                case clsvPlatDefaRoleEN_js_1.clsvPlatDefaRoleEN.con_Memo:
                    return (a, b) => {
                        return a.memo.localeCompare(b.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vPlatDefaRole]中不存在！(in ${exports.vPlatDefaRole_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsvPlatDefaRoleEN_js_1.clsvPlatDefaRoleEN.con_mId:
                    return (a, b) => {
                        return b.mId - a.mId;
                    };
                case clsvPlatDefaRoleEN_js_1.clsvPlatDefaRoleEN.con_id_School:
                    return (a, b) => {
                        return b.id_School.localeCompare(a.id_School);
                    };
                case clsvPlatDefaRoleEN_js_1.clsvPlatDefaRoleEN.con_SchoolId:
                    return (a, b) => {
                        return b.schoolId.localeCompare(a.schoolId);
                    };
                case clsvPlatDefaRoleEN_js_1.clsvPlatDefaRoleEN.con_IsCurrentUse:
                    return (a, b) => {
                        if (b.isCurrentUse == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvPlatDefaRoleEN_js_1.clsvPlatDefaRoleEN.con_SchoolName:
                    return (a, b) => {
                        return b.schoolName.localeCompare(a.schoolName);
                    };
                case clsvPlatDefaRoleEN_js_1.clsvPlatDefaRoleEN.con_PersonType:
                    return (a, b) => {
                        return b.personType.localeCompare(a.personType);
                    };
                case clsvPlatDefaRoleEN_js_1.clsvPlatDefaRoleEN.con_PrjId:
                    return (a, b) => {
                        return b.prjId.localeCompare(a.prjId);
                    };
                case clsvPlatDefaRoleEN_js_1.clsvPlatDefaRoleEN.con_RoleId:
                    return (a, b) => {
                        return b.roleId.localeCompare(a.roleId);
                    };
                case clsvPlatDefaRoleEN_js_1.clsvPlatDefaRoleEN.con_Memo:
                    return (a, b) => {
                        return b.memo.localeCompare(a.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vPlatDefaRole]中不存在！(in ${exports.vPlatDefaRole_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.vPlatDefaRole_SortFunByKey = vPlatDefaRole_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function vPlatDefaRole_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsvPlatDefaRoleEN_js_1.clsvPlatDefaRoleEN.con_mId:
                return (obj) => {
                    return obj.mId === value;
                };
            case clsvPlatDefaRoleEN_js_1.clsvPlatDefaRoleEN.con_id_School:
                return (obj) => {
                    return obj.id_School === value;
                };
            case clsvPlatDefaRoleEN_js_1.clsvPlatDefaRoleEN.con_SchoolId:
                return (obj) => {
                    return obj.schoolId === value;
                };
            case clsvPlatDefaRoleEN_js_1.clsvPlatDefaRoleEN.con_IsCurrentUse:
                return (obj) => {
                    return obj.isCurrentUse === value;
                };
            case clsvPlatDefaRoleEN_js_1.clsvPlatDefaRoleEN.con_SchoolName:
                return (obj) => {
                    return obj.schoolName === value;
                };
            case clsvPlatDefaRoleEN_js_1.clsvPlatDefaRoleEN.con_PersonType:
                return (obj) => {
                    return obj.personType === value;
                };
            case clsvPlatDefaRoleEN_js_1.clsvPlatDefaRoleEN.con_PrjId:
                return (obj) => {
                    return obj.prjId === value;
                };
            case clsvPlatDefaRoleEN_js_1.clsvPlatDefaRoleEN.con_RoleId:
                return (obj) => {
                    return obj.roleId === value;
                };
            case clsvPlatDefaRoleEN_js_1.clsvPlatDefaRoleEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[vPlatDefaRole]中不存在！(in ${exports.vPlatDefaRole_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.vPlatDefaRole_FilterFunByKey = vPlatDefaRole_FilterFunByKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function vPlatDefaRole_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPlatDefaRole_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPlatDefaRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPlatDefaRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPlatDefaRole_GetFirstIDAsync = vPlatDefaRole_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function vPlatDefaRole_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPlatDefaRole_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPlatDefaRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPlatDefaRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPlatDefaRole_GetFirstID = vPlatDefaRole_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function vPlatDefaRole_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPlatDefaRole_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vPlatDefaRole_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objvPlatDefaRole = vPlatDefaRole_GetObjFromJsonObj(returnObj);
                return objvPlatDefaRole;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPlatDefaRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPlatDefaRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPlatDefaRole_GetFirstObjAsync = vPlatDefaRole_GetFirstObjAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function vPlatDefaRole_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPlatDefaRole_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vPlatDefaRole_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vPlatDefaRole_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPlatDefaRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPlatDefaRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPlatDefaRole_GetObjLstAsync = vPlatDefaRole_GetObjLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrmId:关键字列表
    * @returns 对象列表
    **/
    async function vPlatDefaRole_GetObjLstBymIdLstAsync(arrmId) {
        const strThisFuncName = "GetObjLstBymIdLstAsync";
        const strAction = "GetObjLstBymIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPlatDefaRole_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrmId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vPlatDefaRole_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vPlatDefaRole_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPlatDefaRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPlatDefaRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPlatDefaRole_GetObjLstBymIdLstAsync = vPlatDefaRole_GetObjLstBymIdLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function vPlatDefaRole_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPlatDefaRole_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vPlatDefaRole_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vPlatDefaRole_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPlatDefaRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPlatDefaRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPlatDefaRole_GetTopObjLstAsync = vPlatDefaRole_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vPlatDefaRole_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPlatDefaRole_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vPlatDefaRole_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vPlatDefaRole_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPlatDefaRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPlatDefaRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPlatDefaRole_GetObjLstByRangeAsync = vPlatDefaRole_GetObjLstByRangeAsync;
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
    async function vPlatDefaRole_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPlatDefaRole_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPlatDefaRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPlatDefaRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPlatDefaRole_GetObjLstByRange = vPlatDefaRole_GetObjLstByRange;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vPlatDefaRole_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPlatDefaRole_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vPlatDefaRole_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vPlatDefaRole_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPlatDefaRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPlatDefaRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPlatDefaRole_GetObjLstByPagerAsync = vPlatDefaRole_GetObjLstByPagerAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function vPlatDefaRole_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPlatDefaRole_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPlatDefaRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPlatDefaRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPlatDefaRole_IsExistRecordAsync = vPlatDefaRole_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param lngmId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function vPlatDefaRole_IsExist(lngmId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPlatDefaRole_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPlatDefaRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPlatDefaRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPlatDefaRole_IsExist = vPlatDefaRole_IsExist;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param lngmId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function vPlatDefaRole_IsExistAsync(lngmId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPlatDefaRole_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPlatDefaRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPlatDefaRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPlatDefaRole_IsExistAsync = vPlatDefaRole_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function vPlatDefaRole_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPlatDefaRole_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPlatDefaRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPlatDefaRole_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPlatDefaRole_GetRecCountByCondAsync = vPlatDefaRole_GetRecCountByCondAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function vPlatDefaRole_GetWebApiUrl(strController, strAction) {
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
    exports.vPlatDefaRole_GetWebApiUrl = vPlatDefaRole_GetWebApiUrl;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vPlatDefaRole_GetJSONStrByObj(pobjvPlatDefaRoleEN) {
        const strThisFuncName = "GetJSONStrByObj";
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjvPlatDefaRoleEN);
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
    exports.vPlatDefaRole_GetJSONStrByObj = vPlatDefaRole_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function vPlatDefaRole_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrvPlatDefaRoleObjLst = new Array();
        if (strJSON === "") {
            return arrvPlatDefaRoleObjLst;
        }
        try {
            arrvPlatDefaRoleObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrvPlatDefaRoleObjLst;
        }
        return arrvPlatDefaRoleObjLst;
    }
    exports.vPlatDefaRole_GetObjLstByJSONStr = vPlatDefaRole_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrvPlatDefaRoleObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function vPlatDefaRole_GetObjLstByJSONObjLst(arrvPlatDefaRoleObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrvPlatDefaRoleObjLst = new Array();
        for (const objInFor of arrvPlatDefaRoleObjLstS) {
            const obj1 = vPlatDefaRole_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrvPlatDefaRoleObjLst.push(obj1);
        }
        return arrvPlatDefaRoleObjLst;
    }
    exports.vPlatDefaRole_GetObjLstByJSONObjLst = vPlatDefaRole_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vPlatDefaRole_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjvPlatDefaRoleEN = new clsvPlatDefaRoleEN_js_1.clsvPlatDefaRoleEN();
        if (strJSON === "") {
            return pobjvPlatDefaRoleEN;
        }
        try {
            pobjvPlatDefaRoleEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjvPlatDefaRoleEN;
        }
        return pobjvPlatDefaRoleEN;
    }
    exports.vPlatDefaRole_GetObjByJSONStr = vPlatDefaRole_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function vPlatDefaRole_GetCombineCondition(objvPlatDefaRole_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objvPlatDefaRole_Cond.dicFldComparisonOp, clsvPlatDefaRoleEN_js_1.clsvPlatDefaRoleEN.con_mId) == true) {
            const strComparisonOp_mId = objvPlatDefaRole_Cond.dicFldComparisonOp[clsvPlatDefaRoleEN_js_1.clsvPlatDefaRoleEN.con_mId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvPlatDefaRoleEN_js_1.clsvPlatDefaRoleEN.con_mId, objvPlatDefaRole_Cond.mId, strComparisonOp_mId);
        }
        if (Object.prototype.hasOwnProperty.call(objvPlatDefaRole_Cond.dicFldComparisonOp, clsvPlatDefaRoleEN_js_1.clsvPlatDefaRoleEN.con_id_School) == true) {
            const strComparisonOp_id_School = objvPlatDefaRole_Cond.dicFldComparisonOp[clsvPlatDefaRoleEN_js_1.clsvPlatDefaRoleEN.con_id_School];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPlatDefaRoleEN_js_1.clsvPlatDefaRoleEN.con_id_School, objvPlatDefaRole_Cond.id_School, strComparisonOp_id_School);
        }
        if (Object.prototype.hasOwnProperty.call(objvPlatDefaRole_Cond.dicFldComparisonOp, clsvPlatDefaRoleEN_js_1.clsvPlatDefaRoleEN.con_SchoolId) == true) {
            const strComparisonOp_SchoolId = objvPlatDefaRole_Cond.dicFldComparisonOp[clsvPlatDefaRoleEN_js_1.clsvPlatDefaRoleEN.con_SchoolId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPlatDefaRoleEN_js_1.clsvPlatDefaRoleEN.con_SchoolId, objvPlatDefaRole_Cond.schoolId, strComparisonOp_SchoolId);
        }
        if (Object.prototype.hasOwnProperty.call(objvPlatDefaRole_Cond.dicFldComparisonOp, clsvPlatDefaRoleEN_js_1.clsvPlatDefaRoleEN.con_IsCurrentUse) == true) {
            if (objvPlatDefaRole_Cond.isCurrentUse == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvPlatDefaRoleEN_js_1.clsvPlatDefaRoleEN.con_IsCurrentUse);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvPlatDefaRoleEN_js_1.clsvPlatDefaRoleEN.con_IsCurrentUse);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvPlatDefaRole_Cond.dicFldComparisonOp, clsvPlatDefaRoleEN_js_1.clsvPlatDefaRoleEN.con_SchoolName) == true) {
            const strComparisonOp_SchoolName = objvPlatDefaRole_Cond.dicFldComparisonOp[clsvPlatDefaRoleEN_js_1.clsvPlatDefaRoleEN.con_SchoolName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPlatDefaRoleEN_js_1.clsvPlatDefaRoleEN.con_SchoolName, objvPlatDefaRole_Cond.schoolName, strComparisonOp_SchoolName);
        }
        if (Object.prototype.hasOwnProperty.call(objvPlatDefaRole_Cond.dicFldComparisonOp, clsvPlatDefaRoleEN_js_1.clsvPlatDefaRoleEN.con_PersonType) == true) {
            const strComparisonOp_PersonType = objvPlatDefaRole_Cond.dicFldComparisonOp[clsvPlatDefaRoleEN_js_1.clsvPlatDefaRoleEN.con_PersonType];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPlatDefaRoleEN_js_1.clsvPlatDefaRoleEN.con_PersonType, objvPlatDefaRole_Cond.personType, strComparisonOp_PersonType);
        }
        if (Object.prototype.hasOwnProperty.call(objvPlatDefaRole_Cond.dicFldComparisonOp, clsvPlatDefaRoleEN_js_1.clsvPlatDefaRoleEN.con_PrjId) == true) {
            const strComparisonOp_PrjId = objvPlatDefaRole_Cond.dicFldComparisonOp[clsvPlatDefaRoleEN_js_1.clsvPlatDefaRoleEN.con_PrjId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPlatDefaRoleEN_js_1.clsvPlatDefaRoleEN.con_PrjId, objvPlatDefaRole_Cond.prjId, strComparisonOp_PrjId);
        }
        if (Object.prototype.hasOwnProperty.call(objvPlatDefaRole_Cond.dicFldComparisonOp, clsvPlatDefaRoleEN_js_1.clsvPlatDefaRoleEN.con_RoleId) == true) {
            const strComparisonOp_RoleId = objvPlatDefaRole_Cond.dicFldComparisonOp[clsvPlatDefaRoleEN_js_1.clsvPlatDefaRoleEN.con_RoleId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPlatDefaRoleEN_js_1.clsvPlatDefaRoleEN.con_RoleId, objvPlatDefaRole_Cond.roleId, strComparisonOp_RoleId);
        }
        if (Object.prototype.hasOwnProperty.call(objvPlatDefaRole_Cond.dicFldComparisonOp, clsvPlatDefaRoleEN_js_1.clsvPlatDefaRoleEN.con_Memo) == true) {
            const strComparisonOp_Memo = objvPlatDefaRole_Cond.dicFldComparisonOp[clsvPlatDefaRoleEN_js_1.clsvPlatDefaRoleEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPlatDefaRoleEN_js_1.clsvPlatDefaRoleEN.con_Memo, objvPlatDefaRole_Cond.memo, strComparisonOp_Memo);
        }
        return strWhereCond;
    }
    exports.vPlatDefaRole_GetCombineCondition = vPlatDefaRole_GetCombineCondition;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objvPlatDefaRoleENS:源对象
     * @param objvPlatDefaRoleENT:目标对象
    */
    function vPlatDefaRole_CopyObjTo(objvPlatDefaRoleENS, objvPlatDefaRoleENT) {
        objvPlatDefaRoleENT.mId = objvPlatDefaRoleENS.mId; //mId
        objvPlatDefaRoleENT.id_School = objvPlatDefaRoleENS.id_School; //学校流水号
        objvPlatDefaRoleENT.schoolId = objvPlatDefaRoleENS.schoolId; //学校编号
        objvPlatDefaRoleENT.isCurrentUse = objvPlatDefaRoleENS.isCurrentUse; //是否当前使用
        objvPlatDefaRoleENT.schoolName = objvPlatDefaRoleENS.schoolName; //学校名称
        objvPlatDefaRoleENT.personType = objvPlatDefaRoleENS.personType; //人员类别
        objvPlatDefaRoleENT.prjId = objvPlatDefaRoleENS.prjId; //PrjId
        objvPlatDefaRoleENT.roleId = objvPlatDefaRoleENS.roleId; //角色Id
        objvPlatDefaRoleENT.memo = objvPlatDefaRoleENS.memo; //备注
    }
    exports.vPlatDefaRole_CopyObjTo = vPlatDefaRole_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objvPlatDefaRoleENS:源对象
     * @param objvPlatDefaRoleENT:目标对象
    */
    function vPlatDefaRole_GetObjFromJsonObj(objvPlatDefaRoleENS) {
        const objvPlatDefaRoleENT = new clsvPlatDefaRoleEN_js_1.clsvPlatDefaRoleEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvPlatDefaRoleENT, objvPlatDefaRoleENS);
        return objvPlatDefaRoleENT;
    }
    exports.vPlatDefaRole_GetObjFromJsonObj = vPlatDefaRole_GetObjFromJsonObj;
});
