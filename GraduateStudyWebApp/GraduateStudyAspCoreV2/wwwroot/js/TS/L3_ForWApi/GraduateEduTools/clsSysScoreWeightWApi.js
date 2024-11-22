/**
* 类名:clsSysScoreWeightWApi
* 表名:SysScoreWeight(01120629)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/13 00:47:44
* 生成者:pyf
* 生成服务器IP:
工程名称:问卷调查(0112)
CM工程:研究生论文学习(变量首字母小写)-全部函数集
* 相关数据库:103.116.76.183,9433EduHigh_Jsie
* PrjDataBaseId:0170
模块中文名:研培设置(GraduateEduTools)
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
        define(["require", "exports", "axios", "../../L0_Entity/GraduateEduTools/clsSysScoreWeightEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.SysScoreWeight_GetObjFromJsonObj = exports.SysScoreWeight_CopyObjTo = exports.SysScoreWeight_GetCombineCondition = exports.SysScoreWeight_GetObjByJSONStr = exports.SysScoreWeight_GetObjLstByJSONObjLst = exports.SysScoreWeight_GetObjLstByJSONStr = exports.SysScoreWeight_GetJSONStrByObj = exports.SysScoreWeight_CheckProperty4Update = exports.SysScoreWeight_CheckPropertyNew = exports.SysScoreWeight_GetWebApiUrl = exports.SysScoreWeight_GetMaxStrIdByPrefix = exports.SysScoreWeight_GetRecCountByCondAsync = exports.SysScoreWeight_IsExistAsync = exports.SysScoreWeight_IsExist = exports.SysScoreWeight_IsExistRecordAsync = exports.SysScoreWeight_UpdateWithConditionAsync = exports.SysScoreWeight_UpdateRecordAsync = exports.SysScoreWeight_AddNewRecordWithReturnKey = exports.SysScoreWeight_AddNewRecordWithReturnKeyAsync = exports.SysScoreWeight_AddNewRecordWithMaxIdAsync = exports.SysScoreWeight_AddNewRecordAsync = exports.SysScoreWeight_DelSysScoreWeightsByCondAsync = exports.SysScoreWeight_DelSysScoreWeightsAsync = exports.SysScoreWeight_DelRecordAsync = exports.SysScoreWeight_GetObjLstByPagerAsync = exports.SysScoreWeight_GetObjLstByRange = exports.SysScoreWeight_GetObjLstByRangeAsync = exports.SysScoreWeight_GetTopObjLstAsync = exports.SysScoreWeight_GetObjLstByScoreWeightIdLstAsync = exports.SysScoreWeight_GetObjLstAsync = exports.SysScoreWeight_GetFirstObjAsync = exports.SysScoreWeight_GetFirstID = exports.SysScoreWeight_GetFirstIDAsync = exports.SysScoreWeight_FilterFunByKey = exports.SysScoreWeight_SortFunByKey = exports.SysScoreWeight_SortFun_Defa_2Fld = exports.SysScoreWeight_SortFun_Defa = exports.SysScoreWeight_GetObjByScoreWeightIdAsync = exports.sysScoreWeight_ConstructorName = exports.sysScoreWeight_Controller = void 0;
    /**
     * 系统分数权重表(SysScoreWeight)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月13日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const clsSysScoreWeightEN_js_1 = require("../../L0_Entity/GraduateEduTools/clsSysScoreWeightEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsString_js_2 = require("../../PubFun/clsString.js");
    exports.sysScoreWeight_Controller = "SysScoreWeightApi";
    exports.sysScoreWeight_ConstructorName = "sysScoreWeight";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strScoreWeightId:关键字
    * @returns 对象
    **/
    async function SysScoreWeight_GetObjByScoreWeightIdAsync(strScoreWeightId) {
        const strThisFuncName = "GetObjByScoreWeightIdAsync";
        if ((0, clsString_js_2.IsNullOrEmpty)(strScoreWeightId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strScoreWeightId]不能为空！(In clsSysScoreWeightWApi.GetObjByScoreWeightIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strScoreWeightId.length != 1) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strScoreWeightId]的长度:[{0}]不正确！(clsSysScoreWeightWApi.GetObjByScoreWeightIdAsync)", strScoreWeightId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByScoreWeightId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysScoreWeight_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "strScoreWeightId": strScoreWeightId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    return null;
                }
                //console.log(returnObj);
                const objSysScoreWeight = SysScoreWeight_GetObjFromJsonObj(returnObj);
                return objSysScoreWeight;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysScoreWeight_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysScoreWeight_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysScoreWeight_GetObjByScoreWeightIdAsync = SysScoreWeight_GetObjByScoreWeightIdAsync;
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
    function SysScoreWeight_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.scoreWeightId.localeCompare(b.scoreWeightId);
    }
    exports.SysScoreWeight_SortFun_Defa = SysScoreWeight_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function SysScoreWeight_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.memo == b.memo)
            return a.scoreTypeId.localeCompare(b.scoreTypeId);
        else
            return a.memo.localeCompare(b.memo);
    }
    exports.SysScoreWeight_SortFun_Defa_2Fld = SysScoreWeight_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function SysScoreWeight_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsSysScoreWeightEN_js_1.clsSysScoreWeightEN.con_ScoreWeightId:
                    return (a, b) => {
                        return a.scoreWeightId.localeCompare(b.scoreWeightId);
                    };
                case clsSysScoreWeightEN_js_1.clsSysScoreWeightEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                case clsSysScoreWeightEN_js_1.clsSysScoreWeightEN.con_IsPublic:
                    return (a, b) => {
                        if (a.isPublic == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsSysScoreWeightEN_js_1.clsSysScoreWeightEN.con_ScoreTypeId:
                    return (a, b) => {
                        if (a.scoreTypeId == null)
                            return -1;
                        if (b.scoreTypeId == null)
                            return 1;
                        return a.scoreTypeId.localeCompare(b.scoreTypeId);
                    };
                case clsSysScoreWeightEN_js_1.clsSysScoreWeightEN.con_ScoreWeightValue:
                    return (a, b) => {
                        return a.scoreWeightValue.localeCompare(b.scoreWeightValue);
                    };
                case clsSysScoreWeightEN_js_1.clsSysScoreWeightEN.con_UpdDate:
                    return (a, b) => {
                        if (a.updDate == null)
                            return -1;
                        if (b.updDate == null)
                            return 1;
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsSysScoreWeightEN_js_1.clsSysScoreWeightEN.con_UpdUser:
                    return (a, b) => {
                        if (a.updUser == null)
                            return -1;
                        if (b.updUser == null)
                            return 1;
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsSysScoreWeightEN_js_1.clsSysScoreWeightEN.con_id_CurrEduCls:
                    return (a, b) => {
                        if (a.id_CurrEduCls == null)
                            return -1;
                        if (b.id_CurrEduCls == null)
                            return 1;
                        return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[SysScoreWeight]中不存在！(in ${exports.sysScoreWeight_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsSysScoreWeightEN_js_1.clsSysScoreWeightEN.con_ScoreWeightId:
                    return (a, b) => {
                        return b.scoreWeightId.localeCompare(a.scoreWeightId);
                    };
                case clsSysScoreWeightEN_js_1.clsSysScoreWeightEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                case clsSysScoreWeightEN_js_1.clsSysScoreWeightEN.con_IsPublic:
                    return (a, b) => {
                        if (b.isPublic == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsSysScoreWeightEN_js_1.clsSysScoreWeightEN.con_ScoreTypeId:
                    return (a, b) => {
                        if (b.scoreTypeId == null)
                            return -1;
                        if (a.scoreTypeId == null)
                            return 1;
                        return b.scoreTypeId.localeCompare(a.scoreTypeId);
                    };
                case clsSysScoreWeightEN_js_1.clsSysScoreWeightEN.con_ScoreWeightValue:
                    return (a, b) => {
                        return b.scoreWeightValue.localeCompare(a.scoreWeightValue);
                    };
                case clsSysScoreWeightEN_js_1.clsSysScoreWeightEN.con_UpdDate:
                    return (a, b) => {
                        if (b.updDate == null)
                            return -1;
                        if (a.updDate == null)
                            return 1;
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsSysScoreWeightEN_js_1.clsSysScoreWeightEN.con_UpdUser:
                    return (a, b) => {
                        if (b.updUser == null)
                            return -1;
                        if (a.updUser == null)
                            return 1;
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsSysScoreWeightEN_js_1.clsSysScoreWeightEN.con_id_CurrEduCls:
                    return (a, b) => {
                        if (b.id_CurrEduCls == null)
                            return -1;
                        if (a.id_CurrEduCls == null)
                            return 1;
                        return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[SysScoreWeight]中不存在！(in ${exports.sysScoreWeight_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.SysScoreWeight_SortFunByKey = SysScoreWeight_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function SysScoreWeight_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsSysScoreWeightEN_js_1.clsSysScoreWeightEN.con_ScoreWeightId:
                return (obj) => {
                    return obj.scoreWeightId === value;
                };
            case clsSysScoreWeightEN_js_1.clsSysScoreWeightEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            case clsSysScoreWeightEN_js_1.clsSysScoreWeightEN.con_IsPublic:
                return (obj) => {
                    return obj.isPublic === value;
                };
            case clsSysScoreWeightEN_js_1.clsSysScoreWeightEN.con_ScoreTypeId:
                return (obj) => {
                    return obj.scoreTypeId === value;
                };
            case clsSysScoreWeightEN_js_1.clsSysScoreWeightEN.con_ScoreWeightValue:
                return (obj) => {
                    return obj.scoreWeightValue === value;
                };
            case clsSysScoreWeightEN_js_1.clsSysScoreWeightEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsSysScoreWeightEN_js_1.clsSysScoreWeightEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsSysScoreWeightEN_js_1.clsSysScoreWeightEN.con_id_CurrEduCls:
                return (obj) => {
                    return obj.id_CurrEduCls === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[SysScoreWeight]中不存在！(in ${exports.sysScoreWeight_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.SysScoreWeight_FilterFunByKey = SysScoreWeight_FilterFunByKey;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function SysScoreWeight_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysScoreWeight_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysScoreWeight_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysScoreWeight_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysScoreWeight_GetFirstIDAsync = SysScoreWeight_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function SysScoreWeight_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysScoreWeight_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysScoreWeight_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysScoreWeight_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysScoreWeight_GetFirstID = SysScoreWeight_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function SysScoreWeight_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysScoreWeight_Controller, strAction);
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
                const objSysScoreWeight = SysScoreWeight_GetObjFromJsonObj(returnObj);
                return objSysScoreWeight;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysScoreWeight_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysScoreWeight_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysScoreWeight_GetFirstObjAsync = SysScoreWeight_GetFirstObjAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function SysScoreWeight_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysScoreWeight_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.sysScoreWeight_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = SysScoreWeight_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysScoreWeight_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysScoreWeight_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysScoreWeight_GetObjLstAsync = SysScoreWeight_GetObjLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrScoreWeightId:关键字列表
    * @returns 对象列表
    **/
    async function SysScoreWeight_GetObjLstByScoreWeightIdLstAsync(arrScoreWeightId) {
        const strThisFuncName = "GetObjLstByScoreWeightIdLstAsync";
        const strAction = "GetObjLstByScoreWeightIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysScoreWeight_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrScoreWeightId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.sysScoreWeight_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = SysScoreWeight_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysScoreWeight_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysScoreWeight_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysScoreWeight_GetObjLstByScoreWeightIdLstAsync = SysScoreWeight_GetObjLstByScoreWeightIdLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function SysScoreWeight_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysScoreWeight_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.sysScoreWeight_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = SysScoreWeight_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysScoreWeight_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysScoreWeight_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysScoreWeight_GetTopObjLstAsync = SysScoreWeight_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function SysScoreWeight_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysScoreWeight_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.sysScoreWeight_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = SysScoreWeight_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysScoreWeight_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysScoreWeight_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysScoreWeight_GetObjLstByRangeAsync = SysScoreWeight_GetObjLstByRangeAsync;
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
    async function SysScoreWeight_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysScoreWeight_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysScoreWeight_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysScoreWeight_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysScoreWeight_GetObjLstByRange = SysScoreWeight_GetObjLstByRange;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function SysScoreWeight_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysScoreWeight_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.sysScoreWeight_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = SysScoreWeight_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysScoreWeight_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysScoreWeight_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysScoreWeight_GetObjLstByPagerAsync = SysScoreWeight_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param strScoreWeightId:关键字
    * @returns 获取删除的结果
    **/
    async function SysScoreWeight_DelRecordAsync(strScoreWeightId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysScoreWeight_Controller, strAction);
        strUrl = (0, clsString_js_2.Format)("{0}/?Id={1}", strUrl, strScoreWeightId);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysScoreWeight_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysScoreWeight_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysScoreWeight_DelRecordAsync = SysScoreWeight_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrScoreWeightId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function SysScoreWeight_DelSysScoreWeightsAsync(arrScoreWeightId) {
        const strThisFuncName = "DelSysScoreWeightsAsync";
        const strAction = "DelSysScoreWeights";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysScoreWeight_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrScoreWeightId);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysScoreWeight_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysScoreWeight_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysScoreWeight_DelSysScoreWeightsAsync = SysScoreWeight_DelSysScoreWeightsAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function SysScoreWeight_DelSysScoreWeightsByCondAsync(strWhereCond) {
        const strThisFuncName = "DelSysScoreWeightsByCondAsync";
        const strAction = "DelSysScoreWeightsByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysScoreWeight_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysScoreWeight_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysScoreWeight_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysScoreWeight_DelSysScoreWeightsByCondAsync = SysScoreWeight_DelSysScoreWeightsByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objSysScoreWeightEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function SysScoreWeight_AddNewRecordAsync(objSysScoreWeightEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        if (objSysScoreWeightEN.scoreWeightId === null || objSysScoreWeightEN.scoreWeightId === "") {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            throw strMsg;
        }
        //var strJSON = JSON.stringify(objSysScoreWeightEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysScoreWeight_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objSysScoreWeightEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysScoreWeight_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysScoreWeight_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysScoreWeight_AddNewRecordAsync = SysScoreWeight_AddNewRecordAsync;
    /**
    * 调用WebApi来添加记录，关键字用最大关键字，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithMaxIdAsync)
    * @param objSysScoreWeightEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function SysScoreWeight_AddNewRecordWithMaxIdAsync(objSysScoreWeightEN) {
        const strThisFuncName = "AddNewRecordWithMaxIdAsync";
        const strAction = "AddNewRecordWithMaxId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysScoreWeight_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objSysScoreWeightEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysScoreWeight_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysScoreWeight_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysScoreWeight_AddNewRecordWithMaxIdAsync = SysScoreWeight_AddNewRecordWithMaxIdAsync;
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objSysScoreWeightEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function SysScoreWeight_AddNewRecordWithReturnKeyAsync(objSysScoreWeightEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysScoreWeight_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objSysScoreWeightEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysScoreWeight_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysScoreWeight_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysScoreWeight_AddNewRecordWithReturnKeyAsync = SysScoreWeight_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objSysScoreWeightEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function SysScoreWeight_AddNewRecordWithReturnKey(objSysScoreWeightEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objSysScoreWeightEN.scoreWeightId === null || objSysScoreWeightEN.scoreWeightId === "") {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysScoreWeight_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objSysScoreWeightEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysScoreWeight_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysScoreWeight_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysScoreWeight_AddNewRecordWithReturnKey = SysScoreWeight_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objSysScoreWeightEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function SysScoreWeight_UpdateRecordAsync(objSysScoreWeightEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objSysScoreWeightEN.sf_UpdFldSetStr === undefined || objSysScoreWeightEN.sf_UpdFldSetStr === null || objSysScoreWeightEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objSysScoreWeightEN.scoreWeightId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysScoreWeight_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objSysScoreWeightEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysScoreWeight_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysScoreWeight_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysScoreWeight_UpdateRecordAsync = SysScoreWeight_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objSysScoreWeightEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function SysScoreWeight_UpdateWithConditionAsync(objSysScoreWeightEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objSysScoreWeightEN.sf_UpdFldSetStr === undefined || objSysScoreWeightEN.sf_UpdFldSetStr === null || objSysScoreWeightEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objSysScoreWeightEN.scoreWeightId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysScoreWeight_Controller, strAction);
        objSysScoreWeightEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objSysScoreWeightEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysScoreWeight_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysScoreWeight_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysScoreWeight_UpdateWithConditionAsync = SysScoreWeight_UpdateWithConditionAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function SysScoreWeight_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysScoreWeight_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysScoreWeight_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysScoreWeight_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysScoreWeight_IsExistRecordAsync = SysScoreWeight_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strScoreWeightId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function SysScoreWeight_IsExist(strScoreWeightId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysScoreWeight_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "ScoreWeightId": strScoreWeightId,
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysScoreWeight_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysScoreWeight_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysScoreWeight_IsExist = SysScoreWeight_IsExist;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strScoreWeightId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function SysScoreWeight_IsExistAsync(strScoreWeightId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysScoreWeight_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strScoreWeightId": strScoreWeightId }
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysScoreWeight_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysScoreWeight_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysScoreWeight_IsExistAsync = SysScoreWeight_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function SysScoreWeight_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysScoreWeight_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysScoreWeight_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysScoreWeight_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysScoreWeight_GetRecCountByCondAsync = SysScoreWeight_GetRecCountByCondAsync;
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
    async function SysScoreWeight_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysScoreWeight_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysScoreWeight_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysScoreWeight_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysScoreWeight_GetMaxStrIdByPrefix = SysScoreWeight_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function SysScoreWeight_GetWebApiUrl(strController, strAction) {
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
    exports.SysScoreWeight_GetWebApiUrl = SysScoreWeight_GetWebApiUrl;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function SysScoreWeight_CheckPropertyNew(pobjSysScoreWeightEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysScoreWeightEN.scoreWeightValue) === true) {
            throw new Error("(errid:Watl000058)字段[分数权重值]不能为空(In 系统分数权重表)!(clsSysScoreWeightBL:CheckPropertyNew)");
        }
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysScoreWeightEN.scoreWeightId) == false && (0, clsString_js_2.GetStrLen)(pobjSysScoreWeightEN.scoreWeightId) > 1) {
            throw new Error("(errid:Watl000059)字段[分数权重Id(scoreWeightId)]的长度不能超过1(In 系统分数权重表(SysScoreWeight))!值:$(pobjSysScoreWeightEN.scoreWeightId)(clsSysScoreWeightBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysScoreWeightEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjSysScoreWeightEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 系统分数权重表(SysScoreWeight))!值:$(pobjSysScoreWeightEN.memo)(clsSysScoreWeightBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysScoreWeightEN.scoreTypeId) == false && (0, clsString_js_2.GetStrLen)(pobjSysScoreWeightEN.scoreTypeId) > 4) {
            throw new Error("(errid:Watl000059)字段[分数类型Id(scoreTypeId)]的长度不能超过4(In 系统分数权重表(SysScoreWeight))!值:$(pobjSysScoreWeightEN.scoreTypeId)(clsSysScoreWeightBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysScoreWeightEN.scoreWeightValue) == false && (0, clsString_js_2.GetStrLen)(pobjSysScoreWeightEN.scoreWeightValue) > 20) {
            throw new Error("(errid:Watl000059)字段[分数权重值(scoreWeightValue)]的长度不能超过20(In 系统分数权重表(SysScoreWeight))!值:$(pobjSysScoreWeightEN.scoreWeightValue)(clsSysScoreWeightBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysScoreWeightEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjSysScoreWeightEN.updDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 系统分数权重表(SysScoreWeight))!值:$(pobjSysScoreWeightEN.updDate)(clsSysScoreWeightBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysScoreWeightEN.updUser) == false && (0, clsString_js_2.GetStrLen)(pobjSysScoreWeightEN.updUser) > 20) {
            throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 系统分数权重表(SysScoreWeight))!值:$(pobjSysScoreWeightEN.updUser)(clsSysScoreWeightBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysScoreWeightEN.id_CurrEduCls) == false && (0, clsString_js_2.GetStrLen)(pobjSysScoreWeightEN.id_CurrEduCls) > 8) {
            throw new Error("(errid:Watl000059)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 系统分数权重表(SysScoreWeight))!值:$(pobjSysScoreWeightEN.id_CurrEduCls)(clsSysScoreWeightBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysScoreWeightEN.scoreWeightId) == false && undefined !== pobjSysScoreWeightEN.scoreWeightId && clsString_js_1.tzDataType.isString(pobjSysScoreWeightEN.scoreWeightId) === false) {
            throw new Error("(errid:Watl000060)字段[分数权重Id(scoreWeightId)]的值:[$(pobjSysScoreWeightEN.scoreWeightId)], 非法，应该为字符型(In 系统分数权重表(SysScoreWeight))!(clsSysScoreWeightBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysScoreWeightEN.memo) == false && undefined !== pobjSysScoreWeightEN.memo && clsString_js_1.tzDataType.isString(pobjSysScoreWeightEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjSysScoreWeightEN.memo)], 非法，应该为字符型(In 系统分数权重表(SysScoreWeight))!(clsSysScoreWeightBL:CheckPropertyNew)");
        }
        if (null != pobjSysScoreWeightEN.isPublic && undefined !== pobjSysScoreWeightEN.isPublic && clsString_js_1.tzDataType.isBoolean(pobjSysScoreWeightEN.isPublic) === false) {
            throw new Error("(errid:Watl000060)字段[是否公开(isPublic)]的值:[$(pobjSysScoreWeightEN.isPublic)], 非法，应该为布尔型(In 系统分数权重表(SysScoreWeight))!(clsSysScoreWeightBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysScoreWeightEN.scoreTypeId) == false && undefined !== pobjSysScoreWeightEN.scoreTypeId && clsString_js_1.tzDataType.isString(pobjSysScoreWeightEN.scoreTypeId) === false) {
            throw new Error("(errid:Watl000060)字段[分数类型Id(scoreTypeId)]的值:[$(pobjSysScoreWeightEN.scoreTypeId)], 非法，应该为字符型(In 系统分数权重表(SysScoreWeight))!(clsSysScoreWeightBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysScoreWeightEN.scoreWeightValue) == false && undefined !== pobjSysScoreWeightEN.scoreWeightValue && clsString_js_1.tzDataType.isString(pobjSysScoreWeightEN.scoreWeightValue) === false) {
            throw new Error("(errid:Watl000060)字段[分数权重值(scoreWeightValue)]的值:[$(pobjSysScoreWeightEN.scoreWeightValue)], 非法，应该为字符型(In 系统分数权重表(SysScoreWeight))!(clsSysScoreWeightBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysScoreWeightEN.updDate) == false && undefined !== pobjSysScoreWeightEN.updDate && clsString_js_1.tzDataType.isString(pobjSysScoreWeightEN.updDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjSysScoreWeightEN.updDate)], 非法，应该为字符型(In 系统分数权重表(SysScoreWeight))!(clsSysScoreWeightBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysScoreWeightEN.updUser) == false && undefined !== pobjSysScoreWeightEN.updUser && clsString_js_1.tzDataType.isString(pobjSysScoreWeightEN.updUser) === false) {
            throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjSysScoreWeightEN.updUser)], 非法，应该为字符型(In 系统分数权重表(SysScoreWeight))!(clsSysScoreWeightBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysScoreWeightEN.id_CurrEduCls) == false && undefined !== pobjSysScoreWeightEN.id_CurrEduCls && clsString_js_1.tzDataType.isString(pobjSysScoreWeightEN.id_CurrEduCls) === false) {
            throw new Error("(errid:Watl000060)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjSysScoreWeightEN.id_CurrEduCls)], 非法，应该为字符型(In 系统分数权重表(SysScoreWeight))!(clsSysScoreWeightBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjSysScoreWeightEN.SetIsCheckProperty(true);
    }
    exports.SysScoreWeight_CheckPropertyNew = SysScoreWeight_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function SysScoreWeight_CheckProperty4Update(pobjSysScoreWeightEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysScoreWeightEN.scoreWeightId) == false && (0, clsString_js_2.GetStrLen)(pobjSysScoreWeightEN.scoreWeightId) > 1) {
            throw new Error("(errid:Watl000062)字段[分数权重Id(scoreWeightId)]的长度不能超过1(In 系统分数权重表(SysScoreWeight))!值:$(pobjSysScoreWeightEN.scoreWeightId)(clsSysScoreWeightBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysScoreWeightEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjSysScoreWeightEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 系统分数权重表(SysScoreWeight))!值:$(pobjSysScoreWeightEN.memo)(clsSysScoreWeightBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysScoreWeightEN.scoreTypeId) == false && (0, clsString_js_2.GetStrLen)(pobjSysScoreWeightEN.scoreTypeId) > 4) {
            throw new Error("(errid:Watl000062)字段[分数类型Id(scoreTypeId)]的长度不能超过4(In 系统分数权重表(SysScoreWeight))!值:$(pobjSysScoreWeightEN.scoreTypeId)(clsSysScoreWeightBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysScoreWeightEN.scoreWeightValue) == false && (0, clsString_js_2.GetStrLen)(pobjSysScoreWeightEN.scoreWeightValue) > 20) {
            throw new Error("(errid:Watl000062)字段[分数权重值(scoreWeightValue)]的长度不能超过20(In 系统分数权重表(SysScoreWeight))!值:$(pobjSysScoreWeightEN.scoreWeightValue)(clsSysScoreWeightBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysScoreWeightEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjSysScoreWeightEN.updDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 系统分数权重表(SysScoreWeight))!值:$(pobjSysScoreWeightEN.updDate)(clsSysScoreWeightBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysScoreWeightEN.updUser) == false && (0, clsString_js_2.GetStrLen)(pobjSysScoreWeightEN.updUser) > 20) {
            throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 系统分数权重表(SysScoreWeight))!值:$(pobjSysScoreWeightEN.updUser)(clsSysScoreWeightBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysScoreWeightEN.id_CurrEduCls) == false && (0, clsString_js_2.GetStrLen)(pobjSysScoreWeightEN.id_CurrEduCls) > 8) {
            throw new Error("(errid:Watl000062)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 系统分数权重表(SysScoreWeight))!值:$(pobjSysScoreWeightEN.id_CurrEduCls)(clsSysScoreWeightBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysScoreWeightEN.scoreWeightId) == false && undefined !== pobjSysScoreWeightEN.scoreWeightId && clsString_js_1.tzDataType.isString(pobjSysScoreWeightEN.scoreWeightId) === false) {
            throw new Error("(errid:Watl000063)字段[分数权重Id(scoreWeightId)]的值:[$(pobjSysScoreWeightEN.scoreWeightId)], 非法，应该为字符型(In 系统分数权重表(SysScoreWeight))!(clsSysScoreWeightBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysScoreWeightEN.memo) == false && undefined !== pobjSysScoreWeightEN.memo && clsString_js_1.tzDataType.isString(pobjSysScoreWeightEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjSysScoreWeightEN.memo)], 非法，应该为字符型(In 系统分数权重表(SysScoreWeight))!(clsSysScoreWeightBL:CheckProperty4Update)");
        }
        if (null != pobjSysScoreWeightEN.isPublic && undefined !== pobjSysScoreWeightEN.isPublic && clsString_js_1.tzDataType.isBoolean(pobjSysScoreWeightEN.isPublic) === false) {
            throw new Error("(errid:Watl000063)字段[是否公开(isPublic)]的值:[$(pobjSysScoreWeightEN.isPublic)], 非法，应该为布尔型(In 系统分数权重表(SysScoreWeight))!(clsSysScoreWeightBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysScoreWeightEN.scoreTypeId) == false && undefined !== pobjSysScoreWeightEN.scoreTypeId && clsString_js_1.tzDataType.isString(pobjSysScoreWeightEN.scoreTypeId) === false) {
            throw new Error("(errid:Watl000063)字段[分数类型Id(scoreTypeId)]的值:[$(pobjSysScoreWeightEN.scoreTypeId)], 非法，应该为字符型(In 系统分数权重表(SysScoreWeight))!(clsSysScoreWeightBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysScoreWeightEN.scoreWeightValue) == false && undefined !== pobjSysScoreWeightEN.scoreWeightValue && clsString_js_1.tzDataType.isString(pobjSysScoreWeightEN.scoreWeightValue) === false) {
            throw new Error("(errid:Watl000063)字段[分数权重值(scoreWeightValue)]的值:[$(pobjSysScoreWeightEN.scoreWeightValue)], 非法，应该为字符型(In 系统分数权重表(SysScoreWeight))!(clsSysScoreWeightBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysScoreWeightEN.updDate) == false && undefined !== pobjSysScoreWeightEN.updDate && clsString_js_1.tzDataType.isString(pobjSysScoreWeightEN.updDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjSysScoreWeightEN.updDate)], 非法，应该为字符型(In 系统分数权重表(SysScoreWeight))!(clsSysScoreWeightBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysScoreWeightEN.updUser) == false && undefined !== pobjSysScoreWeightEN.updUser && clsString_js_1.tzDataType.isString(pobjSysScoreWeightEN.updUser) === false) {
            throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjSysScoreWeightEN.updUser)], 非法，应该为字符型(In 系统分数权重表(SysScoreWeight))!(clsSysScoreWeightBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysScoreWeightEN.id_CurrEduCls) == false && undefined !== pobjSysScoreWeightEN.id_CurrEduCls && clsString_js_1.tzDataType.isString(pobjSysScoreWeightEN.id_CurrEduCls) === false) {
            throw new Error("(errid:Watl000063)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjSysScoreWeightEN.id_CurrEduCls)], 非法，应该为字符型(In 系统分数权重表(SysScoreWeight))!(clsSysScoreWeightBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysScoreWeightEN.scoreWeightId) === true) {
            throw new Error("(errid:Watl000064)字段[分数权重Id]不能为空(In 系统分数权重表)!(clsSysScoreWeightBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjSysScoreWeightEN.SetIsCheckProperty(true);
    }
    exports.SysScoreWeight_CheckProperty4Update = SysScoreWeight_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function SysScoreWeight_GetJSONStrByObj(pobjSysScoreWeightEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjSysScoreWeightEN.sf_UpdFldSetStr = pobjSysScoreWeightEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjSysScoreWeightEN);
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
    exports.SysScoreWeight_GetJSONStrByObj = SysScoreWeight_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function SysScoreWeight_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrSysScoreWeightObjLst = new Array();
        if (strJSON === "") {
            return arrSysScoreWeightObjLst;
        }
        try {
            arrSysScoreWeightObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrSysScoreWeightObjLst;
        }
        return arrSysScoreWeightObjLst;
    }
    exports.SysScoreWeight_GetObjLstByJSONStr = SysScoreWeight_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrSysScoreWeightObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function SysScoreWeight_GetObjLstByJSONObjLst(arrSysScoreWeightObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrSysScoreWeightObjLst = new Array();
        for (const objInFor of arrSysScoreWeightObjLstS) {
            const obj1 = SysScoreWeight_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrSysScoreWeightObjLst.push(obj1);
        }
        return arrSysScoreWeightObjLst;
    }
    exports.SysScoreWeight_GetObjLstByJSONObjLst = SysScoreWeight_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function SysScoreWeight_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjSysScoreWeightEN = new clsSysScoreWeightEN_js_1.clsSysScoreWeightEN();
        if (strJSON === "") {
            return pobjSysScoreWeightEN;
        }
        try {
            pobjSysScoreWeightEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjSysScoreWeightEN;
        }
        return pobjSysScoreWeightEN;
    }
    exports.SysScoreWeight_GetObjByJSONStr = SysScoreWeight_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function SysScoreWeight_GetCombineCondition(objSysScoreWeight_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objSysScoreWeight_Cond.dicFldComparisonOp, clsSysScoreWeightEN_js_1.clsSysScoreWeightEN.con_ScoreWeightId) == true) {
            const strComparisonOp_ScoreWeightId = objSysScoreWeight_Cond.dicFldComparisonOp[clsSysScoreWeightEN_js_1.clsSysScoreWeightEN.con_ScoreWeightId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsSysScoreWeightEN_js_1.clsSysScoreWeightEN.con_ScoreWeightId, objSysScoreWeight_Cond.scoreWeightId, strComparisonOp_ScoreWeightId);
        }
        if (Object.prototype.hasOwnProperty.call(objSysScoreWeight_Cond.dicFldComparisonOp, clsSysScoreWeightEN_js_1.clsSysScoreWeightEN.con_Memo) == true) {
            const strComparisonOp_Memo = objSysScoreWeight_Cond.dicFldComparisonOp[clsSysScoreWeightEN_js_1.clsSysScoreWeightEN.con_Memo];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsSysScoreWeightEN_js_1.clsSysScoreWeightEN.con_Memo, objSysScoreWeight_Cond.memo, strComparisonOp_Memo);
        }
        if (Object.prototype.hasOwnProperty.call(objSysScoreWeight_Cond.dicFldComparisonOp, clsSysScoreWeightEN_js_1.clsSysScoreWeightEN.con_IsPublic) == true) {
            if (objSysScoreWeight_Cond.isPublic == true) {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '1'", clsSysScoreWeightEN_js_1.clsSysScoreWeightEN.con_IsPublic);
            }
            else {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '0'", clsSysScoreWeightEN_js_1.clsSysScoreWeightEN.con_IsPublic);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objSysScoreWeight_Cond.dicFldComparisonOp, clsSysScoreWeightEN_js_1.clsSysScoreWeightEN.con_ScoreTypeId) == true) {
            const strComparisonOp_ScoreTypeId = objSysScoreWeight_Cond.dicFldComparisonOp[clsSysScoreWeightEN_js_1.clsSysScoreWeightEN.con_ScoreTypeId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsSysScoreWeightEN_js_1.clsSysScoreWeightEN.con_ScoreTypeId, objSysScoreWeight_Cond.scoreTypeId, strComparisonOp_ScoreTypeId);
        }
        if (Object.prototype.hasOwnProperty.call(objSysScoreWeight_Cond.dicFldComparisonOp, clsSysScoreWeightEN_js_1.clsSysScoreWeightEN.con_ScoreWeightValue) == true) {
            const strComparisonOp_ScoreWeightValue = objSysScoreWeight_Cond.dicFldComparisonOp[clsSysScoreWeightEN_js_1.clsSysScoreWeightEN.con_ScoreWeightValue];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsSysScoreWeightEN_js_1.clsSysScoreWeightEN.con_ScoreWeightValue, objSysScoreWeight_Cond.scoreWeightValue, strComparisonOp_ScoreWeightValue);
        }
        if (Object.prototype.hasOwnProperty.call(objSysScoreWeight_Cond.dicFldComparisonOp, clsSysScoreWeightEN_js_1.clsSysScoreWeightEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objSysScoreWeight_Cond.dicFldComparisonOp[clsSysScoreWeightEN_js_1.clsSysScoreWeightEN.con_UpdDate];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsSysScoreWeightEN_js_1.clsSysScoreWeightEN.con_UpdDate, objSysScoreWeight_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objSysScoreWeight_Cond.dicFldComparisonOp, clsSysScoreWeightEN_js_1.clsSysScoreWeightEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objSysScoreWeight_Cond.dicFldComparisonOp[clsSysScoreWeightEN_js_1.clsSysScoreWeightEN.con_UpdUser];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsSysScoreWeightEN_js_1.clsSysScoreWeightEN.con_UpdUser, objSysScoreWeight_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objSysScoreWeight_Cond.dicFldComparisonOp, clsSysScoreWeightEN_js_1.clsSysScoreWeightEN.con_id_CurrEduCls) == true) {
            const strComparisonOp_id_CurrEduCls = objSysScoreWeight_Cond.dicFldComparisonOp[clsSysScoreWeightEN_js_1.clsSysScoreWeightEN.con_id_CurrEduCls];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsSysScoreWeightEN_js_1.clsSysScoreWeightEN.con_id_CurrEduCls, objSysScoreWeight_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
        }
        return strWhereCond;
    }
    exports.SysScoreWeight_GetCombineCondition = SysScoreWeight_GetCombineCondition;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objSysScoreWeightENS:源对象
     * @param objSysScoreWeightENT:目标对象
    */
    function SysScoreWeight_CopyObjTo(objSysScoreWeightENS, objSysScoreWeightENT) {
        objSysScoreWeightENT.scoreWeightId = objSysScoreWeightENS.scoreWeightId; //分数权重Id
        objSysScoreWeightENT.memo = objSysScoreWeightENS.memo; //备注
        objSysScoreWeightENT.isPublic = objSysScoreWeightENS.isPublic; //是否公开
        objSysScoreWeightENT.scoreTypeId = objSysScoreWeightENS.scoreTypeId; //分数类型Id
        objSysScoreWeightENT.scoreWeightValue = objSysScoreWeightENS.scoreWeightValue; //分数权重值
        objSysScoreWeightENT.updDate = objSysScoreWeightENS.updDate; //修改日期
        objSysScoreWeightENT.updUser = objSysScoreWeightENS.updUser; //修改人
        objSysScoreWeightENT.id_CurrEduCls = objSysScoreWeightENS.id_CurrEduCls; //教学班流水号
        objSysScoreWeightENT.sf_UpdFldSetStr = objSysScoreWeightENS.updFldString; //sf_UpdFldSetStr
    }
    exports.SysScoreWeight_CopyObjTo = SysScoreWeight_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objSysScoreWeightENS:源对象
     * @param objSysScoreWeightENT:目标对象
    */
    function SysScoreWeight_GetObjFromJsonObj(objSysScoreWeightENS) {
        const objSysScoreWeightENT = new clsSysScoreWeightEN_js_1.clsSysScoreWeightEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objSysScoreWeightENT, objSysScoreWeightENS);
        return objSysScoreWeightENT;
    }
    exports.SysScoreWeight_GetObjFromJsonObj = SysScoreWeight_GetObjFromJsonObj;
});
