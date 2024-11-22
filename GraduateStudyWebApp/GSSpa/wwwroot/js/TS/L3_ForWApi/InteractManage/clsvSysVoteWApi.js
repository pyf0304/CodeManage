/**
* 类名:clsvSysVoteWApi
* 表名:vSysVote(01120633)
* 生成代码版本:2022.11.02.1
* 生成日期:2022/11/02 12:02:29
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
        define(["require", "exports", "axios", "../../L0_Entity/InteractManage/clsvSysVoteEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsSysPara4WebApi.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.vSysVote_GetObjFromJsonObj = exports.vSysVote_CopyObjTo = exports.vSysVote_GetCombineCondition = exports.vSysVote_GetObjByJSONStr = exports.vSysVote_GetObjLstByJSONObjLst = exports.vSysVote_GetObjLstByJSONStr = exports.vSysVote_GetJSONStrByObj = exports.vSysVote_GetWebApiUrl = exports.vSysVote_GetRecCountByCondAsync = exports.vSysVote_IsExistAsync = exports.vSysVote_IsExist = exports.vSysVote_IsExistRecordAsync = exports.vSysVote_GetObjLstByPagerAsync = exports.vSysVote_GetObjLstByRange = exports.vSysVote_GetObjLstByRangeAsync = exports.vSysVote_GetTopObjLstAsync = exports.vSysVote_GetObjLstByVoteIdLstAsync = exports.vSysVote_GetObjLstAsync = exports.vSysVote_GetFirstObjAsync = exports.vSysVote_GetFirstID = exports.vSysVote_GetFirstIDAsync = exports.vSysVote_FilterFunByKey = exports.vSysVote_SortFunByKey = exports.vSysVote_SortFun_Defa_2Fld = exports.vSysVote_SortFun_Defa = exports.vSysVote_GetObjByVoteIdAsync = exports.vSysVote_ConstructorName = exports.vSysVote_Controller = void 0;
    /**
     * v系统点赞视图(vSysVote)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2022年11月02日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const clsvSysVoteEN_js_1 = require("../../L0_Entity/InteractManage/clsvSysVoteEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.vSysVote_Controller = "vSysVoteApi";
    exports.vSysVote_ConstructorName = "vSysVote";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param lngVoteId:关键字
    * @returns 对象
    **/
    async function vSysVote_GetObjByVoteIdAsync(lngVoteId) {
        const strThisFuncName = "GetObjByVoteIdAsync";
        if (lngVoteId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngVoteId]不能为空！(In GetObjByVoteIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByVoteId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vSysVote_Controller, strAction);
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
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vSysVote_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objvSysVote = vSysVote_GetObjFromJsonObj(returnObj);
                return objvSysVote;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vSysVote_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vSysVote_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vSysVote_GetObjByVoteIdAsync = vSysVote_GetObjByVoteIdAsync;
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
    function vSysVote_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.voteId - b.voteId;
    }
    exports.vSysVote_SortFun_Defa = vSysVote_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vSysVote_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.tableKey == b.tableKey)
            return a.pubParentId.localeCompare(b.pubParentId);
        else
            return a.tableKey.localeCompare(b.tableKey);
    }
    exports.vSysVote_SortFun_Defa_2Fld = vSysVote_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vSysVote_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsvSysVoteEN_js_1.clsvSysVoteEN.con_VoteId:
                    return (a, b) => {
                        return a.voteId - b.voteId;
                    };
                case clsvSysVoteEN_js_1.clsvSysVoteEN.con_TableKey:
                    return (a, b) => {
                        return a.tableKey.localeCompare(b.tableKey);
                    };
                case clsvSysVoteEN_js_1.clsvSysVoteEN.con_PubParentId:
                    return (a, b) => {
                        return a.pubParentId.localeCompare(b.pubParentId);
                    };
                case clsvSysVoteEN_js_1.clsvSysVoteEN.con_VoteTypeId:
                    return (a, b) => {
                        return a.voteTypeId.localeCompare(b.voteTypeId);
                    };
                case clsvSysVoteEN_js_1.clsvSysVoteEN.con_VoteTypeName:
                    return (a, b) => {
                        return a.voteTypeName.localeCompare(b.voteTypeName);
                    };
                case clsvSysVoteEN_js_1.clsvSysVoteEN.con_UpdUser:
                    return (a, b) => {
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsvSysVoteEN_js_1.clsvSysVoteEN.con_VoteTable:
                    return (a, b) => {
                        return a.voteTable.localeCompare(b.voteTable);
                    };
                case clsvSysVoteEN_js_1.clsvSysVoteEN.con_UpdDate:
                    return (a, b) => {
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsvSysVoteEN_js_1.clsvSysVoteEN.con_VoteTableId:
                    return (a, b) => {
                        return a.voteTableId.localeCompare(b.voteTableId);
                    };
                case clsvSysVoteEN_js_1.clsvSysVoteEN.con_Memo:
                    return (a, b) => {
                        return a.memo.localeCompare(b.memo);
                    };
                case clsvSysVoteEN_js_1.clsvSysVoteEN.con_id_CurrEduCls:
                    return (a, b) => {
                        return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
                    };
                case clsvSysVoteEN_js_1.clsvSysVoteEN.con_UserId:
                    return (a, b) => {
                        return a.userId.localeCompare(b.userId);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vSysVote]中不存在！(in ${exports.vSysVote_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsvSysVoteEN_js_1.clsvSysVoteEN.con_VoteId:
                    return (a, b) => {
                        return b.voteId - a.voteId;
                    };
                case clsvSysVoteEN_js_1.clsvSysVoteEN.con_TableKey:
                    return (a, b) => {
                        return b.tableKey.localeCompare(a.tableKey);
                    };
                case clsvSysVoteEN_js_1.clsvSysVoteEN.con_PubParentId:
                    return (a, b) => {
                        return b.pubParentId.localeCompare(a.pubParentId);
                    };
                case clsvSysVoteEN_js_1.clsvSysVoteEN.con_VoteTypeId:
                    return (a, b) => {
                        return b.voteTypeId.localeCompare(a.voteTypeId);
                    };
                case clsvSysVoteEN_js_1.clsvSysVoteEN.con_VoteTypeName:
                    return (a, b) => {
                        return b.voteTypeName.localeCompare(a.voteTypeName);
                    };
                case clsvSysVoteEN_js_1.clsvSysVoteEN.con_UpdUser:
                    return (a, b) => {
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsvSysVoteEN_js_1.clsvSysVoteEN.con_VoteTable:
                    return (a, b) => {
                        return b.voteTable.localeCompare(a.voteTable);
                    };
                case clsvSysVoteEN_js_1.clsvSysVoteEN.con_UpdDate:
                    return (a, b) => {
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsvSysVoteEN_js_1.clsvSysVoteEN.con_VoteTableId:
                    return (a, b) => {
                        return b.voteTableId.localeCompare(a.voteTableId);
                    };
                case clsvSysVoteEN_js_1.clsvSysVoteEN.con_Memo:
                    return (a, b) => {
                        return b.memo.localeCompare(a.memo);
                    };
                case clsvSysVoteEN_js_1.clsvSysVoteEN.con_id_CurrEduCls:
                    return (a, b) => {
                        return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
                    };
                case clsvSysVoteEN_js_1.clsvSysVoteEN.con_UserId:
                    return (a, b) => {
                        return b.userId.localeCompare(a.userId);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vSysVote]中不存在！(in ${exports.vSysVote_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.vSysVote_SortFunByKey = vSysVote_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function vSysVote_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsvSysVoteEN_js_1.clsvSysVoteEN.con_VoteId:
                return (obj) => {
                    return obj.voteId === value;
                };
            case clsvSysVoteEN_js_1.clsvSysVoteEN.con_TableKey:
                return (obj) => {
                    return obj.tableKey === value;
                };
            case clsvSysVoteEN_js_1.clsvSysVoteEN.con_PubParentId:
                return (obj) => {
                    return obj.pubParentId === value;
                };
            case clsvSysVoteEN_js_1.clsvSysVoteEN.con_VoteTypeId:
                return (obj) => {
                    return obj.voteTypeId === value;
                };
            case clsvSysVoteEN_js_1.clsvSysVoteEN.con_VoteTypeName:
                return (obj) => {
                    return obj.voteTypeName === value;
                };
            case clsvSysVoteEN_js_1.clsvSysVoteEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsvSysVoteEN_js_1.clsvSysVoteEN.con_VoteTable:
                return (obj) => {
                    return obj.voteTable === value;
                };
            case clsvSysVoteEN_js_1.clsvSysVoteEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsvSysVoteEN_js_1.clsvSysVoteEN.con_VoteTableId:
                return (obj) => {
                    return obj.voteTableId === value;
                };
            case clsvSysVoteEN_js_1.clsvSysVoteEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            case clsvSysVoteEN_js_1.clsvSysVoteEN.con_id_CurrEduCls:
                return (obj) => {
                    return obj.id_CurrEduCls === value;
                };
            case clsvSysVoteEN_js_1.clsvSysVoteEN.con_UserId:
                return (obj) => {
                    return obj.userId === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[vSysVote]中不存在！(in ${exports.vSysVote_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.vSysVote_FilterFunByKey = vSysVote_FilterFunByKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function vSysVote_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vSysVote_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vSysVote_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vSysVote_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vSysVote_GetFirstIDAsync = vSysVote_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function vSysVote_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vSysVote_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vSysVote_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vSysVote_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vSysVote_GetFirstID = vSysVote_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function vSysVote_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vSysVote_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vSysVote_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objvSysVote = vSysVote_GetObjFromJsonObj(returnObj);
                return objvSysVote;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vSysVote_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vSysVote_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vSysVote_GetFirstObjAsync = vSysVote_GetFirstObjAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function vSysVote_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vSysVote_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vSysVote_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vSysVote_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vSysVote_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vSysVote_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vSysVote_GetObjLstAsync = vSysVote_GetObjLstAsync;
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
    async function vSysVote_GetObjLstByVoteIdLstAsync(arrVoteId) {
        const strThisFuncName = "GetObjLstByVoteIdLstAsync";
        const strAction = "GetObjLstByVoteIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vSysVote_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrVoteId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vSysVote_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vSysVote_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vSysVote_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vSysVote_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vSysVote_GetObjLstByVoteIdLstAsync = vSysVote_GetObjLstByVoteIdLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function vSysVote_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vSysVote_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vSysVote_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vSysVote_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vSysVote_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vSysVote_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vSysVote_GetTopObjLstAsync = vSysVote_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vSysVote_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vSysVote_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vSysVote_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vSysVote_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vSysVote_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vSysVote_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vSysVote_GetObjLstByRangeAsync = vSysVote_GetObjLstByRangeAsync;
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
    async function vSysVote_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vSysVote_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vSysVote_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vSysVote_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vSysVote_GetObjLstByRange = vSysVote_GetObjLstByRange;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vSysVote_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vSysVote_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vSysVote_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vSysVote_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vSysVote_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vSysVote_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vSysVote_GetObjLstByPagerAsync = vSysVote_GetObjLstByPagerAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function vSysVote_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vSysVote_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vSysVote_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vSysVote_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vSysVote_IsExistRecordAsync = vSysVote_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param lngVoteId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function vSysVote_IsExist(lngVoteId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vSysVote_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vSysVote_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vSysVote_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vSysVote_IsExist = vSysVote_IsExist;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param lngVoteId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function vSysVote_IsExistAsync(lngVoteId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vSysVote_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vSysVote_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vSysVote_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vSysVote_IsExistAsync = vSysVote_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function vSysVote_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vSysVote_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vSysVote_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vSysVote_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vSysVote_GetRecCountByCondAsync = vSysVote_GetRecCountByCondAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function vSysVote_GetWebApiUrl(strController, strAction) {
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
    exports.vSysVote_GetWebApiUrl = vSysVote_GetWebApiUrl;
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
    function vSysVote_GetJSONStrByObj(pobjvSysVoteEN) {
        const strThisFuncName = "GetJSONStrByObj";
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjvSysVoteEN);
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
    exports.vSysVote_GetJSONStrByObj = vSysVote_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function vSysVote_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrvSysVoteObjLst = new Array();
        if (strJSON === "") {
            return arrvSysVoteObjLst;
        }
        try {
            arrvSysVoteObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrvSysVoteObjLst;
        }
        return arrvSysVoteObjLst;
    }
    exports.vSysVote_GetObjLstByJSONStr = vSysVote_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrvSysVoteObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function vSysVote_GetObjLstByJSONObjLst(arrvSysVoteObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrvSysVoteObjLst = new Array();
        for (const objInFor of arrvSysVoteObjLstS) {
            const obj1 = vSysVote_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrvSysVoteObjLst.push(obj1);
        }
        return arrvSysVoteObjLst;
    }
    exports.vSysVote_GetObjLstByJSONObjLst = vSysVote_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vSysVote_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjvSysVoteEN = new clsvSysVoteEN_js_1.clsvSysVoteEN();
        if (strJSON === "") {
            return pobjvSysVoteEN;
        }
        try {
            pobjvSysVoteEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjvSysVoteEN;
        }
        return pobjvSysVoteEN;
    }
    exports.vSysVote_GetObjByJSONStr = vSysVote_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function vSysVote_GetCombineCondition(objvSysVote_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objvSysVote_Cond.dicFldComparisonOp, clsvSysVoteEN_js_1.clsvSysVoteEN.con_VoteId) == true) {
            const strComparisonOp_VoteId = objvSysVote_Cond.dicFldComparisonOp[clsvSysVoteEN_js_1.clsvSysVoteEN.con_VoteId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvSysVoteEN_js_1.clsvSysVoteEN.con_VoteId, objvSysVote_Cond.voteId, strComparisonOp_VoteId);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysVote_Cond.dicFldComparisonOp, clsvSysVoteEN_js_1.clsvSysVoteEN.con_TableKey) == true) {
            const strComparisonOp_TableKey = objvSysVote_Cond.dicFldComparisonOp[clsvSysVoteEN_js_1.clsvSysVoteEN.con_TableKey];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvSysVoteEN_js_1.clsvSysVoteEN.con_TableKey, objvSysVote_Cond.tableKey, strComparisonOp_TableKey);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysVote_Cond.dicFldComparisonOp, clsvSysVoteEN_js_1.clsvSysVoteEN.con_PubParentId) == true) {
            const strComparisonOp_PubParentId = objvSysVote_Cond.dicFldComparisonOp[clsvSysVoteEN_js_1.clsvSysVoteEN.con_PubParentId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvSysVoteEN_js_1.clsvSysVoteEN.con_PubParentId, objvSysVote_Cond.pubParentId, strComparisonOp_PubParentId);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysVote_Cond.dicFldComparisonOp, clsvSysVoteEN_js_1.clsvSysVoteEN.con_VoteTypeId) == true) {
            const strComparisonOp_VoteTypeId = objvSysVote_Cond.dicFldComparisonOp[clsvSysVoteEN_js_1.clsvSysVoteEN.con_VoteTypeId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvSysVoteEN_js_1.clsvSysVoteEN.con_VoteTypeId, objvSysVote_Cond.voteTypeId, strComparisonOp_VoteTypeId);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysVote_Cond.dicFldComparisonOp, clsvSysVoteEN_js_1.clsvSysVoteEN.con_VoteTypeName) == true) {
            const strComparisonOp_VoteTypeName = objvSysVote_Cond.dicFldComparisonOp[clsvSysVoteEN_js_1.clsvSysVoteEN.con_VoteTypeName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvSysVoteEN_js_1.clsvSysVoteEN.con_VoteTypeName, objvSysVote_Cond.voteTypeName, strComparisonOp_VoteTypeName);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysVote_Cond.dicFldComparisonOp, clsvSysVoteEN_js_1.clsvSysVoteEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objvSysVote_Cond.dicFldComparisonOp[clsvSysVoteEN_js_1.clsvSysVoteEN.con_UpdUser];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvSysVoteEN_js_1.clsvSysVoteEN.con_UpdUser, objvSysVote_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysVote_Cond.dicFldComparisonOp, clsvSysVoteEN_js_1.clsvSysVoteEN.con_VoteTable) == true) {
            const strComparisonOp_VoteTable = objvSysVote_Cond.dicFldComparisonOp[clsvSysVoteEN_js_1.clsvSysVoteEN.con_VoteTable];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvSysVoteEN_js_1.clsvSysVoteEN.con_VoteTable, objvSysVote_Cond.voteTable, strComparisonOp_VoteTable);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysVote_Cond.dicFldComparisonOp, clsvSysVoteEN_js_1.clsvSysVoteEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objvSysVote_Cond.dicFldComparisonOp[clsvSysVoteEN_js_1.clsvSysVoteEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvSysVoteEN_js_1.clsvSysVoteEN.con_UpdDate, objvSysVote_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysVote_Cond.dicFldComparisonOp, clsvSysVoteEN_js_1.clsvSysVoteEN.con_VoteTableId) == true) {
            const strComparisonOp_VoteTableId = objvSysVote_Cond.dicFldComparisonOp[clsvSysVoteEN_js_1.clsvSysVoteEN.con_VoteTableId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvSysVoteEN_js_1.clsvSysVoteEN.con_VoteTableId, objvSysVote_Cond.voteTableId, strComparisonOp_VoteTableId);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysVote_Cond.dicFldComparisonOp, clsvSysVoteEN_js_1.clsvSysVoteEN.con_Memo) == true) {
            const strComparisonOp_Memo = objvSysVote_Cond.dicFldComparisonOp[clsvSysVoteEN_js_1.clsvSysVoteEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvSysVoteEN_js_1.clsvSysVoteEN.con_Memo, objvSysVote_Cond.memo, strComparisonOp_Memo);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysVote_Cond.dicFldComparisonOp, clsvSysVoteEN_js_1.clsvSysVoteEN.con_id_CurrEduCls) == true) {
            const strComparisonOp_id_CurrEduCls = objvSysVote_Cond.dicFldComparisonOp[clsvSysVoteEN_js_1.clsvSysVoteEN.con_id_CurrEduCls];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvSysVoteEN_js_1.clsvSysVoteEN.con_id_CurrEduCls, objvSysVote_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysVote_Cond.dicFldComparisonOp, clsvSysVoteEN_js_1.clsvSysVoteEN.con_UserId) == true) {
            const strComparisonOp_UserId = objvSysVote_Cond.dicFldComparisonOp[clsvSysVoteEN_js_1.clsvSysVoteEN.con_UserId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvSysVoteEN_js_1.clsvSysVoteEN.con_UserId, objvSysVote_Cond.userId, strComparisonOp_UserId);
        }
        return strWhereCond;
    }
    exports.vSysVote_GetCombineCondition = vSysVote_GetCombineCondition;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objvSysVoteENS:源对象
     * @param objvSysVoteENT:目标对象
    */
    function vSysVote_CopyObjTo(objvSysVoteENS, objvSysVoteENT) {
        objvSysVoteENT.voteId = objvSysVoteENS.voteId; //点赞Id
        objvSysVoteENT.tableKey = objvSysVoteENS.tableKey; //表主键
        objvSysVoteENT.pubParentId = objvSysVoteENS.pubParentId; //公共父Id
        objvSysVoteENT.voteTypeId = objvSysVoteENS.voteTypeId; //点赞类型Id
        objvSysVoteENT.voteTypeName = objvSysVoteENS.voteTypeName; //点赞类型名称
        objvSysVoteENT.updUser = objvSysVoteENS.updUser; //修改人
        objvSysVoteENT.voteTable = objvSysVoteENS.voteTable; //点赞表
        objvSysVoteENT.updDate = objvSysVoteENS.updDate; //修改日期
        objvSysVoteENT.voteTableId = objvSysVoteENS.voteTableId; //点赞表Id
        objvSysVoteENT.memo = objvSysVoteENS.memo; //备注
        objvSysVoteENT.id_CurrEduCls = objvSysVoteENS.id_CurrEduCls; //教学班流水号
        objvSysVoteENT.userId = objvSysVoteENS.userId; //用户ID
    }
    exports.vSysVote_CopyObjTo = vSysVote_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objvSysVoteENS:源对象
     * @param objvSysVoteENT:目标对象
    */
    function vSysVote_GetObjFromJsonObj(objvSysVoteENS) {
        const objvSysVoteENT = new clsvSysVoteEN_js_1.clsvSysVoteEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvSysVoteENT, objvSysVoteENS);
        return objvSysVoteENT;
    }
    exports.vSysVote_GetObjFromJsonObj = vSysVote_GetObjFromJsonObj;
});
