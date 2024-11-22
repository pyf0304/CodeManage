/**
* 类名:clsvgs_PSkillRelaWApi
* 表名:vgs_PSkillRela(01120666)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/13 00:45:00
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
        define(["require", "exports", "axios", "../../L0_Entity/GraduateEduPaper/clsvgs_PSkillRelaEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.vgs_PSkillRela_GetObjFromJsonObj = exports.vgs_PSkillRela_CopyObjTo = exports.vgs_PSkillRela_GetCombineCondition = exports.vgs_PSkillRela_GetObjByJSONStr = exports.vgs_PSkillRela_GetObjLstByJSONObjLst = exports.vgs_PSkillRela_GetObjLstByJSONStr = exports.vgs_PSkillRela_GetJSONStrByObj = exports.vgs_PSkillRela_GetWebApiUrl = exports.vgs_PSkillRela_GetRecCountByCondAsync = exports.vgs_PSkillRela_IsExistAsync = exports.vgs_PSkillRela_IsExist = exports.vgs_PSkillRela_IsExistRecordAsync = exports.vgs_PSkillRela_GetObjLstByPagerAsync = exports.vgs_PSkillRela_GetObjLstByRange = exports.vgs_PSkillRela_GetObjLstByRangeAsync = exports.vgs_PSkillRela_GetTopObjLstAsync = exports.vgs_PSkillRela_GetObjLstBymIdLstAsync = exports.vgs_PSkillRela_GetObjLstAsync = exports.vgs_PSkillRela_GetFirstObjAsync = exports.vgs_PSkillRela_GetFirstID = exports.vgs_PSkillRela_GetFirstIDAsync = exports.vgs_PSkillRela_FilterFunByKey = exports.vgs_PSkillRela_SortFunByKey = exports.vgs_PSkillRela_SortFun_Defa_2Fld = exports.vgs_PSkillRela_SortFun_Defa = exports.vgs_PSkillRela_GetObjBymIdAsync = exports.vgs_PSkillRela_ConstructorName = exports.vgs_PSkillRela_Controller = void 0;
    /**
     * 论文技能关系视图(vgs_PSkillRela)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月13日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const clsvgs_PSkillRelaEN_js_1 = require("../../L0_Entity/GraduateEduPaper/clsvgs_PSkillRelaEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.vgs_PSkillRela_Controller = "vgs_PSkillRelaApi";
    exports.vgs_PSkillRela_ConstructorName = "vgs_PSkillRela";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param lngmId:关键字
    * @returns 对象
    **/
    async function vgs_PSkillRela_GetObjBymIdAsync(lngmId) {
        const strThisFuncName = "GetObjBymIdAsync";
        if (lngmId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngmId]不能为空！(In clsvgs_PSkillRelaWApi.GetObjBymIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjBymId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PSkillRela_Controller, strAction);
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
                const objvgs_PSkillRela = vgs_PSkillRela_GetObjFromJsonObj(returnObj);
                return objvgs_PSkillRela;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PSkillRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PSkillRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PSkillRela_GetObjBymIdAsync = vgs_PSkillRela_GetObjBymIdAsync;
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
    function vgs_PSkillRela_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.mId - b.mId;
    }
    exports.vgs_PSkillRela_SortFun_Defa = vgs_PSkillRela_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vgs_PSkillRela_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.paperId == b.paperId)
            return a.paperTitle.localeCompare(b.paperTitle);
        else
            return a.paperId.localeCompare(b.paperId);
    }
    exports.vgs_PSkillRela_SortFun_Defa_2Fld = vgs_PSkillRela_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vgs_PSkillRela_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_mId:
                    return (a, b) => {
                        return a.mId - b.mId;
                    };
                case clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_PaperId:
                    return (a, b) => {
                        return a.paperId.localeCompare(b.paperId);
                    };
                case clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_PaperTitle:
                    return (a, b) => {
                        if (a.paperTitle == null)
                            return -1;
                        if (b.paperTitle == null)
                            return 1;
                        return a.paperTitle.localeCompare(b.paperTitle);
                    };
                case clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_PaperTypeId:
                    return (a, b) => {
                        if (a.paperTypeId == null)
                            return -1;
                        if (b.paperTypeId == null)
                            return 1;
                        return a.paperTypeId.localeCompare(b.paperTypeId);
                    };
                case clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_SectionId:
                    return (a, b) => {
                        if (a.sectionId == null)
                            return -1;
                        if (b.sectionId == null)
                            return 1;
                        return a.sectionId.localeCompare(b.sectionId);
                    };
                case clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_SectionName:
                    return (a, b) => {
                        if (a.sectionName == null)
                            return -1;
                        if (b.sectionName == null)
                            return 1;
                        return a.sectionName.localeCompare(b.sectionName);
                    };
                case clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_SkillId:
                    return (a, b) => {
                        return a.skillId.localeCompare(b.skillId);
                    };
                case clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_UpdDate:
                    return (a, b) => {
                        if (a.updDate == null)
                            return -1;
                        if (b.updDate == null)
                            return 1;
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_UpdUser:
                    return (a, b) => {
                        if (a.updUser == null)
                            return -1;
                        if (b.updUser == null)
                            return 1;
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                case clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_SkillName:
                    return (a, b) => {
                        if (a.skillName == null)
                            return -1;
                        if (b.skillName == null)
                            return 1;
                        return a.skillName.localeCompare(b.skillName);
                    };
                case clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_OperationTypeId:
                    return (a, b) => {
                        if (a.operationTypeId == null)
                            return -1;
                        if (b.operationTypeId == null)
                            return 1;
                        return a.operationTypeId.localeCompare(b.operationTypeId);
                    };
                case clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_OperationTypeName:
                    return (a, b) => {
                        if (a.operationTypeName == null)
                            return -1;
                        if (b.operationTypeName == null)
                            return 1;
                        return a.operationTypeName.localeCompare(b.operationTypeName);
                    };
                case clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_LevelName:
                    return (a, b) => {
                        if (a.levelName == null)
                            return -1;
                        if (b.levelName == null)
                            return 1;
                        return a.levelName.localeCompare(b.levelName);
                    };
                case clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_LevelId:
                    return (a, b) => {
                        if (a.levelId == null)
                            return -1;
                        if (b.levelId == null)
                            return 1;
                        return a.levelId.localeCompare(b.levelId);
                    };
                case clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_Process:
                    return (a, b) => {
                        if (a.process == null)
                            return -1;
                        if (b.process == null)
                            return 1;
                        return a.process.localeCompare(b.process);
                    };
                case clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_IsSubmit:
                    return (a, b) => {
                        if (a.isSubmit == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_OkCount:
                    return (a, b) => {
                        return a.okCount - b.okCount;
                    };
                case clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_Score:
                    return (a, b) => {
                        return a.score - b.score;
                    };
                case clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_AppraiseCount:
                    return (a, b) => {
                        return a.appraiseCount - b.appraiseCount;
                    };
                case clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_StuScore:
                    return (a, b) => {
                        return a.stuScore - b.stuScore;
                    };
                case clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_TeaScore:
                    return (a, b) => {
                        return a.teaScore - b.teaScore;
                    };
                case clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_CitationCount:
                    return (a, b) => {
                        return a.citationCount - b.citationCount;
                    };
                case clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_VersionCount:
                    return (a, b) => {
                        return a.versionCount - b.versionCount;
                    };
                case clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_SkillUserId:
                    return (a, b) => {
                        if (a.skillUserId == null)
                            return -1;
                        if (b.skillUserId == null)
                            return 1;
                        return a.skillUserId.localeCompare(b.skillUserId);
                    };
                case clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_SkillDate:
                    return (a, b) => {
                        if (a.skillDate == null)
                            return -1;
                        if (b.skillDate == null)
                            return 1;
                        return a.skillDate.localeCompare(b.skillDate);
                    };
                case clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_CreateDate:
                    return (a, b) => {
                        if (a.createDate == null)
                            return -1;
                        if (b.createDate == null)
                            return 1;
                        return a.createDate.localeCompare(b.createDate);
                    };
                case clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_ShareId:
                    return (a, b) => {
                        if (a.shareId == null)
                            return -1;
                        if (b.shareId == null)
                            return 1;
                        return a.shareId.localeCompare(b.shareId);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vgs_PSkillRela]中不存在！(in ${exports.vgs_PSkillRela_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_mId:
                    return (a, b) => {
                        return b.mId - a.mId;
                    };
                case clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_PaperId:
                    return (a, b) => {
                        return b.paperId.localeCompare(a.paperId);
                    };
                case clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_PaperTitle:
                    return (a, b) => {
                        if (b.paperTitle == null)
                            return -1;
                        if (a.paperTitle == null)
                            return 1;
                        return b.paperTitle.localeCompare(a.paperTitle);
                    };
                case clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_PaperTypeId:
                    return (a, b) => {
                        if (b.paperTypeId == null)
                            return -1;
                        if (a.paperTypeId == null)
                            return 1;
                        return b.paperTypeId.localeCompare(a.paperTypeId);
                    };
                case clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_SectionId:
                    return (a, b) => {
                        if (b.sectionId == null)
                            return -1;
                        if (a.sectionId == null)
                            return 1;
                        return b.sectionId.localeCompare(a.sectionId);
                    };
                case clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_SectionName:
                    return (a, b) => {
                        if (b.sectionName == null)
                            return -1;
                        if (a.sectionName == null)
                            return 1;
                        return b.sectionName.localeCompare(a.sectionName);
                    };
                case clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_SkillId:
                    return (a, b) => {
                        return b.skillId.localeCompare(a.skillId);
                    };
                case clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_UpdDate:
                    return (a, b) => {
                        if (b.updDate == null)
                            return -1;
                        if (a.updDate == null)
                            return 1;
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_UpdUser:
                    return (a, b) => {
                        if (b.updUser == null)
                            return -1;
                        if (a.updUser == null)
                            return 1;
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                case clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_SkillName:
                    return (a, b) => {
                        if (b.skillName == null)
                            return -1;
                        if (a.skillName == null)
                            return 1;
                        return b.skillName.localeCompare(a.skillName);
                    };
                case clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_OperationTypeId:
                    return (a, b) => {
                        if (b.operationTypeId == null)
                            return -1;
                        if (a.operationTypeId == null)
                            return 1;
                        return b.operationTypeId.localeCompare(a.operationTypeId);
                    };
                case clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_OperationTypeName:
                    return (a, b) => {
                        if (b.operationTypeName == null)
                            return -1;
                        if (a.operationTypeName == null)
                            return 1;
                        return b.operationTypeName.localeCompare(a.operationTypeName);
                    };
                case clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_LevelName:
                    return (a, b) => {
                        if (b.levelName == null)
                            return -1;
                        if (a.levelName == null)
                            return 1;
                        return b.levelName.localeCompare(a.levelName);
                    };
                case clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_LevelId:
                    return (a, b) => {
                        if (b.levelId == null)
                            return -1;
                        if (a.levelId == null)
                            return 1;
                        return b.levelId.localeCompare(a.levelId);
                    };
                case clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_Process:
                    return (a, b) => {
                        if (b.process == null)
                            return -1;
                        if (a.process == null)
                            return 1;
                        return b.process.localeCompare(a.process);
                    };
                case clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_IsSubmit:
                    return (a, b) => {
                        if (b.isSubmit == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_OkCount:
                    return (a, b) => {
                        return b.okCount - a.okCount;
                    };
                case clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_Score:
                    return (a, b) => {
                        return b.score - a.score;
                    };
                case clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_AppraiseCount:
                    return (a, b) => {
                        return b.appraiseCount - a.appraiseCount;
                    };
                case clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_StuScore:
                    return (a, b) => {
                        return b.stuScore - a.stuScore;
                    };
                case clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_TeaScore:
                    return (a, b) => {
                        return b.teaScore - a.teaScore;
                    };
                case clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_CitationCount:
                    return (a, b) => {
                        return b.citationCount - a.citationCount;
                    };
                case clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_VersionCount:
                    return (a, b) => {
                        return b.versionCount - a.versionCount;
                    };
                case clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_SkillUserId:
                    return (a, b) => {
                        if (b.skillUserId == null)
                            return -1;
                        if (a.skillUserId == null)
                            return 1;
                        return b.skillUserId.localeCompare(a.skillUserId);
                    };
                case clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_SkillDate:
                    return (a, b) => {
                        if (b.skillDate == null)
                            return -1;
                        if (a.skillDate == null)
                            return 1;
                        return b.skillDate.localeCompare(a.skillDate);
                    };
                case clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_CreateDate:
                    return (a, b) => {
                        if (b.createDate == null)
                            return -1;
                        if (a.createDate == null)
                            return 1;
                        return b.createDate.localeCompare(a.createDate);
                    };
                case clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_ShareId:
                    return (a, b) => {
                        if (b.shareId == null)
                            return -1;
                        if (a.shareId == null)
                            return 1;
                        return b.shareId.localeCompare(a.shareId);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vgs_PSkillRela]中不存在！(in ${exports.vgs_PSkillRela_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.vgs_PSkillRela_SortFunByKey = vgs_PSkillRela_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function vgs_PSkillRela_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_mId:
                return (obj) => {
                    return obj.mId === value;
                };
            case clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_PaperId:
                return (obj) => {
                    return obj.paperId === value;
                };
            case clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_PaperTitle:
                return (obj) => {
                    return obj.paperTitle === value;
                };
            case clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_PaperTypeId:
                return (obj) => {
                    return obj.paperTypeId === value;
                };
            case clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_SectionId:
                return (obj) => {
                    return obj.sectionId === value;
                };
            case clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_SectionName:
                return (obj) => {
                    return obj.sectionName === value;
                };
            case clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_SkillId:
                return (obj) => {
                    return obj.skillId === value;
                };
            case clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            case clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_SkillName:
                return (obj) => {
                    return obj.skillName === value;
                };
            case clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_OperationTypeId:
                return (obj) => {
                    return obj.operationTypeId === value;
                };
            case clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_OperationTypeName:
                return (obj) => {
                    return obj.operationTypeName === value;
                };
            case clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_LevelName:
                return (obj) => {
                    return obj.levelName === value;
                };
            case clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_LevelId:
                return (obj) => {
                    return obj.levelId === value;
                };
            case clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_Process:
                return (obj) => {
                    return obj.process === value;
                };
            case clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_IsSubmit:
                return (obj) => {
                    return obj.isSubmit === value;
                };
            case clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_OkCount:
                return (obj) => {
                    return obj.okCount === value;
                };
            case clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_Score:
                return (obj) => {
                    return obj.score === value;
                };
            case clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_AppraiseCount:
                return (obj) => {
                    return obj.appraiseCount === value;
                };
            case clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_StuScore:
                return (obj) => {
                    return obj.stuScore === value;
                };
            case clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_TeaScore:
                return (obj) => {
                    return obj.teaScore === value;
                };
            case clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_CitationCount:
                return (obj) => {
                    return obj.citationCount === value;
                };
            case clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_VersionCount:
                return (obj) => {
                    return obj.versionCount === value;
                };
            case clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_SkillUserId:
                return (obj) => {
                    return obj.skillUserId === value;
                };
            case clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_SkillDate:
                return (obj) => {
                    return obj.skillDate === value;
                };
            case clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_CreateDate:
                return (obj) => {
                    return obj.createDate === value;
                };
            case clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_ShareId:
                return (obj) => {
                    return obj.shareId === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[vgs_PSkillRela]中不存在！(in ${exports.vgs_PSkillRela_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.vgs_PSkillRela_FilterFunByKey = vgs_PSkillRela_FilterFunByKey;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function vgs_PSkillRela_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PSkillRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PSkillRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PSkillRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PSkillRela_GetFirstIDAsync = vgs_PSkillRela_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function vgs_PSkillRela_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PSkillRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PSkillRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PSkillRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PSkillRela_GetFirstID = vgs_PSkillRela_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function vgs_PSkillRela_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PSkillRela_Controller, strAction);
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
                const objvgs_PSkillRela = vgs_PSkillRela_GetObjFromJsonObj(returnObj);
                return objvgs_PSkillRela;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PSkillRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PSkillRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PSkillRela_GetFirstObjAsync = vgs_PSkillRela_GetFirstObjAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function vgs_PSkillRela_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PSkillRela_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vgs_PSkillRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vgs_PSkillRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PSkillRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PSkillRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PSkillRela_GetObjLstAsync = vgs_PSkillRela_GetObjLstAsync;
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
    async function vgs_PSkillRela_GetObjLstBymIdLstAsync(arrmId) {
        const strThisFuncName = "GetObjLstBymIdLstAsync";
        const strAction = "GetObjLstBymIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PSkillRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrmId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vgs_PSkillRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vgs_PSkillRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PSkillRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PSkillRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PSkillRela_GetObjLstBymIdLstAsync = vgs_PSkillRela_GetObjLstBymIdLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function vgs_PSkillRela_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PSkillRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vgs_PSkillRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vgs_PSkillRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PSkillRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PSkillRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PSkillRela_GetTopObjLstAsync = vgs_PSkillRela_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vgs_PSkillRela_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PSkillRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vgs_PSkillRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vgs_PSkillRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PSkillRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PSkillRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PSkillRela_GetObjLstByRangeAsync = vgs_PSkillRela_GetObjLstByRangeAsync;
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
    async function vgs_PSkillRela_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PSkillRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PSkillRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PSkillRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PSkillRela_GetObjLstByRange = vgs_PSkillRela_GetObjLstByRange;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vgs_PSkillRela_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PSkillRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vgs_PSkillRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vgs_PSkillRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PSkillRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PSkillRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PSkillRela_GetObjLstByPagerAsync = vgs_PSkillRela_GetObjLstByPagerAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function vgs_PSkillRela_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PSkillRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PSkillRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PSkillRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PSkillRela_IsExistRecordAsync = vgs_PSkillRela_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param lngmId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function vgs_PSkillRela_IsExist(lngmId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PSkillRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PSkillRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PSkillRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PSkillRela_IsExist = vgs_PSkillRela_IsExist;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param lngmId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function vgs_PSkillRela_IsExistAsync(lngmId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PSkillRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PSkillRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PSkillRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PSkillRela_IsExistAsync = vgs_PSkillRela_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function vgs_PSkillRela_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PSkillRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PSkillRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PSkillRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PSkillRela_GetRecCountByCondAsync = vgs_PSkillRela_GetRecCountByCondAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function vgs_PSkillRela_GetWebApiUrl(strController, strAction) {
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
    exports.vgs_PSkillRela_GetWebApiUrl = vgs_PSkillRela_GetWebApiUrl;
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
    function vgs_PSkillRela_GetJSONStrByObj(pobjvgs_PSkillRelaEN) {
        const strThisFuncName = "GetJSONStrByObj";
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjvgs_PSkillRelaEN);
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
    exports.vgs_PSkillRela_GetJSONStrByObj = vgs_PSkillRela_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function vgs_PSkillRela_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrvgs_PSkillRelaObjLst = new Array();
        if (strJSON === "") {
            return arrvgs_PSkillRelaObjLst;
        }
        try {
            arrvgs_PSkillRelaObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrvgs_PSkillRelaObjLst;
        }
        return arrvgs_PSkillRelaObjLst;
    }
    exports.vgs_PSkillRela_GetObjLstByJSONStr = vgs_PSkillRela_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrvgs_PSkillRelaObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function vgs_PSkillRela_GetObjLstByJSONObjLst(arrvgs_PSkillRelaObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrvgs_PSkillRelaObjLst = new Array();
        for (const objInFor of arrvgs_PSkillRelaObjLstS) {
            const obj1 = vgs_PSkillRela_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrvgs_PSkillRelaObjLst.push(obj1);
        }
        return arrvgs_PSkillRelaObjLst;
    }
    exports.vgs_PSkillRela_GetObjLstByJSONObjLst = vgs_PSkillRela_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vgs_PSkillRela_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjvgs_PSkillRelaEN = new clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN();
        if (strJSON === "") {
            return pobjvgs_PSkillRelaEN;
        }
        try {
            pobjvgs_PSkillRelaEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjvgs_PSkillRelaEN;
        }
        return pobjvgs_PSkillRelaEN;
    }
    exports.vgs_PSkillRela_GetObjByJSONStr = vgs_PSkillRela_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function vgs_PSkillRela_GetCombineCondition(objvgs_PSkillRela_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objvgs_PSkillRela_Cond.dicFldComparisonOp, clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_mId) == true) {
            const strComparisonOp_mId = objvgs_PSkillRela_Cond.dicFldComparisonOp[clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_mId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_mId, objvgs_PSkillRela_Cond.mId, strComparisonOp_mId);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PSkillRela_Cond.dicFldComparisonOp, clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_PaperId) == true) {
            const strComparisonOp_PaperId = objvgs_PSkillRela_Cond.dicFldComparisonOp[clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_PaperId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_PaperId, objvgs_PSkillRela_Cond.paperId, strComparisonOp_PaperId);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PSkillRela_Cond.dicFldComparisonOp, clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_PaperTitle) == true) {
            const strComparisonOp_PaperTitle = objvgs_PSkillRela_Cond.dicFldComparisonOp[clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_PaperTitle];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_PaperTitle, objvgs_PSkillRela_Cond.paperTitle, strComparisonOp_PaperTitle);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PSkillRela_Cond.dicFldComparisonOp, clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_PaperTypeId) == true) {
            const strComparisonOp_PaperTypeId = objvgs_PSkillRela_Cond.dicFldComparisonOp[clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_PaperTypeId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_PaperTypeId, objvgs_PSkillRela_Cond.paperTypeId, strComparisonOp_PaperTypeId);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PSkillRela_Cond.dicFldComparisonOp, clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_SectionId) == true) {
            const strComparisonOp_SectionId = objvgs_PSkillRela_Cond.dicFldComparisonOp[clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_SectionId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_SectionId, objvgs_PSkillRela_Cond.sectionId, strComparisonOp_SectionId);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PSkillRela_Cond.dicFldComparisonOp, clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_SectionName) == true) {
            const strComparisonOp_SectionName = objvgs_PSkillRela_Cond.dicFldComparisonOp[clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_SectionName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_SectionName, objvgs_PSkillRela_Cond.sectionName, strComparisonOp_SectionName);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PSkillRela_Cond.dicFldComparisonOp, clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_SkillId) == true) {
            const strComparisonOp_SkillId = objvgs_PSkillRela_Cond.dicFldComparisonOp[clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_SkillId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_SkillId, objvgs_PSkillRela_Cond.skillId, strComparisonOp_SkillId);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PSkillRela_Cond.dicFldComparisonOp, clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objvgs_PSkillRela_Cond.dicFldComparisonOp[clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_UpdDate, objvgs_PSkillRela_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PSkillRela_Cond.dicFldComparisonOp, clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objvgs_PSkillRela_Cond.dicFldComparisonOp[clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_UpdUser];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_UpdUser, objvgs_PSkillRela_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PSkillRela_Cond.dicFldComparisonOp, clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_Memo) == true) {
            const strComparisonOp_Memo = objvgs_PSkillRela_Cond.dicFldComparisonOp[clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_Memo, objvgs_PSkillRela_Cond.memo, strComparisonOp_Memo);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PSkillRela_Cond.dicFldComparisonOp, clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_SkillName) == true) {
            const strComparisonOp_SkillName = objvgs_PSkillRela_Cond.dicFldComparisonOp[clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_SkillName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_SkillName, objvgs_PSkillRela_Cond.skillName, strComparisonOp_SkillName);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PSkillRela_Cond.dicFldComparisonOp, clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_OperationTypeId) == true) {
            const strComparisonOp_OperationTypeId = objvgs_PSkillRela_Cond.dicFldComparisonOp[clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_OperationTypeId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_OperationTypeId, objvgs_PSkillRela_Cond.operationTypeId, strComparisonOp_OperationTypeId);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PSkillRela_Cond.dicFldComparisonOp, clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_OperationTypeName) == true) {
            const strComparisonOp_OperationTypeName = objvgs_PSkillRela_Cond.dicFldComparisonOp[clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_OperationTypeName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_OperationTypeName, objvgs_PSkillRela_Cond.operationTypeName, strComparisonOp_OperationTypeName);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PSkillRela_Cond.dicFldComparisonOp, clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_LevelName) == true) {
            const strComparisonOp_LevelName = objvgs_PSkillRela_Cond.dicFldComparisonOp[clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_LevelName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_LevelName, objvgs_PSkillRela_Cond.levelName, strComparisonOp_LevelName);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PSkillRela_Cond.dicFldComparisonOp, clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_LevelId) == true) {
            const strComparisonOp_LevelId = objvgs_PSkillRela_Cond.dicFldComparisonOp[clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_LevelId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_LevelId, objvgs_PSkillRela_Cond.levelId, strComparisonOp_LevelId);
        }
        //数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
        if (Object.prototype.hasOwnProperty.call(objvgs_PSkillRela_Cond.dicFldComparisonOp, clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_IsSubmit) == true) {
            if (objvgs_PSkillRela_Cond.isSubmit == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_IsSubmit);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_IsSubmit);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PSkillRela_Cond.dicFldComparisonOp, clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_OkCount) == true) {
            const strComparisonOp_OkCount = objvgs_PSkillRela_Cond.dicFldComparisonOp[clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_OkCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_OkCount, objvgs_PSkillRela_Cond.okCount, strComparisonOp_OkCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PSkillRela_Cond.dicFldComparisonOp, clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_Score) == true) {
            const strComparisonOp_Score = objvgs_PSkillRela_Cond.dicFldComparisonOp[clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_Score];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_Score, objvgs_PSkillRela_Cond.score, strComparisonOp_Score);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PSkillRela_Cond.dicFldComparisonOp, clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_AppraiseCount) == true) {
            const strComparisonOp_AppraiseCount = objvgs_PSkillRela_Cond.dicFldComparisonOp[clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_AppraiseCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_AppraiseCount, objvgs_PSkillRela_Cond.appraiseCount, strComparisonOp_AppraiseCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PSkillRela_Cond.dicFldComparisonOp, clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_StuScore) == true) {
            const strComparisonOp_StuScore = objvgs_PSkillRela_Cond.dicFldComparisonOp[clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_StuScore];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_StuScore, objvgs_PSkillRela_Cond.stuScore, strComparisonOp_StuScore);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PSkillRela_Cond.dicFldComparisonOp, clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_TeaScore) == true) {
            const strComparisonOp_TeaScore = objvgs_PSkillRela_Cond.dicFldComparisonOp[clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_TeaScore];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_TeaScore, objvgs_PSkillRela_Cond.teaScore, strComparisonOp_TeaScore);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PSkillRela_Cond.dicFldComparisonOp, clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_CitationCount) == true) {
            const strComparisonOp_CitationCount = objvgs_PSkillRela_Cond.dicFldComparisonOp[clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_CitationCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_CitationCount, objvgs_PSkillRela_Cond.citationCount, strComparisonOp_CitationCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PSkillRela_Cond.dicFldComparisonOp, clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_VersionCount) == true) {
            const strComparisonOp_VersionCount = objvgs_PSkillRela_Cond.dicFldComparisonOp[clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_VersionCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_VersionCount, objvgs_PSkillRela_Cond.versionCount, strComparisonOp_VersionCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PSkillRela_Cond.dicFldComparisonOp, clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_SkillUserId) == true) {
            const strComparisonOp_SkillUserId = objvgs_PSkillRela_Cond.dicFldComparisonOp[clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_SkillUserId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_SkillUserId, objvgs_PSkillRela_Cond.skillUserId, strComparisonOp_SkillUserId);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PSkillRela_Cond.dicFldComparisonOp, clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_SkillDate) == true) {
            const strComparisonOp_SkillDate = objvgs_PSkillRela_Cond.dicFldComparisonOp[clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_SkillDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_SkillDate, objvgs_PSkillRela_Cond.skillDate, strComparisonOp_SkillDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PSkillRela_Cond.dicFldComparisonOp, clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_CreateDate) == true) {
            const strComparisonOp_CreateDate = objvgs_PSkillRela_Cond.dicFldComparisonOp[clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_CreateDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_CreateDate, objvgs_PSkillRela_Cond.createDate, strComparisonOp_CreateDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PSkillRela_Cond.dicFldComparisonOp, clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_ShareId) == true) {
            const strComparisonOp_ShareId = objvgs_PSkillRela_Cond.dicFldComparisonOp[clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_ShareId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN.con_ShareId, objvgs_PSkillRela_Cond.shareId, strComparisonOp_ShareId);
        }
        return strWhereCond;
    }
    exports.vgs_PSkillRela_GetCombineCondition = vgs_PSkillRela_GetCombineCondition;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objvgs_PSkillRelaENS:源对象
     * @param objvgs_PSkillRelaENT:目标对象
    */
    function vgs_PSkillRela_CopyObjTo(objvgs_PSkillRelaENS, objvgs_PSkillRelaENT) {
        objvgs_PSkillRelaENT.mId = objvgs_PSkillRelaENS.mId; //mId
        objvgs_PSkillRelaENT.paperId = objvgs_PSkillRelaENS.paperId; //论文Id
        objvgs_PSkillRelaENT.paperTitle = objvgs_PSkillRelaENS.paperTitle; //论文标题
        objvgs_PSkillRelaENT.paperTypeId = objvgs_PSkillRelaENS.paperTypeId; //论文类型Id
        objvgs_PSkillRelaENT.sectionId = objvgs_PSkillRelaENS.sectionId; //节Id
        objvgs_PSkillRelaENT.sectionName = objvgs_PSkillRelaENS.sectionName; //节名
        objvgs_PSkillRelaENT.skillId = objvgs_PSkillRelaENS.skillId; //技能Id
        objvgs_PSkillRelaENT.updDate = objvgs_PSkillRelaENS.updDate; //修改日期
        objvgs_PSkillRelaENT.updUser = objvgs_PSkillRelaENS.updUser; //修改人
        objvgs_PSkillRelaENT.memo = objvgs_PSkillRelaENS.memo; //备注
        objvgs_PSkillRelaENT.skillName = objvgs_PSkillRelaENS.skillName; //技能名称
        objvgs_PSkillRelaENT.operationTypeId = objvgs_PSkillRelaENS.operationTypeId; //操作类型ID
        objvgs_PSkillRelaENT.operationTypeName = objvgs_PSkillRelaENS.operationTypeName; //操作类型名
        objvgs_PSkillRelaENT.levelName = objvgs_PSkillRelaENS.levelName; //级别名称
        objvgs_PSkillRelaENT.levelId = objvgs_PSkillRelaENS.levelId; //级别Id
        objvgs_PSkillRelaENT.process = objvgs_PSkillRelaENS.process; //实施过程
        objvgs_PSkillRelaENT.isSubmit = objvgs_PSkillRelaENS.isSubmit; //是否提交
        objvgs_PSkillRelaENT.okCount = objvgs_PSkillRelaENS.okCount; //点赞统计
        objvgs_PSkillRelaENT.score = objvgs_PSkillRelaENS.score; //评分
        objvgs_PSkillRelaENT.appraiseCount = objvgs_PSkillRelaENS.appraiseCount; //评论数
        objvgs_PSkillRelaENT.stuScore = objvgs_PSkillRelaENS.stuScore; //学生平均分
        objvgs_PSkillRelaENT.teaScore = objvgs_PSkillRelaENS.teaScore; //教师评分
        objvgs_PSkillRelaENT.citationCount = objvgs_PSkillRelaENS.citationCount; //引用统计
        objvgs_PSkillRelaENT.versionCount = objvgs_PSkillRelaENS.versionCount; //版本统计
        objvgs_PSkillRelaENT.skillUserId = objvgs_PSkillRelaENS.skillUserId; //SkillUserId
        objvgs_PSkillRelaENT.skillDate = objvgs_PSkillRelaENS.skillDate; //SkillDate
        objvgs_PSkillRelaENT.createDate = objvgs_PSkillRelaENS.createDate; //建立日期
        objvgs_PSkillRelaENT.shareId = objvgs_PSkillRelaENS.shareId; //分享Id
    }
    exports.vgs_PSkillRela_CopyObjTo = vgs_PSkillRela_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objvgs_PSkillRelaENS:源对象
     * @param objvgs_PSkillRelaENT:目标对象
    */
    function vgs_PSkillRela_GetObjFromJsonObj(objvgs_PSkillRelaENS) {
        const objvgs_PSkillRelaENT = new clsvgs_PSkillRelaEN_js_1.clsvgs_PSkillRelaEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvgs_PSkillRelaENT, objvgs_PSkillRelaENS);
        return objvgs_PSkillRelaENT;
    }
    exports.vgs_PSkillRela_GetObjFromJsonObj = vgs_PSkillRela_GetObjFromJsonObj;
});
