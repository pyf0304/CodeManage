/**
* 类名:clsvConceptCitationWApi
* 表名:vConceptCitation(01120611)
* 生成代码版本:2022.11.02.1
* 生成日期:2022/11/02 12:02:49
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
        define(["require", "exports", "axios", "../../L0_Entity/GraduateEduTopic/clsvConceptCitationEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsSysPara4WebApi.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.vConceptCitation_GetObjFromJsonObj = exports.vConceptCitation_CopyObjTo = exports.vConceptCitation_GetUniCondStr4Update_mId_ConceptId_PaperId = exports.vConceptCitation_GetUniCondStr_mId_ConceptId_PaperId = exports.vConceptCitation_GetCombineCondition = exports.vConceptCitation_GetObjByJSONStr = exports.vConceptCitation_GetObjLstByJSONObjLst = exports.vConceptCitation_GetObjLstByJSONStr = exports.vConceptCitation_GetJSONStrByObj = exports.vConceptCitation_GetWebApiUrl = exports.vConceptCitation_GetRecCountByCondAsync = exports.vConceptCitation_IsExistAsync = exports.vConceptCitation_IsExist = exports.vConceptCitation_IsExistRecordAsync = exports.vConceptCitation_GetObjLstByPagerAsync = exports.vConceptCitation_GetObjLstByRange = exports.vConceptCitation_GetObjLstByRangeAsync = exports.vConceptCitation_GetTopObjLstAsync = exports.vConceptCitation_GetObjLstBymIdLstAsync = exports.vConceptCitation_GetObjLstAsync = exports.vConceptCitation_GetFirstObjAsync = exports.vConceptCitation_GetFirstID = exports.vConceptCitation_GetFirstIDAsync = exports.vConceptCitation_FilterFunByKey = exports.vConceptCitation_SortFunByKey = exports.vConceptCitation_SortFun_Defa_2Fld = exports.vConceptCitation_SortFun_Defa = exports.vConceptCitation_GetObjBymIdAsync = exports.vConceptCitation_ConstructorName = exports.vConceptCitation_Controller = void 0;
    /**
     * vConceptCitation(vConceptCitation)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2022年11月02日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const clsvConceptCitationEN_js_1 = require("../../L0_Entity/GraduateEduTopic/clsvConceptCitationEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.vConceptCitation_Controller = "vConceptCitationApi";
    exports.vConceptCitation_ConstructorName = "vConceptCitation";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param lngmId:关键字
    * @returns 对象
    **/
    async function vConceptCitation_GetObjBymIdAsync(lngmId) {
        const strThisFuncName = "GetObjBymIdAsync";
        if (lngmId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngmId]不能为空！(In GetObjBymIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjBymId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vConceptCitation_Controller, strAction);
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
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vConceptCitation_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objvConceptCitation = vConceptCitation_GetObjFromJsonObj(returnObj);
                return objvConceptCitation;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vConceptCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vConceptCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vConceptCitation_GetObjBymIdAsync = vConceptCitation_GetObjBymIdAsync;
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
    function vConceptCitation_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.mId - b.mId;
    }
    exports.vConceptCitation_SortFun_Defa = vConceptCitation_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vConceptCitation_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.conceptContent == b.conceptContent)
            return a.conceptId.localeCompare(b.conceptId);
        else
            return a.conceptContent.localeCompare(b.conceptContent);
    }
    exports.vConceptCitation_SortFun_Defa_2Fld = vConceptCitation_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vConceptCitation_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsvConceptCitationEN_js_1.clsvConceptCitationEN.con_ConceptContent:
                    return (a, b) => {
                        return a.conceptContent.localeCompare(b.conceptContent);
                    };
                case clsvConceptCitationEN_js_1.clsvConceptCitationEN.con_ConceptId:
                    return (a, b) => {
                        return a.conceptId.localeCompare(b.conceptId);
                    };
                case clsvConceptCitationEN_js_1.clsvConceptCitationEN.con_ConceptName:
                    return (a, b) => {
                        return a.conceptName.localeCompare(b.conceptName);
                    };
                case clsvConceptCitationEN_js_1.clsvConceptCitationEN.con_UpdDate:
                    return (a, b) => {
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsvConceptCitationEN_js_1.clsvConceptCitationEN.con_mId:
                    return (a, b) => {
                        return a.mId - b.mId;
                    };
                case clsvConceptCitationEN_js_1.clsvConceptCitationEN.con_PaperId:
                    return (a, b) => {
                        return a.paperId.localeCompare(b.paperId);
                    };
                case clsvConceptCitationEN_js_1.clsvConceptCitationEN.con_PaperTitle:
                    return (a, b) => {
                        return a.paperTitle.localeCompare(b.paperTitle);
                    };
                case clsvConceptCitationEN_js_1.clsvConceptCitationEN.con_PaperContent:
                    return (a, b) => {
                        return a.paperContent.localeCompare(b.paperContent);
                    };
                case clsvConceptCitationEN_js_1.clsvConceptCitationEN.con_UserName:
                    return (a, b) => {
                        return a.userName.localeCompare(b.userName);
                    };
                case clsvConceptCitationEN_js_1.clsvConceptCitationEN.con_UpdUserId:
                    return (a, b) => {
                        return a.updUserId.localeCompare(b.updUserId);
                    };
                case clsvConceptCitationEN_js_1.clsvConceptCitationEN.con_TopicId:
                    return (a, b) => {
                        return a.topicId.localeCompare(b.topicId);
                    };
                case clsvConceptCitationEN_js_1.clsvConceptCitationEN.con_TopicName:
                    return (a, b) => {
                        return a.topicName.localeCompare(b.topicName);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vConceptCitation]中不存在！(in ${exports.vConceptCitation_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsvConceptCitationEN_js_1.clsvConceptCitationEN.con_ConceptContent:
                    return (a, b) => {
                        return b.conceptContent.localeCompare(a.conceptContent);
                    };
                case clsvConceptCitationEN_js_1.clsvConceptCitationEN.con_ConceptId:
                    return (a, b) => {
                        return b.conceptId.localeCompare(a.conceptId);
                    };
                case clsvConceptCitationEN_js_1.clsvConceptCitationEN.con_ConceptName:
                    return (a, b) => {
                        return b.conceptName.localeCompare(a.conceptName);
                    };
                case clsvConceptCitationEN_js_1.clsvConceptCitationEN.con_UpdDate:
                    return (a, b) => {
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsvConceptCitationEN_js_1.clsvConceptCitationEN.con_mId:
                    return (a, b) => {
                        return b.mId - a.mId;
                    };
                case clsvConceptCitationEN_js_1.clsvConceptCitationEN.con_PaperId:
                    return (a, b) => {
                        return b.paperId.localeCompare(a.paperId);
                    };
                case clsvConceptCitationEN_js_1.clsvConceptCitationEN.con_PaperTitle:
                    return (a, b) => {
                        return b.paperTitle.localeCompare(a.paperTitle);
                    };
                case clsvConceptCitationEN_js_1.clsvConceptCitationEN.con_PaperContent:
                    return (a, b) => {
                        return b.paperContent.localeCompare(a.paperContent);
                    };
                case clsvConceptCitationEN_js_1.clsvConceptCitationEN.con_UserName:
                    return (a, b) => {
                        return b.userName.localeCompare(a.userName);
                    };
                case clsvConceptCitationEN_js_1.clsvConceptCitationEN.con_UpdUserId:
                    return (a, b) => {
                        return b.updUserId.localeCompare(a.updUserId);
                    };
                case clsvConceptCitationEN_js_1.clsvConceptCitationEN.con_TopicId:
                    return (a, b) => {
                        return b.topicId.localeCompare(a.topicId);
                    };
                case clsvConceptCitationEN_js_1.clsvConceptCitationEN.con_TopicName:
                    return (a, b) => {
                        return b.topicName.localeCompare(a.topicName);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vConceptCitation]中不存在！(in ${exports.vConceptCitation_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.vConceptCitation_SortFunByKey = vConceptCitation_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function vConceptCitation_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsvConceptCitationEN_js_1.clsvConceptCitationEN.con_ConceptContent:
                return (obj) => {
                    return obj.conceptContent === value;
                };
            case clsvConceptCitationEN_js_1.clsvConceptCitationEN.con_ConceptId:
                return (obj) => {
                    return obj.conceptId === value;
                };
            case clsvConceptCitationEN_js_1.clsvConceptCitationEN.con_ConceptName:
                return (obj) => {
                    return obj.conceptName === value;
                };
            case clsvConceptCitationEN_js_1.clsvConceptCitationEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsvConceptCitationEN_js_1.clsvConceptCitationEN.con_mId:
                return (obj) => {
                    return obj.mId === value;
                };
            case clsvConceptCitationEN_js_1.clsvConceptCitationEN.con_PaperId:
                return (obj) => {
                    return obj.paperId === value;
                };
            case clsvConceptCitationEN_js_1.clsvConceptCitationEN.con_PaperTitle:
                return (obj) => {
                    return obj.paperTitle === value;
                };
            case clsvConceptCitationEN_js_1.clsvConceptCitationEN.con_PaperContent:
                return (obj) => {
                    return obj.paperContent === value;
                };
            case clsvConceptCitationEN_js_1.clsvConceptCitationEN.con_UserName:
                return (obj) => {
                    return obj.userName === value;
                };
            case clsvConceptCitationEN_js_1.clsvConceptCitationEN.con_UpdUserId:
                return (obj) => {
                    return obj.updUserId === value;
                };
            case clsvConceptCitationEN_js_1.clsvConceptCitationEN.con_TopicId:
                return (obj) => {
                    return obj.topicId === value;
                };
            case clsvConceptCitationEN_js_1.clsvConceptCitationEN.con_TopicName:
                return (obj) => {
                    return obj.topicName === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[vConceptCitation]中不存在！(in ${exports.vConceptCitation_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.vConceptCitation_FilterFunByKey = vConceptCitation_FilterFunByKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function vConceptCitation_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vConceptCitation_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vConceptCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vConceptCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vConceptCitation_GetFirstIDAsync = vConceptCitation_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function vConceptCitation_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vConceptCitation_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vConceptCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vConceptCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vConceptCitation_GetFirstID = vConceptCitation_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function vConceptCitation_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vConceptCitation_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vConceptCitation_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objvConceptCitation = vConceptCitation_GetObjFromJsonObj(returnObj);
                return objvConceptCitation;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vConceptCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vConceptCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vConceptCitation_GetFirstObjAsync = vConceptCitation_GetFirstObjAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function vConceptCitation_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vConceptCitation_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vConceptCitation_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vConceptCitation_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vConceptCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vConceptCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vConceptCitation_GetObjLstAsync = vConceptCitation_GetObjLstAsync;
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
    async function vConceptCitation_GetObjLstBymIdLstAsync(arrmId) {
        const strThisFuncName = "GetObjLstBymIdLstAsync";
        const strAction = "GetObjLstBymIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vConceptCitation_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrmId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vConceptCitation_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vConceptCitation_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vConceptCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vConceptCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vConceptCitation_GetObjLstBymIdLstAsync = vConceptCitation_GetObjLstBymIdLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function vConceptCitation_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vConceptCitation_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vConceptCitation_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vConceptCitation_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vConceptCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vConceptCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vConceptCitation_GetTopObjLstAsync = vConceptCitation_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vConceptCitation_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vConceptCitation_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vConceptCitation_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vConceptCitation_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vConceptCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vConceptCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vConceptCitation_GetObjLstByRangeAsync = vConceptCitation_GetObjLstByRangeAsync;
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
    async function vConceptCitation_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vConceptCitation_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vConceptCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vConceptCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vConceptCitation_GetObjLstByRange = vConceptCitation_GetObjLstByRange;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vConceptCitation_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vConceptCitation_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vConceptCitation_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vConceptCitation_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vConceptCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vConceptCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vConceptCitation_GetObjLstByPagerAsync = vConceptCitation_GetObjLstByPagerAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function vConceptCitation_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vConceptCitation_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vConceptCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vConceptCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vConceptCitation_IsExistRecordAsync = vConceptCitation_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param lngmId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function vConceptCitation_IsExist(lngmId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vConceptCitation_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vConceptCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vConceptCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vConceptCitation_IsExist = vConceptCitation_IsExist;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param lngmId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function vConceptCitation_IsExistAsync(lngmId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vConceptCitation_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vConceptCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vConceptCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vConceptCitation_IsExistAsync = vConceptCitation_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function vConceptCitation_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vConceptCitation_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vConceptCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vConceptCitation_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vConceptCitation_GetRecCountByCondAsync = vConceptCitation_GetRecCountByCondAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function vConceptCitation_GetWebApiUrl(strController, strAction) {
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
    exports.vConceptCitation_GetWebApiUrl = vConceptCitation_GetWebApiUrl;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vConceptCitation_GetJSONStrByObj(pobjvConceptCitationEN) {
        const strThisFuncName = "GetJSONStrByObj";
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjvConceptCitationEN);
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
    exports.vConceptCitation_GetJSONStrByObj = vConceptCitation_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function vConceptCitation_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrvConceptCitationObjLst = new Array();
        if (strJSON === "") {
            return arrvConceptCitationObjLst;
        }
        try {
            arrvConceptCitationObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrvConceptCitationObjLst;
        }
        return arrvConceptCitationObjLst;
    }
    exports.vConceptCitation_GetObjLstByJSONStr = vConceptCitation_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrvConceptCitationObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function vConceptCitation_GetObjLstByJSONObjLst(arrvConceptCitationObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrvConceptCitationObjLst = new Array();
        for (const objInFor of arrvConceptCitationObjLstS) {
            const obj1 = vConceptCitation_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrvConceptCitationObjLst.push(obj1);
        }
        return arrvConceptCitationObjLst;
    }
    exports.vConceptCitation_GetObjLstByJSONObjLst = vConceptCitation_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vConceptCitation_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjvConceptCitationEN = new clsvConceptCitationEN_js_1.clsvConceptCitationEN();
        if (strJSON === "") {
            return pobjvConceptCitationEN;
        }
        try {
            pobjvConceptCitationEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjvConceptCitationEN;
        }
        return pobjvConceptCitationEN;
    }
    exports.vConceptCitation_GetObjByJSONStr = vConceptCitation_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function vConceptCitation_GetCombineCondition(objvConceptCitation_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        //数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
        if (Object.prototype.hasOwnProperty.call(objvConceptCitation_Cond.dicFldComparisonOp, clsvConceptCitationEN_js_1.clsvConceptCitationEN.con_ConceptId) == true) {
            const strComparisonOp_ConceptId = objvConceptCitation_Cond.dicFldComparisonOp[clsvConceptCitationEN_js_1.clsvConceptCitationEN.con_ConceptId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvConceptCitationEN_js_1.clsvConceptCitationEN.con_ConceptId, objvConceptCitation_Cond.conceptId, strComparisonOp_ConceptId);
        }
        if (Object.prototype.hasOwnProperty.call(objvConceptCitation_Cond.dicFldComparisonOp, clsvConceptCitationEN_js_1.clsvConceptCitationEN.con_ConceptName) == true) {
            const strComparisonOp_ConceptName = objvConceptCitation_Cond.dicFldComparisonOp[clsvConceptCitationEN_js_1.clsvConceptCitationEN.con_ConceptName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvConceptCitationEN_js_1.clsvConceptCitationEN.con_ConceptName, objvConceptCitation_Cond.conceptName, strComparisonOp_ConceptName);
        }
        if (Object.prototype.hasOwnProperty.call(objvConceptCitation_Cond.dicFldComparisonOp, clsvConceptCitationEN_js_1.clsvConceptCitationEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objvConceptCitation_Cond.dicFldComparisonOp[clsvConceptCitationEN_js_1.clsvConceptCitationEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvConceptCitationEN_js_1.clsvConceptCitationEN.con_UpdDate, objvConceptCitation_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvConceptCitation_Cond.dicFldComparisonOp, clsvConceptCitationEN_js_1.clsvConceptCitationEN.con_mId) == true) {
            const strComparisonOp_mId = objvConceptCitation_Cond.dicFldComparisonOp[clsvConceptCitationEN_js_1.clsvConceptCitationEN.con_mId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvConceptCitationEN_js_1.clsvConceptCitationEN.con_mId, objvConceptCitation_Cond.mId, strComparisonOp_mId);
        }
        if (Object.prototype.hasOwnProperty.call(objvConceptCitation_Cond.dicFldComparisonOp, clsvConceptCitationEN_js_1.clsvConceptCitationEN.con_PaperId) == true) {
            const strComparisonOp_PaperId = objvConceptCitation_Cond.dicFldComparisonOp[clsvConceptCitationEN_js_1.clsvConceptCitationEN.con_PaperId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvConceptCitationEN_js_1.clsvConceptCitationEN.con_PaperId, objvConceptCitation_Cond.paperId, strComparisonOp_PaperId);
        }
        if (Object.prototype.hasOwnProperty.call(objvConceptCitation_Cond.dicFldComparisonOp, clsvConceptCitationEN_js_1.clsvConceptCitationEN.con_PaperTitle) == true) {
            const strComparisonOp_PaperTitle = objvConceptCitation_Cond.dicFldComparisonOp[clsvConceptCitationEN_js_1.clsvConceptCitationEN.con_PaperTitle];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvConceptCitationEN_js_1.clsvConceptCitationEN.con_PaperTitle, objvConceptCitation_Cond.paperTitle, strComparisonOp_PaperTitle);
        }
        //数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
        if (Object.prototype.hasOwnProperty.call(objvConceptCitation_Cond.dicFldComparisonOp, clsvConceptCitationEN_js_1.clsvConceptCitationEN.con_UserName) == true) {
            const strComparisonOp_UserName = objvConceptCitation_Cond.dicFldComparisonOp[clsvConceptCitationEN_js_1.clsvConceptCitationEN.con_UserName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvConceptCitationEN_js_1.clsvConceptCitationEN.con_UserName, objvConceptCitation_Cond.userName, strComparisonOp_UserName);
        }
        if (Object.prototype.hasOwnProperty.call(objvConceptCitation_Cond.dicFldComparisonOp, clsvConceptCitationEN_js_1.clsvConceptCitationEN.con_UpdUserId) == true) {
            const strComparisonOp_UpdUserId = objvConceptCitation_Cond.dicFldComparisonOp[clsvConceptCitationEN_js_1.clsvConceptCitationEN.con_UpdUserId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvConceptCitationEN_js_1.clsvConceptCitationEN.con_UpdUserId, objvConceptCitation_Cond.updUserId, strComparisonOp_UpdUserId);
        }
        if (Object.prototype.hasOwnProperty.call(objvConceptCitation_Cond.dicFldComparisonOp, clsvConceptCitationEN_js_1.clsvConceptCitationEN.con_TopicId) == true) {
            const strComparisonOp_TopicId = objvConceptCitation_Cond.dicFldComparisonOp[clsvConceptCitationEN_js_1.clsvConceptCitationEN.con_TopicId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvConceptCitationEN_js_1.clsvConceptCitationEN.con_TopicId, objvConceptCitation_Cond.topicId, strComparisonOp_TopicId);
        }
        if (Object.prototype.hasOwnProperty.call(objvConceptCitation_Cond.dicFldComparisonOp, clsvConceptCitationEN_js_1.clsvConceptCitationEN.con_TopicName) == true) {
            const strComparisonOp_TopicName = objvConceptCitation_Cond.dicFldComparisonOp[clsvConceptCitationEN_js_1.clsvConceptCitationEN.con_TopicName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvConceptCitationEN_js_1.clsvConceptCitationEN.con_TopicName, objvConceptCitation_Cond.topicName, strComparisonOp_TopicName);
        }
        return strWhereCond;
    }
    exports.vConceptCitation_GetCombineCondition = vConceptCitation_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--vConceptCitation(vConceptCitation),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param lngmId: mId(要求唯一的字段)
    * @param strConceptId: 概念Id(要求唯一的字段)
    * @param strPaperId: 论文Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function vConceptCitation_GetUniCondStr_mId_ConceptId_PaperId(objvConceptCitationEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and mId = '{0}'", objvConceptCitationEN.mId);
        strWhereCond += (0, clsString_js_1.Format)(" and ConceptId = '{0}'", objvConceptCitationEN.conceptId);
        strWhereCond += (0, clsString_js_1.Format)(" and PaperId = '{0}'", objvConceptCitationEN.paperId);
        return strWhereCond;
    }
    exports.vConceptCitation_GetUniCondStr_mId_ConceptId_PaperId = vConceptCitation_GetUniCondStr_mId_ConceptId_PaperId;
    /**
    *获取唯一性条件串(Uniqueness)--vConceptCitation(vConceptCitation),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param lngmId: mId(要求唯一的字段)
    * @param strConceptId: 概念Id(要求唯一的字段)
    * @param strPaperId: 论文Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function vConceptCitation_GetUniCondStr4Update_mId_ConceptId_PaperId(objvConceptCitationEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and mId <> '{0}'", objvConceptCitationEN.mId);
        strWhereCond += (0, clsString_js_1.Format)(" and mId = '{0}'", objvConceptCitationEN.mId);
        strWhereCond += (0, clsString_js_1.Format)(" and ConceptId = '{0}'", objvConceptCitationEN.conceptId);
        strWhereCond += (0, clsString_js_1.Format)(" and PaperId = '{0}'", objvConceptCitationEN.paperId);
        return strWhereCond;
    }
    exports.vConceptCitation_GetUniCondStr4Update_mId_ConceptId_PaperId = vConceptCitation_GetUniCondStr4Update_mId_ConceptId_PaperId;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objvConceptCitationENS:源对象
     * @param objvConceptCitationENT:目标对象
    */
    function vConceptCitation_CopyObjTo(objvConceptCitationENS, objvConceptCitationENT) {
        objvConceptCitationENT.conceptContent = objvConceptCitationENS.conceptContent; //概念内容
        objvConceptCitationENT.conceptId = objvConceptCitationENS.conceptId; //概念Id
        objvConceptCitationENT.conceptName = objvConceptCitationENS.conceptName; //概念名称
        objvConceptCitationENT.updDate = objvConceptCitationENS.updDate; //修改日期
        objvConceptCitationENT.mId = objvConceptCitationENS.mId; //mId
        objvConceptCitationENT.paperId = objvConceptCitationENS.paperId; //论文Id
        objvConceptCitationENT.paperTitle = objvConceptCitationENS.paperTitle; //论文标题
        objvConceptCitationENT.paperContent = objvConceptCitationENS.paperContent; //主题内容
        objvConceptCitationENT.userName = objvConceptCitationENS.userName; //用户名
        objvConceptCitationENT.updUserId = objvConceptCitationENS.updUserId; //修改用户Id
        objvConceptCitationENT.topicId = objvConceptCitationENS.topicId; //主题Id
        objvConceptCitationENT.topicName = objvConceptCitationENS.topicName; //栏目主题
    }
    exports.vConceptCitation_CopyObjTo = vConceptCitation_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objvConceptCitationENS:源对象
     * @param objvConceptCitationENT:目标对象
    */
    function vConceptCitation_GetObjFromJsonObj(objvConceptCitationENS) {
        const objvConceptCitationENT = new clsvConceptCitationEN_js_1.clsvConceptCitationEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvConceptCitationENT, objvConceptCitationENS);
        return objvConceptCitationENT;
    }
    exports.vConceptCitation_GetObjFromJsonObj = vConceptCitation_GetObjFromJsonObj;
});
