/**
* 类名:clsvPaperCollectionLogWApi
* 表名:vPaperCollectionLog(01120569)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/13 00:43:33
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
        define(["require", "exports", "axios", "../../L0_Entity/GraduateEduPaper/clsvPaperCollectionLogEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.vPaperCollectionLog_GetObjFromJsonObj = exports.vPaperCollectionLog_CopyObjTo = exports.vPaperCollectionLog_GetCombineCondition = exports.vPaperCollectionLog_GetObjByJSONStr = exports.vPaperCollectionLog_GetObjLstByJSONObjLst = exports.vPaperCollectionLog_GetObjLstByJSONStr = exports.vPaperCollectionLog_GetJSONStrByObj = exports.vPaperCollectionLog_GetWebApiUrl = exports.vPaperCollectionLog_GetRecCountByCondAsync = exports.vPaperCollectionLog_IsExistAsync = exports.vPaperCollectionLog_IsExist = exports.vPaperCollectionLog_IsExistRecordAsync = exports.vPaperCollectionLog_GetObjLstByPagerAsync = exports.vPaperCollectionLog_GetObjLstByRange = exports.vPaperCollectionLog_GetObjLstByRangeAsync = exports.vPaperCollectionLog_GetTopObjLstAsync = exports.vPaperCollectionLog_GetObjLstByPaperCollectionLogIdLstAsync = exports.vPaperCollectionLog_GetObjLstAsync = exports.vPaperCollectionLog_GetFirstObjAsync = exports.vPaperCollectionLog_GetFirstID = exports.vPaperCollectionLog_GetFirstIDAsync = exports.vPaperCollectionLog_FilterFunByKey = exports.vPaperCollectionLog_SortFunByKey = exports.vPaperCollectionLog_SortFun_Defa_2Fld = exports.vPaperCollectionLog_SortFun_Defa = exports.vPaperCollectionLog_GetObjByPaperCollectionLogIdAsync = exports.vPaperCollectionLog_ConstructorName = exports.vPaperCollectionLog_Controller = void 0;
    /**
     * v论文收藏(vPaperCollectionLog)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月13日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const clsvPaperCollectionLogEN_js_1 = require("../../L0_Entity/GraduateEduPaper/clsvPaperCollectionLogEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.vPaperCollectionLog_Controller = "vPaperCollectionLogApi";
    exports.vPaperCollectionLog_ConstructorName = "vPaperCollectionLog";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param lngPaperCollectionLogId:关键字
    * @returns 对象
    **/
    async function vPaperCollectionLog_GetObjByPaperCollectionLogIdAsync(lngPaperCollectionLogId) {
        const strThisFuncName = "GetObjByPaperCollectionLogIdAsync";
        if (lngPaperCollectionLogId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngPaperCollectionLogId]不能为空！(In clsvPaperCollectionLogWApi.GetObjByPaperCollectionLogIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByPaperCollectionLogId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperCollectionLog_Controller, strAction);
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
                    return null;
                }
                //console.log(returnObj);
                const objvPaperCollectionLog = vPaperCollectionLog_GetObjFromJsonObj(returnObj);
                return objvPaperCollectionLog;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperCollectionLog_GetObjByPaperCollectionLogIdAsync = vPaperCollectionLog_GetObjByPaperCollectionLogIdAsync;
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
    function vPaperCollectionLog_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.paperCollectionLogId - b.paperCollectionLogId;
    }
    exports.vPaperCollectionLog_SortFun_Defa = vPaperCollectionLog_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vPaperCollectionLog_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.paperId == b.paperId)
            return a.updUser.localeCompare(b.updUser);
        else
            return a.paperId.localeCompare(b.paperId);
    }
    exports.vPaperCollectionLog_SortFun_Defa_2Fld = vPaperCollectionLog_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vPaperCollectionLog_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsvPaperCollectionLogEN_js_1.clsvPaperCollectionLogEN.con_PaperCollectionLogId:
                    return (a, b) => {
                        return a.paperCollectionLogId - b.paperCollectionLogId;
                    };
                case clsvPaperCollectionLogEN_js_1.clsvPaperCollectionLogEN.con_PaperId:
                    return (a, b) => {
                        if (a.paperId == null)
                            return -1;
                        if (b.paperId == null)
                            return 1;
                        return a.paperId.localeCompare(b.paperId);
                    };
                case clsvPaperCollectionLogEN_js_1.clsvPaperCollectionLogEN.con_UpdUser:
                    return (a, b) => {
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsvPaperCollectionLogEN_js_1.clsvPaperCollectionLogEN.con_UpdDate:
                    return (a, b) => {
                        if (a.updDate == null)
                            return -1;
                        if (b.updDate == null)
                            return 1;
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsvPaperCollectionLogEN_js_1.clsvPaperCollectionLogEN.con_Meno:
                    return (a, b) => {
                        if (a.meno == null)
                            return -1;
                        if (b.meno == null)
                            return 1;
                        return a.meno.localeCompare(b.meno);
                    };
                case clsvPaperCollectionLogEN_js_1.clsvPaperCollectionLogEN.con_PaperTitle:
                    return (a, b) => {
                        if (a.paperTitle == null)
                            return -1;
                        if (b.paperTitle == null)
                            return 1;
                        return a.paperTitle.localeCompare(b.paperTitle);
                    };
                case clsvPaperCollectionLogEN_js_1.clsvPaperCollectionLogEN.con_Author:
                    return (a, b) => {
                        if (a.author == null)
                            return -1;
                        if (b.author == null)
                            return 1;
                        return a.author.localeCompare(b.author);
                    };
                case clsvPaperCollectionLogEN_js_1.clsvPaperCollectionLogEN.con_Keyword:
                    return (a, b) => {
                        if (a.keyword == null)
                            return -1;
                        if (b.keyword == null)
                            return 1;
                        return a.keyword.localeCompare(b.keyword);
                    };
                case clsvPaperCollectionLogEN_js_1.clsvPaperCollectionLogEN.con_BrowseNumber:
                    return (a, b) => {
                        return a.browseNumber - b.browseNumber;
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vPaperCollectionLog]中不存在！(in ${exports.vPaperCollectionLog_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsvPaperCollectionLogEN_js_1.clsvPaperCollectionLogEN.con_PaperCollectionLogId:
                    return (a, b) => {
                        return b.paperCollectionLogId - a.paperCollectionLogId;
                    };
                case clsvPaperCollectionLogEN_js_1.clsvPaperCollectionLogEN.con_PaperId:
                    return (a, b) => {
                        if (b.paperId == null)
                            return -1;
                        if (a.paperId == null)
                            return 1;
                        return b.paperId.localeCompare(a.paperId);
                    };
                case clsvPaperCollectionLogEN_js_1.clsvPaperCollectionLogEN.con_UpdUser:
                    return (a, b) => {
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsvPaperCollectionLogEN_js_1.clsvPaperCollectionLogEN.con_UpdDate:
                    return (a, b) => {
                        if (b.updDate == null)
                            return -1;
                        if (a.updDate == null)
                            return 1;
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsvPaperCollectionLogEN_js_1.clsvPaperCollectionLogEN.con_Meno:
                    return (a, b) => {
                        if (b.meno == null)
                            return -1;
                        if (a.meno == null)
                            return 1;
                        return b.meno.localeCompare(a.meno);
                    };
                case clsvPaperCollectionLogEN_js_1.clsvPaperCollectionLogEN.con_PaperTitle:
                    return (a, b) => {
                        if (b.paperTitle == null)
                            return -1;
                        if (a.paperTitle == null)
                            return 1;
                        return b.paperTitle.localeCompare(a.paperTitle);
                    };
                case clsvPaperCollectionLogEN_js_1.clsvPaperCollectionLogEN.con_Author:
                    return (a, b) => {
                        if (b.author == null)
                            return -1;
                        if (a.author == null)
                            return 1;
                        return b.author.localeCompare(a.author);
                    };
                case clsvPaperCollectionLogEN_js_1.clsvPaperCollectionLogEN.con_Keyword:
                    return (a, b) => {
                        if (b.keyword == null)
                            return -1;
                        if (a.keyword == null)
                            return 1;
                        return b.keyword.localeCompare(a.keyword);
                    };
                case clsvPaperCollectionLogEN_js_1.clsvPaperCollectionLogEN.con_BrowseNumber:
                    return (a, b) => {
                        return b.browseNumber - a.browseNumber;
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vPaperCollectionLog]中不存在！(in ${exports.vPaperCollectionLog_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.vPaperCollectionLog_SortFunByKey = vPaperCollectionLog_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function vPaperCollectionLog_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsvPaperCollectionLogEN_js_1.clsvPaperCollectionLogEN.con_PaperCollectionLogId:
                return (obj) => {
                    return obj.paperCollectionLogId === value;
                };
            case clsvPaperCollectionLogEN_js_1.clsvPaperCollectionLogEN.con_PaperId:
                return (obj) => {
                    return obj.paperId === value;
                };
            case clsvPaperCollectionLogEN_js_1.clsvPaperCollectionLogEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsvPaperCollectionLogEN_js_1.clsvPaperCollectionLogEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsvPaperCollectionLogEN_js_1.clsvPaperCollectionLogEN.con_Meno:
                return (obj) => {
                    return obj.meno === value;
                };
            case clsvPaperCollectionLogEN_js_1.clsvPaperCollectionLogEN.con_PaperTitle:
                return (obj) => {
                    return obj.paperTitle === value;
                };
            case clsvPaperCollectionLogEN_js_1.clsvPaperCollectionLogEN.con_Author:
                return (obj) => {
                    return obj.author === value;
                };
            case clsvPaperCollectionLogEN_js_1.clsvPaperCollectionLogEN.con_Keyword:
                return (obj) => {
                    return obj.keyword === value;
                };
            case clsvPaperCollectionLogEN_js_1.clsvPaperCollectionLogEN.con_BrowseNumber:
                return (obj) => {
                    return obj.browseNumber === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[vPaperCollectionLog]中不存在！(in ${exports.vPaperCollectionLog_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.vPaperCollectionLog_FilterFunByKey = vPaperCollectionLog_FilterFunByKey;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function vPaperCollectionLog_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperCollectionLog_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperCollectionLog_GetFirstIDAsync = vPaperCollectionLog_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function vPaperCollectionLog_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperCollectionLog_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperCollectionLog_GetFirstID = vPaperCollectionLog_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function vPaperCollectionLog_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperCollectionLog_Controller, strAction);
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
                const objvPaperCollectionLog = vPaperCollectionLog_GetObjFromJsonObj(returnObj);
                return objvPaperCollectionLog;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperCollectionLog_GetFirstObjAsync = vPaperCollectionLog_GetFirstObjAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function vPaperCollectionLog_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperCollectionLog_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vPaperCollectionLog_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vPaperCollectionLog_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperCollectionLog_GetObjLstAsync = vPaperCollectionLog_GetObjLstAsync;
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
    async function vPaperCollectionLog_GetObjLstByPaperCollectionLogIdLstAsync(arrPaperCollectionLogId) {
        const strThisFuncName = "GetObjLstByPaperCollectionLogIdLstAsync";
        const strAction = "GetObjLstByPaperCollectionLogIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperCollectionLog_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrPaperCollectionLogId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vPaperCollectionLog_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vPaperCollectionLog_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperCollectionLog_GetObjLstByPaperCollectionLogIdLstAsync = vPaperCollectionLog_GetObjLstByPaperCollectionLogIdLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function vPaperCollectionLog_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperCollectionLog_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vPaperCollectionLog_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vPaperCollectionLog_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperCollectionLog_GetTopObjLstAsync = vPaperCollectionLog_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vPaperCollectionLog_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperCollectionLog_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vPaperCollectionLog_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vPaperCollectionLog_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperCollectionLog_GetObjLstByRangeAsync = vPaperCollectionLog_GetObjLstByRangeAsync;
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
    async function vPaperCollectionLog_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperCollectionLog_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperCollectionLog_GetObjLstByRange = vPaperCollectionLog_GetObjLstByRange;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vPaperCollectionLog_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperCollectionLog_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vPaperCollectionLog_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vPaperCollectionLog_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperCollectionLog_GetObjLstByPagerAsync = vPaperCollectionLog_GetObjLstByPagerAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function vPaperCollectionLog_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperCollectionLog_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperCollectionLog_IsExistRecordAsync = vPaperCollectionLog_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param lngPaperCollectionLogId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function vPaperCollectionLog_IsExist(lngPaperCollectionLogId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperCollectionLog_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperCollectionLog_IsExist = vPaperCollectionLog_IsExist;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param lngPaperCollectionLogId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function vPaperCollectionLog_IsExistAsync(lngPaperCollectionLogId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperCollectionLog_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperCollectionLog_IsExistAsync = vPaperCollectionLog_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function vPaperCollectionLog_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperCollectionLog_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperCollectionLog_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperCollectionLog_GetRecCountByCondAsync = vPaperCollectionLog_GetRecCountByCondAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function vPaperCollectionLog_GetWebApiUrl(strController, strAction) {
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
    exports.vPaperCollectionLog_GetWebApiUrl = vPaperCollectionLog_GetWebApiUrl;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vPaperCollectionLog_GetJSONStrByObj(pobjvPaperCollectionLogEN) {
        const strThisFuncName = "GetJSONStrByObj";
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjvPaperCollectionLogEN);
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
    exports.vPaperCollectionLog_GetJSONStrByObj = vPaperCollectionLog_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function vPaperCollectionLog_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrvPaperCollectionLogObjLst = new Array();
        if (strJSON === "") {
            return arrvPaperCollectionLogObjLst;
        }
        try {
            arrvPaperCollectionLogObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrvPaperCollectionLogObjLst;
        }
        return arrvPaperCollectionLogObjLst;
    }
    exports.vPaperCollectionLog_GetObjLstByJSONStr = vPaperCollectionLog_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrvPaperCollectionLogObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function vPaperCollectionLog_GetObjLstByJSONObjLst(arrvPaperCollectionLogObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrvPaperCollectionLogObjLst = new Array();
        for (const objInFor of arrvPaperCollectionLogObjLstS) {
            const obj1 = vPaperCollectionLog_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrvPaperCollectionLogObjLst.push(obj1);
        }
        return arrvPaperCollectionLogObjLst;
    }
    exports.vPaperCollectionLog_GetObjLstByJSONObjLst = vPaperCollectionLog_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vPaperCollectionLog_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjvPaperCollectionLogEN = new clsvPaperCollectionLogEN_js_1.clsvPaperCollectionLogEN();
        if (strJSON === "") {
            return pobjvPaperCollectionLogEN;
        }
        try {
            pobjvPaperCollectionLogEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjvPaperCollectionLogEN;
        }
        return pobjvPaperCollectionLogEN;
    }
    exports.vPaperCollectionLog_GetObjByJSONStr = vPaperCollectionLog_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function vPaperCollectionLog_GetCombineCondition(objvPaperCollectionLog_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objvPaperCollectionLog_Cond.dicFldComparisonOp, clsvPaperCollectionLogEN_js_1.clsvPaperCollectionLogEN.con_PaperCollectionLogId) == true) {
            const strComparisonOp_PaperCollectionLogId = objvPaperCollectionLog_Cond.dicFldComparisonOp[clsvPaperCollectionLogEN_js_1.clsvPaperCollectionLogEN.con_PaperCollectionLogId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvPaperCollectionLogEN_js_1.clsvPaperCollectionLogEN.con_PaperCollectionLogId, objvPaperCollectionLog_Cond.paperCollectionLogId, strComparisonOp_PaperCollectionLogId);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperCollectionLog_Cond.dicFldComparisonOp, clsvPaperCollectionLogEN_js_1.clsvPaperCollectionLogEN.con_PaperId) == true) {
            const strComparisonOp_PaperId = objvPaperCollectionLog_Cond.dicFldComparisonOp[clsvPaperCollectionLogEN_js_1.clsvPaperCollectionLogEN.con_PaperId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperCollectionLogEN_js_1.clsvPaperCollectionLogEN.con_PaperId, objvPaperCollectionLog_Cond.paperId, strComparisonOp_PaperId);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperCollectionLog_Cond.dicFldComparisonOp, clsvPaperCollectionLogEN_js_1.clsvPaperCollectionLogEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objvPaperCollectionLog_Cond.dicFldComparisonOp[clsvPaperCollectionLogEN_js_1.clsvPaperCollectionLogEN.con_UpdUser];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperCollectionLogEN_js_1.clsvPaperCollectionLogEN.con_UpdUser, objvPaperCollectionLog_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperCollectionLog_Cond.dicFldComparisonOp, clsvPaperCollectionLogEN_js_1.clsvPaperCollectionLogEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objvPaperCollectionLog_Cond.dicFldComparisonOp[clsvPaperCollectionLogEN_js_1.clsvPaperCollectionLogEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperCollectionLogEN_js_1.clsvPaperCollectionLogEN.con_UpdDate, objvPaperCollectionLog_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperCollectionLog_Cond.dicFldComparisonOp, clsvPaperCollectionLogEN_js_1.clsvPaperCollectionLogEN.con_Meno) == true) {
            const strComparisonOp_Meno = objvPaperCollectionLog_Cond.dicFldComparisonOp[clsvPaperCollectionLogEN_js_1.clsvPaperCollectionLogEN.con_Meno];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperCollectionLogEN_js_1.clsvPaperCollectionLogEN.con_Meno, objvPaperCollectionLog_Cond.meno, strComparisonOp_Meno);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperCollectionLog_Cond.dicFldComparisonOp, clsvPaperCollectionLogEN_js_1.clsvPaperCollectionLogEN.con_PaperTitle) == true) {
            const strComparisonOp_PaperTitle = objvPaperCollectionLog_Cond.dicFldComparisonOp[clsvPaperCollectionLogEN_js_1.clsvPaperCollectionLogEN.con_PaperTitle];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperCollectionLogEN_js_1.clsvPaperCollectionLogEN.con_PaperTitle, objvPaperCollectionLog_Cond.paperTitle, strComparisonOp_PaperTitle);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperCollectionLog_Cond.dicFldComparisonOp, clsvPaperCollectionLogEN_js_1.clsvPaperCollectionLogEN.con_Author) == true) {
            const strComparisonOp_Author = objvPaperCollectionLog_Cond.dicFldComparisonOp[clsvPaperCollectionLogEN_js_1.clsvPaperCollectionLogEN.con_Author];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperCollectionLogEN_js_1.clsvPaperCollectionLogEN.con_Author, objvPaperCollectionLog_Cond.author, strComparisonOp_Author);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperCollectionLog_Cond.dicFldComparisonOp, clsvPaperCollectionLogEN_js_1.clsvPaperCollectionLogEN.con_Keyword) == true) {
            const strComparisonOp_Keyword = objvPaperCollectionLog_Cond.dicFldComparisonOp[clsvPaperCollectionLogEN_js_1.clsvPaperCollectionLogEN.con_Keyword];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperCollectionLogEN_js_1.clsvPaperCollectionLogEN.con_Keyword, objvPaperCollectionLog_Cond.keyword, strComparisonOp_Keyword);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperCollectionLog_Cond.dicFldComparisonOp, clsvPaperCollectionLogEN_js_1.clsvPaperCollectionLogEN.con_BrowseNumber) == true) {
            const strComparisonOp_BrowseNumber = objvPaperCollectionLog_Cond.dicFldComparisonOp[clsvPaperCollectionLogEN_js_1.clsvPaperCollectionLogEN.con_BrowseNumber];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvPaperCollectionLogEN_js_1.clsvPaperCollectionLogEN.con_BrowseNumber, objvPaperCollectionLog_Cond.browseNumber, strComparisonOp_BrowseNumber);
        }
        return strWhereCond;
    }
    exports.vPaperCollectionLog_GetCombineCondition = vPaperCollectionLog_GetCombineCondition;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objvPaperCollectionLogENS:源对象
     * @param objvPaperCollectionLogENT:目标对象
    */
    function vPaperCollectionLog_CopyObjTo(objvPaperCollectionLogENS, objvPaperCollectionLogENT) {
        objvPaperCollectionLogENT.paperCollectionLogId = objvPaperCollectionLogENS.paperCollectionLogId; //论文收藏Id
        objvPaperCollectionLogENT.paperId = objvPaperCollectionLogENS.paperId; //论文Id
        objvPaperCollectionLogENT.updUser = objvPaperCollectionLogENS.updUser; //修改人
        objvPaperCollectionLogENT.updDate = objvPaperCollectionLogENS.updDate; //修改日期
        objvPaperCollectionLogENT.meno = objvPaperCollectionLogENS.meno; //备注
        objvPaperCollectionLogENT.paperTitle = objvPaperCollectionLogENS.paperTitle; //论文标题
        objvPaperCollectionLogENT.author = objvPaperCollectionLogENS.author; //作者
        objvPaperCollectionLogENT.keyword = objvPaperCollectionLogENS.keyword; //关键字
        objvPaperCollectionLogENT.browseNumber = objvPaperCollectionLogENS.browseNumber; //浏览量
    }
    exports.vPaperCollectionLog_CopyObjTo = vPaperCollectionLog_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objvPaperCollectionLogENS:源对象
     * @param objvPaperCollectionLogENT:目标对象
    */
    function vPaperCollectionLog_GetObjFromJsonObj(objvPaperCollectionLogENS) {
        const objvPaperCollectionLogENT = new clsvPaperCollectionLogEN_js_1.clsvPaperCollectionLogEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvPaperCollectionLogENT, objvPaperCollectionLogENS);
        return objvPaperCollectionLogENT;
    }
    exports.vPaperCollectionLog_GetObjFromJsonObj = vPaperCollectionLog_GetObjFromJsonObj;
});
