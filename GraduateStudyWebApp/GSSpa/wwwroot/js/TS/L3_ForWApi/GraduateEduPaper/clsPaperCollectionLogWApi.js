/**
* 类名:clsPaperCollectionLogWApi
* 表名:PaperCollectionLog(01120565)
* 生成代码版本:2022.11.02.1
* 生成日期:2022/11/02 11:46:47
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
        define(["require", "exports", "axios", "../../L0_Entity/GraduateEduPaper/clsPaperCollectionLogEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsSysPara4WebApi.js", "../../PubFun/jsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.PaperCollectionLog_GetObjFromJsonObj = exports.PaperCollectionLog_CopyObjTo = exports.PaperCollectionLog_GetUniCondStr4Update_PaperCollectionLogId = exports.PaperCollectionLog_GetUniCondStr_PaperCollectionLogId = exports.PaperCollectionLog_GetCombineCondition = exports.PaperCollectionLog_GetObjByJSONStr = exports.PaperCollectionLog_GetObjLstByJSONObjLst = exports.PaperCollectionLog_GetObjLstByJSONStr = exports.PaperCollectionLog_GetJSONStrByObj = exports.PaperCollectionLog_CheckProperty4Update = exports.PaperCollectionLog_CheckPropertyNew = exports.PaperCollectionLog_GetWebApiUrl = exports.PaperCollectionLog_GetMaxStrIdByPrefix = exports.PaperCollectionLog_GetRecCountByCondAsync = exports.PaperCollectionLog_IsExistAsync = exports.PaperCollectionLog_IsExist = exports.PaperCollectionLog_IsExistRecordAsync = exports.PaperCollectionLog_UpdateWithConditionAsync = exports.PaperCollectionLog_UpdateRecordAsync = exports.PaperCollectionLog_AddNewRecordWithReturnKey = exports.PaperCollectionLog_AddNewRecordWithReturnKeyAsync = exports.PaperCollectionLog_AddNewRecordAsync = exports.PaperCollectionLog_DelPaperCollectionLogsByCondAsync = exports.PaperCollectionLog_DelPaperCollectionLogsAsync = exports.PaperCollectionLog_DelRecordAsync = exports.PaperCollectionLog_GetObjLstByPagerAsync = exports.PaperCollectionLog_GetObjLstByRange = exports.PaperCollectionLog_GetObjLstByRangeAsync = exports.PaperCollectionLog_GetTopObjLstAsync = exports.PaperCollectionLog_GetObjLstByPaperCollectionLogIdLstAsync = exports.PaperCollectionLog_GetObjLstAsync = exports.PaperCollectionLog_GetFirstObjAsync = exports.PaperCollectionLog_GetFirstID = exports.PaperCollectionLog_GetFirstIDAsync = exports.PaperCollectionLog_FilterFunByKey = exports.PaperCollectionLog_SortFunByKey = exports.PaperCollectionLog_SortFun_Defa_2Fld = exports.PaperCollectionLog_SortFun_Defa = exports.PaperCollectionLog_GetObjByPaperCollectionLogIdAsync = exports.paperCollectionLog_ConstructorName = exports.paperCollectionLog_Controller = void 0;
    /**
     * 论文收藏(PaperCollectionLog)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2022年11月02日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const clsPaperCollectionLogEN_js_1 = require("../../L0_Entity/GraduateEduPaper/clsPaperCollectionLogEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    const jsString_js_1 = require("../../PubFun/jsString.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.paperCollectionLog_Controller = "PaperCollectionLogApi";
    exports.paperCollectionLog_ConstructorName = "paperCollectionLog";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param lngPaperCollectionLogId:关键字
    * @returns 对象
    **/
    async function PaperCollectionLog_GetObjByPaperCollectionLogIdAsync(lngPaperCollectionLogId) {
        const strThisFuncName = "GetObjByPaperCollectionLogIdAsync";
        if (lngPaperCollectionLogId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngPaperCollectionLogId]不能为空！(In GetObjByPaperCollectionLogIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByPaperCollectionLogId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperCollectionLog_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "lngPaperCollectionLogId": lngPaperCollectionLogId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.paperCollectionLog_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objPaperCollectionLog = PaperCollectionLog_GetObjFromJsonObj(returnObj);
                return objPaperCollectionLog;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperCollectionLog_GetObjByPaperCollectionLogIdAsync = PaperCollectionLog_GetObjByPaperCollectionLogIdAsync;
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
    function PaperCollectionLog_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.paperCollectionLogId - b.paperCollectionLogId;
    }
    exports.PaperCollectionLog_SortFun_Defa = PaperCollectionLog_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function PaperCollectionLog_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.paperId == b.paperId)
            return a.updUser.localeCompare(b.updUser);
        else
            return a.paperId.localeCompare(b.paperId);
    }
    exports.PaperCollectionLog_SortFun_Defa_2Fld = PaperCollectionLog_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function PaperCollectionLog_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsPaperCollectionLogEN_js_1.clsPaperCollectionLogEN.con_PaperCollectionLogId:
                    return (a, b) => {
                        return a.paperCollectionLogId - b.paperCollectionLogId;
                    };
                case clsPaperCollectionLogEN_js_1.clsPaperCollectionLogEN.con_PaperId:
                    return (a, b) => {
                        return a.paperId.localeCompare(b.paperId);
                    };
                case clsPaperCollectionLogEN_js_1.clsPaperCollectionLogEN.con_UpdUser:
                    return (a, b) => {
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsPaperCollectionLogEN_js_1.clsPaperCollectionLogEN.con_UpdDate:
                    return (a, b) => {
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsPaperCollectionLogEN_js_1.clsPaperCollectionLogEN.con_Meno:
                    return (a, b) => {
                        return a.meno.localeCompare(b.meno);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[PaperCollectionLog]中不存在！(in ${exports.paperCollectionLog_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsPaperCollectionLogEN_js_1.clsPaperCollectionLogEN.con_PaperCollectionLogId:
                    return (a, b) => {
                        return b.paperCollectionLogId - a.paperCollectionLogId;
                    };
                case clsPaperCollectionLogEN_js_1.clsPaperCollectionLogEN.con_PaperId:
                    return (a, b) => {
                        return b.paperId.localeCompare(a.paperId);
                    };
                case clsPaperCollectionLogEN_js_1.clsPaperCollectionLogEN.con_UpdUser:
                    return (a, b) => {
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsPaperCollectionLogEN_js_1.clsPaperCollectionLogEN.con_UpdDate:
                    return (a, b) => {
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsPaperCollectionLogEN_js_1.clsPaperCollectionLogEN.con_Meno:
                    return (a, b) => {
                        return b.meno.localeCompare(a.meno);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[PaperCollectionLog]中不存在！(in ${exports.paperCollectionLog_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.PaperCollectionLog_SortFunByKey = PaperCollectionLog_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function PaperCollectionLog_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsPaperCollectionLogEN_js_1.clsPaperCollectionLogEN.con_PaperCollectionLogId:
                return (obj) => {
                    return obj.paperCollectionLogId === value;
                };
            case clsPaperCollectionLogEN_js_1.clsPaperCollectionLogEN.con_PaperId:
                return (obj) => {
                    return obj.paperId === value;
                };
            case clsPaperCollectionLogEN_js_1.clsPaperCollectionLogEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsPaperCollectionLogEN_js_1.clsPaperCollectionLogEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsPaperCollectionLogEN_js_1.clsPaperCollectionLogEN.con_Meno:
                return (obj) => {
                    return obj.meno === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[PaperCollectionLog]中不存在！(in ${exports.paperCollectionLog_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.PaperCollectionLog_FilterFunByKey = PaperCollectionLog_FilterFunByKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function PaperCollectionLog_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperCollectionLog_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperCollectionLog_GetFirstIDAsync = PaperCollectionLog_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function PaperCollectionLog_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperCollectionLog_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperCollectionLog_GetFirstID = PaperCollectionLog_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function PaperCollectionLog_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperCollectionLog_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.paperCollectionLog_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objPaperCollectionLog = PaperCollectionLog_GetObjFromJsonObj(returnObj);
                return objPaperCollectionLog;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperCollectionLog_GetFirstObjAsync = PaperCollectionLog_GetFirstObjAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function PaperCollectionLog_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperCollectionLog_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.paperCollectionLog_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = PaperCollectionLog_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperCollectionLog_GetObjLstAsync = PaperCollectionLog_GetObjLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrPaperCollectionLogId:关键字列表
    * @returns 对象列表
    **/
    async function PaperCollectionLog_GetObjLstByPaperCollectionLogIdLstAsync(arrPaperCollectionLogId) {
        const strThisFuncName = "GetObjLstByPaperCollectionLogIdLstAsync";
        const strAction = "GetObjLstByPaperCollectionLogIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperCollectionLog_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrPaperCollectionLogId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.paperCollectionLog_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = PaperCollectionLog_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperCollectionLog_GetObjLstByPaperCollectionLogIdLstAsync = PaperCollectionLog_GetObjLstByPaperCollectionLogIdLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function PaperCollectionLog_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperCollectionLog_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.paperCollectionLog_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = PaperCollectionLog_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperCollectionLog_GetTopObjLstAsync = PaperCollectionLog_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function PaperCollectionLog_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperCollectionLog_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.paperCollectionLog_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = PaperCollectionLog_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperCollectionLog_GetObjLstByRangeAsync = PaperCollectionLog_GetObjLstByRangeAsync;
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
    async function PaperCollectionLog_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperCollectionLog_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperCollectionLog_GetObjLstByRange = PaperCollectionLog_GetObjLstByRange;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function PaperCollectionLog_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperCollectionLog_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.paperCollectionLog_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = PaperCollectionLog_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperCollectionLog_GetObjLstByPagerAsync = PaperCollectionLog_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param lngPaperCollectionLogId:关键字
    * @returns 获取删除的结果
    **/
    async function PaperCollectionLog_DelRecordAsync(lngPaperCollectionLogId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperCollectionLog_Controller, strAction);
        strUrl = (0, clsString_js_1.Format)("{0}/?Id={1}", strUrl, lngPaperCollectionLogId);
        try {
            const response = await axios_1.default.delete(strUrl, {
                params: { "Id": lngPaperCollectionLogId, }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperCollectionLog_DelRecordAsync = PaperCollectionLog_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrPaperCollectionLogId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function PaperCollectionLog_DelPaperCollectionLogsAsync(arrPaperCollectionLogId) {
        const strThisFuncName = "DelPaperCollectionLogsAsync";
        const strAction = "DelPaperCollectionLogs";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperCollectionLog_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrPaperCollectionLogId);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperCollectionLog_DelPaperCollectionLogsAsync = PaperCollectionLog_DelPaperCollectionLogsAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function PaperCollectionLog_DelPaperCollectionLogsByCondAsync(strWhereCond) {
        const strThisFuncName = "DelPaperCollectionLogsByCondAsync";
        const strAction = "DelPaperCollectionLogsByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperCollectionLog_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperCollectionLog_DelPaperCollectionLogsByCondAsync = PaperCollectionLog_DelPaperCollectionLogsByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objPaperCollectionLogEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function PaperCollectionLog_AddNewRecordAsync(objPaperCollectionLogEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objPaperCollectionLogEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperCollectionLog_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPaperCollectionLogEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperCollectionLog_AddNewRecordAsync = PaperCollectionLog_AddNewRecordAsync;
    /* 数据类型不是字符型，不可以最大关键字的方式添加记录。*/
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objPaperCollectionLogEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function PaperCollectionLog_AddNewRecordWithReturnKeyAsync(objPaperCollectionLogEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperCollectionLog_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPaperCollectionLogEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperCollectionLog_AddNewRecordWithReturnKeyAsync = PaperCollectionLog_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objPaperCollectionLogEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function PaperCollectionLog_AddNewRecordWithReturnKey(objPaperCollectionLogEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objPaperCollectionLogEN.paperCollectionLogId === null || objPaperCollectionLogEN.paperCollectionLogId === 0) {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperCollectionLog_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPaperCollectionLogEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperCollectionLog_AddNewRecordWithReturnKey = PaperCollectionLog_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objPaperCollectionLogEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function PaperCollectionLog_UpdateRecordAsync(objPaperCollectionLogEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objPaperCollectionLogEN.sf_UpdFldSetStr === undefined || objPaperCollectionLogEN.sf_UpdFldSetStr === null || objPaperCollectionLogEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objPaperCollectionLogEN.paperCollectionLogId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperCollectionLog_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPaperCollectionLogEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperCollectionLog_UpdateRecordAsync = PaperCollectionLog_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objPaperCollectionLogEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function PaperCollectionLog_UpdateWithConditionAsync(objPaperCollectionLogEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objPaperCollectionLogEN.sf_UpdFldSetStr === undefined || objPaperCollectionLogEN.sf_UpdFldSetStr === null || objPaperCollectionLogEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objPaperCollectionLogEN.paperCollectionLogId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperCollectionLog_Controller, strAction);
        objPaperCollectionLogEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objPaperCollectionLogEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperCollectionLog_UpdateWithConditionAsync = PaperCollectionLog_UpdateWithConditionAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function PaperCollectionLog_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperCollectionLog_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperCollectionLog_IsExistRecordAsync = PaperCollectionLog_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param lngPaperCollectionLogId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function PaperCollectionLog_IsExist(lngPaperCollectionLogId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperCollectionLog_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "PaperCollectionLogId": lngPaperCollectionLogId,
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperCollectionLog_IsExist = PaperCollectionLog_IsExist;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param lngPaperCollectionLogId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function PaperCollectionLog_IsExistAsync(lngPaperCollectionLogId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperCollectionLog_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "lngPaperCollectionLogId": lngPaperCollectionLogId }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperCollectionLog_IsExistAsync = PaperCollectionLog_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function PaperCollectionLog_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperCollectionLog_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperCollectionLog_GetRecCountByCondAsync = PaperCollectionLog_GetRecCountByCondAsync;
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
    async function PaperCollectionLog_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperCollectionLog_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperCollectionLog_GetMaxStrIdByPrefix = PaperCollectionLog_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function PaperCollectionLog_GetWebApiUrl(strController, strAction) {
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
    exports.PaperCollectionLog_GetWebApiUrl = PaperCollectionLog_GetWebApiUrl;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function PaperCollectionLog_CheckPropertyNew(pobjPaperCollectionLogEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperCollectionLogEN.updUser) === true) {
            throw new Error("(errid:Watl000058)字段[修改人]不能为空(In 论文收藏)!(clsPaperCollectionLogBL:CheckPropertyNew)");
        }
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperCollectionLogEN.paperId) == false && (0, clsString_js_1.GetStrLen)(pobjPaperCollectionLogEN.paperId) > 8) {
            throw new Error("(errid:Watl000059)字段[论文Id(paperId)]的长度不能超过8(In 论文收藏(PaperCollectionLog))!值:$(pobjPaperCollectionLogEN.paperId)(clsPaperCollectionLogBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperCollectionLogEN.updUser) == false && (0, clsString_js_1.GetStrLen)(pobjPaperCollectionLogEN.updUser) > 20) {
            throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 论文收藏(PaperCollectionLog))!值:$(pobjPaperCollectionLogEN.updUser)(clsPaperCollectionLogBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperCollectionLogEN.updDate) == false && (0, clsString_js_1.GetStrLen)(pobjPaperCollectionLogEN.updDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 论文收藏(PaperCollectionLog))!值:$(pobjPaperCollectionLogEN.updDate)(clsPaperCollectionLogBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperCollectionLogEN.meno) == false && (0, clsString_js_1.GetStrLen)(pobjPaperCollectionLogEN.meno) > 2000) {
            throw new Error("(errid:Watl000059)字段[备注(meno)]的长度不能超过2000(In 论文收藏(PaperCollectionLog))!值:$(pobjPaperCollectionLogEN.meno)(clsPaperCollectionLogBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if (null != pobjPaperCollectionLogEN.paperCollectionLogId && undefined !== pobjPaperCollectionLogEN.paperCollectionLogId && jsString_js_1.tzDataType.isNumber(pobjPaperCollectionLogEN.paperCollectionLogId) === false) {
            throw new Error("(errid:Watl000060)字段[论文收藏Id(paperCollectionLogId)]的值:[$(pobjPaperCollectionLogEN.paperCollectionLogId)], 非法，应该为数值型(In 论文收藏(PaperCollectionLog))!(clsPaperCollectionLogBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperCollectionLogEN.paperId) == false && undefined !== pobjPaperCollectionLogEN.paperId && jsString_js_1.tzDataType.isString(pobjPaperCollectionLogEN.paperId) === false) {
            throw new Error("(errid:Watl000060)字段[论文Id(paperId)]的值:[$(pobjPaperCollectionLogEN.paperId)], 非法，应该为字符型(In 论文收藏(PaperCollectionLog))!(clsPaperCollectionLogBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperCollectionLogEN.updUser) == false && undefined !== pobjPaperCollectionLogEN.updUser && jsString_js_1.tzDataType.isString(pobjPaperCollectionLogEN.updUser) === false) {
            throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjPaperCollectionLogEN.updUser)], 非法，应该为字符型(In 论文收藏(PaperCollectionLog))!(clsPaperCollectionLogBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperCollectionLogEN.updDate) == false && undefined !== pobjPaperCollectionLogEN.updDate && jsString_js_1.tzDataType.isString(pobjPaperCollectionLogEN.updDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjPaperCollectionLogEN.updDate)], 非法，应该为字符型(In 论文收藏(PaperCollectionLog))!(clsPaperCollectionLogBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperCollectionLogEN.meno) == false && undefined !== pobjPaperCollectionLogEN.meno && jsString_js_1.tzDataType.isString(pobjPaperCollectionLogEN.meno) === false) {
            throw new Error("(errid:Watl000060)字段[备注(meno)]的值:[$(pobjPaperCollectionLogEN.meno)], 非法，应该为字符型(In 论文收藏(PaperCollectionLog))!(clsPaperCollectionLogBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjPaperCollectionLogEN.SetIsCheckProperty(true);
    }
    exports.PaperCollectionLog_CheckPropertyNew = PaperCollectionLog_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function PaperCollectionLog_CheckProperty4Update(pobjPaperCollectionLogEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperCollectionLogEN.paperId) == false && (0, clsString_js_1.GetStrLen)(pobjPaperCollectionLogEN.paperId) > 8) {
            throw new Error("(errid:Watl000062)字段[论文Id(paperId)]的长度不能超过8(In 论文收藏(PaperCollectionLog))!值:$(pobjPaperCollectionLogEN.paperId)(clsPaperCollectionLogBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperCollectionLogEN.updUser) == false && (0, clsString_js_1.GetStrLen)(pobjPaperCollectionLogEN.updUser) > 20) {
            throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 论文收藏(PaperCollectionLog))!值:$(pobjPaperCollectionLogEN.updUser)(clsPaperCollectionLogBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperCollectionLogEN.updDate) == false && (0, clsString_js_1.GetStrLen)(pobjPaperCollectionLogEN.updDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 论文收藏(PaperCollectionLog))!值:$(pobjPaperCollectionLogEN.updDate)(clsPaperCollectionLogBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperCollectionLogEN.meno) == false && (0, clsString_js_1.GetStrLen)(pobjPaperCollectionLogEN.meno) > 2000) {
            throw new Error("(errid:Watl000062)字段[备注(meno)]的长度不能超过2000(In 论文收藏(PaperCollectionLog))!值:$(pobjPaperCollectionLogEN.meno)(clsPaperCollectionLogBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if (null != pobjPaperCollectionLogEN.paperCollectionLogId && undefined !== pobjPaperCollectionLogEN.paperCollectionLogId && jsString_js_1.tzDataType.isNumber(pobjPaperCollectionLogEN.paperCollectionLogId) === false) {
            throw new Error("(errid:Watl000063)字段[论文收藏Id(paperCollectionLogId)]的值:[$(pobjPaperCollectionLogEN.paperCollectionLogId)], 非法，应该为数值型(In 论文收藏(PaperCollectionLog))!(clsPaperCollectionLogBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperCollectionLogEN.paperId) == false && undefined !== pobjPaperCollectionLogEN.paperId && jsString_js_1.tzDataType.isString(pobjPaperCollectionLogEN.paperId) === false) {
            throw new Error("(errid:Watl000063)字段[论文Id(paperId)]的值:[$(pobjPaperCollectionLogEN.paperId)], 非法，应该为字符型(In 论文收藏(PaperCollectionLog))!(clsPaperCollectionLogBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperCollectionLogEN.updUser) == false && undefined !== pobjPaperCollectionLogEN.updUser && jsString_js_1.tzDataType.isString(pobjPaperCollectionLogEN.updUser) === false) {
            throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjPaperCollectionLogEN.updUser)], 非法，应该为字符型(In 论文收藏(PaperCollectionLog))!(clsPaperCollectionLogBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperCollectionLogEN.updDate) == false && undefined !== pobjPaperCollectionLogEN.updDate && jsString_js_1.tzDataType.isString(pobjPaperCollectionLogEN.updDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjPaperCollectionLogEN.updDate)], 非法，应该为字符型(In 论文收藏(PaperCollectionLog))!(clsPaperCollectionLogBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperCollectionLogEN.meno) == false && undefined !== pobjPaperCollectionLogEN.meno && jsString_js_1.tzDataType.isString(pobjPaperCollectionLogEN.meno) === false) {
            throw new Error("(errid:Watl000063)字段[备注(meno)]的值:[$(pobjPaperCollectionLogEN.meno)], 非法，应该为字符型(In 论文收藏(PaperCollectionLog))!(clsPaperCollectionLogBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if (null === pobjPaperCollectionLogEN.paperCollectionLogId
            || pobjPaperCollectionLogEN.paperCollectionLogId != null && pobjPaperCollectionLogEN.paperCollectionLogId.toString() === "") {
            throw new Error("(errid:Watl000064)字段[论文收藏Id]不能为空(In 论文收藏)!(clsPaperCollectionLogBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjPaperCollectionLogEN.SetIsCheckProperty(true);
    }
    exports.PaperCollectionLog_CheckProperty4Update = PaperCollectionLog_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function PaperCollectionLog_GetJSONStrByObj(pobjPaperCollectionLogEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjPaperCollectionLogEN.sf_UpdFldSetStr = pobjPaperCollectionLogEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjPaperCollectionLogEN);
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
    exports.PaperCollectionLog_GetJSONStrByObj = PaperCollectionLog_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function PaperCollectionLog_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrPaperCollectionLogObjLst = new Array();
        if (strJSON === "") {
            return arrPaperCollectionLogObjLst;
        }
        try {
            arrPaperCollectionLogObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrPaperCollectionLogObjLst;
        }
        return arrPaperCollectionLogObjLst;
    }
    exports.PaperCollectionLog_GetObjLstByJSONStr = PaperCollectionLog_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrPaperCollectionLogObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function PaperCollectionLog_GetObjLstByJSONObjLst(arrPaperCollectionLogObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrPaperCollectionLogObjLst = new Array();
        for (const objInFor of arrPaperCollectionLogObjLstS) {
            const obj1 = PaperCollectionLog_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrPaperCollectionLogObjLst.push(obj1);
        }
        return arrPaperCollectionLogObjLst;
    }
    exports.PaperCollectionLog_GetObjLstByJSONObjLst = PaperCollectionLog_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function PaperCollectionLog_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjPaperCollectionLogEN = new clsPaperCollectionLogEN_js_1.clsPaperCollectionLogEN();
        if (strJSON === "") {
            return pobjPaperCollectionLogEN;
        }
        try {
            pobjPaperCollectionLogEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjPaperCollectionLogEN;
        }
        return pobjPaperCollectionLogEN;
    }
    exports.PaperCollectionLog_GetObjByJSONStr = PaperCollectionLog_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function PaperCollectionLog_GetCombineCondition(objPaperCollectionLog_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objPaperCollectionLog_Cond.dicFldComparisonOp, clsPaperCollectionLogEN_js_1.clsPaperCollectionLogEN.con_PaperCollectionLogId) == true) {
            const strComparisonOp_PaperCollectionLogId = objPaperCollectionLog_Cond.dicFldComparisonOp[clsPaperCollectionLogEN_js_1.clsPaperCollectionLogEN.con_PaperCollectionLogId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsPaperCollectionLogEN_js_1.clsPaperCollectionLogEN.con_PaperCollectionLogId, objPaperCollectionLog_Cond.paperCollectionLogId, strComparisonOp_PaperCollectionLogId);
        }
        if (Object.prototype.hasOwnProperty.call(objPaperCollectionLog_Cond.dicFldComparisonOp, clsPaperCollectionLogEN_js_1.clsPaperCollectionLogEN.con_PaperId) == true) {
            const strComparisonOp_PaperId = objPaperCollectionLog_Cond.dicFldComparisonOp[clsPaperCollectionLogEN_js_1.clsPaperCollectionLogEN.con_PaperId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsPaperCollectionLogEN_js_1.clsPaperCollectionLogEN.con_PaperId, objPaperCollectionLog_Cond.paperId, strComparisonOp_PaperId);
        }
        if (Object.prototype.hasOwnProperty.call(objPaperCollectionLog_Cond.dicFldComparisonOp, clsPaperCollectionLogEN_js_1.clsPaperCollectionLogEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objPaperCollectionLog_Cond.dicFldComparisonOp[clsPaperCollectionLogEN_js_1.clsPaperCollectionLogEN.con_UpdUser];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsPaperCollectionLogEN_js_1.clsPaperCollectionLogEN.con_UpdUser, objPaperCollectionLog_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objPaperCollectionLog_Cond.dicFldComparisonOp, clsPaperCollectionLogEN_js_1.clsPaperCollectionLogEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objPaperCollectionLog_Cond.dicFldComparisonOp[clsPaperCollectionLogEN_js_1.clsPaperCollectionLogEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsPaperCollectionLogEN_js_1.clsPaperCollectionLogEN.con_UpdDate, objPaperCollectionLog_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objPaperCollectionLog_Cond.dicFldComparisonOp, clsPaperCollectionLogEN_js_1.clsPaperCollectionLogEN.con_Meno) == true) {
            const strComparisonOp_Meno = objPaperCollectionLog_Cond.dicFldComparisonOp[clsPaperCollectionLogEN_js_1.clsPaperCollectionLogEN.con_Meno];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsPaperCollectionLogEN_js_1.clsPaperCollectionLogEN.con_Meno, objPaperCollectionLog_Cond.meno, strComparisonOp_Meno);
        }
        return strWhereCond;
    }
    exports.PaperCollectionLog_GetCombineCondition = PaperCollectionLog_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--PaperCollectionLog(论文收藏),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param lngPaperCollectionLogId: 论文收藏Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function PaperCollectionLog_GetUniCondStr_PaperCollectionLogId(objPaperCollectionLogEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and PaperCollectionLogId = '{0}'", objPaperCollectionLogEN.paperCollectionLogId);
        return strWhereCond;
    }
    exports.PaperCollectionLog_GetUniCondStr_PaperCollectionLogId = PaperCollectionLog_GetUniCondStr_PaperCollectionLogId;
    /**
    *获取唯一性条件串(Uniqueness)--PaperCollectionLog(论文收藏),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param lngPaperCollectionLogId: 论文收藏Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function PaperCollectionLog_GetUniCondStr4Update_PaperCollectionLogId(objPaperCollectionLogEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and PaperCollectionLogId <> '{0}'", objPaperCollectionLogEN.paperCollectionLogId);
        strWhereCond += (0, clsString_js_1.Format)(" and PaperCollectionLogId = '{0}'", objPaperCollectionLogEN.paperCollectionLogId);
        return strWhereCond;
    }
    exports.PaperCollectionLog_GetUniCondStr4Update_PaperCollectionLogId = PaperCollectionLog_GetUniCondStr4Update_PaperCollectionLogId;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objPaperCollectionLogENS:源对象
     * @param objPaperCollectionLogENT:目标对象
    */
    function PaperCollectionLog_CopyObjTo(objPaperCollectionLogENS, objPaperCollectionLogENT) {
        objPaperCollectionLogENT.paperCollectionLogId = objPaperCollectionLogENS.paperCollectionLogId; //论文收藏Id
        objPaperCollectionLogENT.paperId = objPaperCollectionLogENS.paperId; //论文Id
        objPaperCollectionLogENT.updUser = objPaperCollectionLogENS.updUser; //修改人
        objPaperCollectionLogENT.updDate = objPaperCollectionLogENS.updDate; //修改日期
        objPaperCollectionLogENT.meno = objPaperCollectionLogENS.meno; //备注
        objPaperCollectionLogENT.sf_UpdFldSetStr = objPaperCollectionLogENS.updFldString; //sf_UpdFldSetStr
    }
    exports.PaperCollectionLog_CopyObjTo = PaperCollectionLog_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objPaperCollectionLogENS:源对象
     * @param objPaperCollectionLogENT:目标对象
    */
    function PaperCollectionLog_GetObjFromJsonObj(objPaperCollectionLogENS) {
        const objPaperCollectionLogENT = new clsPaperCollectionLogEN_js_1.clsPaperCollectionLogEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objPaperCollectionLogENT, objPaperCollectionLogENS);
        return objPaperCollectionLogENT;
    }
    exports.PaperCollectionLog_GetObjFromJsonObj = PaperCollectionLog_GetObjFromJsonObj;
});
