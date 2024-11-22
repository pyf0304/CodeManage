/**
* 类名:clsFeedBackWApi
* 表名:FeedBack(01120279)
* 生成代码版本:2022.11.02.1
* 生成日期:2022/11/02 11:46:17
* 生成者:pyf
* 生成服务器IP:
工程名称:问卷调查(0112)
CM工程:研究生论文学习(变量首字母小写)-全部函数集
* 相关数据库:103.116.76.183,9433EduHigh_Jsie
* PrjDataBaseId:0170
模块中文名:新闻公告(NewsAnnouncement)
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
        define(["require", "exports", "axios", "../../L0_Entity/NewsAnnouncement/clsFeedBackEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsSysPara4WebApi.js", "../../PubFun/jsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.FeedBack_GetObjFromJsonObj = exports.FeedBack_CopyObjTo = exports.FeedBack_GetUniCondStr4Update_NickName_FeedBackNumber = exports.FeedBack_GetUniCondStr_NickName_FeedBackNumber = exports.FeedBack_GetCombineCondition = exports.FeedBack_GetObjByJSONStr = exports.FeedBack_GetObjLstByJSONObjLst = exports.FeedBack_GetObjLstByJSONStr = exports.FeedBack_GetJSONStrByObj = exports.FeedBack_CheckProperty4Update = exports.FeedBack_CheckPropertyNew = exports.FeedBack_GetWebApiUrl = exports.FeedBack_GetMaxStrIdByPrefix = exports.FeedBack_GetRecCountByCondAsync = exports.FeedBack_IsExistAsync = exports.FeedBack_IsExist = exports.FeedBack_IsExistRecordAsync = exports.FeedBack_UpdateWithConditionAsync = exports.FeedBack_UpdateRecordAsync = exports.FeedBack_AddNewRecordWithReturnKey = exports.FeedBack_AddNewRecordWithReturnKeyAsync = exports.FeedBack_AddNewRecordAsync = exports.FeedBack_DelFeedBacksByCondAsync = exports.FeedBack_DelFeedBacksAsync = exports.FeedBack_DelRecordAsync = exports.FeedBack_GetObjLstByPagerAsync = exports.FeedBack_GetObjLstByRange = exports.FeedBack_GetObjLstByRangeAsync = exports.FeedBack_GetTopObjLstAsync = exports.FeedBack_GetObjLstByFeedBackIdLstAsync = exports.FeedBack_GetObjLstAsync = exports.FeedBack_GetFirstObjAsync = exports.FeedBack_GetFirstID = exports.FeedBack_GetFirstIDAsync = exports.FeedBack_FilterFunByKey = exports.FeedBack_SortFunByKey = exports.FeedBack_SortFun_Defa_2Fld = exports.FeedBack_SortFun_Defa = exports.FeedBack_GetObjByFeedBackIdAsync = exports.feedBack_ConstructorName = exports.feedBack_Controller = void 0;
    /**
     * 反馈意见(FeedBack)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2022年11月02日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const clsFeedBackEN_js_1 = require("../../L0_Entity/NewsAnnouncement/clsFeedBackEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    const jsString_js_1 = require("../../PubFun/jsString.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.feedBack_Controller = "FeedBackApi";
    exports.feedBack_ConstructorName = "feedBack";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param lngFeedBackId:关键字
    * @returns 对象
    **/
    async function FeedBack_GetObjByFeedBackIdAsync(lngFeedBackId) {
        const strThisFuncName = "GetObjByFeedBackIdAsync";
        if (lngFeedBackId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngFeedBackId]不能为空！(In GetObjByFeedBackIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByFeedBackId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.feedBack_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "lngFeedBackId": lngFeedBackId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.feedBack_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objFeedBack = FeedBack_GetObjFromJsonObj(returnObj);
                return objFeedBack;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.feedBack_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.feedBack_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.FeedBack_GetObjByFeedBackIdAsync = FeedBack_GetObjByFeedBackIdAsync;
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
    function FeedBack_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.feedBackId - b.feedBackId;
    }
    exports.FeedBack_SortFun_Defa = FeedBack_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function FeedBack_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.nickName == b.nickName)
            return a.feedBackNumber.localeCompare(b.feedBackNumber);
        else
            return a.nickName.localeCompare(b.nickName);
    }
    exports.FeedBack_SortFun_Defa_2Fld = FeedBack_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function FeedBack_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsFeedBackEN_js_1.clsFeedBackEN.con_FeedBackId:
                    return (a, b) => {
                        return a.feedBackId - b.feedBackId;
                    };
                case clsFeedBackEN_js_1.clsFeedBackEN.con_NickName:
                    return (a, b) => {
                        return a.nickName.localeCompare(b.nickName);
                    };
                case clsFeedBackEN_js_1.clsFeedBackEN.con_FeedBackNumber:
                    return (a, b) => {
                        return a.feedBackNumber.localeCompare(b.feedBackNumber);
                    };
                case clsFeedBackEN_js_1.clsFeedBackEN.con_FeedBackContent:
                    return (a, b) => {
                        return a.feedBackContent.localeCompare(b.feedBackContent);
                    };
                case clsFeedBackEN_js_1.clsFeedBackEN.con_Email:
                    return (a, b) => {
                        return a.email.localeCompare(b.email);
                    };
                case clsFeedBackEN_js_1.clsFeedBackEN.con_Telephone:
                    return (a, b) => {
                        return a.telephone.localeCompare(b.telephone);
                    };
                case clsFeedBackEN_js_1.clsFeedBackEN.con_UpdDate:
                    return (a, b) => {
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsFeedBackEN_js_1.clsFeedBackEN.con_Memo:
                    return (a, b) => {
                        return a.memo.localeCompare(b.memo);
                    };
                case clsFeedBackEN_js_1.clsFeedBackEN.con_UpdUser:
                    return (a, b) => {
                        return a.updUser.localeCompare(b.updUser);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[FeedBack]中不存在！(in ${exports.feedBack_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsFeedBackEN_js_1.clsFeedBackEN.con_FeedBackId:
                    return (a, b) => {
                        return b.feedBackId - a.feedBackId;
                    };
                case clsFeedBackEN_js_1.clsFeedBackEN.con_NickName:
                    return (a, b) => {
                        return b.nickName.localeCompare(a.nickName);
                    };
                case clsFeedBackEN_js_1.clsFeedBackEN.con_FeedBackNumber:
                    return (a, b) => {
                        return b.feedBackNumber.localeCompare(a.feedBackNumber);
                    };
                case clsFeedBackEN_js_1.clsFeedBackEN.con_FeedBackContent:
                    return (a, b) => {
                        return b.feedBackContent.localeCompare(a.feedBackContent);
                    };
                case clsFeedBackEN_js_1.clsFeedBackEN.con_Email:
                    return (a, b) => {
                        return b.email.localeCompare(a.email);
                    };
                case clsFeedBackEN_js_1.clsFeedBackEN.con_Telephone:
                    return (a, b) => {
                        return b.telephone.localeCompare(a.telephone);
                    };
                case clsFeedBackEN_js_1.clsFeedBackEN.con_UpdDate:
                    return (a, b) => {
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsFeedBackEN_js_1.clsFeedBackEN.con_Memo:
                    return (a, b) => {
                        return b.memo.localeCompare(a.memo);
                    };
                case clsFeedBackEN_js_1.clsFeedBackEN.con_UpdUser:
                    return (a, b) => {
                        return b.updUser.localeCompare(a.updUser);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[FeedBack]中不存在！(in ${exports.feedBack_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.FeedBack_SortFunByKey = FeedBack_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function FeedBack_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsFeedBackEN_js_1.clsFeedBackEN.con_FeedBackId:
                return (obj) => {
                    return obj.feedBackId === value;
                };
            case clsFeedBackEN_js_1.clsFeedBackEN.con_NickName:
                return (obj) => {
                    return obj.nickName === value;
                };
            case clsFeedBackEN_js_1.clsFeedBackEN.con_FeedBackNumber:
                return (obj) => {
                    return obj.feedBackNumber === value;
                };
            case clsFeedBackEN_js_1.clsFeedBackEN.con_FeedBackContent:
                return (obj) => {
                    return obj.feedBackContent === value;
                };
            case clsFeedBackEN_js_1.clsFeedBackEN.con_Email:
                return (obj) => {
                    return obj.email === value;
                };
            case clsFeedBackEN_js_1.clsFeedBackEN.con_Telephone:
                return (obj) => {
                    return obj.telephone === value;
                };
            case clsFeedBackEN_js_1.clsFeedBackEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsFeedBackEN_js_1.clsFeedBackEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            case clsFeedBackEN_js_1.clsFeedBackEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[FeedBack]中不存在！(in ${exports.feedBack_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.FeedBack_FilterFunByKey = FeedBack_FilterFunByKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function FeedBack_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.feedBack_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.feedBack_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.feedBack_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.FeedBack_GetFirstIDAsync = FeedBack_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function FeedBack_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.feedBack_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.feedBack_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.feedBack_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.FeedBack_GetFirstID = FeedBack_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function FeedBack_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.feedBack_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.feedBack_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objFeedBack = FeedBack_GetObjFromJsonObj(returnObj);
                return objFeedBack;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.feedBack_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.feedBack_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.FeedBack_GetFirstObjAsync = FeedBack_GetFirstObjAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function FeedBack_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.feedBack_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.feedBack_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = FeedBack_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.feedBack_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.feedBack_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.FeedBack_GetObjLstAsync = FeedBack_GetObjLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrFeedBackId:关键字列表
    * @returns 对象列表
    **/
    async function FeedBack_GetObjLstByFeedBackIdLstAsync(arrFeedBackId) {
        const strThisFuncName = "GetObjLstByFeedBackIdLstAsync";
        const strAction = "GetObjLstByFeedBackIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.feedBack_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrFeedBackId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.feedBack_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = FeedBack_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.feedBack_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.feedBack_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.FeedBack_GetObjLstByFeedBackIdLstAsync = FeedBack_GetObjLstByFeedBackIdLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function FeedBack_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.feedBack_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.feedBack_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = FeedBack_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.feedBack_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.feedBack_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.FeedBack_GetTopObjLstAsync = FeedBack_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function FeedBack_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.feedBack_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.feedBack_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = FeedBack_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.feedBack_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.feedBack_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.FeedBack_GetObjLstByRangeAsync = FeedBack_GetObjLstByRangeAsync;
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
    async function FeedBack_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.feedBack_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.feedBack_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.feedBack_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.FeedBack_GetObjLstByRange = FeedBack_GetObjLstByRange;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function FeedBack_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.feedBack_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.feedBack_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = FeedBack_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.feedBack_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.feedBack_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.FeedBack_GetObjLstByPagerAsync = FeedBack_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param lngFeedBackId:关键字
    * @returns 获取删除的结果
    **/
    async function FeedBack_DelRecordAsync(lngFeedBackId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.feedBack_Controller, strAction);
        strUrl = (0, clsString_js_1.Format)("{0}/?Id={1}", strUrl, lngFeedBackId);
        try {
            const response = await axios_1.default.delete(strUrl, {
                params: { "Id": lngFeedBackId, }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.feedBack_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.feedBack_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.FeedBack_DelRecordAsync = FeedBack_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrFeedBackId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function FeedBack_DelFeedBacksAsync(arrFeedBackId) {
        const strThisFuncName = "DelFeedBacksAsync";
        const strAction = "DelFeedBacks";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.feedBack_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrFeedBackId);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.feedBack_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.feedBack_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.FeedBack_DelFeedBacksAsync = FeedBack_DelFeedBacksAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function FeedBack_DelFeedBacksByCondAsync(strWhereCond) {
        const strThisFuncName = "DelFeedBacksByCondAsync";
        const strAction = "DelFeedBacksByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.feedBack_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.feedBack_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.feedBack_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.FeedBack_DelFeedBacksByCondAsync = FeedBack_DelFeedBacksByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objFeedBackEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function FeedBack_AddNewRecordAsync(objFeedBackEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objFeedBackEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.feedBack_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objFeedBackEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.feedBack_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.feedBack_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.FeedBack_AddNewRecordAsync = FeedBack_AddNewRecordAsync;
    /* 数据类型不是字符型，不可以最大关键字的方式添加记录。*/
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objFeedBackEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function FeedBack_AddNewRecordWithReturnKeyAsync(objFeedBackEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.feedBack_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objFeedBackEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.feedBack_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.feedBack_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.FeedBack_AddNewRecordWithReturnKeyAsync = FeedBack_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objFeedBackEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function FeedBack_AddNewRecordWithReturnKey(objFeedBackEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objFeedBackEN.feedBackId === null || objFeedBackEN.feedBackId === 0) {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.feedBack_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objFeedBackEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.feedBack_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.feedBack_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.FeedBack_AddNewRecordWithReturnKey = FeedBack_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objFeedBackEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function FeedBack_UpdateRecordAsync(objFeedBackEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objFeedBackEN.sf_UpdFldSetStr === undefined || objFeedBackEN.sf_UpdFldSetStr === null || objFeedBackEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objFeedBackEN.feedBackId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.feedBack_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objFeedBackEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.feedBack_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.feedBack_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.FeedBack_UpdateRecordAsync = FeedBack_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objFeedBackEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function FeedBack_UpdateWithConditionAsync(objFeedBackEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objFeedBackEN.sf_UpdFldSetStr === undefined || objFeedBackEN.sf_UpdFldSetStr === null || objFeedBackEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objFeedBackEN.feedBackId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.feedBack_Controller, strAction);
        objFeedBackEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objFeedBackEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.feedBack_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.feedBack_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.FeedBack_UpdateWithConditionAsync = FeedBack_UpdateWithConditionAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function FeedBack_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.feedBack_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.feedBack_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.feedBack_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.FeedBack_IsExistRecordAsync = FeedBack_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param lngFeedBackId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function FeedBack_IsExist(lngFeedBackId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.feedBack_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "feedBackId": lngFeedBackId,
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.feedBack_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.feedBack_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.FeedBack_IsExist = FeedBack_IsExist;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param lngFeedBackId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function FeedBack_IsExistAsync(lngFeedBackId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.feedBack_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "lngFeedBackId": lngFeedBackId }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.feedBack_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.feedBack_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.FeedBack_IsExistAsync = FeedBack_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function FeedBack_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.feedBack_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.feedBack_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.feedBack_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.FeedBack_GetRecCountByCondAsync = FeedBack_GetRecCountByCondAsync;
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
    async function FeedBack_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.feedBack_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.feedBack_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.feedBack_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.FeedBack_GetMaxStrIdByPrefix = FeedBack_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function FeedBack_GetWebApiUrl(strController, strAction) {
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
    exports.FeedBack_GetWebApiUrl = FeedBack_GetWebApiUrl;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function FeedBack_CheckPropertyNew(pobjFeedBackEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjFeedBackEN.nickName) === true) {
            throw new Error("(errid:Watl000058)字段[昵称]不能为空(In 反馈意见)!(clsFeedBackBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjFeedBackEN.updUser) === true) {
            throw new Error("(errid:Watl000058)字段[修改人]不能为空(In 反馈意见)!(clsFeedBackBL:CheckPropertyNew)");
        }
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjFeedBackEN.nickName) == false && (0, clsString_js_1.GetStrLen)(pobjFeedBackEN.nickName) > 50) {
            throw new Error("(errid:Watl000059)字段[昵称(nickName)]的长度不能超过50(In 反馈意见(FeedBack))!值:$(pobjFeedBackEN.nickName)(clsFeedBackBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjFeedBackEN.feedBackNumber) == false && (0, clsString_js_1.GetStrLen)(pobjFeedBackEN.feedBackNumber) > 50) {
            throw new Error("(errid:Watl000059)字段[feedBackNumber(feedBackNumber)]的长度不能超过50(In 反馈意见(FeedBack))!值:$(pobjFeedBackEN.feedBackNumber)(clsFeedBackBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjFeedBackEN.feedBackContent) == false && (0, clsString_js_1.GetStrLen)(pobjFeedBackEN.feedBackContent) > 1000) {
            throw new Error("(errid:Watl000059)字段[feedBackContent(feedBackContent)]的长度不能超过1000(In 反馈意见(FeedBack))!值:$(pobjFeedBackEN.feedBackContent)(clsFeedBackBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjFeedBackEN.email) == false && (0, clsString_js_1.GetStrLen)(pobjFeedBackEN.email) > 100) {
            throw new Error("(errid:Watl000059)字段[电子邮箱(email)]的长度不能超过100(In 反馈意见(FeedBack))!值:$(pobjFeedBackEN.email)(clsFeedBackBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjFeedBackEN.telephone) == false && (0, clsString_js_1.GetStrLen)(pobjFeedBackEN.telephone) > 200) {
            throw new Error("(errid:Watl000059)字段[telephone(telephone)]的长度不能超过200(In 反馈意见(FeedBack))!值:$(pobjFeedBackEN.telephone)(clsFeedBackBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjFeedBackEN.updDate) == false && (0, clsString_js_1.GetStrLen)(pobjFeedBackEN.updDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 反馈意见(FeedBack))!值:$(pobjFeedBackEN.updDate)(clsFeedBackBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjFeedBackEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjFeedBackEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 反馈意见(FeedBack))!值:$(pobjFeedBackEN.memo)(clsFeedBackBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjFeedBackEN.updUser) == false && (0, clsString_js_1.GetStrLen)(pobjFeedBackEN.updUser) > 20) {
            throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 反馈意见(FeedBack))!值:$(pobjFeedBackEN.updUser)(clsFeedBackBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if (null != pobjFeedBackEN.feedBackId && undefined !== pobjFeedBackEN.feedBackId && jsString_js_1.tzDataType.isNumber(pobjFeedBackEN.feedBackId) === false) {
            throw new Error("(errid:Watl000060)字段[feedBackId(feedBackId)]的值:[$(pobjFeedBackEN.feedBackId)], 非法，应该为数值型(In 反馈意见(FeedBack))!(clsFeedBackBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjFeedBackEN.nickName) == false && undefined !== pobjFeedBackEN.nickName && jsString_js_1.tzDataType.isString(pobjFeedBackEN.nickName) === false) {
            throw new Error("(errid:Watl000060)字段[昵称(nickName)]的值:[$(pobjFeedBackEN.nickName)], 非法，应该为字符型(In 反馈意见(FeedBack))!(clsFeedBackBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjFeedBackEN.feedBackNumber) == false && undefined !== pobjFeedBackEN.feedBackNumber && jsString_js_1.tzDataType.isString(pobjFeedBackEN.feedBackNumber) === false) {
            throw new Error("(errid:Watl000060)字段[feedBackNumber(feedBackNumber)]的值:[$(pobjFeedBackEN.feedBackNumber)], 非法，应该为字符型(In 反馈意见(FeedBack))!(clsFeedBackBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjFeedBackEN.feedBackContent) == false && undefined !== pobjFeedBackEN.feedBackContent && jsString_js_1.tzDataType.isString(pobjFeedBackEN.feedBackContent) === false) {
            throw new Error("(errid:Watl000060)字段[feedBackContent(feedBackContent)]的值:[$(pobjFeedBackEN.feedBackContent)], 非法，应该为字符型(In 反馈意见(FeedBack))!(clsFeedBackBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjFeedBackEN.email) == false && undefined !== pobjFeedBackEN.email && jsString_js_1.tzDataType.isString(pobjFeedBackEN.email) === false) {
            throw new Error("(errid:Watl000060)字段[电子邮箱(email)]的值:[$(pobjFeedBackEN.email)], 非法，应该为字符型(In 反馈意见(FeedBack))!(clsFeedBackBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjFeedBackEN.telephone) == false && undefined !== pobjFeedBackEN.telephone && jsString_js_1.tzDataType.isString(pobjFeedBackEN.telephone) === false) {
            throw new Error("(errid:Watl000060)字段[telephone(telephone)]的值:[$(pobjFeedBackEN.telephone)], 非法，应该为字符型(In 反馈意见(FeedBack))!(clsFeedBackBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjFeedBackEN.updDate) == false && undefined !== pobjFeedBackEN.updDate && jsString_js_1.tzDataType.isString(pobjFeedBackEN.updDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjFeedBackEN.updDate)], 非法，应该为字符型(In 反馈意见(FeedBack))!(clsFeedBackBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjFeedBackEN.memo) == false && undefined !== pobjFeedBackEN.memo && jsString_js_1.tzDataType.isString(pobjFeedBackEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjFeedBackEN.memo)], 非法，应该为字符型(In 反馈意见(FeedBack))!(clsFeedBackBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjFeedBackEN.updUser) == false && undefined !== pobjFeedBackEN.updUser && jsString_js_1.tzDataType.isString(pobjFeedBackEN.updUser) === false) {
            throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjFeedBackEN.updUser)], 非法，应该为字符型(In 反馈意见(FeedBack))!(clsFeedBackBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjFeedBackEN.SetIsCheckProperty(true);
    }
    exports.FeedBack_CheckPropertyNew = FeedBack_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function FeedBack_CheckProperty4Update(pobjFeedBackEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjFeedBackEN.nickName) == false && (0, clsString_js_1.GetStrLen)(pobjFeedBackEN.nickName) > 50) {
            throw new Error("(errid:Watl000062)字段[昵称(nickName)]的长度不能超过50(In 反馈意见(FeedBack))!值:$(pobjFeedBackEN.nickName)(clsFeedBackBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjFeedBackEN.feedBackNumber) == false && (0, clsString_js_1.GetStrLen)(pobjFeedBackEN.feedBackNumber) > 50) {
            throw new Error("(errid:Watl000062)字段[feedBackNumber(feedBackNumber)]的长度不能超过50(In 反馈意见(FeedBack))!值:$(pobjFeedBackEN.feedBackNumber)(clsFeedBackBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjFeedBackEN.feedBackContent) == false && (0, clsString_js_1.GetStrLen)(pobjFeedBackEN.feedBackContent) > 1000) {
            throw new Error("(errid:Watl000062)字段[feedBackContent(feedBackContent)]的长度不能超过1000(In 反馈意见(FeedBack))!值:$(pobjFeedBackEN.feedBackContent)(clsFeedBackBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjFeedBackEN.email) == false && (0, clsString_js_1.GetStrLen)(pobjFeedBackEN.email) > 100) {
            throw new Error("(errid:Watl000062)字段[电子邮箱(email)]的长度不能超过100(In 反馈意见(FeedBack))!值:$(pobjFeedBackEN.email)(clsFeedBackBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjFeedBackEN.telephone) == false && (0, clsString_js_1.GetStrLen)(pobjFeedBackEN.telephone) > 200) {
            throw new Error("(errid:Watl000062)字段[telephone(telephone)]的长度不能超过200(In 反馈意见(FeedBack))!值:$(pobjFeedBackEN.telephone)(clsFeedBackBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjFeedBackEN.updDate) == false && (0, clsString_js_1.GetStrLen)(pobjFeedBackEN.updDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 反馈意见(FeedBack))!值:$(pobjFeedBackEN.updDate)(clsFeedBackBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjFeedBackEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjFeedBackEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 反馈意见(FeedBack))!值:$(pobjFeedBackEN.memo)(clsFeedBackBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjFeedBackEN.updUser) == false && (0, clsString_js_1.GetStrLen)(pobjFeedBackEN.updUser) > 20) {
            throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 反馈意见(FeedBack))!值:$(pobjFeedBackEN.updUser)(clsFeedBackBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if (null != pobjFeedBackEN.feedBackId && undefined !== pobjFeedBackEN.feedBackId && jsString_js_1.tzDataType.isNumber(pobjFeedBackEN.feedBackId) === false) {
            throw new Error("(errid:Watl000063)字段[feedBackId(feedBackId)]的值:[$(pobjFeedBackEN.feedBackId)], 非法，应该为数值型(In 反馈意见(FeedBack))!(clsFeedBackBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjFeedBackEN.nickName) == false && undefined !== pobjFeedBackEN.nickName && jsString_js_1.tzDataType.isString(pobjFeedBackEN.nickName) === false) {
            throw new Error("(errid:Watl000063)字段[昵称(nickName)]的值:[$(pobjFeedBackEN.nickName)], 非法，应该为字符型(In 反馈意见(FeedBack))!(clsFeedBackBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjFeedBackEN.feedBackNumber) == false && undefined !== pobjFeedBackEN.feedBackNumber && jsString_js_1.tzDataType.isString(pobjFeedBackEN.feedBackNumber) === false) {
            throw new Error("(errid:Watl000063)字段[feedBackNumber(feedBackNumber)]的值:[$(pobjFeedBackEN.feedBackNumber)], 非法，应该为字符型(In 反馈意见(FeedBack))!(clsFeedBackBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjFeedBackEN.feedBackContent) == false && undefined !== pobjFeedBackEN.feedBackContent && jsString_js_1.tzDataType.isString(pobjFeedBackEN.feedBackContent) === false) {
            throw new Error("(errid:Watl000063)字段[feedBackContent(feedBackContent)]的值:[$(pobjFeedBackEN.feedBackContent)], 非法，应该为字符型(In 反馈意见(FeedBack))!(clsFeedBackBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjFeedBackEN.email) == false && undefined !== pobjFeedBackEN.email && jsString_js_1.tzDataType.isString(pobjFeedBackEN.email) === false) {
            throw new Error("(errid:Watl000063)字段[电子邮箱(email)]的值:[$(pobjFeedBackEN.email)], 非法，应该为字符型(In 反馈意见(FeedBack))!(clsFeedBackBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjFeedBackEN.telephone) == false && undefined !== pobjFeedBackEN.telephone && jsString_js_1.tzDataType.isString(pobjFeedBackEN.telephone) === false) {
            throw new Error("(errid:Watl000063)字段[telephone(telephone)]的值:[$(pobjFeedBackEN.telephone)], 非法，应该为字符型(In 反馈意见(FeedBack))!(clsFeedBackBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjFeedBackEN.updDate) == false && undefined !== pobjFeedBackEN.updDate && jsString_js_1.tzDataType.isString(pobjFeedBackEN.updDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjFeedBackEN.updDate)], 非法，应该为字符型(In 反馈意见(FeedBack))!(clsFeedBackBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjFeedBackEN.memo) == false && undefined !== pobjFeedBackEN.memo && jsString_js_1.tzDataType.isString(pobjFeedBackEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjFeedBackEN.memo)], 非法，应该为字符型(In 反馈意见(FeedBack))!(clsFeedBackBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjFeedBackEN.updUser) == false && undefined !== pobjFeedBackEN.updUser && jsString_js_1.tzDataType.isString(pobjFeedBackEN.updUser) === false) {
            throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjFeedBackEN.updUser)], 非法，应该为字符型(In 反馈意见(FeedBack))!(clsFeedBackBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if (null === pobjFeedBackEN.feedBackId
            || pobjFeedBackEN.feedBackId != null && pobjFeedBackEN.feedBackId.toString() === "") {
            throw new Error("(errid:Watl000064)字段[feedBackId]不能为空(In 反馈意见)!(clsFeedBackBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjFeedBackEN.SetIsCheckProperty(true);
    }
    exports.FeedBack_CheckProperty4Update = FeedBack_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function FeedBack_GetJSONStrByObj(pobjFeedBackEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjFeedBackEN.sf_UpdFldSetStr = pobjFeedBackEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjFeedBackEN);
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
    exports.FeedBack_GetJSONStrByObj = FeedBack_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function FeedBack_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrFeedBackObjLst = new Array();
        if (strJSON === "") {
            return arrFeedBackObjLst;
        }
        try {
            arrFeedBackObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrFeedBackObjLst;
        }
        return arrFeedBackObjLst;
    }
    exports.FeedBack_GetObjLstByJSONStr = FeedBack_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrFeedBackObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function FeedBack_GetObjLstByJSONObjLst(arrFeedBackObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrFeedBackObjLst = new Array();
        for (const objInFor of arrFeedBackObjLstS) {
            const obj1 = FeedBack_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrFeedBackObjLst.push(obj1);
        }
        return arrFeedBackObjLst;
    }
    exports.FeedBack_GetObjLstByJSONObjLst = FeedBack_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function FeedBack_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjFeedBackEN = new clsFeedBackEN_js_1.clsFeedBackEN();
        if (strJSON === "") {
            return pobjFeedBackEN;
        }
        try {
            pobjFeedBackEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjFeedBackEN;
        }
        return pobjFeedBackEN;
    }
    exports.FeedBack_GetObjByJSONStr = FeedBack_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function FeedBack_GetCombineCondition(objFeedBack_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objFeedBack_Cond.dicFldComparisonOp, clsFeedBackEN_js_1.clsFeedBackEN.con_FeedBackId) == true) {
            const strComparisonOp_FeedBackId = objFeedBack_Cond.dicFldComparisonOp[clsFeedBackEN_js_1.clsFeedBackEN.con_FeedBackId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsFeedBackEN_js_1.clsFeedBackEN.con_FeedBackId, objFeedBack_Cond.feedBackId, strComparisonOp_FeedBackId);
        }
        if (Object.prototype.hasOwnProperty.call(objFeedBack_Cond.dicFldComparisonOp, clsFeedBackEN_js_1.clsFeedBackEN.con_NickName) == true) {
            const strComparisonOp_NickName = objFeedBack_Cond.dicFldComparisonOp[clsFeedBackEN_js_1.clsFeedBackEN.con_NickName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsFeedBackEN_js_1.clsFeedBackEN.con_NickName, objFeedBack_Cond.nickName, strComparisonOp_NickName);
        }
        if (Object.prototype.hasOwnProperty.call(objFeedBack_Cond.dicFldComparisonOp, clsFeedBackEN_js_1.clsFeedBackEN.con_FeedBackNumber) == true) {
            const strComparisonOp_FeedBackNumber = objFeedBack_Cond.dicFldComparisonOp[clsFeedBackEN_js_1.clsFeedBackEN.con_FeedBackNumber];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsFeedBackEN_js_1.clsFeedBackEN.con_FeedBackNumber, objFeedBack_Cond.feedBackNumber, strComparisonOp_FeedBackNumber);
        }
        if (Object.prototype.hasOwnProperty.call(objFeedBack_Cond.dicFldComparisonOp, clsFeedBackEN_js_1.clsFeedBackEN.con_FeedBackContent) == true) {
            const strComparisonOp_FeedBackContent = objFeedBack_Cond.dicFldComparisonOp[clsFeedBackEN_js_1.clsFeedBackEN.con_FeedBackContent];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsFeedBackEN_js_1.clsFeedBackEN.con_FeedBackContent, objFeedBack_Cond.feedBackContent, strComparisonOp_FeedBackContent);
        }
        if (Object.prototype.hasOwnProperty.call(objFeedBack_Cond.dicFldComparisonOp, clsFeedBackEN_js_1.clsFeedBackEN.con_Email) == true) {
            const strComparisonOp_Email = objFeedBack_Cond.dicFldComparisonOp[clsFeedBackEN_js_1.clsFeedBackEN.con_Email];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsFeedBackEN_js_1.clsFeedBackEN.con_Email, objFeedBack_Cond.email, strComparisonOp_Email);
        }
        if (Object.prototype.hasOwnProperty.call(objFeedBack_Cond.dicFldComparisonOp, clsFeedBackEN_js_1.clsFeedBackEN.con_Telephone) == true) {
            const strComparisonOp_Telephone = objFeedBack_Cond.dicFldComparisonOp[clsFeedBackEN_js_1.clsFeedBackEN.con_Telephone];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsFeedBackEN_js_1.clsFeedBackEN.con_Telephone, objFeedBack_Cond.telephone, strComparisonOp_Telephone);
        }
        if (Object.prototype.hasOwnProperty.call(objFeedBack_Cond.dicFldComparisonOp, clsFeedBackEN_js_1.clsFeedBackEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objFeedBack_Cond.dicFldComparisonOp[clsFeedBackEN_js_1.clsFeedBackEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsFeedBackEN_js_1.clsFeedBackEN.con_UpdDate, objFeedBack_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objFeedBack_Cond.dicFldComparisonOp, clsFeedBackEN_js_1.clsFeedBackEN.con_Memo) == true) {
            const strComparisonOp_Memo = objFeedBack_Cond.dicFldComparisonOp[clsFeedBackEN_js_1.clsFeedBackEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsFeedBackEN_js_1.clsFeedBackEN.con_Memo, objFeedBack_Cond.memo, strComparisonOp_Memo);
        }
        if (Object.prototype.hasOwnProperty.call(objFeedBack_Cond.dicFldComparisonOp, clsFeedBackEN_js_1.clsFeedBackEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objFeedBack_Cond.dicFldComparisonOp[clsFeedBackEN_js_1.clsFeedBackEN.con_UpdUser];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsFeedBackEN_js_1.clsFeedBackEN.con_UpdUser, objFeedBack_Cond.updUser, strComparisonOp_UpdUser);
        }
        return strWhereCond;
    }
    exports.FeedBack_GetCombineCondition = FeedBack_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--FeedBack(反馈意见),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param strNickName: 昵称(要求唯一的字段)
    * @param strFeedBackNumber: feedBackNumber(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function FeedBack_GetUniCondStr_NickName_FeedBackNumber(objFeedBackEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and nickName = '{0}'", objFeedBackEN.nickName);
        strWhereCond += (0, clsString_js_1.Format)(" and feedBackNumber = '{0}'", objFeedBackEN.feedBackNumber);
        return strWhereCond;
    }
    exports.FeedBack_GetUniCondStr_NickName_FeedBackNumber = FeedBack_GetUniCondStr_NickName_FeedBackNumber;
    /**
    *获取唯一性条件串(Uniqueness)--FeedBack(反馈意见),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param strNickName: 昵称(要求唯一的字段)
    * @param strFeedBackNumber: feedBackNumber(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function FeedBack_GetUniCondStr4Update_NickName_FeedBackNumber(objFeedBackEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and feedBackId <> '{0}'", objFeedBackEN.feedBackId);
        strWhereCond += (0, clsString_js_1.Format)(" and nickName = '{0}'", objFeedBackEN.nickName);
        strWhereCond += (0, clsString_js_1.Format)(" and feedBackNumber = '{0}'", objFeedBackEN.feedBackNumber);
        return strWhereCond;
    }
    exports.FeedBack_GetUniCondStr4Update_NickName_FeedBackNumber = FeedBack_GetUniCondStr4Update_NickName_FeedBackNumber;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objFeedBackENS:源对象
     * @param objFeedBackENT:目标对象
    */
    function FeedBack_CopyObjTo(objFeedBackENS, objFeedBackENT) {
        objFeedBackENT.feedBackId = objFeedBackENS.feedBackId; //feedBackId
        objFeedBackENT.nickName = objFeedBackENS.nickName; //昵称
        objFeedBackENT.feedBackNumber = objFeedBackENS.feedBackNumber; //feedBackNumber
        objFeedBackENT.feedBackContent = objFeedBackENS.feedBackContent; //feedBackContent
        objFeedBackENT.email = objFeedBackENS.email; //电子邮箱
        objFeedBackENT.telephone = objFeedBackENS.telephone; //telephone
        objFeedBackENT.updDate = objFeedBackENS.updDate; //修改日期
        objFeedBackENT.memo = objFeedBackENS.memo; //备注
        objFeedBackENT.updUser = objFeedBackENS.updUser; //修改人
        objFeedBackENT.sf_UpdFldSetStr = objFeedBackENS.updFldString; //sf_UpdFldSetStr
    }
    exports.FeedBack_CopyObjTo = FeedBack_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objFeedBackENS:源对象
     * @param objFeedBackENT:目标对象
    */
    function FeedBack_GetObjFromJsonObj(objFeedBackENS) {
        const objFeedBackENT = new clsFeedBackEN_js_1.clsFeedBackEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objFeedBackENT, objFeedBackENS);
        return objFeedBackENT;
    }
    exports.FeedBack_GetObjFromJsonObj = FeedBack_GetObjFromJsonObj;
});
