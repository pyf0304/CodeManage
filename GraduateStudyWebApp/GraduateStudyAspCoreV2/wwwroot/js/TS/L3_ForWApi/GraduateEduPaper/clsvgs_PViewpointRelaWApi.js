/**
* 类名:clsvgs_PViewpointRelaWApi
* 表名:vgs_PViewpointRela(01120669)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/13 00:46:10
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
        define(["require", "exports", "axios", "../../L0_Entity/GraduateEduPaper/clsvgs_PViewpointRelaEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.vgs_PViewpointRela_GetObjFromJsonObj = exports.vgs_PViewpointRela_CopyObjTo = exports.vgs_PViewpointRela_GetCombineCondition = exports.vgs_PViewpointRela_GetObjByJSONStr = exports.vgs_PViewpointRela_GetObjLstByJSONObjLst = exports.vgs_PViewpointRela_GetObjLstByJSONStr = exports.vgs_PViewpointRela_GetJSONStrByObj = exports.vgs_PViewpointRela_GetWebApiUrl = exports.vgs_PViewpointRela_GetRecCountByCondAsync = exports.vgs_PViewpointRela_IsExistAsync = exports.vgs_PViewpointRela_IsExist = exports.vgs_PViewpointRela_IsExistRecordAsync = exports.vgs_PViewpointRela_GetObjLstByPagerAsync = exports.vgs_PViewpointRela_GetObjLstByRange = exports.vgs_PViewpointRela_GetObjLstByRangeAsync = exports.vgs_PViewpointRela_GetTopObjLstAsync = exports.vgs_PViewpointRela_GetObjLstBymIdLstAsync = exports.vgs_PViewpointRela_GetObjLstAsync = exports.vgs_PViewpointRela_GetFirstObjAsync = exports.vgs_PViewpointRela_GetFirstID = exports.vgs_PViewpointRela_GetFirstIDAsync = exports.vgs_PViewpointRela_FilterFunByKey = exports.vgs_PViewpointRela_SortFunByKey = exports.vgs_PViewpointRela_SortFun_Defa_2Fld = exports.vgs_PViewpointRela_SortFun_Defa = exports.vgs_PViewpointRela_GetObjBymIdAsync = exports.vgs_PViewpointRela_ConstructorName = exports.vgs_PViewpointRela_Controller = void 0;
    /**
     * 论文观点关系视图(vgs_PViewpointRela)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月13日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const clsvgs_PViewpointRelaEN_js_1 = require("../../L0_Entity/GraduateEduPaper/clsvgs_PViewpointRelaEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.vgs_PViewpointRela_Controller = "vgs_PViewpointRelaApi";
    exports.vgs_PViewpointRela_ConstructorName = "vgs_PViewpointRela";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param lngmId:关键字
    * @returns 对象
    **/
    async function vgs_PViewpointRela_GetObjBymIdAsync(lngmId) {
        const strThisFuncName = "GetObjBymIdAsync";
        if (lngmId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngmId]不能为空！(In clsvgs_PViewpointRelaWApi.GetObjBymIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjBymId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PViewpointRela_Controller, strAction);
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
                const objvgs_PViewpointRela = vgs_PViewpointRela_GetObjFromJsonObj(returnObj);
                return objvgs_PViewpointRela;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PViewpointRela_GetObjBymIdAsync = vgs_PViewpointRela_GetObjBymIdAsync;
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
    function vgs_PViewpointRela_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.mId - b.mId;
    }
    exports.vgs_PViewpointRela_SortFun_Defa = vgs_PViewpointRela_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vgs_PViewpointRela_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.paperId == b.paperId)
            return a.paperTitle.localeCompare(b.paperTitle);
        else
            return a.paperId.localeCompare(b.paperId);
    }
    exports.vgs_PViewpointRela_SortFun_Defa_2Fld = vgs_PViewpointRela_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vgs_PViewpointRela_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_mId:
                    return (a, b) => {
                        return a.mId - b.mId;
                    };
                case clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_PaperId:
                    return (a, b) => {
                        return a.paperId.localeCompare(b.paperId);
                    };
                case clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_PaperTitle:
                    return (a, b) => {
                        if (a.paperTitle == null)
                            return -1;
                        if (b.paperTitle == null)
                            return 1;
                        return a.paperTitle.localeCompare(b.paperTitle);
                    };
                case clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_PaperTypeId:
                    return (a, b) => {
                        if (a.paperTypeId == null)
                            return -1;
                        if (b.paperTypeId == null)
                            return 1;
                        return a.paperTypeId.localeCompare(b.paperTypeId);
                    };
                case clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_SectionId:
                    return (a, b) => {
                        if (a.sectionId == null)
                            return -1;
                        if (b.sectionId == null)
                            return 1;
                        return a.sectionId.localeCompare(b.sectionId);
                    };
                case clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_SectionName:
                    return (a, b) => {
                        if (a.sectionName == null)
                            return -1;
                        if (b.sectionName == null)
                            return 1;
                        return a.sectionName.localeCompare(b.sectionName);
                    };
                case clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_ViewpointId:
                    return (a, b) => {
                        return a.viewpointId.localeCompare(b.viewpointId);
                    };
                case clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_ViewpointName:
                    return (a, b) => {
                        if (a.viewpointName == null)
                            return -1;
                        if (b.viewpointName == null)
                            return 1;
                        return a.viewpointName.localeCompare(b.viewpointName);
                    };
                case clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_ViewpointContent:
                    return (a, b) => {
                        if (a.viewpointContent == null)
                            return -1;
                        if (b.viewpointContent == null)
                            return 1;
                        return a.viewpointContent.localeCompare(b.viewpointContent);
                    };
                case clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_ViewpointTypeId:
                    return (a, b) => {
                        if (a.viewpointTypeId == null)
                            return -1;
                        if (b.viewpointTypeId == null)
                            return 1;
                        return a.viewpointTypeId.localeCompare(b.viewpointTypeId);
                    };
                case clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_ViewpointTypeName:
                    return (a, b) => {
                        if (a.viewpointTypeName == null)
                            return -1;
                        if (b.viewpointTypeName == null)
                            return 1;
                        return a.viewpointTypeName.localeCompare(b.viewpointTypeName);
                    };
                case clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_Reason:
                    return (a, b) => {
                        if (a.reason == null)
                            return -1;
                        if (b.reason == null)
                            return 1;
                        return a.reason.localeCompare(b.reason);
                    };
                case clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_VPProposePeople:
                    return (a, b) => {
                        if (a.vpProposePeople == null)
                            return -1;
                        if (b.vpProposePeople == null)
                            return 1;
                        return a.vpProposePeople.localeCompare(b.vpProposePeople);
                    };
                case clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_IsSubmit:
                    return (a, b) => {
                        if (a.isSubmit == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_UserTypeId:
                    return (a, b) => {
                        if (a.userTypeId == null)
                            return -1;
                        if (b.userTypeId == null)
                            return 1;
                        return a.userTypeId.localeCompare(b.userTypeId);
                    };
                case clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_UserTypeName:
                    return (a, b) => {
                        if (a.userTypeName == null)
                            return -1;
                        if (b.userTypeName == null)
                            return 1;
                        return a.userTypeName.localeCompare(b.userTypeName);
                    };
                case clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_AppraiseCount:
                    return (a, b) => {
                        return a.appraiseCount - b.appraiseCount;
                    };
                case clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_Score:
                    return (a, b) => {
                        return a.score - b.score;
                    };
                case clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_StuScore:
                    return (a, b) => {
                        return a.stuScore - b.stuScore;
                    };
                case clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_TeaScore:
                    return (a, b) => {
                        return a.teaScore - b.teaScore;
                    };
                case clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_OkCount:
                    return (a, b) => {
                        return a.okCount - b.okCount;
                    };
                case clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_CitationCount:
                    return (a, b) => {
                        return a.citationCount - b.citationCount;
                    };
                case clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_VersionCount:
                    return (a, b) => {
                        return a.versionCount - b.versionCount;
                    };
                case clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_ProposePeople:
                    return (a, b) => {
                        if (a.proposePeople == null)
                            return -1;
                        if (b.proposePeople == null)
                            return 1;
                        return a.proposePeople.localeCompare(b.proposePeople);
                    };
                case clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_UpdDate:
                    return (a, b) => {
                        if (a.updDate == null)
                            return -1;
                        if (b.updDate == null)
                            return 1;
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_UpdUser:
                    return (a, b) => {
                        if (a.updUser == null)
                            return -1;
                        if (b.updUser == null)
                            return 1;
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                case clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_ViewsDate:
                    return (a, b) => {
                        if (a.viewsDate == null)
                            return -1;
                        if (b.viewsDate == null)
                            return 1;
                        return a.viewsDate.localeCompare(b.viewsDate);
                    };
                case clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_ViewsUserId:
                    return (a, b) => {
                        if (a.viewsUserId == null)
                            return -1;
                        if (b.viewsUserId == null)
                            return 1;
                        return a.viewsUserId.localeCompare(b.viewsUserId);
                    };
                case clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_CreateDate:
                    return (a, b) => {
                        if (a.createDate == null)
                            return -1;
                        if (b.createDate == null)
                            return 1;
                        return a.createDate.localeCompare(b.createDate);
                    };
                case clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_ShareId:
                    return (a, b) => {
                        if (a.shareId == null)
                            return -1;
                        if (b.shareId == null)
                            return 1;
                        return a.shareId.localeCompare(b.shareId);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vgs_PViewpointRela]中不存在！(in ${exports.vgs_PViewpointRela_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_mId:
                    return (a, b) => {
                        return b.mId - a.mId;
                    };
                case clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_PaperId:
                    return (a, b) => {
                        return b.paperId.localeCompare(a.paperId);
                    };
                case clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_PaperTitle:
                    return (a, b) => {
                        if (b.paperTitle == null)
                            return -1;
                        if (a.paperTitle == null)
                            return 1;
                        return b.paperTitle.localeCompare(a.paperTitle);
                    };
                case clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_PaperTypeId:
                    return (a, b) => {
                        if (b.paperTypeId == null)
                            return -1;
                        if (a.paperTypeId == null)
                            return 1;
                        return b.paperTypeId.localeCompare(a.paperTypeId);
                    };
                case clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_SectionId:
                    return (a, b) => {
                        if (b.sectionId == null)
                            return -1;
                        if (a.sectionId == null)
                            return 1;
                        return b.sectionId.localeCompare(a.sectionId);
                    };
                case clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_SectionName:
                    return (a, b) => {
                        if (b.sectionName == null)
                            return -1;
                        if (a.sectionName == null)
                            return 1;
                        return b.sectionName.localeCompare(a.sectionName);
                    };
                case clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_ViewpointId:
                    return (a, b) => {
                        return b.viewpointId.localeCompare(a.viewpointId);
                    };
                case clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_ViewpointName:
                    return (a, b) => {
                        if (b.viewpointName == null)
                            return -1;
                        if (a.viewpointName == null)
                            return 1;
                        return b.viewpointName.localeCompare(a.viewpointName);
                    };
                case clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_ViewpointContent:
                    return (a, b) => {
                        if (b.viewpointContent == null)
                            return -1;
                        if (a.viewpointContent == null)
                            return 1;
                        return b.viewpointContent.localeCompare(a.viewpointContent);
                    };
                case clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_ViewpointTypeId:
                    return (a, b) => {
                        if (b.viewpointTypeId == null)
                            return -1;
                        if (a.viewpointTypeId == null)
                            return 1;
                        return b.viewpointTypeId.localeCompare(a.viewpointTypeId);
                    };
                case clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_ViewpointTypeName:
                    return (a, b) => {
                        if (b.viewpointTypeName == null)
                            return -1;
                        if (a.viewpointTypeName == null)
                            return 1;
                        return b.viewpointTypeName.localeCompare(a.viewpointTypeName);
                    };
                case clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_Reason:
                    return (a, b) => {
                        if (b.reason == null)
                            return -1;
                        if (a.reason == null)
                            return 1;
                        return b.reason.localeCompare(a.reason);
                    };
                case clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_VPProposePeople:
                    return (a, b) => {
                        if (b.vpProposePeople == null)
                            return -1;
                        if (a.vpProposePeople == null)
                            return 1;
                        return b.vpProposePeople.localeCompare(a.vpProposePeople);
                    };
                case clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_IsSubmit:
                    return (a, b) => {
                        if (b.isSubmit == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_UserTypeId:
                    return (a, b) => {
                        if (b.userTypeId == null)
                            return -1;
                        if (a.userTypeId == null)
                            return 1;
                        return b.userTypeId.localeCompare(a.userTypeId);
                    };
                case clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_UserTypeName:
                    return (a, b) => {
                        if (b.userTypeName == null)
                            return -1;
                        if (a.userTypeName == null)
                            return 1;
                        return b.userTypeName.localeCompare(a.userTypeName);
                    };
                case clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_AppraiseCount:
                    return (a, b) => {
                        return b.appraiseCount - a.appraiseCount;
                    };
                case clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_Score:
                    return (a, b) => {
                        return b.score - a.score;
                    };
                case clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_StuScore:
                    return (a, b) => {
                        return b.stuScore - a.stuScore;
                    };
                case clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_TeaScore:
                    return (a, b) => {
                        return b.teaScore - a.teaScore;
                    };
                case clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_OkCount:
                    return (a, b) => {
                        return b.okCount - a.okCount;
                    };
                case clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_CitationCount:
                    return (a, b) => {
                        return b.citationCount - a.citationCount;
                    };
                case clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_VersionCount:
                    return (a, b) => {
                        return b.versionCount - a.versionCount;
                    };
                case clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_ProposePeople:
                    return (a, b) => {
                        if (b.proposePeople == null)
                            return -1;
                        if (a.proposePeople == null)
                            return 1;
                        return b.proposePeople.localeCompare(a.proposePeople);
                    };
                case clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_UpdDate:
                    return (a, b) => {
                        if (b.updDate == null)
                            return -1;
                        if (a.updDate == null)
                            return 1;
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_UpdUser:
                    return (a, b) => {
                        if (b.updUser == null)
                            return -1;
                        if (a.updUser == null)
                            return 1;
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                case clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_ViewsDate:
                    return (a, b) => {
                        if (b.viewsDate == null)
                            return -1;
                        if (a.viewsDate == null)
                            return 1;
                        return b.viewsDate.localeCompare(a.viewsDate);
                    };
                case clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_ViewsUserId:
                    return (a, b) => {
                        if (b.viewsUserId == null)
                            return -1;
                        if (a.viewsUserId == null)
                            return 1;
                        return b.viewsUserId.localeCompare(a.viewsUserId);
                    };
                case clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_CreateDate:
                    return (a, b) => {
                        if (b.createDate == null)
                            return -1;
                        if (a.createDate == null)
                            return 1;
                        return b.createDate.localeCompare(a.createDate);
                    };
                case clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_ShareId:
                    return (a, b) => {
                        if (b.shareId == null)
                            return -1;
                        if (a.shareId == null)
                            return 1;
                        return b.shareId.localeCompare(a.shareId);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vgs_PViewpointRela]中不存在！(in ${exports.vgs_PViewpointRela_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.vgs_PViewpointRela_SortFunByKey = vgs_PViewpointRela_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function vgs_PViewpointRela_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_mId:
                return (obj) => {
                    return obj.mId === value;
                };
            case clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_PaperId:
                return (obj) => {
                    return obj.paperId === value;
                };
            case clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_PaperTitle:
                return (obj) => {
                    return obj.paperTitle === value;
                };
            case clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_PaperTypeId:
                return (obj) => {
                    return obj.paperTypeId === value;
                };
            case clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_SectionId:
                return (obj) => {
                    return obj.sectionId === value;
                };
            case clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_SectionName:
                return (obj) => {
                    return obj.sectionName === value;
                };
            case clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_ViewpointId:
                return (obj) => {
                    return obj.viewpointId === value;
                };
            case clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_ViewpointName:
                return (obj) => {
                    return obj.viewpointName === value;
                };
            case clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_ViewpointContent:
                return (obj) => {
                    return obj.viewpointContent === value;
                };
            case clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_ViewpointTypeId:
                return (obj) => {
                    return obj.viewpointTypeId === value;
                };
            case clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_ViewpointTypeName:
                return (obj) => {
                    return obj.viewpointTypeName === value;
                };
            case clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_Reason:
                return (obj) => {
                    return obj.reason === value;
                };
            case clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_VPProposePeople:
                return (obj) => {
                    return obj.vpProposePeople === value;
                };
            case clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_IsSubmit:
                return (obj) => {
                    return obj.isSubmit === value;
                };
            case clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_UserTypeId:
                return (obj) => {
                    return obj.userTypeId === value;
                };
            case clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_UserTypeName:
                return (obj) => {
                    return obj.userTypeName === value;
                };
            case clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_AppraiseCount:
                return (obj) => {
                    return obj.appraiseCount === value;
                };
            case clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_Score:
                return (obj) => {
                    return obj.score === value;
                };
            case clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_StuScore:
                return (obj) => {
                    return obj.stuScore === value;
                };
            case clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_TeaScore:
                return (obj) => {
                    return obj.teaScore === value;
                };
            case clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_OkCount:
                return (obj) => {
                    return obj.okCount === value;
                };
            case clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_CitationCount:
                return (obj) => {
                    return obj.citationCount === value;
                };
            case clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_VersionCount:
                return (obj) => {
                    return obj.versionCount === value;
                };
            case clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_ProposePeople:
                return (obj) => {
                    return obj.proposePeople === value;
                };
            case clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            case clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_ViewsDate:
                return (obj) => {
                    return obj.viewsDate === value;
                };
            case clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_ViewsUserId:
                return (obj) => {
                    return obj.viewsUserId === value;
                };
            case clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_CreateDate:
                return (obj) => {
                    return obj.createDate === value;
                };
            case clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_ShareId:
                return (obj) => {
                    return obj.shareId === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[vgs_PViewpointRela]中不存在！(in ${exports.vgs_PViewpointRela_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.vgs_PViewpointRela_FilterFunByKey = vgs_PViewpointRela_FilterFunByKey;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function vgs_PViewpointRela_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PViewpointRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PViewpointRela_GetFirstIDAsync = vgs_PViewpointRela_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function vgs_PViewpointRela_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PViewpointRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PViewpointRela_GetFirstID = vgs_PViewpointRela_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function vgs_PViewpointRela_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PViewpointRela_Controller, strAction);
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
                const objvgs_PViewpointRela = vgs_PViewpointRela_GetObjFromJsonObj(returnObj);
                return objvgs_PViewpointRela;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PViewpointRela_GetFirstObjAsync = vgs_PViewpointRela_GetFirstObjAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function vgs_PViewpointRela_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PViewpointRela_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vgs_PViewpointRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vgs_PViewpointRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PViewpointRela_GetObjLstAsync = vgs_PViewpointRela_GetObjLstAsync;
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
    async function vgs_PViewpointRela_GetObjLstBymIdLstAsync(arrmId) {
        const strThisFuncName = "GetObjLstBymIdLstAsync";
        const strAction = "GetObjLstBymIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PViewpointRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrmId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vgs_PViewpointRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vgs_PViewpointRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PViewpointRela_GetObjLstBymIdLstAsync = vgs_PViewpointRela_GetObjLstBymIdLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function vgs_PViewpointRela_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PViewpointRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vgs_PViewpointRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vgs_PViewpointRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PViewpointRela_GetTopObjLstAsync = vgs_PViewpointRela_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vgs_PViewpointRela_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PViewpointRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vgs_PViewpointRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vgs_PViewpointRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PViewpointRela_GetObjLstByRangeAsync = vgs_PViewpointRela_GetObjLstByRangeAsync;
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
    async function vgs_PViewpointRela_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PViewpointRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PViewpointRela_GetObjLstByRange = vgs_PViewpointRela_GetObjLstByRange;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vgs_PViewpointRela_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PViewpointRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vgs_PViewpointRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vgs_PViewpointRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PViewpointRela_GetObjLstByPagerAsync = vgs_PViewpointRela_GetObjLstByPagerAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function vgs_PViewpointRela_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PViewpointRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PViewpointRela_IsExistRecordAsync = vgs_PViewpointRela_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param lngmId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function vgs_PViewpointRela_IsExist(lngmId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PViewpointRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PViewpointRela_IsExist = vgs_PViewpointRela_IsExist;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param lngmId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function vgs_PViewpointRela_IsExistAsync(lngmId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PViewpointRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PViewpointRela_IsExistAsync = vgs_PViewpointRela_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function vgs_PViewpointRela_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PViewpointRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PViewpointRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PViewpointRela_GetRecCountByCondAsync = vgs_PViewpointRela_GetRecCountByCondAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function vgs_PViewpointRela_GetWebApiUrl(strController, strAction) {
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
    exports.vgs_PViewpointRela_GetWebApiUrl = vgs_PViewpointRela_GetWebApiUrl;
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
    function vgs_PViewpointRela_GetJSONStrByObj(pobjvgs_PViewpointRelaEN) {
        const strThisFuncName = "GetJSONStrByObj";
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjvgs_PViewpointRelaEN);
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
    exports.vgs_PViewpointRela_GetJSONStrByObj = vgs_PViewpointRela_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function vgs_PViewpointRela_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrvgs_PViewpointRelaObjLst = new Array();
        if (strJSON === "") {
            return arrvgs_PViewpointRelaObjLst;
        }
        try {
            arrvgs_PViewpointRelaObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrvgs_PViewpointRelaObjLst;
        }
        return arrvgs_PViewpointRelaObjLst;
    }
    exports.vgs_PViewpointRela_GetObjLstByJSONStr = vgs_PViewpointRela_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrvgs_PViewpointRelaObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function vgs_PViewpointRela_GetObjLstByJSONObjLst(arrvgs_PViewpointRelaObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrvgs_PViewpointRelaObjLst = new Array();
        for (const objInFor of arrvgs_PViewpointRelaObjLstS) {
            const obj1 = vgs_PViewpointRela_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrvgs_PViewpointRelaObjLst.push(obj1);
        }
        return arrvgs_PViewpointRelaObjLst;
    }
    exports.vgs_PViewpointRela_GetObjLstByJSONObjLst = vgs_PViewpointRela_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vgs_PViewpointRela_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjvgs_PViewpointRelaEN = new clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN();
        if (strJSON === "") {
            return pobjvgs_PViewpointRelaEN;
        }
        try {
            pobjvgs_PViewpointRelaEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjvgs_PViewpointRelaEN;
        }
        return pobjvgs_PViewpointRelaEN;
    }
    exports.vgs_PViewpointRela_GetObjByJSONStr = vgs_PViewpointRela_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function vgs_PViewpointRela_GetCombineCondition(objvgs_PViewpointRela_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objvgs_PViewpointRela_Cond.dicFldComparisonOp, clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_mId) == true) {
            const strComparisonOp_mId = objvgs_PViewpointRela_Cond.dicFldComparisonOp[clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_mId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_mId, objvgs_PViewpointRela_Cond.mId, strComparisonOp_mId);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PViewpointRela_Cond.dicFldComparisonOp, clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_PaperId) == true) {
            const strComparisonOp_PaperId = objvgs_PViewpointRela_Cond.dicFldComparisonOp[clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_PaperId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_PaperId, objvgs_PViewpointRela_Cond.paperId, strComparisonOp_PaperId);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PViewpointRela_Cond.dicFldComparisonOp, clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_PaperTitle) == true) {
            const strComparisonOp_PaperTitle = objvgs_PViewpointRela_Cond.dicFldComparisonOp[clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_PaperTitle];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_PaperTitle, objvgs_PViewpointRela_Cond.paperTitle, strComparisonOp_PaperTitle);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PViewpointRela_Cond.dicFldComparisonOp, clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_PaperTypeId) == true) {
            const strComparisonOp_PaperTypeId = objvgs_PViewpointRela_Cond.dicFldComparisonOp[clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_PaperTypeId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_PaperTypeId, objvgs_PViewpointRela_Cond.paperTypeId, strComparisonOp_PaperTypeId);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PViewpointRela_Cond.dicFldComparisonOp, clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_SectionId) == true) {
            const strComparisonOp_SectionId = objvgs_PViewpointRela_Cond.dicFldComparisonOp[clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_SectionId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_SectionId, objvgs_PViewpointRela_Cond.sectionId, strComparisonOp_SectionId);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PViewpointRela_Cond.dicFldComparisonOp, clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_SectionName) == true) {
            const strComparisonOp_SectionName = objvgs_PViewpointRela_Cond.dicFldComparisonOp[clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_SectionName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_SectionName, objvgs_PViewpointRela_Cond.sectionName, strComparisonOp_SectionName);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PViewpointRela_Cond.dicFldComparisonOp, clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_ViewpointId) == true) {
            const strComparisonOp_ViewpointId = objvgs_PViewpointRela_Cond.dicFldComparisonOp[clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_ViewpointId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_ViewpointId, objvgs_PViewpointRela_Cond.viewpointId, strComparisonOp_ViewpointId);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PViewpointRela_Cond.dicFldComparisonOp, clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_ViewpointName) == true) {
            const strComparisonOp_ViewpointName = objvgs_PViewpointRela_Cond.dicFldComparisonOp[clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_ViewpointName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_ViewpointName, objvgs_PViewpointRela_Cond.viewpointName, strComparisonOp_ViewpointName);
        }
        //数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
        if (Object.prototype.hasOwnProperty.call(objvgs_PViewpointRela_Cond.dicFldComparisonOp, clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_ViewpointTypeId) == true) {
            const strComparisonOp_ViewpointTypeId = objvgs_PViewpointRela_Cond.dicFldComparisonOp[clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_ViewpointTypeId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_ViewpointTypeId, objvgs_PViewpointRela_Cond.viewpointTypeId, strComparisonOp_ViewpointTypeId);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PViewpointRela_Cond.dicFldComparisonOp, clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_ViewpointTypeName) == true) {
            const strComparisonOp_ViewpointTypeName = objvgs_PViewpointRela_Cond.dicFldComparisonOp[clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_ViewpointTypeName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_ViewpointTypeName, objvgs_PViewpointRela_Cond.viewpointTypeName, strComparisonOp_ViewpointTypeName);
        }
        //数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
        if (Object.prototype.hasOwnProperty.call(objvgs_PViewpointRela_Cond.dicFldComparisonOp, clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_VPProposePeople) == true) {
            const strComparisonOp_VPProposePeople = objvgs_PViewpointRela_Cond.dicFldComparisonOp[clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_VPProposePeople];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_VPProposePeople, objvgs_PViewpointRela_Cond.vpProposePeople, strComparisonOp_VPProposePeople);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PViewpointRela_Cond.dicFldComparisonOp, clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_IsSubmit) == true) {
            if (objvgs_PViewpointRela_Cond.isSubmit == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_IsSubmit);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_IsSubmit);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PViewpointRela_Cond.dicFldComparisonOp, clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_UserTypeId) == true) {
            const strComparisonOp_UserTypeId = objvgs_PViewpointRela_Cond.dicFldComparisonOp[clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_UserTypeId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_UserTypeId, objvgs_PViewpointRela_Cond.userTypeId, strComparisonOp_UserTypeId);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PViewpointRela_Cond.dicFldComparisonOp, clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_UserTypeName) == true) {
            const strComparisonOp_UserTypeName = objvgs_PViewpointRela_Cond.dicFldComparisonOp[clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_UserTypeName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_UserTypeName, objvgs_PViewpointRela_Cond.userTypeName, strComparisonOp_UserTypeName);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PViewpointRela_Cond.dicFldComparisonOp, clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_AppraiseCount) == true) {
            const strComparisonOp_AppraiseCount = objvgs_PViewpointRela_Cond.dicFldComparisonOp[clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_AppraiseCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_AppraiseCount, objvgs_PViewpointRela_Cond.appraiseCount, strComparisonOp_AppraiseCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PViewpointRela_Cond.dicFldComparisonOp, clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_Score) == true) {
            const strComparisonOp_Score = objvgs_PViewpointRela_Cond.dicFldComparisonOp[clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_Score];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_Score, objvgs_PViewpointRela_Cond.score, strComparisonOp_Score);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PViewpointRela_Cond.dicFldComparisonOp, clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_StuScore) == true) {
            const strComparisonOp_StuScore = objvgs_PViewpointRela_Cond.dicFldComparisonOp[clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_StuScore];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_StuScore, objvgs_PViewpointRela_Cond.stuScore, strComparisonOp_StuScore);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PViewpointRela_Cond.dicFldComparisonOp, clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_TeaScore) == true) {
            const strComparisonOp_TeaScore = objvgs_PViewpointRela_Cond.dicFldComparisonOp[clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_TeaScore];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_TeaScore, objvgs_PViewpointRela_Cond.teaScore, strComparisonOp_TeaScore);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PViewpointRela_Cond.dicFldComparisonOp, clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_OkCount) == true) {
            const strComparisonOp_OkCount = objvgs_PViewpointRela_Cond.dicFldComparisonOp[clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_OkCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_OkCount, objvgs_PViewpointRela_Cond.okCount, strComparisonOp_OkCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PViewpointRela_Cond.dicFldComparisonOp, clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_CitationCount) == true) {
            const strComparisonOp_CitationCount = objvgs_PViewpointRela_Cond.dicFldComparisonOp[clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_CitationCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_CitationCount, objvgs_PViewpointRela_Cond.citationCount, strComparisonOp_CitationCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PViewpointRela_Cond.dicFldComparisonOp, clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_VersionCount) == true) {
            const strComparisonOp_VersionCount = objvgs_PViewpointRela_Cond.dicFldComparisonOp[clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_VersionCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_VersionCount, objvgs_PViewpointRela_Cond.versionCount, strComparisonOp_VersionCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PViewpointRela_Cond.dicFldComparisonOp, clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_ProposePeople) == true) {
            const strComparisonOp_ProposePeople = objvgs_PViewpointRela_Cond.dicFldComparisonOp[clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_ProposePeople];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_ProposePeople, objvgs_PViewpointRela_Cond.proposePeople, strComparisonOp_ProposePeople);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PViewpointRela_Cond.dicFldComparisonOp, clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objvgs_PViewpointRela_Cond.dicFldComparisonOp[clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_UpdDate, objvgs_PViewpointRela_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PViewpointRela_Cond.dicFldComparisonOp, clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objvgs_PViewpointRela_Cond.dicFldComparisonOp[clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_UpdUser];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_UpdUser, objvgs_PViewpointRela_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PViewpointRela_Cond.dicFldComparisonOp, clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_Memo) == true) {
            const strComparisonOp_Memo = objvgs_PViewpointRela_Cond.dicFldComparisonOp[clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_Memo, objvgs_PViewpointRela_Cond.memo, strComparisonOp_Memo);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PViewpointRela_Cond.dicFldComparisonOp, clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_ViewsDate) == true) {
            const strComparisonOp_ViewsDate = objvgs_PViewpointRela_Cond.dicFldComparisonOp[clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_ViewsDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_ViewsDate, objvgs_PViewpointRela_Cond.viewsDate, strComparisonOp_ViewsDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PViewpointRela_Cond.dicFldComparisonOp, clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_ViewsUserId) == true) {
            const strComparisonOp_ViewsUserId = objvgs_PViewpointRela_Cond.dicFldComparisonOp[clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_ViewsUserId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_ViewsUserId, objvgs_PViewpointRela_Cond.viewsUserId, strComparisonOp_ViewsUserId);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PViewpointRela_Cond.dicFldComparisonOp, clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_CreateDate) == true) {
            const strComparisonOp_CreateDate = objvgs_PViewpointRela_Cond.dicFldComparisonOp[clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_CreateDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_CreateDate, objvgs_PViewpointRela_Cond.createDate, strComparisonOp_CreateDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PViewpointRela_Cond.dicFldComparisonOp, clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_ShareId) == true) {
            const strComparisonOp_ShareId = objvgs_PViewpointRela_Cond.dicFldComparisonOp[clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_ShareId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN.con_ShareId, objvgs_PViewpointRela_Cond.shareId, strComparisonOp_ShareId);
        }
        return strWhereCond;
    }
    exports.vgs_PViewpointRela_GetCombineCondition = vgs_PViewpointRela_GetCombineCondition;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objvgs_PViewpointRelaENS:源对象
     * @param objvgs_PViewpointRelaENT:目标对象
    */
    function vgs_PViewpointRela_CopyObjTo(objvgs_PViewpointRelaENS, objvgs_PViewpointRelaENT) {
        objvgs_PViewpointRelaENT.mId = objvgs_PViewpointRelaENS.mId; //mId
        objvgs_PViewpointRelaENT.paperId = objvgs_PViewpointRelaENS.paperId; //论文Id
        objvgs_PViewpointRelaENT.paperTitle = objvgs_PViewpointRelaENS.paperTitle; //论文标题
        objvgs_PViewpointRelaENT.paperTypeId = objvgs_PViewpointRelaENS.paperTypeId; //论文类型Id
        objvgs_PViewpointRelaENT.sectionId = objvgs_PViewpointRelaENS.sectionId; //节Id
        objvgs_PViewpointRelaENT.sectionName = objvgs_PViewpointRelaENS.sectionName; //节名
        objvgs_PViewpointRelaENT.viewpointId = objvgs_PViewpointRelaENS.viewpointId; //观点Id
        objvgs_PViewpointRelaENT.viewpointName = objvgs_PViewpointRelaENS.viewpointName; //观点名称
        objvgs_PViewpointRelaENT.viewpointContent = objvgs_PViewpointRelaENS.viewpointContent; //观点内容
        objvgs_PViewpointRelaENT.viewpointTypeId = objvgs_PViewpointRelaENS.viewpointTypeId; //观点类型Id
        objvgs_PViewpointRelaENT.viewpointTypeName = objvgs_PViewpointRelaENS.viewpointTypeName; //观点类型名
        objvgs_PViewpointRelaENT.reason = objvgs_PViewpointRelaENS.reason; //理由
        objvgs_PViewpointRelaENT.vpProposePeople = objvgs_PViewpointRelaENS.vpProposePeople; //观点提出人
        objvgs_PViewpointRelaENT.isSubmit = objvgs_PViewpointRelaENS.isSubmit; //是否提交
        objvgs_PViewpointRelaENT.userTypeId = objvgs_PViewpointRelaENS.userTypeId; //用户类型Id
        objvgs_PViewpointRelaENT.userTypeName = objvgs_PViewpointRelaENS.userTypeName; //用户类型名称
        objvgs_PViewpointRelaENT.appraiseCount = objvgs_PViewpointRelaENS.appraiseCount; //评论数
        objvgs_PViewpointRelaENT.score = objvgs_PViewpointRelaENS.score; //评分
        objvgs_PViewpointRelaENT.stuScore = objvgs_PViewpointRelaENS.stuScore; //学生平均分
        objvgs_PViewpointRelaENT.teaScore = objvgs_PViewpointRelaENS.teaScore; //教师评分
        objvgs_PViewpointRelaENT.okCount = objvgs_PViewpointRelaENS.okCount; //点赞统计
        objvgs_PViewpointRelaENT.citationCount = objvgs_PViewpointRelaENS.citationCount; //引用统计
        objvgs_PViewpointRelaENT.versionCount = objvgs_PViewpointRelaENS.versionCount; //版本统计
        objvgs_PViewpointRelaENT.proposePeople = objvgs_PViewpointRelaENS.proposePeople; //提出人
        objvgs_PViewpointRelaENT.updDate = objvgs_PViewpointRelaENS.updDate; //修改日期
        objvgs_PViewpointRelaENT.updUser = objvgs_PViewpointRelaENS.updUser; //修改人
        objvgs_PViewpointRelaENT.memo = objvgs_PViewpointRelaENS.memo; //备注
        objvgs_PViewpointRelaENT.viewsDate = objvgs_PViewpointRelaENS.viewsDate; //ViewsDate
        objvgs_PViewpointRelaENT.viewsUserId = objvgs_PViewpointRelaENS.viewsUserId; //ViewsUserId
        objvgs_PViewpointRelaENT.createDate = objvgs_PViewpointRelaENS.createDate; //建立日期
        objvgs_PViewpointRelaENT.shareId = objvgs_PViewpointRelaENS.shareId; //分享Id
    }
    exports.vgs_PViewpointRela_CopyObjTo = vgs_PViewpointRela_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objvgs_PViewpointRelaENS:源对象
     * @param objvgs_PViewpointRelaENT:目标对象
    */
    function vgs_PViewpointRela_GetObjFromJsonObj(objvgs_PViewpointRelaENS) {
        const objvgs_PViewpointRelaENT = new clsvgs_PViewpointRelaEN_js_1.clsvgs_PViewpointRelaEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvgs_PViewpointRelaENT, objvgs_PViewpointRelaENS);
        return objvgs_PViewpointRelaENT;
    }
    exports.vgs_PViewpointRela_GetObjFromJsonObj = vgs_PViewpointRela_GetObjFromJsonObj;
});
