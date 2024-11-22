/**
* 类名:clsRTViewpointRelaWApi
* 表名:RTViewpointRela(01120545)
* 生成代码版本:2022.11.02.1
* 生成日期:2022/11/02 11:47:00
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
        define(["require", "exports", "axios", "../../L0_Entity/GraduateEduTopic/clsRTViewpointRelaEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsSysPara4WebApi.js", "../../PubFun/jsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.RTViewpointRela_GetObjFromJsonObj = exports.RTViewpointRela_CopyObjTo = exports.RTViewpointRela_GetUniCondStr4Update_TopicId_ViewpointId = exports.RTViewpointRela_GetUniCondStr_TopicId_ViewpointId = exports.RTViewpointRela_GetCombineCondition = exports.RTViewpointRela_GetObjByJSONStr = exports.RTViewpointRela_GetObjLstByJSONObjLst = exports.RTViewpointRela_GetObjLstByJSONStr = exports.RTViewpointRela_GetJSONStrByObj = exports.RTViewpointRela_CheckProperty4Update = exports.RTViewpointRela_CheckPropertyNew = exports.RTViewpointRela_GetWebApiUrl = exports.RTViewpointRela_GetMaxStrIdByPrefix = exports.RTViewpointRela_GetRecCountByCondAsync = exports.RTViewpointRela_IsExistAsync = exports.RTViewpointRela_IsExist = exports.RTViewpointRela_IsExistRecordAsync = exports.RTViewpointRela_UpdateWithConditionAsync = exports.RTViewpointRela_UpdateRecordAsync = exports.RTViewpointRela_AddNewRecordWithReturnKey = exports.RTViewpointRela_AddNewRecordWithReturnKeyAsync = exports.RTViewpointRela_AddNewRecordAsync = exports.RTViewpointRela_DelRTViewpointRelasByCondAsync = exports.RTViewpointRela_DelRTViewpointRelasAsync = exports.RTViewpointRela_DelRecordAsync = exports.RTViewpointRela_GetObjLstByPagerAsync = exports.RTViewpointRela_GetObjLstByRange = exports.RTViewpointRela_GetObjLstByRangeAsync = exports.RTViewpointRela_GetTopObjLstAsync = exports.RTViewpointRela_GetObjLstBymIdLstAsync = exports.RTViewpointRela_GetObjLstAsync = exports.RTViewpointRela_GetFirstObjAsync = exports.RTViewpointRela_GetFirstID = exports.RTViewpointRela_GetFirstIDAsync = exports.RTViewpointRela_FilterFunByKey = exports.RTViewpointRela_SortFunByKey = exports.RTViewpointRela_SortFun_Defa_2Fld = exports.RTViewpointRela_SortFun_Defa = exports.RTViewpointRela_GetObjBymIdAsync = exports.rTViewpointRela_ConstructorName = exports.rTViewpointRela_Controller = void 0;
    /**
     * 主题观点关系表(RTViewpointRela)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2022年11月02日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const clsRTViewpointRelaEN_js_1 = require("../../L0_Entity/GraduateEduTopic/clsRTViewpointRelaEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    const jsString_js_1 = require("../../PubFun/jsString.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.rTViewpointRela_Controller = "RTViewpointRelaApi";
    exports.rTViewpointRela_ConstructorName = "rTViewpointRela";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param lngmId:关键字
    * @returns 对象
    **/
    async function RTViewpointRela_GetObjBymIdAsync(lngmId) {
        const strThisFuncName = "GetObjBymIdAsync";
        if (lngmId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngmId]不能为空！(In GetObjBymIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjBymId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTViewpointRela_Controller, strAction);
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
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.rTViewpointRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objRTViewpointRela = RTViewpointRela_GetObjFromJsonObj(returnObj);
                return objRTViewpointRela;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTViewpointRela_GetObjBymIdAsync = RTViewpointRela_GetObjBymIdAsync;
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
    function RTViewpointRela_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.mId - b.mId;
    }
    exports.RTViewpointRela_SortFun_Defa = RTViewpointRela_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function RTViewpointRela_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.topicId == b.topicId)
            return a.viewpointId.localeCompare(b.viewpointId);
        else
            return a.topicId.localeCompare(b.topicId);
    }
    exports.RTViewpointRela_SortFun_Defa_2Fld = RTViewpointRela_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function RTViewpointRela_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsRTViewpointRelaEN_js_1.clsRTViewpointRelaEN.con_mId:
                    return (a, b) => {
                        return a.mId - b.mId;
                    };
                case clsRTViewpointRelaEN_js_1.clsRTViewpointRelaEN.con_TopicId:
                    return (a, b) => {
                        return a.topicId.localeCompare(b.topicId);
                    };
                case clsRTViewpointRelaEN_js_1.clsRTViewpointRelaEN.con_ViewpointId:
                    return (a, b) => {
                        return a.viewpointId.localeCompare(b.viewpointId);
                    };
                case clsRTViewpointRelaEN_js_1.clsRTViewpointRelaEN.con_ProposePeople:
                    return (a, b) => {
                        return a.proposePeople.localeCompare(b.proposePeople);
                    };
                case clsRTViewpointRelaEN_js_1.clsRTViewpointRelaEN.con_UpdDate:
                    return (a, b) => {
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsRTViewpointRelaEN_js_1.clsRTViewpointRelaEN.con_UpdUser:
                    return (a, b) => {
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsRTViewpointRelaEN_js_1.clsRTViewpointRelaEN.con_Memo:
                    return (a, b) => {
                        return a.memo.localeCompare(b.memo);
                    };
                case clsRTViewpointRelaEN_js_1.clsRTViewpointRelaEN.con_ClassificationId:
                    return (a, b) => {
                        return a.classificationId.localeCompare(b.classificationId);
                    };
                case clsRTViewpointRelaEN_js_1.clsRTViewpointRelaEN.con_id_CurrEduCls:
                    return (a, b) => {
                        return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[RTViewpointRela]中不存在！(in ${exports.rTViewpointRela_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsRTViewpointRelaEN_js_1.clsRTViewpointRelaEN.con_mId:
                    return (a, b) => {
                        return b.mId - a.mId;
                    };
                case clsRTViewpointRelaEN_js_1.clsRTViewpointRelaEN.con_TopicId:
                    return (a, b) => {
                        return b.topicId.localeCompare(a.topicId);
                    };
                case clsRTViewpointRelaEN_js_1.clsRTViewpointRelaEN.con_ViewpointId:
                    return (a, b) => {
                        return b.viewpointId.localeCompare(a.viewpointId);
                    };
                case clsRTViewpointRelaEN_js_1.clsRTViewpointRelaEN.con_ProposePeople:
                    return (a, b) => {
                        return b.proposePeople.localeCompare(a.proposePeople);
                    };
                case clsRTViewpointRelaEN_js_1.clsRTViewpointRelaEN.con_UpdDate:
                    return (a, b) => {
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsRTViewpointRelaEN_js_1.clsRTViewpointRelaEN.con_UpdUser:
                    return (a, b) => {
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsRTViewpointRelaEN_js_1.clsRTViewpointRelaEN.con_Memo:
                    return (a, b) => {
                        return b.memo.localeCompare(a.memo);
                    };
                case clsRTViewpointRelaEN_js_1.clsRTViewpointRelaEN.con_ClassificationId:
                    return (a, b) => {
                        return b.classificationId.localeCompare(a.classificationId);
                    };
                case clsRTViewpointRelaEN_js_1.clsRTViewpointRelaEN.con_id_CurrEduCls:
                    return (a, b) => {
                        return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[RTViewpointRela]中不存在！(in ${exports.rTViewpointRela_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.RTViewpointRela_SortFunByKey = RTViewpointRela_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function RTViewpointRela_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsRTViewpointRelaEN_js_1.clsRTViewpointRelaEN.con_mId:
                return (obj) => {
                    return obj.mId === value;
                };
            case clsRTViewpointRelaEN_js_1.clsRTViewpointRelaEN.con_TopicId:
                return (obj) => {
                    return obj.topicId === value;
                };
            case clsRTViewpointRelaEN_js_1.clsRTViewpointRelaEN.con_ViewpointId:
                return (obj) => {
                    return obj.viewpointId === value;
                };
            case clsRTViewpointRelaEN_js_1.clsRTViewpointRelaEN.con_ProposePeople:
                return (obj) => {
                    return obj.proposePeople === value;
                };
            case clsRTViewpointRelaEN_js_1.clsRTViewpointRelaEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsRTViewpointRelaEN_js_1.clsRTViewpointRelaEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsRTViewpointRelaEN_js_1.clsRTViewpointRelaEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            case clsRTViewpointRelaEN_js_1.clsRTViewpointRelaEN.con_ClassificationId:
                return (obj) => {
                    return obj.classificationId === value;
                };
            case clsRTViewpointRelaEN_js_1.clsRTViewpointRelaEN.con_id_CurrEduCls:
                return (obj) => {
                    return obj.id_CurrEduCls === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[RTViewpointRela]中不存在！(in ${exports.rTViewpointRela_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.RTViewpointRela_FilterFunByKey = RTViewpointRela_FilterFunByKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function RTViewpointRela_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTViewpointRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTViewpointRela_GetFirstIDAsync = RTViewpointRela_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function RTViewpointRela_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTViewpointRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTViewpointRela_GetFirstID = RTViewpointRela_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function RTViewpointRela_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTViewpointRela_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.rTViewpointRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objRTViewpointRela = RTViewpointRela_GetObjFromJsonObj(returnObj);
                return objRTViewpointRela;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTViewpointRela_GetFirstObjAsync = RTViewpointRela_GetFirstObjAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function RTViewpointRela_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTViewpointRela_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.rTViewpointRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = RTViewpointRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTViewpointRela_GetObjLstAsync = RTViewpointRela_GetObjLstAsync;
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
    async function RTViewpointRela_GetObjLstBymIdLstAsync(arrmId) {
        const strThisFuncName = "GetObjLstBymIdLstAsync";
        const strAction = "GetObjLstBymIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTViewpointRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrmId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.rTViewpointRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = RTViewpointRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTViewpointRela_GetObjLstBymIdLstAsync = RTViewpointRela_GetObjLstBymIdLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function RTViewpointRela_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTViewpointRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.rTViewpointRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = RTViewpointRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTViewpointRela_GetTopObjLstAsync = RTViewpointRela_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function RTViewpointRela_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTViewpointRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.rTViewpointRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = RTViewpointRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTViewpointRela_GetObjLstByRangeAsync = RTViewpointRela_GetObjLstByRangeAsync;
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
    async function RTViewpointRela_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTViewpointRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTViewpointRela_GetObjLstByRange = RTViewpointRela_GetObjLstByRange;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function RTViewpointRela_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTViewpointRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.rTViewpointRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = RTViewpointRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTViewpointRela_GetObjLstByPagerAsync = RTViewpointRela_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param lngmId:关键字
    * @returns 获取删除的结果
    **/
    async function RTViewpointRela_DelRecordAsync(lngmId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTViewpointRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTViewpointRela_DelRecordAsync = RTViewpointRela_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrmId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function RTViewpointRela_DelRTViewpointRelasAsync(arrmId) {
        const strThisFuncName = "DelRTViewpointRelasAsync";
        const strAction = "DelRTViewpointRelas";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTViewpointRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTViewpointRela_DelRTViewpointRelasAsync = RTViewpointRela_DelRTViewpointRelasAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function RTViewpointRela_DelRTViewpointRelasByCondAsync(strWhereCond) {
        const strThisFuncName = "DelRTViewpointRelasByCondAsync";
        const strAction = "DelRTViewpointRelasByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTViewpointRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTViewpointRela_DelRTViewpointRelasByCondAsync = RTViewpointRela_DelRTViewpointRelasByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objRTViewpointRelaEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function RTViewpointRela_AddNewRecordAsync(objRTViewpointRelaEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objRTViewpointRelaEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTViewpointRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRTViewpointRelaEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTViewpointRela_AddNewRecordAsync = RTViewpointRela_AddNewRecordAsync;
    /* 数据类型不是字符型，不可以最大关键字的方式添加记录。*/
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objRTViewpointRelaEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function RTViewpointRela_AddNewRecordWithReturnKeyAsync(objRTViewpointRelaEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTViewpointRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRTViewpointRelaEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTViewpointRela_AddNewRecordWithReturnKeyAsync = RTViewpointRela_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objRTViewpointRelaEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function RTViewpointRela_AddNewRecordWithReturnKey(objRTViewpointRelaEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objRTViewpointRelaEN.mId === null || objRTViewpointRelaEN.mId === 0) {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTViewpointRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRTViewpointRelaEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTViewpointRela_AddNewRecordWithReturnKey = RTViewpointRela_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objRTViewpointRelaEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function RTViewpointRela_UpdateRecordAsync(objRTViewpointRelaEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objRTViewpointRelaEN.sf_UpdFldSetStr === undefined || objRTViewpointRelaEN.sf_UpdFldSetStr === null || objRTViewpointRelaEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objRTViewpointRelaEN.mId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTViewpointRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRTViewpointRelaEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTViewpointRela_UpdateRecordAsync = RTViewpointRela_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objRTViewpointRelaEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function RTViewpointRela_UpdateWithConditionAsync(objRTViewpointRelaEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objRTViewpointRelaEN.sf_UpdFldSetStr === undefined || objRTViewpointRelaEN.sf_UpdFldSetStr === null || objRTViewpointRelaEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objRTViewpointRelaEN.mId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTViewpointRela_Controller, strAction);
        objRTViewpointRelaEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objRTViewpointRelaEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTViewpointRela_UpdateWithConditionAsync = RTViewpointRela_UpdateWithConditionAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function RTViewpointRela_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTViewpointRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTViewpointRela_IsExistRecordAsync = RTViewpointRela_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param lngmId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function RTViewpointRela_IsExist(lngmId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTViewpointRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTViewpointRela_IsExist = RTViewpointRela_IsExist;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param lngmId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function RTViewpointRela_IsExistAsync(lngmId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTViewpointRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTViewpointRela_IsExistAsync = RTViewpointRela_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function RTViewpointRela_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTViewpointRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTViewpointRela_GetRecCountByCondAsync = RTViewpointRela_GetRecCountByCondAsync;
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
    async function RTViewpointRela_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rTViewpointRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTViewpointRela_GetMaxStrIdByPrefix = RTViewpointRela_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function RTViewpointRela_GetWebApiUrl(strController, strAction) {
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
    exports.RTViewpointRela_GetWebApiUrl = RTViewpointRela_GetWebApiUrl;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function RTViewpointRela_CheckPropertyNew(pobjRTViewpointRelaEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTViewpointRelaEN.topicId) == false && (0, clsString_js_1.GetStrLen)(pobjRTViewpointRelaEN.topicId) > 8) {
            throw new Error("(errid:Watl000059)字段[主题Id(topicId)]的长度不能超过8(In 主题观点关系表(RTViewpointRela))!值:$(pobjRTViewpointRelaEN.topicId)(clsRTViewpointRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTViewpointRelaEN.viewpointId) == false && (0, clsString_js_1.GetStrLen)(pobjRTViewpointRelaEN.viewpointId) > 8) {
            throw new Error("(errid:Watl000059)字段[观点Id(viewpointId)]的长度不能超过8(In 主题观点关系表(RTViewpointRela))!值:$(pobjRTViewpointRelaEN.viewpointId)(clsRTViewpointRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTViewpointRelaEN.proposePeople) == false && (0, clsString_js_1.GetStrLen)(pobjRTViewpointRelaEN.proposePeople) > 50) {
            throw new Error("(errid:Watl000059)字段[提出人(proposePeople)]的长度不能超过50(In 主题观点关系表(RTViewpointRela))!值:$(pobjRTViewpointRelaEN.proposePeople)(clsRTViewpointRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTViewpointRelaEN.updDate) == false && (0, clsString_js_1.GetStrLen)(pobjRTViewpointRelaEN.updDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 主题观点关系表(RTViewpointRela))!值:$(pobjRTViewpointRelaEN.updDate)(clsRTViewpointRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTViewpointRelaEN.updUser) == false && (0, clsString_js_1.GetStrLen)(pobjRTViewpointRelaEN.updUser) > 20) {
            throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 主题观点关系表(RTViewpointRela))!值:$(pobjRTViewpointRelaEN.updUser)(clsRTViewpointRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTViewpointRelaEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjRTViewpointRelaEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 主题观点关系表(RTViewpointRela))!值:$(pobjRTViewpointRelaEN.memo)(clsRTViewpointRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTViewpointRelaEN.classificationId) == false && (0, clsString_js_1.GetStrLen)(pobjRTViewpointRelaEN.classificationId) > 10) {
            throw new Error("(errid:Watl000059)字段[分类Id(classificationId)]的长度不能超过10(In 主题观点关系表(RTViewpointRela))!值:$(pobjRTViewpointRelaEN.classificationId)(clsRTViewpointRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTViewpointRelaEN.id_CurrEduCls) == false && (0, clsString_js_1.GetStrLen)(pobjRTViewpointRelaEN.id_CurrEduCls) > 8) {
            throw new Error("(errid:Watl000059)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 主题观点关系表(RTViewpointRela))!值:$(pobjRTViewpointRelaEN.id_CurrEduCls)(clsRTViewpointRelaBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if (null != pobjRTViewpointRelaEN.mId && undefined !== pobjRTViewpointRelaEN.mId && jsString_js_1.tzDataType.isNumber(pobjRTViewpointRelaEN.mId) === false) {
            throw new Error("(errid:Watl000060)字段[mId(mId)]的值:[$(pobjRTViewpointRelaEN.mId)], 非法，应该为数值型(In 主题观点关系表(RTViewpointRela))!(clsRTViewpointRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTViewpointRelaEN.topicId) == false && undefined !== pobjRTViewpointRelaEN.topicId && jsString_js_1.tzDataType.isString(pobjRTViewpointRelaEN.topicId) === false) {
            throw new Error("(errid:Watl000060)字段[主题Id(topicId)]的值:[$(pobjRTViewpointRelaEN.topicId)], 非法，应该为字符型(In 主题观点关系表(RTViewpointRela))!(clsRTViewpointRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTViewpointRelaEN.viewpointId) == false && undefined !== pobjRTViewpointRelaEN.viewpointId && jsString_js_1.tzDataType.isString(pobjRTViewpointRelaEN.viewpointId) === false) {
            throw new Error("(errid:Watl000060)字段[观点Id(viewpointId)]的值:[$(pobjRTViewpointRelaEN.viewpointId)], 非法，应该为字符型(In 主题观点关系表(RTViewpointRela))!(clsRTViewpointRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTViewpointRelaEN.proposePeople) == false && undefined !== pobjRTViewpointRelaEN.proposePeople && jsString_js_1.tzDataType.isString(pobjRTViewpointRelaEN.proposePeople) === false) {
            throw new Error("(errid:Watl000060)字段[提出人(proposePeople)]的值:[$(pobjRTViewpointRelaEN.proposePeople)], 非法，应该为字符型(In 主题观点关系表(RTViewpointRela))!(clsRTViewpointRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTViewpointRelaEN.updDate) == false && undefined !== pobjRTViewpointRelaEN.updDate && jsString_js_1.tzDataType.isString(pobjRTViewpointRelaEN.updDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjRTViewpointRelaEN.updDate)], 非法，应该为字符型(In 主题观点关系表(RTViewpointRela))!(clsRTViewpointRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTViewpointRelaEN.updUser) == false && undefined !== pobjRTViewpointRelaEN.updUser && jsString_js_1.tzDataType.isString(pobjRTViewpointRelaEN.updUser) === false) {
            throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjRTViewpointRelaEN.updUser)], 非法，应该为字符型(In 主题观点关系表(RTViewpointRela))!(clsRTViewpointRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTViewpointRelaEN.memo) == false && undefined !== pobjRTViewpointRelaEN.memo && jsString_js_1.tzDataType.isString(pobjRTViewpointRelaEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjRTViewpointRelaEN.memo)], 非法，应该为字符型(In 主题观点关系表(RTViewpointRela))!(clsRTViewpointRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTViewpointRelaEN.classificationId) == false && undefined !== pobjRTViewpointRelaEN.classificationId && jsString_js_1.tzDataType.isString(pobjRTViewpointRelaEN.classificationId) === false) {
            throw new Error("(errid:Watl000060)字段[分类Id(classificationId)]的值:[$(pobjRTViewpointRelaEN.classificationId)], 非法，应该为字符型(In 主题观点关系表(RTViewpointRela))!(clsRTViewpointRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTViewpointRelaEN.id_CurrEduCls) == false && undefined !== pobjRTViewpointRelaEN.id_CurrEduCls && jsString_js_1.tzDataType.isString(pobjRTViewpointRelaEN.id_CurrEduCls) === false) {
            throw new Error("(errid:Watl000060)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjRTViewpointRelaEN.id_CurrEduCls)], 非法，应该为字符型(In 主题观点关系表(RTViewpointRela))!(clsRTViewpointRelaBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjRTViewpointRelaEN.SetIsCheckProperty(true);
    }
    exports.RTViewpointRela_CheckPropertyNew = RTViewpointRela_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function RTViewpointRela_CheckProperty4Update(pobjRTViewpointRelaEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTViewpointRelaEN.topicId) == false && (0, clsString_js_1.GetStrLen)(pobjRTViewpointRelaEN.topicId) > 8) {
            throw new Error("(errid:Watl000062)字段[主题Id(topicId)]的长度不能超过8(In 主题观点关系表(RTViewpointRela))!值:$(pobjRTViewpointRelaEN.topicId)(clsRTViewpointRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTViewpointRelaEN.viewpointId) == false && (0, clsString_js_1.GetStrLen)(pobjRTViewpointRelaEN.viewpointId) > 8) {
            throw new Error("(errid:Watl000062)字段[观点Id(viewpointId)]的长度不能超过8(In 主题观点关系表(RTViewpointRela))!值:$(pobjRTViewpointRelaEN.viewpointId)(clsRTViewpointRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTViewpointRelaEN.proposePeople) == false && (0, clsString_js_1.GetStrLen)(pobjRTViewpointRelaEN.proposePeople) > 50) {
            throw new Error("(errid:Watl000062)字段[提出人(proposePeople)]的长度不能超过50(In 主题观点关系表(RTViewpointRela))!值:$(pobjRTViewpointRelaEN.proposePeople)(clsRTViewpointRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTViewpointRelaEN.updDate) == false && (0, clsString_js_1.GetStrLen)(pobjRTViewpointRelaEN.updDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 主题观点关系表(RTViewpointRela))!值:$(pobjRTViewpointRelaEN.updDate)(clsRTViewpointRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTViewpointRelaEN.updUser) == false && (0, clsString_js_1.GetStrLen)(pobjRTViewpointRelaEN.updUser) > 20) {
            throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 主题观点关系表(RTViewpointRela))!值:$(pobjRTViewpointRelaEN.updUser)(clsRTViewpointRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTViewpointRelaEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjRTViewpointRelaEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 主题观点关系表(RTViewpointRela))!值:$(pobjRTViewpointRelaEN.memo)(clsRTViewpointRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTViewpointRelaEN.classificationId) == false && (0, clsString_js_1.GetStrLen)(pobjRTViewpointRelaEN.classificationId) > 10) {
            throw new Error("(errid:Watl000062)字段[分类Id(classificationId)]的长度不能超过10(In 主题观点关系表(RTViewpointRela))!值:$(pobjRTViewpointRelaEN.classificationId)(clsRTViewpointRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTViewpointRelaEN.id_CurrEduCls) == false && (0, clsString_js_1.GetStrLen)(pobjRTViewpointRelaEN.id_CurrEduCls) > 8) {
            throw new Error("(errid:Watl000062)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 主题观点关系表(RTViewpointRela))!值:$(pobjRTViewpointRelaEN.id_CurrEduCls)(clsRTViewpointRelaBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if (null != pobjRTViewpointRelaEN.mId && undefined !== pobjRTViewpointRelaEN.mId && jsString_js_1.tzDataType.isNumber(pobjRTViewpointRelaEN.mId) === false) {
            throw new Error("(errid:Watl000063)字段[mId(mId)]的值:[$(pobjRTViewpointRelaEN.mId)], 非法，应该为数值型(In 主题观点关系表(RTViewpointRela))!(clsRTViewpointRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTViewpointRelaEN.topicId) == false && undefined !== pobjRTViewpointRelaEN.topicId && jsString_js_1.tzDataType.isString(pobjRTViewpointRelaEN.topicId) === false) {
            throw new Error("(errid:Watl000063)字段[主题Id(topicId)]的值:[$(pobjRTViewpointRelaEN.topicId)], 非法，应该为字符型(In 主题观点关系表(RTViewpointRela))!(clsRTViewpointRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTViewpointRelaEN.viewpointId) == false && undefined !== pobjRTViewpointRelaEN.viewpointId && jsString_js_1.tzDataType.isString(pobjRTViewpointRelaEN.viewpointId) === false) {
            throw new Error("(errid:Watl000063)字段[观点Id(viewpointId)]的值:[$(pobjRTViewpointRelaEN.viewpointId)], 非法，应该为字符型(In 主题观点关系表(RTViewpointRela))!(clsRTViewpointRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTViewpointRelaEN.proposePeople) == false && undefined !== pobjRTViewpointRelaEN.proposePeople && jsString_js_1.tzDataType.isString(pobjRTViewpointRelaEN.proposePeople) === false) {
            throw new Error("(errid:Watl000063)字段[提出人(proposePeople)]的值:[$(pobjRTViewpointRelaEN.proposePeople)], 非法，应该为字符型(In 主题观点关系表(RTViewpointRela))!(clsRTViewpointRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTViewpointRelaEN.updDate) == false && undefined !== pobjRTViewpointRelaEN.updDate && jsString_js_1.tzDataType.isString(pobjRTViewpointRelaEN.updDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjRTViewpointRelaEN.updDate)], 非法，应该为字符型(In 主题观点关系表(RTViewpointRela))!(clsRTViewpointRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTViewpointRelaEN.updUser) == false && undefined !== pobjRTViewpointRelaEN.updUser && jsString_js_1.tzDataType.isString(pobjRTViewpointRelaEN.updUser) === false) {
            throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjRTViewpointRelaEN.updUser)], 非法，应该为字符型(In 主题观点关系表(RTViewpointRela))!(clsRTViewpointRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTViewpointRelaEN.memo) == false && undefined !== pobjRTViewpointRelaEN.memo && jsString_js_1.tzDataType.isString(pobjRTViewpointRelaEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjRTViewpointRelaEN.memo)], 非法，应该为字符型(In 主题观点关系表(RTViewpointRela))!(clsRTViewpointRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTViewpointRelaEN.classificationId) == false && undefined !== pobjRTViewpointRelaEN.classificationId && jsString_js_1.tzDataType.isString(pobjRTViewpointRelaEN.classificationId) === false) {
            throw new Error("(errid:Watl000063)字段[分类Id(classificationId)]的值:[$(pobjRTViewpointRelaEN.classificationId)], 非法，应该为字符型(In 主题观点关系表(RTViewpointRela))!(clsRTViewpointRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjRTViewpointRelaEN.id_CurrEduCls) == false && undefined !== pobjRTViewpointRelaEN.id_CurrEduCls && jsString_js_1.tzDataType.isString(pobjRTViewpointRelaEN.id_CurrEduCls) === false) {
            throw new Error("(errid:Watl000063)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjRTViewpointRelaEN.id_CurrEduCls)], 非法，应该为字符型(In 主题观点关系表(RTViewpointRela))!(clsRTViewpointRelaBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if (null === pobjRTViewpointRelaEN.mId
            || pobjRTViewpointRelaEN.mId != null && pobjRTViewpointRelaEN.mId.toString() === "") {
            throw new Error("(errid:Watl000064)字段[mId]不能为空(In 主题观点关系表)!(clsRTViewpointRelaBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjRTViewpointRelaEN.SetIsCheckProperty(true);
    }
    exports.RTViewpointRela_CheckProperty4Update = RTViewpointRela_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function RTViewpointRela_GetJSONStrByObj(pobjRTViewpointRelaEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjRTViewpointRelaEN.sf_UpdFldSetStr = pobjRTViewpointRelaEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjRTViewpointRelaEN);
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
    exports.RTViewpointRela_GetJSONStrByObj = RTViewpointRela_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function RTViewpointRela_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrRTViewpointRelaObjLst = new Array();
        if (strJSON === "") {
            return arrRTViewpointRelaObjLst;
        }
        try {
            arrRTViewpointRelaObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrRTViewpointRelaObjLst;
        }
        return arrRTViewpointRelaObjLst;
    }
    exports.RTViewpointRela_GetObjLstByJSONStr = RTViewpointRela_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrRTViewpointRelaObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function RTViewpointRela_GetObjLstByJSONObjLst(arrRTViewpointRelaObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrRTViewpointRelaObjLst = new Array();
        for (const objInFor of arrRTViewpointRelaObjLstS) {
            const obj1 = RTViewpointRela_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrRTViewpointRelaObjLst.push(obj1);
        }
        return arrRTViewpointRelaObjLst;
    }
    exports.RTViewpointRela_GetObjLstByJSONObjLst = RTViewpointRela_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function RTViewpointRela_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjRTViewpointRelaEN = new clsRTViewpointRelaEN_js_1.clsRTViewpointRelaEN();
        if (strJSON === "") {
            return pobjRTViewpointRelaEN;
        }
        try {
            pobjRTViewpointRelaEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjRTViewpointRelaEN;
        }
        return pobjRTViewpointRelaEN;
    }
    exports.RTViewpointRela_GetObjByJSONStr = RTViewpointRela_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function RTViewpointRela_GetCombineCondition(objRTViewpointRela_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objRTViewpointRela_Cond.dicFldComparisonOp, clsRTViewpointRelaEN_js_1.clsRTViewpointRelaEN.con_mId) == true) {
            const strComparisonOp_mId = objRTViewpointRela_Cond.dicFldComparisonOp[clsRTViewpointRelaEN_js_1.clsRTViewpointRelaEN.con_mId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsRTViewpointRelaEN_js_1.clsRTViewpointRelaEN.con_mId, objRTViewpointRela_Cond.mId, strComparisonOp_mId);
        }
        if (Object.prototype.hasOwnProperty.call(objRTViewpointRela_Cond.dicFldComparisonOp, clsRTViewpointRelaEN_js_1.clsRTViewpointRelaEN.con_TopicId) == true) {
            const strComparisonOp_TopicId = objRTViewpointRela_Cond.dicFldComparisonOp[clsRTViewpointRelaEN_js_1.clsRTViewpointRelaEN.con_TopicId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsRTViewpointRelaEN_js_1.clsRTViewpointRelaEN.con_TopicId, objRTViewpointRela_Cond.topicId, strComparisonOp_TopicId);
        }
        if (Object.prototype.hasOwnProperty.call(objRTViewpointRela_Cond.dicFldComparisonOp, clsRTViewpointRelaEN_js_1.clsRTViewpointRelaEN.con_ViewpointId) == true) {
            const strComparisonOp_ViewpointId = objRTViewpointRela_Cond.dicFldComparisonOp[clsRTViewpointRelaEN_js_1.clsRTViewpointRelaEN.con_ViewpointId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsRTViewpointRelaEN_js_1.clsRTViewpointRelaEN.con_ViewpointId, objRTViewpointRela_Cond.viewpointId, strComparisonOp_ViewpointId);
        }
        if (Object.prototype.hasOwnProperty.call(objRTViewpointRela_Cond.dicFldComparisonOp, clsRTViewpointRelaEN_js_1.clsRTViewpointRelaEN.con_ProposePeople) == true) {
            const strComparisonOp_ProposePeople = objRTViewpointRela_Cond.dicFldComparisonOp[clsRTViewpointRelaEN_js_1.clsRTViewpointRelaEN.con_ProposePeople];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsRTViewpointRelaEN_js_1.clsRTViewpointRelaEN.con_ProposePeople, objRTViewpointRela_Cond.proposePeople, strComparisonOp_ProposePeople);
        }
        if (Object.prototype.hasOwnProperty.call(objRTViewpointRela_Cond.dicFldComparisonOp, clsRTViewpointRelaEN_js_1.clsRTViewpointRelaEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objRTViewpointRela_Cond.dicFldComparisonOp[clsRTViewpointRelaEN_js_1.clsRTViewpointRelaEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsRTViewpointRelaEN_js_1.clsRTViewpointRelaEN.con_UpdDate, objRTViewpointRela_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objRTViewpointRela_Cond.dicFldComparisonOp, clsRTViewpointRelaEN_js_1.clsRTViewpointRelaEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objRTViewpointRela_Cond.dicFldComparisonOp[clsRTViewpointRelaEN_js_1.clsRTViewpointRelaEN.con_UpdUser];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsRTViewpointRelaEN_js_1.clsRTViewpointRelaEN.con_UpdUser, objRTViewpointRela_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objRTViewpointRela_Cond.dicFldComparisonOp, clsRTViewpointRelaEN_js_1.clsRTViewpointRelaEN.con_Memo) == true) {
            const strComparisonOp_Memo = objRTViewpointRela_Cond.dicFldComparisonOp[clsRTViewpointRelaEN_js_1.clsRTViewpointRelaEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsRTViewpointRelaEN_js_1.clsRTViewpointRelaEN.con_Memo, objRTViewpointRela_Cond.memo, strComparisonOp_Memo);
        }
        if (Object.prototype.hasOwnProperty.call(objRTViewpointRela_Cond.dicFldComparisonOp, clsRTViewpointRelaEN_js_1.clsRTViewpointRelaEN.con_ClassificationId) == true) {
            const strComparisonOp_ClassificationId = objRTViewpointRela_Cond.dicFldComparisonOp[clsRTViewpointRelaEN_js_1.clsRTViewpointRelaEN.con_ClassificationId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsRTViewpointRelaEN_js_1.clsRTViewpointRelaEN.con_ClassificationId, objRTViewpointRela_Cond.classificationId, strComparisonOp_ClassificationId);
        }
        if (Object.prototype.hasOwnProperty.call(objRTViewpointRela_Cond.dicFldComparisonOp, clsRTViewpointRelaEN_js_1.clsRTViewpointRelaEN.con_id_CurrEduCls) == true) {
            const strComparisonOp_id_CurrEduCls = objRTViewpointRela_Cond.dicFldComparisonOp[clsRTViewpointRelaEN_js_1.clsRTViewpointRelaEN.con_id_CurrEduCls];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsRTViewpointRelaEN_js_1.clsRTViewpointRelaEN.con_id_CurrEduCls, objRTViewpointRela_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
        }
        return strWhereCond;
    }
    exports.RTViewpointRela_GetCombineCondition = RTViewpointRela_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--RTViewpointRela(主题观点关系表),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param strTopicId: 主题Id(要求唯一的字段)
    * @param strViewpointId: 观点Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function RTViewpointRela_GetUniCondStr_TopicId_ViewpointId(objRTViewpointRelaEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and TopicId = '{0}'", objRTViewpointRelaEN.topicId);
        strWhereCond += (0, clsString_js_1.Format)(" and ViewpointId = '{0}'", objRTViewpointRelaEN.viewpointId);
        return strWhereCond;
    }
    exports.RTViewpointRela_GetUniCondStr_TopicId_ViewpointId = RTViewpointRela_GetUniCondStr_TopicId_ViewpointId;
    /**
    *获取唯一性条件串(Uniqueness)--RTViewpointRela(主题观点关系表),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param strTopicId: 主题Id(要求唯一的字段)
    * @param strViewpointId: 观点Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function RTViewpointRela_GetUniCondStr4Update_TopicId_ViewpointId(objRTViewpointRelaEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and mId <> '{0}'", objRTViewpointRelaEN.mId);
        strWhereCond += (0, clsString_js_1.Format)(" and TopicId = '{0}'", objRTViewpointRelaEN.topicId);
        strWhereCond += (0, clsString_js_1.Format)(" and ViewpointId = '{0}'", objRTViewpointRelaEN.viewpointId);
        return strWhereCond;
    }
    exports.RTViewpointRela_GetUniCondStr4Update_TopicId_ViewpointId = RTViewpointRela_GetUniCondStr4Update_TopicId_ViewpointId;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objRTViewpointRelaENS:源对象
     * @param objRTViewpointRelaENT:目标对象
    */
    function RTViewpointRela_CopyObjTo(objRTViewpointRelaENS, objRTViewpointRelaENT) {
        objRTViewpointRelaENT.mId = objRTViewpointRelaENS.mId; //mId
        objRTViewpointRelaENT.topicId = objRTViewpointRelaENS.topicId; //主题Id
        objRTViewpointRelaENT.viewpointId = objRTViewpointRelaENS.viewpointId; //观点Id
        objRTViewpointRelaENT.proposePeople = objRTViewpointRelaENS.proposePeople; //提出人
        objRTViewpointRelaENT.updDate = objRTViewpointRelaENS.updDate; //修改日期
        objRTViewpointRelaENT.updUser = objRTViewpointRelaENS.updUser; //修改人
        objRTViewpointRelaENT.memo = objRTViewpointRelaENS.memo; //备注
        objRTViewpointRelaENT.classificationId = objRTViewpointRelaENS.classificationId; //分类Id
        objRTViewpointRelaENT.id_CurrEduCls = objRTViewpointRelaENS.id_CurrEduCls; //教学班流水号
        objRTViewpointRelaENT.sf_UpdFldSetStr = objRTViewpointRelaENS.updFldString; //sf_UpdFldSetStr
    }
    exports.RTViewpointRela_CopyObjTo = RTViewpointRela_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objRTViewpointRelaENS:源对象
     * @param objRTViewpointRelaENT:目标对象
    */
    function RTViewpointRela_GetObjFromJsonObj(objRTViewpointRelaENS) {
        const objRTViewpointRelaENT = new clsRTViewpointRelaEN_js_1.clsRTViewpointRelaEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objRTViewpointRelaENT, objRTViewpointRelaENS);
        return objRTViewpointRelaENT;
    }
    exports.RTViewpointRela_GetObjFromJsonObj = RTViewpointRela_GetObjFromJsonObj;
});
