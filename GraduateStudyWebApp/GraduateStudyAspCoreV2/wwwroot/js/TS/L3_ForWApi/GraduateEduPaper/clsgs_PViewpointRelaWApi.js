/**
* 类名:clsgs_PViewpointRelaWApi
* 表名:gs_PViewpointRela(01120674)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/13 00:50:12
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
        define(["require", "exports", "axios", "../../L0_Entity/GraduateEduPaper/clsgs_PViewpointRelaEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.gs_PViewpointRela_GetObjFromJsonObj = exports.gs_PViewpointRela_CopyObjTo = exports.gs_PViewpointRela_GetUniCondStr4Update_PaperId = exports.gs_PViewpointRela_GetUniCondStr4Update_mId = exports.gs_PViewpointRela_GetUniCondStr_PaperId = exports.gs_PViewpointRela_GetUniCondStr_mId = exports.gs_PViewpointRela_GetCombineCondition = exports.gs_PViewpointRela_GetObjByJSONStr = exports.gs_PViewpointRela_GetObjLstByJSONObjLst = exports.gs_PViewpointRela_GetObjLstByJSONStr = exports.gs_PViewpointRela_GetJSONStrByObj = exports.gs_PViewpointRela_CheckProperty4Update = exports.gs_PViewpointRela_CheckPropertyNew = exports.gs_PViewpointRela_GetWebApiUrl = exports.gs_PViewpointRela_GetMaxStrIdByPrefix = exports.gs_PViewpointRela_GetRecCountByCondAsync = exports.gs_PViewpointRela_IsExistAsync = exports.gs_PViewpointRela_IsExist = exports.gs_PViewpointRela_IsExistRecordAsync = exports.gs_PViewpointRela_UpdateWithConditionAsync = exports.gs_PViewpointRela_UpdateRecordAsync = exports.gs_PViewpointRela_AddNewRecordWithReturnKey = exports.gs_PViewpointRela_AddNewRecordWithReturnKeyAsync = exports.gs_PViewpointRela_AddNewRecordAsync = exports.gs_PViewpointRela_Delgs_PViewpointRelasByCondAsync = exports.gs_PViewpointRela_Delgs_PViewpointRelasAsync = exports.gs_PViewpointRela_DelRecordAsync = exports.gs_PViewpointRela_GetObjLstByPagerAsync = exports.gs_PViewpointRela_GetObjLstByRange = exports.gs_PViewpointRela_GetObjLstByRangeAsync = exports.gs_PViewpointRela_GetTopObjLstAsync = exports.gs_PViewpointRela_GetObjLstBymIdLstAsync = exports.gs_PViewpointRela_GetObjLstAsync = exports.gs_PViewpointRela_GetFirstObjAsync = exports.gs_PViewpointRela_GetFirstID = exports.gs_PViewpointRela_GetFirstIDAsync = exports.gs_PViewpointRela_FilterFunByKey = exports.gs_PViewpointRela_SortFunByKey = exports.gs_PViewpointRela_SortFun_Defa_2Fld = exports.gs_PViewpointRela_SortFun_Defa = exports.gs_PViewpointRela_GetObjBymIdAsync = exports.gs_PViewpointRela_ConstructorName = exports.gs_PViewpointRela_Controller = void 0;
    /**
     * 论文观点关系表(gs_PViewpointRela)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月13日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const clsgs_PViewpointRelaEN_js_1 = require("../../L0_Entity/GraduateEduPaper/clsgs_PViewpointRelaEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsString_js_2 = require("../../PubFun/clsString.js");
    exports.gs_PViewpointRela_Controller = "gs_PViewpointRelaApi";
    exports.gs_PViewpointRela_ConstructorName = "gs_PViewpointRela";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param lngmId:关键字
    * @returns 对象
    **/
    async function gs_PViewpointRela_GetObjBymIdAsync(lngmId) {
        const strThisFuncName = "GetObjBymIdAsync";
        if (lngmId == 0) {
            const strMsg = (0, clsString_js_2.Format)("参数:[lngmId]不能为空！(In clsgs_PViewpointRelaWApi.GetObjBymIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjBymId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PViewpointRela_Controller, strAction);
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
                    return null;
                }
                //console.log(returnObj);
                const objgs_PViewpointRela = gs_PViewpointRela_GetObjFromJsonObj(returnObj);
                return objgs_PViewpointRela;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PViewpointRela_GetObjBymIdAsync = gs_PViewpointRela_GetObjBymIdAsync;
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
    function gs_PViewpointRela_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.mId - b.mId;
    }
    exports.gs_PViewpointRela_SortFun_Defa = gs_PViewpointRela_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function gs_PViewpointRela_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.paperId == b.paperId)
            return a.sectionId.localeCompare(b.sectionId);
        else
            return a.paperId.localeCompare(b.paperId);
    }
    exports.gs_PViewpointRela_SortFun_Defa_2Fld = gs_PViewpointRela_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function gs_PViewpointRela_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsgs_PViewpointRelaEN_js_1.clsgs_PViewpointRelaEN.con_mId:
                    return (a, b) => {
                        return a.mId - b.mId;
                    };
                case clsgs_PViewpointRelaEN_js_1.clsgs_PViewpointRelaEN.con_PaperId:
                    return (a, b) => {
                        return a.paperId.localeCompare(b.paperId);
                    };
                case clsgs_PViewpointRelaEN_js_1.clsgs_PViewpointRelaEN.con_SectionId:
                    return (a, b) => {
                        if (a.sectionId == null)
                            return -1;
                        if (b.sectionId == null)
                            return 1;
                        return a.sectionId.localeCompare(b.sectionId);
                    };
                case clsgs_PViewpointRelaEN_js_1.clsgs_PViewpointRelaEN.con_ViewpointId:
                    return (a, b) => {
                        return a.viewpointId.localeCompare(b.viewpointId);
                    };
                case clsgs_PViewpointRelaEN_js_1.clsgs_PViewpointRelaEN.con_ProposePeople:
                    return (a, b) => {
                        if (a.proposePeople == null)
                            return -1;
                        if (b.proposePeople == null)
                            return 1;
                        return a.proposePeople.localeCompare(b.proposePeople);
                    };
                case clsgs_PViewpointRelaEN_js_1.clsgs_PViewpointRelaEN.con_UpdDate:
                    return (a, b) => {
                        if (a.updDate == null)
                            return -1;
                        if (b.updDate == null)
                            return 1;
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsgs_PViewpointRelaEN_js_1.clsgs_PViewpointRelaEN.con_UpdUser:
                    return (a, b) => {
                        if (a.updUser == null)
                            return -1;
                        if (b.updUser == null)
                            return 1;
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsgs_PViewpointRelaEN_js_1.clsgs_PViewpointRelaEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[gs_PViewpointRela]中不存在！(in ${exports.gs_PViewpointRela_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsgs_PViewpointRelaEN_js_1.clsgs_PViewpointRelaEN.con_mId:
                    return (a, b) => {
                        return b.mId - a.mId;
                    };
                case clsgs_PViewpointRelaEN_js_1.clsgs_PViewpointRelaEN.con_PaperId:
                    return (a, b) => {
                        return b.paperId.localeCompare(a.paperId);
                    };
                case clsgs_PViewpointRelaEN_js_1.clsgs_PViewpointRelaEN.con_SectionId:
                    return (a, b) => {
                        if (b.sectionId == null)
                            return -1;
                        if (a.sectionId == null)
                            return 1;
                        return b.sectionId.localeCompare(a.sectionId);
                    };
                case clsgs_PViewpointRelaEN_js_1.clsgs_PViewpointRelaEN.con_ViewpointId:
                    return (a, b) => {
                        return b.viewpointId.localeCompare(a.viewpointId);
                    };
                case clsgs_PViewpointRelaEN_js_1.clsgs_PViewpointRelaEN.con_ProposePeople:
                    return (a, b) => {
                        if (b.proposePeople == null)
                            return -1;
                        if (a.proposePeople == null)
                            return 1;
                        return b.proposePeople.localeCompare(a.proposePeople);
                    };
                case clsgs_PViewpointRelaEN_js_1.clsgs_PViewpointRelaEN.con_UpdDate:
                    return (a, b) => {
                        if (b.updDate == null)
                            return -1;
                        if (a.updDate == null)
                            return 1;
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsgs_PViewpointRelaEN_js_1.clsgs_PViewpointRelaEN.con_UpdUser:
                    return (a, b) => {
                        if (b.updUser == null)
                            return -1;
                        if (a.updUser == null)
                            return 1;
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsgs_PViewpointRelaEN_js_1.clsgs_PViewpointRelaEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[gs_PViewpointRela]中不存在！(in ${exports.gs_PViewpointRela_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.gs_PViewpointRela_SortFunByKey = gs_PViewpointRela_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function gs_PViewpointRela_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsgs_PViewpointRelaEN_js_1.clsgs_PViewpointRelaEN.con_mId:
                return (obj) => {
                    return obj.mId === value;
                };
            case clsgs_PViewpointRelaEN_js_1.clsgs_PViewpointRelaEN.con_PaperId:
                return (obj) => {
                    return obj.paperId === value;
                };
            case clsgs_PViewpointRelaEN_js_1.clsgs_PViewpointRelaEN.con_SectionId:
                return (obj) => {
                    return obj.sectionId === value;
                };
            case clsgs_PViewpointRelaEN_js_1.clsgs_PViewpointRelaEN.con_ViewpointId:
                return (obj) => {
                    return obj.viewpointId === value;
                };
            case clsgs_PViewpointRelaEN_js_1.clsgs_PViewpointRelaEN.con_ProposePeople:
                return (obj) => {
                    return obj.proposePeople === value;
                };
            case clsgs_PViewpointRelaEN_js_1.clsgs_PViewpointRelaEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsgs_PViewpointRelaEN_js_1.clsgs_PViewpointRelaEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsgs_PViewpointRelaEN_js_1.clsgs_PViewpointRelaEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[gs_PViewpointRela]中不存在！(in ${exports.gs_PViewpointRela_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.gs_PViewpointRela_FilterFunByKey = gs_PViewpointRela_FilterFunByKey;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function gs_PViewpointRela_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PViewpointRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PViewpointRela_GetFirstIDAsync = gs_PViewpointRela_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function gs_PViewpointRela_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PViewpointRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PViewpointRela_GetFirstID = gs_PViewpointRela_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function gs_PViewpointRela_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PViewpointRela_Controller, strAction);
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
                const objgs_PViewpointRela = gs_PViewpointRela_GetObjFromJsonObj(returnObj);
                return objgs_PViewpointRela;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PViewpointRela_GetFirstObjAsync = gs_PViewpointRela_GetFirstObjAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function gs_PViewpointRela_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PViewpointRela_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_PViewpointRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_PViewpointRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PViewpointRela_GetObjLstAsync = gs_PViewpointRela_GetObjLstAsync;
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
    async function gs_PViewpointRela_GetObjLstBymIdLstAsync(arrmId) {
        const strThisFuncName = "GetObjLstBymIdLstAsync";
        const strAction = "GetObjLstBymIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PViewpointRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrmId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_PViewpointRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_PViewpointRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PViewpointRela_GetObjLstBymIdLstAsync = gs_PViewpointRela_GetObjLstBymIdLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function gs_PViewpointRela_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PViewpointRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_PViewpointRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_PViewpointRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PViewpointRela_GetTopObjLstAsync = gs_PViewpointRela_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function gs_PViewpointRela_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PViewpointRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_PViewpointRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_PViewpointRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PViewpointRela_GetObjLstByRangeAsync = gs_PViewpointRela_GetObjLstByRangeAsync;
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
    async function gs_PViewpointRela_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PViewpointRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PViewpointRela_GetObjLstByRange = gs_PViewpointRela_GetObjLstByRange;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function gs_PViewpointRela_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PViewpointRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_PViewpointRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_PViewpointRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PViewpointRela_GetObjLstByPagerAsync = gs_PViewpointRela_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param lngmId:关键字
    * @returns 获取删除的结果
    **/
    async function gs_PViewpointRela_DelRecordAsync(lngmId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PViewpointRela_Controller, strAction);
        strUrl = (0, clsString_js_2.Format)("{0}/?Id={1}", strUrl, lngmId);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PViewpointRela_DelRecordAsync = gs_PViewpointRela_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrmId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function gs_PViewpointRela_Delgs_PViewpointRelasAsync(arrmId) {
        const strThisFuncName = "Delgs_PViewpointRelasAsync";
        const strAction = "Delgs_PViewpointRelas";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PViewpointRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PViewpointRela_Delgs_PViewpointRelasAsync = gs_PViewpointRela_Delgs_PViewpointRelasAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function gs_PViewpointRela_Delgs_PViewpointRelasByCondAsync(strWhereCond) {
        const strThisFuncName = "Delgs_PViewpointRelasByCondAsync";
        const strAction = "Delgs_PViewpointRelasByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PViewpointRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PViewpointRela_Delgs_PViewpointRelasByCondAsync = gs_PViewpointRela_Delgs_PViewpointRelasByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objgs_PViewpointRelaEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function gs_PViewpointRela_AddNewRecordAsync(objgs_PViewpointRelaEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objgs_PViewpointRelaEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PViewpointRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_PViewpointRelaEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PViewpointRela_AddNewRecordAsync = gs_PViewpointRela_AddNewRecordAsync;
    /* 数据类型不是字符型，不可以最大关键字的方式添加记录。*/
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objgs_PViewpointRelaEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function gs_PViewpointRela_AddNewRecordWithReturnKeyAsync(objgs_PViewpointRelaEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PViewpointRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_PViewpointRelaEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PViewpointRela_AddNewRecordWithReturnKeyAsync = gs_PViewpointRela_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objgs_PViewpointRelaEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function gs_PViewpointRela_AddNewRecordWithReturnKey(objgs_PViewpointRelaEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objgs_PViewpointRelaEN.mId === null || objgs_PViewpointRelaEN.mId === 0) {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PViewpointRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_PViewpointRelaEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PViewpointRela_AddNewRecordWithReturnKey = gs_PViewpointRela_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objgs_PViewpointRelaEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function gs_PViewpointRela_UpdateRecordAsync(objgs_PViewpointRelaEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objgs_PViewpointRelaEN.sf_UpdFldSetStr === undefined || objgs_PViewpointRelaEN.sf_UpdFldSetStr === null || objgs_PViewpointRelaEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_PViewpointRelaEN.mId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PViewpointRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_PViewpointRelaEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PViewpointRela_UpdateRecordAsync = gs_PViewpointRela_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objgs_PViewpointRelaEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function gs_PViewpointRela_UpdateWithConditionAsync(objgs_PViewpointRelaEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objgs_PViewpointRelaEN.sf_UpdFldSetStr === undefined || objgs_PViewpointRelaEN.sf_UpdFldSetStr === null || objgs_PViewpointRelaEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_PViewpointRelaEN.mId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PViewpointRela_Controller, strAction);
        objgs_PViewpointRelaEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objgs_PViewpointRelaEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PViewpointRela_UpdateWithConditionAsync = gs_PViewpointRela_UpdateWithConditionAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function gs_PViewpointRela_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PViewpointRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PViewpointRela_IsExistRecordAsync = gs_PViewpointRela_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param lngmId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function gs_PViewpointRela_IsExist(lngmId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PViewpointRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PViewpointRela_IsExist = gs_PViewpointRela_IsExist;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param lngmId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function gs_PViewpointRela_IsExistAsync(lngmId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PViewpointRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PViewpointRela_IsExistAsync = gs_PViewpointRela_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function gs_PViewpointRela_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PViewpointRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PViewpointRela_GetRecCountByCondAsync = gs_PViewpointRela_GetRecCountByCondAsync;
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
    async function gs_PViewpointRela_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PViewpointRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PViewpointRela_GetMaxStrIdByPrefix = gs_PViewpointRela_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function gs_PViewpointRela_GetWebApiUrl(strController, strAction) {
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
    exports.gs_PViewpointRela_GetWebApiUrl = gs_PViewpointRela_GetWebApiUrl;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function gs_PViewpointRela_CheckPropertyNew(pobjgs_PViewpointRelaEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PViewpointRelaEN.paperId) === true
            || pobjgs_PViewpointRelaEN.paperId.toString() === "0") {
            throw new Error("(errid:Watl000058)字段[论文Id]不能为空(In 论文观点关系表)!(clsgs_PViewpointRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PViewpointRelaEN.viewpointId) === true) {
            throw new Error("(errid:Watl000058)字段[观点Id]不能为空(In 论文观点关系表)!(clsgs_PViewpointRelaBL:CheckPropertyNew)");
        }
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PViewpointRelaEN.paperId) == false && (0, clsString_js_2.GetStrLen)(pobjgs_PViewpointRelaEN.paperId) > 8) {
            throw new Error("(errid:Watl000059)字段[论文Id(paperId)]的长度不能超过8(In 论文观点关系表(gs_PViewpointRela))!值:$(pobjgs_PViewpointRelaEN.paperId)(clsgs_PViewpointRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PViewpointRelaEN.sectionId) == false && (0, clsString_js_2.GetStrLen)(pobjgs_PViewpointRelaEN.sectionId) > 8) {
            throw new Error("(errid:Watl000059)字段[节Id(sectionId)]的长度不能超过8(In 论文观点关系表(gs_PViewpointRela))!值:$(pobjgs_PViewpointRelaEN.sectionId)(clsgs_PViewpointRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PViewpointRelaEN.viewpointId) == false && (0, clsString_js_2.GetStrLen)(pobjgs_PViewpointRelaEN.viewpointId) > 8) {
            throw new Error("(errid:Watl000059)字段[观点Id(viewpointId)]的长度不能超过8(In 论文观点关系表(gs_PViewpointRela))!值:$(pobjgs_PViewpointRelaEN.viewpointId)(clsgs_PViewpointRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PViewpointRelaEN.proposePeople) == false && (0, clsString_js_2.GetStrLen)(pobjgs_PViewpointRelaEN.proposePeople) > 50) {
            throw new Error("(errid:Watl000059)字段[提出人(proposePeople)]的长度不能超过50(In 论文观点关系表(gs_PViewpointRela))!值:$(pobjgs_PViewpointRelaEN.proposePeople)(clsgs_PViewpointRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PViewpointRelaEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjgs_PViewpointRelaEN.updDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 论文观点关系表(gs_PViewpointRela))!值:$(pobjgs_PViewpointRelaEN.updDate)(clsgs_PViewpointRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PViewpointRelaEN.updUser) == false && (0, clsString_js_2.GetStrLen)(pobjgs_PViewpointRelaEN.updUser) > 20) {
            throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 论文观点关系表(gs_PViewpointRela))!值:$(pobjgs_PViewpointRelaEN.updUser)(clsgs_PViewpointRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PViewpointRelaEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjgs_PViewpointRelaEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 论文观点关系表(gs_PViewpointRela))!值:$(pobjgs_PViewpointRelaEN.memo)(clsgs_PViewpointRelaBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if (null != pobjgs_PViewpointRelaEN.mId && undefined !== pobjgs_PViewpointRelaEN.mId && clsString_js_1.tzDataType.isNumber(pobjgs_PViewpointRelaEN.mId) === false) {
            throw new Error("(errid:Watl000060)字段[mId(mId)]的值:[$(pobjgs_PViewpointRelaEN.mId)], 非法，应该为数值型(In 论文观点关系表(gs_PViewpointRela))!(clsgs_PViewpointRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PViewpointRelaEN.paperId) == false && undefined !== pobjgs_PViewpointRelaEN.paperId && clsString_js_1.tzDataType.isString(pobjgs_PViewpointRelaEN.paperId) === false) {
            throw new Error("(errid:Watl000060)字段[论文Id(paperId)]的值:[$(pobjgs_PViewpointRelaEN.paperId)], 非法，应该为字符型(In 论文观点关系表(gs_PViewpointRela))!(clsgs_PViewpointRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PViewpointRelaEN.sectionId) == false && undefined !== pobjgs_PViewpointRelaEN.sectionId && clsString_js_1.tzDataType.isString(pobjgs_PViewpointRelaEN.sectionId) === false) {
            throw new Error("(errid:Watl000060)字段[节Id(sectionId)]的值:[$(pobjgs_PViewpointRelaEN.sectionId)], 非法，应该为字符型(In 论文观点关系表(gs_PViewpointRela))!(clsgs_PViewpointRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PViewpointRelaEN.viewpointId) == false && undefined !== pobjgs_PViewpointRelaEN.viewpointId && clsString_js_1.tzDataType.isString(pobjgs_PViewpointRelaEN.viewpointId) === false) {
            throw new Error("(errid:Watl000060)字段[观点Id(viewpointId)]的值:[$(pobjgs_PViewpointRelaEN.viewpointId)], 非法，应该为字符型(In 论文观点关系表(gs_PViewpointRela))!(clsgs_PViewpointRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PViewpointRelaEN.proposePeople) == false && undefined !== pobjgs_PViewpointRelaEN.proposePeople && clsString_js_1.tzDataType.isString(pobjgs_PViewpointRelaEN.proposePeople) === false) {
            throw new Error("(errid:Watl000060)字段[提出人(proposePeople)]的值:[$(pobjgs_PViewpointRelaEN.proposePeople)], 非法，应该为字符型(In 论文观点关系表(gs_PViewpointRela))!(clsgs_PViewpointRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PViewpointRelaEN.updDate) == false && undefined !== pobjgs_PViewpointRelaEN.updDate && clsString_js_1.tzDataType.isString(pobjgs_PViewpointRelaEN.updDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjgs_PViewpointRelaEN.updDate)], 非法，应该为字符型(In 论文观点关系表(gs_PViewpointRela))!(clsgs_PViewpointRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PViewpointRelaEN.updUser) == false && undefined !== pobjgs_PViewpointRelaEN.updUser && clsString_js_1.tzDataType.isString(pobjgs_PViewpointRelaEN.updUser) === false) {
            throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjgs_PViewpointRelaEN.updUser)], 非法，应该为字符型(In 论文观点关系表(gs_PViewpointRela))!(clsgs_PViewpointRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PViewpointRelaEN.memo) == false && undefined !== pobjgs_PViewpointRelaEN.memo && clsString_js_1.tzDataType.isString(pobjgs_PViewpointRelaEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjgs_PViewpointRelaEN.memo)], 非法，应该为字符型(In 论文观点关系表(gs_PViewpointRela))!(clsgs_PViewpointRelaBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjgs_PViewpointRelaEN.SetIsCheckProperty(true);
    }
    exports.gs_PViewpointRela_CheckPropertyNew = gs_PViewpointRela_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function gs_PViewpointRela_CheckProperty4Update(pobjgs_PViewpointRelaEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PViewpointRelaEN.paperId) == false && (0, clsString_js_2.GetStrLen)(pobjgs_PViewpointRelaEN.paperId) > 8) {
            throw new Error("(errid:Watl000062)字段[论文Id(paperId)]的长度不能超过8(In 论文观点关系表(gs_PViewpointRela))!值:$(pobjgs_PViewpointRelaEN.paperId)(clsgs_PViewpointRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PViewpointRelaEN.sectionId) == false && (0, clsString_js_2.GetStrLen)(pobjgs_PViewpointRelaEN.sectionId) > 8) {
            throw new Error("(errid:Watl000062)字段[节Id(sectionId)]的长度不能超过8(In 论文观点关系表(gs_PViewpointRela))!值:$(pobjgs_PViewpointRelaEN.sectionId)(clsgs_PViewpointRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PViewpointRelaEN.viewpointId) == false && (0, clsString_js_2.GetStrLen)(pobjgs_PViewpointRelaEN.viewpointId) > 8) {
            throw new Error("(errid:Watl000062)字段[观点Id(viewpointId)]的长度不能超过8(In 论文观点关系表(gs_PViewpointRela))!值:$(pobjgs_PViewpointRelaEN.viewpointId)(clsgs_PViewpointRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PViewpointRelaEN.proposePeople) == false && (0, clsString_js_2.GetStrLen)(pobjgs_PViewpointRelaEN.proposePeople) > 50) {
            throw new Error("(errid:Watl000062)字段[提出人(proposePeople)]的长度不能超过50(In 论文观点关系表(gs_PViewpointRela))!值:$(pobjgs_PViewpointRelaEN.proposePeople)(clsgs_PViewpointRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PViewpointRelaEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjgs_PViewpointRelaEN.updDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 论文观点关系表(gs_PViewpointRela))!值:$(pobjgs_PViewpointRelaEN.updDate)(clsgs_PViewpointRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PViewpointRelaEN.updUser) == false && (0, clsString_js_2.GetStrLen)(pobjgs_PViewpointRelaEN.updUser) > 20) {
            throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 论文观点关系表(gs_PViewpointRela))!值:$(pobjgs_PViewpointRelaEN.updUser)(clsgs_PViewpointRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PViewpointRelaEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjgs_PViewpointRelaEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 论文观点关系表(gs_PViewpointRela))!值:$(pobjgs_PViewpointRelaEN.memo)(clsgs_PViewpointRelaBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if (null != pobjgs_PViewpointRelaEN.mId && undefined !== pobjgs_PViewpointRelaEN.mId && clsString_js_1.tzDataType.isNumber(pobjgs_PViewpointRelaEN.mId) === false) {
            throw new Error("(errid:Watl000063)字段[mId(mId)]的值:[$(pobjgs_PViewpointRelaEN.mId)], 非法，应该为数值型(In 论文观点关系表(gs_PViewpointRela))!(clsgs_PViewpointRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PViewpointRelaEN.paperId) == false && undefined !== pobjgs_PViewpointRelaEN.paperId && clsString_js_1.tzDataType.isString(pobjgs_PViewpointRelaEN.paperId) === false) {
            throw new Error("(errid:Watl000063)字段[论文Id(paperId)]的值:[$(pobjgs_PViewpointRelaEN.paperId)], 非法，应该为字符型(In 论文观点关系表(gs_PViewpointRela))!(clsgs_PViewpointRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PViewpointRelaEN.sectionId) == false && undefined !== pobjgs_PViewpointRelaEN.sectionId && clsString_js_1.tzDataType.isString(pobjgs_PViewpointRelaEN.sectionId) === false) {
            throw new Error("(errid:Watl000063)字段[节Id(sectionId)]的值:[$(pobjgs_PViewpointRelaEN.sectionId)], 非法，应该为字符型(In 论文观点关系表(gs_PViewpointRela))!(clsgs_PViewpointRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PViewpointRelaEN.viewpointId) == false && undefined !== pobjgs_PViewpointRelaEN.viewpointId && clsString_js_1.tzDataType.isString(pobjgs_PViewpointRelaEN.viewpointId) === false) {
            throw new Error("(errid:Watl000063)字段[观点Id(viewpointId)]的值:[$(pobjgs_PViewpointRelaEN.viewpointId)], 非法，应该为字符型(In 论文观点关系表(gs_PViewpointRela))!(clsgs_PViewpointRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PViewpointRelaEN.proposePeople) == false && undefined !== pobjgs_PViewpointRelaEN.proposePeople && clsString_js_1.tzDataType.isString(pobjgs_PViewpointRelaEN.proposePeople) === false) {
            throw new Error("(errid:Watl000063)字段[提出人(proposePeople)]的值:[$(pobjgs_PViewpointRelaEN.proposePeople)], 非法，应该为字符型(In 论文观点关系表(gs_PViewpointRela))!(clsgs_PViewpointRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PViewpointRelaEN.updDate) == false && undefined !== pobjgs_PViewpointRelaEN.updDate && clsString_js_1.tzDataType.isString(pobjgs_PViewpointRelaEN.updDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjgs_PViewpointRelaEN.updDate)], 非法，应该为字符型(In 论文观点关系表(gs_PViewpointRela))!(clsgs_PViewpointRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PViewpointRelaEN.updUser) == false && undefined !== pobjgs_PViewpointRelaEN.updUser && clsString_js_1.tzDataType.isString(pobjgs_PViewpointRelaEN.updUser) === false) {
            throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjgs_PViewpointRelaEN.updUser)], 非法，应该为字符型(In 论文观点关系表(gs_PViewpointRela))!(clsgs_PViewpointRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_PViewpointRelaEN.memo) == false && undefined !== pobjgs_PViewpointRelaEN.memo && clsString_js_1.tzDataType.isString(pobjgs_PViewpointRelaEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjgs_PViewpointRelaEN.memo)], 非法，应该为字符型(In 论文观点关系表(gs_PViewpointRela))!(clsgs_PViewpointRelaBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if (null === pobjgs_PViewpointRelaEN.mId
            || pobjgs_PViewpointRelaEN.mId != null && pobjgs_PViewpointRelaEN.mId.toString() === "") {
            throw new Error("(errid:Watl000064)字段[mId]不能为空(In 论文观点关系表)!(clsgs_PViewpointRelaBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjgs_PViewpointRelaEN.SetIsCheckProperty(true);
    }
    exports.gs_PViewpointRela_CheckProperty4Update = gs_PViewpointRela_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function gs_PViewpointRela_GetJSONStrByObj(pobjgs_PViewpointRelaEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjgs_PViewpointRelaEN.sf_UpdFldSetStr = pobjgs_PViewpointRelaEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjgs_PViewpointRelaEN);
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
    exports.gs_PViewpointRela_GetJSONStrByObj = gs_PViewpointRela_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function gs_PViewpointRela_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrgs_PViewpointRelaObjLst = new Array();
        if (strJSON === "") {
            return arrgs_PViewpointRelaObjLst;
        }
        try {
            arrgs_PViewpointRelaObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrgs_PViewpointRelaObjLst;
        }
        return arrgs_PViewpointRelaObjLst;
    }
    exports.gs_PViewpointRela_GetObjLstByJSONStr = gs_PViewpointRela_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrgs_PViewpointRelaObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function gs_PViewpointRela_GetObjLstByJSONObjLst(arrgs_PViewpointRelaObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrgs_PViewpointRelaObjLst = new Array();
        for (const objInFor of arrgs_PViewpointRelaObjLstS) {
            const obj1 = gs_PViewpointRela_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrgs_PViewpointRelaObjLst.push(obj1);
        }
        return arrgs_PViewpointRelaObjLst;
    }
    exports.gs_PViewpointRela_GetObjLstByJSONObjLst = gs_PViewpointRela_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function gs_PViewpointRela_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjgs_PViewpointRelaEN = new clsgs_PViewpointRelaEN_js_1.clsgs_PViewpointRelaEN();
        if (strJSON === "") {
            return pobjgs_PViewpointRelaEN;
        }
        try {
            pobjgs_PViewpointRelaEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjgs_PViewpointRelaEN;
        }
        return pobjgs_PViewpointRelaEN;
    }
    exports.gs_PViewpointRela_GetObjByJSONStr = gs_PViewpointRela_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function gs_PViewpointRela_GetCombineCondition(objgs_PViewpointRela_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objgs_PViewpointRela_Cond.dicFldComparisonOp, clsgs_PViewpointRelaEN_js_1.clsgs_PViewpointRelaEN.con_mId) == true) {
            const strComparisonOp_mId = objgs_PViewpointRela_Cond.dicFldComparisonOp[clsgs_PViewpointRelaEN_js_1.clsgs_PViewpointRelaEN.con_mId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsgs_PViewpointRelaEN_js_1.clsgs_PViewpointRelaEN.con_mId, objgs_PViewpointRela_Cond.mId, strComparisonOp_mId);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_PViewpointRela_Cond.dicFldComparisonOp, clsgs_PViewpointRelaEN_js_1.clsgs_PViewpointRelaEN.con_PaperId) == true) {
            const strComparisonOp_PaperId = objgs_PViewpointRela_Cond.dicFldComparisonOp[clsgs_PViewpointRelaEN_js_1.clsgs_PViewpointRelaEN.con_PaperId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_PViewpointRelaEN_js_1.clsgs_PViewpointRelaEN.con_PaperId, objgs_PViewpointRela_Cond.paperId, strComparisonOp_PaperId);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_PViewpointRela_Cond.dicFldComparisonOp, clsgs_PViewpointRelaEN_js_1.clsgs_PViewpointRelaEN.con_SectionId) == true) {
            const strComparisonOp_SectionId = objgs_PViewpointRela_Cond.dicFldComparisonOp[clsgs_PViewpointRelaEN_js_1.clsgs_PViewpointRelaEN.con_SectionId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_PViewpointRelaEN_js_1.clsgs_PViewpointRelaEN.con_SectionId, objgs_PViewpointRela_Cond.sectionId, strComparisonOp_SectionId);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_PViewpointRela_Cond.dicFldComparisonOp, clsgs_PViewpointRelaEN_js_1.clsgs_PViewpointRelaEN.con_ViewpointId) == true) {
            const strComparisonOp_ViewpointId = objgs_PViewpointRela_Cond.dicFldComparisonOp[clsgs_PViewpointRelaEN_js_1.clsgs_PViewpointRelaEN.con_ViewpointId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_PViewpointRelaEN_js_1.clsgs_PViewpointRelaEN.con_ViewpointId, objgs_PViewpointRela_Cond.viewpointId, strComparisonOp_ViewpointId);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_PViewpointRela_Cond.dicFldComparisonOp, clsgs_PViewpointRelaEN_js_1.clsgs_PViewpointRelaEN.con_ProposePeople) == true) {
            const strComparisonOp_ProposePeople = objgs_PViewpointRela_Cond.dicFldComparisonOp[clsgs_PViewpointRelaEN_js_1.clsgs_PViewpointRelaEN.con_ProposePeople];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_PViewpointRelaEN_js_1.clsgs_PViewpointRelaEN.con_ProposePeople, objgs_PViewpointRela_Cond.proposePeople, strComparisonOp_ProposePeople);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_PViewpointRela_Cond.dicFldComparisonOp, clsgs_PViewpointRelaEN_js_1.clsgs_PViewpointRelaEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objgs_PViewpointRela_Cond.dicFldComparisonOp[clsgs_PViewpointRelaEN_js_1.clsgs_PViewpointRelaEN.con_UpdDate];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_PViewpointRelaEN_js_1.clsgs_PViewpointRelaEN.con_UpdDate, objgs_PViewpointRela_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_PViewpointRela_Cond.dicFldComparisonOp, clsgs_PViewpointRelaEN_js_1.clsgs_PViewpointRelaEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objgs_PViewpointRela_Cond.dicFldComparisonOp[clsgs_PViewpointRelaEN_js_1.clsgs_PViewpointRelaEN.con_UpdUser];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_PViewpointRelaEN_js_1.clsgs_PViewpointRelaEN.con_UpdUser, objgs_PViewpointRela_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_PViewpointRela_Cond.dicFldComparisonOp, clsgs_PViewpointRelaEN_js_1.clsgs_PViewpointRelaEN.con_Memo) == true) {
            const strComparisonOp_Memo = objgs_PViewpointRela_Cond.dicFldComparisonOp[clsgs_PViewpointRelaEN_js_1.clsgs_PViewpointRelaEN.con_Memo];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_PViewpointRelaEN_js_1.clsgs_PViewpointRelaEN.con_Memo, objgs_PViewpointRela_Cond.memo, strComparisonOp_Memo);
        }
        return strWhereCond;
    }
    exports.gs_PViewpointRela_GetCombineCondition = gs_PViewpointRela_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--gs_PViewpointRela(论文观点关系表),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param lngmId: mId(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function gs_PViewpointRela_GetUniCondStr_mId(objgs_PViewpointRelaEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and mId = '{0}'", objgs_PViewpointRelaEN.mId);
        return strWhereCond;
    }
    exports.gs_PViewpointRela_GetUniCondStr_mId = gs_PViewpointRela_GetUniCondStr_mId;
    /**
    *获取唯一性条件串(Uniqueness)--gs_PViewpointRela(论文观点关系表),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param strPaperId: 论文Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function gs_PViewpointRela_GetUniCondStr_PaperId(objgs_PViewpointRelaEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and PaperId = '{0}'", objgs_PViewpointRelaEN.paperId);
        return strWhereCond;
    }
    exports.gs_PViewpointRela_GetUniCondStr_PaperId = gs_PViewpointRela_GetUniCondStr_PaperId;
    /**
    *获取唯一性条件串(Uniqueness)--gs_PViewpointRela(论文观点关系表),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param lngmId: mId(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function gs_PViewpointRela_GetUniCondStr4Update_mId(objgs_PViewpointRelaEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and mId <> '{0}'", objgs_PViewpointRelaEN.mId);
        strWhereCond += (0, clsString_js_2.Format)(" and mId = '{0}'", objgs_PViewpointRelaEN.mId);
        return strWhereCond;
    }
    exports.gs_PViewpointRela_GetUniCondStr4Update_mId = gs_PViewpointRela_GetUniCondStr4Update_mId;
    /**
    *获取唯一性条件串(Uniqueness)--gs_PViewpointRela(论文观点关系表),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param strPaperId: 论文Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function gs_PViewpointRela_GetUniCondStr4Update_PaperId(objgs_PViewpointRelaEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and mId <> '{0}'", objgs_PViewpointRelaEN.mId);
        strWhereCond += (0, clsString_js_2.Format)(" and PaperId = '{0}'", objgs_PViewpointRelaEN.paperId);
        return strWhereCond;
    }
    exports.gs_PViewpointRela_GetUniCondStr4Update_PaperId = gs_PViewpointRela_GetUniCondStr4Update_PaperId;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objgs_PViewpointRelaENS:源对象
     * @param objgs_PViewpointRelaENT:目标对象
    */
    function gs_PViewpointRela_CopyObjTo(objgs_PViewpointRelaENS, objgs_PViewpointRelaENT) {
        objgs_PViewpointRelaENT.mId = objgs_PViewpointRelaENS.mId; //mId
        objgs_PViewpointRelaENT.paperId = objgs_PViewpointRelaENS.paperId; //论文Id
        objgs_PViewpointRelaENT.sectionId = objgs_PViewpointRelaENS.sectionId; //节Id
        objgs_PViewpointRelaENT.viewpointId = objgs_PViewpointRelaENS.viewpointId; //观点Id
        objgs_PViewpointRelaENT.proposePeople = objgs_PViewpointRelaENS.proposePeople; //提出人
        objgs_PViewpointRelaENT.updDate = objgs_PViewpointRelaENS.updDate; //修改日期
        objgs_PViewpointRelaENT.updUser = objgs_PViewpointRelaENS.updUser; //修改人
        objgs_PViewpointRelaENT.memo = objgs_PViewpointRelaENS.memo; //备注
        objgs_PViewpointRelaENT.sf_UpdFldSetStr = objgs_PViewpointRelaENS.updFldString; //sf_UpdFldSetStr
    }
    exports.gs_PViewpointRela_CopyObjTo = gs_PViewpointRela_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objgs_PViewpointRelaENS:源对象
     * @param objgs_PViewpointRelaENT:目标对象
    */
    function gs_PViewpointRela_GetObjFromJsonObj(objgs_PViewpointRelaENS) {
        const objgs_PViewpointRelaENT = new clsgs_PViewpointRelaEN_js_1.clsgs_PViewpointRelaEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objgs_PViewpointRelaENT, objgs_PViewpointRelaENS);
        return objgs_PViewpointRelaENT;
    }
    exports.gs_PViewpointRela_GetObjFromJsonObj = gs_PViewpointRela_GetObjFromJsonObj;
});
