/**
* 类名:clsSysSocialRelationsVWApi
* 表名:SysSocialRelationsV(01120645)
* 生成代码版本:2022.11.02.1
* 生成日期:2022/11/02 11:46:58
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
        define(["require", "exports", "axios", "../../L0_Entity/GraduateEduTopic/clsSysSocialRelationsVEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsSysPara4WebApi.js", "../../PubFun/jsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.SysSocialRelationsV_GetObjFromJsonObj = exports.SysSocialRelationsV_CopyObjTo = exports.SysSocialRelationsV_GetUniCondStr4Update_SocialVId = exports.SysSocialRelationsV_GetUniCondStr_SocialVId = exports.SysSocialRelationsV_GetCombineCondition = exports.SysSocialRelationsV_GetObjByJSONStr = exports.SysSocialRelationsV_GetObjLstByJSONObjLst = exports.SysSocialRelationsV_GetObjLstByJSONStr = exports.SysSocialRelationsV_GetJSONStrByObj = exports.SysSocialRelationsV_CheckProperty4Update = exports.SysSocialRelationsV_CheckPropertyNew = exports.SysSocialRelationsV_GetWebApiUrl = exports.SysSocialRelationsV_GetMaxStrIdByPrefix = exports.SysSocialRelationsV_GetRecCountByCondAsync = exports.SysSocialRelationsV_IsExistAsync = exports.SysSocialRelationsV_IsExist = exports.SysSocialRelationsV_IsExistRecordAsync = exports.SysSocialRelationsV_UpdateWithConditionAsync = exports.SysSocialRelationsV_UpdateRecordAsync = exports.SysSocialRelationsV_AddNewRecordWithReturnKey = exports.SysSocialRelationsV_AddNewRecordWithReturnKeyAsync = exports.SysSocialRelationsV_AddNewRecordAsync = exports.SysSocialRelationsV_DelSysSocialRelationsVsByCondAsync = exports.SysSocialRelationsV_DelSysSocialRelationsVsAsync = exports.SysSocialRelationsV_DelRecordAsync = exports.SysSocialRelationsV_GetObjLstByPagerAsync = exports.SysSocialRelationsV_GetObjLstByRange = exports.SysSocialRelationsV_GetObjLstByRangeAsync = exports.SysSocialRelationsV_GetTopObjLstAsync = exports.SysSocialRelationsV_GetObjLstBySocialVIdLstAsync = exports.SysSocialRelationsV_GetObjLstAsync = exports.SysSocialRelationsV_GetFirstObjAsync = exports.SysSocialRelationsV_GetFirstID = exports.SysSocialRelationsV_GetFirstIDAsync = exports.SysSocialRelationsV_FilterFunByKey = exports.SysSocialRelationsV_SortFunByKey = exports.SysSocialRelationsV_SortFun_Defa_2Fld = exports.SysSocialRelationsV_SortFun_Defa = exports.SysSocialRelationsV_GetObjBySocialVIdAsync = exports.sysSocialRelationsV_ConstructorName = exports.sysSocialRelationsV_Controller = void 0;
    /**
     * 社会关系版本表(SysSocialRelationsV)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2022年11月02日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const clsSysSocialRelationsVEN_js_1 = require("../../L0_Entity/GraduateEduTopic/clsSysSocialRelationsVEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    const jsString_js_1 = require("../../PubFun/jsString.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.sysSocialRelationsV_Controller = "SysSocialRelationsVApi";
    exports.sysSocialRelationsV_ConstructorName = "sysSocialRelationsV";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param lngSocialVId:关键字
    * @returns 对象
    **/
    async function SysSocialRelationsV_GetObjBySocialVIdAsync(lngSocialVId) {
        const strThisFuncName = "GetObjBySocialVIdAsync";
        if (lngSocialVId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngSocialVId]不能为空！(In GetObjBySocialVIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjBySocialVId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSocialRelationsV_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "lngSocialVId": lngSocialVId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.sysSocialRelationsV_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objSysSocialRelationsV = SysSocialRelationsV_GetObjFromJsonObj(returnObj);
                return objSysSocialRelationsV;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSocialRelationsV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSocialRelationsV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSocialRelationsV_GetObjBySocialVIdAsync = SysSocialRelationsV_GetObjBySocialVIdAsync;
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
    function SysSocialRelationsV_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.socialVId - b.socialVId;
    }
    exports.SysSocialRelationsV_SortFun_Defa = SysSocialRelationsV_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function SysSocialRelationsV_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.socialId == b.socialId)
            return a.fullName.localeCompare(b.fullName);
        else
            return a.socialId.localeCompare(b.socialId);
    }
    exports.SysSocialRelationsV_SortFun_Defa_2Fld = SysSocialRelationsV_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function SysSocialRelationsV_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsSysSocialRelationsVEN_js_1.clsSysSocialRelationsVEN.con_SocialVId:
                    return (a, b) => {
                        return a.socialVId - b.socialVId;
                    };
                case clsSysSocialRelationsVEN_js_1.clsSysSocialRelationsVEN.con_SocialId:
                    return (a, b) => {
                        return a.socialId.localeCompare(b.socialId);
                    };
                case clsSysSocialRelationsVEN_js_1.clsSysSocialRelationsVEN.con_FullName:
                    return (a, b) => {
                        return a.fullName.localeCompare(b.fullName);
                    };
                case clsSysSocialRelationsVEN_js_1.clsSysSocialRelationsVEN.con_Nationality:
                    return (a, b) => {
                        return a.nationality.localeCompare(b.nationality);
                    };
                case clsSysSocialRelationsVEN_js_1.clsSysSocialRelationsVEN.con_WorkUnit:
                    return (a, b) => {
                        return a.workUnit.localeCompare(b.workUnit);
                    };
                case clsSysSocialRelationsVEN_js_1.clsSysSocialRelationsVEN.con_Major:
                    return (a, b) => {
                        return a.major.localeCompare(b.major);
                    };
                case clsSysSocialRelationsVEN_js_1.clsSysSocialRelationsVEN.con_Achievement:
                    return (a, b) => {
                        return a.achievement.localeCompare(b.achievement);
                    };
                case clsSysSocialRelationsVEN_js_1.clsSysSocialRelationsVEN.con_DetailedDescription:
                    return (a, b) => {
                        return a.detailedDescription.localeCompare(b.detailedDescription);
                    };
                case clsSysSocialRelationsVEN_js_1.clsSysSocialRelationsVEN.con_LevelId:
                    return (a, b) => {
                        return a.levelId.localeCompare(b.levelId);
                    };
                case clsSysSocialRelationsVEN_js_1.clsSysSocialRelationsVEN.con_UpdUser:
                    return (a, b) => {
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsSysSocialRelationsVEN_js_1.clsSysSocialRelationsVEN.con_UpdDate:
                    return (a, b) => {
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsSysSocialRelationsVEN_js_1.clsSysSocialRelationsVEN.con_id_CurrEduCls:
                    return (a, b) => {
                        return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
                    };
                case clsSysSocialRelationsVEN_js_1.clsSysSocialRelationsVEN.con_Memo:
                    return (a, b) => {
                        return a.memo.localeCompare(b.memo);
                    };
                case clsSysSocialRelationsVEN_js_1.clsSysSocialRelationsVEN.con_CitationId:
                    return (a, b) => {
                        return a.citationId.localeCompare(b.citationId);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[SysSocialRelationsV]中不存在！(in ${exports.sysSocialRelationsV_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsSysSocialRelationsVEN_js_1.clsSysSocialRelationsVEN.con_SocialVId:
                    return (a, b) => {
                        return b.socialVId - a.socialVId;
                    };
                case clsSysSocialRelationsVEN_js_1.clsSysSocialRelationsVEN.con_SocialId:
                    return (a, b) => {
                        return b.socialId.localeCompare(a.socialId);
                    };
                case clsSysSocialRelationsVEN_js_1.clsSysSocialRelationsVEN.con_FullName:
                    return (a, b) => {
                        return b.fullName.localeCompare(a.fullName);
                    };
                case clsSysSocialRelationsVEN_js_1.clsSysSocialRelationsVEN.con_Nationality:
                    return (a, b) => {
                        return b.nationality.localeCompare(a.nationality);
                    };
                case clsSysSocialRelationsVEN_js_1.clsSysSocialRelationsVEN.con_WorkUnit:
                    return (a, b) => {
                        return b.workUnit.localeCompare(a.workUnit);
                    };
                case clsSysSocialRelationsVEN_js_1.clsSysSocialRelationsVEN.con_Major:
                    return (a, b) => {
                        return b.major.localeCompare(a.major);
                    };
                case clsSysSocialRelationsVEN_js_1.clsSysSocialRelationsVEN.con_Achievement:
                    return (a, b) => {
                        return b.achievement.localeCompare(a.achievement);
                    };
                case clsSysSocialRelationsVEN_js_1.clsSysSocialRelationsVEN.con_DetailedDescription:
                    return (a, b) => {
                        return b.detailedDescription.localeCompare(a.detailedDescription);
                    };
                case clsSysSocialRelationsVEN_js_1.clsSysSocialRelationsVEN.con_LevelId:
                    return (a, b) => {
                        return b.levelId.localeCompare(a.levelId);
                    };
                case clsSysSocialRelationsVEN_js_1.clsSysSocialRelationsVEN.con_UpdUser:
                    return (a, b) => {
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsSysSocialRelationsVEN_js_1.clsSysSocialRelationsVEN.con_UpdDate:
                    return (a, b) => {
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsSysSocialRelationsVEN_js_1.clsSysSocialRelationsVEN.con_id_CurrEduCls:
                    return (a, b) => {
                        return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
                    };
                case clsSysSocialRelationsVEN_js_1.clsSysSocialRelationsVEN.con_Memo:
                    return (a, b) => {
                        return b.memo.localeCompare(a.memo);
                    };
                case clsSysSocialRelationsVEN_js_1.clsSysSocialRelationsVEN.con_CitationId:
                    return (a, b) => {
                        return b.citationId.localeCompare(a.citationId);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[SysSocialRelationsV]中不存在！(in ${exports.sysSocialRelationsV_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.SysSocialRelationsV_SortFunByKey = SysSocialRelationsV_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function SysSocialRelationsV_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsSysSocialRelationsVEN_js_1.clsSysSocialRelationsVEN.con_SocialVId:
                return (obj) => {
                    return obj.socialVId === value;
                };
            case clsSysSocialRelationsVEN_js_1.clsSysSocialRelationsVEN.con_SocialId:
                return (obj) => {
                    return obj.socialId === value;
                };
            case clsSysSocialRelationsVEN_js_1.clsSysSocialRelationsVEN.con_FullName:
                return (obj) => {
                    return obj.fullName === value;
                };
            case clsSysSocialRelationsVEN_js_1.clsSysSocialRelationsVEN.con_Nationality:
                return (obj) => {
                    return obj.nationality === value;
                };
            case clsSysSocialRelationsVEN_js_1.clsSysSocialRelationsVEN.con_WorkUnit:
                return (obj) => {
                    return obj.workUnit === value;
                };
            case clsSysSocialRelationsVEN_js_1.clsSysSocialRelationsVEN.con_Major:
                return (obj) => {
                    return obj.major === value;
                };
            case clsSysSocialRelationsVEN_js_1.clsSysSocialRelationsVEN.con_Achievement:
                return (obj) => {
                    return obj.achievement === value;
                };
            case clsSysSocialRelationsVEN_js_1.clsSysSocialRelationsVEN.con_DetailedDescription:
                return (obj) => {
                    return obj.detailedDescription === value;
                };
            case clsSysSocialRelationsVEN_js_1.clsSysSocialRelationsVEN.con_LevelId:
                return (obj) => {
                    return obj.levelId === value;
                };
            case clsSysSocialRelationsVEN_js_1.clsSysSocialRelationsVEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsSysSocialRelationsVEN_js_1.clsSysSocialRelationsVEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsSysSocialRelationsVEN_js_1.clsSysSocialRelationsVEN.con_id_CurrEduCls:
                return (obj) => {
                    return obj.id_CurrEduCls === value;
                };
            case clsSysSocialRelationsVEN_js_1.clsSysSocialRelationsVEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            case clsSysSocialRelationsVEN_js_1.clsSysSocialRelationsVEN.con_CitationId:
                return (obj) => {
                    return obj.citationId === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[SysSocialRelationsV]中不存在！(in ${exports.sysSocialRelationsV_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.SysSocialRelationsV_FilterFunByKey = SysSocialRelationsV_FilterFunByKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function SysSocialRelationsV_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSocialRelationsV_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSocialRelationsV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSocialRelationsV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSocialRelationsV_GetFirstIDAsync = SysSocialRelationsV_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function SysSocialRelationsV_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSocialRelationsV_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSocialRelationsV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSocialRelationsV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSocialRelationsV_GetFirstID = SysSocialRelationsV_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function SysSocialRelationsV_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSocialRelationsV_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.sysSocialRelationsV_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objSysSocialRelationsV = SysSocialRelationsV_GetObjFromJsonObj(returnObj);
                return objSysSocialRelationsV;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSocialRelationsV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSocialRelationsV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSocialRelationsV_GetFirstObjAsync = SysSocialRelationsV_GetFirstObjAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function SysSocialRelationsV_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSocialRelationsV_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.sysSocialRelationsV_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = SysSocialRelationsV_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSocialRelationsV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSocialRelationsV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSocialRelationsV_GetObjLstAsync = SysSocialRelationsV_GetObjLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrSocialVId:关键字列表
    * @returns 对象列表
    **/
    async function SysSocialRelationsV_GetObjLstBySocialVIdLstAsync(arrSocialVId) {
        const strThisFuncName = "GetObjLstBySocialVIdLstAsync";
        const strAction = "GetObjLstBySocialVIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSocialRelationsV_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrSocialVId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.sysSocialRelationsV_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = SysSocialRelationsV_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSocialRelationsV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSocialRelationsV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSocialRelationsV_GetObjLstBySocialVIdLstAsync = SysSocialRelationsV_GetObjLstBySocialVIdLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function SysSocialRelationsV_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSocialRelationsV_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.sysSocialRelationsV_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = SysSocialRelationsV_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSocialRelationsV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSocialRelationsV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSocialRelationsV_GetTopObjLstAsync = SysSocialRelationsV_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function SysSocialRelationsV_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSocialRelationsV_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.sysSocialRelationsV_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = SysSocialRelationsV_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSocialRelationsV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSocialRelationsV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSocialRelationsV_GetObjLstByRangeAsync = SysSocialRelationsV_GetObjLstByRangeAsync;
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
    async function SysSocialRelationsV_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSocialRelationsV_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSocialRelationsV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSocialRelationsV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSocialRelationsV_GetObjLstByRange = SysSocialRelationsV_GetObjLstByRange;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function SysSocialRelationsV_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSocialRelationsV_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.sysSocialRelationsV_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = SysSocialRelationsV_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSocialRelationsV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSocialRelationsV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSocialRelationsV_GetObjLstByPagerAsync = SysSocialRelationsV_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param lngSocialVId:关键字
    * @returns 获取删除的结果
    **/
    async function SysSocialRelationsV_DelRecordAsync(lngSocialVId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSocialRelationsV_Controller, strAction);
        strUrl = (0, clsString_js_1.Format)("{0}/?Id={1}", strUrl, lngSocialVId);
        try {
            const response = await axios_1.default.delete(strUrl, {
                params: { "Id": lngSocialVId, }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSocialRelationsV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSocialRelationsV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSocialRelationsV_DelRecordAsync = SysSocialRelationsV_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrSocialVId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function SysSocialRelationsV_DelSysSocialRelationsVsAsync(arrSocialVId) {
        const strThisFuncName = "DelSysSocialRelationsVsAsync";
        const strAction = "DelSysSocialRelationsVs";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSocialRelationsV_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrSocialVId);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSocialRelationsV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSocialRelationsV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSocialRelationsV_DelSysSocialRelationsVsAsync = SysSocialRelationsV_DelSysSocialRelationsVsAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function SysSocialRelationsV_DelSysSocialRelationsVsByCondAsync(strWhereCond) {
        const strThisFuncName = "DelSysSocialRelationsVsByCondAsync";
        const strAction = "DelSysSocialRelationsVsByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSocialRelationsV_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSocialRelationsV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSocialRelationsV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSocialRelationsV_DelSysSocialRelationsVsByCondAsync = SysSocialRelationsV_DelSysSocialRelationsVsByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objSysSocialRelationsVEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function SysSocialRelationsV_AddNewRecordAsync(objSysSocialRelationsVEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objSysSocialRelationsVEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSocialRelationsV_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objSysSocialRelationsVEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSocialRelationsV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSocialRelationsV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSocialRelationsV_AddNewRecordAsync = SysSocialRelationsV_AddNewRecordAsync;
    /* 数据类型不是字符型，不可以最大关键字的方式添加记录。*/
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objSysSocialRelationsVEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function SysSocialRelationsV_AddNewRecordWithReturnKeyAsync(objSysSocialRelationsVEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSocialRelationsV_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objSysSocialRelationsVEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSocialRelationsV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSocialRelationsV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSocialRelationsV_AddNewRecordWithReturnKeyAsync = SysSocialRelationsV_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objSysSocialRelationsVEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function SysSocialRelationsV_AddNewRecordWithReturnKey(objSysSocialRelationsVEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objSysSocialRelationsVEN.socialVId === null || objSysSocialRelationsVEN.socialVId === 0) {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSocialRelationsV_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objSysSocialRelationsVEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSocialRelationsV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSocialRelationsV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSocialRelationsV_AddNewRecordWithReturnKey = SysSocialRelationsV_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objSysSocialRelationsVEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function SysSocialRelationsV_UpdateRecordAsync(objSysSocialRelationsVEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objSysSocialRelationsVEN.sf_UpdFldSetStr === undefined || objSysSocialRelationsVEN.sf_UpdFldSetStr === null || objSysSocialRelationsVEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objSysSocialRelationsVEN.socialVId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSocialRelationsV_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objSysSocialRelationsVEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSocialRelationsV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSocialRelationsV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSocialRelationsV_UpdateRecordAsync = SysSocialRelationsV_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objSysSocialRelationsVEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function SysSocialRelationsV_UpdateWithConditionAsync(objSysSocialRelationsVEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objSysSocialRelationsVEN.sf_UpdFldSetStr === undefined || objSysSocialRelationsVEN.sf_UpdFldSetStr === null || objSysSocialRelationsVEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objSysSocialRelationsVEN.socialVId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSocialRelationsV_Controller, strAction);
        objSysSocialRelationsVEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objSysSocialRelationsVEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSocialRelationsV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSocialRelationsV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSocialRelationsV_UpdateWithConditionAsync = SysSocialRelationsV_UpdateWithConditionAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function SysSocialRelationsV_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSocialRelationsV_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSocialRelationsV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSocialRelationsV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSocialRelationsV_IsExistRecordAsync = SysSocialRelationsV_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param lngSocialVId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function SysSocialRelationsV_IsExist(lngSocialVId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSocialRelationsV_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "SocialVId": lngSocialVId,
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSocialRelationsV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSocialRelationsV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSocialRelationsV_IsExist = SysSocialRelationsV_IsExist;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param lngSocialVId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function SysSocialRelationsV_IsExistAsync(lngSocialVId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSocialRelationsV_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "lngSocialVId": lngSocialVId }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSocialRelationsV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSocialRelationsV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSocialRelationsV_IsExistAsync = SysSocialRelationsV_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function SysSocialRelationsV_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSocialRelationsV_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSocialRelationsV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSocialRelationsV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSocialRelationsV_GetRecCountByCondAsync = SysSocialRelationsV_GetRecCountByCondAsync;
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
    async function SysSocialRelationsV_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSocialRelationsV_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSocialRelationsV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSocialRelationsV_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSocialRelationsV_GetMaxStrIdByPrefix = SysSocialRelationsV_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function SysSocialRelationsV_GetWebApiUrl(strController, strAction) {
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
    exports.SysSocialRelationsV_GetWebApiUrl = SysSocialRelationsV_GetWebApiUrl;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function SysSocialRelationsV_CheckPropertyNew(pobjSysSocialRelationsVEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsVEN.socialId) === true) {
            throw new Error("(errid:Watl000058)字段[社会Id]不能为空(In 社会关系版本表)!(clsSysSocialRelationsVBL:CheckPropertyNew)");
        }
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsVEN.socialId) == false && (0, clsString_js_1.GetStrLen)(pobjSysSocialRelationsVEN.socialId) > 10) {
            throw new Error("(errid:Watl000059)字段[社会Id(socialId)]的长度不能超过10(In 社会关系版本表(SysSocialRelationsV))!值:$(pobjSysSocialRelationsVEN.socialId)(clsSysSocialRelationsVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsVEN.fullName) == false && (0, clsString_js_1.GetStrLen)(pobjSysSocialRelationsVEN.fullName) > 50) {
            throw new Error("(errid:Watl000059)字段[姓名(fullName)]的长度不能超过50(In 社会关系版本表(SysSocialRelationsV))!值:$(pobjSysSocialRelationsVEN.fullName)(clsSysSocialRelationsVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsVEN.nationality) == false && (0, clsString_js_1.GetStrLen)(pobjSysSocialRelationsVEN.nationality) > 50) {
            throw new Error("(errid:Watl000059)字段[国籍(nationality)]的长度不能超过50(In 社会关系版本表(SysSocialRelationsV))!值:$(pobjSysSocialRelationsVEN.nationality)(clsSysSocialRelationsVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsVEN.workUnit) == false && (0, clsString_js_1.GetStrLen)(pobjSysSocialRelationsVEN.workUnit) > 100) {
            throw new Error("(errid:Watl000059)字段[工作单位(workUnit)]的长度不能超过100(In 社会关系版本表(SysSocialRelationsV))!值:$(pobjSysSocialRelationsVEN.workUnit)(clsSysSocialRelationsVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsVEN.major) == false && (0, clsString_js_1.GetStrLen)(pobjSysSocialRelationsVEN.major) > 50) {
            throw new Error("(errid:Watl000059)字段[专业(major)]的长度不能超过50(In 社会关系版本表(SysSocialRelationsV))!值:$(pobjSysSocialRelationsVEN.major)(clsSysSocialRelationsVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsVEN.achievement) == false && (0, clsString_js_1.GetStrLen)(pobjSysSocialRelationsVEN.achievement) > 5000) {
            throw new Error("(errid:Watl000059)字段[成就(achievement)]的长度不能超过5000(In 社会关系版本表(SysSocialRelationsV))!值:$(pobjSysSocialRelationsVEN.achievement)(clsSysSocialRelationsVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsVEN.levelId) == false && (0, clsString_js_1.GetStrLen)(pobjSysSocialRelationsVEN.levelId) > 2) {
            throw new Error("(errid:Watl000059)字段[级别Id(levelId)]的长度不能超过2(In 社会关系版本表(SysSocialRelationsV))!值:$(pobjSysSocialRelationsVEN.levelId)(clsSysSocialRelationsVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsVEN.updUser) == false && (0, clsString_js_1.GetStrLen)(pobjSysSocialRelationsVEN.updUser) > 20) {
            throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 社会关系版本表(SysSocialRelationsV))!值:$(pobjSysSocialRelationsVEN.updUser)(clsSysSocialRelationsVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsVEN.updDate) == false && (0, clsString_js_1.GetStrLen)(pobjSysSocialRelationsVEN.updDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 社会关系版本表(SysSocialRelationsV))!值:$(pobjSysSocialRelationsVEN.updDate)(clsSysSocialRelationsVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsVEN.id_CurrEduCls) == false && (0, clsString_js_1.GetStrLen)(pobjSysSocialRelationsVEN.id_CurrEduCls) > 8) {
            throw new Error("(errid:Watl000059)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 社会关系版本表(SysSocialRelationsV))!值:$(pobjSysSocialRelationsVEN.id_CurrEduCls)(clsSysSocialRelationsVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsVEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjSysSocialRelationsVEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 社会关系版本表(SysSocialRelationsV))!值:$(pobjSysSocialRelationsVEN.memo)(clsSysSocialRelationsVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsVEN.citationId) == false && (0, clsString_js_1.GetStrLen)(pobjSysSocialRelationsVEN.citationId) > 8) {
            throw new Error("(errid:Watl000059)字段[引用Id(citationId)]的长度不能超过8(In 社会关系版本表(SysSocialRelationsV))!值:$(pobjSysSocialRelationsVEN.citationId)(clsSysSocialRelationsVBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if (null != pobjSysSocialRelationsVEN.socialVId && undefined !== pobjSysSocialRelationsVEN.socialVId && jsString_js_1.tzDataType.isNumber(pobjSysSocialRelationsVEN.socialVId) === false) {
            throw new Error("(errid:Watl000060)字段[社会版本Id(socialVId)]的值:[$(pobjSysSocialRelationsVEN.socialVId)], 非法，应该为数值型(In 社会关系版本表(SysSocialRelationsV))!(clsSysSocialRelationsVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsVEN.socialId) == false && undefined !== pobjSysSocialRelationsVEN.socialId && jsString_js_1.tzDataType.isString(pobjSysSocialRelationsVEN.socialId) === false) {
            throw new Error("(errid:Watl000060)字段[社会Id(socialId)]的值:[$(pobjSysSocialRelationsVEN.socialId)], 非法，应该为字符型(In 社会关系版本表(SysSocialRelationsV))!(clsSysSocialRelationsVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsVEN.fullName) == false && undefined !== pobjSysSocialRelationsVEN.fullName && jsString_js_1.tzDataType.isString(pobjSysSocialRelationsVEN.fullName) === false) {
            throw new Error("(errid:Watl000060)字段[姓名(fullName)]的值:[$(pobjSysSocialRelationsVEN.fullName)], 非法，应该为字符型(In 社会关系版本表(SysSocialRelationsV))!(clsSysSocialRelationsVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsVEN.nationality) == false && undefined !== pobjSysSocialRelationsVEN.nationality && jsString_js_1.tzDataType.isString(pobjSysSocialRelationsVEN.nationality) === false) {
            throw new Error("(errid:Watl000060)字段[国籍(nationality)]的值:[$(pobjSysSocialRelationsVEN.nationality)], 非法，应该为字符型(In 社会关系版本表(SysSocialRelationsV))!(clsSysSocialRelationsVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsVEN.workUnit) == false && undefined !== pobjSysSocialRelationsVEN.workUnit && jsString_js_1.tzDataType.isString(pobjSysSocialRelationsVEN.workUnit) === false) {
            throw new Error("(errid:Watl000060)字段[工作单位(workUnit)]的值:[$(pobjSysSocialRelationsVEN.workUnit)], 非法，应该为字符型(In 社会关系版本表(SysSocialRelationsV))!(clsSysSocialRelationsVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsVEN.major) == false && undefined !== pobjSysSocialRelationsVEN.major && jsString_js_1.tzDataType.isString(pobjSysSocialRelationsVEN.major) === false) {
            throw new Error("(errid:Watl000060)字段[专业(major)]的值:[$(pobjSysSocialRelationsVEN.major)], 非法，应该为字符型(In 社会关系版本表(SysSocialRelationsV))!(clsSysSocialRelationsVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsVEN.achievement) == false && undefined !== pobjSysSocialRelationsVEN.achievement && jsString_js_1.tzDataType.isString(pobjSysSocialRelationsVEN.achievement) === false) {
            throw new Error("(errid:Watl000060)字段[成就(achievement)]的值:[$(pobjSysSocialRelationsVEN.achievement)], 非法，应该为字符型(In 社会关系版本表(SysSocialRelationsV))!(clsSysSocialRelationsVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsVEN.detailedDescription) == false && undefined !== pobjSysSocialRelationsVEN.detailedDescription && jsString_js_1.tzDataType.isString(pobjSysSocialRelationsVEN.detailedDescription) === false) {
            throw new Error("(errid:Watl000060)字段[详细说明(detailedDescription)]的值:[$(pobjSysSocialRelationsVEN.detailedDescription)], 非法，应该为字符型(In 社会关系版本表(SysSocialRelationsV))!(clsSysSocialRelationsVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsVEN.levelId) == false && undefined !== pobjSysSocialRelationsVEN.levelId && jsString_js_1.tzDataType.isString(pobjSysSocialRelationsVEN.levelId) === false) {
            throw new Error("(errid:Watl000060)字段[级别Id(levelId)]的值:[$(pobjSysSocialRelationsVEN.levelId)], 非法，应该为字符型(In 社会关系版本表(SysSocialRelationsV))!(clsSysSocialRelationsVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsVEN.updUser) == false && undefined !== pobjSysSocialRelationsVEN.updUser && jsString_js_1.tzDataType.isString(pobjSysSocialRelationsVEN.updUser) === false) {
            throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjSysSocialRelationsVEN.updUser)], 非法，应该为字符型(In 社会关系版本表(SysSocialRelationsV))!(clsSysSocialRelationsVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsVEN.updDate) == false && undefined !== pobjSysSocialRelationsVEN.updDate && jsString_js_1.tzDataType.isString(pobjSysSocialRelationsVEN.updDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjSysSocialRelationsVEN.updDate)], 非法，应该为字符型(In 社会关系版本表(SysSocialRelationsV))!(clsSysSocialRelationsVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsVEN.id_CurrEduCls) == false && undefined !== pobjSysSocialRelationsVEN.id_CurrEduCls && jsString_js_1.tzDataType.isString(pobjSysSocialRelationsVEN.id_CurrEduCls) === false) {
            throw new Error("(errid:Watl000060)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjSysSocialRelationsVEN.id_CurrEduCls)], 非法，应该为字符型(In 社会关系版本表(SysSocialRelationsV))!(clsSysSocialRelationsVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsVEN.memo) == false && undefined !== pobjSysSocialRelationsVEN.memo && jsString_js_1.tzDataType.isString(pobjSysSocialRelationsVEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjSysSocialRelationsVEN.memo)], 非法，应该为字符型(In 社会关系版本表(SysSocialRelationsV))!(clsSysSocialRelationsVBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsVEN.citationId) == false && undefined !== pobjSysSocialRelationsVEN.citationId && jsString_js_1.tzDataType.isString(pobjSysSocialRelationsVEN.citationId) === false) {
            throw new Error("(errid:Watl000060)字段[引用Id(citationId)]的值:[$(pobjSysSocialRelationsVEN.citationId)], 非法，应该为字符型(In 社会关系版本表(SysSocialRelationsV))!(clsSysSocialRelationsVBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjSysSocialRelationsVEN.SetIsCheckProperty(true);
    }
    exports.SysSocialRelationsV_CheckPropertyNew = SysSocialRelationsV_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function SysSocialRelationsV_CheckProperty4Update(pobjSysSocialRelationsVEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsVEN.socialId) == false && (0, clsString_js_1.GetStrLen)(pobjSysSocialRelationsVEN.socialId) > 10) {
            throw new Error("(errid:Watl000062)字段[社会Id(socialId)]的长度不能超过10(In 社会关系版本表(SysSocialRelationsV))!值:$(pobjSysSocialRelationsVEN.socialId)(clsSysSocialRelationsVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsVEN.fullName) == false && (0, clsString_js_1.GetStrLen)(pobjSysSocialRelationsVEN.fullName) > 50) {
            throw new Error("(errid:Watl000062)字段[姓名(fullName)]的长度不能超过50(In 社会关系版本表(SysSocialRelationsV))!值:$(pobjSysSocialRelationsVEN.fullName)(clsSysSocialRelationsVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsVEN.nationality) == false && (0, clsString_js_1.GetStrLen)(pobjSysSocialRelationsVEN.nationality) > 50) {
            throw new Error("(errid:Watl000062)字段[国籍(nationality)]的长度不能超过50(In 社会关系版本表(SysSocialRelationsV))!值:$(pobjSysSocialRelationsVEN.nationality)(clsSysSocialRelationsVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsVEN.workUnit) == false && (0, clsString_js_1.GetStrLen)(pobjSysSocialRelationsVEN.workUnit) > 100) {
            throw new Error("(errid:Watl000062)字段[工作单位(workUnit)]的长度不能超过100(In 社会关系版本表(SysSocialRelationsV))!值:$(pobjSysSocialRelationsVEN.workUnit)(clsSysSocialRelationsVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsVEN.major) == false && (0, clsString_js_1.GetStrLen)(pobjSysSocialRelationsVEN.major) > 50) {
            throw new Error("(errid:Watl000062)字段[专业(major)]的长度不能超过50(In 社会关系版本表(SysSocialRelationsV))!值:$(pobjSysSocialRelationsVEN.major)(clsSysSocialRelationsVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsVEN.achievement) == false && (0, clsString_js_1.GetStrLen)(pobjSysSocialRelationsVEN.achievement) > 5000) {
            throw new Error("(errid:Watl000062)字段[成就(achievement)]的长度不能超过5000(In 社会关系版本表(SysSocialRelationsV))!值:$(pobjSysSocialRelationsVEN.achievement)(clsSysSocialRelationsVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsVEN.levelId) == false && (0, clsString_js_1.GetStrLen)(pobjSysSocialRelationsVEN.levelId) > 2) {
            throw new Error("(errid:Watl000062)字段[级别Id(levelId)]的长度不能超过2(In 社会关系版本表(SysSocialRelationsV))!值:$(pobjSysSocialRelationsVEN.levelId)(clsSysSocialRelationsVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsVEN.updUser) == false && (0, clsString_js_1.GetStrLen)(pobjSysSocialRelationsVEN.updUser) > 20) {
            throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 社会关系版本表(SysSocialRelationsV))!值:$(pobjSysSocialRelationsVEN.updUser)(clsSysSocialRelationsVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsVEN.updDate) == false && (0, clsString_js_1.GetStrLen)(pobjSysSocialRelationsVEN.updDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 社会关系版本表(SysSocialRelationsV))!值:$(pobjSysSocialRelationsVEN.updDate)(clsSysSocialRelationsVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsVEN.id_CurrEduCls) == false && (0, clsString_js_1.GetStrLen)(pobjSysSocialRelationsVEN.id_CurrEduCls) > 8) {
            throw new Error("(errid:Watl000062)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 社会关系版本表(SysSocialRelationsV))!值:$(pobjSysSocialRelationsVEN.id_CurrEduCls)(clsSysSocialRelationsVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsVEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjSysSocialRelationsVEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 社会关系版本表(SysSocialRelationsV))!值:$(pobjSysSocialRelationsVEN.memo)(clsSysSocialRelationsVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsVEN.citationId) == false && (0, clsString_js_1.GetStrLen)(pobjSysSocialRelationsVEN.citationId) > 8) {
            throw new Error("(errid:Watl000062)字段[引用Id(citationId)]的长度不能超过8(In 社会关系版本表(SysSocialRelationsV))!值:$(pobjSysSocialRelationsVEN.citationId)(clsSysSocialRelationsVBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if (null != pobjSysSocialRelationsVEN.socialVId && undefined !== pobjSysSocialRelationsVEN.socialVId && jsString_js_1.tzDataType.isNumber(pobjSysSocialRelationsVEN.socialVId) === false) {
            throw new Error("(errid:Watl000063)字段[社会版本Id(socialVId)]的值:[$(pobjSysSocialRelationsVEN.socialVId)], 非法，应该为数值型(In 社会关系版本表(SysSocialRelationsV))!(clsSysSocialRelationsVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsVEN.socialId) == false && undefined !== pobjSysSocialRelationsVEN.socialId && jsString_js_1.tzDataType.isString(pobjSysSocialRelationsVEN.socialId) === false) {
            throw new Error("(errid:Watl000063)字段[社会Id(socialId)]的值:[$(pobjSysSocialRelationsVEN.socialId)], 非法，应该为字符型(In 社会关系版本表(SysSocialRelationsV))!(clsSysSocialRelationsVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsVEN.fullName) == false && undefined !== pobjSysSocialRelationsVEN.fullName && jsString_js_1.tzDataType.isString(pobjSysSocialRelationsVEN.fullName) === false) {
            throw new Error("(errid:Watl000063)字段[姓名(fullName)]的值:[$(pobjSysSocialRelationsVEN.fullName)], 非法，应该为字符型(In 社会关系版本表(SysSocialRelationsV))!(clsSysSocialRelationsVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsVEN.nationality) == false && undefined !== pobjSysSocialRelationsVEN.nationality && jsString_js_1.tzDataType.isString(pobjSysSocialRelationsVEN.nationality) === false) {
            throw new Error("(errid:Watl000063)字段[国籍(nationality)]的值:[$(pobjSysSocialRelationsVEN.nationality)], 非法，应该为字符型(In 社会关系版本表(SysSocialRelationsV))!(clsSysSocialRelationsVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsVEN.workUnit) == false && undefined !== pobjSysSocialRelationsVEN.workUnit && jsString_js_1.tzDataType.isString(pobjSysSocialRelationsVEN.workUnit) === false) {
            throw new Error("(errid:Watl000063)字段[工作单位(workUnit)]的值:[$(pobjSysSocialRelationsVEN.workUnit)], 非法，应该为字符型(In 社会关系版本表(SysSocialRelationsV))!(clsSysSocialRelationsVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsVEN.major) == false && undefined !== pobjSysSocialRelationsVEN.major && jsString_js_1.tzDataType.isString(pobjSysSocialRelationsVEN.major) === false) {
            throw new Error("(errid:Watl000063)字段[专业(major)]的值:[$(pobjSysSocialRelationsVEN.major)], 非法，应该为字符型(In 社会关系版本表(SysSocialRelationsV))!(clsSysSocialRelationsVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsVEN.achievement) == false && undefined !== pobjSysSocialRelationsVEN.achievement && jsString_js_1.tzDataType.isString(pobjSysSocialRelationsVEN.achievement) === false) {
            throw new Error("(errid:Watl000063)字段[成就(achievement)]的值:[$(pobjSysSocialRelationsVEN.achievement)], 非法，应该为字符型(In 社会关系版本表(SysSocialRelationsV))!(clsSysSocialRelationsVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsVEN.detailedDescription) == false && undefined !== pobjSysSocialRelationsVEN.detailedDescription && jsString_js_1.tzDataType.isString(pobjSysSocialRelationsVEN.detailedDescription) === false) {
            throw new Error("(errid:Watl000063)字段[详细说明(detailedDescription)]的值:[$(pobjSysSocialRelationsVEN.detailedDescription)], 非法，应该为字符型(In 社会关系版本表(SysSocialRelationsV))!(clsSysSocialRelationsVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsVEN.levelId) == false && undefined !== pobjSysSocialRelationsVEN.levelId && jsString_js_1.tzDataType.isString(pobjSysSocialRelationsVEN.levelId) === false) {
            throw new Error("(errid:Watl000063)字段[级别Id(levelId)]的值:[$(pobjSysSocialRelationsVEN.levelId)], 非法，应该为字符型(In 社会关系版本表(SysSocialRelationsV))!(clsSysSocialRelationsVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsVEN.updUser) == false && undefined !== pobjSysSocialRelationsVEN.updUser && jsString_js_1.tzDataType.isString(pobjSysSocialRelationsVEN.updUser) === false) {
            throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjSysSocialRelationsVEN.updUser)], 非法，应该为字符型(In 社会关系版本表(SysSocialRelationsV))!(clsSysSocialRelationsVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsVEN.updDate) == false && undefined !== pobjSysSocialRelationsVEN.updDate && jsString_js_1.tzDataType.isString(pobjSysSocialRelationsVEN.updDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjSysSocialRelationsVEN.updDate)], 非法，应该为字符型(In 社会关系版本表(SysSocialRelationsV))!(clsSysSocialRelationsVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsVEN.id_CurrEduCls) == false && undefined !== pobjSysSocialRelationsVEN.id_CurrEduCls && jsString_js_1.tzDataType.isString(pobjSysSocialRelationsVEN.id_CurrEduCls) === false) {
            throw new Error("(errid:Watl000063)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjSysSocialRelationsVEN.id_CurrEduCls)], 非法，应该为字符型(In 社会关系版本表(SysSocialRelationsV))!(clsSysSocialRelationsVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsVEN.memo) == false && undefined !== pobjSysSocialRelationsVEN.memo && jsString_js_1.tzDataType.isString(pobjSysSocialRelationsVEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjSysSocialRelationsVEN.memo)], 非法，应该为字符型(In 社会关系版本表(SysSocialRelationsV))!(clsSysSocialRelationsVBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsVEN.citationId) == false && undefined !== pobjSysSocialRelationsVEN.citationId && jsString_js_1.tzDataType.isString(pobjSysSocialRelationsVEN.citationId) === false) {
            throw new Error("(errid:Watl000063)字段[引用Id(citationId)]的值:[$(pobjSysSocialRelationsVEN.citationId)], 非法，应该为字符型(In 社会关系版本表(SysSocialRelationsV))!(clsSysSocialRelationsVBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if (null === pobjSysSocialRelationsVEN.socialVId
            || pobjSysSocialRelationsVEN.socialVId != null && pobjSysSocialRelationsVEN.socialVId.toString() === "") {
            throw new Error("(errid:Watl000064)字段[社会版本Id]不能为空(In 社会关系版本表)!(clsSysSocialRelationsVBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjSysSocialRelationsVEN.SetIsCheckProperty(true);
    }
    exports.SysSocialRelationsV_CheckProperty4Update = SysSocialRelationsV_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function SysSocialRelationsV_GetJSONStrByObj(pobjSysSocialRelationsVEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjSysSocialRelationsVEN.sf_UpdFldSetStr = pobjSysSocialRelationsVEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjSysSocialRelationsVEN);
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
    exports.SysSocialRelationsV_GetJSONStrByObj = SysSocialRelationsV_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function SysSocialRelationsV_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrSysSocialRelationsVObjLst = new Array();
        if (strJSON === "") {
            return arrSysSocialRelationsVObjLst;
        }
        try {
            arrSysSocialRelationsVObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrSysSocialRelationsVObjLst;
        }
        return arrSysSocialRelationsVObjLst;
    }
    exports.SysSocialRelationsV_GetObjLstByJSONStr = SysSocialRelationsV_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrSysSocialRelationsVObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function SysSocialRelationsV_GetObjLstByJSONObjLst(arrSysSocialRelationsVObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrSysSocialRelationsVObjLst = new Array();
        for (const objInFor of arrSysSocialRelationsVObjLstS) {
            const obj1 = SysSocialRelationsV_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrSysSocialRelationsVObjLst.push(obj1);
        }
        return arrSysSocialRelationsVObjLst;
    }
    exports.SysSocialRelationsV_GetObjLstByJSONObjLst = SysSocialRelationsV_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function SysSocialRelationsV_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjSysSocialRelationsVEN = new clsSysSocialRelationsVEN_js_1.clsSysSocialRelationsVEN();
        if (strJSON === "") {
            return pobjSysSocialRelationsVEN;
        }
        try {
            pobjSysSocialRelationsVEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjSysSocialRelationsVEN;
        }
        return pobjSysSocialRelationsVEN;
    }
    exports.SysSocialRelationsV_GetObjByJSONStr = SysSocialRelationsV_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function SysSocialRelationsV_GetCombineCondition(objSysSocialRelationsV_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objSysSocialRelationsV_Cond.dicFldComparisonOp, clsSysSocialRelationsVEN_js_1.clsSysSocialRelationsVEN.con_SocialVId) == true) {
            const strComparisonOp_SocialVId = objSysSocialRelationsV_Cond.dicFldComparisonOp[clsSysSocialRelationsVEN_js_1.clsSysSocialRelationsVEN.con_SocialVId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsSysSocialRelationsVEN_js_1.clsSysSocialRelationsVEN.con_SocialVId, objSysSocialRelationsV_Cond.socialVId, strComparisonOp_SocialVId);
        }
        if (Object.prototype.hasOwnProperty.call(objSysSocialRelationsV_Cond.dicFldComparisonOp, clsSysSocialRelationsVEN_js_1.clsSysSocialRelationsVEN.con_SocialId) == true) {
            const strComparisonOp_SocialId = objSysSocialRelationsV_Cond.dicFldComparisonOp[clsSysSocialRelationsVEN_js_1.clsSysSocialRelationsVEN.con_SocialId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsSysSocialRelationsVEN_js_1.clsSysSocialRelationsVEN.con_SocialId, objSysSocialRelationsV_Cond.socialId, strComparisonOp_SocialId);
        }
        if (Object.prototype.hasOwnProperty.call(objSysSocialRelationsV_Cond.dicFldComparisonOp, clsSysSocialRelationsVEN_js_1.clsSysSocialRelationsVEN.con_FullName) == true) {
            const strComparisonOp_FullName = objSysSocialRelationsV_Cond.dicFldComparisonOp[clsSysSocialRelationsVEN_js_1.clsSysSocialRelationsVEN.con_FullName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsSysSocialRelationsVEN_js_1.clsSysSocialRelationsVEN.con_FullName, objSysSocialRelationsV_Cond.fullName, strComparisonOp_FullName);
        }
        if (Object.prototype.hasOwnProperty.call(objSysSocialRelationsV_Cond.dicFldComparisonOp, clsSysSocialRelationsVEN_js_1.clsSysSocialRelationsVEN.con_Nationality) == true) {
            const strComparisonOp_Nationality = objSysSocialRelationsV_Cond.dicFldComparisonOp[clsSysSocialRelationsVEN_js_1.clsSysSocialRelationsVEN.con_Nationality];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsSysSocialRelationsVEN_js_1.clsSysSocialRelationsVEN.con_Nationality, objSysSocialRelationsV_Cond.nationality, strComparisonOp_Nationality);
        }
        if (Object.prototype.hasOwnProperty.call(objSysSocialRelationsV_Cond.dicFldComparisonOp, clsSysSocialRelationsVEN_js_1.clsSysSocialRelationsVEN.con_WorkUnit) == true) {
            const strComparisonOp_WorkUnit = objSysSocialRelationsV_Cond.dicFldComparisonOp[clsSysSocialRelationsVEN_js_1.clsSysSocialRelationsVEN.con_WorkUnit];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsSysSocialRelationsVEN_js_1.clsSysSocialRelationsVEN.con_WorkUnit, objSysSocialRelationsV_Cond.workUnit, strComparisonOp_WorkUnit);
        }
        if (Object.prototype.hasOwnProperty.call(objSysSocialRelationsV_Cond.dicFldComparisonOp, clsSysSocialRelationsVEN_js_1.clsSysSocialRelationsVEN.con_Major) == true) {
            const strComparisonOp_Major = objSysSocialRelationsV_Cond.dicFldComparisonOp[clsSysSocialRelationsVEN_js_1.clsSysSocialRelationsVEN.con_Major];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsSysSocialRelationsVEN_js_1.clsSysSocialRelationsVEN.con_Major, objSysSocialRelationsV_Cond.major, strComparisonOp_Major);
        }
        if (Object.prototype.hasOwnProperty.call(objSysSocialRelationsV_Cond.dicFldComparisonOp, clsSysSocialRelationsVEN_js_1.clsSysSocialRelationsVEN.con_Achievement) == true) {
            const strComparisonOp_Achievement = objSysSocialRelationsV_Cond.dicFldComparisonOp[clsSysSocialRelationsVEN_js_1.clsSysSocialRelationsVEN.con_Achievement];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsSysSocialRelationsVEN_js_1.clsSysSocialRelationsVEN.con_Achievement, objSysSocialRelationsV_Cond.achievement, strComparisonOp_Achievement);
        }
        //数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
        if (Object.prototype.hasOwnProperty.call(objSysSocialRelationsV_Cond.dicFldComparisonOp, clsSysSocialRelationsVEN_js_1.clsSysSocialRelationsVEN.con_LevelId) == true) {
            const strComparisonOp_LevelId = objSysSocialRelationsV_Cond.dicFldComparisonOp[clsSysSocialRelationsVEN_js_1.clsSysSocialRelationsVEN.con_LevelId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsSysSocialRelationsVEN_js_1.clsSysSocialRelationsVEN.con_LevelId, objSysSocialRelationsV_Cond.levelId, strComparisonOp_LevelId);
        }
        if (Object.prototype.hasOwnProperty.call(objSysSocialRelationsV_Cond.dicFldComparisonOp, clsSysSocialRelationsVEN_js_1.clsSysSocialRelationsVEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objSysSocialRelationsV_Cond.dicFldComparisonOp[clsSysSocialRelationsVEN_js_1.clsSysSocialRelationsVEN.con_UpdUser];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsSysSocialRelationsVEN_js_1.clsSysSocialRelationsVEN.con_UpdUser, objSysSocialRelationsV_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objSysSocialRelationsV_Cond.dicFldComparisonOp, clsSysSocialRelationsVEN_js_1.clsSysSocialRelationsVEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objSysSocialRelationsV_Cond.dicFldComparisonOp[clsSysSocialRelationsVEN_js_1.clsSysSocialRelationsVEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsSysSocialRelationsVEN_js_1.clsSysSocialRelationsVEN.con_UpdDate, objSysSocialRelationsV_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objSysSocialRelationsV_Cond.dicFldComparisonOp, clsSysSocialRelationsVEN_js_1.clsSysSocialRelationsVEN.con_id_CurrEduCls) == true) {
            const strComparisonOp_id_CurrEduCls = objSysSocialRelationsV_Cond.dicFldComparisonOp[clsSysSocialRelationsVEN_js_1.clsSysSocialRelationsVEN.con_id_CurrEduCls];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsSysSocialRelationsVEN_js_1.clsSysSocialRelationsVEN.con_id_CurrEduCls, objSysSocialRelationsV_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
        }
        if (Object.prototype.hasOwnProperty.call(objSysSocialRelationsV_Cond.dicFldComparisonOp, clsSysSocialRelationsVEN_js_1.clsSysSocialRelationsVEN.con_Memo) == true) {
            const strComparisonOp_Memo = objSysSocialRelationsV_Cond.dicFldComparisonOp[clsSysSocialRelationsVEN_js_1.clsSysSocialRelationsVEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsSysSocialRelationsVEN_js_1.clsSysSocialRelationsVEN.con_Memo, objSysSocialRelationsV_Cond.memo, strComparisonOp_Memo);
        }
        if (Object.prototype.hasOwnProperty.call(objSysSocialRelationsV_Cond.dicFldComparisonOp, clsSysSocialRelationsVEN_js_1.clsSysSocialRelationsVEN.con_CitationId) == true) {
            const strComparisonOp_CitationId = objSysSocialRelationsV_Cond.dicFldComparisonOp[clsSysSocialRelationsVEN_js_1.clsSysSocialRelationsVEN.con_CitationId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsSysSocialRelationsVEN_js_1.clsSysSocialRelationsVEN.con_CitationId, objSysSocialRelationsV_Cond.citationId, strComparisonOp_CitationId);
        }
        return strWhereCond;
    }
    exports.SysSocialRelationsV_GetCombineCondition = SysSocialRelationsV_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--SysSocialRelationsV(社会关系版本表),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param lngSocialVId: 社会版本Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function SysSocialRelationsV_GetUniCondStr_SocialVId(objSysSocialRelationsVEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and SocialVId = '{0}'", objSysSocialRelationsVEN.socialVId);
        return strWhereCond;
    }
    exports.SysSocialRelationsV_GetUniCondStr_SocialVId = SysSocialRelationsV_GetUniCondStr_SocialVId;
    /**
    *获取唯一性条件串(Uniqueness)--SysSocialRelationsV(社会关系版本表),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param lngSocialVId: 社会版本Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function SysSocialRelationsV_GetUniCondStr4Update_SocialVId(objSysSocialRelationsVEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and SocialVId <> '{0}'", objSysSocialRelationsVEN.socialVId);
        strWhereCond += (0, clsString_js_1.Format)(" and SocialVId = '{0}'", objSysSocialRelationsVEN.socialVId);
        return strWhereCond;
    }
    exports.SysSocialRelationsV_GetUniCondStr4Update_SocialVId = SysSocialRelationsV_GetUniCondStr4Update_SocialVId;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objSysSocialRelationsVENS:源对象
     * @param objSysSocialRelationsVENT:目标对象
    */
    function SysSocialRelationsV_CopyObjTo(objSysSocialRelationsVENS, objSysSocialRelationsVENT) {
        objSysSocialRelationsVENT.socialVId = objSysSocialRelationsVENS.socialVId; //社会版本Id
        objSysSocialRelationsVENT.socialId = objSysSocialRelationsVENS.socialId; //社会Id
        objSysSocialRelationsVENT.fullName = objSysSocialRelationsVENS.fullName; //姓名
        objSysSocialRelationsVENT.nationality = objSysSocialRelationsVENS.nationality; //国籍
        objSysSocialRelationsVENT.workUnit = objSysSocialRelationsVENS.workUnit; //工作单位
        objSysSocialRelationsVENT.major = objSysSocialRelationsVENS.major; //专业
        objSysSocialRelationsVENT.achievement = objSysSocialRelationsVENS.achievement; //成就
        objSysSocialRelationsVENT.detailedDescription = objSysSocialRelationsVENS.detailedDescription; //详细说明
        objSysSocialRelationsVENT.levelId = objSysSocialRelationsVENS.levelId; //级别Id
        objSysSocialRelationsVENT.updUser = objSysSocialRelationsVENS.updUser; //修改人
        objSysSocialRelationsVENT.updDate = objSysSocialRelationsVENS.updDate; //修改日期
        objSysSocialRelationsVENT.id_CurrEduCls = objSysSocialRelationsVENS.id_CurrEduCls; //教学班流水号
        objSysSocialRelationsVENT.memo = objSysSocialRelationsVENS.memo; //备注
        objSysSocialRelationsVENT.citationId = objSysSocialRelationsVENS.citationId; //引用Id
        objSysSocialRelationsVENT.sf_UpdFldSetStr = objSysSocialRelationsVENS.updFldString; //sf_UpdFldSetStr
    }
    exports.SysSocialRelationsV_CopyObjTo = SysSocialRelationsV_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objSysSocialRelationsVENS:源对象
     * @param objSysSocialRelationsVENT:目标对象
    */
    function SysSocialRelationsV_GetObjFromJsonObj(objSysSocialRelationsVENS) {
        const objSysSocialRelationsVENT = new clsSysSocialRelationsVEN_js_1.clsSysSocialRelationsVEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objSysSocialRelationsVENT, objSysSocialRelationsVENS);
        return objSysSocialRelationsVENT;
    }
    exports.SysSocialRelationsV_GetObjFromJsonObj = SysSocialRelationsV_GetObjFromJsonObj;
});
