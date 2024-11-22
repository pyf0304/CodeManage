/**
* 类名:clsgs_ResearchResultAttachmentWApi
* 表名:gs_ResearchResultAttachment(01120779)
* 生成代码版本:2022.11.02.1
* 生成日期:2022/11/02 11:47:06
* 生成者:pyf
* 生成服务器IP:
工程名称:问卷调查(0112)
CM工程:研究生论文学习(变量首字母小写)-全部函数集
* 相关数据库:103.116.76.183,9433EduHigh_Jsie
* PrjDataBaseId:0170
模块中文名:研培主题(GraduateEduTopic)
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
        define(["require", "exports", "axios", "../../L0_Entity/GraduateEduTopic/clsgs_ResearchResultAttachmentEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsSysPara4WebApi.js", "../../PubFun/jsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.gs_ResearchResultAttachment_GetObjFromJsonObj = exports.gs_ResearchResultAttachment_CopyObjTo = exports.gs_ResearchResultAttachment_GetUniCondStr4Update_mId = exports.gs_ResearchResultAttachment_GetUniCondStr_mId = exports.gs_ResearchResultAttachment_GetCombineCondition = exports.gs_ResearchResultAttachment_GetObjByJSONStr = exports.gs_ResearchResultAttachment_GetObjLstByJSONObjLst = exports.gs_ResearchResultAttachment_GetObjLstByJSONStr = exports.gs_ResearchResultAttachment_GetJSONStrByObj = exports.gs_ResearchResultAttachment_CheckProperty4Update = exports.gs_ResearchResultAttachment_CheckPropertyNew = exports.gs_ResearchResultAttachment_GetWebApiUrl = exports.gs_ResearchResultAttachment_GetMaxStrIdByPrefix = exports.gs_ResearchResultAttachment_GetRecCountByCondAsync = exports.gs_ResearchResultAttachment_IsExistAsync = exports.gs_ResearchResultAttachment_IsExist = exports.gs_ResearchResultAttachment_IsExistRecordAsync = exports.gs_ResearchResultAttachment_UpdateWithConditionAsync = exports.gs_ResearchResultAttachment_UpdateRecordAsync = exports.gs_ResearchResultAttachment_AddNewRecordWithReturnKey = exports.gs_ResearchResultAttachment_AddNewRecordWithReturnKeyAsync = exports.gs_ResearchResultAttachment_AddNewRecordAsync = exports.gs_ResearchResultAttachment_Delgs_ResearchResultAttachmentsByCondAsync = exports.gs_ResearchResultAttachment_Delgs_ResearchResultAttachmentsAsync = exports.gs_ResearchResultAttachment_DelRecordAsync = exports.gs_ResearchResultAttachment_GetObjLstByPagerAsync = exports.gs_ResearchResultAttachment_GetObjLstByRange = exports.gs_ResearchResultAttachment_GetObjLstByRangeAsync = exports.gs_ResearchResultAttachment_GetTopObjLstAsync = exports.gs_ResearchResultAttachment_GetObjLstBymIdLstAsync = exports.gs_ResearchResultAttachment_GetObjLstAsync = exports.gs_ResearchResultAttachment_GetFirstObjAsync = exports.gs_ResearchResultAttachment_GetFirstID = exports.gs_ResearchResultAttachment_GetFirstIDAsync = exports.gs_ResearchResultAttachment_FilterFunByKey = exports.gs_ResearchResultAttachment_SortFunByKey = exports.gs_ResearchResultAttachment_SortFun_Defa_2Fld = exports.gs_ResearchResultAttachment_SortFun_Defa = exports.gs_ResearchResultAttachment_GetObjBymIdAsync = exports.gs_ResearchResultAttachment_ConstructorName = exports.gs_ResearchResultAttachment_Controller = void 0;
    /**
     * 研究成果附件表(gs_ResearchResultAttachment)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2022年11月02日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const clsgs_ResearchResultAttachmentEN_js_1 = require("../../L0_Entity/GraduateEduTopic/clsgs_ResearchResultAttachmentEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    const jsString_js_1 = require("../../PubFun/jsString.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.gs_ResearchResultAttachment_Controller = "gs_ResearchResultAttachmentApi";
    exports.gs_ResearchResultAttachment_ConstructorName = "gs_ResearchResultAttachment";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param lngmId:关键字
    * @returns 对象
    **/
    async function gs_ResearchResultAttachment_GetObjBymIdAsync(lngmId) {
        const strThisFuncName = "GetObjBymIdAsync";
        if (lngmId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngmId]不能为空！(In GetObjBymIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjBymId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ResearchResultAttachment_Controller, strAction);
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
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_ResearchResultAttachment_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objgs_ResearchResultAttachment = gs_ResearchResultAttachment_GetObjFromJsonObj(returnObj);
                return objgs_ResearchResultAttachment;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ResearchResultAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ResearchResultAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ResearchResultAttachment_GetObjBymIdAsync = gs_ResearchResultAttachment_GetObjBymIdAsync;
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
    function gs_ResearchResultAttachment_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.mId - b.mId;
    }
    exports.gs_ResearchResultAttachment_SortFun_Defa = gs_ResearchResultAttachment_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function gs_ResearchResultAttachment_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.resultId == b.resultId)
            return a.topicId.localeCompare(b.topicId);
        else
            return a.resultId.localeCompare(b.resultId);
    }
    exports.gs_ResearchResultAttachment_SortFun_Defa_2Fld = gs_ResearchResultAttachment_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function gs_ResearchResultAttachment_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsgs_ResearchResultAttachmentEN_js_1.clsgs_ResearchResultAttachmentEN.con_mId:
                    return (a, b) => {
                        return a.mId - b.mId;
                    };
                case clsgs_ResearchResultAttachmentEN_js_1.clsgs_ResearchResultAttachmentEN.con_ResultId:
                    return (a, b) => {
                        return a.resultId.localeCompare(b.resultId);
                    };
                case clsgs_ResearchResultAttachmentEN_js_1.clsgs_ResearchResultAttachmentEN.con_TopicId:
                    return (a, b) => {
                        return a.topicId.localeCompare(b.topicId);
                    };
                case clsgs_ResearchResultAttachmentEN_js_1.clsgs_ResearchResultAttachmentEN.con_FileName:
                    return (a, b) => {
                        return a.fileName.localeCompare(b.fileName);
                    };
                case clsgs_ResearchResultAttachmentEN_js_1.clsgs_ResearchResultAttachmentEN.con_FilePath:
                    return (a, b) => {
                        return a.filePath.localeCompare(b.filePath);
                    };
                case clsgs_ResearchResultAttachmentEN_js_1.clsgs_ResearchResultAttachmentEN.con_UpdDate:
                    return (a, b) => {
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsgs_ResearchResultAttachmentEN_js_1.clsgs_ResearchResultAttachmentEN.con_UpdUser:
                    return (a, b) => {
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsgs_ResearchResultAttachmentEN_js_1.clsgs_ResearchResultAttachmentEN.con_Memo:
                    return (a, b) => {
                        return a.memo.localeCompare(b.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[gs_ResearchResultAttachment]中不存在！(in ${exports.gs_ResearchResultAttachment_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsgs_ResearchResultAttachmentEN_js_1.clsgs_ResearchResultAttachmentEN.con_mId:
                    return (a, b) => {
                        return b.mId - a.mId;
                    };
                case clsgs_ResearchResultAttachmentEN_js_1.clsgs_ResearchResultAttachmentEN.con_ResultId:
                    return (a, b) => {
                        return b.resultId.localeCompare(a.resultId);
                    };
                case clsgs_ResearchResultAttachmentEN_js_1.clsgs_ResearchResultAttachmentEN.con_TopicId:
                    return (a, b) => {
                        return b.topicId.localeCompare(a.topicId);
                    };
                case clsgs_ResearchResultAttachmentEN_js_1.clsgs_ResearchResultAttachmentEN.con_FileName:
                    return (a, b) => {
                        return b.fileName.localeCompare(a.fileName);
                    };
                case clsgs_ResearchResultAttachmentEN_js_1.clsgs_ResearchResultAttachmentEN.con_FilePath:
                    return (a, b) => {
                        return b.filePath.localeCompare(a.filePath);
                    };
                case clsgs_ResearchResultAttachmentEN_js_1.clsgs_ResearchResultAttachmentEN.con_UpdDate:
                    return (a, b) => {
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsgs_ResearchResultAttachmentEN_js_1.clsgs_ResearchResultAttachmentEN.con_UpdUser:
                    return (a, b) => {
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsgs_ResearchResultAttachmentEN_js_1.clsgs_ResearchResultAttachmentEN.con_Memo:
                    return (a, b) => {
                        return b.memo.localeCompare(a.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[gs_ResearchResultAttachment]中不存在！(in ${exports.gs_ResearchResultAttachment_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.gs_ResearchResultAttachment_SortFunByKey = gs_ResearchResultAttachment_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function gs_ResearchResultAttachment_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsgs_ResearchResultAttachmentEN_js_1.clsgs_ResearchResultAttachmentEN.con_mId:
                return (obj) => {
                    return obj.mId === value;
                };
            case clsgs_ResearchResultAttachmentEN_js_1.clsgs_ResearchResultAttachmentEN.con_ResultId:
                return (obj) => {
                    return obj.resultId === value;
                };
            case clsgs_ResearchResultAttachmentEN_js_1.clsgs_ResearchResultAttachmentEN.con_TopicId:
                return (obj) => {
                    return obj.topicId === value;
                };
            case clsgs_ResearchResultAttachmentEN_js_1.clsgs_ResearchResultAttachmentEN.con_FileName:
                return (obj) => {
                    return obj.fileName === value;
                };
            case clsgs_ResearchResultAttachmentEN_js_1.clsgs_ResearchResultAttachmentEN.con_FilePath:
                return (obj) => {
                    return obj.filePath === value;
                };
            case clsgs_ResearchResultAttachmentEN_js_1.clsgs_ResearchResultAttachmentEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsgs_ResearchResultAttachmentEN_js_1.clsgs_ResearchResultAttachmentEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsgs_ResearchResultAttachmentEN_js_1.clsgs_ResearchResultAttachmentEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[gs_ResearchResultAttachment]中不存在！(in ${exports.gs_ResearchResultAttachment_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.gs_ResearchResultAttachment_FilterFunByKey = gs_ResearchResultAttachment_FilterFunByKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function gs_ResearchResultAttachment_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ResearchResultAttachment_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ResearchResultAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ResearchResultAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ResearchResultAttachment_GetFirstIDAsync = gs_ResearchResultAttachment_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function gs_ResearchResultAttachment_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ResearchResultAttachment_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ResearchResultAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ResearchResultAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ResearchResultAttachment_GetFirstID = gs_ResearchResultAttachment_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function gs_ResearchResultAttachment_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ResearchResultAttachment_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_ResearchResultAttachment_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objgs_ResearchResultAttachment = gs_ResearchResultAttachment_GetObjFromJsonObj(returnObj);
                return objgs_ResearchResultAttachment;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ResearchResultAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ResearchResultAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ResearchResultAttachment_GetFirstObjAsync = gs_ResearchResultAttachment_GetFirstObjAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function gs_ResearchResultAttachment_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ResearchResultAttachment_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_ResearchResultAttachment_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_ResearchResultAttachment_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ResearchResultAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ResearchResultAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ResearchResultAttachment_GetObjLstAsync = gs_ResearchResultAttachment_GetObjLstAsync;
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
    async function gs_ResearchResultAttachment_GetObjLstBymIdLstAsync(arrmId) {
        const strThisFuncName = "GetObjLstBymIdLstAsync";
        const strAction = "GetObjLstBymIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ResearchResultAttachment_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrmId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_ResearchResultAttachment_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_ResearchResultAttachment_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ResearchResultAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ResearchResultAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ResearchResultAttachment_GetObjLstBymIdLstAsync = gs_ResearchResultAttachment_GetObjLstBymIdLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function gs_ResearchResultAttachment_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ResearchResultAttachment_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_ResearchResultAttachment_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_ResearchResultAttachment_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ResearchResultAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ResearchResultAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ResearchResultAttachment_GetTopObjLstAsync = gs_ResearchResultAttachment_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function gs_ResearchResultAttachment_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ResearchResultAttachment_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_ResearchResultAttachment_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_ResearchResultAttachment_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ResearchResultAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ResearchResultAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ResearchResultAttachment_GetObjLstByRangeAsync = gs_ResearchResultAttachment_GetObjLstByRangeAsync;
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
    async function gs_ResearchResultAttachment_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ResearchResultAttachment_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ResearchResultAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ResearchResultAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ResearchResultAttachment_GetObjLstByRange = gs_ResearchResultAttachment_GetObjLstByRange;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function gs_ResearchResultAttachment_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ResearchResultAttachment_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_ResearchResultAttachment_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_ResearchResultAttachment_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ResearchResultAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ResearchResultAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ResearchResultAttachment_GetObjLstByPagerAsync = gs_ResearchResultAttachment_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param lngmId:关键字
    * @returns 获取删除的结果
    **/
    async function gs_ResearchResultAttachment_DelRecordAsync(lngmId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ResearchResultAttachment_Controller, strAction);
        strUrl = (0, clsString_js_1.Format)("{0}/?Id={1}", strUrl, lngmId);
        try {
            const response = await axios_1.default.delete(strUrl, {
                params: { "Id": lngmId, }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ResearchResultAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ResearchResultAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ResearchResultAttachment_DelRecordAsync = gs_ResearchResultAttachment_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrmId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function gs_ResearchResultAttachment_Delgs_ResearchResultAttachmentsAsync(arrmId) {
        const strThisFuncName = "Delgs_ResearchResultAttachmentsAsync";
        const strAction = "Delgs_ResearchResultAttachments";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ResearchResultAttachment_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrmId);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ResearchResultAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ResearchResultAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ResearchResultAttachment_Delgs_ResearchResultAttachmentsAsync = gs_ResearchResultAttachment_Delgs_ResearchResultAttachmentsAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function gs_ResearchResultAttachment_Delgs_ResearchResultAttachmentsByCondAsync(strWhereCond) {
        const strThisFuncName = "Delgs_ResearchResultAttachmentsByCondAsync";
        const strAction = "Delgs_ResearchResultAttachmentsByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ResearchResultAttachment_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ResearchResultAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ResearchResultAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ResearchResultAttachment_Delgs_ResearchResultAttachmentsByCondAsync = gs_ResearchResultAttachment_Delgs_ResearchResultAttachmentsByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objgs_ResearchResultAttachmentEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function gs_ResearchResultAttachment_AddNewRecordAsync(objgs_ResearchResultAttachmentEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objgs_ResearchResultAttachmentEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ResearchResultAttachment_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_ResearchResultAttachmentEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ResearchResultAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ResearchResultAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ResearchResultAttachment_AddNewRecordAsync = gs_ResearchResultAttachment_AddNewRecordAsync;
    /* 数据类型不是字符型，不可以最大关键字的方式添加记录。*/
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objgs_ResearchResultAttachmentEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function gs_ResearchResultAttachment_AddNewRecordWithReturnKeyAsync(objgs_ResearchResultAttachmentEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ResearchResultAttachment_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_ResearchResultAttachmentEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ResearchResultAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ResearchResultAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ResearchResultAttachment_AddNewRecordWithReturnKeyAsync = gs_ResearchResultAttachment_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objgs_ResearchResultAttachmentEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function gs_ResearchResultAttachment_AddNewRecordWithReturnKey(objgs_ResearchResultAttachmentEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objgs_ResearchResultAttachmentEN.mId === null || objgs_ResearchResultAttachmentEN.mId === 0) {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ResearchResultAttachment_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_ResearchResultAttachmentEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ResearchResultAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ResearchResultAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ResearchResultAttachment_AddNewRecordWithReturnKey = gs_ResearchResultAttachment_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objgs_ResearchResultAttachmentEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function gs_ResearchResultAttachment_UpdateRecordAsync(objgs_ResearchResultAttachmentEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objgs_ResearchResultAttachmentEN.sf_UpdFldSetStr === undefined || objgs_ResearchResultAttachmentEN.sf_UpdFldSetStr === null || objgs_ResearchResultAttachmentEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_ResearchResultAttachmentEN.mId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ResearchResultAttachment_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_ResearchResultAttachmentEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ResearchResultAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ResearchResultAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ResearchResultAttachment_UpdateRecordAsync = gs_ResearchResultAttachment_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objgs_ResearchResultAttachmentEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function gs_ResearchResultAttachment_UpdateWithConditionAsync(objgs_ResearchResultAttachmentEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objgs_ResearchResultAttachmentEN.sf_UpdFldSetStr === undefined || objgs_ResearchResultAttachmentEN.sf_UpdFldSetStr === null || objgs_ResearchResultAttachmentEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_ResearchResultAttachmentEN.mId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ResearchResultAttachment_Controller, strAction);
        objgs_ResearchResultAttachmentEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objgs_ResearchResultAttachmentEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ResearchResultAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ResearchResultAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ResearchResultAttachment_UpdateWithConditionAsync = gs_ResearchResultAttachment_UpdateWithConditionAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function gs_ResearchResultAttachment_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ResearchResultAttachment_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ResearchResultAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ResearchResultAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ResearchResultAttachment_IsExistRecordAsync = gs_ResearchResultAttachment_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param lngmId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function gs_ResearchResultAttachment_IsExist(lngmId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ResearchResultAttachment_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ResearchResultAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ResearchResultAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ResearchResultAttachment_IsExist = gs_ResearchResultAttachment_IsExist;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param lngmId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function gs_ResearchResultAttachment_IsExistAsync(lngmId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ResearchResultAttachment_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ResearchResultAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ResearchResultAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ResearchResultAttachment_IsExistAsync = gs_ResearchResultAttachment_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function gs_ResearchResultAttachment_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ResearchResultAttachment_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ResearchResultAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ResearchResultAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ResearchResultAttachment_GetRecCountByCondAsync = gs_ResearchResultAttachment_GetRecCountByCondAsync;
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
    async function gs_ResearchResultAttachment_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ResearchResultAttachment_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ResearchResultAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ResearchResultAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ResearchResultAttachment_GetMaxStrIdByPrefix = gs_ResearchResultAttachment_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function gs_ResearchResultAttachment_GetWebApiUrl(strController, strAction) {
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
    exports.gs_ResearchResultAttachment_GetWebApiUrl = gs_ResearchResultAttachment_GetWebApiUrl;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function gs_ResearchResultAttachment_CheckPropertyNew(pobjgs_ResearchResultAttachmentEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ResearchResultAttachmentEN.resultId) === true) {
            throw new Error("(errid:Watl000058)字段[成果Id]不能为空(In 研究成果附件表)!(clsgs_ResearchResultAttachmentBL:CheckPropertyNew)");
        }
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ResearchResultAttachmentEN.resultId) == false && (0, clsString_js_1.GetStrLen)(pobjgs_ResearchResultAttachmentEN.resultId) > 10) {
            throw new Error("(errid:Watl000059)字段[成果Id(resultId)]的长度不能超过10(In 研究成果附件表(gs_ResearchResultAttachment))!值:$(pobjgs_ResearchResultAttachmentEN.resultId)(clsgs_ResearchResultAttachmentBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ResearchResultAttachmentEN.topicId) == false && (0, clsString_js_1.GetStrLen)(pobjgs_ResearchResultAttachmentEN.topicId) > 8) {
            throw new Error("(errid:Watl000059)字段[主题Id(topicId)]的长度不能超过8(In 研究成果附件表(gs_ResearchResultAttachment))!值:$(pobjgs_ResearchResultAttachmentEN.topicId)(clsgs_ResearchResultAttachmentBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ResearchResultAttachmentEN.fileName) == false && (0, clsString_js_1.GetStrLen)(pobjgs_ResearchResultAttachmentEN.fileName) > 500) {
            throw new Error("(errid:Watl000059)字段[文件名称(fileName)]的长度不能超过500(In 研究成果附件表(gs_ResearchResultAttachment))!值:$(pobjgs_ResearchResultAttachmentEN.fileName)(clsgs_ResearchResultAttachmentBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ResearchResultAttachmentEN.filePath) == false && (0, clsString_js_1.GetStrLen)(pobjgs_ResearchResultAttachmentEN.filePath) > 500) {
            throw new Error("(errid:Watl000059)字段[文件路径(filePath)]的长度不能超过500(In 研究成果附件表(gs_ResearchResultAttachment))!值:$(pobjgs_ResearchResultAttachmentEN.filePath)(clsgs_ResearchResultAttachmentBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ResearchResultAttachmentEN.updDate) == false && (0, clsString_js_1.GetStrLen)(pobjgs_ResearchResultAttachmentEN.updDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 研究成果附件表(gs_ResearchResultAttachment))!值:$(pobjgs_ResearchResultAttachmentEN.updDate)(clsgs_ResearchResultAttachmentBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ResearchResultAttachmentEN.updUser) == false && (0, clsString_js_1.GetStrLen)(pobjgs_ResearchResultAttachmentEN.updUser) > 20) {
            throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 研究成果附件表(gs_ResearchResultAttachment))!值:$(pobjgs_ResearchResultAttachmentEN.updUser)(clsgs_ResearchResultAttachmentBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ResearchResultAttachmentEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjgs_ResearchResultAttachmentEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 研究成果附件表(gs_ResearchResultAttachment))!值:$(pobjgs_ResearchResultAttachmentEN.memo)(clsgs_ResearchResultAttachmentBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if (null != pobjgs_ResearchResultAttachmentEN.mId && undefined !== pobjgs_ResearchResultAttachmentEN.mId && jsString_js_1.tzDataType.isNumber(pobjgs_ResearchResultAttachmentEN.mId) === false) {
            throw new Error("(errid:Watl000060)字段[mId(mId)]的值:[$(pobjgs_ResearchResultAttachmentEN.mId)], 非法，应该为数值型(In 研究成果附件表(gs_ResearchResultAttachment))!(clsgs_ResearchResultAttachmentBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ResearchResultAttachmentEN.resultId) == false && undefined !== pobjgs_ResearchResultAttachmentEN.resultId && jsString_js_1.tzDataType.isString(pobjgs_ResearchResultAttachmentEN.resultId) === false) {
            throw new Error("(errid:Watl000060)字段[成果Id(resultId)]的值:[$(pobjgs_ResearchResultAttachmentEN.resultId)], 非法，应该为字符型(In 研究成果附件表(gs_ResearchResultAttachment))!(clsgs_ResearchResultAttachmentBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ResearchResultAttachmentEN.topicId) == false && undefined !== pobjgs_ResearchResultAttachmentEN.topicId && jsString_js_1.tzDataType.isString(pobjgs_ResearchResultAttachmentEN.topicId) === false) {
            throw new Error("(errid:Watl000060)字段[主题Id(topicId)]的值:[$(pobjgs_ResearchResultAttachmentEN.topicId)], 非法，应该为字符型(In 研究成果附件表(gs_ResearchResultAttachment))!(clsgs_ResearchResultAttachmentBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ResearchResultAttachmentEN.fileName) == false && undefined !== pobjgs_ResearchResultAttachmentEN.fileName && jsString_js_1.tzDataType.isString(pobjgs_ResearchResultAttachmentEN.fileName) === false) {
            throw new Error("(errid:Watl000060)字段[文件名称(fileName)]的值:[$(pobjgs_ResearchResultAttachmentEN.fileName)], 非法，应该为字符型(In 研究成果附件表(gs_ResearchResultAttachment))!(clsgs_ResearchResultAttachmentBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ResearchResultAttachmentEN.filePath) == false && undefined !== pobjgs_ResearchResultAttachmentEN.filePath && jsString_js_1.tzDataType.isString(pobjgs_ResearchResultAttachmentEN.filePath) === false) {
            throw new Error("(errid:Watl000060)字段[文件路径(filePath)]的值:[$(pobjgs_ResearchResultAttachmentEN.filePath)], 非法，应该为字符型(In 研究成果附件表(gs_ResearchResultAttachment))!(clsgs_ResearchResultAttachmentBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ResearchResultAttachmentEN.updDate) == false && undefined !== pobjgs_ResearchResultAttachmentEN.updDate && jsString_js_1.tzDataType.isString(pobjgs_ResearchResultAttachmentEN.updDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjgs_ResearchResultAttachmentEN.updDate)], 非法，应该为字符型(In 研究成果附件表(gs_ResearchResultAttachment))!(clsgs_ResearchResultAttachmentBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ResearchResultAttachmentEN.updUser) == false && undefined !== pobjgs_ResearchResultAttachmentEN.updUser && jsString_js_1.tzDataType.isString(pobjgs_ResearchResultAttachmentEN.updUser) === false) {
            throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjgs_ResearchResultAttachmentEN.updUser)], 非法，应该为字符型(In 研究成果附件表(gs_ResearchResultAttachment))!(clsgs_ResearchResultAttachmentBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ResearchResultAttachmentEN.memo) == false && undefined !== pobjgs_ResearchResultAttachmentEN.memo && jsString_js_1.tzDataType.isString(pobjgs_ResearchResultAttachmentEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjgs_ResearchResultAttachmentEN.memo)], 非法，应该为字符型(In 研究成果附件表(gs_ResearchResultAttachment))!(clsgs_ResearchResultAttachmentBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjgs_ResearchResultAttachmentEN.SetIsCheckProperty(true);
    }
    exports.gs_ResearchResultAttachment_CheckPropertyNew = gs_ResearchResultAttachment_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function gs_ResearchResultAttachment_CheckProperty4Update(pobjgs_ResearchResultAttachmentEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ResearchResultAttachmentEN.resultId) == false && (0, clsString_js_1.GetStrLen)(pobjgs_ResearchResultAttachmentEN.resultId) > 10) {
            throw new Error("(errid:Watl000062)字段[成果Id(resultId)]的长度不能超过10(In 研究成果附件表(gs_ResearchResultAttachment))!值:$(pobjgs_ResearchResultAttachmentEN.resultId)(clsgs_ResearchResultAttachmentBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ResearchResultAttachmentEN.topicId) == false && (0, clsString_js_1.GetStrLen)(pobjgs_ResearchResultAttachmentEN.topicId) > 8) {
            throw new Error("(errid:Watl000062)字段[主题Id(topicId)]的长度不能超过8(In 研究成果附件表(gs_ResearchResultAttachment))!值:$(pobjgs_ResearchResultAttachmentEN.topicId)(clsgs_ResearchResultAttachmentBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ResearchResultAttachmentEN.fileName) == false && (0, clsString_js_1.GetStrLen)(pobjgs_ResearchResultAttachmentEN.fileName) > 500) {
            throw new Error("(errid:Watl000062)字段[文件名称(fileName)]的长度不能超过500(In 研究成果附件表(gs_ResearchResultAttachment))!值:$(pobjgs_ResearchResultAttachmentEN.fileName)(clsgs_ResearchResultAttachmentBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ResearchResultAttachmentEN.filePath) == false && (0, clsString_js_1.GetStrLen)(pobjgs_ResearchResultAttachmentEN.filePath) > 500) {
            throw new Error("(errid:Watl000062)字段[文件路径(filePath)]的长度不能超过500(In 研究成果附件表(gs_ResearchResultAttachment))!值:$(pobjgs_ResearchResultAttachmentEN.filePath)(clsgs_ResearchResultAttachmentBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ResearchResultAttachmentEN.updDate) == false && (0, clsString_js_1.GetStrLen)(pobjgs_ResearchResultAttachmentEN.updDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 研究成果附件表(gs_ResearchResultAttachment))!值:$(pobjgs_ResearchResultAttachmentEN.updDate)(clsgs_ResearchResultAttachmentBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ResearchResultAttachmentEN.updUser) == false && (0, clsString_js_1.GetStrLen)(pobjgs_ResearchResultAttachmentEN.updUser) > 20) {
            throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 研究成果附件表(gs_ResearchResultAttachment))!值:$(pobjgs_ResearchResultAttachmentEN.updUser)(clsgs_ResearchResultAttachmentBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ResearchResultAttachmentEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjgs_ResearchResultAttachmentEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 研究成果附件表(gs_ResearchResultAttachment))!值:$(pobjgs_ResearchResultAttachmentEN.memo)(clsgs_ResearchResultAttachmentBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if (null != pobjgs_ResearchResultAttachmentEN.mId && undefined !== pobjgs_ResearchResultAttachmentEN.mId && jsString_js_1.tzDataType.isNumber(pobjgs_ResearchResultAttachmentEN.mId) === false) {
            throw new Error("(errid:Watl000063)字段[mId(mId)]的值:[$(pobjgs_ResearchResultAttachmentEN.mId)], 非法，应该为数值型(In 研究成果附件表(gs_ResearchResultAttachment))!(clsgs_ResearchResultAttachmentBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ResearchResultAttachmentEN.resultId) == false && undefined !== pobjgs_ResearchResultAttachmentEN.resultId && jsString_js_1.tzDataType.isString(pobjgs_ResearchResultAttachmentEN.resultId) === false) {
            throw new Error("(errid:Watl000063)字段[成果Id(resultId)]的值:[$(pobjgs_ResearchResultAttachmentEN.resultId)], 非法，应该为字符型(In 研究成果附件表(gs_ResearchResultAttachment))!(clsgs_ResearchResultAttachmentBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ResearchResultAttachmentEN.topicId) == false && undefined !== pobjgs_ResearchResultAttachmentEN.topicId && jsString_js_1.tzDataType.isString(pobjgs_ResearchResultAttachmentEN.topicId) === false) {
            throw new Error("(errid:Watl000063)字段[主题Id(topicId)]的值:[$(pobjgs_ResearchResultAttachmentEN.topicId)], 非法，应该为字符型(In 研究成果附件表(gs_ResearchResultAttachment))!(clsgs_ResearchResultAttachmentBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ResearchResultAttachmentEN.fileName) == false && undefined !== pobjgs_ResearchResultAttachmentEN.fileName && jsString_js_1.tzDataType.isString(pobjgs_ResearchResultAttachmentEN.fileName) === false) {
            throw new Error("(errid:Watl000063)字段[文件名称(fileName)]的值:[$(pobjgs_ResearchResultAttachmentEN.fileName)], 非法，应该为字符型(In 研究成果附件表(gs_ResearchResultAttachment))!(clsgs_ResearchResultAttachmentBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ResearchResultAttachmentEN.filePath) == false && undefined !== pobjgs_ResearchResultAttachmentEN.filePath && jsString_js_1.tzDataType.isString(pobjgs_ResearchResultAttachmentEN.filePath) === false) {
            throw new Error("(errid:Watl000063)字段[文件路径(filePath)]的值:[$(pobjgs_ResearchResultAttachmentEN.filePath)], 非法，应该为字符型(In 研究成果附件表(gs_ResearchResultAttachment))!(clsgs_ResearchResultAttachmentBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ResearchResultAttachmentEN.updDate) == false && undefined !== pobjgs_ResearchResultAttachmentEN.updDate && jsString_js_1.tzDataType.isString(pobjgs_ResearchResultAttachmentEN.updDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjgs_ResearchResultAttachmentEN.updDate)], 非法，应该为字符型(In 研究成果附件表(gs_ResearchResultAttachment))!(clsgs_ResearchResultAttachmentBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ResearchResultAttachmentEN.updUser) == false && undefined !== pobjgs_ResearchResultAttachmentEN.updUser && jsString_js_1.tzDataType.isString(pobjgs_ResearchResultAttachmentEN.updUser) === false) {
            throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjgs_ResearchResultAttachmentEN.updUser)], 非法，应该为字符型(In 研究成果附件表(gs_ResearchResultAttachment))!(clsgs_ResearchResultAttachmentBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ResearchResultAttachmentEN.memo) == false && undefined !== pobjgs_ResearchResultAttachmentEN.memo && jsString_js_1.tzDataType.isString(pobjgs_ResearchResultAttachmentEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjgs_ResearchResultAttachmentEN.memo)], 非法，应该为字符型(In 研究成果附件表(gs_ResearchResultAttachment))!(clsgs_ResearchResultAttachmentBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if (null === pobjgs_ResearchResultAttachmentEN.mId
            || pobjgs_ResearchResultAttachmentEN.mId != null && pobjgs_ResearchResultAttachmentEN.mId.toString() === "") {
            throw new Error("(errid:Watl000064)字段[mId]不能为空(In 研究成果附件表)!(clsgs_ResearchResultAttachmentBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjgs_ResearchResultAttachmentEN.SetIsCheckProperty(true);
    }
    exports.gs_ResearchResultAttachment_CheckProperty4Update = gs_ResearchResultAttachment_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function gs_ResearchResultAttachment_GetJSONStrByObj(pobjgs_ResearchResultAttachmentEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjgs_ResearchResultAttachmentEN.sf_UpdFldSetStr = pobjgs_ResearchResultAttachmentEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjgs_ResearchResultAttachmentEN);
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
    exports.gs_ResearchResultAttachment_GetJSONStrByObj = gs_ResearchResultAttachment_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function gs_ResearchResultAttachment_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrgs_ResearchResultAttachmentObjLst = new Array();
        if (strJSON === "") {
            return arrgs_ResearchResultAttachmentObjLst;
        }
        try {
            arrgs_ResearchResultAttachmentObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrgs_ResearchResultAttachmentObjLst;
        }
        return arrgs_ResearchResultAttachmentObjLst;
    }
    exports.gs_ResearchResultAttachment_GetObjLstByJSONStr = gs_ResearchResultAttachment_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrgs_ResearchResultAttachmentObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function gs_ResearchResultAttachment_GetObjLstByJSONObjLst(arrgs_ResearchResultAttachmentObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrgs_ResearchResultAttachmentObjLst = new Array();
        for (const objInFor of arrgs_ResearchResultAttachmentObjLstS) {
            const obj1 = gs_ResearchResultAttachment_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrgs_ResearchResultAttachmentObjLst.push(obj1);
        }
        return arrgs_ResearchResultAttachmentObjLst;
    }
    exports.gs_ResearchResultAttachment_GetObjLstByJSONObjLst = gs_ResearchResultAttachment_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function gs_ResearchResultAttachment_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjgs_ResearchResultAttachmentEN = new clsgs_ResearchResultAttachmentEN_js_1.clsgs_ResearchResultAttachmentEN();
        if (strJSON === "") {
            return pobjgs_ResearchResultAttachmentEN;
        }
        try {
            pobjgs_ResearchResultAttachmentEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjgs_ResearchResultAttachmentEN;
        }
        return pobjgs_ResearchResultAttachmentEN;
    }
    exports.gs_ResearchResultAttachment_GetObjByJSONStr = gs_ResearchResultAttachment_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function gs_ResearchResultAttachment_GetCombineCondition(objgs_ResearchResultAttachment_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objgs_ResearchResultAttachment_Cond.dicFldComparisonOp, clsgs_ResearchResultAttachmentEN_js_1.clsgs_ResearchResultAttachmentEN.con_mId) == true) {
            const strComparisonOp_mId = objgs_ResearchResultAttachment_Cond.dicFldComparisonOp[clsgs_ResearchResultAttachmentEN_js_1.clsgs_ResearchResultAttachmentEN.con_mId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsgs_ResearchResultAttachmentEN_js_1.clsgs_ResearchResultAttachmentEN.con_mId, objgs_ResearchResultAttachment_Cond.mId, strComparisonOp_mId);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_ResearchResultAttachment_Cond.dicFldComparisonOp, clsgs_ResearchResultAttachmentEN_js_1.clsgs_ResearchResultAttachmentEN.con_ResultId) == true) {
            const strComparisonOp_ResultId = objgs_ResearchResultAttachment_Cond.dicFldComparisonOp[clsgs_ResearchResultAttachmentEN_js_1.clsgs_ResearchResultAttachmentEN.con_ResultId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_ResearchResultAttachmentEN_js_1.clsgs_ResearchResultAttachmentEN.con_ResultId, objgs_ResearchResultAttachment_Cond.resultId, strComparisonOp_ResultId);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_ResearchResultAttachment_Cond.dicFldComparisonOp, clsgs_ResearchResultAttachmentEN_js_1.clsgs_ResearchResultAttachmentEN.con_TopicId) == true) {
            const strComparisonOp_TopicId = objgs_ResearchResultAttachment_Cond.dicFldComparisonOp[clsgs_ResearchResultAttachmentEN_js_1.clsgs_ResearchResultAttachmentEN.con_TopicId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_ResearchResultAttachmentEN_js_1.clsgs_ResearchResultAttachmentEN.con_TopicId, objgs_ResearchResultAttachment_Cond.topicId, strComparisonOp_TopicId);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_ResearchResultAttachment_Cond.dicFldComparisonOp, clsgs_ResearchResultAttachmentEN_js_1.clsgs_ResearchResultAttachmentEN.con_FileName) == true) {
            const strComparisonOp_FileName = objgs_ResearchResultAttachment_Cond.dicFldComparisonOp[clsgs_ResearchResultAttachmentEN_js_1.clsgs_ResearchResultAttachmentEN.con_FileName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_ResearchResultAttachmentEN_js_1.clsgs_ResearchResultAttachmentEN.con_FileName, objgs_ResearchResultAttachment_Cond.fileName, strComparisonOp_FileName);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_ResearchResultAttachment_Cond.dicFldComparisonOp, clsgs_ResearchResultAttachmentEN_js_1.clsgs_ResearchResultAttachmentEN.con_FilePath) == true) {
            const strComparisonOp_FilePath = objgs_ResearchResultAttachment_Cond.dicFldComparisonOp[clsgs_ResearchResultAttachmentEN_js_1.clsgs_ResearchResultAttachmentEN.con_FilePath];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_ResearchResultAttachmentEN_js_1.clsgs_ResearchResultAttachmentEN.con_FilePath, objgs_ResearchResultAttachment_Cond.filePath, strComparisonOp_FilePath);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_ResearchResultAttachment_Cond.dicFldComparisonOp, clsgs_ResearchResultAttachmentEN_js_1.clsgs_ResearchResultAttachmentEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objgs_ResearchResultAttachment_Cond.dicFldComparisonOp[clsgs_ResearchResultAttachmentEN_js_1.clsgs_ResearchResultAttachmentEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_ResearchResultAttachmentEN_js_1.clsgs_ResearchResultAttachmentEN.con_UpdDate, objgs_ResearchResultAttachment_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_ResearchResultAttachment_Cond.dicFldComparisonOp, clsgs_ResearchResultAttachmentEN_js_1.clsgs_ResearchResultAttachmentEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objgs_ResearchResultAttachment_Cond.dicFldComparisonOp[clsgs_ResearchResultAttachmentEN_js_1.clsgs_ResearchResultAttachmentEN.con_UpdUser];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_ResearchResultAttachmentEN_js_1.clsgs_ResearchResultAttachmentEN.con_UpdUser, objgs_ResearchResultAttachment_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_ResearchResultAttachment_Cond.dicFldComparisonOp, clsgs_ResearchResultAttachmentEN_js_1.clsgs_ResearchResultAttachmentEN.con_Memo) == true) {
            const strComparisonOp_Memo = objgs_ResearchResultAttachment_Cond.dicFldComparisonOp[clsgs_ResearchResultAttachmentEN_js_1.clsgs_ResearchResultAttachmentEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_ResearchResultAttachmentEN_js_1.clsgs_ResearchResultAttachmentEN.con_Memo, objgs_ResearchResultAttachment_Cond.memo, strComparisonOp_Memo);
        }
        return strWhereCond;
    }
    exports.gs_ResearchResultAttachment_GetCombineCondition = gs_ResearchResultAttachment_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--gs_ResearchResultAttachment(研究成果附件表),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param lngmId: mId(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function gs_ResearchResultAttachment_GetUniCondStr_mId(objgs_ResearchResultAttachmentEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and mId = '{0}'", objgs_ResearchResultAttachmentEN.mId);
        return strWhereCond;
    }
    exports.gs_ResearchResultAttachment_GetUniCondStr_mId = gs_ResearchResultAttachment_GetUniCondStr_mId;
    /**
    *获取唯一性条件串(Uniqueness)--gs_ResearchResultAttachment(研究成果附件表),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param lngmId: mId(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function gs_ResearchResultAttachment_GetUniCondStr4Update_mId(objgs_ResearchResultAttachmentEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and mId <> '{0}'", objgs_ResearchResultAttachmentEN.mId);
        strWhereCond += (0, clsString_js_1.Format)(" and mId = '{0}'", objgs_ResearchResultAttachmentEN.mId);
        return strWhereCond;
    }
    exports.gs_ResearchResultAttachment_GetUniCondStr4Update_mId = gs_ResearchResultAttachment_GetUniCondStr4Update_mId;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objgs_ResearchResultAttachmentENS:源对象
     * @param objgs_ResearchResultAttachmentENT:目标对象
    */
    function gs_ResearchResultAttachment_CopyObjTo(objgs_ResearchResultAttachmentENS, objgs_ResearchResultAttachmentENT) {
        objgs_ResearchResultAttachmentENT.mId = objgs_ResearchResultAttachmentENS.mId; //mId
        objgs_ResearchResultAttachmentENT.resultId = objgs_ResearchResultAttachmentENS.resultId; //成果Id
        objgs_ResearchResultAttachmentENT.topicId = objgs_ResearchResultAttachmentENS.topicId; //主题Id
        objgs_ResearchResultAttachmentENT.fileName = objgs_ResearchResultAttachmentENS.fileName; //文件名称
        objgs_ResearchResultAttachmentENT.filePath = objgs_ResearchResultAttachmentENS.filePath; //文件路径
        objgs_ResearchResultAttachmentENT.updDate = objgs_ResearchResultAttachmentENS.updDate; //修改日期
        objgs_ResearchResultAttachmentENT.updUser = objgs_ResearchResultAttachmentENS.updUser; //修改人
        objgs_ResearchResultAttachmentENT.memo = objgs_ResearchResultAttachmentENS.memo; //备注
        objgs_ResearchResultAttachmentENT.sf_UpdFldSetStr = objgs_ResearchResultAttachmentENS.updFldString; //sf_UpdFldSetStr
    }
    exports.gs_ResearchResultAttachment_CopyObjTo = gs_ResearchResultAttachment_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objgs_ResearchResultAttachmentENS:源对象
     * @param objgs_ResearchResultAttachmentENT:目标对象
    */
    function gs_ResearchResultAttachment_GetObjFromJsonObj(objgs_ResearchResultAttachmentENS) {
        const objgs_ResearchResultAttachmentENT = new clsgs_ResearchResultAttachmentEN_js_1.clsgs_ResearchResultAttachmentEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objgs_ResearchResultAttachmentENT, objgs_ResearchResultAttachmentENS);
        return objgs_ResearchResultAttachmentENT;
    }
    exports.gs_ResearchResultAttachment_GetObjFromJsonObj = gs_ResearchResultAttachment_GetObjFromJsonObj;
});
