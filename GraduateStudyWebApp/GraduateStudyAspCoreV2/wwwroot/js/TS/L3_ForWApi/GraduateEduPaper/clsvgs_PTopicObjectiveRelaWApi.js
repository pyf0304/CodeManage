/**
* 类名:clsvgs_PTopicObjectiveRelaWApi
* 表名:vgs_PTopicObjectiveRela(01120667)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/13 00:46:02
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
        define(["require", "exports", "axios", "../../L0_Entity/GraduateEduPaper/clsvgs_PTopicObjectiveRelaEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.vgs_PTopicObjectiveRela_GetObjFromJsonObj = exports.vgs_PTopicObjectiveRela_CopyObjTo = exports.vgs_PTopicObjectiveRela_GetCombineCondition = exports.vgs_PTopicObjectiveRela_GetObjByJSONStr = exports.vgs_PTopicObjectiveRela_GetObjLstByJSONObjLst = exports.vgs_PTopicObjectiveRela_GetObjLstByJSONStr = exports.vgs_PTopicObjectiveRela_GetJSONStrByObj = exports.vgs_PTopicObjectiveRela_GetWebApiUrl = exports.vgs_PTopicObjectiveRela_GetRecCountByCondAsync = exports.vgs_PTopicObjectiveRela_IsExistAsync = exports.vgs_PTopicObjectiveRela_IsExist = exports.vgs_PTopicObjectiveRela_IsExistRecordAsync = exports.vgs_PTopicObjectiveRela_GetObjLstByPagerAsync = exports.vgs_PTopicObjectiveRela_GetObjLstByRange = exports.vgs_PTopicObjectiveRela_GetObjLstByRangeAsync = exports.vgs_PTopicObjectiveRela_GetTopObjLstAsync = exports.vgs_PTopicObjectiveRela_GetObjLstBymIdLstAsync = exports.vgs_PTopicObjectiveRela_GetObjLstAsync = exports.vgs_PTopicObjectiveRela_GetFirstObjAsync = exports.vgs_PTopicObjectiveRela_GetFirstID = exports.vgs_PTopicObjectiveRela_GetFirstIDAsync = exports.vgs_PTopicObjectiveRela_FilterFunByKey = exports.vgs_PTopicObjectiveRela_SortFunByKey = exports.vgs_PTopicObjectiveRela_SortFun_Defa_2Fld = exports.vgs_PTopicObjectiveRela_SortFun_Defa = exports.vgs_PTopicObjectiveRela_GetObjBymIdAsync = exports.vgs_PTopicObjectiveRela_ConstructorName = exports.vgs_PTopicObjectiveRela_Controller = void 0;
    /**
     * 论文客观关系视图(vgs_PTopicObjectiveRela)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月13日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const clsvgs_PTopicObjectiveRelaEN_js_1 = require("../../L0_Entity/GraduateEduPaper/clsvgs_PTopicObjectiveRelaEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.vgs_PTopicObjectiveRela_Controller = "vgs_PTopicObjectiveRelaApi";
    exports.vgs_PTopicObjectiveRela_ConstructorName = "vgs_PTopicObjectiveRela";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param lngmId:关键字
    * @returns 对象
    **/
    async function vgs_PTopicObjectiveRela_GetObjBymIdAsync(lngmId) {
        const strThisFuncName = "GetObjBymIdAsync";
        if (lngmId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngmId]不能为空！(In clsvgs_PTopicObjectiveRelaWApi.GetObjBymIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjBymId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PTopicObjectiveRela_Controller, strAction);
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
                const objvgs_PTopicObjectiveRela = vgs_PTopicObjectiveRela_GetObjFromJsonObj(returnObj);
                return objvgs_PTopicObjectiveRela;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PTopicObjectiveRela_GetObjBymIdAsync = vgs_PTopicObjectiveRela_GetObjBymIdAsync;
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
    function vgs_PTopicObjectiveRela_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.mId - b.mId;
    }
    exports.vgs_PTopicObjectiveRela_SortFun_Defa = vgs_PTopicObjectiveRela_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vgs_PTopicObjectiveRela_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.paperId == b.paperId)
            return a.paperTitle.localeCompare(b.paperTitle);
        else
            return a.paperId.localeCompare(b.paperId);
    }
    exports.vgs_PTopicObjectiveRela_SortFun_Defa_2Fld = vgs_PTopicObjectiveRela_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vgs_PTopicObjectiveRela_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_mId:
                    return (a, b) => {
                        return a.mId - b.mId;
                    };
                case clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_PaperId:
                    return (a, b) => {
                        return a.paperId.localeCompare(b.paperId);
                    };
                case clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_PaperTitle:
                    return (a, b) => {
                        if (a.paperTitle == null)
                            return -1;
                        if (b.paperTitle == null)
                            return 1;
                        return a.paperTitle.localeCompare(b.paperTitle);
                    };
                case clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_PaperTypeId:
                    return (a, b) => {
                        if (a.paperTypeId == null)
                            return -1;
                        if (b.paperTypeId == null)
                            return 1;
                        return a.paperTypeId.localeCompare(b.paperTypeId);
                    };
                case clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_SectionId:
                    return (a, b) => {
                        if (a.sectionId == null)
                            return -1;
                        if (b.sectionId == null)
                            return 1;
                        return a.sectionId.localeCompare(b.sectionId);
                    };
                case clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_SectionName:
                    return (a, b) => {
                        if (a.sectionName == null)
                            return -1;
                        if (b.sectionName == null)
                            return 1;
                        return a.sectionName.localeCompare(b.sectionName);
                    };
                case clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_TopicObjectiveId:
                    return (a, b) => {
                        return a.topicObjectiveId.localeCompare(b.topicObjectiveId);
                    };
                case clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_ObjectiveName:
                    return (a, b) => {
                        if (a.objectiveName == null)
                            return -1;
                        if (b.objectiveName == null)
                            return 1;
                        return a.objectiveName.localeCompare(b.objectiveName);
                    };
                case clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_ObjectiveContent:
                    return (a, b) => {
                        if (a.objectiveContent == null)
                            return -1;
                        if (b.objectiveContent == null)
                            return 1;
                        return a.objectiveContent.localeCompare(b.objectiveContent);
                    };
                case clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_ObjectiveType:
                    return (a, b) => {
                        if (a.objectiveType == null)
                            return -1;
                        if (b.objectiveType == null)
                            return 1;
                        return a.objectiveType.localeCompare(b.objectiveType);
                    };
                case clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_IsSubmit:
                    return (a, b) => {
                        if (a.isSubmit == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_ObjectiveTypeName:
                    return (a, b) => {
                        if (a.objectiveTypeName == null)
                            return -1;
                        if (b.objectiveTypeName == null)
                            return 1;
                        return a.objectiveTypeName.localeCompare(b.objectiveTypeName);
                    };
                case clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_TeaScore:
                    return (a, b) => {
                        return a.teaScore - b.teaScore;
                    };
                case clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_StuScore:
                    return (a, b) => {
                        return a.stuScore - b.stuScore;
                    };
                case clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_Score:
                    return (a, b) => {
                        return a.score - b.score;
                    };
                case clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_AppraiseCount:
                    return (a, b) => {
                        return a.appraiseCount - b.appraiseCount;
                    };
                case clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_OkCount:
                    return (a, b) => {
                        return a.okCount - b.okCount;
                    };
                case clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_VersionCount:
                    return (a, b) => {
                        return a.versionCount - b.versionCount;
                    };
                case clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_CitationCount:
                    return (a, b) => {
                        return a.citationCount - b.citationCount;
                    };
                case clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_UpdDate:
                    return (a, b) => {
                        if (a.updDate == null)
                            return -1;
                        if (b.updDate == null)
                            return 1;
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_UpdUser:
                    return (a, b) => {
                        if (a.updUser == null)
                            return -1;
                        if (b.updUser == null)
                            return 1;
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                case clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_ObjUserId:
                    return (a, b) => {
                        if (a.objUserId == null)
                            return -1;
                        if (b.objUserId == null)
                            return 1;
                        return a.objUserId.localeCompare(b.objUserId);
                    };
                case clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_ObjDate:
                    return (a, b) => {
                        if (a.objDate == null)
                            return -1;
                        if (b.objDate == null)
                            return 1;
                        return a.objDate.localeCompare(b.objDate);
                    };
                case clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_Conclusion:
                    return (a, b) => {
                        if (a.conclusion == null)
                            return -1;
                        if (b.conclusion == null)
                            return 1;
                        return a.conclusion.localeCompare(b.conclusion);
                    };
                case clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_CreateDate:
                    return (a, b) => {
                        if (a.createDate == null)
                            return -1;
                        if (b.createDate == null)
                            return 1;
                        return a.createDate.localeCompare(b.createDate);
                    };
                case clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_ShareId:
                    return (a, b) => {
                        if (a.shareId == null)
                            return -1;
                        if (b.shareId == null)
                            return 1;
                        return a.shareId.localeCompare(b.shareId);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vgs_PTopicObjectiveRela]中不存在！(in ${exports.vgs_PTopicObjectiveRela_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_mId:
                    return (a, b) => {
                        return b.mId - a.mId;
                    };
                case clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_PaperId:
                    return (a, b) => {
                        return b.paperId.localeCompare(a.paperId);
                    };
                case clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_PaperTitle:
                    return (a, b) => {
                        if (b.paperTitle == null)
                            return -1;
                        if (a.paperTitle == null)
                            return 1;
                        return b.paperTitle.localeCompare(a.paperTitle);
                    };
                case clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_PaperTypeId:
                    return (a, b) => {
                        if (b.paperTypeId == null)
                            return -1;
                        if (a.paperTypeId == null)
                            return 1;
                        return b.paperTypeId.localeCompare(a.paperTypeId);
                    };
                case clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_SectionId:
                    return (a, b) => {
                        if (b.sectionId == null)
                            return -1;
                        if (a.sectionId == null)
                            return 1;
                        return b.sectionId.localeCompare(a.sectionId);
                    };
                case clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_SectionName:
                    return (a, b) => {
                        if (b.sectionName == null)
                            return -1;
                        if (a.sectionName == null)
                            return 1;
                        return b.sectionName.localeCompare(a.sectionName);
                    };
                case clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_TopicObjectiveId:
                    return (a, b) => {
                        return b.topicObjectiveId.localeCompare(a.topicObjectiveId);
                    };
                case clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_ObjectiveName:
                    return (a, b) => {
                        if (b.objectiveName == null)
                            return -1;
                        if (a.objectiveName == null)
                            return 1;
                        return b.objectiveName.localeCompare(a.objectiveName);
                    };
                case clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_ObjectiveContent:
                    return (a, b) => {
                        if (b.objectiveContent == null)
                            return -1;
                        if (a.objectiveContent == null)
                            return 1;
                        return b.objectiveContent.localeCompare(a.objectiveContent);
                    };
                case clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_ObjectiveType:
                    return (a, b) => {
                        if (b.objectiveType == null)
                            return -1;
                        if (a.objectiveType == null)
                            return 1;
                        return b.objectiveType.localeCompare(a.objectiveType);
                    };
                case clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_IsSubmit:
                    return (a, b) => {
                        if (b.isSubmit == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_ObjectiveTypeName:
                    return (a, b) => {
                        if (b.objectiveTypeName == null)
                            return -1;
                        if (a.objectiveTypeName == null)
                            return 1;
                        return b.objectiveTypeName.localeCompare(a.objectiveTypeName);
                    };
                case clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_TeaScore:
                    return (a, b) => {
                        return b.teaScore - a.teaScore;
                    };
                case clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_StuScore:
                    return (a, b) => {
                        return b.stuScore - a.stuScore;
                    };
                case clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_Score:
                    return (a, b) => {
                        return b.score - a.score;
                    };
                case clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_AppraiseCount:
                    return (a, b) => {
                        return b.appraiseCount - a.appraiseCount;
                    };
                case clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_OkCount:
                    return (a, b) => {
                        return b.okCount - a.okCount;
                    };
                case clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_VersionCount:
                    return (a, b) => {
                        return b.versionCount - a.versionCount;
                    };
                case clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_CitationCount:
                    return (a, b) => {
                        return b.citationCount - a.citationCount;
                    };
                case clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_UpdDate:
                    return (a, b) => {
                        if (b.updDate == null)
                            return -1;
                        if (a.updDate == null)
                            return 1;
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_UpdUser:
                    return (a, b) => {
                        if (b.updUser == null)
                            return -1;
                        if (a.updUser == null)
                            return 1;
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                case clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_ObjUserId:
                    return (a, b) => {
                        if (b.objUserId == null)
                            return -1;
                        if (a.objUserId == null)
                            return 1;
                        return b.objUserId.localeCompare(a.objUserId);
                    };
                case clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_ObjDate:
                    return (a, b) => {
                        if (b.objDate == null)
                            return -1;
                        if (a.objDate == null)
                            return 1;
                        return b.objDate.localeCompare(a.objDate);
                    };
                case clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_Conclusion:
                    return (a, b) => {
                        if (b.conclusion == null)
                            return -1;
                        if (a.conclusion == null)
                            return 1;
                        return b.conclusion.localeCompare(a.conclusion);
                    };
                case clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_CreateDate:
                    return (a, b) => {
                        if (b.createDate == null)
                            return -1;
                        if (a.createDate == null)
                            return 1;
                        return b.createDate.localeCompare(a.createDate);
                    };
                case clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_ShareId:
                    return (a, b) => {
                        if (b.shareId == null)
                            return -1;
                        if (a.shareId == null)
                            return 1;
                        return b.shareId.localeCompare(a.shareId);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vgs_PTopicObjectiveRela]中不存在！(in ${exports.vgs_PTopicObjectiveRela_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.vgs_PTopicObjectiveRela_SortFunByKey = vgs_PTopicObjectiveRela_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function vgs_PTopicObjectiveRela_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_mId:
                return (obj) => {
                    return obj.mId === value;
                };
            case clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_PaperId:
                return (obj) => {
                    return obj.paperId === value;
                };
            case clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_PaperTitle:
                return (obj) => {
                    return obj.paperTitle === value;
                };
            case clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_PaperTypeId:
                return (obj) => {
                    return obj.paperTypeId === value;
                };
            case clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_SectionId:
                return (obj) => {
                    return obj.sectionId === value;
                };
            case clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_SectionName:
                return (obj) => {
                    return obj.sectionName === value;
                };
            case clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_TopicObjectiveId:
                return (obj) => {
                    return obj.topicObjectiveId === value;
                };
            case clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_ObjectiveName:
                return (obj) => {
                    return obj.objectiveName === value;
                };
            case clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_ObjectiveContent:
                return (obj) => {
                    return obj.objectiveContent === value;
                };
            case clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_ObjectiveType:
                return (obj) => {
                    return obj.objectiveType === value;
                };
            case clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_IsSubmit:
                return (obj) => {
                    return obj.isSubmit === value;
                };
            case clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_ObjectiveTypeName:
                return (obj) => {
                    return obj.objectiveTypeName === value;
                };
            case clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_TeaScore:
                return (obj) => {
                    return obj.teaScore === value;
                };
            case clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_StuScore:
                return (obj) => {
                    return obj.stuScore === value;
                };
            case clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_Score:
                return (obj) => {
                    return obj.score === value;
                };
            case clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_AppraiseCount:
                return (obj) => {
                    return obj.appraiseCount === value;
                };
            case clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_OkCount:
                return (obj) => {
                    return obj.okCount === value;
                };
            case clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_VersionCount:
                return (obj) => {
                    return obj.versionCount === value;
                };
            case clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_CitationCount:
                return (obj) => {
                    return obj.citationCount === value;
                };
            case clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            case clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_ObjUserId:
                return (obj) => {
                    return obj.objUserId === value;
                };
            case clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_ObjDate:
                return (obj) => {
                    return obj.objDate === value;
                };
            case clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_Conclusion:
                return (obj) => {
                    return obj.conclusion === value;
                };
            case clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_CreateDate:
                return (obj) => {
                    return obj.createDate === value;
                };
            case clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_ShareId:
                return (obj) => {
                    return obj.shareId === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[vgs_PTopicObjectiveRela]中不存在！(in ${exports.vgs_PTopicObjectiveRela_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.vgs_PTopicObjectiveRela_FilterFunByKey = vgs_PTopicObjectiveRela_FilterFunByKey;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function vgs_PTopicObjectiveRela_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PTopicObjectiveRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PTopicObjectiveRela_GetFirstIDAsync = vgs_PTopicObjectiveRela_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function vgs_PTopicObjectiveRela_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PTopicObjectiveRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PTopicObjectiveRela_GetFirstID = vgs_PTopicObjectiveRela_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function vgs_PTopicObjectiveRela_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PTopicObjectiveRela_Controller, strAction);
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
                const objvgs_PTopicObjectiveRela = vgs_PTopicObjectiveRela_GetObjFromJsonObj(returnObj);
                return objvgs_PTopicObjectiveRela;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PTopicObjectiveRela_GetFirstObjAsync = vgs_PTopicObjectiveRela_GetFirstObjAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function vgs_PTopicObjectiveRela_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PTopicObjectiveRela_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vgs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vgs_PTopicObjectiveRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PTopicObjectiveRela_GetObjLstAsync = vgs_PTopicObjectiveRela_GetObjLstAsync;
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
    async function vgs_PTopicObjectiveRela_GetObjLstBymIdLstAsync(arrmId) {
        const strThisFuncName = "GetObjLstBymIdLstAsync";
        const strAction = "GetObjLstBymIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PTopicObjectiveRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrmId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vgs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vgs_PTopicObjectiveRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PTopicObjectiveRela_GetObjLstBymIdLstAsync = vgs_PTopicObjectiveRela_GetObjLstBymIdLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function vgs_PTopicObjectiveRela_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PTopicObjectiveRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vgs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vgs_PTopicObjectiveRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PTopicObjectiveRela_GetTopObjLstAsync = vgs_PTopicObjectiveRela_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vgs_PTopicObjectiveRela_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PTopicObjectiveRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vgs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vgs_PTopicObjectiveRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PTopicObjectiveRela_GetObjLstByRangeAsync = vgs_PTopicObjectiveRela_GetObjLstByRangeAsync;
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
    async function vgs_PTopicObjectiveRela_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PTopicObjectiveRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PTopicObjectiveRela_GetObjLstByRange = vgs_PTopicObjectiveRela_GetObjLstByRange;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vgs_PTopicObjectiveRela_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PTopicObjectiveRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vgs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vgs_PTopicObjectiveRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PTopicObjectiveRela_GetObjLstByPagerAsync = vgs_PTopicObjectiveRela_GetObjLstByPagerAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function vgs_PTopicObjectiveRela_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PTopicObjectiveRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PTopicObjectiveRela_IsExistRecordAsync = vgs_PTopicObjectiveRela_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param lngmId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function vgs_PTopicObjectiveRela_IsExist(lngmId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PTopicObjectiveRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PTopicObjectiveRela_IsExist = vgs_PTopicObjectiveRela_IsExist;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param lngmId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function vgs_PTopicObjectiveRela_IsExistAsync(lngmId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PTopicObjectiveRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PTopicObjectiveRela_IsExistAsync = vgs_PTopicObjectiveRela_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function vgs_PTopicObjectiveRela_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PTopicObjectiveRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PTopicObjectiveRela_GetRecCountByCondAsync = vgs_PTopicObjectiveRela_GetRecCountByCondAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function vgs_PTopicObjectiveRela_GetWebApiUrl(strController, strAction) {
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
    exports.vgs_PTopicObjectiveRela_GetWebApiUrl = vgs_PTopicObjectiveRela_GetWebApiUrl;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vgs_PTopicObjectiveRela_GetJSONStrByObj(pobjvgs_PTopicObjectiveRelaEN) {
        const strThisFuncName = "GetJSONStrByObj";
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjvgs_PTopicObjectiveRelaEN);
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
    exports.vgs_PTopicObjectiveRela_GetJSONStrByObj = vgs_PTopicObjectiveRela_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function vgs_PTopicObjectiveRela_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrvgs_PTopicObjectiveRelaObjLst = new Array();
        if (strJSON === "") {
            return arrvgs_PTopicObjectiveRelaObjLst;
        }
        try {
            arrvgs_PTopicObjectiveRelaObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrvgs_PTopicObjectiveRelaObjLst;
        }
        return arrvgs_PTopicObjectiveRelaObjLst;
    }
    exports.vgs_PTopicObjectiveRela_GetObjLstByJSONStr = vgs_PTopicObjectiveRela_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrvgs_PTopicObjectiveRelaObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function vgs_PTopicObjectiveRela_GetObjLstByJSONObjLst(arrvgs_PTopicObjectiveRelaObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrvgs_PTopicObjectiveRelaObjLst = new Array();
        for (const objInFor of arrvgs_PTopicObjectiveRelaObjLstS) {
            const obj1 = vgs_PTopicObjectiveRela_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrvgs_PTopicObjectiveRelaObjLst.push(obj1);
        }
        return arrvgs_PTopicObjectiveRelaObjLst;
    }
    exports.vgs_PTopicObjectiveRela_GetObjLstByJSONObjLst = vgs_PTopicObjectiveRela_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vgs_PTopicObjectiveRela_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjvgs_PTopicObjectiveRelaEN = new clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN();
        if (strJSON === "") {
            return pobjvgs_PTopicObjectiveRelaEN;
        }
        try {
            pobjvgs_PTopicObjectiveRelaEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjvgs_PTopicObjectiveRelaEN;
        }
        return pobjvgs_PTopicObjectiveRelaEN;
    }
    exports.vgs_PTopicObjectiveRela_GetObjByJSONStr = vgs_PTopicObjectiveRela_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function vgs_PTopicObjectiveRela_GetCombineCondition(objvgs_PTopicObjectiveRela_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objvgs_PTopicObjectiveRela_Cond.dicFldComparisonOp, clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_mId) == true) {
            const strComparisonOp_mId = objvgs_PTopicObjectiveRela_Cond.dicFldComparisonOp[clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_mId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_mId, objvgs_PTopicObjectiveRela_Cond.mId, strComparisonOp_mId);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PTopicObjectiveRela_Cond.dicFldComparisonOp, clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_PaperId) == true) {
            const strComparisonOp_PaperId = objvgs_PTopicObjectiveRela_Cond.dicFldComparisonOp[clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_PaperId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_PaperId, objvgs_PTopicObjectiveRela_Cond.paperId, strComparisonOp_PaperId);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PTopicObjectiveRela_Cond.dicFldComparisonOp, clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_PaperTitle) == true) {
            const strComparisonOp_PaperTitle = objvgs_PTopicObjectiveRela_Cond.dicFldComparisonOp[clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_PaperTitle];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_PaperTitle, objvgs_PTopicObjectiveRela_Cond.paperTitle, strComparisonOp_PaperTitle);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PTopicObjectiveRela_Cond.dicFldComparisonOp, clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_PaperTypeId) == true) {
            const strComparisonOp_PaperTypeId = objvgs_PTopicObjectiveRela_Cond.dicFldComparisonOp[clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_PaperTypeId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_PaperTypeId, objvgs_PTopicObjectiveRela_Cond.paperTypeId, strComparisonOp_PaperTypeId);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PTopicObjectiveRela_Cond.dicFldComparisonOp, clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_SectionId) == true) {
            const strComparisonOp_SectionId = objvgs_PTopicObjectiveRela_Cond.dicFldComparisonOp[clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_SectionId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_SectionId, objvgs_PTopicObjectiveRela_Cond.sectionId, strComparisonOp_SectionId);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PTopicObjectiveRela_Cond.dicFldComparisonOp, clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_SectionName) == true) {
            const strComparisonOp_SectionName = objvgs_PTopicObjectiveRela_Cond.dicFldComparisonOp[clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_SectionName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_SectionName, objvgs_PTopicObjectiveRela_Cond.sectionName, strComparisonOp_SectionName);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PTopicObjectiveRela_Cond.dicFldComparisonOp, clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_TopicObjectiveId) == true) {
            const strComparisonOp_TopicObjectiveId = objvgs_PTopicObjectiveRela_Cond.dicFldComparisonOp[clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_TopicObjectiveId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_TopicObjectiveId, objvgs_PTopicObjectiveRela_Cond.topicObjectiveId, strComparisonOp_TopicObjectiveId);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PTopicObjectiveRela_Cond.dicFldComparisonOp, clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_ObjectiveName) == true) {
            const strComparisonOp_ObjectiveName = objvgs_PTopicObjectiveRela_Cond.dicFldComparisonOp[clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_ObjectiveName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_ObjectiveName, objvgs_PTopicObjectiveRela_Cond.objectiveName, strComparisonOp_ObjectiveName);
        }
        //数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
        if (Object.prototype.hasOwnProperty.call(objvgs_PTopicObjectiveRela_Cond.dicFldComparisonOp, clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_ObjectiveType) == true) {
            const strComparisonOp_ObjectiveType = objvgs_PTopicObjectiveRela_Cond.dicFldComparisonOp[clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_ObjectiveType];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_ObjectiveType, objvgs_PTopicObjectiveRela_Cond.objectiveType, strComparisonOp_ObjectiveType);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PTopicObjectiveRela_Cond.dicFldComparisonOp, clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_IsSubmit) == true) {
            if (objvgs_PTopicObjectiveRela_Cond.isSubmit == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_IsSubmit);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_IsSubmit);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PTopicObjectiveRela_Cond.dicFldComparisonOp, clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_ObjectiveTypeName) == true) {
            const strComparisonOp_ObjectiveTypeName = objvgs_PTopicObjectiveRela_Cond.dicFldComparisonOp[clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_ObjectiveTypeName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_ObjectiveTypeName, objvgs_PTopicObjectiveRela_Cond.objectiveTypeName, strComparisonOp_ObjectiveTypeName);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PTopicObjectiveRela_Cond.dicFldComparisonOp, clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_TeaScore) == true) {
            const strComparisonOp_TeaScore = objvgs_PTopicObjectiveRela_Cond.dicFldComparisonOp[clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_TeaScore];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_TeaScore, objvgs_PTopicObjectiveRela_Cond.teaScore, strComparisonOp_TeaScore);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PTopicObjectiveRela_Cond.dicFldComparisonOp, clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_StuScore) == true) {
            const strComparisonOp_StuScore = objvgs_PTopicObjectiveRela_Cond.dicFldComparisonOp[clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_StuScore];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_StuScore, objvgs_PTopicObjectiveRela_Cond.stuScore, strComparisonOp_StuScore);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PTopicObjectiveRela_Cond.dicFldComparisonOp, clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_Score) == true) {
            const strComparisonOp_Score = objvgs_PTopicObjectiveRela_Cond.dicFldComparisonOp[clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_Score];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_Score, objvgs_PTopicObjectiveRela_Cond.score, strComparisonOp_Score);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PTopicObjectiveRela_Cond.dicFldComparisonOp, clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_AppraiseCount) == true) {
            const strComparisonOp_AppraiseCount = objvgs_PTopicObjectiveRela_Cond.dicFldComparisonOp[clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_AppraiseCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_AppraiseCount, objvgs_PTopicObjectiveRela_Cond.appraiseCount, strComparisonOp_AppraiseCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PTopicObjectiveRela_Cond.dicFldComparisonOp, clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_OkCount) == true) {
            const strComparisonOp_OkCount = objvgs_PTopicObjectiveRela_Cond.dicFldComparisonOp[clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_OkCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_OkCount, objvgs_PTopicObjectiveRela_Cond.okCount, strComparisonOp_OkCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PTopicObjectiveRela_Cond.dicFldComparisonOp, clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_VersionCount) == true) {
            const strComparisonOp_VersionCount = objvgs_PTopicObjectiveRela_Cond.dicFldComparisonOp[clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_VersionCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_VersionCount, objvgs_PTopicObjectiveRela_Cond.versionCount, strComparisonOp_VersionCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PTopicObjectiveRela_Cond.dicFldComparisonOp, clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_CitationCount) == true) {
            const strComparisonOp_CitationCount = objvgs_PTopicObjectiveRela_Cond.dicFldComparisonOp[clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_CitationCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_CitationCount, objvgs_PTopicObjectiveRela_Cond.citationCount, strComparisonOp_CitationCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PTopicObjectiveRela_Cond.dicFldComparisonOp, clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objvgs_PTopicObjectiveRela_Cond.dicFldComparisonOp[clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_UpdDate, objvgs_PTopicObjectiveRela_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PTopicObjectiveRela_Cond.dicFldComparisonOp, clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objvgs_PTopicObjectiveRela_Cond.dicFldComparisonOp[clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_UpdUser];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_UpdUser, objvgs_PTopicObjectiveRela_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PTopicObjectiveRela_Cond.dicFldComparisonOp, clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_Memo) == true) {
            const strComparisonOp_Memo = objvgs_PTopicObjectiveRela_Cond.dicFldComparisonOp[clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_Memo, objvgs_PTopicObjectiveRela_Cond.memo, strComparisonOp_Memo);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PTopicObjectiveRela_Cond.dicFldComparisonOp, clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_ObjUserId) == true) {
            const strComparisonOp_ObjUserId = objvgs_PTopicObjectiveRela_Cond.dicFldComparisonOp[clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_ObjUserId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_ObjUserId, objvgs_PTopicObjectiveRela_Cond.objUserId, strComparisonOp_ObjUserId);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PTopicObjectiveRela_Cond.dicFldComparisonOp, clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_ObjDate) == true) {
            const strComparisonOp_ObjDate = objvgs_PTopicObjectiveRela_Cond.dicFldComparisonOp[clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_ObjDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_ObjDate, objvgs_PTopicObjectiveRela_Cond.objDate, strComparisonOp_ObjDate);
        }
        //数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
        if (Object.prototype.hasOwnProperty.call(objvgs_PTopicObjectiveRela_Cond.dicFldComparisonOp, clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_CreateDate) == true) {
            const strComparisonOp_CreateDate = objvgs_PTopicObjectiveRela_Cond.dicFldComparisonOp[clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_CreateDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_CreateDate, objvgs_PTopicObjectiveRela_Cond.createDate, strComparisonOp_CreateDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PTopicObjectiveRela_Cond.dicFldComparisonOp, clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_ShareId) == true) {
            const strComparisonOp_ShareId = objvgs_PTopicObjectiveRela_Cond.dicFldComparisonOp[clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_ShareId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN.con_ShareId, objvgs_PTopicObjectiveRela_Cond.shareId, strComparisonOp_ShareId);
        }
        return strWhereCond;
    }
    exports.vgs_PTopicObjectiveRela_GetCombineCondition = vgs_PTopicObjectiveRela_GetCombineCondition;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objvgs_PTopicObjectiveRelaENS:源对象
     * @param objvgs_PTopicObjectiveRelaENT:目标对象
    */
    function vgs_PTopicObjectiveRela_CopyObjTo(objvgs_PTopicObjectiveRelaENS, objvgs_PTopicObjectiveRelaENT) {
        objvgs_PTopicObjectiveRelaENT.mId = objvgs_PTopicObjectiveRelaENS.mId; //mId
        objvgs_PTopicObjectiveRelaENT.paperId = objvgs_PTopicObjectiveRelaENS.paperId; //论文Id
        objvgs_PTopicObjectiveRelaENT.paperTitle = objvgs_PTopicObjectiveRelaENS.paperTitle; //论文标题
        objvgs_PTopicObjectiveRelaENT.paperTypeId = objvgs_PTopicObjectiveRelaENS.paperTypeId; //论文类型Id
        objvgs_PTopicObjectiveRelaENT.sectionId = objvgs_PTopicObjectiveRelaENS.sectionId; //节Id
        objvgs_PTopicObjectiveRelaENT.sectionName = objvgs_PTopicObjectiveRelaENS.sectionName; //节名
        objvgs_PTopicObjectiveRelaENT.topicObjectiveId = objvgs_PTopicObjectiveRelaENS.topicObjectiveId; //客观Id
        objvgs_PTopicObjectiveRelaENT.objectiveName = objvgs_PTopicObjectiveRelaENS.objectiveName; //客观名称
        objvgs_PTopicObjectiveRelaENT.objectiveContent = objvgs_PTopicObjectiveRelaENS.objectiveContent; //客观内容
        objvgs_PTopicObjectiveRelaENT.objectiveType = objvgs_PTopicObjectiveRelaENS.objectiveType; //客观类型
        objvgs_PTopicObjectiveRelaENT.isSubmit = objvgs_PTopicObjectiveRelaENS.isSubmit; //是否提交
        objvgs_PTopicObjectiveRelaENT.objectiveTypeName = objvgs_PTopicObjectiveRelaENS.objectiveTypeName; //ObjectiveTypeName
        objvgs_PTopicObjectiveRelaENT.teaScore = objvgs_PTopicObjectiveRelaENS.teaScore; //教师评分
        objvgs_PTopicObjectiveRelaENT.stuScore = objvgs_PTopicObjectiveRelaENS.stuScore; //学生平均分
        objvgs_PTopicObjectiveRelaENT.score = objvgs_PTopicObjectiveRelaENS.score; //评分
        objvgs_PTopicObjectiveRelaENT.appraiseCount = objvgs_PTopicObjectiveRelaENS.appraiseCount; //评论数
        objvgs_PTopicObjectiveRelaENT.okCount = objvgs_PTopicObjectiveRelaENS.okCount; //点赞统计
        objvgs_PTopicObjectiveRelaENT.versionCount = objvgs_PTopicObjectiveRelaENS.versionCount; //版本统计
        objvgs_PTopicObjectiveRelaENT.citationCount = objvgs_PTopicObjectiveRelaENS.citationCount; //引用统计
        objvgs_PTopicObjectiveRelaENT.updDate = objvgs_PTopicObjectiveRelaENS.updDate; //修改日期
        objvgs_PTopicObjectiveRelaENT.updUser = objvgs_PTopicObjectiveRelaENS.updUser; //修改人
        objvgs_PTopicObjectiveRelaENT.memo = objvgs_PTopicObjectiveRelaENS.memo; //备注
        objvgs_PTopicObjectiveRelaENT.objUserId = objvgs_PTopicObjectiveRelaENS.objUserId; //ObjUserId
        objvgs_PTopicObjectiveRelaENT.objDate = objvgs_PTopicObjectiveRelaENS.objDate; //ObjDate
        objvgs_PTopicObjectiveRelaENT.conclusion = objvgs_PTopicObjectiveRelaENS.conclusion; //结论
        objvgs_PTopicObjectiveRelaENT.createDate = objvgs_PTopicObjectiveRelaENS.createDate; //建立日期
        objvgs_PTopicObjectiveRelaENT.shareId = objvgs_PTopicObjectiveRelaENS.shareId; //分享Id
    }
    exports.vgs_PTopicObjectiveRela_CopyObjTo = vgs_PTopicObjectiveRela_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objvgs_PTopicObjectiveRelaENS:源对象
     * @param objvgs_PTopicObjectiveRelaENT:目标对象
    */
    function vgs_PTopicObjectiveRela_GetObjFromJsonObj(objvgs_PTopicObjectiveRelaENS) {
        const objvgs_PTopicObjectiveRelaENT = new clsvgs_PTopicObjectiveRelaEN_js_1.clsvgs_PTopicObjectiveRelaEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvgs_PTopicObjectiveRelaENT, objvgs_PTopicObjectiveRelaENS);
        return objvgs_PTopicObjectiveRelaENT;
    }
    exports.vgs_PTopicObjectiveRela_GetObjFromJsonObj = vgs_PTopicObjectiveRela_GetObjFromJsonObj;
});
