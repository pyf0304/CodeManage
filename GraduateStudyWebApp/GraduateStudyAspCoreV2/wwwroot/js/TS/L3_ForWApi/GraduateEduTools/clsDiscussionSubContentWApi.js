/**
* 类名:clsDiscussionSubContentWApi
* 表名:DiscussionSubContent(01120587)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/13 00:43:45
* 生成者:pyf
* 生成服务器IP:
工程名称:问卷调查(0112)
CM工程:研究生论文学习(变量首字母小写)-全部函数集
* 相关数据库:103.116.76.183,9433EduHigh_Jsie
* PrjDataBaseId:0170
模块中文名:研培设置(GraduateEduTools)
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
        define(["require", "exports", "axios", "../../L0_Entity/GraduateEduTools/clsDiscussionSubContentEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.DiscussionSubContent_GetObjFromJsonObj = exports.DiscussionSubContent_CopyObjTo = exports.DiscussionSubContent_GetUniCondStr4Update_SubContentId = exports.DiscussionSubContent_GetUniCondStr_SubContentId = exports.DiscussionSubContent_GetCombineCondition = exports.DiscussionSubContent_GetObjByJSONStr = exports.DiscussionSubContent_GetObjLstByJSONObjLst = exports.DiscussionSubContent_GetObjLstByJSONStr = exports.DiscussionSubContent_GetJSONStrByObj = exports.DiscussionSubContent_CheckProperty4Update = exports.DiscussionSubContent_CheckPropertyNew = exports.DiscussionSubContent_GetWebApiUrl = exports.DiscussionSubContent_GetMaxStrIdByPrefix = exports.DiscussionSubContent_GetMaxStrIdAsync = exports.DiscussionSubContent_GetRecCountByCondAsync = exports.DiscussionSubContent_IsExistAsync = exports.DiscussionSubContent_IsExist = exports.DiscussionSubContent_IsExistRecordAsync = exports.DiscussionSubContent_UpdateWithConditionAsync = exports.DiscussionSubContent_UpdateRecordAsync = exports.DiscussionSubContent_AddNewRecordWithReturnKey = exports.DiscussionSubContent_AddNewRecordWithReturnKeyAsync = exports.DiscussionSubContent_AddNewRecordWithMaxIdAsync = exports.DiscussionSubContent_AddNewRecordAsync = exports.DiscussionSubContent_DelDiscussionSubContentsByCondAsync = exports.DiscussionSubContent_DelDiscussionSubContentsAsync = exports.DiscussionSubContent_DelRecordAsync = exports.DiscussionSubContent_GetObjLstByPagerAsync = exports.DiscussionSubContent_GetObjLstByRange = exports.DiscussionSubContent_GetObjLstByRangeAsync = exports.DiscussionSubContent_GetTopObjLstAsync = exports.DiscussionSubContent_GetObjLstBySubContentIdLstAsync = exports.DiscussionSubContent_GetObjLstAsync = exports.DiscussionSubContent_GetFirstObjAsync = exports.DiscussionSubContent_GetFirstID = exports.DiscussionSubContent_GetFirstIDAsync = exports.DiscussionSubContent_FilterFunByKey = exports.DiscussionSubContent_SortFunByKey = exports.DiscussionSubContent_SortFun_Defa_2Fld = exports.DiscussionSubContent_SortFun_Defa = exports.DiscussionSubContent_GetObjBySubContentIdAsync = exports.discussionSubContent_ConstructorName = exports.discussionSubContent_Controller = void 0;
    /**
     * 讨论子内容(DiscussionSubContent)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月13日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const clsDiscussionSubContentEN_js_1 = require("../../L0_Entity/GraduateEduTools/clsDiscussionSubContentEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsString_js_2 = require("../../PubFun/clsString.js");
    exports.discussionSubContent_Controller = "DiscussionSubContentApi";
    exports.discussionSubContent_ConstructorName = "discussionSubContent";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strSubContentId:关键字
    * @returns 对象
    **/
    async function DiscussionSubContent_GetObjBySubContentIdAsync(strSubContentId) {
        const strThisFuncName = "GetObjBySubContentIdAsync";
        if ((0, clsString_js_2.IsNullOrEmpty)(strSubContentId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strSubContentId]不能为空！(In clsDiscussionSubContentWApi.GetObjBySubContentIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strSubContentId.length != 10) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strSubContentId]的长度:[{0}]不正确！(clsDiscussionSubContentWApi.GetObjBySubContentIdAsync)", strSubContentId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjBySubContentId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.discussionSubContent_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "strSubContentId": strSubContentId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    return null;
                }
                //console.log(returnObj);
                const objDiscussionSubContent = DiscussionSubContent_GetObjFromJsonObj(returnObj);
                return objDiscussionSubContent;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.discussionSubContent_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.discussionSubContent_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.DiscussionSubContent_GetObjBySubContentIdAsync = DiscussionSubContent_GetObjBySubContentIdAsync;
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
    function DiscussionSubContent_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.subContentId.localeCompare(b.subContentId);
    }
    exports.DiscussionSubContent_SortFun_Defa = DiscussionSubContent_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function DiscussionSubContent_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.subContent == b.subContent)
            return a.topicsId.localeCompare(b.topicsId);
        else
            return a.subContent.localeCompare(b.subContent);
    }
    exports.DiscussionSubContent_SortFun_Defa_2Fld = DiscussionSubContent_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function DiscussionSubContent_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsDiscussionSubContentEN_js_1.clsDiscussionSubContentEN.con_SubContentId:
                    return (a, b) => {
                        return a.subContentId.localeCompare(b.subContentId);
                    };
                case clsDiscussionSubContentEN_js_1.clsDiscussionSubContentEN.con_SubContent:
                    return (a, b) => {
                        if (a.subContent == null)
                            return -1;
                        if (b.subContent == null)
                            return 1;
                        return a.subContent.localeCompare(b.subContent);
                    };
                case clsDiscussionSubContentEN_js_1.clsDiscussionSubContentEN.con_TopicsId:
                    return (a, b) => {
                        if (a.topicsId == null)
                            return -1;
                        if (b.topicsId == null)
                            return 1;
                        return a.topicsId.localeCompare(b.topicsId);
                    };
                case clsDiscussionSubContentEN_js_1.clsDiscussionSubContentEN.con_IsTop:
                    return (a, b) => {
                        if (a.isTop == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsDiscussionSubContentEN_js_1.clsDiscussionSubContentEN.con_UpdDate:
                    return (a, b) => {
                        if (a.updDate == null)
                            return -1;
                        if (b.updDate == null)
                            return 1;
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsDiscussionSubContentEN_js_1.clsDiscussionSubContentEN.con_UpdUser:
                    return (a, b) => {
                        if (a.updUser == null)
                            return -1;
                        if (b.updUser == null)
                            return 1;
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsDiscussionSubContentEN_js_1.clsDiscussionSubContentEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                case clsDiscussionSubContentEN_js_1.clsDiscussionSubContentEN.con_ParentId:
                    return (a, b) => {
                        if (a.parentId == null)
                            return -1;
                        if (b.parentId == null)
                            return 1;
                        return a.parentId.localeCompare(b.parentId);
                    };
                case clsDiscussionSubContentEN_js_1.clsDiscussionSubContentEN.con_UserId:
                    return (a, b) => {
                        if (a.userId == null)
                            return -1;
                        if (b.userId == null)
                            return 1;
                        return a.userId.localeCompare(b.userId);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[DiscussionSubContent]中不存在！(in ${exports.discussionSubContent_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsDiscussionSubContentEN_js_1.clsDiscussionSubContentEN.con_SubContentId:
                    return (a, b) => {
                        return b.subContentId.localeCompare(a.subContentId);
                    };
                case clsDiscussionSubContentEN_js_1.clsDiscussionSubContentEN.con_SubContent:
                    return (a, b) => {
                        if (b.subContent == null)
                            return -1;
                        if (a.subContent == null)
                            return 1;
                        return b.subContent.localeCompare(a.subContent);
                    };
                case clsDiscussionSubContentEN_js_1.clsDiscussionSubContentEN.con_TopicsId:
                    return (a, b) => {
                        if (b.topicsId == null)
                            return -1;
                        if (a.topicsId == null)
                            return 1;
                        return b.topicsId.localeCompare(a.topicsId);
                    };
                case clsDiscussionSubContentEN_js_1.clsDiscussionSubContentEN.con_IsTop:
                    return (a, b) => {
                        if (b.isTop == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsDiscussionSubContentEN_js_1.clsDiscussionSubContentEN.con_UpdDate:
                    return (a, b) => {
                        if (b.updDate == null)
                            return -1;
                        if (a.updDate == null)
                            return 1;
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsDiscussionSubContentEN_js_1.clsDiscussionSubContentEN.con_UpdUser:
                    return (a, b) => {
                        if (b.updUser == null)
                            return -1;
                        if (a.updUser == null)
                            return 1;
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsDiscussionSubContentEN_js_1.clsDiscussionSubContentEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                case clsDiscussionSubContentEN_js_1.clsDiscussionSubContentEN.con_ParentId:
                    return (a, b) => {
                        if (b.parentId == null)
                            return -1;
                        if (a.parentId == null)
                            return 1;
                        return b.parentId.localeCompare(a.parentId);
                    };
                case clsDiscussionSubContentEN_js_1.clsDiscussionSubContentEN.con_UserId:
                    return (a, b) => {
                        if (b.userId == null)
                            return -1;
                        if (a.userId == null)
                            return 1;
                        return b.userId.localeCompare(a.userId);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[DiscussionSubContent]中不存在！(in ${exports.discussionSubContent_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.DiscussionSubContent_SortFunByKey = DiscussionSubContent_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function DiscussionSubContent_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsDiscussionSubContentEN_js_1.clsDiscussionSubContentEN.con_SubContentId:
                return (obj) => {
                    return obj.subContentId === value;
                };
            case clsDiscussionSubContentEN_js_1.clsDiscussionSubContentEN.con_SubContent:
                return (obj) => {
                    return obj.subContent === value;
                };
            case clsDiscussionSubContentEN_js_1.clsDiscussionSubContentEN.con_TopicsId:
                return (obj) => {
                    return obj.topicsId === value;
                };
            case clsDiscussionSubContentEN_js_1.clsDiscussionSubContentEN.con_IsTop:
                return (obj) => {
                    return obj.isTop === value;
                };
            case clsDiscussionSubContentEN_js_1.clsDiscussionSubContentEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsDiscussionSubContentEN_js_1.clsDiscussionSubContentEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsDiscussionSubContentEN_js_1.clsDiscussionSubContentEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            case clsDiscussionSubContentEN_js_1.clsDiscussionSubContentEN.con_ParentId:
                return (obj) => {
                    return obj.parentId === value;
                };
            case clsDiscussionSubContentEN_js_1.clsDiscussionSubContentEN.con_UserId:
                return (obj) => {
                    return obj.userId === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[DiscussionSubContent]中不存在！(in ${exports.discussionSubContent_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.DiscussionSubContent_FilterFunByKey = DiscussionSubContent_FilterFunByKey;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function DiscussionSubContent_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.discussionSubContent_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.discussionSubContent_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.discussionSubContent_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.DiscussionSubContent_GetFirstIDAsync = DiscussionSubContent_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function DiscussionSubContent_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.discussionSubContent_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.discussionSubContent_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.discussionSubContent_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.DiscussionSubContent_GetFirstID = DiscussionSubContent_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function DiscussionSubContent_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.discussionSubContent_Controller, strAction);
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
                const objDiscussionSubContent = DiscussionSubContent_GetObjFromJsonObj(returnObj);
                return objDiscussionSubContent;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.discussionSubContent_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.discussionSubContent_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.DiscussionSubContent_GetFirstObjAsync = DiscussionSubContent_GetFirstObjAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function DiscussionSubContent_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.discussionSubContent_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.discussionSubContent_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = DiscussionSubContent_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.discussionSubContent_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.discussionSubContent_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.DiscussionSubContent_GetObjLstAsync = DiscussionSubContent_GetObjLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrSubContentId:关键字列表
    * @returns 对象列表
    **/
    async function DiscussionSubContent_GetObjLstBySubContentIdLstAsync(arrSubContentId) {
        const strThisFuncName = "GetObjLstBySubContentIdLstAsync";
        const strAction = "GetObjLstBySubContentIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.discussionSubContent_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrSubContentId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.discussionSubContent_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = DiscussionSubContent_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.discussionSubContent_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.discussionSubContent_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.DiscussionSubContent_GetObjLstBySubContentIdLstAsync = DiscussionSubContent_GetObjLstBySubContentIdLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function DiscussionSubContent_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.discussionSubContent_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.discussionSubContent_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = DiscussionSubContent_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.discussionSubContent_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.discussionSubContent_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.DiscussionSubContent_GetTopObjLstAsync = DiscussionSubContent_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function DiscussionSubContent_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.discussionSubContent_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.discussionSubContent_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = DiscussionSubContent_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.discussionSubContent_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.discussionSubContent_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.DiscussionSubContent_GetObjLstByRangeAsync = DiscussionSubContent_GetObjLstByRangeAsync;
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
    async function DiscussionSubContent_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.discussionSubContent_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.discussionSubContent_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.discussionSubContent_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.DiscussionSubContent_GetObjLstByRange = DiscussionSubContent_GetObjLstByRange;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function DiscussionSubContent_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.discussionSubContent_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.discussionSubContent_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = DiscussionSubContent_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.discussionSubContent_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.discussionSubContent_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.DiscussionSubContent_GetObjLstByPagerAsync = DiscussionSubContent_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param strSubContentId:关键字
    * @returns 获取删除的结果
    **/
    async function DiscussionSubContent_DelRecordAsync(strSubContentId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.discussionSubContent_Controller, strAction);
        strUrl = (0, clsString_js_2.Format)("{0}/?Id={1}", strUrl, strSubContentId);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.discussionSubContent_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.discussionSubContent_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.DiscussionSubContent_DelRecordAsync = DiscussionSubContent_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrSubContentId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function DiscussionSubContent_DelDiscussionSubContentsAsync(arrSubContentId) {
        const strThisFuncName = "DelDiscussionSubContentsAsync";
        const strAction = "DelDiscussionSubContents";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.discussionSubContent_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrSubContentId);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.discussionSubContent_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.discussionSubContent_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.DiscussionSubContent_DelDiscussionSubContentsAsync = DiscussionSubContent_DelDiscussionSubContentsAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function DiscussionSubContent_DelDiscussionSubContentsByCondAsync(strWhereCond) {
        const strThisFuncName = "DelDiscussionSubContentsByCondAsync";
        const strAction = "DelDiscussionSubContentsByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.discussionSubContent_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.discussionSubContent_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.discussionSubContent_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.DiscussionSubContent_DelDiscussionSubContentsByCondAsync = DiscussionSubContent_DelDiscussionSubContentsByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objDiscussionSubContentEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function DiscussionSubContent_AddNewRecordAsync(objDiscussionSubContentEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objDiscussionSubContentEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.discussionSubContent_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objDiscussionSubContentEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.discussionSubContent_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.discussionSubContent_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.DiscussionSubContent_AddNewRecordAsync = DiscussionSubContent_AddNewRecordAsync;
    /**
    * 调用WebApi来添加记录，关键字用最大关键字，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithMaxIdAsync)
    * @param objDiscussionSubContentEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function DiscussionSubContent_AddNewRecordWithMaxIdAsync(objDiscussionSubContentEN) {
        const strThisFuncName = "AddNewRecordWithMaxIdAsync";
        const strAction = "AddNewRecordWithMaxId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.discussionSubContent_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objDiscussionSubContentEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.discussionSubContent_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.discussionSubContent_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.DiscussionSubContent_AddNewRecordWithMaxIdAsync = DiscussionSubContent_AddNewRecordWithMaxIdAsync;
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objDiscussionSubContentEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function DiscussionSubContent_AddNewRecordWithReturnKeyAsync(objDiscussionSubContentEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.discussionSubContent_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objDiscussionSubContentEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.discussionSubContent_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.discussionSubContent_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.DiscussionSubContent_AddNewRecordWithReturnKeyAsync = DiscussionSubContent_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objDiscussionSubContentEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function DiscussionSubContent_AddNewRecordWithReturnKey(objDiscussionSubContentEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objDiscussionSubContentEN.subContentId === null || objDiscussionSubContentEN.subContentId === "") {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.discussionSubContent_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objDiscussionSubContentEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.discussionSubContent_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.discussionSubContent_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.DiscussionSubContent_AddNewRecordWithReturnKey = DiscussionSubContent_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objDiscussionSubContentEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function DiscussionSubContent_UpdateRecordAsync(objDiscussionSubContentEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objDiscussionSubContentEN.sf_UpdFldSetStr === undefined || objDiscussionSubContentEN.sf_UpdFldSetStr === null || objDiscussionSubContentEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objDiscussionSubContentEN.subContentId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.discussionSubContent_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objDiscussionSubContentEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.discussionSubContent_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.discussionSubContent_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.DiscussionSubContent_UpdateRecordAsync = DiscussionSubContent_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objDiscussionSubContentEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function DiscussionSubContent_UpdateWithConditionAsync(objDiscussionSubContentEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objDiscussionSubContentEN.sf_UpdFldSetStr === undefined || objDiscussionSubContentEN.sf_UpdFldSetStr === null || objDiscussionSubContentEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objDiscussionSubContentEN.subContentId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.discussionSubContent_Controller, strAction);
        objDiscussionSubContentEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objDiscussionSubContentEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.discussionSubContent_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.discussionSubContent_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.DiscussionSubContent_UpdateWithConditionAsync = DiscussionSubContent_UpdateWithConditionAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function DiscussionSubContent_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.discussionSubContent_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.discussionSubContent_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.discussionSubContent_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.DiscussionSubContent_IsExistRecordAsync = DiscussionSubContent_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strSubContentId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function DiscussionSubContent_IsExist(strSubContentId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.discussionSubContent_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "SubContentId": strSubContentId,
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.discussionSubContent_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.discussionSubContent_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.DiscussionSubContent_IsExist = DiscussionSubContent_IsExist;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strSubContentId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function DiscussionSubContent_IsExistAsync(strSubContentId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.discussionSubContent_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strSubContentId": strSubContentId }
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.discussionSubContent_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.discussionSubContent_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.DiscussionSubContent_IsExistAsync = DiscussionSubContent_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function DiscussionSubContent_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.discussionSubContent_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.discussionSubContent_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.discussionSubContent_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.DiscussionSubContent_GetRecCountByCondAsync = DiscussionSubContent_GetRecCountByCondAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 获取表的最大关键字
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdAsync)
    * @returns 获取表的最大关键字
    **/
    async function DiscussionSubContent_GetMaxStrIdAsync() {
        const strThisFuncName = "GetMaxStrIdAsync";
        const strAction = "GetMaxStrId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.discussionSubContent_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.discussionSubContent_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.discussionSubContent_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.DiscussionSubContent_GetMaxStrIdAsync = DiscussionSubContent_GetMaxStrIdAsync;
    /*该表的关键字类型不是字符型带前缀自增，不需要生成获取最大关键字函数！*/
    /**
     * 根据前缀获取当前表关键字值的最大值,再加1,避免重复
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdByPrefix)
     * @param mapParam:参数列表
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 获取当前表关键字值的最大值
    */
    async function DiscussionSubContent_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.discussionSubContent_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.discussionSubContent_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.discussionSubContent_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.DiscussionSubContent_GetMaxStrIdByPrefix = DiscussionSubContent_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function DiscussionSubContent_GetWebApiUrl(strController, strAction) {
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
    exports.DiscussionSubContent_GetWebApiUrl = DiscussionSubContent_GetWebApiUrl;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function DiscussionSubContent_CheckPropertyNew(pobjDiscussionSubContentEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjDiscussionSubContentEN.subContentId) == false && (0, clsString_js_2.GetStrLen)(pobjDiscussionSubContentEN.subContentId) > 10) {
            throw new Error("(errid:Watl000059)字段[子内容Id(subContentId)]的长度不能超过10(In 讨论子内容(DiscussionSubContent))!值:$(pobjDiscussionSubContentEN.subContentId)(clsDiscussionSubContentBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjDiscussionSubContentEN.topicsId) == false && (0, clsString_js_2.GetStrLen)(pobjDiscussionSubContentEN.topicsId) > 8) {
            throw new Error("(errid:Watl000059)字段[主题Id(topicsId)]的长度不能超过8(In 讨论子内容(DiscussionSubContent))!值:$(pobjDiscussionSubContentEN.topicsId)(clsDiscussionSubContentBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjDiscussionSubContentEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjDiscussionSubContentEN.updDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 讨论子内容(DiscussionSubContent))!值:$(pobjDiscussionSubContentEN.updDate)(clsDiscussionSubContentBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjDiscussionSubContentEN.updUser) == false && (0, clsString_js_2.GetStrLen)(pobjDiscussionSubContentEN.updUser) > 20) {
            throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 讨论子内容(DiscussionSubContent))!值:$(pobjDiscussionSubContentEN.updUser)(clsDiscussionSubContentBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjDiscussionSubContentEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjDiscussionSubContentEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 讨论子内容(DiscussionSubContent))!值:$(pobjDiscussionSubContentEN.memo)(clsDiscussionSubContentBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjDiscussionSubContentEN.parentId) == false && (0, clsString_js_2.GetStrLen)(pobjDiscussionSubContentEN.parentId) > 10) {
            throw new Error("(errid:Watl000059)字段[父节点Id(parentId)]的长度不能超过10(In 讨论子内容(DiscussionSubContent))!值:$(pobjDiscussionSubContentEN.parentId)(clsDiscussionSubContentBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjDiscussionSubContentEN.userId) == false && (0, clsString_js_2.GetStrLen)(pobjDiscussionSubContentEN.userId) > 18) {
            throw new Error("(errid:Watl000059)字段[用户ID(userId)]的长度不能超过18(In 讨论子内容(DiscussionSubContent))!值:$(pobjDiscussionSubContentEN.userId)(clsDiscussionSubContentBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjDiscussionSubContentEN.subContentId) == false && undefined !== pobjDiscussionSubContentEN.subContentId && clsString_js_1.tzDataType.isString(pobjDiscussionSubContentEN.subContentId) === false) {
            throw new Error("(errid:Watl000060)字段[子内容Id(subContentId)]的值:[$(pobjDiscussionSubContentEN.subContentId)], 非法，应该为字符型(In 讨论子内容(DiscussionSubContent))!(clsDiscussionSubContentBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjDiscussionSubContentEN.subContent) == false && undefined !== pobjDiscussionSubContentEN.subContent && clsString_js_1.tzDataType.isString(pobjDiscussionSubContentEN.subContent) === false) {
            throw new Error("(errid:Watl000060)字段[子内容(subContent)]的值:[$(pobjDiscussionSubContentEN.subContent)], 非法，应该为字符型(In 讨论子内容(DiscussionSubContent))!(clsDiscussionSubContentBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjDiscussionSubContentEN.topicsId) == false && undefined !== pobjDiscussionSubContentEN.topicsId && clsString_js_1.tzDataType.isString(pobjDiscussionSubContentEN.topicsId) === false) {
            throw new Error("(errid:Watl000060)字段[主题Id(topicsId)]的值:[$(pobjDiscussionSubContentEN.topicsId)], 非法，应该为字符型(In 讨论子内容(DiscussionSubContent))!(clsDiscussionSubContentBL:CheckPropertyNew)");
        }
        if (null != pobjDiscussionSubContentEN.isTop && undefined !== pobjDiscussionSubContentEN.isTop && clsString_js_1.tzDataType.isBoolean(pobjDiscussionSubContentEN.isTop) === false) {
            throw new Error("(errid:Watl000060)字段[是否置顶(isTop)]的值:[$(pobjDiscussionSubContentEN.isTop)], 非法，应该为布尔型(In 讨论子内容(DiscussionSubContent))!(clsDiscussionSubContentBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjDiscussionSubContentEN.updDate) == false && undefined !== pobjDiscussionSubContentEN.updDate && clsString_js_1.tzDataType.isString(pobjDiscussionSubContentEN.updDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjDiscussionSubContentEN.updDate)], 非法，应该为字符型(In 讨论子内容(DiscussionSubContent))!(clsDiscussionSubContentBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjDiscussionSubContentEN.updUser) == false && undefined !== pobjDiscussionSubContentEN.updUser && clsString_js_1.tzDataType.isString(pobjDiscussionSubContentEN.updUser) === false) {
            throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjDiscussionSubContentEN.updUser)], 非法，应该为字符型(In 讨论子内容(DiscussionSubContent))!(clsDiscussionSubContentBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjDiscussionSubContentEN.memo) == false && undefined !== pobjDiscussionSubContentEN.memo && clsString_js_1.tzDataType.isString(pobjDiscussionSubContentEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjDiscussionSubContentEN.memo)], 非法，应该为字符型(In 讨论子内容(DiscussionSubContent))!(clsDiscussionSubContentBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjDiscussionSubContentEN.parentId) == false && undefined !== pobjDiscussionSubContentEN.parentId && clsString_js_1.tzDataType.isString(pobjDiscussionSubContentEN.parentId) === false) {
            throw new Error("(errid:Watl000060)字段[父节点Id(parentId)]的值:[$(pobjDiscussionSubContentEN.parentId)], 非法，应该为字符型(In 讨论子内容(DiscussionSubContent))!(clsDiscussionSubContentBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjDiscussionSubContentEN.userId) == false && undefined !== pobjDiscussionSubContentEN.userId && clsString_js_1.tzDataType.isString(pobjDiscussionSubContentEN.userId) === false) {
            throw new Error("(errid:Watl000060)字段[用户ID(userId)]的值:[$(pobjDiscussionSubContentEN.userId)], 非法，应该为字符型(In 讨论子内容(DiscussionSubContent))!(clsDiscussionSubContentBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjDiscussionSubContentEN.topicsId) == false && (0, clsString_js_2.GetStrLen)(pobjDiscussionSubContentEN.topicsId) != 8) {
            throw ("(errid:Watl000061)字段[主题Id]作为外键字段,长度应该为8(In 讨论子内容)!(clsDiscussionSubContentBL:CheckPropertyNew)");
        }
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjDiscussionSubContentEN.SetIsCheckProperty(true);
    }
    exports.DiscussionSubContent_CheckPropertyNew = DiscussionSubContent_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function DiscussionSubContent_CheckProperty4Update(pobjDiscussionSubContentEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjDiscussionSubContentEN.subContentId) == false && (0, clsString_js_2.GetStrLen)(pobjDiscussionSubContentEN.subContentId) > 10) {
            throw new Error("(errid:Watl000062)字段[子内容Id(subContentId)]的长度不能超过10(In 讨论子内容(DiscussionSubContent))!值:$(pobjDiscussionSubContentEN.subContentId)(clsDiscussionSubContentBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjDiscussionSubContentEN.topicsId) == false && (0, clsString_js_2.GetStrLen)(pobjDiscussionSubContentEN.topicsId) > 8) {
            throw new Error("(errid:Watl000062)字段[主题Id(topicsId)]的长度不能超过8(In 讨论子内容(DiscussionSubContent))!值:$(pobjDiscussionSubContentEN.topicsId)(clsDiscussionSubContentBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjDiscussionSubContentEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjDiscussionSubContentEN.updDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 讨论子内容(DiscussionSubContent))!值:$(pobjDiscussionSubContentEN.updDate)(clsDiscussionSubContentBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjDiscussionSubContentEN.updUser) == false && (0, clsString_js_2.GetStrLen)(pobjDiscussionSubContentEN.updUser) > 20) {
            throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 讨论子内容(DiscussionSubContent))!值:$(pobjDiscussionSubContentEN.updUser)(clsDiscussionSubContentBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjDiscussionSubContentEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjDiscussionSubContentEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 讨论子内容(DiscussionSubContent))!值:$(pobjDiscussionSubContentEN.memo)(clsDiscussionSubContentBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjDiscussionSubContentEN.parentId) == false && (0, clsString_js_2.GetStrLen)(pobjDiscussionSubContentEN.parentId) > 10) {
            throw new Error("(errid:Watl000062)字段[父节点Id(parentId)]的长度不能超过10(In 讨论子内容(DiscussionSubContent))!值:$(pobjDiscussionSubContentEN.parentId)(clsDiscussionSubContentBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjDiscussionSubContentEN.userId) == false && (0, clsString_js_2.GetStrLen)(pobjDiscussionSubContentEN.userId) > 18) {
            throw new Error("(errid:Watl000062)字段[用户ID(userId)]的长度不能超过18(In 讨论子内容(DiscussionSubContent))!值:$(pobjDiscussionSubContentEN.userId)(clsDiscussionSubContentBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjDiscussionSubContentEN.subContentId) == false && undefined !== pobjDiscussionSubContentEN.subContentId && clsString_js_1.tzDataType.isString(pobjDiscussionSubContentEN.subContentId) === false) {
            throw new Error("(errid:Watl000063)字段[子内容Id(subContentId)]的值:[$(pobjDiscussionSubContentEN.subContentId)], 非法，应该为字符型(In 讨论子内容(DiscussionSubContent))!(clsDiscussionSubContentBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjDiscussionSubContentEN.subContent) == false && undefined !== pobjDiscussionSubContentEN.subContent && clsString_js_1.tzDataType.isString(pobjDiscussionSubContentEN.subContent) === false) {
            throw new Error("(errid:Watl000063)字段[子内容(subContent)]的值:[$(pobjDiscussionSubContentEN.subContent)], 非法，应该为字符型(In 讨论子内容(DiscussionSubContent))!(clsDiscussionSubContentBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjDiscussionSubContentEN.topicsId) == false && undefined !== pobjDiscussionSubContentEN.topicsId && clsString_js_1.tzDataType.isString(pobjDiscussionSubContentEN.topicsId) === false) {
            throw new Error("(errid:Watl000063)字段[主题Id(topicsId)]的值:[$(pobjDiscussionSubContentEN.topicsId)], 非法，应该为字符型(In 讨论子内容(DiscussionSubContent))!(clsDiscussionSubContentBL:CheckProperty4Update)");
        }
        if (null != pobjDiscussionSubContentEN.isTop && undefined !== pobjDiscussionSubContentEN.isTop && clsString_js_1.tzDataType.isBoolean(pobjDiscussionSubContentEN.isTop) === false) {
            throw new Error("(errid:Watl000063)字段[是否置顶(isTop)]的值:[$(pobjDiscussionSubContentEN.isTop)], 非法，应该为布尔型(In 讨论子内容(DiscussionSubContent))!(clsDiscussionSubContentBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjDiscussionSubContentEN.updDate) == false && undefined !== pobjDiscussionSubContentEN.updDate && clsString_js_1.tzDataType.isString(pobjDiscussionSubContentEN.updDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjDiscussionSubContentEN.updDate)], 非法，应该为字符型(In 讨论子内容(DiscussionSubContent))!(clsDiscussionSubContentBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjDiscussionSubContentEN.updUser) == false && undefined !== pobjDiscussionSubContentEN.updUser && clsString_js_1.tzDataType.isString(pobjDiscussionSubContentEN.updUser) === false) {
            throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjDiscussionSubContentEN.updUser)], 非法，应该为字符型(In 讨论子内容(DiscussionSubContent))!(clsDiscussionSubContentBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjDiscussionSubContentEN.memo) == false && undefined !== pobjDiscussionSubContentEN.memo && clsString_js_1.tzDataType.isString(pobjDiscussionSubContentEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjDiscussionSubContentEN.memo)], 非法，应该为字符型(In 讨论子内容(DiscussionSubContent))!(clsDiscussionSubContentBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjDiscussionSubContentEN.parentId) == false && undefined !== pobjDiscussionSubContentEN.parentId && clsString_js_1.tzDataType.isString(pobjDiscussionSubContentEN.parentId) === false) {
            throw new Error("(errid:Watl000063)字段[父节点Id(parentId)]的值:[$(pobjDiscussionSubContentEN.parentId)], 非法，应该为字符型(In 讨论子内容(DiscussionSubContent))!(clsDiscussionSubContentBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjDiscussionSubContentEN.userId) == false && undefined !== pobjDiscussionSubContentEN.userId && clsString_js_1.tzDataType.isString(pobjDiscussionSubContentEN.userId) === false) {
            throw new Error("(errid:Watl000063)字段[用户ID(userId)]的值:[$(pobjDiscussionSubContentEN.userId)], 非法，应该为字符型(In 讨论子内容(DiscussionSubContent))!(clsDiscussionSubContentBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjDiscussionSubContentEN.subContentId) === true) {
            throw new Error("(errid:Watl000064)字段[子内容Id]不能为空(In 讨论子内容)!(clsDiscussionSubContentBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjDiscussionSubContentEN.topicsId) == false && (0, clsString_js_2.GetStrLen)(pobjDiscussionSubContentEN.topicsId) != 8) {
            throw ("(errid:Watl000065)字段[主题Id]作为外键字段,长度应该为8(In 讨论子内容)!(clsDiscussionSubContentBL:CheckPropertyNew)");
        }
        pobjDiscussionSubContentEN.SetIsCheckProperty(true);
    }
    exports.DiscussionSubContent_CheckProperty4Update = DiscussionSubContent_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function DiscussionSubContent_GetJSONStrByObj(pobjDiscussionSubContentEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjDiscussionSubContentEN.sf_UpdFldSetStr = pobjDiscussionSubContentEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjDiscussionSubContentEN);
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
    exports.DiscussionSubContent_GetJSONStrByObj = DiscussionSubContent_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function DiscussionSubContent_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrDiscussionSubContentObjLst = new Array();
        if (strJSON === "") {
            return arrDiscussionSubContentObjLst;
        }
        try {
            arrDiscussionSubContentObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrDiscussionSubContentObjLst;
        }
        return arrDiscussionSubContentObjLst;
    }
    exports.DiscussionSubContent_GetObjLstByJSONStr = DiscussionSubContent_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrDiscussionSubContentObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function DiscussionSubContent_GetObjLstByJSONObjLst(arrDiscussionSubContentObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrDiscussionSubContentObjLst = new Array();
        for (const objInFor of arrDiscussionSubContentObjLstS) {
            const obj1 = DiscussionSubContent_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrDiscussionSubContentObjLst.push(obj1);
        }
        return arrDiscussionSubContentObjLst;
    }
    exports.DiscussionSubContent_GetObjLstByJSONObjLst = DiscussionSubContent_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function DiscussionSubContent_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjDiscussionSubContentEN = new clsDiscussionSubContentEN_js_1.clsDiscussionSubContentEN();
        if (strJSON === "") {
            return pobjDiscussionSubContentEN;
        }
        try {
            pobjDiscussionSubContentEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjDiscussionSubContentEN;
        }
        return pobjDiscussionSubContentEN;
    }
    exports.DiscussionSubContent_GetObjByJSONStr = DiscussionSubContent_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function DiscussionSubContent_GetCombineCondition(objDiscussionSubContent_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objDiscussionSubContent_Cond.dicFldComparisonOp, clsDiscussionSubContentEN_js_1.clsDiscussionSubContentEN.con_SubContentId) == true) {
            const strComparisonOp_SubContentId = objDiscussionSubContent_Cond.dicFldComparisonOp[clsDiscussionSubContentEN_js_1.clsDiscussionSubContentEN.con_SubContentId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsDiscussionSubContentEN_js_1.clsDiscussionSubContentEN.con_SubContentId, objDiscussionSubContent_Cond.subContentId, strComparisonOp_SubContentId);
        }
        //数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
        if (Object.prototype.hasOwnProperty.call(objDiscussionSubContent_Cond.dicFldComparisonOp, clsDiscussionSubContentEN_js_1.clsDiscussionSubContentEN.con_TopicsId) == true) {
            const strComparisonOp_TopicsId = objDiscussionSubContent_Cond.dicFldComparisonOp[clsDiscussionSubContentEN_js_1.clsDiscussionSubContentEN.con_TopicsId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsDiscussionSubContentEN_js_1.clsDiscussionSubContentEN.con_TopicsId, objDiscussionSubContent_Cond.topicsId, strComparisonOp_TopicsId);
        }
        if (Object.prototype.hasOwnProperty.call(objDiscussionSubContent_Cond.dicFldComparisonOp, clsDiscussionSubContentEN_js_1.clsDiscussionSubContentEN.con_IsTop) == true) {
            if (objDiscussionSubContent_Cond.isTop == true) {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '1'", clsDiscussionSubContentEN_js_1.clsDiscussionSubContentEN.con_IsTop);
            }
            else {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '0'", clsDiscussionSubContentEN_js_1.clsDiscussionSubContentEN.con_IsTop);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objDiscussionSubContent_Cond.dicFldComparisonOp, clsDiscussionSubContentEN_js_1.clsDiscussionSubContentEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objDiscussionSubContent_Cond.dicFldComparisonOp[clsDiscussionSubContentEN_js_1.clsDiscussionSubContentEN.con_UpdDate];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsDiscussionSubContentEN_js_1.clsDiscussionSubContentEN.con_UpdDate, objDiscussionSubContent_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objDiscussionSubContent_Cond.dicFldComparisonOp, clsDiscussionSubContentEN_js_1.clsDiscussionSubContentEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objDiscussionSubContent_Cond.dicFldComparisonOp[clsDiscussionSubContentEN_js_1.clsDiscussionSubContentEN.con_UpdUser];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsDiscussionSubContentEN_js_1.clsDiscussionSubContentEN.con_UpdUser, objDiscussionSubContent_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objDiscussionSubContent_Cond.dicFldComparisonOp, clsDiscussionSubContentEN_js_1.clsDiscussionSubContentEN.con_Memo) == true) {
            const strComparisonOp_Memo = objDiscussionSubContent_Cond.dicFldComparisonOp[clsDiscussionSubContentEN_js_1.clsDiscussionSubContentEN.con_Memo];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsDiscussionSubContentEN_js_1.clsDiscussionSubContentEN.con_Memo, objDiscussionSubContent_Cond.memo, strComparisonOp_Memo);
        }
        if (Object.prototype.hasOwnProperty.call(objDiscussionSubContent_Cond.dicFldComparisonOp, clsDiscussionSubContentEN_js_1.clsDiscussionSubContentEN.con_ParentId) == true) {
            const strComparisonOp_ParentId = objDiscussionSubContent_Cond.dicFldComparisonOp[clsDiscussionSubContentEN_js_1.clsDiscussionSubContentEN.con_ParentId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsDiscussionSubContentEN_js_1.clsDiscussionSubContentEN.con_ParentId, objDiscussionSubContent_Cond.parentId, strComparisonOp_ParentId);
        }
        if (Object.prototype.hasOwnProperty.call(objDiscussionSubContent_Cond.dicFldComparisonOp, clsDiscussionSubContentEN_js_1.clsDiscussionSubContentEN.con_UserId) == true) {
            const strComparisonOp_UserId = objDiscussionSubContent_Cond.dicFldComparisonOp[clsDiscussionSubContentEN_js_1.clsDiscussionSubContentEN.con_UserId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsDiscussionSubContentEN_js_1.clsDiscussionSubContentEN.con_UserId, objDiscussionSubContent_Cond.userId, strComparisonOp_UserId);
        }
        return strWhereCond;
    }
    exports.DiscussionSubContent_GetCombineCondition = DiscussionSubContent_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--DiscussionSubContent(讨论子内容),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @returns 条件串(strWhereCond)
    **/
    function DiscussionSubContent_GetUniCondStr_SubContentId(objDiscussionSubContentEN) {
        let strWhereCond = " 1 = 1 ";
        return strWhereCond;
    }
    exports.DiscussionSubContent_GetUniCondStr_SubContentId = DiscussionSubContent_GetUniCondStr_SubContentId;
    /**
    *获取唯一性条件串(Uniqueness)--DiscussionSubContent(讨论子内容),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @returns 条件串(strWhereCond)
    **/
    function DiscussionSubContent_GetUniCondStr4Update_SubContentId(objDiscussionSubContentEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and SubContentId <> '{0}'", objDiscussionSubContentEN.subContentId);
        return strWhereCond;
    }
    exports.DiscussionSubContent_GetUniCondStr4Update_SubContentId = DiscussionSubContent_GetUniCondStr4Update_SubContentId;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objDiscussionSubContentENS:源对象
     * @param objDiscussionSubContentENT:目标对象
    */
    function DiscussionSubContent_CopyObjTo(objDiscussionSubContentENS, objDiscussionSubContentENT) {
        objDiscussionSubContentENT.subContentId = objDiscussionSubContentENS.subContentId; //子内容Id
        objDiscussionSubContentENT.subContent = objDiscussionSubContentENS.subContent; //子内容
        objDiscussionSubContentENT.topicsId = objDiscussionSubContentENS.topicsId; //主题Id
        objDiscussionSubContentENT.isTop = objDiscussionSubContentENS.isTop; //是否置顶
        objDiscussionSubContentENT.updDate = objDiscussionSubContentENS.updDate; //修改日期
        objDiscussionSubContentENT.updUser = objDiscussionSubContentENS.updUser; //修改人
        objDiscussionSubContentENT.memo = objDiscussionSubContentENS.memo; //备注
        objDiscussionSubContentENT.parentId = objDiscussionSubContentENS.parentId; //父节点Id
        objDiscussionSubContentENT.userId = objDiscussionSubContentENS.userId; //用户ID
        objDiscussionSubContentENT.sf_UpdFldSetStr = objDiscussionSubContentENS.updFldString; //sf_UpdFldSetStr
    }
    exports.DiscussionSubContent_CopyObjTo = DiscussionSubContent_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objDiscussionSubContentENS:源对象
     * @param objDiscussionSubContentENT:目标对象
    */
    function DiscussionSubContent_GetObjFromJsonObj(objDiscussionSubContentENS) {
        const objDiscussionSubContentENT = new clsDiscussionSubContentEN_js_1.clsDiscussionSubContentEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objDiscussionSubContentENT, objDiscussionSubContentENS);
        return objDiscussionSubContentENT;
    }
    exports.DiscussionSubContent_GetObjFromJsonObj = DiscussionSubContent_GetObjFromJsonObj;
});
