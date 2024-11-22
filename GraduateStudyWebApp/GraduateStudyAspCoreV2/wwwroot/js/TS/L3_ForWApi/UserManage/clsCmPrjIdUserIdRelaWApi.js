/**
* 类名:clsCmPrjIdUserIdRelaWApi
* 表名:CmPrjIdUserIdRela(01120946)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/13 00:44:28
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
        define(["require", "exports", "axios", "../../L0_Entity/UserManage/clsCmPrjIdUserIdRelaEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.CmPrjIdUserIdRela_GetObjFromJsonObj = exports.CmPrjIdUserIdRela_CopyObjTo = exports.CmPrjIdUserIdRela_GetCombineCondition = exports.CmPrjIdUserIdRela_GetObjByJSONStr = exports.CmPrjIdUserIdRela_GetObjLstByJSONObjLst = exports.CmPrjIdUserIdRela_GetObjLstByJSONStr = exports.CmPrjIdUserIdRela_GetJSONStrByObj = exports.CmPrjIdUserIdRela_CheckProperty4Update = exports.CmPrjIdUserIdRela_CheckPropertyNew = exports.CmPrjIdUserIdRela_GetWebApiUrl = exports.CmPrjIdUserIdRela_GetMaxStrIdByPrefix = exports.CmPrjIdUserIdRela_GetRecCountByCondAsync = exports.CmPrjIdUserIdRela_IsExistAsync = exports.CmPrjIdUserIdRela_IsExist = exports.CmPrjIdUserIdRela_IsExistRecordAsync = exports.CmPrjIdUserIdRela_UpdateWithConditionAsync = exports.CmPrjIdUserIdRela_UpdateRecordAsync = exports.CmPrjIdUserIdRela_AddNewRecordWithReturnKey = exports.CmPrjIdUserIdRela_AddNewRecordWithReturnKeyAsync = exports.CmPrjIdUserIdRela_AddNewRecordWithMaxIdAsync = exports.CmPrjIdUserIdRela_AddNewRecordAsync = exports.CmPrjIdUserIdRela_DelCmPrjIdUserIdRelasByCondAsync = exports.CmPrjIdUserIdRela_DelRecKeyLstsAsync = exports.CmPrjIdUserIdRela_DelRecKeyLstAsync = exports.CmPrjIdUserIdRela_GetObjLstByPagerAsync = exports.CmPrjIdUserIdRela_GetObjLstByRange = exports.CmPrjIdUserIdRela_GetObjLstByRangeAsync = exports.CmPrjIdUserIdRela_GetTopObjLstAsync = exports.CmPrjIdUserIdRela_GetObjLstAsync = exports.CmPrjIdUserIdRela_GetFirstObjAsync = exports.CmPrjIdUserIdRela_GetFirstID = exports.CmPrjIdUserIdRela_GetFirstIDAsync = exports.CmPrjIdUserIdRela_FilterFunByKey = exports.CmPrjIdUserIdRela_SortFunByKey = exports.CmPrjIdUserIdRela_SortFun_Defa_2Fld = exports.CmPrjIdUserIdRela_SortFun_Defa = exports.CmPrjIdUserIdRela_GetObjByKeyLstAsync = exports.CmPrjIdUserIdRela_SplitKeyLst = exports.cmPrjIdUserIdRela_ConstructorName = exports.cmPrjIdUserIdRela_Controller = void 0;
    /**
     * Cm项目Id用户关系(CmPrjIdUserIdRela)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月13日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const clsCmPrjIdUserIdRelaEN_js_1 = require("../../L0_Entity/UserManage/clsCmPrjIdUserIdRelaEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsString_js_2 = require("../../PubFun/clsString.js");
    exports.cmPrjIdUserIdRela_Controller = "CmPrjIdUserIdRelaApi";
    exports.cmPrjIdUserIdRela_ConstructorName = "cmPrjIdUserIdRela";
    /**
    * 把多关键字值分解为单独关键字的值，并且以对象形式返回
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strKeyLst:多关键字值
    * @returns 分解后的单独关键字值对象
    **/
    function CmPrjIdUserIdRela_SplitKeyLst(strKeyLst) {
        const arrKey = strKeyLst.split('|');
        if (arrKey.length != 2) {
            const strMsg = "请选择需要修改的记录！";
            console.error(strMsg);
            alert(strMsg);
            throw (strMsg);
        }
        const objKeyLst = {
            cmPrjId: arrKey[0],
            userId: arrKey[1],
        };
        if ((0, clsString_js_2.IsNullOrEmpty)(objKeyLst.cmPrjId) == true) {
            const strMsg = "关键字段(cmPrjId)值不能为空！";
            console.error(strMsg);
            alert(strMsg);
            throw (strMsg);
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(objKeyLst.userId) == true) {
            const strMsg = "关键字段(userId)值不能为空！";
            console.error(strMsg);
            alert(strMsg);
            throw (strMsg);
        }
        return objKeyLst;
    }
    exports.CmPrjIdUserIdRela_SplitKeyLst = CmPrjIdUserIdRela_SplitKeyLst;
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strCmPrjId:关键字
    * @returns 对象
    **/
    async function CmPrjIdUserIdRela_GetObjByKeyLstAsync(strCmPrjId, strUserId) {
        const strThisFuncName = "GetObjByKeyLstAsync";
        if ((0, clsString_js_2.IsNullOrEmpty)(strCmPrjId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strCmPrjId]不能为空！(In clsCmPrjIdUserIdRelaWApi.GetObjByKeyLstAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strCmPrjId.length != 6) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strCmPrjId]的长度:[{0}]不正确！(clsCmPrjIdUserIdRelaWApi.GetObjByKeyLstAsync)", strCmPrjId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(strUserId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strUserId]不能为空！(In clsCmPrjIdUserIdRelaWApi.GetObjByKeyLstAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByKeyLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cmPrjIdUserIdRela_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "strCmPrjId": strCmPrjId,
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
                const objCmPrjIdUserIdRela = CmPrjIdUserIdRela_GetObjFromJsonObj(returnObj);
                return objCmPrjIdUserIdRela;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cmPrjIdUserIdRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cmPrjIdUserIdRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CmPrjIdUserIdRela_GetObjByKeyLstAsync = CmPrjIdUserIdRela_GetObjByKeyLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function CmPrjIdUserIdRela_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.cmPrjId.localeCompare(b.cmPrjId);
    }
    exports.CmPrjIdUserIdRela_SortFun_Defa = CmPrjIdUserIdRela_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function CmPrjIdUserIdRela_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.updDate == b.updDate)
            return a.updUser.localeCompare(b.updUser);
        else
            return a.updDate.localeCompare(b.updDate);
    }
    exports.CmPrjIdUserIdRela_SortFun_Defa_2Fld = CmPrjIdUserIdRela_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function CmPrjIdUserIdRela_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsCmPrjIdUserIdRelaEN_js_1.clsCmPrjIdUserIdRelaEN.con_CmPrjId:
                    return (a, b) => {
                        return a.cmPrjId.localeCompare(b.cmPrjId);
                    };
                case clsCmPrjIdUserIdRelaEN_js_1.clsCmPrjIdUserIdRelaEN.con_UserId:
                    return (a, b) => {
                        return a.userId.localeCompare(b.userId);
                    };
                case clsCmPrjIdUserIdRelaEN_js_1.clsCmPrjIdUserIdRelaEN.con_UpdDate:
                    return (a, b) => {
                        if (a.updDate == null)
                            return -1;
                        if (b.updDate == null)
                            return 1;
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsCmPrjIdUserIdRelaEN_js_1.clsCmPrjIdUserIdRelaEN.con_UpdUser:
                    return (a, b) => {
                        if (a.updUser == null)
                            return -1;
                        if (b.updUser == null)
                            return 1;
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsCmPrjIdUserIdRelaEN_js_1.clsCmPrjIdUserIdRelaEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[CmPrjIdUserIdRela]中不存在！(in ${exports.cmPrjIdUserIdRela_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsCmPrjIdUserIdRelaEN_js_1.clsCmPrjIdUserIdRelaEN.con_CmPrjId:
                    return (a, b) => {
                        return b.cmPrjId.localeCompare(a.cmPrjId);
                    };
                case clsCmPrjIdUserIdRelaEN_js_1.clsCmPrjIdUserIdRelaEN.con_UserId:
                    return (a, b) => {
                        return b.userId.localeCompare(a.userId);
                    };
                case clsCmPrjIdUserIdRelaEN_js_1.clsCmPrjIdUserIdRelaEN.con_UpdDate:
                    return (a, b) => {
                        if (b.updDate == null)
                            return -1;
                        if (a.updDate == null)
                            return 1;
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsCmPrjIdUserIdRelaEN_js_1.clsCmPrjIdUserIdRelaEN.con_UpdUser:
                    return (a, b) => {
                        if (b.updUser == null)
                            return -1;
                        if (a.updUser == null)
                            return 1;
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsCmPrjIdUserIdRelaEN_js_1.clsCmPrjIdUserIdRelaEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[CmPrjIdUserIdRela]中不存在！(in ${exports.cmPrjIdUserIdRela_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.CmPrjIdUserIdRela_SortFunByKey = CmPrjIdUserIdRela_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function CmPrjIdUserIdRela_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsCmPrjIdUserIdRelaEN_js_1.clsCmPrjIdUserIdRelaEN.con_CmPrjId:
                return (obj) => {
                    return obj.cmPrjId === value;
                };
            case clsCmPrjIdUserIdRelaEN_js_1.clsCmPrjIdUserIdRelaEN.con_UserId:
                return (obj) => {
                    return obj.userId === value;
                };
            case clsCmPrjIdUserIdRelaEN_js_1.clsCmPrjIdUserIdRelaEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsCmPrjIdUserIdRelaEN_js_1.clsCmPrjIdUserIdRelaEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsCmPrjIdUserIdRelaEN_js_1.clsCmPrjIdUserIdRelaEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[CmPrjIdUserIdRela]中不存在！(in ${exports.cmPrjIdUserIdRela_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.CmPrjIdUserIdRela_FilterFunByKey = CmPrjIdUserIdRela_FilterFunByKey;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function CmPrjIdUserIdRela_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cmPrjIdUserIdRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cmPrjIdUserIdRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cmPrjIdUserIdRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CmPrjIdUserIdRela_GetFirstIDAsync = CmPrjIdUserIdRela_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function CmPrjIdUserIdRela_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cmPrjIdUserIdRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cmPrjIdUserIdRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cmPrjIdUserIdRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CmPrjIdUserIdRela_GetFirstID = CmPrjIdUserIdRela_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function CmPrjIdUserIdRela_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cmPrjIdUserIdRela_Controller, strAction);
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
                const objCmPrjIdUserIdRela = CmPrjIdUserIdRela_GetObjFromJsonObj(returnObj);
                return objCmPrjIdUserIdRela;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cmPrjIdUserIdRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cmPrjIdUserIdRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CmPrjIdUserIdRela_GetFirstObjAsync = CmPrjIdUserIdRela_GetFirstObjAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function CmPrjIdUserIdRela_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cmPrjIdUserIdRela_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.cmPrjIdUserIdRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = CmPrjIdUserIdRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cmPrjIdUserIdRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cmPrjIdUserIdRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CmPrjIdUserIdRela_GetObjLstAsync = CmPrjIdUserIdRela_GetObjLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function CmPrjIdUserIdRela_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cmPrjIdUserIdRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.cmPrjIdUserIdRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = CmPrjIdUserIdRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cmPrjIdUserIdRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cmPrjIdUserIdRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CmPrjIdUserIdRela_GetTopObjLstAsync = CmPrjIdUserIdRela_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function CmPrjIdUserIdRela_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cmPrjIdUserIdRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.cmPrjIdUserIdRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = CmPrjIdUserIdRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cmPrjIdUserIdRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cmPrjIdUserIdRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CmPrjIdUserIdRela_GetObjLstByRangeAsync = CmPrjIdUserIdRela_GetObjLstByRangeAsync;
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
    async function CmPrjIdUserIdRela_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cmPrjIdUserIdRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cmPrjIdUserIdRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cmPrjIdUserIdRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CmPrjIdUserIdRela_GetObjLstByRange = CmPrjIdUserIdRela_GetObjLstByRange;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function CmPrjIdUserIdRela_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cmPrjIdUserIdRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.cmPrjIdUserIdRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = CmPrjIdUserIdRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cmPrjIdUserIdRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cmPrjIdUserIdRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CmPrjIdUserIdRela_GetObjLstByPagerAsync = CmPrjIdUserIdRela_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param strCmPrjId,strUserId:关键字列表
    * @returns 获取删除的结果
    **/
    async function CmPrjIdUserIdRela_DelRecKeyLstAsync(strCmPrjId, strUserId) {
        const strThisFuncName = "DelRecKeyLstAsync";
        const strAction = "DelRecKeyLst";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cmPrjIdUserIdRela_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "CmPrjId": strCmPrjId,
                    "UserId": strUserId,
                }
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cmPrjIdUserIdRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cmPrjIdUserIdRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CmPrjIdUserIdRela_DelRecKeyLstAsync = CmPrjIdUserIdRela_DelRecKeyLstAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrKeyLsts:关键字列表, 关键字是多个字段的组合
    * @returns 实际删除记录的个数
    **/
    async function CmPrjIdUserIdRela_DelRecKeyLstsAsync(arrKeyLsts) {
        const strThisFuncName = "DelRecKeyLstsAsync";
        const strAction = "DelRecKeyLsts";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cmPrjIdUserIdRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrKeyLsts);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cmPrjIdUserIdRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cmPrjIdUserIdRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CmPrjIdUserIdRela_DelRecKeyLstsAsync = CmPrjIdUserIdRela_DelRecKeyLstsAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function CmPrjIdUserIdRela_DelCmPrjIdUserIdRelasByCondAsync(strWhereCond) {
        const strThisFuncName = "DelCmPrjIdUserIdRelasByCondAsync";
        const strAction = "DelCmPrjIdUserIdRelasByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cmPrjIdUserIdRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cmPrjIdUserIdRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cmPrjIdUserIdRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CmPrjIdUserIdRela_DelCmPrjIdUserIdRelasByCondAsync = CmPrjIdUserIdRela_DelCmPrjIdUserIdRelasByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objCmPrjIdUserIdRelaEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function CmPrjIdUserIdRela_AddNewRecordAsync(objCmPrjIdUserIdRelaEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        if (objCmPrjIdUserIdRelaEN.cmPrjId === null || objCmPrjIdUserIdRelaEN.cmPrjId === "") {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            throw strMsg;
        }
        //var strJSON = JSON.stringify(objCmPrjIdUserIdRelaEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cmPrjIdUserIdRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objCmPrjIdUserIdRelaEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cmPrjIdUserIdRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cmPrjIdUserIdRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CmPrjIdUserIdRela_AddNewRecordAsync = CmPrjIdUserIdRela_AddNewRecordAsync;
    /**
    * 调用WebApi来添加记录，关键字用最大关键字，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithMaxIdAsync)
    * @param objCmPrjIdUserIdRelaEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function CmPrjIdUserIdRela_AddNewRecordWithMaxIdAsync(objCmPrjIdUserIdRelaEN) {
        const strThisFuncName = "AddNewRecordWithMaxIdAsync";
        const strAction = "AddNewRecordWithMaxId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cmPrjIdUserIdRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objCmPrjIdUserIdRelaEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cmPrjIdUserIdRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cmPrjIdUserIdRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CmPrjIdUserIdRela_AddNewRecordWithMaxIdAsync = CmPrjIdUserIdRela_AddNewRecordWithMaxIdAsync;
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objCmPrjIdUserIdRelaEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function CmPrjIdUserIdRela_AddNewRecordWithReturnKeyAsync(objCmPrjIdUserIdRelaEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cmPrjIdUserIdRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objCmPrjIdUserIdRelaEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cmPrjIdUserIdRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cmPrjIdUserIdRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CmPrjIdUserIdRela_AddNewRecordWithReturnKeyAsync = CmPrjIdUserIdRela_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objCmPrjIdUserIdRelaEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function CmPrjIdUserIdRela_AddNewRecordWithReturnKey(objCmPrjIdUserIdRelaEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objCmPrjIdUserIdRelaEN.cmPrjId === null || objCmPrjIdUserIdRelaEN.cmPrjId === "") {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cmPrjIdUserIdRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objCmPrjIdUserIdRelaEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cmPrjIdUserIdRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cmPrjIdUserIdRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CmPrjIdUserIdRela_AddNewRecordWithReturnKey = CmPrjIdUserIdRela_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objCmPrjIdUserIdRelaEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function CmPrjIdUserIdRela_UpdateRecordAsync(objCmPrjIdUserIdRelaEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objCmPrjIdUserIdRelaEN.sf_UpdFldSetStr === undefined || objCmPrjIdUserIdRelaEN.sf_UpdFldSetStr === null || objCmPrjIdUserIdRelaEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objCmPrjIdUserIdRelaEN.cmPrjId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cmPrjIdUserIdRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objCmPrjIdUserIdRelaEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cmPrjIdUserIdRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cmPrjIdUserIdRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CmPrjIdUserIdRela_UpdateRecordAsync = CmPrjIdUserIdRela_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objCmPrjIdUserIdRelaEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function CmPrjIdUserIdRela_UpdateWithConditionAsync(objCmPrjIdUserIdRelaEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objCmPrjIdUserIdRelaEN.sf_UpdFldSetStr === undefined || objCmPrjIdUserIdRelaEN.sf_UpdFldSetStr === null || objCmPrjIdUserIdRelaEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objCmPrjIdUserIdRelaEN.cmPrjId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cmPrjIdUserIdRela_Controller, strAction);
        objCmPrjIdUserIdRelaEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objCmPrjIdUserIdRelaEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cmPrjIdUserIdRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cmPrjIdUserIdRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CmPrjIdUserIdRela_UpdateWithConditionAsync = CmPrjIdUserIdRela_UpdateWithConditionAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function CmPrjIdUserIdRela_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cmPrjIdUserIdRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cmPrjIdUserIdRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cmPrjIdUserIdRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CmPrjIdUserIdRela_IsExistRecordAsync = CmPrjIdUserIdRela_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strCmPrjId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function CmPrjIdUserIdRela_IsExist(strCmPrjId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cmPrjIdUserIdRela_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "CmPrjId": strCmPrjId,
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cmPrjIdUserIdRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cmPrjIdUserIdRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CmPrjIdUserIdRela_IsExist = CmPrjIdUserIdRela_IsExist;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strCmPrjId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function CmPrjIdUserIdRela_IsExistAsync(strCmPrjId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cmPrjIdUserIdRela_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strCmPrjId": strCmPrjId }
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cmPrjIdUserIdRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cmPrjIdUserIdRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CmPrjIdUserIdRela_IsExistAsync = CmPrjIdUserIdRela_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function CmPrjIdUserIdRela_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cmPrjIdUserIdRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cmPrjIdUserIdRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cmPrjIdUserIdRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CmPrjIdUserIdRela_GetRecCountByCondAsync = CmPrjIdUserIdRela_GetRecCountByCondAsync;
    //该表在前台TypeScript中，不需要使用Cache;
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
    async function CmPrjIdUserIdRela_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cmPrjIdUserIdRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cmPrjIdUserIdRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cmPrjIdUserIdRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CmPrjIdUserIdRela_GetMaxStrIdByPrefix = CmPrjIdUserIdRela_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function CmPrjIdUserIdRela_GetWebApiUrl(strController, strAction) {
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
    exports.CmPrjIdUserIdRela_GetWebApiUrl = CmPrjIdUserIdRela_GetWebApiUrl;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function CmPrjIdUserIdRela_CheckPropertyNew(pobjCmPrjIdUserIdRelaEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCmPrjIdUserIdRelaEN.cmPrjId) == false && (0, clsString_js_2.GetStrLen)(pobjCmPrjIdUserIdRelaEN.cmPrjId) > 6) {
            throw new Error("(errid:Watl000059)字段[CM工程Id(cmPrjId)]的长度不能超过6(In Cm项目Id用户关系(CmPrjIdUserIdRela))!值:$(pobjCmPrjIdUserIdRelaEN.cmPrjId)(clsCmPrjIdUserIdRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCmPrjIdUserIdRelaEN.userId) == false && (0, clsString_js_2.GetStrLen)(pobjCmPrjIdUserIdRelaEN.userId) > 18) {
            throw new Error("(errid:Watl000059)字段[用户ID(userId)]的长度不能超过18(In Cm项目Id用户关系(CmPrjIdUserIdRela))!值:$(pobjCmPrjIdUserIdRelaEN.userId)(clsCmPrjIdUserIdRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCmPrjIdUserIdRelaEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjCmPrjIdUserIdRelaEN.updDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In Cm项目Id用户关系(CmPrjIdUserIdRela))!值:$(pobjCmPrjIdUserIdRelaEN.updDate)(clsCmPrjIdUserIdRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCmPrjIdUserIdRelaEN.updUser) == false && (0, clsString_js_2.GetStrLen)(pobjCmPrjIdUserIdRelaEN.updUser) > 20) {
            throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In Cm项目Id用户关系(CmPrjIdUserIdRela))!值:$(pobjCmPrjIdUserIdRelaEN.updUser)(clsCmPrjIdUserIdRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCmPrjIdUserIdRelaEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjCmPrjIdUserIdRelaEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In Cm项目Id用户关系(CmPrjIdUserIdRela))!值:$(pobjCmPrjIdUserIdRelaEN.memo)(clsCmPrjIdUserIdRelaBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCmPrjIdUserIdRelaEN.cmPrjId) == false && undefined !== pobjCmPrjIdUserIdRelaEN.cmPrjId && clsString_js_1.tzDataType.isString(pobjCmPrjIdUserIdRelaEN.cmPrjId) === false) {
            throw new Error("(errid:Watl000060)字段[CM工程Id(cmPrjId)]的值:[$(pobjCmPrjIdUserIdRelaEN.cmPrjId)], 非法，应该为字符型(In Cm项目Id用户关系(CmPrjIdUserIdRela))!(clsCmPrjIdUserIdRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCmPrjIdUserIdRelaEN.userId) == false && undefined !== pobjCmPrjIdUserIdRelaEN.userId && clsString_js_1.tzDataType.isString(pobjCmPrjIdUserIdRelaEN.userId) === false) {
            throw new Error("(errid:Watl000060)字段[用户ID(userId)]的值:[$(pobjCmPrjIdUserIdRelaEN.userId)], 非法，应该为字符型(In Cm项目Id用户关系(CmPrjIdUserIdRela))!(clsCmPrjIdUserIdRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCmPrjIdUserIdRelaEN.updDate) == false && undefined !== pobjCmPrjIdUserIdRelaEN.updDate && clsString_js_1.tzDataType.isString(pobjCmPrjIdUserIdRelaEN.updDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjCmPrjIdUserIdRelaEN.updDate)], 非法，应该为字符型(In Cm项目Id用户关系(CmPrjIdUserIdRela))!(clsCmPrjIdUserIdRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCmPrjIdUserIdRelaEN.updUser) == false && undefined !== pobjCmPrjIdUserIdRelaEN.updUser && clsString_js_1.tzDataType.isString(pobjCmPrjIdUserIdRelaEN.updUser) === false) {
            throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjCmPrjIdUserIdRelaEN.updUser)], 非法，应该为字符型(In Cm项目Id用户关系(CmPrjIdUserIdRela))!(clsCmPrjIdUserIdRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCmPrjIdUserIdRelaEN.memo) == false && undefined !== pobjCmPrjIdUserIdRelaEN.memo && clsString_js_1.tzDataType.isString(pobjCmPrjIdUserIdRelaEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjCmPrjIdUserIdRelaEN.memo)], 非法，应该为字符型(In Cm项目Id用户关系(CmPrjIdUserIdRela))!(clsCmPrjIdUserIdRelaBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjCmPrjIdUserIdRelaEN.SetIsCheckProperty(true);
    }
    exports.CmPrjIdUserIdRela_CheckPropertyNew = CmPrjIdUserIdRela_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function CmPrjIdUserIdRela_CheckProperty4Update(pobjCmPrjIdUserIdRelaEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCmPrjIdUserIdRelaEN.cmPrjId) == false && (0, clsString_js_2.GetStrLen)(pobjCmPrjIdUserIdRelaEN.cmPrjId) > 6) {
            throw new Error("(errid:Watl000062)字段[CM工程Id(cmPrjId)]的长度不能超过6(In Cm项目Id用户关系(CmPrjIdUserIdRela))!值:$(pobjCmPrjIdUserIdRelaEN.cmPrjId)(clsCmPrjIdUserIdRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCmPrjIdUserIdRelaEN.userId) == false && (0, clsString_js_2.GetStrLen)(pobjCmPrjIdUserIdRelaEN.userId) > 18) {
            throw new Error("(errid:Watl000062)字段[用户ID(userId)]的长度不能超过18(In Cm项目Id用户关系(CmPrjIdUserIdRela))!值:$(pobjCmPrjIdUserIdRelaEN.userId)(clsCmPrjIdUserIdRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCmPrjIdUserIdRelaEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjCmPrjIdUserIdRelaEN.updDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In Cm项目Id用户关系(CmPrjIdUserIdRela))!值:$(pobjCmPrjIdUserIdRelaEN.updDate)(clsCmPrjIdUserIdRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCmPrjIdUserIdRelaEN.updUser) == false && (0, clsString_js_2.GetStrLen)(pobjCmPrjIdUserIdRelaEN.updUser) > 20) {
            throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In Cm项目Id用户关系(CmPrjIdUserIdRela))!值:$(pobjCmPrjIdUserIdRelaEN.updUser)(clsCmPrjIdUserIdRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCmPrjIdUserIdRelaEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjCmPrjIdUserIdRelaEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In Cm项目Id用户关系(CmPrjIdUserIdRela))!值:$(pobjCmPrjIdUserIdRelaEN.memo)(clsCmPrjIdUserIdRelaBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCmPrjIdUserIdRelaEN.cmPrjId) == false && undefined !== pobjCmPrjIdUserIdRelaEN.cmPrjId && clsString_js_1.tzDataType.isString(pobjCmPrjIdUserIdRelaEN.cmPrjId) === false) {
            throw new Error("(errid:Watl000063)字段[CM工程Id(cmPrjId)]的值:[$(pobjCmPrjIdUserIdRelaEN.cmPrjId)], 非法，应该为字符型(In Cm项目Id用户关系(CmPrjIdUserIdRela))!(clsCmPrjIdUserIdRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCmPrjIdUserIdRelaEN.userId) == false && undefined !== pobjCmPrjIdUserIdRelaEN.userId && clsString_js_1.tzDataType.isString(pobjCmPrjIdUserIdRelaEN.userId) === false) {
            throw new Error("(errid:Watl000063)字段[用户ID(userId)]的值:[$(pobjCmPrjIdUserIdRelaEN.userId)], 非法，应该为字符型(In Cm项目Id用户关系(CmPrjIdUserIdRela))!(clsCmPrjIdUserIdRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCmPrjIdUserIdRelaEN.updDate) == false && undefined !== pobjCmPrjIdUserIdRelaEN.updDate && clsString_js_1.tzDataType.isString(pobjCmPrjIdUserIdRelaEN.updDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjCmPrjIdUserIdRelaEN.updDate)], 非法，应该为字符型(In Cm项目Id用户关系(CmPrjIdUserIdRela))!(clsCmPrjIdUserIdRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCmPrjIdUserIdRelaEN.updUser) == false && undefined !== pobjCmPrjIdUserIdRelaEN.updUser && clsString_js_1.tzDataType.isString(pobjCmPrjIdUserIdRelaEN.updUser) === false) {
            throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjCmPrjIdUserIdRelaEN.updUser)], 非法，应该为字符型(In Cm项目Id用户关系(CmPrjIdUserIdRela))!(clsCmPrjIdUserIdRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCmPrjIdUserIdRelaEN.memo) == false && undefined !== pobjCmPrjIdUserIdRelaEN.memo && clsString_js_1.tzDataType.isString(pobjCmPrjIdUserIdRelaEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjCmPrjIdUserIdRelaEN.memo)], 非法，应该为字符型(In Cm项目Id用户关系(CmPrjIdUserIdRela))!(clsCmPrjIdUserIdRelaBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjCmPrjIdUserIdRelaEN.cmPrjId) === true) {
            throw new Error("(errid:Watl000064)字段[CM工程Id]不能为空(In Cm项目Id用户关系)!(clsCmPrjIdUserIdRelaBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjCmPrjIdUserIdRelaEN.SetIsCheckProperty(true);
    }
    exports.CmPrjIdUserIdRela_CheckProperty4Update = CmPrjIdUserIdRela_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function CmPrjIdUserIdRela_GetJSONStrByObj(pobjCmPrjIdUserIdRelaEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjCmPrjIdUserIdRelaEN.sf_UpdFldSetStr = pobjCmPrjIdUserIdRelaEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjCmPrjIdUserIdRelaEN);
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
    exports.CmPrjIdUserIdRela_GetJSONStrByObj = CmPrjIdUserIdRela_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function CmPrjIdUserIdRela_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrCmPrjIdUserIdRelaObjLst = new Array();
        if (strJSON === "") {
            return arrCmPrjIdUserIdRelaObjLst;
        }
        try {
            arrCmPrjIdUserIdRelaObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrCmPrjIdUserIdRelaObjLst;
        }
        return arrCmPrjIdUserIdRelaObjLst;
    }
    exports.CmPrjIdUserIdRela_GetObjLstByJSONStr = CmPrjIdUserIdRela_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrCmPrjIdUserIdRelaObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function CmPrjIdUserIdRela_GetObjLstByJSONObjLst(arrCmPrjIdUserIdRelaObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrCmPrjIdUserIdRelaObjLst = new Array();
        for (const objInFor of arrCmPrjIdUserIdRelaObjLstS) {
            const obj1 = CmPrjIdUserIdRela_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrCmPrjIdUserIdRelaObjLst.push(obj1);
        }
        return arrCmPrjIdUserIdRelaObjLst;
    }
    exports.CmPrjIdUserIdRela_GetObjLstByJSONObjLst = CmPrjIdUserIdRela_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function CmPrjIdUserIdRela_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjCmPrjIdUserIdRelaEN = new clsCmPrjIdUserIdRelaEN_js_1.clsCmPrjIdUserIdRelaEN();
        if (strJSON === "") {
            return pobjCmPrjIdUserIdRelaEN;
        }
        try {
            pobjCmPrjIdUserIdRelaEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjCmPrjIdUserIdRelaEN;
        }
        return pobjCmPrjIdUserIdRelaEN;
    }
    exports.CmPrjIdUserIdRela_GetObjByJSONStr = CmPrjIdUserIdRela_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function CmPrjIdUserIdRela_GetCombineCondition(objCmPrjIdUserIdRela_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objCmPrjIdUserIdRela_Cond.dicFldComparisonOp, clsCmPrjIdUserIdRelaEN_js_1.clsCmPrjIdUserIdRelaEN.con_CmPrjId) == true) {
            const strComparisonOp_CmPrjId = objCmPrjIdUserIdRela_Cond.dicFldComparisonOp[clsCmPrjIdUserIdRelaEN_js_1.clsCmPrjIdUserIdRelaEN.con_CmPrjId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsCmPrjIdUserIdRelaEN_js_1.clsCmPrjIdUserIdRelaEN.con_CmPrjId, objCmPrjIdUserIdRela_Cond.cmPrjId, strComparisonOp_CmPrjId);
        }
        if (Object.prototype.hasOwnProperty.call(objCmPrjIdUserIdRela_Cond.dicFldComparisonOp, clsCmPrjIdUserIdRelaEN_js_1.clsCmPrjIdUserIdRelaEN.con_UserId) == true) {
            const strComparisonOp_UserId = objCmPrjIdUserIdRela_Cond.dicFldComparisonOp[clsCmPrjIdUserIdRelaEN_js_1.clsCmPrjIdUserIdRelaEN.con_UserId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsCmPrjIdUserIdRelaEN_js_1.clsCmPrjIdUserIdRelaEN.con_UserId, objCmPrjIdUserIdRela_Cond.userId, strComparisonOp_UserId);
        }
        if (Object.prototype.hasOwnProperty.call(objCmPrjIdUserIdRela_Cond.dicFldComparisonOp, clsCmPrjIdUserIdRelaEN_js_1.clsCmPrjIdUserIdRelaEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objCmPrjIdUserIdRela_Cond.dicFldComparisonOp[clsCmPrjIdUserIdRelaEN_js_1.clsCmPrjIdUserIdRelaEN.con_UpdDate];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsCmPrjIdUserIdRelaEN_js_1.clsCmPrjIdUserIdRelaEN.con_UpdDate, objCmPrjIdUserIdRela_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objCmPrjIdUserIdRela_Cond.dicFldComparisonOp, clsCmPrjIdUserIdRelaEN_js_1.clsCmPrjIdUserIdRelaEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objCmPrjIdUserIdRela_Cond.dicFldComparisonOp[clsCmPrjIdUserIdRelaEN_js_1.clsCmPrjIdUserIdRelaEN.con_UpdUser];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsCmPrjIdUserIdRelaEN_js_1.clsCmPrjIdUserIdRelaEN.con_UpdUser, objCmPrjIdUserIdRela_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objCmPrjIdUserIdRela_Cond.dicFldComparisonOp, clsCmPrjIdUserIdRelaEN_js_1.clsCmPrjIdUserIdRelaEN.con_Memo) == true) {
            const strComparisonOp_Memo = objCmPrjIdUserIdRela_Cond.dicFldComparisonOp[clsCmPrjIdUserIdRelaEN_js_1.clsCmPrjIdUserIdRelaEN.con_Memo];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsCmPrjIdUserIdRelaEN_js_1.clsCmPrjIdUserIdRelaEN.con_Memo, objCmPrjIdUserIdRela_Cond.memo, strComparisonOp_Memo);
        }
        return strWhereCond;
    }
    exports.CmPrjIdUserIdRela_GetCombineCondition = CmPrjIdUserIdRela_GetCombineCondition;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objCmPrjIdUserIdRelaENS:源对象
     * @param objCmPrjIdUserIdRelaENT:目标对象
    */
    function CmPrjIdUserIdRela_CopyObjTo(objCmPrjIdUserIdRelaENS, objCmPrjIdUserIdRelaENT) {
        objCmPrjIdUserIdRelaENT.cmPrjId = objCmPrjIdUserIdRelaENS.cmPrjId; //CM工程Id
        objCmPrjIdUserIdRelaENT.userId = objCmPrjIdUserIdRelaENS.userId; //用户ID
        objCmPrjIdUserIdRelaENT.updDate = objCmPrjIdUserIdRelaENS.updDate; //修改日期
        objCmPrjIdUserIdRelaENT.updUser = objCmPrjIdUserIdRelaENS.updUser; //修改人
        objCmPrjIdUserIdRelaENT.memo = objCmPrjIdUserIdRelaENS.memo; //备注
        objCmPrjIdUserIdRelaENT.sf_UpdFldSetStr = objCmPrjIdUserIdRelaENS.updFldString; //sf_UpdFldSetStr
    }
    exports.CmPrjIdUserIdRela_CopyObjTo = CmPrjIdUserIdRela_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objCmPrjIdUserIdRelaENS:源对象
     * @param objCmPrjIdUserIdRelaENT:目标对象
    */
    function CmPrjIdUserIdRela_GetObjFromJsonObj(objCmPrjIdUserIdRelaENS) {
        const objCmPrjIdUserIdRelaENT = new clsCmPrjIdUserIdRelaEN_js_1.clsCmPrjIdUserIdRelaEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objCmPrjIdUserIdRelaENT, objCmPrjIdUserIdRelaENS);
        return objCmPrjIdUserIdRelaENT;
    }
    exports.CmPrjIdUserIdRela_GetObjFromJsonObj = CmPrjIdUserIdRela_GetObjFromJsonObj;
});
