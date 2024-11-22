/**
* 类名:clsvPaperDownloadLogWApi
* 表名:vPaperDownloadLog(01120572)
* 生成代码版本:2022.11.02.1
* 生成日期:2022/11/02 12:02:40
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
        define(["require", "exports", "axios", "../../L0_Entity/GraduateEduPaper/clsvPaperDownloadLogEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsSysPara4WebApi.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.vPaperDownloadLog_GetObjFromJsonObj = exports.vPaperDownloadLog_CopyObjTo = exports.vPaperDownloadLog_GetCombineCondition = exports.vPaperDownloadLog_GetObjByJSONStr = exports.vPaperDownloadLog_GetObjLstByJSONObjLst = exports.vPaperDownloadLog_GetObjLstByJSONStr = exports.vPaperDownloadLog_GetJSONStrByObj = exports.vPaperDownloadLog_GetWebApiUrl = exports.vPaperDownloadLog_GetRecCountByCondAsync = exports.vPaperDownloadLog_IsExistAsync = exports.vPaperDownloadLog_IsExist = exports.vPaperDownloadLog_IsExistRecordAsync = exports.vPaperDownloadLog_GetObjLstByPagerAsync = exports.vPaperDownloadLog_GetObjLstByRange = exports.vPaperDownloadLog_GetObjLstByRangeAsync = exports.vPaperDownloadLog_GetTopObjLstAsync = exports.vPaperDownloadLog_GetObjLstByPaperDownloadIdLstAsync = exports.vPaperDownloadLog_GetObjLstAsync = exports.vPaperDownloadLog_GetFirstObjAsync = exports.vPaperDownloadLog_GetFirstID = exports.vPaperDownloadLog_GetFirstIDAsync = exports.vPaperDownloadLog_FilterFunByKey = exports.vPaperDownloadLog_SortFunByKey = exports.vPaperDownloadLog_SortFun_Defa_2Fld = exports.vPaperDownloadLog_SortFun_Defa = exports.vPaperDownloadLog_GetObjByPaperDownloadIdAsync = exports.vPaperDownloadLog_ConstructorName = exports.vPaperDownloadLog_Controller = void 0;
    /**
     * v论文下载记录(vPaperDownloadLog)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2022年11月02日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const clsvPaperDownloadLogEN_js_1 = require("../../L0_Entity/GraduateEduPaper/clsvPaperDownloadLogEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.vPaperDownloadLog_Controller = "vPaperDownloadLogApi";
    exports.vPaperDownloadLog_ConstructorName = "vPaperDownloadLog";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param lngPaperDownloadId:关键字
    * @returns 对象
    **/
    async function vPaperDownloadLog_GetObjByPaperDownloadIdAsync(lngPaperDownloadId) {
        const strThisFuncName = "GetObjByPaperDownloadIdAsync";
        if (lngPaperDownloadId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngPaperDownloadId]不能为空！(In GetObjByPaperDownloadIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByPaperDownloadId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperDownloadLog_Controller, strAction);
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
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vPaperDownloadLog_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objvPaperDownloadLog = vPaperDownloadLog_GetObjFromJsonObj(returnObj);
                return objvPaperDownloadLog;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperDownloadLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperDownloadLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperDownloadLog_GetObjByPaperDownloadIdAsync = vPaperDownloadLog_GetObjByPaperDownloadIdAsync;
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
    function vPaperDownloadLog_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.paperDownloadId - b.paperDownloadId;
    }
    exports.vPaperDownloadLog_SortFun_Defa = vPaperDownloadLog_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vPaperDownloadLog_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.downloadFile == b.downloadFile)
            return a.downloadLink.localeCompare(b.downloadLink);
        else
            return a.downloadFile.localeCompare(b.downloadFile);
    }
    exports.vPaperDownloadLog_SortFun_Defa_2Fld = vPaperDownloadLog_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vPaperDownloadLog_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsvPaperDownloadLogEN_js_1.clsvPaperDownloadLogEN.con_PaperDownloadId:
                    return (a, b) => {
                        return a.paperDownloadId - b.paperDownloadId;
                    };
                case clsvPaperDownloadLogEN_js_1.clsvPaperDownloadLogEN.con_DownloadFile:
                    return (a, b) => {
                        return a.downloadFile.localeCompare(b.downloadFile);
                    };
                case clsvPaperDownloadLogEN_js_1.clsvPaperDownloadLogEN.con_DownloadLink:
                    return (a, b) => {
                        return a.downloadLink.localeCompare(b.downloadLink);
                    };
                case clsvPaperDownloadLogEN_js_1.clsvPaperDownloadLogEN.con_PaperId:
                    return (a, b) => {
                        return a.paperId.localeCompare(b.paperId);
                    };
                case clsvPaperDownloadLogEN_js_1.clsvPaperDownloadLogEN.con_UpdUser:
                    return (a, b) => {
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsvPaperDownloadLogEN_js_1.clsvPaperDownloadLogEN.con_UpdDate:
                    return (a, b) => {
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsvPaperDownloadLogEN_js_1.clsvPaperDownloadLogEN.con_Memo:
                    return (a, b) => {
                        return a.memo.localeCompare(b.memo);
                    };
                case clsvPaperDownloadLogEN_js_1.clsvPaperDownloadLogEN.con_PaperTitle:
                    return (a, b) => {
                        return a.paperTitle.localeCompare(b.paperTitle);
                    };
                case clsvPaperDownloadLogEN_js_1.clsvPaperDownloadLogEN.con_Author:
                    return (a, b) => {
                        return a.author.localeCompare(b.author);
                    };
                case clsvPaperDownloadLogEN_js_1.clsvPaperDownloadLogEN.con_Keyword:
                    return (a, b) => {
                        return a.keyword.localeCompare(b.keyword);
                    };
                case clsvPaperDownloadLogEN_js_1.clsvPaperDownloadLogEN.con_UserName:
                    return (a, b) => {
                        return a.userName.localeCompare(b.userName);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vPaperDownloadLog]中不存在！(in ${exports.vPaperDownloadLog_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsvPaperDownloadLogEN_js_1.clsvPaperDownloadLogEN.con_PaperDownloadId:
                    return (a, b) => {
                        return b.paperDownloadId - a.paperDownloadId;
                    };
                case clsvPaperDownloadLogEN_js_1.clsvPaperDownloadLogEN.con_DownloadFile:
                    return (a, b) => {
                        return b.downloadFile.localeCompare(a.downloadFile);
                    };
                case clsvPaperDownloadLogEN_js_1.clsvPaperDownloadLogEN.con_DownloadLink:
                    return (a, b) => {
                        return b.downloadLink.localeCompare(a.downloadLink);
                    };
                case clsvPaperDownloadLogEN_js_1.clsvPaperDownloadLogEN.con_PaperId:
                    return (a, b) => {
                        return b.paperId.localeCompare(a.paperId);
                    };
                case clsvPaperDownloadLogEN_js_1.clsvPaperDownloadLogEN.con_UpdUser:
                    return (a, b) => {
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsvPaperDownloadLogEN_js_1.clsvPaperDownloadLogEN.con_UpdDate:
                    return (a, b) => {
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsvPaperDownloadLogEN_js_1.clsvPaperDownloadLogEN.con_Memo:
                    return (a, b) => {
                        return b.memo.localeCompare(a.memo);
                    };
                case clsvPaperDownloadLogEN_js_1.clsvPaperDownloadLogEN.con_PaperTitle:
                    return (a, b) => {
                        return b.paperTitle.localeCompare(a.paperTitle);
                    };
                case clsvPaperDownloadLogEN_js_1.clsvPaperDownloadLogEN.con_Author:
                    return (a, b) => {
                        return b.author.localeCompare(a.author);
                    };
                case clsvPaperDownloadLogEN_js_1.clsvPaperDownloadLogEN.con_Keyword:
                    return (a, b) => {
                        return b.keyword.localeCompare(a.keyword);
                    };
                case clsvPaperDownloadLogEN_js_1.clsvPaperDownloadLogEN.con_UserName:
                    return (a, b) => {
                        return b.userName.localeCompare(a.userName);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vPaperDownloadLog]中不存在！(in ${exports.vPaperDownloadLog_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.vPaperDownloadLog_SortFunByKey = vPaperDownloadLog_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function vPaperDownloadLog_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsvPaperDownloadLogEN_js_1.clsvPaperDownloadLogEN.con_PaperDownloadId:
                return (obj) => {
                    return obj.paperDownloadId === value;
                };
            case clsvPaperDownloadLogEN_js_1.clsvPaperDownloadLogEN.con_DownloadFile:
                return (obj) => {
                    return obj.downloadFile === value;
                };
            case clsvPaperDownloadLogEN_js_1.clsvPaperDownloadLogEN.con_DownloadLink:
                return (obj) => {
                    return obj.downloadLink === value;
                };
            case clsvPaperDownloadLogEN_js_1.clsvPaperDownloadLogEN.con_PaperId:
                return (obj) => {
                    return obj.paperId === value;
                };
            case clsvPaperDownloadLogEN_js_1.clsvPaperDownloadLogEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsvPaperDownloadLogEN_js_1.clsvPaperDownloadLogEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsvPaperDownloadLogEN_js_1.clsvPaperDownloadLogEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            case clsvPaperDownloadLogEN_js_1.clsvPaperDownloadLogEN.con_PaperTitle:
                return (obj) => {
                    return obj.paperTitle === value;
                };
            case clsvPaperDownloadLogEN_js_1.clsvPaperDownloadLogEN.con_Author:
                return (obj) => {
                    return obj.author === value;
                };
            case clsvPaperDownloadLogEN_js_1.clsvPaperDownloadLogEN.con_Keyword:
                return (obj) => {
                    return obj.keyword === value;
                };
            case clsvPaperDownloadLogEN_js_1.clsvPaperDownloadLogEN.con_UserName:
                return (obj) => {
                    return obj.userName === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[vPaperDownloadLog]中不存在！(in ${exports.vPaperDownloadLog_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.vPaperDownloadLog_FilterFunByKey = vPaperDownloadLog_FilterFunByKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function vPaperDownloadLog_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperDownloadLog_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperDownloadLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperDownloadLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperDownloadLog_GetFirstIDAsync = vPaperDownloadLog_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function vPaperDownloadLog_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperDownloadLog_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperDownloadLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperDownloadLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperDownloadLog_GetFirstID = vPaperDownloadLog_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function vPaperDownloadLog_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperDownloadLog_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vPaperDownloadLog_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objvPaperDownloadLog = vPaperDownloadLog_GetObjFromJsonObj(returnObj);
                return objvPaperDownloadLog;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperDownloadLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperDownloadLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperDownloadLog_GetFirstObjAsync = vPaperDownloadLog_GetFirstObjAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function vPaperDownloadLog_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperDownloadLog_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vPaperDownloadLog_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vPaperDownloadLog_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperDownloadLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperDownloadLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperDownloadLog_GetObjLstAsync = vPaperDownloadLog_GetObjLstAsync;
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
    async function vPaperDownloadLog_GetObjLstByPaperDownloadIdLstAsync(arrPaperDownloadId) {
        const strThisFuncName = "GetObjLstByPaperDownloadIdLstAsync";
        const strAction = "GetObjLstByPaperDownloadIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperDownloadLog_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrPaperDownloadId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vPaperDownloadLog_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vPaperDownloadLog_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperDownloadLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperDownloadLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperDownloadLog_GetObjLstByPaperDownloadIdLstAsync = vPaperDownloadLog_GetObjLstByPaperDownloadIdLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function vPaperDownloadLog_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperDownloadLog_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vPaperDownloadLog_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vPaperDownloadLog_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperDownloadLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperDownloadLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperDownloadLog_GetTopObjLstAsync = vPaperDownloadLog_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vPaperDownloadLog_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperDownloadLog_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vPaperDownloadLog_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vPaperDownloadLog_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperDownloadLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperDownloadLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperDownloadLog_GetObjLstByRangeAsync = vPaperDownloadLog_GetObjLstByRangeAsync;
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
    async function vPaperDownloadLog_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperDownloadLog_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperDownloadLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperDownloadLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperDownloadLog_GetObjLstByRange = vPaperDownloadLog_GetObjLstByRange;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vPaperDownloadLog_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperDownloadLog_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vPaperDownloadLog_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vPaperDownloadLog_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperDownloadLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperDownloadLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperDownloadLog_GetObjLstByPagerAsync = vPaperDownloadLog_GetObjLstByPagerAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function vPaperDownloadLog_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperDownloadLog_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperDownloadLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperDownloadLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperDownloadLog_IsExistRecordAsync = vPaperDownloadLog_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param lngPaperDownloadId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function vPaperDownloadLog_IsExist(lngPaperDownloadId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperDownloadLog_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperDownloadLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperDownloadLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperDownloadLog_IsExist = vPaperDownloadLog_IsExist;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param lngPaperDownloadId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function vPaperDownloadLog_IsExistAsync(lngPaperDownloadId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperDownloadLog_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperDownloadLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperDownloadLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperDownloadLog_IsExistAsync = vPaperDownloadLog_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function vPaperDownloadLog_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperDownloadLog_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperDownloadLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperDownloadLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperDownloadLog_GetRecCountByCondAsync = vPaperDownloadLog_GetRecCountByCondAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function vPaperDownloadLog_GetWebApiUrl(strController, strAction) {
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
    exports.vPaperDownloadLog_GetWebApiUrl = vPaperDownloadLog_GetWebApiUrl;
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
    function vPaperDownloadLog_GetJSONStrByObj(pobjvPaperDownloadLogEN) {
        const strThisFuncName = "GetJSONStrByObj";
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjvPaperDownloadLogEN);
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
    exports.vPaperDownloadLog_GetJSONStrByObj = vPaperDownloadLog_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function vPaperDownloadLog_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrvPaperDownloadLogObjLst = new Array();
        if (strJSON === "") {
            return arrvPaperDownloadLogObjLst;
        }
        try {
            arrvPaperDownloadLogObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrvPaperDownloadLogObjLst;
        }
        return arrvPaperDownloadLogObjLst;
    }
    exports.vPaperDownloadLog_GetObjLstByJSONStr = vPaperDownloadLog_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrvPaperDownloadLogObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function vPaperDownloadLog_GetObjLstByJSONObjLst(arrvPaperDownloadLogObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrvPaperDownloadLogObjLst = new Array();
        for (const objInFor of arrvPaperDownloadLogObjLstS) {
            const obj1 = vPaperDownloadLog_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrvPaperDownloadLogObjLst.push(obj1);
        }
        return arrvPaperDownloadLogObjLst;
    }
    exports.vPaperDownloadLog_GetObjLstByJSONObjLst = vPaperDownloadLog_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vPaperDownloadLog_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjvPaperDownloadLogEN = new clsvPaperDownloadLogEN_js_1.clsvPaperDownloadLogEN();
        if (strJSON === "") {
            return pobjvPaperDownloadLogEN;
        }
        try {
            pobjvPaperDownloadLogEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjvPaperDownloadLogEN;
        }
        return pobjvPaperDownloadLogEN;
    }
    exports.vPaperDownloadLog_GetObjByJSONStr = vPaperDownloadLog_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function vPaperDownloadLog_GetCombineCondition(objvPaperDownloadLog_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objvPaperDownloadLog_Cond.dicFldComparisonOp, clsvPaperDownloadLogEN_js_1.clsvPaperDownloadLogEN.con_PaperDownloadId) == true) {
            const strComparisonOp_PaperDownloadId = objvPaperDownloadLog_Cond.dicFldComparisonOp[clsvPaperDownloadLogEN_js_1.clsvPaperDownloadLogEN.con_PaperDownloadId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvPaperDownloadLogEN_js_1.clsvPaperDownloadLogEN.con_PaperDownloadId, objvPaperDownloadLog_Cond.paperDownloadId, strComparisonOp_PaperDownloadId);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperDownloadLog_Cond.dicFldComparisonOp, clsvPaperDownloadLogEN_js_1.clsvPaperDownloadLogEN.con_DownloadFile) == true) {
            const strComparisonOp_DownloadFile = objvPaperDownloadLog_Cond.dicFldComparisonOp[clsvPaperDownloadLogEN_js_1.clsvPaperDownloadLogEN.con_DownloadFile];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperDownloadLogEN_js_1.clsvPaperDownloadLogEN.con_DownloadFile, objvPaperDownloadLog_Cond.downloadFile, strComparisonOp_DownloadFile);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperDownloadLog_Cond.dicFldComparisonOp, clsvPaperDownloadLogEN_js_1.clsvPaperDownloadLogEN.con_DownloadLink) == true) {
            const strComparisonOp_DownloadLink = objvPaperDownloadLog_Cond.dicFldComparisonOp[clsvPaperDownloadLogEN_js_1.clsvPaperDownloadLogEN.con_DownloadLink];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperDownloadLogEN_js_1.clsvPaperDownloadLogEN.con_DownloadLink, objvPaperDownloadLog_Cond.downloadLink, strComparisonOp_DownloadLink);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperDownloadLog_Cond.dicFldComparisonOp, clsvPaperDownloadLogEN_js_1.clsvPaperDownloadLogEN.con_PaperId) == true) {
            const strComparisonOp_PaperId = objvPaperDownloadLog_Cond.dicFldComparisonOp[clsvPaperDownloadLogEN_js_1.clsvPaperDownloadLogEN.con_PaperId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperDownloadLogEN_js_1.clsvPaperDownloadLogEN.con_PaperId, objvPaperDownloadLog_Cond.paperId, strComparisonOp_PaperId);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperDownloadLog_Cond.dicFldComparisonOp, clsvPaperDownloadLogEN_js_1.clsvPaperDownloadLogEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objvPaperDownloadLog_Cond.dicFldComparisonOp[clsvPaperDownloadLogEN_js_1.clsvPaperDownloadLogEN.con_UpdUser];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperDownloadLogEN_js_1.clsvPaperDownloadLogEN.con_UpdUser, objvPaperDownloadLog_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperDownloadLog_Cond.dicFldComparisonOp, clsvPaperDownloadLogEN_js_1.clsvPaperDownloadLogEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objvPaperDownloadLog_Cond.dicFldComparisonOp[clsvPaperDownloadLogEN_js_1.clsvPaperDownloadLogEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperDownloadLogEN_js_1.clsvPaperDownloadLogEN.con_UpdDate, objvPaperDownloadLog_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperDownloadLog_Cond.dicFldComparisonOp, clsvPaperDownloadLogEN_js_1.clsvPaperDownloadLogEN.con_Memo) == true) {
            const strComparisonOp_Memo = objvPaperDownloadLog_Cond.dicFldComparisonOp[clsvPaperDownloadLogEN_js_1.clsvPaperDownloadLogEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperDownloadLogEN_js_1.clsvPaperDownloadLogEN.con_Memo, objvPaperDownloadLog_Cond.memo, strComparisonOp_Memo);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperDownloadLog_Cond.dicFldComparisonOp, clsvPaperDownloadLogEN_js_1.clsvPaperDownloadLogEN.con_PaperTitle) == true) {
            const strComparisonOp_PaperTitle = objvPaperDownloadLog_Cond.dicFldComparisonOp[clsvPaperDownloadLogEN_js_1.clsvPaperDownloadLogEN.con_PaperTitle];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperDownloadLogEN_js_1.clsvPaperDownloadLogEN.con_PaperTitle, objvPaperDownloadLog_Cond.paperTitle, strComparisonOp_PaperTitle);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperDownloadLog_Cond.dicFldComparisonOp, clsvPaperDownloadLogEN_js_1.clsvPaperDownloadLogEN.con_Author) == true) {
            const strComparisonOp_Author = objvPaperDownloadLog_Cond.dicFldComparisonOp[clsvPaperDownloadLogEN_js_1.clsvPaperDownloadLogEN.con_Author];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperDownloadLogEN_js_1.clsvPaperDownloadLogEN.con_Author, objvPaperDownloadLog_Cond.author, strComparisonOp_Author);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperDownloadLog_Cond.dicFldComparisonOp, clsvPaperDownloadLogEN_js_1.clsvPaperDownloadLogEN.con_Keyword) == true) {
            const strComparisonOp_Keyword = objvPaperDownloadLog_Cond.dicFldComparisonOp[clsvPaperDownloadLogEN_js_1.clsvPaperDownloadLogEN.con_Keyword];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperDownloadLogEN_js_1.clsvPaperDownloadLogEN.con_Keyword, objvPaperDownloadLog_Cond.keyword, strComparisonOp_Keyword);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperDownloadLog_Cond.dicFldComparisonOp, clsvPaperDownloadLogEN_js_1.clsvPaperDownloadLogEN.con_UserName) == true) {
            const strComparisonOp_UserName = objvPaperDownloadLog_Cond.dicFldComparisonOp[clsvPaperDownloadLogEN_js_1.clsvPaperDownloadLogEN.con_UserName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperDownloadLogEN_js_1.clsvPaperDownloadLogEN.con_UserName, objvPaperDownloadLog_Cond.userName, strComparisonOp_UserName);
        }
        return strWhereCond;
    }
    exports.vPaperDownloadLog_GetCombineCondition = vPaperDownloadLog_GetCombineCondition;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objvPaperDownloadLogENS:源对象
     * @param objvPaperDownloadLogENT:目标对象
    */
    function vPaperDownloadLog_CopyObjTo(objvPaperDownloadLogENS, objvPaperDownloadLogENT) {
        objvPaperDownloadLogENT.paperDownloadId = objvPaperDownloadLogENS.paperDownloadId; //PaperDownloadId
        objvPaperDownloadLogENT.downloadFile = objvPaperDownloadLogENS.downloadFile; //DownloadFile
        objvPaperDownloadLogENT.downloadLink = objvPaperDownloadLogENS.downloadLink; //DownloadLink
        objvPaperDownloadLogENT.paperId = objvPaperDownloadLogENS.paperId; //论文Id
        objvPaperDownloadLogENT.updUser = objvPaperDownloadLogENS.updUser; //修改人
        objvPaperDownloadLogENT.updDate = objvPaperDownloadLogENS.updDate; //修改日期
        objvPaperDownloadLogENT.memo = objvPaperDownloadLogENS.memo; //备注
        objvPaperDownloadLogENT.paperTitle = objvPaperDownloadLogENS.paperTitle; //论文标题
        objvPaperDownloadLogENT.author = objvPaperDownloadLogENS.author; //作者
        objvPaperDownloadLogENT.keyword = objvPaperDownloadLogENS.keyword; //关键字
        objvPaperDownloadLogENT.userName = objvPaperDownloadLogENS.userName; //用户名
    }
    exports.vPaperDownloadLog_CopyObjTo = vPaperDownloadLog_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objvPaperDownloadLogENS:源对象
     * @param objvPaperDownloadLogENT:目标对象
    */
    function vPaperDownloadLog_GetObjFromJsonObj(objvPaperDownloadLogENS) {
        const objvPaperDownloadLogENT = new clsvPaperDownloadLogEN_js_1.clsvPaperDownloadLogEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvPaperDownloadLogENT, objvPaperDownloadLogENS);
        return objvPaperDownloadLogENT;
    }
    exports.vPaperDownloadLog_GetObjFromJsonObj = vPaperDownloadLog_GetObjFromJsonObj;
});
