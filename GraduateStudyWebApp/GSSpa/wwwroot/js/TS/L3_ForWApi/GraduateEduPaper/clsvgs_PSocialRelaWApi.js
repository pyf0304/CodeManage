/**
* 类名:clsvgs_PSocialRelaWApi
* 表名:vgs_PSocialRela(01120665)
* 生成代码版本:2022.11.02.1
* 生成日期:2022/11/02 12:02:41
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
        define(["require", "exports", "axios", "../../L0_Entity/GraduateEduPaper/clsvgs_PSocialRelaEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsSysPara4WebApi.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.vgs_PSocialRela_GetObjFromJsonObj = exports.vgs_PSocialRela_CopyObjTo = exports.vgs_PSocialRela_GetCombineCondition = exports.vgs_PSocialRela_GetObjByJSONStr = exports.vgs_PSocialRela_GetObjLstByJSONObjLst = exports.vgs_PSocialRela_GetObjLstByJSONStr = exports.vgs_PSocialRela_GetJSONStrByObj = exports.vgs_PSocialRela_GetWebApiUrl = exports.vgs_PSocialRela_GetRecCountByCondAsync = exports.vgs_PSocialRela_IsExistAsync = exports.vgs_PSocialRela_IsExist = exports.vgs_PSocialRela_IsExistRecordAsync = exports.vgs_PSocialRela_GetObjLstByPagerAsync = exports.vgs_PSocialRela_GetObjLstByRange = exports.vgs_PSocialRela_GetObjLstByRangeAsync = exports.vgs_PSocialRela_GetTopObjLstAsync = exports.vgs_PSocialRela_GetObjLstBymIdLstAsync = exports.vgs_PSocialRela_GetObjLstAsync = exports.vgs_PSocialRela_GetFirstObjAsync = exports.vgs_PSocialRela_GetFirstID = exports.vgs_PSocialRela_GetFirstIDAsync = exports.vgs_PSocialRela_FilterFunByKey = exports.vgs_PSocialRela_SortFunByKey = exports.vgs_PSocialRela_SortFun_Defa_2Fld = exports.vgs_PSocialRela_SortFun_Defa = exports.vgs_PSocialRela_GetObjBymIdAsync = exports.vgs_PSocialRela_ConstructorName = exports.vgs_PSocialRela_Controller = void 0;
    /**
     * 论文社会关系视图(vgs_PSocialRela)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2022年11月02日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const clsvgs_PSocialRelaEN_js_1 = require("../../L0_Entity/GraduateEduPaper/clsvgs_PSocialRelaEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.vgs_PSocialRela_Controller = "vgs_PSocialRelaApi";
    exports.vgs_PSocialRela_ConstructorName = "vgs_PSocialRela";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param lngmId:关键字
    * @returns 对象
    **/
    async function vgs_PSocialRela_GetObjBymIdAsync(lngmId) {
        const strThisFuncName = "GetObjBymIdAsync";
        if (lngmId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngmId]不能为空！(In GetObjBymIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjBymId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PSocialRela_Controller, strAction);
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
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vgs_PSocialRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objvgs_PSocialRela = vgs_PSocialRela_GetObjFromJsonObj(returnObj);
                return objvgs_PSocialRela;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PSocialRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PSocialRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PSocialRela_GetObjBymIdAsync = vgs_PSocialRela_GetObjBymIdAsync;
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
    function vgs_PSocialRela_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.mId - b.mId;
    }
    exports.vgs_PSocialRela_SortFun_Defa = vgs_PSocialRela_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vgs_PSocialRela_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.paperId == b.paperId)
            return a.paperTitle.localeCompare(b.paperTitle);
        else
            return a.paperId.localeCompare(b.paperId);
    }
    exports.vgs_PSocialRela_SortFun_Defa_2Fld = vgs_PSocialRela_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vgs_PSocialRela_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_mId:
                    return (a, b) => {
                        return a.mId - b.mId;
                    };
                case clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_PaperId:
                    return (a, b) => {
                        return a.paperId.localeCompare(b.paperId);
                    };
                case clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_PaperTitle:
                    return (a, b) => {
                        return a.paperTitle.localeCompare(b.paperTitle);
                    };
                case clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_PaperTypeId:
                    return (a, b) => {
                        return a.paperTypeId.localeCompare(b.paperTypeId);
                    };
                case clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_SectionId:
                    return (a, b) => {
                        return a.sectionId.localeCompare(b.sectionId);
                    };
                case clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_SectionName:
                    return (a, b) => {
                        return a.sectionName.localeCompare(b.sectionName);
                    };
                case clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_SocialId:
                    return (a, b) => {
                        return a.socialId.localeCompare(b.socialId);
                    };
                case clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_UpdDate:
                    return (a, b) => {
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_UpdUser:
                    return (a, b) => {
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_Memo:
                    return (a, b) => {
                        return a.memo.localeCompare(b.memo);
                    };
                case clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_FullName:
                    return (a, b) => {
                        return a.fullName.localeCompare(b.fullName);
                    };
                case clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_Nationality:
                    return (a, b) => {
                        return a.nationality.localeCompare(b.nationality);
                    };
                case clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_WorkUnit:
                    return (a, b) => {
                        return a.workUnit.localeCompare(b.workUnit);
                    };
                case clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_Major:
                    return (a, b) => {
                        return a.major.localeCompare(b.major);
                    };
                case clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_Achievement:
                    return (a, b) => {
                        return a.achievement.localeCompare(b.achievement);
                    };
                case clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_DetailedDescription:
                    return (a, b) => {
                        return a.detailedDescription.localeCompare(b.detailedDescription);
                    };
                case clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_LevelId:
                    return (a, b) => {
                        return a.levelId.localeCompare(b.levelId);
                    };
                case clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_LevelName:
                    return (a, b) => {
                        return a.levelName.localeCompare(b.levelName);
                    };
                case clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_IsSubmit:
                    return (a, b) => {
                        if (a.isSubmit == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_OkCount:
                    return (a, b) => {
                        return a.okCount - b.okCount;
                    };
                case clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_CitationCount:
                    return (a, b) => {
                        return a.citationCount - b.citationCount;
                    };
                case clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_VersionCount:
                    return (a, b) => {
                        return a.versionCount - b.versionCount;
                    };
                case clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_AppraiseCount:
                    return (a, b) => {
                        return a.appraiseCount - b.appraiseCount;
                    };
                case clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_score:
                    return (a, b) => {
                        return a.score - b.score;
                    };
                case clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_StuScore:
                    return (a, b) => {
                        return a.stuScore - b.stuScore;
                    };
                case clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_TeaScore:
                    return (a, b) => {
                        return a.teaScore - b.teaScore;
                    };
                case clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_SocialUserId:
                    return (a, b) => {
                        return a.socialUserId.localeCompare(b.socialUserId);
                    };
                case clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_SocialDate:
                    return (a, b) => {
                        return a.socialDate.localeCompare(b.socialDate);
                    };
                case clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_CreateDate:
                    return (a, b) => {
                        return a.createDate.localeCompare(b.createDate);
                    };
                case clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_ShareId:
                    return (a, b) => {
                        return a.shareId.localeCompare(b.shareId);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vgs_PSocialRela]中不存在！(in ${exports.vgs_PSocialRela_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_mId:
                    return (a, b) => {
                        return b.mId - a.mId;
                    };
                case clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_PaperId:
                    return (a, b) => {
                        return b.paperId.localeCompare(a.paperId);
                    };
                case clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_PaperTitle:
                    return (a, b) => {
                        return b.paperTitle.localeCompare(a.paperTitle);
                    };
                case clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_PaperTypeId:
                    return (a, b) => {
                        return b.paperTypeId.localeCompare(a.paperTypeId);
                    };
                case clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_SectionId:
                    return (a, b) => {
                        return b.sectionId.localeCompare(a.sectionId);
                    };
                case clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_SectionName:
                    return (a, b) => {
                        return b.sectionName.localeCompare(a.sectionName);
                    };
                case clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_SocialId:
                    return (a, b) => {
                        return b.socialId.localeCompare(a.socialId);
                    };
                case clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_UpdDate:
                    return (a, b) => {
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_UpdUser:
                    return (a, b) => {
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_Memo:
                    return (a, b) => {
                        return b.memo.localeCompare(a.memo);
                    };
                case clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_FullName:
                    return (a, b) => {
                        return b.fullName.localeCompare(a.fullName);
                    };
                case clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_Nationality:
                    return (a, b) => {
                        return b.nationality.localeCompare(a.nationality);
                    };
                case clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_WorkUnit:
                    return (a, b) => {
                        return b.workUnit.localeCompare(a.workUnit);
                    };
                case clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_Major:
                    return (a, b) => {
                        return b.major.localeCompare(a.major);
                    };
                case clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_Achievement:
                    return (a, b) => {
                        return b.achievement.localeCompare(a.achievement);
                    };
                case clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_DetailedDescription:
                    return (a, b) => {
                        return b.detailedDescription.localeCompare(a.detailedDescription);
                    };
                case clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_LevelId:
                    return (a, b) => {
                        return b.levelId.localeCompare(a.levelId);
                    };
                case clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_LevelName:
                    return (a, b) => {
                        return b.levelName.localeCompare(a.levelName);
                    };
                case clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_IsSubmit:
                    return (a, b) => {
                        if (b.isSubmit == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_OkCount:
                    return (a, b) => {
                        return b.okCount - a.okCount;
                    };
                case clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_CitationCount:
                    return (a, b) => {
                        return b.citationCount - a.citationCount;
                    };
                case clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_VersionCount:
                    return (a, b) => {
                        return b.versionCount - a.versionCount;
                    };
                case clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_AppraiseCount:
                    return (a, b) => {
                        return b.appraiseCount - a.appraiseCount;
                    };
                case clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_score:
                    return (a, b) => {
                        return b.score - a.score;
                    };
                case clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_StuScore:
                    return (a, b) => {
                        return b.stuScore - a.stuScore;
                    };
                case clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_TeaScore:
                    return (a, b) => {
                        return b.teaScore - a.teaScore;
                    };
                case clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_SocialUserId:
                    return (a, b) => {
                        return b.socialUserId.localeCompare(a.socialUserId);
                    };
                case clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_SocialDate:
                    return (a, b) => {
                        return b.socialDate.localeCompare(a.socialDate);
                    };
                case clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_CreateDate:
                    return (a, b) => {
                        return b.createDate.localeCompare(a.createDate);
                    };
                case clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_ShareId:
                    return (a, b) => {
                        return b.shareId.localeCompare(a.shareId);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vgs_PSocialRela]中不存在！(in ${exports.vgs_PSocialRela_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.vgs_PSocialRela_SortFunByKey = vgs_PSocialRela_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function vgs_PSocialRela_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_mId:
                return (obj) => {
                    return obj.mId === value;
                };
            case clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_PaperId:
                return (obj) => {
                    return obj.paperId === value;
                };
            case clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_PaperTitle:
                return (obj) => {
                    return obj.paperTitle === value;
                };
            case clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_PaperTypeId:
                return (obj) => {
                    return obj.paperTypeId === value;
                };
            case clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_SectionId:
                return (obj) => {
                    return obj.sectionId === value;
                };
            case clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_SectionName:
                return (obj) => {
                    return obj.sectionName === value;
                };
            case clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_SocialId:
                return (obj) => {
                    return obj.socialId === value;
                };
            case clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            case clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_FullName:
                return (obj) => {
                    return obj.fullName === value;
                };
            case clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_Nationality:
                return (obj) => {
                    return obj.nationality === value;
                };
            case clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_WorkUnit:
                return (obj) => {
                    return obj.workUnit === value;
                };
            case clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_Major:
                return (obj) => {
                    return obj.major === value;
                };
            case clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_Achievement:
                return (obj) => {
                    return obj.achievement === value;
                };
            case clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_DetailedDescription:
                return (obj) => {
                    return obj.detailedDescription === value;
                };
            case clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_LevelId:
                return (obj) => {
                    return obj.levelId === value;
                };
            case clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_LevelName:
                return (obj) => {
                    return obj.levelName === value;
                };
            case clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_IsSubmit:
                return (obj) => {
                    return obj.isSubmit === value;
                };
            case clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_OkCount:
                return (obj) => {
                    return obj.okCount === value;
                };
            case clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_CitationCount:
                return (obj) => {
                    return obj.citationCount === value;
                };
            case clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_VersionCount:
                return (obj) => {
                    return obj.versionCount === value;
                };
            case clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_AppraiseCount:
                return (obj) => {
                    return obj.appraiseCount === value;
                };
            case clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_score:
                return (obj) => {
                    return obj.score === value;
                };
            case clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_StuScore:
                return (obj) => {
                    return obj.stuScore === value;
                };
            case clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_TeaScore:
                return (obj) => {
                    return obj.teaScore === value;
                };
            case clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_SocialUserId:
                return (obj) => {
                    return obj.socialUserId === value;
                };
            case clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_SocialDate:
                return (obj) => {
                    return obj.socialDate === value;
                };
            case clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_CreateDate:
                return (obj) => {
                    return obj.createDate === value;
                };
            case clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_ShareId:
                return (obj) => {
                    return obj.shareId === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[vgs_PSocialRela]中不存在！(in ${exports.vgs_PSocialRela_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.vgs_PSocialRela_FilterFunByKey = vgs_PSocialRela_FilterFunByKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function vgs_PSocialRela_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PSocialRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PSocialRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PSocialRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PSocialRela_GetFirstIDAsync = vgs_PSocialRela_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function vgs_PSocialRela_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PSocialRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PSocialRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PSocialRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PSocialRela_GetFirstID = vgs_PSocialRela_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function vgs_PSocialRela_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PSocialRela_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vgs_PSocialRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objvgs_PSocialRela = vgs_PSocialRela_GetObjFromJsonObj(returnObj);
                return objvgs_PSocialRela;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PSocialRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PSocialRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PSocialRela_GetFirstObjAsync = vgs_PSocialRela_GetFirstObjAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function vgs_PSocialRela_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PSocialRela_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vgs_PSocialRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vgs_PSocialRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PSocialRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PSocialRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PSocialRela_GetObjLstAsync = vgs_PSocialRela_GetObjLstAsync;
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
    async function vgs_PSocialRela_GetObjLstBymIdLstAsync(arrmId) {
        const strThisFuncName = "GetObjLstBymIdLstAsync";
        const strAction = "GetObjLstBymIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PSocialRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrmId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vgs_PSocialRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vgs_PSocialRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PSocialRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PSocialRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PSocialRela_GetObjLstBymIdLstAsync = vgs_PSocialRela_GetObjLstBymIdLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function vgs_PSocialRela_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PSocialRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vgs_PSocialRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vgs_PSocialRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PSocialRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PSocialRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PSocialRela_GetTopObjLstAsync = vgs_PSocialRela_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vgs_PSocialRela_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PSocialRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vgs_PSocialRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vgs_PSocialRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PSocialRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PSocialRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PSocialRela_GetObjLstByRangeAsync = vgs_PSocialRela_GetObjLstByRangeAsync;
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
    async function vgs_PSocialRela_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PSocialRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PSocialRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PSocialRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PSocialRela_GetObjLstByRange = vgs_PSocialRela_GetObjLstByRange;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vgs_PSocialRela_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PSocialRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vgs_PSocialRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vgs_PSocialRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PSocialRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PSocialRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PSocialRela_GetObjLstByPagerAsync = vgs_PSocialRela_GetObjLstByPagerAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function vgs_PSocialRela_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PSocialRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PSocialRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PSocialRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PSocialRela_IsExistRecordAsync = vgs_PSocialRela_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param lngmId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function vgs_PSocialRela_IsExist(lngmId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PSocialRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PSocialRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PSocialRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PSocialRela_IsExist = vgs_PSocialRela_IsExist;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param lngmId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function vgs_PSocialRela_IsExistAsync(lngmId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PSocialRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PSocialRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PSocialRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PSocialRela_IsExistAsync = vgs_PSocialRela_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function vgs_PSocialRela_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PSocialRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PSocialRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PSocialRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PSocialRela_GetRecCountByCondAsync = vgs_PSocialRela_GetRecCountByCondAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function vgs_PSocialRela_GetWebApiUrl(strController, strAction) {
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
    exports.vgs_PSocialRela_GetWebApiUrl = vgs_PSocialRela_GetWebApiUrl;
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
    function vgs_PSocialRela_GetJSONStrByObj(pobjvgs_PSocialRelaEN) {
        const strThisFuncName = "GetJSONStrByObj";
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjvgs_PSocialRelaEN);
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
    exports.vgs_PSocialRela_GetJSONStrByObj = vgs_PSocialRela_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function vgs_PSocialRela_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrvgs_PSocialRelaObjLst = new Array();
        if (strJSON === "") {
            return arrvgs_PSocialRelaObjLst;
        }
        try {
            arrvgs_PSocialRelaObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrvgs_PSocialRelaObjLst;
        }
        return arrvgs_PSocialRelaObjLst;
    }
    exports.vgs_PSocialRela_GetObjLstByJSONStr = vgs_PSocialRela_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrvgs_PSocialRelaObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function vgs_PSocialRela_GetObjLstByJSONObjLst(arrvgs_PSocialRelaObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrvgs_PSocialRelaObjLst = new Array();
        for (const objInFor of arrvgs_PSocialRelaObjLstS) {
            const obj1 = vgs_PSocialRela_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrvgs_PSocialRelaObjLst.push(obj1);
        }
        return arrvgs_PSocialRelaObjLst;
    }
    exports.vgs_PSocialRela_GetObjLstByJSONObjLst = vgs_PSocialRela_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vgs_PSocialRela_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjvgs_PSocialRelaEN = new clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN();
        if (strJSON === "") {
            return pobjvgs_PSocialRelaEN;
        }
        try {
            pobjvgs_PSocialRelaEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjvgs_PSocialRelaEN;
        }
        return pobjvgs_PSocialRelaEN;
    }
    exports.vgs_PSocialRela_GetObjByJSONStr = vgs_PSocialRela_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function vgs_PSocialRela_GetCombineCondition(objvgs_PSocialRela_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objvgs_PSocialRela_Cond.dicFldComparisonOp, clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_mId) == true) {
            const strComparisonOp_mId = objvgs_PSocialRela_Cond.dicFldComparisonOp[clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_mId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_mId, objvgs_PSocialRela_Cond.mId, strComparisonOp_mId);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PSocialRela_Cond.dicFldComparisonOp, clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_PaperId) == true) {
            const strComparisonOp_PaperId = objvgs_PSocialRela_Cond.dicFldComparisonOp[clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_PaperId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_PaperId, objvgs_PSocialRela_Cond.paperId, strComparisonOp_PaperId);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PSocialRela_Cond.dicFldComparisonOp, clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_PaperTitle) == true) {
            const strComparisonOp_PaperTitle = objvgs_PSocialRela_Cond.dicFldComparisonOp[clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_PaperTitle];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_PaperTitle, objvgs_PSocialRela_Cond.paperTitle, strComparisonOp_PaperTitle);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PSocialRela_Cond.dicFldComparisonOp, clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_PaperTypeId) == true) {
            const strComparisonOp_PaperTypeId = objvgs_PSocialRela_Cond.dicFldComparisonOp[clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_PaperTypeId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_PaperTypeId, objvgs_PSocialRela_Cond.paperTypeId, strComparisonOp_PaperTypeId);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PSocialRela_Cond.dicFldComparisonOp, clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_SectionId) == true) {
            const strComparisonOp_SectionId = objvgs_PSocialRela_Cond.dicFldComparisonOp[clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_SectionId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_SectionId, objvgs_PSocialRela_Cond.sectionId, strComparisonOp_SectionId);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PSocialRela_Cond.dicFldComparisonOp, clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_SectionName) == true) {
            const strComparisonOp_SectionName = objvgs_PSocialRela_Cond.dicFldComparisonOp[clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_SectionName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_SectionName, objvgs_PSocialRela_Cond.sectionName, strComparisonOp_SectionName);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PSocialRela_Cond.dicFldComparisonOp, clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_SocialId) == true) {
            const strComparisonOp_SocialId = objvgs_PSocialRela_Cond.dicFldComparisonOp[clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_SocialId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_SocialId, objvgs_PSocialRela_Cond.socialId, strComparisonOp_SocialId);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PSocialRela_Cond.dicFldComparisonOp, clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objvgs_PSocialRela_Cond.dicFldComparisonOp[clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_UpdDate, objvgs_PSocialRela_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PSocialRela_Cond.dicFldComparisonOp, clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objvgs_PSocialRela_Cond.dicFldComparisonOp[clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_UpdUser];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_UpdUser, objvgs_PSocialRela_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PSocialRela_Cond.dicFldComparisonOp, clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_Memo) == true) {
            const strComparisonOp_Memo = objvgs_PSocialRela_Cond.dicFldComparisonOp[clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_Memo, objvgs_PSocialRela_Cond.memo, strComparisonOp_Memo);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PSocialRela_Cond.dicFldComparisonOp, clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_FullName) == true) {
            const strComparisonOp_FullName = objvgs_PSocialRela_Cond.dicFldComparisonOp[clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_FullName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_FullName, objvgs_PSocialRela_Cond.fullName, strComparisonOp_FullName);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PSocialRela_Cond.dicFldComparisonOp, clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_Nationality) == true) {
            const strComparisonOp_Nationality = objvgs_PSocialRela_Cond.dicFldComparisonOp[clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_Nationality];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_Nationality, objvgs_PSocialRela_Cond.nationality, strComparisonOp_Nationality);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PSocialRela_Cond.dicFldComparisonOp, clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_WorkUnit) == true) {
            const strComparisonOp_WorkUnit = objvgs_PSocialRela_Cond.dicFldComparisonOp[clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_WorkUnit];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_WorkUnit, objvgs_PSocialRela_Cond.workUnit, strComparisonOp_WorkUnit);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PSocialRela_Cond.dicFldComparisonOp, clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_Major) == true) {
            const strComparisonOp_Major = objvgs_PSocialRela_Cond.dicFldComparisonOp[clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_Major];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_Major, objvgs_PSocialRela_Cond.major, strComparisonOp_Major);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PSocialRela_Cond.dicFldComparisonOp, clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_Achievement) == true) {
            const strComparisonOp_Achievement = objvgs_PSocialRela_Cond.dicFldComparisonOp[clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_Achievement];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_Achievement, objvgs_PSocialRela_Cond.achievement, strComparisonOp_Achievement);
        }
        //数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
        if (Object.prototype.hasOwnProperty.call(objvgs_PSocialRela_Cond.dicFldComparisonOp, clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_LevelId) == true) {
            const strComparisonOp_LevelId = objvgs_PSocialRela_Cond.dicFldComparisonOp[clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_LevelId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_LevelId, objvgs_PSocialRela_Cond.levelId, strComparisonOp_LevelId);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PSocialRela_Cond.dicFldComparisonOp, clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_LevelName) == true) {
            const strComparisonOp_LevelName = objvgs_PSocialRela_Cond.dicFldComparisonOp[clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_LevelName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_LevelName, objvgs_PSocialRela_Cond.levelName, strComparisonOp_LevelName);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PSocialRela_Cond.dicFldComparisonOp, clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_IsSubmit) == true) {
            if (objvgs_PSocialRela_Cond.isSubmit == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_IsSubmit);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_IsSubmit);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PSocialRela_Cond.dicFldComparisonOp, clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_OkCount) == true) {
            const strComparisonOp_OkCount = objvgs_PSocialRela_Cond.dicFldComparisonOp[clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_OkCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_OkCount, objvgs_PSocialRela_Cond.okCount, strComparisonOp_OkCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PSocialRela_Cond.dicFldComparisonOp, clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_CitationCount) == true) {
            const strComparisonOp_CitationCount = objvgs_PSocialRela_Cond.dicFldComparisonOp[clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_CitationCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_CitationCount, objvgs_PSocialRela_Cond.citationCount, strComparisonOp_CitationCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PSocialRela_Cond.dicFldComparisonOp, clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_VersionCount) == true) {
            const strComparisonOp_VersionCount = objvgs_PSocialRela_Cond.dicFldComparisonOp[clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_VersionCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_VersionCount, objvgs_PSocialRela_Cond.versionCount, strComparisonOp_VersionCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PSocialRela_Cond.dicFldComparisonOp, clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_AppraiseCount) == true) {
            const strComparisonOp_AppraiseCount = objvgs_PSocialRela_Cond.dicFldComparisonOp[clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_AppraiseCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_AppraiseCount, objvgs_PSocialRela_Cond.appraiseCount, strComparisonOp_AppraiseCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PSocialRela_Cond.dicFldComparisonOp, clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_score) == true) {
            const strComparisonOp_score = objvgs_PSocialRela_Cond.dicFldComparisonOp[clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_score];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_score, objvgs_PSocialRela_Cond.score, strComparisonOp_score);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PSocialRela_Cond.dicFldComparisonOp, clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_StuScore) == true) {
            const strComparisonOp_StuScore = objvgs_PSocialRela_Cond.dicFldComparisonOp[clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_StuScore];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_StuScore, objvgs_PSocialRela_Cond.stuScore, strComparisonOp_StuScore);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PSocialRela_Cond.dicFldComparisonOp, clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_TeaScore) == true) {
            const strComparisonOp_TeaScore = objvgs_PSocialRela_Cond.dicFldComparisonOp[clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_TeaScore];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_TeaScore, objvgs_PSocialRela_Cond.teaScore, strComparisonOp_TeaScore);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PSocialRela_Cond.dicFldComparisonOp, clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_SocialUserId) == true) {
            const strComparisonOp_SocialUserId = objvgs_PSocialRela_Cond.dicFldComparisonOp[clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_SocialUserId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_SocialUserId, objvgs_PSocialRela_Cond.socialUserId, strComparisonOp_SocialUserId);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PSocialRela_Cond.dicFldComparisonOp, clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_SocialDate) == true) {
            const strComparisonOp_SocialDate = objvgs_PSocialRela_Cond.dicFldComparisonOp[clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_SocialDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_SocialDate, objvgs_PSocialRela_Cond.socialDate, strComparisonOp_SocialDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PSocialRela_Cond.dicFldComparisonOp, clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_CreateDate) == true) {
            const strComparisonOp_CreateDate = objvgs_PSocialRela_Cond.dicFldComparisonOp[clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_CreateDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_CreateDate, objvgs_PSocialRela_Cond.createDate, strComparisonOp_CreateDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PSocialRela_Cond.dicFldComparisonOp, clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_ShareId) == true) {
            const strComparisonOp_ShareId = objvgs_PSocialRela_Cond.dicFldComparisonOp[clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_ShareId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN.con_ShareId, objvgs_PSocialRela_Cond.shareId, strComparisonOp_ShareId);
        }
        return strWhereCond;
    }
    exports.vgs_PSocialRela_GetCombineCondition = vgs_PSocialRela_GetCombineCondition;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objvgs_PSocialRelaENS:源对象
     * @param objvgs_PSocialRelaENT:目标对象
    */
    function vgs_PSocialRela_CopyObjTo(objvgs_PSocialRelaENS, objvgs_PSocialRelaENT) {
        objvgs_PSocialRelaENT.mId = objvgs_PSocialRelaENS.mId; //mId
        objvgs_PSocialRelaENT.paperId = objvgs_PSocialRelaENS.paperId; //论文Id
        objvgs_PSocialRelaENT.paperTitle = objvgs_PSocialRelaENS.paperTitle; //论文标题
        objvgs_PSocialRelaENT.paperTypeId = objvgs_PSocialRelaENS.paperTypeId; //论文类型Id
        objvgs_PSocialRelaENT.sectionId = objvgs_PSocialRelaENS.sectionId; //节Id
        objvgs_PSocialRelaENT.sectionName = objvgs_PSocialRelaENS.sectionName; //节名
        objvgs_PSocialRelaENT.socialId = objvgs_PSocialRelaENS.socialId; //社会Id
        objvgs_PSocialRelaENT.updDate = objvgs_PSocialRelaENS.updDate; //修改日期
        objvgs_PSocialRelaENT.updUser = objvgs_PSocialRelaENS.updUser; //修改人
        objvgs_PSocialRelaENT.memo = objvgs_PSocialRelaENS.memo; //备注
        objvgs_PSocialRelaENT.fullName = objvgs_PSocialRelaENS.fullName; //姓名
        objvgs_PSocialRelaENT.nationality = objvgs_PSocialRelaENS.nationality; //国籍
        objvgs_PSocialRelaENT.workUnit = objvgs_PSocialRelaENS.workUnit; //工作单位
        objvgs_PSocialRelaENT.major = objvgs_PSocialRelaENS.major; //专业
        objvgs_PSocialRelaENT.achievement = objvgs_PSocialRelaENS.achievement; //成就
        objvgs_PSocialRelaENT.detailedDescription = objvgs_PSocialRelaENS.detailedDescription; //详细说明
        objvgs_PSocialRelaENT.levelId = objvgs_PSocialRelaENS.levelId; //级别Id
        objvgs_PSocialRelaENT.levelName = objvgs_PSocialRelaENS.levelName; //级别名称
        objvgs_PSocialRelaENT.isSubmit = objvgs_PSocialRelaENS.isSubmit; //是否提交
        objvgs_PSocialRelaENT.okCount = objvgs_PSocialRelaENS.okCount; //点赞统计
        objvgs_PSocialRelaENT.citationCount = objvgs_PSocialRelaENS.citationCount; //引用统计
        objvgs_PSocialRelaENT.versionCount = objvgs_PSocialRelaENS.versionCount; //版本统计
        objvgs_PSocialRelaENT.appraiseCount = objvgs_PSocialRelaENS.appraiseCount; //评论数
        objvgs_PSocialRelaENT.score = objvgs_PSocialRelaENS.score; //评分
        objvgs_PSocialRelaENT.stuScore = objvgs_PSocialRelaENS.stuScore; //学生平均分
        objvgs_PSocialRelaENT.teaScore = objvgs_PSocialRelaENS.teaScore; //教师评分
        objvgs_PSocialRelaENT.socialUserId = objvgs_PSocialRelaENS.socialUserId; //SocialUserId
        objvgs_PSocialRelaENT.socialDate = objvgs_PSocialRelaENS.socialDate; //SocialDate
        objvgs_PSocialRelaENT.createDate = objvgs_PSocialRelaENS.createDate; //建立日期
        objvgs_PSocialRelaENT.shareId = objvgs_PSocialRelaENS.shareId; //分享Id
    }
    exports.vgs_PSocialRela_CopyObjTo = vgs_PSocialRela_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objvgs_PSocialRelaENS:源对象
     * @param objvgs_PSocialRelaENT:目标对象
    */
    function vgs_PSocialRela_GetObjFromJsonObj(objvgs_PSocialRelaENS) {
        const objvgs_PSocialRelaENT = new clsvgs_PSocialRelaEN_js_1.clsvgs_PSocialRelaEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvgs_PSocialRelaENT, objvgs_PSocialRelaENS);
        return objvgs_PSocialRelaENT;
    }
    exports.vgs_PSocialRela_GetObjFromJsonObj = vgs_PSocialRela_GetObjFromJsonObj;
});
