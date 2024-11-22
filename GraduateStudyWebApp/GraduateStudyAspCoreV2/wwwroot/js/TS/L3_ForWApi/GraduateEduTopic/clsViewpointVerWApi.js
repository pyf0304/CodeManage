/**
* 类名:clsViewpointVerWApi
* 表名:ViewpointVer(01120650)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/13 00:48:22
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
        define(["require", "exports", "axios", "../../L0_Entity/GraduateEduTopic/clsViewpointVerEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.ViewpointVer_GetObjFromJsonObj = exports.ViewpointVer_CopyObjTo = exports.ViewpointVer_GetUniCondStr4Update_ViewpointVId = exports.ViewpointVer_GetUniCondStr_ViewpointVId = exports.ViewpointVer_GetCombineCondition = exports.ViewpointVer_GetObjByJSONStr = exports.ViewpointVer_GetObjLstByJSONObjLst = exports.ViewpointVer_GetObjLstByJSONStr = exports.ViewpointVer_GetJSONStrByObj = exports.ViewpointVer_CheckProperty4Update = exports.ViewpointVer_CheckPropertyNew = exports.ViewpointVer_GetWebApiUrl = exports.ViewpointVer_GetMaxStrIdByPrefix = exports.ViewpointVer_GetRecCountByCondAsync = exports.ViewpointVer_IsExistAsync = exports.ViewpointVer_IsExist = exports.ViewpointVer_IsExistRecordAsync = exports.ViewpointVer_UpdateWithConditionAsync = exports.ViewpointVer_UpdateRecordAsync = exports.ViewpointVer_AddNewRecordWithReturnKey = exports.ViewpointVer_AddNewRecordWithReturnKeyAsync = exports.ViewpointVer_AddNewRecordAsync = exports.ViewpointVer_DelViewpointVersByCondAsync = exports.ViewpointVer_DelViewpointVersAsync = exports.ViewpointVer_DelRecordAsync = exports.ViewpointVer_GetObjLstByPagerAsync = exports.ViewpointVer_GetObjLstByRange = exports.ViewpointVer_GetObjLstByRangeAsync = exports.ViewpointVer_GetTopObjLstAsync = exports.ViewpointVer_GetObjLstByViewpointVIdLstAsync = exports.ViewpointVer_GetObjLstAsync = exports.ViewpointVer_GetFirstObjAsync = exports.ViewpointVer_GetFirstID = exports.ViewpointVer_GetFirstIDAsync = exports.ViewpointVer_FilterFunByKey = exports.ViewpointVer_SortFunByKey = exports.ViewpointVer_SortFun_Defa_2Fld = exports.ViewpointVer_SortFun_Defa = exports.ViewpointVer_GetObjByViewpointVIdAsync = exports.viewpointVer_ConstructorName = exports.viewpointVer_Controller = void 0;
    /**
     * 观点版本表(ViewpointVer)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月13日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const clsViewpointVerEN_js_1 = require("../../L0_Entity/GraduateEduTopic/clsViewpointVerEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsString_js_2 = require("../../PubFun/clsString.js");
    exports.viewpointVer_Controller = "ViewpointVerApi";
    exports.viewpointVer_ConstructorName = "viewpointVer";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param lngViewpointVId:关键字
    * @returns 对象
    **/
    async function ViewpointVer_GetObjByViewpointVIdAsync(lngViewpointVId) {
        const strThisFuncName = "GetObjByViewpointVIdAsync";
        if (lngViewpointVId == 0) {
            const strMsg = (0, clsString_js_2.Format)("参数:[lngViewpointVId]不能为空！(In clsViewpointVerWApi.GetObjByViewpointVIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByViewpointVId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointVer_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "lngViewpointVId": lngViewpointVId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    return null;
                }
                //console.log(returnObj);
                const objViewpointVer = ViewpointVer_GetObjFromJsonObj(returnObj);
                return objViewpointVer;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointVer_GetObjByViewpointVIdAsync = ViewpointVer_GetObjByViewpointVIdAsync;
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
    function ViewpointVer_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.viewpointVId - b.viewpointVId;
    }
    exports.ViewpointVer_SortFun_Defa = ViewpointVer_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function ViewpointVer_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.viewpointId == b.viewpointId)
            return a.viewpointName.localeCompare(b.viewpointName);
        else
            return a.viewpointId.localeCompare(b.viewpointId);
    }
    exports.ViewpointVer_SortFun_Defa_2Fld = ViewpointVer_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function ViewpointVer_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsViewpointVerEN_js_1.clsViewpointVerEN.con_ViewpointVId:
                    return (a, b) => {
                        return a.viewpointVId - b.viewpointVId;
                    };
                case clsViewpointVerEN_js_1.clsViewpointVerEN.con_ViewpointId:
                    return (a, b) => {
                        return a.viewpointId.localeCompare(b.viewpointId);
                    };
                case clsViewpointVerEN_js_1.clsViewpointVerEN.con_ViewpointName:
                    return (a, b) => {
                        if (a.viewpointName == null)
                            return -1;
                        if (b.viewpointName == null)
                            return 1;
                        return a.viewpointName.localeCompare(b.viewpointName);
                    };
                case clsViewpointVerEN_js_1.clsViewpointVerEN.con_ViewpointContent:
                    return (a, b) => {
                        if (a.viewpointContent == null)
                            return -1;
                        if (b.viewpointContent == null)
                            return 1;
                        return a.viewpointContent.localeCompare(b.viewpointContent);
                    };
                case clsViewpointVerEN_js_1.clsViewpointVerEN.con_ViewpointTypeId:
                    return (a, b) => {
                        if (a.viewpointTypeId == null)
                            return -1;
                        if (b.viewpointTypeId == null)
                            return 1;
                        return a.viewpointTypeId.localeCompare(b.viewpointTypeId);
                    };
                case clsViewpointVerEN_js_1.clsViewpointVerEN.con_Reason:
                    return (a, b) => {
                        if (a.reason == null)
                            return -1;
                        if (b.reason == null)
                            return 1;
                        return a.reason.localeCompare(b.reason);
                    };
                case clsViewpointVerEN_js_1.clsViewpointVerEN.con_Source:
                    return (a, b) => {
                        if (a.source == null)
                            return -1;
                        if (b.source == null)
                            return 1;
                        return a.source.localeCompare(b.source);
                    };
                case clsViewpointVerEN_js_1.clsViewpointVerEN.con_VPProposePeople:
                    return (a, b) => {
                        if (a.vpProposePeople == null)
                            return -1;
                        if (b.vpProposePeople == null)
                            return 1;
                        return a.vpProposePeople.localeCompare(b.vpProposePeople);
                    };
                case clsViewpointVerEN_js_1.clsViewpointVerEN.con_UserTypeId:
                    return (a, b) => {
                        if (a.userTypeId == null)
                            return -1;
                        if (b.userTypeId == null)
                            return 1;
                        return a.userTypeId.localeCompare(b.userTypeId);
                    };
                case clsViewpointVerEN_js_1.clsViewpointVerEN.con_CitationId:
                    return (a, b) => {
                        if (a.citationId == null)
                            return -1;
                        if (b.citationId == null)
                            return 1;
                        return a.citationId.localeCompare(b.citationId);
                    };
                case clsViewpointVerEN_js_1.clsViewpointVerEN.con_UpdDate:
                    return (a, b) => {
                        if (a.updDate == null)
                            return -1;
                        if (b.updDate == null)
                            return 1;
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsViewpointVerEN_js_1.clsViewpointVerEN.con_UpdUser:
                    return (a, b) => {
                        if (a.updUser == null)
                            return -1;
                        if (b.updUser == null)
                            return 1;
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsViewpointVerEN_js_1.clsViewpointVerEN.con_PdfContent:
                    return (a, b) => {
                        if (a.pdfContent == null)
                            return -1;
                        if (b.pdfContent == null)
                            return 1;
                        return a.pdfContent.localeCompare(b.pdfContent);
                    };
                case clsViewpointVerEN_js_1.clsViewpointVerEN.con_PdfPageNum:
                    return (a, b) => {
                        return a.pdfPageNum - b.pdfPageNum;
                    };
                case clsViewpointVerEN_js_1.clsViewpointVerEN.con_id_CurrEduCls:
                    return (a, b) => {
                        if (a.id_CurrEduCls == null)
                            return -1;
                        if (b.id_CurrEduCls == null)
                            return 1;
                        return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
                    };
                case clsViewpointVerEN_js_1.clsViewpointVerEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[ViewpointVer]中不存在！(in ${exports.viewpointVer_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsViewpointVerEN_js_1.clsViewpointVerEN.con_ViewpointVId:
                    return (a, b) => {
                        return b.viewpointVId - a.viewpointVId;
                    };
                case clsViewpointVerEN_js_1.clsViewpointVerEN.con_ViewpointId:
                    return (a, b) => {
                        return b.viewpointId.localeCompare(a.viewpointId);
                    };
                case clsViewpointVerEN_js_1.clsViewpointVerEN.con_ViewpointName:
                    return (a, b) => {
                        if (b.viewpointName == null)
                            return -1;
                        if (a.viewpointName == null)
                            return 1;
                        return b.viewpointName.localeCompare(a.viewpointName);
                    };
                case clsViewpointVerEN_js_1.clsViewpointVerEN.con_ViewpointContent:
                    return (a, b) => {
                        if (b.viewpointContent == null)
                            return -1;
                        if (a.viewpointContent == null)
                            return 1;
                        return b.viewpointContent.localeCompare(a.viewpointContent);
                    };
                case clsViewpointVerEN_js_1.clsViewpointVerEN.con_ViewpointTypeId:
                    return (a, b) => {
                        if (b.viewpointTypeId == null)
                            return -1;
                        if (a.viewpointTypeId == null)
                            return 1;
                        return b.viewpointTypeId.localeCompare(a.viewpointTypeId);
                    };
                case clsViewpointVerEN_js_1.clsViewpointVerEN.con_Reason:
                    return (a, b) => {
                        if (b.reason == null)
                            return -1;
                        if (a.reason == null)
                            return 1;
                        return b.reason.localeCompare(a.reason);
                    };
                case clsViewpointVerEN_js_1.clsViewpointVerEN.con_Source:
                    return (a, b) => {
                        if (b.source == null)
                            return -1;
                        if (a.source == null)
                            return 1;
                        return b.source.localeCompare(a.source);
                    };
                case clsViewpointVerEN_js_1.clsViewpointVerEN.con_VPProposePeople:
                    return (a, b) => {
                        if (b.vpProposePeople == null)
                            return -1;
                        if (a.vpProposePeople == null)
                            return 1;
                        return b.vpProposePeople.localeCompare(a.vpProposePeople);
                    };
                case clsViewpointVerEN_js_1.clsViewpointVerEN.con_UserTypeId:
                    return (a, b) => {
                        if (b.userTypeId == null)
                            return -1;
                        if (a.userTypeId == null)
                            return 1;
                        return b.userTypeId.localeCompare(a.userTypeId);
                    };
                case clsViewpointVerEN_js_1.clsViewpointVerEN.con_CitationId:
                    return (a, b) => {
                        if (b.citationId == null)
                            return -1;
                        if (a.citationId == null)
                            return 1;
                        return b.citationId.localeCompare(a.citationId);
                    };
                case clsViewpointVerEN_js_1.clsViewpointVerEN.con_UpdDate:
                    return (a, b) => {
                        if (b.updDate == null)
                            return -1;
                        if (a.updDate == null)
                            return 1;
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsViewpointVerEN_js_1.clsViewpointVerEN.con_UpdUser:
                    return (a, b) => {
                        if (b.updUser == null)
                            return -1;
                        if (a.updUser == null)
                            return 1;
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsViewpointVerEN_js_1.clsViewpointVerEN.con_PdfContent:
                    return (a, b) => {
                        if (b.pdfContent == null)
                            return -1;
                        if (a.pdfContent == null)
                            return 1;
                        return b.pdfContent.localeCompare(a.pdfContent);
                    };
                case clsViewpointVerEN_js_1.clsViewpointVerEN.con_PdfPageNum:
                    return (a, b) => {
                        return b.pdfPageNum - a.pdfPageNum;
                    };
                case clsViewpointVerEN_js_1.clsViewpointVerEN.con_id_CurrEduCls:
                    return (a, b) => {
                        if (b.id_CurrEduCls == null)
                            return -1;
                        if (a.id_CurrEduCls == null)
                            return 1;
                        return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
                    };
                case clsViewpointVerEN_js_1.clsViewpointVerEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[ViewpointVer]中不存在！(in ${exports.viewpointVer_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.ViewpointVer_SortFunByKey = ViewpointVer_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function ViewpointVer_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsViewpointVerEN_js_1.clsViewpointVerEN.con_ViewpointVId:
                return (obj) => {
                    return obj.viewpointVId === value;
                };
            case clsViewpointVerEN_js_1.clsViewpointVerEN.con_ViewpointId:
                return (obj) => {
                    return obj.viewpointId === value;
                };
            case clsViewpointVerEN_js_1.clsViewpointVerEN.con_ViewpointName:
                return (obj) => {
                    return obj.viewpointName === value;
                };
            case clsViewpointVerEN_js_1.clsViewpointVerEN.con_ViewpointContent:
                return (obj) => {
                    return obj.viewpointContent === value;
                };
            case clsViewpointVerEN_js_1.clsViewpointVerEN.con_ViewpointTypeId:
                return (obj) => {
                    return obj.viewpointTypeId === value;
                };
            case clsViewpointVerEN_js_1.clsViewpointVerEN.con_Reason:
                return (obj) => {
                    return obj.reason === value;
                };
            case clsViewpointVerEN_js_1.clsViewpointVerEN.con_Source:
                return (obj) => {
                    return obj.source === value;
                };
            case clsViewpointVerEN_js_1.clsViewpointVerEN.con_VPProposePeople:
                return (obj) => {
                    return obj.vpProposePeople === value;
                };
            case clsViewpointVerEN_js_1.clsViewpointVerEN.con_UserTypeId:
                return (obj) => {
                    return obj.userTypeId === value;
                };
            case clsViewpointVerEN_js_1.clsViewpointVerEN.con_CitationId:
                return (obj) => {
                    return obj.citationId === value;
                };
            case clsViewpointVerEN_js_1.clsViewpointVerEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsViewpointVerEN_js_1.clsViewpointVerEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsViewpointVerEN_js_1.clsViewpointVerEN.con_PdfContent:
                return (obj) => {
                    return obj.pdfContent === value;
                };
            case clsViewpointVerEN_js_1.clsViewpointVerEN.con_PdfPageNum:
                return (obj) => {
                    return obj.pdfPageNum === value;
                };
            case clsViewpointVerEN_js_1.clsViewpointVerEN.con_id_CurrEduCls:
                return (obj) => {
                    return obj.id_CurrEduCls === value;
                };
            case clsViewpointVerEN_js_1.clsViewpointVerEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[ViewpointVer]中不存在！(in ${exports.viewpointVer_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.ViewpointVer_FilterFunByKey = ViewpointVer_FilterFunByKey;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function ViewpointVer_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointVer_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointVer_GetFirstIDAsync = ViewpointVer_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function ViewpointVer_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointVer_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointVer_GetFirstID = ViewpointVer_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function ViewpointVer_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointVer_Controller, strAction);
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
                const objViewpointVer = ViewpointVer_GetObjFromJsonObj(returnObj);
                return objViewpointVer;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointVer_GetFirstObjAsync = ViewpointVer_GetFirstObjAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function ViewpointVer_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointVer_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.viewpointVer_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = ViewpointVer_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointVer_GetObjLstAsync = ViewpointVer_GetObjLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrViewpointVId:关键字列表
    * @returns 对象列表
    **/
    async function ViewpointVer_GetObjLstByViewpointVIdLstAsync(arrViewpointVId) {
        const strThisFuncName = "GetObjLstByViewpointVIdLstAsync";
        const strAction = "GetObjLstByViewpointVIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointVer_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrViewpointVId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.viewpointVer_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = ViewpointVer_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointVer_GetObjLstByViewpointVIdLstAsync = ViewpointVer_GetObjLstByViewpointVIdLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function ViewpointVer_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointVer_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.viewpointVer_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = ViewpointVer_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointVer_GetTopObjLstAsync = ViewpointVer_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function ViewpointVer_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointVer_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.viewpointVer_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = ViewpointVer_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointVer_GetObjLstByRangeAsync = ViewpointVer_GetObjLstByRangeAsync;
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
    async function ViewpointVer_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointVer_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointVer_GetObjLstByRange = ViewpointVer_GetObjLstByRange;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function ViewpointVer_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointVer_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.viewpointVer_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = ViewpointVer_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointVer_GetObjLstByPagerAsync = ViewpointVer_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param lngViewpointVId:关键字
    * @returns 获取删除的结果
    **/
    async function ViewpointVer_DelRecordAsync(lngViewpointVId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointVer_Controller, strAction);
        strUrl = (0, clsString_js_2.Format)("{0}/?Id={1}", strUrl, lngViewpointVId);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointVer_DelRecordAsync = ViewpointVer_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrViewpointVId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function ViewpointVer_DelViewpointVersAsync(arrViewpointVId) {
        const strThisFuncName = "DelViewpointVersAsync";
        const strAction = "DelViewpointVers";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointVer_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrViewpointVId);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointVer_DelViewpointVersAsync = ViewpointVer_DelViewpointVersAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function ViewpointVer_DelViewpointVersByCondAsync(strWhereCond) {
        const strThisFuncName = "DelViewpointVersByCondAsync";
        const strAction = "DelViewpointVersByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointVer_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointVer_DelViewpointVersByCondAsync = ViewpointVer_DelViewpointVersByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objViewpointVerEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function ViewpointVer_AddNewRecordAsync(objViewpointVerEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objViewpointVerEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointVer_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objViewpointVerEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointVer_AddNewRecordAsync = ViewpointVer_AddNewRecordAsync;
    /* 数据类型不是字符型，不可以最大关键字的方式添加记录。*/
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objViewpointVerEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function ViewpointVer_AddNewRecordWithReturnKeyAsync(objViewpointVerEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointVer_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objViewpointVerEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointVer_AddNewRecordWithReturnKeyAsync = ViewpointVer_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objViewpointVerEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function ViewpointVer_AddNewRecordWithReturnKey(objViewpointVerEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objViewpointVerEN.viewpointVId === null || objViewpointVerEN.viewpointVId === 0) {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointVer_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objViewpointVerEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointVer_AddNewRecordWithReturnKey = ViewpointVer_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objViewpointVerEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function ViewpointVer_UpdateRecordAsync(objViewpointVerEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objViewpointVerEN.sf_UpdFldSetStr === undefined || objViewpointVerEN.sf_UpdFldSetStr === null || objViewpointVerEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objViewpointVerEN.viewpointVId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointVer_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objViewpointVerEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointVer_UpdateRecordAsync = ViewpointVer_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objViewpointVerEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function ViewpointVer_UpdateWithConditionAsync(objViewpointVerEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objViewpointVerEN.sf_UpdFldSetStr === undefined || objViewpointVerEN.sf_UpdFldSetStr === null || objViewpointVerEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objViewpointVerEN.viewpointVId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointVer_Controller, strAction);
        objViewpointVerEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objViewpointVerEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointVer_UpdateWithConditionAsync = ViewpointVer_UpdateWithConditionAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function ViewpointVer_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointVer_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointVer_IsExistRecordAsync = ViewpointVer_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param lngViewpointVId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function ViewpointVer_IsExist(lngViewpointVId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointVer_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "ViewpointVId": lngViewpointVId,
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointVer_IsExist = ViewpointVer_IsExist;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param lngViewpointVId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function ViewpointVer_IsExistAsync(lngViewpointVId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointVer_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "lngViewpointVId": lngViewpointVId }
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointVer_IsExistAsync = ViewpointVer_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function ViewpointVer_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointVer_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointVer_GetRecCountByCondAsync = ViewpointVer_GetRecCountByCondAsync;
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
    async function ViewpointVer_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointVer_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointVer_GetMaxStrIdByPrefix = ViewpointVer_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function ViewpointVer_GetWebApiUrl(strController, strAction) {
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
    exports.ViewpointVer_GetWebApiUrl = ViewpointVer_GetWebApiUrl;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function ViewpointVer_CheckPropertyNew(pobjViewpointVerEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjViewpointVerEN.viewpointId) === true) {
            throw new Error("(errid:Watl000058)字段[观点Id]不能为空(In 观点版本表)!(clsViewpointVerBL:CheckPropertyNew)");
        }
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjViewpointVerEN.viewpointId) == false && (0, clsString_js_2.GetStrLen)(pobjViewpointVerEN.viewpointId) > 8) {
            throw new Error("(errid:Watl000059)字段[观点Id(viewpointId)]的长度不能超过8(In 观点版本表(ViewpointVer))!值:$(pobjViewpointVerEN.viewpointId)(clsViewpointVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjViewpointVerEN.viewpointName) == false && (0, clsString_js_2.GetStrLen)(pobjViewpointVerEN.viewpointName) > 500) {
            throw new Error("(errid:Watl000059)字段[观点名称(viewpointName)]的长度不能超过500(In 观点版本表(ViewpointVer))!值:$(pobjViewpointVerEN.viewpointName)(clsViewpointVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjViewpointVerEN.viewpointTypeId) == false && (0, clsString_js_2.GetStrLen)(pobjViewpointVerEN.viewpointTypeId) > 4) {
            throw new Error("(errid:Watl000059)字段[观点类型Id(viewpointTypeId)]的长度不能超过4(In 观点版本表(ViewpointVer))!值:$(pobjViewpointVerEN.viewpointTypeId)(clsViewpointVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjViewpointVerEN.source) == false && (0, clsString_js_2.GetStrLen)(pobjViewpointVerEN.source) > 500) {
            throw new Error("(errid:Watl000059)字段[来源(source)]的长度不能超过500(In 观点版本表(ViewpointVer))!值:$(pobjViewpointVerEN.source)(clsViewpointVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjViewpointVerEN.vpProposePeople) == false && (0, clsString_js_2.GetStrLen)(pobjViewpointVerEN.vpProposePeople) > 50) {
            throw new Error("(errid:Watl000059)字段[观点提出人(vpProposePeople)]的长度不能超过50(In 观点版本表(ViewpointVer))!值:$(pobjViewpointVerEN.vpProposePeople)(clsViewpointVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjViewpointVerEN.userTypeId) == false && (0, clsString_js_2.GetStrLen)(pobjViewpointVerEN.userTypeId) > 2) {
            throw new Error("(errid:Watl000059)字段[用户类型Id(userTypeId)]的长度不能超过2(In 观点版本表(ViewpointVer))!值:$(pobjViewpointVerEN.userTypeId)(clsViewpointVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjViewpointVerEN.citationId) == false && (0, clsString_js_2.GetStrLen)(pobjViewpointVerEN.citationId) > 8) {
            throw new Error("(errid:Watl000059)字段[引用Id(citationId)]的长度不能超过8(In 观点版本表(ViewpointVer))!值:$(pobjViewpointVerEN.citationId)(clsViewpointVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjViewpointVerEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjViewpointVerEN.updDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 观点版本表(ViewpointVer))!值:$(pobjViewpointVerEN.updDate)(clsViewpointVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjViewpointVerEN.updUser) == false && (0, clsString_js_2.GetStrLen)(pobjViewpointVerEN.updUser) > 20) {
            throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 观点版本表(ViewpointVer))!值:$(pobjViewpointVerEN.updUser)(clsViewpointVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjViewpointVerEN.pdfContent) == false && (0, clsString_js_2.GetStrLen)(pobjViewpointVerEN.pdfContent) > 2000) {
            throw new Error("(errid:Watl000059)字段[Pdf内容(pdfContent)]的长度不能超过2000(In 观点版本表(ViewpointVer))!值:$(pobjViewpointVerEN.pdfContent)(clsViewpointVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjViewpointVerEN.id_CurrEduCls) == false && (0, clsString_js_2.GetStrLen)(pobjViewpointVerEN.id_CurrEduCls) > 8) {
            throw new Error("(errid:Watl000059)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 观点版本表(ViewpointVer))!值:$(pobjViewpointVerEN.id_CurrEduCls)(clsViewpointVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjViewpointVerEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjViewpointVerEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 观点版本表(ViewpointVer))!值:$(pobjViewpointVerEN.memo)(clsViewpointVerBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if (null != pobjViewpointVerEN.viewpointVId && undefined !== pobjViewpointVerEN.viewpointVId && clsString_js_1.tzDataType.isNumber(pobjViewpointVerEN.viewpointVId) === false) {
            throw new Error("(errid:Watl000060)字段[ViewpointVId(viewpointVId)]的值:[$(pobjViewpointVerEN.viewpointVId)], 非法，应该为数值型(In 观点版本表(ViewpointVer))!(clsViewpointVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjViewpointVerEN.viewpointId) == false && undefined !== pobjViewpointVerEN.viewpointId && clsString_js_1.tzDataType.isString(pobjViewpointVerEN.viewpointId) === false) {
            throw new Error("(errid:Watl000060)字段[观点Id(viewpointId)]的值:[$(pobjViewpointVerEN.viewpointId)], 非法，应该为字符型(In 观点版本表(ViewpointVer))!(clsViewpointVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjViewpointVerEN.viewpointName) == false && undefined !== pobjViewpointVerEN.viewpointName && clsString_js_1.tzDataType.isString(pobjViewpointVerEN.viewpointName) === false) {
            throw new Error("(errid:Watl000060)字段[观点名称(viewpointName)]的值:[$(pobjViewpointVerEN.viewpointName)], 非法，应该为字符型(In 观点版本表(ViewpointVer))!(clsViewpointVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjViewpointVerEN.viewpointContent) == false && undefined !== pobjViewpointVerEN.viewpointContent && clsString_js_1.tzDataType.isString(pobjViewpointVerEN.viewpointContent) === false) {
            throw new Error("(errid:Watl000060)字段[观点内容(viewpointContent)]的值:[$(pobjViewpointVerEN.viewpointContent)], 非法，应该为字符型(In 观点版本表(ViewpointVer))!(clsViewpointVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjViewpointVerEN.viewpointTypeId) == false && undefined !== pobjViewpointVerEN.viewpointTypeId && clsString_js_1.tzDataType.isString(pobjViewpointVerEN.viewpointTypeId) === false) {
            throw new Error("(errid:Watl000060)字段[观点类型Id(viewpointTypeId)]的值:[$(pobjViewpointVerEN.viewpointTypeId)], 非法，应该为字符型(In 观点版本表(ViewpointVer))!(clsViewpointVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjViewpointVerEN.reason) == false && undefined !== pobjViewpointVerEN.reason && clsString_js_1.tzDataType.isString(pobjViewpointVerEN.reason) === false) {
            throw new Error("(errid:Watl000060)字段[理由(reason)]的值:[$(pobjViewpointVerEN.reason)], 非法，应该为字符型(In 观点版本表(ViewpointVer))!(clsViewpointVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjViewpointVerEN.source) == false && undefined !== pobjViewpointVerEN.source && clsString_js_1.tzDataType.isString(pobjViewpointVerEN.source) === false) {
            throw new Error("(errid:Watl000060)字段[来源(source)]的值:[$(pobjViewpointVerEN.source)], 非法，应该为字符型(In 观点版本表(ViewpointVer))!(clsViewpointVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjViewpointVerEN.vpProposePeople) == false && undefined !== pobjViewpointVerEN.vpProposePeople && clsString_js_1.tzDataType.isString(pobjViewpointVerEN.vpProposePeople) === false) {
            throw new Error("(errid:Watl000060)字段[观点提出人(vpProposePeople)]的值:[$(pobjViewpointVerEN.vpProposePeople)], 非法，应该为字符型(In 观点版本表(ViewpointVer))!(clsViewpointVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjViewpointVerEN.userTypeId) == false && undefined !== pobjViewpointVerEN.userTypeId && clsString_js_1.tzDataType.isString(pobjViewpointVerEN.userTypeId) === false) {
            throw new Error("(errid:Watl000060)字段[用户类型Id(userTypeId)]的值:[$(pobjViewpointVerEN.userTypeId)], 非法，应该为字符型(In 观点版本表(ViewpointVer))!(clsViewpointVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjViewpointVerEN.citationId) == false && undefined !== pobjViewpointVerEN.citationId && clsString_js_1.tzDataType.isString(pobjViewpointVerEN.citationId) === false) {
            throw new Error("(errid:Watl000060)字段[引用Id(citationId)]的值:[$(pobjViewpointVerEN.citationId)], 非法，应该为字符型(In 观点版本表(ViewpointVer))!(clsViewpointVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjViewpointVerEN.updDate) == false && undefined !== pobjViewpointVerEN.updDate && clsString_js_1.tzDataType.isString(pobjViewpointVerEN.updDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjViewpointVerEN.updDate)], 非法，应该为字符型(In 观点版本表(ViewpointVer))!(clsViewpointVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjViewpointVerEN.updUser) == false && undefined !== pobjViewpointVerEN.updUser && clsString_js_1.tzDataType.isString(pobjViewpointVerEN.updUser) === false) {
            throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjViewpointVerEN.updUser)], 非法，应该为字符型(In 观点版本表(ViewpointVer))!(clsViewpointVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjViewpointVerEN.pdfContent) == false && undefined !== pobjViewpointVerEN.pdfContent && clsString_js_1.tzDataType.isString(pobjViewpointVerEN.pdfContent) === false) {
            throw new Error("(errid:Watl000060)字段[Pdf内容(pdfContent)]的值:[$(pobjViewpointVerEN.pdfContent)], 非法，应该为字符型(In 观点版本表(ViewpointVer))!(clsViewpointVerBL:CheckPropertyNew)");
        }
        if (null != pobjViewpointVerEN.pdfPageNum && undefined !== pobjViewpointVerEN.pdfPageNum && clsString_js_1.tzDataType.isNumber(pobjViewpointVerEN.pdfPageNum) === false) {
            throw new Error("(errid:Watl000060)字段[Pdf页码(pdfPageNum)]的值:[$(pobjViewpointVerEN.pdfPageNum)], 非法，应该为数值型(In 观点版本表(ViewpointVer))!(clsViewpointVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjViewpointVerEN.id_CurrEduCls) == false && undefined !== pobjViewpointVerEN.id_CurrEduCls && clsString_js_1.tzDataType.isString(pobjViewpointVerEN.id_CurrEduCls) === false) {
            throw new Error("(errid:Watl000060)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjViewpointVerEN.id_CurrEduCls)], 非法，应该为字符型(In 观点版本表(ViewpointVer))!(clsViewpointVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjViewpointVerEN.memo) == false && undefined !== pobjViewpointVerEN.memo && clsString_js_1.tzDataType.isString(pobjViewpointVerEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjViewpointVerEN.memo)], 非法，应该为字符型(In 观点版本表(ViewpointVer))!(clsViewpointVerBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjViewpointVerEN.SetIsCheckProperty(true);
    }
    exports.ViewpointVer_CheckPropertyNew = ViewpointVer_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function ViewpointVer_CheckProperty4Update(pobjViewpointVerEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjViewpointVerEN.viewpointId) == false && (0, clsString_js_2.GetStrLen)(pobjViewpointVerEN.viewpointId) > 8) {
            throw new Error("(errid:Watl000062)字段[观点Id(viewpointId)]的长度不能超过8(In 观点版本表(ViewpointVer))!值:$(pobjViewpointVerEN.viewpointId)(clsViewpointVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjViewpointVerEN.viewpointName) == false && (0, clsString_js_2.GetStrLen)(pobjViewpointVerEN.viewpointName) > 500) {
            throw new Error("(errid:Watl000062)字段[观点名称(viewpointName)]的长度不能超过500(In 观点版本表(ViewpointVer))!值:$(pobjViewpointVerEN.viewpointName)(clsViewpointVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjViewpointVerEN.viewpointTypeId) == false && (0, clsString_js_2.GetStrLen)(pobjViewpointVerEN.viewpointTypeId) > 4) {
            throw new Error("(errid:Watl000062)字段[观点类型Id(viewpointTypeId)]的长度不能超过4(In 观点版本表(ViewpointVer))!值:$(pobjViewpointVerEN.viewpointTypeId)(clsViewpointVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjViewpointVerEN.source) == false && (0, clsString_js_2.GetStrLen)(pobjViewpointVerEN.source) > 500) {
            throw new Error("(errid:Watl000062)字段[来源(source)]的长度不能超过500(In 观点版本表(ViewpointVer))!值:$(pobjViewpointVerEN.source)(clsViewpointVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjViewpointVerEN.vpProposePeople) == false && (0, clsString_js_2.GetStrLen)(pobjViewpointVerEN.vpProposePeople) > 50) {
            throw new Error("(errid:Watl000062)字段[观点提出人(vpProposePeople)]的长度不能超过50(In 观点版本表(ViewpointVer))!值:$(pobjViewpointVerEN.vpProposePeople)(clsViewpointVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjViewpointVerEN.userTypeId) == false && (0, clsString_js_2.GetStrLen)(pobjViewpointVerEN.userTypeId) > 2) {
            throw new Error("(errid:Watl000062)字段[用户类型Id(userTypeId)]的长度不能超过2(In 观点版本表(ViewpointVer))!值:$(pobjViewpointVerEN.userTypeId)(clsViewpointVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjViewpointVerEN.citationId) == false && (0, clsString_js_2.GetStrLen)(pobjViewpointVerEN.citationId) > 8) {
            throw new Error("(errid:Watl000062)字段[引用Id(citationId)]的长度不能超过8(In 观点版本表(ViewpointVer))!值:$(pobjViewpointVerEN.citationId)(clsViewpointVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjViewpointVerEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjViewpointVerEN.updDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 观点版本表(ViewpointVer))!值:$(pobjViewpointVerEN.updDate)(clsViewpointVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjViewpointVerEN.updUser) == false && (0, clsString_js_2.GetStrLen)(pobjViewpointVerEN.updUser) > 20) {
            throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 观点版本表(ViewpointVer))!值:$(pobjViewpointVerEN.updUser)(clsViewpointVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjViewpointVerEN.pdfContent) == false && (0, clsString_js_2.GetStrLen)(pobjViewpointVerEN.pdfContent) > 2000) {
            throw new Error("(errid:Watl000062)字段[Pdf内容(pdfContent)]的长度不能超过2000(In 观点版本表(ViewpointVer))!值:$(pobjViewpointVerEN.pdfContent)(clsViewpointVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjViewpointVerEN.id_CurrEduCls) == false && (0, clsString_js_2.GetStrLen)(pobjViewpointVerEN.id_CurrEduCls) > 8) {
            throw new Error("(errid:Watl000062)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 观点版本表(ViewpointVer))!值:$(pobjViewpointVerEN.id_CurrEduCls)(clsViewpointVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjViewpointVerEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjViewpointVerEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 观点版本表(ViewpointVer))!值:$(pobjViewpointVerEN.memo)(clsViewpointVerBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if (null != pobjViewpointVerEN.viewpointVId && undefined !== pobjViewpointVerEN.viewpointVId && clsString_js_1.tzDataType.isNumber(pobjViewpointVerEN.viewpointVId) === false) {
            throw new Error("(errid:Watl000063)字段[ViewpointVId(viewpointVId)]的值:[$(pobjViewpointVerEN.viewpointVId)], 非法，应该为数值型(In 观点版本表(ViewpointVer))!(clsViewpointVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjViewpointVerEN.viewpointId) == false && undefined !== pobjViewpointVerEN.viewpointId && clsString_js_1.tzDataType.isString(pobjViewpointVerEN.viewpointId) === false) {
            throw new Error("(errid:Watl000063)字段[观点Id(viewpointId)]的值:[$(pobjViewpointVerEN.viewpointId)], 非法，应该为字符型(In 观点版本表(ViewpointVer))!(clsViewpointVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjViewpointVerEN.viewpointName) == false && undefined !== pobjViewpointVerEN.viewpointName && clsString_js_1.tzDataType.isString(pobjViewpointVerEN.viewpointName) === false) {
            throw new Error("(errid:Watl000063)字段[观点名称(viewpointName)]的值:[$(pobjViewpointVerEN.viewpointName)], 非法，应该为字符型(In 观点版本表(ViewpointVer))!(clsViewpointVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjViewpointVerEN.viewpointContent) == false && undefined !== pobjViewpointVerEN.viewpointContent && clsString_js_1.tzDataType.isString(pobjViewpointVerEN.viewpointContent) === false) {
            throw new Error("(errid:Watl000063)字段[观点内容(viewpointContent)]的值:[$(pobjViewpointVerEN.viewpointContent)], 非法，应该为字符型(In 观点版本表(ViewpointVer))!(clsViewpointVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjViewpointVerEN.viewpointTypeId) == false && undefined !== pobjViewpointVerEN.viewpointTypeId && clsString_js_1.tzDataType.isString(pobjViewpointVerEN.viewpointTypeId) === false) {
            throw new Error("(errid:Watl000063)字段[观点类型Id(viewpointTypeId)]的值:[$(pobjViewpointVerEN.viewpointTypeId)], 非法，应该为字符型(In 观点版本表(ViewpointVer))!(clsViewpointVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjViewpointVerEN.reason) == false && undefined !== pobjViewpointVerEN.reason && clsString_js_1.tzDataType.isString(pobjViewpointVerEN.reason) === false) {
            throw new Error("(errid:Watl000063)字段[理由(reason)]的值:[$(pobjViewpointVerEN.reason)], 非法，应该为字符型(In 观点版本表(ViewpointVer))!(clsViewpointVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjViewpointVerEN.source) == false && undefined !== pobjViewpointVerEN.source && clsString_js_1.tzDataType.isString(pobjViewpointVerEN.source) === false) {
            throw new Error("(errid:Watl000063)字段[来源(source)]的值:[$(pobjViewpointVerEN.source)], 非法，应该为字符型(In 观点版本表(ViewpointVer))!(clsViewpointVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjViewpointVerEN.vpProposePeople) == false && undefined !== pobjViewpointVerEN.vpProposePeople && clsString_js_1.tzDataType.isString(pobjViewpointVerEN.vpProposePeople) === false) {
            throw new Error("(errid:Watl000063)字段[观点提出人(vpProposePeople)]的值:[$(pobjViewpointVerEN.vpProposePeople)], 非法，应该为字符型(In 观点版本表(ViewpointVer))!(clsViewpointVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjViewpointVerEN.userTypeId) == false && undefined !== pobjViewpointVerEN.userTypeId && clsString_js_1.tzDataType.isString(pobjViewpointVerEN.userTypeId) === false) {
            throw new Error("(errid:Watl000063)字段[用户类型Id(userTypeId)]的值:[$(pobjViewpointVerEN.userTypeId)], 非法，应该为字符型(In 观点版本表(ViewpointVer))!(clsViewpointVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjViewpointVerEN.citationId) == false && undefined !== pobjViewpointVerEN.citationId && clsString_js_1.tzDataType.isString(pobjViewpointVerEN.citationId) === false) {
            throw new Error("(errid:Watl000063)字段[引用Id(citationId)]的值:[$(pobjViewpointVerEN.citationId)], 非法，应该为字符型(In 观点版本表(ViewpointVer))!(clsViewpointVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjViewpointVerEN.updDate) == false && undefined !== pobjViewpointVerEN.updDate && clsString_js_1.tzDataType.isString(pobjViewpointVerEN.updDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjViewpointVerEN.updDate)], 非法，应该为字符型(In 观点版本表(ViewpointVer))!(clsViewpointVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjViewpointVerEN.updUser) == false && undefined !== pobjViewpointVerEN.updUser && clsString_js_1.tzDataType.isString(pobjViewpointVerEN.updUser) === false) {
            throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjViewpointVerEN.updUser)], 非法，应该为字符型(In 观点版本表(ViewpointVer))!(clsViewpointVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjViewpointVerEN.pdfContent) == false && undefined !== pobjViewpointVerEN.pdfContent && clsString_js_1.tzDataType.isString(pobjViewpointVerEN.pdfContent) === false) {
            throw new Error("(errid:Watl000063)字段[Pdf内容(pdfContent)]的值:[$(pobjViewpointVerEN.pdfContent)], 非法，应该为字符型(In 观点版本表(ViewpointVer))!(clsViewpointVerBL:CheckProperty4Update)");
        }
        if (null != pobjViewpointVerEN.pdfPageNum && undefined !== pobjViewpointVerEN.pdfPageNum && clsString_js_1.tzDataType.isNumber(pobjViewpointVerEN.pdfPageNum) === false) {
            throw new Error("(errid:Watl000063)字段[Pdf页码(pdfPageNum)]的值:[$(pobjViewpointVerEN.pdfPageNum)], 非法，应该为数值型(In 观点版本表(ViewpointVer))!(clsViewpointVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjViewpointVerEN.id_CurrEduCls) == false && undefined !== pobjViewpointVerEN.id_CurrEduCls && clsString_js_1.tzDataType.isString(pobjViewpointVerEN.id_CurrEduCls) === false) {
            throw new Error("(errid:Watl000063)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjViewpointVerEN.id_CurrEduCls)], 非法，应该为字符型(In 观点版本表(ViewpointVer))!(clsViewpointVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjViewpointVerEN.memo) == false && undefined !== pobjViewpointVerEN.memo && clsString_js_1.tzDataType.isString(pobjViewpointVerEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjViewpointVerEN.memo)], 非法，应该为字符型(In 观点版本表(ViewpointVer))!(clsViewpointVerBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if (null === pobjViewpointVerEN.viewpointVId
            || pobjViewpointVerEN.viewpointVId != null && pobjViewpointVerEN.viewpointVId.toString() === "") {
            throw new Error("(errid:Watl000064)字段[ViewpointVId]不能为空(In 观点版本表)!(clsViewpointVerBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjViewpointVerEN.SetIsCheckProperty(true);
    }
    exports.ViewpointVer_CheckProperty4Update = ViewpointVer_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function ViewpointVer_GetJSONStrByObj(pobjViewpointVerEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjViewpointVerEN.sf_UpdFldSetStr = pobjViewpointVerEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjViewpointVerEN);
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
    exports.ViewpointVer_GetJSONStrByObj = ViewpointVer_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function ViewpointVer_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrViewpointVerObjLst = new Array();
        if (strJSON === "") {
            return arrViewpointVerObjLst;
        }
        try {
            arrViewpointVerObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrViewpointVerObjLst;
        }
        return arrViewpointVerObjLst;
    }
    exports.ViewpointVer_GetObjLstByJSONStr = ViewpointVer_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrViewpointVerObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function ViewpointVer_GetObjLstByJSONObjLst(arrViewpointVerObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrViewpointVerObjLst = new Array();
        for (const objInFor of arrViewpointVerObjLstS) {
            const obj1 = ViewpointVer_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrViewpointVerObjLst.push(obj1);
        }
        return arrViewpointVerObjLst;
    }
    exports.ViewpointVer_GetObjLstByJSONObjLst = ViewpointVer_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function ViewpointVer_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjViewpointVerEN = new clsViewpointVerEN_js_1.clsViewpointVerEN();
        if (strJSON === "") {
            return pobjViewpointVerEN;
        }
        try {
            pobjViewpointVerEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjViewpointVerEN;
        }
        return pobjViewpointVerEN;
    }
    exports.ViewpointVer_GetObjByJSONStr = ViewpointVer_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function ViewpointVer_GetCombineCondition(objViewpointVer_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objViewpointVer_Cond.dicFldComparisonOp, clsViewpointVerEN_js_1.clsViewpointVerEN.con_ViewpointVId) == true) {
            const strComparisonOp_ViewpointVId = objViewpointVer_Cond.dicFldComparisonOp[clsViewpointVerEN_js_1.clsViewpointVerEN.con_ViewpointVId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsViewpointVerEN_js_1.clsViewpointVerEN.con_ViewpointVId, objViewpointVer_Cond.viewpointVId, strComparisonOp_ViewpointVId);
        }
        if (Object.prototype.hasOwnProperty.call(objViewpointVer_Cond.dicFldComparisonOp, clsViewpointVerEN_js_1.clsViewpointVerEN.con_ViewpointId) == true) {
            const strComparisonOp_ViewpointId = objViewpointVer_Cond.dicFldComparisonOp[clsViewpointVerEN_js_1.clsViewpointVerEN.con_ViewpointId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsViewpointVerEN_js_1.clsViewpointVerEN.con_ViewpointId, objViewpointVer_Cond.viewpointId, strComparisonOp_ViewpointId);
        }
        if (Object.prototype.hasOwnProperty.call(objViewpointVer_Cond.dicFldComparisonOp, clsViewpointVerEN_js_1.clsViewpointVerEN.con_ViewpointName) == true) {
            const strComparisonOp_ViewpointName = objViewpointVer_Cond.dicFldComparisonOp[clsViewpointVerEN_js_1.clsViewpointVerEN.con_ViewpointName];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsViewpointVerEN_js_1.clsViewpointVerEN.con_ViewpointName, objViewpointVer_Cond.viewpointName, strComparisonOp_ViewpointName);
        }
        //数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
        if (Object.prototype.hasOwnProperty.call(objViewpointVer_Cond.dicFldComparisonOp, clsViewpointVerEN_js_1.clsViewpointVerEN.con_ViewpointTypeId) == true) {
            const strComparisonOp_ViewpointTypeId = objViewpointVer_Cond.dicFldComparisonOp[clsViewpointVerEN_js_1.clsViewpointVerEN.con_ViewpointTypeId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsViewpointVerEN_js_1.clsViewpointVerEN.con_ViewpointTypeId, objViewpointVer_Cond.viewpointTypeId, strComparisonOp_ViewpointTypeId);
        }
        //数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
        if (Object.prototype.hasOwnProperty.call(objViewpointVer_Cond.dicFldComparisonOp, clsViewpointVerEN_js_1.clsViewpointVerEN.con_Source) == true) {
            const strComparisonOp_Source = objViewpointVer_Cond.dicFldComparisonOp[clsViewpointVerEN_js_1.clsViewpointVerEN.con_Source];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsViewpointVerEN_js_1.clsViewpointVerEN.con_Source, objViewpointVer_Cond.source, strComparisonOp_Source);
        }
        if (Object.prototype.hasOwnProperty.call(objViewpointVer_Cond.dicFldComparisonOp, clsViewpointVerEN_js_1.clsViewpointVerEN.con_VPProposePeople) == true) {
            const strComparisonOp_VPProposePeople = objViewpointVer_Cond.dicFldComparisonOp[clsViewpointVerEN_js_1.clsViewpointVerEN.con_VPProposePeople];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsViewpointVerEN_js_1.clsViewpointVerEN.con_VPProposePeople, objViewpointVer_Cond.vpProposePeople, strComparisonOp_VPProposePeople);
        }
        if (Object.prototype.hasOwnProperty.call(objViewpointVer_Cond.dicFldComparisonOp, clsViewpointVerEN_js_1.clsViewpointVerEN.con_UserTypeId) == true) {
            const strComparisonOp_UserTypeId = objViewpointVer_Cond.dicFldComparisonOp[clsViewpointVerEN_js_1.clsViewpointVerEN.con_UserTypeId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsViewpointVerEN_js_1.clsViewpointVerEN.con_UserTypeId, objViewpointVer_Cond.userTypeId, strComparisonOp_UserTypeId);
        }
        if (Object.prototype.hasOwnProperty.call(objViewpointVer_Cond.dicFldComparisonOp, clsViewpointVerEN_js_1.clsViewpointVerEN.con_CitationId) == true) {
            const strComparisonOp_CitationId = objViewpointVer_Cond.dicFldComparisonOp[clsViewpointVerEN_js_1.clsViewpointVerEN.con_CitationId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsViewpointVerEN_js_1.clsViewpointVerEN.con_CitationId, objViewpointVer_Cond.citationId, strComparisonOp_CitationId);
        }
        if (Object.prototype.hasOwnProperty.call(objViewpointVer_Cond.dicFldComparisonOp, clsViewpointVerEN_js_1.clsViewpointVerEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objViewpointVer_Cond.dicFldComparisonOp[clsViewpointVerEN_js_1.clsViewpointVerEN.con_UpdDate];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsViewpointVerEN_js_1.clsViewpointVerEN.con_UpdDate, objViewpointVer_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objViewpointVer_Cond.dicFldComparisonOp, clsViewpointVerEN_js_1.clsViewpointVerEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objViewpointVer_Cond.dicFldComparisonOp[clsViewpointVerEN_js_1.clsViewpointVerEN.con_UpdUser];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsViewpointVerEN_js_1.clsViewpointVerEN.con_UpdUser, objViewpointVer_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objViewpointVer_Cond.dicFldComparisonOp, clsViewpointVerEN_js_1.clsViewpointVerEN.con_PdfContent) == true) {
            const strComparisonOp_PdfContent = objViewpointVer_Cond.dicFldComparisonOp[clsViewpointVerEN_js_1.clsViewpointVerEN.con_PdfContent];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsViewpointVerEN_js_1.clsViewpointVerEN.con_PdfContent, objViewpointVer_Cond.pdfContent, strComparisonOp_PdfContent);
        }
        if (Object.prototype.hasOwnProperty.call(objViewpointVer_Cond.dicFldComparisonOp, clsViewpointVerEN_js_1.clsViewpointVerEN.con_PdfPageNum) == true) {
            const strComparisonOp_PdfPageNum = objViewpointVer_Cond.dicFldComparisonOp[clsViewpointVerEN_js_1.clsViewpointVerEN.con_PdfPageNum];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsViewpointVerEN_js_1.clsViewpointVerEN.con_PdfPageNum, objViewpointVer_Cond.pdfPageNum, strComparisonOp_PdfPageNum);
        }
        if (Object.prototype.hasOwnProperty.call(objViewpointVer_Cond.dicFldComparisonOp, clsViewpointVerEN_js_1.clsViewpointVerEN.con_id_CurrEduCls) == true) {
            const strComparisonOp_id_CurrEduCls = objViewpointVer_Cond.dicFldComparisonOp[clsViewpointVerEN_js_1.clsViewpointVerEN.con_id_CurrEduCls];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsViewpointVerEN_js_1.clsViewpointVerEN.con_id_CurrEduCls, objViewpointVer_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
        }
        if (Object.prototype.hasOwnProperty.call(objViewpointVer_Cond.dicFldComparisonOp, clsViewpointVerEN_js_1.clsViewpointVerEN.con_Memo) == true) {
            const strComparisonOp_Memo = objViewpointVer_Cond.dicFldComparisonOp[clsViewpointVerEN_js_1.clsViewpointVerEN.con_Memo];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsViewpointVerEN_js_1.clsViewpointVerEN.con_Memo, objViewpointVer_Cond.memo, strComparisonOp_Memo);
        }
        return strWhereCond;
    }
    exports.ViewpointVer_GetCombineCondition = ViewpointVer_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--ViewpointVer(观点版本表),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param lngViewpointVId: ViewpointVId(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function ViewpointVer_GetUniCondStr_ViewpointVId(objViewpointVerEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and ViewpointVId = '{0}'", objViewpointVerEN.viewpointVId);
        return strWhereCond;
    }
    exports.ViewpointVer_GetUniCondStr_ViewpointVId = ViewpointVer_GetUniCondStr_ViewpointVId;
    /**
    *获取唯一性条件串(Uniqueness)--ViewpointVer(观点版本表),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param lngViewpointVId: ViewpointVId(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function ViewpointVer_GetUniCondStr4Update_ViewpointVId(objViewpointVerEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and ViewpointVId <> '{0}'", objViewpointVerEN.viewpointVId);
        strWhereCond += (0, clsString_js_2.Format)(" and ViewpointVId = '{0}'", objViewpointVerEN.viewpointVId);
        return strWhereCond;
    }
    exports.ViewpointVer_GetUniCondStr4Update_ViewpointVId = ViewpointVer_GetUniCondStr4Update_ViewpointVId;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objViewpointVerENS:源对象
     * @param objViewpointVerENT:目标对象
    */
    function ViewpointVer_CopyObjTo(objViewpointVerENS, objViewpointVerENT) {
        objViewpointVerENT.viewpointVId = objViewpointVerENS.viewpointVId; //ViewpointVId
        objViewpointVerENT.viewpointId = objViewpointVerENS.viewpointId; //观点Id
        objViewpointVerENT.viewpointName = objViewpointVerENS.viewpointName; //观点名称
        objViewpointVerENT.viewpointContent = objViewpointVerENS.viewpointContent; //观点内容
        objViewpointVerENT.viewpointTypeId = objViewpointVerENS.viewpointTypeId; //观点类型Id
        objViewpointVerENT.reason = objViewpointVerENS.reason; //理由
        objViewpointVerENT.source = objViewpointVerENS.source; //来源
        objViewpointVerENT.vpProposePeople = objViewpointVerENS.vpProposePeople; //观点提出人
        objViewpointVerENT.userTypeId = objViewpointVerENS.userTypeId; //用户类型Id
        objViewpointVerENT.citationId = objViewpointVerENS.citationId; //引用Id
        objViewpointVerENT.updDate = objViewpointVerENS.updDate; //修改日期
        objViewpointVerENT.updUser = objViewpointVerENS.updUser; //修改人
        objViewpointVerENT.pdfContent = objViewpointVerENS.pdfContent; //Pdf内容
        objViewpointVerENT.pdfPageNum = objViewpointVerENS.pdfPageNum; //Pdf页码
        objViewpointVerENT.id_CurrEduCls = objViewpointVerENS.id_CurrEduCls; //教学班流水号
        objViewpointVerENT.memo = objViewpointVerENS.memo; //备注
        objViewpointVerENT.sf_UpdFldSetStr = objViewpointVerENS.updFldString; //sf_UpdFldSetStr
    }
    exports.ViewpointVer_CopyObjTo = ViewpointVer_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objViewpointVerENS:源对象
     * @param objViewpointVerENT:目标对象
    */
    function ViewpointVer_GetObjFromJsonObj(objViewpointVerENS) {
        const objViewpointVerENT = new clsViewpointVerEN_js_1.clsViewpointVerEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objViewpointVerENT, objViewpointVerENS);
        return objViewpointVerENT;
    }
    exports.ViewpointVer_GetObjFromJsonObj = ViewpointVer_GetObjFromJsonObj;
});
