/**
* 类名:clsvPaperSubAttachmentWApi
* 表名:vPaperSubAttachment(01120598)
* 生成代码版本:2022.11.02.1
* 生成日期:2022/11/02 11:46:41
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
        define(["require", "exports", "axios", "../../L0_Entity/GraduateEduPaper/clsvPaperSubAttachmentEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsSysPara4WebApi.js", "../../PubFun/jsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.vPaperSubAttachment_GetObjFromJsonObj = exports.vPaperSubAttachment_CopyObjTo = exports.vPaperSubAttachment_GetUniCondStr4Update_PaperSubAttachmentId_SubViewpointId = exports.vPaperSubAttachment_GetUniCondStr_PaperSubAttachmentId_SubViewpointId = exports.vPaperSubAttachment_GetCombineCondition = exports.vPaperSubAttachment_GetObjByJSONStr = exports.vPaperSubAttachment_GetObjLstByJSONObjLst = exports.vPaperSubAttachment_GetObjLstByJSONStr = exports.vPaperSubAttachment_GetJSONStrByObj = exports.vPaperSubAttachment_CheckProperty4Update = exports.vPaperSubAttachment_CheckPropertyNew = exports.vPaperSubAttachment_GetWebApiUrl = exports.vPaperSubAttachment_GetMaxStrIdByPrefix = exports.vPaperSubAttachment_GetRecCountByCondAsync = exports.vPaperSubAttachment_IsExistAsync = exports.vPaperSubAttachment_IsExist = exports.vPaperSubAttachment_IsExistRecordAsync = exports.vPaperSubAttachment_UpdateWithConditionAsync = exports.vPaperSubAttachment_UpdateRecordAsync = exports.vPaperSubAttachment_AddNewRecordWithReturnKey = exports.vPaperSubAttachment_AddNewRecordWithReturnKeyAsync = exports.vPaperSubAttachment_AddNewRecordAsync = exports.vPaperSubAttachment_DelvPaperSubAttachmentsByCondAsync = exports.vPaperSubAttachment_DelvPaperSubAttachmentsAsync = exports.vPaperSubAttachment_DelRecordAsync = exports.vPaperSubAttachment_GetObjLstByPagerAsync = exports.vPaperSubAttachment_GetObjLstByRange = exports.vPaperSubAttachment_GetObjLstByRangeAsync = exports.vPaperSubAttachment_GetTopObjLstAsync = exports.vPaperSubAttachment_GetObjLstByPaperSubAttachmentIdLstAsync = exports.vPaperSubAttachment_GetObjLstAsync = exports.vPaperSubAttachment_GetFirstObjAsync = exports.vPaperSubAttachment_GetFirstID = exports.vPaperSubAttachment_GetFirstIDAsync = exports.vPaperSubAttachment_FilterFunByKey = exports.vPaperSubAttachment_SortFunByKey = exports.vPaperSubAttachment_SortFun_Defa_2Fld = exports.vPaperSubAttachment_SortFun_Defa = exports.vPaperSubAttachment_GetObjByPaperSubAttachmentIdAsync = exports.vPaperSubAttachment_ConstructorName = exports.vPaperSubAttachment_Controller = void 0;
    /**
     * 子观点附件(vPaperSubAttachment)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2022年11月02日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const clsvPaperSubAttachmentEN_js_1 = require("../../L0_Entity/GraduateEduPaper/clsvPaperSubAttachmentEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    const jsString_js_1 = require("../../PubFun/jsString.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.vPaperSubAttachment_Controller = "vPaperSubAttachmentApi";
    exports.vPaperSubAttachment_ConstructorName = "vPaperSubAttachment";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param lngPaperSubAttachmentId:关键字
    * @returns 对象
    **/
    async function vPaperSubAttachment_GetObjByPaperSubAttachmentIdAsync(lngPaperSubAttachmentId) {
        const strThisFuncName = "GetObjByPaperSubAttachmentIdAsync";
        if (lngPaperSubAttachmentId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngPaperSubAttachmentId]不能为空！(In GetObjByPaperSubAttachmentIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByPaperSubAttachmentId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperSubAttachment_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "lngPaperSubAttachmentId": lngPaperSubAttachmentId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vPaperSubAttachment_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objvPaperSubAttachment = vPaperSubAttachment_GetObjFromJsonObj(returnObj);
                return objvPaperSubAttachment;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperSubAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperSubAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperSubAttachment_GetObjByPaperSubAttachmentIdAsync = vPaperSubAttachment_GetObjByPaperSubAttachmentIdAsync;
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
    function vPaperSubAttachment_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.paperSubAttachmentId - b.paperSubAttachmentId;
    }
    exports.vPaperSubAttachment_SortFun_Defa = vPaperSubAttachment_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vPaperSubAttachment_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.explainContent == b.explainContent)
            return a.filePath.localeCompare(b.filePath);
        else
            return a.explainContent.localeCompare(b.explainContent);
    }
    exports.vPaperSubAttachment_SortFun_Defa_2Fld = vPaperSubAttachment_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vPaperSubAttachment_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsvPaperSubAttachmentEN_js_1.clsvPaperSubAttachmentEN.con_ExplainContent:
                    return (a, b) => {
                        return a.explainContent.localeCompare(b.explainContent);
                    };
                case clsvPaperSubAttachmentEN_js_1.clsvPaperSubAttachmentEN.con_FilePath:
                    return (a, b) => {
                        return a.filePath.localeCompare(b.filePath);
                    };
                case clsvPaperSubAttachmentEN_js_1.clsvPaperSubAttachmentEN.con_Memo:
                    return (a, b) => {
                        return a.memo.localeCompare(b.memo);
                    };
                case clsvPaperSubAttachmentEN_js_1.clsvPaperSubAttachmentEN.con_PaperRWId:
                    return (a, b) => {
                        return a.paperRWId.localeCompare(b.paperRWId);
                    };
                case clsvPaperSubAttachmentEN_js_1.clsvPaperSubAttachmentEN.con_PaperSubAttachmentName:
                    return (a, b) => {
                        return a.paperSubAttachmentName.localeCompare(b.paperSubAttachmentName);
                    };
                case clsvPaperSubAttachmentEN_js_1.clsvPaperSubAttachmentEN.con_RWTitle:
                    return (a, b) => {
                        return a.rwTitle.localeCompare(b.rwTitle);
                    };
                case clsvPaperSubAttachmentEN_js_1.clsvPaperSubAttachmentEN.con_SubViewpointContent:
                    return (a, b) => {
                        return a.subViewpointContent.localeCompare(b.subViewpointContent);
                    };
                case clsvPaperSubAttachmentEN_js_1.clsvPaperSubAttachmentEN.con_SubViewpointId:
                    return (a, b) => {
                        return a.subViewpointId - b.subViewpointId;
                    };
                case clsvPaperSubAttachmentEN_js_1.clsvPaperSubAttachmentEN.con_UpdDate:
                    return (a, b) => {
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsvPaperSubAttachmentEN_js_1.clsvPaperSubAttachmentEN.con_UpdUserId:
                    return (a, b) => {
                        return a.updUserId.localeCompare(b.updUserId);
                    };
                case clsvPaperSubAttachmentEN_js_1.clsvPaperSubAttachmentEN.con_PaperSubAttachmentId:
                    return (a, b) => {
                        return a.paperSubAttachmentId - b.paperSubAttachmentId;
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vPaperSubAttachment]中不存在！(in ${exports.vPaperSubAttachment_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsvPaperSubAttachmentEN_js_1.clsvPaperSubAttachmentEN.con_ExplainContent:
                    return (a, b) => {
                        return b.explainContent.localeCompare(a.explainContent);
                    };
                case clsvPaperSubAttachmentEN_js_1.clsvPaperSubAttachmentEN.con_FilePath:
                    return (a, b) => {
                        return b.filePath.localeCompare(a.filePath);
                    };
                case clsvPaperSubAttachmentEN_js_1.clsvPaperSubAttachmentEN.con_Memo:
                    return (a, b) => {
                        return b.memo.localeCompare(a.memo);
                    };
                case clsvPaperSubAttachmentEN_js_1.clsvPaperSubAttachmentEN.con_PaperRWId:
                    return (a, b) => {
                        return b.paperRWId.localeCompare(a.paperRWId);
                    };
                case clsvPaperSubAttachmentEN_js_1.clsvPaperSubAttachmentEN.con_PaperSubAttachmentName:
                    return (a, b) => {
                        return b.paperSubAttachmentName.localeCompare(a.paperSubAttachmentName);
                    };
                case clsvPaperSubAttachmentEN_js_1.clsvPaperSubAttachmentEN.con_RWTitle:
                    return (a, b) => {
                        return b.rwTitle.localeCompare(a.rwTitle);
                    };
                case clsvPaperSubAttachmentEN_js_1.clsvPaperSubAttachmentEN.con_SubViewpointContent:
                    return (a, b) => {
                        return b.subViewpointContent.localeCompare(a.subViewpointContent);
                    };
                case clsvPaperSubAttachmentEN_js_1.clsvPaperSubAttachmentEN.con_SubViewpointId:
                    return (a, b) => {
                        return b.subViewpointId - a.subViewpointId;
                    };
                case clsvPaperSubAttachmentEN_js_1.clsvPaperSubAttachmentEN.con_UpdDate:
                    return (a, b) => {
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsvPaperSubAttachmentEN_js_1.clsvPaperSubAttachmentEN.con_UpdUserId:
                    return (a, b) => {
                        return b.updUserId.localeCompare(a.updUserId);
                    };
                case clsvPaperSubAttachmentEN_js_1.clsvPaperSubAttachmentEN.con_PaperSubAttachmentId:
                    return (a, b) => {
                        return b.paperSubAttachmentId - a.paperSubAttachmentId;
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vPaperSubAttachment]中不存在！(in ${exports.vPaperSubAttachment_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.vPaperSubAttachment_SortFunByKey = vPaperSubAttachment_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function vPaperSubAttachment_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsvPaperSubAttachmentEN_js_1.clsvPaperSubAttachmentEN.con_ExplainContent:
                return (obj) => {
                    return obj.explainContent === value;
                };
            case clsvPaperSubAttachmentEN_js_1.clsvPaperSubAttachmentEN.con_FilePath:
                return (obj) => {
                    return obj.filePath === value;
                };
            case clsvPaperSubAttachmentEN_js_1.clsvPaperSubAttachmentEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            case clsvPaperSubAttachmentEN_js_1.clsvPaperSubAttachmentEN.con_PaperRWId:
                return (obj) => {
                    return obj.paperRWId === value;
                };
            case clsvPaperSubAttachmentEN_js_1.clsvPaperSubAttachmentEN.con_PaperSubAttachmentName:
                return (obj) => {
                    return obj.paperSubAttachmentName === value;
                };
            case clsvPaperSubAttachmentEN_js_1.clsvPaperSubAttachmentEN.con_RWTitle:
                return (obj) => {
                    return obj.rwTitle === value;
                };
            case clsvPaperSubAttachmentEN_js_1.clsvPaperSubAttachmentEN.con_SubViewpointContent:
                return (obj) => {
                    return obj.subViewpointContent === value;
                };
            case clsvPaperSubAttachmentEN_js_1.clsvPaperSubAttachmentEN.con_SubViewpointId:
                return (obj) => {
                    return obj.subViewpointId === value;
                };
            case clsvPaperSubAttachmentEN_js_1.clsvPaperSubAttachmentEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsvPaperSubAttachmentEN_js_1.clsvPaperSubAttachmentEN.con_UpdUserId:
                return (obj) => {
                    return obj.updUserId === value;
                };
            case clsvPaperSubAttachmentEN_js_1.clsvPaperSubAttachmentEN.con_PaperSubAttachmentId:
                return (obj) => {
                    return obj.paperSubAttachmentId === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[vPaperSubAttachment]中不存在！(in ${exports.vPaperSubAttachment_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.vPaperSubAttachment_FilterFunByKey = vPaperSubAttachment_FilterFunByKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function vPaperSubAttachment_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperSubAttachment_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperSubAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperSubAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperSubAttachment_GetFirstIDAsync = vPaperSubAttachment_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function vPaperSubAttachment_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperSubAttachment_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperSubAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperSubAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperSubAttachment_GetFirstID = vPaperSubAttachment_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function vPaperSubAttachment_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperSubAttachment_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vPaperSubAttachment_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objvPaperSubAttachment = vPaperSubAttachment_GetObjFromJsonObj(returnObj);
                return objvPaperSubAttachment;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperSubAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperSubAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperSubAttachment_GetFirstObjAsync = vPaperSubAttachment_GetFirstObjAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function vPaperSubAttachment_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperSubAttachment_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vPaperSubAttachment_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vPaperSubAttachment_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperSubAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperSubAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperSubAttachment_GetObjLstAsync = vPaperSubAttachment_GetObjLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrPaperSubAttachmentId:关键字列表
    * @returns 对象列表
    **/
    async function vPaperSubAttachment_GetObjLstByPaperSubAttachmentIdLstAsync(arrPaperSubAttachmentId) {
        const strThisFuncName = "GetObjLstByPaperSubAttachmentIdLstAsync";
        const strAction = "GetObjLstByPaperSubAttachmentIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperSubAttachment_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrPaperSubAttachmentId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vPaperSubAttachment_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vPaperSubAttachment_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperSubAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperSubAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperSubAttachment_GetObjLstByPaperSubAttachmentIdLstAsync = vPaperSubAttachment_GetObjLstByPaperSubAttachmentIdLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function vPaperSubAttachment_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperSubAttachment_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vPaperSubAttachment_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vPaperSubAttachment_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperSubAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperSubAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperSubAttachment_GetTopObjLstAsync = vPaperSubAttachment_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vPaperSubAttachment_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperSubAttachment_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vPaperSubAttachment_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vPaperSubAttachment_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperSubAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperSubAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperSubAttachment_GetObjLstByRangeAsync = vPaperSubAttachment_GetObjLstByRangeAsync;
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
    async function vPaperSubAttachment_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperSubAttachment_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperSubAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperSubAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperSubAttachment_GetObjLstByRange = vPaperSubAttachment_GetObjLstByRange;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vPaperSubAttachment_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperSubAttachment_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vPaperSubAttachment_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vPaperSubAttachment_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperSubAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperSubAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperSubAttachment_GetObjLstByPagerAsync = vPaperSubAttachment_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param lngPaperSubAttachmentId:关键字
    * @returns 获取删除的结果
    **/
    async function vPaperSubAttachment_DelRecordAsync(lngPaperSubAttachmentId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperSubAttachment_Controller, strAction);
        strUrl = (0, clsString_js_1.Format)("{0}/?Id={1}", strUrl, lngPaperSubAttachmentId);
        try {
            const response = await axios_1.default.delete(strUrl, {
                params: { "Id": lngPaperSubAttachmentId, }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperSubAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperSubAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperSubAttachment_DelRecordAsync = vPaperSubAttachment_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrPaperSubAttachmentId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function vPaperSubAttachment_DelvPaperSubAttachmentsAsync(arrPaperSubAttachmentId) {
        const strThisFuncName = "DelvPaperSubAttachmentsAsync";
        const strAction = "DelvPaperSubAttachments";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperSubAttachment_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrPaperSubAttachmentId);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperSubAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperSubAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperSubAttachment_DelvPaperSubAttachmentsAsync = vPaperSubAttachment_DelvPaperSubAttachmentsAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function vPaperSubAttachment_DelvPaperSubAttachmentsByCondAsync(strWhereCond) {
        const strThisFuncName = "DelvPaperSubAttachmentsByCondAsync";
        const strAction = "DelvPaperSubAttachmentsByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperSubAttachment_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperSubAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperSubAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperSubAttachment_DelvPaperSubAttachmentsByCondAsync = vPaperSubAttachment_DelvPaperSubAttachmentsByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objvPaperSubAttachmentEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function vPaperSubAttachment_AddNewRecordAsync(objvPaperSubAttachmentEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objvPaperSubAttachmentEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperSubAttachment_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objvPaperSubAttachmentEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperSubAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperSubAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperSubAttachment_AddNewRecordAsync = vPaperSubAttachment_AddNewRecordAsync;
    /* 数据类型不是字符型，不可以最大关键字的方式添加记录。*/
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objvPaperSubAttachmentEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function vPaperSubAttachment_AddNewRecordWithReturnKeyAsync(objvPaperSubAttachmentEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperSubAttachment_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objvPaperSubAttachmentEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperSubAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperSubAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperSubAttachment_AddNewRecordWithReturnKeyAsync = vPaperSubAttachment_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objvPaperSubAttachmentEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function vPaperSubAttachment_AddNewRecordWithReturnKey(objvPaperSubAttachmentEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objvPaperSubAttachmentEN.paperSubAttachmentId === null || objvPaperSubAttachmentEN.paperSubAttachmentId === 0) {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperSubAttachment_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objvPaperSubAttachmentEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperSubAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperSubAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperSubAttachment_AddNewRecordWithReturnKey = vPaperSubAttachment_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objvPaperSubAttachmentEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function vPaperSubAttachment_UpdateRecordAsync(objvPaperSubAttachmentEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objvPaperSubAttachmentEN.sf_UpdFldSetStr === undefined || objvPaperSubAttachmentEN.sf_UpdFldSetStr === null || objvPaperSubAttachmentEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objvPaperSubAttachmentEN.paperSubAttachmentId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperSubAttachment_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objvPaperSubAttachmentEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperSubAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperSubAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperSubAttachment_UpdateRecordAsync = vPaperSubAttachment_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objvPaperSubAttachmentEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function vPaperSubAttachment_UpdateWithConditionAsync(objvPaperSubAttachmentEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objvPaperSubAttachmentEN.sf_UpdFldSetStr === undefined || objvPaperSubAttachmentEN.sf_UpdFldSetStr === null || objvPaperSubAttachmentEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objvPaperSubAttachmentEN.paperSubAttachmentId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperSubAttachment_Controller, strAction);
        objvPaperSubAttachmentEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objvPaperSubAttachmentEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperSubAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperSubAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperSubAttachment_UpdateWithConditionAsync = vPaperSubAttachment_UpdateWithConditionAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function vPaperSubAttachment_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperSubAttachment_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperSubAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperSubAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperSubAttachment_IsExistRecordAsync = vPaperSubAttachment_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param lngPaperSubAttachmentId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function vPaperSubAttachment_IsExist(lngPaperSubAttachmentId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperSubAttachment_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "PaperSubAttachmentId": lngPaperSubAttachmentId,
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperSubAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperSubAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperSubAttachment_IsExist = vPaperSubAttachment_IsExist;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param lngPaperSubAttachmentId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function vPaperSubAttachment_IsExistAsync(lngPaperSubAttachmentId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperSubAttachment_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "lngPaperSubAttachmentId": lngPaperSubAttachmentId }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperSubAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperSubAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperSubAttachment_IsExistAsync = vPaperSubAttachment_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function vPaperSubAttachment_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperSubAttachment_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperSubAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperSubAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperSubAttachment_GetRecCountByCondAsync = vPaperSubAttachment_GetRecCountByCondAsync;
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
    async function vPaperSubAttachment_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperSubAttachment_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperSubAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperSubAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperSubAttachment_GetMaxStrIdByPrefix = vPaperSubAttachment_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function vPaperSubAttachment_GetWebApiUrl(strController, strAction) {
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
    exports.vPaperSubAttachment_GetWebApiUrl = vPaperSubAttachment_GetWebApiUrl;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function vPaperSubAttachment_CheckPropertyNew(pobjvPaperSubAttachmentEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjvPaperSubAttachmentEN.filePath) === true) {
            throw new Error("(errid:Watl000058)字段[文件路径]不能为空(In 子观点附件)!(clsvPaperSubAttachmentBL:CheckPropertyNew)");
        }
        if (null === pobjvPaperSubAttachmentEN.subViewpointId
            || pobjvPaperSubAttachmentEN.subViewpointId != null && pobjvPaperSubAttachmentEN.subViewpointId.toString() === "") {
            throw new Error("(errid:Watl000058)字段[子观点Id]不能为空(In 子观点附件)!(clsvPaperSubAttachmentBL:CheckPropertyNew)");
        }
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjvPaperSubAttachmentEN.explainContent) == false && (0, clsString_js_1.GetStrLen)(pobjvPaperSubAttachmentEN.explainContent) > 5000) {
            throw new Error("(errid:Watl000059)字段[说明内容(explainContent)]的长度不能超过5000(In 子观点附件(vPaperSubAttachment))!值:$(pobjvPaperSubAttachmentEN.explainContent)(clsvPaperSubAttachmentBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjvPaperSubAttachmentEN.filePath) == false && (0, clsString_js_1.GetStrLen)(pobjvPaperSubAttachmentEN.filePath) > 500) {
            throw new Error("(errid:Watl000059)字段[文件路径(filePath)]的长度不能超过500(In 子观点附件(vPaperSubAttachment))!值:$(pobjvPaperSubAttachmentEN.filePath)(clsvPaperSubAttachmentBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjvPaperSubAttachmentEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjvPaperSubAttachmentEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 子观点附件(vPaperSubAttachment))!值:$(pobjvPaperSubAttachmentEN.memo)(clsvPaperSubAttachmentBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjvPaperSubAttachmentEN.paperRWId) == false && (0, clsString_js_1.GetStrLen)(pobjvPaperSubAttachmentEN.paperRWId) > 8) {
            throw new Error("(errid:Watl000059)字段[课文阅读(paperRWId)]的长度不能超过8(In 子观点附件(vPaperSubAttachment))!值:$(pobjvPaperSubAttachmentEN.paperRWId)(clsvPaperSubAttachmentBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjvPaperSubAttachmentEN.paperSubAttachmentName) == false && (0, clsString_js_1.GetStrLen)(pobjvPaperSubAttachmentEN.paperSubAttachmentName) > 200) {
            throw new Error("(errid:Watl000059)字段[附件名称(paperSubAttachmentName)]的长度不能超过200(In 子观点附件(vPaperSubAttachment))!值:$(pobjvPaperSubAttachmentEN.paperSubAttachmentName)(clsvPaperSubAttachmentBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjvPaperSubAttachmentEN.rwTitle) == false && (0, clsString_js_1.GetStrLen)(pobjvPaperSubAttachmentEN.rwTitle) > 50) {
            throw new Error("(errid:Watl000059)字段[读写标题(rwTitle)]的长度不能超过50(In 子观点附件(vPaperSubAttachment))!值:$(pobjvPaperSubAttachmentEN.rwTitle)(clsvPaperSubAttachmentBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjvPaperSubAttachmentEN.updDate) == false && (0, clsString_js_1.GetStrLen)(pobjvPaperSubAttachmentEN.updDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 子观点附件(vPaperSubAttachment))!值:$(pobjvPaperSubAttachmentEN.updDate)(clsvPaperSubAttachmentBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjvPaperSubAttachmentEN.updUserId) == false && (0, clsString_js_1.GetStrLen)(pobjvPaperSubAttachmentEN.updUserId) > 20) {
            throw new Error("(errid:Watl000059)字段[修改用户Id(updUserId)]的长度不能超过20(In 子观点附件(vPaperSubAttachment))!值:$(pobjvPaperSubAttachmentEN.updUserId)(clsvPaperSubAttachmentBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjvPaperSubAttachmentEN.explainContent) == false && undefined !== pobjvPaperSubAttachmentEN.explainContent && jsString_js_1.tzDataType.isString(pobjvPaperSubAttachmentEN.explainContent) === false) {
            throw new Error("(errid:Watl000060)字段[说明内容(explainContent)]的值:[$(pobjvPaperSubAttachmentEN.explainContent)], 非法，应该为字符型(In 子观点附件(vPaperSubAttachment))!(clsvPaperSubAttachmentBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjvPaperSubAttachmentEN.filePath) == false && undefined !== pobjvPaperSubAttachmentEN.filePath && jsString_js_1.tzDataType.isString(pobjvPaperSubAttachmentEN.filePath) === false) {
            throw new Error("(errid:Watl000060)字段[文件路径(filePath)]的值:[$(pobjvPaperSubAttachmentEN.filePath)], 非法，应该为字符型(In 子观点附件(vPaperSubAttachment))!(clsvPaperSubAttachmentBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjvPaperSubAttachmentEN.memo) == false && undefined !== pobjvPaperSubAttachmentEN.memo && jsString_js_1.tzDataType.isString(pobjvPaperSubAttachmentEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjvPaperSubAttachmentEN.memo)], 非法，应该为字符型(In 子观点附件(vPaperSubAttachment))!(clsvPaperSubAttachmentBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjvPaperSubAttachmentEN.paperRWId) == false && undefined !== pobjvPaperSubAttachmentEN.paperRWId && jsString_js_1.tzDataType.isString(pobjvPaperSubAttachmentEN.paperRWId) === false) {
            throw new Error("(errid:Watl000060)字段[课文阅读(paperRWId)]的值:[$(pobjvPaperSubAttachmentEN.paperRWId)], 非法，应该为字符型(In 子观点附件(vPaperSubAttachment))!(clsvPaperSubAttachmentBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjvPaperSubAttachmentEN.paperSubAttachmentName) == false && undefined !== pobjvPaperSubAttachmentEN.paperSubAttachmentName && jsString_js_1.tzDataType.isString(pobjvPaperSubAttachmentEN.paperSubAttachmentName) === false) {
            throw new Error("(errid:Watl000060)字段[附件名称(paperSubAttachmentName)]的值:[$(pobjvPaperSubAttachmentEN.paperSubAttachmentName)], 非法，应该为字符型(In 子观点附件(vPaperSubAttachment))!(clsvPaperSubAttachmentBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjvPaperSubAttachmentEN.rwTitle) == false && undefined !== pobjvPaperSubAttachmentEN.rwTitle && jsString_js_1.tzDataType.isString(pobjvPaperSubAttachmentEN.rwTitle) === false) {
            throw new Error("(errid:Watl000060)字段[读写标题(rwTitle)]的值:[$(pobjvPaperSubAttachmentEN.rwTitle)], 非法，应该为字符型(In 子观点附件(vPaperSubAttachment))!(clsvPaperSubAttachmentBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjvPaperSubAttachmentEN.subViewpointContent) == false && undefined !== pobjvPaperSubAttachmentEN.subViewpointContent && jsString_js_1.tzDataType.isString(pobjvPaperSubAttachmentEN.subViewpointContent) === false) {
            throw new Error("(errid:Watl000060)字段[详情内容(subViewpointContent)]的值:[$(pobjvPaperSubAttachmentEN.subViewpointContent)], 非法，应该为字符型(In 子观点附件(vPaperSubAttachment))!(clsvPaperSubAttachmentBL:CheckPropertyNew)");
        }
        if (null != pobjvPaperSubAttachmentEN.subViewpointId && undefined !== pobjvPaperSubAttachmentEN.subViewpointId && jsString_js_1.tzDataType.isNumber(pobjvPaperSubAttachmentEN.subViewpointId) === false) {
            throw new Error("(errid:Watl000060)字段[子观点Id(subViewpointId)]的值:[$(pobjvPaperSubAttachmentEN.subViewpointId)], 非法，应该为数值型(In 子观点附件(vPaperSubAttachment))!(clsvPaperSubAttachmentBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjvPaperSubAttachmentEN.updDate) == false && undefined !== pobjvPaperSubAttachmentEN.updDate && jsString_js_1.tzDataType.isString(pobjvPaperSubAttachmentEN.updDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjvPaperSubAttachmentEN.updDate)], 非法，应该为字符型(In 子观点附件(vPaperSubAttachment))!(clsvPaperSubAttachmentBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjvPaperSubAttachmentEN.updUserId) == false && undefined !== pobjvPaperSubAttachmentEN.updUserId && jsString_js_1.tzDataType.isString(pobjvPaperSubAttachmentEN.updUserId) === false) {
            throw new Error("(errid:Watl000060)字段[修改用户Id(updUserId)]的值:[$(pobjvPaperSubAttachmentEN.updUserId)], 非法，应该为字符型(In 子观点附件(vPaperSubAttachment))!(clsvPaperSubAttachmentBL:CheckPropertyNew)");
        }
        if (null != pobjvPaperSubAttachmentEN.paperSubAttachmentId && undefined !== pobjvPaperSubAttachmentEN.paperSubAttachmentId && jsString_js_1.tzDataType.isNumber(pobjvPaperSubAttachmentEN.paperSubAttachmentId) === false) {
            throw new Error("(errid:Watl000060)字段[子观点附件Id(paperSubAttachmentId)]的值:[$(pobjvPaperSubAttachmentEN.paperSubAttachmentId)], 非法，应该为数值型(In 子观点附件(vPaperSubAttachment))!(clsvPaperSubAttachmentBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjvPaperSubAttachmentEN.SetIsCheckProperty(true);
    }
    exports.vPaperSubAttachment_CheckPropertyNew = vPaperSubAttachment_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function vPaperSubAttachment_CheckProperty4Update(pobjvPaperSubAttachmentEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjvPaperSubAttachmentEN.explainContent) == false && (0, clsString_js_1.GetStrLen)(pobjvPaperSubAttachmentEN.explainContent) > 5000) {
            throw new Error("(errid:Watl000062)字段[说明内容(explainContent)]的长度不能超过5000(In 子观点附件(vPaperSubAttachment))!值:$(pobjvPaperSubAttachmentEN.explainContent)(clsvPaperSubAttachmentBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjvPaperSubAttachmentEN.filePath) == false && (0, clsString_js_1.GetStrLen)(pobjvPaperSubAttachmentEN.filePath) > 500) {
            throw new Error("(errid:Watl000062)字段[文件路径(filePath)]的长度不能超过500(In 子观点附件(vPaperSubAttachment))!值:$(pobjvPaperSubAttachmentEN.filePath)(clsvPaperSubAttachmentBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjvPaperSubAttachmentEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjvPaperSubAttachmentEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 子观点附件(vPaperSubAttachment))!值:$(pobjvPaperSubAttachmentEN.memo)(clsvPaperSubAttachmentBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjvPaperSubAttachmentEN.paperRWId) == false && (0, clsString_js_1.GetStrLen)(pobjvPaperSubAttachmentEN.paperRWId) > 8) {
            throw new Error("(errid:Watl000062)字段[课文阅读(paperRWId)]的长度不能超过8(In 子观点附件(vPaperSubAttachment))!值:$(pobjvPaperSubAttachmentEN.paperRWId)(clsvPaperSubAttachmentBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjvPaperSubAttachmentEN.paperSubAttachmentName) == false && (0, clsString_js_1.GetStrLen)(pobjvPaperSubAttachmentEN.paperSubAttachmentName) > 200) {
            throw new Error("(errid:Watl000062)字段[附件名称(paperSubAttachmentName)]的长度不能超过200(In 子观点附件(vPaperSubAttachment))!值:$(pobjvPaperSubAttachmentEN.paperSubAttachmentName)(clsvPaperSubAttachmentBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjvPaperSubAttachmentEN.rwTitle) == false && (0, clsString_js_1.GetStrLen)(pobjvPaperSubAttachmentEN.rwTitle) > 50) {
            throw new Error("(errid:Watl000062)字段[读写标题(rwTitle)]的长度不能超过50(In 子观点附件(vPaperSubAttachment))!值:$(pobjvPaperSubAttachmentEN.rwTitle)(clsvPaperSubAttachmentBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjvPaperSubAttachmentEN.updDate) == false && (0, clsString_js_1.GetStrLen)(pobjvPaperSubAttachmentEN.updDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 子观点附件(vPaperSubAttachment))!值:$(pobjvPaperSubAttachmentEN.updDate)(clsvPaperSubAttachmentBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjvPaperSubAttachmentEN.updUserId) == false && (0, clsString_js_1.GetStrLen)(pobjvPaperSubAttachmentEN.updUserId) > 20) {
            throw new Error("(errid:Watl000062)字段[修改用户Id(updUserId)]的长度不能超过20(In 子观点附件(vPaperSubAttachment))!值:$(pobjvPaperSubAttachmentEN.updUserId)(clsvPaperSubAttachmentBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjvPaperSubAttachmentEN.explainContent) == false && undefined !== pobjvPaperSubAttachmentEN.explainContent && jsString_js_1.tzDataType.isString(pobjvPaperSubAttachmentEN.explainContent) === false) {
            throw new Error("(errid:Watl000063)字段[说明内容(explainContent)]的值:[$(pobjvPaperSubAttachmentEN.explainContent)], 非法，应该为字符型(In 子观点附件(vPaperSubAttachment))!(clsvPaperSubAttachmentBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjvPaperSubAttachmentEN.filePath) == false && undefined !== pobjvPaperSubAttachmentEN.filePath && jsString_js_1.tzDataType.isString(pobjvPaperSubAttachmentEN.filePath) === false) {
            throw new Error("(errid:Watl000063)字段[文件路径(filePath)]的值:[$(pobjvPaperSubAttachmentEN.filePath)], 非法，应该为字符型(In 子观点附件(vPaperSubAttachment))!(clsvPaperSubAttachmentBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjvPaperSubAttachmentEN.memo) == false && undefined !== pobjvPaperSubAttachmentEN.memo && jsString_js_1.tzDataType.isString(pobjvPaperSubAttachmentEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjvPaperSubAttachmentEN.memo)], 非法，应该为字符型(In 子观点附件(vPaperSubAttachment))!(clsvPaperSubAttachmentBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjvPaperSubAttachmentEN.paperRWId) == false && undefined !== pobjvPaperSubAttachmentEN.paperRWId && jsString_js_1.tzDataType.isString(pobjvPaperSubAttachmentEN.paperRWId) === false) {
            throw new Error("(errid:Watl000063)字段[课文阅读(paperRWId)]的值:[$(pobjvPaperSubAttachmentEN.paperRWId)], 非法，应该为字符型(In 子观点附件(vPaperSubAttachment))!(clsvPaperSubAttachmentBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjvPaperSubAttachmentEN.paperSubAttachmentName) == false && undefined !== pobjvPaperSubAttachmentEN.paperSubAttachmentName && jsString_js_1.tzDataType.isString(pobjvPaperSubAttachmentEN.paperSubAttachmentName) === false) {
            throw new Error("(errid:Watl000063)字段[附件名称(paperSubAttachmentName)]的值:[$(pobjvPaperSubAttachmentEN.paperSubAttachmentName)], 非法，应该为字符型(In 子观点附件(vPaperSubAttachment))!(clsvPaperSubAttachmentBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjvPaperSubAttachmentEN.rwTitle) == false && undefined !== pobjvPaperSubAttachmentEN.rwTitle && jsString_js_1.tzDataType.isString(pobjvPaperSubAttachmentEN.rwTitle) === false) {
            throw new Error("(errid:Watl000063)字段[读写标题(rwTitle)]的值:[$(pobjvPaperSubAttachmentEN.rwTitle)], 非法，应该为字符型(In 子观点附件(vPaperSubAttachment))!(clsvPaperSubAttachmentBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjvPaperSubAttachmentEN.subViewpointContent) == false && undefined !== pobjvPaperSubAttachmentEN.subViewpointContent && jsString_js_1.tzDataType.isString(pobjvPaperSubAttachmentEN.subViewpointContent) === false) {
            throw new Error("(errid:Watl000063)字段[详情内容(subViewpointContent)]的值:[$(pobjvPaperSubAttachmentEN.subViewpointContent)], 非法，应该为字符型(In 子观点附件(vPaperSubAttachment))!(clsvPaperSubAttachmentBL:CheckProperty4Update)");
        }
        if (null != pobjvPaperSubAttachmentEN.subViewpointId && undefined !== pobjvPaperSubAttachmentEN.subViewpointId && jsString_js_1.tzDataType.isNumber(pobjvPaperSubAttachmentEN.subViewpointId) === false) {
            throw new Error("(errid:Watl000063)字段[子观点Id(subViewpointId)]的值:[$(pobjvPaperSubAttachmentEN.subViewpointId)], 非法，应该为数值型(In 子观点附件(vPaperSubAttachment))!(clsvPaperSubAttachmentBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjvPaperSubAttachmentEN.updDate) == false && undefined !== pobjvPaperSubAttachmentEN.updDate && jsString_js_1.tzDataType.isString(pobjvPaperSubAttachmentEN.updDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjvPaperSubAttachmentEN.updDate)], 非法，应该为字符型(In 子观点附件(vPaperSubAttachment))!(clsvPaperSubAttachmentBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjvPaperSubAttachmentEN.updUserId) == false && undefined !== pobjvPaperSubAttachmentEN.updUserId && jsString_js_1.tzDataType.isString(pobjvPaperSubAttachmentEN.updUserId) === false) {
            throw new Error("(errid:Watl000063)字段[修改用户Id(updUserId)]的值:[$(pobjvPaperSubAttachmentEN.updUserId)], 非法，应该为字符型(In 子观点附件(vPaperSubAttachment))!(clsvPaperSubAttachmentBL:CheckProperty4Update)");
        }
        if (null != pobjvPaperSubAttachmentEN.paperSubAttachmentId && undefined !== pobjvPaperSubAttachmentEN.paperSubAttachmentId && jsString_js_1.tzDataType.isNumber(pobjvPaperSubAttachmentEN.paperSubAttachmentId) === false) {
            throw new Error("(errid:Watl000063)字段[子观点附件Id(paperSubAttachmentId)]的值:[$(pobjvPaperSubAttachmentEN.paperSubAttachmentId)], 非法，应该为数值型(In 子观点附件(vPaperSubAttachment))!(clsvPaperSubAttachmentBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if (null === pobjvPaperSubAttachmentEN.paperSubAttachmentId
            || pobjvPaperSubAttachmentEN.paperSubAttachmentId != null && pobjvPaperSubAttachmentEN.paperSubAttachmentId.toString() === "") {
            throw new Error("(errid:Watl000064)字段[子观点附件Id]不能为空(In 子观点附件)!(clsvPaperSubAttachmentBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjvPaperSubAttachmentEN.SetIsCheckProperty(true);
    }
    exports.vPaperSubAttachment_CheckProperty4Update = vPaperSubAttachment_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vPaperSubAttachment_GetJSONStrByObj(pobjvPaperSubAttachmentEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjvPaperSubAttachmentEN.sf_UpdFldSetStr = pobjvPaperSubAttachmentEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjvPaperSubAttachmentEN);
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
    exports.vPaperSubAttachment_GetJSONStrByObj = vPaperSubAttachment_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function vPaperSubAttachment_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrvPaperSubAttachmentObjLst = new Array();
        if (strJSON === "") {
            return arrvPaperSubAttachmentObjLst;
        }
        try {
            arrvPaperSubAttachmentObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrvPaperSubAttachmentObjLst;
        }
        return arrvPaperSubAttachmentObjLst;
    }
    exports.vPaperSubAttachment_GetObjLstByJSONStr = vPaperSubAttachment_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrvPaperSubAttachmentObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function vPaperSubAttachment_GetObjLstByJSONObjLst(arrvPaperSubAttachmentObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrvPaperSubAttachmentObjLst = new Array();
        for (const objInFor of arrvPaperSubAttachmentObjLstS) {
            const obj1 = vPaperSubAttachment_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrvPaperSubAttachmentObjLst.push(obj1);
        }
        return arrvPaperSubAttachmentObjLst;
    }
    exports.vPaperSubAttachment_GetObjLstByJSONObjLst = vPaperSubAttachment_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vPaperSubAttachment_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjvPaperSubAttachmentEN = new clsvPaperSubAttachmentEN_js_1.clsvPaperSubAttachmentEN();
        if (strJSON === "") {
            return pobjvPaperSubAttachmentEN;
        }
        try {
            pobjvPaperSubAttachmentEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjvPaperSubAttachmentEN;
        }
        return pobjvPaperSubAttachmentEN;
    }
    exports.vPaperSubAttachment_GetObjByJSONStr = vPaperSubAttachment_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function vPaperSubAttachment_GetCombineCondition(objvPaperSubAttachment_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objvPaperSubAttachment_Cond.dicFldComparisonOp, clsvPaperSubAttachmentEN_js_1.clsvPaperSubAttachmentEN.con_ExplainContent) == true) {
            const strComparisonOp_ExplainContent = objvPaperSubAttachment_Cond.dicFldComparisonOp[clsvPaperSubAttachmentEN_js_1.clsvPaperSubAttachmentEN.con_ExplainContent];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperSubAttachmentEN_js_1.clsvPaperSubAttachmentEN.con_ExplainContent, objvPaperSubAttachment_Cond.explainContent, strComparisonOp_ExplainContent);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperSubAttachment_Cond.dicFldComparisonOp, clsvPaperSubAttachmentEN_js_1.clsvPaperSubAttachmentEN.con_FilePath) == true) {
            const strComparisonOp_FilePath = objvPaperSubAttachment_Cond.dicFldComparisonOp[clsvPaperSubAttachmentEN_js_1.clsvPaperSubAttachmentEN.con_FilePath];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperSubAttachmentEN_js_1.clsvPaperSubAttachmentEN.con_FilePath, objvPaperSubAttachment_Cond.filePath, strComparisonOp_FilePath);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperSubAttachment_Cond.dicFldComparisonOp, clsvPaperSubAttachmentEN_js_1.clsvPaperSubAttachmentEN.con_Memo) == true) {
            const strComparisonOp_Memo = objvPaperSubAttachment_Cond.dicFldComparisonOp[clsvPaperSubAttachmentEN_js_1.clsvPaperSubAttachmentEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperSubAttachmentEN_js_1.clsvPaperSubAttachmentEN.con_Memo, objvPaperSubAttachment_Cond.memo, strComparisonOp_Memo);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperSubAttachment_Cond.dicFldComparisonOp, clsvPaperSubAttachmentEN_js_1.clsvPaperSubAttachmentEN.con_PaperRWId) == true) {
            const strComparisonOp_PaperRWId = objvPaperSubAttachment_Cond.dicFldComparisonOp[clsvPaperSubAttachmentEN_js_1.clsvPaperSubAttachmentEN.con_PaperRWId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperSubAttachmentEN_js_1.clsvPaperSubAttachmentEN.con_PaperRWId, objvPaperSubAttachment_Cond.paperRWId, strComparisonOp_PaperRWId);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperSubAttachment_Cond.dicFldComparisonOp, clsvPaperSubAttachmentEN_js_1.clsvPaperSubAttachmentEN.con_PaperSubAttachmentName) == true) {
            const strComparisonOp_PaperSubAttachmentName = objvPaperSubAttachment_Cond.dicFldComparisonOp[clsvPaperSubAttachmentEN_js_1.clsvPaperSubAttachmentEN.con_PaperSubAttachmentName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperSubAttachmentEN_js_1.clsvPaperSubAttachmentEN.con_PaperSubAttachmentName, objvPaperSubAttachment_Cond.paperSubAttachmentName, strComparisonOp_PaperSubAttachmentName);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperSubAttachment_Cond.dicFldComparisonOp, clsvPaperSubAttachmentEN_js_1.clsvPaperSubAttachmentEN.con_RWTitle) == true) {
            const strComparisonOp_RWTitle = objvPaperSubAttachment_Cond.dicFldComparisonOp[clsvPaperSubAttachmentEN_js_1.clsvPaperSubAttachmentEN.con_RWTitle];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperSubAttachmentEN_js_1.clsvPaperSubAttachmentEN.con_RWTitle, objvPaperSubAttachment_Cond.rwTitle, strComparisonOp_RWTitle);
        }
        //数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
        if (Object.prototype.hasOwnProperty.call(objvPaperSubAttachment_Cond.dicFldComparisonOp, clsvPaperSubAttachmentEN_js_1.clsvPaperSubAttachmentEN.con_SubViewpointId) == true) {
            const strComparisonOp_SubViewpointId = objvPaperSubAttachment_Cond.dicFldComparisonOp[clsvPaperSubAttachmentEN_js_1.clsvPaperSubAttachmentEN.con_SubViewpointId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvPaperSubAttachmentEN_js_1.clsvPaperSubAttachmentEN.con_SubViewpointId, objvPaperSubAttachment_Cond.subViewpointId, strComparisonOp_SubViewpointId);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperSubAttachment_Cond.dicFldComparisonOp, clsvPaperSubAttachmentEN_js_1.clsvPaperSubAttachmentEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objvPaperSubAttachment_Cond.dicFldComparisonOp[clsvPaperSubAttachmentEN_js_1.clsvPaperSubAttachmentEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperSubAttachmentEN_js_1.clsvPaperSubAttachmentEN.con_UpdDate, objvPaperSubAttachment_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperSubAttachment_Cond.dicFldComparisonOp, clsvPaperSubAttachmentEN_js_1.clsvPaperSubAttachmentEN.con_UpdUserId) == true) {
            const strComparisonOp_UpdUserId = objvPaperSubAttachment_Cond.dicFldComparisonOp[clsvPaperSubAttachmentEN_js_1.clsvPaperSubAttachmentEN.con_UpdUserId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperSubAttachmentEN_js_1.clsvPaperSubAttachmentEN.con_UpdUserId, objvPaperSubAttachment_Cond.updUserId, strComparisonOp_UpdUserId);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperSubAttachment_Cond.dicFldComparisonOp, clsvPaperSubAttachmentEN_js_1.clsvPaperSubAttachmentEN.con_PaperSubAttachmentId) == true) {
            const strComparisonOp_PaperSubAttachmentId = objvPaperSubAttachment_Cond.dicFldComparisonOp[clsvPaperSubAttachmentEN_js_1.clsvPaperSubAttachmentEN.con_PaperSubAttachmentId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvPaperSubAttachmentEN_js_1.clsvPaperSubAttachmentEN.con_PaperSubAttachmentId, objvPaperSubAttachment_Cond.paperSubAttachmentId, strComparisonOp_PaperSubAttachmentId);
        }
        return strWhereCond;
    }
    exports.vPaperSubAttachment_GetCombineCondition = vPaperSubAttachment_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--vPaperSubAttachment(子观点附件),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param lngPaperSubAttachmentId: 子观点附件Id(要求唯一的字段)
    * @param lngSubViewpointId: 子观点Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function vPaperSubAttachment_GetUniCondStr_PaperSubAttachmentId_SubViewpointId(objvPaperSubAttachmentEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and PaperSubAttachmentId = '{0}'", objvPaperSubAttachmentEN.paperSubAttachmentId);
        strWhereCond += (0, clsString_js_1.Format)(" and SubViewpointId = '{0}'", objvPaperSubAttachmentEN.subViewpointId);
        return strWhereCond;
    }
    exports.vPaperSubAttachment_GetUniCondStr_PaperSubAttachmentId_SubViewpointId = vPaperSubAttachment_GetUniCondStr_PaperSubAttachmentId_SubViewpointId;
    /**
    *获取唯一性条件串(Uniqueness)--vPaperSubAttachment(子观点附件),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param lngPaperSubAttachmentId: 子观点附件Id(要求唯一的字段)
    * @param lngSubViewpointId: 子观点Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function vPaperSubAttachment_GetUniCondStr4Update_PaperSubAttachmentId_SubViewpointId(objvPaperSubAttachmentEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and PaperSubAttachmentId <> '{0}'", objvPaperSubAttachmentEN.paperSubAttachmentId);
        strWhereCond += (0, clsString_js_1.Format)(" and PaperSubAttachmentId = '{0}'", objvPaperSubAttachmentEN.paperSubAttachmentId);
        strWhereCond += (0, clsString_js_1.Format)(" and SubViewpointId = '{0}'", objvPaperSubAttachmentEN.subViewpointId);
        return strWhereCond;
    }
    exports.vPaperSubAttachment_GetUniCondStr4Update_PaperSubAttachmentId_SubViewpointId = vPaperSubAttachment_GetUniCondStr4Update_PaperSubAttachmentId_SubViewpointId;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objvPaperSubAttachmentENS:源对象
     * @param objvPaperSubAttachmentENT:目标对象
    */
    function vPaperSubAttachment_CopyObjTo(objvPaperSubAttachmentENS, objvPaperSubAttachmentENT) {
        objvPaperSubAttachmentENT.explainContent = objvPaperSubAttachmentENS.explainContent; //说明内容
        objvPaperSubAttachmentENT.filePath = objvPaperSubAttachmentENS.filePath; //文件路径
        objvPaperSubAttachmentENT.memo = objvPaperSubAttachmentENS.memo; //备注
        objvPaperSubAttachmentENT.paperRWId = objvPaperSubAttachmentENS.paperRWId; //课文阅读
        objvPaperSubAttachmentENT.paperSubAttachmentName = objvPaperSubAttachmentENS.paperSubAttachmentName; //附件名称
        objvPaperSubAttachmentENT.rwTitle = objvPaperSubAttachmentENS.rwTitle; //读写标题
        objvPaperSubAttachmentENT.subViewpointContent = objvPaperSubAttachmentENS.subViewpointContent; //详情内容
        objvPaperSubAttachmentENT.subViewpointId = objvPaperSubAttachmentENS.subViewpointId; //子观点Id
        objvPaperSubAttachmentENT.updDate = objvPaperSubAttachmentENS.updDate; //修改日期
        objvPaperSubAttachmentENT.updUserId = objvPaperSubAttachmentENS.updUserId; //修改用户Id
        objvPaperSubAttachmentENT.paperSubAttachmentId = objvPaperSubAttachmentENS.paperSubAttachmentId; //子观点附件Id
        objvPaperSubAttachmentENT.sf_UpdFldSetStr = objvPaperSubAttachmentENS.updFldString; //sf_UpdFldSetStr
    }
    exports.vPaperSubAttachment_CopyObjTo = vPaperSubAttachment_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objvPaperSubAttachmentENS:源对象
     * @param objvPaperSubAttachmentENT:目标对象
    */
    function vPaperSubAttachment_GetObjFromJsonObj(objvPaperSubAttachmentENS) {
        const objvPaperSubAttachmentENT = new clsvPaperSubAttachmentEN_js_1.clsvPaperSubAttachmentEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvPaperSubAttachmentENT, objvPaperSubAttachmentENS);
        return objvPaperSubAttachmentENT;
    }
    exports.vPaperSubAttachment_GetObjFromJsonObj = vPaperSubAttachment_GetObjFromJsonObj;
});
