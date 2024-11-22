/**
* 类名:clsRTConceptRelaWApi
* 表名:RTConceptRela(01120605)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/13 00:50:22
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
        define(["require", "exports", "axios", "../../L0_Entity/GraduateEduTopic/clsRTConceptRelaEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.RTConceptRela_GetObjFromJsonObj = exports.RTConceptRela_CopyObjTo = exports.RTConceptRela_GetUniCondStr4Update_mId_TopicId_ConceptId = exports.RTConceptRela_GetUniCondStr_mId_TopicId_ConceptId = exports.RTConceptRela_GetCombineCondition = exports.RTConceptRela_GetObjByJSONStr = exports.RTConceptRela_GetObjLstByJSONObjLst = exports.RTConceptRela_GetObjLstByJSONStr = exports.RTConceptRela_GetJSONStrByObj = exports.RTConceptRela_CheckProperty4Update = exports.RTConceptRela_CheckPropertyNew = exports.RTConceptRela_GetWebApiUrl = exports.RTConceptRela_GetMaxStrIdByPrefix = exports.RTConceptRela_GetRecCountByCondAsync = exports.RTConceptRela_IsExistAsync = exports.RTConceptRela_IsExist = exports.RTConceptRela_IsExistRecordAsync = exports.RTConceptRela_UpdateWithConditionAsync = exports.RTConceptRela_UpdateRecordAsync = exports.RTConceptRela_AddNewRecordWithReturnKey = exports.RTConceptRela_AddNewRecordWithReturnKeyAsync = exports.RTConceptRela_AddNewRecordAsync = exports.RTConceptRela_DelRTConceptRelasByCondAsync = exports.RTConceptRela_DelRTConceptRelasAsync = exports.RTConceptRela_DelRecordAsync = exports.RTConceptRela_GetObjLstByPagerAsync = exports.RTConceptRela_GetObjLstByRange = exports.RTConceptRela_GetObjLstByRangeAsync = exports.RTConceptRela_GetTopObjLstAsync = exports.RTConceptRela_GetObjLstBymIdLstAsync = exports.RTConceptRela_GetObjLstAsync = exports.RTConceptRela_GetFirstObjAsync = exports.RTConceptRela_GetFirstID = exports.RTConceptRela_GetFirstIDAsync = exports.RTConceptRela_FilterFunByKey = exports.RTConceptRela_SortFunByKey = exports.RTConceptRela_SortFun_Defa_2Fld = exports.RTConceptRela_SortFun_Defa = exports.RTConceptRela_GetObjBymIdAsync = exports.rTConceptRela_ConstructorName = exports.rTConceptRela_Controller = void 0;
    /**
     * 主题概念关系表(RTConceptRela)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月13日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const clsRTConceptRelaEN_js_1 = require("../../L0_Entity/GraduateEduTopic/clsRTConceptRelaEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsString_js_2 = require("../../PubFun/clsString.js");
    exports.rTConceptRela_Controller = "RTConceptRelaApi";
    exports.rTConceptRela_ConstructorName = "rTConceptRela";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param lngmId:关键字
    * @returns 对象
    **/
    async function RTConceptRela_GetObjBymIdAsync(lngmId) {
        const strThisFuncName = "GetObjBymIdAsync";
        if (lngmId == 0) {
            const strMsg = (0, clsString_js_2.Format)("参数:[lngmId]不能为空！(In clsRTConceptRelaWApi.GetObjBymIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjBymId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTConceptRela_Controller, strAction);
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
                const objRTConceptRela = RTConceptRela_GetObjFromJsonObj(returnObj);
                return objRTConceptRela;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTConceptRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTConceptRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTConceptRela_GetObjBymIdAsync = RTConceptRela_GetObjBymIdAsync;
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
    function RTConceptRela_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.mId - b.mId;
    }
    exports.RTConceptRela_SortFun_Defa = RTConceptRela_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function RTConceptRela_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.topicId == b.topicId)
            return a.conceptId.localeCompare(b.conceptId);
        else
            return a.topicId.localeCompare(b.topicId);
    }
    exports.RTConceptRela_SortFun_Defa_2Fld = RTConceptRela_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function RTConceptRela_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsRTConceptRelaEN_js_1.clsRTConceptRelaEN.con_mId:
                    return (a, b) => {
                        return a.mId - b.mId;
                    };
                case clsRTConceptRelaEN_js_1.clsRTConceptRelaEN.con_TopicId:
                    return (a, b) => {
                        if (a.topicId == null)
                            return -1;
                        if (b.topicId == null)
                            return 1;
                        return a.topicId.localeCompare(b.topicId);
                    };
                case clsRTConceptRelaEN_js_1.clsRTConceptRelaEN.con_ConceptId:
                    return (a, b) => {
                        return a.conceptId.localeCompare(b.conceptId);
                    };
                case clsRTConceptRelaEN_js_1.clsRTConceptRelaEN.con_UpdDate:
                    return (a, b) => {
                        if (a.updDate == null)
                            return -1;
                        if (b.updDate == null)
                            return 1;
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsRTConceptRelaEN_js_1.clsRTConceptRelaEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                case clsRTConceptRelaEN_js_1.clsRTConceptRelaEN.con_UpdUser:
                    return (a, b) => {
                        if (a.updUser == null)
                            return -1;
                        if (b.updUser == null)
                            return 1;
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsRTConceptRelaEN_js_1.clsRTConceptRelaEN.con_ClassificationId:
                    return (a, b) => {
                        if (a.classificationId == null)
                            return -1;
                        if (b.classificationId == null)
                            return 1;
                        return a.classificationId.localeCompare(b.classificationId);
                    };
                case clsRTConceptRelaEN_js_1.clsRTConceptRelaEN.con_id_CurrEduCls:
                    return (a, b) => {
                        if (a.id_CurrEduCls == null)
                            return -1;
                        if (b.id_CurrEduCls == null)
                            return 1;
                        return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[RTConceptRela]中不存在！(in ${exports.rTConceptRela_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsRTConceptRelaEN_js_1.clsRTConceptRelaEN.con_mId:
                    return (a, b) => {
                        return b.mId - a.mId;
                    };
                case clsRTConceptRelaEN_js_1.clsRTConceptRelaEN.con_TopicId:
                    return (a, b) => {
                        if (b.topicId == null)
                            return -1;
                        if (a.topicId == null)
                            return 1;
                        return b.topicId.localeCompare(a.topicId);
                    };
                case clsRTConceptRelaEN_js_1.clsRTConceptRelaEN.con_ConceptId:
                    return (a, b) => {
                        return b.conceptId.localeCompare(a.conceptId);
                    };
                case clsRTConceptRelaEN_js_1.clsRTConceptRelaEN.con_UpdDate:
                    return (a, b) => {
                        if (b.updDate == null)
                            return -1;
                        if (a.updDate == null)
                            return 1;
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsRTConceptRelaEN_js_1.clsRTConceptRelaEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                case clsRTConceptRelaEN_js_1.clsRTConceptRelaEN.con_UpdUser:
                    return (a, b) => {
                        if (b.updUser == null)
                            return -1;
                        if (a.updUser == null)
                            return 1;
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsRTConceptRelaEN_js_1.clsRTConceptRelaEN.con_ClassificationId:
                    return (a, b) => {
                        if (b.classificationId == null)
                            return -1;
                        if (a.classificationId == null)
                            return 1;
                        return b.classificationId.localeCompare(a.classificationId);
                    };
                case clsRTConceptRelaEN_js_1.clsRTConceptRelaEN.con_id_CurrEduCls:
                    return (a, b) => {
                        if (b.id_CurrEduCls == null)
                            return -1;
                        if (a.id_CurrEduCls == null)
                            return 1;
                        return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[RTConceptRela]中不存在！(in ${exports.rTConceptRela_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.RTConceptRela_SortFunByKey = RTConceptRela_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function RTConceptRela_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsRTConceptRelaEN_js_1.clsRTConceptRelaEN.con_mId:
                return (obj) => {
                    return obj.mId === value;
                };
            case clsRTConceptRelaEN_js_1.clsRTConceptRelaEN.con_TopicId:
                return (obj) => {
                    return obj.topicId === value;
                };
            case clsRTConceptRelaEN_js_1.clsRTConceptRelaEN.con_ConceptId:
                return (obj) => {
                    return obj.conceptId === value;
                };
            case clsRTConceptRelaEN_js_1.clsRTConceptRelaEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsRTConceptRelaEN_js_1.clsRTConceptRelaEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            case clsRTConceptRelaEN_js_1.clsRTConceptRelaEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsRTConceptRelaEN_js_1.clsRTConceptRelaEN.con_ClassificationId:
                return (obj) => {
                    return obj.classificationId === value;
                };
            case clsRTConceptRelaEN_js_1.clsRTConceptRelaEN.con_id_CurrEduCls:
                return (obj) => {
                    return obj.id_CurrEduCls === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[RTConceptRela]中不存在！(in ${exports.rTConceptRela_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.RTConceptRela_FilterFunByKey = RTConceptRela_FilterFunByKey;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function RTConceptRela_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTConceptRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTConceptRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTConceptRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTConceptRela_GetFirstIDAsync = RTConceptRela_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function RTConceptRela_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTConceptRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTConceptRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTConceptRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTConceptRela_GetFirstID = RTConceptRela_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function RTConceptRela_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTConceptRela_Controller, strAction);
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
                const objRTConceptRela = RTConceptRela_GetObjFromJsonObj(returnObj);
                return objRTConceptRela;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTConceptRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTConceptRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTConceptRela_GetFirstObjAsync = RTConceptRela_GetFirstObjAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function RTConceptRela_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTConceptRela_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.rTConceptRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = RTConceptRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTConceptRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTConceptRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTConceptRela_GetObjLstAsync = RTConceptRela_GetObjLstAsync;
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
    async function RTConceptRela_GetObjLstBymIdLstAsync(arrmId) {
        const strThisFuncName = "GetObjLstBymIdLstAsync";
        const strAction = "GetObjLstBymIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTConceptRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrmId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.rTConceptRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = RTConceptRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTConceptRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTConceptRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTConceptRela_GetObjLstBymIdLstAsync = RTConceptRela_GetObjLstBymIdLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function RTConceptRela_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTConceptRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.rTConceptRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = RTConceptRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTConceptRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTConceptRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTConceptRela_GetTopObjLstAsync = RTConceptRela_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function RTConceptRela_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTConceptRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.rTConceptRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = RTConceptRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTConceptRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTConceptRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTConceptRela_GetObjLstByRangeAsync = RTConceptRela_GetObjLstByRangeAsync;
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
    async function RTConceptRela_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTConceptRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTConceptRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTConceptRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTConceptRela_GetObjLstByRange = RTConceptRela_GetObjLstByRange;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function RTConceptRela_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTConceptRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.rTConceptRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = RTConceptRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTConceptRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTConceptRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTConceptRela_GetObjLstByPagerAsync = RTConceptRela_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param lngmId:关键字
    * @returns 获取删除的结果
    **/
    async function RTConceptRela_DelRecordAsync(lngmId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTConceptRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTConceptRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTConceptRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTConceptRela_DelRecordAsync = RTConceptRela_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrmId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function RTConceptRela_DelRTConceptRelasAsync(arrmId) {
        const strThisFuncName = "DelRTConceptRelasAsync";
        const strAction = "DelRTConceptRelas";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTConceptRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTConceptRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTConceptRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTConceptRela_DelRTConceptRelasAsync = RTConceptRela_DelRTConceptRelasAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function RTConceptRela_DelRTConceptRelasByCondAsync(strWhereCond) {
        const strThisFuncName = "DelRTConceptRelasByCondAsync";
        const strAction = "DelRTConceptRelasByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTConceptRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTConceptRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTConceptRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTConceptRela_DelRTConceptRelasByCondAsync = RTConceptRela_DelRTConceptRelasByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objRTConceptRelaEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function RTConceptRela_AddNewRecordAsync(objRTConceptRelaEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objRTConceptRelaEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTConceptRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRTConceptRelaEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTConceptRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTConceptRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTConceptRela_AddNewRecordAsync = RTConceptRela_AddNewRecordAsync;
    /* 数据类型不是字符型，不可以最大关键字的方式添加记录。*/
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objRTConceptRelaEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function RTConceptRela_AddNewRecordWithReturnKeyAsync(objRTConceptRelaEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTConceptRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRTConceptRelaEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTConceptRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTConceptRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTConceptRela_AddNewRecordWithReturnKeyAsync = RTConceptRela_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objRTConceptRelaEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function RTConceptRela_AddNewRecordWithReturnKey(objRTConceptRelaEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objRTConceptRelaEN.mId === null || objRTConceptRelaEN.mId === 0) {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTConceptRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRTConceptRelaEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTConceptRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTConceptRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTConceptRela_AddNewRecordWithReturnKey = RTConceptRela_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objRTConceptRelaEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function RTConceptRela_UpdateRecordAsync(objRTConceptRelaEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objRTConceptRelaEN.sf_UpdFldSetStr === undefined || objRTConceptRelaEN.sf_UpdFldSetStr === null || objRTConceptRelaEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objRTConceptRelaEN.mId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTConceptRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRTConceptRelaEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTConceptRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTConceptRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTConceptRela_UpdateRecordAsync = RTConceptRela_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objRTConceptRelaEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function RTConceptRela_UpdateWithConditionAsync(objRTConceptRelaEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objRTConceptRelaEN.sf_UpdFldSetStr === undefined || objRTConceptRelaEN.sf_UpdFldSetStr === null || objRTConceptRelaEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objRTConceptRelaEN.mId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTConceptRela_Controller, strAction);
        objRTConceptRelaEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objRTConceptRelaEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTConceptRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTConceptRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTConceptRela_UpdateWithConditionAsync = RTConceptRela_UpdateWithConditionAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function RTConceptRela_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTConceptRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTConceptRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTConceptRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTConceptRela_IsExistRecordAsync = RTConceptRela_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param lngmId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function RTConceptRela_IsExist(lngmId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTConceptRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTConceptRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTConceptRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTConceptRela_IsExist = RTConceptRela_IsExist;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param lngmId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function RTConceptRela_IsExistAsync(lngmId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTConceptRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTConceptRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTConceptRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTConceptRela_IsExistAsync = RTConceptRela_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function RTConceptRela_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTConceptRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTConceptRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTConceptRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTConceptRela_GetRecCountByCondAsync = RTConceptRela_GetRecCountByCondAsync;
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
    async function RTConceptRela_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTConceptRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTConceptRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTConceptRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTConceptRela_GetMaxStrIdByPrefix = RTConceptRela_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function RTConceptRela_GetWebApiUrl(strController, strAction) {
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
    exports.RTConceptRela_GetWebApiUrl = RTConceptRela_GetWebApiUrl;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function RTConceptRela_CheckPropertyNew(pobjRTConceptRelaEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjRTConceptRelaEN.conceptId) === true) {
            throw new Error("(errid:Watl000058)字段[概念Id]不能为空(In 主题概念关系表)!(clsRTConceptRelaBL:CheckPropertyNew)");
        }
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjRTConceptRelaEN.topicId) == false && (0, clsString_js_2.GetStrLen)(pobjRTConceptRelaEN.topicId) > 8) {
            throw new Error("(errid:Watl000059)字段[主题Id(topicId)]的长度不能超过8(In 主题概念关系表(RTConceptRela))!值:$(pobjRTConceptRelaEN.topicId)(clsRTConceptRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjRTConceptRelaEN.conceptId) == false && (0, clsString_js_2.GetStrLen)(pobjRTConceptRelaEN.conceptId) > 8) {
            throw new Error("(errid:Watl000059)字段[概念Id(conceptId)]的长度不能超过8(In 主题概念关系表(RTConceptRela))!值:$(pobjRTConceptRelaEN.conceptId)(clsRTConceptRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjRTConceptRelaEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjRTConceptRelaEN.updDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 主题概念关系表(RTConceptRela))!值:$(pobjRTConceptRelaEN.updDate)(clsRTConceptRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjRTConceptRelaEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjRTConceptRelaEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 主题概念关系表(RTConceptRela))!值:$(pobjRTConceptRelaEN.memo)(clsRTConceptRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjRTConceptRelaEN.updUser) == false && (0, clsString_js_2.GetStrLen)(pobjRTConceptRelaEN.updUser) > 20) {
            throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 主题概念关系表(RTConceptRela))!值:$(pobjRTConceptRelaEN.updUser)(clsRTConceptRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjRTConceptRelaEN.classificationId) == false && (0, clsString_js_2.GetStrLen)(pobjRTConceptRelaEN.classificationId) > 10) {
            throw new Error("(errid:Watl000059)字段[分类Id(classificationId)]的长度不能超过10(In 主题概念关系表(RTConceptRela))!值:$(pobjRTConceptRelaEN.classificationId)(clsRTConceptRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjRTConceptRelaEN.id_CurrEduCls) == false && (0, clsString_js_2.GetStrLen)(pobjRTConceptRelaEN.id_CurrEduCls) > 8) {
            throw new Error("(errid:Watl000059)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 主题概念关系表(RTConceptRela))!值:$(pobjRTConceptRelaEN.id_CurrEduCls)(clsRTConceptRelaBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if (null != pobjRTConceptRelaEN.mId && undefined !== pobjRTConceptRelaEN.mId && clsString_js_1.tzDataType.isNumber(pobjRTConceptRelaEN.mId) === false) {
            throw new Error("(errid:Watl000060)字段[mId(mId)]的值:[$(pobjRTConceptRelaEN.mId)], 非法，应该为数值型(In 主题概念关系表(RTConceptRela))!(clsRTConceptRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjRTConceptRelaEN.topicId) == false && undefined !== pobjRTConceptRelaEN.topicId && clsString_js_1.tzDataType.isString(pobjRTConceptRelaEN.topicId) === false) {
            throw new Error("(errid:Watl000060)字段[主题Id(topicId)]的值:[$(pobjRTConceptRelaEN.topicId)], 非法，应该为字符型(In 主题概念关系表(RTConceptRela))!(clsRTConceptRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjRTConceptRelaEN.conceptId) == false && undefined !== pobjRTConceptRelaEN.conceptId && clsString_js_1.tzDataType.isString(pobjRTConceptRelaEN.conceptId) === false) {
            throw new Error("(errid:Watl000060)字段[概念Id(conceptId)]的值:[$(pobjRTConceptRelaEN.conceptId)], 非法，应该为字符型(In 主题概念关系表(RTConceptRela))!(clsRTConceptRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjRTConceptRelaEN.updDate) == false && undefined !== pobjRTConceptRelaEN.updDate && clsString_js_1.tzDataType.isString(pobjRTConceptRelaEN.updDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjRTConceptRelaEN.updDate)], 非法，应该为字符型(In 主题概念关系表(RTConceptRela))!(clsRTConceptRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjRTConceptRelaEN.memo) == false && undefined !== pobjRTConceptRelaEN.memo && clsString_js_1.tzDataType.isString(pobjRTConceptRelaEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjRTConceptRelaEN.memo)], 非法，应该为字符型(In 主题概念关系表(RTConceptRela))!(clsRTConceptRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjRTConceptRelaEN.updUser) == false && undefined !== pobjRTConceptRelaEN.updUser && clsString_js_1.tzDataType.isString(pobjRTConceptRelaEN.updUser) === false) {
            throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjRTConceptRelaEN.updUser)], 非法，应该为字符型(In 主题概念关系表(RTConceptRela))!(clsRTConceptRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjRTConceptRelaEN.classificationId) == false && undefined !== pobjRTConceptRelaEN.classificationId && clsString_js_1.tzDataType.isString(pobjRTConceptRelaEN.classificationId) === false) {
            throw new Error("(errid:Watl000060)字段[分类Id(classificationId)]的值:[$(pobjRTConceptRelaEN.classificationId)], 非法，应该为字符型(In 主题概念关系表(RTConceptRela))!(clsRTConceptRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjRTConceptRelaEN.id_CurrEduCls) == false && undefined !== pobjRTConceptRelaEN.id_CurrEduCls && clsString_js_1.tzDataType.isString(pobjRTConceptRelaEN.id_CurrEduCls) === false) {
            throw new Error("(errid:Watl000060)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjRTConceptRelaEN.id_CurrEduCls)], 非法，应该为字符型(In 主题概念关系表(RTConceptRela))!(clsRTConceptRelaBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjRTConceptRelaEN.topicId) == false && (0, clsString_js_2.GetStrLen)(pobjRTConceptRelaEN.topicId) != 8) {
            throw ("(errid:Watl000061)字段[主题Id]作为外键字段,长度应该为8(In 主题概念关系表)!(clsRTConceptRelaBL:CheckPropertyNew)");
        }
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjRTConceptRelaEN.SetIsCheckProperty(true);
    }
    exports.RTConceptRela_CheckPropertyNew = RTConceptRela_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function RTConceptRela_CheckProperty4Update(pobjRTConceptRelaEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjRTConceptRelaEN.topicId) == false && (0, clsString_js_2.GetStrLen)(pobjRTConceptRelaEN.topicId) > 8) {
            throw new Error("(errid:Watl000062)字段[主题Id(topicId)]的长度不能超过8(In 主题概念关系表(RTConceptRela))!值:$(pobjRTConceptRelaEN.topicId)(clsRTConceptRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjRTConceptRelaEN.conceptId) == false && (0, clsString_js_2.GetStrLen)(pobjRTConceptRelaEN.conceptId) > 8) {
            throw new Error("(errid:Watl000062)字段[概念Id(conceptId)]的长度不能超过8(In 主题概念关系表(RTConceptRela))!值:$(pobjRTConceptRelaEN.conceptId)(clsRTConceptRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjRTConceptRelaEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjRTConceptRelaEN.updDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 主题概念关系表(RTConceptRela))!值:$(pobjRTConceptRelaEN.updDate)(clsRTConceptRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjRTConceptRelaEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjRTConceptRelaEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 主题概念关系表(RTConceptRela))!值:$(pobjRTConceptRelaEN.memo)(clsRTConceptRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjRTConceptRelaEN.updUser) == false && (0, clsString_js_2.GetStrLen)(pobjRTConceptRelaEN.updUser) > 20) {
            throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 主题概念关系表(RTConceptRela))!值:$(pobjRTConceptRelaEN.updUser)(clsRTConceptRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjRTConceptRelaEN.classificationId) == false && (0, clsString_js_2.GetStrLen)(pobjRTConceptRelaEN.classificationId) > 10) {
            throw new Error("(errid:Watl000062)字段[分类Id(classificationId)]的长度不能超过10(In 主题概念关系表(RTConceptRela))!值:$(pobjRTConceptRelaEN.classificationId)(clsRTConceptRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjRTConceptRelaEN.id_CurrEduCls) == false && (0, clsString_js_2.GetStrLen)(pobjRTConceptRelaEN.id_CurrEduCls) > 8) {
            throw new Error("(errid:Watl000062)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 主题概念关系表(RTConceptRela))!值:$(pobjRTConceptRelaEN.id_CurrEduCls)(clsRTConceptRelaBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if (null != pobjRTConceptRelaEN.mId && undefined !== pobjRTConceptRelaEN.mId && clsString_js_1.tzDataType.isNumber(pobjRTConceptRelaEN.mId) === false) {
            throw new Error("(errid:Watl000063)字段[mId(mId)]的值:[$(pobjRTConceptRelaEN.mId)], 非法，应该为数值型(In 主题概念关系表(RTConceptRela))!(clsRTConceptRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjRTConceptRelaEN.topicId) == false && undefined !== pobjRTConceptRelaEN.topicId && clsString_js_1.tzDataType.isString(pobjRTConceptRelaEN.topicId) === false) {
            throw new Error("(errid:Watl000063)字段[主题Id(topicId)]的值:[$(pobjRTConceptRelaEN.topicId)], 非法，应该为字符型(In 主题概念关系表(RTConceptRela))!(clsRTConceptRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjRTConceptRelaEN.conceptId) == false && undefined !== pobjRTConceptRelaEN.conceptId && clsString_js_1.tzDataType.isString(pobjRTConceptRelaEN.conceptId) === false) {
            throw new Error("(errid:Watl000063)字段[概念Id(conceptId)]的值:[$(pobjRTConceptRelaEN.conceptId)], 非法，应该为字符型(In 主题概念关系表(RTConceptRela))!(clsRTConceptRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjRTConceptRelaEN.updDate) == false && undefined !== pobjRTConceptRelaEN.updDate && clsString_js_1.tzDataType.isString(pobjRTConceptRelaEN.updDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjRTConceptRelaEN.updDate)], 非法，应该为字符型(In 主题概念关系表(RTConceptRela))!(clsRTConceptRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjRTConceptRelaEN.memo) == false && undefined !== pobjRTConceptRelaEN.memo && clsString_js_1.tzDataType.isString(pobjRTConceptRelaEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjRTConceptRelaEN.memo)], 非法，应该为字符型(In 主题概念关系表(RTConceptRela))!(clsRTConceptRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjRTConceptRelaEN.updUser) == false && undefined !== pobjRTConceptRelaEN.updUser && clsString_js_1.tzDataType.isString(pobjRTConceptRelaEN.updUser) === false) {
            throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjRTConceptRelaEN.updUser)], 非法，应该为字符型(In 主题概念关系表(RTConceptRela))!(clsRTConceptRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjRTConceptRelaEN.classificationId) == false && undefined !== pobjRTConceptRelaEN.classificationId && clsString_js_1.tzDataType.isString(pobjRTConceptRelaEN.classificationId) === false) {
            throw new Error("(errid:Watl000063)字段[分类Id(classificationId)]的值:[$(pobjRTConceptRelaEN.classificationId)], 非法，应该为字符型(In 主题概念关系表(RTConceptRela))!(clsRTConceptRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjRTConceptRelaEN.id_CurrEduCls) == false && undefined !== pobjRTConceptRelaEN.id_CurrEduCls && clsString_js_1.tzDataType.isString(pobjRTConceptRelaEN.id_CurrEduCls) === false) {
            throw new Error("(errid:Watl000063)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjRTConceptRelaEN.id_CurrEduCls)], 非法，应该为字符型(In 主题概念关系表(RTConceptRela))!(clsRTConceptRelaBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if (null === pobjRTConceptRelaEN.mId
            || pobjRTConceptRelaEN.mId != null && pobjRTConceptRelaEN.mId.toString() === "") {
            throw new Error("(errid:Watl000064)字段[mId]不能为空(In 主题概念关系表)!(clsRTConceptRelaBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjRTConceptRelaEN.topicId) == false && (0, clsString_js_2.GetStrLen)(pobjRTConceptRelaEN.topicId) != 8) {
            throw ("(errid:Watl000065)字段[主题Id]作为外键字段,长度应该为8(In 主题概念关系表)!(clsRTConceptRelaBL:CheckPropertyNew)");
        }
        pobjRTConceptRelaEN.SetIsCheckProperty(true);
    }
    exports.RTConceptRela_CheckProperty4Update = RTConceptRela_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function RTConceptRela_GetJSONStrByObj(pobjRTConceptRelaEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjRTConceptRelaEN.sf_UpdFldSetStr = pobjRTConceptRelaEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjRTConceptRelaEN);
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
    exports.RTConceptRela_GetJSONStrByObj = RTConceptRela_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function RTConceptRela_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrRTConceptRelaObjLst = new Array();
        if (strJSON === "") {
            return arrRTConceptRelaObjLst;
        }
        try {
            arrRTConceptRelaObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrRTConceptRelaObjLst;
        }
        return arrRTConceptRelaObjLst;
    }
    exports.RTConceptRela_GetObjLstByJSONStr = RTConceptRela_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrRTConceptRelaObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function RTConceptRela_GetObjLstByJSONObjLst(arrRTConceptRelaObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrRTConceptRelaObjLst = new Array();
        for (const objInFor of arrRTConceptRelaObjLstS) {
            const obj1 = RTConceptRela_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrRTConceptRelaObjLst.push(obj1);
        }
        return arrRTConceptRelaObjLst;
    }
    exports.RTConceptRela_GetObjLstByJSONObjLst = RTConceptRela_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function RTConceptRela_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjRTConceptRelaEN = new clsRTConceptRelaEN_js_1.clsRTConceptRelaEN();
        if (strJSON === "") {
            return pobjRTConceptRelaEN;
        }
        try {
            pobjRTConceptRelaEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjRTConceptRelaEN;
        }
        return pobjRTConceptRelaEN;
    }
    exports.RTConceptRela_GetObjByJSONStr = RTConceptRela_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function RTConceptRela_GetCombineCondition(objRTConceptRela_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objRTConceptRela_Cond.dicFldComparisonOp, clsRTConceptRelaEN_js_1.clsRTConceptRelaEN.con_mId) == true) {
            const strComparisonOp_mId = objRTConceptRela_Cond.dicFldComparisonOp[clsRTConceptRelaEN_js_1.clsRTConceptRelaEN.con_mId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsRTConceptRelaEN_js_1.clsRTConceptRelaEN.con_mId, objRTConceptRela_Cond.mId, strComparisonOp_mId);
        }
        if (Object.prototype.hasOwnProperty.call(objRTConceptRela_Cond.dicFldComparisonOp, clsRTConceptRelaEN_js_1.clsRTConceptRelaEN.con_TopicId) == true) {
            const strComparisonOp_TopicId = objRTConceptRela_Cond.dicFldComparisonOp[clsRTConceptRelaEN_js_1.clsRTConceptRelaEN.con_TopicId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsRTConceptRelaEN_js_1.clsRTConceptRelaEN.con_TopicId, objRTConceptRela_Cond.topicId, strComparisonOp_TopicId);
        }
        if (Object.prototype.hasOwnProperty.call(objRTConceptRela_Cond.dicFldComparisonOp, clsRTConceptRelaEN_js_1.clsRTConceptRelaEN.con_ConceptId) == true) {
            const strComparisonOp_ConceptId = objRTConceptRela_Cond.dicFldComparisonOp[clsRTConceptRelaEN_js_1.clsRTConceptRelaEN.con_ConceptId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsRTConceptRelaEN_js_1.clsRTConceptRelaEN.con_ConceptId, objRTConceptRela_Cond.conceptId, strComparisonOp_ConceptId);
        }
        if (Object.prototype.hasOwnProperty.call(objRTConceptRela_Cond.dicFldComparisonOp, clsRTConceptRelaEN_js_1.clsRTConceptRelaEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objRTConceptRela_Cond.dicFldComparisonOp[clsRTConceptRelaEN_js_1.clsRTConceptRelaEN.con_UpdDate];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsRTConceptRelaEN_js_1.clsRTConceptRelaEN.con_UpdDate, objRTConceptRela_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objRTConceptRela_Cond.dicFldComparisonOp, clsRTConceptRelaEN_js_1.clsRTConceptRelaEN.con_Memo) == true) {
            const strComparisonOp_Memo = objRTConceptRela_Cond.dicFldComparisonOp[clsRTConceptRelaEN_js_1.clsRTConceptRelaEN.con_Memo];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsRTConceptRelaEN_js_1.clsRTConceptRelaEN.con_Memo, objRTConceptRela_Cond.memo, strComparisonOp_Memo);
        }
        if (Object.prototype.hasOwnProperty.call(objRTConceptRela_Cond.dicFldComparisonOp, clsRTConceptRelaEN_js_1.clsRTConceptRelaEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objRTConceptRela_Cond.dicFldComparisonOp[clsRTConceptRelaEN_js_1.clsRTConceptRelaEN.con_UpdUser];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsRTConceptRelaEN_js_1.clsRTConceptRelaEN.con_UpdUser, objRTConceptRela_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objRTConceptRela_Cond.dicFldComparisonOp, clsRTConceptRelaEN_js_1.clsRTConceptRelaEN.con_ClassificationId) == true) {
            const strComparisonOp_ClassificationId = objRTConceptRela_Cond.dicFldComparisonOp[clsRTConceptRelaEN_js_1.clsRTConceptRelaEN.con_ClassificationId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsRTConceptRelaEN_js_1.clsRTConceptRelaEN.con_ClassificationId, objRTConceptRela_Cond.classificationId, strComparisonOp_ClassificationId);
        }
        if (Object.prototype.hasOwnProperty.call(objRTConceptRela_Cond.dicFldComparisonOp, clsRTConceptRelaEN_js_1.clsRTConceptRelaEN.con_id_CurrEduCls) == true) {
            const strComparisonOp_id_CurrEduCls = objRTConceptRela_Cond.dicFldComparisonOp[clsRTConceptRelaEN_js_1.clsRTConceptRelaEN.con_id_CurrEduCls];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsRTConceptRelaEN_js_1.clsRTConceptRelaEN.con_id_CurrEduCls, objRTConceptRela_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
        }
        return strWhereCond;
    }
    exports.RTConceptRela_GetCombineCondition = RTConceptRela_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--RTConceptRela(主题概念关系表),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param lngmId: mId(要求唯一的字段)
    * @param strTopicId: 主题Id(要求唯一的字段)
    * @param strConceptId: 概念Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function RTConceptRela_GetUniCondStr_mId_TopicId_ConceptId(objRTConceptRelaEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and mId = '{0}'", objRTConceptRelaEN.mId);
        strWhereCond += (0, clsString_js_2.Format)(" and TopicId = '{0}'", objRTConceptRelaEN.topicId);
        strWhereCond += (0, clsString_js_2.Format)(" and ConceptId = '{0}'", objRTConceptRelaEN.conceptId);
        return strWhereCond;
    }
    exports.RTConceptRela_GetUniCondStr_mId_TopicId_ConceptId = RTConceptRela_GetUniCondStr_mId_TopicId_ConceptId;
    /**
    *获取唯一性条件串(Uniqueness)--RTConceptRela(主题概念关系表),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param lngmId: mId(要求唯一的字段)
    * @param strTopicId: 主题Id(要求唯一的字段)
    * @param strConceptId: 概念Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function RTConceptRela_GetUniCondStr4Update_mId_TopicId_ConceptId(objRTConceptRelaEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and mId <> '{0}'", objRTConceptRelaEN.mId);
        strWhereCond += (0, clsString_js_2.Format)(" and mId = '{0}'", objRTConceptRelaEN.mId);
        strWhereCond += (0, clsString_js_2.Format)(" and TopicId = '{0}'", objRTConceptRelaEN.topicId);
        strWhereCond += (0, clsString_js_2.Format)(" and ConceptId = '{0}'", objRTConceptRelaEN.conceptId);
        return strWhereCond;
    }
    exports.RTConceptRela_GetUniCondStr4Update_mId_TopicId_ConceptId = RTConceptRela_GetUniCondStr4Update_mId_TopicId_ConceptId;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objRTConceptRelaENS:源对象
     * @param objRTConceptRelaENT:目标对象
    */
    function RTConceptRela_CopyObjTo(objRTConceptRelaENS, objRTConceptRelaENT) {
        objRTConceptRelaENT.mId = objRTConceptRelaENS.mId; //mId
        objRTConceptRelaENT.topicId = objRTConceptRelaENS.topicId; //主题Id
        objRTConceptRelaENT.conceptId = objRTConceptRelaENS.conceptId; //概念Id
        objRTConceptRelaENT.updDate = objRTConceptRelaENS.updDate; //修改日期
        objRTConceptRelaENT.memo = objRTConceptRelaENS.memo; //备注
        objRTConceptRelaENT.updUser = objRTConceptRelaENS.updUser; //修改人
        objRTConceptRelaENT.classificationId = objRTConceptRelaENS.classificationId; //分类Id
        objRTConceptRelaENT.id_CurrEduCls = objRTConceptRelaENS.id_CurrEduCls; //教学班流水号
        objRTConceptRelaENT.sf_UpdFldSetStr = objRTConceptRelaENS.updFldString; //sf_UpdFldSetStr
    }
    exports.RTConceptRela_CopyObjTo = RTConceptRela_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objRTConceptRelaENS:源对象
     * @param objRTConceptRelaENT:目标对象
    */
    function RTConceptRela_GetObjFromJsonObj(objRTConceptRelaENS) {
        const objRTConceptRelaENT = new clsRTConceptRelaEN_js_1.clsRTConceptRelaEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objRTConceptRelaENT, objRTConceptRelaENS);
        return objRTConceptRelaENT;
    }
    exports.RTConceptRela_GetObjFromJsonObj = RTConceptRela_GetObjFromJsonObj;
});
