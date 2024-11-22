/**
* 类名:clsgs_PTopicObjectiveRelaWApi
* 表名:gs_PTopicObjectiveRela(01120673)
* 生成代码版本:2022.11.02.1
* 生成日期:2022/11/02 11:46:46
* 生成者:pyf
* 生成服务器IP:
工程名称:问卷调查(0112)
CM工程:研究生论文学习(变量首字母小写)-全部函数集
* 相关数据库:103.116.76.183,9433EduHigh_Jsie
* PrjDataBaseId:0170
模块中文名:研培论文(GraduateEduPaper)
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
        define(["require", "exports", "axios", "../../L0_Entity/GraduateEduPaper/clsgs_PTopicObjectiveRelaEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsSysPara4WebApi.js", "../../PubFun/jsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.gs_PTopicObjectiveRela_GetObjFromJsonObj = exports.gs_PTopicObjectiveRela_CopyObjTo = exports.gs_PTopicObjectiveRela_GetUniCondStr4Update_mId = exports.gs_PTopicObjectiveRela_GetUniCondStr_mId = exports.gs_PTopicObjectiveRela_GetCombineCondition = exports.gs_PTopicObjectiveRela_GetObjByJSONStr = exports.gs_PTopicObjectiveRela_GetObjLstByJSONObjLst = exports.gs_PTopicObjectiveRela_GetObjLstByJSONStr = exports.gs_PTopicObjectiveRela_GetJSONStrByObj = exports.gs_PTopicObjectiveRela_CheckProperty4Update = exports.gs_PTopicObjectiveRela_CheckPropertyNew = exports.gs_PTopicObjectiveRela_GetWebApiUrl = exports.gs_PTopicObjectiveRela_GetMaxStrIdByPrefix = exports.gs_PTopicObjectiveRela_GetRecCountByCondAsync = exports.gs_PTopicObjectiveRela_IsExistAsync = exports.gs_PTopicObjectiveRela_IsExist = exports.gs_PTopicObjectiveRela_IsExistRecordAsync = exports.gs_PTopicObjectiveRela_UpdateWithConditionAsync = exports.gs_PTopicObjectiveRela_UpdateRecordAsync = exports.gs_PTopicObjectiveRela_AddNewRecordWithReturnKey = exports.gs_PTopicObjectiveRela_AddNewRecordWithReturnKeyAsync = exports.gs_PTopicObjectiveRela_AddNewRecordAsync = exports.gs_PTopicObjectiveRela_Delgs_PTopicObjectiveRelasByCondAsync = exports.gs_PTopicObjectiveRela_Delgs_PTopicObjectiveRelasAsync = exports.gs_PTopicObjectiveRela_DelRecordAsync = exports.gs_PTopicObjectiveRela_GetObjLstByPagerAsync = exports.gs_PTopicObjectiveRela_GetObjLstByRange = exports.gs_PTopicObjectiveRela_GetObjLstByRangeAsync = exports.gs_PTopicObjectiveRela_GetTopObjLstAsync = exports.gs_PTopicObjectiveRela_GetObjLstBymIdLstAsync = exports.gs_PTopicObjectiveRela_GetObjLstAsync = exports.gs_PTopicObjectiveRela_GetFirstObjAsync = exports.gs_PTopicObjectiveRela_GetFirstID = exports.gs_PTopicObjectiveRela_GetFirstIDAsync = exports.gs_PTopicObjectiveRela_FilterFunByKey = exports.gs_PTopicObjectiveRela_SortFunByKey = exports.gs_PTopicObjectiveRela_SortFun_Defa_2Fld = exports.gs_PTopicObjectiveRela_SortFun_Defa = exports.gs_PTopicObjectiveRela_GetObjBymIdAsync = exports.gs_PTopicObjectiveRela_ConstructorName = exports.gs_PTopicObjectiveRela_Controller = void 0;
    /**
     * 论文客观关系表(gs_PTopicObjectiveRela)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2022年11月02日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const clsgs_PTopicObjectiveRelaEN_js_1 = require("../../L0_Entity/GraduateEduPaper/clsgs_PTopicObjectiveRelaEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    const jsString_js_1 = require("../../PubFun/jsString.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.gs_PTopicObjectiveRela_Controller = "gs_PTopicObjectiveRelaApi";
    exports.gs_PTopicObjectiveRela_ConstructorName = "gs_PTopicObjectiveRela";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param lngmId:关键字
    * @returns 对象
    **/
    async function gs_PTopicObjectiveRela_GetObjBymIdAsync(lngmId) {
        const strThisFuncName = "GetObjBymIdAsync";
        if (lngmId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngmId]不能为空！(In GetObjBymIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjBymId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PTopicObjectiveRela_Controller, strAction);
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
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objgs_PTopicObjectiveRela = gs_PTopicObjectiveRela_GetObjFromJsonObj(returnObj);
                return objgs_PTopicObjectiveRela;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PTopicObjectiveRela_GetObjBymIdAsync = gs_PTopicObjectiveRela_GetObjBymIdAsync;
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
    function gs_PTopicObjectiveRela_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.mId - b.mId;
    }
    exports.gs_PTopicObjectiveRela_SortFun_Defa = gs_PTopicObjectiveRela_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function gs_PTopicObjectiveRela_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.paperId == b.paperId)
            return a.sectionId.localeCompare(b.sectionId);
        else
            return a.paperId.localeCompare(b.paperId);
    }
    exports.gs_PTopicObjectiveRela_SortFun_Defa_2Fld = gs_PTopicObjectiveRela_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function gs_PTopicObjectiveRela_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsgs_PTopicObjectiveRelaEN_js_1.clsgs_PTopicObjectiveRelaEN.con_mId:
                    return (a, b) => {
                        return a.mId - b.mId;
                    };
                case clsgs_PTopicObjectiveRelaEN_js_1.clsgs_PTopicObjectiveRelaEN.con_PaperId:
                    return (a, b) => {
                        return a.paperId.localeCompare(b.paperId);
                    };
                case clsgs_PTopicObjectiveRelaEN_js_1.clsgs_PTopicObjectiveRelaEN.con_SectionId:
                    return (a, b) => {
                        return a.sectionId.localeCompare(b.sectionId);
                    };
                case clsgs_PTopicObjectiveRelaEN_js_1.clsgs_PTopicObjectiveRelaEN.con_TopicObjectiveId:
                    return (a, b) => {
                        return a.topicObjectiveId.localeCompare(b.topicObjectiveId);
                    };
                case clsgs_PTopicObjectiveRelaEN_js_1.clsgs_PTopicObjectiveRelaEN.con_UpdDate:
                    return (a, b) => {
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsgs_PTopicObjectiveRelaEN_js_1.clsgs_PTopicObjectiveRelaEN.con_UpdUser:
                    return (a, b) => {
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsgs_PTopicObjectiveRelaEN_js_1.clsgs_PTopicObjectiveRelaEN.con_Memo:
                    return (a, b) => {
                        return a.memo.localeCompare(b.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[gs_PTopicObjectiveRela]中不存在！(in ${exports.gs_PTopicObjectiveRela_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsgs_PTopicObjectiveRelaEN_js_1.clsgs_PTopicObjectiveRelaEN.con_mId:
                    return (a, b) => {
                        return b.mId - a.mId;
                    };
                case clsgs_PTopicObjectiveRelaEN_js_1.clsgs_PTopicObjectiveRelaEN.con_PaperId:
                    return (a, b) => {
                        return b.paperId.localeCompare(a.paperId);
                    };
                case clsgs_PTopicObjectiveRelaEN_js_1.clsgs_PTopicObjectiveRelaEN.con_SectionId:
                    return (a, b) => {
                        return b.sectionId.localeCompare(a.sectionId);
                    };
                case clsgs_PTopicObjectiveRelaEN_js_1.clsgs_PTopicObjectiveRelaEN.con_TopicObjectiveId:
                    return (a, b) => {
                        return b.topicObjectiveId.localeCompare(a.topicObjectiveId);
                    };
                case clsgs_PTopicObjectiveRelaEN_js_1.clsgs_PTopicObjectiveRelaEN.con_UpdDate:
                    return (a, b) => {
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsgs_PTopicObjectiveRelaEN_js_1.clsgs_PTopicObjectiveRelaEN.con_UpdUser:
                    return (a, b) => {
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsgs_PTopicObjectiveRelaEN_js_1.clsgs_PTopicObjectiveRelaEN.con_Memo:
                    return (a, b) => {
                        return b.memo.localeCompare(a.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[gs_PTopicObjectiveRela]中不存在！(in ${exports.gs_PTopicObjectiveRela_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.gs_PTopicObjectiveRela_SortFunByKey = gs_PTopicObjectiveRela_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function gs_PTopicObjectiveRela_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsgs_PTopicObjectiveRelaEN_js_1.clsgs_PTopicObjectiveRelaEN.con_mId:
                return (obj) => {
                    return obj.mId === value;
                };
            case clsgs_PTopicObjectiveRelaEN_js_1.clsgs_PTopicObjectiveRelaEN.con_PaperId:
                return (obj) => {
                    return obj.paperId === value;
                };
            case clsgs_PTopicObjectiveRelaEN_js_1.clsgs_PTopicObjectiveRelaEN.con_SectionId:
                return (obj) => {
                    return obj.sectionId === value;
                };
            case clsgs_PTopicObjectiveRelaEN_js_1.clsgs_PTopicObjectiveRelaEN.con_TopicObjectiveId:
                return (obj) => {
                    return obj.topicObjectiveId === value;
                };
            case clsgs_PTopicObjectiveRelaEN_js_1.clsgs_PTopicObjectiveRelaEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsgs_PTopicObjectiveRelaEN_js_1.clsgs_PTopicObjectiveRelaEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsgs_PTopicObjectiveRelaEN_js_1.clsgs_PTopicObjectiveRelaEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[gs_PTopicObjectiveRela]中不存在！(in ${exports.gs_PTopicObjectiveRela_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.gs_PTopicObjectiveRela_FilterFunByKey = gs_PTopicObjectiveRela_FilterFunByKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function gs_PTopicObjectiveRela_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PTopicObjectiveRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PTopicObjectiveRela_GetFirstIDAsync = gs_PTopicObjectiveRela_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function gs_PTopicObjectiveRela_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PTopicObjectiveRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PTopicObjectiveRela_GetFirstID = gs_PTopicObjectiveRela_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function gs_PTopicObjectiveRela_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PTopicObjectiveRela_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objgs_PTopicObjectiveRela = gs_PTopicObjectiveRela_GetObjFromJsonObj(returnObj);
                return objgs_PTopicObjectiveRela;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PTopicObjectiveRela_GetFirstObjAsync = gs_PTopicObjectiveRela_GetFirstObjAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function gs_PTopicObjectiveRela_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PTopicObjectiveRela_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_PTopicObjectiveRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PTopicObjectiveRela_GetObjLstAsync = gs_PTopicObjectiveRela_GetObjLstAsync;
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
    async function gs_PTopicObjectiveRela_GetObjLstBymIdLstAsync(arrmId) {
        const strThisFuncName = "GetObjLstBymIdLstAsync";
        const strAction = "GetObjLstBymIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PTopicObjectiveRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrmId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_PTopicObjectiveRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PTopicObjectiveRela_GetObjLstBymIdLstAsync = gs_PTopicObjectiveRela_GetObjLstBymIdLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function gs_PTopicObjectiveRela_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PTopicObjectiveRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_PTopicObjectiveRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PTopicObjectiveRela_GetTopObjLstAsync = gs_PTopicObjectiveRela_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function gs_PTopicObjectiveRela_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PTopicObjectiveRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_PTopicObjectiveRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PTopicObjectiveRela_GetObjLstByRangeAsync = gs_PTopicObjectiveRela_GetObjLstByRangeAsync;
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
    async function gs_PTopicObjectiveRela_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PTopicObjectiveRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PTopicObjectiveRela_GetObjLstByRange = gs_PTopicObjectiveRela_GetObjLstByRange;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function gs_PTopicObjectiveRela_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PTopicObjectiveRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_PTopicObjectiveRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PTopicObjectiveRela_GetObjLstByPagerAsync = gs_PTopicObjectiveRela_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param lngmId:关键字
    * @returns 获取删除的结果
    **/
    async function gs_PTopicObjectiveRela_DelRecordAsync(lngmId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PTopicObjectiveRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PTopicObjectiveRela_DelRecordAsync = gs_PTopicObjectiveRela_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrmId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function gs_PTopicObjectiveRela_Delgs_PTopicObjectiveRelasAsync(arrmId) {
        const strThisFuncName = "Delgs_PTopicObjectiveRelasAsync";
        const strAction = "Delgs_PTopicObjectiveRelas";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PTopicObjectiveRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PTopicObjectiveRela_Delgs_PTopicObjectiveRelasAsync = gs_PTopicObjectiveRela_Delgs_PTopicObjectiveRelasAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function gs_PTopicObjectiveRela_Delgs_PTopicObjectiveRelasByCondAsync(strWhereCond) {
        const strThisFuncName = "Delgs_PTopicObjectiveRelasByCondAsync";
        const strAction = "Delgs_PTopicObjectiveRelasByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PTopicObjectiveRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PTopicObjectiveRela_Delgs_PTopicObjectiveRelasByCondAsync = gs_PTopicObjectiveRela_Delgs_PTopicObjectiveRelasByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objgs_PTopicObjectiveRelaEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function gs_PTopicObjectiveRela_AddNewRecordAsync(objgs_PTopicObjectiveRelaEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objgs_PTopicObjectiveRelaEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PTopicObjectiveRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_PTopicObjectiveRelaEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PTopicObjectiveRela_AddNewRecordAsync = gs_PTopicObjectiveRela_AddNewRecordAsync;
    /* 数据类型不是字符型，不可以最大关键字的方式添加记录。*/
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objgs_PTopicObjectiveRelaEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function gs_PTopicObjectiveRela_AddNewRecordWithReturnKeyAsync(objgs_PTopicObjectiveRelaEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PTopicObjectiveRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_PTopicObjectiveRelaEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PTopicObjectiveRela_AddNewRecordWithReturnKeyAsync = gs_PTopicObjectiveRela_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objgs_PTopicObjectiveRelaEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function gs_PTopicObjectiveRela_AddNewRecordWithReturnKey(objgs_PTopicObjectiveRelaEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objgs_PTopicObjectiveRelaEN.mId === null || objgs_PTopicObjectiveRelaEN.mId === 0) {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PTopicObjectiveRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_PTopicObjectiveRelaEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PTopicObjectiveRela_AddNewRecordWithReturnKey = gs_PTopicObjectiveRela_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objgs_PTopicObjectiveRelaEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function gs_PTopicObjectiveRela_UpdateRecordAsync(objgs_PTopicObjectiveRelaEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objgs_PTopicObjectiveRelaEN.sf_UpdFldSetStr === undefined || objgs_PTopicObjectiveRelaEN.sf_UpdFldSetStr === null || objgs_PTopicObjectiveRelaEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_PTopicObjectiveRelaEN.mId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PTopicObjectiveRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_PTopicObjectiveRelaEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PTopicObjectiveRela_UpdateRecordAsync = gs_PTopicObjectiveRela_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objgs_PTopicObjectiveRelaEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function gs_PTopicObjectiveRela_UpdateWithConditionAsync(objgs_PTopicObjectiveRelaEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objgs_PTopicObjectiveRelaEN.sf_UpdFldSetStr === undefined || objgs_PTopicObjectiveRelaEN.sf_UpdFldSetStr === null || objgs_PTopicObjectiveRelaEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_PTopicObjectiveRelaEN.mId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PTopicObjectiveRela_Controller, strAction);
        objgs_PTopicObjectiveRelaEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objgs_PTopicObjectiveRelaEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PTopicObjectiveRela_UpdateWithConditionAsync = gs_PTopicObjectiveRela_UpdateWithConditionAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function gs_PTopicObjectiveRela_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PTopicObjectiveRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PTopicObjectiveRela_IsExistRecordAsync = gs_PTopicObjectiveRela_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param lngmId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function gs_PTopicObjectiveRela_IsExist(lngmId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PTopicObjectiveRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PTopicObjectiveRela_IsExist = gs_PTopicObjectiveRela_IsExist;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param lngmId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function gs_PTopicObjectiveRela_IsExistAsync(lngmId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PTopicObjectiveRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PTopicObjectiveRela_IsExistAsync = gs_PTopicObjectiveRela_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function gs_PTopicObjectiveRela_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PTopicObjectiveRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PTopicObjectiveRela_GetRecCountByCondAsync = gs_PTopicObjectiveRela_GetRecCountByCondAsync;
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
    async function gs_PTopicObjectiveRela_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PTopicObjectiveRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PTopicObjectiveRela_GetMaxStrIdByPrefix = gs_PTopicObjectiveRela_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function gs_PTopicObjectiveRela_GetWebApiUrl(strController, strAction) {
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
    exports.gs_PTopicObjectiveRela_GetWebApiUrl = gs_PTopicObjectiveRela_GetWebApiUrl;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function gs_PTopicObjectiveRela_CheckPropertyNew(pobjgs_PTopicObjectiveRelaEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PTopicObjectiveRelaEN.paperId) === true
            || pobjgs_PTopicObjectiveRelaEN.paperId.toString() === "0") {
            throw new Error("(errid:Watl000058)字段[论文Id]不能为空(In 论文客观关系表)!(clsgs_PTopicObjectiveRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PTopicObjectiveRelaEN.topicObjectiveId) === true) {
            throw new Error("(errid:Watl000058)字段[客观Id]不能为空(In 论文客观关系表)!(clsgs_PTopicObjectiveRelaBL:CheckPropertyNew)");
        }
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PTopicObjectiveRelaEN.paperId) == false && (0, clsString_js_1.GetStrLen)(pobjgs_PTopicObjectiveRelaEN.paperId) > 8) {
            throw new Error("(errid:Watl000059)字段[论文Id(paperId)]的长度不能超过8(In 论文客观关系表(gs_PTopicObjectiveRela))!值:$(pobjgs_PTopicObjectiveRelaEN.paperId)(clsgs_PTopicObjectiveRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PTopicObjectiveRelaEN.sectionId) == false && (0, clsString_js_1.GetStrLen)(pobjgs_PTopicObjectiveRelaEN.sectionId) > 8) {
            throw new Error("(errid:Watl000059)字段[节Id(sectionId)]的长度不能超过8(In 论文客观关系表(gs_PTopicObjectiveRela))!值:$(pobjgs_PTopicObjectiveRelaEN.sectionId)(clsgs_PTopicObjectiveRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PTopicObjectiveRelaEN.topicObjectiveId) == false && (0, clsString_js_1.GetStrLen)(pobjgs_PTopicObjectiveRelaEN.topicObjectiveId) > 8) {
            throw new Error("(errid:Watl000059)字段[客观Id(topicObjectiveId)]的长度不能超过8(In 论文客观关系表(gs_PTopicObjectiveRela))!值:$(pobjgs_PTopicObjectiveRelaEN.topicObjectiveId)(clsgs_PTopicObjectiveRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PTopicObjectiveRelaEN.updDate) == false && (0, clsString_js_1.GetStrLen)(pobjgs_PTopicObjectiveRelaEN.updDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 论文客观关系表(gs_PTopicObjectiveRela))!值:$(pobjgs_PTopicObjectiveRelaEN.updDate)(clsgs_PTopicObjectiveRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PTopicObjectiveRelaEN.updUser) == false && (0, clsString_js_1.GetStrLen)(pobjgs_PTopicObjectiveRelaEN.updUser) > 20) {
            throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 论文客观关系表(gs_PTopicObjectiveRela))!值:$(pobjgs_PTopicObjectiveRelaEN.updUser)(clsgs_PTopicObjectiveRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PTopicObjectiveRelaEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjgs_PTopicObjectiveRelaEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 论文客观关系表(gs_PTopicObjectiveRela))!值:$(pobjgs_PTopicObjectiveRelaEN.memo)(clsgs_PTopicObjectiveRelaBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if (null != pobjgs_PTopicObjectiveRelaEN.mId && undefined !== pobjgs_PTopicObjectiveRelaEN.mId && jsString_js_1.tzDataType.isNumber(pobjgs_PTopicObjectiveRelaEN.mId) === false) {
            throw new Error("(errid:Watl000060)字段[mId(mId)]的值:[$(pobjgs_PTopicObjectiveRelaEN.mId)], 非法，应该为数值型(In 论文客观关系表(gs_PTopicObjectiveRela))!(clsgs_PTopicObjectiveRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PTopicObjectiveRelaEN.paperId) == false && undefined !== pobjgs_PTopicObjectiveRelaEN.paperId && jsString_js_1.tzDataType.isString(pobjgs_PTopicObjectiveRelaEN.paperId) === false) {
            throw new Error("(errid:Watl000060)字段[论文Id(paperId)]的值:[$(pobjgs_PTopicObjectiveRelaEN.paperId)], 非法，应该为字符型(In 论文客观关系表(gs_PTopicObjectiveRela))!(clsgs_PTopicObjectiveRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PTopicObjectiveRelaEN.sectionId) == false && undefined !== pobjgs_PTopicObjectiveRelaEN.sectionId && jsString_js_1.tzDataType.isString(pobjgs_PTopicObjectiveRelaEN.sectionId) === false) {
            throw new Error("(errid:Watl000060)字段[节Id(sectionId)]的值:[$(pobjgs_PTopicObjectiveRelaEN.sectionId)], 非法，应该为字符型(In 论文客观关系表(gs_PTopicObjectiveRela))!(clsgs_PTopicObjectiveRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PTopicObjectiveRelaEN.topicObjectiveId) == false && undefined !== pobjgs_PTopicObjectiveRelaEN.topicObjectiveId && jsString_js_1.tzDataType.isString(pobjgs_PTopicObjectiveRelaEN.topicObjectiveId) === false) {
            throw new Error("(errid:Watl000060)字段[客观Id(topicObjectiveId)]的值:[$(pobjgs_PTopicObjectiveRelaEN.topicObjectiveId)], 非法，应该为字符型(In 论文客观关系表(gs_PTopicObjectiveRela))!(clsgs_PTopicObjectiveRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PTopicObjectiveRelaEN.updDate) == false && undefined !== pobjgs_PTopicObjectiveRelaEN.updDate && jsString_js_1.tzDataType.isString(pobjgs_PTopicObjectiveRelaEN.updDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjgs_PTopicObjectiveRelaEN.updDate)], 非法，应该为字符型(In 论文客观关系表(gs_PTopicObjectiveRela))!(clsgs_PTopicObjectiveRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PTopicObjectiveRelaEN.updUser) == false && undefined !== pobjgs_PTopicObjectiveRelaEN.updUser && jsString_js_1.tzDataType.isString(pobjgs_PTopicObjectiveRelaEN.updUser) === false) {
            throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjgs_PTopicObjectiveRelaEN.updUser)], 非法，应该为字符型(In 论文客观关系表(gs_PTopicObjectiveRela))!(clsgs_PTopicObjectiveRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PTopicObjectiveRelaEN.memo) == false && undefined !== pobjgs_PTopicObjectiveRelaEN.memo && jsString_js_1.tzDataType.isString(pobjgs_PTopicObjectiveRelaEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjgs_PTopicObjectiveRelaEN.memo)], 非法，应该为字符型(In 论文客观关系表(gs_PTopicObjectiveRela))!(clsgs_PTopicObjectiveRelaBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjgs_PTopicObjectiveRelaEN.SetIsCheckProperty(true);
    }
    exports.gs_PTopicObjectiveRela_CheckPropertyNew = gs_PTopicObjectiveRela_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function gs_PTopicObjectiveRela_CheckProperty4Update(pobjgs_PTopicObjectiveRelaEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PTopicObjectiveRelaEN.paperId) == false && (0, clsString_js_1.GetStrLen)(pobjgs_PTopicObjectiveRelaEN.paperId) > 8) {
            throw new Error("(errid:Watl000062)字段[论文Id(paperId)]的长度不能超过8(In 论文客观关系表(gs_PTopicObjectiveRela))!值:$(pobjgs_PTopicObjectiveRelaEN.paperId)(clsgs_PTopicObjectiveRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PTopicObjectiveRelaEN.sectionId) == false && (0, clsString_js_1.GetStrLen)(pobjgs_PTopicObjectiveRelaEN.sectionId) > 8) {
            throw new Error("(errid:Watl000062)字段[节Id(sectionId)]的长度不能超过8(In 论文客观关系表(gs_PTopicObjectiveRela))!值:$(pobjgs_PTopicObjectiveRelaEN.sectionId)(clsgs_PTopicObjectiveRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PTopicObjectiveRelaEN.topicObjectiveId) == false && (0, clsString_js_1.GetStrLen)(pobjgs_PTopicObjectiveRelaEN.topicObjectiveId) > 8) {
            throw new Error("(errid:Watl000062)字段[客观Id(topicObjectiveId)]的长度不能超过8(In 论文客观关系表(gs_PTopicObjectiveRela))!值:$(pobjgs_PTopicObjectiveRelaEN.topicObjectiveId)(clsgs_PTopicObjectiveRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PTopicObjectiveRelaEN.updDate) == false && (0, clsString_js_1.GetStrLen)(pobjgs_PTopicObjectiveRelaEN.updDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 论文客观关系表(gs_PTopicObjectiveRela))!值:$(pobjgs_PTopicObjectiveRelaEN.updDate)(clsgs_PTopicObjectiveRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PTopicObjectiveRelaEN.updUser) == false && (0, clsString_js_1.GetStrLen)(pobjgs_PTopicObjectiveRelaEN.updUser) > 20) {
            throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 论文客观关系表(gs_PTopicObjectiveRela))!值:$(pobjgs_PTopicObjectiveRelaEN.updUser)(clsgs_PTopicObjectiveRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PTopicObjectiveRelaEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjgs_PTopicObjectiveRelaEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 论文客观关系表(gs_PTopicObjectiveRela))!值:$(pobjgs_PTopicObjectiveRelaEN.memo)(clsgs_PTopicObjectiveRelaBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if (null != pobjgs_PTopicObjectiveRelaEN.mId && undefined !== pobjgs_PTopicObjectiveRelaEN.mId && jsString_js_1.tzDataType.isNumber(pobjgs_PTopicObjectiveRelaEN.mId) === false) {
            throw new Error("(errid:Watl000063)字段[mId(mId)]的值:[$(pobjgs_PTopicObjectiveRelaEN.mId)], 非法，应该为数值型(In 论文客观关系表(gs_PTopicObjectiveRela))!(clsgs_PTopicObjectiveRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PTopicObjectiveRelaEN.paperId) == false && undefined !== pobjgs_PTopicObjectiveRelaEN.paperId && jsString_js_1.tzDataType.isString(pobjgs_PTopicObjectiveRelaEN.paperId) === false) {
            throw new Error("(errid:Watl000063)字段[论文Id(paperId)]的值:[$(pobjgs_PTopicObjectiveRelaEN.paperId)], 非法，应该为字符型(In 论文客观关系表(gs_PTopicObjectiveRela))!(clsgs_PTopicObjectiveRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PTopicObjectiveRelaEN.sectionId) == false && undefined !== pobjgs_PTopicObjectiveRelaEN.sectionId && jsString_js_1.tzDataType.isString(pobjgs_PTopicObjectiveRelaEN.sectionId) === false) {
            throw new Error("(errid:Watl000063)字段[节Id(sectionId)]的值:[$(pobjgs_PTopicObjectiveRelaEN.sectionId)], 非法，应该为字符型(In 论文客观关系表(gs_PTopicObjectiveRela))!(clsgs_PTopicObjectiveRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PTopicObjectiveRelaEN.topicObjectiveId) == false && undefined !== pobjgs_PTopicObjectiveRelaEN.topicObjectiveId && jsString_js_1.tzDataType.isString(pobjgs_PTopicObjectiveRelaEN.topicObjectiveId) === false) {
            throw new Error("(errid:Watl000063)字段[客观Id(topicObjectiveId)]的值:[$(pobjgs_PTopicObjectiveRelaEN.topicObjectiveId)], 非法，应该为字符型(In 论文客观关系表(gs_PTopicObjectiveRela))!(clsgs_PTopicObjectiveRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PTopicObjectiveRelaEN.updDate) == false && undefined !== pobjgs_PTopicObjectiveRelaEN.updDate && jsString_js_1.tzDataType.isString(pobjgs_PTopicObjectiveRelaEN.updDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjgs_PTopicObjectiveRelaEN.updDate)], 非法，应该为字符型(In 论文客观关系表(gs_PTopicObjectiveRela))!(clsgs_PTopicObjectiveRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PTopicObjectiveRelaEN.updUser) == false && undefined !== pobjgs_PTopicObjectiveRelaEN.updUser && jsString_js_1.tzDataType.isString(pobjgs_PTopicObjectiveRelaEN.updUser) === false) {
            throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjgs_PTopicObjectiveRelaEN.updUser)], 非法，应该为字符型(In 论文客观关系表(gs_PTopicObjectiveRela))!(clsgs_PTopicObjectiveRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PTopicObjectiveRelaEN.memo) == false && undefined !== pobjgs_PTopicObjectiveRelaEN.memo && jsString_js_1.tzDataType.isString(pobjgs_PTopicObjectiveRelaEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjgs_PTopicObjectiveRelaEN.memo)], 非法，应该为字符型(In 论文客观关系表(gs_PTopicObjectiveRela))!(clsgs_PTopicObjectiveRelaBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if (null === pobjgs_PTopicObjectiveRelaEN.mId
            || pobjgs_PTopicObjectiveRelaEN.mId != null && pobjgs_PTopicObjectiveRelaEN.mId.toString() === "") {
            throw new Error("(errid:Watl000064)字段[mId]不能为空(In 论文客观关系表)!(clsgs_PTopicObjectiveRelaBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjgs_PTopicObjectiveRelaEN.SetIsCheckProperty(true);
    }
    exports.gs_PTopicObjectiveRela_CheckProperty4Update = gs_PTopicObjectiveRela_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function gs_PTopicObjectiveRela_GetJSONStrByObj(pobjgs_PTopicObjectiveRelaEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjgs_PTopicObjectiveRelaEN.sf_UpdFldSetStr = pobjgs_PTopicObjectiveRelaEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjgs_PTopicObjectiveRelaEN);
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
    exports.gs_PTopicObjectiveRela_GetJSONStrByObj = gs_PTopicObjectiveRela_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function gs_PTopicObjectiveRela_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrgs_PTopicObjectiveRelaObjLst = new Array();
        if (strJSON === "") {
            return arrgs_PTopicObjectiveRelaObjLst;
        }
        try {
            arrgs_PTopicObjectiveRelaObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrgs_PTopicObjectiveRelaObjLst;
        }
        return arrgs_PTopicObjectiveRelaObjLst;
    }
    exports.gs_PTopicObjectiveRela_GetObjLstByJSONStr = gs_PTopicObjectiveRela_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrgs_PTopicObjectiveRelaObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function gs_PTopicObjectiveRela_GetObjLstByJSONObjLst(arrgs_PTopicObjectiveRelaObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrgs_PTopicObjectiveRelaObjLst = new Array();
        for (const objInFor of arrgs_PTopicObjectiveRelaObjLstS) {
            const obj1 = gs_PTopicObjectiveRela_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrgs_PTopicObjectiveRelaObjLst.push(obj1);
        }
        return arrgs_PTopicObjectiveRelaObjLst;
    }
    exports.gs_PTopicObjectiveRela_GetObjLstByJSONObjLst = gs_PTopicObjectiveRela_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function gs_PTopicObjectiveRela_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjgs_PTopicObjectiveRelaEN = new clsgs_PTopicObjectiveRelaEN_js_1.clsgs_PTopicObjectiveRelaEN();
        if (strJSON === "") {
            return pobjgs_PTopicObjectiveRelaEN;
        }
        try {
            pobjgs_PTopicObjectiveRelaEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjgs_PTopicObjectiveRelaEN;
        }
        return pobjgs_PTopicObjectiveRelaEN;
    }
    exports.gs_PTopicObjectiveRela_GetObjByJSONStr = gs_PTopicObjectiveRela_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function gs_PTopicObjectiveRela_GetCombineCondition(objgs_PTopicObjectiveRela_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objgs_PTopicObjectiveRela_Cond.dicFldComparisonOp, clsgs_PTopicObjectiveRelaEN_js_1.clsgs_PTopicObjectiveRelaEN.con_mId) == true) {
            const strComparisonOp_mId = objgs_PTopicObjectiveRela_Cond.dicFldComparisonOp[clsgs_PTopicObjectiveRelaEN_js_1.clsgs_PTopicObjectiveRelaEN.con_mId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsgs_PTopicObjectiveRelaEN_js_1.clsgs_PTopicObjectiveRelaEN.con_mId, objgs_PTopicObjectiveRela_Cond.mId, strComparisonOp_mId);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_PTopicObjectiveRela_Cond.dicFldComparisonOp, clsgs_PTopicObjectiveRelaEN_js_1.clsgs_PTopicObjectiveRelaEN.con_PaperId) == true) {
            const strComparisonOp_PaperId = objgs_PTopicObjectiveRela_Cond.dicFldComparisonOp[clsgs_PTopicObjectiveRelaEN_js_1.clsgs_PTopicObjectiveRelaEN.con_PaperId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_PTopicObjectiveRelaEN_js_1.clsgs_PTopicObjectiveRelaEN.con_PaperId, objgs_PTopicObjectiveRela_Cond.paperId, strComparisonOp_PaperId);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_PTopicObjectiveRela_Cond.dicFldComparisonOp, clsgs_PTopicObjectiveRelaEN_js_1.clsgs_PTopicObjectiveRelaEN.con_SectionId) == true) {
            const strComparisonOp_SectionId = objgs_PTopicObjectiveRela_Cond.dicFldComparisonOp[clsgs_PTopicObjectiveRelaEN_js_1.clsgs_PTopicObjectiveRelaEN.con_SectionId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_PTopicObjectiveRelaEN_js_1.clsgs_PTopicObjectiveRelaEN.con_SectionId, objgs_PTopicObjectiveRela_Cond.sectionId, strComparisonOp_SectionId);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_PTopicObjectiveRela_Cond.dicFldComparisonOp, clsgs_PTopicObjectiveRelaEN_js_1.clsgs_PTopicObjectiveRelaEN.con_TopicObjectiveId) == true) {
            const strComparisonOp_TopicObjectiveId = objgs_PTopicObjectiveRela_Cond.dicFldComparisonOp[clsgs_PTopicObjectiveRelaEN_js_1.clsgs_PTopicObjectiveRelaEN.con_TopicObjectiveId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_PTopicObjectiveRelaEN_js_1.clsgs_PTopicObjectiveRelaEN.con_TopicObjectiveId, objgs_PTopicObjectiveRela_Cond.topicObjectiveId, strComparisonOp_TopicObjectiveId);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_PTopicObjectiveRela_Cond.dicFldComparisonOp, clsgs_PTopicObjectiveRelaEN_js_1.clsgs_PTopicObjectiveRelaEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objgs_PTopicObjectiveRela_Cond.dicFldComparisonOp[clsgs_PTopicObjectiveRelaEN_js_1.clsgs_PTopicObjectiveRelaEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_PTopicObjectiveRelaEN_js_1.clsgs_PTopicObjectiveRelaEN.con_UpdDate, objgs_PTopicObjectiveRela_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_PTopicObjectiveRela_Cond.dicFldComparisonOp, clsgs_PTopicObjectiveRelaEN_js_1.clsgs_PTopicObjectiveRelaEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objgs_PTopicObjectiveRela_Cond.dicFldComparisonOp[clsgs_PTopicObjectiveRelaEN_js_1.clsgs_PTopicObjectiveRelaEN.con_UpdUser];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_PTopicObjectiveRelaEN_js_1.clsgs_PTopicObjectiveRelaEN.con_UpdUser, objgs_PTopicObjectiveRela_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_PTopicObjectiveRela_Cond.dicFldComparisonOp, clsgs_PTopicObjectiveRelaEN_js_1.clsgs_PTopicObjectiveRelaEN.con_Memo) == true) {
            const strComparisonOp_Memo = objgs_PTopicObjectiveRela_Cond.dicFldComparisonOp[clsgs_PTopicObjectiveRelaEN_js_1.clsgs_PTopicObjectiveRelaEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_PTopicObjectiveRelaEN_js_1.clsgs_PTopicObjectiveRelaEN.con_Memo, objgs_PTopicObjectiveRela_Cond.memo, strComparisonOp_Memo);
        }
        return strWhereCond;
    }
    exports.gs_PTopicObjectiveRela_GetCombineCondition = gs_PTopicObjectiveRela_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--gs_PTopicObjectiveRela(论文客观关系表),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param lngmId: mId(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function gs_PTopicObjectiveRela_GetUniCondStr_mId(objgs_PTopicObjectiveRelaEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and mId = '{0}'", objgs_PTopicObjectiveRelaEN.mId);
        return strWhereCond;
    }
    exports.gs_PTopicObjectiveRela_GetUniCondStr_mId = gs_PTopicObjectiveRela_GetUniCondStr_mId;
    /**
    *获取唯一性条件串(Uniqueness)--gs_PTopicObjectiveRela(论文客观关系表),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param lngmId: mId(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function gs_PTopicObjectiveRela_GetUniCondStr4Update_mId(objgs_PTopicObjectiveRelaEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and mId <> '{0}'", objgs_PTopicObjectiveRelaEN.mId);
        strWhereCond += (0, clsString_js_1.Format)(" and mId = '{0}'", objgs_PTopicObjectiveRelaEN.mId);
        return strWhereCond;
    }
    exports.gs_PTopicObjectiveRela_GetUniCondStr4Update_mId = gs_PTopicObjectiveRela_GetUniCondStr4Update_mId;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objgs_PTopicObjectiveRelaENS:源对象
     * @param objgs_PTopicObjectiveRelaENT:目标对象
    */
    function gs_PTopicObjectiveRela_CopyObjTo(objgs_PTopicObjectiveRelaENS, objgs_PTopicObjectiveRelaENT) {
        objgs_PTopicObjectiveRelaENT.mId = objgs_PTopicObjectiveRelaENS.mId; //mId
        objgs_PTopicObjectiveRelaENT.paperId = objgs_PTopicObjectiveRelaENS.paperId; //论文Id
        objgs_PTopicObjectiveRelaENT.sectionId = objgs_PTopicObjectiveRelaENS.sectionId; //节Id
        objgs_PTopicObjectiveRelaENT.topicObjectiveId = objgs_PTopicObjectiveRelaENS.topicObjectiveId; //客观Id
        objgs_PTopicObjectiveRelaENT.updDate = objgs_PTopicObjectiveRelaENS.updDate; //修改日期
        objgs_PTopicObjectiveRelaENT.updUser = objgs_PTopicObjectiveRelaENS.updUser; //修改人
        objgs_PTopicObjectiveRelaENT.memo = objgs_PTopicObjectiveRelaENS.memo; //备注
        objgs_PTopicObjectiveRelaENT.sf_UpdFldSetStr = objgs_PTopicObjectiveRelaENS.updFldString; //sf_UpdFldSetStr
    }
    exports.gs_PTopicObjectiveRela_CopyObjTo = gs_PTopicObjectiveRela_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objgs_PTopicObjectiveRelaENS:源对象
     * @param objgs_PTopicObjectiveRelaENT:目标对象
    */
    function gs_PTopicObjectiveRela_GetObjFromJsonObj(objgs_PTopicObjectiveRelaENS) {
        const objgs_PTopicObjectiveRelaENT = new clsgs_PTopicObjectiveRelaEN_js_1.clsgs_PTopicObjectiveRelaEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objgs_PTopicObjectiveRelaENT, objgs_PTopicObjectiveRelaENS);
        return objgs_PTopicObjectiveRelaENT;
    }
    exports.gs_PTopicObjectiveRela_GetObjFromJsonObj = gs_PTopicObjectiveRela_GetObjFromJsonObj;
});
