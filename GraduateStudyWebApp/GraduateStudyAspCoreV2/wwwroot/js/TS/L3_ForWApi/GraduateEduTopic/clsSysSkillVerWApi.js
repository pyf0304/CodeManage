/**
* 类名:clsSysSkillVerWApi
* 表名:SysSkillVer(01120647)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/13 00:48:16
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
        define(["require", "exports", "axios", "../../L0_Entity/GraduateEduTopic/clsSysSkillVerEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.SysSkillVer_GetObjFromJsonObj = exports.SysSkillVer_CopyObjTo = exports.SysSkillVer_GetUniCondStr4Update_SkillVId = exports.SysSkillVer_GetUniCondStr_SkillVId = exports.SysSkillVer_GetCombineCondition = exports.SysSkillVer_GetObjByJSONStr = exports.SysSkillVer_GetObjLstByJSONObjLst = exports.SysSkillVer_GetObjLstByJSONStr = exports.SysSkillVer_GetJSONStrByObj = exports.SysSkillVer_CheckProperty4Update = exports.SysSkillVer_CheckPropertyNew = exports.SysSkillVer_GetWebApiUrl = exports.SysSkillVer_GetMaxStrIdByPrefix = exports.SysSkillVer_GetRecCountByCondAsync = exports.SysSkillVer_IsExistAsync = exports.SysSkillVer_IsExist = exports.SysSkillVer_IsExistRecordAsync = exports.SysSkillVer_UpdateWithConditionAsync = exports.SysSkillVer_UpdateRecordAsync = exports.SysSkillVer_AddNewRecordWithReturnKey = exports.SysSkillVer_AddNewRecordWithReturnKeyAsync = exports.SysSkillVer_AddNewRecordAsync = exports.SysSkillVer_DelSysSkillVersByCondAsync = exports.SysSkillVer_DelSysSkillVersAsync = exports.SysSkillVer_DelRecordAsync = exports.SysSkillVer_GetObjLstByPagerAsync = exports.SysSkillVer_GetObjLstByRange = exports.SysSkillVer_GetObjLstByRangeAsync = exports.SysSkillVer_GetTopObjLstAsync = exports.SysSkillVer_GetObjLstBySkillVIdLstAsync = exports.SysSkillVer_GetObjLstAsync = exports.SysSkillVer_GetFirstObjAsync = exports.SysSkillVer_GetFirstID = exports.SysSkillVer_GetFirstIDAsync = exports.SysSkillVer_FilterFunByKey = exports.SysSkillVer_SortFunByKey = exports.SysSkillVer_SortFun_Defa_2Fld = exports.SysSkillVer_SortFun_Defa = exports.SysSkillVer_GetObjBySkillVIdAsync = exports.sysSkillVer_ConstructorName = exports.sysSkillVer_Controller = void 0;
    /**
     * 系统技能版本(SysSkillVer)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月13日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const clsSysSkillVerEN_js_1 = require("../../L0_Entity/GraduateEduTopic/clsSysSkillVerEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsString_js_2 = require("../../PubFun/clsString.js");
    exports.sysSkillVer_Controller = "SysSkillVerApi";
    exports.sysSkillVer_ConstructorName = "sysSkillVer";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param lngSkillVId:关键字
    * @returns 对象
    **/
    async function SysSkillVer_GetObjBySkillVIdAsync(lngSkillVId) {
        const strThisFuncName = "GetObjBySkillVIdAsync";
        if (lngSkillVId == 0) {
            const strMsg = (0, clsString_js_2.Format)("参数:[lngSkillVId]不能为空！(In clsSysSkillVerWApi.GetObjBySkillVIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjBySkillVId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSkillVer_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "lngSkillVId": lngSkillVId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    return null;
                }
                //console.log(returnObj);
                const objSysSkillVer = SysSkillVer_GetObjFromJsonObj(returnObj);
                return objSysSkillVer;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSkillVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSkillVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSkillVer_GetObjBySkillVIdAsync = SysSkillVer_GetObjBySkillVIdAsync;
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
    function SysSkillVer_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.skillVId - b.skillVId;
    }
    exports.SysSkillVer_SortFun_Defa = SysSkillVer_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function SysSkillVer_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.skillId == b.skillId)
            return a.skillName.localeCompare(b.skillName);
        else
            return a.skillId.localeCompare(b.skillId);
    }
    exports.SysSkillVer_SortFun_Defa_2Fld = SysSkillVer_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function SysSkillVer_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsSysSkillVerEN_js_1.clsSysSkillVerEN.con_SkillVId:
                    return (a, b) => {
                        return a.skillVId - b.skillVId;
                    };
                case clsSysSkillVerEN_js_1.clsSysSkillVerEN.con_SkillId:
                    return (a, b) => {
                        return a.skillId.localeCompare(b.skillId);
                    };
                case clsSysSkillVerEN_js_1.clsSysSkillVerEN.con_SkillName:
                    return (a, b) => {
                        if (a.skillName == null)
                            return -1;
                        if (b.skillName == null)
                            return 1;
                        return a.skillName.localeCompare(b.skillName);
                    };
                case clsSysSkillVerEN_js_1.clsSysSkillVerEN.con_OperationTypeId:
                    return (a, b) => {
                        if (a.operationTypeId == null)
                            return -1;
                        if (b.operationTypeId == null)
                            return 1;
                        return a.operationTypeId.localeCompare(b.operationTypeId);
                    };
                case clsSysSkillVerEN_js_1.clsSysSkillVerEN.con_Process:
                    return (a, b) => {
                        if (a.process == null)
                            return -1;
                        if (b.process == null)
                            return 1;
                        return a.process.localeCompare(b.process);
                    };
                case clsSysSkillVerEN_js_1.clsSysSkillVerEN.con_LevelId:
                    return (a, b) => {
                        if (a.levelId == null)
                            return -1;
                        if (b.levelId == null)
                            return 1;
                        return a.levelId.localeCompare(b.levelId);
                    };
                case clsSysSkillVerEN_js_1.clsSysSkillVerEN.con_UpdUser:
                    return (a, b) => {
                        if (a.updUser == null)
                            return -1;
                        if (b.updUser == null)
                            return 1;
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsSysSkillVerEN_js_1.clsSysSkillVerEN.con_UpdDate:
                    return (a, b) => {
                        if (a.updDate == null)
                            return -1;
                        if (b.updDate == null)
                            return 1;
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsSysSkillVerEN_js_1.clsSysSkillVerEN.con_CitationId:
                    return (a, b) => {
                        if (a.citationId == null)
                            return -1;
                        if (b.citationId == null)
                            return 1;
                        return a.citationId.localeCompare(b.citationId);
                    };
                case clsSysSkillVerEN_js_1.clsSysSkillVerEN.con_id_CurrEduCls:
                    return (a, b) => {
                        if (a.id_CurrEduCls == null)
                            return -1;
                        if (b.id_CurrEduCls == null)
                            return 1;
                        return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
                    };
                case clsSysSkillVerEN_js_1.clsSysSkillVerEN.con_PdfContent:
                    return (a, b) => {
                        if (a.pdfContent == null)
                            return -1;
                        if (b.pdfContent == null)
                            return 1;
                        return a.pdfContent.localeCompare(b.pdfContent);
                    };
                case clsSysSkillVerEN_js_1.clsSysSkillVerEN.con_PdfPageNum:
                    return (a, b) => {
                        return a.pdfPageNum - b.pdfPageNum;
                    };
                case clsSysSkillVerEN_js_1.clsSysSkillVerEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[SysSkillVer]中不存在！(in ${exports.sysSkillVer_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsSysSkillVerEN_js_1.clsSysSkillVerEN.con_SkillVId:
                    return (a, b) => {
                        return b.skillVId - a.skillVId;
                    };
                case clsSysSkillVerEN_js_1.clsSysSkillVerEN.con_SkillId:
                    return (a, b) => {
                        return b.skillId.localeCompare(a.skillId);
                    };
                case clsSysSkillVerEN_js_1.clsSysSkillVerEN.con_SkillName:
                    return (a, b) => {
                        if (b.skillName == null)
                            return -1;
                        if (a.skillName == null)
                            return 1;
                        return b.skillName.localeCompare(a.skillName);
                    };
                case clsSysSkillVerEN_js_1.clsSysSkillVerEN.con_OperationTypeId:
                    return (a, b) => {
                        if (b.operationTypeId == null)
                            return -1;
                        if (a.operationTypeId == null)
                            return 1;
                        return b.operationTypeId.localeCompare(a.operationTypeId);
                    };
                case clsSysSkillVerEN_js_1.clsSysSkillVerEN.con_Process:
                    return (a, b) => {
                        if (b.process == null)
                            return -1;
                        if (a.process == null)
                            return 1;
                        return b.process.localeCompare(a.process);
                    };
                case clsSysSkillVerEN_js_1.clsSysSkillVerEN.con_LevelId:
                    return (a, b) => {
                        if (b.levelId == null)
                            return -1;
                        if (a.levelId == null)
                            return 1;
                        return b.levelId.localeCompare(a.levelId);
                    };
                case clsSysSkillVerEN_js_1.clsSysSkillVerEN.con_UpdUser:
                    return (a, b) => {
                        if (b.updUser == null)
                            return -1;
                        if (a.updUser == null)
                            return 1;
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsSysSkillVerEN_js_1.clsSysSkillVerEN.con_UpdDate:
                    return (a, b) => {
                        if (b.updDate == null)
                            return -1;
                        if (a.updDate == null)
                            return 1;
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsSysSkillVerEN_js_1.clsSysSkillVerEN.con_CitationId:
                    return (a, b) => {
                        if (b.citationId == null)
                            return -1;
                        if (a.citationId == null)
                            return 1;
                        return b.citationId.localeCompare(a.citationId);
                    };
                case clsSysSkillVerEN_js_1.clsSysSkillVerEN.con_id_CurrEduCls:
                    return (a, b) => {
                        if (b.id_CurrEduCls == null)
                            return -1;
                        if (a.id_CurrEduCls == null)
                            return 1;
                        return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
                    };
                case clsSysSkillVerEN_js_1.clsSysSkillVerEN.con_PdfContent:
                    return (a, b) => {
                        if (b.pdfContent == null)
                            return -1;
                        if (a.pdfContent == null)
                            return 1;
                        return b.pdfContent.localeCompare(a.pdfContent);
                    };
                case clsSysSkillVerEN_js_1.clsSysSkillVerEN.con_PdfPageNum:
                    return (a, b) => {
                        return b.pdfPageNum - a.pdfPageNum;
                    };
                case clsSysSkillVerEN_js_1.clsSysSkillVerEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[SysSkillVer]中不存在！(in ${exports.sysSkillVer_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.SysSkillVer_SortFunByKey = SysSkillVer_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function SysSkillVer_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsSysSkillVerEN_js_1.clsSysSkillVerEN.con_SkillVId:
                return (obj) => {
                    return obj.skillVId === value;
                };
            case clsSysSkillVerEN_js_1.clsSysSkillVerEN.con_SkillId:
                return (obj) => {
                    return obj.skillId === value;
                };
            case clsSysSkillVerEN_js_1.clsSysSkillVerEN.con_SkillName:
                return (obj) => {
                    return obj.skillName === value;
                };
            case clsSysSkillVerEN_js_1.clsSysSkillVerEN.con_OperationTypeId:
                return (obj) => {
                    return obj.operationTypeId === value;
                };
            case clsSysSkillVerEN_js_1.clsSysSkillVerEN.con_Process:
                return (obj) => {
                    return obj.process === value;
                };
            case clsSysSkillVerEN_js_1.clsSysSkillVerEN.con_LevelId:
                return (obj) => {
                    return obj.levelId === value;
                };
            case clsSysSkillVerEN_js_1.clsSysSkillVerEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsSysSkillVerEN_js_1.clsSysSkillVerEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsSysSkillVerEN_js_1.clsSysSkillVerEN.con_CitationId:
                return (obj) => {
                    return obj.citationId === value;
                };
            case clsSysSkillVerEN_js_1.clsSysSkillVerEN.con_id_CurrEduCls:
                return (obj) => {
                    return obj.id_CurrEduCls === value;
                };
            case clsSysSkillVerEN_js_1.clsSysSkillVerEN.con_PdfContent:
                return (obj) => {
                    return obj.pdfContent === value;
                };
            case clsSysSkillVerEN_js_1.clsSysSkillVerEN.con_PdfPageNum:
                return (obj) => {
                    return obj.pdfPageNum === value;
                };
            case clsSysSkillVerEN_js_1.clsSysSkillVerEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[SysSkillVer]中不存在！(in ${exports.sysSkillVer_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.SysSkillVer_FilterFunByKey = SysSkillVer_FilterFunByKey;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function SysSkillVer_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSkillVer_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSkillVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSkillVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSkillVer_GetFirstIDAsync = SysSkillVer_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function SysSkillVer_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSkillVer_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSkillVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSkillVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSkillVer_GetFirstID = SysSkillVer_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function SysSkillVer_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSkillVer_Controller, strAction);
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
                const objSysSkillVer = SysSkillVer_GetObjFromJsonObj(returnObj);
                return objSysSkillVer;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSkillVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSkillVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSkillVer_GetFirstObjAsync = SysSkillVer_GetFirstObjAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function SysSkillVer_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSkillVer_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.sysSkillVer_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = SysSkillVer_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSkillVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSkillVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSkillVer_GetObjLstAsync = SysSkillVer_GetObjLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrSkillVId:关键字列表
    * @returns 对象列表
    **/
    async function SysSkillVer_GetObjLstBySkillVIdLstAsync(arrSkillVId) {
        const strThisFuncName = "GetObjLstBySkillVIdLstAsync";
        const strAction = "GetObjLstBySkillVIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSkillVer_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrSkillVId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.sysSkillVer_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = SysSkillVer_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSkillVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSkillVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSkillVer_GetObjLstBySkillVIdLstAsync = SysSkillVer_GetObjLstBySkillVIdLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function SysSkillVer_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSkillVer_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.sysSkillVer_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = SysSkillVer_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSkillVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSkillVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSkillVer_GetTopObjLstAsync = SysSkillVer_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function SysSkillVer_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSkillVer_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.sysSkillVer_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = SysSkillVer_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSkillVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSkillVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSkillVer_GetObjLstByRangeAsync = SysSkillVer_GetObjLstByRangeAsync;
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
    async function SysSkillVer_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSkillVer_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSkillVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSkillVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSkillVer_GetObjLstByRange = SysSkillVer_GetObjLstByRange;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function SysSkillVer_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSkillVer_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.sysSkillVer_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = SysSkillVer_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSkillVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSkillVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSkillVer_GetObjLstByPagerAsync = SysSkillVer_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param lngSkillVId:关键字
    * @returns 获取删除的结果
    **/
    async function SysSkillVer_DelRecordAsync(lngSkillVId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSkillVer_Controller, strAction);
        strUrl = (0, clsString_js_2.Format)("{0}/?Id={1}", strUrl, lngSkillVId);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSkillVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSkillVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSkillVer_DelRecordAsync = SysSkillVer_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrSkillVId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function SysSkillVer_DelSysSkillVersAsync(arrSkillVId) {
        const strThisFuncName = "DelSysSkillVersAsync";
        const strAction = "DelSysSkillVers";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSkillVer_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrSkillVId);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSkillVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSkillVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSkillVer_DelSysSkillVersAsync = SysSkillVer_DelSysSkillVersAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function SysSkillVer_DelSysSkillVersByCondAsync(strWhereCond) {
        const strThisFuncName = "DelSysSkillVersByCondAsync";
        const strAction = "DelSysSkillVersByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSkillVer_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSkillVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSkillVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSkillVer_DelSysSkillVersByCondAsync = SysSkillVer_DelSysSkillVersByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objSysSkillVerEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function SysSkillVer_AddNewRecordAsync(objSysSkillVerEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objSysSkillVerEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSkillVer_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objSysSkillVerEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSkillVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSkillVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSkillVer_AddNewRecordAsync = SysSkillVer_AddNewRecordAsync;
    /* 数据类型不是字符型，不可以最大关键字的方式添加记录。*/
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objSysSkillVerEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function SysSkillVer_AddNewRecordWithReturnKeyAsync(objSysSkillVerEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSkillVer_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objSysSkillVerEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSkillVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSkillVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSkillVer_AddNewRecordWithReturnKeyAsync = SysSkillVer_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objSysSkillVerEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function SysSkillVer_AddNewRecordWithReturnKey(objSysSkillVerEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objSysSkillVerEN.skillVId === null || objSysSkillVerEN.skillVId === 0) {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSkillVer_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objSysSkillVerEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSkillVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSkillVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSkillVer_AddNewRecordWithReturnKey = SysSkillVer_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objSysSkillVerEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function SysSkillVer_UpdateRecordAsync(objSysSkillVerEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objSysSkillVerEN.sf_UpdFldSetStr === undefined || objSysSkillVerEN.sf_UpdFldSetStr === null || objSysSkillVerEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objSysSkillVerEN.skillVId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSkillVer_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objSysSkillVerEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSkillVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSkillVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSkillVer_UpdateRecordAsync = SysSkillVer_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objSysSkillVerEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function SysSkillVer_UpdateWithConditionAsync(objSysSkillVerEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objSysSkillVerEN.sf_UpdFldSetStr === undefined || objSysSkillVerEN.sf_UpdFldSetStr === null || objSysSkillVerEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objSysSkillVerEN.skillVId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSkillVer_Controller, strAction);
        objSysSkillVerEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objSysSkillVerEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSkillVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSkillVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSkillVer_UpdateWithConditionAsync = SysSkillVer_UpdateWithConditionAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function SysSkillVer_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSkillVer_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSkillVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSkillVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSkillVer_IsExistRecordAsync = SysSkillVer_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param lngSkillVId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function SysSkillVer_IsExist(lngSkillVId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSkillVer_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "SkillVId": lngSkillVId,
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSkillVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSkillVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSkillVer_IsExist = SysSkillVer_IsExist;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param lngSkillVId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function SysSkillVer_IsExistAsync(lngSkillVId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSkillVer_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "lngSkillVId": lngSkillVId }
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSkillVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSkillVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSkillVer_IsExistAsync = SysSkillVer_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function SysSkillVer_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSkillVer_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSkillVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSkillVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSkillVer_GetRecCountByCondAsync = SysSkillVer_GetRecCountByCondAsync;
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
    async function SysSkillVer_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSkillVer_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSkillVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSkillVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSkillVer_GetMaxStrIdByPrefix = SysSkillVer_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function SysSkillVer_GetWebApiUrl(strController, strAction) {
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
    exports.SysSkillVer_GetWebApiUrl = SysSkillVer_GetWebApiUrl;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function SysSkillVer_CheckPropertyNew(pobjSysSkillVerEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSkillVerEN.skillId) === true) {
            throw new Error("(errid:Watl000058)字段[技能Id]不能为空(In 系统技能版本)!(clsSysSkillVerBL:CheckPropertyNew)");
        }
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSkillVerEN.skillId) == false && (0, clsString_js_2.GetStrLen)(pobjSysSkillVerEN.skillId) > 10) {
            throw new Error("(errid:Watl000059)字段[技能Id(skillId)]的长度不能超过10(In 系统技能版本(SysSkillVer))!值:$(pobjSysSkillVerEN.skillId)(clsSysSkillVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSkillVerEN.skillName) == false && (0, clsString_js_2.GetStrLen)(pobjSysSkillVerEN.skillName) > 200) {
            throw new Error("(errid:Watl000059)字段[技能名称(skillName)]的长度不能超过200(In 系统技能版本(SysSkillVer))!值:$(pobjSysSkillVerEN.skillName)(clsSysSkillVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSkillVerEN.operationTypeId) == false && (0, clsString_js_2.GetStrLen)(pobjSysSkillVerEN.operationTypeId) > 4) {
            throw new Error("(errid:Watl000059)字段[操作类型ID(operationTypeId)]的长度不能超过4(In 系统技能版本(SysSkillVer))!值:$(pobjSysSkillVerEN.operationTypeId)(clsSysSkillVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSkillVerEN.levelId) == false && (0, clsString_js_2.GetStrLen)(pobjSysSkillVerEN.levelId) > 2) {
            throw new Error("(errid:Watl000059)字段[级别Id(levelId)]的长度不能超过2(In 系统技能版本(SysSkillVer))!值:$(pobjSysSkillVerEN.levelId)(clsSysSkillVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSkillVerEN.updUser) == false && (0, clsString_js_2.GetStrLen)(pobjSysSkillVerEN.updUser) > 20) {
            throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 系统技能版本(SysSkillVer))!值:$(pobjSysSkillVerEN.updUser)(clsSysSkillVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSkillVerEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjSysSkillVerEN.updDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 系统技能版本(SysSkillVer))!值:$(pobjSysSkillVerEN.updDate)(clsSysSkillVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSkillVerEN.citationId) == false && (0, clsString_js_2.GetStrLen)(pobjSysSkillVerEN.citationId) > 8) {
            throw new Error("(errid:Watl000059)字段[引用Id(citationId)]的长度不能超过8(In 系统技能版本(SysSkillVer))!值:$(pobjSysSkillVerEN.citationId)(clsSysSkillVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSkillVerEN.id_CurrEduCls) == false && (0, clsString_js_2.GetStrLen)(pobjSysSkillVerEN.id_CurrEduCls) > 8) {
            throw new Error("(errid:Watl000059)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 系统技能版本(SysSkillVer))!值:$(pobjSysSkillVerEN.id_CurrEduCls)(clsSysSkillVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSkillVerEN.pdfContent) == false && (0, clsString_js_2.GetStrLen)(pobjSysSkillVerEN.pdfContent) > 2000) {
            throw new Error("(errid:Watl000059)字段[Pdf内容(pdfContent)]的长度不能超过2000(In 系统技能版本(SysSkillVer))!值:$(pobjSysSkillVerEN.pdfContent)(clsSysSkillVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSkillVerEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjSysSkillVerEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 系统技能版本(SysSkillVer))!值:$(pobjSysSkillVerEN.memo)(clsSysSkillVerBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if (null != pobjSysSkillVerEN.skillVId && undefined !== pobjSysSkillVerEN.skillVId && clsString_js_1.tzDataType.isNumber(pobjSysSkillVerEN.skillVId) === false) {
            throw new Error("(errid:Watl000060)字段[SkillVId(skillVId)]的值:[$(pobjSysSkillVerEN.skillVId)], 非法，应该为数值型(In 系统技能版本(SysSkillVer))!(clsSysSkillVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSkillVerEN.skillId) == false && undefined !== pobjSysSkillVerEN.skillId && clsString_js_1.tzDataType.isString(pobjSysSkillVerEN.skillId) === false) {
            throw new Error("(errid:Watl000060)字段[技能Id(skillId)]的值:[$(pobjSysSkillVerEN.skillId)], 非法，应该为字符型(In 系统技能版本(SysSkillVer))!(clsSysSkillVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSkillVerEN.skillName) == false && undefined !== pobjSysSkillVerEN.skillName && clsString_js_1.tzDataType.isString(pobjSysSkillVerEN.skillName) === false) {
            throw new Error("(errid:Watl000060)字段[技能名称(skillName)]的值:[$(pobjSysSkillVerEN.skillName)], 非法，应该为字符型(In 系统技能版本(SysSkillVer))!(clsSysSkillVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSkillVerEN.operationTypeId) == false && undefined !== pobjSysSkillVerEN.operationTypeId && clsString_js_1.tzDataType.isString(pobjSysSkillVerEN.operationTypeId) === false) {
            throw new Error("(errid:Watl000060)字段[操作类型ID(operationTypeId)]的值:[$(pobjSysSkillVerEN.operationTypeId)], 非法，应该为字符型(In 系统技能版本(SysSkillVer))!(clsSysSkillVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSkillVerEN.process) == false && undefined !== pobjSysSkillVerEN.process && clsString_js_1.tzDataType.isString(pobjSysSkillVerEN.process) === false) {
            throw new Error("(errid:Watl000060)字段[实施过程(process)]的值:[$(pobjSysSkillVerEN.process)], 非法，应该为字符型(In 系统技能版本(SysSkillVer))!(clsSysSkillVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSkillVerEN.levelId) == false && undefined !== pobjSysSkillVerEN.levelId && clsString_js_1.tzDataType.isString(pobjSysSkillVerEN.levelId) === false) {
            throw new Error("(errid:Watl000060)字段[级别Id(levelId)]的值:[$(pobjSysSkillVerEN.levelId)], 非法，应该为字符型(In 系统技能版本(SysSkillVer))!(clsSysSkillVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSkillVerEN.updUser) == false && undefined !== pobjSysSkillVerEN.updUser && clsString_js_1.tzDataType.isString(pobjSysSkillVerEN.updUser) === false) {
            throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjSysSkillVerEN.updUser)], 非法，应该为字符型(In 系统技能版本(SysSkillVer))!(clsSysSkillVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSkillVerEN.updDate) == false && undefined !== pobjSysSkillVerEN.updDate && clsString_js_1.tzDataType.isString(pobjSysSkillVerEN.updDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjSysSkillVerEN.updDate)], 非法，应该为字符型(In 系统技能版本(SysSkillVer))!(clsSysSkillVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSkillVerEN.citationId) == false && undefined !== pobjSysSkillVerEN.citationId && clsString_js_1.tzDataType.isString(pobjSysSkillVerEN.citationId) === false) {
            throw new Error("(errid:Watl000060)字段[引用Id(citationId)]的值:[$(pobjSysSkillVerEN.citationId)], 非法，应该为字符型(In 系统技能版本(SysSkillVer))!(clsSysSkillVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSkillVerEN.id_CurrEduCls) == false && undefined !== pobjSysSkillVerEN.id_CurrEduCls && clsString_js_1.tzDataType.isString(pobjSysSkillVerEN.id_CurrEduCls) === false) {
            throw new Error("(errid:Watl000060)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjSysSkillVerEN.id_CurrEduCls)], 非法，应该为字符型(In 系统技能版本(SysSkillVer))!(clsSysSkillVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSkillVerEN.pdfContent) == false && undefined !== pobjSysSkillVerEN.pdfContent && clsString_js_1.tzDataType.isString(pobjSysSkillVerEN.pdfContent) === false) {
            throw new Error("(errid:Watl000060)字段[Pdf内容(pdfContent)]的值:[$(pobjSysSkillVerEN.pdfContent)], 非法，应该为字符型(In 系统技能版本(SysSkillVer))!(clsSysSkillVerBL:CheckPropertyNew)");
        }
        if (null != pobjSysSkillVerEN.pdfPageNum && undefined !== pobjSysSkillVerEN.pdfPageNum && clsString_js_1.tzDataType.isNumber(pobjSysSkillVerEN.pdfPageNum) === false) {
            throw new Error("(errid:Watl000060)字段[Pdf页码(pdfPageNum)]的值:[$(pobjSysSkillVerEN.pdfPageNum)], 非法，应该为数值型(In 系统技能版本(SysSkillVer))!(clsSysSkillVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSkillVerEN.memo) == false && undefined !== pobjSysSkillVerEN.memo && clsString_js_1.tzDataType.isString(pobjSysSkillVerEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjSysSkillVerEN.memo)], 非法，应该为字符型(In 系统技能版本(SysSkillVer))!(clsSysSkillVerBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjSysSkillVerEN.SetIsCheckProperty(true);
    }
    exports.SysSkillVer_CheckPropertyNew = SysSkillVer_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function SysSkillVer_CheckProperty4Update(pobjSysSkillVerEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSkillVerEN.skillId) == false && (0, clsString_js_2.GetStrLen)(pobjSysSkillVerEN.skillId) > 10) {
            throw new Error("(errid:Watl000062)字段[技能Id(skillId)]的长度不能超过10(In 系统技能版本(SysSkillVer))!值:$(pobjSysSkillVerEN.skillId)(clsSysSkillVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSkillVerEN.skillName) == false && (0, clsString_js_2.GetStrLen)(pobjSysSkillVerEN.skillName) > 200) {
            throw new Error("(errid:Watl000062)字段[技能名称(skillName)]的长度不能超过200(In 系统技能版本(SysSkillVer))!值:$(pobjSysSkillVerEN.skillName)(clsSysSkillVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSkillVerEN.operationTypeId) == false && (0, clsString_js_2.GetStrLen)(pobjSysSkillVerEN.operationTypeId) > 4) {
            throw new Error("(errid:Watl000062)字段[操作类型ID(operationTypeId)]的长度不能超过4(In 系统技能版本(SysSkillVer))!值:$(pobjSysSkillVerEN.operationTypeId)(clsSysSkillVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSkillVerEN.levelId) == false && (0, clsString_js_2.GetStrLen)(pobjSysSkillVerEN.levelId) > 2) {
            throw new Error("(errid:Watl000062)字段[级别Id(levelId)]的长度不能超过2(In 系统技能版本(SysSkillVer))!值:$(pobjSysSkillVerEN.levelId)(clsSysSkillVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSkillVerEN.updUser) == false && (0, clsString_js_2.GetStrLen)(pobjSysSkillVerEN.updUser) > 20) {
            throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 系统技能版本(SysSkillVer))!值:$(pobjSysSkillVerEN.updUser)(clsSysSkillVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSkillVerEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjSysSkillVerEN.updDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 系统技能版本(SysSkillVer))!值:$(pobjSysSkillVerEN.updDate)(clsSysSkillVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSkillVerEN.citationId) == false && (0, clsString_js_2.GetStrLen)(pobjSysSkillVerEN.citationId) > 8) {
            throw new Error("(errid:Watl000062)字段[引用Id(citationId)]的长度不能超过8(In 系统技能版本(SysSkillVer))!值:$(pobjSysSkillVerEN.citationId)(clsSysSkillVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSkillVerEN.id_CurrEduCls) == false && (0, clsString_js_2.GetStrLen)(pobjSysSkillVerEN.id_CurrEduCls) > 8) {
            throw new Error("(errid:Watl000062)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 系统技能版本(SysSkillVer))!值:$(pobjSysSkillVerEN.id_CurrEduCls)(clsSysSkillVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSkillVerEN.pdfContent) == false && (0, clsString_js_2.GetStrLen)(pobjSysSkillVerEN.pdfContent) > 2000) {
            throw new Error("(errid:Watl000062)字段[Pdf内容(pdfContent)]的长度不能超过2000(In 系统技能版本(SysSkillVer))!值:$(pobjSysSkillVerEN.pdfContent)(clsSysSkillVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSkillVerEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjSysSkillVerEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 系统技能版本(SysSkillVer))!值:$(pobjSysSkillVerEN.memo)(clsSysSkillVerBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if (null != pobjSysSkillVerEN.skillVId && undefined !== pobjSysSkillVerEN.skillVId && clsString_js_1.tzDataType.isNumber(pobjSysSkillVerEN.skillVId) === false) {
            throw new Error("(errid:Watl000063)字段[SkillVId(skillVId)]的值:[$(pobjSysSkillVerEN.skillVId)], 非法，应该为数值型(In 系统技能版本(SysSkillVer))!(clsSysSkillVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSkillVerEN.skillId) == false && undefined !== pobjSysSkillVerEN.skillId && clsString_js_1.tzDataType.isString(pobjSysSkillVerEN.skillId) === false) {
            throw new Error("(errid:Watl000063)字段[技能Id(skillId)]的值:[$(pobjSysSkillVerEN.skillId)], 非法，应该为字符型(In 系统技能版本(SysSkillVer))!(clsSysSkillVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSkillVerEN.skillName) == false && undefined !== pobjSysSkillVerEN.skillName && clsString_js_1.tzDataType.isString(pobjSysSkillVerEN.skillName) === false) {
            throw new Error("(errid:Watl000063)字段[技能名称(skillName)]的值:[$(pobjSysSkillVerEN.skillName)], 非法，应该为字符型(In 系统技能版本(SysSkillVer))!(clsSysSkillVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSkillVerEN.operationTypeId) == false && undefined !== pobjSysSkillVerEN.operationTypeId && clsString_js_1.tzDataType.isString(pobjSysSkillVerEN.operationTypeId) === false) {
            throw new Error("(errid:Watl000063)字段[操作类型ID(operationTypeId)]的值:[$(pobjSysSkillVerEN.operationTypeId)], 非法，应该为字符型(In 系统技能版本(SysSkillVer))!(clsSysSkillVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSkillVerEN.process) == false && undefined !== pobjSysSkillVerEN.process && clsString_js_1.tzDataType.isString(pobjSysSkillVerEN.process) === false) {
            throw new Error("(errid:Watl000063)字段[实施过程(process)]的值:[$(pobjSysSkillVerEN.process)], 非法，应该为字符型(In 系统技能版本(SysSkillVer))!(clsSysSkillVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSkillVerEN.levelId) == false && undefined !== pobjSysSkillVerEN.levelId && clsString_js_1.tzDataType.isString(pobjSysSkillVerEN.levelId) === false) {
            throw new Error("(errid:Watl000063)字段[级别Id(levelId)]的值:[$(pobjSysSkillVerEN.levelId)], 非法，应该为字符型(In 系统技能版本(SysSkillVer))!(clsSysSkillVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSkillVerEN.updUser) == false && undefined !== pobjSysSkillVerEN.updUser && clsString_js_1.tzDataType.isString(pobjSysSkillVerEN.updUser) === false) {
            throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjSysSkillVerEN.updUser)], 非法，应该为字符型(In 系统技能版本(SysSkillVer))!(clsSysSkillVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSkillVerEN.updDate) == false && undefined !== pobjSysSkillVerEN.updDate && clsString_js_1.tzDataType.isString(pobjSysSkillVerEN.updDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjSysSkillVerEN.updDate)], 非法，应该为字符型(In 系统技能版本(SysSkillVer))!(clsSysSkillVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSkillVerEN.citationId) == false && undefined !== pobjSysSkillVerEN.citationId && clsString_js_1.tzDataType.isString(pobjSysSkillVerEN.citationId) === false) {
            throw new Error("(errid:Watl000063)字段[引用Id(citationId)]的值:[$(pobjSysSkillVerEN.citationId)], 非法，应该为字符型(In 系统技能版本(SysSkillVer))!(clsSysSkillVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSkillVerEN.id_CurrEduCls) == false && undefined !== pobjSysSkillVerEN.id_CurrEduCls && clsString_js_1.tzDataType.isString(pobjSysSkillVerEN.id_CurrEduCls) === false) {
            throw new Error("(errid:Watl000063)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjSysSkillVerEN.id_CurrEduCls)], 非法，应该为字符型(In 系统技能版本(SysSkillVer))!(clsSysSkillVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSkillVerEN.pdfContent) == false && undefined !== pobjSysSkillVerEN.pdfContent && clsString_js_1.tzDataType.isString(pobjSysSkillVerEN.pdfContent) === false) {
            throw new Error("(errid:Watl000063)字段[Pdf内容(pdfContent)]的值:[$(pobjSysSkillVerEN.pdfContent)], 非法，应该为字符型(In 系统技能版本(SysSkillVer))!(clsSysSkillVerBL:CheckProperty4Update)");
        }
        if (null != pobjSysSkillVerEN.pdfPageNum && undefined !== pobjSysSkillVerEN.pdfPageNum && clsString_js_1.tzDataType.isNumber(pobjSysSkillVerEN.pdfPageNum) === false) {
            throw new Error("(errid:Watl000063)字段[Pdf页码(pdfPageNum)]的值:[$(pobjSysSkillVerEN.pdfPageNum)], 非法，应该为数值型(In 系统技能版本(SysSkillVer))!(clsSysSkillVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSkillVerEN.memo) == false && undefined !== pobjSysSkillVerEN.memo && clsString_js_1.tzDataType.isString(pobjSysSkillVerEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjSysSkillVerEN.memo)], 非法，应该为字符型(In 系统技能版本(SysSkillVer))!(clsSysSkillVerBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if (null === pobjSysSkillVerEN.skillVId
            || pobjSysSkillVerEN.skillVId != null && pobjSysSkillVerEN.skillVId.toString() === "") {
            throw new Error("(errid:Watl000064)字段[SkillVId]不能为空(In 系统技能版本)!(clsSysSkillVerBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjSysSkillVerEN.SetIsCheckProperty(true);
    }
    exports.SysSkillVer_CheckProperty4Update = SysSkillVer_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function SysSkillVer_GetJSONStrByObj(pobjSysSkillVerEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjSysSkillVerEN.sf_UpdFldSetStr = pobjSysSkillVerEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjSysSkillVerEN);
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
    exports.SysSkillVer_GetJSONStrByObj = SysSkillVer_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function SysSkillVer_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrSysSkillVerObjLst = new Array();
        if (strJSON === "") {
            return arrSysSkillVerObjLst;
        }
        try {
            arrSysSkillVerObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrSysSkillVerObjLst;
        }
        return arrSysSkillVerObjLst;
    }
    exports.SysSkillVer_GetObjLstByJSONStr = SysSkillVer_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrSysSkillVerObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function SysSkillVer_GetObjLstByJSONObjLst(arrSysSkillVerObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrSysSkillVerObjLst = new Array();
        for (const objInFor of arrSysSkillVerObjLstS) {
            const obj1 = SysSkillVer_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrSysSkillVerObjLst.push(obj1);
        }
        return arrSysSkillVerObjLst;
    }
    exports.SysSkillVer_GetObjLstByJSONObjLst = SysSkillVer_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function SysSkillVer_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjSysSkillVerEN = new clsSysSkillVerEN_js_1.clsSysSkillVerEN();
        if (strJSON === "") {
            return pobjSysSkillVerEN;
        }
        try {
            pobjSysSkillVerEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjSysSkillVerEN;
        }
        return pobjSysSkillVerEN;
    }
    exports.SysSkillVer_GetObjByJSONStr = SysSkillVer_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function SysSkillVer_GetCombineCondition(objSysSkillVer_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objSysSkillVer_Cond.dicFldComparisonOp, clsSysSkillVerEN_js_1.clsSysSkillVerEN.con_SkillVId) == true) {
            const strComparisonOp_SkillVId = objSysSkillVer_Cond.dicFldComparisonOp[clsSysSkillVerEN_js_1.clsSysSkillVerEN.con_SkillVId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsSysSkillVerEN_js_1.clsSysSkillVerEN.con_SkillVId, objSysSkillVer_Cond.skillVId, strComparisonOp_SkillVId);
        }
        if (Object.prototype.hasOwnProperty.call(objSysSkillVer_Cond.dicFldComparisonOp, clsSysSkillVerEN_js_1.clsSysSkillVerEN.con_SkillId) == true) {
            const strComparisonOp_SkillId = objSysSkillVer_Cond.dicFldComparisonOp[clsSysSkillVerEN_js_1.clsSysSkillVerEN.con_SkillId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsSysSkillVerEN_js_1.clsSysSkillVerEN.con_SkillId, objSysSkillVer_Cond.skillId, strComparisonOp_SkillId);
        }
        if (Object.prototype.hasOwnProperty.call(objSysSkillVer_Cond.dicFldComparisonOp, clsSysSkillVerEN_js_1.clsSysSkillVerEN.con_SkillName) == true) {
            const strComparisonOp_SkillName = objSysSkillVer_Cond.dicFldComparisonOp[clsSysSkillVerEN_js_1.clsSysSkillVerEN.con_SkillName];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsSysSkillVerEN_js_1.clsSysSkillVerEN.con_SkillName, objSysSkillVer_Cond.skillName, strComparisonOp_SkillName);
        }
        if (Object.prototype.hasOwnProperty.call(objSysSkillVer_Cond.dicFldComparisonOp, clsSysSkillVerEN_js_1.clsSysSkillVerEN.con_OperationTypeId) == true) {
            const strComparisonOp_OperationTypeId = objSysSkillVer_Cond.dicFldComparisonOp[clsSysSkillVerEN_js_1.clsSysSkillVerEN.con_OperationTypeId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsSysSkillVerEN_js_1.clsSysSkillVerEN.con_OperationTypeId, objSysSkillVer_Cond.operationTypeId, strComparisonOp_OperationTypeId);
        }
        //数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
        if (Object.prototype.hasOwnProperty.call(objSysSkillVer_Cond.dicFldComparisonOp, clsSysSkillVerEN_js_1.clsSysSkillVerEN.con_LevelId) == true) {
            const strComparisonOp_LevelId = objSysSkillVer_Cond.dicFldComparisonOp[clsSysSkillVerEN_js_1.clsSysSkillVerEN.con_LevelId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsSysSkillVerEN_js_1.clsSysSkillVerEN.con_LevelId, objSysSkillVer_Cond.levelId, strComparisonOp_LevelId);
        }
        if (Object.prototype.hasOwnProperty.call(objSysSkillVer_Cond.dicFldComparisonOp, clsSysSkillVerEN_js_1.clsSysSkillVerEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objSysSkillVer_Cond.dicFldComparisonOp[clsSysSkillVerEN_js_1.clsSysSkillVerEN.con_UpdUser];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsSysSkillVerEN_js_1.clsSysSkillVerEN.con_UpdUser, objSysSkillVer_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objSysSkillVer_Cond.dicFldComparisonOp, clsSysSkillVerEN_js_1.clsSysSkillVerEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objSysSkillVer_Cond.dicFldComparisonOp[clsSysSkillVerEN_js_1.clsSysSkillVerEN.con_UpdDate];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsSysSkillVerEN_js_1.clsSysSkillVerEN.con_UpdDate, objSysSkillVer_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objSysSkillVer_Cond.dicFldComparisonOp, clsSysSkillVerEN_js_1.clsSysSkillVerEN.con_CitationId) == true) {
            const strComparisonOp_CitationId = objSysSkillVer_Cond.dicFldComparisonOp[clsSysSkillVerEN_js_1.clsSysSkillVerEN.con_CitationId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsSysSkillVerEN_js_1.clsSysSkillVerEN.con_CitationId, objSysSkillVer_Cond.citationId, strComparisonOp_CitationId);
        }
        if (Object.prototype.hasOwnProperty.call(objSysSkillVer_Cond.dicFldComparisonOp, clsSysSkillVerEN_js_1.clsSysSkillVerEN.con_id_CurrEduCls) == true) {
            const strComparisonOp_id_CurrEduCls = objSysSkillVer_Cond.dicFldComparisonOp[clsSysSkillVerEN_js_1.clsSysSkillVerEN.con_id_CurrEduCls];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsSysSkillVerEN_js_1.clsSysSkillVerEN.con_id_CurrEduCls, objSysSkillVer_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
        }
        if (Object.prototype.hasOwnProperty.call(objSysSkillVer_Cond.dicFldComparisonOp, clsSysSkillVerEN_js_1.clsSysSkillVerEN.con_PdfContent) == true) {
            const strComparisonOp_PdfContent = objSysSkillVer_Cond.dicFldComparisonOp[clsSysSkillVerEN_js_1.clsSysSkillVerEN.con_PdfContent];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsSysSkillVerEN_js_1.clsSysSkillVerEN.con_PdfContent, objSysSkillVer_Cond.pdfContent, strComparisonOp_PdfContent);
        }
        if (Object.prototype.hasOwnProperty.call(objSysSkillVer_Cond.dicFldComparisonOp, clsSysSkillVerEN_js_1.clsSysSkillVerEN.con_PdfPageNum) == true) {
            const strComparisonOp_PdfPageNum = objSysSkillVer_Cond.dicFldComparisonOp[clsSysSkillVerEN_js_1.clsSysSkillVerEN.con_PdfPageNum];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsSysSkillVerEN_js_1.clsSysSkillVerEN.con_PdfPageNum, objSysSkillVer_Cond.pdfPageNum, strComparisonOp_PdfPageNum);
        }
        if (Object.prototype.hasOwnProperty.call(objSysSkillVer_Cond.dicFldComparisonOp, clsSysSkillVerEN_js_1.clsSysSkillVerEN.con_Memo) == true) {
            const strComparisonOp_Memo = objSysSkillVer_Cond.dicFldComparisonOp[clsSysSkillVerEN_js_1.clsSysSkillVerEN.con_Memo];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsSysSkillVerEN_js_1.clsSysSkillVerEN.con_Memo, objSysSkillVer_Cond.memo, strComparisonOp_Memo);
        }
        return strWhereCond;
    }
    exports.SysSkillVer_GetCombineCondition = SysSkillVer_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--SysSkillVer(系统技能版本),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param lngSkillVId: SkillVId(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function SysSkillVer_GetUniCondStr_SkillVId(objSysSkillVerEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and SkillVId = '{0}'", objSysSkillVerEN.skillVId);
        return strWhereCond;
    }
    exports.SysSkillVer_GetUniCondStr_SkillVId = SysSkillVer_GetUniCondStr_SkillVId;
    /**
    *获取唯一性条件串(Uniqueness)--SysSkillVer(系统技能版本),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param lngSkillVId: SkillVId(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function SysSkillVer_GetUniCondStr4Update_SkillVId(objSysSkillVerEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and SkillVId <> '{0}'", objSysSkillVerEN.skillVId);
        strWhereCond += (0, clsString_js_2.Format)(" and SkillVId = '{0}'", objSysSkillVerEN.skillVId);
        return strWhereCond;
    }
    exports.SysSkillVer_GetUniCondStr4Update_SkillVId = SysSkillVer_GetUniCondStr4Update_SkillVId;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objSysSkillVerENS:源对象
     * @param objSysSkillVerENT:目标对象
    */
    function SysSkillVer_CopyObjTo(objSysSkillVerENS, objSysSkillVerENT) {
        objSysSkillVerENT.skillVId = objSysSkillVerENS.skillVId; //SkillVId
        objSysSkillVerENT.skillId = objSysSkillVerENS.skillId; //技能Id
        objSysSkillVerENT.skillName = objSysSkillVerENS.skillName; //技能名称
        objSysSkillVerENT.operationTypeId = objSysSkillVerENS.operationTypeId; //操作类型ID
        objSysSkillVerENT.process = objSysSkillVerENS.process; //实施过程
        objSysSkillVerENT.levelId = objSysSkillVerENS.levelId; //级别Id
        objSysSkillVerENT.updUser = objSysSkillVerENS.updUser; //修改人
        objSysSkillVerENT.updDate = objSysSkillVerENS.updDate; //修改日期
        objSysSkillVerENT.citationId = objSysSkillVerENS.citationId; //引用Id
        objSysSkillVerENT.id_CurrEduCls = objSysSkillVerENS.id_CurrEduCls; //教学班流水号
        objSysSkillVerENT.pdfContent = objSysSkillVerENS.pdfContent; //Pdf内容
        objSysSkillVerENT.pdfPageNum = objSysSkillVerENS.pdfPageNum; //Pdf页码
        objSysSkillVerENT.memo = objSysSkillVerENS.memo; //备注
        objSysSkillVerENT.sf_UpdFldSetStr = objSysSkillVerENS.updFldString; //sf_UpdFldSetStr
    }
    exports.SysSkillVer_CopyObjTo = SysSkillVer_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objSysSkillVerENS:源对象
     * @param objSysSkillVerENT:目标对象
    */
    function SysSkillVer_GetObjFromJsonObj(objSysSkillVerENS) {
        const objSysSkillVerENT = new clsSysSkillVerEN_js_1.clsSysSkillVerEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objSysSkillVerENT, objSysSkillVerENS);
        return objSysSkillVerENT;
    }
    exports.SysSkillVer_GetObjFromJsonObj = SysSkillVer_GetObjFromJsonObj;
});
