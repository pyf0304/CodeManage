/**
* 类名:clsvViewpointCitationWApi
* 表名:vViewpointCitation(01120594)
* 生成代码版本:2022.11.02.1
* 生成日期:2022/11/02 11:46:48
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
        define(["require", "exports", "axios", "../../L0_Entity/GraduateEduTopic/clsvViewpointCitationEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsSysPara4WebApi.js", "../../PubFun/jsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.vViewpointCitation_GetObjFromJsonObj = exports.vViewpointCitation_CopyObjTo = exports.vViewpointCitation_GetUniCondStr4Update_mId_PaperId_ViewpointId = exports.vViewpointCitation_GetUniCondStr_mId_PaperId_ViewpointId = exports.vViewpointCitation_GetCombineCondition = exports.vViewpointCitation_GetObjByJSONStr = exports.vViewpointCitation_GetObjLstByJSONObjLst = exports.vViewpointCitation_GetObjLstByJSONStr = exports.vViewpointCitation_GetJSONStrByObj = exports.vViewpointCitation_CheckProperty4Update = exports.vViewpointCitation_CheckPropertyNew = exports.vViewpointCitation_GetWebApiUrl = exports.vViewpointCitation_GetMaxStrIdByPrefix = exports.vViewpointCitation_GetRecCountByCondAsync = exports.vViewpointCitation_IsExistAsync = exports.vViewpointCitation_IsExist = exports.vViewpointCitation_IsExistRecordAsync = exports.vViewpointCitation_UpdateWithConditionAsync = exports.vViewpointCitation_UpdateRecordAsync = exports.vViewpointCitation_AddNewRecordWithReturnKey = exports.vViewpointCitation_AddNewRecordWithReturnKeyAsync = exports.vViewpointCitation_AddNewRecordAsync = exports.vViewpointCitation_DelvViewpointCitationsByCondAsync = exports.vViewpointCitation_DelvViewpointCitationsAsync = exports.vViewpointCitation_DelRecordAsync = exports.vViewpointCitation_GetObjLstByPagerAsync = exports.vViewpointCitation_GetObjLstByRange = exports.vViewpointCitation_GetObjLstByRangeAsync = exports.vViewpointCitation_GetTopObjLstAsync = exports.vViewpointCitation_GetObjLstBymIdLstAsync = exports.vViewpointCitation_GetObjLstAsync = exports.vViewpointCitation_GetFirstObjAsync = exports.vViewpointCitation_GetFirstID = exports.vViewpointCitation_GetFirstIDAsync = exports.vViewpointCitation_FilterFunByKey = exports.vViewpointCitation_SortFunByKey = exports.vViewpointCitation_SortFun_Defa_2Fld = exports.vViewpointCitation_SortFun_Defa = exports.vViewpointCitation_GetObjBymIdAsync = exports.vViewpointCitation_ConstructorName = exports.vViewpointCitation_Controller = void 0;
    /**
     * v观点引用(vViewpointCitation)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2022年11月02日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const clsvViewpointCitationEN_js_1 = require("../../L0_Entity/GraduateEduTopic/clsvViewpointCitationEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    const jsString_js_1 = require("../../PubFun/jsString.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.vViewpointCitation_Controller = "vViewpointCitationApi";
    exports.vViewpointCitation_ConstructorName = "vViewpointCitation";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param lngmId:关键字
    * @returns 对象
    **/
    async function vViewpointCitation_GetObjBymIdAsync(lngmId) {
        const strThisFuncName = "GetObjBymIdAsync";
        if (lngmId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngmId]不能为空！(In GetObjBymIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjBymId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vViewpointCitation_Controller, strAction);
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
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vViewpointCitation_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objvViewpointCitation = vViewpointCitation_GetObjFromJsonObj(returnObj);
                return objvViewpointCitation;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vViewpointCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vViewpointCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vViewpointCitation_GetObjBymIdAsync = vViewpointCitation_GetObjBymIdAsync;
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
    function vViewpointCitation_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.mId - b.mId;
    }
    exports.vViewpointCitation_SortFun_Defa = vViewpointCitation_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vViewpointCitation_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.memo == b.memo)
            return a.paperContent.localeCompare(b.paperContent);
        else
            return a.memo.localeCompare(b.memo);
    }
    exports.vViewpointCitation_SortFun_Defa_2Fld = vViewpointCitation_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vViewpointCitation_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsvViewpointCitationEN_js_1.clsvViewpointCitationEN.con_Memo:
                    return (a, b) => {
                        return a.memo.localeCompare(b.memo);
                    };
                case clsvViewpointCitationEN_js_1.clsvViewpointCitationEN.con_mId:
                    return (a, b) => {
                        return a.mId - b.mId;
                    };
                case clsvViewpointCitationEN_js_1.clsvViewpointCitationEN.con_PaperContent:
                    return (a, b) => {
                        return a.paperContent.localeCompare(b.paperContent);
                    };
                case clsvViewpointCitationEN_js_1.clsvViewpointCitationEN.con_PaperId:
                    return (a, b) => {
                        return a.paperId.localeCompare(b.paperId);
                    };
                case clsvViewpointCitationEN_js_1.clsvViewpointCitationEN.con_PaperTitle:
                    return (a, b) => {
                        return a.paperTitle.localeCompare(b.paperTitle);
                    };
                case clsvViewpointCitationEN_js_1.clsvViewpointCitationEN.con_Reason:
                    return (a, b) => {
                        return a.reason.localeCompare(b.reason);
                    };
                case clsvViewpointCitationEN_js_1.clsvViewpointCitationEN.con_UpdUserId:
                    return (a, b) => {
                        return a.updUserId.localeCompare(b.updUserId);
                    };
                case clsvViewpointCitationEN_js_1.clsvViewpointCitationEN.con_UserName:
                    return (a, b) => {
                        return a.userName.localeCompare(b.userName);
                    };
                case clsvViewpointCitationEN_js_1.clsvViewpointCitationEN.con_ViewpointId:
                    return (a, b) => {
                        return a.viewpointId.localeCompare(b.viewpointId);
                    };
                case clsvViewpointCitationEN_js_1.clsvViewpointCitationEN.con_ViewpointName:
                    return (a, b) => {
                        return a.viewpointName.localeCompare(b.viewpointName);
                    };
                case clsvViewpointCitationEN_js_1.clsvViewpointCitationEN.con_ViewpointTypeId:
                    return (a, b) => {
                        return a.viewpointTypeId.localeCompare(b.viewpointTypeId);
                    };
                case clsvViewpointCitationEN_js_1.clsvViewpointCitationEN.con_ViewpointTypeName:
                    return (a, b) => {
                        return a.viewpointTypeName.localeCompare(b.viewpointTypeName);
                    };
                case clsvViewpointCitationEN_js_1.clsvViewpointCitationEN.con_UpdDate:
                    return (a, b) => {
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsvViewpointCitationEN_js_1.clsvViewpointCitationEN.con_ProposePeople:
                    return (a, b) => {
                        return a.proposePeople.localeCompare(b.proposePeople);
                    };
                case clsvViewpointCitationEN_js_1.clsvViewpointCitationEN.con_Source:
                    return (a, b) => {
                        return a.source.localeCompare(b.source);
                    };
                case clsvViewpointCitationEN_js_1.clsvViewpointCitationEN.con_TopicId:
                    return (a, b) => {
                        return a.topicId.localeCompare(b.topicId);
                    };
                case clsvViewpointCitationEN_js_1.clsvViewpointCitationEN.con_TopicName:
                    return (a, b) => {
                        return a.topicName.localeCompare(b.topicName);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vViewpointCitation]中不存在！(in ${exports.vViewpointCitation_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsvViewpointCitationEN_js_1.clsvViewpointCitationEN.con_Memo:
                    return (a, b) => {
                        return b.memo.localeCompare(a.memo);
                    };
                case clsvViewpointCitationEN_js_1.clsvViewpointCitationEN.con_mId:
                    return (a, b) => {
                        return b.mId - a.mId;
                    };
                case clsvViewpointCitationEN_js_1.clsvViewpointCitationEN.con_PaperContent:
                    return (a, b) => {
                        return b.paperContent.localeCompare(a.paperContent);
                    };
                case clsvViewpointCitationEN_js_1.clsvViewpointCitationEN.con_PaperId:
                    return (a, b) => {
                        return b.paperId.localeCompare(a.paperId);
                    };
                case clsvViewpointCitationEN_js_1.clsvViewpointCitationEN.con_PaperTitle:
                    return (a, b) => {
                        return b.paperTitle.localeCompare(a.paperTitle);
                    };
                case clsvViewpointCitationEN_js_1.clsvViewpointCitationEN.con_Reason:
                    return (a, b) => {
                        return b.reason.localeCompare(a.reason);
                    };
                case clsvViewpointCitationEN_js_1.clsvViewpointCitationEN.con_UpdUserId:
                    return (a, b) => {
                        return b.updUserId.localeCompare(a.updUserId);
                    };
                case clsvViewpointCitationEN_js_1.clsvViewpointCitationEN.con_UserName:
                    return (a, b) => {
                        return b.userName.localeCompare(a.userName);
                    };
                case clsvViewpointCitationEN_js_1.clsvViewpointCitationEN.con_ViewpointId:
                    return (a, b) => {
                        return b.viewpointId.localeCompare(a.viewpointId);
                    };
                case clsvViewpointCitationEN_js_1.clsvViewpointCitationEN.con_ViewpointName:
                    return (a, b) => {
                        return b.viewpointName.localeCompare(a.viewpointName);
                    };
                case clsvViewpointCitationEN_js_1.clsvViewpointCitationEN.con_ViewpointTypeId:
                    return (a, b) => {
                        return b.viewpointTypeId.localeCompare(a.viewpointTypeId);
                    };
                case clsvViewpointCitationEN_js_1.clsvViewpointCitationEN.con_ViewpointTypeName:
                    return (a, b) => {
                        return b.viewpointTypeName.localeCompare(a.viewpointTypeName);
                    };
                case clsvViewpointCitationEN_js_1.clsvViewpointCitationEN.con_UpdDate:
                    return (a, b) => {
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsvViewpointCitationEN_js_1.clsvViewpointCitationEN.con_ProposePeople:
                    return (a, b) => {
                        return b.proposePeople.localeCompare(a.proposePeople);
                    };
                case clsvViewpointCitationEN_js_1.clsvViewpointCitationEN.con_Source:
                    return (a, b) => {
                        return b.source.localeCompare(a.source);
                    };
                case clsvViewpointCitationEN_js_1.clsvViewpointCitationEN.con_TopicId:
                    return (a, b) => {
                        return b.topicId.localeCompare(a.topicId);
                    };
                case clsvViewpointCitationEN_js_1.clsvViewpointCitationEN.con_TopicName:
                    return (a, b) => {
                        return b.topicName.localeCompare(a.topicName);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vViewpointCitation]中不存在！(in ${exports.vViewpointCitation_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.vViewpointCitation_SortFunByKey = vViewpointCitation_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function vViewpointCitation_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsvViewpointCitationEN_js_1.clsvViewpointCitationEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            case clsvViewpointCitationEN_js_1.clsvViewpointCitationEN.con_mId:
                return (obj) => {
                    return obj.mId === value;
                };
            case clsvViewpointCitationEN_js_1.clsvViewpointCitationEN.con_PaperContent:
                return (obj) => {
                    return obj.paperContent === value;
                };
            case clsvViewpointCitationEN_js_1.clsvViewpointCitationEN.con_PaperId:
                return (obj) => {
                    return obj.paperId === value;
                };
            case clsvViewpointCitationEN_js_1.clsvViewpointCitationEN.con_PaperTitle:
                return (obj) => {
                    return obj.paperTitle === value;
                };
            case clsvViewpointCitationEN_js_1.clsvViewpointCitationEN.con_Reason:
                return (obj) => {
                    return obj.reason === value;
                };
            case clsvViewpointCitationEN_js_1.clsvViewpointCitationEN.con_UpdUserId:
                return (obj) => {
                    return obj.updUserId === value;
                };
            case clsvViewpointCitationEN_js_1.clsvViewpointCitationEN.con_UserName:
                return (obj) => {
                    return obj.userName === value;
                };
            case clsvViewpointCitationEN_js_1.clsvViewpointCitationEN.con_ViewpointId:
                return (obj) => {
                    return obj.viewpointId === value;
                };
            case clsvViewpointCitationEN_js_1.clsvViewpointCitationEN.con_ViewpointName:
                return (obj) => {
                    return obj.viewpointName === value;
                };
            case clsvViewpointCitationEN_js_1.clsvViewpointCitationEN.con_ViewpointTypeId:
                return (obj) => {
                    return obj.viewpointTypeId === value;
                };
            case clsvViewpointCitationEN_js_1.clsvViewpointCitationEN.con_ViewpointTypeName:
                return (obj) => {
                    return obj.viewpointTypeName === value;
                };
            case clsvViewpointCitationEN_js_1.clsvViewpointCitationEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsvViewpointCitationEN_js_1.clsvViewpointCitationEN.con_ProposePeople:
                return (obj) => {
                    return obj.proposePeople === value;
                };
            case clsvViewpointCitationEN_js_1.clsvViewpointCitationEN.con_Source:
                return (obj) => {
                    return obj.source === value;
                };
            case clsvViewpointCitationEN_js_1.clsvViewpointCitationEN.con_TopicId:
                return (obj) => {
                    return obj.topicId === value;
                };
            case clsvViewpointCitationEN_js_1.clsvViewpointCitationEN.con_TopicName:
                return (obj) => {
                    return obj.topicName === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[vViewpointCitation]中不存在！(in ${exports.vViewpointCitation_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.vViewpointCitation_FilterFunByKey = vViewpointCitation_FilterFunByKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function vViewpointCitation_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vViewpointCitation_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vViewpointCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vViewpointCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vViewpointCitation_GetFirstIDAsync = vViewpointCitation_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function vViewpointCitation_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vViewpointCitation_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vViewpointCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vViewpointCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vViewpointCitation_GetFirstID = vViewpointCitation_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function vViewpointCitation_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vViewpointCitation_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vViewpointCitation_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objvViewpointCitation = vViewpointCitation_GetObjFromJsonObj(returnObj);
                return objvViewpointCitation;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vViewpointCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vViewpointCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vViewpointCitation_GetFirstObjAsync = vViewpointCitation_GetFirstObjAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function vViewpointCitation_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vViewpointCitation_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vViewpointCitation_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vViewpointCitation_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vViewpointCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vViewpointCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vViewpointCitation_GetObjLstAsync = vViewpointCitation_GetObjLstAsync;
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
    async function vViewpointCitation_GetObjLstBymIdLstAsync(arrmId) {
        const strThisFuncName = "GetObjLstBymIdLstAsync";
        const strAction = "GetObjLstBymIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vViewpointCitation_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrmId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vViewpointCitation_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vViewpointCitation_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vViewpointCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vViewpointCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vViewpointCitation_GetObjLstBymIdLstAsync = vViewpointCitation_GetObjLstBymIdLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function vViewpointCitation_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vViewpointCitation_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vViewpointCitation_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vViewpointCitation_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vViewpointCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vViewpointCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vViewpointCitation_GetTopObjLstAsync = vViewpointCitation_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vViewpointCitation_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vViewpointCitation_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vViewpointCitation_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vViewpointCitation_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vViewpointCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vViewpointCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vViewpointCitation_GetObjLstByRangeAsync = vViewpointCitation_GetObjLstByRangeAsync;
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
    async function vViewpointCitation_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vViewpointCitation_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vViewpointCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vViewpointCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vViewpointCitation_GetObjLstByRange = vViewpointCitation_GetObjLstByRange;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vViewpointCitation_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vViewpointCitation_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vViewpointCitation_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vViewpointCitation_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vViewpointCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vViewpointCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vViewpointCitation_GetObjLstByPagerAsync = vViewpointCitation_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param lngmId:关键字
    * @returns 获取删除的结果
    **/
    async function vViewpointCitation_DelRecordAsync(lngmId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vViewpointCitation_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vViewpointCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vViewpointCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vViewpointCitation_DelRecordAsync = vViewpointCitation_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrmId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function vViewpointCitation_DelvViewpointCitationsAsync(arrmId) {
        const strThisFuncName = "DelvViewpointCitationsAsync";
        const strAction = "DelvViewpointCitations";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vViewpointCitation_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vViewpointCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vViewpointCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vViewpointCitation_DelvViewpointCitationsAsync = vViewpointCitation_DelvViewpointCitationsAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function vViewpointCitation_DelvViewpointCitationsByCondAsync(strWhereCond) {
        const strThisFuncName = "DelvViewpointCitationsByCondAsync";
        const strAction = "DelvViewpointCitationsByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vViewpointCitation_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vViewpointCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vViewpointCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vViewpointCitation_DelvViewpointCitationsByCondAsync = vViewpointCitation_DelvViewpointCitationsByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objvViewpointCitationEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function vViewpointCitation_AddNewRecordAsync(objvViewpointCitationEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objvViewpointCitationEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vViewpointCitation_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objvViewpointCitationEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vViewpointCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vViewpointCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vViewpointCitation_AddNewRecordAsync = vViewpointCitation_AddNewRecordAsync;
    /* 数据类型不是字符型，不可以最大关键字的方式添加记录。*/
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objvViewpointCitationEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function vViewpointCitation_AddNewRecordWithReturnKeyAsync(objvViewpointCitationEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vViewpointCitation_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objvViewpointCitationEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vViewpointCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vViewpointCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vViewpointCitation_AddNewRecordWithReturnKeyAsync = vViewpointCitation_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objvViewpointCitationEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function vViewpointCitation_AddNewRecordWithReturnKey(objvViewpointCitationEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objvViewpointCitationEN.mId === null || objvViewpointCitationEN.mId === 0) {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vViewpointCitation_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objvViewpointCitationEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vViewpointCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vViewpointCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vViewpointCitation_AddNewRecordWithReturnKey = vViewpointCitation_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objvViewpointCitationEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function vViewpointCitation_UpdateRecordAsync(objvViewpointCitationEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objvViewpointCitationEN.sf_UpdFldSetStr === undefined || objvViewpointCitationEN.sf_UpdFldSetStr === null || objvViewpointCitationEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objvViewpointCitationEN.mId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vViewpointCitation_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objvViewpointCitationEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vViewpointCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vViewpointCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vViewpointCitation_UpdateRecordAsync = vViewpointCitation_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objvViewpointCitationEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function vViewpointCitation_UpdateWithConditionAsync(objvViewpointCitationEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objvViewpointCitationEN.sf_UpdFldSetStr === undefined || objvViewpointCitationEN.sf_UpdFldSetStr === null || objvViewpointCitationEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objvViewpointCitationEN.mId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vViewpointCitation_Controller, strAction);
        objvViewpointCitationEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objvViewpointCitationEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vViewpointCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vViewpointCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vViewpointCitation_UpdateWithConditionAsync = vViewpointCitation_UpdateWithConditionAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function vViewpointCitation_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vViewpointCitation_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vViewpointCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vViewpointCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vViewpointCitation_IsExistRecordAsync = vViewpointCitation_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param lngmId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function vViewpointCitation_IsExist(lngmId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vViewpointCitation_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vViewpointCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vViewpointCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vViewpointCitation_IsExist = vViewpointCitation_IsExist;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param lngmId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function vViewpointCitation_IsExistAsync(lngmId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vViewpointCitation_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vViewpointCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vViewpointCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vViewpointCitation_IsExistAsync = vViewpointCitation_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function vViewpointCitation_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vViewpointCitation_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vViewpointCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vViewpointCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vViewpointCitation_GetRecCountByCondAsync = vViewpointCitation_GetRecCountByCondAsync;
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
    async function vViewpointCitation_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vViewpointCitation_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vViewpointCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vViewpointCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vViewpointCitation_GetMaxStrIdByPrefix = vViewpointCitation_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function vViewpointCitation_GetWebApiUrl(strController, strAction) {
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
    exports.vViewpointCitation_GetWebApiUrl = vViewpointCitation_GetWebApiUrl;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function vViewpointCitation_CheckPropertyNew(pobjvViewpointCitationEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjvViewpointCitationEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjvViewpointCitationEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In v观点引用(vViewpointCitation))!值:$(pobjvViewpointCitationEN.memo)(clsvViewpointCitationBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjvViewpointCitationEN.paperId) == false && (0, clsString_js_1.GetStrLen)(pobjvViewpointCitationEN.paperId) > 8) {
            throw new Error("(errid:Watl000059)字段[论文Id(paperId)]的长度不能超过8(In v观点引用(vViewpointCitation))!值:$(pobjvViewpointCitationEN.paperId)(clsvViewpointCitationBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjvViewpointCitationEN.paperTitle) == false && (0, clsString_js_1.GetStrLen)(pobjvViewpointCitationEN.paperTitle) > 500) {
            throw new Error("(errid:Watl000059)字段[论文标题(paperTitle)]的长度不能超过500(In v观点引用(vViewpointCitation))!值:$(pobjvViewpointCitationEN.paperTitle)(clsvViewpointCitationBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjvViewpointCitationEN.updUserId) == false && (0, clsString_js_1.GetStrLen)(pobjvViewpointCitationEN.updUserId) > 20) {
            throw new Error("(errid:Watl000059)字段[修改用户Id(updUserId)]的长度不能超过20(In v观点引用(vViewpointCitation))!值:$(pobjvViewpointCitationEN.updUserId)(clsvViewpointCitationBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjvViewpointCitationEN.userName) == false && (0, clsString_js_1.GetStrLen)(pobjvViewpointCitationEN.userName) > 50) {
            throw new Error("(errid:Watl000059)字段[用户名(userName)]的长度不能超过50(In v观点引用(vViewpointCitation))!值:$(pobjvViewpointCitationEN.userName)(clsvViewpointCitationBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjvViewpointCitationEN.viewpointId) == false && (0, clsString_js_1.GetStrLen)(pobjvViewpointCitationEN.viewpointId) > 8) {
            throw new Error("(errid:Watl000059)字段[观点Id(viewpointId)]的长度不能超过8(In v观点引用(vViewpointCitation))!值:$(pobjvViewpointCitationEN.viewpointId)(clsvViewpointCitationBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjvViewpointCitationEN.viewpointName) == false && (0, clsString_js_1.GetStrLen)(pobjvViewpointCitationEN.viewpointName) > 500) {
            throw new Error("(errid:Watl000059)字段[观点名称(viewpointName)]的长度不能超过500(In v观点引用(vViewpointCitation))!值:$(pobjvViewpointCitationEN.viewpointName)(clsvViewpointCitationBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjvViewpointCitationEN.viewpointTypeId) == false && (0, clsString_js_1.GetStrLen)(pobjvViewpointCitationEN.viewpointTypeId) > 4) {
            throw new Error("(errid:Watl000059)字段[观点类型Id(viewpointTypeId)]的长度不能超过4(In v观点引用(vViewpointCitation))!值:$(pobjvViewpointCitationEN.viewpointTypeId)(clsvViewpointCitationBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjvViewpointCitationEN.viewpointTypeName) == false && (0, clsString_js_1.GetStrLen)(pobjvViewpointCitationEN.viewpointTypeName) > 50) {
            throw new Error("(errid:Watl000059)字段[观点类型名(viewpointTypeName)]的长度不能超过50(In v观点引用(vViewpointCitation))!值:$(pobjvViewpointCitationEN.viewpointTypeName)(clsvViewpointCitationBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjvViewpointCitationEN.updDate) == false && (0, clsString_js_1.GetStrLen)(pobjvViewpointCitationEN.updDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In v观点引用(vViewpointCitation))!值:$(pobjvViewpointCitationEN.updDate)(clsvViewpointCitationBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjvViewpointCitationEN.proposePeople) == false && (0, clsString_js_1.GetStrLen)(pobjvViewpointCitationEN.proposePeople) > 50) {
            throw new Error("(errid:Watl000059)字段[提出人(proposePeople)]的长度不能超过50(In v观点引用(vViewpointCitation))!值:$(pobjvViewpointCitationEN.proposePeople)(clsvViewpointCitationBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjvViewpointCitationEN.source) == false && (0, clsString_js_1.GetStrLen)(pobjvViewpointCitationEN.source) > 500) {
            throw new Error("(errid:Watl000059)字段[来源(source)]的长度不能超过500(In v观点引用(vViewpointCitation))!值:$(pobjvViewpointCitationEN.source)(clsvViewpointCitationBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjvViewpointCitationEN.topicId) == false && (0, clsString_js_1.GetStrLen)(pobjvViewpointCitationEN.topicId) > 8) {
            throw new Error("(errid:Watl000059)字段[主题Id(topicId)]的长度不能超过8(In v观点引用(vViewpointCitation))!值:$(pobjvViewpointCitationEN.topicId)(clsvViewpointCitationBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjvViewpointCitationEN.topicName) == false && (0, clsString_js_1.GetStrLen)(pobjvViewpointCitationEN.topicName) > 200) {
            throw new Error("(errid:Watl000059)字段[栏目主题(topicName)]的长度不能超过200(In v观点引用(vViewpointCitation))!值:$(pobjvViewpointCitationEN.topicName)(clsvViewpointCitationBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjvViewpointCitationEN.memo) == false && undefined !== pobjvViewpointCitationEN.memo && jsString_js_1.tzDataType.isString(pobjvViewpointCitationEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjvViewpointCitationEN.memo)], 非法，应该为字符型(In v观点引用(vViewpointCitation))!(clsvViewpointCitationBL:CheckPropertyNew)");
        }
        if (null != pobjvViewpointCitationEN.mId && undefined !== pobjvViewpointCitationEN.mId && jsString_js_1.tzDataType.isNumber(pobjvViewpointCitationEN.mId) === false) {
            throw new Error("(errid:Watl000060)字段[mId(mId)]的值:[$(pobjvViewpointCitationEN.mId)], 非法，应该为数值型(In v观点引用(vViewpointCitation))!(clsvViewpointCitationBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjvViewpointCitationEN.paperContent) == false && undefined !== pobjvViewpointCitationEN.paperContent && jsString_js_1.tzDataType.isString(pobjvViewpointCitationEN.paperContent) === false) {
            throw new Error("(errid:Watl000060)字段[主题内容(paperContent)]的值:[$(pobjvViewpointCitationEN.paperContent)], 非法，应该为字符型(In v观点引用(vViewpointCitation))!(clsvViewpointCitationBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjvViewpointCitationEN.paperId) == false && undefined !== pobjvViewpointCitationEN.paperId && jsString_js_1.tzDataType.isString(pobjvViewpointCitationEN.paperId) === false) {
            throw new Error("(errid:Watl000060)字段[论文Id(paperId)]的值:[$(pobjvViewpointCitationEN.paperId)], 非法，应该为字符型(In v观点引用(vViewpointCitation))!(clsvViewpointCitationBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjvViewpointCitationEN.paperTitle) == false && undefined !== pobjvViewpointCitationEN.paperTitle && jsString_js_1.tzDataType.isString(pobjvViewpointCitationEN.paperTitle) === false) {
            throw new Error("(errid:Watl000060)字段[论文标题(paperTitle)]的值:[$(pobjvViewpointCitationEN.paperTitle)], 非法，应该为字符型(In v观点引用(vViewpointCitation))!(clsvViewpointCitationBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjvViewpointCitationEN.reason) == false && undefined !== pobjvViewpointCitationEN.reason && jsString_js_1.tzDataType.isString(pobjvViewpointCitationEN.reason) === false) {
            throw new Error("(errid:Watl000060)字段[理由(reason)]的值:[$(pobjvViewpointCitationEN.reason)], 非法，应该为字符型(In v观点引用(vViewpointCitation))!(clsvViewpointCitationBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjvViewpointCitationEN.updUserId) == false && undefined !== pobjvViewpointCitationEN.updUserId && jsString_js_1.tzDataType.isString(pobjvViewpointCitationEN.updUserId) === false) {
            throw new Error("(errid:Watl000060)字段[修改用户Id(updUserId)]的值:[$(pobjvViewpointCitationEN.updUserId)], 非法，应该为字符型(In v观点引用(vViewpointCitation))!(clsvViewpointCitationBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjvViewpointCitationEN.userName) == false && undefined !== pobjvViewpointCitationEN.userName && jsString_js_1.tzDataType.isString(pobjvViewpointCitationEN.userName) === false) {
            throw new Error("(errid:Watl000060)字段[用户名(userName)]的值:[$(pobjvViewpointCitationEN.userName)], 非法，应该为字符型(In v观点引用(vViewpointCitation))!(clsvViewpointCitationBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjvViewpointCitationEN.viewpointId) == false && undefined !== pobjvViewpointCitationEN.viewpointId && jsString_js_1.tzDataType.isString(pobjvViewpointCitationEN.viewpointId) === false) {
            throw new Error("(errid:Watl000060)字段[观点Id(viewpointId)]的值:[$(pobjvViewpointCitationEN.viewpointId)], 非法，应该为字符型(In v观点引用(vViewpointCitation))!(clsvViewpointCitationBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjvViewpointCitationEN.viewpointName) == false && undefined !== pobjvViewpointCitationEN.viewpointName && jsString_js_1.tzDataType.isString(pobjvViewpointCitationEN.viewpointName) === false) {
            throw new Error("(errid:Watl000060)字段[观点名称(viewpointName)]的值:[$(pobjvViewpointCitationEN.viewpointName)], 非法，应该为字符型(In v观点引用(vViewpointCitation))!(clsvViewpointCitationBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjvViewpointCitationEN.viewpointTypeId) == false && undefined !== pobjvViewpointCitationEN.viewpointTypeId && jsString_js_1.tzDataType.isString(pobjvViewpointCitationEN.viewpointTypeId) === false) {
            throw new Error("(errid:Watl000060)字段[观点类型Id(viewpointTypeId)]的值:[$(pobjvViewpointCitationEN.viewpointTypeId)], 非法，应该为字符型(In v观点引用(vViewpointCitation))!(clsvViewpointCitationBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjvViewpointCitationEN.viewpointTypeName) == false && undefined !== pobjvViewpointCitationEN.viewpointTypeName && jsString_js_1.tzDataType.isString(pobjvViewpointCitationEN.viewpointTypeName) === false) {
            throw new Error("(errid:Watl000060)字段[观点类型名(viewpointTypeName)]的值:[$(pobjvViewpointCitationEN.viewpointTypeName)], 非法，应该为字符型(In v观点引用(vViewpointCitation))!(clsvViewpointCitationBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjvViewpointCitationEN.updDate) == false && undefined !== pobjvViewpointCitationEN.updDate && jsString_js_1.tzDataType.isString(pobjvViewpointCitationEN.updDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjvViewpointCitationEN.updDate)], 非法，应该为字符型(In v观点引用(vViewpointCitation))!(clsvViewpointCitationBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjvViewpointCitationEN.proposePeople) == false && undefined !== pobjvViewpointCitationEN.proposePeople && jsString_js_1.tzDataType.isString(pobjvViewpointCitationEN.proposePeople) === false) {
            throw new Error("(errid:Watl000060)字段[提出人(proposePeople)]的值:[$(pobjvViewpointCitationEN.proposePeople)], 非法，应该为字符型(In v观点引用(vViewpointCitation))!(clsvViewpointCitationBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjvViewpointCitationEN.source) == false && undefined !== pobjvViewpointCitationEN.source && jsString_js_1.tzDataType.isString(pobjvViewpointCitationEN.source) === false) {
            throw new Error("(errid:Watl000060)字段[来源(source)]的值:[$(pobjvViewpointCitationEN.source)], 非法，应该为字符型(In v观点引用(vViewpointCitation))!(clsvViewpointCitationBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjvViewpointCitationEN.topicId) == false && undefined !== pobjvViewpointCitationEN.topicId && jsString_js_1.tzDataType.isString(pobjvViewpointCitationEN.topicId) === false) {
            throw new Error("(errid:Watl000060)字段[主题Id(topicId)]的值:[$(pobjvViewpointCitationEN.topicId)], 非法，应该为字符型(In v观点引用(vViewpointCitation))!(clsvViewpointCitationBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjvViewpointCitationEN.topicName) == false && undefined !== pobjvViewpointCitationEN.topicName && jsString_js_1.tzDataType.isString(pobjvViewpointCitationEN.topicName) === false) {
            throw new Error("(errid:Watl000060)字段[栏目主题(topicName)]的值:[$(pobjvViewpointCitationEN.topicName)], 非法，应该为字符型(In v观点引用(vViewpointCitation))!(clsvViewpointCitationBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjvViewpointCitationEN.SetIsCheckProperty(true);
    }
    exports.vViewpointCitation_CheckPropertyNew = vViewpointCitation_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function vViewpointCitation_CheckProperty4Update(pobjvViewpointCitationEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjvViewpointCitationEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjvViewpointCitationEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In v观点引用(vViewpointCitation))!值:$(pobjvViewpointCitationEN.memo)(clsvViewpointCitationBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjvViewpointCitationEN.paperId) == false && (0, clsString_js_1.GetStrLen)(pobjvViewpointCitationEN.paperId) > 8) {
            throw new Error("(errid:Watl000062)字段[论文Id(paperId)]的长度不能超过8(In v观点引用(vViewpointCitation))!值:$(pobjvViewpointCitationEN.paperId)(clsvViewpointCitationBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjvViewpointCitationEN.paperTitle) == false && (0, clsString_js_1.GetStrLen)(pobjvViewpointCitationEN.paperTitle) > 500) {
            throw new Error("(errid:Watl000062)字段[论文标题(paperTitle)]的长度不能超过500(In v观点引用(vViewpointCitation))!值:$(pobjvViewpointCitationEN.paperTitle)(clsvViewpointCitationBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjvViewpointCitationEN.updUserId) == false && (0, clsString_js_1.GetStrLen)(pobjvViewpointCitationEN.updUserId) > 20) {
            throw new Error("(errid:Watl000062)字段[修改用户Id(updUserId)]的长度不能超过20(In v观点引用(vViewpointCitation))!值:$(pobjvViewpointCitationEN.updUserId)(clsvViewpointCitationBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjvViewpointCitationEN.userName) == false && (0, clsString_js_1.GetStrLen)(pobjvViewpointCitationEN.userName) > 50) {
            throw new Error("(errid:Watl000062)字段[用户名(userName)]的长度不能超过50(In v观点引用(vViewpointCitation))!值:$(pobjvViewpointCitationEN.userName)(clsvViewpointCitationBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjvViewpointCitationEN.viewpointId) == false && (0, clsString_js_1.GetStrLen)(pobjvViewpointCitationEN.viewpointId) > 8) {
            throw new Error("(errid:Watl000062)字段[观点Id(viewpointId)]的长度不能超过8(In v观点引用(vViewpointCitation))!值:$(pobjvViewpointCitationEN.viewpointId)(clsvViewpointCitationBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjvViewpointCitationEN.viewpointName) == false && (0, clsString_js_1.GetStrLen)(pobjvViewpointCitationEN.viewpointName) > 500) {
            throw new Error("(errid:Watl000062)字段[观点名称(viewpointName)]的长度不能超过500(In v观点引用(vViewpointCitation))!值:$(pobjvViewpointCitationEN.viewpointName)(clsvViewpointCitationBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjvViewpointCitationEN.viewpointTypeId) == false && (0, clsString_js_1.GetStrLen)(pobjvViewpointCitationEN.viewpointTypeId) > 4) {
            throw new Error("(errid:Watl000062)字段[观点类型Id(viewpointTypeId)]的长度不能超过4(In v观点引用(vViewpointCitation))!值:$(pobjvViewpointCitationEN.viewpointTypeId)(clsvViewpointCitationBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjvViewpointCitationEN.viewpointTypeName) == false && (0, clsString_js_1.GetStrLen)(pobjvViewpointCitationEN.viewpointTypeName) > 50) {
            throw new Error("(errid:Watl000062)字段[观点类型名(viewpointTypeName)]的长度不能超过50(In v观点引用(vViewpointCitation))!值:$(pobjvViewpointCitationEN.viewpointTypeName)(clsvViewpointCitationBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjvViewpointCitationEN.updDate) == false && (0, clsString_js_1.GetStrLen)(pobjvViewpointCitationEN.updDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In v观点引用(vViewpointCitation))!值:$(pobjvViewpointCitationEN.updDate)(clsvViewpointCitationBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjvViewpointCitationEN.proposePeople) == false && (0, clsString_js_1.GetStrLen)(pobjvViewpointCitationEN.proposePeople) > 50) {
            throw new Error("(errid:Watl000062)字段[提出人(proposePeople)]的长度不能超过50(In v观点引用(vViewpointCitation))!值:$(pobjvViewpointCitationEN.proposePeople)(clsvViewpointCitationBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjvViewpointCitationEN.source) == false && (0, clsString_js_1.GetStrLen)(pobjvViewpointCitationEN.source) > 500) {
            throw new Error("(errid:Watl000062)字段[来源(source)]的长度不能超过500(In v观点引用(vViewpointCitation))!值:$(pobjvViewpointCitationEN.source)(clsvViewpointCitationBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjvViewpointCitationEN.topicId) == false && (0, clsString_js_1.GetStrLen)(pobjvViewpointCitationEN.topicId) > 8) {
            throw new Error("(errid:Watl000062)字段[主题Id(topicId)]的长度不能超过8(In v观点引用(vViewpointCitation))!值:$(pobjvViewpointCitationEN.topicId)(clsvViewpointCitationBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjvViewpointCitationEN.topicName) == false && (0, clsString_js_1.GetStrLen)(pobjvViewpointCitationEN.topicName) > 200) {
            throw new Error("(errid:Watl000062)字段[栏目主题(topicName)]的长度不能超过200(In v观点引用(vViewpointCitation))!值:$(pobjvViewpointCitationEN.topicName)(clsvViewpointCitationBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjvViewpointCitationEN.memo) == false && undefined !== pobjvViewpointCitationEN.memo && jsString_js_1.tzDataType.isString(pobjvViewpointCitationEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjvViewpointCitationEN.memo)], 非法，应该为字符型(In v观点引用(vViewpointCitation))!(clsvViewpointCitationBL:CheckProperty4Update)");
        }
        if (null != pobjvViewpointCitationEN.mId && undefined !== pobjvViewpointCitationEN.mId && jsString_js_1.tzDataType.isNumber(pobjvViewpointCitationEN.mId) === false) {
            throw new Error("(errid:Watl000063)字段[mId(mId)]的值:[$(pobjvViewpointCitationEN.mId)], 非法，应该为数值型(In v观点引用(vViewpointCitation))!(clsvViewpointCitationBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjvViewpointCitationEN.paperContent) == false && undefined !== pobjvViewpointCitationEN.paperContent && jsString_js_1.tzDataType.isString(pobjvViewpointCitationEN.paperContent) === false) {
            throw new Error("(errid:Watl000063)字段[主题内容(paperContent)]的值:[$(pobjvViewpointCitationEN.paperContent)], 非法，应该为字符型(In v观点引用(vViewpointCitation))!(clsvViewpointCitationBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjvViewpointCitationEN.paperId) == false && undefined !== pobjvViewpointCitationEN.paperId && jsString_js_1.tzDataType.isString(pobjvViewpointCitationEN.paperId) === false) {
            throw new Error("(errid:Watl000063)字段[论文Id(paperId)]的值:[$(pobjvViewpointCitationEN.paperId)], 非法，应该为字符型(In v观点引用(vViewpointCitation))!(clsvViewpointCitationBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjvViewpointCitationEN.paperTitle) == false && undefined !== pobjvViewpointCitationEN.paperTitle && jsString_js_1.tzDataType.isString(pobjvViewpointCitationEN.paperTitle) === false) {
            throw new Error("(errid:Watl000063)字段[论文标题(paperTitle)]的值:[$(pobjvViewpointCitationEN.paperTitle)], 非法，应该为字符型(In v观点引用(vViewpointCitation))!(clsvViewpointCitationBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjvViewpointCitationEN.reason) == false && undefined !== pobjvViewpointCitationEN.reason && jsString_js_1.tzDataType.isString(pobjvViewpointCitationEN.reason) === false) {
            throw new Error("(errid:Watl000063)字段[理由(reason)]的值:[$(pobjvViewpointCitationEN.reason)], 非法，应该为字符型(In v观点引用(vViewpointCitation))!(clsvViewpointCitationBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjvViewpointCitationEN.updUserId) == false && undefined !== pobjvViewpointCitationEN.updUserId && jsString_js_1.tzDataType.isString(pobjvViewpointCitationEN.updUserId) === false) {
            throw new Error("(errid:Watl000063)字段[修改用户Id(updUserId)]的值:[$(pobjvViewpointCitationEN.updUserId)], 非法，应该为字符型(In v观点引用(vViewpointCitation))!(clsvViewpointCitationBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjvViewpointCitationEN.userName) == false && undefined !== pobjvViewpointCitationEN.userName && jsString_js_1.tzDataType.isString(pobjvViewpointCitationEN.userName) === false) {
            throw new Error("(errid:Watl000063)字段[用户名(userName)]的值:[$(pobjvViewpointCitationEN.userName)], 非法，应该为字符型(In v观点引用(vViewpointCitation))!(clsvViewpointCitationBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjvViewpointCitationEN.viewpointId) == false && undefined !== pobjvViewpointCitationEN.viewpointId && jsString_js_1.tzDataType.isString(pobjvViewpointCitationEN.viewpointId) === false) {
            throw new Error("(errid:Watl000063)字段[观点Id(viewpointId)]的值:[$(pobjvViewpointCitationEN.viewpointId)], 非法，应该为字符型(In v观点引用(vViewpointCitation))!(clsvViewpointCitationBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjvViewpointCitationEN.viewpointName) == false && undefined !== pobjvViewpointCitationEN.viewpointName && jsString_js_1.tzDataType.isString(pobjvViewpointCitationEN.viewpointName) === false) {
            throw new Error("(errid:Watl000063)字段[观点名称(viewpointName)]的值:[$(pobjvViewpointCitationEN.viewpointName)], 非法，应该为字符型(In v观点引用(vViewpointCitation))!(clsvViewpointCitationBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjvViewpointCitationEN.viewpointTypeId) == false && undefined !== pobjvViewpointCitationEN.viewpointTypeId && jsString_js_1.tzDataType.isString(pobjvViewpointCitationEN.viewpointTypeId) === false) {
            throw new Error("(errid:Watl000063)字段[观点类型Id(viewpointTypeId)]的值:[$(pobjvViewpointCitationEN.viewpointTypeId)], 非法，应该为字符型(In v观点引用(vViewpointCitation))!(clsvViewpointCitationBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjvViewpointCitationEN.viewpointTypeName) == false && undefined !== pobjvViewpointCitationEN.viewpointTypeName && jsString_js_1.tzDataType.isString(pobjvViewpointCitationEN.viewpointTypeName) === false) {
            throw new Error("(errid:Watl000063)字段[观点类型名(viewpointTypeName)]的值:[$(pobjvViewpointCitationEN.viewpointTypeName)], 非法，应该为字符型(In v观点引用(vViewpointCitation))!(clsvViewpointCitationBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjvViewpointCitationEN.updDate) == false && undefined !== pobjvViewpointCitationEN.updDate && jsString_js_1.tzDataType.isString(pobjvViewpointCitationEN.updDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjvViewpointCitationEN.updDate)], 非法，应该为字符型(In v观点引用(vViewpointCitation))!(clsvViewpointCitationBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjvViewpointCitationEN.proposePeople) == false && undefined !== pobjvViewpointCitationEN.proposePeople && jsString_js_1.tzDataType.isString(pobjvViewpointCitationEN.proposePeople) === false) {
            throw new Error("(errid:Watl000063)字段[提出人(proposePeople)]的值:[$(pobjvViewpointCitationEN.proposePeople)], 非法，应该为字符型(In v观点引用(vViewpointCitation))!(clsvViewpointCitationBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjvViewpointCitationEN.source) == false && undefined !== pobjvViewpointCitationEN.source && jsString_js_1.tzDataType.isString(pobjvViewpointCitationEN.source) === false) {
            throw new Error("(errid:Watl000063)字段[来源(source)]的值:[$(pobjvViewpointCitationEN.source)], 非法，应该为字符型(In v观点引用(vViewpointCitation))!(clsvViewpointCitationBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjvViewpointCitationEN.topicId) == false && undefined !== pobjvViewpointCitationEN.topicId && jsString_js_1.tzDataType.isString(pobjvViewpointCitationEN.topicId) === false) {
            throw new Error("(errid:Watl000063)字段[主题Id(topicId)]的值:[$(pobjvViewpointCitationEN.topicId)], 非法，应该为字符型(In v观点引用(vViewpointCitation))!(clsvViewpointCitationBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjvViewpointCitationEN.topicName) == false && undefined !== pobjvViewpointCitationEN.topicName && jsString_js_1.tzDataType.isString(pobjvViewpointCitationEN.topicName) === false) {
            throw new Error("(errid:Watl000063)字段[栏目主题(topicName)]的值:[$(pobjvViewpointCitationEN.topicName)], 非法，应该为字符型(In v观点引用(vViewpointCitation))!(clsvViewpointCitationBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if (null === pobjvViewpointCitationEN.mId
            || pobjvViewpointCitationEN.mId != null && pobjvViewpointCitationEN.mId.toString() === "") {
            throw new Error("(errid:Watl000064)字段[mId]不能为空(In v观点引用)!(clsvViewpointCitationBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjvViewpointCitationEN.SetIsCheckProperty(true);
    }
    exports.vViewpointCitation_CheckProperty4Update = vViewpointCitation_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vViewpointCitation_GetJSONStrByObj(pobjvViewpointCitationEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjvViewpointCitationEN.sf_UpdFldSetStr = pobjvViewpointCitationEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjvViewpointCitationEN);
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
    exports.vViewpointCitation_GetJSONStrByObj = vViewpointCitation_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function vViewpointCitation_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrvViewpointCitationObjLst = new Array();
        if (strJSON === "") {
            return arrvViewpointCitationObjLst;
        }
        try {
            arrvViewpointCitationObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrvViewpointCitationObjLst;
        }
        return arrvViewpointCitationObjLst;
    }
    exports.vViewpointCitation_GetObjLstByJSONStr = vViewpointCitation_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrvViewpointCitationObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function vViewpointCitation_GetObjLstByJSONObjLst(arrvViewpointCitationObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrvViewpointCitationObjLst = new Array();
        for (const objInFor of arrvViewpointCitationObjLstS) {
            const obj1 = vViewpointCitation_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrvViewpointCitationObjLst.push(obj1);
        }
        return arrvViewpointCitationObjLst;
    }
    exports.vViewpointCitation_GetObjLstByJSONObjLst = vViewpointCitation_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vViewpointCitation_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjvViewpointCitationEN = new clsvViewpointCitationEN_js_1.clsvViewpointCitationEN();
        if (strJSON === "") {
            return pobjvViewpointCitationEN;
        }
        try {
            pobjvViewpointCitationEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjvViewpointCitationEN;
        }
        return pobjvViewpointCitationEN;
    }
    exports.vViewpointCitation_GetObjByJSONStr = vViewpointCitation_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function vViewpointCitation_GetCombineCondition(objvViewpointCitation_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objvViewpointCitation_Cond.dicFldComparisonOp, clsvViewpointCitationEN_js_1.clsvViewpointCitationEN.con_Memo) == true) {
            const strComparisonOp_Memo = objvViewpointCitation_Cond.dicFldComparisonOp[clsvViewpointCitationEN_js_1.clsvViewpointCitationEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvViewpointCitationEN_js_1.clsvViewpointCitationEN.con_Memo, objvViewpointCitation_Cond.memo, strComparisonOp_Memo);
        }
        if (Object.prototype.hasOwnProperty.call(objvViewpointCitation_Cond.dicFldComparisonOp, clsvViewpointCitationEN_js_1.clsvViewpointCitationEN.con_mId) == true) {
            const strComparisonOp_mId = objvViewpointCitation_Cond.dicFldComparisonOp[clsvViewpointCitationEN_js_1.clsvViewpointCitationEN.con_mId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvViewpointCitationEN_js_1.clsvViewpointCitationEN.con_mId, objvViewpointCitation_Cond.mId, strComparisonOp_mId);
        }
        //数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
        if (Object.prototype.hasOwnProperty.call(objvViewpointCitation_Cond.dicFldComparisonOp, clsvViewpointCitationEN_js_1.clsvViewpointCitationEN.con_PaperId) == true) {
            const strComparisonOp_PaperId = objvViewpointCitation_Cond.dicFldComparisonOp[clsvViewpointCitationEN_js_1.clsvViewpointCitationEN.con_PaperId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvViewpointCitationEN_js_1.clsvViewpointCitationEN.con_PaperId, objvViewpointCitation_Cond.paperId, strComparisonOp_PaperId);
        }
        if (Object.prototype.hasOwnProperty.call(objvViewpointCitation_Cond.dicFldComparisonOp, clsvViewpointCitationEN_js_1.clsvViewpointCitationEN.con_PaperTitle) == true) {
            const strComparisonOp_PaperTitle = objvViewpointCitation_Cond.dicFldComparisonOp[clsvViewpointCitationEN_js_1.clsvViewpointCitationEN.con_PaperTitle];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvViewpointCitationEN_js_1.clsvViewpointCitationEN.con_PaperTitle, objvViewpointCitation_Cond.paperTitle, strComparisonOp_PaperTitle);
        }
        //数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
        if (Object.prototype.hasOwnProperty.call(objvViewpointCitation_Cond.dicFldComparisonOp, clsvViewpointCitationEN_js_1.clsvViewpointCitationEN.con_UpdUserId) == true) {
            const strComparisonOp_UpdUserId = objvViewpointCitation_Cond.dicFldComparisonOp[clsvViewpointCitationEN_js_1.clsvViewpointCitationEN.con_UpdUserId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvViewpointCitationEN_js_1.clsvViewpointCitationEN.con_UpdUserId, objvViewpointCitation_Cond.updUserId, strComparisonOp_UpdUserId);
        }
        if (Object.prototype.hasOwnProperty.call(objvViewpointCitation_Cond.dicFldComparisonOp, clsvViewpointCitationEN_js_1.clsvViewpointCitationEN.con_UserName) == true) {
            const strComparisonOp_UserName = objvViewpointCitation_Cond.dicFldComparisonOp[clsvViewpointCitationEN_js_1.clsvViewpointCitationEN.con_UserName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvViewpointCitationEN_js_1.clsvViewpointCitationEN.con_UserName, objvViewpointCitation_Cond.userName, strComparisonOp_UserName);
        }
        if (Object.prototype.hasOwnProperty.call(objvViewpointCitation_Cond.dicFldComparisonOp, clsvViewpointCitationEN_js_1.clsvViewpointCitationEN.con_ViewpointId) == true) {
            const strComparisonOp_ViewpointId = objvViewpointCitation_Cond.dicFldComparisonOp[clsvViewpointCitationEN_js_1.clsvViewpointCitationEN.con_ViewpointId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvViewpointCitationEN_js_1.clsvViewpointCitationEN.con_ViewpointId, objvViewpointCitation_Cond.viewpointId, strComparisonOp_ViewpointId);
        }
        if (Object.prototype.hasOwnProperty.call(objvViewpointCitation_Cond.dicFldComparisonOp, clsvViewpointCitationEN_js_1.clsvViewpointCitationEN.con_ViewpointName) == true) {
            const strComparisonOp_ViewpointName = objvViewpointCitation_Cond.dicFldComparisonOp[clsvViewpointCitationEN_js_1.clsvViewpointCitationEN.con_ViewpointName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvViewpointCitationEN_js_1.clsvViewpointCitationEN.con_ViewpointName, objvViewpointCitation_Cond.viewpointName, strComparisonOp_ViewpointName);
        }
        if (Object.prototype.hasOwnProperty.call(objvViewpointCitation_Cond.dicFldComparisonOp, clsvViewpointCitationEN_js_1.clsvViewpointCitationEN.con_ViewpointTypeId) == true) {
            const strComparisonOp_ViewpointTypeId = objvViewpointCitation_Cond.dicFldComparisonOp[clsvViewpointCitationEN_js_1.clsvViewpointCitationEN.con_ViewpointTypeId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvViewpointCitationEN_js_1.clsvViewpointCitationEN.con_ViewpointTypeId, objvViewpointCitation_Cond.viewpointTypeId, strComparisonOp_ViewpointTypeId);
        }
        if (Object.prototype.hasOwnProperty.call(objvViewpointCitation_Cond.dicFldComparisonOp, clsvViewpointCitationEN_js_1.clsvViewpointCitationEN.con_ViewpointTypeName) == true) {
            const strComparisonOp_ViewpointTypeName = objvViewpointCitation_Cond.dicFldComparisonOp[clsvViewpointCitationEN_js_1.clsvViewpointCitationEN.con_ViewpointTypeName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvViewpointCitationEN_js_1.clsvViewpointCitationEN.con_ViewpointTypeName, objvViewpointCitation_Cond.viewpointTypeName, strComparisonOp_ViewpointTypeName);
        }
        if (Object.prototype.hasOwnProperty.call(objvViewpointCitation_Cond.dicFldComparisonOp, clsvViewpointCitationEN_js_1.clsvViewpointCitationEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objvViewpointCitation_Cond.dicFldComparisonOp[clsvViewpointCitationEN_js_1.clsvViewpointCitationEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvViewpointCitationEN_js_1.clsvViewpointCitationEN.con_UpdDate, objvViewpointCitation_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvViewpointCitation_Cond.dicFldComparisonOp, clsvViewpointCitationEN_js_1.clsvViewpointCitationEN.con_ProposePeople) == true) {
            const strComparisonOp_ProposePeople = objvViewpointCitation_Cond.dicFldComparisonOp[clsvViewpointCitationEN_js_1.clsvViewpointCitationEN.con_ProposePeople];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvViewpointCitationEN_js_1.clsvViewpointCitationEN.con_ProposePeople, objvViewpointCitation_Cond.proposePeople, strComparisonOp_ProposePeople);
        }
        if (Object.prototype.hasOwnProperty.call(objvViewpointCitation_Cond.dicFldComparisonOp, clsvViewpointCitationEN_js_1.clsvViewpointCitationEN.con_Source) == true) {
            const strComparisonOp_Source = objvViewpointCitation_Cond.dicFldComparisonOp[clsvViewpointCitationEN_js_1.clsvViewpointCitationEN.con_Source];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvViewpointCitationEN_js_1.clsvViewpointCitationEN.con_Source, objvViewpointCitation_Cond.source, strComparisonOp_Source);
        }
        if (Object.prototype.hasOwnProperty.call(objvViewpointCitation_Cond.dicFldComparisonOp, clsvViewpointCitationEN_js_1.clsvViewpointCitationEN.con_TopicId) == true) {
            const strComparisonOp_TopicId = objvViewpointCitation_Cond.dicFldComparisonOp[clsvViewpointCitationEN_js_1.clsvViewpointCitationEN.con_TopicId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvViewpointCitationEN_js_1.clsvViewpointCitationEN.con_TopicId, objvViewpointCitation_Cond.topicId, strComparisonOp_TopicId);
        }
        if (Object.prototype.hasOwnProperty.call(objvViewpointCitation_Cond.dicFldComparisonOp, clsvViewpointCitationEN_js_1.clsvViewpointCitationEN.con_TopicName) == true) {
            const strComparisonOp_TopicName = objvViewpointCitation_Cond.dicFldComparisonOp[clsvViewpointCitationEN_js_1.clsvViewpointCitationEN.con_TopicName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvViewpointCitationEN_js_1.clsvViewpointCitationEN.con_TopicName, objvViewpointCitation_Cond.topicName, strComparisonOp_TopicName);
        }
        return strWhereCond;
    }
    exports.vViewpointCitation_GetCombineCondition = vViewpointCitation_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--vViewpointCitation(v观点引用),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param lngmId: mId(要求唯一的字段)
    * @param strPaperId: 论文Id(要求唯一的字段)
    * @param strViewpointId: 观点Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function vViewpointCitation_GetUniCondStr_mId_PaperId_ViewpointId(objvViewpointCitationEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and mId = '{0}'", objvViewpointCitationEN.mId);
        strWhereCond += (0, clsString_js_1.Format)(" and PaperId = '{0}'", objvViewpointCitationEN.paperId);
        strWhereCond += (0, clsString_js_1.Format)(" and ViewpointId = '{0}'", objvViewpointCitationEN.viewpointId);
        return strWhereCond;
    }
    exports.vViewpointCitation_GetUniCondStr_mId_PaperId_ViewpointId = vViewpointCitation_GetUniCondStr_mId_PaperId_ViewpointId;
    /**
    *获取唯一性条件串(Uniqueness)--vViewpointCitation(v观点引用),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param lngmId: mId(要求唯一的字段)
    * @param strPaperId: 论文Id(要求唯一的字段)
    * @param strViewpointId: 观点Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function vViewpointCitation_GetUniCondStr4Update_mId_PaperId_ViewpointId(objvViewpointCitationEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and mId <> '{0}'", objvViewpointCitationEN.mId);
        strWhereCond += (0, clsString_js_1.Format)(" and mId = '{0}'", objvViewpointCitationEN.mId);
        strWhereCond += (0, clsString_js_1.Format)(" and PaperId = '{0}'", objvViewpointCitationEN.paperId);
        strWhereCond += (0, clsString_js_1.Format)(" and ViewpointId = '{0}'", objvViewpointCitationEN.viewpointId);
        return strWhereCond;
    }
    exports.vViewpointCitation_GetUniCondStr4Update_mId_PaperId_ViewpointId = vViewpointCitation_GetUniCondStr4Update_mId_PaperId_ViewpointId;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objvViewpointCitationENS:源对象
     * @param objvViewpointCitationENT:目标对象
    */
    function vViewpointCitation_CopyObjTo(objvViewpointCitationENS, objvViewpointCitationENT) {
        objvViewpointCitationENT.memo = objvViewpointCitationENS.memo; //备注
        objvViewpointCitationENT.mId = objvViewpointCitationENS.mId; //mId
        objvViewpointCitationENT.paperContent = objvViewpointCitationENS.paperContent; //主题内容
        objvViewpointCitationENT.paperId = objvViewpointCitationENS.paperId; //论文Id
        objvViewpointCitationENT.paperTitle = objvViewpointCitationENS.paperTitle; //论文标题
        objvViewpointCitationENT.reason = objvViewpointCitationENS.reason; //理由
        objvViewpointCitationENT.updUserId = objvViewpointCitationENS.updUserId; //修改用户Id
        objvViewpointCitationENT.userName = objvViewpointCitationENS.userName; //用户名
        objvViewpointCitationENT.viewpointId = objvViewpointCitationENS.viewpointId; //观点Id
        objvViewpointCitationENT.viewpointName = objvViewpointCitationENS.viewpointName; //观点名称
        objvViewpointCitationENT.viewpointTypeId = objvViewpointCitationENS.viewpointTypeId; //观点类型Id
        objvViewpointCitationENT.viewpointTypeName = objvViewpointCitationENS.viewpointTypeName; //观点类型名
        objvViewpointCitationENT.updDate = objvViewpointCitationENS.updDate; //修改日期
        objvViewpointCitationENT.proposePeople = objvViewpointCitationENS.proposePeople; //提出人
        objvViewpointCitationENT.source = objvViewpointCitationENS.source; //来源
        objvViewpointCitationENT.topicId = objvViewpointCitationENS.topicId; //主题Id
        objvViewpointCitationENT.topicName = objvViewpointCitationENS.topicName; //栏目主题
        objvViewpointCitationENT.sf_UpdFldSetStr = objvViewpointCitationENS.updFldString; //sf_UpdFldSetStr
    }
    exports.vViewpointCitation_CopyObjTo = vViewpointCitation_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objvViewpointCitationENS:源对象
     * @param objvViewpointCitationENT:目标对象
    */
    function vViewpointCitation_GetObjFromJsonObj(objvViewpointCitationENS) {
        const objvViewpointCitationENT = new clsvViewpointCitationEN_js_1.clsvViewpointCitationEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvViewpointCitationENT, objvViewpointCitationENS);
        return objvViewpointCitationENT;
    }
    exports.vViewpointCitation_GetObjFromJsonObj = vViewpointCitation_GetObjFromJsonObj;
});
