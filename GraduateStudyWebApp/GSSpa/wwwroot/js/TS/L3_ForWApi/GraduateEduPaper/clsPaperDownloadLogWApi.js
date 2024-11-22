/**
* 类名:clsPaperDownloadLogWApi
* 表名:PaperDownloadLog(01120571)
* 生成代码版本:2022.11.02.1
* 生成日期:2022/11/02 11:46:53
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
        define(["require", "exports", "axios", "../../L0_Entity/GraduateEduPaper/clsPaperDownloadLogEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsSysPara4WebApi.js", "../../PubFun/jsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.PaperDownloadLog_GetObjFromJsonObj = exports.PaperDownloadLog_CopyObjTo = exports.PaperDownloadLog_GetUniCondStr4Update_PaperDownloadId = exports.PaperDownloadLog_GetUniCondStr_PaperDownloadId = exports.PaperDownloadLog_GetCombineCondition = exports.PaperDownloadLog_GetObjByJSONStr = exports.PaperDownloadLog_GetObjLstByJSONObjLst = exports.PaperDownloadLog_GetObjLstByJSONStr = exports.PaperDownloadLog_GetJSONStrByObj = exports.PaperDownloadLog_CheckProperty4Update = exports.PaperDownloadLog_CheckPropertyNew = exports.PaperDownloadLog_GetWebApiUrl = exports.PaperDownloadLog_GetMaxStrIdByPrefix = exports.PaperDownloadLog_GetRecCountByCondAsync = exports.PaperDownloadLog_IsExistAsync = exports.PaperDownloadLog_IsExist = exports.PaperDownloadLog_IsExistRecordAsync = exports.PaperDownloadLog_UpdateWithConditionAsync = exports.PaperDownloadLog_UpdateRecordAsync = exports.PaperDownloadLog_AddNewRecordWithReturnKey = exports.PaperDownloadLog_AddNewRecordWithReturnKeyAsync = exports.PaperDownloadLog_AddNewRecordAsync = exports.PaperDownloadLog_DelPaperDownloadLogsByCondAsync = exports.PaperDownloadLog_DelPaperDownloadLogsAsync = exports.PaperDownloadLog_DelRecordAsync = exports.PaperDownloadLog_GetObjLstByPagerAsync = exports.PaperDownloadLog_GetObjLstByRange = exports.PaperDownloadLog_GetObjLstByRangeAsync = exports.PaperDownloadLog_GetTopObjLstAsync = exports.PaperDownloadLog_GetObjLstByPaperDownloadIdLstAsync = exports.PaperDownloadLog_GetObjLstAsync = exports.PaperDownloadLog_GetFirstObjAsync = exports.PaperDownloadLog_GetFirstID = exports.PaperDownloadLog_GetFirstIDAsync = exports.PaperDownloadLog_FilterFunByKey = exports.PaperDownloadLog_SortFunByKey = exports.PaperDownloadLog_SortFun_Defa_2Fld = exports.PaperDownloadLog_SortFun_Defa = exports.PaperDownloadLog_GetObjByPaperDownloadIdAsync = exports.paperDownloadLog_ConstructorName = exports.paperDownloadLog_Controller = void 0;
    /**
     * 论文下载记录(PaperDownloadLog)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2022年11月02日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const clsPaperDownloadLogEN_js_1 = require("../../L0_Entity/GraduateEduPaper/clsPaperDownloadLogEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    const jsString_js_1 = require("../../PubFun/jsString.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.paperDownloadLog_Controller = "PaperDownloadLogApi";
    exports.paperDownloadLog_ConstructorName = "paperDownloadLog";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param lngPaperDownloadId:关键字
    * @returns 对象
    **/
    async function PaperDownloadLog_GetObjByPaperDownloadIdAsync(lngPaperDownloadId) {
        const strThisFuncName = "GetObjByPaperDownloadIdAsync";
        if (lngPaperDownloadId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngPaperDownloadId]不能为空！(In GetObjByPaperDownloadIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByPaperDownloadId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperDownloadLog_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "lngPaperDownloadId": lngPaperDownloadId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.paperDownloadLog_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objPaperDownloadLog = PaperDownloadLog_GetObjFromJsonObj(returnObj);
                return objPaperDownloadLog;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperDownloadLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperDownloadLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperDownloadLog_GetObjByPaperDownloadIdAsync = PaperDownloadLog_GetObjByPaperDownloadIdAsync;
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
    function PaperDownloadLog_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.paperDownloadId - b.paperDownloadId;
    }
    exports.PaperDownloadLog_SortFun_Defa = PaperDownloadLog_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function PaperDownloadLog_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.downloadFile == b.downloadFile)
            return a.downloadLink.localeCompare(b.downloadLink);
        else
            return a.downloadFile.localeCompare(b.downloadFile);
    }
    exports.PaperDownloadLog_SortFun_Defa_2Fld = PaperDownloadLog_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function PaperDownloadLog_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsPaperDownloadLogEN_js_1.clsPaperDownloadLogEN.con_PaperDownloadId:
                    return (a, b) => {
                        return a.paperDownloadId - b.paperDownloadId;
                    };
                case clsPaperDownloadLogEN_js_1.clsPaperDownloadLogEN.con_DownloadFile:
                    return (a, b) => {
                        return a.downloadFile.localeCompare(b.downloadFile);
                    };
                case clsPaperDownloadLogEN_js_1.clsPaperDownloadLogEN.con_DownloadLink:
                    return (a, b) => {
                        return a.downloadLink.localeCompare(b.downloadLink);
                    };
                case clsPaperDownloadLogEN_js_1.clsPaperDownloadLogEN.con_PaperId:
                    return (a, b) => {
                        return a.paperId.localeCompare(b.paperId);
                    };
                case clsPaperDownloadLogEN_js_1.clsPaperDownloadLogEN.con_UpdUser:
                    return (a, b) => {
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsPaperDownloadLogEN_js_1.clsPaperDownloadLogEN.con_UpdDate:
                    return (a, b) => {
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsPaperDownloadLogEN_js_1.clsPaperDownloadLogEN.con_Memo:
                    return (a, b) => {
                        return a.memo.localeCompare(b.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[PaperDownloadLog]中不存在！(in ${exports.paperDownloadLog_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsPaperDownloadLogEN_js_1.clsPaperDownloadLogEN.con_PaperDownloadId:
                    return (a, b) => {
                        return b.paperDownloadId - a.paperDownloadId;
                    };
                case clsPaperDownloadLogEN_js_1.clsPaperDownloadLogEN.con_DownloadFile:
                    return (a, b) => {
                        return b.downloadFile.localeCompare(a.downloadFile);
                    };
                case clsPaperDownloadLogEN_js_1.clsPaperDownloadLogEN.con_DownloadLink:
                    return (a, b) => {
                        return b.downloadLink.localeCompare(a.downloadLink);
                    };
                case clsPaperDownloadLogEN_js_1.clsPaperDownloadLogEN.con_PaperId:
                    return (a, b) => {
                        return b.paperId.localeCompare(a.paperId);
                    };
                case clsPaperDownloadLogEN_js_1.clsPaperDownloadLogEN.con_UpdUser:
                    return (a, b) => {
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsPaperDownloadLogEN_js_1.clsPaperDownloadLogEN.con_UpdDate:
                    return (a, b) => {
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsPaperDownloadLogEN_js_1.clsPaperDownloadLogEN.con_Memo:
                    return (a, b) => {
                        return b.memo.localeCompare(a.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[PaperDownloadLog]中不存在！(in ${exports.paperDownloadLog_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.PaperDownloadLog_SortFunByKey = PaperDownloadLog_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function PaperDownloadLog_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsPaperDownloadLogEN_js_1.clsPaperDownloadLogEN.con_PaperDownloadId:
                return (obj) => {
                    return obj.paperDownloadId === value;
                };
            case clsPaperDownloadLogEN_js_1.clsPaperDownloadLogEN.con_DownloadFile:
                return (obj) => {
                    return obj.downloadFile === value;
                };
            case clsPaperDownloadLogEN_js_1.clsPaperDownloadLogEN.con_DownloadLink:
                return (obj) => {
                    return obj.downloadLink === value;
                };
            case clsPaperDownloadLogEN_js_1.clsPaperDownloadLogEN.con_PaperId:
                return (obj) => {
                    return obj.paperId === value;
                };
            case clsPaperDownloadLogEN_js_1.clsPaperDownloadLogEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsPaperDownloadLogEN_js_1.clsPaperDownloadLogEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsPaperDownloadLogEN_js_1.clsPaperDownloadLogEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[PaperDownloadLog]中不存在！(in ${exports.paperDownloadLog_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.PaperDownloadLog_FilterFunByKey = PaperDownloadLog_FilterFunByKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function PaperDownloadLog_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperDownloadLog_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperDownloadLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperDownloadLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperDownloadLog_GetFirstIDAsync = PaperDownloadLog_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function PaperDownloadLog_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperDownloadLog_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperDownloadLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperDownloadLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperDownloadLog_GetFirstID = PaperDownloadLog_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function PaperDownloadLog_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperDownloadLog_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.paperDownloadLog_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objPaperDownloadLog = PaperDownloadLog_GetObjFromJsonObj(returnObj);
                return objPaperDownloadLog;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperDownloadLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperDownloadLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperDownloadLog_GetFirstObjAsync = PaperDownloadLog_GetFirstObjAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function PaperDownloadLog_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperDownloadLog_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.paperDownloadLog_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = PaperDownloadLog_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperDownloadLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperDownloadLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperDownloadLog_GetObjLstAsync = PaperDownloadLog_GetObjLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrPaperDownloadId:关键字列表
    * @returns 对象列表
    **/
    async function PaperDownloadLog_GetObjLstByPaperDownloadIdLstAsync(arrPaperDownloadId) {
        const strThisFuncName = "GetObjLstByPaperDownloadIdLstAsync";
        const strAction = "GetObjLstByPaperDownloadIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperDownloadLog_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrPaperDownloadId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.paperDownloadLog_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = PaperDownloadLog_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperDownloadLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperDownloadLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperDownloadLog_GetObjLstByPaperDownloadIdLstAsync = PaperDownloadLog_GetObjLstByPaperDownloadIdLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function PaperDownloadLog_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperDownloadLog_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.paperDownloadLog_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = PaperDownloadLog_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperDownloadLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperDownloadLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperDownloadLog_GetTopObjLstAsync = PaperDownloadLog_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function PaperDownloadLog_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperDownloadLog_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.paperDownloadLog_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = PaperDownloadLog_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperDownloadLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperDownloadLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperDownloadLog_GetObjLstByRangeAsync = PaperDownloadLog_GetObjLstByRangeAsync;
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
    async function PaperDownloadLog_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperDownloadLog_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperDownloadLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperDownloadLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperDownloadLog_GetObjLstByRange = PaperDownloadLog_GetObjLstByRange;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function PaperDownloadLog_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperDownloadLog_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.paperDownloadLog_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = PaperDownloadLog_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperDownloadLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperDownloadLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperDownloadLog_GetObjLstByPagerAsync = PaperDownloadLog_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param lngPaperDownloadId:关键字
    * @returns 获取删除的结果
    **/
    async function PaperDownloadLog_DelRecordAsync(lngPaperDownloadId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperDownloadLog_Controller, strAction);
        strUrl = (0, clsString_js_1.Format)("{0}/?Id={1}", strUrl, lngPaperDownloadId);
        try {
            const response = await axios_1.default.delete(strUrl, {
                params: { "Id": lngPaperDownloadId, }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperDownloadLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperDownloadLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperDownloadLog_DelRecordAsync = PaperDownloadLog_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrPaperDownloadId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function PaperDownloadLog_DelPaperDownloadLogsAsync(arrPaperDownloadId) {
        const strThisFuncName = "DelPaperDownloadLogsAsync";
        const strAction = "DelPaperDownloadLogs";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperDownloadLog_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrPaperDownloadId);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperDownloadLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperDownloadLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperDownloadLog_DelPaperDownloadLogsAsync = PaperDownloadLog_DelPaperDownloadLogsAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function PaperDownloadLog_DelPaperDownloadLogsByCondAsync(strWhereCond) {
        const strThisFuncName = "DelPaperDownloadLogsByCondAsync";
        const strAction = "DelPaperDownloadLogsByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperDownloadLog_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperDownloadLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperDownloadLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperDownloadLog_DelPaperDownloadLogsByCondAsync = PaperDownloadLog_DelPaperDownloadLogsByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objPaperDownloadLogEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function PaperDownloadLog_AddNewRecordAsync(objPaperDownloadLogEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objPaperDownloadLogEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperDownloadLog_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPaperDownloadLogEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperDownloadLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperDownloadLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperDownloadLog_AddNewRecordAsync = PaperDownloadLog_AddNewRecordAsync;
    /* 数据类型不是字符型，不可以最大关键字的方式添加记录。*/
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objPaperDownloadLogEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function PaperDownloadLog_AddNewRecordWithReturnKeyAsync(objPaperDownloadLogEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperDownloadLog_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPaperDownloadLogEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperDownloadLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperDownloadLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperDownloadLog_AddNewRecordWithReturnKeyAsync = PaperDownloadLog_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objPaperDownloadLogEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function PaperDownloadLog_AddNewRecordWithReturnKey(objPaperDownloadLogEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objPaperDownloadLogEN.paperDownloadId === null || objPaperDownloadLogEN.paperDownloadId === 0) {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperDownloadLog_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPaperDownloadLogEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperDownloadLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperDownloadLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperDownloadLog_AddNewRecordWithReturnKey = PaperDownloadLog_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objPaperDownloadLogEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function PaperDownloadLog_UpdateRecordAsync(objPaperDownloadLogEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objPaperDownloadLogEN.sf_UpdFldSetStr === undefined || objPaperDownloadLogEN.sf_UpdFldSetStr === null || objPaperDownloadLogEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objPaperDownloadLogEN.paperDownloadId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperDownloadLog_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPaperDownloadLogEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperDownloadLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperDownloadLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperDownloadLog_UpdateRecordAsync = PaperDownloadLog_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objPaperDownloadLogEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function PaperDownloadLog_UpdateWithConditionAsync(objPaperDownloadLogEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objPaperDownloadLogEN.sf_UpdFldSetStr === undefined || objPaperDownloadLogEN.sf_UpdFldSetStr === null || objPaperDownloadLogEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objPaperDownloadLogEN.paperDownloadId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperDownloadLog_Controller, strAction);
        objPaperDownloadLogEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objPaperDownloadLogEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperDownloadLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperDownloadLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperDownloadLog_UpdateWithConditionAsync = PaperDownloadLog_UpdateWithConditionAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function PaperDownloadLog_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperDownloadLog_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperDownloadLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperDownloadLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperDownloadLog_IsExistRecordAsync = PaperDownloadLog_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param lngPaperDownloadId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function PaperDownloadLog_IsExist(lngPaperDownloadId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperDownloadLog_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "PaperDownloadId": lngPaperDownloadId,
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperDownloadLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperDownloadLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperDownloadLog_IsExist = PaperDownloadLog_IsExist;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param lngPaperDownloadId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function PaperDownloadLog_IsExistAsync(lngPaperDownloadId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperDownloadLog_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "lngPaperDownloadId": lngPaperDownloadId }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperDownloadLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperDownloadLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperDownloadLog_IsExistAsync = PaperDownloadLog_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function PaperDownloadLog_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperDownloadLog_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperDownloadLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperDownloadLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperDownloadLog_GetRecCountByCondAsync = PaperDownloadLog_GetRecCountByCondAsync;
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
    async function PaperDownloadLog_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperDownloadLog_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperDownloadLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperDownloadLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperDownloadLog_GetMaxStrIdByPrefix = PaperDownloadLog_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function PaperDownloadLog_GetWebApiUrl(strController, strAction) {
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
    exports.PaperDownloadLog_GetWebApiUrl = PaperDownloadLog_GetWebApiUrl;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function PaperDownloadLog_CheckPropertyNew(pobjPaperDownloadLogEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperDownloadLogEN.downloadFile) == false && (0, clsString_js_1.GetStrLen)(pobjPaperDownloadLogEN.downloadFile) > 500) {
            throw new Error("(errid:Watl000059)字段[DownloadFile(downloadFile)]的长度不能超过500(In 论文下载记录(PaperDownloadLog))!值:$(pobjPaperDownloadLogEN.downloadFile)(clsPaperDownloadLogBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperDownloadLogEN.downloadLink) == false && (0, clsString_js_1.GetStrLen)(pobjPaperDownloadLogEN.downloadLink) > 500) {
            throw new Error("(errid:Watl000059)字段[DownloadLink(downloadLink)]的长度不能超过500(In 论文下载记录(PaperDownloadLog))!值:$(pobjPaperDownloadLogEN.downloadLink)(clsPaperDownloadLogBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperDownloadLogEN.paperId) == false && (0, clsString_js_1.GetStrLen)(pobjPaperDownloadLogEN.paperId) > 8) {
            throw new Error("(errid:Watl000059)字段[论文Id(paperId)]的长度不能超过8(In 论文下载记录(PaperDownloadLog))!值:$(pobjPaperDownloadLogEN.paperId)(clsPaperDownloadLogBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperDownloadLogEN.updUser) == false && (0, clsString_js_1.GetStrLen)(pobjPaperDownloadLogEN.updUser) > 20) {
            throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 论文下载记录(PaperDownloadLog))!值:$(pobjPaperDownloadLogEN.updUser)(clsPaperDownloadLogBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperDownloadLogEN.updDate) == false && (0, clsString_js_1.GetStrLen)(pobjPaperDownloadLogEN.updDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 论文下载记录(PaperDownloadLog))!值:$(pobjPaperDownloadLogEN.updDate)(clsPaperDownloadLogBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperDownloadLogEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjPaperDownloadLogEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 论文下载记录(PaperDownloadLog))!值:$(pobjPaperDownloadLogEN.memo)(clsPaperDownloadLogBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if (null != pobjPaperDownloadLogEN.paperDownloadId && undefined !== pobjPaperDownloadLogEN.paperDownloadId && jsString_js_1.tzDataType.isNumber(pobjPaperDownloadLogEN.paperDownloadId) === false) {
            throw new Error("(errid:Watl000060)字段[PaperDownloadId(paperDownloadId)]的值:[$(pobjPaperDownloadLogEN.paperDownloadId)], 非法，应该为数值型(In 论文下载记录(PaperDownloadLog))!(clsPaperDownloadLogBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperDownloadLogEN.downloadFile) == false && undefined !== pobjPaperDownloadLogEN.downloadFile && jsString_js_1.tzDataType.isString(pobjPaperDownloadLogEN.downloadFile) === false) {
            throw new Error("(errid:Watl000060)字段[DownloadFile(downloadFile)]的值:[$(pobjPaperDownloadLogEN.downloadFile)], 非法，应该为字符型(In 论文下载记录(PaperDownloadLog))!(clsPaperDownloadLogBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperDownloadLogEN.downloadLink) == false && undefined !== pobjPaperDownloadLogEN.downloadLink && jsString_js_1.tzDataType.isString(pobjPaperDownloadLogEN.downloadLink) === false) {
            throw new Error("(errid:Watl000060)字段[DownloadLink(downloadLink)]的值:[$(pobjPaperDownloadLogEN.downloadLink)], 非法，应该为字符型(In 论文下载记录(PaperDownloadLog))!(clsPaperDownloadLogBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperDownloadLogEN.paperId) == false && undefined !== pobjPaperDownloadLogEN.paperId && jsString_js_1.tzDataType.isString(pobjPaperDownloadLogEN.paperId) === false) {
            throw new Error("(errid:Watl000060)字段[论文Id(paperId)]的值:[$(pobjPaperDownloadLogEN.paperId)], 非法，应该为字符型(In 论文下载记录(PaperDownloadLog))!(clsPaperDownloadLogBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperDownloadLogEN.updUser) == false && undefined !== pobjPaperDownloadLogEN.updUser && jsString_js_1.tzDataType.isString(pobjPaperDownloadLogEN.updUser) === false) {
            throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjPaperDownloadLogEN.updUser)], 非法，应该为字符型(In 论文下载记录(PaperDownloadLog))!(clsPaperDownloadLogBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperDownloadLogEN.updDate) == false && undefined !== pobjPaperDownloadLogEN.updDate && jsString_js_1.tzDataType.isString(pobjPaperDownloadLogEN.updDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjPaperDownloadLogEN.updDate)], 非法，应该为字符型(In 论文下载记录(PaperDownloadLog))!(clsPaperDownloadLogBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperDownloadLogEN.memo) == false && undefined !== pobjPaperDownloadLogEN.memo && jsString_js_1.tzDataType.isString(pobjPaperDownloadLogEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjPaperDownloadLogEN.memo)], 非法，应该为字符型(In 论文下载记录(PaperDownloadLog))!(clsPaperDownloadLogBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjPaperDownloadLogEN.SetIsCheckProperty(true);
    }
    exports.PaperDownloadLog_CheckPropertyNew = PaperDownloadLog_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function PaperDownloadLog_CheckProperty4Update(pobjPaperDownloadLogEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperDownloadLogEN.downloadFile) == false && (0, clsString_js_1.GetStrLen)(pobjPaperDownloadLogEN.downloadFile) > 500) {
            throw new Error("(errid:Watl000062)字段[DownloadFile(downloadFile)]的长度不能超过500(In 论文下载记录(PaperDownloadLog))!值:$(pobjPaperDownloadLogEN.downloadFile)(clsPaperDownloadLogBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperDownloadLogEN.downloadLink) == false && (0, clsString_js_1.GetStrLen)(pobjPaperDownloadLogEN.downloadLink) > 500) {
            throw new Error("(errid:Watl000062)字段[DownloadLink(downloadLink)]的长度不能超过500(In 论文下载记录(PaperDownloadLog))!值:$(pobjPaperDownloadLogEN.downloadLink)(clsPaperDownloadLogBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperDownloadLogEN.paperId) == false && (0, clsString_js_1.GetStrLen)(pobjPaperDownloadLogEN.paperId) > 8) {
            throw new Error("(errid:Watl000062)字段[论文Id(paperId)]的长度不能超过8(In 论文下载记录(PaperDownloadLog))!值:$(pobjPaperDownloadLogEN.paperId)(clsPaperDownloadLogBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperDownloadLogEN.updUser) == false && (0, clsString_js_1.GetStrLen)(pobjPaperDownloadLogEN.updUser) > 20) {
            throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 论文下载记录(PaperDownloadLog))!值:$(pobjPaperDownloadLogEN.updUser)(clsPaperDownloadLogBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperDownloadLogEN.updDate) == false && (0, clsString_js_1.GetStrLen)(pobjPaperDownloadLogEN.updDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 论文下载记录(PaperDownloadLog))!值:$(pobjPaperDownloadLogEN.updDate)(clsPaperDownloadLogBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperDownloadLogEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjPaperDownloadLogEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 论文下载记录(PaperDownloadLog))!值:$(pobjPaperDownloadLogEN.memo)(clsPaperDownloadLogBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if (null != pobjPaperDownloadLogEN.paperDownloadId && undefined !== pobjPaperDownloadLogEN.paperDownloadId && jsString_js_1.tzDataType.isNumber(pobjPaperDownloadLogEN.paperDownloadId) === false) {
            throw new Error("(errid:Watl000063)字段[PaperDownloadId(paperDownloadId)]的值:[$(pobjPaperDownloadLogEN.paperDownloadId)], 非法，应该为数值型(In 论文下载记录(PaperDownloadLog))!(clsPaperDownloadLogBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperDownloadLogEN.downloadFile) == false && undefined !== pobjPaperDownloadLogEN.downloadFile && jsString_js_1.tzDataType.isString(pobjPaperDownloadLogEN.downloadFile) === false) {
            throw new Error("(errid:Watl000063)字段[DownloadFile(downloadFile)]的值:[$(pobjPaperDownloadLogEN.downloadFile)], 非法，应该为字符型(In 论文下载记录(PaperDownloadLog))!(clsPaperDownloadLogBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperDownloadLogEN.downloadLink) == false && undefined !== pobjPaperDownloadLogEN.downloadLink && jsString_js_1.tzDataType.isString(pobjPaperDownloadLogEN.downloadLink) === false) {
            throw new Error("(errid:Watl000063)字段[DownloadLink(downloadLink)]的值:[$(pobjPaperDownloadLogEN.downloadLink)], 非法，应该为字符型(In 论文下载记录(PaperDownloadLog))!(clsPaperDownloadLogBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperDownloadLogEN.paperId) == false && undefined !== pobjPaperDownloadLogEN.paperId && jsString_js_1.tzDataType.isString(pobjPaperDownloadLogEN.paperId) === false) {
            throw new Error("(errid:Watl000063)字段[论文Id(paperId)]的值:[$(pobjPaperDownloadLogEN.paperId)], 非法，应该为字符型(In 论文下载记录(PaperDownloadLog))!(clsPaperDownloadLogBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperDownloadLogEN.updUser) == false && undefined !== pobjPaperDownloadLogEN.updUser && jsString_js_1.tzDataType.isString(pobjPaperDownloadLogEN.updUser) === false) {
            throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjPaperDownloadLogEN.updUser)], 非法，应该为字符型(In 论文下载记录(PaperDownloadLog))!(clsPaperDownloadLogBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperDownloadLogEN.updDate) == false && undefined !== pobjPaperDownloadLogEN.updDate && jsString_js_1.tzDataType.isString(pobjPaperDownloadLogEN.updDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjPaperDownloadLogEN.updDate)], 非法，应该为字符型(In 论文下载记录(PaperDownloadLog))!(clsPaperDownloadLogBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjPaperDownloadLogEN.memo) == false && undefined !== pobjPaperDownloadLogEN.memo && jsString_js_1.tzDataType.isString(pobjPaperDownloadLogEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjPaperDownloadLogEN.memo)], 非法，应该为字符型(In 论文下载记录(PaperDownloadLog))!(clsPaperDownloadLogBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if (null === pobjPaperDownloadLogEN.paperDownloadId
            || pobjPaperDownloadLogEN.paperDownloadId != null && pobjPaperDownloadLogEN.paperDownloadId.toString() === "") {
            throw new Error("(errid:Watl000064)字段[PaperDownloadId]不能为空(In 论文下载记录)!(clsPaperDownloadLogBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjPaperDownloadLogEN.SetIsCheckProperty(true);
    }
    exports.PaperDownloadLog_CheckProperty4Update = PaperDownloadLog_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function PaperDownloadLog_GetJSONStrByObj(pobjPaperDownloadLogEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjPaperDownloadLogEN.sf_UpdFldSetStr = pobjPaperDownloadLogEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjPaperDownloadLogEN);
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
    exports.PaperDownloadLog_GetJSONStrByObj = PaperDownloadLog_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function PaperDownloadLog_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrPaperDownloadLogObjLst = new Array();
        if (strJSON === "") {
            return arrPaperDownloadLogObjLst;
        }
        try {
            arrPaperDownloadLogObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrPaperDownloadLogObjLst;
        }
        return arrPaperDownloadLogObjLst;
    }
    exports.PaperDownloadLog_GetObjLstByJSONStr = PaperDownloadLog_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrPaperDownloadLogObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function PaperDownloadLog_GetObjLstByJSONObjLst(arrPaperDownloadLogObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrPaperDownloadLogObjLst = new Array();
        for (const objInFor of arrPaperDownloadLogObjLstS) {
            const obj1 = PaperDownloadLog_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrPaperDownloadLogObjLst.push(obj1);
        }
        return arrPaperDownloadLogObjLst;
    }
    exports.PaperDownloadLog_GetObjLstByJSONObjLst = PaperDownloadLog_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function PaperDownloadLog_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjPaperDownloadLogEN = new clsPaperDownloadLogEN_js_1.clsPaperDownloadLogEN();
        if (strJSON === "") {
            return pobjPaperDownloadLogEN;
        }
        try {
            pobjPaperDownloadLogEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjPaperDownloadLogEN;
        }
        return pobjPaperDownloadLogEN;
    }
    exports.PaperDownloadLog_GetObjByJSONStr = PaperDownloadLog_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function PaperDownloadLog_GetCombineCondition(objPaperDownloadLog_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objPaperDownloadLog_Cond.dicFldComparisonOp, clsPaperDownloadLogEN_js_1.clsPaperDownloadLogEN.con_PaperDownloadId) == true) {
            const strComparisonOp_PaperDownloadId = objPaperDownloadLog_Cond.dicFldComparisonOp[clsPaperDownloadLogEN_js_1.clsPaperDownloadLogEN.con_PaperDownloadId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsPaperDownloadLogEN_js_1.clsPaperDownloadLogEN.con_PaperDownloadId, objPaperDownloadLog_Cond.paperDownloadId, strComparisonOp_PaperDownloadId);
        }
        if (Object.prototype.hasOwnProperty.call(objPaperDownloadLog_Cond.dicFldComparisonOp, clsPaperDownloadLogEN_js_1.clsPaperDownloadLogEN.con_DownloadFile) == true) {
            const strComparisonOp_DownloadFile = objPaperDownloadLog_Cond.dicFldComparisonOp[clsPaperDownloadLogEN_js_1.clsPaperDownloadLogEN.con_DownloadFile];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsPaperDownloadLogEN_js_1.clsPaperDownloadLogEN.con_DownloadFile, objPaperDownloadLog_Cond.downloadFile, strComparisonOp_DownloadFile);
        }
        if (Object.prototype.hasOwnProperty.call(objPaperDownloadLog_Cond.dicFldComparisonOp, clsPaperDownloadLogEN_js_1.clsPaperDownloadLogEN.con_DownloadLink) == true) {
            const strComparisonOp_DownloadLink = objPaperDownloadLog_Cond.dicFldComparisonOp[clsPaperDownloadLogEN_js_1.clsPaperDownloadLogEN.con_DownloadLink];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsPaperDownloadLogEN_js_1.clsPaperDownloadLogEN.con_DownloadLink, objPaperDownloadLog_Cond.downloadLink, strComparisonOp_DownloadLink);
        }
        if (Object.prototype.hasOwnProperty.call(objPaperDownloadLog_Cond.dicFldComparisonOp, clsPaperDownloadLogEN_js_1.clsPaperDownloadLogEN.con_PaperId) == true) {
            const strComparisonOp_PaperId = objPaperDownloadLog_Cond.dicFldComparisonOp[clsPaperDownloadLogEN_js_1.clsPaperDownloadLogEN.con_PaperId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsPaperDownloadLogEN_js_1.clsPaperDownloadLogEN.con_PaperId, objPaperDownloadLog_Cond.paperId, strComparisonOp_PaperId);
        }
        if (Object.prototype.hasOwnProperty.call(objPaperDownloadLog_Cond.dicFldComparisonOp, clsPaperDownloadLogEN_js_1.clsPaperDownloadLogEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objPaperDownloadLog_Cond.dicFldComparisonOp[clsPaperDownloadLogEN_js_1.clsPaperDownloadLogEN.con_UpdUser];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsPaperDownloadLogEN_js_1.clsPaperDownloadLogEN.con_UpdUser, objPaperDownloadLog_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objPaperDownloadLog_Cond.dicFldComparisonOp, clsPaperDownloadLogEN_js_1.clsPaperDownloadLogEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objPaperDownloadLog_Cond.dicFldComparisonOp[clsPaperDownloadLogEN_js_1.clsPaperDownloadLogEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsPaperDownloadLogEN_js_1.clsPaperDownloadLogEN.con_UpdDate, objPaperDownloadLog_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objPaperDownloadLog_Cond.dicFldComparisonOp, clsPaperDownloadLogEN_js_1.clsPaperDownloadLogEN.con_Memo) == true) {
            const strComparisonOp_Memo = objPaperDownloadLog_Cond.dicFldComparisonOp[clsPaperDownloadLogEN_js_1.clsPaperDownloadLogEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsPaperDownloadLogEN_js_1.clsPaperDownloadLogEN.con_Memo, objPaperDownloadLog_Cond.memo, strComparisonOp_Memo);
        }
        return strWhereCond;
    }
    exports.PaperDownloadLog_GetCombineCondition = PaperDownloadLog_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--PaperDownloadLog(论文下载记录),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param lngPaperDownloadId: PaperDownloadId(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function PaperDownloadLog_GetUniCondStr_PaperDownloadId(objPaperDownloadLogEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and PaperDownloadId = '{0}'", objPaperDownloadLogEN.paperDownloadId);
        return strWhereCond;
    }
    exports.PaperDownloadLog_GetUniCondStr_PaperDownloadId = PaperDownloadLog_GetUniCondStr_PaperDownloadId;
    /**
    *获取唯一性条件串(Uniqueness)--PaperDownloadLog(论文下载记录),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param lngPaperDownloadId: PaperDownloadId(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function PaperDownloadLog_GetUniCondStr4Update_PaperDownloadId(objPaperDownloadLogEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and PaperDownloadId <> '{0}'", objPaperDownloadLogEN.paperDownloadId);
        strWhereCond += (0, clsString_js_1.Format)(" and PaperDownloadId = '{0}'", objPaperDownloadLogEN.paperDownloadId);
        return strWhereCond;
    }
    exports.PaperDownloadLog_GetUniCondStr4Update_PaperDownloadId = PaperDownloadLog_GetUniCondStr4Update_PaperDownloadId;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objPaperDownloadLogENS:源对象
     * @param objPaperDownloadLogENT:目标对象
    */
    function PaperDownloadLog_CopyObjTo(objPaperDownloadLogENS, objPaperDownloadLogENT) {
        objPaperDownloadLogENT.paperDownloadId = objPaperDownloadLogENS.paperDownloadId; //PaperDownloadId
        objPaperDownloadLogENT.downloadFile = objPaperDownloadLogENS.downloadFile; //DownloadFile
        objPaperDownloadLogENT.downloadLink = objPaperDownloadLogENS.downloadLink; //DownloadLink
        objPaperDownloadLogENT.paperId = objPaperDownloadLogENS.paperId; //论文Id
        objPaperDownloadLogENT.updUser = objPaperDownloadLogENS.updUser; //修改人
        objPaperDownloadLogENT.updDate = objPaperDownloadLogENS.updDate; //修改日期
        objPaperDownloadLogENT.memo = objPaperDownloadLogENS.memo; //备注
        objPaperDownloadLogENT.sf_UpdFldSetStr = objPaperDownloadLogENS.updFldString; //sf_UpdFldSetStr
    }
    exports.PaperDownloadLog_CopyObjTo = PaperDownloadLog_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objPaperDownloadLogENS:源对象
     * @param objPaperDownloadLogENT:目标对象
    */
    function PaperDownloadLog_GetObjFromJsonObj(objPaperDownloadLogENS) {
        const objPaperDownloadLogENT = new clsPaperDownloadLogEN_js_1.clsPaperDownloadLogEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objPaperDownloadLogENT, objPaperDownloadLogENS);
        return objPaperDownloadLogENT;
    }
    exports.PaperDownloadLog_GetObjFromJsonObj = PaperDownloadLog_GetObjFromJsonObj;
});
