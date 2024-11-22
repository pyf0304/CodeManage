/**
* 类名:clsSysVoteWApi
* 表名:SysVote(01120639)
* 生成代码版本:2022.11.02.1
* 生成日期:2022/11/02 11:46:10
* 生成者:pyf
* 生成服务器IP:
工程名称:问卷调查(0112)
CM工程:研究生论文学习(变量首字母小写)-全部函数集
* 相关数据库:103.116.76.183,9433EduHigh_Jsie
* PrjDataBaseId:0170
模块中文名:互动管理(InteractManage)
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
        define(["require", "exports", "axios", "../../L0_Entity/InteractManage/clsSysVoteEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsSysPara4WebApi.js", "../../PubFun/jsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.SysVote_GetObjFromJsonObj = exports.SysVote_CopyObjTo = exports.SysVote_GetUniCondStr4Update_VoteId = exports.SysVote_GetUniCondStr_VoteId = exports.SysVote_GetCombineCondition = exports.SysVote_GetObjByJSONStr = exports.SysVote_GetObjLstByJSONObjLst = exports.SysVote_GetObjLstByJSONStr = exports.SysVote_GetJSONStrByObj = exports.SysVote_CheckProperty4Update = exports.SysVote_CheckPropertyNew = exports.SysVote_GetWebApiUrl = exports.SysVote_GetMaxStrIdByPrefix = exports.SysVote_GetRecCountByCondAsync = exports.SysVote_IsExistAsync = exports.SysVote_IsExist = exports.SysVote_IsExistRecordAsync = exports.SysVote_UpdateWithConditionAsync = exports.SysVote_UpdateRecordAsync = exports.SysVote_AddNewRecordWithReturnKey = exports.SysVote_AddNewRecordWithReturnKeyAsync = exports.SysVote_AddNewRecordAsync = exports.SysVote_DelSysVotesByCondAsync = exports.SysVote_DelSysVotesAsync = exports.SysVote_DelRecordAsync = exports.SysVote_GetObjLstByPagerAsync = exports.SysVote_GetObjLstByRange = exports.SysVote_GetObjLstByRangeAsync = exports.SysVote_GetTopObjLstAsync = exports.SysVote_GetObjLstByVoteIdLstAsync = exports.SysVote_GetObjLstAsync = exports.SysVote_GetFirstObjAsync = exports.SysVote_GetFirstID = exports.SysVote_GetFirstIDAsync = exports.SysVote_FilterFunByKey = exports.SysVote_SortFunByKey = exports.SysVote_SortFun_Defa_2Fld = exports.SysVote_SortFun_Defa = exports.SysVote_GetObjByVoteIdAsync = exports.sysVote_ConstructorName = exports.sysVote_Controller = void 0;
    /**
     * 系统点赞表(SysVote)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2022年11月02日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const clsSysVoteEN_js_1 = require("../../L0_Entity/InteractManage/clsSysVoteEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    const jsString_js_1 = require("../../PubFun/jsString.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.sysVote_Controller = "SysVoteApi";
    exports.sysVote_ConstructorName = "sysVote";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param lngVoteId:关键字
    * @returns 对象
    **/
    async function SysVote_GetObjByVoteIdAsync(lngVoteId) {
        const strThisFuncName = "GetObjByVoteIdAsync";
        if (lngVoteId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngVoteId]不能为空！(In GetObjByVoteIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByVoteId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysVote_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "lngVoteId": lngVoteId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.sysVote_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objSysVote = SysVote_GetObjFromJsonObj(returnObj);
                return objSysVote;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysVote_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysVote_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysVote_GetObjByVoteIdAsync = SysVote_GetObjByVoteIdAsync;
    //该表在前台TypeScript中，不需要使用Cache;
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
    function SysVote_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.voteId - b.voteId;
    }
    exports.SysVote_SortFun_Defa = SysVote_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function SysVote_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.tableKey == b.tableKey)
            return a.pubParentId.localeCompare(b.pubParentId);
        else
            return a.tableKey.localeCompare(b.tableKey);
    }
    exports.SysVote_SortFun_Defa_2Fld = SysVote_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function SysVote_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsSysVoteEN_js_1.clsSysVoteEN.con_VoteId:
                    return (a, b) => {
                        return a.voteId - b.voteId;
                    };
                case clsSysVoteEN_js_1.clsSysVoteEN.con_TableKey:
                    return (a, b) => {
                        return a.tableKey.localeCompare(b.tableKey);
                    };
                case clsSysVoteEN_js_1.clsSysVoteEN.con_PubParentId:
                    return (a, b) => {
                        return a.pubParentId.localeCompare(b.pubParentId);
                    };
                case clsSysVoteEN_js_1.clsSysVoteEN.con_VoteTypeId:
                    return (a, b) => {
                        return a.voteTypeId.localeCompare(b.voteTypeId);
                    };
                case clsSysVoteEN_js_1.clsSysVoteEN.con_UpdUser:
                    return (a, b) => {
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsSysVoteEN_js_1.clsSysVoteEN.con_UpdDate:
                    return (a, b) => {
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsSysVoteEN_js_1.clsSysVoteEN.con_Memo:
                    return (a, b) => {
                        return a.memo.localeCompare(b.memo);
                    };
                case clsSysVoteEN_js_1.clsSysVoteEN.con_id_CurrEduCls:
                    return (a, b) => {
                        return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
                    };
                case clsSysVoteEN_js_1.clsSysVoteEN.con_UserId:
                    return (a, b) => {
                        return a.userId.localeCompare(b.userId);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[SysVote]中不存在！(in ${exports.sysVote_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsSysVoteEN_js_1.clsSysVoteEN.con_VoteId:
                    return (a, b) => {
                        return b.voteId - a.voteId;
                    };
                case clsSysVoteEN_js_1.clsSysVoteEN.con_TableKey:
                    return (a, b) => {
                        return b.tableKey.localeCompare(a.tableKey);
                    };
                case clsSysVoteEN_js_1.clsSysVoteEN.con_PubParentId:
                    return (a, b) => {
                        return b.pubParentId.localeCompare(a.pubParentId);
                    };
                case clsSysVoteEN_js_1.clsSysVoteEN.con_VoteTypeId:
                    return (a, b) => {
                        return b.voteTypeId.localeCompare(a.voteTypeId);
                    };
                case clsSysVoteEN_js_1.clsSysVoteEN.con_UpdUser:
                    return (a, b) => {
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsSysVoteEN_js_1.clsSysVoteEN.con_UpdDate:
                    return (a, b) => {
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsSysVoteEN_js_1.clsSysVoteEN.con_Memo:
                    return (a, b) => {
                        return b.memo.localeCompare(a.memo);
                    };
                case clsSysVoteEN_js_1.clsSysVoteEN.con_id_CurrEduCls:
                    return (a, b) => {
                        return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
                    };
                case clsSysVoteEN_js_1.clsSysVoteEN.con_UserId:
                    return (a, b) => {
                        return b.userId.localeCompare(a.userId);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[SysVote]中不存在！(in ${exports.sysVote_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.SysVote_SortFunByKey = SysVote_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function SysVote_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsSysVoteEN_js_1.clsSysVoteEN.con_VoteId:
                return (obj) => {
                    return obj.voteId === value;
                };
            case clsSysVoteEN_js_1.clsSysVoteEN.con_TableKey:
                return (obj) => {
                    return obj.tableKey === value;
                };
            case clsSysVoteEN_js_1.clsSysVoteEN.con_PubParentId:
                return (obj) => {
                    return obj.pubParentId === value;
                };
            case clsSysVoteEN_js_1.clsSysVoteEN.con_VoteTypeId:
                return (obj) => {
                    return obj.voteTypeId === value;
                };
            case clsSysVoteEN_js_1.clsSysVoteEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsSysVoteEN_js_1.clsSysVoteEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsSysVoteEN_js_1.clsSysVoteEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            case clsSysVoteEN_js_1.clsSysVoteEN.con_id_CurrEduCls:
                return (obj) => {
                    return obj.id_CurrEduCls === value;
                };
            case clsSysVoteEN_js_1.clsSysVoteEN.con_UserId:
                return (obj) => {
                    return obj.userId === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[SysVote]中不存在！(in ${exports.sysVote_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.SysVote_FilterFunByKey = SysVote_FilterFunByKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function SysVote_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysVote_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysVote_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysVote_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysVote_GetFirstIDAsync = SysVote_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function SysVote_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysVote_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysVote_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysVote_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysVote_GetFirstID = SysVote_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function SysVote_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysVote_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.sysVote_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objSysVote = SysVote_GetObjFromJsonObj(returnObj);
                return objSysVote;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysVote_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysVote_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysVote_GetFirstObjAsync = SysVote_GetFirstObjAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function SysVote_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysVote_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.sysVote_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = SysVote_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysVote_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysVote_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysVote_GetObjLstAsync = SysVote_GetObjLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrVoteId:关键字列表
    * @returns 对象列表
    **/
    async function SysVote_GetObjLstByVoteIdLstAsync(arrVoteId) {
        const strThisFuncName = "GetObjLstByVoteIdLstAsync";
        const strAction = "GetObjLstByVoteIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysVote_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrVoteId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.sysVote_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = SysVote_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysVote_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysVote_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysVote_GetObjLstByVoteIdLstAsync = SysVote_GetObjLstByVoteIdLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function SysVote_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysVote_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.sysVote_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = SysVote_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysVote_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysVote_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysVote_GetTopObjLstAsync = SysVote_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function SysVote_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysVote_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.sysVote_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = SysVote_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysVote_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysVote_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysVote_GetObjLstByRangeAsync = SysVote_GetObjLstByRangeAsync;
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
    async function SysVote_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysVote_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysVote_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysVote_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysVote_GetObjLstByRange = SysVote_GetObjLstByRange;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function SysVote_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysVote_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.sysVote_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = SysVote_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysVote_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysVote_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysVote_GetObjLstByPagerAsync = SysVote_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param lngVoteId:关键字
    * @returns 获取删除的结果
    **/
    async function SysVote_DelRecordAsync(lngVoteId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysVote_Controller, strAction);
        strUrl = (0, clsString_js_1.Format)("{0}/?Id={1}", strUrl, lngVoteId);
        try {
            const response = await axios_1.default.delete(strUrl, {
                params: { "Id": lngVoteId, }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysVote_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysVote_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysVote_DelRecordAsync = SysVote_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrVoteId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function SysVote_DelSysVotesAsync(arrVoteId) {
        const strThisFuncName = "DelSysVotesAsync";
        const strAction = "DelSysVotes";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysVote_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrVoteId);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysVote_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysVote_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysVote_DelSysVotesAsync = SysVote_DelSysVotesAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function SysVote_DelSysVotesByCondAsync(strWhereCond) {
        const strThisFuncName = "DelSysVotesByCondAsync";
        const strAction = "DelSysVotesByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysVote_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysVote_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysVote_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysVote_DelSysVotesByCondAsync = SysVote_DelSysVotesByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objSysVoteEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function SysVote_AddNewRecordAsync(objSysVoteEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objSysVoteEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysVote_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objSysVoteEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysVote_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysVote_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysVote_AddNewRecordAsync = SysVote_AddNewRecordAsync;
    /* 数据类型不是字符型，不可以最大关键字的方式添加记录。*/
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objSysVoteEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function SysVote_AddNewRecordWithReturnKeyAsync(objSysVoteEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysVote_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objSysVoteEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysVote_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysVote_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysVote_AddNewRecordWithReturnKeyAsync = SysVote_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objSysVoteEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function SysVote_AddNewRecordWithReturnKey(objSysVoteEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objSysVoteEN.voteId === null || objSysVoteEN.voteId === 0) {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysVote_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objSysVoteEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysVote_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysVote_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysVote_AddNewRecordWithReturnKey = SysVote_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objSysVoteEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function SysVote_UpdateRecordAsync(objSysVoteEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objSysVoteEN.sf_UpdFldSetStr === undefined || objSysVoteEN.sf_UpdFldSetStr === null || objSysVoteEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objSysVoteEN.voteId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysVote_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objSysVoteEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysVote_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysVote_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysVote_UpdateRecordAsync = SysVote_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objSysVoteEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function SysVote_UpdateWithConditionAsync(objSysVoteEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objSysVoteEN.sf_UpdFldSetStr === undefined || objSysVoteEN.sf_UpdFldSetStr === null || objSysVoteEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objSysVoteEN.voteId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysVote_Controller, strAction);
        objSysVoteEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objSysVoteEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysVote_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysVote_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysVote_UpdateWithConditionAsync = SysVote_UpdateWithConditionAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function SysVote_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysVote_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysVote_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysVote_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysVote_IsExistRecordAsync = SysVote_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param lngVoteId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function SysVote_IsExist(lngVoteId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysVote_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "VoteId": lngVoteId,
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysVote_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysVote_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysVote_IsExist = SysVote_IsExist;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param lngVoteId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function SysVote_IsExistAsync(lngVoteId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysVote_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "lngVoteId": lngVoteId }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysVote_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysVote_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysVote_IsExistAsync = SysVote_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function SysVote_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysVote_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysVote_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysVote_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysVote_GetRecCountByCondAsync = SysVote_GetRecCountByCondAsync;
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
    async function SysVote_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysVote_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysVote_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysVote_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysVote_GetMaxStrIdByPrefix = SysVote_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function SysVote_GetWebApiUrl(strController, strAction) {
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
    exports.SysVote_GetWebApiUrl = SysVote_GetWebApiUrl;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function SysVote_CheckPropertyNew(pobjSysVoteEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysVoteEN.tableKey) == false && (0, clsString_js_1.GetStrLen)(pobjSysVoteEN.tableKey) > 20) {
            throw new Error("(errid:Watl000059)字段[表主键(tableKey)]的长度不能超过20(In 系统点赞表(SysVote))!值:$(pobjSysVoteEN.tableKey)(clsSysVoteBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysVoteEN.pubParentId) == false && (0, clsString_js_1.GetStrLen)(pobjSysVoteEN.pubParentId) > 20) {
            throw new Error("(errid:Watl000059)字段[公共父Id(pubParentId)]的长度不能超过20(In 系统点赞表(SysVote))!值:$(pobjSysVoteEN.pubParentId)(clsSysVoteBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysVoteEN.voteTypeId) == false && (0, clsString_js_1.GetStrLen)(pobjSysVoteEN.voteTypeId) > 2) {
            throw new Error("(errid:Watl000059)字段[点赞类型Id(voteTypeId)]的长度不能超过2(In 系统点赞表(SysVote))!值:$(pobjSysVoteEN.voteTypeId)(clsSysVoteBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysVoteEN.updUser) == false && (0, clsString_js_1.GetStrLen)(pobjSysVoteEN.updUser) > 20) {
            throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 系统点赞表(SysVote))!值:$(pobjSysVoteEN.updUser)(clsSysVoteBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysVoteEN.updDate) == false && (0, clsString_js_1.GetStrLen)(pobjSysVoteEN.updDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 系统点赞表(SysVote))!值:$(pobjSysVoteEN.updDate)(clsSysVoteBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysVoteEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjSysVoteEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 系统点赞表(SysVote))!值:$(pobjSysVoteEN.memo)(clsSysVoteBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysVoteEN.id_CurrEduCls) == false && (0, clsString_js_1.GetStrLen)(pobjSysVoteEN.id_CurrEduCls) > 8) {
            throw new Error("(errid:Watl000059)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 系统点赞表(SysVote))!值:$(pobjSysVoteEN.id_CurrEduCls)(clsSysVoteBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysVoteEN.userId) == false && (0, clsString_js_1.GetStrLen)(pobjSysVoteEN.userId) > 20) {
            throw new Error("(errid:Watl000059)字段[用户ID(userId)]的长度不能超过20(In 系统点赞表(SysVote))!值:$(pobjSysVoteEN.userId)(clsSysVoteBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if (null != pobjSysVoteEN.voteId && undefined !== pobjSysVoteEN.voteId && jsString_js_1.tzDataType.isNumber(pobjSysVoteEN.voteId) === false) {
            throw new Error("(errid:Watl000060)字段[点赞Id(voteId)]的值:[$(pobjSysVoteEN.voteId)], 非法，应该为数值型(In 系统点赞表(SysVote))!(clsSysVoteBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysVoteEN.tableKey) == false && undefined !== pobjSysVoteEN.tableKey && jsString_js_1.tzDataType.isString(pobjSysVoteEN.tableKey) === false) {
            throw new Error("(errid:Watl000060)字段[表主键(tableKey)]的值:[$(pobjSysVoteEN.tableKey)], 非法，应该为字符型(In 系统点赞表(SysVote))!(clsSysVoteBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysVoteEN.pubParentId) == false && undefined !== pobjSysVoteEN.pubParentId && jsString_js_1.tzDataType.isString(pobjSysVoteEN.pubParentId) === false) {
            throw new Error("(errid:Watl000060)字段[公共父Id(pubParentId)]的值:[$(pobjSysVoteEN.pubParentId)], 非法，应该为字符型(In 系统点赞表(SysVote))!(clsSysVoteBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysVoteEN.voteTypeId) == false && undefined !== pobjSysVoteEN.voteTypeId && jsString_js_1.tzDataType.isString(pobjSysVoteEN.voteTypeId) === false) {
            throw new Error("(errid:Watl000060)字段[点赞类型Id(voteTypeId)]的值:[$(pobjSysVoteEN.voteTypeId)], 非法，应该为字符型(In 系统点赞表(SysVote))!(clsSysVoteBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysVoteEN.updUser) == false && undefined !== pobjSysVoteEN.updUser && jsString_js_1.tzDataType.isString(pobjSysVoteEN.updUser) === false) {
            throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjSysVoteEN.updUser)], 非法，应该为字符型(In 系统点赞表(SysVote))!(clsSysVoteBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysVoteEN.updDate) == false && undefined !== pobjSysVoteEN.updDate && jsString_js_1.tzDataType.isString(pobjSysVoteEN.updDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjSysVoteEN.updDate)], 非法，应该为字符型(In 系统点赞表(SysVote))!(clsSysVoteBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysVoteEN.memo) == false && undefined !== pobjSysVoteEN.memo && jsString_js_1.tzDataType.isString(pobjSysVoteEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjSysVoteEN.memo)], 非法，应该为字符型(In 系统点赞表(SysVote))!(clsSysVoteBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysVoteEN.id_CurrEduCls) == false && undefined !== pobjSysVoteEN.id_CurrEduCls && jsString_js_1.tzDataType.isString(pobjSysVoteEN.id_CurrEduCls) === false) {
            throw new Error("(errid:Watl000060)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjSysVoteEN.id_CurrEduCls)], 非法，应该为字符型(In 系统点赞表(SysVote))!(clsSysVoteBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysVoteEN.userId) == false && undefined !== pobjSysVoteEN.userId && jsString_js_1.tzDataType.isString(pobjSysVoteEN.userId) === false) {
            throw new Error("(errid:Watl000060)字段[用户ID(userId)]的值:[$(pobjSysVoteEN.userId)], 非法，应该为字符型(In 系统点赞表(SysVote))!(clsSysVoteBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjSysVoteEN.SetIsCheckProperty(true);
    }
    exports.SysVote_CheckPropertyNew = SysVote_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function SysVote_CheckProperty4Update(pobjSysVoteEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysVoteEN.tableKey) == false && (0, clsString_js_1.GetStrLen)(pobjSysVoteEN.tableKey) > 20) {
            throw new Error("(errid:Watl000062)字段[表主键(tableKey)]的长度不能超过20(In 系统点赞表(SysVote))!值:$(pobjSysVoteEN.tableKey)(clsSysVoteBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysVoteEN.pubParentId) == false && (0, clsString_js_1.GetStrLen)(pobjSysVoteEN.pubParentId) > 20) {
            throw new Error("(errid:Watl000062)字段[公共父Id(pubParentId)]的长度不能超过20(In 系统点赞表(SysVote))!值:$(pobjSysVoteEN.pubParentId)(clsSysVoteBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysVoteEN.voteTypeId) == false && (0, clsString_js_1.GetStrLen)(pobjSysVoteEN.voteTypeId) > 2) {
            throw new Error("(errid:Watl000062)字段[点赞类型Id(voteTypeId)]的长度不能超过2(In 系统点赞表(SysVote))!值:$(pobjSysVoteEN.voteTypeId)(clsSysVoteBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysVoteEN.updUser) == false && (0, clsString_js_1.GetStrLen)(pobjSysVoteEN.updUser) > 20) {
            throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 系统点赞表(SysVote))!值:$(pobjSysVoteEN.updUser)(clsSysVoteBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysVoteEN.updDate) == false && (0, clsString_js_1.GetStrLen)(pobjSysVoteEN.updDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 系统点赞表(SysVote))!值:$(pobjSysVoteEN.updDate)(clsSysVoteBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysVoteEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjSysVoteEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 系统点赞表(SysVote))!值:$(pobjSysVoteEN.memo)(clsSysVoteBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysVoteEN.id_CurrEduCls) == false && (0, clsString_js_1.GetStrLen)(pobjSysVoteEN.id_CurrEduCls) > 8) {
            throw new Error("(errid:Watl000062)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 系统点赞表(SysVote))!值:$(pobjSysVoteEN.id_CurrEduCls)(clsSysVoteBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysVoteEN.userId) == false && (0, clsString_js_1.GetStrLen)(pobjSysVoteEN.userId) > 20) {
            throw new Error("(errid:Watl000062)字段[用户ID(userId)]的长度不能超过20(In 系统点赞表(SysVote))!值:$(pobjSysVoteEN.userId)(clsSysVoteBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if (null != pobjSysVoteEN.voteId && undefined !== pobjSysVoteEN.voteId && jsString_js_1.tzDataType.isNumber(pobjSysVoteEN.voteId) === false) {
            throw new Error("(errid:Watl000063)字段[点赞Id(voteId)]的值:[$(pobjSysVoteEN.voteId)], 非法，应该为数值型(In 系统点赞表(SysVote))!(clsSysVoteBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysVoteEN.tableKey) == false && undefined !== pobjSysVoteEN.tableKey && jsString_js_1.tzDataType.isString(pobjSysVoteEN.tableKey) === false) {
            throw new Error("(errid:Watl000063)字段[表主键(tableKey)]的值:[$(pobjSysVoteEN.tableKey)], 非法，应该为字符型(In 系统点赞表(SysVote))!(clsSysVoteBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysVoteEN.pubParentId) == false && undefined !== pobjSysVoteEN.pubParentId && jsString_js_1.tzDataType.isString(pobjSysVoteEN.pubParentId) === false) {
            throw new Error("(errid:Watl000063)字段[公共父Id(pubParentId)]的值:[$(pobjSysVoteEN.pubParentId)], 非法，应该为字符型(In 系统点赞表(SysVote))!(clsSysVoteBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysVoteEN.voteTypeId) == false && undefined !== pobjSysVoteEN.voteTypeId && jsString_js_1.tzDataType.isString(pobjSysVoteEN.voteTypeId) === false) {
            throw new Error("(errid:Watl000063)字段[点赞类型Id(voteTypeId)]的值:[$(pobjSysVoteEN.voteTypeId)], 非法，应该为字符型(In 系统点赞表(SysVote))!(clsSysVoteBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysVoteEN.updUser) == false && undefined !== pobjSysVoteEN.updUser && jsString_js_1.tzDataType.isString(pobjSysVoteEN.updUser) === false) {
            throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjSysVoteEN.updUser)], 非法，应该为字符型(In 系统点赞表(SysVote))!(clsSysVoteBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysVoteEN.updDate) == false && undefined !== pobjSysVoteEN.updDate && jsString_js_1.tzDataType.isString(pobjSysVoteEN.updDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjSysVoteEN.updDate)], 非法，应该为字符型(In 系统点赞表(SysVote))!(clsSysVoteBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysVoteEN.memo) == false && undefined !== pobjSysVoteEN.memo && jsString_js_1.tzDataType.isString(pobjSysVoteEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjSysVoteEN.memo)], 非法，应该为字符型(In 系统点赞表(SysVote))!(clsSysVoteBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysVoteEN.id_CurrEduCls) == false && undefined !== pobjSysVoteEN.id_CurrEduCls && jsString_js_1.tzDataType.isString(pobjSysVoteEN.id_CurrEduCls) === false) {
            throw new Error("(errid:Watl000063)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjSysVoteEN.id_CurrEduCls)], 非法，应该为字符型(In 系统点赞表(SysVote))!(clsSysVoteBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysVoteEN.userId) == false && undefined !== pobjSysVoteEN.userId && jsString_js_1.tzDataType.isString(pobjSysVoteEN.userId) === false) {
            throw new Error("(errid:Watl000063)字段[用户ID(userId)]的值:[$(pobjSysVoteEN.userId)], 非法，应该为字符型(In 系统点赞表(SysVote))!(clsSysVoteBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if (null === pobjSysVoteEN.voteId
            || pobjSysVoteEN.voteId != null && pobjSysVoteEN.voteId.toString() === "") {
            throw new Error("(errid:Watl000064)字段[点赞Id]不能为空(In 系统点赞表)!(clsSysVoteBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjSysVoteEN.SetIsCheckProperty(true);
    }
    exports.SysVote_CheckProperty4Update = SysVote_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function SysVote_GetJSONStrByObj(pobjSysVoteEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjSysVoteEN.sf_UpdFldSetStr = pobjSysVoteEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjSysVoteEN);
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
    exports.SysVote_GetJSONStrByObj = SysVote_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function SysVote_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrSysVoteObjLst = new Array();
        if (strJSON === "") {
            return arrSysVoteObjLst;
        }
        try {
            arrSysVoteObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrSysVoteObjLst;
        }
        return arrSysVoteObjLst;
    }
    exports.SysVote_GetObjLstByJSONStr = SysVote_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrSysVoteObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function SysVote_GetObjLstByJSONObjLst(arrSysVoteObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrSysVoteObjLst = new Array();
        for (const objInFor of arrSysVoteObjLstS) {
            const obj1 = SysVote_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrSysVoteObjLst.push(obj1);
        }
        return arrSysVoteObjLst;
    }
    exports.SysVote_GetObjLstByJSONObjLst = SysVote_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function SysVote_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjSysVoteEN = new clsSysVoteEN_js_1.clsSysVoteEN();
        if (strJSON === "") {
            return pobjSysVoteEN;
        }
        try {
            pobjSysVoteEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjSysVoteEN;
        }
        return pobjSysVoteEN;
    }
    exports.SysVote_GetObjByJSONStr = SysVote_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function SysVote_GetCombineCondition(objSysVote_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objSysVote_Cond.dicFldComparisonOp, clsSysVoteEN_js_1.clsSysVoteEN.con_VoteId) == true) {
            const strComparisonOp_VoteId = objSysVote_Cond.dicFldComparisonOp[clsSysVoteEN_js_1.clsSysVoteEN.con_VoteId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsSysVoteEN_js_1.clsSysVoteEN.con_VoteId, objSysVote_Cond.voteId, strComparisonOp_VoteId);
        }
        if (Object.prototype.hasOwnProperty.call(objSysVote_Cond.dicFldComparisonOp, clsSysVoteEN_js_1.clsSysVoteEN.con_TableKey) == true) {
            const strComparisonOp_TableKey = objSysVote_Cond.dicFldComparisonOp[clsSysVoteEN_js_1.clsSysVoteEN.con_TableKey];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsSysVoteEN_js_1.clsSysVoteEN.con_TableKey, objSysVote_Cond.tableKey, strComparisonOp_TableKey);
        }
        if (Object.prototype.hasOwnProperty.call(objSysVote_Cond.dicFldComparisonOp, clsSysVoteEN_js_1.clsSysVoteEN.con_PubParentId) == true) {
            const strComparisonOp_PubParentId = objSysVote_Cond.dicFldComparisonOp[clsSysVoteEN_js_1.clsSysVoteEN.con_PubParentId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsSysVoteEN_js_1.clsSysVoteEN.con_PubParentId, objSysVote_Cond.pubParentId, strComparisonOp_PubParentId);
        }
        if (Object.prototype.hasOwnProperty.call(objSysVote_Cond.dicFldComparisonOp, clsSysVoteEN_js_1.clsSysVoteEN.con_VoteTypeId) == true) {
            const strComparisonOp_VoteTypeId = objSysVote_Cond.dicFldComparisonOp[clsSysVoteEN_js_1.clsSysVoteEN.con_VoteTypeId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsSysVoteEN_js_1.clsSysVoteEN.con_VoteTypeId, objSysVote_Cond.voteTypeId, strComparisonOp_VoteTypeId);
        }
        if (Object.prototype.hasOwnProperty.call(objSysVote_Cond.dicFldComparisonOp, clsSysVoteEN_js_1.clsSysVoteEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objSysVote_Cond.dicFldComparisonOp[clsSysVoteEN_js_1.clsSysVoteEN.con_UpdUser];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsSysVoteEN_js_1.clsSysVoteEN.con_UpdUser, objSysVote_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objSysVote_Cond.dicFldComparisonOp, clsSysVoteEN_js_1.clsSysVoteEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objSysVote_Cond.dicFldComparisonOp[clsSysVoteEN_js_1.clsSysVoteEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsSysVoteEN_js_1.clsSysVoteEN.con_UpdDate, objSysVote_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objSysVote_Cond.dicFldComparisonOp, clsSysVoteEN_js_1.clsSysVoteEN.con_Memo) == true) {
            const strComparisonOp_Memo = objSysVote_Cond.dicFldComparisonOp[clsSysVoteEN_js_1.clsSysVoteEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsSysVoteEN_js_1.clsSysVoteEN.con_Memo, objSysVote_Cond.memo, strComparisonOp_Memo);
        }
        if (Object.prototype.hasOwnProperty.call(objSysVote_Cond.dicFldComparisonOp, clsSysVoteEN_js_1.clsSysVoteEN.con_id_CurrEduCls) == true) {
            const strComparisonOp_id_CurrEduCls = objSysVote_Cond.dicFldComparisonOp[clsSysVoteEN_js_1.clsSysVoteEN.con_id_CurrEduCls];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsSysVoteEN_js_1.clsSysVoteEN.con_id_CurrEduCls, objSysVote_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
        }
        if (Object.prototype.hasOwnProperty.call(objSysVote_Cond.dicFldComparisonOp, clsSysVoteEN_js_1.clsSysVoteEN.con_UserId) == true) {
            const strComparisonOp_UserId = objSysVote_Cond.dicFldComparisonOp[clsSysVoteEN_js_1.clsSysVoteEN.con_UserId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsSysVoteEN_js_1.clsSysVoteEN.con_UserId, objSysVote_Cond.userId, strComparisonOp_UserId);
        }
        return strWhereCond;
    }
    exports.SysVote_GetCombineCondition = SysVote_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--SysVote(系统点赞表),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param lngVoteId: 点赞Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function SysVote_GetUniCondStr_VoteId(objSysVoteEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and VoteId = '{0}'", objSysVoteEN.voteId);
        return strWhereCond;
    }
    exports.SysVote_GetUniCondStr_VoteId = SysVote_GetUniCondStr_VoteId;
    /**
    *获取唯一性条件串(Uniqueness)--SysVote(系统点赞表),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param lngVoteId: 点赞Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function SysVote_GetUniCondStr4Update_VoteId(objSysVoteEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and VoteId <> '{0}'", objSysVoteEN.voteId);
        strWhereCond += (0, clsString_js_1.Format)(" and VoteId = '{0}'", objSysVoteEN.voteId);
        return strWhereCond;
    }
    exports.SysVote_GetUniCondStr4Update_VoteId = SysVote_GetUniCondStr4Update_VoteId;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objSysVoteENS:源对象
     * @param objSysVoteENT:目标对象
    */
    function SysVote_CopyObjTo(objSysVoteENS, objSysVoteENT) {
        objSysVoteENT.voteId = objSysVoteENS.voteId; //点赞Id
        objSysVoteENT.tableKey = objSysVoteENS.tableKey; //表主键
        objSysVoteENT.pubParentId = objSysVoteENS.pubParentId; //公共父Id
        objSysVoteENT.voteTypeId = objSysVoteENS.voteTypeId; //点赞类型Id
        objSysVoteENT.updUser = objSysVoteENS.updUser; //修改人
        objSysVoteENT.updDate = objSysVoteENS.updDate; //修改日期
        objSysVoteENT.memo = objSysVoteENS.memo; //备注
        objSysVoteENT.id_CurrEduCls = objSysVoteENS.id_CurrEduCls; //教学班流水号
        objSysVoteENT.userId = objSysVoteENS.userId; //用户ID
        objSysVoteENT.sf_UpdFldSetStr = objSysVoteENS.updFldString; //sf_UpdFldSetStr
    }
    exports.SysVote_CopyObjTo = SysVote_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objSysVoteENS:源对象
     * @param objSysVoteENT:目标对象
    */
    function SysVote_GetObjFromJsonObj(objSysVoteENS) {
        const objSysVoteENT = new clsSysVoteEN_js_1.clsSysVoteEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objSysVoteENT, objSysVoteENS);
        return objSysVoteENT;
    }
    exports.SysVote_GetObjFromJsonObj = SysVote_GetObjFromJsonObj;
});
