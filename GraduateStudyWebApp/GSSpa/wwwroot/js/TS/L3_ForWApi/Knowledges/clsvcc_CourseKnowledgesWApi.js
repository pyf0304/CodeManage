/**
* 类名:clsvcc_CourseKnowledgesWApi
* 表名:vcc_CourseKnowledges(01120141)
* 生成代码版本:2022.11.02.1
* 生成日期:2022/11/02 12:02:24
* 生成者:pyf
* 生成服务器IP:
工程名称:问卷调查(0112)
CM工程:研究生论文学习(变量首字母小写)-全部函数集
* 相关数据库:103.116.76.183,9433EduHigh_Jsie
* PrjDataBaseId:0170
模块中文名:知识点相关(Knowledges)
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
        define(["require", "exports", "axios", "../../L0_Entity/Knowledges/clsvcc_CourseKnowledgesEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsSysPara4WebApi.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.vcc_CourseKnowledges_GetObjFromJsonObj = exports.vcc_CourseKnowledges_CopyObjTo = exports.vcc_CourseKnowledges_GetCombineCondition = exports.vcc_CourseKnowledges_GetObjByJSONStr = exports.vcc_CourseKnowledges_GetObjLstByJSONObjLst = exports.vcc_CourseKnowledges_GetObjLstByJSONStr = exports.vcc_CourseKnowledges_GetJSONStrByObj = exports.vcc_CourseKnowledges_GetWebApiUrl = exports.vcc_CourseKnowledges_GetRecCountByCondAsync = exports.vcc_CourseKnowledges_IsExistAsync = exports.vcc_CourseKnowledges_IsExist = exports.vcc_CourseKnowledges_IsExistRecordAsync = exports.vcc_CourseKnowledges_GetObjLstByPagerAsync = exports.vcc_CourseKnowledges_GetObjLstByRange = exports.vcc_CourseKnowledges_GetObjLstByRangeAsync = exports.vcc_CourseKnowledges_GetTopObjLstAsync = exports.vcc_CourseKnowledges_GetObjLstByCourseKnowledgeIdLstAsync = exports.vcc_CourseKnowledges_GetObjLstAsync = exports.vcc_CourseKnowledges_GetFirstObjAsync = exports.vcc_CourseKnowledges_GetFirstID = exports.vcc_CourseKnowledges_GetFirstIDAsync = exports.vcc_CourseKnowledges_FilterFunByKey = exports.vcc_CourseKnowledges_SortFunByKey = exports.vcc_CourseKnowledges_SortFun_Defa_2Fld = exports.vcc_CourseKnowledges_SortFun_Defa = exports.vcc_CourseKnowledges_GetObjByCourseKnowledgeIdAsync = exports.vcc_CourseKnowledges_ConstructorName = exports.vcc_CourseKnowledges_Controller = void 0;
    /**
     * v课程知识点(vcc_CourseKnowledges)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2022年11月02日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const clsvcc_CourseKnowledgesEN_js_1 = require("../../L0_Entity/Knowledges/clsvcc_CourseKnowledgesEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.vcc_CourseKnowledges_Controller = "vcc_CourseKnowledgesApi";
    exports.vcc_CourseKnowledges_ConstructorName = "vcc_CourseKnowledges";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strCourseKnowledgeId:关键字
    * @returns 对象
    **/
    async function vcc_CourseKnowledges_GetObjByCourseKnowledgeIdAsync(strCourseKnowledgeId) {
        const strThisFuncName = "GetObjByCourseKnowledgeIdAsync";
        if ((0, clsString_js_1.IsNullOrEmpty)(strCourseKnowledgeId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strCourseKnowledgeId]不能为空！(In GetObjByCourseKnowledgeIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strCourseKnowledgeId.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strCourseKnowledgeId]的长度:[{0}]不正确！", strCourseKnowledgeId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByCourseKnowledgeId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vcc_CourseKnowledges_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "strCourseKnowledgeId": strCourseKnowledgeId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vcc_CourseKnowledges_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objvcc_CourseKnowledges = vcc_CourseKnowledges_GetObjFromJsonObj(returnObj);
                return objvcc_CourseKnowledges;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vcc_CourseKnowledges_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vcc_CourseKnowledges_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vcc_CourseKnowledges_GetObjByCourseKnowledgeIdAsync = vcc_CourseKnowledges_GetObjByCourseKnowledgeIdAsync;
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
    function vcc_CourseKnowledges_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.courseKnowledgeId.localeCompare(b.courseKnowledgeId);
    }
    exports.vcc_CourseKnowledges_SortFun_Defa = vcc_CourseKnowledges_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vcc_CourseKnowledges_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.knowledgeName == b.knowledgeName)
            return a.knowledgeTitle.localeCompare(b.knowledgeTitle);
        else
            return a.knowledgeName.localeCompare(b.knowledgeName);
    }
    exports.vcc_CourseKnowledges_SortFun_Defa_2Fld = vcc_CourseKnowledges_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vcc_CourseKnowledges_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_CourseKnowledgeId:
                    return (a, b) => {
                        return a.courseKnowledgeId.localeCompare(b.courseKnowledgeId);
                    };
                case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_KnowledgeName:
                    return (a, b) => {
                        return a.knowledgeName.localeCompare(b.knowledgeName);
                    };
                case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_KnowledgeTitle:
                    return (a, b) => {
                        return a.knowledgeTitle.localeCompare(b.knowledgeTitle);
                    };
                case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_KnowledgeContent:
                    return (a, b) => {
                        return a.knowledgeContent.localeCompare(b.knowledgeContent);
                    };
                case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_CourseId:
                    return (a, b) => {
                        return a.courseId.localeCompare(b.courseId);
                    };
                case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_CourseCode:
                    return (a, b) => {
                        return a.courseCode.localeCompare(b.courseCode);
                    };
                case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_CourseName:
                    return (a, b) => {
                        return a.courseName.localeCompare(b.courseName);
                    };
                case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_CourseChapterId:
                    return (a, b) => {
                        return a.courseChapterId.localeCompare(b.courseChapterId);
                    };
                case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_UserId:
                    return (a, b) => {
                        return a.userId.localeCompare(b.userId);
                    };
                case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_ChapterId:
                    return (a, b) => {
                        return a.chapterId.localeCompare(b.chapterId);
                    };
                case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_UploadDate:
                    return (a, b) => {
                        return a.uploadDate.localeCompare(b.uploadDate);
                    };
                case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_SectionId:
                    return (a, b) => {
                        return a.sectionId.localeCompare(b.sectionId);
                    };
                case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_IsShow:
                    return (a, b) => {
                        if (a.isShow == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_ChapterName:
                    return (a, b) => {
                        return a.chapterName.localeCompare(b.chapterName);
                    };
                case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_IsCast:
                    return (a, b) => {
                        if (a.isCast == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_SectionName:
                    return (a, b) => {
                        return a.sectionName.localeCompare(b.sectionName);
                    };
                case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_LikeCount:
                    return (a, b) => {
                        return a.likeCount - b.likeCount;
                    };
                case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_ChapterName_Sim:
                    return (a, b) => {
                        return a.chapterName_Sim.localeCompare(b.chapterName_Sim);
                    };
                case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_UpdDate:
                    return (a, b) => {
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_SectionName_Sim:
                    return (a, b) => {
                        return a.sectionName_Sim.localeCompare(b.sectionName_Sim);
                    };
                case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_Memo:
                    return (a, b) => {
                        return a.memo.localeCompare(b.memo);
                    };
                case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_QuestionNum:
                    return (a, b) => {
                        return a.questionNum - b.questionNum;
                    };
                case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_OrderNum:
                    return (a, b) => {
                        return a.orderNum - b.orderNum;
                    };
                case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_UpdUser:
                    return (a, b) => {
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_KnowledgeTypeId:
                    return (a, b) => {
                        return a.knowledgeTypeId.localeCompare(b.knowledgeTypeId);
                    };
                case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_KnowledgeTypeName:
                    return (a, b) => {
                        return a.knowledgeTypeName.localeCompare(b.knowledgeTypeName);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vcc_CourseKnowledges]中不存在！(in ${exports.vcc_CourseKnowledges_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_CourseKnowledgeId:
                    return (a, b) => {
                        return b.courseKnowledgeId.localeCompare(a.courseKnowledgeId);
                    };
                case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_KnowledgeName:
                    return (a, b) => {
                        return b.knowledgeName.localeCompare(a.knowledgeName);
                    };
                case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_KnowledgeTitle:
                    return (a, b) => {
                        return b.knowledgeTitle.localeCompare(a.knowledgeTitle);
                    };
                case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_KnowledgeContent:
                    return (a, b) => {
                        return b.knowledgeContent.localeCompare(a.knowledgeContent);
                    };
                case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_CourseId:
                    return (a, b) => {
                        return b.courseId.localeCompare(a.courseId);
                    };
                case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_CourseCode:
                    return (a, b) => {
                        return b.courseCode.localeCompare(a.courseCode);
                    };
                case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_CourseName:
                    return (a, b) => {
                        return b.courseName.localeCompare(a.courseName);
                    };
                case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_CourseChapterId:
                    return (a, b) => {
                        return b.courseChapterId.localeCompare(a.courseChapterId);
                    };
                case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_UserId:
                    return (a, b) => {
                        return b.userId.localeCompare(a.userId);
                    };
                case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_ChapterId:
                    return (a, b) => {
                        return b.chapterId.localeCompare(a.chapterId);
                    };
                case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_UploadDate:
                    return (a, b) => {
                        return b.uploadDate.localeCompare(a.uploadDate);
                    };
                case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_SectionId:
                    return (a, b) => {
                        return b.sectionId.localeCompare(a.sectionId);
                    };
                case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_IsShow:
                    return (a, b) => {
                        if (b.isShow == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_ChapterName:
                    return (a, b) => {
                        return b.chapterName.localeCompare(a.chapterName);
                    };
                case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_IsCast:
                    return (a, b) => {
                        if (b.isCast == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_SectionName:
                    return (a, b) => {
                        return b.sectionName.localeCompare(a.sectionName);
                    };
                case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_LikeCount:
                    return (a, b) => {
                        return b.likeCount - a.likeCount;
                    };
                case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_ChapterName_Sim:
                    return (a, b) => {
                        return b.chapterName_Sim.localeCompare(a.chapterName_Sim);
                    };
                case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_UpdDate:
                    return (a, b) => {
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_SectionName_Sim:
                    return (a, b) => {
                        return b.sectionName_Sim.localeCompare(a.sectionName_Sim);
                    };
                case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_Memo:
                    return (a, b) => {
                        return b.memo.localeCompare(a.memo);
                    };
                case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_QuestionNum:
                    return (a, b) => {
                        return b.questionNum - a.questionNum;
                    };
                case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_OrderNum:
                    return (a, b) => {
                        return b.orderNum - a.orderNum;
                    };
                case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_UpdUser:
                    return (a, b) => {
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_KnowledgeTypeId:
                    return (a, b) => {
                        return b.knowledgeTypeId.localeCompare(a.knowledgeTypeId);
                    };
                case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_KnowledgeTypeName:
                    return (a, b) => {
                        return b.knowledgeTypeName.localeCompare(a.knowledgeTypeName);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vcc_CourseKnowledges]中不存在！(in ${exports.vcc_CourseKnowledges_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.vcc_CourseKnowledges_SortFunByKey = vcc_CourseKnowledges_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function vcc_CourseKnowledges_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_CourseKnowledgeId:
                return (obj) => {
                    return obj.courseKnowledgeId === value;
                };
            case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_KnowledgeName:
                return (obj) => {
                    return obj.knowledgeName === value;
                };
            case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_KnowledgeTitle:
                return (obj) => {
                    return obj.knowledgeTitle === value;
                };
            case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_KnowledgeContent:
                return (obj) => {
                    return obj.knowledgeContent === value;
                };
            case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_CourseId:
                return (obj) => {
                    return obj.courseId === value;
                };
            case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_CourseCode:
                return (obj) => {
                    return obj.courseCode === value;
                };
            case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_CourseName:
                return (obj) => {
                    return obj.courseName === value;
                };
            case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_CourseChapterId:
                return (obj) => {
                    return obj.courseChapterId === value;
                };
            case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_UserId:
                return (obj) => {
                    return obj.userId === value;
                };
            case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_ChapterId:
                return (obj) => {
                    return obj.chapterId === value;
                };
            case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_UploadDate:
                return (obj) => {
                    return obj.uploadDate === value;
                };
            case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_SectionId:
                return (obj) => {
                    return obj.sectionId === value;
                };
            case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_IsShow:
                return (obj) => {
                    return obj.isShow === value;
                };
            case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_ChapterName:
                return (obj) => {
                    return obj.chapterName === value;
                };
            case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_IsCast:
                return (obj) => {
                    return obj.isCast === value;
                };
            case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_SectionName:
                return (obj) => {
                    return obj.sectionName === value;
                };
            case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_LikeCount:
                return (obj) => {
                    return obj.likeCount === value;
                };
            case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_ChapterName_Sim:
                return (obj) => {
                    return obj.chapterName_Sim === value;
                };
            case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_SectionName_Sim:
                return (obj) => {
                    return obj.sectionName_Sim === value;
                };
            case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_QuestionNum:
                return (obj) => {
                    return obj.questionNum === value;
                };
            case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_OrderNum:
                return (obj) => {
                    return obj.orderNum === value;
                };
            case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_KnowledgeTypeId:
                return (obj) => {
                    return obj.knowledgeTypeId === value;
                };
            case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_KnowledgeTypeName:
                return (obj) => {
                    return obj.knowledgeTypeName === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[vcc_CourseKnowledges]中不存在！(in ${exports.vcc_CourseKnowledges_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.vcc_CourseKnowledges_FilterFunByKey = vcc_CourseKnowledges_FilterFunByKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function vcc_CourseKnowledges_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vcc_CourseKnowledges_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vcc_CourseKnowledges_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vcc_CourseKnowledges_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vcc_CourseKnowledges_GetFirstIDAsync = vcc_CourseKnowledges_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function vcc_CourseKnowledges_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vcc_CourseKnowledges_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vcc_CourseKnowledges_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vcc_CourseKnowledges_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vcc_CourseKnowledges_GetFirstID = vcc_CourseKnowledges_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function vcc_CourseKnowledges_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vcc_CourseKnowledges_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vcc_CourseKnowledges_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objvcc_CourseKnowledges = vcc_CourseKnowledges_GetObjFromJsonObj(returnObj);
                return objvcc_CourseKnowledges;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vcc_CourseKnowledges_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vcc_CourseKnowledges_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vcc_CourseKnowledges_GetFirstObjAsync = vcc_CourseKnowledges_GetFirstObjAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function vcc_CourseKnowledges_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vcc_CourseKnowledges_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vcc_CourseKnowledges_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vcc_CourseKnowledges_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vcc_CourseKnowledges_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vcc_CourseKnowledges_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vcc_CourseKnowledges_GetObjLstAsync = vcc_CourseKnowledges_GetObjLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrCourseKnowledgeId:关键字列表
    * @returns 对象列表
    **/
    async function vcc_CourseKnowledges_GetObjLstByCourseKnowledgeIdLstAsync(arrCourseKnowledgeId) {
        const strThisFuncName = "GetObjLstByCourseKnowledgeIdLstAsync";
        const strAction = "GetObjLstByCourseKnowledgeIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vcc_CourseKnowledges_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrCourseKnowledgeId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vcc_CourseKnowledges_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vcc_CourseKnowledges_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vcc_CourseKnowledges_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vcc_CourseKnowledges_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vcc_CourseKnowledges_GetObjLstByCourseKnowledgeIdLstAsync = vcc_CourseKnowledges_GetObjLstByCourseKnowledgeIdLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function vcc_CourseKnowledges_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vcc_CourseKnowledges_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vcc_CourseKnowledges_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vcc_CourseKnowledges_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vcc_CourseKnowledges_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vcc_CourseKnowledges_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vcc_CourseKnowledges_GetTopObjLstAsync = vcc_CourseKnowledges_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vcc_CourseKnowledges_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vcc_CourseKnowledges_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vcc_CourseKnowledges_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vcc_CourseKnowledges_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vcc_CourseKnowledges_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vcc_CourseKnowledges_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vcc_CourseKnowledges_GetObjLstByRangeAsync = vcc_CourseKnowledges_GetObjLstByRangeAsync;
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
    async function vcc_CourseKnowledges_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vcc_CourseKnowledges_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vcc_CourseKnowledges_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vcc_CourseKnowledges_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vcc_CourseKnowledges_GetObjLstByRange = vcc_CourseKnowledges_GetObjLstByRange;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vcc_CourseKnowledges_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vcc_CourseKnowledges_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vcc_CourseKnowledges_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vcc_CourseKnowledges_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vcc_CourseKnowledges_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vcc_CourseKnowledges_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vcc_CourseKnowledges_GetObjLstByPagerAsync = vcc_CourseKnowledges_GetObjLstByPagerAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function vcc_CourseKnowledges_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vcc_CourseKnowledges_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vcc_CourseKnowledges_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vcc_CourseKnowledges_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vcc_CourseKnowledges_IsExistRecordAsync = vcc_CourseKnowledges_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strCourseKnowledgeId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function vcc_CourseKnowledges_IsExist(strCourseKnowledgeId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vcc_CourseKnowledges_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "CourseKnowledgeId": strCourseKnowledgeId,
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vcc_CourseKnowledges_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vcc_CourseKnowledges_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vcc_CourseKnowledges_IsExist = vcc_CourseKnowledges_IsExist;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strCourseKnowledgeId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function vcc_CourseKnowledges_IsExistAsync(strCourseKnowledgeId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vcc_CourseKnowledges_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strCourseKnowledgeId": strCourseKnowledgeId }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vcc_CourseKnowledges_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vcc_CourseKnowledges_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vcc_CourseKnowledges_IsExistAsync = vcc_CourseKnowledges_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function vcc_CourseKnowledges_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vcc_CourseKnowledges_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vcc_CourseKnowledges_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vcc_CourseKnowledges_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vcc_CourseKnowledges_GetRecCountByCondAsync = vcc_CourseKnowledges_GetRecCountByCondAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function vcc_CourseKnowledges_GetWebApiUrl(strController, strAction) {
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
    exports.vcc_CourseKnowledges_GetWebApiUrl = vcc_CourseKnowledges_GetWebApiUrl;
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
    function vcc_CourseKnowledges_GetJSONStrByObj(pobjvcc_CourseKnowledgesEN) {
        const strThisFuncName = "GetJSONStrByObj";
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjvcc_CourseKnowledgesEN);
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
    exports.vcc_CourseKnowledges_GetJSONStrByObj = vcc_CourseKnowledges_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function vcc_CourseKnowledges_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrvcc_CourseKnowledgesObjLst = new Array();
        if (strJSON === "") {
            return arrvcc_CourseKnowledgesObjLst;
        }
        try {
            arrvcc_CourseKnowledgesObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrvcc_CourseKnowledgesObjLst;
        }
        return arrvcc_CourseKnowledgesObjLst;
    }
    exports.vcc_CourseKnowledges_GetObjLstByJSONStr = vcc_CourseKnowledges_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrvcc_CourseKnowledgesObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function vcc_CourseKnowledges_GetObjLstByJSONObjLst(arrvcc_CourseKnowledgesObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrvcc_CourseKnowledgesObjLst = new Array();
        for (const objInFor of arrvcc_CourseKnowledgesObjLstS) {
            const obj1 = vcc_CourseKnowledges_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrvcc_CourseKnowledgesObjLst.push(obj1);
        }
        return arrvcc_CourseKnowledgesObjLst;
    }
    exports.vcc_CourseKnowledges_GetObjLstByJSONObjLst = vcc_CourseKnowledges_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vcc_CourseKnowledges_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjvcc_CourseKnowledgesEN = new clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN();
        if (strJSON === "") {
            return pobjvcc_CourseKnowledgesEN;
        }
        try {
            pobjvcc_CourseKnowledgesEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjvcc_CourseKnowledgesEN;
        }
        return pobjvcc_CourseKnowledgesEN;
    }
    exports.vcc_CourseKnowledges_GetObjByJSONStr = vcc_CourseKnowledges_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function vcc_CourseKnowledges_GetCombineCondition(objvcc_CourseKnowledges_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseKnowledges_Cond.dicFldComparisonOp, clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_CourseKnowledgeId) == true) {
            const strComparisonOp_CourseKnowledgeId = objvcc_CourseKnowledges_Cond.dicFldComparisonOp[clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_CourseKnowledgeId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_CourseKnowledgeId, objvcc_CourseKnowledges_Cond.courseKnowledgeId, strComparisonOp_CourseKnowledgeId);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseKnowledges_Cond.dicFldComparisonOp, clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_KnowledgeName) == true) {
            const strComparisonOp_KnowledgeName = objvcc_CourseKnowledges_Cond.dicFldComparisonOp[clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_KnowledgeName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_KnowledgeName, objvcc_CourseKnowledges_Cond.knowledgeName, strComparisonOp_KnowledgeName);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseKnowledges_Cond.dicFldComparisonOp, clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_KnowledgeTitle) == true) {
            const strComparisonOp_KnowledgeTitle = objvcc_CourseKnowledges_Cond.dicFldComparisonOp[clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_KnowledgeTitle];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_KnowledgeTitle, objvcc_CourseKnowledges_Cond.knowledgeTitle, strComparisonOp_KnowledgeTitle);
        }
        //数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseKnowledges_Cond.dicFldComparisonOp, clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_CourseId) == true) {
            const strComparisonOp_CourseId = objvcc_CourseKnowledges_Cond.dicFldComparisonOp[clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_CourseId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_CourseId, objvcc_CourseKnowledges_Cond.courseId, strComparisonOp_CourseId);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseKnowledges_Cond.dicFldComparisonOp, clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_CourseCode) == true) {
            const strComparisonOp_CourseCode = objvcc_CourseKnowledges_Cond.dicFldComparisonOp[clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_CourseCode];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_CourseCode, objvcc_CourseKnowledges_Cond.courseCode, strComparisonOp_CourseCode);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseKnowledges_Cond.dicFldComparisonOp, clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_CourseName) == true) {
            const strComparisonOp_CourseName = objvcc_CourseKnowledges_Cond.dicFldComparisonOp[clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_CourseName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_CourseName, objvcc_CourseKnowledges_Cond.courseName, strComparisonOp_CourseName);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseKnowledges_Cond.dicFldComparisonOp, clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_CourseChapterId) == true) {
            const strComparisonOp_CourseChapterId = objvcc_CourseKnowledges_Cond.dicFldComparisonOp[clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_CourseChapterId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_CourseChapterId, objvcc_CourseKnowledges_Cond.courseChapterId, strComparisonOp_CourseChapterId);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseKnowledges_Cond.dicFldComparisonOp, clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_UserId) == true) {
            const strComparisonOp_UserId = objvcc_CourseKnowledges_Cond.dicFldComparisonOp[clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_UserId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_UserId, objvcc_CourseKnowledges_Cond.userId, strComparisonOp_UserId);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseKnowledges_Cond.dicFldComparisonOp, clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_ChapterId) == true) {
            const strComparisonOp_ChapterId = objvcc_CourseKnowledges_Cond.dicFldComparisonOp[clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_ChapterId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_ChapterId, objvcc_CourseKnowledges_Cond.chapterId, strComparisonOp_ChapterId);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseKnowledges_Cond.dicFldComparisonOp, clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_UploadDate) == true) {
            const strComparisonOp_UploadDate = objvcc_CourseKnowledges_Cond.dicFldComparisonOp[clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_UploadDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_UploadDate, objvcc_CourseKnowledges_Cond.uploadDate, strComparisonOp_UploadDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseKnowledges_Cond.dicFldComparisonOp, clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_SectionId) == true) {
            const strComparisonOp_SectionId = objvcc_CourseKnowledges_Cond.dicFldComparisonOp[clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_SectionId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_SectionId, objvcc_CourseKnowledges_Cond.sectionId, strComparisonOp_SectionId);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseKnowledges_Cond.dicFldComparisonOp, clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_IsShow) == true) {
            if (objvcc_CourseKnowledges_Cond.isShow == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_IsShow);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_IsShow);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseKnowledges_Cond.dicFldComparisonOp, clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_ChapterName) == true) {
            const strComparisonOp_ChapterName = objvcc_CourseKnowledges_Cond.dicFldComparisonOp[clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_ChapterName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_ChapterName, objvcc_CourseKnowledges_Cond.chapterName, strComparisonOp_ChapterName);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseKnowledges_Cond.dicFldComparisonOp, clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_IsCast) == true) {
            if (objvcc_CourseKnowledges_Cond.isCast == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_IsCast);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_IsCast);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseKnowledges_Cond.dicFldComparisonOp, clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_SectionName) == true) {
            const strComparisonOp_SectionName = objvcc_CourseKnowledges_Cond.dicFldComparisonOp[clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_SectionName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_SectionName, objvcc_CourseKnowledges_Cond.sectionName, strComparisonOp_SectionName);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseKnowledges_Cond.dicFldComparisonOp, clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_LikeCount) == true) {
            const strComparisonOp_LikeCount = objvcc_CourseKnowledges_Cond.dicFldComparisonOp[clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_LikeCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_LikeCount, objvcc_CourseKnowledges_Cond.likeCount, strComparisonOp_LikeCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseKnowledges_Cond.dicFldComparisonOp, clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_ChapterName_Sim) == true) {
            const strComparisonOp_ChapterName_Sim = objvcc_CourseKnowledges_Cond.dicFldComparisonOp[clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_ChapterName_Sim];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_ChapterName_Sim, objvcc_CourseKnowledges_Cond.chapterName_Sim, strComparisonOp_ChapterName_Sim);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseKnowledges_Cond.dicFldComparisonOp, clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objvcc_CourseKnowledges_Cond.dicFldComparisonOp[clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_UpdDate, objvcc_CourseKnowledges_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseKnowledges_Cond.dicFldComparisonOp, clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_SectionName_Sim) == true) {
            const strComparisonOp_SectionName_Sim = objvcc_CourseKnowledges_Cond.dicFldComparisonOp[clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_SectionName_Sim];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_SectionName_Sim, objvcc_CourseKnowledges_Cond.sectionName_Sim, strComparisonOp_SectionName_Sim);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseKnowledges_Cond.dicFldComparisonOp, clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_Memo) == true) {
            const strComparisonOp_Memo = objvcc_CourseKnowledges_Cond.dicFldComparisonOp[clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_Memo, objvcc_CourseKnowledges_Cond.memo, strComparisonOp_Memo);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseKnowledges_Cond.dicFldComparisonOp, clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_QuestionNum) == true) {
            const strComparisonOp_QuestionNum = objvcc_CourseKnowledges_Cond.dicFldComparisonOp[clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_QuestionNum];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_QuestionNum, objvcc_CourseKnowledges_Cond.questionNum, strComparisonOp_QuestionNum);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseKnowledges_Cond.dicFldComparisonOp, clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_OrderNum) == true) {
            const strComparisonOp_OrderNum = objvcc_CourseKnowledges_Cond.dicFldComparisonOp[clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_OrderNum];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_OrderNum, objvcc_CourseKnowledges_Cond.orderNum, strComparisonOp_OrderNum);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseKnowledges_Cond.dicFldComparisonOp, clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objvcc_CourseKnowledges_Cond.dicFldComparisonOp[clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_UpdUser];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_UpdUser, objvcc_CourseKnowledges_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseKnowledges_Cond.dicFldComparisonOp, clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_KnowledgeTypeId) == true) {
            const strComparisonOp_KnowledgeTypeId = objvcc_CourseKnowledges_Cond.dicFldComparisonOp[clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_KnowledgeTypeId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_KnowledgeTypeId, objvcc_CourseKnowledges_Cond.knowledgeTypeId, strComparisonOp_KnowledgeTypeId);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseKnowledges_Cond.dicFldComparisonOp, clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_KnowledgeTypeName) == true) {
            const strComparisonOp_KnowledgeTypeName = objvcc_CourseKnowledges_Cond.dicFldComparisonOp[clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_KnowledgeTypeName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_KnowledgeTypeName, objvcc_CourseKnowledges_Cond.knowledgeTypeName, strComparisonOp_KnowledgeTypeName);
        }
        return strWhereCond;
    }
    exports.vcc_CourseKnowledges_GetCombineCondition = vcc_CourseKnowledges_GetCombineCondition;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objvcc_CourseKnowledgesENS:源对象
     * @param objvcc_CourseKnowledgesENT:目标对象
    */
    function vcc_CourseKnowledges_CopyObjTo(objvcc_CourseKnowledgesENS, objvcc_CourseKnowledgesENT) {
        objvcc_CourseKnowledgesENT.courseKnowledgeId = objvcc_CourseKnowledgesENS.courseKnowledgeId; //知识点Id
        objvcc_CourseKnowledgesENT.knowledgeName = objvcc_CourseKnowledgesENS.knowledgeName; //知识点名称
        objvcc_CourseKnowledgesENT.knowledgeTitle = objvcc_CourseKnowledgesENS.knowledgeTitle; //知识点标题
        objvcc_CourseKnowledgesENT.knowledgeContent = objvcc_CourseKnowledgesENS.knowledgeContent; //知识点内容
        objvcc_CourseKnowledgesENT.courseId = objvcc_CourseKnowledgesENS.courseId; //课程Id
        objvcc_CourseKnowledgesENT.courseCode = objvcc_CourseKnowledgesENS.courseCode; //课程代码
        objvcc_CourseKnowledgesENT.courseName = objvcc_CourseKnowledgesENS.courseName; //课程名称
        objvcc_CourseKnowledgesENT.courseChapterId = objvcc_CourseKnowledgesENS.courseChapterId; //课程章节ID
        objvcc_CourseKnowledgesENT.userId = objvcc_CourseKnowledgesENS.userId; //用户ID
        objvcc_CourseKnowledgesENT.chapterId = objvcc_CourseKnowledgesENS.chapterId; //章Id
        objvcc_CourseKnowledgesENT.uploadDate = objvcc_CourseKnowledgesENS.uploadDate; //上传时间
        objvcc_CourseKnowledgesENT.sectionId = objvcc_CourseKnowledgesENS.sectionId; //节Id
        objvcc_CourseKnowledgesENT.isShow = objvcc_CourseKnowledgesENS.isShow; //是否启用
        objvcc_CourseKnowledgesENT.chapterName = objvcc_CourseKnowledgesENS.chapterName; //章名
        objvcc_CourseKnowledgesENT.isCast = objvcc_CourseKnowledgesENS.isCast; //是否播放
        objvcc_CourseKnowledgesENT.sectionName = objvcc_CourseKnowledgesENS.sectionName; //节名
        objvcc_CourseKnowledgesENT.likeCount = objvcc_CourseKnowledgesENS.likeCount; //资源喜欢数量
        objvcc_CourseKnowledgesENT.chapterName_Sim = objvcc_CourseKnowledgesENS.chapterName_Sim; //章名简称
        objvcc_CourseKnowledgesENT.updDate = objvcc_CourseKnowledgesENS.updDate; //修改日期
        objvcc_CourseKnowledgesENT.sectionName_Sim = objvcc_CourseKnowledgesENS.sectionName_Sim; //节名简称
        objvcc_CourseKnowledgesENT.memo = objvcc_CourseKnowledgesENS.memo; //备注
        objvcc_CourseKnowledgesENT.questionNum = objvcc_CourseKnowledgesENS.questionNum; //题目数
        objvcc_CourseKnowledgesENT.orderNum = objvcc_CourseKnowledgesENS.orderNum; //序号
        objvcc_CourseKnowledgesENT.updUser = objvcc_CourseKnowledgesENS.updUser; //修改人
        objvcc_CourseKnowledgesENT.knowledgeTypeId = objvcc_CourseKnowledgesENS.knowledgeTypeId; //知识点类型Id
        objvcc_CourseKnowledgesENT.knowledgeTypeName = objvcc_CourseKnowledgesENS.knowledgeTypeName; //知识点类型名
    }
    exports.vcc_CourseKnowledges_CopyObjTo = vcc_CourseKnowledges_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objvcc_CourseKnowledgesENS:源对象
     * @param objvcc_CourseKnowledgesENT:目标对象
    */
    function vcc_CourseKnowledges_GetObjFromJsonObj(objvcc_CourseKnowledgesENS) {
        const objvcc_CourseKnowledgesENT = new clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvcc_CourseKnowledgesENT, objvcc_CourseKnowledgesENS);
        return objvcc_CourseKnowledgesENT;
    }
    exports.vcc_CourseKnowledges_GetObjFromJsonObj = vcc_CourseKnowledges_GetObjFromJsonObj;
});
