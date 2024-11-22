/**
* 类名:clsSysSocialRelationsVerWApi
* 表名:SysSocialRelationsVer(01120645)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/13 00:44:02
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
        define(["require", "exports", "axios", "../../L0_Entity/GraduateEduTopic/clsSysSocialRelationsVerEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.SysSocialRelationsVer_GetObjFromJsonObj = exports.SysSocialRelationsVer_CopyObjTo = exports.SysSocialRelationsVer_GetUniCondStr4Update_SocialVId = exports.SysSocialRelationsVer_GetUniCondStr_SocialVId = exports.SysSocialRelationsVer_GetCombineCondition = exports.SysSocialRelationsVer_GetObjByJSONStr = exports.SysSocialRelationsVer_GetObjLstByJSONObjLst = exports.SysSocialRelationsVer_GetObjLstByJSONStr = exports.SysSocialRelationsVer_GetJSONStrByObj = exports.SysSocialRelationsVer_CheckProperty4Update = exports.SysSocialRelationsVer_CheckPropertyNew = exports.SysSocialRelationsVer_GetWebApiUrl = exports.SysSocialRelationsVer_GetMaxStrIdByPrefix = exports.SysSocialRelationsVer_GetRecCountByCondAsync = exports.SysSocialRelationsVer_IsExistAsync = exports.SysSocialRelationsVer_IsExist = exports.SysSocialRelationsVer_IsExistRecordAsync = exports.SysSocialRelationsVer_UpdateWithConditionAsync = exports.SysSocialRelationsVer_UpdateRecordAsync = exports.SysSocialRelationsVer_AddNewRecordWithReturnKey = exports.SysSocialRelationsVer_AddNewRecordWithReturnKeyAsync = exports.SysSocialRelationsVer_AddNewRecordAsync = exports.SysSocialRelationsVer_DelSysSocialRelationsVersByCondAsync = exports.SysSocialRelationsVer_DelSysSocialRelationsVersAsync = exports.SysSocialRelationsVer_DelRecordAsync = exports.SysSocialRelationsVer_GetObjLstByPagerAsync = exports.SysSocialRelationsVer_GetObjLstByRange = exports.SysSocialRelationsVer_GetObjLstByRangeAsync = exports.SysSocialRelationsVer_GetTopObjLstAsync = exports.SysSocialRelationsVer_GetObjLstBySocialVIdLstAsync = exports.SysSocialRelationsVer_GetObjLstAsync = exports.SysSocialRelationsVer_GetFirstObjAsync = exports.SysSocialRelationsVer_GetFirstID = exports.SysSocialRelationsVer_GetFirstIDAsync = exports.SysSocialRelationsVer_FilterFunByKey = exports.SysSocialRelationsVer_SortFunByKey = exports.SysSocialRelationsVer_SortFun_Defa_2Fld = exports.SysSocialRelationsVer_SortFun_Defa = exports.SysSocialRelationsVer_GetObjBySocialVIdAsync = exports.sysSocialRelationsVer_ConstructorName = exports.sysSocialRelationsVer_Controller = void 0;
    /**
     * 社会关系版本表(SysSocialRelationsVer)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月13日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const clsSysSocialRelationsVerEN_js_1 = require("../../L0_Entity/GraduateEduTopic/clsSysSocialRelationsVerEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsString_js_2 = require("../../PubFun/clsString.js");
    exports.sysSocialRelationsVer_Controller = "SysSocialRelationsVerApi";
    exports.sysSocialRelationsVer_ConstructorName = "sysSocialRelationsVer";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param lngSocialVId:关键字
    * @returns 对象
    **/
    async function SysSocialRelationsVer_GetObjBySocialVIdAsync(lngSocialVId) {
        const strThisFuncName = "GetObjBySocialVIdAsync";
        if (lngSocialVId == 0) {
            const strMsg = (0, clsString_js_2.Format)("参数:[lngSocialVId]不能为空！(In clsSysSocialRelationsVerWApi.GetObjBySocialVIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjBySocialVId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSocialRelationsVer_Controller, strAction);
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
                    return null;
                }
                //console.log(returnObj);
                const objSysSocialRelationsVer = SysSocialRelationsVer_GetObjFromJsonObj(returnObj);
                return objSysSocialRelationsVer;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSocialRelationsVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSocialRelationsVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSocialRelationsVer_GetObjBySocialVIdAsync = SysSocialRelationsVer_GetObjBySocialVIdAsync;
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
    function SysSocialRelationsVer_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.socialVId - b.socialVId;
    }
    exports.SysSocialRelationsVer_SortFun_Defa = SysSocialRelationsVer_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function SysSocialRelationsVer_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.socialId == b.socialId)
            return a.fullName.localeCompare(b.fullName);
        else
            return a.socialId.localeCompare(b.socialId);
    }
    exports.SysSocialRelationsVer_SortFun_Defa_2Fld = SysSocialRelationsVer_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function SysSocialRelationsVer_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsSysSocialRelationsVerEN_js_1.clsSysSocialRelationsVerEN.con_SocialVId:
                    return (a, b) => {
                        return a.socialVId - b.socialVId;
                    };
                case clsSysSocialRelationsVerEN_js_1.clsSysSocialRelationsVerEN.con_SocialId:
                    return (a, b) => {
                        return a.socialId.localeCompare(b.socialId);
                    };
                case clsSysSocialRelationsVerEN_js_1.clsSysSocialRelationsVerEN.con_FullName:
                    return (a, b) => {
                        if (a.fullName == null)
                            return -1;
                        if (b.fullName == null)
                            return 1;
                        return a.fullName.localeCompare(b.fullName);
                    };
                case clsSysSocialRelationsVerEN_js_1.clsSysSocialRelationsVerEN.con_Nationality:
                    return (a, b) => {
                        if (a.nationality == null)
                            return -1;
                        if (b.nationality == null)
                            return 1;
                        return a.nationality.localeCompare(b.nationality);
                    };
                case clsSysSocialRelationsVerEN_js_1.clsSysSocialRelationsVerEN.con_WorkUnit:
                    return (a, b) => {
                        if (a.workUnit == null)
                            return -1;
                        if (b.workUnit == null)
                            return 1;
                        return a.workUnit.localeCompare(b.workUnit);
                    };
                case clsSysSocialRelationsVerEN_js_1.clsSysSocialRelationsVerEN.con_Major:
                    return (a, b) => {
                        if (a.major == null)
                            return -1;
                        if (b.major == null)
                            return 1;
                        return a.major.localeCompare(b.major);
                    };
                case clsSysSocialRelationsVerEN_js_1.clsSysSocialRelationsVerEN.con_Achievement:
                    return (a, b) => {
                        if (a.achievement == null)
                            return -1;
                        if (b.achievement == null)
                            return 1;
                        return a.achievement.localeCompare(b.achievement);
                    };
                case clsSysSocialRelationsVerEN_js_1.clsSysSocialRelationsVerEN.con_DetailedDescription:
                    return (a, b) => {
                        if (a.detailedDescription == null)
                            return -1;
                        if (b.detailedDescription == null)
                            return 1;
                        return a.detailedDescription.localeCompare(b.detailedDescription);
                    };
                case clsSysSocialRelationsVerEN_js_1.clsSysSocialRelationsVerEN.con_LevelId:
                    return (a, b) => {
                        if (a.levelId == null)
                            return -1;
                        if (b.levelId == null)
                            return 1;
                        return a.levelId.localeCompare(b.levelId);
                    };
                case clsSysSocialRelationsVerEN_js_1.clsSysSocialRelationsVerEN.con_UpdUser:
                    return (a, b) => {
                        if (a.updUser == null)
                            return -1;
                        if (b.updUser == null)
                            return 1;
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsSysSocialRelationsVerEN_js_1.clsSysSocialRelationsVerEN.con_UpdDate:
                    return (a, b) => {
                        if (a.updDate == null)
                            return -1;
                        if (b.updDate == null)
                            return 1;
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsSysSocialRelationsVerEN_js_1.clsSysSocialRelationsVerEN.con_id_CurrEduCls:
                    return (a, b) => {
                        if (a.id_CurrEduCls == null)
                            return -1;
                        if (b.id_CurrEduCls == null)
                            return 1;
                        return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
                    };
                case clsSysSocialRelationsVerEN_js_1.clsSysSocialRelationsVerEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                case clsSysSocialRelationsVerEN_js_1.clsSysSocialRelationsVerEN.con_CitationId:
                    return (a, b) => {
                        if (a.citationId == null)
                            return -1;
                        if (b.citationId == null)
                            return 1;
                        return a.citationId.localeCompare(b.citationId);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[SysSocialRelationsVer]中不存在！(in ${exports.sysSocialRelationsVer_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsSysSocialRelationsVerEN_js_1.clsSysSocialRelationsVerEN.con_SocialVId:
                    return (a, b) => {
                        return b.socialVId - a.socialVId;
                    };
                case clsSysSocialRelationsVerEN_js_1.clsSysSocialRelationsVerEN.con_SocialId:
                    return (a, b) => {
                        return b.socialId.localeCompare(a.socialId);
                    };
                case clsSysSocialRelationsVerEN_js_1.clsSysSocialRelationsVerEN.con_FullName:
                    return (a, b) => {
                        if (b.fullName == null)
                            return -1;
                        if (a.fullName == null)
                            return 1;
                        return b.fullName.localeCompare(a.fullName);
                    };
                case clsSysSocialRelationsVerEN_js_1.clsSysSocialRelationsVerEN.con_Nationality:
                    return (a, b) => {
                        if (b.nationality == null)
                            return -1;
                        if (a.nationality == null)
                            return 1;
                        return b.nationality.localeCompare(a.nationality);
                    };
                case clsSysSocialRelationsVerEN_js_1.clsSysSocialRelationsVerEN.con_WorkUnit:
                    return (a, b) => {
                        if (b.workUnit == null)
                            return -1;
                        if (a.workUnit == null)
                            return 1;
                        return b.workUnit.localeCompare(a.workUnit);
                    };
                case clsSysSocialRelationsVerEN_js_1.clsSysSocialRelationsVerEN.con_Major:
                    return (a, b) => {
                        if (b.major == null)
                            return -1;
                        if (a.major == null)
                            return 1;
                        return b.major.localeCompare(a.major);
                    };
                case clsSysSocialRelationsVerEN_js_1.clsSysSocialRelationsVerEN.con_Achievement:
                    return (a, b) => {
                        if (b.achievement == null)
                            return -1;
                        if (a.achievement == null)
                            return 1;
                        return b.achievement.localeCompare(a.achievement);
                    };
                case clsSysSocialRelationsVerEN_js_1.clsSysSocialRelationsVerEN.con_DetailedDescription:
                    return (a, b) => {
                        if (b.detailedDescription == null)
                            return -1;
                        if (a.detailedDescription == null)
                            return 1;
                        return b.detailedDescription.localeCompare(a.detailedDescription);
                    };
                case clsSysSocialRelationsVerEN_js_1.clsSysSocialRelationsVerEN.con_LevelId:
                    return (a, b) => {
                        if (b.levelId == null)
                            return -1;
                        if (a.levelId == null)
                            return 1;
                        return b.levelId.localeCompare(a.levelId);
                    };
                case clsSysSocialRelationsVerEN_js_1.clsSysSocialRelationsVerEN.con_UpdUser:
                    return (a, b) => {
                        if (b.updUser == null)
                            return -1;
                        if (a.updUser == null)
                            return 1;
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsSysSocialRelationsVerEN_js_1.clsSysSocialRelationsVerEN.con_UpdDate:
                    return (a, b) => {
                        if (b.updDate == null)
                            return -1;
                        if (a.updDate == null)
                            return 1;
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsSysSocialRelationsVerEN_js_1.clsSysSocialRelationsVerEN.con_id_CurrEduCls:
                    return (a, b) => {
                        if (b.id_CurrEduCls == null)
                            return -1;
                        if (a.id_CurrEduCls == null)
                            return 1;
                        return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
                    };
                case clsSysSocialRelationsVerEN_js_1.clsSysSocialRelationsVerEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                case clsSysSocialRelationsVerEN_js_1.clsSysSocialRelationsVerEN.con_CitationId:
                    return (a, b) => {
                        if (b.citationId == null)
                            return -1;
                        if (a.citationId == null)
                            return 1;
                        return b.citationId.localeCompare(a.citationId);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[SysSocialRelationsVer]中不存在！(in ${exports.sysSocialRelationsVer_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.SysSocialRelationsVer_SortFunByKey = SysSocialRelationsVer_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function SysSocialRelationsVer_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsSysSocialRelationsVerEN_js_1.clsSysSocialRelationsVerEN.con_SocialVId:
                return (obj) => {
                    return obj.socialVId === value;
                };
            case clsSysSocialRelationsVerEN_js_1.clsSysSocialRelationsVerEN.con_SocialId:
                return (obj) => {
                    return obj.socialId === value;
                };
            case clsSysSocialRelationsVerEN_js_1.clsSysSocialRelationsVerEN.con_FullName:
                return (obj) => {
                    return obj.fullName === value;
                };
            case clsSysSocialRelationsVerEN_js_1.clsSysSocialRelationsVerEN.con_Nationality:
                return (obj) => {
                    return obj.nationality === value;
                };
            case clsSysSocialRelationsVerEN_js_1.clsSysSocialRelationsVerEN.con_WorkUnit:
                return (obj) => {
                    return obj.workUnit === value;
                };
            case clsSysSocialRelationsVerEN_js_1.clsSysSocialRelationsVerEN.con_Major:
                return (obj) => {
                    return obj.major === value;
                };
            case clsSysSocialRelationsVerEN_js_1.clsSysSocialRelationsVerEN.con_Achievement:
                return (obj) => {
                    return obj.achievement === value;
                };
            case clsSysSocialRelationsVerEN_js_1.clsSysSocialRelationsVerEN.con_DetailedDescription:
                return (obj) => {
                    return obj.detailedDescription === value;
                };
            case clsSysSocialRelationsVerEN_js_1.clsSysSocialRelationsVerEN.con_LevelId:
                return (obj) => {
                    return obj.levelId === value;
                };
            case clsSysSocialRelationsVerEN_js_1.clsSysSocialRelationsVerEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsSysSocialRelationsVerEN_js_1.clsSysSocialRelationsVerEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsSysSocialRelationsVerEN_js_1.clsSysSocialRelationsVerEN.con_id_CurrEduCls:
                return (obj) => {
                    return obj.id_CurrEduCls === value;
                };
            case clsSysSocialRelationsVerEN_js_1.clsSysSocialRelationsVerEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            case clsSysSocialRelationsVerEN_js_1.clsSysSocialRelationsVerEN.con_CitationId:
                return (obj) => {
                    return obj.citationId === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[SysSocialRelationsVer]中不存在！(in ${exports.sysSocialRelationsVer_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.SysSocialRelationsVer_FilterFunByKey = SysSocialRelationsVer_FilterFunByKey;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function SysSocialRelationsVer_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSocialRelationsVer_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSocialRelationsVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSocialRelationsVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSocialRelationsVer_GetFirstIDAsync = SysSocialRelationsVer_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function SysSocialRelationsVer_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSocialRelationsVer_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSocialRelationsVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSocialRelationsVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSocialRelationsVer_GetFirstID = SysSocialRelationsVer_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function SysSocialRelationsVer_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSocialRelationsVer_Controller, strAction);
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
                const objSysSocialRelationsVer = SysSocialRelationsVer_GetObjFromJsonObj(returnObj);
                return objSysSocialRelationsVer;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSocialRelationsVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSocialRelationsVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSocialRelationsVer_GetFirstObjAsync = SysSocialRelationsVer_GetFirstObjAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function SysSocialRelationsVer_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSocialRelationsVer_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.sysSocialRelationsVer_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = SysSocialRelationsVer_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSocialRelationsVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSocialRelationsVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSocialRelationsVer_GetObjLstAsync = SysSocialRelationsVer_GetObjLstAsync;
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
    async function SysSocialRelationsVer_GetObjLstBySocialVIdLstAsync(arrSocialVId) {
        const strThisFuncName = "GetObjLstBySocialVIdLstAsync";
        const strAction = "GetObjLstBySocialVIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSocialRelationsVer_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrSocialVId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.sysSocialRelationsVer_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = SysSocialRelationsVer_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSocialRelationsVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSocialRelationsVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSocialRelationsVer_GetObjLstBySocialVIdLstAsync = SysSocialRelationsVer_GetObjLstBySocialVIdLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function SysSocialRelationsVer_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSocialRelationsVer_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.sysSocialRelationsVer_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = SysSocialRelationsVer_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSocialRelationsVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSocialRelationsVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSocialRelationsVer_GetTopObjLstAsync = SysSocialRelationsVer_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function SysSocialRelationsVer_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSocialRelationsVer_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.sysSocialRelationsVer_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = SysSocialRelationsVer_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSocialRelationsVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSocialRelationsVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSocialRelationsVer_GetObjLstByRangeAsync = SysSocialRelationsVer_GetObjLstByRangeAsync;
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
    async function SysSocialRelationsVer_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSocialRelationsVer_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSocialRelationsVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSocialRelationsVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSocialRelationsVer_GetObjLstByRange = SysSocialRelationsVer_GetObjLstByRange;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function SysSocialRelationsVer_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSocialRelationsVer_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.sysSocialRelationsVer_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = SysSocialRelationsVer_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSocialRelationsVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSocialRelationsVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSocialRelationsVer_GetObjLstByPagerAsync = SysSocialRelationsVer_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param lngSocialVId:关键字
    * @returns 获取删除的结果
    **/
    async function SysSocialRelationsVer_DelRecordAsync(lngSocialVId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSocialRelationsVer_Controller, strAction);
        strUrl = (0, clsString_js_2.Format)("{0}/?Id={1}", strUrl, lngSocialVId);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSocialRelationsVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSocialRelationsVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSocialRelationsVer_DelRecordAsync = SysSocialRelationsVer_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrSocialVId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function SysSocialRelationsVer_DelSysSocialRelationsVersAsync(arrSocialVId) {
        const strThisFuncName = "DelSysSocialRelationsVersAsync";
        const strAction = "DelSysSocialRelationsVers";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSocialRelationsVer_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSocialRelationsVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSocialRelationsVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSocialRelationsVer_DelSysSocialRelationsVersAsync = SysSocialRelationsVer_DelSysSocialRelationsVersAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function SysSocialRelationsVer_DelSysSocialRelationsVersByCondAsync(strWhereCond) {
        const strThisFuncName = "DelSysSocialRelationsVersByCondAsync";
        const strAction = "DelSysSocialRelationsVersByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSocialRelationsVer_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSocialRelationsVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSocialRelationsVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSocialRelationsVer_DelSysSocialRelationsVersByCondAsync = SysSocialRelationsVer_DelSysSocialRelationsVersByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objSysSocialRelationsVerEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function SysSocialRelationsVer_AddNewRecordAsync(objSysSocialRelationsVerEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objSysSocialRelationsVerEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSocialRelationsVer_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objSysSocialRelationsVerEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSocialRelationsVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSocialRelationsVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSocialRelationsVer_AddNewRecordAsync = SysSocialRelationsVer_AddNewRecordAsync;
    /* 数据类型不是字符型，不可以最大关键字的方式添加记录。*/
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objSysSocialRelationsVerEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function SysSocialRelationsVer_AddNewRecordWithReturnKeyAsync(objSysSocialRelationsVerEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSocialRelationsVer_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objSysSocialRelationsVerEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSocialRelationsVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSocialRelationsVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSocialRelationsVer_AddNewRecordWithReturnKeyAsync = SysSocialRelationsVer_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objSysSocialRelationsVerEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function SysSocialRelationsVer_AddNewRecordWithReturnKey(objSysSocialRelationsVerEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objSysSocialRelationsVerEN.socialVId === null || objSysSocialRelationsVerEN.socialVId === 0) {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSocialRelationsVer_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objSysSocialRelationsVerEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSocialRelationsVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSocialRelationsVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSocialRelationsVer_AddNewRecordWithReturnKey = SysSocialRelationsVer_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objSysSocialRelationsVerEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function SysSocialRelationsVer_UpdateRecordAsync(objSysSocialRelationsVerEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objSysSocialRelationsVerEN.sf_UpdFldSetStr === undefined || objSysSocialRelationsVerEN.sf_UpdFldSetStr === null || objSysSocialRelationsVerEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objSysSocialRelationsVerEN.socialVId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSocialRelationsVer_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objSysSocialRelationsVerEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSocialRelationsVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSocialRelationsVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSocialRelationsVer_UpdateRecordAsync = SysSocialRelationsVer_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objSysSocialRelationsVerEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function SysSocialRelationsVer_UpdateWithConditionAsync(objSysSocialRelationsVerEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objSysSocialRelationsVerEN.sf_UpdFldSetStr === undefined || objSysSocialRelationsVerEN.sf_UpdFldSetStr === null || objSysSocialRelationsVerEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objSysSocialRelationsVerEN.socialVId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSocialRelationsVer_Controller, strAction);
        objSysSocialRelationsVerEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objSysSocialRelationsVerEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSocialRelationsVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSocialRelationsVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSocialRelationsVer_UpdateWithConditionAsync = SysSocialRelationsVer_UpdateWithConditionAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function SysSocialRelationsVer_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSocialRelationsVer_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSocialRelationsVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSocialRelationsVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSocialRelationsVer_IsExistRecordAsync = SysSocialRelationsVer_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param lngSocialVId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function SysSocialRelationsVer_IsExist(lngSocialVId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSocialRelationsVer_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSocialRelationsVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSocialRelationsVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSocialRelationsVer_IsExist = SysSocialRelationsVer_IsExist;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param lngSocialVId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function SysSocialRelationsVer_IsExistAsync(lngSocialVId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSocialRelationsVer_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSocialRelationsVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSocialRelationsVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSocialRelationsVer_IsExistAsync = SysSocialRelationsVer_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function SysSocialRelationsVer_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSocialRelationsVer_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSocialRelationsVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSocialRelationsVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSocialRelationsVer_GetRecCountByCondAsync = SysSocialRelationsVer_GetRecCountByCondAsync;
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
    async function SysSocialRelationsVer_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSocialRelationsVer_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSocialRelationsVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSocialRelationsVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSocialRelationsVer_GetMaxStrIdByPrefix = SysSocialRelationsVer_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function SysSocialRelationsVer_GetWebApiUrl(strController, strAction) {
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
    exports.SysSocialRelationsVer_GetWebApiUrl = SysSocialRelationsVer_GetWebApiUrl;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function SysSocialRelationsVer_CheckPropertyNew(pobjSysSocialRelationsVerEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSocialRelationsVerEN.socialId) === true) {
            throw new Error("(errid:Watl000058)字段[社会Id]不能为空(In 社会关系版本表)!(clsSysSocialRelationsVerBL:CheckPropertyNew)");
        }
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSocialRelationsVerEN.socialId) == false && (0, clsString_js_2.GetStrLen)(pobjSysSocialRelationsVerEN.socialId) > 10) {
            throw new Error("(errid:Watl000059)字段[社会Id(socialId)]的长度不能超过10(In 社会关系版本表(SysSocialRelationsVer))!值:$(pobjSysSocialRelationsVerEN.socialId)(clsSysSocialRelationsVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSocialRelationsVerEN.fullName) == false && (0, clsString_js_2.GetStrLen)(pobjSysSocialRelationsVerEN.fullName) > 50) {
            throw new Error("(errid:Watl000059)字段[姓名(fullName)]的长度不能超过50(In 社会关系版本表(SysSocialRelationsVer))!值:$(pobjSysSocialRelationsVerEN.fullName)(clsSysSocialRelationsVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSocialRelationsVerEN.nationality) == false && (0, clsString_js_2.GetStrLen)(pobjSysSocialRelationsVerEN.nationality) > 50) {
            throw new Error("(errid:Watl000059)字段[国籍(nationality)]的长度不能超过50(In 社会关系版本表(SysSocialRelationsVer))!值:$(pobjSysSocialRelationsVerEN.nationality)(clsSysSocialRelationsVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSocialRelationsVerEN.workUnit) == false && (0, clsString_js_2.GetStrLen)(pobjSysSocialRelationsVerEN.workUnit) > 100) {
            throw new Error("(errid:Watl000059)字段[工作单位(workUnit)]的长度不能超过100(In 社会关系版本表(SysSocialRelationsVer))!值:$(pobjSysSocialRelationsVerEN.workUnit)(clsSysSocialRelationsVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSocialRelationsVerEN.major) == false && (0, clsString_js_2.GetStrLen)(pobjSysSocialRelationsVerEN.major) > 50) {
            throw new Error("(errid:Watl000059)字段[专业(major)]的长度不能超过50(In 社会关系版本表(SysSocialRelationsVer))!值:$(pobjSysSocialRelationsVerEN.major)(clsSysSocialRelationsVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSocialRelationsVerEN.achievement) == false && (0, clsString_js_2.GetStrLen)(pobjSysSocialRelationsVerEN.achievement) > 5000) {
            throw new Error("(errid:Watl000059)字段[成就(achievement)]的长度不能超过5000(In 社会关系版本表(SysSocialRelationsVer))!值:$(pobjSysSocialRelationsVerEN.achievement)(clsSysSocialRelationsVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSocialRelationsVerEN.levelId) == false && (0, clsString_js_2.GetStrLen)(pobjSysSocialRelationsVerEN.levelId) > 2) {
            throw new Error("(errid:Watl000059)字段[级别Id(levelId)]的长度不能超过2(In 社会关系版本表(SysSocialRelationsVer))!值:$(pobjSysSocialRelationsVerEN.levelId)(clsSysSocialRelationsVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSocialRelationsVerEN.updUser) == false && (0, clsString_js_2.GetStrLen)(pobjSysSocialRelationsVerEN.updUser) > 20) {
            throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 社会关系版本表(SysSocialRelationsVer))!值:$(pobjSysSocialRelationsVerEN.updUser)(clsSysSocialRelationsVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSocialRelationsVerEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjSysSocialRelationsVerEN.updDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 社会关系版本表(SysSocialRelationsVer))!值:$(pobjSysSocialRelationsVerEN.updDate)(clsSysSocialRelationsVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSocialRelationsVerEN.id_CurrEduCls) == false && (0, clsString_js_2.GetStrLen)(pobjSysSocialRelationsVerEN.id_CurrEduCls) > 8) {
            throw new Error("(errid:Watl000059)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 社会关系版本表(SysSocialRelationsVer))!值:$(pobjSysSocialRelationsVerEN.id_CurrEduCls)(clsSysSocialRelationsVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSocialRelationsVerEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjSysSocialRelationsVerEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 社会关系版本表(SysSocialRelationsVer))!值:$(pobjSysSocialRelationsVerEN.memo)(clsSysSocialRelationsVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSocialRelationsVerEN.citationId) == false && (0, clsString_js_2.GetStrLen)(pobjSysSocialRelationsVerEN.citationId) > 8) {
            throw new Error("(errid:Watl000059)字段[引用Id(citationId)]的长度不能超过8(In 社会关系版本表(SysSocialRelationsVer))!值:$(pobjSysSocialRelationsVerEN.citationId)(clsSysSocialRelationsVerBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if (null != pobjSysSocialRelationsVerEN.socialVId && undefined !== pobjSysSocialRelationsVerEN.socialVId && clsString_js_1.tzDataType.isNumber(pobjSysSocialRelationsVerEN.socialVId) === false) {
            throw new Error("(errid:Watl000060)字段[SocialVId(socialVId)]的值:[$(pobjSysSocialRelationsVerEN.socialVId)], 非法，应该为数值型(In 社会关系版本表(SysSocialRelationsVer))!(clsSysSocialRelationsVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSocialRelationsVerEN.socialId) == false && undefined !== pobjSysSocialRelationsVerEN.socialId && clsString_js_1.tzDataType.isString(pobjSysSocialRelationsVerEN.socialId) === false) {
            throw new Error("(errid:Watl000060)字段[社会Id(socialId)]的值:[$(pobjSysSocialRelationsVerEN.socialId)], 非法，应该为字符型(In 社会关系版本表(SysSocialRelationsVer))!(clsSysSocialRelationsVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSocialRelationsVerEN.fullName) == false && undefined !== pobjSysSocialRelationsVerEN.fullName && clsString_js_1.tzDataType.isString(pobjSysSocialRelationsVerEN.fullName) === false) {
            throw new Error("(errid:Watl000060)字段[姓名(fullName)]的值:[$(pobjSysSocialRelationsVerEN.fullName)], 非法，应该为字符型(In 社会关系版本表(SysSocialRelationsVer))!(clsSysSocialRelationsVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSocialRelationsVerEN.nationality) == false && undefined !== pobjSysSocialRelationsVerEN.nationality && clsString_js_1.tzDataType.isString(pobjSysSocialRelationsVerEN.nationality) === false) {
            throw new Error("(errid:Watl000060)字段[国籍(nationality)]的值:[$(pobjSysSocialRelationsVerEN.nationality)], 非法，应该为字符型(In 社会关系版本表(SysSocialRelationsVer))!(clsSysSocialRelationsVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSocialRelationsVerEN.workUnit) == false && undefined !== pobjSysSocialRelationsVerEN.workUnit && clsString_js_1.tzDataType.isString(pobjSysSocialRelationsVerEN.workUnit) === false) {
            throw new Error("(errid:Watl000060)字段[工作单位(workUnit)]的值:[$(pobjSysSocialRelationsVerEN.workUnit)], 非法，应该为字符型(In 社会关系版本表(SysSocialRelationsVer))!(clsSysSocialRelationsVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSocialRelationsVerEN.major) == false && undefined !== pobjSysSocialRelationsVerEN.major && clsString_js_1.tzDataType.isString(pobjSysSocialRelationsVerEN.major) === false) {
            throw new Error("(errid:Watl000060)字段[专业(major)]的值:[$(pobjSysSocialRelationsVerEN.major)], 非法，应该为字符型(In 社会关系版本表(SysSocialRelationsVer))!(clsSysSocialRelationsVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSocialRelationsVerEN.achievement) == false && undefined !== pobjSysSocialRelationsVerEN.achievement && clsString_js_1.tzDataType.isString(pobjSysSocialRelationsVerEN.achievement) === false) {
            throw new Error("(errid:Watl000060)字段[成就(achievement)]的值:[$(pobjSysSocialRelationsVerEN.achievement)], 非法，应该为字符型(In 社会关系版本表(SysSocialRelationsVer))!(clsSysSocialRelationsVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSocialRelationsVerEN.detailedDescription) == false && undefined !== pobjSysSocialRelationsVerEN.detailedDescription && clsString_js_1.tzDataType.isString(pobjSysSocialRelationsVerEN.detailedDescription) === false) {
            throw new Error("(errid:Watl000060)字段[详细说明(detailedDescription)]的值:[$(pobjSysSocialRelationsVerEN.detailedDescription)], 非法，应该为字符型(In 社会关系版本表(SysSocialRelationsVer))!(clsSysSocialRelationsVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSocialRelationsVerEN.levelId) == false && undefined !== pobjSysSocialRelationsVerEN.levelId && clsString_js_1.tzDataType.isString(pobjSysSocialRelationsVerEN.levelId) === false) {
            throw new Error("(errid:Watl000060)字段[级别Id(levelId)]的值:[$(pobjSysSocialRelationsVerEN.levelId)], 非法，应该为字符型(In 社会关系版本表(SysSocialRelationsVer))!(clsSysSocialRelationsVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSocialRelationsVerEN.updUser) == false && undefined !== pobjSysSocialRelationsVerEN.updUser && clsString_js_1.tzDataType.isString(pobjSysSocialRelationsVerEN.updUser) === false) {
            throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjSysSocialRelationsVerEN.updUser)], 非法，应该为字符型(In 社会关系版本表(SysSocialRelationsVer))!(clsSysSocialRelationsVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSocialRelationsVerEN.updDate) == false && undefined !== pobjSysSocialRelationsVerEN.updDate && clsString_js_1.tzDataType.isString(pobjSysSocialRelationsVerEN.updDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjSysSocialRelationsVerEN.updDate)], 非法，应该为字符型(In 社会关系版本表(SysSocialRelationsVer))!(clsSysSocialRelationsVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSocialRelationsVerEN.id_CurrEduCls) == false && undefined !== pobjSysSocialRelationsVerEN.id_CurrEduCls && clsString_js_1.tzDataType.isString(pobjSysSocialRelationsVerEN.id_CurrEduCls) === false) {
            throw new Error("(errid:Watl000060)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjSysSocialRelationsVerEN.id_CurrEduCls)], 非法，应该为字符型(In 社会关系版本表(SysSocialRelationsVer))!(clsSysSocialRelationsVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSocialRelationsVerEN.memo) == false && undefined !== pobjSysSocialRelationsVerEN.memo && clsString_js_1.tzDataType.isString(pobjSysSocialRelationsVerEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjSysSocialRelationsVerEN.memo)], 非法，应该为字符型(In 社会关系版本表(SysSocialRelationsVer))!(clsSysSocialRelationsVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSocialRelationsVerEN.citationId) == false && undefined !== pobjSysSocialRelationsVerEN.citationId && clsString_js_1.tzDataType.isString(pobjSysSocialRelationsVerEN.citationId) === false) {
            throw new Error("(errid:Watl000060)字段[引用Id(citationId)]的值:[$(pobjSysSocialRelationsVerEN.citationId)], 非法，应该为字符型(In 社会关系版本表(SysSocialRelationsVer))!(clsSysSocialRelationsVerBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjSysSocialRelationsVerEN.SetIsCheckProperty(true);
    }
    exports.SysSocialRelationsVer_CheckPropertyNew = SysSocialRelationsVer_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function SysSocialRelationsVer_CheckProperty4Update(pobjSysSocialRelationsVerEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSocialRelationsVerEN.socialId) == false && (0, clsString_js_2.GetStrLen)(pobjSysSocialRelationsVerEN.socialId) > 10) {
            throw new Error("(errid:Watl000062)字段[社会Id(socialId)]的长度不能超过10(In 社会关系版本表(SysSocialRelationsVer))!值:$(pobjSysSocialRelationsVerEN.socialId)(clsSysSocialRelationsVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSocialRelationsVerEN.fullName) == false && (0, clsString_js_2.GetStrLen)(pobjSysSocialRelationsVerEN.fullName) > 50) {
            throw new Error("(errid:Watl000062)字段[姓名(fullName)]的长度不能超过50(In 社会关系版本表(SysSocialRelationsVer))!值:$(pobjSysSocialRelationsVerEN.fullName)(clsSysSocialRelationsVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSocialRelationsVerEN.nationality) == false && (0, clsString_js_2.GetStrLen)(pobjSysSocialRelationsVerEN.nationality) > 50) {
            throw new Error("(errid:Watl000062)字段[国籍(nationality)]的长度不能超过50(In 社会关系版本表(SysSocialRelationsVer))!值:$(pobjSysSocialRelationsVerEN.nationality)(clsSysSocialRelationsVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSocialRelationsVerEN.workUnit) == false && (0, clsString_js_2.GetStrLen)(pobjSysSocialRelationsVerEN.workUnit) > 100) {
            throw new Error("(errid:Watl000062)字段[工作单位(workUnit)]的长度不能超过100(In 社会关系版本表(SysSocialRelationsVer))!值:$(pobjSysSocialRelationsVerEN.workUnit)(clsSysSocialRelationsVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSocialRelationsVerEN.major) == false && (0, clsString_js_2.GetStrLen)(pobjSysSocialRelationsVerEN.major) > 50) {
            throw new Error("(errid:Watl000062)字段[专业(major)]的长度不能超过50(In 社会关系版本表(SysSocialRelationsVer))!值:$(pobjSysSocialRelationsVerEN.major)(clsSysSocialRelationsVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSocialRelationsVerEN.achievement) == false && (0, clsString_js_2.GetStrLen)(pobjSysSocialRelationsVerEN.achievement) > 5000) {
            throw new Error("(errid:Watl000062)字段[成就(achievement)]的长度不能超过5000(In 社会关系版本表(SysSocialRelationsVer))!值:$(pobjSysSocialRelationsVerEN.achievement)(clsSysSocialRelationsVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSocialRelationsVerEN.levelId) == false && (0, clsString_js_2.GetStrLen)(pobjSysSocialRelationsVerEN.levelId) > 2) {
            throw new Error("(errid:Watl000062)字段[级别Id(levelId)]的长度不能超过2(In 社会关系版本表(SysSocialRelationsVer))!值:$(pobjSysSocialRelationsVerEN.levelId)(clsSysSocialRelationsVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSocialRelationsVerEN.updUser) == false && (0, clsString_js_2.GetStrLen)(pobjSysSocialRelationsVerEN.updUser) > 20) {
            throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 社会关系版本表(SysSocialRelationsVer))!值:$(pobjSysSocialRelationsVerEN.updUser)(clsSysSocialRelationsVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSocialRelationsVerEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjSysSocialRelationsVerEN.updDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 社会关系版本表(SysSocialRelationsVer))!值:$(pobjSysSocialRelationsVerEN.updDate)(clsSysSocialRelationsVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSocialRelationsVerEN.id_CurrEduCls) == false && (0, clsString_js_2.GetStrLen)(pobjSysSocialRelationsVerEN.id_CurrEduCls) > 8) {
            throw new Error("(errid:Watl000062)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 社会关系版本表(SysSocialRelationsVer))!值:$(pobjSysSocialRelationsVerEN.id_CurrEduCls)(clsSysSocialRelationsVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSocialRelationsVerEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjSysSocialRelationsVerEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 社会关系版本表(SysSocialRelationsVer))!值:$(pobjSysSocialRelationsVerEN.memo)(clsSysSocialRelationsVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSocialRelationsVerEN.citationId) == false && (0, clsString_js_2.GetStrLen)(pobjSysSocialRelationsVerEN.citationId) > 8) {
            throw new Error("(errid:Watl000062)字段[引用Id(citationId)]的长度不能超过8(In 社会关系版本表(SysSocialRelationsVer))!值:$(pobjSysSocialRelationsVerEN.citationId)(clsSysSocialRelationsVerBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if (null != pobjSysSocialRelationsVerEN.socialVId && undefined !== pobjSysSocialRelationsVerEN.socialVId && clsString_js_1.tzDataType.isNumber(pobjSysSocialRelationsVerEN.socialVId) === false) {
            throw new Error("(errid:Watl000063)字段[SocialVId(socialVId)]的值:[$(pobjSysSocialRelationsVerEN.socialVId)], 非法，应该为数值型(In 社会关系版本表(SysSocialRelationsVer))!(clsSysSocialRelationsVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSocialRelationsVerEN.socialId) == false && undefined !== pobjSysSocialRelationsVerEN.socialId && clsString_js_1.tzDataType.isString(pobjSysSocialRelationsVerEN.socialId) === false) {
            throw new Error("(errid:Watl000063)字段[社会Id(socialId)]的值:[$(pobjSysSocialRelationsVerEN.socialId)], 非法，应该为字符型(In 社会关系版本表(SysSocialRelationsVer))!(clsSysSocialRelationsVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSocialRelationsVerEN.fullName) == false && undefined !== pobjSysSocialRelationsVerEN.fullName && clsString_js_1.tzDataType.isString(pobjSysSocialRelationsVerEN.fullName) === false) {
            throw new Error("(errid:Watl000063)字段[姓名(fullName)]的值:[$(pobjSysSocialRelationsVerEN.fullName)], 非法，应该为字符型(In 社会关系版本表(SysSocialRelationsVer))!(clsSysSocialRelationsVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSocialRelationsVerEN.nationality) == false && undefined !== pobjSysSocialRelationsVerEN.nationality && clsString_js_1.tzDataType.isString(pobjSysSocialRelationsVerEN.nationality) === false) {
            throw new Error("(errid:Watl000063)字段[国籍(nationality)]的值:[$(pobjSysSocialRelationsVerEN.nationality)], 非法，应该为字符型(In 社会关系版本表(SysSocialRelationsVer))!(clsSysSocialRelationsVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSocialRelationsVerEN.workUnit) == false && undefined !== pobjSysSocialRelationsVerEN.workUnit && clsString_js_1.tzDataType.isString(pobjSysSocialRelationsVerEN.workUnit) === false) {
            throw new Error("(errid:Watl000063)字段[工作单位(workUnit)]的值:[$(pobjSysSocialRelationsVerEN.workUnit)], 非法，应该为字符型(In 社会关系版本表(SysSocialRelationsVer))!(clsSysSocialRelationsVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSocialRelationsVerEN.major) == false && undefined !== pobjSysSocialRelationsVerEN.major && clsString_js_1.tzDataType.isString(pobjSysSocialRelationsVerEN.major) === false) {
            throw new Error("(errid:Watl000063)字段[专业(major)]的值:[$(pobjSysSocialRelationsVerEN.major)], 非法，应该为字符型(In 社会关系版本表(SysSocialRelationsVer))!(clsSysSocialRelationsVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSocialRelationsVerEN.achievement) == false && undefined !== pobjSysSocialRelationsVerEN.achievement && clsString_js_1.tzDataType.isString(pobjSysSocialRelationsVerEN.achievement) === false) {
            throw new Error("(errid:Watl000063)字段[成就(achievement)]的值:[$(pobjSysSocialRelationsVerEN.achievement)], 非法，应该为字符型(In 社会关系版本表(SysSocialRelationsVer))!(clsSysSocialRelationsVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSocialRelationsVerEN.detailedDescription) == false && undefined !== pobjSysSocialRelationsVerEN.detailedDescription && clsString_js_1.tzDataType.isString(pobjSysSocialRelationsVerEN.detailedDescription) === false) {
            throw new Error("(errid:Watl000063)字段[详细说明(detailedDescription)]的值:[$(pobjSysSocialRelationsVerEN.detailedDescription)], 非法，应该为字符型(In 社会关系版本表(SysSocialRelationsVer))!(clsSysSocialRelationsVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSocialRelationsVerEN.levelId) == false && undefined !== pobjSysSocialRelationsVerEN.levelId && clsString_js_1.tzDataType.isString(pobjSysSocialRelationsVerEN.levelId) === false) {
            throw new Error("(errid:Watl000063)字段[级别Id(levelId)]的值:[$(pobjSysSocialRelationsVerEN.levelId)], 非法，应该为字符型(In 社会关系版本表(SysSocialRelationsVer))!(clsSysSocialRelationsVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSocialRelationsVerEN.updUser) == false && undefined !== pobjSysSocialRelationsVerEN.updUser && clsString_js_1.tzDataType.isString(pobjSysSocialRelationsVerEN.updUser) === false) {
            throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjSysSocialRelationsVerEN.updUser)], 非法，应该为字符型(In 社会关系版本表(SysSocialRelationsVer))!(clsSysSocialRelationsVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSocialRelationsVerEN.updDate) == false && undefined !== pobjSysSocialRelationsVerEN.updDate && clsString_js_1.tzDataType.isString(pobjSysSocialRelationsVerEN.updDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjSysSocialRelationsVerEN.updDate)], 非法，应该为字符型(In 社会关系版本表(SysSocialRelationsVer))!(clsSysSocialRelationsVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSocialRelationsVerEN.id_CurrEduCls) == false && undefined !== pobjSysSocialRelationsVerEN.id_CurrEduCls && clsString_js_1.tzDataType.isString(pobjSysSocialRelationsVerEN.id_CurrEduCls) === false) {
            throw new Error("(errid:Watl000063)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjSysSocialRelationsVerEN.id_CurrEduCls)], 非法，应该为字符型(In 社会关系版本表(SysSocialRelationsVer))!(clsSysSocialRelationsVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSocialRelationsVerEN.memo) == false && undefined !== pobjSysSocialRelationsVerEN.memo && clsString_js_1.tzDataType.isString(pobjSysSocialRelationsVerEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjSysSocialRelationsVerEN.memo)], 非法，应该为字符型(In 社会关系版本表(SysSocialRelationsVer))!(clsSysSocialRelationsVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysSocialRelationsVerEN.citationId) == false && undefined !== pobjSysSocialRelationsVerEN.citationId && clsString_js_1.tzDataType.isString(pobjSysSocialRelationsVerEN.citationId) === false) {
            throw new Error("(errid:Watl000063)字段[引用Id(citationId)]的值:[$(pobjSysSocialRelationsVerEN.citationId)], 非法，应该为字符型(In 社会关系版本表(SysSocialRelationsVer))!(clsSysSocialRelationsVerBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if (null === pobjSysSocialRelationsVerEN.socialVId
            || pobjSysSocialRelationsVerEN.socialVId != null && pobjSysSocialRelationsVerEN.socialVId.toString() === "") {
            throw new Error("(errid:Watl000064)字段[SocialVId]不能为空(In 社会关系版本表)!(clsSysSocialRelationsVerBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjSysSocialRelationsVerEN.SetIsCheckProperty(true);
    }
    exports.SysSocialRelationsVer_CheckProperty4Update = SysSocialRelationsVer_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function SysSocialRelationsVer_GetJSONStrByObj(pobjSysSocialRelationsVerEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjSysSocialRelationsVerEN.sf_UpdFldSetStr = pobjSysSocialRelationsVerEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjSysSocialRelationsVerEN);
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
    exports.SysSocialRelationsVer_GetJSONStrByObj = SysSocialRelationsVer_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function SysSocialRelationsVer_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrSysSocialRelationsVerObjLst = new Array();
        if (strJSON === "") {
            return arrSysSocialRelationsVerObjLst;
        }
        try {
            arrSysSocialRelationsVerObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrSysSocialRelationsVerObjLst;
        }
        return arrSysSocialRelationsVerObjLst;
    }
    exports.SysSocialRelationsVer_GetObjLstByJSONStr = SysSocialRelationsVer_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrSysSocialRelationsVerObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function SysSocialRelationsVer_GetObjLstByJSONObjLst(arrSysSocialRelationsVerObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrSysSocialRelationsVerObjLst = new Array();
        for (const objInFor of arrSysSocialRelationsVerObjLstS) {
            const obj1 = SysSocialRelationsVer_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrSysSocialRelationsVerObjLst.push(obj1);
        }
        return arrSysSocialRelationsVerObjLst;
    }
    exports.SysSocialRelationsVer_GetObjLstByJSONObjLst = SysSocialRelationsVer_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function SysSocialRelationsVer_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjSysSocialRelationsVerEN = new clsSysSocialRelationsVerEN_js_1.clsSysSocialRelationsVerEN();
        if (strJSON === "") {
            return pobjSysSocialRelationsVerEN;
        }
        try {
            pobjSysSocialRelationsVerEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjSysSocialRelationsVerEN;
        }
        return pobjSysSocialRelationsVerEN;
    }
    exports.SysSocialRelationsVer_GetObjByJSONStr = SysSocialRelationsVer_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function SysSocialRelationsVer_GetCombineCondition(objSysSocialRelationsVer_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objSysSocialRelationsVer_Cond.dicFldComparisonOp, clsSysSocialRelationsVerEN_js_1.clsSysSocialRelationsVerEN.con_SocialVId) == true) {
            const strComparisonOp_SocialVId = objSysSocialRelationsVer_Cond.dicFldComparisonOp[clsSysSocialRelationsVerEN_js_1.clsSysSocialRelationsVerEN.con_SocialVId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsSysSocialRelationsVerEN_js_1.clsSysSocialRelationsVerEN.con_SocialVId, objSysSocialRelationsVer_Cond.socialVId, strComparisonOp_SocialVId);
        }
        if (Object.prototype.hasOwnProperty.call(objSysSocialRelationsVer_Cond.dicFldComparisonOp, clsSysSocialRelationsVerEN_js_1.clsSysSocialRelationsVerEN.con_SocialId) == true) {
            const strComparisonOp_SocialId = objSysSocialRelationsVer_Cond.dicFldComparisonOp[clsSysSocialRelationsVerEN_js_1.clsSysSocialRelationsVerEN.con_SocialId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsSysSocialRelationsVerEN_js_1.clsSysSocialRelationsVerEN.con_SocialId, objSysSocialRelationsVer_Cond.socialId, strComparisonOp_SocialId);
        }
        if (Object.prototype.hasOwnProperty.call(objSysSocialRelationsVer_Cond.dicFldComparisonOp, clsSysSocialRelationsVerEN_js_1.clsSysSocialRelationsVerEN.con_FullName) == true) {
            const strComparisonOp_FullName = objSysSocialRelationsVer_Cond.dicFldComparisonOp[clsSysSocialRelationsVerEN_js_1.clsSysSocialRelationsVerEN.con_FullName];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsSysSocialRelationsVerEN_js_1.clsSysSocialRelationsVerEN.con_FullName, objSysSocialRelationsVer_Cond.fullName, strComparisonOp_FullName);
        }
        if (Object.prototype.hasOwnProperty.call(objSysSocialRelationsVer_Cond.dicFldComparisonOp, clsSysSocialRelationsVerEN_js_1.clsSysSocialRelationsVerEN.con_Nationality) == true) {
            const strComparisonOp_Nationality = objSysSocialRelationsVer_Cond.dicFldComparisonOp[clsSysSocialRelationsVerEN_js_1.clsSysSocialRelationsVerEN.con_Nationality];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsSysSocialRelationsVerEN_js_1.clsSysSocialRelationsVerEN.con_Nationality, objSysSocialRelationsVer_Cond.nationality, strComparisonOp_Nationality);
        }
        if (Object.prototype.hasOwnProperty.call(objSysSocialRelationsVer_Cond.dicFldComparisonOp, clsSysSocialRelationsVerEN_js_1.clsSysSocialRelationsVerEN.con_WorkUnit) == true) {
            const strComparisonOp_WorkUnit = objSysSocialRelationsVer_Cond.dicFldComparisonOp[clsSysSocialRelationsVerEN_js_1.clsSysSocialRelationsVerEN.con_WorkUnit];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsSysSocialRelationsVerEN_js_1.clsSysSocialRelationsVerEN.con_WorkUnit, objSysSocialRelationsVer_Cond.workUnit, strComparisonOp_WorkUnit);
        }
        if (Object.prototype.hasOwnProperty.call(objSysSocialRelationsVer_Cond.dicFldComparisonOp, clsSysSocialRelationsVerEN_js_1.clsSysSocialRelationsVerEN.con_Major) == true) {
            const strComparisonOp_Major = objSysSocialRelationsVer_Cond.dicFldComparisonOp[clsSysSocialRelationsVerEN_js_1.clsSysSocialRelationsVerEN.con_Major];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsSysSocialRelationsVerEN_js_1.clsSysSocialRelationsVerEN.con_Major, objSysSocialRelationsVer_Cond.major, strComparisonOp_Major);
        }
        if (Object.prototype.hasOwnProperty.call(objSysSocialRelationsVer_Cond.dicFldComparisonOp, clsSysSocialRelationsVerEN_js_1.clsSysSocialRelationsVerEN.con_Achievement) == true) {
            const strComparisonOp_Achievement = objSysSocialRelationsVer_Cond.dicFldComparisonOp[clsSysSocialRelationsVerEN_js_1.clsSysSocialRelationsVerEN.con_Achievement];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsSysSocialRelationsVerEN_js_1.clsSysSocialRelationsVerEN.con_Achievement, objSysSocialRelationsVer_Cond.achievement, strComparisonOp_Achievement);
        }
        //数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
        if (Object.prototype.hasOwnProperty.call(objSysSocialRelationsVer_Cond.dicFldComparisonOp, clsSysSocialRelationsVerEN_js_1.clsSysSocialRelationsVerEN.con_LevelId) == true) {
            const strComparisonOp_LevelId = objSysSocialRelationsVer_Cond.dicFldComparisonOp[clsSysSocialRelationsVerEN_js_1.clsSysSocialRelationsVerEN.con_LevelId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsSysSocialRelationsVerEN_js_1.clsSysSocialRelationsVerEN.con_LevelId, objSysSocialRelationsVer_Cond.levelId, strComparisonOp_LevelId);
        }
        if (Object.prototype.hasOwnProperty.call(objSysSocialRelationsVer_Cond.dicFldComparisonOp, clsSysSocialRelationsVerEN_js_1.clsSysSocialRelationsVerEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objSysSocialRelationsVer_Cond.dicFldComparisonOp[clsSysSocialRelationsVerEN_js_1.clsSysSocialRelationsVerEN.con_UpdUser];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsSysSocialRelationsVerEN_js_1.clsSysSocialRelationsVerEN.con_UpdUser, objSysSocialRelationsVer_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objSysSocialRelationsVer_Cond.dicFldComparisonOp, clsSysSocialRelationsVerEN_js_1.clsSysSocialRelationsVerEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objSysSocialRelationsVer_Cond.dicFldComparisonOp[clsSysSocialRelationsVerEN_js_1.clsSysSocialRelationsVerEN.con_UpdDate];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsSysSocialRelationsVerEN_js_1.clsSysSocialRelationsVerEN.con_UpdDate, objSysSocialRelationsVer_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objSysSocialRelationsVer_Cond.dicFldComparisonOp, clsSysSocialRelationsVerEN_js_1.clsSysSocialRelationsVerEN.con_id_CurrEduCls) == true) {
            const strComparisonOp_id_CurrEduCls = objSysSocialRelationsVer_Cond.dicFldComparisonOp[clsSysSocialRelationsVerEN_js_1.clsSysSocialRelationsVerEN.con_id_CurrEduCls];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsSysSocialRelationsVerEN_js_1.clsSysSocialRelationsVerEN.con_id_CurrEduCls, objSysSocialRelationsVer_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
        }
        if (Object.prototype.hasOwnProperty.call(objSysSocialRelationsVer_Cond.dicFldComparisonOp, clsSysSocialRelationsVerEN_js_1.clsSysSocialRelationsVerEN.con_Memo) == true) {
            const strComparisonOp_Memo = objSysSocialRelationsVer_Cond.dicFldComparisonOp[clsSysSocialRelationsVerEN_js_1.clsSysSocialRelationsVerEN.con_Memo];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsSysSocialRelationsVerEN_js_1.clsSysSocialRelationsVerEN.con_Memo, objSysSocialRelationsVer_Cond.memo, strComparisonOp_Memo);
        }
        if (Object.prototype.hasOwnProperty.call(objSysSocialRelationsVer_Cond.dicFldComparisonOp, clsSysSocialRelationsVerEN_js_1.clsSysSocialRelationsVerEN.con_CitationId) == true) {
            const strComparisonOp_CitationId = objSysSocialRelationsVer_Cond.dicFldComparisonOp[clsSysSocialRelationsVerEN_js_1.clsSysSocialRelationsVerEN.con_CitationId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsSysSocialRelationsVerEN_js_1.clsSysSocialRelationsVerEN.con_CitationId, objSysSocialRelationsVer_Cond.citationId, strComparisonOp_CitationId);
        }
        return strWhereCond;
    }
    exports.SysSocialRelationsVer_GetCombineCondition = SysSocialRelationsVer_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--SysSocialRelationsVer(社会关系版本表),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @returns 条件串(strWhereCond)
    **/
    function SysSocialRelationsVer_GetUniCondStr_SocialVId(objSysSocialRelationsVerEN) {
        let strWhereCond = " 1 = 1 ";
        return strWhereCond;
    }
    exports.SysSocialRelationsVer_GetUniCondStr_SocialVId = SysSocialRelationsVer_GetUniCondStr_SocialVId;
    /**
    *获取唯一性条件串(Uniqueness)--SysSocialRelationsVer(社会关系版本表),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @returns 条件串(strWhereCond)
    **/
    function SysSocialRelationsVer_GetUniCondStr4Update_SocialVId(objSysSocialRelationsVerEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and SocialVId <> '{0}'", objSysSocialRelationsVerEN.socialVId);
        return strWhereCond;
    }
    exports.SysSocialRelationsVer_GetUniCondStr4Update_SocialVId = SysSocialRelationsVer_GetUniCondStr4Update_SocialVId;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objSysSocialRelationsVerENS:源对象
     * @param objSysSocialRelationsVerENT:目标对象
    */
    function SysSocialRelationsVer_CopyObjTo(objSysSocialRelationsVerENS, objSysSocialRelationsVerENT) {
        objSysSocialRelationsVerENT.socialVId = objSysSocialRelationsVerENS.socialVId; //SocialVId
        objSysSocialRelationsVerENT.socialId = objSysSocialRelationsVerENS.socialId; //社会Id
        objSysSocialRelationsVerENT.fullName = objSysSocialRelationsVerENS.fullName; //姓名
        objSysSocialRelationsVerENT.nationality = objSysSocialRelationsVerENS.nationality; //国籍
        objSysSocialRelationsVerENT.workUnit = objSysSocialRelationsVerENS.workUnit; //工作单位
        objSysSocialRelationsVerENT.major = objSysSocialRelationsVerENS.major; //专业
        objSysSocialRelationsVerENT.achievement = objSysSocialRelationsVerENS.achievement; //成就
        objSysSocialRelationsVerENT.detailedDescription = objSysSocialRelationsVerENS.detailedDescription; //详细说明
        objSysSocialRelationsVerENT.levelId = objSysSocialRelationsVerENS.levelId; //级别Id
        objSysSocialRelationsVerENT.updUser = objSysSocialRelationsVerENS.updUser; //修改人
        objSysSocialRelationsVerENT.updDate = objSysSocialRelationsVerENS.updDate; //修改日期
        objSysSocialRelationsVerENT.id_CurrEduCls = objSysSocialRelationsVerENS.id_CurrEduCls; //教学班流水号
        objSysSocialRelationsVerENT.memo = objSysSocialRelationsVerENS.memo; //备注
        objSysSocialRelationsVerENT.citationId = objSysSocialRelationsVerENS.citationId; //引用Id
        objSysSocialRelationsVerENT.sf_UpdFldSetStr = objSysSocialRelationsVerENS.updFldString; //sf_UpdFldSetStr
    }
    exports.SysSocialRelationsVer_CopyObjTo = SysSocialRelationsVer_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objSysSocialRelationsVerENS:源对象
     * @param objSysSocialRelationsVerENT:目标对象
    */
    function SysSocialRelationsVer_GetObjFromJsonObj(objSysSocialRelationsVerENS) {
        const objSysSocialRelationsVerENT = new clsSysSocialRelationsVerEN_js_1.clsSysSocialRelationsVerEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objSysSocialRelationsVerENT, objSysSocialRelationsVerENS);
        return objSysSocialRelationsVerENT;
    }
    exports.SysSocialRelationsVer_GetObjFromJsonObj = SysSocialRelationsVer_GetObjFromJsonObj;
});
